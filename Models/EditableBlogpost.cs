using Models;

public class EditableBlogpost
{
    public Guid? Id { get; set; } = null;
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime PublishedDate { get; set; }
    public string BlogpostMarkdown { get; set; } = string.Empty;
    public Blogpost ToBlogPost(string[] tags) => new Blogpost
    (
    Id.GetValueOrDefault(),
    Title,
    Author,
    PublishedDate,
    tags,
    BlogpostMarkdown
    );
}
