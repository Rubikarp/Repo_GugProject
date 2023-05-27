using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "SCO_Ingredient", menuName = "GugObject/Ingredient")]
public class Ingredient : ScriptableObject
{
    public Sprite sprite;
    public Statistique stat;
}
