using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Contador : MonoBehaviour
{
    [SerializeField] Text Mytext;
    [SerializeField] float speed;
    int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   IEnumerator Cronometro()
    {
       
        for (; ; n++)
        {
            Mytext.text = "Contador: " + n;
            yield return new WaitForSeconds(speed);
           
        }
           
    }
    void Update()
    {
      if(Input.GetButtonDown ("Fire1"))
        {
            StartCoroutine("Cronometro");
        }
        if(Input.GetButtonUp("Fire2"))
        {
            StopCoroutine("Cronometro");
        }
    }
}
