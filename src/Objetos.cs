using BenchmarkDotNet.Attributes;

namespace Projeto;

public class Objetos
{
    [Benchmark]
    public object CriarObject()
    {
        var objeto = new Object();
        return objeto;
    }
    
    [Benchmark]
    public object CriarObjetoAnonimo()
    {
        var objeto = new {};
        return objeto;
    }

    [Benchmark]
    public object CriarObjetoAnonimoComCampo()
    {
        var objeto = new { idade = 0 };
        return objeto;
    }
}