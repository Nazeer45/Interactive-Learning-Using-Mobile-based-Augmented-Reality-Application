using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ARScene()
    {
        SceneManager.LoadScene("AR_3DBook_scene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
