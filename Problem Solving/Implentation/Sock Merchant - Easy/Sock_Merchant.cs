 static int sockMerchant(int n, int[] ar) {
        int cont = 0;
        var aux = ar.GroupBy(a = a)
                    .Select(b = new{ Color= b.Key, Count = b.Count() });
                    

        foreach ( var item in aux)
        {
            Console.WriteLine(item);
            
                if(item.Count == 2)
                {
                    cont++;
                }
                else if( item.Count  2)
                {
                    Console.WriteLine($Teste Recursão item = {item});
                    cont = conta(item.Count, cont);
                    Console.WriteLine($Teste Recursão saida cont = {cont} n);
                }
        }

        return cont;
    }

    static int conta(int valor, int cont){

            Console.WriteLine($Endrada funcção de recursão, valores valor = {valor}, cont = {cont} nn );
        if( valor = 2)
        {
             Console.WriteLine($   IF -- cont = {cont}, valor = {valor});
            valor -= 2;
            cont++;
            cont = conta(valor, cont);
        }
        else
        {   
            Console.WriteLine($   ELSE -- cont = {cont}, valor = {valor});
            return cont;
        }

        Console.WriteLine($   Fora IF -- cont = {cont}, valor = {valor});
        return cont;
    }
