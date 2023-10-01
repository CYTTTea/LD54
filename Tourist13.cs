using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tourist13 : MonoBehaviour

{
    public float moveSpeed = 5f;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    private Vector3 targetPosition;
    private float moveTimer;

    public GameObject BeachManager;
    public GameObject Test;

    public Animator animator;

    public float maxStayTime = 0.1f; 
    private float currentStayTime = 0f;
    private bool Missing = false;
    private bool isMissing = false;

    private UIManager uiManager;
    public int missingTouristsCount = 0;

    public GameObject Tourist1;
    public GameObject Tourist01;
    public GameObject Tourist02;
    public GameObject Tourist03;



    void Start()
    {

        targetPosition = GetRandomTargetPosition();

    }

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {

            moveTimer += Time.deltaTime;
            if (moveTimer >= 2f)
            {

                targetPosition = GetRandomTargetPosition();
                moveTimer = 0f;
            }



    }

        if (Missing == true)
        {
            print(1);
            if (isMissing == false)
            {

                currentStayTime += Time.deltaTime;

                if (currentStayTime >= maxStayTime)
                {
                    HandleMissingTourist();
                }
            }
        }


    }


    Vector3 GetRandomTargetPosition()
    {
        float randomX = Random.Range(minBounds.x, maxBounds.x);
        float randomY = Random.Range(minBounds.y, maxBounds.y);
        return new Vector3(randomX, randomY, 0f);
    }


    private void OnTriggerStay2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Tourist01.transform.position = Tourist1.transform.position;
                Tourist01.SetActive(true);
                Tourist02.transform.position = Tourist1.transform.position;
                Tourist02.SetActive(true);
                Tourist03.transform.position = Tourist1.transform.position;
                Tourist03.SetActive(true);

                animator.Play("香蕉船倒下");
                Destroy(gameObject, 0.5f);
            }


        }


        if (other.CompareTag("Respawn"))
        {
            currentStayTime = 0f;
            Missing = false;

        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            Missing = true;
        }
    }

    void HandleMissingTourist()
    {
        isMissing = true;
        gameObject.SetActive(false); 
        Destroy(gameObject); 

        CountManager.instance.missingTouristsCount++;

    }


}


