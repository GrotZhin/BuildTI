using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class PlayerLife : MonoBehaviour
    {
       public int life = 100;

        public GameObject deathEffect;

        public void TakeDamage(int damage)
        {
            life -= damage;
            if (life <= 0)
            {
                Die();
                SceneManager.LoadScene(1);
            }
        }
  
        public void RestaureLife(int restaure){
            life += restaure;
            if(life > 100){
                life = 100;
            }
        }

        void Die(){
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
