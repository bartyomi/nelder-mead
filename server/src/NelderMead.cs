// ����������� ���� �� ��������� �����
using HELPERS;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NELDER_MEAD {
    // ���� ��� �������� � �������� f(x,y) = x^2+xy+y^2-6x-9y
    // ����� ���������� �������� ���������������� �������

    // ���������, ��� � ���������� ������ ������ �������� ���������� ���������� �������,
    // � ����� ������ �����. ���� ��� �������������� �������� �� ��� �����
    public class NelderMead {
        public List<Simplex> Steps { get; set; } = new List<Simplex>();
        public Point? Solution { get; set; }
        public Simplex InitialPoints { get; set; }

        public NelderMead(Simplex initialPoints) {
            InitialPoints = initialPoints;
            Steps.Add((Simplex)InitialPoints.Clone());
        }

        public Result GetResult() {
            int Count = 10;
            int uselessSteps = 0;
            Simplex step = InitialPoints;

            while (Count > 0 && uselessSteps < 3) {
                Point xReflection = step.Reflection();
                if (xReflection.f() < step.Good.f()) {
                    Point xExpansion = step.Expansion();
                    if (xExpansion.f() < step.Best.f()) step.Worst = xExpansion;
                    else step.Worst = xReflection;
                }
                else {
                    Point xContract = step.Contract();
                    if (xContract.f() < step.Good.f()) step.Worst = xContract;
                    else {
                        step.Shrink();
                        uselessSteps++;
                    }
                }
                step.Sort();
                Steps.Add((Simplex)step.Clone());
                Count--;
            }
            Solution = Steps.Last().Best;
            return new Result(Steps, Solution);
        }
    }
}