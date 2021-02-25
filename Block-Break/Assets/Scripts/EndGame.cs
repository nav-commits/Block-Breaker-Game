using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text Lives;
    public int lifes;
  

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Life();

        if (lifes == 0)
        {
            SceneManager.LoadScene(1);
            Life();
        }
        
    }

    public void Life()
    {
        lifes--;
        Lives.text = "lives" + lifes.ToString();
    }


}
