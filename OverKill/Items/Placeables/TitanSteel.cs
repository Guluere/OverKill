using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Placeables
{
    public class TitanSteel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titan Steel");
            Tooltip.SetDefault("'The Leviathan's Armor.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Titán Acero");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Es la armadura del leviatán.'");
        }

        public override void SetDefaults()
        {
            item.width = 52;
            item.height = 34;
            item.value = 225000;
            item.rare = 6;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("TitanSteelTile");
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SuperSteel"), 10);
            recipe.AddIngredient(1198, 30);
            recipe.AddTile(133);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
