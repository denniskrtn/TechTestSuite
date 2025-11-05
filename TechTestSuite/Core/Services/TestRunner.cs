using TechTestSuite.UI.WPF.Core.Interfaces;
using TechTestSuite.UI.WPF.Core.Models;

namespace TechTestSuite.UI.WPF.Core.Services;

public class TestRunner
{
    private readonly IEnumerable<ITestModule> _modules;
    public TestRunner(IEnumerable<ITestModule> modules) => _modules = modules;

    public async Task<List<TestResult>> ExecuteAllAsync(Action<double>? progressCallback = null)
    {
        var results = new List<TestResult>();
        int total = _modules.Count();
        int index = 0;

        foreach (var module in _modules)
        {
            var result = await module.ExecuteAsync();
            results.Add(result);

            index++;
            progressCallback?.Invoke((double)index / total * 100);
        }

        return results;
    }
}