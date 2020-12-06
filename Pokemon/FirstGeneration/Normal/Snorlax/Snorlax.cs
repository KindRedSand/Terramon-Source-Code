using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Snorlax
{
    public class Snorlax : ParentPokemon
    {
        

        

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Normal };

        public virtual ExpGroup ExpGroup => ExpGroup.Slow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}