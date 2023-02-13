namespace Challenge04
{
    public class User
    {
        private readonly List<Post> _posts = new List<Post>() { };

        private readonly string _name;
        public string Name { get => _name; }

        public User(string name)
        {
            _name = name;
        }

        public void CreatePost(Post post)
        {
            _posts.Add(post);
        }

        public Post GetLastPost()
        {
            return _posts.Last();
        }
    }
}