using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpArithmeticOperations : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpArithmeticOperations()
	{
		InitializeComponent();
        TextWebView();
        OneAnswerWebView();
        TwoAnswerWebView();
        ThreeAnswerWebView();
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
            <p>�������������� ��������</p>
            <ul>
                <li>+<br>�������� �������� ���� �����</li>
                <li>-<br>�������� ��������� ���� �����</li>
                <li>*<br>�������� ��������� ���� �����</li>
                <li>/<br>�������� ������� ���� �����<br>��� ������� ����� ���������, ��� ���� ��� �������� ������������ ����� �����, �� ��������� ����� ����� ����������� �� ������ �����:<br>
                double z = 10 /  4; //��������� ����� 2<br>�������� �� ��, ��� ��������� �������� � ����� ���������� � ���������� ���� double, ������� ��������� ��������� ������� �����, �� � ����� �������� ��������� ��� ��������, ������� �� ��������� ��������������� ��� ������� int, �� ���� ����� �����, � ��������� �� �� ����� �������������.<br>
                ��� ������ �� ���� �������� ���������� ���������� �������� ��� ����������, ����������� � ��������, ������ ��� ���� double ��� float:<br>double z = 10.0 /  4.0; //��������� ����� 2.5</li>
                <li>%<br>�������� ��������� ������� �� �������������� ������� ���� �����</li>
            </ul>
            <p>������� ��������</p>
            <ul>
                <li>++<br>�������� ����������<br>��������� ������ ����������: ++x - ������� �������� ���������� x ������������� �� 1, � ����� �� �������� ������������ � �������� ���������� ��������.<br>
                � ����� ���������� ����������� ���������: x++ - ������� �������� ���������� x ������������ � �������� ���������� ��������, � ����� � ���� ������������ 1.<br>
                int x1 = 5;<br>
                int z1 = ++x1; // z1=6; x1=6<br>
                Console.WriteLine($""{x1} - {z1}"");<br>
                <br>
                int x2 = 5;<br>
                int z2 = x2++; // z2=5; x2=6<br>
                Console.WriteLine($""{x2} - {z2}"");</li>
                <li>--<br>�������� ���������� ��� ���������� �������� �� �������. ����� ���������� ���������� ����� ���������� (--x) � ����������� (x--).<br>
                int x1 = 5;<br>
                int z1 = --x1; // z1=4; x1=4<br>
                Console.WriteLine($""{x1} - {z1}"");<br>
                <br>
                int x2 = 5;<br>
                int z2 = x2--; // z2=5; x2=4<br>
                Console.WriteLine($""{x2} - {z2}"");</li>
            </ul>
            <p>��� ���������� ����� ���������� �������������� �������� ������� ��������� ������� �� ����������. ��������� �������� �� ���������� � �������:</p>
            <ol>
                <li>���������, ���������</li>
                <li>���������, �������, ��������� �������</li>
                <li>��������, ���������</li>
            </ol>
            <p>��� ��������� ������� ���������� �������� ����������� ������.</p>
            <p>��������������� ����������</p>
            <p>����� �������� ����� ���� � ��� �� ���������, ������� ���������� ������������ ���������������� ����������. � ����������� �� ��������������� ���� ��� ���� ����������:</p>
            <ul>
                <li>����������������� ���������, ������� ����������� ����� �������</li>
                <li>������������������ ���������, ������� ����������� ������ ������</li>
            </ul>
            </body>
        </html>";

        textWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void OneAnswerWebView()
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
            <p>� ����� ������� ����� ����������� �������������� ��������:</p>
             <ol>
                 <li>���������, ���������, ��������</li>
                 <li>�������, ���������, ��������� �������</li>
                 <li>���������, ��������, ���������</li>
                 <li>���������, ��������, ���������</li>
             </ol> 
        </body>
        </html>";

        oneAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int one = 0;
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "1")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else
        {
            oneErrorLabel.Text = "�� �����!";
            oneErrorLabel.TextColor = Colors.Red;
        }
    }
    private void TwoAnswerWebView()
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

            <p>����� ����� ��������� ������� �������?<br>double z = 10.0 /  4.0;</p>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int two = 0;
    private void TwoAnswerButton(object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "2.5")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "2,5")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else
        {
            twoErrorLabel.Text = "�� �����!";
            twoErrorLabel.TextColor = Colors.Red;
        }
    }
    private void ThreeAnswerWebView()
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
            <p>��� ������� ��������� ���:<br>
            int a = 3;<br>
            int b = 5;<br>
            int c = 40;<br>
            int d = c---b*a;<br>    // a=3  b=5  c=39  d=25
            Console.WriteLine($""a={a}  b={b}  c={c}  d={d}"");<br><br>� ������ �������� ���������� ����� ������</p>
        </body>
        </html>";

        threeAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int three = 0;
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "3 5 39 25")
        {
            threeErrorLabel.Text = "�����!";
            threeErrorLabel.TextColor = Colors.Green;
            ++three;
        }
        else
        {
            threeErrorLabel.Text = "�� �����!";
            threeErrorLabel.TextColor = Colors.Red;
        }
    }
    private async void OnOpenCSarpCliked(object sender, EventArgs e)
    {
        if (one + two + three == 3)
        {
            var cSharp = new CSharp();
            GlobalState.LabelCSharp = "40%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonColorFour = Color.FromRgb(172, 153, 234);
            await Navigation.PushAsync(cSharp);
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���� �� ��������� �������� �������", "��");
    }
}