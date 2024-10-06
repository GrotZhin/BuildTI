using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class EnemyLife : MonoBehaviour
    {
       public int life = 100;

        public GameObject deathEffect;

        public void TakeDamage(int damage)
        {
            life -= damage;
            if (life <= 0)
            {
                Die();
            }
        }

        void OnCollisionEnter(Collision collision){
            if (collision.gameObject.tag == "Player")
            {
              Die();  
            }
            
        }

        
        void Die(){
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
