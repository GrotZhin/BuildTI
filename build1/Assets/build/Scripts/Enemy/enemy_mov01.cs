using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemy_mov01 : MonoBehaviour
{
     public float spd = 1;

     public Transform cameraFollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;


        pos.y -= spd * Time.fixedDeltaTime;


        transform.position = pos;

        
        if (pos.y < cameraFollow.position.y - 4f)
        {
          
            Destroy(gameObject);
        }
    }
}
