using System.IO;

public static class FileHelper
{
    public static string ReadFile(string filePath)
    {
        if (File.Exists(filePath)) {
            string content = File.ReadAllText(filePath);
            return content;
        }
        return "";
    }

    public static void WriteFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }

    public static bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    public static void DeleteFile(string filePath)
    {
        File.Delete(filePath);
    }
}
