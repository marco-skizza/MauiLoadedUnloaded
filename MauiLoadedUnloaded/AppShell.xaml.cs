﻿namespace MauiLoadedUnloaded
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
        }
    }
}
