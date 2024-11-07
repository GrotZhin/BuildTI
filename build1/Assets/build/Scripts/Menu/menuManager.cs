using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class menuManager : MonoBehaviour
    {
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject optionMenu;

        Scene scene;
        void Start()
        {
            //soundManager.PlaySound(SoundType.menuSong);
            //soundManager.PlaySound(SoundType.sfx);
            scene = SceneManager.GetActiveScene();
        }

        void Update()
        {
            if (optionMenu.activeSelf == false && scene.name == ("level1") && Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                optionMenu.SetActive(true);
            }
            else if (optionMenu.activeSelf == true && scene.name == ("level1") && Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                optionMenu.SetActive(false);
            }
            

        }


        public void Play()
        {
            SceneManager.LoadScene("level1");
        }

        public void Options()
        {
            mainMenu.SetActive(false);
            optionMenu.SetActive(true);
        }

        public void Exit()
        {
            Debug.Log("kitou");
            Application.Quit();
        }
        public void Back()
        {
            mainMenu.SetActive(true);
            optionMenu.SetActive(false);
        }

    }
}
