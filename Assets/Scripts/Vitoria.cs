using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitoria : MonoBehaviour
{

    public GameObject player;

    /* Em Construção */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(-0.02f, -4.3f, 0);
        }
    }

}
