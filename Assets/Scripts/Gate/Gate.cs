using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}

public class Gate : MonoBehaviour
{
    [SerializeField] GateAppearance _gateAppearance;
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;

    void OnValidate()
    {
        _gateAppearance.UIUpdate(_value, _deformationType);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier != null)
        {
            switch (_deformationType)
            {
                case DeformationType.Width:
                    playerModifier.AddWidth(_value);
                    break;
                case DeformationType.Height:
                    playerModifier.AddHeight(_value);
                    break;
            }

            Destroy(gameObject);
        }
    }
}
