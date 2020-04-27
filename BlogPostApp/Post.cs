using System;
using System.Collections.Generic;

namespace BlogPostApp
{
    public class Post
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }


        //Constructor
        public Post(string title, string message, string author, string date)
        {
            Title = title;
            Message = message;
            Author = author;
            Date = date;
        }


        //Method
        public void ReadPost()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Author {Author}");
            Console.WriteLine($"Date: {Date}");
        }

        public void UpdateTitle(string updatedTitle)
        {
            Title = updatedTitle;
        }

        public void UpdateMessage(string updatedMessage)
        {
            Message = updatedMessage;
        }

        public void UpdateAuthor(string updatedAuthor)
        {
            Author = updatedAuthor;
        }

        public void UpdateDate(string updatedDate)
        {
            Date = updatedDate;
        }

        public void Delete(List<Post> postList, string deletionTitle)
        {
            Post postToRemove = null;

            foreach (var post in postList)
            {
                if (deletionTitle == post.Title)
                {
                    postToRemove = post;
                }
            }

            postList.Remove(postToRemove);

        }





    }
}
