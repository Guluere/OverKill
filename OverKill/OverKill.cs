using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;

namespace OverKill
{
	public class OverKill : Mod
	{
		public OverKill()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 1);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Amethyst);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 3);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Topaz);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 5);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Sapphire);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 6);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Emerald);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 8);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Ruby);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Carbon", 10);
            recipe.AddIngredient(ItemID.LavaBucket);
            recipe.AddTile(null, "CompressorTile");
            recipe.SetResult(ItemID.Diamond);
            recipe.AddRecipe();
        }
    }
}
