using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private Transform[] arrowTransforms;
    [SerializeField] private float[] appearTimes;
    [SerializeField] private float[] finalPositions;
    [SerializeField] private float delayBetweenArrows;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AppearArrows();
        }
    }

    public void AppearArrows()
    {
        StartCoroutine(AppearArrowsCoroutine());
    }

    private IEnumerator AppearArrowsCoroutine()
    {
        for (int i = 0; i < arrowTransforms.Length; i++)
        {
            if (arrowTransforms[i] != null)
            {
                arrowTransforms[i].DOLocalMoveY(finalPositions[i], appearTimes[i]).SetEase(Ease.InOutBack);
                yield return new WaitForSeconds(delayBetweenArrows);
            }
            else
            {
                Debug.LogWarning("Arrow Transform at index " + i + " is not assigned.");
            }
        }
    }
}
