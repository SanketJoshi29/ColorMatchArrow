using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    
    void Start()
    {
        offset = transform.position - player.position;
    }
    
    void Update()
    {
        transform.position = player.position + offset;
    }
    /*public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;
 
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;
 
    private void Start()
    {
        Offset = camTransform.position - Target.position;
    }
 
    private void Update()
    {
        // update position
        Vector3 targetPosition = Target.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
    }*/

}
