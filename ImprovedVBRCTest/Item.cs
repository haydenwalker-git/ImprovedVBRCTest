using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

public class Item : ICraftable
{

    private int creates;
    private string category;
    private string name;
    private string source;
    private Dictionary<string, int> resources;

    public Item(int creates, string category, string name, string source, Dictionary<string, int> resources)
    {

        this.creates = creates;
        this.category = category;
        this.name = name;
        this.source = source;
        this.resources = resources;

    }

    public int GetCreates()
    {
        return creates;
    }

    public string GetCategory()
    {
        return category;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSource()
    {
        return source;
    }

    public Dictionary<string, int> GetResources()
    {
        return resources;
    }

    public override string ToString()
    {

        Item itemToOut = new Item(this.creates, this.category, this.name, this.source, this.resources);
        string output = "\t~~~ " + name + " ~~~\n";
        output += "Creates: " + creates + "\n";

        Dictionary<string, int>.KeyCollection kvp = resources.Keys;

        foreach (string key in kvp)
        {
            output += key + ": " + resources[key] + "\n";
        }

        return output;

    }

}
