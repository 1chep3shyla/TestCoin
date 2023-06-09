using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField]
    private Renderer objectRenderer;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Randomixe();
        }
    }

    private void Randomixe()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        objectRenderer.material.color = randomColor;
    }
}