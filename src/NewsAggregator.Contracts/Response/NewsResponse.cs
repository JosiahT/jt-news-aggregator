using System.Security;

namespace NewsAggregator.Contracts.Response;

public class NewsResponse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Synopsis { get; set; }
    public string? Link { get; set; }
    public NewsDetail? Detail {get; set;}
    public string? Thumbnail { get; set; }
    public IEnumerable<string>? Tags { get; set; }
    public string Category { get; set; }
    public DateTime? DatePublished { get; set; }
    public Author? Author { get; set; }
    public Source? Source { get; set; }
}
