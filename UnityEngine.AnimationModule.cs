/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 48: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87420-87536

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 87421
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 87422
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	public interface IAnimationClipSource // TypeDefIndex: 87423
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[RequiredByNativeCode]
	public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 87424
	{
		// Constructors
		public SharedBetweenAnimatorsAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 87425
	{
		// Constructors
		protected StateMachineBehaviour(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum PlayMode // TypeDefIndex: 87426
	{
		StopSameLayer = 0,
		StopAll = 4
	}

	public enum QueueMode // TypeDefIndex: 87427
	{
		CompleteOthers = 0,
		PlayNow = 2
	}

	public enum AnimationBlendMode // TypeDefIndex: 87428
	{
		Blend = 0,
		Additive = 1
	}

	public enum AnimationPlayMode // TypeDefIndex: 87429
	{
		Stop = 0,
		Queue = 1,
		Mix = 2
	}

	public enum AnimationCullingType // TypeDefIndex: 87430
	{
		AlwaysAnimate = 0,
		BasedOnRenderers = 1,
		BasedOnClipBounds = 2,
		BasedOnUserBounds = 3
	}

	internal enum AnimationEventSource // TypeDefIndex: 87431
	{
		NoSource = 0,
		Legacy = 1,
		Animator = 2
	}

	public enum AnimEventHashCodeType // TypeDefIndex: 87432
	{
		None = 0,
		CRC32 = 1,
		HashCode64 = 2
	}

	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : UnityEngine.Behaviour, IEnumerable // TypeDefIndex: 87434
	{
		// Properties
		public AnimationClip clip { get; set; } // 0x000000018D4C05EC-0x000000018D4C0620 0x000000018D4C07B8-0x000000018D4C07FC
		public bool playAutomatically { get; set; } // 0x000000018D4C06C8-0x000000018D4C06FC 0x000000018508F9D0-0x000000018508FA20
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x000000018D4C06FC-0x000000018D4C0730 0x000000018D4C0894-0x000000018D4C08D4
		public bool isPlaying { [NativeName("IsPlaying")] get; } // 0x0000000186D3C7E0-0x0000000186D3C820 
		public UnityEngine.AnimationState this[string name] { get => default; } // 0x000000018783C178-0x000000018783C184 
		public bool animatePhysics { get; set; } // 0x000000018D4C05B8-0x000000018D4C05EC 0x000000018D4C0774-0x000000018D4C07B8
		[Obsolete("Use cullingType instead")]
		public bool animateOnlyIfVisible { [FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = true)] get; [FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = true)] set; } // 0x000000018D4C0584-0x000000018D4C05B8 0x000000018D4C0730-0x000000018D4C0774
		public AnimationCullingType cullingType { get; set; } // 0x000000018D4C0620-0x000000018D4C0654 0x000000018D4C07FC-0x000000018D4C083C
		public Bounds localBounds { [NativeName("GetLocalAABB")] get; [NativeName("SetLocalAABB")] set; } // 0x000000018D4C0698-0x000000018D4C06C8 0x000000018D4C0880-0x000000018D4C0894
	
		// Nested types
		private sealed class Enumerator : IEnumerator // TypeDefIndex: 87433
		{
			// Fields
			private Animation m_Outer; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public object Current { get; } // 0x0000000186256980-0x00000001862569E0 
	
			// Constructors
			internal Enumerator(Animation outer); // 0x00000001850924E0-0x0000000185092500
	
			// Methods
			public bool MoveNext(); // 0x000000018615E120-0x000000018615E190
			public void Reset(); // 0x0000000187234900-0x0000000187234910
		}
	
		// Constructors
		public Animation(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Stop(); // 0x0000000186B807E0-0x0000000186B80820
		public void Stop(string name); // 0x000000018783C184-0x000000018783C18C
		[NativeName("Stop")]
		private void StopNamed(string name); // 0x0000000186D0A470-0x0000000186D0A4C0
		public void Rewind(); // 0x000000018D4C04D4-0x000000018D4C0508
		public void Rewind(string name); // 0x000000018D4C0508-0x000000018D4C0510
		[NativeName("Rewind")]
		private void RewindNamed(string name); // 0x000000018D4C0490-0x000000018D4C04D4
		public void Sample(); // 0x000000018D4C0510-0x000000018D4C0544
		public bool IsPlaying(string name); // 0x000000018D4C0320-0x000000018D4C0364
		[ExcludeFromDocs]
		public bool Play(); // 0x000000018670AC20-0x000000018670AC30
		public bool Play([UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018783C6BC-0x000000018783C6C8
		[NativeName("Play")]
		private bool PlayDefaultAnimation(UnityEngine.PlayMode mode); // 0x0000000186C612B0-0x0000000186C61300
		[ExcludeFromDocs]
		public bool Play(string animation); // 0x000000018783C6C8-0x000000018783C6D8
		public bool Play(string animation, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x00000001869930A0-0x0000000186993100
		[ExcludeFromDocs]
		public void CrossFade(string animation); // 0x000000018D4C02DC-0x000000018D4C02EC
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength); // 0x000000018D4C025C-0x000000018D4C0278
		public void CrossFade(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018D4C0278-0x000000018D4C02DC
		[ExcludeFromDocs]
		public void Blend(string animation); // 0x000000018D4C017C-0x000000018D4C018C
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight); // 0x000000018D4C018C-0x000000018D4C01AC
		public void Blend(string animation, [UnityEngine.Internal.DefaultValue("1.0F")] float targetWeight, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength); // 0x000000018645B660-0x000000018645B6D0
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation); // 0x000000018D4C01E4-0x000000018D4C01F8
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength); // 0x000000018D4C01AC-0x000000018D4C01C8
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue); // 0x000000018D4C01C8-0x000000018D4C01E4
		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018D4C01F8-0x000000018D4C025C
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation); // 0x000000018D4C0364-0x000000018D4C0374
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation, QueueMode queue); // 0x000000018D4C03D8-0x000000018D4C03F4
		[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState PlayQueued(string animation, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018D4C0374-0x000000018D4C03D8
		public void AddClip(AnimationClip clip, string newName); // 0x000000018D4C00F0-0x000000018D4C0118
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame); // 0x000000018D4C00CC-0x000000018D4C00F0
		public void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [UnityEngine.Internal.DefaultValue("false")] bool addLoopFrame); // 0x000000018D4C0118-0x000000018D4C017C
		public void RemoveClip([NotNull("NullExceptionObject")] AnimationClip clip); // 0x000000018D4C044C-0x000000018D4C0490
		public void RemoveClip(string clipName); // 0x000000018D4C0444-0x000000018D4C044C
		[NativeName("RemoveClip")]
		private void RemoveClipNamed(string clipName); // 0x000000018D4C0400-0x000000018D4C0444
		public int GetClipCount(); // 0x000000018D4C02EC-0x000000018D4C0320
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode); // 0x000000018783C6BC-0x000000018783C6C8
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode); // 0x000000018D4C03F4-0x000000018D4C0400
		public void SyncLayer(int layer); // 0x000000018D4C0544-0x000000018D4C0584
		public IEnumerator GetEnumerator(); // 0x00000001850924A0-0x00000001850924E0
		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		internal UnityEngine.AnimationState GetState(string name); // 0x000000018693A540-0x000000018693A590
		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		internal UnityEngine.AnimationState GetStateAtIndex(int index); // 0x00000001862569E0-0x0000000186256A30
		[NativeName("GetAnimationStateCount")]
		internal int GetStateCount(); // 0x000000018615E190-0x000000018615E1D0
		public AnimationClip GetClip(string name); // 0x000000018693A510-0x000000018693A540
		private void get_localBounds_Injected(out Bounds ret); // 0x000000018D4C0654-0x000000018D4C0698
		private void set_localBounds_Injected(ref Bounds value); // 0x000000018D4C083C-0x000000018D4C0880
	}

	[NativeHeader("Modules/Animation/AnimationState.h")]
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference // TypeDefIndex: 87435
	{
		// Properties
		public bool enabled { get; set; } // 0x000000018D4BF9E8-0x000000018D4BFA1C 0x000000018D4BFB94-0x000000018D4BFBD8
		public float weight { get; set; } // 0x000000018D4BFB20-0x000000018D4BFB54 0x000000018D4BFD2C-0x000000018D4BFD70
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x0000000185090140-0x0000000185090180 0x000000018D4BFD70-0x000000018D4BFDB0
		public float time { get; set; } // 0x000000018D4BFAEC-0x000000018D4BFB20 0x000000018D4BFCE8-0x000000018D4BFD2C
		public float normalizedTime { get; set; } // 0x000000018D4BFA84-0x000000018D4BFAB8 0x000000018D4BFC60-0x000000018D4BFCA4
		public float speed { get; set; } // 0x000000018D4BFAB8-0x000000018D4BFAEC 0x000000018D4BFCA4-0x000000018D4BFCE8
		public float normalizedSpeed { get; set; } // 0x000000018D4BFA50-0x000000018D4BFA84 0x000000018D4BFC1C-0x000000018D4BFC60
		public float length { get; } // 0x0000000185090CA0-0x0000000185090CE0 
		public int layer { get; set; } // 0x000000018D4BFA1C-0x000000018D4BFA50 0x0000000185092450-0x00000001850924A0
		public AnimationClip clip { get; } // 0x0000000185091670-0x00000001850916B0 
		public string name { get; set; } // 0x0000000185092410-0x0000000185092450 0x000000018D4BFBD8-0x000000018D4BFC1C
		public AnimationBlendMode blendMode { get; set; } // 0x000000018D4BF9B4-0x000000018D4BF9E8 0x000000018D4BFB54-0x000000018D4BFB94
	
		// Constructors
		public AnimationState(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix); // 0x000000018D4BF910-0x000000018D4BF91C
		public void AddMixingTransform([NotNull("NullExceptionObject")] Transform mix, [UnityEngine.Internal.DefaultValue("true")] bool recursive); // 0x000000018D4BF91C-0x000000018D4BF970
		public void RemoveMixingTransform([NotNull("NullExceptionObject")] Transform mix); // 0x000000018D4BF970-0x000000018D4BF9B4
	}

	[RequiredByNativeCode]
	public struct FastAnimationEvent // TypeDefIndex: 87436
	{
		// Fields
		internal float m_Time; // 0x00
		internal float m_ClipWeight; // 0x04
		internal string m_FunctionName; // 0x08
		internal string m_StringParameter; // 0x10
		internal UnityEngine.Object m_ObjectReferenceParameter; // 0x18
		internal float m_FloatParameter; // 0x20
		internal int m_IntParameter; // 0x24
		internal SendMessageOptions m_MessageOptions; // 0x28
		internal int m_StringParameterHashCode; // 0x2C
		internal int m_FunctionNameHashCode; // 0x30
		internal bool m_IsInTransition; // 0x34
		internal bool m_IsFromMaxWeightClipState; // 0x35
		internal bool m_IsFromNextMaxWeightClipState; // 0x36
	
		// Properties
		public string stringParameter { get; set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public float floatParameter { get; set; } // 0x000000018725FF20-0x000000018725FF30 0x00000001872332D0-0x00000001872332E0
		public int intParameter { get; set; } // 0x000000018725FF50-0x000000018725FF60 0x0000000182A819D0-0x0000000182A819E0
		public string functionName { get; } // 0x000000018725FF40-0x000000018725FF50 
		public float time { get; set; } // 0x000000018725FF90-0x000000018725FFA0 0x0000000187241700-0x0000000187241710
		public SendMessageOptions messageOptions { set; } // 0x0000000182271A90-0x0000000182271AA0
		public float clipWeight { get; set; } // 0x000000018725FCF0-0x000000018725FD00 0x00000001872598B0-0x00000001872598C0
		public bool isInTransition { get; set; } // 0x000000018725FF80-0x000000018725FF90 0x000000018226EBC0-0x000000018226EBD0
		public bool isFromMaxWeightClipState { get; set; } // 0x000000018725FF60-0x000000018725FF70 0x0000000182260CD0-0x0000000182260CE0
		public bool isFromNextMaxWeightClipState { get; set; } // 0x000000018725FF70-0x000000018725FF80 0x0000000182271A50-0x0000000182271A60
		public int functionNameHashCode { get; set; } // 0x000000018725FF30-0x000000018725FF40 0x0000000186033510-0x0000000186033520
	}

	[RequiredByNativeCode]
	public struct FastAnimationEventGroup // TypeDefIndex: 87437
	{
		// Fields
		public int count; // 0x00
		public IntPtr times; // 0x08
		public IntPtr clipWeights; // 0x10
		public IntPtr functionNames; // 0x18
		public IntPtr stringParameters; // 0x20
		public IntPtr functionNamesHashCode; // 0x28
		public IntPtr stringParametersHashCode; // 0x30
		public IntPtr floatParameters; // 0x38
		public IntPtr intParameters; // 0x40
		public IntPtr messageOptions; // 0x48
		public IntPtr inTransitions; // 0x50
		public IntPtr isFromMaxWeightClipStatus; // 0x58
		public IntPtr isFromNextMaxWeightClipStatus; // 0x60
	}

	[Serializable]
	[RequiredByNativeCode]
	public sealed class AnimationEvent // TypeDefIndex: 87438
	{
		// Fields
		internal float m_Time; // 0x10
		internal string m_FunctionName; // 0x18
		internal string m_StringParameter; // 0x20
		internal UnityEngine.Object m_ObjectReferenceParameter; // 0x28
		internal float m_FloatParameter; // 0x30
		internal int m_IntParameter; // 0x34
		internal int m_MessageOptions; // 0x38
		internal AnimationEventSource m_Source; // 0x3C
		internal UnityEngine.AnimationState m_StateSender; // 0x40
		internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
		internal AnimatorClipInfo m_AnimatorClipInfo; // 0x7C
		internal int m_FunctionNameHashCode; // 0x84
		internal int m_StringParameterHashCode; // 0x88
		internal AnimEventHashCodeType m_HashCodeType; // 0x8C
	
		// Properties
		public string stringParameter { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x0000000187835950-0x0000000187835960
		public float floatParameter { get; set; } // 0x000000018725EFA0-0x000000018725EFB0 0x0000000187233880-0x0000000187233890
		public int intParameter { get; set; } // 0x000000018725FEB0-0x000000018725FEC0 0x0000000182271AA0-0x0000000182271AB0
		public UnityEngine.Object objectReferenceParameter { set; } // 0x0000000185CA30F0-0x0000000185CA3100
		public string functionName { get; set; } // 0x0000000187244530-0x0000000187244540 0x0000000187835500-0x0000000187835510
		public float time { get; set; } // 0x000000018725FCD0-0x000000018725FCE0 0x0000000187235230-0x0000000187235240
		public SendMessageOptions messageOptions { get; set; } // 0x000000018725FEC0-0x000000018725FED0 0x0000000185E3C070-0x0000000185E3C080
		public bool isFiredByAnimator { get; } // 0x000000018D4BD3A0-0x000000018D4BD3A8 
		public AnimatorClipInfo animatorClipInfo { get; } // 0x000000018D4BD344-0x000000018D4BD3A0 
	
		// Constructors
		public AnimationEvent(); // 0x000000018D4BD2A0-0x000000018D4BD344
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion // TypeDefIndex: 87439
	{
		// Properties
		[NativeProperty("Length", false, UnityEngine.Bindings.TargetType.Function)]
		public float length { get; } // 0x000000018570BCA0-0x000000018570BCE0 
		[NativeProperty("StartTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float startTime { get; } // 0x000000018D4BD020-0x000000018D4BD054 
		[NativeProperty("StopTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float stopTime { get; } // 0x000000018D4BD054-0x000000018D4BD088 
		[NativeProperty("SampleRate", false, UnityEngine.Bindings.TargetType.Function)]
		public float frameRate { get; set; } // 0x000000018D4BCE0C-0x000000018D4BCE40 0x000000018D4BD13C-0x000000018D4BD180
		public ushort clipTag { [NativeMethod("GetClipTag")] get; [NativeMethod("SetClipTag")] set; } // 0x000000018D4BCD94-0x000000018D4BCDC8 0x000000018D4BD0F0-0x000000018D4BD134
		[NativeProperty("WrapMode", false, UnityEngine.Bindings.TargetType.Function)]
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x0000000185091770-0x00000001850917B0 0x000000018D4BD260-0x000000018D4BD2A0
		[NativeProperty("Bounds", false, UnityEngine.Bindings.TargetType.Function)]
		public Bounds localBounds { get; set; } // 0x000000018D4BCFF0-0x000000018D4BD020 0x000000018D4BD208-0x000000018D4BD21C
		public bool legacy { [NativeMethod("IsLegacy")] get; [NativeMethod("SetLegacy")] set; } // 0x000000018D4BCF78-0x000000018D4BCFAC 0x000000018D4BD180-0x000000018D4BD1C4
		public bool humanMotion { [NativeMethod("IsHumanMotion")] get; } // 0x000000018D4BCF44-0x000000018D4BCF78 
		public bool empty { [NativeMethod("IsEmpty")] get; } // 0x000000018716D8B0-0x000000018716D8F0 
		public bool hasGenericRootTransform { [NativeMethod("HasGenericRootTransform")] get; } // 0x000000018D4BCE40-0x000000018D4BCE74 
		public bool hasMotionFloatCurves { [NativeMethod("HasMotionFloatCurves")] get; } // 0x000000018D4BCEA8-0x000000018D4BCEDC 
		public bool hasMotionCurves { [NativeMethod("HasMotionCurves")] get; } // 0x000000018D4BCE74-0x000000018D4BCEA8 
		public bool hasRootCurves { [NativeMethod("HasRootCurves")] get; } // 0x000000018D4BCEDC-0x000000018D4BCF10 
		internal bool hasRootMotion { [FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)] get; } // 0x000000018D4BCF10-0x000000018D4BCF44 
		public bool transferRotationCompressed { [NativeMethod("GetTransferCompressed")] get; [NativeMethod("SetTransferCompressed")] set; } // 0x000000018D4BD088-0x000000018D4BD0BC 0x000000018D4BD21C-0x000000018D4BD260
		public ulong uniqueId { [NativeMethod("GetClipUniqueID")] get; } // 0x000000018D4BD0BC-0x000000018D4BD0F0 
		public AnimationEvent[] events { get; set; } // 0x000000018D4BCDC8-0x000000018D4BCE0C 0x000000018D4BD134-0x000000018D4BD13C
	
		// Constructors
		public AnimationClip(); // 0x0000000185FE2A50-0x0000000185FE2A80
	
		// Methods
		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self); // 0x0000000185FE2A80-0x0000000185FE2AC0
		public void SampleAnimation(GameObject go, float time); // 0x00000001850916D0-0x0000000185091770
		public void SampleAnimationFast(GameObject go, float time); // 0x00000001857159B0-0x0000000185715A00
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimation([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode); // 0x00000001850917B0-0x0000000185091820
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimationFast([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode); // 0x0000000185715940-0x00000001857159B0
		[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
		public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve); // 0x000000018D4BCCEC-0x000000018D4BCD50
		public bool GetAnimatorFloatCurve(string propertyName, AnimationCurve curve); // 0x000000018D4BCC68-0x000000018D4BCC84
		[FreeFunction("AnimationClipBindings::Internal_GetAnimatorFloatCurve", HasExplicitThis = true)]
		public bool GetAnimatorFloatCurve(string propertyName, AnimationCurve curve, [UnityEngine.Internal.DefaultValue("false")] bool useAclVirtualCurve = false /* Metadata: 0x02646395 */); // 0x000000018D4BCC04-0x000000018D4BCC68
		public void EnsureQuaternionContinuity(); // 0x000000018D4BCBD0-0x000000018D4BCC04
		public void ClearCurves(); // 0x000000018D4BCB9C-0x000000018D4BCBD0
		[FreeFunction("AnimationClipBindings::Internal_GetAnimationRuntimeMemorySize", HasExplicitThis = true)]
		public uint GetRuntimeMemorySize(); // 0x000000018D4BCCB8-0x000000018D4BCCEC
		public void AddEvent(AnimationEvent evt); // 0x000000018D4BCB30-0x000000018D4BCB9C
		[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = true)]
		private void AddEventInternal(object evt); // 0x000000018D4BCAEC-0x000000018D4BCB30
		[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = true, ThrowsException = true)]
		private void SetEventsInternal(Array value); // 0x000000018D4BCD50-0x000000018D4BCD94
		[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = true)]
		private Array GetEventsInternal(); // 0x000000018D4BCC84-0x000000018D4BCCB8
		private void get_localBounds_Injected(out Bounds ret); // 0x000000018D4BCFAC-0x000000018D4BCFF0
		private void set_localBounds_Injected(ref Bounds value); // 0x000000018D4BD1C4-0x000000018D4BD208
	}

	public enum AvatarTarget // TypeDefIndex: 87440
	{
		Root = 0,
		Body = 1,
		LeftFoot = 2,
		RightFoot = 3,
		LeftHand = 4,
		RightHand = 5
	}

	public enum AvatarIKGoal // TypeDefIndex: 87441
	{
		LeftFoot = 0,
		RightFoot = 1,
		LeftHand = 2,
		RightHand = 3
	}

	public enum AvatarIKHint // TypeDefIndex: 87442
	{
		LeftKnee = 0,
		RightKnee = 1,
		LeftElbow = 2,
		RightElbow = 3
	}

	public enum AnimatorControllerParameterType // TypeDefIndex: 87443
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	internal enum StateInfoIndex // TypeDefIndex: 87444
	{
		CurrentState = 0,
		NextState = 1,
		ExitState = 2,
		InterruptedState = 3
	}

	public enum AnimationBlendStyle // TypeDefIndex: 87445
	{
		Linear = 0,
		CubicIn = 1,
		HermiteCubic = 2,
		Sinusoidal = 3,
		CubicInOut = 4
	}

	public enum AnimatorTransitionInterruptionSource // TypeDefIndex: 87446
	{
		None = 0,
		Current = 1,
		Next = 2,
		CurrentThenNext = 3,
		NextThenCurrent = 4
	}

	public enum AnimatorRecorderMode // TypeDefIndex: 87447
	{
		Offline = 0,
		Playback = 1,
		Record = 2
	}

	public enum AnimatorUroMode // TypeDefIndex: 87448
	{
		Origin = 0,
		Predict = 1,
		PredictWithTick = 2,
		PredictWithTickAndRootMotion = 3
	}

	public enum AnimatorCullingMode // TypeDefIndex: 87449
	{
		AlwaysAnimate = 0,
		CullUpdateTransforms = 1,
		CullCompletely = 2
	}

	public enum AnimatorUpdateMode // TypeDefIndex: 87450
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum AnimatorJobDispatchMode // TypeDefIndex: 87451
	{
		Default = 0,
		ForceMainThread = 1,
		PreUpdate = 2,
		CrossFrame = 3,
		CrossFrameLateUpdate = 4
	}

	[UsedByNativeCode]
	public struct AnimatorLOD // TypeDefIndex: 87452
	{
		// Fields
		public float worldAbsoluteDistance; // 0x00
		public float maxDeltaTime; // 0x04
		public int framesPerUpdate; // 0x08
		public float maxBlendDeltaTime; // 0x0C
		public int framesPerWrite; // 0x10
		public int delayFrame; // 0x14
		public AnimatorUroMode uroMode; // 0x18
	
		// Constructors
		public AnimatorLOD(float worldAbsoluteDistance, int framesPerUpdate, float maxDeltaTime, int framesPerWrite = 0 /* Metadata: 0x026463C8 */, float maxBlendDeltaTime = 0f /* Metadata: 0x026463C9 */, AnimatorUroMode uroMode = AnimatorUroMode.Origin /* Metadata: 0x026463CD */, int delayFrame = 0 /* Metadata: 0x026463CE */); // 0x000000018725FEE0-0x000000018725FF10
	}

	[NativeHeader("Modules/Animation/HGAnimExtra/HGTransformRWBuffer.h")]
	public struct AnimationTransformRWBufferHandle // TypeDefIndex: 87453
	{
		// Fields
		public ushort count; // 0x00
		public ushort invalidCount; // 0x02
		public IntPtr validTransformIndexsPtr; // 0x08
		public IntPtr invalidTransformIndexsPtr; // 0x10
		public IntPtr localPositionsPtr; // 0x18
		public IntPtr localRotationsPtr; // 0x20
		public IntPtr localScalesPtr; // 0x28
		public IntPtr positionsPtr; // 0x30
		public IntPtr rotationsPtr; // 0x38
		public IntPtr scalesPtr; // 0x40
		public IntPtr physicsRatioPtr; // 0x48
		public IntPtr writeFlagPtr; // 0x50
		public IntPtr relativePostionPtr; // 0x58
		public IntPtr relativeRotationPtr; // 0x60
		public IntPtr relativeScalePtr; // 0x68
	}

	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	public struct HGAnimParameterSGHandle // TypeDefIndex: 87454
	{
		// Fields
		public int errorCode; // 0x00
		public ushort floatParameterCount; // 0x04
		public ushort boolParameterCount; // 0x06
		public ushort intParameterCount; // 0x08
		public ushort layerCount; // 0x0A
		public IntPtr floatParameterNamesPtr; // 0x10
		public IntPtr floatParameterValuesPtr; // 0x18
		public IntPtr boolParameterNamesPtr; // 0x20
		public IntPtr boolParameterValuesPtr; // 0x28
		public IntPtr intParameterNamesPtr; // 0x30
		public IntPtr intParameterValuesPtr; // 0x38
		public IntPtr layerWeightPtr; // 0x40
	}

	public enum AnimatorStageCallbackStage // TypeDefIndex: 87455
	{
		PreAnimation = 0,
		AfterHumanoid = 1,
		PostAnimation = 2
	}

	public struct AnimatorBoneHandle // TypeDefIndex: 87456
	{
		// Fields
		internal int m_BoneIndex; // 0x00
		internal int m_BoneNameHash; // 0x04
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AnimatorStageCallback(ref AnimatorStageStream stream); // TypeDefIndex: 87457; 0x0000000185B78EA0-0x0000000185B78EB0

	[NativeHeader("Modules/Animation/HGAnimExtra/HGAnimatorStageCallback.h")]
	public struct AnimatorStageStream // TypeDefIndex: 87458
	{
		// Fields
		internal IntPtr m_LocalPose; // 0x00
		internal IntPtr m_DefaultPose; // 0x08
		internal IntPtr m_GlobalPose; // 0x10
		internal IntPtr m_GlobalPoseValidFlags; // 0x18
		internal IntPtr m_ParentNodes; // 0x20
		internal IntPtr m_BoneNameHashes; // 0x28
		internal IntPtr m_WriteFlags; // 0x30
		internal IntPtr m_DirtyIndices; // 0x38
		internal IntPtr m_UserData; // 0x40
		internal int m_DirtyCount; // 0x48
		internal int m_DirtyCapacity; // 0x4C
		internal int m_BoneCount; // 0x50
		internal int m_Stage; // 0x54
		internal float m_DeltaTime; // 0x58
		internal int m_InstanceID; // 0x5C
		internal int m_LODLevel; // 0x60
		internal int m_CallbackId; // 0x64
		internal int m_CallbackSortOrder; // 0x68
		internal IntPtr m_FloatParameterNames; // 0x70
		internal IntPtr m_FloatParameterValues; // 0x78
		internal int m_FloatParameterCount; // 0x80
	}

	public enum AnimFrameSyncMode // TypeDefIndex: 87459
	{
		FrameSyncInRootPlayable = 0,
		FrameSyncInBaseLayerState = 1
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UsedByNativeCode]
	public struct AnimatorClipInfo // TypeDefIndex: 87460
	{
		// Fields
		private int m_ClipInstanceID; // 0x00
		private float m_Weight; // 0x04
	
		// Properties
		public AnimationClip clip { get; } // 0x000000018D4C0908-0x000000018D4C0924 
		public float weight { get; } // 0x000000018725FCF0-0x000000018725FD00 
	
		// Methods
		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID); // 0x000000018D4C08D4-0x000000018D4C0908
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateInfo // TypeDefIndex: 87461
	{
		// Fields
		private int m_Name; // 0x00
		private int m_Path; // 0x04
		private int m_FullPath; // 0x08
		private float m_NormalizedTime; // 0x0C
		private float m_Length; // 0x10
		private float m_Speed; // 0x14
		private float m_SpeedMultiplier; // 0x18
		private int m_Tag; // 0x1C
		private int m_Loop; // 0x20
		private int m_SyncGroup; // 0x24
		private int m_SyncGroupRole; // 0x28
		private int m_CullingMode; // 0x2C
		private int m_SourceMsg; // 0x30
	
		// Properties
		public int fullPathHash { get; } // 0x000000018453A050-0x000000018453A060 
		public int shortNameHash { get; } // 0x000000018725FD00-0x000000018725FD10 
		public float normalizedTime { get; } // 0x000000018725FF10-0x000000018725FF20 
		public float length { get; } // 0x000000018725FCD0-0x000000018725FCE0 
		public int tagHash { get; } // 0x0000000187249850-0x0000000187249860 
	
		// Methods
		public bool IsName(string name); // 0x0000000186729790-0x00000001867297F0
		public bool IsTag(string tag); // 0x00000001867C6720-0x00000001867C6770
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateRootMotionInfo // TypeDefIndex: 87462
	{
		// Fields
		private int m_NameHashLeft; // 0x00
		private Vector3 m_DeltaPositionLeft; // 0x04
		private Quaternion m_DeltaRotationLeft; // 0x10
		private int m_NameHashRight; // 0x20
		private Vector3 m_DeltaPositionRight; // 0x24
		private Quaternion m_DeltaRotationRight; // 0x30
		private float m_TransitionWeight; // 0x40
		private float m_DeltaTime; // 0x44
		private float m_InterruptedTransitionWeight; // 0x48
		private int m_NameHashinterrupted; // 0x4C
		private Vector3 m_DeltaPositioninterrupted; // 0x50
		private Quaternion m_DeltaRotationinterrupted; // 0x5C
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorTransitionInfo // TypeDefIndex: 87463
	{
		// Fields
		[NativeName("fullPathHash")]
		private int m_FullPath; // 0x00
		[NativeName("userNameHash")]
		private int m_UserName; // 0x04
		[NativeName("nameHash")]
		private int m_Name; // 0x08
		[NativeName("hasFixedDuration")]
		private bool m_HasFixedDuration; // 0x0C
		[NativeName("duration")]
		private float m_Duration; // 0x10
		[NativeName("normalizedTime")]
		private float m_NormalizedTime; // 0x14
		[NativeName("anyState")]
		private bool m_AnyState; // 0x18
		[NativeName("transitionType")]
		private int m_TransitionType; // 0x1C
	
		// Properties
		public int nameHash { get; } // 0x000000018453A050-0x000000018453A060 
		public float normalizedTime { get; } // 0x0000000184F6DB00-0x0000000184F6DB10 
	
		// Methods
		public bool IsUserName(string name); // 0x000000018D4C1DAC-0x000000018D4C1E00
	}

	[NativeHeader("Modules/Animation/Animator.h")]
	public struct MatchTargetWeightMask // TypeDefIndex: 87464
	{
		// Fields
		private Vector3 m_PositionXYZWeight; // 0x00
		private float m_RotationWeight; // 0x0C
	
		// Constructors
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight); // 0x0000000187238F10-0x0000000187238F30
	}

	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[UsedByNativeCode]
	public class Animator : UnityEngine.Behaviour // TypeDefIndex: 87471
	{
		// Fields
		internal AnimationEventCallback onAnimationEvent; // 0x18
		internal AnimationEventCallbackOpt onAnimationEventOpt; // 0x20
		internal AnimatorStateChangeCallback onAnimatorStateEnter; // 0x28
		internal AnimatorStateChangeCallback onAnimatorStateExit; // 0x30
		internal AnimatorStateChangeCallback onAnimatorStatePreExit; // 0x38
		internal AniamtorCommonCallback afterAnimatorUpdateGraphCB; // 0x40
		private static readonly int[] s_EmptyStageCallbackGlobalPoseBones; // 0x00
		private static readonly Dictionary<StageCallbackManagedHandleKey, GCHandle> s_StageCallbackManagedHandles; // 0x08
		private const int kStageCallbackMutationNotFound = 0; // Metadata: 0x026463E4
		private const int kStageCallbackMutationSucceeded = 1; // Metadata: 0x026463E5
		private const int kStageCallbackMutationPendingRemove = 2; // Metadata: 0x026463E6
		private const int kStageCallbackMutationBlocked = 3; // Metadata: 0x026463E7
	
		// Properties
		public bool fastAnimationEventsOpt { [NativeMethod("GetEnableFireAnimationEventsOpt")] get; [NativeMethod("SetEnableFireAnimationEventsOpt")] set; } // 0x000000018D4C75E8-0x000000018D4C761C 0x0000000185DA8A80-0x0000000185DA8AD0
		public bool callBackAfterUpdateGraph { [NativeMethod("GetNeedInvokeCBAfterUpdateGraph")] get; [NativeMethod("SetNeedInvokeCBAfterUpdateGraph")] set; } // 0x000000018D4C754C-0x000000018D4C7580 0x000000018D4C8170-0x000000018D4C81B4
		public bool fastAnimationEvents { [NativeMethod("GetFastAnimationEvents")] get; [NativeMethod("SetFastAnimationEvents")] set; } // 0x000000018D4C761C-0x000000018D4C7650 0x0000000185DA8AD0-0x0000000185DA8B20
		public bool notifyAnimatorStateEnterAndExitEvent { [NativeMethod("GetNotifyAnimatorStateEnterAndExitEvent")] get; [NativeMethod("SetNotifyAnimatorStateEnterAndExitEvent")] set; } // 0x000000018D4C7A38-0x000000018D4C7A6C 0x0000000185EA5E80-0x0000000185EA5ED0
		public bool keepStateOnChangeActive { [NativeMethod("GetKeepAnimatorStateOnChangeActive")] get; [NativeMethod("SetKeepAnimatorStateOnChangeActive")] set; } // 0x000000018D4C7864-0x000000018D4C7898 0x000000018D4C8288-0x000000018D4C82CC
		public bool preserveControllerMemoryOnPlayableOutputPreBind { [NativeMethod("GetPreserveControllerMemoryOnPlayableOutputPreBind")] get; [NativeMethod("SetPreserveControllerMemoryOnPlayableOutputPreBind")] set; } // 0x000000018D4C7BB0-0x000000018D4C7BE4 0x000000018D4C84E8-0x000000018D4C852C
		public bool pausePlayableOnChangeActive { [NativeMethod("GetPauseAnimatorStateOnChangeActive")] get; [NativeMethod("SetPauseAnimatorStateOnChangeActive")] set; } // 0x000000018D4C7A6C-0x000000018D4C7AA0 0x000000018D4C8460-0x000000018D4C84A4
		public bool resetControllerPlayableOnChangeActive { [NativeMethod("GetResetAnimatorControllerStateOnChangeActive")] get; [NativeMethod("SetResetAnimatorControllerStateOnChangeActive")] set; } // 0x000000018D4C7C30-0x000000018D4C7C64 0x000000018D4C852C-0x000000018D4C8570
		public bool isOptimizable { [NativeMethod("IsOptimizable")] get; } // 0x000000018D4C77BC-0x000000018D4C77F0 
		public bool isHuman { [NativeMethod("IsHuman")] get; } // 0x000000018D4C7720-0x000000018D4C7754 
		public bool hasRootMotion { [NativeMethod("HasRootMotion")] get; } // 0x000000018D4C76B8-0x000000018D4C76EC 
		internal bool isRootPositionOrRotationControlledByCurves { [NativeMethod("IsRootTranslationOrRotationControllerByCurves")] get; } // 0x000000018D4C77F0-0x000000018D4C7824 
		public float humanScale { get; } // 0x000000018D4C76EC-0x000000018D4C7720 
		public bool isInitialized { [NativeMethod("IsInitialized")] get; } // 0x000000018D4C7754-0x000000018D4C7788 
		public bool isVisible { [NativeMethod("IsVisible")] get; } // 0x000000018633D4C0-0x000000018633D500 
		public bool updatedLastFrame { [NativeMethod("GetShouldTick")] get; } // 0x000000018546C020-0x000000018546C060 
		public bool enableLOD { [NativeMethod("GetEnableLOD")] get; [NativeMethod("SetEnableLOD")] set; } // 0x000000018D4C7580-0x000000018D4C75B4 0x00000001859CE250-0x00000001859CE2A0
		public int LODLevel { [NativeMethod("GetCurrentLODLevel")] get; } // 0x00000001854D76D0-0x00000001854D7710 
		public float motionDeltaTime { get; } // 0x000000018D4C7A04-0x000000018D4C7A38 
		public Vector3 deltaPosition { get; } // 0x000000018570DCD0-0x000000018570DD30 
		public Quaternion deltaRotation { get; } // 0x000000018570DC20-0x000000018570DC80 
		public Vector3 velocity { get; } // 0x000000018570DAC0-0x000000018570DB20 
		public Vector3 angularVelocity { get; } // 0x000000018570DB70-0x000000018570DBD0 
		public Vector3 rootPosition { [NativeMethod("GetAvatarPosition")] get; [NativeMethod("SetAvatarPosition")] set; } // 0x000000018D4C7CDC-0x000000018D4C7D08 0x000000018D4C85B4-0x000000018D4C85C8
		public Quaternion rootRotation { [NativeMethod("GetAvatarRotation")] get; [NativeMethod("SetAvatarRotation")] set; } // 0x000000018D4C7D4C-0x000000018D4C7D78 0x000000018D4C860C-0x000000018D4C8620
		public bool applyRootMotion { get; set; } // 0x000000018D4C7370-0x000000018D4C73A4 0x000000018D4C7FFC-0x000000018D4C8040
		[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
		public bool linearVelocityBlending { get; set; } // 0x000000018D4C7900-0x000000018D4C7934 0x000000018D4C8310-0x000000018D4C8354
		[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
		public bool animatePhysics { get; set; } // 0x000000018D4C7324-0x000000018D4C733C 0x000000018D4C7F98-0x000000018D4C7FB8
		public AnimatorUpdateMode updateMode { get; set; } // 0x00000001859E69B0-0x00000001859E69F0 0x000000018D4C8664-0x000000018D4C86A4
		public bool hasTransformHierarchy { get; } // 0x0000000185A151C0-0x0000000185A15200 
		internal bool allowConstantClipSamplingOptimization { get; set; } // 0x000000018D4C72F0-0x000000018D4C7324 0x000000018D4C7F54-0x000000018D4C7F98
		public float gravityWeight { get; } // 0x000000018570DD80-0x000000018570DDC0 
		public Vector3 bodyPosition { get; set; } // 0x000000018D4C7448-0x000000018D4C7498 0x000000018D4C8098-0x000000018D4C80DC
		internal Vector3 bodyPositionInternal { [NativeMethod("GetBodyPosition")] get; [NativeMethod("SetBodyPosition")] set; } // 0x000000018D4C741C-0x000000018D4C7448 0x000000018D4C8084-0x000000018D4C8098
		public Quaternion bodyRotation { get; set; } // 0x000000018D4C7508-0x000000018D4C754C 0x000000018D4C8134-0x000000018D4C8170
		internal Quaternion bodyRotationInternal { [NativeMethod("GetBodyRotation")] get; [NativeMethod("SetBodyRotation")] set; } // 0x000000018D4C74DC-0x000000018D4C7508 0x000000018D4C8120-0x000000018D4C8134
		public bool stabilizeFeet { get; set; } // 0x000000018D4C7DD8-0x000000018D4C7E0C 0x000000018D4C8620-0x000000018D4C8664
		public int layerCount { get; } // 0x0000000185F7EC40-0x0000000185F7EC80 
		public AnimatorControllerParameter[] parameters { [FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)] get; } // 0x0000000186AF7820-0x0000000186AF7860 
		public int parameterCount { get; } // 0x000000018597CB10-0x000000018597CB50 
		public float feetPivotActive { get; set; } // 0x000000018D4C7650-0x000000018D4C7684 0x000000018D4C81F8-0x000000018D4C823C
		public float pivotWeight { get; } // 0x000000018D4C7B10-0x000000018D4C7B44 
		public Vector3 pivotPosition { get; } // 0x000000018D4C7AE4-0x000000018D4C7B10 
		public bool isMatchingTarget { [NativeMethod("IsMatchingTarget")] get; } // 0x000000018D4C7788-0x000000018D4C77BC 
		public float timeScale { [NativeMethod("GetTimeScale")] get; [NativeMethod("SetTimeScale")] set; } // 0x0000000185DADBB0-0x0000000185DADBF0 0x0000000185DAE4C0-0x0000000185DAE510
		public float speed { get; set; } // 0x000000018D4C7DA4-0x000000018D4C7DD8 0x0000000185DAE910-0x0000000185DAE960
		public Vector3 targetPosition { get; } // 0x000000018D4C7E84-0x000000018D4C7EB0 
		public Quaternion targetRotation { get; } // 0x000000018D4C7EF4-0x000000018D4C7F20 
		internal Transform avatarRoot { get; } // 0x000000018D4C73A4-0x000000018D4C73D8 
		public AnimatorCullingMode cullingMode { get; set; } // 0x00000001854D7CB0-0x00000001854D7CF0 0x0000000185715A90-0x0000000185715AE0
		public float playbackTime { get; set; } // 0x000000018D4C7B7C-0x000000018D4C7BB0 0x000000018D4C84A4-0x000000018D4C84E8
		public float recorderStartTime { get; set; } // 0x000000018D4C7C18-0x000000018D4C7C24 0x0000000186805BA0-0x0000000186805BB0
		public float recorderStopTime { get; set; } // 0x000000018D4C7C24-0x000000018D4C7C30 0x0000000186805BA0-0x0000000186805BB0
		public AnimatorRecorderMode recorderMode { get; } // 0x000000018D4C7BE4-0x000000018D4C7C18 
		public RuntimeAnimatorController runtimeAnimatorController { get; set; } // 0x000000018597E0E0-0x000000018597E120 0x0000000186828230-0x00000001868282B0
		public bool hasBoundPlayables { [NativeMethod("HasBoundPlayables")] get; } // 0x000000018503DD10-0x000000018503DD50 
		public static bool skipRebindWhenNoControllerAndNoBoundPlayable { [NativeMethod("GetSkipRebindWhenNoControllerAndNoBoundPlayable")] get; [NativeMethod("SetSkipRebindWhenNoControllerAndNoBoundPlayable")] set; } // 0x000000018D4C7D78-0x000000018D4C7DA4 0x0000000186B1A350-0x0000000186B1A390
		public Avatar avatar { get; set; } // 0x000000018528A310-0x000000018528A350 0x0000000185F0A1E0-0x0000000185F0A230
		public HGSkeletalMorphAvatar morphAvatar { get; set; } // 0x000000018D4C79D0-0x000000018D4C7A04 0x000000018D4C841C-0x000000018D4C8460
		public LodBoneMask lodBoneMask { get; set; } // 0x000000018D4C7968-0x000000018D4C799C 0x000000018D4C8394-0x000000018D4C83D8
		public uint lodBoneMaskLevel { get; set; } // 0x000000018D4C7934-0x000000018D4C7968 0x000000018D4C8354-0x000000018D4C8394
		public PlayableGraph playableGraph { get; } // 0x000000018D4C7B44-0x000000018D4C7B7C 
		public bool applyMorphPose { get; set; } // 0x000000018D4C733C-0x000000018D4C7370 0x000000018D4C7FB8-0x000000018D4C7FFC
		public bool layersAffectMassCenter { get; set; } // 0x000000018D4C7898-0x000000018D4C78CC 0x000000018D4C82CC-0x000000018D4C8310
		public float leftFeetBottomHeight { get; } // 0x000000018D4C78CC-0x000000018D4C7900 
		public float rightFeetBottomHeight { get; } // 0x000000018D4C7C64-0x000000018D4C7C98 
		[NativeConditional("UNITY_EDITOR")]
		internal bool supportsOnAnimatorMove { [NativeMethod("SupportsOnAnimatorMove")] get; } // 0x000000018D4C7E0C-0x000000018D4C7E40 
		public bool logWarnings { get; set; } // 0x000000018D4C799C-0x000000018D4C79D0 0x000000018D4C83D8-0x000000018D4C841C
		public bool enableParameterWarnings { get; set; } // 0x000000018D4C75B4-0x000000018D4C75E8 0x000000018D4C81B4-0x000000018D4C81F8
		public bool fireEvents { get; set; } // 0x000000018D4C7684-0x000000018D4C76B8 0x000000018D4C823C-0x000000018D4C8280
		[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", false)]
		public bool keepAnimatorControllerStateOnDisable { get; set; } // 0x000000018D4C7824-0x000000018D4C7830 0x000000018D4C8280-0x000000018D4C8288
		public bool keepAnimatorStateOnDisable { get; set; } // 0x000000018D4C7830-0x000000018D4C7864 0x0000000185F0A190-0x0000000185F0A1E0
		public bool writeDefaultValuesOnDisable { get; set; } // 0x000000018D4C7F20-0x000000018D4C7F54 0x0000000186C36A50-0x0000000186C36AA0
	
		// Nested types
		public delegate bool AnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // TypeDefIndex: 87465; 0x00000001826EA580-0x00000001826EA5D0
	
		public delegate void AnimatorStateChangeCallback(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex); // TypeDefIndex: 87466; 0x000000018D4C1D64-0x000000018D4C1DAC
	
		public delegate bool AnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent); // TypeDefIndex: 87467; 0x00000001848FFCC0-0x00000001848FFD30
	
		public delegate void AniamtorCommonCallback(Animator animator); // TypeDefIndex: 87468; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public enum RetargetBoneMode // TypeDefIndex: 87469
		{
			Translation = 0,
			Scale = 1
		}
	
		private struct StageCallbackManagedHandleKey : IEquatable<StageCallbackManagedHandleKey> // TypeDefIndex: 87470
		{
			// Fields
			public int animatorInstanceId; // 0x00
			public int stage; // 0x04
			public int callbackId; // 0x08
	
			// Methods
			public bool Equals(StageCallbackManagedHandleKey other); // 0x00000001887DD288-0x00000001887DD2A4
			public override bool Equals(object obj); // 0x000000018D4C9E64-0x000000018D4C9EE4
			public override int GetHashCode(); // 0x000000018725FFA0-0x000000018725FFC0
		}
	
		// Constructors
		public Animator(); // 0x000000018D4C72A4-0x000000018D4C72F0
		static Animator(); // 0x00000001870BE8A0-0x00000001870BE970
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallAnimatorStateChangeCallback(Animator anim, AnimatorStateInfo animatorStateInfo, int layerIndex, int methodIdx); // 0x0000000185DB0390-0x0000000185DB0510
		[RequiredByNativeCode]
		private static void Internal_CallAfterUpdateGraph(Animator anim); // 0x000000018D4C4638-0x000000018D4C46A8
		[RequiredByNativeCode]
		private static bool Internal_InvokeAnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // 0x0000000186329620-0x00000001863297E0
		[RequiredByNativeCode]
		private static void Internal_InvokeAnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent, out bool optFlag); // 0x0000000184F6DB10-0x0000000184F6DEE0
		public void SetCallbackAfterRootMotionStageCallback(AniamtorCommonCallback cb); // 0x00000001870EAAD0-0x00000001870EAAE0
		public void SetAnimationEventCallback(AnimationEventCallback onAnimationEvent); // 0x0000000187835500-0x0000000187835510
		public void SetAnimationEventCallbackOpt(AnimationEventCallbackOpt onAnimationEvent); // 0x0000000187835950-0x0000000187835960
		public void SetNotifyAnimatorStateEnterAndExitEventCallBack(AnimatorStateChangeCallback onAnimatorStateEnter, AnimatorStateChangeCallback onAnimatorStateExit); // 0x0000000185EA5E50-0x0000000185EA5E80
		public void SetNotifyAnimatorStatePreExitEventCallBack(AnimatorStateChangeCallback onAnimatorStatePreExit); // 0x0000000186AB5C00-0x0000000186AB5C10
		[NativeMethod("SetLODLevel")]
		public bool SetLODLevel(int level); // 0x0000000186324430-0x0000000186324540
		[NativeMethod("GetCurrentLODLevel")]
		public int GetCurrentLODLevel(); // 0x000000018D4C3BAC-0x000000018D4C3BE0
		[FreeFunction("AnimatorBindings::GetLODs_Binding", HasExplicitThis = true)]
		public AnimatorLOD[] GetLODs(); // 0x0000000186323D40-0x0000000186323D80
		[FreeFunction("AnimatorBindings::SetLODs_Binding", HasExplicitThis = true)]
		public void SetLODs([Unmarshalled] AnimatorLOD[] lods); // 0x0000000186324010-0x0000000186324060
		[NativeMethod("SetConstraintEnableImmediately")]
		public void SetConstraintEnableImmediately(int nameHash); // 0x000000018D4C5BE4-0x000000018D4C5C24
		[NativeMethod("SetConstraintDisableImmediately")]
		public void SetConstraintDisableImmediately(int nameHash); // 0x000000018D4C5B54-0x000000018D4C5B94
		[NativeMethod("SetConstraintEnableBlendIn")]
		public void SetConstraintEnableBlendIn(int nameHash, float duration); // 0x000000018D4C5B94-0x000000018D4C5BE4
		[NativeMethod("SetConstraintDisableBlendOut")]
		public void SetConstraintDisableBlendOut(int nameHash, float duration); // 0x000000018D4C5B04-0x000000018D4C5B54
		public void BecameVisible(); // 0x00000001870F3D20-0x00000001870F3D60
		[NativeMethod("SetAnimatorJobOptEnable")]
		public static void SetAnimatorJobOptEnable(bool enabel); // 0x0000000186B1A590-0x0000000186B1A5D0
		[NativeMethod("SetAnimatorJobOptFunc")]
		public static void SetAnimatorJobOptFunc(int value); // 0x0000000186B1A550-0x0000000186B1A590
		[NativeMethod("SetAnimatorWriteTransformOpt")]
		public static void SetAnimatorWriteTransformOpt(bool value); // 0x0000000186B1A510-0x0000000186B1A550
		[NativeMethod("SetGlobalAnimatorClipBindingsOpt")]
		public static void SetGlobalAnimatorClipBindingsOpt(bool value); // 0x0000000186B1A4D0-0x0000000186B1A510
		[NativeMethod("SetGlobalAnimatorClipBindingsConstantOpt")]
		public static void SetGlobalAnimatorClipBindingsConstantOpt(bool value); // 0x0000000186B1A490-0x0000000186B1A4D0
		[NativeMethod("SetGlobalAnimatorClipBindingsOptByAvatar")]
		public static void SetGlobalAnimatorClipBindingsOptByAvatar(bool value); // 0x0000000186B1A450-0x0000000186B1A490
		[NativeMethod("SetAnimatorUroMaxDeltaTimePerframe")]
		public static void SetAnimatorUroMaxDeltaTimePerframe(float value); // 0x000000018D4C58A4-0x000000018D4C58E0
		[NativeMethod("SetGlobalAnimatorCacheClipBindingsOpt")]
		public static void SetGlobalAnimatorCacheClipBindingsOpt(bool value); // 0x0000000186B1A410-0x0000000186B1A450
		[NativeMethod("GetAnimatorUroMaxDeltaTimePerframe")]
		public static float GetAnimatorUroMaxDeltaTimePerframe(); // 0x000000018D4C35C8-0x000000018D4C35F4
		[NativeMethod("SetAnimatorMainThreadJobCount")]
		public static void SetAnimatorMainThreadJobCount(int value); // 0x000000018D4C583C-0x000000018D4C5870
		[NativeMethod("SetAnimatorSplitLazyWriteJobsByDependency")]
		public static void SetAnimatorSplitLazyWriteJobsByDependency(bool value); // 0x000000018D4C5870-0x000000018D4C58A4
		[NativeMethod("SetPrepareFrameJobBatchCountOpt")]
		public static void SetPrepareFrameJobBatchCountOpt(int value); // 0x000000018D4C6A3C-0x000000018D4C6A70
		[NativeMethod("SetProcessAnimJobBatchCountOpt")]
		public static void SetProcessAnimJobBatchCountOpt(int value); // 0x000000018D4C6A70-0x000000018D4C6AA4
		[NativeMethod("SetAnimatorEnableProcessOneStage")]
		public static void SetAnimatorEnableProcessOneStage(bool value); // 0x0000000186B1A3D0-0x0000000186B1A410
		[NativeMethod("SetAnimatorEnableApplyOnMoveInJob")]
		public static void SetAnimatorEnableApplyOnMoveInJob(bool value); // 0x000000018D4C57A0-0x000000018D4C57D4
		[NativeMethod("SetAnimatorEnableRequireEventsAndBehaviour")]
		public static void SetAnimatorEnableRequireEventsAndBehaviour(bool value); // 0x000000018D4C5808-0x000000018D4C583C
		[NativeMethod("SetApplyBuildInRootMotionInJob")]
		public void SetApplyBuildInRootMotionInJob(bool enable); // 0x000000018D4C58E0-0x000000018D4C5924
		[NativeMethod("SetAnimatorForbbidenApplyOnMoveCb")]
		public static void SetAnimatorForbbidenApplyOnMoveCb(bool value); // 0x0000000186B1A390-0x0000000186B1A3D0
		[NativeMethod("SetAnimatorEnableCrossFrameJobs")]
		public static void SetAnimatorEnableCrossFrameJobs(bool enabel); // 0x000000018D4C57D4-0x000000018D4C5808
		[NativeMethod("SetAbilityLevel")]
		public void SetAbilityLevel(int abilityLevel); // 0x0000000186DD8A10-0x0000000186DD8A60
		[NativeMethod("GetAbilityLevel")]
		public int GetAbilityLevel(); // 0x00000001854D7690-0x00000001854D76D0
		[NativeMethod("SetSampleClipCacheCreatePreFrameCount")]
		public static void SetSampleClipCacheCreatePreFrameCount(int value); // 0x000000018D4C6D8C-0x000000018D4C6DC0
		[NativeMethod("SetSampleClipCacheMaxCount")]
		public static void SetSampleClipCacheMaxCount(int value); // 0x000000018D4C6DC0-0x000000018D4C6DF4
		[NativeMethod("SetLayerMeshSpace")]
		public void SetLayerMeshSpace(int layerIndex, bool enable); // 0x0000000185EA6770-0x0000000185EA67D0
		[NativeMethod("GetLayerMeshSpace")]
		public bool GetLayerMeshSpace(int layerIndex); // 0x000000018D4C4184-0x000000018D4C41C4
		[NativeMethod("SetLayerMaskBoneWeights")]
		private void Internal_SetLayerMaskBoneWeights(int layerIndex, IntPtr bonePathHashes, IntPtr weights, int count); // 0x0000000185771D10-0x0000000185771D80
		[NativeMethod("ClearLayerMaskBoneWeights")]
		public void ClearLayerMaskBoneWeights(int layerIndex); // 0x0000000185771410-0x0000000185771460
		public void SetLayerMaskBoneWeights(int layerIndex, int[] bonePathHashes, float[] weights); // 0x0000000185771D80-0x0000000185771E30
		public void SetLayerMaskBoneWeights(int layerIndex, NativeArray<int> bonePathHashes, NativeArray<float> weights); // 0x000000018D4C6474-0x000000018D4C654C
		[NativeMethod("SetRetargetScaleEnabled")]
		public void SetRetargetScaleEnabled(bool enabled); // 0x000000018549D460-0x000000018549D4B0
		[NativeMethod("GetRetargetScaleEnabled")]
		public bool GetRetargetScaleEnabled(); // 0x000000018D4C4448-0x000000018D4C447C
		public void SetRetargetScaleByAvatar(Avatar referenceAvatar, string[] boneNames); // 0x000000018D4C6AA4-0x000000018D4C6BD0
		[NativeMethod("SetRetargetScaleByAvatar")]
		private void Internal_SetRetargetScaleByAvatar(Avatar referenceAvatar, int[] boneNameHashes, int count); // 0x000000018D4C4758-0x000000018D4C47BC
		public void SetRetargetScale(string[] boneNames, Vector3 scaleFactor, RetargetBoneMode[] boneModes = null); // 0x000000018D4C6C14-0x000000018D4C6D8C
		[NativeMethod("SetRetargetScale")]
		private void Internal_SetRetargetScale(int[] boneNameHashes, int count, Vector3 scaleFactor, int[] boneModes); // 0x000000018D4C4820-0x000000018D4C4844
		public void SetRetargetScaleWeight(float weight); // 0x000000018D4C6BD0-0x000000018D4C6C14
		public float GetRetargetScaleWeight(); // 0x000000018D4C447C-0x000000018D4C44B0
		public AnimatorBoneHandle GetStageBoneHandle(string boneName); // 0x000000018D4C44E4-0x000000018D4C4540
		public AnimatorBoneHandle GetStageBoneHandle(int boneNameHash); // 0x000000018D4C4540-0x000000018D4C4564
		[NativeMethod("ResolveStageBoneHandle")]
		private int ResolveStageBoneHandle(int nameHash); // 0x000000018D4C55CC-0x000000018D4C560C
		private StageCallbackManagedHandleKey MakeStageCallbackManagedHandleKey(AnimatorStageCallbackStage stage, int callbackId); // 0x000000018D4C4A10-0x000000018D4C4A68
		private void RetainStageCallbackManagedHandle(AnimatorStageCallbackStage stage, int callbackId, GCHandle handle); // 0x000000018D4C560C-0x000000018D4C5754
		private void ReleaseStageCallbackManagedHandle(AnimatorStageCallbackStage stage, int callbackId); // 0x000000018D4C4EC0-0x000000018D4C4FF8
		private static bool ShouldReleaseStageCallbackManagedHandle(int mutationResult); // 0x000000018D4C70F8-0x000000018D4C710C
		private static bool DidStageCallbackMutationSucceed(int mutationResult); // 0x000000018D4C31F0-0x000000018D4C31F8
		private void ReleaseStageCallbackManagedHandles(AnimatorStageCallbackStage stage); // 0x000000018D4C53C4-0x000000018D4C5420
		private static void ReleaseStageCallbackManagedHandles(int animatorInstanceId, int stageValue); // 0x000000018D4C5048-0x000000018D4C53C4
		[RequiredByNativeCode]
		private static void ReleaseStageCallbackManagedHandlesForAnimator(int animatorInstanceId); // 0x000000018D4C4FF8-0x000000018D4C5048
		public int AddStageCallback(AnimatorStageCallbackStage stage, AnimatorStageCallback callback, IntPtr userData, int priority, bool needGlobalPose = false /* Metadata: 0x026463D4 */); // 0x000000018D4C1F84-0x000000018D4C1FC4
		public int AddStageCallback(AnimatorStageCallbackStage stage, AnimatorStageCallback callback, IntPtr userData, int sortOrder, bool needGlobalPose, string debugName, int maxActiveLODLevel = 2147483647 /* Metadata: 0x026463D5 */, int[] globalPoseBoneIndices = null); // 0x000000018D4C1E64-0x000000018D4C1F84
		internal int AddStageCallback(AnimatorStageCallbackStage stage, IntPtr callbackFnPtr, IntPtr userData, int priority, bool isBurstCompiled, bool needGlobalPose = false /* Metadata: 0x026463D6 */); // 0x000000018D4C20D4-0x000000018D4C2120
		internal int AddStageCallback(AnimatorStageCallbackStage stage, IntPtr callbackFnPtr, IntPtr userData, int sortOrder, bool isBurstCompiled, bool needGlobalPose, string debugName, int maxActiveLODLevel = 2147483647 /* Metadata: 0x026463D7 */, int[] globalPoseBoneIndices = null); // 0x000000018D4C1FC4-0x000000018D4C20D4
		public bool RemoveStageCallback(AnimatorStageCallbackStage stage, int callbackId); // 0x000000018D4C54E8-0x000000018D4C558C
		public bool ClearStageCallbacks(AnimatorStageCallbackStage stage); // 0x000000018D4C237C-0x000000018D4C2404
		public void SetStageCallbackEnabled(AnimatorStageCallbackStage stage, int callbackId, bool enabled); // 0x000000018D4C6E54-0x000000018D4C6E68
		public void SetStageCallbackMaxActiveLODLevel(AnimatorStageCallbackStage stage, int callbackId, int maxActiveLODLevel); // 0x000000018D4C6FD4-0x000000018D4C6FE8
		public void SetStageCallbackSortOrder(AnimatorStageCallbackStage stage, int callbackId, int sortOrder); // 0x000000018D4C7048-0x000000018D4C705C
		public void SetStageCallbackGlobalPoseBones(AnimatorStageCallbackStage stage, int callbackId, bool needGlobalPose, int[] globalPoseBoneIndices = null); // 0x000000018D4C6EC8-0x000000018D4C6F74
		[NativeMethod("AddStageCallbackInternal")]
		private uint AddStageCallbackInternal(int stage, ulong callbackFnPtr, ulong userData, int sortOrder, bool isBurstCompiled, bool needGlobalPose, string debugName, int maxActiveLODLevel, int[] globalPoseBoneIndices, int globalPoseBoneCount); // 0x000000018D4C1E00-0x000000018D4C1E64
		[NativeMethod("RemoveStageCallbackInternal")]
		private int RemoveStageCallbackInternal(int stage, uint callbackId); // 0x000000018D4C5498-0x000000018D4C54E8
		[NativeMethod("ClearStageCallbacksInternal")]
		private int ClearStageCallbacksInternal(int stage); // 0x000000018D4C233C-0x000000018D4C237C
		[NativeMethod("SetStageCallbackEnabledInternal")]
		private void SetStageCallbackEnabledInternal(int stage, uint callbackId, bool enabled); // 0x000000018D4C6DF4-0x000000018D4C6E54
		[NativeMethod("SetStageCallbackMaxActiveLODLevelInternal")]
		private void SetStageCallbackMaxActiveLODLevelInternal(int stage, uint callbackId, int maxActiveLODLevel); // 0x000000018D4C6F74-0x000000018D4C6FD4
		[NativeMethod("SetStageCallbackSortOrderInternal")]
		private void SetStageCallbackSortOrderInternal(int stage, uint callbackId, int sortOrder); // 0x000000018D4C6FE8-0x000000018D4C7048
		[NativeMethod("SetStageCallbackGlobalPoseBonesInternal")]
		private void SetStageCallbackGlobalPoseBonesInternal(int stage, uint callbackId, bool needGlobalPose, int[] globalPoseBoneIndices, int globalPoseBoneCount); // 0x000000018D4C6E68-0x000000018D4C6EC8
		[NativeMethod("SetControllerDefaultValues")]
		public void SetControllerDefaultValues(bool value); // 0x000000018D4C5C24-0x000000018D4C5C68
		public float GetFloat(string name); // 0x0000000187839DA0-0x0000000187839DAC
		public float GetFloat(int id); // 0x0000000187834B2C-0x0000000187834B38
		public float GetFloatFromTransition(int layerIndex, int id); // 0x000000018D4C3D0C-0x000000018D4C3D18
		public float GetFloatFromTransitionWithDefault(int layerIndex, int id, float defValue); // 0x000000018D4C3CFC-0x000000018D4C3D0C
		public void SetFloat(string name, float value); // 0x0000000187835B78-0x0000000187835B80
		public void SetFloat(string name, float value, float dampTime, float deltaTime); // 0x000000018D4C6044-0x000000018D4C6054
		public void SetFloat(int id, float value); // 0x0000000187837520-0x0000000187837528
		public void SetFloat(int id, float value, float dampTime, float deltaTime); // 0x000000018D4C6054-0x000000018D4C6064
		public bool GetBool(string name); // 0x000000018783CD00-0x000000018783CD0C
		public bool GetBool(int id); // 0x0000000187837528-0x0000000187837534
		public void SetBool(string name, bool value); // 0x000000018783C5F4-0x000000018783C5FC
		public void SetBool(int id, bool value); // 0x000000018783B270-0x000000018783B278
		public int GetInteger(string name); // 0x000000018D4C4178-0x000000018D4C4184
		public int GetInteger(int id); // 0x0000000187837514-0x0000000187837520
		public void SetInteger(string name, int value); // 0x0000000187835DE8-0x0000000187835DF0
		public void SetInteger(int id, int value); // 0x000000018783B268-0x000000018783B270
		public void SetTrigger(string name); // 0x0000000187834898-0x00000001878348A0
		public void SetTrigger(int id); // 0x000000018783AB30-0x000000018783AB38
		public void ResetTrigger(string name); // 0x0000000187834890-0x0000000187834898
		public void ResetTrigger(int id); // 0x0000000187834E08-0x0000000187834E10
		public bool IsParameterControlledByCurve(string name); // 0x000000018D4C49F8-0x000000018D4C4A04
		public bool IsParameterControlledByCurve(int id); // 0x000000018D4C4A04-0x000000018D4C4A10
		[NativeMethod("SetAllowConstantClipSamplingOpt")]
		public void SetAllowConstantClipSamplingOpt(bool enable); // 0x000000018D4C5754-0x000000018D4C5798
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x000000018D4C404C-0x000000018D4C40AC
		private Vector3 GetGoalPosition(AvatarIKGoal goal); // 0x000000018D4C3D68-0x000000018D4C3D98
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition); // 0x000000018D4C6398-0x000000018D4C63EC
		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition); // 0x000000018D4C60F8-0x000000018D4C610C
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x000000018D4C40DC-0x000000018D4C4134
		private Quaternion GetGoalRotation(AvatarIKGoal goal); // 0x000000018D4C3DE8-0x000000018D4C3E18
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation); // 0x000000018D4C642C-0x000000018D4C6474
		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation); // 0x000000018D4C615C-0x000000018D4C6170
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x000000018D4C401C-0x000000018D4C404C
		private float GetGoalWeightPosition(AvatarIKGoal goal); // 0x000000018D4C3E18-0x000000018D4C3E58
		public void SetIKPositionWeight(AvatarIKGoal goal, float value); // 0x000000018D4C6358-0x000000018D4C6398
		private void SetGoalWeightPosition(AvatarIKGoal goal, float value); // 0x000000018D4C6170-0x000000018D4C61C0
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x000000018D4C40AC-0x000000018D4C40DC
		private float GetGoalWeightRotation(AvatarIKGoal goal); // 0x000000018D4C3E58-0x000000018D4C3E98
		public void SetIKRotationWeight(AvatarIKGoal goal, float value); // 0x000000018D4C63EC-0x000000018D4C642C
		private void SetGoalWeightRotation(AvatarIKGoal goal, float value); // 0x000000018D4C61C0-0x000000018D4C6210
		public Vector3 GetIKHintPosition(AvatarIKHint hint); // 0x000000018D4C3FBC-0x000000018D4C401C
		private Vector3 GetHintPosition(AvatarIKHint hint); // 0x000000018D4C3F1C-0x000000018D4C3F4C
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition); // 0x000000018D4C6304-0x000000018D4C6358
		private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition); // 0x000000018D4C6260-0x000000018D4C6274
		public float GetIKHintPositionWeight(AvatarIKHint hint); // 0x000000018D4C3F8C-0x000000018D4C3FBC
		private float GetHintWeightPosition(AvatarIKHint hint); // 0x000000018D4C3F4C-0x000000018D4C3F8C
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value); // 0x000000018D4C62C4-0x000000018D4C6304
		private void SetHintWeightPosition(AvatarIKHint hint, float value); // 0x000000018D4C6274-0x000000018D4C62C4
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x000000018D4C65A4-0x000000018D4C65E8
		[NativeMethod("SetLookAtPosition")]
		private void SetLookAtPositionInternal(Vector3 lookAtPosition); // 0x000000018D4C6590-0x000000018D4C65A4
		public void SetLookAtWeight(float weight); // 0x000000018D4C6804-0x000000018D4C685C
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x000000018D4C6650-0x000000018D4C66B8
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x000000018D4C6790-0x000000018D4C6804
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x000000018D4C66B8-0x000000018D4C6730
		public void SetLookAtWeight(float weight, [UnityEngine.Internal.DefaultValue("0.0f")] float bodyWeight, [UnityEngine.Internal.DefaultValue("1.0f")] float headWeight, [UnityEngine.Internal.DefaultValue("0.0f")] float eyesWeight, [UnityEngine.Internal.DefaultValue("0.5f")] float clampWeight); // 0x000000018D4C6730-0x000000018D4C6790
		[NativeMethod("SetLookAtWeight")]
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x000000018D4C65E8-0x000000018D4C6650
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation); // 0x000000018D4C5A18-0x000000018D4C5A6C
		[NativeMethod("SetBoneLocalRotation")]
		private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation); // 0x000000018D4C5A04-0x000000018D4C5A18
		public void SetTransformHierarchy(bool bHas); // 0x000000018D4C70AC-0x000000018D4C70B4
		[NativeMethod("SetHasTransformHierarchy")]
		private void SetTransformHierarchyInternal(bool bHas); // 0x000000018709C9E0-0x000000018709CA30
		public bool GetBoneGlobalTRS(int avatarAssetBoneID, out AnimationTransformf trs); // 0x000000018D4C3734-0x000000018D4C3740
		[NativeMethod("GetBoneGlobalTRS")]
		private bool GetBoneGlobalTRSInternal(int avatarAssetBoneID, out AnimationTransformf trs); // 0x000000018D4C36E4-0x000000018D4C3734
		public AnimationTransformf GetBoneRootTRS(int avatarAssetBoneID); // 0x000000018D4C3898-0x000000018D4C38E0
		[NativeMethod("GetBoneRootTRS")]
		private AnimationTransformf GetBoneRootTRSInternal(int avatarAssetBoneID); // 0x000000018D4C3860-0x000000018D4C3898
		public AnimationTransformf GetBoneLocalTRS(int avatarAssetBoneID); // 0x000000018D4C37C8-0x000000018D4C3810
		[NativeMethod("GetBoneLocalTRS")]
		private AnimationTransformf GetBoneLocalTRSInternal(int avatarAssetBoneID); // 0x000000018D4C3790-0x000000018D4C37C8
		[NativeMethod("SetCorrectiveBoneData")]
		public void SetCorrectiveBoneData(HGCorrectiveBoneData bindings); // 0x000000018D4C5C68-0x000000018D4C5CAC
		[NativeMethod("SetEnableCorrectiveBoneSystem")]
		public void SetEnableCorrectiveBoneSystem(bool enable); // 0x000000018D4C5EB4-0x000000018D4C5EF8
		[NativeMethod("SetBlendProfileData")]
		public void SetBlendProfileData(HGAvatarBlendProfile bindings); // 0x000000018D4C5970-0x000000018D4C59B4
		[NativeMethod("SetEnableAvatarBlendProfile")]
		public void SetEnableAvatarBlendProfile(bool enable); // 0x000000018D4C5DA4-0x000000018D4C5DE8
		[NativeMethod("SetSequenceLayerSkipTimeThreshold")]
		public void SetSequenceLayerSkipTimeThreshold(float value); // 0x0000000185EA6340-0x0000000185EA6390
		[NativeMethod("GetSequenceLayerSkipTimeThreshold")]
		public float GetSequenceLayerSkipTimeThreshold(); // 0x000000018D4C44B0-0x000000018D4C44E4
		[NativeMethod("ForceUpdateCorrectiveBoneDataInEditor")]
		public void ForceUpdateCorrectiveBoneDataInEditor(); // 0x000000018D4C3314-0x000000018D4C3348
		[NativeMethod("SetBakedBindingData")]
		public void SetBakedBindingData(HGAnimationSetBindings bindings); // 0x000000018D4C592C-0x000000018D4C5970
		[NativeMethod("EnableBakedBindingData")]
		public void EnableBakedBindingData(bool enable); // 0x000000018D4C322C-0x000000018D4C3270
		public bool SetClipByIndex(AnimationClip overrideClip, int index); // 0x000000018D4C5A6C-0x000000018D4C5AC0
		public bool SetDynamicClipByBindingIndex(AnimationClip overrideClip, int bindingIndex, int nameHash = 0 /* Metadata: 0x026463D8 */); // 0x000000018D4C5CFC-0x000000018D4C5D60
		public bool SetMontageStateClip(int stateHash, AnimationClip overrideClip, int nameHash = 0 /* Metadata: 0x026463D9 */); // 0x0000000186D41220-0x0000000186D41290
		public void UnloadClipsNoRebind(AnimationClip[] overrideClip, bool clearCache = true /* Metadata: 0x026463DA */); // 0x000000018D4C721C-0x000000018D4C7270
		public void ReloadClipsNoRebind(AnimationClip[] overrideClip); // 0x000000018D4C5420-0x000000018D4C5464
		public void CaptureLastHumanPose(); // 0x0000000185A6E380-0x0000000185A6E3C0
		public void SetWriteTransformDefAsPostProcess(bool enable); // 0x0000000185EA62F0-0x0000000185EA6340
		public void SetWriteTransformDefAsPostProcessSkipOpt(bool enable); // 0x000000018D4C70B4-0x000000018D4C70F8
		public void SetAnimatorJobDispatchMode(AnimatorJobDispatchMode mode); // 0x0000000185EA5ED0-0x0000000185EA5F20
		public AnimatorJobDispatchMode GetAnimatorJobDispatchMode(); // 0x000000018D4C3440-0x000000018D4C3474
		[NativeMethod("AddToFrameSyncGroup")]
		public bool AddToFrameSyncGroup(string groupName, bool isMaster, AnimFrameSyncMode syncMode); // 0x000000018D4C2120-0x000000018D4C2184
		[NativeMethod("RemoveFromFrameSyncGroup")]
		public bool RemoveFromFrameSyncGroup(); // 0x000000018D4C5464-0x000000018D4C5498
		public void SetEnableCollisionConstraintSolver(bool enable); // 0x000000018D4C5E2C-0x000000018D4C5E70
		public void SetEnableDefaultValuesForceUseDefaultPose(bool enable); // 0x000000018D4C5EF8-0x000000018D4C5F3C
		public void SetPoseDriverSystemWeight(float weight); // 0x000000018D4C69F8-0x000000018D4C6A3C
		public float GetPoseDriverSystemWeight(); // 0x000000018D4C438C-0x000000018D4C43C0
		public bool IsEnableDefaultValuesForceUseDefaultPose(); // 0x000000018D4C490C-0x000000018D4C4940
		public void SetEnableConstantOptByDefaultPose(bool enable); // 0x000000018D4C5E70-0x000000018D4C5EB4
		public bool IsEnableConstantOptByDefaultPose(); // 0x000000018D4C48D8-0x000000018D4C490C
		public void SetEnableWriteDefaultValues(bool enable); // 0x000000018D4C5F3C-0x000000018D4C5F80
		public void SetEnableClipBindingOpt(bool enable); // 0x000000018D4C5DE8-0x000000018D4C5E2C
		public void SetEnableOptBindingByAvatar(bool enable); // 0x000000018709CA30-0x000000018709CA80
		public void EnableGenBindingFastPath(bool enable); // 0x000000018709CA80-0x000000018709CAD0
		public bool AddClipsToBindingsNoGrown(AnimationClip[] overrideClip, int nameHash = 0 /* Metadata: 0x026463DB */); // 0x0000000185A6CB60-0x0000000185A6CBC0
		public void SetDynamicBindingReserveCount(int count); // 0x00000001869009C0-0x0000000186900A10
		public void SetDynamicBindingReserveCountByTag(int stringHash, int count); // 0x000000018D4C5CAC-0x000000018D4C5CFC
		public void ReCreatePlayableMemory(); // 0x000000018D4C4E80-0x000000018D4C4EB4
		public void SetForceNonConstantBindingTransforms(Transform[] transforms); // 0x000000018D4C6064-0x000000018D4C60A8
		public AnimationTransformRWBufferHandle CreateClothBindings(Transform[] transformAccessArray); // 0x000000018D4C24F4-0x000000018D4C253C
		public AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(string[] transformPathArray); // 0x000000018D4C2458-0x000000018D4C24A0
		public void DestroyClothBindings(); // 0x000000018D4C31BC-0x000000018D4C31F0
		public void EnableClothBindings(); // 0x000000018D4C3270-0x000000018D4C32A4
		public void DisableClothBindings(); // 0x000000018D4C31F8-0x000000018D4C322C
		public void SetClothBindingsEnableWorldSpace(bool value); // 0x000000018D4C5AC0-0x000000018D4C5B04
		public bool CheckClothBindingsEnableWorldSpace(); // 0x000000018D4C21B8-0x000000018D4C21EC
		public void SetMorphBindingsEnableWorldSpace(bool value); // 0x000000018D4C685C-0x000000018D4C68A0
		public bool CheckMorphBindingsEnableWorldSpace(); // 0x000000018D4C22D4-0x000000018D4C2308
		public AnimationTransformRWBufferHandle CreateMorphBindings(Transform[] transformAccessArray); // 0x0000000186A5C930-0x0000000186A5C980
		public AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(string[] transformPathArray); // 0x000000018D4C2590-0x000000018D4C25D8
		public bool CheckMorphBindingValid([IsReadOnly] in AnimationTransformRWBufferHandle handle); // 0x000000018D4C2290-0x000000018D4C22D4
		public void EnableMorphBindings(); // 0x0000000186A5C980-0x0000000186A5C9C0
		public void DisableMorphBindings(); // 0x0000000185E35CF0-0x0000000185E35D30
		public void SetOptimizedAvatarDataSet(bool optimized); // 0x0000000186950AB0-0x0000000186950B00
		public void SetEnabelMorphBindingWriteInLateUpdate(bool enable); // 0x000000018D4C5D60-0x000000018D4C5DA4
		private ScriptableObject GetBehaviour([NotNull("ArgumentNullException")] System.Type type); // 0x000000018D4C35F4-0x000000018D4C3638
		public T GetBehaviour<T>()
			where T : StateMachineBehaviour;
		private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects)
			where T : StateMachineBehaviour;
		public T[] GetBehaviours<T>()
			where T : StateMachineBehaviour;
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehaviours([NotNull("ArgumentNullException")] System.Type type); // 0x0000000186DB0530-0x0000000186DB0580
		public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex); // 0x000000018D4C3638-0x000000018D4C36E4
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, [NotNull("ArgumentNullException")] System.Type type); // 0x000000018D4C45D8-0x000000018D4C4638
		public string GetLayerName(int layerIndex); // 0x0000000186E394C0-0x0000000186E39510
		public int GetLayerIndex(string layerName); // 0x0000000185F80160-0x0000000185F801B0
		public float GetLayerWeight(int layerIndex); // 0x000000018D4C41C4-0x000000018D4C4204
		public void SetLayerWeight(int layerIndex, float weight); // 0x0000000185711E10-0x0000000185711E70
		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info); // 0x0000000185137B30-0x0000000185137BA0
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex); // 0x0000000185137A80-0x0000000185137B30
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex); // 0x00000001851379E0-0x0000000185137A80
		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info); // 0x000000018D4C3524-0x000000018D4C3574
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex); // 0x000000018D4C3574-0x000000018D4C35C8
		internal int GetAnimatorClipInfoCount(int layerIndex, bool current); // 0x000000018D4C338C-0x000000018D4C33E0
		public int GetCurrentAnimatorClipInfoCount(int layerIndex); // 0x000000018D4C39EC-0x000000018D4C39FC
		public int GetNextAnimatorClipInfoCount(int layerIndex); // 0x000000018D4C42B0-0x000000018D4C42C0
		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex); // 0x000000018D4C3A78-0x000000018D4C3AB8
		[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex); // 0x000000018D4C433C-0x000000018D4C437C
		public bool GetDebugAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018D4C3C40-0x000000018D4C3CAC
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018D4C39FC-0x000000018D4C3A78
		[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
		private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips); // 0x000000018D4C33E0-0x000000018D4C3440
		[FreeFunction(Name = "AnimatorBindings::GetDebugAnimatorClipInfoInternal", HasExplicitThis = true)]
		private bool GetDebugAnimatorClipInfoInternal(int layerIndex, object clips); // 0x000000018D4C3BF0-0x000000018D4C3C40
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018D4C42C0-0x000000018D4C433C
		public bool IsInTransition(int layerIndex); // 0x0000000185137BA0-0x0000000185137BF0
		public bool IsPlayingTag(int layerIndex, int tagHash); // 0x000000018570FFE0-0x0000000185710040
		public bool IsPlayingState(int layerIndex, int stateNameHash); // 0x00000001855293D0-0x0000000185529430
		public int GetAnimatorStateCullMode(int layerIndex); // 0x000000018570ECB0-0x000000018570ED00
		public AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(int layerIndex); // 0x000000018D4C3AB8-0x000000018D4C3B68
		private void GetAnimatorStateRootMotionInfo(int layerIndex, out AnimatorStateRootMotionInfo output); // 0x000000018D4C34D4-0x000000018D4C3524
		public bool HasTrigger(int triggerId); // 0x000000018D4C4598-0x000000018D4C45D8
		[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = true)]
		private AnimatorControllerParameter GetParameterInternal(int index); // 0x000000018597CB50-0x000000018597CBA0
		public AnimatorControllerParameter GetParameter(int index); // 0x000000018597CBA0-0x000000018597CBE0
		private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch); // 0x000000018D4C4BCC-0x000000018D4C4C1C
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime); // 0x000000018D4C4B4C-0x000000018D4C4BCC
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime); // 0x000000018D4C4ACC-0x000000018D4C4B4C
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime, [UnityEngine.Internal.DefaultValue("true")] bool completeMatch); // 0x000000018D4C4C1C-0x000000018D4C4CA0
		public void InterruptMatchTarget(); // 0x000000018D4C4888-0x000000018D4C4894
		public void InterruptMatchTarget([UnityEngine.Internal.DefaultValue("true")] bool completeMatch); // 0x000000018D4C4844-0x000000018D4C4888
		[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
		public void ForceStateNormalizedTime(float normalizedTime); // 0x000000018D4C32F4-0x000000018D4C3314
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration); // 0x000000018D4C2A84-0x000000018D4C2B08
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer); // 0x000000018D4C27AC-0x000000018D4C283C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset); // 0x000000018D4C2920-0x000000018D4C29B8
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C283C-0x000000018D4C28E0
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2644-0x000000018D4C26F0
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion); // 0x000000018D4C2B08-0x000000018D4C2BC4
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C26F0-0x000000018D4C27AC
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime); // 0x000000018D4C28E0-0x000000018D4C2920
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset); // 0x000000018D4C29B8-0x000000018D4C29F4
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer); // 0x000000018D4C25D8-0x000000018D4C260C
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration); // 0x000000018D4C260C-0x000000018D4C2644
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C29F4-0x000000018D4C2A40
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x0000000185C9AEB0-0x0000000185C9AF00
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2A40-0x000000018D4C2A84
		[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = true)]
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion); // 0x0000000185C9AF00-0x0000000185C9AF80
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = true)]
		public void WriteDefaultValues(); // 0x000000018721CC60-0x000000018721CCA0
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValuesDirty", HasExplicitThis = true)]
		public void WriteDefaultValuesDirty(); // 0x0000000186038AE0-0x0000000186038D40
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime); // 0x000000018D4C303C-0x000000018D4C3078
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset); // 0x000000018D4C2CE8-0x000000018D4C2D20
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer); // 0x000000018D4C2CB4-0x000000018D4C2CE8
		public void CrossFade(string stateName, float normalizedTransitionDuration); // 0x000000018D4C2FB4-0x000000018D4C2FF0
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion); // 0x000000018D4C3078-0x000000018D4C3134
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2BC4-0x000000018D4C2C78
		public void CrossFade(string stateName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2E4C-0x000000018D4C2EF8
		public void CrossFade(string stateName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2EF8-0x000000018D4C2FB4
		[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion); // 0x000000018D4C2DAC-0x000000018D4C2E0C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime); // 0x000000018D4C2D20-0x000000018D4C2D60
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset); // 0x000000018D4C3134-0x000000018D4C3170
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer); // 0x000000018D4C2C78-0x000000018D4C2CB4
		public void CrossFade(int stateHashName, float normalizedTransitionDuration); // 0x000000018D4C2E0C-0x000000018D4C2E4C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2FF0-0x000000018D4C303C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C2D60-0x000000018D4C2DAC
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018D4C3170-0x000000018D4C31BC
		[FreeFunction(Name = "AnimatorBindings::ResetToDefaultStates", HasExplicitThis = true)]
		public void ResetToDefaultStates(); // 0x0000000186D2DA00-0x0000000186D2DA40
		public void PlayInFixedTime(string stateName, int layer); // 0x000000018D4C4DD0-0x000000018D4C4DF0
		public void PlayInFixedTime(string stateName); // 0x000000018D4C4D28-0x000000018D4C4D50
		public void PlayInFixedTime(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime); // 0x000000018D4C4D50-0x000000018D4C4DD0
		[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = true)]
		public void PlayInFixedTime(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime); // 0x000000018690C320-0x000000018690C390
		public void PlayInFixedTime(int stateNameHash, int layer); // 0x000000018D4C4D08-0x000000018D4C4D28
		public void PlayInFixedTime(int stateNameHash); // 0x000000018D4C4DF0-0x000000018D4C4E18
		public void Play(string stateName, int layer); // 0x000000018D4C4E18-0x000000018D4C4E38
		public void Play(string stateName); // 0x000000018634A070-0x000000018634A0A0
		public void Play(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime); // 0x000000018634A0A0-0x000000018634A110
		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime); // 0x000000018634A110-0x000000018634A180
		public void Play(int stateNameHash, int layer); // 0x000000018D4C4E38-0x000000018D4C4E58
		public void Play(int stateNameHash); // 0x000000018D4C4E58-0x000000018D4C4E80
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime); // 0x000000018D4C705C-0x000000018D4C70AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", true)]
		public bool IsControlled(Transform transform); // 0x0000000187232850-0x0000000187232860
		internal bool IsBoneTransform(Transform transform); // 0x000000018D4C4894-0x000000018D4C48D8
		public Transform GetBoneTransform(HumanBodyBones humanBoneId); // 0x000000018D4C3920-0x000000018D4C39EC
		[NativeMethod("GetBoneTransform")]
		internal Transform GetBoneTransformInternal(int humanBoneId); // 0x000000018D4C38E0-0x000000018D4C3920
		public Transform GetBoneTransformByBoneId(int boneID); // 0x0000000185A15200-0x0000000185A15220
		[NativeMethod("GetBoneTransformByBoneId")]
		internal Transform GetBoneTransformByBoneIdInternal(int boneId); // 0x0000000185A15220-0x0000000185A15270
		public void StartPlayback(); // 0x000000018D4C710C-0x000000018D4C7140
		public void StopPlayback(); // 0x000000018D4C7180-0x000000018D4C71B4
		public void StartRecording(int frameCount); // 0x000000018D4C7140-0x000000018D4C7180
		public void StopRecording(); // 0x000000018D4C71B4-0x000000018D4C71E8
		private float GetRecorderStartTime(); // 0x000000018D4C43E0-0x000000018D4C4414
		private float GetRecorderStopTime(); // 0x000000018D4C4414-0x000000018D4C4448
		internal void ClearInternalControllerPlayable(); // 0x000000018D4C2308-0x000000018D4C233C
		public bool HasState(int layerIndex, int stateID); // 0x0000000185F7E960-0x0000000185F7E9C0
		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name); // 0x00000001853652D0-0x0000000185365310
		[NativeMethod(Name = "StringToHashCRC32", IsThreadSafe = true)]
		public static int StringToHashCRC32(IntPtr name); // 0x000000018D4C71E8-0x000000018D4C721C
		internal string GetStats(); // 0x000000018D4C4564-0x000000018D4C4598
		[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = true)]
		private void GetCurrentGraph(ref PlayableGraph graph); // 0x000000018D4C3B68-0x000000018D4C3BAC
		private void CheckIfInIKPass(); // 0x000000018D4C2220-0x000000018D4C2290
		private bool IsInIKPass(); // 0x000000018D4C4940-0x000000018D4C4974
		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private void SetFloatString(string name, float value); // 0x0000000185FFC5B0-0x0000000185FFC610
		[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private void SetFloatID(int id, float value); // 0x0000000185E6A2C0-0x0000000185E6A320
		[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
		private float GetFloatString(string name); // 0x000000018647C840-0x000000018647C890
		[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
		private float GetFloatID(int id); // 0x00000001853E7580-0x00000001853E7620
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByID", HasExplicitThis = true)]
		private float GetFloatFromTransitionByID(int layerIndex, int id); // 0x000000018D4C3CAC-0x000000018D4C3CFC
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByIDWithDefault", HasExplicitThis = true)]
		private float GetFloatFromTransitionByIDWithDefault(int layerIndex, int id, float defValue); // 0x0000000186672C10-0x0000000186672C80
		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private void SetBoolString(string name, bool value); // 0x0000000186B421E0-0x0000000186B42240
		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private void SetBoolID(int id, bool value); // 0x00000001863516C0-0x0000000186351720
		[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = true)]
		private bool GetBoolString(string name); // 0x0000000186E5C420-0x0000000186E5C470
		[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
		private bool GetBoolID(int id); // 0x0000000186195FE0-0x0000000186196030
		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		private void SetIntegerString(string name, int value); // 0x00000001869F7BA0-0x00000001869F7C00
		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		private void SetIntegerID(int id, int value); // 0x0000000186776D00-0x0000000186776D60
		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		private int GetIntegerString(string name); // 0x000000018D4C4134-0x000000018D4C4178
		[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
		private int GetIntegerID(int id); // 0x00000001862B6FB0-0x00000001862B7000
		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name); // 0x00000001862F27A0-0x00000001862F27F0
		[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		private void SetTriggerID(int id); // 0x000000018676A020-0x000000018676A070
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name); // 0x00000001860B58B0-0x00000001860B5900
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
		private void ResetTriggerID(int id); // 0x0000000185CA9700-0x0000000185CA9750
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveString(string name); // 0x000000018D4C49B4-0x000000018D4C49F8
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveID(int id); // 0x000000018D4C4974-0x000000018D4C49B4
		[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = true)]
		private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime); // 0x000000018D4C5FE0-0x000000018D4C6044
		[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = true)]
		private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime); // 0x000000018D4C5F80-0x000000018D4C5FE0
		public HGAnimParameterSGHandle[] GetHGParameterHandles(); // 0x000000018D4C3E98-0x000000018D4C3ECC
		public bool CheckHGParmeterHandleValid(); // 0x000000018D4C21EC-0x000000018D4C2220
		[NativeMethod("GetMorphBoneCount")]
		public int GetMorphBoneCount(); // 0x000000018D4C4204-0x000000018D4C4238
		public void GetMorphBoneIds(NativeArray<int> arrayToFill); // 0x000000018D4C428C-0x000000018D4C42B0
		public void GetMorphBoneIdsUnsafe(int count, NativeArray<int> arrayToFill); // 0x000000018D4C4238-0x000000018D4C428C
		[NativeMethod("Internal_GetMorphBoneIds")]
		private void Internal_GetMorphBoneIds(int count, IntPtr arrayToFill); // 0x000000018D4C46A8-0x000000018D4C46F8
		public void SetMorphTransforms(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale); // 0x000000018D4C699C-0x000000018D4C69F8
		public void SetMorphTransformsUnsafe(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale); // 0x000000018D4C68A0-0x000000018D4C699C
		[NativeMethod("Internal_SetMorphTransforms")]
		private void Internal_SetMorphTransforms(int count, IntPtr boneIds, IntPtr translation, IntPtr euler, IntPtr scale); // 0x000000018D4C46F8-0x000000018D4C4758
		[NativeConditional("UNITY_EDITOR")]
		internal void OnUpdateModeChanged(); // 0x000000018D4C4CD4-0x000000018D4C4D08
		[NativeConditional("UNITY_EDITOR")]
		internal void OnCullingModeChanged(); // 0x000000018D4C4CA0-0x000000018D4C4CD4
		[NativeConditional("UNITY_EDITOR")]
		internal void WriteDefaultPose(); // 0x000000018D4C7270-0x000000018D4C72A4
		[NativeMethod("UpdateWithDelta")]
		public void Update(float deltaTime); // 0x0000000185DB0340-0x0000000185DB0390
		[NativeMethod("ForceUpdateWithDelta")]
		public void ForceUpdate(float deltaTime); // 0x000000018D4C3348-0x000000018D4C338C
		public void Rebind(); // 0x000000018D4C4EB4-0x000000018D4C4EC0
		private void Rebind(bool writeDefaultValues); // 0x0000000186E39470-0x0000000186E394C0
		public void ApplyBuiltinRootMotion(); // 0x000000018D4C2184-0x000000018D4C21B8
		[NativeConditional("UNITY_EDITOR")]
		internal void EvaluateController(); // 0x000000018D4C32E8-0x000000018D4C32F4
		private void EvaluateController(float deltaTime); // 0x000000018D4C32A4-0x000000018D4C32E8
		[NativeConditional("UNITY_EDITOR")]
		internal string GetCurrentStateName(int layerIndex); // 0x000000018D4C3BE0-0x000000018D4C3BF0
		[NativeConditional("UNITY_EDITOR")]
		internal string GetNextStateName(int layerIndex); // 0x000000018D4C437C-0x000000018D4C438C
		[NativeConditional("UNITY_EDITOR")]
		private string GetAnimatorStateName(int layerIndex, bool current); // 0x000000018D4C3480-0x000000018D4C34D4
		internal string ResolveHash(int hash); // 0x000000018D4C558C-0x000000018D4C55CC
		public string GetAnimatorStateName(int stateID); // 0x000000018D4C3474-0x000000018D4C3480
		public void GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime = 0f /* Metadata: 0x026463DC */, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x026463E0 */); // 0x000000018783C464-0x000000018783C480
		public void GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x026463E1 */); // 0x000000018783C860-0x000000018783C870
		public void SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x026463E2 */); // 0x000000018D4C5798-0x000000018D4C57A0
		public void RefreshStateOverride(RuntimeAnimatorStateOverride stateOverride); // 0x000000018783C858-0x000000018783C860
		public void SetRuntimeControllerNoRebind(RuntimeAnimatorController controller); // 0x000000018783D42C-0x000000018783D434
		public void RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride); // 0x000000018783C6D8-0x000000018783C6E0
		[NativeMethod("GotoState")]
		internal void Internal_GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime, AnimationBlendStyle blendStyle); // 0x0000000186E79CF0-0x0000000186E79D60
		[NativeMethod("GotoStateInFixedTime")]
		internal void Internal_GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle); // 0x0000000186ED85B0-0x0000000186ED8620
		[NativeMethod("SetAnimationStateOverride")]
		internal void Internal_SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x026463E3 */); // 0x0000000186AC7720-0x0000000186AC7780
		[NativeMethod("RefreshAnimationStateOverride")]
		internal void Internal_RefreshAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride); // 0x0000000186962D50-0x0000000186962DA0
		[NativeMethod("SetRuntimeControllerNoRebind")]
		internal void Internal_SetRuntimeControllerNoRebind(RuntimeAnimatorController controller); // 0x0000000186BCE940-0x0000000186BCE990
		[NativeMethod("RefreshAnimationStateAsyncCompleteOverride")]
		internal void Internal_RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride); // 0x0000000186DD8A60-0x0000000186DD8AB0
		public void SetAvatarNoBind(Avatar avatar); // 0x000000018D4C5924-0x000000018D4C592C
		[NativeMethod("SetAvatarNoBind")]
		internal void Internal_SetAvatarNoBind(Avatar avatar); // 0x0000000186950B00-0x0000000186950B50
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name); // 0x0000000185159710-0x0000000185159730
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id); // 0x0000000185159710-0x0000000185159730
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name); // 0x000000018D4C43C0-0x000000018D4C43E0
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id); // 0x000000018D4C43C0-0x000000018D4C43E0
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value); // 0x0000000186805BA0-0x0000000186805BB0
		private void Internal_SetRetargetScale_Injected(int[] boneNameHashes, int count, ref Vector3 scaleFactor, int[] boneModes); // 0x000000018D4C47BC-0x000000018D4C4820
		private void get_deltaPosition_Injected(out Vector3 ret); // 0x000000018570DD30-0x000000018570DD80
		private void get_deltaRotation_Injected(out Quaternion ret); // 0x000000018570DC80-0x000000018570DCD0
		private void get_velocity_Injected(out Vector3 ret); // 0x000000018570DB20-0x000000018570DB70
		private void get_angularVelocity_Injected(out Vector3 ret); // 0x000000018570DBD0-0x000000018570DC20
		private void get_rootPosition_Injected(out Vector3 ret); // 0x000000018D4C7C98-0x000000018D4C7CDC
		private void set_rootPosition_Injected(ref Vector3 value); // 0x000000018D4C8570-0x000000018D4C85B4
		private void get_rootRotation_Injected(out Quaternion ret); // 0x000000018D4C7D08-0x000000018D4C7D4C
		private void set_rootRotation_Injected(ref Quaternion value); // 0x000000018D4C85C8-0x000000018D4C860C
		private void get_bodyPositionInternal_Injected(out Vector3 ret); // 0x000000018D4C73D8-0x000000018D4C741C
		private void set_bodyPositionInternal_Injected(ref Vector3 value); // 0x000000018D4C8040-0x000000018D4C8084
		private void get_bodyRotationInternal_Injected(out Quaternion ret); // 0x000000018D4C7498-0x000000018D4C74DC
		private void set_bodyRotationInternal_Injected(ref Quaternion value); // 0x000000018D4C80DC-0x000000018D4C8120
		private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret); // 0x000000018D4C3D18-0x000000018D4C3D68
		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition); // 0x000000018D4C60A8-0x000000018D4C60F8
		private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret); // 0x000000018D4C3D98-0x000000018D4C3DE8
		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation); // 0x000000018D4C610C-0x000000018D4C615C
		private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret); // 0x000000018D4C3ECC-0x000000018D4C3F1C
		private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition); // 0x000000018D4C6210-0x000000018D4C6260
		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition); // 0x000000018D4C654C-0x000000018D4C6590
		private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation); // 0x000000018D4C59B4-0x000000018D4C5A04
		private void GetBoneRootTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret); // 0x000000018D4C3810-0x000000018D4C3860
		private void GetBoneLocalTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret); // 0x000000018D4C3740-0x000000018D4C3790
		private void CreateClothBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret); // 0x000000018D4C24A0-0x000000018D4C24F4
		private void CreateClothBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret); // 0x000000018D4C2404-0x000000018D4C2458
		private void CreateMorphBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret); // 0x0000000186A5C9C0-0x0000000186A5CA20
		private void CreateMorphBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret); // 0x000000018D4C253C-0x000000018D4C2590
		private void get_pivotPosition_Injected(out Vector3 ret); // 0x000000018D4C7AA0-0x000000018D4C7AE4
		private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch); // 0x000000018D4C4A68-0x000000018D4C4ACC
		private void get_targetPosition_Injected(out Vector3 ret); // 0x000000018D4C7E40-0x000000018D4C7E84
		private void get_targetRotation_Injected(out Quaternion ret); // 0x000000018D4C7EB0-0x000000018D4C7EF4
	}

	[NativeAsStruct]
	[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
	[UsedByNativeCode]
	public class AnimatorControllerParameter // TypeDefIndex: 87472
	{
		// Fields
		internal string m_Name; // 0x10
		internal AnimatorControllerParameterType m_Type; // 0x18
		internal float m_DefaultFloat; // 0x1C
		internal int m_DefaultInt; // 0x20
		internal bool m_DefaultBool; // 0x24
	
		// Properties
		public string name { get; } // 0x0000000187249840-0x0000000187249850 
		public int nameHash { get; } // 0x0000000185365290-0x00000001853652D0 
		public AnimatorControllerParameterType type { get; } // 0x000000018724B960-0x000000018724B970 
	
		// Constructors
		public AnimatorControllerParameter(); // 0x000000018D4C09BC-0x000000018D4C09FC
	
		// Methods
		public override bool Equals(object o); // 0x000000018D4C0924-0x000000018D4C09BC
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
	}

	[Serializable]
	[Obsolete("This class is not used anymore. See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
	public class AnimationClipPair // TypeDefIndex: 87473
	{
		// Fields
		public AnimationClip originalClip; // 0x10
		public AnimationClip overrideClip; // 0x18
	
		// Constructors
		public AnimationClipPair(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[UsedByNativeCode]
	public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 87475
	{
		// Fields
		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18
	
		// Properties
		public RuntimeAnimatorController runtimeAnimatorController { [NativeMethod("GetAnimatorController")] get; [NativeMethod("SetAnimatorController")] set; } // 0x000000018D4C1BBC-0x000000018D4C1BF0 0x000000018D4C1D20-0x000000018D4C1D64
		public AnimationClip this[string name] { get => default; set {} } // 0x000000018D4C19C4-0x000000018D4C19D4 0x000000018D4C1C0C-0x000000018D4C1C14
		public AnimationClip this[AnimationClip clip] { get => default; set {} } // 0x000000018D4C19B4-0x000000018D4C19C4 0x000000018D4C1BF0-0x000000018D4C1C0C
		public bool enableBindingOpt { [NativeMethod("GetEnableClipBindingOpt")] get; [NativeMethod("SetEnableClipBindingOpt")] set; } // 0x000000018D4C1B20-0x000000018D4C1B54 0x000000018D4C1C98-0x000000018D4C1CDC
		public byte reserveCount { [NativeMethod("GetReserveCount")] get; [NativeMethod("SetReserveCount")] set; } // 0x000000018D4C1B88-0x000000018D4C1BBC 0x000000018D4C1CDC-0x000000018D4C1D20
		public int overridesCount { [NativeMethod("GetOriginalClipsCount")] get; } // 0x000000018D4C1B54-0x000000018D4C1B88 
		[Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
		public AnimationClipPair[] clips { get; set; } // 0x000000018D4C19D4-0x000000018D4C1B20 0x000000018D4C1C14-0x000000018D4C1C98
	
		// Nested types
		internal delegate void OnOverrideControllerDirtyCallback(); // TypeDefIndex: 87474; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public AnimatorOverrideController(); // 0x000000018D4C1940-0x000000018D4C1974
		public AnimatorOverrideController(RuntimeAnimatorController controller); // 0x000000018D4C1974-0x000000018D4C19B4
	
		// Methods
		[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
		private static void Internal_Create([Writable] AnimatorOverrideController self, RuntimeAnimatorController controller); // 0x000000018D4C1758-0x000000018D4C179C
		[NativeMethod("GetClip")]
		private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip); // 0x000000018D4C179C-0x000000018D4C17F0
		[NativeMethod("SetClip")]
		private void Internal_SetClipByName(string name, AnimationClip clip); // 0x000000018D4C17F0-0x000000018D4C1844
		private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip); // 0x000000018D4C14FC-0x000000018D4C1550
		private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify); // 0x000000018D4C18DC-0x000000018D4C1940
		private void SendNotification(); // 0x000000018D4C18A8-0x000000018D4C18DC
		private AnimationClip GetOriginalClip(int index); // 0x000000018D4C1550-0x000000018D4C1590
		private AnimationClip GetOverrideClip(AnimationClip originalClip); // 0x000000018D4C1590-0x000000018D4C15D4
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides); // 0x000000018D4C15D4-0x000000018D4C1758
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides); // 0x000000018D4C13D0-0x000000018D4C14FC
		[NativeConditional("UNITY_EDITOR")]
		internal void PerformOverrideClipListCleanup(); // 0x000000018D4C1874-0x000000018D4C18A8
		[NativeConditional("UNITY_EDITOR")]
		[RequiredByNativeCode]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller); // 0x000000018D4C1844-0x000000018D4C1874
	}

	[NativeHeader("Modules/Animation/OptimizeTransformHierarchy.h")]
	public class AnimatorUtility // TypeDefIndex: 87476
	{
		// Methods
		[FreeFunction]
		public static void OptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go, string[] exposedTransforms); // 0x0000000186950B50-0x0000000186950BA0
		[FreeFunction]
		public static void DeoptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go); // 0x00000001870F3D60-0x00000001870F3DA0
	}

	public enum HumanBodyBones // TypeDefIndex: 87477
	{
		Hips = 0,
		LeftUpperLeg = 1,
		RightUpperLeg = 2,
		LeftLowerLeg = 3,
		RightLowerLeg = 4,
		LeftFoot = 5,
		RightFoot = 6,
		Spine = 7,
		Chest = 8,
		Neck = 9,
		Head = 10,
		LeftShoulder = 11,
		RightShoulder = 12,
		LeftUpperArm = 13,
		RightUpperArm = 14,
		LeftLowerArm = 15,
		RightLowerArm = 16,
		LeftHand = 17,
		RightHand = 18,
		LeftToes = 19,
		RightToes = 20,
		LeftEye = 21,
		RightEye = 22,
		Jaw = 23,
		LeftThumbProximal = 24,
		LeftThumbIntermediate = 25,
		LeftThumbDistal = 26,
		LeftIndexProximal = 27,
		LeftIndexIntermediate = 28,
		LeftIndexDistal = 29,
		LeftMiddleProximal = 30,
		LeftMiddleIntermediate = 31,
		LeftMiddleDistal = 32,
		LeftRingProximal = 33,
		LeftRingIntermediate = 34,
		LeftRingDistal = 35,
		LeftLittleProximal = 36,
		LeftLittleIntermediate = 37,
		LeftLittleDistal = 38,
		RightThumbProximal = 39,
		RightThumbIntermediate = 40,
		RightThumbDistal = 41,
		RightIndexProximal = 42,
		RightIndexIntermediate = 43,
		RightIndexDistal = 44,
		RightMiddleProximal = 45,
		RightMiddleIntermediate = 46,
		RightMiddleDistal = 47,
		RightRingProximal = 48,
		RightRingIntermediate = 49,
		RightRingDistal = 50,
		RightLittleProximal = 51,
		RightLittleIntermediate = 52,
		RightLittleDistal = 53,
		UpperChest = 54,
		LastBone = 55
	}

	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public struct AnimationTransformf // TypeDefIndex: 87478
	{
		// Fields
		public Vector3 t; // 0x00
		public Quaternion q; // 0x0C
		public Vector3 s; // 0x1C
	}

	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : UnityEngine.Object // TypeDefIndex: 87479
	{
		// Properties
		public bool isValid { [NativeMethod("IsValid")] get; } // 0x000000018528A3A0-0x000000018528A3E0 
		public bool isHuman { [NativeMethod("IsHuman")] get; } // 0x0000000185A15180-0x0000000185A151C0 
		public HumanDescription humanDescription { get; } // 0x000000018D4C8E24-0x000000018D4C8E5C 
	
		// Constructors
		private Avatar(); // 0x000000018D4C8DA0-0x000000018D4C8DE0
	
		// Methods
		internal void SetMuscleMinMax(int muscleId, float min, float max); // 0x000000018D4C8CF0-0x000000018D4C8D50
		internal void SetParameter(int parameterId, float value); // 0x000000018D4C8D50-0x000000018D4C8DA0
		internal float GetAxisLength(int humanId); // 0x000000018D4C87B4-0x000000018D4C87DC
		internal Quaternion GetPreRotation(int humanId); // 0x000000018D4C88AC-0x000000018D4C88F4
		internal Quaternion GetPostRotation(int humanId); // 0x000000018D4C8864-0x000000018D4C88AC
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q); // 0x000000018D4C88F4-0x000000018D4C897C
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw); // 0x000000018D4C897C-0x000000018D4C89F0
		internal Vector3 GetLimitSign(int humanId); // 0x000000018D4C8810-0x000000018D4C8864
		[NativeMethod("GetAxisLength")]
		internal float Internal_GetAxisLength(int humanId); // 0x000000018D4C89F0-0x000000018D4C8A30
		[NativeMethod("GetPreRotation")]
		internal Quaternion Internal_GetPreRotation(int humanId); // 0x000000018D4C8B80-0x000000018D4C8BB0
		[NativeMethod("GetPostRotation")]
		internal Quaternion Internal_GetPostRotation(int humanId); // 0x000000018D4C8B00-0x000000018D4C8B30
		[NativeMethod("GetZYPostQ")]
		internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q); // 0x000000018D4C8C10-0x000000018D4C8C54
		[NativeMethod("GetZYRoll")]
		internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw); // 0x000000018D4C8CB4-0x000000018D4C8CF0
		[NativeMethod("GetLimitSign")]
		internal Vector3 Internal_GetLimitSign(int humanId); // 0x000000018D4C8A80-0x000000018D4C8AB0
		[NativeMethod("GetBonePaths")]
		public string[] GetBonePaths(); // 0x000000018D4C87DC-0x000000018D4C8810
		private void get_humanDescription_Injected(out HumanDescription ret); // 0x000000018D4C8DE0-0x000000018D4C8E24
		private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret); // 0x000000018D4C8B30-0x000000018D4C8B80
		private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret); // 0x000000018D4C8AB0-0x000000018D4C8B00
		private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret); // 0x000000018D4C8BB0-0x000000018D4C8C10
		private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret); // 0x000000018D4C8C54-0x000000018D4C8CB4
		private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret); // 0x000000018D4C8A30-0x000000018D4C8A80
	}

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[RequiredByNativeCode]
	public struct SkeletonBone // TypeDefIndex: 87480
	{
		// Fields
		[NativeName("m_Name")]
		public string name; // 0x00
		[NativeName("m_ParentName")]
		internal string parentName; // 0x08
		[NativeName("m_Position")]
		public Vector3 position; // 0x10
		[NativeName("m_Rotation")]
		public Quaternion rotation; // 0x1C
		[NativeName("m_Scale")]
		public Vector3 scale; // 0x2C
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoHumanLimit")]
	public struct HumanLimit // TypeDefIndex: 87481
	{
		// Fields
		private Vector3 m_Min; // 0x00
		private Vector3 m_Max; // 0x0C
		private Vector3 m_Center; // 0x18
		private float m_AxisLength; // 0x24
		private int m_UseDefaultValues; // 0x28
	}

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoHumanBone")]
	[RequiredByNativeCode]
	public struct HumanBone // TypeDefIndex: 87482
	{
		// Fields
		private string m_BoneName; // 0x00
		private string m_HumanName; // 0x08
		[NativeName("m_Limit")]
		public HumanLimit limit; // 0x10
	}

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	public struct HumanDescription // TypeDefIndex: 87483
	{
		// Fields
		[NativeName("m_Human")]
		public HumanBone[] human; // 0x00
		[NativeName("m_Skeleton")]
		public SkeletonBone[] skeleton; // 0x08
		internal float m_ArmTwist; // 0x10
		internal float m_ForeArmTwist; // 0x14
		internal float m_UpperLegTwist; // 0x18
		internal float m_LegTwist; // 0x1C
		internal float m_ArmStretch; // 0x20
		internal float m_LegStretch; // 0x24
		internal float m_FeetSpacing; // 0x28
		internal float m_GlobalScale; // 0x2C
		internal string m_RootMotionBoneName; // 0x30
		internal bool m_HasTranslationDoF; // 0x38
		internal bool m_HasExtraRoot; // 0x39
		internal bool m_SkeletonHasParents; // 0x3A
	}

	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	public enum AvatarMaskBodyPart // TypeDefIndex: 87484
	{
		Root = 0,
		Body = 1,
		Head = 2,
		LeftLeg = 3,
		RightLeg = 4,
		LeftArm = 5,
		RightArm = 6,
		LeftFingers = 7,
		RightFingers = 8,
		LeftFootIK = 9,
		RightFootIK = 10,
		LeftHandIK = 11,
		RightHandIK = 12,
		LastBodyPart = 13
	}

	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AvatarMask.h")]
	[UsedByNativeCode]
	public sealed class AvatarMask : UnityEngine.Object // TypeDefIndex: 87485
	{
		// Properties
		public int transformCount { get; } // 0x000000018D4C8780-0x000000018D4C87B4 
	
		// Methods
		[NativeMethod("GetBodyPart")]
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index); // 0x000000018D4C86A4-0x000000018D4C86E4
		public string GetTransformPath(int index); // 0x000000018D4C8700-0x000000018D4C8740
		private float GetTransformWeight(int index); // 0x000000018D4C8740-0x000000018D4C8780
		public bool GetTransformActive(int index); // 0x000000018D4C86E4-0x000000018D4C8700
	}

	[NativeHeader("Modules/Animation/HGAnimationSetBinding.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGAnimationSetBindings : UnityEngine.Object // TypeDefIndex: 87486
	{
	}

	[Serializable]
	[NativeHeader("Modules/Animation/HGAnimExtra/HGAvatarBlendProfile.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGAvatarBlendProfile : UnityEngine.Object // TypeDefIndex: 87487
	{
		// Constructors
		public HGAvatarBlendProfile(); // 0x000000018D4C8E90-0x000000018D4C8EDC
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHGAvatarBlendProfile")]
		private static void Internal_Create([Writable] HGAvatarBlendProfile self); // 0x000000018D4C8E5C-0x000000018D4C8E90
	}

	[Serializable]
	[NativeHeader("Modules/Animation/HGAnimExtra/HGCorrectiveBoneData.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGCorrectiveBoneData : UnityEngine.Object // TypeDefIndex: 87488
	{
		// Constructors
		public HGCorrectiveBoneData(); // 0x000000018D4C8F10-0x000000018D4C8F5C
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHGAnimCorrectiveBoneData")]
		private static void Internal_Create([Writable] HGCorrectiveBoneData self); // 0x000000018D4C8EDC-0x000000018D4C8F10
	}

	[NativeHeader("Modules/Animation/HGSkeletalMorphAvatar.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/SkeletalMorph.bindings.h")]
	[UsedByNativeCode]
	public sealed class HGSkeletalMorphAvatar : UnityEngine.Object // TypeDefIndex: 87489
	{
		// Constructors
		private HGSkeletalMorphAvatar(); // 0x000000018D4C8F90-0x000000018D4C8FDC
	
		// Methods
		[FreeFunction("SkeletalMorphBindings::CreateSkeletalMorphAvatar")]
		private static void Internal_Create([Writable] HGSkeletalMorphAvatar self); // 0x000000018D4C8F5C-0x000000018D4C8F90
	}

	public struct HumanPose // TypeDefIndex: 87490
	{
		// Fields
		public Vector3 bodyPosition; // 0x00
		public Quaternion bodyRotation; // 0x0C
		public float[] muscles; // 0x20
	
		// Methods
		internal void Init(); // 0x000000018D4C93C0-0x000000018D4C94C4
	}

	[NativeHeader("Modules/Animation/HumanPoseHandler.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public class HumanPoseHandler : IDisposable // TypeDefIndex: 87491
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public HumanPoseHandler(Avatar avatar, Transform root); // 0x000000018D4C91B0-0x000000018D4C93C0
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHumanPoseHandler")]
		private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root); // 0x000000018D4C9138-0x000000018D4C917C
		[FreeFunction("AnimationBindings::DestroyHumanPoseHandler")]
		private static void Internal_Destroy(IntPtr ptr); // 0x000000018D4C917C-0x000000018D4C91B0
		private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, out float[] muscles); // 0x000000018D4C9038-0x000000018D4C909C
		public void Dispose(); // 0x000000018D4C8FDC-0x000000018D4C9038
		public void GetHumanPose(ref HumanPose humanPose); // 0x000000018D4C909C-0x000000018D4C9138
	}

	[NativeHeader("Modules/Animation/HumanTrait.h")]
	public class HumanTrait // TypeDefIndex: 87492
	{
		// Properties
		public static int MuscleCount { get; } // 0x000000018D4C94F8-0x000000018D4C9524 
		public static string[] MuscleName { [NativeMethod("GetMuscleNames")] get; } // 0x000000018D4C9524-0x000000018D4C9550 
	
		// Methods
		internal static int GetBoneIndexFromMono(int humanId); // 0x000000018D4C94C4-0x000000018D4C94F8
	}

	[NativeHeader("Modules/Animation/LodBoneMask.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class LodBoneMask : UnityEngine.Object // TypeDefIndex: 87493
	{
		// Constructors
		public LodBoneMask(); // 0x000000018D4C9584-0x000000018D4C95D0
	
		// Methods
		[FreeFunction("AnimationBindings::CreateLodBoneMask")]
		private static void Internal_Create([Writable] LodBoneMask self); // 0x000000018D4C9550-0x000000018D4C9584
	}

	[NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : UnityEngine.Object // TypeDefIndex: 87494
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool _isAnimatorMotion_k__BackingField; // 0x18
	
		// Properties
		public bool isLooping { [NativeMethod("IsLooping")] get; } // 0x000000018596EFE0-0x000000018596F020 
	
		// Constructors
		protected Motion(); // 0x000000018548CC60-0x000000018548CC80
	}

	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorController : UnityEngine.Object // TypeDefIndex: 87495
	{
		// Properties
		public AnimationClip[] animationClips { get; } // 0x0000000186D41540-0x0000000186D41580 
	
		// Constructors
		protected RuntimeAnimatorController(); // 0x000000018D4C9D8C-0x000000018D4C9DCC
	}

	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorStateOverride.h")]
	[NativeType("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorStateOverride : UnityEngine.Object // TypeDefIndex: 87496
	{
		// Constructors
		public RuntimeAnimatorStateOverride(); // 0x0000000185FE4910-0x0000000185FE4940
	
		// Methods
		[FreeFunction("RuntimeAnimatorStateOverride::Internal_Create")]
		private static void Internal_Create([Writable] RuntimeAnimatorStateOverride self); // 0x0000000185FE4940-0x0000000185FE4980
		public void SetClip(int stateID, AnimationClip overrideClip); // 0x0000000187839610-0x0000000187839618
		public void SetClipAsync(int stateID, float length, bool isHumanoid); // 0x0000000187839618-0x0000000187839628
		public void RemoveClip(int stateID); // 0x000000018D4C9E54-0x000000018D4C9E5C
		public void ClearClip(); // 0x000000018D4C9DCC-0x000000018D4C9DD4
		public bool PreloadClip(AnimationClip clipB); // 0x000000018783B4F4-0x000000018783B500
		public void SetTransition(int transUserNameID, float transitionDuration, float transitionOffset, float exitTime); // 0x0000000187835638-0x0000000187835648
		public void RemoveTransition(int transUserNameID); // 0x000000018D4C9E5C-0x000000018D4C9E64
		public void SetSyncGroupCurve(uint clipNameID, AnimationCurve curve); // 0x000000018783B41C-0x000000018783B424
		[NativeMethod("SetClip")]
		internal void Internal_SetClip(uint stateID, AnimationClip overrideClip); // 0x00000001867C9340-0x00000001867C93A0
		[NativeMethod("SetClipAsync")]
		internal void Internal_SetClipAsync(uint stateID, float length, bool isHumanoid); // 0x00000001868ECA20-0x00000001868ECA90
		[NativeMethod("RemoveClip")]
		internal void Internal_RemoveClip(uint stateID); // 0x000000018D4C9DD4-0x000000018D4C9E14
		[NativeMethod("ClearClip")]
		internal void Internal_ClearClip(); // 0x0000000186CF5AC0-0x0000000186CF5B00
		[NativeMethod("PreloadClip")]
		internal bool Internal_PreloadClip(AnimationClip clipB); // 0x0000000186B52050-0x0000000186B520A0
		[NativeMethod("SetTransition")]
		internal void Internal_SetTransition(uint transUserNameID, float transitionDuration, float transitionOffset, float exitTime); // 0x00000001865DA110-0x00000001865DA180
		[NativeMethod("RemoveTransition")]
		internal void Internal_RemoveTransition(uint transUserNameID); // 0x000000018D4C9E14-0x000000018D4C9E54
		[NativeMethod("SetSyncGroupCurve")]
		internal void Internal_SetSyncGroupCurve(uint clipNameID, AnimationCurve curve); // 0x00000001864B8CE0-0x00000001864B8D40
	}
}

namespace UnityEngine.Animations
{
	public static class AnimationPlayableBinding // TypeDefIndex: 87499
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key); // 0x000000018D4BE85C-0x000000018D4BE97C
		private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name); // 0x000000018D4BE818-0x000000018D4BE85C
	}

	[AttributeUsage(AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 87500
	{
	}

	[JobProducerType(typeof(ProcessAnimationJobStruct<T>))]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationJob // TypeDefIndex: 87501
	{
		// Methods
		void ProcessAnimation(AnimationStream stream);
		void ProcessRootMotion(AnimationStream stream);
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationWindowPreview // TypeDefIndex: 87502
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 87503
	{
		// Constructors
		public NotKeyableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum JobMethodIndex // TypeDefIndex: 87504
	{
		ProcessRootMotionMethodIndex = 0,
		ProcessAnimationMethodIndex = 1,
		MethodIndexCount = 2
	}

	internal struct ProcessAnimationJobStruct<T> // TypeDefIndex: 87506
		where T : struct, IAnimationJob
	{
		// Fields
		private static IntPtr jobReflectionData;
	
		// Nested types
		public delegate void ExecuteJobFunction(ref ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 87505; 0x00000000-0x00000000
	
		// Methods
		public static IntPtr GetJobReflectionData();
		public static void Execute(ref ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex);
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AdvancedAnimationMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AdvancedAnimationMixerPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AdvancedAnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AdvancedAnimationMixerPlayable : IPlayable, IEquatable<AdvancedAnimationMixerPlayable> // TypeDefIndex: 87507
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AdvancedAnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AdvancedAnimationMixerPlayable(PlayableHandle handle); // 0x0000000185712770-0x00000001857127F0
		static AdvancedAnimationMixerPlayable(); // 0x0000000186FB3E10-0x0000000186FB3F20
	
		// Methods
		public static AdvancedAnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02646435 */); // 0x0000000185712840-0x0000000185712940
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02646436 */); // 0x0000000185712940-0x0000000185712AB0
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public bool Equals(AdvancedAnimationMixerPlayable other); // 0x000000018D4BC6D0-0x000000018D4BC75C
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000185712AB0-0x0000000185712AF0
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x00000001857127F0-0x0000000185712840
	}

	[NativeHeader("Modules/Animation/Director/AnimationBlendTreeFastPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationBlendTreeFastPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationBlendTreeFastPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationBlendTreeFastPlayable : IPlayable, IEquatable<AnimationBlendTreeFastPlayable> // TypeDefIndex: 87508
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public bool Equals(AnimationBlendTreeFastPlayable other); // 0x000000018D4BC75C-0x000000018D4BC7D0
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipFastPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationClipFastPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationClipFastPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipFastPlayable : IPlayable, IEquatable<AnimationClipFastPlayable> // TypeDefIndex: 87509
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public bool Equals(AnimationClipFastPlayable other); // 0x000000018D4BC7D0-0x000000018D4BC844
	}

	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 87510
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AnimationClipPlayable(PlayableHandle handle); // 0x0000000185715480-0x0000000185715520
	
		// Methods
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip); // 0x00000001857151D0-0x0000000185715350
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip); // 0x0000000185715350-0x0000000185715430
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationClipPlayable playable); // 0x000000018725FEA0-0x000000018725FEB0
		public static explicit operator AnimationClipPlayable(Playable playable); // 0x000000018D4BCA74-0x000000018D4BCAEC
		public bool Equals(AnimationClipPlayable other); // 0x000000018D4BC844-0x000000018D4BC8B8
		public AnimationClip GetAnimationClip(); // 0x0000000187837508-0x0000000187837514
		public float GetAnimationClipPlayableLengthUncheck(); // 0x000000018D4BC8EC-0x000000018D4BC8F8
		public void SetAnimationClip(AnimationClip clip); // 0x0000000187839628-0x0000000187839630
		public void SetAnimationClipAsync(float length, bool isHumanoid); // 0x0000000187839630-0x0000000187839638
		public void SetApplyFootIK(bool value); // 0x000000018D4BC93C-0x000000018D4BC944
		public void SetApplyPlayableIK(bool value); // 0x000000018D4BC988-0x000000018D4BC990
		internal void SetRemoveStartOffset(bool value); // 0x000000018D4BCA6C-0x000000018D4BCA74
		internal void SetOverrideLoopTime(bool value); // 0x000000018D4BCA20-0x000000018D4BCA28
		internal void SetLoopTime(bool value); // 0x000000018D4BC9D4-0x000000018D4BC9DC
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle); // 0x0000000187837534-0x0000000187837548
		[NativeThrows]
		private static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle); // 0x00000001861F8130-0x00000001861F8170
		[NativeThrows]
		private static void SetAnimationClipInternal(ref PlayableHandle handle, AnimationClip clip); // 0x0000000186963B30-0x0000000186963B80
		[NativeThrows]
		private static void SetAnimationClipAsyncInternal(ref PlayableHandle handle, float length, bool isHumanoid); // 0x0000000186B9B3A0-0x0000000186B9B400
		[NativeThrows]
		private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BC8F8-0x000000018D4BC93C
		[NativeThrows]
		private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BC944-0x000000018D4BC988
		[NativeThrows]
		private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BCA28-0x000000018D4BCA6C
		[NativeThrows]
		private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BC9DC-0x000000018D4BCA20
		[NativeThrows]
		private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BC990-0x000000018D4BC9D4
		[NativeThrows]
		[ThreadSafe]
		private static float GetAnimationClipPlayableLengthInternalUncheck(ref PlayableHandle handle); // 0x000000018D4BC8B8-0x000000018D4BC8EC
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle); // 0x00000001863E0510-0x00000001863E0570
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimationHumanStream // TypeDefIndex: 87511
	{
		// Fields
		private IntPtr stream; // 0x00
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 87512
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x00
	
		// Properties
		public static AnimationLayerMixerPlayable Null { get; } // 0x000000018D4BDB80-0x000000018D4BDBD8 
	
		// Constructors
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true /* Metadata: 0x02646439 */); // 0x000000018596C630-0x000000018596C730
		static AnimationLayerMixerPlayable(); // 0x000000018596C0A0-0x000000018596C150
	
		// Methods
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02646437 */); // 0x000000018596C240-0x000000018596C2E0
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization); // 0x000000018596C2E0-0x000000018596C3B0
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02646438 */); // 0x000000018596C3B0-0x000000018596C580
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationLayerMixerPlayable playable); // 0x000000018D4BDC54-0x000000018D4BDCA8
		public static explicit operator AnimationLayerMixerPlayable(Playable playable); // 0x000000018D4BDBD8-0x000000018D4BDC54
		public bool Equals(AnimationLayerMixerPlayable other); // 0x000000018D4BD3A8-0x000000018D4BD434
		public void SetLayerAdditive(uint layerIndex, bool value); // 0x000000018D4BD488-0x000000018D4BD5E8
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask); // 0x000000018D4BD7EC-0x000000018D4BD9CC
		public void SetLayerRootMotionDisable(uint layerIndex, bool value); // 0x000000018D4BDA20-0x000000018D4BDB80
		public void SetLayerEnableFloatCurve(uint layerIndex, bool value); // 0x000000018D4BD63C-0x000000018D4BD79C
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x000000018596C580-0x000000018596C5E0
		[NativeThrows]
		private static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018D4BD434-0x000000018D4BD488
		[NativeThrows]
		private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value); // 0x000000018596C730-0x000000018596C780
		[NativeThrows]
		private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask); // 0x000000018D4BD79C-0x000000018D4BD7EC
		[NativeThrows]
		private static void SetLayerRootMotionDisableInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018D4BD9CC-0x000000018D4BDA20
		[NativeThrows]
		private static void SetLayerEnableFloatCurveInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018D4BD5E8-0x000000018D4BD63C
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x000000018596C5E0-0x000000018596C630
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 87513
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationMixerPlayable(PlayableHandle handle); // 0x00000001857144B0-0x0000000185714530
		static AnimationMixerPlayable(); // 0x0000000186FB3F20-0x0000000186FB4030
	
		// Methods
		[Obsolete("normalizeWeights is obsolete. It has no effect and will be removed.")]
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights); // 0x000000018D4BDCA8-0x000000018D4BDD28
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0264643A */); // 0x0000000185714240-0x0000000185714340
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0264643B */); // 0x0000000185714340-0x00000001857144B0
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationMixerPlayable playable); // 0x000000018D4BDDB4-0x000000018D4BDE08
		public bool Equals(AnimationMixerPlayable other); // 0x000000018D4BDD28-0x000000018D4BDDB4
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000185714200-0x0000000185714240
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x0000000185714120-0x0000000185714170
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 87514
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x00
	
		// Constructors
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle); // 0x000000018D4BE1C8-0x000000018D4BE2A0
		static AnimationMotionXToDeltaPlayable(); // 0x000000018D4BE144-0x000000018D4BE1C8
	
		// Methods
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph); // 0x000000018D4BDF84-0x000000018D4BE018
		private static PlayableHandle CreateHandle(PlayableGraph graph); // 0x000000018D4BDEA8-0x000000018D4BDF84
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable); // 0x000000018D4BE2A0-0x000000018D4BE2F4
		public bool Equals(AnimationMotionXToDeltaPlayable other); // 0x000000018D4BE018-0x000000018D4BE0A4
		public void SetAbsoluteMotion(bool value); // 0x000000018D4BE0E8-0x000000018D4BE144
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x000000018D4BDE4C-0x000000018D4BDEA8
		[NativeThrows]
		private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value); // 0x000000018D4BE0A4-0x000000018D4BE0E8
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x000000018D4BDE08-0x000000018D4BDE4C
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 87515
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x00
	
		// Properties
		public static AnimationOffsetPlayable Null { get; } // 0x0000000184F6CD30-0x0000000184F6D050 
	
		// Constructors
		internal AnimationOffsetPlayable(PlayableHandle handle); // 0x000000018D4BE6EC-0x000000018D4BE7C4
		static AnimationOffsetPlayable(); // 0x000000018D4BE668-0x000000018D4BE6EC
	
		// Methods
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount); // 0x000000018D4BE4F0-0x000000018D4BE5D0
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount); // 0x000000018D4BE3D0-0x000000018D4BE4F0
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationOffsetPlayable playable); // 0x000000018D4BE7C4-0x000000018D4BE818
		public static explicit operator AnimationOffsetPlayable(Playable playable); // 0x0000000184F6D050-0x0000000184F6DA50
		public bool Equals(AnimationOffsetPlayable other); // 0x000000018D4BE5D0-0x000000018D4BE668
		public void SetPosition(Vector3 value); // 0x0000000184F6CA00-0x0000000184F6CD30
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle); // 0x000000018D4BE358-0x000000018D4BE3D0
		[NativeThrows]
		private static void SetPositionInternal(ref PlayableHandle handle, Vector3 value); // 0x0000000184F6C6B0-0x0000000184F6CA00
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle); // 0x000000018D4BE2F4-0x000000018D4BE358
		private static void SetPositionInternal_Injected(ref PlayableHandle handle, ref Vector3 value); // 0x0000000184F6C650-0x0000000184F6C6B0
	}

	[NativeHeader("Modules/Animation/AnimationClip.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
	public static class AnimationPlayableExtensions // TypeDefIndex: 87516
	{
		// Methods
		[NativeThrows]
		internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties); // 0x000000018D4BE97C-0x000000018D4BE9C0
	
		// Extension methods
		public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip)
			where U : struct, IPlayable;
	}

	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AnimationPlayableGraphExtensions // TypeDefIndex: 87517
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle); // 0x000000018596CF40-0x000000018596CFA0
	}

	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 87518
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AnimationPlayableOutput Null { get; } // 0x000000018D4BEBC0-0x000000018D4BEC38 
	
		// Constructors
		internal AnimationPlayableOutput(PlayableOutputHandle handle); // 0x000000018596CFA0-0x000000018596D020
	
		// Methods
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target); // 0x000000018596CDD0-0x000000018596CF40
		public PlayableOutputHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator PlayableOutput(AnimationPlayableOutput output); // 0x000000018725FEA0-0x000000018725FEB0
		public static explicit operator AnimationPlayableOutput(PlayableOutput output); // 0x000000018D4BEC38-0x000000018D4BECB0
		public Animator GetTarget(); // 0x000000018D4BEAAC-0x000000018D4BEAB8
		public void SetTarget(Animator value); // 0x0000000187838C74-0x0000000187838C7C
		public void PreBindAnimator(Animator value); // 0x000000018D4BEBA8-0x000000018D4BEBB0
		public void SyncUroContext(); // 0x000000018D4BEBB8-0x000000018D4BEBC0
		public void SetNeedRebindOnChanged(bool value); // 0x000000018D4BEBB0-0x000000018D4BEBB8
		[NativeThrows]
		private static Animator InternalGetTarget(ref PlayableOutputHandle handle); // 0x000000018D4BEAB8-0x000000018D4BEAEC
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target); // 0x000000018662A430-0x000000018662A480
		[NativeThrows]
		private static void InternalPreBindAnimator(ref PlayableOutputHandle handle, Animator target); // 0x000000018D4BEAEC-0x000000018D4BEB30
		[NativeThrows]
		private static void InternalSyncUroContext(ref PlayableOutputHandle handle); // 0x000000018D4BEB74-0x000000018D4BEBA8
		[NativeThrows]
		private static void InternalSetNeedRebindOnChanged(ref PlayableOutputHandle handle, bool value); // 0x000000018D4BEB30-0x000000018D4BEB74
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable> // TypeDefIndex: 87519
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationPosePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationPosePlayable(PlayableHandle handle); // 0x000000018D4BEDCC-0x000000018D4BEEA4
		static AnimationPosePlayable(); // 0x000000018D4BED48-0x000000018D4BEDCC
	
		// Methods
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public bool Equals(AnimationPosePlayable other); // 0x000000018D4BECB0-0x000000018D4BED48
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 87520
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationRemoveScalePlayable(PlayableHandle handle); // 0x000000018D4BF1EC-0x000000018D4BF2C4
		static AnimationRemoveScalePlayable(); // 0x000000018D4BF168-0x000000018D4BF1EC
	
		// Methods
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount); // 0x000000018D4BF02C-0x000000018D4BF0D0
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount); // 0x000000018D4BEF44-0x000000018D4BF02C
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AnimationRemoveScalePlayable playable); // 0x000000018D4BF2C4-0x000000018D4BF318
		public bool Equals(AnimationRemoveScalePlayable other); // 0x000000018D4BF0D0-0x000000018D4BF168
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x000000018D4BEEE8-0x000000018D4BEF44
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x000000018D4BEEA4-0x000000018D4BEEE8
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 87521
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationScriptPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationScriptPlayable(PlayableHandle handle); // 0x000000018D4BF7E4-0x000000018D4BF8BC
		static AnimationScriptPlayable(); // 0x000000018D4BF760-0x000000018D4BF7E4
	
		// Methods
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0 /* Metadata: 0x0264643C */)
			where T : struct, IAnimationJob;
		private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount)
			where T : struct, IAnimationJob;
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		private void CheckJobTypeValidity<T>();
		public void SetJobData<T>(T jobData)
			where T : struct, IAnimationJob;
		public static implicit operator Playable(AnimationScriptPlayable playable); // 0x000000018D4BF8BC-0x000000018D4BF910
		public bool Equals(AnimationScriptPlayable other); // 0x000000018D4BF4DC-0x000000018D4BF568
		public void SetForceWriteRootMotionParam(bool value); // 0x000000018D4BF704-0x000000018D4BF760
		public void SetForceResetParam(bool value); // 0x000000018D4BF608-0x000000018D4BF664
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData); // 0x000000018D4BF478-0x000000018D4BF4DC
		[NativeThrows]
		private static void SetForceWriteRootMotionParamInternal(PlayableHandle handle, bool value); // 0x000000018D4BF6A8-0x000000018D4BF704
		[NativeThrows]
		private static void SetForceResetParamInternal(PlayableHandle handle, bool value); // 0x000000018D4BF5AC-0x000000018D4BF608
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData); // 0x000000018D4BF424-0x000000018D4BF478
		private static void SetForceWriteRootMotionParamInternal_Injected(ref PlayableHandle handle, bool value); // 0x000000018D4BF664-0x000000018D4BF6A8
		private static void SetForceResetParamInternal_Injected(ref PlayableHandle handle, bool value); // 0x000000018D4BF568-0x000000018D4BF5AC
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimationStream // TypeDefIndex: 87522
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private IntPtr constant; // 0x08
		private IntPtr input; // 0x10
		private IntPtr output; // 0x18
		private IntPtr workspace; // 0x20
		private IntPtr inputStreamAccessor; // 0x28
		private IntPtr animationHandleBinder; // 0x30
	
		// Properties
		internal uint animatorBindingsVersion { get; } // 0x000000018725FD00-0x000000018725FD10 
		public bool isValid { get; } // 0x000000018D4C00A4-0x000000018D4C00CC 
		public float deltaTime { get; } // 0x000000018D4C0084-0x000000018D4C00A4 
	
		// Methods
		internal void CheckIsValid(); // 0x000000018D4BFFDC-0x000000018D4C0048
		[NativeMethod(IsThreadSafe = true)]
		private float GetDeltaTime(); // 0x000000018D4C007C-0x000000018D4C0084
		private static float GetDeltaTime_Injected(ref AnimationStream _unity_self); // 0x000000018D4C0048-0x000000018D4C007C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	public struct TransformStreamHandle // TypeDefIndex: 87523
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int skeletonIndex; // 0x08
	
		// Properties
		private bool createdByNative { get; } // 0x000000018D4C9D68-0x000000018D4C9D74 
		private bool hasHandleIndex { get; } // 0x000000018D4C9D7C-0x000000018D4C9D84 
		private bool hasSkeletonIndex { get; } // 0x000000018D4C9D84-0x000000018D4C9D8C 
		internal uint animatorBindingsVersion { get; } // 0x000000018725FD00-0x000000018725FD10 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018D4CAE4C-0x000000018D4CAE60
		private bool IsValidInternal(ref AnimationStream stream); // 0x000000018D4CAE1C-0x000000018D4CAE4C
		private bool IsSameVersionAsStream(ref AnimationStream stream); // 0x000000018D4C99CC-0x000000018D4C99D8
		public void Resolve(AnimationStream stream); // 0x000000018D4CAEAC-0x000000018D4CAEC0
		public bool IsResolved(AnimationStream stream); // 0x000000018D4CAE08-0x000000018D4CAE1C
		private bool IsResolvedInternal(ref AnimationStream stream); // 0x000000018D4CADCC-0x000000018D4CAE08
		private void CheckIsValidAndResolve(ref AnimationStream stream); // 0x000000018D4CA688-0x000000018D4CA7A4
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018D4CAC88-0x000000018D4CACEC
		public void SetPosition(AnimationStream stream, Vector3 position); // 0x000000018D4CB38C-0x000000018D4CB3E0
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018D4CAD70-0x000000018D4CADCC
		public void SetRotation(AnimationStream stream, Quaternion rotation); // 0x000000018D4CB448-0x000000018D4CB494
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018D4CA8F8-0x000000018D4CA95C
		public void SetLocalPosition(AnimationStream stream, Vector3 position); // 0x000000018D4CB02C-0x000000018D4CB080
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018D4CA9E0-0x000000018D4CAA3C
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation); // 0x000000018D4CB0E8-0x000000018D4CB134
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018D4CAAC4-0x000000018D4CAB28
		public void SetLocalScale(AnimationStream stream, Vector3 scale); // 0x000000018D4CB19C-0x000000018D4CB1F0
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CAB9C-0x000000018D4CAC00
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask); // 0x000000018D4CB280-0x000000018D4CB324
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4CA818-0x000000018D4CA870
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask); // 0x000000018D4CAF44-0x000000018D4CAFC4
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream); // 0x000000018D4CAEA4-0x000000018D4CAEAC
		[NativeMethod(Name = "TransformStreamHandleBindings::GetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream); // 0x000000018D4CAC54-0x000000018D4CAC88
		[NativeMethod(Name = "TransformStreamHandleBindings::SetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetPositionInternal(ref AnimationStream stream, Vector3 position); // 0x000000018D4CB378-0x000000018D4CB38C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream); // 0x000000018D4CAD40-0x000000018D4CAD70
		[NativeMethod(Name = "TransformStreamHandleBindings::SetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation); // 0x000000018D4CB434-0x000000018D4CB448
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream); // 0x000000018D4CA8C4-0x000000018D4CA8F8
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position); // 0x000000018D4CB018-0x000000018D4CB02C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream); // 0x000000018D4CA9B0-0x000000018D4CA9E0
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation); // 0x000000018D4CB0D4-0x000000018D4CB0E8
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream); // 0x000000018D4CAA90-0x000000018D4CAAC4
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale); // 0x000000018D4CB188-0x000000018D4CB19C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CAB8C-0x000000018D4CAB9C
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask); // 0x000000018D4CB254-0x000000018D4CB280
		[NativeMethod(Name = "TransformStreamHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4CA808-0x000000018D4CA818
		[NativeMethod(Name = "TransformStreamHandleBindings::SetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask); // 0x000000018D4CAF24-0x000000018D4CAF44
		private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018D4CAE60-0x000000018D4CAEA4
		private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CAC00-0x000000018D4CAC54
		private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position); // 0x000000018D4CB324-0x000000018D4CB378
		private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018D4CACEC-0x000000018D4CAD40
		private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation); // 0x000000018D4CB3E0-0x000000018D4CB434
		private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CA870-0x000000018D4CA8C4
		private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position); // 0x000000018D4CAFC4-0x000000018D4CB018
		private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018D4CA95C-0x000000018D4CA9B0
		private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation); // 0x000000018D4CB080-0x000000018D4CB0D4
		private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CAA3C-0x000000018D4CAA90
		private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 scale); // 0x000000018D4CB134-0x000000018D4CB188
		private static void GetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CAB28-0x000000018D4CAB8C
		private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, bool useMask); // 0x000000018D4CB1F0-0x000000018D4CB254
		private static void GetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4CA7A4-0x000000018D4CA808
		private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, bool useMask); // 0x000000018D4CAEC0-0x000000018D4CAF24
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	public struct PropertyStreamHandle // TypeDefIndex: 87524
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int valueArrayIndex; // 0x08
		private int bindType; // 0x0C
	
		// Properties
		private bool createdByNative { get; } // 0x000000018D4C9D68-0x000000018D4C9D74 
		private bool hasHandleIndex { get; } // 0x000000018D4C9D7C-0x000000018D4C9D84 
		private bool hasValueArrayIndex { get; } // 0x000000018D4C9D84-0x000000018D4C9D8C 
		private bool hasBindType { get; } // 0x000000018D4C9D74-0x000000018D4C9D7C 
		internal uint animatorBindingsVersion { get; } // 0x000000018725FD00-0x000000018725FD10 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018D4C9A0C-0x000000018D4C9A20
		private bool IsValidInternal(ref AnimationStream stream); // 0x000000018D4C99D8-0x000000018D4C9A0C
		private bool IsSameVersionAsStream(ref AnimationStream stream); // 0x000000018D4C99CC-0x000000018D4C99D8
		private bool IsResolvedInternal(ref AnimationStream stream); // 0x000000018D4C9990-0x000000018D4C99CC
		private void CheckIsValidAndResolve(ref AnimationStream stream); // 0x000000018D4C95D0-0x000000018D4C96F4
		public float GetFloat(AnimationStream stream); // 0x000000018D4C9820-0x000000018D4C98AC
		public void SetFloat(AnimationStream stream, float value); // 0x000000018D4C9BC8-0x000000018D4C9C64
		public int GetInt(AnimationStream stream); // 0x000000018D4C98F8-0x000000018D4C9990
		public void SetInt(AnimationStream stream, int value); // 0x000000018D4C9CC0-0x000000018D4C9D68
		public bool GetBool(AnimationStream stream); // 0x000000018D4C9740-0x000000018D4C97D4
		public void SetBool(AnimationStream stream, bool value); // 0x000000018D4C9AC8-0x000000018D4C9B6C
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream); // 0x000000018D4C9A64-0x000000018D4C9A6C
		[NativeMethod(Name = "GetFloat", IsThreadSafe = true)]
		private float GetFloatInternal(ref AnimationStream stream); // 0x000000018D4C9818-0x000000018D4C9820
		[NativeMethod(Name = "SetFloat", IsThreadSafe = true)]
		private void SetFloatInternal(ref AnimationStream stream, float value); // 0x000000018D4C9BC0-0x000000018D4C9BC8
		[NativeMethod(Name = "GetInt", IsThreadSafe = true)]
		private int GetIntInternal(ref AnimationStream stream); // 0x000000018D4C98F0-0x000000018D4C98F8
		[NativeMethod(Name = "SetInt", IsThreadSafe = true)]
		private void SetIntInternal(ref AnimationStream stream, int value); // 0x000000018D4C9CB8-0x000000018D4C9CC0
		[NativeMethod(Name = "GetBool", IsThreadSafe = true)]
		private bool GetBoolInternal(ref AnimationStream stream); // 0x000000018D4C9738-0x000000018D4C9740
		[NativeMethod(Name = "SetBool", IsThreadSafe = true)]
		private void SetBoolInternal(ref AnimationStream stream, bool value); // 0x000000018D4C9AC0-0x000000018D4C9AC8
		private static void ResolveInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018D4C9A20-0x000000018D4C9A64
		private static float GetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018D4C97D4-0x000000018D4C9818
		private static void SetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, float value); // 0x000000018D4C9B6C-0x000000018D4C9BC0
		private static int GetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018D4C98AC-0x000000018D4C98F0
		private static void SetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, int value); // 0x000000018D4C9C64-0x000000018D4C9CB8
		private static bool GetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018D4C96F4-0x000000018D4C9738
		private static void SetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, bool value); // 0x000000018D4C9A6C-0x000000018D4C9AC0
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public struct TransformSceneHandle // TypeDefIndex: 87525
	{
		// Fields
		private uint valid; // 0x00
		private int transformSceneHandleDefinitionIndex; // 0x04
	
		// Properties
		private bool createdByNative { get; } // 0x00000001889F343C-0x00000001889F3444 
		private bool hasTransformSceneHandleDefinitionIndex { get; } // 0x000000018D4C9D7C-0x000000018D4C9D84 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018D4CA640-0x000000018D4CA688
		private void CheckIsValid(ref AnimationStream stream); // 0x000000018D4C9EE4-0x000000018D4C9FCC
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018D4CA4B0-0x000000018D4CA514
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018D4CA120-0x000000018D4CA184
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018D4CA598-0x000000018D4CA5F4
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018D4CA208-0x000000018D4CA264
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018D4CA2EC-0x000000018D4CA350
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CA3C4-0x000000018D4CA428
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4CA040-0x000000018D4CA098
		[ThreadSafe]
		private bool HasValidTransform(ref AnimationStream stream); // 0x000000018D4CA638-0x000000018D4CA640
		[NativeMethod(Name = "TransformSceneHandleBindings::GetPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream); // 0x000000018D4CA47C-0x000000018D4CA4B0
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream); // 0x000000018D4CA0EC-0x000000018D4CA120
		[NativeMethod(Name = "TransformSceneHandleBindings::GetRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream); // 0x000000018D4CA568-0x000000018D4CA598
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream); // 0x000000018D4CA1D8-0x000000018D4CA208
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream); // 0x000000018D4CA2B8-0x000000018D4CA2EC
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CA3B4-0x000000018D4CA3C4
		[NativeMethod(Name = "TransformSceneHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4CA030-0x000000018D4CA040
		private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream); // 0x000000018D4CA5F4-0x000000018D4CA638
		private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CA428-0x000000018D4CA47C
		private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CA098-0x000000018D4CA0EC
		private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018D4CA514-0x000000018D4CA568
		private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018D4CA184-0x000000018D4CA1D8
		private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018D4CA264-0x000000018D4CA2B8
		private static void GetLocalTRSInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D4CA350-0x000000018D4CA3B4
		private static void GetGlobalTRInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D4C9FCC-0x000000018D4CA030
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	public struct PropertySceneHandle // TypeDefIndex: 87526
	{
		// Fields
		private uint valid; // 0x00
		private int handleIndex; // 0x04
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationSceneHandleUtility // TypeDefIndex: 87527
	{
		// Methods
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer); // 0x000000018D4BF318-0x000000018D4BF3C0
		internal static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer)
			where T0 : struct
			where T1 : struct;
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadSceneFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count); // 0x000000018D4BF3C0-0x000000018D4BF424
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationStreamHandleUtility // TypeDefIndex: 87528
	{
		// Methods
		public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer, bool useMask); // 0x000000018D4BFEBC-0x000000018D4BFF78
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer); // 0x000000018D4BFDB0-0x000000018D4BFE58
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count); // 0x000000018D4BFE58-0x000000018D4BFEBC
		[NativeMethod(Name = "AnimationHandleUtilityBindings::WriteStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask); // 0x000000018D4BFF78-0x000000018D4BFFDC
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 87529
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimatorControllerPlayable(PlayableHandle handle); // 0x000000018D4C0F1C-0x000000018D4C0FA4
		static AnimatorControllerPlayable(); // 0x000000018D4C0E98-0x000000018D4C0F1C
	
		// Methods
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller); // 0x000000018D4C0B8C-0x000000018D4C0C30
		private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller); // 0x000000018D4C0AB4-0x000000018D4C0B8C
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public void SetHandle(PlayableHandle handle); // 0x000000018D4C0D54-0x000000018D4C0E98
		public bool Equals(AnimatorControllerPlayable other); // 0x000000018D4C0C30-0x000000018D4C0CBC
		public bool IsInTransition(int layerIndex); // 0x000000018D4C0CFC-0x000000018D4C0D54
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle); // 0x000000018D4C0A50-0x000000018D4C0AB4
		[NativeThrows]
		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex); // 0x000000018D4C0CBC-0x000000018D4C0CFC
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle); // 0x000000018D4C09FC-0x000000018D4C0A50
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public enum CustomStreamPropertyType // TypeDefIndex: 87530
	{
		Float = 5,
		Bool = 6,
		Int = 10
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimatorJobExtensions // TypeDefIndex: 87531
	{
		// Methods
		private static void InternalBindStreamTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformStreamHandle transformStreamHandle); // 0x000000018D4C1340-0x000000018D4C1394
		private static void InternalBindStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, bool affectsAnimatorControllerParameter, out PropertyStreamHandle propertyStreamHandle); // 0x000000018D4C12DC-0x000000018D4C1340
		private static void InternalSetStreamHandleLifecycleCleanupEnabled([NotNull("ArgumentNullException")] Animator animator, bool enabled); // 0x0000000184F6DAA0-0x0000000184F6DB00
		private static bool InternalIsStreamHandleLifecycleCleanupEnabled([NotNull("ArgumentNullException")] Animator animator); // 0x0000000184F6DA50-0x0000000184F6DAA0
		private static void InternalBindCustomStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle); // 0x000000018D4C11C0-0x000000018D4C1224
		private static void InternalBindSceneTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformSceneHandle transformSceneHandle); // 0x000000018D4C1288-0x000000018D4C12DC
		private static void InternalBindSceneProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle); // 0x000000018D4C1224-0x000000018D4C1288
		private static void InternalUnbindAllStreamHandles([NotNull("ArgumentNullException")] Animator animator); // 0x000000018D4C1394-0x000000018D4C13C8
	
		// Extension methods
		public static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform); // 0x000000018D4C1170-0x000000018D4C11C0
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property); // 0x000000018D4C10B4-0x000000018D4C10F8
		public static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type); // 0x000000018D4C0FA4-0x000000018D4C0FF0
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference); // 0x000000018D4C1064-0x000000018D4C10B4
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference, [UnityEngine.Internal.DefaultValue("true")] bool affectsAnimatorControllerParameter); // 0x000000018D4C10F8-0x000000018D4C1170
		public static void SetStreamHandleLifecycleCleanupEnabled(this Animator animator, bool enabled); // 0x0000000184F6DAA0-0x0000000184F6DB00
		public static bool IsStreamHandleLifecycleCleanupEnabled(this Animator animator); // 0x0000000184F6DA50-0x0000000184F6DAA0
		public static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform); // 0x000000018D4C1040-0x000000018D4C1064
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property); // 0x000000018D4C1024-0x000000018D4C1040
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference); // 0x000000018D4C0FF0-0x000000018D4C1024
		public static void UnbindAllStreamHandles(this Animator animator); // 0x000000018D4C13C8-0x000000018D4C13D0
	}

	[Flags]
	[NativeType("Modules/Animation/Constraints/ConstraintEnums.h")]
	public enum Axis // TypeDefIndex: 87532
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4
	}

	[Serializable]
	[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
	[NativeType(CodegenOptions = CodegenOptions.Custom, Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource")]
	[UsedByNativeCode]
	public struct ConstraintSource // TypeDefIndex: 87533
	{
		// Fields
		[NativeName("sourceTransform")]
		private Transform m_SourceTransform; // 0x00
		[NativeName("weight")]
		private float m_Weight; // 0x08
	}

	public interface IConstraint // TypeDefIndex: 87534
	{
	}

	internal interface IConstraintInternal // TypeDefIndex: 87535
	{
	}

	[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
	[NativeHeader("Modules/Animation/Constraints/ParentConstraint.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public sealed class ParentConstraint : UnityEngine.Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 87536
	{
		// Properties
		public float weight { get; set; } // 0x0000000184F6F160-0x0000000184F6F1B0 0x0000000184F6F570-0x0000000184F6F5D0
		public bool constraintActive { get; set; } // 0x0000000184F6EDE0-0x0000000184F6EE30 0x0000000184F6F1B0-0x0000000184F6F210
		public bool locked { get; set; } // 0x0000000184F6EE30-0x0000000184F6EE80 0x0000000184F6F210-0x0000000184F6F270
		public int sourceCount { get; } // 0x0000000184F6E140-0x0000000184F6E190 
		public Vector3 translationAtRest { get; set; } // 0x0000000184F6F050-0x0000000184F6F0C0 0x0000000184F6F450-0x0000000184F6F4B0
		public Vector3 rotationAtRest { get; set; } // 0x0000000184F6EEE0-0x0000000184F6EF50 0x0000000184F6F2D0-0x0000000184F6F330
		public Vector3[] translationOffsets { get; set; } // 0x0000000184F6F110-0x0000000184F6F160 0x0000000184F6F510-0x0000000184F6F570
		public Vector3[] rotationOffsets { get; set; } // 0x0000000184F6EFA0-0x0000000184F6EFF0 0x0000000184F6F390-0x0000000184F6F3F0
		public UnityEngine.Animations.Axis translationAxis { get; set; } // 0x0000000184F6F0C0-0x0000000184F6F110 0x0000000184F6F4B0-0x0000000184F6F510
		public UnityEngine.Animations.Axis rotationAxis { get; set; } // 0x0000000184F6EF50-0x0000000184F6EFA0 0x0000000184F6F330-0x0000000184F6F390
	
		// Constructors
		private ParentConstraint(); // 0x0000000184F6ED70-0x0000000184F6EDE0
	
		// Methods
		private static void Internal_Create([Writable] ParentConstraint self); // 0x0000000184F6E520-0x0000000184F6E570
		[FreeFunction("ConstraintBindings::GetSourceCount")]
		private static int GetSourceCountInternal([NotNull("ArgumentNullException")] ParentConstraint self); // 0x0000000184F6E140-0x0000000184F6E190
		public Vector3 GetTranslationOffset(int index); // 0x0000000184F6E470-0x0000000184F6E520
		public void SetTranslationOffset(int index, Vector3 value); // 0x0000000184F6EB10-0x0000000184F6EBA0
		[NativeName("GetTranslationOffset")]
		private Vector3 GetTranslationOffsetInternal(int index); // 0x0000000184F6E3F0-0x0000000184F6E470
		[NativeName("SetTranslationOffset")]
		private void SetTranslationOffsetInternal(int index, Vector3 value); // 0x0000000184F6EAA0-0x0000000184F6EB10
		public Vector3 GetRotationOffset(int index); // 0x0000000184F6E090-0x0000000184F6E140
		public void SetRotationOffset(int index, Vector3 value); // 0x0000000184F6E720-0x0000000184F6E7B0
		[NativeName("GetRotationOffset")]
		private Vector3 GetRotationOffsetInternal(int index); // 0x0000000184F6E010-0x0000000184F6E090
		[NativeName("SetRotationOffset")]
		private void SetRotationOffsetInternal(int index, Vector3 value); // 0x0000000184F6E6B0-0x0000000184F6E720
		private void ValidateSourceIndex(int index); // 0x0000000184F6EBA0-0x0000000184F6ED70
		[FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = true)]
		public void GetSources([NotNull("ArgumentNullException")] List<ConstraintSource> sources); // 0x0000000184F6E320-0x0000000184F6E380
		public void SetSources(List<ConstraintSource> sources); // 0x0000000184F6E970-0x0000000184F6EA30
		[FreeFunction("ConstraintBindings::SetSources", ThrowsException = true)]
		private static void SetSourcesInternal([NotNull("ArgumentNullException")] ParentConstraint self, List<ConstraintSource> sources); // 0x0000000184F6E910-0x0000000184F6E970
		public int AddSource(ConstraintSource source); // 0x0000000184F6DF40-0x0000000184F6DFA0
		public void RemoveSource(int index); // 0x0000000184F6E5D0-0x0000000184F6E640
		[NativeName("RemoveSource")]
		private void RemoveSourceInternal(int index); // 0x0000000184F6E570-0x0000000184F6E5D0
		public ConstraintSource GetSource(int index); // 0x0000000184F6E280-0x0000000184F6E320
		[NativeName("GetSource")]
		private ConstraintSource GetSourceInternal(int index); // 0x0000000184F6E200-0x0000000184F6E280
		public void SetSource(int index, ConstraintSource source); // 0x0000000184F6E890-0x0000000184F6E910
		[NativeName("SetSource")]
		private void SetSourceInternal(int index, ConstraintSource source); // 0x0000000184F6E820-0x0000000184F6E890
		private void get_translationAtRest_Injected(out Vector3 ret); // 0x0000000184F6EFF0-0x0000000184F6F050
		private void set_translationAtRest_Injected(ref Vector3 value); // 0x0000000184F6F3F0-0x0000000184F6F450
		private void get_rotationAtRest_Injected(out Vector3 ret); // 0x0000000184F6EE80-0x0000000184F6EEE0
		private void set_rotationAtRest_Injected(ref Vector3 value); // 0x0000000184F6F270-0x0000000184F6F2D0
		private void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret); // 0x0000000184F6E380-0x0000000184F6E3F0
		private void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value); // 0x0000000184F6EA30-0x0000000184F6EAA0
		private void GetRotationOffsetInternal_Injected(int index, out Vector3 ret); // 0x0000000184F6DFA0-0x0000000184F6E010
		private void SetRotationOffsetInternal_Injected(int index, ref Vector3 value); // 0x0000000184F6E640-0x0000000184F6E6B0
		private int AddSource_Injected(ref ConstraintSource source); // 0x0000000184F6DEE0-0x0000000184F6DF40
		private void GetSourceInternal_Injected(int index, out ConstraintSource ret); // 0x0000000184F6E190-0x0000000184F6E200
		private void SetSourceInternal_Injected(int index, ref ConstraintSource source); // 0x0000000184F6E7B0-0x0000000184F6E820
	}
}

namespace UnityEngine.Experimental.Animations
{
	public enum AnimationStreamSource // TypeDefIndex: 87497
	{
		DefaultValues = 0,
		PreviousInputs = 1
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorDefines.h")]
	[StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimationPlayableOutputExtensions // TypeDefIndex: 87498
	{
		// Methods
		[NativeThrows]
		private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource); // 0x000000018D4BEA00-0x000000018D4BEA14
		[NativeThrows]
		private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder); // 0x000000018D4BEA54-0x000000018D4BEA68
		private static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource); // 0x000000018D4BE9C0-0x000000018D4BEA00
		private static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder); // 0x000000018D4BEA14-0x000000018D4BEA54
	
		// Extension methods
		public static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource); // 0x000000018D4BEA68-0x000000018D4BEA88
		public static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder); // 0x000000018D4BEA88-0x000000018D4BEAAC
	}
}
