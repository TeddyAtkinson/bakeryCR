namespace bakeryApp
{
    public class Bread
    {
        public int Loaves {get; set;}

        public static int loavesCalc(int numberOfLoaves)
        {
            //Buy 2 get 1 free. Every 3rd bread is free
            //Cost of each 5$

            int costPerLoaf = 5;

            int numberOfFreeLoaves = (int)Math.Floor((int)numberOfFreeLoaves / 3);

            int totalCost = (numberOfLoaves - numberOfFreeLoaves) * costPerLoaf;

            return totalCost;
        }
    }
    public class Pastry
    {
        public int Pastries { get; set;}

        public static int pastriesCost()
        {
            //Buy 1 for 2$ or 3 for 5$
        }
    }
}