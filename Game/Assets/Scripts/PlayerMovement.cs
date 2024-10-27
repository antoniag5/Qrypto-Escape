using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f; 

    void Update()
    {
      
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-v, 0, h).normalized;

        if (movement.magnitude >= 0.1f)
        {
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
}
