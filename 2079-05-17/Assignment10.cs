public class DirectoriesAndFiles
{
    public void CreatingFolders()
    {
        string RootPath = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17";
        string FolderPath = $"{RootPath}\\Main Folder";
        Directory.CreateDirectory(FolderPath);

        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder1");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder2");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder3");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder4");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder5");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder6");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder7");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder8");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder9");
        Directory.CreateDirectory(@"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\\Folder10");

    }

    public void CreatingFiles()
    {
        string RootPath = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder1";
        string FilePath = $"{RootPath}\\Nepal.txt";
        File.WriteAllText(FilePath, "Country: Nepal ");
        File.AppendAllText(FilePath, "\nCapital: Kathmandu");

        string RootPath2 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder2";
        string FilePath2 = $"{RootPath2}\\India.txt";
        File.WriteAllText(FilePath2, "Country: India ");
        File.AppendAllText(FilePath2, "\nCapital: New Delhi");

        string RootPath3 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder3";
        string FilePath3 = $"{RootPath3}\\Australia.txt";
        File.WriteAllText(FilePath3, "Country: Australia ");
        File.AppendAllText(FilePath3, "\nCapital: Canberra");

        string RootPath4 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder4";
        string FilePath4 = $"{RootPath4}\\UnitedStates.txt";
        File.WriteAllText(FilePath4, "Country: United States ");
        File.AppendAllText(FilePath4, "\nCapital: Washington, D.C");

        string RootPath5 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder5";
        string FilePath5 = $"{RootPath5}\\England.txt";
        File.WriteAllText(FilePath5, "Country: England ");
        File.AppendAllText(FilePath5, "\nCapital: London");

        string RootPath6 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder6";
        string FilePath6 = $"{RootPath6}\\China.txt";
        File.WriteAllText(FilePath6, "Country: China ");
        File.AppendAllText(FilePath6, "\nCapital: Beijing");

        string RootPath7 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder7";
        string FilePath7 = $"{RootPath7}\\SouthKorea.txt";
        File.WriteAllText(FilePath7, "Country: South Korea ");
        File.AppendAllText(FilePath7, "\nCapital: Seoul");

        string RootPath8 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder8";
        string FilePath8 = $"{RootPath8}\\France.txt";
        File.WriteAllText(FilePath8, "Country: France ");
        File.AppendAllText(FilePath8, "\nCapital: Paris");

        string RootPath9 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder9";
        string FilePath9 = $"{RootPath9}\\Switzerland.txt";
        File.WriteAllText(FilePath9, "Country: Switzerland ");
        File.AppendAllText(FilePath9, "\nCapital: Bern");

        string RootPath10 = @"C:\Apps\CSharpFundamentals-Susan\2079-05-17\Main Folder\Folder10";
        string FilePath10 = $"{RootPath10}\\Germany.txt";
        File.WriteAllText(FilePath10, "Country: Germany ");
        File.AppendAllText(FilePath10, "\nCapital: Berlin");
    }
}