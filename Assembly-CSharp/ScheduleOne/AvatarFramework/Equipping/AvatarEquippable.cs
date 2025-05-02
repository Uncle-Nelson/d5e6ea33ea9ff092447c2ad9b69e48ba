using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000976 RID: 2422
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x060041E0 RID: 16864 RVA: 0x00114630 File Offset: 0x00112830
		[Button]
		public void RecalculateAssetPath()
		{
			this.AssetPath = AssetPathUtility.GetResourcesPath(base.gameObject);
			string[] array = this.AssetPath.Split('/', StringSplitOptions.None);
			array[array.Length - 1] = base.gameObject.name;
			this.AssetPath = string.Join("/", array);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00114680 File Offset: 0x00112880
		protected virtual void Awake()
		{
			if (this.AssetPath == string.Empty)
			{
				Console.LogWarning(base.gameObject.name + " does not have an assetpath!", null);
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x001146B0 File Offset: 0x001128B0
		public virtual void Equip(Avatar _avatar)
		{
			this.avatar = _avatar;
			if (this.Hand == AvatarEquippable.EHand.Right)
			{
				base.transform.SetParent(this.avatar.Anim.RightHandContainer);
			}
			else
			{
				base.transform.SetParent(this.avatar.Anim.LeftHandContainer);
			}
			this.PositionAnimationModel();
			this.InitializeAnimation();
			Player componentInParent = this.avatar.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent.IsOwner && !componentInParent.avatarVisibleToLocalPlayer)
			{
				LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Invisible"));
			}
			Collider[] componentsInChildren = base.GetComponentsInChildren<Collider>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].isTrigger = true;
			}
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00114769 File Offset: 0x00112969
		public virtual void InitializeAnimation()
		{
			if (this.TriggerType == AvatarEquippable.ETriggerType.Trigger)
			{
				this.SetTrigger(this.AnimationTrigger);
				return;
			}
			this.SetBool(this.AnimationTrigger, true);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x0011478D File Offset: 0x0011298D
		public virtual void Unequip()
		{
			if (this.TriggerType == AvatarEquippable.ETriggerType.Trigger)
			{
				this.SetTrigger("EndAction");
			}
			else
			{
				this.SetBool(this.AnimationTrigger, false);
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x001147BC File Offset: 0x001129BC
		private void PositionAnimationModel()
		{
			Transform transform = (this.Hand == AvatarEquippable.EHand.Right) ? this.avatar.Anim.RightHandAlignmentPoint : this.avatar.Anim.LeftHandAlignmentPoint;
			base.transform.rotation = transform.rotation * (Quaternion.Inverse(this.AlignmentPoint.rotation) * base.transform.rotation);
			base.transform.position = transform.position + (base.transform.position - this.AlignmentPoint.position);
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x0011485C File Offset: 0x00112A5C
		protected void SetTrigger(string anim)
		{
			if (this.avatar.GetComponentInParent<Player>() != null)
			{
				this.avatar.GetComponentInParent<Player>().SetAnimationTrigger(anim);
				return;
			}
			if (this.avatar.GetComponentInParent<NPC>() != null)
			{
				this.avatar.GetComponentInParent<NPC>().SetAnimationTrigger(anim);
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001148B4 File Offset: 0x00112AB4
		protected void SetBool(string anim, bool val)
		{
			if (this.avatar.GetComponentInParent<Player>() != null)
			{
				this.avatar.GetComponentInParent<Player>().SetAnimationBool(anim, val);
				return;
			}
			if (this.avatar.GetComponentInParent<NPC>() != null)
			{
				this.avatar.GetComponentInParent<NPC>().SetAnimationBool(anim, val);
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0011490C File Offset: 0x00112B0C
		protected void ResetTrigger(string anim)
		{
			if (this.avatar.GetComponentInParent<Player>() != null)
			{
				this.avatar.GetComponentInParent<Player>().ResetAnimationTrigger(anim);
				return;
			}
			if (this.avatar.GetComponentInParent<NPC>() != null)
			{
				this.avatar.GetComponentInParent<NPC>().ResetAnimationTrigger(anim);
			}
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ReceiveMessage(string message, object parameter)
		{
		}

		// Token: 0x04002F62 RID: 12130
		[Header("Settings")]
		public Transform AlignmentPoint;

		// Token: 0x04002F63 RID: 12131
		[Range(0f, 1f)]
		public float Suspiciousness;

		// Token: 0x04002F64 RID: 12132
		public AvatarEquippable.EHand Hand = AvatarEquippable.EHand.Right;

		// Token: 0x04002F65 RID: 12133
		public AvatarEquippable.ETriggerType TriggerType;

		// Token: 0x04002F66 RID: 12134
		public string AnimationTrigger = "RightArm_Hold_ClosedHand";

		// Token: 0x04002F67 RID: 12135
		public string AssetPath = string.Empty;

		// Token: 0x04002F68 RID: 12136
		protected Avatar avatar;

		// Token: 0x02000977 RID: 2423
		public enum ETriggerType
		{
			// Token: 0x04002F6A RID: 12138
			Trigger,
			// Token: 0x04002F6B RID: 12139
			Bool
		}

		// Token: 0x02000978 RID: 2424
		public enum EHand
		{
			// Token: 0x04002F6D RID: 12141
			Left,
			// Token: 0x04002F6E RID: 12142
			Right
		}
	}
}
