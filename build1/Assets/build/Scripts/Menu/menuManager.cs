using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetalRay
{
    public class menuManager : MonoBehaviour
    {
        [SerializeField]private GameObject mainMenu;
        [SerializeField]private GameObject optionMenu;
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
