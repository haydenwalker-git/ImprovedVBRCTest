/*
    Valheim Basic Resource Calculator (VBRC)
        - Rename ideas:
            * Valheim Crafting Compendium (VCC)
            * Megingjord
            * ...
        - Tagline: Fuling your next playthrough
    Created by Hayden Walker
    Ver. 11/27/24 (November 27th 2024)
    --- TO DO ---
        - Try to find a better solution than a nested for-loop for GetResources(int qualityLevel) and ToString().
        - Create .JSON file to store all items and their quantities, categories, names, crafting bench (source), resource numbers required per quality level, and their required crafting bench (source) level to both craft and repair.
        - Modify DynamicItemDatabase to be loaded from the dynamicItemData JSON file. Can then use this as a template for the rest of the craftable entity/item types.
        - Get started on UI
        - Properly separate DynamicItems (items with quality levels) from regular Items/Craftable entities and figure out good names for them.
            * Create an Item class without quality levels inheriting from the ICraftable class for fireworks, food, mead, etc?
        - Weep
        - Weep again because I deleted ICraftable on accident. SET UP VERSION CONTROL MORON. After you re-create ICraftable, of course.
            * ICraftable re-created, now set up version conotrol you absolute MONKEY
        - Further weeping
 */
public class ImprovedVBRCTest
{
    public static void Main(String[] args)
    {

        DynamicItemDatabase dynamicItemDatabase = new DynamicItemDatabase();
        DynamicItem item = dynamicItemDatabase.GetItem("Club");
        Console.WriteLine(item);

        DynamicItem item2 = dynamicItemDatabase.GetItem("Flint axe");
        Console.WriteLine(item2);

        Console.ReadKey();

    }
}