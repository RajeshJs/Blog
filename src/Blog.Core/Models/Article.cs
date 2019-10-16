﻿using Blog.Core.Sparrow;
using System;

namespace Blog.Core.Models
{
    public class Article : IEntity<string>
    {
        public string Id { get; private set; }

        public string Title { get; private set; }

        public string Digest { get; private set; }

        public string Content { get; private set; }

        public bool IsDraft { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime Creation { get; private set; }
    }
}
