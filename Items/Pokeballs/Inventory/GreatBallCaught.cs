﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Razorwing.Framework.Localisation;
using Terraria.ModLoader;

namespace Terramon.Items.Pokeballs.Inventory
{
    public class GreatBallCaught : BaseCaughtClass
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Great Ball");
            Tooltip.SetDefault(pokeballTooltip?.Value ?? "");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (pokeName.Value != PokemonName)
            {
                pokeName = TerramonMod.Localisation.GetLocalisedString(new LocalisedString(PokemonName));
            }

            TooltipLine nameLine = tooltips.FirstOrDefault(t => t.Name == "ItemName" && t.mod == "Terraria");
            if (nameLine != null) nameLine.text = "Great Ball (" + pokeName.Value + (isShiny ? " ✦)" : ")");

            foreach (TooltipLine line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(89, 183, 255);


            pokeballTooltip.Args = new object[] { isShiny ? pokeName.Value + " ✦" : pokeName.Value };
            tooltips.Find(x => x.Name == "Tooltip0").text = pokeballTooltip.Value;
            base.ModifyTooltips(tooltips);
        }
    }
}