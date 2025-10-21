using JLM_CEE;

namespace JLM_CEE_Test
{
    [TestClass]
    public sealed class Test
    {
        [DataTestMethod]
        [DataRow(5, 120)]
        [DataRow(3, 6)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        public void CalcularFactorial(int n, long esperado)
        {
            long result = Matematicas.CalcularFactorial(n);
            Assert.AreEqual(esperado, result);
        }
    }

    public sealed class Test2
    {
        [DataTestMethod]
        [DataRow("incorrecto", false)]
        [DataRow("", false)]
        [DataRow(null, false)]
        [DataRow("#correcto", true)]
        public void EsConstrasenyaCorrecta(string input,  bool esperado)
        {
            bool result = Contrasenya.ContrasenyaCorrecta(input);
            Assert.AreEqual(esperado, result);
        }
    }
}
