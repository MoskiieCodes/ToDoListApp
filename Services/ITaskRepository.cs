using TodoAppBlazor.Models;
using System.Collections.Generic;

namespace TodoAppBlazor.Services;

public interface ITaskRepository
{
    void Add(TaskItem task);
    void Update(TaskItem task);
    void Delete(int id);
    TaskItem? GetById(int id);
    List<TaskItem> GetAll();
}
