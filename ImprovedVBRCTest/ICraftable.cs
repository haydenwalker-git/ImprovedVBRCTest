using System;
using System.Security;

public interface ICraftable
{

    int GetCreates(); // Returns the creates of items created per craft (not affected by upgrading)
    string GetCategory(); // Returns item category
	string GetName(); // Returns item name
    string GetSource(); // Returns source (source) required to craft or place the item
    Dictionary<string, int> GetResources(); // Returns the resources and the amount needed to craft the item at its default quality level.
	string ToString(); // Purely for testing purposes; converts item to a printable string format

}
