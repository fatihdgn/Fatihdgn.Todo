﻿using Fatihdgn.Todo.Repositories;
using Fatihdgn.Todo.Repositories.Abstractions;

namespace Microsoft.Extensions.DependencyInjection;

public static class TodoRepositoriesExtensions
{
    public static IServiceCollection AddTodoDBRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICommandRepository<,>), typeof(TodoDBCommandRepository<,>));
        services.AddScoped(typeof(IQueryRepository<,>), typeof(TodoDBQueryRepository<,>));
        services.AddScoped(typeof(IRepository<,>), typeof(TodoDBRepository<,>));

        services.AddScoped<ITodoItemCommandRepository, TodoItemCommandRepository>();
        services.AddScoped<ITodoItemQueryRepository, TodoItemQueryRepository>();
        services.AddScoped<ITodoItemRepository, TodoItemRepository>();

        services.AddScoped<ITodoListCommandRepository, TodoListCommandRepository>();
        services.AddScoped<ITodoListQueryRepository, TodoListQueryRepository>();
        services.AddScoped<ITodoListRepository, TodoListRepository>();

        services.AddScoped<ITodoTemplateCommandRepository, TodoTemplateCommandRepository>();
        services.AddScoped<ITodoTemplateQueryRepository, TodoTemplateQueryRepository>();
        services.AddScoped<ITodoTemplateRepository, TodoTemplateRepository>();

        services.AddScoped<ITodoUserCommandRepository, TodoUserCommandRepository>();
        services.AddScoped<ITodoUserQueryRepository, TodoUserQueryRepository>();
        services.AddScoped<ITodoUserRepository, TodoUserRepository>();

        return services;
    }
}
