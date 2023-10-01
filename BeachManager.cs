using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachManager : MonoBehaviour
{
    public float moveSpeed = 5f;
    public AudioClip audioClips1;
    public AudioClip audioClips2;
    public AudioClip audioClips3;
    private AudioSource audioSource;
    public Animator animator;

    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
    }


    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;


        MoveManager(mousePosition);



        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.clip = audioClips1;
            PlaySound();
            animator.Play("攻击1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.clip = audioClips2;
            PlaySound();
            animator.Play("攻击2");
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioSource.clip = audioClips3;
            PlaySound();
            animator.Play("攻击3");
        }


        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            animator.Play("管理员");
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {

            animator.Play("管理员");
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {

            animator.Play("管理员");
        }


    }

    private void MoveManager(Vector3 targetPosition)
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    private void PlaySound()
    {

        if (audioSource != null)
        {

            audioSource.Play();
        }
    }

}
