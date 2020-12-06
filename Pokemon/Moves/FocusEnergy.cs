﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Razorwing.Framework.Graphics;
using Razorwing.Framework.Localisation;
using Razorwing.Framework.Utils;
using System;
using Terramon.Players;
using Terramon.UI;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Terramon.Pokemon.Moves
{
    public class FocusEnergy : DamageMove
    {
        public override string MoveName => "Focus Energy";
        public override string MoveDescription => "The user takes a deep breath and focuses so that critical hits land more easily.";
        public override int Damage => 0;
        public override int Accuracy => -1;
        public override int MaxPP => 30;
        public override int MaxBoostPP => 48;
        public virtual bool MakesContact => false;
        public override bool Special => false;
        public override Target Target => Target.Opponent;
        public override int Cooldown => 60 * 1; //Once per second
        public override PokemonType MoveType => PokemonType.Normal;

        public override int AutoUseWeight(ParentPokemon mon, Vector2 pos, TerramonPlayer player)
        {
            NPC target = GetNearestNPC(pos);
            if (target == null)
                return 0;
            return 30;
        }

        public override bool PerformInWorld(ParentPokemon mon, Vector2 pos, TerramonPlayer player)
        {
            NPC target = GetNearestNPC(pos);
            if (target == null)
                return false;

            player.Attacking = true;
            Vector2 vel = (target.position + (target.Size/2)) - (mon.projectile.position + (mon.projectile.Size/2));
            var l = vel.Length();
            vel += target.velocity * (l / 100);//Make predict shoot
            vel.Normalize(); //Direction
            vel *= 15; //Speed
            Projectile.NewProjectile((mon.projectile.position + (mon.projectile.Size / 2)), vel, ProjectileID.DD2PhoenixBowShot, 20, 1f, player.whoAmI);
            return true;
        }

        private string s;
        public override bool AnimateTurn(ParentPokemon mon, ParentPokemon target, TerramonPlayer player, PokemonData attacker,
            PokemonData deffender, BattleState state, bool opponent)
        {
            if (AnimationFrame == 1) //At initial frame we pan camera to attacker
            {
                TerramonMod.ZoomAnimator.ScreenPosX(mon.projectile.position.X + 12, 500, Easing.OutExpo);
                TerramonMod.ZoomAnimator.ScreenPosY(mon.projectile.position.Y, 500, Easing.OutExpo);
            }
            else if (AnimationFrame == 140) //Move animation begin after 140 frames
            {
                BattleMode.UI.splashText.SetText("");

                Main.PlaySound(ModContent.GetInstance<TerramonMod>().GetLegacySoundSlot(SoundType.Custom, "Sounds/UI/BattleSFX/" + MoveName).WithVolume(.75f));
            }
            
            if (AnimationFrame > 140 && AnimationFrame < 195)
            {
                for (int i = 0; i < 1; i++)
                {
                    Dust dust1 = Dust.NewDustDirect(mon.projectile.position, mon.projectile.width, mon.projectile.height, 174, 0f, 0f, 0, Color.White, 1.1f);
                    dust1.alpha = 50;
                    dust1.velocity.Y = -1.5f;
                    dust1.noGravity = true;
                }
            }

            if (AnimationFrame == 275)
            {
                s = ModifyStat(attacker, mon, GetStat.CritRatio, 1, state, !opponent).ToString();
                BattleMode.UI.splashText.SetText(s);
            }

            if (AnimationFrame >= 415)
            {
                AnimationFrame = 0;
                s = "";
                BattleMode.moveEnd = false;
                return false;
            }

            return true;
        }
    }
    public class FocusDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            Dust.CloneDust(174);
            dust.alpha = 50;
            dust.velocity.Y = -1.5f;
            dust.noGravity = true;
        }

        public int color = 0;

        public override bool Update(Dust dust)
        {
            if (color == 0)
            {
                color = 1;
                int rnd = Main.rand.Next(1, 3);
                if (rnd == 0) {
                    dust.color = new Color(255, 50, 50);
                }
                else if (rnd == 1) {
                    dust.color = new Color(255, 150, 58);
                }
                else dust.color = new Color(255, 251, 48);
            }


            dust.scale -= 0.01f;
            float num59 = dust.scale * 1f;
            if (num59 > 0.6f)
            {
                num59 = 0.6f;
            }
            Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), num59, num59 * 0.4f, 0f);
            return false;
        }
    }
}