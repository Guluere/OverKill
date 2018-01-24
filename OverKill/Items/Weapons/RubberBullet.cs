using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill.Items.Weapons
{	
	public class RubberBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bounce Bounce Bounce!");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("RubberBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 20f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 250);
			recipe.AddTile(18);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
	

}
