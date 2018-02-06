using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
    public class HeavyEdge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Edge");
            Tooltip.SetDefault("'Iron is weak.'");
            DisplayName.AddTranslation(GameCulture.Spanish, "Espada del acero");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Todo de hierro es débil.'");
        }

        public override void SetDefaults()
        {
            item.width = 58;
            item.height = 58;
            item.useStyle = 1;
            item.useAnimation = 23;
            item.useTime = 21;
            item.damage = 34;
            item.knockBack = 5.5f;
            item.autoReuse = true;
            item.rare = 11;
            item.melee = true;
            item.value = 60000;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SuperSteel", 4);
            recipe.AddIngredient(19, 20);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}