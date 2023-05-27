using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SCO_Plat", menuName = "GugObject/Plat")]
public class Recipe : ScriptableObject
{
    [SerializeField] private List<Ingredient> ingredients = new();
    public Ingredient[] Ingredients { get => ingredients.ToArray(); }
    public void AddIngredients(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
        stat += ingredient.stat;
    }

    public Statistique stat = new();

}
