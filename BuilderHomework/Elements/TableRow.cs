using OpenQA.Selenium;

namespace BuilderHomework.Elements;

public class TableRow
{
    private readonly UIElement _uiElement;
    private readonly List<TableCell> _cells;

    public TableRow(UIElement uiElement)
    {
        _uiElement = uiElement;
        _cells = new List<TableCell>();

        foreach (var cellElement in _uiElement.FindUIElements(By.TagName("td")))
        {
            _cells.Add(new TableCell(cellElement));
        }
    }

    public TableCell GetCell(int columnIndex)
    {
        return _cells[columnIndex];
    }
}