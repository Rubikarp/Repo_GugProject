using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[System.Serializable]
public class Statistique
{
    [Range(-10, 10f)] public float axisSweetSalty = 0.0f;
    [Range(-10, 10f)] public float axisSpicyFleshy = 0.0f;
    [Range(-10, 10f)] public float axisThickeness = 0.0f;
    [Range(0, 10f)] public float axisWeight = 0.0f;

    public Statistique()
    {
        axisSpicyFleshy = 0.0f;
        axisSweetSalty = 0.0f;
        axisThickeness = 0.0f;
        axisWeight = 0.0f;
    }
    public Statistique(float sugarSalt, float spicyFleshy, float thickness, float weight)
    {
        axisSpicyFleshy = spicyFleshy;
        axisSweetSalty = sugarSalt;
        axisThickeness = thickness;
        axisWeight = weight;
    }

    public static Statistique operator +(Statistique a, Statistique b)
    {
        return new Statistique(
            a.axisSweetSalty + b.axisSweetSalty,
            a.axisSpicyFleshy + b.axisSpicyFleshy,
            a.axisThickeness + b.axisThickeness,
            a.axisWeight + b.axisWeight
            );
    }
}
