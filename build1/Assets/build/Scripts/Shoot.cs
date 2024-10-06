using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class Shoot : MonoBehaviour
    {
        public float speed = 20f;
        public Rigidbody rb;
        public int damage = 40;
        public GameObject impactEfect;

        void Start(){
            rb.velocity = transform.up * speed;
        }
        void OnTriggerEnter(Collider hitInfo){
           EnemyLife enemyLife = hitInfo.GetComponent<EnemyLife>();
           if(enemyLife != null){
                enemyLife.TakeDamage(damage);

           }

           Instantiate(impactEfect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
