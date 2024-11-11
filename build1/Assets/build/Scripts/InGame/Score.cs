using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MetalRay
{
    public class Score : MonoBehaviour
    {
        public static int scoreValue = 0;
        public TextMeshProUGUI score;

        void Start()
        {
            score = GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {
        score.text = "" + scoreValue;
        }
    }
}
