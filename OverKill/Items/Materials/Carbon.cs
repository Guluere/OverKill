using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Materials
{
    public class Carbon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carbon");
            Tooltip.SetDefault("'Still brighter than your future.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Carbón");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Aún más brillante que tu futuro.'");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = 2;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 50);
            recipe.AddTile(17);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
