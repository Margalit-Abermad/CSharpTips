

// https://chatgpt.com/c/67d1cd7d-3f38-8011-b439-f1f75db8b158





#region CONST VS READONELY - POSTED!

//class Car
//{
//    public const int Wheels = 4;    // Always 4
//    public readonly string Color;   // Set once

//    public Car(string carColor)
//    {
//        Color = carColor;          // Locked after this
//    }
//}

#endregion


#region Break VS Continue -- POSTED!

using System.Text;

for (int i = 1; i <= 5; i++)
{
    if (i == 3) continue; // skip 3
    Console.WriteLine(i);
}
// Output: 1 2 4 5


for (int i = 1; i <= 5; i++)
{
    if (i == 3) break; // stop at 3
    Console.WriteLine(i);
}
// Output: 1 2

#endregion

List<Itme> items = new List<Item>();


#region string vs stringBuilder

// ❌ Creates a new string in each iteration – not efficient

string result = "";

for (int i = 1; i <= items.Count(); i++)
    result += $"Item #{i}\n";


// ✅ Reuses the same object – much better performance

var sb = new StringBuilder();

for (int i = 1; i <= items.Count(); i++)
    sb.AppendLine($"Item #{i}");


#endregion




#region string vs StringBuilder



#endregion










string str = null;
bool noProductFound = false;
IEnumerable<Product> products = null;



#region  1️⃣ Avoid returning null for collections

//good

public IEnumerable<Product> GetProducts()
{
    return noProductFound ? Enumerable.Empty<Product>() : products;
}



//bad

public IEnumerable<Product> GetProducts()
{
    if (noProductFound)
    {
        return null;
    }
    return products;
}



#endregion



#region

//good


if (str == null || str == "" || str.Trim() == "")
{
    Console.WriteLine("Invalid string");
}


//bad


if (string.IsNullOrWhiteSpace(str))
{
    Console.WriteLine("Invalid string");
}


#endregion





