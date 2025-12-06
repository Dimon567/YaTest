using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform target;

    void LateUpdate()
    {
        if (target)
        {
            transform.position = target.position;
        }
    }
}
