using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


namespace MetalRay
{
    public class PlayerLife : MonoBehaviour
    {
        public int life = 100;
        public int damage = 20;
        public GameObject hitSprite;

        public GameObject deathEffect;

        public TextMeshProUGUI textoVida;
        public void TakeDamage(int damage)
        {
            life -= damage;

            if (life <= 0)
            {
                Die();
                SceneManager.LoadScene("lose");
            }
        }

        public void RestaureLife(int restaure)
        {
            life += restaure;
            if (life > 100)
            {
                life = 100;
            }
        }

         void OnCollisionEnter(Collision hitInfo)
        {
            EnemyLife enemyLife = hitInfo.collider.GetComponent<EnemyLife>();
            if (enemyLife != null)
            {
                enemyLife.Die();
                TakeDamage(damage);

            }
           
        }
        void Update()
        {
            this.textoVida.text = ("Life: " + life.ToString());
        }

        void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
