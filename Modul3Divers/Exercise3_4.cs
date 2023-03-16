namespace Modul3Divers
{
    internal class Exercise3_4
    {
        /*
            3-4 Here’s a variation on the array of const values. Write a program for creating a
            substitution cipher problem. In a substitution cipher problem, all messages
            are made of uppercase letters and punctuation. The original message is called
            the plaintext, and you create the ciphertext by substituting each letter with
            another letter (for example, each C could become an X). For this problem,
            hard-code a const array of 26 char elements for the cipher, and have your
            program read a plaintext message and output the equivalent ciphertext.         
         */
        public static void Run()
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var cipher   = "STUVWIJKLYZÆØÅMNOPQRXABCDEFGH";
            // TERJE
            // RWPYW
            Console.WriteLine(Encrypt("TERJE", alphabet, cipher));
        }

        private static string Encrypt(string plaintext, string alphabet, string cipher)
        {
            var ciphertext = "";
            foreach (var letter in plaintext)
            {
                // 1: finne index til bokstaven i alfabetet
                var index = alphabet.IndexOf(letter);
                // 2: finne bokstav i cipher på samme index
                ciphertext += cipher[index];
            }
            return ciphertext;
        }
    }
}
