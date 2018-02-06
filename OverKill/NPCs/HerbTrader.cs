using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace OverKill.NPCs
{
    [AutoloadHead]
    public class HerbTrader : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "OverKill/NPCs/HerbTrader";
            }
        }

        public override string[] AltTextures
        {
            get
            {
                return new string[] { "OverKill/NPCs/HerbTrader" };
            }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brahmi");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 60;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (player.active)
                {
                    for (int j = 0; j < player.inventory.Length; j++)
                    {
                        if (player.inventory[j].type == mod.ItemType("StrangeHerbs"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            int score = 0;
            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {
                    int type = Main.tile[x, y].type;
                    if (type == (TileID.Chairs) || type == (TileID.Tables) || type == (TileID.WorkBenches) || type == (TileID.Beds) || type == (TileID.OpenDoor) || type == (TileID.ClosedDoor))
                    {
                        score++;
                    }
                }
            }
            return score >= (right - left) * (bottom - top) / 2;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Borage";
                case 1:
                    return "Artichoke";
                case 2:
                    return "Betony";
                default:
                    return "Brahmi";
            }
        }

        public override string GetChat()
        {
            int dryad = NPC.FindFirstNPC(NPCID.Dryad);
            if (dryad >= 0 && Main.rand.Next(4) == 0)
            {
                return "Can you please tell " + Main.npc[dryad].GivenName + " that my herbs are more experiencing?";
            }
            else
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        return "It's 420";
                    case 1:
                        return "I do some stuff to my herbs that keep me chill";
                    default:
                        return "Herb is the healing of a nation, alcohol is the destruction";
                }
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Lang.inter[28].Value;
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.BottledWater);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.DoubleCod);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Moonglow);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Daybloom);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Deathweed);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.RottenChunk);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Blinkroot);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Shiverthorn);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Cobweb);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Vertebrae);
            nextSlot++;
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }
    }
}