namespace StudyPro;

public partial class CSharpBitwiseOperations : ContentPage
{
	public CSharpBitwiseOperations()
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
            <p>���������� ��������</p>
            <ul>
                <li>&(���������� ���������)<b>��������� ������������ ����������, � ���� � ����� ��������� �������� �������� ����� 1, �� �������� ���������� 1, ����� ������������ ����� 0. </li>
                <li>| (���������� ��������)<br>������ �� ���������� ���������, �������� ����� ������������ �� �������� ��������, �� ������ ������������ �������, ���� ���� �� � ������ ����� � ������ ������� ������� �������.</li>
                <li>^ (���������� ����������� ���)<br>����� ��� �������� �������� XOR, ������� �� ��������� ��� �������� ����������.</li>
                <li>~ (���������� ��������� ��� ��������)<br>��� ���� ����������� ��������, ������� ����������� ��� �������: ���� �������� ������� ����� 1, �� ��� ���������� ������ ����, � ��������.</li>
            </ul>
            <p>������������� ������������� �����</p>
            <p>��� ������ ����� �� ������ � C# ����������� �������������� ��� (two�s complement), ��� ������� ������� ������ �������� ��������. ���� ��� �������� ����� 0, �� ����� �������������, � ��� �������� ������������� �� ���������� �� ������������� ������������ �����. ��������, 0000 0001 � ���������� ������� 1.<br>���� ������� ������ ����� 1, �� �� ����� ���� � ������������� ������. ��������, 1111 1111 � ���������� ������� ������������ -1. ��������������, 1111 0011 ������������ -13.
            <br>����� �������� �� �������������� ����� �������������, ��� ����� ������������� � ��������� �������:</p>
            <p>�������� ������<br>int x = 12;<br>
            int y = ~x;<br>
            y += 1;<br>
            Console.WriteLine(y);   // -12</p>
            <p>�������� ������</p>
            <p>�������� ������ ����� ������������ ��� ��������� �����. ����� ����� ����������� ������ � �����.</p>
            <ul>
                <li>x<<y - �������� ����� x ����� �� y ��������. ��������, 4<<1 �������� ����� 4 (������� � �������� ������������� 100) �� ���� ������ �����, �� ���� � ����� ���������� 1000 ��� ����� 8 � ���������� �������������.</li>
                <li>x>>y - �������� ����� x ������ �� y ��������. ��������, 16>>1 �������� ����� 16 (������� � �������� ������������� 10000) �� ���� ������ ������, �� ���� � ����� ���������� 1000 ��� ����� 8 � ���������� �������������.</li>
            </ul>
            <p>����� �������, ���� �������� �����, ������� ���� �������� � �� ��� ������ ������, ������� �� ���, �� ���������� ���������� ��������� ��� ������� �� ���. ������� �������� �������� ����� ������������ ������ ����������������� ��������� ��� ������� �� ���.</p>
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
            <p>����� ����� � ������� ����� � �������������� ����������� ��������:<br>int x1 = 2;<br>
            int y1 = 5;<br>
            Console.WriteLine(x1|y1);</p>
        </body>
        </html>";

        oneAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "7")
        {
            oneErrorLabel.Text = "�����!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "111")
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

            <p>��� ������� �� ������� ��������� ���:<br>int x = 12;<br>
            int y = ~x;<br>
            y += 1;<br>
            Console.WriteLine(y);</p>
            <ol>
                 <li>12</li>
                 <li>-12</li>
                 <li>24</li>
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
        if (twoAnswerEntry.Text == "2")
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
            <p>����� ��������� ������� ������� � ������ ����:<br>int x1 = 2;<br>
             int y1 = 5;<br>
             Console.WriteLine(x1&y1);</p> 
        </body>
        </html>";

        threeAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "0")
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