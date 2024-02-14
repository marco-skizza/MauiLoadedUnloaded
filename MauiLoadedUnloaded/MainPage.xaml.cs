namespace MauiLoadedUnloaded
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnLoaded(object? sender, EventArgs e)
        {
            var debug = 0;
        }

        private void OnUnloaded(object? sender, EventArgs e)
        {
            var debug = 0;
        }

        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }
    }
}