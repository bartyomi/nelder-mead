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
        public List<Point[]> Steps { get; set; } = new List<Point[]>();
        public Point? Solution { get; set; }
        public Point[] InitialPoints { get; set; }

        public NelderMead(Point[] initialPoints)
        {
            InitialPoints = initialPoints;
        }

        public Result GetResult()
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