using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class introTransition : MonoBehaviour
    {
        public Animator transition;
        public float currentTime = 0f;
        public float startTime = 10f;


        void Start()
        {
         currentTime = startTime ;
        }

        // Update is called once per frame
        public void Update()
        {
           currentTime  -= 1 * Time.deltaTime ;

        if (currentTime <=0){

        SceneManager.LoadScene("MainMenu");
        }
        


        }
        
    }
}
