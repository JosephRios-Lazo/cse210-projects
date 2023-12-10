using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Exploring Ancient Rome", "Paula Basso", 900);

        Comment video1Comment1 = new Comment("Parker", "This video is truly inspiring! I love how you explore the ancient architecture and share their history.");
        Comment video1Comment2 = new Comment("James", "Your content always surprises me. I'm glad you're showcasing the beauty of Italy.");
        Comment video1Comment3 = new Comment("Emily", "Wonderful! I would love to visit those places someday.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Healthy 5-Minute Breakfast Recipes for Busy Mornings", "Rachel Smith", 480);

        Comment video2Comment1 = new Comment("Brian", "These recipes are a lifesaver! Quick, easy, and nutritious – exactly what I need to kickstart my day. Can't wait to try the avocado toast!");
        Comment video2Comment2 = new Comment("Daniel", "Finally, breakfast ideas that fit into my hectic schedule! Your recipes are not only delicious but also practical.");
        Comment video2Comment3 = new Comment("Thomas", "I've been looking for new breakfast recipes, and your video came at the perfect time!");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Diving into Italian Cuisine", "Mark Carter", 1200);

        Comment video3Comment1 = new Comment("Sarah", "My mouth was watering while watching this video!");
        Comment video3Comment2 = new Comment("Jessica", "I love how you present traditional italian dishes. I definitely need to try them all.");
        Comment video3Comment3 = new Comment("Michael", "Italian food is famous worldwide, and your videos perfectly capture its essence.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}