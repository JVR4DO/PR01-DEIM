using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios : MonoBehaviour
{
    // Start is called before the first frame update




    int aleatorio;
    int n;

    void Start()
    {
        for(int n = 0; n < 10; n++) 
        {
            aleatorio = Random.Range(0, 10);

        }
        while (aleatorio != 5)
        {
            aleatorio = Random.Range(0, 10);
            print("El resultado es :" + aleatorio);
            
        }





    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
}
