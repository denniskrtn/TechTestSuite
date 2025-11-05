namespace TechTestSuite.UI.WPF.Core.Models;

public class TestResult
{
    public string TestName { get; set; } = "";
    public bool Passed { get; set; }
    public string Message { get; set; } = "";
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
