using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MetalRay
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] GameObject muzzlePrefab;
        [SerializeField] GameObject hitPrefab;

        Transform parent;

        public void SetSpeed(float speed) => this.speed = speed;
        public void SetParent(Transform parent) => this.parent = parent;


        void Start()
        {
            if (muzzlePrefab != null)
            {
                //set muzzle flash
            }
        }

        void Update(){
            transform.SetParent(null);
            transform.position += transform.forward * (speed * Time.deltaTime);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (hitPrefab != null)
            {
                //instanciar hit effect
                ContactPoint contact = collision.contacts[0];
                var hitVFX = Instantiate(hitPrefab, contact.point, Quaternion.identity);

                DestroyParticleSystem(hitVFX);
            }
            //destruir projetil
            Destroy(gameObject);
        }
        void DestroyParticleSystem(GameObject vfx){
            var ps = vfx.GetComponent<ParticleSystem>();
            if(ps == null){
                ps = vfx.GetComponentInChildren<ParticleSystem>();
            }
            Destroy(vfx, ps.main.duration);
        }
    }
}
