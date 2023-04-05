using System.IO;
using UnityEngine;

public class FolderCreator : MonoBehaviour
{
    private void Start()
    {
        string assetsFolderPath = Application.dataPath;

        CreateFolder(assetsFolderPath, "Textures");
        CreateFolder(assetsFolderPath, "Scenes");
        CreateFolder(assetsFolderPath, "Prefabs");
        CreateFolder(assetsFolderPath, "Scripts");
        CreateFolder(assetsFolderPath, "Plugins");
        CreateFolder(assetsFolderPath, "Resources");
    }

    private void CreateFolder(string parentFolder, string folderName)
    {
        string folderPath = Path.Combine(parentFolder, folderName);

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log($"Folder created: {folderPath}");
        }
        else
        {
            Debug.LogWarning($"Folder already exists: {folderPath}");
        }
    }
}
