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

// Image 113: UnityEngine.VideoModule.dll - Assembly: UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90944-90958

namespace UnityEngine.Experimental.Video
{
	[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable> // TypeDefIndex: 90945
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle(); // 0x000000018724C6B0-0x000000018724C6C0
		public bool Equals(VideoClipPlayable other); // 0x000000018D6B7D30-0x000000018D6B7DA4
	}
}

namespace UnityEngine.Video
{
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[RequiredByNativeCode]
	public sealed class VideoClip : UnityEngine.Object // TypeDefIndex: 90946
	{
		// Properties
		public string originalPath { get; } // 0x000000018D6B7FB4-0x000000018D6B7FE8 
		public ulong frameCount { get; } // 0x000000018D6B7EE4-0x000000018D6B7F18 
		public double frameRate { get; } // 0x000000018D6B7F18-0x000000018D6B7F4C 
		[NativeName("Duration")]
		public double length { get; } // 0x000000018D6B7F80-0x000000018D6B7FB4 
		public uint width { get; } // 0x000000018D6B8084-0x000000018D6B80B8 
		public uint height { get; } // 0x000000018D6B7F4C-0x000000018D6B7F80 
		public uint pixelAspectRatioNumerator { get; } // 0x000000018D6B801C-0x000000018D6B8050 
		public uint pixelAspectRatioDenominator { get; } // 0x000000018D6B7FE8-0x000000018D6B801C 
		public bool sRGB { [NativeName("IssRGB")] get; } // 0x000000018D6B8050-0x000000018D6B8084 
		public ushort audioTrackCount { get; } // 0x000000018D6B7EB0-0x000000018D6B7EE4 
	
		// Constructors
		private VideoClip(); // 0x000000018D6B7E70-0x000000018D6B7EB0
	
		// Methods
		public ushort GetAudioChannelCount(ushort audioTrackIdx); // 0x000000018D6B7DA4-0x000000018D6B7DE8
		public uint GetAudioSampleRate(ushort audioTrackIdx); // 0x000000018D6B7E2C-0x000000018D6B7E70
		public string GetAudioLanguage(ushort audioTrackIdx); // 0x000000018D6B7DE8-0x000000018D6B7E2C
	}

	[RequiredByNativeCode]
	public enum VideoRenderMode // TypeDefIndex: 90947
	{
		CameraFarPlane = 0,
		CameraNearPlane = 1,
		RenderTexture = 2,
		MaterialOverride = 3,
		APIOnly = 4
	}

	[RequiredByNativeCode]
	public enum Video3DLayout // TypeDefIndex: 90948
	{
		No3D = 0,
		SideBySide3D = 1,
		OverUnder3D = 2
	}

	[RequiredByNativeCode]
	public enum VideoAspectRatio // TypeDefIndex: 90949
	{
		NoScaling = 0,
		FitVertically = 1,
		FitHorizontally = 2,
		FitInside = 3,
		FitOutside = 4,
		Stretch = 5
	}

	[RequiredByNativeCode]
	public enum VideoTimeSource // TypeDefIndex: 90950
	{
		AudioDSPTimeSource = 0,
		GameTimeSource = 1
	}

	[RequiredByNativeCode]
	public enum VideoTimeReference // TypeDefIndex: 90951
	{
		Freerun = 0,
		InternalTime = 1,
		ExternalTime = 2
	}

	[RequiredByNativeCode]
	public enum VideoSource // TypeDefIndex: 90952
	{
		VideoClip = 0,
		Url = 1
	}

	[RequiredByNativeCode]
	public enum VideoAudioOutputMode // TypeDefIndex: 90953
	{
		None = 0,
		AudioSource = 1,
		Direct = 2,
		APIOnly = 3
	}

	[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public sealed class VideoPlayer : UnityEngine.Behaviour // TypeDefIndex: 90958
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler prepareCompleted; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler loopPointReached; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler started; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler frameDropped; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ErrorEventHandler errorReceived; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler seekCompleted; // 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TimeEventHandler clockResyncOccurred; // 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FrameReadyEventHandler frameReady; // 0x50
	
		// Properties
		public VideoSource source { get; set; } // 0x000000018D6B9174-0x000000018D6B91A8 0x000000018D6B9C98-0x000000018D6B9CD8
		[NativeName("VideoUrl")]
		public string url { get; set; } // 0x000000018D6B93B0-0x000000018D6B93E4 0x000000018D6B9F30-0x000000018D6B9F74
		[NativeName("VideoClip")]
		public VideoClip clip { get; set; } // 0x000000018D6B8D60-0x000000018D6B8D94 0x000000018D6B996C-0x000000018D6B99B0
		public VideoRenderMode renderMode { get; set; } // 0x000000018D6B90D8-0x000000018D6B910C 0x000000018D6B9BD0-0x000000018D6B9C10
		[NativeHeader("Runtime/Camera/Camera.h")]
		public Camera targetCamera { get; set; } // 0x000000018D6B9210-0x000000018D6B9244 0x000000018D6B9D5C-0x000000018D6B9DA0
		[NativeHeader("Runtime/Graphics/RenderTexture.h")]
		public RenderTexture targetTexture { get; set; } // 0x000000018D6B92AC-0x000000018D6B92E0 0x000000018D6B9E28-0x000000018D6B9E6C
		[NativeHeader("Runtime/Graphics/Renderer.h")]
		public Renderer targetMaterialRenderer { get; set; } // 0x000000018D6B9278-0x000000018D6B92AC 0x000000018D6B9DE4-0x000000018D6B9E28
		public string targetMaterialProperty { get; set; } // 0x000000018D6B9244-0x000000018D6B9278 0x000000018D6B9DA0-0x000000018D6B9DE4
		public VideoAspectRatio aspectRatio { get; set; } // 0x000000018D6B8B8C-0x000000018D6B8BC0 0x000000018D6B98EC-0x000000018D6B992C
		public float targetCameraAlpha { get; set; } // 0x000000018D6B91DC-0x000000018D6B9210 0x000000018D6B9D18-0x000000018D6B9D5C
		public Video3DLayout targetCamera3DLayout { get; set; } // 0x000000018D6B91A8-0x000000018D6B91DC 0x000000018D6B9CD8-0x000000018D6B9D18
		[NativeHeader("Runtime/Graphics/Texture.h")]
		public Texture texture { get; } // 0x000000018D6B92E0-0x000000018D6B9314 
		public bool isPrepared { [NativeName("IsPrepared")] get; } // 0x000000018D6B8FA0-0x000000018D6B8FD4 
		public bool waitForFirstFrame { get; set; } // 0x000000018D6B93E4-0x000000018D6B9418 0x000000018D6B9F74-0x000000018D6B9FB8
		public bool playOnAwake { get; set; } // 0x000000018D6B9070-0x000000018D6B90A4 0x000000018D6B9B48-0x000000018D6B9B8C
		public bool isPlaying { [NativeName("IsPlaying")] get; } // 0x000000018D6B8F6C-0x000000018D6B8FA0 
		public bool isPaused { [NativeName("IsPaused")] get; } // 0x000000018D6B8F38-0x000000018D6B8F6C 
		public bool canSetTime { [NativeName("CanSetTime")] get; } // 0x000000018D6B8CF8-0x000000018D6B8D2C 
		[NativeName("SecPosition")]
		public double time { get; set; } // 0x000000018D6B937C-0x000000018D6B93B0 0x000000018D6B9EEC-0x000000018D6B9F30
		[NativeName("FramePosition")]
		public long frame { get; set; } // 0x000000018D6B8E9C-0x000000018D6B8ED0 0x000000018D6B9AC0-0x000000018D6B9B04
		public double clockTime { get; } // 0x000000018D6B8D94-0x000000018D6B8DC8 
		public bool canStep { [NativeName("CanStep")] get; } // 0x000000018D6B8D2C-0x000000018D6B8D60 
		public bool canSetPlaybackSpeed { [NativeName("CanSetPlaybackSpeed")] get; } // 0x000000018D6B8C5C-0x000000018D6B8C90 
		public float playbackSpeed { get; set; } // 0x000000018D6B90A4-0x000000018D6B90D8 0x000000018D6B9B8C-0x000000018D6B9BD0
		[NativeName("Loop")]
		public bool isLooping { get; set; } // 0x000000018D6B8F04-0x000000018D6B8F38 0x000000018D6B9B04-0x000000018D6B9B48
		public bool canSetTimeSource { [NativeName("CanSetTimeSource")] get; } // 0x000000018D6B8CC4-0x000000018D6B8CF8 
		public VideoTimeSource timeSource { get; set; } // 0x000000018D6B9348-0x000000018D6B937C 0x000000018D6B9EAC-0x000000018D6B9EEC
		public VideoTimeReference timeReference { get; set; } // 0x000000018D6B9314-0x000000018D6B9348 0x000000018D6B9E6C-0x000000018D6B9EAC
		public double externalReferenceTime { get; set; } // 0x000000018D6B8E00-0x000000018D6B8E34 0x000000018D6B9A7C-0x000000018D6B9AC0
		public bool canSetSkipOnDrop { [NativeName("CanSetSkipOnDrop")] get; } // 0x000000018D6B8C90-0x000000018D6B8CC4 
		public bool skipOnDrop { get; set; } // 0x000000018D6B9140-0x000000018D6B9174 0x000000018D6B9C54-0x000000018D6B9C98
		public ulong frameCount { get; } // 0x000000018D6B8E34-0x000000018D6B8E68 
		public float frameRate { get; } // 0x000000018D6B8E68-0x000000018D6B8E9C 
		[NativeName("Duration")]
		public double length { get; } // 0x000000018D6B8FD4-0x000000018D6B9008 
		public uint width { get; } // 0x000000018D6B9418-0x000000018D6B944C 
		public uint height { get; } // 0x000000018D6B8ED0-0x000000018D6B8F04 
		public uint pixelAspectRatioNumerator { get; } // 0x000000018D6B903C-0x000000018D6B9070 
		public uint pixelAspectRatioDenominator { get; } // 0x000000018D6B9008-0x000000018D6B903C 
		public ushort audioTrackCount { get; } // 0x000000018D6B8BF4-0x000000018D6B8C28 
		public static ushort controlledAudioTrackMaxCount { get; } // 0x000000018D6B8DD4-0x000000018D6B8E00 
		public ushort controlledAudioTrackCount { get; set; } // 0x000000018D6B8DC8-0x000000018D6B8DD4 0x000000018D6B99B0-0x000000018D6B9A7C
		public VideoAudioOutputMode audioOutputMode { get; set; } // 0x000000018D6B8BC0-0x000000018D6B8BF4 0x000000018D6B992C-0x000000018D6B996C
		public bool canSetDirectAudioVolume { [NativeName("CanSetDirectAudioVolume")] get; } // 0x000000018D6B8C28-0x000000018D6B8C5C 
		public bool sendFrameReadyEvents { [NativeName("AreFrameReadyEventsEnabled")] get; [NativeName("EnableFrameReadyEvents")] set; } // 0x000000018D6B910C-0x000000018D6B9140 0x000000018D6B9C10-0x000000018D6B9C54
	
		// Events
		public event EventHandler prepareCompleted {
			add; // 0x000000018D6B89D0-0x000000018D6B8A64
			remove; // 0x000000018D6B9730-0x000000018D6B97C4
		}
		public event EventHandler loopPointReached {
			add; // 0x000000018D6B893C-0x000000018D6B89D0
			remove; // 0x000000018D6B969C-0x000000018D6B9730
		}
		public event EventHandler started {
			add; // 0x000000018D6B8AF8-0x000000018D6B8B8C
			remove; // 0x000000018D6B9858-0x000000018D6B98EC
		}
		public event EventHandler frameDropped {
			add; // 0x000000018D6B8814-0x000000018D6B88A8
			remove; // 0x000000018D6B9574-0x000000018D6B9608
		}
		public event ErrorEventHandler errorReceived {
			add; // 0x000000018D6B8780-0x000000018D6B8814
			remove; // 0x000000018D6B94E0-0x000000018D6B9574
		}
		public event EventHandler seekCompleted {
			add; // 0x000000018D6B8A64-0x000000018D6B8AF8
			remove; // 0x000000018D6B97C4-0x000000018D6B9858
		}
		public event TimeEventHandler clockResyncOccurred {
			add; // 0x000000018D6B86EC-0x000000018D6B8780
			remove; // 0x000000018D6B944C-0x000000018D6B94E0
		}
		public event FrameReadyEventHandler frameReady {
			add; // 0x000000018D6B88A8-0x000000018D6B893C
			remove; // 0x000000018D6B9608-0x000000018D6B969C
		}
	
		// Nested types
		public delegate void EventHandler(VideoPlayer source); // TypeDefIndex: 90954; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void ErrorEventHandler(VideoPlayer source, string message); // TypeDefIndex: 90955; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx); // TypeDefIndex: 90956; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void TimeEventHandler(VideoPlayer source, double seconds); // TypeDefIndex: 90957; 0x00000001859B7730-0x00000001859B7740
	
		// Constructors
		public VideoPlayer(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Prepare(); // 0x000000018D6B8510-0x000000018D6B8544
		public void Play(); // 0x000000018D6B84DC-0x000000018D6B8510
		public void Pause(); // 0x000000018D6B84A8-0x000000018D6B84DC
		public void Stop(); // 0x000000018D6B86B8-0x000000018D6B86EC
		public void StepForward(); // 0x000000018D6B8684-0x000000018D6B86B8
		public string GetAudioLanguageCode(ushort trackIndex); // 0x000000018D6B8150-0x000000018D6B8194
		public ushort GetAudioChannelCount(ushort trackIndex); // 0x000000018D6B810C-0x000000018D6B8150
		public uint GetAudioSampleRate(ushort trackIndex); // 0x000000018D6B8194-0x000000018D6B81D8
		private ushort GetControlledAudioTrackCount(); // 0x000000018D6B81D8-0x000000018D6B820C
		private void SetControlledAudioTrackCount(ushort value); // 0x000000018D6B8544-0x000000018D6B8588
		public void EnableAudioTrack(ushort trackIndex, bool enabled); // 0x000000018D6B80B8-0x000000018D6B810C
		public bool IsAudioTrackEnabled(ushort trackIndex); // 0x000000018D6B8464-0x000000018D6B84A8
		public float GetDirectAudioVolume(ushort trackIndex); // 0x000000018D6B8250-0x000000018D6B8294
		public void SetDirectAudioVolume(ushort trackIndex, float volume); // 0x000000018D6B85DC-0x000000018D6B8630
		public bool GetDirectAudioMute(ushort trackIndex); // 0x000000018D6B820C-0x000000018D6B8250
		public void SetDirectAudioMute(ushort trackIndex, bool mute); // 0x000000018D6B8588-0x000000018D6B85DC
		[NativeHeader("Modules/Audio/Public/AudioSource.h")]
		public AudioSource GetTargetAudioSource(ushort trackIndex); // 0x000000018D6B8294-0x000000018D6B82D8
		public void SetTargetAudioSource(ushort trackIndex, AudioSource source); // 0x000000018D6B8630-0x000000018D6B8684
		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source); // 0x000000018D6B83D4-0x000000018D6B8404
		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx); // 0x000000018D6B8370-0x000000018D6B83A4
		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source); // 0x000000018D6B83A4-0x000000018D6B83D4
		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source); // 0x000000018D6B8434-0x000000018D6B8464
		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source); // 0x000000018D6B8340-0x000000018D6B8370
		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr); // 0x000000018D6B830C-0x000000018D6B8340
		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source); // 0x000000018D6B8404-0x000000018D6B8434
		[RequiredByNativeCode]
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds); // 0x000000018D6B82D8-0x000000018D6B830C
	}
}
