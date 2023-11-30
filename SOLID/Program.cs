using System;

                                   // Example of Single Responsibility Principle
// -------------------------------------
// Class: Report
// Responsibilities:
//   - Generate report
//   - Save the report to a file
// -------------------------------------
public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    // Method to generate the report
    public string GenerateReport()
    {
        return $"Report - {Title}\n{Content}"; // It is Example it can be more complex
    }
}

// -------------------------------------
// Class: ReportSaver
// Responsibilities:
//   - Save report to a file
// -------------------------------------
public class ReportSaver
{
    // Method to save the report to a file
    public void SaveToFile(Report report, string filePath)
    {
        // It is Example it can be more complex

        System.IO.File.WriteAllText(filePath, report.GenerateReport());    
        Console.WriteLine($"Report saved to: {filePath}");
    }
}

// -------------------------------------
// Class: ReportProcessor
// Responsibilities:
//   - Process report
// -------------------------------------
public class ReportProcessor
{
    // Method to process the report
    public void ProcessReport(Report report, string filePath)
    {
        Console.WriteLine("Processing report...");
        report.Content = $"Processed: {report.Content}";
        var reportSaver = new ReportSaver();
        reportSaver.SaveToFile(report, filePath);
    }
}

class Program
{
    static void Main()
    {
        // Create report
        var report = new Report
        {
            Title = "Monthly Report",
            Content = "This is the content of the report."
        };

        // Process and save the report
        var reportProcessor = new ReportProcessor();
        reportProcessor.ProcessReport(report, "monthly_report.txt");
    }
}