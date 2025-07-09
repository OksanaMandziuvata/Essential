namespace BookApp
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string titleText, string authorName, string contentText)
        {
            title = new Title(titleText);
            author = new Author(authorName);
            content = new Content(contentText);
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
