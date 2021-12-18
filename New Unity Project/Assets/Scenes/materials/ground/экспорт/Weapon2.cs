using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2: MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulet;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulet, firePoint.position, firePoint.rotation);
    }
}
