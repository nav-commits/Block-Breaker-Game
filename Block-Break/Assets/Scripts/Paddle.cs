using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Camera mainCamera;
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

   
    void Update()
    {
        transform.position = new Vector3(mainCamera.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, 0, 0)).x, -4, 0);

    }
}
