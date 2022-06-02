# Exercícios

Analisar todo o projeto para entendimento dos **models**, **services** e **controllers** disponíveis e suas relações. Em seguida, alterar os trechos destacados no arquivo **SistemaController.cs** para satisfazer os seguintes requisitos.

1) Método **Listar** será acionado por requisições **GET** sem parâmetros.
Seu resultado deve ser uma lista dos sistemas cadastrados no **EstrelasContext**, disponível através do **SistemaService**.

2) Método **Pesquisar** será acionado por requisições **GET** com o parâmetro codigo.
Pesquisar pelo sistema já cadastrado, considerando o código informado.
Se nenhum sistema for encontrado o código de resposta deve ser **HTTP 404 - Not Found**.
Se um sistema for encontrado o código de resposta deve ser **HTTP 200 - OK**, com os dados do sistema no corpo da resposta.

3) Método **Incluir** será acionado por requisições **POST** sem parâmetros.
Incluir um novo sistema no **EstrelasContext**, através do **SistemaService**.
Se o sistema for cadastrado com sucesso, o código da resposta deve ser **HTTP 204 - No Content**.
Se o sistema não for cadastrado, uma exceção será lançada. Realizar tratamento de exceção, utilizar o código da resposta **HTTP 400 - Bad Request** e informar a mensagem da exceção no corpo da resposta.

4) Embora requisições HTTP possam ser formuladas, organizadas e enviadas por ferramentas como Postman, Insomnia e outras, também é possível utilizar a Swagger UI acoplada à nossa solução.
Execute com sucesso a API e acesse o endereço http://localhost:5204/swagger/index.html 

Realizar requisição à GET /Sistemas e obter o seguinte resultado

```
[]
```

Realizar as seguintes requisições à POST /Sistemas

```
{
  "codigo": 1,
  "nome": "Sistema Solar"
}
```

```
{
  "codigo": 2,
  "nome": "Alpha Centauri"
}
```

```
{
  "codigo": 3,
  "nome": "Sirius"
}
```

Repetir requisição à GET /Sistemas e obter o seguinte resultado

```
[
  {
    "codigo": 1,
    "nome": "Sistema Solar"
  },
  {
    "codigo": 2,
    "nome": "Alpha Centauri"
  },
  {
    "codigo": 3,
    "nome": "Sirius"
  }
]
```

Realizar nova requisição à POST /Sistemas

```
{
  "codigo": 3,
  "nome": "Gerar erro"
}
```

A resposta à requisição acima dave ser HTTP 400 "An item with the same key has already been added. Key: 3"

Realizar requisição à GET /Sistemas/3 e obter o seguinte resultado:

```
{
  "codigo": 3,
  "nome": "Sirius"
}
```

Realizar requisição à GET /Sistemas/4 e obter a resposta HTTP 404.

# Referências

#### Protocolo HTTP
- https://developer.mozilla.org/pt-BR/docs/Web/HTTP (Geral)
- https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Headers (Cabeçalhos)
- https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Methods (Métodos/Verbos)
- https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status (Códigos de resposta)

#### APIs
- https://www.redhat.com/pt-br/topics/api/what-are-application-programming-interfaces
- https://www.redhat.com/pt-br/topics/api/what-is-api-design
- https://www.youtube.com/watch?v=qZ8QVCYmecA
- https://www.youtube.com/watch?v=vN9NRqv7xmY <<< Imperdível

#### REST
- https://blog.betrybe.com/desenvolvimento-web/api-rest-tudo-sobre/
- https://www.restapitutorial.com/lessons/whatisrest.html
- https://www.restapitutorial.com/lessons/restquicktips.html
- https://www.restapitutorial.com/lessons/httpmethods.html
- https://www.restapitutorial.com/lessons/restfulresourcenaming.html
- https://www.ics.uci.edu/~fielding/pubs/dissertation/rest_arch_style.htm

#### JSON
- https://www.json.org/json-pt.html
- https://www.w3schools.com/js/js_json_intro.asp (Introdução)
- https://www.w3schools.com/js/js_json_datatypes.asp (Tipos de dados)
- https://www.w3schools.com/js/js_json_objects.asp (Objetos)
- https://www.w3schools.com/js/js_json_arrays.asp (Arrays)

#### OpenAPI e Swagger
- https://www.infoq.com/br/articles/openapi/
- http://www2.decom.ufop.br/terralab/documentando-sua-api-rest-com-swagger/
- https://github.com/domaindrivendev/Swashbuckle.WebApi (Biblioteca em C#)

#### Curso - Criar uma API Web com os controladores do ASP.NET Core
- https://docs.microsoft.com/pt-br/learn/modules/build-web-api-aspnet-core/

#### Lista de estrelas próximas
- https://pt.wikipedia.org/wiki/Lista_de_estrelas_pr%C3%B3ximas