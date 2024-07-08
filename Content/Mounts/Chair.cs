using Terraria;
using Terraria.ModLoader;

namespace TheFishingChair.Content.Mounts
{
	public class Chair : ModMount
	{
		public override void SetStaticDefaults()
		{
			MountData.buff = ModContent.BuffType<Buffs.ChairMountBuff>();

			MountData.jumpHeight = 0;

			MountData.runSpeed = 0f;
			MountData.dashSpeed = 0f;
			
			MountData.totalFrames = 1; 
			MountData.playerYOffsets = [15];

			MountData.playerHeadOffset = 15;
			MountData.bodyFrame = 1;

			MountData.xOffset = -10;
			if (!Main.dedServ) {
				MountData.textureWidth = MountData.backTexture.Width();
				MountData.textureHeight = MountData.backTexture.Height();
			}
		}
	}
}
