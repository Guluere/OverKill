using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OverKill.Tiles
{
    public class CaelumiteBrick : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            soundType = 21;
            minPick = 65;
            mineResist = 1f;
            drop = mod.ItemType("CaelumiteBrick");
            AddMapEntry(new Color(0, 150, 220));
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0f;
            g = 0.7f;
            b = 0.8f;
        }
    }
}