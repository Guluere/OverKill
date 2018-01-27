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

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Shatter, projectile.position);

            for (int d = 0; d < 20; d++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Vortex, 0f, 0f, 150, default(Color), 1.5f);
            }
            return true;
        }
    }
}