using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill.Items.Weapons
{
	public class FeatherSword : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 90;
			item.height = 90;
			item.scale = 1.2f;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.damage = 34;
			item.knockBack = 4.5f;
			item.autoReuse = false;
			item.useTurn = false;
			item.rare = 11;
			item.melee = true;
			item.value = Item.sellPrice(0, 12, 0, 0);
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileID.HeartySlash;
			item.shootSpeed = 0.5f;
			projOnSwing = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CaelumiteBar", 8);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}