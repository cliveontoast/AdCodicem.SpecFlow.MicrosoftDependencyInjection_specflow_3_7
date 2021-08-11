using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsInjectionSite31;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int first;
        private int second;
        private int result;
        private readonly ValuesController valuesController;

        public CalculatorStepDefinitions(
            ValuesController valuesController)
        {
            this.valuesController = valuesController;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            first = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            second = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = valuesController.AddNumbers(first, second);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, this.result);
        }
    }
}
