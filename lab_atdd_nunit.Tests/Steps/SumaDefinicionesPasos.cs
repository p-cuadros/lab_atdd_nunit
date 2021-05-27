using NUnit.Framework;
using TechTalk.SpecFlow;
using lab_atdd_nunit.domain;
namespace lab_atdd_nunit.tests.Steps
{
    [Binding]
    public sealed class SumaDefinicionesPasos
    {
        private readonly ScenarioContext _scenarioContext;
        private Calculadora _calculadora { get; set; }
        private int _resultado { get; set; }

        public SumaDefinicionesPasos(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _calculadora = new Calculadora();
        }

        [When("yo sumo (.*) y (.*)")]
        public void CuandoDosNumerosSonSumados(int number1, int number2)
        {
            _resultado = _calculadora.Suma(number1,number2);
        }

        [Then("el resultado deberia ser (.*)")]
        public void EntoncesElResultadoDeberiaSer(int resultado)
        {
            Assert.AreEqual(_resultado, resultado);
        }        
        
    }
}