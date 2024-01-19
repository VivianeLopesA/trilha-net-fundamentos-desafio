using DesafioFundamentos.Models;

namespace DesafioFundamentos.Tests;

public class EstacionamentoTests
{

    private Estacionamento es = new Estacionamento(5, 2);

    [Fact]
    public void AdicionarVeiculoPlacaAABB11()
    {   


        bool resultado = es.AdicionarVeiculoTestes("AABB11");

        Assert.True(resultado);
    }

    [Fact]
    public void NaoAdicionarVeiculoPlacaVazia()
    {   

        bool resultado = es.AdicionarVeiculoTestes("");

        Assert.False(resultado);
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
    public void ProcurarPlacaAABB11(){

        es.AdicionarVeiculoTestes("AABB11");
        string placaProcurada = "AABB11";
        string resultado = es.procurarVeiculos(placaProcurada);

        Assert.Equal(placaProcurada, resultado);
    }

}