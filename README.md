# Coletânea de Atividades - DOO
*Tarefas desenvolvidas durante a disciplina:*

## **calculadora-solid** 
Aplique o padrão SOLID em uma Calculadora .NET simples;

## **integraçao-json-xml** 
Implementar uma solução em C# que leia os dados fornecidos pelo web service "Escola" em formato JSON, processe essas informações e as salve em um ou mais arquivos XML. Além disso, é necessário aplicar os seguintes padrões de projeto criativos na implementação: Método Fábrica (Factory Method), Fábrica Abstrata (Abstract Factory), Singleton e Prototype.

[Enunciado completo aqui.](https://chatgpt.com/share/67123016-7e88-800e-8ec0-f9324d7127e4)

## **structural-patterns** 
### 1. Padrão Adapter (Adaptador)

**Exercício:**
Você está desenvolvendo um aplicativo que lê dados de sensores de temperatura de diferentes fabricantes. Cada fabricante fornece uma API diferente para obter a temperatura:

- **SensorA**: Método GetTemperatureInCelsius().
- **SensorB**: Método ObtenerTemperaturaEnCentigrados().
- **SensorC**: Método FetchTempC().

Seu objetivo é criar um sistema que possa ler a temperatura de qualquer sensor usando uma interface comum. Use o padrão Adapter para unificar as diferentes APIs sob uma única interface chamada ITemperatureSensor com o método ReadTemperature(), que retorna a temperatura em Celsius.

**Tarefas:**

- Defina a interface ITemperatureSensor com o método ReadTemperature().
- Crie adaptadores para cada sensor (SensorAAdapter, SensorBAdapter, SensorCAdapter) que implementam ITemperatureSensor.
- Demonstre como seu sistema pode ler a temperatura de diferentes sensores de forma unificada.

### s2. Padrão Bridge (Ponte)

****Exercício:****
Imagine que você está criando uma aplicação de desenho gráfico que suporta diferentes formas (círculo, quadrado) e diferentes cores (vermelho, azul). Você quer ser capaz de combinar qualquer forma com qualquer cor sem criar classes para cada combinação possível.

Use o padrão Bridge para separar as formas das cores.

**Tarefas:**

- Defina uma interface IColor com um método ApplyColor().
- Implemente as cores concretas (RedColor, BlueColor) que implementam IColor.
- Crie uma classe abstrata Shape que tem um objeto IColor.
- Implemente formas concretas (Circle, Square) que derivam de Shape.
- Demonstre como você pode criar diferentes combinações de formas e cores.

## 3. Padrão Composite (Composto)

**Exercício:**

Você está desenvolvendo um sistema de gerenciamento de menu para um restaurante. O menu pode conter itens individuais (como um prato) ou submenus (como um conjunto de pratos especiais).

Use o padrão Composite para representar o menu como uma estrutura de árvore onde itens e submenus podem ser tratados de forma uniforme.

**Tarefas:**

- Defina uma interface IMenuComponent com métodos como Display() e Add().
- Implemente a classe MenuItem que representa itens individuais do menu.
- Implemente a classe Menu que pode conter múltiplos IMenuComponent.
- Demonstre como montar um menu completo com itens e submenus e exibi-lo.

## 4. Padrão Decorator (Decorador)

****Exercício:****
Você está criando um sistema de notificações que pode enviar mensagens via e-mail, SMS e/ou push notifications. Você quer permitir que os usuários escolham múltiplos métodos de notificação.

Use o padrão Decorator para adicionar dinamicamente diferentes tipos de notificações a uma mensagem base.

**Tarefas:**

- Defina uma interface INotification com o método Send(string message).
- Implemente a classe BaseNotification que implementa INotification.
- Crie decoradores como EmailDecorator, SMSDecorator, PushDecorator que também implementam INotification.
- Demonstre como você pode compor notificações para enviar mensagens via múltiplos canais.

## 5. Padrão Facade (Fachada)

**Exercício:**

Você está desenvolvendo um sistema de home theater que envolve múltiplos subsistemas: DVD player, projetor, luzes, sistema de som. Controlar cada componente individualmente é complexo para o usuário.

Use o padrão Facade para criar uma interface simplificada que permita ao usuário iniciar e parar o sistema de home theater com métodos simples como PlayMovie(string movie) e EndMovie().

**Tarefas:**

- Implemente classes para cada subsistema (DvdPlayer, Projector, Lights, SoundSystem).
- Crie a classe HomeTheaterFacade com os métodos PlayMovie(string movie) e EndMovie().
- Demonstre como o usuário pode usar HomeTheaterFacade para controlar todo o sistema de forma simples.

## 6. Padrão Flyweight (Peso-Mosca)

**Exercício:**

Você está desenvolvendo um editor gráfico que precisa renderizar um grande número de objetos similares, como árvores em uma floresta em um jogo.

Use o padrão Flyweight para compartilhar objetos semelhantes (por exemplo, o modelo da árvore) e reduzir o uso de memória.

**Tarefas:**

- Crie uma classe TreeType que contém o estado compartilhado (por exemplo, textura, cor).
- Implemente uma fábrica TreeFactory que gerencia os objetos TreeType.
- Crie a classe Tree que contém o estado extrínseco (por exemplo, posição).
- Demonstre como criar múltiplas instâncias de Tree que compartilham o mesmo TreeType.

## 7. Padrão Proxy

**Exercício:**

Você está desenvolvendo um sistema que carrega imagens de alta resolução. Carregar todas as imagens de uma vez é ineficiente.

Use o padrão Proxy para criar uma imagem proxy que carrega a imagem real somente quando necessário.

**Tarefas:**

- Defina uma interface IImage com o método Display().
- Implemente a classe RealImage que carrega e exibe a imagem real.
- Crie a classe ProxyImage que controla o acesso a RealImage.
- Demonstre como usar ProxyImage para atrasar o carregamento da imagem até que Display() seja chamado.


