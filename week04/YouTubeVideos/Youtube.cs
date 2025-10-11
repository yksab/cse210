using System;
using System.Collections.Generic;

public class Youtube
{
    private List<Video> _videos = new List<Video>();
    
    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n" + "List of Youtube Video's & Commets:");

        foreach (Video video in _videos)
        {
            video.DisplayVideos();
        }

        Console.WriteLine("\n\n");
    }
}