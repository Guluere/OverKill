using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Materials
{
    public class TitanSteel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titan Steel");
            Tooltip.SetDefault("'Leviathan's Plate, you must be mad.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Titan Steel");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Plato de Leviathan, debes estar enojado.'");
        }

        public override void SetDefaults()
        {
            item.width = 52;
            item.height = 34;
            item.value = 345000;
            item.rare = 6;
            item.maxStack = 99;
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
