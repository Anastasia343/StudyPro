using Microsoft.Maui.Controls;

namespace StudyPro;

public partial class CSharpVariables : ContentPage
{
    const string LabelKey = "SavedLabel";
    public CSharpVariables()
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
            <p>Переменные</p>
            <p>Для хранения данных в программе применяются переменные. Переменная представляет именнованную область памяти, в которой хранится значение определенного типа.
            Переменная имеет тип, имя и значение. Тип определяет, какого рода информацию может хранить переменная.</p>
            <p>Синтаксис определения переменной:</p>
            <p>тип имя_переменной;</p>
            <p>Вначале идет тип переменной, потом ее имя. В качестве имени переменной может выступать любое произвольное название, которое удовлетворяет следующим требованиям:</p>
            <ul>
                <li>имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания</li>
                <li>в имени не должно быть знаков пунктуации и пробелов</li>
                <li>имя не может быть ключевым словом языка C#. Таких слов не так много, и при работе в Visual Studio среда разработки подсвечивает ключевые слова синим цветом.</li>
            </ul>
            <p>Хотя имя переменой может быть любым, но следует давать переменным описательные имена, которые будут говорить об их предназначении.</p> 
            <p>string name;</p>
            <p>В данном случае определена переменная name, которая имеет тип string. то есть переменная представляет строку. Поскольку определение переменной представляет собой инструкцию, то после него ставится точка с запятой.</p>
            <p>При этом следует учитывать, что C# является регистрозависимым языком, поэтому следующие два определения переменных будут представлять две разные переменные:</p>
            <p>string name;<br>
             string Name;</p>
            <p>После определения переменной можно присвоить некоторое значение:</p>
            <p>string name;<br>
            name = ""Tom"";</p>
            <p>Так как переменная name представляет тип string, то есть строку, то мы можем присвоить ей строку в двойных кавычках. Причем переменной можно присвоить только то значение, которое соответствует ее типу.</p>
            <p>В дальнейшем с помощью имени переменной мы сможем обращаться к той области памяти, в которой хранится ее значение.</p>
            <p>Также мы можем сразу при определении присвоить переменной значение. Данный прием называется инициализацией:</p>
            <p>string name = ""Tom"";</p>
            <p>Отличительной чертой переменных является то, что в программе можно многократно менять их значение. </p>
            <p>Константы</p>
            <p>Отличительной особенностью переменных является то, что мы можем изменить их значение в процессе работы программы. Но, кроме того, в C# есть константы. Константа должна быть обязательно инициализирована при определении,
            и после определения значение константы не может быть изменено</p>
            <p>Константы предназначены для описания таких значений, которые не должны изменяться в программе. Для определения констант используется ключевое слово const, которое указывается перед типом константы:</p>
            <p>const string NAME = ""Tom"";  // определяем константу</p>
            <p>При использовании констант надо помнить, что объявить мы их можем только один раз и что к моменту компиляции они должны быть определены. Так, в следующем случае мы получим ошибку, так как константе не присвоено начальное значение:</p>
            <p>const string NAME;  // ! Ошибка - константа NAME не инициализирована</p>
            <p>Кроме того, мы ее не сможем изменить в процессе работы программы:</p>
            <p>const string NAME = ""Tom"";  // определяем константу<br>
            NAME = ""Bob"";   // !Ошибка - у констаты нельзя изменить значение</p>
            <p>Таким образом, если нам надо хранить в программе некоторые данные, но их не следует изменить, они определяются в виде констант. Если же их можно изменять, то они определяются в виде переменных.</p>
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
            GlobalState.LabelCSharp = "20%";
            Preferences.Set(LabelKey, GlobalState.LabelCSharp);
            GlobalState.RestartButtonTwo.BackgroundColor = Color.FromRgb(172, 153, 234);
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
            <p>Какие из следующих вариантов представляют корректное определение переменных:</p>
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
    int one = 0;
    private void OneAnswerButton (object sender, EventArgs e) 
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

            <p>Что выведет на консоль следующий код:<br>string person = ""Tom"";<br>
            person = ""Sam"";<br>
            Console.WriteLine(person);</p>
        </body>
        </html>";

        twoAnswerWebView.Source = new HtmlWebViewSource
        {
            Html = html
        };
    }
    int two = 0;
    private void TwoAnswerButton (object sender, EventArgs e)
    {
        if (twoAnswerEntry.Text == "Sam")
        {
            twoErrorLabel.Text = "Верно!";
            twoErrorLabel.TextColor = Colors.Green;
            ++two;
        }
        else if (twoAnswerEntry.Text == "sam") 
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
            string name = ""Tom"";<br>
            Console.WriteLine(Name);</p>
             <ol>
                 <li>не скомпилируется</li>
                 <li>Tom</li>
                 <li>Name</li>
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
        if (threeAnswerEntry.Text == "1")
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