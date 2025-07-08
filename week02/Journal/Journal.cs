using System.IO;

public class Journal
{
    public string _fileName;
    public string _question;
    public string _FileContent;
    public List<string> _entries = new List<string>();

    public string _date;

    public void SaveToFile()
    {

        //In this function, I save the file in my working directory
        // and give it the name that the user types.
        string directoryPath = @"C:\Users\lchil\OneDrive\Desktop\cse210new";
        string path = _fileName;
        string fullPath = Path.Combine(directoryPath, path);

        using (FileStream fs = File.Create(fullPath))
        {
            byte[] content = new System.Text.UTF8Encoding(true).GetBytes($"Date: {_date} - Prompt: {_question}\n {_FileContent}\n \n");
            fs.Write(content, 0, content.Length);

        }
    }

    //public void SaveFile()
    //{
        //string directory = @"C:\Users\lchil\OneDrive\Desktop\cse210new";
        //string path = _fileName;
        //string fullPath = Path.Combine(directory, path);
        //using (FileStream fs = File.Create(fullPath))
        //{ }

    //}

    public void AppendToFile()
    {
        string directoryPath = @"C:\Users\lchil\OneDrive\Desktop\cse210new";
        string FileName = _fileName;

        string fullPath = Path.Combine(directoryPath, FileName);
        string newContent = $"Date: {_date} - Prompt: {_question}\n {_FileContent}\n \n";

        // Append text to the file
        File.AppendAllText(fullPath, newContent);

    }

    public void LoadFromFile()
    {
        string content = File.ReadAllText(_fileName);
        Console.WriteLine(content);
    }

    public void Read()
    {
        string directoryPath = @"C:\Users\lchil\OneDrive\Desktop\cse210new";
        string path = _fileName;
        string fullPath = Path.Combine(directoryPath, path);

        string content = File.ReadAllText(fullPath);
        Console.WriteLine(content);
    }

    public void createNewFile()
    {
        string oldFileName = @"C:\Users\lchil\OneDrive\Desktop\cse210new\original.txt";
        string newFileName = @"C:\Users\lchil\OneDrive\Desktop\cse210new\"+_fileName;

        File.Move(oldFileName, newFileName);

    }
}



