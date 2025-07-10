using System.IO;

public class Journal
{
    public string _fileName;
    public string _question;
    public string _FileContent;

    public string _time;

    public string _date;

    public void SaveToFile()
    {

        //In this function, I save the file in my working directory
        // and give it the name that the user types.
        string path = _fileName;

        using (FileStream fs = File.Create(path))
        {
            byte[] content = new System.Text.UTF8Encoding(true).GetBytes($"Date: {_date} - Prompt: {_question}\n {_FileContent}\n Entered at: {_time}\n \n");
            fs.Write(content, 0, content.Length);

        }
    }

    public void AppendToFile()
    {
        string FileName = _fileName;

        string newContent = $"Date: {_date} - Prompt: {_question}\n {_FileContent}\n Entered at: {_time}\n \n";

        // Append text to the file
        File.AppendAllText(FileName, newContent);

    }

    public void LoadFromFile()
    {
        string FileName = _fileName;

        string content = File.ReadAllText(FileName);
        Console.WriteLine(content);
    }

    public void Read()
    {
        string path = _fileName;

        string content = File.ReadAllText(path);
        Console.WriteLine(content);
    }

    public void createNewFile()
    {
        string oldFileName = "original.txt";
        string newFileName = _fileName;

        File.Move(oldFileName, newFileName);

    }
}



