using TestesUnitarios.Desafio.Console.Services; 
using System; 

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesString
{
    // ...

    public bool ContemTexto(string texto, string textoProcurado)
    {
        return texto.Contains(textoProcurado);
    }

    public bool TextoTerminaCom(string texto, string textoProcurado)
    {
        return texto.EndsWith(textoProcurado);
    }
}


















public class ValidacoesStringTests
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
{
    // Arrange
    var texto = "Matrix";
    var resultadoEsperado = 6;

    // Act
    var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

    // Assert
    Assert.Equal(resultadoEsperado, resultado);
}

[Fact]
public void DeveContemAPalavraQualquerNoTexto()
{
    // Arrange
    var texto = "Esse é um texto qualquer";
    var textoProcurado = "qualquer";

    // Act
    var resultado = _validacoes.ContemTexto(texto, textoProcurado);

    // Assert
    Assert.True(resultado);
}

[Fact]
public void NaoDeveConterAPalavraTesteNoTexto()
{
    // Arrange
    var texto = "Esse é um texto qualquer";
    var textoProcurado = "teste";

    // Act
    var resultado = _validacoes.ContemTexto(texto, textoProcurado);

    // Assert
    Assert.False(resultado);
}

[Fact]
public void TextoDeveTerminarComAPalavraProcurado()
{
    // Arrange
    var texto = "Começo, meio e fim do texto procurado";
    var textoProcurado = "procurado";

    // Act
    var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

    // Assert
    Assert.True(resultado);
}
