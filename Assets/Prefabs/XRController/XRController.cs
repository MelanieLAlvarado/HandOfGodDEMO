using UnityEngine;

public class XRController : MonoBehaviour
{
    public void SetControllerRotation(Quaternion newRotation) 
    {
        transform.localRotation = newRotation;
    }
    public void SetControllerPosition(Vector3 newPosition)
    {
        transform.localPosition = newPosition;
    }
}
