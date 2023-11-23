using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootList : MonoBehaviour
{
    [Header("Chest Type")]
    [SerializeField] private int woodenChest;
    [SerializeField] private int bronzeChest;
    [SerializeField] private int silverChest;
    [SerializeField] private int goldChest;
    [SerializeField] private int platinumChest;
    [SerializeField] private List<string> chestType;

    [Header("Wooden Chest")]
    [SerializeField] private int woodenChestCommon;
    [SerializeField] private int woodenChestUncommon;
    [SerializeField] private int woodenChestRare;
    [SerializeField] private int woodenChestEpic;
    [SerializeField] private int woodenChestLegendary;
    [SerializeField] private List<string> woodenChestDrops;

    [Header("Bronze Chest")]
    [SerializeField] private int bronzeChestCommon;
    [SerializeField] private int bronzeChestUncommon;
    [SerializeField] private int bronzeChestRare;
    [SerializeField] private int bronzeChestEpic;
    [SerializeField] private int bronzeChestLegendary;
    [SerializeField] private List<string> bronzeChestDrops;

    [Header("Silver Chest")]
    [SerializeField] private int silverChestCommon;
    [SerializeField] private int silverChestUncommon;
    [SerializeField] private int silverChestRare;
    [SerializeField] private int silverChestEpic;
    [SerializeField] private int silverChestLegendary;
    [SerializeField] private List<string> silverChestDrops;

    [Header("Gold Chest")]
    [SerializeField] private int goldChestCommon;
    [SerializeField] private int goldChestUncommon;
    [SerializeField] private int goldChestRare;
    [SerializeField] private int goldChestEpic;
    [SerializeField] private int goldChestLegendary;
    [SerializeField] private List<string> goldChestDrops;

    [Header("Platinum Chest")]
    [SerializeField] private int platinumChestCommon;
    [SerializeField] private int platinumChestUncommon;
    [SerializeField] private int platinumChestRare;
    [SerializeField] private int platinumChestEpic;
    [SerializeField] private int platinumChestLegendary;
    [SerializeField] private List<string> platinumChestDrops;

    private string chestTypeName;
    private string dropRaritlyName;

    void Start()
    {
        // Chest Types
        for (int i = 0; i < woodenChest; i++) { chestType.Add("Wooden Chest");}
        for (int i = 0; i < bronzeChest; i++) { chestType.Add("Bronze Chest");}
        for (int i = 0; i < silverChest; i++) { chestType.Add("Silver Chest");}
        for (int i = 0; i < goldChest; i++) { chestType.Add("Gold Chest");}
        for (int i = 0; i < platinumChest; i++) { chestType.Add("Platinum Chest");}

        // Wooden Chest Drops
        for (int i = 0; i < woodenChestCommon; i++) { woodenChestDrops.Add("Common");}
        for (int i = 0; i < woodenChestUncommon; i++) { woodenChestDrops.Add("Uncommon");}
        for (int i = 0; i < woodenChestRare; i++) { woodenChestDrops.Add("Rare");}
        for (int i = 0; i < woodenChestEpic; i++) { woodenChestDrops.Add("Epic");}
        for (int i = 0; i < woodenChestLegendary; i++) { woodenChestDrops.Add("Legendary");}

        // Bronze Chest Drops
        for (int i = 0; i < bronzeChestCommon; i++) { bronzeChestDrops.Add("Common");}
        for (int i = 0; i < bronzeChestUncommon; i++) { bronzeChestDrops.Add("Uncommon");}
        for (int i = 0; i < bronzeChestRare; i++) { bronzeChestDrops.Add("Rare");}
        for (int i = 0; i < bronzeChestEpic; i++) { bronzeChestDrops.Add("Epic");}
        for (int i = 0; i < bronzeChestLegendary; i++) { bronzeChestDrops.Add("Legendary");}

        // Silver Chest Drops
        for (int i = 0; i < silverChestCommon; i++) { silverChestDrops.Add("Common");}
        for (int i = 0; i < silverChestUncommon; i++) { silverChestDrops.Add("Uncommon");}
        for (int i = 0; i < silverChestRare; i++) { silverChestDrops.Add("Rare");}
        for (int i = 0; i < silverChestEpic; i++) { silverChestDrops.Add("Epic");}
        for (int i = 0; i < silverChestLegendary; i++) { silverChestDrops.Add("Legendary");}

        // Gold Chest Drops
        for (int i = 0; i < goldChestCommon; i++) { goldChestDrops.Add("Common");}
        for (int i = 0; i < goldChestUncommon; i++) { goldChestDrops.Add("Uncommon");}
        for (int i = 0; i < goldChestRare; i++) { goldChestDrops.Add("Rare");}
        for (int i = 0; i < goldChestEpic; i++) { goldChestDrops.Add("Epic");}
        for (int i = 0; i < goldChestLegendary; i++) { goldChestDrops.Add("Legendary");}

        // Platinum Chest Drops
        for (int i = 0; i < platinumChestCommon; i++) { platinumChestDrops.Add("Common");}
        for (int i = 0; i < platinumChestUncommon; i++) { platinumChestDrops.Add("Uncommon");}
        for (int i = 0; i < platinumChestRare; i++) { platinumChestDrops.Add("Rare");}
        for (int i = 0; i < platinumChestEpic; i++) { platinumChestDrops.Add("Epic");}
        for (int i = 0; i < platinumChestLegendary; i++) { platinumChestDrops.Add("Legendary");}
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chestTypeName = chestType[Random.Range(0, chestType.Count - 1)];

            switch (chestTypeName)
            {
                case "Wooden Chest":
                    dropRaritlyName = woodenChestDrops[Random.Range(0, woodenChestDrops.Count - 1)];
                    break;
                case "Bronze Chest":
                    dropRaritlyName = bronzeChestDrops[Random.Range(0, bronzeChestDrops.Count - 1)];
                    break;
                case "Silver Chest":
                    dropRaritlyName = silverChestDrops[Random.Range(0, silverChestDrops.Count - 1)];
                    break;
                case "Gold Chest":
                    dropRaritlyName = goldChestDrops[Random.Range(0, goldChestDrops.Count - 1)];
                    break;
                case "Platinum Chest":
                    dropRaritlyName = platinumChestDrops[Random.Range(0, platinumChestDrops.Count - 1)];
                    break;
            }

            Debug.Log("You got a " + dropRaritlyName + " Item from a " + chestTypeName + "!");
        }
    }
}
