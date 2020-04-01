using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nomeDaCena;


    public void SceneLoader(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Quit()
    {
        Application.Quit();
    }
}