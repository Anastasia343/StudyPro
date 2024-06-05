namespace StudyPro;

public partial class CSharpVariables : ContentPage
{
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
        var cSharp = new CSharp();
        await Navigation.PushAsync(cSharp);
        Navigation.RemovePage(this);
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
    private void OneAnswerButton (object sender, EventArgs e) 
    {
        if (oneAnswerEntry.Text == "13")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "1 3")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "1,3") 
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
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
            }
        </style>
        </head>
        <body>

            <p>��� ������� �� ������� ��������� ���:<br>string person = ""Tom"";<br>
            person = ""Sam"";<br>
            Console.WriteLine(person);</p>
            <ol>
                 <li>Tom</li>
                 <li>Sam</li>
                 <li>person</li>
             </ol>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void TwoAnswerButton (object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "Sam")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
        }
        else if (twoAnswerEntry.Text == "sam") 
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
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
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "1")
        {
            threeErrorLabel.Text = "�����!";
            threeErrorLabel.TextColor = Colors.Green;
        }
        else
        {
            threeErrorLabel.Text = "�� �����!";
            threeErrorLabel.TextColor = Colors.Red;
        }
    }
}