using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Request", menuName = "GugObject/Request")]
public class Request : ScriptableObject
{
    [ResizableTextArea] public string linkedRequest;
    [Expandable] public Recipe aimedRecipe;
}