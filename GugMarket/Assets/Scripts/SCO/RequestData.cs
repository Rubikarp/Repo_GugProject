using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Request", menuName = "GugObject/Request")]
public class RequestData : ScriptableObject
{
    [ResizableTextArea] public string linkedRequest;
    [Expandable] public RecipeData aimedRecipe;
}