using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Graveler
{
    public class Graveler : ParentPokemon
    {
        public override int EvolveCost => 1;

        public override EvolveItem EvolveItem => EvolveItem.LinkCable;

        public override Type EvolveTo => typeof(Golem.Golem);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Rock, PokemonType.Ground };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumSlow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}