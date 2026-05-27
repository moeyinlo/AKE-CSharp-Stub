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
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 53: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57069-57170
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

namespace UnityEngine
{
	public interface IAnimationClipSource // TypeDefIndex: 57070
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[RequiredByNativeCode]
	public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 57071
	{
		// Constructors
		public SharedBetweenAnimatorsAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 57072
	{
		// Constructors
		protected StateMachineBehaviour() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStatePreExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x000000018350B670-0x000000018350B680
	}

	public enum PlayMode // TypeDefIndex: 57073
	{
		StopSameLayer = 0,
		StopAll = 4
	}

	public enum QueueMode // TypeDefIndex: 57074
	{
		CompleteOthers = 0,
		PlayNow = 2
	}

	public enum AnimationBlendMode // TypeDefIndex: 57075
	{
		Blend = 0,
		Additive = 1
	}

	public enum AnimationPlayMode // TypeDefIndex: 57076
	{
		Stop = 0,
		Queue = 1,
		Mix = 2
	}

	public enum AnimationCullingType // TypeDefIndex: 57077
	{
		AlwaysAnimate = 0,
		BasedOnRenderers = 1,
		BasedOnClipBounds = 2,
		BasedOnUserBounds = 3
	}

	internal enum AnimationEventSource // TypeDefIndex: 57078
	{
		NoSource = 0,
		Legacy = 1,
		Animator = 2
	}

	public enum AnimEventHashCodeType // TypeDefIndex: 57079
	{
		None = 0,
		CRC32 = 1,
		HashCode64 = 2
	}

	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : UnityEngine.Behaviour, IEnumerable // TypeDefIndex: 57081
	{
		// Properties
		public AnimationClip clip { get => default; set {} } // 0x0000000189D8DDF4-0x0000000189D8DE28 0x0000000189D8DFF4-0x0000000189D8E038
		public bool playAutomatically { get => default; set {} } // 0x0000000189D8DF04-0x0000000189D8DF38 0x00000001825CBA30-0x00000001825CBA80
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x0000000189D8DF38-0x0000000189D8DF6C 0x0000000189D8E0D0-0x0000000189D8E110
		public bool isPlaying { [NativeName("IsPlaying")] get => default; } // 0x0000000189D8DE5C-0x0000000189D8DE90 
		public UnityEngine.AnimationState this[string name] { get => default; } // 0x0000000189D8DD80-0x0000000189D8DD8C 
		public bool animatePhysics { get => default; set {} } // 0x0000000189D8DDC0-0x0000000189D8DDF4 0x0000000189D8DFB0-0x0000000189D8DFF4
		[Obsolete("Use cullingType instead")]
		public bool animateOnlyIfVisible { [FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = true)] get => default; [FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = true)] set {} } // 0x0000000189D8DD8C-0x0000000189D8DDC0 0x0000000189D8DF6C-0x0000000189D8DFB0
		public AnimationCullingType cullingType { get => default; set {} } // 0x0000000189D8DE28-0x0000000189D8DE5C 0x0000000189D8E038-0x0000000189D8E078
		public Bounds localBounds { [NativeName("GetLocalAABB")] get => default; [NativeName("SetLocalAABB")] set {} } // 0x0000000189D8DED4-0x0000000189D8DF04 0x0000000189D8E0BC-0x0000000189D8E0D0
	
		// Nested types
		private sealed class Enumerator : IEnumerator // TypeDefIndex: 57080
		{
			// Fields
			private Animation m_Outer; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x000000018329DB70-0x000000018329DBA0 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(Animation outer) {} // 0x00000001825CE600-0x00000001825CE620
	
			// Methods
			public bool MoveNext() => default; // 0x00000001831AB930-0x00000001831AB9A0
			public void Reset() {} // 0x0000000183D50330-0x0000000183D50340
		}
	
		// Constructors
		public Animation() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Stop() {} // 0x0000000182C6CE90-0x0000000182C6CED0
		public void Stop(string name) {} // 0x0000000189D8DD38-0x0000000189D8DD40
		[NativeName("Stop")]
		private void StopNamed(string name) {} // 0x0000000189D8DCF4-0x0000000189D8DD38
		public void Rewind() {} // 0x0000000189D8DC84-0x0000000189D8DCB8
		public void Rewind(string name) {} // 0x0000000189D8DCB8-0x0000000189D8DCC0
		[NativeName("Rewind")]
		private void RewindNamed(string name) {} // 0x0000000189D8DC40-0x0000000189D8DC84
		public void Sample() {} // 0x0000000189D8DCC0-0x0000000189D8DCF4
		public bool IsPlaying(string name) => default; // 0x0000000189D8DAD0-0x0000000189D8DB14
		[ExcludeFromDocs]
		public bool Play() => default; // 0x0000000183787540-0x0000000183787550
		public bool Play([UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode) => default; // 0x0000000184276B58-0x0000000184276B64
		[NativeName("Play")]
		private bool PlayDefaultAnimation(UnityEngine.PlayMode mode) => default; // 0x0000000183D1EA50-0x0000000183D1EAA0
		[ExcludeFromDocs]
		public bool Play(string animation) => default; // 0x0000000184276B48-0x0000000184276B58
		public bool Play(string animation, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode) => default; // 0x0000000183CC4640-0x0000000183CC46A0
		[ExcludeFromDocs]
		public void CrossFade(string animation) {} // 0x0000000189D8DA8C-0x0000000189D8DA9C
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength) {} // 0x0000000189D8DA0C-0x0000000189D8DA28
		public void CrossFade(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode) {} // 0x0000000189D8DA28-0x0000000189D8DA8C
		[ExcludeFromDocs]
		public void Blend(string animation) {} // 0x0000000189D8D8C8-0x0000000189D8D8D8
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight) {} // 0x0000000189D8D93C-0x0000000189D8D95C
		public void Blend(string animation, [UnityEngine.Internal.DefaultValue("1.0F")] float targetWeight, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength) {} // 0x0000000189D8D8D8-0x0000000189D8D93C
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation) => default; // 0x0000000189D8D994-0x0000000189D8D9A8
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength) => default; // 0x0000000189D8D95C-0x0000000189D8D978
		[ExcludeFromDocs]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) => default; // 0x0000000189D8D978-0x0000000189D8D994
		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState CrossFadeQueued(string animation, [UnityEngine.Internal.DefaultValue("0.3F")] float fadeLength, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode) => default; // 0x0000000189D8D9A8-0x0000000189D8DA0C
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation) => default; // 0x0000000189D8DB14-0x0000000189D8DB24
		[ExcludeFromDocs]
		public UnityEngine.AnimationState PlayQueued(string animation, QueueMode queue) => default; // 0x0000000189D8DB88-0x0000000189D8DBA4
		[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = true)]
		public UnityEngine.AnimationState PlayQueued(string animation, [UnityEngine.Internal.DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [UnityEngine.Internal.DefaultValue("PlayMode.StopSameLayer")] UnityEngine.PlayMode mode) => default; // 0x0000000189D8DB24-0x0000000189D8DB88
		public void AddClip(AnimationClip clip, string newName) {} // 0x0000000189D8D83C-0x0000000189D8D864
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) {} // 0x0000000189D8D818-0x0000000189D8D83C
		public void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [UnityEngine.Internal.DefaultValue("false")] bool addLoopFrame) {} // 0x0000000189D8D864-0x0000000189D8D8C8
		public void RemoveClip([NotNull("NullExceptionObject")] AnimationClip clip) {} // 0x0000000189D8DBFC-0x0000000189D8DC40
		public void RemoveClip(string clipName) {} // 0x0000000189D8DBF4-0x0000000189D8DBFC
		[NativeName("RemoveClip")]
		private void RemoveClipNamed(string clipName) {} // 0x0000000189D8DBB0-0x0000000189D8DBF4
		public int GetClipCount() => default; // 0x0000000189D8DA9C-0x0000000189D8DAD0
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode) => default; // 0x0000000184276B58-0x0000000184276B64
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode) => default; // 0x0000000189D8DBA4-0x0000000189D8DBB0
		public void SyncLayer(int layer) {} // 0x0000000189D8DD40-0x0000000189D8DD80
		public IEnumerator GetEnumerator() => default; // 0x00000001825CE5A0-0x00000001825CE600
		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		internal UnityEngine.AnimationState GetState(string name) => default; // 0x0000000182C6CE40-0x0000000182C6CE90
		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		internal UnityEngine.AnimationState GetStateAtIndex(int index) => default; // 0x000000018329DBA0-0x000000018329DBF0
		[NativeName("GetAnimationStateCount")]
		internal int GetStateCount() => default; // 0x00000001831AB9A0-0x00000001831AB9E0
		public AnimationClip GetClip(string name) => default; // 0x0000000182C6CE10-0x0000000182C6CE40
		private void get_localBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000189D8DE90-0x0000000189D8DED4
		private void set_localBounds_Injected(ref Bounds value) {} // 0x0000000189D8E078-0x0000000189D8E0BC
	}

	[NativeHeader("Modules/Animation/AnimationState.h")]
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference // TypeDefIndex: 57082
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000189D8D138-0x0000000189D8D16C 0x0000000189D8D2E4-0x0000000189D8D328
		public float weight { get => default; set {} } // 0x0000000189D8D270-0x0000000189D8D2A4 0x0000000189D8D47C-0x0000000189D8D4C0
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x00000001825CBEB0-0x00000001825CBEF0 0x0000000189D8D4C0-0x0000000189D8D500
		public float time { get => default; set {} } // 0x0000000189D8D23C-0x0000000189D8D270 0x0000000189D8D438-0x0000000189D8D47C
		public float normalizedTime { get => default; set {} } // 0x0000000189D8D1D4-0x0000000189D8D208 0x0000000189D8D3B0-0x0000000189D8D3F4
		public float speed { get => default; set {} } // 0x0000000189D8D208-0x0000000189D8D23C 0x0000000189D8D3F4-0x0000000189D8D438
		public float normalizedSpeed { get => default; set {} } // 0x0000000189D8D1A0-0x0000000189D8D1D4 0x0000000189D8D36C-0x0000000189D8D3B0
		public float length { get => default; } // 0x00000001825CC780-0x00000001825CC7C0 
		public int layer { get => default; set {} } // 0x0000000189D8D16C-0x0000000189D8D1A0 0x00000001825CE3C0-0x00000001825CE410
		public AnimationClip clip { get => default; } // 0x00000001825CE210-0x00000001825CE250 
		public string name { get => default; set {} } // 0x00000001825CD470-0x00000001825CD4B0 0x0000000189D8D328-0x0000000189D8D36C
		public AnimationBlendMode blendMode { get => default; set {} } // 0x0000000189D8D104-0x0000000189D8D138 0x0000000189D8D2A4-0x0000000189D8D2E4
	
		// Constructors
		public AnimationState() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix) {} // 0x0000000189D8D060-0x0000000189D8D06C
		public void AddMixingTransform([NotNull("NullExceptionObject")] Transform mix, [UnityEngine.Internal.DefaultValue("true")] bool recursive) {} // 0x0000000189D8D06C-0x0000000189D8D0C0
		public void RemoveMixingTransform([NotNull("NullExceptionObject")] Transform mix) {} // 0x0000000189D8D0C0-0x0000000189D8D104
	}

	[RequiredByNativeCode]
	public struct FastAnimationEvent // TypeDefIndex: 57083
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
		public string stringParameter { get => default; set {} } // 0x0000000183D66B80-0x0000000183D66B90 0x000000018426FEE0-0x000000018426FEF0
		public float floatParameter { get => default; set {} } // 0x0000000183D85A70-0x0000000183D85A80 0x0000000183D4F2F0-0x0000000183D4F300
		public int intParameter { get => default; set {} } // 0x0000000183D85AA0-0x0000000183D85AB0 0x0000000183D4E2F0-0x0000000183D4E300
		public string functionName { get => default; } // 0x0000000183D85A90-0x0000000183D85AA0 
		public float time { get => default; set {} } // 0x0000000183D85AE0-0x0000000183D85AF0 0x0000000183D58BD0-0x0000000183D58BE0
		public SendMessageOptions messageOptions { set {} } // 0x0000000183D4EBA0-0x0000000183D4EBB0
		public float clipWeight { get => default; set {} } // 0x0000000183D85850-0x0000000183D85860 0x0000000183D58BF0-0x0000000183D58C00
		public bool isInTransition { get => default; set {} } // 0x0000000183D85AD0-0x0000000183D85AE0 0x0000000183D4F590-0x0000000183D4F5A0
		public bool isFromMaxWeightClipState { get => default; set {} } // 0x0000000183D85AB0-0x0000000183D85AC0 0x0000000183D4F580-0x0000000183D4F590
		public bool isFromNextMaxWeightClipState { get => default; set {} } // 0x0000000183D85AC0-0x0000000183D85AD0 0x0000000183D85AF0-0x0000000183D85B00
		public int functionNameHashCode { get => default; set {} } // 0x0000000183D85A80-0x0000000183D85A90 0x0000000183D4EE10-0x0000000183D4EE20
	}

	[RequiredByNativeCode]
	public struct FastAnimationEventGroup // TypeDefIndex: 57084
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
	public sealed class AnimationEvent // TypeDefIndex: 57085
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
		public string stringParameter { get => default; set {} } // 0x0000000183D85A20-0x0000000183D85A30 0x0000000184271930-0x0000000184271940
		public float floatParameter { get => default; set {} } // 0x0000000183D84BA0-0x0000000183D84BB0 0x0000000183D4F5E0-0x0000000183D4F5F0
		public int intParameter { get => default; set {} } // 0x0000000183D85A10-0x0000000183D85A20 0x0000000183D4EE40-0x0000000183D4EE50
		public UnityEngine.Object objectReferenceParameter { set {} } // 0x0000000182C92F10-0x0000000182C92F20
		public string functionName { get => default; set {} } // 0x0000000183D61D00-0x0000000183D61D10 0x00000001822C3A90-0x00000001822C3AA0
		public float time { get => default; set {} } // 0x0000000183D85830-0x0000000183D85840 0x0000000183D50CA0-0x0000000183D50CB0
		public SendMessageOptions messageOptions { set {} } // 0x0000000183D4ECB0-0x0000000183D4ECC0
		public bool isFiredByAnimator { get => default; } // 0x0000000189D8AB9C-0x0000000189D8ABA4 
		public AnimatorClipInfo animatorClipInfo { get => default; } // 0x0000000189D8AB40-0x0000000189D8AB9C 
	
		// Constructors
		public AnimationEvent() {} // 0x0000000189D8AAA4-0x0000000189D8AB40
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion // TypeDefIndex: 57086
	{
		// Properties
		[NativeProperty("Length", false, UnityEngine.Bindings.TargetType.Function)]
		public float length { get => default; } // 0x0000000182383B20-0x0000000182383B60 
		[NativeProperty("StartTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float startTime { get => default; } // 0x0000000189D8A7B8-0x0000000189D8A7EC 
		[NativeProperty("StopTime", false, UnityEngine.Bindings.TargetType.Function)]
		internal float stopTime { get => default; } // 0x0000000189D8A7EC-0x0000000189D8A820 
		[NativeProperty("SampleRate", false, UnityEngine.Bindings.TargetType.Function)]
		public float frameRate { get => default; set {} } // 0x0000000189D8A5A4-0x0000000189D8A5D8 0x0000000189D8A8D4-0x0000000189D8A918
		public ushort clipTag { [NativeMethod("GetClipTag")] get => default; [NativeMethod("SetClipTag")] set {} } // 0x0000000189D8A4F8-0x0000000189D8A52C 0x0000000189D8A888-0x0000000189D8A8CC
		[NativeProperty("WrapMode", false, UnityEngine.Bindings.TargetType.Function)]
		public UnityEngine.WrapMode wrapMode { get => default; set {} } // 0x00000001825CE310-0x00000001825CE350 0x0000000189D8A9F8-0x0000000189D8AA38
		[NativeProperty("Bounds", false, UnityEngine.Bindings.TargetType.Function)]
		public Bounds localBounds { get => default; set {} } // 0x0000000189D8A788-0x0000000189D8A7B8 0x0000000189D8A9A0-0x0000000189D8A9B4
		public bool legacy { [NativeMethod("IsLegacy")] get => default; [NativeMethod("SetLegacy")] set {} } // 0x0000000189D8A710-0x0000000189D8A744 0x0000000189D8A918-0x0000000189D8A95C
		public bool humanMotion { [NativeMethod("IsHumanMotion")] get => default; } // 0x0000000189D8A6DC-0x0000000189D8A710 
		public bool empty { [NativeMethod("IsEmpty")] get => default; } // 0x0000000189D8A52C-0x0000000189D8A560 
		public bool hasGenericRootTransform { [NativeMethod("HasGenericRootTransform")] get => default; } // 0x0000000189D8A5D8-0x0000000189D8A60C 
		public bool hasMotionFloatCurves { [NativeMethod("HasMotionFloatCurves")] get => default; } // 0x0000000189D8A640-0x0000000189D8A674 
		public bool hasMotionCurves { [NativeMethod("HasMotionCurves")] get => default; } // 0x0000000189D8A60C-0x0000000189D8A640 
		public bool hasRootCurves { [NativeMethod("HasRootCurves")] get => default; } // 0x0000000189D8A674-0x0000000189D8A6A8 
		internal bool hasRootMotion { [FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)] get => default; } // 0x0000000189D8A6A8-0x0000000189D8A6DC 
		public bool transferRotationCompressed { [NativeMethod("GetTransferCompressed")] get => default; [NativeMethod("SetTransferCompressed")] set {} } // 0x0000000189D8A820-0x0000000189D8A854 0x0000000189D8A9B4-0x0000000189D8A9F8
		public ulong uniqueId { [NativeMethod("GetClipUniqueID")] get => default; } // 0x0000000189D8A854-0x0000000189D8A888 
		public AnimationEvent[] events { get => default; set {} } // 0x0000000189D8A560-0x0000000189D8A5A4 0x0000000189D8A8CC-0x0000000189D8A8D4
	
		// Constructors
		public AnimationClip() {} // 0x00000001833570D0-0x00000001833570F0
	
		// Methods
		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self) {} // 0x0000000183357130-0x0000000183357170
		public void SampleAnimation(GameObject go, float time) {} // 0x00000001825CE270-0x00000001825CE310
		public void SampleAnimationFast(GameObject go, float time) {} // 0x0000000182806BB0-0x0000000182806CE0
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimation([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode) {} // 0x00000001825CE350-0x00000001825CE3C0
		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimationFast([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode) {} // 0x0000000182806B40-0x0000000182806BB0
		[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
		public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve) {} // 0x0000000189D8A450-0x0000000189D8A4B4
		[FreeFunction("AnimationClipBindings::Internal_GetAnimatorFloatCurve", HasExplicitThis = true)]
		public bool GetAnimatorFloatCurve(string propertyName, AnimationCurve curve) => default; // 0x0000000189D8A394-0x0000000189D8A3E8
		public void EnsureQuaternionContinuity() {} // 0x0000000189D8A360-0x0000000189D8A394
		public void ClearCurves() {} // 0x0000000189D8A32C-0x0000000189D8A360
		[FreeFunction("AnimationClipBindings::Internal_GetAnimationRuntimeMemorySize", HasExplicitThis = true)]
		public uint GetRuntimeMemorySize() => default; // 0x0000000189D8A41C-0x0000000189D8A450
		public void AddEvent(AnimationEvent evt) {} // 0x0000000189D8A2C0-0x0000000189D8A32C
		[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = true)]
		private void AddEventInternal(object evt) {} // 0x0000000189D8A27C-0x0000000189D8A2C0
		[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = true, ThrowsException = true)]
		private void SetEventsInternal(Array value) {} // 0x0000000189D8A4B4-0x0000000189D8A4F8
		[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = true)]
		private Array GetEventsInternal() => default; // 0x0000000189D8A3E8-0x0000000189D8A41C
		private void get_localBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000189D8A744-0x0000000189D8A788
		private void set_localBounds_Injected(ref Bounds value) {} // 0x0000000189D8A95C-0x0000000189D8A9A0
	}

	public enum AvatarTarget // TypeDefIndex: 57087
	{
		Root = 0,
		Body = 1,
		LeftFoot = 2,
		RightFoot = 3,
		LeftHand = 4,
		RightHand = 5
	}

	public enum AvatarIKGoal // TypeDefIndex: 57088
	{
		LeftFoot = 0,
		RightFoot = 1,
		LeftHand = 2,
		RightHand = 3
	}

	public enum AvatarIKHint // TypeDefIndex: 57089
	{
		LeftKnee = 0,
		RightKnee = 1,
		LeftElbow = 2,
		RightElbow = 3
	}

	public enum AnimatorControllerParameterType // TypeDefIndex: 57090
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	internal enum StateInfoIndex // TypeDefIndex: 57091
	{
		CurrentState = 0,
		NextState = 1,
		ExitState = 2,
		InterruptedState = 3
	}

	public enum AnimationBlendStyle // TypeDefIndex: 57092
	{
		Linear = 0,
		CubicIn = 1,
		HermiteCubic = 2,
		Sinusoidal = 3,
		CubicInOut = 4
	}

	public enum AnimatorTransitionInterruptionSource // TypeDefIndex: 57093
	{
		None = 0,
		Current = 1,
		Next = 2,
		CurrentThenNext = 3,
		NextThenCurrent = 4
	}

	public enum AnimatorRecorderMode // TypeDefIndex: 57094
	{
		Offline = 0,
		Playback = 1,
		Record = 2
	}

	public enum AnimatorUroMode // TypeDefIndex: 57095
	{
		Origin = 0,
		Predict = 1,
		PredictWithTick = 2,
		PredictWithTickAndRootMotion = 3
	}

	public enum AnimatorCullingMode // TypeDefIndex: 57096
	{
		AlwaysAnimate = 0,
		CullUpdateTransforms = 1,
		CullCompletely = 2
	}

	public enum AnimatorUpdateMode // TypeDefIndex: 57097
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum AnimatorJobDispatchMode // TypeDefIndex: 57098
	{
		Default = 0,
		ForceMainThread = 1,
		PreUpdate = 2,
		CrossFrame = 3,
		CrossFrameLateUpdate = 4
	}

	[UsedByNativeCode]
	public struct AnimatorLOD // TypeDefIndex: 57099
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
		public AnimatorLOD(float worldAbsoluteDistance, int framesPerUpdate, float maxDeltaTime, int framesPerWrite = 0 /* Metadata: 0x01FD9BDF */, float maxBlendDeltaTime = 0f /* Metadata: 0x01FD9BE0 */, AnimatorUroMode uroMode = AnimatorUroMode.Origin /* Metadata: 0x01FD9BE4 */, int delayFrame = 0 /* Metadata: 0x01FD9BE5 */) {
			this.worldAbsoluteDistance = default;
			this.maxDeltaTime = default;
			this.framesPerUpdate = default;
			this.maxBlendDeltaTime = default;
			this.framesPerWrite = default;
			this.delayFrame = default;
			this.uroMode = default;
		} // 0x0000000183D85A30-0x0000000183D85A60
	}

	[NativeHeader("Modules/Animation/HGAnimExtra/HGTransformRWBuffer.h")]
	public struct AnimationTransformRWBufferHandle // TypeDefIndex: 57100
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
	public struct HGAnimParameterSGHandle // TypeDefIndex: 57101
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

	public enum AnimFrameSyncMode // TypeDefIndex: 57102
	{
		FrameSyncInRootPlayable = 0,
		FrameSyncInBaseLayerState = 1
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public struct AnimatorClipInfo // TypeDefIndex: 57103
	{
		// Fields
		private int m_ClipInstanceID; // 0x00
		private float m_Weight; // 0x04
	
		// Properties
		public AnimationClip clip { get => default; } // 0x0000000189D8E144-0x0000000189D8E160 
		public float weight { get => default; } // 0x0000000183D85850-0x0000000183D85860 
	
		// Methods
		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) => default; // 0x0000000189D8E110-0x0000000189D8E144
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateInfo // TypeDefIndex: 57104
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
		public int fullPathHash { get => default; } // 0x0000000183D68070-0x0000000183D68080 
		public int shortNameHash { get => default; } // 0x0000000183D85860-0x0000000183D85870 
		public float normalizedTime { get => default; } // 0x0000000183D85A60-0x0000000183D85A70 
		public float length { get => default; } // 0x0000000183D85830-0x0000000183D85840 
		public int tagHash { get => default; } // 0x0000000183D66B90-0x0000000183D66BA0 
		public bool loop { get => default; } // 0x000000018272C740-0x000000018272C750 
	
		// Methods
		public bool IsName(string name) => default; // 0x0000000189D8F538-0x0000000189D8F568
		public bool IsTag(string tag) => default; // 0x00000001838DF820-0x00000001838DF850
	}

	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateRootMotionInfo // TypeDefIndex: 57105
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
	public struct AnimatorTransitionInfo // TypeDefIndex: 57106
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
		public int nameHash { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Methods
		public bool IsUserName(string name) => default; // 0x0000000189D8F568-0x0000000189D8F58C
	}

	[NativeHeader("Modules/Animation/Animator.h")]
	public struct MatchTargetWeightMask // TypeDefIndex: 57107
	{
		// Fields
		private Vector3 m_PositionXYZWeight; // 0x00
		private float m_RotationWeight; // 0x0C
	
		// Constructors
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight) {
			m_PositionXYZWeight = default;
			m_RotationWeight = default;
		} // 0x0000000182103850-0x00000001821038C0
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[UsedByNativeCode]
	public class Animator : UnityEngine.Behaviour // TypeDefIndex: 57112
	{
		// Fields
		internal AnimationEventCallback onAnimationEvent; // 0x18
		internal AnimationEventCallbackOpt onAnimationEventOpt; // 0x20
		internal AnimatorStateChangeCallback onAnimatorStateEnter; // 0x28
		internal AnimatorStateChangeCallback onAnimatorStateExit; // 0x30
		internal AnimatorStateChangeCallback onAnimatorStatePreExit; // 0x38
		internal AniamtorCommonCallback afterAnimatorUpdateGraphCB; // 0x40
	
		// Properties
		public bool fastAnimationEventsOpt { [NativeMethod("GetEnableFireAnimationEventsOpt")] get => default; [NativeMethod("SetEnableFireAnimationEventsOpt")] set {} } // 0x0000000189D936F0-0x0000000189D93724 0x00000001827ACDA0-0x00000001827ACDF0
		public bool callBackAfterUpdateGraph { [NativeMethod("GetNeedInvokeCBAfterUpdateGraph")] get => default; [NativeMethod("SetNeedInvokeCBAfterUpdateGraph")] set {} } // 0x0000000189D93688-0x0000000189D936BC 0x0000000189D94218-0x0000000189D9425C
		public bool fastAnimationEvents { [NativeMethod("GetFastAnimationEvents")] get => default; [NativeMethod("SetFastAnimationEvents")] set {} } // 0x0000000189D93724-0x0000000189D93758 0x00000001827ACDF0-0x00000001827ACE40
		public bool notifyAnimatorStateEnterAndExitEvent { [NativeMethod("GetNotifyAnimatorStateEnterAndExitEvent")] get => default; [NativeMethod("SetNotifyAnimatorStateEnterAndExitEvent")] set {} } // 0x0000000189D93B40-0x0000000189D93B74 0x000000018349B3D0-0x000000018349B420
		public bool keepStateOnChangeActive { [NativeMethod("GetKeepAnimatorStateOnChangeActive")] get => default; [NativeMethod("SetKeepAnimatorStateOnChangeActive")] set {} } // 0x0000000189D9396C-0x0000000189D939A0 0x0000000189D942EC-0x0000000189D94330
		public bool pausePlayableOnChangeActive { [NativeMethod("GetPauseAnimatorStateOnChangeActive")] get => default; [NativeMethod("SetPauseAnimatorStateOnChangeActive")] set {} } // 0x0000000189D93B74-0x0000000189D93BA8 0x0000000189D944C4-0x0000000189D94508
		public bool resetControllerPlayableOnChangeActive { [NativeMethod("GetResetAnimatorControllerStateOnChangeActive")] get => default; [NativeMethod("SetResetAnimatorControllerStateOnChangeActive")] set {} } // 0x0000000189D93D04-0x0000000189D93D38 0x0000000189D9454C-0x0000000189D94590
		public bool isOptimizable { [NativeMethod("IsOptimizable")] get => default; } // 0x0000000189D938C4-0x0000000189D938F8 
		public bool isHuman { [NativeMethod("IsHuman")] get => default; } // 0x0000000189D93828-0x0000000189D9385C 
		public bool hasRootMotion { [NativeMethod("HasRootMotion")] get => default; } // 0x0000000189D937C0-0x0000000189D937F4 
		internal bool isRootPositionOrRotationControlledByCurves { [NativeMethod("IsRootTranslationOrRotationControllerByCurves")] get => default; } // 0x0000000189D938F8-0x0000000189D9392C 
		public float humanScale { get => default; } // 0x0000000189D937F4-0x0000000189D93828 
		public bool isInitialized { [NativeMethod("IsInitialized")] get => default; } // 0x0000000189D9385C-0x0000000189D93890 
		public bool isVisible { [NativeMethod("IsVisible")] get => default; } // 0x0000000182DDAB60-0x0000000182DDABA0 
		public bool updatedLastFrame { [NativeMethod("GetShouldTick")] get => default; } // 0x000000018287C8A0-0x000000018287C8E0 
		public bool enableLOD { [NativeMethod("GetEnableLOD")] get => default; [NativeMethod("SetEnableLOD")] set {} } // 0x0000000189D936BC-0x0000000189D936F0 0x000000018297B950-0x000000018297B9A0
		public int LODLevel { [NativeMethod("GetCurrentLODLevel")] get => default; } // 0x00000001827AFEE0-0x00000001827AFF20 
		public float motionDeltaTime { get => default; } // 0x0000000189D93B0C-0x0000000189D93B40 
		public Vector3 deltaPosition { get => default; } // 0x0000000182D66490-0x0000000182D664F0 
		public Quaternion deltaRotation { get => default; } // 0x00000001831DEB30-0x00000001831DEB90 
		public Vector3 velocity { get => default; } // 0x0000000182D66330-0x0000000182D66390 
		public Vector3 angularVelocity { get => default; } // 0x0000000182D663E0-0x0000000182D66440 
		public Vector3 rootPosition { [NativeMethod("GetAvatarPosition")] get => default; [NativeMethod("SetAvatarPosition")] set {} } // 0x0000000189D93DB0-0x0000000189D93DDC 0x0000000189D945D4-0x0000000189D945E8
		public Quaternion rootRotation { [NativeMethod("GetAvatarRotation")] get => default; [NativeMethod("SetAvatarRotation")] set {} } // 0x0000000189D93E20-0x0000000189D93E4C 0x0000000189D9462C-0x0000000189D94640
		public bool applyRootMotion { get => default; set {} } // 0x0000000189D934AC-0x0000000189D934E0 0x0000000189D940A4-0x0000000189D940E8
		[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
		public bool linearVelocityBlending { get => default; set {} } // 0x0000000189D93A08-0x0000000189D93A3C 0x0000000189D94374-0x0000000189D943B8
		[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
		public bool animatePhysics { get => default; set {} } // 0x0000000189D93460-0x0000000189D93478 0x0000000189D94040-0x0000000189D94060
		public AnimatorUpdateMode updateMode { get => default; set {} } // 0x0000000182DBAAC0-0x0000000182DBAB00 0x0000000189D94684-0x0000000189D946C4
		public bool hasTransformHierarchy { get => default; } // 0x00000001829F0ED0-0x00000001829F0F10 
		internal bool allowConstantClipSamplingOptimization { get => default; set {} } // 0x0000000189D9342C-0x0000000189D93460 0x0000000189D93FFC-0x0000000189D94040
		public float gravityWeight { get => default; } // 0x00000001833585D0-0x0000000183358610 
		public Vector3 bodyPosition { get => default; set {} } // 0x0000000189D93584-0x0000000189D935D4 0x0000000189D94140-0x0000000189D94184
		internal Vector3 bodyPositionInternal { [NativeMethod("GetBodyPosition")] get => default; [NativeMethod("SetBodyPosition")] set {} } // 0x0000000189D93558-0x0000000189D93584 0x0000000189D9412C-0x0000000189D94140
		public Quaternion bodyRotation { get => default; set {} } // 0x0000000189D93644-0x0000000189D93688 0x0000000189D941DC-0x0000000189D94218
		internal Quaternion bodyRotationInternal { [NativeMethod("GetBodyRotation")] get => default; [NativeMethod("SetBodyRotation")] set {} } // 0x0000000189D93618-0x0000000189D93644 0x0000000189D941C8-0x0000000189D941DC
		public bool stabilizeFeet { get => default; set {} } // 0x0000000189D93E80-0x0000000189D93EB4 0x0000000189D94640-0x0000000189D94684
		public int layerCount { get => default; } // 0x0000000182EF2010-0x0000000182EF2050 
		public AnimatorControllerParameter[] parameters { [FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)] get => default; } // 0x0000000182EEDD70-0x0000000182EEDDB0 
		public int parameterCount { get => default; } // 0x0000000183B1FD20-0x0000000183B1FD60 
		public float feetPivotActive { get => default; set {} } // 0x0000000189D93758-0x0000000189D9378C 0x0000000189D9425C-0x0000000189D942A0
		public float pivotWeight { get => default; } // 0x0000000189D93C18-0x0000000189D93C4C 
		public Vector3 pivotPosition { get => default; } // 0x0000000189D93BEC-0x0000000189D93C18 
		public bool isMatchingTarget { [NativeMethod("IsMatchingTarget")] get => default; } // 0x0000000189D93890-0x0000000189D938C4 
		public float timeScale { [NativeMethod("GetTimeScale")] get => default; [NativeMethod("SetTimeScale")] set {} } // 0x0000000182E68A40-0x0000000182E68AE0 0x0000000182B3DE50-0x0000000182B3DEA0
		public float speed { get => default; set {} } // 0x0000000189D93E4C-0x0000000189D93E80 0x0000000182B3DEA0-0x0000000182B3DEF0
		public Vector3 targetPosition { get => default; } // 0x0000000189D93F2C-0x0000000189D93F58 
		public Quaternion targetRotation { get => default; } // 0x0000000189D93F9C-0x0000000189D93FC8 
		internal Transform avatarRoot { get => default; } // 0x0000000189D934E0-0x0000000189D93514 
		public AnimatorCullingMode cullingMode { get => default; set {} } // 0x00000001827B2E80-0x00000001827B2EC0 0x00000001828069F0-0x0000000182806A40
		public float playbackTime { get => default; set {} } // 0x0000000189D93C84-0x0000000189D93CB8 0x0000000189D94508-0x0000000189D9454C
		public float recorderStartTime { get => default; set {} } // 0x0000000189D93CEC-0x0000000189D93CF8 0x000000018350B670-0x000000018350B680
		public float recorderStopTime { get => default; set {} } // 0x0000000189D93CF8-0x0000000189D93D04 0x000000018350B670-0x000000018350B680
		public AnimatorRecorderMode recorderMode { get => default; } // 0x0000000189D93CB8-0x0000000189D93CEC 
		public RuntimeAnimatorController runtimeAnimatorController { get => default; set {} } // 0x0000000182B9A040-0x0000000182B9B860 0x0000000182F49A40-0x0000000182F49A90
		public bool hasBoundPlayables { [NativeMethod("HasBoundPlayables")] get => default; } // 0x00000001822B3C10-0x00000001822B3C50 
		public Avatar avatar { get => default; set {} } // 0x00000001822D8D60-0x00000001822D8DA0 0x0000000183A508A0-0x0000000183A508F0
		public HGSkeletalMorphAvatar morphAvatar { get => default; set {} } // 0x0000000189D93AD8-0x0000000189D93B0C 0x0000000189D94480-0x0000000189D944C4
		public LodBoneMask lodBoneMask { get => default; set {} } // 0x0000000189D93A70-0x0000000189D93AA4 0x0000000189D943F8-0x0000000189D9443C
		public uint lodBoneMaskLevel { get => default; set {} } // 0x0000000189D93A3C-0x0000000189D93A70 0x0000000189D943B8-0x0000000189D943F8
		public PlayableGraph playableGraph { get => default; } // 0x0000000189D93C4C-0x0000000189D93C84 
		public bool applyMorphPose { get => default; set {} } // 0x0000000189D93478-0x0000000189D934AC 0x0000000189D94060-0x0000000189D940A4
		public bool layersAffectMassCenter { get => default; set {} } // 0x0000000189D939A0-0x0000000189D939D4 0x0000000189D94330-0x0000000189D94374
		public float leftFeetBottomHeight { get => default; } // 0x0000000189D939D4-0x0000000189D93A08 
		public float rightFeetBottomHeight { get => default; } // 0x0000000189D93D38-0x0000000189D93D6C 
		[NativeConditional("UNITY_EDITOR")]
		internal bool supportsOnAnimatorMove { [NativeMethod("SupportsOnAnimatorMove")] get => default; } // 0x0000000189D93EB4-0x0000000189D93EE8 
		public bool logWarnings { get => default; set {} } // 0x0000000189D93AA4-0x0000000189D93AD8 0x0000000189D9443C-0x0000000189D94480
		public bool fireEvents { get => default; set {} } // 0x0000000189D9378C-0x0000000189D937C0 0x0000000189D942A0-0x0000000189D942E4
		[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", false)]
		public bool keepAnimatorControllerStateOnDisable { get => default; set {} } // 0x0000000189D9392C-0x0000000189D93938 0x0000000189D942E4-0x0000000189D942EC
		public bool keepAnimatorStateOnDisable { get => default; set {} } // 0x0000000189D93938-0x0000000189D9396C 0x00000001836110E0-0x0000000183611130
		public bool writeDefaultValuesOnDisable { get => default; set {} } // 0x0000000189D93FC8-0x0000000189D93FFC 0x0000000182F49830-0x0000000182F49880
	
		// Nested types
		public delegate bool AnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent); // TypeDefIndex: 57108; 0x00000001821126B0-0x0000000182112700
	
		public delegate void AnimatorStateChangeCallback(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex); // TypeDefIndex: 57109; 0x0000000189D8F4F0-0x0000000189D8F538
	
		public delegate bool AnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent); // TypeDefIndex: 57110; 0x0000000189D8AA38-0x0000000189D8AAA4
	
		public delegate void AniamtorCommonCallback(Animator animator); // TypeDefIndex: 57111; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public Animator() {} // 0x0000000189D933E0-0x0000000189D9342C
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallAnimatorStateChangeCallback(Animator anim, AnimatorStateInfo animatorStateInfo, int layerIndex, int methodIdx) {} // 0x0000000189D91708-0x0000000189D91804
		[RequiredByNativeCode]
		private static void Internal_CallAfterUpdateGraph(Animator anim) {} // 0x0000000189D9169C-0x0000000189D91708
		[RequiredByNativeCode]
		private static bool Internal_InvokeAnimationEventCallback(Animator animator, FastAnimationEvent fastAnimationEvent) => default; // 0x00000001833D90D0-0x00000001833D9150
		[RequiredByNativeCode]
		private static bool Internal_InvokeAnimationEventCallbackOpt(Animator animator, FastAnimationEventGroup fastAnimationEvent) => default; // 0x00000001828309E0-0x0000000182830AE0
		public void SetCallbackAfterRootMotionStageCallback(AniamtorCommonCallback cb) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		public void SetAnimationEventCallback(AnimationEventCallback onAnimationEvent) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public void SetAnimationEventCallbackOpt(AnimationEventCallbackOpt onAnimationEvent) {} // 0x0000000184271930-0x0000000184271940
		public void SetNotifyAnimatorStateEnterAndExitEventCallBack(AnimatorStateChangeCallback onAnimatorStateEnter, AnimatorStateChangeCallback onAnimatorStateExit) {} // 0x000000018349B3A0-0x000000018349B3D0
		public void SetNotifyAnimatorStatePreExitEventCallBack(AnimatorStateChangeCallback onAnimatorStatePreExit) {} // 0x000000018388FF30-0x000000018388FF40
		[NativeMethod("SetLODLevel")]
		public bool SetLODLevel(int level) => default; // 0x0000000182EF05A0-0x0000000182EF0630
		[NativeMethod("GetCurrentLODLevel")]
		public int GetCurrentLODLevel() => default; // 0x0000000189D90CFC-0x0000000189D90D30
		[FreeFunction("AnimatorBindings::GetLODs_Binding", HasExplicitThis = true)]
		public AnimatorLOD[] GetLODs() => default; // 0x0000000182DDC330-0x0000000182DDC370
		[FreeFunction("AnimatorBindings::SetLODs_Binding", HasExplicitThis = true)]
		public void SetLODs([Unmarshalled] AnimatorLOD[] lods) {} // 0x0000000182E38680-0x0000000182E386D0
		[NativeMethod("SetConstraintEnableImmediately")]
		public void SetConstraintEnableImmediately(int nameHash) {} // 0x0000000189D92394-0x0000000189D923D4
		[NativeMethod("SetConstraintDisableImmediately")]
		public void SetConstraintDisableImmediately(int nameHash) {} // 0x0000000189D92304-0x0000000189D92344
		[NativeMethod("SetConstraintEnableBlendIn")]
		public void SetConstraintEnableBlendIn(int nameHash, float duration) {} // 0x0000000189D92344-0x0000000189D92394
		[NativeMethod("SetConstraintDisableBlendOut")]
		public void SetConstraintDisableBlendOut(int nameHash, float duration) {} // 0x0000000189D922B4-0x0000000189D92304
		public void BecameVisible() {} // 0x000000018349BCC0-0x000000018349BD00
		[NativeMethod("SetAnimatorJobOptEnable")]
		public static void SetAnimatorJobOptEnable(bool enabel) {} // 0x0000000183703960-0x00000001837039A0
		[NativeMethod("SetAnimatorJobOptFunc")]
		public static void SetAnimatorJobOptFunc(int value) {} // 0x00000001837039A0-0x00000001837039E0
		[NativeMethod("SetAnimatorWriteTransformOpt")]
		public static void SetAnimatorWriteTransformOpt(bool value) {} // 0x00000001837039E0-0x0000000183703A20
		[NativeMethod("SetGlobalAnimatorClipBindingsOpt")]
		public static void SetGlobalAnimatorClipBindingsOpt(bool value) {} // 0x0000000183703A20-0x0000000183703A60
		[NativeMethod("SetGlobalAnimatorClipBindingsConstantOpt")]
		public static void SetGlobalAnimatorClipBindingsConstantOpt(bool value) {} // 0x0000000183703A60-0x0000000183703AA0
		[NativeMethod("SetGlobalAnimatorClipBindingsOptByAvatar")]
		public static void SetGlobalAnimatorClipBindingsOptByAvatar(bool value) {} // 0x0000000183703AA0-0x0000000183703AE0
		[NativeMethod("SetAnimatorUroMaxDeltaTimePerframe")]
		public static void SetAnimatorUroMaxDeltaTimePerframe(float value) {} // 0x0000000189D920A0-0x0000000189D920DC
		[NativeMethod("SetGlobalAnimatorCacheClipBindingsOpt")]
		public static void SetGlobalAnimatorCacheClipBindingsOpt(bool value) {} // 0x0000000183703AE0-0x0000000183703B20
		[NativeMethod("GetAnimatorUroMaxDeltaTimePerframe")]
		public static float GetAnimatorUroMaxDeltaTimePerframe() => default; // 0x0000000189D906D4-0x0000000189D90700
		[NativeMethod("SetAnimatorMainThreadJobCount")]
		public static void SetAnimatorMainThreadJobCount(int value) {} // 0x0000000189D9206C-0x0000000189D920A0
		[NativeMethod("SetPrepareFrameJobBatchCountOpt")]
		public static void SetPrepareFrameJobBatchCountOpt(int value) {} // 0x0000000189D930A0-0x0000000189D930D4
		[NativeMethod("SetProcessAnimJobBatchCountOpt")]
		public static void SetProcessAnimJobBatchCountOpt(int value) {} // 0x0000000189D930D4-0x0000000189D93108
		[NativeMethod("SetAnimatorEnableProcessOneStage")]
		public static void SetAnimatorEnableProcessOneStage(bool value) {} // 0x0000000183703B20-0x0000000183703B60
		[NativeMethod("SetAnimatorEnableApplyOnMoveInJob")]
		public static void SetAnimatorEnableApplyOnMoveInJob(bool value) {} // 0x0000000189D91FD0-0x0000000189D92004
		[NativeMethod("SetAnimatorEnableRequireEventsAndBehaviour")]
		public static void SetAnimatorEnableRequireEventsAndBehaviour(bool value) {} // 0x0000000189D92038-0x0000000189D9206C
		[NativeMethod("SetApplyBuildInRootMotionInJob")]
		public void SetApplyBuildInRootMotionInJob(bool enable) {} // 0x0000000189D920DC-0x0000000189D92120
		[NativeMethod("SetAnimatorForbbidenApplyOnMoveCb")]
		public static void SetAnimatorForbbidenApplyOnMoveCb(bool value) {} // 0x0000000183703B60-0x0000000183703BA0
		[NativeMethod("SetAnimatorEnableCrossFrameJobs")]
		public static void SetAnimatorEnableCrossFrameJobs(bool enabel) {} // 0x0000000189D92004-0x0000000189D92038
		[NativeMethod("SetAbilityLevel")]
		public void SetAbilityLevel(int abilityLevel) {} // 0x00000001827ABF40-0x00000001827ABF90
		[NativeMethod("GetAbilityLevel")]
		public int GetAbilityLevel() => default; // 0x00000001827AFEA0-0x00000001827AFEE0
		[NativeMethod("SetSampleClipCacheCreatePreFrameCount")]
		public static void SetSampleClipCacheCreatePreFrameCount(int value) {} // 0x0000000189D93108-0x0000000189D9313C
		[NativeMethod("SetSampleClipCacheMaxCount")]
		public static void SetSampleClipCacheMaxCount(int value) {} // 0x0000000189D9313C-0x0000000189D93170
		[NativeMethod("SetLayerMeshSpace")]
		public void SetLayerMeshSpace(int layerIndex, bool enable) {} // 0x0000000189D92B94-0x0000000189D92BE8
		[NativeMethod("GetLayerMeshSpace")]
		public bool GetLayerMeshSpace(int layerIndex) => default; // 0x0000000189D912C4-0x0000000189D91304
		[NativeMethod("SetControllerDefaultValues")]
		public void SetControllerDefaultValues(bool value) {} // 0x0000000189D923D4-0x0000000189D92418
		public float GetFloat(string name) => default; // 0x0000000184271FA0-0x0000000184271FAC
		public float GetFloat(int id) => default; // 0x0000000184270C3C-0x0000000184270C48
		public float GetFloatFromTransition(int layerIndex, int id) => default; // 0x0000000189D90E4C-0x0000000189D90E58
		public float GetFloatFromTransitionWithDefault(int layerIndex, int id, float defValue) => default; // 0x0000000184275FB0-0x0000000184275FC0
		public void SetFloat(string name, float value) {} // 0x00000001842706B4-0x00000001842706BC
		public void SetFloat(string name, float value, float dampTime, float deltaTime) {} // 0x0000000189D9274C-0x0000000189D9275C
		public void SetFloat(int id, float value) {} // 0x0000000184271FAC-0x0000000184271FB4
		public void SetFloat(int id, float value, float dampTime, float deltaTime) {} // 0x0000000189D9275C-0x0000000189D9276C
		public bool GetBool(string name) => default; // 0x0000000189D90B34-0x0000000189D90B40
		public bool GetBool(int id) => default; // 0x0000000184274670-0x000000018427467C
		public void SetBool(string name, bool value) {} // 0x0000000184276650-0x0000000184276658
		public void SetBool(int id, bool value) {} // 0x0000000184270030-0x0000000184270038
		public int GetInteger(string name) => default; // 0x0000000189D912B8-0x0000000189D912C4
		public int GetInteger(int id) => default; // 0x000000018426FFE8-0x000000018426FFF4
		public void SetInteger(string name, int value) {} // 0x0000000189D92B8C-0x0000000189D92B94
		public void SetInteger(int id, int value) {} // 0x0000000184270028-0x0000000184270030
		public void SetTrigger(string name) {} // 0x000000018426F564-0x000000018426F56C
		public void SetTrigger(int id) {} // 0x0000000189D931C8-0x0000000189D931D0
		public void ResetTrigger(string name) {} // 0x000000018426F55C-0x000000018426F564
		public void ResetTrigger(int id) {} // 0x0000000184270C34-0x0000000184270C3C
		public bool IsParameterControlledByCurve(string name) => default; // 0x0000000189D91A34-0x0000000189D91A40
		public bool IsParameterControlledByCurve(int id) => default; // 0x0000000189D91A40-0x0000000189D91A4C
		[NativeMethod("SetAllowConstantClipSamplingOpt")]
		public void SetAllowConstantClipSamplingOpt(bool enable) {} // 0x0000000189D91F8C-0x0000000189D91FD0
		public Vector3 GetIKPosition(AvatarIKGoal goal) => default; // 0x0000000189D9118C-0x0000000189D911EC
		private Vector3 GetGoalPosition(AvatarIKGoal goal) => default; // 0x0000000189D90EA8-0x0000000189D90ED8
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x0000000189D92A5C-0x0000000189D92AB0
		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x0000000189D927BC-0x0000000189D927D0
		public Quaternion GetIKRotation(AvatarIKGoal goal) => default; // 0x0000000189D9121C-0x0000000189D91274
		private Quaternion GetGoalRotation(AvatarIKGoal goal) => default; // 0x0000000189D90F28-0x0000000189D90F58
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x0000000189D92AF0-0x0000000189D92B38
		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x0000000189D92820-0x0000000189D92834
		public float GetIKPositionWeight(AvatarIKGoal goal) => default; // 0x0000000189D9115C-0x0000000189D9118C
		private float GetGoalWeightPosition(AvatarIKGoal goal) => default; // 0x0000000189D90F58-0x0000000189D90F98
		public void SetIKPositionWeight(AvatarIKGoal goal, float value) {} // 0x0000000189D92A1C-0x0000000189D92A5C
		private void SetGoalWeightPosition(AvatarIKGoal goal, float value) {} // 0x0000000189D92834-0x0000000189D92884
		public float GetIKRotationWeight(AvatarIKGoal goal) => default; // 0x0000000189D911EC-0x0000000189D9121C
		private float GetGoalWeightRotation(AvatarIKGoal goal) => default; // 0x0000000189D90F98-0x0000000189D90FD8
		public void SetIKRotationWeight(AvatarIKGoal goal, float value) {} // 0x0000000189D92AB0-0x0000000189D92AF0
		private void SetGoalWeightRotation(AvatarIKGoal goal, float value) {} // 0x0000000189D92884-0x0000000189D928D4
		public Vector3 GetIKHintPosition(AvatarIKHint hint) => default; // 0x0000000189D910FC-0x0000000189D9115C
		private Vector3 GetHintPosition(AvatarIKHint hint) => default; // 0x0000000189D9105C-0x0000000189D9108C
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) {} // 0x0000000189D929C8-0x0000000189D92A1C
		private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) {} // 0x0000000189D92924-0x0000000189D92938
		public float GetIKHintPositionWeight(AvatarIKHint hint) => default; // 0x0000000189D910CC-0x0000000189D910FC
		private float GetHintWeightPosition(AvatarIKHint hint) => default; // 0x0000000189D9108C-0x0000000189D910CC
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value) {} // 0x0000000189D92988-0x0000000189D929C8
		private void SetHintWeightPosition(AvatarIKHint hint, float value) {} // 0x0000000189D92938-0x0000000189D92988
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x0000000189D92C40-0x0000000189D92C84
		[NativeMethod("SetLookAtPosition")]
		private void SetLookAtPositionInternal(Vector3 lookAtPosition) {} // 0x0000000189D92C2C-0x0000000189D92C40
		public void SetLookAtWeight(float weight) {} // 0x0000000189D92EB0-0x0000000189D92F08
		public void SetLookAtWeight(float weight, float bodyWeight) {} // 0x0000000189D92CEC-0x0000000189D92D50
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) {} // 0x0000000189D92E40-0x0000000189D92EB0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) {} // 0x0000000189D92D50-0x0000000189D92DC8
		public void SetLookAtWeight(float weight, [UnityEngine.Internal.DefaultValue("0.0f")] float bodyWeight, [UnityEngine.Internal.DefaultValue("1.0f")] float headWeight, [UnityEngine.Internal.DefaultValue("0.0f")] float eyesWeight, [UnityEngine.Internal.DefaultValue("0.5f")] float clampWeight) {} // 0x0000000189D92DC8-0x0000000189D92E40
		[NativeMethod("SetLookAtWeight")]
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x0000000189D92C84-0x0000000189D92CEC
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) {} // 0x0000000189D921C8-0x0000000189D9221C
		[NativeMethod("SetBoneLocalRotation")]
		private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) {} // 0x0000000189D921B4-0x0000000189D921C8
		public void SetTransformHierarchy(bool bHas) {} // 0x0000000189D931C0-0x0000000189D931C8
		[NativeMethod("SetHasTransformHierarchy")]
		private void SetTransformHierarchyInternal(bool bHas) {} // 0x0000000183B33D60-0x0000000183B33DB0
		public bool GetBoneGlobalTRS(int avatarAssetBoneID, out AnimationTransformf trs) {
			trs = default;
			return default;
		} // 0x0000000189D9083C-0x0000000189D90848
		[NativeMethod("GetBoneGlobalTRS")]
		private bool GetBoneGlobalTRSInternal(int avatarAssetBoneID, out AnimationTransformf trs) {
			trs = default;
			return default;
		} // 0x0000000189D907EC-0x0000000189D9083C
		public AnimationTransformf GetBoneRootTRS(int avatarAssetBoneID) => default; // 0x0000000189D909A0-0x0000000189D909E8
		[NativeMethod("GetBoneRootTRS")]
		private AnimationTransformf GetBoneRootTRSInternal(int avatarAssetBoneID) => default; // 0x0000000189D90968-0x0000000189D909A0
		public AnimationTransformf GetBoneLocalTRS(int avatarAssetBoneID) => default; // 0x0000000189D908D0-0x0000000189D90918
		[NativeMethod("GetBoneLocalTRS")]
		private AnimationTransformf GetBoneLocalTRSInternal(int avatarAssetBoneID) => default; // 0x0000000189D90898-0x0000000189D908D0
		[NativeMethod("SetCorrectiveBoneData")]
		public void SetCorrectiveBoneData(HGCorrectiveBoneData bindings) {} // 0x0000000189D92418-0x0000000189D9245C
		[NativeMethod("SetEnableCorrectiveBoneSystem")]
		public void SetEnableCorrectiveBoneSystem(bool enable) {} // 0x0000000189D92578-0x0000000189D925BC
		[NativeMethod("SetSequenceLayerSkipTimeThreshold")]
		public void SetSequenceLayerSkipTimeThreshold(float value) {} // 0x0000000183000FB0-0x0000000183001000
		[NativeMethod("GetSequenceLayerSkipTimeThreshold")]
		public float GetSequenceLayerSkipTimeThreshold() => default; // 0x0000000189D91550-0x0000000189D91584
		[NativeMethod("ForceUpdateCorrectiveBoneDataInEditor")]
		public void ForceUpdateCorrectiveBoneDataInEditor() {} // 0x0000000189D90420-0x0000000189D90454
		[NativeMethod("SetBakedBindingData")]
		public void SetBakedBindingData(HGAnimationSetBindings bindings) {} // 0x0000000189D92120-0x0000000189D92164
		[NativeMethod("EnableBakedBindingData")]
		public void EnableBakedBindingData(bool enable) {} // 0x0000000189D90338-0x0000000189D9037C
		public bool SetClipByIndex(AnimationClip overrideClip, int index) => default; // 0x0000000189D9221C-0x0000000189D92270
		public void UnloadClipsNoRebind(AnimationClip[] overrideClip, bool clearCache = true /* Metadata: 0x01FD9BE8 */) {} // 0x0000000189D93324-0x0000000189D93378
		public void ReloadClipsNoRebind(AnimationClip[] overrideClip) {} // 0x0000000189D91ED4-0x0000000189D91F18
		public void CaptureLastHumanPose() {} // 0x00000001830F6980-0x00000001830F6A60
		public void SetWriteTransformDefAsPostProcess(bool enable) {} // 0x0000000183000F60-0x0000000183000FB0
		public void SetWriteTransformDefAsPostProcessSkipOpt(bool enable) {} // 0x0000000189D931D0-0x0000000189D93214
		public void SetAnimatorJobDispatchMode(AnimatorJobDispatchMode mode) {} // 0x0000000183850240-0x0000000183850290
		public AnimatorJobDispatchMode GetAnimatorJobDispatchMode() => default; // 0x0000000189D9054C-0x0000000189D90580
		[NativeMethod("AddToFrameSyncGroup")]
		public bool AddToFrameSyncGroup(string groupName, bool isMaster, AnimFrameSyncMode syncMode) => default; // 0x0000000189D8F58C-0x0000000189D8F5F0
		[NativeMethod("RemoveFromFrameSyncGroup")]
		public bool RemoveFromFrameSyncGroup() => default; // 0x0000000189D91F18-0x0000000189D91F4C
		public void SetEnableCollisionConstraintSolver(bool enable) {} // 0x0000000189D92534-0x0000000189D92578
		public void SetEnableDefaultValuesForceUseDefaultPose(bool enable) {} // 0x0000000189D925BC-0x0000000189D92600
		public bool IsEnableDefaultValuesForceUseDefaultPose() => default; // 0x0000000189D91948-0x0000000189D9197C
		public void SetEnableWriteDefaultValues(bool enable) {} // 0x0000000189D92644-0x0000000189D92688
		public void SetEnableClipBindingOpt(bool enable) {} // 0x0000000189D924F0-0x0000000189D92534
		public void SetEnableOptBindingByAvatar(bool enable) {} // 0x0000000189D92600-0x0000000189D92644
		public bool AddClipsToBindingsNoGrown(AnimationClip[] overrideClip, int nameHash = 0 /* Metadata: 0x01FD9BE9 */) => default; // 0x0000000182EF34D0-0x0000000182EF3530
		public void SetDynamicBindingReserveCount(int count) {} // 0x0000000182F49A90-0x0000000182F49AE0
		public void SetDynamicBindingReserveCountByTag(int stringHash, int count) {} // 0x0000000189D9245C-0x0000000189D924AC
		public void ReCreatePlayableMemory() {} // 0x0000000189D91E8C-0x0000000189D91EC0
		public AnimationTransformRWBufferHandle CreateClothBindings(Transform[] transformAccessArray) => default; // 0x0000000189D8F854-0x0000000189D8F89C
		public AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(string[] transformPathArray) => default; // 0x0000000189D8F7B8-0x0000000189D8F800
		public void DestroyClothBindings() {} // 0x0000000189D902D0-0x0000000189D90304
		public void EnableClothBindings() {} // 0x0000000189D9037C-0x0000000189D903B0
		public void DisableClothBindings() {} // 0x0000000189D90304-0x0000000189D90338
		public void SetClothBindingsEnableWorldSpace(bool value) {} // 0x0000000189D92270-0x0000000189D922B4
		public bool CheckClothBindingsEnableWorldSpace() => default; // 0x0000000189D8F624-0x0000000189D8F658
		public void SetMorphBindingsEnableWorldSpace(bool value) {} // 0x0000000189D92F08-0x0000000189D92F4C
		public bool CheckMorphBindingsEnableWorldSpace() => default; // 0x0000000189D8F6FC-0x0000000189D8F730
		public AnimationTransformRWBufferHandle CreateMorphBindings(Transform[] transformAccessArray) => default; // 0x0000000182FADD50-0x0000000182FADDA0
		public AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(string[] transformPathArray) => default; // 0x0000000189D8F8F0-0x0000000189D8F938
		public void EnableMorphBindings() {} // 0x0000000182FADD10-0x0000000182FADD50
		public void DisableMorphBindings() {} // 0x0000000182F5D9F0-0x0000000182F5DA30
		public void SetOptimizedAvatarDataSet(bool optimized) {} // 0x0000000183627320-0x0000000183627370
		public void SetEnabelMorphBindingWriteInLateUpdate(bool enable) {} // 0x0000000189D924AC-0x0000000189D924F0
		private ScriptableObject GetBehaviour([NotNull("ArgumentNullException")] System.Type type) => default; // 0x0000000189D90700-0x0000000189D90744
		public T GetBehaviour<T>()
			where T : StateMachineBehaviour => default;
		private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects)
			where T : StateMachineBehaviour => default;
		public T[] GetBehaviours<T>()
			where T : StateMachineBehaviour => default;
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehaviours([NotNull("ArgumentNullException")] System.Type type) => default; // 0x0000000189D91658-0x0000000189D9169C
		public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) => default; // 0x0000000189D90744-0x0000000189D907EC
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = true)]
		internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, [NotNull("ArgumentNullException")] System.Type type) => default; // 0x0000000189D915F8-0x0000000189D91658
		public string GetLayerName(int layerIndex) => default; // 0x0000000183A2D3F0-0x0000000183A2D440
		public int GetLayerIndex(string layerName) => default; // 0x0000000182EF3A40-0x0000000182EF3A90
		public float GetLayerWeight(int layerIndex) => default; // 0x0000000189D91304-0x0000000189D91344
		public void SetLayerWeight(int layerIndex, float weight) {} // 0x0000000183336E20-0x0000000183336E80
		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) {
			info = default;
		} // 0x000000018292F3B0-0x000000018292F420
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) => default; // 0x000000018292F300-0x000000018292F3B0
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) => default; // 0x000000018292F240-0x000000018292F300
		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) {
			info = default;
		} // 0x0000000189D90630-0x0000000189D90680
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) => default; // 0x0000000189D90680-0x0000000189D906D4
		internal int GetAnimatorClipInfoCount(int layerIndex, bool current) => default; // 0x0000000189D90498-0x0000000189D904EC
		public int GetCurrentAnimatorClipInfoCount(int layerIndex) => default; // 0x0000000189D90B40-0x0000000189D90B50
		public int GetNextAnimatorClipInfoCount(int layerIndex) => default; // 0x0000000189D913F0-0x0000000189D91400
		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) => default; // 0x0000000189D90BC8-0x0000000189D90C08
		[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) => default; // 0x0000000189D91478-0x0000000189D914B8
		public bool GetDebugAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) => default; // 0x0000000189D90D90-0x0000000189D90DFC
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) {} // 0x0000000189D90B50-0x0000000189D90BC8
		[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
		private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) {} // 0x0000000189D904EC-0x0000000189D9054C
		[FreeFunction(Name = "AnimatorBindings::GetDebugAnimatorClipInfoInternal", HasExplicitThis = true)]
		private bool GetDebugAnimatorClipInfoInternal(int layerIndex, object clips) => default; // 0x0000000189D90D40-0x0000000189D90D90
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) {} // 0x0000000189D91400-0x0000000189D91478
		public bool IsInTransition(int layerIndex) => default; // 0x000000018292F420-0x000000018292F470
		public bool IsPlayingTag(int layerIndex, int tagHash) => default; // 0x0000000182931680-0x00000001829316E0
		public bool IsPlayingState(int layerIndex, int stateNameHash) => default; // 0x000000018272A910-0x000000018272A970
		public int GetAnimatorStateCullMode(int layerIndex) => default; // 0x00000001829318B0-0x0000000182931900
		public AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(int layerIndex) => default; // 0x0000000189D90C08-0x0000000189D90CB8
		private void GetAnimatorStateRootMotionInfo(int layerIndex, out AnimatorStateRootMotionInfo output) {
			output = default;
		} // 0x0000000189D905E0-0x0000000189D90630
		public bool HasTrigger(int triggerId) => default; // 0x0000000189D915B8-0x0000000189D915F8
		[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = true)]
		private AnimatorControllerParameter GetParameterInternal(int index) => default; // 0x00000001839DD090-0x00000001839DD0E0
		public AnimatorControllerParameter GetParameter(int index) => default; // 0x00000001839DD050-0x00000001839DD090
		private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) {} // 0x0000000189D91BA8-0x0000000189D91BF8
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) {} // 0x0000000189D91B2C-0x0000000189D91BA8
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime) {} // 0x0000000189D91AB0-0x0000000189D91B2C
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [UnityEngine.Internal.DefaultValue("1")] float targetNormalizedTime, [UnityEngine.Internal.DefaultValue("true")] bool completeMatch) {} // 0x0000000189D91BF8-0x0000000189D91C7C
		public void InterruptMatchTarget() {} // 0x0000000189D918F8-0x0000000189D91904
		public void InterruptMatchTarget([UnityEngine.Internal.DefaultValue("true")] bool completeMatch) {} // 0x0000000189D918B4-0x0000000189D918F8
		[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
		public void ForceStateNormalizedTime(float normalizedTime) {} // 0x0000000189D90400-0x0000000189D90420
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) {} // 0x0000000189D8FCDC-0x0000000189D8FD2C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) {} // 0x0000000189D8FAA0-0x0000000189D8FAFC
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) {} // 0x0000000189D8FBAC-0x0000000189D8FC10
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FAFC-0x0000000189D8FB6C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8F9A4-0x0000000189D8FA1C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x0000000189D8FD2C-0x0000000189D8FDB0
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FA1C-0x0000000189D8FAA0
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) {} // 0x0000000189D8FB6C-0x0000000189D8FBAC
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) {} // 0x0000000189D8FC10-0x0000000189D8FC4C
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) {} // 0x0000000189D8F938-0x0000000189D8F96C
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) {} // 0x0000000189D8F96C-0x0000000189D8F9A4
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FC4C-0x0000000189D8FC98
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x000000018278DC00-0x000000018278DC50
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FC98-0x0000000189D8FCDC
		[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = true)]
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float fixedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion) {} // 0x000000018278DC50-0x000000018278DCD0
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = true)]
		public void WriteDefaultValues() {} // 0x0000000189D933AC-0x0000000189D933E0
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValuesDirty", HasExplicitThis = true)]
		public void WriteDefaultValuesDirty() {} // 0x0000000182D27BF0-0x0000000182D27C30
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) {} // 0x0000000189D90188-0x0000000189D901C4
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) {} // 0x0000000189D8FEA0-0x0000000189D8FED8
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) {} // 0x0000000189D8FE6C-0x0000000189D8FEA0
		public void CrossFade(string stateName, float normalizedTransitionDuration) {} // 0x0000000189D90100-0x0000000189D9013C
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource, bool enableBlendRootMotion) {} // 0x0000000189D901C4-0x0000000189D90248
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FDB0-0x0000000189D8FE30
		public void CrossFade(string stateName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D90004-0x0000000189D9007C
		public void CrossFade(string stateName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D9007C-0x0000000189D90100
		[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTimeOffset, [UnityEngine.Internal.DefaultValue("0.0f")] float normalizedTransitionTime, [UnityEngine.Internal.DefaultValue("AnimationBlendStyle.Linear")] AnimationBlendStyle blendStyle, [UnityEngine.Internal.DefaultValue("AnimatorTransitionInterruptionSource.None")] AnimatorTransitionInterruptionSource interruptionSource, [UnityEngine.Internal.DefaultValue("true")] bool enableBlendRootMotion) {} // 0x0000000189D8FF64-0x0000000189D8FFC4
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) {} // 0x0000000189D8FED8-0x0000000189D8FF18
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) {} // 0x0000000189D90248-0x0000000189D90284
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) {} // 0x0000000189D8FE30-0x0000000189D8FE6C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration) {} // 0x0000000189D8FFC4-0x0000000189D90004
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D9013C-0x0000000189D90188
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D8FF18-0x0000000189D8FF64
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, AnimationBlendStyle blendStyle, AnimatorTransitionInterruptionSource interruptionSource) {} // 0x0000000189D90284-0x0000000189D902D0
		[FreeFunction(Name = "AnimatorBindings::ResetToDefaultStates", HasExplicitThis = true)]
		public void ResetToDefaultStates() {} // 0x0000000183CB7F70-0x0000000183CB7FB0
		public void PlayInFixedTime(string stateName, int layer) {} // 0x0000000189D91D7C-0x0000000189D91D9C
		public void PlayInFixedTime(string stateName) {} // 0x0000000189D91D04-0x0000000189D91D2C
		public void PlayInFixedTime(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime) {} // 0x0000000189D91D2C-0x0000000189D91D7C
		[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = true)]
		public void PlayInFixedTime(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float fixedTime) {} // 0x0000000189D91D9C-0x0000000189D91DFC
		public void PlayInFixedTime(int stateNameHash, int layer) {} // 0x0000000189D91CE4-0x0000000189D91D04
		public void PlayInFixedTime(int stateNameHash) {} // 0x0000000189D91DFC-0x0000000189D91E24
		public void Play(string stateName, int layer) {} // 0x0000000189D91E24-0x0000000189D91E44
		public void Play(string stateName) {} // 0x000000018285CE40-0x000000018285CE70
		public void Play(string stateName, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime) {} // 0x000000018285D3C0-0x000000018285D410
		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [UnityEngine.Internal.DefaultValue("-1")] int layer, [UnityEngine.Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime) {} // 0x000000018285D410-0x000000018285D480
		public void Play(int stateNameHash, int layer) {} // 0x0000000189D91E44-0x0000000189D91E64
		public void Play(int stateNameHash) {} // 0x0000000189D91E64-0x0000000189D91E8C
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) {} // 0x0000000189D93170-0x0000000189D931C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", true)]
		public bool IsControlled(Transform transform) => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		internal bool IsBoneTransform(Transform transform) => default; // 0x0000000189D91904-0x0000000189D91948
		public Transform GetBoneTransform(HumanBodyBones humanBoneId) => default; // 0x0000000189D90A28-0x0000000189D90AF0
		[NativeMethod("GetBoneTransform")]
		internal Transform GetBoneTransformInternal(int humanBoneId) => default; // 0x0000000189D909E8-0x0000000189D90A28
		public Transform GetBoneTransformByBoneId(int boneID) => default; // 0x00000001829F0300-0x00000001829F0320
		[NativeMethod("GetBoneTransformByBoneId")]
		internal Transform GetBoneTransformByBoneIdInternal(int boneId) => default; // 0x00000001829F02B0-0x00000001829F0300
		public void StartPlayback() {} // 0x0000000189D93214-0x0000000189D93248
		public void StopPlayback() {} // 0x0000000189D93288-0x0000000189D932BC
		public void StartRecording(int frameCount) {} // 0x0000000189D93248-0x0000000189D93288
		public void StopRecording() {} // 0x0000000189D932BC-0x0000000189D932F0
		private float GetRecorderStartTime() => default; // 0x0000000189D914E8-0x0000000189D9151C
		private float GetRecorderStopTime() => default; // 0x0000000189D9151C-0x0000000189D91550
		internal void ClearInternalControllerPlayable() {} // 0x0000000189D8F730-0x0000000189D8F764
		public bool HasState(int layerIndex, int stateID) => default; // 0x0000000182F496D0-0x0000000182F49730
		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name) => default; // 0x000000018291C100-0x000000018291C140
		[NativeMethod(Name = "StringToHashCRC32", IsThreadSafe = true)]
		public static int StringToHashCRC32(IntPtr name) => default; // 0x0000000189D932F0-0x0000000189D93324
		internal string GetStats() => default; // 0x0000000189D91584-0x0000000189D915B8
		[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = true)]
		private void GetCurrentGraph(ref PlayableGraph graph) {} // 0x0000000189D90CB8-0x0000000189D90CFC
		private void CheckIfInIKPass() {} // 0x0000000189D8F68C-0x0000000189D8F6FC
		private bool IsInIKPass() => default; // 0x0000000189D9197C-0x0000000189D919B0
		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private void SetFloatString(string name, float value) {} // 0x00000001830FDBE0-0x00000001830FDC40
		[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private void SetFloatID(int id, float value) {} // 0x0000000182EECE10-0x0000000182EED000
		[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
		private float GetFloatString(string name) => default; // 0x0000000183300150-0x00000001833002E0
		[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
		private float GetFloatID(int id) => default; // 0x0000000182D85B80-0x0000000182D85C90
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByID", HasExplicitThis = true)]
		private float GetFloatFromTransitionByID(int layerIndex, int id) => default; // 0x0000000189D90DFC-0x0000000189D90E4C
		[FreeFunction(Name = "AnimatorBindings::GetFloatFromTransitionByIDWithDefault", HasExplicitThis = true)]
		private float GetFloatFromTransitionByIDWithDefault(int layerIndex, int id, float defValue) => default; // 0x00000001836C6D20-0x00000001836C6D90
		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private void SetBoolString(string name, bool value) {} // 0x00000001838D1DC0-0x00000001838D1E70
		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private void SetBoolID(int id, bool value) {} // 0x000000018349AD90-0x000000018349ADF0
		[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = true)]
		private bool GetBoolString(string name) => default; // 0x0000000189D90AF0-0x0000000189D90B34
		[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
		private bool GetBoolID(int id) => default; // 0x00000001832DA0C0-0x00000001832DA110
		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		private void SetIntegerString(string name, int value) {} // 0x0000000189D92B38-0x0000000189D92B8C
		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		private void SetIntegerID(int id, int value) {} // 0x0000000183856710-0x0000000183856770
		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		private int GetIntegerString(string name) => default; // 0x0000000189D91274-0x0000000189D912B8
		[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
		private int GetIntegerID(int id) => default; // 0x00000001832707D0-0x0000000183270820
		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name) {} // 0x0000000183495FC0-0x0000000183496010
		[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		private void SetTriggerID(int id) {} // 0x00000001838E93C0-0x00000001838E9410
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name) {} // 0x0000000183295E30-0x0000000183295E80
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
		private void ResetTriggerID(int id) {} // 0x0000000182E97050-0x0000000182E970A0
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveString(string name) => default; // 0x0000000189D919F0-0x0000000189D91A34
		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveID(int id) => default; // 0x0000000189D919B0-0x0000000189D919F0
		[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = true)]
		private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) {} // 0x0000000189D926E8-0x0000000189D9274C
		[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = true)]
		private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) {} // 0x0000000189D92688-0x0000000189D926E8
		public HGAnimParameterSGHandle[] GetHGParameterHandles() => default; // 0x0000000189D90FD8-0x0000000189D9100C
		public bool CheckHGParmeterHandleValid() => default; // 0x0000000189D8F658-0x0000000189D8F68C
		[NativeMethod("GetMorphBoneCount")]
		public int GetMorphBoneCount() => default; // 0x0000000189D91344-0x0000000189D91378
		public void GetMorphBoneIds(NativeArray<int> arrayToFill) {} // 0x0000000189D913CC-0x0000000189D913F0
		public void GetMorphBoneIdsUnsafe(int count, NativeArray<int> arrayToFill) {} // 0x0000000189D91378-0x0000000189D913CC
		[NativeMethod("Internal_GetMorphBoneIds")]
		private void Internal_GetMorphBoneIds(int count, IntPtr arrayToFill) {} // 0x0000000189D91804-0x0000000189D91854
		public void SetMorphTransforms(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale) {} // 0x0000000189D93048-0x0000000189D930A0
		public void SetMorphTransformsUnsafe(NativeArray<int> boneIds, NativeArray<Vector3> translation, NativeArray<Vector3> euler, NativeArray<Vector3> scale) {} // 0x0000000189D92F4C-0x0000000189D93048
		[NativeMethod("Internal_SetMorphTransforms")]
		private void Internal_SetMorphTransforms(int count, IntPtr boneIds, IntPtr translation, IntPtr euler, IntPtr scale) {} // 0x0000000189D91854-0x0000000189D918B4
		[NativeConditional("UNITY_EDITOR")]
		internal void OnUpdateModeChanged() {} // 0x0000000189D91CB0-0x0000000189D91CE4
		[NativeConditional("UNITY_EDITOR")]
		internal void OnCullingModeChanged() {} // 0x0000000189D91C7C-0x0000000189D91CB0
		[NativeConditional("UNITY_EDITOR")]
		internal void WriteDefaultPose() {} // 0x0000000189D93378-0x0000000189D933AC
		[NativeMethod("UpdateWithDelta")]
		public void Update(float deltaTime) {} // 0x00000001833D4680-0x00000001833D46D0
		[NativeMethod("ForceUpdateWithDelta")]
		public void ForceUpdate(float deltaTime) {} // 0x0000000189D90454-0x0000000189D90498
		public void Rebind() {} // 0x0000000189D91EC0-0x0000000189D91ECC
		private void Rebind(bool writeDefaultValues) {} // 0x0000000183D00B20-0x0000000183D00B70
		public void ApplyBuiltinRootMotion() {} // 0x0000000189D8F5F0-0x0000000189D8F624
		[NativeConditional("UNITY_EDITOR")]
		internal void EvaluateController() {} // 0x0000000189D903F4-0x0000000189D90400
		private void EvaluateController(float deltaTime) {} // 0x0000000189D903B0-0x0000000189D903F4
		[NativeConditional("UNITY_EDITOR")]
		internal string GetCurrentStateName(int layerIndex) => default; // 0x0000000189D90D30-0x0000000189D90D40
		[NativeConditional("UNITY_EDITOR")]
		internal string GetNextStateName(int layerIndex) => default; // 0x0000000189D914B8-0x0000000189D914C8
		[NativeConditional("UNITY_EDITOR")]
		private string GetAnimatorStateName(int layerIndex, bool current) => default; // 0x0000000189D9058C-0x0000000189D905E0
		internal string ResolveHash(int hash) => default; // 0x0000000189D91F4C-0x0000000189D91F8C
		public string GetAnimatorStateName(int stateID) => default; // 0x0000000189D90580-0x0000000189D9058C
		public void GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime = 0f /* Metadata: 0x01FD9BEA */, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x01FD9BEE */) {} // 0x0000000184276254-0x0000000184276264
		public void GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle = AnimationBlendStyle.Linear /* Metadata: 0x01FD9BEF */) {} // 0x0000000184270040-0x0000000184270050
		public void SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x01FD9BF0 */) {} // 0x0000000184274798-0x00000001842747A0
		public void RefreshStateOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x0000000184270038-0x0000000184270040
		public void SetRuntimeControllerNoRebind(RuntimeAnimatorController controller) {} // 0x0000000184272C58-0x0000000184272C60
		public void RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x0000000189D91ECC-0x0000000189D91ED4
		[NativeMethod("GotoState")]
		internal void Internal_GotoState(int layer, int stateId, float normalizedTime, float transitionDuration, float transitionTime, AnimationBlendStyle blendStyle) {} // 0x0000000183C8F890-0x0000000183C8F900
		[NativeMethod("GotoStateInFixedTime")]
		internal void Internal_GotoStateInFixedTime(int layerIndex, int stateId, float fixedTime, float fixedTransitionDuration, float normalizedTransitionTime, AnimationBlendStyle blendStyle) {} // 0x0000000183C8F900-0x0000000183C8F970
		[NativeMethod("SetAnimationStateOverride")]
		internal void Internal_SetAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride, bool rebind = true /* Metadata: 0x01FD9BF1 */) {} // 0x00000001839CF8F0-0x00000001839CF950
		[NativeMethod("RefreshAnimationStateOverride")]
		internal void Internal_RefreshAnimationStateOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x0000000183CA4370-0x0000000183CA43C0
		[NativeMethod("SetRuntimeControllerNoRebind")]
		internal void Internal_SetRuntimeControllerNoRebind(RuntimeAnimatorController controller) {} // 0x0000000183CA4320-0x0000000183CA4370
		[NativeMethod("RefreshAnimationStateAsyncCompleteOverride")]
		internal void Internal_RefreshAnimationStateAsyncCompleteOverride(RuntimeAnimatorStateOverride stateOverride) {} // 0x0000000183B13590-0x0000000183B135E0
		public void SetAvatarNoBind(Avatar avatar) {} // 0x0000000184275140-0x0000000184275148
		[NativeMethod("SetAvatarNoBind")]
		internal void Internal_SetAvatarNoBind(Avatar avatar) {} // 0x0000000183626660-0x00000001836266B0
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name) => default; // 0x0000000183D86AF0-0x0000000183D86B10
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id) => default; // 0x0000000183D86AF0-0x0000000183D86B10
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name) => default; // 0x0000000189D914C8-0x0000000189D914E8
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id) => default; // 0x0000000189D914C8-0x0000000189D914E8
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value) {} // 0x000000018350B670-0x000000018350B680
		private void get_deltaPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000182D664F0-0x0000000182D66540
		private void get_deltaRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001831DEB90-0x00000001831DEBE0
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000182D66390-0x0000000182D663E0
		private void get_angularVelocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000182D66440-0x0000000182D66490
		private void get_rootPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189D93D6C-0x0000000189D93DB0
		private void set_rootPosition_Injected(ref Vector3 value) {} // 0x0000000189D94590-0x0000000189D945D4
		private void get_rootRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000189D93DDC-0x0000000189D93E20
		private void set_rootRotation_Injected(ref Quaternion value) {} // 0x0000000189D945E8-0x0000000189D9462C
		private void get_bodyPositionInternal_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189D93514-0x0000000189D93558
		private void set_bodyPositionInternal_Injected(ref Vector3 value) {} // 0x0000000189D940E8-0x0000000189D9412C
		private void get_bodyRotationInternal_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000189D935D4-0x0000000189D93618
		private void set_bodyRotationInternal_Injected(ref Quaternion value) {} // 0x0000000189D94184-0x0000000189D941C8
		private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D90E58-0x0000000189D90EA8
		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) {} // 0x0000000189D9276C-0x0000000189D927BC
		private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D90ED8-0x0000000189D90F28
		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) {} // 0x0000000189D927D0-0x0000000189D92820
		private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D9100C-0x0000000189D9105C
		private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) {} // 0x0000000189D928D4-0x0000000189D92924
		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) {} // 0x0000000189D92BE8-0x0000000189D92C2C
		private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) {} // 0x0000000189D92164-0x0000000189D921B4
		private void GetBoneRootTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret) {
			ret = default;
		} // 0x0000000189D90918-0x0000000189D90968
		private void GetBoneLocalTRSInternal_Injected(int avatarAssetBoneID, out AnimationTransformf ret) {
			ret = default;
		} // 0x0000000189D90848-0x0000000189D90898
		private void CreateClothBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x0000000189D8F800-0x0000000189D8F854
		private void CreateClothBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x0000000189D8F764-0x0000000189D8F7B8
		private void CreateMorphBindings_Injected(Transform[] transformAccessArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x0000000182FADCB0-0x0000000182FADD10
		private void CreateMorphBindingsByNameLst_Injected(string[] transformPathArray, out AnimationTransformRWBufferHandle ret) {
			ret = default;
		} // 0x0000000189D8F89C-0x0000000189D8F8F0
		private void get_pivotPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189D93BA8-0x0000000189D93BEC
		private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) {} // 0x0000000189D91A4C-0x0000000189D91AB0
		private void get_targetPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189D93EE8-0x0000000189D93F2C
		private void get_targetRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000189D93F58-0x0000000189D93F9C
	}

	[NativeAsStruct]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
	[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
	[UsedByNativeCode]
	public class AnimatorControllerParameter // TypeDefIndex: 57113
	{
		// Fields
		internal string m_Name; // 0x10
		internal AnimatorControllerParameterType m_Type; // 0x18
		internal float m_DefaultFloat; // 0x1C
		internal int m_DefaultInt; // 0x20
		internal bool m_DefaultBool; // 0x24
	
		// Properties
		public string name { get => default; } // 0x0000000183D66B80-0x0000000183D66B90 
		public int nameHash { get => default; } // 0x0000000184274684-0x0000000184274694 
		public AnimatorControllerParameterType type { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
	
		// Constructors
		public AnimatorControllerParameter() {} // 0x0000000189D8E1F8-0x0000000189D8E238
	
		// Methods
		public override bool Equals(object o) => default; // 0x0000000189D8E160-0x0000000189D8E1F8
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	[Serializable]
	[Obsolete("This class is not used anymore. See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
	public class AnimationClipPair // TypeDefIndex: 57114
	{
		// Fields
		public AnimationClip originalClip; // 0x10
		public AnimationClip overrideClip; // 0x18
	
		// Constructors
		public AnimationClipPair() {} // 0x000000018350B670-0x000000018350B680
	}

	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 57116
	{
		// Fields
		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18
	
		// Properties
		public RuntimeAnimatorController runtimeAnimatorController { [NativeMethod("GetAnimatorController")] get => default; [NativeMethod("SetAnimatorController")] set {} } // 0x0000000189D8F350-0x0000000189D8F384 0x0000000189D8F4AC-0x0000000189D8F4F0
		public AnimationClip this[string name] { get => default; set {} } // 0x0000000189D8F15C-0x0000000189D8F16C 0x0000000189D8F3A0-0x0000000189D8F3A8
		public AnimationClip this[AnimationClip clip] { get => default; set {} } // 0x0000000189D8F14C-0x0000000189D8F15C 0x0000000189D8F384-0x0000000189D8F3A0
		public bool enableBindingOpt { [NativeMethod("GetEnableClipBindingOpt")] get => default; [NativeMethod("SetEnableClipBindingOpt")] set {} } // 0x0000000189D8F2B4-0x0000000189D8F2E8 0x0000000189D8F424-0x0000000189D8F468
		public byte reserveCount { [NativeMethod("GetReserveCount")] get => default; [NativeMethod("SetReserveCount")] set {} } // 0x0000000189D8F31C-0x0000000189D8F350 0x0000000189D8F468-0x0000000189D8F4AC
		public int overridesCount { [NativeMethod("GetOriginalClipsCount")] get => default; } // 0x0000000189D8F2E8-0x0000000189D8F31C 
		[Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
		public AnimationClipPair[] clips { get => default; set {} } // 0x0000000189D8F16C-0x0000000189D8F2B4 0x0000000189D8F3A8-0x0000000189D8F424
	
		// Nested types
		internal delegate void OnOverrideControllerDirtyCallback(); // TypeDefIndex: 57115; 0x00000001842BE03C-0x00000001842BE04C
	
		// Constructors
		public AnimatorOverrideController() {} // 0x0000000189D8F0D8-0x0000000189D8F10C
		public AnimatorOverrideController(RuntimeAnimatorController controller) {} // 0x0000000189D8F10C-0x0000000189D8F14C
	
		// Methods
		[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
		private static void Internal_Create([Writable] AnimatorOverrideController self, RuntimeAnimatorController controller) {} // 0x0000000189D8EEF4-0x0000000189D8EF38
		[NativeMethod("GetClip")]
		private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) => default; // 0x0000000189D8EF38-0x0000000189D8EF8C
		[NativeMethod("SetClip")]
		private void Internal_SetClipByName(string name, AnimationClip clip) {} // 0x0000000189D8EF8C-0x0000000189D8EFE0
		private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) => default; // 0x0000000189D8EC98-0x0000000189D8ECEC
		private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) {} // 0x0000000189D8F074-0x0000000189D8F0D8
		private void SendNotification() {} // 0x0000000189D8F040-0x0000000189D8F074
		private AnimationClip GetOriginalClip(int index) => default; // 0x0000000189D8ECEC-0x0000000189D8ED2C
		private AnimationClip GetOverrideClip(AnimationClip originalClip) => default; // 0x0000000189D8ED2C-0x0000000189D8ED70
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides) {} // 0x0000000189D8ED70-0x0000000189D8EEF4
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides) {} // 0x0000000189D8EB6C-0x0000000189D8EC98
		[NativeConditional("UNITY_EDITOR")]
		internal void PerformOverrideClipListCleanup() {} // 0x0000000189D8F00C-0x0000000189D8F040
		[NativeConditional("UNITY_EDITOR")]
		[RequiredByNativeCode]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) {} // 0x0000000189D8EFE0-0x0000000189D8F00C
	}

	[NativeHeader("Modules/Animation/OptimizeTransformHierarchy.h")]
	public class AnimatorUtility // TypeDefIndex: 57117
	{
		// Constructors
		public AnimatorUtility() {} // Dummy constructor
	
		// Methods
		[FreeFunction]
		public static void OptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go, string[] exposedTransforms) {} // 0x0000000183627370-0x00000001836273C0
		[FreeFunction]
		public static void DeoptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go) {} // 0x0000000183C7DB90-0x0000000183C7DBD0
	}

	public enum HumanBodyBones // TypeDefIndex: 57118
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
	public struct AnimationTransformf // TypeDefIndex: 57119
	{
		// Fields
		public Vector3 t; // 0x00
		public Quaternion q; // 0x0C
		public Vector3 s; // 0x1C
	}

	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : UnityEngine.Object // TypeDefIndex: 57120
	{
		// Properties
		public bool isValid { [NativeMethod("IsValid")] get => default; } // 0x00000001822D5F00-0x00000001822D5F40 
		public bool isHuman { [NativeMethod("IsHuman")] get => default; } // 0x00000001829F0F10-0x00000001829F0F50 
		public HumanDescription humanDescription { get => default; } // 0x0000000189D94E3C-0x0000000189D94E74 
	
		// Constructors
		private Avatar() {} // 0x0000000189D94DB8-0x0000000189D94DF8
	
		// Methods
		internal void SetMuscleMinMax(int muscleId, float min, float max) {} // 0x0000000189D94D08-0x0000000189D94D68
		internal void SetParameter(int parameterId, float value) {} // 0x0000000189D94D68-0x0000000189D94DB8
		internal float GetAxisLength(int humanId) => default; // 0x0000000189D947D4-0x0000000189D947FC
		internal Quaternion GetPreRotation(int humanId) => default; // 0x0000000189D948CC-0x0000000189D94914
		internal Quaternion GetPostRotation(int humanId) => default; // 0x0000000189D94884-0x0000000189D948CC
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) => default; // 0x0000000189D94914-0x0000000189D94998
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw) => default; // 0x0000000189D94998-0x0000000189D94A08
		internal Vector3 GetLimitSign(int humanId) => default; // 0x0000000189D94830-0x0000000189D94884
		[NativeMethod("GetAxisLength")]
		internal float Internal_GetAxisLength(int humanId) => default; // 0x0000000189D94A08-0x0000000189D94A48
		[NativeMethod("GetPreRotation")]
		internal Quaternion Internal_GetPreRotation(int humanId) => default; // 0x0000000189D94B98-0x0000000189D94BC8
		[NativeMethod("GetPostRotation")]
		internal Quaternion Internal_GetPostRotation(int humanId) => default; // 0x0000000189D94B18-0x0000000189D94B48
		[NativeMethod("GetZYPostQ")]
		internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) => default; // 0x0000000189D94C28-0x0000000189D94C6C
		[NativeMethod("GetZYRoll")]
		internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) => default; // 0x0000000189D94CCC-0x0000000189D94D08
		[NativeMethod("GetLimitSign")]
		internal Vector3 Internal_GetLimitSign(int humanId) => default; // 0x0000000189D94A98-0x0000000189D94AC8
		[NativeMethod("GetBonePaths")]
		public string[] GetBonePaths() => default; // 0x0000000189D947FC-0x0000000189D94830
		private void get_humanDescription_Injected(out HumanDescription ret) {
			ret = default;
		} // 0x0000000189D94DF8-0x0000000189D94E3C
		private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D94B48-0x0000000189D94B98
		private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D94AC8-0x0000000189D94B18
		private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D94BC8-0x0000000189D94C28
		private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D94C6C-0x0000000189D94CCC
		private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D94A48-0x0000000189D94A98
	}

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[RequiredByNativeCode]
	public struct SkeletonBone // TypeDefIndex: 57121
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

	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	[NativeType(CodegenOptions.Custom, "MonoHumanLimit")]
	public struct HumanLimit // TypeDefIndex: 57122
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
	public struct HumanBone // TypeDefIndex: 57123
	{
		// Fields
		private string m_BoneName; // 0x00
		private string m_HumanName; // 0x08
		[NativeName("m_Limit")]
		public HumanLimit limit; // 0x10
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct HumanDescription // TypeDefIndex: 57124
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
	public enum AvatarMaskBodyPart // TypeDefIndex: 57125
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
	public sealed class AvatarMask : UnityEngine.Object // TypeDefIndex: 57126
	{
		// Properties
		public int transformCount { get => default; } // 0x0000000189D947A0-0x0000000189D947D4 
	
		// Constructors
		public AvatarMask() {} // Dummy constructor
	
		// Methods
		[NativeMethod("GetBodyPart")]
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) => default; // 0x0000000189D946C4-0x0000000189D94704
		public string GetTransformPath(int index) => default; // 0x0000000189D94720-0x0000000189D94760
		private float GetTransformWeight(int index) => default; // 0x0000000189D94760-0x0000000189D947A0
		public bool GetTransformActive(int index) => default; // 0x0000000189D94704-0x0000000189D94720
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/HGAnimationSetBinding.h")]
	[UsedByNativeCode]
	public class HGAnimationSetBindings : UnityEngine.Object // TypeDefIndex: 57127
	{
		// Constructors
		public HGAnimationSetBindings() {} // Dummy constructor
	}

	[Serializable]
	[NativeHeader("Modules/Animation/HGAnimExtra/HGCorrectiveBoneData.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class HGCorrectiveBoneData : UnityEngine.Object // TypeDefIndex: 57128
	{
		// Constructors
		public HGCorrectiveBoneData() {} // 0x0000000189D94EA8-0x0000000189D94EF4
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHGAnimCorrectiveBoneData")]
		private static void Internal_Create([Writable] HGCorrectiveBoneData self) {} // 0x0000000189D94E74-0x0000000189D94EA8
	}

	[NativeHeader("Modules/Animation/ScriptBindings/SkeletalMorph.bindings.h")]
	[NativeHeader("Modules/Animation/HGSkeletalMorphAvatar.h")]
	[UsedByNativeCode]
	public sealed class HGSkeletalMorphAvatar : UnityEngine.Object // TypeDefIndex: 57129
	{
		// Constructors
		private HGSkeletalMorphAvatar() {} // 0x0000000189D94F28-0x0000000189D94F74
	
		// Methods
		[FreeFunction("SkeletalMorphBindings::CreateSkeletalMorphAvatar")]
		private static void Internal_Create([Writable] HGSkeletalMorphAvatar self) {} // 0x0000000189D94EF4-0x0000000189D94F28
	}

	public struct HumanPose // TypeDefIndex: 57130
	{
		// Fields
		public Vector3 bodyPosition; // 0x00
		public Quaternion bodyRotation; // 0x0C
		public float[] muscles; // 0x20
	
		// Methods
		internal void Init() {} // 0x0000000189D95350-0x0000000189D95454
	}

	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/HumanPoseHandler.h")]
	public class HumanPoseHandler : IDisposable // TypeDefIndex: 57131
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public HumanPoseHandler() {} // Dummy constructor
		public HumanPoseHandler(Avatar avatar, Transform root) {} // 0x0000000189D95144-0x0000000189D95350
	
		// Methods
		[FreeFunction("AnimationBindings::CreateHumanPoseHandler")]
		private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root) => default; // 0x0000000189D950CC-0x0000000189D95110
		[FreeFunction("AnimationBindings::DestroyHumanPoseHandler")]
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000189D95110-0x0000000189D95144
		private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, out float[] muscles) {
			bodyPosition = default;
			bodyRotation = default;
			muscles = default;
		} // 0x0000000189D94FCC-0x0000000189D95030
		public void Dispose() {} // 0x0000000189D94F74-0x0000000189D94FCC
		public void GetHumanPose(ref HumanPose humanPose) {} // 0x0000000189D95030-0x0000000189D950CC
	}

	[NativeHeader("Modules/Animation/HumanTrait.h")]
	public class HumanTrait // TypeDefIndex: 57132
	{
		// Properties
		public static int MuscleCount { get => default; } // 0x0000000189D95488-0x0000000189D954B4 
		public static string[] MuscleName { [NativeMethod("GetMuscleNames")] get => default; } // 0x0000000189D954B4-0x0000000189D954E0 
	
		// Constructors
		public HumanTrait() {} // Dummy constructor
	
		// Methods
		internal static int GetBoneIndexFromMono(int humanId) => default; // 0x0000000189D95454-0x0000000189D95488
	}

	[NativeHeader("Modules/Animation/LodBoneMask.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class LodBoneMask : UnityEngine.Object // TypeDefIndex: 57133
	{
		// Constructors
		public LodBoneMask() {} // 0x0000000189D95514-0x0000000189D95560
	
		// Methods
		[FreeFunction("AnimationBindings::CreateLodBoneMask")]
		private static void Internal_Create([Writable] LodBoneMask self) {} // 0x0000000189D954E0-0x0000000189D95514
	}

	[NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : UnityEngine.Object // TypeDefIndex: 57134
	{
		// Properties
		public bool isLooping { [NativeMethod("IsLooping")] get => default; } // 0x0000000182966620-0x0000000182966660 
	
		// Constructors
		protected Motion() {} // 0x00000001833570F0-0x0000000183357130
	}

	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorController : UnityEngine.Object // TypeDefIndex: 57135
	{
		// Properties
		public AnimationClip[] animationClips { get => default; } // 0x0000000183CB7F30-0x0000000183CB7F70 
	
		// Constructors
		protected RuntimeAnimatorController() {} // 0x0000000189D95D30-0x0000000189D95D70
	}

	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorStateOverride.h")]
	[NativeType("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	public class RuntimeAnimatorStateOverride : UnityEngine.Object // TypeDefIndex: 57136
	{
		// Constructors
		public RuntimeAnimatorStateOverride() {} // 0x0000000182F49AE0-0x0000000182F49B30
	
		// Methods
		[FreeFunction("RuntimeAnimatorStateOverride::Internal_Create")]
		private static void Internal_Create([Writable] RuntimeAnimatorStateOverride self) {} // 0x0000000182F49B30-0x0000000182F49B70
		public void SetClip(int stateID, AnimationClip overrideClip) {} // 0x0000000184276BA0-0x0000000184276BA8
		public void SetClipAsync(int stateID, float length, bool isHumanoid) {} // 0x0000000184276BA8-0x0000000184276BB8
		public void RemoveClip(int stateID) {} // 0x0000000189D95DF0-0x0000000189D95DF8
		public void ClearClip() {} // 0x0000000184272C60-0x0000000184272C68
		public bool PreloadClip(AnimationClip clipB) => default; // 0x000000018427616C-0x0000000184276178
		public void SetTransition(int transUserNameID, float transitionDuration, float transitionOffset, float exitTime) {} // 0x0000000184276BDC-0x0000000184276BEC
		public void RemoveTransition(int transUserNameID) {} // 0x0000000189D95DF8-0x0000000189D95E00
		public void SetSyncGroupCurve(uint clipNameID, AnimationCurve curve) {} // 0x00000001842747A0-0x00000001842747A8
		[NativeMethod("SetClip")]
		internal void Internal_SetClip(uint stateID, AnimationClip overrideClip) {} // 0x00000001838E48A0-0x00000001838E4900
		[NativeMethod("SetClipAsync")]
		internal void Internal_SetClipAsync(uint stateID, float length, bool isHumanoid) {} // 0x0000000183CFFD20-0x0000000183CFFD90
		[NativeMethod("RemoveClip")]
		internal void Internal_RemoveClip(uint stateID) {} // 0x0000000189D95D70-0x0000000189D95DB0
		[NativeMethod("ClearClip")]
		internal void Internal_ClearClip() {} // 0x0000000183D27550-0x0000000183D27590
		[NativeMethod("PreloadClip")]
		internal bool Internal_PreloadClip(AnimationClip clipB) => default; // 0x0000000183871DB0-0x0000000183871E00
		[NativeMethod("SetTransition")]
		internal void Internal_SetTransition(uint transUserNameID, float transitionDuration, float transitionOffset, float exitTime) {} // 0x0000000183A09540-0x0000000183A095B0
		[NativeMethod("RemoveTransition")]
		internal void Internal_RemoveTransition(uint transUserNameID) {} // 0x0000000189D95DB0-0x0000000189D95DF0
		[NativeMethod("SetSyncGroupCurve")]
		internal void Internal_SetSyncGroupCurve(uint clipNameID, AnimationCurve curve) {} // 0x00000001833D9170-0x00000001833D91D0
	}
}

namespace UnityEngine.Animations
{
	public static class AnimationPlayableBinding // TypeDefIndex: 57139
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key) => default; // 0x0000000189D8C044-0x0000000189D8C160
		private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name) => default; // 0x0000000189D8C004-0x0000000189D8C044
	}

	[AttributeUsage(AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 57140
	{
		// Constructors
		public DiscreteEvaluationAttribute() {} // Dummy constructor
	}

	[JobProducerType(typeof(ProcessAnimationJobStruct<T>))]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationJob // TypeDefIndex: 57141
	{
		// Methods
		void ProcessAnimation(AnimationStream stream);
		void ProcessRootMotion(AnimationStream stream);
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationWindowPreview // TypeDefIndex: 57142
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	[RequiredByNativeCode]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 57143
	{
		// Constructors
		public NotKeyableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum JobMethodIndex // TypeDefIndex: 57144
	{
		ProcessRootMotionMethodIndex = 0,
		ProcessAnimationMethodIndex = 1,
		MethodIndexCount = 2
	}

	internal struct ProcessAnimationJobStruct<T> // TypeDefIndex: 57146
		where T : struct, IAnimationJob
	{
		// Fields
		private static IntPtr jobReflectionData;
	
		// Nested types
		public delegate void ExecuteJobFunction(ref ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57145; 0x00000000-0x00000000
	
		// Methods
		public static IntPtr GetJobReflectionData() => default;
		public static void Execute(ref ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex) {}
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AdvancedAnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AdvancedAnimationMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AdvancedAnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AdvancedAnimationMixerPlayable : IPlayable, IEquatable<AdvancedAnimationMixerPlayable> // TypeDefIndex: 57147
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AdvancedAnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AdvancedAnimationMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000183326A70-0x0000000183326B10
		static AdvancedAnimationMixerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000183326700-0x0000000183326790
	
		// Methods
		public static AdvancedAnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C3D */) => default; // 0x0000000183326790-0x0000000183326840
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C3E */) => default; // 0x0000000183326840-0x00000001833269C0
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public bool Equals(AdvancedAnimationMixerPlayable other) => default; // 0x0000000189D89F48-0x0000000189D89FD4
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x00000001833269C0-0x0000000183326A20
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000183326A20-0x0000000183326A70
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 57148
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AnimationClipPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000182809720-0x00000001828097C0
	
		// Methods
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) => default; // 0x0000000182809460-0x0000000182809590
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) => default; // 0x0000000182809590-0x00000001828096B0
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationClipPlayable playable) => default; // 0x0000000183D85A00-0x0000000183D85A10
		public static explicit operator AnimationClipPlayable(Playable playable) => default; // 0x0000000189D8A204-0x0000000189D8A27C
		public bool Equals(AnimationClipPlayable other) => default; // 0x0000000189D89FD4-0x0000000189D8A048
		public AnimationClip GetAnimationClip() => default; // 0x000000018426FA88-0x000000018426FA94
		public float GetAnimationClipPlayableLengthUncheck() => default; // 0x0000000189D8A07C-0x0000000189D8A088
		public void SetAnimationClip(AnimationClip clip) {} // 0x000000018427467C-0x0000000184274684
		public void SetAnimationClipAsync(float length, bool isHumanoid) {} // 0x00000001842751B0-0x00000001842751B8
		public void SetApplyFootIK(bool value) {} // 0x0000000189D8A0CC-0x0000000189D8A0D4
		public void SetApplyPlayableIK(bool value) {} // 0x0000000189D8A118-0x0000000189D8A120
		internal void SetRemoveStartOffset(bool value) {} // 0x0000000189D8A1FC-0x0000000189D8A204
		internal void SetOverrideLoopTime(bool value) {} // 0x0000000189D8A1B0-0x0000000189D8A1B8
		internal void SetLoopTime(bool value) {} // 0x0000000189D8A164-0x0000000189D8A16C
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) => default; // 0x0000000184271BAC-0x0000000184271BC0
		[NativeThrows]
		private static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle) => default; // 0x0000000183027760-0x00000001830277F0
		[NativeThrows]
		private static void SetAnimationClipInternal(ref PlayableHandle handle, AnimationClip clip) {} // 0x00000001836BF110-0x00000001836BF160
		[NativeThrows]
		private static void SetAnimationClipAsyncInternal(ref PlayableHandle handle, float length, bool isHumanoid) {} // 0x0000000183C7B990-0x0000000183C7BBF0
		[NativeThrows]
		private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8A088-0x0000000189D8A0CC
		[NativeThrows]
		private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8A0D4-0x0000000189D8A118
		[NativeThrows]
		private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8A1B8-0x0000000189D8A1FC
		[NativeThrows]
		private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8A16C-0x0000000189D8A1B0
		[NativeThrows]
		private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8A120-0x0000000189D8A164
		[NativeThrows]
		[ThreadSafe]
		private static float GetAnimationClipPlayableLengthInternalUncheck(ref PlayableHandle handle) => default; // 0x0000000189D8A048-0x0000000189D8A07C
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) => default; // 0x000000018332D860-0x000000018332D8C0
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimationHumanStream // TypeDefIndex: 57149
	{
		// Fields
		private IntPtr stream; // 0x00
	}

	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 57150
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x00
	
		// Properties
		public static AnimationLayerMixerPlayable Null { get => default; } // 0x0000000189D8B37C-0x0000000189D8B3D4 
	
		// Constructors
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true /* Metadata: 0x01FD9C41 */) : this() {
			m_Handle = default;
		} // 0x0000000182967E20-0x0000000182967F20
		static AnimationLayerMixerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000182967F70-0x0000000182968000
	
		// Methods
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C3F */) => default; // 0x0000000182967A80-0x0000000182967B20
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) => default; // 0x0000000182967B20-0x0000000182967BF0
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C40 */) => default; // 0x0000000182967BF0-0x0000000182967D70
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationLayerMixerPlayable playable) => default; // 0x0000000189D8B450-0x0000000189D8B4A4
		public static explicit operator AnimationLayerMixerPlayable(Playable playable) => default; // 0x0000000189D8B3D4-0x0000000189D8B450
		public bool Equals(AnimationLayerMixerPlayable other) => default; // 0x0000000189D8ABA4-0x0000000189D8AC30
		public void SetLayerAdditive(uint layerIndex, bool value) {} // 0x0000000189D8AC84-0x0000000189D8ADE4
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) {} // 0x0000000189D8AFE8-0x0000000189D8B1C8
		public void SetLayerRootMotionDisable(uint layerIndex, bool value) {} // 0x0000000189D8B21C-0x0000000189D8B37C
		public void SetLayerEnableFloatCurve(uint layerIndex, bool value) {} // 0x0000000189D8AE38-0x0000000189D8AF98
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000182967D70-0x0000000182967DD0
		[NativeThrows]
		private static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x0000000189D8AC30-0x0000000189D8AC84
		[NativeThrows]
		private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) {} // 0x0000000182967F20-0x0000000182967F70
		[NativeThrows]
		private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) {} // 0x0000000189D8AF98-0x0000000189D8AFE8
		[NativeThrows]
		private static void SetLayerRootMotionDisableInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x0000000189D8B1C8-0x0000000189D8B21C
		[NativeThrows]
		private static void SetLayerEnableFloatCurveInternal(ref PlayableHandle handle, uint layerIndex, bool value) {} // 0x0000000189D8ADE4-0x0000000189D8AE38
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000182967DD0-0x0000000182967E20
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 57151
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMixerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x00000001828086F0-0x0000000182808790
		static AnimationMixerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000183CE5560-0x0000000183CE55F0
	
		// Methods
		[Obsolete("normalizeWeights is obsolete. It has no effect and will be removed.")]
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights) => default; // 0x0000000189D8B4A4-0x0000000189D8B524
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C42 */) => default; // 0x0000000182808450-0x0000000182808500
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FD9C43 */) => default; // 0x0000000182808500-0x00000001828086F0
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationMixerPlayable playable) => default; // 0x0000000189D8B5B0-0x0000000189D8B604
		public bool Equals(AnimationMixerPlayable other) => default; // 0x0000000189D8B524-0x0000000189D8B5B0
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x00000001828099E0-0x0000000182809A40
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000182809A40-0x0000000182809A90
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 57152
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x00
	
		// Constructors
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8B9C4-0x0000000189D8BA9C
		static AnimationMotionXToDeltaPlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8B940-0x0000000189D8B9C4
	
		// Methods
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) => default; // 0x0000000189D8B780-0x0000000189D8B814
		private static PlayableHandle CreateHandle(PlayableGraph graph) => default; // 0x0000000189D8B6A4-0x0000000189D8B780
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable) => default; // 0x0000000189D8BA9C-0x0000000189D8BAF0
		public bool Equals(AnimationMotionXToDeltaPlayable other) => default; // 0x0000000189D8B814-0x0000000189D8B8A0
		public void SetAbsoluteMotion(bool value) {} // 0x0000000189D8B8E4-0x0000000189D8B940
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000189D8B648-0x0000000189D8B6A4
		[NativeThrows]
		private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) {} // 0x0000000189D8B8A0-0x0000000189D8B8E4
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000189D8B604-0x0000000189D8B648
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 57153
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationOffsetPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8BED8-0x0000000189D8BFB0
		static AnimationOffsetPlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8BE54-0x0000000189D8BED8
	
		// Methods
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) => default; // 0x0000000189D8BCE4-0x0000000189D8BDC0
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) => default; // 0x0000000189D8BBC8-0x0000000189D8BCE4
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationOffsetPlayable playable) => default; // 0x0000000189D8BFB0-0x0000000189D8C004
		public bool Equals(AnimationOffsetPlayable other) => default; // 0x0000000189D8BDC0-0x0000000189D8BE54
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) => default; // 0x0000000189D8BB54-0x0000000189D8BBC8
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) => default; // 0x0000000189D8BAF0-0x0000000189D8BB54
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
	[NativeHeader("Modules/Animation/AnimationClip.h")]
	public static class AnimationPlayableExtensions // TypeDefIndex: 57154
	{
		// Methods
		[NativeThrows]
		internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) {} // 0x0000000189D8C160-0x0000000189D8C1A4
	
		// Extension methods
		public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip)
			where U : struct, IPlayable {}
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AnimationPlayableGraphExtensions // TypeDefIndex: 57155
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x0000000182966E40-0x0000000182966EA0
	}

	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 57156
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AnimationPlayableOutput Null { get => default; } // 0x0000000189D8C31C-0x0000000189D8C394 
	
		// Constructors
		internal AnimationPlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x0000000182966EA0-0x0000000182966F40
	
		// Methods
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) => default; // 0x0000000182966D80-0x0000000182966E40
		public PlayableOutputHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator PlayableOutput(AnimationPlayableOutput output) => default; // 0x0000000183D85A00-0x0000000183D85A10
		public static explicit operator AnimationPlayableOutput(PlayableOutput output) => default; // 0x0000000189D8C394-0x0000000189D8C40C
		public Animator GetTarget() => default; // 0x0000000189D8C290-0x0000000189D8C29C
		public void SetTarget(Animator value) {} // 0x0000000184272110-0x0000000184272118
		public void SetNeedRebindOnChanged(bool value) {} // 0x0000000189D8C314-0x0000000189D8C31C
		[NativeThrows]
		private static Animator InternalGetTarget(ref PlayableOutputHandle handle) => default; // 0x0000000189D8C29C-0x0000000189D8C2D0
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) {} // 0x0000000183540510-0x0000000183540560
		[NativeThrows]
		private static void InternalSetNeedRebindOnChanged(ref PlayableOutputHandle handle, bool value) {} // 0x0000000189D8C2D0-0x0000000189D8C314
	}

	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable> // TypeDefIndex: 57157
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationPosePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationPosePlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8C524-0x0000000189D8C5FC
		static AnimationPosePlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8C4A0-0x0000000189D8C524
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public bool Equals(AnimationPosePlayable other) => default; // 0x0000000189D8C40C-0x0000000189D8C4A0
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 57158
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationRemoveScalePlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8C940-0x0000000189D8CA18
		static AnimationRemoveScalePlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8C8BC-0x0000000189D8C940
	
		// Methods
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) => default; // 0x0000000189D8C784-0x0000000189D8C828
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) => default; // 0x0000000189D8C69C-0x0000000189D8C784
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AnimationRemoveScalePlayable playable) => default; // 0x0000000189D8CA18-0x0000000189D8CA6C
		public bool Equals(AnimationRemoveScalePlayable other) => default; // 0x0000000189D8C828-0x0000000189D8C8BC
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000189D8C640-0x0000000189D8C69C
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) => default; // 0x0000000189D8C5FC-0x0000000189D8C640
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 57159
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimationScriptPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimationScriptPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8CF34-0x0000000189D8D00C
		static AnimationScriptPlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8CEB0-0x0000000189D8CF34
	
		// Methods
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0 /* Metadata: 0x01FD9C44 */)
			where T : struct, IAnimationJob => default;
		private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount)
			where T : struct, IAnimationJob => default;
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		private void CheckJobTypeValidity<T>() {}
		public void SetJobData<T>(T jobData)
			where T : struct, IAnimationJob {}
		public static implicit operator Playable(AnimationScriptPlayable playable) => default; // 0x0000000189D8D00C-0x0000000189D8D060
		public bool Equals(AnimationScriptPlayable other) => default; // 0x0000000189D8CC2C-0x0000000189D8CCB8
		public void SetForceWriteRootMotionParam(bool value) {} // 0x0000000189D8CE54-0x0000000189D8CEB0
		public void SetForceResetParam(bool value) {} // 0x0000000189D8CD58-0x0000000189D8CDB4
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) => default; // 0x0000000189D8CBC8-0x0000000189D8CC2C
		[NativeThrows]
		private static void SetForceWriteRootMotionParamInternal(PlayableHandle handle, bool value) {} // 0x0000000189D8CDF8-0x0000000189D8CE54
		[NativeThrows]
		private static void SetForceResetParamInternal(PlayableHandle handle, bool value) {} // 0x0000000189D8CCFC-0x0000000189D8CD58
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) => default; // 0x0000000189D8CB74-0x0000000189D8CBC8
		private static void SetForceWriteRootMotionParamInternal_Injected(ref PlayableHandle handle, bool value) {} // 0x0000000189D8CDB4-0x0000000189D8CDF8
		private static void SetForceResetParamInternal_Injected(ref PlayableHandle handle, bool value) {} // 0x0000000189D8CCB8-0x0000000189D8CCFC
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[RequiredByNativeCode]
	public struct AnimationStream // TypeDefIndex: 57160
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
		internal uint animatorBindingsVersion { get => default; } // 0x0000000183D85860-0x0000000183D85870 
		public bool isValid { get => default; } // 0x0000000189D8D7F0-0x0000000189D8D818 
		public float deltaTime { get => default; } // 0x0000000189D8D7D0-0x0000000189D8D7F0 
	
		// Methods
		internal void CheckIsValid() {} // 0x0000000189D8D728-0x0000000189D8D794
		[NativeMethod(IsThreadSafe = true)]
		private float GetDeltaTime() => default; // 0x0000000189D8D7C8-0x0000000189D8D7D0
		private static float GetDeltaTime_Injected(ref AnimationStream _unity_self) => default; // 0x0000000189D8D794-0x0000000189D8D7C8
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public struct TransformStreamHandle // TypeDefIndex: 57161
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int skeletonIndex; // 0x08
	
		// Properties
		private bool createdByNative { get => default; } // 0x0000000189D95D04-0x0000000189D95D10 
		private bool hasHandleIndex { get => default; } // 0x0000000189D95D18-0x0000000189D95D24 
		private bool hasSkeletonIndex { get => default; } // 0x0000000189D95D24-0x0000000189D95D30 
		internal uint animatorBindingsVersion { get => default; } // 0x0000000183D85860-0x0000000183D85870 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x0000000189D96D74-0x0000000189D96D88
		private bool IsValidInternal(ref AnimationStream stream) => default; // 0x0000000189D96D44-0x0000000189D96D74
		private bool IsSameVersionAsStream(ref AnimationStream stream) => default; // 0x0000000189D95968-0x0000000189D95974
		public void Resolve(AnimationStream stream) {} // 0x0000000189D96DD4-0x0000000189D96DE8
		public bool IsResolved(AnimationStream stream) => default; // 0x0000000189D96D30-0x0000000189D96D44
		private bool IsResolvedInternal(ref AnimationStream stream) => default; // 0x0000000189D96CF4-0x0000000189D96D30
		private void CheckIsValidAndResolve(ref AnimationStream stream) {} // 0x0000000189D965A4-0x0000000189D966CC
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x0000000189D96BB0-0x0000000189D96C14
		public void SetPosition(AnimationStream stream, Vector3 position) {} // 0x0000000189D972B4-0x0000000189D97308
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x0000000189D96C98-0x0000000189D96CF4
		public void SetRotation(AnimationStream stream, Quaternion rotation) {} // 0x0000000189D97370-0x0000000189D973BC
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x0000000189D96820-0x0000000189D96884
		public void SetLocalPosition(AnimationStream stream, Vector3 position) {} // 0x0000000189D96F54-0x0000000189D96FA8
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x0000000189D96908-0x0000000189D96964
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation) {} // 0x0000000189D97010-0x0000000189D9705C
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x0000000189D969EC-0x0000000189D96A50
		public void SetLocalScale(AnimationStream stream, Vector3 scale) {} // 0x0000000189D970C4-0x0000000189D97118
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D96AC4-0x0000000189D96B28
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) {} // 0x0000000189D971A8-0x0000000189D9724C
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D96740-0x0000000189D96798
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) {} // 0x0000000189D96E6C-0x0000000189D96EEC
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream) {} // 0x0000000189D96DCC-0x0000000189D96DD4
		[NativeMethod(Name = "TransformStreamHandleBindings::GetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream) => default; // 0x0000000189D96B7C-0x0000000189D96BB0
		[NativeMethod(Name = "TransformStreamHandleBindings::SetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetPositionInternal(ref AnimationStream stream, Vector3 position) {} // 0x0000000189D972A0-0x0000000189D972B4
		[NativeMethod(Name = "TransformStreamHandleBindings::GetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream) => default; // 0x0000000189D96C68-0x0000000189D96C98
		[NativeMethod(Name = "TransformStreamHandleBindings::SetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation) {} // 0x0000000189D9735C-0x0000000189D97370
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream) => default; // 0x0000000189D967EC-0x0000000189D96820
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position) {} // 0x0000000189D96F40-0x0000000189D96F54
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream) => default; // 0x0000000189D968D8-0x0000000189D96908
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation) {} // 0x0000000189D96FFC-0x0000000189D97010
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream) => default; // 0x0000000189D969B8-0x0000000189D969EC
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale) {} // 0x0000000189D970B0-0x0000000189D970C4
		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D96AB4-0x0000000189D96AC4
		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) {} // 0x0000000189D9717C-0x0000000189D971A8
		[NativeMethod(Name = "TransformStreamHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D96730-0x0000000189D96740
		[NativeMethod(Name = "TransformStreamHandleBindings::SetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) {} // 0x0000000189D96E4C-0x0000000189D96E6C
		private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream) {} // 0x0000000189D96D88-0x0000000189D96DCC
		private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D96B28-0x0000000189D96B7C
		private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) {} // 0x0000000189D9724C-0x0000000189D972A0
		private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D96C14-0x0000000189D96C68
		private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) {} // 0x0000000189D97308-0x0000000189D9735C
		private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D96798-0x0000000189D967EC
		private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) {} // 0x0000000189D96EEC-0x0000000189D96F40
		private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D96884-0x0000000189D968D8
		private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) {} // 0x0000000189D96FA8-0x0000000189D96FFC
		private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D96964-0x0000000189D969B8
		private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 scale) {} // 0x0000000189D9705C-0x0000000189D970B0
		private static void GetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D96A50-0x0000000189D96AB4
		private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, bool useMask) {} // 0x0000000189D97118-0x0000000189D9717C
		private static void GetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D966CC-0x0000000189D96730
		private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, bool useMask) {} // 0x0000000189D96DE8-0x0000000189D96E4C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	public struct PropertyStreamHandle // TypeDefIndex: 57162
	{
		// Fields
		private uint m_AnimatorBindingsVersion; // 0x00
		private int handleIndex; // 0x04
		private int valueArrayIndex; // 0x08
		private int bindType; // 0x0C
	
		// Properties
		private bool createdByNative { get => default; } // 0x0000000189D95D04-0x0000000189D95D10 
		private bool hasHandleIndex { get => default; } // 0x0000000189D95D18-0x0000000189D95D24 
		private bool hasValueArrayIndex { get => default; } // 0x0000000189D95D24-0x0000000189D95D30 
		private bool hasBindType { get => default; } // 0x0000000189D95D10-0x0000000189D95D18 
		internal uint animatorBindingsVersion { get => default; } // 0x0000000183D85860-0x0000000183D85870 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x0000000189D959A8-0x0000000189D959BC
		private bool IsValidInternal(ref AnimationStream stream) => default; // 0x0000000189D95974-0x0000000189D959A8
		private bool IsSameVersionAsStream(ref AnimationStream stream) => default; // 0x0000000189D95968-0x0000000189D95974
		private bool IsResolvedInternal(ref AnimationStream stream) => default; // 0x0000000189D9592C-0x0000000189D95968
		private void CheckIsValidAndResolve(ref AnimationStream stream) {} // 0x0000000189D95560-0x0000000189D95690
		public float GetFloat(AnimationStream stream) => default; // 0x0000000189D957BC-0x0000000189D95848
		public void SetFloat(AnimationStream stream, float value) {} // 0x0000000189D95B64-0x0000000189D95C00
		public int GetInt(AnimationStream stream) => default; // 0x0000000189D95894-0x0000000189D9592C
		public void SetInt(AnimationStream stream, int value) {} // 0x0000000189D95C5C-0x0000000189D95D04
		public bool GetBool(AnimationStream stream) => default; // 0x0000000189D956DC-0x0000000189D95770
		public void SetBool(AnimationStream stream, bool value) {} // 0x0000000189D95A64-0x0000000189D95B08
		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream) {} // 0x0000000189D95A00-0x0000000189D95A08
		[NativeMethod(Name = "GetFloat", IsThreadSafe = true)]
		private float GetFloatInternal(ref AnimationStream stream) => default; // 0x0000000189D957B4-0x0000000189D957BC
		[NativeMethod(Name = "SetFloat", IsThreadSafe = true)]
		private void SetFloatInternal(ref AnimationStream stream, float value) {} // 0x0000000189D95B5C-0x0000000189D95B64
		[NativeMethod(Name = "GetInt", IsThreadSafe = true)]
		private int GetIntInternal(ref AnimationStream stream) => default; // 0x0000000189D9588C-0x0000000189D95894
		[NativeMethod(Name = "SetInt", IsThreadSafe = true)]
		private void SetIntInternal(ref AnimationStream stream, int value) {} // 0x0000000189D95C54-0x0000000189D95C5C
		[NativeMethod(Name = "GetBool", IsThreadSafe = true)]
		private bool GetBoolInternal(ref AnimationStream stream) => default; // 0x0000000189D956D4-0x0000000189D956DC
		[NativeMethod(Name = "SetBool", IsThreadSafe = true)]
		private void SetBoolInternal(ref AnimationStream stream, bool value) {} // 0x0000000189D95A5C-0x0000000189D95A64
		private static void ResolveInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) {} // 0x0000000189D959BC-0x0000000189D95A00
		private static float GetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x0000000189D95770-0x0000000189D957B4
		private static void SetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, float value) {} // 0x0000000189D95B08-0x0000000189D95B5C
		private static int GetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x0000000189D95848-0x0000000189D9588C
		private static void SetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, int value) {} // 0x0000000189D95C00-0x0000000189D95C54
		private static bool GetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) => default; // 0x0000000189D95690-0x0000000189D956D4
		private static void SetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, bool value) {} // 0x0000000189D95A08-0x0000000189D95A5C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public struct TransformSceneHandle // TypeDefIndex: 57163
	{
		// Fields
		private uint valid; // 0x00
		private int transformSceneHandleDefinitionIndex; // 0x04
	
		// Properties
		private bool createdByNative { get => default; } // 0x000000018426F724-0x000000018426F72C 
		private bool hasTransformSceneHandleDefinitionIndex { get => default; } // 0x0000000189D95D18-0x0000000189D95D24 
	
		// Methods
		public bool IsValid(AnimationStream stream) => default; // 0x0000000189D9655C-0x0000000189D965A4
		private void CheckIsValid(ref AnimationStream stream) {} // 0x0000000189D95E00-0x0000000189D95EE8
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x0000000189D963CC-0x0000000189D96430
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x0000000189D9603C-0x0000000189D960A0
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x0000000189D964B4-0x0000000189D96510
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x0000000189D96124-0x0000000189D96180
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x0000000189D96208-0x0000000189D9626C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D962E0-0x0000000189D96344
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D95F5C-0x0000000189D95FB4
		[ThreadSafe]
		private bool HasValidTransform(ref AnimationStream stream) => default; // 0x0000000189D96554-0x0000000189D9655C
		[NativeMethod(Name = "TransformSceneHandleBindings::GetPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream) => default; // 0x0000000189D96398-0x0000000189D963CC
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream) => default; // 0x0000000189D96008-0x0000000189D9603C
		[NativeMethod(Name = "TransformSceneHandleBindings::GetRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream) => default; // 0x0000000189D96484-0x0000000189D964B4
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream) => default; // 0x0000000189D960F4-0x0000000189D96124
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream) => default; // 0x0000000189D961D4-0x0000000189D96208
		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D962D0-0x0000000189D962E0
		[NativeMethod(Name = "TransformSceneHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D95F4C-0x0000000189D95F5C
		private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream) => default; // 0x0000000189D96510-0x0000000189D96554
		private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D96344-0x0000000189D96398
		private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D95FB4-0x0000000189D96008
		private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D96430-0x0000000189D96484
		private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) {
			ret = default;
		} // 0x0000000189D960A0-0x0000000189D960F4
		private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) {
			ret = default;
		} // 0x0000000189D96180-0x0000000189D961D4
		private static void GetLocalTRSInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189D9626C-0x0000000189D962D0
		private static void GetGlobalTRInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189D95EE8-0x0000000189D95F4C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	public struct PropertySceneHandle // TypeDefIndex: 57164
	{
		// Fields
		private uint valid; // 0x00
		private int handleIndex; // 0x04
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationSceneHandleUtility // TypeDefIndex: 57165
	{
		// Methods
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer) {} // 0x0000000189D8CA6C-0x0000000189D8CB10
		internal static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer)
			where T0 : struct
			where T1 : struct => default;
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadSceneFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count) {} // 0x0000000189D8CB10-0x0000000189D8CB74
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationStreamHandleUtility // TypeDefIndex: 57166
	{
		// Methods
		public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer, bool useMask) {} // 0x0000000189D8D60C-0x0000000189D8D6C4
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer) {} // 0x0000000189D8D500-0x0000000189D8D5A8
		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count) {} // 0x0000000189D8D5A8-0x0000000189D8D60C
		[NativeMethod(Name = "AnimationHandleUtilityBindings::WriteStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private static unsafe void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask) {} // 0x0000000189D8D6C4-0x0000000189D8D728
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 57167
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x00
	
		// Constructors
		internal AnimatorControllerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D8E758-0x0000000189D8E7E0
		static AnimatorControllerPlayable() {
			m_NullPlayable = default;
		} // 0x0000000189D8E6D4-0x0000000189D8E758
	
		// Methods
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller) => default; // 0x0000000189D8E3C8-0x0000000189D8E46C
		private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller) => default; // 0x0000000189D8E2F0-0x0000000189D8E3C8
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public void SetHandle(PlayableHandle handle) {} // 0x0000000189D8E590-0x0000000189D8E6D4
		public bool Equals(AnimatorControllerPlayable other) => default; // 0x0000000189D8E46C-0x0000000189D8E4F8
		public bool IsInTransition(int layerIndex) => default; // 0x0000000189D8E538-0x0000000189D8E590
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) => default; // 0x0000000189D8E28C-0x0000000189D8E2F0
		[NativeThrows]
		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex) => default; // 0x0000000189D8E4F8-0x0000000189D8E538
		private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) => default; // 0x0000000189D8E238-0x0000000189D8E28C
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	public enum CustomStreamPropertyType // TypeDefIndex: 57168
	{
		Float = 5,
		Bool = 6,
		Int = 10
	}

	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimatorJobExtensions // TypeDefIndex: 57169
	{
		// Methods
		private static void InternalBindStreamTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformStreamHandle transformStreamHandle) {
			transformStreamHandle = default;
		} // 0x0000000189D8EB18-0x0000000189D8EB6C
		private static void InternalBindStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle) {
			propertyStreamHandle = default;
		} // 0x0000000189D8EAB4-0x0000000189D8EB18
		private static void InternalBindCustomStreamProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle) {
			propertyStreamHandle = default;
		} // 0x0000000189D8E998-0x0000000189D8E9FC
		private static void InternalBindSceneTransform([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, out TransformSceneHandle transformSceneHandle) {
			transformSceneHandle = default;
		} // 0x0000000189D8EA60-0x0000000189D8EAB4
		private static void InternalBindSceneProperty([NotNull("ArgumentNullException")] Animator animator, [NotNull("ArgumentNullException")] Transform transform, [NotNull("ArgumentNullException")] System.Type type, [NotNull("ArgumentNullException")] string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle) {
			propertySceneHandle = default;
		} // 0x0000000189D8E9FC-0x0000000189D8EA60
	
		// Extension methods
		public static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform) => default; // 0x0000000189D8E948-0x0000000189D8E998
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property) => default; // 0x0000000189D8E904-0x0000000189D8E948
		public static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type) => default; // 0x0000000189D8E7E0-0x0000000189D8E828
		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference) => default; // 0x0000000189D8E89C-0x0000000189D8E904
		public static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform) => default; // 0x0000000189D8E878-0x0000000189D8E89C
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property) => default; // 0x0000000189D8E85C-0x0000000189D8E878
		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, System.Type type, string property, [UnityEngine.Internal.DefaultValue("false")] bool isObjectReference) => default; // 0x0000000189D8E828-0x0000000189D8E85C
	}

	[Flags]
	[NativeType("Modules/Animation/Constraints/ConstraintEnums.h")]
	public enum Axis // TypeDefIndex: 57170
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4
	}
}

namespace UnityEngine.Experimental.Animations
{
	public enum AnimationStreamSource // TypeDefIndex: 57137
	{
		DefaultValues = 0,
		PreviousInputs = 1
	}

	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorDefines.h")]
	[StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType.DoubleColon)]
	public static class AnimationPlayableOutputExtensions // TypeDefIndex: 57138
	{
		// Methods
		[NativeThrows]
		private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource) {} // 0x0000000189D8C1E4-0x0000000189D8C1F8
		[NativeThrows]
		private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder) {} // 0x0000000189D8C238-0x0000000189D8C24C
		private static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource) {} // 0x0000000189D8C1A4-0x0000000189D8C1E4
		private static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder) {} // 0x0000000189D8C1F8-0x0000000189D8C238
	
		// Extension methods
		public static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource) {} // 0x0000000189D8C24C-0x0000000189D8C26C
		public static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder) {} // 0x0000000189D8C26C-0x0000000189D8C290
	}
}
