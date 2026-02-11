using System;

namespace Flow.Service
{
    public class AppState
    {
        public string? CurrentTask { get; private set; }
        public event Action? OnChange;

        public void SetCurrentTask(string? task)
        {
            CurrentTask = task;
            OnChange?.Invoke();
        }
    }
}