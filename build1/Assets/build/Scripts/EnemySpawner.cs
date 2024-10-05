using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace MetalRay
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] List<Enemy> enemies;
        [SerializeField] int maxEnemies = 10;
        [SerializeField] float intervaloSpawn = 2f;

        float spawnTimer;

        List<SplineContainer> splines;
        EnemyFactory enemyFactory;
        int enemiesSpawned;

        void OnValidate()
        {
            splines = new List<SplineContainer>(GetComponentsInChildren<SplineContainer>());
        }
        
        void Start() => enemyFactory = new EnemyFactory(); 

        void Update()
        {
            spawnTimer += Time.deltaTime;

            if(enemiesSpawned < maxEnemies && spawnTimer >= intervaloSpawn){
                SpawnEnemy();
                spawnTimer = 0f;
            }
        }

        void SpawnEnemy(){
            Enemy enemy = enemies[Random.Range(0, enemies.Count)];
            SplineContainer spline = splines[Random.Range(0,splines.Count)];

                enemyFactory.CreateEnemy(enemy, spline);

            enemiesSpawned++;
        }
    }
}
