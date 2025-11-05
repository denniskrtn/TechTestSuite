using TechTestSuite.UI.WPF.Core.Interfaces;
using TechTestSuite.UI.WPF.Core.Models;

namespace TechTestSuite.UI.WPF.Tests;

public class CommunicationTest : ITestModule
{
    public string TestName => "Communication Test";

    public async Task<TestResult> ExecuteAsync()
    {
        await Task.Delay(300);
        bool ok = new Random().Next(0, 10) > 1;
        return new TestResult
        {
            TestName = TestName,
            Passed = ok,
            Message = ok ? "Response OK" : "No response"
        };
    }
}