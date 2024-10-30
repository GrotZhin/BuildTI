using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_mov_ocean : MonoBehaviour
{
  float sinCenterX;

  public float minAmp = -3f;
  public float maxAmp = 3f;
  public float minFr = 0f;
  public float maxFr = 3f;






  void Start()
  {

    sinCenterX = transform.position.x;

  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float amplitude = Random.Range(minAmp, maxAmp);
    float frequency = Random.Range(minFr, maxFr);

    Vector2 pos = transform.position;

    float sin = Mathf.Sin(pos.y * frequency) * amplitude;
    pos.x = sinCenterX + sin;

    transform.position = pos;




  }

}