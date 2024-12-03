using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemDatabase
{

    Dictionary<string, Item> itemDatabase = new Dictionary<string, Item>();

    public ItemDatabase()
    {
        // Test Item 1
        int creates = 6;
        string category = "Mead";
        string name = "Major healing mead";
        string source = "Fermenter";
        Dictionary<string, int> resources = new Dictionary<string, int>();

        resources.Add("Mead base: Major Healing", 1);

        Item item = new Item(creates, category, name, source, resources);
        itemDatabase.Add(name, item);

        // Test Item 2
        int creates2 = 1;
        string category2 = "Mead Bases";
        string name2 = "Mead Base: Major Healing";
        string source2 = "Mead ketill";
        Dictionary<string, int> resources2 = new Dictionary<string, int>();

        resources2.Add("Honey", 10);
        resources2.Add("Blood clot", 4);
        resources2.Add("Royal jelly", 5);

        Item item2 = new Item(creates2, category2, name2, source2, resources2);
        itemDatabase.Add(name2, item2);

    }

    public Item GetItem(string name)
    {
        return itemDatabase[name];
    }

}
