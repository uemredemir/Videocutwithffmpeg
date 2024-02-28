using System;
using FFmpeg;


class Program
{
    static void Main(string[] args)
    {
        
        var inputVideo = new MediaFile("selam.mp4");

      
        var startTime = TimeSpan.FromSeconds(10); 
        var duration = TimeSpan.FromSeconds(20);  

        
        var outputVideo = new MediaFile("selam3.mp4");

      
        var ffmpeg = new Engine();
        var options = new ConversionOptions { Seek = startTime, Output = outputVideo, Duration = duration };

        
        ffmpeg.Convert(inputVideo, outputVideo, options);

        Console.WriteLine("Video kesme işlemi tamamlandı.");
    }
}