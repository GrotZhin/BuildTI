using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_mov_ocean : MonoBehaviour
{
      float sinCenterX;
      public float amplitude = 0f;

      public float frequency = 0f;

    
    void Start()
    {
        
        sinCenterX= transform.position.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
          Vector2 pos = transform.position;

          float sin = Mathf.Sin(pos.y*frequency) * amplitude;
          pos.x = sinCenterX + sin;

        transform.position = pos;


    }

}