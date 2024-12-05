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
        - Try to find a better solution than a nested for-loop for GetResources(int qualityLevel)
        - Create .JSON file to store all items and their quantities, categories, names, crafting bench (source), resource numbers required per quality level (if applicable), and their required crafting bench (source) level to both craft and repair.
        - Modify UpgradeableItemDatabase to be loaded from the upgradeableItemData JSON file. Can then use this as a template for the rest of the craftable entity/item types.
        - Get started on UI
        - Properly separate UpgradeableItems (items with quality levels) from regular Items/Craftable entities and figure out good names for them.
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

        Database database = new Database();

        // Upgradeable Item Testing
        Console.WriteLine("-------------------- Upgradeable Item Testing --------------------");
        UpgradeableItem upgradeableItem = database.GetUpgradeableItem("Club");
        Console.WriteLine(upgradeableItem);

        UpgradeableItem upgradeableItem2 = database.GetUpgradeableItem("Flint axe");
        Console.WriteLine(upgradeableItem2);

        // Non-upgradeable Item Testing
        Console.WriteLine("-------------------- Non-upgradeable Item Testing --------------------");
        Item item = database.GetItem("Major healing mead");
        Console.WriteLine(item);

        Item item2 = database.GetItem("Mead Base: Major Healing");
        Console.WriteLine(item2);

    }
}