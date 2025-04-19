using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double lastnumber, result;
    SelectedOperator selectedOperator;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
        double newNumber;
        if (double.TryParse(ResultLabel.Content.ToString(), out newNumber))
        {
            switch (selectedOperator)
            {
                case SelectedOperator.Addition:
                    result = SimpleMath.Add(lastnumber,newNumber);
                    break;
                case SelectedOperator.Subtraction:
                    result = SimpleMath.Subtract(lastnumber,newNumber);
                    break;
                case SelectedOperator.Multiplication:
                    result = SimpleMath.Multiply(lastnumber,newNumber);
                    break;
                case SelectedOperator.Division:
                    result = SimpleMath.Divide(lastnumber,newNumber);
                    break;
            }
            ResultLabel.Content = result.ToString();
        }
    }
    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(ResultLabel.Content.ToString(), out lastnumber))
        {
            ResultLabel.Content = "0";
        }
        if(sender == multiplicationButton)
            selectedOperator = SelectedOperator.Multiplication;
        else if (sender == divisionButton)
            selectedOperator = SelectedOperator.Division;
        else if (sender == AdditionButton)
            selectedOperator = SelectedOperator.Addition;
        else if (sender == SubtractionButton)
            selectedOperator = SelectedOperator.Subtraction;
    }
    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        int selectedValue = int.Parse((sender as Button).Content.ToString());
        if (ResultLabel.Content.ToString()=="0")
        {
            ResultLabel.Content = selectedValue.ToString();
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}{selectedValue}";
        }
    }
    private void acButton_Click(object sender, RoutedEventArgs e)
    {
        ResultLabel.Content = "0";
        result = 0;
        lastnumber = 0;
    }

    private void percentageButton_Click(object sender, RoutedEventArgs e)
    {
        double tempNumber;
        if (double.TryParse(ResultLabel.Content.ToString(), out tempNumber))
        {
            tempNumber /= 100;
            if(lastnumber != 0)
            {
                tempNumber *= lastnumber;
            }
            ResultLabel.Content = tempNumber.ToString();
        }
    }
    private void pointButton_Click(object sender, RoutedEventArgs e)
    {
        if (!ResultLabel.Content.ToString().Contains("."))
        {
            ResultLabel.Content = $"{ResultLabel.Content}.";
        }
    }

    private void negativeButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(ResultLabel.Content.ToString(), out double lastNumber))
        {
            lastNumber *= -1;
            ResultLabel.Content = lastNumber.ToString();
        }
    }
    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    public class SimpleMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            if(y == 0)
            {
                MessageBox.Show("Cannot divide by zero","Wrong operation",MessageBoxButton.OK,MessageBoxImage.Error);
                return 0;
            }
            return x / y;
        }
    }
}