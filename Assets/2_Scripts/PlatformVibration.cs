using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformVibration : MonoBehaviour
{
    //public float vibrationStrength = 0.1f;
    //public float vibrationDuration = 0.1f;
    //public bool platformStick = false;
    //public bool vibrationEnabled = true;

    //private Vector3 originalPosition;

    //private void Start()
    //{
    //    originalPosition = transform.position;
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        VibratePlatform();
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Player")&& vibrationEnabled == true)
        //{
        //    VibratePlatform();
        //}
        if (collision.gameObject.CompareTag("Player") )
        {
            collision.transform.SetParent(this.transform);
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            playerRb.interpolation = RigidbodyInterpolation2D.None;
            Debug.Log("Player Enter");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            playerRb.interpolation = RigidbodyInterpolation2D.Interpolate;
            Debug.Log("Player Exit");

        }
    }

    //private void VibratePlatform()
    //{
    //    transform.DOMoveY(originalPosition.y + Random.Range(-vibrationStrength, vibrationStrength), vibrationDuration)
    //        .SetEase(Ease.OutBack) // Adjust ease for desired vibration style
    //        .OnComplete(() => transform.DOMoveY(originalPosition.y, vibrationDuration * 0.5f).SetEase(Ease.Linear)) // Reset to original position
    //        .Play();
    //}

}
