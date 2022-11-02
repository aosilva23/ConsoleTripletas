using NUnit.Framework;
using SolutionTriplets;
using System.Collections.Generic;


namespace TripletaTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {        
        }

        [Test]
        public void EncontrarTipleta_Encuentra2Triplates_RetornaPass()
        {
            //Arrange
            var solution = new Solution();

            //Act


            //Assert
            Assert.AreEqual(2, solution.FindTriplets(new int[] { 5, 5, 5, 5, 5, 5 }));
          
        }

        [Test]
        public void EncontrarTipleta_Encuentra2TriplatesComplejas_RetornaPass()
        {
            //Arrange
            var solution = new Solution();

            //Act


            //Assert
            Assert.AreEqual(2, solution.FindTriplets(new int[] { 4, 3, 3, 3, 6, 1, 1, 1 }));

        }

        [Test]
        public void EncontrarTipleta_Encuentra5TriplatesComplejas_RetornaPass()
        {
            //Arrange
            var solution = new Solution();

            //Act


            //Assert
            Assert.AreEqual(5, solution.FindTriplets(new int[] { 4, 3, 3, 3, 6, 1, 1, 1, 3, 3, 3, 4, 5, 5, 5, 7, 8, 8, 8 }));

        }


        [Test]
        public void EncontrarTipleta_NoEncuentraTriplates_RetornaFalse()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.FindTriplets(new int[] { 4, 3, 6, 1, 3, 4, 5, 7, 8 });
            var Flag = true;

            if (result == 0)
            {
                Flag = false;
            }

            //Assert
            Assert.IsFalse(Flag); 

        }
    }
}