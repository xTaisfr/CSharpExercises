# ExerciciosCSharp
 
Neste repositório você encontra exercicios básicos de c#.

- **C# e .NET Framework**
  - Namespace: É um container (depósito) para classes.
  - Assembly: A single unit of deploymente of .NET application. É um arquivo, na forma de um executável ou DLL, que contém um ou mais namespaces e classes. 
  - CLR (Common Language Runtime): É uma aplicação, em memória, que traduz o IL Code (Intermediate Language) em código de máquina.
  - Compilação JIT (Just-In-Time): É o processo de compilação de código de linguagem intermediaria (equivalente ao assembly) em código nativo (Instruções de CPU).

![image](https://user-images.githubusercontent.com/100882291/196008592-d7dd499c-36ea-466c-a1fc-6a555291aa8a.png)

- **Tipos primitivos e expressões**
  - O compilador do C# checa se os valores atribuídos a variáveis são validos com base nos seus tipos. Ex.:  
  
        //Não é compilado.
        byte number = 1000;
       
  - O tipo long equivale a int64 no .NET Framework.
  - A instrução abaixo gera overflow e o resultado no console será 1:
  
        byte number = 255; 
        number += 2; 
        Console.WriteLine(number);
        
  - Não compila pois pode ocorrer perda de dados durante a conversão.
  
        int number1 = 257; 
        byte number2 = number1; 
        
- **Tipos não primitivos**
  - Declaração array:
        
        int[] numbers = new int[3];
        int[] impares = new int[] { 1, 3, 5, 7, 9 };
        
  - Arrays são tipos de referência. Mesmo atribuindo um array a outra variável de array estaremos modificando a original, pois estamos passando a referência do mesmo objeto em memória. Exemplo:
  
        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;
        Console.WriteLine(array1[0]);
        //Resultado = 0
        
  - Array: O index do primeiro elemento começa em zero.
  - Enums são integers internamente. O valor do primeiro membro de um enum (if not set) é zero.
  
        public enum CustomerType
        {
           Bronze,
           Silver,
           Gold
        }

        //What will be the output of this code?
        var type = (int)CustomerType.Bronze;
        Console.WriteLine(type):   
        
   - Exemplo com o valor setado:
   
         enum ErrorCode : ushort
         {
             None = 0,
             Unknown = 1,
             ConnectionLost = 100,
             OutlierReading = 200
         }

- Arrays e listas
  - Arrays são de tamanho fixo enquanto listas tem tamanho dinâmico (Mais itens podem ser adicionados depois).
  - Exemplo:   
  
          var numbers = new List<int>() { 1, 2, 3, 4, 5 };
          var index = numbers.IndexOf(1);

          Console.WriteLine(index);
          //Resultado = 0
          
   - Acessar o último elemento de uma lista:
            
          list[list.Count - 1]
 
 - Date and Time
   - Data e horário atual:
   
          DateTime.Now; 
   - Operações com data criam uma cópia na memória, exemplo:
   
          var dateTime = new DateTime(2015, 1, 1);
          dateTime.AddYears(1);
          Console.WriteLine(dateTime.Year);
          // Resultado = 2015
          
   - Melhor forma de criar um objeto TimeSpan para representar 1 hora.
   
          TimeSpan.FromHours(1);
      
   - Obter o ano atual:
   
          DateTime.Now.Year;
- Manipulação de texto
  - Strings são imutáveis. Uma vez setadas, não podem ser alteradas. Exemplo:

          var name = "Mosh";
          name[0] = "N";
          Console.WriteLine(name);
          //Resultado: error CS0200: Property or indexer 'string.this[int]' cannot be assigned to -- it is read only
            
  - **StringBuilder** apenas fornece métodos para manipular strings de forma rápida e eficiente. Porém não possui métodos para fazer buscas em strings. Caso precise realizar buscas em uma string em construção usando StringBuilder, é necessário converter para string antes, exemplo:
  
          var builder = new StringBuilder("Mosh");
          var index = builder.ToString().IndexOf('M');
          
- Manipulando arquivos
  - File, FileInfo: Fornecem métodos para criação, cópia, remoção, mover e abrir arquivos.
       - **FileInfo:** Fornece métodos de instância. Recomendado para quando se tem muitas operações. Assim a verificação de segurança é feita somente uma vez, durante a criação da instância.
    - **File:** Fornece métodos estáticos. Recomendado para quando se tem menos operações, como por exemplo pegar atributos de um arquivo, é mais conveniente usar os métodos estáticos. Toda vez que os métodos estáticos são chamados, o sistema operacional realiza verificações de segurança, para garantir que o usuário atual possui acesso ao arquivo. 
  - Métodos úteis:
  
          Create()
          Copy()
          Delete()
          Exists()
          GetAttibutes()
          Move()
          ReadAllText()
          
   - Directory, DirectoryInfo: Classes para trabalhar com diretórios.
     - **DirectoryInfo:** Fornece métodos de instância.
     - **Directory:** Fornece métodos estáticos.

  - Métodos úteis:
  
          CreateDirectory()
          Delete()
          Existis()
          GetCurrentDirectory()
          GetFiles()
          Move()
          GetLogicalDrives()

  - Path: Fornece métodos para trabalhar com strings que contem o caminho do diretório.
  
          GetDirectoryName()
          GetFileName()
          GetExtension()
          GetTempPath()

- Debugging
  -    F9: BreakPoint;
  -    F5: Modo debug; 
  -    Shift F5: stop debug mode;
  -    F10: step over;
  -    F11: step into;
  -    Shift F1: step out;
  -    Debug > Window > Watch (janela que mostra a variavel e seus valores);
  -    Debug > Window > Call Stack (Conferir ordem de execução por numeração da linha);
  -    Debug > Window > Autos (Similar a janela watch porem gera as variaveis inspecionadas automaticamente);


