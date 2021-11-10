using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallLoop : MonoBehaviour
{
    public GameObject edge;
    private SpriteRenderer sr;
    private float xvalue;
    private float yvalue;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);

        sr = edge.GetComponent<SpriteRenderer>();

        Debug.Log(sr.bounds.extents.x);
        Debug.Log(sr.bounds.extents.y);
    }

    // Update is called once per frame
    void Update()
    {
        xvalue = transform.position.x;
        yvalue = transform.position.y;

        if (transform.position.x > sr.bounds.extents.x)
        {
            //xvalue = -xvalue;
            transform.position = new Vector3(-xvalue, transform.position.y, 19);
        }
  
        if (transform.position.y > sr.bounds.extents.y)
        {
            //yvalue = -yvalue;
            transform.position = new Vector3(transform.position.x, -yvalue, 19);
        }

        if (transform.position.x < -sr.bounds.extents.x)
        {
            xvalue = -xvalue;
            transform.position = new Vector3(xvalue, transform.position.y, 19);
        }

        if (transform.position.y < -sr.bounds.extents.y)
        {
            yvalue = -yvalue;
            transform.position = new Vector3(transform.position.x, yvalue, 19);
        }
    }
}
