using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios : MonoBehaviour
{
    // Start is called before the first frame update



    
    public string usuario;
    void Start()
    {

        Saludo(usuario);




    }

    // Update is called once per frame
    void Update()
    {



    }
    void Saludo(string nombre)
    {
        print("Hola " + nombre);

    }





}
