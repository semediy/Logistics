using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Logistiks.Views;

public partial class LogistHomePage : UserControl
{
    public LogistHomePage()
    {
        InitializeComponent();
        
        ContentArea.Content = new TransportationsPage();
        ContentArea.Content = new DriversPage();
    }

    private void OpenTransport(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new TransportationsPage();
    }

    private void OpenDrivers(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new DriversPage();
    }

    private void OpenRoutes(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new RoutesPage();
    }

    private void OpenVehicles(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new VehiclesPage();
    }

    private void OpenCalendar(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new CalendarPage();
    }

    private void OpenSettings(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = new SettingsPage();
    }
}