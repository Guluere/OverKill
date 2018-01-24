using Terraria.ModLoader;

namespace OverKill
{
	class OverKill : Mod
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
	}
}
