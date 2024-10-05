using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace MetalRay
{
    public class EnemyFactory
    {
        public GameObject CreateEnemy(Enemy enemy, SplineContainer spline){
                EnemyBuilder builder = new EnemyBuilder()
                .SetBasePrefab(enemy.enemyPrefab)
                .SetSpline(spline)
                .SetSpeed(enemy.speed);

                return builder.Build();
        }
    }
}
