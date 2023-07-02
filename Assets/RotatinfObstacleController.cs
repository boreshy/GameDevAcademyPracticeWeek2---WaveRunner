using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotatinfObstacleController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Скорость вращения платформы

    private void Update()
    {
        // Вращение платформы вокруг своей оси
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}

