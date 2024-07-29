using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BladeFalling : MonoBehaviour
{
    [SerializeField] private float bladeSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * bladeSpeed * Time.deltaTime);
    }


}
