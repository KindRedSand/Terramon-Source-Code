using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Weepinbell
{
    public class Weepinbell : ParentPokemon
    {
        public override int EvolveCost => 1;

        public override EvolveItem EvolveItem => EvolveItem.LeafStone;

        public override Type EvolveTo => typeof(Victreebel.Victreebel);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Grass, PokemonType.Poison };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumSlow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}