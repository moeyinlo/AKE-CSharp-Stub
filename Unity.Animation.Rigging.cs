/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

// Image 59: Unity.Animation.Rigging.dll - Assembly: Unity.Animation.Rigging, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61402-61537
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.Editor")]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61403
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 61404
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine.Animations.Rigging
{
	public struct CacheIndex // TypeDefIndex: 61405
	{
		// Fields
		internal int idx; // 0x00
	}

	public struct AnimationJobCache : IDisposable // TypeDefIndex: 61406
	{
		// Fields
		private NativeArray<float> m_Data; // 0x00
	
		// Constructors
		internal AnimationJobCache(float[] data); // 0x000000018B14850C-0x000000018B148570
	
		// Methods
		public void Dispose(); // 0x000000018B1484D0-0x000000018B14850C
		public float GetRaw(CacheIndex index, int offset = 0 /* Metadata: 0x0234FC1E */); // 0x0000000184DAB030-0x0000000184DAB040
		public void SetRaw(float val, CacheIndex index, int offset = 0 /* Metadata: 0x0234FC1F */); // 0x0000000184DAB040-0x0000000184DAB050
		public T Get<T>(CacheIndex index, int offset = 0 /* Metadata: 0x0234FC20 */)
			where T : struct;
		public void Set<T>(T val, CacheIndex index, int offset = 0 /* Metadata: 0x0234FC21 */)
			where T : struct;
		public void SetArray<T>(T[] v, CacheIndex index, int offset = 0 /* Metadata: 0x0234FC22 */)
			where T : struct;
	}

	public class AnimationJobCacheBuilder // TypeDefIndex: 61407
	{
		// Fields
		private List<float> m_Data; // 0x10
	
		// Constructors
		public AnimationJobCacheBuilder(); // 0x000000018B148458-0x000000018B1484D0
	
		// Methods
		public CacheIndex Add(float v); // 0x000000018B1481D0-0x000000018B148240
		public CacheIndex Add(Vector2 v); // 0x000000018B148240-0x000000018B1482C8
		public CacheIndex Add(Vector3 v); // 0x000000018B148050-0x000000018B1480F8
		public CacheIndex Add(Vector4 v); // 0x000000018B147F90-0x000000018B148050
		public CacheIndex Add(Quaternion v); // 0x000000018B1481B0-0x000000018B1481D0
		public CacheIndex Add(AffineTransform tx); // 0x000000018B1480F8-0x000000018B1481B0
		public CacheIndex AllocateChunk(int size); // 0x000000018B1482C8-0x000000018B148360
		public void SetValue(CacheIndex index, int offset, float value); // 0x000000018B1483CC-0x000000018B148458
		public AnimationJobCache Build(); // 0x000000018B148360-0x000000018B1483CC
	}

	[BurstCompile]
	public struct BlendConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61408
	{
		// Fields
		private const int k_BlendTranslationMask = 1; // Metadata: 0x0234FC23
		private const int k_BlendRotationMask = 2; // Metadata: 0x0234FC24
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle sourceA; // 0x0C
		public ReadOnlyTransformHandle sourceB; // 0x24
		public AffineTransform sourceAOffset; // 0x3C
		public AffineTransform sourceBOffset; // 0x58
		public BoolProperty blendPosition; // 0x74
		public BoolProperty blendRotation; // 0x84
		public FloatProperty positionWeight; // 0x94
		public FloatProperty rotationWeight; // 0xA4
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xB4
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DAB050-0x0000000184DAB060 0x0000000184DAB060-0x0000000184DAB070
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B149CF0-0x000000018B14A274
	}

	public interface IBlendConstraintData // TypeDefIndex: 61409
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObjectA { get; }
		Transform sourceObjectB { get; }
		bool maintainPositionOffsets { get; }
		bool maintainRotationOffsets { get; }
		string blendPositionBoolProperty { get; }
		string blendRotationBoolProperty { get; }
		string positionWeightFloatProperty { get; }
		string rotationWeightFloatProperty { get; }
	}

	public class BlendConstraintJobBinder<T> : AnimationJobBinder<BlendConstraintJob, T> // TypeDefIndex: 61410
		where T : struct, IAnimationJobData, IBlendConstraintData
	{
		// Constructors
		public BlendConstraintJobBinder();
	
		// Methods
		public override BlendConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(BlendConstraintJob job);
	}

	[BurstCompile]
	public struct ChainIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61411
	{
		// Fields
		public NativeArray<ReadWriteTransformHandle> chain; // 0x00
		public ReadOnlyTransformHandle target; // 0x10
		public AffineTransform targetOffset; // 0x28
		public NativeArray<float> linkLengths; // 0x48
		public NativeArray<Vector3> linkPositions; // 0x58
		public FloatProperty chainRotationWeight; // 0x68
		public FloatProperty tipRotationWeight; // 0x78
		public CacheIndex toleranceIdx; // 0x88
		public CacheIndex maxIterationsIdx; // 0x8C
		public AnimationJobCache cache; // 0x90
		public float maxReach; // 0xA0
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DAB070-0x0000000184DAB080 0x0000000184DAB080-0x0000000184DAB090
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14A6EC-0x000000018B14AE00
	}

	public interface IChainIKConstraintData // TypeDefIndex: 61412
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform target { get; }
		int maxIterations { get; }
		float tolerance { get; }
		bool maintainTargetPositionOffset { get; }
		bool maintainTargetRotationOffset { get; }
		string chainRotationWeightFloatProperty { get; }
		string tipRotationWeightFloatProperty { get; }
	}

	public class ChainIKConstraintJobBinder<T> : AnimationJobBinder<ChainIKConstraintJob, T> // TypeDefIndex: 61413
		where T : struct, IAnimationJobData, IChainIKConstraintData
	{
		// Constructors
		public ChainIKConstraintJobBinder();
	
		// Methods
		public override ChainIKConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(ChainIKConstraintJob job);
		public override void Update(ChainIKConstraintJob job, ref ref T data);
	}

	[BurstCompile]
	public struct DampedTransformJob : IWeightedAnimationJob // TypeDefIndex: 61414
	{
		// Fields
		private const float k_FixedDt = 0.01667f; // Metadata: 0x0234FC25
		private const float k_DampFactor = 40f; // Metadata: 0x0234FC29
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform localBindTx; // 0x24
		public Vector3 aimBindAxis; // 0x40
		public AffineTransform prevDrivenTx; // 0x4C
		public FloatProperty dampPosition; // 0x68
		public FloatProperty dampRotation; // 0x78
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x88
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DAB090-0x0000000184DAB0A0 0x0000000184DAB0A0-0x0000000184DAB0B0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14B568-0x000000018B14BD10
	}

	public interface IDampedTransformData // TypeDefIndex: 61415
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		bool maintainAim { get; }
		string dampPositionFloatProperty { get; }
		string dampRotationFloatProperty { get; }
	}

	public class DampedTransformJobBinder<T> : AnimationJobBinder<DampedTransformJob, T> // TypeDefIndex: 61416
		where T : struct, IAnimationJobData, IDampedTransformData
	{
		// Constructors
		public DampedTransformJobBinder();
	
		// Methods
		public override DampedTransformJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(DampedTransformJob job);
	}

	public interface IAnimatableProperty<T> // TypeDefIndex: 61417
	{
		// Methods
		T Get(AnimationStream stream);
		void Set(AnimationStream stream, T value);
	}

	public struct BoolProperty : IAnimatableProperty<bool> // TypeDefIndex: 61418
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static BoolProperty Bind(Animator animator, Component component, string name); // 0x000000018B14A3A0-0x000000018B14A430
		public static BoolProperty BindCustom(Animator animator, string property); // 0x000000018B14A368-0x000000018B14A3A0
		public bool Get(AnimationStream stream); // 0x000000018B14A430-0x000000018B14A46C
		public void Set(AnimationStream stream, bool v); // 0x000000018B14A46C-0x000000018B14A4A8
	}

	public struct IntProperty : IAnimatableProperty<int> // TypeDefIndex: 61419
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static IntProperty Bind(Animator animator, Component component, string name); // 0x000000018B14A3A0-0x000000018B14A430
		public static IntProperty BindCustom(Animator animator, string property); // 0x000000018B14C060-0x000000018B14C098
		public int Get(AnimationStream stream); // 0x000000018B14C098-0x000000018B14C0D4
		public void Set(AnimationStream stream, int v); // 0x000000018B14C0D4-0x000000018B14C110
	}

	public struct FloatProperty : IAnimatableProperty<float> // TypeDefIndex: 61420
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static FloatProperty Bind(Animator animator, Component component, string name); // 0x000000018B14A3A0-0x000000018B14A430
		public static FloatProperty BindCustom(Animator animator, string property); // 0x000000018B14BFB0-0x000000018B14BFE8
		public float Get(AnimationStream stream); // 0x000000018B14BFE8-0x000000018B14C024
		public void Set(AnimationStream stream, float v); // 0x000000018B14C024-0x000000018B14C060
	}

	public struct Vector2Property : IAnimatableProperty<Vector2> // TypeDefIndex: 61421
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
	
		// Methods
		public static Vector2Property Bind(Animator animator, Component component, string name); // 0x000000018B158F44-0x000000018B159064
		public static Vector2Property BindCustom(Animator animator, string name); // 0x000000018B158E7C-0x000000018B158F44
		public Vector2 Get(AnimationStream stream); // 0x000000018B159064-0x000000018B15910C
		public void Set(AnimationStream stream, Vector2 value); // 0x000000018B15910C-0x000000018B1591B8
	}

	public struct Vector3Property : IAnimatableProperty<Vector3> // TypeDefIndex: 61422
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3Property Bind(Animator animator, Component component, string name); // 0x000000018B159B68-0x000000018B159CE0
		public static Vector3Property BindCustom(Animator animator, string name); // 0x000000018B159A58-0x000000018B159B68
		public Vector3 Get(AnimationStream stream); // 0x000000018B159CE0-0x000000018B159DE0
		public void Set(AnimationStream stream, Vector3 value); // 0x000000018B159DE0-0x000000018B159EBC
	}

	public struct Vector3IntProperty : IAnimatableProperty<Vector3Int> // TypeDefIndex: 61423
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3IntProperty Bind(Animator animator, Component component, string name); // 0x000000018B159718-0x000000018B159890
		public static Vector3IntProperty BindCustom(Animator animator, string name); // 0x000000018B159608-0x000000018B159718
		public Vector3Int Get(AnimationStream stream); // 0x000000018B159890-0x000000018B159980
		public void Set(AnimationStream stream, Vector3Int value); // 0x000000018B159980-0x000000018B159A58
	}

	public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool> // TypeDefIndex: 61424
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3BoolProperty Bind(Animator animator, Component component, string name); // 0x000000018B1592C8-0x000000018B159440
		public static Vector3BoolProperty BindCustom(Animator animator, string name); // 0x000000018B1591B8-0x000000018B1592C8
		public Vector3Bool Get(AnimationStream stream); // 0x000000018B159440-0x000000018B159530
		public void Set(AnimationStream stream, Vector3Bool value); // 0x000000018B159530-0x000000018B159608
	}

	public struct Vector4Property : IAnimatableProperty<Vector4> // TypeDefIndex: 61425
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
		public PropertyStreamHandle w; // 0x30
	
		// Methods
		public static Vector4Property Bind(Animator animator, Component component, string name); // 0x000000018B15A00C-0x000000018B15A1D8
		public static Vector4Property BindCustom(Animator animator, string name); // 0x000000018B159EBC-0x000000018B15A00C
		public Vector4 Get(AnimationStream stream); // 0x000000018B15A1D8-0x000000018B15A324
		public void Set(AnimationStream stream, Vector4 value); // 0x000000018B15A324-0x000000018B15A440
	}

	public interface IAnimationJobBinder // TypeDefIndex: 61426
	{
		// Methods
		IAnimationJob Create(Animator animator, IAnimationJobData data, Component component = null);
		void Destroy(IAnimationJob job);
		void Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public abstract class AnimationJobBinder<TJob, TData> : IAnimationJobBinder // TypeDefIndex: 61427
		where TJob : struct, IAnimationJob
		where TData : struct, IAnimationJobData
	{
		// Constructors
		protected AnimationJobBinder();
	
		// Methods
		public abstract TJob Create(Animator animator, ref ref TData data, Component component);
		public abstract void Destroy(TJob job);
		public virtual void Update(TJob job, ref ref TData data);
		IAnimationJob IAnimationJobBinder.Create(Animator animator, IAnimationJobData data, Component component);
		void IAnimationJobBinder.Destroy(IAnimationJob job);
		void IAnimationJobBinder.Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable IAnimationJobBinder.CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public interface IAnimationJobData // TypeDefIndex: 61428
	{
		// Methods
		bool IsValid();
		void SetDefaultValues();
	}

	public interface IWeightedAnimationJob : IAnimationJob // TypeDefIndex: 61429
	{
		// Properties
		FloatProperty jobWeight { get; set; }
	}

	[BurstCompile]
	public struct MultiAimConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61431
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0234FC2D
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 aimAxis; // 0x98
		public Vector3 upAxis; // 0xA4
		public WorldUpType worldUpType; // 0xB0
		public Vector3 worldUpAxis; // 0xB4
		public ReadOnlyTransformHandle worldUpObject; // 0xC0
		public Vector3 axesMask; // 0xD8
		public FloatProperty minLimit; // 0xE4
		public FloatProperty maxLimit; // 0xF4
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x104
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAB120-0x0000000184DAB130 0x0000000184DAB130-0x0000000184DAB140
	
		// Nested types
		public enum WorldUpType // TypeDefIndex: 61430
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14C910-0x000000018B14D860
		private Vector3 ComputeWorldUpVector(AnimationStream stream); // 0x000000018B14C690-0x000000018B14C910
	}

	public interface IMultiAimConstraintData // TypeDefIndex: 61432
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		Vector3 aimAxis { get; }
		Vector3 upAxis { get; }
		int worldUpType { get; }
		Vector3 worldUpAxis { get; }
		Transform worldUpObject { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
		string offsetVector3Property { get; }
		string minLimitFloatProperty { get; }
		string maxLimitFloatProperty { get; }
		string sourceObjectsProperty { get; }
	}

	public class MultiAimConstraintJobBinder<T> : AnimationJobBinder<MultiAimConstraintJob, T> // TypeDefIndex: 61433
		where T : struct, IAnimationJobData, IMultiAimConstraintData
	{
		// Constructors
		public MultiAimConstraintJobBinder();
	
		// Methods
		public override MultiAimConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiAimConstraintJob job);
	}

	[BurstCompile]
	public struct MultiParentConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61434
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0234FC36
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x28
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x38
		public NativeArray<AffineTransform> sourceOffsets; // 0x48
		public NativeArray<float> weightBuffer; // 0x58
		public Vector3 positionAxesMask; // 0x68
		public Vector3 rotationAxesMask; // 0x74
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x80
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D90620-0x0000000184D90630 0x0000000184D9DEE0-0x0000000184D9DEF0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14DD20-0x000000018B14E7EC
	}

	public interface IMultiParentConstraintData // TypeDefIndex: 61435
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainPositionOffset { get; }
		bool maintainRotationOffset { get; }
		bool constrainedPositionXAxis { get; }
		bool constrainedPositionYAxis { get; }
		bool constrainedPositionZAxis { get; }
		bool constrainedRotationXAxis { get; }
		bool constrainedRotationYAxis { get; }
		bool constrainedRotationZAxis { get; }
		string sourceObjectsProperty { get; }
	}

	public class MultiParentConstraintJobBinder<T> : AnimationJobBinder<MultiParentConstraintJob, T> // TypeDefIndex: 61436
		where T : struct, IAnimationJobData, IMultiParentConstraintData
	{
		// Constructors
		public MultiParentConstraintJobBinder();
	
		// Methods
		public override MultiParentConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiParentConstraintJob job);
	}

	[BurstCompile]
	public struct MultiPositionConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61437
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0234FC3A
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Vector3> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAB070-0x0000000184DAB080 0x0000000184DAB080-0x0000000184DAB090
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14EC7C-0x000000018B14F378
	}

	public interface IMultiPositionConstraintData // TypeDefIndex: 61438
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		string offsetVector3Property { get; }
		string sourceObjectsProperty { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
	}

	public class MultiPositionConstraintJobBinder<T> : AnimationJobBinder<MultiPositionConstraintJob, T> // TypeDefIndex: 61439
		where T : struct, IAnimationJobData, IMultiPositionConstraintData
	{
		// Constructors
		public MultiPositionConstraintJobBinder();
	
		// Methods
		public override MultiPositionConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiPositionConstraintJob job);
	}

	[BurstCompile]
	public struct MultiReferentialConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61440
	{
		// Fields
		public IntProperty driver; // 0x00
		public NativeArray<ReadWriteTransformHandle> sources; // 0x10
		public NativeArray<AffineTransform> sourceBindTx; // 0x20
		public NativeArray<AffineTransform> offsetTx; // 0x30
		private int m_PrevDriverIdx; // 0x40
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x44
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAAF10-0x0000000184DAAF20 0x0000000184DAAF20-0x0000000184DAAF30
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B14F900-0x000000018B14FDB8
		internal void UpdateOffsets(int driver); // 0x000000018B14FDB8-0x000000018B14FF50
	}

	public interface IMultiReferentialConstraintData // TypeDefIndex: 61441
	{
		// Properties
		int driverValue { get; }
		string driverIntProperty { get; }
		Transform[] sourceObjects { get; }
	}

	public class MultiReferentialConstraintJobBinder<T> : AnimationJobBinder<MultiReferentialConstraintJob, T> // TypeDefIndex: 61442
		where T : struct, IAnimationJobData, IMultiReferentialConstraintData
	{
		// Constructors
		public MultiReferentialConstraintJobBinder();
	
		// Methods
		public override MultiReferentialConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiReferentialConstraintJob job);
	}

	[BurstCompile]
	public struct MultiRotationConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61443
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0234FC3E
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAB070-0x0000000184DAB080 0x0000000184DAB080-0x0000000184DAB090
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B1502E8-0x000000018B1509D8
	}

	public interface IMultiRotationConstraintData // TypeDefIndex: 61444
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		string offsetVector3Property { get; }
		string sourceObjectsProperty { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
	}

	public class MultiRotationConstraintJobBinder<T> : AnimationJobBinder<MultiRotationConstraintJob, T> // TypeDefIndex: 61445
		where T : struct, IAnimationJobData, IMultiRotationConstraintData
	{
		// Constructors
		public MultiRotationConstraintJobBinder();
	
		// Methods
		public override MultiRotationConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiRotationConstraintJob job);
	}

	[BurstCompile]
	public struct OverrideTransformJob : IWeightedAnimationJob // TypeDefIndex: 61447
	{
		// Fields
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform sourceInvLocalBindTx; // 0x24
		public Quaternion sourceToWorldRot; // 0x40
		public Quaternion sourceToLocalRot; // 0x50
		public Quaternion sourceToPivotRot; // 0x60
		public CacheIndex spaceIdx; // 0x70
		public CacheIndex sourceToCurrSpaceRotIdx; // 0x74
		public Vector3Property position; // 0x78
		public Vector3Property rotation; // 0xA8
		public FloatProperty positionWeight; // 0xD8
		public FloatProperty rotationWeight; // 0xE8
		public AnimationJobCache cache; // 0xF8
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x108
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DAA110-0x0000000184DAA120 0x0000000184DAA170-0x0000000184DAA180
	
		// Nested types
		public enum Space // TypeDefIndex: 61446
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B1510A4-0x000000018B151900
		internal void UpdateSpace(int space); // 0x000000018B151900-0x000000018B1519A0
	}

	public interface IOverrideTransformData // TypeDefIndex: 61448
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		int space { get; }
		string positionWeightFloatProperty { get; }
		string rotationWeightFloatProperty { get; }
		string positionVector3Property { get; }
		string rotationVector3Property { get; }
	}

	public class OverrideTransformJobBinder<T> : AnimationJobBinder<OverrideTransformJob, T> // TypeDefIndex: 61449
		where T : struct, IAnimationJobData, IOverrideTransformData
	{
		// Constructors
		public OverrideTransformJobBinder();
	
		// Methods
		public override OverrideTransformJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(OverrideTransformJob job);
		public override void Update(OverrideTransformJob job, ref ref T data);
	}

	[BurstCompile]
	internal struct RigSyncSceneToStreamJob : IAnimationJob // TypeDefIndex: 61452
	{
		// Fields
		public TransformSyncer transformSyncer; // 0x00
		public PropertySyncer propertySyncer; // 0x20
		public PropertySyncer rigWeightSyncer; // 0x50
		public PropertySyncer constraintWeightSyncer; // 0x80
		public NativeArray<float> rigStates; // 0xB0
		public NativeArray<int> rigConstraintEndIdx; // 0xC0
		public NativeArray<PropertyStreamHandle> modulatedConstraintWeights; // 0xD0
	
		// Nested types
		public struct TransformSyncer : IDisposable // TypeDefIndex: 61450
		{
			// Fields
			public NativeArray<TransformSceneHandle> sceneHandles; // 0x00
			public NativeArray<TransformStreamHandle> streamHandles; // 0x10
	
			// Methods
			public static TransformSyncer Create(int size); // 0x000000018B157674-0x000000018B157724
			public void Dispose(); // 0x000000018B157724-0x000000018B1577A0
			public void BindAt(int index, Animator animator, Transform transform); // 0x000000018B1575F8-0x000000018B157674
			public void Sync(ref AnimationStream stream); // 0x000000018B1577A0-0x000000018B15796C
		}
	
		internal struct PropertySyncer : IDisposable // TypeDefIndex: 61451
		{
			// Fields
			public NativeArray<PropertySceneHandle> sceneHandles; // 0x00
			public NativeArray<PropertyStreamHandle> streamHandles; // 0x10
			public NativeArray<float> buffer; // 0x20
	
			// Methods
			public static PropertySyncer Create(int size); // 0x000000018B151B3C-0x000000018B151C2C
			public void Dispose(); // 0x000000018B151C2C-0x000000018B151CD8
			public void BindAt(int index, Animator animator, Component component, string property); // 0x000000018B151A70-0x000000018B151B3C
			public void Sync(ref AnimationStream stream); // 0x000000018B151D54-0x000000018B151E1C
			public NativeArray<float> StreamValues(ref AnimationStream stream); // 0x000000018B151CD8-0x000000018B151D54
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B154A50-0x000000018B154B9C
	}

	internal struct SyncableProperties // TypeDefIndex: 61453
	{
		// Fields
		public RigProperties rig; // 0x00
		public ConstraintProperties[] constraints; // 0x08
	}

	internal interface IRigSyncSceneToStreamData // TypeDefIndex: 61454
	{
		// Properties
		Transform[] syncableTransforms { get; }
		SyncableProperties[] syncableProperties { get; }
		bool[] rigStates { get; }
	}

	internal class RigSyncSceneToStreamJobBinder<T> : AnimationJobBinder<RigSyncSceneToStreamJob, T> // TypeDefIndex: 61455
		where T : struct, IAnimationJobData, IRigSyncSceneToStreamData
	{
		// Fields
		internal static string[] s_PropertyElementNames;
	
		// Constructors
		public RigSyncSceneToStreamJobBinder();
		static RigSyncSceneToStreamJobBinder();
	
		// Methods
		public override RigSyncSceneToStreamJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(RigSyncSceneToStreamJob job);
		public override void Update(RigSyncSceneToStreamJob job, ref ref T data);
	}

	public struct ReadWriteTransformHandle // TypeDefIndex: 61456
	{
		// Fields
		private TransformStreamHandle m_Handle; // 0x00
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018B15283C-0x000000018B152894
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018B152894-0x000000018B1528E4
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018B1528E4-0x000000018B15293C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B15293C-0x000000018B15298C
		public void SetLocalPosition(AnimationStream stream, Vector3 position); // 0x000000018B152B60-0x000000018B152BB4
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation); // 0x000000018B152BB4-0x000000018B152BFC
		public void SetLocalScale(AnimationStream stream, Vector3 scale); // 0x000000018B152BFC-0x000000018B152C50
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false /* Metadata: 0x0234FC45 */); // 0x000000018B152C50-0x000000018B152CDC
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018B15298C-0x000000018B1529E4
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018B1529E4-0x000000018B152A34
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B1527F8-0x000000018B15283C
		public void SetPosition(AnimationStream stream, Vector3 position); // 0x000000018B152CDC-0x000000018B152D30
		public void SetRotation(AnimationStream stream, Quaternion rotation); // 0x000000018B152D30-0x000000018B152D78
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false /* Metadata: 0x0234FC46 */); // 0x000000018B152AE8-0x000000018B152B60
		public bool IsResolved(AnimationStream stream); // 0x000000018B152A34-0x000000018B152A70
		public bool IsValid(AnimationStream stream); // 0x000000018B152A70-0x000000018B152AAC
		public void Resolve(AnimationStream stream); // 0x000000018B152AAC-0x000000018B152AE8
		public static ReadWriteTransformHandle Bind(Animator animator, Transform transform); // 0x000000018B152664-0x000000018B1527F8
	}

	public struct ReadOnlyTransformHandle // TypeDefIndex: 61457
	{
		// Fields
		private TransformStreamHandle m_StreamHandle; // 0x00
		private TransformSceneHandle m_SceneHandle; // 0x0C
		private byte m_InStream; // 0x14
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018B1522EC-0x000000018B152364
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018B152364-0x000000018B1523D4
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018B1523D4-0x000000018B15244C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B15244C-0x000000018B1524A8
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018B1524A8-0x000000018B152520
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018B152520-0x000000018B152590
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B1522A0-0x000000018B1522EC
		public bool IsResolved(AnimationStream stream); // 0x000000018B152590-0x000000018B1525D4
		public bool IsValid(AnimationStream stream); // 0x000000018B1525D4-0x000000018B152620
		public void Resolve(AnimationStream stream); // 0x000000018B152620-0x000000018B152664
		public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform); // 0x000000018B152154-0x000000018B1522A0
	}

	[BurstCompile]
	public struct TwistChainConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61458
	{
		// Fields
		public ReadWriteTransformHandle rootTarget; // 0x00
		public ReadWriteTransformHandle tipTarget; // 0x0C
		public NativeArray<ReadWriteTransformHandle> chain; // 0x18
		public NativeArray<float> steps; // 0x28
		public NativeArray<float> weights; // 0x38
		public NativeArray<Quaternion> rotations; // 0x48
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x58
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D87E00-0x0000000184D87E10 0x0000000184DA61E0-0x0000000184DA61F0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B157AC0-0x000000018B157FB8
	}

	public interface ITwistChainConstraintData // TypeDefIndex: 61459
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform rootTarget { get; }
		Transform tipTarget { get; }
		AnimationCurve curve { get; }
	}

	public class TwistChainConstraintJobBinder<T> : AnimationJobBinder<TwistChainConstraintJob, T> // TypeDefIndex: 61460
		where T : struct, IAnimationJobData, ITwistChainConstraintData
	{
		// Constructors
		public TwistChainConstraintJobBinder();
	
		// Methods
		public override TwistChainConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwistChainConstraintJob job);
	}

	[BurstCompile]
	public struct TwistCorrectionJob : IWeightedAnimationJob // TypeDefIndex: 61461
	{
		// Fields
		public ReadOnlyTransformHandle source; // 0x00
		public Quaternion sourceInverseBindRotation; // 0x18
		public Vector3 axisMask; // 0x28
		public NativeArray<ReadWriteTransformHandle> twistTransforms; // 0x38
		public NativeArray<PropertyStreamHandle> twistWeights; // 0x48
		public NativeArray<Quaternion> twistBindRotations; // 0x58
		public NativeArray<float> weightBuffer; // 0x68
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x78
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D8E8F0-0x0000000184D8E900 0x0000000184DA96F0-0x0000000184DA9700
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B15820C-0x000000018B1585C8
		private static Quaternion TwistRotation(Vector3 axis, Quaternion rot); // 0x0000000184DAB160-0x0000000184DAB1A0
	}

	public interface ITwistCorrectionData // TypeDefIndex: 61462
	{
		// Properties
		Transform source { get; }
		WeightedTransformArray twistNodes { get; }
		Vector3 twistAxis { get; }
		string twistNodesProperty { get; }
	}

	public class TwistCorrectionJobBinder<T> : AnimationJobBinder<TwistCorrectionJob, T> // TypeDefIndex: 61463
		where T : struct, IAnimationJobData, ITwistCorrectionData
	{
		// Constructors
		public TwistCorrectionJobBinder();
	
		// Methods
		public override TwistCorrectionJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwistCorrectionJob job);
	}

	[BurstCompile]
	public struct TwoBoneIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 61464
	{
		// Fields
		public ReadWriteTransformHandle root; // 0x00
		public ReadWriteTransformHandle mid; // 0x0C
		public ReadWriteTransformHandle tip; // 0x18
		public ReadOnlyTransformHandle hint; // 0x24
		public ReadOnlyTransformHandle target; // 0x3C
		public AffineTransform targetOffset; // 0x54
		public FloatProperty targetPositionWeight; // 0x70
		public FloatProperty targetRotationWeight; // 0x80
		public FloatProperty hintWeight; // 0x90
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA0
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DA1260-0x0000000184DA1270 0x0000000184DA1300-0x0000000184DA1310
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessAnimation(AnimationStream stream); // 0x000000018B15896C-0x000000018B158D0C
	}

	public interface ITwoBoneIKConstraintData // TypeDefIndex: 61465
	{
		// Properties
		Transform root { get; }
		Transform mid { get; }
		Transform tip { get; }
		Transform target { get; }
		Transform hint { get; }
		bool maintainTargetPositionOffset { get; }
		bool maintainTargetRotationOffset { get; }
		string targetPositionWeightFloatProperty { get; }
		string targetRotationWeightFloatProperty { get; }
		string hintWeightFloatProperty { get; }
	}

	public class TwoBoneIKConstraintJobBinder<T> : AnimationJobBinder<TwoBoneIKConstraintJob, T> // TypeDefIndex: 61466
		where T : struct, IAnimationJobData, ITwoBoneIKConstraintData
	{
		// Constructors
		public TwoBoneIKConstraintJobBinder();
	
		// Methods
		public override TwoBoneIKConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwoBoneIKConstraintJob job);
	}

	public class WeightedTransformArrayBinder // TypeDefIndex: 61467
	{
		// Constructors
		public WeightedTransformArrayBinder(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle> transforms); // 0x000000018B15A440-0x000000018B15A554
		public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle> transforms); // 0x000000018B15A554-0x000000018B15A664
		public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle> weights); // 0x000000018B15A664-0x000000018B15A7F4
	}

	[Serializable]
	public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData // TypeDefIndex: 61468
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_SourceA; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_SourceB; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private bool m_BlendPosition; // 0x18
		[SerializeField]
		[SyncSceneToStream]
		private bool m_BlendRotation; // 0x19
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_PositionWeight; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_RotationWeight; // 0x20
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffsets; // 0x24
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffsets; // 0x25
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform sourceObjectA { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Transform sourceObjectB { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool blendPosition { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool blendRotation { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public float positionWeight { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000189F4C9E8-0x0000000189F4CA00
		public float rotationWeight { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x0000000189F4C9D0-0x0000000189F4C9E8
		public bool maintainPositionOffsets { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
		public bool maintainRotationOffsets { get; set; } // 0x0000000184D86930-0x0000000184D86940 0x0000000184D86950-0x0000000184D86960
		string IBlendConstraintData.blendPositionBoolProperty { get; } // 0x000000018B149C20-0x000000018B149C54 
		string IBlendConstraintData.blendRotationBoolProperty { get; } // 0x000000018B149C54-0x000000018B149C88 
		string IBlendConstraintData.positionWeightFloatProperty { get; } // 0x000000018B149C88-0x000000018B149CBC 
		string IBlendConstraintData.rotationWeightFloatProperty { get; } // 0x000000018B149CBC-0x000000018B149CF0 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B149B3C-0x000000018B149BD4
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B149BD4-0x000000018B149C20
	}

	[AddComponentMenu("Animation Rigging/Blend Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/BlendConstraint.html")]
	public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder<BlendConstraintData>> // TypeDefIndex: 61469
	{
		// Constructors
		public BlendConstraint(); // 0x000000018B14A2D8-0x000000018B14A32C
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14A274-0x000000018B14A2D8
	}

	[Serializable]
	public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData // TypeDefIndex: 61470
	{
		// Fields
		internal const int k_MinIterations = 1; // Metadata: 0x0234FC47
		internal const int k_MaxIterations = 50; // Metadata: 0x0234FC48
		internal const float k_MinTolerance = 0f; // Metadata: 0x0234FC49
		internal const float k_MaxTolerance = 0.01f; // Metadata: 0x0234FC4D
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Tip; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Target; // 0x10
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_ChainRotationWeight; // 0x18
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TipRotationWeight; // 0x1C
		[NotKeyable]
		[Range(1f, 50f)]
		[SerializeField]
		private int m_MaxIterations; // 0x20
		[NotKeyable]
		[Range(0f, 0.01f)]
		[SerializeField]
		private float m_Tolerance; // 0x24
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetPositionOffset; // 0x28
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetRotationOffset; // 0x29
	
		// Properties
		public Transform root { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform tip { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Transform target { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public float chainRotationWeight { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x00000001890D4BA8-0x00000001890D4BC0
		public float tipRotationWeight { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000189F4C9E8-0x0000000189F4CA00
		public int maxIterations { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018B14A6A8-0x000000018B14A6C8
		public float tolerance { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x000000018B14A6C8-0x000000018B14A6EC
		public bool maintainTargetPositionOffset { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public bool maintainTargetRotationOffset { get; set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		string IChainIKConstraintData.chainRotationWeightFloatProperty { get; } // 0x000000018B14A640-0x000000018B14A674 
		string IChainIKConstraintData.tipRotationWeightFloatProperty { get; } // 0x000000018B14A674-0x000000018B14A6A8 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14A4A8-0x000000018B14A5EC
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14A5EC-0x000000018B14A640
	}

	[AddComponentMenu("Animation Rigging/Chain IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/ChainIKConstraint.html")]
	public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder<ChainIKConstraintData>> // TypeDefIndex: 61471
	{
		// Constructors
		public ChainIKConstraint(); // 0x000000018B14AEB4-0x000000018B14AF08
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14AE00-0x000000018B14AEB4
	}

	[Serializable]
	public struct DampedTransformData : IAnimationJobData, IDampedTransformData // TypeDefIndex: 61472
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Source; // 0x08
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_DampPosition; // 0x10
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_DampRotation; // 0x14
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainAim; // 0x18
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform sourceObject { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public float dampPosition { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x000000018B14B538-0x000000018B14B550
		public float dampRotation { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x000000018B14B550-0x000000018B14B568
		public bool maintainAim { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		string IDampedTransformData.dampPositionFloatProperty { get; } // 0x000000018B14B4D0-0x000000018B14B504 
		string IDampedTransformData.dampRotationFloatProperty { get; } // 0x000000018B14B504-0x000000018B14B538 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14B41C-0x000000018B14B494
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14B494-0x000000018B14B4D0
	}

	[AddComponentMenu("Animation Rigging/Damped Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/DampedTransform.html")]
	public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder<DampedTransformData>> // TypeDefIndex: 61473
	{
		// Constructors
		public DampedTransform(); // 0x000000018B14BD74-0x000000018B14BDC8
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14BD10-0x000000018B14BD74
	}

	[Serializable]
	public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData // TypeDefIndex: 61476
	{
		// Fields
		internal const float k_MinAngularLimit = -180f; // Metadata: 0x0234FC51
		internal const float k_MaxAngularLimit = 180f; // Metadata: 0x0234FC55
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[Range(-180f, 180f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_MinLimit; // 0x9C
		[Range(-180f, 180f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_MaxLimit; // 0xA0
		[NotKeyable]
		[SerializeField]
		private Axis m_AimAxis; // 0xA4
		[NotKeyable]
		[SerializeField]
		private Axis m_UpAxis; // 0xA8
		[NotKeyable]
		[SerializeField]
		private WorldUpType m_WorldUpType; // 0xAC
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_WorldUpObject; // 0xB0
		[NotKeyable]
		[SerializeField]
		private Axis m_WorldUpAxis; // 0xB8
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0xBC
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0xBD
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public WeightedTransformArray sourceObjects { get; set; } // 0x0000000184D9C2C0-0x0000000184D9C320 0x000000018B14C62C-0x000000018B14C690
		public bool maintainOffset { get; set; } // 0x0000000184D8E640-0x0000000184D8E650 0x0000000184D8E670-0x0000000184D8E680
		public Vector3 offset { get; set; } // 0x0000000184D90DD0-0x0000000184D90DF0 0x0000000184D90E30-0x0000000184D90E50
		public Vector2 limits { get; set; } // 0x0000000184DA84B0-0x0000000184DA84D0 0x000000018B14C5CC-0x000000018B14C62C
		public Axis aimAxis { get; set; } // 0x0000000184D88C90-0x0000000184D88CA0 0x0000000184D88CF0-0x0000000184D88D00
		public Axis upAxis { get; set; } // 0x0000000184D88C80-0x0000000184D88C90 0x0000000184D88CE0-0x0000000184D88CF0
		public WorldUpType worldUpType { get; set; } // 0x0000000184D88CA0-0x0000000184D88CB0 0x0000000184D88D00-0x0000000184D88D10
		public Axis worldUpAxis { get; set; } // 0x0000000184D8E580-0x0000000184D8E590 0x0000000184D8E5A0-0x0000000184D8E5B0
		public Transform worldUpObject { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D84CE0-0x0000000184D84D00
		public bool constrainedXAxis { get; set; } // 0x0000000184DAB0C0-0x0000000184DAB0D0 0x0000000184DAB0F0-0x0000000184DAB100
		public bool constrainedYAxis { get; set; } // 0x0000000184DAB0D0-0x0000000184DAB0E0 0x0000000184DAB100-0x0000000184DAB110
		public bool constrainedZAxis { get; set; } // 0x0000000184DAB0E0-0x0000000184DAB0F0 0x0000000184DAB110-0x0000000184DAB120
		Vector3 IMultiAimConstraintData.aimAxis { get; } // 0x000000018B14C460-0x000000018B14C494 
		Vector3 IMultiAimConstraintData.upAxis { get; } // 0x000000018B14C564-0x000000018B14C598 
		int IMultiAimConstraintData.worldUpType { get; } // 0x0000000184D88CA0-0x0000000184D88CB0 
		Vector3 IMultiAimConstraintData.worldUpAxis { get; } // 0x000000018B14C598-0x000000018B14C5CC 
		string IMultiAimConstraintData.offsetVector3Property { get; } // 0x000000018B14C4FC-0x000000018B14C530 
		string IMultiAimConstraintData.minLimitFloatProperty { get; } // 0x000000018B14C4C8-0x000000018B14C4FC 
		string IMultiAimConstraintData.maxLimitFloatProperty { get; } // 0x000000018B14C494-0x000000018B14C4C8 
		string IMultiAimConstraintData.sourceObjectsProperty { get; } // 0x000000018B14C530-0x000000018B14C564 
	
		// Nested types
		public enum Axis // TypeDefIndex: 61474
		{
			X = 0,
			X_NEG = 1,
			Y = 2,
			Y_NEG = 3,
			Z = 4,
			Z_NEG = 5
		}
	
		public enum WorldUpType // TypeDefIndex: 61475
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14C17C-0x000000018B14C38C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14C38C-0x000000018B14C460
		private static Vector3 Convert(Axis axis); // 0x000000018B14C110-0x000000018B14C17C
	}

	[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiAimConstraint.html")]
	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>> // TypeDefIndex: 61477
	{
		// Constructors
		public MultiAimConstraint(); // 0x000000018B14DA04-0x000000018B14DA58
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14D860-0x000000018B14DA04
	}

	[Serializable]
	public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData // TypeDefIndex: 61478
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedPositionAxes; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedRotationAxes; // 0x93
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffset; // 0x96
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffset; // 0x97
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public WeightedTransformArray sourceObjects { get; set; } // 0x0000000184D9C2C0-0x0000000184D9C320 0x000000018B14C62C-0x000000018B14C690
		public bool maintainPositionOffset { get; set; } // 0x0000000184D893A0-0x0000000184D893B0 0x0000000184D91BE0-0x0000000184D91BF0
		public bool maintainRotationOffset { get; set; } // 0x0000000184DAB140-0x0000000184DAB150 0x0000000184DAB150-0x0000000184DAB160
		public bool constrainedPositionXAxis { get; set; } // 0x0000000182EC6590-0x0000000182EC65A0 0x0000000182EC65A0-0x0000000182EC65B0
		public bool constrainedPositionYAxis { get; set; } // 0x0000000184D88160-0x0000000184D88170 0x0000000184D88180-0x0000000184D88190
		public bool constrainedPositionZAxis { get; set; } // 0x0000000184D88170-0x0000000184D88180 0x0000000184D88190-0x0000000184D881A0
		public bool constrainedRotationXAxis { get; set; } // 0x0000000184DAA1C0-0x0000000184DAA1D0 0x0000000184DAA980-0x0000000184DAA990
		public bool constrainedRotationYAxis { get; set; } // 0x0000000184D91BC0-0x0000000184D91BD0 0x0000000184D91BD0-0x0000000184D91BE0
		public bool constrainedRotationZAxis { get; set; } // 0x0000000184D893B0-0x0000000184D893C0 0x0000000184D91BF0-0x0000000184D91C00
		string IMultiParentConstraintData.sourceObjectsProperty { get; } // 0x000000018B14DCEC-0x000000018B14DD20 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14DA58-0x000000018B14DC68
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14DC68-0x000000018B14DCEC
	}

	[AddComponentMenu("Animation Rigging/Multi-Parent Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiParentConstraint.html")]
	public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder<MultiParentConstraintData>> // TypeDefIndex: 61479
	{
		// Constructors
		public MultiParentConstraint(); // 0x000000018B14E928-0x000000018B14E97C
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14E7EC-0x000000018B14E928
	}

	[Serializable]
	public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData // TypeDefIndex: 61480
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public WeightedTransformArray sourceObjects { get; set; } // 0x0000000184D9C2C0-0x0000000184D9C320 0x000000018B14C62C-0x000000018B14C690
		public bool maintainOffset { get; set; } // 0x0000000184DA34E0-0x0000000184DA34F0 0x0000000184DA3530-0x0000000184DA3540
		public Vector3 offset { get; set; } // 0x0000000184D90DD0-0x0000000184D90DF0 0x0000000184D90E30-0x0000000184D90E50
		public bool constrainedXAxis { get; set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		public bool constrainedYAxis { get; set; } // 0x0000000184DA34D0-0x0000000184DA34E0 0x0000000184DA3520-0x0000000184DA3530
		public bool constrainedZAxis { get; set; } // 0x0000000184DA34F0-0x0000000184DA3500 0x0000000184DA3540-0x0000000184DA3550
		string IMultiPositionConstraintData.offsetVector3Property { get; } // 0x000000018B14EC14-0x000000018B14EC48 
		string IMultiPositionConstraintData.sourceObjectsProperty { get; } // 0x000000018B14EC48-0x000000018B14EC7C 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14E97C-0x000000018B14EB8C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14EB8C-0x000000018B14EC14
	}

	[AddComponentMenu("Animation Rigging/Multi-Position Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiPositionConstraint.html")]
	public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder<MultiPositionConstraintData>> // TypeDefIndex: 61481
	{
		// Constructors
		public MultiPositionConstraint(); // 0x000000018B14F4B4-0x000000018B14F508
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14F378-0x000000018B14F4B4
	}

	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData // TypeDefIndex: 61482
	{
		// Fields
		[SerializeField]
		[SyncSceneToStream]
		private int m_Driver; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private List<Transform> m_SourceObjects; // 0x08
	
		// Properties
		public int driver { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x000000018B14F834-0x000000018B14F890
		public List<Transform> sourceObjects { get; set; } // 0x000000018B14F7B0-0x000000018B14F834 0x000000018B14F890-0x000000018B14F900
		Transform[] IMultiReferentialConstraintData.sourceObjects { get; } // 0x000000018B14F718-0x000000018B14F760 
		int IMultiReferentialConstraintData.driverValue { get; } // 0x0000000182B77620-0x0000000182B77630 
		string IMultiReferentialConstraintData.driverIntProperty { get; } // 0x000000018B14F6E4-0x000000018B14F718 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14F508-0x000000018B14F66C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B14F66C-0x000000018B14F6E4
		public void UpdateDriver(); // 0x000000018B14F760-0x000000018B14F7B0
	}

	[AddComponentMenu("Animation Rigging/Multi-Referential Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiReferentialConstraint.html")]
	public class MultiReferentialConstraint : RigConstraint<MultiReferentialConstraintJob, MultiReferentialConstraintData, MultiReferentialConstraintJobBinder<MultiReferentialConstraintData>> // TypeDefIndex: 61483
	{
		// Constructors
		public MultiReferentialConstraint(); // 0x000000018B14FF94-0x000000018B14FFE8
	
		// Methods
		protected override void OnValidate(); // 0x000000018B14FF50-0x000000018B14FF94
	}

	[Serializable]
	public struct MultiRotationConstraintData : IAnimationJobData, IMultiRotationConstraintData // TypeDefIndex: 61484
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public WeightedTransformArray sourceObjects { get; set; } // 0x0000000184D9C2C0-0x0000000184D9C320 0x000000018B14C62C-0x000000018B14C690
		public bool maintainOffset { get; set; } // 0x0000000184DA34E0-0x0000000184DA34F0 0x0000000184DA3530-0x0000000184DA3540
		public Vector3 offset { get; set; } // 0x0000000184D90DD0-0x0000000184D90DF0 0x0000000184D90E30-0x0000000184D90E50
		public bool constrainedXAxis { get; set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		public bool constrainedYAxis { get; set; } // 0x0000000184DA34D0-0x0000000184DA34E0 0x0000000184DA3520-0x0000000184DA3530
		public bool constrainedZAxis { get; set; } // 0x0000000184DA34F0-0x0000000184DA3500 0x0000000184DA3540-0x0000000184DA3550
		string IMultiRotationConstraintData.offsetVector3Property { get; } // 0x000000018B150280-0x000000018B1502B4 
		string IMultiRotationConstraintData.sourceObjectsProperty { get; } // 0x000000018B1502B4-0x000000018B1502E8 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B14FFE8-0x000000018B1501F8
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B1501F8-0x000000018B150280
	}

	[AddComponentMenu("Animation Rigging/Multi-Rotation Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiRotationConstraint.html")]
	public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder<MultiRotationConstraintData>> // TypeDefIndex: 61485
	{
		// Constructors
		public MultiRotationConstraint(); // 0x000000018B150B14-0x000000018B150B68
	
		// Methods
		protected override void OnValidate(); // 0x000000018B1509D8-0x000000018B150B14
	}

	[Serializable]
	public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData // TypeDefIndex: 61487
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_OverrideSource; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_OverridePosition; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_OverrideRotation; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_PositionWeight; // 0x28
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_RotationWeight; // 0x2C
		[NotKeyable]
		[SerializeField]
		private Space m_Space; // 0x30
	
		// Properties
		public Transform constrainedObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform sourceObject { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Space space { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public Vector3 position { get; set; } // 0x0000000184D8C950-0x0000000184D8C970 0x0000000184D8C970-0x0000000184D8C980
		public Vector3 rotation { get; set; } // 0x0000000184D90520-0x0000000184D90540 0x0000000184D90500-0x0000000184D90510
		public float positionWeight { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x000000018B151074-0x000000018B15108C
		public float rotationWeight { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x000000018B15108C-0x000000018B1510A4
		int IOverrideTransformData.space { get; } // 0x0000000184D864F0-0x0000000184D86500 
		string IOverrideTransformData.positionWeightFloatProperty { get; } // 0x000000018B150FD8-0x000000018B15100C 
		string IOverrideTransformData.rotationWeightFloatProperty { get; } // 0x000000018B151040-0x000000018B151074 
		string IOverrideTransformData.positionVector3Property { get; } // 0x000000018B150FA4-0x000000018B150FD8 
		string IOverrideTransformData.rotationVector3Property { get; } // 0x000000018B15100C-0x000000018B151040 
	
		// Nested types
		[Serializable]
		public enum Space // TypeDefIndex: 61486
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B150EE4-0x000000018B150F34
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B150F34-0x000000018B150FA4
	}

	[AddComponentMenu("Animation Rigging/Override Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/OverrideTransform.html")]
	public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder<OverrideTransformData>> // TypeDefIndex: 61488
	{
		// Constructors
		public OverrideTransform(); // 0x000000018B151A04-0x000000018B151A58
	
		// Methods
		protected override void OnValidate(); // 0x000000018B1519A0-0x000000018B151A04
	}

	[Serializable]
	public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData // TypeDefIndex: 61489
	{
		// Fields
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Tip; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_RootTarget; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_TipTarget; // 0x18
		[SerializeField]
		private AnimationCurve m_Curve; // 0x20
	
		// Properties
		public Transform root { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform tip { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Transform rootTarget { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Transform tipTarget { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public AnimationCurve curve { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B15796C-0x000000018B157A54
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B157A54-0x000000018B157AC0
	}

	[AddComponentMenu("Animation Rigging/Twist Chain Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistChainConstraint.html")]
	public class TwistChainConstraint : RigConstraint<TwistChainConstraintJob, TwistChainConstraintData, TwistChainConstraintJobBinder<TwistChainConstraintData>> // TypeDefIndex: 61490
	{
		// Constructors
		public TwistChainConstraint(); // 0x000000018B157FB8-0x000000018B15800C
	}

	[Serializable]
	public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData // TypeDefIndex: 61492
	{
		// Fields
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Source; // 0x00
		[NotKeyable]
		[SerializeField]
		private Axis m_TwistAxis; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(-1f, 1f)]
		private WeightedTransformArray m_TwistNodes; // 0x10
	
		// Properties
		public Transform sourceObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public WeightedTransformArray twistNodes { get; set; } // 0x0000000184D97660-0x0000000184D976C0 0x000000018B1581A8-0x000000018B15820C
		public Axis twistAxis { get; set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
		Transform ITwistCorrectionData.source { get; } // 0x0000000182B76770-0x0000000182B76780 
		Vector3 ITwistCorrectionData.twistAxis { get; } // 0x000000018B158144-0x000000018B158174 
		string ITwistCorrectionData.twistNodesProperty { get; } // 0x000000018B158174-0x000000018B1581A8 
	
		// Nested types
		public enum Axis // TypeDefIndex: 61491
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Methods
		private static Vector3 Convert(Axis axis); // 0x000000018ABD4DF4-0x000000018ABD4E34
		bool IAnimationJobData.IsValid(); // 0x000000018B15800C-0x000000018B1580E4
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B1580E4-0x000000018B158144
	}

	[AddComponentMenu("Animation Rigging/Twist Correction")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistCorrection.html")]
	public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder<TwistCorrectionData>> // TypeDefIndex: 61493
	{
		// Constructors
		public TwistCorrection(); // 0x000000018B15870C-0x000000018B158760
	
		// Methods
		protected override void OnValidate(); // 0x000000018B1585C8-0x000000018B15870C
	}

	[Serializable]
	public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData // TypeDefIndex: 61494
	{
		// Fields
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Mid; // 0x08
		[SerializeField]
		private Transform m_Tip; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Target; // 0x18
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Hint; // 0x20
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TargetPositionWeight; // 0x28
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TargetRotationWeight; // 0x2C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_HintWeight; // 0x30
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetPositionOffset; // 0x34
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetRotationOffset; // 0x35
	
		// Properties
		public Transform root { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform mid { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Transform tip { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Transform target { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Transform hint { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public float targetPositionWeight { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x000000018B151074-0x000000018B15108C
		public float targetRotationWeight { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x000000018B15108C-0x000000018B1510A4
		public float hintWeight { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x000000018B158954-0x000000018B15896C
		public bool maintainTargetPositionOffset { get; set; } // 0x0000000184D86A90-0x0000000184D86AA0 0x0000000184D86AA0-0x0000000184D86AB0
		public bool maintainTargetRotationOffset { get; set; } // 0x0000000184D86D30-0x0000000184D86D40 0x0000000184D86D40-0x0000000184D86D50
		string ITwoBoneIKConstraintData.targetPositionWeightFloatProperty { get; } // 0x000000018B1588EC-0x000000018B158920 
		string ITwoBoneIKConstraintData.targetRotationWeightFloatProperty { get; } // 0x000000018B158920-0x000000018B158954 
		string ITwoBoneIKConstraintData.hintWeightFloatProperty { get; } // 0x000000018B1588B8-0x000000018B1588EC 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018B158760-0x000000018B158854
		void IAnimationJobData.SetDefaultValues(); // 0x000000018B158854-0x000000018B1588B8
	}

	[AddComponentMenu("Animation Rigging/Two Bone IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwoBoneIKConstraint.html")]
	public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder<TwoBoneIKConstraintData>> // TypeDefIndex: 61495
	{
		// Constructors
		public TwoBoneIKConstraint(); // 0x000000018B158D84-0x000000018B158DD8
	
		// Methods
		protected override void OnValidate(); // 0x000000018B158D0C-0x000000018B158D84
	}

	public interface IRigConstraint // TypeDefIndex: 61496
	{
		// Properties
		IAnimationJobData data { get; }
		IAnimationJobBinder binder { get; }
		Component component { get; }
		float weight { get; set; }
	
		// Methods
		bool IsValid();
		IAnimationJob CreateJob(Animator animator);
		void UpdateJob(IAnimationJob job);
		void DestroyJob(IAnimationJob job);
	}

	public interface IRigLayer // TypeDefIndex: 61497
	{
		// Properties
		Rig rig { get; }
		IRigConstraint[] constraints { get; }
		IAnimationJob[] jobs { get; }
		bool active { get; }
		string name { get; }
	
		// Methods
		bool Initialize(Animator animator);
		void Update();
		void Reset();
		bool IsValid();
	}

	public class OverrideRigConstraint<TConstraint, TJob, TData, TBinder> : IRigConstraint // TypeDefIndex: 61498
		where TConstraint : MonoBehaviour, IRigConstraint
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		[SerializeField]
		protected TConstraint m_Constraint;
		private static readonly TBinder s_Binder;
	
		// Properties
		IAnimationJobBinder IRigConstraint.binder { get; }
		IAnimationJobData IRigConstraint.data { get; }
		Component IRigConstraint.component { get; }
		public float weight { get; set; }
	
		// Constructors
		public OverrideRigConstraint(TConstraint baseConstraint);
		static OverrideRigConstraint();
	
		// Methods
		public IAnimationJob CreateJob(Animator animator);
		public void DestroyJob(IAnimationJob job);
		public void UpdateJob(IAnimationJob job);
		public bool IsValid();
	}

	[Serializable]
	public class OverrideRigLayer : IRigLayer // TypeDefIndex: 61499
	{
		// Fields
		[FormerlySerializedAs("rig")]
		[SerializeField]
		private Rig m_Rig; // 0x10
		[FormerlySerializedAs("active")]
		[SerializeField]
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get; private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool active { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public string name { get; } // 0x000000018B150E54-0x000000018B150EE4 
		public IRigConstraint[] constraints { get; } // 0x000000018B150E34-0x000000018B150E44 
		public IAnimationJob[] jobs { get; } // 0x000000018B150E44-0x000000018B150E54 
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
	
		// Constructors
		public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true /* Metadata: 0x0234FC6A */); // 0x000000018B150E04-0x000000018B150E34
	
		// Methods
		public bool Initialize(Animator animator); // 0x000000018B150B68-0x000000018B150C98
		public void Update(); // 0x000000018B150D98-0x000000018B150E04
		public void Reset(); // 0x000000018B150CF4-0x000000018B150D98
		public bool IsValid(); // 0x000000018B150C98-0x000000018B150CF4
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-component")]
	public class Rig : MonoBehaviour, IRigEffectorHolder // TypeDefIndex: 61500
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Weight; // 0x18
		[SerializeField]
		private List<RigEffectorData> m_Effectors; // 0x20
	
		// Properties
		public float weight { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x00000001890D4BA8-0x00000001890D4BC0
	
		// Constructors
		public Rig(); // 0x000000018B1571A0-0x000000018B157228
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Builder")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-builder-component")]
	[RequireComponent(typeof(Animator))]
	public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder // TypeDefIndex: 61503
	{
		// Fields
		[SerializeField]
		private List<RigLayer> m_RigLayers; // 0x18
		private IRigLayer[] m_RuntimeRigLayers; // 0x20
		private SyncSceneToStreamLayer m_SyncSceneToStreamLayer; // 0x28
		[SerializeField]
		private List<RigEffectorData> m_Effectors; // 0x30
		public static OnAddRigBuilderCallback onAddRigBuilder; // 0x00
		public static OnRemoveRigBuilderCallback onRemoveRigBuilder; // 0x08
		[CompilerGenerated]
		private PlayableGraph _graph_k__BackingField; // 0x38
	
		// Properties
		public List<RigLayer> layers { get; set; } // 0x000000018B154304-0x000000018B154388 0x0000000185392C40-0x0000000185392C50
		private SyncSceneToStreamLayer syncSceneToStreamLayer { get; set; } // 0x000000018B154388-0x000000018B1543C8 0x0000000182FDB880-0x0000000182FDB890
		public PlayableGraph graph { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FD20-0x0000000184D8FD30 0x0000000184D91AB0-0x0000000184D91AC0
	
		// Nested types
		public delegate void OnAddRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 61501; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void OnRemoveRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 61502; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public RigBuilder(); // 0x000000018B154284-0x000000018B154304
	
		// Methods
		private void OnEnable(); // 0x000000018B153F4C-0x000000018B153FB0
		private void OnDisable(); // 0x000000018B153EE4-0x000000018B153F4C
		private void OnDestroy(); // 0x000000018B153EDC-0x000000018B153EE4
		private void Update(); // 0x000000018B154190-0x000000018B154284
		public bool Build(); // 0x000000018B153C7C-0x000000018B153DF4
		public void Clear(); // 0x000000018B153DF4-0x000000018B153EDC
		public void StartPreview(); // 0x000000018B153FB0-0x000000018B1540B0
		public void StopPreview(); // 0x000000018B1540B0-0x000000018B1540E4
		public void UpdatePreviewGraph(PlayableGraph graph); // 0x000000018B1540E4-0x000000018B154190
		public Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable); // 0x000000018B1539C0-0x000000018B153C7C
	}

	internal static class RigBuilderUtils // TypeDefIndex: 61505
	{
		// Fields
		private static readonly ushort k_AnimationOutputPriority; // 0x00
	
		// Nested types
		public struct PlayableChain // TypeDefIndex: 61504
		{
			// Fields
			public string name; // 0x00
			public Playable[] playables; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018B151A58-0x000000018B151A70
		}
	
		// Constructors
		static RigBuilderUtils(); // 0x000000018B153988-0x000000018B1539C0
	
		// Methods
		public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer); // 0x000000018B153760-0x000000018B153988
		public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer); // 0x000000018B153148-0x000000018B153760
		public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer); // 0x000000018B152D78-0x000000018B153148
	}

	public class RigConstraint<TJob, TData, TBinder> : MonoBehaviour, IRigConstraint // TypeDefIndex: 61506
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		protected float m_Weight;
		[ExpandChildren]
		[SerializeField]
		protected TData m_Data;
		private static readonly TBinder s_Binder;
	
		// Properties
		public ref TData data { get; }
		public float weight { get; set; }
		IAnimationJobBinder IRigConstraint.binder { get; }
		IAnimationJobData IRigConstraint.data { get; }
		Component IRigConstraint.component { get; }
	
		// Constructors
		public RigConstraint();
		static RigConstraint();
	
		// Methods
		public void Reset();
		public bool IsValid();
		protected virtual void OnValidate();
		public IAnimationJob CreateJob(Animator animator);
		public void DestroyJob(IAnimationJob job);
		public void UpdateJob(IAnimationJob job);
	}

	[Serializable]
	public class RigLayer : IRigLayer // TypeDefIndex: 61507
	{
		// Fields
		[FormerlySerializedAs("rig")]
		[SerializeField]
		private Rig m_Rig; // 0x10
		[FormerlySerializedAs("active")]
		[SerializeField]
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get; private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool active { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public string name { get; } // 0x000000018B154654-0x000000018B1546E4 
		public IRigConstraint[] constraints { get; } // 0x000000018B150E34-0x000000018B150E44 
		public IAnimationJob[] jobs { get; } // 0x000000018B150E44-0x000000018B150E54 
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
	
		// Constructors
		public RigLayer(Rig rig, bool active = true /* Metadata: 0x0234FC6B */); // 0x000000018A8D8D40-0x000000018A8D8D68
	
		// Methods
		public bool Initialize(Animator animator); // 0x000000018B154418-0x000000018B154500
		public void Update(); // 0x000000018B1545D0-0x000000018B154654
		public void Reset(); // 0x000000018B154548-0x000000018B1545D0
		public bool IsValid(); // 0x000000018B154500-0x000000018B154548
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-transform")]
	public class RigTransform : MonoBehaviour // TypeDefIndex: 61508
	{
		// Constructors
		public RigTransform(); // 0x0000000185393520-0x0000000185393538
	}

	internal static class RigUtils // TypeDefIndex: 61511
	{
		// Fields
		internal static readonly Dictionary<System.Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor; // 0x00
		[CompilerGenerated]
		private static readonly IAnimationJobBinder _syncSceneToStreamBinder_k__BackingField; // 0x08
	
		// Properties
		public static IAnimationJobBinder syncSceneToStreamBinder { [CompilerGenerated] get; } // 0x000000018B157150-0x000000018B1571A0 
	
		// Nested types
		private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData // TypeDefIndex: 61509
		{
			// Fields
			[CompilerGenerated]
			private Transform[] _syncableTransforms_k__BackingField; // 0x00
			[CompilerGenerated]
			private SyncableProperties[] _syncableProperties_k__BackingField; // 0x08
			[CompilerGenerated]
			private bool[] _rigStates_k__BackingField; // 0x10
			private readonly bool m_IsValid; // 0x18
	
			// Properties
			public Transform[] syncableTransforms { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
			public SyncableProperties[] syncableProperties { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
			public bool[] rigStates { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount); // 0x000000018B1548C8-0x000000018B154A50
	
			// Methods
			private static int[] UniqueTransformIndices(Transform[] transforms); // 0x000000018B154740-0x000000018B154898
			bool IAnimationJobData.IsValid(); // 0x0000000184D86340-0x0000000184D86350
			void IAnimationJobData.SetDefaultValues(); // 0x000000018B154898-0x000000018B1548C8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61510
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Reflection.FieldInfo, bool> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B158E18-0x000000018B158E7C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ExtractNestedPropertyType_b__6_0(System.Reflection.FieldInfo info); // 0x000000018B158DD8-0x000000018B158E18
		}
	
		// Constructors
		static RigUtils(); // 0x000000018B156DC4-0x000000018B157150
	
		// Methods
		public static IRigConstraint[] GetConstraints(Rig rig); // 0x000000018B156BA4-0x000000018B156CD8
		private static Transform[] GetSyncableRigTransforms(Animator animator); // 0x000000018B156CD8-0x000000018B156DC4
		private static bool ExtractTransformType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms); // 0x000000018B1560D0-0x000000018B156508
		private static bool ExtractPropertyType(System.Reflection.FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0234FC6C */); // 0x000000018B155F90-0x000000018B1560D0
		private static bool ExtractWeightedTransforms(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties); // 0x000000018B156508-0x000000018B156BA4
		private static bool ExtractNestedPropertyType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0234FC6D */); // 0x000000018B155980-0x000000018B155F90
		private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform> syncableTransforms, out List<SyncableProperties> syncableProperties); // 0x000000018B154E0C-0x000000018B155980
		public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints); // 0x000000018B154B9C-0x000000018B154C68
		public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs); // 0x000000018B154D9C-0x000000018B154E0C
		internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers); // 0x000000018B154C68-0x000000018B154D9C
	}

	internal class SyncSceneToStreamLayer // TypeDefIndex: 61512
	{
		// Fields
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x10
		public IAnimationJob job; // 0x18
		private IAnimationJobData m_Data; // 0x20
		private List<int> m_RigIndices; // 0x28
	
		// Properties
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public SyncSceneToStreamLayer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool Initialize(Animator animator, IList<IRigLayer> layers); // 0x000000018B157228-0x000000018B1573F8
		public void Update(IList<IRigLayer> layers); // 0x000000018B157498-0x000000018B1575F8
		public void Reset(); // 0x000000018B15740C-0x000000018B157498
		public bool IsValid(); // 0x000000018B1573F8-0x000000018B15740C
	}

	public interface ITransformProvider // TypeDefIndex: 61513
	{
		// Properties
		Transform transform { get; set; }
	}

	public interface IWeightProvider // TypeDefIndex: 61514
	{
		// Properties
		float weight { get; set; }
	}

	[Serializable]
	public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform> // TypeDefIndex: 61515
	{
		// Fields
		public Transform transform; // 0x00
		public float weight; // 0x08
	
		// Properties
		Transform ITransformProvider.transform { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		float IWeightProvider.weight { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x000000018B15BE44-0x000000018B15BE5C
	
		// Constructors
		public WeightedTransform(Transform transform, float weight); // 0x000000018B15BE5C-0x000000018B15BE80
	
		// Methods
		public static WeightedTransform Default(float weight); // 0x000000018B15BDA4-0x000000018B15BDCC
		public bool Equals(WeightedTransform other); // 0x000000018B15BDCC-0x000000018B15BE44
	}

	[Serializable]
	public struct WeightedTransformArray : IList<WeightedTransform>, IList // TypeDefIndex: 61517
	{
		// Fields
		public static readonly int k_MaxLength; // 0x00
		[NotKeyable]
		[SerializeField]
		private int m_Length; // 0x00
		[SerializeField]
		private WeightedTransform m_Item0; // 0x08
		[SerializeField]
		private WeightedTransform m_Item1; // 0x18
		[SerializeField]
		private WeightedTransform m_Item2; // 0x28
		[SerializeField]
		private WeightedTransform m_Item3; // 0x38
		[SerializeField]
		private WeightedTransform m_Item4; // 0x48
		[SerializeField]
		private WeightedTransform m_Item5; // 0x58
		[SerializeField]
		private WeightedTransform m_Item6; // 0x68
		[SerializeField]
		private WeightedTransform m_Item7; // 0x78
	
		// Properties
		object IList.this[int index] { get => default; set {} } // 0x000000018B15BB14-0x000000018B15BB90 0x000000018B15BB90-0x000000018B15BC18
		public WeightedTransform this[int index] { get => default; set {} } // 0x000000018B15BCC8-0x000000018B15BD38 0x000000018B15BD38-0x000000018B15BDA4
		public int Count { get; } // 0x0000000182B77620-0x0000000182B77630 
		public bool IsReadOnly { get; } // 0x00000001812081B0-0x0000000181208610 
		public bool IsFixedSize { get; } // 0x00000001812081B0-0x0000000181208610 
		bool ICollection.IsSynchronized { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		object ICollection.SyncRoot { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Nested types
		[Serializable]
		private struct Enumerator : IEnumerator<WeightedTransform> // TypeDefIndex: 61516
		{
			// Fields
			private WeightedTransformArray m_Array; // 0x00
			private int m_Index; // 0x88
	
			// Properties
			public WeightedTransform Current { get; } // 0x000000018B14BF40-0x000000018B14BFB0 
			object IEnumerator.Current { get; } // 0x000000018B14BE1C-0x000000018B14BE74 
	
			// Constructors
			public Enumerator(ref WeightedTransformArray array); // 0x000000018B14BE74-0x000000018B14BF40
	
			// Methods
			public bool MoveNext(); // 0x000000018B14BDC8-0x000000018B14BE1C
			public void Reset(); // 0x0000000184DAB0B0-0x0000000184DAB0C0
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public WeightedTransformArray(int size); // 0x000000018B15BC54-0x000000018B15BCC8
		static WeightedTransformArray(); // 0x000000018B15BC18-0x000000018B15BC54
	
		// Methods
		public IEnumerator<WeightedTransform> GetEnumerator(); // 0x000000018B15ACF0-0x000000018B15ADB0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B15B7E8-0x000000018B15B8A8
		int IList.Add(object value); // 0x000000018B15B8A8-0x000000018B15B924
		public void Add(WeightedTransform value); // 0x000000018B15A7F4-0x000000018B15A928
		public void Clear(); // 0x0000000184D910C0-0x0000000184D910D0
		int IList.IndexOf(object value); // 0x000000018B15B99C-0x000000018B15BA14
		public int IndexOf(WeightedTransform value); // 0x000000018B15AF20-0x000000018B15AFBC
		bool IList.Contains(object value); // 0x000000018B15B924-0x000000018B15B99C
		public bool Contains(WeightedTransform value); // 0x000000018B15AA8C-0x000000018B15AB28
		void ICollection.CopyTo(Array array, int arrayIndex); // 0x000000018B15B600-0x000000018B15B7E8
		public void CopyTo(WeightedTransform[] array, int arrayIndex); // 0x000000018B15AB28-0x000000018B15ACF0
		void IList.Remove(object value); // 0x000000018B15BA9C-0x000000018B15BB14
		public bool Remove(WeightedTransform value); // 0x000000018B15B2E8-0x000000018B15B3D4
		public void RemoveAt(int index); // 0x000000018B15B250-0x000000018B15B2E8
		void IList.Insert(int index, object value); // 0x000000018B15BA14-0x000000018B15BA9C
		public void Insert(int index, WeightedTransform value); // 0x000000018B15AFBC-0x000000018B15B18C
		private static int ClampSize(int size); // 0x000000018B15AA38-0x000000018B15AA8C
		private void CheckOutOfRangeIndex(int index); // 0x000000018B15A928-0x000000018B15AA38
		private WeightedTransform Get(int index); // 0x000000018B15AE64-0x000000018B15AF20
		private void Set(int index, WeightedTransform value); // 0x000000018B15B504-0x000000018B15B600
		public void SetWeight(int index, float weight); // 0x000000018B15B474-0x000000018B15B504
		public float GetWeight(int index); // 0x000000018B15AE08-0x000000018B15AE64
		public void SetTransform(int index, Transform transform); // 0x000000018B15B3D4-0x000000018B15B474
		public Transform GetTransform(int index); // 0x000000018B15ADB0-0x000000018B15AE08
		public static void OnValidate(ref WeightedTransformArray array, float min = 0f /* Metadata: 0x0234FC6E */, float max = 1f /* Metadata: 0x0234FC72 */); // 0x000000018B15B18C-0x000000018B15B250
	}

	internal sealed class ExpandChildrenAttribute : PropertyAttribute // TypeDefIndex: 61518
	{
		// Constructors
		public ExpandChildrenAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class SyncSceneToStreamAttribute : Attribute // TypeDefIndex: 61519
	{
		// Constructors
		public SyncSceneToStreamAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal enum PropertyType : byte // TypeDefIndex: 61520
	{
		Bool = 0,
		Int = 1,
		Float = 2
	}

	internal struct PropertyDescriptor // TypeDefIndex: 61521
	{
		// Fields
		public int size; // 0x00
		public PropertyType type; // 0x04
	}

	internal struct Property // TypeDefIndex: 61522
	{
		// Fields
		public string name; // 0x00
		public PropertyDescriptor descriptor; // 0x08
	}

	internal struct RigProperties // TypeDefIndex: 61523
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
	
		// Constructors
		static RigProperties(); // 0x000000018B1546E4-0x000000018B154740
	}

	internal struct ConstraintProperties // TypeDefIndex: 61524
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
		public Property[] properties; // 0x08
	
		// Constructors
		static ConstraintProperties(); // 0x000000018B14AF08-0x000000018B14AF64
	}

	[Obsolete("PropertyUtils is deprecated. Use ConstraintsUtils instead. (UnityUpgradable) -> ConstraintsUtils")]
	public static class PropertyUtils // TypeDefIndex: 61525
	{
		// Methods
		[Obsolete("ConstructConstraintDataPropertyName is deprecated. Use ConstraintsUtils.ConstructConstraintDataPropertyName instead.")]
		public static string ConstructConstraintDataPropertyName(string property); // 0x000000018B151E1C-0x000000018B151E24
		[Obsolete("ConstructCustomPropertyName is deprecated. Use ConstraintsUtils.ConstructCustomPropertyName instead.")]
		public static string ConstructCustomPropertyName(Component component, string property); // 0x000000018B151E24-0x000000018B151E2C
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class WeightRangeAttribute : PropertyAttribute // TypeDefIndex: 61526
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public WeightRangeAttribute(float min, float max); // 0x0000000184D8D120-0x0000000184D8D130
	}

	public interface IRigEffectorHolder // TypeDefIndex: 61527
	{
	}

	[Serializable]
	public class RigEffectorData // TypeDefIndex: 61529
	{
		// Fields
		[SerializeField]
		private Transform m_Transform; // 0x10
		[SerializeField]
		private Style m_Style; // 0x18
		[SerializeField]
		private bool m_Visible; // 0x50
	
		// Properties
		public Transform transform { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public Style style { get; } // 0x0000000184D98300-0x0000000184D98330 
		public bool visible { get; set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 61528
		{
			// Fields
			public Mesh shape; // 0x00
			public UnityEngine.Color color; // 0x08
			public float size; // 0x18
			public Vector3 position; // 0x1C
			public Vector3 rotation; // 0x28
		}
	
		// Constructors
		public RigEffectorData(); // 0x0000000184DA9DE0-0x0000000184DA9DF0
	
		// Methods
		public void Initialize(Transform transform, Style style); // 0x000000018B1543C8-0x000000018B154418
	}

	[Serializable]
	public struct AffineTransform // TypeDefIndex: 61530
	{
		// Fields
		public Vector3 translation; // 0x00
		public Quaternion rotation; // 0x0C
		[CompilerGenerated]
		private static readonly AffineTransform _identity_k__BackingField; // 0x00
	
		// Properties
		public static AffineTransform identity { [CompilerGenerated] get; } // 0x000000018B147E1C-0x000000018B147E7C 
	
		// Constructors
		public AffineTransform(Vector3 t, Quaternion r); // 0x0000000184D91FA0-0x0000000184D91FC0
		static AffineTransform(); // 0x000000018B147D90-0x000000018B147E1C
	
		// Methods
		public void Set(Vector3 t, Quaternion r); // 0x0000000184D91FA0-0x0000000184D91FC0
		public Vector3 Transform(Vector3 p); // 0x000000018722ACFC-0x000000018722AD88
		public Vector3 InverseTransform(Vector3 p); // 0x000000018722AB8C-0x000000018722AC4C
		public AffineTransform Inverse(); // 0x000000018722AC4C-0x000000018722ACFC
		public AffineTransform InverseMul(AffineTransform transform); // 0x000000018722AA64-0x000000018722AB8C
		public static Vector3 operator *(AffineTransform lhs, Vector3 rhs); // 0x000000018722ACFC-0x000000018722AD88
		public static AffineTransform operator *(AffineTransform lhs, AffineTransform rhs); // 0x000000018B147E7C-0x000000018B147F90
		public static AffineTransform operator *(Quaternion lhs, AffineTransform rhs); // 0x000000018722AF88-0x000000018722B028
		public static AffineTransform operator *(AffineTransform lhs, Quaternion rhs); // 0x000000018722B028-0x000000018722B07C
	}

	public static class AnimationRuntimeUtils // TypeDefIndex: 61531
	{
		// Fields
		private const float k_SqrEpsilon = 1E-08f; // Metadata: 0x0234FC79
	
		// Methods
		public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset); // 0x000000018B148D48-0x000000018B149A9C
		private static float TriangleAngle(float aLen, float aLen1, float aLen2); // 0x000000018B149AEC-0x000000018B149B3C
		public static bool SolveFABRIK(ref NativeArray<Vector3> linkPositions, ref NativeArray<float> linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations); // 0x000000018B14889C-0x000000018B148D48
		public static float SqrDistance(Vector3 lhs, Vector3 rhs); // 0x0000000186888FD0-0x000000018688902C
		public static float Square(float value); // 0x0000000184D886E0-0x0000000184D886F0
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t); // 0x000000018B148570-0x000000018B148674
		public static float Select(float a, float b, float c); // 0x000000018B148890-0x000000018B14889C
		public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c); // 0x000000018B148834-0x000000018B148890
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal); // 0x000000018B148774-0x000000018B148834
		internal static float Sum(AnimationJobCache cache, CacheIndex index, int count); // 0x000000018B149AC4-0x000000018B149AEC
		public static float Sum(NativeArray<float> floatBuffer); // 0x000000018B149A9C-0x000000018B149AC4
		public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle); // 0x000000018B148674-0x000000018B148774
	}

	[AddComponentMenu("Animation Rigging/Setup/Bone Renderer")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#bone-renderer-component")]
	public class BoneRenderer : MonoBehaviour // TypeDefIndex: 61533
	{
		// Fields
		public BoneShape boneShape; // 0x18
		public bool drawBones; // 0x1C
		public bool drawTripods; // 0x1D
		[Range(0.01f, 5f)]
		public float boneSize; // 0x20
		[Range(0.01f, 5f)]
		public float tripodSize; // 0x24
		public UnityEngine.Color boneColor; // 0x28
		[SerializeField]
		private Transform[] m_Transforms; // 0x38
	
		// Properties
		public Transform[] transforms { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Nested types
		public enum BoneShape // TypeDefIndex: 61532
		{
			Line = 0,
			Pyramid = 1,
			Box = 2
		}
	
		// Constructors
		public BoneRenderer(); // 0x000000018B14A32C-0x000000018B14A368
	}

	public static class ConstraintsUtils // TypeDefIndex: 61535
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 61534
		{
			// Fields
			public float totalLength; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ExtractSteps_b__0(float length); // 0x0000000184DAB1A0-0x0000000184DAB1B0
		}
	
		// Methods
		public static Transform[] ExtractChain(Transform root, Transform tip); // 0x000000018B14B0D0-0x000000018B14B220
		public static float[] ExtractLengths(Transform[] chain); // 0x000000018B14B220-0x000000018B14B2EC
		public static float[] ExtractSteps(Transform[] chain); // 0x000000018B14B2EC-0x000000018B14B41C
		public static string ConstructConstraintDataPropertyName(string property); // 0x000000018B14AF64-0x000000018B14AFA0
		public static string ConstructCustomPropertyName(Component component, string property); // 0x000000018B14AFA0-0x000000018B14B0D0
	}

	public static class QuaternionExt // TypeDefIndex: 61536
	{
		// Fields
		private const float k_FloatMin = 1E-10f; // Metadata: 0x0234FC80
		public static readonly Quaternion zero; // 0x00
	
		// Constructors
		static QuaternionExt(); // 0x000000018B152118-0x000000018B152154
	
		// Methods
		public static Quaternion FromToRotation(Vector3 from, Vector3 to); // 0x000000018B151EB0-0x000000018B1520A4
		public static Quaternion Add(Quaternion rhs, Quaternion lhs); // 0x000000018B151E2C-0x000000018B151EB0
		public static Quaternion Scale(Quaternion q, float scale); // 0x000000018308B480-0x000000018308B4A0
		public static Quaternion NormalizeSafe(Quaternion q); // 0x000000018B1520A4-0x000000018B152118
	}

	[Serializable]
	public struct Vector3Bool // TypeDefIndex: 61537
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Constructors
		public Vector3Bool(bool val); // 0x0000000184DAB1B0-0x0000000184DAB1C0
		public Vector3Bool(bool x, bool y, bool z); // 0x0000000184DA0780-0x0000000184DA0790
	}
}
