using TechTestSuite.UI.WPF.Core.Interfaces;
using TechTestSuite.UI.WPF.Core.Models;

namespace TechTestSuite.UI.WPF.Tests;

public class CurrentTest : ITestModule
{
    public string TestName => "Current Measurement";

    public async Task<TestResult> ExecuteAsync()
    {
        await Task.Delay(500);
        double current = new Random().NextDouble() * 3; // 0–3A
        bool pass = current < 2.5;
        return new TestResult
        {
            TestName = TestName,
            Passed = pass,
            Message = pass ? $"Current OK ({current:F2} A)" : $"Too high ({current:F2} A)"
        };
    }
}