using Terraria.ID;
using Terraria.ModLoader;

namespace TheFishingChair.Content.Items.Mounts
{
	public class Chair: ModItem
	{
		public override void SetDefaults() {
			Item.mountType = ModContent.MountType<Content.Mounts.Chair>();
			Item.width = 64;
			Item.height = 64;
		}
		
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.WoodenChair)
				.AddIngredient(ItemID.Worm, 5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
	
}
