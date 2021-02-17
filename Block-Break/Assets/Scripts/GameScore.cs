using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public int Score;
    public Text Scoretext;

    public void Addscore()
    {
        Score++;
        Scoretext.text = "Player Score:" + Score.ToString();
    }
}

