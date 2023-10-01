using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourist1 : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    private Vector3 targetPosition;
    private float moveTimer;

    public GameObject BeachManager;

    public Animator animator;

    public bool isCaught = false;


    void Start()
    {
    }

    void Update()
    {


    }




    private void OnTriggerStay2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {


            if (Input.GetKey(KeyCode.E))
            {
                

                    transform.position = BeachManager.transform.position;
                    animator.Play("普通游客挣扎");
                    isCaught = true;

            }

            else
            {
                animator.Play("普通游客游泳");
            }


            }

            if (Input.GetKeyDown(KeyCode.E))
            {

            }


        }



    private void OnTriggerExit2D(Collider2D other)
    {

    }



    void MoveAndAdjustSortingOrder()
    {
        float currentY = transform.position.y;


        int sortingOrder = Mathf.FloorToInt(-currentY * 100); 

    }


}
