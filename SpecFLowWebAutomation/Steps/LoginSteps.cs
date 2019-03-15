using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFLowWebAutomation.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef


        private Login login = new Login();
        private int result;
        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            login.FirstNumber=number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number2)
        {
            login.SecondNumber = number2;
        }


        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            result=login.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            //TODO: implement assert (verification) logic

            Assert.AreEqual(expectedResult, expectedResult);
        }
    }
}
