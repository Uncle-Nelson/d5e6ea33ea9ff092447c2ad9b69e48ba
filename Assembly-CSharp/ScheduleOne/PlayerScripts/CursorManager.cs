using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D6 RID: 1494
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x060024F6 RID: 9462 RVA: 0x00094F3A File Offset: 0x0009313A
		protected override void Awake()
		{
			base.Awake();
			this.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00094F4C File Offset: 0x0009314C
		public void SetCursorAppearance(CursorManager.ECursorType type)
		{
			CursorManager.CursorConfig cursorConfig = this.Cursors.Find((CursorManager.CursorConfig x) => x.CursorType == type);
			Cursor.SetCursor(cursorConfig.Texture, cursorConfig.HotSpot, CursorMode.Auto);
		}

		// Token: 0x04001B82 RID: 7042
		[Header("References")]
		public List<CursorManager.CursorConfig> Cursors = new List<CursorManager.CursorConfig>();

		// Token: 0x020005D7 RID: 1495
		public enum ECursorType
		{
			// Token: 0x04001B84 RID: 7044
			Default,
			// Token: 0x04001B85 RID: 7045
			Finger,
			// Token: 0x04001B86 RID: 7046
			OpenHand,
			// Token: 0x04001B87 RID: 7047
			Grab,
			// Token: 0x04001B88 RID: 7048
			Scissors
		}

		// Token: 0x020005D8 RID: 1496
		[Serializable]
		public class CursorConfig
		{
			// Token: 0x04001B89 RID: 7049
			public CursorManager.ECursorType CursorType;

			// Token: 0x04001B8A RID: 7050
			public Texture2D Texture;

			// Token: 0x04001B8B RID: 7051
			public Vector2 HotSpot;
		}
	}
}
