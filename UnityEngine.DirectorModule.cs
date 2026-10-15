/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 129: UnityEngine.DirectorModule.dll - Assembly: UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91194-91195

namespace UnityEngine.Playables
{
	[NativeHeader("Modules/Director/PlayableDirector.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[RequiredByNativeCode]
	public class PlayableDirector : UnityEngine.Behaviour, IExposedPropertyTable // TypeDefIndex: 91195
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> played; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> paused; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> stopped; // 0x28
	
		// Properties
		public PlayState state { get; } // 0x000000018D520B84-0x000000018D520B90 
		public DirectorWrapMode extrapolationMode { get; set; } // 0x000000018D520AC8-0x000000018D520AD4 0x000000018D520D9C-0x000000018D520DA4
		public PlayableAsset playableAsset { get; set; } // 0x000000018D520B14-0x000000018D520B58 0x000000018D520DF0-0x000000018D520DF8
		public PlayableGraph playableGraph { get; } // 0x000000018D520B58-0x000000018D520B84 
		public bool playOnAwake { get; set; } // 0x000000018D520B08-0x000000018D520B14 0x000000018D520DE8-0x000000018D520DF0
		public DirectorUpdateMode timeUpdateMode { get; set; } // 0x000000018D520B90-0x000000018D520BC4 0x000000018D520DF8-0x000000018D520E38
		public double time { get; set; } // 0x000000018D520BC4-0x000000018D520BF8 0x000000018D520E38-0x000000018D520E7C
		public double initialTime { get; set; } // 0x000000018D520AD4-0x000000018D520B08 0x000000018D520DA4-0x000000018D520DE8
		public double duration { get; } // 0x000000018D520A94-0x000000018D520AC8 
	
		// Events
		public event Action<PlayableDirector> played {
			add; // 0x000000018D52097C-0x000000018D520A08
			remove; // 0x000000018D520C84-0x000000018D520D10
		}
		public event Action<PlayableDirector> paused {
			add; // 0x000000018D5208F0-0x000000018D52097C
			remove; // 0x000000018D520BF8-0x000000018D520C84
		}
		public event Action<PlayableDirector> stopped {
			add; // 0x000000018D520A08-0x000000018D520A94
			remove; // 0x000000018D520D10-0x000000018D520D9C
		}
	
		// Constructors
		public PlayableDirector(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void DeferredEvaluate(); // 0x000000018D5200A0-0x000000018D5200A8
		internal void Play(FrameRate frameRate); // 0x000000018D52050C-0x000000018D520528
		public void Play(PlayableAsset asset); // 0x000000018D520528-0x000000018D5205EC
		public void Play(PlayableAsset asset, DirectorWrapMode mode); // 0x000000018D520430-0x000000018D52050C
		public void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value); // 0x000000018D52077C-0x000000018D520784
		[NativeThrows]
		public void Evaluate(); // 0x000000018D5200DC-0x000000018D520110
		[NativeThrows]
		private void PlayOnFrame(FrameRate frameRate); // 0x000000018D520414-0x000000018D520430
		[NativeThrows]
		public void Play(); // 0x000000018D5205EC-0x000000018D520620
		public void Stop(); // 0x000000018D5208BC-0x000000018D5208F0
		public void Pause(); // 0x000000018D52039C-0x000000018D5203D0
		public void Resume(); // 0x000000018D5206E8-0x000000018D52071C
		[NativeThrows]
		public void RebuildGraph(); // 0x000000018D520688-0x000000018D5206BC
		public void ClearReferenceValue(PropertyName id); // 0x000000018D520084-0x000000018D5200A0
		public void SetReferenceValue(PropertyName id, UnityEngine.Object value); // 0x000000018D520860-0x000000018D52087C
		public UnityEngine.Object GetReferenceValue(PropertyName id, out bool idValid); // 0x000000018D520280-0x000000018D52029C
		[NativeMethod("GetBindingFor")]
		public UnityEngine.Object GetGenericBinding(UnityEngine.Object key); // 0x000000018D520110-0x000000018D520154
		[NativeMethod("ClearBindingFor")]
		public void ClearGenericBinding(UnityEngine.Object key); // 0x000000018D51FFFC-0x000000018D520040
		[NativeThrows]
		public void RebindPlayableGraphOutputs(); // 0x000000018D520654-0x000000018D520688
		internal void ProcessPendingGraphChanges(); // 0x000000018D520620-0x000000018D520654
		[NativeMethod("HasBinding")]
		internal bool HasGenericBinding(UnityEngine.Object key); // 0x000000018D5202D0-0x000000018D520314
		private PlayState GetPlayState(); // 0x000000018D5201F8-0x000000018D52022C
		private void SetWrapMode(DirectorWrapMode mode); // 0x000000018D52087C-0x000000018D5208BC
		private DirectorWrapMode GetWrapMode(); // 0x000000018D52029C-0x000000018D5202D0
		[NativeThrows]
		private void EvaluateNextFrame(); // 0x000000018D5200A8-0x000000018D5200DC
		private PlayableGraph GetGraphHandle(); // 0x000000018D520198-0x000000018D5201C4
		private void SetPlayOnAwake(bool on); // 0x000000018D520784-0x000000018D5207C8
		private bool GetPlayOnAwake(); // 0x000000018D5201C4-0x000000018D5201F8
		[NativeThrows]
		private void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value); // 0x000000018D520348-0x000000018D52039C
		private void SetPlayableAsset(ScriptableObject asset); // 0x000000018D5207C8-0x000000018D52080C
		private ScriptableObject Internal_GetPlayableAsset(); // 0x000000018D520314-0x000000018D520348
		[NativeHeader("Runtime/Director/Core/DirectorManager.h")]
		[StaticAccessor("GetDirectorManager()", StaticAccessorType.Dot)]
		internal static void ResetFrameTiming(); // 0x000000018D5206BC-0x000000018D5206E8
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPlay(); // 0x000000018D52073C-0x000000018D52075C
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPause(); // 0x000000018D52071C-0x000000018D52073C
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorStop(); // 0x000000018D52075C-0x000000018D52077C
		private void PlayOnFrame_Injected(ref FrameRate frameRate); // 0x000000018D5203D0-0x000000018D520414
		private void ClearReferenceValue_Injected(ref PropertyName id); // 0x000000018D520040-0x000000018D520084
		private void SetReferenceValue_Injected(ref PropertyName id, UnityEngine.Object value); // 0x000000018D52080C-0x000000018D520860
		private UnityEngine.Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid); // 0x000000018D52022C-0x000000018D520280
		private void GetGraphHandle_Injected(out PlayableGraph ret); // 0x000000018D520154-0x000000018D520198
	}
}
