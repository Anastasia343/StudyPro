using System.Windows.Input;

namespace StudyPro;

public partial class CSharpIntroduction : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpIntroduction()
	{
		InitializeComponent();
        TextWebView();
    }
    private void TextWebView()
    {
        string html = @"
        <!DOCTYPE html>
        <html>
        <head>
            <style>
            body {
                font-size: 16px;
                text-align: justify;
                padding: 10px;
                color:#ACACAC;
            }
        </style>
        </head>
        <body>
            <p>���������� ���������</p>
            <p>���� ��� ��������� �� ����� C# ���������� � ����� � ����������� .cs. �� ��������� � �������, ������� ��������� � Visual Studio
            ��� ���� ���� ���� � ����� C# - ���� Program.cs. ������ ��� ����� Program.cs ����������� �� ���������, ���� �� �������� ������ �� ����������.
            �� ��� ������������� �� ����� ����� ��������� ������ ����� � ����� C#.</p>
            <p>����������</p>
            <p>������� ������������ ������ ��������� �������� ���������� (statement). ���������� ������������ ��������� ��������, ��������, ��������������
            ��������, ����� ������, ���������� ���������� � ���������� �� ��������. � ����� ������ ���������� � C# �������� ����� � ������� (;). ������ ����
            ��������� ����������� �� ����� ����������.</p>
            <p>Console.WriteLine(""Hello, World!"");</p>
            <p>����� ���������� ����� ������������ � ���� ����. ���� ���� ����������� � �������� ������, � ���������� ���������� ����� ����������� � ����������� ��������� ��������.</p>
            <p>{<br>
                Console.WriteLine(""������"");<br>
                Console.WriteLine(""����� ���������� � C#"");<br>
            }</p>
            <p>�������������������</p>
            <p>C# �������� ����������������� ������. ��� ������, ��� � ����������� �� �������� �������� �����-�� ������������ �������� ����� ������������ ������ ������, ������, ���������� � �.�.</p>
            <p>�����������</p>
            <p>������ ������ ������������ ���� �������� �����������. ��� �� �������� ���������� ������ ���������, ��� ���������� ��� ������������. ��� �� ����� �����������
            ������ ��� ��������� ����� ��������, ������� ������ �� ��� ���� ��� �����.</p>
            <p>���� ��� ���� ������������:</p>
            <ul>
                <li>������������ - ����������� �� ����� ������ ����� �������� ����� //. </li>
                <li>������������� - ����������� ����� ��������� /* ����� ����������� */. �� ����� ����������� �� ���������� �������.</li>
            </ul>
            <p>/*<br>
            ������ ��������� �� C#,<br>
            ������� ������� ����������� �� �������<br>
            */</p>
            <p>// ������� ������ ""������""</p> 
        </body>
        </html>";

        textWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private async void OnOpenCSarpCliked(object sender, EventArgs e)
    {
        var cSharp = new CSharp();
        GlobalState.RestartButtonColorOne = Color.FromRgb(172, 153, 234);
        GlobalState.LabelCSharp = "10%";
        Preferences.Set(LabelKey, GlobalState.LabelCSharp);
        await Navigation.PushAsync(cSharp);
        Navigation.RemovePage(this);
    }
}