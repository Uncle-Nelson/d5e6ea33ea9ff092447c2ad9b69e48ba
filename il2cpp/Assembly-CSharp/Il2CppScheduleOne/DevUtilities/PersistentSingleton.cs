using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000463 RID: 1123
	public class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x06006190 RID: 24976 RVA: 0x001BCE38 File Offset: 0x001BB038
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentSingleton()
		{
			Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PersistentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr);
			PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675696);
			PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675697);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x001BCECC File Offset: 0x001BB0CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 201120, RefRangeEnd = 201130, XrefRangeStart = 201112, XrefRangeEnd = 201120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x001BCF08 File Offset: 0x001BB108
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 201131, RefRangeEnd = 201142, XrefRangeStart = 201130, XrefRangeEnd = 201131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x0002E1F1 File Offset: 0x0002C3F1
		public PersistentSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004290 RID: 17040
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004291 RID: 17041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
