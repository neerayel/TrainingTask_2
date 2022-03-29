using System;
using System.Text;
using System.Windows;

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OutputResult.Clear();

            float number;
            int grade;

            if (float.TryParse(InputNumber.Text, out number) && int.TryParse(InputGrade.Text, out grade))
            {
                OutputResult.Text = string.Format("{0:f5}", MyMath.MyRoot(number, grade, 0.01F));
            }
            else
            {
                OutputResult.Text += "Поля Число и Степень должны содержать цифры";
            }

            if (float.TryParse(InputNumber.Text, out number))
            {
                int inpDecimal = Convert.ToInt32(float.Parse(InputNumber.Text));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in System.Text.Encoding.Unicode.GetBytes(inpDecimal.ToString()))
                    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');

                string binaryStr = sb.ToString();

                OutputBytes.Text = binaryStr;
            }
        }

        private void Number(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputNumber.Text))
            {
                NumberHelpText.Opacity = 0;
                InputNumber.Opacity = 1;
            }
            else
            {
                NumberHelpText.Opacity = 1;
                InputNumber.Opacity = 0.5;
            }
        }

        private void Grade(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputGrade.Text))
            {
                GradeHelpText.Opacity = 0;
                InputGrade.Opacity = 1;
            }
            else
            {
                GradeHelpText.Opacity = 1;
                InputGrade.Opacity = 0.5;
            }
        }

        private void Result(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputResult.Text))
            {
                ResultHelpText.Opacity = 0;
                OutputResult.Opacity = 1;
            }
            else
            {
                ResultHelpText.Opacity = 1;
                OutputResult.Opacity = 0.5;
            }

            int grade;
            float inp;

            if(float.TryParse(InputNumber.Text, out inp) && int.TryParse(InputGrade.Text, out grade))
            {
                OutputComparison.Text = " Результат Math.Pow - " + string.Format("{0:f5}", Math.Pow(inp, 1F / grade));
            }
        }

        private void Comparison(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputComparison.Text))
            {
                ComparisonHelpText.Opacity = 0;
                OutputComparison.Opacity = 1;
            }
            else
            {
                ComparisonHelpText.Opacity = 1;
                OutputComparison.Opacity = 0.5;
            }
        }

        private void Bytes(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputBytes.Text))
            {
                BytesHelpText.Opacity = 0;
                OutputBytes.Opacity = 1;
            }
            else
            {
                BytesHelpText.Opacity = 1;
                OutputBytes.Opacity = 0.5;
            }
        }
    }
}
