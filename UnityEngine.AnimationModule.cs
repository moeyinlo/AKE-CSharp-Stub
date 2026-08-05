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

// Image 52: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60536-60641
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
[assembly: InternalsVisibleTo("Unity.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommon")]
[assembly: InternalsVisibleTo("UnityEngine.Advertisements")]
[assembly: InternalsVisibleTo("UnityEngine.Purchasing")]
[assembly: InternalsVisibleTo("UnityEngine.TestRunner")]
[assembly: InternalsVisibleTo("Unity.Automation")]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.DeploymentTests.Services")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.UnityAnalytics")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Timeline")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Framework")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework")]
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60537
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60538
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine
{
	public interface IAnimationClipSource // TypeDefIndex: 60539
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[RequiredByNativeCode]
	public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 60540
	{
		// Constructors
		public SharedBetweenAnimatorsAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 60541
	{
		// Constructors
		protected StateMachineBehaviour(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum PlayMode // TypeDefIndex: 60542
	{
		StopSameLayer = 0,
		StopAll = 4
	}

	public enum QueueMode // TypeDefIndex: 60543
	{
		CompleteOthers = 0,
		PlayNow = 2
	}

	public enum AnimationBlendMode // TypeDefIndex: 60544
	{
		Blend = 0,
		Additive = 1
	}

	public enum AnimationPlayMode // TypeDefIndex: 60545
	{
		Stop = 0,
		Queue = 1,
		Mix = 2
	}

	public enum AnimationCullingType // TypeDefIndex: 60546
	{
		AlwaysAnimate = 0,
		BasedOnRenderers = 1,
		BasedOnClipBounds = 2,
		BasedOnUserBounds = 3
	}

	internal enum AnimationEventSource // TypeDefIndex: 60547
	{
		NoSource = 0,
		Legacy = 1,
		Animator = 2
	}

	public enum AnimEventHashCodeType // TypeDefIndex: 60548
	{
		None = 0,
		CRC32 = 1,
		HashCode64 = 2
	}

	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : UnityEngine.Behaviour, IEnumerable // TypeDefIndex: 60550
	{
		// Properties
		public AnimationClip clip { get; set; } // 0x000000018B3982AC-0x000000018B3982E0 0x000000018B3984AC-0x000000018B3984F0
		public bool playAutomatically { get; set; } // 0x000000018B3983BC-0x000000018B3983F0 0x00000001832E9F60-0x00000001832E9FB0
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x000000018B3983F0-0x000000018B398424 0x000000018B398588-0x000000018B3985C8
		public bool isPlaying { [NativeName("IsPlaying")] get; } // 0x000000018B398314-0x000000018B398348 
		public UnityEngine.AnimationState this[string name] { get => default; } // 0x000000018B398238-0x000000018B398244 
		public bool animatePhysics { get; set; } // 0x000000018B398278-0x000000018B3982AC 0x000000018B398468-0x000000018B3984AC
		[Obsolete("Use cullingType instead")]
		public bool animateOnlyIfVisible { [FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = true)] get; [FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = true)] set; } // 0x000000018B398244-0x000000018B398278 0x000000018B398424-0x000000018B398468
		public AnimationCullingType cullingType { get; set; } // 0x000000018B3982E0-0x000000018B398314 0x000000018B3984F0-0x000000018B398530
		public Bounds localBounds { [NativeName("GetLocalAABB")] get; [NativeName("SetLocalAABB")] set; } // 0x000000018B39838C-0x000000018B3983BC 0x000000018B398574-0x000000018B398588
	
		// Nested types
		private sealed class Enumerator : IEnumerator // TypeDefIndex: 60549
		{
			// Fields
			private Animation m_Outer; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public object Current { get; } // 0x000000018400B4A0-0x000000018400B500 
	
			// Constructors
			internal Enumerator(Animation outer); // 0x00000001832ED9A0-0x00000001832ED9C0
	
			// Methods
			public bool MoveNext(); // 0x0000000183F2F310-0x0000000183F2F380
			public void Reset(); // 0x0000000184D87910-0x0000000184D87920
		}
	
		// Constructors
		public Animation(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Stop(); // 0x000000018378E160-0x000000018378E1A0
		public void Stop(string name); // 0x000000018B3981F0-0x000000018B3981F8
		[NativeName("Stop")]
		private void StopNamed(string name); // 0x000000018B3981AC-0x000000018B3981F0
		public void Rewind(); // 0x000000018B39813C-0x000000018B398170
		public void Rewind(string name); // 0x000000018B398170-0x000000018B398178
		[NativeName("Rewind")]
		private void RewindNamed(string name); // 0x000000018B3980F8-0x000000018B39813C
		public void Sample(); // 0x000000018B398178-0x000000018B3981AC
		public bool IsPlaying(string name); // 0x000000018B397F88-0x000000018B397FCC
		[ExcludeFromDocs]
		public bool Play(); // 0x00000001845C64C0-0x00000001845C64D0
		public bool Play([UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x0000000185397994-0x00000001853979A0
		[NativeName("Play")]
		private bool PlayDefaultAnimation(UnityEngine.PlayMode mode); // 0x0000000184CD8EA0-0x0000000184CD8EF0
		[ExcludeFromDocs]
		public bool Play(string animation); // 0x00000001853979A0-0x00000001853979B0
		public bool Play(string animation, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018378E100-0x000000018378E160
		[ExcludeFromDocs]
		public void CrossFade(string animation); // 0x000000018B397F44-0x000000018B397F54
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength); // 0x000000018B397EC4-0x000000018B397EE0
		public void CrossFade(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018B397EE0-0x000000018B397F44
		[ExcludeFromDocs]
		public void Blend(string animation); // 0x000000018B397D80-0x000000018B397D90
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight); // 0x000000018B397DF4-0x000000018B397E14
		public void Blend(string animation, [UnityEngine.Internal.DefaultValue("1.0F")] float targetWeight, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength); // 0x000000018B397D90-0x000000018B397DF4
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation); // 0x000000018B397E4C-0x000000018B397E60
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength); // 0x000000018B397E14-0x000000018B397E30
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue); // 0x000000018B397E30-0x000000018B397E4C
		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018B397E60-0x000000018B397EC4
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation); // 0x000000018B397FCC-0x000000018B397FDC
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation, QueueMode queue); // 0x000000018B398040-0x000000018B39805C
		[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState PlayQueued(string animation, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode); // 0x000000018B397FDC-0x000000018B398040
		public void AddClip(AnimationClip clip, string newName); // 0x000000018B397CF4-0x000000018B397D1C
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame); // 0x000000018B397CD0-0x000000018B397CF4
		public void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [UnityEngine.Internal.DefaultValue("false")] bool addLoopFrame); // 0x000000018B397D1C-0x000000018B397D80
		public void RemoveClip([NotNull("NullExceptionObject")] AnimationClip clip); // 0x000000018B3980B4-0x000000018B3980F8
		public void RemoveClip(string clipName); // 0x000000018B3980AC-0x000000018B3980B4
		[NativeName("RemoveClip")]
		private void RemoveClipNamed(string clipName); // 0x000000018B398068-0x000000018B3980AC
		public int GetClipCount(); // 0x000000018B397F54-0x000000018B397F88
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode); // 0x0000000185397994-0x00000001853979A0
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode); // 0x000000018B39805C-0x000000018B398068
		public void SyncLayer(int layer); // 0x000000018B3981F8-0x000000018B398238
		public IEnumerator GetEnumerator(); // 0x00000001832ED960-0x00000001832ED9A0
		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		internal UnityEngine.AnimationState GetState(string name); // 0x000000018378E1A0-0x000000018378E1F0
		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		internal UnityEngine.AnimationState GetStateAtIndex(int index); // 0x000000018400B500-0x000000018400B550
		[NativeName("GetAnimationStateCount")]
		internal int GetStateCount(); // 0x0000000183F2F380-0x0000000183F2F3C0
		public AnimationClip GetClip(string name); // 0x000000018378E1F0-0x000000018378E220
		private void get_localBounds_Injected(out Bounds ret); // 0x000000018B398348-0x000000018B39838C
		private void set_localBounds_Injected(ref Bounds value); // 0x000000018B398530-0x000000018B398574
	}

	[NativeHeader("Modules/Animation/AnimationState.h")]
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference // TypeDefIndex: 60551
	{
		// Properties
		public bool enabled { get; set; } // 0x000000018B3975F0-0x000000018B397624 0x000000018B39779C-0x000000018B3977E0
		public float weight { get; set; } // 0x000000018B397728-0x000000018B39775C 0x000000018B397934-0x000000018B397978
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x00000001832EE490-0x00000001832EE4D0 0x000000018B397978-0x000000018B3979B8
		public float time { get; set; } // 0x000000018B3976F4-0x000000018B397728 0x000000018B3978F0-0x000000018B397934
		public float normalizedTime { get; set; } // 0x000000018B39768C-0x000000018B3976C0 0x000000018B397868-0x000000018B3978AC
		public float speed { get; set; } // 0x000000018B3976C0-0x000000018B3976F4 0x000000018B3978AC-0x000000018B3978F0
		public float normalizedSpeed { get; set; } // 0x000000018B397658-0x000000018B39768C 0x000000018B397824-0x000000018B397868
		public float length { get; } // 0x00000001832EB770-0x00000001832EB7B0 
		public int layer { get; set; } // 0x000000018B397624-0x000000018B397658 0x00000001832ED3A0-0x00000001832ED3F0
		public AnimationClip clip { get; } // 0x00000001832ECBE0-0x00000001832ECC20 
		public string name { get; set; } // 0x00000001832ED360-0x00000001832ED3A0 0x000000018B3977E0-0x000000018B397824
		public AnimationBlendMode blendMode { get; set; } // 0x000000018B3975BC-0x000000018B3975F0 0x000000018B39775C-0x000000018B39779C
	
		// Constructors
		public AnimationState(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix); // 0x000000018B397518-0x000000018B397524
		public void AddMixingTransform([NotNull("NullExceptionObject")] Transform mix, [UnityEngine.Internal.DefaultValue("true")] bool recursive); // 0x000000018B397524-0x000000018B397578
		public void RemoveMixingTransform([NotNull("NullExceptionObject")] Transform mix); // 0x000000018B397578-0x000000018B3975BC
	}

	[RequiredByNativeCode]
	public struct FastAnimationEvent // TypeDefIndex: 60552
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
		public string stringParameter { get; set; } // 0x0000000184D9B600-0x0000000184D9B610 0x00000001853908C0-0x00000001853908D0
		public float floatParameter { get; set; } // 0x0000000184DBA960-0x0000000184DBA970 0x00000001811EC9E0-0x00000001811EC9F0
		public int intParameter { get; set; } // 0x0000000184DBA990-0x0000000184DBA9A0 0x00000001811F0030-0x00000001811F0040
		public string functionName { get; } // 0x0000000184DBA980-0x0000000184DBA990 
		public float time { get; set; } // 0x0000000184DBA9D0-0x0000000184DBA9E0 0x0000000184D932C0-0x0000000184D932D0
		public SendMessageOptions messageOptions { set; } // 0x00000001811F2AA0-0x00000001811F2AB0
		public float clipWeight { get; set; } // 0x0000000184DBA740-0x0000000184DBA750 0x0000000184DAB920-0x0000000184DAB930
		public bool isInTransition { get; set; } // 0x0000000184DBA9C0-0x0000000184DBA9D0 0x0000000184D86AA0-0x0000000184D86AB0
		public bool isFromMaxWeightClipState { get; set; } // 0x0000000184DBA9A0-0x0000000184DBA9B0 0x0000000184D86D40-0x0000000184D86D50
		public bool isFromNextMaxWeightClipState { get; set; } // 0x0000000184DBA9B0-0x0000000184DBA9C0 0x0000000184DBA9E0-0x0000000184DBA9F0
		public int functionNameHashCode { get; set; } // 0x0000000184DBA970-0x0000000184DBA980 0x0000000184D86740-0x0000000184D86750
	}

	[RequiredByNativeCode]
	public struct FastAnimationEventGroup // TypeDefIndex: 60553
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
	public sealed class AnimationEvent // TypeDefIndex: 60554
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
		public string stringParameter { get; set; } // 0x0000000184DBA910-0x0000000184DBA920 0x0000000185390F40-0x0000000185390F50
		public float floatParameter { get; set; } // 0x0000000184DB9A40-0x0000000184DB9A50 0x0000000184D86E30-0x0000000184D86E40
		public int intParameter { get; set; } // 0x0000000184DBA8F0-0x0000000184DBA900 0x0000000184D86760-0x0000000184D86770
		public UnityEngine.Object objectReferenceParameter { set; } // 0x0000000182FDB880-0x0000000182FDB890
		public string functionName { get; set; } // 0x0000000184D96330-0x0000000184D96340 0x0000000185392C40-0x0000000185392C50
		public float time { get; set; } // 0x0000000184DBA720-0x0000000184DBA730 0x0000000184D88280-0x0000000184D88290
		public SendMessageOptions messageOptions { get; set; } // 0x0000000184DBA900-0x0000000184DBA910 0x0000000184D86430-0x0000000184D86440
		public bool isFiredByAnimator { get; } // 0x000000018B395BF4-0x000000018B395BFC 
		public AnimatorClipInfo animatorClipInfo { get; } // 0x000000018B395B98-0x000000018B395BF4 
	
		// Constructors
		public AnimationEvent(); // 0x000000018B395AFC-0x000000018B395B98
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion // TypeDefIndex: 60555
	{
		// Properties
		[NativeProperty("Length", false, UnityEngine.Bindings.TargetType.Function)]
		public float length { get; } // 0x000000018343B670-0x000000018343B6B0 
		[NativeProperty("StartTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float startTime { get; } // 0x000000018B395810-0x000000018B395844 
		[NativeProperty("StopTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float stopTime { get; } // 0x000000018B395844-0x000000018B395878 
		[NativeProperty("SampleRate", false, UnityEngine.Bindings.TargetType.Function)]
		public float frameRate { get; set; } // 0x000000018B395698-0x000000018B3956CC 0x000000018B39592C-0x000000018B395970
		public ushort clipTag { [NativeMethod("GetClipTag")] get; [NativeMethod("SetClipTag")] set; } // 0x000000018B395620-0x000000018B395654 0x000000018B3958E0-0x000000018B395924
		[NativeProperty("WrapMode", false, UnityEngine.Bindings.TargetType.Function)]
		public UnityEngine.WrapMode wrapMode { get; set; } // 0x00000001832ECCE0-0x00000001832ECD20 0x000000018B395A50-0x000000018B395A90
		[NativeProperty("Bounds", false, UnityEngine.Bindings.TargetType.Function)]
		public Bounds localBounds { get; set; } // 0x000000018B3957E0-0x000000018B395810 0x000000018B3959F8-0x000000018B395A0C
		public bool legacy { [NativeMethod("IsLegacy")] get; [NativeMethod("SetLegacy")] set; } // 0x0000000184D770C0-0x0000000184D77100 0x000000018B395970-0x000000018B3959B4
		public bool humanMotion { [NativeMethod("IsHumanMotion")] get; } // 0x000000018B395768-0x000000018B39579C 
		public bool empty { [NativeMethod("IsEmpty")] get; } // 0x00000001839F6FC0-0x00000001839F7000 
		public bool hasGenericRootTransform { [NativeMethod("HasGenericRootTransform")] get; } // 0x0000000183FA5D90-0x0000000183FA5DD0 
		public bool hasMotionFloatCurves { [NativeMethod("HasMotionFloatCurves")] get; } // 0x000000018B395700-0x000000018B395734 
		public bool hasMotionCurves { [NativeMethod("HasMotionCurves")] get; } // 0x000000018B3956CC-0x000000018B395700 
		public bool hasRootCurves { [NativeMethod("HasRootCurves")] get; } // 0x000000018B395734-0x000000018B395768 
		internal bool hasRootMotion { [FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)] get; } // 0x0000000183FA5D50-0x0000000183FA5D90 
		public bool transferRotationCompressed { [NativeMethod("GetTransferCompressed")] get; [NativeMethod("SetTransferCompressed")] set; } // 0x000000018B395878-0x000000018B3958AC 0x000000018B395A0C-0x000000018B395A50
		public ulong uniqueId { [NativeMethod("GetClipUniqueID")] get; } // 0x000000018B3958AC-0x000000018B3958E0 
		public AnimationEvent[] events { get; set; } // 0x000000018B395654-0x000000018B395698 0x000000018B395924-0x000000018B39592C
	
		// Constructors
		public AnimationClip(); // 0x000000018386FF40-0x000000018386FF70
	
		// Methods
		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self); // 0x000000018386FF70-0x000000018386FFB0
		public void SampleAnimation(GameObject go, float time); // 0x00000001832ECC40-0x00000001832ECCE0
		public void SampleAnimationFast(GameObject go, float time); // 0x0000000183435540-0x0000000183435590
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimation([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode); // 0x00000001832ECD20-0x00000001832ECD90
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimationFast([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode); // 0x00000001834354D0-0x0000000183435540
		[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
		public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve); // 0x000000018B395578-0x000000018B3955DC
		[FreeFunction("AnimationClipBindings::Internal_GetAnimatorFloatCurve", HasExplicitThis = true)]
		public bool GetAnimatorFloatCurve(string propertyName, AnimationCurve curve); // 0x000000018B3954BC-0x000000018B395510
		public void EnsureQuaternionContinuity(); // 0x000000018B395488-0x000000018B3954BC
		public void ClearCurves(); // 0x000000018B395454-0x000000018B395488
		[FreeFunction("AnimationClipBindings::Internal_GetAnimationRuntimeMemorySize", HasExplicitThis = true)]
		public uint GetRuntimeMemorySize(); // 0x000000018B395544-0x000000018B395578
		public void AddEvent(AnimationEvent evt); // 0x000000018B3953E8-0x000000018B395454
		[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = true)]
		private void AddEventInternal(object evt); // 0x000000018B3953A4-0x000000018B3953E8
		[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = true, ThrowsException = true)]
		private void SetEventsInternal(Array value); // 0x000000018B3955DC-0x000000018B395620
		[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = true)]
		private Array GetEventsInternal(); // 0x000000018B395510-0x000000018B395544
		private void get_localBounds_Injected(out Bounds ret); // 0x000000018B39579C-0x000000018B3957E0
		private void set_localBounds_Injected(ref Bounds value); // 0x000000018B3959B4-0x000000018B3959F8
	}

	public enum AvatarTarget // TypeDefIndex: 60556
	{
		Root = 0,
		Body = 1,
		LeftFoot = 2,
		RightFoot = 3,
		LeftHand = 4,
		RightHand = 5
	}

	public enum AvatarIKGoal // TypeDefIndex: 60557
	{
		LeftFoot = 0,
		RightFoot = 1,
		LeftHand = 2,
		RightHand = 3
	}

	public enum AvatarIKHint // TypeDefIndex: 60558
	{
		LeftKnee = 0,
		RightKnee = 1,
		LeftElbow = 2,
		RightElbow = 3
	}

	public enum AnimatorControllerParameterType // TypeDefIndex: 60559
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	internal enum StateInfoIndex // TypeDefIndex: 60560
	{
		CurrentState = 0,
		NextState = 1,
		ExitState = 2,
		InterruptedState = 3
	}

	public enum AnimationBlendStyle // TypeDefIndex: 60561
	{
		Linear = 0,
		CubicIn = 1,
		HermiteCubic = 2,
		Sinusoidal = 3,
		CubicInOut = 4
	}

	public enum AnimatorTransitionInterruptionSource // TypeDefIndex: 60562
	{
		None = 0,
		Current = 1,
		Next = 2,
		CurrentThenNext = 3,
		NextThenCurrent = 4
	}

	public enum AnimatorRecorderMode // TypeDefIndex: 60563
	{
		Offline = 0,
		Playback = 1,
		Record = 2
	}

	public enum AnimatorUroMode // TypeDefIndex: 60564
	{
		Origin = 0,
		Predict = 1,
		PredictWithTick = 2,
		PredictWithTickAndRootMotion = 3
	}

	public enum AnimatorCullingMode // TypeDefIndex: 60565
	{
		AlwaysAnimate = 0,
		CullUpdateTransforms = 1,
		CullCompletely = 2
	}

	public enum AnimatorUpdateMode // TypeDefIndex: 60566
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum AnimatorJobDispatchMode // TypeDefIndex: 60567
	{
		Default = 0,
		ForceMainThread = 1,
		PreUpdate = 2,
		CrossFrame = 3,
		CrossFrameLateUpdate = 4
	}

	[UsedByNativeCode]
	public struct AnimatorLOD // TypeDefIndex: 60568
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
		public AnimatorLOD(float worldAbsoluteDistance, int framesPerUpdate, float maxDeltaTime, int framesPerWrite = 0 /* Metadata: 0x0234ECB4 */, float maxBlendDeltaTime = 0f /* Metadata: 0x0234ECB5 */, AnimatorUroMode uroMode = AnimatorUroMode.Origin /* Metadata: 0x0234ECB9 */, int delayFrame = 0 /* Metadata: 0x0234ECBA */); // 0x0000000184DBA920-0x0000000184DBA950
	}

	[NativeHeader("Modules/Animation/HGAnimExtra/HGTransformRWBuffer.h")]
	public struct AnimationTransformRWBufferHandle // TypeDefIndex: 60569
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
	public struct HGAnimParameterSGHandle // TypeDefIndex: 60570
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

	public enum AnimFrameSyncMode // TypeDefIndex: 60571
	{
		FrameSyncInRootPlayable = 0,
		FrameSyncInBaseLayerState = 1
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public struct AnimatorClipInfo // TypeDefIndex: 60572
	{
		// Fields
		private int m_ClipInstanceID; // 0x00
		private float m_Weight; // 0x04
	
		// Properties
		public AnimationClip clip { get; } // 0x000000018B3985FC-0x000000018B398618 
		public float weight { get; } // 0x0000000184DBA740-0x0000000184DBA750 
	
		// Methods
		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID); // 0x000000018B3985C8-0x000000018B3985FC
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateInfo // TypeDefIndex: 60573
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
		public int fullPathHash { get; } // 0x0000000184D9CF30-0x0000000184D9CF40 
		public int shortNameHash { get; } // 0x0000000184DBA750-0x0000000184DBA760 
		public float normalizedTime { get; } // 0x0000000184DBA950-0x0000000184DBA960 
		public float length { get; } // 0x0000000184DBA720-0x0000000184DBA730 
		public int tagHash { get; } // 0x0000000184D9B610-0x0000000184D9B620 
		public bool loop { get; } // 0x000000018343C970-0x000000018343C980 
	
		// Methods
		public bool IsName(string name); // 0x0000000183F7F9F0-0x0000000183F7FA20
		public bool IsTag(string tag); // 0x0000000183B071C0-0x0000000183B071F0
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateRootMotionInfo // TypeDefIndex: 60574
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
	public struct AnimatorTransitionInfo // TypeDefIndex: 60575
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
		public int nameHash { get; } // 0x0000000184D9CF30-0x0000000184D9CF40 
	
		// Methods
		public bool IsUserName(string name); // 0x000000018B3999F0-0x000000018B399A14
	}

	[NativeHeader("Modules/Animation/Animator.h")]
	public struct MatchTargetWeightMask // TypeDefIndex: 60576
	{
		// Fields
		private Vector3 m_PositionXYZWeight; // 0x00
		private float m_RotationWeight; // 0x0C
	
		// Constructors
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight); // 0x0000000184D8C1B0-0x0000000184D8C1D0
	}

	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UsedByNativeCode]
	public class Animator : UnityEngine.Behaviour // TypeDefIndex: 60582
	{
		// Fields
		internal AnimationEventCallback onAnimationEvent; // 0x18
		internal AnimationEventCallbackOpt onAnimationEventOpt; // 0x20
		internal AnimatorStateChangeCallback onAnimatorStateEnter; // 0x28
		internal AnimatorStateChangeCallback onAnimatorStateExit; // 0x30
		internal AnimatorStateChangeCallback onAnimatorStatePreExit; // 0x38
		internal AniamtorCommonCallback afterAnimatorUpdateGraphCB; // 0x40
	
		// Properties
		public bool fastAnimationEventsOpt { [NativeMethod("GetEnableFireAnimationEventsOpt")] get; [NativeMethod("SetEnableFireAnimationEventsOpt")] set; } // 0x000000018B39E1E8-0x000000018B39E21C 0x000000018378DC80-0x000000018378DCD0
		public bool callBackAfterUpdateGraph { [NativeMethod("GetNeedInvokeCBAfterUpdateGraph")] get; [NativeMethod("SetNeedInvokeCBAfterUpdateGraph")] set; } // 0x000000018B39E14C-0x000000018B39E180 0x000000018B39ECDC-0x000000018B39ED20
		public bool fastAnimationEvents { [NativeMethod("GetFastAnimationEvents")] get; [NativeMethod("SetFastAnimationEvents")] set; } // 0x000000018B39E21C-0x000000018B39E250 0x000000018378DCD0-0x000000018378DD20
		public bool notifyAnimatorStateEnterAndExitEvent { [NativeMethod("GetNotifyAnimatorStateEnterAndExitEvent")] get; [NativeMethod("SetNotifyAnimatorStateEnterAndExitEvent")] set; } // 0x000000018B39E604-0x000000018B39E638 0x000000018408AA50-0x000000018408AAA0
		public bool keepStateOnChangeActive { [NativeMethod("GetKeepAnimatorStateOnChangeActive")] get; [NativeMethod("SetKeepAnimatorStateOnChangeActive")] set; } // 0x000000018B39E430-0x000000018B39E464 0x000000018B39EDF4-0x000000018B39EE38
		public bool pausePlayableOnChangeActive { [NativeMethod("GetPauseAnimatorStateOnChangeActive")] get; [NativeMethod("SetPauseAnimatorStateOnChangeActive")] set; } // 0x000000018B39E638-0x000000018B39E66C 0x000000018B39EFCC-0x000000018B39F010
		public bool resetControllerPlayableOnChangeActive { [NativeMethod("GetResetAnimatorControllerStateOnChangeActive")] get; [NativeMethod("SetResetAnimatorControllerStateOnChangeActive")] set; } // 0x000000018B39E7C8-0x000000018B39E7FC 0x000000018B39F054-0x000000018B39F098
		public bool isOptimizable { [NativeMethod("IsOptimizable")] get; } // 0x000000018B39E388-0x000000018B39E3BC 
		public bool isHuman { [NativeMethod("IsHuman")] get; } // 0x0000000183FA6110-0x0000000183FA6150 
		public bool hasRootMotion { [NativeMethod("HasRootMotion")] get; } // 0x000000018B39E2B8-0x000000018B39E2EC 
		internal bool isRootPositionOrRotationControlledByCurves { [NativeMethod("IsRootTranslationOrRotationControllerByCurves")] get; } // 0x000000018B39E3BC-0x000000018B39E3F0 
		public float humanScale { get; } // 0x000000018B39E2EC-0x000000018B39E320 
		public bool isInitialized { [NativeMethod("IsInitialized")] get; } // 0x000000018B39E320-0x000000018B39E354 
		public bool isVisible { [NativeMethod("IsVisible")] get; } // 0x00000001833D0530-0x00000001833D0570 
		public bool updatedLastFrame { [NativeMethod("GetShouldTick")] get; } // 0x0000000183503520-0x0000000183503560 
		public bool enableLOD { [NativeMethod("GetEnableLOD")] get; [NativeMethod("SetEnableLOD")] set; } // 0x000000018B39E180-0x000000018B39E1B4 0x00000001836276B0-0x0000000183627700
		public int LODLevel { [NativeMethod("GetCurrentLODLevel")] get; } // 0x0000000182F937E0-0x0000000182F93820 
		public float motionDeltaTime { get; } // 0x000000018B39E5D0-0x000000018B39E604 
		public Vector3 deltaPosition { get; } // 0x000000018343D7F0-0x000000018343D850 
		public Quaternion deltaRotation { get; } // 0x000000018343D8E0-0x000000018343D910 
		public Vector3 velocity { get; } // 0x000000018343D690-0x000000018343D6F0 
		public Vector3 angularVelocity { get; } // 0x000000018343D740-0x000000018343D7A0 
		public Vector3 rootPosition { [NativeMethod("GetAvatarPosition")] get; [NativeMethod("SetAvatarPosition")] set; } // 0x000000018B39E874-0x000000018B39E8A0 0x000000018B39F0DC-0x000000018B39F0F0
		public Quaternion rootRotation { [NativeMethod("GetAvatarRotation")] get; [NativeMethod("SetAvatarRotation")] set; } // 0x000000018B39E8E4-0x000000018B39E910 0x000000018B39F134-0x000000018B39F148
		public bool applyRootMotion { get; set; } // 0x000000018B39DF70-0x000000018B39DFA4 0x000000018B39EB68-0x000000018B39EBAC
		[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
		public bool linearVelocityBlending { get; set; } // 0x000000018B39E4CC-0x000000018B39E500 0x000000018B39EE7C-0x000000018B39EEC0
		[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
		public bool animatePhysics { get; set; } // 0x000000018B39DF24-0x000000018B39DF3C 0x000000018B39EB04-0x000000018B39EB24
		public AnimatorUpdateMode updateMode { get; set; } // 0x00000001835BD460-0x00000001835BD4A0 0x000000018B39F18C-0x000000018B39F1CC
		public bool hasTransformHierarchy { get; } // 0x00000001839C7C00-0x00000001839C7C40 
		internal bool allowConstantClipSamplingOptimization { get; set; } // 0x000000018B39DEF0-0x000000018B39DF24 0x000000018B39EAC0-0x000000018B39EB04
		public float gravityWeight { get; } // 0x000000018343D8A0-0x000000018343D8E0 
		public Vector3 bodyPosition { get; set; } // 0x000000018B39E048-0x000000018B39E098 0x000000018B39EC04-0x000000018B39EC48
		internal Vector3 bodyPositionInternal { [NativeMethod("GetBodyPosition")] get; [NativeMethod("SetBodyPosition")] set; } // 0x000000018B39E01C-0x000000018B39E048 0x000000018B39EBF0-0x000000018B39EC04
		public Quaternion bodyRotation { get; set; } // 0x000000018B39E108-0x000000018B39E14C 0x000000018B39ECA0-0x000000018B39ECDC
		internal Quaternion bodyRotationInternal { [NativeMethod("GetBodyRotation")] get; [NativeMethod("SetBodyRotation")] set; } // 0x000000018B39E0DC-0x000000018B39E108 0x000000018B39EC8C-0x000000018B39ECA0
		public bool stabilizeFeet { get; set; } // 0x000000018B39E944-0x000000018B39E978 0x000000018B39F148-0x000000018B39F18C
		public int layerCount { get; } // 0x000000018322D150-0x000000018322D190 
		public AnimatorControllerParameter[] parameters { [FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)] get; } // 0x000000018378ADA0-0x000000018378ADE0 
		public int parameterCount { get; } // 0x000000018378ADE0-0x000000018378AE20 
		public float feetPivotActive { get; set; } // 0x000000018B39E250-0x000000018B39E284 0x000000018B39ED64-0x000000018B39EDA8
		public float pivotWeight { get; } // 0x000000018B39E6DC-0x000000018B39E710 
		public Vector3 pivotPosition { get; } // 0x000000018B39E6B0-0x000000018B39E6DC 
		public bool isMatchingTarget { [NativeMethod("IsMatchingTarget")] get; } // 0x000000018B39E354-0x000000018B39E388 
		public float timeScale { [NativeMethod("GetTimeScale")] get; [NativeMethod("SetTimeScale")] set; } // 0x0000000183860A10-0x0000000183860A50 0x00000001838602D0-0x0000000183860320
		public float speed { get; set; } // 0x000000018B39E910-0x000000018B39E944 0x0000000183861540-0x0000000183861590
		public Vector3 targetPosition { get; } // 0x000000018B39E9F0-0x000000018B39EA1C 
		public Quaternion targetRotation { get; } // 0x000000018B39EA60-0x000000018B39EA8C 
		internal Transform avatarRoot { get; } // 0x000000018B39DFA4-0x000000018B39DFD8 
		public AnimatorCullingMode cullingMode { get; set; } // 0x00000001835BD8B0-0x00000001835BD8F0 0x00000001831DD660-0x00000001831DD6B0
		public float playbackTime { get; set; } // 0x000000018B39E748-0x000000018B39E77C 0x000000018B39F010-0x000000018B39F054
		public float recorderStartTime { get; set; } // 0x000000018B39E7B0-0x000000018B39E7BC 0x00000001841E1670-0x00000001841E1680
		public float recorderStopTime { get; set; } // 0x000000018B39E7BC-0x000000018B39E7C8 0x00000001841E1670-0x00000001841E1680
		public AnimatorRecorderMode recorderMode { get; } // 0x000000018B39E77C-0x000000018B39E7B0 
		public RuntimeAnimatorController runtimeAnimatorController { get; set; } // 0x000000018300FA90-0x000000018300FCE0 0x000000018322E3B0-0x000000018322E400
		public bool hasBoundPlayables { [NativeMethod("HasBoundPlayables")] get; } // 0x0000000183796920-0x0000000183796960 
		public Avatar avatar { get; set; } // 0x00000001839C99F0-0x00000001839C9A30 0x0000000183DD0120-0x0000000183DD0170
		public HGSkeletalMorphAvatar morphAvatar { get; set; } // 0x000000018B39E59C-0x000000018B39E5D0 0x000000018B39EF88-0x000000018B39EFCC
		public LodBoneMask lodBoneMask { get; set; } // 0x000000018B39E534-0x000000018B39E568 0x000000018B39EF00-0x000000018B39EF44
		public uint lodBoneMaskLevel { get; set; } // 0x000000018B39E500-0x000000018B39E534 0x000000018B39EEC0-0x000000018B39EF00
		public PlayableGraph playableGraph { get; } // 0x000000018B39E710-0x000000018B39E748 
		public bool applyMorphPose { get; set; } // 0x000000018B39DF3C-0x000000018B39DF70 0x000000018B39EB24-0x000000018B39EB68
		public bool layersAffectMassCenter { get; set; } // 0x000000018B39E464-0x000000018B39E498 0x000000018B39EE38-0x000000018B39EE7C
		public float leftFeetBottomHeight { get; } // 0x000000018B39E498-0x000000018B39E4CC 
		public float rightFeetBottomHeight { get; } // 0x000000018B39E7FC-0x000000018B39E830 
		[NativeConditional("UNITY_EDITOR")]
		internal bool supportsOnAnimatorMove { [NativeMethod("SupportsOnAnimatorMove")] get; } // 0x000000018B39E978-0x000000018B39E9AC 
		public bool logWarnings { get; set; } // 0x000000018B39E568-0x000000018B39E59C 0x000000018B39EF44-0x000000018B39EF88
		public bool enableParameterWarnings { get; set; } // 0x000000018B39E1B4-0x000000018B39E1E8 0x000000018B39ED20-0x000000018B39ED64
		public bool fireEvents { get; set; } // 0x000000018B39E284-0x000000018B39E2B8 0x000000018B39EDA8-0x000000018B39EDEC
		[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", false)]
		public bool keepAnimatorControllerStateOnDisable { get; set; } // 0x000000018B39E3F0-0x000000018B39E3FC 0x000000018B39EDEC-0x000000018B39EDF4
		public bool keepAnimatorStateOnDisable { get; set; } // 0x000000018B39E3FC-0x000000018B39E430 0x0000000183DD00D0-0x0000000183DD0120
		public bool writeDefaultValuesOnDisable { get; set; } // 0x000000018B39EA8C-0x000000018B39EAC0 0x000000018322E400-0x000000018322E450
	
		// Nested types
		public delegate bool AnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // TypeDefIndex: 60577; 0x000000018622AD60-0x000000018622ADA8
	
		public delegate void AnimatorStateChangeCallback(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex); // TypeDefIndex: 60578; 0x000000018B3999A8-0x000000018B3999F0
	
		public delegate bool AnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent); // TypeDefIndex: 60579; 0x000000018B395A90-0x000000018B395AFC
	
		public delegate void AniamtorCommonCallback(Animator animator); // TypeDefIndex: 60580; 0x0000000182B46B90-0x0000000182B46BA0
	
		public enum RetargetBoneMode // TypeDefIndex: 60581
		{
			Translation = 0,
			Scale = 1
		}
	
		// Constructors
		public Animator(); // 0x000000018B39DEA4-0x000000018B39DEF0
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallAnimatorStateChangeCallback(Animator anim, AnimatorStateInfo animatorStateInfo, int layerIndex, int methodIdx); // 0x00000001845D15D0-0x00000001845D1720
		[RequiredByNativeCode]
		private static void Internal_CallAfterUpdateGraph(Animator anim); // 0x000000018B39BC44-0x000000018B39BCB0
		[RequiredByNativeCode]
		private static bool Internal_InvokeAnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // 0x0000000184231DD0-0x0000000184231E50
		[RequiredByNativeCode]
		private static bool Internal_InvokeAnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent); // 0x0000000183F32C60-0x0000000183F32D60
		public void SetCallbackAfterRootMotionStageCallback(AniamtorCommonCallback cb); // 0x00000001842B4AE0-0x00000001842B4AF0
		public void SetAnimationEventCallback(AnimationEventCallback onAnimationEvent); // 0x0000000185392C40-0x0000000185392C50
		public void SetAnimationEventCallbackOpt(AnimationEventCallbackOpt onAnimationEvent); // 0x0000000185390F40-0x0000000185390F50
		public void SetNotifyAnimatorStateEnterAndExitEventCallBack(AnimatorStateChangeCallback onAnimatorStateEnter, AnimatorStateChangeCallback onAnimatorStateExit); // 0x000000018408AA20-0x000000018408AA50
		public void SetNotifyAnimatorStatePreExitEventCallBack(AnimatorStateChangeCallback onAnimatorStatePreExit); // 0x00000001846A91B0-0x00000001846A91C0
		[NativeMethod("SetLODLevel")]
		public bool SetLODLevel(int level); // 0x0000000183787AB0-0x0000000183787B00
		[NativeMethod("GetCurrentLODLevel")]
		public int GetCurrentLODLevel(); // 0x000000018B39B208-0x000000018B39B23C
		[FreeFunction("AnimatorBindings::GetLODs_Binding", HasExplicitThis = true)]
		public AnimatorLOD[] GetLODs(); // 0x00000001833D1900-0x00000001833D1940
		[FreeFunction("AnimatorBindings::SetLODs_Binding", HasExplicitThis = true)]
		public void SetLODs([Unmarshalled] AnimatorLOD[] lods); // 0x00000001837878D0-0x0000000183787920
		[NativeMethod("SetConstraintEnableImmediately")]
		public void SetConstraintEnableImmediately(int nameHash); // 0x000000018B39C984-0x000000018B39C9C4
		[NativeMethod("SetConstraintDisableImmediately")]
		public void SetConstraintDisableImmediately(int nameHash); // 0x000000018B39C8F4-0x000000018B39C934
		[NativeMethod("SetConstraintEnableBlendIn")]
		public void SetConstraintEnableBlendIn(int nameHash, float duration); // 0x000000018B39C934-0x000000018B39C984
		[NativeMethod("SetConstraintDisableBlendOut")]
		public void SetConstraintDisableBlendOut(int nameHash, float duration); // 0x000000018B39C8A4-0x000000018B39C8F4
		public void BecameVisible(); // 0x0000000183434620-0x0000000183434660
		[NativeMethod("SetAnimatorJobOptEnable")]
		public static void SetAnimatorJobOptEnable(bool enabel); // 0x000000018464F170-0x000000018464F1B0
		[NativeMethod("SetAnimatorJobOptFunc")]
		public static void SetAnimatorJobOptFunc(int value); // 0x000000018464F1B0-0x000000018464F1F0
		[NativeMethod("SetAnimatorWriteTransformOpt")]
		public static void SetAnimatorWriteTransformOpt(bool value); // 0x000000018464F1F0-0x000000018464F230
		[NativeMethod("SetGlobalAnimatorClipBindingsOpt")]
		public static void SetGlobalAnimatorClipBindingsOpt(bool value); // 0x000000018464F230-0x000000018464F270
		[NativeMethod("SetGlobalAnimatorClipBindingsConstantOpt")]
		public static void SetGlobalAnimatorClipBindingsConstantOpt(bool value); // 0x000000018464F270-0x000000018464F2B0
		[NativeMethod("SetGlobalAnimatorClipBindingsOptByAvatar")]
		public static void SetGlobalAnimatorClipBindingsOptByAvatar(bool value); // 0x000000018464F2B0-0x000000018464F2F0
		[NativeMethod("SetAnimatorUroMaxDeltaTimePerframe")]
		public static void SetAnimatorUroMaxDeltaTimePerframe(float value); // 0x000000018B39C644-0x000000018B39C680
		[NativeMethod("SetGlobalAnimatorCacheClipBindingsOpt")]
		public static void SetGlobalAnimatorCacheClipBindingsOpt(bool value); // 0x000000018464F2F0-0x000000018464F330
		[NativeMethod("GetAnimatorUroMaxDeltaTimePerframe")]
		public static float GetAnimatorUroMaxDeltaTimePerframe(); // 0x000000018B39ABE0-0x000000018B39AC0C
		[NativeMethod("SetAnimatorMainThreadJobCount")]
		public static void SetAnimatorMainThreadJobCount(int value); // 0x000000018B39C610-0x000000018B39C644
		[NativeMethod("SetPrepareFrameJobBatchCountOpt")]
		public static void SetPrepareFrameJobBatchCountOpt(int value); // 0x000000018B39D8EC-0x000000018B39D920
		[NativeMethod("SetProcessAnimJobBatchCountOpt")]
		public static void SetProcessAnimJobBatchCountOpt(int value); // 0x000000018B39D920-0x000000018B39D954
		[NativeMethod("SetAnimatorEnableProcessOneStage")]
		public static void SetAnimatorEnableProcessOneStage(bool value); // 0x000000018464F330-0x000000018464F370
		[NativeMethod("SetAnimatorEnableApplyOnMoveInJob")]
		public static void SetAnimatorEnableApplyOnMoveInJob(bool value); // 0x000000018B39C574-0x000000018B39C5A8
		[NativeMethod("SetAnimatorEnableRequireEventsAndBehaviour")]
		public static void SetAnimatorEnableRequireEventsAndBehaviour(bool value); // 0x000000018B39C5DC-0x000000018B39C610
		[NativeMethod("SetApplyBuildInRootMotionInJob")]
		public void SetApplyBuildInRootMotionInJob(bool enable); // 0x000000018B39C680-0x000000018B39C6C4
		[NativeMethod("SetAnimatorForbbidenApplyOnMoveCb")]
		public static void SetAnimatorForbbidenApplyOnMoveCb(bool value); // 0x000000018464F370-0x000000018464F3B0
		[NativeMethod("SetAnimatorEnableCrossFrameJobs")]
		public static void SetAnimatorEnableCrossFrameJobs(bool enabel); // 0x000000018B39C5A8-0x000000018B39C5DC
		[NativeMethod("SetAbilityLevel")]
		public void SetAbilityLevel(int abilityLevel); // 0x000000018378B130-0x000000018378B180
		[NativeMethod("GetAbilityLevel")]
		public int GetAbilityLevel(); // 0x0000000182F937A0-0x0000000182F937E0
		[NativeMethod("SetSampleClipCacheCreatePreFrameCount")]
		public static void SetSampleClipCacheCreatePreFrameCount(int value); // 0x000000018B39DBD4-0x000000018B39DC08
		[NativeMethod("SetSampleClipCacheMaxCount")]
		public static void SetSampleClipCacheMaxCount(int value); // 0x000000018B39DC08-0x000000018B39DC3C
		[NativeMethod("SetLayerMeshSpace")]
		public void SetLayerMeshSpace(int layerIndex, bool enable); // 0x000000018378AAA0-0x000000018378AB00
		[NativeMethod("GetLayerMeshSpace")]
		public bool GetLayerMeshSpace(int layerIndex); // 0x000000018B39B7D0-0x000000018B39B810
		[NativeMethod("SetLayerMaskBoneWeights")]
		private void Internal_SetLayerMaskBoneWeights(int layerIndex, IntPtr bonePathHashes, IntPtr weights, int count); // 0x000000018B39BD00-0x000000018B39BD60
		[NativeMethod("ClearLayerMaskBoneWeights")]
		public void ClearLayerMaskBoneWeights(int layerIndex); // 0x000000018B399C30-0x000000018B399C70
		public void SetLayerMaskBoneWeights(int layerIndex, int[] bonePathHashes, float[] weights); // 0x000000018B39D1D0-0x000000018B39D318
		public void SetLayerMaskBoneWeights(int layerIndex, NativeArray<int> bonePathHashes, NativeArray<float> weights); // 0x000000018B39D318-0x000000018B39D3F0
		[NativeMethod("SetRetargetScaleEnabled")]
		public void SetRetargetScaleEnabled(bool enabled); // 0x000000018322E550-0x000000018322E5A0
		[NativeMethod("GetRetargetScaleEnabled")]
		public bool GetRetargetScaleEnabled(); // 0x000000018B39BA90-0x000000018B39BAC4
		public void SetRetargetScaleByAvatar(Avatar referenceAvatar, string[] boneNames); // 0x000000018B39D954-0x000000018B39DA54
		[NativeMethod("SetRetargetScaleByAvatar")]
		private void Internal_SetRetargetScaleByAvatar(Avatar referenceAvatar, int[] boneNameHashes, int count); // 0x000000018B39BDC0-0x000000018B39BE24
		public void SetRetargetScale(string[] boneNames, Vector3 scaleFactor, RetargetBoneMode[] boneModes = null); // 0x000000018B39DA98-0x000000018B39DBD4
		[NativeMethod("SetRetargetScale")]
		private void Internal_SetRetargetScale(int[] boneNameHashes, int count, Vector3 scaleFactor, int[] boneModes); // 0x000000018B39BE88-0x000000018B39BEAC
		public void SetRetargetScaleWeight(float weight); // 0x000000018B39DA54-0x000000018B39DA98
		public float GetRetargetScaleWeight(); // 0x000000018B39BAC4-0x000000018B39BAF8
		[NativeMethod("SetControllerDefaultValues")]
		public void SetControllerDefaultValues(bool value); // 0x000000018B39C9C4-0x000000018B39CA08
		public float GetFloat(string name); // 0x00000001853925AC-0x00000001853925B8
		public float GetFloat(int id); // 0x0000000185390B1C-0x0000000185390B28
		public float GetFloatFromTransition(int layerIndex, int id); // 0x000000018B39B358-0x000000018B39B364
		public float GetFloatFromTransitionWithDefault(int layerIndex, int id, float defValue); // 0x00000001853944F4-0x0000000185394504
		public void SetFloat(string name, float value); // 0x000000018B39CD4C-0x000000018B39CD54
		public void SetFloat(string name, float value, float dampTime, float deltaTime); // 0x000000018B39CD3C-0x000000018B39CD4C
		public void SetFloat(int id, float value); // 0x00000001853925B8-0x00000001853925C0
		public void SetFloat(int id, float value, float dampTime, float deltaTime); // 0x000000018B39CD54-0x000000018B39CD64
		public bool GetBool(string name); // 0x000000018B39B040-0x000000018B39B04C
		public bool GetBool(int id); // 0x0000000185393DC4-0x0000000185393DD0
		public void SetBool(string name, bool value); // 0x0000000185397548-0x0000000185397550
		public void SetBool(int id, bool value); // 0x000000018539463C-0x0000000185394644
		public int GetInteger(string name); // 0x000000018B39B7C4-0x000000018B39B7D0
		public int GetInteger(int id); // 0x00000001853925A0-0x00000001853925AC
		public void SetInteger(string name, int value); // 0x000000018B39D1C8-0x000000018B39D1D0
		public void SetInteger(int id, int value); // 0x0000000185396E38-0x0000000185396E40
		public void SetTrigger(string name); // 0x0000000185393888-0x0000000185393890
		public void SetTrigger(int id); // 0x000000018B39DC8C-0x000000018B39DC94
		public void ResetTrigger(string name); // 0x0000000185393880-0x0000000185393888
		public void ResetTrigger(int id); // 0x0000000185390B14-0x0000000185390B1C
		public bool IsParameterControlledByCurve(string name); // 0x000000018B39C060-0x000000018B39C06C
		public bool IsParameterControlledByCurve(int id); // 0x000000018B39C06C-0x000000018B39C078
		[NativeMethod("SetAllowConstantClipSamplingOpt")]
		public void SetAllowConstantClipSamplingOpt(bool enable); // 0x000000018B39C530-0x000000018B39C574
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x000000018B39B698-0x000000018B39B6F8
		private Vector3 GetGoalPosition(AvatarIKGoal goal); // 0x000000018B39B3B4-0x000000018B39B3E4
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition); // 0x000000018B39D098-0x000000018B39D0EC
		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition); // 0x000000018B39CDF8-0x000000018B39CE0C
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x000000018B39B728-0x000000018B39B780
		private Quaternion GetGoalRotation(AvatarIKGoal goal); // 0x000000018B39B434-0x000000018B39B464
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation); // 0x000000018B39D12C-0x000000018B39D174
		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation); // 0x000000018B39CE5C-0x000000018B39CE70
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x000000018B39B668-0x000000018B39B698
		private float GetGoalWeightPosition(AvatarIKGoal goal); // 0x000000018B39B464-0x000000018B39B4A4
		public void SetIKPositionWeight(AvatarIKGoal goal, float value); // 0x000000018B39D058-0x000000018B39D098
		private void SetGoalWeightPosition(AvatarIKGoal goal, float value); // 0x000000018B39CE70-0x000000018B39CEC0
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x000000018B39B6F8-0x000000018B39B728
		private float GetGoalWeightRotation(AvatarIKGoal goal); // 0x000000018B39B4A4-0x000000018B39B4E4
		public void SetIKRotationWeight(AvatarIKGoal goal, float value); // 0x000000018B39D0EC-0x000000018B39D12C
		private void SetGoalWeightRotation(AvatarIKGoal goal, float value); // 0x000000018B39CEC0-0x000000018B39CF10
		public Vector3 GetIKHintPosition(AvatarIKHint hint); // 0x000000018B39B608-0x000000018B39B668
		private Vector3 GetHintPosition(AvatarIKHint hint); // 0x000000018B39B568-0x000000018B39B598
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition); // 0x000000018B39D004-0x000000018B39D058
		private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition); // 0x000000018B39CF60-0x000000018B39CF74
		public float GetIKHintPositionWeight(AvatarIKHint hint); // 0x000000018B39B5D8-0x000000018B39B608
		private float GetHintWeightPosition(AvatarIKHint hint); // 0x000000018B39B598-0x000000018B39B5D8
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value); // 0x000000018B39CFC4-0x000000018B39D004
		private void SetHintWeightPosition(AvatarIKHint hint, float value); // 0x000000018B39CF74-0x000000018B39CFC4
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x000000018B39D448-0x000000018B39D48C
		[NativeMethod("SetLookAtPosition")]
		private void SetLookAtPositionInternal(Vector3 lookAtPosition); // 0x000000018B39D434-0x000000018B39D448
		public void SetLookAtWeight(float weight); // 0x000000018B39D6B8-0x000000018B39D710
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x000000018B39D4F4-0x000000018B39D558
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x000000018B39D648-0x000000018B39D6B8
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x000000018B39D558-0x000000018B39D5D0
		public void SetLookAtWeight(float weight, [UnityEngine.Internal.DefaultValue("0.0f")] float bodyWeight, [UnityEngine.Internal.DefaultValue("1.0f")] float headWeight, [UnityEngine.Internal.DefaultValue("0.0f")] float eyesWeight, [UnityEngine.Internal.DefaultValue("0.5f")] float clampWeight); // 0x000000018B39D5D0-0x000000018B39D648
		[NativeMethod("SetLookAtWeight")]
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x000000018B39D48C-0x000000018B39D4F4
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation); // 0x000000018B39C7B8-0x000000018B39C80C
		[NativeMethod("SetBoneLocalRotation")]
		private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation); // 0x000000018B39C7A4-0x000000018B39C7B8
		public void SetTransformHierarchy(bool bHas); // 0x0000000185395CA8-0x0000000185395CB0
		[NativeMethod("SetHasTransformHierarchy")]
		private void SetTransformHierarchyInternal(bool bHas); // 0x0000000184B0E8C0-0x0000000184B0E910
		public bool GetBoneGlobalTRS(int avatarAssetBoneID, out AnimationTransformf trs); // 0x000000018B39AD48-0x000000018B39AD54
		[NativeMethod("GetBoneGlobalTRS")]
		private bool GetBoneGlobalTRSInternal(int avatarAssetBoneID, out AnimationTransformf trs); // 0x000000018B39ACF8-0x000000018B39AD48
		public AnimationTransformf GetBoneRootTRS(int avatarAssetBoneID); // 0x000000018B39AEAC-0x000000018B39AEF4
		[NativeMethod("GetBoneRootTRS")]
		private AnimationTransformf GetBoneRootTRSInternal(int avatarAssetBoneID); // 0x000000018B39AE74-0x000000018B39AEAC
		public AnimationTransformf GetBoneLocalTRS(int avatarAssetBoneID); // 0x000000018B39ADDC-0x000000018B39AE24
		[NativeMethod("GetBoneLocalTRS")]
		private AnimationTransformf GetBoneLocalTRSInternal(int avatarAssetBoneID); // 0x000000018B39ADA4-0x000000018B39ADDC
		[NativeMethod("SetCorrectiveBoneData")]
		public void SetCorrectiveBoneData(HGCorrectiveBoneData bindings); // 0x000000018B39CA08-0x000000018B39CA4C
		[NativeMethod("SetEnableCorrectiveBoneSystem")]
		public void SetEnableCorrectiveBoneSystem(bool enable); // 0x000000018B39CB68-0x000000018B39CBAC
		[NativeMethod("SetBlendProfileData")]
		public void SetBlendProfileData(HGAvatarBlendProfile bindings); // 0x000000018B39C710-0x000000018B39C754
		[NativeMethod("SetEnableAvatarBlendProfile")]
		public void SetEnableAvatarBlendProfile(bool enable); // 0x000000018322E650-0x000000018322E6A0
		[NativeMethod("SetSequenceLayerSkipTimeThreshold")]
		public void SetSequenceLayerSkipTimeThreshold(float value); // 0x0000000183788050-0x00000001837880A0
		[NativeMethod("GetSequenceLayerSkipTimeThreshold")]
		public float GetSequenceLayerSkipTimeThreshold(); // 0x000000018B39BAF8-0x000000018B39BB2C
		[NativeMethod("ForceUpdateCorrectiveBoneDataInEditor")]
		public void ForceUpdateCorrectiveBoneDataInEditor(); // 0x000000018B39A92C-0x000000018B39A960
		[NativeMethod("SetBakedBindingData")]
		public void SetBakedBindingData(HGAnimationSetBindings bindings); // 0x000000018B39C6CC-0x000000018B39C710
		[NativeMethod("EnableBakedBindingData")]
		public void EnableBakedBindingData(bool enable); // 0x000000018B39A844-0x000000018B39A888
		public bool SetClipByIndex(AnimationClip overrideClip, int index); // 0x000000018B39C80C-0x000000018B39C860
		public void UnloadClipsNoRebind(AnimationClip[] overrideClip, bool clearCache = true /* Metadata: 0x0234ECBD */); // 0x000000018B39DDE8-0x000000018B39DE3C
		public void ReloadClipsNoRebind(AnimationClip[] overrideClip); // 0x000000018B39C478-0x000000018B39C4BC
		public void CaptureLastHumanPose(); // 0x0000000183892500-0x0000000183892540
		public void SetWriteTransformDefAsPostProcess(bool enable); // 0x000000018322E310-0x000000018322E360
		public void SetWriteTransformDefAsPostProcessSkipOpt(bool enable); // 0x000000018B39DC94-0x000000018B39DCD8
		public void SetAnimatorJobDispatchMode(AnimatorJobDispatchMode mode); // 0x000000018408AAA0-0x000000018408AAF0
		public AnimatorJobDispatchMode GetAnimatorJobDispatchMode(); // 0x000000018B39AA58-0x000000018B39AA8C
		[NativeMethod("AddToFrameSyncGroup")]
		public bool AddToFrameSyncGroup(string groupName, bool isMaster, AnimFrameSyncMode syncMode); // 0x000000018B399A14-0x000000018B399A78
		[NativeMethod("RemoveFromFrameSyncGroup")]
		public bool RemoveFromFrameSyncGroup(); // 0x000000018B39C4BC-0x000000018B39C4F0
		public void SetEnableCollisionConstraintSolver(bool enable); // 0x000000018B39CB24-0x000000018B39CB68
		public void SetEnableDefaultValuesForceUseDefaultPose(bool enable); // 0x000000018B39CBAC-0x000000018B39CBF0
		public void SetPoseDriverSystemWeight(float weight); // 0x000000018B39D8A8-0x000000018B39D8EC
		public float GetPoseDriverSystemWeight(); // 0x000000018B39B9D4-0x000000018B39BA08
		public bool IsEnableDefaultValuesForceUseDefaultPose(); // 0x000000018B39BF74-0x000000018B39BFA8
		public void SetEnableConstantOptByDefaultPose(bool enable); // 0x0000000183FA6060-0x0000000183FA60B0
		public bool IsEnableConstantOptByDefaultPose(); // 0x000000018B39BF40-0x000000018B39BF74
		public void SetEnableWriteDefaultValues(bool enable); // 0x000000018B39CC34-0x000000018B39CC78
		public void SetEnableClipBindingOpt(bool enable); // 0x000000018B39CAE0-0x000000018B39CB24
		public void SetEnableOptBindingByAvatar(bool enable); // 0x000000018B39CBF0-0x000000018B39CC34
		public bool AddClipsToBindingsNoGrown(AnimationClip[] overrideClip, int nameHash = 0 /* Metadata: 0x0234ECBE */); // 0x000000018464E5D0-0x000000018464E630
		public void SetDynamicBindingReserveCount(int count); // 0x000000018322E360-0x000000018322E3B0
		public void SetDynamicBindingReserveCountByTag(int stringHash, int count); // 0x000000018B39CA4C-0x000000018B39CA9C
		public void ReCreatePlayableMemory(); // 0x000000018B39C430-0x000000018B39C464
		public void SetForceNonConstantBindingTransforms(Transform[] transforms); // 0x000000018B39CD64-0x000000018B39CDA8
		public AnimationTransformRWBufferHandle CreateClothBindings(Transform[] transformAccessArray); // 0x000000018B399D60-0x000000018B399DA8
		public AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(string[] transformPathArray); // 0x000000018B399CC4-0x000000018B399D0C
		public void DestroyClothBindings(); // 0x000000018B39A7DC-0x000000018B39A810
		public void EnableClothBindings(); // 0x000000018B39A888-0x000000018B39A8BC
		public void DisableClothBindings(); // 0x000000018B39A810-0x000000018B39A844
		public void SetClothBindingsEnableWorldSpace(bool value); // 0x000000018B39C860-0x000000018B39C8A4
		public bool CheckClothBindingsEnableWorldSpace(); // 0x000000018B399AAC-0x000000018B399AE0
		public void SetMorphBindingsEnableWorldSpace(bool value); // 0x000000018B39D710-0x000000018B39D754
		public bool CheckMorphBindingsEnableWorldSpace(); // 0x000000018B399BC8-0x000000018B399BFC
		public AnimationTransformRWBufferHandle CreateMorphBindings(Transform[] transformAccessArray); // 0x0000000183B6A110-0x0000000183B6A160
		public AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(string[] transformPathArray); // 0x000000018B399DFC-0x000000018B399E44
		public bool CheckMorphBindingValid([IsReadOnly] in AnimationTransformRWBufferHandle handle); // 0x000000018B399B84-0x000000018B399BC8
		public void EnableMorphBindings(); // 0x0000000183B6A0D0-0x0000000183B6A110
		public void DisableMorphBindings(); // 0x0000000184B6CCA0-0x0000000184B6CCE0
		public void SetOptimizedAvatarDataSet(bool optimized); // 0x00000001844E35C0-0x00000001844E3610
		public void SetEnabelMorphBindingWriteInLateUpdate(bool enable); // 0x000000018B39CA9C-0x000000018B39CAE0
		private ScriptableObject GetBehaviour([NotNull("ArgumentNullException")] System.Type type); // 0x000000018B39AC0C-0x000000018B39AC50
		public T GetBehaviour<T>()
			where T : StateMachineBehaviour;
		private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects)
			where T : StateMachineBehaviour;
		public T[] GetBehaviours<T>()
			where T : StateMachineBehaviour;
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehaviours([NotNull("ArgumentNullException")] System.Type type); // 0x000000018B39BC00-0x000000018B39BC44
		public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex); // 0x000000018B39AC50-0x000000018B39ACF8
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, [NotNull("ArgumentNullException")] System.Type type); // 0x000000018B39BBA0-0x000000018B39BC00
		public string GetLayerName(int layerIndex); // 0x000000018485A130-0x000000018485A180
		public int GetLayerIndex(string layerName); // 0x000000018378A7D0-0x000000018378A820
		public float GetLayerWeight(int layerIndex); // 0x000000018B39B810-0x000000018B39B850
		public void SetLayerWeight(int layerIndex, float weight); // 0x000000018413A9F0-0x000000018413AA50
		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info); // 0x000000018300E630-0x000000018300E6A0
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex); // 0x000000018300E580-0x000000018300E630
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex); // 0x000000018300E4E0-0x000000018300E580
		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info); // 0x000000018B39AB3C-0x000000018B39AB8C
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex); // 0x000000018B39AB8C-0x000000018B39ABE0
		internal int GetAnimatorClipInfoCount(int layerIndex, bool current); // 0x000000018B39A9A4-0x000000018B39A9F8
		public int GetCurrentAnimatorClipInfoCount(int layerIndex); // 0x000000018B39B04C-0x000000018B39B05C
		public int GetNextAnimatorClipInfoCount(int layerIndex); // 0x000000018B39B8FC-0x000000018B39B90C
		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex); // 0x000000018B39B0D4-0x000000018B39B114
		[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex); // 0x000000018B39B984-0x000000018B39B9C4
		public bool GetDebugAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018B39B29C-0x000000018B39B308
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018B39B05C-0x000000018B39B0D4
		[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
		private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips); // 0x000000018B39A9F8-0x000000018B39AA58
		[FreeFunction(Name = "AnimatorBindings::GetDebugAnimatorClipInfoInternal", HasExplicitThis = true)]
		private bool GetDebugAnimatorClipInfoInternal(int layerIndex, object clips); // 0x000000018B39B24C-0x000000018B39B29C
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips); // 0x000000018B39B90C-0x000000018B39B984
		public bool IsInTransition(int layerIndex); // 0x000000018300E6A0-0x000000018300E6F0
		public bool IsPlayingTag(int layerIndex, int tagHash); // 0x000000018343E5E0-0x000000018343E640
		public bool IsPlayingState(int layerIndex, int stateNameHash); // 0x0000000183008F60-0x0000000183008FC0
		public int GetAnimatorStateCullMode(int layerIndex); // 0x000000018343EA60-0x000000018343EAB0
		public AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(int layerIndex); // 0x000000018B39B114-0x000000018B39B1C4
		private void GetAnimatorStateRootMotionInfo(int layerIndex, out AnimatorStateRootMotionInfo output); // 0x000000018B39AAEC-0x000000018B39AB3C
		public bool HasTrigger(int triggerId); // 0x000000018B39BB60-0x000000018B39BBA0
		[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = true)]
		private AnimatorControllerParameter GetParameterInternal(int index); // 0x00000001841CCA50-0x00000001841CCAA0
		public AnimatorControllerParameter GetParameter(int index); // 0x00000001841CCA10-0x00000001841CCA50
		private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch); // 0x000000018B39C1D4-0x000000018B39C224
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime); // 0x000000018B39C158-0x000000018B39C1D4
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime); // 0x000000018B39C0DC-0x000000018B39C158
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime, [UnityEngine.Internal.DefaultValue("true")] bool completeMatch); // 0x000000018B39C224-0x000000018B39C2A8
		public void InterruptMatchTarget(); // 0x000000018B39BEF0-0x000000018B39BEFC
		public void InterruptMatchTarget([UnityEngine.Internal.DefaultValue("true")] bool completeMatch); // 0x000000018B39BEAC-0x000000018B39BEF0
		[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
		public void ForceStateNormalizedTime(float normalizedTime); // 0x000000018B39A90C-0x000000018B39A92C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration); // 0x000000018B39A1E8-0x000000018B39A238
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer); // 0x000000018B399FAC-0x000000018B39A008
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset); // 0x000000018B39A0B8-0x000000018B39A11C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A008-0x000000018B39A078
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B399EB0-0x000000018B399F28
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion); // 0x000000018B39A238-0x000000018B39A2BC
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B399F28-0x000000018B399FAC
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime); // 0x000000018B39A078-0x000000018B39A0B8
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset); // 0x000000018B39A11C-0x000000018B39A158
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer); // 0x000000018B399E44-0x000000018B399E78
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration); // 0x000000018B399E78-0x000000018B399EB0
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A158-0x000000018B39A1A4
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x0000000183D70D00-0x0000000183D70D50
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A1A4-0x000000018B39A1E8
		[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = true)]
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion); // 0x0000000183D710E0-0x0000000183D71160
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = true)]
		public void WriteDefaultValues(); // 0x000000018B39DE70-0x000000018B39DEA4
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValuesDirty", HasExplicitThis = true)]
		public void WriteDefaultValuesDirty(); // 0x0000000184A31860-0x0000000184A318A0
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime); // 0x000000018B39A694-0x000000018B39A6D0
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset); // 0x000000018B39A3AC-0x000000018B39A3E4
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer); // 0x000000018B39A378-0x000000018B39A3AC
		public void CrossFade(string stateName, float normalizedTransitionDuration); // 0x000000018B39A60C-0x000000018B39A648
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion); // 0x000000018B39A6D0-0x000000018B39A754
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A2BC-0x000000018B39A33C
		public void CrossFade(string stateName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A510-0x000000018B39A588
		public void CrossFade(string stateName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A588-0x000000018B39A60C
		[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion); // 0x000000018B39A470-0x000000018B39A4D0
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime); // 0x000000018B39A3E4-0x000000018B39A424
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset); // 0x000000018B39A754-0x000000018B39A790
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer); // 0x000000018B39A33C-0x000000018B39A378
		public void CrossFade(int stateHashName, float normalizedTransitionDuration); // 0x000000018B39A4D0-0x000000018B39A510
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A648-0x000000018B39A694
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A424-0x000000018B39A470
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource); // 0x000000018B39A790-0x000000018B39A7DC
		[FreeFunction(Name = "AnimatorBindings::ResetToDefaultStates", HasExplicitThis = true)]
		public void ResetToDefaultStates(); // 0x0000000184CDE4F0-0x0000000184CDE570
		public void PlayInFixedTime(string stateName, int layer); // 0x000000018B39C3A8-0x000000018B39C3C8
		public void PlayInFixedTime(string stateName); // 0x000000018B39C330-0x000000018B39C358
		public void PlayInFixedTime(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime); // 0x000000018B39C358-0x000000018B39C3A8
		[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = true)]
		public void PlayInFixedTime(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime); // 0x000000018495ABA0-0x000000018495AC10
		public void PlayInFixedTime(int stateNameHash, int layer); // 0x000000018B39C310-0x000000018B39C330
		public void PlayInFixedTime(int stateNameHash); // 0x000000018B39C3C8-0x000000018B39C3F0
		public void Play(string stateName, int layer); // 0x000000018B39C3F0-0x000000018B39C410
		public void Play(string stateName); // 0x00000001831CEA20-0x00000001831CEA50
		public void Play(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime); // 0x00000001831CEA50-0x00000001831CEAA0
		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime); // 0x00000001831CEAA0-0x00000001831CEB10
		public void Play(int stateNameHash, int layer); // 0x000000018B39C410-0x000000018B39C430
		public void Play(int stateNameHash); // 0x00000001834FCD00-0x00000001834FCD30
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime); // 0x000000018B39DC3C-0x000000018B39DC8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", true)]
		public bool IsControlled(Transform transform); // 0x0000000184D85B20-0x0000000184D85B30
		internal bool IsBoneTransform(Transform transform); // 0x000000018B39BEFC-0x000000018B39BF40
		public Transform GetBoneTransform(HumanBodyBones humanBoneId); // 0x000000018B39AF34-0x000000018B39AFFC
		[NativeMethod("GetBoneTransform")]
		internal Transform GetBoneTransformInternal(int humanBoneId); // 0x000000018B39AEF4-0x000000018B39AF34
		public Transform GetBoneTransformByBoneId(int boneID); // 0x00000001839C7AE0-0x00000001839C7B00
		[NativeMethod("GetBoneTransformByBoneId")]
		internal Transform GetBoneTransformByBoneIdInternal(int boneId); // 0x00000001839C7A90-0x00000001839C7AE0
		public void StartPlayback(); // 0x000000018B39DCD8-0x000000018B39DD0C
		public void StopPlayback(); // 0x000000018B39DD4C-0x000000018B39DD80
		public void StartRecording(int frameCount); // 0x000000018B39DD0C-0x000000018B39DD4C
		public void StopRecording(); // 0x000000018B39DD80-0x000000018B39DDB4
		private float GetRecorderStartTime(); // 0x000000018B39BA28-0x000000018B39BA5C
		private float GetRecorderStopTime(); // 0x000000018B39BA5C-0x000000018B39BA90
		internal void ClearInternalControllerPlayable(); // 0x000000018B399BFC-0x000000018B399C30
		public bool HasState(int layerIndex, int stateID); // 0x000000018322C0A0-0x000000018322C100
		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name); // 0x0000000183B06430-0x0000000183B06470
		[NativeMethod(Name = "StringToHashCRC32", IsThreadSafe = true)]
		public static int StringToHashCRC32(IntPtr name); // 0x000000018B39DDB4-0x000000018B39DDE8
		internal string GetStats(); // 0x000000018B39BB2C-0x000000018B39BB60
		[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = true)]
		private void GetCurrentGraph(ref PlayableGraph graph); // 0x000000018B39B1C4-0x000000018B39B208
		private void CheckIfInIKPass(); // 0x000000018B399B14-0x000000018B399B84
		private bool IsInIKPass(); // 0x000000018B39BFA8-0x000000018B39BFDC
		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private void SetFloatString(string name, float value); // 0x0000000183DF2D80-0x0000000183DF2DE0
		[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private void SetFloatID(int id, float value); // 0x0000000183BDEE90-0x0000000183BDEEF0
		[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
		private float GetFloatString(string name); // 0x00000001840B91E0-0x00000001840B9370
		[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
		private float GetFloatID(int id); // 0x0000000183A09690-0x0000000183A096E0
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByID", HasExplicitThis = true)]
		private float GetFloatFromTransitionByID(int layerIndex, int id); // 0x000000018B39B308-0x000000018B39B358
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByIDWithDefault", HasExplicitThis = true)]
		private float GetFloatFromTransitionByIDWithDefault(int layerIndex, int id, float defValue); // 0x00000001843EE130-0x00000001843EE1A0
		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private void SetBoolString(string name, bool value); // 0x00000001846F7D80-0x00000001846F7DE0
		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private void SetBoolID(int id, bool value); // 0x000000018408E410-0x000000018408E470
		[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = true)]
		private bool GetBoolString(string name); // 0x000000018B39AFFC-0x000000018B39B040
		[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
		private bool GetBoolID(int id); // 0x0000000183FA3EE0-0x0000000183FA3F30
		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		private void SetIntegerString(string name, int value); // 0x000000018B39D174-0x000000018B39D1C8
		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		private void SetIntegerID(int id, int value); // 0x00000001844E7160-0x00000001844E71C0
		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		private int GetIntegerString(string name); // 0x000000018B39B780-0x000000018B39B7C4
		[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
		private int GetIntegerID(int id); // 0x0000000184072CD0-0x0000000184072D20
		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name); // 0x00000001841ECAE0-0x00000001841ECB30
		[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		private void SetTriggerID(int id); // 0x00000001845C8690-0x00000001845C86E0
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name); // 0x0000000183F82A30-0x0000000183F82A80
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
		private void ResetTriggerID(int id); // 0x0000000183B5B250-0x0000000183B5B2A0
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveString(string name); // 0x000000018B39C01C-0x000000018B39C060
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveID(int id); // 0x000000018B39BFDC-0x000000018B39C01C
		[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = true)]
		private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime); // 0x000000018B39CCD8-0x000000018B39CD3C
		[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = true)]
		private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime); // 0x000000018B39CC78-0x000000018B39CCD8
		public HGAnimParameterSGHandle[] GetHGParameterHandles(); // 0x000000018B39B4E4-0x000000018B39B518
		public bool CheckHGParmeterHandleValid(); // 0x000000018B399AE0-0x000000018B399B14
		[NativeMethod("GetMorphBoneCount")]
		public int GetMorphBoneCount(); // 0x000000018B39B850-0x000000018B39B884
		public void GetMorphBoneIds(NativeArray<int> arrayToFill); // 0x000000018B39B8D8-0x000000018B39B8FC
		public void GetMorphBoneIdsUnsafe(int count, NativeArray<int> arrayToFill); // 0x000000018B39B884-0x000000018B39B8D8
		[NativeMethod("Internal_GetMorphBoneIds")]
		private void Internal_GetMorphBoneIds(int count, IntPtr arrayToFill); // 0x000000018B39BCB0-0x000000018B39BD00
		public void SetMorphTransforms(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale); // 0x000000018B39D850-0x000000018B39D8A8
		public void SetMorphTransformsUnsafe(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale); // 0x000000018B39D754-0x000000018B39D850
		[NativeMethod("Internal_SetMorphTransforms")]
		private void Internal_SetMorphTransforms(int count, IntPtr boneIds, IntPtr translation, IntPtr euler, IntPtr scale); // 0x000000018B39BD60-0x000000018B39BDC0
		[NativeConditional("UNITY_EDITOR")]
		internal void OnUpdateModeChanged(); // 0x000000018B39C2DC-0x000000018B39C310
		[NativeConditional("UNITY_EDITOR")]
		internal void OnCullingModeChanged(); // 0x000000018B39C2A8-0x000000018B39C2DC
		[NativeConditional("UNITY_EDITOR")]
		internal void WriteDefaultPose(); // 0x000000018B39DE3C-0x000000018B39DE70
		[NativeMethod("UpdateWithDelta")]
		public void Update(float deltaTime); // 0x000000018378AA50-0x000000018378AAA0
		[NativeMethod("ForceUpdateWithDelta")]
		public void ForceUpdate(float deltaTime); // 0x000000018B39A960-0x000000018B39A9A4
		public void Rebind(); // 0x000000018B39C464-0x000000018B39C470
		private void Rebind(bool writeDefaultValues); // 0x00000001849BBFC0-0x00000001849BC010
		public void ApplyBuiltinRootMotion(); // 0x000000018B399A78-0x000000018B399AAC
		[NativeConditional("UNITY_EDITOR")]
		internal void EvaluateController(); // 0x000000018B39A900-0x000000018B39A90C
		private void EvaluateController(float deltaTime); // 0x000000018B39A8BC-0x000000018B39A900
		[NativeConditional("UNITY_EDITOR")]
		internal string GetCurrentStateName(int layerIndex); // 0x000000018B39B23C-0x000000018B39B24C
		[NativeConditional("UNITY_EDITOR")]
		internal string GetNextStateName(int layerIndex); // 0x000000018B39B9C4-0x000000018B39B9D4
		[NativeConditional("UNITY_EDITOR")]
		private string GetAnimatorStateName(int layerIndex, bool current); // 0x000000018B39AA98-0x000000018B39AAEC
		internal string ResolveHash(int hash); // 0x000000018B39C4F0-0x000000018B39C530
		public string GetAnimatorStateName(int stateID); // 0x000000018B39AA8C-0x000000018B39AA98
		public void GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime = 0f /* Metadata: 0x0234ECBF */, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x0234ECC3 */); // 0x0000000185397594-0x00000001853975A4
		public void GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x0234ECC4 */); // 0x0000000185396E48-0x0000000185396E58
		public void SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x0234ECC5 */); // 0x0000000185391A5C-0x0000000185391A70
		public void RefreshStateOverride(RuntimeAnimatorStateOverride stateOverride); // 0x0000000185396E40-0x0000000185396E48
		public void SetRuntimeControllerNoRebind(RuntimeAnimatorController controller); // 0x0000000185393BF0-0x0000000185393BF8
		public void RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride); // 0x000000018B39C470-0x000000018B39C478
		[NativeMethod("GotoState")]
		internal void Internal_GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime, AnimationBlendStyle blendStyle); // 0x0000000184970B70-0x0000000184970BE0
		[NativeMethod("GotoStateInFixedTime")]
		internal void Internal_GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle); // 0x00000001849C7590-0x00000001849C7600
		[NativeMethod("SetAnimationStateOverride")]
		internal void Internal_SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x0234ECC6 */); // 0x00000001845DFE50-0x00000001845DFEB0
		[NativeMethod("RefreshAnimationStateOverride")]
		internal void Internal_RefreshAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride); // 0x0000000184654110-0x0000000184654160
		[NativeMethod("SetRuntimeControllerNoRebind")]
		internal void Internal_SetRuntimeControllerNoRebind(RuntimeAnimatorController controller); // 0x00000001847DAB80-0x00000001847DABD0
		[NativeMethod("RefreshAnimationStateAsyncCompleteOverride")]
		internal void Internal_RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride); // 0x0000000184A3DAA0-0x0000000184A3DAF0
		public void SetAvatarNoBind(Avatar avatar); // 0x000000018B39C6C4-0x000000018B39C6CC
		[NativeMethod("SetAvatarNoBind")]
		internal void Internal_SetAvatarNoBind(Avatar avatar); // 0x00000001844E3610-0x00000001844E3660
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name); // 0x00000001832C6EA0-0x00000001832C6EC0
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id); // 0x00000001832C6EA0-0x00000001832C6EC0
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value); // 0x00000001841E1670-0x00000001841E1680
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value); // 0x00000001841E1670-0x00000001841E1680
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name); // 0x000000018B39BA08-0x000000018B39BA28
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id); // 0x000000018B39BA08-0x000000018B39BA28
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value); // 0x00000001841E1670-0x00000001841E1680
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value); // 0x00000001841E1670-0x00000001841E1680
		private void Internal_SetRetargetScale_Injected(int[] boneNameHashes, int count, ref Vector3 scaleFactor, int[] boneModes); // 0x000000018B39BE24-0x000000018B39BE88
		private void get_deltaPosition_Injected(out Vector3 ret); // 0x000000018343D850-0x000000018343D8A0
		private void get_deltaRotation_Injected(out Quaternion ret); // 0x000000018343CE60-0x000000018343CEB0
		private void get_velocity_Injected(out Vector3 ret); // 0x000000018343D6F0-0x000000018343D740
		private void get_angularVelocity_Injected(out Vector3 ret); // 0x000000018343D7A0-0x000000018343D7F0
		private void get_rootPosition_Injected(out Vector3 ret); // 0x000000018B39E830-0x000000018B39E874
		private void set_rootPosition_Injected(ref Vector3 value); // 0x000000018B39F098-0x000000018B39F0DC
		private void get_rootRotation_Injected(out Quaternion ret); // 0x000000018B39E8A0-0x000000018B39E8E4
		private void set_rootRotation_Injected(ref Quaternion value); // 0x000000018B39F0F0-0x000000018B39F134
		private void get_bodyPositionInternal_Injected(out Vector3 ret); // 0x000000018B39DFD8-0x000000018B39E01C
		private void set_bodyPositionInternal_Injected(ref Vector3 value); // 0x000000018B39EBAC-0x000000018B39EBF0
		private void get_bodyRotationInternal_Injected(out Quaternion ret); // 0x000000018B39E098-0x000000018B39E0DC
		private void set_bodyRotationInternal_Injected(ref Quaternion value); // 0x000000018B39EC48-0x000000018B39EC8C
		private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret); // 0x000000018B39B364-0x000000018B39B3B4
		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition); // 0x000000018B39CDA8-0x000000018B39CDF8
		private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret); // 0x000000018B39B3E4-0x000000018B39B434
		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation); // 0x000000018B39CE0C-0x000000018B39CE5C
		private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret); // 0x000000018B39B518-0x000000018B39B568
		private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition); // 0x000000018B39CF10-0x000000018B39CF60
		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition); // 0x000000018B39D3F0-0x000000018B39D434
		private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation); // 0x000000018B39C754-0x000000018B39C7A4
		private void GetBoneRootTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret); // 0x000000018B39AE24-0x000000018B39AE74
		private void GetBoneLocalTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret); // 0x000000018B39AD54-0x000000018B39ADA4
		private void CreateClothBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret); // 0x000000018B399D0C-0x000000018B399D60
		private void CreateClothBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret); // 0x000000018B399C70-0x000000018B399CC4
		private void CreateMorphBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret); // 0x0000000183B6A070-0x0000000183B6A0D0
		private void CreateMorphBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret); // 0x000000018B399DA8-0x000000018B399DFC
		private void get_pivotPosition_Injected(out Vector3 ret); // 0x000000018B39E66C-0x000000018B39E6B0
		private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch); // 0x000000018B39C078-0x000000018B39C0DC
		private void get_targetPosition_Injected(out Vector3 ret); // 0x000000018B39E9AC-0x000000018B39E9F0
		private void get_targetRotation_Injected(out Quaternion ret); // 0x000000018B39EA1C-0x000000018B39EA60
	}

	[NativeAsStruct]
	[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
	[UsedByNativeCode]
	public class AnimatorControllerParameter // TypeDefIndex: 60583
	{
		// Fields
		internal string m_Name; // 0x10
		internal AnimatorControllerParameterType m_Type; // 0x18
		internal float m_DefaultFloat; // 0x1C
		internal int m_DefaultInt; // 0x20
		internal bool m_DefaultBool; // 0x24
	
		// Properties
		public string name { get; } // 0x0000000184D9B600-0x0000000184D9B610 
		public int nameHash { get; } // 0x0000000185393844-0x0000000185393854 
		public AnimatorControllerParameterType type { get; } // 0x0000000184D9D860-0x0000000184D9D870 
	
		// Constructors
		public AnimatorControllerParameter(); // 0x000000018B3986B0-0x000000018B3986F0
	
		// Methods
		public override bool Equals(object o); // 0x000000018B398618-0x000000018B3986B0
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
	}

	[Serializable]
	[Obsolete("This class is not used anymore. See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
	public class AnimationClipPair // TypeDefIndex: 60584
	{
		// Fields
		public AnimationClip originalClip; // 0x10
		public AnimationClip overrideClip; // 0x18
	
		// Constructors
		public AnimationClipPair(); // 0x00000001841E1670-0x00000001841E1680
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[UsedByNativeCode]
	public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 60586
	{
		// Fields
		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18
	
		// Properties
		public RuntimeAnimatorController runtimeAnimatorController { [NativeMethod("GetAnimatorController")] get; [NativeMethod("SetAnimatorController")] set; } // 0x000000018B399808-0x000000018B39983C 0x000000018B399964-0x000000018B3999A8
		public AnimationClip this[string name] { get => default; set {} } // 0x000000018B399614-0x000000018B399624 0x000000018B399858-0x000000018B399860
		public AnimationClip this[AnimationClip clip] { get => default; set {} } // 0x000000018B399604-0x000000018B399614 0x000000018B39983C-0x000000018B399858
		public bool enableBindingOpt { [NativeMethod("GetEnableClipBindingOpt")] get; [NativeMethod("SetEnableClipBindingOpt")] set; } // 0x000000018B39976C-0x000000018B3997A0 0x000000018B3998DC-0x000000018B399920
		public byte reserveCount { [NativeMethod("GetReserveCount")] get; [NativeMethod("SetReserveCount")] set; } // 0x000000018B3997D4-0x000000018B399808 0x000000018B399920-0x000000018B399964
		public int overridesCount { [NativeMethod("GetOriginalClipsCount")] get; } // 0x000000018B3997A0-0x000000018B3997D4 
		[Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
		public AnimationClipPair[] clips { get; set; } // 0x000000018B399624-0x000000018B39976C 0x000000018B399860-0x000000018B3998DC
	
		// Nested types
		internal delegate void OnOverrideControllerDirtyCallback(); // TypeDefIndex: 60585; 0x00000001853DEDB8-0x00000001853DEDC8
	
		// Constructors
		public AnimatorOverrideController(); // 0x000000018B399590-0x000000018B3995C4
		public AnimatorOverrideController(RuntimeAnimatorController controller); // 0x000000018B3995C4-0x000000018B399604
	
		// Methods
		[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
		private static void Internal_Create([Writable] AnimatorOverrideController self, RuntimeAnimatorController controller); // 0x000000018B3993AC-0x000000018B3993F0
		[NativeMethod("GetClip")]
		private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip); // 0x000000018B3993F0-0x000000018B399444
		[NativeMethod("SetClip")]
		private void Internal_SetClipByName(string name, AnimationClip clip); // 0x000000018B399444-0x000000018B399498
		private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip); // 0x000000018B399150-0x000000018B3991A4
		private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify); // 0x000000018B39952C-0x000000018B399590
		private void SendNotification(); // 0x000000018B3994F8-0x000000018B39952C
		private AnimationClip GetOriginalClip(int index); // 0x000000018B3991A4-0x000000018B3991E4
		private AnimationClip GetOverrideClip(AnimationClip originalClip); // 0x000000018B3991E4-0x000000018B399228
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides); // 0x000000018B399228-0x000000018B3993AC
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides); // 0x000000018B399024-0x000000018B399150
		[NativeConditional("UNITY_EDITOR")]
		internal void PerformOverrideClipListCleanup(); // 0x000000018B3994C4-0x000000018B3994F8
		[NativeConditional("UNITY_EDITOR")]
		[RequiredByNativeCode]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller); // 0x000000018B399498-0x000000018B3994C4
	}

	[NativeHeader("Modules/Animation/OptimizeTransformHierarchy.h")]
	public class AnimatorUtility // TypeDefIndex: 60587
	{
		// Methods
		[FreeFunction]
		public static void OptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go, string[] exposedTransforms); // 0x00000001844E3660-0x00000001844E36B0
		[FreeFunction]
		public static void DeoptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go); // 0x0000000183DD01B0-0x0000000183DD01F0
	}

	public enum HumanBodyBones // TypeDefIndex: 60588
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
	public struct AnimationTransformf // TypeDefIndex: 60589
	{
		// Fields
		public Vector3 t; // 0x00
		public Quaternion q; // 0x0C
		public Vector3 s; // 0x1C
	}

	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : UnityEngine.Object // TypeDefIndex: 60590
	{
		// Properties
		public bool isValid { [NativeMethod("IsValid")] get; } // 0x00000001839C9A80-0x00000001839C9AC0 
		public bool isHuman { [NativeMethod("IsHuman")] get; } // 0x00000001839C7C40-0x00000001839C7C80 
		public HumanDescription humanDescription { get; } // 0x000000018B39F944-0x000000018B39F97C 
	
		// Constructors
		private Avatar(); // 0x000000018B39F8C0-0x000000018B39F900
	
		// Methods
		internal void SetMuscleMinMax(int muscleId, float min, float max); // 0x000000018B39F810-0x000000018B39F870
		internal void SetParameter(int parameterId, float value); // 0x000000018B39F870-0x000000018B39F8C0
		internal float GetAxisLength(int humanId); // 0x000000018B39F2DC-0x000000018B39F304
		internal Quaternion GetPreRotation(int humanId); // 0x000000018B39F3D4-0x000000018B39F41C
		internal Quaternion GetPostRotation(int humanId); // 0x000000018B39F38C-0x000000018B39F3D4
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q); // 0x000000018B39F41C-0x000000018B39F4A0
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw); // 0x000000018B39F4A0-0x000000018B39F510
		internal Vector3 GetLimitSign(int humanId); // 0x000000018B39F338-0x000000018B39F38C
		[NativeMethod("GetAxisLength")]
		internal float Internal_GetAxisLength(int humanId); // 0x000000018B39F510-0x000000018B39F550
		[NativeMethod("GetPreRotation")]
		internal Quaternion Internal_GetPreRotation(int humanId); // 0x000000018B39F6A0-0x000000018B39F6D0
		[NativeMethod("GetPostRotation")]
		internal Quaternion Internal_GetPostRotation(int humanId); // 0x000000018B39F620-0x000000018B39F650
		[NativeMethod("GetZYPostQ")]
		internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q); // 0x000000018B39F730-0x000000018B39F774
		[NativeMethod("GetZYRoll")]
		internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw); // 0x000000018B39F7D4-0x000000018B39F810
		[NativeMethod("GetLimitSign")]
		internal Vector3 Internal_GetLimitSign(int humanId); // 0x000000018B39F5A0-0x000000018B39F5D0
		[NativeMethod("GetBonePaths")]
		public string[] GetBonePaths(); // 0x000000018B39F304-0x000000018B39F338
		private void get_humanDescription_Injected(out HumanDescription ret); // 0x000000018B39F900-0x000000018B39F944
		private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret); // 0x000000018B39F650-0x000000018B39F6A0
		private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret); // 0x000000018B39F5D0-0x000000018B39F620
		private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret); // 0x000000018B39F6D0-0x000000018B39F730
		private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret); // 0x000000018B39F774-0x000000018B39F7D4
		private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret); // 0x000000018B39F550-0x000000018B39F5A0
	}

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[RequiredByNativeCode]
	public struct SkeletonBone // TypeDefIndex: 60591
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
	public struct HumanLimit // TypeDefIndex: 60592
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
	public struct HumanBone // TypeDefIndex: 60593
	{
		// Fields
		private string m_BoneName; // 0x00
		private string m_HumanName; // 0x08
		[NativeName("m_Limit")]
		public HumanLimit limit; // 0x10
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct HumanDescription // TypeDefIndex: 60594
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
	public enum AvatarMaskBodyPart // TypeDefIndex: 60595
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
	[NativeHeader("Modules/Animation/AvatarMask.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public sealed class AvatarMask : UnityEngine.Object // TypeDefIndex: 60596
	{
		// Properties
		public int transformCount { get; } // 0x000000018B39F2A8-0x000000018B39F2DC 
	
		// Methods
		[NativeMethod("GetBodyPart")]
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index); // 0x000000018B39F1CC-0x000000018B39F20C
		public string GetTransformPath(int index); // 0x000000018B39F228-0x000000018B39F268
		private float GetTransformWeight(int index); // 0x000000018B39F268-0x000000018B39F2A8
		public bool GetTransformActive(int index); // 0x000000018B39F20C-0x000000018B39F228
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/HGAnimationSetBinding.h")]
	[UsedByNativeCode]
	public class HGAnimationSetBindings : UnityEngine.Object // TypeDefIndex: 60597
	{
	}

	[Serializable]
	[NativeHeader("Modules/Animation/HGAnimExtra/HGAvatarBlendProfile.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGAvatarBlendProfile : UnityEngine.Object // TypeDefIndex: 60598
	{
		// Constructors
		public HGAvatarBlendProfile(); // 0x000000018B39F9B0-0x000000018B39F9FC
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHGAvatarBlendProfile")]
		private static void Internal_Create([Writable] HGAvatarBlendProfile self); // 0x000000018B39F97C-0x000000018B39F9B0
	}

	[Serializable]
	[NativeHeader("Modules/Animation/HGAnimExtra/HGCorrectiveBoneData.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGCorrectiveBoneData : UnityEngine.Object // TypeDefIndex: 60599
	{
		// Constructors
		public HGCorrectiveBoneData(); // 0x000000018B39FA30-0x000000018B39FA7C
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHGAnimCorrectiveBoneData")]
		private static void Internal_Create([Writable] HGCorrectiveBoneData self); // 0x000000018B39F9FC-0x000000018B39FA30
	}

	[NativeHeader("Modules/Animation/HGSkeletalMorphAvatar.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/SkeletalMorph.bindings.h")]
	[UsedByNativeCode]
	public sealed class HGSkeletalMorphAvatar : UnityEngine.Object // TypeDefIndex: 60600
	{
		// Constructors
		private HGSkeletalMorphAvatar(); // 0x000000018B39FAB0-0x000000018B39FAFC
	
		// Methods
		[FreeFunction("SkeletalMorphBindings::CreateSkeletalMorphAvatar")]
		private static void Internal_Create([Writable] HGSkeletalMorphAvatar self); // 0x000000018B39FA7C-0x000000018B39FAB0
	}

	public struct HumanPose // TypeDefIndex: 60601
	{
		// Fields
		public Vector3 bodyPosition; // 0x00
		public Quaternion bodyRotation; // 0x0C
		public float[] muscles; // 0x20
	
		// Methods
		internal void Init(); // 0x000000018B39FED8-0x000000018B39FFDC
	}

	[NativeHeader("Modules/Animation/HumanPoseHandler.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public class HumanPoseHandler : IDisposable // TypeDefIndex: 60602
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public HumanPoseHandler(Avatar avatar, Transform root); // 0x000000018B39FCCC-0x000000018B39FED8
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHumanPoseHandler")]
		private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root); // 0x000000018B39FC54-0x000000018B39FC98
		[FreeFunction("AnimationBindings::DestroyHumanPoseHandler")]
		private static void Internal_Destroy(IntPtr ptr); // 0x000000018B39FC98-0x000000018B39FCCC
		private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, out float[] muscles); // 0x000000018B39FB54-0x000000018B39FBB8
		public void Dispose(); // 0x000000018B39FAFC-0x000000018B39FB54
		public void GetHumanPose(ref HumanPose humanPose); // 0x000000018B39FBB8-0x000000018B39FC54
	}

	[NativeHeader("Modules/Animation/HumanTrait.h")]
	public class HumanTrait // TypeDefIndex: 60603
	{
		// Properties
		public static int MuscleCount { get; } // 0x000000018B3A0010-0x000000018B3A003C 
		public static string[] MuscleName { [NativeMethod("GetMuscleNames")] get; } // 0x000000018B3A003C-0x000000018B3A0068 
	
		// Methods
		internal static int GetBoneIndexFromMono(int humanId); // 0x000000018B39FFDC-0x000000018B3A0010
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/LodBoneMask.h")]
	[UsedByNativeCode]
	public class LodBoneMask : UnityEngine.Object // TypeDefIndex: 60604
	{
		// Constructors
		public LodBoneMask(); // 0x000000018B3A009C-0x000000018B3A00E8
	
		// Methods
		[FreeFunction("AnimationBindings::CreateLodBoneMask")]
		private static void Internal_Create([Writable] LodBoneMask self); // 0x000000018B3A0068-0x000000018B3A009C
	}

	[NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : UnityEngine.Object // TypeDefIndex: 60605
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool _isAnimatorMotion_k__BackingField; // 0x18
	
		// Properties
		public bool isLooping { [NativeMethod("IsLooping")] get; } // 0x00000001839F6F80-0x00000001839F6FC0 
	
		// Constructors
		protected Motion(); // 0x0000000183695570-0x0000000183695590
	}

	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorController : UnityEngine.Object // TypeDefIndex: 60606
	{
		// Properties
		public AnimationClip[] animationClips { get; } // 0x0000000184CDE3B0-0x0000000184CDE3F0 
	
		// Constructors
		protected RuntimeAnimatorController(); // 0x000000018B3A08B8-0x000000018B3A08F8
	}

	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorStateOverride.h")]
	[NativeType("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorStateOverride : UnityEngine.Object // TypeDefIndex: 60607
	{
		// Constructors
		public RuntimeAnimatorStateOverride(); // 0x000000018322E2A0-0x000000018322E2D0
	
		// Methods
		[FreeFunction("RuntimeAnimatorStateOverride::Internal_Create")]
		private static void Internal_Create([Writable] RuntimeAnimatorStateOverride self); // 0x000000018322E2D0-0x000000018322E310
		public void SetClip(int stateID, AnimationClip overrideClip); // 0x0000000185393BD0-0x0000000185393BD8
		public void SetClipAsync(int stateID, float length, bool isHumanoid); // 0x0000000185393BD8-0x0000000185393BE8
		public void RemoveClip(int stateID); // 0x000000018B3A0978-0x000000018B3A0980
		public void ClearClip(); // 0x0000000185393BE8-0x0000000185393BF0
		public bool PreloadClip(AnimationClip clipB); // 0x0000000185393BC4-0x0000000185393BD0
		public void SetTransition(int transUserNameID, float transitionDuration, float transitionOffset, float exitTime); // 0x0000000185393560-0x0000000185393570
		public void RemoveTransition(int transUserNameID); // 0x000000018B3A0980-0x000000018B3A0988
		public void SetSyncGroupCurve(uint clipNameID, AnimationCurve curve); // 0x0000000185391A54-0x0000000185391A5C
		[NativeMethod("SetClip")]
		internal void Internal_SetClip(uint stateID, AnimationClip overrideClip); // 0x00000001845304F0-0x0000000184530610
		[NativeMethod("SetClipAsync")]
		internal void Internal_SetClipAsync(uint stateID, float length, bool isHumanoid); // 0x0000000184640880-0x0000000184640920
		[NativeMethod("RemoveClip")]
		internal void Internal_RemoveClip(uint stateID); // 0x000000018B3A08F8-0x000000018B3A0938
		[NativeMethod("ClearClip")]
		internal void Internal_ClearClip(); // 0x00000001849B8A50-0x00000001849B8A90
		[NativeMethod("PreloadClip")]
		internal bool Internal_PreloadClip(AnimationClip clipB); // 0x000000018455DEF0-0x000000018455DF40
		[NativeMethod("SetTransition")]
		internal void Internal_SetTransition(uint transUserNameID, float transitionDuration, float transitionOffset, float exitTime); // 0x0000000184416620-0x0000000184416690
		[NativeMethod("RemoveTransition")]
		internal void Internal_RemoveTransition(uint transUserNameID); // 0x000000018B3A0938-0x000000018B3A0978
		[NativeMethod("SetSyncGroupCurve")]
		internal void Internal_SetSyncGroupCurve(uint clipNameID, AnimationCurve curve); // 0x00000001840E0620-0x00000001840E0680
	}
}

namespace UnityEngine.Animations
{
	public static class AnimationPlayableBinding // TypeDefIndex: 60610
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key); // 0x000000018441D9A0-0x000000018441DAE0
		private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name); // 0x0000000184D2B9A0-0x0000000184D2B9F0
	}

	[AttributeUsage(AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 60611
	{
	}

	[JobProducerType(typeof(ProcessAnimationJobStruct<T>))]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationJob // TypeDefIndex: 60612
	{
		// Methods
		void ProcessAnimation(AnimationStream stream);
		void ProcessRootMotion(AnimationStream stream);
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationWindowPreview // TypeDefIndex: 60613
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 60614
	{
		// Constructors
		public NotKeyableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal enum JobMethodIndex // TypeDefIndex: 60615
	{
		ProcessRootMotionMethodIndex = 0,
		ProcessAnimationMethodIndex = 1,
		MethodIndexCount = 2
	}

	internal struct ProcessAnimationJobStruct<T> // TypeDefIndex: 60617
		where T : struct, IAnimationJob
	{
		// Fields
		private static IntPtr jobReflectionData;
	
		// Nested types
		public delegate void ExecuteJobFunction(ref ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60616; 0x00000000-0x00000000
	
		// Methods
		public static IntPtr GetJobReflectionData();
		public static void Execute(ref ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex);
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AdvancedAnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AdvancedAnimationMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AdvancedAnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AdvancedAnimationMixerPlayable : IPlayable, IEquatable<AdvancedAnimationMixerPlayable> // TypeDefIndex: 60618
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AdvancedAnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AdvancedAnimationMixerPlayable(PlayableHandle handle); // 0x0000000183E0FA80-0x0000000183E0FB00
		static AdvancedAnimationMixerPlayable(); // 0x0000000184B47850-0x0000000184B47960
	
		// Methods
		public static AdvancedAnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED14 */); // 0x0000000183E0F350-0x0000000183E0F450
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED15 */); // 0x0000000183E0F450-0x0000000183E0F5C0
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public bool Equals(AdvancedAnimationMixerPlayable other); // 0x000000018B39513C-0x000000018B3951C8
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0F5C0-0x0000000183E0F600
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0FA30-0x0000000183E0FA80
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 60619
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AnimationClipPlayable(PlayableHandle handle); // 0x0000000183439130-0x00000001834391B0
	
		// Methods
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip); // 0x0000000183438E90-0x0000000183439010
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip); // 0x0000000183439010-0x00000001834390E0
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationClipPlayable playable); // 0x000000018315BC70-0x000000018315BC80
		public static explicit operator AnimationClipPlayable(Playable playable); // 0x000000018B39532C-0x000000018B3953A4
		public bool Equals(AnimationClipPlayable other); // 0x000000018B3951C8-0x000000018B39523C
		public AnimationClip GetAnimationClip(); // 0x0000000185392594-0x00000001853925A0
		public float GetAnimationClipPlayableLengthUncheck(); // 0x000000018B395270-0x000000018B39527C
		public void SetAnimationClip(AnimationClip clip); // 0x000000018B3952D8-0x000000018B3952E0
		public void SetAnimationClipAsync(float length, bool isHumanoid); // 0x000000018B3952D0-0x000000018B3952D8
		public void SetApplyFootIK(bool value); // 0x000000018539815C-0x0000000185398164
		public void SetApplyPlayableIK(bool value); // 0x000000018B395324-0x000000018B39532C
		internal void SetRemoveStartOffset(bool value); // 0x0000000185398144-0x000000018539814C
		internal void SetOverrideLoopTime(bool value); // 0x000000018539814C-0x0000000185398154
		internal void SetLoopTime(bool value); // 0x0000000185398154-0x000000018539815C
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle); // 0x0000000185392580-0x0000000185392594
		[NativeThrows]
		private static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle); // 0x0000000183F633B0-0x0000000183F633F0
		[NativeThrows]
		private static void SetAnimationClipInternal(ref PlayableHandle handle, AnimationClip clip); // 0x0000000184CD8EF0-0x0000000184CD8F40
		[NativeThrows]
		private static void SetAnimationClipAsyncInternal(ref PlayableHandle handle, float length, bool isHumanoid); // 0x000000018B39527C-0x000000018B3952D0
		[NativeThrows]
		private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value); // 0x0000000184D5E540-0x0000000184D5E590
		[NativeThrows]
		private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value); // 0x000000018B3952E0-0x000000018B395324
		[NativeThrows]
		private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value); // 0x0000000184D5E450-0x0000000184D5E4A0
		[NativeThrows]
		private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value); // 0x0000000184D5E4A0-0x0000000184D5E4F0
		[NativeThrows]
		private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value); // 0x0000000184D5E4F0-0x0000000184D5E540
		[NativeThrows]
		[ThreadSafe]
		private static float GetAnimationClipPlayableLengthInternalUncheck(ref PlayableHandle handle); // 0x000000018B39523C-0x000000018B395270
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle); // 0x0000000184126100-0x0000000184126160
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[RequiredByNativeCode]
	public struct AnimationHumanStream // TypeDefIndex: 60620
	{
		// Fields
		private IntPtr stream; // 0x00
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 60621
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x00
	
		// Properties
		public static AnimationLayerMixerPlayable Null { get; } // 0x000000018B3963D4-0x000000018B39642C 
	
		// Constructors
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true /* Metadata: 0x0234ED18 */); // 0x0000000183E0FC00-0x0000000183E0FD00
		static AnimationLayerMixerPlayable(); // 0x0000000184D11E00-0x0000000184D11EB0
	
		// Methods
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED16 */); // 0x0000000183E0ECE0-0x0000000183E0ED80
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization); // 0x0000000183E0ED80-0x0000000183E0EE50
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED17 */); // 0x0000000183E0EE50-0x0000000183E0F010
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationLayerMixerPlayable playable); // 0x0000000183FA72D0-0x0000000183FA7330
		public static explicit operator AnimationLayerMixerPlayable(Playable playable); // 0x000000018B39642C-0x000000018B3964A8
		public bool Equals(AnimationLayerMixerPlayable other); // 0x000000018B395BFC-0x000000018B395C88
		public void SetLayerAdditive(uint layerIndex, bool value); // 0x000000018B395CDC-0x000000018B395E3C
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask); // 0x000000018B396040-0x000000018B396220
		public void SetLayerRootMotionDisable(uint layerIndex, bool value); // 0x000000018B396274-0x000000018B3963D4
		public void SetLayerEnableFloatCurve(uint layerIndex, bool value); // 0x000000018B395E90-0x000000018B395FF0
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0FB50-0x0000000183E0FBB0
		[NativeThrows]
		private static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018B395C88-0x000000018B395CDC
		[NativeThrows]
		private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value); // 0x0000000183E0FD00-0x0000000183E0FD50
		[NativeThrows]
		private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask); // 0x000000018B395FF0-0x000000018B396040
		[NativeThrows]
		private static void SetLayerRootMotionDisableInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018B396220-0x000000018B396274
		[NativeThrows]
		private static void SetLayerEnableFloatCurveInternal(ref PlayableHandle handle, uint layerIndex, bool value); // 0x000000018B395E3C-0x000000018B395E90
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0FBB0-0x0000000183E0FC00
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 60622
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationMixerPlayable(PlayableHandle handle); // 0x0000000183E0F9B0-0x0000000183E0FA30
		static AnimationMixerPlayable(); // 0x0000000184B47960-0x0000000184B47A70
	
		// Methods
		[Obsolete("normalizeWeights is obsolete. It has no effect and will be removed.")]
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights); // 0x000000018B3964A8-0x000000018B396528
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED19 */); // 0x0000000183E0F600-0x0000000183E0F700
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0234ED1A */); // 0x0000000183E0F700-0x0000000183E0F890
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationMixerPlayable playable); // 0x0000000183FA6B30-0x0000000183FA6B90
		public bool Equals(AnimationMixerPlayable other); // 0x000000018B396528-0x000000018B3965B4
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0F890-0x0000000183E0F8D0
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183E0F960-0x0000000183E0F9B0
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 60623
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x00
	
		// Constructors
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle); // 0x0000000183FA5E80-0x0000000183FA5F20
		static AnimationMotionXToDeltaPlayable(); // 0x0000000183FA5DD0-0x0000000183FA5E80
	
		// Methods
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph); // 0x0000000183FA7230-0x0000000183FA72D0
		private static PlayableHandle CreateHandle(PlayableGraph graph); // 0x0000000183FA6FB0-0x0000000183FA7120
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable); // 0x0000000183FA92E0-0x0000000183FA9340
		public bool Equals(AnimationMotionXToDeltaPlayable other); // 0x000000018B3965B4-0x000000018B396640
		public void SetAbsoluteMotion(bool value); // 0x0000000183FA5FB0-0x0000000183FA6010
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183FA60B0-0x0000000183FA6110
		[NativeThrows]
		private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value); // 0x0000000183FA6010-0x0000000183FA6060
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x0000000183FA7120-0x0000000183FA7170
	}

	[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 60624
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationOffsetPlayable(PlayableHandle handle); // 0x0000000183E10D50-0x0000000183E10DF0
		static AnimationOffsetPlayable(); // 0x0000000183E114B0-0x0000000183E11560
	
		// Methods
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount); // 0x0000000183E108B0-0x0000000183E109A0
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount); // 0x0000000183E109A0-0x0000000183E10B50
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationOffsetPlayable playable); // 0x000000018315BC10-0x000000018315BC70
		public bool Equals(AnimationOffsetPlayable other); // 0x000000018B396640-0x000000018B3966D4
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle); // 0x0000000183E10C60-0x0000000183E10CE0
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle); // 0x0000000183E10CE0-0x0000000183E10D50
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/AnimationClip.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
	public static class AnimationPlayableExtensions // TypeDefIndex: 60625
	{
		// Methods
		[NativeThrows]
		internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties); // 0x00000001848AC0A0-0x00000001848AC0F0
	
		// Extension methods
		public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip)
			where U : struct, IPlayable;
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AnimationPlayableGraphExtensions // TypeDefIndex: 60626
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle); // 0x0000000183FC8C80-0x0000000183FC8CE0
	}

	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 60627
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AnimationPlayableOutput Null { get; } // 0x000000018B39684C-0x000000018B3968C4 
	
		// Constructors
		internal AnimationPlayableOutput(PlayableOutputHandle handle); // 0x0000000183FC8CE0-0x0000000183FC8D60
	
		// Methods
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target); // 0x0000000183FC8B10-0x0000000183FC8C80
		public PlayableOutputHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator PlayableOutput(AnimationPlayableOutput output); // 0x000000018315BC70-0x000000018315BC80
		public static explicit operator AnimationPlayableOutput(PlayableOutput output); // 0x0000000184D26620-0x0000000184D26700
		public Animator GetTarget(); // 0x000000018B3967C0-0x000000018B3967CC
		public void SetTarget(Animator value); // 0x0000000185396C40-0x0000000185396C48
		public void PreBindAnimator(Animator value); // 0x0000000182ED1AA0-0x0000000182ED1B00
		public void SetNeedRebindOnChanged(bool value); // 0x000000018B396844-0x000000018B39684C
		[NativeThrows]
		private static Animator InternalGetTarget(ref PlayableOutputHandle handle); // 0x000000018B3967CC-0x000000018B396800
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target); // 0x00000001843C1180-0x00000001843C1260
		[NativeThrows]
		private static void InternalPreBindAnimator(ref PlayableOutputHandle handle, Animator target); // 0x0000000182ED1AA0-0x0000000182ED1B00
		[NativeThrows]
		private static void InternalSetNeedRebindOnChanged(ref PlayableOutputHandle handle, bool value); // 0x000000018B396800-0x000000018B396844
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable> // TypeDefIndex: 60628
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationPosePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationPosePlayable(PlayableHandle handle); // 0x000000018B3969DC-0x000000018B396AB4
		static AnimationPosePlayable(); // 0x000000018B396958-0x000000018B3969DC
	
		// Methods
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public bool Equals(AnimationPosePlayable other); // 0x000000018B3968C4-0x000000018B396958
	}

	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 60629
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationRemoveScalePlayable(PlayableHandle handle); // 0x000000018B396DF8-0x000000018B396ED0
		static AnimationRemoveScalePlayable(); // 0x000000018B396D74-0x000000018B396DF8
	
		// Methods
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount); // 0x000000018B396C3C-0x000000018B396CE0
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount); // 0x000000018B396B54-0x000000018B396C3C
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AnimationRemoveScalePlayable playable); // 0x000000018B396ED0-0x000000018B396F24
		public bool Equals(AnimationRemoveScalePlayable other); // 0x000000018B396CE0-0x000000018B396D74
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle); // 0x000000018B396AF8-0x000000018B396B54
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle); // 0x000000018B396AB4-0x000000018B396AF8
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 60630
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationScriptPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationScriptPlayable(PlayableHandle handle); // 0x000000018B3973EC-0x000000018B3974C4
		static AnimationScriptPlayable(); // 0x000000018B397368-0x000000018B3973EC
	
		// Methods
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0 /* Metadata: 0x0234ED1B */)
			where T : struct, IAnimationJob;
		private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount)
			where T : struct, IAnimationJob;
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		private void CheckJobTypeValidity<T>();
		public void SetJobData<T>(T jobData)
			where T : struct, IAnimationJob;
		public static implicit operator Playable(AnimationScriptPlayable playable); // 0x000000018B3974C4-0x000000018B397518
		public bool Equals(AnimationScriptPlayable other); // 0x000000018B3970E4-0x000000018B397170
		public void SetForceWriteRootMotionParam(bool value); // 0x000000018B39730C-0x000000018B397368
		public void SetForceResetParam(bool value); // 0x000000018B397210-0x000000018B39726C
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData); // 0x000000018B397080-0x000000018B3970E4
		[NativeThrows]
		private static void SetForceWriteRootMotionParamInternal(PlayableHandle handle, bool value); // 0x000000018B3972B0-0x000000018B39730C
		[NativeThrows]
		private static void SetForceResetParamInternal(PlayableHandle handle, bool value); // 0x000000018B3971B4-0x000000018B397210
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData); // 0x000000018B39702C-0x000000018B397080
		private static void SetForceWriteRootMotionParamInternal_Injected(ref PlayableHandle handle, bool value); // 0x000000018B39726C-0x000000018B3972B0
		private static void SetForceResetParamInternal_Injected(ref PlayableHandle handle, bool value); // 0x000000018B397170-0x000000018B3971B4
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[RequiredByNativeCode]
	public struct AnimationStream // TypeDefIndex: 60631
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
		internal uint animatorBindingsVersion { get; } // 0x0000000184DBA750-0x0000000184DBA760 
		public bool isValid { get; } // 0x000000018B397CA8-0x000000018B397CD0 
		public float deltaTime { get; } // 0x000000018B397C88-0x000000018B397CA8 
	
		// Methods
		internal void CheckIsValid(); // 0x000000018B397BE0-0x000000018B397C4C
		[NativeMethod(IsThreadSafe = true)]
		private float GetDeltaTime(); // 0x000000018B397C80-0x000000018B397C88
		private static float GetDeltaTime_Injected(ref AnimationStream _unity_self); // 0x000000018B397C4C-0x000000018B397C80
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public struct TransformStreamHandle // TypeDefIndex: 60632
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int skeletonIndex; // 0x08
	
		// Properties
		private bool createdByNative { get; } // 0x000000018B3A088C-0x000000018B3A0898 
		private bool hasHandleIndex { get; } // 0x000000018B3A08A0-0x000000018B3A08AC 
		private bool hasSkeletonIndex { get; } // 0x000000018B3A08AC-0x000000018B3A08B8 
		internal uint animatorBindingsVersion { get; } // 0x0000000184DBA750-0x0000000184DBA760 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018B3A18FC-0x000000018B3A1910
		private bool IsValidInternal(ref AnimationStream stream); // 0x000000018B3A18CC-0x000000018B3A18FC
		private bool IsSameVersionAsStream(ref AnimationStream stream); // 0x000000018B3A04F0-0x000000018B3A04FC
		public void Resolve(AnimationStream stream); // 0x000000018B3A195C-0x000000018B3A1970
		public bool IsResolved(AnimationStream stream); // 0x000000018B3A18B8-0x000000018B3A18CC
		private bool IsResolvedInternal(ref AnimationStream stream); // 0x000000018B3A187C-0x000000018B3A18B8
		private void CheckIsValidAndResolve(ref AnimationStream stream); // 0x000000018B3A112C-0x000000018B3A1254
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018B3A1738-0x000000018B3A179C
		public void SetPosition(AnimationStream stream, Vector3 position); // 0x000000018B3A1E3C-0x000000018B3A1E90
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018B3A1820-0x000000018B3A187C
		public void SetRotation(AnimationStream stream, Quaternion rotation); // 0x000000018B3A1EF8-0x000000018B3A1F44
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018B3A13A8-0x000000018B3A140C
		public void SetLocalPosition(AnimationStream stream, Vector3 position); // 0x000000018B3A1ADC-0x000000018B3A1B30
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018B3A1490-0x000000018B3A14EC
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation); // 0x000000018B3A1B98-0x000000018B3A1BE4
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018B3A1574-0x000000018B3A15D8
		public void SetLocalScale(AnimationStream stream, Vector3 scale); // 0x000000018B3A1C4C-0x000000018B3A1CA0
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A164C-0x000000018B3A16B0
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask); // 0x000000018B3A1D30-0x000000018B3A1DD4
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A12C8-0x000000018B3A1320
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask); // 0x000000018B3A19F4-0x000000018B3A1A74
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream); // 0x000000018B3A1954-0x000000018B3A195C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream); // 0x000000018B3A1704-0x000000018B3A1738
		[NativeMethod(Name = "TransformStreamHandleBindings::SetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetPositionInternal(ref AnimationStream stream, Vector3 position); // 0x000000018B3A1E28-0x000000018B3A1E3C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream); // 0x000000018B3A17F0-0x000000018B3A1820
		[NativeMethod(Name = "TransformStreamHandleBindings::SetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation); // 0x000000018B3A1EE4-0x000000018B3A1EF8
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream); // 0x000000018B3A1374-0x000000018B3A13A8
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position); // 0x000000018B3A1AC8-0x000000018B3A1ADC
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream); // 0x000000018B3A1460-0x000000018B3A1490
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation); // 0x000000018B3A1B84-0x000000018B3A1B98
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream); // 0x000000018B3A1540-0x000000018B3A1574
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale); // 0x000000018B3A1C38-0x000000018B3A1C4C
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A163C-0x000000018B3A164C
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask); // 0x000000018B3A1D04-0x000000018B3A1D30
		[NativeMethod(Name = "TransformStreamHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A12B8-0x000000018B3A12C8
		[NativeMethod(Name = "TransformStreamHandleBindings::SetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask); // 0x000000018B3A19D4-0x000000018B3A19F4
		private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A1910-0x000000018B3A1954
		private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A16B0-0x000000018B3A1704
		private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position); // 0x000000018B3A1DD4-0x000000018B3A1E28
		private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018B3A179C-0x000000018B3A17F0
		private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation); // 0x000000018B3A1E90-0x000000018B3A1EE4
		private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A1320-0x000000018B3A1374
		private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position); // 0x000000018B3A1A74-0x000000018B3A1AC8
		private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018B3A140C-0x000000018B3A1460
		private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation); // 0x000000018B3A1B30-0x000000018B3A1B84
		private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A14EC-0x000000018B3A1540
		private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 scale); // 0x000000018B3A1BE4-0x000000018B3A1C38
		private static void GetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A15D8-0x000000018B3A163C
		private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, bool useMask); // 0x000000018B3A1CA0-0x000000018B3A1D04
		private static void GetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A1254-0x000000018B3A12B8
		private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, bool useMask); // 0x000000018B3A1970-0x000000018B3A19D4
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	public struct PropertyStreamHandle // TypeDefIndex: 60633
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int valueArrayIndex; // 0x08
		private int bindType; // 0x0C
	
		// Properties
		private bool createdByNative { get; } // 0x000000018B3A088C-0x000000018B3A0898 
		private bool hasHandleIndex { get; } // 0x000000018B3A08A0-0x000000018B3A08AC 
		private bool hasValueArrayIndex { get; } // 0x000000018B3A08AC-0x000000018B3A08B8 
		private bool hasBindType { get; } // 0x000000018B3A0898-0x000000018B3A08A0 
		internal uint animatorBindingsVersion { get; } // 0x0000000184DBA750-0x0000000184DBA760 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018B3A0530-0x000000018B3A0544
		private bool IsValidInternal(ref AnimationStream stream); // 0x000000018B3A04FC-0x000000018B3A0530
		private bool IsSameVersionAsStream(ref AnimationStream stream); // 0x000000018B3A04F0-0x000000018B3A04FC
		private bool IsResolvedInternal(ref AnimationStream stream); // 0x000000018B3A04B4-0x000000018B3A04F0
		private void CheckIsValidAndResolve(ref AnimationStream stream); // 0x000000018B3A00E8-0x000000018B3A0218
		public float GetFloat(AnimationStream stream); // 0x000000018B3A0344-0x000000018B3A03D0
		public void SetFloat(AnimationStream stream, float value); // 0x000000018B3A06EC-0x000000018B3A0788
		public int GetInt(AnimationStream stream); // 0x000000018B3A041C-0x000000018B3A04B4
		public void SetInt(AnimationStream stream, int value); // 0x000000018B3A07E4-0x000000018B3A088C
		public bool GetBool(AnimationStream stream); // 0x000000018B3A0264-0x000000018B3A02F8
		public void SetBool(AnimationStream stream, bool value); // 0x000000018B3A05EC-0x000000018B3A0690
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream); // 0x000000018B3A0588-0x000000018B3A0590
		[NativeMethod(Name = "GetFloat", IsThreadSafe = true)]
		private float GetFloatInternal(ref AnimationStream stream); // 0x000000018B3A033C-0x000000018B3A0344
		[NativeMethod(Name = "SetFloat", IsThreadSafe = true)]
		private void SetFloatInternal(ref AnimationStream stream, float value); // 0x000000018B3A06E4-0x000000018B3A06EC
		[NativeMethod(Name = "GetInt", IsThreadSafe = true)]
		private int GetIntInternal(ref AnimationStream stream); // 0x000000018B3A0414-0x000000018B3A041C
		[NativeMethod(Name = "SetInt", IsThreadSafe = true)]
		private void SetIntInternal(ref AnimationStream stream, int value); // 0x000000018B3A07DC-0x000000018B3A07E4
		[NativeMethod(Name = "GetBool", IsThreadSafe = true)]
		private bool GetBoolInternal(ref AnimationStream stream); // 0x000000018B3A025C-0x000000018B3A0264
		[NativeMethod(Name = "SetBool", IsThreadSafe = true)]
		private void SetBoolInternal(ref AnimationStream stream, bool value); // 0x000000018B3A05E4-0x000000018B3A05EC
		private static void ResolveInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A0544-0x000000018B3A0588
		private static float GetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A02F8-0x000000018B3A033C
		private static void SetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, float value); // 0x000000018B3A0690-0x000000018B3A06E4
		private static int GetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A03D0-0x000000018B3A0414
		private static void SetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, int value); // 0x000000018B3A0788-0x000000018B3A07DC
		private static bool GetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A0218-0x000000018B3A025C
		private static void SetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, bool value); // 0x000000018B3A0590-0x000000018B3A05E4
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	public struct TransformSceneHandle // TypeDefIndex: 60634
	{
		// Fields
		private uint valid; // 0x00
		private int transformSceneHandleDefinitionIndex; // 0x04
	
		// Properties
		private bool createdByNative { get; } // 0x00000001868B8E74-0x00000001868B8E7C 
		private bool hasTransformSceneHandleDefinitionIndex { get; } // 0x000000018B3A08A0-0x000000018B3A08AC 
	
		// Methods
		public bool IsValid(AnimationStream stream); // 0x000000018B3A10E4-0x000000018B3A112C
		private void CheckIsValid(ref AnimationStream stream); // 0x000000018B3A0988-0x000000018B3A0A70
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018B3A0F54-0x000000018B3A0FB8
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018B3A0BC4-0x000000018B3A0C28
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018B3A103C-0x000000018B3A1098
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018B3A0CAC-0x000000018B3A0D08
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018B3A0D90-0x000000018B3A0DF4
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A0E68-0x000000018B3A0ECC
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A0AE4-0x000000018B3A0B3C
		[ThreadSafe]
		private bool HasValidTransform(ref AnimationStream stream); // 0x000000018B3A10DC-0x000000018B3A10E4
		[NativeMethod(Name = "TransformSceneHandleBindings::GetPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream); // 0x000000018B3A0F20-0x000000018B3A0F54
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream); // 0x000000018B3A0B90-0x000000018B3A0BC4
		[NativeMethod(Name = "TransformSceneHandleBindings::GetRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream); // 0x000000018B3A100C-0x000000018B3A103C
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream); // 0x000000018B3A0C7C-0x000000018B3A0CAC
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream); // 0x000000018B3A0D5C-0x000000018B3A0D90
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A0E58-0x000000018B3A0E68
		[NativeMethod(Name = "TransformSceneHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A0AD4-0x000000018B3A0AE4
		private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream); // 0x000000018B3A1098-0x000000018B3A10DC
		private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A0ECC-0x000000018B3A0F20
		private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A0B3C-0x000000018B3A0B90
		private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018B3A0FB8-0x000000018B3A100C
		private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret); // 0x000000018B3A0C28-0x000000018B3A0C7C
		private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret); // 0x000000018B3A0D08-0x000000018B3A0D5C
		private static void GetLocalTRSInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018B3A0DF4-0x000000018B3A0E58
		private static void GetGlobalTRInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018B3A0A70-0x000000018B3A0AD4
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	public struct PropertySceneHandle // TypeDefIndex: 60635
	{
		// Fields
		private uint valid; // 0x00
		private int handleIndex; // 0x04
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationSceneHandleUtility // TypeDefIndex: 60636
	{
		// Methods
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer); // 0x000000018B396F24-0x000000018B396FC8
		internal static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer)
			where T0 : struct
			where T1 : struct;
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadSceneFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count); // 0x000000018B396FC8-0x000000018B39702C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationStreamHandleUtility // TypeDefIndex: 60637
	{
		// Methods
		public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer, bool useMask); // 0x000000018B397AC4-0x000000018B397B7C
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer); // 0x000000018B3979B8-0x000000018B397A60
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count); // 0x000000018B397A60-0x000000018B397AC4
		[NativeMethod(Name = "AnimationHandleUtilityBindings::WriteStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask); // 0x000000018B397B7C-0x000000018B397BE0
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 60638
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimatorControllerPlayable(PlayableHandle handle); // 0x000000018B398C10-0x000000018B398C98
		static AnimatorControllerPlayable(); // 0x000000018B398B8C-0x000000018B398C10
	
		// Methods
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller); // 0x000000018B398880-0x000000018B398924
		private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller); // 0x000000018B3987A8-0x000000018B398880
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public void SetHandle(PlayableHandle handle); // 0x000000018B398A48-0x000000018B398B8C
		public bool Equals(AnimatorControllerPlayable other); // 0x000000018B398924-0x000000018B3989B0
		public bool IsInTransition(int layerIndex); // 0x000000018B3989F0-0x000000018B398A48
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle); // 0x000000018B398744-0x000000018B3987A8
		[NativeThrows]
		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex); // 0x000000018B3989B0-0x000000018B3989F0
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle); // 0x000000018B3986F0-0x000000018B398744
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public enum CustomStreamPropertyType // TypeDefIndex: 60639
	{
		Float = 5,
		Bool = 6,
		Int = 10
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimatorJobExtensions // TypeDefIndex: 60640
	{
		// Methods
		private static void InternalBindStreamTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformStreamHandle transformStreamHandle); // 0x000000018B398FD0-0x000000018B399024
		private static void InternalBindStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle); // 0x000000018B398F6C-0x000000018B398FD0
		private static void InternalBindCustomStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle); // 0x000000018B398E50-0x000000018B398EB4
		private static void InternalBindSceneTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformSceneHandle transformSceneHandle); // 0x000000018B398F18-0x000000018B398F6C
		private static void InternalBindSceneProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle); // 0x000000018B398EB4-0x000000018B398F18
	
		// Extension methods
		public static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform); // 0x000000018B398E00-0x000000018B398E50
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property); // 0x000000018B398DBC-0x000000018B398E00
		public static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type); // 0x000000018B398C98-0x000000018B398CE0
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference); // 0x000000018B398D54-0x000000018B398DBC
		public static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform); // 0x000000018B398D30-0x000000018B398D54
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property); // 0x000000018B398D14-0x000000018B398D30
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference); // 0x000000018B398CE0-0x000000018B398D14
	}

	[Flags]
	[NativeType("Modules/Animation/Constraints/ConstraintEnums.h")]
	public enum Axis // TypeDefIndex: 60641
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4
	}
}

namespace UnityEngine.Experimental.Animations
{
	public enum AnimationStreamSource // TypeDefIndex: 60608
	{
		DefaultValues = 0,
		PreviousInputs = 1
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorDefines.h")]
	[StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimationPlayableOutputExtensions // TypeDefIndex: 60609
	{
		// Methods
		[NativeThrows]
		private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource); // 0x000000018B396714-0x000000018B396728
		[NativeThrows]
		private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder); // 0x000000018B396768-0x000000018B39677C
		private static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource); // 0x000000018B3966D4-0x000000018B396714
		private static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder); // 0x000000018B396728-0x000000018B396768
	
		// Extension methods
		public static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource); // 0x000000018B39677C-0x000000018B39679C
		public static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder); // 0x000000018B39679C-0x000000018B3967C0
	}
}
