using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PruebaUnitaria.UnitTest
{
    [TestClass]
    public class TripletesTest
    {
        [TestMethod]
        public void IdentyficarTripletesBasicos()
        {
            var solution = new Solucion();

            Assert.AreEqual(2, solution.FindTriplets(new int[] { 5, 5, 5, 5, 5, 5 }));
        }

        [TestMethod]
        public void IdentyficarTripletesMultiples()
        {
        }
    }
}
