
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFinanceApp.Models;
using MyFinanceApp.Services;
using System.Threading.Tasks;

namespace MyFinanceApp.Tests.UnitTests
{
    [TestClass]
    public class DatabaseTests
    {
        private ILocalDatabase _db;

        [TestInitialize]
        public async Task Setup()
        {
            _db = new SqliteLocalDatabase();
            await _db.InitializeAsync();
        }

        [TestMethod]
        public async Task AddTransaction_ShouldIncreaseCount()
        {
            var initial = await _db.GetTransactionsAsync();
            int countBefore = initial.Count;

            var txn = new Transaction { Title = "Test", Amount = 100, Category = "Food" };
            await _db.AddTransactionAsync(txn);

            var after = await _db.GetTransactionsAsync();
            Assert.AreEqual(countBefore + 1, after.Count);
        }

        [TestMethod]
        public async Task DeleteTransaction_ShouldDecreaseCount()
        {
            var txn = new Transaction { Title = "DeleteMe", Amount = 50, Category = "Transport" };
            await _db.AddTransactionAsync(txn);

            var initial = await _db.GetTransactionsAsync();
            await _db.DeleteTransactionAsync(txn.Id);

            var after = await _db.GetTransactionsAsync();
            Assert.AreEqual(initial.Count - 1, after.Count);
        }
    }
}
