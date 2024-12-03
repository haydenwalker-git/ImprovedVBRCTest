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
        int creates_2 = 1;
        string category_2 = "Mead Bases";
        string name_2 = "Mead Base: Major Healing";
        string source_2 = "Mead ketill";
        Dictionary<string, int> resources_2 = new Dictionary<string, int>();

        resources_2.Add("Honey", 10);
        resources_2.Add("Blood clot", 4);
        resources_2.Add("Royal jelly", 5);

        Item item_2 = new Item(creates_2, category_2, name_2, source_2, resources_2);
        itemDatabase.Add(name_2, item_2);

    }

    public Item GetItem(string name)
    {
        return itemDatabase[name];
    }

}
