using System.Collections;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    RespawnScript respawnScript;


    private void Awake()
    {
        respawnScript = GameObject.FindGameObjectWithTag("RespawnP").GetComponent<RespawnScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawnScript.DieAndSpawn();
        }
    }


}