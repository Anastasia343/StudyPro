
namespace StudyPro;

public partial class CSharp : ContentPage
{
    const string LabelKey = "SavedLabel";
    const string ButtonColorKey = "ButtonColor";
    public CSharp()
    {
        InitializeComponent();
        //GlobalState.LabelCSharp = result;
        GlobalState.RestartButtonOne = restartButtonOne;
        GlobalState.RestartButtonTwo = restartButtonTwo;
        GlobalState.RestartButtonThree = restartButtonThree;
        GlobalState.RestartButtonFour = restartButtonFour;
        GlobalState.RestartButtonFive = restartButtonFive;
        GlobalState.RestartButtonSix = restartButtonSix;
        GlobalState.RestartButtonSeven = restartButtonSeven;
        GlobalState.RestartButtonElght = restartButtonElght;
        GlobalState.RestartButtonNine = restartButtonNine;
        //���������
        GlobalState.LabelCSharp = Preferences.Get(LabelKey, GlobalState.LabelCSharp);
        result.Text = GlobalState.LabelCSharp;
        // �����
        restartButtonOne.BackgroundColor = GlobalState.RestartButtonColorOne;
        restartButtonTwo.BackgroundColor = GlobalState.RestartButtonColorTwo;
        restartButtonThree.BackgroundColor = GlobalState.RestartButtonColorThree;
        restartButtonFour.BackgroundColor = GlobalState.RestartButtonColorFour;
        restartButtonFive.BackgroundColor = GlobalState.RestartButtonColorFive;
        restartButtonSix.BackgroundColor = GlobalState.RestartButtonColorSix;
        restartButtonSeven.BackgroundColor = GlobalState.RestartButtonColorSeven;
        restartButtonElght.BackgroundColor = GlobalState.RestartButtonColorElght;
        restartButtonNine.BackgroundColor = GlobalState.RestartButtonColorNine;
    }
    //���� ���������
    protected override void OnAppearing()
    {
        base.OnAppearing();
        result.Text = GlobalState.LabelCSharp;
    }
    //���� ������
    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //    Preferences.Set("RestartButtonOne", restartButtonOne.BackgroundColor.ToHex());
    //}
    

    //��������� ��������� 10
    private async void ButtonClickOne(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        await Navigation.PushAsync(new CSharpIntroduction());
        Navigation.RemovePage(this);
    }
    //���������� � ��������� 20
    private async void ButtonClickTwo(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorOne = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonOne.BackgroundColor.ToArgbHex() == exepectedColorOne.ToArgbHex())
        {
            await Navigation.PushAsync(new CSharpVariables());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������� � ���� ������ 30
    private async void ButtonClickThree(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorTwo = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonTwo.BackgroundColor.ToArgbHex() == exepectedColorTwo.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpDataType());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������������� �������� 40
    private async void ButtonClickFour(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorThree = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonThree.BackgroundColor.ToArgbHex() == exepectedColorThree.ToArgbHex())
        {
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpArithmeticOperations());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //������������ �������� 50
    private async void ButtonClickFive(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorFour = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonFour.BackgroundColor.ToArgbHex() == exepectedColorFour.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpBitwiseOperations());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������� ������������ 60
    private async void ButtonClickSix(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorFive = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonFive.BackgroundColor.ToArgbHex() == exepectedColorFive.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpAssignmentOperations());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������������� ������� ����� ������ 70
    private async void ButtonClickSeven(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorSix = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonSix.BackgroundColor.ToArgbHex() == exepectedColorSix.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpTransformationsBasicData());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������� ��������� 80
    private async void ButtonClickElght(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorSeven = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonSeven.BackgroundColor.ToArgbHex() == exepectedColorSeven.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpConditionalExpressions());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //if/else 90
    private async void ButtonClickNine(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorElght = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonElght.BackgroundColor.ToArgbHex() == exepectedColorElght.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpIfElseConstruction());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //����� 100
    private async void ButtonClickTen(object senter, EventArgs e)
    {
        GlobalState.LabelCSharp = result.Text;
        var exepectedColorNine = Color.FromRgb(172, 153, 234);
        if (GlobalState.RestartButtonNine.BackgroundColor.ToArgbHex() == exepectedColorNine.ToArgbHex())
        {
            //GlobalState.LabelCSharp = result.Text;
            //Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            await Navigation.PushAsync(new CSharpCycles());
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���������� ������� ���������� ����", "��");
    }
    //�������
    public async void ButtonClickRestart(object senter, EventArgs e)
    {
        bool restart = await DisplayAlert("�������", "� � ������ ������� �� ��������, �� ��������� ���� ���������", "��������", "������");
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
            Preferences.Remove(LabelKey);
            GlobalState.LabelCSharp = "";
            result.Text = GlobalState.LabelCSharp;
        }
    }
}