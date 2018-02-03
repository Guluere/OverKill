using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill.Projectiles
{
    public class CaelumiteProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caelumite Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 30;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.hostile = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }
    }
}
