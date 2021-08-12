using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    //Use this variable to set the target for the camera to follow
    public Transform target;
    public float smoothSpeed = 0.200f;

    //This vector enables us to "fix" the z position of the camera
    public Vector3 offset;

    private void FixedUpdate()
    {
        //This makes the camera "smoother", instead of just following the player, read the code and you'll understand
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
