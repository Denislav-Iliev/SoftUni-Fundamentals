
class Program
{
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
    static void Main()
    {
        List<Article> articles = new List<Article>();
        int articlesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < articlesCount; i++)
        {
            string[] arguments = Console.ReadLine().Split(", ");
            Article newArticle = new Article(arguments[0], arguments[1], arguments[2]);
            articles.Add(newArticle);
        }
         foreach (Article article in articles)
        {
            Console.WriteLine(article.ToString());
        }


    }
}