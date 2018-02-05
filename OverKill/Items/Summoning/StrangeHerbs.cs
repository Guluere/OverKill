using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Summoning
{
    public class StrangeHerbs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Strange Herbs");
            Tooltip.SetDefault("'These will relax you!'");
            DisplayName.AddTranslation(GameCulture.Spanish, "");
            DisplayName.AddTranslation(GameCulture.French, "");
            Tooltip.AddTranslation(GameCulture.Spanish, "");
            Tooltip.AddTranslation(GameCulture.French, "");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 44;
            item.maxStack = 20;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 40;
            item.useTime = 45;
            item.consumable = true;
            item.createTile = mod.TileType("StrangeHerbTile");
            item.placeStyle = 0;
            item.useStyle = 4;
        }

        public override bool CanUseItem(Player player)
        {
            // Does NPC Exist?
            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("HerbTrader"));

            return !alreadySpawned;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("HerbTrader"));
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}