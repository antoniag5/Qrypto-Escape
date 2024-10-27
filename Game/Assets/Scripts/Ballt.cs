using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Ballt : MonoBehaviour
{
    Vector3 initialPos;
    public bool hitter;
    int playerScore;
    int OppScore;
    bool playing;

    [SerializeField] TMP_Text playerscoretext;
    [SerializeField] TMP_Text oppscoretext;

    void Start()
    {
        initialPos = transform.position;
        playerScore = 0;
        OppScore = 0;
        playing = true;
        UpdateScores(); 
        hitter = true;
    }
private void OnCollisionEnter(Collision collision)
 {
     if(collision.transform.CompareTag("Wall"))
     {
         Debug.Log("Collision with Wall");
         UpdateScore();
         ResetBall();
     }
     else if (collision.transform.CompareTag("Opponent"))
        {
            BounceOffOpponent(collision);
            hitter = false;
            Debug.Log("Hitter: Opponent" );
        } 
     else if (collision.transform.CompareTag("Player"))
     {
         BounceOffPlayer(collision);
         hitter = true;
         Debug.Log("Hitter: Player");

     }

  }  
   private void OnTriggerEnter(Collider other){
       if((other.CompareTag("Out") && playing)||(other.CompareTag("Net") && playing)){
          Debug.Log("Trigger with Out or Net while playing");
          if(hitter){
              OppScore++;
              Debug.Log("Opponent Score: " + OppScore);
          }else {
              playerScore++;
              Debug.Log("Player Score: " + playerScore);
          } 
          playing = false;
          UpdateScores();
          ResetBall();

       }
   }

  void ResetBall()
  {
      GetComponent<Rigidbody>().velocity = Vector3.zero;
      transform.position = initialPos;
      playing = true;
  }

  void UpdateScore()
  {
    if(hitter == true && playing)
        {
            playerScore++;
        }
        else if (hitter == false && playing)
        {
            OppScore++;
        }
        playing = false;
        UpdateScores();
  }

  void UpdateScores()
   {
       playerscoretext.text = "Player : " + playerScore;
       oppscoretext.text = "Opponent : " + OppScore;
   }

  void BounceOffOpponent(Collision collision)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 bounceDirection = (transform.position - collision.transform.position).normalized;
        rb.velocity = bounceDirection * rb.velocity.magnitude;
    }

    void BounceOffPlayer(Collision collision)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 bounceDirection = (transform.position - collision.transform.position).normalized;
        rb.velocity = bounceDirection * rb.velocity.magnitude;
    }

   
}

