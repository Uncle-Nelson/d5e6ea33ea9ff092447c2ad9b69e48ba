using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dragging;
using ScheduleOne.Equipping;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x02000835 RID: 2101
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Draggable))]
	[RequireComponent(typeof(PhysicsDamageable))]
	public class TrashItem : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x000F346D File Offset: 0x000F166D
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x000F3475 File Offset: 0x000F1675
		public Guid GUID { get; protected set; }

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x000F347E File Offset: 0x000F167E
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x000F3486 File Offset: 0x000F1686
		public Property CurrentProperty { get; protected set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x000F3490 File Offset: 0x000F1690
		public string SaveFolderName
		{
			get
			{
				return "Trash_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x000F34C4 File Offset: 0x000F16C4
		public string SaveFileName
		{
			get
			{
				return "Trash_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x000F34F6 File Offset: 0x000F16F6
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x000F34FE File Offset: 0x000F16FE
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x000F3507 File Offset: 0x000F1707
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x000F350F File Offset: 0x000F170F
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x000F3518 File Offset: 0x000F1718
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x000F3520 File Offset: 0x000F1720
		public bool HasChanged { get; set; }

		// Token: 0x060039A0 RID: 14752 RVA: 0x000F352C File Offset: 0x000F172C
		protected void Awake()
		{
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Trash"));
			this.RecheckPosition();
			base.InvokeRepeating("RecheckPosition", Random.Range(0f, 1f), 1f);
			this.SetPhysicsActive(false);
			this.Rigidbody.drag = 0.1f;
			this.Rigidbody.angularDrag = 0.1f;
			this.Rigidbody.interpolation = 1;
			this.Rigidbody.collisionDetectionMode = 0;
			this.Rigidbody.sleepThreshold = 0.01f;
			this.Draggable.onDragStart.AddListener(new UnityAction(delegate()
			{
				this.SetContinuousCollisionDetection();
			}));
			PhysicsDamageable physicsDamageable = base.GetComponent<PhysicsDamageable>();
			if (physicsDamageable == null)
			{
				physicsDamageable = base.gameObject.AddComponent<PhysicsDamageable>();
			}
			PhysicsDamageable physicsDamageable2 = physicsDamageable;
			physicsDamageable2.onImpacted = (Action<Impact>)Delegate.Combine(physicsDamageable2.onImpacted, new Action<Impact>(delegate(Impact impact)
			{
				if (impact.ImpactForce > 0f)
				{
					this.SetContinuousCollisionDetection();
				}
			}));
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x000F361C File Offset: 0x000F181C
		protected void Start()
		{
			this.InitializeSaveable();
			TimeManager.onSleepEnd = (Action<int>)Delegate.Combine(TimeManager.onSleepEnd, new Action<int>(this.SleepEnd));
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			this.Draggable.onHovered.AddListener(new UnityAction(this.Hovered));
			this.Draggable.onInteracted.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x000F36B0 File Offset: 0x000F18B0
		protected void OnValidate()
		{
			if (this.Rigidbody == null)
			{
				this.Rigidbody = base.GetComponent<Rigidbody>();
			}
			if (this.Draggable == null)
			{
				this.Draggable = base.GetComponent<Draggable>();
			}
			if (this.colliders == null || this.colliders.Length == 0)
			{
				this.colliders = base.GetComponentsInChildren<Collider>();
			}
			if (base.GetComponent<ImpactSoundEntity>() == null)
			{
				base.gameObject.AddComponent<ImpactSoundEntity>();
			}
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x000F3728 File Offset: 0x000F1928
		protected void MinPass()
		{
			if (this == null || base.transform == null)
			{
				return;
			}
			if (Time.time - this.timeOnPhysicsEnabled > 30f)
			{
				float num = Vector3.SqrMagnitude(PlayerSingleton<PlayerMovement>.Instance.transform.position - base.transform.position);
				this.SetCollidersEnabled(num < 900f);
			}
			if (base.transform.position.y < -100f && InstanceFinder.IsServer)
			{
				Console.LogWarning("Trash item fell below the world. Destroying.", null);
				this.DestroyTrash();
			}
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x000045B1 File Offset: 0x000027B1
		protected void SleepEnd(int mins)
		{
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x000F37C4 File Offset: 0x000F19C4
		protected void Hovered()
		{
			if (Equippable_TrashGrabber.IsEquipped && this.CanGoInContainer)
			{
				if (Equippable_TrashGrabber.Instance.GetCapacity() > 0)
				{
					this.Draggable.IntObj.SetMessage("Pick up");
					this.Draggable.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
					return;
				}
				this.Draggable.IntObj.SetMessage("Bin is full");
				this.Draggable.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
			}
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x000F383A File Offset: 0x000F1A3A
		protected void Interacted()
		{
			if (Equippable_TrashGrabber.IsEquipped && this.CanGoInContainer && Equippable_TrashGrabber.Instance.GetCapacity() > 0)
			{
				Equippable_TrashGrabber.Instance.PickupTrash(this);
			}
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x000F3864 File Offset: 0x000F1A64
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
			string text = this.GUID.ToString();
			if (text[text.Length - 1] != '1')
			{
				text = text.Substring(0, text.Length - 1) + "1";
			}
			else
			{
				text = text.Substring(0, text.Length - 1) + "2";
			}
			this.Draggable.SetGUID(new Guid(text));
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x000F38EC File Offset: 0x000F1AEC
		public void SetVelocity(Vector3 velocity)
		{
			this.Rigidbody.velocity = velocity;
			this.HasChanged = true;
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x000F3901 File Offset: 0x000F1B01
		public void DestroyTrash()
		{
			NetworkSingleton<TrashManager>.Instance.DestroyTrash(this);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x000F3910 File Offset: 0x000F1B10
		public virtual void Deinitialize()
		{
			TimeManager.onSleepEnd = (Action<int>)Delegate.Remove(TimeManager.onSleepEnd, new Action<int>(this.SleepEnd));
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x000F3964 File Offset: 0x000F1B64
		private void OnDestroy()
		{
			TimeManager.onSleepEnd = (Action<int>)Delegate.Remove(TimeManager.onSleepEnd, new Action<int>(this.SleepEnd));
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x000F39BE File Offset: 0x000F1BBE
		private void RecheckPosition()
		{
			if (Vector3.Distance(this.lastPosition, base.transform.position) > 1f)
			{
				this.lastPosition = base.transform.position;
				this.HasChanged = true;
				this.RecheckProperty();
			}
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x000F39FC File Offset: 0x000F1BFC
		public virtual TrashItemData GetData()
		{
			return new TrashItemData(this.ID, this.GUID.ToString(), base.transform.position, base.transform.rotation);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x000F3A3E File Offset: 0x000F1C3E
		public virtual string GetSaveString()
		{
			return this.GetData().GetJson(true);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x000022C9 File Offset: 0x000004C9
		public virtual bool ShouldSave()
		{
			return true;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x000F3A4C File Offset: 0x000F1C4C
		private void RecheckProperty()
		{
			if (this.CurrentProperty != null && this.CurrentProperty.DoBoundsContainPoint(base.transform.position))
			{
				return;
			}
			this.CurrentProperty = null;
			for (int i = 0; i < Property.OwnedProperties.Count; i++)
			{
				if (Vector3.Distance(base.transform.position, Property.OwnedProperties[i].BoundingBox.transform.position) <= 25f && Property.OwnedProperties[i].DoBoundsContainPoint(base.transform.position))
				{
					this.CurrentProperty = Property.OwnedProperties[i];
					return;
				}
			}
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x000F3AFC File Offset: 0x000F1CFC
		public void SetContinuousCollisionDetection()
		{
			this.Rigidbody.collisionDetectionMode = 1;
			this.SetPhysicsActive(true);
			base.CancelInvoke("SetDiscreteCollisionDetection");
			base.Invoke("SetDiscreteCollisionDetection", 60f);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x000F3B2C File Offset: 0x000F1D2C
		public void SetDiscreteCollisionDetection()
		{
			if (this.Rigidbody == null)
			{
				return;
			}
			this.SetPhysicsActive(false);
			this.Rigidbody.collisionDetectionMode = 0;
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x000F3B50 File Offset: 0x000F1D50
		public void SetPhysicsActive(bool active)
		{
			this.Rigidbody.isKinematic = !active;
			this.SetCollidersEnabled(active);
			if (active)
			{
				this.timeOnPhysicsEnabled = Time.time;
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x000F3B78 File Offset: 0x000F1D78
		public void SetCollidersEnabled(bool enabled)
		{
			if (this.collidersEnabled == enabled)
			{
				return;
			}
			this.collidersEnabled = enabled;
			for (int i = 0; i < this.colliders.Length; i++)
			{
				this.colliders[i].enabled = true;
			}
			if (!this.collidersEnabled)
			{
				this.Rigidbody.isKinematic = true;
			}
		}

		// Token: 0x04002991 RID: 10641
		public const float POSITION_CHANGE_THRESHOLD = 1f;

		// Token: 0x04002992 RID: 10642
		public const float LINEAR_DRAG = 0.1f;

		// Token: 0x04002993 RID: 10643
		public const float ANGULAR_DRAG = 0.1f;

		// Token: 0x04002994 RID: 10644
		public const float MIN_Y = -100f;

		// Token: 0x04002995 RID: 10645
		public const int INTERACTION_PRIORITY = 5;

		// Token: 0x04002996 RID: 10646
		public Rigidbody Rigidbody;

		// Token: 0x04002997 RID: 10647
		public Draggable Draggable;

		// Token: 0x04002998 RID: 10648
		[Header("Settings")]
		public string ID = "trashid";

		// Token: 0x04002999 RID: 10649
		[Range(0f, 5f)]
		public int Size = 2;

		// Token: 0x0400299A RID: 10650
		[Range(0f, 10f)]
		public int SellValue = 1;

		// Token: 0x0400299B RID: 10651
		public bool CanGoInContainer = true;

		// Token: 0x0400299C RID: 10652
		public Collider[] colliders;

		// Token: 0x0400299F RID: 10655
		private Vector3 lastPosition = Vector3.zero;

		// Token: 0x040029A0 RID: 10656
		public Action<TrashItem> onDestroyed;

		// Token: 0x040029A1 RID: 10657
		private bool collidersEnabled = true;

		// Token: 0x040029A2 RID: 10658
		private float timeOnPhysicsEnabled;
	}
}
