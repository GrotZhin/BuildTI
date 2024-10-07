using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class Weapon : MonoBehaviour
    {
        public Transform firePoint;
        public GameObject shootPrefab;
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {

                Shoot();
                Debug.Log("player atirou");
            }

        }
        void Shoot()
        {
            Instantiate(shootPrefab, firePoint.position, transform.rotation);
            
        }
    }
}
