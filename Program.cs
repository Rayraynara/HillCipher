// C# code to implement Hill Cipher
using System;

class HC
{

    static void getKeyMatrix(String key, int[,] keyMatrix)
    {
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                keyMatrix[i, j] = (key[k]) % 65;
                k++;
            }
        }
    }

    static void encrypt(int[,] cipherMatrix, int[,] keyMatrix, int[,] messageVector)
    {

    }

    static void HillCipher(String message, String key)
    {

        int[,] keyMatrix = new int[3, 3];
        getKeyMatrix(key, keyMatrix);

        String CipherText = "";

        Console.Write("Ciphertext: " + CipherText + "\n");
    }

    public static void Main(String[] args)
    {
        String message = "RAY";
        String key = "HILLMAGIC";

        HillCipher(message, key);
    }
}