using MatrixLib;

namespace MatrixUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_SetsDefaultValues()
        {
            var matrix = new Matrix2D();

            Assert.AreEqual(matrix.A, 1);
            Assert.AreEqual(matrix.B, 0);
            Assert.AreEqual(matrix.C, 0);
            Assert.AreEqual(matrix.D, 1);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4)]
        [DataRow(-1, -10, -20, 42)]
        [DataRow(11, 0, -2, 12)]
        [DataRow(2, 3, 56, 2)]
        public void Constructor_SetsValues (int a, int b, int c, int d)
        {
            var matrix = new Matrix2D(a, b, c, d);

            Assert.AreEqual(matrix.A, a);
            Assert.AreEqual(matrix.B, b);
            Assert.AreEqual(matrix.C, c);
            Assert.AreEqual(matrix.D, d);
        }
    }
}