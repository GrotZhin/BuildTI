using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "MetalRay/Enemy", order =0)]
    public class Enemy : ScriptableObject
    {
        public GameObject enemyPrefab;
        public GameObject armaPrefab;
        public float speed;

    }

}
