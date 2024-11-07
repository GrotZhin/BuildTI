using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

namespace MetalRay
{
    public class enemyWeapon : MonoBehaviour
    {
        public Transform firePoint;
        public GameObject firePoint1;
        public GameObject shootPrefab;
        public float fireTime;
        
        public float fireRate = 0.75f;
        void Update()
        {
            fireTime += Time.deltaTime;
            if (fireTime >= fireRate)
            {
                
                EnemyShoot();
                fireTime = 0f;
            }

        }
        void EnemyShoot()
        {
            Instantiate(shootPrefab, firePoint.position, transform.rotation);

        }

        public void ShootOn(){
             firePoint1.SetActive(true);
        }
       
    }
}
