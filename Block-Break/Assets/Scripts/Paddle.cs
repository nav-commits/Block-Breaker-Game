using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenwidthUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    
   
    void Update()
    {
        float mousemoveunits = Input.mousePosition.x / Screen.width * screenwidthUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mousemoveunits, minX, maxX);
        paddlepos.y = 1;
        transform.position = paddlepos;

    }
}
