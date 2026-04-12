using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Logistiks.Views;

public partial class LoginPage : UserControl
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void LoginClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.MainFrameInstance.Content = new LogistHomePage();
    }
}