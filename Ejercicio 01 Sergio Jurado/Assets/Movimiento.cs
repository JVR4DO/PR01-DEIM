using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update




    
    void Start()
    {
        
        




    }

    // Update is called once per frame
    void Update()
    {
        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);
        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desplX * Time.deltaTime);
        float desplZ1 = Input.GetAxis("Profundidad +") * speed;
        transform.Translate(Vector3.forward * desplZ1 * Time.deltaTime);
        float desplZ2 = Input.GetAxis("Profundidad -") * speed;
        transform.Translate(Vector3.back * desplZ2 * Time.deltaTime);
        if (Input.GetButtonDown("Fire1"))
        {
            print("Se ha disparado");
        }

    }
    
     




}
