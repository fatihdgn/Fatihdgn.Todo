﻿using Fatihdgn.Todo.Context;
using Fatihdgn.Todo.Entities;

namespace Fatihdgn.Todo.Repositories;

public class TodoItemCommandRepository : TodoDBCommandRepository<TodoItemEntity>, ITodoItemCommandRepository
{
    public TodoItemCommandRepository(TodoDB context) : base(context) { }
}