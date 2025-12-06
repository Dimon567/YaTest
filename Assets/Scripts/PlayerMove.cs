using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _sensitive = 0.5f;

    private float _oldMousePositionX;
    private float _rotateAngel = 0;

    void Start()
    {
        _oldMousePositionX = Input.mousePosition.x;
    }

    void FixedUpdate()
    {
        Rotate();
        Move();
    }

    private void Move()
    {
        Vector3 nextPosition = Vector3.Lerp(transform.position, transform.position + transform.forward, _speed);
        transform.position = new Vector3(Mathf.Clamp(nextPosition.x,-3,3), nextPosition.y, nextPosition.z); 
    }

    private void Rotate()
    {
        float delta = (Input.mousePosition.x - _oldMousePositionX) * _sensitive;
        _oldMousePositionX = Input.mousePosition.x;

        _rotateAngel += delta;
        _rotateAngel = Mathf.Clamp(_rotateAngel, -50, 50);

        transform.eulerAngles = new Vector3(0 ,_rotateAngel, 0);
        
    }
}
