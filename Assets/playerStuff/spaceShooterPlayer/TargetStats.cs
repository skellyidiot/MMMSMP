using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStats : MonoBehaviour
{
    public int health;
    public int xp;
    public GameObject theShip;
    public GameObject enemy;

    private void Update()
    {
        if (health < 1)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            transform.localScale *= 0.5f;
            health--;
            theShip.GetComponent<ShipMovement>().xp += xp;
            xp++;
            Instantiate(enemy);
            Destroy(collision.gameObject);

        }
    }
}
