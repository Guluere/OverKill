using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
 
namespace OverKill.Items
{
    public class Caelumite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caelumite Brick");
            DisplayName.AddTranslation(GameCulture.Spanish, "Ladrillo de Caelumita");
        }
 
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CaelumiteBrick");
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3, 2);
            recipe.AddIngredient(mod.ItemType("Caelumite"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
    }
}