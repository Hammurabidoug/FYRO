using FYRO.Application.Common.Mappings;
using FYRO.Domain.Entities;

namespace FYRO.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
