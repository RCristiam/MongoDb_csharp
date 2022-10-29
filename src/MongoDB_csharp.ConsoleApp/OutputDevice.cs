using MongoDB_csharp.Interfaces;

namespace MongoDB_csharp.ConsoleApp;

internal class OutputDevice : IOutputDevice
{
    public OutputDevice()
    {

    }
    
    public void Write(string text)
    {
        Console.WriteLine(text);
    }
}