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

        [TestMethod]
        public void StaticProperty_Zero()
        {
            var matrix = Matrix2D.Zero;
            Assert.AreEqual(matrix.A, 0);
            Assert.AreEqual(matrix.B, 0);
            Assert.AreEqual(matrix.C, 0);
            Assert.AreEqual(matrix.D, 0);
        }

        [TestMethod]
        public void StaticProperty_Id()
        {
            var matrix = Matrix2D.Id;

            Assert.AreEqual(matrix.A, 1);
            Assert.AreEqual(matrix.B, 0);
            Assert.AreEqual(matrix.C, 0);
            Assert.AreEqual(matrix.D, 1);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, "[[1, 2], [3, 4]]")]
        [DataRow(20, 18, -2, -5, "[[20, 18], [-2, -5]]")]
        [DataRow(13, 2, -7, -10, "[[13, 2], [-7, -10]]")]
        [DataRow(0, 0, 2, 10, "[[0, 0], [2, 10]]")]
        public void Method_ToString(int a, int b, int c, int d, string expectedText)
        {
            var matrix = new Matrix2D(a, b, c, d);

            Assert.AreEqual(matrix.ToString(), expectedText);   
        }
    }
}