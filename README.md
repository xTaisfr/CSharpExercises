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
