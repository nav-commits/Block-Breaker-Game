using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
    public int Score;
    public Text Scoretext;

    public void Addscore()
    {
        Score++;
        Scoretext.text = "Player Score:" + Score.ToString();


        if (Score == 52)
        {
            Scoretext.text = "You Win:" + Score.ToString();
            SceneManager.LoadScene(2);
        }


    }

   
}

