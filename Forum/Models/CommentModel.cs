using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CommentModel
    {
        public string Id { get; set; }
        public string Creator { get; set; }
        public string Comment { get; set; }
        public DateTime dateTime { get; set; }

        public List<CommentModel> CommentArray {get; set;}
    }
}
