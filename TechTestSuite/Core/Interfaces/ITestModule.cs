using TechTestSuite.UI.WPF.Core.Models;

namespace TechTestSuite.UI.WPF.Core.Interfaces;

public interface ITestModule
{
    string TestName { get; }
    Task<TestResult> ExecuteAsync();
}