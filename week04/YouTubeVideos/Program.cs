using System;

class Program
{
    static void Main(string[] args)
    {
        Youtube newYouTube = new Youtube();

        string[] title = new string[] { "Drqgon Hell", "Heaven's Gate", "Mortal Man" };
        string[] author = new string[] { "Satan", "Michael", "Adam" };
        int[] length = new int[] { 300, 280, 290 };
        string[,] comment = new string[3, 3] { { "Nice movie, bad actors", "Satan delived a powerful experience.", "I liked the part of when Satan got punched in the face" }, { "Wow, that was amazing", "rubbish. Waste of time.", "So beautiful that there is a way back to Heavenly Father" }, { "Oh man, how evil is man", "They would have lived forever in happiness, if only Eve didn't eat the fruit. What a silly decision", "I cried and realized how Adam and Eve opened the door to salvation for all of God's children" } };
        string[,] commenter = new string[3, 3] { { "John", "Nephi", "Paul" }, { "Susan", "Ko Ko Beware", "Bishop" }, { "Big Bird", "Elvis", "Max" } };

        for (int i = 0; i < 3; i++)
        {
            Video newVideo = new Video(title[i], author[i], length[i]);


            for (int j = 0; j < 3; j++)
            {
                Comment newComment = new Comment(commenter[i, j], comment[i, j]);

                newVideo.AddComents(newComment);

                //Added comment to list in video class
                // newVideo = new Video(newComment);
            }

            newYouTube.AddVideo(newVideo);
            // newYouTube.DisplayAll();
        }

        newYouTube.DisplayAll();
        // Youtube newYouTube
    }
}