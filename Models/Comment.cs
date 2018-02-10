using System;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public int ParentId { get; set; }
    public bool IsApproved { get; set; }
}