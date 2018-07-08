using UnityEngine;

[ExecuteInEditMode]
sealed class MaterialKeywordController : MonoBehaviour
{
    enum Selector { None, Red, Blue }

    [SerializeField] Selector _selector;

    void Update()
    {
        var m = GetComponent<Renderer>().sharedMaterial;

        switch (_selector)
        {
        case Selector.Red:
            m.EnableKeyword("RED");
            m.DisableKeyword("BLUE");
            break;
        case Selector.Blue:
            m.DisableKeyword("RED");
            m.EnableKeyword("BLUE");
            break;
        default:
            m.DisableKeyword("RED");
            m.DisableKeyword("BLUE");
            break;
        }
    }
}
