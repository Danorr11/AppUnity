using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles10 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(0);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
