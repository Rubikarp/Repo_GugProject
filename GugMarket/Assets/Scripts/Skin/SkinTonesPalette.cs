using UnityEngine;


    public class SkinTonesPalette : SingletonSCO<SkinTonesPalette>
    {
        [Header("SkinTones")]
        [ColorUsage(true, false)] public Color[] skinTones;
    }

