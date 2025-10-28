
using BenchmarkDotNet.Running;
namespace Projeto;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        BenchmarkRunner.Run<Objetos>();
    }
}