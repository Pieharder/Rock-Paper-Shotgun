using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void CompChoice_ChooseRandomNum_Random()
    {
      //Arrange
      RPShotgun testRPS = new RPShotgun();
      //Act
      int result = testRPS.CompChoice();
      //Assert
      Assert.IsTrue((result > 0) && (result < 4));
    }
  }
}