using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bladePrefab;
    [SerializeField] private float spawnTime;
    [SerializeField] private Sprite activeSprite;
    [SerializeField] private Sprite inactiveSprite;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(SpawnBlade(spawnTime));
    }

    private IEnumerator SpawnBlade(float time)
    {
        while (true) 
        {
            spriteRenderer.sprite = activeSprite;
            yield return new WaitForSeconds(0.5f);
            Instantiate(bladePrefab.gameObject , gameObject.transform.position, gameObject.transform.rotation);
            spriteRenderer.sprite = inactiveSprite;
            yield return new WaitForSeconds(time);
        }
    }


}
