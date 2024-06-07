namespace StudyPro;

public partial class CSharpConditionalExpressions : ContentPage
{
	public CSharpConditionalExpressions()
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
            <p>�������� ���������<br><br>��������� ����� �������� ������������ �������� ���������. ����� �������� ���������� ���������� ��������, �� ���� �������� ���� bool: true, ���� ��������� �������, � false, ���� ��������� �����. � �������� ��������� ��������� �������� ��������� � ���������� ��������.</p>
<p>�������� ���������<br><br>� ��������� ��������� ������������ ��� �������� � ������������ �������� ���� bool - true, ���� ��������� �����, � false, ���� ��������� �������.</p>
            <ul>
                <li>==<br>���������� ��� �������� �� ���������. ���� ��� �����, �� �������� ���������� true, ���� �� �����, �� ������������ false</li>
                <li>!=<br>���������� ��� �������� � ���������� true, ���� �������� �� �����, � false, ���� ��� �����.</li>
                <li><<br>�������� ""������ ���"". ���������� true, ���� ������ ������� ������ �������, � false, ���� ������ ������� ������ �������</li>
                <li>><br>�������� ""������ ���"". ���������� ��� �������� � ���������� true, ���� ������ ������� ������ �������, ����� ���������� false</li>
                <li><=<br>�������� ""������ ��� �����"". ���������� ��� �������� � ���������� true, ���� ������ ������� ������ ��� ����� �������. ����� ���������� false.</li>
                <li>>=<br>�������� ""������ ��� �����"". ���������� ��� �������� � ���������� true, ���� ������ ������� ������ ��� ����� �������, ����� ������������ false</li>
            </ul>
            <p>�������� <, > <=, >= ����� ������� ���������, ��� == � !=.</p>
            <p>���������� ��������<br><br>����� � C# ���������� ���������� ���������, ������� ����� ���������� �������� ���� bool. � �������� ��������� ��� ��������� �������� ���� bool. ��� �������, ����������� � ���������� � ���������� ��������� �������� ���������.</p>
            <ul>
                <li>|<br>�������� ����������� �������� ��� ���������� ���. ���������� true, ���� ���� �� ���� �� ��������� ���������� true.</li>
                <li>&<br>�������� ����������� ��������� ��� ���������� �. ���������� true, ���� ��� �������� ������������ ����� true.</li>
                <li>||<br>�������� ����������� ��������. ���������� true, ���� ���� �� ���� �� ��������� ���������� true.</li>
                <li>&&<br>�������� ����������� ���������. ���������� true, ���� ��� �������� ������������ ����� true.</li>
                <li>!<br>�������� ����������� ���������. ������������ ��� ����� ��������� � ���������� true, ���� ������� ����� false. ���� ������� ����� true, �� �������� ���������� false</li>
                <li>^<br>�������� ������������ ���. ���������� true, ���� ���� ������, ���� ������ ������� (�� �� ������������) ����� true, ����� ���������� false</li>
            </ul>
            <p>����� � ��� ��� ���� �������� | � || (� ����� & � &&) ��������� ������� ��������, ������ �� ��� �� �����������.<br>� ��������� z=x|y; ����� ����������� ��� �������� - x � y.
            <br>� ��������� �� z=x||y; ������� ����� ����������� �������� x, � ���� ��� ����� true, �� ���������� �������� y ��� ������ �� �����, ��� ��� � ��� � ����� ������ ��� z ����� ����� true. �������� y ����� ����������� ������ � ��� ������, ���� x ����� false
            <br>�� �� ����� �������� ���� �������� &/&&. � ��������� z=x&y; ����� ����������� ��� �������� - x � y.
            <br>� ��������� �� z=x&&y; ������� ����� ����������� �������� x, � ���� ��� ����� false, �� ���������� �������� y ��� ������ �� �����, ��� ��� � ��� � ����� ������ ��� z ����� ����� false. �������� y ����� ����������� ������ � ��� ������, ���� x ����� true
            <br>������� �������� || � && ����� ������ � �����������, ��� ��� ��������� ��������� ����� �� ���������� �������� ���������, � ��� ����� �������� ������������������. � �������� | � & ������ �������� ��� ���������� ����������� �������� ��� �������.</p>
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
            <p>����� �� ��������� ��������� ������������ �������� �:</p>
             <ol>
                 <li>&&</li>
                 <li>|</li>
                 <li>>=</li>
                 <li>&</li>
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
        if (oneAnswerEntry.Text == "4")
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

            <p>����� ������ �������� (��� bool) � ������ ����:<br>bool x1 = (5 > 6) | (4 < 6);</p>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void TwoAnswerButton(object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "True")
        {
            twoErrorLabel.Text = "�����!";
            twoErrorLabel.TextColor = Colors.Green;
        }
        else if (twoAnswerEntry.Text == "true")
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
            <p>����� ������ �������� (��� bool) � ������ ����:<br>bool x1 = (5 > 6) && (4 < 6);</p>
        </body>
        </html>";

        threeAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "false")
        {
            threeErrorLabel.Text = "�����!";
            threeErrorLabel.TextColor = Colors.Green;
        }
        else if (threeAnswerEntry.Text == "False") 
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