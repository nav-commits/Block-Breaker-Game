using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddleOne;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
     Vector2 paddleBallVector;
     bool Hastarted = false;

    void Start()
    {
        paddleBallVector = transform.position - paddleOne.transform.position;
    }

  
    void Update()
    {
        if(!Hastarted)
        {
           LaunchBall();
           LockBallpaddle();
        }

    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Hastarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
    }

    private void LockBallpaddle()
    {
        Vector2 paddlepos = new Vector2(paddleOne.transform.position.x, paddleOne.transform.position.y);
        transform.position = paddlepos + paddleBallVector;
    }
}
