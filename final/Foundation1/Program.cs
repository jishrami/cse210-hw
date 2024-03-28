using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Comment c1v1 = new Comment();
        c1v1.comment = "This is a great video!";
        c1v1.commenter = "Samuel";

        Comment c2v1 = new Comment();
        c2v1.commenter = "Jill";
        c2v1.comment = "I agree with Samuel's comment. I'll watch it again.";

        Comment c3v1 = new Comment();
        c3v1.comment = "Awesome content!";
        c3v1.commenter = "Sarah";

        Comment c1v2 = new Comment();
        c1v2.comment = "This is a video!";
        c1v2.commenter = "Samuel";

        Comment c2v2 = new Comment();
        c2v2.commenter = "Kylee";
        c2v2.comment = "This video is not good!";

        Comment c3v2 = new Comment();
        c3v2.comment = "I love cats!";
        c3v2.commenter = "Emma";

        Comment c1v3 = new Comment();
        c1v3.comment = "Amazing performance!";
        c1v3.commenter = "Michael";

        Comment c2v3 = new Comment();
        c2v3.commenter = "Elena";
        c2v3.comment = "This is my favorite video ever!";

        Comment c3v3 = new Comment();
        c3v3.comment = "Inspirational!";
        c3v3.commenter = "Chris";


        Video v1 = new Video();
        v1.title = "Me at the Zoo";
        v1.author = "Tim";
        v1.comments = new List<Comment> { c1v1, c2v1, c3v1 };
        v1.length = 120;

        Video v2 = new Video();
        v2.author = "Andrew";
        v2.title = "Cats";
        v2.comments = new List<Comment> { c1v2, c2v2, c3v2 };
        v2.length = 60;

        Video v3 = new Video();
        v3.title = "Amazing Acrobatics";
        v3.author = "Sarah";
        v3.comments = new List<Comment> { c1v3, c2v3, c3v3 };
        v3.length = 180;

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.Clear();
            Console.WriteLine($"Title: {video.title} by {video.author} with a length of {video.length} seconds");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"{comment.comment} - {comment.commenter}");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
