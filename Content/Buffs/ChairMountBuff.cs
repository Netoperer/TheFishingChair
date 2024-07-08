using Terraria;
using Terraria.ModLoader;
using TheFishingChair.Content.Mounts;

namespace TheFishingChair.Content.Buffs
{
	public class ChairMountBuff : ModBuff
	{
		public override void SetStaticDefaults() {
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Chair>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
