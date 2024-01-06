using CalculatorLib;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorOperations.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly Calculator calculator = new Calculator();
        private int firstNumber;
        private int secondNumber;
        private double result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            secondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calculator.Add(firstNumber, secondNumber);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Multiply(firstNumber, secondNumber);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calculator.Subtract(firstNumber, secondNumber);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Divide(firstNumber, secondNumber);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
