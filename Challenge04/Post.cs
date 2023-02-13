namespace Challenge04
{
    public class Post
    {
        private readonly string _name;
        private readonly string _body;

        private readonly List<User> _usersLike = new List<User>() { };

        public Post(string name, string body)
        {
            _name = name;
            _body = body;
        }

        public void LikeBy(string name)
        {
            User user = new User(name);
            _usersLike.Add(user);
        }

        public string GetLikes()
        {
            var count = _usersLike.Count();

            if (count >= 3)
                return string.Format("{0}, {1} and {2} others like your post", _usersLike[0].Name, _usersLike[1].Name, count);
            else if (count >= 2)
                return string.Format("{0} and {1} like your post", _usersLike[0].Name, _usersLike[1].Name);
            else if (count == 1)
                return string.Format("{0} likes your post", _usersLike[0].Name);

            return "0 likes";
        }       

    }
}