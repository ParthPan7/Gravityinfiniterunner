using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private static float speed = 3.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x += Time.deltaTime * speed;
        transform.position = cameraPosition;
    }
}
