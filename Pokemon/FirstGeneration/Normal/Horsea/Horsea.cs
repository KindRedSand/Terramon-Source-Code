using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Horsea
{
    public class Horsea : ParentPokemon
    {
        public override int EvolveCost => 27;

        public override Type EvolveTo => typeof(Seadra.Seadra);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumFast;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}