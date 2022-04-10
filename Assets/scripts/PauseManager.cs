using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    public bool pauseGame = false;
    public GameObject pauseGameMenu;


    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.Escape))
        {

            Pause();

        }
        else
        {

            Resume();

        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        pauseGame = true;
    }

    public void LoadMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }



}
