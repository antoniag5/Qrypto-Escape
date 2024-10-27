using UnityEngine;

public class DragAlongXAxis : MonoBehaviour
{
    private Vector3 offset;
    private float initialY; 

    private void Start()
    {
        initialY = transform.position.y;
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = GetMouseWorldPosition();
        offset = transform.position - mousePosition;
    }

    private void OnMouseDrag()
    {
        
        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 newPosition = mousePosition + offset;
        transform.position = new Vector3(newPosition.x, initialY, transform.position.z);
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 screenPosition = Input.mousePosition;
        screenPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }
}

