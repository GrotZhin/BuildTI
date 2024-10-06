using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MetalRay
{
    public class SpawnEnemy : MonoBehaviour
    {
        public Transform enemyPrefab;
      

        public float spawnRate = 2f;

    
        

        private void Spawn(){
            var enemyTransform = Instantiate (enemyPrefab) as Transform;
            enemyTransform.position = transform.position;
        }
    }

}