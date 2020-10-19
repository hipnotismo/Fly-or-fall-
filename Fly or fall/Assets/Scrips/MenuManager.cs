using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void PlayGame()
    {
       SceneManager.LoadScene("Game");
       Debug.Log("Play with 1 player");

    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Credits");

    }
}


