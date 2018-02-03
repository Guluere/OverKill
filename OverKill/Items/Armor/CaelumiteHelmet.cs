using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class CaelumiteHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caelumite Helmet");
            DisplayName.AddTranslation(GameCulture.Spanish, "Casco de caelumita");
            Tooltip.SetDefault("'Warrior of the skies.'");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 64800;
            item.rare = 3;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("CaelumiteBreastplate") && legs.type == mod.ItemType("CaelumiteLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.GetModPlayer<OverkillPlayer>().runIncrease = true;
            player.jumpBoost = 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CaelumiteBar", 12);
            recipe.AddIngredient(ItemID.Leather, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

