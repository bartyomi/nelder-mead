// ����������� ������������ ��� �� ����� NelderMead
// ����� ����������� ���������� ������ Ctrl+R, ����� a (�������� Run All)
// ����������� ����� ����� �������� �������, � �������� - ������
using NELDER_MEAD;
using HELPERS;

namespace Tests
{
    [TestClass]
    public class NelderMeadTests
    {
        // ������ ����
        [TestMethod]
        // �������� ������ - �������� �����
        public void NelderMeadResultReturnsCorrectSolution()
        {
            var result = NelderMead.GetResult();
            var solution = result.Solution;
            // �������� ���������� �������
            Assert.AreEqual(1, solution.X);
            Assert.AreEqual(4, solution.Y);
        }

        [TestMethod]
        public void ThisTestWillFail()
        {
            Assert.AreEqual(666, NelderMead.GetResult());
        }
    }
}