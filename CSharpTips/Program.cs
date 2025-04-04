

// https://chatgpt.com/c/67d1cd7d-3f38-8011-b439-f1f75db8b158





#region CONST VS READONELY - POSTED!

class Car
{
    public const int Wheels = 4;    // Always 4
    public readonly string Color;   // Set once

    public Car(string carColor)
    {
        Color = carColor;          // Locked after this
    }
}

#endregion


#region














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





