using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Placeables
{
    public class Compressor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Compressor");
            DisplayName.AddTranslation(GameCulture.Spanish, "...");
            DisplayName.AddTranslation(GameCulture.French, "...");
            Tooltip.SetDefault("Used to compress Items into other components");
            Tooltip.AddTranslation(GameCulture.Spanish, "...");
            Tooltip.AddTranslation(GameCulture.French, "...");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("Compressor");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SuperSteel", 25);
            recipe.AddIngredient(ItemID.CopperBar, 40);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.IronBar, 55);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}