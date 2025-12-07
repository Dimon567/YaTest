using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _colliderTransform;

    float _baseHeightSpine;
    float _widthMultiplier = 0.0005f;
    float _heightMultiplier = 0.01f;

    private void Start()
    {
        _baseHeightSpine = _topSpine.position.y - _bottomSpine.position.y;

        SetWidth(Progress.Instance.Width);
        SetHeight(Progress.Instance.Height);
    }

    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }
    public void AddHeight(int value) 
    { 
        _height += value;

        UpdateHeight();
        Debug.Log("Add height");
    }

    public void SetWidth(int value)
    {
        _width = value; 
        UpdateWidth();
    }

    public void SetHeight(int value) 
    {
        _height = value;
        UpdateHeight();
    }

    public void HitBarrier()
    {
        if (_height - 50 >= 0)
        {
            _height -= 50;
            UpdateHeight();
        }
        else if (_width - 50 >= 0)
        {
            _width -= 50;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }

    public void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }

    public void UpdateHeight()
    {
        float offsetY = _height * _heightMultiplier + _baseHeightSpine;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
    }

    public void Die()
    {
        Destroy(gameObject);
        FindAnyObjectByType<GameManager>().ShowFinishWindow();
    }
}
