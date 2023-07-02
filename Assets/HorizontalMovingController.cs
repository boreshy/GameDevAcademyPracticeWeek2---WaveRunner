using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HorizontalMovingController : MonoBehaviour
{
    public float moveDistance = 5f; // Расстояние, на которое будет двигаться платформа
    public float moveSpeed = 2f; // Скорость движения платформы

    private float leftBound;
    private float rightBound;
    private bool movingRight = true;

    private void Start()
    {
        // Определение границ диапазона игрового пространства
        leftBound = transform.position.x - moveDistance / 2;
        rightBound = transform.position.x + moveDistance / 2;
    }

    private void Update()
    {
        // Перемещение платформы влево-вправо
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // Если достигнута правая граница, меняем направление движения
            if (transform.position.x >= rightBound)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            // Если достигнута левая граница, меняем направление движения
            if (transform.position.x <= leftBound)
            {
                movingRight = true;
            }
        }
    }
}

