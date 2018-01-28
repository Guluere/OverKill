using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Materials
{
    public class SuperSteel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super steel");
            Tooltip.SetDefault("'Fire and Steel, Blood and Iron.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Super steel");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Fuego y Acero, Sangre y Hierro.'");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.value = 12000;
            item.rare = 3;
            item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SuperSteelTile");
			item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Carbon"),10);
            recipe.AddRecipeGroup("IronBar", 30);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Carbon"),6);
            recipe.AddRecipeGroup("IronBar", 50);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
