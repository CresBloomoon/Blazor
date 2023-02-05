using System;
using Microsoft.AspNetCore.Components;

namespace hello_blazor.Pages{
    public class IndexBase : ComponentBase{
        protected string Message{get;set;} = "Hello Blazor";
        protected string CurrentDateTime{get;set;} = "???";
        protected void GetDateTime(){
            CurrentDateTime = DateTime.Now.ToString("yyyy/MM/dd H:m:s");
        }
    }
}