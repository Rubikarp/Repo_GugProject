using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Request", menuName = "GugObject/Request")]
public class RequestData : ScriptableObject
{
<<<<<<< HEAD:GugMarket/Assets/Scripts/SCO/RequestData.cs
    [ResizableTextArea] public string linkedRequest;
    [Expandable] public RecipeData aimedRecipe;
=======
    public string linkedRequest;
    [Expandable] public Recipe aimedRecipe;
>>>>>>> Mathys:GugMarket/Assets/Scripts/SCO/Request.cs
}