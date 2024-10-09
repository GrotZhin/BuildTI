using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace MetalRay
{
    public class Shoot : MonoBehaviour
    {
        public float speed = 20f;
        public Rigidbody rb;
        Transform parent;

        public int damage = 40;

        public float timeDestroy = 0f;

        public GameObject impactEfect;
        public GameObject muzzlePrefab;

        void Start()
        {
            rb.velocity = transform.up * speed;
            Destroy(this.gameObject, timeDestroy);

            if (muzzlePrefab != null)
            {
                var muzzleVFX = Instantiate(muzzlePrefab, transform.position, Quaternion.identity);
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


