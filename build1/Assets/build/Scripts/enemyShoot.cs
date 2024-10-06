using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MetalRay
{
    public class enemyShoot : MonoBehaviour
    {
        public float speed = 20f;
        public Rigidbody rb;
        public int damage = 20;
        public GameObject impactEfect;
        enemyWeapon weapon;

        void Start(){
            rb.velocity = -transform.up * speed;
            weapon = GetComponent<enemyWeapon>();
            
        }
       
        
        void OnTriggerEnter(Collider hitInfo){
           PlayerLife playerLife = hitInfo.GetComponent<PlayerLife>();
           if(playerLife != null){
                playerLife.TakeDamage(damage);

           }

           Instantiate(impactEfect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
