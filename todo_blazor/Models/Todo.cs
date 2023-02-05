using System;

namespace todo_blazor.Models{
    public class Todo{
        public int ID{get;set;}
        public string? Contents{get;set;}
        public bool IsCompleted{get;set;}
    }
}