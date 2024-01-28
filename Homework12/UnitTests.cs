namespace Homework12;

public class Tests
{
    [Test(Description = "�������� ������� ������ ����� �� ����� �����")]
    [Order(1), Severity(Severity.High), Category("Integer"), Category("Positive")]
    [TestCaseSource(typeof(TestData), nameof(TestData.ItegerDivideCases))]
    public void TestDivideIntegersFunction(int firstNum, int secondNum, int result) =>
        Assert.That(Calculator.Divide(firstNum, secondNum), Is.EqualTo(result));

    [Test(Description = "�������� ������� ���� �� ����� �����")]
    [Order(2), Severity(Severity.High), Category("Integer"), Category("Positive")]
    public void TestDivideZeroByIntegersFunction() =>
        Assert.That(Calculator.Divide(0, new Random().Next(-100, 100)), Is.EqualTo(0));

    [Test(Description = "�������� ������� ������ ����� �� ����")]
    [Order(3), Severity(Severity.High), Category("Integer"), Category("Negative")]
    public void TestDivideIntegersByZeroFunction() =>
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(new Random().Next(-100, 100), 0));

    [Test(Description = "�������� ������� ����� c ��������� ������ �� ����� � �������� ������")]
    [Order(4), Severity(Severity.High), Category("Double"), Category("Positive")]
    [TestCaseSource(typeof(TestData), nameof(TestData.DoubleDivideCases))]
    public void TestDivideDoublesFunction(double firstNum, double secondNum, double result) =>
        Assert.That(Calculator.Divide(firstNum, secondNum), Is.EqualTo(result));

    [Test(Description = "�������� ������� ���� �� ����� � �������� ������")]
    [Order(5), Severity(Severity.High), Category("Double"), Category("Positive")]
    public void TestDivideZeroByDoublesFunction() =>
    Assert.That(Calculator.Divide(0d, new Random().NextDouble()), Is.EqualTo(0d));

    [Test(Description = "�������� ������� ����� c ��������� ������ �� ����")]
    [Order(6), Severity(Severity.High), Category("Double"), Category("Negative")]
    public void TestDivideDoublesByZeroFunction() =>
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(new Random().NextDouble(), 0d));

    [Ignore("�������� �������� Ignore")]
    [Order(7), Category("Integer"), Category("Alternative")]
    public int TestIgnoreAttribute(int x, int y) => Calculator.Divide(x, y);

    // ����� ��� ������������� �������� TestCase
    [Test(Description = "�������� ������� ������ ����� �� ����� ����� 2")]
    [Order(8), Severity(Severity.High), Category("Integer"), Category("Positive")]
    [TestCase(7, 7, 1)]
    public void TestDivideIntegersFunctionExample(int firstNum, int secondNum, int result) =>
        Assert.That(Calculator.Divide(firstNum, secondNum), Is.EqualTo(result));

    [Test(Description = "�������� ������� ������ ����� �� ����� ����� 2")]
    [Order(9), Severity(Severity.High), Category("Integer"), Category("Positive")]
    [TestCase(7, 7, ExpectedResult = 1)]
    public int TestDivideIntegersFunctionExample2(int firstNum, int secondNum) =>
        Calculator.Divide(firstNum, secondNum);
}