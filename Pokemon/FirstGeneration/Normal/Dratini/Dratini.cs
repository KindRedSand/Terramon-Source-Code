using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Dratini
{
    public class Dratini : ParentPokemon
    {
        public override int EvolveCost => 25;

        public override Type EvolveTo => typeof(Dragonair.Dragonair);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Dragon };

        public virtual ExpGroup ExpGroup => ExpGroup.Slow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}