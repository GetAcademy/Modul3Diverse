namespace Modul3Divers
{
    /*
        3-3 Write a bool function that is passed an array and the number of elements in
        that array and determines whether the data in the array is sorted. This should
        require only one pass!     
     */
    internal class Exercise3_3
    {
        public static void Run()
        {
            var exampleNumbers1 = new[] { 1, 2, 3 };
            var exampleNumbers2 = new[] { 1, 3, 2, 4, 9 };
            Console.WriteLine(IsSorted(exampleNumbers1));
            Console.WriteLine(IsSorted(exampleNumbers2));

        }

        private static bool IsSorted(int[] numbers)
        {
            for (var index = 1; index < numbers.Length; index++)
            {
                var previousNumber = numbers[index-1];
                var number = numbers[index];
                if (number < previousNumber) return false;
            }
            return true;
        }

        private static bool IsSortedx(int[] numbers)
        {
            int? previousNumber = null;
            foreach (var number in numbers)
            {
                if (previousNumber != null && number < previousNumber) return false;
                previousNumber = number;
            }
            return true;
        }

        private static bool IsSortedy(int[] numbers)
        {
            var previousNumber = numbers[0];
            foreach (var number in numbers)
            {
                if (number < previousNumber) return false;
                previousNumber = number;
            }
            return true;
        }
    }
}
