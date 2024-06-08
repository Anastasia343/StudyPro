

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
    //��������� ���������
    private async void ButtonClickOne(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpIntroduction());
    }
    //���������� � ���������
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpVariables());
    }
    //�������� � ���� ������
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpDataType());
    }
    //�������������� ��������
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpArithmeticOperations());
    }
    //������������ ��������
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpBitwiseOperations());
    }
    //�������� ������������
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpAssignmentOperations());
    }
    //�������������� ������� ����� ������
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpTransformationsBasicData());
    }
    //�������� ���������
    private async void ButtonClickElght(object senter, EventArgs e)
    {
         await Navigation.PushAsync(new CSharpConditionalExpressions());
    }
    //if/else
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpIfElseConstruction());
    }
    //�����
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        await Navigation.PushAsync(new CSharpCycles());
    }
    ////�������
    //public async void ButtonClickRestart(object senter, EventArgs e)
    //{
    //    bool restart = await DisplayAlert("�������", "� � ������ ������� �� ��������, �� ��������� ���� ���������", "��������", "������");
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