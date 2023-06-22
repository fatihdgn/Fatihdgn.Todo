﻿using Fatihdgn.Todo.Context;
using Fatihdgn.Todo.Entities.Abstractions;
using Fatihdgn.Todo.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using OneOf;
using OneOf.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fatihdgn.Todo.Repositories;

public class TodoDBQueryRepository<TEntity> : IQueryRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly TodoDB _context;

    public TodoDBQueryRepository(TodoDB context)
    {
        _context = context;
    }

    private DbSet<TEntity> Set => _context.Set<TEntity>();
    public async Task<OneOf<TEntity, NotFound>> FindAsync(Guid id)
    {
        var entity = await Set.FindAsync(id);
        if (entity == null) return new NotFound();
        return entity;
    }

    public IQueryable<TEntity> GetAll() => Set.AsQueryable();

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> exp) => Set.Where(exp);
}