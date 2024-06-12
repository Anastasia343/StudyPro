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
            <p>Преобразования базовых типов данных</p>
            <p>При рассмотрении типов данных указывалось, какие значения может иметь тот или иной тип и сколько байт памяти он может занимать. В прошлой теме были расмотрены арифметические операции. Теперь применим операцию сложения к данным разных типов:<br><br>
            byte a = 4;<br>
            int b = a + 70;<bt><br>
            Результатом операции вполне справедливо является число 74, как и ожидается.Но теперь попробуем применить сложение к двум объектам типа byte:<br><br>byte a = 4;<br>
            byte b = a + 70;  // ошибка</p>
            <p>Здесь поменялся только тип переменной, которая получает результат сложения - с int на byte. Однако при попытке скомпилировать программу мы получим ошибку на этапе компиляции. И если мы работаем в Visual Studio, среда подчеркнет вторую строку красной волнистой линией, указывая, что в ней ошибка.<br>
            При операциях мы должны учитывать диапазон значений, которые может хранить тот или иной тип. Но в данном случае число 74, которое мы ожидаем получить, вполне укладывается в диапазон значений типа byte, тем не менее мы получаем ошибку.<br>
            Дело в том, что операция сложения (да и вычитания) возвращает значение типа int, если в операции участвуют целочисленные типы данных с разрядностью меньше или равно int (то есть типы byte, short, int). Поэтому результатом операции a + 70 будет объект, который имеет длину в памяти 4 байта. Затем этот объект мы пытаемся присвоить переменной b, которая имеет тип byte и в памяти занимает 1 байт.<br>
            И чтобы выйти из этой ситуации, необходимо применить операцию преобразования типов. Операция преобразования типов предполагает указание в скобках того типа, к которому надо преобразовать значение<br>
            byte a = 4;<br>
            byte b = (byte)(a + 70);</p>
            <p>Сужающие и расширяющие преобразования</p>
            <p>Преобразования могут быть сужающие (narrowing) и расширяющие (widening). Расширяющие преобразования расширяют размер объекта в памяти. Например:</p>
            <p>byte a = 4;             // 0000100<br>
            ushort b = a;   // 000000000000100<br>То есть значение, которое занимает 8 бит, расширяется до 16 бит.</p>
            <p>Сужающие преобразования, наоборот, сужают значение до типа меньшей разядности. Во втором листинге статьи мы как раз имели дело с сужающими преобразованиями:<br><br>
            ushort a = 4;<br>
            byte b = (byte) a;</p>
            <p>Явные и неявные преобразования</p> 
            <p>Явные и неявные преобразования: в случае с расширяющими преобразованиями компилятор за нас выполнял все преобразования данных, то есть преобразования были неявными (implicit conversion). Такие преобразования не вызывают каких-то затруднений. Тем не менее стоит сказать пару слов об общей механике подобных преобразований.<br>
            Если производится преобразование от безнакового типа меньшей разрядности к безнаковому типу большой разрядности, то добавляются дополнительные биты, которые имеют значени 0. Это называется дополнение нулями или zero extension.<br><br>
            byte a = 4;             // 0000100<br>
            ushort b = a;   // 000000000000100</p>
            <p>Если производится преобразование к знаковому типу, то битовое представление дополняется нулями, если число положительное, и единицами, если число отрицательное. Последний разряд числа содержит знаковый бит - 0 для положительных и 1 для отрицательных чисел. При расширении в добавленные разряды компируется знаковый бит.</p>
            <p>Явные преобразования</p>
            <p>При явных преобразованиях (explicit conversion) мы сами должны применить операцию преобразования (операция ()). Суть операции преобразования типов состоит в том, что перед значением указывается в скобках тип, к которому надо привести данное значение:<br><br>
            int a = 4;<br>
            int b = 6;<br>
            byte c = (byte)(a+b);</p>
            <p>Расширяющие преобразования от типа с меньшей разрядностью к типу с большей разрядностью компилятор проводит неявно. Это могут быть следующие цепочки преобразований:</p>
            <p>byte -> short -> int -> long -> decimal<br>
            int -> double<br>
            short -> float -> double<br>
            char -> int</p>
            <p>Потеря точности данных</p>
            <p>Рассмотрим другую ситуацию, что будет, например, в следующем случае:<br><br>
            int a = 33;<br>
            int b = 600;<br>
            byte c = (byte)(a+b);<br>
            Console.WriteLine(c);   // 121<br><br>
            Результатом будет число 121, так число 633 не попадает в допустимый диапазон для типа byte, и старшие биты будут усекаться. В итоге получится число 121. Поэтому при преобразованиях надо это учитывать. И мы в данном случае можем либо взять такие числа a и b, которые в сумме дадут число не больше 255, либо мы можем выбрать вместо byte другой тип данных, например, int.</p>
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
            await DisplayAlert("Не доступно", "Есть не правильно решенные задания", "ок");
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
            <p>Какие преобразования типов НЕ выполняются автоматически (возможно, несколько вариантов):</p>
             <ol>
                 <li>Из int в short</li>
                 <li>Из short в int</li>
                 <li>Из bool в string</li>
                 <li>Из byte в float</li>
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
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "1 3")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "1,3")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
        }
        else if (oneAnswerEntry.Text == "1, 3")
        {
            oneErrorLabel.Text = "Верно!";
            oneErrorLabel.TextColor = Colors.Green;
            ++one;
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

            <p>Что выведет на консоль следующий код:<br>byte a = 13;<br>
            byte b =a + 20;<br>
            Console.WriteLine(b);</p>
            <ol>
                 <li>Ошибка компиляции</li>
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
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
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
            <p>Что выведет следующий код:<br>byte an = 4;<br>
            byte b = (byte)(a + 70);<br>
            Console.WriteLine(b);</p>
             <ol>
                 <li>74</li>
                 <li>Не скомпилируется</li>
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
            threeErrorLabel.Text = "Верно!";
            threeErrorLabel.TextColor = Colors.Green;
            ++three;
        }
        else
        {
            threeErrorLabel.Text = "Не верно!";
            threeErrorLabel.TextColor = Colors.Red;
        }
    }
}