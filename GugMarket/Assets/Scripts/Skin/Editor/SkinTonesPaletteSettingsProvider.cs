using Karprod;
using UnityEditor;
using UnityEngine;

public class SkinTonesPaletteSettingsProvider : SettingsProvider
{
    public SkinTonesPaletteSettingsProvider(string path, SettingsScope scope) : base(path, scope) { }

    static Editor editor;

    [SettingsProvider]
    public static SettingsProvider CreateProviderForProjectSettings()
    {
        SkinTonesPaletteSettingsProvider trsp = new SkinTonesPaletteSettingsProvider("_GugMarket/SkinTonesPalette", SettingsScope.Project);
        trsp.guiHandler = OnProviderGUI;

        return trsp;
    }

    public static void OnProviderGUI(string context)
    {
        SkinTonesPalette trs = Resources.Load("SkinTonesPalette") as SkinTonesPalette;
        if (trs is null)
        {
            trs = CreateSettingsAsset();
        }
        if (!editor)
        {
            Editor.CreateCachedEditor(trs, null, ref editor);
        }
        editor.OnInspectorGUI();
    }

    public static SkinTonesPalette CreateSettingsAsset()
    {
        var path = KarpToolUtilities.FindScriptFolder("SkinTonesPalette", true);
        if (!AssetDatabase.IsValidFolder(path + "Resources/"))
        {
            var folder = path.Remove(path.Length - 1);
            Debug.Log(folder);
            AssetDatabase.CreateFolder(folder, "Resources");
        }
        path += "Resources/SkinTonesPalette.asset";
        Debug.Log(path);
        var trs = ScriptableObject.CreateInstance<SkinTonesPalette>();
        AssetDatabase.CreateAsset(trs, path);
        //
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        return trs;
    }
}

