using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeTrap : MonoBehaviour
{
    RespawnScript respawnScript;


    private void Awake()
    {
        respawnScript = GameObject.FindGameObjectWithTag("RespawnP").GetComponent<RespawnScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            respawnScript.DieAndSpawn();

        }
    }
}
