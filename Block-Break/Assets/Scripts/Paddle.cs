using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenwidthUnits = 16f;
    [SerializeField] float minX = -5f;
    [SerializeField] float maxX = 5.7f;

    void Start()
    {
      
    }

   
    void Update()
    {
        float mousemoveunits = Input.mousePosition.x / Screen.width * screenwidthUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mousemoveunits, minX, maxX);
        transform.position = paddlepos;
        
    }
}
