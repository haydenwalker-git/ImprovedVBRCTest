using System;

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

    public string ToString()
    {
        return null;
    }

}
