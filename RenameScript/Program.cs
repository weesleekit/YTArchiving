// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Enter the folder path:");
string folderPath = Console.ReadLine();

if (Directory.Exists(folderPath))
{
    RenameFilesInFolder(folderPath);
    Console.WriteLine("File renaming completed.");
}
else
{
    Console.WriteLine("Invalid folder path. Exiting program.");
}

static void RenameFilesInFolder(string folderPath)
{
    string[] files = Directory.GetFiles(folderPath);
    foreach (string filePath in files)
    {
        RenameFile(filePath);
    }

    string[] subdirectories = Directory.GetDirectories(folderPath);
    foreach (string subdirectory in subdirectories)
    {
        RenameFilesInFolder(subdirectory);
    }
}

static void RenameFile(string filePath)
{
    string fileName = Path.GetFileName(filePath);

    // Extract matched groups
    string date = fileName.Substring(0, 10);
    string id = fileName.Split(' ')[1];
    string fileExtension = Path.GetExtension(filePath);
    if (fileExtension == ".vtt")
    {
        fileExtension = ".en.vtt";
    }
    string description = fileName.Replace($"{date} {id} ","").Replace($"{fileExtension}", "");

    string newFileName = $"{date} {description} [{id}]{fileExtension}";

    // Build the new file path
    string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);

    // Rename the file
    File.Move(filePath, newFilePath);

    Console.WriteLine($"Renamed: {filePath} -> {newFilePath}");
}