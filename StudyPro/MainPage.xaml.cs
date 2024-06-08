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
        private async void ButtonClickTwo(object senter, EventArgs e)
        {
            await DisplayAlert("Не доступно", "В ближайшем времени будет доступно новое обновление с языком программирования C++", "ок");
        }
        private async void ButtonClickThree(object senter, EventArgs e)
        {
            await DisplayAlert("Не доступно", "В ближайшем времени будет доступно новое обновление с языком программирования Puthon", "ок");
        }
    }

}
