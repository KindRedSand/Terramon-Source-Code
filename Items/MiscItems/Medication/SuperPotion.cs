﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Terramon.Items.MiscItems.Medication
{
    public class SuperPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Super Potion");
            Tooltip.SetDefault("A spray-type medicine for treating wounds."
                               + "\nHold it and right click your Pokémon to use."
                               + "\nRestores up to 50 HP.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 32;
            item.maxStack = 99;
            item.value = 400;
            item.rare = 0;
            // Set other item.X values here
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine nameLine = tooltips.FirstOrDefault(t => t.Name == "ItemName" && t.mod == "Terraria");

            foreach (TooltipLine line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(255, 173, 148);
        }

        public override bool CanBurnInLava()
        {
            return false;
        }
    }
}