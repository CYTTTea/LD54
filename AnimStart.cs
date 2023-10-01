using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{

    public string clipName;
    private Animator anim;
    public float startTime = 0.3f;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play(clipName, 0, Random.Range(0f, 1f));
    }

    void Update()
    {
        
    }
}
