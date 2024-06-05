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
            <p>Логические операции</p>
            <ul>
                <li>&(логическое умножение)<b>Умножение производится поразрядно, и если у обоих операндов значения разрядов равно 1, то операция возвращает 1, иначе возвращается число 0. </li>
                <li>| (логическое сложение)<br>Похоже на логическое умножение, операция также производится по двоичным разрядам, но теперь возвращается единица, если хотя бы у одного числа в данном разряде имеется единица.</li>
                <li>^ (логическое исключающее ИЛИ)<br>Также эту операцию называют XOR, нередко ее применяют для простого шифрования.</li>
                <li>~ (логическое отрицание или инверсия)<br>Еще одна поразрядная операция, которая инвертирует все разряды: если значение разряда равно 1, то оно становится равным нулю, и наоборот.</li>
            </ul>
            <p>Представление отрицательных чисел</p>
            <p>Для записи чисел со знаком в C# применяется дополнительный код (two’s complement), при котором старший разряд является знаковым. Если его значение равно 0, то число положительное, и его двоичное представление не отличается от представления беззнакового числа. Например, 0000 0001 в десятичной системе 1.<br>Если старший разряд равен 1, то мы имеем дело с отрицательным числом. Например, 1111 1111 в десятичной системе представляет -1. Соответственно, 1111 0011 представляет -13.
            <br>Чтобы получить из положительного числа отрицательное, его нужно инвертировать и прибавить единицу:</p>
            <p>Операции сдвига<br>int x = 12;<br>
            int y = ~x;<br>
            y += 1;<br>
            Console.WriteLine(y);   // -12</p>
            <p>Операции сдвига</p>
            <p>Операции сдвига также производятся над разрядами чисел. Сдвиг может происходить вправо и влево.</p>
            <ul>
                <li>x<<y - сдвигает число x влево на y разрядов. Например, 4<<1 сдвигает число 4 (которое в двоичном представлении 100) на один разряд влево, то есть в итоге получается 1000 или число 8 в десятичном представлении.</li>
                <li>x>>y - сдвигает число x вправо на y разрядов. Например, 16>>1 сдвигает число 16 (которое в двоичном представлении 10000) на один разряд вправо, то есть в итоге получается 1000 или число 8 в десятичном представлении.</li>
            </ul>
            <p>Таким образом, если исходное число, которое надо сдвинуть в ту или другую строну, делится на два, то фактически получается умножение или деление на два. Поэтому подобную операцию можно использовать вместо непосредственного умножения или деления на два.</p>
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
            <p>Какой вывод в консоль будет с использованием логического сложения:<br>int x1 = 2;<br>
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
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "111")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else
        {
            oneErrorLabel.Text = "Не верно!";
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

            <p>Что выведет на консоль следующий код:<br>int x = 12;<br>
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
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
        }
        else
        {
            twoErrorLabel.Text = "Не верно!";
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
            <p>Какой результат выведет консоль в данном коде:<br>int x1 = 2;<br>
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
            threeErrorLabel.Text = "Верно!";
            threeErrorLabel.TextColor = Colors.Green;
        }
        else
        {
            threeErrorLabel.Text = "Не верно!";
            threeErrorLabel.TextColor = Colors.Red;
        }
    }
}