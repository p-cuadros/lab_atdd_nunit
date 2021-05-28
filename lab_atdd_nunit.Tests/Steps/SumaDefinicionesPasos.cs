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
        private int _numeroUno { get; set; }
        private int _numeroDos { get; set; }
        private int _resultado { get; set; }
        private string _error { get; set; }
        private bool _es_error { get; set; } = false;
        
        public SumaDefinicionesPasos(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _calculadora = new Calculadora();
        }

        [Given("los numeros (.*) y (.*)")]
        public void DadoDosNumeros(int number1, int number2)
        {
            try
            {
                _numeroUno = number1;
                _numeroDos = number2;
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }            
        }

        [When("yo sumo")]
        public void CuandoYoSumo()
        {
            try
            {
                _resultado = _calculadora.Suma(_numeroUno, _numeroDos);
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }
        }

        [Then("el resultado deberia ser (.*)")]
        public void EntoncesElResultadoDeberiaSer(int resultado)
        {
            Assert.AreEqual(_resultado, resultado);
        }        

        [Then("deberia ser error")]
        public void EntoncesDeberiaMostrarseError()
        {
            Assert.IsTrue(_es_error);
        }

        [Then("deberia mostrarse el error: (.*)")]
        public void EntoncesDeberiaMostrarseError(string error)
        {
            Assert.AreEqual(_error, error);
        }
    }
}