using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpArithmeticOperations : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpArithmeticOperations()
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
            <p>Арифметические операции</p>
            <ul>
                <li>+<br>Операция сложения двух чисел</li>
                <li>-<br>Операция вычитания двух чисел</li>
                <li>*<br>Операция вычитания двух чисел</li>
                <li>/<br>операция деления двух чисел<br>При делении стоит учитывать, что если оба операнда представляют целые числа, то результат также будет округляться до целого числа:<br>
                double z = 10 /  4; //результат равен 2<br>Несмотря на то, что результат операции в итоге помещается в переменную типа double, которая позволяет сохранить дробную часть, но в самой операции участвуют два литерала, которые по умолчанию рассматриваются как объекты int, то есть целые числа, и результат то же будет целочисленный.<br>
                Для выхода из этой ситуации необходимо определять литералы или переменные, участвующие в операции, именно как типы double или float:<br>double z = 10.0 /  4.0; //результат равен 2.5</li>
                <li>%<br>Операция получение остатка от целочисленного деления двух чисел</li>
            </ul>
            <p>Унарные операций</p>
            <ul>
                <li>++<br>Операция инкремента<br>Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.<br>
                И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.<br>
                int x1 = 5;<br>
                int z1 = ++x1; // z1=6; x1=6<br>
                Console.WriteLine($""{x1} - {z1}"");<br>
                <br>
                int x2 = 5;<br>
                int z2 = x2++; // z2=5; x2=6<br>
                Console.WriteLine($""{x2} - {z2}"");</li>
                <li>--<br>Операция декремента или уменьшения значения на единицу. Также существует префиксная форма декремента (--x) и постфиксная (x--).<br>
                int x1 = 5;<br>
                int z1 = --x1; // z1=4; x1=4<br>
                Console.WriteLine($""{x1} - {z1}"");<br>
                <br>
                int x2 = 5;<br>
                int z2 = x2--; // z2=5; x2=4<br>
                Console.WriteLine($""{x2} - {z2}"");</li>
            </ul>
            <p>При выполнении сразу нескольких арифметических операций следует учитывать порядок их выполнения. Приоритет операций от наивысшего к низшему:</p>
            <ol>
                <li>Инкремент, декремент</li>
                <li>Умножение, деление, получение остатка</li>
                <li>Сложение, вычитание</li>
            </ol>
            <p>Для изменения порядка следования операций применяются скобки.</p>
            <p>Ассоциативность операторов</p>
            <p>Когда операции имеют один и тот же приоритет, порядок вычисления определяется ассоциативностью операторов. В зависимости от ассоциативности есть два типа операторов:</p>
            <ul>
                <li>Левоассоциативные операторы, которые выполняются слева направо</li>
                <li>Правоассоциативные операторы, которые выполняются справа налево</li>
            </ul>
            </body>
        </html>";

        textWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
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
            <p>В каком порядке верно перечислины арифметические операции:</p>
             <ol>
                 <li>Инкремент, Умножение, Сложение</li>
                 <li>Деление, Декремент, Получение остатка</li>
                 <li>Умножение, Сложение, Инкремент</li>
                 <li>Декремент, Сложение, Умножение</li>
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
        if (oneAnswerEntry.Text == "1")
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

            <p>Какой будет результат данного примера?<br>double z = 10.0 /  4.0;</p>
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
        if (twoAnswerEntry.Text == "2.5")
        {
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "2,5")
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
            <p>Что выведет следующий код:<br>
            int a = 3;<br>
            int b = 5;<br>
            int c = 40;<br>
            int d = c---b*a;<br>    // a=3  b=5  c=39  d=25
            Console.WriteLine($""a={a}  b={b}  c={c}  d={d}"");<br><br>в ответе написать результаты через пробел</p>
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
        if (threeAnswerEntry.Text == "3 5 39 25")
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
    private async void OnOpenCSarpCliked(object sender, EventArgs e)
    {
        if (one + two + three == 3)
        {
            var cSharp = new CSharp();
            GlobalState.LabelCSharp = "40%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonColorFour = Color.FromRgb(172, 153, 234);
            await Navigation.PushAsync(cSharp);
            Navigation.RemovePage(this);
        }
        else
            await DisplayAlert("Не доступно", "Есть не правильно решенные задания", "ок");
    }
}