using System;
using System.Collections.Generic;

namespace BlogPostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> postList = new List<Post>();
            Post newPost = new Post(null, null, null, null);


            //CRUD Actions - Create, Read, Update, Delete


            while (true)
            {
                Console.WriteLine("Please choose a menu option [1]Create Post [2]Update [3]Delete [4]Read All [5]Read Post by Author");
                string userInput = Console.ReadLine();

                //Main Menu
                switch (userInput)
                {
                    case "1":
                        Console.Write("What is your title:");
                        string blogTitle = Console.ReadLine().ToLower().Trim();

                        Console.Write("What is your message:");
                        string blogMessage = Console.ReadLine().ToLower().Trim();

                        Console.Write("Who is your author:");
                        string blogAuthor = Console.ReadLine().ToLower().Trim();

                        Console.Write("What is the date:");
                        string blogDate = Console.ReadLine().ToLower().Trim();

                        newPost = new Post(blogTitle, blogMessage, blogAuthor, blogDate);
                        postList.Add(newPost);

                        break;
                    case "2":
                        //TODO: Update Submenu
                        Console.WriteLine("Choose the post property you want to update: [1]Title [2]Message [3]Author [4]Date");
                        string updateChoice = Console.ReadLine();

                        switch (updateChoice)
                        {
                            case "1":
                                //Todo refactor to methods
                                //Todo make it so we can update any post
                                Console.WriteLine("What post title would you like to update?");
                                string titleToUpdate = Console.ReadLine().ToLower().Trim();


                                EditPost(postList, titleToUpdate, updateChoice);


                                //Test
                                newPost.ReadPost();

                                break;

                            case "2":
                                Console.WriteLine("What is the title of the message you want to update?");
                                string titleToUpdateMessage = Console.ReadLine().ToLower().Trim();

                                EditPost(postList, titleToUpdateMessage, updateChoice);

                                //Test
                                newPost.ReadPost();
                                break;

                            case "3":
                                Console.WriteLine("What is the title of the author you want to update?");
                                string titleToUpdateAuthor = Console.ReadLine().ToLower().Trim();

                                EditPost(postList, titleToUpdateAuthor, updateChoice);

                                //Test
                                newPost.ReadPost();
                                break;
                            case "4":
                                Console.WriteLine("What is the title of the date you want to update?");
                                string titleToUpdateDate = Console.ReadLine().ToLower().Trim();

                                EditPost(postList, titleToUpdateDate, updateChoice);

                                //Test
                                newPost.ReadPost();
                                break;
                            default:
                                Console.WriteLine("Please choose a valid update option.");
                                break;
                        }
                        break;

                    //END SUBMENU

                    //CONTINUE MAIN MENU
                    case "3":
                        Console.WriteLine("Please enter the title of the post you want to delete");
                        string deletionTitle = Console.ReadLine().ToLower().Trim();

                        newPost.Delete(postList, deletionTitle);

                        break;
                    case "4":
                        foreach (var post in postList)
                        {
                            post.ReadPost();
                        }
                        break;
                    case "5":

                        Console.WriteLine("Which author's post would you like to view?");
                        string authorsPostToView = Console.ReadLine().ToLower().Trim();

                        foreach (var post in postList)
                        {
                            if (authorsPostToView == post.Author)
                            {
                                post.ReadPost();
                            }
                        }


                        break;

                    default:
                        Console.WriteLine("Please make a valid choice");
                        break;
                }



            }


            Console.ReadLine();


        }

        private static void EditPost(List<Post> postList, string itemToUpdate, string userMenuChoice)
        {
            var numOfPostThatExist = NumOfPostThatExist(postList, itemToUpdate);


            if (numOfPostThatExist != 0)
            {
                foreach (var item in postList)
                {
                    if (itemToUpdate == item.Title)
                    {
                        Console.WriteLine("What would you like the update to be?");
                        string userUpdatedChoice = Console.ReadLine();

                        if (userMenuChoice == "1")
                        {
                            item.UpdateTitle(userUpdatedChoice);
                        }else if (userMenuChoice == "2")
                        {
                            item.UpdateMessage(userUpdatedChoice);
                        }else if (userMenuChoice == "3")
                        {
                            item.UpdateAuthor(userUpdatedChoice);
                        }else if (userMenuChoice == "4")
                        {
                            item.UpdateDate(userUpdatedChoice);
                        }
                        else
                        {
                            Console.WriteLine("Valid input please?");
                        }

                    }

                    
                }
            }
            else
            {
                Console.WriteLine("There are no post by that title.");
            }
        }

        private static int NumOfPostThatExist(List<Post> postList, string itemToUpdate)
        {
            int numOfPostThatExist = 0;

            foreach (var item in postList)
            {
                if (itemToUpdate == item.Title)
                {
                    numOfPostThatExist++;
                }
            }

            return numOfPostThatExist;
        }

    }
}
