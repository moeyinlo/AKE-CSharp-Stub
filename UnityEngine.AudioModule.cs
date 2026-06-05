/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

// Image 107: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60729-60747

namespace UnityEngine
{
	public sealed class AudioSettings // TypeDefIndex: 60731
	{
		// Fields
		private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x00
		private static Action OnAudioSystemShuttingDown; // 0x08
		private static Action OnAudioSystemStartedUp; // 0x10
	
		// Nested types
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged); // TypeDefIndex: 60730; 0x000000018BEB0EB0-0x000000018BEB0EF4
	
		// Constructors
		public AudioSettings() {} // Dummy constructor
	
		// Methods
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) {} // 0x000000018BEB0EF4-0x000000018BEB0F38
		internal static void InvokeOnAudioSystemShuttingDown() {} // 0x00000001889CCDF0-0x00000001889CCEB8
		internal static void InvokeOnAudioSystemStartedUp() {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public sealed class AudioClip : UnityEngine.Object // TypeDefIndex: 60734
	{
		// Fields
		private PCMReaderCallback m_PCMReaderCallback; // 0x18
		private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20
	
		// Properties
		public float length { get => default; } // 0x000000018BEB0224-0x000000018BEB023C 
		public int samples { get => default; } // 0x0000000188F4DA44-0x0000000188F4DB18 
		public int frequency { get => default; } // 0x00000001833EEC70-0x00000001833EEC80 
	
		// Nested types
		public delegate void PCMReaderCallback(float[] data); // TypeDefIndex: 60732; 0x000000018BEB02A4-0x000000018BEB02D8
	
		public delegate void PCMSetPositionCallback(int position); // TypeDefIndex: 60733; 0x000000018BEB020C-0x000000018BEB0224
	
		// Constructors
		public AudioClip() {} // Dummy constructor
	
		// Methods
		private void InvokePCMReaderCallback_Internal(float[] data) {} // 0x000000018789F4A4-0x000000018789F56C
		private void InvokePCMSetPositionCallback_Internal(int position) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public class AudioBehaviour : UnityEngine.Behaviour // TypeDefIndex: 60735
	{
		// Constructors
		public AudioBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 60736
	{
		// Constructors
		public AudioListener() {} // Dummy constructor
	}

	public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 60737
	{
		// Properties
		public float volume { set {} } // 0x000000018BEB1534-0x000000018BEB1578
		public float pitch { set {} } // 0x000000018BEB1460-0x000000018BEB1468
		public float time { get => default; set {} } // 0x000000018BEB131C-0x000000018BEB1350 0x000000018BEB14F0-0x000000018BEB1534
		public AudioClip clip { set {} } // 0x000000018BEB1394-0x000000018BEB13D8
		public AudioMixerGroup outputAudioMixerGroup { set {} } // 0x000000018BEB13D8-0x000000018BEB141C
		public bool isPlaying { get => default; } // 0x000000018BEB12E8-0x000000018BEB131C 
		public bool playOnAwake { set {} } // 0x000000018BEB1468-0x000000018BEB14AC
		public float panStereo { set {} } // 0x000000018BEB141C-0x000000018BEB1460
		public float spatialBlend { set {} } // 0x000000018BEB14AC-0x000000018BEB14F0
		public bool bypassReverbZones { set {} } // 0x000000018BEB1350-0x000000018BEB1394
	
		// Constructors
		public AudioSource() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private static void SetPitch(AudioSource source, float pitch) {} // 0x000000018BEB1254-0x000000018BEB1298
		private static void PlayHelper(AudioSource source, ulong delay) {} // 0x000000018BEB1108-0x000000018BEB114C
		private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) {} // 0x000000018BEB114C-0x000000018BEB11A0
		private void Stop(bool stopOneShots) {} // 0x000000018BEB12A4-0x000000018BEB12E8
		public void Play() {} // 0x000000018BEB1248-0x000000018BEB1254
		public void PlayOneShot(AudioClip clip, float volumeScale) {} // 0x000000018BEB11A0-0x000000018BEB1248
		public void Stop() {} // 0x000000018BEB1298-0x000000018BEB12A4
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) {} // 0x000000018BEB0F38-0x000000018BEB1108
	}
}

namespace UnityEngine.Audio
{
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 60738
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioClipPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEB00BC-0x000000018BEB0194
	
		// Methods
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) => default; // 0x000000018BEAFA5C-0x000000018BEAFB70
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) => default; // 0x000000018BEAF994-0x000000018BEAFA5C
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AudioClipPlayable playable) => default; // 0x0000000185FE6690-0x0000000185FE66A0
		public static explicit operator AudioClipPlayable(Playable playable) => default; // 0x000000018BEB0194-0x000000018BEB020C
		public bool Equals(AudioClipPlayable other) => default; // 0x000000018BEAFB70-0x000000018BEAFBE4
		internal void SetVolume(float value) {} // 0x000000018BEB0014-0x000000018BEB00BC
		internal void SetStereoPan(float value) {} // 0x000000018BEAFF24-0x000000018BEAFFD0
		internal void SetSpatialBlend(float value) {} // 0x000000018BEAFDF4-0x000000018BEAFE9C
		public void Seek(double startTime, double startDelay, double duration) {} // 0x000000018BEAFC48-0x000000018BEAFD6C
		private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) {} // 0x000000018BEAFFD0-0x000000018BEB0014
		private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) {} // 0x000000018BEAFEE0-0x000000018BEAFF24
		private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) {} // 0x000000018BEAFDB0-0x000000018BEAFDF4
		private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) {} // 0x000000018BEAFE9C-0x000000018BEAFEE0
		private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) {} // 0x000000018BEAFD6C-0x000000018BEAFDB0
		private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) => default; // 0x000000018BEAFBE4-0x000000018BEAFC48
	}

	public class AudioMixer : UnityEngine.Object // TypeDefIndex: 60739
	{
		// Constructors
		internal AudioMixer() {} // 0x000000018BEB0928-0x000000018BEB0968
	
		// Methods
		public AudioMixerSnapshot FindSnapshot(string name) => default; // 0x000000018BEB0660-0x000000018BEB06A4
		internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) {} // 0x000000018BEB06F8-0x000000018BEB0928
		private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) {} // 0x000000018BEB06A4-0x000000018BEB06F8
	}

	public class AudioMixerGroup : UnityEngine.Object // TypeDefIndex: 60740
	{
		// Constructors
		public AudioMixerGroup() {} // Dummy constructor
	}

	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 60741
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Constructors
		internal AudioMixerPlayable(PlayableHandle handle) {
			m_Handle = default;
		} // 0x000000018BEB04D4-0x000000018BEB05AC
	
		// Methods
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02082AE8 */, bool normalizeInputVolumes = false /* Metadata: 0x02082AE9 */) => default; // 0x000000018BEB0400-0x000000018BEB0460
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) => default; // 0x000000018BEB032C-0x000000018BEB0400
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator Playable(AudioMixerPlayable playable) => default; // 0x0000000185FE6690-0x0000000185FE66A0
		public bool Equals(AudioMixerPlayable other) => default; // 0x000000018BEB0460-0x000000018BEB04D4
		private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) => default; // 0x000000018BEB02D8-0x000000018BEB032C
	}

	public class AudioMixerSnapshot : UnityEngine.Object // TypeDefIndex: 60742
	{
		// Properties
		public AudioMixer audioMixer { get => default; } // 0x000000018BEB062C-0x000000018BEB0660 
	
		// Constructors
		internal AudioMixerSnapshot() {} // 0x000000018BEB05EC-0x000000018BEB062C
	
		// Methods
		public void TransitionTo(float timeToReach) {} // 0x000000018BEB05AC-0x000000018BEB05EC
	}

	public static class AudioPlayableBinding // TypeDefIndex: 60743
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key) => default; // 0x000000018BEB09A8-0x000000018BEB0AC4
		private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name) => default; // 0x000000018BEB0968-0x000000018BEB09A8
	}

	internal static class AudioPlayableGraphExtensions // TypeDefIndex: 60744
	{
		// Methods
		internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x000000018BEB0AC4-0x000000018BEB0B18
	}

	public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 60745
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static AudioPlayableOutput Null { get => default; } // 0x000000018BEB0D20-0x000000018BEB0D98 
	
		// Constructors
		internal AudioPlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x000000018BEB0C48-0x000000018BEB0D20
	
		// Methods
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) => default; // 0x000000018BEB0B18-0x000000018BEB0BB0
		public PlayableOutputHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator PlayableOutput(AudioPlayableOutput output) => default; // 0x0000000185FE6690-0x0000000185FE66A0
		public static explicit operator AudioPlayableOutput(PlayableOutput output) => default; // 0x000000018BEB0D98-0x000000018BEB0E10
		public void SetTarget(AudioSource value) {} // 0x000000018BEB0C40-0x000000018BEB0C48
		public void SetEvaluateOnSeek(bool value) {} // 0x000000018BEB0C38-0x000000018BEB0C40
		private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) {} // 0x000000018BEB0BF4-0x000000018BEB0C38
		private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) {} // 0x000000018BEB0BB0-0x000000018BEB0BF4
	}
}

namespace UnityEngine.Experimental.Audio
{
	public class AudioSampleProvider // TypeDefIndex: 60747
	{
		// Fields
		private SampleFramesHandler sampleFramesAvailable; // 0x10
		private SampleFramesHandler sampleFramesOverflow; // 0x18
	
		// Nested types
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount); // TypeDefIndex: 60746; 0x000000018BEB0E38-0x000000018BEB0E60
	
		// Constructors
		public AudioSampleProvider() {} // Dummy constructor
	
		// Methods
		private void InvokeSampleFramesAvailable(int sampleFrameCount) {} // 0x000000018BEB1578-0x000000018BEB17C0
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) {} // 0x00000001831C5680-0x00000001831C5690
	}
}
