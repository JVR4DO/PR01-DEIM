using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios : MonoBehaviour
{
    // Start is called before the first frame update





    int n = 10;

    void Start()
    {

        if (n == 0)
        {
            Debug.Log("n vale 0");
        }
        else if (n <= 10)
        {
            Debug.Log("n es igual o menor que 10");
        }
        else
                {
            Debug.Log("n vale mas de 10");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
}
