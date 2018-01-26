using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Projectiles
{
	public class RubberBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rubber Bullet");
            DisplayName.AddTranslation(GameCulture.Spanish, "Bala de goma");

            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5; 
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
            projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 40;
			projectile.timeLeft = 600;
			projectile.alpha = 255;
			projectile.light = 0; 
			projectile.ignoreWater = true; 
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Bullet;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
			}
			else
			{
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
				Main.PlaySound(SoundID.Item10, projectile.position);
			}
			return false;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			{
				projectile.Kill();
			}
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}
