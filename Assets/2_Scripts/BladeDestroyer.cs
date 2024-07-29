using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {

            Destroy(collision.gameObject);
        }
    }
}
