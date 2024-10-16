//3.მატრიცების შეკრება:
//*შექმენით ორი 3x3 ზე მატრიცა (ორ განზომილებიანი მასივი) 
//* მოხმარებელს შეავსებინეთ მატრიცაში მნიშვნელობები
//* შეკრიბეთ მატრიცები https://en.wikipedia.org/wiki/Matrix_addition


        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] matrixSum = new int[3, 3];


        Console.WriteLine("Enter 9 values for the first 3x3 matrix :");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

   
        Console.WriteLine("Enter 9 values for the second 3x3 matrix :");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

    
        Console.WriteLine("Sum of the two matrices:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrixSum[i, j] + " ");
            }
            Console.WriteLine(); 
        }
