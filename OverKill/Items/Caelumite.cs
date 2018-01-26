﻿using Microsoft.Xna.Framework;
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
            DisplayName.AddTranslation(GameCulture.Spanish, "Caelumita");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = 950;
            item.rare = 2;
        }
    }
}
