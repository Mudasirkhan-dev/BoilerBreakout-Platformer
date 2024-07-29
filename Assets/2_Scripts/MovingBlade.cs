using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlade : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform[] points;
    [SerializeField] private float duration = 1f;
    [SerializeField] private bool bladeMoveTF;

    [SerializeField] private Ease easeInterpolations;

    void Start()
    {
        if(bladeMoveTF)
        {
            Sequence sequence = DOTween.Sequence();

            foreach (Transform point in points)
            {
                sequence.Append(target.DOMove(point.position, duration).SetEase(easeInterpolations));
            }

            sequence.SetLoops(-1, LoopType.Yoyo);
        }
        else 
        {
            if (points.Length < 2)
            {
                Debug.LogWarning("At least two points are required for cyclic motion.");
                return;
            }

            Sequence sequence = DOTween.Sequence();

            for (int i = 0; i < points.Length; i++)
            {
                sequence.Append(target.DOMove(points[i].position, duration).SetEase(Ease.Linear));
            }

            sequence.SetLoops(-1, LoopType.Restart);
        }
    }
}
