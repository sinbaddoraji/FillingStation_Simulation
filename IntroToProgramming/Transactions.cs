namespace IntroToProgramming
{
    internal static class Transactions
    {
        //Money liters sold equqate to using rate below
        //£1.35 per litre for diseal
        //£1.31 per litre for unleaded
        //£1.33 per litre for LPG
        public static double TotalMoneyFromTransactions => MoneyFromDiesel + MoneyFromUnleaded + MoneyFromLpg;

        //Specific Transaction money details
        public static double MoneyFromDiesel => DieselFuelDispenced * 1.35;

        public static double MoneyFromUnleaded => UnleadedFuelDispenced * 1.31;
        public static double MoneyFromLpg => LpgFuelDispenced * 1.33;

        // Total commision for fuel attendant
        //MoneyFromTransactions * 1%
        public static double TotalCommison => TotalMoneyFromTransactions * 0.01;

        public static int TotalNumberOfVehiclesCreated = 0;
        public static int VehiclesServiced = 0;

        //Variables to monitor fuel dispensed counter
        public static double TotalFuelDispensed => UnleadedFuelDispenced + DieselFuelDispenced + LpgFuelDispenced;

        public static double UnleadedFuelDispenced = 0;
        public static double DieselFuelDispenced = 0;
        public static double LpgFuelDispenced = 0;

        public static int VehiclesNotServiced => TotalNumberOfVehiclesCreated - VehiclesServiced;

        //List of all transactions
        public static string TransactionLog = "";
    }
}