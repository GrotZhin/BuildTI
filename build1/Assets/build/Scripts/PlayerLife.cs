using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class PlayerLife : MonoBehaviour
    {
        [SerializeField]public int life = 100;

        public GameObject deathEffect;

        public void TakeDamage(int damage)
        {
            life -= damage;
            if (life <= 0)
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

