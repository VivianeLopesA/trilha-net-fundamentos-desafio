using DesafioFundamentos.Models;

namespace DesafioFundamentos.Tests;

public class EstacionamentoTests
{

    private Estacionamento es = new Estacionamento(5, 2);

    [Fact]
    public void AdicionarVeiculoPlacaAABB11()
    {   

        
        string resultado = es.AdicionarVeiculoTestes("AABB11");

        string resultadoEsperado = "AABB11";

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void NaoAdicionarVeiculoPlacaVazia()
    {   

        string resultado = es.AdicionarVeiculoTestes("");

        string resultadoEsperado = "Erro no teste";

        Assert.Equal(resultadoEsperado, resultado);
    }

    
    [Fact]
    public void RetirarVazioDePlacaAAgg22()
    {   
      
        es.AdicionarVeiculoTestes("  AA gg 22      ");
        string placaSemEspaco = "AAgg22";

        string resultado = es.procurarVeiculos(placaSemEspaco);
        
        Assert.Equal(placaSemEspaco, resultado);
    }

    [Fact]
    public void RemoverVeiculoRRFF47Com2HorasEstacionado(){

        es.AdicionarVeiculoTestes("RRFF47");
        string esperado = $"{"RRFF47"} : {9}";

        string resultado = es.RemoverVeiculoTestes("RRFF47", "2");


        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void NaoRemoverPlacaNaoCadastradaRR55EE()
    {
        // Given
        string placaNaoCadastrada = "RR55EE";
    
        // When
        string resultado = es.RemoverVeiculoTestes(placaNaoCadastrada, "5");
        // Then

        Assert.Equal("Erro no teste", resultado);
        
    }

    [Fact]
    public void ListarTodosVeiculosCadastrados()
    {
        
        es.AdicionarVeiculoTestes("25ggAA");
        es.AdicionarVeiculoTestes("96REgg");
        es.AdicionarVeiculoTestes("LL26ww");


        List<string> resultado = es.ListarVeiculosTestes();
        List<string> resultadoEsperado = ["25ggAA", "96REgg" , "LL26ww"];


        Assert.Equal(resultadoEsperado, resultado);


    }

    [Fact]
    public void ProcurarPlacaAABB11(){

        es.AdicionarVeiculoTestes("AABB11");
        string placaProcurada = "AABB11";

        string resultado = es.procurarVeiculos(placaProcurada);

        Assert.Equal(placaProcurada, resultado);
    }



}