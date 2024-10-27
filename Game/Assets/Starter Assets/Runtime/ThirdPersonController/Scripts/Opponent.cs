using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tOpponent : MonoBehaviour
{
    float minspeed = 1F;
    float speed = 3F;
    float force = 10;
    Animator animator;
    public Transform ball;
    public Transform aimTargetOpp;
    public float reactionDelay = 0.3f;
    private float lastReactionTime = 0;
    public Transform[] targets;

    Vector3 targetPosition;
    


    void Start()
    {
       targetPosition = transform.position;
       animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Time.time - lastReactionTime > reactionDelay)
        {
        lastReactionTime = Time.time;
        if (ball.position.z < transform.position.z) 
        {
            Move();
        }
        }
    }


    void Move( ){
        targetPosition.z = ball.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Mathf.Max(speed,minspeed) * Time.deltaTime);
    }

    Vector3 PickTarget(){
           
         int randomValue = Random.Range(0,3);
         return targets[randomValue].position;
    }

  private void OnTriggerEnter(Collider other){
	   if(other.CompareTag("Ball")){
           Vector3 dir = PickTarget() - transform.position;
		   other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0,7,0);
	   }
   }
   }

