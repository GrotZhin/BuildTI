using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class PlayerLife : MonoBehaviour
    {
       public int life = 100;

        public GameObject deathEffect;

        public TextMeshProUGUI textoVida;
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
        void Update(){
              this.textoVida.text = ("Life: "+ life.ToString());
        }

        void Die(){
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
