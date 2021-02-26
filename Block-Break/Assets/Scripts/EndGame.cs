using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text Lives;
    public int lifes;


    private void Start()
    {
        lifes = 5;
        TrackText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Life();

        if (lifes == 0)
        {
            SceneManager.LoadScene(1);

        }
        
    }

    public void Life()
    {
        lifes--;
        TrackText();
    }

    public void TrackText()
    {
        Lives.text = "lives:" + lifes.ToString();
    }


}
