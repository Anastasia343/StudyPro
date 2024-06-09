using Microsoft.Maui.Controls;

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
            <p>Условные выражения<br><br>Отдельный набор операций представляет условные выражения. Такие операции возвращают логическое значение, то есть значение типа bool: true, если выражение истинно, и false, если выражение ложно. К подобным операциям относятся операции сравнения и логические операции.</p>
<p>Операции сравнения<br><br>В операциях сравнения сравниваются два операнда и возвращается значение типа bool - true, если выражение верно, и false, если выражение неверно.</p>
            <ul>
                <li>==<br>Сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false</li>
                <li>!=<br>Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.</li>
                <li><<br>Операция ""меньше чем"". Возвращает true, если первый операнд меньше второго, и false, если первый операнд больше второго</li>
                <li>><br>Операция ""больше чем"". Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false</li>
                <li><=<br>Операция ""меньше или равно"". Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false.</li>
                <li>>=<br>Операция ""больше или равно"". Сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false</li>
            </ul>
            <p>Операции <, > <=, >= имеют больший приоритет, чем == и !=.</p>
            <p>Логические операции<br><br>Также в C# определены логические операторы, которые также возвращают значение типа bool. В качестве операндов они принимают значения типа bool. Как правило, применяются к отношениям и объединяют несколько операций сравнения.</p>
            <ul>
                <li>|<br>Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true.</li>
                <li>&<br>Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.</li>
                <li>||<br>Операция логического сложения. Возвращает true, если хотя бы один из операндов возвращает true.</li>
                <li>&&<br>Операция логического умножения. Возвращает true, если оба операнда одновременно равны true.</li>
                <li>!<br>Операция логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false</li>
                <li>^<br>Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false</li>
            </ul>
            <p>Здесь у нас две пары операций | и || (а также & и &&) выполняют похожие действия, однако же они не равнозначны.<br>В выражении z=x|y; будут вычисляться оба значения - x и y.
            <br>В выражении же z=x||y; сначала будет вычисляться значение x, и если оно равно true, то вычисление значения y уже смысла не имеет, так как у нас в любом случае уже z будет равно true. Значение y будет вычисляться только в том случае, если x равно false
            <br>То же самое касается пары операций &/&&. В выражении z=x&y; будут вычисляться оба значения - x и y.
            <br>В выражении же z=x&&y; сначала будет вычисляться значение x, и если оно равно false, то вычисление значения y уже смысла не имеет, так как у нас в любом случае уже z будет равно false. Значение y будет вычисляться только в том случае, если x равно true
            <br>Поэтому операции || и && более удобны в вычислениях, так как позволяют сократить время на вычисление значения выражения, и тем самым повышают производительность. А операции | и & больше подходят для выполнения поразрядных операций над числами.</p>
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
            await Navigation.PushAsync(cSharp);
            Navigation.RemovePage(this);
            GlobalState.LabelCSharp.Text = "80%";
            GlobalState.RestartButtonElght.BackgroundColor = Color.FromRgb(172, 153, 234);
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
            <p>Какие из следующих вариантов представляют операцию И:</p>
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
    int one = 0;
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "4")
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

            <p>Какое вернет значение (тип bool) в данном коде:<br>bool x1 = (5 > 6) | (4 < 6);</p>
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
        if (twoAnswerEntry.Text == "True")
        {
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "true")
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
            <p>Какое вернет значение (тип bool) в данном коде:<br>bool x1 = (5 > 6) && (4 < 6);</p>
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
        if (threeAnswerEntry.Text == "false")
        {
            threeErrorLabel.Text = "Верно!";
            threeErrorLabel.TextColor = Colors.Green;
            ++three;
        }
        else if (threeAnswerEntry.Text == "False") 
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