using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Poliwrath
{
    public class Poliwrath : ParentPokemon
    {
        

        

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water, PokemonType.Fighting };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumSlow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}