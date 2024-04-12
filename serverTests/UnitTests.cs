// ����������� ������������ ��� �� ����� NelderMead.cs
// ����� ����������� ���������� ������ Ctrl+R, ����� a (�������� Run All)
// ����������� ����� ����� �������� �������, � �������� - ������
using NELDER_MEAD;
using HELPERS;

namespace Tests
{
    [TestClass]
    public class NelderMeadTests
    {
        public Point[] InitialPoints = new Point[3]{
            new Point(0, 0),
            new Point(1, 0),
            new Point(0, 1)
        };
        // ������ ����
        [TestMethod]
        // �������� ������ - �������� �����
        public void NelderMeadResultReturnsCorrectSolution()
        {
            var result = new NelderMead(InitialPoints).GetResult();
            var solution = result.Solution;
            // �������� ���������� �������
            Assert.AreEqual(1, solution.X);
            Assert.AreEqual(4, solution.Y);
        }

        [TestMethod]
        public void ThisTestWillFail()
        {
            Assert.AreEqual(666, new NelderMead(InitialPoints).GetResult());
        }
    }
}