using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenHandler : SingletonMonoBehaviour<KitchenHandler>
{
    [Expandable] public RecipeData currentDish;

    [Button]
    public void ResetDish()
    {
        currentDish = ScriptableObject.CreateInstance<RecipeData>();
    }

    void Update()
    {
        
    }
}
