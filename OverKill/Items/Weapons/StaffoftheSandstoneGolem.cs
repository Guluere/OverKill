using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
    public class SummonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Staff of the Sand Guardian");
            Tooltip.SetDefault("'Summons a baby Sandstone Guardian. But I think it wants its dad'");
            DisplayName.AddTranslation(GameCulture.Spanish, "...");
            DisplayName.AddTranslation(GameCulture.French, "...");
            Tooltip.AddTranslation(GameCulture.Spanish, "...");
            Tooltip.AddTranslation(GameCulture.French, "...");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.summon = true;
            item.mana = 50;
            item.width = 50;
            item.height = 50;
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item4;
            item.shoot = mod.ProjectileType("SandstoneGolem");
            item.shootSpeed = 10f;
            item.buffType = mod.BuffType("SandstoneGolem");
            item.buffTime = 3600;
        }
    }
}