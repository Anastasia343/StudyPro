namespace StudyPro;

public partial class CSharpCycles : ContentPage
{
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
            <p>Циклы являются управляющими конструкциями, позволяя в зависимости от определенных условий выполнять некоторое действие множество раз. В C# имеются следующие виды циклов:</p>
            <ul>
                 <li>for</li>
                <li>foreach</li>
                <li>while</li>
                <li>do...while</li>
            </ul>
            <p>Цикл for</p>
            <p>Цикл for имеет следующее формальное определение:<br>for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])<br>
            {<br>
                // действия<br>
            }</p>
            <p>Объявление цикла for состоит из трех частей. Первая часть объявления цикла - некоторые действия, которые выполняются один раз до выполнения цикла. Обычно здесь определяются переменные, которые будут использоваться в цикле.<br>Вторая часть - условие, при котором будет выполняться цикл. Пока условие равно true, будет выполняться цикл.
            <br>И третья часть - некоторые действия, которые выполняются после завершения блока цикла. Эти действия выполняются каждый раз при завершении блока цикла.
            <br>После объявления цикла в фигурных скобках помещаются сами действия цикла.</p>
            <p>Если блок цикла for содержит одну инструкцию, то мы можем его сократить, убрав фигурные свобки:<br>
            for (int i = 1; i < 4; i++)<br>
                Console.WriteLine(i);<br><br>
 
            // или так<br>
            for (int i = 1; i < 4; i++) Console.WriteLine(i);</p>
            <p>Цикл do..while</p>
            <p>В цикле do сначала выполняется код цикла, а потом происходит проверка условия в инструкции while. И пока это условие истинно, цикл повторяется.<br><br>
            do<br>
            {<br>
                действия цикла<br>
            }<br>
            while (условие)</p>
            <p>Цикл while</p>
            <p>В отличие от цикла do цикл while сразу проверяет истинность некоторого условия, и если условие истинно, то код цикла выполняется:<br><br>
            while (условие)<br>
            {<br>
                действия цикла<br>
            }</p>
            <p>Цикл foreach</p>
            <p>Цикл foreach предназначен для перебора набора или коллекции элементов. Его общее определение:<br><br>
            foreach(тип_данных переменная in коллекция)<br>
            {<br>
                // действия цикла<br>
            }</p>
            <p>После оператора foreach в скобках сначала идет определение переменной. Затем ключевое слово in и далее коллекция, элементы которой надо перебрать.<br>
            При выполнении цикл последовательно перебирает элементы коллекции и помещает их в переменную, и таким образом в блоке цикла мы можем выполнить с ними некоторые действия.
            <br>Например, возьмем строку. Строка по сути - это коллекция символов. И .NET позволяет перебрать все элементы строки - ее символы с помощью цикла foreach.</p>
            <p>Стоит отметить, что переменная, которая определяется в объявлении цикла, должна по типу соответствовать типу элементов перебираемой коллекции. Так, элементы строки - значения типа char - символы. Поэтому переменная c имеет тип char. Однако в реальности не всегда бывает очевидно, какой тип представляют элементы коллекции. В этом случае мы можем определить переменную с помощью оператора var</p>
            <p>Операторы continue и break</p>
            <p>Иногда возникает ситуация, когда требуется выйти из цикла, не дожидаясь его завершения. В этом случае мы можем воспользоваться оператором break.</p>
            <p>for (int i = 0; i < 9; i++)<br>
            {<br>
                if (i == 5)<br>
                    break;<br>
                Console.WriteLine(i);<br>
            }</p>
            <p>Теперь поставим себе другую задачу. А что если мы хотим, чтобы при проверке цикл не завершался, а просто пропускал текущую итерацию. Для этого мы можем воспользоваться оператором continue:</p>
            <p>for (int i = 0; i < 9; i++)<br>
            {<br>
                if (i == 5)<br>
                    continue;<br>
                Console.WriteLine(i);<br>
            }</p>
            <p>Стоит отметить, что операторы break и continue можно применять в любом типе циклов.</p>
            <p>Вложенные циклы</p>
            <p>Одни циклы могут быть вложенными в другие. Например:<br><br>
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
            <p>Сколько раз выполнится следующий цикл:<br><br>int i = 5;<br>
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
    private void OneAnswerButton(object sender, EventArgs e)
    {
        if (oneAnswerEntry.Text == "1")
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

            <p>Что будет выведено на консоль в результате выполнения следующего цикла:<br><br>for(int i = 1; i < 3; i++)<br>
            {<br>
                switch (i)<br>
                {<br>
                    default:<br>
                        Console.WriteLine($""i = {i++}"");<br>
                        break;<br>
                }<br>
            }</p>
            <ol>
                 <li>Программа не скомпилируется</li>
                 <li>Ничего не будет выведено на консоль</li>
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
            <p>Сколько раз в этом цикле будет выполняться строка j = j - 1:<br><br>int j = 2;<br>
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
    private void ThreeAnswerButton(object sender, EventArgs e)
    {
        if (threeAnswerEntry.Text == "50")
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