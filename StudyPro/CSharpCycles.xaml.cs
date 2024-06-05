namespace StudyPro;

public partial class CSharpCycles : ContentPage
{
	public CSharpCycles()
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
            <p>����� �������� ������������ �������������, �������� � ����������� �� ������������ ������� ��������� ��������� �������� ��������� ���. � C# ������� ��������� ���� ������:</p>
            <ul>
                 <li>for</li>
                <li>foreach</li>
                <li>while</li>
                <li>do...while</li>
            </ul>
            <p>���� for</p>
            <p>���� for ����� ��������� ���������� �����������:<br>for ([��������_��_����������_�����]; [�������]; [��������_�����_����������])<br>
            {<br>
                // ��������<br>
            }</p>
            <p>���������� ����� for ������� �� ���� ������. ������ ����� ���������� ����� - ��������� ��������, ������� ����������� ���� ��� �� ���������� �����. ������ ����� ������������ ����������, ������� ����� �������������� � �����.<br>������ ����� - �������, ��� ������� ����� ����������� ����. ���� ������� ����� true, ����� ����������� ����.
            <br>� ������ ����� - ��������� ��������, ������� ����������� ����� ���������� ����� �����. ��� �������� ����������� ������ ��� ��� ���������� ����� �����.
            <br>����� ���������� ����� � �������� ������� ���������� ���� �������� �����.</p>
            <p>���� ���� ����� for �������� ���� ����������, �� �� ����� ��� ���������, ����� �������� ������:<br>
            for (int i = 1; i < 4; i++)<br>
                Console.WriteLine(i);<br><br>
 
            // ��� ���<br>
            for (int i = 1; i < 4; i++) Console.WriteLine(i);</p>
            <p>���� do..while</p>
            <p>� ����� do ������� ����������� ��� �����, � ����� ���������� �������� ������� � ���������� while. � ���� ��� ������� �������, ���� �����������.<br><br>
            do<br>
            {<br>
                �������� �����<br>
            }<br>
            while (�������)</p>
            <p>���� while</p>
            <p>� ������� �� ����� do ���� while ����� ��������� ���������� ���������� �������, � ���� ������� �������, �� ��� ����� �����������:<br><br>
            while (�������)<br>
            {<br>
                �������� �����<br>
            }</p>
            <p>���� foreach</p>
            <p>���� foreach ������������ ��� �������� ������ ��� ��������� ���������. ��� ����� �����������:<br><br>
            foreach(���_������ ���������� in ���������)<br>
            {<br>
                // �������� �����<br>
            }</p>
            <p>����� ��������� foreach � ������� ������� ���� ����������� ����������. ����� �������� ����� in � ����� ���������, �������� ������� ���� ���������.<br>
            ��� ���������� ���� ��������������� ���������� �������� ��������� � �������� �� � ����������, � ����� ������� � ����� ����� �� ����� ��������� � ���� ��������� ��������.
            <br>��������, ������� ������. ������ �� ���� - ��� ��������� ��������. � .NET ��������� ��������� ��� �������� ������ - �� ������� � ������� ����� foreach.</p>
            <p>����� ��������, ��� ����������, ������� ������������ � ���������� �����, ������ �� ���� ��������������� ���� ��������� ������������ ���������. ���, �������� ������ - �������� ���� char - �������. ������� ���������� c ����� ��� char. ������ � ���������� �� ������ ������ ��������, ����� ��� ������������ �������� ���������. � ���� ������ �� ����� ���������� ���������� � ������� ��������� var</p>
            <p>��������� continue � break</p>
            <p>������ ��������� ��������, ����� ��������� ����� �� �����, �� ��������� ��� ����������. � ���� ������ �� ����� ��������������� ���������� break.</p>
            <p>for (int i = 0; i < 9; i++)<br>
            {<br>
                if (i == 5)<br>
                    break;<br>
                Console.WriteLine(i);<br>
            }</p>
            <p>������ �������� ���� ������ ������. � ��� ���� �� �����, ����� ��� �������� ���� �� ����������, � ������ ��������� ������� ��������. ��� ����� �� ����� ��������������� ���������� continue:</p>
            <p>for (int i = 0; i < 9; i++)<br>
            {<br>
                if (i == 5)<br>
                    continue;<br>
                Console.WriteLine(i);<br>
            }</p>
            <p>����� ��������, ��� ��������� break � continue ����� ��������� � ����� ���� ������.</p>
            <p>��������� �����</p>
            <p>���� ����� ����� ���� ���������� � ������. ��������:<br><br>
            for (int i = 1; i < 10; i++)<br>
            {<br>
                for (int j = 1; j < 10; j++)<br>
                {<br>
                    Console.Write($""{i * j} \t"");<br>
                }<br>
                Console.WriteLine();<br>
            }</p>
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
    private void OneAnswerButton(object sender, EventArgs e)
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
    private void TwoAnswerButton(object sender, EventArgs e)
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