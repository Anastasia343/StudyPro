

namespace StudyPro;

public partial class CSharp : ContentPage
{
    public CSharp()
    {
        InitializeComponent();
        GlobalState.LabelCSharp = result;
        GlobalState.RestartButtonOne = restartButtonOne;
        GlobalState.RestartButtonTwo = restartButtonTwo;
        GlobalState.RestartButtonThree = restartButtonThree;
        GlobalState.RestartButtonFour = restartButtonFour;
        GlobalState.RestartButtonFive = restartButtonFive;
        GlobalState.RestartButtonSix = restartButtonSix;
        GlobalState.RestartButtonSeven = restartButtonSeven;
        GlobalState.RestartButtonElght = restartButtonElght;
        GlobalState.RestartButtonNine = restartButtonNine;
    }
    //структура программы 10
    private async void ButtonClickOne(object senter, EventArgs e)
    { 
         await Navigation.PushAsync(new CSharpIntroduction());
    }
    //переменные и константы 20  restartButtonOne.BackgroundColor == Color.FromHsv(254, 35, 92)
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        var exepectedColorOne = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonOne.BackgroundColor.ToArgbHex() == exepectedColorOne.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpVariables());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Литералы и Типы данных 30
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        var exepectedColorTwo = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonTwo.BackgroundColor.ToArgbHex() == exepectedColorTwo.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpDataType());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Арифметические операции 40
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        var exepectedColorThree = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonThree.BackgroundColor.ToArgbHex() == exepectedColorThree.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpArithmeticOperations());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Подразрядные операции 50
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        var exepectedColorFour = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonFour.BackgroundColor.ToArgbHex() == exepectedColorFour.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpBitwiseOperations());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Операции присваивания 60
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        var exepectedColorFive = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonFive.BackgroundColor.ToArgbHex() == exepectedColorFive.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpAssignmentOperations());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Преобразования базовых типов данных 70
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
        var exepectedColorSix = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonSix.BackgroundColor.ToArgbHex() == exepectedColorSix.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpTransformationsBasicData());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Условные выражения 80
    private async void ButtonClickElght(object senter, EventArgs e)
    {
        var exepectedColorSeven = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonSeven.BackgroundColor.ToArgbHex() == exepectedColorSeven.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpConditionalExpressions());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //if/else 90
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        var exepectedColorElght = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonElght.BackgroundColor.ToArgbHex() == exepectedColorElght.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpIfElseConstruction());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //Циклы 100
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        var exepectedColorNine = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonNine.BackgroundColor.ToArgbHex() == exepectedColorNine.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpCycles());
        }
        else
            await DisplayAlert("Не доступно", "Необходимо изучить предыдущий урок", "ок");
    }
    //рестарт
    public async void ButtonClickRestart(object senter, EventArgs e)
    {
        bool restart = await DisplayAlert("Рестарт", "В в случае нажатия на согласен, Вы обнуляете свой результат", "согласен", "отмена");
        if (restart)
        {
            restartButtonOne.BackgroundColor = Colors.Gray;
            restartButtonTwo.BackgroundColor = Colors.Gray;
            restartButtonThree.BackgroundColor = Colors.Gray;
            restartButtonFour.BackgroundColor = Colors.Gray;
            restartButtonFive.BackgroundColor = Colors.Gray;
            restartButtonSix.BackgroundColor = Colors.Gray;
            restartButtonSeven.BackgroundColor = Colors.Gray;
            restartButtonElght.BackgroundColor = Colors.Gray;
            restartButtonNine.BackgroundColor = Colors.Gray;
        }
    }
}