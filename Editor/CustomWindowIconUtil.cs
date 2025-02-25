using UnityEditor;
using UnityEngine;

namespace BoressoStudio.EditorTools
{
    public static class CustomWindowIconUtil
    {
        private const string _iconPath = "Assets/Editor/CustomIcons/YourIconHere.png";
        public static Texture GetCustomWindowIcon => AssetDatabase.LoadAssetAtPath(_iconPath, typeof(Texture)) as Texture;
    }
}