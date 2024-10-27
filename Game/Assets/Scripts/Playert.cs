using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playert : MonoBehaviour {

    public Transform aimTarget;
	public Transform ball;
    float speed = 4f;
	float force = 25;
    bool hitting;
	Animator playerAnim;

	private void Awake()
	{
		playerAnim = GetComponent<Animator>();
	}

  
   void Update() {
	   float h = Input.GetAxisRaw("Horizontal"); 
       float v = Input.GetAxisRaw("Vertical");

	   if(Input.GetKeyDown(KeyCode.F)){
		   hitting = true;
	   }else if(Input.GetKeyUp(KeyCode.F)){
		   hitting = false;
	   }

	   if (Input.GetKeyDown(KeyCode.UpArrow)){
		   playerAnim.SetBool("runN", true);
	   }

	   if (Input.GetKeyDown(KeyCode.DownArrow)){
		   playerAnim.SetBool("runS", true);
	   }

	   if(hitting){
		   aimTarget.Translate(new Vector3(0,0,h)*speed*Time.deltaTime);
	   }

	    if (h != 0 || v != 0) {
            transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
        }
   }

   private void OnTriggerEnter(Collider other){
	   if(other.CompareTag("Ball")){
		   Vector3 dir = aimTarget.position - transform.position;
		   other.GetComponent<Rigidbody>().velocity = dir.normalized *force + new Vector3(0,6,0);
		   force = 15;
		   }
   }

}
