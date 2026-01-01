using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Exit(){
        Application.Quit();
        Debug.Log("Aplikasi Telah Ditutup");
    }


    public void Info(){
        SceneManager.LoadScene("Info");
    }

    public void Play(){
        SceneManager.LoadScene("Start");
    }
}
