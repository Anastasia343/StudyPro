using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPro
{
    public class GlobalState
    {
        public static string? LabelCSharp { get; set; } = "Default Text";

        private const string RestartButtonColorKeyOne = "RestartButtonColorOne";
        private static Color? restartButtonColorOne;

        private const string RestartButtonColorKeyTwo = "RestartButtonColorTwo";
        private static Color? restartButtonColorTwo;

        private const string RestartButtonColorKeyThree = "RestartButtonColorThree";
        private static Color? restartButtonColorThree;

        private const string RestartButtonColorKeyFour = "RestartButtonColorFour";
        private static Color? restartButtonColorFour;

        private const string RestartButtonColorKeyFive = "RestartButtonColorFive";
        private static Color? restartButtonColorFive;

        private const string RestartButtonColorKeySix = "RestartButtonColorSix";
        private static Color? restartButtonColorSix;

        private const string RestartButtonColorKeySeven = "RestartButtonColorSeven";
        private static Color? restartButtonColorSeven;

        private const string RestartButtonColorKeyElght = "RestartButtonColorElght";
        private static Color? restartButtonColorElght;

        private const string RestartButtonColorKeyNine = "RestartButtonColorNine";
        private static Color? restartButtonColorNine;
        static GlobalState() //System.NullReferenceException: 'Object reference not set to an instance of an object.'
        {
            //1
            if (Preferences.ContainsKey(RestartButtonColorKeyOne))
            {
                Preferences.Get(RestartButtonColorKeyOne, string.Empty);
                restartButtonColorOne = Color.FromRgb(128, 128, 128);
            }
            //2 string colorStringOne = 
            else if (Preferences.ContainsKey(RestartButtonColorKeyTwo))
            {
                Preferences.Get(RestartButtonColorKeyTwo, string.Empty);
                restartButtonColorTwo = Color.FromRgb(128, 128, 128);
            }
            //3
            else if (Preferences.ContainsKey(RestartButtonColorKeyThree))
            {
                Preferences.Get(RestartButtonColorKeyThree, string.Empty);
                restartButtonColorThree = Color.FromRgb(128, 128, 128);
            }
            //4
            else if (Preferences.ContainsKey(RestartButtonColorKeyFour)) 
            {
                Preferences.Get(RestartButtonColorKeyFour, string.Empty);
                restartButtonColorFour = Color.FromRgb(128, 128, 128);
            }
            //5
            else if (Preferences.ContainsKey(RestartButtonColorKeyFive))
            {
                Preferences.Get(RestartButtonColorKeyFive, string.Empty);
                restartButtonColorFive = Color.FromRgb(128, 128, 128);
            }
            //6
            else if (Preferences.ContainsKey(RestartButtonColorKeySix))
            {
                Preferences.Get(RestartButtonColorKeySix, string.Empty);
                restartButtonColorSix = Color.FromRgb(128, 128, 128);
            }
            //7
            else if (Preferences.ContainsKey(RestartButtonColorKeySeven))
            {
                Preferences.Get(RestartButtonColorKeySeven, string.Empty);
                restartButtonColorSeven = Color.FromRgb(128, 128, 128);
            }
            //8
            else if (Preferences.ContainsKey(RestartButtonColorKeyElght))
            {
                Preferences.Get(RestartButtonColorKeyElght, string.Empty);
                restartButtonColorElght = Color.FromRgb(128, 128, 128);
            }
            //9
            else if (Preferences.ContainsKey(RestartButtonColorKeyNine))
            {
                Preferences.Get(RestartButtonColorKeyNine, string.Empty);
                restartButtonColorNine = Color.FromRgb(128, 128, 128);
            }
        }
        public static Button? RestartButtonOne { get; set; }
        public static Button? RestartButtonTwo { get; set; }
        public static Button? RestartButtonThree { get; set; }
        public static Button? RestartButtonFour { get; set; }
        public static Button? RestartButtonFive { get; set; }
        public static Button? RestartButtonSix { get; set; }
        public static Button? RestartButtonSeven { get; set; }
        public static Button? RestartButtonElght { get; set; }
        public static Button? RestartButtonNine { get; set; }
        //1
        public static Color RestartButtonColorOne
        { 
            get => restartButtonColorOne;
            set 
            {
                restartButtonColorOne = value;
                Preferences.Set(RestartButtonColorKeyOne, restartButtonColorOne.ToHex());
                if (RestartButtonOne != null)
                    RestartButtonOne.BackgroundColor = restartButtonColorOne;
            }
        }
        //2
        public static Color RestartButtonColorTwo
        {
            get => restartButtonColorTwo;
            set
            {
                restartButtonColorTwo = value;
                Preferences.Set(RestartButtonColorKeyTwo, restartButtonColorTwo.ToHex());
                if (RestartButtonTwo != null)
                    RestartButtonTwo.BackgroundColor = restartButtonColorTwo;
            }
        }
        //3
        public static Color RestartButtonColorThree
        {
            get => restartButtonColorThree;
            set
            {
                restartButtonColorThree = value;
                Preferences.Set(RestartButtonColorKeyThree, restartButtonColorThree.ToHex());
                if (RestartButtonThree != null)
                    RestartButtonThree.BackgroundColor = restartButtonColorThree;
            }
        }
        //4
        public static Color RestartButtonColorFour
        {
            get => restartButtonColorFour;
            set
            {
                restartButtonColorFour = value;
                Preferences.Set(RestartButtonColorKeyFour, restartButtonColorFour.ToHex());
                if (RestartButtonFour != null)
                    RestartButtonFour.BackgroundColor = restartButtonColorFour;
            }
        }
        //5
        public static Color RestartButtonColorFive
        {
            get => restartButtonColorFive;
            set
            {
                restartButtonColorFive = value;
                Preferences.Set(RestartButtonColorKeyFive, restartButtonColorFive.ToHex());
                if (RestartButtonFive != null)
                    RestartButtonFive.BackgroundColor = restartButtonColorFive;
            }
        }
        //6
        public static Color RestartButtonColorSix
        {
            get => restartButtonColorSix;
            set
            {
                restartButtonColorSix = value;
                Preferences.Set(RestartButtonColorKeySix, restartButtonColorSix.ToHex());
                if (RestartButtonSix != null)
                    RestartButtonSix.BackgroundColor = restartButtonColorSix;
            }
        }
        //7
        public static Color RestartButtonColorSeven
        {
            get => restartButtonColorSeven;
            set
            {
                restartButtonColorSeven = value;
                Preferences.Set(RestartButtonColorKeySeven, restartButtonColorSeven.ToHex());
                if (RestartButtonSeven != null)
                    RestartButtonSeven.BackgroundColor = restartButtonColorSeven;
            }
        }
        //8
        public static Color RestartButtonColorElght
        {
            get => restartButtonColorElght;
            set
            {
                restartButtonColorElght = value;
                Preferences.Set(RestartButtonColorKeyElght, restartButtonColorElght.ToHex());
                if (RestartButtonElght != null)
                    RestartButtonElght.BackgroundColor = restartButtonColorElght;
            }
        }
        //9
        public static Color RestartButtonColorNine
        {
            get => restartButtonColorNine;
            set
            {
                restartButtonColorNine = value;
                Preferences.Set(RestartButtonColorKeyNine, restartButtonColorNine.ToHex());
                if (RestartButtonNine != null)
                    RestartButtonNine.BackgroundColor = restartButtonColorNine;
            }
        }
    }

    
}
