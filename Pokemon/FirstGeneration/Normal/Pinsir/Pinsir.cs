using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Pinsir
{
    public class Pinsir : ParentPokemon
    {
        

        

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Bug };

        public virtual ExpGroup ExpGroup => ExpGroup.Slow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}