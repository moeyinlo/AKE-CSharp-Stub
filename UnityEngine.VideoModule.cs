/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Image 108: UnityEngine.VideoModule.dll - Assembly: UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59780-59794

namespace UnityEngine.Experimental.Video
{
	[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable> // TypeDefIndex: 59781
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000183D695A0-0x0000000183D695B0
		public bool Equals(VideoClipPlayable other) => default; // 0x0000000189F89A88-0x0000000189F89AFC
	}
}

namespace UnityEngine.Video
{
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[RequiredByNativeCode]
	public sealed class VideoClip : UnityEngine.Object // TypeDefIndex: 59782
	{
		// Properties
		public string originalPath { get => default; } // 0x0000000189F89D0C-0x0000000189F89D40 
		public ulong frameCount { get => default; } // 0x0000000189F89C3C-0x0000000189F89C70 
		public double frameRate { get => default; } // 0x0000000189F89C70-0x0000000189F89CA4 
		[NativeName("Duration")]
		public double length { get => default; } // 0x0000000189F89CD8-0x0000000189F89D0C 
		public uint width { get => default; } // 0x0000000189F89DDC-0x0000000189F89E10 
		public uint height { get => default; } // 0x0000000189F89CA4-0x0000000189F89CD8 
		public uint pixelAspectRatioNumerator { get => default; } // 0x0000000189F89D74-0x0000000189F89DA8 
		public uint pixelAspectRatioDenominator { get => default; } // 0x0000000189F89D40-0x0000000189F89D74 
		public bool sRGB { [NativeName("IssRGB")] get => default; } // 0x0000000189F89DA8-0x0000000189F89DDC 
		public ushort audioTrackCount { get => default; } // 0x0000000189F89C08-0x0000000189F89C3C 
	
		// Constructors
		private VideoClip() {} // 0x0000000189F89BC8-0x0000000189F89C08
	
		// Methods
		public ushort GetAudioChannelCount(ushort audioTrackIdx) => default; // 0x0000000189F89AFC-0x0000000189F89B40
		public uint GetAudioSampleRate(ushort audioTrackIdx) => default; // 0x0000000189F89B84-0x0000000189F89BC8
		public string GetAudioLanguage(ushort audioTrackIdx) => default; // 0x0000000189F89B40-0x0000000189F89B84
	}

	[RequiredByNativeCode]
	public enum VideoRenderMode // TypeDefIndex: 59783
	{
		CameraFarPlane = 0,
		CameraNearPlane = 1,
		RenderTexture = 2,
		MaterialOverride = 3,
		APIOnly = 4
	}

	[RequiredByNativeCode]
	public enum Video3DLayout // TypeDefIndex: 59784
	{
		No3D = 0,
		SideBySide3D = 1,
		OverUnder3D = 2
	}

	[RequiredByNativeCode]
	public enum VideoAspectRatio // TypeDefIndex: 59785
	{
		NoScaling = 0,
		FitVertically = 1,
		FitHorizontally = 2,
		FitInside = 3,
		FitOutside = 4,
		Stretch = 5
	}

	[RequiredByNativeCode]
	public enum VideoTimeSource // TypeDefIndex: 59786
	{
		AudioDSPTimeSource = 0,
		GameTimeSource = 1
	}

	[RequiredByNativeCode]
	public enum VideoTimeReference // TypeDefIndex: 59787
	{
		Freerun = 0,
		InternalTime = 1,
		ExternalTime = 2
	}

	[RequiredByNativeCode]
	public enum VideoSource // TypeDefIndex: 59788
	{
		VideoClip = 0,
		Url = 1
	}

	[RequiredByNativeCode]
	public enum VideoAudioOutputMode // TypeDefIndex: 59789
	{
		None = 0,
		AudioSource = 1,
		Direct = 2,
		APIOnly = 3
	}

	[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public sealed class VideoPlayer : UnityEngine.Behaviour // TypeDefIndex: 59794
	{
		// Properties
		public VideoSource source { get => default; set {} } // 0x0000000189F8AF5C-0x0000000189F8AF90 0x0000000189F8BAA8-0x0000000189F8BAEC
		[NativeName("VideoUrl")]
		public string url { get => default; set {} } // 0x0000000189F8AFF8-0x0000000189F8B02C 0x0000000189F8BB74-0x0000000189F8BBB8
		[NativeName("VideoClip")]
		public VideoClip clip { get => default; set {} } // 0x0000000189F8AFC4-0x0000000189F8AFF8 0x0000000189F8BB30-0x0000000189F8BB74
		public VideoRenderMode renderMode { get => default; set {} } // 0x0000000189F8AF90-0x0000000189F8AFC4 0x0000000189F8BAEC-0x0000000189F8BB30
		[NativeHeader("Runtime/Camera/Camera.h")]
		public Camera targetCamera { get => default; set {} } // 0x0000000189F8A8D8-0x0000000189F8A90C 0x0000000189F8B638-0x0000000189F8B678
		[NativeHeader("Runtime/Graphics/RenderTexture.h")]
		public RenderTexture targetTexture { get => default; set {} } // 0x0000000189F8AF28-0x0000000189F8AF5C 0x0000000189F8BA64-0x0000000189F8BAA8
		[NativeHeader("Runtime/Graphics/Renderer.h")]
		public Renderer targetMaterialRenderer { get => default; set {} } // 0x0000000189F8AEF4-0x0000000189F8AF28 0x0000000189F8BA24-0x0000000189F8BA64
		public string targetMaterialProperty { get => default; set {} } // 0x0000000189F8B02C-0x0000000189F8B060 0x0000000189F8A25C-0x0000000189F8A290
		public VideoAspectRatio aspectRatio { get => default; set {} } // 0x0000000189F8ACEC-0x0000000189F8AD20 0x0000000189F8B130-0x0000000189F8B164
		public float targetCameraAlpha { get => default; set {} } // 0x0000000189F8BCC0-0x0000000189F8BD04 0x0000000189F8ADBC-0x0000000189F8ADF0
		public Video3DLayout targetCamera3DLayout { get => default; set {} } // 0x0000000189F8B894-0x0000000189F8B8D8 0x0000000189F8A228-0x0000000189F8A25C
		[NativeHeader("Runtime/Graphics/Texture.h")]
		public Texture texture { get => default; } // 0x0000000189F8A1F4-0x0000000189F8A228 
		public bool isPrepared { [NativeName("IsPrepared")] get => default; } // 0x0000000189F8ACB8-0x0000000189F8ACEC 
		public bool waitForFirstFrame { get => default; set {} } // 0x0000000189F8AC84-0x0000000189F8ACB8 0x0000000189F8AA44-0x0000000189F8AA78
		public bool playOnAwake { get => default; set {} } // 0x0000000189F8B0C8-0x0000000189F8B0FC 0x0000000189F8BC38-0x0000000189F8BC7C
		public bool isPlaying { [NativeName("IsPlaying")] get => default; } // 0x0000000189F8AA78-0x0000000189F8AAAC 
		public bool isPaused { [NativeName("IsPaused")] get => default; } // 0x0000000189F8A3D0-0x0000000189F8A404 
		public bool canSetTime { [NativeName("CanSetTime")] get => default; } // 0x0000000189F8A9A8-0x0000000189F8A9DC 
		[NativeName("SecPosition")]
		public double time { get => default; set {} } // 0x0000000189F8ADF0-0x0000000189F8AE24 0x0000000189F8B8D8-0x0000000189F8B91C
		[NativeName("FramePosition")]
		public long frame { get => default; set {} } // 0x0000000189F8AC50-0x0000000189F8AC84 0x0000000189F8B850-0x0000000189F8B894
		public double clockTime { get => default; } // 0x0000000189F8AA10-0x0000000189F8AA44 
		public bool canStep { [NativeName("CanStep")] get => default; } // 0x0000000189F8B094-0x0000000189F8B0C8 
		public bool canSetPlaybackSpeed { [NativeName("CanSetPlaybackSpeed")] get => default; } // 0x0000000189F8B060-0x0000000189F8B094 
		public float playbackSpeed { get => default; set {} } // 0x0000000189F8BBB8-0x0000000189F8BBF8 0x0000000189F8AB4C-0x0000000189F8AB80
		[NativeName("Loop")]
		public bool isLooping { get => default; set {} } // 0x0000000189F8B7C8-0x0000000189F8B80C 0x0000000189F8A9DC-0x0000000189F8AA10
		public bool canSetTimeSource { [NativeName("CanSetTimeSource")] get => default; } // 0x0000000189F8AE8C-0x0000000189F8AEC0 
		public VideoTimeSource timeSource { get => default; set {} } // 0x0000000189F8B9A0-0x0000000189F8B9E4 0x0000000189F8AB80-0x0000000189F8ABB4
		public VideoTimeReference timeReference { get => default; set {} } // 0x0000000189F8ABB4-0x0000000189F8ABE8 0x0000000189F8AD20-0x0000000189F8AD54
		public double externalReferenceTime { get => default; set {} } // 0x0000000189F8B164-0x0000000189F8B198 0x0000000189F8AC1C-0x0000000189F8AC50
		public bool canSetSkipOnDrop { [NativeName("CanSetSkipOnDrop")] get => default; } // 0x0000000189F8AD88-0x0000000189F8ADBC 
		public bool skipOnDrop { get => default; set {} } // 0x0000000189F8AD54-0x0000000189F8AD88 0x0000000189F8A940-0x0000000189F8A974
		public ulong frameCount { get => default; } // 0x0000000189F89EA8-0x0000000189F89EEC 
		public float frameRate { get => default; } // 0x0000000189F89E64-0x0000000189F89EA8 
		[NativeName("Duration")]
		public double length { get => default; } // 0x0000000189F89EEC-0x0000000189F89F30 
		public uint width { get => default; } // 0x0000000189F8AB20-0x0000000189F8AB4C 
		public uint height { get => default; } // 0x0000000189F8AB14-0x0000000189F8AB20 
		public uint pixelAspectRatioNumerator { get => default; } // 0x0000000189F8B6FC-0x0000000189F8B7C8 
		public uint pixelAspectRatioDenominator { get => default; } // 0x0000000189F89F30-0x0000000189F89F64 
		public ushort audioTrackCount { get => default; } // 0x0000000189F8A290-0x0000000189F8A2D4 
		public static ushort controlledAudioTrackMaxCount { get => default; } // 0x0000000189F8B678-0x0000000189F8B6B8 
		public ushort controlledAudioTrackCount { get => default; set {} } // 0x0000000189F8A974-0x0000000189F8A9A8 0x0000000189F89FA8-0x0000000189F89FEC
		public VideoAudioOutputMode audioOutputMode { get => default; set {} } // 0x0000000189F8A37C-0x0000000189F8A3D0 0x0000000189F8A71C-0x0000000189F8A7B0
		public bool canSetDirectAudioVolume { [NativeName("CanSetDirectAudioVolume")] get => default; } // 0x0000000189F8B47C-0x0000000189F8B510 
		public bool sendFrameReadyEvents { [NativeName("AreFrameReadyEventsEnabled")] get => default; [NativeName("EnableFrameReadyEvents")] set {} } // 0x0000000189F8A090-0x0000000189F8A0C0 0x0000000189F8A060-0x0000000189F8A090
	
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
		public delegate void EventHandler(VideoPlayer source); // TypeDefIndex: 59790; 0x0000000189F8B9E4-0x0000000189F8BA24
	
		public delegate void ErrorEventHandler(VideoPlayer source, string message); // TypeDefIndex: 59791; 0x0000000189F8BC7C-0x0000000189F8BCC0
	
		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx); // TypeDefIndex: 59792; 0x0000000189F8B6B8-0x0000000189F8B6FC
	
		public delegate void TimeEventHandler(VideoPlayer source, double seconds); // TypeDefIndex: 59793; 0x0000000189F8B91C-0x0000000189F8B95C
	
		// Constructors
		public VideoPlayer() {} // 0x0000000182065C10-0x0000000182065C20
	
		// Methods
		public void Prepare() {} // 0x0000000189F8A404-0x0000000189F8A438
		public void Play() {} // 0x0000000189F8ABE8-0x0000000189F8AC1C
		public void Pause() {} // 0x0000000189F8B80C-0x0000000189F8B850
		public void Stop() {} // 0x0000000189F8AAE0-0x0000000189F8AB14
		public void StepForward() {} // 0x0000000189F8BBF8-0x0000000189F8BC38
		public string GetAudioLanguageCode(ushort trackIndex) => default; // 0x0000000189F89E10-0x0000000189F89E64
		public ushort GetAudioChannelCount(ushort trackIndex) => default; // 0x0000000189F8A1B0-0x0000000189F8A1F4
		public uint GetAudioSampleRate(ushort trackIndex) => default; // 0x0000000189F8A90C-0x0000000189F8A940
		private ushort GetControlledAudioTrackCount() => default; // 0x0000000189F8A328-0x0000000189F8A37C
		private void SetControlledAudioTrackCount(ushort value) {} // 0x0000000189F89F64-0x0000000189F89FA8
		public void EnableAudioTrack(ushort trackIndex, bool enabled) {} // 0x0000000189F8A2D4-0x0000000189F8A328
		public bool IsAudioTrackEnabled(ushort trackIndex) => default; // 0x0000000189F89FEC-0x0000000189F8A030
		public float GetDirectAudioVolume(ushort trackIndex) => default; // 0x0000000189F8A688-0x0000000189F8A71C
		public void SetDirectAudioVolume(ushort trackIndex, float volume) {} // 0x0000000189F8B3E8-0x0000000189F8B47C
		public bool GetDirectAudioMute(ushort trackIndex) => default; // 0x0000000189F8A844-0x0000000189F8A8D8
		public void SetDirectAudioMute(ushort trackIndex, bool mute) {} // 0x0000000189F8B5A4-0x0000000189F8B638
		[NativeHeader("Modules/Audio/Public/AudioSource.h")]
		public AudioSource GetTargetAudioSource(ushort trackIndex) => default; // 0x0000000189F8A560-0x0000000189F8A5F4
		public void SetTargetAudioSource(ushort trackIndex, AudioSource source) {} // 0x0000000189F8B2C0-0x0000000189F8B354
		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) {} // 0x000000018426FE60-0x000000018426FE68
		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) {} // 0x0000000186DE8490-0x0000000186DE8564
		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) {} // 0x0000000182149960-0x0000000182149970
		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source) {} // 0x000000018951C0FC-0x000000018951C1D0
		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) {} // 0x0000000182065C10-0x0000000182065C20
		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) {} // 0x0000000187977BE4-0x0000000187977CB8
		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) {} // 0x0000000182065C10-0x0000000182065C20
		[RequiredByNativeCode]
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) {} // 0x0000000189F899B4-0x0000000189F89A88
	}
}
