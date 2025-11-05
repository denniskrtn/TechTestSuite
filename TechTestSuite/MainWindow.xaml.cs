using System.Windows;
using TechTestSuite.UI.WPF.ViewModels;

namespace TechTestSuite.UI.WPF;

public partial class MainWindow : Window
{
    public MainViewModel ViewModel { get; } = new MainViewModel();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = ViewModel;
    }
}