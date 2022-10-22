// C# code to implement Hill Cipher
using System;

class HC
{

    
    static void getKeyMatrix(String key,  int[,] keyMatrix)
    {
        
    }

    static void encrypt()
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

