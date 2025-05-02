using System;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200039A RID: 922
	public class ShopManagerLoader : Loader
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x0005C71C File Offset: 0x0005A91C
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			ShopLoader loader = new ShopLoader();
			string[] files = Directory.GetFiles(mainPath);
			for (int i = 0; i < files.Length; i++)
			{
				Console.Log("Loading shop file: " + files[i], null);
				new LoadRequest(files[i], loader);
			}
		}
	}
}
