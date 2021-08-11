using Builders.Shared.Documents;

namespace Builders.Domain.EntranceTestContext.Documents
{
    public class PalindromeDocument : BaseDocument
    {
        public string Valor { get; private set; }

        public bool EhPalindrome { get; private set; }

        private PalindromeDocument() { }
        public PalindromeDocument(string valor, bool ehPalindrome):this()
        {
            Valor = valor;
            EhPalindrome = ehPalindrome;
        }


    }
}
