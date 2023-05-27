using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Request", menuName = "GugObject/Request")]
public class RequestData : ScriptableObject
{
    [TextArea(3,8)] public string linkedRequest;
    [Expandable] public RecipeData aimedRecipe;
}