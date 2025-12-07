using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform target;

    private void Start()
    {
        transform.parent = null;
    }

    void LateUpdate()
    {
        if (target)
        {
            transform.position = target.position;
        }
    }
}
