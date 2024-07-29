using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraOutFade : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private float maxLenzSize , minLenzSize , fadeTime;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            //virtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(minLenzSize, maxLenzSize , fadeTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //virtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(maxLenzSize, minLenzSize , fadeTime);
        }
    }
}

