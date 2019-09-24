using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;

namespace ScientificCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// manualResetEvent = new ManualResetEvent(false);
    class Program
    {
        
    }
    public partial class MainWindow : Window
    {
        decimal num1 = 0;
        decimal num2 = 0;
        public string Operator = "";
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        public MainWindow()
        {
            InitializeComponent();
            manualResetEvent = new ManualResetEvent(false);
        //    GreetMe();
        //    Console.WriteLine("Speak");
            RecognizeSpeechAndMakeSureTheComputerSpeaksToYou();
        }
        public void input(string a)
        {
            if (txt_Main.Text == "0")
                txt_Main.Text = a;
            else
                txt_Main.Text += a;
        }

        private void btn_O_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Operator = (Button)sender;
            Operator = btn_Operator.Content.ToString();
            num1 = decimal.Parse(txt_Main.Text);
            txt_Main.Text = "0";
        }

        private void btn_Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Number = (Button)sender;
            input(btn_Number.Content.ToString());
        }

        private void btn_Dot_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Main.Text != "")
            {
                if (!txt_Main.Text.Contains("."))
                    input(".");
            }
        }

        private void txt_Main_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Main.Text != "0")
            {
                if (txt_Main.Text.Length == 1)
                {
                    txt_Main.Text = "0";
                }
                else if (txt_Main.Text.Length > 0)
                {
                    txt_Main.Text = txt_Main.Text.Substring(0, txt_Main.Text.Length - 1);
                }
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txt_Main.Text = "0";
            Operator = "";
            num1 = 0;
            num2 = 0;
        }

        private void btn_Equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = decimal.Parse(txt_Main.Text);
            ////////////////////////////////
            switch (Operator)
            {
                case "+":
                    txt_Main.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txt_Main.Text = (num1 - num2).ToString();
                    break;
                case "×":
                    txt_Main.Text = (num1 * num2).ToString();
                    break;
                case "÷":
                    txt_Main.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()),double.Parse(num2.ToString()))).ToString();
                    break;
                case "Mod":
                    txt_Main.Text = (num1 % num2).ToString();
                    break;
            }
        }

        private void btn_Sin_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == "")
                txt_Main.Text = (Math.Sin(double.Parse(txt_Main.Text))).ToString();
            else if (num1 != 0 && Operator != "" && num2 == 0)
                txt_Main.Text = (Math.Sin(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        txt_Main.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }

                txt_Main.Text = (Math.Sin(double.Parse(txt_Main.Text))).ToString();
            }
        }

        private void btn_Cos_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == "")
                txt_Main.Text = (Math.Cos(double.Parse(txt_Main.Text))).ToString();
            else if (num1 != 0 && Operator != "" && num2 == 0)
                txt_Main.Text = (Math.Cos(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        txt_Main.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }

                txt_Main.Text = (Math.Cos(double.Parse(txt_Main.Text))).ToString();
            }
        }

        private void btn_Log_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == "")
                txt_Main.Text = (Math.Log(double.Parse(txt_Main.Text))).ToString();
            else if (num1 != 0 && Operator != "" && num2 == 0)
                txt_Main.Text = (Math.Log(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        txt_Main.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }

                txt_Main.Text = (Math.Log(double.Parse(txt_Main.Text))).ToString();
            }
        }

        private void btn_Radical_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == "")
                txt_Main.Text = (Math.Sqrt(double.Parse(txt_Main.Text))).ToString();
            else if (num1 != 0 && Operator != "" && num2 == 0)
                txt_Main.Text = (Math.Sqrt(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        txt_Main.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }

                txt_Main.Text = (Math.Sqrt(double.Parse(txt_Main.Text))).ToString();
            }
        }

        private void btn_Tan_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == "")
                txt_Main.Text = (Math.Tan(double.Parse(txt_Main.Text))).ToString();
            else if (num1 != 0 && Operator != "" && num2 == 0)
                txt_Main.Text = (Math.Tan(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        txt_Main.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }

                txt_Main.Text = (Math.Tan(double.Parse(txt_Main.Text))).ToString();
            }
        }

        private void btn_Fact_Click(object sender, RoutedEventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(txt_Main.Text); i++)
            {
                f = f * i;
            }
            txt_Main.Text = f.ToString();
        }
        public static SpeechRecognitionEngine _recognizer = null;
        public static ManualResetEvent manualResetEvent = null;
        public static String first = "";
        public static String second = "";
        public static String operation = "";
        public static Boolean firstString = true;
        /* static void Main(string[] args)
         {
             manualResetEvent = new ManualResetEvent(false);
             GreetMe();
             Console.WriteLine("Speak");
             RecognizeSpeechAndMakeSureTheComputerSpeaksToYou();
             Console.ReadKey(true);
         }*/
        public static void GreetMe()
        {
            String str = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(str);
            if ((str.CompareTo("03:59:59") < 0))
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("Sir you're up so late anything important");
                speechSynthesizer.Dispose();
            }
            else
            if ((str.CompareTo("12:00:01") < 0))
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("good morning sir, im Aegis");
                speechSynthesizer.Dispose();
            }
            else
            if ((str.CompareTo("16:00:01") < 0))
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("good afternoon sir");
                speechSynthesizer.Dispose();
            }
            else
                if ((str.CompareTo("20:00:01") < 0))
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("good evening sir");
                speechSynthesizer.Dispose();
            }
            else
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("Sir its dark");
                Task.Delay(5);
                speechSynthesizer.Speak("you might want to turn on lights");
                speechSynthesizer.Dispose();
            }

        }
        private static Grammar CreateGrammarDocument()
        {
            GrammarBuilder gBuilder = new GrammarBuilder();
            // Construct GrammarBuilder here
            gBuilder.Append(new Choices("One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Zero", "Point", "Dot"));
            Grammar speechGrammar = new Grammar(gBuilder);
            return speechGrammar;
        }
        private static Grammar CreateGrammarDocument1()
        {
            GrammarBuilder gBuilder = new GrammarBuilder();
            // Construct GrammarBuilder here
            //gBuilder.Append(new Choices("Aegis"));
            gBuilder.Append(new Choices("decrease volume", "increase volume", "close","input","add", "sum", "plus", "minus", "answer", "result", "back","Del","divide","by","times","subtract","multiply"));
            Grammar speechGrammar = new Grammar(gBuilder);
            return speechGrammar;
        }
        public void RecognizeSpeechAndMakeSureTheComputerSpeaksToYou()
        {
            _recognizer = new SpeechRecognitionEngine();
            #region Grammar builder
            _recognizer.LoadGrammar(CreateGrammarDocument());
            _recognizer.LoadGrammar(CreateGrammarDocument1());
            #endregion
            _recognizer.SpeechRecognized += _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized; // if speech is recognized, call the specified method
            _recognizer.SpeechRecognitionRejected += _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected;
            _recognizer.SetInputToDefaultAudioDevice(); // set the input to the default audio device
            _recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous

        }
        static String _appendToString(String main, int appender)
        {
            return main + appender;
        }
        static String _appendToString(String main, String appender)
        {
            return main + appender;
        }
        void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            Console.Write(e.Result.Text);
            if (e.Result.Text == "One" || e.Result.Text == "one")
            {
                input("1");
                if (firstString)
                {
                    first = _appendToString(first, 1);
                }
                else
                {
                    second = _appendToString(second, 1);
                }
            }
            else if (e.Result.Text == "Two" || e.Result.Text == "two")
            {
                input("2");
                if (firstString)
                {
                    first = _appendToString(first, 2);
                }
                else
                {
                    second = _appendToString(second, 2);
                }
            }
            else if (e.Result.Text == "Three" || e.Result.Text == "three")
            {
                input("3");
                if (firstString)
                {
                    first = _appendToString(first, 3);
                }
                else
                {
                    second = _appendToString(second, 3);
                }
            }
            else if (e.Result.Text == "Four" || e.Result.Text == "four")
            {
                input("4");
                if (firstString)
                {
                    first = _appendToString(first, 4);
                }
                else
                {
                    second = _appendToString(second, 4);
                }
            }
            else if (e.Result.Text == "Five" || e.Result.Text == "five")
            {
                input("5");
                if (firstString)
                {
                    first = _appendToString(first, 5);
                }
                else
                {
                    second = _appendToString(second, 5);
                }
            }
            else if (e.Result.Text == "Six" || e.Result.Text == "six")
            {
                input("6");
                if (firstString)
                {
                    first = _appendToString(first, 6);
                }
                else
                {
                    second = _appendToString(second, 6);
                }
            }
            else if (e.Result.Text == "Seven" || e.Result.Text == "seven")
            {
                input("7");
                if (firstString)
                {
                    first = _appendToString(first, 7);
                }
                else
                {
                    second = _appendToString(second, 7);
                }
            }
            else if (e.Result.Text == "Eight" || e.Result.Text == "eight")
            {
                input("8");
                if (firstString)
                {
                    first = _appendToString(first, 8);
                }
                else
                {
                    second = _appendToString(second, 8);
                }
            }
            else if (e.Result.Text == "Nine" || e.Result.Text == "nine")
            {
                input("9");
                if (firstString)
                {
                    first = _appendToString(first, 9);
                }
                else
                {
                    second = _appendToString(second, 9);
                }
            }
            else if (e.Result.Text == "Zero" || e.Result.Text == "zero")
            {
                input("0");
                if (firstString)
                {
                    first = _appendToString(first, 0);
                }
                else
                {
                    second = _appendToString(second, 0);
                }
            }
            else if (e.Result.Text == "Point" || e.Result.Text == "Dot")
            {
                input(".");
                if (firstString)
                {
                    first = _appendToString(first, ".");
                }
                else
                {
                    second = _appendToString(second, ".");
                }
            }
            else if (e.Result.Text == "plus" || e.Result.Text == "add" || e.Result.Text=="sum")
            {
                firstString = false;
                operation = "plus";
                Operator = "+";
                num1 = decimal.Parse(txt_Main.Text);
                txt_Main.Text = "0";

            }
            else if (e.Result.Text == "minus" || e.Result.Text == "subtract")
            {
                firstString = false;
                operation = "minus";
                Operator = "-";
                num1 = decimal.Parse(txt_Main.Text);
                txt_Main.Text = "0";

            }
            else if (e.Result.Text == "multiply" || e.Result.Text == "times")
            {
                firstString = false;
                operation = "product";
                Operator = "×";
                num1 = decimal.Parse(txt_Main.Text);
                txt_Main.Text = "0";
            }
            else if (e.Result.Text == "divide" || e.Result.Text == "by")
            {
                firstString = false;
                operation = "divide";
                Operator = "÷";
                num1 = decimal.Parse(txt_Main.Text);
                txt_Main.Text = "0";

            }
            else if(e.Result.Text == "back" || e.Result.Text== "Del")
            {
                if (txt_Main.Text != "0")
                {
                    if (txt_Main.Text.Length == 1)
                    {
                        txt_Main.Text = "0";
                    }
                    else if (txt_Main.Text.Length > 0)
                    {
                        txt_Main.Text = txt_Main.Text.Substring(0, txt_Main.Text.Length - 1);
                    }
                }
            }
            else if (e.Result.Text == "result" || e.Result.Text == "Result" )
            {
                num2 = decimal.Parse(txt_Main.Text);
                ////////////////////////////////
                switch (Operator)
                {
                    case "+":
                        txt_Main.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        txt_Main.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        txt_Main.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        if (num2 == 0)
                        {
                            speechSynthesizer.Speak("cannot divide by zero");
                        }
                        else
                        {
                            txt_Main.Text = (num1 / num2).ToString();
                        }
                        break;
                    case "^":
                        txt_Main.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        txt_Main.Text = (num1 % num2).ToString();
                        break;
                }
                speechSynthesizer.Speak("The result is " + txt_Main.Text);
            }else if (e.Result.Text == "close")
            {
                speechSynthesizer.Speak("closing calculator");
                Environment.Exit(0);
                manualResetEvent.Set();
            }else if (e.Result.Text.Contains("input"))
            {
                speechSynthesizer.Speak("The input box contains " + txt_Main.Text);
            }else if (e.Result.Text == "decrease volume")
            {
                if (defaultPlaybackDevice.Volume == 0)
                {
                    speechSynthesizer.Speak("Volume is minimum");
                }
                else
                {
                    Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                    defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume - 20;
                    speechSynthesizer.Speak("Volume decreased to " + defaultPlaybackDevice.Volume + " percentage");
                }
            }
            else if (e.Result.Text == "increase volume")
            {
                if (defaultPlaybackDevice.Volume == 100)
                {
                    speechSynthesizer.Speak("Volume is maximum");
                }
                else
                {
                    Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                    defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume + 20;
                    speechSynthesizer.Speak("Volume increased to " + defaultPlaybackDevice.Volume + " percentage");
                }
            }
            else
            {
                Console.WriteLine("NO MATCH : " + first);
            }
            speechSynthesizer.Dispose();
        }
        static void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            if (e.Result.Alternates.Count == 0)
            {
                Console.WriteLine("No candidate phrases found.");
                return;
            }

        }
    }
}