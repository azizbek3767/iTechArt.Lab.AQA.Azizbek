using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDForCalculatorFunctions.Tests
{
    [Binding]
    public class TestCalculatorSteps
    {
        private Calculator _calculator;

        [Given(@"Calculator class")]
        public void GivenCalculatorClass()
        {
            _calculator= new Calculator();
        }

        [Given(@"I have the first number (.*)")]
        public void GivenIHaveTheFirstNumber(int number)
        {
            _calculator.FirstNumber=number;
        }

        [Given(@"I have the second number (.*)")]
        public void GivenIHaveTheSecondNumber(int number)
        {
            _calculator.SecondNumber=number;
        }

        [When(@"I want to sum those numbers")]
        public void WhenIWantToSumThoseNumbers()
        {
            _calculator.Sum();
        }

        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Result);
        }

        [When(@"I want to subtract those numbers")]
        public void WhenIWantToSubtractThoseNumbers()
        {
            _calculator.Subtract();
        }

        [When(@"I want to multiply those numbers")]
        public void WhenIWantToMultiplyThoseNumbers()
        {
            _calculator.Multiply();
        }

        [When(@"I want to divide those numbers")]
        public void WhenIWantToDivideThoseNumbers()
        {
            _calculator.Divide();
        }
    }
}
