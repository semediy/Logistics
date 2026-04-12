using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Logistiks.Views;

public partial class StartPage : UserControl
{
    public StartPage()
    {
        InitializeComponent();
    }

    private void OpenLogin(object? sender, RoutedEventArgs e)
    {
        MainWindow.MainFrameInstance.Content = new LoginPage();
    }

    private void OpenRegister(object? sender, RoutedEventArgs e)
    {
        MainWindow.MainFrameInstance.Content = new RegisterPage();
    }
}