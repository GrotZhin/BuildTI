using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class ShootOn : MonoBehaviour
    {
      void OnTriggerEnter(Collider other){
        enemyWeapon enemyWeapon = other.GetComponent<enemyWeapon>();;
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("colidiu");
           enemyWeapon.ShootOn(); 
        }
      }
        
    }
}
