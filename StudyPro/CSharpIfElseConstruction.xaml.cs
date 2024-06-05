namespace StudyPro;

public partial class CSharpIfElseConstruction : ContentPage
{
	public CSharpIfElseConstruction()
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
            <p>����������� if..else</p>
            <p>���������if</p>
            <p>�������� ����������� - ���� �� ������� ����������� ������ ������ ����������������, ������� ���������� ������ ��������� �� ������ �� ����� � ����������� �� ������������ �������. ����� �� ����� ����������� � ����� ���������������� C# �������� ����������� if..else<br>
            ����������� if/else ��������� ���������� ���������� ������� � � ����������� �� ����������� �������� ��������� ������������ ���.<br>
            �� ���������� ����� ������� �� ����� if:<br>
            if(�������)<br>
            {<br>
                ����������� ����������<br>
            }<br><br>
            ����� ��������� ����� if �������� �������. ������� ������ ������������ �������� ���� bool. ��� ����� ���� ��������������� �������� ���� bool ��� ��������� ��������� ��������� ��� ������� ���������, ������� ���������� �������� ���� bool. � ���� ��� ������� ������� (����� true), �� ����������� ���, ������� ������� ����� ����� ������� ������ �������� ������.</p>
            <p>���� ���� if �������� ���� ����������, �� �� ����� ��� ���������, ����� �������� ������:<br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if (num1 > num2)<br>
            Console.WriteLine($""����� {num1} ������ ����� {num2}"");<br><br>
            // ��� ���<br>
            if (num1 > num2) Console.WriteLine($""����� {num1} ������ ����� {num2}"");</p>
            <p>��������� else</p>
            <p>�� ���, ���� �� �������, ����� ��� ������������ ������� ����� ����������� �����-���� ��������? � ���� ������ �� ����� �������� ���� else:<br><br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if(num1 > num2)<br>
            {<br>
                Console.WriteLine($""����� {num1} ������ ����� {num2}"");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine($""����� {num1} ������ ����� {num2}"");<br>
            }</p>
            <p>���� else �����������, ���� ������� ����� if �����, �� ���� ����� false. ���� ���� else �������� ����� ���� ����������, �� ���� �� �� ����� ��� ���������, ����� �������� ������</p>
            <p>��������� else if</p>
            <p>�� � ������� ���� ��� ��������� ����� �� ����� ��������� ��� ���������: ������ ����� ������ �������, ������ ����� ������ ������� � ����� �����. ��������� ����������� else if, �� ����� ������������ �������������� �������:<br><br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if(num1 > num2)<br>
            {<br>
                Console.WriteLine($""����� {num1} ������ ����� {num2}"");<br>
            }<br>
            else if (num1 < num2)<br>
            {<br>
                Console.WriteLine($""����� {num1} ������ ����� {num2}"");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine(""����� num1 ����� ����� num2"");<br>
            }<br><br>
            ��� ������������� ����� �������� ��������� ��������� else if</p>
            <p>��������� ��������</p>
            <p>��������� �������� ����� ��������� ��������� ��������� ������� � � ����������� �� ��� ���������� ��������� ��������� ��������.��� ����� ��������� ���������:<br>
            [������ ������� - �������] ? [������ �������] : [������ �������]</p>
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
                color:#ACACAC;
            }
        </style>
        </head>
        <body>
            <p>��������, ��� �� ������� � ������ ����, ���� ��� ����� � ��� ������ � 18 ���:<br>string name = ""Tom"";<br>
           int age = 17;<br>
            if()<br>
                Console.WriteLine(""����� ���������� � ��� ���!"");<br>
            else<br>
                Console.WriteLine(""�� �� ���������!"");</p>
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
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "age>17")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age > 17")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age >=18")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age >= 18")
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
                color:#ACACAC;
            }
        </style>
        </head>
        <body>

            <p>� ������ ���� ������������ ������. �������� ��������� ������������ ���� ����� ����. <br>string name = ""Tom"";<br>
           int age = 16;<br>
           int height = 167;<br>
            if(Name = ""Tom"")<br>
                Console.WriteLine($""������, ���� �����{name}"");<br>
            else<br>
                Console.WriteLine("":("");</p>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void TwoAnswerButton(object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "(name = \"Tom\")")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
        }
        else if (twoAnswerEntry.Text == "(name=\"Tom\")")
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
                color:#ACACAC;
            }
        </style>
        </head>
        <body>
            <p>��� ������� ��������� ���:<br>
            string name = ""Tom"";<br>
           int age = 13;<br>
            if(age>13)<br>
                Console.WriteLine(""�� ������ ������� �������"");<br>
            else<br>
                Console.WriteLine(""�� �� ������ �������� �������"");</p>
             <ol>
                 <li>�� ��������������</li>
                 <li>�� ������ ������� �������</li>
                 <li>�� �� ������ �������� �������</li>
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
        if (threeAnswerEntry.Text == "2")
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