using System;
using System.Reflection;

namespace StreamingPlatform;

public class Video
{
    public string Title { get; private set; }
    public int Length { get; private set; }

    public Video(string title, int length)
    {
        this.Title = title;
        this.Length = length;
    }
}
