using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacleController : MonoBehaviour
{
    public float scaleSpeed = 1f; // Скорость изменения размера платформы
    public float minScale = 0.5f; // Минимальный размер платформы
    public float maxScale = 2f; // Максимальный размер платформы

    private bool isScalingUp = true; // Флаг, указывающий, увеличивается ли размер платформы

    private void Update()
    {
        // Изменение размера платформы
        if (isScalingUp)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x >= maxScale)
                isScalingUp = false;
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x <= minScale)
                isScalingUp = true;
        }
    }
}

