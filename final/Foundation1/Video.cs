public class Video {
    public string title { get; set; } //title of video

    public string author { get; set; } //author of video

    public int length { get; set; } //length in seconds

    public List<Comment> comments { get; set; } //comments on video

    public void displayVideo(){

        Console.WriteLine($"Title: {title} by {author} with a length of {length} seconds");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in comments){
            Console.WriteLine($"{comment.comment} - {comment.commenter}");
        }
    }
}