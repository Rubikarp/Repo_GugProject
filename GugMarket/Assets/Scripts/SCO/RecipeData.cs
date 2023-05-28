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

    public float GetDistance(RecipeData other)
    {
        float result = 0f;
        result += Mathf.Abs(stat.axisSpicyFleshy - other.stat.axisSpicyFleshy);
        result += Mathf.Abs(stat.axisSweetSalty - other.stat.axisSweetSalty);
        //result += Mathf.Abs(stat.axisThickeness - other.stat.axisThickeness);
        //result += Mathf.Abs(stat.axisWeight - other.stat.axisWeight);
        return result;
    }

    public Statistique stat = new();

}
