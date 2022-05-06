using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSpectre;

public class Product
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int Cost { get; set; }

    public List<Nutrition> Nutritions { get; set; } = new List<Nutrition>();

    public override string ToString() => $"\nName: {Name}\nCost: {Cost}\nNutritions: " + String.Join(", ", Nutritions) +"\n";
}