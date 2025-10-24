class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public void Edit(string newContent)
    {
        Content = newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        Title = newTitle; 
    }
    public override string ToString()
    {     
         return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main()
    {
        string[] arguments = Console.ReadLine().Split(", ").ToArray();
        Article newArticle = new Article(arguments[0], arguments[1], arguments[2]);

        int commandCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < commandCount; i++)
        {
            arguments = Console.ReadLine().Split(": ").ToArray();
            switch (arguments[0])
            {
                case "Edit":
                    newArticle.Edit(arguments[1]);
                    break;
                case "ChangeAuthor":
                    newArticle.ChangeAuthor(arguments[1]);
                    break;
                case "Rename":
                    newArticle.Rename(arguments[1]);
                    break;
            }
        }
        Console.WriteLine(newArticle.ToString());
    }
}