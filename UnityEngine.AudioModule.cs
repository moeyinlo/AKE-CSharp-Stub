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

// Image 109: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90789-90807

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings // TypeDefIndex: 90791
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
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged); // TypeDefIndex: 90790; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged); // 0x000000018D4CD474-0x000000018D4CD4C8
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown(); // 0x000000018D4CD4C8-0x000000018D4CD50C
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp(); // 0x000000018D4CD50C-0x000000018D4CD550
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : UnityEngine.Object // TypeDefIndex: 90794
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
		public float length { get; } // 0x000000018D4CC878-0x000000018D4CC8AC 
		[NativeProperty("SampleCount")]
		public int samples { get; } // 0x000000018D4CC8AC-0x000000018D4CC8E0 
		public int frequency { get; } // 0x000000018D4CC844-0x000000018D4CC878 
	
		// Nested types
		public delegate void PCMReaderCallback(float[] data); // TypeDefIndex: 90792; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void PCMSetPositionCallback(int position); // TypeDefIndex: 90793; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data); // 0x000000018D4CC80C-0x000000018D4CC828
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position); // 0x000000018D4CC828-0x000000018D4CC844
	}

	public class AudioBehaviour : UnityEngine.Behaviour // TypeDefIndex: 90795
	{
		// Constructors
		public AudioBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 90796
	{
	}

	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 90797
	{
		// Properties
		public float volume { set; } // 0x000000018D4CDB4C-0x000000018D4CDB90
		public float pitch { set; } // 0x000000018D4CDA78-0x000000018D4CDA80
		[NativeProperty("SecPosition")]
		public float time { get; set; } // 0x000000018D4CD934-0x000000018D4CD968 0x000000018D4CDB08-0x000000018D4CDB4C
		[NativeProperty("AudioClip")]
		public AudioClip clip { set; } // 0x000000018D4CD9AC-0x000000018D4CD9F0
		public AudioMixerGroup outputAudioMixerGroup { set; } // 0x000000018D4CD9F0-0x000000018D4CDA34
		public bool isPlaying { [NativeName("IsPlayingScripting")] get; } // 0x000000018D4CD900-0x000000018D4CD934 
		public bool playOnAwake { set; } // 0x000000018D4CDA80-0x000000018D4CDAC4
		[NativeProperty("StereoPan")]
		public float panStereo { set; } // 0x000000018D4CDA34-0x000000018D4CDA78
		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend { set; } // 0x000000018D4CDAC4-0x000000018D4CDB08
		public bool bypassReverbZones { set; } // 0x000000018D4CD968-0x000000018D4CD9AC
	
		// Constructors
		public AudioSource(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch); // 0x000000018D4CD86C-0x000000018D4CD8B0
		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay); // 0x000000018D4CD720-0x000000018D4CD764
		private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale); // 0x000000018D4CD764-0x000000018D4CD7B8
		private void Stop(bool stopOneShots); // 0x000000018D4CD8BC-0x000000018D4CD900
		[ExcludeFromDocs]
		public void Play(); // 0x000000018D4CD860-0x000000018D4CD86C
		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale); // 0x000000018D4CD7B8-0x000000018D4CD860
		public void Stop(); // 0x000000018D4CD8B0-0x000000018D4CD8BC
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume); // 0x000000018D4CD550-0x000000018D4CD720
	}
}

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 90798
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioClipPlayable(PlayableHandle handle); // 0x000000018D4CC6BC-0x000000018D4CC794
	
		// Methods
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping); // 0x000000018D4CC05C-0x000000018D4CC170
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping); // 0x000000018D4CBF90-0x000000018D4CC05C
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AudioClipPlayable playable); // 0x000000018725FEA0-0x000000018725FEB0
		public static explicit operator AudioClipPlayable(Playable playable); // 0x000000018D4CC794-0x000000018D4CC80C
		public bool Equals(AudioClipPlayable other); // 0x000000018D4CC170-0x000000018D4CC1E4
		internal void SetVolume(float value); // 0x000000018D4CC614-0x000000018D4CC6BC
		internal void SetStereoPan(float value); // 0x000000018D4CC524-0x000000018D4CC5D0
		internal void SetSpatialBlend(float value); // 0x000000018D4CC3F4-0x000000018D4CC49C
		public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration); // 0x000000018D4CC248-0x000000018D4CC36C
		[NativeThrows]
		private static void SetVolumeInternal(ref PlayableHandle hdl, float volume); // 0x000000018D4CC5D0-0x000000018D4CC614
		[NativeThrows]
		private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan); // 0x000000018D4CC4E0-0x000000018D4CC524
		[NativeThrows]
		private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend); // 0x000000018D4CC3B0-0x000000018D4CC3F4
		[NativeThrows]
		private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay); // 0x000000018D4CC49C-0x000000018D4CC4E0
		[NativeThrows]
		private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay); // 0x000000018D4CC36C-0x000000018D4CC3B0
		[NativeThrows]
		private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle); // 0x000000018D4CC1E4-0x000000018D4CC248
	}

	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	public class AudioMixer : UnityEngine.Object // TypeDefIndex: 90799
	{
		// Constructors
		internal AudioMixer(); // 0x000000018D4CCF34-0x000000018D4CCF74
	
		// Methods
		[NativeMethod("FindSnapshotFromName")]
		public AudioMixerSnapshot FindSnapshot(string name); // 0x000000018D4CCC6C-0x000000018D4CCCB0
		internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach); // 0x000000018D4CCD04-0x000000018D4CCF34
		[NativeMethod("TransitionToSnapshot")]
		private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach); // 0x000000018D4CCCB0-0x000000018D4CCD04
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
	public class AudioMixerGroup : UnityEngine.Object // TypeDefIndex: 90800
	{
	}

	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 90801
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioMixerPlayable(PlayableHandle handle); // 0x000000018D4CCAE0-0x000000018D4CCBB8
	
		// Methods
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x0264B138 */, bool normalizeInputVolumes = false /* Metadata: 0x0264B139 */); // 0x000000018D4CCA08-0x000000018D4CCA6C
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes); // 0x000000018D4CC934-0x000000018D4CCA08
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator Playable(AudioMixerPlayable playable); // 0x000000018725FEA0-0x000000018725FEB0
		public bool Equals(AudioMixerPlayable other); // 0x000000018D4CCA6C-0x000000018D4CCAE0
		[NativeThrows]
		private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle); // 0x000000018D4CC8E0-0x000000018D4CC934
	}

	[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
	public class AudioMixerSnapshot : UnityEngine.Object // TypeDefIndex: 90802
	{
		// Properties
		[NativeProperty]
		public AudioMixer audioMixer { get; } // 0x000000018D4CCC38-0x000000018D4CCC6C 
	
		// Constructors
		internal AudioMixerSnapshot(); // 0x000000018D4CCBF8-0x000000018D4CCC38
	
		// Methods
		public void TransitionTo(float timeToReach); // 0x000000018D4CCBB8-0x000000018D4CCBF8
	}

	public static class AudioPlayableBinding // TypeDefIndex: 90803
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key); // 0x000000018D4CCFB8-0x000000018D4CD0D8
		private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name); // 0x000000018D4CCF74-0x000000018D4CCFB8
	}

	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AudioPlayableGraphExtensions // TypeDefIndex: 90804
	{
		// Methods
		[NativeThrows]
		internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle); // 0x000000018D4CD0D8-0x000000018D4CD12C
	}

	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 90805
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AudioPlayableOutput Null { get; } // 0x000000018D4CD334-0x000000018D4CD3AC 
	
		// Constructors
		internal AudioPlayableOutput(PlayableOutputHandle handle); // 0x000000018D4CD25C-0x000000018D4CD334
	
		// Methods
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target); // 0x000000018D4CD12C-0x000000018D4CD1C4
		public PlayableOutputHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public static implicit operator PlayableOutput(AudioPlayableOutput output); // 0x000000018725FEA0-0x000000018725FEB0
		public static explicit operator AudioPlayableOutput(PlayableOutput output); // 0x000000018D4CD3AC-0x000000018D4CD424
		public void SetTarget(AudioSource value); // 0x000000018D4CD254-0x000000018D4CD25C
		public void SetEvaluateOnSeek(bool value); // 0x000000018D4CD24C-0x000000018D4CD254
		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target); // 0x000000018D4CD208-0x000000018D4CD24C
		[NativeThrows]
		private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value); // 0x000000018D4CD1C4-0x000000018D4CD208
	}
}

namespace UnityEngine.Experimental.Audio
{
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	public class AudioSampleProvider // TypeDefIndex: 90807
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesAvailable; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesOverflow; // 0x18
	
		// Nested types
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount); // TypeDefIndex: 90806; 0x00000001859B7730-0x00000001859B7740
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount); // 0x000000018D4CD424-0x000000018D4CD44C
		[RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount); // 0x000000018D4CD44C-0x000000018D4CD474
	}
}
