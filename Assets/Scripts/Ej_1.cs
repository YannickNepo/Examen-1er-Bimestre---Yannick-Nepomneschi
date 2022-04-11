using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Todos los ingresos se hacen por Inspector. 
//Ingresar:
//nombre de alumno
//de qué año es(un número del 1 al 5)
//a qué orientación pertenece(sólo se puede ingresar la inicial en mayúscula de la especialidad: T para TIC, D para Diseño, G para Gestión, M para Medios y H para Humanidades).

//El programa debe cumplir los siguientes requerimientos:

//Mostrar un mensaje de error si el nombre ingresado es una cadena de caracteres vacía y si el año ingresado no está en el rango del 1 al 5. 

//Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación escribir en consola “Solo puede ingresar T, D, G, M o H”. 


//Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error.Aún estás en el ciclo básico”.


//Si los ingresos de nombre, año y orientación son válidos escribir en consola un mensaje de agradecimiento en el siguiente formato: “Muchas gracias[nombreAlumno]!”



public class Ej_1 : MonoBehaviour
{
    public string nombre;
    public int año;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {
        string orientacion1 = "T";
        string orientacion2 = "M";
        string orientacion3 = "D";
        string orientacion4 = "G";
        string orientacion5 = "H";
        string vacio = "";



        if ((nombre == vacio) || (año > 5) || (año < 1))
        {
            Debug.Log("error");
        }
        if (orientacion != orientacion1 || orientacion != orientacion2 || orientacion != orientacion3 || orientacion != orientacion4 || orientacion != orientacion5)
        {
            Debug.Log("Solo puede ingresar T,D,G,M o H");
        }
        if(orientacion == orientacion1 || (orientacion == orientacion2) || (orientacion == orientacion3) || (orientacion == orientacion4) || (orientacion == orientacion5))
        {
            Debug.Log("Ya elegiste orientacion");
        }
        else if (año < 3)
        {
            Debug.Log("Error.Aun estas en el ciclo basico");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombre);
        }
    }

    
}
