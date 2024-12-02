using System;
using System.Security;

public interface IDynamicItem : ICraftable
{

	// Can't define constructors in interfaces, but this is how they should be implemented:
	// Item(string category, string name, string source,  
	//	Dictionary<string, int> resourcesByQualityLevel, Dictionary<int, int[]> qualityLevelData);

	Dictionary<int, int[]> GetQualityLevelData(); // Returns dictionary with the key as the quality level, value is an array where index 0 is the crafting level and index 1 is the repair level
	Dictionary<string, int> GetResources(int qualityLevel); // Returns resource names and amounts required to craft or upgrade. 

}
