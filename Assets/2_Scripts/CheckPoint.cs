using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public SpriteRenderer _color;
    public GameObject _light;
    public bool backTracking = false;

    private RespawnScript respawn;
    private BoxCollider2D checkPointCollider;




    private void Awake()
    {
        checkPointCollider = GetComponent<BoxCollider2D>();
        respawn = GameObject.FindGameObjectWithTag("RespawnP").GetComponent<RespawnScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawn.respawnPoint = this.gameObject;

            if(backTracking)
            {
                checkPointCollider.enabled = false;
            }

            _color.DOColor(Color.HSVToRGB(0 ,0 ,100) , 0.5f);
            _light.SetActive(true);
        }
    }



}
