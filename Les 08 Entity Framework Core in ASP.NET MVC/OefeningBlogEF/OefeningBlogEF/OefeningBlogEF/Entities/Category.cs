﻿namespace OefeningBlogEF.Entities;

public class Category
{
    public Category()
    {
        Posts = new List<Post>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Post> Posts { get; set; } 
}
