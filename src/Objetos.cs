using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Projeto.Models;

namespace Projeto;
// Traz indicadores de memória
[MemoryDiagnoser]

// Ordenação dos resultados
[Orderer(SummaryOrderPolicy.FastestToSlowest)]

[RankColumn]
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

    [Benchmark]
    public Vazia Vazia()
    {
        var objeto = new Vazia();
        return objeto;
    }
    
    [Benchmark]
    public Pessoa Pessoa()
    {
        var objeto = new Pessoa();
        return objeto;
    }
    
    [Benchmark]
    public Empresa EmpresaVazia()
    {
        var objeto = new Empresa();
        return objeto;
    }
    
    [Benchmark]
    public Pessoa PessoaComNome()
    {
        var objeto = new Pessoa(){ Nome = "Pessoa"};
        return objeto;
    }
    
    [Benchmark]
    public object EmpresaComNome()
    {
        var objeto = new Empresa(){ Cnpj = "1234567890", RazaoSocial = "Empresa"};
        return objeto;
    }
    
    [Benchmark]
    public object ObjetoGrandeSemDados()
    {
        var objeto = new ObjetoGrande(){ };
        return objeto;
    }
    
    
}