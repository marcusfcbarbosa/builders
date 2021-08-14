using Builders.Domain.EntranceTestContext.Commands.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builders.Test.Commands
{
    [TestClass]
    public class CriaPalindromeCommandTest
    {
        private readonly CriaPalindromeCommand _invalidCommand = new CriaPalindromeCommand { Valor = null };
        private readonly CriaPalindromeCommand _validCommand = new CriaPalindromeCommand { Valor = "Deleveled" };
        public CriaPalindromeCommandTest()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        //RED GREEN REFACTOR
        [TestMethod]
        public void DadoCommandoInvalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void DadoCommandovalido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }

    }
}
