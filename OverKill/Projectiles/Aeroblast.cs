using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Projectiles
{
    public class Aeroblast : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aeroblast");
            DisplayName.AddTranslation(GameCulture.Spanish, "Aero-ráfaga");
        }

        public override void SetDefaults()
        {
            projectile.width = 28; 
            projectile.height = 28;
            projectile.timeLeft = 180;
            projectile.penetrate = -1;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            aiType = ProjectileID.Starfury;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.player[projectile.owner].HealEffect(Main.rand.Next(5,8)); //Heal between 5 and 8 life

            Main.PlaySound(SoundID.Shatter, projectile.position); //Play glass shatter sound where the projectile is

            for (int d = 0; d < Main.rand.Next(5,7); d++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Vortex, 0f, 0f, 150, default(Color), 1.5f); //Create 5-7 neon teal particles
            }

            projectile.Kill(); //Kill the projectile
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {

            if (projectile.position.Y > Main.screenPosition.Y + 160f) //If the projectile is low enough
            {
                Main.PlaySound(SoundID.Shatter, projectile.position); //Play glass shatter sound where the projectile is

                for (int d = 0; d < Main.rand.Next(10, 15); d++)
                {
                    Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Vortex, 0f, 0f, 150, default(Color), 1.5f); //Create 10-15 neon teal particles
                }

                return true; //Destroy the projectile
            }

            else
            {
                projectile.velocity = oldVelocity; //Don't change direction (don't bounce off)
                return false; //Don't destroy the projectile
            }
        } 
    }
}