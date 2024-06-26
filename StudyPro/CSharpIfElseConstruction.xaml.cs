namespace StudyPro;

public partial class CSharpIfElseConstruction : ContentPage
{
    const string LabelKey = "SavedLabel";
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
        if (one + two + three == 3) 
        {
            var cSharp = new CSharp();
            GlobalState.LabelCSharp = "90%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonColorNine = Color.FromRgb(172, 153, 234);
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
    int one = 0;
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "age>17")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "age > 17")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "age >=18")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "age >= 18")
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
    int two = 0;
    private void TwoAnswerButton(object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "(name = \"Tom\")")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "(name=\"Tom\")")
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
    int three = 0;
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "2")
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