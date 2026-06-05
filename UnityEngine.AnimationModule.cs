/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 53: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58072-58175

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58073
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 58074
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine
{
	public interface IAnimationClipSource // TypeDefIndex: 58075
	{
	}

	public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 58076
	{
		// Constructors
		public SharedBetweenAnimatorsAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 58077
	{
		// Constructors
		protected StateMachineBehaviour() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x0000000185492010-0x0000000185492020
	}

	public enum PlayMode // TypeDefIndex: 58078
	{
		StopSameLayer = 0,
		StopAll = 4
	}

	public enum QueueMode // TypeDefIndex: 58079
	{
		CompleteOthers = 0,
		PlayNow = 2
	}

	public enum AnimationBlendMode // TypeDefIndex: 58080
	{
		Blend = 0,
		Additive = 1
	}

	public enum AnimationPlayMode // TypeDefIndex: 58081
	{
		Stop = 0,
		Queue = 1,
		Mix = 2
	}

	public enum AnimationCullingType // TypeDefIndex: 58082
	{
		AlwaysAnimate = 0,
		BasedOnRenderers = 1,
		BasedOnClipBounds = 2,
		BasedOnUserBounds = 3
	}

	internal enum AnimationEventSource // TypeDefIndex: 58083
	{
		NoSource = 0,
		Legacy = 1,
		Animator = 2
	}

	public enum AnimEventHashCodeType // TypeDefIndex: 58084
	{
		None = 0,
		CRC32 = 1,
		HashCode64 = 2
	}

	public sealed class Animation : UnityEngine.Behaviour, IEnumerable // TypeDefIndex: 58086
	{
		// Properties
		public AnimationClip clip { get => default; set {} } // 0x000000018BEA5D20-0x000000018BEA5D54 0x000000018BEA5EB8-0x000000018BEA5EF8
		public bool playAutomatically { get => default; set {} } // 0x0000000184230B90-0x0000000184230BD0 0x000000018BEA5B20-0x000000018BEA5B28
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x000000018BEA5ADC-0x000000018BEA5B20 0x000000018BEA5A6C-0x000000018BEA5AA0
		public bool isPlaying { get => default; } // 0x0000000186474714-0x0000000186474720 
		public UnityEngine.AnimationState this[string name] { get => default; } // 0x0000000186474704-0x0000000186474714 
		public bool animatePhysics { get => default; set {} } // 0x000000018BEA5C10-0x000000018BEA5C44 0x000000018BEA5E20-0x000000018BEA5E60
		public bool animateOnlyIfVisible { get => default; set {} } // 0x000000018BEA5CBC-0x000000018BEA5CEC 0x000000018BEA5EA4-0x000000018BEA5EB8
		public AnimationCullingType cullingType { get => default; set {} } // 0x000000018646DB20-0x000000018646DB28 0x000000018BEA5C78-0x000000018BEA5CBC
		public Bounds localBounds { get => default; set {} } // 0x000000018BEA5E60-0x000000018BEA5EA4 0x00000001844A9C00-0x00000001844A9C20
	
		// Nested types
		private sealed class Enumerator : IEnumerator // TypeDefIndex: 58085
		{
			// Fields
			private Animation m_Outer; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x000000018BEA5DDC-0x000000018BEA5E20 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(Animation outer) {} // 0x000000018BEA5BDC-0x000000018BEA5C10
	
			// Methods
			public bool MoveNext() => default; // 0x000000018BEA5CEC-0x000000018BEA5D20
			public void Reset() {} // 0x000000018454B2F0-0x000000018454B340
		}
	
		// Constructors
		public Animation() {} // 0x000000018521E600-0x000000018521E630
	
		// Methods
		public void Stop() {} // 0x000000018BEA5AA0-0x000000018BEA5AA8
		public void Stop(string name) {} // 0x000000018BEA5A28-0x000000018BEA5A6C
		private void StopNamed(string name) {} // 0x000000018BEA5AA8-0x000000018BEA5ADC
		public void Rewind() {} // 0x000000018BEA5C44-0x000000018BEA5C78
		public void Rewind(string name) {} // 0x000000018BEA58B8-0x000000018BEA58FC
		private void RewindNamed(string name) {} // 0x000000018BEA5B68-0x000000018BEA5B74
		public void Sample() {} // 0x00000001858A3E00-0x00000001858A3E10
		public bool IsPlaying(string name) => default; // 0x0000000185F7D8D0-0x0000000185F7D970
		public bool Play() => default; // 0x0000000185F1D200-0x0000000185F1D260
		public bool Play(UnityEngine.PlayMode mode) => default; // 0x000000018BEA5874-0x000000018BEA5884
		private bool PlayDefaultAnimation(UnityEngine.PlayMode mode) => default; // 0x000000018BEA57F4-0x000000018BEA5810
		public bool Play(string animation) => default; // 0x000000018BEA5810-0x000000018BEA5874
		public bool Play(string animation, UnityEngine.PlayMode mode) => default; // 0x000000018BEA56B0-0x000000018BEA56C0
		public void CrossFade(string animation) {} // 0x000000018BEA5724-0x000000018BEA5744
		public void CrossFade(string animation, float fadeLength) {} // 0x000000018BEA56C0-0x000000018BEA5724
		public void CrossFade(string animation, float fadeLength, UnityEngine.PlayMode mode) {} // 0x000000018BEA577C-0x000000018BEA5790
		public void Blend(string animation) {} // 0x000000018BEA5744-0x000000018BEA5760
		public void Blend(string animation, float targetWeight) {} // 0x000000018BEA5760-0x000000018BEA577C
		public void Blend(string animation, float targetWeight, float fadeLength) {} // 0x000000018BEA5790-0x000000018BEA57F4
		public UnityEngine.AnimationState CrossFadeQueued(string animation) => default; // 0x000000018BEA58FC-0x000000018BEA590C
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength) => default; // 0x000000018BEA5970-0x000000018BEA598C
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) => default; // 0x000000018BEA590C-0x000000018BEA5970
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, UnityEngine.PlayMode mode) => default; // 0x000000018BEA5624-0x000000018BEA564C
		public UnityEngine.AnimationState PlayQueued(string animation) => default; // 0x000000018BEA5600-0x000000018BEA5624
		public UnityEngine.AnimationState PlayQueued(string animation, QueueMode queue) => default; // 0x000000018BEA564C-0x000000018BEA56B0
		public UnityEngine.AnimationState PlayQueued(string animation, QueueMode queue, UnityEngine.PlayMode mode) => default; // 0x000000018BEA59E4-0x000000018BEA5A28
		public void AddClip(AnimationClip clip, string newName) {} // 0x000000018BEA59DC-0x000000018BEA59E4
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) {} // 0x000000018BEA5998-0x000000018BEA59DC
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) {} // 0x000000018BEA5884-0x000000018BEA58B8
		public void RemoveClip(AnimationClip clip) {} // 0x0000000186474714-0x0000000186474720
		public void RemoveClip(string clipName) {} // 0x000000018BEA598C-0x000000018BEA5998
		private void RemoveClipNamed(string clipName) {} // 0x000000018BEA5B28-0x000000018BEA5B68
		public int GetClipCount() => default; // 0x00000001844A9BA0-0x00000001844A9C00
		public bool Play(AnimationPlayMode mode) => default; // 0x0000000184230B40-0x0000000184230B90
		public bool Play(string animation, AnimationPlayMode mode) => default; // 0x000000018521E630-0x000000018521E680
		public void SyncLayer(int layer) {} // 0x0000000185121750-0x0000000185121790
		public IEnumerator GetEnumerator() => default; // 0x0000000184230B10-0x0000000184230B40
		internal UnityEngine.AnimationState GetState(string name) => default; // 0x000000018BEA5BA8-0x000000018BEA5BDC
		internal UnityEngine.AnimationState GetStateAtIndex(int index) => default; // 0x000000018BEA5D98-0x000000018BEA5DDC
		internal int GetStateCount() => default; // 0x000000018BEA5B74-0x000000018BEA5BA8
		public AnimationClip GetClip(string name) => default; // 0x000000018BEA5D54-0x000000018BEA5D98
		private void get_localBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x00000001851216E0-0x0000000185121750
		private void set_localBounds_Injected(ref Bounds value) {} // 0x0000000185FB1880-0x0000000185FB1890
	}

	public sealed class AnimationState : TrackedReference // TypeDefIndex: 58087
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x000000018BEA4F20-0x000000018BEA4F54 0x000000018BEA50CC-0x000000018BEA5110
		public float weight { get => default; set {} } // 0x000000018BEA5058-0x000000018BEA508C 0x000000018BEA5264-0x000000018BEA52A8
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x00000001844A7930-0x00000001844A7970 0x000000018BEA52A8-0x000000018BEA52E8
		public float time { get => default; set {} } // 0x000000018BEA5024-0x000000018BEA5058 0x000000018BEA5220-0x000000018BEA5264
		public float normalizedTime { get => default; set {} } // 0x000000018BEA4FBC-0x000000018BEA4FF0 0x000000018BEA5198-0x000000018BEA51DC
		public float speed { get => default; set {} } // 0x000000018BEA4FF0-0x000000018BEA5024 0x000000018BEA51DC-0x000000018BEA5220
		public float normalizedSpeed { get => default; set {} } // 0x000000018BEA4F88-0x000000018BEA4FBC 0x000000018BEA5154-0x000000018BEA5198
		public float length { get => default; } // 0x00000001844A78F0-0x00000001844A7930 
		public int layer { get => default; set {} } // 0x000000018BEA4F54-0x000000018BEA4F88 0x00000001844A99C0-0x00000001844A9A10
		public AnimationClip clip { get => default; } // 0x00000001844A9810-0x00000001844A9850 
		public string name { get => default; set {} } // 0x00000001844A8A70-0x00000001844A8AB0 0x000000018BEA5110-0x000000018BEA5154
		public AnimationBlendMode blendMode { get => default; set {} } // 0x000000018BEA4EEC-0x000000018BEA4F20 0x000000018BEA508C-0x000000018BEA50CC
	
		// Constructors
		public AnimationState() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void AddMixingTransform(Transform mix) {} // 0x000000018BEA4E48-0x000000018BEA4E54
		public void AddMixingTransform(Transform mix, bool recursive) {} // 0x000000018BEA4E54-0x000000018BEA4EA8
		public void RemoveMixingTransform(Transform mix) {} // 0x000000018BEA4EA8-0x000000018BEA4EEC
	}

	public struct FastAnimationEvent // TypeDefIndex: 58088
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
		public string stringParameter { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public float floatParameter { get => default; set {} } // 0x0000000185FE6700-0x0000000185FE6710 0x0000000181C9A5B0-0x0000000181C9A5C0
		public int intParameter { get => default; set {} } // 0x0000000185FE6730-0x0000000185FE6740 0x0000000181424940-0x0000000181424950
		public string functionName { get => default; } // 0x0000000185FE6720-0x0000000185FE6730 
		public float time { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FBA160-0x0000000185FBA170
		public SendMessageOptions messageOptions { set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0
		public float clipWeight { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x0000000185FBA180-0x0000000185FBA190
		public bool isInTransition { get => default; set {} } // 0x0000000185FE6760-0x0000000185FE6770 0x0000000185FB0BB0-0x0000000185FB0BC0
		public bool isFromMaxWeightClipState { get => default; set {} } // 0x0000000185FE6740-0x0000000185FE6750 0x0000000185FB0BA0-0x0000000185FB0BB0
		public bool isFromNextMaxWeightClipState { get => default; set {} } // 0x0000000185FE6750-0x0000000185FE6760 0x0000000185FE6780-0x0000000185FE6790
		public int functionNameHashCode { get => default; set {} } // 0x0000000185FE6710-0x0000000185FE6720 0x00000001813D0A90-0x00000001813D0AA0
	}

	public struct FastAnimationEventGroup // TypeDefIndex: 58089
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
	public sealed class AnimationEvent // TypeDefIndex: 58090
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
		public string stringParameter { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018646EE40-0x000000018646EE50
		public float floatParameter { get => default; set {} } // 0x0000000185FE5830-0x0000000185FE5840 0x0000000185FB0BF0-0x0000000185FB0C00
		public int intParameter { get => default; set {} } // 0x0000000185FE66A0-0x0000000185FE66B0 0x0000000185FB07E0-0x0000000185FB07F0
		public UnityEngine.Object objectReferenceParameter { set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string functionName { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public float time { get => default; set {} } // 0x0000000185FE64C0-0x0000000185FE64D0 0x0000000181A6E380-0x0000000181A6E390
		public SendMessageOptions messageOptions { set {} } // 0x00000001813E6F50-0x00000001813E6F60
		public bool isFiredByAnimator { get => default; } // 0x000000018BEA2984-0x000000018BEA298C 
		public AnimatorClipInfo animatorClipInfo { get => default; } // 0x000000018BEA2928-0x000000018BEA2984 
	
		// Constructors
		public AnimationEvent() {} // 0x000000018BEA288C-0x000000018BEA2928
	}

	public sealed class AnimationClip : Motion // TypeDefIndex: 58091
	{
		// Properties
		public float length { get => default; } // 0x0000000184536430-0x0000000184536470 
		internal float startTime { get => default; } // 0x000000018BEA25A0-0x000000018BEA25D4 
		internal float stopTime { get => default; } // 0x000000018BEA25D4-0x000000018BEA2608 
		public float frameRate { get => default; set {} } // 0x000000018BEA238C-0x000000018BEA23C0 0x000000018BEA26BC-0x000000018BEA2700
		public ushort clipTag { get => default; set {} } // 0x000000018BEA22E0-0x000000018BEA2314 0x000000018BEA2670-0x000000018BEA26B4
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x00000001844A9910-0x00000001844A9950 0x000000018BEA27E0-0x000000018BEA2820
		public Bounds localBounds { get => default; set {} } // 0x000000018BEA2570-0x000000018BEA25A0 0x000000018BEA2788-0x000000018BEA279C
		public bool legacy { get => default; set {} } // 0x000000018BEA24F8-0x000000018BEA252C 0x000000018BEA2700-0x000000018BEA2744
		public bool humanMotion { get => default; } // 0x000000018BEA24C4-0x000000018BEA24F8 
		public bool empty { get => default; } // 0x000000018BEA2314-0x000000018BEA2348 
		public bool hasGenericRootTransform { get => default; } // 0x000000018BEA23C0-0x000000018BEA23F4 
		public bool hasMotionFloatCurves { get => default; } // 0x000000018BEA2428-0x000000018BEA245C 
		public bool hasMotionCurves { get => default; } // 0x000000018BEA23F4-0x000000018BEA2428 
		public bool hasRootCurves { get => default; } // 0x000000018BEA245C-0x000000018BEA2490 
		internal bool hasRootMotion { get => default; } // 0x000000018BEA2490-0x000000018BEA24C4 
		public bool transferRotationCompressed { get => default; set {} } // 0x000000018BEA2608-0x000000018BEA263C 0x000000018BEA279C-0x000000018BEA27E0
		public ulong uniqueId { get => default; } // 0x000000018BEA263C-0x000000018BEA2670 
		public AnimationEvent[] events { get => default; set {} } // 0x000000018BEA2348-0x000000018BEA238C 0x000000018BEA26B4-0x000000018BEA26BC
	
		// Constructors
		public AnimationClip() {} // 0x000000018530CCB0-0x000000018530CCD0
	
		// Methods
		private static void Internal_CreateAnimationClip(AnimationClip self) {} // 0x000000018530CD10-0x000000018530CD50
		public void SampleAnimation(GameObject go, float time) {} // 0x00000001844A9870-0x00000001844A9910
		public void SampleAnimationFast(GameObject go, float time) {} // 0x00000001845EDFC0-0x00000001845EE0F0
		internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode) {} // 0x00000001844A9950-0x00000001844A99C0
		internal static void SampleAnimationFast(GameObject go, AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode) {} // 0x00000001845EDF50-0x00000001845EDFC0
		public void SetCurve(string relativePath, System.Type type, string propertyName, AnimationCurve curve) {} // 0x000000018BEA2238-0x000000018BEA229C
		public bool GetAnimatorFloatCurve(string propertyName, AnimationCurve curve) => default; // 0x000000018BEA217C-0x000000018BEA21D0
		public void EnsureQuaternionContinuity() {} // 0x000000018BEA2148-0x000000018BEA217C
		public void ClearCurves() {} // 0x000000018BEA2114-0x000000018BEA2148
		public uint GetRuntimeMemorySize() => default; // 0x000000018BEA2204-0x000000018BEA2238
		public void AddEvent(AnimationEvent evt) {} // 0x000000018BEA20A8-0x000000018BEA2114
		private void AddEventInternal(object evt) {} // 0x000000018BEA2064-0x000000018BEA20A8
		private void SetEventsInternal(Array value) {} // 0x000000018BEA229C-0x000000018BEA22E0
		private Array GetEventsInternal() => default; // 0x000000018BEA21D0-0x000000018BEA2204
		private void get_localBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BEA252C-0x000000018BEA2570
		private void set_localBounds_Injected(ref Bounds value) {} // 0x000000018BEA2744-0x000000018BEA2788
	}

	public enum AvatarTarget // TypeDefIndex: 58092
	{
		Root = 0,
		Body = 1,
		LeftFoot = 2,
		RightFoot = 3,
		LeftHand = 4,
		RightHand = 5
	}

	public enum AvatarIKGoal // TypeDefIndex: 58093
	{
		LeftFoot = 0,
		RightFoot = 1,
		LeftHand = 2,
		RightHand = 3
	}

	public enum AvatarIKHint // TypeDefIndex: 58094
	{
		LeftKnee = 0,
		RightKnee = 1,
		LeftElbow = 2,
		RightElbow = 3
	}

	public enum AnimatorControllerParameterType // TypeDefIndex: 58095
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	internal enum StateInfoIndex // TypeDefIndex: 58096
	{
		CurrentState = 0,
		NextState = 1,
		ExitState = 2,
		InterruptedState = 3
	}

	public enum AnimationBlendStyle // TypeDefIndex: 58097
	{
		Linear = 0,
		CubicIn = 1,
		HermiteCubic = 2,
		Sinusoidal = 3,
		CubicInOut = 4
	}

	public enum AnimatorTransitionInterruptionSource // TypeDefIndex: 58098
	{
		None = 0,
		Current = 1,
		Next = 2,
		CurrentThenNext = 3,
		NextThenCurrent = 4
	}

	public enum AnimatorRecorderMode // TypeDefIndex: 58099
	{
		Offline = 0,
		Playback = 1,
		Record = 2
	}

	public enum AnimatorUroMode // TypeDefIndex: 58100
	{
		Origin = 0,
		Predict = 1,
		PredictWithTick = 2,
		PredictWithTickAndRootMotion = 3
	}

	public enum AnimatorCullingMode // TypeDefIndex: 58101
	{
		AlwaysAnimate = 0,
		CullUpdateTransforms = 1,
		CullCompletely = 2
	}

	public enum AnimatorUpdateMode // TypeDefIndex: 58102
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum AnimatorJobDispatchMode // TypeDefIndex: 58103
	{
		Default = 0,
		ForceMainThread = 1,
		PreUpdate = 2,
		CrossFrame = 3,
		CrossFrameLateUpdate = 4
	}

	public struct AnimatorLOD // TypeDefIndex: 58104
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
		public AnimatorLOD(float worldAbsoluteDistance, int framesPerUpdate, float maxDeltaTime, int framesPerWrite = 0 /* Metadata: 0x0207F493 */, float maxBlendDeltaTime = 0f /* Metadata: 0x0207F494 */, AnimatorUroMode uroMode = AnimatorUroMode.Origin /* Metadata: 0x0207F498 */, int delayFrame = 0 /* Metadata: 0x0207F499 */) {
			this.worldAbsoluteDistance = default;
			this.maxDeltaTime = default;
			this.framesPerUpdate = default;
			this.maxBlendDeltaTime = default;
			this.framesPerWrite = default;
			this.delayFrame = default;
			this.uroMode = default;
		} // 0x0000000185FE66C0-0x0000000185FE66F0
	}

	public struct AnimationTransformRWBufferHandle // TypeDefIndex: 58105
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

	public struct HGAnimParameterSGHandle // TypeDefIndex: 58106
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

	public enum AnimFrameSyncMode // TypeDefIndex: 58107
	{
		FrameSyncInRootPlayable = 0,
		FrameSyncInBaseLayerState = 1
	}

	public struct AnimatorClipInfo // TypeDefIndex: 58108
	{
		// Fields
		private int m_ClipInstanceID; // 0x00
		private float m_Weight; // 0x04
	
		// Properties
		public AnimationClip clip { get => default; } // 0x000000018BEA5F2C-0x000000018BEA5F48 
		public float weight { get => default; } // 0x0000000185FE64E0-0x0000000185FE64F0 
	
		// Methods
		private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) => default; // 0x000000018BEA5EF8-0x000000018BEA5F2C
	}

	public struct AnimatorStateInfo // TypeDefIndex: 58109
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
		public int fullPathHash { get => default; } // 0x00000001835DC780-0x00000001835DC790 
		public int shortNameHash { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public float normalizedTime { get => default; } // 0x0000000185FE66F0-0x0000000185FE6700 
		public float length { get => default; } // 0x0000000185FE64C0-0x0000000185FE64D0 
		public int tagHash { get => default; } // 0x0000000185FC79A0-0x0000000185FC79B0 
		public bool loop { get => default; } // 0x0000000185414EE0-0x0000000185414EF0 
	
		// Methods
		public bool IsName(string name) => default; // 0x000000018BEA7320-0x000000018BEA7350
		public bool IsTag(string tag) => default; // 0x0000000185A83F00-0x0000000185A83F30
	}

	public struct AnimatorStateRootMotionInfo // TypeDefIndex: 58110
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

	public struct AnimatorTransitionInfo // TypeDefIndex: 58111
	{
		// Fields
		private int m_FullPath; // 0x00
		private int m_UserName; // 0x04
		private int m_Name; // 0x08
		private bool m_HasFixedDuration; // 0x0C
		private float m_Duration; // 0x10
		private float m_NormalizedTime; // 0x14
		private bool m_AnyState; // 0x18
		private int m_TransitionType; // 0x1C
	
		// Properties
		public int nameHash { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public bool IsUserName(string name) => default; // 0x000000018BEA7350-0x000000018BEA7374
	}

	public struct MatchTargetWeightMask // TypeDefIndex: 58112
	{
		// Fields
		private Vector3 m_PositionXYZWeight; // 0x00
		private float m_RotationWeight; // 0x0C
	
		// Constructors
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight) {
			m_PositionXYZWeight = default;
			m_RotationWeight = default;
		} // 0x00000001836800E0-0x0000000183680100
	}

	public class Animator : UnityEngine.Behaviour // TypeDefIndex: 58117
	{
		// Fields
		internal AnimationEventCallback onAnimationEvent; // 0x18
		internal AnimationEventCallbackOpt onAnimationEventOpt; // 0x20
		internal AnimatorStateChangeCallback onAnimatorStateEnter; // 0x28
		internal AnimatorStateChangeCallback onAnimatorStateExit; // 0x30
		internal AnimatorStateChangeCallback onAnimatorStatePreExit; // 0x38
		internal AniamtorCommonCallback afterAnimatorUpdateGraphCB; // 0x40
	
		// Properties
		public bool fastAnimationEventsOpt { get => default; set {} } // 0x000000018BEAB754-0x000000018BEAB788 0x000000018BEAC0D4-0x000000018BEAC118
		public bool callBackAfterUpdateGraph { get => default; set {} } // 0x000000018BEAB95C-0x000000018BEAB990 0x000000018BEAC2AC-0x000000018BEAC2F0
		public bool fastAnimationEvents { get => default; set {} } // 0x000000018BEABAEC-0x000000018BEABB20 0x000000018BEAC334-0x000000018BEAC378
		public bool notifyAnimatorStateEnterAndExitEvent { get => default; set {} } // 0x000000018BEAB6AC-0x000000018BEAB6E0 0x000000018BEAB610-0x000000018BEAB644
		public bool keepStateOnChangeActive { get => default; set {} } // 0x000000018BEAB5A8-0x000000018BEAB5DC 0x000000018BEAB6E0-0x000000018BEAB714
		public bool pausePlayableOnChangeActive { get => default; set {} } // 0x000000018BEAB5DC-0x000000018BEAB610 0x000000018BEAB644-0x000000018BEAB678
		public bool resetControllerPlayableOnChangeActive { get => default; set {} } // 0x0000000184CE8D10-0x0000000184CE8D50 0x000000018447E100-0x000000018447E140
		public bool isOptimizable { get => default; } // 0x000000018BEAB4A4-0x000000018BEAB4D8 
		public bool isHuman { get => default; } // 0x000000018452E740-0x000000018452E790 
		public bool hasRootMotion { get => default; } // 0x0000000184484BF0-0x0000000184484C30 
		internal bool isRootPositionOrRotationControlledByCurves { get => default; } // 0x0000000184DB33E0-0x0000000184DB3430 
		public float humanScale { get => default; } // 0x000000018BEA8AE4-0x000000018BEA8B18 
		public bool isInitialized { get => default; } // 0x0000000184CEA4E0-0x0000000184CEA520 
		public bool isVisible { get => default; } // 0x000000018452CD00-0x000000018452CD50 
		public bool updatedLastFrame { get => default; } // 0x000000018BEAA174-0x000000018BEAA1B4 
		public bool enableLOD { get => default; set {} } // 0x000000018BEAA0E4-0x000000018BEAA124 0x000000018BEAA124-0x000000018BEAA174
		public int LODLevel { get => default; } // 0x000000018BEAA094-0x000000018BEAA0E4 
		public float motionDeltaTime { get => default; } // 0x000000018BEAC414-0x000000018BEAC428 
		public Vector3 deltaPosition { get => default; } // 0x000000018BEAB294-0x000000018BEAB2C8 
		public Quaternion deltaRotation { get => default; } // 0x000000018BEABE8C-0x000000018BEABED0 
		public Vector3 velocity { get => default; } // 0x000000018BEAB7F0-0x000000018BEAB824 
		public Vector3 angularVelocity { get => default; } // 0x000000018BEAC15C-0x000000018BEAC1A0 
		public Vector3 rootPosition { get => default; set {} } // 0x000000018BEAB248-0x000000018BEAB260 0x000000018BEABE28-0x000000018BEABE48
		public Quaternion rootRotation { get => default; set {} } // 0x0000000184B98F50-0x0000000184B98F90 0x000000018BEAC46C-0x000000018BEAC4AC
		public bool applyRootMotion { get => default; set {} } // 0x0000000184EDE110-0x0000000184EDE150 0x000000018BEA9D6C-0x000000018BEA9DB0
		public bool linearVelocityBlending { get => default; set {} } // 0x000000018BEAB214-0x000000018BEAB248 0x000000018BEABDE4-0x000000018BEABE28
		public bool animatePhysics { get => default; set {} } // 0x0000000184532140-0x0000000184532180 0x000000018BEAB36C-0x000000018BEAB3BC
		public AnimatorUpdateMode updateMode { get => default; set {} } // 0x000000018BEABF28-0x000000018BEABF6C 0x000000018BEAB340-0x000000018BEAB36C
		public bool hasTransformHierarchy { get => default; } // 0x000000018BEABF14-0x000000018BEABF28 
		internal bool allowConstantClipSamplingOptimization { get => default; set {} } // 0x000000018BEABFC4-0x000000018BEAC000 0x000000018BEAB400-0x000000018BEAB42C
		public float gravityWeight { get => default; } // 0x000000018BEABFB0-0x000000018BEABFC4 
		public Vector3 bodyPosition { get => default; set {} } // 0x000000018BEA8F74-0x000000018BEA8FD4 0x000000018BEA8C90-0x000000018BEA8CC0
		internal Vector3 bodyPositionInternal { get => default; set {} } // 0x000000018BEAA844-0x000000018BEAA898 0x000000018BEAA5A4-0x000000018BEAA5B8
		public Quaternion bodyRotation { get => default; set {} } // 0x000000018BEA9004-0x000000018BEA905C 0x000000018BEA8D10-0x000000018BEA8D40
		internal Quaternion bodyRotationInternal { get => default; set {} } // 0x000000018BEAA8D8-0x000000018BEAA920 0x000000018BEAA608-0x000000018BEAA61C
		public bool stabilizeFeet { get => default; set {} } // 0x000000018453E490-0x000000018453E540 0x000000018453E3D0-0x000000018453E490
		public int layerCount { get => default; } // 0x000000018BEA8418-0x000000018BEA8468 
		public AnimatorControllerParameter[] parameters { get => default; } // 0x000000018BEA9990-0x000000018BEA99E0 
		public int parameterCount { get => default; } // 0x000000018BEA9914-0x000000018BEA9990 
		public float feetPivotActive { get => default; set {} } // 0x000000018BEA96E0-0x000000018BEA96EC 0x000000018BEA969C-0x000000018BEA96E0
		public float pivotWeight { get => default; } // 0x000000018BEAB678-0x000000018BEAB6AC 
		public Vector3 pivotPosition { get => default; } // 0x000000018442BD60-0x000000018442BE00 
		public bool isMatchingTarget { get => default; } // 0x000000018BEA7994-0x000000018BEA79F8 
		public float timeScale { get => default; set {} } // 0x000000018BEA78E4-0x000000018BEA7954 0x000000018BEA778C-0x000000018BEA7804
		public float speed { get => default; set {} } // 0x000000018BEA7B14-0x000000018BEA7B98 0x000000018BEA7804-0x000000018BEA7888
		public Vector3 targetPosition { get => default; } // 0x0000000184EDE170-0x0000000184EDE1C0 
		public Quaternion targetRotation { get => default; } // 0x0000000184487B90-0x0000000184487BD0 
		internal Transform avatarRoot { get => default; } // 0x000000018BEAB070-0x000000018BEAB0A4 
		public AnimatorCullingMode cullingMode { get => default; set {} } // 0x000000018BEABAD4-0x000000018BEABAE0 0x0000000185492010-0x0000000185492020
		public float playbackTime { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BEA9304-0x000000018BEA9338
		public float recorderStartTime { get => default; set {} } // 0x00000001844E8C30-0x00000001844E8C80 0x0000000183FB44D0-0x0000000183FB4510
		public float recorderStopTime { get => default; set {} } // 0x0000000184B56950-0x0000000184B569B0 0x0000000184711D50-0x0000000184711D90
		public AnimatorRecorderMode recorderMode { get => default; } // 0x000000018426A460-0x000000018426A4A0 
		public RuntimeAnimatorController runtimeAnimatorController { get => default; set {} } // 0x0000000185C58300-0x0000000185C58350 0x000000018BEAB8C0-0x000000018BEAB8F4
		public bool hasBoundPlayables { get => default; } // 0x000000018BEAC268-0x000000018BEAC2AC 
		public Avatar avatar { get => default; set {} } // 0x000000018BEA936C-0x000000018BEA93A0 0x000000018BEABA34-0x000000018BEABA6C
		public HGSkeletalMorphAvatar morphAvatar { get => default; set {} } // 0x000000018BEA8AA0-0x000000018BEA8AE4 0x000000018BEA7474-0x000000018BEA74E4
		public LodBoneMask lodBoneMask { get => default; set {} } // 0x000000018BEA9764-0x000000018BEA9798 0x000000018502B5E0-0x000000018502B640
		public uint lodBoneMaskLevel { get => default; set {} } // 0x0000000184D00FC0-0x0000000184D01020 0x0000000185260730-0x0000000185261780
		public PlayableGraph playableGraph { get => default; } // 0x000000018BEA8BE4-0x000000018BEA8C34 
		public bool applyMorphPose { get => default; set {} } // 0x000000018BEA963C-0x000000018BEA969C 0x000000018BEAB788-0x000000018BEAB7BC
		public bool layersAffectMassCenter { get => default; set {} } // 0x0000000184A962E0-0x0000000184A96330 0x000000018BEA823C-0x000000018BEA8280
		public float leftFeetBottomHeight { get => default; } // 0x000000018BEA9CA8-0x000000018BEA9CB4 
		public float rightFeetBottomHeight { get => default; } // 0x0000000185F5F7F0-0x0000000185F5F840 
		internal bool supportsOnAnimatorMove { get => default; } // 0x000000018BEA73D8-0x000000018BEA740C 
		public bool logWarnings { get => default; set {} } // 0x000000018BEABDB0-0x000000018BEABDE4 0x00000001844E8A20-0x00000001844E8A70
		public bool fireEvents { get => default; set {} } // 0x00000001848E6230-0x00000001848E6250 0x00000001848E6230-0x00000001848E6250
		public bool keepAnimatorControllerStateOnDisable { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public bool keepAnimatorStateOnDisable { get => default; set {} } // 0x000000018BEA92B0-0x000000018BEA92D0 0x000000018BEA92B0-0x000000018BEA92D0
		public bool writeDefaultValuesOnDisable { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
	
		// Nested types
		public delegate bool AnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // TypeDefIndex: 58113; 0x000000018BEA94F0-0x000000018BEA95EC
	
		public delegate void AnimatorStateChangeCallback(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex); // TypeDefIndex: 58114; 0x00000001853B1F20-0x00000001853B1FA0
	
		public delegate bool AnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent); // TypeDefIndex: 58115; 0x0000000185F05C80-0x0000000185F05C90
	
		public delegate void AniamtorCommonCallback(Animator animator); // TypeDefIndex: 58116; 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public Animator() {} // 0x00000001854A2CC0-0x00000001854A2CF0
	
		// Methods
		private static void Internal_CallAnimatorStateChangeCallback(Animator anim, AnimatorStateInfo animatorStateInfo, int layerIndex, int methodIdx) {} // 0x0000000185A16440-0x0000000185A16450
		private static void Internal_CallAfterUpdateGraph(Animator anim) {} // 0x000000018BEAB4D8-0x000000018BEAB50C
		private static bool Internal_InvokeAnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent) => default; // 0x0000000184481B10-0x0000000184481B60
		private static bool Internal_InvokeAnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent) => default; // 0x000000018BEAB470-0x000000018BEAB4A4
		public void SetCallbackAfterRootMotionStageCallback(AniamtorCommonCallback cb) {} // 0x000000018BEAC000-0x000000018BEAC044
		public void SetAnimationEventCallback(AnimationEventCallback onAnimationEvent) {} // 0x000000018BEAB50C-0x000000018BEAB540
		public void SetAnimationEventCallbackOpt(AnimationEventCallbackOpt onAnimationEvent) {} // 0x0000000184481B60-0x0000000184481BB0
		public void SetNotifyAnimatorStateEnterAndExitEventCallBack(AnimatorStateChangeCallback onAnimatorStateEnter, AnimatorStateChangeCallback onAnimatorStateExit) {} // 0x000000018BEAB928-0x000000018BEAB95C
		public void SetNotifyAnimatorStatePreExitEventCallBack(AnimatorStateChangeCallback onAnimatorStatePreExit) {} // 0x00000001854A2CF0-0x00000001854A2D40
		public bool SetLODLevel(int level) => default; // 0x0000000184784830-0x0000000184784870
		public int GetCurrentLODLevel() => default; // 0x00000001857FEA60-0x00000001857FEAA0
		public AnimatorLOD[] GetLODs() => default; // 0x00000001857FEAA0-0x00000001857FEAE0
		public void SetLODs(AnimatorLOD[] lods) {} // 0x00000001857FEAE0-0x00000001857FEB20
		public void SetConstraintEnableImmediately(int nameHash) {} // 0x00000001857FEB20-0x00000001857FEB60
		public void SetConstraintDisableImmediately(int nameHash) {} // 0x00000001857FEB60-0x00000001857FEBA0
		public void SetConstraintEnableBlendIn(int nameHash, float duration) {} // 0x00000001857FEBA0-0x00000001857FEBE0
		public void SetConstraintDisableBlendOut(int nameHash, float duration) {} // 0x000000018BEA9E80-0x000000018BEA9EBC
		public void BecameVisible() {} // 0x00000001857FEBE0-0x00000001857FEC20
		public static void SetAnimatorJobOptEnable(bool enabel) {} // 0x000000018BEA84BC-0x000000018BEA84E8
		public static void SetAnimatorJobOptFunc(int value) {} // 0x000000018BEA9E4C-0x000000018BEA9E80
		public static void SetAnimatorWriteTransformOpt(bool value) {} // 0x000000018BEAAE88-0x000000018BEAAEBC
		public static void SetGlobalAnimatorClipBindingsOpt(bool value) {} // 0x000000018BEAAEBC-0x000000018BEAAEF0
		public static void SetGlobalAnimatorClipBindingsConstantOpt(bool value) {} // 0x00000001857FEC20-0x00000001857FEC60
		public static void SetGlobalAnimatorClipBindingsOptByAvatar(bool value) {} // 0x000000018BEA9DB0-0x000000018BEA9DE4
		public static void SetAnimatorUroMaxDeltaTimePerframe(float value) {} // 0x000000018BEA9E18-0x000000018BEA9E4C
		public static void SetGlobalAnimatorCacheClipBindingsOpt(bool value) {} // 0x000000018BEA9EBC-0x000000018BEA9F00
		public static float GetAnimatorUroMaxDeltaTimePerframe() => default; // 0x00000001857FEC60-0x00000001857FECA0
		public static void SetAnimatorMainThreadJobCount(int value) {} // 0x000000018BEA9DE4-0x000000018BEA9E18
		public static void SetPrepareFrameJobBatchCountOpt(int value) {} // 0x0000000184480CA0-0x0000000184480CF0
		public static void SetProcessAnimJobBatchCountOpt(int value) {} // 0x0000000184484BB0-0x0000000184484BF0
		public static void SetAnimatorEnableProcessOneStage(bool value) {} // 0x000000018BEAAEF0-0x000000018BEAAF24
		public static void SetAnimatorEnableApplyOnMoveInJob(bool value) {} // 0x000000018BEAAF24-0x000000018BEAAF58
		public static void SetAnimatorEnableRequireEventsAndBehaviour(bool value) {} // 0x000000018BEAA97C-0x000000018BEAA9D0
		public void SetApplyBuildInRootMotionInJob(bool enable) {} // 0x000000018BEA90AC-0x000000018BEA90EC
		public static void SetAnimatorForbbidenApplyOnMoveCb(bool value) {} // 0x000000018BEAA1B4-0x000000018BEAA1F8
		public static void SetAnimatorEnableCrossFrameJobs(bool enabel) {} // 0x0000000186471070-0x000000018647107C
		public void SetAbilityLevel(int abilityLevel) {} // 0x000000018646D64C-0x000000018646D658
		public int GetAbilityLevel() => default; // 0x000000018BEA8C34-0x000000018BEA8C40
		public static void SetSampleClipCacheCreatePreFrameCount(int value) {} // 0x000000018646EE30-0x000000018646EE40
		public static void SetSampleClipCacheMaxCount(int value) {} // 0x000000018BEAA53C-0x000000018BEAA544
		public void SetLayerMeshSpace(int layerIndex, bool enable) {} // 0x000000018BEAA52C-0x000000018BEAA53C
		public bool GetLayerMeshSpace(int layerIndex) => default; // 0x000000018647107C-0x0000000186471084
		public void SetControllerDefaultValues(bool value) {} // 0x000000018BEAA544-0x000000018BEAA554
		public float GetFloat(string name) => default; // 0x000000018BEA891C-0x000000018BEA8928
		public float GetFloat(int id) => default; // 0x00000001864726E4-0x00000001864726F0
		public float GetFloatFromTransition(int layerIndex, int id) => default; // 0x0000000186474100-0x0000000186474108
		public float GetFloatFromTransitionWithDefault(int layerIndex, int id, float defValue) => default; // 0x0000000186472798-0x00000001864727A0
		public void SetFloat(string name, float value) {} // 0x000000018BEA90A0-0x000000018BEA90AC
		public void SetFloat(string name, float value, float dampTime, float deltaTime) {} // 0x0000000186472760-0x000000018647276C
		public void SetFloat(int id, float value) {} // 0x000000018BEAA974-0x000000018BEAA97C
		public void SetFloat(int id, float value, float dampTime, float deltaTime) {} // 0x0000000186472790-0x0000000186472798
		public bool GetBool(string name) => default; // 0x000000018646D3A4-0x000000018646D3AC
		public bool GetBool(int id) => default; // 0x000000018BEAAFB0-0x000000018BEAAFB8
		public void SetBool(string name, bool value) {} // 0x000000018646D39C-0x000000018646D3A4
		public void SetBool(int id, bool value) {} // 0x000000018646D658-0x000000018646D660
		public int GetInteger(string name) => default; // 0x000000018BEA981C-0x000000018BEA9828
		public int GetInteger(int id) => default; // 0x000000018BEA9828-0x000000018BEA9834
		public void SetInteger(string name, int value) {} // 0x000000018BEAB8F4-0x000000018BEAB928
		public void SetInteger(int id, int value) {} // 0x0000000184532090-0x00000001845320F0
		public void SetTrigger(string name) {} // 0x0000000184532030-0x0000000184532090
		public void SetTrigger(int id) {} // 0x0000000184531ED0-0x0000000184531F30
		public void ResetTrigger(string name) {} // 0x0000000184531F80-0x0000000184531FE0
		public void ResetTrigger(int id) {} // 0x000000018BEABB98-0x000000018BEABBC4
		public bool IsParameterControlledByCurve(string name) => default; // 0x000000018BEAC3BC-0x000000018BEAC3D0
		public bool IsParameterControlledByCurve(int id) => default; // 0x000000018BEABC08-0x000000018BEABC34
		public void SetAllowConstantClipSamplingOpt(bool enable) {} // 0x000000018BEAB42C-0x000000018BEAB470
		public Vector3 GetIKPosition(AvatarIKGoal goal) => default; // 0x000000018BEA8F44-0x000000018BEA8F74
		private Vector3 GetGoalPosition(AvatarIKGoal goal) => default; // 0x000000018BEA8D40-0x000000018BEA8D80
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x000000018BEAA804-0x000000018BEAA844
		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x000000018BEAA61C-0x000000018BEAA66C
		public Quaternion GetIKRotation(AvatarIKGoal goal) => default; // 0x000000018BEA8FD4-0x000000018BEA9004
		private Quaternion GetGoalRotation(AvatarIKGoal goal) => default; // 0x000000018BEA8D80-0x000000018BEA8DC0
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x000000018BEAA898-0x000000018BEAA8D8
		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x000000018BEAA66C-0x000000018BEAA6BC
		public float GetIKPositionWeight(AvatarIKGoal goal) => default; // 0x000000018BEA8EE4-0x000000018BEA8F44
		private float GetGoalWeightPosition(AvatarIKGoal goal) => default; // 0x000000018BEA8E44-0x000000018BEA8E74
		public void SetIKPositionWeight(AvatarIKGoal goal, float value) {} // 0x000000018BEAA7B0-0x000000018BEAA804
		private void SetGoalWeightPosition(AvatarIKGoal goal, float value) {} // 0x000000018BEAA70C-0x000000018BEAA720
		public float GetIKRotationWeight(AvatarIKGoal goal) => default; // 0x000000018BEA8EB4-0x000000018BEA8EE4
		private float GetGoalWeightRotation(AvatarIKGoal goal) => default; // 0x000000018BEA8E74-0x000000018BEA8EB4
		public void SetIKRotationWeight(AvatarIKGoal goal, float value) {} // 0x000000018BEAA770-0x000000018BEAA7B0
		private void SetGoalWeightRotation(AvatarIKGoal goal, float value) {} // 0x000000018BEAA720-0x000000018BEAA770
		public Vector3 GetIKHintPosition(AvatarIKHint hint) => default; // 0x000000018BEAAA28-0x000000018BEAAA6C
		private Vector3 GetHintPosition(AvatarIKHint hint) => default; // 0x000000018BEAAA14-0x000000018BEAAA28
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) {} // 0x000000018BEAAC98-0x000000018BEAACF0
		private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) {} // 0x000000018BEAAAD4-0x000000018BEAAB38
		public float GetIKHintPositionWeight(AvatarIKHint hint) => default; // 0x000000018BEAAC28-0x000000018BEAAC98
		private float GetHintWeightPosition(AvatarIKHint hint) => default; // 0x000000018BEAAB38-0x000000018BEAABB0
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value) {} // 0x000000018BEAABB0-0x000000018BEAAC28
		private void SetHintWeightPosition(AvatarIKHint hint, float value) {} // 0x000000018BEAAA6C-0x000000018BEAAAD4
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x000000018BEA9FA8-0x000000018BEA9FFC
		private void SetLookAtPositionInternal(Vector3 lookAtPosition) {} // 0x000000018BEA9F94-0x000000018BEA9FA8
		public void SetLookAtWeight(float weight) {} // 0x000000018BEAAFA8-0x000000018BEAAFB0
		public void SetLookAtWeight(float weight, float bodyWeight) {} // 0x0000000185D65AE0-0x0000000185D65B30
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) {} // 0x000000018BEA8624-0x000000018BEA8630
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) {} // 0x000000018BEA85D4-0x000000018BEA8624
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x000000018BEA8788-0x000000018BEA87D0
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x000000018BEA8750-0x000000018BEA8788
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) {} // 0x000000018BEA86B8-0x000000018BEA8700
		private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) {} // 0x000000018BEA8680-0x000000018BEA86B8
		public void SetTransformHierarchy(bool bHas) {} // 0x000000018BEAA1F8-0x000000018BEAA23C
		private void SetTransformHierarchyInternal(bool bHas) {} // 0x000000018BEAA358-0x000000018BEAA39C
		public bool GetBoneGlobalTRS(int avatarAssetBoneID, out AnimationTransformf trs) {
			trs = default;
			return default;
		} // 0x0000000184FC6F20-0x0000000184FC6F70
		private bool GetBoneGlobalTRSInternal(int avatarAssetBoneID, out AnimationTransformf trs) {
			trs = default;
			return default;
		} // 0x000000018BEA9338-0x000000018BEA936C
		public AnimationTransformf GetBoneRootTRS(int avatarAssetBoneID) => default; // 0x000000018BEA8208-0x000000018BEA823C
		private AnimationTransformf GetBoneRootTRSInternal(int avatarAssetBoneID) => default; // 0x000000018BEA9F00-0x000000018BEA9F44
		public AnimationTransformf GetBoneLocalTRS(int avatarAssetBoneID) => default; // 0x000000018BEA8120-0x000000018BEA8164
		private AnimationTransformf GetBoneLocalTRSInternal(int avatarAssetBoneID) => default; // 0x000000018BEA9FFC-0x000000018BEAA050
		public void SetCorrectiveBoneData(HGCorrectiveBoneData bindings) {} // 0x000000018BEAB10C-0x000000018BEAB160
		public void SetEnableCorrectiveBoneSystem(bool enable) {} // 0x000000018BEA9CB4-0x000000018BEA9CF8
		public void SetSequenceLayerSkipTimeThreshold(float value) {} // 0x0000000184979B30-0x0000000184979C10
		public float GetSequenceLayerSkipTimeThreshold() => default; // 0x0000000184FC6ED0-0x0000000184FC6F20
		public void ForceUpdateCorrectiveBoneDataInEditor() {} // 0x000000018BEAAFB8-0x000000018BEAAFFC
		public void SetBakedBindingData(HGAnimationSetBindings bindings) {} // 0x00000001859C1070-0x00000001859C10C0
		public void EnableBakedBindingData(bool enable) {} // 0x000000018BEA8334-0x000000018BEA8368
		public bool SetClipByIndex(AnimationClip overrideClip, int index) => default; // 0x000000018BEA7374-0x000000018BEA73D8
		public void UnloadClipsNoRebind(AnimationClip[] overrideClip, bool clearCache = true /* Metadata: 0x0207F49C */) {} // 0x000000018BEA9CF8-0x000000018BEA9D2C
		public void ReloadClipsNoRebind(AnimationClip[] overrideClip) {} // 0x000000018BEAA314-0x000000018BEAA358
		public void CaptureLastHumanPose() {} // 0x000000018BEAA39C-0x000000018BEAA3E0
		public void SetWriteTransformDefAsPostProcess(bool enable) {} // 0x000000018BEA9730-0x000000018BEA9764
		public void SetWriteTransformDefAsPostProcessSkipOpt(bool enable) {} // 0x000000018BEAA424-0x000000018BEAA468
		public void SetAnimatorJobDispatchMode(AnimatorJobDispatchMode mode) {} // 0x000000018BEAA2D0-0x000000018BEAA314
		public AnimatorJobDispatchMode GetAnimatorJobDispatchMode() => default; // 0x000000018BEAA3E0-0x000000018BEAA424
		public bool AddToFrameSyncGroup(string groupName, bool isMaster, AnimFrameSyncMode syncMode) => default; // 0x0000000184D7B9E0-0x0000000184D7BA40
		public bool RemoveFromFrameSyncGroup() => default; // 0x00000001844E8C80-0x00000001844E8CD0
		public void SetEnableCollisionConstraintSolver(bool enable) {} // 0x000000018BEAA23C-0x000000018BEAA28C
		public void SetEnableDefaultValuesForceUseDefaultPose(bool enable) {} // 0x000000018BEA9C74-0x000000018BEA9CA8
		public bool IsEnableDefaultValuesForceUseDefaultPose() => default; // 0x000000018BEA763C-0x000000018BEA7684
		public void SetEnableWriteDefaultValues(bool enable) {} // 0x000000018BEA75A0-0x000000018BEA75E8
		public void SetEnableClipBindingOpt(bool enable) {} // 0x000000018BEA80B8-0x000000018BEA80EC
		public void SetEnableOptBindingByAvatar(bool enable) {} // 0x000000018BEA8164-0x000000018BEA8198
		public bool AddClipsToBindingsNoGrown(AnimationClip[] overrideClip, int nameHash = 0 /* Metadata: 0x0207F49D */) => default; // 0x000000018BEA80EC-0x000000018BEA8120
		public void SetDynamicBindingReserveCount(int count) {} // 0x000000018BEAA050-0x000000018BEAA094
		public void SetDynamicBindingReserveCountByTag(int stringHash, int count) {} // 0x000000018BEA740C-0x000000018BEA7440
		public void ReCreatePlayableMemory() {} // 0x000000018BEAACF0-0x000000018BEAAD34
		public AnimationTransformRWBufferHandle CreateClothBindings(Transform[] transformAccessArray) => default; // 0x000000018BEA74E4-0x000000018BEA7518
		public AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(string[] transformPathArray) => default; // 0x0000000184FC6230-0x0000000184FC6280
		public void DestroyClothBindings() {} // 0x000000018BEA76D8-0x000000018BEA7720
		public void EnableClothBindings() {} // 0x0000000183F864C0-0x0000000183F86520
		public void DisableClothBindings() {} // 0x0000000184FC6280-0x0000000184FC62C0
		public void SetClothBindingsEnableWorldSpace(bool value) {} // 0x0000000184948060-0x00000001849480A0
		public bool CheckClothBindingsEnableWorldSpace() => default; // 0x00000001856D8FA0-0x00000001856D8FF0
		public void SetMorphBindingsEnableWorldSpace(bool value) {} // 0x000000018BEAA28C-0x000000018BEAA2D0
		public bool CheckMorphBindingsEnableWorldSpace() => default; // 0x000000018BEA84E8-0x000000018BEA852C
		public AnimationTransformRWBufferHandle CreateMorphBindings(Transform[] transformAccessArray) => default;
		public AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(string[] transformPathArray) => default;
		public bool CheckMorphBindingValid(in AnimationTransformRWBufferHandle handle) => default;
		public void EnableMorphBindings() {} // 0x000000018BEA9440-0x000000018BEA9484
		public void DisableMorphBindings() {} // 0x000000018BEA852C-0x000000018BEA85D4
		public void SetOptimizedAvatarDataSet(bool optimized) {} // 0x000000018BEA93E0-0x000000018BEA9440
		public void SetEnabelMorphBindingWriteInLateUpdate(bool enable) {} // 0x000000018BEABC68-0x000000018BEABC9C
		private ScriptableObject GetBehaviour(System.Type type) => default; // 0x000000018BEAC428-0x000000018BEAC46C
		public T GetBehaviour<T>()
			where T : StateMachineBehaviour => default; // 0x0000000184D7AC70-0x0000000184D7ACB0
		private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects)
			where T : StateMachineBehaviour => default; // 0x0000000185C31AE0-0x0000000185C31B30
		public T[] GetBehaviours<T>()
			where T : StateMachineBehaviour => default; // 0x0000000184D7BE10-0x0000000184D7BE60
		internal ScriptableObject[] InternalGetBehaviours(System.Type type) => default; // 0x000000018BEA90EC-0x000000018BEA912C
		public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) => default; // 0x0000000184367780-0x00000001843677E0
		internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type) => default; // 0x000000018453E540-0x000000018453E5B0
		public string GetLayerName(int layerIndex) => default; // 0x000000018BEA8468-0x000000018BEA84BC
		public int GetLayerIndex(string layerName) => default; // 0x000000018BEA8280-0x000000018BEA82D4
		public float GetLayerWeight(int layerIndex) => default; // 0x000000018BEA8928-0x000000018BEA8938
		public void SetLayerWeight(int layerIndex, float weight) {} // 0x000000018BEA91D8-0x000000018BEA91E8
		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) {
			info = default;
		} // 0x000000018BEA89B0-0x000000018BEA89F0
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) => default; // 0x000000018BEA9260-0x000000018BEA92A0
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) => default; // 0x000000018BEA8B78-0x000000018BEA8BE4
		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) {
			info = default;
		} // 0x000000018BEA8938-0x000000018BEA89B0
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) => default; // 0x000000018BEA82D4-0x000000018BEA8334
		internal int GetAnimatorClipInfoCount(int layerIndex, bool current) => default; // 0x000000018BEA8B28-0x000000018BEA8B78
		public int GetCurrentAnimatorClipInfoCount(int layerIndex) => default; // 0x000000018BEA91E8-0x000000018BEA9260
		public int GetNextAnimatorClipInfoCount(int layerIndex) => default; // 0x000000018453E5B0-0x000000018453E600
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) => default; // 0x00000001845338D0-0x0000000184533930
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) => default; // 0x0000000184538010-0x0000000184538070
		public bool GetDebugAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) => default; // 0x000000018497C910-0x000000018497C960
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) {} // 0x000000018BEA89F0-0x000000018BEA8AA0
		private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) {} // 0x000000018BEA83C8-0x000000018BEA8418
		private bool GetDebugAnimatorClipInfoInternal(int layerIndex, object clips) => default; // 0x000000018BEA93A0-0x000000018BEA93E0
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) {} // 0x0000000184D78880-0x0000000184D788C0
		public bool IsInTransition(int layerIndex) => default; // 0x0000000185346520-0x0000000185346560
		public bool IsPlayingTag(int layerIndex, int tagHash) => default; // 0x00000001853464D0-0x0000000185346520
		public bool IsPlayingState(int layerIndex, int stateNameHash) => default; // 0x0000000185346490-0x00000001853464D0
		public int GetAnimatorStateCullMode(int layerIndex) => default; // 0x000000018BEAB540-0x000000018BEAB574
		public AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(int layerIndex) => default; // 0x000000018BEAC044-0x000000018BEAC088
		private void GetAnimatorStateRootMotionInfo(int layerIndex, out AnimatorStateRootMotionInfo output) {
			output = default;
		} // 0x000000018BEABA00-0x000000018BEABA34
		public bool HasTrigger(int triggerId) => default; // 0x000000018BEAB9D4-0x000000018BEABA00
		private AnimatorControllerParameter GetParameterInternal(int index) => default; // 0x000000018BEA9898-0x000000018BEA9914
		public AnimatorControllerParameter GetParameter(int index) => default; // 0x000000018BEA99E0-0x000000018BEA9A64
		private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) {} // 0x00000001844D5510-0x00000001844D5560
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) {} // 0x000000018BEABC34-0x000000018BEABC68
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) {} // 0x00000001844D5560-0x00000001844D55B0
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) {} // 0x000000018BEA81E8-0x000000018BEA8208
		public void InterruptMatchTarget() {} // 0x000000018BEA7AC4-0x000000018BEA7B14
		public void InterruptMatchTarget(bool completeMatch) {} // 0x000000018BEA7888-0x000000018BEA78E4
		public void ForceStateNormalizedTime(float normalizedTime) {} // 0x000000018BEA7954-0x000000018BEA7994
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) {} // 0x000000018BEA79F8-0x000000018BEA7A34
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) {} // 0x000000018BEA7720-0x000000018BEA7754
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) {} // 0x000000018BEA7754-0x000000018BEA778C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7A34-0x000000018BEA7A80
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018503BAE0-0x000000018503BB30
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x000000018BEA7A80-0x000000018BEA7AC4
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018503BB30-0x000000018503BBB0
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) {} // 0x000000018BEAB194-0x000000018BEAB1C8
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) {} // 0x000000018484DB70-0x000000018484DBB0
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) {} // 0x000000018BEA7F70-0x000000018BEA7FAC
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) {} // 0x000000018BEA7C88-0x000000018BEA7CC0
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7C54-0x000000018BEA7C88
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7EE8-0x000000018BEA7F24
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7FAC-0x000000018BEA8030
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x000000018BEA7B98-0x000000018BEA7C18
		public void WriteDefaultValues() {} // 0x000000018BEA7DEC-0x000000018BEA7E64
		public void WriteDefaultValuesDirty() {} // 0x000000018BEA7E64-0x000000018BEA7EE8
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) {} // 0x000000018BEA7D4C-0x000000018BEA7DAC
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) {} // 0x000000018BEA7CC0-0x000000018BEA7D00
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) {} // 0x000000018BEA8030-0x000000018BEA806C
		public void CrossFade(string stateName, float normalizedTransitionDuration) {} // 0x000000018BEA7C18-0x000000018BEA7C54
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x000000018BEA7DAC-0x000000018BEA7DEC
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7F24-0x000000018BEA7F70
		public void CrossFade(string stateName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA7D00-0x000000018BEA7D4C
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA806C-0x000000018BEA80B8
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x0000000185F0AD00-0x0000000185F0AD40
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) {} // 0x000000018BEA9B64-0x000000018BEA9B84
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) {} // 0x000000018BEA9AEC-0x000000018BEA9B14
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) {} // 0x000000018BEA9B14-0x000000018BEA9B64
		public void CrossFade(int stateHashName, float normalizedTransitionDuration) {} // 0x000000018BEA9B84-0x000000018BEA9BE4
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA9ACC-0x000000018BEA9AEC
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA9BE4-0x000000018BEA9C0C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018BEA9C0C-0x000000018BEA9C2C
		public void ResetToDefaultStates() {} // 0x000000018496E2D0-0x000000018496E300
		public void PlayInFixedTime(string stateName, int layer) {} // 0x000000018496E850-0x000000018496E8A0
		public void PlayInFixedTime(string stateName) {} // 0x000000018496E8A0-0x000000018496E910
		public void PlayInFixedTime(string stateName, int layer, float fixedTime) {} // 0x000000018BEA9C2C-0x000000018BEA9C4C
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) {} // 0x000000018BEA9C4C-0x000000018BEA9C74
		public void PlayInFixedTime(int stateNameHash, int layer) {} // 0x000000018BEAAF58-0x000000018BEAAFA8
		public void PlayInFixedTime(int stateNameHash) {} // 0x000000018BEABD14-0x000000018BEABD40
		public void Play(string stateName, int layer) {} // 0x000000018BEABD84-0x000000018BEABDB0
		public void Play(string stateName) {} // 0x0000000185FAFEF0-0x0000000185FAFF00
		public void Play(string stateName, int layer, float normalizedTime) {} // 0x000000018BEA96EC-0x000000018BEA9730
		public void Play(int stateNameHash, int layer, float normalizedTime) {} // 0x000000018BEAB2C8-0x000000018BEAB2FC
		public void Play(int stateNameHash, int layer) {} // 0x000000018BEA8810-0x000000018BEA88D8
		public void Play(int stateNameHash) {} // 0x000000018BEA87D0-0x000000018BEA8810
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) {} // 0x0000000184EDE150-0x0000000184EDE170
		public bool IsControlled(Transform transform) => default; // 0x00000001845EDE00-0x00000001845EDE50
		internal bool IsBoneTransform(Transform transform) => default; // 0x000000018BEAAFFC-0x000000018BEAB030
		public Transform GetBoneTransform(HumanBodyBones humanBoneId) => default; // 0x000000018BEABA6C-0x000000018BEABAA0
		internal Transform GetBoneTransformInternal(int humanBoneId) => default; // 0x000000018BEAC2F0-0x000000018BEAC334
		public Transform GetBoneTransformByBoneId(int boneID) => default; // 0x000000018BEAB030-0x000000018BEAB070
		internal Transform GetBoneTransformByBoneIdInternal(int boneId) => default; // 0x000000018BEAB0A4-0x000000018BEAB0D8
		public void StartPlayback() {} // 0x000000018BEA92D0-0x000000018BEA9304
		public void StopPlayback() {} // 0x000000018BEABAE0-0x000000018BEABAEC
		public void StartRecording(int frameCount) {} // 0x000000018BEABAA0-0x000000018BEABAD4
		public void StopRecording() {} // 0x00000001844712F0-0x0000000184471330
		private float GetRecorderStartTime() => default; // 0x000000018BEA7518-0x000000018BEA754C
		private float GetRecorderStopTime() => default; // 0x000000018BEAB0D8-0x000000018BEAB10C
		internal void ClearInternalControllerPlayable() {} // 0x000000018BEAB858-0x000000018BEAB88C
		public bool HasState(int layerIndex, int stateID) => default; // 0x000000018BEAC1E0-0x000000018BEAC224
		public static int StringToHash(string name) => default; // 0x000000018BEAB824-0x000000018BEAB858
		public static int StringToHashCRC32(IntPtr name) => default; // 0x000000018BEAC1A0-0x000000018BEAC1E0
		internal string GetStats() => default; // 0x0000000184B23E30-0x0000000184B23F40
		private void GetCurrentGraph(ref PlayableGraph graph) {} // 0x00000001857B4420-0x00000001857B4490
		private void CheckIfInIKPass() {} // 0x0000000185A74450-0x0000000185A74500
		private bool IsInIKPass() => default; // 0x00000001854A26B0-0x00000001854A2710
		private void SetFloatString(string name, float value) {} // 0x000000018BEA88D8-0x000000018BEA891C
		private void SetFloatID(int id, float value) {} // 0x0000000185247400-0x0000000185247450
		private float GetFloatString(string name) => default; // 0x000000018BEAA920-0x000000018BEAA974
		private float GetFloatID(int id) => default; // 0x00000001859CAC50-0x00000001859CACB0
		private float GetFloatFromTransitionByID(int layerIndex, int id) => default; // 0x000000018BEA905C-0x000000018BEA90A0
		private float GetFloatFromTransitionByIDWithDefault(int layerIndex, int id, float defValue) => default; // 0x00000001851D1340-0x00000001851D1390
		private void SetBoolString(string name, bool value) {} // 0x000000018549A5D0-0x000000018549A620
		private void SetBoolID(int id, bool value) {} // 0x0000000185A932F0-0x0000000185A93340
		private bool GetBoolString(string name) => default; // 0x000000018521AED0-0x000000018521AF20
		private bool GetBoolID(int id) => default; // 0x0000000184C89C70-0x0000000184C89CC0
		private void SetIntegerString(string name, int value) {} // 0x000000018BEA97D8-0x000000018BEA981C
		private void SetIntegerID(int id, int value) {} // 0x000000018BEA9798-0x000000018BEA97D8
		private int GetIntegerString(string name) => default; // 0x000000018BEAA4C8-0x000000018BEAA52C
		private int GetIntegerID(int id) => default; // 0x000000018BEAA468-0x000000018BEAA4C8
		private void SetTriggerString(string name) {} // 0x000000018BEA8DC0-0x000000018BEA8DF4
		private void SetTriggerID(int id) {} // 0x000000018BEA7440-0x000000018BEA7474
		private void ResetTriggerString(string name) {} // 0x000000018BEAB260-0x000000018BEAB294
		private void ResetTriggerID(int id) {} // 0x000000018BEABE48-0x000000018BEABE8C
		private bool IsParameterControlledByCurveString(string name) => default; // 0x000000018BEA912C-0x000000018BEA9160
		private bool IsParameterControlledByCurveID(int id) => default; // 0x000000018BEA91B4-0x000000018BEA91D8
		private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) {} // 0x000000018BEA9160-0x000000018BEA91B4
		private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) {} // 0x000000018BEA95EC-0x000000018BEA963C
		public HGAnimParameterSGHandle[] GetHGParameterHandles() => default; // 0x000000018BEAAE30-0x000000018BEAAE88
		public bool CheckHGParmeterHandleValid() => default; // 0x000000018BEAAD34-0x000000018BEAAE30
		public int GetMorphBoneCount() => default; // 0x000000018BEAC118-0x000000018BEAC15C
		public void GetMorphBoneIds(NativeArray<int> arrayToFill) {} // 0x000000018BEAB7BC-0x000000018BEAB7F0
		public void GetMorphBoneIdsUnsafe(int count, NativeArray<int> arrayToFill) {} // 0x000000018BEABB20-0x000000018BEABB54
		private void Internal_GetMorphBoneIds(int count, IntPtr arrayToFill) {} // 0x000000018BEABC9C-0x000000018BEABCD0
		public void SetMorphTransforms(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale) {} // 0x000000018BEA9A98-0x000000018BEA9ACC
		public void SetMorphTransformsUnsafe(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale) {} // 0x000000018BEA9A64-0x000000018BEA9A98
		private void Internal_SetMorphTransforms(int count, IntPtr boneIds, IntPtr translation, IntPtr euler, IntPtr scale) {} // 0x000000018BEAB160-0x000000018BEAB194
		internal void OnUpdateModeChanged() {} // 0x000000018BEA81DC-0x000000018BEA81E8
		internal void OnCullingModeChanged() {} // 0x000000018BEA8198-0x000000018BEA81DC
		internal void WriteDefaultPose() {} // 0x000000018BEA8B18-0x000000018BEA8B28
		public void Update(float deltaTime) {} // 0x000000018BEA92A0-0x000000018BEA92B0
		public void ForceUpdate(float deltaTime) {} // 0x000000018BEA8374-0x000000018BEA83C8
		public void Rebind() {} // 0x000000018BEA9D2C-0x000000018BEA9D6C
		private void Rebind(bool writeDefaultValues) {} // 0x000000018BEA8368-0x000000018BEA8374
		public void ApplyBuiltinRootMotion() {} // 0x0000000186474660-0x0000000186474670
		internal void EvaluateController() {} // 0x00000001864727B8-0x00000001864727C8
		private void EvaluateController(float deltaTime) {} // 0x000000018646F000-0x000000018646F008
		internal string GetCurrentStateName(int layerIndex) => default; // 0x00000001864727B0-0x00000001864727B8
		internal string GetNextStateName(int layerIndex) => default; // 0x0000000186470D14-0x0000000186470D1C
		private string GetAnimatorStateName(int layerIndex, bool current) => default; // 0x000000018647421C-0x0000000186474224
		internal string ResolveHash(int hash) => default; // 0x0000000185EDB430-0x0000000185EDB4A0
		public string GetAnimatorStateName(int stateID) => default; // 0x0000000185EDB4A0-0x0000000185EDB510
		public void GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime = 0f /* Metadata: 0x0207F49E */, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x0207F4A2 */) {} // 0x0000000185BB7440-0x0000000185BB74A0
		public void GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x0207F4A3 */) {} // 0x0000000185EF5880-0x0000000185EF5920
		public void SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x0207F4A4 */) {} // 0x0000000185EF5830-0x0000000185EF5880
		public void RefreshStateOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x0000000185D2A530-0x0000000185D2A580
		public void SetRuntimeControllerNoRebind(RuntimeAnimatorController controller) {} // 0x0000000186473034-0x000000018647303C
		public void RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x00000001856D82E0-0x00000001856D8330
		internal void Internal_GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime, AnimationBlendStyle blendStyle) {} // 0x000000018BEAB88C-0x000000018BEAB8C0
		internal void Internal_GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle) {} // 0x000000018BEAC224-0x000000018BEAC268
		internal void Internal_SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x0207F4A5 */) {} // 0x000000018BEAB574-0x000000018BEAB5A8
		internal void Internal_RefreshAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x000000018BEAC088-0x000000018BEAC0CC
		internal void Internal_SetRuntimeControllerNoRebind(RuntimeAnimatorController controller) {} // 0x000000018BEAB714-0x000000018BEAB720
		internal void Internal_RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x000000018BEAC0CC-0x000000018BEAC0D4
		public void SetAvatarNoBind(Avatar avatar) {} // 0x000000018BEAB720-0x000000018BEAB754
		internal void Internal_SetAvatarNoBind(Avatar avatar) {} // 0x00000001856BDA70-0x00000001856BDAC0
		public Vector3 GetVector(string name) => default; // 0x00000001845320F0-0x0000000184532140
		public Vector3 GetVector(int id) => default; // 0x00000001845318D0-0x0000000184531920
		public void SetVector(string name, Vector3 value) {} // 0x0000000184531F30-0x0000000184531F80
		public void SetVector(int id, Vector3 value) {} // 0x0000000184531FE0-0x0000000184532030
		public Quaternion GetQuaternion(string name) => default; // 0x000000018BEABB54-0x000000018BEABB98
		public Quaternion GetQuaternion(int id) => default; // 0x000000018BEAC378-0x000000018BEAC3BC
		public void SetQuaternion(string name, Quaternion value) {} // 0x000000018BEABBC4-0x000000018BEABC08
		public void SetQuaternion(int id, Quaternion value) {} // 0x000000018BEAC3D0-0x000000018BEAC414
		private void get_deltaPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAB2FC-0x000000018BEAB340
		private void get_deltaRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BEABED0-0x000000018BEABF14
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAB3BC-0x000000018BEAB400
		private void get_angularVelocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEABF6C-0x000000018BEABFB0
		private void get_rootPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEA8C40-0x000000018BEA8C90
		private void set_rootPosition_Injected(ref Vector3 value) {} // 0x000000018BEAA554-0x000000018BEAA5A4
		private void get_rootRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BEA8CC0-0x000000018BEA8D10
		private void set_rootRotation_Injected(ref Quaternion value) {} // 0x000000018BEAA5B8-0x000000018BEAA608
		private void get_bodyPositionInternal_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEA8DF4-0x000000018BEA8E44
		private void set_bodyPositionInternal_Injected(ref Vector3 value) {} // 0x000000018BEAA6BC-0x000000018BEAA70C
		private void get_bodyRotationInternal_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAA9D0-0x000000018BEAAA14
		private void set_bodyRotationInternal_Injected(ref Quaternion value) {} // 0x000000018BEA9F44-0x000000018BEA9F94
		private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEA8700-0x000000018BEA8750
		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) {} // 0x000000018BEA8630-0x000000018BEA8680
		private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEA75E8-0x000000018BEA763C
		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) {} // 0x000000018BEA754C-0x000000018BEA75A0
		private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) {
			ret = default;
		} // 0x0000000184FC4CB0-0x0000000184FC4D10
		private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) {} // 0x000000018BEA7684-0x000000018BEA76D8
		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) {} // 0x000000018BEAB990-0x000000018BEAB9D4
		private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) {} // 0x000000018BEA9834-0x000000018BEA9898
		private void GetBoneRootTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret) {
			ret = default;
		} // 0x000000018BEABCD0-0x000000018BEABD14
		private void GetBoneLocalTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret) {
			ret = default;
		} // 0x000000018BEABD40-0x000000018BEABD84
		private void CreateClothBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x0000000185F1C9A0-0x0000000185F1CA20
		private void CreateClothBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x00000001836BE4A0-0x00000001836BE4F0
		private void CreateMorphBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x00000001854A2C40-0x00000001854A2CC0
		private void CreateMorphBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x000000018BEA72D8-0x000000018BEA7320
		private void get_pivotPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000184481BB0-0x0000000184481C30
		private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) {} // 0x000000018BEA2820-0x000000018BEA288C
		private void get_targetPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001882A83C4-0x00000001882A84E8
		private void get_targetRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public class AnimatorControllerParameter // TypeDefIndex: 58118
	{
		// Fields
		internal string m_Name; // 0x10
		internal AnimatorControllerParameterType m_Type; // 0x18
		internal float m_DefaultFloat; // 0x1C
		internal int m_DefaultInt; // 0x20
		internal bool m_DefaultBool; // 0x24
	
		// Properties
		public string name { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public int nameHash { get => default; } // 0x00000001864726F8-0x0000000186472708 
		public AnimatorControllerParameterType type { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
	
		// Constructors
		public AnimatorControllerParameter() {} // 0x000000018BEA5FE0-0x000000018BEA6020
	
		// Methods
		public override bool Equals(object o) => default; // 0x000000018BEA5F48-0x000000018BEA5FE0
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
	}

	[Serializable]
	public class AnimationClipPair // TypeDefIndex: 58119
	{
		// Fields
		public AnimationClip originalClip; // 0x10
		public AnimationClip overrideClip; // 0x18
	
		// Constructors
		public AnimationClipPair() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 58121
	{
		// Fields
		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18
	
		// Properties
		public RuntimeAnimatorController runtimeAnimatorController { get => default; set {} } // 0x000000018BEA6F44-0x000000018BEA6F54 0x000000018BEA7188-0x000000018BEA7190
		public AnimationClip this[string name] { get => default; set {} } // 0x000000018BEA6D20-0x000000018BEA6D74 0x000000018BEA6D74-0x000000018BEA6DC8
		public AnimationClip this[AnimationClip clip] { get => default; set {} } // 0x000000018BEA709C-0x000000018BEA70D0 0x000000018BEA720C-0x000000018BEA7250
		public bool enableBindingOpt { get => default; set {} } // 0x000000018BEA7104-0x000000018BEA7138 0x000000018BEA7250-0x000000018BEA7294
		public byte reserveCount { get => default; set {} } // 0x000000018BEA6A80-0x000000018BEA6AD4 0x000000018BEA6E5C-0x000000018BEA6EC0
		public int overridesCount { get => default; } // 0x000000018BEA6954-0x000000018BEA6A80 
		public AnimationClipPair[] clips { get => default; set {} } // 0x000000018BEA6DF4-0x000000018BEA6E28 0x000000018BEA6DC8-0x000000018BEA6DF4
	
		// Nested types
		internal delegate void OnOverrideControllerDirtyCallback(); // TypeDefIndex: 58120; 0x000000018BEA6EF4-0x000000018BEA6F34
	
		// Constructors
		public AnimatorOverrideController() {} // 0x000000018BEA6CDC-0x000000018BEA6D20
		public AnimatorOverrideController(RuntimeAnimatorController controller) {} // 0x000000018BEA7138-0x000000018BEA716C
	
		// Methods
		private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) {} // 0x000000018BEA7294-0x000000018BEA72D8
		private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) => default; // 0x000000018BEA6F34-0x000000018BEA6F44
		private void Internal_SetClipByName(string name, AnimationClip clip) {} // 0x000000018BEA716C-0x000000018BEA7188
		private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) => default; // 0x000000018BEA6E28-0x000000018BEA6E5C
		private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) {} // 0x000000018BEA6AD4-0x000000018BEA6B14
		private void SendNotification() {} // 0x000000018BEA6B14-0x000000018BEA6B58
		private AnimationClip GetOriginalClip(int index) => default; // 0x000000018BEA70D0-0x000000018BEA7104
		private AnimationClip GetOverrideClip(AnimationClip originalClip) => default; // 0x000000018BEA6B58-0x000000018BEA6CDC
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides) {} // 0x000000018BEA6F54-0x000000018BEA709C
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides) {} // 0x000000018BEA7190-0x000000018BEA720C
		internal void PerformOverrideClipListCleanup() {} // 0x00000001864BC330-0x00000001864BC3F4
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) {} // 0x00000001864BC320-0x00000001864BC330
	}

	public class AnimatorUtility // TypeDefIndex: 58122
	{
		// Constructors
		public AnimatorUtility() {} // Dummy constructor
	
		// Methods
		public static void OptimizeTransformHierarchy(GameObject go, string[] exposedTransforms) {} // 0x00000001856D8FF0-0x00000001856D9040
		public static void DeoptimizeTransformHierarchy(GameObject go) {} // 0x0000000185EBB900-0x0000000185EBB940
	}

	public enum HumanBodyBones // TypeDefIndex: 58123
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

	public struct AnimationTransformf // TypeDefIndex: 58124
	{
		// Fields
		public Vector3 t; // 0x00
		public Quaternion q; // 0x0C
		public Vector3 s; // 0x1C
	}

	public class Avatar : UnityEngine.Object // TypeDefIndex: 58125
	{
		// Properties
		public bool isValid { get => default; } // 0x0000000184267DA0-0x0000000184267DE0 
		public bool isHuman { get => default; } // 0x0000000184EDE0D0-0x0000000184EDE110 
		public HumanDescription humanDescription { get => default; } // 0x000000018BEACC24-0x000000018BEACC5C 
	
		// Constructors
		private Avatar() {} // 0x000000018BEACBA0-0x000000018BEACBE0
	
		// Methods
		internal void SetMuscleMinMax(int muscleId, float min, float max) {} // 0x000000018BEACAF0-0x000000018BEACB50
		internal void SetParameter(int parameterId, float value) {} // 0x000000018BEACB50-0x000000018BEACBA0
		internal float GetAxisLength(int humanId) => default; // 0x000000018BEAC5BC-0x000000018BEAC5E4
		internal Quaternion GetPreRotation(int humanId) => default; // 0x000000018BEAC6B4-0x000000018BEAC6FC
		internal Quaternion GetPostRotation(int humanId) => default; // 0x000000018BEAC66C-0x000000018BEAC6B4
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) => default; // 0x000000018BEAC6FC-0x000000018BEAC780
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw) => default; // 0x000000018BEAC780-0x000000018BEAC7F0
		internal Vector3 GetLimitSign(int humanId) => default; // 0x000000018BEAC618-0x000000018BEAC66C
		internal float Internal_GetAxisLength(int humanId) => default; // 0x000000018BEAC7F0-0x000000018BEAC830
		internal Quaternion Internal_GetPreRotation(int humanId) => default; // 0x000000018BEAC980-0x000000018BEAC9B0
		internal Quaternion Internal_GetPostRotation(int humanId) => default; // 0x000000018BEAC900-0x000000018BEAC930
		internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) => default; // 0x000000018BEACA10-0x000000018BEACA54
		internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) => default; // 0x000000018BEACAB4-0x000000018BEACAF0
		internal Vector3 Internal_GetLimitSign(int humanId) => default; // 0x000000018BEAC880-0x000000018BEAC8B0
		public string[] GetBonePaths() => default; // 0x000000018BEAC5E4-0x000000018BEAC618
		private void get_humanDescription_Injected(out HumanDescription ret) {
			ret = default;
		} // 0x000000018BEACBE0-0x000000018BEACC24
		private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAC930-0x000000018BEAC980
		private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAC8B0-0x000000018BEAC900
		private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAC9B0-0x000000018BEACA10
		private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEACA54-0x000000018BEACAB4
		private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAC830-0x000000018BEAC880
	}

	public struct SkeletonBone // TypeDefIndex: 58126
	{
		// Fields
		public string name; // 0x00
		internal string parentName; // 0x08
		public Vector3 position; // 0x10
		public Quaternion rotation; // 0x1C
		public Vector3 scale; // 0x2C
	}

	public struct HumanLimit // TypeDefIndex: 58127
	{
		// Fields
		private Vector3 m_Min; // 0x00
		private Vector3 m_Max; // 0x0C
		private Vector3 m_Center; // 0x18
		private float m_AxisLength; // 0x24
		private int m_UseDefaultValues; // 0x28
	}

	public struct HumanBone // TypeDefIndex: 58128
	{
		// Fields
		private string m_BoneName; // 0x00
		private string m_HumanName; // 0x08
		public HumanLimit limit; // 0x10
	}

	public struct HumanDescription // TypeDefIndex: 58129
	{
		// Fields
		public HumanBone[] human; // 0x00
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

	public enum AvatarMaskBodyPart // TypeDefIndex: 58130
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

	public sealed class AvatarMask : UnityEngine.Object // TypeDefIndex: 58131
	{
		// Properties
		public int transformCount { get => default; } // 0x000000018BEAC588-0x000000018BEAC5BC 
	
		// Constructors
		public AvatarMask() {} // Dummy constructor
	
		// Methods
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) => default; // 0x000000018BEAC4AC-0x000000018BEAC4EC
		public string GetTransformPath(int index) => default; // 0x000000018BEAC508-0x000000018BEAC548
		private float GetTransformWeight(int index) => default; // 0x000000018BEAC548-0x000000018BEAC588
		public bool GetTransformActive(int index) => default; // 0x000000018BEAC4EC-0x000000018BEAC508
	}

	public class HGAnimationSetBindings : UnityEngine.Object // TypeDefIndex: 58132
	{
		// Constructors
		public HGAnimationSetBindings() {} // Dummy constructor
	}

	[Serializable]
	public class HGCorrectiveBoneData : UnityEngine.Object // TypeDefIndex: 58133
	{
		// Constructors
		public HGCorrectiveBoneData() {} // 0x000000018BEACC90-0x000000018BEACCDC
	
		// Methods
		private static void Internal_Create(HGCorrectiveBoneData self) {} // 0x000000018BEACC5C-0x000000018BEACC90
	}

	public sealed class HGSkeletalMorphAvatar : UnityEngine.Object // TypeDefIndex: 58134
	{
		// Constructors
		private HGSkeletalMorphAvatar() {} // 0x000000018BEACD10-0x000000018BEACD5C
	
		// Methods
		private static void Internal_Create(HGSkeletalMorphAvatar self) {} // 0x000000018BEACCDC-0x000000018BEACD10
	}

	public struct HumanPose // TypeDefIndex: 58135
	{
		// Fields
		public Vector3 bodyPosition; // 0x00
		public Quaternion bodyRotation; // 0x0C
		public float[] muscles; // 0x20
	
		// Methods
		internal void Init() {} // 0x000000018BEAD138-0x000000018BEAD23C
	}

	public class HumanPoseHandler : IDisposable // TypeDefIndex: 58136
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public HumanPoseHandler() {} // Dummy constructor
		public HumanPoseHandler(Avatar avatar, Transform root) {} // 0x000000018BEACF2C-0x000000018BEAD138
	
		// Methods
		private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root) => default; // 0x000000018BEACEB4-0x000000018BEACEF8
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018BEACEF8-0x000000018BEACF2C
		private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, out float[] muscles) {
			bodyPosition = default;
			bodyRotation = default;
			muscles = default;
		} // 0x000000018BEACDB4-0x000000018BEACE18
		public void Dispose() {} // 0x000000018BEACD5C-0x000000018BEACDB4
		public void GetHumanPose(ref HumanPose humanPose) {} // 0x000000018BEACE18-0x000000018BEACEB4
	}

	public class HumanTrait // TypeDefIndex: 58137
	{
		// Properties
		public static int MuscleCount { get => default; } // 0x000000018BEAD270-0x000000018BEAD29C 
		public static string[] MuscleName { get => default; } // 0x000000018BEAD29C-0x000000018BEAD2C8 
	
		// Constructors
		public HumanTrait() {} // Dummy constructor
	
		// Methods
		internal static int GetBoneIndexFromMono(int humanId) => default; // 0x000000018BEAD23C-0x000000018BEAD270
	}

	public class LodBoneMask : UnityEngine.Object // TypeDefIndex: 58138
	{
		// Constructors
		public LodBoneMask() {} // 0x000000018BEAD2FC-0x000000018BEAD348
	
		// Methods
		private static void Internal_Create(LodBoneMask self) {} // 0x000000018BEAD2C8-0x000000018BEAD2FC
	}

	public class Motion : UnityEngine.Object // TypeDefIndex: 58139
	{
		// Fields
		private readonly bool _isAnimatorMotion_k__BackingField; // 0x18
	
		// Properties
		public bool isLooping { get => default; } // 0x0000000184D3FF10-0x0000000184D3FF50 
	
		// Constructors
		protected Motion() {} // 0x000000018530CCD0-0x000000018530CD10
	}

	public class RuntimeAnimatorController : UnityEngine.Object // TypeDefIndex: 58140
	{
		// Properties
		public AnimationClip[] animationClips { get => default; } // 0x0000000185F0ACC0-0x0000000185F0AD00 
	
		// Constructors
		protected RuntimeAnimatorController() {} // 0x000000018BEADB18-0x000000018BEADB58
	}

	public class RuntimeAnimatorStateOverride : UnityEngine.Object // TypeDefIndex: 58141
	{
		// Constructors
		public RuntimeAnimatorStateOverride() {} // 0x00000001844E8CD0-0x00000001844E8D20
	
		// Methods
		private static void Internal_Create(RuntimeAnimatorStateOverride self) {} // 0x00000001844E8D20-0x00000001844E8D60
		public void SetClip(int stateID, AnimationClip overrideClip) {} // 0x0000000186474224-0x000000018647422C
		public void SetClipAsync(int stateID, float length, bool isHumanoid) {} // 0x000000018647420C-0x000000018647421C
		public void RemoveClip(int stateID) {} // 0x000000018BEADBD8-0x000000018BEADBE0
		public void ClearClip() {} // 0x0000000186470D0C-0x0000000186470D14
		public bool PreloadClip(AnimationClip clipB) => default; // 0x0000000186473B18-0x0000000186473B24
		public void SetTransition(int transUserNameID, float transitionDuration, float transitionOffset, float exitTime) {} // 0x00000001864728A8-0x00000001864728B8
		public void RemoveTransition(int transUserNameID) {} // 0x000000018BEADBE0-0x000000018BEADBE8
		public void SetSyncGroupCurve(uint clipNameID, AnimationCurve curve) {} // 0x000000018646F008-0x000000018646F010
		internal void Internal_SetClip(uint stateID, AnimationClip overrideClip) {} // 0x0000000185A891C0-0x0000000185A89220
		internal void Internal_SetClipAsync(uint stateID, float length, bool isHumanoid) {} // 0x0000000185F5E500-0x0000000185F5E570
		internal void Internal_RemoveClip(uint stateID) {} // 0x000000018BEADB58-0x000000018BEADB98
		internal void Internal_ClearClip() {} // 0x0000000185F86830-0x0000000185F86870
		internal bool Internal_PreloadClip(AnimationClip clipB) => default; // 0x00000001859EBD90-0x00000001859EBDE0
		internal void Internal_SetTransition(uint transUserNameID, float transitionDuration, float transitionOffset, float exitTime) {} // 0x0000000185C09920-0x0000000185C09990
		internal void Internal_RemoveTransition(uint transUserNameID) {} // 0x000000018BEADB98-0x000000018BEADBD8
		internal void Internal_SetSyncGroupCurve(uint clipNameID, AnimationCurve curve) {} // 0x00000001853B1FC0-0x00000001853B2020
	}
}

namespace UnityEngine.Animations
{
	public static class AnimationPlayableBinding // TypeDefIndex: 58144
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key) => default; // 0x000000018BEA3E2C-0x000000018BEA3F48
		private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name) => default; // 0x000000018BEA3DEC-0x000000018BEA3E2C
	}

	public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 58145
	{
		// Constructors
		public DiscreteEvaluationAttribute() {} // Dummy constructor
	}

	public interface IAnimationJob // TypeDefIndex: 58146
	{
		// Methods
		void ProcessAnimation(AnimationStream stream);
		void ProcessRootMotion(AnimationStream stream);
	}

	public interface IAnimationWindowPreview // TypeDefIndex: 58147
	{
	}

	public class NotKeyableAttribute : Attribute // TypeDefIndex: 58148
	{
		// Constructors
		public NotKeyableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal enum JobMethodIndex // TypeDefIndex: 58149
	{
		ProcessRootMotionMethodIndex = 0,
		ProcessAnimationMethodIndex = 1,
		MethodIndexCount = 2
	}

	internal struct ProcessAnimationJobStruct<T> // TypeDefIndex: 58151
		where T : struct, IAnimationJob
	{
		// Fields
		private static IntPtr jobReflectionData;
	
		// Nested types
		public delegate void ExecuteJobFunction(ref ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58150; 0x00000000-0x00000000
	
		// Methods
		public static IntPtr GetJobReflectionData() => default;
		public static void Execute(ref ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex) {}
	}

	public struct AdvancedAnimationMixerPlayable : IPlayable, IEquatable<AdvancedAnimationMixerPlayable> // TypeDefIndex: 58152
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AdvancedAnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AdvancedAnimationMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000185298860-0x0000000185298900
		static AdvancedAnimationMixerPlayable() {
			m_NullPlayable = default;
		} // 0x00000001852984F0-0x0000000185298580
	
		// Methods
		public static AdvancedAnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F1 */) => default; // 0x0000000185298580-0x0000000185298630
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F2 */) => default; // 0x0000000185298630-0x00000001852987B0
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(AdvancedAnimationMixerPlayable other) => default; // 0x000000018BEA1D30-0x000000018BEA1DBC
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x00000001852987B0-0x0000000185298810
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000185298810-0x0000000185298860
	}

	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 58153
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AnimationClipPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x00000001845F0190-0x00000001845F0230
	
		// Methods
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) => default; // 0x00000001845EFED0-0x00000001845F0000
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) => default; // 0x00000001845F0000-0x00000001845F0120
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationClipPlayable playable) => default; // 0x0000000185FE6690-0x0000000185FE66A0
		public static explicit operator AnimationClipPlayable(Playable playable) => default; // 0x000000018BEA1FEC-0x000000018BEA2064
		public bool Equals(AnimationClipPlayable other) => default; // 0x000000018BEA1DBC-0x000000018BEA1E30
		public AnimationClip GetAnimationClip() => default; // 0x000000018646F268-0x000000018646F274
		public float GetAnimationClipPlayableLengthUncheck() => default; // 0x000000018BEA1E64-0x000000018BEA1E70
		public void SetAnimationClip(AnimationClip clip) {} // 0x00000001864726F0-0x00000001864726F8
		public void SetAnimationClipAsync(float length, bool isHumanoid) {} // 0x0000000186471068-0x0000000186471070
		public void SetApplyFootIK(bool value) {} // 0x000000018BEA1EB4-0x000000018BEA1EBC
		public void SetApplyPlayableIK(bool value) {} // 0x000000018BEA1F00-0x000000018BEA1F08
		internal void SetRemoveStartOffset(bool value) {} // 0x000000018BEA1FE4-0x000000018BEA1FEC
		internal void SetOverrideLoopTime(bool value) {} // 0x000000018BEA1F98-0x000000018BEA1FA0
		internal void SetLoopTime(bool value) {} // 0x000000018BEA1F4C-0x000000018BEA1F54
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) => default; // 0x000000018646F6C4-0x000000018646F6D8
		private static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle) => default; // 0x0000000184E94AE0-0x0000000184E94B20
		private static void SetAnimationClipInternal(ref PlayableHandle handle, AnimationClip clip) {} // 0x00000001857A9AC0-0x00000001857A9B10
		private static void SetAnimationClipAsyncInternal(ref PlayableHandle handle, float length, bool isHumanoid) {} // 0x0000000185EB8720-0x0000000185EB8780
		private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA1E70-0x000000018BEA1EB4
		private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA1EBC-0x000000018BEA1F00
		private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA1FA0-0x000000018BEA1FE4
		private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA1F54-0x000000018BEA1F98
		private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA1F08-0x000000018BEA1F4C
		private static float GetAnimationClipPlayableLengthInternalUncheck(ref PlayableHandle handle) => default; // 0x000000018BEA1E30-0x000000018BEA1E64
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) => default; // 0x000000018529FCD0-0x000000018529FD30
	}

	public struct AnimationHumanStream // TypeDefIndex: 58154
	{
		// Fields
		private IntPtr stream; // 0x00
	}

	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 58155
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x00
	
		// Properties
		public static AnimationLayerMixerPlayable Null { get => default; } // 0x000000018BEA3164-0x000000018BEA31BC 
	
		// Constructors
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true /* Metadata: 0x0207F4F5 */) : this() {
			m_Handle = default;
		} // 0x0000000184D40FB0-0x0000000184D410B0
		static AnimationLayerMixerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000184D41100-0x0000000184D41190
	
		// Methods
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F3 */) => default; // 0x0000000184D40C10-0x0000000184D40CB0
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) => default; // 0x0000000184D40CB0-0x0000000184D40D80
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F4 */) => default; // 0x0000000184D40D80-0x0000000184D40F00
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationLayerMixerPlayable playable) => default; // 0x000000018BEA3238-0x000000018BEA328C
		public static explicit operator AnimationLayerMixerPlayable(Playable playable) => default; // 0x000000018BEA31BC-0x000000018BEA3238
		public bool Equals(AnimationLayerMixerPlayable other) => default; // 0x000000018BEA298C-0x000000018BEA2A18
		public void SetLayerAdditive(uint layerIndex, bool value) {} // 0x000000018BEA2A6C-0x000000018BEA2BCC
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) {} // 0x000000018BEA2DD0-0x000000018BEA2FB0
		public void SetLayerRootMotionDisable(uint layerIndex, bool value) {} // 0x000000018BEA3004-0x000000018BEA3164
		public void SetLayerEnableFloatCurve(uint layerIndex, bool value) {} // 0x000000018BEA2C20-0x000000018BEA2D80
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000184D40F00-0x0000000184D40F60
		private static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x000000018BEA2A18-0x000000018BEA2A6C
		private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) {} // 0x0000000184D410B0-0x0000000184D41100
		private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) {} // 0x000000018BEA2D80-0x000000018BEA2DD0
		private static void SetLayerRootMotionDisableInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x000000018BEA2FB0-0x000000018BEA3004
		private static void SetLayerEnableFloatCurveInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x000000018BEA2BCC-0x000000018BEA2C20
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000184D40F60-0x0000000184D40FB0
	}

	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 58156
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x00000001845EF000-0x00000001845EF0A0
		static AnimationMixerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000185F41020-0x0000000185F410B0
	
		// Methods
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights) => default; // 0x000000018BEA328C-0x000000018BEA330C
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F6 */) => default; // 0x00000001845EED60-0x00000001845EEE10
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0207F4F7 */) => default; // 0x00000001845EEE10-0x00000001845EF000
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationMixerPlayable playable) => default; // 0x000000018BEA3398-0x000000018BEA33EC
		public bool Equals(AnimationMixerPlayable other) => default; // 0x000000018BEA330C-0x000000018BEA3398
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x00000001845EECB0-0x00000001845EED10
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x00000001845EED10-0x00000001845EED60
	}

	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 58157
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x00
	
		// Constructors
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA37AC-0x000000018BEA3884
		static AnimationMotionXToDeltaPlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA3728-0x000000018BEA37AC
	
		// Methods
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) => default; // 0x000000018BEA3568-0x000000018BEA35FC
		private static PlayableHandle CreateHandle(PlayableGraph graph) => default; // 0x000000018BEA348C-0x000000018BEA3568
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable) => default; // 0x000000018BEA3884-0x000000018BEA38D8
		public bool Equals(AnimationMotionXToDeltaPlayable other) => default; // 0x000000018BEA35FC-0x000000018BEA3688
		public void SetAbsoluteMotion(bool value) {} // 0x000000018BEA36CC-0x000000018BEA3728
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x000000018BEA3430-0x000000018BEA348C
		private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) {} // 0x000000018BEA3688-0x000000018BEA36CC
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x000000018BEA33EC-0x000000018BEA3430
	}

	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 58158
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationOffsetPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA3CC0-0x000000018BEA3D98
		static AnimationOffsetPlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA3C3C-0x000000018BEA3CC0
	
		// Methods
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) => default; // 0x000000018BEA3ACC-0x000000018BEA3BA8
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) => default; // 0x000000018BEA39B0-0x000000018BEA3ACC
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationOffsetPlayable playable) => default; // 0x000000018BEA3D98-0x000000018BEA3DEC
		public bool Equals(AnimationOffsetPlayable other) => default; // 0x000000018BEA3BA8-0x000000018BEA3C3C
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) => default; // 0x000000018BEA393C-0x000000018BEA39B0
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) => default; // 0x000000018BEA38D8-0x000000018BEA393C
	}

	public static class AnimationPlayableExtensions // TypeDefIndex: 58159
	{
		// Methods
		public static void SetAnimatedProperties<U>(U playable, AnimationClip clip)
			where U : struct, IPlayable {}
		internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) {} // 0x000000018BEA3F48-0x000000018BEA3F8C
	}

	internal static class AnimationPlayableGraphExtensions // TypeDefIndex: 58160
	{
		// Methods
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x0000000184D40730-0x0000000184D40790
	}

	public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 58161
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AnimationPlayableOutput Null { get => default; } // 0x000000018BEA4104-0x000000018BEA417C 
	
		// Constructors
		internal AnimationPlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x0000000184D40790-0x0000000184D40830
	
		// Methods
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) => default; // 0x0000000184D40670-0x0000000184D40730
		public PlayableOutputHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator PlayableOutput(AnimationPlayableOutput output) => default; // 0x0000000185FE6690-0x0000000185FE66A0
		public static explicit operator AnimationPlayableOutput(PlayableOutput output) => default; // 0x000000018BEA417C-0x000000018BEA41F4
		public Animator GetTarget() => default; // 0x000000018BEA4078-0x000000018BEA4084
		public void SetTarget(Animator value) {} // 0x0000000186472640-0x0000000186472648
		public void SetNeedRebindOnChanged(bool value) {} // 0x000000018BEA40FC-0x000000018BEA4104
		private static Animator InternalGetTarget(ref PlayableOutputHandle handle) => default; // 0x000000018BEA4084-0x000000018BEA40B8
		private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) {} // 0x000000018558DC70-0x000000018558DCC0
		private static void InternalSetNeedRebindOnChanged(ref PlayableOutputHandle handle, bool value) {} // 0x000000018BEA40B8-0x000000018BEA40FC
	}

	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable> // TypeDefIndex: 58162
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationPosePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationPosePlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA430C-0x000000018BEA43E4
		static AnimationPosePlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA4288-0x000000018BEA430C
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(AnimationPosePlayable other) => default; // 0x000000018BEA41F4-0x000000018BEA4288
	}

	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 58163
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationRemoveScalePlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA4728-0x000000018BEA4800
		static AnimationRemoveScalePlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA46A4-0x000000018BEA4728
	
		// Methods
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) => default; // 0x000000018BEA456C-0x000000018BEA4610
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) => default; // 0x000000018BEA4484-0x000000018BEA456C
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AnimationRemoveScalePlayable playable) => default; // 0x000000018BEA4800-0x000000018BEA4854
		public bool Equals(AnimationRemoveScalePlayable other) => default; // 0x000000018BEA4610-0x000000018BEA46A4
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x000000018BEA4428-0x000000018BEA4484
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x000000018BEA43E4-0x000000018BEA4428
	}

	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 58164
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationScriptPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationScriptPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA4D1C-0x000000018BEA4DF4
		static AnimationScriptPlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA4C98-0x000000018BEA4D1C
	
		// Methods
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0 /* Metadata: 0x0207F4F8 */)
			where T : struct, IAnimationJob => default;
		private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount)
			where T : struct, IAnimationJob => default;
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		private void CheckJobTypeValidity<T>() {}
		public void SetJobData<T>(T jobData)
			where T : struct, IAnimationJob {}
		public static implicit operator Playable(AnimationScriptPlayable playable) => default; // 0x000000018BEA4DF4-0x000000018BEA4E48
		public bool Equals(AnimationScriptPlayable other) => default; // 0x000000018BEA4A14-0x000000018BEA4AA0
		public void SetForceWriteRootMotionParam(bool value) {} // 0x000000018BEA4C3C-0x000000018BEA4C98
		public void SetForceResetParam(bool value) {} // 0x000000018BEA4B40-0x000000018BEA4B9C
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) => default; // 0x000000018BEA49B0-0x000000018BEA4A14
		private static void SetForceWriteRootMotionParamInternal(PlayableHandle handle, bool value) {} // 0x000000018BEA4BE0-0x000000018BEA4C3C
		private static void SetForceResetParamInternal(PlayableHandle handle, bool value) {} // 0x000000018BEA4AE4-0x000000018BEA4B40
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) => default; // 0x000000018BEA495C-0x000000018BEA49B0
		private static void SetForceWriteRootMotionParamInternal_Injected(ref PlayableHandle handle, bool value) {} // 0x000000018BEA4B9C-0x000000018BEA4BE0
		private static void SetForceResetParamInternal_Injected(ref PlayableHandle handle, bool value) {} // 0x000000018BEA4AA0-0x000000018BEA4AE4
	}

	public struct AnimationStream // TypeDefIndex: 58165
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
		internal uint animatorBindingsVersion { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public bool isValid { get => default; } // 0x000000018BEA55D8-0x000000018BEA5600 
		public float deltaTime { get => default; } // 0x000000018BEA55B8-0x000000018BEA55D8 
	
		// Methods
		internal void CheckIsValid() {} // 0x000000018BEA5510-0x000000018BEA557C
		private float GetDeltaTime() => default; // 0x000000018BEA55B0-0x000000018BEA55B8
		private static float GetDeltaTime_Injected(ref AnimationStream _unity_self) => default; // 0x000000018BEA557C-0x000000018BEA55B0
	}

	public struct TransformStreamHandle // TypeDefIndex: 58166
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int skeletonIndex; // 0x08
	
		// Properties
		private bool createdByNative { get => default; } // 0x000000018BEADAEC-0x000000018BEADAF8 
		private bool hasHandleIndex { get => default; } // 0x000000018BEADB00-0x000000018BEADB0C 
		private bool hasSkeletonIndex { get => default; } // 0x000000018BEADB0C-0x000000018BEADB18 
		internal uint animatorBindingsVersion { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x000000018BEAEB5C-0x000000018BEAEB70
		private bool IsValidInternal(ref AnimationStream stream) => default; // 0x000000018BEAEB2C-0x000000018BEAEB5C
		private bool IsSameVersionAsStream(ref AnimationStream stream) => default; // 0x000000018BEAD750-0x000000018BEAD75C
		public void Resolve(AnimationStream stream) {} // 0x000000018BEAEBBC-0x000000018BEAEBD0
		public bool IsResolved(AnimationStream stream) => default; // 0x000000018BEAEB18-0x000000018BEAEB2C
		private bool IsResolvedInternal(ref AnimationStream stream) => default; // 0x000000018BEAEADC-0x000000018BEAEB18
		private void CheckIsValidAndResolve(ref AnimationStream stream) {} // 0x000000018BEAE38C-0x000000018BEAE4B4
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x000000018BEAE998-0x000000018BEAE9FC
		public void SetPosition(AnimationStream stream, Vector3 position) {} // 0x000000018BEAF09C-0x000000018BEAF0F0
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x000000018BEAEA80-0x000000018BEAEADC
		public void SetRotation(AnimationStream stream, Quaternion rotation) {} // 0x000000018BEAF158-0x000000018BEAF1A4
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x000000018BEAE608-0x000000018BEAE66C
		public void SetLocalPosition(AnimationStream stream, Vector3 position) {} // 0x000000018BEAED3C-0x000000018BEAED90
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x000000018BEAE6F0-0x000000018BEAE74C
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation) {} // 0x000000018BEAEDF8-0x000000018BEAEE44
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x000000018BEAE7D4-0x000000018BEAE838
		public void SetLocalScale(AnimationStream stream, Vector3 scale) {} // 0x000000018BEAEEAC-0x000000018BEAEF00
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE8AC-0x000000018BEAE910
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) {} // 0x000000018BEAEF90-0x000000018BEAF034
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEAE528-0x000000018BEAE580
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) {} // 0x000000018BEAEC54-0x000000018BEAECD4
		private void ResolveInternal(ref AnimationStream stream) {} // 0x000000018BEAEBB4-0x000000018BEAEBBC
		private Vector3 GetPositionInternal(ref AnimationStream stream) => default; // 0x000000018BEAE964-0x000000018BEAE998
		private void SetPositionInternal(ref AnimationStream stream, Vector3 position) {} // 0x000000018BEAF088-0x000000018BEAF09C
		private Quaternion GetRotationInternal(ref AnimationStream stream) => default; // 0x000000018BEAEA50-0x000000018BEAEA80
		private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation) {} // 0x000000018BEAF144-0x000000018BEAF158
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream) => default; // 0x000000018BEAE5D4-0x000000018BEAE608
		private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position) {} // 0x000000018BEAED28-0x000000018BEAED3C
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream) => default; // 0x000000018BEAE6C0-0x000000018BEAE6F0
		private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation) {} // 0x000000018BEAEDE4-0x000000018BEAEDF8
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream) => default; // 0x000000018BEAE7A0-0x000000018BEAE7D4
		private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale) {} // 0x000000018BEAEE98-0x000000018BEAEEAC
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE89C-0x000000018BEAE8AC
		private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) {} // 0x000000018BEAEF64-0x000000018BEAEF90
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEAE518-0x000000018BEAE528
		private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) {} // 0x000000018BEAEC34-0x000000018BEAEC54
		private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream) {} // 0x000000018BEAEB70-0x000000018BEAEBB4
		private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAE910-0x000000018BEAE964
		private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) {} // 0x000000018BEAF034-0x000000018BEAF088
		private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAE9FC-0x000000018BEAEA50
		private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) {} // 0x000000018BEAF0F0-0x000000018BEAF144
		private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAE580-0x000000018BEAE5D4
		private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) {} // 0x000000018BEAECD4-0x000000018BEAED28
		private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAE66C-0x000000018BEAE6C0
		private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) {} // 0x000000018BEAED90-0x000000018BEAEDE4
		private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAE74C-0x000000018BEAE7A0
		private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 scale) {} // 0x000000018BEAEE44-0x000000018BEAEE98
		private static void GetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE838-0x000000018BEAE89C
		private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, bool useMask) {} // 0x000000018BEAEF00-0x000000018BEAEF64
		private static void GetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEAE4B4-0x000000018BEAE518
		private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, bool useMask) {} // 0x000000018BEAEBD0-0x000000018BEAEC34
	}

	public struct PropertyStreamHandle // TypeDefIndex: 58167
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int valueArrayIndex; // 0x08
		private int bindType; // 0x0C
	
		// Properties
		private bool createdByNative { get => default; } // 0x000000018BEADAEC-0x000000018BEADAF8 
		private bool hasHandleIndex { get => default; } // 0x000000018BEADB00-0x000000018BEADB0C 
		private bool hasValueArrayIndex { get => default; } // 0x000000018BEADB0C-0x000000018BEADB18 
		private bool hasBindType { get => default; } // 0x000000018BEADAF8-0x000000018BEADB00 
		internal uint animatorBindingsVersion { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x000000018BEAD790-0x000000018BEAD7A4
		private bool IsValidInternal(ref AnimationStream stream) => default; // 0x000000018BEAD75C-0x000000018BEAD790
		private bool IsSameVersionAsStream(ref AnimationStream stream) => default; // 0x000000018BEAD750-0x000000018BEAD75C
		private bool IsResolvedInternal(ref AnimationStream stream) => default; // 0x000000018BEAD714-0x000000018BEAD750
		private void CheckIsValidAndResolve(ref AnimationStream stream) {} // 0x000000018BEAD348-0x000000018BEAD478
		public float GetFloat(AnimationStream stream) => default; // 0x000000018BEAD5A4-0x000000018BEAD630
		public void SetFloat(AnimationStream stream, float value) {} // 0x000000018BEAD94C-0x000000018BEAD9E8
		public int GetInt(AnimationStream stream) => default; // 0x000000018BEAD67C-0x000000018BEAD714
		public void SetInt(AnimationStream stream, int value) {} // 0x000000018BEADA44-0x000000018BEADAEC
		public bool GetBool(AnimationStream stream) => default; // 0x000000018BEAD4C4-0x000000018BEAD558
		public void SetBool(AnimationStream stream, bool value) {} // 0x000000018BEAD84C-0x000000018BEAD8F0
		private void ResolveInternal(ref AnimationStream stream) {} // 0x000000018BEAD7E8-0x000000018BEAD7F0
		private float GetFloatInternal(ref AnimationStream stream) => default; // 0x000000018BEAD59C-0x000000018BEAD5A4
		private void SetFloatInternal(ref AnimationStream stream, float value) {} // 0x000000018BEAD944-0x000000018BEAD94C
		private int GetIntInternal(ref AnimationStream stream) => default; // 0x000000018BEAD674-0x000000018BEAD67C
		private void SetIntInternal(ref AnimationStream stream, int value) {} // 0x000000018BEADA3C-0x000000018BEADA44
		private bool GetBoolInternal(ref AnimationStream stream) => default; // 0x000000018BEAD4BC-0x000000018BEAD4C4
		private void SetBoolInternal(ref AnimationStream stream, bool value) {} // 0x000000018BEAD844-0x000000018BEAD84C
		private static void ResolveInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) {} // 0x000000018BEAD7A4-0x000000018BEAD7E8
		private static float GetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x000000018BEAD558-0x000000018BEAD59C
		private static void SetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, float value) {} // 0x000000018BEAD8F0-0x000000018BEAD944
		private static int GetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x000000018BEAD630-0x000000018BEAD674
		private static void SetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, int value) {} // 0x000000018BEAD9E8-0x000000018BEADA3C
		private static bool GetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x000000018BEAD478-0x000000018BEAD4BC
		private static void SetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, bool value) {} // 0x000000018BEAD7F0-0x000000018BEAD844
	}

	public struct TransformSceneHandle // TypeDefIndex: 58168
	{
		// Fields
		private uint valid; // 0x00
		private int transformSceneHandleDefinitionIndex; // 0x04
	
		// Properties
		private bool createdByNative { get => default; } // 0x000000018646D60C-0x000000018646D614 
		private bool hasTransformSceneHandleDefinitionIndex { get => default; } // 0x000000018BEADB00-0x000000018BEADB0C 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x000000018BEAE344-0x000000018BEAE38C
		private void CheckIsValid(ref AnimationStream stream) {} // 0x000000018BEADBE8-0x000000018BEADCD0
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x000000018BEAE1B4-0x000000018BEAE218
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x000000018BEADE24-0x000000018BEADE88
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x000000018BEAE29C-0x000000018BEAE2F8
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x000000018BEADF0C-0x000000018BEADF68
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x000000018BEADFF0-0x000000018BEAE054
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE0C8-0x000000018BEAE12C
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEADD44-0x000000018BEADD9C
		private bool HasValidTransform(ref AnimationStream stream) => default; // 0x000000018BEAE33C-0x000000018BEAE344
		private Vector3 GetPositionInternal(ref AnimationStream stream) => default; // 0x000000018BEAE180-0x000000018BEAE1B4
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream) => default; // 0x000000018BEADDF0-0x000000018BEADE24
		private Quaternion GetRotationInternal(ref AnimationStream stream) => default; // 0x000000018BEAE26C-0x000000018BEAE29C
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream) => default; // 0x000000018BEADEDC-0x000000018BEADF0C
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream) => default; // 0x000000018BEADFBC-0x000000018BEADFF0
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE0B8-0x000000018BEAE0C8
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEADD34-0x000000018BEADD44
		private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream) => default; // 0x000000018BEAE2F8-0x000000018BEAE33C
		private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEAE12C-0x000000018BEAE180
		private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEADD9C-0x000000018BEADDF0
		private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEAE218-0x000000018BEAE26C
		private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEADE88-0x000000018BEADEDC
		private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEADF68-0x000000018BEADFBC
		private static void GetLocalTRSInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BEAE054-0x000000018BEAE0B8
		private static void GetGlobalTRInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEADCD0-0x000000018BEADD34
	}

	public struct PropertySceneHandle // TypeDefIndex: 58169
	{
		// Fields
		private uint valid; // 0x00
		private int handleIndex; // 0x04
	}

	public static class AnimationSceneHandleUtility // TypeDefIndex: 58170
	{
		// Methods
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer) {} // 0x000000018BEA4854-0x000000018BEA48F8
		internal static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer)
			where T0 : struct
			where T1 : struct => default;
		private static unsafe void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count) {} // 0x000000018BEA48F8-0x000000018BEA495C
	}

	public static class AnimationStreamHandleUtility // TypeDefIndex: 58171
	{
		// Methods
		public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer, bool useMask) {} // 0x000000018BEA53F4-0x000000018BEA54AC
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer) {} // 0x000000018BEA52E8-0x000000018BEA5390
		private static unsafe void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count) {} // 0x000000018BEA5390-0x000000018BEA53F4
		private static unsafe void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask) {} // 0x000000018BEA54AC-0x000000018BEA5510
	}

	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 58172
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimatorControllerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEA6540-0x000000018BEA65C8
		static AnimatorControllerPlayable() {
			m_NullPlayable = default;
		} // 0x000000018BEA64BC-0x000000018BEA6540
	
		// Methods
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller) => default; // 0x000000018BEA61B0-0x000000018BEA6254
		private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller) => default; // 0x000000018BEA60D8-0x000000018BEA61B0
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public void SetHandle(PlayableHandle handle) {} // 0x000000018BEA6378-0x000000018BEA64BC
		public bool Equals(AnimatorControllerPlayable other) => default; // 0x000000018BEA6254-0x000000018BEA62E0
		public bool IsInTransition(int layerIndex) => default; // 0x000000018BEA6320-0x000000018BEA6378
		private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) => default; // 0x000000018BEA6074-0x000000018BEA60D8
		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex) => default; // 0x000000018BEA62E0-0x000000018BEA6320
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) => default; // 0x000000018BEA6020-0x000000018BEA6074
	}

	public enum CustomStreamPropertyType // TypeDefIndex: 58173
	{
		Float = 5,
		Bool = 6,
		Int = 10
	}

	public static class AnimatorJobExtensions // TypeDefIndex: 58174
	{
		// Methods
		public static TransformStreamHandle BindStreamTransform(Animator animator, Transform transform) => default; // 0x000000018BEA6730-0x000000018BEA6780
		public static PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, System.Type type, string property) => default; // 0x000000018BEA66EC-0x000000018BEA6730
		public static PropertyStreamHandle BindCustomStreamProperty(Animator animator, string property, CustomStreamPropertyType type) => default; // 0x000000018BEA65C8-0x000000018BEA6610
		public static PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, System.Type type, string property, bool isObjectReference) => default; // 0x000000018BEA6684-0x000000018BEA66EC
		public static TransformSceneHandle BindSceneTransform(Animator animator, Transform transform) => default; // 0x000000018BEA6660-0x000000018BEA6684
		public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, System.Type type, string property) => default; // 0x000000018BEA6644-0x000000018BEA6660
		public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, System.Type type, string property, bool isObjectReference) => default; // 0x000000018BEA6610-0x000000018BEA6644
		private static void InternalBindStreamTransform(Animator animator, Transform transform, out TransformStreamHandle transformStreamHandle) {
			transformStreamHandle = default;
		} // 0x000000018BEA6900-0x000000018BEA6954
		private static void InternalBindStreamProperty(Animator animator, Transform transform, System.Type type, string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle) {
			propertyStreamHandle = default;
		} // 0x000000018BEA689C-0x000000018BEA6900
		private static void InternalBindCustomStreamProperty(Animator animator, string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle) {
			propertyStreamHandle = default;
		} // 0x000000018BEA6780-0x000000018BEA67E4
		private static void InternalBindSceneTransform(Animator animator, Transform transform, out TransformSceneHandle transformSceneHandle) {
			transformSceneHandle = default;
		} // 0x000000018BEA6848-0x000000018BEA689C
		private static void InternalBindSceneProperty(Animator animator, Transform transform, System.Type type, string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle) {
			propertySceneHandle = default;
		} // 0x000000018BEA67E4-0x000000018BEA6848
	}

	public enum Axis // TypeDefIndex: 58175
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4
	}
}

namespace UnityEngine.Experimental.Animations
{
	public enum AnimationStreamSource // TypeDefIndex: 58142
	{
		DefaultValues = 0,
		PreviousInputs = 1
	}

	public static class AnimationPlayableOutputExtensions // TypeDefIndex: 58143
	{
		// Methods
		public static void SetAnimationStreamSource(AnimationPlayableOutput output, AnimationStreamSource streamSource) {} // 0x000000018BEA4034-0x000000018BEA4054
		public static void SetSortingOrder(AnimationPlayableOutput output, ushort sortingOrder) {} // 0x000000018BEA4054-0x000000018BEA4078
		private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource) {} // 0x000000018BEA3FCC-0x000000018BEA3FE0
		private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder) {} // 0x000000018BEA4020-0x000000018BEA4034
		private static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource) {} // 0x000000018BEA3F8C-0x000000018BEA3FCC
		private static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder) {} // 0x000000018BEA3FE0-0x000000018BEA4020
	}
}
