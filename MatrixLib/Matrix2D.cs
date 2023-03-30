namespace MatrixLib
{
    public class Matrix2D
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }   

        public Matrix2D():this(1, 0, 0, 1) { }
    }
}