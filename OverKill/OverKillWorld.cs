using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace OverKill
{
    public class OverKillWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Caelumite", delegate (GenerationProgress progress)
                {
                    progress.Message = "Blessing the sky with Caelumite";

                    for (int k = 0; k < (int)((Main.maxTilesX) * (Main.worldSurface - 100) * (0.05)); k++)
                    {
                        int SpawnTileY = WorldGen.genRand.Next(10, (int)(WorldGen.worldSurface) - 100);
                        int SpawnTileX = WorldGen.genRand.Next(10, Main.maxTilesX - 10);
                        bool onFloatingIsland = false;


                        for (int m = 1; m < 10; m++) // Check within a 10 tile radius for clouds
                        {
                            for (int n = 1; n < 10; n++)
                            {
                                Tile tile = Framing.GetTileSafely(SpawnTileX + n, SpawnTileY + m);
                                if (tile.active()) { if (tile.type == TileID.Cloud) { onFloatingIsland = true; } } 
                                tile = Framing.GetTileSafely(SpawnTileX - n, SpawnTileY - m);
                                if (tile.active()) { if (tile.type == TileID.Cloud) { onFloatingIsland = true; } }
                            }
                        }
                        if (onFloatingIsland) // If there are clouds within a 10 tile radius then generate the ore
                        {
                            WorldGen.TileRunner(SpawnTileX, SpawnTileY, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("Caelumite"), false, 0f, 0f, false, true);
                        }
                    }
                }));
            }
        }
    }
}