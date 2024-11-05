using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_mov_ocean : MonoBehaviour
{
  float sinCenterX;

  public int minAmp = -3;
  public int maxAmp = 3;
  public int minFr = 0;
  public int maxFr = 3;

  int amplitude;
  int frequency;




  void Start()
  {

    sinCenterX = transform.position.x;
     amplitude = Random.Range(minAmp, maxAmp);
     frequency = Random.Range(minFr, maxFr);
  }

  // Update is called once per frame
  void Update()
  {
   

    Vector2 pos = transform.position;

    float sin = Mathf.Sin((pos.y * frequency)) * amplitude;
    pos.x = sinCenterX + sin;
    Debug.Log(amplitude);
    transform.position = pos;




  }

}