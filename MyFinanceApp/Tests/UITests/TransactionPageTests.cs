
using Microsoft.Maui.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFinanceApp.Views;

namespace MyFinanceApp.Tests.UITests
{
    [TestClass]
    public class TransactionPageTests
    {
        [TestMethod]
        public void TransactionsPage_ShouldLoad()
        {
            var page = new TransactionsPage();
            Assert.IsNotNull(page);
        }

        [TestMethod]
        public void MainPage_ShouldHaveTitle()
        {
            var page = new TransactionsPage();
            Assert.AreEqual("Transactions", page.Title);
        }
    }
}
