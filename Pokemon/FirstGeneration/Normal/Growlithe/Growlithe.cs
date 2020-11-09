using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Growlithe
{
    public class Growlithe : ParentPokemon
    {
        public override int EvolveCost => 1;

        public override EvolveItem EvolveItem => EvolveItem.FireStone;

        public override Type EvolveTo => typeof(Arcanine.Arcanine);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Fire };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}