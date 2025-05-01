using System.Net.Http.Json;
using TodoAppBlazor.Models;

namespace TodoAppBlazor.Services
{
    public class TaskApiService
    {
        private readonly HttpClient http;

        public TaskApiService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
            => await http.GetFromJsonAsync<List<TaskItem>>("api/tasks") ?? new List<TaskItem>();

        public async Task AddTaskAsync(TaskItem task)
            => await http.PostAsJsonAsync("api/tasks", task);

        public async Task MarkCompletedAsync(int id)
            => await http.PutAsync($"api/tasks/{id}/complete", null);

        public async Task DeleteTaskAsync(int id)
            => await http.DeleteAsync($"api/tasks/{id}");
    }
}
