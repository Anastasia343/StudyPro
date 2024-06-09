

namespace StudyPro;

public partial class CSharp : ContentPage
{
    public CSharp()
    {
        InitializeComponent();
        GlobalState.labelCSharp = result;
        //GlobalState.buttonCSharp = restartButtonOne;
        //GlobalState.buttonCSharp = restartButtonTwo;
        //GlobalState.buttonCSharp = restartButtonThree;
        //GlobalState.buttonCSharp = restartButtonFour;
        //GlobalState.buttonCSharp = restartButtonFive;
        //GlobalState.buttonCSharp = restartButtonSix;
        //GlobalState.buttonCSharp = restartButtonSeven;
        //GlobalState.buttonCSharp = restartButtonElght;
        //GlobalState.buttonCSharp = restartButtonNine;
    }
    //��������� ��������� 10
    private async void ButtonClickOne(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpIntroduction());
    }
    //���������� � ��������� 20
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpVariables());
    }
    //�������� � ���� ������ 30
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpDataType());
    }
    //�������������� �������� 40
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpArithmeticOperations());
    }
    //������������ �������� 50
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpBitwiseOperations());
    }
    //�������� ������������ 60
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpAssignmentOperations());
    }
    //�������������� ������� ����� ������ 70
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpTransformationsBasicData());
    }
    //�������� ��������� 80
    private async void ButtonClickElght(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpConditionalExpressions());
    }
    //if/else 90
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIfElseConstruction());
    }
    //����� 100
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpCycles());
    }
    //�������
    public async void ButtonClickRestart(object senter, EventArgs e)
    {
        bool restart = await DisplayAlert("�������", "� � ������ ������� �� ��������, �� ��������� ���� ���������", "��������", "������");
        if (restart)
        {
            //restartButtonOne.BackgroundColor = Colors.Gray;
            //restartButtonTwo.BackgroundColor = Colors.Gray;
            //restartButtonThree.BackgroundColor = Colors.Gray;
            //restartButtonFour.BackgroundColor = Colors.Gray;
            //restartButtonFive.BackgroundColor = Colors.Gray;
            //restartButtonSix.BackgroundColor = Colors.Gray;
            //restartButtonSeven.BackgroundColor = Colors.Gray;
            //restartButtonElght.BackgroundColor = Colors.Gray;
            //restartButtonNine.BackgroundColor = Colors.Gray;
        }
    }
}