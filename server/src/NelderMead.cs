// ����������� ���� �� ��������� �����
using HELPERS;

namespace NELDER_MEAD
{
    // ���� ��� �������� � �������� f(x,y) = x^2+xy+y^2-6x-9y
    // ����� ���������� �������� ���������������� �������


    // ���������, ��� � ���������� ������ ������ �������� ���������� ���������� �������,
    // � ����� ������ �����. ���� ��� �������������� �������� �� ��� �����
    public class NelderMead
    {
        public static List<Point[]> Steps { get; set; } = new List<Point[]>();
        public static Point Solution { get; set; }

        public static Result GetResult()
        {
            // ��������� 2 ���� ������ ���������
            Steps.Add(new Point[] { new Point(1, 2), new Point(3, 4), new Point(5, 6) });
            Steps.Add(new Point[] { new Point(7, 8), new Point(9, 10), new Point(11, 12) });

            // ��������� ��������� �������
            Solution = new Point(1, 4);

            return new Result(Steps, Solution);
        }
    }
}