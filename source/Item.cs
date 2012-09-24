using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    class Item : ACDActor
    {
        private static Dictionary<int, int> GBData;

        public int ItemLevel { get; private set; }
        private string ItemName;
        private int GBID { get { return reader.ReadInt(ACDAddress + 0xB4); } }

        public ItemQuality Quality
        {
            get
            {
                int QLevel = GetInt(Attrib.Item_Quality_Level);
                if (QLevel >= 9)
                    return ItemQuality.Legendary;
                else if (QLevel >= 6)
                    return ItemQuality.Rare;
                else if (QLevel >= 3)
                    return ItemQuality.Magic;
                else if (Name.Contains("CraftingPlan"))
                    return ItemQuality.CraftingPlan;
                return ItemQuality.None;
            }
        }

        public Item(MemoryManager reader, int address)
            : base(reader, address)
        {
            GetItemData();
        }

        public Item(Actor other)
            : base(other)
        {
            GetItemData();
        }

        private void GetItemData()
        {
            if (GBData == null)
            {
                SNOReader snoReader = new SNOReader(reader, 0x1548FB8); //GameBalance SNOGroup
                GBData = new Dictionary<int, int>();

                int armor = snoReader.GetAddressFromID(19750);
                int other = snoReader.GetAddressFromID(19753);
                int weapon = snoReader.GetAddressFromID(19754);

                ReadItemData(armor);
                ReadItemData(other);
                ReadItemData(weapon);
            }

            if (GBData.ContainsKey(GBID))
            {
                int data = GBData[GBID];
                ItemLevel = reader.ReadInt(data + 0x114);
                ItemName = reader.ReadString(data + 0x4, 100);
            }
        }

        private void ReadItemData(int GBFile)
        {
            int address = GBFile + 0x218;
            while (reader.ReadInt(address) == 0)
                address += 0x4;

            int size = reader.ReadInt(address + 0x4);
            address = GBFile + reader.ReadInt(address);

            for (int i = 0; i < size; i += 0x5F0)
            {
                GBData.Add(reader.ReadInt(address + i), address + i);
            }
        }

        public bool IsJewelry()
        {
            return Name.Contains("Ring") || Name.Contains("Amulet");
        }

        public int MaximumLevel()
        {
            if (Name.Contains("Quiver") ||
                Name.Contains("Mojo") ||
                Name.Contains("orb_") ||
                ItemName.Contains("SpiritStone") ||
                ItemName.Contains("BarbBelt") ||
                ItemName.Contains("Cloak") ||
                ItemName.Contains("WizardHat") ||
                ItemName.Contains("VoodooMask"))
                return 62;
            return 63;
        }
    }

    public enum ItemQuality
    {
        None = 0,
        Magic = 1,
        Rare = 2,
        Legendary = 3,
        CraftingPlan = 4
    }
}
