/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 128: UnityEngine.DirectorModule.dll - Assembly: UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61117-61118

namespace UnityEngine.Playables
{
	public class PlayableDirector : UnityEngine.Behaviour, IExposedPropertyTable // TypeDefIndex: 61118
	{
		// Fields
		private Action<PlayableDirector> played; // 0x18
		private Action<PlayableDirector> paused; // 0x20
		private Action<PlayableDirector> stopped; // 0x28
	
		// Properties
		public PlayState state { get => default; } // 0x000000018BF0C04C-0x000000018BF0C058 
		public DirectorWrapMode extrapolationMode { get => default; set {} } // 0x000000018BF0BF90-0x000000018BF0BF9C 0x000000018BF0C264-0x000000018BF0C26C
		public PlayableAsset playableAsset { get => default; set {} } // 0x000000018BF0BFDC-0x000000018BF0C020 0x000000018BF0C2B8-0x000000018BF0C2C0
		public PlayableGraph playableGraph { get => default; } // 0x000000018BF0C020-0x000000018BF0C04C 
		public bool playOnAwake { get => default; set {} } // 0x000000018BF0BFD0-0x000000018BF0BFDC 0x000000018BF0C2B0-0x000000018BF0C2B8
		public DirectorUpdateMode timeUpdateMode { get => default; set {} } // 0x000000018BF0C058-0x000000018BF0C08C 0x000000018BF0C2C0-0x000000018BF0C300
		public double time { get => default; set {} } // 0x000000018BF0C08C-0x000000018BF0C0C0 0x000000018BF0C300-0x000000018BF0C344
		public double initialTime { get => default; set {} } // 0x000000018BF0BF9C-0x000000018BF0BFD0 0x000000018BF0C26C-0x000000018BF0C2B0
		public double duration { get => default; } // 0x000000018BF0BF5C-0x000000018BF0BF90 
	
		// Events
		public event Action<PlayableDirector> played;
		public event Action<PlayableDirector> paused;
		public event Action<PlayableDirector> stopped;
	
		// Constructors
		public PlayableDirector() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void DeferredEvaluate() {} // 0x000000018BF0B568-0x000000018BF0B570
		internal void Play(FrameRate frameRate) {} // 0x000000018BF0B9D4-0x000000018BF0B9F0
		public void Play(PlayableAsset asset) {} // 0x000000018BF0B9F0-0x000000018BF0BAB4
		public void Play(PlayableAsset asset, DirectorWrapMode mode) {} // 0x000000018BF0B8F8-0x000000018BF0B9D4
		public void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) {} // 0x000000018BF0BC44-0x000000018BF0BC4C
		public void Evaluate() {} // 0x000000018BF0B5A4-0x000000018BF0B5D8
		private void PlayOnFrame(FrameRate frameRate) {} // 0x000000018BF0B8DC-0x000000018BF0B8F8
		public void Play() {} // 0x000000018BF0BAB4-0x000000018BF0BAE8
		public void Stop() {} // 0x000000018BF0BD84-0x000000018BF0BDB8
		public void Pause() {} // 0x000000018BF0B864-0x000000018BF0B898
		public void Resume() {} // 0x000000018BF0BBB0-0x000000018BF0BBE4
		public void RebuildGraph() {} // 0x000000018BF0BB50-0x000000018BF0BB84
		public void ClearReferenceValue(PropertyName id) {} // 0x000000018BF0B54C-0x000000018BF0B568
		public void SetReferenceValue(PropertyName id, UnityEngine.Object value) {} // 0x000000018BF0BD28-0x000000018BF0BD44
		public UnityEngine.Object GetReferenceValue(PropertyName id, out bool idValid) {
			idValid = default;
			return default;
		} // 0x000000018BF0B748-0x000000018BF0B764
		public UnityEngine.Object GetGenericBinding(UnityEngine.Object key) => default; // 0x000000018BF0B5D8-0x000000018BF0B61C
		public void ClearGenericBinding(UnityEngine.Object key) {} // 0x000000018BF0B4C4-0x000000018BF0B508
		public void RebindPlayableGraphOutputs() {} // 0x000000018BF0BB1C-0x000000018BF0BB50
		internal void ProcessPendingGraphChanges() {} // 0x000000018BF0BAE8-0x000000018BF0BB1C
		internal bool HasGenericBinding(UnityEngine.Object key) => default; // 0x000000018BF0B798-0x000000018BF0B7DC
		private PlayState GetPlayState() => default; // 0x000000018BF0B6C0-0x000000018BF0B6F4
		private void SetWrapMode(DirectorWrapMode mode) {} // 0x000000018BF0BD44-0x000000018BF0BD84
		private DirectorWrapMode GetWrapMode() => default; // 0x000000018BF0B764-0x000000018BF0B798
		private void EvaluateNextFrame() {} // 0x000000018BF0B570-0x000000018BF0B5A4
		private PlayableGraph GetGraphHandle() => default; // 0x000000018BF0B660-0x000000018BF0B68C
		private void SetPlayOnAwake(bool on) {} // 0x000000018BF0BC4C-0x000000018BF0BC90
		private bool GetPlayOnAwake() => default; // 0x000000018BF0B68C-0x000000018BF0B6C0
		private void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) {} // 0x000000018BF0B810-0x000000018BF0B864
		private void SetPlayableAsset(ScriptableObject asset) {} // 0x000000018BF0BC90-0x000000018BF0BCD4
		private ScriptableObject Internal_GetPlayableAsset() => default; // 0x000000018BF0B7DC-0x000000018BF0B810
		internal static void ResetFrameTiming() {} // 0x000000018BF0BB84-0x000000018BF0BBB0
		private void SendOnPlayableDirectorPlay() {} // 0x000000018BF0BC04-0x000000018BF0BC24
		private void SendOnPlayableDirectorPause() {} // 0x000000018BF0BBE4-0x000000018BF0BC04
		private void SendOnPlayableDirectorStop() {} // 0x000000018BF0BC24-0x000000018BF0BC44
		private void PlayOnFrame_Injected(ref FrameRate frameRate) {} // 0x000000018BF0B898-0x000000018BF0B8DC
		private void ClearReferenceValue_Injected(ref PropertyName id) {} // 0x000000018BF0B508-0x000000018BF0B54C
		private void SetReferenceValue_Injected(ref PropertyName id, UnityEngine.Object value) {} // 0x000000018BF0BCD4-0x000000018BF0BD28
		private UnityEngine.Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) {
			idValid = default;
			return default;
		} // 0x000000018BF0B6F4-0x000000018BF0B748
		private void GetGraphHandle_Injected(out PlayableGraph ret) {
			ret = default;
		} // 0x000000018BF0B61C-0x000000018BF0B660
	}
}
