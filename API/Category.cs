using System;
using Newtonsoft.Json;

namespace API
{
    //category class
    public class Category
    {
        public Category()
        {
        }
        
        [JsonProperty("cid")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
