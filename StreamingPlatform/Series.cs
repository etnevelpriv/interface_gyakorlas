using System;

namespace StreamingPlatform;

public class Series:IContent
{
    public string Title {get;private set;}
    public List<Video> Videos {get;private set;}

    public Series(string title, Video video)
    {
        this.Title = title;
        this.Videos = new List<Video>();
        this.Videos.Add(video);
    }
    public Series(string title, List<Video> videos)
    {
        this.Title = title;
        this.Videos = videos;
    }
    public string GetTitle()
    {
        return this.Title;
    }
    public int GetLength()
    {
        int summedLength = 0;
        foreach(Video video in this.Videos)
        {
            summedLength += video.Length;
        }
        return summedLength;
    }
}
