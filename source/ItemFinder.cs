using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    class ItemFinder : IDisposable
    {
        private DiabloIII d3;
        private List<ACDActor> IgnoreList;
        private int LastLevelArea;

        public ItemFinder()
        {
            d3 = new DiabloIII();
            IgnoreList = new List<ACDActor>();
        }

        public ItemFinder(int processID)
        {
            d3 = new DiabloIII(processID);
            IgnoreList = new List<ACDActor>();
        }

        public ACDActor FindBestItem()
        {
            if (d3.Valid == false)
                return null;
            ACDActor player = d3.Player();
            if (player == null || player.IsValid() == false)
                return null;

            if (LastLevelArea != d3.CurrentLevelArea())
            {
                IgnoreList.Clear();
                LastLevelArea = d3.CurrentLevelArea();
            }

            foreach (ACDActor a in d3.GetACDActors())
            {
                if (a.IsValid() == false)
                    continue;
                if (IgnoreList.Contains(a))
                    continue;

                if (a.ACDType == ACDType.Item)
                {
                    Item item = new Item(a);
                    ItemQuality q = item.Quality;

                    if (q == ItemQuality.Legendary && Settings.PlayOnLegendary)
                    {
                        IgnoreList.Add(a);
                        return a;
                    }
                    if (q == ItemQuality.Rare && Settings.PlayOnRare)
                    {
                        bool Max62 = item.MaximumLevel() == 62;
                        if ((Max62 && item.ItemLevel >= Settings.Min62s) ||
                            (!Max62 && item.ItemLevel >= Settings.Min63s) ||
                            item.IsJewelry() && item.ItemLevel >= Settings.MinJewelry)
                        {
                            IgnoreList.Add(a);
                            return a;
                        }
                    }
                    if (q == ItemQuality.Magic && Settings.PlayOnMagic)
                    {
                        if (item.ItemLevel >= Settings.MinMagic)
                        {
                            IgnoreList.Add(a);
                            return a;
                        }
                    }

                    if (q == ItemQuality.CraftingPlan && Settings.PlayOnCrafting)
                    {
                        IgnoreList.Add(a);
                        return a;
                    }
                }

                else if (Settings.PlayOnGoblin && a.IsGoblin())
                {
                    IgnoreList.Add(a);
                    return a;
                }
            }
            return null;
        }

        public void Dispose()
        {
            d3.Dispose();
        }
    }
}
