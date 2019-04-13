namespace Calculator.TestAutomation
{
    public class CalcWebPage
    {
        public static void GoTo()
        {
            // Using the 'production' website in order to not have to solve SSL issues on localhost:
            Driver.Instance.Navigate().GoToUrl("https://breynisson-simple-calc.azurewebsites.net");
        }

        public static void InsertNumbersToAdd(float firstNumber, float secondNumber)
        {
            // Finds the form elements and inserts the values
            throw new System.NotImplementedException();
        }


        public static void Calculate()
        {
            // Finds the submit ('Calculate') button and initiates the calculation
            throw new System.NotImplementedException();
        }

        public static float Result()
        {
            // Returns the value of the calculation in the label:
            throw new System.NotImplementedException();
        }
    }
}