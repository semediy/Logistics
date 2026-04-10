using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Logistiks;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenLogin(object? sender, RoutedEventArgs e)
    {
        var loginWindow = new LoginWindow();
        loginWindow.Show();
    }

    private void OpenRegister(object? sender, RoutedEventArgs e)
    {
        var registerWindow = new RegisterWindow();
        registerWindow.Show();
    }

    private void CloseApp(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}