﻿namespace Blog.Core.DTOs
{
    /// <summary>
    /// 分类
    /// </summary>
    public class CategoryDTO 
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public bool Enable { get; set; }
    }

    public class CategoryCreateDTO
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public bool Enable { get; set; }
    }
     
    public class CategoryUpdateDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public bool Enable { get; set; }
    }
}
