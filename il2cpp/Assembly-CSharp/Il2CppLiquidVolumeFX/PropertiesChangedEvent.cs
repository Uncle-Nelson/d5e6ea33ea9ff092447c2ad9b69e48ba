using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D3 RID: 211
	public sealed class PropertiesChangedEvent : MulticastDelegate
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x000A1794 File Offset: 0x0009F994
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesChangedEvent()
		{
			Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "PropertiesChangedEvent");
			PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665097);
			PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665098);
			PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665099);
			PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665100);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000A180C File Offset: 0x0009FA0C
		[CallerCount(632)]
		[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81889, XrefRangeEnd = 82521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesChangedEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000A1868 File Offset: 0x0009FA68
		[CallerCount(0)]
		public unsafe void Invoke(LiquidVolume lv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000A18AC File Offset: 0x0009FAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(LiquidVolume lv, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000A1920 File Offset: 0x0009FB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00009D12 File Offset: 0x00007F12
		public PropertiesChangedEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00009D1B File Offset: 0x00007F1B
		public static implicit operator PropertiesChangedEvent(Action<LiquidVolume> A_0)
		{
			return DelegateSupport.ConvertDelegate<PropertiesChangedEvent>(A_0);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00009D23 File Offset: 0x00007F23
		public static PropertiesChangedEvent operator +(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PropertiesChangedEvent>();
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00009D31 File Offset: 0x00007F31
		public static PropertiesChangedEvent operator -(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<PropertiesChangedEvent>();
			}
			return result;
		}

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
