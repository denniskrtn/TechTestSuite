using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TechTestSuite.UI.WPF.Core.Interfaces;
using TechTestSuite.UI.WPF.Core.Models;
using TechTestSuite.UI.WPF.Core.Services;
using TechTestSuite.UI.WPF.Tests;

namespace TechTestSuite.UI.WPF.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<TestResult> Results { get; set; } = new();

    private double _progress;
    public double Progress
    {
        get => _progress;
        set
        {
            if (_progress != value)
            {
                _progress = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand StartTestsCommand { get; }

    public MainViewModel()
    {
        StartTestsCommand = new RelayCommand(async () => await RunTests());
    }

    private async Task RunTests()
    {
        Results.Clear();
        Progress = 0;

        var modules = new List<ITestModule>
        {
            new CurrentTest(),
            new VoltageTest(),
            new CommunicationTest()
        };

        var runner = new TestRunner(modules);
        var results = await runner.ExecuteAllAsync(p => Progress = p);

        foreach (var r in results)
            Results.Add(r);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}