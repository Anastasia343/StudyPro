namespace StudyPro;

public partial class CSharp : ContentPage
{
	public CSharp()
	{
		InitializeComponent();
	}
    //структура программы
    private async void ButtonClickOne(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIntroduction ());
    }
    //переменные и константы
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpVariables());
    }
    //Литералы и Типы данных
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        await Navigation.PushAsync (new CSharpDataType());
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
}