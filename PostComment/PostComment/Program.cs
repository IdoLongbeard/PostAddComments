using System;


namespace PostComment
{
    class Program
    {
        static void Main(string[] args)
        {
            string moment ="21/06/2018 13:05:44";
            string title = "Travelling to New Zealand!";
            string content = "I'm going to visit this wonderful country!!";
            int likes = 12;

            Convert.ToDateTime(moment);

            Post post = new Post(moment, title, content, likes);

            

            Comment comment = new Comment("Have a nice trip!");

            post.AddComment(comment);

            Console.WriteLine(post);


        }
    }
}
