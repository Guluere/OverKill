using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Materials
{
    public class CaelumiteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caelumite Bar");
            Tooltip.SetDefault("'Humid and light.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Lingote de la caelumita");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Esta humedo y es luz.'");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.value = 5400;
            item.rare = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Caelumite"),3);
            recipe.AddIngredient(ItemID.Cloud, 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Caelumite"), 3);
            recipe.AddIngredient(ItemID.RainCloud, 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
