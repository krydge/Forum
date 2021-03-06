﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class SubClassModel
    {
        public  string Id { get; set; }
        public string Creator  { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime dateTime { get; set; }
        public PostModel Post { get; set; }

        public ICollection<CommentModel> CommentArray { get; set; }
    }
    
}
