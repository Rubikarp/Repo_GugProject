using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Plat", menuName = "GugObject/Plat")]
public class RecipeData : ScriptableObject
{
    [SerializeField] private List<IngredientData> ingredients = new();
    public IngredientData[] Ingredients { get => ingredients.ToArray(); }
    public void AddIngredients(IngredientData ingredient)
    {
        ingredients.Add(ingredient);
        stat += ingredient.stat;
    }

    public Statistique stat = new();

}
