using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Logistiks;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LoginClick(object? sender, RoutedEventArgs e)
    {
        Title = "Вхід виконано";
    }
}