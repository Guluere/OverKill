using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CaelumiteBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caelumite Breastplate");
            DisplayName.AddTranslation(GameCulture.Spanish, "Peto de caelumita");
			Tooltip.SetDefault("Soldier of the heavens");
            Tooltip.AddTranslation(GameCulture.Spanish, "Soldado de los cielos");
		}
		
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 22800; //This should be correct
			item.rare = 3;
			item.defense = 8;
		}
		
		/* public override void UpdateEquip(Player player)
		{
			player.AddBuff[BuffID.Spelunker] = true;
		}*/ //Check this first before addition.
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CaelumiteBar", 24);
			recipe.AddIngredient(ItemID.Leather, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}