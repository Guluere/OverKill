using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
	public class RapierOfGods : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Rapier of Gods");
            Tooltip.SetDefault("'By sacrificing lots of souls, you have made a weapon to slay gods.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Estoque de los dioses");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Al sacrificar muchas almas, tu has hecho una arma que puede matar los dioses.'");
        }

		public override void SetDefaults()
		{
			item.damage = 255;
			item.melee = true;
			item.width = 124;
			item.height = 124;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 3;
			item.knockBack = 1;
            item.value = 524500;
			item.rare = 11; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 50);
			recipe.AddIngredient(ItemID.SoulofSight, 50);
			recipe.AddIngredient(ItemID.SoulofFright, 50);
			recipe.AddIngredient(3459, 20);
			recipe.AddIngredient(3458, 20);
			recipe.AddIngredient(3457, 20);
			recipe.AddIngredient(3456, 20);
			recipe.AddIngredient(ItemID.WoodenSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
