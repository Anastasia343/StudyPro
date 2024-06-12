using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpVariables : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpVariables()
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
            <p>����������</p>
            <p>��� �������� ������ � ��������� ����������� ����������. ���������� ������������ ������������ ������� ������, � ������� �������� �������� ������������� ����.
            ���������� ����� ���, ��� � ��������. ��� ����������, ������ ���� ���������� ����� ������� ����������.</p>
            <p>��������� ����������� ����������:</p>
            <p>��� ���_����������;</p>
            <p>������� ���� ��� ����������, ����� �� ���. � �������� ����� ���������� ����� ��������� ����� ������������ ��������, ������� ������������� ��������� �����������:</p>
            <ul>
                <li>��� ����� ��������� ����� �����, ����� � ������ �������������, ��� ���� ������ ������ � ����� ������ ���� ������ ��� �������� �������������</li>
                <li>� ����� �� ������ ���� ������ ���������� � ��������</li>
                <li>��� �� ����� ���� �������� ������ ����� C#. ����� ���� �� ��� �����, � ��� ������ � Visual Studio ����� ���������� ������������ �������� ����� ����� ������.</li>
            </ul>
            <p>���� ��� ��������� ����� ���� �����, �� ������� ������ ���������� ������������ �����, ������� ����� �������� �� �� ��������������.</p> 
            <p>string name;</p>
            <p>� ������ ������ ���������� ���������� name, ������� ����� ��� string. �� ���� ���������� ������������ ������. ��������� ����������� ���������� ������������ ����� ����������, �� ����� ���� �������� ����� � �������.</p>
            <p>��� ���� ������� ���������, ��� C# �������� ����������������� ������, ������� ��������� ��� ����������� ���������� ����� ������������ ��� ������ ����������:</p>
            <p>string name;<br>
             string Name;</p>
            <p>����� ����������� ���������� ����� ��������� ��������� ��������:</p>
            <p>string name;<br>
            name = ""Tom"";</p>
            <p>��� ��� ���������� name ������������ ��� string, �� ���� ������, �� �� ����� ��������� �� ������ � ������� ��������. ������ ���������� ����� ��������� ������ �� ��������, ������� ������������� �� ����.</p>
            <p>� ���������� � ������� ����� ���������� �� ������ ���������� � ��� ������� ������, � ������� �������� �� ��������.</p>
            <p>����� �� ����� ����� ��� ����������� ��������� ���������� ��������. ������ ����� ���������� ��������������:</p>
            <p>string name = ""Tom"";</p>
            <p>������������� ������ ���������� �������� ��, ��� � ��������� ����� ����������� ������ �� ��������. </p>
            <p>���������</p>
            <p>������������� ������������ ���������� �������� ��, ��� �� ����� �������� �� �������� � �������� ������ ���������. ��, ����� ����, � C# ���� ���������. ��������� ������ ���� ����������� ���������������� ��� �����������,
            � ����� ����������� �������� ��������� �� ����� ���� ��������</p>
            <p>��������� ������������� ��� �������� ����� ��������, ������� �� ������ ���������� � ���������. ��� ����������� �������� ������������ �������� ����� const, ������� ����������� ����� ����� ���������:</p>
            <p>const string NAME = ""Tom"";  // ���������� ���������</p>
            <p>��� ������������� �������� ���� �������, ��� �������� �� �� ����� ������ ���� ��� � ��� � ������� ���������� ��� ������ ���� ����������. ���, � ��������� ������ �� ������� ������, ��� ��� ��������� �� ��������� ��������� ��������:</p>
            <p>const string NAME;  // ! ������ - ��������� NAME �� ����������������</p>
            <p>����� ����, �� �� �� ������ �������� � �������� ������ ���������:</p>
            <p>const string NAME = ""Tom"";  // ���������� ���������<br>
            NAME = ""Bob"";   // !������ - � �������� ������ �������� ��������</p>
            <p>����� �������, ���� ��� ���� ������� � ��������� ��������� ������, �� �� �� ������� ��������, ��� ������������ � ���� ��������. ���� �� �� ����� ��������, �� ��� ������������ � ���� ����������.</p>
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
            GlobalState.LabelCSharp = "20%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonTwo.BackgroundColor = Color.FromRgb(172, 153, 234);
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
            <p>����� �� ��������� ��������� ������������ ���������� ����������� ����������:</p>
             <ol>
                 <li>string person = ""Tom"";</li>
                 <li>person = ""Tom"";</li>
                 <li>string person;</li>
                 <li>string ""Tom"";</li>
             </ol> 
        </body>
        </html>";

        oneAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int one = 0;
    private void OneAnswerButton (object sender, EventArgs e) 
    {
        if (oneAnswerEntry.Text == "13")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "1 3")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "1,3") 
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

            <p>��� ������� �� ������� ��������� ���:<br>string person = ""Tom"";<br>
            person = ""Sam"";<br>
            Console.WriteLine(person);</p>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int two = 0;
    private void TwoAnswerButton (object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "Sam")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "sam") 
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
            string name = ""Tom"";<br>
            Console.WriteLine(Name);</p>
             <ol>
                 <li>�� ��������������</li>
                 <li>Tom</li>
                 <li>Name</li>
             </ol> 
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
        if (threeAnswerEntry.Text == "1")
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