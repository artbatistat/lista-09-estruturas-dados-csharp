using System.Collections;

Hashtable CPF_Telefone = new Hashtable(); 
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Digite o CPF da pessoa {0}: ",i);
            string CPF = Console.ReadLine();

            Console.Write("Digite o número de telefone da pessoa {0}: ",i);
            string telefone = Console.ReadLine();

            CPF_Telefone[CPF] = telefone;

            Console.WriteLine();
        }
        foreach (DictionaryEntry entry in CPF_Telefone)
        {
            string cpf = (string)entry.Key;
            string telefone = (string)entry.Value;

            Console.WriteLine($"CPF: {cpf}, Telefone: {telefone}");
        }
        Console.ReadLine();