using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpTransformationsBasicData : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpTransformationsBasicData()
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
            <p>�������������� ������� ����� ������</p>
            <p>��� ������������ ����� ������ �����������, ����� �������� ����� ����� ��� ��� ���� ��� � ������� ���� ������ �� ����� ��������. � ������� ���� ���� ���������� �������������� ��������. ������ �������� �������� �������� � ������ ������ �����:<br><br>
            byte a = 4;<br>
            int b = a + 70;<bt><br>
            ����������� �������� ������ ����������� �������� ����� 74, ��� � ���������.�� ������ ��������� ��������� �������� � ���� �������� ���� byte:<br><br>byte a = 4;<br>
            byte b = a + 70;  // ������</p>
            <p>����� ��������� ������ ��� ����������, ������� �������� ��������� �������� - � int �� byte. ������ ��� ������� �������������� ��������� �� ������� ������ �� ����� ����������. � ���� �� �������� � Visual Studio, ����� ���������� ������ ������ ������� ��������� ������, ��������, ��� � ��� ������.<br>
            ��� ��������� �� ������ ��������� �������� ��������, ������� ����� ������� ��� ��� ���� ���. �� � ������ ������ ����� 74, ������� �� ������� ��������, ������ ������������ � �������� �������� ���� byte, ��� �� ����� �� �������� ������.<br>
            ���� � ���, ��� �������� �������� (�� � ���������) ���������� �������� ���� int, ���� � �������� ��������� ������������� ���� ������ � ������������ ������ ��� ����� int (�� ���� ���� byte, short, int). ������� ����������� �������� a + 70 ����� ������, ������� ����� ����� � ������ 4 �����. ����� ���� ������ �� �������� ��������� ���������� b, ������� ����� ��� byte � � ������ �������� 1 ����.<br>
            � ����� ����� �� ���� ��������, ���������� ��������� �������� �������������� �����. �������� �������������� ����� ������������ �������� � ������� ���� ����, � �������� ���� ������������� ��������<br>
            byte a = 4;<br>
            byte b = (byte)(a + 70);</p>
            <p>�������� � ����������� ��������������</p>
            <p>�������������� ����� ���� �������� (narrowing) � ����������� (widening). ����������� �������������� ��������� ������ ������� � ������. ��������:</p>
            <p>byte a = 4;             // 0000100<br>
            ushort b = a;   // 000000000000100<br>�� ���� ��������, ������� �������� 8 ���, ����������� �� 16 ���.</p>
            <p>�������� ��������������, ��������, ������ �������� �� ���� ������� ����������. �� ������ �������� ������ �� ��� ��� ����� ���� � ��������� ����������������:<br><br>
            ushort a = 4;<br>
            byte b = (byte) a;</p>
            <p>����� � ������� ��������������</p> 
            <p>����� � ������� ��������������: � ������ � ������������ ���������������� ���������� �� ��� �������� ��� �������������� ������, �� ���� �������������� ���� �������� (implicit conversion). ����� �������������� �� �������� �����-�� �����������. ��� �� ����� ����� ������� ���� ���� �� ����� �������� �������� ��������������.<br>
            ���� ������������ �������������� �� ����������� ���� ������� ����������� � ����������� ���� ������� �����������, �� ����������� �������������� ����, ������� ����� ������� 0. ��� ���������� ���������� ������ ��� zero extension.<br><br>
            byte a = 4;             // 0000100<br>
            ushort b = a;   // 000000000000100</p>
            <p>���� ������������ �������������� � ��������� ����, �� ������� ������������� ����������� ������, ���� ����� �������������, � ���������, ���� ����� �������������. ��������� ������ ����� �������� �������� ��� - 0 ��� ������������� � 1 ��� ������������� �����. ��� ���������� � ����������� ������� ����������� �������� ���.</p>
            <p>����� ��������������</p>
            <p>��� ����� ��������������� (explicit conversion) �� ���� ������ ��������� �������� �������������� (�������� ()). ���� �������� �������������� ����� ������� � ���, ��� ����� ��������� ����������� � ������� ���, � �������� ���� �������� ������ ��������:<br><br>
            int a = 4;<br>
            int b = 6;<br>
            byte c = (byte)(a+b);</p>
            <p>����������� �������������� �� ���� � ������� ������������ � ���� � ������� ������������ ���������� �������� ������. ��� ����� ���� ��������� ������� ��������������:</p>
            <p>byte -> short -> int -> long -> decimal<br>
            int -> double<br>
            short -> float -> double<br>
            char -> int</p>
            <p>������ �������� ������</p>
            <p>���������� ������ ��������, ��� �����, ��������, � ��������� ������:<br><br>
            int a = 33;<br>
            int b = 600;<br>
            byte c = (byte)(a+b);<br>
            Console.WriteLine(c);   // 121<br><br>
            ����������� ����� ����� 121, ��� ����� 633 �� �������� � ���������� �������� ��� ���� byte, � ������� ���� ����� ���������. � ����� ��������� ����� 121. ������� ��� ��������������� ���� ��� ���������. � �� � ������ ������ ����� ���� ����� ����� ����� a � b, ������� � ����� ����� ����� �� ������ 255, ���� �� ����� ������� ������ byte ������ ��� ������, ��������, int.</p>
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
            GlobalState.LabelCSharp = "70%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonSeven.BackgroundColor = Color.FromRgb(172, 153, 234);
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
            <p>����� �������������� ����� �� ����������� ������������� (��������, ��������� ���������):</p>
             <ol>
                 <li>�� int � short</li>
                 <li>�� short � int</li>
                 <li>�� bool � string</li>
                 <li>�� byte � float</li>
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
        else if (oneAnswerEntry.Text == "1, 3")
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

            <p>��� ������� �� ������� ��������� ���:<br>byte a = 13;<br>
            byte b =a + 20;<br>
            Console.WriteLine(b);</p>
            <ol>
                 <li>������ ����������</li>
                 <li>33</li>
                 <li>-33</li>
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
        if (twoAnswerEntry.Text == "1")
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
            <p>��� ������� ��������� ���:<br>byte an = 4;<br>
            byte b = (byte)(a + 70);<br>
            Console.WriteLine(b);</p>
             <ol>
                 <li>74</li>
                 <li>�� ��������������</li>
                 <li>-74</li>
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