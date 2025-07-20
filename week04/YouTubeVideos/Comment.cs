using System;

public class Comment
{
    public string _name { get; set; }
    public string _text { get; set; }

    public Comment(string commenterName, string text)
    {
        _name = commenterName;
        _text = text;
    }

    public string Display()
    {
        return $"- {_name}: {_text}";
    }
}
