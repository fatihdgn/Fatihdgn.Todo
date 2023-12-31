﻿namespace Fatihdgn.Todo.DTOs;


public class TodoItemDTO
{
    public Guid Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
