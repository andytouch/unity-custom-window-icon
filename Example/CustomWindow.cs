using BoressoStudio.EditorTools;
using UnityEngine;
using UnityEditor;

public class CustomWindow : EditorWindow
{
    [MenuItem("Boresso Studio/Custom Window")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CustomWindow), false);
        var window = GetWindow<CustomWindow>();
        window.titleContent = new GUIContent("Custom Window", CustomWindowIconUtil.GetCustomWindowIcon);
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Look! A custom icon!");
    }
}
