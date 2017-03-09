using System;
using System.IO;
namespace MyBlog
{
    public class Post: IEquatable<Post>, IComparable<Post>
    {
        public Post()
        {
            Content = new Lazy<string>(() => 
            {
                var html = string.Empty;
                var fileName = Path.Combine(GlobalString.WebRootPath, "posts", Slug);
                fileName = Path.Combine(fileName, Slug + ".html");
                if (File.Exists(fileName))
                {
                    html = File.ReadAllText(fileName);
                }
                return html;
            });
        }
        public string Slug { get; set; }
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public string[] Tags { get; set; }
        public Lazy<string> Content{get;set;}
        public string FeaturedImage{get;set;}

        public int CompareTo(Post other)
        {
            if (other == null)
                return -1;

            return this.Published.CompareTo(other.Published);
        }

        public bool Equals(Post other)
        {
            if (other == null)
                return false;
            return this.Published.Equals(other.Published);
        }
    }
}