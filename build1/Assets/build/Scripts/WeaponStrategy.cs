using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetalRay
{
    public class WeaponStrategy : ScriptableObject
    {
        [SerializeField] int damage = 10;
        [SerializeField] float fireRate = 0.5f;
        [SerializeField] protected float projetilSpeed = 10f;
        [SerializeField] protected float projetilLifeTime = 4f;
        [SerializeField] protected GameObject projetilPrefab;

        public int Damage => damage;
        public float FireRate => fireRate
    }
}
