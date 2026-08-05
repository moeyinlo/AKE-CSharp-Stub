/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Rewired;
using Rewired.Config;
using Rewired.ControllerExtensions;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.HID.Drivers;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Internal.Localization;
using Rewired.Libraries.SharpDX.DirectInput;
using Rewired.Libraries.SharpDX.RawInput;
using Rewired.Libraries.SharpDX.Windows.Forms;
using Rewired.Libraries.SharpDX.XInput;
using Rewired.Platforms;
using Rewired.Platforms.Microsoft.WindowsGamingInput;
using Rewired.Platforms.Windows.RawInput;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 20: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53583-54040
[assembly: AssemblyCompany("Guavaman Enterprises")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("Copyright \u00A9  2014 Augie R. Maddox. All rights reserved.")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("Rewired")]
[assembly: AssemblyTitle("Rewired Windows")]
[assembly: AssemblyTrademark("Augie R. Maddox")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("a41ebc23-ec97-4fd2-81ae-f39afc75854a")]
[assembly: NeutralResourcesLanguage("en-us")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class dyJcqkkCOKdlMMAdfeedYNMzbGXXA // TypeDefIndex: 53584
{
	// Fields
	private static int sFHzEXczlQftnxMyKDbAEQUqaEru; // 0x00
	private static Rewired.Utils.Classes.Utility.ThreadHelper fbyQdfhoVDBkrVXdMFafkxyYHqBP; // 0x08
	private static Rewired.Utils.Classes.Utility.ThreadHelper NBDOUCIIoivGAysRGEjIQKudSxbs; // 0x10

	// Properties
	public static int aYBDnbKBUwDPQhvmrEtmsCcZckGhA { get; } // 0x000000018AB84B20-0x000000018AB84B58 
	public static Rewired.Utils.Classes.Utility.ThreadHelper cTxRcNWsabfeQbArXKTRMnXgyGOH { get; } // 0x000000018AB84AE8-0x000000018AB84B20 
	public static Rewired.Utils.Classes.Utility.ThreadHelper TPitKbsNfKADGeLlzNukKPValncl { get; } // 0x000000018AB84B58-0x000000018AB84B90 

	// Methods
	public static void DKVpNyqREOIVACgmSVaaAXYjPvP(bool param_000733a0); // 0x0000000183B258B0-0x0000000183B25A70
	private static void dVKAHzfNnsDImjkdkSOKGbRvTaBzA(UpdateLoopType param_000733a1); // 0x000000018381BE70-0x000000018381BED0
	public static void SbYVTdmkPElTDzeOGdijEuqHpCge(); // 0x000000018AB84B90-0x000000018AB84CF8
}

internal sealed class xPfnLVIvrLrDqEyvvAFdcLgWKpGQ : IElementIdentifierTool // TypeDefIndex: 53585
{
	// Fields
	private GUIText uRpgQQxkIcZfgCnnzeNmUzeYStDl; // 0x10
	private string UApmUXqeSElPgXfxaWmqRIRJhpmm; // 0x18
	private int NuvDUxhiReiWpQidTMIMeRlKnCTyA; // 0x20
	private nmDUaUhbthOlhiDQJeKfGxYxeylPA kpvPZlvxDyNXZmTPjGIpIycLmSaf; // 0x28
	private uiNBFFkTpfqYYBjzPgxoiyKQNigQA MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x30
	private Guid mvJBXmGLjyExEGIRDhFMNBMXeMQMB; // 0x38
	private IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> ELGeYAhrkslrsSSggpFWqeRBkDBG; // 0x48
	private IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> OrRIvEumYtLTRVJxJHzhTCEhdUIM; // 0x50
	private bool ORfUiVhuzgVzGwqnDPsnCenctVEf; // 0x58
	private bool IaQHDpIxSWlVSdWAcfzpAkQjcwTzA; // 0x59
	private bool fyCxlxBEVJlODwuYMTYcozPWUXtt; // 0x5A
	private int AaJFntfPrronxQZBQcKjCzFJNhheb; // 0x5C
	private TimerRealTime SbbJtQJZzisMWHKxmkfcVZWdUHGH; // 0x60

	// Constructors
	public xPfnLVIvrLrDqEyvvAFdcLgWKpGQ(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void Initialize(GUIText text); // 0x00000001853908C0-0x00000001853908D0
	public void Start(); // 0x000000018AB8883C-0x000000018AB88AA4
	public void Update(); // 0x000000018AB88AA4-0x000000018AB89F80
	private void aWaeGTWYwaFywDnKiBtMWOmRrRnH(); // 0x000000018AB8A084-0x000000018AB8A128
	private void GSrquDvozUzyEGPNfYYEmeMOjkZC(); // 0x000000018AB8880C-0x000000018AB88828
	private void WoKfjAhvbFeccwjyTNFktBBccyQd(); // 0x000000018AB8880C-0x000000018AB88828
	private void EwkcAaHOpQOleCWgbsCvmKHkjzAoA(); // 0x000000018AB8880C-0x000000018AB88828
	private void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB8A128-0x000000018AB8A1A0
	private void XEajjyPDjlIbYMTFoxxgPNPwjNmf(string param_000733a3, object param_000733a4); // 0x000000018AB89F80-0x000000018AB8A084
	private int DYxtgWHqYudqjBhVQJKzjymElHwy(DirectInputAxis param_000733a5, GPkbBxELmYMSjUedRXbWrnFhNjKFb param_000733a6); // 0x000000018AB884BC-0x000000018AB8880C
	private float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_000733a7); // 0x000000018AB7AE68-0x000000018AB7AECC
	public void OnDestroy(); // 0x000000018AB88828-0x000000018AB8883C
}

internal sealed class BzHDsnGnVFDdDBcIlNNKFiBXbjzHb : IElementIdentifierTool // TypeDefIndex: 53586
{
	// Fields
	private GUIText uRpgQQxkIcZfgCnnzeNmUzeYStDl; // 0x10
	private string UApmUXqeSElPgXfxaWmqRIRJhpmm; // 0x18
	private int NuvDUxhiReiWpQidTMIMeRlKnCTyA; // 0x20
	private szduZeeDEtcYluGujxaTriOejwKbA pDKjIIcjIQpnIgOLIQVlwxtaMtSbA; // 0x28
	private xLiBDACQHMkUJDONyqwWiGgepFzkA MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x30
	private Guid mvJBXmGLjyExEGIRDhFMNBMXeMQMB; // 0x38
	private IList<xLiBDACQHMkUJDONyqwWiGgepFzkA> ELGeYAhrkslrsSSggpFWqeRBkDBG; // 0x48
	private bool ORfUiVhuzgVzGwqnDPsnCenctVEf; // 0x50
	private bool IaQHDpIxSWlVSdWAcfzpAkQjcwTzA; // 0x51
	private bool fyCxlxBEVJlODwuYMTYcozPWUXtt; // 0x52
	private string[] ZtFfmEzDzZQMzpAxrzeWhNodHVgI; // 0x58
	private int[] idtBmUHjFaBXkGQyOoBfYzCXBJkX; // 0x60

	// Constructors
	public BzHDsnGnVFDdDBcIlNNKFiBXbjzHb(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void Initialize(GUIText text); // 0x000000018AB78B38-0x000000018AB78C28
	public void Start(); // 0x000000018AB78D40-0x000000018AB78F54
	public void Update(); // 0x000000018AB78F54-0x000000018AB7ACA8
	public void OnDestroy(); // 0x000000018AB78D2C-0x000000018AB78D40
	private void aWaeGTWYwaFywDnKiBtMWOmRrRnH(); // 0x000000018AB7ADAC-0x000000018AB7AE00
	private void GSrquDvozUzyEGPNfYYEmeMOjkZC(); // 0x000000018AB78B1C-0x000000018AB78B38
	private void WoKfjAhvbFeccwjyTNFktBBccyQd(); // 0x000000018AB78B1C-0x000000018AB78B38
	private void EwkcAaHOpQOleCWgbsCvmKHkjzAoA(); // 0x000000018AB78B1C-0x000000018AB78B38
	private void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB7AE00-0x000000018AB7AE68
	private void XEajjyPDjlIbYMTFoxxgPNPwjNmf(string param_000733a9, object param_000733aa); // 0x000000018AB7ACA8-0x000000018AB7ADAC
	private void LaLijTZWRWsoVIMAprAIkNSApaPx(string param_000733ab, object param_000733ac); // 0x000000018AB78C28-0x000000018AB78D2C
	private int DYxtgWHqYudqjBhVQJKzjymElHwy(RawInputAxis param_000733ad, int param_000733ae, MlriOiaGsGcNChpISALUGlIRPxwK param_000733af); // 0x000000018AB78AF8-0x000000018AB78B1C
	private float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_000733b0); // 0x000000018AB7AE68-0x000000018AB7AECC
}

internal class sSeXfAxAAxiXLAtqyIfJrJTcdaQh : IDisposable // TypeDefIndex: 53592
{
	// Fields
	private readonly List<OzOCKacbuZbJtdiFDEBKjZTEEESIc> BfBuWWbeLNGmHCRVgPnYcSPcYaFfB; // 0x10
	private readonly ReadOnlyCollection<OzOCKacbuZbJtdiFDEBKjZTEEESIc> BUiFxpDbqgzGYVofHMMBJQSjIEqNA; // 0x18
	private readonly List<xTONizpynmfsfmMGjoZKtugyxXqB> HrryNfxLEdSgcggRaMcZakXiCPwN; // 0x20
	private readonly Func<int> jbHaACMRFuHVwpuOhXSMPMzmndhA; // 0x28
	private readonly Rewired.Utils.Classes.Utility.SpinLock jVKhafVxDVBmCideiKSBvCWXBVkN; // 0x30
	private readonly Rewired.Utils.Classes.Utility.SpinLock MVJwniOvJHoBJBphXjlHbarMpTld; // 0x38
	private RingBuffer<WNPovYgfKDJLlaUCUcqWKPslkcSM> BmKUNrIYvUcPKwlwRBNZbqvPvrjtA; // 0x40
	private RingBuffer<sSmmaYETUaIRsQptpKzWiDLxIFPZ> UvOhQyEWVvSAuIdbAvMmMaoYOHyd; // 0x48
	private bool MVWxwypMDvEYkFBvplbulXuOOUmU; // 0x50
	private readonly ThreadSafeObjectPool<WNPovYgfKDJLlaUCUcqWKPslkcSM> GvuEeGiuYHoyxFGQuEgXITkCSJAq; // 0x58
	private readonly ThreadSafeObjectPool<sSmmaYETUaIRsQptpKzWiDLxIFPZ> FqZCSxAKDEybgBTWGUgQUzuceOWi; // 0x60
	private readonly List<OzOCKacbuZbJtdiFDEBKjZTEEESIc> pGHffLwbPXCvshrQWSHbOazJdShZ; // 0x68
	private RingBuffer<WNPovYgfKDJLlaUCUcqWKPslkcSM> hKZomecyRIZXJWGynHvDjpqbcoxZ; // 0x70
	private RingBuffer<sSmmaYETUaIRsQptpKzWiDLxIFPZ> aQyGuvJgkpxJDVrQBRJfkFPQZSgw; // 0x78
	private bool sWfXftcBabupQUjJJRjthhWXefuV; // 0x80
	private Action<xTONizpynmfsfmMGjoZKtugyxXqB, JaQnnRxPcWCJXAnpNCxpObeGFfZ> aqNhubqMWhfhobejovwiNlKLvMJC; // 0x88
	[CompilerGenerated]
	private Action FMRGOqcWNMqVYKduzIJTfcfHoEhTb; // 0x90
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x98
	private static Guid[] bupIlNEGJTKaYaSGNTEfbZTiGWCe; // 0x00
	private static string[] NAfFaCkqvNBIXjXJFawGsBzNaMmCc; // 0x08
	private static string[] POfIjhtjyMJcYPXICDfirWYSjqMJ; // 0x10

	// Events
	public event Action FMRGOqcWNMqVYKduzIJTfcfHoEhTb {
		add; // 0x000000018AB85DF8-0x000000018AB85E90
		remove; // 0x000000018AB86AA4-0x000000018AB86B3C
	}

	// Nested types
	private abstract class tlUQiPQblRXSDPZRekgoAcezDjtcA : IPoolableObject_Internal // TypeDefIndex: 53588
	{
		// Fields
		[CompilerGenerated]
		private IObjectPool vWbRXonvaOawNZrwYLpzdBGtsepG; // 0x10

		// Properties
		IObjectPool IPoolableObject_Internal.pool { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0

		// Constructors
		protected tlUQiPQblRXSDPZRekgoAcezDjtcA(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		protected abstract void Clear();
		void IPoolableObject_Internal.Clear(); // 0x00000001873629EC-0x00000001873629FC
		void IDisposable.Dispose(); // 0x000000018AB882AC-0x000000018AB882B4
		public void Return(); // 0x000000018AB88254-0x000000018AB882AC
	}

	private class WNPovYgfKDJLlaUCUcqWKPslkcSM : tlUQiPQblRXSDPZRekgoAcezDjtcA // TypeDefIndex: 53589
	{
		// Fields
		public xTONizpynmfsfmMGjoZKtugyxXqB aGZTLRceVCiwjwmKKFfUanjFlXyt; // 0x18
		public CbTgNHFFAIhPqyQzSkOQWxDxpAFbA OrrEbEAztAtFvOLJBCkSnoSKrvnP; // 0x20
		public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x60

		// Constructors
		public WNPovYgfKDJLlaUCUcqWKPslkcSM(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		protected override void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB7DDD8-0x000000018AB7DE10
	}

	private sealed class sSmmaYETUaIRsQptpKzWiDLxIFPZ : tlUQiPQblRXSDPZRekgoAcezDjtcA // TypeDefIndex: 53590
	{
		// Fields
		public xTONizpynmfsfmMGjoZKtugyxXqB aGZTLRceVCiwjwmKKFfUanjFlXyt; // 0x18
		public JaQnnRxPcWCJXAnpNCxpObeGFfZ AQwStVeKIwCRGaZPubvpRItBKTIFb; // 0x20

		// Constructors
		public sSmmaYETUaIRsQptpKzWiDLxIFPZ(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		protected override void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB88228-0x000000018AB88254
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class pMpGBKygEUozxUxcDyDCCdxUCKK // TypeDefIndex: 53591
	{
		// Fields
		public static readonly pMpGBKygEUozxUxcDyDCCdxUCKK __9; // 0x00
		public static Func<WNPovYgfKDJLlaUCUcqWKPslkcSM> __9__19_0; // 0x08
		public static Func<sSmmaYETUaIRsQptpKzWiDLxIFPZ> __9__19_1; // 0x10

		// Constructors
		static pMpGBKygEUozxUxcDyDCCdxUCKK(); // 0x000000018AB85C1C-0x000000018AB85C80
		public pMpGBKygEUozxUxcDyDCCdxUCKK(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal WNPovYgfKDJLlaUCUcqWKPslkcSM eLhwaxiGDsDKYbyavaQkgMImIsXfb(); // 0x000000018AB85C80-0x000000018AB85CBC
		internal sSmmaYETUaIRsQptpKzWiDLxIFPZ wHWMpONJdiaELGltwoClaVawGGEOA(); // 0x000000018AB85CBC-0x000000018AB85CF8
	}

	// Constructors
	public sSeXfAxAAxiXLAtqyIfJrJTcdaQh(Func<int> param_000733b5); // 0x000000018AB86D44-0x000000018AB874DC
	static sSeXfAxAAxiXLAtqyIfJrJTcdaQh(); // 0x000000018AB86BB0-0x000000018AB86D44

	// Methods
	public void TSexxBoQJJrDUHjAVGegZXOfrqTg(); // 0x000000018AB869BC-0x000000018AB86AA4
	public void lMJJIQInRrgXAznDPfJphjvZbHZmA(); // 0x000000018AB87F24-0x000000018AB88128
	private void dIynDsLKbxaDRBsYLuwSquvHCLOcA(xTONizpynmfsfmMGjoZKtugyxXqB param_000733b6, JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733b7); // 0x000000018AB87D90-0x000000018AB87F24
	public IList<OzOCKacbuZbJtdiFDEBKjZTEEESIc> enWrmPEeSZfdoBIXgaeNFsgyFeVm(); // 0x000000018385B100-0x000000018385B110
	private void coQJkvlkhzIzrgfqiMgtGMvUOoYQA(); // 0x000000018AB877C8-0x000000018AB87D90
	private void BSBbCkZloeHSdffjvjzejfeNNIchb(bool param_000733b8); // 0x000000018AB85CF8-0x000000018AB85DF8
	private void yonePGyMPqkUCoaTVtNEWneSYdiQ(bool param_000733b9); // 0x000000018AB88128-0x000000018AB88228
	private void OEUiepMJOLOxlvyKFlBdMfSwBByE(); // 0x000000018AB85F38-0x000000018AB86198
	private void bQByUaaPbcTUdwegxMgjeATLizYD(); // 0x000000018AB875B4-0x000000018AB877C8
	private void RFZFqrCkqbaEfgIYkBuPofcBTYuob(xTONizpynmfsfmMGjoZKtugyxXqB param_000733ba); // 0x000000018AB863B8-0x000000018AB86490
	private void bGKzDUzVMfBNXFzlSlKPkVqBxzWB(xTONizpynmfsfmMGjoZKtugyxXqB param_000733bb); // 0x000000018AB874DC-0x000000018AB875B4
	public void Dispose(); // 0x000000018AB85E90-0x000000018AB85EE0
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB86B3C-0x000000018AB86BB0
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000733bc); // 0x000000018AB86490-0x000000018AB869BC
	private static bool JbHKGHuKYWuEknRHVEICrXICEbMR(IList<xTONizpynmfsfmMGjoZKtugyxXqB> param_000733bd, xTONizpynmfsfmMGjoZKtugyxXqB param_000733be); // 0x000000018AB85EE0-0x000000018AB85F38
	private static int PAAHqPJeiyimprjSbjbBBdnBTcrPA(IList<OzOCKacbuZbJtdiFDEBKjZTEEESIc> param_000733bf, xTONizpynmfsfmMGjoZKtugyxXqB param_000733c0); // 0x000000018AB862B4-0x000000018AB863B8
	private static int PAAHqPJeiyimprjSbjbBBdnBTcrPA(IList<xTONizpynmfsfmMGjoZKtugyxXqB> param_000733c1, xTONizpynmfsfmMGjoZKtugyxXqB param_000733c2); // 0x000000018AB86198-0x000000018AB862B4
}

internal interface eNfvpwLBlcLZrDwMSAAKYmquIOpc : IDisposable // TypeDefIndex: 53593
{
	// Properties
	InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; }
	int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; }
	string cJMYRUIePewENzlebCoKsxxPfeZBA { get; }
	Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; }
	PidVid eabRFvqklxoYMJPbeMmtEYziJBbB { get; }
	ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX { get; }
	ushort NDweLaWskzoBwpWJxCWuzQStzdYi { get; }
	Guid aNgaHbYRnoeDOKekCLvIxDjDiTpgA { get; }
	int iNOQjioNbBRxJPHSCBvgxibcstpi { get; }
	int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; }
	int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; }
	int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; }
	bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; }
	WGIDeviceType FeydSgDjtypCTgePURUdNlOclvVRA { get; }
	bool DMJqTpZTwOTOujCqZfgHNmEThhfJ { get; }
	Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; }

	// Methods
	void SetVibration(int motorIndex, float amount, bool stopOtherMotors);
	void StopVibration();
	bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(int param_000733c7);
	float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_000733c8);
	int ImLuWROnVBPkqNCjYBWRnhyTStaH(int param_000733c9);
	void pklLTaWbvSXZvwSHNrAPLnwqJXoO(eNfvpwLBlcLZrDwMSAAKYmquIOpc param_000733ca);
	void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_000733cb);
	void rtVwRpwCmfbNsKOJOmhtvzHenwRDA();
}

internal static class QCXAdrYeoiIaDhgwJbqhSbdCgmWt // TypeDefIndex: 53596
{
	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void qsUaWnaOTfbdEUpSLXGSWhXhItCBb(plwsmfqnWbhsWAUbGQRUXipBtMde pGamepad); // TypeDefIndex: 53594; 0x0000000182B46B90-0x0000000182B46BA0

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void CZdmTuZTZgzBZpuotKhclUJfgIwC(plwsmfqnWbhsWAUbGQRUXipBtMde pGamepad); // TypeDefIndex: 53595; 0x0000000182B46B90-0x0000000182B46BA0

	// Methods
	private static extern ulong qkUPVdQQExZbWbEYNmjfACrvbnXz(IntPtr param_000733cc); // 0x000000018AB7C38C-0x000000018AB7C404
	public static ulong zVyBDEPNlVrPxMoiPzqJVBogWCAM(IntPtr param_000733cd); // 0x000000018AB7C6D4-0x000000018AB7C6F0
	private static extern ulong uaSTyiwEMlIHazMOrNJkvxRkNmTi(IntPtr param_000733ce); // 0x000000018AB7C65C-0x000000018AB7C6D4
	public static ulong oLfxZkFoUcIjeZOZhfdxCtCvClvrA(IntPtr param_000733cf); // 0x000000018AB7C370-0x000000018AB7C38C
	public static extern bool ZcoVpvzMmLZOXNtbUxpkmmBvPHAj(); // 0x000000018AB7BE7C-0x000000018AB7BEE8
	private static extern IntPtr fUTOWpASUlmIZfPOrLwGKlaEabJt(); // 0x000000018AB7BFA8-0x000000018AB7C010
	public static string gheqiqOXVVurAdelNkYSKsLZQcDS(); // 0x000000018AB7C010-0x000000018AB7C060
	public static extern plwsmfqnWbhsWAUbGQRUXipBtMde LyNXuymqchfyMHbKPzhLkknAoUWx(); // 0x000000018AB7BC74-0x000000018AB7BCDC
	public static extern uint qsrppLnMrChUNpkbhdzwxIRUJVnP(IntPtr param_000733d0); // 0x000000018AB7C404-0x000000018AB7C47C
	public static extern plwsmfqnWbhsWAUbGQRUXipBtMde huhWIPmoKUnKxSCiTFuuGcWdmZmk(IntPtr param_000733d1, uint param_000733d2); // 0x000000018AB7C060-0x000000018AB7C0E0
	public static extern bool uXpuWnjdHQCYXLhWEMwLNkcpTpxo(IntPtr param_000733d3, ref CbTgNHFFAIhPqyQzSkOQWxDxpAFbA param_000733d4); // 0x000000018AB7C5D4-0x000000018AB7C65C
	public static extern void kWjhLkyGSxCKpwDimnssiEzdRkIT(IntPtr param_000733d5, in JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733d6); // 0x000000018AB7C138-0x000000018AB7C1D0
	public static extern void dseGZnliktiAdJiOKkxIOcEybndR(); // 0x000000018AB7BEE8-0x000000018AB7BF50
	public static extern void tUhxtCBYhzDOtrHKdgrSwNqCzlPT(); // 0x000000018AB7C56C-0x000000018AB7C5D4
	public static extern void kkZATgLfdNebsKxcLBkQYdlorzab(qsUaWnaOTfbdEUpSLXGSWhXhItCBb param_000733d7); // 0x000000018AB7C1D0-0x000000018AB7C24C
	public static extern void PpncbbCxciIJxHCaLCMjNFmKoLBib(CZdmTuZTZgzBZpuotKhclUJfgIwC param_000733d8); // 0x000000018AB7BCDC-0x000000018AB7BD58
	public static extern bool szphOnhBCjCdPAoaDJMgUUdxmxhKA(IntPtr param_000733d9); // 0x000000018AB7C4F4-0x000000018AB7C56C
	public static extern int WQFZqACcRmytIipdBRjINQQokWpV(IntPtr param_000733da); // 0x000000018AB7BDD0-0x000000018AB7BE04
	public static extern int ncisDyYFVfqABdYykBDZRMxvlSHL(IntPtr param_000733db); // 0x000000018AB7C33C-0x000000018AB7C370
	public static extern int DEIbNKSfsDIFmsLQfviRFkztfHXFA(IntPtr param_000733dc); // 0x000000018AB7BBFC-0x000000018AB7BC74
	private static extern IntPtr mLsPElIYekXWgJQBUMLsohGoyPpE(IntPtr param_000733dd); // 0x000000018AB7C2C4-0x000000018AB7C33C
	public static string idoTBwRHsKhntLELrqfVFIKuPuCb(IntPtr param_000733de); // 0x000000018AB7C0E0-0x000000018AB7C138
	public static extern ushort swjEKOjObbkSbcAfGpfhnnreJMqc(IntPtr param_000733df); // 0x000000018AB7C47C-0x000000018AB7C4F4
	public static extern ushort SJSYQsUTxrniSctldepXhvrdflSn(IntPtr param_000733e0); // 0x000000018AB7BD58-0x000000018AB7BDD0
	public static extern IntPtr lwtqpwrkNbcQMsopmoVFccrRtckk(IntPtr param_000733e1); // 0x000000018AB7C24C-0x000000018AB7C2C4
	public static string etZTYmFKTSxHhYhhhenHhTZwsBRn(IntPtr param_000733e2); // 0x000000018AB7BF50-0x000000018AB7BFA8
	public static extern plwsmfqnWbhsWAUbGQRUXipBtMde YjQrHwSlNxhlikZFFweYqeVtxpIM(IntPtr param_000733e3); // 0x000000018AB7BE04-0x000000018AB7BE7C
}

internal struct plwsmfqnWbhsWAUbGQRUXipBtMde // TypeDefIndex: 53597
{
	// Fields
	private IntPtr LhxRtdKyhADHwatXDTXvylxWqMgT; // 0x00

	// Properties
	public IntPtr ttbSJgeKdiAPRlyxoAEMHoJrTGyI { get; } // 0x0000000182B76770-0x0000000182B76780 
	public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x00000001830CFC40-0x00000001830CFC50 
}

internal struct YWCaxKCjNDTdBLTDZNSJtTHiIMnk : IEquatable<YWCaxKCjNDTdBLTDZNSJtTHiIMnk> // TypeDefIndex: 53598
{
	// Fields
	public IntPtr FNMJsIYcymsJuahkrckLTjpCWbrd; // 0x00

	// Properties
	public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x00000001830CFC40-0x00000001830CFC50 

	// Constructors
	public YWCaxKCjNDTdBLTDZNSJtTHiIMnk(plwsmfqnWbhsWAUbGQRUXipBtMde param_000733ea); // 0x0000000184D88B60-0x0000000184D88B70

	// Methods
	public void IYsALPEzKUpSHjMlchBUFTjZCkvr(); // 0x000000018AB8141C-0x000000018AB81444
	public static IntPtr APoRgahkkqCivzZqzQUvGNyXvZFi(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_000733eb); // 0x000000018464E630-0x000000018464E640
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_000733ec); // 0x000000018AB81444-0x000000018AB814A4
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x000000018AB813CC-0x000000018AB8141C
	public bool Equals(YWCaxKCjNDTdBLTDZNSJtTHiIMnk other); // 0x0000000182EECF30-0x0000000182EECF40
	public static bool pqIWMXtLRfrLeVQnvBQsHmpvyOwL(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_000733ee, YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_000733ef); // 0x0000000182FB1840-0x0000000182FB1850
}

internal sealed class OzOCKacbuZbJtdiFDEBKjZTEEESIc : kRyYZXvVecLRzJlIrixXarXRkjAGb // TypeDefIndex: 53600
{
	// Fields
	private xTONizpynmfsfmMGjoZKtugyxXqB XClabGCGqUysxygjhfOJzpCkkKck; // 0x90
	private JaQnnRxPcWCJXAnpNCxpObeGFfZ TqvNeRPIitbALvtJvKZyMyYfPvwD; // 0x98
	private JaQnnRxPcWCJXAnpNCxpObeGFfZ okpHnkuDeSKwJGXhVGObUiXitLiW; // 0xB8
	private double TSGBHOQBvMgJnlBXuAcqgiJSnqEnA; // 0xD8
	private bool FiFwBmFckWVjHRKGiOMNpQDBTbOq; // 0xE0
	private double ZgePPxEfkpqxAQJJnYnPLhuzVLeF; // 0xE8
	private Action<xTONizpynmfsfmMGjoZKtugyxXqB, JaQnnRxPcWCJXAnpNCxpObeGFfZ> uwdWwYXIIhEOCUzfdDhFBNTaFKMQ; // 0xF0

	// Properties
	public xTONizpynmfsfmMGjoZKtugyxXqB aGZTLRceVCiwjwmKKFfUanjFlXyt { get; } // 0x0000000184D86220-0x0000000184D86230 
	public override bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	public override int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; } // 0x0000000184D882B0-0x0000000184D882C0 

	// Constructors
	public OzOCKacbuZbJtdiFDEBKjZTEEESIc(xTONizpynmfsfmMGjoZKtugyxXqB param_000733f0, int param_000733f1, Action<xTONizpynmfsfmMGjoZKtugyxXqB, JaQnnRxPcWCJXAnpNCxpObeGFfZ> param_000733f2); // 0x000000018AB7B908-0x000000018AB7BA80

	// Methods
	public void EtIibDtUhxvFOcDQBfvZunDPNman(CbTgNHFFAIhPqyQzSkOQWxDxpAFbA param_000733f3, double param_000733f4); // 0x000000018AB7B380-0x000000018AB7B6C0
	public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_000733f5); // 0x000000018AB7B874-0x000000018AB7B894
	public override void pklLTaWbvSXZvwSHNrAPLnwqJXoO(eNfvpwLBlcLZrDwMSAAKYmquIOpc param_000733f6); // 0x000000018AB7BB78-0x000000018AB7BBE8
	public override void hJVWdluocTccqfVOELDXAeXkkPPlA(int param_000733f7, float param_000733f8, bool param_000733f9); // 0x000000018AB7BAD0-0x000000018AB7BB78
	public override void eEnRZrPQkNXhsmIjYHcmHsAiBpVj(); // 0x000000018AB7BAA8-0x000000018AB7BAD0
	private void cbJpAWKVtCgvFtIikgPssDjoPxht(); // 0x000000018AB7BA80-0x000000018AB7BAA8
	private void NIxaCWDZMjMBnhrHHfjBzuFxLWeLA(); // 0x000000018AB7B6C0-0x000000018AB7B73C
	private void xTimvBZRWJdKfVfeeBPYgxOlHdGq(bool param_000733fa); // 0x000000018AB7BBE8-0x000000018AB7BBFC
	private void ZozcRgeaVRNMRbRTPKeaqXlAkzSX(); // 0x000000018AB7B894-0x000000018AB7B908
	private void DXtdzhBNMxMaGgNIIiPTFzyyqagoA(); // 0x000000018AB7B288-0x000000018AB7B380
	private bool QTMlFBnealhycdDsWHhlspySoJlU(ref JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733fb); // 0x000000018AB7B73C-0x000000018AB7B770
	private void nqabqRtHrrvynCNJypHmNKlllcLr(ref JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733fc); // 0x0000000184DA86C0-0x0000000184DA86E0
	private void jGJVOJHrAZNeacGSrLEXlKVmALZ(ref JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733fd, ref JaQnnRxPcWCJXAnpNCxpObeGFfZ param_000733fe); // 0x0000000184DA86A0-0x0000000184DA86C0
	protected override bool SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000733ff); // 0x000000018AB7B770-0x000000018AB7B874
}

internal class ZvFOVHtMPPFSKMXvcEpBjwvCmYwe : PlatformInputManager // TypeDefIndex: 53606
{
	// Fields
	private QxTmNwfleGAUlOPloekweCICSBLE wxrsQxIdcVBTqAgHMwBTcqMmdEUOA; // 0x38
	private List<dNsssvxJNFrLApzRfgonqfmlEPBbA> TNqgWuvjBCYgOVCSnGXROLahYyaS; // 0x40
	private int MKTmWllStazkhRAJmTOHnpRlzbHA; // 0x48
	private VOIUdgfvFOcBkklESphisBeETZCF zEXAytyyWNitcOcjHagycmLbyfNAA; // 0x50
	private bool LUerFwlJOhrXLmPefbEuBAAwOpgL; // 0x58
	private ConfigVars citmFSzSlOHbAffiLPaeVitsTcNL; // 0x60
	private Action<int, ControllerDataUpdater> TbbDUoAqMmrcaEjeayEMKHtJzKLe; // 0x68
	private PlatformInputManager DeuaCkgWrfMxvbuXImykIcuYIdCrA; // 0x70
	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rqAjfzaDytOqusVpXrJowWQXlELt; // 0x78
	private readonly Func<int> kSPXKdIyXsnUpjQGNfNppmWhLHBd; // 0x80
	private Func<PidVid, bool> EghWguErCSSlckfDqyUkzauWdIqGA; // 0x88

	// Properties
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x0000000184DA77E0-0x0000000184DA77F0 
	protected QxTmNwfleGAUlOPloekweCICSBLE lWfJISnECaZrRWGEYyVbdMtABwBdA { get; } // 0x0000000184D85A50-0x0000000184D85A60 

	// Nested types
	private class dNsssvxJNFrLApzRfgonqfmlEPBbA : IDisposable, IInputManagerJoystick // TypeDefIndex: 53601
	{
		// Fields
		private int SAwUWSkGKioQPDUaFBSUbXjjqYIM; // 0x10
		private int JPJrLcYgPhcXVbQwetbymmJfKAmH; // 0x14
		public Guid CxzTsJSuiZuoQzFIXAHesNKBJEGIA; // 0x18
		public string KAhPhNCPIOUGWydRQSumNKzZsKNx; // 0x28
		public eNfvpwLBlcLZrDwMSAAKYmquIOpc MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x30
		public string rTDvBtbCVHvoCFneOcKfGwPSCvaeA; // 0x38
		public string ZFMfPPlGsRclaQOlhEcmxjLIUoNw; // 0x40
		public Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x48
		public PidVid UpyzrRZKfKsNDZOSBiHvfgsXnMEj; // 0x58
		public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x5C
		public int bFaTouXVRSbUDxnKoDJaMwjffcUaA; // 0x6C
		public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0x70
		public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0x74
		public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x78
		public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x7C
		public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x80
		public bool lDGUseilaXGQbkQZzhoWsJSOEiWlA; // 0x84
		public int wmIpsUFSaOewogOkLvkWvhcvIkdx; // 0x88
		private float[] WfmlOHFCVeUNZVCPhDBiDsPajnMg; // 0x90
		private float[] yyCeayeEvvFNGKjODQMmSEtKmaSuA; // 0x98
		private bool[] noPRYRxTAeWhQaIlmSTYqrgmrmuC; // 0xA0
		private HardwareJoystickMap_InputManager CYjJHFxAtePWANrtsNPovmhwWUDX; // 0xA8
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0xB0
		private bool nBhrPsWcWrCUgCUSDZmuJHYHdMDR; // 0xB8
		private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0xB9
		[CompilerGenerated]
		private Rewired.Controller.Extension ZZNbPgECnscaJlWQDXZbQJUjJQXeb; // 0xC0
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xC8

		// Properties
		[CustomObfuscation(rename = false)]
		public int rewiredId { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		[CustomObfuscation(rename = false)]
		public int inputManagerId { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		[CustomObfuscation(rename = false)]
		public string name { get; } // 0x000000018AB83EE4-0x000000018AB83F30 
		[CustomObfuscation(rename = false)]
		public long? systemId { get; } // 0x000000018AB83FC8-0x000000018AB84028 
		[CustomObfuscation(rename = false)]
		public int unityId { get; } // 0x00000001811EC580-0x00000001811EC590 
		[CustomObfuscation(rename = false)]
		public Guid instanceGuid { get; } // 0x0000000184D8FD50-0x0000000184D8FD60 
		[CustomObfuscation(rename = false)]
		public Guid persistentGuid { get; } // 0x000000018AB83F30-0x000000018AB83FC8 
		[CustomObfuscation(rename = false)]
		public Rewired.Controller.Extension extension { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0

		// Constructors
		public dNsssvxJNFrLApzRfgonqfmlEPBbA(Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_0007342a); // 0x000000018AB83EBC-0x000000018AB83EE4

		// Methods
		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex); // 0x000000018AB83B04-0x000000018AB83B30
		[CustomObfuscation(rename = false)]
		public void StopVibration(); // 0x000000018AB83C08-0x000000018AB83C5C
		public void pYQRzXnykRQYsfpIPhseqdKvyUyv(); // 0x000000018AB8467C-0x000000018AB848DC
		public void zdydrJEThCgTgeIKlxbRirIgPrdgB(dNsssvxJNFrLApzRfgonqfmlEPBbA param_0007342b); // 0x000000018AB84994-0x000000018AB84AE8
		[CustomObfuscation(rename = false)]
		public void Update(); // 0x000000018AB83D94-0x000000018AB83DB4
		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018AB82F94-0x000000018AB83144
		public int HzPmTNZHjTeMRqJVTLSBKHKRLNFG(dNsssvxJNFrLApzRfgonqfmlEPBbA param_0007342d); // 0x000000018AB83144-0x000000018AB83200
		private BridgedControllerHWInfo QaexLfVSNbNHhboOvHEvgYdhcbmt(); // 0x000000018AB83A3C-0x000000018AB83A9C
		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController(); // 0x000000018AB83C5C-0x000000018AB83CBC
		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x000000018AB83CBC-0x000000018AB83D20
		private void NkoqbCbQUJeDuCjzLLadeyqGfntS(); // 0x000000018AB833CC-0x000000018AB83484
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(); // 0x000000018AB848DC-0x000000018AB84994
		private void UxgsasKuGqopgQwFFISfZULSApaI(HardwareJoystickMap.Platform_WindowsWGI_Base.Axis param_0007342e, int param_0007342f); // 0x000000018AB83DB4-0x000000018AB83E8C
		private void SlxylFVFbDNoNznWgcjBPYhvekkC(HardwareJoystickMap.Platform_WindowsWGI_Base.Button param_00073430, int param_00073431); // 0x000000018AB83B30-0x000000018AB83C08
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(HardwareJoystickMap.Platform_WindowsWGI_Base.Axis param_00073432); // 0x000000018AB82E14-0x000000018AB82F44
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_00073433); // 0x000000018AB82D94-0x000000018AB82E14
		private float lrsQAhdkMHwMfBaOmoegOfkmAFnX(HardwareJoystickMap.Platform_WindowsWGI_Base.Button param_00073434); // 0x000000018AB84028-0x000000018AB842E0
		private float nRdiXbbkJNZLWvmBZlGjEqPPBccI(int param_00073435, int param_00073436, HatType param_00073437); // 0x000000018AB8432C-0x000000018AB843D0
		private float mSxgldHAJNIiJDyPeUSIRNKVYLSqb(int param_00073438, Rewired.Data.Mapping.AxisDirection param_00073439); // 0x000000018AB842E0-0x000000018AB8432C
		private void ODjDNosGTVTcApOFJHPRXXJKAaMW(); // 0x000000018AB83484-0x000000018AB83A3C
		private string IeuDBTyfoXaFRBEPsPJzcxogdisx(); // 0x000000018AB83200-0x000000018AB833CC
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedControllerHWInfo param_0007343a); // 0x000000018AB843D0-0x000000018AB84528
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedController param_0007343b); // 0x000000018AB84528-0x000000018AB8467C
		private UnknownControllerHat[] AksIjPlBzYIerpYGUHpsdbhDSeVW(); // 0x000000018AB82BD4-0x000000018AB82D94
		public void Dispose(); // 0x000000018AB82F44-0x000000018AB82F94
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB83D20-0x000000018AB83D94
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007343c); // 0x000000018AB83A9C-0x000000018AB83B04
		public static int PUwZSLuKHRgBeBIdtZbaoZgHIMdBA(dNsssvxJNFrLApzRfgonqfmlEPBbA param_0007343d, dNsssvxJNFrLApzRfgonqfmlEPBbA param_0007343e); // 0x000000018AB0699C-0x000000018AB069CC
		public static int ZTOwqxDJXpohSLyPoOMAhofMtKMo(dNsssvxJNFrLApzRfgonqfmlEPBbA param_0007343f, dNsssvxJNFrLApzRfgonqfmlEPBbA param_00073440); // 0x000000018AB83E8C-0x000000018AB83EBC
	}

	private class VOIUdgfvFOcBkklESphisBeETZCF // TypeDefIndex: 53605
	{
		// Fields
		private List<oxFErcZrDolxlHjiZWMcPhWuilFC> kfYfqEcEuytPhEMEULSfGPpdWoee; // 0x10

		// Nested types
		public enum BkyQQTfkaoDdOdkdePBMBSEcOvYC // TypeDefIndex: 53602
		{
			Exact = 0,
			Approximate = 1
		}

		public class oxFErcZrDolxlHjiZWMcPhWuilFC // TypeDefIndex: 53603
		{
			// Fields
			public int ZewBubFBTMGdguZhicDjJwXDMzqL; // 0x10
			public Guid RuUyWLJiWbqVBpGrMytXGugwnZGo; // 0x14
			public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x24
			public int JXScdMHyYyhMIpOYqnnMPyDeWaAgA; // 0x34
			public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x38
			public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x3C
			public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x40
			public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0x44
			public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0x48

			// Constructors
			public oxFErcZrDolxlHjiZWMcPhWuilFC(); // 0x00000001841E1670-0x00000001841E1680

			// Methods
			public bool HzPmTNZHjTeMRqJVTLSBKHKRLNFG(dNsssvxJNFrLApzRfgonqfmlEPBbA param_00073447, BkyQQTfkaoDdOdkdePBMBSEcOvYC param_00073448); // 0x000000018AB85B1C-0x000000018AB85C1C
		}

		[CompilerGenerated]
		private sealed class tuUvGepKTNboGNzzxHNDifnoEWZDA : IEnumerable<oxFErcZrDolxlHjiZWMcPhWuilFC>, IEnumerator<oxFErcZrDolxlHjiZWMcPhWuilFC> // TypeDefIndex: 53604
		{
			// Fields
			private int fYQgehhaxgmucoHwUcKeBQGOPxQf; // 0x10
			private oxFErcZrDolxlHjiZWMcPhWuilFC rEnDOlfBAoeCjPebviBVAehVjPn; // 0x18
			private int IZBclvIYPYqsRntRbExTPuWmERphA; // 0x20
			public VOIUdgfvFOcBkklESphisBeETZCF fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x28
			private dNsssvxJNFrLApzRfgonqfmlEPBbA PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x30
			public dNsssvxJNFrLApzRfgonqfmlEPBbA hisBWedFwfgnWcdvDaDbceiyvEbrc; // 0x38
			private BkyQQTfkaoDdOdkdePBMBSEcOvYC oXtqEqZfQuyKWUrFJKdmMIOQHjsBA; // 0x40
			public BkyQQTfkaoDdOdkdePBMBSEcOvYC MpkzjDbhaZctoAPhNvsdAaUgKnCJ; // 0x44
			private int oqwDyyTMKnSedrldMxUmixFEHvcE; // 0x48
			private int JbCuPbQlPJerRbkBryzmjprgTJnI; // 0x4C

			// Properties
			oxFErcZrDolxlHjiZWMcPhWuilFC IEnumerator<Rewired.Platforms.Microsoft.WindowsGamingInput.WGIInputManager.JoystickRecords.Record>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 

			// Constructors
			[DebuggerHidden]
			public tuUvGepKTNboGNzzxHNDifnoEWZDA(int param_00073449); // 0x00000001891B1F10-0x00000001891B1F44

			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AB882B4-0x000000018AB883AC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AB88470-0x000000018AB884BC
			[DebuggerHidden]
			IEnumerator<oxFErcZrDolxlHjiZWMcPhWuilFC> System.Collections.Generic.IEnumerable<Rewired.Platforms.Microsoft.WindowsGamingInput.WGIInputManager.JoystickRecords.Record>.GetEnumerator(); // 0x000000018AB883AC-0x000000018AB88468
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AB88468-0x000000018AB88470
		}

		// Constructors
		public VOIUdgfvFOcBkklESphisBeETZCF(); // 0x000000018AB7D9D0-0x000000018AB7DA48

		// Methods
		public void oeWKkKFoQYQjZrnTprfFYxpVhrZv(dNsssvxJNFrLApzRfgonqfmlEPBbA param_00073441); // 0x000000018AB7DA48-0x000000018AB7DD40
		public IEnumerable<oxFErcZrDolxlHjiZWMcPhWuilFC> rPEMzZmJunpFkQUNyRKTxEVSsvJu(dNsssvxJNFrLApzRfgonqfmlEPBbA param_00073442, BkyQQTfkaoDdOdkdePBMBSEcOvYC param_00073443); // 0x000000018AB7DD40-0x000000018AB7DDD8
		private void QKCfzjnPNjViQblauEfiHIvbjBzFA(int param_00073444, Guid param_00073445, int param_00073446); // 0x000000018AB7D8A8-0x000000018AB7D9D0
	}

	// Constructors
	public ZvFOVHtMPPFSKMXvcEpBjwvCmYwe(ConfigVars param_00073400, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_00073401, Func<int> param_00073402, Func<PidVid, bool> param_00073403); // 0x000000018AB82428-0x000000018AB82644

	// Methods
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x000000018AB81840-0x000000018AB818C0
	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop); // 0x000000018AB82138-0x000000018AB821A8
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018AB81AF8-0x000000018AB81BB8
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000184D86230-0x0000000184D86240
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x000000018AB82038-0x000000018AB82138
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x000000018AB82008-0x000000018AB82020
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x000000018AB82020-0x000000018AB82038
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018AB81828-0x000000018AB81840
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018AB81828-0x000000018AB81840
	protected bool bExEtJRMyxGvZHyIQvbjmTimVEXKA(PidVid param_00073409); // 0x000000018AB82644-0x000000018AB82670
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(); // 0x000000018AB81FE4-0x000000018AB82008
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(IList<eNfvpwLBlcLZrDwMSAAKYmquIOpc> param_0007340a); // 0x000000018AB81BB8-0x000000018AB81FE4
	private void yJJCtBCrCEsbprFwlpsOnWBkGRvrA(); // 0x000000018AB82ABC-0x000000018AB82B2C
	private IList<eNfvpwLBlcLZrDwMSAAKYmquIOpc> AlkKsBlkcKIlWhlVuLZJCJDXfHCgb(); // 0x000000018AB814A4-0x000000018AB814EC
	private void FVpBjAwyGBpVQpbIGUMUuPmYWCYq(int param_0007340b, int param_0007340c, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_0007340d, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_0007340e); // 0x000000018AB814EC-0x000000018AB816F4
	private bool ymbuqHxpmIVcyliPHUJTGDZqcnEJA(List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_0007340f, int param_00073410); // 0x000000018AB82B2C-0x000000018AB82BD4
	private int gYLinYswKgWgjjceGEMBKlqvhlEGb(List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073411); // 0x000000018AB82670-0x000000018AB82718
	private bool iXsRWfwjaxOSbFdmAXxVCIUyoIxI(List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073412, int param_00073413); // 0x000000018AB82778-0x000000018AB827FC
	private void NQvRARFJpLxdsIUPRkuuXQTUjNox(int param_00073414, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073415, int param_00073416, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073417, VOIUdgfvFOcBkklESphisBeETZCF.BkyQQTfkaoDdOdkdePBMBSEcOvYC param_00073418); // 0x000000018AB819B4-0x000000018AB81AF8
	private void XxteBwdFImtrzajKwxGejbRDStnH(int param_00073419, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_0007341a, VOIUdgfvFOcBkklESphisBeETZCF.BkyQQTfkaoDdOdkdePBMBSEcOvYC param_0007341b); // 0x000000018AB821A8-0x000000018AB82428
	private void pjAprbCReXGeXpuaPApVlCDMgEk(); // 0x000000018AB827FC-0x000000018AB8285C
	private bool uRdbjqOsEkXqUsbrHdKhfkfmEUboA(IList<eNfvpwLBlcLZrDwMSAAKYmquIOpc> param_0007341c); // 0x000000018AB8285C-0x000000018AB829D8
	private bool xcIOtxcgNETqciTqWuRjukkZMnEj(Guid param_0007341d); // 0x000000018AB829D8-0x000000018AB82ABC
	private bool MUMDpCDwdurISJEJjKWLquYbZQvaA(IList<eNfvpwLBlcLZrDwMSAAKYmquIOpc> param_0007341e, Guid param_0007341f); // 0x000000018AB818C0-0x000000018AB819B4
	private void GOiJYHNLShkFyPFsoSQwzPnKQhdP(List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073420, List<dNsssvxJNFrLApzRfgonqfmlEPBbA> param_00073421, bool param_00073422); // 0x000000018AB816F4-0x000000018AB81828
	private void iEEFlbFDszRppifBFnwpNApzASvF(dNsssvxJNFrLApzRfgonqfmlEPBbA param_00073423, bool param_00073424); // 0x000000018AB82718-0x000000018AB82778
}

internal class QxTmNwfleGAUlOPloekweCICSBLE : IInputSource // TypeDefIndex: 53607
{
	// Fields
	private static sSeXfAxAAxiXLAtqyIfJrJTcdaQh CDfqZkcaEYxbetBerABYaOrzklRMA; // 0x00
	private List<eNfvpwLBlcLZrDwMSAAKYmquIOpc> PCdPJbHLsogIbJECApXLUpgSXfnrA; // 0x10
	private ReadOnlyCollection<eNfvpwLBlcLZrDwMSAAKYmquIOpc> ulAcKhdUgomyceGYpJGFbANYPEsC; // 0x18
	private ConfigVars VZkjmxqEGPGMJvGmBfBIPDvdPApS; // 0x20
	private readonly bool axkKvliPJxIEjkBAIyuBFFzRUJZj; // 0x28
	private readonly bool WVkPZPERjqJrUTkyeJPxPWSPJUUe; // 0x29
	private readonly bool blXhVnJwmDqRDEWaVygZFlMlUjnd; // 0x2A
	private bool hbpWASBWJoDFbejbdXkTCkzkrHOP; // 0x2B
	[CompilerGenerated]
	private Action dxnTatXHsETEvJsuYRfCNkvGrAxy; // 0x30
	private readonly bool qITJHglIaCJOqhFtaHRAinrkYKm; // 0x38
	private readonly bool JvUGwOkbMBEHpCPFuTcRjomivCXeA; // 0x39
	private readonly bool TGhctRASUlMSMahHCqUrwkLiiOPRA; // 0x3A
	private int VHIBouSuUkRHHbxTsSCPjOIBjNcHA; // 0x3C
	private bool TBWyFKSyHebRlQFGLjukyFebmpNd; // 0x40
	private static readonly string JFYxhxLqhUhkPgtvPohERITwlUuK; // 0x08
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x41

	// Properties
	public IUnifiedKeyboardSource DAKrDXiLhyBpnKTEDsnKpBNhcGcL { get; } // 0x00000001811EC580-0x00000001811EC590 
	public IUnifiedMouseSource biKlLsDpPRJnAQPptDMBvDdWKqLK { get; } // 0x00000001811EC580-0x00000001811EC590 

	// Events
	private event Action dxnTatXHsETEvJsuYRfCNkvGrAxy {
		add; // 0x000000018AB7C778-0x000000018AB7C80C
		remove; // 0x000000018AB7C8A8-0x000000018AB7C93C
	}
	public event Action DpsleWpZupQSExUUeoaqxQrXkiab {
		add; // 0x000000018AB7D888-0x000000018AB7D890
		remove; // 0x000000018AB7D890-0x000000018AB7D898
	}

	// Constructors
	public QxTmNwfleGAUlOPloekweCICSBLE(ConfigVars param_0007344c, bool param_0007344d, bool param_0007344e, bool param_0007344f); // 0x000000018AB7D1E4-0x000000018AB7D888
	static QxTmNwfleGAUlOPloekweCICSBLE(); // 0x000000018AB7D184-0x000000018AB7D1E4

	// Methods
	public void zqSkLmupRiXSvinHfYCcdyyKpYwJ(); // 0x000000018AB7D898-0x000000018AB7D8A8
	public bool PRajVZFjkThVyEtmdfNgoHAJuyoe(PidVid param_00073450); // 0x000000018AB7C824-0x000000018AB7C88C
	public void SystemDeviceDisconnected(); // 0x000000018AB7CED8-0x000000018AB7CEE0
	public void SystemDeviceConnected(); // 0x000000018AB7CED8-0x000000018AB7CEE0
	public void Update(); // 0x000000018AB7D114-0x000000018AB7D184
	public void UpdateDevices(UpdateLoopType updateLoop); // 0x000000018AB7CF54-0x000000018AB7D068
	public void UpdateFinished(); // 0x000000018AB7D068-0x000000018AB7D114
	public IList<T> GetJoysticks<T>()
		where T : class;
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(bool param_00073454); // 0x000000018AB7C93C-0x000000018AB7CD58
	private void QcNqgYIEBECjeindYsOwxaBNNylR(); // 0x000000018AB7C88C-0x000000018AB7C8A8
	private int GfyCUpLbRVSoLyvlZFXnudRcZyHo(); // 0x000000018AB7C80C-0x000000018AB7C824
	private void BSBbCkZloeHSdffjvjzejfeNNIchb(bool param_00073455); // 0x000000018AB7C718-0x000000018AB7C728
	public void Dispose(); // 0x000000018AB7C728-0x000000018AB7C778
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB7CEE0-0x000000018AB7CF54
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073456); // 0x000000018AB7CD58-0x000000018AB7CED8
}

internal abstract class kRyYZXvVecLRzJlIrixXarXRkjAGb : eNfvpwLBlcLZrDwMSAAKYmquIOpc // TypeDefIndex: 53610
{
	// Fields
	protected readonly WGIDeviceType FMzRoXctgKLenpvIAfMtMnMnbNBk; // 0x10
	private int mBtXxAjzptwoKVBtfVsfIdZmEYkaA; // 0x14
	protected readonly Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x18
	protected readonly Guid iRPiAClIZbOdyUnmcpfzkmsIdgoJ; // 0x28
	protected readonly PidVid TAiEBzCPoAjcHwGjaEaYAyYSRkDcA; // 0x38
	protected readonly ushort tMntoUuZQZtDlsUcaHXULsdxGIpS; // 0x3C
	protected readonly ushort gTRusTxIOqlYAyUvPydyUVDWDKZK; // 0x3E
	protected readonly string FTsvIXEktiHXgfwfsNXGtJdrQfsR; // 0x40
	protected readonly string mkdAHpEKgEeYXQmkzeUtIlDlKGCBb; // 0x48
	protected readonly bool BgcqbzTwKrqAcJaYvXsGhkURtjGy; // 0x50
	private WRqiFiMABvxEeukPytmLAZrDMfeI EKJjjXKMDoyBLlBQDgxfLiaIWsPE; // 0x58
	private Rewired.Controller.Extension RHSxHLIJnOQXQFTHMLuenqSPAUBl; // 0x60
	protected readonly ButtonLoopSet sNHNPUwkJdSniwWpqjpgKZvUkcXg; // 0x68
	protected readonly QZBgpNcZHxUIdcYbGYxykIMrQHufA[] GJbtoqUIykdcrGykLQjVjDezPgJxA; // 0x70
	protected readonly int mcjmovIdelhuuidgbQwUjRMuilVGb; // 0x78
	protected readonly int YjYHQqCNXeaLDEeDhECJjazcWtgF; // 0x7C
	protected readonly int BtfhKVXdSTHOOxDkoIwphIDlNZqcb; // 0x80
	private readonly bool gpkjLazteZhqcTbnCrknMWiKkOCC; // 0x84
	private readonly PidVid SzuAONCRTtsopQMcokENzKoWoQsm; // 0x86
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x8A

	// Properties
	public InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; } // 0x0000000184DA77E0-0x0000000184DA77F0 
	public int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; } // 0x0000000184D882A0-0x0000000184D882B0 
	public string cJMYRUIePewENzlebCoKsxxPfeZBA { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	public Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; } // 0x0000000184D890C0-0x0000000184D890D0 
	public PidVid eabRFvqklxoYMJPbeMmtEYziJBbB { get; } // 0x000000018AB856AC-0x000000018AB856C0 
	public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX { get; } // 0x0000000184DA86F0-0x0000000184DA8700 
	public ushort NDweLaWskzoBwpWJxCWuzQStzdYi { get; } // 0x0000000184DA86E0-0x0000000184DA86F0 
	public Guid aNgaHbYRnoeDOKekCLvIxDjDiTpgA { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { get; } // 0x000000018AB84E9C-0x000000018AB84EB8 
	public int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; } // 0x000000018AB84DEC-0x000000018AB84E08 
	public int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; } // 0x0000000184D863A0-0x0000000184D863B0 
	public abstract bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; }
	public abstract int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; }
	public WGIDeviceType FeydSgDjtypCTgePURUdNlOclvVRA { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	public bool DMJqTpZTwOTOujCqZfgHNmEThhfJ { get; } // 0x0000000182A80FA0-0x0000000182A80FB0 
	public Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; } // 0x0000000184D86280-0x0000000184D86290 

	// Nested types
	protected abstract class POiSXKWqpBngEMPJrSMlukiUOCu<u0001> // TypeDefIndex: 53608
	{
		// Fields
		public u0001 IaOjDqjXmTvIEPrVtSrrcPlQvkii;

		// Constructors
		public POiSXKWqpBngEMPJrSMlukiUOCu();
	}

	protected class QZBgpNcZHxUIdcYbGYxykIMrQHufA : POiSXKWqpBngEMPJrSMlukiUOCu<float> // TypeDefIndex: 53609
	{
		// Constructors
		public QZBgpNcZHxUIdcYbGYxykIMrQHufA(); // 0x000000018AB7C6F0-0x000000018AB7C718
	}

	// Constructors
	public kRyYZXvVecLRzJlIrixXarXRkjAGb(WGIDeviceType param_00073457, WRqiFiMABvxEeukPytmLAZrDMfeI param_00073458, int param_00073459, int param_0007345a, int param_0007345b, int param_0007345c); // 0x000000018AB84F9C-0x000000018AB85624

	// Methods
	public abstract void SetVibration(int motorIndex, float amount, bool stopOtherMotors);
	public abstract void StopVibration();
	public bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(int param_00073460); // 0x000000018AB85624-0x000000018AB856AC
	public float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_00073461); // 0x000000018AB84E08-0x000000018AB84E4C
	public int ImLuWROnVBPkqNCjYBWRnhyTStaH(int param_00073462); // 0x0000000184DA2BB0-0x0000000184DA2BC0
	public virtual void pklLTaWbvSXZvwSHNrAPLnwqJXoO(eNfvpwLBlcLZrDwMSAAKYmquIOpc param_00073463); // 0x000000018AB856C0-0x000000018AB85728
	public virtual void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073464); // 0x000000018AB84ED0-0x000000018AB84F24
	public virtual void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018AB85728-0x000000018AB8577C
	public void Dispose(); // 0x000000018AB84E4C-0x000000018AB84E9C
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB84F24-0x000000018AB84F9C
	protected virtual bool SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073465); // 0x000000018AB84EB8-0x000000018AB84ED0
}

internal abstract class WRqiFiMABvxEeukPytmLAZrDMfeI : gfOsPGwCBWApLANJUASJsoWlYrzbA // TypeDefIndex: 53613
{
	// Constructors
	protected WRqiFiMABvxEeukPytmLAZrDMfeI(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_0007346b); // 0x0000000184D88BF0-0x0000000184D88C00
}

internal class xTONizpynmfsfmMGjoZKtugyxXqB : WRqiFiMABvxEeukPytmLAZrDMfeI // TypeDefIndex: 53614
{
	// Fields
	private static bool aQtLoqtxsekSGSGCyIhPxJnYfoIdA; // 0x00
	private static PidVid[] XcsEwalNqrfBOCxknLDMUpkNJwFwA; // 0x08
	[CompilerGenerated]
	private static Action<xTONizpynmfsfmMGjoZKtugyxXqB> fEPGZKBRlEFKhQtGAmlIjpeijsZLc; // 0x10
	[CompilerGenerated]
	private static Action<xTONizpynmfsfmMGjoZKtugyxXqB> KsMjFASygbTssqeXdUMuOsJqcSDl; // 0x18

	// Properties
	public JaQnnRxPcWCJXAnpNCxpObeGFfZ AzTKzpcpepoHyqkrIKIAosuSVoBx { set; } // 0x000000018AB8ACE0-0x000000018AB8AD14

	// Events
	public static event Action<xTONizpynmfsfmMGjoZKtugyxXqB> fEPGZKBRlEFKhQtGAmlIjpeijsZLc {
		add; // 0x000000018AB8A1A0-0x000000018AB8A268
		remove; // 0x000000018AB8A600-0x000000018AB8A6C8
	}
	public static event Action<xTONizpynmfsfmMGjoZKtugyxXqB> KsMjFASygbTssqeXdUMuOsJqcSDl {
		add; // 0x000000018AB8A918-0x000000018AB8A9E0
		remove; // 0x000000018AB8A518-0x000000018AB8A5E0
	}

	// Constructors
	public xTONizpynmfsfmMGjoZKtugyxXqB(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_0007347c); // 0x0000000184D88BF0-0x0000000184D88C00
	static xTONizpynmfsfmMGjoZKtugyxXqB(); // 0x000000018AB8A884-0x000000018AB8A918

	// Methods
	public static void DKVpNyqREOIVACgmSVaaAXYjPvP(); // 0x000000018AB8A268-0x000000018AB8A518
	public static void gVdBeQJURtaltdSYjxAtasRcQkfZB(); // 0x000000018AB8A9E0-0x000000018AB8ABE4
	public static void sWJOnfxPBadazuczZMVzMdnWxuMF(List<xTONizpynmfsfmMGjoZKtugyxXqB> param_00073470); // 0x000000018AB8AD14-0x000000018AB8AEA4
	public static bool NvTKiYhpNyHCiHSqumMZdTDfGGMqb(ushort param_00073471, ushort param_00073472); // 0x000000018AB8A708-0x000000018AB8A884
	private static bool mvfAKmMmnTfexhBoeWLcDVABFJFcb(ushort param_00073473, ushort param_00073474, ltvMIJQDOVahJxMogBIqJomZcAyGb param_00073475); // 0x000000018AB8ABE4-0x000000018AB8ACCC
	private static bool yrUeUxjCTMlGIIeSkBbTLyUTCgex(ushort param_00073476, ushort param_00073477, ushort param_00073478, ushort param_00073479); // 0x000000018AB8B0B8-0x000000018AB8B200
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(QCXAdrYeoiIaDhgwJbqhSbdCgmWt.qsUaWnaOTfbdEUpSLXGSWhXhItCBb))]
	private static void wwLgwEQUiKEHyzLXrSFGwhRSuwrQ(plwsmfqnWbhsWAUbGQRUXipBtMde param_0007347a); // 0x000000018AB8B028-0x000000018AB8B0B8
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(QCXAdrYeoiIaDhgwJbqhSbdCgmWt.CZdmTuZTZgzBZpuotKhclUJfgIwC))]
	private static void tngfjEbSnLeRaHbzeSADyWdcHAiJA(plwsmfqnWbhsWAUbGQRUXipBtMde param_0007347b); // 0x000000018AB8AEA4-0x000000018AB8AF34
	public CbTgNHFFAIhPqyQzSkOQWxDxpAFbA LanptfCarJGFsSnHOBSkeKNpGhuNA(); // 0x000000018AB8A6C8-0x000000018AB8A708
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_0007347e); // 0x000000018AB8AFAC-0x000000018AB8B028
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x0000000184D87100-0x0000000184D87110
	public bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(xTONizpynmfsfmMGjoZKtugyxXqB param_0007347f); // 0x000000018AB8AF34-0x000000018AB8AFAC
	public static bool pqIWMXtLRfrLeVQnvBQsHmpvyOwL(xTONizpynmfsfmMGjoZKtugyxXqB param_00073480, xTONizpynmfsfmMGjoZKtugyxXqB param_00073481); // 0x000000018AB8ACCC-0x000000018AB8ACE0
	public static bool FUeRCYeZMdcUMzwOCDzlKtPuAvXS(xTONizpynmfsfmMGjoZKtugyxXqB param_00073482, xTONizpynmfsfmMGjoZKtugyxXqB param_00073483); // 0x000000018AB8A5E0-0x000000018AB8A600
}

internal class ltvMIJQDOVahJxMogBIqJomZcAyGb : WRqiFiMABvxEeukPytmLAZrDMfeI, IhnkQXvfiVqodZkZlCKfERgAixYb // TypeDefIndex: 53615
{
	// Properties
	public bool PtgvDgVGDSoFpSyoAQWGUVadHpyG { get; } // 0x000000018AB85A88-0x000000018AB85AA8 
	public int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; } // 0x000000018AB8577C-0x000000018AB8579C 
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { get; } // 0x000000018AB85928-0x000000018AB85948 
	public ushort UJzRyOlVLEWSgNGuEUZhOEUtcBgO { get; } // 0x000000018AB85A68-0x000000018AB85A88 
	public ushort LtCoVbQhCtrFFQMdQhulKASuRWqL { get; } // 0x000000018AB85AA8-0x000000018AB85AC8 
	public int VkIkNerOTMGSqrYXSFRxDHAwPdtD { get; } // 0x000000018AB85908-0x000000018AB85928 
	public string DmgOnrfsrdJveAtMBYLlduRkGcQv { get; } // 0x000000018AB85948-0x000000018AB8599C 
	public string dVBWLIqvdJjCTQUVQqSaJdTIAzsR { get; } // 0x000000018AB85AC8-0x000000018AB85B1C 

	// Constructors
	public ltvMIJQDOVahJxMogBIqJomZcAyGb(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_00073485); // 0x0000000184D88BF0-0x0000000184D88C00

	// Methods
	public static ltvMIJQDOVahJxMogBIqJomZcAyGb jBsIGPfNQdQlCWuDQfJzCKcJZXDGB(WRqiFiMABvxEeukPytmLAZrDMfeI param_00073484); // 0x000000018AB8599C-0x000000018AB85A68
	public bool DMJqTpZTwOTOujCqZfgHNmEThhfJ(out PidVid param_00073486); // 0x000000018AB8579C-0x000000018AB85908
}

internal struct JaQnnRxPcWCJXAnpNCxpObeGFfZ // TypeDefIndex: 53616
{
	// Fields
	public double bnVCUMRPyGNZCBSBfoFOWqsyoSiD; // 0x00
	public double NHXQOwSppJgoLEkdgyidunvRqBQPA; // 0x08
	public double DgRdfReODEnYrxxVRlJXGsPZRHvTA; // 0x10
	public double vJTvjiVXyLpJFjfATeIPFcgKcshx; // 0x18

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB7B184-0x000000018AB7B288
}

internal struct CbTgNHFFAIhPqyQzSkOQWxDxpAFbA // TypeDefIndex: 53617
{
	// Fields
	public GamepadButtons PlahzMFUWWFVTEjviHdVVhgEfBVTb; // 0x00
	public double eFOFrBPeuQLSJYqxLukOyQnwWxTO; // 0x08
	public double iajIZllhiSlChOaBFvIKXDIVBwov; // 0x10
	public double NHXQOwSppJgoLEkdgyidunvRqBQPA; // 0x18
	public double WRxVfANqjwSjOaMxYWaRdmzLQFte; // 0x20
	public double NSqhiEZwjAouRoFwmpZtLcTYdbmx; // 0x28
	public double vJTvjiVXyLpJFjfATeIPFcgKcshx; // 0x30
	public ulong yarsNCqpAJyntJMkiHvyHqhuMcsT; // 0x38

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB7AECC-0x000000018AB7B0E4
}

internal interface IhnkQXvfiVqodZkZlCKfERgAixYb // TypeDefIndex: 53619
{
	// Properties
	bool PtgvDgVGDSoFpSyoAQWGUVadHpyG { get; }
}

internal interface dgxxfOXDTLCjaOlmsbBKVcVTHAcO // TypeDefIndex: 53620
{
	// Properties
	bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; }

	// Methods
	void IYsALPEzKUpSHjMlchBUFTjZCkvr();
}

internal abstract class gfOsPGwCBWApLANJUASJsoWlYrzbA : IDisposable, dgxxfOXDTLCjaOlmsbBKVcVTHAcO // TypeDefIndex: 53621
{
	// Fields
	protected YWCaxKCjNDTdBLTDZNSJtTHiIMnk HmjIMgrvlgIJozHXDOXofnrdHqTk; // 0x10
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x18

	// Properties
	public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x0000000183CF6CB0-0x0000000183CF6CC0 
	public IntPtr flvVEFpgKucPjVdmvJHkUQNaTzAQ { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 

	// Constructors
	protected gfOsPGwCBWApLANJUASJsoWlYrzbA(YWCaxKCjNDTdBLTDZNSJtTHiIMnk param_00073487); // 0x0000000184D88BF0-0x0000000184D88C00

	// Methods
	public virtual void IYsALPEzKUpSHjMlchBUFTjZCkvr(); // 0x000000018AB84D48-0x000000018AB84D54
	public virtual void Dispose(); // 0x000000018AB84CF8-0x000000018AB84D48
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB84D78-0x000000018AB84DEC
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073488); // 0x000000018AB84D54-0x000000018AB84D78
}

internal enum DKfdSpPOsWGnACTRAulCFEVLxkQk // TypeDefIndex: 53622
{
	None = 0,
	LostFocus = 1,
	GainedFocus = 2
}

internal enum ZmIGzJfowxKiyvJARuzfVHOOhwvO // TypeDefIndex: 53623
{
	None = 0,
	RawInput = 1,
	DirectInput = 2,
	XInput = 3,
	ManualHID = 4
}

internal class WtJzdNLrJHyRaJJmBqtOoHCrGIsI : PlatformInputManager, rcTfTYAszdSLhBATSedVHksZNKpU // TypeDefIndex: 53636
{
	// Fields
	private IntPtr jhGooCbTTXmgjsKnAiicIgjWqgcZ; // 0x38
	private nmDUaUhbthOlhiDQJeKfGxYxeylPA kpvPZlvxDyNXZmTPjGIpIycLmSaf; // 0x40
	private List<SulfOtFmRZnbMqygEpLarHhEkBqj> PCdPJbHLsogIbJECApXLUpgSXfnrA; // 0x48
	private int kGiRolZJJVXJXFIbgdrtzARRRwXB; // 0x50
	private eChiVyLsHBuxgtuOcCaBRldtIBrcA CXazGSMYzoifXDbkIaaNsbkSZbeP; // 0x58
	private bool KdmwGnYbMHfNjoxROCJtGTeOPvzrA; // 0x60
	private hohNsNaAhdJOLmrreLGwwtWoRfkL iCEBYENXkrooMoPlvszKOfnAQAmp; // 0x68
	private UpdateLoopSetting SdWaFZjlDoaLBjbxEkIClPMoqSuSA; // 0x70
	private Action<int, ControllerDataUpdater> HqGgQZphbXxVTpfvwnRAAhNlMQRI; // 0x78
	private PlatformInputManager DeuaCkgWrfMxvbuXImykIcuYIdCrA; // 0x80
	private TimerRealTime SbbJtQJZzisMWHKxmkfcVZWdUHGH; // 0x88
	private KSXcWnVJXHdGdcxUNnMBaqHZACuK<bool> UrCDGcaImKXLdWBBgToCXUsODRGB; // 0x90
	private VtHAKVjbpOKKtQGWBbdqHjKCvTZNc vDKyvDgRzbUCPUvPGnTcZFSiotRP; // 0x98
	private int FFpVkafjOpfTZntjBVnZgQjJineC; // 0xA0
	private int BOWFKzAGxWgFctMCdsQlqHACQcgE; // 0xA4
	private KSXcWnVJXHdGdcxUNnMBaqHZACuK<List<CWHceIMuggmodXXlPmEbtsWTclpk>> bvJfuxxhJrbPGqHkieajTTZqEMRi; // 0xA8
	private readonly object HjEsWTUUzyFrvqnrkapJHwVyFDeL; // 0xB0
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0xB8
	private Func<int> bMdbmKyqgyUaZuaPJHLNCqnGNHeDb; // 0xC0

	// Properties
	public hohNsNaAhdJOLmrreLGwwtWoRfkL DFsdfJeNLRhTXegkARhhXCEGzBogc { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x0000000184D86550-0x0000000184D86560 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000184D86260-0x0000000184D86270 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x000000018AB7FBB8-0x000000018AB7FC2C 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x0000000184D85B80-0x0000000184D85B90 

	// Nested types
	private class SulfOtFmRZnbMqygEpLarHhEkBqj : IInputManagerJoystick // TypeDefIndex: 53624
	{
		// Fields
		private int SAwUWSkGKioQPDUaFBSUbXjjqYIM; // 0x10
		private int JPJrLcYgPhcXVbQwetbymmJfKAmH; // 0x14
		public Guid CxzTsJSuiZuoQzFIXAHesNKBJEGIA; // 0x18
		public string KAhPhNCPIOUGWydRQSumNKzZsKNx; // 0x28
		public readonly gDyOnIMLNWnkqgMmQAeBaAvbdhUC boNDKtEvtQnFljhvyLYTzMMSWoS; // 0x30
		public asJwVBrSeOWneGuTCmUUKaDTCXQW xzpxpHzCMniucFvRNnKzdwDjbwZm; // 0x38
		public juBleaBZMyhfoVXqEhTgtytcTBnB lkPCdRZBgSyyRexpNCLLBfPHHwZdA; // 0x40
		public string rTDvBtbCVHvoCFneOcKfGwPSCvaeA; // 0x48
		public string ZFMfPPlGsRclaQOlhEcmxjLIUoNw; // 0x50
		public int mDfvIrfTdctiyDRPfEHZSUBTcTRU; // 0x58
		public Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x5C
		public Guid djMajrdRSJCSddJnrgHcxADPUbjH; // 0x6C
		public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x7C
		public int bFaTouXVRSbUDxnKoDJaMwjffcUaA; // 0x8C
		public bool IfcdjuIFoCXolpufCEJxbAlFVrcc; // 0x90
		public string KhYGVTHrwIDzyjLrEqyCyqFYGmisA; // 0x98
		public string hcikOlXsuvqEJKJVwwJnMNgzEvzA; // 0xA0
		public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0xA8
		public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0xAC
		public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0xB0
		public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0xB4
		public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0xB8
		public bool mUeuDXVwqxKZvZMHBIDTAvGSqqqp; // 0xBC
		public Rewired.Controller.Extension TGvHAlvaJSWTwWCdWlyRBrrTreuj; // 0xC0
		private float[] WfmlOHFCVeUNZVCPhDBiDsPajnMg; // 0xC8
		private bool[] yyCeayeEvvFNGKjODQMmSEtKmaSuA; // 0xD0
		private HardwareJoystickMap_InputManager CYjJHFxAtePWANrtsNPovmhwWUDX; // 0xD8
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0xE0
		private bool nBhrPsWcWrCUgCUSDZmuJHYHdMDR; // 0xE8
		private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0xE9
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xEA

		// Properties
		[CustomObfuscation(rename = false)]
		public int rewiredId { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		[CustomObfuscation(rename = false)]
		public int inputManagerId { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		[CustomObfuscation(rename = false)]
		public string name { get; } // 0x000000018AB92A40-0x000000018AB92AA8 
		[CustomObfuscation(rename = false)]
		public long? systemId { get; } // 0x000000018AB92AA8-0x000000018AB92B08 
		[CustomObfuscation(rename = false)]
		public int unityId { get; } // 0x00000001811EC580-0x00000001811EC590 
		[CustomObfuscation(rename = false)]
		public Rewired.Controller.Extension extension { get; } // 0x0000000184D892F0-0x0000000184D89300 
		[CustomObfuscation(rename = false)]
		public Guid instanceGuid { get; } // 0x0000000184DA8720-0x0000000184DA8730 
		[CustomObfuscation(rename = false)]
		public Guid persistentGuid { get; } // 0x0000000184DA8720-0x0000000184DA8730 

		// Constructors
		public SulfOtFmRZnbMqygEpLarHhEkBqj(gDyOnIMLNWnkqgMmQAeBaAvbdhUC param_000734b9, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_000734ba); // 0x000000018AB929B4-0x000000018AB929EC

		// Methods
		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex); // 0x00000001841E1670-0x00000001841E1680
		[CustomObfuscation(rename = false)]
		public void StopVibration(); // 0x00000001841E1670-0x00000001841E1680
		public void pYQRzXnykRQYsfpIPhseqdKvyUyv(); // 0x000000018AB9328C-0x000000018AB9342C
		public void zdydrJEThCgTgeIKlxbRirIgPrdgB(SulfOtFmRZnbMqygEpLarHhEkBqj param_000734bb); // 0x000000018AB935E0-0x000000018AB936E4
		[CustomObfuscation(rename = false)]
		public void Update(); // 0x000000018AB92838-0x000000018AB928CC
		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018AB91BF8-0x000000018AB91D4C
		public int HzPmTNZHjTeMRqJVTLSBKHKRLNFG(SulfOtFmRZnbMqygEpLarHhEkBqj param_000734bd); // 0x000000018AB91D4C-0x000000018AB91E18
		private BridgedControllerHWInfo QaexLfVSNbNHhboOvHEvgYdhcbmt(); // 0x000000018AB92474-0x000000018AB924D4
		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController(); // 0x000000018AB9266C-0x000000018AB926CC
		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x000000018AB926CC-0x000000018AB92730
		public bool TxMOcAAtBTbnmMNVgaFjIETLvxVv(); // 0x000000018AB92730-0x000000018AB927C4
		public void IoyeuUADILkjyEidcCIyeCInNLwS(); // 0x000000018AB92170-0x000000018AB92214
		private void NkoqbCbQUJeDuCjzLLadeyqGfntS(bool[] param_000734be, int[] param_000734bf); // 0x000000018AB92214-0x000000018AB923C8
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(bool[] param_000734c0, int[] param_000734c1); // 0x000000018AB9342C-0x000000018AB935E0
		private void UxgsasKuGqopgQwFFISfZULSApaI(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_000734c2, int param_000734c3, bool[] param_000734c4, int[] param_000734c5); // 0x000000018AB928CC-0x000000018AB929B4
		private void SlxylFVFbDNoNznWgcjBPYhvekkC(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_000734c6, int param_000734c7, bool[] param_000734c8, int[] param_000734c9); // 0x000000018AB92590-0x000000018AB9266C
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_000734ca, bool[] param_000734cb, int[] param_000734cc); // 0x000000018AB913D4-0x000000018AB9165C
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(DirectInputAxis param_000734cd); // 0x000000018AB9165C-0x000000018AB91BF8
		private bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_000734ce, bool[] param_000734cf, int[] param_000734d0); // 0x000000018AB92B08-0x000000018AB92F6C
		private bool nRdiXbbkJNZLWvmBZlGjEqPPBccI(int param_000734d1, int param_000734d2, HatType param_000734d3); // 0x000000018AB92FB0-0x000000018AB9304C
		private float mSxgldHAJNIiJDyPeUSIRNKVYLSqb(int param_000734d4, Rewired.Data.Mapping.AxisDirection param_000734d5); // 0x000000018AB842E0-0x000000018AB8432C
		private bool ayhGxgprMQKavcwPaVdDMAlZHPYJA(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_000734d6, bool[] param_000734d7, out bool param_000734d8); // 0x000000018AB929EC-0x000000018AB92A40
		private bool HzedpnOvqgcpdOxXJbSnaXeBYtlB(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_000734d9, out float param_000734da); // 0x000000018AB91E18-0x000000018AB91F6C
		private ControlDeviceType mRMKKTqBmJNLoCLdURVGuIhgRmpE(juBleaBZMyhfoVXqEhTgtytcTBnB param_000734db); // 0x000000018AB92F6C-0x000000018AB92FB0
		private void ODjDNosGTVTcApOFJHPRXXJKAaMW(); // 0x000000018AB923C8-0x000000018AB92474
		private string IeuDBTyfoXaFRBEPsPJzcxogdisx(); // 0x000000018AB91F6C-0x000000018AB92170
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedControllerHWInfo param_000734dc); // 0x000000018AB9304C-0x000000018AB93184
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedController param_000734dd); // 0x000000018AB93184-0x000000018AB9328C
		private UnknownControllerHat[] AksIjPlBzYIerpYGUHpsdbhDSeVW(); // 0x000000018AB91214-0x000000018AB913D4
		public void SbYVTdmkPElTDzeOGdijEuqHpCge(); // 0x000000018AB92540-0x000000018AB92590
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB927C4-0x000000018AB92838
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000734de); // 0x000000018AB92508-0x000000018AB92540
		public static int vATpGYCXLZLqQShJNcjRGtWeNRypA(SulfOtFmRZnbMqygEpLarHhEkBqj param_000734df, SulfOtFmRZnbMqygEpLarHhEkBqj param_000734e0); // 0x000000018AB0699C-0x000000018AB069CC
		public static int SRDjGGcGcwXogDrwOelaYcDKFPcp(SulfOtFmRZnbMqygEpLarHhEkBqj param_000734e1, SulfOtFmRZnbMqygEpLarHhEkBqj param_000734e2); // 0x000000018AB924D4-0x000000018AB92508
	}

	private class gDyOnIMLNWnkqgMmQAeBaAvbdhUC : IDisposable // TypeDefIndex: 53626
	{
		// Fields
		private readonly int mcjmovIdelhuuidgbQwUjRMuilVGb; // 0x10
		private readonly ButtonLoopSet sNHNPUwkJdSniwWpqjpgKZvUkcXg; // 0x18
		private readonly DualThreadLowLevelInputEventQueue wAYdmCMyMlWIgAAysxaMfmdriutHA; // 0x20
		private BxvBxbtXoUKMZoXIzwiATBygTUHp yOCDZAuKuNetHByATwSOOwhaMtcNA; // 0x28
		private readonly GPkbBxELmYMSjUedRXbWrnFhNjKFb XdmjjMeFxgaqSxcTQvcgGfErVmCEA; // 0x30
		private readonly GPkbBxELmYMSjUedRXbWrnFhNjKFb AjtgxffeZnmomXGMfKpGmufTGtnG; // 0x38
		private readonly object usmTHeMAGmCrTetnVPFtjBlXQsMEb; // 0x40
		private bool wPwEpSTGbzFkclIFABWyxxCvYiOx; // 0x48
		public readonly uiNBFFkTpfqYYBjzPgxoiyKQNigQA FNMJsIYcymsJuahkrckLTjpCWbrd; // 0x50
		private readonly qPadcpTaLfEnMsbAwBoWLDhhGLwL MZFdGQgreEpRDfACvtaBAYVHryMl; // 0x58
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x60

		// Properties
		public bool[] QfHOjFpcoFlpvJKhBRdhaliAhqPO { get; } // 0x000000018AB9508C-0x000000018AB950E0 
		public qPadcpTaLfEnMsbAwBoWLDhhGLwL jGYEuXwlDjgLJhkmWOHijeiHfcyj { get; } // 0x0000000182E56440-0x0000000182E56460 

		// Nested types
		public class qPadcpTaLfEnMsbAwBoWLDhhGLwL // TypeDefIndex: 53625
		{
			// Fields
			public float sURegOJXrVrzsRbkTLhQVBuqJVbJ; // 0x10
			public float KNTFhJabRbWgVSMSJojTSthigWSM; // 0x14
			public float MFJjLDiicbnoxXotepspuhOjfNkU; // 0x18
			public float JHOkKToIVVbEcQssxCBAbFteUTkQ; // 0x1C
			public float MPFeHSJixWGHRViAmxtGYsCTbaBS; // 0x20
			public float HzCrJpUKcFwGlBvsIoLvGxAmjbkg; // 0x24
			public float[] tQMFwFExlACgqLBpJkZQHFkqDevy; // 0x28
			public readonly int[] lLFhHhTIlkPPZIEycNsUuGtSyENC; // 0x30
			public readonly bool[] PlahzMFUWWFVTEjviHdVVhgEfBVTb; // 0x38
			public float nMXWZjmUOsgnEDIggCbietHaDulG; // 0x40
			public float gOprXbqeJdcnvaXGWLEibDgUZTTp; // 0x44
			public float TMqorUndAhGVWeuMVKXiERPjxBccB; // 0x48
			public float xaktQtDeBEfMritKatjunUXLFzJm; // 0x4C
			public float JxKRuTpZfeQsRJscQoyeTSMMDVyr; // 0x50
			public float yNsxnEADgrJiFToYaFiqMehPGKtY; // 0x54
			public readonly float[] AcGhvdLAvxSObqgmvUyxoeQwolJC; // 0x58
			public float BWzWpyeMNqZYmsDIwMPxzlcuhgPB; // 0x60
			public float rGayEOeAOdRcJXVXPshqTGsTECXz; // 0x64
			public float CzsOlnRhsuydUyCBYJsEKMxnSWuU; // 0x68
			public float JkeWkKAKZVHbDghQHzvIAJzRJFQr; // 0x6C
			public float rnBVcFvKrCijIJnrgqRPyRGksUrk; // 0x70
			public float WjKqIuLkcYZCvVGSlBrDKElircMK; // 0x74
			public readonly float[] SsvrLLvGhWXUmFhbSkonQzKgpDMg; // 0x78
			public float OnbtdHADzTjroKuJEKWlXSKskARq; // 0x80
			public float SgObdTVqQKDtrHLaAVHQmvwnYBKr; // 0x84
			public float TEtZtVcZmHktppdaeqwMrrbvJCep; // 0x88
			public float ATCfXnEcwrDcbaPXkNvYbBtgJEBeD; // 0x8C
			public float WwzLuDGHSspRHCkpQBHIAOYWUbytA; // 0x90
			public float dbvJIKkVDcPVizpIAbyDQMiNTjRc; // 0x94
			public readonly float[] McibGxihWCRUpJxuGDWxQiSiYGsr; // 0x98

			// Constructors
			public qPadcpTaLfEnMsbAwBoWLDhhGLwL(); // 0x000000018AB964F4-0x000000018AB965F0

			// Methods
			public void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB9699C-0x000000018AB97020
			public void OSNJxVibfKbltujYHkKMLuczmano(qPadcpTaLfEnMsbAwBoWLDhhGLwL param_000734ec); // 0x000000018AB96238-0x000000018AB964F4
			public void OSNJxVibfKbltujYHkKMLuczmano(ref LowLevelInputEvent param_000734ed); // 0x000000018AB95FBC-0x000000018AB96238
			public static void dBLvMPXvSuyuuiBuXDrcyADZkqTA(GPkbBxELmYMSjUedRXbWrnFhNjKFb param_000734ee, double param_000734ef, LowLevelInputEvent param_000734f0); // 0x000000018AB965F0-0x000000018AB9699C
		}

		// Constructors
		public gDyOnIMLNWnkqgMmQAeBaAvbdhUC(uiNBFFkTpfqYYBjzPgxoiyKQNigQA param_000734e3, UpdateLoopSetting param_000734e4); // 0x000000018AB94D70-0x000000018AB94FC8

		// Methods
		public void ZdcGgynytMPTLdLAaWDBvAvTrhqr(); // 0x000000018AB94CF4-0x000000018AB94D70
		public void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018AB95038-0x000000018AB9508C
		public void NpMOgLjaQKghKbXenFQXBkoChQfCA(); // 0x000000018AB94AB4-0x000000018AB94AD0
		public void eTDWPSgpXIMtpgNDkBPsaHTWXrZjA(); // 0x000000018AB94FC8-0x000000018AB94FD4
		public void zdydrJEThCgTgeIKlxbRirIgPrdgB(gDyOnIMLNWnkqgMmQAeBaAvbdhUC param_000734e5); // 0x000000018AB950E0-0x000000018AB95314
		public void MDeYcbIyMBSalXbTMtlcMhwDSLzN(int param_000734e6, int param_000734e7, int param_000734e8, float param_000734e9); // 0x000000018AB94698-0x000000018AB947F8
		private void MKwPGmPNfhFmvlkQlEqXqLOfRmuO(); // 0x000000018AB947F8-0x000000018AB94AB4
		private void QbndUmpgRhLuwkYVaWbOLhdwDFmn(); // 0x000000018AB94AD0-0x000000018AB94BB0
		private void DFzbWQdNlFisggGgVmYILlDdMehP(); // 0x000000018AB94544-0x000000018AB94648
		public void Dispose(); // 0x000000018AB94648-0x000000018AB94698
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB94C80-0x000000018AB94CF4
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000734ea); // 0x000000018AB94BB0-0x000000018AB94C80
		private static float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_000734eb); // 0x000000018AB94FD4-0x000000018AB95038
	}

	private class BxvBxbtXoUKMZoXIzwiATBygTUHp // TypeDefIndex: 53627
	{
		// Fields
		private GPkbBxELmYMSjUedRXbWrnFhNjKFb ZVvGefazKFEfJvZhrrVWcRvWCdYfA; // 0x10
		private moYfWaYUXKQPVKButWaFqbkILmWJ jQASXixBgHBCAhrWYIAqeiyifBoJB; // 0x18
		private int RXjCeDOcXoHTVrUMSSHCSrkfHpbcA; // 0x20
		private int MnmitBGvIjrnpkCEZqtoIvLBYmNk; // 0x24
		private int OcfBcCrOilhOKEbvyAUBldyvZeix; // 0x28
		private float OgWYqWCTenLEOpjhNZRIuPHrfedk; // 0x2C

		// Constructors
		public BxvBxbtXoUKMZoXIzwiATBygTUHp(GPkbBxELmYMSjUedRXbWrnFhNjKFb param_000734f3, int param_000734f4, int param_000734f5, int param_000734f6, float param_000734f7); // 0x000000018AB8BB20-0x000000018AB8BBF4
		private BxvBxbtXoUKMZoXIzwiATBygTUHp(BxvBxbtXoUKMZoXIzwiATBygTUHp param_000734f8, GPkbBxELmYMSjUedRXbWrnFhNjKFb param_000734f9); // 0x000000018AB8BAC0-0x000000018AB8BB20
		private BxvBxbtXoUKMZoXIzwiATBygTUHp(int param_000734fa, int param_000734fb, int param_000734fc, float param_000734fd); // 0x0000000184DA8700-0x0000000184DA8720

		// Methods
		public static BxvBxbtXoUKMZoXIzwiATBygTUHp IrXHgUrWSsnIQwaPDrwiBSQGtsqb(BxvBxbtXoUKMZoXIzwiATBygTUHp param_000734f1, GPkbBxELmYMSjUedRXbWrnFhNjKFb param_000734f2); // 0x000000018AB8B230-0x000000018AB8B2B0
		public void TSexxBoQJJrDUHjAVGegZXOfrqTg(double param_000734fe); // 0x000000018AB8B318-0x000000018AB8BAC0
		public void OSNJxVibfKbltujYHkKMLuczmano(BxvBxbtXoUKMZoXIzwiATBygTUHp param_000734ff); // 0x000000018AB8B2B0-0x000000018AB8B318
		private int CRxcrYSXdAeIdGaifRNOnInpBBEEA(int param_00073500); // 0x000000018AB8B200-0x000000018AB8B230
	}

	private class moYfWaYUXKQPVKButWaFqbkILmWJ // TypeDefIndex: 53628
	{
		// Fields
		private double lUAEUUoQpUIYpeenjLbmfhEDiAseB; // 0x10
		private GPkbBxELmYMSjUedRXbWrnFhNjKFb OJABnLhbzDVhEcYrKINmjpdbHCyqA; // 0x18
		private GPkbBxELmYMSjUedRXbWrnFhNjKFb FQYLmqrQxmFsxalcDmYahFGwtGSG; // 0x20
		private GPkbBxELmYMSjUedRXbWrnFhNjKFb DhmpbxlMAJPehbDzgbrYjAZhBZwO; // 0x28
		private bool umtdXDbMsmMsjQoqzBYBGLjCRMYFb; // 0x30
		private double yZiqePwjyFulOwEtSggCjghUPpyL; // 0x38

		// Properties
		public GPkbBxELmYMSjUedRXbWrnFhNjKFb gRjaLAtCMVhjzRWBefGJYFKGFtTz { get; } // 0x000000018385B100-0x000000018385B110 
		public GPkbBxELmYMSjUedRXbWrnFhNjKFb SfpFEPnmFBoJXZGGXdxZoGVgfNdE { get; } // 0x0000000184D86240-0x0000000184D86250 
		public bool dEQNDwTYiSUzaQMhKLcGEyebeMjl { get; } // 0x0000000184D865F0-0x0000000184D86600 
		public double BumMEmxOGEdtDHGHnQLUdlAZFtbfb { get; } // 0x0000000184D869C0-0x0000000184D869D0 

		// Constructors
		public moYfWaYUXKQPVKButWaFqbkILmWJ(GPkbBxELmYMSjUedRXbWrnFhNjKFb param_00073501); // 0x000000018AB95F1C-0x000000018AB95FBC

		// Methods
		public void TSexxBoQJJrDUHjAVGegZXOfrqTg(double param_00073502); // 0x000000018AB9536C-0x000000018AB95C10
		public void OSNJxVibfKbltujYHkKMLuczmano(moYfWaYUXKQPVKButWaFqbkILmWJ param_00073503); // 0x000000018AB95314-0x000000018AB9536C
		private bool YyFArKHbNSGOJhHdaZgQVmwMGXIIA(); // 0x000000018AB95C10-0x000000018AB95F1C
	}

	private class eChiVyLsHBuxgtuOcCaBRldtIBrcA // TypeDefIndex: 53632
	{
		// Fields
		private List<czRBwkLAZVbFdHFxSnZUYWeXWvaw> kfYfqEcEuytPhEMEULSfGPpdWoee; // 0x10

		// Nested types
		public enum EwgWwCtiGlBzuRFyRHkKucTGHLnd // TypeDefIndex: 53629
		{
			Exact = 0,
			Approximate = 1
		}

		public class czRBwkLAZVbFdHFxSnZUYWeXWvaw // TypeDefIndex: 53630
		{
			// Fields
			public int ZewBubFBTMGdguZhicDjJwXDMzqL; // 0x10
			public Guid RuUyWLJiWbqVBpGrMytXGugwnZGo; // 0x14
			public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x24
			public int JXScdMHyYyhMIpOYqnnMPyDeWaAgA; // 0x34
			public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x38
			public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x3C
			public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x40

			// Constructors
			public czRBwkLAZVbFdHFxSnZUYWeXWvaw(); // 0x00000001841E1670-0x00000001841E1680

			// Methods
			public bool HzPmTNZHjTeMRqJVTLSBKHKRLNFG(SulfOtFmRZnbMqygEpLarHhEkBqj param_0007350a, EwgWwCtiGlBzuRFyRHkKucTGHLnd param_0007350b); // 0x000000018AB93C14-0x000000018AB93D00
			public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB93D00-0x000000018AB93EF0
		}

		[CompilerGenerated]
		private sealed class EDqyHJiteSUNyQddlqqKeGsULmmu : IEnumerable<czRBwkLAZVbFdHFxSnZUYWeXWvaw>, IEnumerator<czRBwkLAZVbFdHFxSnZUYWeXWvaw> // TypeDefIndex: 53631
		{
			// Fields
			private int fYQgehhaxgmucoHwUcKeBQGOPxQf; // 0x10
			private czRBwkLAZVbFdHFxSnZUYWeXWvaw rEnDOlfBAoeCjPebviBVAehVjPn; // 0x18
			private int IZBclvIYPYqsRntRbExTPuWmERphA; // 0x20
			public eChiVyLsHBuxgtuOcCaBRldtIBrcA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x28
			private SulfOtFmRZnbMqygEpLarHhEkBqj PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x30
			public SulfOtFmRZnbMqygEpLarHhEkBqj hisBWedFwfgnWcdvDaDbceiyvEbrc; // 0x38
			private EwgWwCtiGlBzuRFyRHkKucTGHLnd oXtqEqZfQuyKWUrFJKdmMIOQHjsBA; // 0x40
			public EwgWwCtiGlBzuRFyRHkKucTGHLnd MpkzjDbhaZctoAPhNvsdAaUgKnCJ; // 0x44
			private int oqwDyyTMKnSedrldMxUmixFEHvcE; // 0x48
			private int JbCuPbQlPJerRbkBryzmjprgTJnI; // 0x4C

			// Properties
			czRBwkLAZVbFdHFxSnZUYWeXWvaw IEnumerator<Rewired.Platforms.Windows.DirectInputManager.JoystickRecords.Record>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 

			// Constructors
			[DebuggerHidden]
			public EDqyHJiteSUNyQddlqqKeGsULmmu(int param_0007350c); // 0x00000001891B1F10-0x00000001891B1F44

			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AB8C630-0x000000018AB8C728
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AB8C7EC-0x000000018AB8C838
			[DebuggerHidden]
			IEnumerator<czRBwkLAZVbFdHFxSnZUYWeXWvaw> System.Collections.Generic.IEnumerable<Rewired.Platforms.Windows.DirectInputManager.JoystickRecords.Record>.GetEnumerator(); // 0x000000018AB8C728-0x000000018AB8C7E4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AB8C7E4-0x000000018AB8C7EC
		}

		// Constructors
		public eChiVyLsHBuxgtuOcCaBRldtIBrcA(); // 0x000000018AB94018-0x000000018AB94090

		// Methods
		public void oeWKkKFoQYQjZrnTprfFYxpVhrZv(SulfOtFmRZnbMqygEpLarHhEkBqj param_00073504); // 0x000000018AB94090-0x000000018AB9433C
		public IEnumerable<czRBwkLAZVbFdHFxSnZUYWeXWvaw> rPEMzZmJunpFkQUNyRKTxEVSsvJu(SulfOtFmRZnbMqygEpLarHhEkBqj param_00073505, EwgWwCtiGlBzuRFyRHkKucTGHLnd param_00073506); // 0x000000018AB9433C-0x000000018AB943D4
		private void QKCfzjnPNjViQblauEfiHIvbjBzFA(int param_00073507, Guid param_00073508, int param_00073509); // 0x000000018AB93EF0-0x000000018AB94018
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB943D4-0x000000018AB94544
	}

	private class CWHceIMuggmodXXlPmEbtsWTclpk // TypeDefIndex: 53633
	{
		// Fields
		public SulfOtFmRZnbMqygEpLarHhEkBqj MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x10
		public asJwVBrSeOWneGuTCmUUKaDTCXQW xzpxpHzCMniucFvRNnKzdwDjbwZm; // 0x18

		// Properties
		public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x000000018AB8BD08-0x000000018AB8BD1C 

		// Constructors
		public CWHceIMuggmodXXlPmEbtsWTclpk(SulfOtFmRZnbMqygEpLarHhEkBqj param_0007350d, asJwVBrSeOWneGuTCmUUKaDTCXQW param_0007350e); // 0x00000001832AF420-0x00000001832AF450

		// Methods
		public static List<asJwVBrSeOWneGuTCmUUKaDTCXQW> JaBTQnjSbBBdpmjdCKychqOaCHIv(List<CWHceIMuggmodXXlPmEbtsWTclpk> param_0007350f); // 0x000000018AB8BBF4-0x000000018AB8BD08
	}

	private class VtHAKVjbpOKKtQGWBbdqHjKCvTZNc // TypeDefIndex: 53634
	{
		// Fields
		private yqCthwNGAZgagjDBQbkNEzFfVZWu.AInQCDdqSLTTWRljCHGQhayircJNA fulvxOsuIgQbWVavtVKkciNxaCOk; // 0x10
		private yqCthwNGAZgagjDBQbkNEzFfVZWu.ygRJphukthbSeHYUTNVFxMSmRNEw pOMsRKfPsNeBdQopVobDMEckFbRQ; // 0x28
		private NativeBuffer TqBIKkkWuWofFUAnHFfIfgTJhoWF; // 0x68
		private int MKTmWllStazkhRAJmTOHnpRlzbHA; // 0x70

		// Constructors
		public VtHAKVjbpOKKtQGWBbdqHjKCvTZNc(); // 0x000000018AB93AC4-0x000000018AB93C14

		// Methods
		public bool ZDbedOgIzcfMpbVdeWUGCHDtqMPpA(); // 0x000000018AB93AA0-0x000000018AB93AC4
		public void nClbpvjBChWOpZxTrbJuOGSLeVeV(int param_00073510); // 0x0000000184D868D0-0x0000000184D868E0
		private int HAlcbAPlpAGCjaHUimzYPmYgHkkwA(); // 0x000000018AB939E0-0x000000018AB93AA0
	}

	private enum juBleaBZMyhfoVXqEhTgtytcTBnB // TypeDefIndex: 53635
	{
		Device = 17,
		Mouse = 18,
		Keyboard = 19,
		Joystick = 20,
		Gamepad = 21,
		Driving = 22,
		Flight = 23,
		FirstPerson = 24,
		ControlDevice = 25,
		ScreenPointer = 26,
		Remote = 27,
		Supplemental = 28
	}

	// Constructors
	public WtJzdNLrJHyRaJJmBqtOoHCrGIsI(UpdateLoopSetting param_0007348a, hohNsNaAhdJOLmrreLGwwtWoRfkL param_0007348b, IntPtr param_0007348c, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_0007348d, Func<int> param_0007348e); // 0x000000018AB7F6F0-0x000000018AB7FA64

	// Methods
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x000000018AB7EC1C-0x000000018AB7ECDC
	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop); // 0x000000018AB7F444-0x000000018AB7F470
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018AB7F044-0x000000018AB7F1E4
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000184D862A0-0x0000000184D862B0
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x000000018AB7F2C4-0x000000018AB7F444
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x000000018AB7F1E4-0x000000018AB7F220
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x000000018AB7F220-0x000000018AB7F25C
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x00000001811EC580-0x00000001811EC590
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x00000001811EC580-0x00000001811EC590
	private void DEPfegiyDWufXpFoXVnbVBNfCCAaA(); // 0x000000018AB7E33C-0x000000018AB7E478
	private List<CWHceIMuggmodXXlPmEbtsWTclpk> rJoeVQehMPBDLoUINyZoQAIRnqPaA(); // 0x000000018AB8006C-0x000000018AB80E38
	private void jCFYFjuTFHbeymqccTbonOFCiYhaA(); // 0x000000018AB7FD10-0x000000018AB7FD34
	private void IPsKeuhUudiiGzcWoCODIHfxGMbI(List<CWHceIMuggmodXXlPmEbtsWTclpk> param_00073494); // 0x000000018AB7E7C8-0x000000018AB7EC1C
	private void lLDOaYnxEcAvAnjHdbBVPmqDLGQV(SulfOtFmRZnbMqygEpLarHhEkBqj param_00073495, BxcPeTIqLZsfHyGzFAombgJBgOBgA param_00073496, out string param_00073497); // 0x000000018AB7FD54-0x000000018AB7FF44
	private void yJJCtBCrCEsbprFwlpsOnWBkGRvrA(); // 0x000000018AB811AC-0x000000018AB81324
	private IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> mxPGGEbDGwrHhMYjlSXReOlvKYceA(); // 0x000000018AB7FF44-0x000000018AB8006C
	private void kNwsRjzUPqlWAngmSxVsTsQzbnNU(); // 0x000000018AB7FD34-0x000000018AB7FD54
	private void FVpBjAwyGBpVQpbIGUMUuPmYWCYq(int param_00073498, int param_00073499, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_0007349a, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_0007349b); // 0x000000018AB7E480-0x000000018AB7E64C
	private bool ymbuqHxpmIVcyliPHUJTGDZqcnEJA(List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_0007349c, int param_0007349d); // 0x000000018AB81324-0x000000018AB813CC
	private int gYLinYswKgWgjjceGEMBKlqvhlEGb(List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_0007349e); // 0x000000018AB7FB10-0x000000018AB7FBB8
	private bool iXsRWfwjaxOSbFdmAXxVCIUyoIxI(List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_0007349f, int param_000734a0); // 0x000000018AB7FC8C-0x000000018AB7FD10
	private void NQvRARFJpLxdsIUPRkuuXQTUjNox(int param_000734a1, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734a2, int param_000734a3, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734a4, eChiVyLsHBuxgtuOcCaBRldtIBrcA.EwgWwCtiGlBzuRFyRHkKucTGHLnd param_000734a5); // 0x000000018AB7EF00-0x000000018AB7F044
	private void XxteBwdFImtrzajKwxGejbRDStnH(int param_000734a6, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734a7, eChiVyLsHBuxgtuOcCaBRldtIBrcA.EwgWwCtiGlBzuRFyRHkKucTGHLnd param_000734a8); // 0x000000018AB7F470-0x000000018AB7F6F0
	private void aHkOdhJXptAoBHaAPdXpbfyfxpNg(); // 0x000000018AB7FA64-0x000000018AB7FB10
	private void MlGkGyByutorfoeNATowscMEHlCc(); // 0x000000018AB7EE88-0x000000018AB7EF00
	private void HrafxVEiJeftPMWeXgAkqYHrGJCJA(List<CWHceIMuggmodXXlPmEbtsWTclpk> param_000734a9); // 0x000000018AB7E780-0x000000018AB7E7C8
	private bool uRdbjqOsEkXqUsbrHdKhfkfmEUboA(IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> param_000734aa); // 0x000000018AB80E38-0x000000018AB81038
	private bool xcIOtxcgNETqciTqWuRjukkZMnEj(Guid param_000734ab); // 0x000000018AB81038-0x000000018AB811AC
	private bool MUMDpCDwdurISJEJjKWLquYbZQvaA(IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> param_000734ac, Guid param_000734ad); // 0x000000018AB7EDB0-0x000000018AB7EE88
	private void GOiJYHNLShkFyPFsoSQwzPnKQhdP(List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734ae, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734af, bool param_000734b0); // 0x000000018AB7E64C-0x000000018AB7E780
	private void iEEFlbFDszRppifBFnwpNApzASvF(SulfOtFmRZnbMqygEpLarHhEkBqj param_000734b1, bool param_000734b2); // 0x000000018AB7FC2C-0x000000018AB7FC8C
	private bool UXZDQIcBhgpFIozsnuFnGIIstaSK(); // 0x000000018AB7F25C-0x000000018AB7F2C4
	private void KXngRhiuZCfLPeTPuDzRMuTRmSkg(List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734b3, List<SulfOtFmRZnbMqygEpLarHhEkBqj> param_000734b4); // 0x000000018AB7ECDC-0x000000018AB7EDB0
	[CompilerGenerated]
	private List<CWHceIMuggmodXXlPmEbtsWTclpk> FCKqoVPyZlClyKkxbkNXALERJWyi(); // 0x000000018AB7E478-0x000000018AB7E480
}

internal interface rcTfTYAszdSLhBATSedVHksZNKpU // TypeDefIndex: 53637
{
	// Properties
	hohNsNaAhdJOLmrreLGwwtWoRfkL DFsdfJeNLRhTXegkARhhXCEGzBogc { get; set; }
}

internal class CglnwxVZWlSCbdZbtvQjaQfcgbwC : PlatformInputManager, rcTfTYAszdSLhBATSedVHksZNKpU // TypeDefIndex: 53643
{
	// Fields
	private szduZeeDEtcYluGujxaTriOejwKbA raDdjPAASMcdHBzQALvvcmPWsFgHA; // 0x38
	private List<PxbGPiifPxCrzMdPLgUvczDVlANfb> TNqgWuvjBCYgOVCSnGXROLahYyaS; // 0x40
	private int MKTmWllStazkhRAJmTOHnpRlzbHA; // 0x48
	private RKNUDawKxmBeyGORMNgHaWXmcsFA zEXAytyyWNitcOcjHagycmLbyfNAA; // 0x50
	private bool cfphGESIUWUexKePdKQgmqZIAzuX; // 0x58
	private TimerRealTime wWaWwwksTQTvHnUBeDEJNMuWxBRk; // 0x60
	private KSXcWnVJXHdGdcxUNnMBaqHZACuK<bool> FhGwlmAyohKunIJsDMHfhvuKNtyh; // 0x68
	private KSXcWnVJXHdGdcxUNnMBaqHZACuK<bool> bpWAgWERJCRGTleGHHFcPpqVboHEA; // 0x70
	private int vcAwmLOHdmEugfqvnwUmiQAFbqtT; // 0x78
	private int bOoWiMblyRelLegIMmjPksuOjzmvA; // 0x7C
	private ConfigVars citmFSzSlOHbAffiLPaeVitsTcNL; // 0x80
	private hohNsNaAhdJOLmrreLGwwtWoRfkL iCEBYENXkrooMoPlvszKOfnAQAmp; // 0x88
	private Action<int, ControllerDataUpdater> TbbDUoAqMmrcaEjeayEMKHtJzKLe; // 0x90
	private PlatformInputManager DeuaCkgWrfMxvbuXImykIcuYIdCrA; // 0x98
	private readonly ZTnhIRoUwpwDSquXvRdXVrHhmNqH LklBCFfDLkZZHsywfeNyDqZBUGBrb; // 0xA0
	private readonly BGFFhOVnzqjmrCUSbuDuqqEvzAIS iCjoMdgoRounlMfDZaOmdBFCdsJA; // 0xA8
	private readonly bool kjhSBlkCBAvGTQpgbmswmEjFCVgQ; // 0xB0
	private readonly bool zuLGorFNarmUSnCLbtxkvDLJfsJv; // 0xB1
	private readonly bool veQEVObjvuWMFODdJuDvVejvWjFVA; // 0xB2
	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rqAjfzaDytOqusVpXrJowWQXlELt; // 0xB8
	private readonly Func<int> kSPXKdIyXsnUpjQGNfNppmWhLHBd; // 0xC0

	// Properties
	public hohNsNaAhdJOLmrreLGwwtWoRfkL DFsdfJeNLRhTXegkARhhXCEGzBogc { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x000000018AB8C2E4-0x000000018AB8C318
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 

	// Nested types
	private class PxbGPiifPxCrzMdPLgUvczDVlANfb : IInputManagerJoystick // TypeDefIndex: 53638
	{
		// Fields
		private int SAwUWSkGKioQPDUaFBSUbXjjqYIM; // 0x10
		private int JPJrLcYgPhcXVbQwetbymmJfKAmH; // 0x14
		public Guid CxzTsJSuiZuoQzFIXAHesNKBJEGIA; // 0x18
		public string KAhPhNCPIOUGWydRQSumNKzZsKNx; // 0x28
		private readonly xLiBDACQHMkUJDONyqwWiGgepFzkA MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x30
		private readonly Rewired.Platforms.Windows.RawInput.DeviceType OTjLSLUOBvVHaczyFnTXUKxmshUc; // 0x38
		public string rTDvBtbCVHvoCFneOcKfGwPSCvaeA; // 0x40
		public string ZFMfPPlGsRclaQOlhEcmxjLIUoNw; // 0x48
		public string KhYGVTHrwIDzyjLrEqyCyqFYGmisA; // 0x50
		public int mDfvIrfTdctiyDRPfEHZSUBTcTRU; // 0x58
		public int GcDXLONUdcLWGUjNnLEwuJedpMpo; // 0x5C
		public Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x60
		public Guid djMajrdRSJCSddJnrgHcxADPUbjH; // 0x70
		public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x80
		public int bFaTouXVRSbUDxnKoDJaMwjffcUaA; // 0x90
		public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0x94
		public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0x98
		public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x9C
		public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0xA0
		public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0xA4
		public bool mUeuDXVwqxKZvZMHBIDTAvGSqqqp; // 0xA8
		public bool IfcdjuIFoCXolpufCEJxbAlFVrcc; // 0xA9
		public bool lDGUseilaXGQbkQZzhoWsJSOEiWlA; // 0xAA
		public int wmIpsUFSaOewogOkLvkWvhcvIkdx; // 0xAC
		private float[] WfmlOHFCVeUNZVCPhDBiDsPajnMg; // 0xB0
		private float[] yyCeayeEvvFNGKjODQMmSEtKmaSuA; // 0xB8
		private bool[] noPRYRxTAeWhQaIlmSTYqrgmrmuC; // 0xC0
		private HardwareJoystickMap_InputManager CYjJHFxAtePWANrtsNPovmhwWUDX; // 0xC8
		private lDcxHnYDfFcPYdZdkSWGiPhmdwgmA GXwkpZqsqVjgssnWaZYMOwEVPzGj; // 0xD0
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0xD8
		private bool nBhrPsWcWrCUgCUSDZmuJHYHdMDR; // 0xE0
		private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0xE1
		[CompilerGenerated]
		private Rewired.Controller.Extension ZZNbPgECnscaJlWQDXZbQJUjJQXeb; // 0xE8
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xF0

		// Properties
		public bool VBrZBfLiMVfMwGbjjNpXHBaikpHtA { get; } // 0x000000018AB8DCC8-0x000000018AB8DCEC 
		[CustomObfuscation(rename = false)]
		public int rewiredId { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		[CustomObfuscation(rename = false)]
		public int inputManagerId { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		[CustomObfuscation(rename = false)]
		public string name { get; } // 0x000000018AB8E584-0x000000018AB8E5E8 
		[CustomObfuscation(rename = false)]
		public long? systemId { get; } // 0x000000018AB8E5E8-0x000000018AB8E648 
		[CustomObfuscation(rename = false)]
		public int unityId { get; } // 0x00000001811EC580-0x00000001811EC590 
		[CustomObfuscation(rename = false)]
		public Rewired.Controller.Extension extension { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		[CustomObfuscation(rename = false)]
		public Guid instanceGuid { get; } // 0x0000000184DA1280-0x0000000184DA1290 
		[CustomObfuscation(rename = false)]
		public Guid persistentGuid { get; } // 0x0000000184DA1280-0x0000000184DA1290 
		public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x000000018AB8F5F8-0x000000018AB8F654 

		// Constructors
		public PxbGPiifPxCrzMdPLgUvczDVlANfb(xLiBDACQHMkUJDONyqwWiGgepFzkA param_00073543, Rewired.Platforms.Windows.RawInput.DeviceType param_00073544, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_00073545); // 0x000000018AB8E254-0x000000018AB8E290

		// Methods
		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex); // 0x000000018AB8DDB0-0x000000018AB8DDB8
		[CustomObfuscation(rename = false)]
		public void StopVibration(); // 0x000000018AB8DDB0-0x000000018AB8DDB8
		public void pYQRzXnykRQYsfpIPhseqdKvyUyv(); // 0x000000018AB8EE68-0x000000018AB8F210
		public void zdydrJEThCgTgeIKlxbRirIgPrdgB(PxbGPiifPxCrzMdPLgUvczDVlANfb param_00073546); // 0x000000018AB8F494-0x000000018AB8F5F8
		[CustomObfuscation(rename = false)]
		public void Update(); // 0x000000018AB8DFD8-0x000000018AB8E050
		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018AB8D14C-0x000000018AB8D320
		public int HzPmTNZHjTeMRqJVTLSBKHKRLNFG(PxbGPiifPxCrzMdPLgUvczDVlANfb param_00073548); // 0x000000018AB8D76C-0x000000018AB8D87C
		private BridgedControllerHWInfo QaexLfVSNbNHhboOvHEvgYdhcbmt(); // 0x000000018AB8DCEC-0x000000018AB8DD4C
		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController(); // 0x000000018AB8DEA0-0x000000018AB8DF14
		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x000000018AB8DF14-0x000000018AB8DF78
		private void NkoqbCbQUJeDuCjzLLadeyqGfntS(bool[] param_00073549, int[] param_0007354a); // 0x000000018AB8D9CC-0x000000018AB8DC1C
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(bool[] param_0007354b, int[] param_0007354c); // 0x000000018AB8F244-0x000000018AB8F494
		private void UxgsasKuGqopgQwFFISfZULSApaI(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_0007354d, int param_0007354e, bool[] param_0007354f, int[] param_00073550); // 0x000000018AB8E050-0x000000018AB8E138
		private void SlxylFVFbDNoNznWgcjBPYhvekkC(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_00073551, int param_00073552, bool[] param_00073553, int[] param_00073554); // 0x000000018AB8DDB8-0x000000018AB8DEA0
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_00073555, bool[] param_00073556, int[] param_00073557); // 0x000000018AB8CE9C-0x000000018AB8D14C
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(RawInputAxis param_00073558, int param_00073559); // 0x000000018AB8CE00-0x000000018AB8CE9C
		private float lrsQAhdkMHwMfBaOmoegOfkmAFnX(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_0007355a, bool[] param_0007355b, int[] param_0007355c); // 0x000000018AB8E648-0x000000018AB8EAF4
		private float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_0007355d); // 0x000000018AB7AE68-0x000000018AB7AECC
		private float nRdiXbbkJNZLWvmBZlGjEqPPBccI(int param_0007355e, int param_0007355f, HatType param_00073560); // 0x000000018AB8EAF4-0x000000018AB8EB98
		private float mSxgldHAJNIiJDyPeUSIRNKVYLSqb(int param_00073561, Rewired.Data.Mapping.AxisDirection param_00073562); // 0x000000018AB842E0-0x000000018AB8432C
		private bool ayhGxgprMQKavcwPaVdDMAlZHPYJA(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00073563, bool[] param_00073564, out bool param_00073565); // 0x000000018AB8E290-0x000000018AB8E2E4
		private bool HzedpnOvqgcpdOxXJbSnaXeBYtlB(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00073566, out float param_00073567); // 0x000000018AB8D87C-0x000000018AB8D9CC
		private ControlDeviceType tbUQUTrHHWYRlFppEIFXxsXtwdjj(Rewired.Platforms.Windows.RawInput.DeviceType param_00073568); // 0x000000018AB8F210-0x000000018AB8F244
		private void YgVreXzRuVMyEnzJNolFgafTdbgi(HardwareJoystickMap.Platform_InternalDriver_Base.Axis param_00073569, int param_0007356a, bool[] param_0007356b, int[] param_0007356c); // 0x000000018AB8E138-0x000000018AB8E220
		private void dtpcfzcngDzdaNFxelIKbvnHWQClB(HardwareJoystickMap.Platform_InternalDriver_Base.Button param_0007356d, int param_0007356e, bool[] param_0007356f, int[] param_00073570); // 0x000000018AB8E2E4-0x000000018AB8E3CC
		private float ffZfMlwjEvamNEuFvkRdqoFSmZcB(HardwareJoystickMap.Platform_InternalDriver_Base.Axis param_00073571, bool[] param_00073572, int[] param_00073573); // 0x000000018AB8E3CC-0x000000018AB8E510
		private float ffZfMlwjEvamNEuFvkRdqoFSmZcB(int param_00073574); // 0x000000018AB8E510-0x000000018AB8E584
		private float HImmtwjBFrEzqRHITHaMZgiqcwJj(HardwareJoystickMap.Platform_InternalDriver_Base.Button param_00073575, bool[] param_00073576, int[] param_00073577); // 0x000000018AB8D514-0x000000018AB8D76C
		private void ODjDNosGTVTcApOFJHPRXXJKAaMW(); // 0x000000018AB8DC1C-0x000000018AB8DCC8
		private string GjijczTURIgZZpyFRyfwxQetRhHD(); // 0x000000018AB8D320-0x000000018AB8D514
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedControllerHWInfo param_00073578); // 0x000000018AB8ED04-0x000000018AB8EE68
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedController param_00073579); // 0x000000018AB8EB98-0x000000018AB8ED04
		private UnknownControllerHat[] AksIjPlBzYIerpYGUHpsdbhDSeVW(); // 0x000000018AB8CC40-0x000000018AB8CE00
		public void SbYVTdmkPElTDzeOGdijEuqHpCge(); // 0x000000018AB8DD4C-0x000000018AB8DD9C
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB8DF78-0x000000018AB8DFD8
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007357a); // 0x000000018AB8DD9C-0x000000018AB8DDB0
		public static int PUwZSLuKHRgBeBIdtZbaoZgHIMdBA(PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007357b, PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007357c); // 0x000000018AB0699C-0x000000018AB069CC
		public static int ZTOwqxDJXpohSLyPoOMAhofMtKMo(PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007357d, PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007357e); // 0x000000018AB8E220-0x000000018AB8E254
	}

	private class RKNUDawKxmBeyGORMNgHaWXmcsFA // TypeDefIndex: 53642
	{
		// Fields
		private List<ErZxzAZcIFIVCGSUxzwfPTRZoOVFb> kfYfqEcEuytPhEMEULSfGPpdWoee; // 0x10

		// Nested types
		public enum FmTWaQOirJtdWziXjRJqyKFwvqKM // TypeDefIndex: 53639
		{
			Exact = 0,
			Approximate = 1
		}

		public class ErZxzAZcIFIVCGSUxzwfPTRZoOVFb // TypeDefIndex: 53640
		{
			// Fields
			public int ZewBubFBTMGdguZhicDjJwXDMzqL; // 0x10
			public Guid RuUyWLJiWbqVBpGrMytXGugwnZGo; // 0x14
			public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x24
			public int JXScdMHyYyhMIpOYqnnMPyDeWaAgA; // 0x34
			public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x38
			public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x3C
			public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x40
			public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0x44
			public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0x48
			public bool VBrZBfLiMVfMwGbjjNpXHBaikpHtA; // 0x4C

			// Constructors
			public ErZxzAZcIFIVCGSUxzwfPTRZoOVFb(); // 0x00000001841E1670-0x00000001841E1680

			// Methods
			public bool HzPmTNZHjTeMRqJVTLSBKHKRLNFG(PxbGPiifPxCrzMdPLgUvczDVlANfb param_00073585, FmTWaQOirJtdWziXjRJqyKFwvqKM param_00073586); // 0x000000018AB8C838-0x000000018AB8C984
			public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB8C984-0x000000018AB8CC40
		}

		[CompilerGenerated]
		private sealed class UIHORvOvhYWHLbqIdGNdwtFeejlF : IEnumerable<ErZxzAZcIFIVCGSUxzwfPTRZoOVFb>, IEnumerator<ErZxzAZcIFIVCGSUxzwfPTRZoOVFb> // TypeDefIndex: 53641
		{
			// Fields
			private int fYQgehhaxgmucoHwUcKeBQGOPxQf; // 0x10
			private ErZxzAZcIFIVCGSUxzwfPTRZoOVFb rEnDOlfBAoeCjPebviBVAehVjPn; // 0x18
			private int IZBclvIYPYqsRntRbExTPuWmERphA; // 0x20
			public RKNUDawKxmBeyGORMNgHaWXmcsFA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x28
			private PxbGPiifPxCrzMdPLgUvczDVlANfb PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x30
			public PxbGPiifPxCrzMdPLgUvczDVlANfb hisBWedFwfgnWcdvDaDbceiyvEbrc; // 0x38
			private FmTWaQOirJtdWziXjRJqyKFwvqKM oXtqEqZfQuyKWUrFJKdmMIOQHjsBA; // 0x40
			public FmTWaQOirJtdWziXjRJqyKFwvqKM MpkzjDbhaZctoAPhNvsdAaUgKnCJ; // 0x44
			private int oqwDyyTMKnSedrldMxUmixFEHvcE; // 0x48
			private int JbCuPbQlPJerRbkBryzmjprgTJnI; // 0x4C

			// Properties
			ErZxzAZcIFIVCGSUxzwfPTRZoOVFb IEnumerator<Rewired.Platforms.Windows.RawInputManager.JoystickRecords.Record>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 

			// Constructors
			[DebuggerHidden]
			public UIHORvOvhYWHLbqIdGNdwtFeejlF(int param_00073587); // 0x00000001891B1F10-0x00000001891B1F44

			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AB936E4-0x000000018AB937DC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AB938A0-0x000000018AB938EC
			[DebuggerHidden]
			IEnumerator<ErZxzAZcIFIVCGSUxzwfPTRZoOVFb> System.Collections.Generic.IEnumerable<Rewired.Platforms.Windows.RawInputManager.JoystickRecords.Record>.GetEnumerator(); // 0x000000018AB937DC-0x000000018AB93898
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AB93898-0x000000018AB938A0
		}

		// Constructors
		public RKNUDawKxmBeyGORMNgHaWXmcsFA(); // 0x00000001841D2A20-0x00000001841D2AA0

		// Methods
		public void oeWKkKFoQYQjZrnTprfFYxpVhrZv(PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007357f); // 0x000000018AB908F0-0x000000018AB90C50
		public IEnumerable<ErZxzAZcIFIVCGSUxzwfPTRZoOVFb> rPEMzZmJunpFkQUNyRKTxEVSsvJu(PxbGPiifPxCrzMdPLgUvczDVlANfb param_00073580, FmTWaQOirJtdWziXjRJqyKFwvqKM param_00073581); // 0x000000018AB90C50-0x000000018AB90CE8
		private void QKCfzjnPNjViQblauEfiHIvbjBzFA(int param_00073582, Guid param_00073583, int param_00073584); // 0x000000018AB907C8-0x000000018AB908F0
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB90CE8-0x000000018AB90E58
	}

	// Constructors
	public CglnwxVZWlSCbdZbtvQjaQfcgbwC(ConfigVars param_00073513, hohNsNaAhdJOLmrreLGwwtWoRfkL param_00073514, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_00073515, Func<int> param_00073516, bool param_00073517, bool param_00073518, bool param_00073519, bool param_0007351a); // 0x0000000183B22E60-0x0000000183B231F0

	// Methods
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x00000001841D2820-0x00000001841D28F0
	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop); // 0x0000000183302D30-0x0000000183303040
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018AB8BF54-0x000000018AB8C080
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000184D86220-0x0000000184D86230
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x000000018AB8C1D0-0x000000018AB8C2D8
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x000000018AB8C080-0x000000018AB8C128
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x000000018AB8C128-0x000000018AB8C1D0
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x0000000184D86210-0x0000000184D86220
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x0000000184D86290-0x0000000184D862A0
	public void AHVmwAdwlooYvXMzczUiicdmJSfj(pHOXMyaEVxLmIeQfiMyGgXRiPlXo param_00073520, DKfdSpPOsWGnACTRAulCFEVLxkQk param_00073521); // 0x00000001841E1670-0x00000001841E1680
	private void DEPfegiyDWufXpFoXVnbVBNfCCAaA(); // 0x0000000183303E50-0x0000000183303F70
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(); // 0x00000001841D28F0-0x00000001841D2920
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(IList<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_00073522); // 0x00000001841D2EC0-0x00000001841D3100
	private void yJJCtBCrCEsbprFwlpsOnWBkGRvrA(); // 0x0000000183303040-0x0000000183303070
	private IList<xLiBDACQHMkUJDONyqwWiGgepFzkA> AlkKsBlkcKIlWhlVuLZJCJDXfHCgb(); // 0x00000001841D2980-0x00000001841D29D0
	private void FVpBjAwyGBpVQpbIGUMUuPmYWCYq(int param_00073523, int param_00073524, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073525, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073526); // 0x00000001841D3190-0x00000001841D32A0
	private bool ymbuqHxpmIVcyliPHUJTGDZqcnEJA(List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073527, int param_00073528); // 0x000000018AB8C588-0x000000018AB8C630
	private int gYLinYswKgWgjjceGEMBKlqvhlEGb(List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073529); // 0x000000018AB8C318-0x000000018AB8C3C0
	private bool iXsRWfwjaxOSbFdmAXxVCIUyoIxI(List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_0007352a, int param_0007352b); // 0x000000018AB8C420-0x000000018AB8C4A4
	private void NQvRARFJpLxdsIUPRkuuXQTUjNox(int param_0007352c, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_0007352d, int param_0007352e, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_0007352f, RKNUDawKxmBeyGORMNgHaWXmcsFA.FmTWaQOirJtdWziXjRJqyKFwvqKM param_00073530); // 0x000000018AB8BE10-0x000000018AB8BF54
	private void XxteBwdFImtrzajKwxGejbRDStnH(int param_00073531, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073532, RKNUDawKxmBeyGORMNgHaWXmcsFA.FmTWaQOirJtdWziXjRJqyKFwvqKM param_00073533); // 0x00000001841D32A0-0x00000001841D3590
	private void wuwoBlIQSdpATYAkogxOgHQdPIGeb(); // 0x0000000183303810-0x00000001833038A0
	private void uRznQxjfiWWMZRqOxDNKGnVpQTMc(); // 0x0000000184CC8380-0x0000000184CC8400
	private void HrafxVEiJeftPMWeXgAkqYHrGJCJA(); // 0x00000001841D2920-0x00000001841D2980
	private bool uRdbjqOsEkXqUsbrHdKhfkfmEUboA(IList<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_00073534); // 0x00000001841D2AA0-0x00000001841D2B70
	private bool xcIOtxcgNETqciTqWuRjukkZMnEj(Guid param_00073535); // 0x000000018AB8C4A4-0x000000018AB8C588
	private bool MUMDpCDwdurISJEJjKWLquYbZQvaA(IList<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_00073536, Guid param_00073537); // 0x000000018AB8BD1C-0x000000018AB8BE10
	private void GOiJYHNLShkFyPFsoSQwzPnKQhdP(List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073538, List<PxbGPiifPxCrzMdPLgUvczDVlANfb> param_00073539, bool param_0007353a); // 0x00000001841D3100-0x00000001841D3190
	private void iEEFlbFDszRppifBFnwpNApzASvF(PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007353b, bool param_0007353c); // 0x000000018AB8C3C0-0x000000018AB8C420
	private bool UXZDQIcBhgpFIozsnuFnGIIstaSK(); // 0x00000001836A84D0-0x00000001836A8550
	[CompilerGenerated]
	private void XdapwZNFbbGysrosccuORCsvJbzL(PxbGPiifPxCrzMdPLgUvczDVlANfb param_0007353d); // 0x000000018AB8C2D8-0x000000018AB8C2E4
}

internal class SFgaCJttxzkGcFYzwaMzNZCZlvVR : IDisposable, JtAgsvgsGMTkkHyzazJahvxjADso // TypeDefIndex: 53646
{
	// Fields
	private Action<EventArgs> hmPKQquIKQcgDqSZKWmeysdWPrIQ; // 0x10
	private Action<EventArgs> NgDJTKplpOgcBpNQQTfUAgohNOBc; // 0x18
	private Action<EventArgs> DbcjLGwJvBYsqDsZXeSzHkujkpZT; // 0x20
	private Action<pHOXMyaEVxLmIeQfiMyGgXRiPlXo, DKfdSpPOsWGnACTRAulCFEVLxkQk> aBjHpZEbLETzQNfsPBpfPrHkWnek; // 0x28
	private IntPtr DfIfAOBqJkQxqDvUSJZxUOsWUpHuA; // 0x30
	private giqbwdSVuzgXFgkujBcrjDMNLMUiA SDVdnXploBbNNyRiOWqovdozIfbp; // 0x38
	private readonly bool EpOeYAUynWpraRsJhsuccrAMFAku; // 0x40
	private static VAmVuDvNsSbewEPAcnmMyxvuGlBo DlVfonkCLHlAIUPkTSWJWMBCkCdu; // 0x00
	private giqbwdSVuzgXFgkujBcrjDMNLMUiA LYLonkEAxeGqnGJKwEcVxHyBGYZl; // 0x48
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x50

	// Properties
	public IntPtr jhGooCbTTXmgjsKnAiicIgjWqgcZ { get; } // 0x00000001811F36E0-0x00000001811F36F0 

	// Events
	public event Action<EventArgs> vrsKYxMgJTEgnNvuckTBQHVDBKDX {
		add; // 0x0000000184D28DE0-0x0000000184D28E60
		remove; // 0x000000018AB90EA8-0x000000018AB90F1C
	}
	public event Action<EventArgs> cquFiigoGXXxfjEUDiFhIXaBAHsbc {
		add; // 0x0000000184D28E60-0x0000000184D28EE0
		remove; // 0x000000018AB91088-0x000000018AB910FC
	}
	public event Action<pHOXMyaEVxLmIeQfiMyGgXRiPlXo, DKfdSpPOsWGnACTRAulCFEVLxkQk> JROnXTQaaJtvBkshGaaOAimJzdDF {
		add; // 0x00000001842B3840-0x00000001842B38C0
		remove; // 0x000000018AB911A0-0x000000018AB91214
	}

	// Nested types
	private static class UJCWqnlSpSvfQHdvPoivYjJYtQHW // TypeDefIndex: 53645
	{
		// Fields
		private static readonly Guid EAIQbJjDzNjcGpNCLRjxJueXlHCA; // 0x00
		private static IntPtr xRUZUbqxxvJDAfAqvHMkPpHiAWfM; // 0x10
		private static bool DBdtoiVyEGkaNDgREajgdtJVFTel; // 0x18

		// Nested types
		private struct GvYoLHQmSORCWetxVpMnfROwMpIc // TypeDefIndex: 53644
		{
			// Fields
			internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
			internal int psAUfTCmGaZDidaHRsWjLEaznECN; // 0x04
			internal int uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x08
			internal Guid TFCmbGedgzeEcgpGHSjcgbdJTGwQ; // 0x0C
			internal short cJMYRUIePewENzlebCoKsxxPfeZBA; // 0x1C
		}

		// Constructors
		static UJCWqnlSpSvfQHdvPoivYjJYtQHW(); // 0x0000000184D34880-0x0000000184D348F0

		// Methods
		public static void tscEVGhIvqCFhbiZeiWxJXMsRhMpc(IntPtr param_0007359b); // 0x0000000183BFB6A0-0x0000000183BFB810
		public static void VQMkIkdFLlhIXJamcwSQuVuyGEHAA(); // 0x000000018AB93968-0x000000018AB939E0
		private static extern IntPtr xfalHHTnWKkVEbZkQDHVEtChhLEd(IntPtr param_0007359c, IntPtr param_0007359d, int param_0007359e); // 0x0000000183826940-0x00000001838269F0
		private static extern bool RVmlmapDJpsIVotlwQOKvDxYEDPx(IntPtr param_0007359f); // 0x000000018AB938EC-0x000000018AB93968
	}

	// Constructors
	public SFgaCJttxzkGcFYzwaMzNZCZlvVR(); // 0x0000000183BF5480-0x0000000183BF54E0

	// Methods
	public void hoAhQOJWtqQFplfEKzOAsAgxjDsK(); // 0x000000018AB91198-0x000000018AB911A0
	private void DKVpNyqREOIVACgmSVaaAXYjPvP(); // 0x0000000183BF54E0-0x0000000183BF5550
	public void Dispose(); // 0x000000018AB90E58-0x000000018AB90EA8
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB90FD4-0x000000018AB91048
	private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007358e); // 0x000000018AB90F1C-0x000000018AB90FD4
	private void tscEVGhIvqCFhbiZeiWxJXMsRhMpc(); // 0x0000000183BF5550-0x0000000183BF55A0
	private void VQMkIkdFLlhIXJamcwSQuVuyGEHAA(); // 0x000000018AB91048-0x000000018AB91088
	private void gHAhDhvboplanFMdirgphWMRDVvf(aPUzMfNhVBeTKbkRTCyfUbYiSBad param_0007358f, pHOXMyaEVxLmIeQfiMyGgXRiPlXo param_00073590, uint param_00073591, IntPtr param_00073592); // 0x0000000184701490-0x00000001847014E0
	private void adICXhsRwpmheobRAgzuZkLsiSDgA(aPUzMfNhVBeTKbkRTCyfUbYiSBad param_00073593, pHOXMyaEVxLmIeQfiMyGgXRiPlXo param_00073594, uint param_00073595, IntPtr param_00073596); // 0x000000018AB910FC-0x000000018AB91198
	private void gRrCsHGsATbPYlAbVLUMxHXddIOO(); // 0x0000000183BF55A0-0x0000000183BF56F0
	private IntPtr CUiCXilpJQfklcGwLpIgKHqaNvEaA(IntPtr param_00073597, uint param_00073598, IntPtr param_00073599, IntPtr param_0007359a); // 0x00000001847013B0-0x0000000184701490
}

internal enum TIWOKdoJCWhTsnGfcCDaEsbLDNXvA // TypeDefIndex: 53647
{
	None = 0,
	XInput = 1,
	WindowsGamingInput = 2
}

internal class QMheRbslqkBZlcuHvVkfPGPGEfzr : PlatformInputManager, INativePlatformHelper // TypeDefIndex: 53655
{
	// Fields
	private bool YcrITPRQcuWnqpkOKTEheFfNkewS; // 0x38
	private SFgaCJttxzkGcFYzwaMzNZCZlvVR HzsmPchstSWQMzZvBAnNSGtXEzIu; // 0x40
	private IndexedDictionary<int, PlatformInputManager> taEiJPAqHOSkiMwbenFqQQlSxGsUA; // 0x48
	private OjhuiYfsQLjmDSLAdjapFDDYOHRBb EKNARvXrCyOJgmXcUIsHKTEjuzOR; // 0x50
	private Action<int, ControllerDataUpdater> TbbDUoAqMmrcaEjeayEMKHtJzKLe; // 0x58
	private WindowsStandalonePrimaryInputSource lyRxbSDKpHAjlpBYKuHtOdRgqHCC; // 0x60
	private PlatformInputManager DeuaCkgWrfMxvbuXImykIcuYIdCrA; // 0x68
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rqAjfzaDytOqusVpXrJowWQXlELt; // 0x70
	private Func<int> kSPXKdIyXsnUpjQGNfNppmWhLHBd; // 0x78
	private Func<PidVid, bool> EghWguErCSSlckfDqyUkzauWdIqGA; // 0x80

	// Properties
	bool INativePlatformHelper.isApplicationFocused { get; } // 0x000000018AB8FA4C-0x000000018AB8FAA0 
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x000000018AB903E4-0x000000018AB90404 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000184D86230-0x0000000184D86240 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x000000018AB9042C-0x000000018AB90450 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x000000018AB90404-0x000000018AB9042C 

	// Nested types
	private class OjhuiYfsQLjmDSLAdjapFDDYOHRBb // TypeDefIndex: 53651
	{
		// Fields
		private List<efXfIrYwGgwWZENBhiBIZMlcwsPL> JRjGAFFeszLfkxHmZNROumymdhzab; // 0x10
		private List<efXfIrYwGgwWZENBhiBIZMlcwsPL> vtZNTrudViWSRdoVTYWrGMXPdKWH; // 0x18

		// Properties
		public int PccjpnFaoYhHAJKoTXLipsqIJYbNA { get; } // 0x000000018AB9C748-0x000000018AB9C788 

		// Nested types
		private class efXfIrYwGgwWZENBhiBIZMlcwsPL // TypeDefIndex: 53648
		{
			// Fields
			public int TeGggniDTQNkpisBJPYzTqcoaVTac; // 0x10
			public int zFNdXazNWFUglfCzNmWRYOgTPXRI; // 0x14
			public int cBDCwQHjFWirLYoJqMgewlcyrJze; // 0x18
			public InputSource FNMJsIYcymsJuahkrckLTjpCWbrd; // 0x1C

			// Constructors
			public efXfIrYwGgwWZENBhiBIZMlcwsPL(int param_000735ca, int param_000735cb, int param_000735cc, InputSource param_000735cd); // 0x0000000184D8B5C0-0x0000000184D8B5E0

			// Methods
			public void TSexxBoQJJrDUHjAVGegZXOfrqTg(int param_000735ce); // 0x0000000184D8F540-0x0000000184D8F550
			public JmOnMqPORAhpavOGVQqoHmIzbKer DlvAJqBRaezRrHrnhRqNeBSpMxlcb(); // 0x0000000184DA8780-0x0000000184DA87A0
			public static int vAOObLSXCKvyKsGRHaITynPBIZMDA(efXfIrYwGgwWZENBhiBIZMlcwsPL param_000735cf, efXfIrYwGgwWZENBhiBIZMlcwsPL param_000735d0); // 0x000000018AB9DF64-0x000000018AB9DF94
		}

		public struct JmOnMqPORAhpavOGVQqoHmIzbKer // TypeDefIndex: 53649
		{
			// Fields
			public int TeGggniDTQNkpisBJPYzTqcoaVTac; // 0x00
			public int zFNdXazNWFUglfCzNmWRYOgTPXRI; // 0x04
			public InputSource FNMJsIYcymsJuahkrckLTjpCWbrd; // 0x08

			// Constructors
			public JmOnMqPORAhpavOGVQqoHmIzbKer(int param_000735d1, int param_000735d2, InputSource param_000735d3); // 0x0000000184D85D60-0x0000000184D85D70
		}

		public enum WpYNjEPAKakeDWMSOucJXqQlqdLd // TypeDefIndex: 53650
		{
			Connected = 0,
			Disconnected = 1
		}

		// Constructors
		public OjhuiYfsQLjmDSLAdjapFDDYOHRBb(); // 0x00000001849C6EA0-0x00000001849C6F50

		// Methods
		public void OZCBlnzMtFganGWISuWvvUlyprPC(BridgedController param_000735bb); // 0x000000018AB9C240-0x000000018AB9C50C
		public void tBTioINkucxScUwASwBBarBdIFSj(ControllerDisconnectedEventArgs param_000735bc); // 0x000000018AB9C82C-0x000000018AB9C910
		public void NXaZKluUuIoYHzLyQyTRqDfQVaZf(int param_000735bd, int param_000735be); // 0x000000018AB9C1A8-0x000000018AB9C240
		public int PAAHqPJeiyimprjSbjbBBdnBTcrPA(int param_000735bf, WpYNjEPAKakeDWMSOucJXqQlqdLd param_000735c0); // 0x000000018AB9C50C-0x000000018AB9C5F4
		public int PAAHqPJeiyimprjSbjbBBdnBTcrPA(int param_000735c1, InputSource param_000735c2, WpYNjEPAKakeDWMSOucJXqQlqdLd param_000735c3); // 0x000000018AB9C5F4-0x000000018AB9C748
		public JmOnMqPORAhpavOGVQqoHmIzbKer DlvAJqBRaezRrHrnhRqNeBSpMxlcb(int param_000735c4, WpYNjEPAKakeDWMSOucJXqQlqdLd param_000735c5); // 0x000000018AB9BF1C-0x000000018AB9C064
		public int inFWSzNpuekzleFvGRxGWwlgpcud(int param_000735c6, InputSource param_000735c7, WpYNjEPAKakeDWMSOucJXqQlqdLd param_000735c8); // 0x000000018AB9C788-0x000000018AB9C82C
		private int KiTfWzJBJqzNIuIFWrKfUsLPQmMi(int param_000735c9); // 0x000000018AB9C064-0x000000018AB9C108
		private int KiTfWzJBJqzNIuIFWrKfUsLPQmMi(); // 0x000000018AB9C108-0x000000018AB9C1A8
	}

	private class MOICKaGpxhWtyBLVQTNrFLXoTHai : IInputManagerJoystickPublic, ITryGetLocalizedName // TypeDefIndex: 53652
	{
		// Fields
		private IInputManagerJoystickPublic boNDKtEvtQnFljhvyLYTzMMSWoS; // 0x10
		private int bbeMguIoqGgoxHrJvkGVmHAhtZzd; // 0x18

		// Properties
		public int rewiredId { get; } // 0x000000018AB9B9C0-0x000000018AB9B9E0 
		public int inputManagerId { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public string name { get; } // 0x000000018AB9B978-0x000000018AB9B998 
		public long? systemId { get; } // 0x000000018AB9B9E0-0x000000018AB9BA14 
		public int unityId { get; } // 0x000000018AB9BA14-0x000000018AB9BA34 
		public Guid instanceGuid { get; } // 0x000000018AB9B944-0x000000018AB9B978 
		public Guid persistentGuid { get; } // 0x000000018AB9B998-0x000000018AB9B9C0 
		public Rewired.Controller.Extension extension { get; } // 0x000000018AB9B924-0x000000018AB9B944 

		// Constructors
		public MOICKaGpxhWtyBLVQTNrFLXoTHai(IInputManagerJoystickPublic param_000735d4, int param_000735d5); // 0x0000000183B46FF0-0x0000000183B47040

		// Methods
		public void SetVibration(float amount, int motorIndex); // 0x000000018AB9B8E4-0x000000018AB9B904
		public void StopVibration(); // 0x000000018AB9B904-0x000000018AB9B924
		bool ITryGetLocalizedName.TryGetLocalizedName(out string value); // 0x000000018AB9B878-0x000000018AB9B8E4
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class xDaNoTWqRzaXePepUJIfmnHocbzE // TypeDefIndex: 53653
	{
		// Fields
		public static readonly xDaNoTWqRzaXePepUJIfmnHocbzE __9; // 0x00
		public static Func<PidVid, bool> __9__17_0; // 0x08

		// Constructors
		static xDaNoTWqRzaXePepUJIfmnHocbzE(); // 0x0000000184D3E710-0x0000000184D3E770
		public xDaNoTWqRzaXePepUJIfmnHocbzE(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal bool lcdMiOnjTsbvXlAFgCwAjwxkKGhl(PidVid param_000735d9); // 0x00000001812081B0-0x0000000181208610
	}

	[CompilerGenerated]
	private sealed class GsijRuvKOdohGPGwIUDMBGivUqZT // TypeDefIndex: 53654
	{
		// Fields
		public int JMfmsMjVGQYxGgCzcDcKvsjFwVVL; // 0x10

		// Constructors
		public GsijRuvKOdohGPGwIUDMBGivUqZT(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal int cLSxpZjiwLJISBrvozGPqmqxDyxE(); // 0x0000000184DA8760-0x0000000184DA8770
	}

	// Constructors
	public QMheRbslqkBZlcuHvVkfPGPGEfzr(ConfigVars param_000735a0, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_000735a1, Func<int> param_000735a2); // 0x000000018381B2A0-0x000000018381B800

	// Methods
	private bool aHosPjIAvHmlXZuwUhZPsSekcjGC(ConfigVars param_000735a3, SFgaCJttxzkGcFYzwaMzNZCZlvVR param_000735a4, hohNsNaAhdJOLmrreLGwwtWoRfkL param_000735a5); // 0x000000018AB8FF5C-0x000000018AB903E4
	private bool UeLqBvBNkQlZqKYlUUKRAMtSJomV(ConfigVars param_000735a6, SFgaCJttxzkGcFYzwaMzNZCZlvVR param_000735a7, hohNsNaAhdJOLmrreLGwwtWoRfkL param_000735a8); // 0x00000001842B45E0-0x00000001842B4890
	private bool LyWQtJmOztptvRAPOQWGRyIvAPoe(ConfigVars param_000735a9, SFgaCJttxzkGcFYzwaMzNZCZlvVR param_000735aa); // 0x000000018AB8F654-0x000000018AB8F978
	private bool MZKABNiBJRYKtiMMxZrpaOzxECViA(ConfigVars param_000735ab, bool param_000735ac, out PlatformInputManager param_000735ad); // 0x00000001842B4890-0x00000001842B4AE0
	private bool THoyCDdceDgpdfDtwcEICnaxGnAjA(ConfigVars param_000735ae, bool param_000735af, out PlatformInputManager param_000735b0); // 0x000000018AB8FAA0-0x000000018AB8FEA4
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x00000001849C6DD0-0x00000001849C6EA0
	public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_000735b1); // 0x00000001830B7700-0x00000001830B7790
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018AB8F978-0x000000018AB8FA4C
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000182E56440-0x0000000182E56460
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data); // 0x000000018AB8FEA4-0x000000018AB8FF5C
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x0000000184B42130-0x0000000184B421D0
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x0000000184B421D0-0x0000000184B42270
	private void pMEAxuEYXhMFAnjSlfHeNgrlPxPQ(BridgedController param_000735b6); // 0x000000018AB90650-0x000000018AB906A0
	private void mRRUFjhBSbdxngjjjaZbeCubOwOob(ControllerDisconnectedEventArgs param_000735b7); // 0x000000018AB90450-0x000000018AB904A0
	private void pVubgwsVcdumuxrmvbYGNdAkPVuS(EventArgs param_000735b8); // 0x000000018AB906A0-0x000000018AB90734
	private void weZgfCbYdBhDovOdzNTiongPhvVH(EventArgs param_000735b9); // 0x000000018AB90734-0x000000018AB907C8
	private void nMqlgvXSvtazHPVhciVXWubctSPu(UpdateControllerInfoEventArgs param_000735ba); // 0x000000018AB904A0-0x000000018AB90650
}

internal class psTbmShznQqLMMRKqcocsAdKgKFTA : ZvFOVHtMPPFSKMXvcEpBjwvCmYwe, hohNsNaAhdJOLmrreLGwwtWoRfkL // TypeDefIndex: 53656
{
	// Properties
	private TIWOKdoJCWhTsnGfcCDaEsbLDNXvA XQoKuCErZNQlQGpBnaJDCkjnsajJA { get; } // 0x0000000182BBE540-0x0000000182BBE550 

	// Constructors
	public psTbmShznQqLMMRKqcocsAdKgKFTA(ConfigVars param_000735da, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_000735db, Func<int> param_000735dc, Func<PidVid, bool> param_000735dd); // 0x000000018AB9F904-0x000000018AB9F914

	// Methods
	private bool PCrJskquNxmwAdpvwnSVoFFxcbDG(string param_000735de, string param_000735df, string param_000735e0, PidVid param_000735e1); // 0x000000018AB9F8C0-0x000000018AB9F904
}

internal class rBZGQBZwTiSiuHITZSaJgTFuMivb : PlatformInputManager, hohNsNaAhdJOLmrreLGwwtWoRfkL // TypeDefIndex: 53663
{
	// Fields
	private BFABnUirdfafqrsPBWQiwdmSoNCAA[] wObDbzgCSPpmrkNUEKYXvWjJbeFJA; // 0x38
	private bool RxVDVTpGzicTrVQmXjomJOdfOkIFA; // 0x40
	private LzizGTYpZCgQCElPpfEDRfvDvWXpA donvPemuJKnfScXiSnZHNXmppsBE; // 0x48
	private GlvatcZimdinLZLBgGCImLeEgkWE nvVgpsKaQffwPiGsyTwuSovlDXcL; // 0x50
	private KSXcWnVJXHdGdcxUNnMBaqHZACuK<bool> bvJfuxxhJrbPGqHkieajTTZqEMRi; // 0x58
	private bool[] pnqfunvobomYzRUTcZzzjftEwkLA; // 0x60
	private bool[] QAJCTahiFMluJMxSnZMsjufKuCpRA; // 0x68
	private bool pmClilickqOIDTOtWREPApCiJeqq; // 0x70
	private readonly bool DgKDwmjUYSxkqmWfIPdHRnPyekJY; // 0x71
	private readonly UpdateLoopSetting XltDzFvhhAdzVVkaPJAiXYTRRIGl; // 0x74
	private UpdateLoopType iAmcJXZKjhpBzZBljLYoPoHiTErV; // 0x78
	private UpdateLoopType SqEjxbPSUWlPbbWPyacCWgNItEIe; // 0x7C
	private Action<int, ControllerDataUpdater> HqGgQZphbXxVTpfvwnRAAhNlMQRI; // 0x80
	private bool QzETaHZbiZnHspKlFDZomiWOZhDj; // 0x88
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0x90
	private Func<int> bMdbmKyqgyUaZuaPJHLNCqnGNHeDb; // 0x98
	private Func<PidVid, bool> ovrIWXTxmEpphLWfsDWVbCQmStyo; // 0xA0
	private static Guid[] bupIlNEGJTKaYaSGNTEfbZTiGWCe; // 0x00
	private static string[] NAfFaCkqvNBIXjXJFawGsBzNaMmCc; // 0x08
	private static string[] POfIjhtjyMJcYPXICDfirWYSjqMJ; // 0x10

	// Properties
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x000000018ABA013C-0x000000018ABA01A4 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x000000018464E630-0x000000018464E640 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x00000001811EC580-0x00000001811EC590 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	private TIWOKdoJCWhTsnGfcCDaEsbLDNXvA XQoKuCErZNQlQGpBnaJDCkjnsajJA { get; } // 0x0000000184D85B80-0x0000000184D85B90 

	// Nested types
	private class BFABnUirdfafqrsPBWQiwdmSoNCAA : IDisposable, IInputManagerJoystick, ITryGetLocalizedName // TypeDefIndex: 53657
	{
		// Fields
		private bool pmClilickqOIDTOtWREPApCiJeqq; // 0x10
		private int SAwUWSkGKioQPDUaFBSUbXjjqYIM; // 0x14
		private readonly int GCsFzmofrqCkoJPGnsIfZodQcXR; // 0x18
		public Guid CxzTsJSuiZuoQzFIXAHesNKBJEGIA; // 0x1C
		public string NVisgdgmCFTTAegfyHXuYAToBinR; // 0x30
		public string KAhPhNCPIOUGWydRQSumNKzZsKNx; // 0x38
		public Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x40
		public Rewired.Libraries.SharpDX.XInput.DeviceType FeydSgDjtypCTgePURUdNlOclvVRA; // 0x50
		public XInputDeviceSubType rqtDrJdpfGPOHZrczXFKuqiesRVDA; // 0x54
		public bool lDGUseilaXGQbkQZzhoWsJSOEiWlA; // 0x58
		public bool qLABoBUfBvBpTUpsApbunHLrXcNK; // 0x59
		public bool hqrAcfnFmogmXzfMIumOEedIArPR; // 0x5A
		public bool FbDmubKHHdXxcuYTfJFqIFYOuqnG; // 0x5B
		private int InPIThWQyaFVIFkmyUeeDBeqAMth; // 0x5C
		private int FyijsPYPkZofyZbVExmyRvDMcNhH; // 0x60
		private int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x64
		private int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x68
		private readonly float[] WfmlOHFCVeUNZVCPhDBiDsPajnMg; // 0x70
		private readonly bool[] yyCeayeEvvFNGKjODQMmSEtKmaSuA; // 0x78
		private HardwareJoystickMap_InputManager CYjJHFxAtePWANrtsNPovmhwWUDX; // 0x80
		public readonly glrnucEUzNoToJLBWReJKJsCbnHKA boNDKtEvtQnFljhvyLYTzMMSWoS; // 0x88
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0x90
		private Action wLLPJfilnLuEEArhrGQfKlYkaZJH; // 0x98
		private readonly LocalizedString dysDRcMeqEfzmAhqZisXYquOiFtMA; // 0xA0
		private bool wPwEpSTGbzFkclIFABWyxxCvYiOx; // 0xA8
		private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0xA9
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xAA

		// Properties
		public string rTDvBtbCVHvoCFneOcKfGwPSCvaeA { get; } // 0x000000018AB97E00-0x000000018AB97EA8 
		public string ZFMfPPlGsRclaQOlhEcmxjLIUoNw { get; } // 0x000000018AB97728-0x000000018AB977A8 
		public bool oyacANaeyTJvtKtdJsdYmnqAekUQ { get; } // 0x0000000183303BD0-0x0000000183303C00 
		[CustomObfuscation(rename = false)]
		public int rewiredId { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		[CustomObfuscation(rename = false)]
		public int inputManagerId { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		[CustomObfuscation(rename = false)]
		public string name { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[CustomObfuscation(rename = false)]
		public long? systemId { get; } // 0x000000018AB97EC4-0x000000018AB97F10 
		[CustomObfuscation(rename = false)]
		public int unityId { get; } // 0x00000001811EC580-0x00000001811EC590 
		[CustomObfuscation(rename = false)]
		public Rewired.Controller.Extension extension { get; } // 0x000000018AB97EA8-0x000000018AB97EC4 
		[CustomObfuscation(rename = false)]
		public Guid instanceGuid { get; } // 0x0000000184D905C0-0x0000000184D905D0 
		[CustomObfuscation(rename = false)]
		public Guid persistentGuid { get; } // 0x0000000184D905C0-0x0000000184D905D0 

		// Constructors
		public BFABnUirdfafqrsPBWQiwdmSoNCAA(int param_000735fc, bool param_000735fd, glrnucEUzNoToJLBWReJKJsCbnHKA param_000735fe, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_000735ff, Action param_00073600); // 0x0000000183A421A0-0x0000000183A42300

		// Methods
		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex); // 0x000000018AB97BE8-0x000000018AB97C0C
		[CustomObfuscation(rename = false)]
		public void StopVibration(); // 0x000000018AB97C0C-0x000000018AB97C30
		bool ITryGetLocalizedName.TryGetLocalizedName(out string value); // 0x000000018AB97A9C-0x000000018AB97B88
		[CustomObfuscation(rename = false)]
		public void Update(); // 0x000000018AB97D68-0x000000018AB97E00
		public void EwkcAaHOpQOleCWgbsCvmKHkjzAoA(bool param_00073601); // 0x0000000183302660-0x0000000183302670
		public bool ZYycJocImHWXmdvdEbkVgAimMvlC(bFsHvvhHIXsuHKEjfGsxBfqmGTgAA param_00073602); // 0x0000000183A423C0-0x0000000183A423E0
		public bool UQpmPGKmikGKxcatkbzmcAWdDhSZb(bFsHvvhHIXsuHKEjfGsxBfqmGTgAA param_00073603); // 0x00000001836A8220-0x00000001836A8290
		public void JbOaOhivkuMSQVdgFdshyYgCESEab(bool param_00073604); // 0x0000000184D90750-0x0000000184D90760
		public void tcaCVfnFuTmEDkyraDEYvlHdxLyd(); // 0x000000018AB9845C-0x000000018AB984B0
		public void QYLSZuxgfwkPUJKRbVNZXWIehHjP(); // 0x000000018AB979D4-0x000000018AB97A3C
		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018AB97408-0x000000018AB97540
		public BridgedControllerHWInfo QaexLfVSNbNHhboOvHEvgYdhcbmt(); // 0x000000018AB97A3C-0x000000018AB97A9C
		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController(); // 0x000000018AB97C30-0x000000018AB97C90
		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x000000018AB97C90-0x000000018AB97CF4
		private void EIgZIsAaXKSOIBvpwmqjiRutRAOm(); // 0x0000000183A42300-0x0000000183A423C0
		private bool oGHJymPhAxdTsXntdBelIXozhnGg(); // 0x000000018AB98364-0x000000018AB9841C
		private void YLHoWZyzMtRNKjCsBcqKObjyZmOf(); // 0x0000000184DA8730-0x0000000184DA8740
		private void pWtGFOOyGmNdsZkKgBiSaJeOQZqq(); // 0x000000018AB9841C-0x000000018AB9845C
		private void NkoqbCbQUJeDuCjzLLadeyqGfntS(bool[] param_00073606, ref noccVtHfezXkLCsIalwenvYFTJemA param_00073607); // 0x000000018AB977A8-0x000000018AB9792C
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(bool[] param_00073608, ref noccVtHfezXkLCsIalwenvYFTJemA param_00073609); // 0x000000018AB984B0-0x000000018AB98628
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(HardwareJoystickMap.Platform_XInput_Base.Axis param_0007360a, bool[] param_0007360b, ref noccVtHfezXkLCsIalwenvYFTJemA param_0007360c); // 0x000000018AB97344-0x000000018AB973B8
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(XInputAxis param_0007360d, ref noccVtHfezXkLCsIalwenvYFTJemA param_0007360e); // 0x000000018AB972DC-0x000000018AB97344
		private bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(HardwareJoystickMap.Platform_XInput_Base.Button param_0007360f, bool[] param_00073610, ref noccVtHfezXkLCsIalwenvYFTJemA param_00073611); // 0x000000018AB9810C-0x000000018AB98198
		private bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(XInputButton param_00073612, bool[] param_00073613); // 0x000000018AB97F10-0x000000018AB9810C
		private void ODjDNosGTVTcApOFJHPRXXJKAaMW(); // 0x000000018AB9792C-0x000000018AB979D4
		private string GjijczTURIgZZpyFRyfwxQetRhHD(); // 0x000000018AB97540-0x000000018AB97728
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedControllerHWInfo param_00073614); // 0x000000018AB982C8-0x000000018AB98364
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedController param_00073615); // 0x000000018AB98198-0x000000018AB982C8
		public void Dispose(); // 0x000000018AB973B8-0x000000018AB97408
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB97CF4-0x000000018AB97D68
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073616); // 0x000000018AB97B88-0x000000018AB97BE8
	}

	private class GlvatcZimdinLZLBgGCImLeEgkWE // TypeDefIndex: 53659
	{
		// Fields
		private List<QtEhwSYenAhCEaatXydRqrNqMPWQ> kfYfqEcEuytPhEMEULSfGPpdWoee; // 0x10

		// Nested types
		private class QtEhwSYenAhCEaatXydRqrNqMPWQ // TypeDefIndex: 53658
		{
			// Fields
			public bool eizjJaGCKAKSoNOSxqlnFnYoOcZR; // 0x10
			public int ZewBubFBTMGdguZhicDjJwXDMzqL; // 0x14
			public XInputDeviceSubType rqtDrJdpfGPOHZrczXFKuqiesRVDA; // 0x18

			// Constructors
			public QtEhwSYenAhCEaatXydRqrNqMPWQ(int param_00073626, XInputDeviceSubType param_00073627); // 0x0000000184DA8770-0x0000000184DA8780

			// Methods
			public void TSexxBoQJJrDUHjAVGegZXOfrqTg(BFABnUirdfafqrsPBWQiwdmSoNCAA param_00073624, bool param_00073625); // 0x000000018AB9C910-0x000000018AB9C934
		}

		// Constructors
		public GlvatcZimdinLZLBgGCImLeEgkWE(); // 0x0000000183A41020-0x0000000183A410A0

		// Methods
		public void gYvpQOgpgbFrJowabFJErvEiPAXo(BFABnUirdfafqrsPBWQiwdmSoNCAA param_00073617, bool param_00073618); // 0x000000018AB98A34-0x000000018AB98AF0
		public void TSexxBoQJJrDUHjAVGegZXOfrqTg(int param_00073619, BFABnUirdfafqrsPBWQiwdmSoNCAA param_0007361a, bool param_0007361b); // 0x000000018AB988C0-0x000000018AB98960
		public int elnKOjwEVBHvNZiNAyIzpUHIdlfG(XInputDeviceSubType param_0007361c, bool param_0007361d); // 0x000000018AB98960-0x000000018AB98A34
		public int PAAHqPJeiyimprjSbjbBBdnBTcrPA(int param_0007361e, XInputDeviceSubType param_0007361f, bool param_00073620); // 0x000000018AB987C0-0x000000018AB988C0
		public int NecciTpRMLDvaQKUHRNiCLoQaSfI(int param_00073621); // 0x000000018AB9870C-0x000000018AB987C0
		public void qFqZRDTdTLyOsoBpkaudedvGIpXgA(int param_00073622, bool param_00073623); // 0x000000018AB98AF0-0x000000018AB98B74
	}

	private class LzizGTYpZCgQCElPpfEDRfvDvWXpA // TypeDefIndex: 53660
	{
		// Fields
		public bool TTXjKzYcAtbhzXxLtgiAhZXbLUMuA; // 0x10
		private double PQGscZlsWvcInduagGciaOgvzRXH; // 0x18
		public float trSIhajCPEUvjAretroNiVctrZmT; // 0x20

		// Constructors
		public LzizGTYpZCgQCElPpfEDRfvDvWXpA(float param_00073628); // 0x00000001811EC9E0-0x00000001811EC9F0

		// Methods
		public void AUIECoEHQdHwzaapCcIAhFHhHsro(); // 0x0000000183302230-0x0000000183302290
		public bool TSexxBoQJJrDUHjAVGegZXOfrqTg(); // 0x0000000183303DF0-0x0000000183303E50
	}

	public class glrnucEUzNoToJLBWReJKJsCbnHKA : IDisposable // TypeDefIndex: 53661
	{
		// Fields
		public readonly nKmzDjyDAHhaWGWNaeRKraijtxEk zyjJJQMDNLgGTgOwMILoGjYyQstBA; // 0x10
		private readonly Rewired.Controller.Extension TGvHAlvaJSWTwWCdWlyRBrrTreuj; // 0x18
		public noccVtHfezXkLCsIalwenvYFTJemA cPrMshBOTcFWmerQtRsPlfgZnJm; // 0x20
		private bool wPwEpSTGbzFkclIFABWyxxCvYiOx; // 0x2C
		private readonly ButtonLoopSet sNHNPUwkJdSniwWpqjpgKZvUkcXg; // 0x30
		private noccVtHfezXkLCsIalwenvYFTJemA WQBGefAkLHqEsyTveOgsDNEYAlRKA; // 0x38
		private bool YZKCZAUjqkVTCkcbteXPAppGqfemA; // 0x44
		private DualThreadLowLevelInputEventQueue wAYdmCMyMlWIgAAysxaMfmdriutHA; // 0x48
		private readonly object HjEsWTUUzyFrvqnrkapJHwVyFDeL; // 0x50
		private RingBuffer<MjfRFftkTcBeBOoxrCKsCyjeiVkX> DrqBREHxiYhAxSOddlOgteEqdmMPA; // 0x58
		private RingBuffer<MjfRFftkTcBeBOoxrCKsCyjeiVkX> JwhMbAIXRAidaWDkEfsmiFstptgG; // 0x60
		private readonly object vzjmfQRqnFDAlutzVYpyriziwlXB; // 0x68
		private readonly object eQQGpxMILKbMwrmxUWvClMKlhgOr; // 0x70
		private MjfRFftkTcBeBOoxrCKsCyjeiVkX KmJrjHupiCLPqkMyLFGbHyrbIRZd; // 0x78
		private double sPxfnydArqdaLzvvekTOxMHaFJCpA; // 0x80
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x88

		// Properties
		public Rewired.Controller.Extension NdFyOmsmaWBAIhHebklaYJBWUZfE { get; } // 0x000000018385B100-0x000000018385B110 
		public bool[] QfHOjFpcoFlpvJKhBRdhaliAhqPO { get; } // 0x000000018AB9F27C-0x000000018AB9F2D0 

		// Constructors
		public glrnucEUzNoToJLBWReJKJsCbnHKA(int param_00073629, UpdateLoopSetting param_0007362a); // 0x0000000183A423E0-0x0000000183A42690

		// Methods
		public void ZdcGgynytMPTLdLAaWDBvAvTrhqr(); // 0x000000018AB9EE10-0x000000018AB9EE90
		public void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018AB9F21C-0x000000018AB9F27C
		public void NpMOgLjaQKghKbXenFQXBkoChQfCA(); // 0x000000018AB9EB58-0x000000018AB9EB8C
		public void eTDWPSgpXIMtpgNDkBPsaHTWXrZjA(); // 0x000000018AB9F028-0x000000018AB9F038
		public bool UQpmPGKmikGKxcatkbzmcAWdDhSZb(bFsHvvhHIXsuHKEjfGsxBfqmGTgAA param_0007362b); // 0x00000001836A8290-0x00000001836A82E0
		public void hJVWdluocTccqfVOELDXAeXkkPPlA(float param_0007362c, int param_0007362d); // 0x000000018AB9F038-0x000000018AB9F094
		public void eEnRZrPQkNXhsmIjYHcmHsAiBpVj(); // 0x000000018AB9F01C-0x000000018AB9F028
		public void DCzoBWVbDQflAenKageEgwKrZlkR(); // 0x000000018AB9E7F8-0x000000018AB9E950
		public void OEUiepMJOLOxlvyKFlBdMfSwBByE(); // 0x0000000183617460-0x0000000183617710
		public void bQByUaaPbcTUdwegxMgjeATLizYD(); // 0x0000000183617710-0x0000000183617880
		private void cbJpAWKVtCgvFtIikgPssDjoPxht(); // 0x000000018AB9EF60-0x000000018AB9EF68
		private void NIxaCWDZMjMBnhrHHfjBzuFxLWeLA(); // 0x000000018AB9EA58-0x000000018AB9EB58
		private void dIynDsLKbxaDRBsYLuwSquvHCLOcA(); // 0x000000018AB9EF68-0x000000018AB9F01C
		private static void klxLesivsoDcuFJPjuyxNnKqNker(RingBuffer<MjfRFftkTcBeBOoxrCKsCyjeiVkX> param_0007362e, nKmzDjyDAHhaWGWNaeRKraijtxEk param_0007362f, ref double param_00073630); // 0x000000018AB9F0F8-0x000000018AB9F198
		private static void WHQkUusMnfMdEtkmpklkwvEzfSLF(nKmzDjyDAHhaWGWNaeRKraijtxEk param_00073631, MjfRFftkTcBeBOoxrCKsCyjeiVkX param_00073632, ref double param_00073633); // 0x000000018AB9ED30-0x000000018AB9EE10
		private void ZhaMfegKEcaYTTYtJFlVhwccVqcl(ref noccVtHfezXkLCsIalwenvYFTJemA param_00073634); // 0x000000018AB9EE90-0x000000018AB9EF60
		private void OAlzeOtIpuBNzMKxqoYYRwJHNjLL(ref noccVtHfezXkLCsIalwenvYFTJemA param_00073635, double param_00073636, LowLevelInputEvent param_00073637); // 0x000000018AB9EB8C-0x000000018AB9EC80
		private void xUVWOijUKuiOeHeHcSoMxqOoodhs(ref noccVtHfezXkLCsIalwenvYFTJemA param_00073638, ref LowLevelInputEvent param_00073639); // 0x000000018AB9F2D0-0x000000018AB9F3DC
		private static bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(int param_0007363a, int param_0007363b); // 0x000000018AB9F1FC-0x000000018AB9F21C
		private void DFzbWQdNlFisggGgVmYILlDdMehP(); // 0x000000018AB9E950-0x000000018AB9EA08
		public void Dispose(); // 0x000000018AB9EA08-0x000000018AB9EA58
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB9ECBC-0x000000018AB9ED30
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007363c); // 0x000000018AB9EC80-0x000000018AB9ECBC
		public static float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_0007363d); // 0x000000018AB9F198-0x000000018AB9F1FC
		public static float hdZcXCdRxvHmMmvVsrzbNtfbjBMXA(int param_0007363e); // 0x000000018AB9F094-0x000000018AB9F0F8
		private static bool CuDoEPEJQapgbkINSuEJLwmbaAbd(noccVtHfezXkLCsIalwenvYFTJemA param_0007363f, noccVtHfezXkLCsIalwenvYFTJemA param_00073640); // 0x000000018AB9E7B0-0x000000018AB9E7F8
	}

	public enum bFsHvvhHIXsuHKEjfGsxBfqmGTgAA // TypeDefIndex: 53662
	{
		Synchronous = 0,
		Asynchronous = 1
	}

	// Constructors
	public rBZGQBZwTiSiuHITZSaJgTFuMivb(bool param_000735e2, UpdateLoopSetting param_000735e3, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_000735e4, Func<int> param_000735e5, Func<PidVid, bool> param_000735e6); // 0x0000000183B22470-0x0000000183B22E60
	static rBZGQBZwTiSiuHITZSaJgTFuMivb(); // 0x00000001849E5980-0x00000001849E5B50

	// Methods
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x0000000183A41D80-0x0000000183A42080
	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType currentUpdateLoop); // 0x0000000183303A20-0x0000000183303BD0
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018AB9FD9C-0x000000018AB9FF9C
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000184D86260-0x0000000184D86270
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data); // 0x000000018ABA00FC-0x000000018ABA013C
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x000000018ABA008C-0x000000018ABA00C4
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x000000018ABA00C4-0x000000018ABA00FC
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x00000001811EC580-0x00000001811EC590
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x00000001811EC580-0x00000001811EC590
	private bool PCrJskquNxmwAdpvwnSVoFFxcbDG(string param_000735ec, string param_000735ed, string param_000735ee, PidVid param_000735ef); // 0x000000018AB9FF9C-0x000000018ABA008C
	private bool JRwSwwfbydOlsmRZOPQMAGESBIheA(); // 0x0000000183303D40-0x0000000183303DF0
	private void frddIMHcKFiaYzcdcavbZJHdTsPcA(bool param_000735f0); // 0x0000000183302200-0x0000000183302230
	private void pCTHHdiYlWAANgEcGswtLRIAYggsD(); // 0x0000000184D549E0-0x0000000184D54A30
	private void kNwsRjzUPqlWAngmSxVsTsQzbnNU(); // 0x000000018ABA0384-0x000000018ABA03D0
	private void aHkOdhJXptAoBHaAPdXpbfyfxpNg(); // 0x0000000183303C00-0x0000000183303D40
	private void MlGkGyByutorfoeNATowscMEHlCc(); // 0x0000000183302290-0x00000001833022D0
	private void HrafxVEiJeftPMWeXgAkqYHrGJCJA(); // 0x0000000183301CE0-0x0000000183302110
	private bool nLZEuKasgqDlEKGIuPILWtzyapiib(); // 0x00000001836A7330-0x00000001836A8220
	private bool[] tyENmsjcxkgcMIvcqEetyfdRkfNu(); // 0x00000001849D3010-0x00000001849D30E0
	private void BkZDOWMnPEbtOhNopUvkrbRhFRoT(bool[] param_000735f1); // 0x00000001833038B0-0x0000000183303A20
	private bool iEEFlbFDszRppifBFnwpNApzASvF(BFABnUirdfafqrsPBWQiwdmSoNCAA param_000735f2, bool param_000735f3); // 0x000000018ABA01A4-0x000000018ABA0384
	public static bool GlkAWXDUNvdQsCbMaLLQgGXTXAddA(string param_000735f4, string param_000735f5, string param_000735f6, Guid param_000735f7); // 0x000000018AB9FB58-0x000000018AB9FD9C
}

internal interface JtAgsvgsGMTkkHyzazJahvxjADso // TypeDefIndex: 53664
{
	// Events
	event Action<EventArgs> vrsKYxMgJTEgnNvuckTBQHVDBKDX {
		add; // 0x00000000-0x00000000
		remove; // 0x00000000-0x00000000
	}
	event Action<EventArgs> cquFiigoGXXxfjEUDiFhIXaBAHsbc {
		add; // 0x00000000-0x00000000
		remove; // 0x00000000-0x00000000
	}

	// Methods
	void hoAhQOJWtqQFplfEKzOAsAgxjDsK();
}

internal interface hohNsNaAhdJOLmrreLGwwtWoRfkL // TypeDefIndex: 53665
{
	// Properties
	TIWOKdoJCWhTsnGfcCDaEsbLDNXvA NidrKPPiVPTdrLJKDNQKBcjoOCUb { get; }

	// Methods
	bool PRajVZFjkThVyEtmdfNgoHAJuyoe(string param_00073645, string param_00073646, string param_00073647, PidVid param_00073648);
}

internal static class yqCthwNGAZgagjDBQbkNEzFfVZWu // TypeDefIndex: 53671
{
	// Nested types
	public struct AInQCDdqSLTTWRljCHGQhayircJNA // TypeDefIndex: 53666
	{
		// Fields
		public uint BAOrtdveeFJDDIIhfyXvlubcLkGj; // 0x00
		public bool VICGphkXTgJzMTTiGpRqzIIxEsxNA; // 0x04
		public bool AtTbFSNzIEQTJlJgEtVcLBRUbicB; // 0x05
		public bool VNLphvRTMkeYkFVRlYkyWyJgcbnD; // 0x06
		public bool sKZRjkVRtJrgYTPQXTHfQMwLszjN; // 0x07
		public bool AZCYAOPXDAHUSsTPWzkPSIsVvbjI; // 0x08
		public byte DYHGckCLLXoNwgzuwzUMbAmLLxLNA; // 0x09
		public IntPtr nbzpBjCSRAdsnmaaZLqUpzzJIQIL; // 0x10

		// Methods
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB97020-0x000000018AB972DC
	}

	public struct ygRJphukthbSeHYUTNVFxMSmRNEw // TypeDefIndex: 53667
	{
		// Fields
		public uint BAOrtdveeFJDDIIhfyXvlubcLkGj; // 0x00
		public zjqYgNShDGWqApAIcTMzTZjxpPXO WrCjUkbeQSCjnNDJNfLqgFqiTgUvA; // 0x04
		public uint BumXwtohNUmXpraXjQpyTJGEjWeiA; // 0x10
		public bool XRMPMmkcFFZEODWCPIyKFpteDpwT; // 0x14
		public bool xjDfzPIMwHyKvhVKSLFNBYUSCLIL; // 0x15
		public bool OaEGssroqDlJpjkeLWKgsjiNcOyM; // 0x16
		public ZxkAWJEvROErAlVLuJWMIEjURgkS pUIknBZoZuZQkXsYDTEZLNUJNCPS; // 0x17
		public ZxkAWJEvROErAlVLuJWMIEjURgkS RlLBFbLRvZccccStOlnKTpmTxDbq; // 0x27
		public string jluGTEJSZCQcwybKVMvTKULuHVATA; // 0x38

		// Methods
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABA1E18-0x000000018ABA20FC
		public static ygRJphukthbSeHYUTNVFxMSmRNEw XchWqxgmUvhSvDLAYlZyAXmMcTYy(); // 0x0000000183A434E0-0x0000000183A43590
	}

	public struct ZxkAWJEvROErAlVLuJWMIEjURgkS // TypeDefIndex: 53668
	{
		// Fields
		public ushort pZRZthsmOxjeYdtwcDFxHJvwdWYw; // 0x00
		public ushort QRfMLtZnIisGvzKAMcFKsQPIoFHM; // 0x02
		public ushort shpcyfwAMtsaXvWvrArAAYylrNvR; // 0x04
		public ushort uhSQtHmROCyogXNHgskWUCMFUhIA; // 0x06
		public ushort MfifWcHQlHaWrtKQsnpjeTzrZApQ; // 0x08
		public ushort dLOMJIVXgzMPmtjvjlFSEVbAJLWO; // 0x0A
		public ushort QWvHmsWzOqFgFLmQwchwdQTWpeJT; // 0x0C
		public ushort eqfKruxKkTetMLnItDGIglqlbozR; // 0x0E

		// Methods
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB9D684-0x000000018AB9D8C4
	}

	public struct zjqYgNShDGWqApAIcTMzTZjxpPXO // TypeDefIndex: 53669
	{
		// Fields
		public byte MJfNnWCIhWaUuhcmAosZaKTloplDb; // 0x00
		public byte RBdLjmIgLkzLntLgtvgFRtaasMEY; // 0x01
		public byte kAIKzghMVCsZoBqBLadJVrnkbbqy; // 0x02
		public byte ZXGfVLAKQqpDBDYigsIlTAUrbHLhc; // 0x03
		public byte ysxumoXdIFMLDYgYatKjHvWQBtEF; // 0x04
		public byte XlYFrHeUqHxpckiEYcQZyhlwgWZs; // 0x05
		public byte ZaNrCcnhdtHuhuNZHRADwHvhbZDCA; // 0x06
		public byte WlhTeaLnNNQPKXbcMfzvMEUVYalM; // 0x07
		public byte GGLvsHbLusbuqHrrpDCzACVgyTVaB; // 0x08
		public byte eShxjChRgpHVTNGdPUQpexMstCAp; // 0x09
		public byte WXlaJAKWNpbJBGJhaXtjGlDhuXcmb; // 0x0A
		public byte gqKAsdfXpIXoddzOfUqcZgzDPzJi; // 0x0B

		// Methods
		public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABA3158-0x000000018ABA3390
		public bool ZekLfWolLuPxVcKiHUPtpCzfkSpD(ref qouLffTOBqCNRYJTtvCdYqzmFTjY param_00073652); // 0x000000018ABA3120-0x000000018ABA3158
	}

	public struct qouLffTOBqCNRYJTtvCdYqzmFTjY // TypeDefIndex: 53670
	{
		// Fields
		private static byte[] mAJEeYRLWzFnlGELTpvuOFNjEPtGA; // 0x00
		public byte MJfNnWCIhWaUuhcmAosZaKTloplDb; // 0x00
		public byte RBdLjmIgLkzLntLgtvgFRtaasMEY; // 0x01
		public byte kAIKzghMVCsZoBqBLadJVrnkbbqy; // 0x02
		public byte ZXGfVLAKQqpDBDYigsIlTAUrbHLhc; // 0x03
		public byte ysxumoXdIFMLDYgYatKjHvWQBtEF; // 0x04
		public byte XlYFrHeUqHxpckiEYcQZyhlwgWZs; // 0x05

		// Constructors
		static qouLffTOBqCNRYJTtvCdYqzmFTjY(); // 0x000000018AB9FAF0-0x000000018AB9FB58

		// Methods
		public static qouLffTOBqCNRYJTtvCdYqzmFTjY OHXABKpcRQEyVCVNYSxyCIeRDFxC(string param_00073653, out bool param_00073654); // 0x000000018AB9F914-0x000000018AB9FAF0
	}

	// Methods
	public static extern IntPtr WxQDbcBewOHVDjYIJHPdWjPxllS(ref AInQCDdqSLTTWRljCHGQhayircJNA param_00073649, ref ygRJphukthbSeHYUTNVFxMSmRNEw param_0007364a); // 0x000000018ABA2D8C-0x000000018ABA2EF8
	public static extern IntPtr WxQDbcBewOHVDjYIJHPdWjPxllS(ref AInQCDdqSLTTWRljCHGQhayircJNA param_0007364b, IntPtr param_0007364c); // 0x0000000183A44BD0-0x0000000183A44C90
	public static extern bool mQssrJgjUbCvONGNlAAVBhZNgoOU(IntPtr param_0007364d, ref ygRJphukthbSeHYUTNVFxMSmRNEw param_0007364e); // 0x000000018ABA2F78-0x000000018ABA3090
	public static extern bool mQssrJgjUbCvONGNlAAVBhZNgoOU(IntPtr param_0007364f, IntPtr param_00073650); // 0x000000018ABA3090-0x000000018ABA3120
	public static extern bool bEWDUdFfIpgjwkQndYcSZOhUkjbh(IntPtr param_00073651); // 0x000000018ABA2EF8-0x000000018ABA2F78
}

internal class VAmVuDvNsSbewEPAcnmMyxvuGlBo : IDisposable // TypeDefIndex: 53675
{
	// Fields
	private readonly ushort RyVzcDOUsGFwekBwZgSPqLWbSQzA; // 0x10
	private readonly string qcRfkgjdgrTyEjxhMTqptkwGbtcKA; // 0x18
	private bool MavmtwJnLFDfxlouqLLOGtReFssd; // 0x20
	private IntPtr moCsUVMGiXakcHdBXDctQmTujckjA; // 0x28
	private int LbjStJkxRAQgcJIrQEJOAzwXJWrAA; // 0x30
	private uint ZJwfQiCoaeYtHFmrQKiNjNVVsLphA; // 0x34
	private kHNwxQmQEdrtRthvkmZVuYphaaTJ PwRUwYVeJZpHrrYVHJUEKDizdkldA; // 0x38
	private kHNwxQmQEdrtRthvkmZVuYphaaTJ EGGuNRAbCiKCXVvQLKSRMjVfeoCKA; // 0x40

	// Properties
	public IntPtr PUEzmrlElSKlZtsHOOIRnENkNBKo { get; } // 0x0000000184D86240-0x0000000184D86250 

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr kHNwxQmQEdrtRthvkmZVuYphaaTJ(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam); // TypeDefIndex: 53672; 0x00000001814D0D00-0x00000001814D0D20

	private struct JLzqcoYPpoPdErdUrOgqAeuRLnyW // TypeDefIndex: 53673
	{
		// Fields
		public uint tgBeGGbIPzrXuKbbJMcBbDIQQGSM; // 0x00
		public IntPtr MLknMgZMtviBUfIgjGKDCvGntPOB; // 0x08
		public int wBoaVdBqibkANVFvuTxqQVFTMRRdb; // 0x10
		public int nKFfsJGHwBefOHaLANOnCwicVaHgd; // 0x14
		public IntPtr LeWhoLCRYHPVpkeflhaanKkpnqxz; // 0x18
		public IntPtr XJNomzcfbACkqIhIAZVSuuoJdOHd; // 0x20
		public IntPtr IRGzsLlmvYdqmhmcKlRethfrXkWmA; // 0x28
		public IntPtr XTyyIrvQIdcyzFnkMVEKcMvixKbF; // 0x30
		public string xhegkNCsXOYaNIJBGxHKsSFTBojdA; // 0x38
		public string sEKbQbCwVLQYSMgrcWnoDEZDPNyVA; // 0x40
	}

	private struct etvIfgZlCvHnuOCaylGJIKTqfXqQ // TypeDefIndex: 53674
	{
		// Fields
		public IntPtr sHpWOkHeJRHcTWucdVnlHxOrpOnQ; // 0x00
		public IntPtr LeWhoLCRYHPVpkeflhaanKkpnqxz; // 0x08
		public IntPtr ShDiKcIjIiirneluiCpwvAGrHAGRA; // 0x10
		public IntPtr ibTkhCWZMwrAqyNiUjLszIUpGkQcA; // 0x18
		public int xfrjafspumZzJYYwjLEEfhjIhWck; // 0x20
		public int CBAwUHBkbItWChbUpNjBqLUbYWtp; // 0x24
		public int IuEuFRbjYKACLnaEzOkNJxcvuQDh; // 0x28
		public int mGBqRTPfHeiBcGQGSVwfLDhJaFFPA; // 0x2C
		public int tgBeGGbIPzrXuKbbJMcBbDIQQGSM; // 0x30
		public IntPtr hTGQpUjWvbOBbuhvhyzTPlrdjJGi; // 0x38
		public IntPtr XUOVanuTiuvguZxSBbmTyNfptZQA; // 0x40
		public uint siBADAnCqdxDDGNTMeEjkYVtzwqPA; // 0x48
	}

	// Constructors
	public VAmVuDvNsSbewEPAcnmMyxvuGlBo(string param_0007366a, bool param_0007366b, kHNwxQmQEdrtRthvkmZVuYphaaTJ param_0007366c); // 0x0000000183BF71B0-0x0000000183BF7390

	// Methods
	private static extern ushort VlEDOckYBQeVQiVtPbzHODxpPDqFb(in JLzqcoYPpoPdErdUrOgqAeuRLnyW param_00073655); // 0x0000000183BF7120-0x0000000183BF71B0
	private static extern bool DRllTtQhZYldGsKJwviGSzfmygMC(string param_00073656, IntPtr param_00073657); // 0x000000018AB9D0A4-0x000000018AB9D138
	private static extern IntPtr ervBAZBzpueRpQeCxpGWOIjcFiEsA(uint param_00073658, string param_00073659, string param_0007365a, uint param_0007365b, int param_0007365c, int param_0007365d, int param_0007365e, int param_0007365f, IntPtr param_00073660, IntPtr param_00073661, IntPtr param_00073662, IntPtr param_00073663); // 0x0000000183BF7530-0x0000000183BF7620
	private static extern IntPtr mShTuwnDkNEssGVztjGrAZHLNLwXA(IntPtr param_00073664, uint param_00073665, IntPtr param_00073666, IntPtr param_00073667); // 0x00000001835AC9A0-0x00000001835ACA20
	private static extern bool YdCeZwZrvmgNBtyOBvtuQpaIJRaE(IntPtr param_00073668); // 0x000000018AB9D27C-0x000000018AB9D2FC
	public void Dispose(); // 0x000000018AB9D138-0x000000018AB9D188
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB9D208-0x000000018AB9D27C
	private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073669); // 0x000000018AB9D188-0x000000018AB9D208
	private IntPtr yIZoZTXrSGdjkMnanAKqHTfoBXrc(string param_0007366d, IntPtr param_0007366e); // 0x000000018AB9D2FC-0x000000018AB9D388
	private IntPtr svtjyZxQguJEqsRYyrtwCzhqhquf(string param_0007366f, IntPtr param_00073670); // 0x0000000183BF7460-0x0000000183BF7530
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(kHNwxQmQEdrtRthvkmZVuYphaaTJ))]
	private static IntPtr qbeGbfdGZqFKOzogqBfhESidVyvkc(IntPtr param_00073671, uint param_00073672, IntPtr param_00073673, IntPtr param_00073674); // 0x00000001835AC810-0x00000001835AC9A0
	public void QVAyCDWtLDCZVmdXEbRmtGNJsDnj(kHNwxQmQEdrtRthvkmZVuYphaaTJ param_00073675); // 0x00000001842B4AE0-0x00000001842B4AF0
}

internal class WVJmIOuiHfoHGzSrfIOlgfYfJWHl // TypeDefIndex: 53677
{
	// Fields
	public static IntPtr XDEfqDDBnOJTggmIOXdhEWdulorq; // 0x00
	public static int SCJUDnKgphXoLzaQjmEFfgwtrvIF; // 0x08
	public static int FhJBzIgTXjeiUHdAwMZCwvvfVjhxA; // 0x0C
	public static int MpOoCTUnpRznVCWzLVxMhnlmZVs; // 0x10
	public static int fZmWpcHJbQoVukxdRQKxWCyfBGFiA; // 0x14
	public static int LCJBzJbLFnYsBEtDnRxJlOwsVGVp; // 0x18
	public static int jqLzCqhuJZnGevybPAiMamqkqdNK; // 0x1C
	public static int tJBMFPFxTAQtRtEdSZufopnAFpaeA; // 0x20
	public static int lrbkCcMCpnxzotppIRXbmleRdDCD; // 0x24
	public static int QYKfNwysjtAfhbQmtEWmxKCkJLmCA; // 0x28
	public static int RzWfgCvAVggZHbYZoVBSfqVgOAtdA; // 0x2C
	public static int qJdsedUdCsVxoBfoAcKCUksyiqMh; // 0x30
	public static int tWmPgnqXLuPIXFnLdSlhoNlCekVaA; // 0x34
	public static int CZVsyWVdZomJJWQFAwItbztRFQdV; // 0x38
	public static int eLaxJXhDflneZDGgOKrRpkNuXVfP; // 0x3C
	public static int VqAmxfnkiUarJQRHinstXRcVbWob; // 0x40
	public static int WugadxoAAhvLAQMfuCAkCTdFBbzaA; // 0x44
	public static int VgNJjHVDDSijhwktQBBQsgBQyNxC; // 0x48
	public static int bGzqEigDgSAVsnqVmkIlXCWzvUOk; // 0x4C
	public static int fTyjlpjhdMBrqSZGbiPgfqObwEDh; // 0x50
	public static int atdZYSXcWsfBvidhobnmtnoTEYTgA; // 0x54
	public static int XaQpoRbaBCWmqncRPWkKBsWDBMcF; // 0x58
	public static int jVUSWYADsfasFjjKfJYyHdFRhXhz; // 0x5C
	public static int fMJUUrhyUQHNYPxnafgtEAhxHpYP; // 0x60
	public static int lNKXvCANkQdRPGBFFDNFvaQHOItFA; // 0x64
	public static int YFsbtaEHrazkMWmNCldSlqIGrKQJ; // 0x68
	public static int SJgeEugRXroysLYaPpgdKSjelYgy; // 0x6C
	public static int oDXdVJRkIsMmKDnQHLPRPLnDYpDk; // 0x70
	public static int ckpxHGpGQxGEGzliOAGYADLdIJpF; // 0x74
	public static int vGjgPhyNZeJzLVhnRnfekDfOQFlN; // 0x78
	public static int BewxFcNWnrbJpuZMiMNWdhovdYql; // 0x7C
	public static int qrrNzKtjmJphigdeHfFQTHGrIupI; // 0x80
	public static int SrAEBrWJFCgnKggbEEBChjiNGaZoA; // 0x84
	public static int ueOSFtEqDvPStQcDeOxhYqBkItKC; // 0x88
	public static int cMcGEWFhsTdrBIEMpmEkmXRqOldIA; // 0x8C
	public static int sgibdDOoBbgYuhqnKtGfRgYvhGGA; // 0x90
	public static int XezXpDAsLHDNWdfOxIexTMDgAtbNA; // 0x94
	public static int ZGJbFWtKcdyXnUpGdTwQlZepnpnh; // 0x98
	public static int rHIdHMjHHRxzZuZZEYUixetjPVIH; // 0x9C
	public static int dCGgNYHvmpbnItrfOqVUKnGOksHX; // 0xA0
	public static int iphJfVbJJdndBYdSMVdLZsJjaHcx; // 0xA4
	public static int LLScrpCfbydSJfnbZBEBowUHugcl; // 0xA8
	public static int NoMdZfWCdVnSlLWQsORvEfJbFSYGA; // 0xAC
	public static int kKHFTvoMLWBstWWQGEpHITgbpyKtA; // 0xB0
	public static int gtuaElEmxOdfYztCAWqNQmAcFQmm; // 0xB4
	public static int dtrICQIqXBpqpmTpInSzuscICclu; // 0xB8
	public static int mtHAAOaOtoICEGNWZMvjVIzxvDms; // 0xBC
	public static int zEelqtlVeXqNFMMMZBOrdgckSwAw; // 0xC0
	public static int PoIfoXfZaKIBuSjFjDsnAczIqPIB; // 0xC4
	public static int iQCvhhwhknuOtsGAJXCAwSCGVDzw; // 0xC8
	public static int LJtoGUfBLJQXtMjwNAFnjtQvpjdR; // 0xCC
	public static int FIFQrqPXhVcFjEBkioQmppblGzbr; // 0xD0
	public static int aOAFjYIlIBQByixzzqTgCAngUVgac; // 0xD4
	public static int elRVxENkGCITLoplgOlHlIbfPXLs; // 0xD8
	public static int XWHhUvkrKQutkpGrdRPOkqGsmqMP; // 0xDC
	public static int YGRvlLEWKieAHOVFCwZcNfnVzbrw; // 0xE0
	public static int diGnOGMZcCHzdZTqwstedioxPfJO; // 0xE4
	public static int EmPDAgEacQZeiLaQDsqUnlVIaJTIb; // 0xE8
	public static int OZHadHuwetfutazBWVglLKQhbXT; // 0xEC
	public static int CEDHGrbBuOpItFWvLhFQHOOavLEXB; // 0xF0
	public static int nvMtDiyAKXWArqwHeTonYzcHdUwd; // 0xF4
	public static int fjqMKhjbKOTCclvQGgTpoCpfPMiB; // 0xF8
	public static int jGNYRMwUzXvjvpBHbyCbccHXXkQj; // 0xFC
	public static int ijrnnDiADlivvxcDRcxWhEUBNRkY; // 0x100
	public static int GdKarffXrTuUZjPhxfaVaXWbYjvI; // 0x104
	public static int qzKbEIlucBlyGpmfVuuEjVroAADh; // 0x108
	public static int tJPcyScwKALoSrFJLbmqyesZdgGW; // 0x10C
	public static int poJpwYqiQlhDDtNbmNjNSEPKUOsR; // 0x110
	public static int hBaVbMtyudlpECzhMpsbIGijSsEJ; // 0x114
	public static int YCkilNAYKjyXobNmOqcUplgOtBNG; // 0x118
	public static int MrSlwquiECwlGyMMMGmcIcRCfjdfA; // 0x11C
	public static int ualXbqwWwWphkWMpVdoAsfKGMAqt; // 0x120
	public static int QFnMqDaafOhsXSLDpjJjzroKogxs; // 0x124
	public static int jWtcaKQVFiNVUmMrKlmvXIjKFdiD; // 0x128
	public static int NXvIEgFwqJaDRchHJDPgZGSxkjEh; // 0x12C
	public static int BYAfzVAsvxHnyTJejsIfYrIFGuVNA; // 0x130
	public static int mdLHVGoEUkzrMcVTVUaLRaZHAFDm; // 0x134
	public static int QyXdQfWipgTisQSLAbShBeWfbMuf; // 0x138
	public static int WhHHdmbZMjfYjcNNxeGhjLtrUpBt; // 0x13C
	public static int zMxyUGHVcFLRKNFbKGyVbeWTjOMjb; // 0x140
	public static int RDdunSJevDQYjfpHdOuBzWvZGxPB; // 0x144
	public static int TUNbRjWIqvlaEaykcezYNubyniSK; // 0x148
	public static int KykFEDVMQlCFqVAAJEGhPzdlQtfW; // 0x14C
	public static int bZwiAmPAeeMMsrqkTxSzVlsOIpKK; // 0x150
	public static int pgNpBMhkObGczWYczvKzblHTBvNJ; // 0x154
	public static int QFKHRBgWXsuDdThYYCYxkiJMqjvE; // 0x158
	public static uint cXDJZpYImcSbUHBmaPLoTVTubjWS; // 0x15C
	public static uint tjtbtYkOBBRHicQguPCoDbiFLPGaA; // 0x160
	public static uint SYahhcjfwMfpYaxSbteZPCkdkBdfE; // 0x164
	public static uint GdEGVuRPhXeDCNNrJFUnAlPxtzIt; // 0x168
	public static uint xaXUWsQPnGgNHUjfwzjcOiNfvZGH; // 0x16C

	// Nested types
	public enum WRERAPCBXnkbbRNoLOLIJyYkhFAo // TypeDefIndex: 53676
	{
		Arabic_101 = 1025,
		Bulgarian_Typewriter = 1026,
		Chinese_Traditional_US_Keyboard = 1028,
		Chinese_Traditional = 1029,
		Czech = 1029,
		Danish = 1030,
		German = 1031,
		Greek = 1032,
		United_States_English = 1033,
		Spanish = 1034,
		Finnish = 1035,
		French = 1036,
		Hebrew = 1037,
		Hungarian = 1038,
		Icelandic = 1039,
		Italian = 1040,
		Japanese = 1041,
		Korean = 1042,
		Dutch = 1043,
		Norwegian = 1044,
		Polish_Programmers = 1045,
		Portuguese_Brazilian_ABNT = 1046,
		Romanian_Legacy = 1048,
		Russian = 1049,
		Croatian = 1050,
		Slovak = 1051,
		Albanian = 1052,
		Swedish = 1053,
		Thai_Kedmanee = 1054,
		Turkish_Q = 1055,
		Urdu = 1056,
		Ukrainian = 1058,
		Belarusian = 1059,
		Slovenian = 1060,
		Estonian = 1061,
		Lithuanian_IBM = 1063,
		Tajik = 1064,
		Central_Kurdish = 1065,
		Persian = 1065,
		Vietnamese = 1066,
		Armenian_Eastern = 1067,
		Azerbaijani_Latin = 1068,
		Sorbian_Standard_Legacy = 1070,
		Macedonia_FYROM = 1071,
		Setswana = 1074,
		Georgian = 1079,
		Faeroese = 1080,
		DevanagariINSCRIPT = 1081,
		Maltese_47Key = 1082,
		Norwegian_with_Sami = 1083,
		Kazakh = 1087,
		Kyrgyz_Cyrillic = 1088,
		Turkmen = 1090,
		Tatar_Legacy = 1092,
		Bangla_Bangladesh = 1093,
		Punjabi = 1094,
		Gujarati = 1095,
		Odia = 1096,
		Tamil = 1097,
		Telugu = 1098,
		Kannada = 1099,
		Malayalam = 1100,
		Assamese_Inscript = 1101,
		Marathi = 1102,
		Mongolian_Cyrillic = 1104,
		Tibetan_PRC_Legacy = 1105,
		United_Kingdom_Extended = 1106,
		Khmer = 1107,
		Lao = 1108,
		Syriac = 1114,
		Sinhala = 1115,
		Cherokee_Nation = 1116,
		Nepali = 1121,
		Pashto_Afghanistan = 1123,
		Divehi_Phonetic = 1125,
		Hausa = 1128,
		Yoruba = 1130,
		Sesotho_sa_Leboa = 1132,
		Bashkir = 1133,
		Luxembourgish = 1134,
		Greenlandic = 1135,
		Igbo = 1136,
		Guarani = 1140,
		Uyghur_Legacy = 1152,
		Maori = 1153,
		Sakha = 1157,
		Yakut = 1157,
		Wolof = 1160,
		Chinese_Simplified_US_Keyboard = 2052,
		Swiss_German = 2055,
		United_Kingdom = 2057,
		Latin_American = 2058,
		Belgian_French = 2060,
		Belgian_Period = 2067,
		Portuguese = 2070,
		Serbian_Latin = 2074,
		Azerbaijani_Cyrillic = 2092,
		Swedish_with_Sami = 2107,
		Uzbek_Cyrillic = 2115,
		Mongolian_Mongolian_Script_Legacy = 2128,
		Inuktitut_Latin = 2141,
		Central_Atlas_Tamazight = 2143,
		_Hong_Kong_S_A_R_ = 3076,
		Canadian_French_Legacy = 3084,
		Serbian_Cyrillic = 3098,
		Dzongkha = 3153,
		_Singapore_US_keyboard = 4100,
		Canadian_French = 4105,
		Swiss_French = 4108,
		Chinese_Traditional_Macao_S_A_R__US_Keyboard = 5124,
		Chinese_Simplified = 5125,
		Irish = 6153,
		Bosnian_Cyrillic = 8218,
		India = 16393,
		Arabic_102 = 66561,
		Bulgarian_Latin = 66562,
		Czech_QWERTY = 66565,
		German_IBM = 66567,
		Greek_220 = 66568,
		United_States_Dvorak = 66569,
		Spanish_Variation = 66570,
		Hungarian_101key = 66574,
		Italian_142 = 66576,
		Polish_214 = 66581,
		Portuguese_Brazilian_ABNT2 = 66582,
		Romanian_Standard = 66584,
		Russian_Typewriter = 66585,
		Slovak_QWERTY = 66587,
		Thai_Pattachote = 66590,
		Turkish_F = 66591,
		Latvian_Legacy = 66598,
		Lithuanian = 66599,
		Armenian_Western = 66603,
		Azerbaijani_Standard = 66604,
		Sorbian_Extended = 66606,
		Macedonia_FYROM_Standard = 66607,
		Georgian_QWERTY = 66615,
		Hindi_Traditional = 66617,
		Maltese_48key = 66618,
		Sami_Extended_Norway = 66619,
		Tatar = 66628,
		Bangla_India_Legacy = 66629,
		Tibetan_PRC_Standard = 66641,
		Khmer_NIDA = 66643,
		Syriac_Phonetic = 66650,
		Sinhala_wij_9 = 66651,
		Cherokee_Nation_Phonetic = 66652,
		Inuktitut_Naqittaut = 66653,
		Divehi_Typewriter = 66661,
		Uyghur = 66688,
		Belgian_Comma = 67596,
		Finnish_with_Sami = 67643,
		Myanmar = 68608,
		Canadian_Multilingual_Standard = 69641,
		Scottish_Gaelic = 71689,
		Arabic_102_AZERTY = 132097,
		Bulgarian_phonetic_layout = 132098,
		Czech_Programmers = 132101,
		Greek_319 = 132104,
		United_States_International = 132105,
		Romanian_Programmers = 132120,
		Russian_Mnemonic = 132121,
		Thai_Kedmanee_nonShiftLock = 132126,
		Ukrainian_Enhanced = 132130,
		Latvian_Standard = 132134,
		Lithuanian_Standard = 132135,
		Armenian_Phonetic = 132139,
		Sorbian_Standard = 132142,
		Georgian_Ergonomic = 132151,
		Bangla_India = 132165,
		Sami_Extended_FinlandSweden = 133179,
		Mongolian_Mongolian_Script_Standard = 133200,
		New_Tai_Lue = 134144,
		Bulgarian = 197634,
		Greek_220_Latin = 197640,
		United_StatesDvorak_for_left_hand = 197641,
		Thai_Pattachote_nonShiftLock = 197662,
		Armenian_Typewriter = 197675,
		Georgian_Ministry_of_Education_and_Science_Schools = 197687,
		Tai_Le = 199680,
		Bulgarian_phonetic_traditional = 263170,
		Greek_319_Latin = 263176,
		United_StatesDvorak_for_right_hand = 263177,
		Georgian_Old_Alphabets = 263223,
		Greek_Latin = 328712,
		Persian_Standard = 328745,
		Tifinagh_Basic = 330752,
		Greek_Polytonic = 394248,
		Tifinagh_Full = 396288,
		Lisu_Basic = 461824,
		Lisu_Standard = 527360,
		N_ko = 592896,
		Phagspa = 658432,
		Buginese = 723968,
		Gothic = 789504,
		Ol_Chiki = 855040,
		Osmanya = 920576,
		Old_Italic = 986112,
		Sora = 1051648,
		Javanese = 1117184,
		Futhark = 1182720
	}

	// Constructors
	static WVJmIOuiHfoHGzSrfIOlgfYfJWHl(); // 0x000000018478F3F0-0x000000018478FC40
}

internal static class eBbUmnmEZFTGwXhzRnIfDMLGelxl // TypeDefIndex: 53678
{
	// Fields
	private static IntPtr jhGooCbTTXmgjsKnAiicIgjWqgcZ; // 0x00
	private static int djdcjYgrGoQGLvNWbUgdAvzXkFsb; // 0x08

	// Constructors
	static eBbUmnmEZFTGwXhzRnIfDMLGelxl(); // 0x0000000184D79610-0x0000000184D79650

	// Methods
	public static extern IntPtr mVblMjPRjsUetvUoUmcLNFVJSEDf(); // 0x000000018AB9DD48-0x000000018AB9DDB0
	public static extern bool YpreMWhlQDtsLaQhjKBdzKOTcKFUA(IntPtr param_0007367c, out bool param_0007367d); // 0x000000018AB9DAF4-0x000000018AB9DB90
	internal static extern bool mtSaPCodCIAqAUkfFPZjykoitoKn(IntPtr param_0007367e, IntPtr param_0007367f, out uint param_00073680, bool param_00073681); // 0x000000018AB9DDB0-0x000000018AB9DE5C
	private static extern IntPtr aINYIkNGKjgQIePoEHPemiHSXijL(); // 0x0000000183827D50-0x0000000183827D80
	public static extern IntPtr ZUoaHEftkulQoYGMaACresswCinLA(); // 0x000000018381EC20-0x000000018381EC50
	public static IntPtr kZUgUEiEIyfFGHxEceelvhObUcBoc(IntPtr param_00073682, int param_00073683); // 0x00000001835AC770-0x00000001835AC7D0
	private static extern IntPtr WmEBbdHCmIkBFeSzenoaYkCQibeJB(IntPtr param_00073684, int param_00073685); // 0x000000018AB9DA74-0x000000018AB9DAF4
	private static extern IntPtr MOXnhZhygCYADfqDpxIHjSOlMTwC(IntPtr param_00073686, int param_00073687); // 0x00000001835AC7D0-0x00000001835AC810
	public static IntPtr XaklGCfEzDmqVaMUgSfIbZQAQQNO(IntPtr param_00073688, int param_00073689, IntPtr param_0007368a); // 0x0000000184D4F580-0x0000000184D4F5F0
	private static extern IntPtr wjSkeGElkCyagEEYBfiJpTZetwFD(IntPtr param_0007368b, int param_0007368c, IntPtr param_0007368d); // 0x0000000183826A80-0x0000000183826B20
	private static extern IntPtr uASAIjqNUPqHtfYKwpybaegkZxCk(IntPtr param_0007368e, int param_0007368f, IntPtr param_00073690); // 0x000000018AB9DED4-0x000000018AB9DF64
	public static extern uint QGORlCUYiiKgAzLxpdAHdjnrahLU(IntPtr param_00073691, ref uint param_00073692, uint param_00073693); // 0x0000000183826100-0x0000000183826150
	public static extern uint iIeFvfbrvrhiakPoCdEUVroOLDrjA(IntPtr param_00073694, ref uint param_00073695, uint param_00073696); // 0x00000001833021B0-0x0000000183302200
	public static extern int WApiiNqDPGoIKAKMKgRcADYUEbYIb(IntPtr param_00073697, ref uint param_00073698, uint param_00073699); // 0x0000000183125750-0x00000001831257A0
	public static extern bool aIJpRxEUveMkAIzAQksntrJeKZMO(uint param_0007369a, uint param_0007369b, ref int param_0007369c, uint param_0007369d); // 0x000000018AB9DB90-0x000000018AB9DC30
	public static extern int fJwuwuvwwrmjuhvIfnKQmmolYpJi(int param_0007369e); // 0x0000000183826210-0x0000000183826240
	public static extern bool MqdZpLPUVBfOfQdIdfgzsLVVqfih(out KcRercaTvoYLPFdZzeDXDMmffaMZB param_0007369f); // 0x000000018381EE30-0x000000018381EE70
	public static extern IntPtr RebJItCveBVpJKqaodwdZPKilOWfA(uint param_000736a0, bool param_000736a1, uint param_000736a2); // 0x000000018381EDE0-0x000000018381EE30
	public static extern short rfuzROnRasHNdEgqYTqCgOKwLKWA(int param_000736a3); // 0x000000018AB9DE5C-0x000000018AB9DED4
	public static extern short IOFqRHsvTosiCIcxKSBgPhrGcGLv(int param_000736a4); // 0x000000018AB9D9FC-0x000000018AB9DA74
	public static extern bool vXgltdkmbVXoHdcwURXyTbWyGSot(IntPtr param_000736a5); // 0x0000000183826240-0x0000000183826280
	public static extern bool UonCDnEqsFcEEdAjbiNEJDwzQoHTA(IntPtr param_000736a6, out KcRercaTvoYLPFdZzeDXDMmffaMZB param_000736a7); // 0x000000018381EEC0-0x000000018381EF10
	public static extern bool hItvGDbfGUBtFEhJcavuBXpHRnMFA(IntPtr param_000736a8, out VQEiCdnEbwGfohyMCMuyTfTNFUbCA param_000736a9); // 0x000000018381EE70-0x000000018381EEC0
	public static extern bool HDFmbmIZhkaUynASZHmIWMrSPwPR(IntPtr param_000736aa, out VQEiCdnEbwGfohyMCMuyTfTNFUbCA param_000736ab); // 0x000000018AB9D9B4-0x000000018AB9D9FC
	public static extern uint CdqMrhMtLwkHECFDINmClLVuMcKg(uint param_000736ac, uint param_000736ad); // 0x000000018381E910-0x000000018381E950
	public static extern IntPtr EBhNoGhmucqztNTmsDDLTVAaUCbb(int param_000736ae); // 0x000000018381EBA0-0x000000018381EBD0
	public static extern bool lrEincuMGLSvnKLPsrIwshYmAdwA(IntPtr param_000736af); // 0x00000001838269F0-0x0000000183826A80
	public static IntPtr WDfRYgPumOULOLJgJQmVbQrIGFcB(); // 0x000000018381CA30-0x000000018381CAD0
	public static bool buvZNiUIUGRrscMpoIFAmpdCtSlD(); // 0x000000018AB9DC30-0x000000018AB9DD48
}

internal struct aPUzMfNhVBeTKbkRTCyfUbYiSBad // TypeDefIndex: 53679
{
	// Fields
	private int mSeyKxQAdShumFrtyKzbiHWlRiBKA; // 0x00
	private long zxKpSeDznHgAjutJkXtmeQQiSipd; // 0x00
	private IntPtr lWAScQkfOAhowQEyDsTrkGqWuqhk; // 0x00
	private static readonly bool CLNuCZJxWQAbkDyrXrqOgHsjigEs; // 0x00
	public static readonly int eKqkynwsVFXrdjSOTPyGJFUMkkrC; // 0x04

	// Constructors
	static aPUzMfNhVBeTKbkRTCyfUbYiSBad(); // 0x0000000184D4FC00-0x0000000184D4FC60

	// Methods
	public static aPUzMfNhVBeTKbkRTCyfUbYiSBad OMkFuddpffkHwiQqkLMPATdLLdCg(byte[] param_000736b0, int param_000736b1); // 0x000000018AB9D8C4-0x000000018AB9D954
	public static aPUzMfNhVBeTKbkRTCyfUbYiSBad APoRgahkkqCivzZqzQUvGNyXvZFi(IntPtr param_000736b2); // 0x00000001847014E0-0x0000000184701550
	public static IntPtr APoRgahkkqCivzZqzQUvGNyXvZFi(aPUzMfNhVBeTKbkRTCyfUbYiSBad param_000736b3); // 0x000000018464E630-0x000000018464E640
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB9D954-0x000000018AB9D9B4
}

internal struct pHOXMyaEVxLmIeQfiMyGgXRiPlXo // TypeDefIndex: 53680
{
	// Fields
	private uint mSeyKxQAdShumFrtyKzbiHWlRiBKA; // 0x00
	private ulong zxKpSeDznHgAjutJkXtmeQQiSipd; // 0x00
	private IntPtr lWAScQkfOAhowQEyDsTrkGqWuqhk; // 0x00
	private static readonly bool CLNuCZJxWQAbkDyrXrqOgHsjigEs; // 0x00
	public static readonly int eKqkynwsVFXrdjSOTPyGJFUMkkrC; // 0x04

	// Constructors
	static pHOXMyaEVxLmIeQfiMyGgXRiPlXo(); // 0x0000000184D4FBA0-0x0000000184D4FC00

	// Methods
	public static pHOXMyaEVxLmIeQfiMyGgXRiPlXo OMkFuddpffkHwiQqkLMPATdLLdCg(byte[] param_000736b4, int param_000736b5); // 0x000000018AB9F7D0-0x000000018AB9F860
	public static IntPtr APoRgahkkqCivzZqzQUvGNyXvZFi(pHOXMyaEVxLmIeQfiMyGgXRiPlXo param_000736b6); // 0x000000018464E630-0x000000018464E640
	public static pHOXMyaEVxLmIeQfiMyGgXRiPlXo APoRgahkkqCivzZqzQUvGNyXvZFi(IntPtr param_000736b7); // 0x0000000184701550-0x00000001847015C0
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB9F860-0x000000018AB9F8C0
	public int JRtfSkgrFOUPKcSoGGvytyofYjqoA(); // 0x000000018AB9F794-0x000000018AB9F7D0
}

internal struct KcRercaTvoYLPFdZzeDXDMmffaMZB // TypeDefIndex: 53681
{
	// Fields
	public int mGBqRTPfHeiBcGQGSVwfLDhJaFFPA; // 0x00
	public int IuEuFRbjYKACLnaEzOkNJxcvuQDh; // 0x04
}

internal struct VQEiCdnEbwGfohyMCMuyTfTNFUbCA // TypeDefIndex: 53682
{
	// Fields
	public int lEFQlXWLnFTNCAEEMuDkRgWHehHGA; // 0x00
	public int hObSryZgXJCqCRnNQmTeHogmordb; // 0x04
	public int sDGCySJBpytXbWorNvWNemuxLOGU; // 0x08
	public int qUfwIaiDlSGlSVrgWNppsxAzrbBU; // 0x0C
}

internal static class tXkxDwISRsbqeYLWGfsMFeJEHmJpA // TypeDefIndex: 53683
{
	// Methods
	public static string dIfWoiGpEtcwfZsXRYmQBQOGIOBi(IntPtr param_000736b8, int param_000736b9); // 0x00000001835AB610-0x00000001835AB6D0
	public static string CspekwhrfweFnBDOKYLdmhXUeNqz(IntPtr param_000736ba, int param_000736bb); // 0x00000001835ABF70-0x00000001835ABFC0
	public static string iILbmyixUpigvnVNpEEdLTAeRcwMA(string param_000736bc); // 0x00000001835ABFC0-0x00000001835AC010
}

internal class giqbwdSVuzgXFgkujBcrjDMNLMUiA : IDisposable // TypeDefIndex: 53686
{
	// Fields
	private static giqbwdSVuzgXFgkujBcrjDMNLMUiA xrdNMXQNXfwPuveZIufXarNDAOKx; // 0x00
	private IntPtr DeOHTVgQqhcbFDmJhcggSlSCxvzsA; // 0x10
	private BpzSPrKUTnftWgconIhCbVUdvRvQ WUMFXfiPIyywQrNVmfPpXkwykxfDA; // 0x18
	private Action<aPUzMfNhVBeTKbkRTCyfUbYiSBad, pHOXMyaEVxLmIeQfiMyGgXRiPlXo, uint, IntPtr> yIQEQPsFoUoPPebLcCIGVRJRNXMs; // 0x20
	private byte[] xiSQyUJbdJOSwLdgMSHXUaxlhGAy; // 0x28
	private readonly bool CLNuCZJxWQAbkDyrXrqOgHsjigEs; // 0x30
	private yOyuUSsjdEKXCWupRyogKAjJKPXD jUAFetMPiWkANiBPmflieXIoLdkoA; // 0x38
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x58

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr BpzSPrKUTnftWgconIhCbVUdvRvQ(int nCode, IntPtr wParam, IntPtr lParam); // TypeDefIndex: 53684; 0x00000001814F3120-0x00000001814F3140

	private struct yOyuUSsjdEKXCWupRyogKAjJKPXD // TypeDefIndex: 53685
	{
		// Fields
		public IntPtr BItnZqEPinFijJHiEtvVEzrOxjwE; // 0x00
		public IntPtr SHeBnGHckcHYYRnaIIswCUuCgSxSb; // 0x08
		public uint GYiSpBZiGtoJaWMVArjnSSgOHOyt; // 0x10
		public IntPtr yUKGHeunFQwIeZWgVIHaeJTCUgpT; // 0x18
	}

	// Constructors
	public giqbwdSVuzgXFgkujBcrjDMNLMUiA(); // 0x000000018AB9E1F0-0x000000018AB9E2CC

	// Methods
	public void fyNzemgyjZNUwhYKrMOEPxWkSvtb(Action<aPUzMfNhVBeTKbkRTCyfUbYiSBad, pHOXMyaEVxLmIeQfiMyGgXRiPlXo, uint, IntPtr> param_000736bd, bool param_000736be); // 0x000000018AB9E2CC-0x000000018AB9E3B4
	public void sPMCdCGkvTWCiroURfkKtrpakKwyA(); // 0x000000018AB9E750-0x000000018AB9E7B0
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(BpzSPrKUTnftWgconIhCbVUdvRvQ))]
	private static IntPtr oJhyHmkjymBxsdWHVDkmPYXPsQEvA(int param_000736bf, IntPtr param_000736c0, IntPtr param_000736c1); // 0x000000018AB9E454-0x000000018AB9E750
	public void Dispose(); // 0x000000018AB9DF94-0x000000018AB9DFE4
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB9E17C-0x000000018AB9E1F0
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000736c2); // 0x000000018AB9E110-0x000000018AB9E17C
	private static extern IntPtr KdIYStopGjSUYeJgXgIBHbMUzaEJA(int param_000736c3, BpzSPrKUTnftWgconIhCbVUdvRvQ param_000736c4, IntPtr param_000736c5, uint param_000736c6); // 0x000000018AB9E060-0x000000018AB9E110
	private static extern bool HArxDIMFfWqSlphPYRpMnhTdtkXj(IntPtr param_000736c7); // 0x000000018AB9DFE4-0x000000018AB9E060
	private static extern IntPtr iKxvmKSBVHzPmdBLtLaLejObFmL(IntPtr param_000736c8, int param_000736c9, IntPtr param_000736ca, IntPtr param_000736cb); // 0x000000018AB9E3B4-0x000000018AB9E454
}

internal static class GhphCjTTtxbPXhyujaPMwvhvlMRD // TypeDefIndex: 53687
{
	// Methods
	public static string vaOpvJjlGEDKEbdIFaCHClVgHLMK(string param_000736d1); // 0x00000001835AA960-0x00000001835AAA00
	public static DKfdSpPOsWGnACTRAulCFEVLxkQk pyaFZFgMVvquylYyXNdJqCakLGAD(int param_000736d2); // 0x000000018AB986F0-0x000000018AB9870C
}

internal static class vLBQszORMVnneBVHflZvQbEcUEeo // TypeDefIndex: 53692
{
	// Fields
	private static Guid[] CgcBYYaglKgXNsjABcKnntGWtzsIA; // 0x00
	private static string[] NrphhDYdCGGEuFzTOlNTyWnEMkdp; // 0x08
	private static readonly hVGxLyMVpLAbzuwdUUJdJbNOTTHI[] ohquEhhtrDdhnGLUusKGMIjdgsEEA; // 0x10

	// Nested types
	public enum cBwLnixqKismFQXZofhvMEalYjTS // TypeDefIndex: 53688
	{
		None = 0,
		CombinedTriggers = 1,
		SplitTriggers = 2
	}

	private struct hVGxLyMVpLAbzuwdUUJdJbNOTTHI // TypeDefIndex: 53690
	{
		// Fields
		public PidVid UpyzrRZKfKsNDZOSBiHvfgsXnMEj; // 0x00
		public ktfDPlUaOAAfdEZveKmPxELRhcXGA QIFfqVFzAOVHXQCtcKcTtPAIinvib; // 0x04
		public RNUXpWQSHQZQxcCWdcDApglzUSgr FNIpviIZOJyPidyUpXYmPGfCEKoB; // 0x08

		// Nested types
		public enum RNUXpWQSHQZQxcCWdcDApglzUSgr // TypeDefIndex: 53689
		{
			MatchAnyOption = 0,
			MatchAllOptions = 1,
			IgnoreOptions = 2
		}

		// Constructors
		public hVGxLyMVpLAbzuwdUUJdJbNOTTHI(PidVid param_000736e3, ktfDPlUaOAAfdEZveKmPxELRhcXGA param_000736e4, RNUXpWQSHQZQxcCWdcDApglzUSgr param_000736e5); // 0x0000000184D85D60-0x0000000184D85D70

		// Methods
		public bool HzPmTNZHjTeMRqJVTLSBKHKRLNFG(ushort param_000736e6, ushort param_000736e7, ktfDPlUaOAAfdEZveKmPxELRhcXGA param_000736e8); // 0x0000000183A45080-0x0000000183A450A0
	}

	public enum ktfDPlUaOAAfdEZveKmPxELRhcXGA // TypeDefIndex: 53691
	{
		None = 0,
		Bluetooth = 1,
		USB = 2
	}

	// Constructors
	static vLBQszORMVnneBVHflZvQbEcUEeo(); // 0x0000000183CBDB50-0x0000000183CBDE90

	// Methods
	public static string PGezzyYCrBikwHWNIDoWZBxdgidr(IdxcAbgzMTzxeMxdElxolIcPzwurA param_000736d3, Guid param_000736d4, string param_000736d5, string param_000736d6); // 0x000000018ABA1D34-0x000000018ABA1E18
	public static cBwLnixqKismFQXZofhvMEalYjTS HZNIaIXuWQslfOqkTjsGnbfRuMUf(JXtFhzUqozCGLAAgSlsxdSapKppi[] param_000736d7, Guid param_000736d8, string param_000736d9, string param_000736da); // 0x000000018ABA1ABC-0x000000018ABA1BAC
	public static bool MSIlIbPadRQqbtMaGWMtdJAHLVcw(Guid param_000736db, string param_000736dc, string param_000736dd); // 0x000000018ABA1BAC-0x000000018ABA1C70
	private static bool MSIlIbPadRQqbtMaGWMtdJAHLVcw(string param_000736de); // 0x000000018ABA1C70-0x000000018ABA1D34
	public static bool VjotqwmHEoalFmdAcNGVuRMHdKHl(InputSource param_000736df, ushort param_000736e0, ushort param_000736e1, ktfDPlUaOAAfdEZveKmPxELRhcXGA param_000736e2); // 0x0000000183A44F90-0x0000000183A45080
}

internal class lGhpciCdniKLZLdOpeIcKWUFYWuAA : NativeBuffer // TypeDefIndex: 53695
{
	// Fields
	private int ARMDhMHmzbvBrDpoCmzpPwhAYelH; // 0x20
	private int xhdJuNERqkqVaqnRcSmwOhKHNEBX; // 0x24

	// Properties
	public int PcQxRrpvvqjayMZVpLpbDQDWvzwE { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
	public int vtNMEckrEDwwdSQRzPgmASJgjhhA { get; } // 0x00000001811F0020-0x00000001811F0030 

	// Constructors
	public lGhpciCdniKLZLdOpeIcKWUFYWuAA(int param_000736ee, int param_000736ef); // 0x0000000183A41A60-0x0000000183A41AA0
}

internal class yoxkQKAzOinufduFGBoeZHuXZtZs : HaRQsfqAjhzwicvrCCTdcrSnwyKT, xLiBDACQHMkUJDONyqwWiGgepFzkA // TypeDefIndex: 53696
{
	// Fields
	private int mBtXxAjzptwoKVBtfVsfIdZmEYkaA; // 0x88
	private ZmIGzJfowxKiyvJARuzfVHOOhwvO xFLnPrexJXswFVXEkgAhMuNZCpht; // 0x8C
	private ButtonLoopSet IHIyAzYqVGZzizmnkIHKmAeHgozdA; // 0x90
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI[] GJbtoqUIykdcrGykLQjVjDezPgJxA; // 0x98
	private lDGIHZYGcLWiHYTgTEPoVmylQNXj[] LtGmEoLLKZvMSrZMgZvuWCvJcDnd; // 0xA0
	private int[] ptbQKkpEDgBhsYrynckUvpfYYHFU; // 0xA8
	private BMNnWbDIXUHHRoADwVXJdYVDrPxr[] pwTFGqaDAvbwdtAHZUQEMuzBtJye; // 0xB0
	private PiAoaHLiNJrbgVmbRfzTAJWkhYXRA[] vJweGtIZaBncuhKZXlpCUfsdgczwA; // 0xB8
	private psxalbFqqRAvexHgaNTDxDrhdRTx[] KIdoASIgWEKMdqdOcogiRdGmfiLm; // 0xC0
	private int mcjmovIdelhuuidgbQwUjRMuilVGb; // 0xC8
	private int YjYHQqCNXeaLDEeDhECJjazcWtgF; // 0xCC
	private int BtfhKVXdSTHOOxDkoIwphIDlNZqcb; // 0xD0
	private int nMNSFsXvIsgyxKIlmLyrhmKMLApr; // 0xD4
	private int wpkAbqiVmRvyGdfPJDaumiKNdzWb; // 0xD8
	private int cEfMSmeQgaugyaKlKsXahkDOPKaN; // 0xDC
	private jtKDhEFaghTPhKKmJDXICzhwqTbdA HxrCCKzryTDGXMECTZRBGfrJuWNP; // 0xE0
	private REPhaSELegkrQWkZsOTraGFJMQPm qgkBPVGanQwqEoopacOQPQnqiiwaA; // 0xE8
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xF0

	// Properties
	public int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; } // 0x0000000184D86890-0x0000000184D868A0 
	public ZmIGzJfowxKiyvJARuzfVHOOhwvO zPAolPHIpBxdaALaMIjQXvmkttvN { get; } // 0x0000000184D90C40-0x0000000184D90C50 
	public bool[] PlahzMFUWWFVTEjviHdVVhgEfBVTb { get; } // 0x000000018ABA2D34-0x000000018ABA2D8C 
	public int[] dGjaUTfRZTkKwqBTUsMjpTIBIgssA { get; } // 0x0000000184D86290-0x0000000184D862A0 
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { get; } // 0x0000000184D89300-0x0000000184D89310 
	public int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; } // 0x0000000184DA5BE0-0x0000000184DA5BF0 
	public int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; } // 0x0000000184D9E810-0x0000000184D9E820 
	public bool UZsYTHlvNqSwfBIafJHUuzcvloTP { get; } // 0x000000018ABA2B00-0x000000018ABA2B20 
	public bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; } // 0x000000018ABA224C-0x000000018ABA2270 
	public int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; } // 0x000000018ABA28E4-0x000000018ABA2904 
	public InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; } // 0x0000000184DA87D0-0x0000000184DA87E0 
	public lDcxHnYDfFcPYdZdkSWGiPhmdwgmA xZeMZzjkWTwGJcpflslctbmZrXFI { get; } // 0x0000000184D88590-0x0000000184D885A0 

	// Constructors
	public yoxkQKAzOinufduFGBoeZHuXZtZs(int param_000736f0, ZmIGzJfowxKiyvJARuzfVHOOhwvO param_000736f1, IntPtr param_000736f2, IdxcAbgzMTzxeMxdElxolIcPzwurA param_000736f3, HIDDeviceDriver param_000736f4, jtKDhEFaghTPhKKmJDXICzhwqTbdA param_000736f5, qMSJAGnGFztVWGbbMtcbmLOJutTU param_000736f6, qMSJAGnGFztVWGbbMtcbmLOJutTU param_000736f7, nqaKskRUwxbeUaaRxyXfhGNcbkBm param_000736f8); // 0x000000018ABA2904-0x000000018ABA2AA8

	// Methods
	public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_000736f9); // 0x000000018ABA2834-0x000000018ABA28E4
	public override void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018ABA2AA8-0x000000018ABA2B00
	public void EGhvxPKhXjlkipAYJerjFLXFedUDA(IntPtr param_000736fa, int param_000736fb, int param_000736fc, int param_000736fd, double param_000736fe); // 0x000000018ABA20FC-0x000000018ABA215C
	public override void ZoGbtSrjNkpybJlqlhkJDQCcPlkF(); // 0x00000001841E1670-0x00000001841E1680
	public override void IoyeuUADILkjyEidcCIyeCInNLwS(); // 0x00000001841E1670-0x00000001841E1680
	public void nextLeCtjcIrhGkHxnHsBgbWXbjk(int param_000736ff); // 0x0000000184D868C0-0x0000000184D868D0
	private void QYFGQngsPeNUUNpXdBFatEpLZoZp(); // 0x000000018ABA2438-0x000000018ABA27DC
	private void yfAvlFShiJiZPPnfreeMjhGTujmfA(); // 0x000000018ABA2C98-0x000000018ABA2D34
	private void LeBKgVoQDbqkNKUSJHDqrUoYHwJG(); // 0x000000018ABA215C-0x000000018ABA224C
	private void NkoqbCbQUJeDuCjzLLadeyqGfntS(); // 0x000000018ABA2270-0x000000018ABA22F0
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI yPoaNQvvcNMxHtlrvgHzoXzbIFeW(MkXjQPavsbpITCEdETTHuRYirZF param_00073700); // 0x000000018ABA2B20-0x000000018ABA2C98
	private lDGIHZYGcLWiHYTgTEPoVmylQNXj OJwknHEmjnbROhMpZBraZkwqRtHX(aGpYUdpKsUxonfUNYstiGMzKpBRk param_00073701); // 0x000000018ABA22F0-0x000000018ABA2438
	protected override void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073702); // 0x000000018ABA27DC-0x000000018ABA2834
}

internal abstract class HaRQsfqAjhzwicvrCCTdcrSnwyKT : kRbZYuhpKzSxbqUHMGxBcrQvRuQg // TypeDefIndex: 53697
{
	// Fields
	protected readonly IdxcAbgzMTzxeMxdElxolIcPzwurA gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x10
	protected IntPtr isHQxXecLduNfiWGxkrHfvsWgIsE; // 0x18
	protected readonly int XQvtCusCtAEoYWxBkkoHIoYcGiaU; // 0x20
	protected readonly int EYQTklduEJzoxqzOSSEeKMSxKxoi; // 0x24
	protected readonly Guid qKekwXsBMukAxFnBNFkJDCVTDlznA; // 0x28
	protected readonly Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x38
	protected readonly Rewired.Platforms.Windows.RawInput.DeviceType FMzRoXctgKLenpvIAfMtMnMnbNBk; // 0x48
	protected readonly string quubyidsFhNFAnfvVjmYFMOaPEQH; // 0x50
	protected HIDDeviceDriver xSDSLufssJEtmYFdQOIwxgEFLEkU; // 0x58
	protected Rewired.Controller.Extension RHSxHLIJnOQXQFTHMLuenqSPAUBl; // 0x60
	private string PVQUUSEIzTeZUHBcetsfEbHibgWzA; // 0x68
	private string rDcwFZlfPcdyfASfWpmIznIxtNIK; // 0x70
	private string WLiaFevFoghspTGDIgADfurVDcLx; // 0x78
	private bool apZuRExaLlBCFipLUlwkVKcITRcUA; // 0x80
	private bool hXmBWshQEpHBfShlSZWTLNVDMNvcb; // 0x81
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x82

	// Properties
	public IdxcAbgzMTzxeMxdElxolIcPzwurA SbVXyACZfupWZsZEfJQfxoOrIiVU { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	public IntPtr TNXzHXXjfaOmNhNeeIHeezCdZXKX { get; } // 0x000000018385B100-0x000000018385B110 
	public string LOikUxXJsvTgyuFJrAzLxiECoOlH { get; } // 0x000000018AB98FD8-0x000000018AB9905C 
	public string YYRyzKMAZwsaThONuxJfKsPrqcLy { get; } // 0x000000018AB98F54-0x000000018AB98FD8 
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB { get; } // 0x00000001811F0020-0x00000001811F0030 
	public Guid ystlCDcHjwlcYzgaLpkqnMWqYczw { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
	public Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; } // 0x0000000184D8FD20-0x0000000184D8FD30 
	public Rewired.Platforms.Windows.RawInput.DeviceType psAUfTCmGaZDidaHRsWjLEaznECN { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	public bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; } // 0x000000018AB990AC-0x000000018AB990C8 
	public string RCkbDMwhfgaXSHlSrLNVbcJiljIPc { get; } // 0x000000018AB98B74-0x000000018AB98B90 
	public string tBRcGxIJicmbDzuBDnHFPihxnYHiA { get; } // 0x000000018AB98E94-0x000000018AB98F54 
	public HIDDeviceDriver ATxmJEZGRZxXPLUqrLKAwlFIyGbB { get; } // 0x0000000182E56440-0x0000000182E56460 
	public Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; } // 0x0000000184D86280-0x0000000184D86290 
	public virtual bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x000000018AB990C8-0x000000018AB990D4 

	// Constructors
	public HaRQsfqAjhzwicvrCCTdcrSnwyKT(IdxcAbgzMTzxeMxdElxolIcPzwurA param_00073703, IntPtr param_00073704); // 0x000000018AB98CEC-0x000000018AB98E94

	// Methods
	public virtual void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073705); // 0x000000018AB98C58-0x000000018AB98C74
	public abstract void UpdateFinished();
	public void Dispose(); // 0x000000018AB98B90-0x000000018AB98BE0
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018AB98C74-0x000000018AB98CEC
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073706); // 0x000000018AB98BE0-0x000000018AB98C58
	private static Rewired.Platforms.Windows.RawInput.DeviceType rlshlhoHiVFHIOUBzbvZSjotESWN(ushort param_00073707, ushort param_00073708); // 0x000000018AB9905C-0x000000018AB990AC
	public abstract void Acquire();
	public abstract void Unacquire();
}

internal abstract class FmarwRrUedMdVuRPApXNMZUKevwt // TypeDefIndex: 53698
{
	// Fields
	public readonly ushort CYtxSBIcDASRtcEBicXiSLSLYjuR; // 0x10
	public readonly ushort JgkXfSUVjtjfBrljIbYIZHzHjCnF; // 0x12
	public readonly int qssLBWSvoLTpoBvyurpyOEBeNhbH; // 0x14
	public readonly int CItJkcFXmZYkOiftjDDXUUoGRIiF; // 0x18
	public readonly byte jLKgYPbCXIqnNylkRhlRiDlyritOA; // 0x1C

	// Constructors
	public FmarwRrUedMdVuRPApXNMZUKevwt(byte param_00073709, ushort param_0007370a, ushort param_0007370b, int param_0007370c, int param_0007370d); // 0x0000000184DA8740-0x0000000184DA8760

	// Methods
	public abstract void ghAXNTTllFZJImfdUqzOVvWsJmgN();
}

internal class ofHLpdJoyXyoAkNJdIeRpwrQxGCI : FmarwRrUedMdVuRPApXNMZUKevwt // TypeDefIndex: 53699
{
	// Fields
	public readonly bool RoLXagipAOyrXOjFMzxhjrdmXWLG; // 0x20
	private int fWwTZTHbcPcIEYZpEtfEsajMiaIp; // 0x24
	private int KFhZWgJZixHxMvDVtKNjoDRKwDbM; // 0x28
	private bool YwkcIKYSshvqsxwtFCMyQloyKnpF; // 0x2C
	public readonly int oOVvmUPhByFiqPOnPaXNVlZlRWGm; // 0x30
	public readonly int DGlDtTrpmBjccXjYUBVqwOSdCDvFA; // 0x34
	public readonly int rNxqpwUDMhZJdxAkmGbCaLpZerhT; // 0x38
	public readonly int PIjOKvoDxxKKlQnhvHFAsWLEMusB; // 0x3C
	public readonly int EgYWHUGEeXwNQkBphcmllhqUoQN; // 0x40
	public readonly int JmYBMRmnvcmZvvOwFanjsNCmckbU; // 0x44
	public readonly uint uEPipKocdogNQddecQKPaLvQzJJk; // 0x48
	public readonly uint pArhwaIupbnZPmpkWCLXrGKenRnv; // 0x4C
	public readonly int HuvNDRZdtIchEfaQqXBEegVqlybd; // 0x50
	public uint nXdBpypsCihkGgjdHnUwIADZGegB; // 0x54

	// Properties
	public virtual int IaOjDqjXmTvIEPrVtSrrcPlQvkii { get; } // 0x000000018AB9F6A8-0x000000018AB9F710 

	// Constructors
	public ofHLpdJoyXyoAkNJdIeRpwrQxGCI(byte param_0007370e, ushort param_0007370f, ushort param_00073710, int param_00073711, int param_00073712, int param_00073713, int param_00073714, int param_00073715, int param_00073716, uint param_00073717, uint param_00073718, int param_00073719, bool param_0007371a); // 0x000000018AB9F540-0x000000018AB9F6A8

	// Methods
	public override void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x0000000184DA87B0-0x0000000184DA87C0
	private static float tyTDSVbkDOqKgMUIpShNJBBGFVdbA(float param_0007371b, float param_0007371c, float param_0007371d, float param_0007371e, float param_0007371f); // 0x000000018AB9F710-0x000000018AB9F794
	private void VZZXTrHYntrgnxApHogYkofmzrBD(); // 0x000000018AB9F50C-0x000000018AB9F540
}

internal class lDGIHZYGcLWiHYTgTEPoVmylQNXj : FmarwRrUedMdVuRPApXNMZUKevwt // TypeDefIndex: 53700
{
	// Fields
	public readonly int oOVvmUPhByFiqPOnPaXNVlZlRWGm; // 0x20
	public readonly int DGlDtTrpmBjccXjYUBVqwOSdCDvFA; // 0x24
	public readonly int rNxqpwUDMhZJdxAkmGbCaLpZerhT; // 0x28
	public readonly int JmYBMRmnvcmZvvOwFanjsNCmckbU; // 0x2C
	public readonly uint uEPipKocdogNQddecQKPaLvQzJJk; // 0x30
	public readonly uint WBKovobkLnOROkwKNIKEDnBYCIHk; // 0x34
	public readonly int HuvNDRZdtIchEfaQqXBEegVqlybd; // 0x38
	private readonly int YsBFBxKqvcihsgnlhdePABEJMxddb; // 0x3C
	public uint nXdBpypsCihkGgjdHnUwIADZGegB; // 0x40

	// Properties
	public int IaOjDqjXmTvIEPrVtSrrcPlQvkii { get; } // 0x000000018AB9F464-0x000000018AB9F4A8 

	// Constructors
	public lDGIHZYGcLWiHYTgTEPoVmylQNXj(byte param_00073720, ushort param_00073721, ushort param_00073722, int param_00073723, int param_00073724, int param_00073725, int param_00073726, int param_00073727, int param_00073728, uint param_00073729, uint param_0007372a, int param_0007372b); // 0x000000018AB9F3DC-0x000000018AB9F464

	// Methods
	public override void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x0000000184DA87A0-0x0000000184DA87B0
}

internal interface kRbZYuhpKzSxbqUHMGxBcrQvRuQg : IDisposable // TypeDefIndex: 53702
{
	// Properties
	IdxcAbgzMTzxeMxdElxolIcPzwurA SbVXyACZfupWZsZEfJQfxoOrIiVU { get; }
	IntPtr TNXzHXXjfaOmNhNeeIHeezCdZXKX { get; }
	string LOikUxXJsvTgyuFJrAzLxiECoOlH { get; }
	string YYRyzKMAZwsaThONuxJfKsPrqcLy { get; }
	int WrZJIhOLVdLWUIrJApfNbpXUMNdG { get; }
	int KnragBIqiQeRNgMAwjMLFeBdfrAKB { get; }
	Guid ystlCDcHjwlcYzgaLpkqnMWqYczw { get; }
	Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; }
	Rewired.Platforms.Windows.RawInput.DeviceType psAUfTCmGaZDidaHRsWjLEaznECN { get; }
	bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; }
	string RCkbDMwhfgaXSHlSrLNVbcJiljIPc { get; }
	string tBRcGxIJicmbDzuBDnHFPihxnYHiA { get; }
	HIDDeviceDriver ATxmJEZGRZxXPLUqrLKAwlFIyGbB { get; }
	Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; }
	bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; }

	// Methods
	void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_0007372c);
	void UpdateFinished();
	void Acquire();
	void Unacquire();
}

internal interface xLiBDACQHMkUJDONyqwWiGgepFzkA : kRbZYuhpKzSxbqUHMGxBcrQvRuQg // TypeDefIndex: 53703
{
	// Properties
	int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; }
	ZmIGzJfowxKiyvJARuzfVHOOhwvO zPAolPHIpBxdaALaMIjQXvmkttvN { get; }
	bool[] PlahzMFUWWFVTEjviHdVVhgEfBVTb { get; }
	int[] dGjaUTfRZTkKwqBTUsMjpTIBIgssA { get; }
	int iNOQjioNbBRxJPHSCBvgxibcstpi { get; }
	int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; }
	int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; }
	bool UZsYTHlvNqSwfBIafJHUuzcvloTP { get; }
	bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; }
	int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; }
	lDcxHnYDfFcPYdZdkSWGiPhmdwgmA xZeMZzjkWTwGJcpflslctbmZrXFI { get; }
	InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; }

	// Methods
	void EGhvxPKhXjlkipAYJerjFLXFedUDA(IntPtr param_0007372d, int param_0007372e, int param_0007372f, int param_00073730, double param_00073731);
	void nextLeCtjcIrhGkHxnHsBgbWXbjk(int param_00073732);
}

internal abstract class sYIBzoAewKjkEjeRAitFzrgWDNJT // TypeDefIndex: 53704
{
	// Fields
	public uint pQtHvGVCzCmCrGrDIKFSgCUebtrc; // 0x10
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x18
	private static uint DjYOQmKcYVdfbFDaNMPPNRStKZchA; // 0x00

	// Constructors
	protected sYIBzoAewKjkEjeRAitFzrgWDNJT(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void lBMTbRuwRfNSwCPcHnAiVMhJqLHQ(); // 0x000000018381D0E0-0x000000018381D120
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABA03D0-0x000000018ABA0484
}

internal class hzfUWCjNPPmSYyCeozhXHZrHbmeI : sYIBzoAewKjkEjeRAitFzrgWDNJT // TypeDefIndex: 53705
{
	// Fields
	public agWzVEkIFodpccVvGQaNfUcyYDIUA UyaGHWZvWIteWvfDgGjbzZeHjQQK; // 0x20
	public uint JoeFjwiaulVHgZhxlPLWnaPITfts; // 0x24
	public IntPtr XYJbperUKfiSMXQUuxMvCcxQOWRH; // 0x28
	public uint woIGtSGdtUcVvQuxOtLBOOrHTONdA; // 0x30
	public nEjeDBVgexNIjqfJlYOtOMoVihOf CcGAZCkbEErnfWNngLuNuACDmDMi; // 0x34
	public int wvnGnMksBcdHlGsKIaaiKpalCvYQA; // 0x38
	public int mGBqRTPfHeiBcGQGSVwfLDhJaFFPA; // 0x3C
	public int IuEuFRbjYKACLnaEzOkNJxcvuQDh; // 0x40

	// Constructors
	public hzfUWCjNPPmSYyCeozhXHZrHbmeI(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void OSNJxVibfKbltujYHkKMLuczmano(ref DjdfDrcNukTKWfrrRLbyuQXQgKyCb param_00073733); // 0x000000018381D050-0x000000018381D0E0
}

internal class YuzVBZAVrBXogjeFXEIGbMAEejwR : sYIBzoAewKjkEjeRAitFzrgWDNJT // TypeDefIndex: 53706
{
	// Fields
	public IntPtr XYJbperUKfiSMXQUuxMvCcxQOWRH; // 0x20
	public int woIGtSGdtUcVvQuxOtLBOOrHTONdA; // 0x28
	public Keys UmyNWYNGsDkKSppwkXNznNcyFFi; // 0x2C
	public int mkRrFNNqQHBKrbXchFRsWwfXUSUr; // 0x30
	public ScanCodeFlags rkWGfnHUNWjnnmKIJTSDLmHAEmMF; // 0x34
	public KeyState qiGcZSJxGopIPnLDnLXfDzOCSjRf; // 0x38

	// Constructors
	public YuzVBZAVrBXogjeFXEIGbMAEejwR(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void OSNJxVibfKbltujYHkKMLuczmano(ref mSXBYzcjZtWtzBMaRNJMFIuGieHBb param_00073734); // 0x000000018381CED0-0x000000018381CF50
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018AB9D3E8-0x000000018AB9D620
}

internal class KPUcNweIcXXVKPnTNSXZVDWPwgse : HaRQsfqAjhzwicvrCCTdcrSnwyKT, xLiBDACQHMkUJDONyqwWiGgepFzkA // TypeDefIndex: 53712
{
	// Fields
	private int mBtXxAjzptwoKVBtfVsfIdZmEYkaA; // 0x88
	private ZmIGzJfowxKiyvJARuzfVHOOhwvO xFLnPrexJXswFVXEkgAhMuNZCpht; // 0x8C
	private byte[] SfWHMhEQffceqCxChQCMGIWBFvjY; // 0x90
	private bool[] RfwbnIKYoVwQtKTjiMBpekzBmYuRB; // 0x98
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI[] gcjeHrVCyOAaoLsvYNhudVTIHQgJ; // 0xA0
	private lDGIHZYGcLWiHYTgTEPoVmylQNXj[] LtGmEoLLKZvMSrZMgZvuWCvJcDnd; // 0xA8
	private int[] ptbQKkpEDgBhsYrynckUvpfYYHFU; // 0xB0
	private int mcjmovIdelhuuidgbQwUjRMuilVGb; // 0xB8
	private int YjYHQqCNXeaLDEeDhECJjazcWtgF; // 0xBC
	private int BtfhKVXdSTHOOxDkoIwphIDlNZqcb; // 0xC0
	private ButtonLoopSet sNHNPUwkJdSniwWpqjpgKZvUkcXg; // 0xC8
	private xUWOnZkFHcMPURTJdtYlIgDFwfmM[] hXDoEyYQoJgfXwOXbArUETuYGYAbb; // 0xD0
	private PbkriHrdXjmJsObVndfZLuSHkcJi[] uisUnTdfntpnriCTOZjVYKThVwTo; // 0xD8
	private EzzIvMwZfCNBGPLqavLvXOMUteoA[] hDMEzXotsvtXLqJFBhWKZRkfOlxL; // 0xE0
	private ushort[] LBofQdnVqcAIRsZmZNlDqcjdGJfEA; // 0xE8
	private MlriOiaGsGcNChpISALUGlIRPxwK qgkBPVGanQwqEoopacOQPQnqiiwaA; // 0xF0
	private readonly GmZKiAtyHCxBQdcQbJSlTPDYeHyh BIleMrLcjqEJKTdwToLetqnibgvs; // 0xF8
	private readonly AList<MDBYECqvXkaCiSmYJZjrizfidEbk.dHQmwhHbvgbNuAqIBFbWyaCtzDht> LocOfmjjUUdCSthXHMfTJGFjgbXu; // 0x100
	private NativeBuffer UHQnNXyjuWbiHeVFjcNUcaJruuoV; // 0x108
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x110

	// Properties
	public int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; } // 0x0000000184D86890-0x0000000184D868A0 
	public ZmIGzJfowxKiyvJARuzfVHOOhwvO zPAolPHIpBxdaALaMIjQXvmkttvN { get; } // 0x0000000184D90C40-0x0000000184D90C50 
	public bool[] PlahzMFUWWFVTEjviHdVVhgEfBVTb { get; } // 0x000000018AB9B820-0x000000018AB9B878 
	public int[] dGjaUTfRZTkKwqBTUsMjpTIBIgssA { get; } // 0x0000000184D86250-0x0000000184D86260 
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { get; } // 0x0000000184D8E580-0x0000000184D8E590 
	public int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; } // 0x0000000184DA32C0-0x0000000184DA32D0 
	public int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; } // 0x0000000184DA4B70-0x0000000184DA4B80 
	public bool UZsYTHlvNqSwfBIafJHUuzcvloTP { get; } // 0x000000018AB9B3E8-0x000000018AB9B408 
	public bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; } // 0x00000001812081B0-0x0000000181208610 
	public int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; } // 0x00000001811EC580-0x00000001811EC590 
	public InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	public lDcxHnYDfFcPYdZdkSWGiPhmdwgmA xZeMZzjkWTwGJcpflslctbmZrXFI { get; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 

	// Nested types
	private class xUWOnZkFHcMPURTJdtYlIgDFwfmM // TypeDefIndex: 53707
	{
		// Fields
		public readonly aHzSDAgzXeTUuXeKeiUwhHjMNyKD UdRQWEcmSrmdmUBMTQBqIWRcBfSc; // 0x10

		// Constructors
		public xUWOnZkFHcMPURTJdtYlIgDFwfmM(aHzSDAgzXeTUuXeKeiUwhHjMNyKD param_00073790); // 0x00000001853908C0-0x00000001853908D0
	}

	private class PbkriHrdXjmJsObVndfZLuSHkcJi // TypeDefIndex: 53708
	{
		// Fields
		public readonly JXtFhzUqozCGLAAgSlsxdSapKppi UdRQWEcmSrmdmUBMTQBqIWRcBfSc; // 0x10

		// Constructors
		public PbkriHrdXjmJsObVndfZLuSHkcJi(JXtFhzUqozCGLAAgSlsxdSapKppi param_00073791); // 0x00000001853908C0-0x00000001853908D0
	}

	private abstract class EzzIvMwZfCNBGPLqavLvXOMUteoA // TypeDefIndex: 53709
	{
		// Fields
		public readonly bool FIiAJPiqkxSDvPfuQJAZoysjMwBA; // 0x10

		// Constructors
		protected EzzIvMwZfCNBGPLqavLvXOMUteoA(bool param_00073792); // 0x0000000184D86130-0x0000000184D86140
	}

	private class YydebhCXXfXOawTbRGxYgLNGUlsXB : EzzIvMwZfCNBGPLqavLvXOMUteoA // TypeDefIndex: 53710
	{
		// Fields
		public readonly FmarwRrUedMdVuRPApXNMZUKevwt[] PRUUGFIsJlhtSfHuElXmCPJYUYvpA; // 0x18

		// Constructors
		public YydebhCXXfXOawTbRGxYgLNGUlsXB(int param_00073793); // 0x000000018AB9D620-0x000000018AB9D684
	}

	private class obkXOyhqGBxlUiRonqACcRxSKuZe : EzzIvMwZfCNBGPLqavLvXOMUteoA // TypeDefIndex: 53711
	{
		// Fields
		public readonly YydebhCXXfXOawTbRGxYgLNGUlsXB[] hwPxKvUnzBBTjiCXpLUOuTjmaMSX; // 0x18

		// Constructors
		public obkXOyhqGBxlUiRonqACcRxSKuZe(int param_00073794); // 0x000000018AB9F4A8-0x000000018AB9F50C
	}

	// Constructors
	public KPUcNweIcXXVKPnTNSXZVDWPwgse(int param_00073735, ZmIGzJfowxKiyvJARuzfVHOOhwvO param_00073736, IntPtr param_00073737, IdxcAbgzMTzxeMxdElxolIcPzwurA param_00073738); // 0x000000018AB9A7A0-0x000000018AB9AA44

	// Methods
	public void EGhvxPKhXjlkipAYJerjFLXFedUDA(IntPtr param_00073739, int param_0007373a, int param_0007373b, int param_0007373c, double param_0007373d); // 0x000000018AB99378-0x000000018AB996A0
	public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_0007373e); // 0x000000018AB9A63C-0x000000018AB9A6C0
	public override void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018AB9B2A8-0x000000018AB9B300
	public override void ZoGbtSrjNkpybJlqlhkJDQCcPlkF(); // 0x00000001841E1670-0x00000001841E1680
	public override void IoyeuUADILkjyEidcCIyeCInNLwS(); // 0x00000001841E1670-0x00000001841E1680
	public void nextLeCtjcIrhGkHxnHsBgbWXbjk(int param_0007373f); // 0x0000000184D868C0-0x0000000184D868D0
	private void QYFGQngsPeNUUNpXdBFatEpLZoZp(); // 0x000000018AB99894-0x000000018AB9A59C
	private void yfAvlFShiJiZPPnfreeMjhGTujmfA(IntPtr param_00073740, int param_00073741, IntPtr param_00073742, byte param_00073743, double param_00073744); // 0x000000018AB9B544-0x000000018AB9B820
	private void nibLAGsXhUkHAymdlkXvbyaAjirq(AList<MDBYECqvXkaCiSmYJZjrizfidEbk.dHQmwhHbvgbNuAqIBFbWyaCtzDht> param_00073745, IntPtr param_00073746, int param_00073747, IntPtr param_00073748, byte param_00073749, double param_0007374a); // 0x000000018AB9AF1C-0x000000018AB9B1E4
	private void luJntzprlBNmnuHnBedGcTxzITXv(AList<MDBYECqvXkaCiSmYJZjrizfidEbk.dHQmwhHbvgbNuAqIBFbWyaCtzDht> param_0007374b, int param_0007374c, PbkriHrdXjmJsObVndfZLuSHkcJi param_0007374d, int param_0007374e, ushort param_0007374f, IntPtr param_00073750, IntPtr param_00073751, int param_00073752); // 0x000000018AB9AD4C-0x000000018AB9AF1C
	private bool sSgaPaCRITPuMBAjLqumcsjvPXtS(AList<MDBYECqvXkaCiSmYJZjrizfidEbk.dHQmwhHbvgbNuAqIBFbWyaCtzDht> param_00073753, JXtFhzUqozCGLAAgSlsxdSapKppi param_00073754, int param_00073755, out uint param_00073756); // 0x000000018AB9B300-0x000000018AB9B3E8
	private bool xSOfqpvlkyeNfqLOaIBNaNhbWVym(JXtFhzUqozCGLAAgSlsxdSapKppi param_00073757, int param_00073758, IntPtr param_00073759, IntPtr param_0007375a, ushort param_0007375b, int param_0007375c, int param_0007375d, IntPtr param_0007375e); // 0x000000018AB9B480-0x000000018AB9B544
	private static bool FlEBMeRVRQazumVeQIYnbBRPDuZY(IntPtr param_0007375f, int param_00073760, IntPtr param_00073761, AList<MDBYECqvXkaCiSmYJZjrizfidEbk.dHQmwhHbvgbNuAqIBFbWyaCtzDht> param_00073762, NativeBuffer param_00073763); // 0x000000018AB996A0-0x000000018AB997EC
	private void qvYGeXeGlIkheDMjWsikEJTzmcHA(int param_00073764, ushort param_00073765, ushort param_00073766, uint param_00073767, int param_00073768, int param_00073769); // 0x000000018AB9B1E4-0x000000018AB9B2A8
	private void BVCiKnOCToKDgmhnxRfSThwZUOkr(int param_0007376a, ushort param_0007376b, ushort param_0007376c, int param_0007376d, ushort param_0007376e, IntPtr param_0007376f, int param_00073770, ushort param_00073771); // 0x000000018AB990D4-0x000000018AB99378
	private void xNbcdXMmWsASjatpkLkNkKmAwexj(int param_00073772, ushort param_00073773, ushort param_00073774, int param_00073775, int param_00073776, uint param_00073777); // 0x000000018AB9B408-0x000000018AB9B480
	private void JsjOXtopwUSqjgiShdZTZXGpVHBW(int param_00073778, ushort param_00073779, ushort param_0007377a, int param_0007377b, int param_0007377c, uint param_0007377d); // 0x000000018AB997EC-0x000000018AB99864
	private void RflbCNHcLQbAuloVqeDRQNFCECXY(IntPtr param_0007377e, int param_0007377f, int param_00073780, double param_00073781); // 0x000000018AB9A59C-0x000000018AB9A5CC
	protected override void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073782); // 0x000000018AB9A5CC-0x000000018AB9A63C
	private static FmarwRrUedMdVuRPApXNMZUKevwt iYNCcaehgpwhCGDActAqYExwhUNYA(List<ofHLpdJoyXyoAkNJdIeRpwrQxGCI> param_00073783, List<lDGIHZYGcLWiHYTgTEPoVmylQNXj> param_00073784, MlriOiaGsGcNChpISALUGlIRPxwK param_00073785, JXtFhzUqozCGLAAgSlsxdSapKppi param_00073786, ushort param_00073787, bool param_00073788, int param_00073789, int param_0007378a); // 0x000000018AB9AA44-0x000000018AB9AD4C
	private FmarwRrUedMdVuRPApXNMZUKevwt XKFFvVDiKuHWIGsSzwdUrkQNhHnbb(EzzIvMwZfCNBGPLqavLvXOMUteoA[] param_0007378b, int param_0007378c, int param_0007378d, int param_0007378e); // 0x000000018AB9A6C0-0x000000018AB9A7A0
	private static bool KmumXRhbNCKPddDmdJYYoqkqDIxp(IdxcAbgzMTzxeMxdElxolIcPzwurA param_0007378f); // 0x000000018AB99864-0x000000018AB99894
}

internal abstract class lDcxHnYDfFcPYdZdkSWGiPhmdwgmA // TypeDefIndex: 53713
{
	// Constructors
	protected lDcxHnYDfFcPYdZdkSWGiPhmdwgmA(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public abstract void ghpRYZOlOAyEnbMLpYIqdDbtPgQh(ofHLpdJoyXyoAkNJdIeRpwrQxGCI param_00073795);
	public abstract void KPuiWAvOKrAdDjHVrInsJKecQePb();
}

internal class REPhaSELegkrQWkZsOTraGFJMQPm : lDcxHnYDfFcPYdZdkSWGiPhmdwgmA // TypeDefIndex: 53714
{
	// Fields
	private List<ofHLpdJoyXyoAkNJdIeRpwrQxGCI> JnZdnAAxIEnZHOEoELthikNEvNaaA; // 0x10
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI[] CqgeFQBmyfohqewCcSrulGlgEiSIB; // 0x18
	private bool HEwlObHLcANEFfbAOiDfGuAIUMsM; // 0x20

	// Constructors
	public REPhaSELegkrQWkZsOTraGFJMQPm(); // 0x000000018AB9C9F0-0x000000018AB9CA68

	// Methods
	public override void ghpRYZOlOAyEnbMLpYIqdDbtPgQh(ofHLpdJoyXyoAkNJdIeRpwrQxGCI param_00073796); // 0x000000018AB9CA68-0x000000018AB9CABC
	public float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_00073797); // 0x000000018AB9C934-0x000000018AB9C984
	public int vvUauQUeffozzgJFkSCnIWIEwnhP(int param_00073798); // 0x000000018AB9CABC-0x000000018AB9CAFC
	public override void KPuiWAvOKrAdDjHVrInsJKecQePb(); // 0x000000018AB9C984-0x000000018AB9C9F0
	private static float kzrWRwKiQqAJGqnTzWzzgJiRpXsJ(int param_00073799); // 0x000000018AB94FD4-0x000000018AB95038
}

internal class MlriOiaGsGcNChpISALUGlIRPxwK : lDcxHnYDfFcPYdZdkSWGiPhmdwgmA // TypeDefIndex: 53715
{
	// Fields
	private bool HEwlObHLcANEFfbAOiDfGuAIUMsM; // 0x10
	private List<ofHLpdJoyXyoAkNJdIeRpwrQxGCI> xrWQaiNBjblotRTQZYiPXXwhPQSF; // 0x18
	private int kQUAIGGpeRxlDisefIQXaAKkGQYFb; // 0x20
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI eSmalOwbeMkXVQPXHgudWpCJHTzE; // 0x28
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI munYfvwDUALYRjMqAbVrRwbTqDJu; // 0x30
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI BujuQzlmDXLAxVFYNQopsPKixWXM; // 0x38
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI IruokcYfEfUdGrsbhMipKphmMaHF; // 0x40
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI pcgPBTCrBtGjFIzKZMxDmFJwYdtk; // 0x48
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI gmYplwEoHODIDDzLbEYfSGURDTSkA; // 0x50
	private readonly ofHLpdJoyXyoAkNJdIeRpwrQxGCI[] HHfzmnBjHnfWbWLtYFzGCKIccYZiA; // 0x58
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI mCkxBraKwnDBbWconaBqCcKPLlML; // 0x60
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI UVnwHviFrtHwsFeNqhYOIALOeaRY; // 0x68
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI haDHjyCUeresobAOKtqxNeLhSmrUc; // 0x70
	private int nrVrdCKEtDnLmXInIDdMgacVTcpG; // 0x78
	private ofHLpdJoyXyoAkNJdIeRpwrQxGCI[] NYbDfBmYBYxDHYQLXEjeMivjLNvc; // 0x80

	// Properties
	public int kmxlJMJLnLOAgESnXBARXJzszbKT { get; } // 0x000000018AB9BC54-0x000000018AB9BC74 

	// Constructors
	public MlriOiaGsGcNChpISALUGlIRPxwK(); // 0x000000018AB9BC74-0x000000018AB9BD14

	// Methods
	public override void ghpRYZOlOAyEnbMLpYIqdDbtPgQh(ofHLpdJoyXyoAkNJdIeRpwrQxGCI param_0007379a); // 0x000000018AB9BD14-0x000000018AB9BF1C
	public int DYxtgWHqYudqjBhVQJKzjymElHwy(RawInputAxis param_0007379b, int param_0007379c); // 0x000000018AB9BA34-0x000000018AB9BBE0
	public override void KPuiWAvOKrAdDjHVrInsJKecQePb(); // 0x000000018AB9BBE0-0x000000018AB9BC54
}

internal enum KMIrdmYHGwLisztsVlJZPPznmmQt // TypeDefIndex: 53718
{
	SharpDX = 0
}

internal class szduZeeDEtcYluGujxaTriOejwKbA : IInputSource // TypeDefIndex: 53732
{
	// Fields
	private List<xLiBDACQHMkUJDONyqwWiGgepFzkA> PCdPJbHLsogIbJECApXLUpgSXfnrA; // 0x10
	private List<xLiBDACQHMkUJDONyqwWiGgepFzkA> iBWfowdBREqSSAQlzBEWgpPGJRKNA; // 0x18
	private ReadOnlyCollection<xLiBDACQHMkUJDONyqwWiGgepFzkA> ulAcKhdUgomyceGYpJGFbANYPEsC; // 0x20
	private ZTnhIRoUwpwDSquXvRdXVrHhmNqH tcywqNEGVDagmbnfDpCCSfsRzemuA; // 0x28
	private BGFFhOVnzqjmrCUSbuDuqqEvzAIS CmMOHjiGEbONKkdUWUsoBXiHnZFP; // 0x30
	private ConfigVars VZkjmxqEGPGMJvGmBfBIPDvdPApS; // 0x38
	private hohNsNaAhdJOLmrreLGwwtWoRfkL iCEBYENXkrooMoPlvszKOfnAQAmp; // 0x40
	private UpdateLoopSetting XltDzFvhhAdzVVkaPJAiXYTRRIGl; // 0x48
	private readonly bool EpOeYAUynWpraRsJhsuccrAMFAku; // 0x4C
	private readonly bool axkKvliPJxIEjkBAIyuBFFzRUJZj; // 0x4D
	private readonly bool WVkPZPERjqJrUTkyeJPxPWSPJUUe; // 0x4E
	private readonly bool blXhVnJwmDqRDEWaVygZFlMlUjnd; // 0x4F
	private readonly bool euwWlLVzPUtslVAdwEdNCLTiprwjA; // 0x50
	public readonly bool ElgXaLswQpoRfOZbhjUFigANouUg; // 0x51
	private readonly List<EnhancedDeviceSupportDeviceType> qYccEAUUQAlqXLNUMSsUXvHMKdy; // 0x58
	private bool NVIXGJDBIczVdmkWukrmHMBTwazj; // 0x60
	private bool btYfKRifiBOAILJNKdSeySXtHric; // 0x61
	private bool hbpWASBWJoDFbejbdXkTCkzkrHOP; // 0x62
	private bool nmVWBPcFHhiTmUTAGaktAtxhkKZGA; // 0x63
	private int YMWSmiDQQQVeoDOXkzpyMkQbpnQS; // 0x64
	private readonly object hdlcglUKtsctGJivpJPafseVwVUI; // 0x68
	private readonly KMIrdmYHGwLisztsVlJZPPznmmQt jwUvJmrIKNTdQuWTvBduRrwMjyoI; // 0x70
	private int ybtRofpgpMkgQFFwWTPhIigcbtzV; // 0x74
	private bool uzfGkKIHVauTBfwaoNGWgwNIlzzg; // 0x78
	private bool tnmQMvRhfdJHsEXhjPoJTBgYknnF; // 0x79
	private lGhpciCdniKLZLdOpeIcKWUFYWuAA wqbdbQEuzbTNdEVclsZKxTDDSqszA; // 0x80
	private IntPtr NXIhEtZlHMqGPSHeuqmflSEBlTiD; // 0x88
	private IntPtr ZlELpQZKupDWpthsFsdseHpEPhoj; // 0x90
	private ValueWatcher<IntPtr> HVqrmQhTDagglABqltCJVZYmrHXd; // 0x98
	private ValueWatcher[] touUZnBBMlngSffUngHxDrgXIBae; // 0xA0
	private double tEcCdFrvsIcSqbPLclKnKqAQCYmTA; // 0xA8
	private VAmVuDvNsSbewEPAcnmMyxvuGlBo BxBjUruzrKqwmQAzytYttTSzGTiC; // 0xB0
	private OlYiLLSahgAkoRhTdadLIxcrPDagA DXEUMSDDvhDkWgwSYfrcEDhMSTcCA; // 0xB8
	private static yqCthwNGAZgagjDBQbkNEzFfVZWu.AInQCDdqSLTTWRljCHGQhayircJNA zpLESdCeTohexEHsdCFhjHBxKIIwB; // 0x00
	private yqCthwNGAZgagjDBQbkNEzFfVZWu.ygRJphukthbSeHYUTNVFxMSmRNEw REiaFjsoqCAsxdHPnkIIgGpBzUV; // 0xC0
	private NativeBuffer cZKRjCslhUbZXDpnQqxEUjtlaXUOA; // 0x100
	private static BBPHWEilcatnRSLrVfHUObqnlgQO[] caxDbKtLYAUZPFKTtapOzYaiqXXv; // 0x18
	private readonly hzfUWCjNPPmSYyCeozhXHZrHbmeI ljtKbqyJABDGgaRDSBxKDBWDkNUiA; // 0x108
	private readonly YuzVBZAVrBXogjeFXEIGbMAEejwR ahWOiHHaJEzoCDfmculToFGpNxKd; // 0x110
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x118

	// Properties
	public hohNsNaAhdJOLmrreLGwwtWoRfkL DFsdfJeNLRhTXegkARhhXCEGzBogc { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x000000018ABA1680-0x000000018ABA1684

	// Events
	public event Action DpsleWpZupQSExUUeoaqxQrXkiab {
		add; // 0x000000018ABA1634-0x000000018ABA1680
		remove; // 0x000000018ABA1A70-0x000000018ABA1ABC
	}

	// Nested types
	private class BBPHWEilcatnRSLrVfHUObqnlgQO // TypeDefIndex: 53719
	{
		// Fields
		public ushort CYtxSBIcDASRtcEBicXiSLSLYjuR; // 0x10
		public ushort JgkXfSUVjtjfBrljIbYIZHzHjCnF; // 0x12

		// Constructors
		public BBPHWEilcatnRSLrVfHUObqnlgQO(ushort param_000737ec, ushort param_000737ed); // 0x0000000184DA87E0-0x0000000184DA87F0
	}

	internal class TYZWQvCctKFtWPxDncuiJgmJUxed : IdxcAbgzMTzxeMxdElxolIcPzwurA // TypeDefIndex: 53720
	{
		// Fields
		private IntPtr isHQxXecLduNfiWGxkrHfvsWgIsE; // 0x10
		private IntPtr LoXafMJHdpRuVlGsNNXWroNslajjA; // 0x18
		private ZmPxydCEzlPckyvKlHErkFzgGOFX vXjBMkGGuZZLwzKtWAXwypPzBzCF; // 0x20
		private readonly string jEvJkTuNlfBPMidphiBpyVyxgLsFA; // 0x28
		private readonly string brGcSQOyREiDQmYUDOShcciGajbhA; // 0x30
		private readonly string rjcjRXWJsuVHiuuMbWUVyfKzkhXp; // 0x38
		private readonly string ZJwfQiCoaeYtHFmrQKiNjNVVsLphA; // 0x40
		private readonly pKfkmqTLezjFVzcIBPtMMyRxABwH CyEkwmcMtvUufoCfpJtPmawKeQmJA; // 0x48
		private readonly string NXxDcchZXlRzcSzqfzhcosPBXKZj; // 0x50
		private readonly int fpnumdzasXtrfmlTBWMzSNwPSsSK; // 0x58
		private readonly int aKKTscABfhwyrwxFghlQKNUgbtRx; // 0x5C
		private readonly bool bjpDBQGTjoYCnueDsSmToesxBPDgA; // 0x60
		private readonly string BMYyLkbUgIoslUdBlINhEVsuPPTs; // 0x68
		private readonly bool bykMiCdBFUQuJgkSBdhwTSwzfXr; // 0x70
		private readonly ZmPxydCEzlPckyvKlHErkFzgGOFX AfyPlICvCmpLOvFtPdOMZZSDFQPc; // 0x78
		private readonly aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] IyKCOgGvVVEbpbCJBIpGngMJGAVSB; // 0x80
		private readonly JXtFhzUqozCGLAAgSlsxdSapKppi[] SkYmSIqVvOhcWAqogZEHotpvRhwn; // 0x88
		private qMSJAGnGFztVWGbbMtcbmLOJutTU ZeuUsEorhhylYfoPquBeFdaZXktj; // 0x90
		private qMSJAGnGFztVWGbbMtcbmLOJutTU KQOmbloYOHWxPSNeaaVsONciuDKG; // 0x94
		private nqaKskRUwxbeUaaRxyXfhGNcbkBm nypVyKwJAfrUnujnMJAGrYZqVIVF; // 0x98
		[CompilerGenerated]
		private bool VEuNYdpZVeDRskoHCxMnQySLfVeQ; // 0x9C

		// Properties
		public IntPtr GebVmHpsJPFlDsHlVnlvHSQVztdK { get; } // 0x000000018385B100-0x000000018385B110 
		public bool zDVgUhrfAfIgYMdclajHjFgtbNJXA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		public bool akJlAXhUcHpRKZzggAJdBwlcZzEF { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public ZmPxydCEzlPckyvKlHErkFzgGOFX BkPbwOOXbHfrprsNBdoJnAuJgArO { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public pKfkmqTLezjFVzcIBPtMMyRxABwH FgnMidYTRITgpetgeSFsBzmtVqg { get; } // 0x0000000184D86200-0x0000000184D86210 
		public string QVMkSNFdzYBkSGGdcYhOkBRBEqJFb { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public bool jRIXoCZDUfZanaiKGfTModoQmerH { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] vnsxdvCfmAdoMUjBnHXzFustAXhEb { get; } // 0x0000000184D86260-0x0000000184D86270 
		public JXtFhzUqozCGLAAgSlsxdSapKppi[] NdwbjMyHWBpjFInkCzszCfJNATFjA { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public string QXKDwkyKHflTUTDjlilpWKmzxeZi { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public string YYRyzKMAZwsaThONuxJfKsPrqcLy { get; } // 0x0000000184D86270-0x0000000184D86280 
		public int eKPYMUXhTxBdzYqkhjcxbAyVDCugA { get; } // 0x0000000184D86570-0x0000000184D86580 
		public int IgAWnnkazSdEUGswQhfizzwTVqAs { get; } // 0x0000000184D86560-0x0000000184D86570 
		public bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; } // 0x0000000184D88340-0x0000000184D88350 
		public string RCkbDMwhfgaXSHlSrLNVbcJiljIPc { get; } // 0x0000000184D86230-0x0000000184D86240 
		public bool BJdhruPWQfbEmflPqJRhZZyRVxDTA { get; } // 0x00000001812081B0-0x0000000181208610 

		// Constructors
		public TYZWQvCctKFtWPxDncuiJgmJUxed(IntPtr param_000737f0, string param_000737f1, string param_000737f2, string param_000737f3, string param_000737f4, int param_000737f5, int param_000737f6, bool param_000737f7, string param_000737f8); // 0x000000018ABA8564-0x000000018ABA8E64

		// Methods
		public static TYZWQvCctKFtWPxDncuiJgmJUxed qXhKlRveaMOfkyfZqUhJZWCFRfkd(IntPtr param_000737ee, string param_000737ef); // 0x000000018ABA9A88-0x000000018ABA9B30
		public bool xULxbDXErMDWumqPoCklYRksejXD(bool param_000737fb, qMSJAGnGFztVWGbbMtcbmLOJutTU param_000737fc, bool param_000737fd, qMSJAGnGFztVWGbbMtcbmLOJutTU param_000737fe, nqaKskRUwxbeUaaRxyXfhGNcbkBm param_000737ff); // 0x000000018ABA9B3C-0x000000018ABA9D10
		public void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA(); // 0x000000018ABA8124-0x000000018ABA816C
		public bool EhQhxFweepMpjwazcuSRnFZeQtLc(YWFEqRKsCWKdGhNygVhQhOHuhIISb param_00073800, int param_00073801); // 0x00000001812081B0-0x0000000181208610
		public bool aunlOVhpWoQiLKWoGcKSaHLfoXig(out byte[] param_00073802, int param_00073803, byte param_00073804 = 0 /* Metadata: 0x02333D3D */); // 0x000000018ABA91E8-0x000000018ABA95A8
		public string efFcegvAymobYqJrtnRqLeSRXvqm(); // 0x000000018ABA9960-0x000000018ABA9A88
		public bool efFcegvAymobYqJrtnRqLeSRXvqm(out byte[] param_00073805); // 0x000000018ABA95A8-0x000000018ABA9960
		public string aWBHzUPzbLPVEfFhmcDSkVnnSvncA(); // 0x000000018ABA915C-0x000000018ABA91E8
		public bool aWBHzUPzbLPVEfFhmcDSkVnnSvncA(out byte[] param_00073806); // 0x000000018ABA8E64-0x000000018ABA915C
		public string FpKBQHheYjWwGPXekyQQsMXbqOsJA(); // 0x000000018ABA81B8-0x000000018ABA8244
		public bool FpKBQHheYjWwGPXekyQQsMXbqOsJA(out byte[] param_00073807); // 0x000000018ABA8244-0x000000018ABA8564
		public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		public bool cWNDdKjHWcUyzYOsFgZrPjZLiW(SAcTodLryXZPmeZqsKbnQQxsbBmo param_00073808, int param_00073809); // 0x00000001812081B0-0x0000000181208610
		private static byte[] rBaHfZKawipRifPvkvHJKbEAcqIbA(int param_0007380a); // 0x000000018ABA9B30-0x000000018ABA9B3C
		private static byte[] EBVcyhHKcGqGprrNlMmPYhzuwScN(int param_0007380b); // 0x000000018ABA816C-0x000000018ABA81B8
	}

	internal class ruxuuPDanVezylUfoGeMkVKJEnht : HIDDeviceDriver.IHIDDevice // TypeDefIndex: 53721
	{
		// Fields
		private IdxcAbgzMTzxeMxdElxolIcPzwurA gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x10
		private HIDDeviceDriver.HIDProperties CCIDsGdBkezzjiCYAvVUqKLboyKN; // 0x18
		private jtKDhEFaghTPhKKmJDXICzhwqTbdA SNoiKRVsPfSohLHPFqmoFRFXgmuj; // 0x40
		private YWFEqRKsCWKdGhNygVhQhOHuhIISb ofeMqKayCcCqfzsNnflltZtNnCnw; // 0x48

		// Properties
		public HIDDeviceDriver.HIDProperties properties { get; } // 0x0000000184D921A0-0x0000000184D921C0 

		// Constructors
		public ruxuuPDanVezylUfoGeMkVKJEnht(IdxcAbgzMTzxeMxdElxolIcPzwurA param_0007380c, jtKDhEFaghTPhKKmJDXICzhwqTbdA param_0007380d); // 0x000000018ABAD0D0-0x000000018ABAD33C

		// Methods
		public byte[] GetHidFeatureData(byte reportId, int reportLength, int timeoutMs, int retryCount); // 0x000000018ABACE3C-0x000000018ABACF2C
		public bool ReadSync(IntPtr buffer, int bytesToRead, int timeoutMs); // 0x000000018ABACF2C-0x000000018ABAD01C
		public void WriteAsync(SAcTodLryXZPmeZqsKbnQQxsbBmo outputReport, int timeoutMs); // 0x000000018ABAD01C-0x000000018ABAD054
		public bool WriteSync(SAcTodLryXZPmeZqsKbnQQxsbBmo outputReport, int timeoutMs); // 0x000000018ABAD054-0x000000018ABAD0D0
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class omwAInyGiLnGMfhQQeVbChBjqJiSA // TypeDefIndex: 53722
	{
		// Fields
		public static readonly omwAInyGiLnGMfhQQeVbChBjqJiSA __9; // 0x00
		public static Action<xLiBDACQHMkUJDONyqwWiGgepFzkA> __9__63_0; // 0x08

		// Constructors
		static omwAInyGiLnGMfhQQeVbChBjqJiSA(); // 0x0000000184D3E7D0-0x0000000184D3E830
		public omwAInyGiLnGMfhQQeVbChBjqJiSA(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void YjnFatoRtXbnwbzKGbIYKKRidrkJ(xLiBDACQHMkUJDONyqwWiGgepFzkA param_00073819); // 0x000000018ABAC6A0-0x000000018ABAC6E8
	}

	[CompilerGenerated]
	private sealed class ikmtoIrgaQEmwgrLGzLuySoJFqajA // TypeDefIndex: 53723
	{
		// Fields
		public IList<prXDGPaiLRznhHdqRYUShDUjqIyH.IYkFHeDTeaiIvMIzYRFbPiZVuQFL> GOzTOfPYxjKiJhXSvjNBuDyvlcEN; // 0x10
		public int JMfmsMjVGQYxGgCzcDcKvsjFwVVL; // 0x18
		public Predicate<string> cfKNSsaNXhxtiqgPDGlZJuyUMbNe; // 0x20

		// Constructors
		public ikmtoIrgaQEmwgrLGzLuySoJFqajA(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal bool bnFqPCshRloXmbhRXaIjcWkTkDoM(string param_0007381a); // 0x000000018ABAB9C4-0x000000018ABABA50
	}

	[CompilerGenerated]
	private sealed class prZhJkGBFrwUqAKCmChravCGvJNP // TypeDefIndex: 53724
	{
		// Fields
		public xLiBDACQHMkUJDONyqwWiGgepFzkA PvKagwjwgdXskZTrVyKqnAaEjUjp; // 0x10

		// Constructors
		public prZhJkGBFrwUqAKCmChravCGvJNP(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal bool dgUlRWoEXCStrfZCEgzrjEuSgUqI(xLiBDACQHMkUJDONyqwWiGgepFzkA param_0007381b); // 0x000000018ABAC968-0x000000018ABAC9D0
	}

	[CompilerGenerated]
	private sealed class GlNhCCgMjcQIVwwXMEiSWzZbAfnX // TypeDefIndex: 53725
	{
		// Fields
		public szduZeeDEtcYluGujxaTriOejwKbA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x10
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x18

		// Constructors
		public GlNhCCgMjcQIVwwXMEiSWzZbAfnX(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void vZjcZWMEntIzLtcjbeTsSgTINytg(); // 0x0000000183826310-0x0000000183826490
	}

	[CompilerGenerated]
	private sealed class FWZCGroCJfXRIUZkmKoLGrbKjzOT // TypeDefIndex: 53726
	{
		// Fields
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x10

		// Constructors
		public FWZCGroCJfXRIUZkmKoLGrbKjzOT(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void ObDUYKchQWRiSbkmIIbnYCQOGhPN(); // 0x000000018ABA59EC-0x000000018ABA5AD0
	}

	[CompilerGenerated]
	private sealed class VNMdXtDLkQXEpSyYombUnkKjGEvc // TypeDefIndex: 53727
	{
		// Fields
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x10

		// Constructors
		public VNMdXtDLkQXEpSyYombUnkKjGEvc(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void PeFtLtOYkjxixvKmeghUafarnKuOA(); // 0x000000018ABA9F8C-0x000000018ABAA040
	}

	[CompilerGenerated]
	private sealed class akdamyrqQLDGcybxMjSNvUiasAGP // TypeDefIndex: 53728
	{
		// Fields
		public szduZeeDEtcYluGujxaTriOejwKbA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x10
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x18

		// Constructors
		public akdamyrqQLDGcybxMjSNvUiasAGP(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void lOgeMHWULyuDCCedGGeEgOskOqiMA(); // 0x0000000183824C30-0x0000000183824CC0
	}

	[CompilerGenerated]
	private sealed class gqmJDTUdRrFISImawJTcoGBHLmAib // TypeDefIndex: 53729
	{
		// Fields
		public szduZeeDEtcYluGujxaTriOejwKbA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x10
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x18

		// Constructors
		public gqmJDTUdRrFISImawJTcoGBHLmAib(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void oXGILJBqCMgmWATlAeDwCJthyJYJB(); // 0x0000000183826280-0x0000000183826310
	}

	[CompilerGenerated]
	private sealed class GoQCAXddPhpZnFSgEIGjhNZHVvCPb // TypeDefIndex: 53730
	{
		// Fields
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x10

		// Constructors
		public GoQCAXddPhpZnFSgEIGjhNZHVvCPb(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void TKruLIUpBNRzvTmHGklOHaWPrKVD(); // 0x000000018ABA5AD0-0x000000018ABA5B84
	}

	[CompilerGenerated]
	private sealed class HhYFZUOAMYchRCDHhmKdDkGmRWyPA // TypeDefIndex: 53731
	{
		// Fields
		public szduZeeDEtcYluGujxaTriOejwKbA fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x10
		public VAmVuDvNsSbewEPAcnmMyxvuGlBo.kHNwxQmQEdrtRthvkmZVuYphaaTJ wgYiMqFpRtxwtQXvoiOGhoIGujeT; // 0x18
		public bool HGEsqLPPQDyoMIyIJfbjyrMBSKyQ; // 0x20

		// Constructors
		public HhYFZUOAMYchRCDHhmKdDkGmRWyPA(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void mLWwkuAiiNmrmxcHxHMhkiABaSQfb(); // 0x0000000184B21940-0x0000000184B219F0
	}

	// Constructors
	public szduZeeDEtcYluGujxaTriOejwKbA(ConfigVars param_000737a3, hohNsNaAhdJOLmrreLGwwtWoRfkL param_000737a4, bool param_000737a5, bool param_000737a6, ZTnhIRoUwpwDSquXvRdXVrHhmNqH param_000737a7, BGFFhOVnzqjmrCUSbuDuqqEvzAIS param_000737a8); // 0x0000000183A43590-0x0000000183A43EC0
	static szduZeeDEtcYluGujxaTriOejwKbA(); // 0x00000001849BACD0-0x00000001849BAE50

	// Methods
	public void YYSIcdQZNwuArKWlGMDmRJNqArY(); // 0x00000001841E1670-0x00000001841E1680
	public void zqSkLmupRiXSvinHfYCcdyyKpYwJ(); // 0x00000001841D2B70-0x00000001841D2C80
	public bool TBJVCXPqQIwZjxnHHtaOCFIuckci(); // 0x0000000183A43050-0x0000000183A43140
	public bool jVjgOpvShvSdLChqjIbSIbIIanUs(); // 0x000000018ABA1940-0x000000018ABA1964
	public bool BFfsjWiEpJdOjSFSiJcagkWdgaVe(); // 0x0000000183A41A10-0x0000000183A41A60
	public bool JIOXLRuMyjcqaJZnjmXwnbWNmUAcA(bool param_000737a9); // 0x00000001833038A0-0x00000001833038B0
	public void SystemDeviceDisconnected(); // 0x000000018ABA1178-0x000000018ABA1184
	public void SystemDeviceConnected(); // 0x000000018ABA1178-0x000000018ABA1184
	public void Update(); // 0x00000001833036D0-0x0000000183303750
	public void UpdateDevices(UpdateLoopType updateLoop); // 0x0000000183303070-0x00000001833030C0
	public void UpdateFinished(); // 0x00000001833030C0-0x0000000183303110
	public IList<T> GetJoysticks<T>()
		where T : class;
	private List<xLiBDACQHMkUJDONyqwWiGgepFzkA> jeLlJnpyFXRSpQwfmBbZzMeqKJMd(bool param_000737ad); // 0x0000000183A43EC0-0x0000000183A44200
	private static void IvaiVVNYacgZnqKZfujTUHpfbBhU(ref List<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_000737ae, List<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_000737af); // 0x00000001841D2C80-0x00000001841D2EC0
	private xLiBDACQHMkUJDONyqwWiGgepFzkA oMpNWtDkqBarMtULfBUYmGnseBtO(IntPtr param_000737b0, mrpPdMulHkXGyvibMdjBBPWOPSOo param_000737b1, IList<prXDGPaiLRznhHdqRYUShDUjqIyH.IYkFHeDTeaiIvMIzYRFbPiZVuQFL> param_000737b2, List<string> param_000737b3, int param_000737b4); // 0x0000000183A44200-0x0000000183A44400
	private xLiBDACQHMkUJDONyqwWiGgepFzkA UtmCNmkcQjejyuWQFZPRpnzkaTAV(prXDGPaiLRznhHdqRYUShDUjqIyH.IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_000737b5, int param_000737b6); // 0x000000018ABA11F8-0x000000018ABA13D0
	private xLiBDACQHMkUJDONyqwWiGgepFzkA lagCYTOqVShxXMDfailyhoDMeQZQA(ZmIGzJfowxKiyvJARuzfVHOOhwvO param_000737b7, IdxcAbgzMTzxeMxdElxolIcPzwurA param_000737b8, IntPtr param_000737b9, ushort param_000737ba, ushort param_000737bb, int param_000737bc); // 0x0000000183A44590-0x0000000183A44670
	private bool sWjKGFeakMLKUrcJiTerGpkwEnlgA(ushort param_000737bd, ushort param_000737be); // 0x0000000183A44400-0x0000000183A44550
	private int EsLwNrByQcEYDaVUhdrUcJekSZrc(); // 0x0000000183A44AC0-0x0000000183A44B10
	private int HAlcbAPlpAGCjaHUimzYPmYgHkkwA(); // 0x000000018ABA0A14-0x000000018ABA0AEC
	private xLiBDACQHMkUJDONyqwWiGgepFzkA AIeKyVaARAbqBseIBlYSeGYKIRPf(ZmIGzJfowxKiyvJARuzfVHOOhwvO param_000737bf, IntPtr param_000737c0, int param_000737c1, IdxcAbgzMTzxeMxdElxolIcPzwurA param_000737c2, List<xLiBDACQHMkUJDONyqwWiGgepFzkA> param_000737c3, bool param_000737c4); // 0x0000000183A448F0-0x0000000183A44AC0
	private xLiBDACQHMkUJDONyqwWiGgepFzkA ldSiUwcEKgSlJKqcqaBlKxEjgOiDA(ZmIGzJfowxKiyvJARuzfVHOOhwvO param_000737c5, IntPtr param_000737c6); // 0x0000000183F4D230-0x0000000183F4D290
	private static int SVJCECoUpFLjPlNOqfDiLxmBvMRM(xLiBDACQHMkUJDONyqwWiGgepFzkA param_000737c7, xLiBDACQHMkUJDONyqwWiGgepFzkA param_000737c8); // 0x000000018ABA0C84-0x000000018ABA0D70
	private void NaqpfzKBgzvsCPBYctRnpQSwrUjw(); // 0x0000000183A44EA0-0x0000000183A44F70
	private void BgjPLwHdmNLeqEXEBYSYXgIwCgMn(); // 0x000000018ABA06F0-0x000000018ABA07B8
	private void CNuXwRByEAlSsRNuVKoMfHXJXoPk(); // 0x000000018ABA07CC-0x000000018ABA0984
	private void mCUaWYMQNsJjivLOnmAVDLStzZee(); // 0x0000000183304040-0x0000000183304190
	private void HYrmDLgtoGMidKkGLNKlNxBDvYRJ(); // 0x000000018ABA0B4C-0x000000018ABA0C44
	private void BXxYjqUovILvkoVjZpJeCaVZGoVW(); // 0x000000018ABA06B0-0x000000018ABA06F0
	private void AtpbzvkCQeShMyQbveVpfYMUlQtd(); // 0x000000018ABA0484-0x000000018ABA06B0
	private void eGtyJqMJNzzxMIcUENFayGEhhLxH(IntPtr param_000737c9); // 0x000000018ABA18AC-0x000000018ABA1908
	private void VaMlaCTsZZHenILJSgqVboewfQLaA(); // 0x0000000183A45B10-0x0000000183A45BD0
	private void pOBVblzEENapurvRdFzQiCLogZeD(); // 0x0000000183A45400-0x0000000183A454F0
	public static bool iIeFvfbrvrhiakPoCdEUVroOLDrjA(lGhpciCdniKLZLdOpeIcKWUFYWuAA param_000737ca, out uint param_000737cb); // 0x0000000183302110-0x00000001833021A0
	private bool qTdkVSvlDLSajpAXJngHFmSCoeSN(Rewired.ControllerType param_000737cc, lGhpciCdniKLZLdOpeIcKWUFYWuAA param_000737cd, uint param_000737ce, out IntPtr param_000737cf); // 0x00000001833022D0-0x0000000183302440
	private void ZVKkhwUCDMDnGjQIBDeMXEEAhxbdb(IntPtr param_000737d0); // 0x000000018ABA15E8-0x000000018ABA1634
	private void yKMeFGEqxNaAigEkJZuUwKeFgLwxA(); // 0x0000000183A45BD0-0x0000000183A45BE0
	private void xzDqvRzonUdMvwyTsfWTKstwcrkV(); // 0x0000000183A44DB0-0x0000000183A44EA0
	private void gKYevTglWegheEqthLLgUznwcqKGb(); // 0x000000018ABA1908-0x000000018ABA1940
	private void eDAGGEpCSVLGsTJGNDIMtSYQuDwC(); // 0x000000018ABA1684-0x000000018ABA18AC
	private void HSAIzkNyFOAYbKJKgLpCVKuubomb(); // 0x000000018ABA0AEC-0x000000018ABA0B4C
	private void xbdWTeHMyveQReZGlhbtoMIyilfe(); // 0x0000000183328610-0x0000000183328850
	private void YBIKlNzikKbQIlpVFckxxsxuhWDj(); // 0x000000018ABA13D0-0x000000018ABA15E8
	private void svtjyZxQguJEqsRYyrtwCzhqhquf(VAmVuDvNsSbewEPAcnmMyxvuGlBo.kHNwxQmQEdrtRthvkmZVuYphaaTJ param_000737d1); // 0x0000000183A45330-0x0000000183A45400
	private static VAmVuDvNsSbewEPAcnmMyxvuGlBo bTLupeoyTomBFOiIqcRdAmMlwICN(VAmVuDvNsSbewEPAcnmMyxvuGlBo.kHNwxQmQEdrtRthvkmZVuYphaaTJ param_000737d2); // 0x0000000184B219F0-0x0000000184B21A80
	private void IjeZlMjSdOEVHHbBtqUaegyNgOEE(); // 0x0000000183A45DC0-0x0000000183A45F60
	private void nBeuQYAYJbweumPcWoeFnUlOsiOX(); // 0x000000018ABA1964-0x000000018ABA1A70
	private void QxWvCVWYWrVtTIGBhKsSrDiqbcDcA(bool param_000737d3); // 0x000000018ABA0C44-0x000000018ABA0C84
	private void BSBbCkZloeHSdffjvjzejfeNNIchb(bool param_000737d4); // 0x0000000184D86FA0-0x0000000184D86FB0
	private void yonePGyMPqkUCoaTVtNEWneSYdiQ(bool param_000737d5); // 0x0000000184D88E90-0x0000000184D88EA0
	private void CLTBAgqnxQgewuhANitNRputSTiR(FullScreenMode param_000737d6); // 0x000000018ABA07B8-0x000000018ABA07CC
	private void FIRaUXoJZMEkgIpqqHgxeQmHGhvAA(IntPtr param_000737d7); // 0x000000018ABA09D4-0x000000018ABA0A14
	private IntPtr EHpWMcCNNRKjmTJfVKblgdrxqEyR(IntPtr param_000737d8, uint param_000737d9, IntPtr param_000737da, IntPtr param_000737db); // 0x0000000183ECB120-0x0000000183ECB2A0
	private void qkuXeeejCQiWxHPFGTnqTKUmGVtiA(Action param_000737dc, bool param_000737dd); // 0x0000000183A44F70-0x0000000183A44F90
	private void EPlRczSzrQiPhqdzQkoGvhyPzhnP(zKVkJdcdYcKLvtNQJglDKOzGsCiJA param_000737de, double param_000737df); // 0x0000000183F4D1B0-0x0000000183F4D230
	private void UJpunUADhWsykxnQeUpOiqNyrDGl(DjdfDrcNukTKWfrrRLbyuQXQgKyCb param_000737e0, double param_000737e1); // 0x000000018381CF50-0x000000018381D020
	private void mwjfWWCtWiqiGQRWhfkGBoNPFbjw(hzfUWCjNPPmSYyCeozhXHZrHbmeI param_000737e2, double param_000737e3); // 0x000000018381D020-0x000000018381D050
	private void aaXYjTgngXnPzsiDHlzgjPghTuEt(mSXBYzcjZtWtzBMaRNJMFIuGieHBb param_000737e4, double param_000737e5); // 0x000000018381CE50-0x000000018381CEA0
	private void pmwewcEnUtTWMJqgiSPcqzEXdCQmA(YuzVBZAVrBXogjeFXEIGbMAEejwR param_000737e6, double param_000737e7); // 0x000000018381CEA0-0x000000018381CED0
	private void gaixKEKXsvqNKuHlJjlMJdAIClvc(IntPtr param_000737e8); // 0x0000000184DA87C0-0x0000000184DA87D0
	private void tlSEpQyVSWnlGzjHEgCjodhuJxXk(); // 0x0000000184DA87C0-0x0000000184DA87D0
	public void Dispose(); // 0x000000018ABA0984-0x000000018ABA09D4
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABA1184-0x000000018ABA11F8
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000737e9); // 0x000000018ABA0D70-0x000000018ABA1178
	public static bool tCbcPZwKuIOKmAcgXlTEByoPzOae(CRhcTXpzBCukpjnPBnBpAuCFmFrX param_000737ea, out int param_000737eb); // 0x0000000183656980-0x0000000183656C90
	[CompilerGenerated]
	private bool OHKNPsGEQeaWeVRqQcrFZxKnamAfA(); // 0x000000018434D070-0x000000018434D080
}

internal class BGFFhOVnzqjmrCUSbuDuqqEvzAIS : IDisposable, IUnifiedKeyboardSource, IGetSetEnabled // TypeDefIndex: 53734
{
	// Fields
	private readonly object HjEsWTUUzyFrvqnrkapJHwVyFDeL; // 0x10
	private UpdateLoopDataSet<avWgBWgMFdSQrvTVQeBgdycbSGpPc> ntgagSxREctSDdkPxzrbhlcQbadZ; // 0x18
	private HardwareControllerMap_Game fMvbYVpHZKFivZJOSvgFdJyoyJcJ; // 0x20
	private bool MVWxwypMDvEYkFBvplbulXuOOUmU; // 0x28
	private int aEfacfhstllEiEAQlRLIzUIDvGzQA; // 0x2C
	private bool[] TzUgxqwuFdYUZSOOrVhgPUsPKfCn; // 0x30
	private readonly YuzVBZAVrBXogjeFXEIGbMAEejwR JUvGhFcPdDTxKGVDycBMadZmAwsHA; // 0x38
	private bool ATJVjCUpthiJVXHDTEpQUcxufvay; // 0x40
	private static readonly int[] ElocavSspreSOjJzdipAqJTpfWtE; // 0x00
	private static readonly int YVHQuExnAcUyQsUdCeiXXJNoIDhc; // 0x08
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x41
	private static IntPtr WfcUdEFXUflOTuXpCvpNDIxpzgxI; // 0x10
	private static WVJmIOuiHfoHGzSrfIOlgfYfJWHl.WRERAPCBXnkbbRNoLOLIJyYkhFAo EttFbnLIYjbMpeXLuQMVnfKefyaX; // 0x18
	private static readonly int[] RQJmnxhKNmvtvHDeJHSPRRkMFgOs; // 0x20
	private static Dictionary<int, Dictionary<int, KeyCode>> pIFekIHqwRxIBHMrSweuPMtTqjGXA; // 0x28
	private static readonly int[] HeTNVscHrGYDoawzylOsckULxDcI; // 0x30

	// Properties
	public bool enabled { get; set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000183B25570-0x0000000183B25580
	public InputSource inputSource { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	public HardwareControllerMap_Game hardwareMap { get; } // 0x0000000183CB66B0-0x0000000183CB6710 
	public int buttonCount { get; } // 0x0000000184DA7330-0x0000000184DA7340 
	public Rewired.Controller.Extension controllerExtension { get; } // 0x00000001811EC580-0x00000001811EC590 

	// Nested types
	private class avWgBWgMFdSQrvTVQeBgdycbSGpPc // TypeDefIndex: 53733
	{
		// Fields
		private static readonly KeyCode[] pFuGnbLRDSnNvhAQAenmcPZqiZJUA; // 0x00
		private readonly UpdateLoopType pFEhljMHttGCkHPDZdESaDYgtFFob; // 0x10
		private bool[] abEohBHxqjyPcFFTlIdOjhClLsOo; // 0x18
		private bool[] FJOXvzOMrAFlZKiVTUcYWqUmBpUt; // 0x20
		private uint iCgpPHzbeBZRvUdEMfMWitcWYGYdA; // 0x28

		// Constructors
		public avWgBWgMFdSQrvTVQeBgdycbSGpPc(UpdateLoopType param_0007382f); // 0x0000000183B23A10-0x0000000183B23A90
		static avWgBWgMFdSQrvTVQeBgdycbSGpPc(); // 0x0000000184D36220-0x0000000184D36290

		// Methods
		public void WYQzLCOWqkbLHmJcWgMubEnztMay(YuzVBZAVrBXogjeFXEIGbMAEejwR param_00073830); // 0x000000018381DFE0-0x000000018381E1F0
		public void ThxjiTXroVhUQlMvuVXRacyBCfxI(ControllerDataUpdater param_00073831); // 0x00000001830BE5E0-0x00000001830BE7D0
		public void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x0000000185393A94-0x0000000185393A9C
		private void onmZpcQsNWkJaoyEXrkRLfzaMDNP(); // 0x0000000183D08F20-0x0000000183D09080
		public void IlInRbQKjABiLpwivJDVudtvAhrT(); // 0x0000000185395B50-0x0000000185395B64
		public void DFzbWQdNlFisggGgVmYILlDdMehP(); // 0x000000018381F4B0-0x000000018381F4F0
	}

	// Constructors
	static BGFFhOVnzqjmrCUSbuDuqqEvzAIS(); // 0x00000001842FEAA0-0x00000001842FF0C0
	public BGFFhOVnzqjmrCUSbuDuqqEvzAIS(UpdateLoopSetting param_0007381c); // 0x0000000183B24A80-0x0000000183B254F0

	// Methods
	public void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_0007381d); // 0x00000001830BE050-0x00000001830BE5E0
	public void dIQoZlRvvXQBwfqmSAhCFbuZFRfl(YuzVBZAVrBXogjeFXEIGbMAEejwR param_0007381e); // 0x000000018381DAF0-0x000000018381DF00
	public void kLFPRiEHmmWpHKPIQzKIRWwjlRaY(bool param_0007381f); // 0x0000000185394954-0x000000018539495C
	public void DrkbGFnnjuIFzGgUJMWHvELXATHgb(bool param_00073820); // 0x000000018ABA33E0-0x000000018ABA340C
	private int LXBptcZWiZkJQlJEcdIwkmFrgqym(); // 0x0000000183B254F0-0x0000000183B25570
	private void BSBbCkZloeHSdffjvjzejfeNNIchb(bool param_00073821); // 0x0000000183820320-0x0000000183820390
	private void yonePGyMPqkUCoaTVtNEWneSYdiQ(bool param_00073822); // 0x000000018ABA38D8-0x000000018ABA392C
	private void SilOiSjOzMFSkyAGlGTtAGtKYhtQ(bool param_00073823); // 0x00000001841E1670-0x00000001841E1680
	private void wdffWlIHAHwHXZMJagxgeuvOlrL(bool param_00073824); // 0x000000018ABA37A8-0x000000018ABA38D8
	private void fdDrNFhysOaMiFiboTMuPapDPCGL(UpdateLoopType param_00073825); // 0x000000018381D780-0x000000018381D8A0
	private void IFnZWtaVuVqwqMtbuWlOHUZikYnH(); // 0x000000018381EFC0-0x000000018381F4B0
	public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x0000000183C7BCC0-0x0000000183C7BD00
	public void Clear(); // 0x0000000185394954-0x000000018539495C
	private static HardwareControllerMap_Game lHUHEThTZvhKPeQFVBfKcPLdzhYdA(); // 0x0000000183CB9E90-0x0000000183CBA250
	public void Dispose(); // 0x000000018ABA3390-0x000000018ABA33E0
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABA35C0-0x000000018ABA3634
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073828); // 0x000000018ABA340C-0x000000018ABA35C0
	public static int XhJtRxldAadntQUcXEtPqgBRnOUo(YuzVBZAVrBXogjeFXEIGbMAEejwR param_00073829, KeyCode[] param_0007382a); // 0x000000018381E1F0-0x000000018381E910
	private static WVJmIOuiHfoHGzSrfIOlgfYfJWHl.WRERAPCBXnkbbRNoLOLIJyYkhFAo NpozjhYGMcYRIEKScsvqlDcNDNYiA(); // 0x000000018381E950-0x000000018381EBA0
	private static bool sUoPnPsKrcACoKpZFSVqdvHEcvKP(Keys param_0007382b, WVJmIOuiHfoHGzSrfIOlgfYfJWHl.WRERAPCBXnkbbRNoLOLIJyYkhFAo param_0007382c, out KeyCode param_0007382d); // 0x000000018ABA3634-0x000000018ABA37A8
	private static bool iYKiwkUmEJLbOIJagzsHSQOrWcaG(Keys param_0007382e); // 0x000000018381EBD0-0x000000018381EC20
}

internal class ZTnhIRoUwpwDSquXvRdXVrHhmNqH : IDisposable, IUnifiedMouseSource, IGetSetEnabled // TypeDefIndex: 53738
{
	// Fields
	private readonly Rewired.Utils.Classes.Utility.SpinLock HjEsWTUUzyFrvqnrkapJHwVyFDeL; // 0x10
	private UpdateLoopDataSet<lCgPxQxUWsyWqmIWfpNakKUfxVRH> ntgagSxREctSDdkPxzrbhlcQbadZ; // 0x18
	private HardwareControllerMap_Game fMvbYVpHZKFivZJOSvgFdJyoyJcJ; // 0x20
	private PlCzmuNhZpPPWYyaeUOeECkDjsWIA CDNtzWnbwponwwddNqKdpELUBBJk; // 0x28
	private bool MVWxwypMDvEYkFBvplbulXuOOUmU; // 0x30
	private int uzObaTHFwEBIDvQTcOdeTmhymwlgb; // 0x34
	private bool ATJVjCUpthiJVXHDTEpQUcxufvay; // 0x38
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x39

	// Properties
	public bool enabled { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x0000000183B23A90-0x0000000183B23AE0
	public InputSource inputSource { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	public HardwareControllerMap_Game hardwareMap { get; } // 0x0000000183CB69D0-0x0000000183CB6A10 
	public int buttonCount { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	public int axisCount { get; } // 0x0000000184D882B0-0x0000000184D882C0 
	public Vector2 mousePosition { get; } // 0x0000000183B23D60-0x0000000183B23DA0 
	public Rewired.Controller.Extension controllerExtension { get; } // 0x00000001811EC580-0x00000001811EC590 

	// Nested types
	private class lCgPxQxUWsyWqmIWfpNakKUfxVRH // TypeDefIndex: 53736
	{
		// Fields
		public readonly UpdateLoopType pFEhljMHttGCkHPDZdESaDYgtFFob; // 0x10
		public uint JoeFjwiaulVHgZhxlPLWnaPITfts; // 0x14
		public uint woIGtSGdtUcVvQuxOtLBOOrHTONdA; // 0x18
		public nEjeDBVgexNIjqfJlYOtOMoVihOf CcGAZCkbEErnfWNngLuNuACDmDMi; // 0x1C
		public float mGBqRTPfHeiBcGQGSVwfLDhJaFFPA; // 0x20
		public float IuEuFRbjYKACLnaEzOkNJxcvuQDh; // 0x24
		public float emIfhkQNrILDDsmKaoSDTWuXdAFN; // 0x28
		public float PvZRYuADmVWvwDyFdpgZKKscXQFV; // 0x2C
		private bool[] abEohBHxqjyPcFFTlIdOjhClLsOo; // 0x30
		private bool[] FJOXvzOMrAFlZKiVTUcYWqUmBpUt; // 0x38
		private PlCzmuNhZpPPWYyaeUOeECkDjsWIA CDNtzWnbwponwwddNqKdpELUBBJk; // 0x40
		private uint iCgpPHzbeBZRvUdEMfMWitcWYGYdA; // 0x48
		private int gxMDBtKqPiCQKHAESCcrOhyZPFVjA; // 0x4C
		private int cMvaHcEXHokSmRPmSpTRyAwbqZPfA; // 0x50
		private bool UanSeCfuScbcPkurFjZgMxAfhuTX; // 0x54

		// Nested types
		private enum HhTBnQyJIkIiaJgNxOCgGTOKguzrb // TypeDefIndex: 53735
		{
			None = 0,
			Down = 1,
			Up = 2,
			DownAndUp = 3
		}

		// Constructors
		public lCgPxQxUWsyWqmIWfpNakKUfxVRH(PlCzmuNhZpPPWYyaeUOeECkDjsWIA param_0007383f, UpdateLoopType param_00073840); // 0x0000000183B23980-0x0000000183B23A10

		// Methods
		public void WYQzLCOWqkbLHmJcWgMubEnztMay(hzfUWCjNPPmSYyCeozhXHZrHbmeI param_00073841); // 0x000000018381D8A0-0x000000018381DAF0
		public void ThxjiTXroVhUQlMvuVXRacyBCfxI(ControllerDataUpdater param_00073842); // 0x00000001830BC910-0x00000001830BCB50
		public void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x0000000185393A8C-0x0000000185393A94
		private void onmZpcQsNWkJaoyEXrkRLfzaMDNP(); // 0x0000000183128840-0x00000001831289A0
		public void DFzbWQdNlFisggGgVmYILlDdMehP(); // 0x000000018381B900-0x000000018381B950
		public void CYdSaltspMNWohvuuTXUjBWHTpDl(); // 0x00000001831289A0-0x0000000183128B70
		private void VyCgqKfpajjcknrXTuhUmiZQcyqwA(int param_00073843, int param_00073844, int param_00073845, int param_00073846); // 0x000000018381DF00-0x000000018381DFB0
		private static HhTBnQyJIkIiaJgNxOCgGTOKguzrb kyKfQxZyKWeQPedOIhyYDRyNmDAI(int param_00073847, int param_00073848, int param_00073849); // 0x000000018381DFB0-0x000000018381DFE0
		private static bool VHMaCoQghLUPGIBaWgsvoPcKNHIg(IntPtr param_0007384a); // 0x000000018381EC50-0x000000018381EDE0
	}

	private class PlCzmuNhZpPPWYyaeUOeECkDjsWIA // TypeDefIndex: 53737
	{
		// Fields
		private bool ATJVjCUpthiJVXHDTEpQUcxufvay; // 0x10
		private bool fdNSWFLUehkQGFfuEevluBPaNGhI; // 0x11
		private bool cAvRgWClSicGaXxSzKEOIamwGydhA; // 0x12
		private int QjnqDfGdHOOufabMpKXyEhmkTQGw; // 0x14
		private readonly float LaQfcbDghLQkmEQsCAcGFcZycZiq; // 0x18
		private double SmKsyQZReGxldCPFdSRcxpnvZMBw; // 0x20

		// Properties
		public bool SMHjScSRxOyFrvkxYQVeBOGPGlSU { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public bool lmtaWdhnloskbAyjOWXPwARdGroU { get; } // 0x0000000184D88380-0x0000000184D88390 

		// Constructors
		public PlCzmuNhZpPPWYyaeUOeECkDjsWIA(bool param_0007384b, float param_0007384c); // 0x0000000183B23EB0-0x0000000183B23ED0

		// Methods
		public void TSexxBoQJJrDUHjAVGegZXOfrqTg(); // 0x0000000183304560-0x00000001833045B0
		private void EOwFowhEzkhRTYDoIWAqvfpBBhWz(bool param_0007384d); // 0x0000000183826150-0x0000000183826210
	}

	// Constructors
	public ZTnhIRoUwpwDSquXvRdXVrHhmNqH(UpdateLoopSetting param_00073832); // 0x0000000183B23ED0-0x0000000183B249E0

	// Methods
	public void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073833); // 0x0000000183304360-0x0000000183304560
	public void dIQoZlRvvXQBwfqmSAhCFbuZFRfl(hzfUWCjNPPmSYyCeozhXHZrHbmeI param_00073834); // 0x000000018381D120-0x000000018381D670
	public void kLFPRiEHmmWpHKPIQzKIRWwjlRaY(bool param_00073835); // 0x000000018539495C-0x0000000185394964
	public void DrkbGFnnjuIFzGgUJMWHvELXATHgb(bool param_00073836); // 0x000000018ABAA23C-0x000000018ABAA268
	private int PhkiokooYDDYxkDImYTrcLciFuHcA(); // 0x0000000183B249E0-0x0000000183B24A80
	private void BSBbCkZloeHSdffjvjzejfeNNIchb(bool param_00073837); // 0x0000000183820390-0x0000000183820410
	private void yonePGyMPqkUCoaTVtNEWneSYdiQ(bool param_00073838); // 0x000000018ABAA608-0x000000018ABAA65C
	private void SilOiSjOzMFSkyAGlGTtAGtKYhtQ(bool param_00073839); // 0x00000001841E1670-0x00000001841E1680
	private void wdffWlIHAHwHXZMJagxgeuvOlrL(bool param_0007383a); // 0x000000018ABAA4C4-0x000000018ABAA608
	private void fdDrNFhysOaMiFiboTMuPapDPCGL(UpdateLoopType param_0007383b); // 0x000000018381D670-0x000000018381D780
	private void edrKAxwAkJAXhgHqMieXnBDbdsoCb(); // 0x000000018381B950-0x000000018381BE70
	public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x0000000183B23C30-0x0000000183B23C70
	public void Clear(); // 0x000000018539495C-0x0000000185394964
	private HardwareControllerMap_Game lHUHEThTZvhKPeQFVBfKcPLdzhYdA(); // 0x0000000183CB9970-0x0000000183CB9E90
	public void Dispose(); // 0x000000018ABAA1EC-0x000000018ABAA23C
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABAA450-0x000000018ABAA4C4
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007383e); // 0x000000018ABAA268-0x000000018ABAA450
}

internal struct DiznChfdyTJvRPParHLnaqnPVzZv // TypeDefIndex: 53739
{
	// Fields
	public ushort NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x00
	public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x02
	public int qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x04
	public IntPtr FTfUyLMXnRNRbeaVgvsiuEYXLbVT; // 0x08

	// Properties
	public static int YpiskYsFFWembKBaCqaTQGDhNxlO { get; } // 0x0000000184DA43A0-0x0000000184DA43B0 
}

internal class KSXcWnVJXHdGdcxUNnMBaqHZACuK<u0001> // TypeDefIndex: 53746
{
	// Fields
	private FyEbIWjWQhPULmtXskjXBUhYUqFPA jmipOkUkxbAcgZiyhHUsLQsuuYiU;
	private u0001 sDStEzyNZosRkkQhjDIVYMkftJfx;
	private WaitCallback xlBGlicniqyqVcDrynCdvCYuHFKD;
	private object usmTHeMAGmCrTetnVPFtjBlXQsMEb;
	private Func<u0001> nztoWouVATIZlHDXHgQlhOHHnvyz;
	private bool UcBfFZfztcbITOTowbiRfOlgfBqqB;
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG;

	// Properties
	public bool kpiozDGqXEqWbpXVwqBFQdDCNXpm { get; }
	public u0001 NQthVhNZOAkUOSWFJwgKuUWBhYMO { get; }

	// Nested types
	private enum FyEbIWjWQhPULmtXskjXBUhYUqFPA // TypeDefIndex: 53742
	{
		Idle = 0,
		AwaitingResult = 1,
		ResultReceived = 2
	}

	private sealed class NESEXlkBVRLSjGEsOdIKXfRsOFCl // TypeDefIndex: 53745
	{
		// Fields
		private static NESEXlkBVRLSjGEsOdIKXfRsOFCl<u0001> xrdNMXQNXfwPuveZIufXarNDAOKx;
		private BTNmtMSOiajrmBAIaoFdMzCdVskY qqMsIyoayIMBgckKAAbErKrsRMlb;
		private int RKdcXqXbtTeCbdFQPfumNaFoiiCwA;
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG;

		// Properties
		private static NESEXlkBVRLSjGEsOdIKXfRsOFCl<u0001> kmqGlvnBOqdlIDoelaOAjDQhsEhbA { get; }
		private BTNmtMSOiajrmBAIaoFdMzCdVskY lJjrRfRJvPeJUShIPlGdELzsBDUQ { get; }

		// Nested types
		private class BTNmtMSOiajrmBAIaoFdMzCdVskY : IDisposable // TypeDefIndex: 53744
		{
			// Fields
			private readonly object HjEsWTUUzyFrvqnrkapJHwVyFDeL;
			private List<WaitCallback> XIlGIsbJailfZbsokDjDBtFqZusfB;
			private List<WaitCallback> TlUBoVeblhiWdfTQARozatIIUizI;
			private Thread swKaDCbNENkYjkUfdceifkmFnqWvA;
			private AutoResetEvent AVwhmIUahCYCxWCxGXXKyRqxdJKL;
			private bool pnYJyCPpqWTeKFEQakNtSFbCmBLI;
			private bool SDZzycXisZCsbkXvMrFLTnoGAgSN;
			private bool HepygyxAmguyTznOHCHFiCqeyKwn;
			private bool eLGaZWNmIskxPvBERxVfbRtgiQJG;

			// Nested types
			[CompilerGenerated]
			private sealed class BUIeXeoziomLPIapGsSkFgmUdRpiA // TypeDefIndex: 53743
			{
				// Fields
				public BTNmtMSOiajrmBAIaoFdMzCdVskY<u0001> fssrnmhfPTfupcxFxQGSQWsdnHnDA;
				public ManualResetEvent SJgijDYpStdrnJOexEloGIWQivwh;

				// Constructors
				public BUIeXeoziomLPIapGsSkFgmUdRpiA();

				// Methods
				internal void fZmeHfNUaahkEApRHeZxflYbxnebb();
			}

			// Constructors
			public BTNmtMSOiajrmBAIaoFdMzCdVskY();

			// Methods
			public void AAXjsGGHQEteEheROEeoBzNznwsrA(WaitCallback param_0007385c);
			private bool DKVpNyqREOIVACgmSVaaAXYjPvP();
			private bool FxiegTKVyhfGenuvuiEUOYSQqspG();
			private void cJeIgwPpHpJGVXAKXNJbFaEFIlIgA();
			private void qbugDYBTDEzxYdAfJbmnClmJlShr();
			private void uBHqzaCswncgWAdbNWUayxzJoldu();
			public void Dispose();
			protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA();
			protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007385d);
		}

		// Constructors
		private NESEXlkBVRLSjGEsOdIKXfRsOFCl();

		// Methods
		private void BKbxHFMYcvQRuhbUaIZMyXlmzOIG();
		private void rbrNYWagjzOiRNfxSnvGuvZlbJgu();
		private void SMZJGeIgeRtmrUpceNbdeKQKOtnl(WaitCallback param_00073859);
		private void SbYVTdmkPElTDzeOGdijEuqHpCge();
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA();
		private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007385a);
		public static void euZXQnafTjiEzrhHIKeELzrqjFyr();
		public static void GgzQSbkFWCDsneRKNqUgeIrHGJSmA();
		public static void AAXjsGGHQEteEheROEeoBzNznwsrA(WaitCallback param_0007385b);
	}

	// Constructors
	public KSXcWnVJXHdGdcxUNnMBaqHZACuK(bool param_00073855, Func<u0001> param_00073856);

	// Methods
	public bool evtegpBZukhUanAyLlcPaJjgZbJbA();
	public bool DWIrjgNykvSEeIQkvOfpQQEGuOWS();
	public void ghAXNTTllFZJImfdUqzOVvWsJmgN();
	private void hdiJdZyFEUGKhDTcyWDBiRKYKLKOA(object param_00073857);
	public void SbYVTdmkPElTDzeOGdijEuqHpCge();
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA();
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073858);
}

[DefaultMember("Item")]
internal class toAwWuzejnaxZpduiQVRAKFLGLpV : IDisposable // TypeDefIndex: 53748
{
	// Fields
	private unsafe byte* vTLatNQVCPvVEfeheGwFAFPYSJLM; // 0x10
	private int BOgYVoKGdqUMaVDWuBdDlcqTBfpkA; // 0x18
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x1C

	// Properties
	public IntPtr JQribhuJPxYJhZXwMOVrrrQRjfcE { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 

	// Constructors
	public toAwWuzejnaxZpduiQVRAKFLGLpV(int param_0007385e); // 0x00000001843C1480-0x00000001843C1490

	// Methods
	public byte xSODOfgqLsiXoyJvmOpBVPwaIhwfA(int param_0007385f); // 0x000000018ABAE878-0x000000018ABAE8F0
	public unsafe int NfAisoggUvhlodoCNuCEacDozOghA(byte* param_00073860, int param_00073861, int param_00073862, int param_00073863 = 0 /* Metadata: 0x02333D45 */, int param_00073864 = 0 /* Metadata: 0x02333D46 */); // 0x000000018ABAE61C-0x000000018ABAE6A8
	public unsafe int pKFSKDqgONfLTCDUYnuwcUilOSdfA(byte* param_00073865, int param_00073866, int param_00073867, int param_00073868 = 0 /* Metadata: 0x02333D47 */, int param_00073869 = 0 /* Metadata: 0x02333D48 */); // 0x000000018ABAE74C-0x000000018ABAE7CC
	public int pKFSKDqgONfLTCDUYnuwcUilOSdfA(IntPtr param_0007386a, int param_0007386b, int param_0007386c, int param_0007386d = 0 /* Metadata: 0x02333D49 */, int param_0007386e = 0 /* Metadata: 0x02333D4A */); // 0x000000018ABAE73C-0x000000018ABAE74C
	public bool PvUblyHLGmOPsBpGTwBHtzjsBHNJ(int param_0007386f); // 0x00000001843C1490-0x00000001843C1520
	public void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x00000001843C1520-0x00000001843C1540
	public void IYsALPEzKUpSHjMlchBUFTjZCkvr(); // 0x00000001843C1540-0x00000001843C1590
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAE7CC-0x000000018ABAE878
	public void Dispose(); // 0x000000018ABAE5CC-0x000000018ABAE61C
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABAE6C8-0x000000018ABAE73C
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073870); // 0x000000018ABAE6A8-0x000000018ABAE6C8
	public static IntPtr APoRgahkkqCivzZqzQUvGNyXvZFi(toAwWuzejnaxZpduiQVRAKFLGLpV param_00073871); // 0x00000001833021A0-0x00000001833021B0
}

internal class rYyHAAtlEbEefKkEVDsoHjKzQHzSA : IDisposable // TypeDefIndex: 53749
{
	// Fields
	private readonly toAwWuzejnaxZpduiQVRAKFLGLpV UzUtkVqQmznFIdHWsNfTBPdCjRYAA; // 0x10
	private readonly int EiXKMgCXuGFYeYpMmPFuRPgOyaUf; // 0x18
	private long hCrjZdLNtkeCTDMOrFRJODycJFXyA; // 0x20
	private long wUlQBOkKBnRpPORHTJlOoxNRgaul; // 0x28
	private int wZYdoTlnGFIDlMSKbOksTRicnbSe; // 0x30
	private bool AuLBFBClUIXauVHeXtItrxIWcslQA; // 0x34
	private uint RrDdoBzvxWdcmAFGINijJIoIDUSj; // 0x38
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x3C

	// Constructors
	public rYyHAAtlEbEefKkEVDsoHjKzQHzSA(int param_00073872); // 0x000000018ABACBF8-0x000000018ABACCC0

	// Methods
	public unsafe int lNECrXByHXlCxWFdivlmtrMoEFAhb(byte* param_00073873, int param_00073874, int param_00073875, out int param_00073876, out uint param_00073877); // 0x000000018ABACD24-0x000000018ABACE10
	public int lNECrXByHXlCxWFdivlmtrMoEFAhb(byte[] param_00073878, int param_00073879, out int param_0007387a, out uint param_0007387b); // 0x000000018ABACCC0-0x000000018ABACD24
	public int lNECrXByHXlCxWFdivlmtrMoEFAhb(byte[] param_0007387c, int param_0007387d); // 0x000000018ABACE10-0x000000018ABACE3C
	public unsafe int EhQhxFweepMpjwazcuSRnFZeQtLc(byte* param_0007387e, int param_0007387f, int param_00073880); // 0x000000018ABACA68-0x000000018ABACB54
	public int EhQhxFweepMpjwazcuSRnFZeQtLc(byte[] param_00073881, int param_00073882); // 0x000000018ABACA20-0x000000018ABACA68
	private void IcBISzOexeeCFBBCHLiSwCFvMhLgb(int param_00073883); // 0x000000018AAF2574-0x000000018AAF2620
	private void yuLXTQnXSGIcdGUhDNZoJPyanKWi(int param_00073884); // 0x000000018AAF1FD0-0x000000018AAF2018
	private void kyDgXWfzjJAkrIQxdKMrgyHLnHJqB(); // 0x000000018AAF2560-0x000000018AAF2574
	public void Dispose(); // 0x000000018ABAC9D0-0x000000018ABACA20
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABACB84-0x000000018ABACBF8
	protected void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073885); // 0x000000018ABACB54-0x000000018ABACB84
}

internal class QJwvzXmfrDwHfKfbgOEvmUxvMugV<u0001> : IDisposable // TypeDefIndex: 53750
	where  : struct
{
	// Fields
	private static readonly int YYYwecOazrpNKDkqnhldLbjwVCOt;
	private toAwWuzejnaxZpduiQVRAKFLGLpV UzUtkVqQmznFIdHWsNfTBPdCjRYAA;
	private bool HTNiJfnovuGWigSEfeUYcFQdKSmFb;

	// Properties
	public toAwWuzejnaxZpduiQVRAKFLGLpV UzEiPTSeaaatYAzlznlVjqoEnlFB { get; }
	public bool oKJsVOCbMkIMZOXKJDSAZkorBpQb { get; }
	public u0001 IaOjDqjXmTvIEPrVtSrrcPlQvkii { get; set; }

	// Constructors
	public QJwvzXmfrDwHfKfbgOEvmUxvMugV();
	static QJwvzXmfrDwHfKfbgOEvmUxvMugV();

	// Methods
	private void JXMwUKzdKsQrCZVBaiKwnsmkPmQr();
	private void bcgbrYhHCWtoivWahvpLJXBJcqjU();
	private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073887);
	public void Dispose();
}

internal static class zozpnScYaMYLEskGhxafwYKHPZAg // TypeDefIndex: 53751
{
	// Methods
	private static unsafe void DFyINpwAkpyNMTAFAIeuZmRCfSTQ(byte* param_00073888, byte* param_00073889, uint param_0007388a); // 0x000000018ABAEC2C-0x000000018ABAEF00
	private static unsafe void DFyINpwAkpyNMTAFAIeuZmRCfSTQ(byte* param_0007388b, byte* param_0007388c, ulong param_0007388d); // 0x000000018ABAEF00-0x000000018ABAF1BC
	public static unsafe bool qKdcIUhkEEAsbPtVMNAaEBFbzjxZA(byte* param_0007388e, byte* param_0007388f, int param_00073890, int param_00073891, int param_00073892); // 0x000000018ABAF25C-0x000000018ABAF630
	public static unsafe bool QhNLvaNMaGFxNukiIiOTMHLSUsKy(byte* param_00073893, byte* param_00073894, int param_00073895, int param_00073896, int param_00073897); // 0x000000018ABAF1BC-0x000000018ABAF25C
	public static unsafe void adQeBKQycYBIKxYHBChhSlmJZlnH(byte* param_00073898, int param_00073899); // 0x00000001843C1590-0x00000001843C1600
}

internal struct osgMuduIeTPzAGUfwObqUCaVRyzG : IEquatable<osgMuduIeTPzAGUfwObqUCaVRyzG> // TypeDefIndex: 53752
{
	// Fields
	private int HSnIduFqjbgPApqEtDpMoTJARSpq; // 0x00

	// Methods
	public bool Equals(osgMuduIeTPzAGUfwObqUCaVRyzG other); // 0x0000000182EED260-0x0000000182EED270
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_0007389b); // 0x000000018ABAC74C-0x000000018ABAC7A8
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x0000000182B77620-0x0000000182B77630
	public static bool APoRgahkkqCivzZqzQUvGNyXvZFi(osgMuduIeTPzAGUfwObqUCaVRyzG param_0007389c); // 0x00000001845FCC70-0x00000001845FCC80
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAC6E8-0x000000018ABAC74C
}

internal class beaToZucjyOfmWGEnxdCGCgakptr : RCeEVNGupoFrfdNPsoxbzSPYwBxdA, hosKjEbZIzDTSDHxGqYoGUnVmtF // TypeDefIndex: 53753
{
	// Constructors
	public beaToZucjyOfmWGEnxdCGCgakptr(IntPtr param_0007389d); // 0x000000018ABA8048-0x000000018ABA8050
	protected beaToZucjyOfmWGEnxdCGCgakptr(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	private int zbGNYxQlkfDNSRfsmocddFNZCxJg(); // 0x000000018ABAAE10-0x000000018ABAAEB0
	protected override void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007389e); // 0x000000018ABAAC7C-0x000000018ABAADA4
	protected override void tRZXOmwrFPteeSBixriJnLPOkZUO(); // 0x000000018ABAADA4-0x000000018ABAAE10
	protected override void KyeLibjaCuIJLGBLURntTLgfGlvEb(IntPtr param_0007389f); // 0x000000018ABAAC10-0x000000018ABAAC7C
}

internal static class ZLUfwKdIzjhfuhpbHTsguqSkHrKjc // TypeDefIndex: 53754
{
	// Fields
	public static bool NxWByWiXQAWFanFdlIscXiojYSHJA; // 0x00
	public static bool VlhZeWjfsSAgrWNikufdOnSygYqJ; // 0x01
	public static bool IZkHbrJKwNnxpQSyDQSrhnpErbQN; // 0x02
	public static bool wZYwmjOFqkPgWfjMEyvuqndOgpIx; // 0x03
	public static bool ZEDuewImLKarFXsZVqNTVKQIyqit; // 0x04

	// Constructors
	static ZLUfwKdIzjhfuhpbHTsguqSkHrKjc(); // 0x000000018ABAA178-0x000000018ABAA1EC
}

internal class RCeEVNGupoFrfdNPsoxbzSPYwBxdA : tzrBlbgnrkVEMpkSCLtDWtjEVeLS // TypeDefIndex: 53755
{
	// Fields
	protected internal unsafe void* lAcSoTmtafaUVffsOybRduUMmIYr; // 0x28

	// Properties
	public IntPtr flvVEFpgKucPjVdmvJHkUQNaTzAQ { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x000000018ABA8004-0x000000018ABA8048

	// Constructors
	public RCeEVNGupoFrfdNPsoxbzSPYwBxdA(IntPtr param_000738a0); // 0x000000018ABA8048-0x000000018ABA8050
	protected RCeEVNGupoFrfdNPsoxbzSPYwBxdA(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	protected virtual void tRZXOmwrFPteeSBixriJnLPOkZUO(); // 0x00000001841E1670-0x00000001841E1680
	protected virtual void KyeLibjaCuIJLGBLURntTLgfGlvEb(IntPtr param_000738a2); // 0x00000001841E1670-0x00000001841E1680
	protected override void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000738a3); // 0x00000001841E1670-0x00000001841E1680
}

internal abstract class tzrBlbgnrkVEMpkSCLtDWtjEVeLS : IDisposable // TypeDefIndex: 53756
{
	// Fields
	[CompilerGenerated]
	private EventHandler<EventArgs> pgSJLFXIVtrhnYIkFWRHyGUyYkHu; // 0x10
	[CompilerGenerated]
	private EventHandler<EventArgs> ABwQPLoQTSFdJqaZVMPZhyCqvghp; // 0x18
	[CompilerGenerated]
	private bool RhxbbauMvTzhNsFBmASStlVahrdbA; // 0x20

	// Properties
	public bool aUTgKpJATaNiezPFWYhlmSmsCPlC { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0

	// Constructors
	protected tzrBlbgnrkVEMpkSCLtDWtjEVeLS(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABAE9E8-0x000000018ABAEA5C
	public void Dispose(); // 0x000000018ABAE8F0-0x000000018ABAE8FC
	private void KBdDTdNqXftRPscisbtlkjsgaUPO(bool param_000738a5); // 0x000000018ABAE8FC-0x000000018ABAE9E8
	protected abstract void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_000738a6);
}

internal class TrZygBjBOPxdNoLZDCUKGcceunIo // TypeDefIndex: 53757
{
	// Fields
	public IntPtr JQribhuJPxYJhZXwMOVrrrQRjfcE; // 0x10

	// Constructors
	public TrZygBjBOPxdNoLZDCUKGcceunIo(IntPtr param_000738a7); // 0x0000000184D88BF0-0x0000000184D88C00

	// Methods
	public static TrZygBjBOPxdNoLZDCUKGcceunIo APoRgahkkqCivzZqzQUvGNyXvZFi(IntPtr param_000738a8); // 0x000000018ABA9D10-0x000000018ABA9D58
	public static unsafe void* APoRgahkkqCivzZqzQUvGNyXvZFi(TrZygBjBOPxdNoLZDCUKGcceunIo param_000738a9); // 0x00000001853E476C-0x00000001853E4784
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABA9D58-0x000000018ABA9E38
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
	public bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(TrZygBjBOPxdNoLZDCUKGcceunIo param_000738aa); // 0x000000018ABA9E38-0x000000018ABA9E58
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_000738ab); // 0x000000018ABA9E58-0x000000018ABA9F10
}

[Guid("00000000-0000-0000-C000-000000000046")]
internal interface hosKjEbZIzDTSDHxGqYoGUnVmtF // TypeDefIndex: 53758
{
	// Methods
	int IYsALPEzKUpSHjMlchBUFTjZCkvr();
}

internal struct sjuMpQgJsMMamCXrodZGkLhzEaWP : IEquatable<sjuMpQgJsMMamCXrodZGkLhzEaWP> // TypeDefIndex: 53759
{
	// Fields
	private int wfZtUaqEuoTiZPVpOiwfYggcKVVM; // 0x00
	public static readonly sjuMpQgJsMMamCXrodZGkLhzEaWP PEaHcCMoMKhPspgKYoxYMeCgzcSG; // 0x00
	public static readonly sjuMpQgJsMMamCXrodZGkLhzEaWP PpTfWubeRrVFxxngPFuMbAYlvbyd; // 0x04
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO cZSsYdrMjYKbgTjLFHmiGahQonStA; // 0x08
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO jKlRBYuFDZfYHdjpvDixcwmfVQjaB; // 0x10
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO nfWetDkhWDsPMSutziCvGvjtJJNp; // 0x18
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO PUEzmrlElSKlZtsHOOIRnENkNBKo; // 0x20
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO xYIxSXUpOgEoBHKVdOKNTbvfrekqA; // 0x28
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO ztxbpKrGHDhVpFMrzgvlGHvOPPTpA; // 0x30
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO gUbFMvkZYjWWtOtKcAWEsqIthify; // 0x38
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO qEKLSvgdgGDcgOASnzLDwfwEBeLfA; // 0x40
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO iWbRNyuNFrQODyfubEoTCsjhKBdn; // 0x48
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO rVqkedweBxIZcBMWtnjekAnRCoTGA; // 0x50
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO NQammlWwDhAULIZKgMYWQemIMpev; // 0x58
	public static readonly bfSyveGvJUGZkIOhbclwiChZPQrO YjKrMIveSChdaCJhDLipDxHCbdNPb; // 0x60

	// Properties
	public int rJSfuaTnaunbUhFSRwBTCTBYnyDb { get; } // 0x0000000182B77620-0x0000000182B77630 
	public bool tRuaqIhSdYzhnrhZSyEMOnYHehUr { get; } // 0x000000018ABAE3E4-0x000000018ABAE424 

	// Constructors
	public sjuMpQgJsMMamCXrodZGkLhzEaWP(int param_000738ac); // 0x0000000184D86140-0x0000000184D86150
	public sjuMpQgJsMMamCXrodZGkLhzEaWP(uint param_000738ad); // 0x0000000184D86140-0x0000000184D86150
	static sjuMpQgJsMMamCXrodZGkLhzEaWP(); // 0x000000018ABADC4C-0x000000018ABAE33C

	// Methods
	public static int dYrigLVdlgNkIRdGqiPIJRSuzwi(sjuMpQgJsMMamCXrodZGkLhzEaWP param_000738ae); // 0x000000018ABAE33C-0x000000018ABAE380
	public static sjuMpQgJsMMamCXrodZGkLhzEaWP APoRgahkkqCivzZqzQUvGNyXvZFi(int param_000738af); // 0x0000000184D88BE0-0x0000000184D88BF0
	public bool Equals(sjuMpQgJsMMamCXrodZGkLhzEaWP other); // 0x000000018ABADBC0-0x000000018ABADC08
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_000738b1); // 0x000000018ABAE504-0x000000018ABAE574
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x000000018ABADC08-0x000000018ABADC4C
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAE424-0x000000018ABAE504
	public void hAZvkDasTiqEOBiwnrBHkHIaUlHO(); // 0x000000018ABAE380-0x000000018ABAE3E4
}

internal sealed class bfSyveGvJUGZkIOhbclwiChZPQrO // TypeDefIndex: 53760
{
	// Fields
	private static readonly object ZmiDSdTByJVOmBlCYCNEdEqJiceI; // 0x00
	private static readonly List<System.Type> uCsbUKGDkjqUwCRToMQTeZYOsSwF; // 0x08
	private static readonly Dictionary<sjuMpQgJsMMamCXrodZGkLhzEaWP, bfSyveGvJUGZkIOhbclwiChZPQrO> ilcdIGgBXCeDjMqJDQNlxjROZUOiA; // 0x10
	[CompilerGenerated]
	private sjuMpQgJsMMamCXrodZGkLhzEaWP DRqSzageKznCobQERGhuGATEazfO; // 0x10
	[CompilerGenerated]
	private string NuhJNFgeGXcEKkPtWgqnlWmEMdQn; // 0x18
	[CompilerGenerated]
	private string xPqjPdStXRSvJfDCbnoWYwBVnIMP; // 0x20
	[CompilerGenerated]
	private string InBFdlrqMwdWYxyAJoVgQJBuVFyP; // 0x28
	[CompilerGenerated]
	private string kRdGDRZLnRMEVZuAFhqPyTEUlftG; // 0x30

	// Properties
	public sjuMpQgJsMMamCXrodZGkLhzEaWP gMRGEdhhgqpXnIAVONYyDfqHOvJJc { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	public string YYmqiTBOJEBhWqdLAOdhIHyRgxTV { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	public string cEBHICmSaSZTMrCZHtWqVdpEuXiA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	public string DVbZohZclzeJzulNXhAYNNnnEzxD { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	public string ryYCGDiFKHbCVCRTEIIcHhWPnpxTb { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210

	// Constructors
	public bfSyveGvJUGZkIOhbclwiChZPQrO(sjuMpQgJsMMamCXrodZGkLhzEaWP param_000738b2, string param_000738b3, string param_000738b4, string param_000738b5, string param_000738b6 = null); // 0x000000018A8D912C-0x000000018A8D9178
	static bfSyveGvJUGZkIOhbclwiChZPQrO(); // 0x000000018ABAB2F0-0x000000018ABAB430

	// Methods
	public bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(bfSyveGvJUGZkIOhbclwiChZPQrO param_000738bc); // 0x000000018ABAB88C-0x000000018ABAB8FC
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_000738bd); // 0x000000018ABAB8FC-0x000000018ABAB9C4
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x000000018ABAAEB0-0x000000018ABAAF04
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAB73C-0x000000018ABAB88C
	public static bfSyveGvJUGZkIOhbclwiChZPQrO VKICJqsJwFOpSUilqXSJZBqYhSeT(sjuMpQgJsMMamCXrodZGkLhzEaWP param_000738be); // 0x000000018ABAAF04-0x000000018ABAB2F0
	private static void lSSCOJFIWrnBijzKFolPglRHfchqE(System.Type param_000738bf); // 0x000000018ABAB590-0x000000018ABAB73C
	private static string hTeZRFPSWzaqjQbCTpOdHimdNdSO(int param_000738c0); // 0x000000018ABAB4D0-0x000000018ABAB590
	private static extern uint cOZXuDTobiOdpFwHGvPoPBreOMPv(int param_000738c1, IntPtr param_000738c2, int param_000738c3, int param_000738c4, ref IntPtr param_000738c5, int param_000738c6, IntPtr param_000738c7); // 0x000000018ABAB430-0x000000018ABAB4D0
}

internal class KIANlWxmpqLSfvaerMIDZHOPDMdD : Exception // TypeDefIndex: 53761
{
	// Fields
	private bfSyveGvJUGZkIOhbclwiChZPQrO VNCzCGcKHuGqDDqrmPJZtvCnUtYi; // 0x90

	// Constructors
	public KIANlWxmpqLSfvaerMIDZHOPDMdD(sjuMpQgJsMMamCXrodZGkLhzEaWP param_000738c8); // 0x000000018ABA6448-0x000000018ABA64E0
	public KIANlWxmpqLSfvaerMIDZHOPDMdD(bfSyveGvJUGZkIOhbclwiChZPQrO param_000738c9); // 0x000000018ABA64E0-0x000000018ABA6590
}

internal delegate u0001 xxrnKXssXwirTAQWUdskFdUMBgNHb<out u0001>(); // TypeDefIndex: 53762; 0x00000000-0x00000000

internal static class BrxTASPZWLjfpFdYlhWjVHOQaBUe // TypeDefIndex: 53763
{
	// Methods
	private static unsafe extern void* yneFvEDelAAnMoHsqMrOepXLkDffb(void* param_000738cc, void* param_000738cd, UIntPtr param_000738ce); // 0x0000000183125240-0x0000000183125290
	private static unsafe void* ajHtDTrvzcZCRjeUpGONRGpfyKUK(void* param_000738cf, void* param_000738d0, int param_000738d1); // 0x00000001831251F0-0x0000000183125240
	public static void qKdcIUhkEEAsbPtVMNAaEBFbzjxZA(IntPtr param_000738d2, IntPtr param_000738d3, int param_000738d4); // 0x00000001831251F0-0x0000000183125240
	public static int SYUJsGEebKGYJaXvpjqFltrKPxst<u0001>()
		where  : struct;
	public static Guid lxBfDgfWvtXURJWTdktXMEccQnHe(System.Type param_000738d5); // 0x000000018ABA3ABC-0x000000018ABA3AF4
	public static string uOzPQZBhpjDJZbMJzGgWPpgOzePp(IntPtr param_000738d6, int param_000738d7); // 0x000000018ABA3AF4-0x000000018ABA3B40
	public static string QTHrbaUMJlrPinbmosEAlsKRWhsg<u0001>(string param_000738d8, u0001[] param_000738d9);
}

internal class seIBpytGDfuFlKsBhBvcMXznriOe // TypeDefIndex: 53765
{
	// Fields
	private static IntPtr jhGooCbTTXmgjsKnAiicIgjWqgcZ; // 0x00

	// Nested types
	internal enum slZGpLdlHEcSApIxuWJmPRUgnEMS // TypeDefIndex: 53764
	{
		UserData = -21,
		ExtendedStyle = -20,
		Style = -16,
		Id = -12,
		HwndParent = -8,
		HInstance = -6,
		WndProc = -4
	}

	// Constructors
	static seIBpytGDfuFlKsBhBvcMXznriOe(); // 0x000000018ABAD4B8-0x000000018ABAD4F4

	// Methods
	public static extern IntPtr hRiRwYJBjSVOrHiPzPXauIMCQPTj(IntPtr param_000738da, IntPtr param_000738db, int param_000738dc, IntPtr param_000738dd, IntPtr param_000738de); // 0x000000018ABAD4F4-0x000000018ABAD594
	public static extern IntPtr QFgaYbkWDIHVIbxKtCmwkREWHRUlA(string param_000738df); // 0x000000018ABAD3BC-0x000000018ABAD438
	public static IntPtr kZUgUEiEIyfFGHxEceelvhObUcBoc(IntPtr param_000738e0, slZGpLdlHEcSApIxuWJmPRUgnEMS param_000738e1); // 0x000000018ABAD594-0x000000018ABAD5EC
	private static extern IntPtr WmEBbdHCmIkBFeSzenoaYkCQibeJB(IntPtr param_000738e2, slZGpLdlHEcSApIxuWJmPRUgnEMS param_000738e3); // 0x000000018ABAD438-0x000000018ABAD4B8
	private static extern IntPtr MOXnhZhygCYADfqDpxIHjSOlMTwC(IntPtr param_000738e4, slZGpLdlHEcSApIxuWJmPRUgnEMS param_000738e5); // 0x000000018ABAD33C-0x000000018ABAD3BC
	public static extern bool lFRbcmhglbQbPdQIaYNvQrGesSgJB(IntPtr param_000738e6); // 0x000000018ABAD5EC-0x000000018ABAD624
}

internal enum MIMEBibeTKehnATrbjXXwrQAaUzCb // TypeDefIndex: 53766
{
	None = 0,
	XINPUT_9_1_0 = 1,
	XINPUT_1_1 = 2,
	XINPUT_1_2 = 3,
	XINPUT_1_3 = 4,
	XINPUT_1_4 = 5
}

internal class GtCdBOEKissCDxkzesWcITSdMOut // TypeDefIndex: 53768
{
	// Fields
	private static bool cskAILJHBmOJbCCYzUscJUtMJpkjA; // 0x00
	private static MIMEBibeTKehnATrbjXXwrQAaUzCb dVksZQpPKHKSLuXWLRlekfYFMpcM; // 0x04
	private static string RMumPSQxLmPHWZEgtEJLFSnICpcgb; // 0x08
	private static CrgrIKvxFWvZvjakhDbDRFvrhbjw fsIJwYNTGRvRIKaXccIzirDIrZHE; // 0x10
	private static BJBFthynMHXUCKrXpIrKdnkmNKsv oTgnAwDElWujlNEWnBKuoeXGqSoH; // 0x18

	// Properties
	public static bool sqJLlwsCsBhPRvpGyAjZbEBOcprv { get; } // 0x000000018ABA5CF4-0x000000018ABA5D2C 
	public static MIMEBibeTKehnATrbjXXwrQAaUzCb ifGsmUnyklcvIhWxxvBsBtYoUrvh { get; } // 0x000000018ABA5E14-0x000000018ABA5E4C 
	public static CrgrIKvxFWvZvjakhDbDRFvrhbjw rLxaACDCyIxzUcBGEkfeVaKJWVTk { get; } // 0x000000018ABA5D54-0x000000018ABA5D8C 

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int CrgrIKvxFWvZvjakhDbDRFvrhbjw(int arg0, void* arg1); // TypeDefIndex: 53767; 0x00000001815802E0-0x00000001815802F0

	// Methods
	private static unsafe extern int WmuQlwARWIUUGmlQtMvyLQMCEBCS(int param_000738e7, void* param_000738e8); // 0x000000018ABA5DD4-0x000000018ABA5E14
	private static unsafe int qLOWFiGgQzBqnTjjtHmPbtlmMXSGA(int param_000738e9, void* param_000738ea); // 0x000000018ABA6150-0x000000018ABA6158
	private static unsafe extern int EcLEGzcLuWLwfgqmHoSoCBnmLzxMc(int param_000738eb, void* param_000738ec); // 0x000000018ABA5CAC-0x000000018ABA5CF4
	private static unsafe int gKeJjjwLrgOcooRjpRBOhCsXuAhK(int param_000738ed, void* param_000738ee); // 0x000000018ABA5E4C-0x000000018ABA5E54
	private static unsafe extern int nKZDwZpAhcNvngleGNwOkwrXtNNQ(int param_000738ef, void* param_000738f0); // 0x000000018ABA6100-0x000000018ABA6148
	private static unsafe int llInDuXSJRDqKFlXbbcLZHDILJOm(int param_000738f1, void* param_000738f2); // 0x000000018ABA5FD0-0x000000018ABA5FD8
	private static unsafe extern int SMSSEESdBQjgKkfSOnqHAFmaLqJu(int param_000738f3, void* param_000738f4); // 0x000000018ABA5D8C-0x000000018ABA5DD4
	private static unsafe int oWgUodfIzEwHIhjXHEPdjqOYEgKBA(int param_000738f5, void* param_000738f6); // 0x000000018ABA6148-0x000000018ABA6150
	private static unsafe extern int GlpgmzVdgHsxMKCoIfGIJleBntmEb(int param_000738f7, void* param_000738f8); // 0x0000000184D280F0-0x0000000184D28180
	private static unsafe int NiFotMbPIZbgbjZvSZHKPVZHOkUpA(int param_000738f9, void* param_000738fa); // 0x00000001853952B4-0x00000001853952BC
	public static bool EIgZIsAaXKSOIBvpwmqjiRutRAOm(out MIMEBibeTKehnATrbjXXwrQAaUzCb param_000738fb, out string param_000738fc, out int param_000738fd); // 0x0000000183B231F0-0x0000000183B23380
	private static bool AqSjfMIAPvzxYokyFbynybATTPjJ(); // 0x0000000183B233D0-0x0000000183B234E0
	private static bool gXNGfLtOhcrOgQRUCoNYOBPAZtQC(); // 0x000000018ABA5E54-0x000000018ABA5F7C
	private static bool mqeEzuBkyHAUIazBILjoaWTZXONyA(); // 0x000000018ABA5FD8-0x000000018ABA6100
	private static bool zSLfyxiSNglLhhRWeNIPaAdwtSogB(); // 0x000000018ABA6158-0x000000018ABA6280
	private static bool CPRiWouGWpIvZbMzMaMcGTVlJPog(); // 0x000000018ABA5B84-0x000000018ABA5CAC
	private static bool PghschPkVcdMkuEjwKNmmlfwibMl(); // 0x000000018ABA5D2C-0x000000018ABA5D54
	private static bool kNwsRjzUPqlWAngmSxVsTsQzbnNU(); // 0x0000000183B23380-0x0000000183B233D0
	public static void iUSCAVHRnNWsJHJVInfBbwPDDdWBB(); // 0x000000018ABA5F7C-0x000000018ABA5FD0
}

internal class nKmzDjyDAHhaWGWNaeRKraijtxEk // TypeDefIndex: 53769
{
	// Fields
	private readonly XeeDQlLvdfFWoEYqJXLUihFnLlSt TSmOIDpHImYStgrgdcBDQRGCYTcd; // 0x10

	// Properties
	public bool akJlAXhUcHpRKZzggAJdBwlcZzEF { get; } // 0x00000001836A82E0-0x00000001836A8310 

	// Constructors
	public nKmzDjyDAHhaWGWNaeRKraijtxEk(XeeDQlLvdfFWoEYqJXLUihFnLlSt param_00073902 = XeeDQlLvdfFWoEYqJXLUihFnLlSt.Any /* Metadata: 0x02333D58 */); // 0x0000000184D86130-0x0000000184D86140

	// Methods
	public MTkIHhmbDyfNUhhhFXnIIVjLwOsY RnRKkCABRuKQqtoefbomyRfdIyAI(lzVnDkLSnMDxnNcAjwlHHyjxaWuL param_00073903); // 0x000000018ABABD9C-0x000000018ABABE24
	public bool jhDqvurSoWPXWZpHUjiCqrMMMfVS(out BJBFthynMHXUCKrXpIrKdnkmNKsv param_00073904); // 0x000000018ABABE94-0x000000018ABABEB0
	public sjuMpQgJsMMamCXrodZGkLhzEaWP hJVWdluocTccqfVOELDXAeXkkPPlA(MjfRFftkTcBeBOoxrCKsCyjeiVkX param_00073905); // 0x000000018ABABE24-0x000000018ABABE94
}

internal struct noccVtHfezXkLCsIalwenvYFTJemA // TypeDefIndex: 53770
{
	// Fields
	public cycPVSDOevSXhUToOPDYJAzVngvP PlahzMFUWWFVTEjviHdVVhgEfBVTb; // 0x00
	public byte NHXQOwSppJgoLEkdgyidunvRqBQPA; // 0x02
	public byte vJTvjiVXyLpJFjfATeIPFcgKcshx; // 0x03
	public short dTDbNJgShQxRVyoIUlZiaMxYDnPI; // 0x04
	public short ZmnrrAgXuhUFsUavbboZwwJwdzFK; // 0x06
	public short BqtmJzGwdhztsPAqfEvOsKzkuDKr; // 0x08
	public short hCMIUROrTGFDMMqLkLejnPumaGdU; // 0x0A

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAC480-0x000000018ABAC6A0
}

[Flags]
internal enum uadRIYjcmydQXrMsjFupGPQKYlxI : short // TypeDefIndex: 53771
{
	None = 0,
	VoiceSupported = 4
}

internal enum lzVnDkLSnMDxnNcAjwlHHyjxaWuL // TypeDefIndex: 53772
{
	Any = 0,
	Gamepad = 1
}

internal enum QytQNbevFMmLqBLgMvWLcuqTSrYS : byte // TypeDefIndex: 53773
{
	Gamepad = 1,
	Wheel = 2,
	ArcadeStick = 3,
	FlightStick = 4,
	DancePad = 5,
	Guitar = 6,
	GuitarAlternate = 7,
	DrumKit = 8,
	GuitarBass = 11,
	ArcadePad = 19
}

[Flags]
internal enum cycPVSDOevSXhUToOPDYJAzVngvP : short // TypeDefIndex: 53775
{
	Y = -32768,
	None = 0,
	DPadUp = 1,
	DPadDown = 2,
	DPadLeft = 4,
	DPadRight = 8,
	Start = 16,
	Back = 32,
	LeftThumb = 64,
	RightThumb = 128,
	LeftShoulder = 256,
	RightShoulder = 512,
	Guide = 1024,
	A = 4096,
	B = 8192,
	X = 16384
}

internal enum XeeDQlLvdfFWoEYqJXLUihFnLlSt : byte // TypeDefIndex: 53776
{
	One = 0,
	Two = 1,
	Three = 2,
	Four = 3,
	Any = 255
}

internal static class shnHHDrlItPppjTdnueDMaecBIoF // TypeDefIndex: 53777
{
	// Methods
	public static int wVFohyegaaQeFDgTfJYKtLKogtgR(int param_00073906, MjfRFftkTcBeBOoxrCKsCyjeiVkX param_00073907); // 0x000000018ABADAF0-0x000000018ABADB0C
	private static unsafe int ohlZIROIcbLMisUPhQvAAftGaIXd(int param_00073908, void* param_00073909); // 0x000000018ABAD948-0x000000018ABAD9D0
	private static unsafe extern int drNVUIubQttGHkuzLAsWuvSZsJTc(int param_0007390a, void* param_0007390b); // 0x000000018ABAD70C-0x000000018ABAD74C
	private static unsafe extern int qCyBbXchefAJxButpsWlQEtcnzJW(int param_0007390c, void* param_0007390d); // 0x000000018ABADA20-0x000000018ABADA68
	private static unsafe extern int uRZEDYCPcESEdxERxuQhqXVijabH(int param_0007390e, void* param_0007390f); // 0x000000018ABADAA8-0x000000018ABADAF0
	private static unsafe extern int nDZSStYEtqlQZfkxWZvzhjlJGRNKA(int param_00073910, void* param_00073911); // 0x000000018ABAD8B8-0x000000018ABAD900
	private static unsafe extern int MCTvSDSujIVfbjwftkjHzEpbGEns(int param_00073912, void* param_00073913); // 0x000000018ABAD624-0x000000018ABAD66C
	public static int jchinRbcEpGCiNimVCjmUrgPbxygb(int param_00073914, out BJBFthynMHXUCKrXpIrKdnkmNKsv param_00073915); // 0x00000001836A8310-0x00000001836A8320
	private static unsafe int esqCpYIkAcsHEBmFMnFSVAuAloPgA(int param_00073916, void* param_00073917); // 0x00000001836A8320-0x00000001836A8440
	private static unsafe extern int qLOWFiGgQzBqnTjjtHmPbtlmMXSGA(int param_00073918, void* param_00073919); // 0x000000018ABADA68-0x000000018ABADAA8
	private static unsafe extern int gKeJjjwLrgOcooRjpRBOhCsXuAhK(int param_0007391a, void* param_0007391b); // 0x000000018ABAD7D8-0x000000018ABAD820
	private static unsafe extern int llInDuXSJRDqKFlXbbcLZHDILJOm(int param_0007391c, void* param_0007391d); // 0x000000018ABAD870-0x000000018ABAD8B8
	private static unsafe extern int oWgUodfIzEwHIhjXHEPdjqOYEgKBA(int param_0007391e, void* param_0007391f); // 0x000000018ABAD900-0x000000018ABAD948
	private static unsafe extern int NiFotMbPIZbgbjZvSZHKPVZHOkUpA(int param_00073920, void* param_00073921); // 0x00000001836A8440-0x00000001836A84D0
	public static int xdWWhxhvmgmkLLBwouOFGdJVbuNx(int param_00073922, lzVnDkLSnMDxnNcAjwlHHyjxaWuL param_00073923, out MTkIHhmbDyfNUhhhFXnIIVjLwOsY param_00073924); // 0x000000018ABADB0C-0x000000018ABADB24
	private static unsafe int yxXWCHstXCFCCMBNolxEflYSsAUn(int param_00073925, int param_00073926, void* param_00073927); // 0x000000018ABADB24-0x000000018ABADBC0
	private static unsafe extern int eJYYHbJrjZBFOXOmMCYESfVBZqMM(int param_00073928, int param_00073929, void* param_0007392a); // 0x000000018ABAD74C-0x000000018ABAD7D8
	private static unsafe extern int MXvGpBjbsLUCVLXvQQdDEKWCtcBY(int param_0007392b, int param_0007392c, void* param_0007392d); // 0x000000018ABAD66C-0x000000018ABAD6BC
	private static unsafe extern int iLnWhwvWzDknQPIMxhwMcieQPKBbA(int param_0007392e, int param_0007392f, void* param_00073930); // 0x000000018ABAD820-0x000000018ABAD870
	private static unsafe extern int OHNlSIycQZrbzDzRANioMwRBpeMQ(int param_00073931, int param_00073932, void* param_00073933); // 0x000000018ABAD6BC-0x000000018ABAD70C
	private static unsafe extern int pJEcXmQEhIaVberlyFFmMipIcdav(int param_00073934, int param_00073935, void* param_00073936); // 0x000000018ABAD9D0-0x000000018ABADA20
}

internal struct MTkIHhmbDyfNUhhhFXnIIVjLwOsY // TypeDefIndex: 53778
{
	// Fields
	public Rewired.Libraries.SharpDX.XInput.DeviceType SPvkVDDQKebsselcJZJzSqGLscPR; // 0x00
	public QytQNbevFMmLqBLgMvWLcuqTSrYS YxAVcIEFexzwIHWHyzPnHtwJTESH; // 0x01
	public uadRIYjcmydQXrMsjFupGPQKYlxI qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x02
	public noccVtHfezXkLCsIalwenvYFTJemA yEzDGpbzVFxDDUBgkdbBQTXdcfKib; // 0x04
	public MjfRFftkTcBeBOoxrCKsCyjeiVkX AzTKzpcpepoHyqkrIKIAosuSVoBx; // 0x10
}

internal struct BJBFthynMHXUCKrXpIrKdnkmNKsv // TypeDefIndex: 53779
{
	// Fields
	public int oCVfOcyPWfqxcGJTrHWIbrkJtSbn; // 0x00
	public noccVtHfezXkLCsIalwenvYFTJemA yEzDGpbzVFxDDUBgkdbBQTXdcfKib; // 0x04
}

internal struct MjfRFftkTcBeBOoxrCKsCyjeiVkX // TypeDefIndex: 53780
{
	// Fields
	public ushort UetSrkuKipqxnZTTTLZFrsjNsUrs; // 0x00
	public ushort NYrExorVtOMkvlyysTUTBJyxLuGv; // 0x02
}

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
internal delegate IntPtr OlYiLLSahgAkoRhTdadLIxcrPDagA(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam); // TypeDefIndex: 53781; 0x00000001814D0D00-0x00000001814D0D20

internal delegate void YmzpkeeavzkhSRVYZAjVqDpxtWjO(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize); // TypeDefIndex: 53782; 0x00000001814DD080-0x00000001814DD0A0

internal static class PFieJcnJGXQWnamkjCbEsemZIUvaA // TypeDefIndex: 53783
{
	// Fields
	internal static kShxDsToEeohgssnWUecapcoTGAY lOpEXrgCIzZTgtqSunZdfhqRxwCrA; // 0x00

	// Methods
	public static void DKVpNyqREOIVACgmSVaaAXYjPvP(); // 0x0000000183A457B0-0x0000000183A45840
	public static void SbYVTdmkPElTDzeOGdijEuqHpCge(); // 0x000000018ABA7EC4-0x000000018ABA7F4C
	public static OlYiLLSahgAkoRhTdadLIxcrPDagA yydCLfbOZCmdAWhusRGdMrQCLikk(); // 0x0000000183A45F60-0x0000000183A45FF0
	public static void TpiKAhQKVNTRraDvFHgiVaVMiotV(IntPtr param_00073944, bool param_00073945); // 0x0000000183A45AB0-0x0000000183A45B10
	public static void lPtuVhwlxOLXlhXxyBXbRlzWWbVF(bool param_00073946); // 0x000000018ABA7F4C-0x000000018ABA7FDC
	public static void CUeHhSUGvEXntxCfpTYkQgmMxTRJ(YmzpkeeavzkhSRVYZAjVqDpxtWjO param_00073947); // 0x0000000183A45670-0x0000000183A45710
}

internal class kShxDsToEeohgssnWUecapcoTGAY : IDisposable // TypeDefIndex: 53784
{
	// Fields
	private int zadrMTlYVTgdzKxPzICXdxgbwQex; // 0x10
	private uint eKqkynwsVFXrdjSOTPyGJFUMkkrC; // 0x14
	private IntPtr FPtxBFFXVrtYsIYCVSlNhKRdSHVk; // 0x18
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x20

	// Constructors
	public kShxDsToEeohgssnWUecapcoTGAY(uint param_00073948); // 0x0000000183A45840-0x0000000183A458C0

	// Methods
	public unsafe IntPtr oGlFeFwwZwedaHIewyilwhOLvyyG(uint param_00073949, void* param_0007394a); // 0x0000000183125150-0x00000001831251F0
	public void Dispose(); // 0x000000018ABABA50-0x000000018ABABAA0
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABABAF8-0x000000018ABABB6C
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_0007394b); // 0x000000018ABABAA0-0x000000018ABABAF8
}

internal class JpjMwGtAGXGdiSKJDsvCQANVInzY // TypeDefIndex: 53785
{
	// Methods
	public static unsafe eVGbmsHPQqEuPzDqvamRtBFdLadfb* aWxbndPmTPjLOCEauVAheAMzUlFC(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_0007394c); // 0x00000001831258F0-0x0000000183125920
	public static unsafe eVGbmsHPQqEuPzDqvamRtBFdLadfb* yIHqZCfhLoWDvawkQqmLFopXoxSA(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_0007394d); // 0x000000018ABA6424-0x000000018ABA6448
	public static unsafe eVGbmsHPQqEuPzDqvamRtBFdLadfb* xhSnFqBEonsMmIEcSGbrksbKsnorA(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_0007394e); // 0x00000001831258F0-0x0000000183125920
	private static uint HWcbvHbLIpYfFBKcQhkBiYzgCnTdB(uint param_0007394f); // 0x0000000184DA8880-0x0000000184DA8890
	private static ulong fIyFzgigAjTcWBRPhpyuGxtgnyocb(ulong param_00073950); // 0x0000000184DA8890-0x0000000184DA88A0
}

internal class MVrlJVITVpqkHqjKGDpulBhzcIhh // TypeDefIndex: 53786
{
	// Fields
	private static readonly OlYiLLSahgAkoRhTdadLIxcrPDagA FqefwoaXiSJOmYYtELQISkLtqHHC; // 0x00
	private static IntPtr mcnirHBRcxPOcJWSejBzpawlwNoN; // 0x08
	private static bool ZVgxBNjkPwzCztblxDJQSyHfRWZb; // 0x10
	private static IntPtr kwKYeDROKjhGMNNAKKxhDwYwPgeN; // 0x18
	private static bool GUcfKhUpOTSvaPlFTIRHCBKTTwsRA; // 0x20
	private static readonly int ynLfFkxNhBDwaMimzgVcADCTyFcxA; // 0x24
	private static readonly int TnTJeYCQhcyAJqPXjgmBDovNxVINA; // 0x28
	private static readonly NativeBuffer HgKdnhariSHxsQiiodzzDVijaXFvA; // 0x30
	public static readonly bool prXlVDlKuzuyKkdgsdEflmGlmIOM; // 0x38
	private static readonly byte[] lcMJGtFjoOXUbYJnHBynqCchXLgw; // 0x40
	private static readonly uint[] eHreTXbHdMGbFIexoYiIxMxWucxqA; // 0x48
	private static readonly uint[] TMitMvfprfKTrtEfyVebTMXRspdK; // 0x50
	private static readonly bool JkvsFGRVRQpIqvOHykmoYQFcmdQy; // 0x58
	private static YmzpkeeavzkhSRVYZAjVqDpxtWjO VerhSKtaaMvOVlaYuwpgoGUkCGgCA; // 0x60
	public static xxrnKXssXwirTAQWUdskFdUMBgNHb<bool> atlhytMeihueBnwcxsDJLxqMKtCN; // 0x68
	[CompilerGenerated]
	private static Action<mSXBYzcjZtWtzBMaRNJMFIuGieHBb, double> SsXiUcznBpWfadJBgDDEoeJsbcno; // 0x70
	[CompilerGenerated]
	private static Action<DjdfDrcNukTKWfrrRLbyuQXQgKyCb, double> LEbFnBzHYoCiYcshYAScAihGhxHwA; // 0x78
	[CompilerGenerated]
	private static Action<zKVkJdcdYcKLvtNQJglDKOzGsCiJA, double> neJbWcBDantvUooVijlaFMpMNMwc; // 0x80
	[CompilerGenerated]
	private static Action<IntPtr> vrsKYxMgJTEgnNvuckTBQHVDBKDX; // 0x88
	[CompilerGenerated]
	private static Action cquFiigoGXXxfjEUDiFhIXaBAHsbc; // 0x90

	// Properties
	public static YmzpkeeavzkhSRVYZAjVqDpxtWjO syXEaBfCiAwrlPWEPnfmcHGtkJjH { set; } // 0x000000018ABA6C5C-0x000000018ABA6CBC

	// Events
	public static event Action<mSXBYzcjZtWtzBMaRNJMFIuGieHBb, double> SsXiUcznBpWfadJBgDDEoeJsbcno {
		add; // 0x0000000183328A10-0x0000000183328AF0
		remove; // 0x000000018ABA696C-0x000000018ABA6A34
	}
	public static event Action<DjdfDrcNukTKWfrrRLbyuQXQgKyCb, double> LEbFnBzHYoCiYcshYAScAihGhxHwA {
		add; // 0x0000000183328930-0x0000000183328A10
		remove; // 0x000000018ABA670C-0x000000018ABA67D4
	}
	public static event Action<zKVkJdcdYcKLvtNQJglDKOzGsCiJA, double> neJbWcBDantvUooVijlaFMpMNMwc {
		add; // 0x0000000183328850-0x0000000183328930
		remove; // 0x000000018ABA67D4-0x000000018ABA68A0
	}
	public static event Action<IntPtr> vrsKYxMgJTEgnNvuckTBQHVDBKDX {
		add; // 0x0000000183328AF0-0x0000000183328BE0
		remove; // 0x000000018ABA68A0-0x000000018ABA696C
	}
	public static event Action cquFiigoGXXxfjEUDiFhIXaBAHsbc {
		add; // 0x0000000183329800-0x00000001833298F0
		remove; // 0x000000018ABA6A34-0x000000018ABA6B0C
	}

	// Constructors
	static MVrlJVITVpqkHqjKGDpulBhzcIhh(); // 0x0000000183A41AA0-0x0000000183A41D80

	// Methods
	public static void TpiKAhQKVNTRraDvFHgiVaVMiotV(IntPtr param_0007395c, bool param_0007395d); // 0x0000000183A454F0-0x0000000183A455C0
	public static void lPtuVhwlxOLXlhXxyBXbRlzWWbVF(bool param_0007395e); // 0x000000018ABA6C08-0x000000018ABA6C5C
	public static OlYiLLSahgAkoRhTdadLIxcrPDagA yydCLfbOZCmdAWhusRGdMrQCLikk(); // 0x000000018ABA6D78-0x000000018ABA6DC8
	public static List<wgusdmZBLEfgRBCxIrfySywpZHFE> enWrmPEeSZfdoBIXgaeNFsgyFeVm(bool param_0007395f); // 0x0000000183656C90-0x0000000183657050
	public static void NlBooNplUxgcTGtUoAHOdxfgqLeLB(abFErqCdZgKHUdVIIOnJrBUAGMehA param_00073960, LWuuyyeGWpRCBrWNacseKxmRFYIp param_00073961, goEaxheiFEgwAIsfqZHDtvQiUGPG param_00073962, IntPtr param_00073963); // 0x00000001838264D0-0x00000001838265C0
	public static void wGrahPhRbBizMtOvWEMDVwYXVDvtA(abFErqCdZgKHUdVIIOnJrBUAGMehA param_00073964, LWuuyyeGWpRCBrWNacseKxmRFYIp param_00073965); // 0x000000018ABA6CBC-0x000000018ABA6D78
	internal static void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018ABA6B0C-0x000000018ABA6C08
	public static void vgKBcpOoajMJoqTWxeHtyWzsjdnM(IntPtr param_00073966, double param_00073967); // 0x0000000183125D00-0x0000000183126390
	private static unsafe void qxQLXaYgByjGNWpBbcJghGGKeNTC(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_00073968, byte[] param_00073969, uint[] param_0007396a, uint[] param_0007396b, ref uint param_0007396c, ref uint param_0007396d); // 0x0000000183126390-0x00000001831266C0
	private static unsafe bool SPMCNsrOpGwcxLYacDElVNDXRFns(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_0007396e, byte[] param_0007396f, uint[] param_00073970, uint[] param_00073971, ref uint param_00073972, ref uint param_00073973); // 0x00000001831266C0-0x0000000183126950
	private static void tVxBFTGXMnxgPeMYCSkQUnpbGOoe(byte[] param_00073974, uint[] param_00073975, uint[] param_00073976, ref uint param_00073977, ref uint param_00073978); // 0x00000001831253F0-0x0000000183125670
	private static unsafe void RRZhkOeYzzthkSLVmwFonkcdgpjJ(eVGbmsHPQqEuPzDqvamRtBFdLadfb* param_00073979, double param_0007397a); // 0x0000000183125920-0x0000000183125D00
	private static void nDTawVTAoIAFsbtkUfIldMjueiTZA(IntPtr param_0007397b, IntPtr param_0007397c); // 0x0000000184A43B30-0x0000000184A43BF0
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(OlYiLLSahgAkoRhTdadLIxcrPDagA))]
	private static IntPtr EHpWMcCNNRKjmTJfVKblgdrxqEyR(IntPtr param_0007397d, uint param_0007397e, IntPtr param_0007397f, IntPtr param_00073980); // 0x00000001831252E0-0x00000001831253F0
	private static void AZgZtnudOfHLMHbaXZPBHyxBJVMlA(IntPtr param_00073981, uint param_00073982, IntPtr param_00073983, IntPtr param_00073984); // 0x000000018ABA6590-0x000000018ABA670C
}

internal class wgusdmZBLEfgRBCxIrfySywpZHFE // TypeDefIndex: 53787
{
	// Fields
	[CompilerGenerated]
	private string eQBUYYQGPDwFGpCTSnwyYCwvhwwH; // 0x10
	[CompilerGenerated]
	private CRhcTXpzBCukpjnPBnBpAuCFmFrX QEDgSgDWBOXgYUoeJBaECBvAdsBq; // 0x18
	[CompilerGenerated]
	private IntPtr AmVONUtDvoQUFdreFSkTcHvqipNr; // 0x20

	// Properties
	public string gZujlIZHlXntcldIKdZQeHyVlQWHA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	public CRhcTXpzBCukpjnPBnBpAuCFmFrX psAUfTCmGaZDidaHRsWjLEaznECN { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	public IntPtr PUEzmrlElSKlZtsHOOIRnENkNBKo { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000184D86500-0x0000000184D86510

	// Constructors
	internal wgusdmZBLEfgRBCxIrfySywpZHFE(ref gPplkeSKivfTCZDOGuWFpRDGDmsm param_00073985, string param_00073986, IntPtr param_00073987); // 0x00000001845FCCD0-0x00000001845FCD00

	// Methods
	internal static wgusdmZBLEfgRBCxIrfySywpZHFE RLcJyEedmyGIJVtDCTzfkOeSDRUX(ref gPplkeSKivfTCZDOGuWFpRDGDmsm param_0007398b, string param_0007398c, IntPtr param_0007398d); // 0x00000001836570C0-0x00000001836571F0
}

[Flags]
internal enum goEaxheiFEgwAIsfqZHDtvQiUGPG // TypeDefIndex: 53788
{
	None = 0,
	Remove = 1,
	Exclude = 16,
	PageOnly = 32,
	NoLegacy = 48,
	InputSink = 256,
	CaptureMouse = 512,
	NoHotKeys = 512,
	AppKeys = 1024,
	ExclusiveInputSink = 4096,
	DeviceNotify = 8192
}

internal enum CRhcTXpzBCukpjnPBnBpAuCFmFrX // TypeDefIndex: 53789
{
	Mouse = 0,
	Keyboard = 1,
	HumanInputDevice = 2
}

[Flags]
internal enum agWzVEkIFodpccVvGQaNfUcyYDIUA // TypeDefIndex: 53791
{
	None = 0,
	LeftButtonDown = 1,
	Button1Down = 1,
	LeftButtonUp = 2,
	Button1Up = 2,
	RightButtonDown = 4,
	Button2Down = 4,
	RightButtonUp = 8,
	Button2Up = 8,
	MiddleButtonDown = 16,
	Button3Down = 16,
	MiddleButtonUp = 32,
	Button3Up = 32,
	Button4Down = 64,
	Button4Up = 128,
	Button5Down = 256,
	Button5Up = 512,
	MouseWheel = 1024
}

[Flags]
internal enum nEjeDBVgexNIjqfJlYOtOMoVihOf // TypeDefIndex: 53792
{
	MoveRelative = 0,
	MoveAbsolute = 1,
	VirtualDesktop = 2,
	AttributesChanged = 4,
	MoveNoCoalesce = 8
}

internal enum zxmQEDVlSVZgBaGceSudpJKYsZKf // TypeDefIndex: 53793
{
	Input = 268435459,
	Header = 268435461
}

internal enum gALzpFzwhlnEZZUcMLSUZZXetvHR // TypeDefIndex: 53794
{
	PreparsedData = 536870917,
	DeviceName = 536870919,
	DeviceInfo = 536870923
}

internal static class txdZluSVIdNbTzSPvjBJBaqRCFYjA // TypeDefIndex: 53796
{
	// Methods
	public static int QGORlCUYiiKgAzLxpdAHdjnrahLU(OQIcCfJXWwApaUlAVrdDDLoBUrejb[] param_0007398e, ref int param_0007398f, int param_00073990); // 0x00000001836A8550-0x00000001836A85C0
	private static unsafe extern int hSGeHgcIEPTzBThcNXmeEMCmXZePA(void* param_00073991, void* param_00073992, int param_00073993); // 0x00000001836A85C0-0x00000001836A8610
	public static int gRHknKLgPajCSfGvSCmrfNADQYVBc(IntPtr param_00073994, gALzpFzwhlnEZZUcMLSUZZXetvHR param_00073995, IntPtr param_00073996, ref int param_00073997); // 0x0000000183657050-0x0000000183657060
	private static unsafe extern int gLzvIPtgxPoPTrfPMDRRawcgceAc(void* param_00073998, int param_00073999, void* param_0007399a, void* param_0007399b); // 0x0000000183657060-0x00000001836570C0
	public static osgMuduIeTPzAGUfwObqUCaVRyzG vRDUPewDxXlFctDUtsHDaGjOqokW(CNtllmNWNzFkFTNFeulZFkWvvpHy[] param_0007399c, int param_0007399d, int param_0007399e); // 0x0000000183826490-0x00000001838264D0
	private static unsafe extern osgMuduIeTPzAGUfwObqUCaVRyzG QwEAPBfvQKwNgoZReNOvboqfnSCY(void* param_0007399f, int param_000739a0, int param_000739a1); // 0x00000001838265C0-0x0000000183826610
	public static int zGEeBnIfiyJZjxSpMXPsWHmIpoMd(IntPtr param_000739a2, zxmQEDVlSVZgBaGceSudpJKYsZKf param_000739a3, IntPtr param_000739a4, ref int param_000739a5, int param_000739a6); // 0x00000001831257A0-0x0000000183125800
	private static unsafe extern int ZljhvXOxSssEffLNOEouPxQnBoXE(void* param_000739a7, int param_000739a8, void* param_000739a9, void* param_000739aa, int param_000739ab); // 0x00000001831257A0-0x0000000183125800
}

internal struct gPplkeSKivfTCZDOGuWFpRDGDmsm // TypeDefIndex: 53797
{
	// Fields
	public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
	public CRhcTXpzBCukpjnPBnBpAuCFmFrX SPvkVDDQKebsselcJZJzSqGLscPR; // 0x04
	public YEaFsvGKtTiepucCOCjGDFntYFrZ DukdLFGcEPRHSHNCfwNoiYBgvsqRB; // 0x08
	public SfFaHADMrQbcwflMBmQXkwqIelOJc ijztdxGlxdNnYCbrWuUidZmidawU; // 0x08
	public rgAkIgjHDNckdejhqWDuEmGRIoFq ZBCSSGMWnCwgDPJeIPDSPZBKtuvy; // 0x08
}

internal struct rgAkIgjHDNckdejhqWDuEmGRIoFq // TypeDefIndex: 53798
{
	// Fields
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG; // 0x00
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB; // 0x04
	public int yaEXslHRhOToVZGGZIFieBALQaJRA; // 0x08
	public abFErqCdZgKHUdVIIOnJrBUAGMehA NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x0C
	public LWuuyyeGWpRCBrWNacseKxmRFYIp ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x0E
}

internal struct SfFaHADMrQbcwflMBmQXkwqIelOJc // TypeDefIndex: 53799
{
	// Fields
	public int SPvkVDDQKebsselcJZJzSqGLscPR; // 0x00
	public int YxAVcIEFexzwIHWHyzPnHtwJTESH; // 0x04
	public int aEkTcvgYqxSexHVWAmvzTvYwdOVB; // 0x08
	public int CTZoDYtPOoEmuJQYJmPsFrkeBwJDb; // 0x0C
	public int FpuCXUENXYNWRrlSAaprcOXybDPwA; // 0x10
	public int ZpyLJjoennsvsigUEJXRRfZQMZm; // 0x14
}

internal struct YEaFsvGKtTiepucCOCjGDFntYFrZ // TypeDefIndex: 53800
{
	// Fields
	public int kHDARXdQXjnkqXHSxymGIdZFAfeYA; // 0x00
	public int PWsQlnzoBTWaDbWOQGNqGhwrQGRQ; // 0x04
	public int FLayQNTZGlakSZxbqEvPeDahBpVR; // 0x08
	public osgMuduIeTPzAGUfwObqUCaVRyzG WTsXHRpuyFqDDJoYoileSsFcUVDR; // 0x0C
}

internal struct ljSrYrwNGOwPioPZBpvStBnwjFQAA // TypeDefIndex: 53801
{
	// Fields
	public int NtcGiXQhWfOScMXzroBpmRQcbosh; // 0x00
	public int XHNTgyeibSCWXbBCndHuzPeCaRLKA; // 0x04
	public int weiPPQoYrlwEMXGVOFGXYvmeFoNKA; // 0x08
}

internal struct eVGbmsHPQqEuPzDqvamRtBFdLadfb // TypeDefIndex: 53802
{
	// Fields
	public sAkZhNdEdGCnzHbulSTkFQBJEjjmA fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
	public xEOCvMytMMBiFNtjQSoRjINVCJAT thLICHPmpalmfjGmuMkilAKwymgl; // 0x18
}

internal struct CNtllmNWNzFkFTNFeulZFkWvvpHy // TypeDefIndex: 53803
{
	// Fields
	public short NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x00
	public short ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x02
	public int qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x04
	public IntPtr FTfUyLMXnRNRbeaVgvsiuEYXLbVT; // 0x08
}

internal struct OQIcCfJXWwApaUlAVrdDDLoBUrejb // TypeDefIndex: 53804
{
	// Fields
	public IntPtr KyAihJLnqGkelkzINpKTCpuYYfu; // 0x00
	public int SPvkVDDQKebsselcJZJzSqGLscPR; // 0x08
}

internal struct sAkZhNdEdGCnzHbulSTkFQBJEjjmA // TypeDefIndex: 53805
{
	// Fields
	public CRhcTXpzBCukpjnPBnBpAuCFmFrX SPvkVDDQKebsselcJZJzSqGLscPR; // 0x00
	public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x04
	public IntPtr KyAihJLnqGkelkzINpKTCpuYYfu; // 0x08
	public IntPtr SYqmVJUIKktczRQHKAkUmMbYGBxaA; // 0x10
}

internal struct xEOCvMytMMBiFNtjQSoRjINVCJAT // TypeDefIndex: 53806
{
	// Fields
	public ajxMoblcufJawiiMHymdgaEIvjFw DukdLFGcEPRHSHNCfwNoiYBgvsqRB; // 0x00
	public cZLbCsAFlKJMGGqHdHjLmmRJabKPc ijztdxGlxdNnYCbrWuUidZmidawU; // 0x00
	public ljSrYrwNGOwPioPZBpvStBnwjFQAA ZBCSSGMWnCwgDPJeIPDSPZBKtuvy; // 0x00
}

internal struct cZLbCsAFlKJMGGqHdHjLmmRJabKPc // TypeDefIndex: 53807
{
	// Fields
	public short QqciAOwjVzFtInJAgMFDmpoPpQVK; // 0x00
	public ScanCodeFlags qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x02
	public short uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x04
	public short RuayCVnQSzAqxzFBqNUIOMEqWRoR; // 0x06
	public KeyState pqvwruakifaBeKyAkpwTYixuduOl; // 0x08
	public int fADmYCSvHxrTPAqWhMiVXhcMhSWj; // 0x0C
}

internal class mrpPdMulHkXGyvibMdjBBPWOPSOo : wgusdmZBLEfgRBCxIrfySywpZHFE // TypeDefIndex: 53808
{
	// Fields
	[CompilerGenerated]
	private int wwylsiIyBycQLoNkYeZeciBEzMTW; // 0x28
	[CompilerGenerated]
	private int TgMPcOKbNumEAmdlgItweDiAhAOz; // 0x2C
	[CompilerGenerated]
	private int pAyjhFbopIhXlldGzAOlxbtswMb; // 0x30
	[CompilerGenerated]
	private abFErqCdZgKHUdVIIOnJrBUAGMehA LUMuzAbrWnMHseXKgyELDjFGWJSj; // 0x34
	[CompilerGenerated]
	private LWuuyyeGWpRCBrWNacseKxmRFYIp rqZHdIAsEIlrdlDQBtmUhaxPNUBB; // 0x36

	// Properties
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	public int yaEXslHRhOToVZGGZIFieBALQaJRA { [CompilerGenerated] set; } // 0x0000000184D86740-0x0000000184D86750
	public abFErqCdZgKHUdVIIOnJrBUAGMehA NDweLaWskzoBwpWJxCWuzQStzdYi { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA89B0-0x0000000184DA89C0 0x0000000184DA89A0-0x0000000184DA89B0
	public LWuuyyeGWpRCBrWNacseKxmRFYIp ZhwNBMzYOdcsywMxxqnQBgbeZIaX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA89D0-0x0000000184DA89E0 0x0000000184DA89C0-0x0000000184DA89D0

	// Constructors
	internal mrpPdMulHkXGyvibMdjBBPWOPSOo(ref gPplkeSKivfTCZDOGuWFpRDGDmsm param_000739ac, string param_000739ad, IntPtr param_000739ae); // 0x00000001845FCC80-0x00000001845FCCD0
}

internal struct zKVkJdcdYcKLvtNQJglDKOzGsCiJA // TypeDefIndex: 53809
{
	// Fields
	public IntPtr KyAihJLnqGkelkzINpKTCpuYYfu; // 0x00
	private IntPtr ufXIwPLElcxoRQnjhAyIfxvMaIitA; // 0x08
	private int zgEbQuYUsGgkpNeDDgDvjCrQueLAA; // 0x10
	public int XHNTgyeibSCWXbBCndHuzPeCaRLKA; // 0x14
	public int iuNYQbPwVApaHsrhjCzxXYEPzBgK; // 0x18

	// Properties
	internal bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x0000000183125290-0x00000001831252B0 
	public IntPtr SHlbubNuxlqVklDElKqucmqaCxZcA { get; } // 0x0000000184D88320-0x0000000184D88330 
	public int yeudotIftAWEtGlsppEvDqGAffNuB { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 

	// Constructors
	internal zKVkJdcdYcKLvtNQJglDKOzGsCiJA(ref eVGbmsHPQqEuPzDqvamRtBFdLadfb param_000739b4, kShxDsToEeohgssnWUecapcoTGAY param_000739b5); // 0x00000001831250F0-0x0000000183125150
}

internal class wipgjXgdcagaRVfgHUmgjqThFDQPA : wgusdmZBLEfgRBCxIrfySywpZHFE // TypeDefIndex: 53810
{
	// Fields
	[CompilerGenerated]
	private int wwnkTFzHFjEPUBbZpczUEQOchqDGb; // 0x28
	[CompilerGenerated]
	private int luVRUgLkkfAPquuNqrWjNlTEFitA; // 0x2C
	[CompilerGenerated]
	private int BDStJJJIJMJRPETgSHiYiBnamVZN; // 0x30
	[CompilerGenerated]
	private int QBLUCZWyIiHPsLpqeZzyJKKysEFD; // 0x34
	[CompilerGenerated]
	private int QmRnzTmdiSfEqshYnrAPhslYsklH; // 0x38
	[CompilerGenerated]
	private int cYAASufDZpoNOavZdlkKnIofuTiQB; // 0x3C

	// Properties
	public int eHAaNjBSbKSlOjKEZJQNkJoSwZVkA { [CompilerGenerated] set; } // 0x00000001811F2AA0-0x00000001811F2AB0
	public int VYKoqtbBjrGccTFhEMzSSLVuJPE { [CompilerGenerated] set; } // 0x0000000184D86720-0x0000000184D86730
	public int aEkTcvgYqxSexHVWAmvzTvYwdOVB { [CompilerGenerated] set; } // 0x0000000184D86740-0x0000000184D86750
	public int vtRKDNMEXnCtWGRZpQJXnHBRkEArA { [CompilerGenerated] set; } // 0x0000000184D86760-0x0000000184D86770
	public int AJOTmBiiRlAMOGoYxtoLzCZpXfLw { [CompilerGenerated] set; } // 0x0000000184D86430-0x0000000184D86440
	public int ThKWlJXDmlVGnnQRpDVYbxuXdPwL { [CompilerGenerated] set; } // 0x0000000184D86670-0x0000000184D86680

	// Constructors
	internal wipgjXgdcagaRVfgHUmgjqThFDQPA(ref gPplkeSKivfTCZDOGuWFpRDGDmsm param_000739b6, string param_000739b7, IntPtr param_000739b8); // 0x00000001845FCBD0-0x00000001845FCC20
}

internal struct mSXBYzcjZtWtzBMaRNJMFIuGieHBb // TypeDefIndex: 53811
{
	// Fields
	public IntPtr KyAihJLnqGkelkzINpKTCpuYYfu; // 0x00
	public Keys JGkTkvTxtgfctSmgVXZIKeZpHBcI; // 0x08
	public int QqciAOwjVzFtInJAgMFDmpoPpQVK; // 0x0C
	public ScanCodeFlags DNlONlCeLBjcnAkePErljLWiInUOA; // 0x10
	public KeyState BkBTDAfYXMrimSPScOozYcGlgbG; // 0x14
	public int fADmYCSvHxrTPAqWhMiVXhcMhSWj; // 0x18

	// Constructors
	internal mSXBYzcjZtWtzBMaRNJMFIuGieHBb(ref eVGbmsHPQqEuPzDqvamRtBFdLadfb param_000739bf); // 0x00000001831252B0-0x00000001831252E0
}

internal class wieHFjxbsUmmATupJtXCbsazblEo : wgusdmZBLEfgRBCxIrfySywpZHFE // TypeDefIndex: 53812
{
	// Fields
	[CompilerGenerated]
	private int TPVsyoaaYbGcWeyXvUcMRGHEYVCGA; // 0x28
	[CompilerGenerated]
	private int SBelyiiHsRhSDnEuphwaYShiAqpk; // 0x2C
	[CompilerGenerated]
	private int zyeuZJJvwlKqnnNnjPuQILovvhpM; // 0x30
	[CompilerGenerated]
	private bool ItoeVtbnocScRHJgKyONdwCnxAsoA; // 0x34

	// Properties
	public int kHDARXdQXjnkqXHSxymGIdZFAfeYA { [CompilerGenerated] set; } // 0x00000001811F2AA0-0x00000001811F2AB0
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { [CompilerGenerated] set; } // 0x0000000184D86720-0x0000000184D86730
	public int FLayQNTZGlakSZxbqEvPeDahBpVR { [CompilerGenerated] set; } // 0x0000000184D86740-0x0000000184D86750
	public bool WTsXHRpuyFqDDJoYoileSsFcUVDR { [CompilerGenerated] set; } // 0x0000000184D86AA0-0x0000000184D86AB0

	// Constructors
	internal wieHFjxbsUmmATupJtXCbsazblEo(ref gPplkeSKivfTCZDOGuWFpRDGDmsm param_000739c0, string param_000739c1, IntPtr param_000739c2); // 0x00000001845FCC20-0x00000001845FCC70
}

internal struct DjdfDrcNukTKWfrrRLbyuQXQgKyCb // TypeDefIndex: 53813
{
	// Fields
	public IntPtr KyAihJLnqGkelkzINpKTCpuYYfu; // 0x00
	public nEjeDBVgexNIjqfJlYOtOMoVihOf HkQtMvNcOybWMOTnPfAfkWMkpD; // 0x08
	public agWzVEkIFodpccVvGQaNfUcyYDIUA EPBvPIBbXnGSNEnMoaJrWWYVztuX; // 0x0C
	public uint fADmYCSvHxrTPAqWhMiVXhcMhSWj; // 0x10
	public uint PlahzMFUWWFVTEjviHdVVhgEfBVTb; // 0x14
	public int uXhOtogRyvSDYaavdIgkRGsAnCnP; // 0x18
	public int sURegOJXrVrzsRbkTLhQVBuqJVbJ; // 0x1C
	public int KNTFhJabRbWgVSMSJojTSthigWSM; // 0x20

	// Constructors
	internal DjdfDrcNukTKWfrrRLbyuQXQgKyCb(ref eVGbmsHPQqEuPzDqvamRtBFdLadfb param_000739c7); // 0x0000000184DA8810-0x0000000184DA8850
}

internal struct ajxMoblcufJawiiMHymdgaEIvjFw // TypeDefIndex: 53815
{
	// Fields
	public short qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x00
	public USiwaeSaxweLQUqwTGtUJWFxJkrnA LaGAeiydCjDLvhGdKfCQawtmACkb; // 0x04
	public uint xEKeoHAOvJHlftcOYyDnMroEiYlW; // 0x08
	public int JnhYBSynofZpaeCAjVSAWWUPHqOE; // 0x0C
	public int uzhoSksLeBHMLXvCldtIVyIkVtdG; // 0x10
	public uint fADmYCSvHxrTPAqWhMiVXhcMhSWj; // 0x14

	// Nested types
	internal struct USiwaeSaxweLQUqwTGtUJWFxJkrnA // TypeDefIndex: 53814
	{
		// Fields
		public int PlahzMFUWWFVTEjviHdVVhgEfBVTb; // 0x00
		public short EPBvPIBbXnGSNEnMoaJrWWYVztuX; // 0x00
		public short ykKPSjynjYSuWQjVQghwunBYyjCB; // 0x02
	}
}

internal class MwhSVMPfdcpoumktuBQSgmpdjtWy // TypeDefIndex: 53816
{
	// Fields
	[CompilerGenerated]
	private System.DateTime kZymtZSfSXinQtTBWGQHOigKGAmq; // 0x10
	[CompilerGenerated]
	private WeakReference OElEYShuDYHzMCOxCvBVJIEGVYwrB; // 0x18
	[CompilerGenerated]
	private string buNwJfbmWgjXTqvSrXqbYAWEsumH; // 0x20

	// Properties
	public System.DateTime hgFaQmGLUeVDOdDXRoqfXHiJIuHG { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x0000000184D88BF0-0x0000000184D88C00
	public WeakReference CONGklVjAgCjvUUVAAcuaCaElUhgA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	public string ndfVIOIcKudCckULWiysYpaCbGrT { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	public bool KhUXLNPkpWjwofZokzbeleVKbjfgA { get; } // 0x000000018ABA6DC8-0x000000018ABA6DE8 

	// Constructors
	public MwhSVMPfdcpoumktuBQSgmpdjtWy(System.DateTime param_000739c8, beaToZucjyOfmWGEnxdCGCgakptr param_000739c9, string param_000739ca); // 0x000000018ABA6DE8-0x000000018ABA6E84

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABA6E84-0x000000018ABA70BC
}

internal class sydsmPALqDcYsqFlVusLVUEQVMTF : EventArgs // TypeDefIndex: 53817
{
	// Fields
	public beaToZucjyOfmWGEnxdCGCgakptr CONGklVjAgCjvUUVAAcuaCaElUhgA; // 0x10

	// Constructors
	public sydsmPALqDcYsqFlVusLVUEQVMTF(beaToZucjyOfmWGEnxdCGCgakptr param_000739ce); // 0x000000018ABAE574-0x000000018ABAE5CC
}

internal static class DjSNbeYiviAPSDflTjNmhluZkSEDA // TypeDefIndex: 53818
{
	// Fields
	private static Dictionary<IntPtr, List<MwhSVMPfdcpoumktuBQSgmpdjtWy>> NJwgxxHIwUQbAbaAedCWkDFhbfvIA; // 0x00
	[ThreadStatic]
	private static Dictionary<IntPtr, List<MwhSVMPfdcpoumktuBQSgmpdjtWy>> gIfjKHBZBHAiepSVIQuFwMiyzbRq; // 0x80000000
	[CompilerGenerated]
	private static EventHandler<sydsmPALqDcYsqFlVusLVUEQVMTF> CYXIkKYOhCHEBEUrGYrUTARlYkIi; // 0x08
	[CompilerGenerated]
	private static EventHandler<sydsmPALqDcYsqFlVusLVUEQVMTF> JLizZBTUTJnQfglpikskfHPNHgfu; // 0x10

	// Properties
	private static Dictionary<IntPtr, List<MwhSVMPfdcpoumktuBQSgmpdjtWy>> eMTEjLuPdsFtNqZKblbNcJptsmLy { get; } // 0x000000018ABA5750-0x000000018ABA5954 

	// Constructors
	static DjSNbeYiviAPSDflTjNmhluZkSEDA(); // 0x000000018ABA5688-0x000000018ABA5750

	// Methods
	private static void tUHBCNTueGOlWtHpLXuYHYhkeYAQ(object param_000739cf, EventArgs param_000739d0); // 0x000000018ABA5954-0x000000018ABA59EC
	public static void TdIjAaBrrCTcQSdlsdfSVnXMwsij(beaToZucjyOfmWGEnxdCGCgakptr param_000739d1); // 0x000000018ABA4F9C-0x000000018ABA5438
	public static MwhSVMPfdcpoumktuBQSgmpdjtWy VKICJqsJwFOpSUilqXSJZBqYhSeT(beaToZucjyOfmWGEnxdCGCgakptr param_000739d2); // 0x000000018ABA5438-0x000000018ABA5688
	public static void EswdwvOCwPJrqQcxniNLuqSeonQm(beaToZucjyOfmWGEnxdCGCgakptr param_000739d3); // 0x000000018ABA4728-0x000000018ABA49A0
	public static List<MwhSVMPfdcpoumktuBQSgmpdjtWy> ATNEAsvgwocAGmxmntLZGIFaKUHJ(); // 0x000000018ABA42F0-0x000000018ABA4680
	public static string JQBMldhjYDRygibJkDILaZGLpMJj(); // 0x000000018ABA4A48-0x000000018ABA4F9C
	private static void GScePwfOnrAtARsauTXUrxzKrdvCA(beaToZucjyOfmWGEnxdCGCgakptr param_000739d4); // 0x000000018ABA49A0-0x000000018ABA4A48
	private static void EpDviDZsDTJJroieQwfNNwQMUwdU(beaToZucjyOfmWGEnxdCGCgakptr param_000739d5); // 0x000000018ABA4680-0x000000018ABA4728
}

internal class wIMvmabHACphhxAzZJdivgRKjPRS // TypeDefIndex: 53819
{
	// Methods
	public static sjuMpQgJsMMamCXrodZGkLhzEaWP LekOyIAejjFsjtpmzmOFJGnvGrfR(int param_000739d6); // 0x000000018ABAEA5C-0x000000018ABAEA6C
}

internal enum LWuuyyeGWpRCBrWNacseKxmRFYIp : short // TypeDefIndex: 53820
{

}

internal enum abFErqCdZgKHUdVIIOnJrBUAGMehA : short // TypeDefIndex: 53821
{

}

internal static class alcYuHLEzuGPfuLRSCIyjPahvkwMA // TypeDefIndex: 53823
{
	// Fields
	public static readonly IEqualityComparer<IntPtr> VudBgnfEHueVHdnyyUaJgaZeWSuMb; // 0x00

	// Nested types
	internal class QQQnCYuJNqhupVpBaAfTGQnQNfIeA : EqualityComparer<IntPtr> // TypeDefIndex: 53822
	{
		// Constructors
		public QQQnCYuJNqhupVpBaAfTGQnQNfIeA(); // 0x000000018ABA7FDC-0x000000018ABA8004

		// Methods
		public override bool Equals(IntPtr param_000739d7, IntPtr param_000739d8); // 0x000000018829C278-0x000000018829C280
		public override int GetHashCode(IntPtr param_000739d9); // 0x0000000184D86510-0x0000000184D86520
	}

	// Constructors
	static alcYuHLEzuGPfuLRSCIyjPahvkwMA(); // 0x000000018ABAAAEC-0x000000018ABAAB68
}

internal class ajkStzGIJaDgjbLVrblCWyQPXycSA // TypeDefIndex: 53825
{
	// Fields
	internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x10
	public BofDOjIlnPpdCKzkZiAcEniWwqDKA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x14
	internal int uNOTfQyMOWuCyFHdxjInFQCpWvYK; // 0x18
	public int qtSUtcwsgIimOFSxJPvfZgSTNlRRA; // 0x1C
	public int iNOQjioNbBRxJPHSCBvgxibcstpi; // 0x20
	public int XtItsLpeiIFITQTrAkzeoFLrYOvj; // 0x24
	public int mYiobxRHuIWGgqKFAgyeCogCgzEI; // 0x28
	public int gYNfzXiewjYMkRFgCNTxgbhoexjc; // 0x2C
	public int pKuqLGvUTyhpJONaXsEAwRycGhqFA; // 0x30
	public int CvKCFDdzyYnNhtZkgiQHeEBvcpmPA; // 0x34
	public int gIXNVNOUUsvTJscMHIuLrdDZdGGFA; // 0x38

	// Properties
	public Rewired.Libraries.SharpDX.DirectInput.DeviceType SPvkVDDQKebsselcJZJzSqGLscPR { get; } // 0x0000000184D86340-0x0000000184D86350 

	// Nested types
	internal struct TJXYcYlQQWVjaqEPBpgKDgLMEDFIA // TypeDefIndex: 53824
	{
		// Fields
		public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		public BofDOjIlnPpdCKzkZiAcEniWwqDKA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x04
		public int uNOTfQyMOWuCyFHdxjInFQCpWvYK; // 0x08
		public int qtSUtcwsgIimOFSxJPvfZgSTNlRRA; // 0x0C
		public int iNOQjioNbBRxJPHSCBvgxibcstpi; // 0x10
		public int XtItsLpeiIFITQTrAkzeoFLrYOvj; // 0x14
		public int mYiobxRHuIWGgqKFAgyeCogCgzEI; // 0x18
		public int gYNfzXiewjYMkRFgCNTxgbhoexjc; // 0x1C
		public int pKuqLGvUTyhpJONaXsEAwRycGhqFA; // 0x20
		public int CvKCFDdzyYnNhtZkgiQHeEBvcpmPA; // 0x24
		public int gIXNVNOUUsvTJscMHIuLrdDZdGGFA; // 0x28
	}

	// Constructors
	public ajkStzGIJaDgjbLVrblCWyQPXycSA(); // 0x0000000184DA8920-0x0000000184DA8930

	// Methods
	internal static TJXYcYlQQWVjaqEPBpgKDgLMEDFIA aCLjbmCknACmVmpCCqRcKovsfAeq(); // 0x0000000184DA8930-0x0000000184DA8950
	internal void BcaDDZeihMgRujTrJVazrAjsWLLU(ref TJXYcYlQQWVjaqEPBpgKDgLMEDFIA param_000739da); // 0x0000000184DA88D0-0x0000000184DA8920
}

internal abstract class BslFyWdFqNvcSBpOIOOVPaeVNHaNA<u0001, u0002, u0003> : NinxpESAdWHMScogYtzEcrOKmWSq // TypeDefIndex: 53826
	where  : class, nQctLAKvbEudnDiceCspsjyQWyFh<u0002, u0003>, new()
	where  : struct
	where  : struct, yAcTuDRxvBzGjwYsLbbzRJSQLkNg
{
	// Fields
	private BdBmIXRJGKOiDSKgyDtNfVCrBQEn avZdMLeGGnpciBRtqYXbCGmpagVIA;
	private readonly Dictionary<string, HegtEhejPmLQIYSeBGlDUmMVfXog> kZIJmMxeGsSFnHbatwcDAPEOcYJA;
	private static readonly u0003[] tuzqvPEIjWLzOHhCjETGwjImFUDn;

	// Constructors
	protected BslFyWdFqNvcSBpOIOOVPaeVNHaNA(nmDUaUhbthOlhiDQJeKfGxYxeylPA param_000739db, Guid param_000739dc);
	static BslFyWdFqNvcSBpOIOOVPaeVNHaNA();

	// Methods
	public void pBdrxIfkhCoeAxTcHlOjIOiDbQCK(u0001 param_000739dd);
	public u0001 wPFOKUUpYprfCDMPnhYKcLjfowrTA();
	public void wPFOKUUpYprfCDMPnhYKcLjfowrTA(ref ref u0001 param_000739de);
	private BdBmIXRJGKOiDSKgyDtNfVCrBQEn ZQigHQgruyJfOUyTeykyunojQPpD();
}

internal class BdBmIXRJGKOiDSKgyDtNfVCrBQEn // TypeDefIndex: 53828
{
	// Fields
	[CompilerGenerated]
	private HegtEhejPmLQIYSeBGlDUmMVfXog[] FcSQZyDpQivoFWvBmvzVFDcwHdEC; // 0x10
	internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x18
	internal int JamCHqguHPGpzsYWkJkgUqgBBhSm; // 0x1C
	public ZSUAvntfLnoPvgBKYfVfuvtQblMGA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x20
	public int iuNYQbPwVApaHsrhjCzxXYEPzBgK; // 0x24

	// Properties
	public HegtEhejPmLQIYSeBGlDUmMVfXog[] kidCTAgaJTWmbWtqnuzgvoLuRezj { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0

	// Nested types
	internal struct FutXJCNATGBBBVcZISpPWUxaJkzE // TypeDefIndex: 53827
	{
		// Fields
		public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		public int JamCHqguHPGpzsYWkJkgUqgBBhSm; // 0x04
		public ZSUAvntfLnoPvgBKYfVfuvtQblMGA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x08
		public int iuNYQbPwVApaHsrhjCzxXYEPzBgK; // 0x0C
		public int iVJdxwBQvrXtDiYmHLYOotOQcPHgb; // 0x10
		public IntPtr owpoqybUmgJxbGYvZyZMEcbNBjg; // 0x18

		// Methods
		internal void tlMFikAtsnFGlFrXAOESOHxMzckeB(); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public BdBmIXRJGKOiDSKgyDtNfVCrBQEn(ZSUAvntfLnoPvgBKYfVfuvtQblMGA param_000739df); // 0x000000018ABA3A58-0x000000018ABA3ABC

	// Methods
	internal static FutXJCNATGBBBVcZISpPWUxaJkzE aCLjbmCknACmVmpCCqRcKovsfAeq(); // 0x0000000184DA87F0-0x0000000184DA8810
	internal void tlMFikAtsnFGlFrXAOESOHxMzckeB(ref FutXJCNATGBBBVcZISpPWUxaJkzE param_000739e1); // 0x00000001841E1670-0x00000001841E1680
	internal void KmiIOZVjDMCcknNOzTkUaihZTwDu(ref FutXJCNATGBBBVcZISpPWUxaJkzE param_000739e2); // 0x000000018ABA392C-0x000000018ABA3A58
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
internal sealed class NumFTHcWyFNMUnwclDnApNJtFwHK : Attribute // TypeDefIndex: 53829
{
	// Fields
	public ZSUAvntfLnoPvgBKYfVfuvtQblMGA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x10

	// Constructors
	public NumFTHcWyFNMUnwclDnApNJtFwHK(ZSUAvntfLnoPvgBKYfVfuvtQblMGA param_000739e3); // 0x00000001814F51F0-0x00000001814F5220
}

internal class HegtEhejPmLQIYSeBGlDUmMVfXog // TypeDefIndex: 53831
{
	// Fields
	[CompilerGenerated]
	private string tHndTBtfnWIalbcyHjugTmhxTLEk; // 0x10
	[CompilerGenerated]
	private Guid crFijMVvFbfzmdBbZSGXczOawiIp; // 0x18
	[CompilerGenerated]
	private int RdDTpqYHaWhRaHgZFpHToPqYjmWCA; // 0x28
	[CompilerGenerated]
	private poeujHXJKdgxzeFEVUBvUcmFtnlu gzTLeTCCVNDwlzTOMoYYMYJkfLSE; // 0x2C
	[CompilerGenerated]
	private int OTAkQQmAkIHoivQVLFSMrkKWMIYT; // 0x30
	[CompilerGenerated]
	private JusXszoNktGzFGSsuCDrqZOXPYLd YYRYLQkIcFanROmUnffIgJLHciYM; // 0x34

	// Properties
	public string cJMYRUIePewENzlebCoKsxxPfeZBA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	public Guid siWwLXOcgVFQaBSYCwupJaWLZyif { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
	public int eACABbdNxPpsXrChQCGOcejnVKCoA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	public poeujHXJKdgxzeFEVUBvUcmFtnlu SaoerZudwQNINIaXPcHwRppPeTAjA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	public int LXWtZSJLQtMoTbFjkdAwAqCiriInA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	public JusXszoNktGzFGSsuCDrqZOXPYLd qtIfMRoWBGZEUSCwsKeTMCQXFfRIA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770

	// Nested types
	internal struct ozvAyCXuKGgqigeHCTMEVggfEdBb // TypeDefIndex: 53830
	{
		// Fields
		public IntPtr fruetKtxnglqvJWPDpeQHtLRoAFR; // 0x00
		public int eACABbdNxPpsXrChQCGOcejnVKCoA; // 0x08
		public int SPvkVDDQKebsselcJZJzSqGLscPR; // 0x0C
		public JusXszoNktGzFGSsuCDrqZOXPYLd qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x10
	}

	// Constructors
	public HegtEhejPmLQIYSeBGlDUmMVfXog(Guid param_000739e4, int param_000739e5, poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739e6, JusXszoNktGzFGSsuCDrqZOXPYLd param_000739e7, int param_000739e8); // 0x0000000184DA8860-0x0000000184DA8880

	// Methods
	internal void KmiIOZVjDMCcknNOzTkUaihZTwDu(ref ozvAyCXuKGgqigeHCTMEVggfEdBb param_000739ef); // 0x000000018ABA6338-0x000000018ABA6424
}

[AttributeUsage(AttributeTargets.Field)]
internal sealed class UsoCBdhjCsFpPWgGxoGohJlQMojhA : Attribute // TypeDefIndex: 53832
{
	// Fields
	public string cJMYRUIePewENzlebCoKsxxPfeZBA; // 0x10
	public string siWwLXOcgVFQaBSYCwupJaWLZyif; // 0x18
	public int aOUUjcDdlPgnZIcRkdyYQqZGLoPtA; // 0x20
	public poeujHXJKdgxzeFEVUBvUcmFtnlu SaoerZudwQNINIaXPcHwRppPeTAjA; // 0x24
	public JusXszoNktGzFGSsuCDrqZOXPYLd qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x28
	public int LXWtZSJLQtMoTbFjkdAwAqCiriInA; // 0x2C

	// Constructors
	public UsoCBdhjCsFpPWgGxoGohJlQMojhA(string param_000739f0, poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739f1, JusXszoNktGzFGSsuCDrqZOXPYLd param_000739f2); // 0x000000018ABA9F3C-0x000000018ABA9F60
	public UsoCBdhjCsFpPWgGxoGohJlQMojhA(string param_000739f3, int param_000739f4, poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739f5, JusXszoNktGzFGSsuCDrqZOXPYLd param_000739f6); // 0x000000018ABA9F60-0x000000018ABA9F8C
	public UsoCBdhjCsFpPWgGxoGohJlQMojhA(string param_000739f7, int param_000739f8, poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739f9); // 0x000000018ABA9F10-0x000000018ABA9F3C
	public UsoCBdhjCsFpPWgGxoGohJlQMojhA(int param_000739fa, poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739fb); // 0x0000000184DA88A0-0x0000000184DA88B0
}

[Guid("54d41081-dc15-4833-a41b-748f73a38179")]
internal class NinxpESAdWHMScogYtzEcrOKmWSq : beaToZucjyOfmWGEnxdCGCgakptr // TypeDefIndex: 53833
{
	// Fields
	private BxcPeTIqLZsfHyGzFAombgJBgOBgA CCIDsGdBkezzjiCYAvVUqKLboyKN; // 0x30

	// Properties
	public BxcPeTIqLZsfHyGzFAombgJBgOBgA bQxjaUtIIAzBytgLlGJLWkKTvfYJ { get; } // 0x000000018ABA7158-0x000000018ABA71CC 
	public ajkStzGIJaDgjbLVrblCWyQPXycSA BkPbwOOXbHfrprsNBdoJnAuJgArO { get; } // 0x000000018ABA7C14-0x000000018ABA7C38 
	public asJwVBrSeOWneGuTCmUUKaDTCXQW HaJoSgyQGvIKAhtZwsROMPMhCloz { get; } // 0x000000018ABA7134-0x000000018ABA7158 

	// Constructors
	protected NinxpESAdWHMScogYtzEcrOKmWSq(nmDUaUhbthOlhiDQJeKfGxYxeylPA param_000739fc, Guid param_000739fd); // 0x000000018ABA7A38-0x000000018ABA7A90

	// Methods
	public IList<HcRHynaOJyRqcNcJqdaUjCNwaqErA> MznPZWFYHovIfnvTwQfLuchCFQtCA(); // 0x000000018ABA7504-0x000000018ABA7510
	public IList<HcRHynaOJyRqcNcJqdaUjCNwaqErA> MznPZWFYHovIfnvTwQfLuchCFQtCA(poeujHXJKdgxzeFEVUBvUcmFtnlu param_000739fe); // 0x000000018ABA736C-0x000000018ABA7504
	private static unsafe extern int AxSHxvBzfqylfXIptAxhKBZKBBoAA(void* param_000739ff); // 0x000000018ABA70BC-0x000000018ABA7134
	private static unsafe extern int VWWPECkrYMVsBueqQDPvLpvSntZy(void* param_00073a00, void* param_00073a01, void* param_00073a02, int param_00073a03); // 0x000000018ABA788C-0x000000018ABA792C
	private static unsafe extern int nYJURgbmJOiKYdzYikHbMfheswry(void* param_00073a04, void* param_00073a05); // 0x000000018ABA7D78-0x000000018ABA7DFC
	private static unsafe extern int XfDKazdHpSSHvtnCCYBbFpwMtcQd(void* param_00073a06, void* param_00073a07); // 0x000000018ABA79A0-0x000000018ABA79E4
	private static unsafe extern int SfQunMaEfrkvUFcTpiaRaTSkGeFU(void* param_00073a08, int param_00073a09, void* param_00073a0a); // 0x000000018ABA776C-0x000000018ABA77FC
	private static unsafe extern int htNczLIrTOhhLZIhqojELWddiMIp(void* param_00073a0b, void* param_00073a0c, void* param_00073a0d); // 0x000000018ABA7CB0-0x000000018ABA7D04
	private static unsafe extern int dAvfAxMEDcCNUGiIoJToIKOtfCctA(void* param_00073a0e); // 0x000000018ABA7AE4-0x000000018ABA7B5C
	private static unsafe extern int TZGGYBFbWjKPVKBBaJUcrgOVoDEGb(void* param_00073a0f, void* param_00073a10, int param_00073a11); // 0x000000018ABA77FC-0x000000018ABA788C
	private static unsafe extern int FlTVZZHkavFydpByPrsdEfygeFQG(void* param_00073a12, void* param_00073a13); // 0x000000018ABA7240-0x000000018ABA7284
	private static unsafe extern int aajgrhsheUBnSvThaJcSzQFAxRnh(void* param_00073a14, void* param_00073a15, void* param_00073a16); // 0x000000018ABA7A90-0x000000018ABA7AE4
	private static unsafe extern int hkQvHjFvIvDOYOdDtYPmVMGjKkem(void* param_00073a17); // 0x000000018ABA7C38-0x000000018ABA7CB0
	internal void RnRKkCABRuKQqtoefbomyRfdIyAI(out ajkStzGIJaDgjbLVrblCWyQPXycSA param_00073a18); // 0x000000018ABA767C-0x000000018ABA776C
	internal void MAuHDzjMnPcOWbSeiFCzttkSKDpjA(TrZygBjBOPxdNoLZDCUKGcceunIo param_00073a19, IntPtr param_00073a1a, int param_00073a1b); // 0x000000018ABA72D8-0x000000018ABA736C
	internal void FZbpTJYKmvFDvHfqhGDnGJLJLXTFB(IntPtr param_00073a1c, IntPtr param_00073a1d); // 0x000000018ABA71CC-0x000000018ABA7240
	internal void myZnuCrIBGWvxqjekjoiAHhhceUfb(IntPtr param_00073a1e, IntPtr param_00073a1f); // 0x000000018ABA7D04-0x000000018ABA7D78
	public void ZoGbtSrjNkpybJlqlhkJDQCcPlkF(); // 0x000000018ABA79E4-0x000000018ABA7A38
	public void IoyeuUADILkjyEidcCIyeCInNLwS(); // 0x000000018ABA7284-0x000000018ABA72D8
	internal void WuSaVHZtGxfwIdMWdiQmkvkgqKRQA(int param_00073a20, IntPtr param_00073a21); // 0x000000018ABA792C-0x000000018ABA79A0
	internal void drtdpDkrzuYshLmnvAEuCyRyPjPeA(BdBmIXRJGKOiDSKgyDtNfVCrBQEn param_00073a22); // 0x000000018ABA7B5C-0x000000018ABA7C14
	public void qgQQxgNRUXeZPOPVqlZKNCorGlvU(IntPtr param_00073a23, xyDAHdjbDRYaqEPZVCMNiWkIIuzcA param_00073a24); // 0x000000018ABA7DFC-0x000000018ABA7E70
	internal void OGrDcIXXNcEPYhAmTKABFmhvcEhL(out asJwVBrSeOWneGuTCmUUKaDTCXQW param_00073a25); // 0x000000018ABA7510-0x000000018ABA767C
	public void swHCghpaXnNJcxZhclsnDkVwtNWU(); // 0x000000018ABA7E70-0x000000018ABA7EC4
}

internal class asJwVBrSeOWneGuTCmUUKaDTCXQW // TypeDefIndex: 53835
{
	// Fields
	internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x10
	public Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw; // 0x14
	public Guid ystlCDcHjwlcYzgaLpkqnMWqYczw; // 0x24
	internal int uNOTfQyMOWuCyFHdxjInFQCpWvYK; // 0x34
	public string RAdTimOkRuPhcwvRyrBcdsSbqafR; // 0x38
	public string LOikUxXJsvTgyuFJrAzLxiECoOlH; // 0x40
	public Guid eCpxrOGGCIkMpVDLVEYonkQpyuvf; // 0x48
	public ushort NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x58
	public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x5A

	// Properties
	public Rewired.Libraries.SharpDX.DirectInput.DeviceType SPvkVDDQKebsselcJZJzSqGLscPR { get; } // 0x0000000184D86A90-0x0000000184D86AA0 
	public int VYKoqtbBjrGccTFhEMzSSLVuJPE { get; } // 0x0000000184DA8950-0x0000000184DA8960 
	public bool VxwjAuEHHcRvsDhckJuytMDdsEkO { get; } // 0x000000018ABAAC04-0x000000018ABAAC10 

	// Nested types
	internal struct CNqfbQSlroFLSiDmFWHFtobYppShA // TypeDefIndex: 53834
	{
		// Fields
		public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		public Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw; // 0x04
		public Guid ystlCDcHjwlcYzgaLpkqnMWqYczw; // 0x14
		public int uNOTfQyMOWuCyFHdxjInFQCpWvYK; // 0x24
		public char RAdTimOkRuPhcwvRyrBcdsSbqafR; // 0x28
		private char daYwlPGWFBpHiISzkXtwNYGskagb; // 0x2A
		private char BwnkaBQYmsmqErOmBghIPxDOtWRD; // 0x2C
		private char ZgUfhkJdpnoPAeFVeZbHplsUqYuI; // 0x2E
		private char CWNaoyderBmmWYRPfnuRChQKYAvpB; // 0x30
		private char KAteTXJfiRKPzGCEUiBHfHiLfCLUA; // 0x32
		private char sGauBLIYWsFZlptqcytczhdkmpY; // 0x34
		private char dbhuNcvBDNXXAgOLHASRMZmuagqk; // 0x36
		private char heczPQNyOjPUHRCzjEYBBGrZZYLD; // 0x38
		private char ZiidusAorAocBifnenHNiDcOqVmmB; // 0x3A
		private char neRjHNtFokcHqmvKoWhWaarLCjSz; // 0x3C
		private char ZlRLcdboheFEwzZyqqunTluQmsBu; // 0x3E
		private char ojbEGEEZfZaUKLvMgNmrHTizQhWL; // 0x40
		private char FbRDsHaSAARAIznWeGAUkGXUSyOQA; // 0x42
		private char SHfGPmOdsZfUNgFUOnDOakPpAWNEb; // 0x44
		private char yllrelzZbJYlGvaJIUBjOaJmkIUl; // 0x46
		private char CKBhXXlhRmsUsYGyfWIkjkYyVGSm; // 0x48
		private char eeRHZVQBNpQuOgHOoDixoKUMFGQEA; // 0x4A
		private char WjRIIkYhzEREKSBHTPcKFthPAAhP; // 0x4C
		private char wExPmklEcSqNAiTtwmPbHwnbEpvB; // 0x4E
		private char ywIpCEzmfbaxGizhorNLbtoqaEFzA; // 0x50
		private char FsGofSyexvhbQneQGOfusnKYgqcv; // 0x52
		private char euvasNdiOBlbZdWatQYwQZUQmDTn; // 0x54
		private char XarkVlXGDTiqktrVzFEQVUBBUYas; // 0x56
		private char yVhoEzEwOjARbLOGyKOAwemsXXpn; // 0x58
		private char gFtcMsYrCHhAFdZVHGpwmBhZfzNYA; // 0x5A
		private char sbOOOVlgGORhCmDULODRvzqYGEnn; // 0x5C
		private char VdgVDJPtqROzhGLbXbxpnPRaouDM; // 0x5E
		private char WSczoQQGpJimLqwddxEuYDyOtvyq; // 0x60
		private char zaRNknnnCsCFomfDmUOjozwjJAPe; // 0x62
		private char aDmQgfWnbmXEOMnXwZcFXBTGgtikA; // 0x64
		private char NsUDmnfIcDhrPexahvYDdeCSioPB; // 0x66
		private char ExzBLzdNRdBJLjTSOOzrZAzujenw; // 0x68
		private char RhVBcpjNPybRPMqQAOovidNbyVeyA; // 0x6A
		private char WLbNYsFNheeckMHNHdepjOCdNTjP; // 0x6C
		private char vPPtanypcRfTRtTuYlBoJQjlPKsc; // 0x6E
		private char nAIAWBjPqcehamVckjgmxUofAYwx; // 0x70
		private char yMHccMfflCnRoFllHHMlQGFaJjGFc; // 0x72
		private char VLnYLUyNHgjtjemIxFEwteNxDwILA; // 0x74
		private char pSGcsmJJmLaMdwDSoqFVIPOZpWRBb; // 0x76
		private char adnLKnhAoRmzDHHLiFXBQluYrhCb; // 0x78
		private char oCRmoLLBRKKAyxrHgWywvJnTmUOk; // 0x7A
		private char lDoiLFnCTFllqvbtoZEDoCtiUlqm; // 0x7C
		private char GbyyneWrqsLOfKfZzqgAcRsinJlT; // 0x7E
		private char VkILLmqslNfjdlzfZfdMFWXbQIyf; // 0x80
		private char tFfPgWMJzKocfIDWxOATiTEnpMdq; // 0x82
		private char vnYYKuavifCYMSiyizTJpAMWEKND; // 0x84
		private char KDMBrGfJPKONNkpiQXjLxJGblTUTA; // 0x86
		private char XgwKGvKxyacwvLNbCdxDPdTUNeVR; // 0x88
		private char GliaUyaTKjdvbhiuexzRLxwLqimDB; // 0x8A
		private char ZlAkvnXqgJHlBazTSfajDOZbJVlNA; // 0x8C
		private char qxhRukeLKqyxlDLQkUtjXWSCkANN; // 0x8E
		private char xDwHJeJFyOSbebpSbgjumGBihetC; // 0x90
		private char cDEtIGmfcBNePbHUGVnubClScNfC; // 0x92
		private char tZdAbLhUiSHYSpvhBloJOczKidbqA; // 0x94
		private char tNkYxnRGREDsGuUqAfHEfEZBwZyj; // 0x96
		private char TgsATikOopNZOZaCVqvMlwklhyuEA; // 0x98
		private char fQbYCDIKjYjwLeOIMDtNEyyiQvPfA; // 0x9A
		private char gROQGiutAwZBMGeItEWMIDGkNEdd; // 0x9C
		private char dyDvrWPXTAcAyEFEIsBPnlbiYHBM; // 0x9E
		private char CvQDpTeAmbimgsGNgGrogFZMSyXGA; // 0xA0
		private char gphHrMvXchbTpyLNoYCYBLIPSxrL; // 0xA2
		private char diAKSlpnPjnpnTbSiAWAooVjEXBC; // 0xA4
		private char FUdBnixOHvIURoXWwjJIbLBMiUzJ; // 0xA6
		private char BsVbSuASjnUZqXJWqbWUchHHMETbA; // 0xA8
		private char uiUVFeORKUlPfGUyAqdQdwTbDzod; // 0xAA
		private char EiNBywMaVVvKdevJRtcGcRaBMWfl; // 0xAC
		private char ANqPmPOQemoqhMBqDAxoFHwVytQp; // 0xAE
		private char SGlIjenPRwtfgYwpvMYTPzErmfeE; // 0xB0
		private char SbDnUWFcdZVxisnmQirLlivtxdc; // 0xB2
		private char zgSioArKocghYaowUkJpJkNFwBowA; // 0xB4
		private char iWyBcoHGHCZkTNleZBNJNiTHKWdA; // 0xB6
		private char EXsAncEaMOyzPfqCYjGHTosgaYKRA; // 0xB8
		private char TDVeixmGRbOQgQGMjMScnJQkEntz; // 0xBA
		private char wWBGfaTkwwaxnExPvTnhAOekxryv; // 0xBC
		private char rHzwHgsnEYYfloHxIBSJDqgWlRAC; // 0xBE
		private char fFOtZIATRXgdejOIQptmOCCgnqpn; // 0xC0
		private char nvqCxggWTdAijCFBGQiZElANqXch; // 0xC2
		private char MXIKFcHwDrYpViUcXMUDMjqKUCNh; // 0xC4
		private char CqIAQXbKOuUVaaweTEwhpparBnhC; // 0xC6
		private char whNxZyoYbWlLCiBqfDtpodKdFsoS; // 0xC8
		private char TzfQqoijevoxObjDaQgWgadqlxAg; // 0xCA
		private char axnGcjZxutJCMkfnBJKLRRbAeXWM; // 0xCC
		private char mXJMTZCcquknobmiQBahhJUUatMUA; // 0xCE
		private char exbkAZkUgrmLrCHSQDBoQIvwxuBF; // 0xD0
		private char qKKllQgLkciZmgQjEJhdpGhNIuwj; // 0xD2
		private char MzKvfrGLElzEoPexESEfKOYyrQII; // 0xD4
		private char WSUdQuJRidXBBOGHvHUyROlJGANx; // 0xD6
		private char zdGsoAHCbqhqnnSdKImipbMLzHyX; // 0xD8
		private char CZzafLbULQECdsGuuJbrbffQeLkTA; // 0xDA
		private char ThZyZIHDKHpbKpSdKaQHBpGZKlRP; // 0xDC
		private char QetFFUbTRQGArGjHjqGTglNcXpmHA; // 0xDE
		private char oUXbcCuExRgLZsMxBUOjpYcbTXRc; // 0xE0
		private char XPglVLQPrOHGHOqufYKHWSmBDYtb; // 0xE2
		private char JkoZSMXRlWslzcEQaOiJmGafkvyk; // 0xE4
		private char wyJWYnePVyhXYYvABDiRYyLKwWRc; // 0xE6
		private char AHaTWOvBknBjGrZTFODFdLniZTjW; // 0xE8
		private char uBgyRrkuOwaKbogUCeqYeLtnIYLt; // 0xEA
		private char rptlSPtZHbvYaVvhVBKPSBfrrlHP; // 0xEC
		private char PqLeAeyzSGSNlvrgdHMgmLqDBQgg; // 0xEE
		private char KowALjVQdIezPivQrjTeqeHNnrzeb; // 0xF0
		private char RfjlZyodlxcIKUXmhzwhXvcjXgwI; // 0xF2
		private char qNYiUBHwefFoXYUpUGPDtToaQqwH; // 0xF4
		private char xhifVldjQgNMSsqhzFcThaKdKZfbB; // 0xF6
		private char iDvkOxIdHAiqEqjZzcCReSVkAViHA; // 0xF8
		private char mkzOrWSzpQiNxPepaMHERrHBaMqT; // 0xFA
		private char aydgLXIubVQRlaemZLTMRhDibmHsA; // 0xFC
		private char RemlKYrldOFRYtomYtyeUPxnjOnr; // 0xFE
		private char HwOrIORMkxGdghGpDPNByeacyoxuA; // 0x100
		private char JBGuXreqcgHQjYhOfJiPlgoSHQrAA; // 0x102
		private char fhpVMRVCPKcFmuCtTkvzOztZJyUd; // 0x104
		private char OdSdSQblSHLKXkUPVrZjOibPCldEA; // 0x106
		private char wBUIWKVRcgvsaaCkXBKhHkHtBSDG; // 0x108
		private char LzXWkDLvDkJLfvKczMsRxKKsPvIu; // 0x10A
		private char zhaBsFcLuJTKybRHfjecAUKNMuUKA; // 0x10C
		private char MwEqyBzlzcibjWkRKuFiEWaIJOxV; // 0x10E
		private char dyhOcakeFTkJLNtuUviZTxGbxKdE; // 0x110
		private char DeuTsWIkvJKPkshprdSSjiCzhABJ; // 0x112
		private char oNDdLafnvCCoYTFTbTFuACddTCee; // 0x114
		private char HFGnfdEAyNpMGKwnSqZMnIrrESAK; // 0x116
		private char TxOQwVlPSZgNHhrWUzOvfwNKOQOD; // 0x118
		private char GhscESPKwWpeHqAkjOPFqrGcBktcA; // 0x11A
		private char RwASgKkEqHGrDgJBwMEQuZuwBlBtA; // 0x11C
		private char CdOVdbedeTOPjHGrLoXapyceLOQO; // 0x11E
		private char iRCkwCVhnyUJtogDRSXkJqIrlns; // 0x120
		private char rgPCnsPwVObljhdEJaHgQIMDHWuXA; // 0x122
		private char rLkDVgHEpyuIUQftHCgEdYWMelQE; // 0x124
		private char LEgvSqqFsbiiGRjEEnQxRBCzcbsh; // 0x126
		private char ElrdECgGIyJtyQIfMiwsCvVoIVwQ; // 0x128
		private char zXuomEWPOfdysAGfLYccQrJDdGSKA; // 0x12A
		private char ntNLhDVIUpXhjhFKIDgbKtvNhGSBb; // 0x12C
		private char jZAdMcDnLMcMZObkliSvHHwFOmHMA; // 0x12E
		private char hbbOndTxVDmkKPWkNhUmoNowRwYp; // 0x130
		private char tdHKmAIdVLbckOXvVnXQRUNyFQgU; // 0x132
		private char jDzzbjojkMXOkvEcXDmcXmgzhvNp; // 0x134
		private char okgLTPFDJVdutqBaVYgRUiYugDhG; // 0x136
		private char ffgmhjIgXOzotENzDhuSevauIzjmA; // 0x138
		private char fxhpBjyQNEUhrHwXoLbjWZaBUCAw; // 0x13A
		private char WrsEtJKnxDzLVfvQylofdYbYoPkb; // 0x13C
		private char tcKfoSHcoXlkMryMCeKWmKbhAnfcb; // 0x13E
		private char lNGrSbtlLVHDbBUcPbUkbmvGNLuA; // 0x140
		private char uICdPALSRYZFMfxCAmpxSSblhnyQ; // 0x142
		private char AJrPsVNnFQZosuGMMlEkImvCVESA; // 0x144
		private char UesCzKczeKewdKXyhswpRYcbFvMpA; // 0x146
		private char RtHyIDWNCDhAyiHMXKbZJmfHyFaHA; // 0x148
		private char KLlvOooNBqkKDbKZBfRsKLgpfIzoA; // 0x14A
		private char twKoCfqfhFzUaCVeBvMzPOujCPuH; // 0x14C
		private char ntLUrrsiUtueXZjTcjFVKizEBqsW; // 0x14E
		private char GKmKXselaSsZSxaNnYgkVEhNWlPA; // 0x150
		private char osWESdFUUhAcTxMVTkmVKEiZSFnfA; // 0x152
		private char dGIlEmsGkFTZrNOeQlgnrmTeYyAh; // 0x154
		private char IfDXcmmMRdkYAWTkURRzOXDGupoL; // 0x156
		private char FnimFTSICHcfShlDUnSFlnTWbfOXA; // 0x158
		private char QjYXfGJEmsWfBWgIDMzxavaGkwVp; // 0x15A
		private char HsQqCCxQTVHfWeHSqJjDKmVyaQVp; // 0x15C
		private char LljcEYtkoMcXXAGmrgZFxZyqyDNjA; // 0x15E
		private char qPGDIEzDcQznwjowzoKPdocHEvZh; // 0x160
		private char aPHvpavEBOZesQPpGaiCERvqcvDVA; // 0x162
		private char veXJTzuWAWPIVLmlwXaHxUZAfint; // 0x164
		private char ZqKeFqDGqYrfcBPSCFwaSVgcGVRy; // 0x166
		private char CVNkmkrqxIDJWEMWWCrjmICaYPBM; // 0x168
		private char uVlgVKNALXaEulrvCEDpNeCiKrP; // 0x16A
		private char fVPOHnaddqTYDTkTqpQXVqtkpOKA; // 0x16C
		private char NmATRwMYjjQupmKMEFUwobClDCVw; // 0x16E
		private char PGvmCDmVKgQiwGMOfjqjDldZtqMD; // 0x170
		private char UpyPjJgcNOKIpmpbphuaqWgKiztY; // 0x172
		private char JSqXUBsEnacrBnmsaJLTnSyAojAT; // 0x174
		private char DQtAbdeEKJIajwhXvNPgEhRakDfgc; // 0x176
		private char MCQqmYvzYAzGpvyadafrpNhtFdEF; // 0x178
		private char XEFyWvOErTkdFIOepivvPhStPQaA; // 0x17A
		private char wubvDEfMsDcYnUcmGGXDSHfHoLGw; // 0x17C
		private char UGZepNDDxVbUWxExnSbyhvqEonVwA; // 0x17E
		private char xYWinbuzVcmLoUOvdeXSeylPXhsqA; // 0x180
		private char ntmqiavfQlmuhkcltVEXZXwFFZzT; // 0x182
		private char GvZBNQZxPcAfermNusWMPoNLkoZn; // 0x184
		private char uWmEJesUUqlpLjPaeYDfkrggrJzn; // 0x186
		private char kcATVhOwCpnXGhYBPtcWSLoQlsQb; // 0x188
		private char IxGNGePcSRIwEelZjdvKRFQYECmfA; // 0x18A
		private char rwDigYEDlwsoMbDWlHJvHZlrVLVc; // 0x18C
		private char SfemkyJGBLleThliQkqGOubDkovB; // 0x18E
		private char DzNkOuEEIXBDGgHuGTdvVriMIBcmA; // 0x190
		private char rzptVmgFQglNJWkeQWsEumbWAYgCA; // 0x192
		private char zvDCWcWHctcPxkExogELnBVDMOlFA; // 0x194
		private char aATmbMbTLntmzfSeMtBfdgvayXMD; // 0x196
		private char hqOGjpogeWSkJMcDBkvZHkdaXTlI; // 0x198
		private char KnGMlNaDtOmqxyTJbhkyGxIpxNw; // 0x19A
		private char ggnfLULSAvNZhnyoqArwlkSUVkSS; // 0x19C
		private char WEBCJyjetSHAnGrJRMjVJxWnirXT; // 0x19E
		private char bbniCImUKYHwRWAimdJOnzIcWRrt; // 0x1A0
		private char KpebVqgBYrhtIaOLzWlDIwldddRIA; // 0x1A2
		private char zDcPOTaOxJCVqGLQvQGIcHmTjlUu; // 0x1A4
		private char kLgKZVEamGQXbfJjHPFPvCZpvOQK; // 0x1A6
		private char XHCmbxzLsXzTAeLdcDOfsrBTgZmCA; // 0x1A8
		private char CYLaKtKPLsKSzuLEzoaCVLmDODBMA; // 0x1AA
		private char LownjTIXCkiadUcaDtsPHixOVIDn; // 0x1AC
		private char DaPJNqYGaQrkSsGNqCfyVbWTaCrF; // 0x1AE
		private char EjFeDLRxEzPEQpLIesVEQoIqRLTL; // 0x1B0
		private char CMzEenYLrasaiiCbizOyumgRmEaw; // 0x1B2
		private char VRqokabMdOBmXURsJaMnDoTceLcJA; // 0x1B4
		private char ZwRftWwlbJqwvcDWgcPZLDggDS; // 0x1B6
		private char wTVTsVYnaCuxGYEbQqxIuvTxMUQT; // 0x1B8
		private char dapbrTgCLLsWxgdTzFZDqXnKyKkh; // 0x1BA
		private char KopkZVJEmuMDQSNiuOzlCNVQCFyU; // 0x1BC
		private char HuSmXxeBveLwfYLWIpnUIsUYkhtL; // 0x1BE
		private char kYHbCiavsiCHHIUyTtFZcDuAIikKc; // 0x1C0
		private char oQsFDzapuLOefRBfQazHzlWNwcUOA; // 0x1C2
		private char CPPbPSbVJNHVEXixTwKvCHThUOjE; // 0x1C4
		private char UMuzkiIfbmkisQISkxZrUcxDhaiM; // 0x1C6
		private char oCVIqmHCsmmWmGtjFIzTNbzAVkYEc; // 0x1C8
		private char MsRyqDekRcdfzKDWZEEgzJozaJlKA; // 0x1CA
		private char dKGDKOwyqAHxViViXMYUsoytBidB; // 0x1CC
		private char niJTtXLfhdzyNKTzqbPOiDyNCkSU; // 0x1CE
		private char NnXAtwlcleNKqHAgnJgAdVOKNfKA; // 0x1D0
		private char mbTXipPNojHKYtNPjTQYkXNTlnzc; // 0x1D2
		private char ZTUqjbxjvePqWckzTDXVBLpampJJA; // 0x1D4
		private char LnyzdYUutgUkpQmpIpUdEtfMFwsT; // 0x1D6
		private char JeWOoQfPBaVwasUgIgsqWxRSMdTQ; // 0x1D8
		private char lJRALLdJBLhlMpGFrvEqIhVdvbWeA; // 0x1DA
		private char WSxHllvveqTaqYeWfMUjCKSSWkhG; // 0x1DC
		private char iPADyaWPxPzpCjUOhjotsPJutqkv; // 0x1DE
		private char iXAdBfUCOWKpumfOjjjOjnDbAnZaA; // 0x1E0
		private char CWdnfhQGFehvuDRiEPAxeuIUcRxB; // 0x1E2
		private char sHGZZQRGmvSRitptPAOnuGPgstGX; // 0x1E4
		private char UGlvxLJUmOpgyCIkbHjticBxQrsj; // 0x1E6
		private char FILuTmwObPmlAwQvhPUgWQkhDbjF; // 0x1E8
		private char GyJeRNIvxGYrcPNVOxkieYKIdUhHA; // 0x1EA
		private char iwoRTcggLDKvRVmflIgQRuURbUne; // 0x1EC
		private char xlVwxCSVDKQMxPohSvsqRVAnwpeG; // 0x1EE
		private char MvtJuWRHnAInJuOqJfddGJWRzPJm; // 0x1F0
		private char XXSMQwiotswLtUoxGTAVlVNgbKGe; // 0x1F2
		private char dnagOgAqJWsnVLUwvBijaDtjJaCPb; // 0x1F4
		private char stIzNxTApcOdsNeZkWufsvdeiIOD; // 0x1F6
		private char IkqcimChiRsivFHsDtMzJTCUHOPYA; // 0x1F8
		private char olUepJeUBHlYedMyCxOzNWXKuzrzA; // 0x1FA
		private char OvaIhuOIEADciwAkXUPnThmCyhRX; // 0x1FC
		private char hOGDTnFMwFJXZzLNTkivFRxnnYSo; // 0x1FE
		private char shZSZnVQjSVnVHuDcvKxKchckJDS; // 0x200
		private char xFYGTWSfhKCowdbvbeMeiSKwtRGP; // 0x202
		private char BZkfMKJMHMuTOdHmikMQgCDDoRRh; // 0x204
		private char BRKzlSJgVrMYvLSTPdhBNaUVSVNT; // 0x206
		private char xrYdoKlQBcGabevGISNjEcAhGbecA; // 0x208
		private char HGhgpIhoNwkEBhyJkaQygkGqYdjn; // 0x20A
		private char XJcriaUAFdmDwXTfJNDduLHMwPPv; // 0x20C
		private char pOSdRjOizdVkKHdheIUXhywSlpSB; // 0x20E
		private char PCpHYbhGgxooqwtmVVZqClvLWodz; // 0x210
		private char ulVmEfSLsSgvlnebBfCpmsTOfGrr; // 0x212
		private char ZHnNkwFhYtPnOvpfWtFXQmuTYqgB; // 0x214
		private char PrjGinSeOwSsjsceklMGyAcPHvWU; // 0x216
		private char HzCvCcDRmHTtWePnqpNJmoydTazg; // 0x218
		private char IkwHRTSIUdWefVxqiJDWbNKrGltb; // 0x21A
		private char eCzNXCZzhAMpzWMbtXpYcZTLLmGj; // 0x21C
		private char qqejSIXyHznimxFDmErHuyhwsiso; // 0x21E
		private char VjVgendyKVYZfnSuhCNTVqsBErOk; // 0x220
		private char iZmoOuhMpbbOZAlGhbQfygCYUtGlA; // 0x222
		private char aOwTvTZxArpzDFKzmLqozjCUmYUc; // 0x224
		private char pUYfHrjrPSPJLBXZNxhGfhkSkVyF; // 0x226
		private char jTSGJqJAUSUIBCDKtTWOwUuXjSaM; // 0x228
		private char lBLOGJOyDltOEVElkUsugPRIOoiB; // 0x22A
		private char tchtAyzkqTozKnQjOqevJndqHGel; // 0x22C
		private char PJVWQlmHjTjjXhFCNIDejJQacKRqb; // 0x22E
		public char LOikUxXJsvTgyuFJrAzLxiECoOlH; // 0x230
		private char lDPBqIkkDnWchdYJFTVJdKsknVEeA; // 0x232
		private char gGerbZICYZghxwyiVMfcRkfnEQTBA; // 0x234
		private char yYmuwmFHDUgxYuFkrspwQcZlhQnj; // 0x236
		private char vGGaJtJOXUvOCcgdOogCadCBnLVAB; // 0x238
		private char qhUFEFatDzvYWyBerdDtcHcnXQiuA; // 0x23A
		private char HAFxLahqQTIOmYCPZeJrQOhqKVgh; // 0x23C
		private char VrkiwPEQodsCUYehdtwcnckgcNFjA; // 0x23E
		private char PTEDPXkhHdSyyCzjLglUhKXPnngq; // 0x240
		private char XAidRkUGjsECWyuungbJMEeDwwdp; // 0x242
		private char XvGmHosHFFWdYWadiWHnkXQamXNo; // 0x244
		private char CerEaQaQjTIvruvJrYmUKLkcHDKVA; // 0x246
		private char KFzktaZXHAqsxcncmNvhihkEWNwV; // 0x248
		private char NQLcQRgHhmPsjJvUOIHwAjdDKVufb; // 0x24A
		private char LRxPdyvLWsDxaCdGeQVDABGGfcGPB; // 0x24C
		private char LGHzuSzDzKabpHnIymNSySNZnZJGb; // 0x24E
		private char FdkDbLYiqVohPNIABrwmTcHhnlJb; // 0x250
		private char kbhNUpJvpbpKxYhqazTxNOSBfpphA; // 0x252
		private char LPgxKhKuJnsfCNXLXcXnKMmFqDuV; // 0x254
		private char rlDOcDJypOdRAaLMuHOFpVLiHHhG; // 0x256
		private char NGIaAqgffBEEEclGjYhZainaEkGKD; // 0x258
		private char abAQFGcJELHrSyUyogJPCaQeSCYlA; // 0x25A
		private char RvrbxVMmboiQOWGcsPMlZTjxIeEc; // 0x25C
		private char AJmSUHEVNkwhjiBmXkkMhmvFKHee; // 0x25E
		private char XnmNMjSvjteijqZhjRJQfTfZuaw; // 0x260
		private char rvyHOfPegzDQmQbiadyDhOEwwElKA; // 0x262
		private char UwGlCFhRBxjwMGlsVkgMIXojglRgb; // 0x264
		private char rLrFVxLtlfFLeAtIVpZvCVVMnZbAA; // 0x266
		private char hDnCwzIAJbClYzkEyWKUcQNOYtPl; // 0x268
		private char jffoIuLAArAmqKwJuuaVhfbPjDzd; // 0x26A
		private char WVdqLAkjMYkMbcEbWjtAfIyBfUBU; // 0x26C
		private char dMwLdPzvJMsrCfcsOlrQhTnqDNPG; // 0x26E
		private char UmeBAOXdEqERFMAXRygUTGKgYSfv; // 0x270
		private char KLFNJLVZBEwCEpEYcCMSOJffpSvo; // 0x272
		private char MskdtydcamRlvSKbeFmaoBsnRNTFA; // 0x274
		private char onqzhtZyuPIhPCcraeIOFAYyoeAQ; // 0x276
		private char dFsadywTwSQeBoGkoDlvvnRVchibA; // 0x278
		private char RCeAnJgWOvhqLiNtTClxxDCWnJOWA; // 0x27A
		private char IulxPwMJOojdwIlojpZtePjwSIvTA; // 0x27C
		private char AUHaRhDRsgAarXvaILTWZDiOJKpgb; // 0x27E
		private char eKaQhKyyUWUnvnEjFDERVXxMlHYd; // 0x280
		private char ACScznzfhGZciochYxsibLhQFiDJA; // 0x282
		private char ZFefkgEeKnkWrCQbuVHudeoimagMB; // 0x284
		private char JWZrGxhkOZjPtaVTBhiTabyhwCXeA; // 0x286
		private char BrcmlOqduoIbqSMxiyZqzYxYCfiI; // 0x288
		private char QmqOjfDKnQdNwTUwNxOphSNfSzpl; // 0x28A
		private char wnuWSWsKpKjPeKKIEHDBhYRyNREu; // 0x28C
		private char IMRQaZSGBWdpqnFfOLMqUBRzDNVu; // 0x28E
		private char NHqLkVbaNOaEpnDTTKZvPvKjfBaH; // 0x290
		private char TxAgbjcOwvcCFYJMPGzGscUixLeQA; // 0x292
		private char mShlaYQTLuHQMfSAtfZkNQLnIicf; // 0x294
		private char faygBuKXbpKnjGabOUCjBUQHKtDSA; // 0x296
		private char ETMRaSydaHCUAaEpJrHigbDgOZsOA; // 0x298
		private char pbwNOBovdBPhBNydjbmzOaOecsIr; // 0x29A
		private char mjrAXPviZzgmrtGYPaZsdwiWtsvH; // 0x29C
		private char trXjHVsGEqBdVjRBXGfDjUPnZvcqA; // 0x29E
		private char BWZGRIZUcHGAgIPVzffVnoNTzFeO; // 0x2A0
		private char zBhwSLakddcwRQGqgDjGPcvVQgPU; // 0x2A2
		private char gkPQaFzzQzCFIAojxwWNkIJDAcBT; // 0x2A4
		private char InVTnUKFgXjiqtLNJdzfXNDXoRWw; // 0x2A6
		private char ppUjezBgAoLYFfvfTCHboVwYLhQm; // 0x2A8
		private char klBUySxfLPAVyqchGcrQJmntmBjx; // 0x2AA
		private char IcgelzGMkrDkYLPxaLzrDgfHNkICA; // 0x2AC
		private char DPnSMFJBImcCxUuwJgBgSluhDdoFA; // 0x2AE
		private char qJSFoDNTLaEVibhbBscrGRAgBxtzb; // 0x2B0
		private char FZtPNWtZncRRspiTKuLhHYJByLrl; // 0x2B2
		private char VrqaDucratSjLTlBcAkjgrnophBg; // 0x2B4
		private char NjJFZkBPQyGrJaFXuETqBPRPaIhzA; // 0x2B6
		private char ezuxfpWldCkYCCAnvcOsYQWjKCkT; // 0x2B8
		private char gFDgZApGdbjXeGFFZXSYtUuDRSdN; // 0x2BA
		private char DZUiZrSTvUBmTgohnOibPjDgTuHR; // 0x2BC
		private char LpOLummVGfWUhhrkzSEXVJRPUMek; // 0x2BE
		private char PJkWHYePXgrCmNbOQUZfaxarnxEF; // 0x2C0
		private char eLwDBKgZVzFjJbEEGZjNEJAWsXskA; // 0x2C2
		private char biCrpKkWuFxaMfhxHBTvwSlhYGpi; // 0x2C4
		private char xxruUVMMypJukEThWjJbqFpJleKq; // 0x2C6
		private char OWVFVwdXGZPkMfZtQCJObNkeyQpSB; // 0x2C8
		private char BgKtNwRUEEvUiBfDWxoLlnRwgnfA; // 0x2CA
		private char WyUfoFshwldIXhphDIuozbsQUFzZ; // 0x2CC
		private char tYrwffALORjkPIDpXNOClDOXdXJFb; // 0x2CE
		private char wTOWDbpwuogtKTmhiNcHtZDnCmUc; // 0x2D0
		private char unATTIaVhUUVlUXlfAQHzMdCwsJR; // 0x2D2
		private char NqddXmDbxmAprfYvsyVkAnIzEwvfb; // 0x2D4
		private char XHHqUhxzNZspAavKYpJXzGuCdWhV; // 0x2D6
		private char pkVILrQjkIwEAMtlqTSOFxsWOfOf; // 0x2D8
		private char MfcoKPmLEpfMImAOitKiWJFMMZUf; // 0x2DA
		private char aodLRWUmUhcarPatrzvkTrBZQVLB; // 0x2DC
		private char kHZmVuqbBLfJEEolWClNDvJlQQUx; // 0x2DE
		private char arUzVSbBTyjFBBxnRMAttYXrSneA; // 0x2E0
		private char FarhDNJpKYFGgEIvExRRHnZtwCarB; // 0x2E2
		private char lNsyASkdToDxHXvJXstZHbokDRkEA; // 0x2E4
		private char ELNKnSgzMPpKkUtQqFeqmvZOZoti; // 0x2E6
		private char JleDUGyqqkIoAKIjMLlizdbDHgYn; // 0x2E8
		private char qXLEvmtwbJQnJhTiDdYCbTbrmbwS; // 0x2EA
		private char GSkXjszIAMUdFDVzDLamGvVLsuIT; // 0x2EC
		private char ggxYsUaWWcDxCfQxGDBxpjjOLgZT; // 0x2EE
		private char xRPNrfthvFLzopjnlfYckhTzOARS; // 0x2F0
		private char ZxcfTfRQomIoJNoHDzjlXatxzAvS; // 0x2F2
		private char KCvXJdhMgAAKBxHSUgLgldhZjdsp; // 0x2F4
		private char WhydAnHJMAGpCfTlkQKcxqxQXiCu; // 0x2F6
		private char bwPVKEASSRfYYIHoeEIMMtcHaYcI; // 0x2F8
		private char tTeauqaMeCetKaeQJoOxiIswiSxNc; // 0x2FA
		private char THOLiCreMsjwjivOsCBOXIEcNAGGb; // 0x2FC
		private char opoCjzOjLaDPaXiNLLWrqKNpIjPd; // 0x2FE
		private char ulqoGPKInQzSiLKcwnnCnqvyZFhR; // 0x300
		private char wnUbQRmvqHIggYDlqGTleqyIumjV; // 0x302
		private char xlsdhIyCuKxVmurjedEjuLQZGqzS; // 0x304
		private char YBvFslZOuZEUEpDDVdhAJvSeXUmIA; // 0x306
		private char HVmOYyzQADKGcwTBCXKhFGfPKjFG; // 0x308
		private char XHWHgCtdJMwAyuRSzJAUmfEcCunE; // 0x30A
		private char zAMNoemeqyxxYOcEAVBuYystrrZR; // 0x30C
		private char kEzkLnciiLqfWxxnYefDsbFXCfsR; // 0x30E
		private char DAsEDULLAHPKTBKUXFTvRqKdvDxJ; // 0x310
		private char emDDHKIsuQGjNrEGzuNDHtlOGocIA; // 0x312
		private char sIwdUfNWSEDOMHwdJEcEguAHwCwRb; // 0x314
		private char gxTBxlESCQzfjUSvSHbKfyVqabMm; // 0x316
		private char vekvmKihssYjELtQywVTKSwahPab; // 0x318
		private char erImeDpHaLfweDfvbesxzGJVKkAM; // 0x31A
		private char bZSzsYzXpBUqYxKInGnQftowUdCFA; // 0x31C
		private char dqBFMkEWYHuCnTcZhefQDwubJFDmB; // 0x31E
		private char SWPISLvrnSfnMnyuEMSwWVPGzjXJ; // 0x320
		private char LyHbgVNGEnFNtbcdrTzcsCgtfOGfA; // 0x322
		private char iYtSmEXglGhHhursGDFbTENpxtjK; // 0x324
		private char qYlgsAkONlisAFsJxyXWtQjApShO; // 0x326
		private char OfVDENCTqdWlDFMhNuxKOdYSYeBvA; // 0x328
		private char RUtqAuwGZEAeojMGZIcgVSlsobagA; // 0x32A
		private char KxTfcdkzuuPmNOeHqehdFBbmYebhA; // 0x32C
		private char RKoyFrTBQwwHxKzfnAzdPVjfvoaD; // 0x32E
		private char ROXnKGUlrkMtvtPzDJleUYuDqzck; // 0x330
		private char ziBcXfjFKhvtGnwfCrFPEcazejSh; // 0x332
		private char vYbWVWGWpakTuVOSEJvhoJHUIQEaA; // 0x334
		private char FFObBsvztTkbQbCSBamRVWVXghDp; // 0x336
		private char MvGPxFwRiIQunCPMzFextrFOjdhu; // 0x338
		private char oFrHJughknqvZVmotiNazCCpWfQp; // 0x33A
		private char jbIcFomgnqfRmHScFrYNAAhAMmZuA; // 0x33C
		private char eRWgJilObxzsRqKYgudEoqZBARtEA; // 0x33E
		private char wYoBbjNaEBJqqPcyWjdWbvyPpIvN; // 0x340
		private char METhHYBcauRbVGELjrZqMqsqlfcrc; // 0x342
		private char dnQtcSTWUZPVfvIGFPSIblbGJyql; // 0x344
		private char nQpUOwJocTeIBzVGlKpgwvEsIXdQ; // 0x346
		private char slTPgiNQoZkuGnimRYKLkyUQjrQm; // 0x348
		private char GGnrMXtxVRiCioOIgTpgnyQMrnQT; // 0x34A
		private char TscpaDxGAqaOCEIwoMXugjRCMrRj; // 0x34C
		private char qsjfSCilRpPKWHucwpkCngvWbnrcb; // 0x34E
		private char ehnNozxZKWpLUCfNHnJBZjhflCWo; // 0x350
		private char UQucYVOEyQyFDWEbvDSSSgjsxggD; // 0x352
		private char DvDXBwZBTTYkbHyJhQfeWNgoVFfB; // 0x354
		private char FPOIhnIWVSBamduVRcTyWtzSsfhf; // 0x356
		private char SifNagIvLSWdSJAkVXwbsgaHbXyC; // 0x358
		private char JNUWrcSWmWFscoYOADEHyrMxumJC; // 0x35A
		private char YLBYnGJUQvMbpcTMqygnSiCjKMoi; // 0x35C
		private char DrrdjkkGfQyaGKamqGHgrOdthaOc; // 0x35E
		private char SgKuzVDHRGJLCBAKqryeruNKbqei; // 0x360
		private char nOIzmFfsdZDAiXHoMGSEJvlAdjtTA; // 0x362
		private char WnaOqEGhjsjzwEqAHUBdwGIQkBeg; // 0x364
		private char VzUNdfHJXyjhKUEWLxrXyLvEkcCq; // 0x366
		private char HTPeitDvQpqzZHufdSGsgsurPvMYA; // 0x368
		private char URrWXiZMJVTFNuHrNgCyZqCsJXTL; // 0x36A
		private char IUFeoJkEhtPyozvfkgPXluQolwFeA; // 0x36C
		private char PtsMBLRhgbbRrrPspcDYHvTMAumh; // 0x36E
		private char rkMhhHTXaMWrQekwzPXIsoFhesDF; // 0x370
		private char LchFqLVKpkwNlzblBchjFqFcvfFG; // 0x372
		private char BLJRsyWgznEPuqdjZMPrhykGJJpv; // 0x374
		private char sPcqeSEgamUTkkCoFFEDrwVEeLgy; // 0x376
		private char HQaHKUgkCweuceFuvFeWrimSCnQab; // 0x378
		private char tzZliDHfFfqaXEFgkezRoBoPbRFQ; // 0x37A
		private char ImJThjrQFXxOrtrkIJPHkFJzKoXk; // 0x37C
		private char omNmhWlAIOORhhxwDrlaYXoTklBC; // 0x37E
		private char MYxfTXxwhGEdtswwgULFbNrWelmHA; // 0x380
		private char YUzRhjSRLJwqzVWlQLoVrrzeBpbR; // 0x382
		private char VAOFjxAZFAgFUsNeuootGVuBodDdc; // 0x384
		private char vLuvEuYWrUSGLlNbtIzPbKwbStfEA; // 0x386
		private char SKKebOidirrCGHMYfvyuAHaqrUQV; // 0x388
		private char ZFQHcgIulcSMokAWWLAoGRXDkFFC; // 0x38A
		private char QdyuCDYojXzqLAtGSPgYswhqqtwb; // 0x38C
		private char obEGHSqsYYCwVQYNZDsNiCMnFLSK; // 0x38E
		private char NnMrzzZbfGpqAWlyfIaLGAlijBwkA; // 0x390
		private char MYMZCwzhuwqtqxLGAbKNkneCZbLt; // 0x392
		private char LrNRcNzcBNyxNTTHHAgcdSSpYhBe; // 0x394
		private char kVIdfpShtCuUvGBaWbQDGHZFWMJcA; // 0x396
		private char NutmCXKmHlDXitWUcHVIWicpiDFz; // 0x398
		private char hTkCdXpoolcVDGTTvuZSLqjlHviLA; // 0x39A
		private char HudDlmrplvzyRflYAMtDEiPIHxYQ; // 0x39C
		private char BRtramwisWirZQqtNlIERKFVfjrG; // 0x39E
		private char AQiLIiIQYqqJlvUdyGetXmkyZZuc; // 0x3A0
		private char RLvhMRQEpMBaDULPQNzFOypwbmBe; // 0x3A2
		private char GUlyhbTWokiIkXvpBdZBETIMHJGi; // 0x3A4
		private char aRjtbDNYDRXrweXhmakgBqvSKICd; // 0x3A6
		private char bswXTsviQfBuXqMvXfLmIniVJvil; // 0x3A8
		private char thJQbWtMlOYSUghGNiZSiKwWSaoJ; // 0x3AA
		private char zuMcPKlbvPobTKXBDcGNxBfPkwKp; // 0x3AC
		private char OHTUVmzuzHUjUaJSGEnCEpFtnPYw; // 0x3AE
		private char rLJGrXbvXnBrUSIbbvbclggKyjOB; // 0x3B0
		private char RKHZKOeahZdJlBDGqInNSaSRrTvr; // 0x3B2
		private char FSghMlmaVERbYgoIRkdGXGaVGXXV; // 0x3B4
		private char UfprmLnqlzMleKSnEBisvfglwawM; // 0x3B6
		private char JRVfRfYuzZbELEjaQQHbHatwiuQd; // 0x3B8
		private char CddJbPeRGVgOutPwxrBGSsTNRLej; // 0x3BA
		private char FddDYkCIGGFeAQNMzvUJpyIRoWle; // 0x3BC
		private char jysHOgYbyUERJvJXMvjFvuijHEkV; // 0x3BE
		private char YJrIqDjBViGYCAyytikqBUylOxsDb; // 0x3C0
		private char bGuOLHszfpCSArSYlfoQfTkybCkK; // 0x3C2
		private char SYFBFjwMmbFgGRHeCYfrVIlNHlajA; // 0x3C4
		private char jfMkFLIGClgxUbegwzpGSinmFrGuA; // 0x3C6
		private char EBiYCBzGpTcHTFUZUCqjSuVmWZiE; // 0x3C8
		private char gUKztiVdKuntFgIdJpmPUBEwxthq; // 0x3CA
		private char RhmaxmdMMMfFhUOoZddymGMupfRs; // 0x3CC
		private char KpCDjDOCLHhOekfsXMtcDUNzXaZCA; // 0x3CE
		private char IHJUbWTVqwvwldOMlnAbGYQkoIin; // 0x3D0
		private char FjpgonGEPTHsdhvHMfaigEyyflPI; // 0x3D2
		private char gstLbjOKFOhItXoQoWFSXXipPlsE; // 0x3D4
		private char WJUhcpofnCEMqbeHBQXTwEnGIOaQA; // 0x3D6
		private char QUDzKZviwzLOsaYKaGxaDyMeITgT; // 0x3D8
		private char aIZKYtVxvYUmjYaPwfKsOFyHJIfD; // 0x3DA
		private char TGsfZsXelPsIGqjoieFeAxhOQSdsA; // 0x3DC
		private char LVNOxuYrOQcVLIMUvXrsjrNBmzLQ; // 0x3DE
		private char gZabsBFrPNGjAboHDDfdBJxoBHGyb; // 0x3E0
		private char WJUTragtDdqQRjtvIiWfrZXmsASA; // 0x3E2
		private char PlMaahILnBrywmMWpXoEIGcZNIMfA; // 0x3E4
		private char tZynDcyptKxcsVMCKXktxHnfzPqi; // 0x3E6
		private char LvlxDrJREaryAldFxDtgcqfsfvPDA; // 0x3E8
		private char iftAsXHITSAvXNXFcZPrHJJTFItEA; // 0x3EA
		private char WHCljJiAUCzYLWSGPUfCcIjDxQNn; // 0x3EC
		private char fLqyxhMteIdUjGYPCIKiKbvdgfNh; // 0x3EE
		private char RXmEGLcrpKXKIQFqjfgQmGKiScZgA; // 0x3F0
		private char xgUnlUMbkSDdMhTRocsKeAkEjVlMA; // 0x3F2
		private char yAtFPiRRUufdlKzTJPRIlLuzgMyy; // 0x3F4
		private char NISgewiFjKsdcRdmSNcfanGxZZYG; // 0x3F6
		private char iwCqUVhWIyLCMGBaQPlNhqPIBfaN; // 0x3F8
		private char vXMaYZAOhNxbdciwPSPKtZcBKzZY; // 0x3FA
		private char WkxAiXCpJtgQJgZnDevVnMAjZoGGD; // 0x3FC
		private char RSSpFkeWYpTLpOCPYxXHbmfBeZPU; // 0x3FE
		private char QFfHSCdEFzMmJYSRZJzdTQudstDG; // 0x400
		private char vUIRfrUXkFbDqpuJnZvsrIBqwxYc; // 0x402
		private char LPVfzVmaoLWagxheEwcqBKzXBHIg; // 0x404
		private char xChVmmBskwEfoxArqsjPRbgIQmtN; // 0x406
		private char jDXBhBvBszcsSgdkOEytBVlSYKSR; // 0x408
		private char MqcAgBjSjbvlKgzTjUQIEQgrzNJIA; // 0x40A
		private char kKloobuftkoCuRsPGAwbYylHaQYT; // 0x40C
		private char JhCYAcIcmNdQpJiAQbsAGeIFVOMA; // 0x40E
		private char RKNmRQIZlvIJJgRdlqvXJeUOtLuU; // 0x410
		private char EVSZuVVlfQEznNAyRGCmIQLTybtD; // 0x412
		private char FMpCRZhhtJdaqelnKsMVIijCNDbME; // 0x414
		private char vtkEUBbLeDrpsCigMIJKBJkcGLwob; // 0x416
		private char MMayMuLwVCAevxChGvWnMulNCFqu; // 0x418
		private char ZtDbmnCYrMGKUrZWuZUCAMHDGFbSA; // 0x41A
		private char CJadqhOVnzwKArjMdMPjVaaUocZe; // 0x41C
		private char AvZPuZZzSbNYbGEZQTzCibgggMvG; // 0x41E
		private char rbzjnZcqMRHtUSdllHvaRLoHgVBfA; // 0x420
		private char oQzMzrneVqEmqioXSUfpPEHTrxkAA; // 0x422
		private char pAKDCntyvtlbOFnKIaTXuuBMFhNh; // 0x424
		private char xdRmxMEorTjOPTrtJtAlCmZaPBmc; // 0x426
		private char BdpKCNKGIOXrfEbxEcEwwqOcXesR; // 0x428
		private char cGAIaKLVCBskOsAChnqsVzFkSlbi; // 0x42A
		private char VpVAxksVranxHrQbDUvsNhgbaRHw; // 0x42C
		private char nCPeKMBuAAJmgjpIwxTVcKPRRORDA; // 0x42E
		private char yZrdriGdKyZGQHhAPabvwAfNtdeA; // 0x430
		private char pJFbqSWKPCgGGDTXgbYmiZwZWKJqA; // 0x432
		private char RYBJHroGjgfxQZXiVbhhaBqgjLdT; // 0x434
		private char hmpwRViQrXMguKFuPDeTfrjXQrWBA; // 0x436
		public Guid eCpxrOGGCIkMpVDLVEYonkQpyuvf; // 0x438
		public ushort NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x448
		public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x44A
	}

	// Constructors
	public asJwVBrSeOWneGuTCmUUKaDTCXQW(); // 0x0000000184DA8960-0x0000000184DA8970

	// Methods
	internal static CNqfbQSlroFLSiDmFWHFtobYppShA aCLjbmCknACmVmpCCqRcKovsfAeq(); // 0x0000000184DA8970-0x0000000184DA89A0
	internal void BcaDDZeihMgRujTrJVazrAjsWLLU(ref CNqfbQSlroFLSiDmFWHFtobYppShA param_00073a26); // 0x000000018ABAAB68-0x000000018ABAAC04
}

internal struct ZiNFfyMDyvFubBAcAJZJdlSkFDnK // TypeDefIndex: 53836
{
	// Fields
	private int hHOhDmXXIIbTDlbnlvBbdCfmTboR; // 0x00

	// Properties
	public poeujHXJKdgxzeFEVUBvUcmFtnlu qtIfMRoWBGZEUSCwsKeTMCQXFfRIA { get; } // 0x0000000184DA88C0-0x0000000184DA88D0 
	public int LXWtZSJLQtMoTbFjkdAwAqCiriInA { get; } // 0x0000000184DA88B0-0x0000000184DA88C0 

	// Methods
	public bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(ZiNFfyMDyvFubBAcAJZJdlSkFDnK param_00073a27); // 0x000000018ABAA87C-0x000000018ABAA884
	public override bool wmgNCKPTdHLFLNHTicNSGFrTxitCA(object param_00073a28); // 0x000000018ABAA7C8-0x000000018ABAA87C
	public override int GubJpCYCjfcPBxeJkADxCoihHVYdA(); // 0x0000000182B77620-0x0000000182B77630
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAA65C-0x000000018ABAA7C8
}

internal class HcRHynaOJyRqcNcJqdaUjCNwaqErA // TypeDefIndex: 53838
{
	// Fields
	internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x10
	public Guid DYDgicVxAtJbyiHVjwCompuQFHss; // 0x14
	public int eACABbdNxPpsXrChQCGOcejnVKCoA; // 0x24
	public ZiNFfyMDyvFubBAcAJZJdlSkFDnK AlPILbxlBIGBViEEirdPjUsYLwGu; // 0x28
	public CyFASCppRXrIorhnlHrqucehWOo IVLQDeuZqJDUYRaiimtNHkMoXOwC; // 0x2C
	public string cJMYRUIePewENzlebCoKsxxPfeZBA; // 0x30
	public int OsBpaIRiKvssaqCwwRFpMNVbJbQh; // 0x38
	public int scZgJiovcLTbfUTBaTVQAgKBZhyw; // 0x3C
	public short LAjUGAESVxeQlBNhrsPFQLIqCufFb; // 0x40
	public short iBWeYzDXeUpHNJXfgECfOIwdFzByA; // 0x42
	public short NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x44
	public short ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x46
	public int JlEcxFgAgCjwQqmOeNAqFRlgBGRMA; // 0x48
	public short bkKUQfuSMhlqAigowOvyNdPGrJmF; // 0x4C
	public short dlIVDRGEvVUFoSlAgprRdLPqgqDE; // 0x4E

	// Nested types
	internal struct sXYLFovlvLSPcFvjDhXVeNhoaMEX // TypeDefIndex: 53837
	{
		// Fields
		public int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		public Guid DYDgicVxAtJbyiHVjwCompuQFHss; // 0x04
		public int eACABbdNxPpsXrChQCGOcejnVKCoA; // 0x14
		public ZiNFfyMDyvFubBAcAJZJdlSkFDnK AlPILbxlBIGBViEEirdPjUsYLwGu; // 0x18
		public CyFASCppRXrIorhnlHrqucehWOo IVLQDeuZqJDUYRaiimtNHkMoXOwC; // 0x1C
		public char cJMYRUIePewENzlebCoKsxxPfeZBA; // 0x20
		private char dfhYjALDouUzonUlscwdYHnKMYAj; // 0x22
		private char ptRRgkJBiVBwPJlqxFIiBXrkTzXCA; // 0x24
		private char LrMSlAsviMkIvXYXrJPVydjWicKy; // 0x26
		private char NCRmwMmWtVNyXjqvimnCSUgmNsmJ; // 0x28
		private char ZplwAvEJPUCLJdJvyVnlZmXmTwUA; // 0x2A
		private char iJrOZbpxCopeGAsRPBlRfOEvAaEhA; // 0x2C
		private char hacyRMOYsdriSCKPwAaoXtDjewcGA; // 0x2E
		private char JvKqzLIxAaAablghLbVTYdtkkhwA; // 0x30
		private char VbCJrIXaWeLdwRuAKnHoIJDuEAueA; // 0x32
		private char JmmVcadvHJArbchLVLoiEPpPVyib; // 0x34
		private char VtvjxYNtLvsmKARREQQvVWtKjrbu; // 0x36
		private char SThokBjDtGZmxSnuOjREjRAMpgbe; // 0x38
		private char hTntjNAiSRcNfDvegpEPvvxBedtO; // 0x3A
		private char qXOaPXlVCrATbycZHAcHggZeCAMS; // 0x3C
		private char VUaqWjGYGZTtVEDIOpTxOzGSpSrS; // 0x3E
		private char ZeWfDASgVMTODXowRBNmAjuPVHU; // 0x40
		private char FDDIPtUciHIhNphPsKUhBAanAIxD; // 0x42
		private char yVGQSuHQpWAArNCPqumiSDtTghChA; // 0x44
		private char avFEJaGtfEsWorhnyvGobOpwfQsDb; // 0x46
		private char QOTmMCqSbeNcfwLkqgoUBmMsEQvC; // 0x48
		private char CvkzbZUTudRTkdwUxzykZUqQdvaH; // 0x4A
		private char azILfkERtmMjgVSBNaxfmwxjPtBD; // 0x4C
		private char xyvsjRuQHhzGRZRLhMBlWJzfGvoF; // 0x4E
		private char DmyfsuircgcQQwMvYKBXsBADhgSe; // 0x50
		private char OniWJkUehRxZZKGHHeErYLZBlUWi; // 0x52
		private char iIPvUjqXXYYjhpLOUxHCjuAkWHrb; // 0x54
		private char BUQxMPlYUWDlMSHviUQYTzoQNscj; // 0x56
		private char SHVLInTXHIlCZQZauRYTHPJvDsJw; // 0x58
		private char AyGapeeLauoueIcvsbQPhlxyJHnE; // 0x5A
		private char BglVOekgpaIPBfGwkrCDoxmyVmXgA; // 0x5C
		private char BvpMkIJgeYxEtKuubxMQwEgZfDFb; // 0x5E
		private char aIPxvNPRPsWjdBlGgbXJGCFElMXIA; // 0x60
		private char oQrZdnGhNATgCleBOcYgQyksahaE; // 0x62
		private char dvnbHVEvjWaUlEtrAQJKdZZmuMXGc; // 0x64
		private char mVaVblfHHeVsmVIghnbqVwhCWtXv; // 0x66
		private char lHihAKPoItQhektBMtDsJzvXiySD; // 0x68
		private char kLnoajnywIPeDCqhuZjCzFdZiFVy; // 0x6A
		private char JahhniGmjpjMMFsuBMvFWZYCiEcPb; // 0x6C
		private char CxmVElwccgaZQdBifbvjbkSXQCfCA; // 0x6E
		private char bgvqzjZuHgpAMKbARFCgNHAJjsfAA; // 0x70
		private char gvCCAGeVCmJoSpRAlVYwCSqEshBc; // 0x72
		private char qaMGkVhSCUvabKgbaXtuWAdejkWq; // 0x74
		private char EXjDnwgzLWTMEiRazxgMopvrFilQ; // 0x76
		private char QvaCtpZovASKjaqvcgPZnkTaOeKk; // 0x78
		private char UGfgSvqBqxCBiAsCEGIaayTckWbO; // 0x7A
		private char JAjHtxqCexeqmmwtkRXgwCZQDwVs; // 0x7C
		private char aVWWQXawHajdXrsMRsrpjEGhsbDF; // 0x7E
		private char ewjeIgCtgvNkkophubleeVzATVzfb; // 0x80
		private char HoYUAdhrIxLnkkajEifLoGxRaSDGA; // 0x82
		private char jJsNvcHAjENMeJnOMAKcXdUtVYdP; // 0x84
		private char dzvtVUZHBJeWhfVPjfrMcihdKNfIA; // 0x86
		private char MtTzXSeepjNaUuBELvGhDSWMRNJD; // 0x88
		private char txyYyInYwseJoJIeRldsohZOtlbM; // 0x8A
		private char mIHzapGtHOSrNQhOovMgbjkWwbPn; // 0x8C
		private char KoOsfmaxfFiDveZbGzebvyQvlhgE; // 0x8E
		private char ECEqoZTHWwGWPAbMzcELIpjEKQNdc; // 0x90
		private char RwTWNvCYbmGkSTmsPlxjWgvzOSKm; // 0x92
		private char PyrPpabhASSNWnQdzlGiprGtUfRh; // 0x94
		private char EbLHgpdNMNpQoOGzPLcQByAWLJpeA; // 0x96
		private char gsvHntFAXiQjeaOhwZYHTcgyuCaD; // 0x98
		private char HOIETelOjIeLjYthnAguUfzQiLmu; // 0x9A
		private char zETbQIeqFerFlLxWCnWcEwfExffQA; // 0x9C
		private char IZlPWdClnSGPkloyIDtttoddZzBb; // 0x9E
		private char oKNRLrlpHELGkfmgdaYKCdKdOqJN; // 0xA0
		private char FyzniALGuYEeSShdjDPdlIeQdmhT; // 0xA2
		private char jycFXNiUezntmDvcRLROuajmqUMXA; // 0xA4
		private char sZYzUirdRxgdeOiPrCvqtPzWXbru; // 0xA6
		private char OXbZgemeTbSFpLXERtIpumQuoPyK; // 0xA8
		private char NuzefzIyoCBAtRevUDXOaqnmfGnVA; // 0xAA
		private char TyEOohSWcCffzPhmmooQAgAwjBYe; // 0xAC
		private char ZrXzzGiHsGowJOYTwRRsnDhtGuCw; // 0xAE
		private char CWaTkwKXlYOglgctpEzToioXaWnv; // 0xB0
		private char MeAsnOdGgompvAzXqoPpfTdHaCwM; // 0xB2
		private char OkVbBwNnIphwPrzMZROOtkRyGqWFA; // 0xB4
		private char aoGSwWTmoNXobHYsVieHGdQQvMpd; // 0xB6
		private char UyaqjGSiUVNkgWHxcXyFmkOvUmix; // 0xB8
		private char KBJxvJfqbjlNKhTnIdjnJkhbJGdDA; // 0xBA
		private char NSMCiQBLsddWbmIUldfnbeCqoUSJA; // 0xBC
		private char HPrCtfRUrsPTNYgiweIsdeZhFIEp; // 0xBE
		private char IADUiGFIDTAyeQckFcNxCaDFigqn; // 0xC0
		private char sNCeQGAvKIwlMETmgEamAvDoWnbh; // 0xC2
		private char AVfFIUkPrjEeRQzhmZoXTLHpQGXo; // 0xC4
		private char ykAreNaOUznkJQkuwBnETbQOolnT; // 0xC6
		private char jrmYwPdJTkkkGicxWlcITthwTSmI; // 0xC8
		private char NXEVCiTPoZVKPGzXiThlPRxirvfW; // 0xCA
		private char sVmKfcGgnkbjPOmEZNqddqEIjnCy; // 0xCC
		private char tPYzaGnFKfKoEIFSdXjNVnZvnYrB; // 0xCE
		private char kQHKYdXyGTtjFoKxFERaccKNDPrW; // 0xD0
		private char jACgKuedeZnHxhTkQplczTCvfCfIb; // 0xD2
		private char QVvnCQjztsxVJayUQtTeBdzIfeXI; // 0xD4
		private char vrYtxFTlHlWFRKuDiQmlWMkabVKG; // 0xD6
		private char toUuOBvlZBCYCxqsIlaahmzuDpsFA; // 0xD8
		private char muJVZqxQBvmYqKpAARepmtNFOjsn; // 0xDA
		private char ZsFUaqnYPivGbOObrHFwjlZoslZq; // 0xDC
		private char LlBOlJIgKQHEeadOEdTscZTDNuMyB; // 0xDE
		private char kCrCyCgAqxZxqABUgxAkflrbBxjlA; // 0xE0
		private char mCPDFpPIEAAMEczLgLAhdDKlBNDh; // 0xE2
		private char iOZEaeHdXgvSznbNchImdSLHoEDnc; // 0xE4
		private char LUnKRNIhewcMnwjMOZlDAMEnfHrR; // 0xE6
		private char YUqkZpzqeOMsMukZYAPRcVaAjCbVA; // 0xE8
		private char YOpwXvLlJdnTDgYhqMshBaUmBsjAA; // 0xEA
		private char yKoSKazedGPGWPoWcfqycJaNymjOA; // 0xEC
		private char KiycMlpTMHpaszDmRZimHfUFjLFv; // 0xEE
		private char EpRXsJCYTtGMwyORsAPXmXCGJqrX; // 0xF0
		private char rGZwnlnwnhxyjTSnPqeTrglNKqsO; // 0xF2
		private char mqIjguxmYggLBLhWuqXVuZJpJhAx; // 0xF4
		private char uztoeyEUcJMpDMpddizuyJjvlScF; // 0xF6
		private char axnXlHKDJJCVUfNmJFlMiJaInQGLb; // 0xF8
		private char WzWEnWEpChuyVFiDmbXlgzxwxUPU; // 0xFA
		private char yFFBUinqeafbtHZOCbzIzlaUFFQGb; // 0xFC
		private char cUidOdQtmEhOqlxeenfKWRmTymjH; // 0xFE
		private char FZdCoxxUaHREkztkTsxlKuIDYZjb; // 0x100
		private char tjDMjCmXHyaerAzyRFZTHYSkatVL; // 0x102
		private char YpUNefkRIPEZUIYQstuKXGrqBicJ; // 0x104
		private char VHFAErAABBLfIlVZBjrFLfNFhGvk; // 0x106
		private char bPNYpQsRRZrpryJOKVGELmEVpUKf; // 0x108
		private char QwSvRIDIIUGSUCMNSqzoVutGZLePA; // 0x10A
		private char gKCHnZggdhYpJejvclWLBgxwhBpK; // 0x10C
		private char jvlqxmlTUUUfxlbKpvtECHydbgHk; // 0x10E
		private char UwnGXjeLsyGfWaZBExWleogdipqdb; // 0x110
		private char RNHBNcbvaUFJjpTuhbNXCzOHaVuoA; // 0x112
		private char QxRrSsoZhKUdxXnEdHhRJFCiDuGH; // 0x114
		private char tswzkSIrUaGGOEctdNuqxPiRGrlw; // 0x116
		private char GZQYGnXDuygFqsHsFFVdzFRNmuyO; // 0x118
		private char LdtduXsAbNnwRMrYUExQcptINfCy; // 0x11A
		private char jDSmnlBIKNpYNwEpBkaNdxzhiRd; // 0x11C
		private char ykqDbLHpCADctSRrujuYDLIcjGWLb; // 0x11E
		private char VehoFIZAMvbFUqtclfOtKalLqmTnA; // 0x120
		private char IOyQaUKbcsBBrDRNMdCBgbXAqAxVb; // 0x122
		private char XZkSUiktGGblcYzMTdLkoEIJQylK; // 0x124
		private char NmuenzAubxZKxCJpLRAiGoiBXoCg; // 0x126
		private char poamFuYrNlBmlZIlbdZtCinDjcCxA; // 0x128
		private char JsBQejkShugCjsIIFONQayZmHJZV; // 0x12A
		private char KcUTwuXdmMbcBPvBINGRZkXUIrCd; // 0x12C
		private char yfWYlLpuQrBOOasvKrUofvcTFije; // 0x12E
		private char ctpqvoGJekusDBiNXXPCKtwrmAxH; // 0x130
		private char vHWpxlcJOYJNGJOeBbjuQkiPEvyCA; // 0x132
		private char bggDunpGQwqupRpAZRkJQWkrwDzM; // 0x134
		private char pMIwikDojLvvuuzvNLwkEomFCaGN; // 0x136
		private char tnSFzwfBgcLswEfVbKRdZfdPUCqTb; // 0x138
		private char dydqYndKJWUVUPZmAHPDDltqBpmv; // 0x13A
		private char DjadXiAwXGbbAPBvGSofDbemMKDr; // 0x13C
		private char zyMougzopOBxbKHPughGaqZHYFWwA; // 0x13E
		private char fmyLHwSfKxVgsHXrHhVpyZGDHLOm; // 0x140
		private char VuVFxuamUEPdZaDdzEQaokdrcvuCb; // 0x142
		private char LdYnpJKlIycisItypOcWNMpSDrXr; // 0x144
		private char AoENcWeAHKKteKUmGVwpibzzvwqN; // 0x146
		private char XNVXuKCCnDECHadtnbjhdhdGvJUeA; // 0x148
		private char vNeyFUvCvDyqCHgCcwOyoDTBEiSs; // 0x14A
		private char TPLGWZbzfUHNjEZhkabHgctasmIs; // 0x14C
		private char uYHgidZQDPUNMzCCdOklTiqucaWA; // 0x14E
		private char lUOhTMJiXTqKjFOoOuTxSTZoDtWu; // 0x150
		private char YHnyrQbSPJLoqEneeprPbvsTtHXH; // 0x152
		private char ZzTqUvRsmMgradlDgWjkTJzjinpC; // 0x154
		private char eEbdXGsTNQYnUmoVLwcyJOUxSmDg; // 0x156
		private char LePmTCUxxOTWJtgtHstssaRFogUp; // 0x158
		private char HWDplxfLxaRtNuYPEMdMWVqDbCdw; // 0x15A
		private char OgAdItAlDRtCFRCKHoNoPpaUUbUbA; // 0x15C
		private char yLQezEKstBHGXvQzClYaDFMuDUVC; // 0x15E
		private char PsXEuWTmvYceaGLZQpebPTjfHBQGb; // 0x160
		private char FPmmDKxqzGaOZyKVwOOpxyNdRicg; // 0x162
		private char QBaUAVwEpGEFogFtncIhMJNQxiAMA; // 0x164
		private char CEnAEBAYMmfQclywjIhuAKRFpPKA; // 0x166
		private char UOVZJygFVWrRrYHdeAFWDxWtKSbb; // 0x168
		private char MKrCLzcCEFsuUGPyGCABpoAVILBbA; // 0x16A
		private char fNIcxriCbRjrYwAMPbkthCvbQxoec; // 0x16C
		private char XjhUoCQclGcMNcmeNAOaiTIISSrOc; // 0x16E
		private char yXAebgYeYBynovMhKDltAZwjmkxfA; // 0x170
		private char xmPFrQTXbYiGdFMzUXftgPKuMzeAA; // 0x172
		private char CAoSZiWLetZcZCfdWbsJLAnqDrin; // 0x174
		private char OctSGQhsCyZlimamICKHoAAFbdphA; // 0x176
		private char SJlHLYvPyzvaBokZIPHBgCLFDlCbA; // 0x178
		private char rhJlkQHfOkneVRgxKUMJYdydNGUH; // 0x17A
		private char tKIFdLYvcOMorfYiPQRNPyOzNeNV; // 0x17C
		private char FQYkukbWnKpLnYUXkzViNSLtDeQ; // 0x17E
		private char ymhnbZUetZCMOGqyAADAlOQkVMuh; // 0x180
		private char IwRxthXKIxIqcKKYCeXzITZiwowmA; // 0x182
		private char DLsBlBMwaELfEkASbYuvFwFDMqoj; // 0x184
		private char ebcykbJddpZUZfVyumnPJjxpIEhI; // 0x186
		private char vfUWSRcfQNFdFIriZcaZeoJMEecR; // 0x188
		private char FgJoDpLTbiBrnDgPHOkJVHgoGlTBA; // 0x18A
		private char eHgBjQjWNiLLUKegJNBxczXlKpAF; // 0x18C
		private char JMWJoNJqacIFXifNCInjbodEZbmSA; // 0x18E
		private char ZDeajlBTcthzjICldVfkeayceObEA; // 0x190
		private char AgQWNEqAggyZywaJQusUADEjvevf; // 0x192
		private char lIiYbKTHxWJBhISbyZoHXjaAmmmD; // 0x194
		private char qEGDpgjxFXAuLgeJroRMlJLTMnNB; // 0x196
		private char IppNNxFUulMXzOqwSGJYdkqggcP; // 0x198
		private char jUWUJICDqVFjuCVrKbptjAHuiSvfA; // 0x19A
		private char OrwvqgfkLAJRJpoWDmyAuQpAUZQH; // 0x19C
		private char BCfgmBLCJtWbqpHknKSijqgdvMPT; // 0x19E
		private char ZvyAgMmCfMgexWvhsWblMmITyAqn; // 0x1A0
		private char YuANuImylAmOzoCbYuGFFSUEDOYb; // 0x1A2
		private char DEcCfNXaeoYAzqDIoACeikmPPqmGb; // 0x1A4
		private char McJcbzegDNfotUhwFhfJYqShnvMfb; // 0x1A6
		private char HbHelIWXsJdnzEyTNXFVIJgBMmvib; // 0x1A8
		private char prCnJQSgHRhrUiPtCZXbAlbVeQeXA; // 0x1AA
		private char TarDvZgteHlbPlskELrrFrzCRwBsb; // 0x1AC
		private char gjQfQJhLqBhIQqwpWRRTlZpucPhPA; // 0x1AE
		private char GHSOcprVJdPbAcmkWPRybYkfMBbQ; // 0x1B0
		private char HOcnfsoIeqCjOcwIOOScVAIBwUMb; // 0x1B2
		private char ZNXSQzAeWQrlfLxGRaQwXZzORBuM; // 0x1B4
		private char CmVeSmVMMvdpqjcqYzJIyYrqlIeD; // 0x1B6
		private char FhsZwkgAzphpXJEYuGoVjCkCqfaQA; // 0x1B8
		private char qjfRUcjmCrofmMJdRdgbJDyjmtvHA; // 0x1BA
		private char jpGoLUcGttwtxkRGYePldHbIsMlX; // 0x1BC
		private char brBpNglEXIDYKKtbxkImaKqfCzeB; // 0x1BE
		private char JbqlvlBLWLjYQqWIiekgBbCmWLoU; // 0x1C0
		private char rkDmYDmWRjeFvwCjpZiqwumzdZnV; // 0x1C2
		private char JwJjSViKMLbJKjDOOARBiKeIbbdt; // 0x1C4
		private char TXFCoJIwGVTXPGXcWOPpTQRJdYRf; // 0x1C6
		private char ZTlhhaXNzrmcrjchszYQGvRGlkbX; // 0x1C8
		private char zAldWjGWhVBXmESqTMJPZQhuJOoNA; // 0x1CA
		private char JaSHKeUUnBCIDbYbKAlOEkKKOBvW; // 0x1CC
		private char vfoGIkeXowZdZVVZwxlEadrABFzfb; // 0x1CE
		private char EEyhfVQbSEAGWRVoQXWduHNxOgWh; // 0x1D0
		private char KmnzRTnipDWSouvectCdvvFtNXZe; // 0x1D2
		private char RRnegOGCMZhCkpcdDdWgsgxjkqvW; // 0x1D4
		private char QiCsCyRsQCJLtpbVjZrTLXfOHKol; // 0x1D6
		private char OHYcuhgXVTFTjGUEBfTnYqbLYrePA; // 0x1D8
		private char VRJGgofgowUgBLrIcNvEpSFqXORt; // 0x1DA
		private char RCDpRjhvmSHanngvMewcHwtbuHJo; // 0x1DC
		private char bLyxBPjklutNVMVcQjfmQglztBjn; // 0x1DE
		private char gPldqLXksJrcjrDcLjjjBdmhhSLzA; // 0x1E0
		private char MdelFbaDMWsvMfkQqrAIkgKiIlNt; // 0x1E2
		private char orxMmFImmLCWryagUsQsoxlPpIbV; // 0x1E4
		private char jIKWWLinmioZfYCmTpemCfZOhvLq; // 0x1E6
		private char tZvXLRrZVIJsjeGURHjeLSqhDcvfA; // 0x1E8
		private char ziqknguCAiEecpAXzaqYFwlIDgMHA; // 0x1EA
		private char pdVtnyZhlrlkITybwoTynamcKbGk; // 0x1EC
		private char SQgUgQhVnprXkBbippKvWzvMZISi; // 0x1EE
		private char MCNQrkxZWTCKdBpyilKLeljxPELS; // 0x1F0
		private char ITMgENqqwgaYXwXgmeRwaAVziYlH; // 0x1F2
		private char IeazXQZOOHIcTzbcndMGAhzbJfQCA; // 0x1F4
		private char AMaKRtDeSTWdzPSBHWJeKXiXrfcE; // 0x1F6
		private char gLfDcSJzLeJzQKfzaRZvWDJrIHNo; // 0x1F8
		private char mStbPOFKstCGHQihMUYjnFyTzMYI; // 0x1FA
		private char adAamMEHzllajfWfGnIqrPLMqkJbb; // 0x1FC
		private char PNNTePZCfjcVRopwGTgJjmfQjwlbA; // 0x1FE
		private char qxOlsyxIiDksGpEJoaTmdbUDOXwmA; // 0x200
		private char NUUmGXLJGADzNcJPoEezorigmtLX; // 0x202
		private char GACHRZEPWqRXCWKCBbEVzexnLmAO; // 0x204
		private char TiLWnRWkcCXQQFZFYMpVoEuDjeYf; // 0x206
		private char QqQNSSAYSefFgwEfylKsvjRfiJFl; // 0x208
		private char QtSAvAnuOhifCDdQTcGcLUGRbBJv; // 0x20A
		private char cUDVElIiOafikjnltIjFUbrumObib; // 0x20C
		private char GvhcbiFYXvMowIcUpTPMHdNbVMYV; // 0x20E
		private char EVmKIaEjiwDYaFUxuVqiwLthyDrjA; // 0x210
		private char vJoipaWIsAYRzdtVnrQQYdksGFxK; // 0x212
		private char nyroplshgxjawaxSrMBkyGkhDPtw; // 0x214
		private char mlNfkbKdjGpucDhzkxEpLJPVWxpCA; // 0x216
		private char tZNYMwyjpIOmgNzBdwhMFrXkggUh; // 0x218
		private char egWSdFfJyTckZCRMfaYADFxQIeWNA; // 0x21A
		private char HjVGInpKsDakCqfMCjfyeygmUEzm; // 0x21C
		private char AbNFHznlLBzgJkRAmsamFctTdOJCA; // 0x21E
		private char OlPilrfFZwgVCsZFeQpASPGJVTx; // 0x220
		private char QreFTGsyVgGpIFyurjNFMbtKBlCv; // 0x222
		private char NIUMOPoFiZFHurJijArrfKWLzbTnA; // 0x224
		private char LrQLFKuPDAMunxDWIJfoqSkZdajL; // 0x226
		public int OsBpaIRiKvssaqCwwRFpMNVbJbQh; // 0x228
		public int scZgJiovcLTbfUTBaTVQAgKBZhyw; // 0x22C
		public short LAjUGAESVxeQlBNhrsPFQLIqCufFb; // 0x230
		public short iBWeYzDXeUpHNJXfgECfOIwdFzByA; // 0x232
		public short NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x234
		public short ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x236
		public int JlEcxFgAgCjwQqmOeNAqFRlgBGRMA; // 0x238
		public short bkKUQfuSMhlqAigowOvyNdPGrJmF; // 0x23C
		public short dlIVDRGEvVUFoSlAgprRdLPqgqDE; // 0x23E
	}

	// Constructors
	public HcRHynaOJyRqcNcJqdaUjCNwaqErA(); // 0x0000000184DA8850-0x0000000184DA8860

	// Methods
	internal void BcaDDZeihMgRujTrJVazrAjsWLLU(ref sXYLFovlvLSPcFvjDhXVeNhoaMEX param_00073a29); // 0x000000018ABA6280-0x000000018ABA6338
}

internal class BxcPeTIqLZsfHyGzFAombgJBgOBgA : IXVoGLHTxMZOhmxUdMQSOueCZssK // TypeDefIndex: 53839
{
	// Properties
	public WBJKccxsRUtRJdmcyVziTsqftMNx IlcLYDpMHHjmkmnhEaMyOecSKJjG { set; } // 0x000000018ABA3D24-0x000000018ABA3D88
	public string HhWVFfmFttuBrivSKjzReDMOiLBBA { get; } // 0x000000018ABA3D88-0x000000018ABA3DE0 
	public int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; } // 0x000000018ABA3BF4-0x000000018ABA3C4C 
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB { get; } // 0x000000018ABA3B40-0x000000018ABA3B9C 
	public string LOikUxXJsvTgyuFJrAzLxiECoOlH { get; } // 0x000000018ABA3CD0-0x000000018ABA3D24 
	public EsYlVkTNpXweFHIzPgRHfxdCgmmRA rWfPOTkywVVLkhergznPfrOaXcQA { set; } // 0x000000018ABA3C6C-0x000000018ABA3CD0
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG { get; } // 0x000000018ABA3B9C-0x000000018ABA3BF4 

	// Constructors
	internal BxcPeTIqLZsfHyGzFAombgJBgOBgA(NinxpESAdWHMScogYtzEcrOKmWSq param_00073a2a); // 0x000000018ABA3C4C-0x000000018ABA3C6C
}

[Guid("bf798031-483a-4da2-aa99-5d64ed369700")]
internal class nmDUaUhbthOlhiDQJeKfGxYxeylPA : beaToZucjyOfmWGEnxdCGCgakptr // TypeDefIndex: 53842
{
	// Nested types
	private static class kbvKEgcMmfBBffrwpruAVhvtnuzD // TypeDefIndex: 53841
	{
		// Fields
		private static tMimMEtdyazRsphUXImMfGENsXXk xlBGlicniqyqVcDrynCdvCYuHFKD; // 0x00
		private static IntPtr syZVGlHruJsajzgfNAvSisXVBzoQA; // 0x08
		private static int fKLlmcGypGrqZthvjDiFnMYoYyhQ; // 0x10

		// Properties
		public static IntPtr ZuzLHeGGMPEKuocadCcrASTQesVzA { get; } // 0x000000018ABABB6C-0x000000018ABABBBC 

		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private unsafe delegate int tMimMEtdyazRsphUXImMfGENsXXk(void* deviceInstance, IntPtr data); // TypeDefIndex: 53840; 0x00000001815802E0-0x00000001815802F0

		// Constructors
		static kbvKEgcMmfBBffrwpruAVhvtnuzD(); // 0x000000018ABABBBC-0x000000018ABABC94

		// Methods
		public static int oVJgJJeEaimeBjSkJAJcNoqnwkSR(); // 0x000000018ABABCE8-0x000000018ABABD44
		public static void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018ABABC94-0x000000018ABABCE8
		[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(tMimMEtdyazRsphUXImMfGENsXXk))]
		private static unsafe int qIDEVMCaZpeqDADiaqyTpWBDgMPQA(void* param_00073a41, IntPtr param_00073a42); // 0x000000018ABABD44-0x000000018ABABD9C
	}

	// Constructors
	public nmDUaUhbthOlhiDQJeKfGxYxeylPA(); // 0x000000018ABAC080-0x000000018ABAC16C

	// Methods
	public IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> enWrmPEeSZfdoBIXgaeNFsgyFeVm(); // 0x000000018ABAC20C-0x000000018ABAC21C
	public IList<asJwVBrSeOWneGuTCmUUKaDTCXQW> enWrmPEeSZfdoBIXgaeNFsgyFeVm(CjUKMefScpzMvgjgiUiuzegeDMUm param_00073a2d, krgKPYTnLgdfAdFjoUESWSGAlErR param_00073a2e); // 0x000000018ABAC21C-0x000000018ABAC3C8
	public int vCJFJxrdRFOvytGXVnYrjkdwDObt(CjUKMefScpzMvgjgiUiuzegeDMUm param_00073a2f, krgKPYTnLgdfAdFjoUESWSGAlErR param_00073a30); // 0x000000018ABAC3C8-0x000000018ABAC480
	private static unsafe extern int dLepqwjgJnjtChZdwslOrnVNvgZl(void* param_00073a31, void* param_00073a32, void* param_00073a33, void* param_00073a34); // 0x000000018ABAC16C-0x000000018ABAC20C
	private static unsafe extern int RwOjAFglUQiUuBNhHgEgMjALXQvh(void* param_00073a35, int param_00073a36, void* param_00073a37, void* param_00073a38, int param_00073a39); // 0x000000018ABABEB0-0x000000018ABABF50
	internal void SnFdvdwiySLLSSiTHYYZjXHLHIjP(Guid param_00073a3a, out IntPtr param_00073a3b, beaToZucjyOfmWGEnxdCGCgakptr param_00073a3c); // 0x000000018ABABF50-0x000000018ABABFE4
	internal void UtKGIVDjczyGxgCHobkVhsfcudsub(int param_00073a3d, TrZygBjBOPxdNoLZDCUKGcceunIo param_00073a3e, IntPtr param_00073a3f, krgKPYTnLgdfAdFjoUESWSGAlErR param_00073a40); // 0x000000018ABABFE4-0x000000018ABAC080
}

internal class wuUsWJxKUExVGbjrtMTrHrrTkHbe // TypeDefIndex: 53844
{
	// Fields
	private readonly IntPtr lAcSoTmtafaUVffsOybRduUMmIYr; // 0x10
	private readonly SYhuNWxVfYmSkwZWMuEcrBLoLMGT xlBGlicniqyqVcDrynCdvCYuHFKD; // 0x18
	[CompilerGenerated]
	private List<asJwVBrSeOWneGuTCmUUKaDTCXQW> jBzjoZjRACtkMgdijVWGGaIhSqdWD; // 0x20

	// Properties
	public IntPtr flvVEFpgKucPjVdmvJHkUQNaTzAQ { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	public List<asJwVBrSeOWneGuTCmUUKaDTCXQW> MzPERRBOtszDGBDVIGlDTyZWLsQe { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int SYhuNWxVfYmSkwZWMuEcrBLoLMGT(void* deviceInstance, IntPtr data); // TypeDefIndex: 53843; 0x00000001815802E0-0x00000001815802F0

	// Constructors
	public wuUsWJxKUExVGbjrtMTrHrrTkHbe(); // 0x000000018ABAEA6C-0x000000018ABAEB58

	// Methods
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(SYhuNWxVfYmSkwZWMuEcrBLoLMGT))]
	private static unsafe int qIDEVMCaZpeqDADiaqyTpWBDgMPQA(void* param_00073a48, IntPtr param_00073a49); // 0x000000018ABAEB58-0x000000018ABAEC2C
}

internal class pAlgwGEUPtryjgsKQTmLqLcapLJfA // TypeDefIndex: 53846
{
	// Fields
	private readonly IntPtr lAcSoTmtafaUVffsOybRduUMmIYr; // 0x10
	private readonly eDsskVCpFwDNWJVmPNTIBKGClisQA xlBGlicniqyqVcDrynCdvCYuHFKD; // 0x18
	[CompilerGenerated]
	private List<HcRHynaOJyRqcNcJqdaUjCNwaqErA> eydGulGzjGCrVoBdVauMYRMNMFLr; // 0x20

	// Properties
	public IntPtr flvVEFpgKucPjVdmvJHkUQNaTzAQ { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	public List<HcRHynaOJyRqcNcJqdaUjCNwaqErA> zeaYchZeeNyczvMxtOgCNwpsetpu { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int eDsskVCpFwDNWJVmPNTIBKGClisQA(void* deviceInstance, IntPtr data); // TypeDefIndex: 53845; 0x00000001815802E0-0x00000001815802F0

	// Constructors
	public pAlgwGEUPtryjgsKQTmLqLcapLJfA(); // 0x000000018ABAC7A8-0x000000018ABAC894

	// Methods
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(eDsskVCpFwDNWJVmPNTIBKGClisQA))]
	private static unsafe int ruMcqlHhNVQqoKxDgpAFwBLBsbxVA(void* param_00073a4f, IntPtr param_00073a50); // 0x000000018ABAC894-0x000000018ABAC968
}

[Flags]
internal enum xyDAHdjbDRYaqEPZVCMNiWkIIuzcA // TypeDefIndex: 53847
{
	Exclusive = 1,
	NonExclusive = 2,
	Foreground = 4,
	Background = 8,
	NoWinKey = 16
}

internal enum ZSUAvntfLnoPvgBKYfVfuvtQblMGA // TypeDefIndex: 53848
{
	AbsoluteAxis = 1,
	RelativeAxis = 2
}

internal enum WBJKccxsRUtRJdmcyVziTsqftMNx // TypeDefIndex: 53849
{
	Absolute = 0,
	Relative = 1
}

internal enum CjUKMefScpzMvgjgiUiuzegeDMUm // TypeDefIndex: 53850
{
	All = 0,
	Device = 1,
	Pointer = 2,
	Keyboard = 3,
	GameControl = 4
}

[Flags]
internal enum krgKPYTnLgdfAdFjoUESWSGAlErR // TypeDefIndex: 53851
{
	AllDevices = 0,
	AttachedOnly = 1,
	ForceFeedback = 256,
	IncludeAliases = 65536,
	IncludePhantoms = 131072,
	IncludeHidden = 262144
}

[Flags]
internal enum BofDOjIlnPpdCKzkZiAcEniWwqDKA // TypeDefIndex: 53852
{
	Attached = 1,
	PolledDevice = 2,
	Emulated = 4,
	PolledDataFormat = 8,
	ForceFeedback = 256,
	ForwardFeedbackAttack = 512,
	ForceFeedbackDate = 1024,
	Saturation = 2048,
	PositiveNegativeCoeeficients = 4096,
	PositiveNegativeSaturation = 8192,
	DeadBand = 16384,
	StartDelay = 32768,
	Alias = 65536,
	Phantom = 131072,
	Hidden = 262144
}

[Flags]
internal enum poeujHXJKdgxzeFEVUBvUcmFtnlu // TypeDefIndex: 53853
{
	All = 0,
	RelativeAxis = 1,
	AbsoluteAxis = 2,
	Axis = 3,
	PushButton = 4,
	ToggleButton = 8,
	Button = 12,
	PointOfViewController = 16,
	Collection = 64,
	NoData = 128,
	AnyInstance = 16776960,
	ForceFeedbackActuator = 16777216,
	ForceFeedbackEffectTrigger = 33554432,
	VendorDefined = 67108864,
	Alias = 134217728,
	Output = 268435456,
	Optional = 2147483647
}

internal enum CyFASCppRXrIorhnlHrqucehWOo // TypeDefIndex: 53855
{
	ForceFeedbackActuator = 1,
	ForceFeedbackTrigger = 2,
	Position = 256,
	Velocity = 512,
	Acceleration = 768,
	Force = 1024,
	Mask = 3840,
	Polled = 32768,
	GuidIsUsage = 65536
}

internal enum gBJFzvCtfVRFnbuNFPcUrApHGRbld // TypeDefIndex: 53856
{
	Device = 0,
	Byoffset = 1,
	Byid = 2,
	Byusage = 3
}

internal static class YrKeajBlioTDbIZrSmDozcGIxEZH // TypeDefIndex: 53857
{
	// Methods
	public static void HKufRDnCLuWDDhREAOmBIYAaebUc(IntPtr param_00073a55, int param_00073a56, Guid param_00073a57, out IntPtr param_00073a58, beaToZucjyOfmWGEnxdCGCgakptr param_00073a59); // 0x000000018ABAA040-0x000000018ABAA0DC
	private static unsafe extern int VJLKbJKUcqgDWnApUjSUhfldDyeEb(void* param_00073a5a, int param_00073a5b, void* param_00073a5c, void* param_00073a5d, void* param_00073a5e); // 0x000000018ABAA0DC-0x000000018ABAA178
}

internal sealed class aVZjCUyfrUiieRCSvMhvPOLXIvNB // TypeDefIndex: 53858
{
	// Fields
	public static readonly IntPtr oDmajWmJdXkNRgeRAsNAnharcyDDA; // 0x00
	public static readonly IntPtr uWjyWjxFqUnThRLxATbMWZtZvqfd; // 0x08
	public static readonly IntPtr bxdbsBxQLIrQWfbCKOQlrWCcAMKE; // 0x10
	public static readonly IntPtr bxXFMeghaHjyDhGcDwgsjeRJFZQ; // 0x18
	public static readonly IntPtr uNCKSHPhmWpptqHBeODlUbyUaHSIA; // 0x20
	public static readonly IntPtr ROcHDVjpHdEYFNvZdGpNenttaQQLA; // 0x28
	public static readonly IntPtr OEyNmQQFocCZnvppSvjnoCoyXPWd; // 0x30
	public static readonly IntPtr YGVETsFhLxboCFsofoqZMkiNEbRQc; // 0x38
	public static readonly IntPtr VbIMUbrBBdLoebaZvGfviMgipGofb; // 0x40
	public static readonly IntPtr CUYEInlBmJzveAMVMWLJaCNTdLbCA; // 0x48
	public static readonly IntPtr JUAvPvsTjNRTkLfFhjlfzAOqwIug; // 0x50
	public static readonly IntPtr WGYzkKwjFKfBOAaByacsYQkfVYWbA; // 0x58
	public static readonly IntPtr CyInKzrBtDaZsigsSrNgUsoTwmicA; // 0x60
	public static readonly IntPtr bJcRbEtKTEnpsqfnUBQWLSKQtWzP; // 0x68
	public static readonly IntPtr rWfPOTkywVVLkhergznPfrOaXcQA; // 0x70
	public static readonly IntPtr VAVnGEnsLQshzpfCCtivYtEGpZHE; // 0x78
	public static readonly IntPtr QVYaYcmRbJimwebPrlFAUcMGuCRm; // 0x80
	public static readonly IntPtr lVKCqydhXxOZrGtzefzJFVNxlSbP; // 0x88
	public static readonly IntPtr qjryLebPObybimJtUAQoKPpcHnuD; // 0x90
	public static readonly IntPtr RAdTimOkRuPhcwvRyrBcdsSbqafR; // 0x98
	public static readonly IntPtr RssRxRHTKquToVlPRNoZiQaZKSNk; // 0xA0
	public static readonly IntPtr xlcBxYekHvgWIZEhZpOYBbRoILHO; // 0xA8
	public static readonly IntPtr UFcCwRuevlTBGKuWOdOCNlHMcYDBA; // 0xB0
	public static readonly IntPtr JMeoAlALCRWptBdpCeRVJsfsTVrEA; // 0xB8
	public static readonly IntPtr NttGkMgOjvZIHnlPQdBudxwAxfslb; // 0xC0

	// Constructors
	static aVZjCUyfrUiieRCSvMhvPOLXIvNB(); // 0x000000018ABAA884-0x000000018ABAAAEC
}

internal struct cgArPRymQOcpHGuUttHKOmZEDCfNA // TypeDefIndex: 53860
{
	// Fields
	public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
	public Guid XHhgJeGYHmzzJaEwygcmumuXuuvF; // 0x10
	public string uHVFxYdqpgjkdgNAHnKeGPzZhuZpb; // 0x20

	// Nested types
	internal struct IxQHsEdrJUMoitelnVClfEnMbawIA // TypeDefIndex: 53859
	{
		// Fields
		public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
		public Guid XHhgJeGYHmzzJaEwygcmumuXuuvF; // 0x10
		public char uHVFxYdqpgjkdgNAHnKeGPzZhuZpb; // 0x20
		private char NXMbtNhEvQOLyNKCcIfcbLIFHHsI; // 0x22
		private char vATKFXaqgzXMuVONAbddsLBqlYTr; // 0x24
		private char exeESFDFqxgsJmmmuasPBjDxKZDzA; // 0x26
		private char YkbBTSZmMeczxetaZcmeifNXfZuq; // 0x28
		private char bQNAAvvKajAUCIyLEaGyymfSpVBO; // 0x2A
		private char fVTwQmAjJShVbHDgJnzwTZJdtzYV; // 0x2C
		private char SlKbMTElQRKWlaPqNvQxmMyPocuK; // 0x2E
		private char QWsHWvKaFNfwizaTfIUihuCpPTSC; // 0x30
		private char cUzBpEgKqvmNHakJPuGZpUakfhRE; // 0x32
		private char ovQxsZfagigRUmGzlEYNnwFSEgx; // 0x34
		private char BFpdAfHsxDbxmRUjTAoINntfCtRD; // 0x36
		private char JPuxNoROscRPtWgcnCfrPcIkhowJA; // 0x38
		private char rfFhnGNTUrNWqWhxweVDzjcwPHIe; // 0x3A
		private char BeNDQRXiagpNUlLgxQBwcFDMsArh; // 0x3C
		private char nPsQXXwPIuKglbWAyTWwczbSKRCU; // 0x3E
		private char NIlEPFTjLaULiQihVGPnskDIfezf; // 0x40
		private char qyilIOJpHAhQahjNIDMHuJvfWaWC; // 0x42
		private char JZCmVkQNEHteWyTXPZsZpakJjGlG; // 0x44
		private char ZQMFshkrJETuXsyvtCLnKoyfWxE; // 0x46
		private char cnqxgmiHRfFhzDQvobpHvZnwbcWE; // 0x48
		private char vJNJPuibaIeUagWYofzqDfEOjBwHA; // 0x4A
		private char jQZSoQJFqqETznKygIfxAsluxLIA; // 0x4C
		private char kFdquBrdFbUuOwNOtKiWvczuJBCv; // 0x4E
		private char RpBTujcogrHvpgzJgNwXGkmdOtjCA; // 0x50
		private char wsiVeJNCtnikmahjiXcgYQWtysYh; // 0x52
		private char GhicMaZlWwyqWJWNrgMLDBtPWgox; // 0x54
		private char YvHBcmTrqswWUyyXlqHmHfFdCOiM; // 0x56
		private char wfwbxjaYFHYeyleQzniPFGCRORMe; // 0x58
		private char lzqgHMDGXMikvIaKIlEShyNeozxSc; // 0x5A
		private char PTzFnwOWZuoFiUoHsvOUnRotIHan; // 0x5C
		private char jAJbPBiQUUkImhkvOnNCdlqSjILJ; // 0x5E
		private char dhbxWhsQwXWuHNiClcniqSHFJGWv; // 0x60
		private char AdEWjCtbkBgahwVTNxEudSrZUeis; // 0x62
		private char WZkvdmpjpuFujFJjSxhcLpBfxvvZ; // 0x64
		private char nxRVJEIFPcDGozEdtHjWkJyoVHPsA; // 0x66
		private char qnfkVjEtqSWXwZplkgIlmmPHYeDQ; // 0x68
		private char mFybCiHkXQKEoFiXDiItUwBQGkYPB; // 0x6A
		private char vwbqdKkdXhVfQUHXzFWSGrBGoYSvA; // 0x6C
		private char fZqdsiJWOqrpWNxvTOUOrkOSKrWk; // 0x6E
		private char CcOiuBHXsdgGyWfdTiHszfWMLZFX; // 0x70
		private char WFdhgOCIaVmKmrrDdamRXlZhQqHU; // 0x72
		private char JhvePEPNheeutxoGEzdqKPnXZLwu; // 0x74
		private char AYLojUCjJgGmOdYEVIckvYmNYTDQA; // 0x76
		private char LqacUoIujhkFqlHIymDoHLaqTDtg; // 0x78
		private char WsoECAGDtGvYzeAVzFJJaZwOTwFFb; // 0x7A
		private char FSnUqXyfIXuTZzpJztwLATEpfcIn; // 0x7C
		private char hIJtiOaPCWkhQTEqELjEOQbpUNcd; // 0x7E
		private char cgtfIGNboBmWONrRFWKaNXnWLrIR; // 0x80
		private char JUNsPBGzbioVRTWvzHWXbUFujFOh; // 0x82
		private char cDrsfZuXiskNWVfUwWzfAbgoNVUh; // 0x84
		private char wlUiCzjvaVKcIJBiLmJDkPHovVxq; // 0x86
		private char UbBVJlWmiVVAtJBbrdSsYAzWwgYK; // 0x88
		private char qYFCKJhqvpWSvxCOZimtCJgIWOVkA; // 0x8A
		private char OyGsMEwwwcoNFMHZzIKdnXnilNHu; // 0x8C
		private char FZdADpwqwTDpKsufCOAGLAPvxVFc; // 0x8E
		private char HdGMUjDgEyRuGuchXGkpQZxtGWkN; // 0x90
		private char PjeqmPGVAGKLrkJpKsbkHPJWrMAC; // 0x92
		private char yhDFaebNUwvSbEhZqhtCRXcZKGEl; // 0x94
		private char qPJeApMPccWvGEFQQSlsPqKopEBK; // 0x96
		private char vOqqAdGvePthzcmlHAzKhOhAxrlCA; // 0x98
		private char gsqlssAwlKbTYdjXBUlphduGpead; // 0x9A
		private char vaHZoyVptGUiGHcADzbjpqGkWChP; // 0x9C
		private char soCphLYvZdApjUhxAwcEAnNzEVMo; // 0x9E
		private char VkjCyJtGSjWtBFiiBcUgrhuTTulK; // 0xA0
		private char MbtAEVmsdqYchPqjFrjmMmhttFNN; // 0xA2
		private char ftKjifGhhfBqOxbUSftJFRTzsfSJ; // 0xA4
		private char UxVZIMjaZyISoTjajrUIFTwzptOy; // 0xA6
		private char OxRrDKNHSKjTdfZRwMvXfKhyhLvjA; // 0xA8
		private char ghSGWRrBPXMiIiEapstbLNLgXoGA; // 0xAA
		private char smyXTvGZyLEVHRLSBROrtnEbaptQ; // 0xAC
		private char pNjsvKnnOycLiiRTzOobNaDRNcZaA; // 0xAE
		private char JXZgpuwhnPUxJvsDaAyXTyGpaKF; // 0xB0
		private char ZVCFswpsthpNbYkxQUbCTseZzjcV; // 0xB2
		private char ugnhZyqaSDKjFsuGGUqUVHvBnPwj; // 0xB4
		private char gXnyDqrxDsmOGcfASSKPHZlaHDqp; // 0xB6
		private char bfOGXqmfVcWSUppfoFXBBgeUtkKkA; // 0xB8
		private char ImXciYqWjnARssPBQdaAIHdMqomj; // 0xBA
		private char kHUnmtmjJxNZzkmSyVVMAHwqhndA; // 0xBC
		private char suyUVYXJEAdMkkfFLDlZoOdajJdLA; // 0xBE
		private char YyiEKpPpQVKoCesqvJTZMFsqrmbm; // 0xC0
		private char NGtYApuyOznABGBsTTgBuAoywDrp; // 0xC2
		private char GsCjyGGspqtGxEFCbwMNeRHnSqVn; // 0xC4
		private char HhfbKSkqqYXJObKwIbqybbDRAaycA; // 0xC6
		private char IBhaEbCZhSmjUDYNHSeRMpVtyOrrA; // 0xC8
		private char epsmpNBMItHMpenjbLEnBKNaPGCyb; // 0xCA
		private char ESMJwTGaZyNNvADpKCRcavsvupoJ; // 0xCC
		private char rCvBOhchhsabZUGTFvBRJsEcYoAwA; // 0xCE
		private char wonGCvKfprEmPnzdFUdJeWkrEyDc; // 0xD0
		private char DPdncjJwDBFidJIUEFxqPjiqSfbT; // 0xD2
		private char nuxezGYLkttjKqdBoRJaOgSAetSO; // 0xD4
		private char DjJmeSfqLScATOjgDAQnjgZBvigOA; // 0xD6
		private char VQEavpDnXMnJZjeZnjXndsjllwLV; // 0xD8
		private char BgIwbWjDODypQrkVMWPpXGuoAWRc; // 0xDA
		private char yriGrgTliQtuoaGYyPtWciJyAEBi; // 0xDC
		private char wzJEudmmkzktASgjmdyaNcvQSuEY; // 0xDE
		private char cDytRWFkuHlZtqdETcnPqaUqBhYG; // 0xE0
		private char ptsmuyXwabcWKABvpsWwzmCwGthj; // 0xE2
		private char cOPaJqFKyhOQAVgVNteBmzsyJhhw; // 0xE4
		private char QVtnNIDQhVtesMHwbbFyniyiuGSG; // 0xE6
		private char iGnvraVDqCFuiCKDlungRrfFGfnfb; // 0xE8
		private char XzdaypfQunBoSEfZgSfDZNIRuLMu; // 0xEA
		private char FqRBdbaNaBqFhHZSkXgmnLQjUdrN; // 0xEC
		private char qQzVTKZzYCjcCILHvntVNcHZxkit; // 0xEE
		private char SkZfZnHsgwjCSqlArjTsJReRIVPdb; // 0xF0
		private char NYxeDAkuWXZdPWoDGnehgbXLLwAnA; // 0xF2
		private char BlamatPBBACdaZAUmcmBaiCOWptg; // 0xF4
		private char WBadxiJpQZHHNtbIOwGzoHngJaXJ; // 0xF6
		private char iDMrufBaqYsRcudtyjGixhzfoaEI; // 0xF8
		private char MehTABxMVKyrojwsTHbEBbjtcaBu; // 0xFA
		private char MtupSQpAYVEJRkJGWQNzpnCQkkYPA; // 0xFC
		private char LaSBhRYoNkDMOjksnAfthiCAhQeib; // 0xFE
		private char TNKYPGxGwVDMhmcqAdWazzUedIXx; // 0x100
		private char eKNXLgMkgJpsxKjYqCSNfqpFKhDQ; // 0x102
		private char REZFKlGDaQrOgsnPISjYRDAqIdMqA; // 0x104
		private char FOZtufNuDYUrBRygBPAXEELopGP; // 0x106
		private char BPMZQgtcXXxptXNgBaDDfuipeKPe; // 0x108
		private char JSZWvjkLNwtauaJgmggBKhQEDJEX; // 0x10A
		private char QLgzMftJzWIDRARwleRepTLUAWSq; // 0x10C
		private char gGaVhXALAnxKaFIUfnpmFYGjNBZL; // 0x10E
		private char jRxbSrkcrKDFgmDvDioYatDcWLzZA; // 0x110
		private char GbiCXfuXOAVAeTWyjsUkwkJvwWhv; // 0x112
		private char obgfhSKUVZcfhQSkAacetWTxdvbOA; // 0x114
		private char YqrByNwSzHsHmXTVZtJGxjjeLATB; // 0x116
		private char WXTrUiDvoSaODkTKLIWfrhbglqQm; // 0x118
		private char BEZHYAcmSsrDVSTHxnNxHsAdoFxsA; // 0x11A
		private char PgLzZSvwhejdfePRvZLlzMFAsgZb; // 0x11C
		private char MWyiDWQdazBxIPkJItxEWRqcdvJs; // 0x11E
		private char cBNCJaAKfoQkInSqJRGRYsSYmtoE; // 0x120
		private char pkcVpbXBjGItSaNMSwUQPwyRDGZT; // 0x122
		private char unZnUFZTdytMhZcyGBtmrFhizYIK; // 0x124
		private char OypWfCwJeSandRnTmnkmunzZaHGu; // 0x126
		private char PTZUcpibyqGXMaNCLxHahvvkNWrGb; // 0x128
		private char xkjpIouStNcYOKZfMEtImbMxsGWs; // 0x12A
		private char EyStAJkOLwHIIXtqYjcYJRBsXGRi; // 0x12C
		private char cVSjlsxLsCLKdiLfcrGgAPGZaFui; // 0x12E
		private char pTRBzscFHQewXOzhODPKmHZiUzIn; // 0x130
		private char VXoRLseKHUvrQiwVluSdYwZzLUZu; // 0x132
		private char oTHUTOgeGCeMawTarEntgfsqaAqz; // 0x134
		private char thkhEwEiTAbyWFUjOjDYiQlknemnB; // 0x136
		private char hVjiizUfoHYgCEPvxmhklNQDdGgKA; // 0x138
		private char TAWahuyuJFtBeyUpZzZPyvMMAtle; // 0x13A
		private char JoVDNdJXZGEjmhiKJkuCLRiWqenEA; // 0x13C
		private char atlMJwkgpXfPRthbXLJSHNaFUInQ; // 0x13E
		private char QOkiYxTzrLmOIdYkCFYGbsiuwgnN; // 0x140
		private char kZRKBVKZsGbeGRlQHldguoElXOyH; // 0x142
		private char VJUwBNyoircyjGegoqyKSzaUAnFpA; // 0x144
		private char GgWGaLufTuXQLjGuvHMHCiQxqLQO; // 0x146
		private char FvQlOUBmPKCLYeRhmMooametHMOq; // 0x148
		private char cxBqdwmlMToGlrJbLxmTNDsdGBcN; // 0x14A
		private char kVaNWZXOseSDrqBCTdLdCNQuizAmA; // 0x14C
		private char gxoadPxSHbnLwxTzLmieXlqMPfCu; // 0x14E
		private char xjfQelPuzSxCSKrGpyqvPhZaNeqj; // 0x150
		private char iJQbPdgVubftqZhJxbWEbPKaipOTA; // 0x152
		private char izZpawCQPxMMMaaWyFcobmZRETdAb; // 0x154
		private char ocmkXlSFWZFpIJzdQLnaIbhmuyoQ; // 0x156
		private char mRZgawXjINYeUUfPTQxidUSDtEad; // 0x158
		private char wPmmyNjUTNikJLcpObGGEFpLnnYjA; // 0x15A
		private char DhKDzJAgoVbRcPMWLrKKSggfUhekA; // 0x15C
		private char pwtGNoKZkUFUSkDPbNlZEGjfPOWiB; // 0x15E
		private char OMsiYOcwYsNLHbEcKOliZJofjxRK; // 0x160
		private char jZrJtDiQGVBtWMFsQXyDNzIBGNXr; // 0x162
		private char ENrIRALahGvBpZaATVMdIjYvhBDY; // 0x164
		private char OOCCCFfhMpyjBTNepWnYdaXwPqoLA; // 0x166
		private char gPIfSMwsoaBUackuZaLOFCFfgzwdA; // 0x168
		private char zglQxWVxpWruiBQoIQrdcSiGyGHP; // 0x16A
		private char NVKNpwVoNvzPcIVOBqhyOsDxmWhG; // 0x16C
		private char gFDxFFKRTXAdpeinCiwEbPGCJjfgb; // 0x16E
		private char tDYaltjlxgkRYGBgDdNHATcSiczJA; // 0x170
		private char IcPKfYDiagVzMSBaHEXsMGkjzFep; // 0x172
		private char TgccwUBbfPwQASwQGlSwjoNGvBve; // 0x174
		private char muzpExRFFWpEuhCxveFoSOxSnIix; // 0x176
		private char rLeKbapKiFfiLAAbldnNJxxuxfwv; // 0x178
		private char hwSINeAQBWnyGDdPiapEZxoXWbVd; // 0x17A
		private char DUDlhLUgHSpjqecPRJYuTQfrVGOw; // 0x17C
		private char YrUVsLTgvMgkvHxoDvAWQxHQvBOg; // 0x17E
		private char WSTPRundpQfjawFQRdOyvdivnYWn; // 0x180
		private char tRDAFearyyXoothpiAihjPkPcOgcA; // 0x182
		private char EKkErlqitPmpwDCTZaJGSlsuKTSw; // 0x184
		private char HTrsHEDGrWoEZNYwtmQDJkBqHCUjA; // 0x186
		private char datlfPJfAlePBzLCfFuEYzmBxnCy; // 0x188
		private char WpefLnzJyfAFuyIqJBDoytwveUPQ; // 0x18A
		private char LXmyfSoApKKNjTgcRiIYEHWpMewE; // 0x18C
		private char SynSEQToMENfXkdUHJPrRGMwINuEA; // 0x18E
		private char OChvTPwKvqrJsKfwREGwiIJVOrsb; // 0x190
		private char HCVeHJpgDPEvtdWtqIUgAEhzinHxA; // 0x192
		private char ytQBlgXKGJkHjapgnPeTdrhVDgqH; // 0x194
		private char xueEfLECRhfCRltjTIpRzcvGNBLJ; // 0x196
		private char lKagSsjkLRjPpTBfSmIAkJQpJsRCb; // 0x198
		private char rfQGgTwktZbLhBYLiOThDnvzJNejb; // 0x19A
		private char TNkhYdylYPwmARUHOovCkNsodcel; // 0x19C
		private char wiKYtnphENTChTQdWhkmjKYwnWZ; // 0x19E
		private char TXeLcMZKCGNkAYdBIDXXjIMdTOHr; // 0x1A0
		private char CpWNlDuVCjGHuYZTSJnHiAjVTXrA; // 0x1A2
		private char pmEEDdKNPxcpNdMjcQLMUQgFzQlLB; // 0x1A4
		private char rUmmwaJPPRNjTeZUHcAXYFLtPpGR; // 0x1A6
		private char QCIegeIDnriNpkHdrjAFfnrFkYVU; // 0x1A8
		private char qUtyEuBotRcqERmdOQmNFHfFiKiD; // 0x1AA
		private char wPYpTvHYFEvkLFpwkjshLInnGSJ; // 0x1AC
		private char YnOcpCDktidYvxaeBNSjzumHNhWM; // 0x1AE
		private char VZItAIbgzHoqXCcprXnhWFtjEXQC; // 0x1B0
		private char sjpDjVkOHBeafpwRyopJkzAcIzBX; // 0x1B2
		private char KsjjNBupalEQpfWfLAaiYADTzzJF; // 0x1B4
		private char JenYcqgaMEEYwUVHdSdeGPqRqNhi; // 0x1B6
		private char xhbKKPbgqtfcXEzvuJoxbSuIuxXv; // 0x1B8
		private char yfFooajaVgidxPYWmRyKJUZvEXMi; // 0x1BA
		private char RfwLkXMMMtkCCRBQuYlCmdRyCuHfA; // 0x1BC
		private char ZPiMJuMVARQODmZCQwTYeBsklFEx; // 0x1BE
		private char jHVSxsRmneYkLFOHTqwHcDZGDEiE; // 0x1C0
		private char pyGeUrcJkKZwOzVGmJAcpdEcdavD; // 0x1C2
		private char WjqgDGvKtbAZOQFgkICOQXybOEEL; // 0x1C4
		private char DnYSwfSmPIDtUWuIoMnQxHHotKNe; // 0x1C6
		private char iBrRljlATaCtCKkcZbLNkVnjcAKk; // 0x1C8
		private char TBjIYOxXilAsoijkGERmBJwaBbJDb; // 0x1CA
		private char djGGDvUaJybpjItrkopxVHJQfyhlA; // 0x1CC
		private char gTBQqAJiUJMfiVIuEEtGyVcPlime; // 0x1CE
		private char NITaemcFHiWHqcOElUAHBcnQIxUK; // 0x1D0
		private char CPkSdmQVblwOfHMLcFUPYukTgYieA; // 0x1D2
		private char cVBaZdfHbIbJQIDZwfUpZZZUvoeA; // 0x1D4
		private char hFCowcSFMXkndgdrnnBkJXIuIDOB; // 0x1D6
		private char FZiARBBWtrhVtQsguhFYVtlrPxCUA; // 0x1D8
		private char BkBjpUnSJyWzjrXRjZXEOmLuMHdB; // 0x1DA
		private char hKOVyBMQbfoyCKAfkOxXgajCvDFc; // 0x1DC
		private char VFKjhpHVGojCkCFDFzQuIZqACYUEb; // 0x1DE
		private char gDrcVQsvnJcayVaOGddiPNddqQtN; // 0x1E0
		private char FUWAjZwgeNgXMbwtQrqHbJJgAsmBA; // 0x1E2
		private char wdmdwwCNTOiDFhOsbpDtnCIGDyHsD; // 0x1E4
		private char dvQdOSySiCoNTKawHIZQuGuKtVnT; // 0x1E6
		private char JZOhGZaaDTZJBrHIGBMvGoXpHAZjA; // 0x1E8
		private char WBbegUGQwcnARjSkjPFaxwucZAvNA; // 0x1EA
		private char JkLtieuCColpxxgXTFSPFYwXNUxn; // 0x1EC
		private char dsKFluTQNwPMETjSefGNMLwPoBwV; // 0x1EE
		private char JvVxusYMUgAdXHHJmVMTfYusfhLIA; // 0x1F0
		private char KobPxuIToNxKmpMHQVMisiqhLOfC; // 0x1F2
		private char BPBQZBkDkuGZcApCNQyidtKveElk; // 0x1F4
		private char RaoeDPgGjeFVhcNnIbSCibxmaUKdb; // 0x1F6
		private char kPJNBHAYSWTBitCJcdYuRMEjpTMp; // 0x1F8
		private char mSnNkrleDBVpClGTOMBoydiVJNOU; // 0x1FA
		private char WlZhLBgiDUIgCwNECcQjmhZrAOQaA; // 0x1FC
		private char UdkgiWHTSYDbqBmnDpKogqtImEqHA; // 0x1FE
		private char BIINXCyoQPmZdUrSfiRuMpebakkq; // 0x200
		private char buvFGBmtvbMWXyCkPGJpwRQKTclp; // 0x202
		private char tCKaircdFmoAuwgrTNWxjKswitgCA; // 0x204
		private char swrGOLdduqNiwoogZJtuynLfIAWi; // 0x206
		private char KOIaJTAGuhDDdvEThuCTkIgcDexe; // 0x208
		private char VzbfJtFMKChUVICptBEOBvWjdwGrA; // 0x20A
		private char AvQMrxrilJdFOemwndjPsSNsAEdab; // 0x20C
		private char ConQJFaAQBxLYLBhTbpRLxvVIXaF; // 0x20E
		private char BkNyZWzIPFqPXOZGleYnOnbJzruD; // 0x210
		private char yVVdBsjMyEJcEWlZcRjpErBiVvWT; // 0x212
		private char BYMObNykdJuWujhHtwWQtNnfwkCV; // 0x214
		private char OzIKjeNIxYzhdkuSIZTRtIYNAlX; // 0x216
		private char AoQnpjnEQpqrtaQNnVZzsPjkJqbF; // 0x218
		private char jcbSTazTRHqTQdhzwFRXeuNAMhbHA; // 0x21A
		private char ydWgUobmHdjxojaQVbaZqOLWpLANA; // 0x21C
		private char ioWBxoRIECFBETRUBNuDggtMCgiU; // 0x21E
		private char zYPKcFxskmAPGCLFWdpheCtBcPxPB; // 0x220
		private char EUToxLKfMdlWIcMdpbzabZgOetI; // 0x222
		private char wiCdVBYsKwUbrEEXtSdWhHlDHkid; // 0x224
		private char vjlbVflewggMsgMbhilhtTCDewkLA; // 0x226
	}

	// Methods
	internal void BcaDDZeihMgRujTrJVazrAjsWLLU(ref IxQHsEdrJUMoitelnVClfEnMbawIA param_00073a5f); // 0x000000018ABB8A94-0x000000018ABB8AD0
}

internal struct kkodSjjyHKxXmuuzDWPlSRhmRILR // TypeDefIndex: 53861
{
	// Fields
	internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
	public int UoJRrfSQsyDnlUhRsiydVJBzQoIi; // 0x04
	public int xAPJujqyYeGNWmIWAbauOkiuNlWL; // 0x08
	public gBJFzvCtfVRFnbuNFPcUrApHGRbld SPvkVDDQKebsselcJZJzSqGLscPR; // 0x0C
}

internal struct fcRAIOWwGfwZOjORFTyrSbXkUTyd // TypeDefIndex: 53862
{
	// Fields
	public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
	public int thLICHPmpalmfjGmuMkilAKwymgl; // 0x10
}

internal struct QvWbleffChmRFEWHpvLtcEfemOHPc // TypeDefIndex: 53863
{
	// Fields
	public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
	public int noqySfrMPKQOLUdUcoEmCuTfljsN; // 0x10
	public int iKBRPdrdnIJiibACgpcKoJPBTfmg; // 0x14
}

internal struct pCGksMnYbcBiSLcNpaGiTypRAZyi // TypeDefIndex: 53865
{
	// Fields
	public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
	public string ynhuhpTbOaCIKUkjGeRHUWijjFkKA; // 0x10

	// Nested types
	internal struct EaVrxzQFCTeFlgOvlCOXVfDNHkVI // TypeDefIndex: 53864
	{
		// Fields
		public kkodSjjyHKxXmuuzDWPlSRhmRILR fGbkjxXruFaPdjIKRcGRbabwnxrUA; // 0x00
		public char ynhuhpTbOaCIKUkjGeRHUWijjFkKA; // 0x10
		private char koaeGimkkzajwEnlMXkgeMETbOPf; // 0x12
		private char JLjhFsxOkiqbprNNwQrxmVGAwJbS; // 0x14
		private char kXmsQbyKcsHBgROUAHEhDnmZmpfC; // 0x16
		private char LyVpHxNbBoiZdHYFMxZxApAZqwWnA; // 0x18
		private char sQrqpeMPMWJNJkPNAlNoRFqYYHNG; // 0x1A
		private char bjhbSoaXmoSokBzTpzLnOuUmDCKGA; // 0x1C
		private char JQFBGhJeeBsPKBQOMQRImgagotwAA; // 0x1E
		private char CKaJEmHOUoYGUzfHDNejbIDAIMFKA; // 0x20
		private char pbiBHxQwLxgsQndAQUfWOkPMZbiG; // 0x22
		private char mNrXcLcDQmiRYRzXNztuTgIhjiJu; // 0x24
		private char AgpIOrlPuQjXGhkswjemBHCZTwoB; // 0x26
		private char LcxtPzYupSHFePlAjvmrktTDzrDL; // 0x28
		private char jFfPSWdnfGCTKJMRRkKstMtNdFSab; // 0x2A
		private char QaTzzxhgIXrBsyqmxVSNiyNvvJFM; // 0x2C
		private char FsCmKTHBJUeDphsOsZcdqkxzWmxrA; // 0x2E
		private char aBUcdibyXpBHDPRdBBHdqoZtayug; // 0x30
		private char NMhpZGUHJYSQPOgsInsTQXbPJkXD; // 0x32
		private char EOsdlWaTfIzfyfBjZmoNusosdeTV; // 0x34
		private char oJDNvDahSIwpjqsIBKgFhBkBHFHM; // 0x36
		private char TsDANdArLOGHeADBZcFDIhPrBOwc; // 0x38
		private char OMfngdGzBYBiPjsiMBrRkldMCjphA; // 0x3A
		private char YCLhXZpJGWZjWeIhTjZIXMsLgyRY; // 0x3C
		private char cfrerULgookcozvkaPkQBomTfnYS; // 0x3E
		private char mIiHTbtuIKBtLVdLZqyyfGSrrqnp; // 0x40
		private char PSTlDBMguYhaPibZOCkNbWemZvjoA; // 0x42
		private char NwoMZIRIBrodQJGdGUalJuqyssQo; // 0x44
		private char eEIARBnbZMqCVSwdvUAixMqEAMsE; // 0x46
		private char RKdxyuGIgjfCIvsXNRTtjMRIPqyJ; // 0x48
		private char VyAhKdHQnRZtysTvtzgHCiMgGvhqA; // 0x4A
		private char hKKlbcJXoEILCWzBiBsMXOVpHizx; // 0x4C
		private char ZWgyvzYgmmzqfWMPekMVAQPBjSPv; // 0x4E
		private char ENHgtzvQVNLDZAkqkNrDeoUjgxWG; // 0x50
		private char HNyoNtyqClgPCyGSBJcptmhreRygA; // 0x52
		private char fRnXpyVGgZDxSVYUBmWsKcikBCsK; // 0x54
		private char dVrRYvKNwFCgwGYspgfwdxcbRfZm; // 0x56
		private char mwAJpuTkauVEQqtUzCGZjRdMDfJl; // 0x58
		private char hxVjFRXeBhnfeYmDbSvwXdbOjjCH; // 0x5A
		private char gQPDFkKmJBmQsZdKObsnPHKjEPit; // 0x5C
		private char yAAfKlKZtJoIbiHNrSIecmLxNdIZ; // 0x5E
		private char CTGPIucLQTgVleMqAMuUuKjCmFo; // 0x60
		private char NVkqPWSApaclivyacPvwRuLxPmlA; // 0x62
		private char AsKVjLBPCieDWQZMkwSPacCcpDHX; // 0x64
		private char CvHAQMhBEGwWsoUJybzFShwPPUAN; // 0x66
		private char rwcVppzovpHYieROsoqNlpbYMvKy; // 0x68
		private char nGtNHrllobDwABaVSbkXDOiwSUoT; // 0x6A
		private char nHYufAxHqMdIhtsnNYIJqUXVFwlq; // 0x6C
		private char TVOjRJPHnZHdZoXarJmupfBPYsfe; // 0x6E
		private char NjhqTOygbKPWmXesUyerneZTHJny; // 0x70
		private char dZUCCpFfXqwoCxlpHCCrObjZcjqo; // 0x72
		private char sAvCUcLGhEHOwGeqcNuIUWdkHmvU; // 0x74
		private char QpTThIJgeBiYKspGnKbPgvyfEkhN; // 0x76
		private char orhJEtCicQfukiXSmuPJRardMzBDb; // 0x78
		private char XhvKOpiEMsSHBjoFZxjZtKeknYCp; // 0x7A
		private char ZSqrlqOgMULuCWalatUnWsjmiMev; // 0x7C
		private char KFXFkfspVgDrcreaLdOACcEJgNkT; // 0x7E
		private char eLEdJPEkCQRLVmhwgvWzglNulkwc; // 0x80
		private char GOXjXRqcMNFqrDENZLOaZgpugbUaA; // 0x82
		private char LFAZiTkzGEbbMVEAzSqexoiuCipO; // 0x84
		private char awIhgWrNpYTtgBWVUWgquREFCohD; // 0x86
		private char SVactaNDfnvUBSBmqHERvdZrVnFt; // 0x88
		private char ATxzydRUWoFjcrfukPJPOADnNebp; // 0x8A
		private char owLFolXdJVGqxJMeWoFZgAbIBdMpA; // 0x8C
		private char NvZIFuFotlYAAANTPjlxEbleGZrR; // 0x8E
		private char TmGbTrHzqJGeUbXMOCQBbSHLeoTGA; // 0x90
		private char tdwIyDDwawaGUDwQCcyUCAxCTxPZA; // 0x92
		private char ZuWCFzkEbjjqJyzMVzNdTtduLeVdA; // 0x94
		private char rlKmIdVnJhBFjlAxrqmLcEaoduEcA; // 0x96
		private char AZCceMBqFoVKoqogGCbkzUpcOrpVA; // 0x98
		private char JZWosmtTQkGuRhnpVdjvgdsMizJH; // 0x9A
		private char JyWGOpnkIiOynepqFETBfJBTpeKe; // 0x9C
		private char UAhHzlAJdLJiidFCCdyPONLKHZFiB; // 0x9E
		private char LoMrAjyBXZihesixXgTJcajbCBom; // 0xA0
		private char HnVimYAlUGnieTlDcbTJAGUGTHvD; // 0xA2
		private char zABTebIyxHiNFkqKnfLcnidoljwD; // 0xA4
		private char nKqgShflhrJGRBOkPMvyStIdJXHaA; // 0xA6
		private char cRKHnnRMGsnkLiPFXvccvEOuFWy; // 0xA8
		private char odMyyIlhzsuuRhYwxDegvxvpbmhl; // 0xAA
		private char nyLdtYaiTfomlWeXaKNCvdWJgVnuA; // 0xAC
		private char IjBIWMMYFWcjAONTDMMoenfjBupz; // 0xAE
		private char UkDMDORLqdbRyTYCTgJwIHEQOtOh; // 0xB0
		private char LxyAcNcJbvoSHxyhaVKuHqeRfwEp; // 0xB2
		private char jEohhgMiPcvgAiXOvmWCsWZAoHfX; // 0xB4
		private char briCjOYOSzSlrzQEaBLkBamvadvdA; // 0xB6
		private char ZdYIWvuyfXiBBfClyHQIfLqCMFrO; // 0xB8
		private char jScAbcatdXlANUBFzYLSOBsyaJFs; // 0xBA
		private char uKnMkdOLamkowAduRzORdXAkvmQM; // 0xBC
		private char dFNOJMOGbEcmxIEhNvNvnnlcCuGGb; // 0xBE
		private char IwvxRNULhsNFAfNkBSYDSVMJWPZb; // 0xC0
		private char uYzRcGkUtxaqVXlQqCVDxcfybKRu; // 0xC2
		private char EkUloyrvQqhmNaPRMdQMjzlSQmyCA; // 0xC4
		private char rYQwQutXmPqCWJkJdQEKcHqPNknm; // 0xC6
		private char DFtONPVigSajBxclTcZeJnOzSGLA; // 0xC8
		private char EboyONjfmqCdVTAWTibrLNKgGJSF; // 0xCA
		private char VYYQBoYfBmJKtNfgSYCPYaToRJbK; // 0xCC
		private char iOuVKYGxOXoGaKULqDbPkNyiDwpX; // 0xCE
		private char cvpzPPVbtmMHuSWIbFdoumyRoCdE; // 0xD0
		private char qsPQssKIYJNgrBFUSJhZzsFQwmZq; // 0xD2
		private char ykEyUXipMlCzneRkBfoNiIbcQPyDb; // 0xD4
		private char TXbYOoLFPEmleRkgNWAqRVRzjuxU; // 0xD6
		private char GnITrLdnZahOSFCszDxoAyZlMbdlA; // 0xD8
		private char wbJKElLeivxhptQqfgpJmdwAMHWi; // 0xDA
		private char ePhCTIToiJGFJheVQyeHhGxCixgyA; // 0xDC
		private char EjJGIZegIFmWIQNnIgenIpJrWjyV; // 0xDE
		private char YaciWHRTCaJCXuPDWEDEhrcaBWgCb; // 0xE0
		private char hzPbCEnCGuLHQugyIpxhJRZUYkRE; // 0xE2
		private char ghWMAtJgyLrCLjtJVoPxOkcBERcr; // 0xE4
		private char hgAXljsWXmWCvATEARjRsYjJJQSd; // 0xE6
		private char PlyaYLiuTWPMwFkueoVMsSTjszBKB; // 0xE8
		private char bnJnUnSzFCInATFBCpdrTwncoObO; // 0xEA
		private char kDaNEqcbqOkFROUhzcXaMuJJopmG; // 0xEC
		private char wmlyVkBHNvkPChhjwtzIuFrfhnjb; // 0xEE
		private char KEgzyldRmCwPAdOrImByhVWmZqcF; // 0xF0
		private char MfuRyBEJLOhuEFbRyoZydAJqQGLX; // 0xF2
		private char cWpYDTAFhayPWAAvFktbSIxIPyAR; // 0xF4
		private char MLeMKzyPFmtiWepiXIGlKorYCxkoA; // 0xF6
		private char lArEGXczEhPnacoWchPwTaEbLvzv; // 0xF8
		private char WUmFpgXlDZgTxjhjtxjnKcYaekMAb; // 0xFA
		private char dskjJendzxhFNkUGhHVjBUZjQqDJ; // 0xFC
		private char NaAtaWimnSZzmBstDfxkWAhRmSas; // 0xFE
		private char JbPckajIvMoAZchyEkwmGedSlhhtb; // 0x100
		private char LcKloOzLTSngOiHxtYjTHmdPdPdf; // 0x102
		private char MhXzXKUxMSelYzRjLJcUqqlkIlNg; // 0x104
		private char XwTRsNOeGeKlAknvxcZjbdJBXDUU; // 0x106
		private char mhrUweWiJvZSJfJDQwqzqfJWHxdf; // 0x108
		private char rvvWqqrQNcVRBJgLDYfpmDMFOJfA; // 0x10A
		private char pxxNvTDDYSAEGIENOsxgFXGIYeISA; // 0x10C
		private char xMKwJpXqVIlRqxfNUWVTTRzRLagb; // 0x10E
		private char kxDzRgoGzTqYXoFkRMTxwIImowDR; // 0x110
		private char YsfLgowllWLwuWFwEkCCqBdIntDU; // 0x112
		private char nyqrHpsxPgDJKxJwCeXDuLFZvEuA; // 0x114
		private char pqrWVAUKyHmNirGEtkDZlPrWyIqV; // 0x116
		private char VsWwPwGVinwjJfzhdaKGANKCiZAf; // 0x118
		private char OnUNEnCPTiaqTDSoylfZJIxLrAmB; // 0x11A
		private char bLCGTuTxJBgwgTehzlZaBXYKyAhE; // 0x11C
		private char EXjGFjYXYbfQhevYzfyQgUsElFehB; // 0x11E
		private char MDrfJhgtAtRUIEvtEUaYnleEUcged; // 0x120
		private char KOJAwliEJcDhLSIgYHfFQNVUDdHy; // 0x122
		private char UkcUlrUgijzORPgQFsOoAMqweZvcA; // 0x124
		private char UPxiQPBhXzEybSOSWVhDnSjnMBIx; // 0x126
		private char ykPccBnIBtEfFxabFcfRUSBqOycv; // 0x128
		private char AvwAENYxNWeXuHHIZiTbBhKrkMecb; // 0x12A
		private char PPQAjEOJcdIhbPxCNWqMtclkFYho; // 0x12C
		private char tAYcAQbCKpuSsaiSHGjFpqqbkBVNA; // 0x12E
		private char qXgenYboUosEOMHDMVobNgkGPVJSA; // 0x130
		private char ksfvqvcuCmTmLpMBRzsPLzDbMAny; // 0x132
		private char lmWSDGCAcUvYZshvVmwwQvNtuoJq; // 0x134
		private char cXuuPAmEmSqaqWKhvTRpLTxNJdQN; // 0x136
		private char ErUWojuoQBTbXXViqqSnSyAINzfv; // 0x138
		private char iEjLEqZcvktKcRNSiqakZsXyrXQe; // 0x13A
		private char tRuZyTKjeThEmBfLszRbFZpyftMk; // 0x13C
		private char pRcFKXxXGQhUpMYOuHGvToJhRQCC; // 0x13E
		private char DonBxTKhprZMYqlLNGzLAtWTdGoAA; // 0x140
		private char RveQnMcoDcRCFHmGuICaYKzYCEEV; // 0x142
		private char rqnWWuoTwvsdvKSGGPEtQRdpAIOm; // 0x144
		private char seqMCLHcJHdSDinyeiBctvdPFgEBA; // 0x146
		private char fTnFPtbJgYDhiYBDXVOgLRahuPlUA; // 0x148
		private char YuqQCLpDYmEtOSGPnGestlzPlpOM; // 0x14A
		private char QEvcNpULjytFVuDbJYiThZHOzdke; // 0x14C
		private char lMMkjTMxeiFAtdAxrBeUekMZBLfDb; // 0x14E
		private char DWdIDogxekuoVLbgtHgSXxDjFwGiA; // 0x150
		private char VoncNeHzxHyBnostcbGlAzXkycLeA; // 0x152
		private char LNbVnoEQvZtWixUfEefHdClpxndT; // 0x154
		private char MzBgTIusYVfTRRDapfFfAtHAtxEMA; // 0x156
		private char iMYbAqHkUICqoAHRIJabGoRZNwbVB; // 0x158
		private char lAWqPFxFrbGvMdbmyMJOMjFvDFWAb; // 0x15A
		private char seBSlKJmLaAOtnVNTmQMLpmyfgUj; // 0x15C
		private char XOQIsLONZCmUDBDqSZOcoHwfhgdn; // 0x15E
		private char CxvQWkpmbAmkoWnjbpZgIXTFXfCE; // 0x160
		private char lIhAYOgtzyiUrPFilCKRqxgLEdGi; // 0x162
		private char GmtGsZQJHkISuadhSYWlTvxUxxVi; // 0x164
		private char HzjHXhapLGnlbvkdKnqfswkkLZWu; // 0x166
		private char ahgannhkwhPpaZfUfSpavnHmgwUOA; // 0x168
		private char QGnLclKGaLsSyCGQsgFumOAYnqSC; // 0x16A
		private char DdiomlTLFaItrjSvFmttltNxXnggA; // 0x16C
		private char tqeSXwsezWhNRGxfuKnpGXobvAeK; // 0x16E
		private char cgLINZEzmGtoKRskgqxVFWagblqtA; // 0x170
		private char nsHQlQZXiUMgQEZMtKrCLCzdEorHA; // 0x172
		private char CLUZzFxYjAgprCUHmilzDmJdYWbk; // 0x174
		private char YBjItEaOqMnwZqMdAsYgqPlFXKEMA; // 0x176
		private char oidjZntoHZWOxMQRRSodcaRTKfuQ; // 0x178
		private char vJsdZpBGmMefXwBzaCqwNvXwqnfHA; // 0x17A
		private char HkbAxzIJIVFZKRIOTSIBDiejvbKk; // 0x17C
		private char HUMgwGRYCDnerDoAeNOmSMKGTdav; // 0x17E
		private char JVNfMMfYyZrUpCrRzqYRzGymIgTAA; // 0x180
		private char FxfGYOBpmHbgkbSdgIdGneKojVUPc; // 0x182
		private char mxtZYhwMWlDkYVUJTGEaDUnCYLPG; // 0x184
		private char fdUUSVQannyDGahHscVWaAVqfrdGA; // 0x186
		private char qmLgZOZWDulsyHIRPeNnBxmFJlxs; // 0x188
		private char GSapFPmmwhbXBeOXpfcpGTDGxOoR; // 0x18A
		private char EayfKEiJZfXsChNmyIbtYtPHhAbR; // 0x18C
		private char SdptbYdjVYZjpAnnfPuZKswvoXOP; // 0x18E
		private char itaLIPMfdXFiYeOfcIJELpNNCEIZ; // 0x190
		private char wopbbWuoldiXipnKKBcdQOWKpQmg; // 0x192
		private char hURbaOADAZHKefwKiUjsfWXSKkQqb; // 0x194
		private char aNgllAIYlTuIoSxOwDTOlhTolZcQ; // 0x196
		private char NBcNQsEvxivuLHLugYfSdDQXfmpu; // 0x198
		private char OrKoZpGzpKkiyqXqSHhlwphbsDDb; // 0x19A
		private char QZaCsicjOUYiPjktlJmBvoEGPiJEb; // 0x19C
		private char qyxQXJrPPpuOZTRQopmxGXdNVdLH; // 0x19E
		private char RuMEsgPHMOZhDeTSIFxRKNKfJHnv; // 0x1A0
		private char JCVIgPBfUSmVsOBDGaHhYTRBAxxBb; // 0x1A2
		private char WIWlQExfpNgcKKNfdmuYlKqvajro; // 0x1A4
		private char cXZcbsmtcQtxrwFbgkatIoqghwGk; // 0x1A6
		private char KcTZszjpbpdXUtWeZeBZkxIvOkzSA; // 0x1A8
		private char OteCYtXiENRrEBIhszItCHmnGIHs; // 0x1AA
		private char acuGofLDZOEXrUrhkflGQkCVdRqG; // 0x1AC
		private char odYIxKuLCjiFIeNJcawvXkKDljkR; // 0x1AE
		private char yADQVxKuoJajloFWniRDFzlZUZfT; // 0x1B0
		private char ISzebQwEsqvmtSSMxxCegcZdPVRj; // 0x1B2
		private char ePbNmseBsJmLPFFpZbYoaycZvQyg; // 0x1B4
		private char WchDQvBczMEjEFiOiemeokadBYBZ; // 0x1B6
		private char njkHPYNhfhrVIYogEqHXXKUTmaCC; // 0x1B8
		private char RvxBIkPuWVyrGuiixgoxKCveKVzw; // 0x1BA
		private char acHtxSgeEdvDVuHihkPCVIUMLScK; // 0x1BC
		private char DGDLMVfhIuQelOLexRbYTapmdHss; // 0x1BE
		private char hQGIqLbGxDbjeFEdjsAHQrfHYIUJ; // 0x1C0
		private char AEMGsDNKqUDbTegOIFyDQvRUGQrP; // 0x1C2
		private char sqplKANmkWBKIIkYmZQstISzpBDkA; // 0x1C4
		private char NpIbJEFHtGGdmCTxcGBPNmCIdLIdc; // 0x1C6
		private char lyjZAPtAGKcqWvrBgxRHRnWRTTCF; // 0x1C8
		private char EfZDYLGliIyGJVokMqHaUyFpoaUvA; // 0x1CA
		private char iiEDXPHgEhrJLtAWpHWCkycRtcNe; // 0x1CC
		private char iLPGmqpRJJNiVEAzIqveSlPVmIzd; // 0x1CE
		private char IjImKWQBgKKcRgpdYdhocEjwnLsbA; // 0x1D0
		private char mFiAzLDIswGcQAHuIsSefkfwLxBn; // 0x1D2
		private char MIobXpTxpcREEMgdcAaCELPIAoAJA; // 0x1D4
		private char KYAXkmFCpdDDUkmaVtOlNRHJbqZl; // 0x1D6
		private char XiVImYqmauBkGBtLUlBRxXiOletSA; // 0x1D8
		private char PUrBVtgvxjGvJthRBwXoFXQCVMVc; // 0x1DA
		private char cRrIMmfDRTLJLPBAlPqIViOFzkxP; // 0x1DC
		private char keKOMWiRWKBJOXarIuugJsiEdyWl; // 0x1DE
		private char VvxIiJtPHYCjeuWmhVadukdofvBJ; // 0x1E0
		private char OzitgsrsKWMBrloWZGVTxzEvEhVK; // 0x1E2
		private char kypmuVpRfAqAvwBIBdwgDrXZKDvuA; // 0x1E4
		private char rImCAIBlxCNduCTMjjsMFwSuHsNbB; // 0x1E6
		private char lNGGfsByBiovPuzSlqbxNVujxZpSA; // 0x1E8
		private char SPQGciIdFqFPWMsuiyDcVATfVhcHA; // 0x1EA
		private char qkQatJECjaLgkjdDiwpPbZgmZMjBc; // 0x1EC
		private char zcCoDErEeGEtYcILwBAUvxkBbkyoA; // 0x1EE
		private char WeoxZYDykcTRdZgsEtOCsvgEHoAO; // 0x1F0
		private char UDAYkyPWCmxPwARJRbobyVEgLieH; // 0x1F2
		private char eaCXXUOlLwsrfwwelbTftQoGICYO; // 0x1F4
		private char OpABTpQVHILrsKogZvRNWRVNpSAv; // 0x1F6
		private char ZiZrRYgmtRVkLehwIJUWIMSqyaaY; // 0x1F8
		private char XPVLkOzwzlBxHBjPDJStBxSTSUVr; // 0x1FA
		private char cTAzJDZrSxbkpjeqAsAHhIpxPExPA; // 0x1FC
		private char iWQkPoMyyjmYQmgFxEBbSqRlPsgC; // 0x1FE
		private char eyNqhgBOXqhgaivyDmJwdpPHUnXw; // 0x200
		private char ymoCUlhghZDZJgSGjbokbkOasttub; // 0x202
		private char VEsNwAWCEqFNIrTidLmkyGZVUqQb; // 0x204
		private char SFZWsBLHKlCpGxHfdwqUddqmhjwM; // 0x206
		private char hmCgdzuUOWwNswaMOJZqEMzFZIaK; // 0x208
		private char PxGPWigAyfcfLBCJSKNIDsXGYzKJA; // 0x20A
		private char BbcWmhGQuIibIMqEvlWrkNbenhrq; // 0x20C
		private char vvhaYUSUxHBRFIiKzBEmpypraKakA; // 0x20E
		private char ijCoOeFdoqdFzAXpdCsVgYDtoMSp; // 0x210
		private char pdiNHlTNtjbWLcswFMChIjGaScpVB; // 0x212
		private char OiRBBukbSxMtPbnAQyCwBULwLQfsA; // 0x214
		private char ZBYrZOPFCnXhiEhHkHUgBwulstZh; // 0x216
	}

	// Methods
	internal void BcaDDZeihMgRujTrJVazrAjsWLLU(ref EaVrxzQFCTeFlgOvlCOXVfDNHkVI param_00073a60); // 0x000000018ABB9778-0x000000018ABB97AC
}

internal interface LUJFUwdxIdstOIgjIQCNizLsdLETA // TypeDefIndex: 53866
{
	// Properties
	ZSUAvntfLnoPvgBKYfVfuvtQblMGA qtIfMRoWBGZEUSCwsKeTMCQXFfRIA { get; }
	HegtEhejPmLQIYSeBGlDUmMVfXog[] kidCTAgaJTWmbWtqnuzgvoLuRezj { get; }
}

internal interface nQctLAKvbEudnDiceCspsjyQWyFh<u0001, in u0002> // TypeDefIndex: 53867
	where  : struct
	where  : struct, yAcTuDRxvBzGjwYsLbbzRJSQLkNg
{
	// Methods
	void MarshalFrom(IntPtr param_00073a61);
}

internal struct EsYlVkTNpXweFHIzPgRHfxdCgmmRA // TypeDefIndex: 53868
{
	// Fields
	public int HSeftqFKglSCHULyPTKbHYccgDSz; // 0x00
	public int ULSIzpQhQxVgvjIcLvfoFdMCeDIB; // 0x04

	// Constructors
	public EsYlVkTNpXweFHIzPgRHfxdCgmmRA(int param_00073a62, int param_00073a63); // 0x0000000184D85C40-0x0000000184D85C50

	// Methods
	internal void yaDKKkmiDuALDKUnmEByBCDNTjpD(ref QvWbleffChmRFEWHpvLtcEfemOHPc param_00073a64); // 0x0000000184DA89F0-0x0000000184DA8A00
}

internal interface yAcTuDRxvBzGjwYsLbbzRJSQLkNg // TypeDefIndex: 53869
{
	// Properties
	int bUsOcCfceAaHAFMFyMNHggeIypvmb { get; }
	int aAYoduMJWbpzoALgzTFLgapBasnK { get; }
	int yarsNCqpAJyntJMkiHvyHqhuMcsT { get; }
	int SuwGDyfBVtiOexFOrVCuRmDawZagA { get; }
}

internal class uiNBFFkTpfqYYBjzPgxoiyKQNigQA : BslFyWdFqNvcSBpOIOOVPaeVNHaNA<GPkbBxELmYMSjUedRXbWrnFhNjKFb, OIMKScjOBjkpKdGtwdiPLlAhCFN, BFjQFlXYsiaVRjZHngIGIaJlOkcm> // TypeDefIndex: 53870
{
	// Constructors
	public uiNBFFkTpfqYYBjzPgxoiyKQNigQA(nmDUaUhbthOlhiDQJeKfGxYxeylPA param_00073a65, Guid param_00073a66); // 0x000000018ABBB310-0x000000018ABBB38C
}

internal enum xvWLroqHVxATEJwSrusLWaCJJSGI // TypeDefIndex: 53871
{
	X = 0,
	Y = 4,
	Z = 8,
	RotationX = 12,
	RotationY = 16,
	RotationZ = 20,
	Sliders0 = 24,
	Sliders1 = 28,
	PointOfViewControllers0 = 32,
	PointOfViewControllers1 = 36,
	PointOfViewControllers2 = 40,
	PointOfViewControllers3 = 44,
	Buttons0 = 48,
	Buttons1 = 49,
	Buttons2 = 50,
	Buttons3 = 51,
	Buttons4 = 52,
	Buttons5 = 53,
	Buttons6 = 54,
	Buttons7 = 55,
	Buttons8 = 56,
	Buttons9 = 57,
	Buttons10 = 58,
	Buttons11 = 59,
	Buttons12 = 60,
	Buttons13 = 61,
	Buttons14 = 62,
	Buttons15 = 63,
	Buttons16 = 64,
	Buttons17 = 65,
	Buttons18 = 66,
	Buttons19 = 67,
	Buttons20 = 68,
	Buttons21 = 69,
	Buttons22 = 70,
	Buttons23 = 71,
	Buttons24 = 72,
	Buttons25 = 73,
	Buttons26 = 74,
	Buttons27 = 75,
	Buttons28 = 76,
	Buttons29 = 77,
	Buttons30 = 78,
	Buttons31 = 79,
	Buttons32 = 80,
	Buttons33 = 81,
	Buttons34 = 82,
	Buttons35 = 83,
	Buttons36 = 84,
	Buttons37 = 85,
	Buttons38 = 86,
	Buttons39 = 87,
	Buttons40 = 88,
	Buttons41 = 89,
	Buttons42 = 90,
	Buttons43 = 91,
	Buttons44 = 92,
	Buttons45 = 93,
	Buttons46 = 94,
	Buttons47 = 95,
	Buttons48 = 96,
	Buttons49 = 97,
	Buttons50 = 98,
	Buttons51 = 99,
	Buttons52 = 100,
	Buttons53 = 101,
	Buttons54 = 102,
	Buttons55 = 103,
	Buttons56 = 104,
	Buttons57 = 105,
	Buttons58 = 106,
	Buttons59 = 107,
	Buttons60 = 108,
	Buttons61 = 109,
	Buttons62 = 110,
	Buttons63 = 111,
	Buttons64 = 112,
	Buttons65 = 113,
	Buttons66 = 114,
	Buttons67 = 115,
	Buttons68 = 116,
	Buttons69 = 117,
	Buttons70 = 118,
	Buttons71 = 119,
	Buttons72 = 120,
	Buttons73 = 121,
	Buttons74 = 122,
	Buttons75 = 123,
	Buttons76 = 124,
	Buttons77 = 125,
	Buttons78 = 126,
	Buttons79 = 127,
	Buttons80 = 128,
	Buttons81 = 129,
	Buttons82 = 130,
	Buttons83 = 131,
	Buttons84 = 132,
	Buttons85 = 133,
	Buttons86 = 134,
	Buttons87 = 135,
	Buttons88 = 136,
	Buttons89 = 137,
	Buttons90 = 138,
	Buttons91 = 139,
	Buttons92 = 140,
	Buttons93 = 141,
	Buttons94 = 142,
	Buttons95 = 143,
	Buttons96 = 144,
	Buttons97 = 145,
	Buttons98 = 146,
	Buttons99 = 147,
	Buttons100 = 148,
	Buttons101 = 149,
	Buttons102 = 150,
	Buttons103 = 151,
	Buttons104 = 152,
	Buttons105 = 153,
	Buttons106 = 154,
	Buttons107 = 155,
	Buttons108 = 156,
	Buttons109 = 157,
	Buttons110 = 158,
	Buttons111 = 159,
	Buttons112 = 160,
	Buttons113 = 161,
	Buttons114 = 162,
	Buttons115 = 163,
	Buttons116 = 164,
	Buttons117 = 165,
	Buttons118 = 166,
	Buttons119 = 167,
	Buttons120 = 168,
	Buttons121 = 169,
	Buttons122 = 170,
	Buttons123 = 171,
	Buttons124 = 172,
	Buttons125 = 173,
	Buttons126 = 174,
	Buttons127 = 175,
	VelocityX = 176,
	VelocityY = 180,
	VelocityZ = 184,
	AngularVelocityX = 188,
	AngularVelocityY = 192,
	AngularVelocityZ = 196,
	VelocitySliders0 = 200,
	VelocitySliders1 = 204,
	AccelerationX = 208,
	AccelerationY = 212,
	AccelerationZ = 216,
	AngularAccelerationX = 220,
	AngularAccelerationY = 224,
	AngularAccelerationZ = 228,
	AccelerationSliders0 = 232,
	AccelerationSliders1 = 236,
	ForceX = 240,
	ForceY = 244,
	ForceZ = 248,
	TorqueX = 252,
	TorqueY = 256,
	TorqueZ = 260,
	ForceSliders0 = 264,
	ForceSliders1 = 268
}

internal class GPkbBxELmYMSjUedRXbWrnFhNjKFb : nQctLAKvbEudnDiceCspsjyQWyFh<OIMKScjOBjkpKdGtwdiPLlAhCFN, BFjQFlXYsiaVRjZHngIGIaJlOkcm> // TypeDefIndex: 53872
{
	// Fields
	private int wYzJglTQyAoUtvakRNfILbqUpqkk; // 0x10
	private int rKCBRtJdnrOQLidMIMQaKRWpGHXY; // 0x14
	private int EPJxzoofTkQcxwxsckvWiPLxovGv; // 0x18
	private int kUDGQsFBvgxoadZKUZtSnyFFeyMGb; // 0x1C
	private int heAGaXhYfnoYzjqsnsMImdPufjZEA; // 0x20
	private int PcrrobsuNctvUyXjmanllBTBxlWq; // 0x24
	private int[] VNykwiqcrPUdgETPOpLnBYfygVww; // 0x28
	private int[] boYezkqhgtHFogBkHIxHxtrjYaNi; // 0x30
	private bool[] eNLbuzAhxLiGHiIpRLezlVgEAddN; // 0x38
	private int DELsjkbMoOcLSFTRSmEYPhdQkpSMA; // 0x40
	private int uhCnuJCFZoLzQmwCAKbNkWqzvdMB; // 0x44
	private int uqwuiqfpTVXTmhkPRmNAiaDuEDtl; // 0x48
	private int DOnqnhcIzKBGYokCvBRjAlHcyUlpA; // 0x4C
	private int OJmaktiFuHmPDcoydjmqbGqQKvJwA; // 0x50
	private int KEGVfEOzOfYqpyFRftVeILaqlQLd; // 0x54
	private int[] bSapjZibvwPUfvKvrMMeEnMCFuYgA; // 0x58
	private int kSvOMZYElRePTCxBoEEpjBdoghNj; // 0x60
	private int CMuqfRuZeVwAKtcqhojsHVSwiZBm; // 0x64
	private int lDqlPEclFEWRlPXGLrXbfwLGhymG; // 0x68
	private int bIBSafyegMAidBnTIafLSspRwZlrA; // 0x6C
	private int HlIfhcBelxoXblipJlCWYnSQoCFg; // 0x70
	private int TuzPQNCImmMdLbiJGDlWIdEdrhXK; // 0x74
	private int[] WxhbLvsuBjVeXSYqNwCoUtwqdrDe; // 0x78
	private int LwNSPdCGqwdRmHWfAAazEDifMtAjc; // 0x80
	private int xLKrXhzUEUqmhGNBlIgeByKBrzkK; // 0x84
	private int PEFGGyUSfQlGUYsNcBvXcRjfilKn; // 0x88
	private int UgJdfHiielClkbTXLFbkNjQTaPaCA; // 0x8C
	private int VbfnKWdYtsFVlAGoyMnhFXHrIvyG; // 0x90
	private int UlAwKfFjTWEOaEOEpTbeQwbODvDpA; // 0x94
	private int[] gbQqTKasYrlAhVhxLmxdPDrseOFhA; // 0x98

	// Properties
	public int sURegOJXrVrzsRbkTLhQVBuqJVbJ { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	public int KNTFhJabRbWgVSMSJojTSthigWSM { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
	public int MFJjLDiicbnoxXotepspuhOjfNkU { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	public int JHOkKToIVVbEcQssxCBAbFteUTkQ { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	public int MPFeHSJixWGHRViAmxtGYsCTbaBS { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	public int HzCrJpUKcFwGlBvsIoLvGxAmjbkg { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	public int[] tQMFwFExlACgqLBpJkZQHFkqDevy { get; internal set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	public int[] lLFhHhTIlkPPZIEycNsUuGtSyENC { get; internal set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	public bool[] PlahzMFUWWFVTEjviHdVVhgEfBVTb { get; internal set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
	public int nMXWZjmUOsgnEDIggCbietHaDulG { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
	public int gOprXbqeJdcnvaXGWLEibDgUZTTp { get; set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
	public int TMqorUndAhGVWeuMVKXiERPjxBccB { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
	public int xaktQtDeBEfMritKatjunUXLFzJm { get; set; } // 0x0000000184D86600-0x0000000184D86610 0x0000000184D86630-0x0000000184D86640
	public int JxKRuTpZfeQsRJscQoyeTSMMDVyr { get; set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
	public int yNsxnEADgrJiFToYaFiqMehPGKtY { get; set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
	public int[] AcGhvdLAvxSObqgmvUyxoeQwolJC { get; internal set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
	public int BWzWpyeMNqZYmsDIwMPxzlcuhgPB { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
	public int rGayEOeAOdRcJXVXPshqTGsTECXz { get; set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
	public int CzsOlnRhsuydUyCBYJsEKMxnSWuU { get; set; } // 0x0000000184D86CF0-0x0000000184D86D00 0x0000000184D86D00-0x0000000184D86D10
	public int JkeWkKAKZVHbDghQHzvIAJzRJFQr { get; set; } // 0x0000000184D86B50-0x0000000184D86B60 0x0000000184D86BB0-0x0000000184D86BC0
	public int rnBVcFvKrCijIJnrgqRPyRGksUrk { get; set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
	public int WjKqIuLkcYZCvVGSlBrDKElircMK { get; set; } // 0x0000000184D868B0-0x0000000184D868C0 0x0000000184D868E0-0x0000000184D868F0
	public int[] SsvrLLvGhWXUmFhbSkonQzKgpDMg { get; internal set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
	public int OnbtdHADzTjroKuJEKWlXSKskARq { get; set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
	public int SgObdTVqQKDtrHLaAVHQmvwnYBKr { get; set; } // 0x0000000184D8FCE0-0x0000000184D8FCF0 0x0000000184D8FCF0-0x0000000184D8FD00
	public int TEtZtVcZmHktppdaeqwMrrbvJCep { get; set; } // 0x0000000184D86890-0x0000000184D868A0 0x0000000184D868C0-0x0000000184D868D0
	public int ATCfXnEcwrDcbaPXkNvYbBtgJEBeD { get; set; } // 0x0000000184D90C40-0x0000000184D90C50 0x0000000184D90C60-0x0000000184D90C70
	public int WwzLuDGHSspRHCkpQBHIAOYWUbytA { get; set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
	public int dbvJIKkVDcPVizpIAbyDQMiNTjRc { get; set; } // 0x0000000184D86B20-0x0000000184D86B30 0x0000000184D86B80-0x0000000184D86B90
	public int[] McibGxihWCRUpJxuGDWxQiSiYGsr { get; internal set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20

	// Constructors
	public GPkbBxELmYMSjUedRXbWrnFhNjKFb(); // 0x000000018ABB26D0-0x000000018ABB27C0

	// Methods
	public void MarshalFrom(IntPtr param_00073a85); // 0x000000018ABB241C-0x000000018ABB26D0
	public void OSNJxVibfKbltujYHkKMLuczmano(GPkbBxELmYMSjUedRXbWrnFhNjKFb param_00073a86); // 0x000000018AB96238-0x000000018AB964F4
	public void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018AB9699C-0x000000018AB97020
	public bool zOecMSUXqFEeObIykqUIZusBBEzfb(GPkbBxELmYMSjUedRXbWrnFhNjKFb param_00073a87); // 0x000000018ABB2EC8-0x000000018ABB3258
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABB27C0-0x000000018ABB2EC8
}

internal struct BFjQFlXYsiaVRjZHngIGIaJlOkcm : yAcTuDRxvBzGjwYsLbbzRJSQLkNg // TypeDefIndex: 53873
{
	// Fields
	[CompilerGenerated]
	private int lZKcowxkaJkwZQlNLnGcoVslplpr; // 0x00
	[CompilerGenerated]
	private int uOXTLDJHKLpkLDyauaUcygkmaTNKA; // 0x04
	[CompilerGenerated]
	private int evqLgaNKhmBADYNvNcfugwunJtjGA; // 0x08
	[CompilerGenerated]
	private int fKlcastPuvARuASmKkyvmcubSdbP; // 0x0C

	// Properties
	public int bUsOcCfceAaHAFMFyMNHggeIypvmb { [CompilerGenerated] get; } // 0x0000000182B77620-0x0000000182B77630 
	public int aAYoduMJWbpzoALgzTFLgapBasnK { [CompilerGenerated] get; } // 0x0000000184D88B20-0x0000000184D88B30 
	public int yarsNCqpAJyntJMkiHvyHqhuMcsT { [CompilerGenerated] get; } // 0x0000000184D88B10-0x0000000184D88B20 
	public int SuwGDyfBVtiOexFOrVCuRmDawZagA { [CompilerGenerated] get; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 
	public xvWLroqHVxATEJwSrusLWaCJJSGI eACABbdNxPpsXrChQCGOcejnVKCoA { get; } // 0x0000000182B77620-0x0000000182B77630 

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABAF778-0x000000018ABAF910
}

[Flags]
internal enum JusXszoNktGzFGSsuCDrqZOXPYLd // TypeDefIndex: 53874
{
	None = 0,
	Position = 256,
	Velocity = 512,
	Acceleration = 768,
	Force = 1024
}

internal abstract class IXVoGLHTxMZOhmxUdMQSOueCZssK // TypeDefIndex: 53875
{
	// Fields
	[CompilerGenerated]
	private NinxpESAdWHMScogYtzEcrOKmWSq XMwLheezAFXiiBujwstkpqhdiPNK; // 0x10
	[CompilerGenerated]
	private int JZCfHSJUfptVgGXMYCwRsyXvWEwCA; // 0x18
	[CompilerGenerated]
	private gBJFzvCtfVRFnbuNFPcUrApHGRbld hBIZgtQsQWGAmgRmMqIoSaNqDtzb; // 0x1C

	// Properties
	private NinxpESAdWHMScogYtzEcrOKmWSq KyAihJLnqGkelkzINpKTCpuYYfu { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	private int piNaiPHnbCykrnVuKnIfGQADxohrb { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	private gBJFzvCtfVRFnbuNFPcUrApHGRbld DKzDBNjhyKawuvYhonJIQWfJJXouA { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330

	// Constructors
	internal IXVoGLHTxMZOhmxUdMQSOueCZssK(NinxpESAdWHMScogYtzEcrOKmWSq param_00073a8b, int param_00073a8c, gBJFzvCtfVRFnbuNFPcUrApHGRbld param_00073a8d); // 0x000000018A7DAF08-0x000000018A7DAF2C

	// Methods
	protected int IbvjoHVOeandXkoQeovjYhtlcGTH(IntPtr param_00073a8e); // 0x000000018ABB4068-0x000000018ABB4074
	protected int IbvjoHVOeandXkoQeovjYhtlcGTH(IntPtr param_00073a8f, int param_00073a90); // 0x000000018ABB4074-0x000000018ABB4104
	protected void mnOZfTJZaPJhBHSiKkLNiAfZLffw(IntPtr param_00073a91, int param_00073a92); // 0x000000018ABB4264-0x000000018ABB42F0
	protected string CmOETABROiKtQaTdmgJeSDAFRDKy(IntPtr param_00073a93); // 0x000000018ABB3FB8-0x000000018ABB4068
	protected string RwTlCccdmfTvMlReSRsZUqwrcDzJ(IntPtr param_00073a94); // 0x000000018ABB41C0-0x000000018ABB41CC
	protected string RwTlCccdmfTvMlReSRsZUqwrcDzJ(IntPtr param_00073a95, int param_00073a96); // 0x000000018ABB4104-0x000000018ABB41C0
	protected void mnOZfTJZaPJhBHSiKkLNiAfZLffw(IntPtr param_00073a97, EsYlVkTNpXweFHIzPgRHfxdCgmmRA param_00073a98); // 0x000000018ABB41CC-0x000000018ABB4264
	internal void NWPOtDnANJklqoVQxJKSFBnsYXcG<u0001>(ref kkodSjjyHKxXmuuzDWPlSRhmRILR param_00073a99)
		where  : struct;
}

[NumFTHcWyFNMUnwclDnApNJtFwHK(ZSUAvntfLnoPvgBKYfVfuvtQblMGA.AbsoluteAxis)]
internal struct OIMKScjOBjkpKdGtwdiPLlAhCFN // TypeDefIndex: 53882
{
	// Fields
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e0-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int sURegOJXrVrzsRbkTLhQVBuqJVbJ; // 0x00
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e1-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int KNTFhJabRbWgVSMSJojTSthigWSM; // 0x04
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e2-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int MFJjLDiicbnoxXotepspuhOjfNkU; // 0x08
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f4-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int JHOkKToIVVbEcQssxCBAbFteUTkQ; // 0x0C
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f5-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int MPFeHSJixWGHRViAmxtGYsCTbaBS; // 0x10
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e3-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public int HzCrJpUKcFwGlBvsIoLvGxAmjbkg; // 0x14
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e4-c9f3-11cf-bfc7-444553540000", 2, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Position)]
	public unsafe fixed /* 0x00000000-0x00000000 */ int tQMFwFExlACgqLBpJkZQHFkqDevy[0]; // 0x18
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f2-c9f3-11cf-bfc7-444553540000", 4, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.PointOfViewController | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance)]
	public unsafe fixed /* 0x00000000-0x00000000 */ int lLFhHhTIlkPPZIEycNsUuGtSyENC[0]; // 0x20
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA(128, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.PushButton | poeujHXJKdgxzeFEVUBvUcmFtnlu.ToggleButton | poeujHXJKdgxzeFEVUBvUcmFtnlu.Button | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance)]
	public unsafe fixed /* 0x00000000-0x00000000 */ byte PlahzMFUWWFVTEjviHdVVhgEfBVTb[0]; // 0x30
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e0-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int nMXWZjmUOsgnEDIggCbietHaDulG; // 0xB0
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e1-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int gOprXbqeJdcnvaXGWLEibDgUZTTp; // 0xB4
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e2-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int TMqorUndAhGVWeuMVKXiERPjxBccB; // 0xB8
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f4-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int xaktQtDeBEfMritKatjunUXLFzJm; // 0xBC
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f5-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int JxKRuTpZfeQsRJscQoyeTSMMDVyr; // 0xC0
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e3-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int yNsxnEADgrJiFToYaFiqMehPGKtY; // 0xC4
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e4-c9f3-11cf-bfc7-444553540000", 2, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public unsafe fixed /* 0x00000000-0x00000000 */ int AcGhvdLAvxSObqgmvUyxoeQwolJC[0]; // 0xC8
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e0-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int BWzWpyeMNqZYmsDIwMPxzlcuhgPB; // 0xD0
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e1-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int rGayEOeAOdRcJXVXPshqTGsTECXz; // 0xD4
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e2-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int CzsOlnRhsuydUyCBYJsEKMxnSWuU; // 0xD8
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f4-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int JkeWkKAKZVHbDghQHzvIAJzRJFQr; // 0xDC
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f5-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int rnBVcFvKrCijIJnrgqRPyRGksUrk; // 0xE0
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e3-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public int WjKqIuLkcYZCvVGSlBrDKElircMK; // 0xE4
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e4-c9f3-11cf-bfc7-444553540000", 2, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Acceleration | JusXszoNktGzFGSsuCDrqZOXPYLd.Position | JusXszoNktGzFGSsuCDrqZOXPYLd.Velocity)]
	public unsafe fixed /* 0x00000000-0x00000000 */ int SsvrLLvGhWXUmFhbSkonQzKgpDMg[0]; // 0xE8
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e0-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int OnbtdHADzTjroKuJEKWlXSKskARq; // 0xF0
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e1-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int SgObdTVqQKDtrHLaAVHQmvwnYBKr; // 0xF4
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e2-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int TEtZtVcZmHktppdaeqwMrrbvJCep; // 0xF8
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f4-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int ATCfXnEcwrDcbaPXkNvYbBtgJEBeD; // 0xFC
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02f5-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int WwzLuDGHSspRHCkpQBHIAOYWUbytA; // 0x100
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e3-c9f3-11cf-bfc7-444553540000", poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public int dbvJIKkVDcPVizpIAbyDQMiNTjRc; // 0x104
	[UsoCBdhjCsFpPWgGxoGohJlQMojhA("a36d02e4-c9f3-11cf-bfc7-444553540000", 2, poeujHXJKdgxzeFEVUBvUcmFtnlu.All | poeujHXJKdgxzeFEVUBvUcmFtnlu.RelativeAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AbsoluteAxis | poeujHXJKdgxzeFEVUBvUcmFtnlu.Axis | poeujHXJKdgxzeFEVUBvUcmFtnlu.AnyInstance, JusXszoNktGzFGSsuCDrqZOXPYLd.None | JusXszoNktGzFGSsuCDrqZOXPYLd.Force)]
	public unsafe fixed /* 0x00000000-0x00000000 */ int McibGxihWCRUpJxuGDWxQiSiYGsr[0]; // 0x108

	// Nested types
	[CompilerGenerated]
	[UnsafeValueType]
	public struct dnwgCPskbCTndpnYChDvjxqegNPVA // TypeDefIndex: 53876
	{
		// Fields
		public int LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}

	[CompilerGenerated]
	[UnsafeValueType]
	public struct RjfdULNFKDUKshSsbLaipldtoeRe // TypeDefIndex: 53877
	{
		// Fields
		public byte LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}

	[CompilerGenerated]
	[UnsafeValueType]
	public struct tCSUEGwBtoWbbIABjeMhOAwkjJKd // TypeDefIndex: 53878
	{
		// Fields
		public int LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}

	[CompilerGenerated]
	[UnsafeValueType]
	public struct jmRkwNfmcIQEhYatGHRgLTKtMqv // TypeDefIndex: 53879
	{
		// Fields
		public int LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}

	[CompilerGenerated]
	[UnsafeValueType]
	public struct QsfDoNeJyNpLYgfytuOQaqWEUKoEc // TypeDefIndex: 53880
	{
		// Fields
		public int LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}

	[CompilerGenerated]
	[UnsafeValueType]
	public struct QnanEQmYDJICALBcEGCwizylolqkA // TypeDefIndex: 53881
	{
		// Fields
		public int LBTCsHdPuZxlgwbRpqFFEZxHLNXvB; // 0x00
	}
}

internal class SWoCckscCFFlHZUcZBalEtsOlVBB : IDisposable // TypeDefIndex: 53886
{
	// Fields
	private readonly string brGcSQOyREiDQmYUDOShcciGajbhA; // 0x10
	private IntPtr LhxRtdKyhADHwatXDTXvylxWqMgT; // 0x18
	private readonly NativeBuffer UzUtkVqQmznFIdHWsNfTBPdCjRYAA; // 0x20
	private readonly int szKxErTqYGdkoJuapWmQGOTAmQnHA; // 0x28
	private readonly MDBYECqvXkaCiSmYJZjrizfidEbk.nnQCTPzFcMHWGWfoOtAsaDpWLiXO iwpIcSWhCVyUmNWDIYZzyRpxkrnE; // 0x30
	private readonly object GdiaoUixUdMkuvnXLXjFLAQlimXp; // 0x38
	private readonly uint ZJwfQiCoaeYtHFmrQKiNjNVVsLphA; // 0x40
	private QJwvzXmfrDwHfKfbgOEvmUxvMugV<MDBYECqvXkaCiSmYJZjrizfidEbk.CBtraXnwXpmyYfPuzLvlCcBzHcLk> zKxmaTHuihDdNKlYzkPhnZCYIkIA; // 0x48
	private zyzbBTMhhKdxBRMBXLSFiNshoEIT yARrlCRpmrfIUYMILBdVIMkPLZZGA; // 0x50
	private int NARAmolZenVfUQmnpgEWpESwmbct; // 0x54
	private bool vemXRUpvtRkRobsaRmkAgkKCazBC; // 0x58
	private int uFFEGUiuDlAoejAEtJPkfQbBeKLAb; // 0x5C
	private int SPIqcferkcBmmglwihNEhAwgnPoEb; // 0x60
	public readonly int qnjJFVnIuwqRdLKJEzwYyNMRMJyM; // 0x64
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x68

	// Properties
	private bool akJlAXhUcHpRKZzggAJdBwlcZzEF { get; } // 0x000000018ABB74F8-0x000000018ABB7548 

	// Nested types
	private enum zyzbBTMhhKdxBRMBXLSFiNshoEIT // TypeDefIndex: 53884
	{
		Idle = 0,
		Waiting = 1,
		ErrorPending = 2,
		FinishedError = 3,
		SuccessPending = 4,
		FinishedSuccess = 5
	}

	public enum VRtdlWZPJsabUWMRrfWbNDGWgGUBA // TypeDefIndex: 53885
	{
		Idle = 0,
		Success = 1,
		Error = 2,
		Waiting = 3,
		CriticalError = 4
	}

	// Constructors
	public SWoCckscCFFlHZUcZBalEtsOlVBB(string param_00073a9a, int param_00073a9b, int param_00073a9c); // 0x000000018ABB7208-0x000000018ABB74F8

	// Methods
	public VRtdlWZPJsabUWMRrfWbNDGWgGUBA EhQhxFweepMpjwazcuSRnFZeQtLc(byte[] param_00073a9d); // 0x000000018ABB6C90-0x000000018ABB6FC4
	private bool fnQdOSfnsDVjxpjPuvcYfsMiPhHW(); // 0x000000018ABB7548-0x000000018ABB7730
	private void NURSyHTXmChYGrLRLcTlgmIUZHes(); // 0x000000018ABB6FD4-0x000000018ABB7094
	private VRtdlWZPJsabUWMRrfWbNDGWgGUBA yyJosQggFThnaqprPeJzBJCwuauA(); // 0x000000018ABB7A20-0x000000018ABB7B9C
	private void GnozaAakspodijQYSRWkQsLZBcuW(); // 0x000000018ABB6FC4-0x000000018ABB6FD4
	private void vmUpEHNMKvugRhWjFEYqKHjMaSmm(); // 0x000000018ABB7894-0x000000018ABB7934
	private void tRuaqIhSdYzhnrhZSyEMOnYHehUr(); // 0x000000018ABB7884-0x000000018ABB7894
	private void xIDBeuCIhqKkMkiEyjskQnzzqdhDb(); // 0x000000018ABB7934-0x000000018ABB7A20
	private void DFzbWQdNlFisggGgVmYILlDdMehP(); // 0x000000018ABB6C08-0x000000018ABB6C40
	private void lBMTbRuwRfNSwCPcHnAiVMhJqLHQ(); // 0x000000018ABB77E0-0x000000018ABB784C
	private bool ljzOTGpCHRdGziUWNHWpNIuHgneIA(); // 0x000000018ABB784C-0x000000018ABB7884
	private bool kVYKrvcgVGoBAawfvjoxKHOMlWwG(); // 0x000000018ABB7730-0x000000018ABB77E0
	private void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA(); // 0x000000018ABB6B84-0x000000018ABB6C08
	[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(MDBYECqvXkaCiSmYJZjrizfidEbk.nnQCTPzFcMHWGWfoOtAsaDpWLiXO))]
	private static void DrVaxNHoNLkLOmHrSqoMKLRBoMjY(int param_00073a9e, int param_00073a9f, IntPtr param_00073aa0); // 0x00000001841E1670-0x00000001841E1680
	public void Dispose(); // 0x000000018ABB6C40-0x000000018ABB6C90
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABB7194-0x000000018ABB7208
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073aa1); // 0x000000018ABB7094-0x000000018ABB7194
}

internal class aHzSDAgzXeTUuXeKeiUwhHjMNyKD // TypeDefIndex: 53889
{
	// Fields
	[CompilerGenerated]
	private ushort LUMuzAbrWnMHseXKgyELDjFGWJSj; // 0x10
	[CompilerGenerated]
	private byte WzclJqZLidxBrDrAUUtbEkQsHyfb; // 0x12
	[CompilerGenerated]
	private bool SQsiEzIScYlDgyeJZYkJrphFbfFA; // 0x13
	[CompilerGenerated]
	private ushort UciwgiHoaDCynyCDvfZYlmwHppbc; // 0x14
	[CompilerGenerated]
	private ushort forBhCFfqJjrxPbbvNnWfAgokqQiA; // 0x16
	[CompilerGenerated]
	private ushort OWRFvAcVlplTTYSiWfbJJScBJBbWA; // 0x18
	[CompilerGenerated]
	private ushort VwZBUnXyeKAFQrsHkhTGLEwuSiGM; // 0x1A
	[CompilerGenerated]
	private bool oxJJoRhJDQEZFIkcPpmhSurGTbHT; // 0x1C
	[CompilerGenerated]
	private bool kKMiOapOHoQgXWVHoCAWkUKuQDOH; // 0x1D
	[CompilerGenerated]
	private bool rDEEPiMvsXpABkYMdFpbjtsyAZjC; // 0x1E
	[CompilerGenerated]
	private bool VUsIgdVRQZOEKTRchjuMDKTZEKyz; // 0x1F
	[CompilerGenerated]
	private uint[] pgBuuCeKSuTAcbjapyUZImCdAVNiA; // 0x20
	[CompilerGenerated]
	private OkLYbJfHcwWnAGGibDNWcbwLCuXsA GFPiBctkpLainibUgLYxBOCTbeWVA; // 0x28
	[CompilerGenerated]
	private ywtLnMAYNmOsSSPgvZjUhjksSggo wkXxVtcCQqSjsHMkInyHuMXAVkrL; // 0x38

	// Properties
	public ushort NDweLaWskzoBwpWJxCWuzQStzdYi { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D96190-0x0000000184D961A0 0x0000000184D94F60-0x0000000184D94F70
	public byte yQxQgOQNMVMVBtcqgArgADGYErtCb { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88390-0x0000000184D883A0 0x0000000184DA0900-0x0000000184DA0910
	private bool vtTDydgHKBpOnHSyNFEsNAlyQxfS { [CompilerGenerated] set; } // 0x0000000184DA8AE0-0x0000000184DA8AF0
	private ushort EVOgATFTRXRYYHBhTtlQzWYqqwdA { [CompilerGenerated] set; } // 0x0000000184DA8B00-0x0000000184DA8B10
	public ushort pHcUlKlzzchyOdBayWGzpHfvaXne { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D993B0-0x0000000184D993C0 0x0000000184DA8A80-0x0000000184DA8A90
	private ushort OZGNGboMcWuoFBqTPiRpwosbEqYM { [CompilerGenerated] set; } // 0x0000000184DA8AB0-0x0000000184DA8AC0
	private ushort xfxgDPRowhYBpUmBfcwmlmnSOAOk { [CompilerGenerated] set; } // 0x0000000184DA8AF0-0x0000000184DA8B00
	public bool BfopjfztUWmuPqlPQddPxAYCUqBv { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
	private bool hMRiaanusLpZjoDmjlMCDmUAeXvt { [CompilerGenerated] set; } // 0x0000000184D89610-0x0000000184D89620
	private bool OrluHimCvJfxNzFNtqGOaUVOaKzG { [CompilerGenerated] set; } // 0x0000000184D89630-0x0000000184D89640
	private bool pBNaQqqwjWuTtRxKaIqRAoduhvcR { [CompilerGenerated] set; } // 0x0000000184D89620-0x0000000184D89630
	private uint[] uEWSYFkyRUKNddSuwNCCuQBguizT { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
	public OkLYbJfHcwWnAGGibDNWcbwLCuXsA rWfPOTkywVVLkhergznPfrOaXcQA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
	public ywtLnMAYNmOsSSPgvZjUhjksSggo vLEBkPDtgrvJRhDPlMNfHsyfaKXnB { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FD20-0x0000000184D8FD30 0x0000000184D91AB0-0x0000000184D91AC0

	// Nested types
	public struct OkLYbJfHcwWnAGGibDNWcbwLCuXsA // TypeDefIndex: 53887
	{
		// Fields
		[CompilerGenerated]
		private ushort ELlaRTvgVEjHUpvxmdDBwXeTSSTQ; // 0x00
		[CompilerGenerated]
		private ushort CzVzQlBcLcNYFWYGMkLXwsOeCSJd; // 0x02
		[CompilerGenerated]
		private ushort uAGyARYkWHnrFXAhRigGLRibFkjL; // 0x04
		[CompilerGenerated]
		private ushort NjtCjUKilYJACojqZjBqodUHaCKjb; // 0x06
		[CompilerGenerated]
		private ushort bpcVsvwNMfufGuCSrbjRblHNksvB; // 0x08
		[CompilerGenerated]
		private ushort dbAGmWdFkXkDNNWbQZcdkYODQHYMA; // 0x0A
		[CompilerGenerated]
		private ushort USZdQxjjysNAEGyVRPBVhvvGHSqAb; // 0x0C
		[CompilerGenerated]
		private ushort TvxuXikcWoBDNuALcEEQPyyqnVZm; // 0x0E

		// Properties
		public ushort ItMgALtDaiVTFjHhSTsudMjbbXEbA { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184D87160-0x0000000184D87170
		public ushort vNUrgCyNhiUnLsFVTLYUvLEjfntu { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87610-0x0000000184D87620 0x0000000184DA8A10-0x0000000184DA8A20
		internal ushort DwlIhRdQEPDZMlYEjVTJrPCtauNx { [CompilerGenerated] set; } // 0x0000000184DA8A50-0x0000000184DA8A60
		internal ushort bxWgvYsqzYEOyNWKUFzImHLcCmcK { [CompilerGenerated] set; } // 0x0000000184DA8A20-0x0000000184DA8A30
		internal ushort EvUdqujojeMZuETniwnoKWXjuZNWB { [CompilerGenerated] set; } // 0x0000000184DA8A70-0x0000000184DA8A80
		internal ushort hEKMVDtZDkgVmvdcqcPlfCxPVjok { [CompilerGenerated] set; } // 0x0000000184DA8A00-0x0000000184DA8A10
		internal ushort oQpvoKPnebMtUqjKGMoXpqAsQVCj { [CompilerGenerated] set; } // 0x0000000184DA8A40-0x0000000184DA8A50
		internal ushort JxxAHZCnxiMJSoWYGfKVGIrCMVJIA { [CompilerGenerated] set; } // 0x0000000184DA8A60-0x0000000184DA8A70
	}

	public struct ywtLnMAYNmOsSSPgvZjUhjksSggo // TypeDefIndex: 53888
	{
		// Fields
		[CompilerGenerated]
		private ushort rqZHdIAsEIlrdlDQBtmUhaxPNUBB; // 0x00
		[CompilerGenerated]
		private ushort ffvRVzEZhpaGpDkdUuVBEZWVCnaj; // 0x02
		[CompilerGenerated]
		private ushort twRDpeslgSNYPMqaXtdUigIpjUcv; // 0x04
		[CompilerGenerated]
		private ushort YDyCCYTGHQgQydQRqDxUiZdADHjxA; // 0x06
		[CompilerGenerated]
		private ushort FYgTlKshxqlWWYfPpJUsQgUlCgcq; // 0x08
		[CompilerGenerated]
		private ushort BYdhqmBDSYELKztdVnjtkCPhFuuFb; // 0x0A
		[CompilerGenerated]
		private ushort RDsEWTKHLTsFISjggDUeeEzjMHrU; // 0x0C
		[CompilerGenerated]
		private ushort VmjYZskzCwrkfFwqWiukRllVDVxW; // 0x0E

		// Properties
		public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184D87160-0x0000000184D87170
		internal ushort rfcVzyntsQRBZuQsphQIAieNMatf { [CompilerGenerated] set; } // 0x0000000184DA8A10-0x0000000184DA8A20
		internal ushort UGSHpKjCSetxyyuIPUDWVEYHBlFD { [CompilerGenerated] set; } // 0x0000000184DA8A50-0x0000000184DA8A60
		internal ushort YGNxrFfotADbwHHXFCFbjPccoxEvb { [CompilerGenerated] set; } // 0x0000000184DA8A20-0x0000000184DA8A30
		internal ushort iBWeYzDXeUpHNJXfgECfOIwdFzByA { [CompilerGenerated] set; } // 0x0000000184DA8A70-0x0000000184DA8A80
		internal ushort cNzOuRRFodLwcumimnQZGvgbMZCT { [CompilerGenerated] set; } // 0x0000000184DA8A00-0x0000000184DA8A10
		internal ushort UJTiICQitwbxBiJLohBISjwTSsGgA { [CompilerGenerated] set; } // 0x0000000184DA8A40-0x0000000184DA8A50
		internal ushort QLFvEFUNxbHddWoDVbMfbMgJHwGY { [CompilerGenerated] set; } // 0x0000000184DA8A60-0x0000000184DA8A70
	}

	// Constructors
	internal aHzSDAgzXeTUuXeKeiUwhHjMNyKD(MDBYECqvXkaCiSmYJZjrizfidEbk.cGvTcLBAAcvnQHXapwJLwcbObXDw param_00073aa2); // 0x0000000183BF7B00-0x0000000183BF7CF0
}

internal sealed class yDpFzqLnhRMZnaEyxToARrRqCzAhA : IdxcAbgzMTzxeMxdElxolIcPzwurA // TypeDefIndex: 53892
{
	// Fields
	[CompilerGenerated]
	private YAYhqrEoEUwBEDwatJjdRaWkgjIE KtrCywelWMYGovnGNyfTuHhcTEED; // 0x10
	private readonly string jEvJkTuNlfBPMidphiBpyVyxgLsFA; // 0x18
	private readonly string brGcSQOyREiDQmYUDOShcciGajbhA; // 0x20
	private readonly string rjcjRXWJsuVHiuuMbWUVyfKzkhXp; // 0x28
	private readonly string ZJwfQiCoaeYtHFmrQKiNjNVVsLphA; // 0x30
	private readonly pKfkmqTLezjFVzcIBPtMMyRxABwH CyEkwmcMtvUufoCfpJtPmawKeQmJA; // 0x38
	private readonly string NXxDcchZXlRzcSzqfzhcosPBXKZj; // 0x40
	private readonly int fpnumdzasXtrfmlTBWMzSNwPSsSK; // 0x48
	private readonly int aKKTscABfhwyrwxFghlQKNUgbtRx; // 0x4C
	private readonly bool bjpDBQGTjoYCnueDsSmToesxBPDgA; // 0x50
	private readonly string BMYyLkbUgIoslUdBlINhEVsuPPTs; // 0x58
	private readonly uint KErvOIrbqWcRzFdvFlNPQjkjhEiVA; // 0x60
	private readonly ZmPxydCEzlPckyvKlHErkFzgGOFX AfyPlICvCmpLOvFtPdOMZZSDFQPc; // 0x68
	private readonly aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] IyKCOgGvVVEbpbCJBIpGngMJGAVSB; // 0x70
	private readonly JXtFhzUqozCGLAAgSlsxdSapKppi[] SkYmSIqVvOhcWAqogZEHotpvRhwn; // 0x78
	private qMSJAGnGFztVWGbbMtcbmLOJutTU ZeuUsEorhhylYfoPquBeFdaZXktj; // 0x80
	private qMSJAGnGFztVWGbbMtcbmLOJutTU KQOmbloYOHWxPSNeaaVsONciuDKG; // 0x84
	private nqaKskRUwxbeUaaRxyXfhGNcbkBm nypVyKwJAfrUnujnMJAGrYZqVIVF; // 0x88
	private readonly PaspQuZMWnmetbmgeGoiPkTYOPRh pDVRSzoOfwPGzzpKNEdBbQPegTqpA; // 0x90
	private bool HfNiYUqtUqjAjOqjnLeXEeyAhqUGA; // 0x98
	private QJwvzXmfrDwHfKfbgOEvmUxvMugV<MDBYECqvXkaCiSmYJZjrizfidEbk.NwIzwEuvvoEuXLxYyuEhdQwOWVzA> bUdmXFKFPGoyvtrEBVPRQGIDZIew; // 0xA0
	private QJwvzXmfrDwHfKfbgOEvmUxvMugV<MDBYECqvXkaCiSmYJZjrizfidEbk.CBtraXnwXpmyYfPuzLvlCcBzHcLk> gvjaCufrGQzDKCYlCfCeQoPWowvc; // 0xA8
	private readonly Rewired.Utils.Classes.Utility.SpinLock YxgIkeYKckfdTJuzCnDOmlMznkCSA; // 0xB0
	private readonly Rewired.Utils.Classes.Utility.SpinLock zqosILHtFtMQNCcBqOhqtXiKTkLw; // 0xB8
	private IntPtr jcXzXoMDIZUYBfpdWcaFjtOhSgcT; // 0xC0
	private IntPtr mfPDOGUJxhgDhzvUufBvRDxdEyDp; // 0xC8
	private qJbRNNMrmslroOIsxeQmCcLMXgXZ BPvbtXZURrbcSbaLDSmMGOHoqQah; // 0xD0
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xD4

	// Properties
	public IntPtr GebVmHpsJPFlDsHlVnlvHSQVztdK { get; } // 0x0000000184D892F0-0x0000000184D89300 
	public bool zDVgUhrfAfIgYMdclajHjFgtbNJXA { get; } // 0x000000018ABBD458-0x000000018ABBD5A8 
	public bool akJlAXhUcHpRKZzggAJdBwlcZzEF { get; } // 0x000000018ABBDE04-0x000000018ABBDE54 
	public ZmPxydCEzlPckyvKlHErkFzgGOFX BkPbwOOXbHfrprsNBdoJnAuJgArO { get; } // 0x0000000184D86230-0x0000000184D86240 
	public aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] vnsxdvCfmAdoMUjBnHXzFustAXhEb { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	public JXtFhzUqozCGLAAgSlsxdSapKppi[] NdwbjMyHWBpjFInkCzszCfJNATFjA { get; } // 0x0000000184D862A0-0x0000000184D862B0 
	public pKfkmqTLezjFVzcIBPtMMyRxABwH FgnMidYTRITgpetgeSFsBzmtVqg { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	public string QVMkSNFdzYBkSGGdcYhOkBRBEqJFb { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	public string QXKDwkyKHflTUTDjlilpWKmzxeZi { get; } // 0x00000001811F36E0-0x00000001811F36F0 
	public string YYRyzKMAZwsaThONuxJfKsPrqcLy { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	public int eKPYMUXhTxBdzYqkhjcxbAyVDCugA { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	public int IgAWnnkazSdEUGswQhfizzwTVqAs { get; } // 0x0000000184D86600-0x0000000184D86610 
	public bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; } // 0x0000000184D86800-0x0000000184D86810 
	public string RCkbDMwhfgaXSHlSrLNVbcJiljIPc { get; } // 0x0000000182E56440-0x0000000182E56460 
	public bool BJdhruPWQfbEmflPqJRhZZyRVxDTA { get; } // 0x000000018ABBE9CC-0x000000018ABBEBA4 
	public bool jRIXoCZDUfZanaiKGfTModoQmerH { get; set; } // 0x0000000184D86C50-0x0000000184D86C60 0x000000018ABBC690-0x000000018ABBC6DC

	// Nested types
	private enum qJbRNNMrmslroOIsxeQmCcLMXgXZ // TypeDefIndex: 53890
	{
		Closed = 0,
		Read = 1,
		Write = 2
	}

	private enum XbydykTBZpzAgcAYLLOAdYoJdXOI // TypeDefIndex: 53891
	{
		Success = 0,
		ReadError = 1,
		BufferTooSmall = 2,
		DeviceNotOpen = 3
	}

	// Constructors
	[CustomObfuscation(rename = false)]
	private yDpFzqLnhRMZnaEyxToARrRqCzAhA(); // 0x0000000183BF7CF0-0x0000000183BF7E50
	[CustomObfuscation(rename = false)]
	internal yDpFzqLnhRMZnaEyxToARrRqCzAhA(string param_00073ac2, string param_00073ac3, string param_00073ac4, string param_00073ac5, int param_00073ac6, int param_00073ac7, bool param_00073ac8, string param_00073ac9); // 0x0000000183BF86F0-0x0000000183BF90B0

	// Methods
	public bool xULxbDXErMDWumqPoCklYRksejXD(bool param_00073aca, qMSJAGnGFztVWGbbMtcbmLOJutTU param_00073acb, bool param_00073acc, qMSJAGnGFztVWGbbMtcbmLOJutTU param_00073acd, nqaKskRUwxbeUaaRxyXfhGNcbkBm param_00073ace); // 0x000000018ABBE3A0-0x000000018ABBE9CC
	public void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA(); // 0x000000018ABBB400-0x000000018ABBB544
	private void SKCfCPhVJOMYakuKsOmJaIsjlwUnb(); // 0x000000018ABBC838-0x000000018ABBC898
	public bool EhQhxFweepMpjwazcuSRnFZeQtLc(YWFEqRKsCWKdGhNygVhQhOHuhIISb param_00073acf, int param_00073ad0); // 0x000000018ABBBD44-0x000000018ABBBED4
	public bool aunlOVhpWoQiLKWoGcKSaHLfoXig(out byte[] param_00073ad1, int param_00073ad2, byte param_00073ad3 = 0 /* Metadata: 0x02334118 */); // 0x000000018ABBD97C-0x000000018ABBDDB8
	public string efFcegvAymobYqJrtnRqLeSRXvqm(); // 0x000000018ABBE290-0x000000018ABBE394
	public bool efFcegvAymobYqJrtnRqLeSRXvqm(out byte[] param_00073ad4); // 0x000000018ABBDE54-0x000000018ABBE290
	public string aWBHzUPzbLPVEfFhmcDSkVnnSvncA(); // 0x000000018ABBD5A8-0x000000018ABBD610
	public bool aWBHzUPzbLPVEfFhmcDSkVnnSvncA(out byte[] param_00073ad5); // 0x000000018ABBD610-0x000000018ABBD97C
	public string FpKBQHheYjWwGPXekyQQsMXbqOsJA(); // 0x000000018ABBBF20-0x000000018ABBBF88
	public bool FpKBQHheYjWwGPXekyQQsMXbqOsJA(out byte[] param_00073ad6); // 0x000000018ABBBFF0-0x000000018ABBC318
	public bool cWNDdKjHWcUyzYOsFgZrPjZLiW(IntPtr param_00073ad7, int param_00073ad8, int param_00073ad9, AnBliHBmROTlQRPQOqeIZLIecGsj param_00073ada); // 0x000000018ABBDDE0-0x000000018ABBDE04
	public bool cWNDdKjHWcUyzYOsFgZrPjZLiW(SAcTodLryXZPmeZqsKbnQQxsbBmo param_00073adb, int param_00073adc); // 0x000000018ABBDDB8-0x000000018ABBDDE0
	private static byte[] rBaHfZKawipRifPvkvHJKbEAcqIbA(int param_00073add); // 0x000000018ABBE394-0x000000018ABBE3A0
	private XbydykTBZpzAgcAYLLOAdYoJdXOI CIRcAPhwkFeoRmgwpjkeBCjfAhDcA(IntPtr param_00073ade, int param_00073adf, int param_00073ae0, out YWFEqRKsCWKdGhNygVhQhOHuhIISb.IiHctnpBsQSxJMoMVHTqEaHmqgQd param_00073ae1); // 0x000000018ABBB544-0x000000018ABBBCA8
	private bool ToQFotKWwCgndUaTBToYTmrOovVs(IntPtr param_00073ae2, int param_00073ae3, int param_00073ae4, AnBliHBmROTlQRPQOqeIZLIecGsj param_00073ae5, bool param_00073ae6); // 0x000000018ABBCA9C-0x000000018ABBD3E4
	private void VKxYmTNYVOnOBunPEPJgOAzNeExF(); // 0x00000001841E1670-0x00000001841E1680
	private void RXznckIneLHHZgcoHMWJxWSGcOG(); // 0x000000018ABBC6DC-0x000000018ABBC838
	public void Dispose(); // 0x000000018ABBBCA8-0x000000018ABBBCF8
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABBD3E4-0x000000018ABBD458
	private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073ae7); // 0x000000018ABBC898-0x000000018ABBCA9C
	public static bool FpKBQHheYjWwGPXekyQQsMXbqOsJA(IntPtr param_00073ae8, out byte[] param_00073ae9); // 0x000000018ABBC318-0x000000018ABBC690
	public static string FpKBQHheYjWwGPXekyQQsMXbqOsJA(IntPtr param_00073aea); // 0x000000018ABBBF88-0x000000018ABBBFF0
	public static IntPtr TtLPjCoOesFjwMuQyzeJompLoOlU(string param_00073aeb, qMSJAGnGFztVWGbbMtcbmLOJutTU param_00073aec, uint param_00073aed, nqaKskRUwxbeUaaRxyXfhGNcbkBm param_00073aee); // 0x0000000183BF9160-0x0000000183BF9270
	public static void IjwGSjYKZqScbuJEXEeygNHIrhKN(IntPtr param_00073aef); // 0x0000000183BF8690-0x0000000183BF86F0
	public static void FddmNUFAJGTaeGitIyWbBgVFrpjP(IntPtr param_00073af0); // 0x0000000183BF85B0-0x0000000183BF8630
	private static void EvQkruhFtUPkWpfhSyZahjeJteKb(IntPtr param_00073af1); // 0x000000018ABBBED4-0x000000018ABBBF20
	private static byte[] EBVcyhHKcGqGprrNlMmPYhzuwScN(int param_00073af2); // 0x000000018ABBBCF8-0x000000018ABBBD44
	public static pKfkmqTLezjFVzcIBPtMMyRxABwH iLsCnIghhhFKLfgeJKsjceaxsTLCB(IntPtr param_00073af3); // 0x0000000183BF9390-0x0000000183BF94F0
	public static ZmPxydCEzlPckyvKlHErkFzgGOFX uEAXsIjxPmFhXTzVAoDinwENKsxP(IntPtr param_00073af4); // 0x0000000183BFA520-0x0000000183BFADE0
	public static aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] MzZjSlZlkKsGUFYXBKcrVLMLrije(IntPtr param_00073af5, short param_00073af6, short param_00073af7); // 0x0000000183BF94F0-0x0000000183BF9C70
	public static JXtFhzUqozCGLAAgSlsxdSapKppi[] dgkbLUUyrEuMcEjmmFDNcXLvCQvrA(IntPtr param_00073af8, short param_00073af9, short param_00073afa); // 0x0000000183BF9C70-0x0000000183BFA450
}

internal class pKfkmqTLezjFVzcIBPtMMyRxABwH // TypeDefIndex: 53893
{
	// Fields
	[CompilerGenerated]
	private int wwylsiIyBycQLoNkYeZeciBEzMTW; // 0x10
	[CompilerGenerated]
	private int TgMPcOKbNumEAmdlgItweDiAhAOz; // 0x14
	[CompilerGenerated]
	private int ibGcLTkPNvWKTVoXeaycynboufEbA; // 0x18
	[CompilerGenerated]
	private string qEpmBaivszQbPEohxLeayileHwBb; // 0x20
	[CompilerGenerated]
	private string MvURDPGVAnbNPHokVbYnEDrMWSGAA; // 0x28

	// Properties
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
	private int yBrHttIvbAPDTFKFjBZTKMchpxWn { [CompilerGenerated] set; } // 0x00000001811EF9B0-0x00000001811EF9C0
	public string TnSIgOtQQQCxeLXdYqAmhJEQAWjv { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
	public string KUxPfqLSyZJZSINawevgTrMiCXuD { [CompilerGenerated] set; } // 0x0000000182FDB880-0x0000000182FDB890

	// Constructors
	internal pKfkmqTLezjFVzcIBPtMMyRxABwH(MDBYECqvXkaCiSmYJZjrizfidEbk.GdZTshfUFywPkphGdVzwMUmXwiZb param_00073afb); // 0x0000000183BFB070-0x0000000183BFB140
}

internal class ZmPxydCEzlPckyvKlHErkFzgGOFX // TypeDefIndex: 53894
{
	// Fields
	[CompilerGenerated]
	private short rqZHdIAsEIlrdlDQBtmUhaxPNUBB; // 0x10
	[CompilerGenerated]
	private short LUMuzAbrWnMHseXKgyELDjFGWJSj; // 0x12
	[CompilerGenerated]
	private short WmspeFIJdhtSwVMHBEivGtFuuWyT; // 0x14
	[CompilerGenerated]
	private short zjThqJligFfNygtMCbJvAZtEOeKrb; // 0x16
	[CompilerGenerated]
	private short aIvEuuCgdDfiqkELURdkilpwBfMWA; // 0x18
	[CompilerGenerated]
	private short[] pgBuuCeKSuTAcbjapyUZImCdAVNiA; // 0x20
	[CompilerGenerated]
	private short asPaXdXehQlvrVhDRwSwHZMjfQMP; // 0x28
	[CompilerGenerated]
	private short aYwAjSdJmQkLhqeyVXyFTFOzDHEC; // 0x2A
	[CompilerGenerated]
	private short fXlqZvTpHEHnddVJNKFDtRiWBuRR; // 0x2C
	[CompilerGenerated]
	private short QrIBKADRgiirRzDoQCPmCXnzgRMuA; // 0x2E
	[CompilerGenerated]
	private short WBlqNZDtLjdWEecYJeuGJSPLdNEd; // 0x30
	[CompilerGenerated]
	private short ZADFfKuUsvYzazRjiUDPzFStaywD; // 0x32
	[CompilerGenerated]
	private short mIxRecduYGGwnRXqoccKsAstOIDK; // 0x34
	[CompilerGenerated]
	private short XjowNyiINaenNwhREeLmJTsyOLZZA; // 0x36
	[CompilerGenerated]
	private short tMVeHZvHFCYmhoFnucARqrefjOXe; // 0x38
	[CompilerGenerated]
	private short ZRgddIBNtsoJSMltJbMEcykMQkkqA; // 0x3A

	// Properties
	public short ZhwNBMzYOdcsywMxxqnQBgbeZIaX { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D96190-0x0000000184D961A0 0x0000000184D94F60-0x0000000184D94F70
	public short NDweLaWskzoBwpWJxCWuzQStzdYi { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA8BA0-0x0000000184DA8BB0 0x0000000184DA8B80-0x0000000184DA8B90
	public short eWcIGAyfISkTRCxwLEzYDwBhxXNT { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D96D00-0x0000000184D96D10 0x0000000184DA8B00-0x0000000184DA8B10
	public short twWgyKYIignftDZJqVYymJvnhZLO { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D993B0-0x0000000184D993C0 0x0000000184DA8A80-0x0000000184DA8A90
	public short FGGPXeutjDcGGYJFjFtImAsQZSIC { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA8B70-0x0000000184DA8B80 0x0000000184DA8AB0-0x0000000184DA8AC0
	private short[] uEWSYFkyRUKNddSuwNCCuQBguizT { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
	private short zEhcdcxrhEhqCSdWJNEpaIvoFigJ { [CompilerGenerated] set; } // 0x0000000184DA8B10-0x0000000184DA8B20
	public short lQXkNeVylOntJdOrOVkFESIdghWt { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA8B90-0x0000000184DA8BA0 0x0000000184DA8BC0-0x0000000184DA8BD0
	public short vQZsVQHIJiHngByYIlmtSFLxlgwi { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E610-0x0000000184D9E620 0x0000000184DA8B40-0x0000000184DA8B50
	private short EyRKBObXUWcxCdXUNGOOucVdSnbE { [CompilerGenerated] set; } // 0x0000000184DA8B20-0x0000000184DA8B30
	private short sBCDQUIDvFWgcDrQNjSppTLxUwQE { [CompilerGenerated] set; } // 0x0000000184DA8B60-0x0000000184DA8B70
	private short iiBypvdQtOAZmaprrbycWFwNeYOVA { [CompilerGenerated] set; } // 0x0000000184DA8B50-0x0000000184DA8B60
	private short rLiXPNunmKNJgUDKdNtNLzzfRvgv { [CompilerGenerated] set; } // 0x0000000184DA89A0-0x0000000184DA89B0
	private short krUWCsmFkCCaniEjibwlkSFwqXxHA { [CompilerGenerated] set; } // 0x0000000184DA89C0-0x0000000184DA89D0
	private short aXlxbZdHqFFqrGzexQagmVHTilEDA { [CompilerGenerated] set; } // 0x0000000184DA8B30-0x0000000184DA8B40
	private short RcJPzQHLaLlIsNMwUGthGWLbZmgIA { [CompilerGenerated] set; } // 0x0000000184DA8BB0-0x0000000184DA8BC0

	// Constructors
	internal ZmPxydCEzlPckyvKlHErkFzgGOFX(MDBYECqvXkaCiSmYJZjrizfidEbk.wVeMkOOBFiFZpAAnIEqQLLFkoZNAA param_00073b01); // 0x0000000183BFAFC0-0x0000000183BFB070
}

internal class YWFEqRKsCWKdGhNygVhQhOHuhIISb // TypeDefIndex: 53896
{
	// Fields
	[CompilerGenerated]
	private byte[] mRldTjdYZCENIUzMJDPMOOoyxSonA; // 0x10
	[CompilerGenerated]
	private IiHctnpBsQSxJMoMVHTqEaHmqgQd ErNcmAYszzaAphAnutJlcIjkyYuq; // 0x18

	// Properties
	public byte[] thLICHPmpalmfjGmuMkilAKwymgl { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	private IiHctnpBsQSxJMoMVHTqEaHmqgQd OuXZCbJoDUmyQUJlOUEYTbvwsriI { [CompilerGenerated] set; } // 0x00000001811EF9B0-0x00000001811EF9C0

	// Nested types
	public enum IiHctnpBsQSxJMoMVHTqEaHmqgQd // TypeDefIndex: 53895
	{
		Success = 0,
		WaitTimedOut = 1,
		WaitFail = 2,
		NoDataRead = 3,
		ReadError = 4,
		NotConnected = 5,
		WaitIOCompletion = 6,
		WaitAbandoned = 7
	}

	// Constructors
	public YWFEqRKsCWKdGhNygVhQhOHuhIISb(int param_00073b12); // 0x000000018ABB7C9C-0x000000018ABB7CF8

	// Methods
	public void mnOZfTJZaPJhBHSiKkLNiAfZLffw(byte[] param_00073b15, IiHctnpBsQSxJMoMVHTqEaHmqgQd param_00073b16); // 0x0000000183B46FF0-0x0000000183B47040
}

internal class PaspQuZMWnmetbmgeGoiPkTYOPRh // TypeDefIndex: 53899
{
	// Fields
	[CompilerGenerated]
	private UCdwqJeASphJMbzucKJohLzKNEqD aUuoQzbZBRJjbeeCFhvLcBhACrrT; // 0x10
	[CompilerGenerated]
	private SwCsQrkBjVSTgqqRcJuRjwBjNmaf KtrCywelWMYGovnGNyfTuHhcTEED; // 0x18
	private readonly yDpFzqLnhRMZnaEyxToARrRqCzAhA BfpiOvUxdZhCNWfSeVTpTeEyaaiP; // 0x20
	private bool xqSeFqKdXmGZPgLiEexsGKDyWQgdA; // 0x28

	// Events
	public event UCdwqJeASphJMbzucKJohLzKNEqD aUuoQzbZBRJjbeeCFhvLcBhACrrT {
		add; // 0x0000000183BF8470-0x0000000183BF8510
		remove; // 0x000000018ABB689C-0x000000018ABB6930
	}
	public event SwCsQrkBjVSTgqqRcJuRjwBjNmaf KtrCywelWMYGovnGNyfTuHhcTEED {
		add; // 0x0000000183BF8510-0x0000000183BF85B0
		remove; // 0x000000018ABB69CC-0x000000018ABB6A60
	}

	// Nested types
	public delegate void UCdwqJeASphJMbzucKJohLzKNEqD(); // TypeDefIndex: 53897; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void SwCsQrkBjVSTgqqRcJuRjwBjNmaf(); // TypeDefIndex: 53898; 0x00000001853DEDB8-0x00000001853DEDC8

	// Constructors
	public PaspQuZMWnmetbmgeGoiPkTYOPRh(yDpFzqLnhRMZnaEyxToARrRqCzAhA param_00073b1b); // 0x0000000185390F40-0x0000000185390F50

	// Methods
	public void lBMTbRuwRfNSwCPcHnAiVMhJqLHQ(); // 0x000000018ABB6A60-0x000000018ABB6B20
	private void WQhldserNbWnudEAZYBcioElozWr(); // 0x000000018ABB6930-0x000000018ABB69CC
	private static void obpeZCglRVGqGSqZFghdtHEHdLYSA(IAsyncResult param_00073b1c); // 0x000000018ABB6B20-0x000000018ABB6B84
}

internal class prXDGPaiLRznhHdqRYUShDUjqIyH // TypeDefIndex: 53906
{
	// Fields
	private static Guid orFmBWnFhrAmrGbePUDhMXIWYfFaA; // 0x00
	private static List<yDpFzqLnhRMZnaEyxToARrRqCzAhA> hrFhAhGXHZENxLPgvRKZVpglSDwV; // 0x10
	private static List<cQuuLrgeChfSTCfVgQjFhkvLyfEuA> tbIeshZMEQcBRbCfTjNLpjPryAxjA; // 0x18
	private static List<IYkFHeDTeaiIvMIzYRFbPiZVuQFL> fzjnbtogSuusTaSFgJiRzuZFIAjM; // 0x20
	private static List<PUUjROsMtnhbqLEaBbcdiryfdlYVA> PorAGhsKVWIHvhRbsNMiGhYFhIqf; // 0x28
	private static yqCthwNGAZgagjDBQbkNEzFfVZWu.AInQCDdqSLTTWRljCHGQhayircJNA kFHTekevXPwXAQjNzgsSngCxmyRT; // 0x30
	private static yqCthwNGAZgagjDBQbkNEzFfVZWu.ygRJphukthbSeHYUTNVFxMSmRNEw auecMXUVorcCpGVFLRybIupSzmhqA; // 0x48
	private static NativeBuffer qPvwreSiMPHTVHFnILkVMbgTdVckA; // 0x88

	// Properties
	private static Guid pAUPSOxlCkARNioNgUKfLJSUTAsb { get; } // 0x00000001849C9560-0x00000001849C96A0 

	// Nested types
	public struct IYkFHeDTeaiIvMIzYRFbPiZVuQFL // TypeDefIndex: 53900
	{
		// Fields
		public string uHVFxYdqpgjkdgNAHnKeGPzZhuZpb; // 0x00
		public string BEEVfqYuoDlzPMtIkkcNBsHBsvry; // 0x08
		public string QXKDwkyKHflTUTDjlilpWKmzxeZi; // 0x10
		public string ryYCGDiFKHbCVCRTEIIcHhWPnpxTb; // 0x18
		public string YYRyzKMAZwsaThONuxJfKsPrqcLy; // 0x20
		public string hdyeVnGBkdgGBgilyBhrVrxcQSQLA; // 0x28
		public int eKPYMUXhTxBdzYqkhjcxbAyVDCugA; // 0x30
		public int IgAWnnkazSdEUGswQhfizzwTVqAs; // 0x34
		public bool tLrAyVcCEurtcBKhkxyJlRolMCZB; // 0x38
		public string RCkbDMwhfgaXSHlSrLNVbcJiljIPc; // 0x40

		// Constructors
		public IYkFHeDTeaiIvMIzYRFbPiZVuQFL(string param_00073b53, string param_00073b54, string param_00073b55, string param_00073b56, string param_00073b57, bool param_00073b58, string param_00073b59); // 0x00000001835AAA00-0x00000001835AAAC0

		// Methods
		private void XnCEiShJkGvlKpNnqFurhkzzhMGd(); // 0x0000000184433890-0x00000001844339C0
	}

	private struct cQuuLrgeChfSTCfVgQjFhkvLyfEuA // TypeDefIndex: 53901
	{
		// Fields
		public int EEjhUIhIcsWLXXeGfefLxEjqKdgQ; // 0x00
		public uint DoaPxMFAmfwLwshNWtiPzjXtBZNn; // 0x04
		public string hdyeVnGBkdgGBgilyBhrVrxcQSQLA; // 0x08

		// Constructors
		public cQuuLrgeChfSTCfVgQjFhkvLyfEuA(int param_00073b5a, uint param_00073b5b, string param_00073b5c); // 0x0000000185395DAC-0x0000000185395DC0
	}

	private struct PUUjROsMtnhbqLEaBbcdiryfdlYVA // TypeDefIndex: 53902
	{
		// Fields
		public readonly uint DoaPxMFAmfwLwshNWtiPzjXtBZNn; // 0x00
		public readonly string SvmsnETUSlePEWPKjGqPgpeaQhBCb; // 0x08

		// Constructors
		public PUUjROsMtnhbqLEaBbcdiryfdlYVA(uint param_00073b5d, string param_00073b5e); // 0x000000018ABB6834-0x000000018ABB689C
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class iHTcxnFGZEknIwdPyWYiSWhasdfr // TypeDefIndex: 53903
	{
		// Fields
		public static readonly iHTcxnFGZEknIwdPyWYiSWhasdfr __9; // 0x00
		public static Func<IYkFHeDTeaiIvMIzYRFbPiZVuQFL, yDpFzqLnhRMZnaEyxToARrRqCzAhA> __9__15_0; // 0x08
		public static Func<IYkFHeDTeaiIvMIzYRFbPiZVuQFL, yDpFzqLnhRMZnaEyxToARrRqCzAhA> __9__16_1; // 0x10

		// Constructors
		static iHTcxnFGZEknIwdPyWYiSWhasdfr(); // 0x0000000184D3E890-0x0000000184D3E8F0
		public iHTcxnFGZEknIwdPyWYiSWhasdfr(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal yDpFzqLnhRMZnaEyxToARrRqCzAhA JyWLrEfuZufMatcdBHYODKYexGNpA(IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_00073b5f); // 0x0000000183BF7A00-0x0000000183BF7B00
		internal yDpFzqLnhRMZnaEyxToARrRqCzAhA llUwWOhSJpXGABMigmacsomCTqRf(IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_00073b60); // 0x000000018ABB9044-0x000000018ABB912C
	}

	[CompilerGenerated]
	private sealed class coBnyIRvfDSGVhYitTrMKrmmJyes // TypeDefIndex: 53904
	{
		// Fields
		public string CusHjDRpgtyRVMdEIQNEUqckZRHS; // 0x10
		public StringComparison yLuIpNZNhUrDNMLHWsApTJYEMyAs; // 0x18

		// Constructors
		public coBnyIRvfDSGVhYitTrMKrmmJyes(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal bool gYfiFoTNSByGDnTRoiIOtcwsYWIJ(IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_00073b61); // 0x00000001847DC790-0x00000001847DC7C0
	}

	[CompilerGenerated]
	private sealed class iFYZNmPpSepatsZnFmYSKeNoIeeu // TypeDefIndex: 53905
	{
		// Fields
		public string CusHjDRpgtyRVMdEIQNEUqckZRHS; // 0x10

		// Constructors
		public iFYZNmPpSepatsZnFmYSKeNoIeeu(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal bool itPeTpKIPoEZdFubjsTtBhNBjRwT(IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_00073b62); // 0x000000018ABB8EB4-0x000000018ABB8EC8
	}

	// Constructors
	static prXDGPaiLRznhHdqRYUShDUjqIyH(); // 0x0000000183A43140-0x0000000183A434E0

	// Methods
	public static bool akJlAXhUcHpRKZzggAJdBwlcZzEF(string param_00073b21); // 0x000000018ABB9FAC-0x000000018ABBA1E4
	public static IList<IYkFHeDTeaiIvMIzYRFbPiZVuQFL> ZsFKVtoqECXqMobddXTHIzFkgTDf(); // 0x0000000183A44550-0x0000000183A44590
	public static yDpFzqLnhRMZnaEyxToARrRqCzAhA ftozITswzymIijifTFKqaNvpMxYe(IList<IYkFHeDTeaiIvMIzYRFbPiZVuQFL> param_00073b22, string param_00073b23, StringComparison param_00073b24); // 0x0000000183A44670-0x0000000183A447D0
	public static yDpFzqLnhRMZnaEyxToARrRqCzAhA lSlsrqNndcLyPhsxkdXsTaZoJcFm(IYkFHeDTeaiIvMIzYRFbPiZVuQFL param_00073b25); // 0x0000000183A447D0-0x0000000183A448F0
	public static yDpFzqLnhRMZnaEyxToARrRqCzAhA RDxaMMdZGrVvyrpeXUOWDMjjtQBp(string param_00073b26); // 0x000000018ABB9F50-0x000000018ABB9FAC
	public static IEnumerable<yDpFzqLnhRMZnaEyxToARrRqCzAhA> EHzJeyivDsPTLTBcjaniESaGLkps(); // 0x0000000183A40EE0-0x0000000183A41020
	public static IEnumerable<yDpFzqLnhRMZnaEyxToARrRqCzAhA> EHzJeyivDsPTLTBcjaniESaGLkps(string param_00073b27); // 0x000000018ABB9800-0x000000018ABB99C0
	public static bool BFfsjWiEpJdOjSFSiJcagkWdgaVe(); // 0x0000000183A40C90-0x0000000183A40EE0
	public static int SWbYOscVZJwijEvqMgmjujNLcsHr(); // 0x0000000183A44B10-0x0000000183A44B70
	public static int SWbYOscVZJwijEvqMgmjujNLcsHr(ref yqCthwNGAZgagjDBQbkNEzFfVZWu.AInQCDdqSLTTWRljCHGQhayircJNA param_00073b28, NativeBuffer param_00073b29); // 0x0000000183A44B70-0x0000000183A44BD0
	private static IList<IYkFHeDTeaiIvMIzYRFbPiZVuQFL> xmpJfrrdjRmhDPmzAXFLDvDVEGWs(); // 0x00000001835AAAC0-0x00000001835AB1C0
	private static void LhbNLblETIcsVFiyTBeldyFEHJVAA(List<cQuuLrgeChfSTCfVgQjFhkvLyfEuA> param_00073b2a); // 0x0000000183E048B0-0x0000000183E04C30
	private static List<PUUjROsMtnhbqLEaBbcdiryfdlYVA> hAzrRYoAQCAzVlmESxUYeppeFjiHA(List<PUUjROsMtnhbqLEaBbcdiryfdlYVA> param_00073b2b); // 0x000000018ABBA444-0x000000018ABBA5F8
	private static List<uint> ZaAiEABFIHOILIBTghxOurobuiQNA(uint param_00073b2c); // 0x0000000183E05500-0x0000000183E056E0
	private static List<uint> qClaPQIpuNiUBudQkNlzytTaNVAL(uint param_00073b2d); // 0x0000000183E056E0-0x0000000183E05840
	private static string gpKudyFUqpLILrJBheYPpiNAaRVb(uint param_00073b2e); // 0x00000001835ABD20-0x00000001835ABF30
	private static void OwwQDpGojKDBAmTtwtniZPNtpmMr(uint param_00073b2f, ref List<PUUjROsMtnhbqLEaBbcdiryfdlYVA> param_00073b30, out bool param_00073b31, out string param_00073b32); // 0x0000000184424210-0x00000001844242F0
	private static bool hsRlUUaETREUjXzkuqivbvLsWfLP(uint param_00073b33, ref List<PUUjROsMtnhbqLEaBbcdiryfdlYVA> param_00073b34, out bool param_00073b35, out uint param_00073b36); // 0x00000001844242F0-0x00000001844243B0
	private static bool TSgPgCsRkdGmyzuupaPfboHknHCcA(uint param_00073b37, string param_00073b38, out string param_00073b39, out uint param_00073b3a); // 0x00000001835ABB50-0x00000001835ABCD0
	private static bool gtGWbLOgbGxPMAgkCHDWcyCucxqJA(string param_00073b3b, out string param_00073b3c); // 0x000000018ABBA34C-0x000000018ABBA444
	private static bool eDyFVubmhWaFrouRpboBKdrfJKrL(uint param_00073b3d, string param_00073b3e, out uint param_00073b3f); // 0x000000018ABBA1E4-0x000000018ABBA34C
	private static bool NbqWRqtzdNlHvUvcOKFBldUZeUICA(string param_00073b40, bool param_00073b41 = true /* Metadata: 0x02334128 */); // 0x000000018ABB9A14-0x000000018ABB9F50
	private static MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB RpcHbtTsDvqNIwcmrikEejKmglMf(); // 0x0000000183E04850-0x0000000183E048B0
	private static string WSbygJHhAOkGYSkBTqfQVaLdTwWD(IntPtr param_00073b42, MDBYECqvXkaCiSmYJZjrizfidEbk.OdnntAHntokWiUdDHtrlcobDeFoF param_00073b43); // 0x00000001835AB2F0-0x00000001835AB400
	private static string tRUnFgKTtCscuSPvKgSIaAABMVpL(IntPtr param_00073b44, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b45); // 0x00000001835AB400-0x00000001835AB520
	private static string EEmmwDJRxHVvCIDUZHfIeXTDuzij(IntPtr param_00073b46, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b47); // 0x000000018ABB97AC-0x000000018ABB9800
	private static string ENzahFoqYbHqgQWFcUBGCjRzGsvP(IntPtr param_00073b48, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b49); // 0x000000018ABB99C0-0x000000018ABB9A14
	private static string UMFVPIxbQrSCNKcyITghJqcjOoXi(IntPtr param_00073b4a, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b4b); // 0x0000000183E04C30-0x0000000183E04CA0
	private static string DJGaEpIjHmBElJmHZJsXFXBAHZdCb(IntPtr param_00073b4c, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b4d); // 0x00000001835AB280-0x00000001835AB2F0
	private static string pOHzpBxHEcNSmGKovYmuTBCmjdhC(IntPtr param_00073b4e, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b4f, int param_00073b50); // 0x00000001835AB6D0-0x00000001835AB890
	private static string bggqCanFRkzuRDWxQjbXwQcodoiH(IntPtr param_00073b51, ref MDBYECqvXkaCiSmYJZjrizfidEbk.ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073b52); // 0x00000001835AC170-0x00000001835AC2D0
}

internal class JXtFhzUqozCGLAAgSlsxdSapKppi // TypeDefIndex: 53909
{
	// Fields
	[CompilerGenerated]
	private ushort LUMuzAbrWnMHseXKgyELDjFGWJSj; // 0x10
	[CompilerGenerated]
	private byte WzclJqZLidxBrDrAUUtbEkQsHyfb; // 0x12
	[CompilerGenerated]
	private bool SQsiEzIScYlDgyeJZYkJrphFbfFA; // 0x13
	[CompilerGenerated]
	private ushort UciwgiHoaDCynyCDvfZYlmwHppbc; // 0x14
	[CompilerGenerated]
	private ushort forBhCFfqJjrxPbbvNnWfAgokqQiA; // 0x16
	[CompilerGenerated]
	private ushort OWRFvAcVlplTTYSiWfbJJScBJBbWA; // 0x18
	[CompilerGenerated]
	private ushort VwZBUnXyeKAFQrsHkhTGLEwuSiGM; // 0x1A
	[CompilerGenerated]
	private bool oxJJoRhJDQEZFIkcPpmhSurGTbHT; // 0x1C
	[CompilerGenerated]
	private bool kKMiOapOHoQgXWVHoCAWkUKuQDOH; // 0x1D
	[CompilerGenerated]
	private bool rDEEPiMvsXpABkYMdFpbjtsyAZjC; // 0x1E
	[CompilerGenerated]
	private bool VUsIgdVRQZOEKTRchjuMDKTZEKyz; // 0x1F
	[CompilerGenerated]
	private bool MFyMKQAtNaUJRapbHiSyDZcZgqmV; // 0x20
	[CompilerGenerated]
	private byte pgBuuCeKSuTAcbjapyUZImCdAVNiA; // 0x21
	[CompilerGenerated]
	private ushort XDKwPupWhimgMQIYDyStjXfVlpgu; // 0x22
	[CompilerGenerated]
	private ushort oScFWXbxjuVECPwoUYHJCNUJZitJA; // 0x24
	[CompilerGenerated]
	private ushort[] YDyCCYTGHQgQydQRqDxUiZdADHjxA; // 0x28
	[CompilerGenerated]
	private uint zbCaocfBcgPJVHdEEALtHuOjSrWp; // 0x30
	[CompilerGenerated]
	private uint fHDbWAGfaFeUVgNpaedUpWJwkUUDc; // 0x34
	[CompilerGenerated]
	private int zIfNNaDDimKwuMNneiIQvfuTPjwj; // 0x38
	[CompilerGenerated]
	private int fRLcwShnrCUiCjruKDKbBfdiqGMiA; // 0x3C
	[CompilerGenerated]
	private int BLShlkRNcujUYQSbVKLOQXnvKVei; // 0x40
	[CompilerGenerated]
	private int EYHgHIkVEVXOczdWYvWSmjbDmaVG; // 0x44
	[CompilerGenerated]
	private xzMuoUlvKGCyuZtipJBdZbVUadLB GFPiBctkpLainibUgLYxBOCTbeWVA; // 0x48
	[CompilerGenerated]
	private FTOiINMsdGsAPJJyCRstLZPtRyob wkXxVtcCQqSjsHMkInyHuMXAVkrL; // 0x58

	// Properties
	public ushort NDweLaWskzoBwpWJxCWuzQStzdYi { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D96190-0x0000000184D961A0 0x0000000184D94F60-0x0000000184D94F70
	public byte yQxQgOQNMVMVBtcqgArgADGYErtCb { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88390-0x0000000184D883A0 0x0000000184DA0900-0x0000000184DA0910
	private bool vtTDydgHKBpOnHSyNFEsNAlyQxfS { [CompilerGenerated] set; } // 0x0000000184DA8AE0-0x0000000184DA8AF0
	private ushort EVOgATFTRXRYYHBhTtlQzWYqqwdA { [CompilerGenerated] set; } // 0x0000000184DA8B00-0x0000000184DA8B10
	public ushort pHcUlKlzzchyOdBayWGzpHfvaXne { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D993B0-0x0000000184D993C0 0x0000000184DA8A80-0x0000000184DA8A90
	private ushort OZGNGboMcWuoFBqTPiRpwosbEqYM { [CompilerGenerated] set; } // 0x0000000184DA8AB0-0x0000000184DA8AC0
	private ushort xfxgDPRowhYBpUmBfcwmlmnSOAOk { [CompilerGenerated] set; } // 0x0000000184DA8AF0-0x0000000184DA8B00
	public bool BfopjfztUWmuPqlPQddPxAYCUqBv { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
	private bool hMRiaanusLpZjoDmjlMCDmUAeXvt { [CompilerGenerated] set; } // 0x0000000184D89610-0x0000000184D89620
	private bool OrluHimCvJfxNzFNtqGOaUVOaKzG { [CompilerGenerated] set; } // 0x0000000184D89630-0x0000000184D89640
	private bool pBNaQqqwjWuTtRxKaIqRAoduhvcR { [CompilerGenerated] set; } // 0x0000000184D89620-0x0000000184D89630
	private bool lhcFgIyotHiTDfPsiWQeKyQqtxTO { [CompilerGenerated] set; } // 0x0000000184D866D0-0x0000000184D866E0
	private byte uEWSYFkyRUKNddSuwNCCuQBguizT { [CompilerGenerated] set; } // 0x0000000184D86860-0x0000000184D86870
	public ushort rTIQSbqOnUSmuevmXNIAdLXhUEc { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA8AD0-0x0000000184DA8AE0 0x0000000184DA8AC0-0x0000000184DA8AD0
	public ushort VtyHLJteBwuRwyyuieGwmtYecGPq { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA8A90-0x0000000184DA8AA0 0x0000000184DA8AA0-0x0000000184DA8AB0
	private ushort[] YGNxrFfotADbwHHXFCFbjPccoxEvb { [CompilerGenerated] set; } // 0x0000000182FDB880-0x0000000182FDB890
	public uint CfHaeRicZteSoguHdEQyFjSdoVhgd { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	public uint bFwqshEICTItwIvQnTVtjCmEEhPOA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
	public int yuuLeDEnXHQWGYlbsuwXHCpOexoCA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
	public int UIOacgZTgkjwtdxToaahjmcjPOooc { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
	public int iWOAtDfVIEwlveRsEXZbFHNDedliA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
	public int GgFHkuuBxplJABXwhoHoystWwxHJ { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
	public xzMuoUlvKGCyuZtipJBdZbVUadLB rWfPOTkywVVLkhergznPfrOaXcQA { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FD50-0x0000000184D8FD60 0x0000000184D91540-0x0000000184D91550
	public FTOiINMsdGsAPJJyCRstLZPtRyob vLEBkPDtgrvJRhDPlMNfHsyfaKXnB { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87E00-0x0000000184D87E10 0x0000000184DA61E0-0x0000000184DA61F0

	// Nested types
	public struct xzMuoUlvKGCyuZtipJBdZbVUadLB // TypeDefIndex: 53907
	{
		// Fields
		[CompilerGenerated]
		private ushort ELlaRTvgVEjHUpvxmdDBwXeTSSTQ; // 0x00
		[CompilerGenerated]
		private ushort CzVzQlBcLcNYFWYGMkLXwsOeCSJd; // 0x02
		[CompilerGenerated]
		private ushort uAGyARYkWHnrFXAhRigGLRibFkjL; // 0x04
		[CompilerGenerated]
		private ushort NjtCjUKilYJACojqZjBqodUHaCKjb; // 0x06
		[CompilerGenerated]
		private ushort bpcVsvwNMfufGuCSrbjRblHNksvB; // 0x08
		[CompilerGenerated]
		private ushort dbAGmWdFkXkDNNWbQZcdkYODQHYMA; // 0x0A
		[CompilerGenerated]
		private ushort USZdQxjjysNAEGyVRPBVhvvGHSqAb; // 0x0C
		[CompilerGenerated]
		private ushort TvxuXikcWoBDNuALcEEQPyyqnVZm; // 0x0E

		// Properties
		public ushort ItMgALtDaiVTFjHhSTsudMjbbXEbA { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184D87160-0x0000000184D87170
		public ushort vNUrgCyNhiUnLsFVTLYUvLEjfntu { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87610-0x0000000184D87620 0x0000000184DA8A10-0x0000000184DA8A20
		internal ushort DwlIhRdQEPDZMlYEjVTJrPCtauNx { [CompilerGenerated] set; } // 0x0000000184DA8A50-0x0000000184DA8A60
		internal ushort bxWgvYsqzYEOyNWKUFzImHLcCmcK { [CompilerGenerated] set; } // 0x0000000184DA8A20-0x0000000184DA8A30
		internal ushort EvUdqujojeMZuETniwnoKWXjuZNWB { [CompilerGenerated] set; } // 0x0000000184DA8A70-0x0000000184DA8A80
		internal ushort hEKMVDtZDkgVmvdcqcPlfCxPVjok { [CompilerGenerated] set; } // 0x0000000184DA8A00-0x0000000184DA8A10
		public ushort oQpvoKPnebMtUqjKGMoXpqAsQVCj { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA8A30-0x0000000184DA8A40 0x0000000184DA8A40-0x0000000184DA8A50
		public ushort JxxAHZCnxiMJSoWYGfKVGIrCMVJIA { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA8BD0-0x0000000184DA8BE0 0x0000000184DA8A60-0x0000000184DA8A70
	}

	public struct FTOiINMsdGsAPJJyCRstLZPtRyob // TypeDefIndex: 53908
	{
		// Fields
		[CompilerGenerated]
		private ushort rqZHdIAsEIlrdlDQBtmUhaxPNUBB; // 0x00
		[CompilerGenerated]
		private ushort ffvRVzEZhpaGpDkdUuVBEZWVCnaj; // 0x02
		[CompilerGenerated]
		private ushort twRDpeslgSNYPMqaXtdUigIpjUcv; // 0x04
		[CompilerGenerated]
		private ushort YDyCCYTGHQgQydQRqDxUiZdADHjxA; // 0x06
		[CompilerGenerated]
		private ushort FYgTlKshxqlWWYfPpJUsQgUlCgcq; // 0x08
		[CompilerGenerated]
		private ushort BYdhqmBDSYELKztdVnjtkCPhFuuFb; // 0x0A
		[CompilerGenerated]
		private ushort RDsEWTKHLTsFISjggDUeeEzjMHrU; // 0x0C
		[CompilerGenerated]
		private ushort VmjYZskzCwrkfFwqWiukRllVDVxW; // 0x0E

		// Properties
		public ushort ZhwNBMzYOdcsywMxxqnQBgbeZIaX { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184D87160-0x0000000184D87170
		internal ushort rfcVzyntsQRBZuQsphQIAieNMatf { [CompilerGenerated] set; } // 0x0000000184DA8A10-0x0000000184DA8A20
		internal ushort UGSHpKjCSetxyyuIPUDWVEYHBlFD { [CompilerGenerated] set; } // 0x0000000184DA8A50-0x0000000184DA8A60
		internal ushort YGNxrFfotADbwHHXFCFbjPccoxEvb { [CompilerGenerated] set; } // 0x0000000184DA8A20-0x0000000184DA8A30
		internal ushort iBWeYzDXeUpHNJXfgECfOIwdFzByA { [CompilerGenerated] set; } // 0x0000000184DA8A70-0x0000000184DA8A80
		internal ushort cNzOuRRFodLwcumimnQZGvgbMZCT { [CompilerGenerated] set; } // 0x0000000184DA8A00-0x0000000184DA8A10
		public ushort UJTiICQitwbxBiJLohBISjwTSsGgA { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA8A30-0x0000000184DA8A40 0x0000000184DA8A40-0x0000000184DA8A50
		internal ushort QLFvEFUNxbHddWoDVbMfbMgJHwGY { [CompilerGenerated] set; } // 0x0000000184DA8A60-0x0000000184DA8A70
	}

	// Constructors
	internal JXtFhzUqozCGLAAgSlsxdSapKppi(MDBYECqvXkaCiSmYJZjrizfidEbk.HZHOCcmbYJxOQijkKDEoZNGhKlFt param_00073b63); // 0x0000000183BFB330-0x0000000183BFB5B0
}

internal delegate void YAYhqrEoEUwBEDwatJjdRaWkgjIE(); // TypeDefIndex: 53910; 0x00000001853DEDB8-0x00000001853DEDC8

internal enum qMSJAGnGFztVWGbbMtcbmLOJutTU // TypeDefIndex: 53911
{
	NonOverlapped = 0,
	Overlapped = 1
}

[Flags]
internal enum nqaKskRUwxbeUaaRxyXfhGNcbkBm // TypeDefIndex: 53912
{
	Exclusive = 0,
	ShareRead = 1,
	ShareWrite = 2
}

internal interface IdxcAbgzMTzxeMxdElxolIcPzwurA : IDisposable // TypeDefIndex: 53913
{
	// Properties
	IntPtr GebVmHpsJPFlDsHlVnlvHSQVztdK { get; }
	bool zDVgUhrfAfIgYMdclajHjFgtbNJXA { get; }
	bool akJlAXhUcHpRKZzggAJdBwlcZzEF { get; }
	ZmPxydCEzlPckyvKlHErkFzgGOFX BkPbwOOXbHfrprsNBdoJnAuJgArO { get; }
	pKfkmqTLezjFVzcIBPtMMyRxABwH FgnMidYTRITgpetgeSFsBzmtVqg { get; }
	string QVMkSNFdzYBkSGGdcYhOkBRBEqJFb { get; }
	bool jRIXoCZDUfZanaiKGfTModoQmerH { get; set; }
	aHzSDAgzXeTUuXeKeiUwhHjMNyKD[] vnsxdvCfmAdoMUjBnHXzFustAXhEb { get; }
	JXtFhzUqozCGLAAgSlsxdSapKppi[] NdwbjMyHWBpjFInkCzszCfJNATFjA { get; }
	string QXKDwkyKHflTUTDjlilpWKmzxeZi { get; }
	string YYRyzKMAZwsaThONuxJfKsPrqcLy { get; }
	int eKPYMUXhTxBdzYqkhjcxbAyVDCugA { get; }
	int IgAWnnkazSdEUGswQhfizzwTVqAs { get; }
	bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; }
	string RCkbDMwhfgaXSHlSrLNVbcJiljIPc { get; }
	bool BJdhruPWQfbEmflPqJRhZZyRVxDTA { get; }

	// Methods
	bool xULxbDXErMDWumqPoCklYRksejXD(bool param_00073b8f, qMSJAGnGFztVWGbbMtcbmLOJutTU param_00073b90, bool param_00073b91, qMSJAGnGFztVWGbbMtcbmLOJutTU param_00073b92, nqaKskRUwxbeUaaRxyXfhGNcbkBm param_00073b93);
	void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA();
	bool EhQhxFweepMpjwazcuSRnFZeQtLc(YWFEqRKsCWKdGhNygVhQhOHuhIISb param_00073b94, int param_00073b95);
	bool aunlOVhpWoQiLKWoGcKSaHLfoXig(out byte[] param_00073b96, int param_00073b97, byte param_00073b98 = 0 /* Metadata: 0x0233412E */);
	string efFcegvAymobYqJrtnRqLeSRXvqm();
	bool efFcegvAymobYqJrtnRqLeSRXvqm(out byte[] param_00073b99);
	string aWBHzUPzbLPVEfFhmcDSkVnnSvncA();
	bool aWBHzUPzbLPVEfFhmcDSkVnnSvncA(out byte[] param_00073b9a);
	string FpKBQHheYjWwGPXekyQQsMXbqOsJA();
	bool FpKBQHheYjWwGPXekyQQsMXbqOsJA(out byte[] param_00073b9b);
	bool cWNDdKjHWcUyzYOsFgZrPjZLiW(SAcTodLryXZPmeZqsKbnQQxsbBmo param_00073b9c, int param_00073b9d);
}

internal class GmZKiAtyHCxBQdcQbJSlTPDYeHyh : IDisposable // TypeDefIndex: 53915
{
	// Fields
	private readonly BCrcjwPSVWVTkTJoZjurbxnlvFSPA CfrKJJSAyimvwjMUPAPRDXKzsPZP; // 0x10
	private readonly SWoCckscCFFlHZUcZBalEtsOlVBB PESeIcjejbxNKoiHcKCLjrkkczupb; // 0x18
	private readonly Rewired.Utils.Classes.Utility.ThreadHelper swKaDCbNENkYjkUfdceifkmFnqWvA; // 0x20
	private readonly int PPWZidNKBOlaaEKUoPHokwqPenqp; // 0x28
	private readonly int pfFLnbWyebkFqMFGQNLdLTfmHwFn; // 0x2C
	private readonly string FTsvIXEktiHXgfwfsNXGtJdrQfsR; // 0x30
	private readonly byte[] AEcUnIAGJoTLfYbyKvaNXemuYreV; // 0x38
	private readonly byte[] cIJrCQBUOspSynOxYaPsDYkClkGkA; // 0x40
	private int RkmIDamWuyIVNVnWBDXwSSBRJZiH; // 0x48
	private rYyHAAtlEbEefKkEVDsoHjKzQHzSA qSrbLEdOZrZFtZjoBkNNpMgMgyweA; // 0x50
	private rYyHAAtlEbEefKkEVDsoHjKzQHzSA ZKeoEanQFoLPOxtGsiIqGtPiiTIB; // 0x58
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x60

	// Nested types
	public delegate void BCrcjwPSVWVTkTJoZjurbxnlvFSPA(IntPtr reportPointer, int reportByteLength, int reportCount, double timestamp); // TypeDefIndex: 53914; 0x00000001815547C0-0x00000001815547E0

	// Constructors
	public GmZKiAtyHCxBQdcQbJSlTPDYeHyh(string param_00073b9e, int param_00073b9f, string param_00073ba0, BCrcjwPSVWVTkTJoZjurbxnlvFSPA param_00073ba1); // 0x000000018ABB389C-0x000000018ABB3E20

	// Methods
	public void TSexxBoQJJrDUHjAVGegZXOfrqTg(); // 0x000000018ABB358C-0x000000018ABB3734
	private void NzwthoEmIfaUpXEKjvYIxvKAYsLH(); // 0x000000018ABB3414-0x000000018ABB3548
	private void MKwPGmPNfhFmvlkQlEqXqLOfRmuO(); // 0x000000018ABB32A8-0x000000018ABB3414
	private bool eZqveQdLMqWCWwgrupQSzRJBttwc(byte[] param_00073ba2); // 0x000000018ABB3E20-0x000000018ABB3E74
	private bool UVAINHhGqunVbVWdcaVBPDuDgptg(); // 0x000000018ABB3734-0x000000018ABB3828
	public void Dispose(); // 0x000000018ABB3258-0x000000018ABB32A8
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABB3828-0x000000018ABB389C
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073ba3); // 0x000000018ABB3548-0x000000018ABB358C
}

internal static class MDBYECqvXkaCiSmYJZjrizfidEbk // TypeDefIndex: 53930
{
	// Fields
	internal static readonly IntPtr WUbkTWMRstakAOOBXTqosefccnxn; // 0x00
	internal static IVfAZcQUPLflQJNXBMuFPKDDBvSJ WuyOVSGWaiJiZxsguelzyftXTiSp; // 0x08

	// Properties
	internal static int ZMyoQQZHmAhxHATKUZpfdwJoOKpiA { get; } // 0x00000001835AC3B0-0x00000001835AC410 
	internal static int qeHAzYAsIzstuoMjzWyVgrxmJmpeb { get; } // 0x0000000184DA3370-0x0000000184DA3380 
	internal static Guid FyZtNyZLPMCKmsEvHWkPVNuBLRiQ { get; } // 0x000000018ABB4D10-0x000000018ABB4D68 
	internal static Guid MxWoSgVNBNuNEIjXHaoUkPwILiPo { get; } // 0x0000000183E04750-0x0000000183E047B0 

	// Nested types
	internal struct CBtraXnwXpmyYfPuzLvlCcBzHcLk // TypeDefIndex: 53916
	{
		// Fields
		public static readonly int YYYwecOazrpNKDkqnhldLbjwVCOt; // 0x00
		public IntPtr GLXXMYKmaqmXiiWvsOoYiMiRBZbc; // 0x00
		public IntPtr SmoCooaGWPoVkbeEfJdnaamguSoVb; // 0x08
		public int cUnbMmRopjnIcVzEYdAdwbDpVtGP; // 0x10
		public int gsUCzHPBYMYiPnToFImFmDDWhMGH; // 0x14
		public IntPtr jsSJXwXwYGhgniLMhSTWRVpIvwms; // 0x18

		// Constructors
		static CBtraXnwXpmyYfPuzLvlCcBzHcLk(); // 0x000000018ABAF910-0x000000018ABAF9A0
	}

	internal struct NwIzwEuvvoEuXLxYyuEhdQwOWVzA // TypeDefIndex: 53917
	{
		// Fields
		public static readonly int YYYwecOazrpNKDkqnhldLbjwVCOt; // 0x00
		public int EjQFFLCgGoakkUuMOEmNQKsFAbRrA; // 0x00
		public IntPtr CaUEQhRNZYMmCVQPDHVFbebWHLHx; // 0x08
		public bool hIxHTAahWVYNjOEaYDCCfjqWUhHv; // 0x10

		// Constructors
		static NwIzwEuvvoEuXLxYyuEhdQwOWVzA(); // 0x0000000184CEC600-0x0000000184CEC6B0
	}

	internal struct OdnntAHntokWiUdDHtrlcobDeFoF // TypeDefIndex: 53918
	{
		// Fields
		internal int RAqcnpHrqBYCbbQhULmPgKdlbAcP; // 0x00
		internal Guid YtYzaGGMxFPoUssfSIjPqoeYMKJy; // 0x04
		internal int qtIfMRoWBGZEUSCwsKeTMCQXFfRIA; // 0x14
		internal IntPtr uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x18

		// Properties
		public int YYYwecOazrpNKDkqnhldLbjwVCOt { get; } // 0x0000000184DA43E0-0x0000000184DA43F0 
	}

	internal struct ZBJNsrUqCLQBwhEksjgMQwyVNulB // TypeDefIndex: 53919
	{
		// Fields
		internal int RAqcnpHrqBYCbbQhULmPgKdlbAcP; // 0x00
		internal Guid TFCmbGedgzeEcgpGHSjcgbdJTGwQ; // 0x04
		internal int RGVVIVZjJExeZXsPofhBRohzcrEw; // 0x14
		internal IntPtr uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x18

		// Properties
		public int YYYwecOazrpNKDkqnhldLbjwVCOt { get; } // 0x0000000184DA43E0-0x0000000184DA43F0 
	}

	internal struct zQUvgYtDBPnHxTlagLfRbHFoYHuA // TypeDefIndex: 53920
	{
		// Fields
		internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		internal string QVMkSNFdzYBkSGGdcYhOkBRBEqJFb; // 0x08
	}

	internal struct IVfAZcQUPLflQJNXBMuFPKDDBvSJ // TypeDefIndex: 53921
	{
		// Fields
		public Guid zNEQgTKuywuYjIFibrdrdMXNcTWdA; // 0x00
		public ulong DKZHXbCKKHSLelzDkJSsZeqCwUoG; // 0x10
	}

	internal struct GdZTshfUFywPkphGdVzwMUmXwiZb // TypeDefIndex: 53922
	{
		// Fields
		internal int DpYPmjpmntKbDQjXRlVzRHTqRZtb; // 0x00
		internal ushort ZafHsBfzyUhaKkyhAJTpVsPPQacB; // 0x04
		internal ushort NtMXBzPrDqbDWFkRLCJKRUroAwrd; // 0x06
		internal short yaEXslHRhOToVZGGZIFieBALQaJRA; // 0x08
	}

	internal struct wVeMkOOBFiFZpAAnIEqQLLFkoZNAA // TypeDefIndex: 53923
	{
		// Fields
		internal short ZhwNBMzYOdcsywMxxqnQBgbeZIaX; // 0x00
		internal short NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x02
		internal short eWcIGAyfISkTRCxwLEzYDwBhxXNT; // 0x04
		internal short twWgyKYIignftDZJqVYymJvnhZLO; // 0x06
		internal short FGGPXeutjDcGGYJFjFtImAsQZSIC; // 0x08
		internal short[] uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x10
		internal short zEhcdcxrhEhqCSdWJNEpaIvoFigJ; // 0x18
		internal short lQXkNeVylOntJdOrOVkFESIdghWt; // 0x1A
		internal short vQZsVQHIJiHngByYIlmtSFLxlgwi; // 0x1C
		internal short EyRKBObXUWcxCdXUNGOOucVdSnbE; // 0x1E
		internal short sBCDQUIDvFWgcDrQNjSppTLxUwQE; // 0x20
		internal short iiBypvdQtOAZmaprrbycWFwNeYOVA; // 0x22
		internal short rLiXPNunmKNJgUDKdNtNLzzfRvgv; // 0x24
		internal short krUWCsmFkCCaniEjibwlkSFwqXxHA; // 0x26
		internal short aXlxbZdHqFFqrGzexQagmVHTilEDA; // 0x28
		internal short RcJPzQHLaLlIsNMwUGthGWLbZmgIA; // 0x2A
	}

	internal struct HZHOCcmbYJxOQijkKDEoZNGhKlFt // TypeDefIndex: 53925
	{
		// Fields
		internal ushort NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x00
		internal byte yQxQgOQNMVMVBtcqgArgADGYErtCb; // 0x02
		internal bool vtTDydgHKBpOnHSyNFEsNAlyQxfS; // 0x03
		internal ushort EVOgATFTRXRYYHBhTtlQzWYqqwdA; // 0x04
		internal ushort pHcUlKlzzchyOdBayWGzpHfvaXne; // 0x06
		internal ushort OZGNGboMcWuoFBqTPiRpwosbEqYM; // 0x08
		internal ushort xfxgDPRowhYBpUmBfcwmlmnSOAOk; // 0x0A
		internal bool BfopjfztUWmuPqlPQddPxAYCUqBv; // 0x0C
		internal bool hMRiaanusLpZjoDmjlMCDmUAeXvt; // 0x0D
		internal bool OrluHimCvJfxNzFNtqGOaUVOaKzG; // 0x0E
		internal bool pBNaQqqwjWuTtRxKaIqRAoduhvcR; // 0x0F
		internal bool lhcFgIyotHiTDfPsiWQeKyQqtxTO; // 0x10
		internal byte uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x11
		internal ushort rTIQSbqOnUSmuevmXNIAdLXhUEc; // 0x12
		internal ushort VtyHLJteBwuRwyyuieGwmtYecGPq; // 0x14
		internal ushort[] YGNxrFfotADbwHHXFCFbjPccoxEvb; // 0x18
		internal uint CfHaeRicZteSoguHdEQyFjSdoVhgd; // 0x20
		internal uint bFwqshEICTItwIvQnTVtjCmEEhPOA; // 0x24
		internal int yuuLeDEnXHQWGYlbsuwXHCpOexoCA; // 0x28
		internal int UIOacgZTgkjwtdxToaahjmcjPOooc; // 0x2C
		internal int iWOAtDfVIEwlveRsEXZbFHNDedliA; // 0x30
		internal int GgFHkuuBxplJABXwhoHoystWwxHJ; // 0x34
		internal IByqlcoARSDqEKzHbCrNMVsTTQLu VLenFfKKPrenZGpfyWJnXIhXbjuD; // 0x38

		// Nested types
		internal struct IByqlcoARSDqEKzHbCrNMVsTTQLu // TypeDefIndex: 53924
		{
			// Fields
			internal ushort[] MdVJzrDujwFLpVVdSUCkeVIfhPcv; // 0x00
		}
	}

	internal struct cGvTcLBAAcvnQHXapwJLwcbObXDw // TypeDefIndex: 53927
	{
		// Fields
		internal ushort NDweLaWskzoBwpWJxCWuzQStzdYi; // 0x00
		internal byte yQxQgOQNMVMVBtcqgArgADGYErtCb; // 0x02
		internal bool vtTDydgHKBpOnHSyNFEsNAlyQxfS; // 0x03
		internal ushort EVOgATFTRXRYYHBhTtlQzWYqqwdA; // 0x04
		internal ushort pHcUlKlzzchyOdBayWGzpHfvaXne; // 0x06
		internal ushort OZGNGboMcWuoFBqTPiRpwosbEqYM; // 0x08
		internal ushort xfxgDPRowhYBpUmBfcwmlmnSOAOk; // 0x0A
		internal bool BfopjfztUWmuPqlPQddPxAYCUqBv; // 0x0C
		internal bool hMRiaanusLpZjoDmjlMCDmUAeXvt; // 0x0D
		internal bool OrluHimCvJfxNzFNtqGOaUVOaKzG; // 0x0E
		internal bool pBNaQqqwjWuTtRxKaIqRAoduhvcR; // 0x0F
		internal uint[] uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x10
		internal ckgadpNmTOqjlmzFTWrSowPkwEdY VLenFfKKPrenZGpfyWJnXIhXbjuD; // 0x18

		// Nested types
		internal struct ckgadpNmTOqjlmzFTWrSowPkwEdY // TypeDefIndex: 53926
		{
			// Fields
			internal ushort[] MdVJzrDujwFLpVVdSUCkeVIfhPcv; // 0x00
		}
	}

	internal struct dHQmwhHbvgbNuAqIBFbWyaCtzDht // TypeDefIndex: 53928
	{
		// Fields
		public ushort UJTiICQitwbxBiJLohBISjwTSsGgA; // 0x00
		public ushort uEWSYFkyRUKNddSuwNCCuQBguizT; // 0x02
		public uint SLPzpJxHRYLGGqgBYRdylUCgwhEM; // 0x04

		// Properties
		public uint jyZihDTgYnhgMvYUjEVDqSPXpyHB { get; } // 0x0000000184D88B20-0x0000000184D88B30 
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void nnQCTPzFcMHWGWfoOtAsaDpWLiXO(int dwErrorCode, int dwNumbmerOfBytesTransfered, IntPtr lpOverlapped); // TypeDefIndex: 53929; 0x0000000181546280-0x00000001815462A0

	// Constructors
	static MDBYECqvXkaCiSmYJZjrizfidEbk(); // 0x0000000184B6B2A0-0x0000000184B6B370

	// Methods
	internal static extern bool RYrcvNGsskawASVJvvEVsabgNctg(IntPtr param_00073baa); // 0x000000018ABB4730-0x000000018ABB47AC
	internal static extern bool ImbwHAAIHSaxgTyvDvEpzDXjhce(IntPtr param_00073bab, IntPtr param_00073bac); // 0x0000000183BF8630-0x0000000183BF8690
	internal static extern bool WuPzsguhZYdvHaWbnBQQzUUJbDQpA(IntPtr param_00073bad); // 0x0000000183BF83C0-0x0000000183BF8470
	internal static extern IntPtr xCnufPBpKdYnhGCjrxEfDUZOthqJ(IntPtr param_00073bae, int param_00073baf, int param_00073bb0, IntPtr param_00073bb1); // 0x000000018ABB4E2C-0x000000018ABB4ED4
	internal static extern IntPtr EhCgiLwvPkqgjCyzTcXzaXhlhTCD(string param_00073bb2, uint param_00073bb3, int param_00073bb4, ref NwIzwEuvvoEuXLxYyuEhdQwOWVzA param_00073bb5, int param_00073bb6, int param_00073bb7, int param_00073bb8); // 0x0000000183BF9270-0x0000000183BF9390
	internal static extern bool TqXaeispoJFPnbIQJiTmbSrTiZQsA(IntPtr param_00073bb9, out IntPtr param_00073bba, uint param_00073bbb, out uint param_00073bbc, IntPtr param_00073bbd); // 0x000000018ABB47AC-0x000000018ABB4868
	internal static extern bool vzDSCTvFaOAiNKVFyODODxCmCxcgb(IntPtr param_00073bbe, out IntPtr param_00073bbf, uint param_00073bc0, IntPtr param_00073bc1, nnQCTPzFcMHWGWfoOtAsaDpWLiXO param_00073bc2); // 0x000000018ABB4D68-0x000000018ABB4E2C
	internal static extern uint grKWUTxHrBekRHyGyqwzltCJmZbNA(IntPtr param_00073bc3, int param_00073bc4); // 0x000000018ABB4BDC-0x000000018ABB4C64
	internal static extern bool aWmXAsuhvUfzVzqjYKyuJJTRUgTC(IntPtr param_00073bc5, IntPtr param_00073bc6, uint param_00073bc7, out uint param_00073bc8, IntPtr param_00073bc9); // 0x000000018ABB4B20-0x000000018ABB4BDC
	internal static extern bool aWmXAsuhvUfzVzqjYKyuJJTRUgTC(IntPtr param_00073bca, IntPtr param_00073bcb, uint param_00073bcc, IntPtr param_00073bcd, IntPtr param_00073bce); // 0x000000018ABB4A64-0x000000018ABB4B20
	internal static extern void sDUBlMDuCrPLxbyAXEXopezSVYlSA(IntPtr param_00073bcf, int param_00073bd0); // 0x0000000183BF78F0-0x0000000183BF7940
	internal static extern bool mtSaPCodCIAqAUkfFPZjykoitoKn(IntPtr param_00073bd1, IntPtr param_00073bd2, out int param_00073bd3, bool param_00073bd4); // 0x000000018ABB4C64-0x000000018ABB4D10
	internal static extern uint PMKTUsakHzcYBvHKnxuNGwJuJXWn(int param_00073bd5, bool param_00073bd6); // 0x000000018ABB460C-0x000000018ABB4694
	public static extern bool FmnMJMxFTrSOZWCFWCkbwloVGQgH(IntPtr param_00073bd7, ref ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073bd8, int param_00073bd9, ref int param_00073bda, IntPtr param_00073bdb, int param_00073bdc, ref int param_00073bdd); // 0x00000001835AB890-0x00000001835AB920
	public static extern bool cjSszbhUuOYloPbmVElhxorJJlru(IntPtr param_00073bde, ref ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073bdf, ref IVfAZcQUPLflQJNXBMuFPKDDBvSJ param_00073be0, ref ulong param_00073be1, IntPtr param_00073be2, int param_00073be3, ref int param_00073be4, uint param_00073be5); // 0x00000001835AC490-0x00000001835AC540
	internal static extern bool JVoDOoRetbRCPIiFUOHmNjsvwsex(IntPtr param_00073be6, int param_00073be7, ref ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073be8); // 0x00000001835AB230-0x00000001835AB280
	internal static extern int KuhQvokhsUXrtnTEHOIjowvEUEXM(IntPtr param_00073be9); // 0x0000000183E047B0-0x0000000183E047E0
	internal static extern bool rslFJoayUotdPsPPolEiTNhdjCfkA(IntPtr param_00073bea, ref ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073beb, ref Guid param_00073bec, int param_00073bed, ref OdnntAHntokWiUdDHtrlcobDeFoF param_00073bee); // 0x00000001835AB1C0-0x00000001835AB230
	internal static extern IntPtr RSwFhLkinlqsRryJsUguPSweSrdJA(ref Guid param_00073bef, string param_00073bf0, int param_00073bf1, int param_00073bf2); // 0x0000000183E047E0-0x0000000183E04850
	internal static extern bool PLikBdjLDPBDKcMpgVqTOxXXSNfNA(IntPtr param_00073bf3, ref OdnntAHntokWiUdDHtrlcobDeFoF param_00073bf4, IntPtr param_00073bf5, int param_00073bf6, ref int param_00073bf7, IntPtr param_00073bf8); // 0x00000001835AC410-0x00000001835AC490
	internal static extern bool PLikBdjLDPBDKcMpgVqTOxXXSNfNA(IntPtr param_00073bf9, ref OdnntAHntokWiUdDHtrlcobDeFoF param_00073bfa, ref zQUvgYtDBPnHxTlagLfRbHFoYHuA param_00073bfb, int param_00073bfc, ref int param_00073bfd, IntPtr param_00073bfe); // 0x0000000183826610-0x0000000183826730
	internal static extern bool tkavVlneyLExcabIOnRTCxEMKhQjA(IntPtr param_00073bff, ref ZBJNsrUqCLQBwhEksjgMQwyVNulB param_00073c00, IntPtr param_00073c01, uint param_00073c02, out uint param_00073c03); // 0x00000001835AC540-0x00000001835AC700
	internal static extern int faXBkMDpQFrgQHDzZyEaQalcBcJW(out uint param_00073c04, uint param_00073c05, uint param_00073c06); // 0x00000001835ABCD0-0x00000001835ABD20
	internal static extern int SRMyVaUNoYAmCAmVdQiWEadSxyNz(uint param_00073c07, IntPtr param_00073c08, int param_00073c09, uint param_00073c0a); // 0x00000001835AC060-0x00000001835AC0C0
	internal static extern int jbbGNMciSfRZTAceYrCVNBnhIZNCb(out uint param_00073c0b, uint param_00073c0c, uint param_00073c0d); // 0x00000001835AC010-0x00000001835AC060
	internal static extern int tUrpCGzHZDQfUMSYGckzHRoUgUij(out uint param_00073c0e, uint param_00073c0f, uint param_00073c10); // 0x0000000183E05840-0x0000000183E05890
	internal static extern int jwFgcYxBnPLkNorEiHJaCRzbYYV(out uint param_00073c11, uint param_00073c12, uint param_00073c13); // 0x0000000183E054B0-0x0000000183E05500
	internal static extern bool fMXBzDdBdGKLINYGUKUetTzjxGOtA(IntPtr param_00073c14, ref GdZTshfUFywPkphGdVzwMUmXwiZb param_00073c15); // 0x0000000183BFAF70-0x0000000183BFAFC0
	internal static extern bool ZNzCNtgwgJZKDWYhYoqDzJxQHMiS(IntPtr param_00073c16, byte[] param_00073c17, int param_00073c18); // 0x000000018ABB49BC-0x000000018ABB4A64
	internal static extern bool XtmaREUrnRpnBTGOWCRgKELJuyKSA(IntPtr param_00073c19, IntPtr param_00073c1a, int param_00073c1b); // 0x000000018ABB4920-0x000000018ABB49BC
	internal static extern void EOgyeaeeUGjLwYeDvEDHAxqDoBms(ref Guid param_00073c1c); // 0x0000000183826B20-0x0000000183826BA0
	internal static extern bool uixceIvdPJdaoJJymVkliGNeEdAaA(IntPtr param_00073c1d, ref IntPtr param_00073c1e); // 0x0000000183BFAF20-0x0000000183BFAF70
	internal static extern bool BJJMzlwCocwgEVyYAexZMNYxwtz(IntPtr param_00073c1f); // 0x000000018470FE60-0x000000018470FEA0
	internal static extern bool QVvpdVYdnjjLylHFdYIuXIfWCQDAA(IntPtr param_00073c20, IntPtr param_00073c21, int param_00073c22); // 0x000000018ABB4694-0x000000018ABB4730
	internal static extern int BCWNrQNlFTqSlxykTDyYIBaCBZPP(IntPtr param_00073c23, ref wVeMkOOBFiFZpAAnIEqQLLFkoZNAA param_00073c24); // 0x0000000183BFAE50-0x0000000183BFAF20
	internal static extern int DSxRQZVleAiAANmrZyuFBqUxAFiQ(short param_00073c25, IntPtr param_00073c26, ref short param_00073c27, IntPtr param_00073c28); // 0x0000000183BFB5B0-0x0000000183BFB610
	internal static extern bool CYbrFAVAccWinrZWyDmVXKtjtzqk(IntPtr param_00073c29, IntPtr param_00073c2a, int param_00073c2b); // 0x000000018ABB4350-0x000000018ABB43EC
	internal static extern bool MCEXBgwAQbgGjLOtKDRGAMXmhtCJ(IntPtr param_00073c2c, IntPtr param_00073c2d, int param_00073c2e); // 0x000000018ABB450C-0x000000018ABB456C
	internal static extern bool CVKCdCEMXUyTspWjgpKwyxyjOGAn(IntPtr param_00073c2f, IntPtr param_00073c30, int param_00073c31); // 0x000000018ABB42F0-0x000000018ABB4350
	internal static extern int nXspMLbwoNOUldHkejknQQJCcfbZ(short param_00073c32, IntPtr param_00073c33, ref short param_00073c34, IntPtr param_00073c35); // 0x0000000183BF7940-0x0000000183BF79A0
	public static extern int EaNAkBPFRrZGjEPWWKtpUeIpPqyI(int param_00073c36, ushort param_00073c37, ushort param_00073c38, IntPtr param_00073c39, ref uint param_00073c3a, IntPtr param_00073c3b, IntPtr param_00073c3c, uint param_00073c3d); // 0x000000018ABB446C-0x000000018ABB450C
	public static extern int UJbLHJlpDBEQFdwYfqlXzqRZEuMm(int param_00073c3e, ushort param_00073c3f, ushort param_00073c40, ushort param_00073c41, IntPtr param_00073c42, ushort param_00073c43, IntPtr param_00073c44, IntPtr param_00073c45, uint param_00073c46); // 0x000000018ABB4868-0x000000018ABB4920
	public static extern int OzvgWaYsBvDVMJjsVKCaLmZqBHaiA(int param_00073c47, IntPtr param_00073c48, ref uint param_00073c49, IntPtr param_00073c4a, IntPtr param_00073c4b, uint param_00073c4c); // 0x000000018ABB456C-0x000000018ABB460C
	public static extern int ECxiAMdxpFiEHNqdGuupiYZFClnHA(int param_00073c4d, IntPtr param_00073c4e); // 0x000000018ABB43EC-0x000000018ABB446C
}

internal class ERrmsitpcXDZelTYlGLEEisQnmaGA // TypeDefIndex: 53943
{
	// Fields
	private static Rewired.Platforms.Platform GXaMQWLMYHxvakihbyXtNdLRZwcd; // 0x00

	// Nested types
	public enum JjlLXXcqMqcxzDtGZnlUJTjxredw : uint // TypeDefIndex: 53931
	{
		SDL_FIRSTEVENT = 0,
		SDL_QUIT = 256,
		SDL_APP_TERMINATING = 257,
		SDL_APP_LOWMEMORY = 258,
		SDL_APP_WILLENTERBACKGROUND = 259,
		SDL_APP_DIDENTERBACKGROUND = 260,
		SDL_APP_WILLENTERFOREGROUND = 261,
		SDL_APP_DIDENTERFOREGROUND = 262,
		SDL_WINDOWEVENT = 512,
		SDL_SYSWMEVENT = 513,
		SDL_KEYDOWN = 768,
		SDL_KEYUP = 769,
		SDL_TEXTEDITING = 770,
		SDL_TEXTINPUT = 771,
		SDL_MOUSEMOTION = 1024,
		SDL_MOUSEBUTTONDOWN = 1025,
		SDL_MOUSEBUTTONUP = 1026,
		SDL_MOUSEWHEEL = 1027,
		SDL_JOYAXISMOTION = 1536,
		SDL_JOYBALLMOTION = 1537,
		SDL_JOYHATMOTION = 1538,
		SDL_JOYBUTTONDOWN = 1539,
		SDL_JOYBUTTONUP = 1540,
		SDL_JOYDEVICEADDED = 1541,
		SDL_JOYDEVICEREMOVED = 1542,
		SDL_CONTROLLERAXISMOTION = 1616,
		SDL_CONTROLLERBUTTONDOWN = 1617,
		SDL_CONTROLLERBUTTONUP = 1618,
		SDL_CONTROLLERDEVICEADDED = 1619,
		SDL_CONTROLLERDEVICEREMOVED = 1620,
		SDL_CONTROLLERDEVICEREMAPPED = 1621,
		SDL_FINGERDOWN = 1792,
		SDL_FINGERUP = 1793,
		SDL_FINGERMOTION = 1794,
		SDL_DOLLARGESTURE = 2048,
		SDL_DOLLARRECORD = 2049,
		SDL_MULTIGESTURE = 2050,
		SDL_CLIPBOARDUPDATE = 2304,
		SDL_DROPFILE = 4096,
		SDL_RENDER_TARGETS_RESET = 8192,
		SDL_USEREVENT = 32768,
		SDL_LASTEVENT = 65535
	}

	public struct WtYDlYGBazQlCIfNIIGpZwxTHFulA // TypeDefIndex: 53932
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte ksXILWnBSSgWlABkRWUCevyMVTlo; // 0x0C
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0D
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0E
		public byte VEvDshjJNBJKwrpsnHTEJpvZhDxcA; // 0x0F
		public short IaOjDqjXmTvIEPrVtSrrcPlQvkii; // 0x10
		public ushort VnheYvgFyqcMywLnySzvjCjWscEMA; // 0x12

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c73, uint param_00073c74, IntPtr param_00073c75); // 0x000000018ABB7B9C-0x000000018ABB7C28
	}

	public struct nuPqVpafSULPUJReuwXEHVFGTqYo // TypeDefIndex: 53933
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte hfhRFVAeCPMNDHgMEMgxIprhJEGI; // 0x0C
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0D
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0E
		public byte VEvDshjJNBJKwrpsnHTEJpvZhDxcA; // 0x0F
		public short wKItLqiBDfkczDXWZqUdXCeLRTqv; // 0x10
		public short FmdSXrJLQJYiSCJmoqvyCXHSOSmD; // 0x12

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c76, uint param_00073c77, IntPtr param_00073c78); // 0x000000018ABB91F4-0x000000018ABB9294
	}

	public struct MpgatCrtHXZXKexKnssNnzqOxHkb // TypeDefIndex: 53934
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte TjuqKdZPujgkemMEsnovTKhKgUQx; // 0x0C
		public byte IaOjDqjXmTvIEPrVtSrrcPlQvkii; // 0x0D
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0E
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0F

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c79, uint param_00073c7a, IntPtr param_00073c7b); // 0x000000018ABB4ED4-0x000000018ABB4F54
	}

	public struct ARLpXSGgShledzMXCkwiFbYQfzgq // TypeDefIndex: 53935
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte WxryYuawZXtdOrftOHNWXqdmbnnjA; // 0x0C
		public byte qiGcZSJxGopIPnLDnLXfDzOCSjRf; // 0x0D
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0E
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0F

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c7c, uint param_00073c7d, IntPtr param_00073c7e); // 0x000000018ABAF630-0x000000018ABAF6B0
	}

	public struct XkfkMHwGKUjrAejsvknbmMNxlVxj // TypeDefIndex: 53936
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c7f, uint param_00073c80, IntPtr param_00073c81); // 0x000000018ABB7C28-0x000000018ABB7C9C
	}

	public struct EEHintEoWqwtrulXqUuaStXrpcHl // TypeDefIndex: 53937
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte ksXILWnBSSgWlABkRWUCevyMVTlo; // 0x0C
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0D
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0E
		public byte VEvDshjJNBJKwrpsnHTEJpvZhDxcA; // 0x0F
		public short IaOjDqjXmTvIEPrVtSrrcPlQvkii; // 0x10
		public ushort VnheYvgFyqcMywLnySzvjCjWscEMA; // 0x12

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c82, uint param_00073c83, IntPtr param_00073c84); // 0x000000018ABAF9A0-0x000000018ABAFA2C
	}

	public struct ZFIgyKFYAnbTAjavbvUFScwzweHVA // TypeDefIndex: 53938
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08
		public byte WxryYuawZXtdOrftOHNWXqdmbnnjA; // 0x0C
		public byte qiGcZSJxGopIPnLDnLXfDzOCSjRf; // 0x0D
		public byte hBMYuQyBnBgNOsFswVWqgFoWJTOU; // 0x0E
		public byte jzbhfBnEYjRMcuwPXqZPPJqPVMfX; // 0x0F

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c85, uint param_00073c86, IntPtr param_00073c87); // 0x000000018ABB7CF8-0x000000018ABB7D78
	}

	public struct wEGFotndTOlmgYqzAoyIypxyoDcB // TypeDefIndex: 53939
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public uint jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x04
		public int zBSiICiRqsUlQKkfjtDXhKgQNPQk; // 0x08

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(JjlLXXcqMqcxzDtGZnlUJTjxredw param_00073c88, uint param_00073c89, IntPtr param_00073c8a); // 0x000000018ABBB38C-0x000000018ABBB400
	}

	public struct iFlWUPUplqnKICmxEXHwZclSsZxJ // TypeDefIndex: 53940
	{
		// Fields
		public JjlLXXcqMqcxzDtGZnlUJTjxredw IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x00
		public WtYDlYGBazQlCIfNIIGpZwxTHFulA kTqBRlrxnpgMjiionJBMTNTqCsoW; // 0x04
		public nuPqVpafSULPUJReuwXEHVFGTqYo eTwjqouYsokOvvyvTTHTroLCtzM; // 0x18
		public MpgatCrtHXZXKexKnssNnzqOxHkb wxazLPUpdunsliLyTAXJuProjOYr; // 0x2C
		public ARLpXSGgShledzMXCkwiFbYQfzgq CxVSntJqMLYLgHnvsFQOjROJLgIUA; // 0x3C
		public XkfkMHwGKUjrAejsvknbmMNxlVxj LjFIQZTfBfwAXVTBuSkqysgQIvFg; // 0x4C
		public EEHintEoWqwtrulXqUuaStXrpcHl KZVMOOhMNJCOEdctbxJRevXDMncVA; // 0x58
		public ZFIgyKFYAnbTAjavbvUFScwzweHVA aoWpVJeFipAkiJihvXrjeaeKBBKYA; // 0x6C
		public wEGFotndTOlmgYqzAoyIypxyoDcB hZbTzmReTERBNKOIAxjoohpNVhtX; // 0x7C

		// Methods
		public void OuBkTAWCffoNeeupcONpZtGJgILD(IntPtr param_00073c8b); // 0x000000018ABB8EC8-0x000000018ABB9044
	}

	private class qYbtvLznmMJAIBgUTZLsEeMXGBFo // TypeDefIndex: 53941
	{
		// Methods
		public static extern int jwrJtgKjbbgPiEvPzIjyLvoCtpHE(uint param_00073c8c); // 0x000000018ABBAE84-0x000000018ABBAEF4
		public static extern void tqeQqIgZtGKzNcajBGIXRnLskZYM(); // 0x000000018ABBB118-0x000000018ABBB180
		public static extern int FlPITYNFTmoSbARzUSaLQMrOMOqc(); // 0x000000018ABBA668-0x000000018ABBA6D0
		public static extern int jtMkMQzzIZBUVMwQIAFkBFEmWivb(IntPtr param_00073c8d); // 0x000000018ABBAE50-0x000000018ABBAE84
		public static string tedOpxaNBSGgAWoWixwzWrgFqoQL(IntPtr param_00073c8e); // 0x000000018ABBB0A4-0x000000018ABBB118
		private static extern IntPtr IWqTvEUOuYeLmIzLwLRzkDjsOPqWA(IntPtr param_00073c8f); // 0x000000018ABBA744-0x000000018ABBA7B8
		public static extern Guid LuQdaCyDzrtQGUQqmEytwWAgfOYw(IntPtr param_00073c90); // 0x000000018ABBA7B8-0x000000018ABBA848
		public static extern Guid ZIPzEXUFOeVjIAgnLFCepqkVKHJM(int param_00073c91); // 0x000000018ABBACD0-0x000000018ABBAD58
		public static extern int vERLDthNGhXVoXIEPqNUoGHEEkEIA(IntPtr param_00073c92); // 0x000000018ABBB180-0x000000018ABBB1B4
		public static extern int PWTInrzAvACxKnQqxEWHVcrFdUNg(IntPtr param_00073c93); // 0x000000018ABBA9D4-0x000000018ABBAA08
		public static extern int NNBTbfFuffRFbqDBUgrcqpINLrEu(IntPtr param_00073c94); // 0x000000018ABBA92C-0x000000018ABBA960
		public static extern int nVyFChLsZrfhaBbmqjMMxtRtfyFX(IntPtr param_00073c95); // 0x000000018ABBB070-0x000000018ABBB0A4
		public static extern IntPtr DppdmBqndqzcqMmSjilMoljGXHDB(int param_00073c96); // 0x000000018ABBA5F8-0x000000018ABBA668
		public static extern void WVPXjSlbIxbDIjcYXENKhsSaYzCAB(IntPtr param_00073c97); // 0x000000018ABBAAF4-0x000000018ABBAB68
		public static extern bool ammdgwfkSBjrtriRwGNWqoBgoViD(IntPtr param_00073c98); // 0x000000018ABBADA4-0x000000018ABBAE1C
		public static extern bool yCHnHBjrrRHIabrzBFQYgVHXTDIS(int param_00073c99); // 0x000000018ABBB234-0x000000018ABBB2A8
		public static extern IntPtr MEHnTIhsJPTJLZVWwtLapocCBslU(int param_00073c9a); // 0x000000018ABBA848-0x000000018ABBA8B8
		public static extern void OKxZCQOlAKuxosWnNfUSpAVtqCOU(IntPtr param_00073c9b); // 0x000000018ABBA960-0x000000018ABBA9D4
		public static extern bool WHlNHJApSucVJmftrxByiJtrRFgB(IntPtr param_00073c9c); // 0x000000018ABBAA7C-0x000000018ABBAAF4
		public static extern IntPtr YByIqufDeKtkEgnFNqxDdfMkIPqNB(IntPtr param_00073c9d); // 0x000000018ABBABDC-0x000000018ABBAC50
		public static string kVQNMjyFRTnECAjDfOLwOrfoongs(IntPtr param_00073c9e); // 0x000000018ABBAEF4-0x000000018ABBAF68
		private static extern IntPtr WehwYZSglWDUlLRFOEFmyNNiixis(IntPtr param_00073c9f); // 0x000000018ABBAB68-0x000000018ABBABDC
		public static string YsvKMokirpfvzgJIaASLQdhjBLAyA(Guid param_00073ca0); // 0x000000018ABBAC50-0x000000018ABBACD0
		private static extern IntPtr xrBYQeYkrICdseJJLmdJfKrjSswHA(Guid param_00073ca1); // 0x000000018ABBB1B4-0x000000018ABBB234
		public static extern int luDrnAHGQGWZDDrfcgFDsOraUmUL(string param_00073ca2); // 0x000000018ABBAFDC-0x000000018ABBB070
		public static extern void lUwudyWMKicvdDYOlOAiHMjSgEcj(IntPtr param_00073ca3); // 0x000000018ABBAF68-0x000000018ABBAFDC
		public static extern IntPtr MHJxrABcIImHEyevoooKONwddsvQ(IntPtr param_00073ca4); // 0x000000018ABBA8B8-0x000000018ABBA92C
		public static extern int ztlzTIjgAXDKNEMgxnlhkQXrVnOD(IntPtr param_00073ca5); // 0x000000018ABBB2DC-0x000000018ABBB310
		public static extern int amSFbSxgSxaxeNKePFRsBRhODgCj(IntPtr param_00073ca6, float param_00073ca7, uint param_00073ca8); // 0x000000018ABBAD58-0x000000018ABBADA4
		public static extern int gaBBlfWoIYcnGKOiIRgLgVaTEaRCA(IntPtr param_00073ca9); // 0x000000018ABBAE1C-0x000000018ABBAE50
		public static extern int FsbyMkSMOpwrdHnSeRoaODVKANlH(IntPtr param_00073caa); // 0x000000018ABBA6D0-0x000000018ABBA744
		public static extern int zLuybkgsnsUtTrwghlaYJqRjseGt(IntPtr param_00073cab); // 0x000000018ABBB2A8-0x000000018ABBB2DC
		public static extern int RyzUoOVywYCGxBIgLHQLebPAhVll(IntPtr param_00073cac); // 0x000000018ABBAA08-0x000000018ABBAA7C
	}

	private class ZiFBslcUIoWqkgvaoOpVTkLNvMBfA // TypeDefIndex: 53942
	{
		// Methods
		public static extern int jwrJtgKjbbgPiEvPzIjyLvoCtpHE(uint param_00073cad); // 0x000000018ABB8608-0x000000018ABB8678
		public static extern void tqeQqIgZtGKzNcajBGIXRnLskZYM(); // 0x000000018ABB889C-0x000000018ABB8904
		public static extern int FlPITYNFTmoSbARzUSaLQMrOMOqc(); // 0x000000018ABB7DE8-0x000000018ABB7E50
		public static extern int jtMkMQzzIZBUVMwQIAFkBFEmWivb(IntPtr param_00073cae); // 0x000000018ABB85D4-0x000000018ABB8608
		public static string tedOpxaNBSGgAWoWixwzWrgFqoQL(IntPtr param_00073caf); // 0x000000018ABB8828-0x000000018ABB889C
		private static extern IntPtr IWqTvEUOuYeLmIzLwLRzkDjsOPqWA(IntPtr param_00073cb0); // 0x000000018ABB7EC4-0x000000018ABB7F38
		public static extern Guid LuQdaCyDzrtQGUQqmEytwWAgfOYw(IntPtr param_00073cb1); // 0x000000018ABB7F38-0x000000018ABB7FC8
		public static extern Guid ZIPzEXUFOeVjIAgnLFCepqkVKHJM(int param_00073cb2); // 0x000000018ABB8450-0x000000018ABB84DC
		public static extern int vERLDthNGhXVoXIEPqNUoGHEEkEIA(IntPtr param_00073cb3); // 0x000000018ABB8904-0x000000018ABB8938
		public static extern int PWTInrzAvACxKnQqxEWHVcrFdUNg(IntPtr param_00073cb4); // 0x000000018ABB8154-0x000000018ABB8188
		public static extern int NNBTbfFuffRFbqDBUgrcqpINLrEu(IntPtr param_00073cb5); // 0x000000018ABB80AC-0x000000018ABB80E0
		public static extern int nVyFChLsZrfhaBbmqjMMxtRtfyFX(IntPtr param_00073cb6); // 0x000000018ABB87F4-0x000000018ABB8828
		public static extern IntPtr DppdmBqndqzcqMmSjilMoljGXHDB(int param_00073cb7); // 0x000000018ABB7D78-0x000000018ABB7DE8
		public static extern void WVPXjSlbIxbDIjcYXENKhsSaYzCAB(IntPtr param_00073cb8); // 0x000000018ABB8274-0x000000018ABB82E8
		public static extern bool ammdgwfkSBjrtriRwGNWqoBgoViD(IntPtr param_00073cb9); // 0x000000018ABB8528-0x000000018ABB85A0
		public static extern bool yCHnHBjrrRHIabrzBFQYgVHXTDIS(int param_00073cba); // 0x000000018ABB89B4-0x000000018ABB8A2C
		public static extern IntPtr MEHnTIhsJPTJLZVWwtLapocCBslU(int param_00073cbb); // 0x000000018ABB7FC8-0x000000018ABB8038
		public static extern void OKxZCQOlAKuxosWnNfUSpAVtqCOU(IntPtr param_00073cbc); // 0x000000018ABB80E0-0x000000018ABB8154
		public static extern bool WHlNHJApSucVJmftrxByiJtrRFgB(IntPtr param_00073cbd); // 0x000000018ABB81FC-0x000000018ABB8274
		public static extern IntPtr YByIqufDeKtkEgnFNqxDdfMkIPqNB(IntPtr param_00073cbe); // 0x000000018ABB835C-0x000000018ABB83D0
		public static string kVQNMjyFRTnECAjDfOLwOrfoongs(IntPtr param_00073cbf); // 0x000000018ABB8678-0x000000018ABB86EC
		private static extern IntPtr WehwYZSglWDUlLRFOEFmyNNiixis(IntPtr param_00073cc0); // 0x000000018ABB82E8-0x000000018ABB835C
		public static string YsvKMokirpfvzgJIaASLQdhjBLAyA(Guid param_00073cc1); // 0x000000018ABB83D0-0x000000018ABB8450
		private static extern IntPtr xrBYQeYkrICdseJJLmdJfKrjSswHA(Guid param_00073cc2); // 0x000000018ABB8938-0x000000018ABB89B4
		public static extern int luDrnAHGQGWZDDrfcgFDsOraUmUL(string param_00073cc3); // 0x000000018ABB8760-0x000000018ABB87F4
		public static extern void lUwudyWMKicvdDYOlOAiHMjSgEcj(IntPtr param_00073cc4); // 0x000000018ABB86EC-0x000000018ABB8760
		public static extern IntPtr MHJxrABcIImHEyevoooKONwddsvQ(IntPtr param_00073cc5); // 0x000000018ABB8038-0x000000018ABB80AC
		public static extern int ztlzTIjgAXDKNEMgxnlhkQXrVnOD(IntPtr param_00073cc6); // 0x000000018ABB8A60-0x000000018ABB8A94
		public static extern int amSFbSxgSxaxeNKePFRsBRhODgCj(IntPtr param_00073cc7, float param_00073cc8, uint param_00073cc9); // 0x000000018ABB84DC-0x000000018ABB8528
		public static extern int gaBBlfWoIYcnGKOiIRgLgVaTEaRCA(IntPtr param_00073cca); // 0x000000018ABB85A0-0x000000018ABB85D4
		public static extern int FsbyMkSMOpwrdHnSeRoaODVKANlH(IntPtr param_00073ccb); // 0x000000018ABB7E50-0x000000018ABB7EC4
		public static extern int zLuybkgsnsUtTrwghlaYJqRjseGt(IntPtr param_00073ccc); // 0x000000018ABB8A2C-0x000000018ABB8A60
		public static extern int RyzUoOVywYCGxBIgLHQLebPAhVll(IntPtr param_00073ccd); // 0x000000018ABB8188-0x000000018ABB81FC
	}

	// Methods
	public static void zNxygNLCbLgQWIkDHlllTllbCkWN(Rewired.Platforms.Platform param_00073c54); // 0x000000018ABB0D30-0x000000018ABB0D6C
	public static int jwrJtgKjbbgPiEvPzIjyLvoCtpHE(uint param_00073c55); // 0x000000018ABB06D0-0x000000018ABB0774
	public static void tqeQqIgZtGKzNcajBGIXRnLskZYM(); // 0x000000018ABB0AA8-0x000000018ABB0B44
	public static int FlPITYNFTmoSbARzUSaLQMrOMOqc(); // 0x000000018ABAFAD0-0x000000018ABAFB6C
	public static int jtMkMQzzIZBUVMwQIAFkBFEmWivb(IntPtr param_00073c56); // 0x000000018ABB062C-0x000000018ABB06D0
	public static string tedOpxaNBSGgAWoWixwzWrgFqoQL(IntPtr param_00073c57); // 0x000000018ABB0A04-0x000000018ABB0AA8
	public static Guid LuQdaCyDzrtQGUQqmEytwWAgfOYw(IntPtr param_00073c58); // 0x000000018ABAFC10-0x000000018ABAFCD8
	public static Guid ZIPzEXUFOeVjIAgnLFCepqkVKHJM(int param_00073c59); // 0x000000018ABB0354-0x000000018ABB0418
	public static int vERLDthNGhXVoXIEPqNUoGHEEkEIA(IntPtr param_00073c5a); // 0x000000018ABB0B44-0x000000018ABB0BE8
	public static int PWTInrzAvACxKnQqxEWHVcrFdUNg(IntPtr param_00073c5b); // 0x000000018ABAFF68-0x000000018ABB000C
	public static int NNBTbfFuffRFbqDBUgrcqpINLrEu(IntPtr param_00073c5c); // 0x000000018ABAFE20-0x000000018ABAFEC4
	public static int nVyFChLsZrfhaBbmqjMMxtRtfyFX(IntPtr param_00073c5d); // 0x000000018ABB0960-0x000000018ABB0A04
	public static IntPtr DppdmBqndqzcqMmSjilMoljGXHDB(int param_00073c5e); // 0x000000018ABAFA2C-0x000000018ABAFAD0
	public static void WVPXjSlbIxbDIjcYXENKhsSaYzCAB(IntPtr param_00073c5f); // 0x000000018ABB0154-0x000000018ABB01F8
	public static bool ammdgwfkSBjrtriRwGNWqoBgoViD(IntPtr param_00073c60); // 0x000000018ABB04E4-0x000000018ABB0588
	public static bool yCHnHBjrrRHIabrzBFQYgVHXTDIS(int param_00073c61); // 0x000000018ABB0BE8-0x000000018ABB0C8C
	public static IntPtr MEHnTIhsJPTJLZVWwtLapocCBslU(int param_00073c62); // 0x000000018ABAFCD8-0x000000018ABAFD7C
	public static void OKxZCQOlAKuxosWnNfUSpAVtqCOU(IntPtr param_00073c63); // 0x000000018ABAFEC4-0x000000018ABAFF68
	public static bool WHlNHJApSucVJmftrxByiJtrRFgB(IntPtr param_00073c64); // 0x000000018ABB00B0-0x000000018ABB0154
	public static IntPtr YByIqufDeKtkEgnFNqxDdfMkIPqNB(IntPtr param_00073c65); // 0x000000018ABB01F8-0x000000018ABB029C
	public static string kVQNMjyFRTnECAjDfOLwOrfoongs(IntPtr param_00073c66); // 0x000000018ABB0774-0x000000018ABB0818
	public static string YsvKMokirpfvzgJIaASLQdhjBLAyA(Guid param_00073c67); // 0x000000018ABB029C-0x000000018ABB0354
	public static int luDrnAHGQGWZDDrfcgFDsOraUmUL(string param_00073c68); // 0x000000018ABB08BC-0x000000018ABB0960
	public static void lUwudyWMKicvdDYOlOAiHMjSgEcj(IntPtr param_00073c69); // 0x000000018ABB0818-0x000000018ABB08BC
	public static IntPtr MHJxrABcIImHEyevoooKONwddsvQ(IntPtr param_00073c6a); // 0x000000018ABAFD7C-0x000000018ABAFE20
	public static int ztlzTIjgAXDKNEMgxnlhkQXrVnOD(IntPtr param_00073c6b); // 0x000000018ABB0D6C-0x000000018ABB0E10
	public static int amSFbSxgSxaxeNKePFRsBRhODgCj(IntPtr param_00073c6c, float param_00073c6d, uint param_00073c6e); // 0x000000018ABB0418-0x000000018ABB04E4
	public static int gaBBlfWoIYcnGKOiIRgLgVaTEaRCA(IntPtr param_00073c6f); // 0x000000018ABB0588-0x000000018ABB062C
	public static int FsbyMkSMOpwrdHnSeRoaODVKANlH(IntPtr param_00073c70); // 0x000000018ABAFB6C-0x000000018ABAFC10
	public static int zLuybkgsnsUtTrwghlaYJqRjseGt(IntPtr param_00073c71); // 0x000000018ABB0C8C-0x000000018ABB0D30
	public static int RyzUoOVywYCGxBIgLHQLebPAhVll(IntPtr param_00073c72); // 0x000000018ABB000C-0x000000018ABB00B0
}

internal abstract class awAAQgaTMaFquWqbjmYTlfVuPLmn : IntPtrWrapper // TypeDefIndex: 53944
{
	// Constructors
	public awAAQgaTMaFquWqbjmYTlfVuPLmn(IntPtr param_00073cce); // 0x0000000184D88BF0-0x0000000184D88C00
}

internal class emeCwsELnoJvwBwEcPKnJiieeMKWB : awAAQgaTMaFquWqbjmYTlfVuPLmn // TypeDefIndex: 53945
{
	// Constructors
	public emeCwsELnoJvwBwEcPKnJiieeMKWB(IntPtr param_00073ccf); // 0x0000000184D88BF0-0x0000000184D88C00
}

internal class vNRtVHTjVoyNCDmQcAzXxtkQARZr : emeCwsELnoJvwBwEcPKnJiieeMKWB // TypeDefIndex: 53946
{
	// Constructors
	public vNRtVHTjVoyNCDmQcAzXxtkQARZr(IntPtr param_00073cd0); // 0x0000000184D88BF0-0x0000000184D88C00
}

internal class vKhSWbjZBnXdiBtYsIvqFDDeKQgD : awAAQgaTMaFquWqbjmYTlfVuPLmn // TypeDefIndex: 53947
{
	// Constructors
	public vKhSWbjZBnXdiBtYsIvqFDDeKQgD(IntPtr param_00073cd1); // 0x0000000184D88BF0-0x0000000184D88C00
}

internal abstract class eymKPgAQNIgZhKCqIVYwnHlbhjdg : SATAzMAJRyYTzCBJGvFLRQVcCxJp // TypeDefIndex: 53948
{
	// Fields
	public readonly awAAQgaTMaFquWqbjmYTlfVuPLmn WRVMLbifHBwQBLkFCpNYIkjmlyHS; // 0x10
	public readonly ItgnJOvMvArQEKCRZgvhggJrcdcBb IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x18
	public readonly int WlmjUWgHhDkLHQSZYnEhFYvhjgvS; // 0x1C
	private EAUUbKQFcztOaxVulmGcrJehPchk PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x20
	private bool FbDmubKHHdXxcuYTfJFqIFYOuqnG; // 0x28
	protected bool zfllenkNdLbHHBHatIBLndEydOmgb; // 0x29
	protected vKhSWbjZBnXdiBtYsIvqFDDeKQgD JatpMknJonJZulEtSaQPQEgEHclx; // 0x30
	protected bool gijuZrHXIHTiFYgkdCupcnFNIibeb; // 0x38
	protected int wmIpsUFSaOewogOkLvkWvhcvIkdx; // 0x3C
	protected float[] toeDvbyvzAzHPYNhGpTbCXllddcY; // 0x40
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x48

	// Properties
	public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x000000018ABB8E9C-0x000000018ABB8EB4 
	public string FtcRGxQNIjALWmqPGdmabKWoWeGqA { get; } // 0x000000018ABB8B74-0x000000018ABB8B90 
	public string SvmsnETUSlePEWPKjGqPgpeaQhBCb { get; } // 0x000000018ABB8B58-0x000000018ABB8B74 
	public int WrZJIhOLVdLWUIrJApfNbpXUMNdG { get; } // 0x000000018ABB8B90-0x000000018ABB8BAC 
	public int KnragBIqiQeRNgMAwjMLFeBdfrAKB { get; } // 0x000000018ABB8AD0-0x000000018ABB8AEC 
	public PidVid eabRFvqklxoYMJPbeMmtEYziJBbB { get; } // 0x000000018ABB8E48-0x000000018ABB8E64 
	public Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; } // 0x000000018ABB8CE8-0x000000018ABB8D0C 
	public virtual YwnGomAALbeQxCXpVQwIDgzNouDmA psAUfTCmGaZDidaHRsWjLEaznECN { get; } // 0x00000001811EC580-0x00000001811EC590 
	public bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; } // 0x00000001812081B0-0x0000000181208610 
	public Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; } // 0x00000001811EC580-0x00000001811EC590 
	public bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; } // 0x00000001811F2A70-0x00000001811F2A80 
	public int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; } // 0x0000000184D86640-0x0000000184D86650 

	// Constructors
	protected eymKPgAQNIgZhKCqIVYwnHlbhjdg(awAAQgaTMaFquWqbjmYTlfVuPLmn param_00073cd2, EAUUbKQFcztOaxVulmGcrJehPchk param_00073cd3, ItgnJOvMvArQEKCRZgvhggJrcdcBb param_00073cd4); // 0x000000018ABB8C14-0x000000018ABB8C70

	// Methods
	public virtual void DKVpNyqREOIVACgmSVaaAXYjPvP(); // 0x000000018ABB8AEC-0x000000018ABB8B0C
	public virtual void cRSJGojFjxojRfSBwUsHksZOrqPe(); // 0x000000018ABB8C70-0x000000018ABB8C94
	private void xPBdvUPjjzkXVCZTuDzSdjNkafrP(); // 0x000000018ABB8E64-0x000000018ABB8E9C
	public abstract void Update(UpdateLoopType updateLoop);
	public abstract void UpdateFinished();
	public void ZoGbtSrjNkpybJlqlhkJDQCcPlkF(); // 0x00000001841E1670-0x00000001841E1680
	public void IoyeuUADILkjyEidcCIyeCInNLwS(); // 0x00000001841E1670-0x00000001841E1680
	public virtual bool ktgGdIfNDRudeuiYQdNnefAmyiVaA(); // 0x000000018ABB8E28-0x000000018ABB8E48
	public void hJVWdluocTccqfVOELDXAeXkkPPlA(int param_00073cd6, float param_00073cd7, bool param_00073cd8); // 0x000000018ABB8D0C-0x000000018ABB8E28
	public void eEnRZrPQkNXhsmIjYHcmHsAiBpVj(); // 0x000000018ABB8C94-0x000000018ABB8CE8
	public void Dispose(); // 0x000000018ABB8B0C-0x000000018ABB8B58
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABB8BB8-0x000000018ABB8C14
	protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073cd9); // 0x000000018ABB8BAC-0x000000018ABB8BB8
	protected abstract void FWwXtpLDXpNEVxDZFIrCEZiSGYLi();
	protected abstract void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA();
}

internal enum mRjzAKSnuWBoVcYwzfxaYuEXQlkL : byte // TypeDefIndex: 53949
{
	Button = 0,
	Axis = 1,
	Hat = 2,
	Ball = 3
}

internal enum ItgnJOvMvArQEKCRZgvhggJrcdcBb // TypeDefIndex: 53950
{
	Joystick = 0,
	Gamepad = 1
}

internal enum YwnGomAALbeQxCXpVQwIDgzNouDmA // TypeDefIndex: 53951
{
	Joystick = 0,
	Gamepad = 1,
	Mouse = 2,
	Keyboard = 3
}

internal class HMtmYXFGOgHuhDFfOFddFYSgYpDVA : dnxyCjpDlDvOdxTyzeYVqByiyZzK // TypeDefIndex: 53952
{
	// Properties
	public override YwnGomAALbeQxCXpVQwIDgzNouDmA psAUfTCmGaZDidaHRsWjLEaznECN { get; } // 0x0000000184D85B80-0x0000000184D85B90 

	// Constructors
	public HMtmYXFGOgHuhDFfOFddFYSgYpDVA(vNRtVHTjVoyNCDmQcAzXxtkQARZr param_00073cda, EAUUbKQFcztOaxVulmGcrJehPchk param_00073cdb); // 0x000000018ABB3F64-0x000000018ABB3F98

	// Methods
	public override bool ktgGdIfNDRudeuiYQdNnefAmyiVaA(); // 0x000000018ABB3F98-0x000000018ABB3FB8
	protected override void FWwXtpLDXpNEVxDZFIrCEZiSGYLi(); // 0x000000018ABB3EDC-0x000000018ABB3F64
	protected override void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA(); // 0x000000018ABB3E74-0x000000018ABB3EDC
}

internal class EUduSDIlhfiaIBoNLnCGNzHdzizb : PlatformInputManager // TypeDefIndex: 53958
{
	// Fields
	private IInputSource IAmByAEMxeEeStLlLVFgPdffNLub; // 0x38
	private List<NzfnZqexdZgkSScFXWJZEzeOWPul> PCdPJbHLsogIbJECApXLUpgSXfnrA; // 0x40
	private int kGiRolZJJVXJXFIbgdrtzARRRwXB; // 0x48
	private oUOKGHnKbmgVUnxustBbqqMKFIAR CXazGSMYzoifXDbkIaaNsbkSZbeP; // 0x50
	private bool KdmwGnYbMHfNjoxROCJtGTeOPvzrA; // 0x58
	private Action<int, ControllerDataUpdater> HqGgQZphbXxVTpfvwnRAAhNlMQRI; // 0x60
	private PlatformInputManager DeuaCkgWrfMxvbuXImykIcuYIdCrA; // 0x68
	private readonly bool axkKvliPJxIEjkBAIyuBFFzRUJZj; // 0x70
	private readonly bool WVkPZPERjqJrUTkyeJPxPWSPJUUe; // 0x71
	private readonly bool blXhVnJwmDqRDEWaVygZFlMlUjnd; // 0x72
	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0x78
	private readonly Func<int> bMdbmKyqgyUaZuaPJHLNCqnGNHeDb; // 0x80

	// Properties
	[CustomObfuscation(rename = false)]
	public override int deviceCount { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000184D86230-0x0000000184D86240 
	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType { get; } // 0x0000000184DA89E0-0x0000000184DA89F0 

	// Nested types
	private class NzfnZqexdZgkSScFXWJZEzeOWPul : IInputManagerJoystick // TypeDefIndex: 53953
	{
		// Fields
		private int SAwUWSkGKioQPDUaFBSUbXjjqYIM; // 0x10
		private int JPJrLcYgPhcXVbQwetbymmJfKAmH; // 0x14
		public Guid CxzTsJSuiZuoQzFIXAHesNKBJEGIA; // 0x18
		public string KAhPhNCPIOUGWydRQSumNKzZsKNx; // 0x28
		public eYBCsGBkYgpZlfwGcBnLcsBJbMwt MiuPDXtHjMqEUmptccKlmIrdlHeg; // 0x30
		public YwnGomAALbeQxCXpVQwIDgzNouDmA FeydSgDjtypCTgePURUdNlOclvVRA; // 0x38
		public string OdwcoirgKSaKAyWcFNqRQfZjFlf; // 0x40
		public string ZBXDeTKjYkolMiTdwUasCHQiPdAIb; // 0x48
		public int mDfvIrfTdctiyDRPfEHZSUBTcTRU; // 0x50
		public int GcDXLONUdcLWGUjNnLEwuJedpMpo; // 0x54
		public Guid dSGbyFpzdTFOQmSkWyqzIpgdaMdh; // 0x58
		public PidVid UpyzrRZKfKsNDZOSBiHvfgsXnMEj; // 0x68
		public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x6C
		public int bFaTouXVRSbUDxnKoDJaMwjffcUaA; // 0x7C
		public int leCIWodzSMNIJlvlcmjWenntrvEL; // 0x80
		public int sUZajWKojtfXOShyZQsGsfIaDzTFA; // 0x84
		public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x88
		public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x8C
		public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x90
		public bool IfcdjuIFoCXolpufCEJxbAlFVrcc; // 0x94
		public bool lDGUseilaXGQbkQZzhoWsJSOEiWlA; // 0x95
		public int wmIpsUFSaOewogOkLvkWvhcvIkdx; // 0x98
		private float[] WfmlOHFCVeUNZVCPhDBiDsPajnMg; // 0xA0
		private bool[] yyCeayeEvvFNGKjODQMmSEtKmaSuA; // 0xA8
		private HardwareJoystickMap_InputManager CYjJHFxAtePWANrtsNPovmhwWUDX; // 0xB0
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> koSqWjMBvARGEpFxGTFrQrSPEuGt; // 0xB8
		private bool nBhrPsWcWrCUgCUSDZmuJHYHdMDR; // 0xC0
		private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0xC1
		[CompilerGenerated]
		private Rewired.Controller.Extension ZZNbPgECnscaJlWQDXZbQJUjJQXeb; // 0xC8

		// Properties
		[CustomObfuscation(rename = false)]
		public int rewiredId { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		[CustomObfuscation(rename = false)]
		public int inputManagerId { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		[CustomObfuscation(rename = false)]
		public string name { get; } // 0x0000000184D86240-0x0000000184D86250 
		[CustomObfuscation(rename = false)]
		public long? systemId { get; } // 0x000000018ABB5F04-0x000000018ABB5F64 
		[CustomObfuscation(rename = false)]
		public int unityId { get; } // 0x00000001811EC580-0x00000001811EC590 
		[CustomObfuscation(rename = false)]
		public Guid instanceGuid { get; } // 0x0000000184D87E00-0x0000000184D87E10 
		[CustomObfuscation(rename = false)]
		public Guid persistentGuid { get; } // 0x0000000184D87E00-0x0000000184D87E10 
		[CustomObfuscation(rename = false)]
		public Rewired.Controller.Extension extension { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x0000000186AC5B30-0x0000000186AC5B44

		// Constructors
		public NzfnZqexdZgkSScFXWJZEzeOWPul(Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_00073d03); // 0x000000018ABB5EDC-0x000000018ABB5F04

		// Methods
		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex); // 0x000000018ABB5C1C-0x000000018ABB5C40
		[CustomObfuscation(rename = false)]
		public void StopVibration(); // 0x00000001841E1670-0x00000001841E1680
		public void pYQRzXnykRQYsfpIPhseqdKvyUyv(); // 0x000000018ABB64E4-0x000000018ABB668C
		public void zdydrJEThCgTgeIKlxbRirIgPrdgB(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d04); // 0x000000018ABB6748-0x000000018ABB6834
		[CustomObfuscation(rename = false)]
		public void Update(); // 0x000000018ABB5D9C-0x000000018ABB5E10
		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018ABB5290-0x000000018ABB53E4
		public int HzPmTNZHjTeMRqJVTLSBKHKRLNFG(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d06); // 0x000000018ABB53E4-0x000000018ABB54B0
		private BridgedControllerHWInfo QaexLfVSNbNHhboOvHEvgYdhcbmt(); // 0x000000018ABB5BBC-0x000000018ABB5C1C
		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController(); // 0x000000018ABB5CD8-0x000000018ABB5D38
		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x000000018ABB5D38-0x000000018ABB5D9C
		private void NkoqbCbQUJeDuCjzLLadeyqGfntS(); // 0x000000018ABB56A8-0x000000018ABB5790
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(); // 0x000000018ABB668C-0x000000018ABB6748
		private void UxgsasKuGqopgQwFFISfZULSApaI(HardwareJoystickMap.Platform_SDL2_Base.Axis param_00073d07, int param_00073d08); // 0x000000018ABB5E10-0x000000018ABB5EAC
		private void SlxylFVFbDNoNznWgcjBPYhvekkC(HardwareJoystickMap.Platform_SDL2_Base.Button param_00073d09, int param_00073d0a); // 0x000000018ABB5C40-0x000000018ABB5CD8
		private float DYxtgWHqYudqjBhVQJKzjymElHwy(HardwareJoystickMap.Platform_SDL2_Base.Axis param_00073d0b); // 0x000000018ABB5140-0x000000018ABB5290
		private bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(HardwareJoystickMap.Platform_SDL2_Base.Button param_00073d0c); // 0x000000018ABB5F64-0x000000018ABB6238
		private bool nRdiXbbkJNZLWvmBZlGjEqPPBccI(int param_00073d0d, int param_00073d0e, HatType param_00073d0f); // 0x000000018ABB6238-0x000000018ABB62D4
		private float mSxgldHAJNIiJDyPeUSIRNKVYLSqb(int param_00073d10, Rewired.Data.Mapping.AxisDirection param_00073d11); // 0x000000018AB842E0-0x000000018AB8432C
		private ControlDeviceType BCgWEkBQDSIocFrfafoaaDZZIqEv(YwnGomAALbeQxCXpVQwIDgzNouDmA param_00073d12); // 0x000000018ABB5114-0x000000018ABB5140
		private void ODjDNosGTVTcApOFJHPRXXJKAaMW(); // 0x000000018ABB5790-0x000000018ABB5BBC
		private string IeuDBTyfoXaFRBEPsPJzcxogdisx(); // 0x000000018ABB54B0-0x000000018ABB56A8
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedControllerHWInfo param_00073d13); // 0x000000018ABB63D0-0x000000018ABB64E4
		private void nTCBmuLlaOPLgCgiTpWPxqNDfOdw(BridgedController param_00073d14); // 0x000000018ABB62D4-0x000000018ABB63D0
		private UnknownControllerHat[] AksIjPlBzYIerpYGUHpsdbhDSeVW(); // 0x000000018ABB4F54-0x000000018ABB5114
		public static int PUwZSLuKHRgBeBIdtZbaoZgHIMdBA(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d15, NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d16); // 0x000000018AB0699C-0x000000018AB069CC
		public static int ZTOwqxDJXpohSLyPoOMAhofMtKMo(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d17, NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d18); // 0x000000018ABB5EAC-0x000000018ABB5EDC
	}

	private class oUOKGHnKbmgVUnxustBbqqMKFIAR // TypeDefIndex: 53957
	{
		// Fields
		private List<JVfHduEdjteOzOpMhmxTIlGBvTXP> kfYfqEcEuytPhEMEULSfGPpdWoee; // 0x10

		// Nested types
		public enum fJVfptvxSiGstmLDuwjqSLUyzAnG // TypeDefIndex: 53954
		{
			Exact = 0,
			Approximate = 1
		}

		public class JVfHduEdjteOzOpMhmxTIlGBvTXP // TypeDefIndex: 53955
		{
			// Fields
			public int ZewBubFBTMGdguZhicDjJwXDMzqL; // 0x10
			public Guid RuUyWLJiWbqVBpGrMytXGugwnZGo; // 0x14
			public Guid ZXBCfhHBMvuWTVnrGPZhlFILPuWQ; // 0x24
			public int JXScdMHyYyhMIpOYqnnMPyDeWaAgA; // 0x34
			public int swdovXOcPkGjCwdsHtSJRIrDvDpJ; // 0x38
			public int fAEaitKCsCmFcBIuJUHPzttPmnpTA; // 0x3C
			public int GLSLJeVDquUKRLDTtYNqebBYfdCK; // 0x40

			// Constructors
			public JVfHduEdjteOzOpMhmxTIlGBvTXP(); // 0x00000001841E1670-0x00000001841E1680

			// Methods
			public bool HzPmTNZHjTeMRqJVTLSBKHKRLNFG(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d1f, fJVfptvxSiGstmLDuwjqSLUyzAnG param_00073d20); // 0x000000018ABC71C8-0x000000018ABC72B4
		}

		[CompilerGenerated]
		private sealed class nKrAmqahJMUsOOFjEQdTCPNJLcXfB : IEnumerable<JVfHduEdjteOzOpMhmxTIlGBvTXP>, IEnumerator<JVfHduEdjteOzOpMhmxTIlGBvTXP> // TypeDefIndex: 53956
		{
			// Fields
			private int fYQgehhaxgmucoHwUcKeBQGOPxQf; // 0x10
			private JVfHduEdjteOzOpMhmxTIlGBvTXP rEnDOlfBAoeCjPebviBVAehVjPn; // 0x18
			private int IZBclvIYPYqsRntRbExTPuWmERphA; // 0x20
			public oUOKGHnKbmgVUnxustBbqqMKFIAR fssrnmhfPTfupcxFxQGSQWsdnHnDA; // 0x28
			private NzfnZqexdZgkSScFXWJZEzeOWPul PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x30
			public NzfnZqexdZgkSScFXWJZEzeOWPul hisBWedFwfgnWcdvDaDbceiyvEbrc; // 0x38
			private fJVfptvxSiGstmLDuwjqSLUyzAnG oXtqEqZfQuyKWUrFJKdmMIOQHjsBA; // 0x40
			public fJVfptvxSiGstmLDuwjqSLUyzAnG MpkzjDbhaZctoAPhNvsdAaUgKnCJ; // 0x44
			private int oqwDyyTMKnSedrldMxUmixFEHvcE; // 0x48
			private int JbCuPbQlPJerRbkBryzmjprgTJnI; // 0x4C

			// Properties
			JVfHduEdjteOzOpMhmxTIlGBvTXP IEnumerator<Rewired.InputSources.SDL2.SDL2InputManager.JoystickRecords.Record>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 

			// Constructors
			[DebuggerHidden]
			public nKrAmqahJMUsOOFjEQdTCPNJLcXfB(int param_00073d21); // 0x00000001891B1F10-0x00000001891B1F44

			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018ABCCEEC-0x000000018ABCCFE4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ABCD0A8-0x000000018ABCD0F4
			[DebuggerHidden]
			IEnumerator<JVfHduEdjteOzOpMhmxTIlGBvTXP> System.Collections.Generic.IEnumerable<Rewired.InputSources.SDL2.SDL2InputManager.JoystickRecords.Record>.GetEnumerator(); // 0x000000018ABCCFE4-0x000000018ABCD0A0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018ABCD0A0-0x000000018ABCD0A8
		}

		// Constructors
		public oUOKGHnKbmgVUnxustBbqqMKFIAR(); // 0x000000018ABB93BC-0x000000018ABB9434

		// Methods
		public void oeWKkKFoQYQjZrnTprfFYxpVhrZv(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d19); // 0x000000018ABB9434-0x000000018ABB96E0
		public IEnumerable<JVfHduEdjteOzOpMhmxTIlGBvTXP> rPEMzZmJunpFkQUNyRKTxEVSsvJu(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073d1a, fJVfptvxSiGstmLDuwjqSLUyzAnG param_00073d1b); // 0x000000018ABB96E0-0x000000018ABB9778
		private void QKCfzjnPNjViQblauEfiHIvbjBzFA(int param_00073d1c, Guid param_00073d1d, int param_00073d1e); // 0x000000018ABB9294-0x000000018ABB93BC
	}

	// Constructors
	public EUduSDIlhfiaIBoNLnCGNzHdzizb(ConfigVars param_00073cdc, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> param_00073cdd, Func<int> param_00073cde, bool param_00073cdf, bool param_00073ce0, bool param_00073ce1); // 0x000000018ABB1F44-0x000000018ABB2178

	// Methods
	[CustomObfuscation(rename = false)]
	public override void Initialize(); // 0x000000018ABB11BC-0x000000018ABB1234
	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop); // 0x000000018ABB1B24-0x000000018ABB1CAC
	[CustomObfuscation(rename = false)]
	public override void OnDestroy(); // 0x000000018ABB1378-0x000000018ABB147C
	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000184D86280-0x0000000184D86290
	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x000000018ABB1A70-0x000000018ABB1B24
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected(); // 0x000000018ABB1A38-0x000000018ABB1A54
	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected(); // 0x000000018ABB1A54-0x000000018ABB1A70
	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001841E1670-0x00000001841E1680
	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x00000001811EC580-0x00000001811EC590
	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x00000001811EC580-0x00000001811EC590
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(); // 0x000000018ABB147C-0x000000018ABB14A0
	private void RhgInQuUBnQMTDjkeZBGAYpMBRql(IList<eYBCsGBkYgpZlfwGcBnLcsBJbMwt> param_00073ce7); // 0x000000018ABB14A0-0x000000018ABB1A38
	private void yJJCtBCrCEsbprFwlpsOnWBkGRvrA(); // 0x000000018ABB2304-0x000000018ABB2374
	private IList<eYBCsGBkYgpZlfwGcBnLcsBJbMwt> AlkKsBlkcKIlWhlVuLZJCJDXfHCgb(); // 0x000000018ABB0E10-0x000000018ABB0E58
	private void FVpBjAwyGBpVQpbIGUMUuPmYWCYq(int param_00073ce8, int param_00073ce9, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cea, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073ceb); // 0x000000018ABB0E58-0x000000018ABB1060
	private bool ymbuqHxpmIVcyliPHUJTGDZqcnEJA(List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cec, int param_00073ced); // 0x000000018ABB2374-0x000000018ABB241C
	private int gYLinYswKgWgjjceGEMBKlqvhlEGb(List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cee); // 0x000000018ABB2178-0x000000018ABB2220
	private bool iXsRWfwjaxOSbFdmAXxVCIUyoIxI(List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cef, int param_00073cf0); // 0x000000018ABB2280-0x000000018ABB2304
	private void NQvRARFJpLxdsIUPRkuuXQTUjNox(int param_00073cf1, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cf2, int param_00073cf3, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cf4, oUOKGHnKbmgVUnxustBbqqMKFIAR.fJVfptvxSiGstmLDuwjqSLUyzAnG param_00073cf5); // 0x000000018ABB1234-0x000000018ABB1378
	private void XxteBwdFImtrzajKwxGejbRDStnH(int param_00073cf6, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cf7, oUOKGHnKbmgVUnxustBbqqMKFIAR.fJVfptvxSiGstmLDuwjqSLUyzAnG param_00073cf8); // 0x000000018ABB1CAC-0x000000018ABB1F2C
	private void FmRdMrTyVCXeXzKnHASejEPxgddh(); // 0x000000018ABB1060-0x000000018ABB1088
	private void GOiJYHNLShkFyPFsoSQwzPnKQhdP(List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cf9, List<NzfnZqexdZgkSScFXWJZEzeOWPul> param_00073cfa, bool param_00073cfb); // 0x000000018ABB1088-0x000000018ABB11BC
	private void iEEFlbFDszRppifBFnwpNApzASvF(NzfnZqexdZgkSScFXWJZEzeOWPul param_00073cfc, bool param_00073cfd); // 0x000000018ABB2220-0x000000018ABB2280
	private void YRTktFeeUAVOaQxmZgkJtHesqmqO(); // 0x000000018ABB1F2C-0x000000018ABB1F44
}

internal interface SATAzMAJRyYTzCBJGvFLRQVcCxJp : IDisposable // TypeDefIndex: 53960
{
	// Properties
	string FtcRGxQNIjALWmqPGdmabKWoWeGqA { get; }
	string SvmsnETUSlePEWPKjGqPgpeaQhBCb { get; }
	int WrZJIhOLVdLWUIrJApfNbpXUMNdG { get; }
	int KnragBIqiQeRNgMAwjMLFeBdfrAKB { get; }
	PidVid eabRFvqklxoYMJPbeMmtEYziJBbB { get; }
	Guid lAPlbdTpUUTlIXjXMGhYOvVvirGw { get; }
	YwnGomAALbeQxCXpVQwIDgzNouDmA psAUfTCmGaZDidaHRsWjLEaznECN { get; }
	bool tLrAyVcCEurtcBKhkxyJlRolMCZB { get; }
	Rewired.Controller.Extension pRKzCmAPObGnLKFLapCPeGiCIBrub { get; }
	bool xqUYbLPLrmFdyZFIgZvzennsaPdQ { get; }
	int JRFeOiKXgtgggVSSKsmUhCRRAWyd { get; }

	// Methods
	void Update(UpdateLoopType updateLoop);
	void UpdateFinished();
	void ZoGbtSrjNkpybJlqlhkJDQCcPlkF();
	void IoyeuUADILkjyEidcCIyeCInNLwS();
	bool ktgGdIfNDRudeuiYQdNnefAmyiVaA();
	void hJVWdluocTccqfVOELDXAeXkkPPlA(int param_00073d55, float param_00073d56, bool param_00073d57);
	void eEnRZrPQkNXhsmIjYHcmHsAiBpVj();
}

internal interface eYBCsGBkYgpZlfwGcBnLcsBJbMwt : SATAzMAJRyYTzCBJGvFLRQVcCxJp // TypeDefIndex: 53961
{
	// Properties
	int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; }
	int iNOQjioNbBRxJPHSCBvgxibcstpi { get; }
	int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; }
	int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; }
	InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; }
	bool kvhxEchYAeVevuDKBFpXXYUTZopc { get; }

	// Methods
	float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_00073d58);
	bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(int param_00073d59);
	int ImLuWROnVBPkqNCjYBWRnhyTStaH(int param_00073d5a);
}

internal class dnxyCjpDlDvOdxTyzeYVqByiyZzK : eymKPgAQNIgZhKCqIVYwnHlbhjdg, eYBCsGBkYgpZlfwGcBnLcsBJbMwt // TypeDefIndex: 53962
{
	// Fields
	public readonly int FyijsPYPkZofyZbVExmyRvDMcNhH; // 0x50
	public readonly int InPIThWQyaFVIFkmyUeeDBeqAMth; // 0x54
	public readonly int jMIcgSCcVqglVFaWBJvNQBYgxfJs; // 0x58
	public readonly int fZhkbMsNGeFoaDFDXtCZgFoHMjnH; // 0x5C
	public readonly short[] idtBmUHjFaBXkGQyOoBfYzCXBJkX; // 0x60
	private readonly ButtonLoopSet IHIyAzYqVGZzizmnkIHKmAeHgozdA; // 0x68
	public readonly short[] NdZqsAWRwGDZFDXirqfvKUrdkGBZA; // 0x70
	public readonly short[] EAhCsmfvgEBVCGwCmWpJfjGIcGJm; // 0x78
	private bool IChuAIFqQqdhkCxewvXZoMKPBgMeA; // 0x80

	// Properties
	public int aEzAgIVEqKcrAAUPDMqCfKbgZYrTb { get; } // 0x0000000184D86310-0x0000000184D86320 
	public int iNOQjioNbBRxJPHSCBvgxibcstpi { get; } // 0x0000000184D86550-0x0000000184D86560 
	public int hpHEWblMORJTJvPPqjDYAUiPxJQN { get; } // 0x0000000184D86540-0x0000000184D86550 
	public int ACEOXLRCsNdDCWUGWYRzsPIHAeoBA { get; } // 0x0000000184D86570-0x0000000184D86580 
	public InputSource zERCWzsvIRQVvGinECtcGVMfFapFb { get; } // 0x0000000184DA89E0-0x0000000184DA89F0 
	public bool kvhxEchYAeVevuDKBFpXXYUTZopc { get; } // 0x0000000184D8D1F0-0x0000000184D8D200 

	// Constructors
	public dnxyCjpDlDvOdxTyzeYVqByiyZzK(emeCwsELnoJvwBwEcPKnJiieeMKWB param_00073d5b, EAUUbKQFcztOaxVulmGcrJehPchk param_00073d5c); // 0x000000018ABCAD84-0x000000018ABCADA0
	protected dnxyCjpDlDvOdxTyzeYVqByiyZzK(emeCwsELnoJvwBwEcPKnJiieeMKWB param_00073d5d, EAUUbKQFcztOaxVulmGcrJehPchk param_00073d5e, ItgnJOvMvArQEKCRZgvhggJrcdcBb param_00073d5f); // 0x000000018ABCADA0-0x000000018ABCADF8
	protected dnxyCjpDlDvOdxTyzeYVqByiyZzK(awAAQgaTMaFquWqbjmYTlfVuPLmn param_00073d60, EAUUbKQFcztOaxVulmGcrJehPchk param_00073d61, ItgnJOvMvArQEKCRZgvhggJrcdcBb param_00073d62, int param_00073d63, int param_00073d64, int param_00073d65, int param_00073d66); // 0x000000018ABCAC14-0x000000018ABCAD84

	// Methods
	public void XRbfXMBnELvQWROZJCQXJkBLAYkh(mRjzAKSnuWBoVcYwzfxaYuEXQlkL param_00073d67, byte param_00073d68, short param_00073d69, double param_00073d6a); // 0x000000018ABCAB28-0x000000018ABCAC14
	public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073d6b); // 0x000000018ABCAA60-0x000000018ABCAAB4
	public override void rtVwRpwCmfbNsKOJOmhtvzHenwRDA(); // 0x000000018ABCAE80-0x000000018ABCAED4
	public float DYxtgWHqYudqjBhVQJKzjymElHwy(int param_00073d6c); // 0x000000018ABCA820-0x000000018ABCA868
	public bool lrsQAhdkMHwMfBaOmoegOfkmAFnX(int param_00073d6d); // 0x000000018ABCADF8-0x000000018ABCAE80
	public int ImLuWROnVBPkqNCjYBWRnhyTStaH(int param_00073d6e); // 0x000000018ABCA9CC-0x000000018ABCAA10
	protected void HZsdiEZvykgsHaxzaLWnbNlmEyfAA(emeCwsELnoJvwBwEcPKnJiieeMKWB param_00073d6f); // 0x000000018ABCA8B0-0x000000018ABCA9CC
	protected override void FWwXtpLDXpNEVxDZFIrCEZiSGYLi(); // 0x000000018ABCA868-0x000000018ABCA8B0
	protected override void AJjHQkSWCXEVFGwQfDDPGjmhdXBbA(); // 0x000000018ABCA7B8-0x000000018ABCA820
	private float MooJfwCJmltiYVFDwnfNcYcaEqtH(int param_00073d70); // 0x000000018ABCAA10-0x000000018ABCAA60
	private int UyTdZLDnPVBTdbBLEhLJzrknCbCnb(short param_00073d71); // 0x000000018ABCAAB4-0x000000018ABCAB28
}

internal class EAUUbKQFcztOaxVulmGcrJehPchk // TypeDefIndex: 53963
{
	// Fields
	public int xmhBzZvHjrDXSYjquxxdImhALvdn; // 0x10
	public int XWFDBbuFJdbEGJFmBTChsyFOLZHr; // 0x14
	public bool kdXdhocgreeSSYUPOAvkumkvRivqA; // 0x18
	public string fhXhHAFYUatrCVJyJGUYsEOPDbKI; // 0x20
	public string ZBXDeTKjYkolMiTdwUasCHQiPdAIb; // 0x28
	public Guid fGVLAJffwPzCYZdBrLRIjVwTOvuj; // 0x30
	public Guid xbJGrqtOvXsUXyDbJZwPZLUhXfCl; // 0x40
	public int FyijsPYPkZofyZbVExmyRvDMcNhH; // 0x50
	public int InPIThWQyaFVIFkmyUeeDBeqAMth; // 0x54
	public int jMIcgSCcVqglVFaWBJvNQBYgxfJs; // 0x58
	public int fZhkbMsNGeFoaDFDXtCZgFoHMjnH; // 0x5C
	public PidVid UpyzrRZKfKsNDZOSBiHvfgsXnMEj; // 0x60
	public Guid RuUyWLJiWbqVBpGrMytXGugwnZGo; // 0x64
	public int GcDXLONUdcLWGUjNnLEwuJedpMpo; // 0x74
	public int mDfvIrfTdctiyDRPfEHZSUBTcTRU; // 0x78

	// Constructors
	public EAUUbKQFcztOaxVulmGcrJehPchk(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public void pYQRzXnykRQYsfpIPhseqdKvyUyv(); // 0x000000018ABC65F8-0x000000018ABC67A0
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABC67A0-0x000000018ABC6B70
}

internal static class CkYAeLjuGywRgkcwnFEDEdreeWUH // TypeDefIndex: 53964
{
	// Methods
	public static string[] nkbwzzXaxJDZxDlleLaIiCTWIrSA(); // 0x000000018ABBF684-0x000000018ABBF6F4
	private static string[] DKHcXCDshgIueEpuCgDvHRrgWKXPc(byte[] param_00073d72); // 0x000000018ABBF4B8-0x000000018ABBF5C4
	private static string AOgsqWWfIUAdPERQNfNKylGprhJo(byte[] param_00073d73, byte[] param_00073d74, byte[] param_00073d75); // 0x000000018ABBEF68-0x000000018ABBF4B8
	private static byte[] XziEXFEDZzYTTTkiVhpDDbaCBLOwB(); // 0x000000018ABBF624-0x000000018ABBF684
	private static byte[] ydEFHkgSZwLwmEkIXLgfUjsVRlcS(); // 0x000000018ABBF6F4-0x000000018ABBF754
	private static byte[] LpauIRVxRMhdbthiybZkdHetkWry(); // 0x000000018ABBF5C4-0x000000018ABBF624
}

internal class BMNnWbDIXUHHRoADwVXJdYVDrPxr : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53965
{
	// Fields
	public readonly float[] nXdBpypsCihkGgjdHnUwIADZGegB; // 0x20
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x28
	public readonly int pbDDxnkDGOFFxgurHgDSPHXKbAtm; // 0x30
	private readonly byte[] nHisCqzKiJPnvrBApmQCTQgKQacL; // 0x38
	private readonly int uHOVCRuRsdksMClfpvoNHVetaXYr; // 0x40
	private readonly int ileFirqiBVUBcxKKxTpSyHDMLaLL; // 0x44
	private readonly Action<byte[], float[]> YwiPAftMvGgmgCcORnlZzluKFMEMA; // 0x48

	// Constructors
	public BMNnWbDIXUHHRoADwVXJdYVDrPxr(byte param_00073d76, HIDInfo param_00073d77, int param_00073d78, Action<byte[], float[]> param_00073d79); // 0x000000018ABBEC5C-0x000000018ABBED4C

	// Methods
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073d7a, double param_00073d7b); // 0x000000018ABBEBA4-0x000000018ABBEC5C
}

internal class MkXjQPavsbpITCEdETTHuRYirZF : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53966
{
	// Fields
	public int nXdBpypsCihkGgjdHnUwIADZGegB; // 0x20
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x28
	public readonly int uHOVCRuRsdksMClfpvoNHVetaXYr; // 0x30
	public readonly int ileFirqiBVUBcxKKxTpSyHDMLaLL; // 0x34
	public readonly bool OPLGUNKAzNfqGTawQeyfghijtEMfA; // 0x38
	public readonly int EKHJcbfdiOxIKQyApVokJmmMTIjV; // 0x3C
	public readonly int jaVhanxHYQhtApmJxhnCOYQeHWYO; // 0x40
	public readonly int kSwmEyHjVuCPsrTRRDEKURcgTEAV; // 0x44

	// Constructors
	public MkXjQPavsbpITCEdETTHuRYirZF(byte param_00073d7c, HIDInfo param_00073d7d, bool param_00073d7e, int param_00073d7f); // 0x000000018ABC745C-0x000000018ABC74C8

	// Methods
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073d80, double param_00073d81); // 0x000000018ABC73A4-0x000000018ABC745C
}

internal class lvcscUNtHDcrkMfwArDXBcZCtwpB : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53967
{
	// Fields
	public bool nXdBpypsCihkGgjdHnUwIADZGegB; // 0x20
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x28

	// Constructors
	public lvcscUNtHDcrkMfwArDXBcZCtwpB(byte param_00073d82, HIDInfo param_00073d83); // 0x0000000183219380-0x0000000183219390

	// Methods
	public void XRbfXMBnELvQWROZJCQXJkBLAYkh(bool param_00073d84, double param_00073d85); // 0x0000000184DA8E60-0x0000000184DA8E70
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073d86, double param_00073d87); // 0x000000018ABCCE5C-0x000000018ABCCE98
}

internal struct SAcTodLryXZPmeZqsKbnQQxsbBmo // TypeDefIndex: 53968
{
	// Fields
	public IntPtr nHisCqzKiJPnvrBApmQCTQgKQacL; // 0x00
	public int OUnbaSihhLonWaJkIIyKrNHGnfUM; // 0x08
	public int PVHoQRWIcRaBiBuQfUwXDwDuZfsU; // 0x0C
	public AnBliHBmROTlQRPQOqeIZLIecGsj QIFfqVFzAOVHXQCtcKcTtPAIinvib; // 0x10

	// Properties
	public bool mqRCtAxaQaFWMUPrNugLezEtRAku { get; } // 0x000000018ABC8C44-0x000000018ABC8C58 

	// Constructors
	public SAcTodLryXZPmeZqsKbnQQxsbBmo(IntPtr param_00073d88, int param_00073d89, int param_00073d8a); // 0x0000000184DA8DD0-0x0000000184DA8DF0

	// Methods
	public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABC89F0-0x000000018ABC8C44
}

internal abstract class zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53970
{
	// Fields
	public readonly byte jLKgYPbCXIqnNylkRhlRiDlyritOA; // 0x10
	public readonly HIDInfo odkWVCuUSdfhMibeenGTyuClPMR; // 0x18

	// Nested types
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class HIDInfo // TypeDefIndex: 53969
	{
		// Fields
		public ushort usagePage; // 0x10
		public ushort usage; // 0x12
		public int dataIndex; // 0x14
		public int bitSize; // 0x18
		public int logicalMin; // 0x1C
		public int logicalMax; // 0x20
		public int physicalMin; // 0x24
		public int physicalMax; // 0x28
		public uint units; // 0x2C
		public uint unitsExp; // 0x30

		// Constructors
		public HIDInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public zseGNggMpNmuvgqogMqiEcjsNLTGc(byte param_00073d8b, HIDInfo param_00073d8c); // 0x0000000183219380-0x0000000183219390

	// Methods
	public abstract void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073d8d, double param_00073d8e);
}

internal abstract class BrezXUXIUZIUDqjwzOgFxvkVSabY : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53973
{
	// Fields
	internal OoscetqJhudXgEciDHFwzOydVvnF OQuDWCRCmZkGoHBTJAXxelJXcmSj; // 0x20

	// Nested types
	internal abstract class OoscetqJhudXgEciDHFwzOydVvnF // TypeDefIndex: 53971
	{
		// Fields
		private int TcjJRWjshTQwocwamIBcpjKiRmed; // 0x10
		private int[] cZwmHMjnbBIXySfnVjYXinlAUyBJA; // 0x18
		protected iauVjjFObNvkjJmbggvouVWygepEA[] jeDVBuCiLeNXiUiAaKpbhZdLcwVc; // 0x20
		public iauVjjFObNvkjJmbggvouVWygepEA oYPZFLGywBnSGVLHccaqLJKYvonu; // 0x28
		private int MeQTwwwWuxbPbCwSdXRnErDdZLPE; // 0x30
		private int KUxRDTEonuYEoEETGmVFHGJtIfIBA; // 0x34
		private bool FbDmubKHHdXxcuYTfJFqIFYOuqnG; // 0x38

		// Properties
		public UpdateLoopType pFEhljMHttGCkHPDZdESaDYgtFFob { set; } // 0x000000018ABC83C0-0x000000018ABC841C

		// Constructors
		public OoscetqJhudXgEciDHFwzOydVvnF(); // 0x0000000184DA8DC0-0x0000000184DA8DD0

		// Methods
		public void ZKVquzDWqTgHeItuLmTWcFhwVgaF(UpdateLoopSetting param_00073d94, Func<UpdateLoopType, iauVjjFObNvkjJmbggvouVWygepEA> param_00073d95); // 0x000000018ABC8030-0x000000018ABC83C0
		public virtual void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073d96); // 0x000000018ABC8020-0x000000018ABC8030
	}

	internal abstract class iauVjjFObNvkjJmbggvouVWygepEA // TypeDefIndex: 53972
	{
		// Fields
		public readonly UpdateLoopType pFEhljMHttGCkHPDZdESaDYgtFFob; // 0x10

		// Constructors
		public iauVjjFObNvkjJmbggvouVWygepEA(UpdateLoopType param_00073d97); // 0x00000001814F51F0-0x00000001814F5220
	}

	// Constructors
	public BrezXUXIUZIUDqjwzOgFxvkVSabY(OoscetqJhudXgEciDHFwzOydVvnF param_00073d8f, byte param_00073d90, HIDInfo param_00073d91); // 0x000000018ABBED68-0x000000018ABBED94

	// Methods
	public virtual void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073d92); // 0x000000018ABBED4C-0x000000018ABBED68
}

[Flags]
internal enum AnBliHBmROTlQRPQOqeIZLIecGsj // TypeDefIndex: 53974
{
	None = 0,
	WriteDirect = 1,
	IgnoreExpectedReportSize = 2
}

internal enum sHQfHnKWSyUglbJevPHjzyHZgqdoA // TypeDefIndex: 53975
{
	Unknown = 0,
	USB = 1,
	Bluetooth = 2
}

internal enum hJxPFEDYiOqNMDuutvEivGuMTnYB // TypeDefIndex: 53976
{
	Synchronous = 0,
	Asynchronous = 1
}

internal class PiAoaHLiNJrbgVmbRfzTAJWkhYXRA : BrezXUXIUZIUDqjwzOgFxvkVSabY // TypeDefIndex: 53981
{
	// Fields
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x28
	public readonly float[] YaoCItnbFVSYFgSXmPFvnvRHvIkr; // 0x30
	public readonly int pbDDxnkDGOFFxgurHgDSPHXKbAtm; // 0x38
	private readonly byte[] nHisCqzKiJPnvrBApmQCTQgKQacL; // 0x40
	private readonly float[] XQRpbIYeFfhmxItSLolTyyvpwjAq; // 0x48
	private readonly int uHOVCRuRsdksMClfpvoNHVetaXYr; // 0x50
	private readonly int ileFirqiBVUBcxKKxTpSyHDMLaLL; // 0x54
	private readonly Action<byte[], float[]> YwiPAftMvGgmgCcORnlZzluKFMEMA; // 0x58
	private readonly Func<float> VVXlQiWWvlBMKJxZjKBlrPLsXDtq; // 0x60

	// Properties
	public float[] nXdBpypsCihkGgjdHnUwIADZGegB { get; } // 0x000000018ABC8704-0x000000018ABC8768 
	public RingBuffer<HiuAvUHPgkmSANBATMROifVCBjUxA> HoFCUsHKnPeVbzHOakkkpbMlyBLD { get; } // 0x000000018ABC8768-0x000000018ABC87CC 

	// Nested types
	internal class kyqjQlIiaGZtpYRkEETpxDSpxvDv : BrezXUXIUZIUDqjwzOgFxvkVSabY.OoscetqJhudXgEciDHFwzOydVvnF // TypeDefIndex: 53977
	{
		// Fields
		private int pbDDxnkDGOFFxgurHgDSPHXKbAtm; // 0x40
		private int RsaxMMimAbCgwIfghHuRsaWosJrCA; // 0x44

		// Properties
		public float[] nXdBpypsCihkGgjdHnUwIADZGegB { get; } // 0x000000018ABCCDA4-0x000000018ABCCE00 
		public RingBuffer<HiuAvUHPgkmSANBATMROifVCBjUxA> HoFCUsHKnPeVbzHOakkkpbMlyBLD { get; } // 0x000000018ABCCE00-0x000000018ABCCE5C 

		// Constructors
		public kyqjQlIiaGZtpYRkEETpxDSpxvDv(UpdateLoopSetting param_00073da1, int param_00073da2, int param_00073da3); // 0x000000018ABCCC7C-0x000000018ABCCD20

		// Methods
		public override void TSexxBoQJJrDUHjAVGegZXOfrqTg(UpdateLoopType param_00073da4); // 0x000000018ABCCB48-0x000000018ABCCBC4
		public void ZEDAhXcNFeIbNaPFJpmdmsCxtulXB(float[] param_00073da5, float param_00073da6); // 0x000000018ABCCBC4-0x000000018ABCCC7C
		private BrezXUXIUZIUDqjwzOgFxvkVSabY.iauVjjFObNvkjJmbggvouVWygepEA cCPdnrwJLaDYFvYciKmFvMUgvsFX(UpdateLoopType param_00073da7); // 0x000000018ABCCD20-0x000000018ABCCDA4
	}

	internal class HLBnPtgZqgIhkkDljbUsrpAeszHs : BrezXUXIUZIUDqjwzOgFxvkVSabY.iauVjjFObNvkjJmbggvouVWygepEA // TypeDefIndex: 53979
	{
		// Fields
		private float[] CWbBjAbbYvkvCWVdqqQTLDlshNMgb; // 0x18
		public float[] nXdBpypsCihkGgjdHnUwIADZGegB; // 0x20
		public RingBuffer<HiuAvUHPgkmSANBATMROifVCBjUxA> HoFCUsHKnPeVbzHOakkkpbMlyBLD; // 0x28
		private RingBuffer<HiuAvUHPgkmSANBATMROifVCBjUxA> lTZKhTJRyEucEUIucnWfvwhecsqV; // 0x30
		private ObjectPool<HiuAvUHPgkmSANBATMROifVCBjUxA> pjdcDlowThxXpFfQxEgBbgzEbMmA; // 0x38

		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class FXaMAIQanfMLpceamEgcsFHguvbA // TypeDefIndex: 53978
		{
			// Fields
			public static readonly FXaMAIQanfMLpceamEgcsFHguvbA __9; // 0x00
			public static Func<HiuAvUHPgkmSANBATMROifVCBjUxA> __9__5_0; // 0x08

			// Constructors
			static FXaMAIQanfMLpceamEgcsFHguvbA(); // 0x000000018ABC6B70-0x000000018ABC6BD4
			public FXaMAIQanfMLpceamEgcsFHguvbA(); // 0x00000001841E1670-0x00000001841E1680

			// Methods
			internal HiuAvUHPgkmSANBATMROifVCBjUxA kczVUQgBKZSwIAHtfNxgpvzxQCjH(); // 0x000000018ABC6BD4-0x000000018ABC6C10
		}

		// Constructors
		public HLBnPtgZqgIhkkDljbUsrpAeszHs(UpdateLoopType param_00073da8, int param_00073da9, int param_00073daa); // 0x000000018ABC6E9C-0x000000018ABC70B8

		// Methods
		public void TSexxBoQJJrDUHjAVGegZXOfrqTg(); // 0x000000018ABC6D0C-0x000000018ABC6E9C
		public void EGhvxPKhXjlkipAYJerjFLXFedUDA(float[] param_00073dab, float param_00073dac); // 0x000000018ABC6C10-0x000000018ABC6D0C
	}

	public class HiuAvUHPgkmSANBATMROifVCBjUxA // TypeDefIndex: 53980
	{
		// Fields
		public Vector3 nXdBpypsCihkGgjdHnUwIADZGegB; // 0x10
		public float IIQdtrlhGlIfBJNHpheUBYofgwZL; // 0x1C

		// Constructors
		public HiuAvUHPgkmSANBATMROifVCBjUxA(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		public void mnOZfTJZaPJhBHSiKkLNiAfZLffw(float[] param_00073dad, float param_00073dae); // 0x000000018ABC7140-0x000000018ABC71C8
		public void OSNJxVibfKbltujYHkKMLuczmano(HiuAvUHPgkmSANBATMROifVCBjUxA param_00073daf); // 0x000000018ABC7114-0x000000018ABC7140
	}

	// Constructors
	public PiAoaHLiNJrbgVmbRfzTAJWkhYXRA(UpdateLoopSetting param_00073d98, byte param_00073d99, HIDInfo param_00073d9a, int param_00073d9b, int param_00073d9c, Action<byte[], float[]> param_00073d9d, Func<float> param_00073d9e); // 0x000000018ABC858C-0x000000018ABC8704

	// Methods
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073d9f, double param_00073da0); // 0x000000018ABC841C-0x000000018ABC858C
}

internal class aGpYUdpKsUxonfUNYstiGMzKpBRk : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53983
{
	// Fields
	public int nXdBpypsCihkGgjdHnUwIADZGegB; // 0x20
	public double jKarPwkwSXrEognwvLrOcdRHcNeA; // 0x28
	public readonly int uHOVCRuRsdksMClfpvoNHVetaXYr; // 0x30
	public readonly int ileFirqiBVUBcxKKxTpSyHDMLaLL; // 0x34
	public readonly eoNcwkAZGAFJnvEjsAsmYdHYHPjhb IhWBKiERBWnyRQRTdQrbdYNSHuuM; // 0x38
	private Func<int, int> YwiPAftMvGgmgCcORnlZzluKFMEMA; // 0x40

	// Nested types
	public enum eoNcwkAZGAFJnvEjsAsmYdHYHPjhb // TypeDefIndex: 53982
	{
		Default = 0,
		Custom = 1
	}

	// Constructors
	public aGpYUdpKsUxonfUNYstiGMzKpBRk(byte param_00073db0, HIDInfo param_00073db1, eoNcwkAZGAFJnvEjsAsmYdHYHPjhb param_00073db2); // 0x000000018ABCA6BC-0x000000018ABCA710
	public aGpYUdpKsUxonfUNYstiGMzKpBRk(byte param_00073db3, HIDInfo param_00073db4, Func<int, int> param_00073db5); // 0x000000018ABCA710-0x000000018ABCA74C

	// Methods
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073db6, double param_00073db7); // 0x000000018ABCA5D0-0x000000018ABCA6BC
}

internal sealed class jtKDhEFaghTPhKKmJDXICzhwqTbdA : IDisposable // TypeDefIndex: 53987
{
	// Fields
	private Rewired.Utils.Classes.Utility.ThreadHelper swKaDCbNENkYjkUfdceifkmFnqWvA; // 0x10
	private hgjbdVMBzosMrnPpxtWgpzWiigxg UzUtkVqQmznFIdHWsNfTBPdCjRYAA; // 0x18
	private hgjbdVMBzosMrnPpxtWgpzWiigxg ynaGTvdhHAhXWCcWCrzgWOdPFgQj; // 0x20
	private bool OzUJNlfEeJUYqczBObQlGeeRWqHt; // 0x28
	private bool YcrITPRQcuWnqpkOKTEheFfNkewS; // 0x29
	private readonly object KSpKzXeQHbRcjsiGhnIKfTdKjmHk; // 0x30
	private gbbRmNlhHpFiauYmPxdDBPsbFjoE GNHXmVnpiJCkqGsJtytujOFNCbVdb; // 0x38
	private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x40

	// Nested types
	public delegate bool gbbRmNlhHpFiauYmPxdDBPsbFjoE(SAcTodLryXZPmeZqsKbnQQxsbBmo report, int timeoutMs); // TypeDefIndex: 53984; 0x0000000185FD6A74-0x0000000185FD6AA4

	private class hgjbdVMBzosMrnPpxtWgpzWiigxg : IDisposable // TypeDefIndex: 53986
	{
		// Fields
		private bool XRptggVYwQNQEdxPtFjcjAjCJVxq; // 0x10
		private tgxrTrgZneKONfhmBSnPyXsFbDPf ckHXiGDUdlYHlAHrXUHFBDIKDsST; // 0x18
		private NativeBuffer UzUtkVqQmznFIdHWsNfTBPdCjRYAA; // 0x38
		private int dVHInZMFIzLZcmnVHOpCbhikvOTf; // 0x40
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x44

		// Properties
		public bool PEpqVkzuexMtothymCvAAubDtYVq { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 

		// Nested types
		public struct tgxrTrgZneKONfhmBSnPyXsFbDPf // TypeDefIndex: 53985
		{
			// Fields
			public SAcTodLryXZPmeZqsKbnQQxsbBmo mQrqDGdAdHFSQumahwovqGlDLgWA; // 0x00
			public int ppmeWhGhIHoUfYLMiYtRmPsFPUny; // 0x18
		}

		// Constructors
		public hgjbdVMBzosMrnPpxtWgpzWiigxg(); // 0x000000018ABCB090-0x000000018ABCB0FC

		// Methods
		public void wCtpDbtxPicIuXtuGQKqvmyDbeRr(ref SAcTodLryXZPmeZqsKbnQQxsbBmo param_00073dc0, int param_00073dc1); // 0x000000018ABCB124-0x000000018ABCB26C
		public tgxrTrgZneKONfhmBSnPyXsFbDPf pVkevBBTaMPqQrkKZsFGLIOUTRvFA(); // 0x000000018ABCB0FC-0x000000018ABCB124
		public void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x0000000184DA8E50-0x0000000184DA8E60
		public void Dispose(); // 0x000000018ABCAF9C-0x000000018ABCAFEC
		protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABCB01C-0x000000018ABCB090
		protected virtual void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073dc2); // 0x000000018ABCAFEC-0x000000018ABCB01C
	}

	// Constructors
	public jtKDhEFaghTPhKKmJDXICzhwqTbdA(gbbRmNlhHpFiauYmPxdDBPsbFjoE param_00073db8); // 0x000000018ABCB8B4-0x000000018ABCB9D8

	// Methods
	public void hYvemJOXXUPtREKiTBHrlMMsGDrV(SAcTodLryXZPmeZqsKbnQQxsbBmo param_00073db9, int param_00073dba); // 0x000000018ABCBD8C-0x000000018ABCBEFC
	public void ghAXNTTllFZJImfdUqzOVvWsJmgN(); // 0x000000018ABCBB0C-0x000000018ABCBD8C
	private bool EIgZIsAaXKSOIBvpwmqjiRutRAOm(); // 0x000000018ABCB2BC-0x000000018ABCB2EC
	private bool KRUgOpAPLkQYqdFcOjkKadcFryvo(); // 0x000000018ABCB2EC-0x000000018ABCB594
	private void bKfARqbnaNHoECghRjJvcRHJTmoSB(); // 0x000000018ABCB9D8-0x000000018ABCBB0C
	private void DsSeJLzxIxyAHbxkWYAhwdMYTUyI(); // 0x00000001841E1670-0x00000001841E1680
	private void ZUMZLCCaSxZVHCuTXKLNUOVVFEFc(); // 0x00000001841E1670-0x00000001841E1680
	private void MKwPGmPNfhFmvlkQlEqXqLOfRmuO(); // 0x000000018ABCB594-0x000000018ABCB76C
	public void Dispose(); // 0x000000018ABCB26C-0x000000018ABCB2BC
	protected override void UlyZCbweXGfeTJIZsUwUGXjUnpwaA(); // 0x000000018ABCB840-0x000000018ABCB8B4
	private void SbYVTdmkPElTDzeOGdijEuqHpCge(bool param_00073dbb); // 0x000000018ABCB76C-0x000000018ABCB840
}

internal class RBWPuDEGPubdlvFFeXjPxJMpYYij // TypeDefIndex: 53988
{
	// Fields
	private byte caasdHbDlOGYqhKbRaxkOlDDhkFoA; // 0x10
	private byte WGbHDZFusDcXMMZuGQIYnpVroCHD; // 0x11
	private byte rHjFlbFeaybgBfZUCjnsMoqDvcpK; // 0x12
	[CompilerGenerated]
	private Action YyIWivtzuBhhvNfvbejonXoThpE; // 0x18

	// Properties
	public float ykhfzAYhhtbumDJSjGZrFKgLjXlg { get; set; } // 0x000000018ABC88CC-0x000000018ABC88E0 0x000000018ABC88E0-0x000000018ABC890C
	public float zhusFmcCBtTZbuuoZfgcSzcnuLlg { get; set; } // 0x000000018ABC89C8-0x000000018ABC89DC 0x000000018ABC87CC-0x000000018ABC87F8
	public float pYiEkwIgIrQXsEKIZyINXQdzYopC { get; set; } // 0x000000018ABC890C-0x000000018ABC8920 0x000000018ABC88A0-0x000000018ABC88CC
	public byte DMnVvPBsAAJdxNAWNtvwXIfBhEsh { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x000000018ABC89DC-0x000000018ABC89F0
	public byte KNBzijjeDFeLXEuEGPePapYGvipEB { get; set; } // 0x0000000184D88380-0x0000000184D88390 0x000000018ABC87F8-0x000000018ABC880C
	public byte SGliDyErnsorGKsladytAlEeuyeb { get; set; } // 0x0000000184D88390-0x0000000184D883A0 0x000000018ABC8920-0x000000018ABC8934

	// Events
	public event Action YyIWivtzuBhhvNfvbejonXoThpE {
		add; // 0x000000018ABC8934-0x000000018ABC89C8
		remove; // 0x000000018ABC880C-0x000000018ABC88A0
	}

	// Constructors
	public RBWPuDEGPubdlvFFeXjPxJMpYYij(byte param_00073dcb, byte param_00073dcc, byte param_00073dcd); // 0x0000000184DA6B90-0x0000000184DA6BA0
}

internal static class NNefSVhzYujRHlfteDpNOUkkUmtWA // TypeDefIndex: 53990
{
	// Fields
	private static LnNStPJIXScwsdLkQVeDAsbanRsq[] mUarZAnOcAgasaFrUziGjTsTtExW; // 0x00

	// Nested types
	private class LnNStPJIXScwsdLkQVeDAsbanRsq // TypeDefIndex: 53989
	{
		// Fields
		public readonly ushort GcDXLONUdcLWGUjNnLEwuJedpMpo; // 0x10
		public readonly ushort mDfvIrfTdctiyDRPfEHZSUBTcTRU; // 0x12
		public readonly string ZFMfPPlGsRclaQOlhEcmxjLIUoNw; // 0x18
		public readonly bool RAjyHQzEeSjnPWflaFFmaayVJVAu; // 0x20
		public readonly int qDewspVTFRHrLjKyANSxStmeDDtG; // 0x24
		public readonly int vHWXcracpBYWrSnEIOUHdhOXzOV; // 0x28
		public readonly int hDFzqGFcDpMuaiIEoaLnErcycDpIb; // 0x2C
		public readonly float fyMfMsJFuuFKhIifangwweWmriev; // 0x30

		// Constructors
		public LnNStPJIXScwsdLkQVeDAsbanRsq(ushort param_00073ddd, ushort param_00073dde, string param_00073ddf, bool param_00073de0, int param_00073de1, int param_00073de2, int param_00073de3, float param_00073de4); // 0x000000018ABC72F8-0x000000018ABC73A4

		// Methods
		public bool AnRgfMBlQHwOzfSTAJfBJzQWMhaTA(ushort param_00073de5, ushort param_00073de6); // 0x000000018ABC72E4-0x000000018ABC72F8
		public bool AnRgfMBlQHwOzfSTAJfBJzQWMhaTA(ushort param_00073de7, ushort param_00073de8, string param_00073de9); // 0x000000018ABC72B4-0x000000018ABC72E4
	}

	// Constructors
	static NNefSVhzYujRHlfteDpNOUkkUmtWA(); // 0x000000018ABC7E04-0x000000018ABC8020

	// Methods
	public static bool RUKiytTXrLcSpQZCCQWaDIqtKpRi(ushort param_00073dce, ushort param_00073dcf, string param_00073dd0 = null); // 0x000000018ABC7D98-0x000000018ABC7E04
	public static float RDQwknGoqzlZPaqjxePTtSVHsjZh(ushort param_00073dd1, ushort param_00073dd2, string param_00073dd3 = null); // 0x000000018ABC7D28-0x000000018ABC7D98
	public static bool PWBpTzdlpMMdlGkToklvyHBOgsFO(ushort param_00073dd4, ushort param_00073dd5, string param_00073dd6, out int param_00073dd7, out int param_00073dd8, out int param_00073dd9); // 0x000000018ABC7A48-0x000000018ABC7C20
	private static LnNStPJIXScwsdLkQVeDAsbanRsq QKYeAJatDbmEBhCgDoraFkrxAfGgA(ushort param_00073dda, ushort param_00073ddb, string param_00073ddc = null); // 0x000000018ABC7C20-0x000000018ABC7D28
}

internal class psxalbFqqRAvexHgaNTDxDrhdRTx : zseGNggMpNmuvgqogMqiEcjsNLTGc // TypeDefIndex: 53994
{
	// Fields
	private TouchpadInfo PbqIfxbfeatRVrbKRWrLMiXzJFwcb; // 0x20
	private RingBuffer<nDGDgFZHIjKCRXRTSCjYEVvndGZs> pvIQxzUsygaPXmiRvsrKjgcopHDq; // 0x28
	private TouchData[] kXnLdBlJgCxbfqCAGzQCtURIKygi; // 0x30
	private Action<NativeBuffer, TouchData[]> YwiPAftMvGgmgCcORnlZzluKFMEMA; // 0x38
	public TouchData[] KLhMuLdxLLSfcuhBuVoCbmQEJqXO; // 0x40
	private ObjectPool<nDGDgFZHIjKCRXRTSCjYEVvndGZs> PWKcBQwVcxuqQgyamMaQJyCzrcMG; // 0x48

	// Nested types
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class TouchpadInfo // TypeDefIndex: 53991
	{
		// Fields
		public int maxTouches; // 0x10
		public int minX; // 0x14
		public int maxX; // 0x18
		public int minY; // 0x1C
		public int maxY; // 0x20
		public bool invertY; // 0x24
		public bool reverseY; // 0x25

		// Constructors
		public TouchpadInfo(int param_00073df2, int param_00073df3, int param_00073df4, int param_00073df5, int param_00073df6, bool param_00073df7, bool param_00073df8); // 0x0000000184DA8E10-0x0000000184DA8E40

		// Methods
		public void CalculateTouch(ref TouchData data); // 0x000000018ABCA368-0x000000018ABCA464
	}

	private class nDGDgFZHIjKCRXRTSCjYEVvndGZs // TypeDefIndex: 53992
	{
		// Fields
		public readonly TouchData[] HoFCUsHKnPeVbzHOakkkpbMlyBLD; // 0x10

		// Constructors
		public nDGDgFZHIjKCRXRTSCjYEVvndGZs(int param_00073dfa); // 0x000000018ABCCE98-0x000000018ABCCEEC
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal struct TouchData // TypeDefIndex: 53993
	{
		// Fields
		public int touchId; // 0x00
		public float timeStamp; // 0x04
		public bool isTouching; // 0x08
		public int positionRawX; // 0x0C
		public int positionRawY; // 0x10
		public float positionX; // 0x14
		public float positionY; // 0x18
		public int positionAbsX; // 0x1C
		public int positionAbsY; // 0x20

		// Methods
		public void Clear(); // 0x0000000184DA8DF0-0x0000000184DA8E10
	}

	// Constructors
	public psxalbFqqRAvexHgaNTDxDrhdRTx(byte param_00073dea, TouchpadInfo param_00073deb, HIDInfo param_00073dec, int param_00073ded, Action<NativeBuffer, TouchData[]> param_00073dee); // 0x000000018ABCD3A8-0x000000018ABCD5A0

	// Methods
	public override void EGhvxPKhXjlkipAYJerjFLXFedUDA(NativeBuffer param_00073def, double param_00073df0); // 0x000000018ABCD0F4-0x000000018ABCD2D0
	public void ngUTlTZVPYrlJkAyrcnFEapgxoxqA(); // 0x000000018ABCD5A0-0x000000018ABCD80C
	public bool KfeTnSggKRQtOUjPypCDriUSQzXD(int param_00073df1); // 0x000000018ABCD33C-0x000000018ABCD3A8
	[CompilerGenerated]
	private nDGDgFZHIjKCRXRTSCjYEVvndGZs IaOGkKqyuGWXZNwuvoHmkUzArMpF(); // 0x000000018ABCD2D0-0x000000018ABCD33C
}

internal class VbAAdTxzmAWCstIPAWbKlCcBdbYW // TypeDefIndex: 53999
{
	// Nested types
	public static class HMuWgOZTDrvYKkeApgAkWDDFcCDk // TypeDefIndex: 53995
	{
		// Methods
		public static bool DAzrfvcgSzzBEUwbqeizpCzsHfjt(ushort param_00073e06); // 0x000000018ABC70B8-0x000000018ABC70D0
		public static bool SeISTUMcvxQbscTuWAifXUKbHvHV(ushort param_00073e07); // 0x000000018ABC70F4-0x000000018ABC7114
		public static bool FRfnKffdTlqLSvooDnaigfyWpISN(ushort param_00073e08); // 0x000000018ABC70D0-0x000000018ABC70F4
	}

	public static class snOrUdREYdJKgyCftIoxkViViWHFA // TypeDefIndex: 53996
	{
		// Methods
		public static bool SeISTUMcvxQbscTuWAifXUKbHvHV(ushort param_00073e09); // 0x000000018ABCD848-0x000000018ABCD8CC
		public static bool FRfnKffdTlqLSvooDnaigfyWpISN(ushort param_00073e0a); // 0x000000018ABCD80C-0x000000018ABCD848
	}

	public static class MoKkibzybyrItQEdSxLaAbbpHvUZ // TypeDefIndex: 53997
	{
		// Methods
		public static bool SeISTUMcvxQbscTuWAifXUKbHvHV(ushort param_00073e0b); // 0x00000001812081B0-0x0000000181208610
		public static bool FRfnKffdTlqLSvooDnaigfyWpISN(ushort param_00073e0c); // 0x000000018ABC74C8-0x000000018ABC7A48
	}

	public static class knmhShzUJmxzMFpGUDPFxDsHRSVJ // TypeDefIndex: 53998
	{
		// Methods
		public static bool SeISTUMcvxQbscTuWAifXUKbHvHV(ushort param_00073e0d); // 0x000000018ABCCB38-0x000000018ABCCB48
		public static bool FRfnKffdTlqLSvooDnaigfyWpISN(ushort param_00073e0e); // 0x000000018ABCCB28-0x000000018ABCCB38
	}

	// Methods
	public static bool SeISTUMcvxQbscTuWAifXUKbHvHV(ushort param_00073dfb, ushort param_00073dfc); // 0x000000018ABCA554-0x000000018ABCA5A0
	public static bool RDYeEwbRtXsLWoAKUGFZDJmuTWfRA(ushort param_00073dfd, ushort param_00073dfe); // 0x000000018ABCA518-0x000000018ABCA554
	public static bool FRfnKffdTlqLSvooDnaigfyWpISN(ushort param_00073dff, ushort param_00073e00); // 0x000000018ABCA464-0x000000018ABCA4D4
	public static bool JGFRXvvyCbkrJeZqPirIEOeFkncc(ushort param_00073e01); // 0x000000018ABCA4E8-0x000000018ABCA518
	public static bool HBMeXiFMgCwqUbhbrdJcODHQmucqA(ushort param_00073e02); // 0x000000018ABCA4D4-0x000000018ABCA4E8
	public static bool lnjdfxrUQNpYNSRzIboSGmgXoptU(ushort param_00073e03); // 0x000000018ABCA5B4-0x000000018ABCA5D0
	public static bool ZRrQEqyAEAaASggpqmGZdBFHevqOA(ushort param_00073e04, ushort param_00073e05); // 0x000000018ABCA5A0-0x000000018ABCA5B4
}

internal class CdOeHzikbRBkBZoJPipyBOeHnirMb // TypeDefIndex: 54000
{
	// Fields
	private int faXYUcNLwyASXbOrsvCIlWLksNkG; // 0x10
	private int ycdqnGzmnjbDvKLkJoaqfItRJGUbA; // 0x14
	private int kWeXlFoALxBrZNITZvBHiacnkKxe; // 0x18
	[CompilerGenerated]
	private Action YyIWivtzuBhhvNfvbejonXoThpE; // 0x20

	// Properties
	public float hdhgRruzeMjkMsQRzkiAhPPzgRzN { get; set; } // 0x000000018ABBEF34-0x000000018ABBEF40 0x000000018ABBEE40-0x000000018ABBEE70
	public int vsFLtRXKpsrJpdFoXcvsRKfdRFeU { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x000000018ABBED94-0x000000018ABBEDAC

	// Events
	public event Action YyIWivtzuBhhvNfvbejonXoThpE {
		add; // 0x000000018ABBEEA0-0x000000018ABBEF34
		remove; // 0x000000018ABBEDAC-0x000000018ABBEE40
	}

	// Constructors
	public CdOeHzikbRBkBZoJPipyBOeHnirMb(int param_00073e13, int param_00073e14); // 0x0000000184DA8770-0x0000000184DA8780

	// Methods
	private float ZUajHrsIpJtSCJNnXgSMUYoOlGHH(int param_00073e15); // 0x000000018ABBEE70-0x000000018ABBEEA0
	private int yLMbUGkHMQkfGjtSylvgzWWFMavm(float param_00073e16); // 0x000000018ABBEF40-0x000000018ABBEF68
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 54040
{
	// Fields
	internal static readonly long _0B31436F7F817F43292A073BAA33FBF3A226D874FC2753978FCE13DBA0EAFA5E; // 0x00 // Static value (base64): AAFAQAABQEA= - Metadata: 0x023341EC
	internal static readonly __StaticArrayInitTypeSize_30352 _3D81570F62DF347E1C5258C8177FEB1B3318D84871BF789DD2A9446D57947604; // 0x08 // Static value (base64): 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 - Metadata: 0x023341FC
	internal static readonly __StaticArrayInitTypeSize_13688 _5BBBDF4BAF16C2FF947F86FE4EABE872040F6FFB7501FA48FA14D67BAFCFAF1A; // 0x7698 // Static value (base64): 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 - Metadata: 0x0233B894
	internal static readonly __StaticArrayInitTypeSize_88 _672B0FC8F401165C3B383DDB9C4E99487720970520B26DEB99BA4AF7DBDEA591; // 0xAC10 // Static value (base64): ugAAAL8AAADAAAAA2wAAANwAAADdAAAA3gAAAN8AAADiAAAA4gAAAP4AAADdAAAAvAAAAL0AAADbAAAAvgAAANwAAAC7AAAAvwAAAN4AAAC6AAAAwAAAAA== - Metadata: 0x0233EE14
	internal static readonly __StaticArrayInitTypeSize_1024 D8FC129383BFF513C55131253FB9B0EC0A8206F473F932CF0006871A8007B4CD; // 0xAC68 // Static value (base64): je8C0hvfBaWhjgw8N74LS5Qrb9UCG2iiuEphOy56Zky/Z9ncKVfeq5MG1zIFNtBFpqO02zCTs6yKwro1HPK9Qun/tc9/z7K4xZ67IVOuvFbwO9jIZgvfv9xa1iZKatFR23duwU1Habb3FmAvYSZnWMKzA8ZUgwSx7tINKHjiCl9Fz2zp0/9rnmmuYgf/nmVwXAsB7so7Bplwag8A5loId3dHt+fhd7CQWya5Cc0Wvn5ug9rg+LPdl0Li1A7U0tN5Id/b9Lfv3IMNvtUam47SbTgbtvOuK7GEFHq4HYJKv2oTVwD6hWcHjT82DhSpBgljCpNt/Zyjaoom8mMTsMJkZB2u3qSLntnTMc/QSqf/1z0EarOjklq01CgLvU2+O7o6LyYFqrkWAt0DRwtElXcMMzbiaK2g0m/aGoNmQ4yzYTR5vmm5745uzlXfZ1fD72AgYHoEvvZKA8lMGwpQ2isNJ0s2srfdBrXAZ1e8WfFnuy5S8t+wxMLYx36T0V7oo9Yp1Y6wn0O+t+j5775xb9+5BsxK3Zhaetrv4CvTdnYb1AHnBmuRcTZs5stnZX9dV2II/sIGlmjyAeHSowh4RJMPD7GeB4InrgD1nf8JbAvPDhuoWmqFPmpt8oQ7ZGsSC2McgxbcjBUm2/uvd9JiOUfVFZrSsYsM4rb8trO/ZSCDuBKtbLo/O1y9SIENtNEXPbOmtKjXOCKY0E+YydnWDvneoZ/kYTEJ1GZGs4Vv3yW1aKiGIAw2EBALQapBAtg8cQWvyXwNIl9MClXlHQPMcy0Eu9C4YCVGiGdS/Nluy2rpabz79NYsbcTRW9eV2MJBpd+14jC7K3QAvFzOUbXFWGGysmVM1ATzfNNzSS3a6t8d3Z18iLkD6ri+dFDpt+3G2bCaV8QPCsH0CH17pQHk7ZUGk04AYg3YMGV6YmFs4/RRa5QBXGMZl2xkbi09bfe7DWqAGJgOHo6oCWk0+QDwoskHhzPUuBel5L9gH7W2+YmFsY4qENUQvCDSZwZx2/6QQdyJPS1mSasdYT4RTGinh3xv0CTpC06y2Qw5CIgFoJ64AtcPpb1HmZW6MCPEs6m19LTeFmHQQIBR1zc6AN6urDDZ2Vk90VTPDdYjdVzfuuNs2M1A+bxT1sm7JGyYsr36qLXKa7UKWv2FDS1H1AS00eQDw3JxZ13kQWAqXhBps8ggbsT1DQhyYz0PBdlsBpxPXAHr7MlldXr5YgLAqGubVphs7MeF03xRtdQL6+Tdkn3U2uXeQb57SHG5DPIgsJVkELfikR2/bwctuBi9fLGBK0y29ojZ0mge6dUfpLjchjKI2/GjlWRhNaVjFo/0ao8ZxG34ulEJZixhDhGWMAeIAAAA/w== - Metadata: 0x0233EE74
	internal static readonly __StaticArrayInitTypeSize_16688 F381B0143773191EE069E703BE085604D913BC08C17AD8E76556B6D477CFD241; // 0xB068 // Static value (base64): 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 - Metadata: 0x0233F27C

	// Nested types
	private struct __StaticArrayInitTypeSize_88 // TypeDefIndex: 54035
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 54036
	{
	}

	private struct __StaticArrayInitTypeSize_13688 // TypeDefIndex: 54037
	{
	}

	private struct __StaticArrayInitTypeSize_16688 // TypeDefIndex: 54038
	{
	}

	private struct __StaticArrayInitTypeSize_30352 // TypeDefIndex: 54039
	{
	}
}

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class DualSenseDriver : HIDDeviceDriver, IDisposable, IDriver_DualSense // TypeDefIndex: 54013
	{
		// Fields
		private readonly IHIDDevice gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x58
		private readonly HIDProperties VkVAKVIMQRyPhbkRyooTuWaVvzlLA; // 0x60
		private readonly bool PEGFXXAcEYsrWGfWfGnNKtAdthSe; // 0x88
		private readonly int ARnnszsMZKeOUYYzZRZUwEefEtii; // 0x8C
		private readonly int OMLzFssKjBgHgeLUXdhchwgmfGmx; // 0x90
		private readonly bool UbPOhqoEvaplirSJnLizErwbnFBu; // 0x94
		private readonly byte FrHSGGlmMVQFavVOAKhZHJYnHGND; // 0x95
		private readonly int TRuqcNGExQAFFaBxWIyOLUKqEAKSA; // 0x98
		private readonly int ZQnyTTTmsZjSDMZMBflUxViYjQod; // 0x9C
		private readonly int QNHGjiJfQABbiilpwdFGdnwonVRC; // 0xA0
		private readonly int uaYfolaObMIVhJvZuyXhRkTDZRlz; // 0xA4
		private readonly NativeBuffer xkaUSPMbKaIaWIOXokAQIEKBViHGA; // 0xA8
		private readonly NativeBuffer sjLHthEwwVztivMgeRRYASiKesWF; // 0xB0
		private SAcTodLryXZPmeZqsKbnQQxsbBmo xbEsAkXaaLqjjqgKWpscjpqoFCyU; // 0xB8
		private int jmBXbpMEmeMeSPpmYruvFLwXTete; // 0xD0
		private bool kTzQvuDQExstkJkbShIMTzLhPMKy; // 0xD4
		private bool qoNvEaCyJnqTindhxKVdRtALcZsH; // 0xD5
		private double LKZLXAJjpWMnLeZXoJJDIBuifkZf; // 0xD8
		private int rJijwqsFeFuElEfbIAklzOTKEqKjA; // 0xE0
		private zevHCMgjpSIcEHGdYHQwwhRNWQpq YSAbzHahTyCfisDrqondQGNiVqPO; // 0xE4
		private bool qTkxrtkXAhNHEYKDEdlMqkEnsLzE; // 0xE8
		private Quaternion EOVsCHixclSwbGIyDivPXifACXSZ; // 0xEC
		private DualSenseMicrophoneLightMode orqAxHYKPIPsYCTzymCfOInVdDYQ; // 0xFC
		private CEDiiLYnylVhKqzRVmTmEUraLGnb AVRRdcwbRVkscGFQWdYMhveEtmvE; // 0xFD
		private DualSensePlayerLightFlags HsMnPWlFWizidVwqsDrVrakEwaGQ; // 0xFE
		private bool vCpnWaEMNtVVGeaVaJcedEutlcxU; // 0xFF
		private uint ngFGBuFNIyEzwXGTNhljyLoCJknib; // 0x100
		private float UAeNzinasdhufezAiyLJHdSmrsql; // 0x104
		private double AVyPLjpHGvdVMcogFnXBaZUCzxpFA; // 0x108
		private float tZOfLkELLoiGSGwlAOlVuItRImlGB; // 0x110
		private readonly IDualSenseTriggerEffect[] MJNNjBHytmdquQFwZjykUzkMNFiq; // 0x118
		private readonly byte[] HArzhsurAKFtcCIXyDCTiRElhFcAb; // 0x120
		private readonly byte[] YDmcXQlGYzQzBOJSasnktyAdwwvr; // 0x128
		private DualSenseTriggerEffectState[] mvBFXXDbaxBGVHgfPeKALypoyjgm; // 0x130
		private DualSenseVibrationMode DrqbruOMuMuwBrYfQwPzlSVOVOyH; // 0x138
		private byte rfsiDjimJdepBNbZXmsoyjBLXkgWA; // 0x13C
		private bool nuUGoAcNTzwOLcmLDjnOZsLlJPGOA; // 0x13D
		private bool clrCQezCRexHVWivEcXmzcXufofH; // 0x13E
		private bool DyOYHHVaaDsGVBsZNLuqDzUzDJFI; // 0x13F
		private bool nIGrSOoKznakDbfWypBwydaLMWCO; // 0x140
		private bool VPqjgHQEdwkrYRbtZnlPQuHrmDfs; // 0x141
		private bool aTOxSVjevySFRbYdFWrDDEsvRphD; // 0x142
		private bool pUlZDHcKdcccXAVErjUnbmoKwfHCc; // 0x143
		private bool cDipGurdsABPvaWbhRyPtAswnPar; // 0x144
		private bool fDbSxNTQiuCRVYaFguQtXzMqCuQH; // 0x145
		private byte ZyatxfmKaBQwUdfTDraMrdsebPwM; // 0x146
		private byte ogZjReCqmxDoVbSlFgSHbIAgLNss; // 0x147
		private Quaternion ECImyMtRQoTaQXHpKhkvHsYzvMBW; // 0x148
		private Quaternion LWqdBRgbnHexJhYCwZiYeXenPnUhA; // 0x158
		private bool NgvgFVNKYmCzWKlmRRgWyWXkDrPq; // 0x168
		private int SDhaHcneSYWgZhePOydTZlcjFJDV; // 0x16C
		private int[] CpFbvUDTUgXVeMMeKgjVDnkgoibZB; // 0x170
		private int[] jxgaQivcSkkQAFauzgYwflHgescD; // 0x178
		private static uint[] IMXJZruKEAhSIjsecQEVWmnOmbrD; // 0x00
	
		// Properties
		private bool isVibrating { get; } // 0x000000018ABC1FB8-0x000000018ABC2020 
		public float BatteryLevel { get; } // 0x0000000184DA8C70-0x0000000184DA8C80 
		public bool BatteryCharging { get; } // 0x000000018ABC1B88-0x000000018ABC1B94 
		public DualSenseVibrationMode vibrationMode { get; set; } // 0x0000000184D8D0B0-0x0000000184D8D0C0 0x0000000184DA8D20-0x0000000184DA8D30
		public float LeftMotor { get; set; } // 0x000000018ABC1E38-0x000000018ABC1E70 0x000000018ABC2720-0x000000018ABC2754
		public float RightMotor { get; set; } // 0x000000018ABC1F30-0x000000018ABC1F68 0x000000018ABC28C8-0x000000018ABC28FC
		public float LightColorR { get; set; } // 0x000000018ABC1EF0-0x000000018ABC1F30 0x000000018ABC27BC-0x000000018ABC27F0
		public float LightColorG { get; set; } // 0x000000018ABC1EB0-0x000000018ABC1EF0 0x000000018ABC2788-0x000000018ABC27BC
		public float LightColorB { get; set; } // 0x000000018ABC1E70-0x000000018ABC1EB0 0x000000018ABC2754-0x000000018ABC2788
		public float LightFlashOnDuration { get; set; } // 0x0000000184DA8C90-0x0000000184DA8CA0 0x000000018ABC285C-0x000000018ABC28C8
		public float LightFlashOffDuration { get; set; } // 0x0000000184DA8C80-0x0000000184DA8C90 0x000000018ABC27F0-0x000000018ABC285C
		public DualSenseMicrophoneLightMode microphoneLightMode { get; set; } // 0x0000000184DA8CB0-0x0000000184DA8CC0 0x0000000184DA8CE0-0x0000000184DA8D00
		public DualSenseOtherLightBrightness otherLightBrightness { get; set; } // 0x000000018ABC1F68-0x000000018ABC1FB8 0x000000018ABC28FC-0x000000018ABC2960
		public DualSensePlayerLightFlags playerLights { get; set; } // 0x0000000184DA8CC0-0x0000000184DA8CD0 0x0000000184DA8D00-0x0000000184DA8D20
		public Vector3 AccelerometerValue { get; } // 0x000000018ABC1B30-0x000000018ABC1B88 
		public Vector3 AccelerometerValueRaw { get; } // 0x000000018ABC1AAC-0x000000018ABC1B30 
		public Vector3 GyroscopeValue { get; } // 0x000000018ABC1C80-0x000000018ABC1CEC 
		public Vector3 GyroscopeValueRaw { get; } // 0x000000018ABC1B94-0x000000018ABC1C80 
		public Vector3 LastGyroscopeValue { get; } // 0x000000018ABC1D70-0x000000018ABC1E38 
		public Vector3 LastGyroscopeValueRaw { get; } // 0x000000018ABC1CEC-0x000000018ABC1D70 
		public Quaternion Orientation { get; } // 0x0000000184DA8CA0-0x0000000184DA8CB0 
		public int MaxTouches { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		ushort IHIDControllerExtension.vendorId { get; } // 0x0000000184DA8C40-0x0000000184DA8C50 
		ushort IHIDControllerExtension.productId { get; } // 0x0000000184DA8C10-0x0000000184DA8C20 
		string IHIDControllerExtension.productName { get; } // 0x0000000184D86230-0x0000000184D86240 
		string IHIDControllerExtension.manufacturer { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		ushort IHIDControllerExtension.usagePage { get; } // 0x0000000184DA8C20-0x0000000184DA8C30 
		ushort IHIDControllerExtension.usage { get; } // 0x0000000184DA8C30-0x0000000184DA8C40 
	
		// Nested types
		private enum TWCgCVykdASvqjAvtwILMsxkJfqS // TypeDefIndex: 54001
		{
			None = 0,
			XZ = 1,
			Y = 2
		}
	
		private enum pWrWdNeHBdvnuLueHgImyhgSLeDG : byte // TypeDefIndex: 54002
		{
			Off = 0,
			Feedback = 1,
			Weapon = 2,
			Vibration = 3,
			SlopeFeedback = 4
		}
	
		private enum CEDiiLYnylVhKqzRVmTmEUraLGnb : byte // TypeDefIndex: 54003
		{
			High = 0,
			Medium = 1,
			Low = 2
		}
	
		private enum FyuaIbtRJcYOMxenmHnFCkNOWcAKA : byte // TypeDefIndex: 54004
		{
			Discharging = 0,
			Charging = 1,
			Full = 2,
			TemperatureOutOfRange = 10,
			TemperatureError = 11,
			ChargingError = 15
		}
	
		private enum zevHCMgjpSIcEHGdYHQwwhRNWQpq // TypeDefIndex: 54005
		{
			NotCharging = 0,
			Discharging = 1,
			Charging = 2,
			Full = 3,
			Unknown = 4
		}
	
		private enum qJWDrWFTHUzGihflrdUMFvJqKIYRA : byte // TypeDefIndex: 54006
		{
			None = 0,
			CompatibleVibrationMode1 = 1,
			HapticsSelect = 2,
			RightTriggerEffect = 4,
			LeftTriggerEffect = 8,
			AudioVolume = 16,
			ToggleInternalSpeaker = 32,
			MicrophoneVolume = 64,
			ToggleInternalMicOrExternalSpeaker = 128
		}
	
		private enum HhwtNilXeadAoHHrzdwMmcgWBMJY : byte // TypeDefIndex: 54007
		{
			None = 0,
			MicrophoneLEDControl = 1,
			PowerSaveControl = 2,
			LightbarControl = 4,
			TurnOffLEDs = 8,
			PlayerIndicatorLEDControl = 16,
			Unknown1 = 32,
			ChangeOverallMotorEffectPower = 64,
			Unknown2 = 128
		}
	
		private enum cSkdeMGgZoTQzLyvjJJsrKZlrAjbA : byte // TypeDefIndex: 54008
		{
			None = 0,
			OtherLightBrightnessControl = 1,
			LightbarSetupControl = 2,
			CompatibleVibrationMode2 = 4
		}
	
		private struct VcsZpuFmaGWbgtFHPqkibctKOOSD // TypeDefIndex: 54009
		{
			// Fields
			public byte IaOjDqjXmTvIEPrVtSrrcPlQvkii; // 0x00
	
			// Properties
			public byte ftEGzwCOTsOQHzRVxKNcTqNQciPgA { get; } // 0x0000000184D874B0-0x0000000184D874C0 
			public byte RBYlIZAAsSeZLKwwqWjYrgjfzydJ { get; } // 0x0000000184DA8E40-0x0000000184DA8E50 
	
			// Constructors
			public VcsZpuFmaGWbgtFHPqkibctKOOSD(byte param_00073e69); // 0x0000000184D87180-0x0000000184D87190
		}
	
		private static class alCCYiGZllrJPlpReystvrnGtQGs // TypeDefIndex: 54012
		{
			// Nested types
			public static class kCZSdAchJreiZflWtxTSzYgysngq // TypeDefIndex: 54011
			{
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class cayHBADxgITRmVakrATHfiUEHSjn // TypeDefIndex: 54010
				{
					// Fields
					public static readonly cayHBADxgITRmVakrATHfiUEHSjn __9; // 0x00
					public static Func<byte, bool> __9__4_0; // 0x08
					public static Func<byte, bool> __9__6_0; // 0x10
	
					// Constructors
					static cayHBADxgITRmVakrATHfiUEHSjn(); // 0x000000018ABCA74C-0x000000018ABCA7B0
					public cayHBADxgITRmVakrATHfiUEHSjn(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal bool juHfDEKKzBbxMRJcXpvLPiyglqlHA(byte param_00073e87); // 0x000000018ABCA7B0-0x000000018ABCA7B8
					internal bool xhPDEVeyBHDXCmwmsZuiLlCqHTaZA(byte param_00073e88); // 0x000000018ABCA7B0-0x000000018ABCA7B8
				}
	
				// Methods
				public static bool smyIfgWKHLuWuhRLJIuqwptGkNyL(byte[] param_00073e6a, int param_00073e6b); // 0x000000018ABCCA40-0x000000018ABCCB28
				public static bool OoKABNyQUAFbnVfEqfJmkeFccgjoA(byte[] param_00073e6c, int param_00073e6d, byte param_00073e6e, byte param_00073e6f); // 0x000000018ABCC714-0x000000018ABCC8B4
				public static bool FIEMnmTQkRQGLEZmIDcfwQwkdqHG(byte[] param_00073e70, int param_00073e71, byte param_00073e72, byte param_00073e73, byte param_00073e74); // 0x000000018ABCC0B4-0x000000018ABCC218
				public static bool AzTKzpcpepoHyqkrIKIAosuSVoBx(byte[] param_00073e75, int param_00073e76, byte param_00073e77, byte param_00073e78, byte param_00073e79); // 0x000000018ABCBEFC-0x000000018ABCC0B4
				public static bool JCAfMYDEZhXCMMwUrbPGHbVLokHXA(byte[] param_00073e7a, int param_00073e7b, byte[] param_00073e7c); // 0x000000018ABCC4A4-0x000000018ABCC714
				public static bool jIbBsSzIgAQfboLujxPXYAEcCYUB(byte[] param_00073e7d, int param_00073e7e, byte param_00073e7f, byte param_00073e80, byte param_00073e81, byte param_00073e82); // 0x000000018ABCC8B4-0x000000018ABCCA40
				public static bool FbrihUFIGGjchnylTBtUiyEiJCAJ(byte[] param_00073e83, int param_00073e84, byte param_00073e85, byte[] param_00073e86); // 0x000000018ABCC218-0x000000018ABCC4A4
			}
		}
	
		// Constructors
		public DualSenseDriver(InitArgs param_00073e31); // 0x000000018ABC0878-0x000000018ABC1940
		static DualSenseDriver(); // 0x0000000184D184E0-0x0000000184D18570
	
		// Methods
		public void ResetOrientation(); // 0x000000018ABC06B4-0x000000018ABC06DC
		public int GetTouchCount(); // 0x000000018ABBFA54-0x000000018ABBFAC4
		public bool IsTouchingAtIndex(int index); // 0x000000018ABC0030-0x000000018ABC007C
		public bool IsTouchingAtTouchId(int touchId); // 0x000000018ABC007C-0x000000018ABC00B0
		public int GetTouchIdAtIndex(int index); // 0x000000018ABBFAC4-0x000000018ABBFB10
		public bool GetTouchPositionByIndex(int index, out Vector2 position); // 0x000000018ABBFC94-0x000000018ABBFD28
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x000000018ABBFD28-0x000000018ABBFDF4
		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY); // 0x000000018ABBFB10-0x000000018ABBFBB8
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY); // 0x000000018ABBFBB8-0x000000018ABBFC94
		public void StopLightFlash(); // 0x0000000184DA8C50-0x0000000184DA8C70
		public void StopVibration(); // 0x000000018ABC0778-0x000000018ABC07E0
		public bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect); // 0x000000018ABC06DC-0x000000018ABC0778
		public DualSenseTriggerEffectStates GetTriggerEffectStates(); // 0x000000018ABBFDF4-0x000000018ABBFE40
		public override void Update(UpdateLoopType updateLoop); // 0x000000018ABC0850-0x000000018ABC0878
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp); // 0x000000018ABC02BC-0x000000018ABC0618
		public override Rewired.Controller.Extension CreateControllerExtension(); // 0x000000018ABBF8A8-0x000000018ABBF908
		private void xogNzFQFRWULJIgOmcBxBKtxFiqoA(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073e36); // 0x000000018ABC33CC-0x000000018ABC33F4
		private bool jPYAiNWxnQLIxYSKTaudFjrNWoeP(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073e37); // 0x000000018ABC20E0-0x000000018ABC212C
		private void uFUlbKTKNOwrICDqXmKOZKORLYaO(); // 0x000000018ABC2A14-0x000000018ABC2B90
		private void uFUlbKTKNOwrICDqXmKOZKORLYaO(NativeBuffer param_00073e38, int param_00073e39); // 0x000000018ABC2B90-0x000000018ABC2E40
		private void yohjHxXpsviSyWsxJpLvoNagNLiR(ref IDualSenseTriggerEffect param_00073e3a, NativeBuffer param_00073e3b, int param_00073e3c); // 0x000000018ABC3750-0x000000018ABC3A80
		private bool cWNDdKjHWcUyzYOsFgZrPjZLiW(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073e3d); // 0x000000018ABC1940-0x000000018ABC1A48
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(NativeBuffer param_00073e3e, double param_00073e3f); // 0x000000018ABC33F4-0x000000018ABC3750
		private void UpYaxgFpNVZKFuYVuRZBvCBMruRh(zseGNggMpNmuvgqogMqiEcjsNLTGc[] param_00073e40, NativeBuffer param_00073e41, double param_00073e42); // 0x000000018ABC07E0-0x000000018ABC0850
		private void wtpahohJGFbRNFDwJuSYdYemDMiYB(); // 0x000000018ABC31F8-0x000000018ABC325C
		private void pOsIRlVLbtdiHmFlfVyGdygxNYZr(NativeBuffer param_00073e43); // 0x000000018ABC22FC-0x000000018ABC237C
		private void vHfgconsGMfWYdkHICzBGcwEErcqc(); // 0x000000018ABC2E40-0x000000018ABC3018
		private static bool AiyWxOBgPpWpMNsHslxJpmXFryPr(ref Vector3 param_00073e44); // 0x000000018ABBF7C0-0x000000018ABBF7F0
		private void sOXxkBcDlswbSzIcxCkMFuyUWUtNA(Vector3 param_00073e45, Vector3 param_00073e46); // 0x000000018ABC237C-0x000000018ABC2720
		private Quaternion wKGCUNkgwbgehoWTuuGDEpsfehihA(Vector3 param_00073e47, float param_00073e48 = 0f /* Metadata: 0x0233419C */); // 0x000000018ABC3018-0x000000018ABC30F8
		private Quaternion xIzhTduUCYcMGVhTgDCMWrRtKdrE(Vector3 param_00073e49, float param_00073e4a = 0f /* Metadata: 0x023341A0 */); // 0x000000018ABC325C-0x000000018ABC33CC
		private bool RAkhYzgaViWNCVLpNQmWUEnUTAKmA(Vector3 param_00073e4b, out TWCgCVykdASvqjAvtwILMsxkJfqS param_00073e4c); // 0x000000018ABC0618-0x000000018ABC06B4
		private bool dnrVvOWNyGgZFCDiyuqhYhlZFwYi(Vector3 param_00073e4d); // 0x000000018ABC1A48-0x000000018ABC1AAC
		private bool KvVxuJqPQdMoUoEmpdfFEDLylXSeb(Vector3 param_00073e4e); // 0x000000018ABC01A8-0x000000018ABC0204
		private Vector3 tIscWxDuheEuxNhWePMsXKCTFjHCA(float[] param_00073e4f); // 0x000000018ABC2960-0x000000018ABC29D8
		private Vector3 nsyUsUUpzkmkhcqiFSFlIzeTrkBS(RingBuffer<PiAoaHLiNJrbgVmbRfzTAJWkhYXRA.HiuAvUHPgkmSANBATMROifVCBjUxA> param_00073e50); // 0x000000018ABC21C4-0x000000018ABC22FC
		private Vector3 nsyUsUUpzkmkhcqiFSFlIzeTrkBS(Vector3 param_00073e51, float param_00073e52); // 0x000000018ABC212C-0x000000018ABC21C4
		private int LuhCwgNusYgFEEHMNmFrQIaUAuBfA(int param_00073e53); // 0x0000000184DA8BF0-0x0000000184DA8C00
		private void PMVNoFmLFIjFcalsPazCvdVVAmDr(byte[] param_00073e54, float[] param_00073e55); // 0x000000018ABC0204-0x000000018ABC02BC
		private void CqWKgKBkckVeSqNwzzwHwdPbxpcP(byte[] param_00073e56, float[] param_00073e57); // 0x000000018ABBF7F0-0x000000018ABBF8A8
		private float XtLNxyTZvnrSNbBhUKpqrWOfcDjN(); // 0x0000000184D8C8E0-0x0000000184D8C8F0
		private void IYBwhwBHWoFBcJeMGGxWueWwCvuSA(NativeBuffer param_00073e58, psxalbFqqRAvexHgaNTDxDrhdRTx.TouchData[] param_00073e59); // 0x000000018ABBFE40-0x000000018ABC0030
		private int KWcCWWDNqxHCAgcqvaevdTpBbfWsb(int param_00073e5a, bool param_00073e5b, int param_00073e5c); // 0x000000018ABC00B0-0x000000018ABC01A8
		private void izyOsNUroIhKZBWsdUMAlJMzboUz(); // 0x0000000184DA8CD0-0x0000000184DA8CE0
		private void saHHzscIFdoJAUqrVQMaGZwQZhAn(); // 0x0000000184DA8CD0-0x0000000184DA8CE0
		private void KOCxANsCETcsclwQohzJULnYfsMv(); // 0x0000000184DA8BE0-0x0000000184DA8BF0
		private void PmzUQqLxlqEZUlJGBXbjJRQbiyw(); // 0x0000000184DA8C00-0x0000000184DA8C10
		~DualSenseDriver(); // 0x000000018ABBF9D8-0x000000018ABBFA54
		protected override void Dispose(bool disposing); // 0x000000018ABBF908-0x000000018ABBF96C
		public static bool Matches(int vid, int pid); // 0x0000000183A44D70-0x0000000183A44DB0
		private static uint ifQVtzKeJXDpETkFUmBePRSjcilY(NativeBuffer param_00073e60, int param_00073e61); // 0x000000018ABC2020-0x000000018ABC20E0
		private static CEDiiLYnylVhKqzRVmTmEUraLGnb FNSTBXHdgxxSvtGiuOkauhskNPVQ(DualSenseOtherLightBrightness param_00073e62); // 0x000000018ABBF96C-0x000000018ABBF9D8
		private static DualSenseOtherLightBrightness AIYjpMYDriUlmmfcRgEdtyHpGITv(CEDiiLYnylVhKqzRVmTmEUraLGnb param_00073e63); // 0x000000018ABBF754-0x000000018ABBF7C0
		private static pWrWdNeHBdvnuLueHgImyhgSLeDG tOYzCQmFNnGLoxkWcrbNuvXTCiOd(DualSenseTriggerType param_00073e64, byte param_00073e65); // 0x000000018ABC29D8-0x000000018ABC2A14
		private static DualSenseTriggerEffectState wNXlGEmGFZtHTuGbIGXOIueiOmND(DualSenseTriggerType param_00073e66, byte param_00073e67, byte param_00073e68); // 0x000000018ABC30F8-0x000000018ABC31F8
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IDriver_DualShock4 // TypeDefIndex: 54017
	{
		// Fields
		private readonly IHIDDevice gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x58
		private readonly HIDProperties VkVAKVIMQRyPhbkRyooTuWaVvzlLA; // 0x60
		private readonly bool PEGFXXAcEYsrWGfWfGnNKtAdthSe; // 0x88
		private readonly sHQfHnKWSyUglbJevPHjzyHZgqdoA TSrVjGqkhjzIsTQjRUUJhTTgBCBF; // 0x8C
		private readonly int ARnnszsMZKeOUYYzZRZUwEefEtii; // 0x90
		private readonly int OMLzFssKjBgHgeLUXdhchwgmfGmx; // 0x94
		private readonly bool UbPOhqoEvaplirSJnLizErwbnFBu; // 0x98
		private readonly byte FrHSGGlmMVQFavVOAKhZHJYnHGND; // 0x99
		private readonly int TRuqcNGExQAFFaBxWIyOLUKqEAKSA; // 0x9C
		private readonly int ZQnyTTTmsZjSDMZMBflUxViYjQod; // 0xA0
		private readonly int QNHGjiJfQABbiilpwdFGdnwonVRC; // 0xA4
		private readonly int uaYfolaObMIVhJvZuyXhRkTDZRlz; // 0xA8
		private readonly NativeBuffer xkaUSPMbKaIaWIOXokAQIEKBViHGA; // 0xB0
		private readonly NativeBuffer sjLHthEwwVztivMgeRRYASiKesWF; // 0xB8
		private readonly SAcTodLryXZPmeZqsKbnQQxsbBmo xbEsAkXaaLqjjqgKWpscjpqoFCyU; // 0xC0
		private readonly byte[] kurYIxHhyxDNBLGJcdeOJDIQsnikA; // 0xD8
		private bool kTzQvuDQExstkJkbShIMTzLhPMKy; // 0xE0
		private bool qoNvEaCyJnqTindhxKVdRtALcZsH; // 0xE1
		private double LKZLXAJjpWMnLeZXoJJDIBuifkZf; // 0xE8
		private int rJijwqsFeFuElEfbIAklzOTKEqKjA; // 0xF0
		private rbgAffEVwbmKKMzOOEOZbWmOSjJH YSAbzHahTyCfisDrqondQGNiVqPO; // 0xF4
		private Quaternion EOVsCHixclSwbGIyDivPXifACXSZ; // 0xF8
		private ushort ngFGBuFNIyEzwXGTNhljyLoCJknib; // 0x108
		private float UAeNzinasdhufezAiyLJHdSmrsql; // 0x10C
		private double AVyPLjpHGvdVMcogFnXBaZUCzxpFA; // 0x110
		private float tZOfLkELLoiGSGwlAOlVuItRImlGB; // 0x118
		private bool nuUGoAcNTzwOLcmLDjnOZsLlJPGOA; // 0x11C
		private bool rvsEQLFTembdQuCxkbdJbZTYtlOeb; // 0x11D
		private bool ydkgbtQgyIoBTsmRFiOVroGvMTnH; // 0x11E
		private bool ZlBjwMZJXngluxDUzJcWwApZVCOw; // 0x11F
		private byte ZyatxfmKaBQwUdfTDraMrdsebPwM; // 0x120
		private byte ogZjReCqmxDoVbSlFgSHbIAgLNss; // 0x121
		private Quaternion ECImyMtRQoTaQXHpKhkvHsYzvMBW; // 0x124
		private Quaternion LWqdBRgbnHexJhYCwZiYeXenPnUhA; // 0x134
		private bool NgvgFVNKYmCzWKlmRRgWyWXkDrPq; // 0x144
		private int SDhaHcneSYWgZhePOydTZlcjFJDV; // 0x148
		private int[] CpFbvUDTUgXVeMMeKgjVDnkgoibZB; // 0x150
		private int[] jxgaQivcSkkQAFauzgYwflHgescD; // 0x158
	
		// Properties
		private bool isVibrating { get; } // 0x000000018ABC1FB8-0x000000018ABC2020 
		public float BatteryLevel { get; } // 0x0000000184DA8D60-0x0000000184DA8D70 
		public bool BatteryCharging { get; } // 0x000000018ABC5468-0x000000018ABC5474 
		public float LeftMotor { get; set; } // 0x000000018ABC1E38-0x000000018ABC1E70 0x000000018ABC2720-0x000000018ABC2754
		public float RightMotor { get; set; } // 0x000000018ABC1F30-0x000000018ABC1F68 0x000000018ABC28C8-0x000000018ABC28FC
		public float LightColorR { get; set; } // 0x000000018ABC1EF0-0x000000018ABC1F30 0x000000018ABC27BC-0x000000018ABC27F0
		public float LightColorG { get; set; } // 0x000000018ABC1EB0-0x000000018ABC1EF0 0x000000018ABC2788-0x000000018ABC27BC
		public float LightColorB { get; set; } // 0x000000018ABC1E70-0x000000018ABC1EB0 0x000000018ABC2754-0x000000018ABC2788
		public float LightFlashOnDuration { get; set; } // 0x0000000184DA8D80-0x0000000184DA8D90 0x000000018ABC5B78-0x000000018ABC5BE4
		public float LightFlashOffDuration { get; set; } // 0x0000000184DA8D70-0x0000000184DA8D80 0x000000018ABC5B0C-0x000000018ABC5B78
		public Vector3 AccelerometerValue { get; } // 0x000000018ABC1B30-0x000000018ABC1B88 
		public Vector3 AccelerometerValueRaw { get; } // 0x000000018ABC1AAC-0x000000018ABC1B30 
		public Vector3 GyroscopeValue { get; } // 0x000000018ABC5474-0x000000018ABC54E0 
		public Vector3 GyroscopeValueRaw { get; } // 0x000000018ABC1B94-0x000000018ABC1C80 
		public Vector3 LastGyroscopeValue { get; } // 0x000000018ABC54E0-0x000000018ABC55A8 
		public Vector3 LastGyroscopeValueRaw { get; } // 0x000000018ABC1CEC-0x000000018ABC1D70 
		public Quaternion Orientation { get; } // 0x0000000184DA8D90-0x0000000184DA8DA0 
		public int MaxTouches { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		ushort IHIDControllerExtension.vendorId { get; } // 0x0000000184DA8C40-0x0000000184DA8C50 
		ushort IHIDControllerExtension.productId { get; } // 0x0000000184DA8C10-0x0000000184DA8C20 
		string IHIDControllerExtension.productName { get; } // 0x0000000184D86230-0x0000000184D86240 
		string IHIDControllerExtension.manufacturer { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		ushort IHIDControllerExtension.usagePage { get; } // 0x0000000184DA8C20-0x0000000184DA8C30 
		ushort IHIDControllerExtension.usage { get; } // 0x0000000184DA8C30-0x0000000184DA8C40 
	
		// Nested types
		private enum BJjxSujbJcqSpnXkhhjndNotpnWD // TypeDefIndex: 54014
		{
			None = 0,
			XZ = 1,
			Y = 2
		}
	
		private static class DJDfyVMZquNeGXcVFPRfPqOGBEHf // TypeDefIndex: 54015
		{
			// Methods
			public static unsafe uint rvUBHGpeaJFkQktbEaUiuwhZrUrN(byte* param_00073ec7, int param_00073ec8, uint param_00073ec9); // 0x000000018ABCD920-0x000000018ABCD978
			private static unsafe uint oTwTKtmidZJYqlcpaXeNESDzIhYV(uint param_00073eca, byte* param_00073ecb, int param_00073ecc, uint param_00073ecd); // 0x000000018ABCD8CC-0x000000018ABCD920
		}
	
		private enum rbgAffEVwbmKKMzOOEOZbWmOSjJH // TypeDefIndex: 54016
		{
			Discharging = 0,
			Charging = 1,
			Full = 2,
			Unknown = 3
		}
	
		// Constructors
		public DualShock4Driver(InitArgs param_00073e9d); // 0x000000018ABC42D4-0x000000018ABC5360
	
		// Methods
		public void ResetOrientation(); // 0x000000018ABC4284-0x000000018ABC42AC
		public int GetTouchCount(); // 0x000000018ABBFA54-0x000000018ABBFAC4
		public bool IsTouchingAtIndex(int index); // 0x000000018ABC0030-0x000000018ABC007C
		public bool IsTouchingAtTouchId(int touchId); // 0x000000018ABC007C-0x000000018ABC00B0
		public int GetTouchIdAtIndex(int index); // 0x000000018ABBFAC4-0x000000018ABBFB10
		public bool GetTouchPositionByIndex(int index, out Vector2 position); // 0x000000018ABBFC94-0x000000018ABBFD28
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x000000018ABBFD28-0x000000018ABBFDF4
		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY); // 0x000000018ABBFB10-0x000000018ABBFBB8
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY); // 0x000000018ABBFBB8-0x000000018ABBFC94
		public void StopLightFlash(); // 0x0000000184DA8D40-0x0000000184DA8D60
		public void StopVibration(); // 0x000000018ABC0778-0x000000018ABC07E0
		public override void Update(UpdateLoopType updateLoop); // 0x000000018ABC42AC-0x000000018ABC42D4
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp); // 0x000000018ABC3FE8-0x000000018ABC4284
		public override Rewired.Controller.Extension CreateControllerExtension(); // 0x000000018ABC3B38-0x000000018ABC3B98
		private void xogNzFQFRWULJIgOmcBxBKtxFiqoA(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073ea2); // 0x000000018ABC62B0-0x000000018ABC62D8
		private bool LSOKeSyVmCGMgCPbzpLZYxBbzNaC(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073ea3); // 0x000000018ABC3EE4-0x000000018ABC3F30
		private void uFUlbKTKNOwrICDqXmKOZKORLYaO(); // 0x000000018ABC5BE4-0x000000018ABC60AC
		private bool cWNDdKjHWcUyzYOsFgZrPjZLiW(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073ea4); // 0x000000018ABC5360-0x000000018ABC5468
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(NativeBuffer param_00073ea5, double param_00073ea6); // 0x000000018ABC62D8-0x000000018ABC65F8
		private void UpYaxgFpNVZKFuYVuRZBvCBMruRh(zseGNggMpNmuvgqogMqiEcjsNLTGc[] param_00073ea7, NativeBuffer param_00073ea8, double param_00073ea9); // 0x000000018ABC07E0-0x000000018ABC0850
		private void wtpahohJGFbRNFDwJuSYdYemDMiYB(); // 0x000000018ABC624C-0x000000018ABC62B0
		private void pOsIRlVLbtdiHmFlfVyGdygxNYZr(NativeBuffer param_00073eaa); // 0x000000018ABC56E0-0x000000018ABC5768
		private void vHfgconsGMfWYdkHICzBGcwEErcqc(); // 0x000000018ABC60AC-0x000000018ABC624C
		private static bool AiyWxOBgPpWpMNsHslxJpmXFryPr(ref Vector3 param_00073eab); // 0x000000018ABBF7C0-0x000000018ABBF7F0
		private void sOXxkBcDlswbSzIcxCkMFuyUWUtNA(Vector3 param_00073eac, Vector3 param_00073ead); // 0x000000018ABC5768-0x000000018ABC5B0C
		private Quaternion wKGCUNkgwbgehoWTuuGDEpsfehihA(Vector3 param_00073eae, float param_00073eaf = 0f /* Metadata: 0x023341D0 */); // 0x000000018ABC3018-0x000000018ABC30F8
		private Quaternion xIzhTduUCYcMGVhTgDCMWrRtKdrE(Vector3 param_00073eb0, float param_00073eb1 = 0f /* Metadata: 0x023341D4 */); // 0x000000018ABC325C-0x000000018ABC33CC
		private bool RAkhYzgaViWNCVLpNQmWUEnUTAKmA(Vector3 param_00073eb2, out BJjxSujbJcqSpnXkhhjndNotpnWD param_00073eb3); // 0x000000018ABC0618-0x000000018ABC06B4
		private bool dnrVvOWNyGgZFCDiyuqhYhlZFwYi(Vector3 param_00073eb4); // 0x000000018ABC1A48-0x000000018ABC1AAC
		private bool KvVxuJqPQdMoUoEmpdfFEDLylXSeb(Vector3 param_00073eb5); // 0x000000018ABC01A8-0x000000018ABC0204
		private Vector3 tIscWxDuheEuxNhWePMsXKCTFjHCA(float[] param_00073eb6); // 0x000000018ABC2960-0x000000018ABC29D8
		private Vector3 nsyUsUUpzkmkhcqiFSFlIzeTrkBS(RingBuffer<PiAoaHLiNJrbgVmbRfzTAJWkhYXRA.HiuAvUHPgkmSANBATMROifVCBjUxA> param_00073eb7); // 0x000000018ABC55A8-0x000000018ABC56E0
		private Vector3 nsyUsUUpzkmkhcqiFSFlIzeTrkBS(Vector3 param_00073eb8, float param_00073eb9); // 0x000000018ABC212C-0x000000018ABC21C4
		private int LuhCwgNusYgFEEHMNmFrQIaUAuBfA(int param_00073eba); // 0x0000000184DA8BF0-0x0000000184DA8C00
		private void PMVNoFmLFIjFcalsPazCvdVVAmDr(byte[] param_00073ebb, float[] param_00073ebc); // 0x000000018ABC3F30-0x000000018ABC3FE8
		private void CqWKgKBkckVeSqNwzzwHwdPbxpcP(byte[] param_00073ebd, float[] param_00073ebe); // 0x000000018ABC3A80-0x000000018ABC3B38
		private float XtLNxyTZvnrSNbBhUKpqrWOfcDjN(); // 0x0000000184D90AD0-0x0000000184D90AE0
		private void IYBwhwBHWoFBcJeMGGxWueWwCvuSA(NativeBuffer param_00073ebf, psxalbFqqRAvexHgaNTDxDrhdRTx.TouchData[] param_00073ec0); // 0x000000018ABC3BFC-0x000000018ABC3DEC
		private int KWcCWWDNqxHCAgcqvaevdTpBbfWsb(int param_00073ec1, bool param_00073ec2, int param_00073ec3); // 0x000000018ABC3DEC-0x000000018ABC3EE4
		private void izyOsNUroIhKZBWsdUMAlJMzboUz(); // 0x0000000184DA8DA0-0x0000000184DA8DB0
		private void saHHzscIFdoJAUqrVQMaGZwQZhAn(); // 0x0000000184DA8DB0-0x0000000184DA8DC0
		private void KOCxANsCETcsclwQohzJULnYfsMv(); // 0x0000000184DA8D30-0x0000000184DA8D40
		private void PmzUQqLxlqEZUlJGBXbjJRQbiyw(); // 0x0000000184D90B30-0x0000000184D90B40
		~DualShock4Driver(); // 0x000000018ABBF9D8-0x000000018ABBFA54
		protected override void Dispose(bool disposing); // 0x000000018ABC3B98-0x000000018ABC3BFC
		public static bool Matches(int vid, int pid); // 0x0000000183A450F0-0x0000000183A451F0
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver // TypeDefIndex: 54022
	{
		// Fields
		public MkXjQPavsbpITCEdETTHuRYirZF[] axes; // 0x10
		public lvcscUNtHDcrkMfwArDXBcZCtwpB[] buttons; // 0x18
		public aGpYUdpKsUxonfUNYstiGMzKpBRk[] hats; // 0x20
		public BMNnWbDIXUHHRoADwVXJdYVDrPxr[] accelerometers; // 0x28
		public PiAoaHLiNJrbgVmbRfzTAJWkhYXRA[] gyroscopes; // 0x30
		public psxalbFqqRAvexHgaNTDxDrhdRTx[] touchpads; // 0x38
		public CdOeHzikbRBkBZoJPipyBOeHnirMb[] vibrationMotors; // 0x40
		public RBWPuDEGPubdlvFFeXjPxJMpYYij[] lights; // 0x48
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0x50
	
		// Properties
		public int AxisCount { get; } // 0x0000000183141B90-0x0000000183141BB0 
		public int ButtonCount { get; } // 0x0000000183BA3DE0-0x0000000183BA3E00 
		public int HatCount { get; } // 0x000000018AA74444-0x000000018AA74458 
		public int AccelerometerCount { get; } // 0x000000018A78175C-0x000000018A781770 
		public int GyroscopeCount { get; } // 0x000000018AA50CC0-0x000000018AA50CD4 
		public int TouchpadCount { get; } // 0x000000018ABCDC20-0x000000018ABCDC34 
		public int LightCount { get; } // 0x000000018AA7AFC8-0x000000018AA7AFDC 
		public int VibrationMotorCount { get; } // 0x000000018AA75B34-0x000000018AA75B48 
		protected bool disposed { get; } // 0x0000000184D86800-0x0000000184D86810 
	
		// Nested types
		[CustomObfuscation(rename = false)]
		public enum DriverType // TypeDefIndex: 54018
		{
			None = 0,
			DualShock4 = 1,
			DualSense = 2,
			RailDriver = 3,
			SwitchJoyConLeft = 4,
			SwitchJoyConRight = 5,
			SwitchProController = 6
		}
	
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		internal struct HIDProperties // TypeDefIndex: 54019
		{
			// Fields
			public ushort vendorId; // 0x00
			public ushort productId; // 0x02
			public string productName; // 0x08
			public string manufacturer; // 0x10
			public ushort usagePage; // 0x18
			public ushort usage; // 0x1A
			public int maxInputReportLength; // 0x1C
			public int maxOutputReportLength; // 0x20
			public int maxFeatureReportLength; // 0x24
	
			// Constructors
			public HIDProperties(ushort param_00073ed8, ushort param_00073ed9, string param_00073eda, string param_00073edb, ushort param_00073edc, ushort param_00073edd, int param_00073ede, int param_00073edf, int param_00073ee0); // 0x000000018ABCDC34-0x000000018ABCDC94
		}
	
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		internal interface IHIDDevice // TypeDefIndex: 54020
		{
			// Properties
			HIDProperties properties { get; }
	
			// Methods
			bool WriteSync(SAcTodLryXZPmeZqsKbnQQxsbBmo outputReport, int timeoutMs);
			void WriteAsync(SAcTodLryXZPmeZqsKbnQQxsbBmo outputReport, int timeoutMs);
			bool ReadSync(IntPtr buffer, int bytesToRead, int timeoutMs);
			byte[] GetHidFeatureData(byte reportId, int reportLength, int timeoutMs, int retryCount);
		}
	
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		internal class InitArgs // TypeDefIndex: 54021
		{
			// Fields
			public readonly UpdateLoopSetting updateLoopSetting; // 0x10
			public readonly sHQfHnKWSyUglbJevPHjzyHZgqdoA connectionType; // 0x14
			public readonly int minAxisValue; // 0x18
			public readonly int maxAxisValue; // 0x1C
			public readonly int hatZeroValue; // 0x20
			public readonly int hatSpan; // 0x24
			public readonly IHIDDevice hidDevice; // 0x28
	
			// Constructors
			public InitArgs(UpdateLoopSetting param_00073eec, sHQfHnKWSyUglbJevPHjzyHZgqdoA param_00073eed, int param_00073eee, int param_00073eef, int param_00073ef0, int param_00073ef1, IHIDDevice param_00073ef2); // 0x000000018ABCDDD8-0x000000018ABCDE0C
		}
	
		// Constructors
		public HIDDeviceDriver(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void Update(UpdateLoopType updateLoop);
		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp);
		public abstract Rewired.Controller.Extension CreateControllerExtension();
		public static HIDDeviceDriver GetDriver(DriverType driverId, InitArgs hidDriverInitArgs); // 0x000000018ABCDA4C-0x000000018ABCDC20
		public static DriverType FindDriverId(int vendorId, int productId, IList<EnhancedDeviceSupportDeviceType> exclusions); // 0x0000000183A44C90-0x0000000183A44D30
		public void Dispose(); // 0x000000018ABCD978-0x000000018ABCD9C8
		~HIDDeviceDriver(); // 0x000000018ABCD9D4-0x000000018ABCDA4C
		protected virtual void Dispose(bool disposing); // 0x000000018ABCD9C8-0x000000018ABCD9D4
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class NintendoSwitchGamepadDriver : HIDDeviceDriver, IDisposable, IDriver_NintendoSwitchController // TypeDefIndex: 54028
	{
		// Fields
		protected readonly wcLGjjlXOWCsqrhLDGtKnWBSVcAL _controllerType; // 0x58
		protected readonly int _buttonCount; // 0x5C
		protected readonly int _axisCount; // 0x60
		protected readonly int _vibrationMotorCount; // 0x64
		private readonly IHIDDevice gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x68
		private readonly HIDProperties VkVAKVIMQRyPhbkRyooTuWaVvzlLA; // 0x70
		private readonly bool PEGFXXAcEYsrWGfWfGnNKtAdthSe; // 0x98
		private readonly NativeBuffer xkaUSPMbKaIaWIOXokAQIEKBViHGA; // 0xA0
		private readonly NativeBuffer sjLHthEwwVztivMgeRRYASiKesWF; // 0xA8
		private readonly NativeBuffer XUiBGOkHFNFWUFoUrjADtRoLXAQT; // 0xB0
		private readonly byte[] IATUqdBFMSOIhdhuSoWnfOVNSiRI; // 0xB8
		private readonly NativeBuffer PfJRNLcaaoUtfmoAObNqdAXRldMQA; // 0xC0
		private readonly NativeBuffer NcAkBSdACkUQgRhsHUsNzYjLRvGJ; // 0xC8
		private SAcTodLryXZPmeZqsKbnQQxsbBmo xbEsAkXaaLqjjqgKWpscjpqoFCyU; // 0xD0
		private double VBWpehmsQBxWzBfFrAcsbRdRxsCF; // 0xE8
		private byte WHAVLVNQnaHFoQFnUaKnEJHreRDIA; // 0xF0
		private double tXqdBrhJtnKjfFqqiksXncroTOWLB; // 0xF8
		private bool ARtQUtYYexjLKEzjKvNnVHUMYmur; // 0x100
		private bool YcrITPRQcuWnqpkOKTEheFfNkewS; // 0x101
		private WUYtwgxBXJzJOdfCTCFuhglrMbxfA[] wGkCKLAkOYgzFEEkIitVSsXwRAoC; // 0x108
		private rZsfLMXWUnotxWcVpREIqsNOkmls[] UXzCzuhkmIflTzCmcKjULpNJFOupA; // 0x110
		private static readonly byte[] ZCnVgaecDladAEpezVypWQNqWRCK; // 0x00
	
		// Properties
		public int vibrationMotorCount { get; } // 0x0000000184D88110-0x0000000184D88120 
		ushort IHIDControllerExtension.vendorId { get; } // 0x0000000184DA8EA0-0x0000000184DA8EB0 
		ushort IHIDControllerExtension.productId { get; } // 0x0000000184DA8E70-0x0000000184DA8E80 
		string IHIDControllerExtension.productName { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		string IHIDControllerExtension.manufacturer { get; } // 0x0000000184D86260-0x0000000184D86270 
		ushort IHIDControllerExtension.usagePage { get; } // 0x0000000184DA8E80-0x0000000184DA8E90 
		ushort IHIDControllerExtension.usage { get; } // 0x0000000184DA8E90-0x0000000184DA8EA0 
	
		// Nested types
		protected enum wcLGjjlXOWCsqrhLDGtKnWBSVcAL // TypeDefIndex: 54023
		{
			ProController = 0,
			JoyConLeft = 1,
			JoyConRight = 2
		}
	
		protected class WUYtwgxBXJzJOdfCTCFuhglrMbxfA // TypeDefIndex: 54024
		{
			// Fields
			private CdOeHzikbRBkBZoJPipyBOeHnirMb oSmYVHrrZztTUAiQcopTNrallcvl; // 0x10
			private IgqKcEqmTZuWvfVRBytHBiJRqAZc bKSxRBAOIgmZCEKqTSnKkrSHyMZd; // 0x18
			private float HvLeGrPgSwfgAkbpUoozeNKUSIgdb; // 0x28
			private double sPQpifsdFSURWZLTNyRQiXnBddck; // 0x30
	
			// Properties
			public IgqKcEqmTZuWvfVRBytHBiJRqAZc AQwStVeKIwCRGaZPubvpRItBKTIFb { get; } // 0x0000000184D890C0-0x0000000184D890D0 
	
			// Constructors
			public WUYtwgxBXJzJOdfCTCFuhglrMbxfA(CdOeHzikbRBkBZoJPipyBOeHnirMb param_00073f40); // 0x000000018ABD2DF8-0x000000018ABD2E1C
	
			// Methods
			public void mnOZfTJZaPJhBHSiKkLNiAfZLffw(float param_00073f41, float param_00073f42, float param_00073f43, float param_00073f44, float param_00073f45); // 0x000000018ABD2E1C-0x000000018ABD2F68
			public void TSexxBoQJJrDUHjAVGegZXOfrqTg(double param_00073f46); // 0x000000018ABD2D78-0x000000018ABD2DB8
			public void RLhCOjJytEwCexIjODqRQczSCOzr(); // 0x000000018ABD2D10-0x000000018ABD2D78
			public void ZNeBqtGTmPaOOBcWCPGYKvyjvYxhB(); // 0x000000018ABD2DB8-0x000000018ABD2DF8
		}
	
		protected struct IgqKcEqmTZuWvfVRBytHBiJRqAZc // TypeDefIndex: 54025
		{
			// Fields
			public float qnRKuAnbBhrlERNWTQPANqYTGWYN; // 0x00
			public float FxcGHIgfFucNsZZowrmpUZhVmEYOA; // 0x04
			public float TGpeirHYwttcqhmPwlZxHhNBiFvIA; // 0x08
			public float jHwyInqjSJsdWkuMHPfyxSkBeAGe; // 0x0C
	
			// Constructors
			internal IgqKcEqmTZuWvfVRBytHBiJRqAZc(float param_00073f47, float param_00073f48, float param_00073f49, float param_00073f4a); // 0x000000018AA8026C-0x000000018AA802C4
	
			// Methods
			public static IgqKcEqmTZuWvfVRBytHBiJRqAZc XchWqxgmUvhSvDLAYlZyAXmMcTYy(); // 0x000000018AA80028-0x000000018AA80044
			public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABCDC94-0x000000018ABCDDD8
		}
	
		private struct vLrvCEMfbNvdxOZFnFodHwNKJpgW // TypeDefIndex: 54026
		{
			// Fields
			public byte GEceeAxWbJBtYCHpVqINelGlzHPL; // 0x00
			public byte[] jeDVBuCiLeNXiUiAaKpbhZdLcwVc; // 0x08
			public int waPRlRSkshALtzJtPscwChHvxPvA; // 0x10
	
			// Constructors
			public vLrvCEMfbNvdxOZFnFodHwNKJpgW(byte param_00073f4b, byte[] param_00073f4c, int param_00073f4d); // 0x0000000188EF8150-0x0000000188EF8170
		}
	
		protected class rZsfLMXWUnotxWcVpREIqsNOkmls // TypeDefIndex: 54027
		{
			// Fields
			public ushort XQPUUnlyQwdKFhnfBaahYWJhEfFf; // 0x10
			public ushort iFmMpKKVrxAaquHXfAKrFfTduJCoA; // 0x12
			public ushort bGVtRIaXAhMiQKAMBeaaYedlOQkf; // 0x14
			public ushort EgdKWhZprbpKAYWwnahUEaPhAUVEA; // 0x16
	
			// Constructors
			public rZsfLMXWUnotxWcVpREIqsNOkmls(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override string vPQRuijKVWXgODYHqHVwLVeBdxsL(); // 0x000000018ABD2F68-0x000000018ABD30B0
		}
	
		// Constructors
		protected NintendoSwitchGamepadDriver(InitArgs param_00073f12, wcLGjjlXOWCsqrhLDGtKnWBSVcAL param_00073f13, int param_00073f14, int param_00073f15, int param_00073f16); // 0x000000018ABCF9C0-0x000000018ABCFFF4
		static NintendoSwitchGamepadDriver(); // 0x000000018ABCF934-0x000000018ABCF9C0
	
		// Methods
		public void GetVibration(int motorIndex, out float amplitudeLow, out float frequencyLow, out float amplitudeHigh, out float frequencyHigh); // 0x000000018ABCE508-0x000000018ABCE594
		public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh); // 0x000000018ABCF2FC-0x000000018ABCF340
		public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors); // 0x000000018ABCF3F8-0x000000018ABCF444
		public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration); // 0x000000018ABCF2B0-0x000000018ABCF2FC
		public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors); // 0x000000018ABCF340-0x000000018ABCF3F8
		public void StopVibration(int motorIndex); // 0x000000018ABCF49C-0x000000018ABCF4E0
		public void StopVibration(); // 0x000000018ABCF444-0x000000018ABCF49C
		private void zdfqRijxtsPriXbLVHJRFgHKxhTcA(int param_00073f11); // 0x000000018ABD07A4-0x000000018ABD080C
		protected void Initialize(); // 0x000000018ABCE604-0x000000018ABCEB78
		public override void Update(UpdateLoopType updateLoop); // 0x000000018ABCF5B0-0x000000018ABCF748
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp); // 0x000000018ABCEF1C-0x000000018ABCF080
		protected abstract void UpdateButtons(NativeBuffer inputReport, double timestamp);
		protected abstract void UpdateElements(zseGNggMpNmuvgqogMqiEcjsNLTGc[] elements, NativeBuffer inputReport, double timestamp);
		private bool LHTQmniloxxvLUBvWooEQJBMckxFA(vLrvCEMfbNvdxOZFnFodHwNKJpgW param_00073f20, byte[] param_00073f21); // 0x000000018ABCEBC0-0x000000018ABCEF1C
		private bool XNEPLczSghGxfiHBBQBFllxUGZYh(NativeBuffer param_00073f22, byte param_00073f23); // 0x000000018ABCF8CC-0x000000018ABCF934
		private void HChFRtIoVWDFmfMJBcrPBtjGfQNY(NativeBuffer param_00073f24); // 0x000000018ABCE594-0x000000018ABCE604
		private void SxAdTqOoJagADFgnJZxAjZWQieEe(NativeBuffer param_00073f25, int param_00073f26); // 0x000000018ABCF4E0-0x000000018ABCF5B0
		private static void SFkRhTrgmrHnhdjpcHOYgefKiVEl(NativeBuffer param_00073f27, int param_00073f28, IgqKcEqmTZuWvfVRBytHBiJRqAZc param_00073f29); // 0x000000018ABCF080-0x000000018ABCF2B0
		private static byte AxrwIQtLXJBzGGlOgMzxHTBWNNsCb(float param_00073f2a); // 0x000000018ABCDE0C-0x000000018ABCDF7C
		private bool sVFgBkVJzHonzwPVLYllGkUaBluE(); // 0x000000018ABD0660-0x000000018ABD0744
		private bool kvaTWgNrBcpLSfPvzeibboaKLEKVA(byte param_00073f2b, byte param_00073f2c, byte param_00073f2d, byte[] param_00073f2e); // 0x000000018ABD04D4-0x000000018ABD0660
		private bool cWNDdKjHWcUyzYOsFgZrPjZLiW(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073f2f); // 0x000000018ABCFFF4-0x000000018ABD00B4
		private byte FjQCWVDBCljzgHZKPTpkqfXsFaHhb(); // 0x000000018ABCE2A4-0x000000018ABCE2C4
		private bool ghsxgEGOPBfwjydpCjOkBJkzcZoMA(); // 0x000000018ABD00B4-0x000000018ABD04D4
		private static void XDpefEfWNwHpFIMSZGjhsJLMGjEe(byte[] param_00073f30, rZsfLMXWUnotxWcVpREIqsNOkmls param_00073f31, rZsfLMXWUnotxWcVpREIqsNOkmls param_00073f32, bool param_00073f33); // 0x000000018ABCF748-0x000000018ABCF8CC
		private static void KsbyBJXhKyqNGURubvAmjHeIRRtb(byte[] param_00073f34, rZsfLMXWUnotxWcVpREIqsNOkmls param_00073f35, rZsfLMXWUnotxWcVpREIqsNOkmls param_00073f36); // 0x000000018ABCEB78-0x000000018ABCEBC0
		protected bool GetCalibratedStickValue(ushort valueX, ushort valueY, rZsfLMXWUnotxWcVpREIqsNOkmls calX, rZsfLMXWUnotxWcVpREIqsNOkmls calY, out ushort calibratedX, out ushort calibratedY); // 0x000000018ABCE2F4-0x000000018ABCE508
		protected rZsfLMXWUnotxWcVpREIqsNOkmls GetAxisCalibration(int index); // 0x000000018ABCE2C4-0x000000018ABCE2F4
		private void yonePGyMPqkUCoaTVtNEWneSYdiQ(bool param_00073f3e); // 0x000000018ABD0744-0x000000018ABD07A4
		~NintendoSwitchGamepadDriver(); // 0x000000018ABBF9D8-0x000000018ABBFA54
		protected override void Dispose(bool disposing); // 0x000000018ABCDF7C-0x000000018ABCE2A4
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class NintendoSwitchJoyConDriver : NintendoSwitchGamepadDriver, IDriver_NintendoSwitchJoyCon // TypeDefIndex: 54029
	{
		// Fields
		private readonly NativeBuffer rIqxtIVIBEWMoGjIpWvOKpsgCyniA; // 0x118
		private readonly NintendoSwitchJoyConType nXpBukbUBuhQwkirWrOqFozREqkg; // 0x120
		private NintendoSwitchJoyConGripStyle RrpUzCrfRyynLqpEodrUCzvNYnnG; // 0x124
		private readonly byte[] EZeYuaOIJYjqeBMLylNPkWvUjsXjA; // 0x128
	
		// Properties
		protected byte[] buttonAxisReadBuffer { get; } // 0x0000000184D8D910-0x0000000184D8D920 
		protected abstract int byteIndexStartSticks { get; }
		public NintendoSwitchJoyConType joyConType { get; } // 0x0000000184D90A90-0x0000000184D90AA0 
		public NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; } // 0x0000000184D90A80-0x0000000184D90A90 0x0000000184D90AB0-0x0000000184D90AC0
	
		// Constructors
		protected NintendoSwitchJoyConDriver(InitArgs param_00073f50, wcLGjjlXOWCsqrhLDGtKnWBSVcAL param_00073f51); // 0x000000018ABD0B38-0x000000018ABD0E2C
	
		// Methods
		int IAxisCalibrationIndexMap.GetMappedAxisIndex(int elementIndex); // 0x000000018ABD0934-0x000000018ABD094C
		public override Rewired.Controller.Extension CreateControllerExtension(); // 0x000000018ABD080C-0x000000018ABD086C
		protected override void UpdateElements(zseGNggMpNmuvgqogMqiEcjsNLTGc[] elements, NativeBuffer inputReport, double timestamp); // 0x000000018ABD094C-0x000000018ABD0B38
		protected abstract void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY);
		~NintendoSwitchJoyConDriver(); // 0x000000018ABD08B8-0x000000018ABD0934
		protected override void Dispose(bool disposing); // 0x000000018ABD086C-0x000000018ABD08B8
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class NintendoSwitchJoyConLeftDriver : NintendoSwitchJoyConDriver // TypeDefIndex: 54030
	{
		// Properties
		protected override int byteIndexStartSticks { get; } // 0x0000000184D9EC60-0x0000000184D9EC70 
	
		// Constructors
		public NintendoSwitchJoyConLeftDriver(InitArgs param_00073f58); // 0x000000018ABD1230-0x000000018ABD1240
	
		// Methods
		protected override void UpdateButtons(NativeBuffer inputReport, double timestamp); // 0x000000018ABD0ED8-0x000000018ABD1230
		protected override void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY); // 0x000000018ABD0EB8-0x000000018ABD0ED8
		~NintendoSwitchJoyConLeftDriver(); // 0x000000018ABD0E3C-0x000000018ABD0EB8
		protected override void Dispose(bool disposing); // 0x000000018ABD0E2C-0x000000018ABD0E3C
		public static bool Matches(int vid, int pid); // 0x0000000183A44D60-0x0000000183A44D70
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class SwitchJoyConRightDriver : NintendoSwitchJoyConDriver // TypeDefIndex: 54031
	{
		// Properties
		protected override int byteIndexStartSticks { get; } // 0x0000000184DA4FC0-0x0000000184DA4FD0 
	
		// Constructors
		public SwitchJoyConRightDriver(InitArgs param_00073f60); // 0x000000018ABD2D00-0x000000018ABD2D10
	
		// Methods
		protected override void UpdateButtons(NativeBuffer inputReport, double timestamp); // 0x000000018ABD2A78-0x000000018ABD2D00
		protected override void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY); // 0x000000018ABD2A5C-0x000000018ABD2A78
		~SwitchJoyConRightDriver(); // 0x000000018ABD0E3C-0x000000018ABD0EB8
		protected override void Dispose(bool disposing); // 0x000000018ABD0E2C-0x000000018ABD0E3C
		public static bool Matches(int vid, int pid); // 0x0000000183A44D50-0x0000000183A44D60
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class NintendoSwitchProControllerDriver : NintendoSwitchGamepadDriver, IDriver_NintendoSwitchProController // TypeDefIndex: 54032
	{
		// Fields
		private readonly byte[] EZeYuaOIJYjqeBMLylNPkWvUjsXjA; // 0x118
		private readonly NativeBuffer rIqxtIVIBEWMoGjIpWvOKpsgCyniA; // 0x120
	
		// Constructors
		public NintendoSwitchProControllerDriver(InitArgs param_00073f68); // 0x000000018ABD1B4C-0x000000018ABD1EDC
	
		// Methods
		public override void Update(UpdateLoopType updateLoop); // 0x000000018ABD1B44-0x000000018ABD1B4C
		public override Rewired.Controller.Extension CreateControllerExtension(); // 0x000000018ABD1240-0x000000018ABD12A0
		protected override void UpdateButtons(NativeBuffer inputReport, double timestamp); // 0x000000018ABD12EC-0x000000018ABD18A0
		protected override void UpdateElements(zseGNggMpNmuvgqogMqiEcjsNLTGc[] elements, NativeBuffer inputReport, double timestamp); // 0x000000018ABD18A0-0x000000018ABD1B44
		~NintendoSwitchProControllerDriver(); // 0x000000018ABD08B8-0x000000018ABD0934
		protected override void Dispose(bool disposing); // 0x000000018ABD12A0-0x000000018ABD12EC
		public static bool Matches(int vid, int pid); // 0x0000000183A44D40-0x0000000183A44D50
	}

	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IDriver_RailDriver // TypeDefIndex: 54034
	{
		// Fields
		private readonly NativeBuffer xkaUSPMbKaIaWIOXokAQIEKBViHGA; // 0x58
		private readonly NativeBuffer sjLHthEwwVztivMgeRRYASiKesWF; // 0x60
		private bool MgGjdIWLebvbxyLjifZCwysvJEEv; // 0x68
		private byte[] lQNMiymyuSCJPIOyegfeIWYnsDUfA; // 0x70
		private readonly IHIDDevice gFLkmEnVjMQSOwejMhMlKHEESruD; // 0x78
		private readonly HIDProperties VkVAKVIMQRyPhbkRyooTuWaVvzlLA; // 0x80
		private readonly SAcTodLryXZPmeZqsKbnQQxsbBmo xbEsAkXaaLqjjqgKWpscjpqoFCyU; // 0xA8
	
		// Properties
		public bool SpeakerEnabled { get; set; } // 0x0000000184D86B40-0x0000000184D86B50 0x000000018ABD26B4-0x000000018ABD26C4
		ushort IHIDControllerExtension.vendorId { get; } // 0x0000000184DA5C60-0x0000000184DA5C70 
		ushort IHIDControllerExtension.productId { get; } // 0x0000000184DA8EB0-0x0000000184DA8EC0 
		string IHIDControllerExtension.productName { get; } // 0x0000000184D861F0-0x0000000184D86200 
		string IHIDControllerExtension.manufacturer { get; } // 0x0000000184D86220-0x0000000184D86230 
		ushort IHIDControllerExtension.usagePage { get; } // 0x0000000184DA8EC0-0x0000000184DA8ED0 
		ushort IHIDControllerExtension.usage { get; } // 0x0000000184DA8ED0-0x0000000184DA8EE0 
	
		// Nested types
		private enum ZGfmepahbYuPqRsanVTTjGOJtIWA // TypeDefIndex: 54033
		{
			Speaker = 0,
			LED = 1
		}
	
		// Constructors
		public RailDriverDriver(InitArgs param_00073f78); // 0x000000018ABD20D0-0x000000018ABD25F4
	
		// Methods
		public void SetLEDDisplay(int digitIndex, byte digitBitValues); // 0x000000018ABD2034-0x000000018ABD2074
		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues); // 0x000000018ABD2074-0x000000018ABD20D0
		public override void Update(UpdateLoopType updateLoop); // 0x00000001841E1670-0x00000001841E1680
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp); // 0x000000018ABD1FB0-0x000000018ABD2034
		public override Rewired.Controller.Extension CreateControllerExtension(); // 0x000000018ABD1EDC-0x000000018ABD1F3C
		private bool LSOKeSyVmCGMgCPbzpLZYxBbzNaC(ZGfmepahbYuPqRsanVTTjGOJtIWA param_00073f7d, hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073f7e); // 0x000000018ABD1F80-0x000000018ABD1FB0
		private void uFUlbKTKNOwrICDqXmKOZKORLYaO(ZGfmepahbYuPqRsanVTTjGOJtIWA param_00073f7f); // 0x000000018ABD26C4-0x000000018ABD282C
		private bool cWNDdKjHWcUyzYOsFgZrPjZLiW(hJxPFEDYiOqNMDuutvEivGuMTnYB param_00073f80); // 0x000000018ABD25F4-0x000000018ABD26B4
		private void yfAvlFShiJiZPPnfreeMjhGTujmfA(NativeBuffer param_00073f81, double param_00073f82); // 0x000000018ABD282C-0x000000018ABD2A5C
		private void UpYaxgFpNVZKFuYVuRZBvCBMruRh(zseGNggMpNmuvgqogMqiEcjsNLTGc[] param_00073f83, NativeBuffer param_00073f84, double param_00073f85); // 0x000000018ABC07E0-0x000000018ABC0850
		~RailDriverDriver(); // 0x000000018ABBF9D8-0x000000018ABBFA54
		protected override void Dispose(bool disposing); // 0x000000018ABD1F3C-0x000000018ABD1F80
		public static bool Matches(int vid, int pid); // 0x0000000183A44D30-0x0000000183A44D40
	}
}

namespace Rewired.InputManagers
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class Initializer : PlatformInitializer // TypeDefIndex: 53587
	{
		// Fields
		private static PlatformInitializer kmqGlvnBOqdlIDoelaOAjDQhsEhbA; // 0x00
	
		// Constructors
		public Initializer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static PlatformInitializer GetPlatformInitializer(); // 0x0000000184D27180-0x0000000184D27200
		public override object Initialize(IConfigVars_Internal configVars); // 0x000000018381A210-0x000000018381A3C0
		public override IElementIdentifierTool CreateTool(string inputSourceString); // 0x000000018AB7B0E4-0x000000018AB7B184
	}
}

namespace Rewired.InputSources.SDL2
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class SDL2InputSource : IInputSource // TypeDefIndex: 53959
	{
		// Fields
		private bool axkKvliPJxIEjkBAIyuBFFzRUJZj; // 0x10
		private bool jikBZpFucxALVjhcdxNRroKiaMWsB; // 0x11
		private bool WVkPZPERjqJrUTkyeJPxPWSPJUUe; // 0x12
		private bool blXhVnJwmDqRDEWaVygZFlMlUjnd; // 0x13
		private bool YcrITPRQcuWnqpkOKTEheFfNkewS; // 0x14
		private ADictionary<int, dnxyCjpDlDvOdxTyzeYVqByiyZzK> PCdPJbHLsogIbJECApXLUpgSXfnrA; // 0x18
		private ADictionary<int, HMtmYXFGOgHuhDFfOFddFYSgYpDVA> jfFFrjJzCZwWsYPdYeEoIBoShtaCA; // 0x20
		private ERrmsitpcXDZelTYlGLEEisQnmaGA.iFlWUPUplqnKICmxEXHwZclSsZxJ YXGLeQKpGOEBeMaONCfiFPSWebhx; // 0x28
		private NativeBuffer pvIQxzUsygaPXmiRvsrKjgcopHDq; // 0xB0
		[CompilerGenerated]
		private Action dxnTatXHsETEvJsuYRfCNkvGrAxy; // 0xB8
		private bool eLGaZWNmIskxPvBERxVfbRtgiQJG; // 0xC0
	
		// Events
		private event Action _DeviceChangedEvent {
			add; // 0x000000018ABC8E40-0x000000018ABC8ED8
			remove; // 0x000000018ABC9194-0x000000018ABC922C
		}
		public event Action DeviceChangedEvent {
			add; // 0x000000018ABC9C10-0x000000018ABC9C18
			remove; // 0x000000018ABCA178-0x000000018ABCA180
		}
	
		// Constructors
		public SDL2InputSource(UpdateLoopSetting param_00073d22, bool param_00073d23, bool param_00073d24, bool param_00073d25, bool param_00073d26); // 0x000000018ABC9940-0x000000018ABC9C10
	
		// Methods
		public void SystemDeviceConnected(); // 0x000000018ABC9454-0x000000018ABC94A0
		public void SystemDeviceDisconnected(); // 0x000000018ABC94A0-0x000000018ABC94EC
		public void Update(); // 0x00000001841E1670-0x00000001841E1680
		public void UpdateDevices(UpdateLoopType updateLoop); // 0x000000018ABC9618-0x000000018ABC9628
		public void UpdateFinished(); // 0x00000001841E1670-0x00000001841E1680
		public IList<T> GetJoysticks<T>()
			where T : class;
		private int jJiflOGWXPvqIozGqKiZJpHvQFNM(); // 0x000000018ABC9D48-0x000000018ABC9D9C
		private dnxyCjpDlDvOdxTyzeYVqByiyZzK AIeKyVaARAbqBseIBlYSeGYKIRPf(int param_00073d2c); // 0x000000018ABC8C58-0x000000018ABC8D2C
		private HMtmYXFGOgHuhDFfOFddFYSgYpDVA gBNIybsZTXAmCaKhYascONqMhSrc(int param_00073d2d); // 0x000000018ABC9C50-0x000000018ABC9D48
		private EAUUbKQFcztOaxVulmGcrJehPchk HyiBkIyOECHCrIoBldAPabTCXmkL(int param_00073d2e, emeCwsELnoJvwBwEcPKnJiieeMKWB param_00073d2f); // 0x000000018ABC8F40-0x000000018ABC9068
		private EAUUbKQFcztOaxVulmGcrJehPchk ViZqQMwzPcmDSdCsEEbAlNkidrQG(int param_00073d30, vNRtVHTjVoyNCDmQcAzXxtkQARZr param_00073d31); // 0x000000018ABC9690-0x000000018ABC9724
		private void XPCDnGEzgkfVnCkrckXqMyQfoJYcc(); // 0x000000018ABC98E4-0x000000018ABC9940
		private void ngDwkjpbEWRBNcKXSDRjHRwjBKlLA(); // 0x000000018ABC9DEC-0x000000018ABCA104
		private bool UZywRESKMpGMDDmezeTfAxnccbZQ(int param_00073d32); // 0x000000018ABC94EC-0x000000018ABC9618
		private void wqNaUSqQKKjHQwxpKLkaRwRpHQPt(int param_00073d33); // 0x000000018ABCA210-0x000000018ABCA2BC
		private bool SXaDIQEJgRfHDgvjFwseYXBOkOGRA(int param_00073d34); // 0x000000018ABC9330-0x000000018ABC9454
		private void ywKjiqUeBmWYHXunwWNGtCyLePFs(int param_00073d35); // 0x000000018ABCA2BC-0x000000018ABCA368
		private dnxyCjpDlDvOdxTyzeYVqByiyZzK HWVGwOeKGJdZtPelpcqeGGIJqUvZb(int param_00073d36); // 0x000000018ABC8ED8-0x000000018ABC8F40
		private HMtmYXFGOgHuhDFfOFddFYSgYpDVA VYenPzBRozvvWYLHsDkjerWXlpnEb(int param_00073d37); // 0x000000018ABC9628-0x000000018ABC9690
		private void WsjBbREIIhMeCyzhcDPEhwpDTLMzb(); // 0x000000018ABC9724-0x000000018ABC98E4
		private void qCJunJjLcnCecADZSsfUnQxyORBv(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.WtYDlYGBazQlCIfNIIGpZwxTHFulA param_00073d38, double param_00073d39); // 0x000000018ABCA140-0x000000018ABCA178
		private void eQqdnlIiBPspGhSxZlunxIkAwkiGA(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.ARLpXSGgShledzMXCkwiFbYQfzgq param_00073d3a, double param_00073d3b); // 0x000000018ABC9C18-0x000000018ABC9C50
		private void JKifqkEUcTcvSfvEDPyOwyjcREQx(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.MpgatCrtHXZXKexKnssNnzqOxHkb param_00073d3c, double param_00073d3d); // 0x000000018ABC90A4-0x000000018ABC90DC
		private void XhrlMWJsyShJAPEqJeIfwdObJvpy(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.nuPqVpafSULPUJReuwXEHVFGTqYo param_00073d3e, double param_00073d3f); // 0x00000001841E1670-0x00000001841E1680
		private void NBnDLoBkwkhNRbZsLPdvWhUvxqcL(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.XkfkMHwGKUjrAejsvknbmMNxlVxj param_00073d40); // 0x000000018ABC90DC-0x000000018ABC9118
		private void PEjBbOeLuEXsmMwhUWOFjbEebzmcb(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.XkfkMHwGKUjrAejsvknbmMNxlVxj param_00073d41); // 0x000000018ABC9118-0x000000018ABC9154
		private void wKOJbYEinLweOxZznCORqijmkaPL(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.EEHintEoWqwtrulXqUuaStXrpcHl param_00073d42, double param_00073d43); // 0x000000018ABCA1D0-0x000000018ABCA210
		private void PRxdkZaJWvPmORSVENOsizlgWymHb(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.ZFIgyKFYAnbTAjavbvUFScwzweHVA param_00073d44, double param_00073d45); // 0x000000018ABC9154-0x000000018ABC9194
		private void omMjLVkXiEoOSUcYWtcRVMgovlBR(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.wEGFotndTOlmgYqzAoyIypxyoDcB param_00073d46); // 0x000000018ABCA104-0x000000018ABCA140
		private void IAhWNKhBbwGSYSxqBEGqdaQcapZO(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.wEGFotndTOlmgYqzAoyIypxyoDcB param_00073d47); // 0x000000018ABC9068-0x000000018ABC90A4
		private void zuOAfpgCoxGAvQbTcrPrRhdgqViPA(ref ERrmsitpcXDZelTYlGLEEisQnmaGA.wEGFotndTOlmgYqzAoyIypxyoDcB param_00073d48); // 0x00000001841E1670-0x00000001841E1680
		private void sRvJQsBjiTFUByzdyQstlmxBwDlf(int param_00073d49, mRjzAKSnuWBoVcYwzfxaYuEXQlkL param_00073d4a, byte param_00073d4b, short param_00073d4c, double param_00073d4d); // 0x000000018ABCA180-0x000000018ABCA1D0
		private void jZXdYzCIqoxnremxPHcgdBfFRQAUB(int param_00073d4e, mRjzAKSnuWBoVcYwzfxaYuEXQlkL param_00073d4f, byte param_00073d50, short param_00073d51, double param_00073d52); // 0x000000018ABC9D9C-0x000000018ABC9DEC
		private void RXpoRKZgVUbOXfsxzIlYsKabWHbuA(); // 0x000000018ABC922C-0x000000018ABC9330
		public void Dispose(); // 0x000000018ABC8D7C-0x000000018ABC8DCC
		~SDL2InputSource(); // 0x000000018ABC8DCC-0x000000018ABC8E40
		protected virtual void Dispose(bool disposing); // 0x000000018ABC8D2C-0x000000018ABC8D7C
	}
}

namespace Rewired.Libraries.SharpDX.DirectInput
{
	internal enum DeviceType // TypeDefIndex: 53854
	{
		Device = 17,
		Mouse = 18,
		Keyboard = 19,
		Joystick = 20,
		Gamepad = 21,
		Driving = 22,
		Flight = 23,
		FirstPerson = 24,
		ControlDevice = 25,
		ScreenPointer = 26,
		Remote = 27,
		Supplemental = 28
	}
}

namespace Rewired.Libraries.SharpDX.RawInput
{
	internal enum KeyState // TypeDefIndex: 53790
	{
		VirtualKeyToItem = 46,
		SetHotKey = 50,
		GetHotKey = 51,
		KeyFirst = 256,
		KeyDown = 256,
		KeyUp = 257,
		SystemKeyDown = 260,
		SystemKeyUp = 261,
		KeyLast = 265,
		ImeKeyLast = 271,
		ImeKeyDown = 656,
		ImeKeyUp = 657,
		HotKey = 786
	}

	[Flags]
	internal enum ScanCodeFlags : short // TypeDefIndex: 53795
	{
		Make = 0,
		Break = 1,
		E0 = 2,
		E1 = 4
	}
}

namespace Rewired.Libraries.SharpDX.Windows.Forms
{
	[ComVisible(true)]
	internal enum Keys // TypeDefIndex: 53883
	{
		Modifiers = -65536,
		None = 0,
		LButton = 1,
		RButton = 2,
		Cancel = 3,
		MButton = 4,
		XButton1 = 5,
		XButton2 = 6,
		Back = 8,
		Tab = 9,
		LineFeed = 10,
		Clear = 12,
		Return = 13,
		Enter = 13,
		ShiftKey = 16,
		ControlKey = 17,
		Menu = 18,
		Pause = 19,
		Capital = 20,
		CapsLock = 20,
		KanaMode = 21,
		HanguelMode = 21,
		HangulMode = 21,
		JunjaMode = 23,
		FinalMode = 24,
		HanjaMode = 25,
		KanjiMode = 25,
		Escape = 27,
		IMEConvert = 28,
		IMENonconvert = 29,
		IMEAccept = 30,
		IMEAceept = 30,
		IMEModeChange = 31,
		Space = 32,
		Prior = 33,
		PageUp = 33,
		Next = 34,
		PageDown = 34,
		End = 35,
		Home = 36,
		Left = 37,
		Up = 38,
		Right = 39,
		Down = 40,
		Select = 41,
		Print = 42,
		Execute = 43,
		Snapshot = 44,
		PrintScreen = 44,
		Insert = 45,
		Delete = 46,
		Help = 47,
		D0 = 48,
		D1 = 49,
		D2 = 50,
		D3 = 51,
		D4 = 52,
		D5 = 53,
		D6 = 54,
		D7 = 55,
		D8 = 56,
		D9 = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LWin = 91,
		RWin = 92,
		Apps = 93,
		Sleep = 95,
		NumPad0 = 96,
		NumPad1 = 97,
		NumPad2 = 98,
		NumPad3 = 99,
		NumPad4 = 100,
		NumPad5 = 101,
		NumPad6 = 102,
		NumPad7 = 103,
		NumPad8 = 104,
		NumPad9 = 105,
		Multiply = 106,
		Add = 107,
		Separator = 108,
		Subtract = 109,
		Decimal = 110,
		Divide = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		NumLock = 144,
		Scroll = 145,
		LShiftKey = 160,
		RShiftKey = 161,
		LControlKey = 162,
		RControlKey = 163,
		LMenu = 164,
		RMenu = 165,
		BrowserBack = 166,
		BrowserForward = 167,
		BrowserRefresh = 168,
		BrowserStop = 169,
		BrowserSearch = 170,
		BrowserFavorites = 171,
		BrowserHome = 172,
		VolumeMute = 173,
		VolumeDown = 174,
		VolumeUp = 175,
		MediaNextTrack = 176,
		MediaPreviousTrack = 177,
		MediaStop = 178,
		MediaPlayPause = 179,
		LaunchMail = 180,
		SelectMedia = 181,
		LaunchApplication1 = 182,
		LaunchApplication2 = 183,
		OemSemicolon = 186,
		Oem1 = 186,
		Oemplus = 187,
		Oemcomma = 188,
		OemMinus = 189,
		OemPeriod = 190,
		OemQuestion = 191,
		Oem2 = 191,
		Oemtilde = 192,
		Oem3 = 192,
		OemOpenBrackets = 219,
		Oem4 = 219,
		OemPipe = 220,
		Oem5 = 220,
		OemCloseBrackets = 221,
		Oem6 = 221,
		OemQuotes = 222,
		Oem7 = 222,
		Oem8 = 223,
		OemBackslash = 226,
		Oem102 = 226,
		ProcessKey = 229,
		Packet = 231,
		Attn = 246,
		Crsel = 247,
		Exsel = 248,
		EraseEof = 249,
		Play = 250,
		Zoom = 251,
		NoName = 252,
		Pa1 = 253,
		OemClear = 254,
		KeyCode = 65535,
		Shift = 65536,
		Control = 131072,
		Alt = 262144
	}
}

namespace Rewired.Libraries.SharpDX.XInput
{
	internal enum DeviceType : byte // TypeDefIndex: 53774
	{
		Gamepad = 1
	}
}

namespace Rewired.Platforms.Microsoft.WindowsGamingInput
{
	[CustomObfuscation(rename = false)]
	internal enum WGIDeviceType // TypeDefIndex: 53599
	{
		None = 0,
		Gamepad = 1
	}

	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public sealed class WindowsGamingInputControllerExtension : Rewired.Controller.Extension, IHIDControllerExtension // TypeDefIndex: 53612
	{
		// Fields
		private XBtNrEbRzbSZpamjVidGdfjRSeJu AFwfRVfsGZFjMcRMdwIccXaDUMcGc; // 0x28
		private bool oMmQYEPtkGHEnpyuIjkfSCSefHbx; // 0x30
	
		// Properties
		public string productName { get; } // 0x000000018AB7E1DC-0x000000018AB7E294 
		string IHIDControllerExtension.manufacturer { get; } // 0x000000018AB7DE70-0x000000018AB7DEA8 
		public ushort vendorId { get; } // 0x000000018AB7E294-0x000000018AB7E33C 
		public ushort productId { get; } // 0x000000018AB7E138-0x000000018AB7E1DC 
		ushort IHIDControllerExtension.usagePage { get; } // 0x000000018AB7DEA8-0x000000018AB7DF74 
		ushort IHIDControllerExtension.usage { get; } // 0x000000018AB7DF74-0x000000018AB7E040 
	
		// Nested types
		private class XBtNrEbRzbSZpamjVidGdfjRSeJu : IControllerExtensionSource // TypeDefIndex: 53611
		{
			// Fields
			private eNfvpwLBlcLZrDwMSAAKYmquIOpc BfpiOvUxdZhCNWfSeVTpTeEyaaiP; // 0x10
	
			// Properties
			public eNfvpwLBlcLZrDwMSAAKYmquIOpc XYJbperUKfiSMXQUuxMvCcxQOWRH { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
			// Constructors
			public XBtNrEbRzbSZpamjVidGdfjRSeJu(eNfvpwLBlcLZrDwMSAAKYmquIOpc param_0007346a); // 0x00000001853908C0-0x00000001853908D0
		}
	
		// Constructors
		internal WindowsGamingInputControllerExtension(eNfvpwLBlcLZrDwMSAAKYmquIOpc param_00073466); // 0x000000018AB7E0C0-0x000000018AB7E138
		private WindowsGamingInputControllerExtension(WindowsGamingInputControllerExtension param_00073467); // 0x000000018AA6D1B8-0x000000018AA6D1C0
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x000000018AB7E0B0-0x000000018AB7E0C0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x000000018AB7E040-0x000000018AB7E0B0
		internal override Rewired.Controller.Extension Clone(); // 0x000000018AB7DE10-0x000000018AB7DE70
	}

	[Flags]
	internal enum GamepadButtons : uint // TypeDefIndex: 53618
	{
		None = 0,
		Menu = 1,
		View = 2,
		A = 4,
		B = 8,
		X = 16,
		Y = 32,
		DPadUp = 64,
		DPadDown = 128,
		DPadLeft = 256,
		DPadRight = 512,
		LeftShoulder = 1024,
		RightShoulder = 2048,
		LeftThumbstick = 4096,
		RightThumbstick = 8192
	}
}

namespace Rewired.Platforms.Windows.DirectInput
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public sealed class DirectInputControllerExtension : Rewired.Controller.Extension, IHIDControllerExtension // TypeDefIndex: 53741
	{
		// Fields
		private DXEgaekdXNroDGNlvMuTAwFqPKhEb AFwfRVfsGZFjMcRMdwIccXaDUMcGc; // 0x28
		private bool oMmQYEPtkGHEnpyuIjkfSCSefHbx; // 0x30
	
		// Properties
		public string productName { get; } // 0x000000018ABA4024-0x000000018ABA40EC 
		public ushort usagePage { get; } // 0x000000018ABA40EC-0x000000018ABA4194 
		public ushort usage { get; } // 0x000000018ABA4194-0x000000018ABA423C 
		public ushort productId { get; } // 0x000000018ABA3F70-0x000000018ABA4024 
		public ushort vendorId { get; } // 0x000000018ABA423C-0x000000018ABA42F0 
		string IHIDControllerExtension.manufacturer { get; } // 0x000000018ABA3E40-0x000000018ABA3E78 
	
		// Nested types
		private class DXEgaekdXNroDGNlvMuTAwFqPKhEb : IControllerExtensionSource // TypeDefIndex: 53740
		{
			// Fields
			private asJwVBrSeOWneGuTCmUUKaDTCXQW yvvvkHJqqCsfGZGsAuGggudVLGsk; // 0x10
			private NinxpESAdWHMScogYtzEcrOKmWSq BfpiOvUxdZhCNWfSeVTpTeEyaaiP; // 0x18
	
			// Properties
			public asJwVBrSeOWneGuTCmUUKaDTCXQW xzpxpHzCMniucFvRNnKzdwDjbwZm { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public NinxpESAdWHMScogYtzEcrOKmWSq XYJbperUKfiSMXQUuxMvCcxQOWRH { get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			public DXEgaekdXNroDGNlvMuTAwFqPKhEb(asJwVBrSeOWneGuTCmUUKaDTCXQW param_00073853, NinxpESAdWHMScogYtzEcrOKmWSq param_00073854); // 0x00000001832AF420-0x00000001832AF450
		}
	
		// Constructors
		internal DirectInputControllerExtension(asJwVBrSeOWneGuTCmUUKaDTCXQW param_0007384e, NinxpESAdWHMScogYtzEcrOKmWSq param_0007384f); // 0x000000018ABA3EE8-0x000000018ABA3F70
		private DirectInputControllerExtension(DirectInputControllerExtension param_00073850); // 0x000000018AA6D1B8-0x000000018AA6D1C0
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x000000018AB7E0B0-0x000000018AB7E0C0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x000000018ABA3E78-0x000000018ABA3EE8
		internal override Rewired.Controller.Extension Clone(); // 0x000000018ABA3DE0-0x000000018ABA3E40
	}
}

namespace Rewired.Platforms.Windows.RawInput
{
	internal enum DeviceType // TypeDefIndex: 53701
	{
		Joystick = 0,
		Gamepad = 1,
		Keyboard = 2,
		Mouse = 3,
		MultiAxisController = 4,
		Unknown = 5
	}

	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public sealed class RawInputControllerExtension : Rewired.Controller.Extension, IHIDControllerExtension // TypeDefIndex: 53717
	{
		// Fields
		private wCjZrmUUUzubrddAwdvTcgSeNgNM AFwfRVfsGZFjMcRMdwIccXaDUMcGc; // 0x28
		private bool oMmQYEPtkGHEnpyuIjkfSCSefHbx; // 0x30
	
		// Properties
		public string productName { get; } // 0x000000018AB9CDD8-0x000000018AB9CE90 
		public string manufacturer { get; } // 0x000000018AB9CC44-0x000000018AB9CD34 
		public ushort vendorId { get; } // 0x000000018AB9D000-0x000000018AB9D0A4 
		public ushort productId { get; } // 0x000000018AB9CD34-0x000000018AB9CDD8 
		public ushort usagePage { get; } // 0x000000018AB9CE90-0x000000018AB9CF48 
		public ushort usage { get; } // 0x000000018AB9CF48-0x000000018AB9D000 
	
		// Nested types
		private class wCjZrmUUUzubrddAwdvTcgSeNgNM : IControllerExtensionSource // TypeDefIndex: 53716
		{
			// Fields
			private kRbZYuhpKzSxbqUHMGxBcrQvRuQg BfpiOvUxdZhCNWfSeVTpTeEyaaiP; // 0x10
	
			// Properties
			public kRbZYuhpKzSxbqUHMGxBcrQvRuQg XYJbperUKfiSMXQUuxMvCcxQOWRH { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
			// Constructors
			public wCjZrmUUUzubrddAwdvTcgSeNgNM(kRbZYuhpKzSxbqUHMGxBcrQvRuQg param_000737a1); // 0x00000001853908C0-0x00000001853908D0
		}
	
		// Constructors
		internal RawInputControllerExtension(kRbZYuhpKzSxbqUHMGxBcrQvRuQg param_0007379d); // 0x000000018AB9CBCC-0x000000018AB9CC44
		private RawInputControllerExtension(RawInputControllerExtension param_0007379e); // 0x000000018AA6D1B8-0x000000018AA6D1C0
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x000000018AB7E0B0-0x000000018AB7E0C0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x000000018AB9CB5C-0x000000018AB9CBCC
		internal override Rewired.Controller.Extension Clone(); // 0x000000018AB9CAFC-0x000000018AB9CB5C
	}
}

namespace Rewired.Platforms.Windows.XInput
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public sealed class XInputControllerExtension : Rewired.Controller.Extension // TypeDefIndex: 53694
	{
		// Fields
		private rvSmxamcvlhwQuczrUXGIxseZMV AFwfRVfsGZFjMcRMdwIccXaDUMcGc; // 0x28
		private bool oMmQYEPtkGHEnpyuIjkfSCSefHbx; // 0x30
	
		// Nested types
		private class rvSmxamcvlhwQuczrUXGIxseZMV : IControllerExtensionSource // TypeDefIndex: 53693
		{
			// Fields
			private rBZGQBZwTiSiuHITZSaJgTFuMivb.glrnucEUzNoToJLBWReJKJsCbnHKA BfpiOvUxdZhCNWfSeVTpTeEyaaiP; // 0x10
	
			// Constructors
			public rvSmxamcvlhwQuczrUXGIxseZMV(rBZGQBZwTiSiuHITZSaJgTFuMivb.glrnucEUzNoToJLBWReJKJsCbnHKA param_000736ed); // 0x00000001853908C0-0x00000001853908D0
		}
	
		// Constructors
		internal XInputControllerExtension(rBZGQBZwTiSiuHITZSaJgTFuMivb.glrnucEUzNoToJLBWReJKJsCbnHKA param_000736e9); // 0x0000000183A42690-0x0000000183A42700
		private XInputControllerExtension(XInputControllerExtension param_000736ea); // 0x000000018AA6D1B8-0x000000018AA6D1C0
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x000000018AB7E0B0-0x000000018AB7E0C0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x0000000184A3D480-0x0000000184A3D500
		internal override Rewired.Controller.Extension Clone(); // 0x000000018AB9D388-0x000000018AB9D3E8
	}
}

namespace Rewired.Utils.Platforms.Windows
{
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class Main // TypeDefIndex: 53747
	{
		// Methods
		public static object GetPlatformInitializer(); // 0x000000018539494C-0x0000000185394954
	}
}
