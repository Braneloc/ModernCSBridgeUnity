using UnityEditor;

public class CsprojPostProcessor : AssetPostprocessor
{
    const string latest = "latest"; // 10.0
    /// <summary>
    /// Updates C# project files to C# latest 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    static string OnGeneratedCSProject(string path, string content) => content.Replace(
                "<LangVersion>9.0</LangVersion>",
                $"<LangVersion>{latest}</LangVersion>");
}
