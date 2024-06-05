namespace StudyPro;

public partial class CSharp : ContentPage
{
	public CSharp()
	{
		InitializeComponent();
	}
    private async void ButtonClickOne(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIntroduction ());
    }
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpVariables());
    }
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        await Navigation.PushAsync (new CSharpDataType());
    }
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpArithmeticOperations());
    }
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpBitwiseOperations());
    }
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpAssignmentOperations());
    }
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpTransformationsBasicData());
    }
    private async void ButtonClickElght(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpConditionalExpressions());
    }
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIfElseConstruction());
    }
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpCycles());
    }
}