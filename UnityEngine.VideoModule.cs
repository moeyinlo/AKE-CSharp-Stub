/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;
using UnityEngine.Playables;

// Image 111: UnityEngine.VideoModule.dll - Assembly: UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60884-60898

namespace UnityEngine.Experimental.Video
{
	public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable> // TypeDefIndex: 60885
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(VideoClipPlayable other) => default; // 0x000000018C0A1774-0x000000018C0A17E8
	}
}

namespace UnityEngine.Video
{
	public sealed class VideoClip : UnityEngine.Object // TypeDefIndex: 60886
	{
		// Properties
		public string originalPath { get => default; } // 0x000000018C0A19F8-0x000000018C0A1A2C 
		public ulong frameCount { get => default; } // 0x000000018C0A1928-0x000000018C0A195C 
		public double frameRate { get => default; } // 0x000000018C0A195C-0x000000018C0A1990 
		public double length { get => default; } // 0x000000018C0A19C4-0x000000018C0A19F8 
		public uint width { get => default; } // 0x000000018C0A1AC8-0x000000018C0A1AFC 
		public uint height { get => default; } // 0x000000018C0A1990-0x000000018C0A19C4 
		public uint pixelAspectRatioNumerator { get => default; } // 0x000000018C0A1A60-0x000000018C0A1A94 
		public uint pixelAspectRatioDenominator { get => default; } // 0x000000018C0A1A2C-0x000000018C0A1A60 
		public bool sRGB { get => default; } // 0x000000018C0A1A94-0x000000018C0A1AC8 
		public ushort audioTrackCount { get => default; } // 0x000000018C0A18F4-0x000000018C0A1928 
	
		// Constructors
		private VideoClip() {} // 0x000000018C0A18B4-0x000000018C0A18F4
	
		// Methods
		public ushort GetAudioChannelCount(ushort audioTrackIdx) => default; // 0x000000018C0A17E8-0x000000018C0A182C
		public uint GetAudioSampleRate(ushort audioTrackIdx) => default; // 0x000000018C0A1870-0x000000018C0A18B4
		public string GetAudioLanguage(ushort audioTrackIdx) => default; // 0x000000018C0A182C-0x000000018C0A1870
	}

	public enum VideoRenderMode // TypeDefIndex: 60887
	{
		CameraFarPlane = 0,
		CameraNearPlane = 1,
		RenderTexture = 2,
		MaterialOverride = 3,
		APIOnly = 4
	}

	public enum Video3DLayout // TypeDefIndex: 60888
	{
		No3D = 0,
		SideBySide3D = 1,
		OverUnder3D = 2
	}

	public enum VideoAspectRatio // TypeDefIndex: 60889
	{
		NoScaling = 0,
		FitVertically = 1,
		FitHorizontally = 2,
		FitInside = 3,
		FitOutside = 4,
		Stretch = 5
	}

	public enum VideoTimeSource // TypeDefIndex: 60890
	{
		AudioDSPTimeSource = 0,
		GameTimeSource = 1
	}

	public enum VideoTimeReference // TypeDefIndex: 60891
	{
		Freerun = 0,
		InternalTime = 1,
		ExternalTime = 2
	}

	public enum VideoSource // TypeDefIndex: 60892
	{
		VideoClip = 0,
		Url = 1
	}

	public enum VideoAudioOutputMode // TypeDefIndex: 60893
	{
		None = 0,
		AudioSource = 1,
		Direct = 2,
		APIOnly = 3
	}

	public sealed class VideoPlayer : UnityEngine.Behaviour // TypeDefIndex: 60898
	{
		// Fields
		private EventHandler prepareCompleted; // 0x18
		private EventHandler loopPointReached; // 0x20
		private EventHandler started; // 0x28
		private EventHandler frameDropped; // 0x30
		private ErrorEventHandler errorReceived; // 0x38
		private EventHandler seekCompleted; // 0x40
		private TimeEventHandler clockResyncOccurred; // 0x48
		private FrameReadyEventHandler frameReady; // 0x50
	
		// Properties
		public VideoSource source { get => default; set {} } // 0x000000018C0A2C48-0x000000018C0A2C7C 0x000000018C0A3794-0x000000018C0A37D8
		public string url { get => default; set {} } // 0x000000018C0A2CE4-0x000000018C0A2D18 0x000000018C0A3860-0x000000018C0A38A4
		public VideoClip clip { get => default; set {} } // 0x000000018C0A2CB0-0x000000018C0A2CE4 0x000000018C0A381C-0x000000018C0A3860
		public VideoRenderMode renderMode { get => default; set {} } // 0x000000018C0A2C7C-0x000000018C0A2CB0 0x000000018C0A37D8-0x000000018C0A381C
		public Camera targetCamera { get => default; set {} } // 0x000000018C0A25C4-0x000000018C0A25F8 0x000000018C0A3324-0x000000018C0A3364
		public RenderTexture targetTexture { get => default; set {} } // 0x000000018C0A2C14-0x000000018C0A2C48 0x000000018C0A3750-0x000000018C0A3794
		public Renderer targetMaterialRenderer { get => default; set {} } // 0x000000018C0A2BE0-0x000000018C0A2C14 0x000000018C0A3710-0x000000018C0A3750
		public string targetMaterialProperty { get => default; set {} } // 0x000000018C0A2D18-0x000000018C0A2D4C 0x000000018C0A1F48-0x000000018C0A1F7C
		public VideoAspectRatio aspectRatio { get => default; set {} } // 0x000000018C0A29D8-0x000000018C0A2A0C 0x000000018C0A2E1C-0x000000018C0A2E50
		public float targetCameraAlpha { get => default; set {} } // 0x000000018C0A39AC-0x000000018C0A39F0 0x000000018C0A2AA8-0x000000018C0A2ADC
		public Video3DLayout targetCamera3DLayout { get => default; set {} } // 0x000000018C0A3580-0x000000018C0A35C4 0x000000018C0A1F14-0x000000018C0A1F48
		public Texture texture { get => default; } // 0x000000018C0A1EE0-0x000000018C0A1F14 
		public bool isPrepared { get => default; } // 0x000000018C0A29A4-0x000000018C0A29D8 
		public bool waitForFirstFrame { get => default; set {} } // 0x000000018C0A2970-0x000000018C0A29A4 0x000000018C0A2730-0x000000018C0A2764
		public bool playOnAwake { get => default; set {} } // 0x000000018C0A2DB4-0x000000018C0A2DE8 0x000000018C0A3924-0x000000018C0A3968
		public bool isPlaying { get => default; } // 0x000000018C0A2764-0x000000018C0A2798 
		public bool isPaused { get => default; } // 0x000000018C0A20BC-0x000000018C0A20F0 
		public bool canSetTime { get => default; } // 0x000000018C0A2694-0x000000018C0A26C8 
		public double time { get => default; set {} } // 0x000000018C0A2ADC-0x000000018C0A2B10 0x000000018C0A35C4-0x000000018C0A3608
		public long frame { get => default; set {} } // 0x000000018C0A293C-0x000000018C0A2970 0x000000018C0A353C-0x000000018C0A3580
		public double clockTime { get => default; } // 0x000000018C0A26FC-0x000000018C0A2730 
		public bool canStep { get => default; } // 0x000000018C0A2D80-0x000000018C0A2DB4 
		public bool canSetPlaybackSpeed { get => default; } // 0x000000018C0A2D4C-0x000000018C0A2D80 
		public float playbackSpeed { get => default; set {} } // 0x000000018C0A38A4-0x000000018C0A38E4 0x000000018C0A2838-0x000000018C0A286C
		public bool isLooping { get => default; set {} } // 0x000000018C0A34B4-0x000000018C0A34F8 0x000000018C0A26C8-0x000000018C0A26FC
		public bool canSetTimeSource { get => default; } // 0x000000018C0A2B78-0x000000018C0A2BAC 
		public VideoTimeSource timeSource { get => default; set {} } // 0x000000018C0A368C-0x000000018C0A36D0 0x000000018C0A286C-0x000000018C0A28A0
		public VideoTimeReference timeReference { get => default; set {} } // 0x000000018C0A28A0-0x000000018C0A28D4 0x000000018C0A2A0C-0x000000018C0A2A40
		public double externalReferenceTime { get => default; set {} } // 0x000000018C0A2E50-0x000000018C0A2E84 0x000000018C0A2908-0x000000018C0A293C
		public bool canSetSkipOnDrop { get => default; } // 0x000000018C0A2A74-0x000000018C0A2AA8 
		public bool skipOnDrop { get => default; set {} } // 0x000000018C0A2A40-0x000000018C0A2A74 0x000000018C0A262C-0x000000018C0A2660
		public ulong frameCount { get => default; } // 0x000000018C0A1B94-0x000000018C0A1BD8 
		public float frameRate { get => default; } // 0x000000018C0A1B50-0x000000018C0A1B94 
		public double length { get => default; } // 0x000000018C0A1BD8-0x000000018C0A1C1C 
		public uint width { get => default; } // 0x000000018C0A280C-0x000000018C0A2838 
		public uint height { get => default; } // 0x000000018C0A2800-0x000000018C0A280C 
		public uint pixelAspectRatioNumerator { get => default; } // 0x000000018C0A33E8-0x000000018C0A34B4 
		public uint pixelAspectRatioDenominator { get => default; } // 0x000000018C0A1C1C-0x000000018C0A1C50 
		public ushort audioTrackCount { get => default; } // 0x000000018C0A1F7C-0x000000018C0A1FC0 
		public static ushort controlledAudioTrackMaxCount { get => default; } // 0x000000018C0A3364-0x000000018C0A33A4 
		public ushort controlledAudioTrackCount { get => default; set {} } // 0x000000018C0A2660-0x000000018C0A2694 0x000000018C0A1C94-0x000000018C0A1CD8
		public VideoAudioOutputMode audioOutputMode { get => default; set {} } // 0x000000018C0A2068-0x000000018C0A20BC 0x000000018C0A2408-0x000000018C0A249C
		public bool canSetDirectAudioVolume { get => default; } // 0x000000018C0A3168-0x000000018C0A31FC 
		public bool sendFrameReadyEvents { get => default; set {} } // 0x000000018C0A1D7C-0x000000018C0A1DAC 0x000000018C0A1D4C-0x000000018C0A1D7C
	
		// Events
		public event EventHandler prepareCompleted;
		public event EventHandler loopPointReached;
		public event EventHandler started;
		public event EventHandler frameDropped;
		public event ErrorEventHandler errorReceived;
		public event EventHandler seekCompleted;
		public event TimeEventHandler clockResyncOccurred;
		public event FrameReadyEventHandler frameReady;
	
		// Nested types
		public delegate void EventHandler(VideoPlayer source); // TypeDefIndex: 60894; 0x000000018C0A36D0-0x000000018C0A3710
	
		public delegate void ErrorEventHandler(VideoPlayer source, string message); // TypeDefIndex: 60895; 0x000000018C0A3968-0x000000018C0A39AC
	
		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx); // TypeDefIndex: 60896; 0x000000018C0A33A4-0x000000018C0A33E8
	
		public delegate void TimeEventHandler(VideoPlayer source, double seconds); // TypeDefIndex: 60897; 0x000000018C0A3608-0x000000018C0A3648
	
		// Constructors
		public VideoPlayer() {} // 0x00000001831C5680-0x00000001831C5690
	
		// Methods
		public void Prepare() {} // 0x000000018C0A20F0-0x000000018C0A2124
		public void Play() {} // 0x000000018C0A28D4-0x000000018C0A2908
		public void Pause() {} // 0x000000018C0A34F8-0x000000018C0A353C
		public void Stop() {} // 0x000000018C0A27CC-0x000000018C0A2800
		public void StepForward() {} // 0x000000018C0A38E4-0x000000018C0A3924
		public string GetAudioLanguageCode(ushort trackIndex) => default; // 0x000000018C0A1AFC-0x000000018C0A1B50
		public ushort GetAudioChannelCount(ushort trackIndex) => default; // 0x000000018C0A1E9C-0x000000018C0A1EE0
		public uint GetAudioSampleRate(ushort trackIndex) => default; // 0x000000018C0A25F8-0x000000018C0A262C
		private ushort GetControlledAudioTrackCount() => default; // 0x000000018C0A2014-0x000000018C0A2068
		private void SetControlledAudioTrackCount(ushort value) {} // 0x000000018C0A1C50-0x000000018C0A1C94
		public void EnableAudioTrack(ushort trackIndex, bool enabled) {} // 0x000000018C0A1FC0-0x000000018C0A2014
		public bool IsAudioTrackEnabled(ushort trackIndex) => default; // 0x000000018C0A1CD8-0x000000018C0A1D1C
		public float GetDirectAudioVolume(ushort trackIndex) => default; // 0x000000018C0A2374-0x000000018C0A2408
		public void SetDirectAudioVolume(ushort trackIndex, float volume) {} // 0x000000018C0A30D4-0x000000018C0A3168
		public bool GetDirectAudioMute(ushort trackIndex) => default; // 0x000000018C0A2530-0x000000018C0A25C4
		public void SetDirectAudioMute(ushort trackIndex, bool mute) {} // 0x000000018C0A3290-0x000000018C0A3324
		public AudioSource GetTargetAudioSource(ushort trackIndex) => default; // 0x000000018C0A224C-0x000000018C0A22E0
		public void SetTargetAudioSource(ushort trackIndex, AudioSource source) {} // 0x000000018C0A2FAC-0x000000018C0A3040
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) {} // 0x000000018646DB20-0x000000018646DB28
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) {} // 0x0000000188F4DA44-0x0000000188F4DB18
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) {} // 0x00000001833EEC70-0x00000001833EEC80
		private static void InvokeStartedCallback_Internal(VideoPlayer source) {} // 0x000000018B642154-0x000000018B642228
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) {} // 0x00000001831C5680-0x00000001831C5690
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) {} // 0x0000000189AE6B08-0x0000000189AE6BDC
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) {} // 0x00000001831C5680-0x00000001831C5690
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) {} // 0x000000018C0A16A0-0x000000018C0A1774
	}
}
