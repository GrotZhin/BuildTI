using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MetalRay
{
    public class ParallaxController : MonoBehaviour
    {
        [SerializeField] Transform[] backgrounds; // Vetor para camadas do background
        [SerializeField] float smoothing = 10f; //Suavidade das nuvens
        [SerializeField] float multiplier = 15f; // Quanto o efeito do parallax se move pelo background

        Transform cam; // referencia para camera principal
        Vector3 cameraPrevia; // posicao da camera no frame previo

        void Awake() => cam = Camera.main.transform;
        void Start() => cameraPrevia = cam.position;

        void Update()
        {  //interage com todas as camadas do background
            for (var i = 0; i < backgrounds.Length; i++){
                var parallax = (cameraPrevia.y - cam.position.y) * (i * multiplier);
                var targetY = backgrounds[i].position.y + parallax;

                var targetPosition = new Vector3(backgrounds[i].position.x, y:targetY, backgrounds[i].position.z);

                backgrounds[i].position = Vector3.Lerp(a:backgrounds[i].position, b:targetPosition, t:smoothing * Time.deltaTime);
            }

            cameraPrevia = cam.position;
        }
    }
}
