// ���� ���� �������� ������ ����� � ����������

using System.Text.Json;

// ���������� ������������ ��� �� ����� NelderMead.cs ��� ������� � ��� �������
using NELDER_MEAD;
using HELPERS;

// ������ ������
var builder = WebApplication.CreateBuilder();
builder.Services.AddCors();
var app = builder.Build();
app.UseCors(builder => builder.AllowAnyOrigin());

// ����� ������� http://localhost:7022

// ��� ������� � http://localhost:7022/ ������� ����� Nelder-Mead
app.MapGet("/", () => "Nelder-Mead");

// ��� ������� � http://localhost:7022/result ������� ��������� ������ ������
// �� ���� ����� ������ ������ ������ ��� ������� �� ������ calculate
app.MapGet("/result", () => {
    // � ���������� ����� ����������� ������������ �������� ��������� ����� �� �������,
    // ��� � ��������� �������
    var initialPoints = new Point[3]{
        new Point(0, 0),
        new Point(1, 0),
        new Point(0, 1)
    };
    var result = new NelderMead(initialPoints).GetResult();
                
    // ������ � ������ ������������ ��������, ��� ��� ����������� ������ � ������
    string jsonString = JsonSerializer.Serialize(result);
    return jsonString;
});

// ��������� ������
app.Run();