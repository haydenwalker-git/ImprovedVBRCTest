using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Database
{

    Dictionary<string, UpgradeableItem> upgradeableItemDict = new Dictionary<string, UpgradeableItem>();
    Dictionary<string, Item> itemDict = new Dictionary<string, Item>();

    public Database()
    {

        // Test UpgradeableItem 1
        int creates = 1;
        string category = "Weapon";
        string name = "Club";
        string source = "Player crafting menu";
        Dictionary<int, Dictionary<string, int>> resourcesByQualityLevel = new Dictionary<int, Dictionary<string, int>>();
        Dictionary<int, int[]> qualityLevelData = new Dictionary<int, int[]>();
        Dictionary<string, int> q1 = new Dictionary<string, int>();
        Dictionary<string, int> q2 = new Dictionary<string, int>();
        Dictionary<string, int> q3 = new Dictionary<string, int>();
        Dictionary<string, int> q4 = new Dictionary<string, int>();

        q1.Add("Wood", 6);
        q2.Add("Bone fragments", 5);
        q3.Add("Bone fragments", 10);
        q4.Add("Bone fragments", 15);
        resourcesByQualityLevel.Add(1, q1);
        resourcesByQualityLevel.Add(2, q2);
        resourcesByQualityLevel.Add(3, q3);
        resourcesByQualityLevel.Add(4, q4);

        int[] ql1 = { 1, 1 };
        int[] ql2 = { 2, 1 };
        int[] ql3 = { 3, 1 };
        int[] ql4 = { 4, 1 };
        qualityLevelData.Add(1, ql1);
        qualityLevelData.Add(2, ql2);
        qualityLevelData.Add(3, ql3);
        qualityLevelData.Add(4, ql3);

        UpgradeableItem item = new UpgradeableItem(creates, category, name, source, resourcesByQualityLevel, qualityLevelData);
        upgradeableItemDict.Add(name, item);

        // Test UpgradeableItem 2
        int creates2 = 1;
        string category2 = "Weapon";
        string name2 = "Flint axe";
        string source2 = "Workbench";
        Dictionary<int, Dictionary<string, int>> resourcesByQualityLevel2 = new Dictionary<int, Dictionary<string, int>>();
        Dictionary<int, int[]> qualityLevelData2 = new Dictionary<int, int[]>();
        Dictionary<string, int> q12 = new Dictionary<string, int>();
        Dictionary<string, int> q22 = new Dictionary<string, int>();
        Dictionary<string, int> q32 = new Dictionary<string, int>();
        Dictionary<string, int> q42 = new Dictionary<string, int>();

        q12.Add("Wood", 4);
        q12.Add("Flint", 6);
        q22.Add("Flint", 3);
        q22.Add("Leather scraps", 2);
        q32.Add("Flint", 6);
        q32.Add("Leather scraps", 4);
        q42.Add("Flint", 9);
        q42.Add("Leather scraps", 6);
        resourcesByQualityLevel2.Add(1, q12);
        resourcesByQualityLevel2.Add(2, q22);
        resourcesByQualityLevel2.Add(3, q32);
        resourcesByQualityLevel2.Add(4, q42);

        int[] ql12 = { 1, 1 };
        int[] ql22 = { 2, 1 };
        int[] ql32 = { 3, 1 };
        int[] ql42 = { 4, 1 };
        qualityLevelData2.Add(1, ql12);
        qualityLevelData2.Add(2, ql22);
        qualityLevelData2.Add(3, ql32);
        qualityLevelData2.Add(4, ql42);

        UpgradeableItem item2 = new UpgradeableItem(creates2, category2, name2, source2, resourcesByQualityLevel2, qualityLevelData2);
        upgradeableItemDict.Add(name2, item2);

        // Test Item 1
        int creates3 = 6;
        string category3 = "Mead";
        string name3 = "Major healing mead";
        string source3 = "Fermenter";
        Dictionary<string, int> resources3 = new Dictionary<string, int>();

        resources3.Add("Mead base: Major Healing", 1);

        Item item3 = new Item(creates3, category3, name3, source3, resources3);
        itemDict.Add(name3, item3);

        // Test Item 2
        int creates4 = 1;
        string category4 = "Mead Bases";
        string name4 = "Mead Base: Major Healing";
        string source4 = "Mead ketill";
        Dictionary<string, int> resources4 = new Dictionary<string, int>();

        resources4.Add("Honey", 10);
        resources4.Add("Blood clot", 4);
        resources4.Add("Royal jelly", 5);

        Item item4 = new Item(creates4, category4, name4, source4, resources4);
        itemDict.Add(name4, item4);

    }

    public UpgradeableItem GetUpgradeableItem(string name)
    {
        return upgradeableItemDict[name];
    }

    public Item GetItem(string name)
    {
        return itemDict[name];
    }

}
