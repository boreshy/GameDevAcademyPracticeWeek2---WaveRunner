using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingController : MonoBehaviour
{
    public float moveDistance = 3f; // Расстояние, на которое будет двигаться платформа
    public float moveSpeed = 2f; // Скорость движения платформы

    private float upBound;
    private float downBound;
    private bool movingUp = true;

    private void Start()
    {
        // Определение границ диапазона игрового пространства
        upBound = transform.position.y - moveDistance / 2;
        downBound = transform.position.y + moveDistance / 2;
    }

    private void Update()
    {
        // Перемещение платформы влево-вправо
        if (movingUp)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

            // Если достигнута правая граница, меняем направление движения
            if (transform.position.y >= downBound)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

            // Если достигнута левая граница, меняем направление движения
            if (transform.position.y <= upBound)
            {
                movingUp = true;
            }
        }
    }
}
