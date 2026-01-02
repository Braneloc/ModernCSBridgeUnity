using System.IO;

using UnityEditor;
namespace UnitySupport.Editor
{
    static class CreateCsc
    {
        const string filename = "csc.rsp";
        const string content = "-langversion:10";

        [MenuItem("Assets/Create/Scripting/csc.rsp", priority = 180)]
        static void CreateFromScripting() => WriteFile(SelectedFolder());
        [MenuItem("Assets/Create/Support Code/csc.rsp", priority = 50)]
        static void CreateFromSupportCode() => WriteFile(SelectedFolder());
        static void WriteFile(string folder)
        {
            string path = Path.Combine(folder, filename);
            bool replace = File.Exists(path);

            File.WriteAllText(path, content);   // create or overwrite
            AssetDatabase.Refresh();

            EditorUtility.DisplayDialog(
                "Modern CS Bridge for Unity",
                replace
                    ? $"Replaced ‘{filename}’ in ‘{folder}’."
                    : $"Created ‘{filename}’ in ‘{folder}’.",
                "Close");
        }
        static string SelectedFolder()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject) ?? "Assets";
            if (path.Length == 0) path = "Assets";
            if (Path.HasExtension(path)) path = Path.GetDirectoryName(path);
            return path;
        }
    }
}
