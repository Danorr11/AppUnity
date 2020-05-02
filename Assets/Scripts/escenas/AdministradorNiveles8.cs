using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles8 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(8);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
