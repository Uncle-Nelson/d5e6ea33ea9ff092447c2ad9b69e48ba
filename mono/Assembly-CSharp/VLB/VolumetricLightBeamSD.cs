using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x02000144 RID: 324
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001B823 File Offset: 0x00019A23
		public ColorMode usedColorMode
		{
			get
			{
				if (Config.Instance.featureEnabledColorGradient == FeatureEnabledColorGradient.Off)
				{
					return ColorMode.Flat;
				}
				return this.colorMode;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001B839 File Offset: 0x00019A39
		private bool useColorFromAttachedLightSpot
		{
			get
			{
				return this.colorFromLight && base.lightSpotAttached != null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001B851 File Offset: 0x00019A51
		private bool useColorTemperatureFromAttachedLightSpot
		{
			get
			{
				return this.useColorFromAttachedLightSpot && base.lightSpotAttached.useColorTemperature && Config.Instance.useLightColorTemperature;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001B874 File Offset: 0x00019A74
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0001B87C File Offset: 0x00019A7C
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			get
			{
				return this.intensityInside;
			}
			set
			{
				this.intensityInside = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001B885 File Offset: 0x00019A85
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0001B88D File Offset: 0x00019A8D
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			get
			{
				return this.intensityOutside;
			}
			set
			{
				this.intensityOutside = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001B885 File Offset: 0x00019A85
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0001B896 File Offset: 0x00019A96
		public float intensityGlobal
		{
			get
			{
				return this.intensityOutside;
			}
			set
			{
				this.intensityInside = value;
				this.intensityOutside = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001B8A6 File Offset: 0x00019AA6
		public bool useIntensityFromAttachedLightSpot
		{
			get
			{
				return this.intensityFromLight && base.lightSpotAttached != null;
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
			if (this.intensityModeAdvanced)
			{
				inside = this.intensityInside;
				outside = this.intensityOutside;
				return;
			}
			inside = (outside = this.intensityOutside);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001B8F3 File Offset: 0x00019AF3
		public bool useSpotAngleFromAttachedLightSpot
		{
			get
			{
				return this.spotAngleFromLight && base.lightSpotAttached != null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001B90B File Offset: 0x00019B0B
		public float coneAngle
		{
			get
			{
				return Mathf.Atan2(this.coneRadiusEnd - this.coneRadiusStart, this.maxGeometryDistance) * 57.29578f * 2f;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001B931 File Offset: 0x00019B31
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0001B944 File Offset: 0x00019B44
		public float coneRadiusEnd
		{
			get
			{
				return Utils.ComputeConeRadiusEnd(this.maxGeometryDistance, this.spotAngle);
			}
			set
			{
				this.spotAngle = Utils.ComputeSpotAngle(this.maxGeometryDistance, value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001B958 File Offset: 0x00019B58
		public float coneVolume
		{
			get
			{
				float num = this.coneRadiusStart;
				float coneRadiusEnd = this.coneRadiusEnd;
				return 1.0471976f * (num * num + num * coneRadiusEnd + coneRadiusEnd * coneRadiusEnd) * this.fallOffEnd;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001B98C File Offset: 0x00019B8C
		public float coneApexOffsetZ
		{
			get
			{
				float num = this.coneRadiusStart / this.coneRadiusEnd;
				if (num != 1f)
				{
					return this.maxGeometryDistance * num / (1f - num);
				}
				return float.MaxValue;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001B9C5 File Offset: 0x00019BC5
		public Vector3 coneApexPositionLocal
		{
			get
			{
				return new Vector3(0f, 0f, -this.coneApexOffsetZ);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		public Vector3 coneApexPositionGlobal
		{
			get
			{
				return base.transform.localToWorldMatrix.MultiplyPoint(this.coneApexPositionLocal);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000022C9 File Offset: 0x000004C9
		public override bool IsScalable()
		{
			return true;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001BA06 File Offset: 0x00019C06
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0001BA22 File Offset: 0x00019C22
		public int geomSides
		{
			get
			{
				if (this.geomMeshType != MeshType.Custom)
				{
					return Config.Instance.sharedMeshSides;
				}
				return this.geomCustomSides;
			}
			set
			{
				this.geomCustomSides = value;
				Debug.LogWarningFormat("The setter VLB.{0}.geomSides is OBSOLETE and has been renamed to geomCustomSides.", new object[]
				{
					"VolumetricLightBeamSD"
				});
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001BA43 File Offset: 0x00019C43
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0001BA5F File Offset: 0x00019C5F
		public int geomSegments
		{
			get
			{
				if (this.geomMeshType != MeshType.Custom)
				{
					return Config.Instance.sharedMeshSegments;
				}
				return this.geomCustomSegments;
			}
			set
			{
				this.geomCustomSegments = value;
				Debug.LogWarningFormat("The setter VLB.{0}.geomSegments is OBSOLETE and has been renamed to geomCustomSegments.", new object[]
				{
					"VolumetricLightBeamSD"
				});
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001BA80 File Offset: 0x00019C80
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			get
			{
				if (Mathf.Approximately(this.skewingLocalForwardDirection.z, 0f))
				{
					Debug.LogErrorFormat("Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden", new object[]
					{
						base.name
					});
					return Vector3.forward;
				}
				return this.skewingLocalForwardDirection.normalized;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0001BACE File Offset: 0x00019CCE
		public bool canHaveMeshSkewing
		{
			get
			{
				return this.geomMeshType == MeshType.Custom;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001BAD9 File Offset: 0x00019CD9
		public bool hasMeshSkewing
		{
			get
			{
				return Config.Instance.featureEnabledMeshSkewing && this.canHaveMeshSkewing && !Mathf.Approximately(Vector3.Dot(this.skewingLocalForwardDirectionNormalized, Vector3.forward), 1f);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0001BB12 File Offset: 0x00019D12
		public Vector4 additionalClippingPlane
		{
			get
			{
				if (!(this.clippingPlaneTransform == null))
				{
					return Utils.PlaneEquation(this.clippingPlaneTransform.forward, this.clippingPlaneTransform.position);
				}
				return Vector4.zero;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001BB43 File Offset: 0x00019D43
		public float attenuationLerpLinearQuad
		{
			get
			{
				if (this.attenuationEquation == AttenuationEquation.Linear)
				{
					return 0f;
				}
				if (this.attenuationEquation == AttenuationEquation.Quadratic)
				{
					return 1f;
				}
				return this.attenuationCustomBlending;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001BB68 File Offset: 0x00019D68
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0001BB70 File Offset: 0x00019D70
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			get
			{
				return this.fallOffStart;
			}
			set
			{
				this.fallOffStart = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001BB79 File Offset: 0x00019D79
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0001BB81 File Offset: 0x00019D81
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			get
			{
				return this.fallOffEnd;
			}
			set
			{
				this.fallOffEnd = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001BB8A File Offset: 0x00019D8A
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0001BB92 File Offset: 0x00019D92
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			get
			{
				return this.fallOffEndFromLight;
			}
			set
			{
				this.fallOffEndFromLight = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001BB9B File Offset: 0x00019D9B
		public bool useFallOffEndFromAttachedLightSpot
		{
			get
			{
				return this.fallOffEndFromLight && base.lightSpotAttached != null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001BBB3 File Offset: 0x00019DB3
		public float maxGeometryDistance
		{
			get
			{
				return this.fallOffEnd + Mathf.Max(Mathf.Abs(this.tiltFactor.x), Mathf.Abs(this.tiltFactor.y));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001BBE1 File Offset: 0x00019DE1
		public bool isNoiseEnabled
		{
			get
			{
				return this.noiseMode > NoiseMode.Disabled;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001BBEC File Offset: 0x00019DEC
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			get
			{
				return this.isNoiseEnabled;
			}
			set
			{
				this.noiseMode = (value ? NoiseMode.WorldSpace : NoiseMode.Disabled);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001BC03 File Offset: 0x00019E03
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0001BC0B File Offset: 0x00019E0B
		public float fadeOutBegin
		{
			get
			{
				return this._FadeOutBegin;
			}
			set
			{
				this.SetFadeOutValue(ref this._FadeOutBegin, value);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001BC1A File Offset: 0x00019E1A
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0001BC22 File Offset: 0x00019E22
		public float fadeOutEnd
		{
			get
			{
				return this._FadeOutEnd;
			}
			set
			{
				this.SetFadeOutValue(ref this._FadeOutEnd, value);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001BC31 File Offset: 0x00019E31
		public bool isFadeOutEnabled
		{
			get
			{
				return this._FadeOutBegin >= 0f && this._FadeOutEnd >= 0f;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001BC52 File Offset: 0x00019E52
		public bool isTilted
		{
			get
			{
				return !this.tiltFactor.Approximately(Vector2.zero, 1E-05f);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001BC6C File Offset: 0x00019E6C
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0001BC74 File Offset: 0x00019E74
		public int sortingLayerID
		{
			get
			{
				return this._SortingLayerID;
			}
			set
			{
				this._SortingLayerID = value;
				if (this.m_BeamGeom)
				{
					this.m_BeamGeom.sortingLayerID = value;
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001BC96 File Offset: 0x00019E96
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0001BCA3 File Offset: 0x00019EA3
		public string sortingLayerName
		{
			get
			{
				return SortingLayer.IDToName(this.sortingLayerID);
			}
			set
			{
				this.sortingLayerID = SortingLayer.NameToID(value);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001BCB1 File Offset: 0x00019EB1
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		public int sortingOrder
		{
			get
			{
				return this._SortingOrder;
			}
			set
			{
				this._SortingOrder = value;
				if (this.m_BeamGeom)
				{
					this.m_BeamGeom.sortingOrder = value;
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001BCDB File Offset: 0x00019EDB
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0001BCE3 File Offset: 0x00019EE3
		public bool trackChangesDuringPlaytime
		{
			get
			{
				return this._TrackChangesDuringPlaytime;
			}
			set
			{
				this._TrackChangesDuringPlaytime = value;
				this.StartPlaytimeUpdateIfNeeded();
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001BCF2 File Offset: 0x00019EF2
		public bool isCurrentlyTrackingChanges
		{
			get
			{
				return this.m_CoPlaytimeUpdate != null;
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001BCFD File Offset: 0x00019EFD
		public override BeamGeometryAbstractBase GetBeamGeometry()
		{
			return this.m_BeamGeom;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001BD05 File Offset: 0x00019F05
		protected override void SetBeamGeometryNull()
		{
			this.m_BeamGeom = null;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001BD0E File Offset: 0x00019F0E
		public int blendingModeAsInt
		{
			get
			{
				return Mathf.Clamp((int)this.blendingMode, 0, Enum.GetValues(typeof(BlendingMode)).Length);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0001BD30 File Offset: 0x00019F30
		public Quaternion beamInternalLocalRotation
		{
			get
			{
				if (this.dimensions != Dimensions.Dim3D)
				{
					return Quaternion.LookRotation(Vector3.right, Vector3.up);
				}
				return Quaternion.identity;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001BD4F File Offset: 0x00019F4F
		public Vector3 beamLocalForward
		{
			get
			{
				if (this.dimensions != Dimensions.Dim3D)
				{
					return Vector3.right;
				}
				return Vector3.forward;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001BD64 File Offset: 0x00019F64
		public Vector3 beamGlobalForward
		{
			get
			{
				return base.transform.TransformDirection(this.beamLocalForward);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001BD78 File Offset: 0x00019F78
		public override Vector3 GetLossyScale()
		{
			if (this.dimensions != Dimensions.Dim3D)
			{
				return new Vector3(base.transform.lossyScale.z, base.transform.lossyScale.y, base.transform.lossyScale.x);
			}
			return base.transform.lossyScale;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		public float raycastDistance
		{
			get
			{
				if (!this.hasMeshSkewing)
				{
					return this.maxGeometryDistance;
				}
				float z = this.skewingLocalForwardDirectionNormalized.z;
				if (!Mathf.Approximately(z, 0f))
				{
					return this.maxGeometryDistance / z;
				}
				return this.maxGeometryDistance;
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001BE14 File Offset: 0x0001A014
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
		{
			return base.transform.rotation * this.beamInternalLocalRotation * localVec;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001BE32 File Offset: 0x0001A032
		public Vector3 raycastGlobalForward
		{
			get
			{
				return this.ComputeRaycastGlobalVector(this.hasMeshSkewing ? this.skewingLocalForwardDirectionNormalized : Vector3.forward);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001BE4F File Offset: 0x0001A04F
		public Vector3 raycastGlobalUp
		{
			get
			{
				return this.ComputeRaycastGlobalVector(Vector3.up);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001BE5C File Offset: 0x0001A05C
		public Vector3 raycastGlobalRight
		{
			get
			{
				return this.ComputeRaycastGlobalVector(Vector3.right);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001BE69 File Offset: 0x0001A069
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0001BE7F File Offset: 0x0001A07F
		public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			get
			{
				if (!Config.Instance.featureEnabledDynamicOcclusion)
				{
					return MaterialManager.SD.DynamicOcclusion.Off;
				}
				return this.m_INTERNAL_DynamicOcclusionMode;
			}
			set
			{
				this.m_INTERNAL_DynamicOcclusionMode = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001BE88 File Offset: 0x0001A088
		public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			get
			{
				if (!this.m_INTERNAL_DynamicOcclusionMode_Runtime)
				{
					return MaterialManager.SD.DynamicOcclusion.Off;
				}
				return this._INTERNAL_DynamicOcclusionMode;
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001BE9A File Offset: 0x0001A09A
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			this.m_INTERNAL_DynamicOcclusionMode_Runtime = (cb != null);
			if (this.m_BeamGeom)
			{
				this.m_BeamGeom.SetDynamicOcclusionCallback(shaderKeyword, cb);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600061C RID: 1564 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		// (remove) Token: 0x0600061D RID: 1565 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		public event VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam;

		// Token: 0x0600061E RID: 1566 RVA: 0x0001BF2D File Offset: 0x0001A12D
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
			if (this.onWillCameraRenderThisBeam != null)
			{
				this.onWillCameraRenderThisBeam(cam);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001BF43 File Offset: 0x0001A143
		public void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeamSD.OnBeamGeometryInitialized cb)
		{
			this.m_OnBeamGeometryInitialized = (VolumetricLightBeamSD.OnBeamGeometryInitialized)Delegate.Combine(this.m_OnBeamGeometryInitialized, cb);
			if (this.m_BeamGeom)
			{
				this.CallOnBeamGeometryInitializedCallback();
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001BF6F File Offset: 0x0001A16F
		private void CallOnBeamGeometryInitializedCallback()
		{
			if (this.m_OnBeamGeometryInitialized != null)
			{
				this.m_OnBeamGeometryInitialized();
				this.m_OnBeamGeometryInitialized = null;
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001BF8C File Offset: 0x0001A18C
		private void SetFadeOutValue(ref float propToChange, float value)
		{
			bool isFadeOutEnabled = this.isFadeOutEnabled;
			propToChange = value;
			if (this.isFadeOutEnabled != isFadeOutEnabled)
			{
				this.OnFadeOutStateChanged();
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001BFB2 File Offset: 0x0001A1B2
		private void OnFadeOutStateChanged()
		{
			if (this.isFadeOutEnabled && this.m_BeamGeom)
			{
				this.m_BeamGeom.RestartFadeOutCoroutine();
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		public string meshStats
		{
			get
			{
				Mesh mesh = this.m_BeamGeom ? this.m_BeamGeom.coneMesh : null;
				if (mesh)
				{
					return string.Format("Cone angle: {0:0.0} degrees\nMesh: {1} vertices, {2} triangles", this.coneAngle, mesh.vertexCount, mesh.triangles.Length / 3);
				}
				return "no mesh available";
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001C04E File Offset: 0x0001A24E
		public int meshVerticesCount
		{
			get
			{
				if (!this.m_BeamGeom || !this.m_BeamGeom.coneMesh)
				{
					return 0;
				}
				return this.m_BeamGeom.coneMesh.vertexCount;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001C081 File Offset: 0x0001A281
		public int meshTrianglesCount
		{
			get
			{
				if (!this.m_BeamGeom || !this.m_BeamGeom.coneMesh)
				{
					return 0;
				}
				return this.m_BeamGeom.coneMesh.triangles.Length / 3;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return this.GetInsideBeamFactorFromObjectSpacePos(base.transform.InverseTransformPoint(posWS));
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			if (this.dimensions == Dimensions.Dim2D)
			{
				posOS = new Vector3(posOS.z, posOS.y, posOS.x);
			}
			if (posOS.z < 0f)
			{
				return -1f;
			}
			Vector2 a = posOS.xy();
			if (this.hasMeshSkewing)
			{
				Vector3 skewingLocalForwardDirectionNormalized = this.skewingLocalForwardDirectionNormalized;
				a -= skewingLocalForwardDirectionNormalized.xy() * (posOS.z / skewingLocalForwardDirectionNormalized.z);
			}
			Vector2 normalized = new Vector2(a.magnitude, posOS.z + this.coneApexOffsetZ).normalized;
			return Mathf.Clamp((Mathf.Abs(Mathf.Sin(this.coneAngle * 0.017453292f / 2f)) - Mathf.Abs(normalized.x)) / 0.1f, -1f, 1f);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001C1A2 File Offset: 0x0001A3A2
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
			this.GenerateGeometry();
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		public virtual void GenerateGeometry()
		{
			this.HandleBackwardCompatibility(this.pluginVersion, 20100);
			this.pluginVersion = 20100;
			this.ValidateProperties();
			if (this.m_BeamGeom == null)
			{
				this.m_BeamGeom = Utils.NewWithComponent<BeamGeometrySD>("Beam Geometry");
				this.m_BeamGeom.Initialize(this);
				this.CallOnBeamGeometryInitializedCallback();
			}
			this.m_BeamGeom.RegenerateMesh(base.enabled);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001C21C File Offset: 0x0001A41C
		public virtual void UpdateAfterManualPropertyChange()
		{
			this.ValidateProperties();
			if (this.m_BeamGeom)
			{
				this.m_BeamGeom.UpdateMaterialAndBounds();
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001C23C File Offset: 0x0001A43C
		private void Start()
		{
			base.InitLightSpotAttachedCached();
			this.GenerateGeometry();
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001C24A File Offset: 0x0001A44A
		private void OnEnable()
		{
			if (this.m_BeamGeom)
			{
				this.m_BeamGeom.OnMasterEnable();
			}
			this.StartPlaytimeUpdateIfNeeded();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001C26A File Offset: 0x0001A46A
		private void OnDisable()
		{
			if (this.m_BeamGeom)
			{
				this.m_BeamGeom.OnMasterDisable();
			}
			this.m_CoPlaytimeUpdate = null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001C28B File Offset: 0x0001A48B
		private void StartPlaytimeUpdateIfNeeded()
		{
			if (Application.isPlaying && this.trackChangesDuringPlaytime && this.m_CoPlaytimeUpdate == null)
			{
				this.m_CoPlaytimeUpdate = base.StartCoroutine(this.CoPlaytimeUpdate());
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001C2B6 File Offset: 0x0001A4B6
		private IEnumerator CoPlaytimeUpdate()
		{
			while (this.trackChangesDuringPlaytime && base.enabled)
			{
				this.UpdateAfterManualPropertyChange();
				yield return null;
			}
			this.m_CoPlaytimeUpdate = null;
			yield break;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
		private void AssignPropertiesFromAttachedSpotLight()
		{
			Light lightSpotAttached = base.lightSpotAttached;
			if (lightSpotAttached)
			{
				if (this.intensityFromLight)
				{
					this.intensityModeAdvanced = false;
					this.intensityGlobal = SpotLightHelper.GetIntensity(lightSpotAttached) * this.intensityMultiplier;
				}
				if (this.fallOffEndFromLight)
				{
					this.fallOffEnd = SpotLightHelper.GetFallOffEnd(lightSpotAttached) * this.fallOffEndMultiplier;
				}
				if (this.spotAngleFromLight)
				{
					this.spotAngle = Mathf.Clamp(SpotLightHelper.GetSpotAngle(lightSpotAttached) * this.spotAngleMultiplier, 0.1f, 179.9f);
				}
				if (this.colorFromLight)
				{
					this.colorMode = ColorMode.Flat;
					if (this.useColorTemperatureFromAttachedLightSpot)
					{
						Color b = Mathf.CorrelatedColorTemperatureToRGB(lightSpotAttached.colorTemperature);
						this.color = (lightSpotAttached.color.linear * b).gamma;
						return;
					}
					this.color = lightSpotAttached.color;
				}
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
		private void ClampProperties()
		{
			this.intensityInside = Mathf.Max(this.intensityInside, 0f);
			this.intensityOutside = Mathf.Max(this.intensityOutside, 0f);
			this.intensityMultiplier = Mathf.Max(this.intensityMultiplier, 0f);
			this.attenuationCustomBlending = Mathf.Clamp(this.attenuationCustomBlending, 0f, 1f);
			this.fallOffEnd = Mathf.Max(0.01f, this.fallOffEnd);
			this.fallOffStart = Mathf.Clamp(this.fallOffStart, 0f, this.fallOffEnd - 0.01f);
			this.fallOffEndMultiplier = Mathf.Max(this.fallOffEndMultiplier, 0f);
			this.spotAngle = Mathf.Clamp(this.spotAngle, 0.1f, 179.9f);
			this.spotAngleMultiplier = Mathf.Max(this.spotAngleMultiplier, 0f);
			this.coneRadiusStart = Mathf.Max(this.coneRadiusStart, 0f);
			this.depthBlendDistance = Mathf.Max(this.depthBlendDistance, 0f);
			this.cameraClippingDistance = Mathf.Max(this.cameraClippingDistance, 0f);
			this.geomCustomSides = Mathf.Clamp(this.geomCustomSides, 3, 256);
			this.geomCustomSegments = Mathf.Clamp(this.geomCustomSegments, 0, 64);
			this.fresnelPow = Mathf.Max(0f, this.fresnelPow);
			this.glareBehind = Mathf.Clamp(this.glareBehind, 0f, 1f);
			this.glareFrontal = Mathf.Clamp(this.glareFrontal, 0f, 1f);
			this.noiseIntensity = Mathf.Clamp(this.noiseIntensity, 0f, 1f);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001C55D File Offset: 0x0001A75D
		private void ValidateProperties()
		{
			this.AssignPropertiesFromAttachedSpotLight();
			this.ClampProperties();
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001C56C File Offset: 0x0001A76C
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			if (serializedVersion == -1)
			{
				return;
			}
			if (serializedVersion == newVersion)
			{
				return;
			}
			if (serializedVersion < 1301)
			{
				this.attenuationEquation = AttenuationEquation.Linear;
			}
			if (serializedVersion < 1501)
			{
				this.geomMeshType = MeshType.Custom;
				this.geomCustomSegments = 5;
			}
			if (serializedVersion < 1610)
			{
				this.intensityFromLight = false;
				this.intensityModeAdvanced = !Mathf.Approximately(this.intensityInside, this.intensityOutside);
			}
			if (serializedVersion < 1910 && !this.intensityModeAdvanced && !Mathf.Approximately(this.intensityInside, this.intensityOutside))
			{
				this.intensityInside = this.intensityOutside;
			}
			Utils.MarkCurrentSceneDirty();
		}

		// Token: 0x040006CF RID: 1743
		public new const string ClassName = "VolumetricLightBeamSD";

		// Token: 0x040006D0 RID: 1744
		public bool colorFromLight = true;

		// Token: 0x040006D1 RID: 1745
		public ColorMode colorMode;

		// Token: 0x040006D2 RID: 1746
		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color = Consts.Beam.FlatColor;

		// Token: 0x040006D3 RID: 1747
		public Gradient colorGradient;

		// Token: 0x040006D4 RID: 1748
		public bool intensityFromLight = true;

		// Token: 0x040006D5 RID: 1749
		public bool intensityModeAdvanced;

		// Token: 0x040006D6 RID: 1750
		[FormerlySerializedAs("alphaInside")]
		[Min(0f)]
		public float intensityInside = 1f;

		// Token: 0x040006D7 RID: 1751
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Min(0f)]
		public float intensityOutside = 1f;

		// Token: 0x040006D8 RID: 1752
		[Min(0f)]
		public float intensityMultiplier = 1f;

		// Token: 0x040006D9 RID: 1753
		[Range(0f, 1f)]
		public float hdrpExposureWeight;

		// Token: 0x040006DA RID: 1754
		public BlendingMode blendingMode;

		// Token: 0x040006DB RID: 1755
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight = true;

		// Token: 0x040006DC RID: 1756
		[Range(0.1f, 179.9f)]
		public float spotAngle = 35f;

		// Token: 0x040006DD RID: 1757
		[Min(0f)]
		public float spotAngleMultiplier = 1f;

		// Token: 0x040006DE RID: 1758
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart = 0.1f;

		// Token: 0x040006DF RID: 1759
		public ShaderAccuracy shaderAccuracy;

		// Token: 0x040006E0 RID: 1760
		public MeshType geomMeshType;

		// Token: 0x040006E1 RID: 1761
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides = 18;

		// Token: 0x040006E2 RID: 1762
		public int geomCustomSegments = 5;

		// Token: 0x040006E3 RID: 1763
		public Vector3 skewingLocalForwardDirection = Consts.Beam.SD.SkewingLocalForwardDirectionDefault;

		// Token: 0x040006E4 RID: 1764
		public Transform clippingPlaneTransform;

		// Token: 0x040006E5 RID: 1765
		public bool geomCap;

		// Token: 0x040006E6 RID: 1766
		public AttenuationEquation attenuationEquation = AttenuationEquation.Quadratic;

		// Token: 0x040006E7 RID: 1767
		[Range(0f, 1f)]
		public float attenuationCustomBlending = 0.5f;

		// Token: 0x040006E8 RID: 1768
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		// Token: 0x040006E9 RID: 1769
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd = 3f;

		// Token: 0x040006EA RID: 1770
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight = true;

		// Token: 0x040006EB RID: 1771
		[Min(0f)]
		public float fallOffEndMultiplier = 1f;

		// Token: 0x040006EC RID: 1772
		public float depthBlendDistance = 2f;

		// Token: 0x040006ED RID: 1773
		public float cameraClippingDistance = 0.5f;

		// Token: 0x040006EE RID: 1774
		[Range(0f, 1f)]
		public float glareFrontal = 0.5f;

		// Token: 0x040006EF RID: 1775
		[Range(0f, 1f)]
		public float glareBehind = 0.5f;

		// Token: 0x040006F0 RID: 1776
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow = 8f;

		// Token: 0x040006F1 RID: 1777
		public NoiseMode noiseMode;

		// Token: 0x040006F2 RID: 1778
		[Range(0f, 1f)]
		public float noiseIntensity = 0.5f;

		// Token: 0x040006F3 RID: 1779
		public bool noiseScaleUseGlobal = true;

		// Token: 0x040006F4 RID: 1780
		[Range(0.01f, 2f)]
		public float noiseScaleLocal = 0.5f;

		// Token: 0x040006F5 RID: 1781
		public bool noiseVelocityUseGlobal = true;

		// Token: 0x040006F6 RID: 1782
		public Vector3 noiseVelocityLocal = Consts.Beam.NoiseVelocityDefault;

		// Token: 0x040006F7 RID: 1783
		public Dimensions dimensions;

		// Token: 0x040006F8 RID: 1784
		public Vector2 tiltFactor = Consts.Beam.SD.TiltDefault;

		// Token: 0x040006F9 RID: 1785
		private MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		// Token: 0x040006FA RID: 1786
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		// Token: 0x040006FC RID: 1788
		private VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		// Token: 0x040006FD RID: 1789
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		// Token: 0x040006FE RID: 1790
		[SerializeField]
		private int _SortingLayerID;

		// Token: 0x040006FF RID: 1791
		[SerializeField]
		private int _SortingOrder;

		// Token: 0x04000700 RID: 1792
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin = -150f;

		// Token: 0x04000701 RID: 1793
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd = -200f;

		// Token: 0x04000703 RID: 1795
		private BeamGeometrySD m_BeamGeom;

		// Token: 0x04000704 RID: 1796
		private Coroutine m_CoPlaytimeUpdate;

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000638 RID: 1592
		public delegate void OnWillCameraRenderCB(Camera cam);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x0600063C RID: 1596
		public delegate void OnBeamGeometryInitialized();
	}
}
