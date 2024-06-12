using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPro
{
    public class GlobalState
    {
        public static Button RestartButtonOne { get; set; }
        public static void SetButtonOne(Button button, Color color)
        {
            button.BackgroundColor = color;
            SaveButtoColor(color);
        }
        public static void SaveButtoColor(Color color)
        {
            var colorString = $"{color}";
            Preferences.Set("RestartButtonColor", colorString);
        }
        public static Color LoadButtonColor() 
        {
            var colorString = Preferences.Get("RestartButtonColor", "172, 153, 234");
            var colorParts = colorString.Split(',');
            return Color.FromArgb(colorParts[0]);
        }
        public static Button RestartButtonTwo { get; set; }
        public static Button RestartButtonThree { get; set; }
        public static Button RestartButtonFour { get; set; }
        public static Button RestartButtonFive { get; set; }
        public static Button RestartButtonSix { get; set; }
        public static Button RestartButtonSeven { get; set; }
        public static Button RestartButtonElght { get; set; }
        public static Button RestartButtonNine { get; set; }
        public static string LabelCSharp { get; set; } = "Default Text";
    }

    
}
