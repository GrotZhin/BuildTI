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
        public int life;

        public GameObject deathEffect;

        public TextMeshProUGUI scoreText;

        public ParticleSystem vfxhit;
        public int damage = 10;

        DropRate dropRate;

        void Start()
        {
            dropRate = GetComponent<DropRate>();
        }




        public void TakeDamage(int damage)
        {

            life -= damage;
            if (life <= 0)
            {
                Die();
                dropRate.DropPowerUp();
            }


        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("enemyDestroy")){
                Delete();
            }


        }

        public void Delete()
        {
            Destroy(gameObject);
        }
        public void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Instantiate(vfxhit, transform.position, Quaternion.identity);
            controlePontuacao.Pontuacao++;

            Destroy(gameObject);

        }
    }
}
