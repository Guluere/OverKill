using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
    public class SteelMountainTrue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The True Sword of Steel");
            DisplayName.AddTranslation(GameCulture.Spanish, "Verdadera espada de acero");
            DisplayName.AddTranslation(GameCulture.French, "");
            Tooltip.SetDefault("'This sword was first created in the forges of the titans'");
            Tooltip.AddTranslation(GameCulture.Spanish, "");
            Tooltip.AddTranslation(GameCulture.French, "");
        }

        public override void SetDefaults()
        {
            item.damage = 140;
            item.melee = true;
            item.width = 122;
            item.height = 126;
            item.useTime = 35;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 7.5f;
            item.rare = 5;
            item.value = 53000;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TitanSteel", 35);
            recipe.AddIngredient(null, "CaelumiteBar", 30);
            recipe.AddTile(TileID.LunarMonolith);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}