using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Spectre.Console;

namespace point_of_sale_EF;

static internal class UserInterface
{
    static internal void ShowProductTable(List<Product> products)
    {
        var table = new Spectre.Console.Table();
        table.AddColumn("ID");
        table.AddColumn("Name");

        foreach (var product in products)
        {
            table.AddRow(product.Id.ToString(), product.Name);
        }

        AnsiConsole.Write(table);
        Console.WriteLine("Enter any key to continue");
        Console.ReadLine();
        Console.Clear();
    }

    internal static void ShowProduct(Product product)
    {
        var panel = new Panel($@"ID: {product.Id}
Name: {product.Name}");
        panel.Header = new PanelHeader("Product Info");
        panel.Padding = new Padding(2, 2, 2, 2);
        
        AnsiConsole.Write(panel);
        Console.WriteLine("Enter any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
}
