using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class UpgradeableItem : ICraftable
{

    private const int MinQualityLevel = 1;
    private int creates;
    private string category;
    private string name;
    private string source;
    private Dictionary<int, Dictionary<string, int>> resourcesByQualityLevel;
    private Dictionary<int, int[]> qualityLevelData;

    public UpgradeableItem (int creates, string category, string name, string source,
        Dictionary<int, Dictionary<string, int>> resourcesByQualityLevel, Dictionary<int, int[]> qualityLevelData)
    {

        this.creates = creates;
        this.category = category;
        this.name = name;
        this.source = source;
        this.resourcesByQualityLevel = resourcesByQualityLevel;
        this.qualityLevelData = qualityLevelData;

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
        return resourcesByQualityLevel[MinQualityLevel];

    }

    // Definitely a more efficient solution than a nested for-loop out there. Come back and refactor once other more important things are taken care of.
    public Dictionary<string, int> GetResources(int qualityLevel)
    {

        Dictionary<string, int> tempResourcesByQualityLevel = new Dictionary<string, int>();
        for (int i = 1; i <= qualityLevel; i++)
        {

            Dictionary<string, int>.KeyCollection kvp = resourcesByQualityLevel[i].Keys;
            foreach (string key in kvp)
            {

                int currVal = resourcesByQualityLevel[i][key];
                if (!tempResourcesByQualityLevel.ContainsKey(key))
                {
                    tempResourcesByQualityLevel.Add(key, currVal);
                }
                else
                {
                    tempResourcesByQualityLevel[key] += currVal;
                }

            }

        }

        return tempResourcesByQualityLevel;
    }

    public Dictionary<int, int[]> GetQualityLevelData()
    {
        return qualityLevelData;
    }

    // Purely for testing purposes; returns a string containing a resourcesByQualityLevel needed to craft the item at each quality level.
    public override string ToString()
    {

        UpgradeableItem itemToOut = new UpgradeableItem(this.creates, this.category, this.name, this.source, this.resourcesByQualityLevel, this.qualityLevelData);
        string output = "\t~~~ " + name + " ~~~\n";
        output += "Creates: " + creates + "\n";

        for (int i = 1; i <= resourcesByQualityLevel.Count; i++) // Another nested for-loop. This is so scuffed, but it works(?)
        {

            Dictionary<string, int> resources = itemToOut.GetResources(i);
            Dictionary<string, int>.KeyCollection kvp = resources.Keys;
            output += "\n--- Quality Level " + i + " ---\n";

            foreach (string key in kvp)
            {
                output += key + ": " + resources[key] + "\n";
            }

        }

        return output; 

    }

}
