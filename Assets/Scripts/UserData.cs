using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/FaceDrawphp/escribir.php";

    public int IdUser ;
    private string nombre = "";
    private int edad = 0;
    private string profesion = "";
    

    public InputField campoNombre;
    public InputField campoProfesion;
    public InputField campoEdad;
    

    public void SenData()
    {
        //es llamar a un metodo generando una pausa en la ejecución del programa hasta que se realiza lo que esta dentro del metodo
        StartCoroutine(enviarDatosUsuario());
    }

    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        profesion = campoProfesion.text;
        

        if (campoEdad.text != "")
        {
            edad = int.Parse(campoEdad.text);
        }
        else
        {
            print("el campo de edad no puede estar vacio");
        }

        print(IdUser + "  " + nombre + "  " + edad + profesion + "  "  );


        if (nombre == "" || profesion == "" || edad == 0)
        {
            print("los campos de nombre, profesion y edad deben tener información");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("idu", IdUser);
            form.AddField("nom", nombre);
            form.AddField("prof", profesion);
            form.AddField("ed", edad);



            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);

        }

            

    }
}