using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverKill
{
    public class OverkillPlayer : ModPlayer
    {
        public bool runIncrease = false;
        public override void PostUpdateMiscEffects()
        {
            if (runIncrease)
            {
                player.moveSpeed += 10f;
            }
        }
        public override void ResetEffects()
        {
            runIncrease = false;
        }
    }
}
