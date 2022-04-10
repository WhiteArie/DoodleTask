using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseManager : MonoBehaviour
{
  public void Restart()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");


    }

    public void Menu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }



}
