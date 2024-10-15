using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

namespace MetalRay
{
    public class Shoot : MonoBehaviour
    {
        public float speed = 20f;
        public Rigidbody rb;
        public Transform parent;

        public int damage = 40;

        public float timeDestroy = 0f;

        public GameObject impactEfect;
        public GameObject muzzlePrefab;

        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        void Start()
        {
            rb.velocity = transform.up * speed;
            Destroy(this.gameObject, timeDestroy);

            if (muzzlePrefab != null)
            {
                GameObject muzzleVFX = Instantiate(muzzlePrefab,transform.position,quaternion.identity);
                muzzleVFX.transform.forward = gameObject.transform.forward;
                muzzleVFX.transform.SetParent(parent);
                

                Destroy(muzzleVFX, 0.25f);

            }
        }
        void OnTriggerEnter(Collider hitInfo)
        {
            EnemyLife enemyLife = hitInfo.GetComponent<EnemyLife>();
            if (enemyLife != null)
            {
                enemyLife.TakeDamage(damage);

            }

            Instantiate(impactEfect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}


