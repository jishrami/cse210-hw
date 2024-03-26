using System;

class Program
{
    static void Main(string[] args)
    {
        Comment c1v1 = new Comment();
        c1v1.comment = "This is a great video!";
        c1v1.commenter = "Samuel";

        Comment c2v1 = new Comment();
        c2v1.commenter = "Jill";
        c2v1.comment = "I agree with Samuel's comment. I'll watch it again.";

        Comment c1v2 = new Comment();
        c1v2.comment = "This is a video!";
        c1v2.commenter = "Samuel";

        Comment c2v2 = new Comment();
        c2v2.commenter = "Kylee";
        c2v2.comment = "This video is not good!";



        Video v1 = new Video();
        v1.title = "Me at the Zoo";
        v1.author = "Tim";
        v1.comments = new List<Comment> {c1v1,c2v1};
        v1.length = 120;

        Video v2 = new Video();
        v2.author = "Andrew";
        v2.title = "Cats";
        v2.comments = new List<Comment> {c1v2,c2v2};
        v2.length = 60;

        v1.displayVideo();
        v2.displayVideo();
    }
}