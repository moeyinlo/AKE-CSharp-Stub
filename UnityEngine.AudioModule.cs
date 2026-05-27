/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Image 104: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59625-59643
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
[assembly: InternalsVisibleTo("UnityEngine.Analytics")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("Unity.Automation")]
[assembly: InternalsVisibleTo("UnityEngine.TestRunner")]
[assembly: InternalsVisibleTo("UnityEngine.Purchasing")]
[assembly: InternalsVisibleTo("UnityEngine.Advertisements")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommon")]
[assembly: InternalsVisibleTo("Unity.DeploymentTests.Services")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.Audio.DSPGraph.Tests")]
[assembly: InternalsVisibleTo("Unity.Audio.DSPGraph")]
[assembly: InternalsVisibleTo("Unity.Audio.Tests")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.Analytics")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Framework")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Timeline")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.UnityAnalytics")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("VivoxUnity")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings // TypeDefIndex: 59627
	{
		// Nested types
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged); // TypeDefIndex: 59626; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public AudioSettings() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) {} // 0x0000000189D99078-0x0000000189D990C8
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown() {} // 0x0000000189D990C8-0x0000000189D9910C
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp() {} // 0x0000000189D9910C-0x0000000189D99150
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : UnityEngine.Object // TypeDefIndex: 59630
	{
		// Properties
		[NativeProperty("LengthSec")]
		public float length { get => default; } // 0x0000000189D98488-0x0000000189D984BC 
		[NativeProperty("SampleCount")]
		public int samples { get => default; } // 0x0000000189D984BC-0x0000000189D984F0 
		public int frequency { get => default; } // 0x0000000189D98454-0x0000000189D98488 
	
		// Nested types
		public delegate void PCMReaderCallback(float[] data); // TypeDefIndex: 59628; 0x0000000182149960-0x0000000182149970
	
		public delegate void PCMSetPositionCallback(int position); // TypeDefIndex: 59629; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public AudioClip() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data) {} // 0x0000000189D98424-0x0000000189D9843C
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position) {} // 0x0000000189D9843C-0x0000000189D98454
	}

	public class AudioBehaviour : UnityEngine.Behaviour // TypeDefIndex: 59631
	{
		// Constructors
		public AudioBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 59632
	{
		// Constructors
		public AudioListener() {} // Dummy constructor
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 59633
	{
		// Properties
		public float volume { set {} } // 0x0000000189D9974C-0x0000000189D99790
		public float pitch { set {} } // 0x0000000189D99678-0x0000000189D99680
		[NativeProperty("SecPosition")]
		public float time { get => default; set {} } // 0x0000000189D99534-0x0000000189D99568 0x0000000189D99708-0x0000000189D9974C
		[NativeProperty("AudioClip")]
		public AudioClip clip { set {} } // 0x0000000189D995AC-0x0000000189D995F0
		public AudioMixerGroup outputAudioMixerGroup { set {} } // 0x0000000189D995F0-0x0000000189D99634
		public bool isPlaying { [NativeName("IsPlayingScripting")] get => default; } // 0x0000000189D99500-0x0000000189D99534 
		public bool playOnAwake { set {} } // 0x0000000189D99680-0x0000000189D996C4
		[NativeProperty("StereoPan")]
		public float panStereo { set {} } // 0x0000000189D99634-0x0000000189D99678
		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend { set {} } // 0x0000000189D996C4-0x0000000189D99708
		public bool bypassReverbZones { set {} } // 0x0000000189D99568-0x0000000189D995AC
	
		// Constructors
		public AudioSource() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch) {} // 0x0000000189D9946C-0x0000000189D994B0
		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay) {} // 0x0000000189D99320-0x0000000189D99364
		private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale) {} // 0x0000000189D99364-0x0000000189D993B8
		private void Stop(bool stopOneShots) {} // 0x0000000189D994BC-0x0000000189D99500
		[ExcludeFromDocs]
		public void Play() {} // 0x0000000189D99460-0x0000000189D9946C
		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale) {} // 0x0000000189D993B8-0x0000000189D99460
		public void Stop() {} // 0x0000000189D994B0-0x0000000189D994BC
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume) {} // 0x0000000189D99150-0x0000000189D99320
	}
}

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 59634
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioClipPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D982D4-0x0000000189D983AC
	
		// Methods
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) => default; // 0x0000000189D97C74-0x0000000189D97D88
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) => default; // 0x0000000189D97BAC-0x0000000189D97C74
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AudioClipPlayable playable) => default; // 0x0000000183D85A00-0x0000000183D85A10
		public static explicit operator AudioClipPlayable(Playable playable) => default; // 0x0000000189D983AC-0x0000000189D98424
		public bool Equals(AudioClipPlayable other) => default; // 0x0000000189D97D88-0x0000000189D97DFC
		internal void SetVolume(float value) {} // 0x0000000189D9822C-0x0000000189D982D4
		internal void SetStereoPan(float value) {} // 0x0000000189D9813C-0x0000000189D981E8
		internal void SetSpatialBlend(float value) {} // 0x0000000189D9800C-0x0000000189D980B4
		public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration) {} // 0x0000000189D97E60-0x0000000189D97F84
		[NativeThrows]
		private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) {} // 0x0000000189D981E8-0x0000000189D9822C
		[NativeThrows]
		private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) {} // 0x0000000189D980F8-0x0000000189D9813C
		[NativeThrows]
		private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) {} // 0x0000000189D97FC8-0x0000000189D9800C
		[NativeThrows]
		private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) {} // 0x0000000189D980B4-0x0000000189D980F8
		[NativeThrows]
		private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) {} // 0x0000000189D97F84-0x0000000189D97FC8
		[NativeThrows]
		private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) => default; // 0x0000000189D97DFC-0x0000000189D97E60
	}

	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	public class AudioMixer : UnityEngine.Object // TypeDefIndex: 59635
	{
		// Constructors
		internal AudioMixer() {} // 0x0000000189D98B40-0x0000000189D98B80
	
		// Methods
		[NativeMethod("FindSnapshotFromName")]
		public AudioMixerSnapshot FindSnapshot(string name) => default; // 0x0000000189D98878-0x0000000189D988BC
		internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) {} // 0x0000000189D98910-0x0000000189D98B40
		[NativeMethod("TransitionToSnapshot")]
		private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) {} // 0x0000000189D988BC-0x0000000189D98910
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
	public class AudioMixerGroup : UnityEngine.Object // TypeDefIndex: 59636
	{
		// Constructors
		public AudioMixerGroup() {} // Dummy constructor
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 59637
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x0000000189D986EC-0x0000000189D987C4
	
		// Methods
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x01FDD1FC */, bool normalizeInputVolumes = false /* Metadata: 0x01FDD1FD */) => default; // 0x0000000189D98618-0x0000000189D98678
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) => default; // 0x0000000189D98544-0x0000000189D98618
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator Playable(AudioMixerPlayable playable) => default; // 0x0000000183D85A00-0x0000000183D85A10
		public bool Equals(AudioMixerPlayable other) => default; // 0x0000000189D98678-0x0000000189D986EC
		[NativeThrows]
		private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) => default; // 0x0000000189D984F0-0x0000000189D98544
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
	public class AudioMixerSnapshot : UnityEngine.Object // TypeDefIndex: 59638
	{
		// Properties
		[NativeProperty]
		public AudioMixer audioMixer { get => default; } // 0x0000000189D98844-0x0000000189D98878 
	
		// Constructors
		internal AudioMixerSnapshot() {} // 0x0000000189D98804-0x0000000189D98844
	
		// Methods
		public void TransitionTo(float timeToReach) {} // 0x0000000189D987C4-0x0000000189D98804
	}

	public static class AudioPlayableBinding // TypeDefIndex: 59639
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key) => default; // 0x0000000189D98BC0-0x0000000189D98CDC
		private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name) => default; // 0x0000000189D98B80-0x0000000189D98BC0
	}

	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AudioPlayableGraphExtensions // TypeDefIndex: 59640
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x0000000189D98CDC-0x0000000189D98D30
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 59641
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AudioPlayableOutput Null { get => default; } // 0x0000000189D98F38-0x0000000189D98FB0 
	
		// Constructors
		internal AudioPlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x0000000189D98E60-0x0000000189D98F38
	
		// Methods
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) => default; // 0x0000000189D98D30-0x0000000189D98DC8
		public PlayableOutputHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public static implicit operator PlayableOutput(AudioPlayableOutput output) => default; // 0x0000000183D85A00-0x0000000183D85A10
		public static explicit operator AudioPlayableOutput(PlayableOutput output) => default; // 0x0000000189D98FB0-0x0000000189D99028
		public void SetTarget(AudioSource value) {} // 0x0000000189D98E58-0x0000000189D98E60
		public void SetEvaluateOnSeek(bool value) {} // 0x0000000189D98E50-0x0000000189D98E58
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) {} // 0x0000000189D98E0C-0x0000000189D98E50
		[NativeThrows]
		private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) {} // 0x0000000189D98DC8-0x0000000189D98E0C
	}
}

namespace UnityEngine.Experimental.Audio
{
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	public class AudioSampleProvider // TypeDefIndex: 59643
	{
		// Nested types
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount); // TypeDefIndex: 59642; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public AudioSampleProvider() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount) {} // 0x0000000189D99028-0x0000000189D99050
		[RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) {} // 0x0000000189D99050-0x0000000189D99078
	}
}
