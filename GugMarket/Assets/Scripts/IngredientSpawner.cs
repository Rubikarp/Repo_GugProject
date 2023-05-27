using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientSpawner : MonoBehaviour
{
    public Ingredient ingredientPrefab;
    [Expandable]public IngredientData ingredientData;

    public Transform spawnPos;

    private void OnValidate()
    {
        GetComponent<Image>().sprite = ingredientData.sprite;
    }

    public void SpawnIngredient()
    {
        Ingredient ingredient = Instantiate(ingredientPrefab, spawnPos.position, Quaternion.identity);
        ingredient.sprite.sprite = ingredientData.sprite;
        ingredient.data = ingredientData;
        ingredient.collider.TryUpdateShapeToAttachedSprite();
    }
}
