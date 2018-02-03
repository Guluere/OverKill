using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CaelumiteLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caelumite Leggings");
			Tooltip.SetDefault("To be changed"); //This needs to be changed
		}
		
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 3;
			item.defense = 9;
		}
		
		public override void UpdateEquip(Player player)
		{
			//Need to find out what to put here
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CaelumiteBar", 16)'
			recipe.AddIngredient(ItemID.Leather, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}