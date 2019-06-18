using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;

        switch (itemID)
        {
            #region Food 0-99
            case 0:
                name = "Meat";
                value = 15;
                description = "Animal Flavour";
                icon = "Meat_Icon";
                mesh = "Meat_Mesh";
                type = ItemType.Food;
                heal = 20;
                amount = 1;
                break;
            case 1:
                name = "Chicken";
                value = 10;
                description = "Bird Flavour";
                icon = "Chicken_Icon";
                mesh = "Chicken_Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;
            case 2:
                name = "Bread";
                value = 5;
                description = "Bread Flavour";
                icon = "Bread_Icon";
                mesh = "Bread_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;
            #endregion
            #region Weapon 100-199
            case 100:
                name = "Short Sword";
                value = 25;
                description = "Short One";
                icon = "ShortSword_Icon";
                mesh = "ShortSword_Mesh";
                type = ItemType.Weapon;
                damage = 15;
                amount = 1;
                break;
            case 101:
                name = "Long Sword";
                value = 50;
                description = "Long One";
                icon = "LongSword_Icon";
                mesh = "LongSword_Mesh";
                type = ItemType.Weapon;
                damage = 30;
                amount = 1;
                break;
            case 102:
                name = "Axe";
                value = 75;
                description = "Strong One";
                icon = "Axe_Icon";
                mesh = "Axe_Mesh";
                type = ItemType.Weapon;
                damage = 45;
                amount = 1;
                break;
            #endregion
            #region Apparel 200-299
            case 200:
                name = "Mage Helmet";
                value = 10;
                description = "Malzahar";
                icon = "MageHelmet_Icon";
                mesh = "MageHelmet_Mesh";
                type = ItemType.Apparel;
                armour = 10;
                amount = 1;
                break;
            case 201:
                name = "Spooky Helmet";
                value = 50;
                description = "Unknown";
                icon = "SpookyHelmet_Icon";
                mesh = "SpookyHelmet_Mesh";
                type = ItemType.Apparel;
                armour = 50;
                amount = 1;
                break;
            case 202:
                name = "Prince Helmet";
                value = 100;
                description = "Aladdin";
                icon = "PrinceHelmet_Icon";
                mesh = "PrinceHelmet_Mesh";
                type = ItemType.Apparel;
                armour = 100;
                amount = 1;
                break;
            #endregion
            #region Crafting 300-399
            case 300:
                name = "Feather";
                value = 15;
                description = "I can fly";
                icon = "Feather_Icon";
                mesh = "Feather_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 301:
                name = "Blood";
                value = 75;
                description = "I can die";
                icon = "Blood_Icon";
                mesh = "Blood_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 302:
                name = "Slime";
                value = 200;
                description = "I can feel";
                icon = "Slime_Icon";
                mesh = "Slime_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            #endregion
            #region Quest 400-499
            case 400:
                name = "Book";
                value = 15;
                description = "Regular Book";
                icon = "Book_Icon";
                mesh = "Book_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 401:
                name = "Map";
                value = 50;
                description = "Regular Map";
                icon = "Map_Icon";
                mesh = "Map_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 402:
                name = "Ring";
                value = 200;
                description = "Regular Ring";
                icon = "Ring_Icon";
                mesh = "Ring_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            #endregion
            #region Ingredient 500-599
            case 500:
                name = "Flower";
                value = 1;
                description = "Tiny Flower";
                icon = "Flower_Icon";
                mesh = "Flower_Mesh";
                type = ItemType.Ingredient;
                heal = 1;
                amount = 1;
                break;
            case 501:
                name = "Fruitage";
                value = 2;
                description = "Tiny Fruitage";
                icon = "Fruitage_Icon";
                mesh = "Fruitage_Mesh";
                type = ItemType.Ingredient;
                heal = 2;
                amount = 1;
                break;
            case 502:
                name = "Mushrooms";
                value = 3;
                description = "Tiny Mushrooms";
                icon = "Mushrooms_Icon";
                mesh = "Mushrooms_Mesh";
                type = ItemType.Ingredient;
                heal = 3;
                amount = 1;
                break;
            #endregion
            #region Potion 600-699
            case 600:
                name = "Health";
                value = 30;
                description = "Heal";
                icon = "Health_Icon";
                mesh = "Health_Mesh";
                type = ItemType.Potion;
                heal = 20;
                amount = 1;
                break;
            case 601:
                name = "Tenacity";
                value = 30;
                description = "Heavy";
                icon = "Tenacity_Icon";
                mesh = "Tenacity_Mesh";
                type = ItemType.Potion;
                armour = 20;
                amount = 1;
                break;
            case 602:
                name = "Corrupted";
                value = 1;
                description = "Drink This";
                icon = "Corrupted_Icon";
                mesh = "Corrupted_Mesh";
                type = ItemType.Potion;
                damage = 1000;
                amount = 1;
                break;
            #endregion
            #region Scrolls 700-799
            case 700:
                name = "Red";
                value = 15;
                description = "Is Red";
                icon = "Red_Icon";
                mesh = "Red_Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            case 701:
                name = "Blue";
                value = 15;
                description = "Is Blue";
                icon = "Blue_Icon";
                mesh = "Blue_Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            case 702:
                name = "Green";
                value = 15;
                description = "Is Green";
                icon = "Green_Icon";
                mesh = "Green_Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            #endregion
            #region Default
            default:
                itemID = 4;
                name = "Apple";
                value = 5;
                description = "Munchy and Crunchy";
                icon = "Apple_Icon";
                mesh = "Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 5;
                break;
                #endregion
        }
        Item temp = new Item
        {
            Name = name,
            Description = description,
            ID = itemID,
            Value = value,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Heal = heal,
            Type = type,
            Mesh = Resources.Load("Prefabs/" + mesh) as GameObject,
            Icon = Resources.Load("Icon/" + icon) as Texture2D,
        };
        return temp;
    }
}