using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    float speed = 4;
    float force = 10;
    Animator animator;
    public Transform ball;
    public Transform aimTargetOpp;

    public Transform[] targets;

    Vector3 targetPosition;
    


    void Start()
    {
       targetPosition = transform.position;
       animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        Move();
    }

    void Move( ){
        targetPosition.z = ball.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    Vector3 PickTarget(){
        int randomValue = Random.Range(0,targets.Length);
        return targets[randomValue].position;
    }

  private void OnTriggerEnter(Collider other){
	   if(other.CompareTag("Ball")){
		   Vector3 dir = PickTarget() - transform.position;
		   other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0,7,0);
	   }
   }
   }

