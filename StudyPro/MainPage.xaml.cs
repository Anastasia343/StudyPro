namespace StudyPro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClickOne(object senter, EventArgs e)
        {
            await Navigation.PushAsync(new CSharp());
        }
    }

}
