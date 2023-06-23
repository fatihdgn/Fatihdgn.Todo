﻿using FluentValidation;

namespace Fatihdgn.Todo.DTOs.Validators;

public class TodoItemCreateDTOValidator : AbstractValidator<TodoItemCreateDTO>
{
    public TodoItemCreateDTOValidator()
    {
        RuleFor(x => x.Content).NotEmpty();
        RuleFor(x => x.Note).NotEmpty();
    }
}

public class TodoItemUpdateDTOValidator : AbstractValidator<TodoItemUpdateDTO>
{
    public TodoItemUpdateDTOValidator()
    {
        RuleFor(x => x.Content).NotEmpty();
        RuleFor(x => x.Note).NotEmpty();
    }
}