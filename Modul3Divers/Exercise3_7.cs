namespace Modul3Divers
{
    internal class Exercise3_7
    {
        /*
            3-7 Write a program that is given an array of integers and determines the mode,
            which is the number that appears most frequently in the array.     
        
            Pause 13:34
         */
        public static void Run()
        {
            var numbers = new int[] {1, 2, 3, 4, 4, 4, 5, 5, 6, 7, 8, 10, 12, 13, 13};
            var mode = GetMode(numbers);
            Console.WriteLine(mode);
        }

        private static int GetMode(int[] numbers)
        {
            var frequencyTable = GetFrequencyTable(numbers);
            //for (var number = 0; number < frequencyTable.Length; number++)
            //{
            //    var frequency = frequencyTable[number];
            //    Console.WriteLine($"frequencyTable[{number}]={frequency}");
            //}
            /*
                frequencyTable[0]=0
                frequencyTable[1]=1
                frequencyTable[2]=1
                frequencyTable[3]=1
                frequencyTable[4]=3
                frequencyTable[5]=2
                frequencyTable[6]=1
                frequencyTable[7]=1
                frequencyTable[8]=1
                frequencyTable[9]=0
                frequencyTable[10]=1
                frequencyTable[11]=0
                frequencyTable[12]=1
                frequencyTable[13]=2
             */
            var maxNumber = numbers[0];
            var maxFrequency = 0;
            for (var number = 0; number < frequencyTable.Length; number++)
            {
                var frequency = frequencyTable[number];
                if (frequency > maxFrequency)
                {
                    maxNumber = number;
                    maxFrequency = frequency;
                }
            }
            return maxNumber;
        }

        private static int[] GetFrequencyTable(int[] numbers)
        {
            var frequencyTable = new int[14];
            foreach (var number in numbers)
            {
                frequencyTable[number]++;
            }
            return frequencyTable;
        }
    }
}
