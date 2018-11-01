static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        int valor = 0;
        for(int i = 0; i < keyboards.Length; i++)
        {
            for(int j = 0; j < drives.Length; j++)
            {
                int aux = keyboards[i] + drives[j];
                if( ( aux <= b) &&  aux > valor )
                {
                    valor = aux;
                }
            }
        }
       
       return valor != 0 ? valor : -1 ;
    }