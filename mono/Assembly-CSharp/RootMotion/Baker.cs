using System;
using UnityEngine;
using UnityEngine.Playables;

namespace RootMotion
{
	// Token: 0x02000005 RID: 5
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	public abstract class Baker : MonoBehaviour
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000228F File Offset: 0x0000048F
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page3.html");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000229B File Offset: 0x0000049B
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_baker.html");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022A7 File Offset: 0x000004A7
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022B3 File Offset: 0x000004B3
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000022BF File Offset: 0x000004BF
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000022C7 File Offset: 0x000004C7
		public bool isBaking { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000022D8 File Offset: 0x000004D8
		public float bakingProgress { get; private set; }

		// Token: 0x06000014 RID: 20
		protected abstract Transform GetCharacterRoot();

		// Token: 0x06000015 RID: 21
		protected abstract void OnStartBaking();

		// Token: 0x06000016 RID: 22
		protected abstract void OnSetLoopFrame(float time);

		// Token: 0x06000017 RID: 23
		protected abstract void OnSetCurves(ref AnimationClip clip);

		// Token: 0x06000018 RID: 24
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000022E1 File Offset: 0x000004E1
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000022E9 File Offset: 0x000004E9
		private protected float clipLength { protected get; private set; }

		// Token: 0x0600001B RID: 27 RVA: 0x000022F2 File Offset: 0x000004F2
		public void BakeClip()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022F4 File Offset: 0x000004F4
		public void StartBaking()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022F6 File Offset: 0x000004F6
		public void StopBaking()
		{
		}

		// Token: 0x04000006 RID: 6
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate = 30;

		// Token: 0x04000007 RID: 7
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError = 0.01f;

		// Token: 0x04000008 RID: 8
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Baker.Mode mode;

		// Token: 0x04000009 RID: 9
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips = new AnimationClip[0];

		// Token: 0x0400000A RID: 10
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates = new string[0];

		// Token: 0x0400000B RID: 11
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder = "Assets";

		// Token: 0x0400000C RID: 12
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName = "_Baked";

		// Token: 0x0400000D RID: 13
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName = "Baked Clip";

		// Token: 0x04000010 RID: 16
		[HideInInspector]
		public Animator animator;

		// Token: 0x04000011 RID: 17
		[HideInInspector]
		public PlayableDirector director;

		// Token: 0x04000012 RID: 18
		public Baker.BakerDelegate OnStartClip;

		// Token: 0x04000013 RID: 19
		public Baker.BakerDelegate OnUpdateClip;

		// Token: 0x04000014 RID: 20
		[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
		public bool inheritClipSettings;

		// Token: 0x04000015 RID: 21
		[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
		public Baker.ClipSettings clipSettings;

		// Token: 0x04000017 RID: 23
		protected bool addLoopFrame;

		// Token: 0x020000CB RID: 203
		[Serializable]
		public enum Mode
		{
			// Token: 0x040005E4 RID: 1508
			AnimationClips,
			// Token: 0x040005E5 RID: 1509
			AnimationStates,
			// Token: 0x040005E6 RID: 1510
			PlayableDirector,
			// Token: 0x040005E7 RID: 1511
			Realtime
		}

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x0600065D RID: 1629
		public delegate void BakerDelegate(AnimationClip clip, float time);

		// Token: 0x020000CD RID: 205
		[Serializable]
		public class ClipSettings
		{
			// Token: 0x040005E8 RID: 1512
			public bool loopTime;

			// Token: 0x040005E9 RID: 1513
			public bool loopBlend;

			// Token: 0x040005EA RID: 1514
			public float cycleOffset;

			// Token: 0x040005EB RID: 1515
			public bool loopBlendOrientation;

			// Token: 0x040005EC RID: 1516
			public Baker.ClipSettings.BasedUponRotation basedUponRotation;

			// Token: 0x040005ED RID: 1517
			public float orientationOffsetY;

			// Token: 0x040005EE RID: 1518
			public bool loopBlendPositionY;

			// Token: 0x040005EF RID: 1519
			public Baker.ClipSettings.BasedUponY basedUponY;

			// Token: 0x040005F0 RID: 1520
			public float level;

			// Token: 0x040005F1 RID: 1521
			public bool loopBlendPositionXZ;

			// Token: 0x040005F2 RID: 1522
			public Baker.ClipSettings.BasedUponXZ basedUponXZ;

			// Token: 0x040005F3 RID: 1523
			public bool mirror;

			// Token: 0x02000133 RID: 307
			[Serializable]
			public enum BasedUponRotation
			{
				// Token: 0x040008A4 RID: 2212
				Original,
				// Token: 0x040008A5 RID: 2213
				BodyOrientation
			}

			// Token: 0x02000134 RID: 308
			[Serializable]
			public enum BasedUponY
			{
				// Token: 0x040008A7 RID: 2215
				Original,
				// Token: 0x040008A8 RID: 2216
				CenterOfMass,
				// Token: 0x040008A9 RID: 2217
				Feet
			}

			// Token: 0x02000135 RID: 309
			[Serializable]
			public enum BasedUponXZ
			{
				// Token: 0x040008AB RID: 2219
				Original,
				// Token: 0x040008AC RID: 2220
				CenterOfMass
			}
		}
	}
}
