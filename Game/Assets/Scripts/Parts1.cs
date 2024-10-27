using UnityEngine;

public class ActivateOnPosition : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject targetObject1;
    public GameObject targetObject2;
    public float targetXPosition = 0.73f;
    public float tolerance = 0.05f;

    private void Update()
    {
        if (Mathf.Abs(transform.position.x - targetXPosition) <= tolerance)
        {
            if (targetObject != null && !targetObject.activeSelf)
            {
                targetObject.SetActive(true);
            }
            if (targetObject1 != null && targetObject.activeSelf)
            {
                targetObject1.SetActive(false);
            }
            if (targetObject2 != null && !targetObject2.activeSelf)
            {
                targetObject2.SetActive(true);
            }
            Collider targetCollider = targetObject.GetComponent<Collider>();
            if (targetCollider != null)
            {
              targetCollider.enabled = false; 
            }
        }
    }
}

