namespace CalcLibrary
{
    public class Calculator
    {

        private int result;


        public int Addition(int firstNumber, int secondNumber)
        {
            result = firstNumber + secondNumber;

            return result;
        }


        public int Subtraction(int firstNumber, int secondNumber)
        {
            result = firstNumber - secondNumber;

            return result;
        }


        public int Multiplication(int firstNumber, int secondNumber)
        {
            result = firstNumber * secondNumber;

            return result;
        }



        public int Division(int firstNumber, int secondNumber)
        {

            if (secondNumber == 0)
            {
                throw new ArgumentException("Division by zero");
            }


            result = firstNumber / secondNumber;


            return result;

        }



        public int GetResult
        {
            get
            {
                return result;
            }
        }



        public void AllClear()
        {
            result = 0;
        }

    }
}