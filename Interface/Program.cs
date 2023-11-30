using System;

public interface IWorker
{
    void Work();
    void Eat();
}

// Interface for workers who deal with documents
public interface IDocumentWorker
{
    void ReadDocument();
    void WriteDocument();
}

// Interface for workers who deal with reports
public interface IReportingWorker
{
    void GenerateReport();
}

public class DocumentWorker : IWorker, IDocumentWorker
{
    public void Work()
    {
        Console.WriteLine("Working on documents");
    }

    public void Eat()
    {
        Console.WriteLine("Eating lunch");
    }

    public void ReadDocument()
    {
        Console.WriteLine("Reading document");
    }

    public void WriteDocument()
    {
        Console.WriteLine("Writing document");
    }
}


public class ReportingWorker : IWorker, IReportingWorker
{
    public void Work()
    {
        Console.WriteLine("Working on reports");
    }

    public void Eat()
    {
        Console.WriteLine("Eating lunch");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating report");
    }
}

class Program
{
    static void Main()
    {
        // Example

        DocumentWorker documentWorker = new DocumentWorker();
        documentWorker.Work();
        documentWorker.ReadDocument();
        documentWorker.WriteDocument();
        documentWorker.Eat();

        ReportingWorker reportingWorker = new ReportingWorker();
        reportingWorker.Work();
        reportingWorker.GenerateReport();
        reportingWorker.Eat();
    }
}