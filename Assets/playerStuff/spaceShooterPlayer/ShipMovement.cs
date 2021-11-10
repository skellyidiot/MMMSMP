using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipMovement : MonoBehaviour
{
    //actual ship movement
    public float rotateScale;
    public float thrustScale;
    private Rigidbody2D rb2;

    //bullet movement
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;

    //game mechanics
    public int bulletCount;    
    public GameObject AmmoMask;
    public int xp;
    public Text XPtext;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        XPtext.text = "XP: " + xp.ToString();

        float rotation = Time.deltaTime * rotateScale * Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -rotation));

        float thrust = Time.deltaTime * thrustScale * Input.GetAxis("Vertical");
        rb2.AddForce(transform.up * thrust);

        if(Input.GetButtonDown("Fire1") ||  Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, transform.rotation);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            rb2bullet.AddForce(bulletSpeed * transform.up);
            Destroy(b, 5);
            bulletCount--;
            AmmoMask.GetComponent<MaskScript>().MoveMask(bulletCount, 10);
        }

        if (xp > 24)
        {
            SceneManager.LoadScene("endCredits");
        }

    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("EXIT");
            Application.Quit();
        }
    }
}
