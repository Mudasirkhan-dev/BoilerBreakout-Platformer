using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateWay : MonoBehaviour
{
    [SerializeField] private Transform Shutter;
    [SerializeField] private GameObject lightTop;
    [SerializeField] private float finalShutterPos , delayTime;
    [SerializeField] private int LevelIndex;

    SceneController sceneController;

    private void Start()
    {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            StartCoroutine(ActivateGateWay());
        } 
    }

    IEnumerator ActivateGateWay()
    {
        Shutter.DOLocalMoveY(finalShutterPos , 0.3f).SetEase(Ease.InOutQuint);
        lightTop.SetActive(true);
        yield return new WaitForSeconds(delayTime);
        sceneController.NextLevel(LevelIndex);
    }

}
