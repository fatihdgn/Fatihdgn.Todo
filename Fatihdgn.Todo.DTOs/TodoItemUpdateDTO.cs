﻿namespace Fatihdgn.Todo.DTOs;

public class TodoItemUpdateDTO
{
    public string Content { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
