namespace StudyPro;

public partial class CSharpAssignmentOperations : ContentPage
{
	public CSharpAssignmentOperations()
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
            <p>Операции присваивания</p>
            <p>Операции присвоения устанавливают значение. В операциях присвоения участвуют два операнда, причем левый операнд может представлять только модифицируемое именованное выражение, например, переменную
            <br>Как и во многих других языках программирования, в C# имеется базовая операция присваивания =, которая присвоивает значение правого операнда левому операнду:</p>
            <p>int number = 23;</p>
            <p>Также можно выполнять множественно присвоение сразу нескольких переменным одновременно:</p>
            <p>int a, b, c;<br>
            a = b = c = 34;</p>
            <p>Стоит отметить, что операции присвоения имеют низкий приоритет. И вначале будет вычисляться значение правого операнда и только потом будет идти присвоение этого значения левому операнду. Например:</p>
            <p>int a, b, c;<br>
            a = b = c = 34 * 2 / 4; // 17</p>
            <p>Кроме базовой операции присвоения в C# есть еще ряд операций:</p>
            <ul>
                <li>+=: присваивание после сложения. Присваивает левому операнду сумму левого и правого операндов: выражение A += B равнозначно выражению A = A + B</li>
                <li>-=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов: A -= B эквивалентно A = A - B</li>
                <li>*=: присваивание после умножения. Присваивает левому операнду произведение левого и правого операндов: A *= B эквивалентно A = A * B</li>
                <li>/=: присваивание после деления. Присваивает левому операнду частное левого и правого операндов: A /= B эквивалентно A = A / B</li>
                <li>%=: присваивание после деления по модулю. Присваивает левому операнду остаток от целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B</li>
                <li>&=: присваивание после поразрядной конъюнкции. Присваивает левому операнду результат поразрядной конъюнкции его битового представления с битовым представлением правого операнда: A &= B эквивалентно A = A & B</li>
                <li>|=: присваивание после поразрядной дизъюнкции. Присваивает левому операнду результат поразрядной дизъюнкции его битового представления с битовым представлением правого операнда: A |= B эквивалентно A = A | B</li>
                <li>^=: присваивание после операции исключающего ИЛИ. Присваивает левому операнду результат операции исключающего ИЛИ его битового представления с битовым представлением правого операнда: A ^= B эквивалентно A = A ^ B</li>
                <li><<=: присваивание после сдвига разрядов влево. Присваивает левому операнду результат сдвига его битового представления влево на определенное количество разрядов, равное значению правого операнда: A <<= B эквивалентно A = A << B</li>
                <li>>>=: присваивание после сдвига разрядов вправо. Присваивает левому операнду результат сдвига его битового представления вправо на определенное количество разрядов, равное значению правого операнда: A >>= B эквивалентно A = A >> B</li>          
            </ul>
            <p>Применение операций присвоения:</p>
            <p>int a = 10;<br>
            a += 10;        // 20<br>
            a -= 4;         // 16<br>
            a *= 2;         // 32<br>
            a /= 8;         // 4<br>
            a <<= 4;        // 64<br>
            a >>= 2;        // 16</p>
            <p>Операции присвоения являются правоассоциативными, то есть выполняются справа налево. Например:</p>
            <p>int a = 8;<br>
            int b = 6;<br>
            int c = a += b -= 5;    // 9</p>
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
            <p>Что выведет на консоль следующий код:<br>int c = 15;<br>
            c*=20;<br>
            Console.WriteLine(c);</p>
        </body>
        </html>";

        oneAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "300")
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
                color:#ACACAC;
            }
        </style>
        </head>
        <body>

            <p>Что выведет на консоль следующий код:<br>int c = 10;<br>
            c*=10/30+23;<br>
            Console.WriteLine(c);</p>
            <ol>
                 <li>-231</li>
                 <li>231</li>
                 <li>230</li>
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
        if (twoAnswerEntry.Text == "3")
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
                color:#ACACAC;
            }
        </style>
        </head>
        <body>
            <p>Что выведет на консоль следующий код:<br>
            int c = 1;<br>
            c*=10/1+10-10;<br>
            Console.WriteLine(c);</p>
        </body>
        </html>";

        threeAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "10")
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