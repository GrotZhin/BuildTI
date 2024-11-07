using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MetalRay
{
    public class destroyEnemy : MonoBehaviour
    {

        void OnTriggerEnter(Collider other)
        {
            EnemyLife enemyLife = other.GetComponent<EnemyLife>();
            if (other.gameObject.CompareTag("enemy"))
            {
                enemyLife.Delete();
            }

        }


    }
}
