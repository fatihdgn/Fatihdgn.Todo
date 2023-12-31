﻿using Fatihdgn.Todo.Entities;

namespace Fatihdgn.Todo.DTOs.Mappings.Entities
{
    public static class TodoItemEntityExtensions
    {
        public static TodoItemEntity ToEntity(this TodoItemDTO entity) => new TodoItemEntity
        {
            Id = entity.Id,
            Content = entity.Content,
            Note = entity.Note,
            IsCompleted = entity.IsCompleted,
        };

        public static TodoItemDTO ToDTO(this TodoItemEntity entity) => new TodoItemDTO
        {
            Id = entity.Id,
            Content = entity.Content,
            Note = entity.Note,
            IsCompleted = entity.IsCompleted,
        };

        public static TodoItemCreateDTO ToCreateDTO(this TodoItemEntity entity) => new TodoItemCreateDTO
        {
            Content = entity.Content,
            Note = entity.Note,
            IsCompleted = entity.IsCompleted,
        };

        public static TodoItemUpdateDTO ToUpdateDTO(this TodoItemEntity entity) => new TodoItemUpdateDTO
        {
            Content = entity.Content,
            Note = entity.Note,
            IsCompleted = entity.IsCompleted,
        };

        public static TodoItemPatchDTO ToPatchDTO(this TodoItemEntity entity) => new TodoItemPatchDTO
        {
            Content = entity.Content,
            Note = entity.Note,
            IsCompleted = entity.IsCompleted,
        };

        public static TodoItemEntity ApplyTo(this TodoItemCreateDTO self, TodoItemEntity entity)
        {
            entity.Content = self.Content;
            entity.Note = self.Note;
            entity.IsCompleted = self.IsCompleted;
            return entity;
        }

        public static TodoItemEntity ApplyTo(this TodoItemUpdateDTO self, TodoItemEntity entity)
        {
            entity.Content = self.Content;
            entity.Note = self.Note;
            entity.IsCompleted = self.IsCompleted;
            return entity;
        }

        public static TodoItemEntity ApplyTo(this TodoItemPatchDTO self, TodoItemEntity entity)
        {
            entity.Content = self.Content ?? entity.Content;
            entity.Note = self.Note ?? entity.Note;
            entity.IsCompleted = self.IsCompleted ?? entity.IsCompleted;
            return entity;
        }
    }
}
