namespace BDDForCalculatorFunctions
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int Result { get; set; }

        public void Sum()
        {
            Result = FirstNumber + SecondNumber;
        }
        public void Subtract()
        {
            Result = FirstNumber - SecondNumber;
        }
        public void Multiply()
        {
            Result = FirstNumber * SecondNumber;
        }
        public void Divide()
        {
            Result = FirstNumber / SecondNumber;
        }
    }
}
