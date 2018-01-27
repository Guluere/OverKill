using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace OverKill.Items.Weapons
{
    public class Aeroblast : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aeroblast");
            Tooltip.SetDefault("Fires balls of dense humidity onto your enemy.");
            DisplayName.AddTranslation(GameCulture.Spanish, "Aero-ráfaga");
            Tooltip.AddTranslation(GameCulture.Spanish, "Dispara esferas de la humedad para tú enemigo.");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 23;
            item.magic = true;
            item.mana = 20;
            item.width = 28;
            item.height = 30;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 35400;
            item.rare = 5;
            item.shoot = mod.ProjectileType("Aeroblast");
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shootSpeed = 16f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 6; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.006f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CaelumiteBar"), 7);
            recipe.AddIngredient(ItemID.Cloud, 5);
            recipe.AddIngredient(ItemID.WaterBolt);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}