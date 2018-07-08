using UnityEngine;

[ExecuteInEditMode]
sealed class GlobalKeywordController : MonoBehaviour
{
    enum Selector { None, Red, Blue }

    [SerializeField] Selector _selector;

    void Update()
    {
        switch (_selector)
        {
        case Selector.Red:
            Shader.EnableKeyword("RED");
            Shader.DisableKeyword("BLUE");
            break;
        case Selector.Blue:
            Shader.DisableKeyword("RED");
            Shader.EnableKeyword("BLUE");
            break;
        default:
            Shader.DisableKeyword("RED");
            Shader.DisableKeyword("BLUE");
            break;
        }
    }
}
