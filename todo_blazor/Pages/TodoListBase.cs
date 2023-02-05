using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using todo_blazor.Models;

namespace todo_blazor.Pages{
    public class TodoListBase : ComponentBase{
        public List<Todo> Todos{get;set;} = new List<Todo>();
        protected override void OnInitialized(){
            this.Todos.Add(new Todo(){ID = 0, Contents = "C#やる", IsCompleted = true});
            this.Todos.Add( new Todo() { ID = 1, Contents = "TypeScriptやる", IsCompleted = false } );
            this.Todos.Add( new Todo() { ID = 2, Contents = "Babelやる", IsCompleted = true } );
            this.Todos.Add( new Todo() { ID = 3, Contents = "Blazorやる", IsCompleted = false } );
            this.Todos.Add( new Todo() { ID = 4, Contents = "Goやる", IsCompleted = false } );
        }
    }
}