using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPrincipal : MonoBehaviour
{
    //main menu script

    public void jugar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("koch");
    }

    public void jugar2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("cantorSet");
    }

    public void jugar3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("vicsek");
    }

    public void jugar4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("sierpinski");
    }


    public void salir()
    {
        Application.Quit();
    }
}