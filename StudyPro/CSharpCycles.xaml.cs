using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpCycles : ContentPage
{
    const string LabelKey = "SavedLabel";
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
                color:#ACACAC;
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
        if (one + two + three == 3)
        {
            var cSharp = new CSharp();
            GlobalState.LabelCSharp = "100%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
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
            <p>������� ��� ���������� ��������� ����:<br><br>int i = 5;<br>
            while(i > 0)<br>
            {<br>
                i *= 3;<br>
                i *= -1;<br>
            }</p>
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

            <p>��� ����� �������� �� ������� � ���������� ���������� ���������� �����:<br><br>for(int i = 1; i < 3; i++)<br>
            {<br>
                switch (i)<br>
                {<br>
                    default:<br>
                        Console.WriteLine($""i = {i++}"");<br>
                        break;<br>
                }<br>
            }</p>
            <ol>
                 <li>��������� �� ��������������</li>
                 <li>������ �� ����� �������� �� �������</li>
                 <li>i = 1</li>
                 <li>i = 1<br>
                 i = 2</li>
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
            <p>������� ��� � ���� ����� ����� ����������� ������ j = j - 1:<br><br>int j = 2;<br>
            for (int i = 1; i < 100; i = i + 2)<br>
            {<br>
                j = j - 1;<br>
                while(j < 15)<br>
                {<br>
                    j = j + 5;<br>
                }<br>
            }</p>
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
        if (threeAnswerEntry.Text == "50")
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