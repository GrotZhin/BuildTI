using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace MetalRay
{
    public class EnemyLife : MonoBehaviour
    {
       public int life = 100;
       public float pontos = 100;
        public GameObject deathEffect;
        public TextMeshProUGUI scoreText;

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
            controlePontuacao.Pontuacao++;
            
            Destroy(gameObject);
        }
    }
}
