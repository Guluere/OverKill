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
                player.moveSpeed += 0.1f;
            }
        }
        public override void ResetEffects()
        {
            runIncrease = false;
        }
    }
}
