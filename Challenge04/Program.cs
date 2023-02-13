namespace Challenge04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Mike");
            user.CreatePost(new Post("Mi 1er Post", "Mi mascota come demasiado") );

            var post = user.GetLastPost();

            Console.WriteLine("Enter names: ");

            while (true)
            {
                var name = Console.ReadLine();
                bool userQuit = string.IsNullOrWhiteSpace(name);
                if (userQuit)
                    break;

                post.LikeBy(name);
            }

            Console.WriteLine( post.GetLikes() );
        }
    }
}