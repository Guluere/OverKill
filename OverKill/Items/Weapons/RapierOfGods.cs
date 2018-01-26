using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
	public class RapierOfGods : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'By sacrificing lots of souls, you have made a weapon to slay gods.'");
            Tooltip.AddTranslation(GameCulture.Spanish, "'Al sacrificar muchas almas, tu has hecho una arma que puede matar los dioses.'");
        }

		public override void SetDefaults()
		{
			item.damage = 255;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 90;            //Weapon's texture's width
			item.height = 90;           //Weapon's texture's height
			item.useTime = 5;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 5;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 3;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 1;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(gold: 20);           //The value of the weapon
			item.rare = 11;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 50);
			recipe.AddIngredient(ItemID.SoulofSight, 50);
			recipe.AddIngredient(ItemID.SoulofFright, 50);
			recipe.AddIngredient(3459, 20);
			recipe.AddIngredient(3458, 20);
			recipe.AddIngredient(3457, 20);
			recipe.AddIngredient(3456, 20);
			recipe.AddIngredient(ItemID.WoodenSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
