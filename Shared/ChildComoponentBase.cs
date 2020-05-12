using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brello.Shared
{
    public class ChildComoponentBase : ComponentBase
    {
        
    [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected bool DarkThemeOn;
        protected string AlertTheme => DarkThemeOn ? "dark" : "light";

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }

    }

}
