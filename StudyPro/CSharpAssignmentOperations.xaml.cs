using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpAssignmentOperations : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpAssignmentOperations()
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
            <p>�������� ������������</p>
            <p>�������� ���������� ������������� ��������. � ��������� ���������� ��������� ��� ��������, ������ ����� ������� ����� ������������ ������ �������������� ����������� ���������, ��������, ����������
            <br>��� � �� ������ ������ ������ ����������������, � C# ������� ������� �������� ������������ =, ������� ����������� �������� ������� �������� ������ ��������:</p>
            <p>int number = 23;</p>
            <p>����� ����� ��������� ������������ ���������� ����� ���������� ���������� ������������:</p>
            <p>int a, b, c;<br>
            a = b = c = 34;</p>
            <p>����� ��������, ��� �������� ���������� ����� ������ ���������. � ������� ����� ����������� �������� ������� �������� � ������ ����� ����� ���� ���������� ����� �������� ������ ��������. ��������:</p>
            <p>int a, b, c;<br>
            a = b = c = 34 * 2 / 4; // 17</p>
            <p>����� ������� �������� ���������� � C# ���� ��� ��� ��������:</p>
            <ul>
                <li>+=: ������������ ����� ��������. ����������� ������ �������� ����� ������ � ������� ���������: ��������� A += B ����������� ��������� A = A + B</li>
                <li>-=: ������������ ����� ���������. ����������� ������ �������� �������� ������ � ������� ���������: A -= B ������������ A = A - B</li>
                <li>*=: ������������ ����� ���������. ����������� ������ �������� ������������ ������ � ������� ���������: A *= B ������������ A = A * B</li>
                <li>/=: ������������ ����� �������. ����������� ������ �������� ������� ������ � ������� ���������: A /= B ������������ A = A / B</li>
                <li>%=: ������������ ����� ������� �� ������. ����������� ������ �������� ������� �� �������������� ������� ������ �������� �� ������: A %= B ������������ A = A % B</li>
                <li>&=: ������������ ����� ����������� ����������. ����������� ������ �������� ��������� ����������� ���������� ��� �������� ������������� � ������� �������������� ������� ��������: A &= B ������������ A = A & B</li>
                <li>|=: ������������ ����� ����������� ����������. ����������� ������ �������� ��������� ����������� ���������� ��� �������� ������������� � ������� �������������� ������� ��������: A |= B ������������ A = A | B</li>
                <li>^=: ������������ ����� �������� ������������ ���. ����������� ������ �������� ��������� �������� ������������ ��� ��� �������� ������������� � ������� �������������� ������� ��������: A ^= B ������������ A = A ^ B</li>
                <li><<=: ������������ ����� ������ �������� �����. ����������� ������ �������� ��������� ������ ��� �������� ������������� ����� �� ������������ ���������� ��������, ������ �������� ������� ��������: A <<= B ������������ A = A << B</li>
                <li>>>=: ������������ ����� ������ �������� ������. ����������� ������ �������� ��������� ������ ��� �������� ������������� ������ �� ������������ ���������� ��������, ������ �������� ������� ��������: A >>= B ������������ A = A >> B</li>          
            </ul>
            <p>���������� �������� ����������:</p>
            <p>int a = 10;<br>
            a += 10;        // 20<br>
            a -= 4;         // 16<br>
            a *= 2;         // 32<br>
            a /= 8;         // 4<br>
            a <<= 4;        // 64<br>
            a >>= 2;        // 16</p>
            <p>�������� ���������� �������� �������������������, �� ���� ����������� ������ ������. ��������:</p>
            <p>int a = 8;<br>
            int b = 6;<br>
            int c = a += b -= 5;    // 9</p>
            </body>
        </html>";

        textWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private async void OnOpenCSarpCliked(object sender, EventArgs e)
    {
        if (one + two + three == 3)
        {
            var cSharp = new CSharp();
            GlobalState.LabelCSharp = "60%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonColorSix = Color.FromRgb(172, 153, 234);
            await Navigation.PushAsync(cSharp);
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("�� ��������", "���� �� ��������� �������� �������", "��");
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
            <p>��� ������� �� ������� ��������� ���:<br>int c = 15;<br>
            c*=20;<br>
            Console.WriteLine(c);</p>
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
        if (oneAnswerEntry.Text == "300")
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

            <p>��� ������� �� ������� ��������� ���:<br>int c = 10;<br>
            c*=10/30+23;<br>
            Console.WriteLine(c);</p>
            <ol>
                 <li>-231</li>
                 <li>231</li>
                 <li>230</li>
             </ol>
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
        if (twoAnswerEntry.Text == "3")
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
            <p>��� ������� �� ������� ��������� ���:<br>
            int c = 1;<br>
            c*=10/1+10-10;<br>
            Console.WriteLine(c);</p>
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
        if (threeAnswerEntry.Text == "10")
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
}