namespace bakeryApp
{
    public class Bread
    {
        public int Loaves {get; set;}

        public static int loavesCalc(int numberOfLoaves)
        {
            //Buy 2 get 1 free. Every 3rd bread is free
            //Cost of each 5$
            int numberOfLoaves = int.Parse(Console.ReadLine());
            int costPerLoaf = 5;
            int numberOfFreeLoaves = (int)Math.Floor((int)numberOfFreeLoaves / 3);
            int totalCostBread = (numberOfLoaves - numberOfFreeLoaves) * costPerLoaf;

            return totalCostBread;
        }
    }
    public class Pastry
    {
        public int Pastries { get; set;}

        public static int pastriesCost(int numberOfPastries)
        {
            int sub3past = (numberOfPastries % 3);
            int pastry3Calc = sub3past * 5;
            int pastry1Calc = (numberOfPastries - (3 * sub3past)) * 2;

            int totalPastCost = pastry3Calc + pastry1Calc;

            return totalPastCost; 
            //Buy 1 for 2$ or 3 for 5$
        }
    }
}