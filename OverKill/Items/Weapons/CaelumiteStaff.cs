using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill.Items.Weapons
{
	public class CaelumiteStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caelumite Staff"); //Need to be changed to a more appropiate name.
			Tooltip.SetDefault("This might not happen"); //Needs to be changed.
			Item.staff[item.type] = true; //This makes the useStyle animate as a staff instead of a gun.
		}
		
		public override void SetDefaults()
		{
			item.damage = 20;
			item.magic = true; //Sets the weapon to a magic weapon.
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //So the item's animation doesn't do any damage.
			item.knockBack = 5;
			item.value = 10; //Change this to be more suitable.
			item.rare = 3;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CaelumiteProjectile"); //Change this to a projectile.
			item.shootSpeed = 16f;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CaelumiteBar", 20);
			recipe.AddIngredient(ItemID.Leather, 10);
			recipe.AddRecipeGroup("Wood", 15)
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}