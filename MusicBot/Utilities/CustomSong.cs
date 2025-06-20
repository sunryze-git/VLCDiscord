using YoutubeExplode.Channels;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace MusicBot.Utilities;

public class CustomSong(string url, string title, string? author, IReadOnlyList<Thumbnail>? thumbnails, Stream stream) : IVideo
{
    public Stream Source { get; } = stream;
    public VideoId Id { get; } = new();
    public string Url { get; } = url;
    public string Title { get; } = title;
    public Author Author { get; } = new(new ChannelId(), author ?? "");
    public TimeSpan? Duration { get; } = TimeSpan.Zero;
    public IReadOnlyList<Thumbnail> Thumbnails { get; } = thumbnails ??
    [new Thumbnail("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgv5PskaP6expiqdoE7maiCUWqc399A8jdvA&s",
        new Resolution(914,1000))];

    public string? FormatType { get; set; }
}