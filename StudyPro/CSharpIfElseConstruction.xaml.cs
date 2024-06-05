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
            <p>Конструкция if..else</p>
            <p>Выражениеif</p>
            <p>Условные конструкции - один из базовых компонентов многих языков программирования, которые направляют работу программы по одному из путей в зависимости от определенных условий. Одной из таких конструкций в языке программирования C# является конструкция if..else<br>
            Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.<br>
            Ее простейшая форма состоит из блока if:<br>
            if(условие)<br>
            {<br>
                выполняемые инструкции<br>
            }<br><br>
            После ключевого слова if ставится условие. Условие должно представлять значение типа bool. Это может быть непосредственно значение типа bool или результат условного выражения или другого выражения, которое возвращает значение типа bool. И если это условие истинно (равно true), то срабатывает код, который помещен далее после условия внутри фигурных скобок.</p>
            <p>Если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки:<br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if (num1 > num2)<br>
            Console.WriteLine($""Число {num1} больше числа {num2}"");<br><br>
            // или так<br>
            if (num1 > num2) Console.WriteLine($""Число {num1} больше числа {num2}"");</p>
            <p>Выражение else</p>
            <p>Но что, если мы захотим, чтобы при несоблюдении условия также выполнялись какие-либо действия? В этом случае мы можем добавить блок else:<br><br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if(num1 > num2)<br>
            {<br>
                Console.WriteLine($""Число {num1} больше числа {num2}"");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine($""Число {num1} меньше числа {num2}"");<br>
            }</p>
            <p>Блок else выполняется, если условие после if ложно, то есть равно false. Если блок else содержит толко одну инструкцию, то оять же мы можем его сократить, убрав фигурные скобки</p>
            <p>Выражение else if</p>
            <p>Но в примере выше при сравнении чисел мы можем насчитать три состояния: первое число больше второго, первое число меньше второго и числа равны. Используя конструкцию else if, мы можем обрабатывать дополнительные условия:<br><br>
            int num1 = 8;<br>
            int num2 = 6;<br>
            if(num1 > num2)<br>
            {<br>
                Console.WriteLine($""Число {num1} больше числа {num2}"");<br>
            }<br>
            else if (num1 < num2)<br>
            {<br>
                Console.WriteLine($""Число {num1} меньше числа {num2}"");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine(""Число num1 равно числу num2"");<br>
            }<br><br>
            При необходимости можно добавить несколько выражений else if</p>
            <p>Тернарная операция</p>
            <p>Тернарную операция также позволяет проверить некоторое условие и в зависимости от его истинности выполнить некоторые действия.Она имеет следующий синтаксис:<br>
            [первый операнд - условие] ? [второй операнд] : [третий операнд]</p>
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
            <p>Напишите, что не хватает в данном коде, если для входа в бар строго с 18 лет:<br>string name = ""Tom"";<br>
           int age = 17;<br>
            if()<br>
                Console.WriteLine(""Добро пожаловать в наш бар!"");<br>
            else<br>
                Console.WriteLine(""Вы не проходите!"");</p>
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
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age > 17")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age >=18")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
        }
        else if (oneAnswerEntry.Text == "age >= 18")
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

            <p>В данном коде присутствует ошибка. Напишите полностью исправленную вами часть кода. <br>string name = ""Tom"";<br>
           int age = 16;<br>
           int height = 167;<br>
            if(Name = ""Tom"")<br>
                Console.WriteLine($""привет, меня зовут{name}"");<br>
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
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
        }
        else if (twoAnswerEntry.Text == "(name=\"Tom\")")
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
            <p>Что выведет следующий код:<br>
            string name = ""Tom"";<br>
           int age = 13;<br>
            if(age>13)<br>
                Console.WriteLine(""вы можете получть паспорт"");<br>
            else<br>
                Console.WriteLine(""вы не можете получить паспорт"");</p>
             <ol>
                 <li>не скомпилируется</li>
                 <li>вы можете получть паспорт</li>
                 <li>вы не можете получить паспорт</li>
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