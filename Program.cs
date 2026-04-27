using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> posts = new List<string>();

        
        Dictionary<string, int> likes = new Dictionary<string, int>();

       
        HashSet<int> users = new HashSet<int>();

       
        Stack<string> actions = new Stack<string>();

      
        Queue<string> notifications = new Queue<string>();


    
        users.Add(1);
        users.Add(2);
        users.Add(1); // duplicate

        // Add posts
        posts.Add("First Post");
        posts.Add("Second Post");

        // Initialize likes
        likes["First Post"] = 0;
        likes["Second Post"] = 0;

        // User likes a post
        likes["First Post"]++;
        actions.Push("Liked First Post");
        notifications.Enqueue("Someone liked your First Post");

        // Another like
        likes["First Post"]++;
        actions.Push("Liked First Post");
        notifications.Enqueue("Someone liked your First Post");

        // Undo last action
        Console.WriteLine("Undo Last Action:");
        if (actions.Count > 0)
        {
            string lastAction = actions.Pop();
            Console.WriteLine($"Undo: {lastAction}");

            // Reverse effect (simple logic)
            if (lastAction.Contains("Liked First Post"))
            {
                likes["First Post"]--;
            }
        }

        // Display posts and likes
        Console.WriteLine("\nPosts & Likes:");
        foreach (var post in posts)
        {
            Console.WriteLine($"{post} → {likes[post]} likes");
        }

        // Process notifications (FIFO)
        Console.WriteLine("\nNotifications:");
        while (notifications.Count > 0)
        {
            Console.WriteLine(notifications.Dequeue());
        }

        // Show unique users
        Console.WriteLine("\nUnique Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"User ID: {user}");
        }
    }
}