using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles9 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(9);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
