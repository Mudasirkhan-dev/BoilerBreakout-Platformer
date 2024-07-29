using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeLarger : MonoBehaviour
{
    [SerializeField] private Transform bladeTransform;
    [SerializeField] private bool BladeTrick = false;
    [SerializeField] private float scaleTime = 0.5f , endScale , initialScale;

    [SerializeField] private Ease Interpolations = Ease.Linear;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && BladeTrick)
        {
            bladeTransform.DOScale(endScale , scaleTime).SetEase(Interpolations);        
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && BladeTrick)
        {
            bladeTransform.DOScale(initialScale, scaleTime).SetEase(Interpolations);
        }
    }

}
