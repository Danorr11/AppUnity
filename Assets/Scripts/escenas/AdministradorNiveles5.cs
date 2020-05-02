using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles5 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(5);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
