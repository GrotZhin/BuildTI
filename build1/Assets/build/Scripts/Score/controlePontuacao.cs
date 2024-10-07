using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace MetalRay
{
    public class controlePontuacao : MonoBehaviour
    {

        public static int pontuacao;



        public static int Pontuacao
        {
            get
            {
                return pontuacao;
            }
            set
            {
                pontuacao = value;
                if (pontuacao < 0)
                {
                    pontuacao = 0;
                }
                Debug.Log("Pontos" + pontuacao);
            }
        }
    }
}

