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
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Seven_Click(object sender, RoutedEventArgs e)
    {
        if(ResultLabel.Content.ToString()=="0")
        {
            ResultLabel.Content = "7";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}7";
        }
    }

    private void EightButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "9";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}8";
        }
    }

    private void NineButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "9";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}9";
        }
    }

    private void FourButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "4";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}4";
        }
    }

    private void FiveButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "5";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}5";
        }
    }

    private void SixButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "6";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}6";
        }
    }

    private void OneButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "1";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}1";
        }
    }

    private void TwoButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "2";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}2";
        }
    }

    private void ThreeButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "3";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}3";
        }
    }

    private void ZeroButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResultLabel.Content.ToString() == "0")
        {
            ResultLabel.Content = "0";
        }
        else
        {
            ResultLabel.Content = $"{ResultLabel.Content}0";
        }
    }

    private void acButton_Click(object sender, RoutedEventArgs e)
    {
        ResultLabel.Content = "0";
    }

    private void percentageButton_Click(object sender, RoutedEventArgs e)
    {
        if(double.TryParse(ResultLabel.Content.ToString(), out double lastNumber))
        {
            lastNumber /= 100;
            ResultLabel.Content = lastNumber.ToString();
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
}