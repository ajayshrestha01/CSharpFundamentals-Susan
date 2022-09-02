//File - Create,Read,Write,Delete,Move,Copy
//Directory- Create,Delete,Move,Copy

public class FileIO
{
        string rootPath = @"C:\Apps\CSharpFundamentals-Susan\CSharpBasics\Lessions\FileIOTest";//use verbatim character-@ else / will be treated as /n type and error will be shown
                                                                                               //@ will imply that \ is part of string

    public void LearnFileHandling()
    {
        string filePath = rootPath + @"\abc.txt";
        File.WriteAllText(filePath, "This is First Line");
        File.AppendAllText(filePath, "This is Second Line");

        FileInfo fi = new FileInfo(filePath);
        Console.WriteLine($"Created: {fi.CreationTime}");
        Console.WriteLine($"Size: {fi.Length} bytes");
        Console.WriteLine($"Modified: {fi.LastWriteTime}");
        Console.WriteLine($"File Name: {fi.FullName}");
    }
    public void LearnFolderHandling()
    {
string folderPath = $"{rootPath}\\abc";
Directory.CreateDirectory(folderPath);

    }
}