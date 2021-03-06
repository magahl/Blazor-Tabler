﻿
using Microsoft.AspNetCore.Components;

namespace Tabler.Components
{
   public partial class TablerTab : TablerBaseComponent, ITablerTab
    {
        [CascadingParameter] TablerTabs ContainerTabSet { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public RenderFragment Header { get; set; }

        string TitleCssClass => ContainerTabSet.ActiveTab == this ? "active" : null;

        protected override void OnInitialized()
        {
            ContainerTabSet.AddTab(this);
        }

        public void Dispose()
        {
            ContainerTabSet.RemoveTab(this);
        }

        void Activate()
        {
            ContainerTabSet.SetActivateTab(this);
        }
    }
}
