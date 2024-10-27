using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace MetalRay
{

    public enum SoundType

    {
        INTROTRANSITION,
    

    }

    [RequireComponent(typeof(AudioSource))]
    public class soundManager : MonoBehaviour
    {

        [SerializeField] private AudioClip[] soundlist;
        public static soundManager instance;
        public AudioSource audioSource;

        public void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void Awake()
        {
            instance = this;
        }
        
        public static void PlaySound(SoundType sound, float volume =  1)
        {

            instance.audioSource.PlayOneShot(instance.soundlist[(int)sound], volume);

        }
    }
}
