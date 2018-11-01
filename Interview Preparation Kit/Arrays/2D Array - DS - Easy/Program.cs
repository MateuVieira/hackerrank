static int hourglassSum(int[][] arr) {

        var value = -1000;

        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                int sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] +
                          arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                Console.WriteLine($"Teste: valor value = {value}, sum = {sum} ");
                if(value < sum)
                {
                    value = sum;
                }
            }
        }
        return value;
    }