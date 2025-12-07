using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GateAppearance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _backgroundImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    [SerializeField] GameObject _expandLabel;
    [SerializeField] GameObject _shrinkLabel;
    [SerializeField] GameObject _upLabel;
    [SerializeField] GameObject _downLabel;

    public void UIUpdate(int value, DeformationType deformationType)
    {
        string prefix = "";

        if (value > 0)
        {
            SetColor(_colorPositive);
            prefix = "+";
        }
        else if (value < 0)
        {
            SetColor(_colorNegative);
        }
        else
        {
            SetColor(Color.lightGray);
        }

        _text.text = prefix + value.ToString();


        bool isValueMoreZero = value > 0;

        _expandLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);

        switch (deformationType)
        {
            case DeformationType.Width:
                _expandLabel.SetActive(isValueMoreZero);
                _shrinkLabel.SetActive(!isValueMoreZero);
                break;
            case DeformationType.Height:
                _upLabel.SetActive(isValueMoreZero);
                _downLabel.SetActive(!isValueMoreZero);
                break;
        }
    }
    private void SetColor(Color color)
    {
        _topImage.color = color;
        _backgroundImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

 
     
}
