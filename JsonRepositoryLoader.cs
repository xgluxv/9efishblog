using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyBlog
{
    public class JsonRepositoryLoader<T>
    {
        private string _fileName;

        public JsonRepositoryLoader(string fileName)
        {
            _fileName = fileName;
        }

        public List<T> Load()
        {
            var items = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(_fileName));
            items.Sort();
            return items;
        }
    }
}