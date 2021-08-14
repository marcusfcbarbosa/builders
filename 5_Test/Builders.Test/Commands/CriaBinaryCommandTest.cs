using Builders.Domain.EntranceTestContext.Commands.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Builders.Test.Commands
{
    [TestClass]
    public class CriaBinaryCommandTest
    {
        List<Request> invalidList = new List<Request>();
        private readonly Request _invalidrequest1 = new Request { node = 1, Value = 2, Left = null, Right = null };
        private readonly Request _invalidrequest2 = new Request { node = 2, Value = 1, Left = "1", Right = "3" };
        private readonly Request _invalidrequest3 = new Request { node = 3, Value = 3, Left = "2", Right = null };
        private readonly CriaBinaryCommand _invalidCommand;

        List<Request> validList = new List<Request>();
        private readonly Request _validrequest1 = new Request { node = 1, Value = 1, Left = null, Right = null };
        private readonly Request _validrequest2 = new Request { node = 2, Value = 2, Left = "1", Right = "3" };
        private readonly Request _validrequest3 = new Request { node = 3, Value = 3, Left = "2", Right = null };

        private readonly CriaBinaryCommand _validCommand;
        public CriaBinaryCommandTest()
        {
            invalidList.Add(_invalidrequest1);
            invalidList.Add(_invalidrequest2);
            invalidList.Add(_invalidrequest3);
            _invalidCommand = new CriaBinaryCommand(invalidList.OrderBy(x=>x.node));
            _invalidCommand.Validate();

            validList.Add(_validrequest1);
            validList.Add(_validrequest2);
            validList.Add(_validrequest3);
            _validCommand = new CriaBinaryCommand(validList.OrderBy(x => x.node));
            _validCommand.Validate();

        }

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