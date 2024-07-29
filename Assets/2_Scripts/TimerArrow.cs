using DG.Tweening;
using System.Collections;
using UnityEngine;

public class TimerArrow : MonoBehaviour
{
    [SerializeField] private Transform _arrow;
    [SerializeField] private float _fHight  , _iHight, _hideTime , _showTime , _animTime;
    [SerializeField] private Ease _ease = Ease.InOutBack;


    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ArrowShowHide());

        }
    }

    IEnumerator ArrowShowHide()
    {
        yield return new WaitForSeconds(_showTime);
        _arrow.DOLocalMoveY(_fHight, _animTime).SetEase(_ease);
        yield return new WaitForSeconds(_hideTime);
        _arrow.DOLocalMoveY(_iHight, _animTime).SetEase(_ease);


    }
}