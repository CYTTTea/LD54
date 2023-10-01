using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] audioClips;
    private AudioSource audioSource;



    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (audioClips != null && audioClips.Length > 0)
            {
                int randomIndex = Random.Range(0, audioClips.Length);
                audioSource.clip = audioClips[randomIndex];
                audioSource.Play();
            }
        }
    }
}
