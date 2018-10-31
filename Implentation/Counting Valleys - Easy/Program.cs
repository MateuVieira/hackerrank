static int countingValleys(int n, string s) {
        
        int cont = 0;
        int vale = 0;

        foreach (var item in s)
        {
            if(item == 'U')
            {
                if(cont == -1 && cont +1 ==0)
                {
                    vale++;
                }
                cont++;
            }
            else
            {
                cont--;
            }
           // Console.Write( $"Valor item = {item}, cont = {cont} \n ->");
        }
        return vale;
    }