using System;

namespace StreamingPlatform;

public class Movie : IContent
{
    public Video Video {get;private set;}

    public Movie (Video video)
    {
        this.Video = video;
    }

    public string GetTitle()
    {
        return this.Video.Title;
    }

    public int GetLength()
    {
        return this.Video.Length;
    }
}
