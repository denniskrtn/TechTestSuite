using TechTestSuite.UI.WPF.Core.Interfaces;
using TechTestSuite.UI.WPF.Core.Models;

namespace TechTestSuite.UI.WPF.Tests;

public class VoltageTest : ITestModule
{
    public string TestName => "Voltage Check";

    public async Task<TestResult> ExecuteAsync()
    {
        await Task.Delay(400);
        double voltage = 230 + (new Random().NextDouble() - 0.5) * 10;
        bool pass = voltage > 220 && voltage < 240;
        return new TestResult
        {
            TestName = TestName,
            Passed = pass,
            Message = pass ? $"Voltage OK ({voltage:F1} V)" : $"Out of range ({voltage:F1} V)"
        };
    }
}