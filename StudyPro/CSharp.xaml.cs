

namespace StudyPro;

public partial class CSharp : ContentPage
{
    public CSharp()
    {
        InitializeComponent();
        //      GlobalState.buttonCSharp = restartButtonOne;
        //      GlobalState.buttonCSharp = restartButtonNine;
        GlobalState.labelCSharp = result;
    }
    //структура программы
    private async void ButtonClickOne(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpIntroduction());
    }
    //переменные и константы
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpVariables());
    }
    //Литералы и Типы данных
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpDataType());
    }
    //Арифметические операции
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpArithmeticOperations());
    }
    //Подразрядные операции
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpBitwiseOperations());
    }
    //Операции присваивания
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpAssignmentOperations());
    }
    //Преобразования базовых типов данных
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpTransformationsBasicData());
    }
    //Условные выражения
    private async void ButtonClickElght(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpConditionalExpressions());
    }
    //if/else
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIfElseConstruction());
    }
    //Циклы
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpCycles());
    }
    ////рестарт
    //public async void ButtonClickRestart(object senter, EventArgs e)
    //{
    //    bool restart = await DisplayAlert("Рестарт", "В в случае нажатия на согласен, Вы обнуляете свой результат", "согласен", "отмена");
    //    if (restart)
    //    {
    //        restartButtonOne.BackgroundColor = Colors.Gray;
    //        restartButtonTwo.BackgroundColor = Colors.Gray;
    //        restartButtonThree.BackgroundColor = Colors.Gray;
    //        restartButtonFour.BackgroundColor = Colors.Gray;
    //        restartButtonFive.BackgroundColor = Colors.Gray;
    //        restartButtonSix.BackgroundColor = Colors.Gray;
    //        restartButtonSeven.BackgroundColor = Colors.Gray;
    //        restartButtonElght.BackgroundColor = Colors.Gray;
    //        restartButtonNine.BackgroundColor = Colors.Gray;
    //    }
    //}
}