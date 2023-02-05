using System;
using Microsoft.AspNetCore.Components;

namespace cals_blazor.Components{
    public partial class Calculator{
        public int Value1{get;set;} = 0;
        public int Value2{get;set;} = 20;
        public int Result{get;set;} = 0;

        [Parameter]
        public EventCallback<int> ChangeCalsResult {get;set;}

        public void Calc(){
            this.Result = this.Value1 + this.Value2;
            ChangeCalsResult.InvokeAsync(this.Result);
        }
    }
}