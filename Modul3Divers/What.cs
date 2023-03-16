namespace Modul3Divers
{
    internal class What
    {
        /*
         * 1: Introduce variable
         * 2: Extract method
         * 3: Introduce class
         */
        public static void Run()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                CountCharacters(text, counts);
                ShowCounts(range, counts);
            }
        }

        private static void ShowCounts(int range, int[] counts)
        {
            for (var asciiCode = 0; asciiCode < range; asciiCode++)
            {
                var count = counts[asciiCode];
                if (count > 0)
                {
                    var character = (char) asciiCode;
                    Console.WriteLine(character + " - " + count);
                }
            }
        }

        private static void CountCharacters(string text, int[] counts)
        {
            foreach (var character in text)
            {
                var characterAsciiCode = (int) character;
                counts[characterAsciiCode]++;
            }
        }
    }
}
