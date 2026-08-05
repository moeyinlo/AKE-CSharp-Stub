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

// Image 109: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63355-63373
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
	public sealed class AudioSettings // TypeDefIndex: 63357
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemShuttingDown; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemStartedUp; // 0x10
	
		// Nested types
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged); // TypeDefIndex: 63356; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged); // 0x000000018B3A3EFC-0x000000018B3A3F4C
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown(); // 0x000000018B3A3F4C-0x000000018B3A3F90
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp(); // 0x000000018B3A3F90-0x000000018B3A3FD4
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : UnityEngine.Object // TypeDefIndex: 63360
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PCMReaderCallback m_PCMReaderCallback; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20
	
		// Properties
		[NativeProperty("LengthSec")]
		public float length { get; } // 0x000000018B3A330C-0x000000018B3A3340 
		[NativeProperty("SampleCount")]
		public int samples { get; } // 0x000000018B3A3340-0x000000018B3A3374 
		public int frequency { get; } // 0x000000018B3A32D8-0x000000018B3A330C 
	
		// Nested types
		public delegate void PCMReaderCallback(float[] data); // TypeDefIndex: 63358; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void PCMSetPositionCallback(int position); // TypeDefIndex: 63359; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data); // 0x000000018B3A32A8-0x000000018B3A32C0
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position); // 0x000000018B3A32C0-0x000000018B3A32D8
	}

	public class AudioBehaviour : UnityEngine.Behaviour // TypeDefIndex: 63361
	{
		// Constructors
		public AudioBehaviour(); // 0x0000000185393520-0x0000000185393538
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 63362
	{
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 63363
	{
		// Properties
		public float volume { set; } // 0x000000018B3A45D0-0x000000018B3A4614
		public float pitch { set; } // 0x000000018B3A44FC-0x000000018B3A4504
		[NativeProperty("SecPosition")]
		public float time { get; set; } // 0x000000018B3A43B8-0x000000018B3A43EC 0x000000018B3A458C-0x000000018B3A45D0
		[NativeProperty("AudioClip")]
		public AudioClip clip { set; } // 0x000000018B3A4430-0x000000018B3A4474
		public AudioMixerGroup outputAudioMixerGroup { set; } // 0x000000018B3A4474-0x000000018B3A44B8
		public bool isPlaying { [NativeName("IsPlayingScripting")] get; } // 0x000000018B3A4384-0x000000018B3A43B8 
		public bool playOnAwake { set; } // 0x000000018B3A4504-0x000000018B3A4548
		[NativeProperty("StereoPan")]
		public float panStereo { set; } // 0x000000018B3A44B8-0x000000018B3A44FC
		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend { set; } // 0x000000018B3A4548-0x000000018B3A458C
		public bool bypassReverbZones { set; } // 0x000000018B3A43EC-0x000000018B3A4430
	
		// Constructors
		public AudioSource(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch); // 0x000000018B3A42F0-0x000000018B3A4334
		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay); // 0x000000018B3A41A4-0x000000018B3A41E8
		private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale); // 0x000000018B3A41E8-0x000000018B3A423C
		private void Stop(bool stopOneShots); // 0x000000018B3A4340-0x000000018B3A4384
		[ExcludeFromDocs]
		public void Play(); // 0x000000018B3A42E4-0x000000018B3A42F0
		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale); // 0x000000018B3A423C-0x000000018B3A42E4
		public void Stop(); // 0x000000018B3A4334-0x000000018B3A4340
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume); // 0x000000018B3A3FD4-0x000000018B3A41A4
	}
}

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 63364
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioClipPlayable(PlayableHandle handle); // 0x000000018B3A3158-0x000000018B3A3230
	
		// Methods
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping); // 0x000000018B3A2AF8-0x000000018B3A2C0C
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping); // 0x000000018B3A2A30-0x000000018B3A2AF8
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AudioClipPlayable playable); // 0x000000018315BC70-0x000000018315BC80
		public static explicit operator AudioClipPlayable(Playable playable); // 0x000000018B3A3230-0x000000018B3A32A8
		public bool Equals(AudioClipPlayable other); // 0x000000018B3A2C0C-0x000000018B3A2C80
		internal void SetVolume(float value); // 0x000000018B3A30B0-0x000000018B3A3158
		internal void SetStereoPan(float value); // 0x000000018B3A2FC0-0x000000018B3A306C
		internal void SetSpatialBlend(float value); // 0x000000018B3A2E90-0x000000018B3A2F38
		public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration); // 0x000000018B3A2CE4-0x000000018B3A2E08
		[NativeThrows]
		private static void SetVolumeInternal(ref PlayableHandle hdl, float volume); // 0x000000018B3A306C-0x000000018B3A30B0
		[NativeThrows]
		private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan); // 0x000000018B3A2F7C-0x000000018B3A2FC0
		[NativeThrows]
		private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend); // 0x000000018B3A2E4C-0x000000018B3A2E90
		[NativeThrows]
		private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay); // 0x000000018B3A2F38-0x000000018B3A2F7C
		[NativeThrows]
		private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay); // 0x000000018B3A2E08-0x000000018B3A2E4C
		[NativeThrows]
		private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle); // 0x000000018B3A2C80-0x000000018B3A2CE4
	}

	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	public class AudioMixer : UnityEngine.Object // TypeDefIndex: 63365
	{
		// Constructors
		internal AudioMixer(); // 0x000000018B3A39C4-0x000000018B3A3A04
	
		// Methods
		[NativeMethod("FindSnapshotFromName")]
		public AudioMixerSnapshot FindSnapshot(string name); // 0x000000018B3A36FC-0x000000018B3A3740
		internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach); // 0x000000018B3A3794-0x000000018B3A39C4
		[NativeMethod("TransitionToSnapshot")]
		private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach); // 0x000000018B3A3740-0x000000018B3A3794
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
	public class AudioMixerGroup : UnityEngine.Object // TypeDefIndex: 63366
	{
	}

	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 63367
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioMixerPlayable(PlayableHandle handle); // 0x000000018B3A3570-0x000000018B3A3648
	
		// Methods
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x023527B2 */, bool normalizeInputVolumes = false /* Metadata: 0x023527B3 */); // 0x000000018B3A349C-0x000000018B3A34FC
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes); // 0x000000018B3A33C8-0x000000018B3A349C
		public PlayableHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator Playable(AudioMixerPlayable playable); // 0x000000018315BC70-0x000000018315BC80
		public bool Equals(AudioMixerPlayable other); // 0x000000018B3A34FC-0x000000018B3A3570
		[NativeThrows]
		private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle); // 0x000000018B3A3374-0x000000018B3A33C8
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
	public class AudioMixerSnapshot : UnityEngine.Object // TypeDefIndex: 63368
	{
		// Properties
		[NativeProperty]
		public AudioMixer audioMixer { get; } // 0x000000018B3A36C8-0x000000018B3A36FC 
	
		// Constructors
		internal AudioMixerSnapshot(); // 0x000000018B3A3688-0x000000018B3A36C8
	
		// Methods
		public void TransitionTo(float timeToReach); // 0x000000018B3A3648-0x000000018B3A3688
	}

	public static class AudioPlayableBinding // TypeDefIndex: 63369
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key); // 0x000000018B3A3A44-0x000000018B3A3B60
		private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name); // 0x000000018B3A3A04-0x000000018B3A3A44
	}

	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AudioPlayableGraphExtensions // TypeDefIndex: 63370
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle); // 0x000000018B3A3B60-0x000000018B3A3BB4
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 63371
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AudioPlayableOutput Null { get; } // 0x000000018B3A3DBC-0x000000018B3A3E34 
	
		// Constructors
		internal AudioPlayableOutput(PlayableOutputHandle handle); // 0x000000018B3A3CE4-0x000000018B3A3DBC
	
		// Methods
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target); // 0x000000018B3A3BB4-0x000000018B3A3C4C
		public PlayableOutputHandle GetHandle(); // 0x0000000184D9E560-0x0000000184D9E570
		public static implicit operator PlayableOutput(AudioPlayableOutput output); // 0x000000018315BC70-0x000000018315BC80
		public static explicit operator AudioPlayableOutput(PlayableOutput output); // 0x000000018B3A3E34-0x000000018B3A3EAC
		public void SetTarget(AudioSource value); // 0x000000018B3A3CDC-0x000000018B3A3CE4
		public void SetEvaluateOnSeek(bool value); // 0x000000018B3A3CD4-0x000000018B3A3CDC
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target); // 0x000000018B3A3C90-0x000000018B3A3CD4
		[NativeThrows]
		private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value); // 0x000000018B3A3C4C-0x000000018B3A3C90
	}
}

namespace UnityEngine.Experimental.Audio
{
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	public class AudioSampleProvider // TypeDefIndex: 63373
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesAvailable; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesOverflow; // 0x18
	
		// Nested types
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount); // TypeDefIndex: 63372; 0x00000001838E1420-0x00000001838E1430
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount); // 0x000000018B3A3EAC-0x000000018B3A3ED4
		[RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount); // 0x000000018B3A3ED4-0x000000018B3A3EFC
	}
}
