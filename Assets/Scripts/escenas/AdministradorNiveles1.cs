using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorNiveles1 : MonoBehaviour
{

    public void irAjuego()
    {

        SceneManager.LoadScene(1);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}
