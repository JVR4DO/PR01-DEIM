using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafagas : MonoBehaviour
{


    public GameObject projectile;

    public float fireRate = 0.5f;

    private float nextFire = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;

            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
