using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject player;
    private Rigidbody2D rb2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2 = player.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            player.transform.localPosition = spawnPoint.transform.localPosition;

        }
    }
}