﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles6 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(6);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
