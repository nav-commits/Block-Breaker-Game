using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddleOne;
     Vector2 paddleBallVector;
    bool Hastarted = false;

    void Start()
    {
        paddleBallVector = transform.position - paddleOne.transform.position;
    }

  
    void Update()
    {
        LockBallpaddle();
        LaunchBall();

    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    private void LockBallpaddle()
    {
        Vector2 paddlepos = new Vector2(paddleOne.transform.position.x, paddleOne.transform.position.y);
        transform.position = paddlepos + paddleBallVector;
    }
}
