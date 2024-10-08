using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class WinContidion : MonoBehaviour
    {
        // Start is called before the first frame update
     void OnTriggerEnter(Collider hitInfo){
          if (hitInfo.gameObject.CompareTag("Player"))
          {
            Debug.Log("bateuuuu");
            SceneManager.LoadScene(2);
          }
    }
}
    }
    
