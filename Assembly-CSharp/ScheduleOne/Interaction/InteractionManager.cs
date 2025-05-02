using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dragging;
using ScheduleOne.EntityFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Storage;
using ScheduleOne.UI;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000616 RID: 1558
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000A7E5F File Offset: 0x000A605F
		public LayerMask Interaction_SearchMask
		{
			get
			{
				return this.interaction_SearchMask;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000A7E67 File Offset: 0x000A6067
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x000A7E6F File Offset: 0x000A606F
		public bool CanDestroy { get; set; } = true;

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000A7E78 File Offset: 0x000A6078
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x000A7E80 File Offset: 0x000A6080
		public InteractableObject hoveredInteractableObject { get; protected set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000A7E89 File Offset: 0x000A6089
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x000A7E91 File Offset: 0x000A6091
		public InteractableObject hoveredValidInteractableObject { get; protected set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000A7E9A File Offset: 0x000A609A
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x000A7EA2 File Offset: 0x000A60A2
		public InteractableObject interactedObject { get; protected set; }

		// Token: 0x060028CC RID: 10444 RVA: 0x000A7EAC File Offset: 0x000A60AC
		protected override void Start()
		{
			base.Start();
			this.LoadInteractKey();
			Settings instance = Singleton<Settings>.Instance;
			instance.onInputsApplied = (Action)Delegate.Remove(instance.onInputsApplied, new Action(this.LoadInteractKey));
			Settings instance2 = Singleton<Settings>.Instance;
			instance2.onInputsApplied = (Action)Delegate.Combine(instance2.onInputsApplied, new Action(this.LoadInteractKey));
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000A7F11 File Offset: 0x000A6111
		protected override void OnDestroy()
		{
			if (Singleton<Settings>.InstanceExists)
			{
				Settings instance = Singleton<Settings>.Instance;
				instance.onInputsApplied = (Action)Delegate.Remove(instance.onInputsApplied, new Action(this.LoadInteractKey));
			}
			base.OnDestroy();
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000A7F48 File Offset: 0x000A6148
		private void LoadInteractKey()
		{
			string text;
			string controlPath;
			InputActionRebindingExtensions.GetBindingDisplayString(this.InteractInput.action, 0, ref text, ref controlPath, 0);
			this.InteractKey = Singleton<InputPromptsManager>.Instance.GetDisplayNameForControlPath(controlPath);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000A7F7D File Offset: 0x000A617D
		protected virtual void Update()
		{
			this.timeSinceLastInteractStart += Time.deltaTime;
			if (Singleton<GameInput>.InstanceExists)
			{
				this.CheckRightClick();
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000A7FA0 File Offset: 0x000A61A0
		protected virtual void LateUpdate()
		{
			if (!Singleton<GameInput>.InstanceExists)
			{
				return;
			}
			this.interactionDisplayEnabledThisFrame = false;
			this.CheckHover();
			if (this.hoveredInteractableObject != null)
			{
				this.hoveredInteractableObject.Hovered();
			}
			this.CheckInteraction();
			this.interaction_Canvas.enabled = (this.interactionDisplayEnabledThisFrame || this.activeWSlabels.Count > 0);
			this.interactionDisplay_Container.gameObject.SetActive(this.interactionDisplayEnabledThisFrame);
			if (!this.interactionDisplayEnabledThisFrame)
			{
				this.tempDisplayScale = 0.75f;
			}
			for (int i = 0; i < this.activeWSlabels.Count; i++)
			{
				this.activeWSlabels[i].RefreshDisplay();
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000A8058 File Offset: 0x000A6258
		protected virtual void CheckHover()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (Singleton<TaskManager>.InstanceExists && Singleton<TaskManager>.Instance.currentTask != null)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (Singleton<ObjectSelector>.InstanceExists && Singleton<ObjectSelector>.Instance.isSelecting)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (Singleton<GameplayMenu>.InstanceExists && Singleton<GameplayMenu>.Instance.IsOpen)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (PlayerSingleton<PlayerMovement>.Instance.currentVehicle != null)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerInventory>.Instance.equippable != null && !PlayerSingleton<PlayerInventory>.Instance.equippable.CanInteractWhenEquipped)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (Player.Local.IsSkating)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			if (NetworkSingleton<DragManager>.Instance.IsDragging)
			{
				this.hoveredInteractableObject = null;
				return;
			}
			Ray ray = default(Ray);
			EInteractionSearchType einteractionSearchType = this.interactionSearchType;
			if (einteractionSearchType != EInteractionSearchType.CameraForward)
			{
				if (einteractionSearchType != EInteractionSearchType.Mouse)
				{
					Console.LogWarning("EInteractionSearchType type not accounted for", null);
					return;
				}
				ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			}
			else
			{
				ray.origin = PlayerSingleton<PlayerCamera>.Instance.transform.position;
				ray.direction = PlayerSingleton<PlayerCamera>.Instance.transform.forward;
			}
			InteractableObject hoveredInteractableObject = this.hoveredInteractableObject;
			this.hoveredInteractableObject = null;
			RaycastHit[] array = Physics.SphereCastAll(ray, 0.075f, 5f, this.interaction_SearchMask, 2);
			RaycastHit[] array2 = Physics.RaycastAll(ray, 5f, this.interaction_SearchMask, 2);
			if (array.Length != 0)
			{
				Array.Sort<RaycastHit>(array, (RaycastHit x, RaycastHit y) => x.distance.CompareTo(y.distance));
				List<InteractableObject> list = new List<InteractableObject>();
				Dictionary<InteractableObject, RaycastHit> objectHits = new Dictionary<InteractableObject, RaycastHit>();
				foreach (RaycastHit value in array)
				{
					InteractableObject componentInParent = value.collider.GetComponentInParent<InteractableObject>();
					if (componentInParent == null)
					{
						bool flag = false;
						foreach (RaycastHit raycastHit in array2)
						{
							if (raycastHit.collider == value.collider)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
					else if (!list.Contains(componentInParent) && componentInParent != null && Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, value.point) <= componentInParent.MaxInteractionRange)
					{
						list.Add(componentInParent);
						objectHits.Add(componentInParent, value);
					}
				}
				list.Sort(delegate(InteractableObject x, InteractableObject y)
				{
					int num = y.Priority.CompareTo(x.Priority);
					if (num == 0)
					{
						return objectHits[x].distance.CompareTo(objectHits[y].distance);
					}
					return num;
				});
				for (int k = 0; k < list.Count; k++)
				{
					RaycastHit raycastHit2 = objectHits[list[k]];
					InteractableObject interactableObject = list[k];
					if (interactableObject == null)
					{
						bool flag2 = false;
						foreach (RaycastHit raycastHit3 in array2)
						{
							if (raycastHit3.collider == raycastHit2.collider)
							{
								flag2 = true;
								break;
							}
						}
						if (flag2)
						{
							break;
						}
					}
					else
					{
						if (!interactableObject.CheckAngleLimit(ray.origin))
						{
							interactableObject = null;
						}
						if (interactableObject != null && !interactableObject.enabled)
						{
							interactableObject = null;
						}
						if (interactableObject != null && Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, raycastHit2.point) <= interactableObject.MaxInteractionRange)
						{
							this.hoveredInteractableObject = interactableObject;
							if (interactableObject != hoveredInteractableObject)
							{
								this.tempDisplayScale = 1f;
								break;
							}
							break;
						}
					}
				}
			}
			if (this.DEBUG)
			{
				string str = "Hovered interactable object: ";
				InteractableObject hoveredInteractableObject2 = this.hoveredInteractableObject;
				Debug.Log(str + ((hoveredInteractableObject2 != null) ? hoveredInteractableObject2.name : null));
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000A8470 File Offset: 0x000A6670
		protected virtual void CheckInteraction()
		{
			this.hoveredValidInteractableObject = null;
			if (this.interactedObject != null && ((this.interactedObject._interactionType == InteractableObject.EInteractionType.Key_Press && !GameInput.GetButton(GameInput.ButtonCode.Interact)) || (this.interactedObject._interactionType == InteractableObject.EInteractionType.LeftMouse_Click && !GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))))
			{
				this.interactedObject.EndInteract();
				this.interactedObject = null;
			}
			if (this.hoveredInteractableObject == null)
			{
				return;
			}
			if (this.hoveredInteractableObject._interactionState == InteractableObject.EInteractableState.Disabled)
			{
				return;
			}
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				return;
			}
			this.hoveredValidInteractableObject = this.hoveredInteractableObject;
			if (GameInput.GetButton(GameInput.ButtonCode.Interact) && this.timeSinceLastInteractStart >= InteractionManager.interactCooldown && this.hoveredInteractableObject._interactionType == InteractableObject.EInteractionType.Key_Press && (!this.hoveredInteractableObject.RequiresUniqueClick || GameInput.GetButtonDown(GameInput.ButtonCode.Interact)))
			{
				this.timeSinceLastInteractStart = 0f;
				this.hoveredInteractableObject.StartInteract();
				this.interactedObject = this.hoveredInteractableObject;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && this.timeSinceLastInteractStart >= InteractionManager.interactCooldown && this.hoveredInteractableObject._interactionType == InteractableObject.EInteractionType.LeftMouse_Click && (!this.hoveredInteractableObject.RequiresUniqueClick || GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick)))
			{
				this.timeSinceLastInteractStart = 0f;
				this.hoveredInteractableObject.StartInteract();
				this.interactedObject = this.hoveredInteractableObject;
			}
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000A85C8 File Offset: 0x000A67C8
		protected virtual void CheckRightClick()
		{
			bool flag = false;
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (Singleton<TaskManager>.Instance.currentTask == null && (!PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped || (PlayerSingleton<PlayerInventory>.Instance.equippable != null && PlayerSingleton<PlayerInventory>.Instance.equippable.CanInteractWhenEquipped && PlayerSingleton<PlayerInventory>.Instance.equippable.CanPickUpWhenEquipped)) && PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0 && this.CanDestroy && GameInput.GetButton(GameInput.ButtonCode.SecondaryClick))
			{
				BuildableItem hoveredBuildableItem = this.GetHoveredBuildableItem();
				this.GetHoveredPallet();
				this.GetHoveredConstructable();
				if (hoveredBuildableItem != null)
				{
					string text;
					if (hoveredBuildableItem.CanBePickedUp(out text))
					{
						if (this.itemBeingDestroyed == hoveredBuildableItem)
						{
							this.destroyTime += Time.deltaTime;
						}
						this.itemBeingDestroyed = hoveredBuildableItem;
						if (this.destroyTime >= InteractionManager.timeToDestroy)
						{
							this.itemBeingDestroyed.PickupItem();
							this.destroyTime = 0f;
						}
						flag = true;
						Singleton<HUD>.Instance.ShowRadialIndicator(this.destroyTime / InteractionManager.timeToDestroy);
					}
					else
					{
						Singleton<HUD>.Instance.CrosshairText.Show(text, new Color32(byte.MaxValue, 100, 100, byte.MaxValue));
					}
				}
			}
			if (!flag)
			{
				this.destroyTime = 0f;
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000A8724 File Offset: 0x000A6924
		protected virtual BuildableItem GetHoveredBuildableItem()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.rightClickRange, out raycastHit, 1 << LayerMask.NameToLayer("Default"), true, 0f))
			{
				return raycastHit.collider.GetComponentInParent<BuildableItem>();
			}
			return null;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000A8770 File Offset: 0x000A6970
		protected virtual Pallet GetHoveredPallet()
		{
			LayerMask layerMask = default(LayerMask) | 1 << LayerMask.NameToLayer("Default");
			layerMask |= 1 << LayerMask.NameToLayer("Pallet");
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.rightClickRange, out raycastHit, layerMask, true, 0f))
			{
				return raycastHit.collider.GetComponentInParent<Pallet>();
			}
			return null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000A87E8 File Offset: 0x000A69E8
		protected virtual Constructable GetHoveredConstructable()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.rightClickRange, out raycastHit, 1 << LayerMask.NameToLayer("Default"), true, 0f))
			{
				return raycastHit.collider.GetComponentInParent<Constructable>();
			}
			return null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000A8831 File Offset: 0x000A6A31
		public void SetCanDestroy(bool canDestroy)
		{
			this.CanDestroy = canDestroy;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000A883C File Offset: 0x000A6A3C
		public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
			this.interactionDisplayEnabledThisFrame = true;
			this.interactionDisplay_Container.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(pos);
			this.interactionDisplay_Icon.gameObject.SetActive(icon != null);
			this.interactionDisplay_Icon.sprite = icon;
			this.interactionDisplay_Icon.color = iconColor;
			this.interactionDisplay_IconText.enabled = (spriteText != string.Empty);
			this.interactionDisplay_IconText.text = spriteText.ToUpper();
			this.interactionDisplay_MessageText.text = message;
			this.interactionDisplay_MessageText.color = messageColor;
			this.interactionDisplay_Container.sizeDelta = new Vector2(60f + this.interactionDisplay_MessageText.preferredWidth, this.interactionDisplay_Container.sizeDelta.y);
			this.backgroundImage.sizeDelta = new Vector2(this.interactionDisplay_MessageText.preferredWidth + 180f, 140f);
			float num = Mathf.Clamp(1f / Vector3.Distance(pos, PlayerSingleton<PlayerCamera>.Instance.transform.position), 0f, 1f) * this.tempDisplayScale * this.displaySizeMultiplier;
			this.interactionDisplay_Container.localScale = new Vector3(num, num, 1f);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000A8983 File Offset: 0x000A6B83
		public void LerpDisplayScale(float endScale)
		{
			if (this.ILerpDisplayScale_Coroutine != null)
			{
				base.StopCoroutine(this.ILerpDisplayScale_Coroutine);
			}
			this.ILerpDisplayScale_Coroutine = base.StartCoroutine(this.ILerpDisplayScale(this.tempDisplayScale, endScale));
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000A89B2 File Offset: 0x000A6BB2
		protected IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			float lerpTime = Mathf.Abs(startScale - endScale) * 0.75f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.tempDisplayScale = Mathf.Lerp(startScale, endScale, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.tempDisplayScale = endScale;
			this.ILerpDisplayScale_Coroutine = null;
			yield break;
		}

		// Token: 0x04001DDD RID: 7645
		public const float RayRadius = 0.075f;

		// Token: 0x04001DDE RID: 7646
		public const float MaxInteractionRange = 5f;

		// Token: 0x04001DDF RID: 7647
		[SerializeField]
		protected LayerMask interaction_SearchMask;

		// Token: 0x04001DE0 RID: 7648
		[SerializeField]
		protected float rightClickRange = 5f;

		// Token: 0x04001DE1 RID: 7649
		public EInteractionSearchType interactionSearchType;

		// Token: 0x04001DE2 RID: 7650
		public bool DEBUG;

		// Token: 0x04001DE4 RID: 7652
		[Header("Visuals Settings")]
		public Color messageColor_Default;

		// Token: 0x04001DE5 RID: 7653
		public Color iconColor_Default;

		// Token: 0x04001DE6 RID: 7654
		public Color iconColor_Default_Key;

		// Token: 0x04001DE7 RID: 7655
		public Color messageColor_Invalid;

		// Token: 0x04001DE8 RID: 7656
		public Color iconColor_Invalid;

		// Token: 0x04001DE9 RID: 7657
		public Sprite icon_Key;

		// Token: 0x04001DEA RID: 7658
		public Sprite icon_LeftMouse;

		// Token: 0x04001DEB RID: 7659
		public Sprite icon_Cross;

		// Token: 0x04001DEC RID: 7660
		public float displaySizeMultiplier = 1f;

		// Token: 0x04001DED RID: 7661
		[Header("References")]
		[SerializeField]
		protected Canvas interaction_Canvas;

		// Token: 0x04001DEE RID: 7662
		[SerializeField]
		protected RectTransform interactionDisplay_Container;

		// Token: 0x04001DEF RID: 7663
		[SerializeField]
		protected Image interactionDisplay_Icon;

		// Token: 0x04001DF0 RID: 7664
		[SerializeField]
		protected Text interactionDisplay_IconText;

		// Token: 0x04001DF1 RID: 7665
		[SerializeField]
		protected Text interactionDisplay_MessageText;

		// Token: 0x04001DF2 RID: 7666
		public RectTransform wsLabelContainer;

		// Token: 0x04001DF3 RID: 7667
		[SerializeField]
		protected InputActionReference InteractInput;

		// Token: 0x04001DF4 RID: 7668
		[HideInInspector]
		public string InteractKey = string.Empty;

		// Token: 0x04001DF5 RID: 7669
		[SerializeField]
		protected RectTransform backgroundImage;

		// Token: 0x04001DF6 RID: 7670
		[Header("Prefabs")]
		public GameObject WSLabelPrefab;

		// Token: 0x04001DFA RID: 7674
		private bool interactionDisplayEnabledThisFrame;

		// Token: 0x04001DFB RID: 7675
		private BuildableItem itemBeingDestroyed;

		// Token: 0x04001DFC RID: 7676
		private Pallet palletBeingDestroyed;

		// Token: 0x04001DFD RID: 7677
		private Constructable constructableBeingDestroyed;

		// Token: 0x04001DFE RID: 7678
		private float destroyTime;

		// Token: 0x04001DFF RID: 7679
		private float tempDisplayScale = 0.75f;

		// Token: 0x04001E00 RID: 7680
		public static float interactCooldown = 0.1f;

		// Token: 0x04001E01 RID: 7681
		private float timeSinceLastInteractStart;

		// Token: 0x04001E02 RID: 7682
		public List<WorldSpaceLabel> activeWSlabels = new List<WorldSpaceLabel>();

		// Token: 0x04001E03 RID: 7683
		private static float timeToDestroy = 0.5f;

		// Token: 0x04001E04 RID: 7684
		private Coroutine ILerpDisplayScale_Coroutine;
	}
}
