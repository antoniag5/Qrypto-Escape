using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    Camera cam;
    PlayerMotor motor;
    Animator playeranim;

    private void Awake()
    {
        playeranim = GetComponent<Animator>();
    }

    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;   //stores inputs
           if(Physics.Raycast(ray, out hit, 100, movementMask))
           {
               playeranim.SetBool("Walk", true);
               motor.MoveToPoint(hit.point);
           }
        }

         if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;   //stores inputs
           if(Physics.Raycast(ray, out hit, 100))
           {
               playeranim.SetBool("Walk", true);
               motor.MoveToPoint(hit.point);
           }
        }
    }
}
