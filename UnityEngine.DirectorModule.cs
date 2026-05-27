/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 125: UnityEngine.DirectorModule.dll - Assembly: UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60012-60013

namespace UnityEngine.Playables
{
	[NativeHeader("Modules/Director/PlayableDirector.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[RequiredByNativeCode]
	public class PlayableDirector : UnityEngine.Behaviour, IExposedPropertyTable // TypeDefIndex: 60013
	{
		// Properties
		public PlayState state { get => default; } // 0x0000000189DF429C-0x0000000189DF42A8 
		public DirectorWrapMode extrapolationMode { get => default; set {} } // 0x0000000189DF41E0-0x0000000189DF41EC 0x0000000189DF44B4-0x0000000189DF44BC
		public PlayableAsset playableAsset { get => default; set {} } // 0x0000000189DF422C-0x0000000189DF4270 0x0000000189DF4508-0x0000000189DF4510
		public PlayableGraph playableGraph { get => default; } // 0x0000000189DF4270-0x0000000189DF429C 
		public bool playOnAwake { get => default; set {} } // 0x0000000189DF4220-0x0000000189DF422C 0x0000000189DF4500-0x0000000189DF4508
		public DirectorUpdateMode timeUpdateMode { get => default; set {} } // 0x0000000189DF42A8-0x0000000189DF42DC 0x0000000189DF4510-0x0000000189DF4550
		public double time { get => default; set {} } // 0x0000000189DF42DC-0x0000000189DF4310 0x0000000189DF4550-0x0000000189DF4594
		public double initialTime { get => default; set {} } // 0x0000000189DF41EC-0x0000000189DF4220 0x0000000189DF44BC-0x0000000189DF4500
		public double duration { get => default; } // 0x0000000189DF41AC-0x0000000189DF41E0 
	
		// Events
		public event Action<PlayableDirector> played;
		public event Action<PlayableDirector> paused;
		public event Action<PlayableDirector> stopped;
	
		// Constructors
		public PlayableDirector() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void DeferredEvaluate() {} // 0x0000000189DF37B8-0x0000000189DF37C0
		internal void Play(FrameRate frameRate) {} // 0x0000000189DF3C24-0x0000000189DF3C40
		public void Play(PlayableAsset asset) {} // 0x0000000189DF3C40-0x0000000189DF3D04
		public void Play(PlayableAsset asset, DirectorWrapMode mode) {} // 0x0000000189DF3B48-0x0000000189DF3C24
		public void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) {} // 0x0000000189DF3E94-0x0000000189DF3E9C
		[NativeThrows]
		public void Evaluate() {} // 0x0000000189DF37F4-0x0000000189DF3828
		[NativeThrows]
		private void PlayOnFrame(FrameRate frameRate) {} // 0x0000000189DF3B2C-0x0000000189DF3B48
		[NativeThrows]
		public void Play() {} // 0x0000000189DF3D04-0x0000000189DF3D38
		public void Stop() {} // 0x0000000189DF3FD4-0x0000000189DF4008
		public void Pause() {} // 0x0000000189DF3AB4-0x0000000189DF3AE8
		public void Resume() {} // 0x0000000189DF3E00-0x0000000189DF3E34
		[NativeThrows]
		public void RebuildGraph() {} // 0x0000000189DF3DA0-0x0000000189DF3DD4
		public void ClearReferenceValue(PropertyName id) {} // 0x0000000189DF379C-0x0000000189DF37B8
		public void SetReferenceValue(PropertyName id, UnityEngine.Object value) {} // 0x0000000189DF3F78-0x0000000189DF3F94
		public UnityEngine.Object GetReferenceValue(PropertyName id, out bool idValid) {
			idValid = default;
			return default;
		} // 0x0000000189DF3998-0x0000000189DF39B4
		[NativeMethod("GetBindingFor")]
		public UnityEngine.Object GetGenericBinding(UnityEngine.Object key) => default; // 0x0000000189DF3828-0x0000000189DF386C
		[NativeMethod("ClearBindingFor")]
		public void ClearGenericBinding(UnityEngine.Object key) {} // 0x0000000189DF3714-0x0000000189DF3758
		[NativeThrows]
		public void RebindPlayableGraphOutputs() {} // 0x0000000189DF3D6C-0x0000000189DF3DA0
		internal void ProcessPendingGraphChanges() {} // 0x0000000189DF3D38-0x0000000189DF3D6C
		[NativeMethod("HasBinding")]
		internal bool HasGenericBinding(UnityEngine.Object key) => default; // 0x0000000189DF39E8-0x0000000189DF3A2C
		private PlayState GetPlayState() => default; // 0x0000000189DF3910-0x0000000189DF3944
		private void SetWrapMode(DirectorWrapMode mode) {} // 0x0000000189DF3F94-0x0000000189DF3FD4
		private DirectorWrapMode GetWrapMode() => default; // 0x0000000189DF39B4-0x0000000189DF39E8
		[NativeThrows]
		private void EvaluateNextFrame() {} // 0x0000000189DF37C0-0x0000000189DF37F4
		private PlayableGraph GetGraphHandle() => default; // 0x0000000189DF38B0-0x0000000189DF38DC
		private void SetPlayOnAwake(bool on) {} // 0x0000000189DF3E9C-0x0000000189DF3EE0
		private bool GetPlayOnAwake() => default; // 0x0000000189DF38DC-0x0000000189DF3910
		[NativeThrows]
		private void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) {} // 0x0000000189DF3A60-0x0000000189DF3AB4
		private void SetPlayableAsset(ScriptableObject asset) {} // 0x0000000189DF3EE0-0x0000000189DF3F24
		private ScriptableObject Internal_GetPlayableAsset() => default; // 0x0000000189DF3A2C-0x0000000189DF3A60
		[NativeHeader("Runtime/Director/Core/DirectorManager.h")]
		[StaticAccessor("GetDirectorManager()", StaticAccessorType.Dot)]
		internal static void ResetFrameTiming() {} // 0x0000000189DF3DD4-0x0000000189DF3E00
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPlay() {} // 0x0000000189DF3E54-0x0000000189DF3E74
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPause() {} // 0x0000000189DF3E34-0x0000000189DF3E54
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorStop() {} // 0x0000000189DF3E74-0x0000000189DF3E94
		private void PlayOnFrame_Injected(ref FrameRate frameRate) {} // 0x0000000189DF3AE8-0x0000000189DF3B2C
		private void ClearReferenceValue_Injected(ref PropertyName id) {} // 0x0000000189DF3758-0x0000000189DF379C
		private void SetReferenceValue_Injected(ref PropertyName id, UnityEngine.Object value) {} // 0x0000000189DF3F24-0x0000000189DF3F78
		private UnityEngine.Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) {
			idValid = default;
			return default;
		} // 0x0000000189DF3944-0x0000000189DF3998
		private void GetGraphHandle_Injected(out PlayableGraph ret) {
			ret = default;
		} // 0x0000000189DF386C-0x0000000189DF38B0
	}
}
