namespace CoffeeMachineLibrary
{
    public class CoffeeMachine
    {
        public double CoinValue(double firstCoin, double secondCoin, double thirdCoin, double forthCoin)
        {
            double totalMoneyCounterPositive = 0;
            double totalMoneyCounterNegative = 0;

            if (firstCoin >= 0)
            {
                totalMoneyCounterPositive += firstCoin;

            }
            if (secondCoin >= 0)
            {
                totalMoneyCounterPositive += secondCoin;
            }
            if (thirdCoin >= 0)
            {
                totalMoneyCounterPositive += thirdCoin;
            }
            if (forthCoin >= 0)
            {
                totalMoneyCounterPositive += forthCoin;
            }

            if (firstCoin < 0)
            {
                totalMoneyCounterNegative += firstCoin;

            }
            if (secondCoin < 0)
            {
                totalMoneyCounterNegative += Math.Abs(secondCoin);
            }
            if (thirdCoin < 0)
            {
                totalMoneyCounterNegative += Math.Abs(thirdCoin);
            }
            if (forthCoin < 0)
            {
                totalMoneyCounterNegative += Math.Abs(forthCoin);
            }
            return totalMoneyCounterNegative + totalMoneyCounterPositive;
        }

        public string CoinInfo(double firstCoin, double secondCoin, double thirdCoin, double forthCoin)
        {
            double totalMoney = firstCoin + secondCoin + thirdCoin + forthCoin;
            return "The used coin values are " + firstCoin.ToString() + " " + secondCoin.ToString() + " " + thirdCoin.ToString() + " " + forthCoin.ToString()
                + "The total is " + totalMoney;
        }

        public string GetProduct(double firstCoin, double secondCoin, double thirdCoin, double forthCoin, string productLatte, double lattePrice, string productCapuchino,
            double capuchinoPrice, string notEnoughMoney)
        {
            double totalMoney = firstCoin + secondCoin + thirdCoin + forthCoin;
            if (totalMoney >= lattePrice)
            {
                return productLatte;
            }
            else if (totalMoney >= capuchinoPrice)
            {
                return productCapuchino;
            }
            return notEnoughMoney;
        }

        public double GetChange(double firstCoin, double secondCoin, double thirdCoin, double forthCoin, string productLatte, double lattePrice, string productCapuchino,
            double capuchinoPrice)
        {
            double totalMoney = firstCoin + secondCoin + thirdCoin + forthCoin;
            if (totalMoney >= lattePrice)
            {
                return totalMoney - lattePrice;
            }
            else if (totalMoney <= capuchinoPrice)
            {
                throw new ArgumentException();
            }
            return totalMoney - capuchinoPrice;
        }
    }
}
