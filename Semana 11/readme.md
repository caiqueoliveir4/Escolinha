# Exercícios

1) No projeto da semana semana anterior (10), incrementar a API para expor o modelo **Estrela** do mesmo modo que foi realizado para o modelo **Sistema** (criar **EstrelaService**, **EstrelaController**). Mantenha a aplicação em exceução enquanto realiza as tarefas seguintes.
Cada vez que esta aplicação é reiniciada os dados previamente cadastrados são eliminados.

2) No projeto desta semana, alterar os trechos destacados nos arquivos **EstrelaService.cs** e **SistemaService.cs** para realizar chamadas à API do projeto anterior, de modo que o resultado da execução seja o seguinte:

```
  > Listando Sistemas
  Nenhum sistema cadastrado
  > Adicionando Sistemas
  > Listando Sistemas
  - Código: 1 Nome: Sistema Solar
  - Código: 2 Nome: Alpha Centauri
  - Código: 3 Nome: Sirius
  > Listando Estrelas
  Nenhuma estrela cadastrada
  > Adicionando Estrelas
  > Listando Estrelas
  - Código: 1 Nome: 'Sol' Sistema: 'Sistema Solar' Classificação: G2V Magnitude Absoluta: 4,85 Distância: 0 anos-luz
  - Código: 2 Nome: 'Proxima Centauri' Sistema: 'Alpha Centauri' Classificação: M5.5Ve Magnitude Absoluta: 15,53 Distância: 4,2421 anos-luz
  - Código: 3 Nome: 'a Centauri A' Sistema: 'Alpha Centauri' Classificação: G2V Magnitude Absoluta: 4,38 Distância: 4,365 anos-luz
  - Código: 4 Nome: 'a Centauri B' Sistema: 'Alpha Centauri' Classificação: K1V Magnitude Absoluta: 5,71 Distância: 4,365 anos-luz
  - Código: 5 Nome: 'Sirius A' Sistema: 'Sirius' Classificação: A1V Magnitude Absoluta: 1,42 Distância: 8,5828 anos-luz
  - Código: 6 Nome: 'Sirius B' Sistema: 'Sirius' Classificação: DA2 Magnitude Absoluta: 11,34 Distância: 8,5828 anos-luz
```

3) Observe através da Swagger UI (http://localhost:5204/swagger/index.html) como as chamadas realizadas no exercício 2 alteraram os dados cadastrados.


# Referências

#### Chamar uma API Web de um cliente .NET
- https://docs.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

#### HttpClient Classe
- https://docs.microsoft.com/pt-br/dotnet/api/system.net.http.httpclient?view=net-6.0

#### Usage of EnsureSuccessStatusCode and handling of HttpRequestException
- https://stackoverflow.com/questions/21097730/usage-of-ensuresuccessstatuscode-and-handling-of-httprequestexception-it-throws

#### NET 5 - Explorando o namespace System.Net.Http.Json
- https://www.macoratti.net/21/01/net5_httpjson1.htm

#### Consume Web API in .NET using HttpClient
- https://www.tutorialsteacher.com/webapi/consuming-web-api-in-dotnet-using-httpclient

#### Lista de estrelas próximas
- https://pt.wikipedia.org/wiki/Lista_de_estrelas_pr%C3%B3ximas