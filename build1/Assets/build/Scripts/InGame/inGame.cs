using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace MetalRay
{
    public class inGame : MonoBehaviour
    {
        public TextMeshProUGUI textoPontuacao;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.textoPontuacao.text = controlePontuacao.Pontuacao.ToString();
            if (controlePontuacao.Pontuacao == 20)
            {
                SceneManager.LoadScene("win");
            }
        }
    }
}
