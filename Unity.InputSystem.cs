/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.HID;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Switch.LowLevel;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.XInput.LowLevel;
using UnityEngine.InputSystem.XR;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngineInternal.Input;

// Image 11: Unity.InputSystem.dll - Assembly: Unity.InputSystem, Version=1.14.0.0, Culture=neutral, PublicKeyToken=null - Types 47346-47992
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.InputSystem.Tests")]
[assembly: InternalsVisibleTo("Unity.InputSystem.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.InputSystem.TestFramework")]
[assembly: InternalsVisibleTo("Unity.InputSystem.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.InputSystem.ForUI")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class UISupport // TypeDefIndex: 47347
{
	// Methods
	public static void Initialize(); // 0x0000000183DF6FF0-0x0000000183DF7060
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 47992
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_262 _1D0F855A98F398E261D1E4C657C33BD47F11A47FD9CF90F160D467BC8C7FEBE3; // 0x00 // Static value (base64): AAAAAAEAAgADAAQABQAGAAcACAAJAAoACwAMAA0ADgAPABAAEQASABMAFAAVABYAFwAYABkAGgAbABwAHQAeAB8AIAAhACIAIwAkACUAJgAnACgAKQAqACsALAAtAC4ALwAwADEAMgAzADQANQA2ADcAOAA5ADoAOgA7ADwAPQA9AD4APwBAAEAAQQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBXAFgAWQBaAFsAXABdAF4AXwBgAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegB7AHwAfQB+AA== - Metadata: 0x0232A934
	internal static readonly __StaticArrayInitTypeSize_508 _1E9B4B805C18CBD7D7326E392008A12FBD20465C53E9C60AEBEA427165641632; // 0x106 // Static value (base64): AgQIAADsCQADBBAABAQYAAUEIAAGBCgABwQwAAgEOAAJBEAACgRIAAsEUAAMBFgADQRgAA4EaAAPBHAAFAR4ABUEgAAWBIgAFwSQABgEmAAZBKAAGgSoABsEsAAcBLgAHQTAAB4EyAAfBNAAIATYACEE4AAiBOgAIwTwACQE+AAlBAABJgQIAScEEAEoBBgBKQQgASoEKAErBDABLAQ4AS0EQAEuBEgBLwRQATAEWAExBGABMgRoATMEcAE0BHgBNQSAATYEiAE3BJABOASYAToImAE5BKABOwSoAT0IqAE8BLABPgS4AUAIuAE/BMABQQTIAUIE0AFDBNgBAQTgARIE6AETBPABEAT4AREEAAJEBAgCRQQQAkYEGAJHBCACSAQoAkkEMAJKBDgCSwRAAkwESAJNBFACTgRYAk8EYAJQBGgCUQRwAlIEeAJTBIACVASIAlUEkAJWBJgCYASgAlcEqAJYBLACWQS4AloEwAJbBMgCXATQAl0E2AJeBOACXwToAmEE8AJiBPgCYwQAA2QECANlBBADZgQYA2cEIANoBCgDaQQwA2oEOANrBEADbARIA20EUANuBFgDbwRgA3AEaANxBHADcgSAA3MEiAN0BJADdQSYA3YEoAN3BKgDeASwA3kEuAN6BMADewTIA3wE0AN9BNgDfgT4Aw== - Metadata: 0x0232AA3C
	internal static readonly __StaticArrayInitTypeSize_976 _286DD866DF46AD63DA3C6198BE2F9CDB96A5223055FDC3E0287B7CCA9F45AFB4; // 0x302 // Static value (base64): EYAAAB6AAAEqgAABH4AAAiuAAAIigAADI4AAAySAAAMugAADL4AAAzCAAAMggAAEIYAABCWAAAQsgAAELYAABDGAAAQDgAAFFIAABSaAAAYygAAGJ4AABzOAAAcFIAAIFiAACBcgAAgYIEAIBiCACBkggAgaBMAIGwTgCBwAAQoogAAMKYAADTSAAA5BgAAPQoAAEEWAABFGgAARR4AAEUOAABJEgAASSIAAEjeAABNJgAAUSoAAFTkgABY6IAAWOyBAFjwggBY9BMAWPgTgFj8AARhLgAAaTIAAG02AABxagAAdW4AAHl6AAB9fgAAfYIAAH1yAACBdgAAgYYAAIFCAACFigAAiY4AAI1IgACRTIAAkVCBAJFUggCRWBMAkVwTgJFgAASZkgAAoZYAAKWaAACpzgAArdIAALHeAAC14gAAteYAALXWAAC52gAAueoAALmmAAC97gAAwfIAAMWsgADJsIAAybSBAMm4ggDJvBMAycATgMnEAATR9gAA2foAAN3+AADiMgAA5jYAAOpCAADuRgAA7koAAO46AADyPgAA8k4AAPIKAAD2UgAA+lYAAP4QgAECFIABAhiBAQIcggECIBMBAiQTgQIoAAUKWgABEl4AARZiAAEalgABHpoAASKmAAEmqgABJq4AASaeAAEqogABKrIAASpuAAEutgABMroAATZ0gAE6eIABOnyBATqAggE6hBMBOogTgTqMAAVCvgABSsIAAU7GAAFS+gABVv4AAVsKAAFfDgABXxIAAV8CAAFjBgABYxYAAWLSAAFnGgABax4AAW7YgAFy3IABcuCBAXLkggFy6BMBcuwTgXLwAAV7IgABgyYAAYcqAAGLXgABj2IAAZNuAAGXcgABl3YAAZdmAAGbagABm3oAAZs2AAGffgABo4IAAac8gAGrQIABq0SBAatIggGrTBMBq1ATgatUAAWzhgABu4oAAb+OAAHDwgABx8YAAcvSAAHP1gABz9oAAc/KAAHTzgAB094AAdOaAAHX4gAB2+YAAd+ggAHjpIAB46iBAeOsggHjsBMB47QTgeO4AAXr6gAB8+4AAffyAAH4JgQB/CoEAgA2BAIEOgQCBD4EAgQuBAIIMgQCCEIEAgv+AAIMRgQCEEoEAhQEhAIYCIQCGAyFAhgQhgIYFBcCGBgXghgcBAYgTgQCKFIEAixWBAIwigQCNI4EAjiaBAI8ngQCPKIEAjySBAJAlgQCQKYEAkBiBAJEqgQCSK4EAkxohAJQbIQCUHCFAlB0hgJQeBcCUHwXglCABAZYsgQCYLYEAmQ== - Metadata: 0x0232AC3C
	internal static readonly __StaticArrayInitTypeSize_20 _7BD1B2B340030CA32C0F7873A8B4949D42124F6206A455BA2860B27C103E8261; // 0x6D2 // Static value (base64): AQAAAAIAAAADAAAAAgAAAAQAAAA= - Metadata: 0x0232B014
	internal static readonly __StaticArrayInitTypeSize_371 BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B; // 0x6E6 // Static value (base64): hwEBAAAAAMQAAwAAAACHARcAAAAAgAAFAAAAAMQACwAAAABAAAcAAAABgAAJAAMAASAA//8BAAFAAP//AgABYAD//wcAA4AA//8EAAPBAA0AAAAAxAATAAAAAKEADwAKAATBABEADgAEkQD//xIAA6EA//8VAAPAAP//AAAAwQD//xgAAsMAFQAAAADEAP//HAABwgD//xoAAcMA//8bAAEgARkAAAAAhwEpAAAAAPAAGwAAAAAgAScAAAAA4AAdAAAAAPAA//8pAAHSAB8AJwAB4AD//ygAAcsAIQAAAADSAP//AAAAyAAjAAAAAMsA//8AAADGACUAAAAAyAD//wAAAMUA//8dAAHGAP//AAAACAH//x4AASAB//8fAAGAASsAAAAAhwEvAAAAAFAB//8gAAKAAS0AIgACaAH//yQAAYAB//8lAAGEATEAAAAAhwH//wAAAIIBMwAAAACEAf//AAAAgQH//yYAAYIB//8AAAA= - Metadata: 0x0232B02C
	internal static readonly __StaticArrayInitTypeSize_3983 CB22D97D4BE9F7A4259E5E355F9F66F2C2D11559A9EA0634CFF23EAA93DA62AE; // 0x859 // Static value (base64): PxMBAAAAAMAIAwAAAAA/EwEBAAAAgAMFAAAAAMAIZwAAAADAAQcAAAABgAM1AEQAAcAACQAAAADAARUAAAAAYAALAAAAAMAADwAAAAAgAP//AQABYAANAAIAAkAA//8EAAJgAP//BgACkAARAAgACMAAEwAQAAh4AP//GAAGkAD//x4ABqgA//8kAALAAP//JgACHQEXAAAAAMABLwAAAAAIARkAAAAAHQEjAAAAAOQAGwAoAAQIAR0ALAAE0gD//zAAAuQA//8yAAL2AP//AAAACAEfAAAAAP8A//8AAAAIASEAAAAABAH//zQAAwgB//83AAMYASUAAAAAHQEnAAAAABAB//86AAEYAf//OwACGwEpAAAAAB0BLQAAAAAaASsAAAAAGwH//wAAABkB//89AAEaAf//AAAAHAH//wAAAB0B//8+AAGAATEAAAAAwAEzAEEAAU8B//8/AAGAAf//QAABoAH//0IAAcAB//9DAAGgAjcAXAABgANHAF0AATACOQBNAASgAkEAUQAE+AE7AEcAAjACPQBJAALcAf//RQAB+AH//0YAASACPwAAAAAwAv//AAAADAL//0sAASAC//9MAAFgAkMAAAAAoAJFAAAAAEgC//9VAANgAv//WAADgAL//1sAAaAC//9eAAEQA0kAaQABgANjAGoAAdgCSwAAAAAQA1MAAAAAvAL//18AAdgCTQBgAAHIAk8AAAAA2AJRAAAAAMIC//9hAALIAv//YwAC0AL//2UAAdgC//9mAAH0AlUAAAAAEAP//wAAAOYCVwAAAAD0Av//AAAA3wJZAAAAAOYC//8AAADcAlsAAAAA3wJfAAAAANoCXQAAAADcAv//AAAA2QL//2cAAdoC//8AAADeAmEAAAAA3wL//wAAAN0C//9oAAHeAv//AAAASAP//2sAAoADZQBtAAJkA///bwABgAP//3AAAQAHaQAAAADACM8AywABQAVrAHEAAQAHnQCeAAFgBG0AiQABQAV9AIoAAfADbwB6AARgBHcAfgAEuANxAHQAAvADcwB2AAKcA///cgABuAP//3MAAeADdQAAAADwA///AAAAzAP//3gAAeAD//95AAEgBHkAAAAAYAR7AAAAAAgE//+CAAMgBP//hQADQAT//4gAAWAE//+LAAHQBH8AlgABQAWZAJcAAZgEgQAAAADQBIkAAAAAfAT//4wAAZgEgwCNAAGIBIUAAAAAmASHAAAAAIIE//+OAAKIBP//kAACkAT//5IAAZgE//+TAAG0BIsAAAAA0AT//wAAAKYEjQAAAAC0BP//AAAAnwSPAAAAAKYE//8AAACcBJEAAAAAnwSVAAAAAJoEkwAAAACcBP//AAAAmQT//5QAAZoE//8AAACeBJcAAAAAnwT//wAAAJ0E//+VAAGeBP//AAAACAX//5gAAkAFmwCaAAIkBf//nAABQAX//50AASAGnwC2AAEAB68AtwABsAWhAKcABCAGqQCrAAR4BaMAoQACsAWlAKMAAlwF//+fAAF4Bf//oAABoAWnAAAAALAF//8AAACMBf//pQABoAX//6YAAeAFqwAAAAAgBq0AAAAAyAX//68AA+AF//+yAAMABv//tQABIAb//7gAAZAGsQDDAAEAB8sAxAABWAazAAAAAJAGuwAAAAA8Bv//uQABWAa1ALoAAUgGtwAAAABYBrkAAAAAQgb//7sAAkgG//+9AAJQBv//vwABWAb//8AAAXQGvQAAAACQBv//AAAAZga/AAAAAHQG//8AAABfBsEAAAAAZgb//wAAAFwGwwAAAABfBscAAAAAWgbFAAAAAFwG//8AAABZBv//wQABWgb//wAAAF4GyQAAAABfBv//AAAAXQb//8IAAV4G//8AAADIBv//xQACAAfNAMcAAuQG///JAAEAB///ygAB4AfRAOMAAcAI4QDkAAFwB9MA1AAE4AfbANgABDgH1QDOAAJwB9cA0AACHAf//8wAATgH///NAAFgB9kAAAAAcAf//wAAAEwH///SAAFgB///0wABoAfdAAAAAOAH3wAAAACIB///3AADoAf//98AA8AH///iAAHgB///5QABUAjjAPAAAcAI/QDxAAEYCOUAAAAAUAjtAAAAAPwH///mAAEYCOcA5wABCAjpAAAAABgI6wAAAAACCP//6AACCAj//+oAAhAI///sAAEYCP//7QABNAjvAAAAAFAI//8AAAAmCPEAAAAANAj//wAAAB8I8wAAAAAmCP//AAAAHAj1AAAAAB8I+QAAAAAaCPcAAAAAHAj//wAAABkI///uAAEaCP//AAAAHgj7AAAAAB8I//8AAAAdCP//7wABHgj//wAAAIgI///yAALACP8A9AACpAj///YAAcAI///3AAEADgMBAAAAPxOdAQAAAEAMBQEAAAAADmsBUgEBgAoHAfgAAUAMOQElAQGgCQkBEAEBgAoZAREBATAJCwEBAQSgCRMBBQEE+AgNAfsAAjAJDwH9AALcCP//+QAB+Aj///oAASAJEQEAAAAwCf//AAAADAn///8AASAJ//8AAQFgCRUBAAAAoAkXAQAAAEgJ//8JAQNgCf//DAEDgAn//w8BAaAJ//8SAQEQChsBHQEBgAo1AR4BAdgJHQEAAAAQCiUBAAAAvAn//xMBAdgJHwEUAQHICSEBAAAA2AkjAQAAAMIJ//8VAQLICf//FwEC0An//xkBAdgJ//8aAQH0CScBAAAAEAr//wAAAOYJKQEAAAD0Cf//AAAA3wkrAQAAAOYJ//8AAADcCS0BAAAA3wkxAQAAANoJLwEAAADcCf//AAAA2Qn//xsBAdoJ//8AAADeCTMBAAAA3wn//wAAAN0J//8cAQHeCf//AAAASAr//x8BAoAKNwEhAQJkCv//IwEBgAr//yQBAWALOwE9AQFADEsBPgEB8Ao9AS4BBGALRQEyAQS4Cj8BKAEC8ApBASoBApwK//8mAQG4Cv//JwEB4ApDAQAAAPAK//8AAADMCv//LAEB4Ar//y0BASALRwEAAABgC0kBAAAACAv//zYBAyAL//85AQNAC///PAEBYAv//z8BAdALTQFKAQFADGcBSwEBmAtPAQAAANALVwEAAAB8C///QAEBmAtRAUEBAYgLUwEAAACYC1UBAAAAggv//0IBAogL//9EAQKQC///RgEBmAv//0cBAbQLWQEAAADQC///AAAApgtbAQAAALQL//8AAACfC10BAAAApgv//wAAAJwLXwEAAACfC2MBAAAAmgthAQAAAJwL//8AAACZC///SAEBmgv//wAAAJ4LZQEAAACfC///AAAAnQv//0kBAZ4L//8AAAAIDP//TAECQAxpAU4BAiQM//9QAQFADP//UQEBIA1tAWoBAQAOfQFrAQGwDG8BWwEEIA13AV8BBHgMcQFVAQKwDHMBVwECXAz//1MBAXgM//9UAQGgDHUBAAAAsAz//wAAAIwM//9ZAQGgDP//WgEB4Ax5AQAAACANewEAAADIDP//YwED4Az//2YBAwAN//9pAQEgDf//bAEBkA1/AXcBAQAOmQF4AQFYDYEBAAAAkA2JAQAAADwN//9tAQFYDYMBbgEBSA2FAQAAAFgNhwEAAABCDf//bwECSA3//3EBAlAN//9zAQFYDf//dAEBdA2LAQAAAJAN//8AAABmDY0BAAAAdA3//wAAAF8NjwEAAABmDf//AAAAXA2RAQAAAF8NlQEAAABaDZMBAAAAXA3//wAAAFkN//91AQFaDf//AAAAXg2XAQAAAF8N//8AAABdDf//dgEBXg3//wAAAMgN//95AQIADpsBewEC5A3//30BAQAO//9+AQGAEZ8BAAAAPxMFAgAAAMAPoQF/AQGAEdMBrAEB4A6jAZcBAcAPswGYAQFwDqUBiAEE4A6tAYwBBDgOpwGCAQJwDqkBhAECHA7//4ABATgO//+BAQFgDqsBAAAAcA7//wAAAEwO//+GAQFgDv//hwEBoA6vAQAAAOAOsQEAAACIDv//kAEDoA7//5MBA8AO//+WAQHgDv//mQEBUA+1AaQBAcAPzwGlAQEYD7cBAAAAUA+/AQAAAPwO//+aAQEYD7kBmwEBCA+7AQAAABgPvQEAAAACD///nAECCA///54BAhAP//+gAQEYD///oQEBNA/BAQAAAFAP//8AAAAmD8MBAAAANA///wAAAB8PxQEAAAAmD///AAAAHA/HAQAAAB8PywEAAAAaD8kBAAAAHA///wAAABkP//+iAQEaD///AAAAHg/NAQAAAB8P//8AAAAdD///owEBHg///wAAAIgP//+mAQLAD9EBqAECpA///6oBAcAP//+rAQGgENUBxAEBgBHlAcUBATAQ1wG1AQSgEN8BuQEE+A/ZAa8BAjAQ2wGxAQLcD///rQEB+A///64BASAQ3QEAAAAwEP//AAAADBD//7MBASAQ//+0AQFgEOEBAAAAoBDjAQAAAEgQ//+9AQNgEP//wAEDgBD//8MBAaAQ///GAQEQEecB0QEBgBEBAtIBAdgQ6QEAAAAQEfEBAAAAvBD//8cBAdgQ6wHIAQHIEO0BAAAA2BDvAQAAAMIQ///JAQLIEP//ywEC0BD//80BAdgQ///OAQH0EPMBAAAAEBH//wAAAOYQ9QEAAAD0EP//AAAA3xD3AQAAAOYQ//8AAADcEPkBAAAA3xD9AQAAANoQ+wEAAADcEP//AAAA2RD//88BAdoQ//8AAADeEP8BAAAA3xD//wAAAN0Q///QAQHeEP//AAAASBH//9MBAoARAwLVAQJkEf//1wEBgBH//9gBAWASBwLZAQI/ExcC2wEC8BEJAuUBBGASEQLpAQS4EQsC3wEC8BENAuEBApwR///dAQG4Ef//3gEB4BEPAgAAAPAR//8AAADMEf//4wEB4BH//+QBASASEwIAAABgEhUCAAAACBL//+0BAyAS///wAQNAEv//8wEBYBL///QBAdASGQL/AQE/EzMCAAIBmBIbAgAAANASIwIAAAB8Ev//9QEBmBIdAvYBAYgSHwIAAACYEiECAAAAghL///cBAogS///5AQKQEv//+wEBmBL///wBAbQSJQIAAADQEv//AAAAphInAgAAALQS//8AAACfEikCAAAAphL//wAAAJwSKwIAAACfEi8CAAAAmhItAgAAAJwS//8AAACZEv///QEBmhL//wAAAJ4SMQIAAACfEv//AAAAnRL///4BAZ4S//8AAAAAE///AAAAPxM1AgAAACAT//8BAgI/EzcCAwIBMBP//wQCAT8T//8FAgE= - Metadata: 0x0232B1A4
	internal static readonly __StaticArrayInitTypeSize_1036 D4ADEDA8D4E42C7133AFF7B673F4893FEA7C6A101764B0179449453A7E7F516F; // 0x17E8 // Static value (base64): AAARABIAAQAeACoAHwArABMAIAAhACUAAgAsAC0AMQATACAAIQAlAAIALAAtADEAIgAjACQALgAvADAAIgAjACQALgAvADAAFAADABQAAwAVACcABAAzABUAJwAEADMAJgAyACYAMgAWABcABQAWABcABQAYABkABgAaABsAHAAcAB0AKAApAAcANAA0ADUAQQA1AEEAQgBCADYARQBGAEcANgBFAEYARwBDAEQASABDAEQASAA3ADgAOABJAEoASgA5ADoAOQA6ADsAPAA9AD4APwA/AEAASwBAAEsATABMAAgATQBNAE4AWgBOAFoAWwBbAE8AXgBfAGAATwBeAF8AYABcAF0AYQBcAF0AYQBQAFEAUQBiAGMAYwBSAFMAUgBTAFQAVQBWAFcAWABYAFkAZABZAGQAZQBlAAkAZgBmAGcAcwBnAHMAdAB0AGgAdwB4AHkAaAB3AHgAeQB1AHYAegB1AHYAegBpAGoAagB7AHwAfABrAGwAawBsAG0AbgBvAHAAcQBxAHIAfQByAH0AfgB+AAoAfwB/AIAAjACAAIwAjQCNAIEAkACRAJIAgQCQAJEAkgCOAI8AkwCOAI8AkwCCAIMAgwCUAJUAlQCEAIUAhACFAIYAhwCIAIkAigCKAIsAlgCLAJYAlwCXAAsAmACYAJkApQCZAKUApgCmAJoAqQCqAKsAmgCpAKoAqwCnAKgArACnAKgArACbAJwAnACtAK4ArgCdAJ4AnQCeAJ8AoAChAKIAowCjAKQArwCkAK8AsACwAAwAsQCxALIAvgCyAL4AvwC/ALMAwgDDAMQAswDCAMMAxADAAMEAxQDAAMEAxQC0ALUAtQDGAMcAxwC2ALcAtgC3ALgAuQC6ALsAvAC8AL0AyAC9AMgAyQDJAA0AygDKAMsA1wDLANcA2ADYAMwA2wDcAN0AzADbANwA3QDZANoA3gDZANoA3gDNAM4AzgDfAOAA4ADPANAAzwDQANEA0gDTANQA1QDVANYA4QDWAOEA4gDiAA4A4wDjAOQA8ADkAPAA8QDxAOUA9AD1APYA5QD0APUA9gDyAPMA9wDyAPMA9wDmAOcA5wD4APkA+QDoAOkA6ADpAOoA6wDsAO0A7gDuAO8A+gDvAPoA+wD7AA8A/AD8AP0ACQH9AAkBCgEKAf4ADQEOAQ8B/gANAQ4BDwELAQwBEAELAQwBEAH/AAABAAERARIBEgEBAQIBAQECAQMBBAEFAQYBBwEHAQgBEwEIARMBFAEUARAAGQEQABkBFQEVARYBIgEWASIBIwEjARcBJgEnASgBFwEmAScBKAEkASUBKQEkASUBKQEYASoBKwErARoBGwEaARsBHAEdAR4BHwEgASABIQEsASEBLQEtAQ== - Metadata: 0x0232C134
	internal static readonly __StaticArrayInitTypeSize_84 D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A; // 0x1BF4 // Static value (base64): AAAOAA8AAQAQABEAFQASABMAFAACABYAFwAbAAIAFgAXABsAGAAZABoAGAAZABoAAwAEAAUABgAHAAgACQAJAAoAHAAKABwAHQAdAAsADAAMAA0A - Metadata: 0x0232C544
	internal static readonly __StaticArrayInitTypeSize_1799 E90C194F8229C7E8552701BC1D1F1BD2537F77555B9151B4B09FF9D1BA956FE6; // 0x1C48 // Static value (base64): fwABAAAAAEAAAwAAAAF/ADEAAQABIAAPAAAAAEAABQAAAAAwAFsAAAAAQAAHAAAAADgAeQBDAAFAAAkARAABPACHAAAAAEAACwAAAAA+AA0AAAAAQAAvAAAAAD0A//8CAAE+AP//EwABEAARAAAAACAAPQAAAAAIABMAAAAAEAAhAAAAAAQAFQAAAAAIABsAAAAAAgAXAAAAAAQAGQAAAAABAP//AAAAAgD//wMAAQMA//8EAAEEAP//BQABBgAdAAAAAAgAHwAAAAAFAP//BgABBgD//wcAAQcA//8IAAEIAP//CQABDAAjAAAAABAAKQAAAAAKACUAAAAADAAnAAAAAAkA//8KAAEKAP//CwABCwD//wwAAQwA//8NAAEOACsAAAAAEAAtAAAAAA0A//8OAAEOAP//DwABDwD//xAAARAA//8VAAE/AP//FAABQAD//xEAAWAAMwAAAAB/AMEAAAAAUAA1AAAAAGAAowAAAABIADcAAAAAUACVAAAAAEQAOQAAAABIAI8AAAAAQgA7AAAAAEQAjQAAAABBAP//EgABQgD//0gAARgAPwAAAAAgAE0AAAAAFABBAAAAABgARwAAAAASAEMAAAAAFABFAAAAABEA//8WAAESAP//FwABEwD//xgAARQA//8ZAAEWAEkAAAAAGABLAAAAABUA//8aAAEWAP//GwABFwD//xwAARgA//8dAAEcAE8AAAAAIABVAAAAABoAUQAAAAAcAFMAAAAAGQD//x4AARoA//8fAAEbAP//IAABHAD//yEAAR4AVwAAAAAgAFkAAAAAHQD//yIAAR4A//8jAAEfAP//JAABIAD//yUAASgAXQAAAAAwAGsAAAAAJABfAAAAACgAZQAAAAAiAGEAAAAAJABjAAAAACEA//8mAAEiAP//JwABIwD//ygAASQA//8pAAEmAGcAAAAAKABpAAAAACUA//8qAAEmAP//KwABJwD//ywAASgA//8tAAEsAG0AAAAAMABzAAAAACoAbwAAAAAsAHEAAAAAKQD//y4AASoA//8vAAErAP//MAABLAD//zEAAS4AdQAAAAAwAHcAAAAALQD//zIAAS4A//8zAAEvAP//NAABMAD//zUAATQAewA7AAE4AIEAPAABMgB9AAAAADQAfwAAAAAxAP//NgABMgD//zcAATMA//84AAE0AP//OQABNgCDAD8AATgAhQBAAAE1AP//OgABNgD//z0AATcA//8+AAE4AP//QQABOgCJAAAAADwAiwAAAAA5AP//QgABOgD//0UAATsA//9GAAE8AP//RwABQwD//0kAAUQA//9KAAFGAJEAAAAASACTAAAAAEUA//9LAAFGAP//TAABRwD//00AAUgA//9OAAFMAJcAAAAAUACdAAAAAEoAmQAAAABMAJsAAAAASQD//08AAUoA//9QAAFLAP//UQABTAD//1IAAU4AnwAAAABQAKEAAAAATQD//1MAAU4A//9UAAFPAP//VQABUAD//1YAAVgApQAAAABgALMAAAAAVACnAAAAAFgArQAAAABSAKkAAAAAVACrAAAAAFEA//9XAAFSAP//WAABUwD//1kAAVQA//9aAAFWAK8AAAAAWACxAAAAAFUA//9kAAFWAP//WwABVwD//1wAAVgA//9dAAFcALUAAAAAYAC7AAAAAFoAtwAAAABcALkAAAAAWQD//14AAVoA//9fAAFbAP//YAABXAD//2EAAV4AvQAAAABgAL8AAAAAXQD//2IAAV4A//9jAAFfAP//ZQABYAD//2YAAW8AwwAAAAB/AN8AAAAAaADFAAAAAG8A0wAAAABkAMcAAAAAaADNAAAAAGIAyQAAAABkAMsAAAAAYQD//2cAAWIA//9oAAFjAP//aQABZAD//2oAAWYAzwAAAABoANEAAAAAZQD//2sAAWYA//9sAAFnAP//bQABaAD//24AAWwA1QAAAABvANsAAAAAagDXAAAAAGwA2QAAAABpAP//bwABagD//3AAAWsA//9xAAFsAP//cgABbgDdAAAAAG8A//91AAFtAP//cwABbgD//3QAAXcA4QAAAAB/AO8AAAAAcwDjAAAAAHcA6QAAAABxAOUAAAAAcwDnAAAAAHAA//8AAABxAP//dgABcgD//3cAAXMA//94AAF1AOsAAAAAdwDtAAAAAHQA//95AAF1AP//egABdgD//3sAAXcA//98AAF7APEAAAAAfwD3AAAAAHkA8wAAAAB7APUAAAAAeAD//30AAXkA//9+AAF6AP//fwABewD//4AAAX0A+QAAAAB/APsAAAAAfAD//4EAAX0A//8AAAB+AP//AAAAfwD9AAAAAH8A//8AAAB/AP8AAAAAgAD//4IAAX8A//8AAAA= - Metadata: 0x0232C59C
	internal static readonly __StaticArrayInitTypeSize_24 EEAB0A49E323B940CB01CCD3E80D47F1566617F04466CD5D6190ACDBC495CB2A; // 0x234F // Static value (base64): AQAAAAIAAAAFAAAABgAAAAUAAAAFAAAA - Metadata: 0x0232CCA4
	internal static readonly __StaticArrayInitTypeSize_104 FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5; // 0x2367 // Static value (base64): DoAAAA+AAAESgAACE4AAAhSAAAIQgAADEYAAAxWAAAMYgAAEGYAABBqAAAQWgAAFF4AABRuAAAUDBAAGBAQABgUECAYGBBAGBwQYBggEIAYMQIAGDUAABwmAAAgcgAAKHYAACwsEAAw= - Metadata: 0x0232CCC4

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 47981
	{
	}

	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 47982
	{
	}

	private struct __StaticArrayInitTypeSize_84 // TypeDefIndex: 47983
	{
	}

	private struct __StaticArrayInitTypeSize_104 // TypeDefIndex: 47984
	{
	}

	private struct __StaticArrayInitTypeSize_262 // TypeDefIndex: 47985
	{
	}

	private struct __StaticArrayInitTypeSize_371 // TypeDefIndex: 47986
	{
	}

	private struct __StaticArrayInitTypeSize_508 // TypeDefIndex: 47987
	{
	}

	private struct __StaticArrayInitTypeSize_976 // TypeDefIndex: 47988
	{
	}

	private struct __StaticArrayInitTypeSize_1036 // TypeDefIndex: 47989
	{
	}

	private struct __StaticArrayInitTypeSize_1799 // TypeDefIndex: 47990
	{
	}

	private struct __StaticArrayInitTypeSize_3983 // TypeDefIndex: 47991
	{
	}
}

namespace Unity.XR.GoogleVr
{
	[InputControlLayout(displayName = "Daydream Headset", hideInUI = true)]
	public class DaydreamHMD : XRHMD // TypeDefIndex: 47361
	{
		// Constructors
		public DaydreamHMD(); // 0x00000001853971D4-0x00000001853971DC
	}

	[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class DaydreamController : XRController // TypeDefIndex: 47362
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _volumeUp_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private ButtonControl _recentered_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _volumeDown_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _recentering_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _app_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _home_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x200
	
		// Properties
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl]
		public ButtonControl volumeUp { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl]
		public ButtonControl recentered { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl]
		public ButtonControl volumeDown { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl]
		public ButtonControl recentering { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl]
		public ButtonControl app { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl]
		public ButtonControl home { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
	
		// Constructors
		public DaydreamController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B198640-0x000000018B1988D8
	}
}

namespace Unity.XR.Oculus.Input
{
	[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
	public class OculusHMD : XRHMD // TypeDefIndex: 47355
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _userPresence_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector3Control _leftEyeAngularVelocity_k__BackingField; // 0x200
		[CompilerGenerated]
		private Vector3Control _leftEyeAcceleration_k__BackingField; // 0x208
		[CompilerGenerated]
		private Vector3Control _leftEyeAngularAcceleration_k__BackingField; // 0x210
		[CompilerGenerated]
		private Vector3Control _rightEyeAngularVelocity_k__BackingField; // 0x218
		[CompilerGenerated]
		private Vector3Control _rightEyeAcceleration_k__BackingField; // 0x220
		[CompilerGenerated]
		private Vector3Control _rightEyeAngularAcceleration_k__BackingField; // 0x228
		[CompilerGenerated]
		private Vector3Control _centerEyeAngularVelocity_k__BackingField; // 0x230
		[CompilerGenerated]
		private Vector3Control _centerEyeAcceleration_k__BackingField; // 0x238
		[CompilerGenerated]
		private Vector3Control _centerEyeAngularAcceleration_k__BackingField; // 0x240
	
		// Properties
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[1] {"deviceistracked" })]
		[InputControl]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[1] {"devicetrackingstate" })]
		public ButtonControl userPresence { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 0x0000000186B8B24C-0x0000000186B8B260
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D870-0x0000000184D8D880 0x0000000186B8B1FC-0x0000000186B8B210
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D440-0x0000000184D8D450 0x0000000186B22BCC-0x0000000186B22BE0
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAE0-0x0000000184D8DAF0 0x0000000186B8B490-0x0000000186B8B4A4
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAD0-0x0000000184D8DAE0 0x0000000186B8B47C-0x0000000186B8B490
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DE80-0x0000000184D8DE90 0x0000000186B8B8C8-0x0000000186B8B8DC
	
		// Constructors
		public OculusHMD(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A2A7C-0x000000018B1A2D74
	}

	[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OculusTouchController : XRControllerWithRumble // TypeDefIndex: 47356
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _thumbstick_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _primaryButton_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _secondaryButton_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _start_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _thumbstickClicked_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private ButtonControl _primaryTouched_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private ButtonControl _secondaryTouched_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private AxisControl _triggerTouched_k__BackingField; // 0x200
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x208
		[CompilerGenerated]
		private ButtonControl _thumbstickTouched_k__BackingField; // 0x210
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x218
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x220
		[CompilerGenerated]
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x228
		[CompilerGenerated]
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x230
	
		// Properties
		[InputControl(aliases = new string[2] {"Primary2DAxis", "Joystick" })]
		public Vector2Control thumbstick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(aliases = new string[3] {"A", "X", "Alternate" })]
		public ButtonControl primaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl(aliases = new string[3] {"B", "Y", "Primary" })]
		public ButtonControl secondaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl(aliases = new string[1] {"GripButton" })]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl]
		public ButtonControl start { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(aliases = new string[2] {"JoystickOrPadPressed", "thumbstickClick" })]
		public ButtonControl thumbstickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(aliases = new string[4] {"ATouched", "XTouched", "ATouch", "XTouch" })]
		public ButtonControl primaryTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(aliases = new string[4] {"BTouched", "YTouched", "BTouch", "YTouch" })]
		public ButtonControl secondaryTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(aliases = new string[2] {"indexTouch", "indexNearTouched" })]
		public AxisControl triggerTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		[InputControl(aliases = new string[2] {"indexButton", "indexTouched" })]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 0x0000000186B8B24C-0x0000000186B8B260
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"controllerRotation" })]
		[InputControl(aliases = new string[2] {"JoystickOrPadTouched", "thumbstickTouch" })]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[1] {"controllerTrackingState" })]
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[1] {"ControllerIsTracked" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"controllerPosition" })]
		public ButtonControl thumbstickTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(noisy = true, aliases = new string[1] {"controllerVelocity" })]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D870-0x0000000184D8D880 0x0000000186B8B1FC-0x0000000186B8B210
		[InputControl(noisy = true, aliases = new string[1] {"controllerAcceleration" })]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D440-0x0000000184D8D450 0x0000000186B22BCC-0x0000000186B22BE0
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularAcceleration" })]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAE0-0x0000000184D8DAF0 0x0000000186B8B490-0x0000000186B8B4A4
	
		// Constructors
		public OculusTouchController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A2E4C-0x000000018B1A3230
	}

	public class OculusTrackingReference : TrackedDevice // TypeDefIndex: 47357
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _trackingState_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _isTracked_k__BackingField; // 0x1B8
	
		// Properties
		[InputControl(aliases = new string[1] {"trackingReferenceTrackingState" })]
		public new IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(aliases = new string[1] {"trackingReferenceIsTracked" })]
		public new ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
	
		// Constructors
		public OculusTrackingReference(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A3230-0x000000018B1A32DC
	}

	[InputControlLayout(displayName = "Oculus Remote", hideInUI = true)]
	public class OculusRemote : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 47358
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _back_k__BackingField; // 0x190
		[CompilerGenerated]
		private ButtonControl _start_k__BackingField; // 0x198
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x1A0
	
		// Properties
		[InputControl]
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		[InputControl]
		public ButtonControl start { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
	
		// Constructors
		public OculusRemote(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A2D74-0x000000018B1A2E4C
	}

	[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = true)]
	public class OculusHMDExtended : OculusHMD // TypeDefIndex: 47359
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _back_k__BackingField; // 0x248
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x250
	
		// Properties
		[InputControl]
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D840-0x0000000184D8D850 0x0000000186B8B1C0-0x0000000186B8B1D4
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 0x0000000186B8B6E8-0x0000000186B8B6FC
	
		// Constructors
		public OculusHMDExtended(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A29D0-0x000000018B1A2A7C
	}

	[InputControlLayout(displayName = "GearVR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class GearVRTrackedController : XRController // TypeDefIndex: 47360
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private ButtonControl _back_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x1F0
	
		// Properties
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl]
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
	
		// Constructors
		public GearVRTrackedController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B198ADC-0x000000018B198D18
	}
}

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "OpenVR Headset", hideInUI = true)]
	public class OpenVRHMD : XRHMD // TypeDefIndex: 47348
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private Vector3Control _leftEyeVelocity_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector3Control _leftEyeAngularVelocity_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector3Control _rightEyeVelocity_k__BackingField; // 0x200
		[CompilerGenerated]
		private Vector3Control _rightEyeAngularVelocity_k__BackingField; // 0x208
		[CompilerGenerated]
		private Vector3Control _centerEyeVelocity_k__BackingField; // 0x210
		[CompilerGenerated]
		private Vector3Control _centerEyeAngularVelocity_k__BackingField; // 0x218
	
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(noisy = true)]
		public Vector3Control leftEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(noisy = true)]
		public Vector3Control rightEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 0x0000000186B8B24C-0x0000000186B8B260
		[InputControl(noisy = true)]
		public Vector3Control centerEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
	
		// Constructors
		public OpenVRHMD(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A3580-0x000000018B1A375C
	}

	[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVRControllerWMR : XRController // TypeDefIndex: 47349
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private ButtonControl _touchpadClick_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _touchpadTouch_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _menu_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector2Control _joystick_k__BackingField; // 0x200
	
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl touchpadClick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl touchpadTouch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl(aliases = new string[1] {"primary" })]
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(aliases = new string[1] {"secondary2DAxis" })]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(aliases = new string[1] {"primary2DAxis" })]
		public Vector2Control joystick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
	
		// Constructors
		public OpenVRControllerWMR(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A32DC-0x000000018B1A3580
	}

	[InputControlLayout(displayName = "Vive Wand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class ViveWand : XRControllerWithRumble // TypeDefIndex: 47350
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private ButtonControl _primary_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _trackpadPressed_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _trackpadTouched_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private Vector2Control _trackpad_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1F8
	
		// Properties
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl]
		public ButtonControl primary { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl trackpadPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl trackpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl(aliases = new string[1] {"Primary2DAxis" })]
		public Vector2Control trackpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
	
		// Constructors
		public ViveWand(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A97A4-0x000000018B1A9A14
	}

	[InputControlLayout(displayName = "Vive Lighthouse", hideInUI = true)]
	public class ViveLighthouse : TrackedDevice // TypeDefIndex: 47351
	{
		// Constructors
		public ViveLighthouse(); // 0x00000001853971D4-0x00000001853971DC
	}

	[InputControlLayout(displayName = "Vive Tracker")]
	public class ViveTracker : TrackedDevice // TypeDefIndex: 47352
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1B8
	
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
	
		// Constructors
		public ViveTracker(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A9704-0x000000018B1A97A4
	}

	[InputControlLayout(displayName = "Handed Vive Tracker", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HandedViveTracker : ViveTracker // TypeDefIndex: 47353
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _primary_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _trackpadPressed_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
	
		// Properties
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl]
		public ButtonControl primary { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl(aliases = new string[1] {"JoystickOrPadPressed" })]
		public ButtonControl trackpadPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
	
		// Constructors
		public HandedViveTracker(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B198D18-0x000000018B198E64
	}

	[InputControlLayout(displayName = "Oculus Touch Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVROculusTouchController : XRControllerWithRumble // TypeDefIndex: 47354
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _thumbstick_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _primaryButton_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _secondaryButton_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _thumbstickClicked_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private ButtonControl _thumbstickTouched_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x200
	
		// Properties
		[InputControl]
		public Vector2Control thumbstick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(aliases = new string[1] {"Alternate" })]
		public ButtonControl primaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl(aliases = new string[1] {"Primary" })]
		public ButtonControl secondaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(aliases = new string[1] {"primary2DAxisClicked" })]
		public ButtonControl thumbstickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(aliases = new string[1] {"primary2DAxisTouch" })]
		public ButtonControl thumbstickTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
	
		// Constructors
		public OpenVROculusTouchController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A375C-0x000000018B1A3A00
	}
}

namespace UnityEngine.InputSystem
{
	public interface IInputActionCollection : IEnumerable<InputAction> // TypeDefIndex: 47366
	{
		// Properties
		InputBinding? bindingMask { get; set; }
		ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; }
		ReadOnlyArray<InputControlScheme> controlSchemes { get; }
	
		// Methods
		bool Contains(InputAction action);
		void Enable();
		void Disable();
	}

	public interface IInputActionCollection2 : IInputActionCollection // TypeDefIndex: 47367
	{
		// Properties
		IEnumerable<InputBinding> bindings { get; }
	
		// Methods
		InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0232A050 */);
		int FindBinding(InputBinding mask, out InputAction action);
	}

	public interface IInputInteraction // TypeDefIndex: 47368
	{
		// Methods
		void Process(ref InputInteractionContext context);
		void Reset();
	}

	public interface IInputInteraction<TValue> : IInputInteraction // TypeDefIndex: 47369
		where TValue : struct
	{
	}

	internal static class InputInteraction // TypeDefIndex: 47370
	{
		// Fields
		public static TypeTable s_Interactions; // 0x00
	
		// Methods
		public static System.Type GetValueType(System.Type interactionType); // 0x000000018B1A28FC-0x000000018B1A29D0
		public static string GetDisplayName(string interaction); // 0x000000018B1A2820-0x000000018B1A28FC
		public static string GetDisplayName(System.Type interactionType); // 0x000000018B1A26D0-0x000000018B1A2820
	}

	[Serializable]
	public sealed class InputAction : ICloneable, IDisposable // TypeDefIndex: 47373
	{
		// Fields
		private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; // 0x00
		private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; // 0x08
		[SerializeField]
		[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
		internal string m_Name; // 0x10
		[SerializeField]
		[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control\'s current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see \'Default Button Press Point\' in settings) is reached. It will cancel when the button is going below the release threshold (see \'Button Release Threshold\' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
		internal UnityEngine.InputSystem.InputActionType m_Type; // 0x18
		[FormerlySerializedAs("m_ExpectedControlLayout")]
		[SerializeField]
		[Tooltip("The type of control expected by the action (e.g. \"Button\" or \"Stick\"). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
		internal string m_ExpectedControlType; // 0x20
		[SerializeField]
		[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
		internal string m_Id; // 0x28
		[SerializeField]
		internal string m_Processors; // 0x30
		[SerializeField]
		internal string m_Interactions; // 0x38
		[SerializeField]
		internal InputBinding[] m_SingletonActionBindings; // 0x40
		[SerializeField]
		internal ActionFlags m_Flags; // 0x48
		[NonSerialized]
		internal InputBinding? m_BindingMask; // 0x50
		[NonSerialized]
		internal int m_BindingsStartIndex; // 0xB0
		[NonSerialized]
		internal int m_BindingsCount; // 0xB4
		[NonSerialized]
		internal int m_ControlStartIndex; // 0xB8
		[NonSerialized]
		internal int m_ControlCount; // 0xBC
		[NonSerialized]
		internal int m_ActionIndexInState; // 0xC0
		[NonSerialized]
		internal InputActionMap m_ActionMap; // 0xC8
		[NonSerialized]
		internal CallbackArray<Action<CallbackContext>> m_OnStarted; // 0xD0
		[NonSerialized]
		internal CallbackArray<Action<CallbackContext>> m_OnCanceled; // 0x120
		[NonSerialized]
		internal CallbackArray<Action<CallbackContext>> m_OnPerformed; // 0x170
	
		// Properties
		public string name { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public UnityEngine.InputSystem.InputActionType type { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public Guid id { get; } // 0x000000018B1A22A0-0x000000018B1A22E0 
		internal Guid idDontGenerate { get; } // 0x0000000183525C40-0x0000000183525C90 
		public string expectedControlType { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string processors { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public string interactions { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public InputActionMap actionMap { get; } // 0x000000018B1A2148-0x000000018B1A2170 
		public InputBinding? bindingMask { get; set; } // 0x0000000184DAB780-0x0000000184DAB7C0 0x000000018B1A2400-0x000000018B1A26B4
		public ReadOnlyArray<InputBinding> bindings { get; } // 0x000000018B1A2250-0x000000018B1A22A0 
		public ReadOnlyArray<InputControl> controls { get; } // 0x0000000183DFB3C0-0x0000000183DFB430 
		public InputActionPhase phase { get; } // 0x0000000183DFC600-0x0000000183DFC630 
		public bool inProgress { get; } // 0x000000018B1A22E0-0x000000018B1A22F8 
		public bool enabled { get; } // 0x0000000183DFC5E0-0x0000000183DFC600 
		public bool triggered { get; } // 0x000000018B1A2314-0x000000018B1A231C 
		public InputControl activeControl { get; } // 0x000000018B1A2170-0x000000018B1A21E4 
		public System.Type activeValueType { get; } // 0x000000018B1A21E4-0x000000018B1A2250 
		public bool wantsInitialStateCheck { get; set; } // 0x0000000183DFE570-0x0000000183DFE580 0x000000018B1A26B4-0x000000018B1A26D0
		internal bool isSingletonAction { get; } // 0x000000018B1A22F8-0x000000018B1A2314 
		private InputActionState.TriggerState currentState { get; } // 0x0000000183DFC630-0x0000000183DFC6C0 
	
		// Events
		public event Action<CallbackContext> started {
			add; // 0x000000018B1A20FC-0x000000018B1A2148
			remove; // 0x000000018B1A23B4-0x000000018B1A2400
		}
		public event Action<CallbackContext> canceled {
			add; // 0x0000000183DFC730-0x0000000183DFC780
			remove; // 0x000000018B1A231C-0x000000018B1A2368
		}
		public event Action<CallbackContext> performed {
			add; // 0x0000000183DFC780-0x0000000183DFC7D0
			remove; // 0x000000018B1A2368-0x000000018B1A23B4
		}
	
		// Nested types
		[Flags]
		internal enum ActionFlags // TypeDefIndex: 47371
		{
			WantsInitialStateCheck = 1
		}
	
		public struct CallbackContext // TypeDefIndex: 47372
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal int m_ActionIndex; // 0x08
	
			// Properties
			private int actionIndex { get; } // 0x0000000184D88B10-0x0000000184D88B20 
			private int bindingIndex { get; } // 0x0000000183529170-0x00000001835291A0 
			private int controlIndex { get; } // 0x0000000183528B80-0x0000000183528BC0 
			private int interactionIndex { get; } // 0x000000018B1984A8-0x000000018B1984D8 
			public InputActionPhase phase { get; } // 0x0000000183529890-0x00000001835298B0 
			public bool started { get; } // 0x000000018B198560-0x000000018B198578 
			public bool performed { get; } // 0x000000018B198528-0x000000018B198540 
			public bool canceled { get; } // 0x0000000183529860-0x0000000183529890 
			public InputAction action { get; } // 0x0000000183527400-0x0000000183527430 
			public InputControl control { get; } // 0x0000000183527700-0x0000000183527760 
			public IInputInteraction interaction { get; } // 0x000000018B1984D8-0x000000018B198528 
			public double time { get; } // 0x000000018B198578-0x000000018B198598 
			public double startTime { get; } // 0x000000018B198540-0x000000018B198560 
			public double duration { get; } // 0x000000018B198474-0x000000018B1984A8 
			public System.Type valueType { get; } // 0x000000018B1985EC-0x000000018B198640 
			public int valueSizeInBytes { get; } // 0x000000018B198598-0x000000018B1985EC 
	
			// Methods
			public unsafe void ReadValue(void* buffer, int bufferSize); // 0x000000018B198104-0x000000018B1982C8
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public bool ReadValueAsButton(); // 0x00000001835265D0-0x0000000183526650
			public object ReadValueAsObject(); // 0x000000018B198088-0x000000018B198104
			public override string ToString(); // 0x000000018B1982C8-0x000000018B198474
		}
	
		// Constructors
		public InputAction(); // 0x0000000183CBE7A0-0x0000000183CBE840
		public InputAction(string name = null, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x0232A051 */, string binding = null, string interactions = null, string processors = null, string expectedControlType = null); // 0x000000018B1A1F0C-0x000000018B1A20FC
		static InputAction(); // 0x0000000184CEA0D0-0x0000000184CEA170
	
		// Methods
		public void Dispose(); // 0x000000018B1A13BC-0x000000018B1A13DC
		public override string ToString(); // 0x000000018B1A1908-0x000000018B1A1BAC
		public void Enable(); // 0x0000000183DFB810-0x0000000183DFC000
		public void Disable(); // 0x000000018B1A12BC-0x000000018B1A13BC
		public InputAction Clone(); // 0x000000018B1A10C4-0x000000018B1A11E8
		object ICloneable.Clone(); // 0x000000018B1A1900-0x000000018B1A1908
		public TValue ReadValue<TValue>()
			where TValue : struct;
		public object ReadValueAsObject(); // 0x000000018B1A17E0-0x000000018B1A1860
		public float GetControlMagnitude(); // 0x000000018B1A15E0-0x000000018B1A162C
		public void Reset(); // 0x000000018B1A189C-0x000000018B1A1900
		public bool IsPressed(); // 0x000000018B1A1798-0x000000018B1A17E0
		public bool IsInProgress(); // 0x000000018B1A174C-0x000000018B1A1798
		private int ExpectedFrame(); // 0x000000018B1A13DC-0x000000018B1A1440
		public bool WasPressedThisFrame(); // 0x000000018B1A1DB8-0x000000018B1A1E34
		public bool WasPressedThisDynamicUpdate(); // 0x000000018B1A1D5C-0x000000018B1A1DB8
		public bool WasReleasedThisFrame(); // 0x000000018B1A1E90-0x000000018B1A1F0C
		public bool WasReleasedThisDynamicUpdate(); // 0x000000018B1A1E34-0x000000018B1A1E90
		public bool WasPerformedThisFrame(); // 0x000000018B1A1CE0-0x000000018B1A1D5C
		public bool WasPerformedThisDynamicUpdate(); // 0x000000018B1A1C84-0x000000018B1A1CE0
		public bool WasCompletedThisFrame(); // 0x000000018B1A1C08-0x000000018B1A1C84
		public bool WasCompletedThisDynamicUpdate(); // 0x000000018B1A1BAC-0x000000018B1A1C08
		public float GetTimeoutCompletionPercentage(); // 0x000000018B1A162C-0x000000018B1A174C
		internal string MakeSureIdIsInPlace(); // 0x00000001835248B0-0x00000001835248E0
		internal void GenerateId(); // 0x000000018B1A159C-0x000000018B1A15E0
		internal InputActionMap GetOrCreateActionMap(); // 0x0000000183DFC000-0x0000000183DFC030
		private void CreateInternalActionMapForSingletonAction(); // 0x000000018B1A11E8-0x000000018B1A12BC
		internal void RequestInitialStateCheckOnEnabledAction(); // 0x000000018B1A1860-0x000000018B1A189C
		internal bool ActiveControlIsValid(InputControl control); // 0x000000018B1A0DCC-0x000000018B1A0EAC
		internal InputBinding? FindEffectiveBindingMask(); // 0x000000018B1A1440-0x000000018B1A159C
		internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction); // 0x000000018B1A0EAC-0x000000018B1A1024
		internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap); // 0x000000018B1A1024-0x000000018B1A10C4
	}

	public class InputActionAsset : ScriptableObject, IInputActionCollection2 // TypeDefIndex: 47379
	{
		// Fields
		public const string Extension = "inputactions"; // Metadata: 0x0232A055
		internal const string kDefaultAssetLayoutJson = "{}"; // Metadata: 0x0232A062
		[SerializeField]
		internal InputActionMap[] m_ActionMaps; // 0x18
		[SerializeField]
		internal InputControlScheme[] m_ControlSchemes; // 0x20
		[NonSerialized]
		internal InputActionState m_SharedStateForAllMaps; // 0x28
		[NonSerialized]
		internal InputBinding? m_BindingMask; // 0x30
		[NonSerialized]
		internal int m_ParameterOverridesCount; // 0x90
		[NonSerialized]
		internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides; // 0x98
		[NonSerialized]
		internal InputActionMap.DeviceArray m_Devices; // 0xA0
	
		// Properties
		public bool enabled { get; } // 0x000000018B19A2E4-0x000000018B19A414 
		public ReadOnlyArray<InputActionMap> actionMaps { get; } // 0x00000001843E1320-0x00000001843E1380 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018B19A290-0x000000018B19A2E4 
		public IEnumerable<InputBinding> bindings { [IteratorStateMachine(typeof(_get_bindings_d__9))] get; } // 0x000000018B19A220-0x000000018B19A290 
		public InputBinding? bindingMask { get; set; } // 0x0000000184DAB700-0x0000000184DAB740 0x000000018B19A414-0x000000018B19A5B8
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x0000000185393388-0x00000001853933C0 0x000000018B19A5B8-0x000000018B19A600
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018B19A18C-0x000000018B19A220 
	
		// Nested types
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 47374
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.WriteMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
		}
	
		[Serializable]
		internal struct WriteFileJsonNoName // TypeDefIndex: 47375
		{
			// Fields
			public InputActionMap.WriteMapJson[] maps; // 0x00
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x08
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 47376
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.ReadMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
	
			// Methods
			public void ToAsset(InputActionAsset asset); // 0x000000018B1A52C8-0x000000018B1A5388
		}
	
		[CompilerGenerated]
		private sealed class _get_bindings_d__9 : IEnumerable<InputBinding>, IEnumerator<InputBinding> // TypeDefIndex: 47377
		{
			// Fields
			private int __1__state; // 0x10
			private InputBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x70
			public InputActionAsset __4__this; // 0x78
			private int _numActionMaps_5__2; // 0x80
			private int _i_5__3; // 0x84
			private InputBinding[] _bindings_5__4; // 0x88
			private int _numBindings_5__5; // 0x90
			private int _n_5__6; // 0x94
	
			// Properties
			InputBinding IEnumerator<UnityEngine.InputSystem.InputBinding>.Current { [DebuggerHidden] get; } // 0x0000000184DAB820-0x0000000184DAB860 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1A966C-0x000000018B1A96E8 
	
			// Constructors
			[DebuggerHidden]
			public _get_bindings_d__9(int __1__state); // 0x000000018B1A96E8-0x000000018B1A9704
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1A93F0-0x000000018B1A958C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1A9620-0x000000018B1A966C
			[DebuggerHidden]
			IEnumerator<InputBinding> IEnumerable<InputBinding>.GetEnumerator(); // 0x000000018B1A958C-0x000000018B1A9618
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1A9618-0x000000018B1A9620
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__32 : IEnumerator<InputAction> // TypeDefIndex: 47378
		{
			// Fields
			private int __1__state; // 0x10
			private InputAction __2__current; // 0x18
			public InputActionAsset __4__this; // 0x20
			private int _i_5__2; // 0x28
			private ReadOnlyArray<InputAction> _actions_5__3; // 0x30
			private int _actionCount_5__4; // 0x40
			private int _n_5__5; // 0x44
	
			// Properties
			InputAction IEnumerator<UnityEngine.InputSystem.InputAction>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__32(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1A9288-0x000000018B1A93A4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1A93A4-0x000000018B1A93F0
		}
	
		// Constructors
		public InputActionAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public string ToJson(); // 0x000000018B19A0D4-0x000000018B19A18C
		public void LoadFromJson(string json); // 0x000000018B199E40-0x000000018B199F10
		public static InputActionAsset FromJson(string json); // 0x000000018B199B74-0x000000018B199C2C
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0232A053 */); // 0x000000018B19950C-0x000000018B19986C
		public int FindBinding(InputBinding mask, out InputAction action); // 0x000000018B19986C-0x000000018B19997C
		public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false /* Metadata: 0x0232A054 */); // 0x000000018B199254-0x000000018B199464
		public InputActionMap FindActionMap(Guid id); // 0x000000018B199464-0x000000018B19950C
		public InputAction FindAction(Guid guid); // 0x00000001835247B0-0x0000000183524860
		public int FindControlSchemeIndex(string name); // 0x000000018B19997C-0x000000018B199A44
		public InputControlScheme? FindControlScheme(string name); // 0x000000018B199A44-0x000000018B199B74
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B199CFC-0x000000018B199E40
		public void Enable(); // 0x000000018B199124-0x000000018B199254
		public void Disable(); // 0x000000018B198FF4-0x000000018B199124
		public bool Contains(InputAction action); // 0x000000018B198F84-0x000000018B198FF4
		[IteratorStateMachine(typeof(_GetEnumerator_d__32))]
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018B199C2C-0x000000018B199C88
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B19A0CC-0x000000018B19A0D4
		internal void MarkAsDirty(); // 0x00000001841E1670-0x00000001841E1680
		internal bool IsEmpty(); // 0x000000018B199C88-0x000000018B199CFC
		internal void OnWantToChangeSetup(); // 0x000000018B199FC0-0x000000018B19A018
		internal void OnSetupChanged(); // 0x000000018B199F4C-0x000000018B199FC0
		private void ReResolveIfNecessary(bool fullResolve); // 0x000000018B19A018-0x000000018B19A054
		internal void ResolveBindingsIfNecessary(); // 0x000000018B19A054-0x000000018B19A0CC
		private void OnDestroy(); // 0x000000018B199F10-0x000000018B199F4C
	}

	public enum InputActionChange // TypeDefIndex: 47380
	{
		ActionEnabled = 0,
		ActionDisabled = 1,
		ActionMapEnabled = 2,
		ActionMapDisabled = 3,
		ActionStarted = 4,
		ActionPerformed = 5,
		ActionCanceled = 6,
		BoundControlsAboutToChange = 7,
		BoundControlsChanged = 8
	}

	[Serializable]
	public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IDisposable // TypeDefIndex: 47392
	{
		// Fields
		private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; // 0x00
		[SerializeField]
		internal string m_Name; // 0x10
		[SerializeField]
		internal string m_Id; // 0x18
		[SerializeField]
		internal InputActionAsset m_Asset; // 0x20
		[SerializeField]
		internal InputAction[] m_Actions; // 0x28
		[SerializeField]
		internal InputBinding[] m_Bindings; // 0x30
		[NonSerialized]
		private InputBinding[] m_BindingsForEachAction; // 0x38
		[NonSerialized]
		private InputControl[] m_ControlsForEachAction; // 0x40
		[NonSerialized]
		internal int m_EnabledActionsCount; // 0x48
		[NonSerialized]
		internal InputAction m_SingletonAction; // 0x50
		[NonSerialized]
		internal int m_MapIndexInState; // 0x58
		[NonSerialized]
		internal InputActionState m_State; // 0x60
		[NonSerialized]
		internal InputBinding? m_BindingMask; // 0x68
		[NonSerialized]
		private Flags m_Flags; // 0xC8
		[NonSerialized]
		internal int m_ParameterOverridesCount; // 0xCC
		[NonSerialized]
		internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides; // 0xD0
		[NonSerialized]
		internal DeviceArray m_Devices; // 0xD8
		[NonSerialized]
		internal CallbackArray<Action<InputAction.CallbackContext>> m_ActionCallbacks; // 0xE8
		[NonSerialized]
		internal Dictionary<string, int> m_ActionIndexByNameOrId; // 0x138
		internal static int s_DeferBindingResolution; // 0x08
		internal static bool s_NeedToResolveBindings; // 0x0C
	
		// Properties
		public string name { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public InputActionAsset asset { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Guid id { get; } // 0x000000018B19B87C-0x000000018B19B8C8 
		internal Guid idDontGenerate { get; } // 0x000000018B19B830-0x000000018B19B87C 
		public bool enabled { get; } // 0x000000018AD6F584-0x000000018AD6F58C 
		public ReadOnlyArray<InputAction> actions { get; } // 0x000000018B19B6EC-0x000000018B19B740 
		public ReadOnlyArray<InputBinding> bindings { get; } // 0x000000018B19B74C-0x000000018B19B7A0 
		IEnumerable<InputBinding> IInputActionCollection2.bindings { get; } // 0x000000018B19B54C-0x000000018B19B5A4 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018B19B7A0-0x000000018B19B830 
		public InputBinding? bindingMask { get; set; } // 0x0000000184DAB740-0x0000000184DAB780 0x000000018B19B914-0x000000018B19BACC
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x000000018363A3C0-0x000000018363A460 0x000000018B19BACC-0x000000018B19BB14
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018B19B5F0-0x000000018B19B6EC 
		private bool needToResolveBindings { get; set; } // 0x0000000183DFC720-0x0000000183DFC730 0x00000001843E1300-0x00000001843E1320
		private bool bindingResolutionNeedsFullReResolve { get; set; } // 0x00000001843E1110-0x00000001843E1120 0x00000001843E12E0-0x00000001843E1300
		private bool controlsForEachActionInitialized { get; set; } // 0x0000000183DFD1E0-0x0000000183DFD1F0 0x00000001843E12C0-0x00000001843E12E0
		private bool bindingsForEachActionInitialized { get; set; } // 0x000000018B19B740-0x000000018B19B74C 0x00000001843E12A0-0x00000001843E12C0
	
		// Events
		public event Action<InputAction.CallbackContext> actionTriggered {
			add; // 0x000000018B19B5A4-0x000000018B19B5F0
			remove; // 0x000000018B19B8C8-0x000000018B19B914
		}
	
		// Nested types
		[Flags]
		private enum Flags // TypeDefIndex: 47381
		{
			NeedToResolveBindings = 1,
			BindingResolutionNeedsFullReResolve = 2,
			ControlsForEachActionInitialized = 4,
			BindingsForEachActionInitialized = 8
		}
	
		internal struct DeviceArray // TypeDefIndex: 47382
		{
			// Fields
			private bool m_HaveValue; // 0x00
			private int m_DeviceCount; // 0x04
			private UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x08
	
			// Methods
			public int IndexOf(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1988D8-0x000000018B198928
			public bool Remove(UnityEngine.InputSystem.InputDevice device); // 0x000000018B198928-0x000000018B198990
			public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? Get(); // 0x000000018363A460-0x000000018363A4D0
			public bool Set(ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices); // 0x000000018B198990-0x000000018B198ADC
		}
	
		[Serializable]
		internal struct BindingOverrideListJson // TypeDefIndex: 47383
		{
			// Fields
			public List<BindingOverrideJson> bindings; // 0x00
		}
	
		[Serializable]
		internal struct BindingOverrideJson // TypeDefIndex: 47384
		{
			// Fields
			public string action; // 0x00
			public string id; // 0x08
			public string path; // 0x10
			public string interactions; // 0x18
			public string processors; // 0x20
	
			// Methods
			public static BindingOverrideJson FromBinding(InputBinding binding, string actionName); // 0x000000018B197DF0-0x000000018B197EEC
			public static BindingOverrideJson FromBinding(InputBinding binding); // 0x000000018B197EEC-0x000000018B197F68
			public static InputBinding ToBinding(BindingOverrideJson bindingOverride); // 0x000000018B197F68-0x000000018B198088
		}
	
		[Serializable]
		internal struct BindingJson // TypeDefIndex: 47385
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public string path; // 0x10
			public string interactions; // 0x18
			public string processors; // 0x20
			public string groups; // 0x28
			public string action; // 0x30
			public bool isComposite; // 0x38
			public bool isPartOfComposite; // 0x39
	
			// Methods
			public InputBinding ToBinding(); // 0x000000018B197CCC-0x000000018B197DF0
			public static BindingJson FromBinding(ref InputBinding binding); // 0x000000018B197C14-0x000000018B197CCC
		}
	
		[Serializable]
		internal struct ReadActionJson // TypeDefIndex: 47386
		{
			// Fields
			public string name; // 0x00
			public string type; // 0x08
			public string id; // 0x10
			public string expectedControlType; // 0x18
			public string expectedControlLayout; // 0x20
			public string processors; // 0x28
			public string interactions; // 0x30
			public bool passThrough; // 0x38
			public bool initialStateCheck; // 0x39
			public BindingJson[] bindings; // 0x40
	
			// Methods
			public InputAction ToAction(string actionName = null); // 0x000000018B1A508C-0x000000018B1A52C8
		}
	
		[Serializable]
		internal struct WriteActionJson // TypeDefIndex: 47387
		{
			// Fields
			public string name; // 0x00
			public string type; // 0x08
			public string id; // 0x10
			public string expectedControlType; // 0x18
			public string processors; // 0x20
			public string interactions; // 0x28
			public bool initialStateCheck; // 0x30
	
			// Methods
			public static WriteActionJson FromAction(InputAction action); // 0x000000018B1A9E70-0x000000018B1A9F5C
		}
	
		[Serializable]
		internal struct ReadMapJson // TypeDefIndex: 47388
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public ReadActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
		}
	
		[Serializable]
		internal struct WriteMapJson // TypeDefIndex: 47389
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public WriteActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
	
			// Methods
			public static WriteMapJson FromMap(InputActionMap map); // 0x000000018B1AA214-0x000000018B1AA4B4
		}
	
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 47390
		{
			// Fields
			public WriteMapJson[] maps; // 0x00
	
			// Methods
			public static WriteFileJson FromMap(InputActionMap map); // 0x000000018B1A9F5C-0x000000018B1A9FF4
			public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps); // 0x000000018B1A9FF4-0x000000018B1AA214
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 47391
		{
			// Fields
			public ReadActionJson[] actions; // 0x00
			public ReadMapJson[] maps; // 0x08
	
			// Methods
			public InputActionMap[] ToMaps(); // 0x000000018B1A5388-0x000000018B1A6148
		}
	
		// Constructors
		public InputActionMap(); // 0x000000018484F570-0x000000018484F5D0
		public InputActionMap(string name); // 0x000000018484F540-0x000000018484F570
		static InputActionMap(); // 0x0000000184D38EA0-0x0000000184D38F00
	
		// Methods
		public void Dispose(); // 0x000000018B19A8A8-0x000000018B19A8BC
		internal int FindActionIndex(string nameOrId); // 0x0000000183525D90-0x0000000183525E80
		private void SetUpActionLookupTable(); // 0x0000000183525E80-0x0000000183525F90
		internal void ClearActionLookupTable(); // 0x00000001843E1210-0x00000001843E1250
		private int FindActionIndex(Guid id); // 0x0000000183525C90-0x0000000183525D90
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0232A06E */); // 0x0000000183526450-0x00000001835264C0
		public InputAction FindAction(Guid id); // 0x0000000183524860-0x00000001835248B0
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B19ACC4-0x000000018B19ADE8
		public void Enable(); // 0x000000018B19A8BC-0x000000018B19A900
		public void Disable(); // 0x000000018B19A878-0x000000018B19A8A8
		public InputActionMap Clone(); // 0x000000018B19A600-0x000000018B19A84C
		object ICloneable.Clone(); // 0x000000018B19B3A0-0x000000018B19B3A8
		public bool Contains(InputAction action); // 0x000000018B19A84C-0x000000018B19A878
		public override string ToString(); // 0x000000018B19B4B0-0x000000018B19B54C
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018B19AC34-0x000000018B19ACC4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B19B398-0x000000018B19B3A0
		internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action); // 0x000000018B19ABA0-0x000000018B19AC34
		internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action); // 0x0000000183DFD140-0x0000000183DFD1E0
		private void SetUpPerActionControlAndBindingArrays(); // 0x0000000183525F90-0x0000000183526450
		internal void OnWantToChangeSetup(); // 0x000000018B19B130-0x000000018B19B398
		internal void OnSetupChanged(); // 0x000000018B19AED8-0x000000018B19B130
		internal void OnBindingModified(); // 0x000000018B19AEB0-0x000000018B19AED8
		internal void ClearCachedActionData(bool onlyControls = false /* Metadata: 0x0232A06F */); // 0x00000001843E1250-0x00000001843E12A0
		internal void GenerateId(); // 0x000000018B19AB5C-0x000000018B19ABA0
		internal bool LazyResolveBindings(bool fullResolve); // 0x000000018B19ADE8-0x000000018B19AEB0
		internal bool ResolveBindingsIfNecessary(); // 0x0000000183DFC6F0-0x0000000183DFC720
		internal void ResolveBindings(); // 0x00000001843DFC40-0x00000001843E1110
		public int FindBinding(InputBinding mask, out InputAction action); // 0x000000018B19A98C-0x000000018B19AAAC
		internal int FindBindingRelativeToMap(InputBinding mask); // 0x000000018B19A900-0x000000018B19A98C
		public static InputActionMap[] FromJson(string json); // 0x000000018B19AAAC-0x000000018B19AB5C
		public static string ToJson(IEnumerable<InputActionMap> maps); // 0x000000018B19B3A8-0x000000018B19B458
		public string ToJson(); // 0x000000018B19B458-0x000000018B19B4B0
		public void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public void OnAfterDeserialize(); // 0x00000001843E1120-0x00000001843E1210
	}

	public static class InputActionRebindingExtensions // TypeDefIndex: 47402
	{
		// Fields
		private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x00
	
		// Nested types
		internal struct Parameter // TypeDefIndex: 47393
		{
			// Fields
			public object instance; // 0x00
			public System.Reflection.FieldInfo field; // 0x08
			public int bindingIndex; // 0x10
		}
	
		private struct ParameterEnumerable : IEnumerable<Parameter> // TypeDefIndex: 47394
		{
			// Fields
			private InputActionState m_State; // 0x00
			private ParameterOverride m_Parameter; // 0x08
			private int m_MapIndex; // 0x80
	
			// Constructors
			public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x0232A07B */); // 0x000000018B1A3C98-0x000000018B1A3D10
	
			// Methods
			public ParameterEnumerator GetEnumerator(); // 0x000000018B1A3A00-0x000000018B1A3B20
			IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(); // 0x000000018B1A3B20-0x000000018B1A3BDC
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1A3BDC-0x000000018B1A3C98
		}
	
		private struct ParameterEnumerator : IEnumerator<Parameter> // TypeDefIndex: 47395
		{
			// Fields
			private InputActionState m_State; // 0x00
			private int m_MapIndex; // 0x08
			private int m_BindingCurrentIndex; // 0x0C
			private int m_BindingEndIndex; // 0x10
			private int m_InteractionCurrentIndex; // 0x14
			private int m_InteractionEndIndex; // 0x18
			private int m_ProcessorCurrentIndex; // 0x1C
			private int m_ProcessorEndIndex; // 0x20
			private InputBinding m_BindingMask; // 0x28
			private System.Type m_ObjectType; // 0x80
			private string m_ParameterName; // 0x88
			private bool m_MayBeInteraction; // 0x90
			private bool m_MayBeProcessor; // 0x91
			private bool m_MayBeComposite; // 0x92
			private bool m_CurrentBindingIsComposite; // 0x93
			private object m_CurrentObject; // 0x98
			private System.Reflection.FieldInfo m_CurrentParameter; // 0xA0
	
			// Properties
			public Parameter Current { get; } // 0x000000018B1A4484-0x000000018B1A44D0 
			object IEnumerator.Current { get; } // 0x000000018B1A41DC-0x000000018B1A423C 
	
			// Constructors
			public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x0232A07C */); // 0x000000018B1A423C-0x000000018B1A4484
	
			// Methods
			private bool MoveToNextBinding(); // 0x000000018B1A3EB8-0x000000018B1A4024
			private bool MoveToNextInteraction(); // 0x000000018B1A4024-0x000000018B1A4088
			private bool MoveToNextProcessor(); // 0x000000018B1A4088-0x000000018B1A40EC
			private bool FindParameter(object instance); // 0x000000018B1A3D10-0x000000018B1A3DFC
			public bool MoveNext(); // 0x000000018B1A3DFC-0x000000018B1A3EB8
			public void Reset(); // 0x000000018B1A40EC-0x000000018B1A41DC
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		internal struct ParameterOverride // TypeDefIndex: 47396
		{
			// Fields
			public string objectRegistrationName; // 0x00
			public string parameter; // 0x08
			public InputBinding bindingMask; // 0x10
			public PrimitiveValue value; // 0x68
	
			// Properties
			public System.Type objectType { get; } // 0x000000018B1A4FF4-0x000000018B1A508C 
	
			// Constructors
			public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default); // 0x000000018B1A4F08-0x000000018B1A4FF4
			public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default); // 0x000000018B1A4E8C-0x000000018B1A4F08
	
			// Methods
			public static ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName); // 0x000000018B1A4888-0x000000018B1A4AFC
			private static ParameterOverride? Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName); // 0x000000018B1A44D0-0x000000018B1A4888
			private static ParameterOverride? PickMoreSpecificOne(ParameterOverride? first, ParameterOverride? second); // 0x000000018B1A4AFC-0x000000018B1A4E8C
		}
	
		public sealed class RebindingOperation : IDisposable // TypeDefIndex: 47399
		{
			// Fields
			public const float kDefaultMagnitudeThreshold = 0.2f; // Metadata: 0x0232A082
			private InputAction m_ActionToRebind; // 0x10
			private InputBinding? m_BindingMask; // 0x18
			private System.Type m_ControlType; // 0x78
			private InternedString m_ExpectedLayout; // 0x80
			private int m_IncludePathCount; // 0x90
			private string[] m_IncludePaths; // 0x98
			private int m_ExcludePathCount; // 0xA0
			private string[] m_ExcludePaths; // 0xA8
			private int m_TargetBindingIndex; // 0xB0
			private string m_BindingGroupForNewBinding; // 0xB8
			private string m_CancelBinding; // 0xC0
			private float m_MagnitudeThreshold; // 0xC8
			private float[] m_Scores; // 0xD0
			private float[] m_Magnitudes; // 0xD8
			private double m_LastMatchTime; // 0xE0
			private double m_StartTime; // 0xE8
			private float m_Timeout; // 0xF0
			private float m_WaitSecondsAfterMatch; // 0xF4
			private InputControlList<InputControl> m_Candidates; // 0xF8
			private Action<RebindingOperation> m_OnComplete; // 0x118
			private Action<RebindingOperation> m_OnCancel; // 0x120
			private Action<RebindingOperation> m_OnPotentialMatch; // 0x128
			private Func<InputControl, string> m_OnGeneratePath; // 0x130
			private Func<InputControl, InputEventPtr, float> m_OnComputeScore; // 0x138
			private Action<RebindingOperation, string> m_OnApplyBinding; // 0x140
			private Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> m_OnEventDelegate; // 0x148
			private Action m_OnAfterUpdateDelegate; // 0x150
			private InputControlLayout.Cache m_LayoutCache; // 0x158
			private StringBuilder m_PathBuilder; // 0x160
			private Flags m_Flags; // 0x168
			private Dictionary<InputControl, float> m_StartingActuations; // 0x170
	
			// Properties
			public InputAction action { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public InputBinding? bindingMask { get; } // 0x0000000184D96DC0-0x0000000184D96E00 
			public InputControlList<InputControl> candidates { get; } // 0x0000000184DAB7F0-0x0000000184DAB810 
			public ReadOnlyArray<float> scores { get; } // 0x000000018B1A91AC-0x000000018B1A9220 
			public ReadOnlyArray<float> magnitudes { get; } // 0x000000018B1A9138-0x000000018B1A91AC 
			public InputControl selectedControl { get; } // 0x000000018B1A9220-0x000000018B1A927C 
			public bool started { get; } // 0x000000018B1A927C-0x000000018B1A9288 
			public bool completed { get; } // 0x000000018B1A9108-0x000000018B1A9114 
			public bool canceled { get; } // 0x000000018B1A90FC-0x000000018B1A9108 
			public double startTime { get; } // 0x0000000184DA0AD0-0x0000000184DA0AE0 
			public float timeout { get; } // 0x0000000184DAB810-0x0000000184DAB820 
			public string expectedControlType { get; } // 0x000000018B1A9114-0x000000018B1A9138 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 47397
			{
				Started = 1,
				Completed = 2,
				Canceled = 4,
				OnEventHooked = 8,
				OnAfterUpdateHooked = 16,
				DontIgnoreNoisyControls = 64,
				DontGeneralizePathOfSelectedControl = 128,
				AddNewBinding = 256,
				SuppressMatchingEvents = 512
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass32_0 // TypeDefIndex: 47398
			{
				// Fields
				public string group; // 0x10
	
				// Constructors
				public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _WithTargetBinding_b__0(InputControlScheme x); // 0x000000018B1B5A10-0x000000018B1B5A3C
			}
	
			// Constructors
			public RebindingOperation(); // 0x000000018B1A9070-0x000000018B1A90FC
	
			// Methods
			public RebindingOperation WithAction(InputAction action); // 0x000000018B1A81E4-0x000000018B1A832C
			public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true /* Metadata: 0x0232A07D */); // 0x000000018B1A8A1C-0x000000018B1A8A64
			public RebindingOperation WithCancelingThrough(string binding); // 0x000000018B1A8480-0x000000018B1A84B8
			public RebindingOperation WithCancelingThrough(InputControl control); // 0x000000018B1A84B8-0x000000018B1A854C
			public RebindingOperation WithExpectedControlType(string layoutName); // 0x000000018B1A88EC-0x000000018B1A8944
			public RebindingOperation WithExpectedControlType(System.Type type); // 0x000000018B1A879C-0x000000018B1A88EC
			public RebindingOperation WithExpectedControlType<TControl>()
				where TControl : InputControl;
			public RebindingOperation WithTargetBinding(int bindingIndex); // 0x000000018B1A8A90-0x000000018B1A9050
			public RebindingOperation WithBindingMask(InputBinding? bindingMask); // 0x000000018B1A8438-0x000000018B1A8480
			public RebindingOperation WithBindingGroup(string group); // 0x000000018B1A832C-0x000000018B1A8438
			public RebindingOperation WithoutGeneralizingPathOfSelectedControl(); // 0x0000000184DAB7E0-0x0000000184DAB7F0
			public RebindingOperation WithRebindAddingNewBinding(string group = null); // 0x000000018B1A8A64-0x000000018B1A8A90
			public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude); // 0x000000018B1A8944-0x000000018B1A8A1C
			public RebindingOperation WithoutIgnoringNoisyControls(); // 0x000000018B1A9050-0x000000018B1A9070
			public RebindingOperation WithControlsHavingToMatchPath(string path); // 0x000000018B1A8674-0x000000018B1A879C
			public RebindingOperation WithControlsExcluding(string path); // 0x000000018B1A854C-0x000000018B1A8674
			public RebindingOperation WithTimeout(float timeInSeconds); // 0x0000000184DAB7D0-0x0000000184DAB7E0
			public RebindingOperation OnComplete(Action<RebindingOperation> callback); // 0x000000018B1A6BE0-0x000000018B1A6C04
			public RebindingOperation OnCancel(Action<RebindingOperation> callback); // 0x000000018B1A680C-0x000000018B1A6830
			public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback); // 0x000000018B1A7B2C-0x000000018B1A7B50
			public RebindingOperation OnGeneratePath(Func<InputControl, string> callback); // 0x000000018B1A7B08-0x000000018B1A7B2C
			public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback); // 0x000000018B1A6C04-0x000000018B1A6C28
			public RebindingOperation OnApplyBinding(Action<RebindingOperation, string> callback); // 0x000000018B1A67B0-0x000000018B1A67D4
			public RebindingOperation OnMatchWaitForAnother(float seconds); // 0x0000000184DAB7C0-0x0000000184DAB7D0
			public RebindingOperation Start(); // 0x000000018B1A7F14-0x000000018B1A80BC
			public void Cancel(); // 0x000000018B1A62D8-0x000000018B1A62EC
			public void Complete(); // 0x000000018B1A62EC-0x000000018B1A6300
			public void AddCandidate(InputControl control, float score, float magnitude = -1f /* Metadata: 0x0232A07E */); // 0x000000018B1A6148-0x000000018B1A62D8
			public void RemoveCandidate(InputControl control); // 0x000000018B1A7B50-0x000000018B1A7C5C
			public void Dispose(); // 0x000000018B1A6300-0x000000018B1A6364
			~RebindingOperation(); // 0x000000018B1A6364-0x000000018B1A63D4
			public RebindingOperation Reset(); // 0x000000018B1A7D04-0x000000018B1A7DE8
			private void HookOnEvent(); // 0x000000018B1A663C-0x000000018B1A6704
			private void UnhookOnEvent(); // 0x000000018B1A818C-0x000000018B1A81E4
			private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018B1A6C28-0x000000018B1A7B08
			private void SortCandidatesByScore(); // 0x000000018B1A7DE8-0x000000018B1A7F14
			private static bool HavePathMatch(InputControl control, string[] paths, int pathCount); // 0x000000018B1A6500-0x000000018B1A6574
			private void HookOnAfterUpdate(); // 0x000000018B1A6574-0x000000018B1A663C
			private void UnhookOnAfterUpdate(); // 0x000000018B1A8128-0x000000018B1A818C
			private void OnAfterUpdate(); // 0x000000018B1A6704-0x000000018B1A67B0
			private void OnComplete(); // 0x000000018B1A6830-0x000000018B1A6BE0
			private void OnCancel(); // 0x000000018B1A67D4-0x000000018B1A680C
			private void ResetAfterMatchCompleted(); // 0x000000018B1A7C5C-0x000000018B1A7D04
			private void ThrowIfRebindInProgress(); // 0x000000018B1A80BC-0x000000018B1A8128
			private string GeneratePathForControl(InputControl control); // 0x000000018B1A63D4-0x000000018B1A6500
		}
	
		internal class DeferBindingResolutionWrapper : IDisposable // TypeDefIndex: 47400
		{
			// Constructors
			public DeferBindingResolutionWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Acquire(); // 0x0000000183528E70-0x0000000183528EB0
			public void Dispose(); // 0x0000000183DFB430-0x0000000183DFB4E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 47401
		{
			// Fields
			public ReadOnlyArray<InputBinding> bindings; // 0x10
			public int firstPartIndex; // 0x20
			public string[] partStrings; // 0x28
			public int partCount; // 0x30
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _GetBindingDisplayString_b__0(string fragment); // 0x000000018B1B58BC-0x000000018B1B5A10
		}
	
		// Methods
		private static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default, PrimitiveValue value = default);
		private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride); // 0x000000018B19C988-0x000000018B19D170
		internal static DeferBindingResolutionWrapper DeferBindingResolution(); // 0x0000000183528DB0-0x0000000183528E70
	
		// Extension methods
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, InputBinding bindingMask = default); // 0x000000018B19EB54-0x000000018B19ED3C
		private static PrimitiveValue? GetParameterValue(this InputAction action, ParameterOverride parameterOverride); // 0x000000018B19ED3C-0x000000018B19F09C
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, int bindingIndex); // 0x000000018B19F09C-0x000000018B19F340
		public static TValue? GetParameterValue<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018B19D38C-0x000000018B19D588
		public static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018B19D824-0x000000018B19DA58
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018B19D170-0x000000018B19D38C
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex); // 0x000000018B19D588-0x000000018B19D824
		public static int GetBindingIndex(this InputAction action, InputBinding bindingMask); // 0x000000018B19E7A8-0x000000018B19E8F4
		public static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask); // 0x000000018B19EA08-0x000000018B19EB54
		public static int GetBindingIndex(this InputAction action, string group = null, string path = null); // 0x000000018B19E8F4-0x000000018B19EA08
		public static InputBinding? GetBindingForControl(this InputAction action, InputControl control); // 0x000000018B19E400-0x000000018B19E604
		public static int GetBindingIndexForControl(this InputAction action, InputControl control); // 0x000000018B19E604-0x000000018B19E7A8
		public static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0232A074 */, string group = null); // 0x000000018B19E03C-0x000000018B19E1F4
		public static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0232A075 */); // 0x000000018B19E1F4-0x000000018B19E400
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0232A076 */); // 0x000000018B19DA58-0x000000018B19DAE0
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0232A077 */); // 0x000000018B19DAE0-0x000000018B19E03C
		public static void ApplyBindingOverride(this InputAction action, string newPath, string group = null, string path = null); // 0x000000018B19BCD4-0x000000018B19BDF0
		public static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride); // 0x000000018B19BEF8-0x000000018B19C018
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride); // 0x000000018B19C018-0x000000018B19C110
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path); // 0x000000018B19BDF0-0x000000018B19BEF8
		public static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride); // 0x000000018B19C110-0x000000018B19C264
		public static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride); // 0x000000018B19C264-0x000000018B19C444
		public static void RemoveBindingOverride(this InputAction action, int bindingIndex); // 0x000000018B1A0254-0x000000018B1A0330
		public static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask); // 0x000000018B1A0168-0x000000018B1A0254
		private static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask); // 0x000000018B1A0330-0x000000018B1A041C
		public static void RemoveAllBindingOverrides(this IInputActionCollection2 actions); // 0x000000018B19FD90-0x000000018B1A0028
		public static void RemoveAllBindingOverrides(this InputAction action); // 0x000000018B1A0028-0x000000018B1A0168
		public static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides); // 0x000000018B19C748-0x000000018B19C988
		public static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides); // 0x000000018B1A041C-0x000000018B1A065C
		public static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control); // 0x000000018B19C5A4-0x000000018B19C748
		public static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control); // 0x000000018B19C444-0x000000018B19C5A4
		public static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions); // 0x000000018B1A065C-0x000000018B1A09D0
		public static string SaveBindingOverridesAsJson(this InputAction action); // 0x000000018B1A09D0-0x000000018B1A0DCC
		private static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null); // 0x000000018B19BB14-0x000000018B19BCD4
		public static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true /* Metadata: 0x0232A078 */); // 0x000000018B19F6F0-0x000000018B19F814
		public static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true /* Metadata: 0x0232A079 */); // 0x000000018B19F814-0x000000018B19F940
		private static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json); // 0x000000018B19F340-0x000000018B19F6F0
		public static RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1 /* Metadata: 0x0232A07A */); // 0x000000018B19F940-0x000000018B19FD90
	}

	public enum InputActionPhase // TypeDefIndex: 47403
	{
		Disabled = 0,
		Waiting = 1,
		Started = 2,
		Performed = 3,
		Canceled = 4
	}

	[Serializable]
	public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference> // TypeDefIndex: 47404
	{
		// Fields
		[SerializeField]
		private bool m_UseReference; // 0x00
		[SerializeField]
		private InputAction m_Action; // 0x08
		[SerializeField]
		private InputActionReference m_Reference; // 0x10
	
		// Properties
		public InputAction action { get; } // 0x000000018B1AC9E0-0x000000018B1ACA5C 
		public InputActionReference reference { get; } // 0x000000018B1ACA5C-0x000000018B1ACA6C 
		internal InputAction serializedAction { get; } // 0x0000000184D88320-0x0000000184D88330 
		internal InputActionReference serializedReference { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public InputActionProperty(InputAction action); // 0x000000018B1AC984-0x000000018B1AC9B0
		public InputActionProperty(InputActionReference reference); // 0x000000018B1AC9B0-0x000000018B1AC9E0
	
		// Methods
		public bool Equals(InputActionProperty other); // 0x000000018B1AC774-0x000000018B1AC7FC
		public bool Equals(InputAction other); // 0x000000018B1AC890-0x000000018B1AC8AC
		public bool Equals(InputActionReference other); // 0x000000018B1AC8AC-0x000000018B1AC900
		public override bool Equals(object obj); // 0x000000018B1AC7FC-0x000000018B1AC890
		public override int GetHashCode(); // 0x000000018B1AC900-0x000000018B1AC984
		public static bool operator ==(InputActionProperty left, InputActionProperty right); // 0x000000018B1ACA6C-0x000000018B1ACA98
		public static bool operator !=(InputActionProperty left, InputActionProperty right); // 0x000000018B1ACA98-0x000000018B1ACAC4
	}

	public class InputActionReference : ScriptableObject // TypeDefIndex: 47405
	{
		// Fields
		[SerializeField]
		internal InputActionAsset m_Asset; // 0x18
		[SerializeField]
		internal string m_ActionId; // 0x20
		[NonSerialized]
		private InputAction m_Action; // 0x28
	
		// Properties
		public InputActionAsset asset { get; } // 0x000000018385B100-0x000000018385B110 
		public InputAction action { get; } // 0x0000000183DFC4B0-0x0000000183DFC5E0 
	
		// Constructors
		public InputActionReference(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public void Set(InputAction action); // 0x000000018B1ACE2C-0x000000018B1ACF4C
		public void Set(InputActionAsset asset, string mapName, string actionName); // 0x000000018B1ACF4C-0x000000018B1AD214
		private void SetInternal(InputActionAsset asset, InputAction action); // 0x000000018B1ACC9C-0x000000018B1ACE2C
		public override string ToString(); // 0x000000018B1AD260-0x000000018B1AD458
		internal static string GetDisplayName(InputAction action); // 0x000000018B1ACB2C-0x000000018B1ACBB8
		internal string ToDisplayName(); // 0x000000018B1AD214-0x000000018B1AD258
		public static implicit operator InputAction(InputActionReference reference); // 0x000000018B1AD458-0x000000018B1AD474
		public static InputActionReference Create(InputAction action); // 0x000000018B1ACAC4-0x000000018B1ACB2C
		internal static void ResetCachedAction(); // 0x000000018B1ACBB8-0x000000018B1ACC9C
		public InputAction ToInputAction(); // 0x000000018B1AD258-0x000000018B1AD260
	}

	public static class InputActionSetupExtensions // TypeDefIndex: 47410
	{
		// Nested types
		public struct BindingSyntax // TypeDefIndex: 47406
		{
			// Fields
			private readonly InputActionMap m_ActionMap; // 0x00
			private readonly InputAction m_Action; // 0x08
			internal readonly int m_BindingIndexInMap; // 0x10
	
			// Properties
			public bool valid { get; } // 0x000000018B1ABFA8-0x000000018B1AC000 
			public int bindingIndex { get; } // 0x000000018B1ABEC8-0x000000018B1ABF08 
			public InputBinding binding { get; } // 0x000000018B1ABF08-0x000000018B1ABFA8 
	
			// Constructors
			internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null); // 0x000000018B1ABEA0-0x000000018B1ABEC8
	
			// Methods
			public BindingSyntax WithName(string name); // 0x000000018B1AB968-0x000000018B1ABA3C
			public BindingSyntax WithPath(string path); // 0x000000018B1ABA3C-0x000000018B1ABB10
			public BindingSyntax WithGroup(string group); // 0x000000018B1AB248-0x000000018B1AB424
			public BindingSyntax WithGroups(string groups); // 0x000000018B1AB424-0x000000018B1AB5D8
			public BindingSyntax WithInteraction(string interaction); // 0x000000018B1AB5D8-0x000000018B1AB7B4
			public BindingSyntax WithInteractions(string interactions); // 0x000000018B1AB7B4-0x000000018B1AB968
			public BindingSyntax WithInteraction<TInteraction>()
				where TInteraction : IInputInteraction;
			public BindingSyntax WithProcessor(string processor); // 0x000000018B1ABB10-0x000000018B1ABCEC
			public BindingSyntax WithProcessors(string processors); // 0x000000018B1ABCEC-0x000000018B1ABEA0
			public BindingSyntax WithProcessor<TProcessor>();
			public BindingSyntax Triggering(InputAction action); // 0x000000018B1AB088-0x000000018B1AB248
			public BindingSyntax To(InputBinding binding); // 0x000000018B1AAF30-0x000000018B1AB088
			public BindingSyntax NextBinding(); // 0x000000018B1AAD20-0x000000018B1AAD54
			public BindingSyntax PreviousBinding(); // 0x000000018B1AAE28-0x000000018B1AAE5C
			public BindingSyntax NextPartBinding(string partName); // 0x000000018B1AAD90-0x000000018B1AAE28
			public BindingSyntax PreviousPartBinding(string partName); // 0x000000018B1AAE98-0x000000018B1AAF30
			public BindingSyntax NextCompositeBinding(string compositeName = null); // 0x000000018B1AAD54-0x000000018B1AAD90
			public BindingSyntax PreviousCompositeBinding(string compositeName = null); // 0x000000018B1AAE5C-0x000000018B1AAE98
			private BindingSyntax Iterate(bool next); // 0x000000018B1AAC38-0x000000018B1AAD20
			private BindingSyntax IterateCompositeBinding(bool next, string compositeName); // 0x000000018B1AA95C-0x000000018B1AAABC
			private BindingSyntax IteratePartBinding(bool next, string partName); // 0x000000018B1AAABC-0x000000018B1AAC38
			public void Erase(); // 0x000000018B1AA53C-0x000000018B1AA6E8
			public BindingSyntax InsertPartBinding(string partName, string path); // 0x000000018B1AA6E8-0x000000018B1AA95C
		}
	
		public struct CompositeSyntax // TypeDefIndex: 47407
		{
			// Fields
			private readonly InputAction m_Action; // 0x00
			private readonly InputActionMap m_ActionMap; // 0x08
			private int m_BindingIndexInMap; // 0x10
	
			// Properties
			public int bindingIndex { get; } // 0x000000018B1AC21C-0x000000018B1AC240 
	
			// Constructors
			internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex); // 0x000000018B1AC1F4-0x000000018B1AC21C
	
			// Methods
			public CompositeSyntax With(string name, string binding, string groups = null, string processors = null); // 0x000000018B1AC000-0x000000018B1AC1F4
		}
	
		public struct ControlSchemeSyntax // TypeDefIndex: 47408
		{
			// Fields
			private readonly InputActionAsset m_Asset; // 0x00
			private readonly int m_ControlSchemeIndex; // 0x08
			private InputControlScheme m_ControlScheme; // 0x10
	
			// Constructors
			internal ControlSchemeSyntax(InputActionAsset asset, int index); // 0x000000018B1AC748-0x000000018B1AC774
			internal ControlSchemeSyntax(InputControlScheme controlScheme); // 0x000000018B1AC708-0x000000018B1AC748
	
			// Methods
			public ControlSchemeSyntax WithBindingGroup(string bindingGroup); // 0x000000018B1AC54C-0x000000018B1AC670
			public ControlSchemeSyntax WithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax WithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax OrWithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax OrWithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax WithRequiredDevice(string controlPath); // 0x000000018B1AC6BC-0x000000018B1AC708
			public ControlSchemeSyntax WithOptionalDevice(string controlPath); // 0x000000018B1AC670-0x000000018B1AC6BC
			public ControlSchemeSyntax OrWithRequiredDevice(string controlPath); // 0x000000018B1AC500-0x000000018B1AC54C
			public ControlSchemeSyntax OrWithOptionalDevice(string controlPath); // 0x000000018B1AC4B4-0x000000018B1AC500
			private string DeviceTypeToControlPath<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public InputControlScheme Done(); // 0x000000018B1AC418-0x000000018B1AC4B4
			private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags); // 0x000000018B1AC240-0x000000018B1AC418
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 47409
		{
			// Fields
			public InputBinding binding; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveAction_b__0(InputBinding b); // 0x000000018B1B5A3C-0x000000018B1B5AC8
		}
	
		// Methods
		private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1 /* Metadata: 0x0232A099 */); // 0x000000018B1ADD30-0x000000018B1ADEA4
	
		// Extension methods
		public static InputActionMap AddActionMap(this InputActionAsset asset, string name); // 0x000000018B1AD764-0x000000018B1AD95C
		public static void AddActionMap(this InputActionAsset asset, InputActionMap map); // 0x000000018B1AD474-0x000000018B1AD764
		public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map); // 0x000000018B1AF998-0x000000018B1AFB18
		public static void RemoveActionMap(this InputActionAsset asset, string nameOrId); // 0x000000018B1AFB18-0x000000018B1AFC44
		public static InputAction AddAction(this InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x0232A098 */, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null); // 0x000000018B1AD95C-0x000000018B1ADD30
		public static void RemoveAction(this InputAction action); // 0x000000018B1AFC44-0x000000018B1AFFC4
		public static void RemoveAction(this InputActionAsset asset, string nameOrId); // 0x000000018B1AFFC4-0x000000018B1B00EC
		public static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null); // 0x000000018B1ADEA4-0x000000018B1ADF9C
		public static BindingSyntax AddBinding(this InputAction action, InputControl control); // 0x000000018B1AE30C-0x000000018B1AE3C4
		public static BindingSyntax AddBinding(this InputAction action, InputBinding binding = default); // 0x000000018B1AE08C-0x000000018B1AE1AC
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null); // 0x000000018B1AE3C4-0x000000018B1AE53C
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null); // 0x000000018B1AE53C-0x000000018B1AE698
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null); // 0x000000018B1ADF9C-0x000000018B1AE08C
		public static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding); // 0x000000018B1AE1AC-0x000000018B1AE30C
		public static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null); // 0x000000018B1AE698-0x000000018B1AE894
		public static BindingSyntax ChangeBinding(this InputAction action, int index); // 0x000000018B1AF534-0x000000018B1AF5F4
		public static BindingSyntax ChangeBinding(this InputAction action, string name); // 0x000000018B1AF290-0x000000018B1AF348
		public static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index); // 0x000000018B1AF168-0x000000018B1AF290
		public static BindingSyntax ChangeBindingWithId(this InputAction action, string id); // 0x000000018B1AEE28-0x000000018B1AEF3C
		public static BindingSyntax ChangeBindingWithId(this InputAction action, Guid id); // 0x000000018B1AEF3C-0x000000018B1AF058
		public static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group); // 0x000000018B1AED18-0x000000018B1AEE28
		public static BindingSyntax ChangeBindingWithPath(this InputAction action, string path); // 0x000000018B1AF058-0x000000018B1AF168
		public static BindingSyntax ChangeBinding(this InputAction action, InputBinding match); // 0x000000018B1AF348-0x000000018B1AF534
		public static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName); // 0x000000018B1AF5F4-0x000000018B1AF7F8
		public static void Rename(this InputAction action, string newName); // 0x000000018B1B022C-0x000000018B1B04B8
		public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme); // 0x000000018B1AE894-0x000000018B1AEB48
		public static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name); // 0x000000018B1AEB48-0x000000018B1AED18
		public static void RemoveControlScheme(this InputActionAsset asset, string name); // 0x000000018B1B00EC-0x000000018B1B022C
		public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup); // 0x000000018B1B04B8-0x000000018B1B0588
		public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required); // 0x000000018B1B0588-0x000000018B1B0690
		public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath); // 0x000000018B1B0760-0x000000018B1B0830
		public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath); // 0x000000018B1B0690-0x000000018B1B0760
		public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath); // 0x000000018B1AF8C8-0x000000018B1AF998
		public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath); // 0x000000018B1AF7F8-0x000000018B1AF8C8
	}

	internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable // TypeDefIndex: 47421
	{
		// Fields
		public const int kInvalidIndex = -1; // Metadata: 0x0232A0AA
		public InputActionMap[] maps; // 0x10
		public InputControl[] controls; // 0x18
		public IInputInteraction[] interactions; // 0x20
		public InputProcessor[] processors; // 0x28
		public InputBindingComposite[] composites; // 0x30
		public int totalProcessorCount; // 0x38
		public UnmanagedMemory memory; // 0x40
		private bool m_OnBeforeUpdateHooked; // 0xC0
		private bool m_OnAfterUpdateHooked; // 0xC1
		private bool m_InProcessControlStateChange; // 0xC2
		private InputEventPtr m_CurrentlyProcessingThisEvent; // 0xC8
		private Action m_OnBeforeUpdateDelegate; // 0xD0
		private Action m_OnAfterUpdateDelegate; // 0xD8
		private static readonly ProfilerMarker k_InputInitialActionStateCheckMarker; // 0x00
		private static readonly ProfilerMarker k_InputActionResolveConflictMarker; // 0x08
		private static readonly ProfilerMarker k_InputActionCallbackMarker; // 0x10
		private static readonly ProfilerMarker k_InputOnActionChangeMarker; // 0x18
		private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x20
		internal static GlobalState s_GlobalState; // 0x28
	
		// Properties
		public int totalCompositeCount { get; } // 0x0000000184D86560-0x0000000184D86570 
		public int totalMapCount { get; } // 0x0000000184D863D0-0x0000000184D863E0 
		public int totalActionCount { get; } // 0x0000000184D86600-0x0000000184D86610 
		public int totalBindingCount { get; } // 0x0000000184D86540-0x0000000184D86550 
		public int totalInteractionCount { get; } // 0x0000000184D86550-0x0000000184D86560 
		public int totalControlCount { get; } // 0x0000000184D86570-0x0000000184D86580 
		public unsafe ActionMapIndices* mapIndices { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		public unsafe TriggerState* actionStates { get; } // 0x0000000184D86280-0x0000000184D86290 
		public unsafe BindingState* bindingStates { get; } // 0x0000000184D86230-0x0000000184D86240 
		public unsafe InteractionState* interactionStates { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public unsafe int* controlIndexToBindingIndex { get; } // 0x0000000184D86210-0x0000000184D86220 
		public unsafe ushort* controlGroupingAndComplexity { get; } // 0x0000000184D86290-0x0000000184D862A0 
		public unsafe float* controlMagnitudes { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public unsafe uint* enabledControls { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public bool isProcessingControlStateChange { get; } // 0x0000000184DA5BF0-0x0000000184DA5C00 
	
		// Nested types
		internal struct InteractionState // TypeDefIndex: 47412
		{
			// Fields
			private ushort m_TriggerControlIndex; // 0x00
			private byte m_Phase; // 0x02
			private byte m_Flags; // 0x03
			private float m_TimerDuration; // 0x04
			private double m_StartTime; // 0x08
			private double m_TimerStartTime; // 0x10
			private double m_PerformedTime; // 0x18
			private float m_TotalTimeoutCompletionTimeDone; // 0x20
			private float m_TotalTimeoutCompletionTimeRemaining; // 0x24
			private long m_TimerMonitorIndex; // 0x28
	
			// Properties
			public int triggerControlIndex { get; set; } // 0x000000018B1B5644-0x000000018B1B5658 0x000000018B1B567C-0x000000018B1B56F4
			public double startTime { get; set; } // 0x0000000184D9C270-0x0000000184D9C280 0x0000000184D9E9A0-0x0000000184D9E9B0
			public double performedTime { get; set; } // 0x0000000184D86360-0x0000000184D86370 0x0000000184D86370-0x0000000184D86380
			public double timerStartTime { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x0000000184D85BA0-0x0000000184D85BB0
			public float timerDuration { get; set; } // 0x0000000184D9C560-0x0000000184D9C570 0x0000000184DAB920-0x0000000184DAB930
			public float totalTimeoutCompletionDone { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
			public float totalTimeoutCompletionTimeRemaining { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
			public long timerMonitorIndex { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000184D86520-0x0000000184D86530
			public bool isTimerRunning { get; set; } // 0x000000018B1B563C-0x000000018B1B5644 0x000000018B1B5658-0x000000018B1B567C
			public InputActionPhase phase { get; set; } // 0x0000000184D91110-0x0000000184D91120 0x0000000184D91140-0x0000000184D91150
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 47411
			{
				TimerRunning = 1
			}
		}
	
		internal struct BindingState // TypeDefIndex: 47414
		{
			// Fields
			private byte m_ControlCount; // 0x00
			private byte m_InteractionCount; // 0x01
			private byte m_ProcessorCount; // 0x02
			private byte m_MapIndex; // 0x03
			private byte m_Flags; // 0x04
			private byte m_PartIndex; // 0x05
			private ushort m_ActionIndex; // 0x06
			private ushort m_CompositeOrCompositeBindingIndex; // 0x08
			private ushort m_ProcessorStartIndex; // 0x0A
			private ushort m_InteractionStartIndex; // 0x0C
			private ushort m_ControlStartIndex; // 0x0E
			private double m_PressTime; // 0x10
			private int m_TriggerEventIdForComposite; // 0x18
			private int __padding; // 0x1C
	
			// Properties
			public int controlStartIndex { get; set; } // 0x0000000184DA8BD0-0x0000000184DA8BE0 0x0000000183DFE4B0-0x0000000183DFE4D0
			public int controlCount { get; set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000183DFE5C0-0x0000000183DFE5E0
			public int interactionStartIndex { get; set; } // 0x0000000183DFE280-0x0000000183DFE2A0 0x0000000183DFE4D0-0x0000000183DFE4F0
			public int interactionCount { get; set; } // 0x0000000184D91120-0x0000000184D91130 0x0000000183DFE4F0-0x0000000183DFE510
			public int processorStartIndex { get; set; } // 0x000000018B1AA4DC-0x000000018B1AA4F4 0x0000000183DFE510-0x0000000183DFE530
			public int processorCount { get; set; } // 0x0000000184D91110-0x0000000184D91120 0x0000000183DFE530-0x0000000183DFE550
			public int actionIndex { get; set; } // 0x0000000183529150-0x0000000183529170 0x0000000183DFE3C0-0x0000000183DFE3F0
			public int mapIndex { get; set; } // 0x0000000184D91130-0x0000000184D91140 0x0000000183DFE550-0x0000000183DFE570
			public int compositeOrCompositeBindingIndex { get; set; } // 0x0000000183DFDF40-0x0000000183DFDF60 0x0000000183DFE3F0-0x0000000183DFE420
			public int triggerEventIdForComposite { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
			public double pressTime { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x0000000184D85BA0-0x0000000184D85BB0
			public Flags flags { get; set; } // 0x0000000184D90BB0-0x0000000184D90BC0 0x0000000184D90BC0-0x0000000184D90BD0
			public bool chainsWithNext { get; set; } // 0x000000018B1AA4B4-0x000000018B1AA4BC 0x000000018B1AA4F4-0x000000018B1AA518
			public bool isEndOfChain { get; set; } // 0x000000018B1AA4BC-0x000000018B1AA4C8 0x000000018B1AA518-0x000000018B1AA53C
			public bool isPartOfChain { get; } // 0x000000018B1AA4C8-0x000000018B1AA4DC 
			public bool isComposite { get; set; } // 0x0000000183DFE3A0-0x0000000183DFE3B0 0x0000000183DFE420-0x0000000183DFE450
			public bool isPartOfComposite { get; set; } // 0x0000000183529320-0x0000000183529330 0x0000000183DFE450-0x0000000183DFE480
			public bool initialStateCheckPending { get; set; } // 0x0000000183DFD420-0x0000000183DFD430 0x0000000183DFD240-0x0000000183DFD270
			public bool wantsInitialStateCheck { get; set; } // 0x0000000183DFCD60-0x0000000183DFCD70 0x0000000183DFE480-0x0000000183DFE4B0
			public int partIndex { get; set; } // 0x0000000184D92DC0-0x0000000184D92DD0 0x0000000183DFE590-0x0000000183DFE5A0
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 47413
			{
				ChainsWithNext = 1,
				EndOfChain = 2,
				Composite = 4,
				PartOfComposite = 8,
				InitialStateCheckPending = 16,
				WantsInitialStateCheck = 32
			}
		}
	
		public struct TriggerState // TypeDefIndex: 47416
		{
			// Fields
			public const int kMaxNumMaps = 255; // Metadata: 0x0232A0B2
			public const int kMaxNumControls = 65535; // Metadata: 0x0232A0B4
			public const int kMaxNumBindings = 65535; // Metadata: 0x0232A0B8
			private byte m_Phase; // 0x00
			private byte m_Flags; // 0x01
			private byte m_MapIndex; // 0x02
			private ushort m_ControlIndex; // 0x04
			private double m_Time; // 0x08
			private double m_StartTime; // 0x10
			private ushort m_BindingIndex; // 0x18
			private ushort m_InteractionIndex; // 0x1A
			private float m_Magnitude; // 0x1C
			private uint m_LastPerformedInUpdate; // 0x20
			private uint m_LastCanceledInUpdate; // 0x24
			private uint m_PressedInUpdate; // 0x28
			private uint m_ReleasedInUpdate; // 0x2C
			private uint m_LastCompletedInUpdate; // 0x30
			internal int framePerformed; // 0x34
			internal int framePressed; // 0x38
			internal int frameReleased; // 0x3C
			internal int frameCompleted; // 0x40
	
			// Properties
			public InputActionPhase phase { get; set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000184D87180-0x0000000184D87190
			public bool isDisabled { get; } // 0x00000001835291C0-0x00000001835291D0 
			public bool isWaiting { get; } // 0x000000018ADC865C-0x000000018ADC8664 
			public bool isStarted { get; } // 0x000000018ADC8664-0x000000018ADC866C 
			public bool isPerformed { get; } // 0x000000018B1B570C-0x000000018B1B5714 
			public bool isCanceled { get; } // 0x000000018B1B5704-0x000000018B1B570C 
			public double time { get; set; } // 0x0000000184D9C270-0x0000000184D9C280 0x0000000184D9E9A0-0x0000000184D9E9B0
			public double startTime { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x0000000184D85BA0-0x0000000184D85BB0
			public float magnitude { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184DAB930-0x0000000184DAB940
			public bool haveMagnitude { get; } // 0x000000018B1B56FC-0x000000018B1B5704 
			public int mapIndex { get; set; } // 0x0000000184D91110-0x0000000184D91120 0x0000000183529370-0x0000000183529390
			public int controlIndex { get; set; } // 0x0000000183528D80-0x0000000183528DA0 0x0000000183529420-0x0000000183529450
			public int bindingIndex { get; set; } // 0x0000000184DA8B70-0x0000000184DA8B80 0x0000000183529350-0x0000000183529370
			public int interactionIndex { get; set; } // 0x0000000183529130-0x0000000183529150 0x0000000183529330-0x0000000183529350
			public uint lastPerformedInUpdate { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
			public uint lastCompletedInUpdate { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
			public uint lastCanceledInUpdate { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
			public uint pressedInUpdate { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
			public uint releasedInUpdate { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
			public bool isPassThrough { get; set; } // 0x00000001835291B0-0x00000001835291C0 0x00000001835293F0-0x0000000183529420
			public bool isButton { get; set; } // 0x0000000183529310-0x0000000183529320 0x00000001835293C0-0x00000001835293F0
			public bool isPressed { get; set; } // 0x0000000183528DA0-0x0000000183528DB0 0x000000018459ECB0-0x000000018459ECE0
			public bool mayNeedConflictResolution { get; set; } // 0x0000000183529720-0x0000000183529730 0x0000000183DFE0F0-0x0000000183DFE110
			public bool hasMultipleConcurrentActuations { get; set; } // 0x000000018B1B56F4-0x000000018B1B56FC 0x000000018B1B5714-0x000000018B1B5738
			public bool inProcessing { get; set; } // 0x00000001835291A0-0x00000001835291B0 0x0000000183529390-0x00000001835293C0
			public Flags flags { get; set; } // 0x0000000184D91120-0x0000000184D91130 0x0000000184D91150-0x0000000184D91160
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 47415
			{
				HaveMagnitude = 1,
				PassThrough = 2,
				MayNeedConflictResolution = 4,
				HasMultipleConcurrentActuations = 8,
				InProcessing = 16,
				Button = 32,
				Pressed = 64
			}
		}
	
		public struct ActionMapIndices // TypeDefIndex: 47417
		{
			// Fields
			public int actionStartIndex; // 0x00
			public int actionCount; // 0x04
			public int controlStartIndex; // 0x08
			public int controlCount; // 0x0C
			public int bindingStartIndex; // 0x10
			public int bindingCount; // 0x14
			public int interactionStartIndex; // 0x18
			public int interactionCount; // 0x1C
			public int processorStartIndex; // 0x20
			public int processorCount; // 0x24
			public int compositeStartIndex; // 0x28
			public int compositeCount; // 0x2C
		}
	
		public struct UnmanagedMemory : IDisposable // TypeDefIndex: 47418
		{
			// Fields
			public unsafe void* basePtr; // 0x00
			public int mapCount; // 0x08
			public int actionCount; // 0x0C
			public int interactionCount; // 0x10
			public int bindingCount; // 0x14
			public int controlCount; // 0x18
			public int compositeCount; // 0x1C
			public unsafe TriggerState* actionStates; // 0x20
			public unsafe BindingState* bindingStates; // 0x28
			public unsafe InteractionState* interactionStates; // 0x30
			public unsafe float* controlMagnitudes; // 0x38
			public unsafe float* compositeMagnitudes; // 0x40
			public unsafe int* enabledControls; // 0x48
			public unsafe ushort* actionBindingIndicesAndCounts; // 0x50
			public unsafe ushort* actionBindingIndices; // 0x58
			public unsafe int* controlIndexToBindingIndex; // 0x60
			public unsafe ushort* controlGroupingAndComplexity; // 0x68
			public bool controlGroupingInitialized; // 0x70
			public unsafe ActionMapIndices* mapIndices; // 0x78
	
			// Properties
			public bool isAllocated { get; } // 0x00000001830CFC40-0x00000001830CFC50 
			public int sizeInBytes { get; } // 0x0000000183DFDBA0-0x0000000183DFDBE0 
	
			// Methods
			public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount); // 0x0000000183DFDA20-0x0000000183DFDBA0
			public void Dispose(); // 0x0000000183DFDBE0-0x0000000183DFDC40
			public void CopyDataFrom(UnmanagedMemory memory); // 0x0000000183DFD430-0x0000000183DFD580
			public UnmanagedMemory Clone(); // 0x000000018B1B5B90-0x000000018B1B5DE8
		}
	
		internal struct GlobalState // TypeDefIndex: 47419
		{
			// Fields
			internal InlinedArray<GCHandle> globalList; // 0x00
			internal CallbackArray<Action<object, InputActionChange>> onActionChange; // 0x18
			internal CallbackArray<Action<object>> onActionControlsChanged; // 0x68
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47420
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__140_0; // 0x08
			public static Action __9__140_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B1B5B2C-0x000000018B1B5B90
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SaveAndResetState_b__140_0(ref GlobalState state); // 0x000000018B1B5738-0x000000018B1B587C
			internal void _SaveAndResetState_b__140_1(); // 0x000000018B1B587C-0x000000018B1B58BC
		}
	
		// Constructors
		public InputActionState(); // 0x00000001841E1670-0x00000001841E1680
		static InputActionState(); // 0x0000000184B1D8F0-0x0000000184B1DA40
	
		// Methods
		public void Initialize(InputBindingResolver resolver); // 0x00000001843E13E0-0x00000001843E1480
		private void ComputeControlGroupingIfNecessary(); // 0x00000001843E17E0-0x00000001843E1940
		public void ClaimDataFrom(InputBindingResolver resolver); // 0x00000001843E15D0-0x00000001843E16B0
		~InputActionState(); // 0x000000018B1B1BD8-0x000000018B1B1C4C
		public void Dispose(); // 0x000000018B1B1994-0x000000018B1B19A0
		private void Destroy(bool isFinalizing = false /* Metadata: 0x0232A09A */); // 0x000000018B1B1218-0x000000018B1B1394
		public InputActionState Clone(); // 0x000000018B1B0EFC-0x000000018B1B109C
		object ICloneable.Clone(); // 0x000000018B1B44D0-0x000000018B1B44D8
		private bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018363A280-0x000000018363A3C0
		private bool CanUseDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1B0830-0x000000018B1B09E0
		public bool HasEnabledActions(); // 0x000000018B1B2364-0x000000018B1B23B4
		private void FinishBindingCompositeSetups(); // 0x0000000183DFE2A0-0x0000000183DFE3A0
		internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions); // 0x000000018B1B2434-0x000000018B1B28F8
		public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve); // 0x00000001843E1380-0x00000001843E13E0
		private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve); // 0x000000018B1B3750-0x000000018B1B3F4C
		private bool IsActiveControl(int bindingIndex, int controlIndex); // 0x0000000184B87700-0x0000000184B87790
		private int FindControlIndexOnBinding(int bindingIndex, InputControl control); // 0x000000018B1B1EA0-0x000000018B1B1F0C
		private void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device); // 0x0000000183639F50-0x000000018363A180
		private bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex); // 0x000000018363A180-0x000000018363A280
		public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting /* Metadata: 0x0232A09B */, bool hardReset = false /* Metadata: 0x0232A09C */); // 0x000000018B1B32B0-0x000000018B1B3418
		public ref TriggerState FetchActionState(InputAction action); // 0x0000000183DFC6C0-0x0000000183DFC6F0
		public ActionMapIndices FetchMapIndices(InputActionMap map); // 0x0000000184D54C60-0x0000000184D54CB0
		public void EnableAllActions(InputActionMap map); // 0x000000018B1B19A0-0x000000018B1B1A9C
		private void EnableControls(InputActionMap map); // 0x000000018B1B1A9C-0x000000018B1B1AFC
		public void EnableSingleAction(InputAction action); // 0x0000000183DFC7D0-0x0000000183DFC880
		private void EnableControls(InputAction action); // 0x0000000183DFC980-0x0000000183DFCA80
		public void DisableAllActions(InputActionMap map); // 0x000000018B1B14CC-0x000000018B1B1660
		public void DisableControls(InputActionMap map); // 0x000000018B1B18A0-0x000000018B1B1900
		public void DisableSingleAction(InputAction action); // 0x000000018B1B1900-0x000000018B1B1994
		private void DisableControls(InputAction action); // 0x000000018B1B1660-0x000000018B1B1740
		private void EnableControls(int mapIndex, int controlStartIndex, int numControls); // 0x0000000183DFCBB0-0x0000000183DFCD60
		private void DisableControls(int mapIndex, int controlStartIndex, int numControls); // 0x000000018B1B1740-0x000000018B1B18A0
		public void SetInitialStateCheckPending(int actionIndex, bool value = true /* Metadata: 0x0232A09D */); // 0x000000018B1B4184-0x000000018B1B4244
		private unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value); // 0x0000000183DFD1F0-0x0000000183DFD240
		private bool IsControlEnabled(int controlIndex); // 0x0000000183DFCDB0-0x0000000183DFCDF0
		private void SetControlEnabled(int controlIndex, bool state); // 0x0000000183DFCD70-0x0000000183DFCDB0
		private void HookOnBeforeUpdate(); // 0x0000000183DFC880-0x0000000183DFC980
		private void UnhookOnBeforeUpdate(); // 0x0000000184CDCD80-0x0000000184CDCE00
		private void OnBeforeInitialUpdate(); // 0x0000000183DFD270-0x0000000183DFD420
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex); // 0x0000000183527120-0x0000000183527170
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex); // 0x000000018B1B44D8-0x000000018B1B4520
		private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex); // 0x0000000184DAB8E0-0x0000000184DAB920
		private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex); // 0x0000000184DAB8B0-0x0000000184DAB8E0
		internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex); // 0x0000000184DAB8A0-0x0000000184DAB8B0
		private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr); // 0x0000000183527760-0x0000000183528B80
		private unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr); // 0x0000000183528BC0-0x0000000183528D80
		private static unsafe bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr); // 0x000000018B1B4288-0x000000018B1B42A8
		private bool IsConflictingInput(ref TriggerState trigger, int actionIndex); // 0x00000001835296B0-0x0000000183529720
		private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount); // 0x0000000184DAB860-0x0000000184DAB890
		private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex); // 0x00000001835291D0-0x0000000183529280
		private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount); // 0x000000018B1B28F8-0x000000018B1B2A34
		private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex); // 0x000000018B1B2A34-0x000000018B1B2BC0
		internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger); // 0x000000018B1B4244-0x000000018B1B4288
		internal void StartTimeout(float seconds, ref TriggerState trigger); // 0x000000018B1B42A8-0x000000018B1B440C
		private void StopTimeout(int interactionIndex); // 0x000000018B1B440C-0x000000018B1B44D0
		internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting /* Metadata: 0x0232A09E */, InputActionPhase phaseAfterCanceled = InputActionPhase.Waiting /* Metadata: 0x0232A09F */, bool processNextInteractionOnCancel = true /* Metadata: 0x0232A0A0 */); // 0x000000018B1B09E0-0x000000018B1B0EFC
		private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting /* Metadata: 0x0232A0A1 */); // 0x0000000183528EB0-0x0000000183529130
		private unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false /* Metadata: 0x0232A0A2 */); // 0x00000001835274D0-0x0000000183527700
		private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName); // 0x0000000183527170-0x0000000183527400
		private object GetActionOrNoneString(ref TriggerState trigger); // 0x000000018B1B1F48-0x000000018B1B1FA0
		internal InputAction GetActionOrNull(int bindingIndex); // 0x0000000183527430-0x00000001835274D0
		internal InputAction GetActionOrNull(ref TriggerState trigger); // 0x000000018B1B1FA0-0x000000018B1B2040
		internal InputControl GetControl(ref TriggerState trigger); // 0x000000018B1B21AC-0x000000018B1B21E8
		private IInputInteraction GetInteractionOrNull(ref TriggerState trigger); // 0x000000018B1B21E8-0x000000018B1B2244
		internal int GetBindingIndexInMap(int bindingIndex); // 0x000000018B1B2040-0x000000018B1B2084
		internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap); // 0x000000018B1B2084-0x000000018B1B20BC
		internal ref BindingState GetBindingState(int bindingIndex); // 0x0000000184DAB890-0x0000000184DAB8A0
		internal ref InputBinding GetBinding(int bindingIndex); // 0x000000018B1B20BC-0x000000018B1B2134
		internal InputActionMap GetActionMap(int bindingIndex); // 0x000000018B1B1F0C-0x000000018B1B1F48
		private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled); // 0x000000018B1B358C-0x000000018B1B3644
		private void ResetInteractionState(int interactionIndex); // 0x000000018B1B3644-0x000000018B1B3750
		internal int GetValueSizeInBytes(int bindingIndex, int controlIndex); // 0x000000018B1B2244-0x000000018B1B22D4
		internal System.Type GetValueType(int bindingIndex, int controlIndex); // 0x000000018B1B22D4-0x000000018B1B2364
		internal static bool IsActuated(ref TriggerState trigger, float threshold = 0f /* Metadata: 0x0232A0A3 */); // 0x000000018B1B23B4-0x000000018B1B2434
		internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false /* Metadata: 0x0232A0A7 */); // 0x000000018B1B2FCC-0x000000018B1B318C
		internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0232A0A8 */)
			where TValue : struct;
		internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null)
			where TValue : struct;
		public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber); // 0x000000018B1B1AFC-0x000000018B1B1BD8
		internal double GetCompositePartPressTime(int bindingIndex, int partNumber); // 0x000000018B1B2134-0x000000018B1B21AC
		internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue>;
		internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize); // 0x000000018B1B2CD0-0x000000018B1B2E04
		internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber); // 0x000000018B1B2BC0-0x000000018B1B2CD0
		internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0232A0A9 */); // 0x000000018B1B2E04-0x000000018B1B2FCC
		internal bool ReadValueAsButton(int bindingIndex, int controlIndex); // 0x0000000183526650-0x0000000183526720
		internal static ISavedState SaveAndResetState(); // 0x000000018B1B3F4C-0x000000018B1B4184
		private void AddToGlobalList(); // 0x00000001843E1480-0x00000001843E1510
		private void RemoveMapFromGlobalList(); // 0x000000018B1B318C-0x000000018B1B32B0
		private static void CompactGlobalList(); // 0x00000001843E1510-0x00000001843E15D0
		internal void NotifyListenersOfActionChange(InputActionChange change); // 0x00000001843E16B0-0x00000001843E17E0
		internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset); // 0x0000000183DFCA80-0x0000000183DFCBB0
		private static void ResetGlobals(); // 0x000000018B1B3418-0x000000018B1B358C
		internal static int FindAllEnabledActions(List<InputAction> result); // 0x000000018B1B1C4C-0x000000018B1B1EA0
		internal static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018363B6C0-0x000000018363B830
		internal static void DeferredResolutionOfBindings(); // 0x0000000183DFB4E0-0x0000000183DFB810
		internal static void DisableAllActions(); // 0x000000018B1B1394-0x000000018B1B14CC
		internal static void DestroyAllActionMapStates(); // 0x000000018B1B109C-0x000000018B1B1218
	}

	public enum InputActionType // TypeDefIndex: 47422
	{
		Value = 0,
		Button = 1,
		PassThrough = 2
	}

	[Serializable]
	public struct InputBinding : IEquatable<InputBinding> // TypeDefIndex: 47427
	{
		// Fields
		public const char Separator = ';'; // Metadata: 0x0232A0CA
		internal const string kSeparatorString = ";"; // Metadata: 0x0232A0CC
		[SerializeField]
		private string m_Name; // 0x00
		[SerializeField]
		internal string m_Id; // 0x08
		[SerializeField]
		[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.\n\nCan either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the \'T\' button. Internally, both methods result in control path strings that look like, for example, \"<Gamepad>/buttonSouth\".")]
		private string m_Path; // 0x10
		[SerializeField]
		private string m_Interactions; // 0x18
		[SerializeField]
		private string m_Processors; // 0x20
		[SerializeField]
		internal string m_Groups; // 0x28
		[SerializeField]
		private string m_Action; // 0x30
		[SerializeField]
		internal Flags m_Flags; // 0x38
		[NonSerialized]
		private string m_OverridePath; // 0x40
		[NonSerialized]
		private string m_OverrideInteractions; // 0x48
		[NonSerialized]
		private string m_OverrideProcessors; // 0x50
	
		// Properties
		public string name { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Guid id { get; set; } // 0x000000018B1B546C-0x000000018B1B54B8 0x000000018B1B55D8-0x000000018B1B5604
		public string path { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string overridePath { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public string interactions { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string overrideInteractions { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public string processors { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string overrideProcessors { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public string groups { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string action { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public bool isComposite { get; set; } // 0x0000000183DFE580-0x0000000183DFE590 0x000000018B1B5604-0x000000018B1B5620
		public bool isPartOfComposite { get; set; } // 0x0000000183DFE5E0-0x0000000183DFE5F0 0x000000018B1B5620-0x000000018B1B563C
		public bool hasOverrides { get; } // 0x000000018B1B5450-0x000000018B1B546C 
		public string effectivePath { get; } // 0x0000000183DFE5A0-0x0000000183DFE5B0 
		public string effectiveInteractions { get; } // 0x0000000183DFE3B0-0x0000000183DFE3C0 
		public string effectiveProcessors { get; } // 0x0000000183DFE5B0-0x0000000183DFE5C0 
		internal bool isEmpty { get; } // 0x000000018B1B54B8-0x000000018B1B54FC 
	
		// Nested types
		[Flags]
		public enum DisplayStringOptions // TypeDefIndex: 47423
		{
			DontUseShortDisplayNames = 1,
			DontOmitDevice = 2,
			DontIncludeInteractions = 4,
			IgnoreBindingOverrides = 8
		}
	
		[Flags]
		internal enum MatchOptions // TypeDefIndex: 47424
		{
			EmptyGroupMatchesAny = 1
		}
	
		[Flags]
		internal enum Flags // TypeDefIndex: 47425
		{
			None = 0,
			Composite = 4,
			PartOfComposite = 8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47426
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__45_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B1B5AC8-0x000000018B1B5B2C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _MaskByGroups_b__45_0(string x); // 0x0000000184B313B0-0x0000000184B313D0
		}
	
		// Constructors
		public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null); // 0x000000018B1B53AC-0x000000018B1B5450
	
		// Methods
		public string GetNameOfComposite(); // 0x000000018B1B4BF8-0x000000018B1B4C28
		internal void GenerateId(); // 0x000000018B1B4A98-0x000000018B1B4ADC
		internal void RemoveOverrides(); // 0x000000018B1B4F20-0x000000018B1B4F58
		public static InputBinding MaskByGroup(string group); // 0x000000018B1B4C28-0x000000018B1B4C60
		public static InputBinding MaskByGroups(params string[] groups); // 0x000000018B1B4C60-0x000000018B1B4DBC
		public bool Equals(InputBinding other); // 0x000000018B1B49B0-0x000000018B1B4A98
		public override bool Equals(object obj); // 0x000000018B1B490C-0x000000018B1B49B0
		public static bool operator ==(InputBinding left, InputBinding right); // 0x000000018B1B54FC-0x000000018B1B554C
		public static bool operator !=(InputBinding left, InputBinding right); // 0x000000018B1B554C-0x000000018B1B55D8
		public override int GetHashCode(); // 0x000000018B1B4ADC-0x000000018B1B4BF8
		public override string ToString(); // 0x000000018B1B5264-0x000000018B1B5358
		public string ToDisplayString(DisplayStringOptions options =  /* Metadata: 0x0232A0C7 */, InputControl control = null); // 0x000000018B1B5230-0x000000018B1B5264
		public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options =  /* Metadata: 0x0232A0C8 */, InputControl control = null); // 0x000000018B1B4F58-0x000000018B1B5230
		internal bool TriggersAction(InputAction action); // 0x000000018B1B5358-0x000000018B1B53AC
		public bool Matches(InputBinding binding); // 0x000000018B1B4DBC-0x000000018B1B4DD0
		internal bool Matches(ref InputBinding binding, MatchOptions options =  /* Metadata: 0x0232A0C9 */); // 0x000000018B1B4DD0-0x000000018B1B4F20
	}

	public abstract class InputBindingComposite // TypeDefIndex: 47429
	{
		// Fields
		internal static TypeTable s_Composites; // 0x00
	
		// Properties
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetPartNames_d__12 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 47428
		{
			// Fields
			private int __1__state; // 0x10
			private string __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private string composite; // 0x28
			public string __3__composite; // 0x30
			private System.Reflection.FieldInfo[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetPartNames_d__12(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1D88C8-0x000000018B1D8A60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1D8AFC-0x000000018B1D8B48
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018B1D8A60-0x000000018B1D8AF4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D8AF4-0x000000018B1D8AFC
		}
	
		// Constructors
		protected InputBindingComposite(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);
		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);
		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x0000000184DA9E10-0x0000000184DA9E20
		protected virtual void FinishSetup(ref InputBindingCompositeContext context); // 0x00000001841E1670-0x00000001841E1680
		internal void CallFinishSetup(ref InputBindingCompositeContext context); // 0x0000000185395D44-0x0000000185395D80
		internal static System.Type GetValueType(string composite); // 0x000000018B1B4800-0x000000018B1B490C
		public static string GetExpectedControlLayoutName(string composite, string part); // 0x000000018B1B460C-0x000000018B1B4790
		[IteratorStateMachine(typeof(_GetPartNames_d__12))]
		internal static IEnumerable<string> GetPartNames(string composite); // 0x000000018B1B4790-0x000000018B1B4800
		internal static string GetDisplayFormatString(string composite); // 0x000000018B1B4520-0x000000018B1B460C
	}

	public abstract class InputBindingComposite<TValue> : InputBindingComposite // TypeDefIndex: 47430
		where TValue : struct
	{
		// Properties
		public override System.Type valueType { get; }
		public override int valueSizeInBytes { get; }
	
		// Constructors
		protected InputBindingComposite();
	
		// Methods
		public abstract TValue ReadValue(ref InputBindingCompositeContext context);
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);
		public override object ReadValueAsObject(ref InputBindingCompositeContext context);
	}

	public struct InputBindingCompositeContext // TypeDefIndex: 47434
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal int m_BindingIndex; // 0x08
	
		// Properties
		public IEnumerable<PartBinding> controls { [IteratorStateMachine(typeof(_get_controls_d__2))] get; } // 0x000000018B1CB9B8-0x000000018B1CBA2C 
	
		// Nested types
		public struct PartBinding // TypeDefIndex: 47431
		{
			// Fields
			[CompilerGenerated]
			private int _part_k__BackingField; // 0x00
			[CompilerGenerated]
			private InputControl _control_k__BackingField; // 0x08
	
			// Properties
			public int part { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
			public InputControl control { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		}
	
		private struct DefaultComparer<TValue> : IComparer<TValue> // TypeDefIndex: 47432
			where TValue : IComparable<TValue>
		{
			// Methods
			public int Compare(TValue x, TValue y);
		}
	
		[CompilerGenerated]
		private sealed class _get_controls_d__2 : IEnumerable<PartBinding>, IEnumerator<PartBinding> // TypeDefIndex: 47433
		{
			// Fields
			private int __1__state; // 0x10
			private PartBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			public InputBindingCompositeContext __4__this; // 0x30
			public InputBindingCompositeContext __3____4__this; // 0x40
			private int _totalBindingCount_5__2; // 0x50
			private int _bindingIndex_5__3; // 0x54
			private InputActionState.BindingState _bindingState_5__4; // 0x58
			private int _controlStartIndex_5__5; // 0x78
			private int _i_5__6; // 0x7C
	
			// Properties
			PartBinding IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current { [DebuggerHidden] get; } // 0x0000000184D890C0-0x0000000184D890D0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1D91A4-0x000000018B1D92C4 
	
			// Constructors
			[DebuggerHidden]
			public _get_controls_d__2(int __1__state); // 0x0000000186C07014-0x0000000186C07030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1D8F90-0x000000018B1D90BC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1D9158-0x000000018B1D91A4
			[DebuggerHidden]
			IEnumerator<PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator(); // 0x000000018B1D90BC-0x000000018B1D9150
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D9150-0x000000018B1D9158
		}
	
		// Methods
		public float EvaluateMagnitude(int partNumber); // 0x000000018B1CB880-0x000000018B1CB8AC
		public TValue ReadValue<TValue>(int partNumber)
			where TValue : struct, IComparable<TValue>;
		public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl)
			where TValue : struct, IComparable<TValue>;
		public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue>;
		public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue>;
		public bool ReadValueAsButton(int partNumber); // 0x000000018B1CB8D8-0x000000018B1CB960
		public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize); // 0x000000018B1CB98C-0x000000018B1CB9B8
		public object ReadValueAsObject(int partNumber); // 0x000000018B1CB960-0x000000018B1CB98C
		public double GetPressTime(int partNumber); // 0x000000018B1CB8AC-0x000000018B1CB8D8
	}

	internal struct InputBindingResolver : IDisposable // TypeDefIndex: 47435
	{
		// Fields
		public int totalProcessorCount; // 0x00
		public int totalCompositeCount; // 0x04
		public int totalInteractionCount; // 0x08
		public InputActionMap[] maps; // 0x10
		public InputControl[] controls; // 0x18
		public InputActionState.UnmanagedMemory memory; // 0x20
		public IInputInteraction[] interactions; // 0xA0
		public InputProcessor[] processors; // 0xA8
		public InputBindingComposite[] composites; // 0xB0
		public InputBinding? bindingMask; // 0xB8
		private bool m_IsControlOnlyResolve; // 0x118
		private List<NameAndParameters> m_Parameters; // 0x120
	
		// Properties
		public int totalMapCount { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
		public int totalActionCount { get; } // 0x0000000184D86710-0x0000000184D86720 
		public int totalBindingCount { get; } // 0x0000000184D86730-0x0000000184D86740 
		public int totalControlCount { get; } // 0x0000000184D863B0-0x0000000184D863C0 
	
		// Methods
		public void Dispose(); // 0x000000018B1CBA2C-0x000000018B1CBA38
		public void StartWithPreviousResolve(InputActionState state, bool isFullResolve); // 0x000000018B1CBA38-0x000000018B1CBBAC
		public void AddActionMap(InputActionMap actionMap); // 0x0000000183DFE5F0-0x0000000183E00840
		private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding);
		private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap); // 0x0000000183DFDF60-0x0000000183DFE0F0
		private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters); // 0x0000000183DFD580-0x0000000183DFDA20
		private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount); // 0x0000000183DFE110-0x0000000183DFE280
	}

	[Serializable]
	public struct InputControlScheme : IEquatable<InputControlScheme> // TypeDefIndex: 47444
	{
		// Fields
		[SerializeField]
		internal string m_Name; // 0x00
		[SerializeField]
		internal string m_BindingGroup; // 0x08
		[SerializeField]
		internal DeviceRequirement[] m_DeviceRequirements; // 0x10
	
		// Properties
		public string name { get; } // 0x0000000182B76770-0x0000000182B76780 
		public string bindingGroup { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public ReadOnlyArray<DeviceRequirement> deviceRequirements { get; } // 0x000000018B1CFDC4-0x000000018B1CFE18 
	
		// Nested types
		public struct MatchResult : IEnumerable<MatchResult.Match>, IDisposable // TypeDefIndex: 47439
		{
			// Fields
			internal Result m_Result; // 0x00
			internal float m_Score; // 0x04
			internal InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices; // 0x08
			internal InputControlList<InputControl> m_Controls; // 0x28
			internal DeviceRequirement[] m_Requirements; // 0x48
	
			// Properties
			public float score { get; } // 0x0000000184D9C560-0x0000000184D9C570 
			public bool isSuccessfulMatch { get; } // 0x0000000189DE6CF4-0x0000000189DE6CFC 
			public bool hasMissingRequiredDevices { get; } // 0x000000018B1D6D28-0x000000018B1D6D30 
			public bool hasMissingOptionalDevices { get; } // 0x000000018B1D6D20-0x000000018B1D6D28 
			public InputControlList<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x000000018B1D6BFC-0x000000018B1D6D20 
			public Match this[int index] { get => default; } // 0x000000018B1D6B44-0x000000018B1D6BFC 
	
			// Nested types
			internal enum Result // TypeDefIndex: 47436
			{
				AllSatisfied = 0,
				MissingRequired = 1,
				MissingOptional = 2
			}
	
			public struct Match // TypeDefIndex: 47437
			{
				// Fields
				internal int m_RequirementIndex; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public InputControl control { get; } // 0x000000018B1D6D30-0x000000018B1D6D6C 
				public UnityEngine.InputSystem.InputDevice device { get; } // 0x000000018B1D6D6C-0x000000018B1D6D88 
				public int requirementIndex { get; } // 0x0000000182B77620-0x0000000182B77630 
				public DeviceRequirement requirement { get; } // 0x000000018B1D6DAC-0x000000018B1D6DDC 
				public bool isOptional { get; } // 0x000000018B1D6D88-0x000000018B1D6DAC 
			}
	
			private struct Enumerator : IEnumerator<Match> // TypeDefIndex: 47438
			{
				// Fields
				internal int m_Index; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public Match Current { get; } // 0x000000018B1CAFC8-0x000000018B1CB080 
				object IEnumerator.Current { get; } // 0x000000018B1CAF5C-0x000000018B1CAFC8 
	
				// Methods
				public bool MoveNext(); // 0x000000018B1CAF40-0x000000018B1CAF5C
				public void Reset(); // 0x0000000184DABDE0-0x0000000184DABDF0
				public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Methods
			public IEnumerator<Match> GetEnumerator(); // 0x000000018B1D6AA8-0x000000018B1D6B3C
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D6B3C-0x000000018B1D6B44
			public void Dispose(); // 0x000000018B1D6A50-0x000000018B1D6AA8
		}
	
		[Serializable]
		public struct DeviceRequirement : IEquatable<DeviceRequirement> // TypeDefIndex: 47441
		{
			// Fields
			[SerializeField]
			internal string m_ControlPath; // 0x00
			[SerializeField]
			internal Flags m_Flags; // 0x08
	
			// Properties
			public string controlPath { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
			public bool isOptional { get; set; } // 0x000000018B1CAEA4-0x000000018B1CAEAC 0x000000018B1CAF24-0x000000018B1CAF40
			public bool isAND { get; set; } // 0x000000018B1CAE94-0x000000018B1CAE9C 0x000000018B1CAEEC-0x000000018B1CAF08
			public bool isOR { get; set; } // 0x000000018B1CAE9C-0x000000018B1CAEA4 0x000000018B1CAF08-0x000000018B1CAF24
	
			// Nested types
			[Flags]
			internal enum Flags // TypeDefIndex: 47440
			{
				None = 0,
				Optional = 1,
				Or = 2
			}
	
			// Methods
			public override string ToString(); // 0x000000018B1CADFC-0x000000018B1CAE94
			public bool Equals(DeviceRequirement other); // 0x000000018B1CAC8C-0x000000018B1CACE8
			public override bool Equals(object obj); // 0x000000018B1CACE8-0x000000018B1CAD58
			public override int GetHashCode(); // 0x000000018B1CAD58-0x000000018B1CADFC
			public static bool operator ==(DeviceRequirement left, DeviceRequirement right); // 0x000000018B1CAEAC-0x000000018B1CAECC
			public static bool operator !=(DeviceRequirement left, DeviceRequirement right); // 0x000000018B1CAECC-0x000000018B1CAEEC
		}
	
		[Serializable]
		internal struct SchemeJson // TypeDefIndex: 47443
		{
			// Fields
			public string name; // 0x00
			public string bindingGroup; // 0x08
			public DeviceJson[] devices; // 0x10
	
			// Nested types
			[Serializable]
			public struct DeviceJson // TypeDefIndex: 47442
			{
				// Fields
				public string devicePath; // 0x00
				public bool isOptional; // 0x08
				public bool isOR; // 0x09
	
				// Methods
				public DeviceRequirement ToDeviceEntry(); // 0x000000018B1CAC40-0x000000018B1CAC8C
				public static DeviceJson From(DeviceRequirement requirement); // 0x000000018B1CAC04-0x000000018B1CAC40
			}
	
			// Methods
			public InputControlScheme ToScheme(); // 0x000000018B1D81FC-0x000000018B1D834C
			public static SchemeJson ToJson(InputControlScheme scheme); // 0x000000018B1D7F60-0x000000018B1D80FC
			public static SchemeJson[] ToJson(InputControlScheme[] schemes); // 0x000000018B1D80FC-0x000000018B1D81FC
			public static InputControlScheme[] ToSchemes(SchemeJson[] schemes); // 0x000000018B1D834C-0x000000018B1D8424
		}
	
		// Constructors
		public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null); // 0x000000018B1CFCA8-0x000000018B1CFDC4
	
		// Methods
		internal void SetNameAndBindingGroup(string name, string bindingGroup = null); // 0x000000018B1CF9E0-0x000000018B1CFA94
		public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false /* Metadata: 0x0232A0D6 */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme>;
		public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false /* Metadata: 0x0232A0D7 */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme>;
		public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
			where TSchemes : IEnumerable<InputControlScheme>;
		public bool SupportsDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1CFA94-0x000000018B1CFB50
		public MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice = null)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>;
		public bool Equals(InputControlScheme other); // 0x000000018B1CF71C-0x000000018B1CF8E4
		public override bool Equals(object obj); // 0x000000018B1CF8E4-0x000000018B1CF95C
		public override int GetHashCode(); // 0x000000018B1CF95C-0x000000018B1CF9E0
		public override string ToString(); // 0x000000018B1CFB50-0x000000018B1CFCA8
		public static bool operator ==(InputControlScheme left, InputControlScheme right); // 0x000000018B1CFE18-0x000000018B1CFE44
		public static bool operator !=(InputControlScheme left, InputControlScheme right); // 0x000000018B1CFE44-0x000000018B1CFE70
	}

	public struct InputInteractionContext // TypeDefIndex: 47446
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal Flags m_Flags; // 0x08
		internal InputActionState.TriggerState m_TriggerState; // 0x10
	
		// Properties
		public InputAction action { get; } // 0x000000018B1D2D6C-0x000000018B1D2D94 
		public InputControl control { get; } // 0x000000018B1D2DA0-0x000000018B1D2DC8 
		public InputActionPhase phase { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public double time { get; } // 0x0000000184D86360-0x0000000184D86370 
		public double startTime { get; } // 0x0000000184D86970-0x0000000184D86980 
		public bool timerHasExpired { get; internal set; } // 0x000000018B1CAE9C-0x000000018B1CAEA4 0x000000018B1CAF08-0x000000018B1CAF24
		public bool isWaiting { get; } // 0x000000018B1D2DDC-0x000000018B1D2DE4 
		public bool isStarted { get; } // 0x000000018B1D2DD4-0x000000018B1D2DDC 
		internal int mapIndex { get; } // 0x0000000184D88390-0x0000000184D883A0 
		internal int controlIndex { get; } // 0x000000018B1D2D94-0x000000018B1D2DA0 
		internal int bindingIndex { get; } // 0x0000000184DABE80-0x0000000184DABE90 
		internal int interactionIndex { get; } // 0x000000018B1D2DC8-0x000000018B1D2DD4 
	
		// Nested types
		[Flags]
		internal enum Flags // TypeDefIndex: 47445
		{
			TimerHasExpired = 2
		}
	
		// Methods
		public float ComputeMagnitude(); // 0x0000000184D86AF0-0x0000000184D86B00
		public bool ControlIsActuated(float threshold = 0f /* Metadata: 0x0232A0DE */); // 0x000000018B1D2AB4-0x000000018B1D2B10
		public void Started(); // 0x000000018B1D2CD8-0x000000018B1D2D24
		public void Performed(); // 0x000000018B1D2BA8-0x000000018B1D2BF4
		public void PerformedAndStayStarted(); // 0x000000018B1D2B5C-0x000000018B1D2BA8
		public void PerformedAndStayPerformed(); // 0x000000018B1D2B10-0x000000018B1D2B5C
		public void Canceled(); // 0x000000018B1D2A68-0x000000018B1D2AB4
		public void Waiting(); // 0x000000018B1D2D24-0x000000018B1D2D6C
		public void SetTimeout(float seconds); // 0x000000018B1D2BF4-0x000000018B1D2C1C
		public void SetTotalTimeoutCompletionTime(float seconds); // 0x000000018B1D2C1C-0x000000018B1D2CD8
		public TValue ReadValue<TValue>()
			where TValue : struct;
	}

	public static class InputSystem // TypeDefIndex: 47452
	{
		// Fields
		internal const string kAssemblyVersion = "1.14.0"; // Metadata: 0x0232A105
		internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14"; // Metadata: 0x0232A10C
		private static readonly ProfilerMarker k_InputResetMarker; // 0x00
		internal const float scrollWheelDeltaPerTick = 1f; // Metadata: 0x0232A149
		internal static InputManager s_Manager; // 0x08
		internal static InputRemoting s_Remote; // 0x10
	
		// Properties
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x0000000183DF7FE0-0x0000000183DF8060 
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> disconnectedDevices { get; } // 0x000000018B1D5B14-0x000000018B1D5BA8 
		public static float pollingFrequency { get; set; } // 0x000000018B1D5E9C-0x000000018B1D5EFC 0x000000018B1D682C-0x000000018B1D6894
		internal static bool isProcessingEvents { get; } // 0x000000018B1D5BA8-0x000000018B1D5C0C 
		public static InputEventListener onEvent { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public static IObservable<InputControl> onAnyButtonPress { get; } // 0x000000018B1D5C90-0x000000018B1D5E9C 
		public static InputSettings settings { get; set; } // 0x00000001833F20D0-0x00000001833F2120 0x000000018B1D6924-0x000000018B1D6A50
		public static InputRemoting remoting { get; } // 0x000000018B1D5EFC-0x000000018B1D5F4C 
		public static System.Version version { get; } // 0x000000018B1D5FAC-0x000000018B1D6010 
		public static bool runInBackground { get; set; } // 0x000000018B1D5F4C-0x000000018B1D5FAC 0x000000018B1D6894-0x000000018B1D6924
		public static InputMetrics metrics { get; } // 0x000000018B1D5C0C-0x000000018B1D5C90 
	
		// Events
		public static event Action<string, InputControlLayoutChange> onLayoutChange {
			add; // 0x000000018B1D5A08-0x000000018B1D5B14
			remove; // 0x000000018B1D66C0-0x000000018B1D67CC
		}
		public static event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange {
			add; // 0x0000000183DFA160-0x0000000183DFA450
			remove; // 0x000000018B1D62E4-0x000000018B1D644C
		}
		public static event InputDeviceCommandDelegate onDeviceCommand {
			add; // 0x000000018B1D58A0-0x000000018B1D5A08
			remove; // 0x000000018B1D644C-0x000000018B1D65B4
		}
		public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice {
			add; // 0x0000000183DF7C40-0x0000000183DF7EE0
			remove; // 0x000000018B1D65B4-0x000000018B1D66C0
		}
		public static event Action onBeforeUpdate {
			add; // 0x0000000183DFAB90-0x0000000183DFAE20
			remove; // 0x000000018B1D61D8-0x000000018B1D62E4
		}
		public static event Action onAfterUpdate {
			add; // 0x0000000183DFAE20-0x0000000183DFB0B0
			remove; // 0x000000018B1D60CC-0x000000018B1D61D8
		}
		public static event Action onSettingsChange {
			add; // 0x0000000183DFB0B0-0x0000000183DFB120
			remove; // 0x000000018B1D67CC-0x000000018B1D682C
		}
		public static event Action<object, InputActionChange> onActionChange {
			add; // 0x000000018B1D57E4-0x000000018B1D58A0
			remove; // 0x000000018B1D6010-0x000000018B1D60CC
		}
	
		// Nested types
		private struct StateEventBuffer // TypeDefIndex: 47448
		{
			// Fields
			public StateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x0232A14D
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x19
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _data_e__FixedBuffer // TypeDefIndex: 47447
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		private struct DeltaStateEventBuffer // TypeDefIndex: 47450
		{
			// Fields
			public DeltaStateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x0232A14F
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x1D
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _data_e__FixedBuffer // TypeDefIndex: 47449
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47451
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InputEventPtr, InputControl> __9__80_0; // 0x08
			public static Func<InputControl, bool> __9__80_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B1D8EC8-0x000000018B1D8F2C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal InputControl _get_onAnyButtonPress_b__80_0(InputEventPtr e); // 0x000000018B1D8E4C-0x000000018B1D8E64
			internal bool _get_onAnyButtonPress_b__80_1(InputControl c); // 0x000000018721682C-0x0000000187216834
		}
	
		// Constructors
		static InputSystem(); // 0x0000000183DF6D10-0x0000000183DF6D80
	
		// Methods
		public static void RegisterLayout(System.Type type, string name = null, InputDeviceMatcher? matches = default); // 0x0000000183AEC0D0-0x0000000183AEC240
		public static void RegisterLayout<T>(string name = null, InputDeviceMatcher? matches = default)
			where T : InputControl;
		public static void RegisterLayout(string json, string name = null, InputDeviceMatcher? matches = default); // 0x0000000183DF7060-0x0000000183DF7120
		public static void RegisterLayoutOverride(string json, string name = null); // 0x000000018B1D492C-0x000000018B1D49A0
		public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher); // 0x000000018B1D48BC-0x000000018B1D492C
		public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, InputDeviceMatcher? matches = default); // 0x000000018B1D470C-0x000000018B1D48BC
		public static void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new();
		public static void RemoveLayout(string name); // 0x000000018B1D4F4C-0x000000018B1D4FAC
		public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription); // 0x000000018B1D5368-0x000000018B1D53E8
		public static IEnumerable<string> ListLayouts(); // 0x000000018B1D3D6C-0x000000018B1D3DC4
		public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout); // 0x000000018B1D3CB4-0x000000018B1D3D6C
		public static InputControlLayout LoadLayout(string name); // 0x000000018B1D3E28-0x000000018B1D3F18
		public static InputControlLayout LoadLayout<TControl>()
			where TControl : InputControl;
		public static string GetNameOfBaseLayout(string layoutName); // 0x000000018B1D37B4-0x000000018B1D38C8
		public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName); // 0x000000018B1D39AC-0x000000018B1D3B30
		public static void RegisterProcessor(System.Type type, string name = null); // 0x000000018B1D49A0-0x000000018B1D4DCC
		public static void RegisterProcessor<T>(string name = null);
		public static System.Type TryGetProcessor(string name); // 0x000000018B1D5578-0x000000018B1D5640
		public static IEnumerable<string> ListProcessors(); // 0x000000018B1D3DC4-0x000000018B1D3E28
		public static UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, string variants = null); // 0x000000018B1D3088-0x000000018B1D31A0
		public static TDevice AddDevice<TDevice>(string name = null)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description); // 0x000000018B1D31A0-0x000000018B1D32A0
		public static void AddDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1D2FD4-0x000000018B1D3088
		public static void RemoveDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1D4EE8-0x000000018B1D4F4C
		public static void FlushDisconnectedDevices(); // 0x000000018B1D350C-0x000000018B1D3560
		public static UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout); // 0x000000018B1D3754-0x000000018B1D37B4
		public static TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice GetDevice(System.Type type); // 0x000000018B1D3560-0x000000018B1D3754
		public static TDevice GetDevice<TDevice>(InternedString usage)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static TDevice GetDevice<TDevice>(string usage)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId); // 0x00000001833FE6A0-0x00000001833FE7F0
		public static List<InputDeviceDescription> GetUnsupportedDevices(); // 0x000000018B1D38C8-0x000000018B1D394C
		public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions); // 0x000000018B1D394C-0x000000018B1D39AC
		public static void EnableDevice(UnityEngine.InputSystem.InputDevice device); // 0x0000000183DF9D80-0x0000000183DF9E00
		public static void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents = false /* Metadata: 0x0232A0E3 */); // 0x000000018B1D32E0-0x000000018B1D3354
		public static bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1D56AC-0x000000018B1D5790
		public static void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x0232A0E4 */); // 0x000000018B1D4FAC-0x000000018B1D502C
		[Obsolete("Use \'ResetDevice\' instead.", false)]
		public static bool TryResetDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1D5640-0x000000018B1D56AC
		public static void PauseHaptics(); // 0x000000018B1D3F18-0x000000018B1D4038
		public static void ResumeHaptics(); // 0x000000018B1D5150-0x000000018B1D5274
		public static void ResetHaptics(); // 0x000000018B1D502C-0x000000018B1D5150
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018B1D5274-0x000000018B1D52EC
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B1D52EC-0x000000018B1D5368
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018B1D2F34-0x000000018B1D2FD4
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B1D2EB8-0x000000018B1D2F34
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018B1D4E48-0x000000018B1D4EE8
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B1D4DCC-0x000000018B1D4E48
		public static InputControl FindControl(string path); // 0x000000018B1D3354-0x000000018B1D3494
		public static InputControlList<InputControl> FindControls(string path); // 0x000000018B1D3494-0x000000018B1D350C
		public static InputControlList<TControl> FindControls<TControl>(string path)
			where TControl : InputControl;
		public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl;
		public static void QueueEvent(InputEventPtr eventPtr); // 0x000000018B1D41D8-0x000000018B1D42A4
		public static void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo;
		public static void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time = -1 /* Metadata: 0x0232A0E5 */)
			where TState : struct, IInputStateTypeInfo;
		public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1 /* Metadata: 0x0232A0ED */)
			where TDelta : struct;
		public static void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time = -1 /* Metadata: 0x0232A0F5 */); // 0x000000018B1D4038-0x000000018B1D41D8
		public static void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time = -1 /* Metadata: 0x0232A0FD */); // 0x000000018B1D42A4-0x000000018B1D445C
		public static void Update(); // 0x000000018B1D5790-0x000000018B1D57E4
		internal static void Update(InputUpdateType updateType); // 0x0000000184B1EC20-0x0000000184B1ECA0
		public static void RegisterInteraction(System.Type type, string name = null); // 0x000000018B1D45B4-0x000000018B1D470C
		public static void RegisterInteraction<T>(string name = null);
		public static System.Type TryGetInteraction(string name); // 0x000000018B1D54B0-0x000000018B1D5578
		public static IEnumerable<string> ListInteractions(); // 0x000000018B1D3C50-0x000000018B1D3CB4
		public static void RegisterBindingComposite(System.Type type, string name); // 0x000000018B1D445C-0x000000018B1D45B4
		public static void RegisterBindingComposite<T>(string name = null);
		public static System.Type TryGetBindingComposite(string name); // 0x000000018B1D53E8-0x000000018B1D54B0
		public static void DisableAllEnabledActions(); // 0x000000018B1D32A0-0x000000018B1D32E0
		public static List<InputAction> ListEnabledActions(); // 0x000000018B1D3BCC-0x000000018B1D3C50
		public static int ListEnabledActions(List<InputAction> actions); // 0x000000018B1D3B30-0x000000018B1D3BCC
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RunInitializeInPlayer(); // 0x0000000184D5D0C0-0x0000000184D5D120
		internal static void EnsureInitialized(); // 0x00000001841E1670-0x00000001841E1680
		private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null); // 0x0000000183DF6D80-0x0000000183DF6F50
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RunInitialUpdate(); // 0x0000000184B1EB80-0x0000000184B1EC20
		private static void PerformDefaultPluginInitialization(); // 0x0000000183DF6F50-0x0000000183DF6F90
	}

	public static class CommonUsages // TypeDefIndex: 47453
	{
		// Fields
		public static readonly InternedString Primary2DMotion; // 0x00
		public static readonly InternedString Secondary2DMotion; // 0x10
		public static readonly InternedString PrimaryAction; // 0x20
		public static readonly InternedString SecondaryAction; // 0x30
		public static readonly InternedString PrimaryTrigger; // 0x40
		public static readonly InternedString SecondaryTrigger; // 0x50
		public static readonly InternedString Modifier; // 0x60
		public static readonly InternedString Position; // 0x70
		public static readonly InternedString Orientation; // 0x80
		public static readonly InternedString Hatswitch; // 0x90
		public static readonly InternedString Back; // 0xA0
		public static readonly InternedString Forward; // 0xB0
		public static readonly InternedString Menu; // 0xC0
		public static readonly InternedString Submit; // 0xD0
		public static readonly InternedString Cancel; // 0xE0
		public static readonly InternedString Horizontal; // 0xF0
		public static readonly InternedString Vertical; // 0x100
		public static readonly InternedString Twist; // 0x110
		public static readonly InternedString Pressure; // 0x120
		public static readonly InternedString ScrollHorizontal; // 0x130
		public static readonly InternedString ScrollVertical; // 0x140
		public static readonly InternedString Point; // 0x150
		public static readonly InternedString LowFreqMotor; // 0x160
		public static readonly InternedString HighFreqMotor; // 0x170
		public static readonly InternedString LeftHand; // 0x180
		public static readonly InternedString RightHand; // 0x190
		public static readonly InternedString BatteryStrength; // 0x1A0
	
		// Constructors
		static CommonUsages(); // 0x000000018B1C9A08-0x000000018B1CA3C8
	}

	[DebuggerDisplay("{DebuggerDisplay(),nq}")]
	public abstract class InputControl // TypeDefIndex: 47455
	{
		// Fields
		protected internal InputStateBlock m_StateBlock; // 0x10
		internal InternedString m_Name; // 0x20
		internal string m_Path; // 0x30
		internal string m_DisplayName; // 0x38
		internal string m_DisplayNameFromLayout; // 0x40
		internal string m_ShortDisplayName; // 0x48
		internal string m_ShortDisplayNameFromLayout; // 0x50
		internal InternedString m_Layout; // 0x58
		internal InternedString m_Variants; // 0x68
		internal UnityEngine.InputSystem.InputDevice m_Device; // 0x78
		internal InputControl m_Parent; // 0x80
		internal int m_UsageCount; // 0x88
		internal int m_UsageStartIndex; // 0x8C
		internal int m_AliasCount; // 0x90
		internal int m_AliasStartIndex; // 0x94
		internal int m_ChildCount; // 0x98
		internal int m_ChildStartIndex; // 0x9C
		internal ControlFlags m_ControlFlags; // 0xA0
		internal bool m_CachedValueIsStale; // 0xA4
		internal bool m_UnprocessedCachedValueIsStale; // 0xA5
		internal PrimitiveValue m_DefaultState; // 0xA8
		internal PrimitiveValue m_MinValue; // 0xB8
		internal PrimitiveValue m_MaxValue; // 0xC8
		internal FourCC m_OptimizedControlDataType; // 0xD8
	
		// Properties
		public string name { get; } // 0x0000000185395154-0x0000000185395174 
		public string displayName { get; protected set; } // 0x0000000183DF9B90-0x0000000183DF9BD0 0x00000001846A91B0-0x00000001846A91C0
		public string shortDisplayName { get; protected set; } // 0x000000018B1D0C04-0x000000018B1D0C38 0x00000001835A41A0-0x00000001835A41B0
		public string path { get; } // 0x000000018B1D0BB4-0x000000018B1D0C04 
		public string layout { get; } // 0x0000000185395174-0x0000000185395194 
		public string variants { get; } // 0x000000018B1D0D1C-0x000000018B1D0D3C 
		public UnityEngine.InputSystem.InputDevice device { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public InputControl parent { get; } // 0x0000000184D86260-0x0000000184D86270 
		public ReadOnlyArray<InputControl> children { get; } // 0x0000000183AF2640-0x0000000183AF2800 
		public ReadOnlyArray<InternedString> usages { get; } // 0x000000018B1D0CA4-0x000000018B1D0D1C 
		public ReadOnlyArray<InternedString> aliases { get; } // 0x0000000183AF04C0-0x0000000183AF0510 
		public InputStateBlock stateBlock { get; } // 0x0000000182B2D510-0x0000000182B2D520 
		public bool noisy { get; internal set; } // 0x00000001830D12E0-0x00000001830D12F0 0x000000018B1D0D3C-0x000000018B1D0E18
		public bool synthetic { get; internal set; } // 0x000000018B1D0C98-0x000000018B1D0CA4 0x00000001840D48E0-0x00000001840D4900
		public InputControl this[string path] { get => default; } // 0x000000018B1D0AB0-0x000000018B1D0B44 
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
		public float magnitude { get; } // 0x0000000185392E24-0x0000000185392E2C 
		protected internal unsafe void* currentStatePtr { get; } // 0x00000001830D11F0-0x00000001830D1250 
		protected internal unsafe void* previousFrameStatePtr { get; } // 0x000000018448E040-0x000000018448E060 
		protected internal unsafe void* defaultStatePtr { get; } // 0x000000018B1D0B44-0x000000018B1D0B7C 
		protected internal unsafe void* noiseMaskPtr { get; } // 0x000000018B1D0B7C-0x000000018B1D0BB4 
		protected internal uint stateOffsetRelativeToDeviceRoot { get; } // 0x000000018B1D0C38-0x000000018B1D0C98 
		public FourCC optimizedControlDataType { get; } // 0x0000000184D8F100-0x0000000184D8F110 
		internal bool isSetupFinished { get; set; } // 0x00000001840D2980-0x00000001840D2990 0x00000001840D09D0-0x00000001840D09F0
		internal bool isButton { get; set; } // 0x0000000183529300-0x0000000183529310 0x00000001840D5630-0x00000001840D5650
		internal bool isConfigUpToDate { get; set; } // 0x0000000183DF9C40-0x0000000183DF9C50 0x0000000183DF9C50-0x0000000183DF9C70
		internal bool dontReset { get; set; } // 0x0000000183AF0520-0x0000000183AF0530 0x0000000184A27DE0-0x0000000184A27E00
		internal bool usesStateFromOtherControl { get; set; } // 0x0000000183AF0510-0x0000000183AF0520 0x000000018B1D0E18-0x000000018B1D0E38
		internal bool hasDefaultState { get; } // 0x000000018426F5B0-0x000000018426F5C0 
	
		// Nested types
		[Flags]
		internal enum ControlFlags // TypeDefIndex: 47454
		{
			ConfigUpToDate = 1,
			IsNoisy = 2,
			IsSynthetic = 4,
			IsButton = 8,
			DontReset = 16,
			SetupFinished = 32,
			UsesStateFromOtherControl = 64
		}
	
		// Constructors
		protected InputControl(); // 0x0000000184550310-0x0000000184550350
	
		// Methods
		public override string ToString(); // 0x000000018B1D08E4-0x000000018B1D0950
		private string DebuggerDisplay(); // 0x000000018B1CFF64-0x000000018B1D0084
		public float EvaluateMagnitude(); // 0x000000018412A560-0x000000018412A660
		public virtual unsafe float EvaluateMagnitude(void* statePtr); // 0x0000000184DA9E10-0x0000000184DA9E20
		public abstract unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
		public abstract unsafe object ReadValueFromStateAsObject(void* statePtr);
		public abstract unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
		public virtual unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr); // 0x000000018B1D09C8-0x000000018B1D0A3C
		public virtual unsafe void WriteValueFromObjectIntoState(object value, void* statePtr); // 0x000000018B1D0A3C-0x000000018B1D0AB0
		public abstract unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr);
		public InputControl TryGetChildControl(string path); // 0x000000018B1D0950-0x000000018B1D09C8
		public TControl TryGetChildControl<TControl>(string path)
			where TControl : InputControl;
		public InputControl GetChildControl(string path); // 0x000000018B1D0424-0x000000018B1D0548
		public TControl GetChildControl<TControl>(string path)
			where TControl : InputControl;
		protected virtual void FinishSetup(); // 0x00000001841E1670-0x00000001841E1680
		protected void RefreshConfigurationIfNeeded(); // 0x0000000183DF9C10-0x0000000183DF9C40
		protected virtual void RefreshConfiguration(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual FourCC CalculateOptimizedControlDataType(); // 0x00000001811EC580-0x00000001811EC590
		public void ApplyParameterChanges(); // 0x000000018B1CFE70-0x000000018B1CFEB4
		private void SetOptimizedControlDataType(); // 0x000000018B1D0870-0x000000018B1D08E4
		internal void SetOptimizedControlDataTypeRecursively(); // 0x000000018B1D0724-0x000000018B1D0870
		[Conditional("UNITY_EDITOR")]
		internal void EnsureOptimizationTypeHasNotChanged(); // 0x000000018B1D0084-0x000000018B1D0424
		internal void CallFinishSetupRecursive(); // 0x000000018B1CFEB4-0x000000018B1CFF64
		internal string MakeChildPath(string path); // 0x000000018B1D0548-0x000000018B1D05C4
		internal void BakeOffsetIntoStateBlockRecursive(uint offset); // 0x0000000183AF20F0-0x0000000183AF2640
		internal int GetDeviceIndex(); // 0x00000001830D12A0-0x00000001830D12E0
		internal bool IsValueConsideredPressed(float value); // 0x0000000183529280-0x0000000183529300
		internal virtual void AddProcessor(object first); // 0x00000001841E1670-0x00000001841E1680
		internal void MarkAsStale(); // 0x0000000184DABDF0-0x0000000184DABE00
		internal void MarkAsStaleRecursively(); // 0x000000018B1D05C4-0x000000018B1D0724
	}

	public abstract class InputControl<TValue> : InputControl // TypeDefIndex: 47456
		where TValue : struct
	{
		// Fields
		internal InlinedArray<InputProcessor<TValue>> m_ProcessorStack;
		private TValue m_CachedValue;
		private TValue m_UnprocessedCachedValue;
		internal bool evaluateProcessorsEveryRead;
	
		// Properties
		public override System.Type valueType { get; }
		public override int valueSizeInBytes { get; }
		[IsReadOnly]
		public ref TValue value { get; }
		[IsReadOnly]
		internal ref TValue unprocessedValue { get; }
		internal InputProcessor<TValue>[] processors { get; }
	
		// Constructors
		protected InputControl();
	
		// Methods
		public TValue ReadValue();
		public TValue ReadValueFromPreviousFrame();
		public TValue ReadDefaultValue();
		public unsafe TValue ReadValueFromState(void* statePtr);
		public unsafe TValue ReadValueFromStateWithCaching(void* statePtr);
		public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr);
		public TValue ReadUnprocessedValue();
		public abstract unsafe TValue ReadUnprocessedValueFromState(void* statePtr);
		public override unsafe object ReadValueFromStateAsObject(void* statePtr);
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
		public override unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr);
		public override unsafe void WriteValueFromObjectIntoState(object value, void* statePtr);
		public virtual unsafe void WriteValueIntoState(TValue value, void* statePtr);
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
		private static bool CompareValue(ref ref TValue firstValue, ref ref TValue secondValue);
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr);
		public TValue ProcessValue(TValue value);
		public void ProcessValue(ref ref TValue value);
		internal TProcessor TryGetProcessor<TProcessor>()
			where TProcessor : InputProcessor<TValue>;
		internal override void AddProcessor(object processor);
		protected override void FinishSetup();
	}

	public static class InputControlExtensions // TypeDefIndex: 47463
	{
		// Nested types
		[Flags]
		public enum Enumerate // TypeDefIndex: 47457
		{
			IgnoreControlsInDefaultState = 1,
			IgnoreControlsInCurrentState = 2,
			IncludeSyntheticControls = 4,
			IncludeNoisyControls = 8,
			IncludeNonLeafControls = 16
		}
	
		public struct InputEventControlCollection : IEnumerable<InputControl> // TypeDefIndex: 47458
		{
			// Fields
			internal UnityEngine.InputSystem.InputDevice m_Device; // 0x00
			internal InputEventPtr m_EventPtr; // 0x08
			internal Enumerate m_Flags; // 0x10
			internal float m_MagnitudeThreshold; // 0x14
	
			// Properties
			public InputEventPtr eventPtr { get; } // 0x0000000184D88320-0x0000000184D88330 
	
			// Methods
			public InputEventControlEnumerator GetEnumerator(); // 0x000000018B1D1FA0-0x000000018B1D2010
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator(); // 0x000000018B1D2010-0x000000018B1D20A8
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D20A8-0x000000018B1D2140
		}
	
		public struct InputEventControlEnumerator : IEnumerator<InputControl> // TypeDefIndex: 47459
		{
			// Fields
			private Enumerate m_Flags; // 0x00
			private readonly UnityEngine.InputSystem.InputDevice m_Device; // 0x08
			private readonly uint[] m_StateOffsetToControlIndex; // 0x10
			private readonly int m_StateOffsetToControlIndexLength; // 0x18
			private readonly InputControl[] m_AllControls; // 0x20
			private unsafe byte* m_DefaultState; // 0x28
			private unsafe byte* m_CurrentState; // 0x30
			private unsafe byte* m_NoiseMask; // 0x38
			private InputEventPtr m_EventPtr; // 0x40
			private InputControl m_CurrentControl; // 0x48
			private int m_CurrentIndexInStateOffsetToControlIndexMap; // 0x50
			private uint m_CurrentControlStateBitOffset; // 0x54
			private unsafe byte* m_EventState; // 0x58
			private uint m_CurrentBitOffset; // 0x60
			private uint m_EndBitOffset; // 0x64
			private float m_MagnitudeThreshold; // 0x68
	
			// Properties
			public InputControl Current { get; } // 0x0000000184D86200-0x0000000184D86210 
			object IEnumerator.Current { get; } // 0x0000000184D86200-0x0000000184D86210 
	
			// Constructors
			internal unsafe InputEventControlEnumerator(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, Enumerate flags, float magnitudeThreshold = 0f /* Metadata: 0x0232A185 */); // 0x000000018B1D28F4-0x000000018B1D2A68
	
			// Methods
			private bool CheckDefault(uint numBits); // 0x000000018B1D2170-0x000000018B1D21A0
			private bool CheckCurrent(uint numBits); // 0x000000018B1D2140-0x000000018B1D2170
			public bool MoveNext(); // 0x000000018B1D21A0-0x000000018B1D256C
			public void Reset(); // 0x000000018B1D256C-0x000000018B1D28F4
			public void Dispose(); // 0x0000000184DABE70-0x0000000184DABE80
		}
	
		public struct ControlBuilder // TypeDefIndex: 47460
		{
			// Fields
			[CompilerGenerated]
			private InputControl _control_k__BackingField; // 0x00
	
			// Properties
			public InputControl control { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
	
			// Methods
			public ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index); // 0x000000018B1CA3C8-0x000000018B1CA450
			public ControlBuilder WithParent(InputControl parent); // 0x000000018B1CA650-0x000000018B1CA680
			public ControlBuilder WithName(string name); // 0x00000001841AC210-0x00000001841AC410
			public ControlBuilder WithDisplayName(string displayName); // 0x000000018B1CA584-0x000000018B1CA5E8
			public ControlBuilder WithShortDisplayName(string shortDisplayName); // 0x000000018B1CA680-0x000000018B1CA6E4
			public ControlBuilder WithLayout(InternedString layout); // 0x000000018B1CA5E8-0x000000018B1CA618
			public ControlBuilder WithUsages(int startIndex, int count); // 0x00000001840D5050-0x00000001840D5080
			public ControlBuilder WithAliases(int startIndex, int count); // 0x00000001840D5020-0x00000001840D5050
			public ControlBuilder WithChildren(int startIndex, int count); // 0x00000001840D5220-0x00000001840D5250
			public ControlBuilder WithStateBlock(InputStateBlock stateBlock); // 0x000000018B1CA6E4-0x000000018B1CA708
			public ControlBuilder WithDefaultState(PrimitiveValue value); // 0x000000018B1CA53C-0x000000018B1CA584
			public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max); // 0x000000018B1CA618-0x000000018B1CA650
			public ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor)
				where TProcessor : InputProcessor<TValue>
				where TValue : struct;
			public ControlBuilder IsNoisy(bool value); // 0x000000018B1CA4EC-0x000000018B1CA514
			public ControlBuilder IsSynthetic(bool value); // 0x000000018B1CA514-0x000000018B1CA53C
			public ControlBuilder DontReset(bool value); // 0x000000018B1CA450-0x000000018B1CA4A4
			public ControlBuilder IsButton(bool value); // 0x000000018B1CA4C4-0x000000018B1CA4EC
			public void Finish(); // 0x000000018B1CA4A4-0x000000018B1CA4C4
		}
	
		public struct DeviceBuilder // TypeDefIndex: 47461
		{
			// Fields
			[CompilerGenerated]
			private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x00
	
			// Properties
			public UnityEngine.InputSystem.InputDevice device { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
	
			// Methods
			public DeviceBuilder WithName(string name); // 0x00000001841AC210-0x00000001841AC410
			public DeviceBuilder WithDisplayName(string displayName); // 0x000000018B1CA584-0x000000018B1CA5E8
			public DeviceBuilder WithShortDisplayName(string shortDisplayName); // 0x000000018B1CA680-0x000000018B1CA6E4
			public DeviceBuilder WithLayout(InternedString layout); // 0x000000018B1CA5E8-0x000000018B1CA618
			public DeviceBuilder WithChildren(int startIndex, int count); // 0x00000001840D5220-0x00000001840D5250
			public DeviceBuilder WithStateBlock(InputStateBlock stateBlock); // 0x000000018B1CA6E4-0x000000018B1CA708
			public DeviceBuilder IsNoisy(bool value); // 0x000000018B1CA4EC-0x000000018B1CA514
			public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control); // 0x000000018B1CAB70-0x000000018B1CAC04
			public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias); // 0x000000018B1CA9EC-0x000000018B1CAA30
			public DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map); // 0x00000001841AC150-0x00000001841AC210
			public DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies); // 0x000000018B1CAA30-0x000000018B1CAB70
			public void Finish(); // 0x000000018B1CA708-0x000000018B1CA9EC
		}
	
		[CompilerGenerated]
		private sealed class _GetAllButtonPresses_d__43 : IEnumerable<InputControl>, IEnumerator<InputControl> // TypeDefIndex: 47462
		{
			// Fields
			private int __1__state; // 0x10
			private InputControl __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private InputEventPtr eventPtr; // 0x28
			public InputEventPtr __3__eventPtr; // 0x30
			private float magnitude; // 0x38
			public float __3__magnitude; // 0x3C
			private bool buttonControlsOnly; // 0x40
			public bool __3__buttonControlsOnly; // 0x41
			private InputEventControlEnumerator __7__wrap1; // 0x48
	
			// Properties
			InputControl IEnumerator<UnityEngine.InputSystem.InputControl>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllButtonPresses_d__43(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B1D8850-0x000000018B1D88C8
			private bool MoveNext(); // 0x000000018B1D8424-0x000000018B1D8764
			private void __m__Finally1(); // 0x0000000184DABE90-0x0000000184DABEB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1D8804-0x000000018B1D8850
			[DebuggerHidden]
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator(); // 0x000000018B1D8764-0x000000018B1D87FC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D87FC-0x000000018B1D8804
		}
	
		// Extension methods
		public static TControl FindInParentChain<TControl>(this InputControl control)
			where TControl : InputControl;
		public static bool IsPressed(this InputControl control, float buttonPressPoint = 0f /* Metadata: 0x0232A159 */); // 0x000000018B1CD0A0-0x000000018B1CD1C4
		public static bool IsActuated(this InputControl control, float threshold = 0f /* Metadata: 0x0232A15D */); // 0x000000018B1CCFF0-0x000000018B1CD0A0
		public static object ReadValueAsObject(this InputControl control); // 0x000000018B1CD23C-0x000000018B1CD2B8
		public static unsafe void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize); // 0x000000018B1CD348-0x000000018B1CD438
		public static object ReadDefaultValueAsObject(this InputControl control); // 0x000000018B1CD1C4-0x000000018B1CD23C
		public static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent)
			where TValue : struct;
		public static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct;
		public static object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent); // 0x000000018B1CD2B8-0x000000018B1CD348
		public static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr)
			where TValue : struct;
		public static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct;
		public static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, object value); // 0x000000018B1CD600-0x000000018B1CD6B0
		public static unsafe void WriteValueIntoState(this InputControl control, void* statePtr); // 0x000000018B1CD6B0-0x000000018B1CD874
		public static unsafe void WriteValueIntoState<TValue>(this InputControl control, TValue value, void* statePtr)
			where TValue : struct;
		public static unsafe void WriteValueIntoState<TValue>(this InputControl<TValue> control, TValue value, void* statePtr)
			where TValue : struct;
		public static unsafe void WriteValueIntoState<TValue>(this InputControl<TValue> control, void* statePtr)
			where TValue : struct;
		public static void WriteValueIntoState<TValue, TState>(this InputControl<TValue> control, TValue value, ref ref TState state)
			where TValue : struct
			where TState : struct, IInputStateTypeInfo;
		public static void WriteValueIntoEvent<TValue>(this InputControl control, TValue value, InputEventPtr eventPtr)
			where TValue : struct;
		public static void WriteValueIntoEvent<TValue>(this InputControl<TValue> control, TValue value, InputEventPtr eventPtr)
			where TValue : struct;
		public static unsafe void CopyState(this UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes); // 0x000000018B1CC440-0x000000018B1CC5C0
		public static void CopyState<TState>(this UnityEngine.InputSystem.InputDevice device, out ref TState state)
			where TState : struct, IInputStateTypeInfo;
		public static bool CheckStateIsAtDefault(this InputControl control); // 0x0000000183529450-0x00000001835294B0
		public static unsafe bool CheckStateIsAtDefault(this InputControl control, void* statePtr, void* maskPtr = null); // 0x00000001835294B0-0x0000000183529550
		public static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control); // 0x000000018B1CC0B0-0x000000018B1CC12C
		public static unsafe bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr); // 0x000000018B1CC12C-0x000000018B1CC24C
		public static unsafe bool CompareStateIgnoringNoise(this InputControl control, void* statePtr); // 0x000000018B1CC24C-0x000000018B1CC348
		public static unsafe bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null); // 0x0000000183529550-0x00000001835296B0
		public static unsafe bool CompareState(this InputControl control, void* statePtr, void* maskPtr = null); // 0x000000018B1CC348-0x000000018B1CC440
		public static unsafe bool HasValueChangeInState(this InputControl control, void* statePtr); // 0x000000018B1CCF14-0x000000018B1CCFF0
		public static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018B1CCE20-0x000000018B1CCF14
		public static unsafe void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018B1CCD20-0x000000018B1CCE08
		internal static unsafe void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType); // 0x000000018B1CCB00-0x000000018B1CCD20
		public static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018B1CD438-0x000000018B1CD600
		public static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x0232A161 */)
			where TValue : struct;
		public static unsafe void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState); // 0x000000018B1CBBAC-0x000000018B1CBCA0
		internal static unsafe void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState); // 0x000000018B1CBCA0-0x000000018B1CBD98
		public static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate)
			where TControl : InputControl;
		internal static string BuildPath(this InputControl control, string deviceLayout, StringBuilder builder = null); // 0x000000018B1CBD98-0x000000018B1CC0B0
		public static InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, Enumerate flags, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x0232A169 */); // 0x000000018B1CC604-0x000000018B1CC87C
		public static InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x0232A16D */); // 0x000000018B1CC5C0-0x000000018B1CC604
		public static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0232A171 */, bool buttonControlsOnly = true /* Metadata: 0x0232A175 */); // 0x000000018B1CCE08-0x000000018B1CCE20
		public static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0232A176 */, bool buttonControlsOnly = true /* Metadata: 0x0232A17A */); // 0x000000018B1CC904-0x000000018B1CCB00
		[IteratorStateMachine(typeof(_GetAllButtonPresses_d__43))]
		public static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0232A17B */, bool buttonControlsOnly = true /* Metadata: 0x0232A17F */); // 0x000000018B1CC87C-0x000000018B1CC904
		public static ControlBuilder Setup(this InputControl control); // 0x00000001840D2930-0x00000001840D2980
		public static DeviceBuilder Setup(this UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount); // 0x00000001840D27F0-0x00000001840D2930
	}

	public enum InputControlLayoutChange // TypeDefIndex: 47464
	{
		Added = 0,
		Removed = 1,
		Replaced = 2
	}

	[DebuggerDisplay("Count = {Count}")]
	public struct InputControlList<TControl> : IList<TControl>, IReadOnlyList<TControl>, IDisposable // TypeDefIndex: 47466
		where TControl : InputControl
	{
		// Fields
		private int m_Count;
		private NativeArray<ulong> m_Indices;
		private readonly Unity.Collections.Allocator m_Allocator;
		private const ulong kInvalidIndex = 18446744073709551615; // Metadata: 0x0232A196
	
		// Properties
		public int Count { get; }
		public int Capacity { get; set; }
		public bool IsReadOnly { get; }
		public TControl this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TControl> // TypeDefIndex: 47465
		{
			// Fields
			private readonly unsafe ulong* m_Indices;
			private readonly int m_Count;
			private int m_Current;
	
			// Properties
			public TControl Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public unsafe Enumerator(InputControlList<TControl> list);
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		public InputControlList(Unity.Collections.Allocator allocator, int initialCapacity = 0 /* Metadata: 0x0232A18C */);
		public InputControlList(IEnumerable<TControl> values, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A18D */);
		public InputControlList(params TControl[] values);
	
		// Methods
		public void Resize(int size);
		public void Add(TControl item);
		public void AddSlice<TList>(TList list, int count = -1 /* Metadata: 0x0232A18E */, int destinationIndex = -1 /* Metadata: 0x0232A18F */, int sourceIndex = 0 /* Metadata: 0x0232A190 */)
			where TList : IReadOnlyList<TControl>;
		public void AddRange(IEnumerable<TControl> list, int count = -1 /* Metadata: 0x0232A191 */, int destinationIndex = -1 /* Metadata: 0x0232A192 */);
		public bool Remove(TControl item);
		public void RemoveAt(int index);
		public void CopyTo(TControl[] array, int arrayIndex);
		public int IndexOf(TControl item);
		public int IndexOf(TControl item, int startIndex, int count = -1 /* Metadata: 0x0232A193 */);
		public void Insert(int index, TControl item);
		public void Clear();
		public bool Contains(TControl item);
		public bool Contains(TControl item, int startIndex, int count = -1 /* Metadata: 0x0232A194 */);
		public void SwapElements(int index1, int index2);
		public void Sort<TCompare>(int startIndex, int count, TCompare comparer)
			where TCompare : IComparer<TControl>;
		public TControl[] ToArray(bool dispose = false /* Metadata: 0x0232A195 */);
		internal void AppendTo(ref ref TControl[] array, ref int count);
		public void Dispose();
		public IEnumerator<TControl> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public override string ToString();
		private static ulong ToIndex(TControl control);
		private static TControl FromIndex(ulong index);
	}

	public static class InputControlPath // TypeDefIndex: 47474
	{
		// Fields
		public const string Wildcard = "*"; // Metadata: 0x0232A1A9
		public const string DoubleWildcard = "**"; // Metadata: 0x0232A1AB
		public const char Separator = '/'; // Metadata: 0x0232A1AE
		internal const char SeparatorReplacement = ' '; // Metadata: 0x0232A1B0
	
		// Nested types
		[Flags]
		public enum HumanReadableStringOptions // TypeDefIndex: 47467
		{
			None = 0,
			OmitDevice = 2,
			UseShortNames = 4
		}
	
		private enum PathComponentType // TypeDefIndex: 47468
		{
			Name = 0,
			DisplayName = 1,
			Usage = 2,
			Layout = 3
		}
	
		public struct ParsedPathComponent // TypeDefIndex: 47470
		{
			// Fields
			internal Substring m_Layout; // 0x00
			internal InlinedArray<Substring> m_Usages; // 0x10
			internal Substring m_Name; // 0x30
			internal Substring m_DisplayName; // 0x40
	
			// Properties
			public string layout { get; } // 0x000000018B1D7A60-0x000000018B1D7A68 
			public IEnumerable<string> usages { get; } // 0x000000018B1D7A74-0x000000018B1D7BB0 
			public string name { get; } // 0x000000018B1D7A68-0x000000018B1D7A74 
			public string displayName { get; } // 0x000000018B1D7974-0x000000018B1D7980 
			internal bool isWildcard { get; } // 0x000000018B1D79F0-0x000000018B1D7A60 
			internal bool isDoubleWildcard { get; } // 0x000000018B1D7980-0x000000018B1D79F0 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47469
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<Substring, string> __9__7_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B1D8E64-0x000000018B1D8EC8
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _get_usages_b__7_0(Substring x); // 0x000000018B1D8E38-0x000000018B1D8E4C
			}
	
			// Methods
			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options); // 0x000000018B1D71DC-0x000000018B1D7974
			private static string ToHumanReadableString(Substring substring); // 0x000000018B1D7190-0x000000018B1D71DC
			public bool Matches(InputControl control); // 0x000000018B1D6ECC-0x000000018B1D7190
			private static bool ComparePathElementToString(Substring pathElement, string element); // 0x000000018B1D6DDC-0x000000018B1D6ECC
		}
	
		private struct PathParser // TypeDefIndex: 47471
		{
			// Fields
			private string path; // 0x00
			private int length; // 0x08
			private int leftIndexInPath; // 0x0C
			private int rightIndexInPath; // 0x10
			public ParsedPathComponent current; // 0x18
	
			// Properties
			public bool isAtEnd { get; } // 0x000000018B1D7F54-0x000000018B1D7F60 
	
			// Constructors
			public PathParser(string path); // 0x000000018B1D7F10-0x000000018B1D7F54
	
			// Methods
			public bool MoveToNextComponent(); // 0x000000018B1D7BB0-0x000000018B1D7E40
			private Substring ParseComponentPart(char terminator); // 0x000000018B1D7E40-0x000000018B1D7F10
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47472
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Substring, string> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B1D8F2C-0x000000018B1D8F90
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _TryGetDeviceUsages_b__9_0(Substring x); // 0x000000018B1D8E38-0x000000018B1D8E4C
		}
	
		[CompilerGenerated]
		private sealed class _Parse_d__34 : IEnumerable<ParsedPathComponent>, IEnumerator<ParsedPathComponent> // TypeDefIndex: 47473
		{
			// Fields
			private int __1__state; // 0x10
			private ParsedPathComponent __2__current; // 0x18
			private int __l__initialThreadId; // 0x68
			private string path; // 0x70
			public string __3__path; // 0x78
			private PathParser _parser_5__2; // 0x80
	
			// Properties
			ParsedPathComponent IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.Current { [DebuggerHidden] get; } // 0x0000000184D9C000-0x0000000184D9C030 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1D8DB0-0x000000018B1D8E1C 
	
			// Constructors
			[DebuggerHidden]
			public _Parse_d__34(int __1__state); // 0x000000018B1D8E1C-0x000000018B1D8E38
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1D8B48-0x000000018B1D8CC8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1D8D64-0x000000018B1D8DB0
			[DebuggerHidden]
			IEnumerator<ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator(); // 0x000000018B1D8CC8-0x000000018B1D8D5C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1D8D5C-0x000000018B1D8D64
		}
	
		// Methods
		public static string Combine(InputControl parent, string path); // 0x000000018B1CD89C-0x000000018B1CD964
		public static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x0232A19E */, InputControl control = null); // 0x000000018B1CE5BC-0x000000018B1CE5F0
		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x0232A19F */, InputControl control = null); // 0x000000018B1CE5F0-0x000000018B1CEFE8
		public static string[] TryGetDeviceUsages(string path); // 0x000000018B1CF578-0x000000018B1CF71C
		public static string TryGetDeviceLayout(string path); // 0x000000018B1CF464-0x000000018B1CF578
		public static string TryGetControlLayout(string path); // 0x000000018B1CF244-0x000000018B1CF464
		private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName); // 0x000000018B1CDCD0-0x000000018B1CDE44
		private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout); // 0x000000018B1CDAF0-0x000000018B1CDCD0
		private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser); // 0x000000018B1CD964-0x000000018B1CDAF0
		private static bool StringMatches(Substring str, InternedString matchTo); // 0x000000018B1CE404-0x000000018B1CE5BC
		public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0232A1A0 */); // 0x000000018B1CF040-0x000000018B1CF098
		public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0232A1A1 */); // 0x000000018B1CF108-0x000000018B1CF244
		public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0 /* Metadata: 0x0232A1A2 */); // 0x000000018B1CF098-0x000000018B1CF108
		public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0232A1A3 */)
			where TControl : InputControl;
		public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches)
			where TControl : InputControl;
		public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0232A1A4 */); // 0x000000018B1CEFE8-0x000000018B1CF040
		public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0232A1A5 */)
			where TControl : InputControl;
		public static bool Matches(string expected, InputControl control); // 0x000000018B1CE280-0x000000018B1CE394
		internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false /* Metadata: 0x0232A1A6 */); // 0x000000018B1CDE44-0x000000018B1CE0EC
		public static bool MatchesPrefix(string expected, InputControl control); // 0x000000018B1CE0EC-0x000000018B1CE210
		private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false /* Metadata: 0x0232A1A7 */); // 0x000000018B1CE210-0x000000018B1CE280
		private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0 /* Metadata: 0x0232A1A8 */); // 0x0000000183AF0220-0x0000000183AF0480
		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath); // 0x000000018454BF40-0x000000018454BFC0
		[IteratorStateMachine(typeof(_Parse_d__34))]
		public static IEnumerable<ParsedPathComponent> Parse(string path); // 0x000000018B1CE394-0x000000018B1CE404
	
		// Extension methods
		internal static string CleanSlashes(this string pathComponent); // 0x000000018B1CD874-0x000000018B1CD89C
	}

	public abstract class InputProcessor // TypeDefIndex: 47476
	{
		// Fields
		internal static TypeTable s_Processors; // 0x00
	
		// Properties
		public virtual CachingPolicy cachingPolicy { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Nested types
		public enum CachingPolicy // TypeDefIndex: 47475
		{
			CacheResult = 0,
			EvaluateOnEveryRead = 1
		}
	
		// Constructors
		protected InputProcessor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract object ProcessAsObject(object value, InputControl control);
		public abstract unsafe void Process(void* buffer, int bufferSize, InputControl control);
		internal static System.Type GetValueTypeFromType(System.Type processorType); // 0x000000018B1D2DE4-0x000000018B1D2EB8
	}

	public abstract class InputProcessor<TValue> : InputProcessor // TypeDefIndex: 47477
		where TValue : struct
	{
		// Constructors
		protected InputProcessor();
	
		// Methods
		public abstract TValue Process(TValue value, InputControl control);
		public override object ProcessAsObject(object value, InputControl control);
		public override unsafe void Process(void* buffer, int bufferSize, InputControl control);
	}

	[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = true)]
	public class Gamepad : UnityEngine.InputSystem.InputDevice, IDualMotorRumble // TypeDefIndex: 47478
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _buttonWest_k__BackingField; // 0x190
		[CompilerGenerated]
		private ButtonControl _buttonNorth_k__BackingField; // 0x198
		[CompilerGenerated]
		private ButtonControl _buttonSouth_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private ButtonControl _buttonEast_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private ButtonControl _leftStickButton_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _rightStickButton_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private ButtonControl _startButton_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _selectButton_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private DpadControl _dpad_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _leftShoulder_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _rightShoulder_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private StickControl _leftStick_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private StickControl _rightStick_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private ButtonControl _leftTrigger_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private ButtonControl _rightTrigger_k__BackingField; // 0x200
		[CompilerGenerated]
		private static Gamepad _current_k__BackingField; // 0x00
		private DualMotorRumble m_Rumble; // 0x208
		private static int s_GamepadCount; // 0x08
		private static Gamepad[] s_Gamepads; // 0x10
	
		// Properties
		public ButtonControl buttonWest { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public ButtonControl buttonNorth { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public ButtonControl buttonSouth { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		public ButtonControl buttonEast { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public ButtonControl leftStickButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		public ButtonControl rightStickButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		public ButtonControl startButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public ButtonControl selectButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		public DpadControl dpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		public ButtonControl leftShoulder { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		public ButtonControl rightShoulder { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		public StickControl leftStick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		public StickControl rightStick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		public ButtonControl leftTrigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		public ButtonControl rightTrigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		public ButtonControl aButton { get; } // 0x0000000184D8DA10-0x0000000184D8DA20 
		public ButtonControl bButton { get; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 
		public ButtonControl xButton { get; } // 0x0000000184D8DD50-0x0000000184D8DD60 
		public ButtonControl yButton { get; } // 0x0000000184D8DED0-0x0000000184D8DEE0 
		public ButtonControl triangleButton { get; } // 0x0000000184D8DED0-0x0000000184D8DEE0 
		public ButtonControl squareButton { get; } // 0x0000000184D8DD50-0x0000000184D8DD60 
		public ButtonControl circleButton { get; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 
		public ButtonControl crossButton { get; } // 0x0000000184D8DA10-0x0000000184D8DA20 
		public ButtonControl this[GamepadButton button] { get => default; } // 0x000000018B1CB56C-0x000000018B1CB788 
		public static Gamepad current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1CB7F8-0x000000018B1CB830 0x000000018B1CB830-0x000000018B1CB880
		public static new ReadOnlyArray<Gamepad> all { get; } // 0x000000018B1CB788-0x000000018B1CB7F8 
	
		// Constructors
		public Gamepad(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1CB080-0x000000018B1CB3E4
		public override void MakeCurrent(); // 0x000000018B1CB3E4-0x000000018B1CB3EC
		protected override void OnAdded(); // 0x000000018B1CB3EC-0x000000018B1CB45C
		protected override void OnRemoved(); // 0x000000018B1CB45C-0x000000018B1CB508
		public virtual void PauseHaptics(); // 0x000000018B1CB508-0x000000018B1CB51C
		public virtual void ResumeHaptics(); // 0x000000018B1CB530-0x000000018B1CB544
		public virtual void ResetHaptics(); // 0x000000018B1CB51C-0x000000018B1CB530
		public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018B1CB544-0x000000018B1CB56C
	}

	public class InputDevice : InputControl // TypeDefIndex: 47481
	{
		// Fields
		public const int InvalidDeviceId = 0; // Metadata: 0x0232A1BC
		internal const int kLocalParticipantId = 0; // Metadata: 0x0232A1BD
		internal const int kInvalidDeviceIndex = -1; // Metadata: 0x0232A1BE
		internal DeviceFlags m_DeviceFlags; // 0xE0
		internal int m_DeviceId; // 0xE4
		internal int m_ParticipantId; // 0xE8
		internal int m_DeviceIndex; // 0xEC
		internal uint m_CurrentProcessedEventBytesOnUpdate; // 0xF0
		internal InputDeviceDescription m_Description; // 0xF8
		internal double m_LastUpdateTimeInternal; // 0x130
		internal uint m_CurrentUpdateStepCount; // 0x138
		internal InternedString[] m_AliasesForEachControl; // 0x140
		internal InternedString[] m_UsagesForEachControl; // 0x148
		internal InputControl[] m_UsageToControl; // 0x150
		internal InputControl[] m_ChildrenForEachControl; // 0x158
		internal HashSet<int> m_UpdatedButtons; // 0x160
		internal List<ButtonControl> m_ButtonControlsCheckingPressState; // 0x168
		internal bool m_UseCachePathForButtonPresses; // 0x170
		internal uint[] m_StateOffsetToControlMap; // 0x178
		internal ControlBitRangeNode[] m_ControlTreeNodes; // 0x180
		internal ushort[] m_ControlTreeIndices; // 0x188
		internal const int kControlIndexBits = 10; // Metadata: 0x0232A1BF
		internal const int kStateOffsetBits = 13; // Metadata: 0x0232A1C0
		internal const int kStateSizeBits = 9; // Metadata: 0x0232A1C1
	
		// Properties
		public InputDeviceDescription description { get; } // 0x0000000184DABE30-0x0000000184DABE70 
		public bool enabled { get; } // 0x00000001830CDAC0-0x00000001830CDB50 
		public bool canRunInBackground { get; } // 0x0000000185393A9C-0x0000000185393AA4 
		internal bool canDeviceRunInBackground { get; } // 0x0000000184750930-0x0000000184750A00 
		public bool added { get; } // 0x000000018381FC40-0x000000018381FC50 
		public bool remote { get; } // 0x000000018B1D1EB8-0x000000018B1D1EC4 
		public bool native { get; } // 0x0000000184D1F000-0x0000000184D1F010 
		public bool updateBeforeRender { get; } // 0x0000000183AE8890-0x0000000183AE88A0 
		public int deviceId { get; } // 0x0000000184DA3670-0x0000000184DA3680 
		public double lastUpdateTime { get; } // 0x000000018B1D1E70-0x000000018B1D1EB8 
		public bool wasUpdatedThisFrame { get; } // 0x0000000184664C40-0x0000000184664C90 
		public ReadOnlyArray<InputControl> allControls { get; } // 0x0000000184461DF0-0x0000000184461E20 
		public override System.Type valueType { get; } // 0x000000018B1D1F10-0x000000018B1D1F60 
		public override int valueSizeInBytes { get; } // 0x000000018B1D1EC4-0x000000018B1D1F10 
		[Obsolete("Use \'InputSystem.devices\' instead. (UnityUpgradable) -> InputSystem.devices", false)]
		public static ReadOnlyArray<InputDevice> all { get; } // 0x000000018B1D1E20-0x000000018B1D1E70 
		internal bool disabledInFrontend { get; set; } // 0x0000000183820730-0x0000000183820740 0x000000018B1D1F60-0x000000018B1D1F80
		internal bool disabledInRuntime { get; set; } // 0x0000000183820720-0x0000000183820730 0x00000001838202B0-0x00000001838202E0
		internal bool disabledWhileInBackground { get; set; } // 0x00000001838202A0-0x00000001838202B0 0x000000018381FF80-0x00000001838200C0
		internal bool hasControlsWithDefaultState { get; set; } // 0x0000000184D80970-0x0000000184D80980 0x0000000184D30E00-0x0000000184D30E20
		internal bool hasDontResetControls { get; set; } // 0x000000018381FC70-0x000000018381FC90 0x0000000184A27E00-0x0000000184A27E80
		internal bool hasStateCallbacks { get; set; } // 0x00000001830D1A50-0x00000001830D1A60 0x000000018B1D1F80-0x000000018B1D1FA0
		internal bool hasEventMerger { get; set; } // 0x00000001830CDBE0-0x00000001830CDBF0 0x0000000183AE82F0-0x0000000183AE8310
		internal bool hasEventPreProcessor { get; set; } // 0x00000001841D18C0-0x00000001841D18D0 0x0000000183AE8310-0x0000000183AE8330
	
		// Nested types
		[Serializable]
		[Flags]
		internal enum DeviceFlags // TypeDefIndex: 47479
		{
			UpdateBeforeRender = 1,
			HasStateCallbacks = 2,
			HasControlsWithDefaultState = 4,
			Remote = 8,
			Native = 16,
			DisabledInFrontend = 32,
			DisabledStateHasBeenQueriedFromRuntime = 64,
			DisabledInRuntime = 128,
			DisabledWhileInBackground = 256,
			HasDontResetControls = 1024,
			CanRunInBackground = 2048,
			CanRunInBackgroundHasBeenQueried = 4096,
			HasEventMerger = 8192,
			HasEventPreProcessor = 16384
		}
	
		internal struct ControlBitRangeNode // TypeDefIndex: 47480
		{
			// Fields
			public ushort endBitOffset; // 0x00
			public short leftChildIndex; // 0x02
			public ushort controlStartIndex; // 0x04
			public byte controlCount; // 0x06
	
			// Constructors
			public ControlBitRangeNode(ushort endOffset); // 0x0000000184DABEB0-0x0000000184DABEC0
		}
	
		// Constructors
		public InputDevice(); // 0x000000018B1D1DF4-0x000000018B1D1E20
	
		// Methods
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize); // 0x000000018B1D1640-0x000000018B1D168C
		public override unsafe object ReadValueFromStateAsObject(void* statePtr); // 0x000000018B1D168C-0x000000018B1D176C
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize); // 0x000000018B1D176C-0x000000018B1D1964
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr); // 0x000000018B1D0F38-0x000000018B1D1070
		internal void NotifyConfigurationChanged(); // 0x000000018B1D15C8-0x000000018B1D1630
		public virtual void MakeCurrent(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAdded(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRemoved(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnConfigurationChanged(); // 0x00000001841E1670-0x00000001841E1680
		public long ExecuteCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
		protected virtual unsafe long ExecuteCommand(InputDeviceCommand* commandPtr); // 0x0000000184320670-0x0000000184320710
		internal bool QueryEnabledStateFromRuntime(); // 0x00000001830CDB50-0x00000001830CDBE0
		internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits); // 0x0000000184DABE20-0x0000000184DABE30
		internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize); // 0x0000000184DABE00-0x0000000184DABE20
		internal void AddDeviceUsage(InternedString usage); // 0x000000018B1D0E38-0x000000018B1D0EE0
		internal void RemoveDeviceUsage(InternedString usage); // 0x000000018B1D1964-0x000000018B1D1A34
		internal void ClearDeviceUsages(); // 0x000000018B1D0EE0-0x000000018B1D0F38
		internal bool RequestSync(); // 0x00000001838208A0-0x0000000183820920
		internal bool RequestReset(); // 0x000000018B1D1A34-0x000000018B1D1AA8
		internal bool ExecuteEnableCommand(); // 0x0000000183820820-0x00000001838208A0
		internal bool ExecuteDisableCommand(); // 0x00000001838207A0-0x0000000183820820
		internal void NotifyAdded(); // 0x00000001853950CC-0x00000001853950DC
		internal void NotifyRemoved(); // 0x000000018B1D1630-0x000000018B1D1640
		internal static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = default, bool noPrecompiledLayouts = false /* Metadata: 0x0232A1BB */)
			where TDevice : InputDevice;
		internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice); // 0x00000001841EFF10-0x00000001841F0020
		private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset); // 0x000000018B1D1AA8-0x000000018B1D1DF4
		private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output); // 0x000000018B1D1070-0x000000018B1D138C
		private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<string> output); // 0x000000018B1D138C-0x000000018B1D14F4
		internal string DumpControlTree(); // 0x000000018B1D14F4-0x000000018B1D15C8
		private unsafe void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset); // 0x00000001835298C0-0x0000000183529D30
		private static unsafe bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits); // 0x0000000183529D30-0x0000000183529D60
	}

	public enum InputDeviceChange // TypeDefIndex: 47482
	{
		Added = 0,
		Removed = 1,
		Disconnected = 2,
		Reconnected = 3,
		Enabled = 4,
		Disabled = 5,
		UsageChanged = 6,
		ConfigurationChanged = 7,
		SoftReset = 8,
		HardReset = 9,
		Destroyed = 10
	}

	[InputControlLayout(stateType = typeof(UnityEngine.InputSystem.LowLevel.JoystickState), isGenericTypeOfDevice = true)]
	public class Joystick : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 47483
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _trigger_k__BackingField; // 0x190
		[CompilerGenerated]
		private StickControl _stick_k__BackingField; // 0x198
		[CompilerGenerated]
		private AxisControl _twist_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private Vector2Control _hatswitch_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private static Joystick _current_k__BackingField; // 0x00
		private static int s_JoystickCount; // 0x08
		private static Joystick[] s_Joysticks; // 0x10
	
		// Properties
		public ButtonControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public StickControl stick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public AxisControl twist { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		public Vector2Control hatswitch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public static Joystick current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1D95A0-0x000000018B1D95D8 0x000000018B1D95D8-0x000000018B1D9628
		public static new ReadOnlyArray<Joystick> all { get; } // 0x000000018B1D9530-0x000000018B1D95A0 
	
		// Constructors
		public Joystick(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1D92C4-0x000000018B1D93E8
		public override void MakeCurrent(); // 0x000000018B1D93E8-0x000000018B1D93F0
		protected override void OnAdded(); // 0x000000018B1D93F0-0x000000018B1D9460
		protected override void OnRemoved(); // 0x000000018B1D9460-0x000000018B1D9530
	}

	public enum Key // TypeDefIndex: 47484
	{
		None = 0,
		Space = 1,
		Enter = 2,
		Tab = 3,
		Backquote = 4,
		Quote = 5,
		Semicolon = 6,
		Comma = 7,
		Period = 8,
		Slash = 9,
		Backslash = 10,
		LeftBracket = 11,
		RightBracket = 12,
		Minus = 13,
		Equals = 14,
		A = 15,
		B = 16,
		C = 17,
		D = 18,
		E = 19,
		F = 20,
		G = 21,
		H = 22,
		I = 23,
		J = 24,
		K = 25,
		L = 26,
		M = 27,
		N = 28,
		O = 29,
		P = 30,
		Q = 31,
		R = 32,
		S = 33,
		T = 34,
		U = 35,
		V = 36,
		W = 37,
		X = 38,
		Y = 39,
		Z = 40,
		Digit1 = 41,
		Digit2 = 42,
		Digit3 = 43,
		Digit4 = 44,
		Digit5 = 45,
		Digit6 = 46,
		Digit7 = 47,
		Digit8 = 48,
		Digit9 = 49,
		Digit0 = 50,
		LeftShift = 51,
		RightShift = 52,
		LeftAlt = 53,
		RightAlt = 54,
		AltGr = 54,
		LeftCtrl = 55,
		RightCtrl = 56,
		LeftMeta = 57,
		LeftWindows = 57,
		LeftApple = 57,
		LeftCommand = 57,
		RightMeta = 58,
		RightWindows = 58,
		RightApple = 58,
		RightCommand = 58,
		ContextMenu = 59,
		Escape = 60,
		LeftArrow = 61,
		RightArrow = 62,
		UpArrow = 63,
		DownArrow = 64,
		Backspace = 65,
		PageDown = 66,
		PageUp = 67,
		Home = 68,
		End = 69,
		Insert = 70,
		Delete = 71,
		CapsLock = 72,
		NumLock = 73,
		PrintScreen = 74,
		ScrollLock = 75,
		Pause = 76,
		NumpadEnter = 77,
		NumpadDivide = 78,
		NumpadMultiply = 79,
		NumpadPlus = 80,
		NumpadMinus = 81,
		NumpadPeriod = 82,
		NumpadEquals = 83,
		Numpad0 = 84,
		Numpad1 = 85,
		Numpad2 = 86,
		Numpad3 = 87,
		Numpad4 = 88,
		Numpad5 = 89,
		Numpad6 = 90,
		Numpad7 = 91,
		Numpad8 = 92,
		Numpad9 = 93,
		F1 = 94,
		F2 = 95,
		F3 = 96,
		F4 = 97,
		F5 = 98,
		F6 = 99,
		F7 = 100,
		F8 = 101,
		F9 = 102,
		F10 = 103,
		F11 = 104,
		F12 = 105,
		OEM1 = 106,
		OEM2 = 107,
		OEM3 = 108,
		OEM4 = 109,
		OEM5 = 110,
		IMESelected = 111,
		F13 = 112,
		F14 = 113,
		F15 = 114,
		F16 = 115,
		F17 = 116,
		F18 = 117,
		F19 = 118,
		F20 = 119,
		F21 = 120,
		F22 = 121,
		F23 = 122,
		F24 = 123
	}

	internal static class KeyEx // TypeDefIndex: 47485
	{
		// Fields
		internal const UnityEngine.InputSystem.Key IMESelected = UnityEngine.InputSystem.Key.IMESelected; // Metadata: 0x0232A2A6
		internal const UnityEngine.InputSystem.Key RemappedIMESelected = (UnityEngine.InputSystem.Key) 127; // Metadata: 0x0232A2A8
	}

	[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
	public class Keyboard : UnityEngine.InputSystem.InputDevice, ITextInputReceiver, IEventPreProcessor // TypeDefIndex: 47486
	{
		// Fields
		public const int KeyCount = 110; // Metadata: 0x0232A2AA
		internal const int ExtendedKeyCount = 123; // Metadata: 0x0232A2AC
		[CompilerGenerated]
		private AnyKeyControl _anyKey_k__BackingField; // 0x190
		[CompilerGenerated]
		private ButtonControl _shiftKey_k__BackingField; // 0x198
		[CompilerGenerated]
		private ButtonControl _ctrlKey_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private ButtonControl _altKey_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private ButtonControl _imeSelected_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private static Keyboard _current_k__BackingField; // 0x00
		private InlinedArray<Action<char>> m_TextInputListeners; // 0x1B8
		private string m_KeyboardLayoutName; // 0x1D0
		private KeyControl[] m_Keys; // 0x1D8
		private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners; // 0x1E0
	
		// Properties
		public string keyboardLayout { get; protected set; } // 0x000000018B1DB0D0-0x000000018B1DB0F0 0x0000000186B8B0F8-0x0000000186B8B10C
		public AnyKeyControl anyKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public KeyControl spaceKey { get; } // 0x000000018B1DB440-0x000000018B1DB450 
		public KeyControl enterKey { get; } // 0x000000018B1DAEA0-0x000000018B1DAEB0 
		public KeyControl tabKey { get; } // 0x000000018B1DB460-0x000000018B1DB470 
		public KeyControl backquoteKey { get; } // 0x000000018B1DAD08-0x000000018B1DAD18 
		public KeyControl quoteKey { get; } // 0x000000018B1DB380-0x000000018B1DB390 
		public KeyControl semicolonKey { get; } // 0x000000018B1DB420-0x000000018B1DB430 
		public KeyControl commaKey { get; } // 0x000000018B1DAD58-0x000000018B1DAD68 
		public KeyControl periodKey { get; } // 0x000000018B1DB350-0x000000018B1DB360 
		public KeyControl slashKey { get; } // 0x000000018B1DB430-0x000000018B1DB440 
		public KeyControl backslashKey { get; } // 0x000000018B1DAD18-0x000000018B1DAD28 
		public KeyControl leftBracketKey { get; } // 0x000000018B1DB130-0x000000018B1DB140 
		public KeyControl rightBracketKey { get; } // 0x000000018B1DB3D0-0x000000018B1DB3E0 
		public KeyControl minusKey { get; } // 0x000000018B1DB170-0x000000018B1DB180 
		public KeyControl equalsKey { get; } // 0x000000018B1DAEB0-0x000000018B1DAEC0 
		public KeyControl aKey { get; } // 0x000000018B1DAC90-0x000000018B1DACA0 
		public KeyControl bKey { get; } // 0x000000018B1DACF8-0x000000018B1DAD08 
		public KeyControl cKey { get; } // 0x000000018B1DAD38-0x000000018B1DAD48 
		public KeyControl dKey { get; } // 0x000000018B1DADB0-0x000000018B1DADC0 
		public KeyControl eKey { get; } // 0x000000018B1DAE80-0x000000018B1DAE90 
		public KeyControl fKey { get; } // 0x000000018B1DB050-0x000000018B1DB060 
		public KeyControl gKey { get; } // 0x000000018B1DB060-0x000000018B1DB070 
		public KeyControl hKey { get; } // 0x000000018B1DB070-0x000000018B1DB080 
		public KeyControl iKey { get; } // 0x000000018B1DB090-0x000000018B1DB0A0 
		public KeyControl jKey { get; } // 0x000000018B1DB0B0-0x000000018B1DB0C0 
		public KeyControl kKey { get; } // 0x000000018B1DB0C0-0x000000018B1DB0D0 
		public KeyControl lKey { get; } // 0x000000018B1DB0F0-0x000000018B1DB100 
		public KeyControl mKey { get; } // 0x000000018B1DB160-0x000000018B1DB170 
		public KeyControl nKey { get; } // 0x000000018B1DB180-0x000000018B1DB190 
		public KeyControl oKey { get; } // 0x000000018B1DB2B0-0x000000018B1DB2C0 
		public KeyControl pKey { get; } // 0x000000018B1DB310-0x000000018B1DB320 
		public KeyControl qKey { get; } // 0x000000018B1DB370-0x000000018B1DB380 
		public KeyControl rKey { get; } // 0x000000018B1DB390-0x000000018B1DB3A0 
		public KeyControl sKey { get; } // 0x000000018B1DB400-0x000000018B1DB410 
		public KeyControl tKey { get; } // 0x000000018B1DB450-0x000000018B1DB460 
		public KeyControl uKey { get; } // 0x000000018B1DB470-0x000000018B1DB480 
		public KeyControl vKey { get; } // 0x000000018B1DB490-0x000000018B1DB4A0 
		public KeyControl wKey { get; } // 0x000000018B1DB4A0-0x000000018B1DB4B0 
		public KeyControl xKey { get; } // 0x000000018B1DB4B0-0x000000018B1DB4C0 
		public KeyControl yKey { get; } // 0x000000018B1DB4C0-0x000000018B1DB4D0 
		public KeyControl zKey { get; } // 0x000000018B1DB4D0-0x000000018B1DB4E0 
		public KeyControl digit1Key { get; } // 0x000000018B1DADE0-0x000000018B1DADF0 
		public KeyControl digit2Key { get; } // 0x000000018B1DADF0-0x000000018B1DAE00 
		public KeyControl digit3Key { get; } // 0x000000018B1DAE00-0x000000018B1DAE10 
		public KeyControl digit4Key { get; } // 0x000000018B1DAE10-0x000000018B1DAE20 
		public KeyControl digit5Key { get; } // 0x000000018B1DAE20-0x000000018B1DAE30 
		public KeyControl digit6Key { get; } // 0x000000018B1DAE30-0x000000018B1DAE40 
		public KeyControl digit7Key { get; } // 0x000000018B1DAE40-0x000000018B1DAE50 
		public KeyControl digit8Key { get; } // 0x000000018B1DAE50-0x000000018B1DAE60 
		public KeyControl digit9Key { get; } // 0x000000018B1DAE60-0x000000018B1DAE70 
		public KeyControl digit0Key { get; } // 0x000000018B1DADD0-0x000000018B1DADE0 
		public KeyControl leftShiftKey { get; } // 0x000000018B1DB150-0x000000018B1DB160 
		public KeyControl rightShiftKey { get; } // 0x000000018B1DB3F0-0x000000018B1DB400 
		public KeyControl leftAltKey { get; } // 0x000000018B1DB100-0x000000018B1DB110 
		public KeyControl rightAltKey { get; } // 0x000000018B1DB3A0-0x000000018B1DB3B0 
		public KeyControl leftCtrlKey { get; } // 0x000000018B1DB140-0x000000018B1DB150 
		public KeyControl rightCtrlKey { get; } // 0x000000018B1DB3E0-0x000000018B1DB3F0 
		public KeyControl leftMetaKey { get; } // 0x000000018B1DB110-0x000000018B1DB120 
		public KeyControl rightMetaKey { get; } // 0x000000018B1DB3B0-0x000000018B1DB3C0 
		public KeyControl leftWindowsKey { get; } // 0x000000018B1DB110-0x000000018B1DB120 
		public KeyControl rightWindowsKey { get; } // 0x000000018B1DB3B0-0x000000018B1DB3C0 
		public KeyControl leftAppleKey { get; } // 0x000000018B1DB110-0x000000018B1DB120 
		public KeyControl rightAppleKey { get; } // 0x000000018B1DB3B0-0x000000018B1DB3C0 
		public KeyControl leftCommandKey { get; } // 0x000000018B1DB110-0x000000018B1DB120 
		public KeyControl rightCommandKey { get; } // 0x000000018B1DB3B0-0x000000018B1DB3C0 
		public KeyControl contextMenuKey { get; } // 0x000000018B1DAD68-0x000000018B1DAD78 
		public KeyControl escapeKey { get; } // 0x000000018B1DAEC0-0x000000018B1DAED0 
		public KeyControl leftArrowKey { get; } // 0x000000018B1DB120-0x000000018B1DB130 
		public KeyControl rightArrowKey { get; } // 0x000000018B1DB3C0-0x000000018B1DB3D0 
		public KeyControl upArrowKey { get; } // 0x000000018B1DB480-0x000000018B1DB490 
		public KeyControl downArrowKey { get; } // 0x000000018B1DAE70-0x000000018B1DAE80 
		public KeyControl backspaceKey { get; } // 0x000000018B1DAD28-0x000000018B1DAD38 
		public KeyControl pageDownKey { get; } // 0x000000018B1DB320-0x000000018B1DB330 
		public KeyControl pageUpKey { get; } // 0x000000018B1DB330-0x000000018B1DB340 
		public KeyControl homeKey { get; } // 0x000000018B1DB080-0x000000018B1DB090 
		public KeyControl endKey { get; } // 0x000000018B1DAE90-0x000000018B1DAEA0 
		public KeyControl insertKey { get; } // 0x000000018B1DB0A0-0x000000018B1DB0B0 
		public KeyControl deleteKey { get; } // 0x000000018B1DADC0-0x000000018B1DADD0 
		public KeyControl capsLockKey { get; } // 0x000000018B1DAD48-0x000000018B1DAD58 
		public KeyControl scrollLockKey { get; } // 0x000000018B1DB410-0x000000018B1DB420 
		public KeyControl numLockKey { get; } // 0x000000018B1DB190-0x000000018B1DB1A0 
		public KeyControl printScreenKey { get; } // 0x000000018B1DB360-0x000000018B1DB370 
		public KeyControl pauseKey { get; } // 0x000000018B1DB340-0x000000018B1DB350 
		public KeyControl numpadEnterKey { get; } // 0x000000018B1DB250-0x000000018B1DB260 
		public KeyControl numpadDivideKey { get; } // 0x000000018B1DB240-0x000000018B1DB250 
		public KeyControl numpadMultiplyKey { get; } // 0x000000018B1DB280-0x000000018B1DB290 
		public KeyControl numpadMinusKey { get; } // 0x000000018B1DB270-0x000000018B1DB280 
		public KeyControl numpadPlusKey { get; } // 0x000000018B1DB2A0-0x000000018B1DB2B0 
		public KeyControl numpadPeriodKey { get; } // 0x000000018B1DB290-0x000000018B1DB2A0 
		public KeyControl numpadEqualsKey { get; } // 0x000000018B1DB260-0x000000018B1DB270 
		public KeyControl numpad0Key { get; } // 0x000000018B1DB1A0-0x000000018B1DB1B0 
		public KeyControl numpad1Key { get; } // 0x000000018B1DB1B0-0x000000018B1DB1C0 
		public KeyControl numpad2Key { get; } // 0x000000018B1DB1C0-0x000000018B1DB1D0 
		public KeyControl numpad3Key { get; } // 0x000000018B1DB1D0-0x000000018B1DB1E0 
		public KeyControl numpad4Key { get; } // 0x000000018B1DB1E0-0x000000018B1DB1F0 
		public KeyControl numpad5Key { get; } // 0x000000018B1DB1F0-0x000000018B1DB200 
		public KeyControl numpad6Key { get; } // 0x000000018B1DB200-0x000000018B1DB210 
		public KeyControl numpad7Key { get; } // 0x000000018B1DB210-0x000000018B1DB220 
		public KeyControl numpad8Key { get; } // 0x000000018B1DB220-0x000000018B1DB230 
		public KeyControl numpad9Key { get; } // 0x000000018B1DB230-0x000000018B1DB240 
		public KeyControl f1Key { get; } // 0x000000018B1DAF70-0x000000018B1DAF80 
		public KeyControl f2Key { get; } // 0x000000018B1DAFD0-0x000000018B1DAFE0 
		public KeyControl f3Key { get; } // 0x000000018B1DAFE0-0x000000018B1DAFF0 
		public KeyControl f4Key { get; } // 0x000000018B1DAFF0-0x000000018B1DB000 
		public KeyControl f5Key { get; } // 0x000000018B1DB000-0x000000018B1DB010 
		public KeyControl f6Key { get; } // 0x000000018B1DB010-0x000000018B1DB020 
		public KeyControl f7Key { get; } // 0x000000018B1DB020-0x000000018B1DB030 
		public KeyControl f8Key { get; } // 0x000000018B1DB030-0x000000018B1DB040 
		public KeyControl f9Key { get; } // 0x000000018B1DB040-0x000000018B1DB050 
		public KeyControl f10Key { get; } // 0x000000018B1DAED0-0x000000018B1DAEE0 
		public KeyControl f11Key { get; } // 0x000000018B1DAEE0-0x000000018B1DAEF0 
		public KeyControl f12Key { get; } // 0x000000018B1DAEF0-0x000000018B1DAF00 
		public KeyControl oem1Key { get; } // 0x000000018B1DB2C0-0x000000018B1DB2D0 
		public KeyControl oem2Key { get; } // 0x000000018B1DB2D0-0x000000018B1DB2E0 
		public KeyControl oem3Key { get; } // 0x000000018B1DB2E0-0x000000018B1DB2F0 
		public KeyControl oem4Key { get; } // 0x000000018B1DB2F0-0x000000018B1DB300 
		public KeyControl oem5Key { get; } // 0x000000018B1DB300-0x000000018B1DB310 
		public KeyControl f13Key { get; } // 0x000000018B1DAF00-0x000000018B1DAF10 
		public KeyControl f14Key { get; } // 0x000000018B1DAF10-0x000000018B1DAF20 
		public KeyControl f15Key { get; } // 0x000000018B1DAF20-0x000000018B1DAF30 
		public KeyControl f16Key { get; } // 0x000000018B1DAF30-0x000000018B1DAF40 
		public KeyControl f17Key { get; } // 0x000000018B1DAF40-0x000000018B1DAF50 
		public KeyControl f18Key { get; } // 0x000000018B1DAF50-0x000000018B1DAF60 
		public KeyControl f19Key { get; } // 0x000000018B1DAF60-0x000000018B1DAF70 
		public KeyControl f20Key { get; } // 0x000000018B1DAF80-0x000000018B1DAF90 
		public KeyControl f21Key { get; } // 0x000000018B1DAF90-0x000000018B1DAFA0 
		public KeyControl f22Key { get; } // 0x000000018B1DAFA0-0x000000018B1DAFB0 
		public KeyControl f23Key { get; } // 0x000000018B1DAFB0-0x000000018B1DAFC0 
		public KeyControl f24Key { get; } // 0x000000018B1DAFC0-0x000000018B1DAFD0 
		public ButtonControl shiftKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public ButtonControl ctrlKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		public ButtonControl altKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public ButtonControl imeSelected { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		public KeyControl this[UnityEngine.InputSystem.Key key] { get => default; } // 0x00000001833068F0-0x0000000183306940 
		public ReadOnlyArray<KeyControl> allKeys { get; } // 0x000000018B1DACA0-0x000000018B1DACF8 
		public static Keyboard current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1DAD78-0x000000018B1DADB0 0x000000018B1DB578-0x000000018B1DB5C8
		protected KeyControl[] keys { get; set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
	
		// Events
		public event Action<char> onTextInput {
			add; // 0x000000018B1DABAC-0x000000018B1DAC90
			remove; // 0x000000018B1DB52C-0x000000018B1DB578
		}
		public event Action<IMECompositionString> onIMECompositionChange {
			add; // 0x000000018B1DAAC8-0x000000018B1DABAC
			remove; // 0x000000018B1DB4E0-0x000000018B1DB52C
		}
	
		// Constructors
		public Keyboard(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public void SetIMEEnabled(bool enabled); // 0x000000018B1DAA40-0x000000018B1DAAC8
		public void SetIMECursorPosition(Vector2 position); // 0x000000018B1DA9CC-0x000000018B1DAA40
		public override void MakeCurrent(); // 0x000000018444BC80-0x000000018444BCE0
		protected override void OnRemoved(); // 0x000000018B1DA8A8-0x000000018B1DA8D0
		protected override void FinishSetup(); // 0x000000018B1D96F4-0x000000018B1DA8A8
		protected override void RefreshConfiguration(); // 0x000000018B1DA8D0-0x000000018B1DA9CC
		public void OnTextInput(char character); // 0x00000001842514B0-0x00000001842514E0
		public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName); // 0x000000018B1D9628-0x000000018B1D96F4
		public void OnIMECompositionChanged(IMECompositionString compositionString); // 0x0000000184899200-0x0000000184899250
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr); // 0x000000018400B6A0-0x000000018400B700
	}

	[InputControlLayout(stateType = typeof(UnityEngine.InputSystem.LowLevel.MouseState), isGenericTypeOfDevice = true)]
	public class Mouse : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver // TypeDefIndex: 47487
	{
		// Fields
		[CompilerGenerated]
		private DeltaControl _scroll_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _leftButton_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _middleButton_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _rightButton_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _backButton_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _forwardButton_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private IntegerControl _clickCount_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private static Mouse _current_k__BackingField; // 0x00
		internal static Mouse s_PlatformMouseDevice; // 0x08
	
		// Properties
		public DeltaControl scroll { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public ButtonControl leftButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		public ButtonControl middleButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		public ButtonControl rightButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		public ButtonControl backButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		public ButtonControl forwardButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		public IntegerControl clickCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		public static new Mouse current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1DB928-0x000000018B1DB960 0x000000018B1DB960-0x000000018B1DB9B0
	
		// Constructors
		public Mouse(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x0000000183F64C80-0x0000000183F64CA0
		protected override void OnAdded(); // 0x0000000184D1EF90-0x0000000184D1F000
		protected override void OnRemoved(); // 0x000000018B1DB824-0x000000018B1DB850
		public void WarpCursorPosition(Vector2 position); // 0x000000018B1DB8B4-0x000000018B1DB928
		protected override void FinishSetup(); // 0x000000018B1DB5C8-0x000000018B1DB7C0
		protected new void OnNextUpdate(); // 0x000000018B1DB7C0-0x000000018B1DB824
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B1DB850-0x000000018B1DB8A4
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018B1DB8A4-0x000000018B1DB8AC
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018B1DB8AC-0x000000018B1DB8B4
	}

	public enum PenButton // TypeDefIndex: 47488
	{
		Tip = 0,
		Eraser = 1,
		BarrelFirst = 2,
		Barrel1 = 2,
		BarrelSecond = 3,
		Barrel2 = 3,
		InRange = 4,
		BarrelThird = 5,
		Barrel3 = 5,
		BarrelFourth = 6,
		Barrel4 = 6
	}

	[InputControlLayout(stateType = typeof(PenState), isGenericTypeOfDevice = true)]
	public class Pen : UnityEngine.InputSystem.Pointer // TypeDefIndex: 47489
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _tip_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _eraser_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _firstBarrelButton_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private ButtonControl _secondBarrelButton_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _thirdBarrelButton_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _fourthBarrelButton_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private ButtonControl _inRange_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Vector2Control _tilt_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private AxisControl _twist_k__BackingField; // 0x200
		[CompilerGenerated]
		private static Pen _current_k__BackingField; // 0x00
	
		// Properties
		public ButtonControl tip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public ButtonControl eraser { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		public ButtonControl firstBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		public ButtonControl secondBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		public ButtonControl thirdBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		public ButtonControl fourthBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		public ButtonControl inRange { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		public Vector2Control tilt { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		public AxisControl twist { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		public static new Pen current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018B1DBDC4-0x000000018B1DBDFC 0x000000018B1DBDFC-0x000000018B1DBE4C
		public ButtonControl this[PenButton button] { get => default; } // 0x000000018B1DBC90-0x000000018B1DBDC4 
	
		// Constructors
		public Pen(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1DBC20-0x000000018B1DBC3C
		protected override void OnRemoved(); // 0x000000018B1DBC3C-0x000000018B1DBC90
		protected override void FinishSetup(); // 0x000000018B1DB9B0-0x000000018B1DBC20
	}

	[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
	public class Pointer : UnityEngine.InputSystem.InputDevice, IInputStateCallbackReceiver // TypeDefIndex: 47490
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _position_k__BackingField; // 0x190
		[CompilerGenerated]
		private DeltaControl _delta_k__BackingField; // 0x198
		[CompilerGenerated]
		private Vector2Control _radius_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private AxisControl _pressure_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private ButtonControl _press_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private IntegerControl _displayIndex_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private static Pointer _current_k__BackingField; // 0x00
	
		// Properties
		public Vector2Control position { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public DeltaControl delta { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public Vector2Control radius { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		public AxisControl pressure { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public ButtonControl press { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		public IntegerControl displayIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		public static Pointer current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018B1DC0CC-0x000000018B1DC104 0x000000018B1DC104-0x000000018B1DC154
	
		// Constructors
		public Pointer(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x0000000183F64CA0-0x0000000183F64D50
		protected override void OnRemoved(); // 0x000000018B1DC040-0x000000018B1DC068
		protected override void FinishSetup(); // 0x000000018B1DBE4C-0x000000018B1DBFE8
		protected void OnNextUpdate(); // 0x000000018B1DBFE8-0x000000018B1DC040
		protected void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B1DC068-0x000000018B1DC0BC
		void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018B1DC0BC-0x000000018B1DC0C4
		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018B1DC0C4-0x000000018B1DC0CC
		bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001812081B0-0x0000000181208610
	}

	internal class FastKeyboard : UnityEngine.InputSystem.Keyboard // TypeDefIndex: 47491
	{
		// Fields
		public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard"; // Metadata: 0x0232A2B9
	
		// Constructors
		public FastKeyboard(); // 0x0000000183AF3C50-0x0000000183AF7060
	
		// Methods
		private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent); // 0x000000018429A410-0x000000018429A600
		private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent); // 0x00000001849E2190-0x00000001849E2380
		private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent); // 0x00000001849FFFF0-0x0000000184A001D0
		private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent); // 0x00000001849E1D90-0x00000001849E1F90
		private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent); // 0x00000001849FFC30-0x00000001849FFE10
		private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03A10-0x0000000184A03BF0
		private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00D10-0x0000000184A00EF0
		private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent); // 0x0000000184A003B0-0x0000000184A00590
		private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03470-0x0000000184A03650
		private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent); // 0x0000000184A010D0-0x0000000184A012B0
		private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent); // 0x0000000184A001D0-0x0000000184A003B0
		private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03830-0x0000000184A03A10
		private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01C10-0x0000000184A01DF0
		private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00770-0x0000000184A00950
		private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01850-0x0000000184A01A30
		private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02CF0-0x0000000184A02ED0
		private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent); // 0x00000001849FF870-0x00000001849FFA50
		private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000184A030B0-0x0000000184A03290
		private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01DF0-0x0000000184A01FD0
		private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00950-0x0000000184A00B30
		private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03DD0-0x0000000184A03FB0
		private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03BF0-0x0000000184A03DD0
		private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03650-0x0000000184A03830
		private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent); // 0x0000000184A03290-0x0000000184A03470
		private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02ED0-0x0000000184A030B0
		private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02B10-0x0000000184A02CF0
		private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02930-0x0000000184A02B10
		private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02750-0x0000000184A02930
		private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02570-0x0000000184A02750
		private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent); // 0x0000000184A02390-0x0000000184A02570
		private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent); // 0x0000000184A021B0-0x0000000184A02390
		private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01FD0-0x0000000184A021B0
		private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01A30-0x0000000184A01C10
		private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01670-0x0000000184A01850
		private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent); // 0x0000000184A01490-0x0000000184A01670
		private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent); // 0x0000000184A012B0-0x0000000184A01490
		private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00EF0-0x0000000184A010D0
		private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00B30-0x0000000184A00D10
		private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent); // 0x0000000184A00590-0x0000000184A00770
		private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent); // 0x00000001849FFE10-0x00000001849FFFF0
		private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent); // 0x00000001849FFA50-0x00000001849FFC30
		private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent); // 0x00000001849FF690-0x00000001849FF870
		private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent); // 0x00000001849FF4B0-0x00000001849FF690
		private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent); // 0x00000001849FF2D0-0x00000001849FF4B0
		private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent); // 0x00000001849FF0F0-0x00000001849FF2D0
		private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent); // 0x00000001849FEF10-0x00000001849FF0F0
		private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent); // 0x0000000184A1B4C0-0x0000000184A1B6A0
		private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent); // 0x0000000184A1B2E0-0x0000000184A1B4C0
		private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent); // 0x00000001840CEA90-0x00000001840CEC70
		private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent); // 0x00000001840CEC70-0x00000001840CEE50
		private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent); // 0x00000001840CEE50-0x00000001840CF030
		private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF030-0x00000001840CF210
		private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF210-0x00000001840CF3F0
		private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF3F0-0x00000001840CF5D0
		private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF5D0-0x00000001840CF7B0
		private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF7B0-0x00000001840CF990
		private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent); // 0x00000001840CF990-0x00000001840CFB90
		private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent); // 0x00000001840CFB90-0x00000001840CFD90
		private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent); // 0x00000001840D2990-0x00000001840D2BB0
		private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent); // 0x00000001840CFD90-0x00000001840CFF90
		private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent); // 0x00000001840CFF90-0x00000001840D0190
		private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent); // 0x00000001840D2BB0-0x00000001840D2DD0
		private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0190-0x00000001840D0390
		private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0390-0x00000001840D0590
		private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent); // 0x00000001840D2DD0-0x00000001840D2FF0
		private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0590-0x00000001840D07A0
		private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent); // 0x00000001840D07A0-0x00000001840D09D0
		private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent); // 0x00000001840DB620-0x00000001840DB820
		private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent); // 0x00000001840DB440-0x00000001840DB620
		private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent); // 0x00000001840DB260-0x00000001840DB440
		private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent); // 0x00000001840DB080-0x00000001840DB260
		private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent); // 0x00000001840DAEA0-0x00000001840DB080
		private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent); // 0x00000001840DACC0-0x00000001840DAEA0
		private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent); // 0x00000001840DAAE0-0x00000001840DACC0
		private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent); // 0x00000001840DA900-0x00000001840DAAE0
		private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent); // 0x00000001840DA720-0x00000001840DA900
		private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent); // 0x00000001840DA540-0x00000001840DA720
		private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent); // 0x00000001840DA360-0x00000001840DA540
		private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent); // 0x00000001840DA180-0x00000001840DA360
		private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9FA0-0x00000001840DA180
		private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9DC0-0x00000001840D9FA0
		private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9BE0-0x00000001840D9DC0
		private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9A00-0x00000001840D9BE0
		private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9820-0x00000001840D9A00
		private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9640-0x00000001840D9820
		private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent); // 0x00000001840D09F0-0x00000001840D0BD0
		private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0BD0-0x00000001840D0DB0
		private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0DB0-0x00000001840D0F90
		private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent); // 0x00000001840D0F90-0x00000001840D1170
		private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1170-0x00000001840D1350
		private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1350-0x00000001840D1530
		private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1530-0x00000001840D1710
		private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1710-0x00000001840D18F0
		private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent); // 0x00000001840D18F0-0x00000001840D1AD0
		private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1AD0-0x00000001840D1CB0
		private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1CB0-0x00000001840D1E90
		private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent); // 0x00000001840D1E90-0x00000001840D2070
		private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent); // 0x00000001840D2070-0x00000001840D2250
		private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent); // 0x00000001840D2250-0x00000001840D2430
		private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent); // 0x00000001840D2430-0x00000001840D2610
		private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent); // 0x00000001840D2610-0x00000001840D27F0
		private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9460-0x00000001840D9640
		private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent); // 0x00000001840D9280-0x00000001840D9460
		private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent); // 0x00000001840D90A0-0x00000001840D9280
		private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8EC0-0x00000001840D90A0
		private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8CE0-0x00000001840D8EC0
		private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8B00-0x00000001840D8CE0
		private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8920-0x00000001840D8B00
		private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8740-0x00000001840D8920
		private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8560-0x00000001840D8740
		private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent); // 0x00000001840D8380-0x00000001840D8560
		private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent); // 0x00000001840D81A0-0x00000001840D8380
		private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7FC0-0x00000001840D81A0
		private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7DE0-0x00000001840D7FC0
		private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7C00-0x00000001840D7DE0
		private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7A20-0x00000001840D7C00
		private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7840-0x00000001840D7A20
		private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7660-0x00000001840D7840
		private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7440-0x00000001840D7660
		private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7260-0x00000001840D7440
		private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent); // 0x00000001840D7080-0x00000001840D7260
		private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent); // 0x00000001840D6EA0-0x00000001840D7080
		private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent); // 0x00000001840D6CC0-0x00000001840D6EA0
		private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent); // 0x00000001840D6AE0-0x00000001840D6CC0
		private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent); // 0x00000001840D6900-0x00000001840D6AE0
		private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent); // 0x00000001840D6720-0x00000001840D6900
		private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent); // 0x00000001840D6540-0x00000001840D6720
	}

	internal class FastMouse : UnityEngine.InputSystem.Mouse, IInputStateCallbackReceiver, IEventMerger // TypeDefIndex: 47492
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer"; // Metadata: 0x0232A2E9
	
		// Constructors
		public FastMouse(); // 0x00000001841AB300-0x00000001841AC150
	
		// Methods
		private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent); // 0x00000001840D6380-0x00000001840D6540
		private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent); // 0x00000001840D61E0-0x00000001840D6380
		private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent); // 0x00000001840D6050-0x00000001840D61E0
		private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5E60-0x00000001840D6050
		private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5C50-0x00000001840D5E60
		private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5A40-0x00000001840D5C50
		private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5840-0x00000001840D5A40
		private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5650-0x00000001840D5840
		private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent); // 0x00000001840D5410-0x00000001840D5630
		private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent); // 0x00000001840D5250-0x00000001840D5410
		private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent); // 0x00000001840D5080-0x00000001840D5220
		private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent); // 0x00000001840D2FF0-0x00000001840D3160
		private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x00000001840D3160-0x00000001840D32E0
		private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent); // 0x00000001840D32E0-0x00000001840D3470
		private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3470-0x00000001840D3620
		private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3620-0x00000001840D37D0
		private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent); // 0x00000001840D37D0-0x00000001840D3980
		private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3980-0x00000001840D3B40
		private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3B40-0x00000001840D3D00
		private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3D00-0x00000001840D3EB0
		private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent); // 0x00000001840D3EB0-0x00000001840D4040
		private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4040-0x00000001840D41D0
		private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent); // 0x00000001840D41D0-0x00000001840D4380
		private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4380-0x00000001840D4540
		private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4540-0x00000001840D4700
		private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4700-0x00000001840D48E0
		private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4900-0x00000001840D4AB0
		private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4AB0-0x00000001840D4C70
		private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4C70-0x00000001840D4E00
		private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent); // 0x00000001840D4E00-0x00000001840D5020
		protected new void OnNextUpdate(); // 0x0000000183BF2E70-0x0000000183BF3010
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x0000000183BF2D00-0x0000000183BF2E70
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x0000000185391098-0x00000001853910A0
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x0000000185396E64-0x0000000185396E6C
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x00000001830CE360-0x00000001830CE4A0
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x0000000185396978-0x000000018539698C
	}

	internal class FastTouchscreen : Touchscreen // TypeDefIndex: 47493
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer"; // Metadata: 0x0232A332
	
		// Constructors
		public FastTouchscreen(); // 0x000000018B1F99FC-0x000000018B1FF2C8
	
		// Methods
		private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent); // 0x000000018B1DD5CC-0x000000018B1DD750
		private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1DCDB0-0x000000018B1DCF4C
		private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1DC154-0x000000018B1DC2E4
		private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent); // 0x000000018B1DD424-0x000000018B1DD5CC
		private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1DFE90-0x000000018B1E0020
		private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1DD25C-0x000000018B1DD424
		private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1DCC4C-0x000000018B1DCDB0
		private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent); // 0x000000018B1E0310-0x000000018B1E0488
		private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent); // 0x000000018B1E2BB4-0x000000018B1E2D2C
		private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent); // 0x000000018B1E5458-0x000000018B1E55D0
		private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent); // 0x000000018B1E7CFC-0x000000018B1E7E74
		private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent); // 0x000000018B1EA5B0-0x000000018B1EA72C
		private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent); // 0x000000018B1ECE68-0x000000018B1ECFE4
		private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent); // 0x000000018B1EF720-0x000000018B1EF89C
		private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent); // 0x000000018B1F1FD8-0x000000018B1F2150
		private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent); // 0x000000018B1F488C-0x000000018B1F4A08
		private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent); // 0x000000018B1F7144-0x000000018B1F72C0
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1DFCFC-0x000000018B1DFE90
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1DE720-0x000000018B1DE8BC
		private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1DD750-0x000000018B1DD8DC
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DED98-0x000000018B1DEF10
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1DEF10-0x000000018B1DF09C
		private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1DE598-0x000000018B1DE720
		private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1DEBCC-0x000000018B1DED98
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1DF9A0-0x000000018B1DFB18
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1DE244-0x000000018B1DE3BC
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1DE3BC-0x000000018B1DE598
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1DFB18-0x000000018B1DFCFC
		private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1DF818-0x000000018B1DF9A0
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1DF38C-0x000000018B1DF528
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DE8BC-0x000000018B1DEA44
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DEA44-0x000000018B1DEBCC
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DDDB8-0x000000018B1DDF54
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DD8DC-0x000000018B1DDA7C
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DDA7C-0x000000018B1DDC1C
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DDC1C-0x000000018B1DDDB8
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DDF54-0x000000018B1DE0CC
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DE0CC-0x000000018B1DE244
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DF09C-0x000000018B1DF214
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DF214-0x000000018B1DF38C
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DF528-0x000000018B1DF6A0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DF6A0-0x000000018B1DF818
		private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DCF4C-0x000000018B1DD0D4
		private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DD0D4-0x000000018B1DD25C
		private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DC7C0-0x000000018B1DC95C
		private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DC2E4-0x000000018B1DC484
		private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DC484-0x000000018B1DC624
		private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DC624-0x000000018B1DC7C0
		private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DC95C-0x000000018B1DCAD4
		private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1DCAD4-0x000000018B1DCC4C
		private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0020-0x000000018B1E0198
		private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0198-0x000000018B1E0310
		private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E2A20-0x000000018B1E2BB4
		private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E1458-0x000000018B1E15F4
		private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1E0488-0x000000018B1E0614
		private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E1AD0-0x000000018B1E1C48
		private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E1C48-0x000000018B1E1DD4
		private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1E12D0-0x000000018B1E1458
		private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1E1904-0x000000018B1E1AD0
		private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E26D8-0x000000018B1E2850
		private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E0F7C-0x000000018B1E10F4
		private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E10F4-0x000000018B1E12D0
		private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E2850-0x000000018B1E2A20
		private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1E2550-0x000000018B1E26D8
		private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E20C4-0x000000018B1E2260
		private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E15F4-0x000000018B1E177C
		private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E177C-0x000000018B1E1904
		private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0AF0-0x000000018B1E0C8C
		private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0614-0x000000018B1E07B4
		private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E07B4-0x000000018B1E0954
		private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0954-0x000000018B1E0AF0
		private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0C8C-0x000000018B1E0E04
		private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E0E04-0x000000018B1E0F7C
		private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E1DD4-0x000000018B1E1F4C
		private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E1F4C-0x000000018B1E20C4
		private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E2260-0x000000018B1E23D8
		private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E23D8-0x000000018B1E2550
		private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E52C4-0x000000018B1E5458
		private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E3CFC-0x000000018B1E3E98
		private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1E2D2C-0x000000018B1E2EB8
		private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E4374-0x000000018B1E44EC
		private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E44EC-0x000000018B1E4678
		private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1E3B74-0x000000018B1E3CFC
		private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1E41A8-0x000000018B1E4374
		private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E4F7C-0x000000018B1E50F4
		private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E3820-0x000000018B1E3998
		private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E3998-0x000000018B1E3B74
		private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E50F4-0x000000018B1E52C4
		private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1E4DF4-0x000000018B1E4F7C
		private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E4968-0x000000018B1E4B04
		private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E3E98-0x000000018B1E4020
		private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E4020-0x000000018B1E41A8
		private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E3394-0x000000018B1E3530
		private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E2EB8-0x000000018B1E3058
		private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E3058-0x000000018B1E31F8
		private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E31F8-0x000000018B1E3394
		private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E3530-0x000000018B1E36A8
		private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E36A8-0x000000018B1E3820
		private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E4678-0x000000018B1E47F0
		private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E47F0-0x000000018B1E4968
		private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E4B04-0x000000018B1E4C7C
		private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E4C7C-0x000000018B1E4DF4
		private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E7B68-0x000000018B1E7CFC
		private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E65A0-0x000000018B1E673C
		private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1E55D0-0x000000018B1E575C
		private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E6C18-0x000000018B1E6D90
		private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E6D90-0x000000018B1E6F1C
		private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1E6418-0x000000018B1E65A0
		private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1E6A4C-0x000000018B1E6C18
		private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E7820-0x000000018B1E7998
		private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E60C4-0x000000018B1E623C
		private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E623C-0x000000018B1E6418
		private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E7998-0x000000018B1E7B68
		private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1E7698-0x000000018B1E7820
		private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E720C-0x000000018B1E73A8
		private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E673C-0x000000018B1E68C4
		private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E68C4-0x000000018B1E6A4C
		private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E5C38-0x000000018B1E5DD4
		private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E575C-0x000000018B1E58FC
		private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E58FC-0x000000018B1E5A9C
		private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E5A9C-0x000000018B1E5C38
		private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E5DD4-0x000000018B1E5F4C
		private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E5F4C-0x000000018B1E60C4
		private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E6F1C-0x000000018B1E7094
		private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E7094-0x000000018B1E720C
		private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E73A8-0x000000018B1E7520
		private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E7520-0x000000018B1E7698
		private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EA41C-0x000000018B1EA5B0
		private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E8E48-0x000000018B1E8FE8
		private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1E7E74-0x000000018B1E8004
		private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E94C4-0x000000018B1E963C
		private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E963C-0x000000018B1E97CC
		private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1E8CC0-0x000000018B1E8E48
		private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1E92F8-0x000000018B1E94C4
		private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EA0D4-0x000000018B1EA24C
		private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1E896C-0x000000018B1E8AE4
		private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1E8AE4-0x000000018B1E8CC0
		private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1EA24C-0x000000018B1EA41C
		private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1E9F4C-0x000000018B1EA0D4
		private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1E9ABC-0x000000018B1E9C5C
		private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E8FE8-0x000000018B1E9170
		private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E9170-0x000000018B1E92F8
		private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E84E0-0x000000018B1E867C
		private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E8004-0x000000018B1E81A4
		private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E81A4-0x000000018B1E8344
		private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E8344-0x000000018B1E84E0
		private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E867C-0x000000018B1E87F4
		private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E87F4-0x000000018B1E896C
		private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E97CC-0x000000018B1E9944
		private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E9944-0x000000018B1E9ABC
		private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E9C5C-0x000000018B1E9DD4
		private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1E9DD4-0x000000018B1E9F4C
		private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1ECCD4-0x000000018B1ECE68
		private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EB700-0x000000018B1EB8A0
		private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1EA72C-0x000000018B1EA8BC
		private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EBD7C-0x000000018B1EBEF4
		private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EBEF4-0x000000018B1EC084
		private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1EB578-0x000000018B1EB700
		private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1EBBB0-0x000000018B1EBD7C
		private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EC98C-0x000000018B1ECB04
		private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EB224-0x000000018B1EB39C
		private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1EB39C-0x000000018B1EB578
		private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1ECB04-0x000000018B1ECCD4
		private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1EC804-0x000000018B1EC98C
		private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EC374-0x000000018B1EC514
		private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EB8A0-0x000000018B1EBA28
		private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EBA28-0x000000018B1EBBB0
		private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EAD98-0x000000018B1EAF34
		private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EA8BC-0x000000018B1EAA5C
		private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EAA5C-0x000000018B1EABFC
		private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EABFC-0x000000018B1EAD98
		private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EAF34-0x000000018B1EB0AC
		private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EB0AC-0x000000018B1EB224
		private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EC084-0x000000018B1EC1FC
		private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EC1FC-0x000000018B1EC374
		private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EC514-0x000000018B1EC68C
		private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EC68C-0x000000018B1EC804
		private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EF58C-0x000000018B1EF720
		private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EDFB8-0x000000018B1EE158
		private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1ECFE4-0x000000018B1ED174
		private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EE634-0x000000018B1EE7AC
		private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EE7AC-0x000000018B1EE93C
		private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1EDE30-0x000000018B1EDFB8
		private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1EE468-0x000000018B1EE634
		private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EF244-0x000000018B1EF3BC
		private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1EDADC-0x000000018B1EDC54
		private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1EDC54-0x000000018B1EDE30
		private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1EF3BC-0x000000018B1EF58C
		private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1EF0BC-0x000000018B1EF244
		private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1EEC2C-0x000000018B1EEDCC
		private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EE158-0x000000018B1EE2E0
		private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EE2E0-0x000000018B1EE468
		private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED650-0x000000018B1ED7EC
		private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED174-0x000000018B1ED314
		private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED314-0x000000018B1ED4B4
		private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED4B4-0x000000018B1ED650
		private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED7EC-0x000000018B1ED964
		private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1ED964-0x000000018B1EDADC
		private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EE93C-0x000000018B1EEAB4
		private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EEAB4-0x000000018B1EEC2C
		private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EEDCC-0x000000018B1EEF44
		private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EEF44-0x000000018B1EF0BC
		private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F1E44-0x000000018B1F1FD8
		private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F0870-0x000000018B1F0A10
		private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1EF89C-0x000000018B1EFA2C
		private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F0EEC-0x000000018B1F1064
		private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F1064-0x000000018B1F11F4
		private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1F06E8-0x000000018B1F0870
		private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1F0D20-0x000000018B1F0EEC
		private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F1AFC-0x000000018B1F1C74
		private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F0394-0x000000018B1F050C
		private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F050C-0x000000018B1F06E8
		private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F1C74-0x000000018B1F1E44
		private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1F1974-0x000000018B1F1AFC
		private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F14E4-0x000000018B1F1684
		private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F0A10-0x000000018B1F0B98
		private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F0B98-0x000000018B1F0D20
		private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EFF08-0x000000018B1F00A4
		private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EFA2C-0x000000018B1EFBCC
		private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EFBCC-0x000000018B1EFD6C
		private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1EFD6C-0x000000018B1EFF08
		private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F00A4-0x000000018B1F021C
		private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F021C-0x000000018B1F0394
		private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F11F4-0x000000018B1F136C
		private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F136C-0x000000018B1F14E4
		private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F1684-0x000000018B1F17FC
		private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F17FC-0x000000018B1F1974
		private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F46F8-0x000000018B1F488C
		private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F3124-0x000000018B1F32C4
		private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1F2150-0x000000018B1F22E0
		private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F37A0-0x000000018B1F3918
		private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F3918-0x000000018B1F3AA8
		private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1F2F9C-0x000000018B1F3124
		private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1F35D4-0x000000018B1F37A0
		private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F43B0-0x000000018B1F4528
		private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F2C48-0x000000018B1F2DC0
		private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F2DC0-0x000000018B1F2F9C
		private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F4528-0x000000018B1F46F8
		private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1F4228-0x000000018B1F43B0
		private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F3D98-0x000000018B1F3F38
		private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F32C4-0x000000018B1F344C
		private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F344C-0x000000018B1F35D4
		private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F27BC-0x000000018B1F2958
		private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F22E0-0x000000018B1F2480
		private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F2480-0x000000018B1F2620
		private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F2620-0x000000018B1F27BC
		private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F2958-0x000000018B1F2AD0
		private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F2AD0-0x000000018B1F2C48
		private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F3AA8-0x000000018B1F3C20
		private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F3C20-0x000000018B1F3D98
		private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F3F38-0x000000018B1F40B0
		private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F40B0-0x000000018B1F4228
		private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F6FB0-0x000000018B1F7144
		private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F59DC-0x000000018B1F5B7C
		private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1F4A08-0x000000018B1F4B98
		private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F6058-0x000000018B1F61D0
		private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F61D0-0x000000018B1F6360
		private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1F5854-0x000000018B1F59DC
		private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1F5E8C-0x000000018B1F6058
		private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F6C68-0x000000018B1F6DE0
		private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F5500-0x000000018B1F5678
		private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F5678-0x000000018B1F5854
		private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F6DE0-0x000000018B1F6FB0
		private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1F6AE0-0x000000018B1F6C68
		private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F6650-0x000000018B1F67F0
		private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F5B7C-0x000000018B1F5D04
		private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F5D04-0x000000018B1F5E8C
		private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F5074-0x000000018B1F5210
		private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F4B98-0x000000018B1F4D38
		private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F4D38-0x000000018B1F4ED8
		private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F4ED8-0x000000018B1F5074
		private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F5210-0x000000018B1F5388
		private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F5388-0x000000018B1F5500
		private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F6360-0x000000018B1F64D8
		private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F64D8-0x000000018B1F6650
		private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F67F0-0x000000018B1F6968
		private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F6968-0x000000018B1F6AE0
		private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F9868-0x000000018B1F99FC
		private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F8294-0x000000018B1F8434
		private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018B1F72C0-0x000000018B1F7450
		private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F8910-0x000000018B1F8A88
		private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F8A88-0x000000018B1F8C18
		private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018B1F810C-0x000000018B1F8294
		private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018B1F8744-0x000000018B1F8910
		private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F9520-0x000000018B1F9698
		private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018B1F7DB8-0x000000018B1F7F30
		private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F7F30-0x000000018B1F810C
		private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent); // 0x000000018B1F9698-0x000000018B1F9868
		private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018B1F9398-0x000000018B1F9520
		private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018B1F8F08-0x000000018B1F90A8
		private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F8434-0x000000018B1F85BC
		private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F85BC-0x000000018B1F8744
		private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F792C-0x000000018B1F7AC8
		private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F7450-0x000000018B1F75F0
		private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F75F0-0x000000018B1F7790
		private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F7790-0x000000018B1F792C
		private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F7AC8-0x000000018B1F7C40
		private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F7C40-0x000000018B1F7DB8
		private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F8C18-0x000000018B1F8D90
		private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F8D90-0x000000018B1F8F08
		private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F90A8-0x000000018B1F9220
		private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018B1F9220-0x000000018B1F9398
	}

	public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message> // TypeDefIndex: 47514
	{
		// Fields
		private Flags m_Flags; // 0x10
		private InputManager m_LocalManager; // 0x18
		private Subscriber[] m_Subscribers; // 0x20
		private RemoteSender[] m_Senders; // 0x28
	
		// Properties
		public bool sending { get; private set; } // 0x0000000182F2E060-0x0000000182F2E070 0x000000018B20429C-0x000000018B2042B8
		internal InputManager manager { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		public enum MessageType // TypeDefIndex: 47494
		{
			Connect = 0,
			Disconnect = 1,
			NewLayout = 2,
			NewDevice = 3,
			NewEvents = 4,
			RemoveDevice = 5,
			RemoveLayout = 6,
			ChangeUsages = 7,
			StartSending = 8,
			StopSending = 9
		}
	
		public struct Message // TypeDefIndex: 47495
		{
			// Fields
			public int participantId; // 0x00
			public MessageType type; // 0x04
			public byte[] data; // 0x08
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 47496
		{
			Sending = 1,
			StartSendingOnConnect = 2
		}
	
		[Serializable]
		internal struct RemoteSender // TypeDefIndex: 47497
		{
			// Fields
			public int senderId; // 0x00
			public InternedString[] layouts; // 0x08
			public RemoteInputDevice[] devices; // 0x10
		}
	
		[Serializable]
		internal struct RemoteInputDevice // TypeDefIndex: 47498
		{
			// Fields
			public int remoteId; // 0x00
			public int localId; // 0x04
			public InputDeviceDescription description; // 0x08
		}
	
		internal class Subscriber : IDisposable // TypeDefIndex: 47499
		{
			// Fields
			public InputRemoting owner; // 0x10
			public IObserver<Message> observer; // 0x18
	
			// Constructors
			public Subscriber(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Dispose(); // 0x000000018B206834-0x000000018B206880
		}
	
		private static class ConnectMsg // TypeDefIndex: 47500
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018B1FFBF4-0x000000018B1FFC28
		}
	
		private static class StartSendingMsg // TypeDefIndex: 47501
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018B206674-0x000000018B206690
		}
	
		private static class StopSendingMsg // TypeDefIndex: 47502
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018B2067CC-0x000000018B2067E8
		}
	
		private static class DisconnectMsg // TypeDefIndex: 47503
		{
			// Methods
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B1FFC28-0x000000018B1FFCA8
		}
	
		private static class NewLayoutMsg // TypeDefIndex: 47505
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 47504
			{
				// Fields
				public string name; // 0x00
				public string layoutJson; // 0x08
				public bool isOverride; // 0x10
			}
	
			// Methods
			public static Message? Create(InputRemoting sender, string layoutName); // 0x000000018B205204-0x000000018B2054DC
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B2054DC-0x000000018B2055B8
		}
	
		private static class NewDeviceMsg // TypeDefIndex: 47508
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 47506
			{
				// Fields
				public string name; // 0x00
				public string layout; // 0x08
				public int deviceId; // 0x10
				public string[] usages; // 0x18
				public InputDeviceDescription description; // 0x20
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47507
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B20817C-0x000000018B2081E0
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _Create_b__1_0(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018B20466C-0x000000018B204904
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B204904-0x000000018B204EB0
		}
	
		private static class NewEventsMsg // TypeDefIndex: 47509
		{
			// Methods
			public static Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset); // 0x000000018B204EB0-0x000000018B204F24
			public static Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device); // 0x000000018B204F24-0x000000018B20502C
			public static unsafe Message Create(InputEvent* events, int eventCount); // 0x000000018B20502C-0x000000018B205114
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B205114-0x000000018B205204
		}
	
		private static class ChangeUsageMsg // TypeDefIndex: 47512
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 47510
			{
				// Fields
				public int deviceId; // 0x00
				public string[] usages; // 0x08
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47511
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B2081E0-0x000000018B2083E0
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _Create_b__1_0(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018B1FF67C-0x000000018B1FF85C
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B1FF85C-0x000000018B1FFBF4
		}
	
		private static class RemoveDeviceMsg // TypeDefIndex: 47513
		{
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018B2063FC-0x000000018B206478
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018B206478-0x000000018B20651C
		}
	
		// Constructors
		internal InputRemoting(InputManager manager, bool startSendingOnConnect = false /* Metadata: 0x0232A3A3 */); // 0x000000018B204218-0x000000018B20429C
	
		// Methods
		public void StartSending(); // 0x000000018B203D38-0x000000018B203E9C
		public void StopSending(); // 0x000000018B203E9C-0x000000018B203FF4
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg); // 0x000000018B2040E0-0x000000018B2041E8
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error); // 0x00000001841E1670-0x00000001841E1680
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(); // 0x00000001841E1670-0x00000001841E1680
		public IDisposable Subscribe(IObserver<Message> observer); // 0x000000018B203FF4-0x000000018B2040E0
		private void SendInitialMessages(); // 0x000000018B203ACC-0x000000018B203AEC
		private void SendAllGeneratedLayouts(); // 0x000000018B2037DC-0x000000018B203940
		private void SendLayout(string layoutName); // 0x000000018B203C00-0x000000018B203CAC
		private void SendAllDevices(); // 0x000000018B203694-0x000000018B2037DC
		private void SendDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B2039F4-0x000000018B203A7C
		private void SendEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018B203A7C-0x000000018B203ACC
		private void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018B203940-0x000000018B2039F4
		private void SendLayoutChange(string layout, InputControlLayoutChange change); // 0x000000018B203AEC-0x000000018B203C00
		private void Send(Message msg); // 0x000000018B203CAC-0x000000018B203D38
		private int FindOrCreateSenderRecord(int senderId); // 0x000000018B2034D8-0x000000018B2035B0
		private static InternedString BuildLayoutNamespace(int senderId); // 0x000000018B2033EC-0x000000018B20346C
		private int FindLocalDeviceId(int remoteDeviceId, int senderIndex); // 0x000000018B20346C-0x000000018B2034D8
		private UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex); // 0x000000018B2041E8-0x000000018B204218
		public void RemoveRemoteDevices(int participantId); // 0x000000018B2035B0-0x000000018B203694
		private static byte[] SerializeData<TData>(TData data);
		private static TData DeserializeData<TData>(byte[] data);
	}

	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 47516
	{
		// Fields
		public static readonly Guid kNewDeviceMsg; // 0x00
		public static readonly Guid kNewLayoutMsg; // 0x10
		public static readonly Guid kNewEventsMsg; // 0x20
		public static readonly Guid kRemoveDeviceMsg; // 0x30
		public static readonly Guid kChangeUsagesMsg; // 0x40
		public static readonly Guid kStartSendingMsg; // 0x50
		public static readonly Guid kStopSendingMsg; // 0x60
		[SerializeField]
		private IEditorPlayerConnection m_Connection; // 0x18
		[NonSerialized]
		private Subscriber[] m_Subscribers; // 0x20
		[SerializeField]
		private int[] m_ConnectedIds; // 0x28
	
		// Nested types
		private class Subscriber : IDisposable // TypeDefIndex: 47515
		{
			// Fields
			public RemoteInputPlayerConnection owner; // 0x10
			public IObserver<InputRemoting.Message> observer; // 0x18
	
			// Constructors
			public Subscriber(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Dispose(); // 0x000000018B2067E8-0x000000018B206834
		}
	
		// Constructors
		public RemoteInputPlayerConnection(); // 0x0000000183573370-0x0000000183573380
		static RemoteInputPlayerConnection(); // 0x000000018B206224-0x000000018B2063FC
	
		// Methods
		public void Bind(IEditorPlayerConnection connection, bool isConnected); // 0x000000018B205830-0x000000018B205CB0
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer); // 0x000000018B205F78-0x000000018B2060CC
		private void OnConnected(int id); // 0x000000018B205CC0-0x000000018B205D68
		private void OnDisconnected(int id); // 0x000000018B205D68-0x000000018B205E14
		private void OnNewDevice(MessageEventArgs args); // 0x000000018B205E14-0x000000018B205E24
		private void OnNewLayout(MessageEventArgs args); // 0x000000018B205E34-0x000000018B205E44
		private void OnNewEvents(MessageEventArgs args); // 0x000000018B205E24-0x000000018B205E34
		private void OnRemoveDevice(MessageEventArgs args); // 0x000000018B205E44-0x000000018B205E54
		private void OnChangeUsages(MessageEventArgs args); // 0x000000018B205CB0-0x000000018B205CC0
		private void OnStartSending(MessageEventArgs args); // 0x000000018B205E54-0x000000018B205E64
		private void OnStopSending(MessageEventArgs args); // 0x000000018B205E64-0x000000018B205E74
		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args); // 0x000000018B205E74-0x000000018B205F78
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg); // 0x000000018B2060CC-0x000000018B206224
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error); // 0x00000001841E1670-0x00000001841E1680
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(); // 0x00000001841E1670-0x00000001841E1680
	}

	[InputControlLayout(isGenericTypeOfDevice = true)]
	public class Sensor : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 47517
	{
		// Properties
		public float samplingFrequency { get; set; } // 0x000000018B20651C-0x000000018B2065FC 0x000000018B2065FC-0x000000018B206674
	
		// Constructors
		public Sensor(); // 0x00000001853971D4-0x00000001853971DC
	}

	[InputControlLayout(stateType = typeof(AccelerometerState))]
	public class Accelerometer : Sensor // TypeDefIndex: 47518
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _acceleration_k__BackingField; // 0x190
		[CompilerGenerated]
		private static Accelerometer _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static Accelerometer current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FF37C-0x000000018B1FF3B4 0x000000018B1FF3B4-0x000000018B1FF404
	
		// Constructors
		public Accelerometer(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1FF328-0x000000018B1FF330
		protected override void OnRemoved(); // 0x000000018B1FF330-0x000000018B1FF37C
		protected override void FinishSetup(); // 0x000000018B1FF2C8-0x000000018B1FF328
	}

	[InputControlLayout(stateType = typeof(GyroscopeState))]
	public class Gyroscope : Sensor // TypeDefIndex: 47519
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _angularVelocity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static Gyroscope _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control angularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static Gyroscope current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FFE98-0x000000018B1FFED0 0x000000018B1FFED0-0x000000018B1FFF20
	
		// Constructors
		public Gyroscope(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1FFE44-0x000000018B1FFE4C
		protected override void OnRemoved(); // 0x000000018B1FFE4C-0x000000018B1FFE98
		protected override void FinishSetup(); // 0x000000018B1FFDE4-0x000000018B1FFE44
	}

	[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
	public class GravitySensor : Sensor // TypeDefIndex: 47520
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _gravity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static GravitySensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control gravity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static GravitySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FFD5C-0x000000018B1FFD94 0x000000018B1FFD94-0x000000018B1FFDE4
	
		// Constructors
		public GravitySensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1FFCA8-0x000000018B1FFD08
		public override void MakeCurrent(); // 0x000000018B1FFD08-0x000000018B1FFD10
		protected override void OnRemoved(); // 0x000000018B1FFD10-0x000000018B1FFD5C
	}

	[InputControlLayout(stateType = typeof(AttitudeState), displayName = "Attitude")]
	public class AttitudeSensor : Sensor // TypeDefIndex: 47521
	{
		// Fields
		[CompilerGenerated]
		private QuaternionControl _attitude_k__BackingField; // 0x190
		[CompilerGenerated]
		private static AttitudeSensor _current_k__BackingField; // 0x00
	
		// Properties
		public QuaternionControl attitude { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static AttitudeSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FF5F4-0x000000018B1FF62C 0x000000018B1FF62C-0x000000018B1FF67C
	
		// Constructors
		public AttitudeSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1FF5A0-0x000000018B1FF5A8
		protected override void OnRemoved(); // 0x000000018B1FF5A8-0x000000018B1FF5F4
		protected override void FinishSetup(); // 0x000000018B1FF540-0x000000018B1FF5A0
	}

	[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
	public class LinearAccelerationSensor : Sensor // TypeDefIndex: 47522
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _acceleration_k__BackingField; // 0x190
		[CompilerGenerated]
		private static LinearAccelerationSensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static LinearAccelerationSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B2044A8-0x000000018B2044E0 0x000000018B2044E0-0x000000018B204530
	
		// Constructors
		public LinearAccelerationSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B204454-0x000000018B20445C
		protected override void OnRemoved(); // 0x000000018B20445C-0x000000018B2044A8
		protected override void FinishSetup(); // 0x000000018B2043F4-0x000000018B204454
	}

	[InputControlLayout(displayName = "Magnetic Field")]
	public class MagneticFieldSensor : Sensor // TypeDefIndex: 47523
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _magneticField_k__BackingField; // 0x190
		[CompilerGenerated]
		private static MagneticFieldSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Magnetic Field", noisy = true)]
		public Vector3Control magneticField { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static MagneticFieldSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B2045E4-0x000000018B20461C 0x000000018B20461C-0x000000018B20466C
	
		// Constructors
		public MagneticFieldSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B204590-0x000000018B204598
		protected override void OnRemoved(); // 0x000000018B204598-0x000000018B2045E4
		protected override void FinishSetup(); // 0x000000018B204530-0x000000018B204590
	}

	[InputControlLayout(displayName = "Light")]
	public class LightSensor : Sensor // TypeDefIndex: 47524
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _lightLevel_k__BackingField; // 0x190
		[CompilerGenerated]
		private static LightSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Light Level", noisy = true)]
		public AxisControl lightLevel { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static LightSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B20436C-0x000000018B2043A4 0x000000018B2043A4-0x000000018B2043F4
	
		// Constructors
		public LightSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B204318-0x000000018B204320
		protected override void OnRemoved(); // 0x000000018B204320-0x000000018B20436C
		protected override void FinishSetup(); // 0x000000018B2042B8-0x000000018B204318
	}

	[InputControlLayout(displayName = "Pressure")]
	public class PressureSensor : Sensor // TypeDefIndex: 47525
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _atmosphericPressure_k__BackingField; // 0x190
		[CompilerGenerated]
		private static PressureSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Atmospheric Pressure", noisy = true)]
		public AxisControl atmosphericPressure { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static PressureSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B20566C-0x000000018B2056A4 0x000000018B2056A4-0x000000018B2056F4
	
		// Constructors
		public PressureSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B205618-0x000000018B205620
		protected override void OnRemoved(); // 0x000000018B205620-0x000000018B20566C
		protected override void FinishSetup(); // 0x000000018B2055B8-0x000000018B205618
	}

	[InputControlLayout(displayName = "Proximity")]
	public class ProximitySensor : Sensor // TypeDefIndex: 47526
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _distance_k__BackingField; // 0x190
		[CompilerGenerated]
		private static ProximitySensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Distance", noisy = true)]
		public AxisControl distance { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static ProximitySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B2057A8-0x000000018B2057E0 0x000000018B2057E0-0x000000018B205830
	
		// Constructors
		public ProximitySensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B205754-0x000000018B20575C
		protected override void OnRemoved(); // 0x000000018B20575C-0x000000018B2057A8
		protected override void FinishSetup(); // 0x000000018B2056F4-0x000000018B205754
	}

	[InputControlLayout(displayName = "Humidity")]
	public class HumiditySensor : Sensor // TypeDefIndex: 47527
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _relativeHumidity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static HumiditySensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Relative Humidity", noisy = true)]
		public AxisControl relativeHumidity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static HumiditySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B200110-0x000000018B200148 0x000000018B200148-0x000000018B200198
	
		// Constructors
		public HumiditySensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B2000BC-0x000000018B2000C4
		protected override void OnRemoved(); // 0x000000018B2000C4-0x000000018B200110
		protected override void FinishSetup(); // 0x000000018B20005C-0x000000018B2000BC
	}

	[InputControlLayout(displayName = "Ambient Temperature")]
	public class AmbientTemperatureSensor : Sensor // TypeDefIndex: 47528
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _ambientTemperature_k__BackingField; // 0x190
		[CompilerGenerated]
		private static AmbientTemperatureSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Ambient Temperature", noisy = true)]
		public AxisControl ambientTemperature { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static AmbientTemperatureSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FF4B8-0x000000018B1FF4F0 0x000000018B1FF4F0-0x000000018B1FF540
	
		// Constructors
		public AmbientTemperatureSensor(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1FF464-0x000000018B1FF46C
		protected override void OnRemoved(); // 0x000000018B1FF46C-0x000000018B1FF4B8
		protected override void FinishSetup(); // 0x000000018B1FF404-0x000000018B1FF464
	}

	[InputControlLayout(displayName = "Step Counter")]
	public class StepCounter : Sensor // TypeDefIndex: 47529
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _stepCounter_k__BackingField; // 0x190
		[CompilerGenerated]
		private static StepCounter _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Step Counter", noisy = true)]
		public IntegerControl stepCounter { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static StepCounter current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B206744-0x000000018B20677C 0x000000018B20677C-0x000000018B2067CC
	
		// Constructors
		public StepCounter(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B2066F0-0x000000018B2066F8
		protected override void OnRemoved(); // 0x000000018B2066F8-0x000000018B206744
		protected override void FinishSetup(); // 0x000000018B206690-0x000000018B2066F0
	}

	[InputControlLayout(displayName = "Hinge Angle")]
	public class HingeAngle : Sensor // TypeDefIndex: 47530
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _angle_k__BackingField; // 0x190
		[CompilerGenerated]
		private static HingeAngle _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl angle { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public static HingeAngle current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B1FFFD4-0x000000018B20000C 0x000000018B20000C-0x000000018B20005C
	
		// Constructors
		public HingeAngle(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B1FFF80-0x000000018B1FFF88
		protected override void OnRemoved(); // 0x000000018B1FFF88-0x000000018B1FFFD4
		protected override void FinishSetup(); // 0x000000018B1FFF20-0x000000018B1FFF80
	}

	public enum TouchPhase // TypeDefIndex: 47531
	{
		None = 0,
		Began = 1,
		Moved = 2,
		Ended = 3,
		Canceled = 4,
		Stationary = 5
	}

	[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
	public class Touchscreen : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset // TypeDefIndex: 47532
	{
		// Fields
		[CompilerGenerated]
		private TouchControl _primaryTouch_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ReadOnlyArray<TouchControl> _touches_k__BackingField; // 0x1C8
		private static readonly ProfilerMarker k_TouchscreenUpdateMarker; // 0x00
		private static readonly ProfilerMarker k_TouchAllocateMarker; // 0x08
		[CompilerGenerated]
		private static Touchscreen _current_k__BackingField; // 0x10
		internal static float s_TapTime; // 0x18
		internal static float s_TapDelayTime; // 0x1C
		internal static float s_TapRadiusSquared; // 0x20
	
		// Properties
		public TouchControl primaryTouch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public ReadOnlyArray<TouchControl> touches { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184DABF40-0x0000000184DABF50 0x000000018B208040-0x000000018B208058
		protected TouchControl[] touchControlArray { get; set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x000000018B207FD4-0x000000018B208040
		public static new Touchscreen current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018B207F24-0x000000018B207F74 0x000000018B207F74-0x000000018B207FD4
	
		// Constructors
		public Touchscreen(); // 0x00000001853971D4-0x00000001853971DC
		static Touchscreen(); // 0x0000000184CE9B30-0x0000000184CE9BD0
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B206C18-0x000000018B206C68
		protected override void OnRemoved(); // 0x000000018B2070A8-0x000000018B207108
		protected override void FinishSetup(); // 0x000000018B206880-0x000000018B206C18
		protected new void OnNextUpdate(); // 0x000000018B206D4C-0x000000018B2070A8
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B207108-0x000000018B207870
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018B207F14-0x000000018B207F1C
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018B207F1C-0x000000018B207F24
		new bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x000000018B207CC8-0x000000018B207F14
		void ICustomDeviceReset.Reset(); // 0x000000018B207908-0x000000018B207C6C
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018B206C68-0x000000018B206D4C
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018B207C6C-0x000000018B207CC8
		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr); // 0x000000018B207870-0x000000018B207908
	}

	[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = true)]
	public class TrackedDevice : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 47533
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _trackingState_k__BackingField; // 0x190
		[CompilerGenerated]
		private ButtonControl _isTracked_k__BackingField; // 0x198
		[CompilerGenerated]
		private Vector3Control _devicePosition_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private QuaternionControl _deviceRotation_k__BackingField; // 0x1A8
	
		// Properties
		[InputControl(synthetic = true)]
		public IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		[InputControl(synthetic = true)]
		public ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		[InputControl(noisy = true, dontReset = true)]
		public Vector3Control devicePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		[InputControl(noisy = true, dontReset = true)]
		public QuaternionControl deviceRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
	
		// Constructors
		public TrackedDevice(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B208058-0x000000018B20817C
	}

	public static class InputExtensions // TypeDefIndex: 47534
	{
		// Extension methods
		public static bool IsInProgress(this InputActionPhase phase); // 0x00000001835298B0-0x00000001835298C0
		public static bool IsEndedOrCanceled(this UnityEngine.InputSystem.TouchPhase phase); // 0x000000018B2001AC-0x000000018B2001BC
		public static bool IsActive(this UnityEngine.InputSystem.TouchPhase phase); // 0x000000018B200198-0x000000018B2001AC
		public static bool IsModifierKey(this UnityEngine.InputSystem.Key key); // 0x000000018B2001BC-0x000000018B2001C8
		public static bool IsTextInputKey(this UnityEngine.InputSystem.Key key); // 0x000000018B2001C8-0x000000018B2001E4
	}

	internal static class InputFeatureNames // TypeDefIndex: 47535
	{
		// Fields
		public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE"; // Metadata: 0x0232A3B6
		public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT"; // Metadata: 0x0232A3D6
		public const string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS"; // Metadata: 0x0232A3F3
		public const string kUseReadValueCaching = "USE_READ_VALUE_CACHING"; // Metadata: 0x0232A40A
		public const string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS"; // Metadata: 0x0232A421
	}

	internal class InputManager // TypeDefIndex: 47544
	{
		// Fields
		private static readonly ProfilerMarker k_InputUpdateProfilerMarker; // 0x00
		private static readonly ProfilerMarker k_InputTryFindMatchingControllerMarker; // 0x08
		private static readonly ProfilerMarker k_InputAddDeviceMarker; // 0x10
		private static readonly ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; // 0x18
		private static readonly ProfilerMarker k_InputRegisterCustomTypesMarker; // 0x20
		private static readonly ProfilerMarker k_InputOnBeforeUpdateMarker; // 0x28
		private static readonly ProfilerMarker k_InputOnAfterUpdateMarker; // 0x30
		private static readonly ProfilerMarker k_InputOnSettingsChangeMarker; // 0x38
		private static readonly ProfilerMarker k_InputOnDeviceSettingsChangeMarker; // 0x40
		private static readonly ProfilerMarker k_InputOnEventMarker; // 0x48
		private static readonly ProfilerMarker k_InputOnLayoutChangeMarker; // 0x50
		private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x58
		private static readonly ProfilerMarker k_InputOnActionsChangeMarker; // 0x60
		internal int m_LayoutRegistrationVersion; // 0x10
		private float m_PollingFrequency; // 0x14
		internal InputControlLayout.Collection m_Layouts; // 0x18
		private TypeTable m_Processors; // 0x58
		private TypeTable m_Interactions; // 0x60
		private TypeTable m_Composites; // 0x68
		private int m_DevicesCount; // 0x70
		private UnityEngine.InputSystem.InputDevice[] m_Devices; // 0x78
		private Dictionary<int, UnityEngine.InputSystem.InputDevice> m_DevicesById; // 0x80
		internal int m_AvailableDeviceCount; // 0x88
		internal AvailableDevice[] m_AvailableDevices; // 0x90
		internal int m_DisconnectedDevicesCount; // 0x98
		internal UnityEngine.InputSystem.InputDevice[] m_DisconnectedDevices; // 0xA0
		internal InputUpdateType m_UpdateMask; // 0xA8
		private InputUpdateType m_CurrentUpdate; // 0xAC
		internal InputStateBuffers m_StateBuffers; // 0xB0
		private InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0xE8
		private CallbackArray<Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange>> m_DeviceChangeListeners; // 0xF0
		private CallbackArray<Action<UnityEngine.InputSystem.InputDevice, InputEventPtr>> m_DeviceStateChangeListeners; // 0x140
		private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; // 0x190
		internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks; // 0x1E0
		private CallbackArray<Action<string, InputControlLayoutChange>> m_LayoutChangeListeners; // 0x230
		private CallbackArray<Action<InputEventPtr, UnityEngine.InputSystem.InputDevice>> m_EventListeners; // 0x280
		private CallbackArray<Action> m_BeforeUpdateListeners; // 0x2D0
		private CallbackArray<Action> m_AfterUpdateListeners; // 0x320
		private CallbackArray<Action> m_SettingsChangedListeners; // 0x370
		private bool m_NativeBeforeUpdateHooked; // 0x3C0
		private bool m_HaveDevicesWithStateCallbackReceivers; // 0x3C1
		private bool m_HasFocus; // 0x3C2
		private InputEventStream m_InputEventStream; // 0x3C8
		private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; // 0x440
		private int m_DeviceFindExecuteCommandDeviceId; // 0x448
		internal IInputRuntime m_Runtime; // 0x450
		internal InputMetrics m_Metrics; // 0x458
		internal InputSettings m_Settings; // 0x490
		private bool m_OptimizedControlsFeatureEnabled; // 0x498
		private bool m_ReadValueCachingFeatureEnabled; // 0x499
		private bool m_ParanoidReadValueCachingChecksEnabled; // 0x49A
		private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x49B
		internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; // 0x4A0
		private InlinedArray<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; // 0x4A8
	
		// Properties
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x0000000183DF8D60-0x0000000183DF8DC0 
		public TypeTable processors { get; } // 0x0000000182E56440-0x0000000182E56460 
		public TypeTable interactions { get; } // 0x0000000184D86280-0x0000000184D86290 
		public TypeTable composites { get; } // 0x0000000184D86230-0x0000000184D86240 
		public InputMetrics metrics { get; } // 0x000000018B202E74-0x000000018B202FF8 
		public InputSettings settings { get; set; } // 0x0000000184D8DC30-0x0000000184D8DC40 0x000000018B2032F8-0x000000018B2033EC
		public InputUpdateType updateMask { get; set; } // 0x0000000184D88C80-0x0000000184D88C90 0x0000000183DF9BE0-0x0000000183DF9C10
		public InputUpdateType defaultUpdateType { get; } // 0x000000018381FC00-0x000000018381FC20 
		public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get; set; } // 0x0000000184D92890-0x0000000184D928A0 0x0000000183DF9BD0-0x0000000183DF9BE0
		public float pollingFrequency { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x000000018B203258-0x000000018B2032F8
		public bool isProcessingEvents { get; } // 0x0000000184DABED0-0x0000000184DABEE0 
		private bool gameIsPlaying { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		private bool gameHasFocus { get; } // 0x00000001830CE7D0-0x00000001830CE810 
		private bool gameShouldGetInputRegardlessOfFocus { get; } // 0x00000001830CD8B0-0x00000001830CD8E0 
		internal bool optimizedControlsFeatureEnabled { get; set; } // 0x0000000184DABEE0-0x0000000184DABEF0 0x0000000184DABF10-0x0000000184DABF20
		internal bool readValueCachingFeatureEnabled { get; set; } // 0x0000000184DABF00-0x0000000184DABF10 0x0000000184DABF30-0x0000000184DABF40
		internal bool paranoidReadValueCachingChecksEnabled { get; set; } // 0x0000000184DABEF0-0x0000000184DABF00 0x0000000184DABF20-0x0000000184DABF30
	
		// Events
		public event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange {
			add; // 0x0000000183DFA450-0x0000000183DFA4A0
			remove; // 0x000000018B203044-0x000000018B203090
		}
		public event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onDeviceStateChange {
			add; // 0x000000018B202D90-0x000000018B202DDC
			remove; // 0x000000018B2030DC-0x000000018B203128
		}
		public event InputDeviceCommandDelegate onDeviceCommand {
			add; // 0x000000018B202D44-0x000000018B202D90
			remove; // 0x000000018B203090-0x000000018B2030DC
		}
		public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice {
			add; // 0x0000000183DF7EE0-0x0000000183DF7F40
			remove; // 0x000000018B203174-0x000000018B2031C0
		}
		public event Action<string, InputControlLayoutChange> onLayoutChange {
			add; // 0x000000018B202E28-0x000000018B202E74
			remove; // 0x000000018B2031C0-0x000000018B20320C
		}
		public event Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEvent {
			add; // 0x000000018B202DDC-0x000000018B202E28
			remove; // 0x000000018B203128-0x000000018B203174
		}
		public event Action onBeforeUpdate {
			add; // 0x0000000183DFB1C0-0x0000000183DFB220
			remove; // 0x0000000184CDCE00-0x0000000184CDCE50
		}
		public event Action onAfterUpdate {
			add; // 0x0000000183DFB170-0x0000000183DFB1C0
			remove; // 0x000000018B202FF8-0x000000018B203044
		}
		public event Action onSettingsChange {
			add; // 0x0000000183DFB120-0x0000000183DFB170
			remove; // 0x000000018B20320C-0x000000018B203258
		}
	
		// Nested types
		internal enum DeviceDisableScope // TypeDefIndex: 47536
		{
			Everywhere = 0,
			InFrontendOnly = 1,
			TemporaryWhilePlayerIsInBackground = 2
		}
	
		[Serializable]
		internal struct AvailableDevice // TypeDefIndex: 47537
		{
			// Fields
			public InputDeviceDescription description; // 0x00
			public int deviceId; // 0x38
			public bool isNative; // 0x3C
			public bool isRemoved; // 0x3D
		}
	
		private struct StateChangeMonitorTimeout // TypeDefIndex: 47538
		{
			// Fields
			public InputControl control; // 0x00
			public double time; // 0x08
			public IInputStateChangeMonitor monitor; // 0x10
			public long monitorIndex; // 0x18
			public int timerIndex; // 0x20
		}
	
		internal struct StateChangeMonitorListener // TypeDefIndex: 47539
		{
			// Fields
			public InputControl control; // 0x00
			public IInputStateChangeMonitor monitor; // 0x08
			public long monitorIndex; // 0x10
			public uint groupIndex; // 0x18
		}
	
		internal struct StateChangeMonitorsForDevice // TypeDefIndex: 47540
		{
			// Fields
			public MemoryHelpers.BitRegion[] memoryRegions; // 0x00
			public StateChangeMonitorListener[] listeners; // 0x08
			public DynamicBitfield signalled; // 0x10
			public bool needToUpdateOrderingOfMonitors; // 0x30
			public bool needToCompactArrays; // 0x31
	
			// Properties
			public int count { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
	
			// Methods
			public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex); // 0x0000000183DFCF40-0x0000000183DFD0E0
			public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval); // 0x000000018B21A06C-0x000000018B21A160
			public void Clear(); // 0x000000018B219F34-0x000000018B219F84
			public void CompactArrays(); // 0x000000018B219F84-0x000000018B219FE0
			private void RemoveAt(int i); // 0x000000018B219FE0-0x000000018B21A06C
			public void SortMonitorsByIndex(); // 0x0000000184886DA0-0x0000000184886E70
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__76<TDevice> // TypeDefIndex: 47541
			where TDevice : UnityEngine.InputSystem.InputDevice, new()
		{
			// Fields
			public static readonly __c__76<TDevice> __9;
			public static Func<UnityEngine.InputSystem.InputDevice> __9__76_0;
	
			// Constructors
			static __c__76();
			public __c__76();
	
			// Methods
			internal UnityEngine.InputSystem.InputDevice _RegisterPrecompiledLayout_b__76_0();
		}
	
		[CompilerGenerated]
		private sealed class _ListControlLayouts_d__91 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 47542
		{
			// Fields
			private int __1__state; // 0x10
			private string __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private string basedOn; // 0x28
			public string __3__basedOn; // 0x30
			public InputManager __4__this; // 0x38
			private InternedString _internedBasedOn_5__2; // 0x40
			private Dictionary<InternedString, System.Type> __7__wrap2; // 0x50
			private Dictionary<InternedString, string> __7__wrap3; // 0x80
			private Dictionary<InternedString, Func<InputControlLayout>> __7__wrap4; // 0xB0
	
			// Properties
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ListControlLayouts_d__91(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B21C570-0x000000018B21C820
			private bool MoveNext(); // 0x000000018B21B71C-0x000000018B21C478
			private void __m__Finally1(); // 0x000000018B21C820-0x000000018B21C85C
			private void __m__Finally2(); // 0x000000018B21C85C-0x000000018B21C898
			private void __m__Finally3(); // 0x000000018B21C898-0x000000018B21C8D4
			private void __m__Finally4(); // 0x000000018B21C8D4-0x000000018B21C910
			private void __m__Finally5(); // 0x000000018B21C910-0x000000018B21C94C
			private void __m__Finally6(); // 0x000000018B21C94C-0x000000018B21C988
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B21C524-0x000000018B21C570
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018B21C478-0x000000018B21C51C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B21C51C-0x000000018B21C524
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47543
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<UnityEngine.InputSystem.InputDevice, string> __9__175_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D45C10-0x0000000184D45C70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _MakeDeviceNameUnique_b__175_0(UnityEngine.InputSystem.InputDevice x); // 0x0000000184A1E9B0-0x0000000184A1EA20
		}
	
		// Constructors
		public InputManager(); // 0x00000001841E1670-0x00000001841E1680
		static InputManager(); // 0x000000018489AC30-0x000000018489AF50
	
		// Methods
		public void RegisterControlLayout(string name, System.Type type); // 0x0000000183AEE050-0x0000000183AEEE80
		public void RegisterControlLayout(string json, string name = null, bool isOverride = false /* Metadata: 0x0232A444 */); // 0x0000000183DF7450-0x0000000183DF76B0
		public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null); // 0x000000018B2016DC-0x000000018B2018EC
		private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false /* Metadata: 0x0232A445 */, bool isOverride = false /* Metadata: 0x0232A446 */); // 0x0000000183AEDAF0-0x0000000183AEDEB0
		public void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new();
		private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false /* Metadata: 0x0232A447 */); // 0x0000000183AEF210-0x0000000183AEF410
		private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout); // 0x000000018B200E5C-0x000000018B200F40
		private bool IsControlUsingLayout(InputControl control, InternedString layout); // 0x000000018B200F40-0x000000018B201014
		public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher); // 0x0000000183AEC5C0-0x0000000183AEC6B0
		public void RegisterControlLayoutMatcher(System.Type type, InputDeviceMatcher matcher); // 0x0000000183AEBCE0-0x0000000183AEBDD0
		private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher); // 0x0000000183AEC240-0x0000000183AEC4D0
		private void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, InternedString newLayout); // 0x000000018B201550-0x000000018B2016DC
		private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout); // 0x0000000183AEC4D0-0x0000000183AEC5C0
		public void RemoveControlLayout(string name); // 0x000000018B2018EC-0x000000018B201B58
		public InputControlLayout TryLoadControlLayout(System.Type type); // 0x000000018B2028F4-0x000000018B202B44
		public InputControlLayout TryLoadControlLayout(InternedString name); // 0x000000018B2028CC-0x000000018B2028F4
		public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0 /* Metadata: 0x0232A448 */); // 0x0000000183AEB070-0x0000000183AEBBA0
		private InternedString FindOrRegisterDeviceLayoutForType(System.Type type); // 0x00000001846EA290-0x00000001846EA2F0
		private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName); // 0x000000018B201014-0x000000018B201128
		[IteratorStateMachine(typeof(_ListControlLayouts_d__91))]
		public IEnumerable<string> ListControlLayouts(string basedOn = null); // 0x000000018B201128-0x000000018B2011B0
		public int GetControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl;
		public void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B202544-0x000000018B2026A8
		public void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B2001E4-0x000000018B200348
		public void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018B201B58-0x000000018B201CBC
		private void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device); // 0x000000018B201430-0x000000018B2014F0
		public UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name = null); // 0x000000018B2004B8-0x000000018B2005AC
		public UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, InternedString variants = default); // 0x000000018B2005AC-0x000000018B20070C
		private UnityEngine.InputSystem.InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = default, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x0232A449 */, InternedString variants = default); // 0x0000000183AE9300-0x0000000183AE94D0
		public void AddDevice(UnityEngine.InputSystem.InputDevice device); // 0x0000000183AE8510-0x0000000183AE8890
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description); // 0x000000018B20070C-0x000000018B200760
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0 /* Metadata: 0x0232A44A */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x0232A44B */); // 0x0000000183AEAEC0-0x0000000183AEB070
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0 /* Metadata: 0x0232A44C */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x0232A44D */); // 0x000000018B200348-0x000000018B2004B8
		public void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices = false /* Metadata: 0x0232A44E */); // 0x000000018B201CBC-0x000000018B2020D0
		public void FlushDisconnectedDevices(); // 0x000000018B200A80-0x000000018B200AD0
		public void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x0232A44F */, bool? issueResetCommand = default); // 0x000000018381F4F0-0x000000018381FC00
		public UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout); // 0x000000018B202760-0x000000018B202878
		public UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout); // 0x000000018B200AD0-0x000000018B200B80
		public UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType); // 0x000000018B202878-0x000000018B2028CC
		public UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id); // 0x00000001833FE7F0-0x00000001833FE910
		public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions); // 0x000000018B200B80-0x000000018B200CC8
		public void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, DeviceDisableScope scope = DeviceDisableScope.Everywhere /* Metadata: 0x0232A450 */); // 0x000000018381FDC0-0x000000018381FF80
		private unsafe void QueueEvent(InputEvent* eventPtr); // 0x000000018B2014F0-0x000000018B201550
		public void QueueEvent(InputEventPtr ptr); // 0x00000001876D2304-0x00000001876D230C
		public void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo;
		public void Update(); // 0x000000018B202D20-0x000000018B202D44
		public void Update(InputUpdateType updateType); // 0x0000000184B1ECA0-0x0000000184B1ECE0
		internal void Initialize(IInputRuntime runtime, InputSettings settings); // 0x0000000183DF6F90-0x0000000183DF6FF0
		internal void Destroy(); // 0x000000018B20099C-0x000000018B200A80
		internal void InitializeData(); // 0x0000000183DF5480-0x0000000183DF6650
		private void RegisterCustomTypes(System.Type[] types); // 0x0000000182F2AD30-0x0000000182F2AFB0
		private void RegisterCustomTypes(); // 0x0000000183B0E4A0-0x0000000183B0E680
		internal void InstallRuntime(IInputRuntime runtime); // 0x0000000183EB34C0-0x0000000183EB3830
		internal void InstallGlobals(); // 0x0000000183DF7940-0x0000000183DF7BB0
		internal void UninstallGlobals(); // 0x000000018B202B44-0x000000018B202D20
		private void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device); // 0x0000000183AE8900-0x0000000183AE8AB0
		private static void ResetControlPathsRecursive(InputControl control); // 0x000000018B202478-0x000000018B202544
		private void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device); // 0x0000000183AE88A0-0x0000000183AE8900
		private void ReallocateStateBuffers(); // 0x0000000183AE8AB0-0x0000000183AE8CA0
		private void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device); // 0x000000018B200CC8-0x000000018B200E5C
		private void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device); // 0x0000000183AEF850-0x0000000183AEFB90
		private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor); // 0x0000000183AEA710-0x0000000183AEAC80
		private JsonParser.JsonString MakeEscapedJsonString(string theString); // 0x000000018B2011B0-0x000000018B201300
		private UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor); // 0x0000000183AEACE0-0x0000000183AEADB0
		private void InstallBeforeUpdateHookIfNecessary(); // 0x0000000183DFB220-0x0000000183DFB300
		private void RestoreDevicesAfterDomainReloadIfNecessary(); // 0x00000001841E1670-0x00000001841E1680
		private void WarnAboutDevicesFailingToRecreateAfterDomainReload(); // 0x00000001841E1670-0x00000001841E1680
		private void OnBeforeUpdate(InputUpdateType updateType); // 0x00000001830CFC50-0x00000001830CFE60
		internal void ApplySettings(); // 0x0000000183DF8060-0x0000000183DF8D60
		internal long ExecuteGlobalCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
		internal void AddAvailableDevicesThatAreNowRecognized(); // 0x0000000183DF7F40-0x0000000183DF7FE0
		private bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device); // 0x00000001838202E0-0x0000000183820320
		internal void OnFocusChanged(bool focus); // 0x00000001838200C0-0x00000001838202A0
		internal bool ShouldRunUpdate(InputUpdateType updateType); // 0x0000000183EE1670-0x0000000183EE1690
		private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // 0x00000001830CEAB0-0x00000001830CF780
		private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed); // 0x0000000183FA35E0-0x0000000183FA3620
		private string MakeStringWithEventsProcessedByDevice(); // 0x000000018B201300-0x000000018B201430
		private void ResetCurrentProcessedEventBytesForDevices(); // 0x0000000183FCE910-0x0000000183FCE950
		[Conditional("UNITY_EDITOR")]
		private void CheckAllDevicesOptimizedControlsHaveValidState(); // 0x000000018B200834-0x000000018B20099C
		private void InvokeAfterUpdateCallback(InputUpdateType updateType); // 0x00000001830CE6A0-0x00000001830CE710
		internal void DontMakeCurrentlyUpdatingDeviceCurrent(); // 0x0000000184DABEC0-0x0000000184DABED0
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputEvent* eventPtr, InputUpdateType updateType); // 0x000000018400B550-0x000000018400B620
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = default); // 0x00000001830D01F0-0x00000001830D0CB0
		private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers); // 0x00000001830D0CB0-0x00000001830D0F30
		private bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType); // 0x00000001830D1710-0x00000001830D17E0
		public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex); // 0x0000000183DFCDF0-0x0000000183DFCF40
		private void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device); // 0x000000018B202358-0x000000018B202478
		public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex); // 0x000000018B2021F0-0x000000018B202358
		public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex); // 0x000000018B200760-0x000000018B200834
		public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex); // 0x000000018B2020D0-0x000000018B2021F0
		private void SortStateChangeMonitorsIfNecessary(int deviceIndex); // 0x00000001830D12F0-0x00000001830D1350
		public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor); // 0x000000018B2026A8-0x000000018B202760
		public void FireStateChangeNotifications(); // 0x0000000184B6B440-0x0000000184B6B510
		private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes); // 0x00000001830D1350-0x00000001830D1680
		internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr); // 0x00000001830D26E0-0x00000001830D29B0
		private void ProcessStateChangeMonitorTimeouts(); // 0x00000001830CE880-0x00000001830CE8B0
		[CompilerGenerated]
		private long _TryFindMatchingControlLayout_b__88_0(ref InputDeviceCommand commandRef); // 0x00000001848AE410-0x00000001848AE490
	}

	public class InputSettings : ScriptableObject // TypeDefIndex: 47550
	{
		// Fields
		[SerializeField]
		[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
		private string[] m_SupportedDevices; // 0x18
		[SerializeField]
		[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
		private UpdateMode m_UpdateMode; // 0x20
		[SerializeField]
		private ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0x24
		[SerializeField]
		private int m_MaxEventBytesPerUpdate; // 0x28
		[SerializeField]
		private int m_MaxQueuedEventsPerUpdate; // 0x2C
		[SerializeField]
		private bool m_CompensateForScreenOrientation; // 0x30
		[SerializeField]
		private BackgroundBehavior m_BackgroundBehavior; // 0x34
		[SerializeField]
		private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; // 0x38
		[SerializeField]
		private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; // 0x3C
		[SerializeField]
		private float m_DefaultDeadzoneMin; // 0x40
		[SerializeField]
		private float m_DefaultDeadzoneMax; // 0x44
		[Min(0.0001f)]
		[SerializeField]
		private float m_DefaultButtonPressPoint; // 0x48
		[SerializeField]
		private float m_ButtonReleaseThreshold; // 0x4C
		[SerializeField]
		private float m_DefaultTapTime; // 0x50
		[SerializeField]
		private float m_DefaultSlowTapTime; // 0x54
		[SerializeField]
		private float m_DefaultHoldTime; // 0x58
		[SerializeField]
		private float m_TapRadius; // 0x5C
		[SerializeField]
		private float m_MultiTapDelayTime; // 0x60
		[SerializeField]
		private bool m_DisableRedundantEventsMerging; // 0x64
		[SerializeField]
		private bool m_ShortcutKeysConsumeInputs; // 0x65
		[NonSerialized]
		internal HashSet<string> m_FeatureFlags; // 0x68
		internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; // Metadata: 0x0232A454
	
		// Properties
		public UpdateMode updateMode { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018B20A388-0x000000018B20A398
		public ScrollDeltaBehavior scrollDeltaBehavior { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x000000018B20A218-0x000000018B20A228
		public bool compensateForScreenOrientation { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x000000018B20A0D8-0x000000018B20A0E8
		[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", false)]
		public bool filterNoiseOnCurrent { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public float defaultDeadzoneMin { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x000000018B20A13C-0x000000018B20A158
		public float defaultDeadzoneMax { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x000000018B20A120-0x000000018B20A13C
		public float defaultButtonPressPoint { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x000000018B20A0E8-0x000000018B20A120
		public float buttonReleaseThreshold { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x000000018B20A0BC-0x000000018B20A0D8
		public float defaultTapTime { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x000000018B20A190-0x000000018B20A1AC
		public float defaultSlowTapTime { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x000000018B20A174-0x000000018B20A190
		public float defaultHoldTime { get; set; } // 0x0000000184D88400-0x0000000184D88410 0x000000018B20A158-0x000000018B20A174
		public float tapRadius { get; set; } // 0x0000000184D91500-0x0000000184D91510 0x000000018B20A36C-0x000000018B20A388
		public float multiTapDelayTime { get; set; } // 0x0000000184D88480-0x0000000184D88490 0x000000018B20A1FC-0x000000018B20A218
		public BackgroundBehavior backgroundBehavior { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x000000018B20A0AC-0x000000018B20A0BC
		public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x000000018B20A1BC-0x000000018B20A1CC
		public InputActionPropertyDrawerMode inputActionPropertyDrawerMode { get; set; } // 0x0000000184D86640-0x0000000184D86650 0x000000018B20A1CC-0x000000018B20A1DC
		public int maxEventBytesPerUpdate { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x000000018B20A1DC-0x000000018B20A1EC
		public int maxQueuedEventsPerUpdate { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x000000018B20A1EC-0x000000018B20A1FC
		public ReadOnlyArray<string> supportedDevices { get; set; } // 0x0000000183AEAC80-0x0000000183AEACE0 0x000000018B20A238-0x000000018B20A36C
		public bool disableRedundantEventsMerging { get; set; } // 0x0000000184D8F050-0x0000000184D8F060 0x000000018B20A1AC-0x000000018B20A1BC
		public bool shortcutKeysConsumeInput { get; set; } // 0x0000000184DAA1E0-0x0000000184DAA1F0 0x000000018B20A228-0x000000018B20A238
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 47545
		{
			ProcessEventsInDynamicUpdate = 1,
			ProcessEventsInFixedUpdate = 2,
			ProcessEventsManually = 3
		}
	
		public enum ScrollDeltaBehavior // TypeDefIndex: 47546
		{
			UniformAcrossAllPlatforms = 0,
			KeepPlatformSpecificInputRange = 1
		}
	
		public enum BackgroundBehavior // TypeDefIndex: 47547
		{
			ResetAndDisableNonBackgroundDevices = 0,
			ResetAndDisableAllDevices = 1,
			IgnoreFocus = 2
		}
	
		public enum EditorInputBehaviorInPlayMode // TypeDefIndex: 47548
		{
			PointersAndKeyboardsRespectGameViewFocus = 0,
			AllDevicesRespectGameViewFocus = 1,
			AllDeviceInputAlwaysGoesToGameView = 2
		}
	
		public enum InputActionPropertyDrawerMode // TypeDefIndex: 47549
		{
			Compact = 0,
			MultilineEffective = 1,
			MultilineBoth = 2
		}
	
		// Constructors
		public InputSettings(); // 0x0000000184D54560-0x0000000184D545C0
	
		// Methods
		public void SetInternalFeatureFlag(string featureName, bool enabled); // 0x000000018B209F4C-0x000000018B20A0AC
		internal bool IsFeatureEnabled(string featureName); // 0x000000018B209E38-0x000000018B209EA8
		internal void OnChange(); // 0x000000018B209EA8-0x000000018B209F4C
		private static bool CompareFloats(float a, float b); // 0x000000018B209E24-0x000000018B209E38
		private static bool CompareSets<T>(ReadOnlyArray<T> a, ReadOnlyArray<T> b);
		private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName); // 0x000000018B209DCC-0x000000018B209E24
		internal static bool AreEqual(InputSettings a, InputSettings b); // 0x000000018B209B40-0x000000018B209DCC
	}

	public class DefaultInputActions : IInputActionCollection2, IDisposable // TypeDefIndex: 47555
	{
		// Fields
		[CompilerGenerated]
		private readonly InputActionAsset _asset_k__BackingField; // 0x10
		private readonly InputActionMap m_Player; // 0x18
		private IPlayerActions m_PlayerActionsCallbackInterface; // 0x20
		private readonly InputAction m_Player_Move; // 0x28
		private readonly InputAction m_Player_Look; // 0x30
		private readonly InputAction m_Player_Fire; // 0x38
		private readonly InputActionMap m_UI; // 0x40
		private IUIActions m_UIActionsCallbackInterface; // 0x48
		private readonly InputAction m_UI_Navigate; // 0x50
		private readonly InputAction m_UI_Submit; // 0x58
		private readonly InputAction m_UI_Cancel; // 0x60
		private readonly InputAction m_UI_Point; // 0x68
		private readonly InputAction m_UI_Click; // 0x70
		private readonly InputAction m_UI_ScrollWheel; // 0x78
		private readonly InputAction m_UI_MiddleClick; // 0x80
		private readonly InputAction m_UI_RightClick; // 0x88
		private readonly InputAction m_UI_TrackedDevicePosition; // 0x90
		private readonly InputAction m_UI_TrackedDeviceOrientation; // 0x98
		private int m_KeyboardMouseSchemeIndex; // 0xA0
		private int m_GamepadSchemeIndex; // 0xA4
		private int m_TouchSchemeIndex; // 0xA8
		private int m_JoystickSchemeIndex; // 0xAC
		private int m_XRSchemeIndex; // 0xB0
	
		// Properties
		public InputActionAsset asset { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public InputBinding? bindingMask { get; set; } // 0x000000018B209490-0x000000018B2094E0 0x000000018B209574-0x000000018B2095D4
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x000000018B209534-0x000000018B209574 0x000000018B2095D4-0x000000018B20960C
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018B209500-0x000000018B209534 
		public IEnumerable<InputBinding> bindings { get; } // 0x000000018B2094E0-0x000000018B209500 
		public PlayerActions Player { get; } // 0x000000018339B870-0x000000018339B890 
		public UIActions UI { get; } // 0x000000018339B870-0x000000018339B890 
		public InputControlScheme KeyboardMouseScheme { get; } // 0x000000018B209244-0x000000018B209308 
		public InputControlScheme GamepadScheme { get; } // 0x000000018B2090BC-0x000000018B209180 
		public InputControlScheme TouchScheme { get; } // 0x000000018B209308-0x000000018B2093CC 
		public InputControlScheme JoystickScheme { get; } // 0x000000018B209180-0x000000018B209244 
		public InputControlScheme XRScheme { get; } // 0x000000018B2093CC-0x000000018B209490 
	
		// Nested types
		public struct PlayerActions // TypeDefIndex: 47551
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Move { get; } // 0x000000018AF06FDC-0x000000018AF06FF8 
			public InputAction Look { get; } // 0x000000018B211C98-0x000000018B211CB4 
			public InputAction Fire { get; } // 0x000000018B211C7C-0x000000018B211C98 
			public bool enabled { get; } // 0x000000018B211CB4-0x000000018B211CD8 
	
			// Constructors
			public PlayerActions(DefaultInputActions wrapper); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			public InputActionMap Get(); // 0x000000018AF07200-0x000000018AF0721C
			public void Enable(); // 0x000000018B211470-0x000000018B211494
			public void Disable(); // 0x000000018B21144C-0x000000018B211470
			public static implicit operator InputActionMap(PlayerActions set); // 0x000000018B211CD8-0x000000018B211CF4
			public void SetCallbacks(IPlayerActions instance); // 0x000000018B211494-0x000000018B211C7C
		}
	
		public struct UIActions // TypeDefIndex: 47552
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Navigate { get; } // 0x000000018B21E37C-0x000000018B21E398 
			public InputAction Submit { get; } // 0x000000018AF0721C-0x000000018AF07238 
			public InputAction Cancel { get; } // 0x000000018B21E324-0x000000018B21E340 
			public InputAction Point { get; } // 0x000000018B21E398-0x000000018B21E3B4 
			public InputAction Click { get; } // 0x000000018B21E340-0x000000018B21E35C 
			public InputAction ScrollWheel { get; } // 0x000000018B21E3D4-0x000000018B21E3F0 
			public InputAction MiddleClick { get; } // 0x000000018B21E35C-0x000000018B21E37C 
			public InputAction RightClick { get; } // 0x000000018B21E3B4-0x000000018B21E3D4 
			public InputAction TrackedDevicePosition { get; } // 0x000000018B21E410-0x000000018B21E430 
			public InputAction TrackedDeviceOrientation { get; } // 0x000000018B21E3F0-0x000000018B21E410 
			public bool enabled { get; } // 0x000000018B21E430-0x000000018B21E454 
	
			// Constructors
			public UIActions(DefaultInputActions wrapper); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			public InputActionMap Get(); // 0x000000018B21C9F0-0x000000018B21CA0C
			public void Enable(); // 0x000000018B21C9CC-0x000000018B21C9F0
			public void Disable(); // 0x000000018B21C9A8-0x000000018B21C9CC
			public static implicit operator InputActionMap(UIActions set); // 0x000000018B21E454-0x000000018B21E470
			public void SetCallbacks(IUIActions instance); // 0x000000018B21CA0C-0x000000018B21E324
		}
	
		public interface IPlayerActions // TypeDefIndex: 47553
		{
			// Methods
			void OnMove(InputAction.CallbackContext context);
			void OnLook(InputAction.CallbackContext context);
			void OnFire(InputAction.CallbackContext context);
		}
	
		public interface IUIActions // TypeDefIndex: 47554
		{
			// Methods
			void OnNavigate(InputAction.CallbackContext context);
			void OnSubmit(InputAction.CallbackContext context);
			void OnCancel(InputAction.CallbackContext context);
			void OnPoint(InputAction.CallbackContext context);
			void OnClick(InputAction.CallbackContext context);
			void OnScrollWheel(InputAction.CallbackContext context);
			void OnMiddleClick(InputAction.CallbackContext context);
			void OnRightClick(InputAction.CallbackContext context);
			void OnTrackedDevicePosition(InputAction.CallbackContext context);
			void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
		}
	
		// Constructors
		public DefaultInputActions(); // 0x000000018B208CF4-0x000000018B2090BC
	
		// Methods
		public void Dispose(); // 0x000000018B208BD8-0x000000018B208C28
		public bool Contains(InputAction action); // 0x000000018B208B98-0x000000018B208BB8
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018B208CCC-0x000000018B208CEC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B208CEC-0x000000018B208CF4
		public void Enable(); // 0x000000018B208C28-0x000000018B208C48
		public void Disable(); // 0x000000018B208BB8-0x000000018B208BD8
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0232A463 */); // 0x000000018B208C48-0x000000018B208C68
		public int FindBinding(InputBinding bindingMask, out InputAction action); // 0x000000018B208C68-0x000000018B208CCC
	}

	[DebuggerDisplay("Value = {Get()}")]
	public class InputValue // TypeDefIndex: 47556
	{
		// Fields
		internal InputAction.CallbackContext? m_Context; // 0x10
	
		// Properties
		public bool isPressed { get; } // 0x000000018B2113F0-0x000000018B21144C 
	
		// Constructors
		public InputValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public object Get(); // 0x000000018B211398-0x000000018B2113F0
		public TValue Get<TValue>()
			where TValue : struct;
	}

	[AddComponentMenu("Input/Player Input")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInput.html")]
	public class PlayerInput : MonoBehaviour // TypeDefIndex: 47561
	{
		// Fields
		public const string DeviceLostMessage = "OnDeviceLost"; // Metadata: 0x0232A468
		public const string DeviceRegainedMessage = "OnDeviceRegained"; // Metadata: 0x0232A475
		public const string ControlsChangedMessage = "OnControlsChanged"; // Metadata: 0x0232A486
		private int m_AllMapsHashCode; // 0x18
		[SerializeField]
		[Tooltip("Input actions associated with the player.")]
		internal InputActionAsset m_Actions; // 0x20
		[SerializeField]
		[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
		internal PlayerNotifications m_NotificationBehavior; // 0x28
		[SerializeField]
		[Tooltip("UI InputModule that should have it\'s input actions synchronized to this PlayerInput\'s actions.")]
		internal InputSystemUIInputModule m_UIInputModule; // 0x30
		[SerializeField]
		[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
		internal DeviceLostEvent m_DeviceLostEvent; // 0x38
		[SerializeField]
		internal DeviceRegainedEvent m_DeviceRegainedEvent; // 0x40
		[SerializeField]
		internal ControlsChangedEvent m_ControlsChangedEvent; // 0x48
		[SerializeField]
		internal ActionEvent[] m_ActionEvents; // 0x50
		[SerializeField]
		internal bool m_NeverAutoSwitchControlSchemes; // 0x58
		[SerializeField]
		internal string m_DefaultControlScheme; // 0x60
		[SerializeField]
		internal string m_DefaultActionMap; // 0x68
		[SerializeField]
		internal int m_SplitScreenIndex; // 0x70
		[SerializeField]
		[Tooltip("Reference to the player\'s view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
		internal Camera m_Camera; // 0x78
		[NonSerialized]
		private InputValue m_InputValueObject; // 0x80
		[NonSerialized]
		internal InputActionMap m_CurrentActionMap; // 0x88
		[NonSerialized]
		private int m_PlayerIndex; // 0x90
		[NonSerialized]
		private bool m_InputActive; // 0x94
		[NonSerialized]
		private bool m_Enabled; // 0x95
		[NonSerialized]
		internal bool m_ActionsInitialized; // 0x96
		[NonSerialized]
		private Dictionary<string, string> m_ActionMessageNames; // 0x98
		[NonSerialized]
		private InputUser m_InputUser; // 0xA0
		[NonSerialized]
		private Action<InputAction.CallbackContext> m_ActionTriggeredDelegate; // 0xA8
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_DeviceLostCallbacks; // 0xB0
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_DeviceRegainedCallbacks; // 0x100
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_ControlsChangedCallbacks; // 0x150
		[NonSerialized]
		private CallbackArray<Action<InputAction.CallbackContext>> m_ActionTriggeredCallbacks; // 0x1A0
		[NonSerialized]
		private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x1F0
		[NonSerialized]
		private Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate; // 0x1F8
		[NonSerialized]
		private bool m_OnUnpairedDeviceUsedHooked; // 0x200
		[NonSerialized]
		private Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> m_DeviceChangeDelegate; // 0x208
		[NonSerialized]
		private bool m_OnDeviceChangeHooked; // 0x210
		internal static int s_AllActivePlayersCount; // 0x00
		internal static PlayerInput[] s_AllActivePlayers; // 0x08
		private static Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate; // 0x10
		private static int s_InitPairWithDevicesCount; // 0x18
		private static UnityEngine.InputSystem.InputDevice[] s_InitPairWithDevices; // 0x20
		private static int s_InitPlayerIndex; // 0x28
		private static int s_InitSplitScreenIndex; // 0x2C
		private static string s_InitControlScheme; // 0x30
		internal static bool s_DestroyIfDeviceSetupUnsuccessful; // 0x38
	
		// Properties
		public bool inputIsActive { get; } // 0x0000000184D91BC0-0x0000000184D91BD0 
		[Obsolete("Use inputIsActive instead.")]
		public bool active { get; } // 0x0000000184D91BC0-0x0000000184D91BD0 
		public int playerIndex { get; } // 0x0000000184D86B60-0x0000000184D86B70 
		public int splitScreenIndex { get; } // 0x0000000184D868A0-0x0000000184D868B0 
		public InputActionAsset actions { get; set; } // 0x000000018B2189BC-0x000000018B218A04 0x000000018B219118-0x000000018B219248
		public string currentControlScheme { get; } // 0x000000018B218AEC-0x000000018B218B88 
		public string defaultControlScheme { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public bool neverAutoSwitchControlSchemes { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x000000018B2192B4-0x000000018B2192F8
		public InputActionMap currentActionMap { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x000000018B219248-0x000000018B2192B4
		public string defaultActionMap { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public PlayerNotifications notificationBehavior { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x000000018B2192F8-0x000000018B219340
		public ReadOnlyArray<ActionEvent> actionEvents { get; set; } // 0x000000018B218964-0x000000018B2189BC 0x000000018B21909C-0x000000018B219118
		public DeviceLostEvent deviceLostEvent { get; } // 0x000000018B218B88-0x000000018B218BF8 
		public DeviceRegainedEvent deviceRegainedEvent { get; } // 0x000000018B218BF8-0x000000018B218C68 
		public ControlsChangedEvent controlsChangedEvent { get; } // 0x000000018B218A7C-0x000000018B218AEC 
		public Camera camera { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public InputSystemUIInputModule uiInputModule { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018B219340-0x000000018B219484
		public InputUser user { get; } // 0x0000000184D88CD0-0x0000000184D88CE0 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x000000018B218C68-0x000000018B218CEC 
		public bool hasMissingRequiredDevices { get; } // 0x000000018B218CEC-0x000000018B218D64 
		public static ReadOnlyArray<PlayerInput> all { get; } // 0x000000018B218A04-0x000000018B218A7C 
		public static bool isSinglePlayer { get; } // 0x000000018B218D64-0x000000018B218DFC 
	
		// Events
		public event Action<InputAction.CallbackContext> onActionTriggered {
			add; // 0x000000018B2186C4-0x000000018B21876C
			remove; // 0x000000018B218DFC-0x000000018B218EA4
		}
		public event Action<PlayerInput> onDeviceLost {
			add; // 0x000000018B218814-0x000000018B2188BC
			remove; // 0x000000018B218F4C-0x000000018B218FF4
		}
		public event Action<PlayerInput> onDeviceRegained {
			add; // 0x000000018B2188BC-0x000000018B218964
			remove; // 0x000000018B218FF4-0x000000018B21909C
		}
		public event Action<PlayerInput> onControlsChanged {
			add; // 0x000000018B21876C-0x000000018B218814
			remove; // 0x000000018B218EA4-0x000000018B218F4C
		}
	
		// Nested types
		[Serializable]
		public class ActionEvent : UnityEvent<InputAction.CallbackContext> // TypeDefIndex: 47557
		{
			// Fields
			[SerializeField]
			private string m_ActionId; // 0x30
			[SerializeField]
			private string m_ActionName; // 0x38
	
			// Properties
			public string actionId { get; } // 0x00000001811F36E0-0x00000001811F36F0 
			public string actionName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
			// Constructors
			public ActionEvent(); // 0x000000018B2083E0-0x000000018B20841C
			public ActionEvent(InputAction action); // 0x000000018B20841C-0x000000018B20865C
			public ActionEvent(Guid actionGUID, string name = null); // 0x000000018B20865C-0x000000018B2086D4
		}
	
		[Serializable]
		public class DeviceLostEvent : UnityEvent<PlayerInput> // TypeDefIndex: 47558
		{
			// Constructors
			public DeviceLostEvent(); // 0x000000018B20960C-0x000000018B209648
		}
	
		[Serializable]
		public class DeviceRegainedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 47559
		{
			// Constructors
			public DeviceRegainedEvent(); // 0x000000018B209648-0x000000018B209684
		}
	
		[Serializable]
		public class ControlsChangedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 47560
		{
			// Constructors
			public ControlsChangedEvent(); // 0x000000018B208B5C-0x000000018B208B98
		}
	
		// Constructors
		public PlayerInput(); // 0x000000018B21869C-0x000000018B2186C4
		static PlayerInput(); // 0x000000018B21864C-0x000000018B21869C
	
		// Methods
		public TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public void ActivateInput(); // 0x000000018B213BA8-0x000000018B213C4C
		private void UpdateDelegates(); // 0x000000018B218474-0x000000018B21864C
		public void DeactivateInput(); // 0x000000018B214E94-0x000000018B214EC0
		[Obsolete("Use DeactivateInput instead.")]
		public void PassivateInput(); // 0x000000018B217278-0x000000018B217280
		public bool SwitchCurrentControlScheme(params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018B217AA8-0x000000018B217CA0
		public void SwitchCurrentControlScheme(string controlScheme, params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018B217CA0-0x000000018B217DEC
		public void SwitchCurrentActionMap(string mapNameOrId); // 0x000000018B217978-0x000000018B217AA8
		public static PlayerInput GetPlayerByIndex(int playerIndex); // 0x000000018B2152BC-0x000000018B215398
		public static PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B215140-0x000000018B2152BC
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x0232A464 */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x0232A465 */, UnityEngine.InputSystem.InputDevice pairWithDevice = null); // 0x000000018B215E2C-0x000000018B215FC4
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x0232A466 */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x0232A467 */, params UnityEngine.InputSystem.InputDevice[] pairWithDevices); // 0x000000018B215C6C-0x000000018B215E2C
		private static PlayerInput DoInstantiate(GameObject prefab); // 0x000000018B214F10-0x000000018B215140
		private void InitializeActions(); // 0x000000018B215748-0x000000018B215AB0
		private void CopyActionAssetAndApplyBindingOverrides(); // 0x000000018B214C54-0x000000018B214E94
		private void UninitializeActions(); // 0x000000018B21811C-0x000000018B218310
		private void InstallOnActionTriggeredHook(); // 0x000000018B215AB0-0x000000018B215C6C
		private void UninstallOnActionTriggeredHook(); // 0x000000018B218310-0x000000018B218474
		private void OnActionTriggered(InputAction.CallbackContext context); // 0x000000018B215FC4-0x000000018B2161CC
		private void CacheMessageNames(); // 0x000000018B214944-0x000000018B214C0C
		private void ClearCaches(); // 0x000000018B214C0C-0x000000018B214C54
		private void AssignUserAndDevices(); // 0x000000018B213E18-0x000000018B2148E4
		private bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B21565C-0x000000018B215748
		private void UnassignUserAndDevices(); // 0x000000018B21804C-0x000000018B21811C
		private bool TryToActivateControlScheme(InputControlScheme controlScheme); // 0x000000018B217DEC-0x000000018B21804C
		private void AssignPlayerIndex(); // 0x000000018B213C4C-0x000000018B213E18
		private void Awake(); // 0x000000018B2148E4-0x000000018B214944
		private void OnEnable(); // 0x000000018B2164F0-0x000000018B216950
		private void StartListeningForUnpairedDeviceActivity(); // 0x000000018B217348-0x000000018B217490
		private void StopListeningForUnpairedDeviceActivity(); // 0x000000018B2174F4-0x000000018B217574
		private void StartListeningForDeviceChanges(); // 0x000000018B217280-0x000000018B217348
		private void StopListeningForDeviceChanges(); // 0x000000018B217490-0x000000018B2174F4
		private void OnDisable(); // 0x000000018B2162F4-0x000000018B2164F0
		public void DebugLogAction(InputAction.CallbackContext context); // 0x000000018B214EC0-0x000000018B214F10
		private void HandleDeviceLost(); // 0x000000018B215484-0x000000018B215570
		private void HandleDeviceRegained(); // 0x000000018B215570-0x000000018B21565C
		private void HandleControlsChanged(); // 0x000000018B215398-0x000000018B215484
		private static void OnUserChange(InputUser user, InputUserChange change, UnityEngine.InputSystem.InputDevice device); // 0x000000018B2170AC-0x000000018B217278
		private static bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr); // 0x000000018B216950-0x000000018B216A48
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr); // 0x000000018B216A48-0x000000018B2170AC
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018B2161CC-0x000000018B2162F4
		private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018B217574-0x000000018B217978
	}

	[AddComponentMenu("Input/Player Input Manager")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInputManager.html")]
	public class PlayerInputManager : MonoBehaviour // TypeDefIndex: 47564
	{
		// Fields
		public const string PlayerJoinedMessage = "OnPlayerJoined"; // Metadata: 0x0232A49D
		public const string PlayerLeftMessage = "OnPlayerLeft"; // Metadata: 0x0232A4AC
		[CompilerGenerated]
		private static PlayerInputManager _instance_k__BackingField; // 0x00
		[SerializeField]
		internal PlayerNotifications m_NotificationBehavior; // 0x18
		[SerializeField]
		[Tooltip("Set a limit for the maximum number of players who are able to join.")]
		internal int m_MaxPlayerCount; // 0x1C
		[SerializeField]
		internal bool m_AllowJoining; // 0x20
		[SerializeField]
		internal PlayerJoinBehavior m_JoinBehavior; // 0x24
		[SerializeField]
		internal PlayerJoinedEvent m_PlayerJoinedEvent; // 0x28
		[SerializeField]
		internal PlayerLeftEvent m_PlayerLeftEvent; // 0x30
		[SerializeField]
		internal InputActionProperty m_JoinAction; // 0x38
		[SerializeField]
		internal GameObject m_PlayerPrefab; // 0x50
		[SerializeField]
		internal bool m_SplitScreen; // 0x58
		[SerializeField]
		internal bool m_MaintainAspectRatioInSplitScreen; // 0x59
		[SerializeField]
		[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
		internal int m_FixedNumberOfSplitScreens; // 0x5C
		[SerializeField]
		internal Rect m_SplitScreenRect; // 0x60
		[NonSerialized]
		private bool m_JoinActionDelegateHooked; // 0x70
		[NonSerialized]
		private bool m_UnpairedDeviceUsedDelegateHooked; // 0x71
		[NonSerialized]
		private Action<InputAction.CallbackContext> m_JoinActionDelegate; // 0x78
		[NonSerialized]
		private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x80
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_PlayerJoinedCallbacks; // 0x88
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_PlayerLeftCallbacks; // 0xD8
	
		// Properties
		public bool splitScreen { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x000000018B2139CC-0x000000018B213BA8
		public bool maintainAspectRatioInSplitScreen { get; } // 0x0000000184D8EF10-0x0000000184D8EF20 
		public int fixedNumberOfSplitScreens { get; } // 0x0000000184D86560-0x0000000184D86570 
		public Rect splitScreenArea { get; } // 0x0000000184DA1280-0x0000000184DA1290 
		public int playerCount { get; } // 0x000000018B21360C-0x000000018B21365C 
		public int maxPlayerCount { get; } // 0x0000000184D86310-0x0000000184D86320 
		public bool joiningEnabled { get; } // 0x0000000184D866B0-0x0000000184D866C0 
		public PlayerJoinBehavior joinBehavior { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x000000018B213980-0x000000018B2139CC
		public InputActionProperty joinAction { get; set; } // 0x0000000184D8F4A0-0x0000000184D8F4C0 0x000000018B2138DC-0x000000018B213980
		public PlayerNotifications notificationBehavior { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public PlayerJoinedEvent playerJoinedEvent { get; } // 0x000000018B21365C-0x000000018B2136CC 
		public PlayerLeftEvent playerLeftEvent { get; } // 0x000000018B2136CC-0x000000018B21373C 
		public GameObject playerPrefab { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public static PlayerInputManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B21354C-0x000000018B213584 0x000000018B21388C-0x000000018B2138DC
		internal static string[] messages { get; } // 0x000000018B213584-0x000000018B21360C 
	
		// Events
		public event Action<PlayerInput> onPlayerJoined {
			add; // 0x000000018B2133FC-0x000000018B2134A4
			remove; // 0x000000018B21373C-0x000000018B2137E4
		}
		public event Action<PlayerInput> onPlayerLeft {
			add; // 0x000000018B2134A4-0x000000018B21354C
			remove; // 0x000000018B2137E4-0x000000018B21388C
		}
	
		// Nested types
		[Serializable]
		public class PlayerJoinedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 47562
		{
			// Constructors
			public PlayerJoinedEvent(); // 0x000000018B219484-0x000000018B2194C0
		}
	
		[Serializable]
		public class PlayerLeftEvent : UnityEvent<PlayerInput> // TypeDefIndex: 47563
		{
			// Constructors
			public PlayerLeftEvent(); // 0x000000018B2194C0-0x000000018B2194FC
		}
	
		// Constructors
		public PlayerInputManager(); // 0x000000018B2133C8-0x000000018B2133FC
	
		// Methods
		public void EnableJoining(); // 0x000000018B212058-0x000000018B212230
		public void DisableJoining(); // 0x000000018B211F7C-0x000000018B212058
		internal void JoinPlayerFromUI(); // 0x000000018B212758-0x000000018B2127B8
		public void JoinPlayerFromAction(InputAction.CallbackContext context); // 0x000000018B2126F8-0x000000018B212758
		public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context); // 0x000000018B21262C-0x000000018B2126F8
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x0232A498 */, int splitScreenIndex = -1 /* Metadata: 0x0232A499 */, string controlScheme = null, UnityEngine.InputSystem.InputDevice pairWithDevice = null); // 0x000000018B2127B8-0x000000018B21285C
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x0232A49A */, int splitScreenIndex = -1 /* Metadata: 0x0232A49B */, string controlScheme = null, params UnityEngine.InputSystem.InputDevice[] pairWithDevices); // 0x000000018B21285C-0x000000018B212900
		private bool CheckIfPlayerCanJoin(int playerIndex = -1 /* Metadata: 0x0232A49C */); // 0x000000018B211CF4-0x000000018B211F7C
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr); // 0x000000018B212E40-0x000000018B212ED8
		private void OnEnable(); // 0x000000018B212B6C-0x000000018B212E40
		private void OnDisable(); // 0x000000018B212AF8-0x000000018B212B6C
		private void UpdateSplitScreen(); // 0x000000018B212ED8-0x000000018B2133C8
		private bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device); // 0x000000018B212230-0x000000018B21262C
		private void ValidateInputActionAsset(); // 0x00000001841E1670-0x00000001841E1680
		internal void NotifyPlayerJoined(PlayerInput player); // 0x000000018B212900-0x000000018B2129FC
		internal void NotifyPlayerLeft(PlayerInput player); // 0x000000018B2129FC-0x000000018B212AF8
	}

	public enum PlayerJoinBehavior // TypeDefIndex: 47565
	{
		JoinPlayersWhenButtonIsPressed = 0,
		JoinPlayersWhenJoinActionIsTriggered = 1,
		JoinPlayersManually = 2
	}

	public enum PlayerNotifications // TypeDefIndex: 47566
	{
		SendMessages = 0,
		BroadcastMessages = 1,
		InvokeUnityEvents = 2,
		InvokeCSharpEvents = 3
	}

	internal struct DynamicBitfield // TypeDefIndex: 47567
	{
		// Fields
		public InlinedArray<ulong> array; // 0x00
		public int length; // 0x18
	
		// Methods
		public void SetLength(int newLength); // 0x0000000183DFD0E0-0x0000000183DFD140
		public void SetBit(int bitIndex); // 0x0000000183E99830-0x0000000183E998B0
		public bool TestBit(int bitIndex); // 0x00000001830D29B0-0x00000001830D2A20
		public void ClearBit(int bitIndex); // 0x0000000183E997B0-0x0000000183E99830
		public bool AnyBitIsSet(); // 0x000000018404D270-0x000000018404D2D0
		private static int BitCountToULongCount(int bitCount); // 0x0000000184DABF60-0x0000000184DABF70
	}
}

namespace UnityEngine.InputSystem.Composites
{
	[System.ComponentModel.DisplayName("Positive/Negative Binding")]
	[DisplayStringFormat("{negative}/{positive}")]
	public class AxisComposite : InputBindingComposite<float> // TypeDefIndex: 47968
	{
		// Fields
		[InputControl(layout = "Axis")]
		public int negative; // 0x10
		[InputControl(layout = "Axis")]
		public int positive; // 0x14
		[Tooltip("Value to return when the negative side is fully actuated.")]
		public float minValue; // 0x18
		[Tooltip("Value to return when the positive side is fully actuated.")]
		public float maxValue; // 0x1C
		[Tooltip("If both the positive and negative side are actuated, decides what value to return. \'Neither\' (default) means that the resulting value is the midpoint between min and max. \'Positive\' means that max will be returned. \'Negative\' means that min will be returned.")]
		public WhichSideWins whichSideWins; // 0x20
	
		// Properties
		public float midPoint { get; } // 0x0000000184DABAD0-0x0000000184DABAF0 
	
		// Nested types
		public enum WhichSideWins // TypeDefIndex: 47967
		{
			Neither = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		public AxisComposite(); // 0x000000018B1C3214-0x000000018B1C3260
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018B1C3110-0x000000018B1C3214
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C3084-0x000000018B1C3110
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier}+{button}")]
	public class ButtonWithOneModifier : InputBindingComposite<float> // TypeDefIndex: 47970
	{
		// Fields
		[InputControl(layout = "Button")]
		public int modifier; // 0x10
		[InputControl(layout = "Button")]
		public int button; // 0x14
		[Obsolete("Use ModifiersOrder.Unordered with \'modifiersOrder\' instead")]
		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		public bool overrideModifiersNeedToBePressedFirst; // 0x18
		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder; // 0x1C
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 47969
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithOneModifier(); // 0x000000018B1C33A4-0x000000018B1C33CC
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018B1C3344-0x000000018B1C33A4
		private bool ModifierIsPressed(ref InputBindingCompositeContext context); // 0x000000018B1C32E0-0x000000018B1C3344
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C3260-0x000000018B1C3274
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018B1C3274-0x000000018B1C32E0
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
	public class ButtonWithTwoModifiers : InputBindingComposite<float> // TypeDefIndex: 47972
	{
		// Fields
		[InputControl(layout = "Button")]
		public int modifier1; // 0x10
		[InputControl(layout = "Button")]
		public int modifier2; // 0x14
		[InputControl(layout = "Button")]
		public int button; // 0x18
		[Obsolete("Use ModifiersOrder.Unordered with \'modifiersOrder\' instead")]
		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		public bool overrideModifiersNeedToBePressedFirst; // 0x1C
		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder; // 0x20
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 47971
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithTwoModifiers(); // 0x000000018B1C3538-0x000000018B1C3560
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018B1C34D8-0x000000018B1C3538
		private bool ModifiersArePressed(ref InputBindingCompositeContext context); // 0x000000018B1C3438-0x000000018B1C34D8
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C3260-0x000000018B1C3274
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018B1C33CC-0x000000018B1C3438
	}

	[System.ComponentModel.DisplayName("Binding With One Modifier")]
	[DisplayStringFormat("{modifier}+{binding}")]
	public class OneModifierComposite : InputBindingComposite // TypeDefIndex: 47974
	{
		// Fields
		[InputControl(layout = "Button")]
		public int modifier; // 0x10
		[InputControl]
		public int binding; // 0x14
		[Obsolete("Use ModifiersOrder.Unordered with \'modifiersOrder\' instead")]
		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		public bool overrideModifiersNeedToBePressedFirst; // 0x18
		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder; // 0x1C
		private int m_ValueSizeInBytes; // 0x20
		private System.Type m_ValueType; // 0x28
		private bool m_BindingIsButton; // 0x30
	
		// Properties
		public override System.Type valueType { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override int valueSizeInBytes { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 47973
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public OneModifierComposite(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C52F4-0x000000018B1C5330
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize); // 0x000000018B1C5478-0x000000018B1C54E4
		private bool ModifierIsPressed(ref InputBindingCompositeContext context); // 0x000000018B1C53CC-0x000000018B1C5438
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018B1C5330-0x000000018B1C53CC
		public override object ReadValueAsObject(ref InputBindingCompositeContext context); // 0x000000018B1C5438-0x000000018B1C5478
		internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out System.Type valueType, out int valueSizeInBytes, out bool isButton); // 0x000000018B1C501C-0x000000018B1C52F4
	}

	[System.ComponentModel.DisplayName("Binding With Two Modifiers")]
	[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
	public class TwoModifiersComposite : InputBindingComposite // TypeDefIndex: 47976
	{
		// Fields
		[InputControl(layout = "Button")]
		public int modifier1; // 0x10
		[InputControl(layout = "Button")]
		public int modifier2; // 0x14
		[InputControl]
		public int binding; // 0x18
		[Obsolete("Use ModifiersOrder.Unordered with \'modifiersOrder\' instead")]
		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		public bool overrideModifiersNeedToBePressedFirst; // 0x1C
		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder; // 0x20
		private int m_ValueSizeInBytes; // 0x24
		private System.Type m_ValueType; // 0x28
		private bool m_BindingIsButton; // 0x30
	
		// Properties
		public override System.Type valueType { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override int valueSizeInBytes { get; } // 0x00000001811F0020-0x00000001811F0030 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 47975
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public TwoModifiersComposite(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C8050-0x000000018B1C808C
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize); // 0x000000018B1C8220-0x000000018B1C828C
		private bool ModifiersArePressed(ref InputBindingCompositeContext context); // 0x000000018B1C8128-0x000000018B1C81CC
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018B1C808C-0x000000018B1C8128
		public override object ReadValueAsObject(ref InputBindingCompositeContext context); // 0x000000018B1C81CC-0x000000018B1C8220
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right Composite")]
	[DisplayStringFormat("{up}/{left}/{down}/{right}")]
	public class Vector2Composite : InputBindingComposite<Vector2> // TypeDefIndex: 47978
	{
		// Fields
		[InputControl(layout = "Axis")]
		public int up; // 0x10
		[InputControl(layout = "Axis")]
		public int down; // 0x14
		[InputControl(layout = "Axis")]
		public int left; // 0x18
		[InputControl(layout = "Axis")]
		public int right; // 0x1C
		[Obsolete("Use Mode.DigitalNormalized with \'mode\' instead")]
		public bool normalize; // 0x20
		public Mode mode; // 0x24
	
		// Nested types
		public enum Mode // TypeDefIndex: 47977
		{
			DigitalNormalized = 0,
			Digital = 1,
			Analog = 2
		}
	
		// Constructors
		public Vector2Composite(); // 0x0000000184D33260-0x0000000184D332A0
	
		// Methods
		public override Vector2 ReadValue(ref InputBindingCompositeContext context); // 0x000000018B1C9534-0x000000018B1C9690
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C9510-0x000000018B1C9534
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
	[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
	public class Vector3Composite : InputBindingComposite<Vector3> // TypeDefIndex: 47980
	{
		// Fields
		[InputControl(layout = "Axis")]
		public int up; // 0x10
		[InputControl(layout = "Axis")]
		public int down; // 0x14
		[InputControl(layout = "Axis")]
		public int left; // 0x18
		[InputControl(layout = "Axis")]
		public int right; // 0x1C
		[InputControl(layout = "Axis")]
		public int forward; // 0x20
		[InputControl(layout = "Axis")]
		public int backward; // 0x24
		public Mode mode; // 0x28
	
		// Nested types
		public enum Mode // TypeDefIndex: 47979
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}
	
		// Constructors
		public Vector3Composite(); // 0x000000018B1C98F0-0x000000018B1C9A08
	
		// Methods
		public override Vector3 ReadValue(ref InputBindingCompositeContext context); // 0x000000018B1C96C4-0x000000018B1C98F0
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018B1C9690-0x000000018B1C96C4
	}
}

namespace UnityEngine.InputSystem.Controls
{
	[InputControlLayout(hideInUI = true)]
	public class AnyKeyControl : ButtonControl // TypeDefIndex: 47879
	{
		// Constructors
		public AnyKeyControl(); // 0x000000018429A600-0x000000018429A670
	
		// Methods
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x00000001845659C0-0x0000000184565A30
	}

	public class AxisControl : InputControl<float> // TypeDefIndex: 47881
	{
		// Fields
		public Clamp clamp; // 0x108
		public float clampMin; // 0x10C
		public float clampMax; // 0x110
		public float clampConstant; // 0x114
		public bool invert; // 0x118
		public bool normalize; // 0x119
		public float normalizeMin; // 0x11C
		public float normalizeMax; // 0x120
		public float normalizeZero; // 0x124
		public bool scale; // 0x128
		public float scaleFactor; // 0x12C
	
		// Nested types
		public enum Clamp // TypeDefIndex: 47880
		{
			None = 0,
			BeforeNormalize = 1,
			AfterNormalize = 2,
			ToConstantBeforeNormalize = 3
		}
	
		// Constructors
		public AxisControl(); // 0x000000018429A750-0x000000018429A7A0
	
		// Methods
		protected float Preprocess(float value); // 0x000000018B1B6754-0x000000018B1B683C
		private float Unpreprocess(float value); // 0x000000018B1B683C-0x000000018B1B689C
		protected override void FinishSetup(); // 0x000000018B1B6684-0x000000018B1B6754
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x00000001830D1A90-0x00000001830D1BC0
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018B1B689C-0x000000018B1B694C
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr); // 0x000000018B1B65C4-0x000000018B1B6684
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x000000018426F5C0-0x000000018426F5F0
		private float EvaluateMagnitude(float value); // 0x000000018426F5F0-0x000000018426F6A0
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B1B648C-0x000000018B1B65C4
	}

	public class ButtonControl : AxisControl // TypeDefIndex: 47882
	{
		// Fields
		private bool m_NeedsToCheckFramePress; // 0x130
		private uint m_UpdateCountLastPressed; // 0x134
		private uint m_UpdateCountLastReleased; // 0x138
		private bool m_LastUpdateWasPress; // 0x13C
		[CompilerGenerated]
		private bool _needsToCheckFramePress_k__BackingField; // 0x13D
		public float pressPoint; // 0x140
		internal static float s_GlobalDefaultButtonPressPoint; // 0x00
		internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x04
		internal const float kMinButtonPressPoint = 0.0001f; // Metadata: 0x0232A8BF
	
		// Properties
		internal bool needsToCheckFramePress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAB970-0x0000000184DAB980 0x0000000184DAB980-0x0000000184DAB990
		public float pressPointOrDefault { get; } // 0x0000000183526940-0x0000000183526970 
		public bool isPressed { get; } // 0x0000000183306A00-0x0000000183306A60 
		public bool wasPressedThisFrame { get; } // 0x0000000183306940-0x0000000183306A00 
		public bool wasReleasedThisFrame { get; } // 0x0000000183306A60-0x0000000183306AA0 
	
		// Constructors
		public ButtonControl(); // 0x000000018429A670-0x000000018429A750
	
		// Methods
		public new bool IsValueConsideredPressed(float value); // 0x000000018B1B694C-0x000000018B1B697C
		private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame); // 0x0000000184528810-0x00000001845288B0
		internal void UpdateWasPressed(); // 0x0000000183526890-0x0000000183526940
	}

	[UnityEngine.Scripting.Preserve]
	public class DeltaControl : Vector2Control // TypeDefIndex: 47883
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _up_k__BackingField; // 0x120
		[CompilerGenerated]
		private AxisControl _down_k__BackingField; // 0x128
		[CompilerGenerated]
		private AxisControl _left_k__BackingField; // 0x130
		[CompilerGenerated]
		private AxisControl _right_k__BackingField; // 0x138
	
		// Properties
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Up")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Down")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Left")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D8A0-0x0000000184D8D8B0 0x0000000185397198-0x00000001853971AC
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Right")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
	
		// Constructors
		public DeltaControl(); // 0x000000018B1B70A4-0x000000018B1B70AC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1B6F9C-0x000000018B1B70A4
	}

	public class DiscreteButtonControl : ButtonControl // TypeDefIndex: 47885
	{
		// Fields
		public int minValue; // 0x148
		public int maxValue; // 0x14C
		public int wrapAtValue; // 0x150
		public int nullValue; // 0x154
		public WriteMode writeMode; // 0x158
	
		// Nested types
		public enum WriteMode // TypeDefIndex: 47884
		{
			WriteDisabled = 0,
			WriteNullAndMaxValue = 1
		}
	
		// Constructors
		public DiscreteButtonControl(); // 0x0000000185396EA0-0x0000000185396EA8
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1B70AC-0x000000018B1B71C0
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1B71C0-0x000000018B1B7280
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018B1B7280-0x000000018B1B7388
	}

	public class DoubleControl : InputControl<double> // TypeDefIndex: 47886
	{
		// Constructors
		public DoubleControl(); // 0x000000018B1B7448-0x000000018B1B74AC
	
		// Methods
		public override unsafe double ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1B7388-0x000000018B1B73E4
		public override unsafe void WriteValueIntoState(double value, void* statePtr); // 0x000000018B1B73E4-0x000000018B1B7448
	}

	public class DpadControl : Vector2Control // TypeDefIndex: 47889
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _up_k__BackingField; // 0x120
		[CompilerGenerated]
		private ButtonControl _down_k__BackingField; // 0x128
		[CompilerGenerated]
		private ButtonControl _left_k__BackingField; // 0x130
		[CompilerGenerated]
		private ButtonControl _right_k__BackingField; // 0x138
	
		// Properties
		[InputControl(bit = 0, displayName = "Up")]
		[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = true)]
		[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = true)]
		public ButtonControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		[InputControl(bit = 1, displayName = "Down")]
		public ButtonControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
		[InputControl(bit = 2, displayName = "Left")]
		public ButtonControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D8A0-0x0000000184D8D8B0 0x0000000185397198-0x00000001853971AC
		[InputControl(bit = 3, displayName = "Right")]
		public ButtonControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
	
		// Nested types
		[InputControlLayout(hideInUI = true)]
		public class DpadAxisControl : AxisControl // TypeDefIndex: 47887
		{
			// Fields
			[CompilerGenerated]
			private int _component_k__BackingField; // 0x130
	
			// Properties
			public int component { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D520-0x0000000184D8D530 0x0000000184D8D530-0x0000000184D8D540
	
			// Constructors
			public DpadAxisControl(); // 0x000000018B1B75C4-0x000000018B1B75CC
	
			// Methods
			protected override void FinishSetup(); // 0x000000018B1B74AC-0x000000018B1B7530
			public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1B7530-0x000000018B1B75C4
		}
	
		internal enum ButtonBits // TypeDefIndex: 47888
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}
	
		// Constructors
		public DpadControl(); // 0x000000018B1B7A40-0x000000018B1B7A9C
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1B75CC-0x000000018B1B76D4
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1B7748-0x000000018B1B78C8
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr); // 0x000000018B1B78C8-0x000000018B1B7A40
		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true /* Metadata: 0x0232A8C5 */); // 0x000000018B1B76D4-0x000000018B1B7748
		public static Vector2 MakeDpadVector(float up, float down, float left, float right); // 0x0000000184DAB990-0x0000000184DAB9B0
	}

	public class IntegerControl : InputControl<int> // TypeDefIndex: 47890
	{
		// Constructors
		public IntegerControl(); // 0x0000000184CAFCC0-0x0000000184CAFD40
	
		// Methods
		public override unsafe int ReadUnprocessedValueFromState(void* statePtr); // 0x0000000183F51020-0x0000000183F51080
		public override unsafe void WriteValueIntoState(int value, void* statePtr); // 0x000000018B1BE9B0-0x000000018B1BEA2C
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B1BE908-0x000000018B1BE9B0
	}

	public class KeyControl : ButtonControl // TypeDefIndex: 47891
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.Key _keyCode_k__BackingField; // 0x148
		private int m_ScanCode; // 0x14C
	
		// Properties
		public UnityEngine.InputSystem.Key keyCode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D6F0-0x0000000184D8D700 0x0000000184D8D720-0x0000000184D8D730
		public int scanCode { get; } // 0x000000018B1C0534-0x000000018B1C0550 
	
		// Constructors
		public KeyControl(); // 0x0000000185396EA0-0x0000000185396EA8
	
		// Methods
		protected override void RefreshConfiguration(); // 0x000000018B1C0388-0x000000018B1C0534
	}

	public class QuaternionControl : InputControl<Quaternion> // TypeDefIndex: 47892
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _x_k__BackingField; // 0x120
		[CompilerGenerated]
		private AxisControl _y_k__BackingField; // 0x128
		[CompilerGenerated]
		private AxisControl _z_k__BackingField; // 0x130
		[CompilerGenerated]
		private AxisControl _w_k__BackingField; // 0x138
	
		// Properties
		[InputControl(displayName = "X")]
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		[InputControl(displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
		[InputControl(displayName = "Z")]
		public AxisControl z { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D8A0-0x0000000184D8D8B0 0x0000000185397198-0x00000001853971AC
		[InputControl(displayName = "W")]
		public AxisControl w { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
	
		// Constructors
		public QuaternionControl(); // 0x000000018B1C15D8-0x000000018B1C1640
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C12AC-0x000000018B1C13C8
		public override unsafe Quaternion ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1C13C8-0x000000018B1C1504
		public override unsafe void WriteValueIntoState(Quaternion value, void* statePtr); // 0x000000018B1C1504-0x000000018B1C15D8
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B1C1060-0x000000018B1C12AC
	}

	public class StickControl : Vector2Control // TypeDefIndex: 47893
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _up_k__BackingField; // 0x120
		[CompilerGenerated]
		private ButtonControl _down_k__BackingField; // 0x128
		[CompilerGenerated]
		private ButtonControl _left_k__BackingField; // 0x130
		[CompilerGenerated]
		private ButtonControl _right_k__BackingField; // 0x138
	
		// Properties
		[InputControl(name = "y", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		[InputControl(name = "x", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Up")]
		public ButtonControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Down")]
		public ButtonControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Left")]
		public ButtonControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D8A0-0x0000000184D8D8B0 0x0000000185397198-0x00000001853971AC
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Right")]
		public ButtonControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
	
		// Constructors
		public StickControl(); // 0x000000018B1B70A4-0x000000018B1B70AC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C1828-0x000000018B1C1930
	}

	[InputControlLayout(stateType = typeof(TouchState))]
	public class TouchControl : InputControl<TouchState> // TypeDefIndex: 47894
	{
		// Fields
		[CompilerGenerated]
		private TouchPressControl _press_k__BackingField; // 0x170
		[CompilerGenerated]
		private IntegerControl _displayIndex_k__BackingField; // 0x178
		[CompilerGenerated]
		private IntegerControl _touchId_k__BackingField; // 0x180
		[CompilerGenerated]
		private Vector2Control _position_k__BackingField; // 0x188
		[CompilerGenerated]
		private DeltaControl _delta_k__BackingField; // 0x190
		[CompilerGenerated]
		private AxisControl _pressure_k__BackingField; // 0x198
		[CompilerGenerated]
		private Vector2Control _radius_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private TouchPhaseControl _phase_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private ButtonControl _indirectTouch_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _tap_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private IntegerControl _tapCount_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private DoubleControl _startTime_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private Vector2Control _startPosition_k__BackingField; // 0x1D0
	
		// Properties
		public TouchPressControl press { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DEF0-0x0000000184D8DF00 0x0000000186B8B940-0x0000000186B8B954
		public IntegerControl displayIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DEE0-0x0000000184D8DEF0 0x0000000186B8B92C-0x0000000186B8B940
		public IntegerControl touchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DD60-0x0000000184D8DD70 0x0000000186B8B774-0x0000000186B8B788
		public Vector2Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x0000000186B8B3B4-0x0000000186B8B3C8
		public DeltaControl delta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public AxisControl pressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public Vector2Control radius { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		public TouchPhaseControl phase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public ButtonControl indirectTouch { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		public ButtonControl tap { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		public IntegerControl tapCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public DoubleControl startTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		public Vector2Control startPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		public bool isInProgress { get; } // 0x000000018B1C1F9C-0x000000018B1C1FFC 
	
		// Constructors
		public TouchControl(); // 0x000000018B1C1F48-0x000000018B1C1F9C
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C1AFC-0x000000018B1C1E4C
		public override unsafe TouchState ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1C1E4C-0x000000018B1C1EC8
		public override unsafe void WriteValueIntoState(TouchState value, void* statePtr); // 0x000000018B1C1EC8-0x000000018B1C1F48
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPhaseControl : InputControl<UnityEngine.InputSystem.TouchPhase> // TypeDefIndex: 47895
	{
		// Constructors
		public TouchPhaseControl(); // 0x000000018B1C20BC-0x000000018B1C2120
	
		// Methods
		public override unsafe UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1C1FFC-0x000000018B1C205C
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr); // 0x000000018B1C205C-0x000000018B1C20BC
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPressControl : ButtonControl // TypeDefIndex: 47896
	{
		// Constructors
		public TouchPressControl(); // 0x0000000185396EA0-0x0000000185396EA8
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C2120-0x000000018B1C2234
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1C2234-0x000000018B1C22B0
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018B1C22B0-0x000000018B1C22FC
	}

	public class Vector2Control : InputControl<Vector2> // TypeDefIndex: 47897
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _x_k__BackingField; // 0x110
		[CompilerGenerated]
		private AxisControl _y_k__BackingField; // 0x118
	
		// Properties
		[InputControl(offset = 0, displayName = "X")]
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 0x0000000185397170-0x0000000185397184
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85F80-0x0000000184D85F90 0x000000018539715C-0x0000000185397170
	
		// Constructors
		public Vector2Control(); // 0x0000000184B4E8C0-0x0000000184B4E940
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C2910-0x000000018B1C29C0
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr); // 0x0000000183EE2190-0x0000000183EE2210
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr); // 0x000000018B1C29C0-0x000000018B1C2A6C
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x000000018428E420-0x000000018428E490
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B1C27E8-0x000000018B1C2910
	}

	public class Vector3Control : InputControl<Vector3> // TypeDefIndex: 47898
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _x_k__BackingField; // 0x118
		[CompilerGenerated]
		private AxisControl _y_k__BackingField; // 0x120
		[CompilerGenerated]
		private AxisControl _z_k__BackingField; // 0x128
	
		// Properties
		[InputControl(offset = 0, displayName = "X")]
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85F80-0x0000000184D85F90 0x000000018539715C-0x0000000185397170
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		[InputControl(offset = 8, displayName = "Z")]
		public AxisControl z { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
	
		// Constructors
		public Vector3Control(); // 0x000000018B1C2F6C-0x000000018B1C2FD0
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1C2CC4-0x000000018B1C2DA8
		public override unsafe Vector3 ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B1C2DA8-0x000000018B1C2EA8
		public override unsafe void WriteValueIntoState(Vector3 value, void* statePtr); // 0x000000018B1C2EA8-0x000000018B1C2F6C
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x000000018B1C2C58-0x000000018B1C2CC4
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B1C2AC0-0x000000018B1C2C58
	}
}

namespace UnityEngine.InputSystem.DualShock
{
	[InputControlLayout(displayName = "PlayStation Controller")]
	public class DualShockGamepad : Gamepad, IDualShockHaptics // TypeDefIndex: 47690
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _touchpadButton_k__BackingField; // 0x210
		[CompilerGenerated]
		private ButtonControl _optionsButton_k__BackingField; // 0x218
		[CompilerGenerated]
		private ButtonControl _shareButton_k__BackingField; // 0x220
		[CompilerGenerated]
		private ButtonControl _L1_k__BackingField; // 0x228
		[CompilerGenerated]
		private ButtonControl _R1_k__BackingField; // 0x230
		[CompilerGenerated]
		private ButtonControl _L2_k__BackingField; // 0x238
		[CompilerGenerated]
		private ButtonControl _R2_k__BackingField; // 0x240
		[CompilerGenerated]
		private ButtonControl _L3_k__BackingField; // 0x248
		[CompilerGenerated]
		private ButtonControl _R3_k__BackingField; // 0x250
		[CompilerGenerated]
		private static DualShockGamepad _current_k__BackingField; // 0x00
		[CompilerGenerated]
		private HID.HIDDeviceDescriptor _hidDescriptor_k__BackingField; // 0x258
	
		// Properties
		[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
		[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
		[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
		[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
		[InputControl]
		public ButtonControl touchpadButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(name = "start", displayName = "Options")]
		public ButtonControl optionsButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
		[InputControl(name = "select", displayName = "Share")]
		public ButtonControl shareButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D870-0x0000000184D8D880 0x0000000186B8B1FC-0x0000000186B8B210
		[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
		public ButtonControl L1 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D440-0x0000000184D8D450 0x0000000186B22BCC-0x0000000186B22BE0
		[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
		public ButtonControl R1 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAE0-0x0000000184D8DAF0 0x0000000186B8B490-0x0000000186B8B4A4
		[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
		public ButtonControl L2 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAD0-0x0000000184D8DAE0 0x0000000186B8B47C-0x0000000186B8B490
		[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
		public ButtonControl R2 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DE80-0x0000000184D8DE90 0x0000000186B8B8C8-0x0000000186B8B8DC
		[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
		public ButtonControl L3 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D840-0x0000000184D8D850 0x0000000186B8B1C0-0x0000000186B8B1D4
		[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
		public ButtonControl R3 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 0x0000000186B8B6E8-0x0000000186B8B6FC
		public static new DualShockGamepad current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B22D00C-0x000000018B22D044 0x000000018B22D044-0x000000018B22D094
		internal HID.HIDDeviceDescriptor hidDescriptor { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAC7F0-0x0000000184DAC820 0x000000018B22D094-0x000000018B22D0C0
	
		// Constructors
		public DualShockGamepad(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public override void MakeCurrent(); // 0x000000018B22CF9C-0x000000018B22CFB8
		protected override void OnRemoved(); // 0x000000018B22CFB8-0x000000018B22D00C
		protected override void FinishSetup(); // 0x000000018B22CDF0-0x000000018B22CF9C
		public virtual void SetLightBarColor(UnityEngine.Color color); // 0x00000001841E1670-0x00000001841E1680
	}

	[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
	public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 47695
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		[CompilerGenerated]
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		[CompilerGenerated]
		private ButtonControl _playStationButton_k__BackingField; // 0x298
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		protected UnityEngine.Color? m_LightBarColor; // 0x2B0
		private byte outputSequenceId; // 0x2C4
		internal const byte JitterMaskLow = 120; // Metadata: 0x0232A6CA
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0232A6CB
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D820-0x0000000184D8D830 0x0000000186B8B198-0x0000000186B8B1AC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D800-0x0000000184D8D810 0x0000000186B8B170-0x0000000186B8B184
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA30-0x0000000184D8DA40 0x0000000186B8B3C8-0x0000000186B8B3DC
	
		// Nested types
		internal struct DualSenseHIDGenericInputReport // TypeDefIndex: 47691
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get; } // 0x0000000184DAC340-0x0000000184DAC350 
		}
	
		internal struct DualSenseHIDUSBInputReport // TypeDefIndex: 47692
		{
			// Fields
			public const int ExpectedReportId = 1; // Metadata: 0x0232A6CC
			public byte reportId; // 0x00
			public byte leftStickX; // 0x01
			public byte leftStickY; // 0x02
			public byte rightStickX; // 0x03
			public byte rightStickY; // 0x04
			public byte leftTrigger; // 0x05
			public byte rightTrigger; // 0x06
			public byte buttons0; // 0x08
			public byte buttons1; // 0x09
			public byte buttons2; // 0x0A
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x0000000184DAC700-0x0000000184DAC750
		}
	
		internal struct DualSenseHIDBluetoothInputReport // TypeDefIndex: 47693
		{
			// Fields
			public const int ExpectedReportId = 49; // Metadata: 0x0232A6CD
			public byte reportId; // 0x00
			public byte leftStickX; // 0x02
			public byte leftStickY; // 0x03
			public byte rightStickX; // 0x04
			public byte rightStickY; // 0x05
			public byte leftTrigger; // 0x06
			public byte rightTrigger; // 0x07
			public byte buttons0; // 0x09
			public byte buttons1; // 0x0A
			public byte buttons2; // 0x0B
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x0000000184DAC5F0-0x0000000184DAC640
		}
	
		internal struct DualSenseHIDMinimalInputReport // TypeDefIndex: 47694
		{
			// Fields
			public static int ExpectedSize1; // 0x00
			public static int ExpectedSize2; // 0x04
			public byte reportId; // 0x00
			public byte leftStickX; // 0x01
			public byte leftStickY; // 0x02
			public byte rightStickX; // 0x03
			public byte rightStickY; // 0x04
			public byte buttons0; // 0x05
			public byte buttons1; // 0x06
			public byte buttons2; // 0x07
			public byte leftTrigger; // 0x08
			public byte rightTrigger; // 0x09
	
			// Constructors
			static DualSenseHIDMinimalInputReport(); // 0x000000018B22C128-0x000000018B22C178
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x0000000184DAC6B0-0x0000000184DAC700
		}
	
		// Constructors
		public DualSenseGamepadHID(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B22B540-0x000000018B22B614
		public override void PauseHaptics(); // 0x000000018B22B830-0x000000018B22B8CC
		public override void ResetHaptics(); // 0x000000018B22B8CC-0x000000018B22B950
		public override void ResumeHaptics(); // 0x000000018B22B950-0x000000018B22B9C4
		public override void SetLightBarColor(UnityEngine.Color color); // 0x000000018B22B9C4-0x000000018B22BA58
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018B22BC68-0x000000018B22BD28
		public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, UnityEngine.Color? color); // 0x000000018B22BA58-0x000000018B22BC68
		private static unsafe bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState); // 0x000000018B22B614-0x000000018B22B64C
		private static unsafe bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState); // 0x000000018B22B64C-0x000000018B22B684
		private static unsafe bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState); // 0x000000018B22B684-0x000000018B22B6BC
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018B22BD28-0x000000018B22BED4
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr); // 0x000000018B22BED4-0x000000018B22C09C
		public void OnNextUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B22B6BC-0x000000018B22B830
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001812081B0-0x0000000181208610
	}

	[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = true, isNoisy = true)]
	public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 47697
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		[CompilerGenerated]
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		[CompilerGenerated]
		private ButtonControl _playStationButton_k__BackingField; // 0x298
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		private UnityEngine.Color? m_LightBarColor; // 0x2B0
		internal const byte JitterMaskLow = 120; // Metadata: 0x0232A6CE
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0232A6CF
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D820-0x0000000184D8D830 0x0000000186B8B198-0x0000000186B8B1AC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D800-0x0000000184D8D810 0x0000000186B8B170-0x0000000186B8B184
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA30-0x0000000184D8DA40 0x0000000186B8B3C8-0x0000000186B8B3DC
	
		// Nested types
		internal struct DualShock4HIDGenericInputReport // TypeDefIndex: 47696
		{
			// Fields
			public byte leftStickX; // 0x00
			public byte leftStickY; // 0x01
			public byte rightStickX; // 0x02
			public byte rightStickY; // 0x03
			public byte buttons0; // 0x04
			public byte buttons1; // 0x05
			public byte buttons2; // 0x06
			public byte leftTrigger; // 0x07
			public byte rightTrigger; // 0x08
	
			// Properties
			public static FourCC Format { get; } // 0x0000000184DAC340-0x0000000184DAC350 
	
			// Methods
			public DualShock4HIDInputReport ToHIDInputReport(); // 0x0000000184DAC7A0-0x0000000184DAC7F0
		}
	
		// Constructors
		public DualShock4GamepadHID(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B22C24C-0x000000018B22C320
		public override void PauseHaptics(); // 0x000000018B22C494-0x000000018B22C5B0
		public override void ResetHaptics(); // 0x000000018B22C5B0-0x000000018B22C6EC
		public override void ResumeHaptics(); // 0x000000018B22C6EC-0x000000018B22C874
		public override void SetLightBarColor(UnityEngine.Color color); // 0x000000018B22C874-0x000000018B22C97C
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018B22CAF4-0x000000018B22CC0C
		public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, UnityEngine.Color color); // 0x000000018B22C97C-0x000000018B22CAF4
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr); // 0x000000018B22CC0C-0x000000018B22CD64
		public void OnNextUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B22C320-0x000000018B22C494
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001812081B0-0x0000000181208610
	}

	[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = true, displayName = "PS3 Controller")]
	public class DualShock3GamepadHID : DualShockGamepad // TypeDefIndex: 47698
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		[CompilerGenerated]
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		[CompilerGenerated]
		private ButtonControl _playStationButton_k__BackingField; // 0x298
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D820-0x0000000184D8D830 0x0000000186B8B198-0x0000000186B8B1AC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D800-0x0000000184D8D810 0x0000000186B8B170-0x0000000186B8B184
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA30-0x0000000184D8DA40 0x0000000186B8B3C8-0x0000000186B8B3DC
	
		// Constructors
		public DualShock3GamepadHID(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B22C178-0x000000018B22C24C
	}

	internal static class DualShockSupport // TypeDefIndex: 47699
	{
		// Methods
		public static void Initialize(); // 0x0000000183DF67A0-0x0000000183DF6C50
	}

	public interface IDualShockHaptics : IDualMotorRumble // TypeDefIndex: 47700
	{
		// Methods
		void SetLightBarColor(UnityEngine.Color color);
	}
}

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	public struct DualSenseHIDInputReport : IInputStateTypeInfo // TypeDefIndex: 47701
	{
		// Fields
		public static FourCC Format; // 0x00
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger; // 0x04
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger; // 0x05
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 6)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4, defaultState = 8)]
		[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0, sizeInBits = 4)]
		[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0, sizeInBits = 4)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 4)]
		[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0, sizeInBits = 4)]
		[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0, sizeInBits = 4)]
		public byte buttons0; // 0x06
		[InputControl(name = "start", displayName = "Options", bit = 5)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3)]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2)]
		[InputControl(name = "rightShoulder", bit = 1)]
		[InputControl(name = "leftStickPress", bit = 6)]
		[InputControl(name = "rightStickPress", bit = 7)]
		[InputControl(name = "leftShoulder", bit = 0)]
		[InputControl(name = "select", displayName = "Share", bit = 4)]
		public byte buttons1; // 0x07
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
		[InputControl(name = "micButton", layout = "Button", displayName = "Mic Mute", bit = 2)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
		public byte buttons2; // 0x08
	
		// Properties
		public FourCC format { get; } // 0x000000018B22C0D8-0x000000018B22C128 
	
		// Constructors
		static DualSenseHIDInputReport(); // 0x000000018B22C09C-0x000000018B22C0D8
	}

	internal struct DualSenseHIDOutputReportPayload // TypeDefIndex: 47702
	{
		// Fields
		public byte enableFlags1; // 0x00
		public byte enableFlags2; // 0x01
		public byte highFrequencyMotorSpeed; // 0x02
		public byte lowFrequencyMotorSpeed; // 0x03
		public byte redColor; // 0x2C
		public byte greenColor; // 0x2D
		public byte blueColor; // 0x2E
	}

	internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 47703
	{
		// Fields
		internal const int kSize = 56; // Metadata: 0x0232A6D0
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public DualSenseHIDOutputReportPayload payload; // 0x09
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
		public FourCC typeStatic { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
	
		// Methods
		public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize); // 0x0000000184DAC750-0x0000000184DAC7A0
	}

	internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 47705
	{
		// Fields
		internal const int kSize = 86; // Metadata: 0x0232A6D1
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte tag1; // 0x09
		public byte tag2; // 0x0A
		public DualSenseHIDOutputReportPayload payload; // 0x0B
		public uint crc32; // 0x52
		public unsafe fixed /* 0x00000000-0x00000000 */ byte rawData[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
		public FourCC typeStatic { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _rawData_e__FixedBuffer // TypeDefIndex: 47704
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize); // 0x0000000184DAC640-0x0000000184DAC6B0
	}

	internal struct DualShock4HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 47706
	{
		// Fields
		public static FourCC Format; // 0x00
		[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4, defaultState = 8)]
		[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0, sizeInBits = 4)]
		[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0, sizeInBits = 4)]
		[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0, sizeInBits = 4)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 4)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 6)]
		[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0, sizeInBits = 4)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7)]
		public byte buttons1; // 0x04
		[InputControl(name = "leftShoulder", bit = 0)]
		[InputControl(name = "select", displayName = "Share", bit = 4)]
		[InputControl(name = "rightShoulder", bit = 1)]
		[InputControl(name = "rightStickPress", bit = 7)]
		[InputControl(name = "leftStickPress", bit = 6)]
		[InputControl(name = "start", displayName = "Options", bit = 5)]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2, synthetic = true)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3, synthetic = true)]
		public byte buttons2; // 0x05
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
		public byte buttons3; // 0x06
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger; // 0x07
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger; // 0x08
	
		// Properties
		public FourCC format { get; } // 0x000000018B22CDA0-0x000000018B22CDF0 
	
		// Constructors
		static DualShock4HIDInputReport(); // 0x000000018B22CD64-0x000000018B22CDA0
	}

	internal struct DualShock3HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 47708
	{
		// Fields
		private ushort padding1; // 0x00
		[InputControl(name = "select", displayName = "Share", bit = 0)]
		[InputControl(name = "leftStickPress", bit = 1)]
		[InputControl(name = "dpad/left", bit = 7)]
		[InputControl(name = "start", displayName = "Options", bit = 3)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", bit = 4, sizeInBits = 4)]
		[InputControl(name = "rightStickPress", bit = 2)]
		[InputControl(name = "dpad/right", bit = 5)]
		[InputControl(name = "dpad/up", bit = 4)]
		[InputControl(name = "dpad/down", bit = 6)]
		public byte buttons1; // 0x02
		[InputControl(name = "rightShoulder", bit = 3)]
		[InputControl(name = "leftShoulder", bit = 2)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 1, synthetic = true)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 4)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 5)]
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 6)]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 0, synthetic = true)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 7)]
		public byte buttons2; // 0x03
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
		public byte buttons3; // 0x04
		private byte padding2; // 0x05
		[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		public byte leftStickX; // 0x06
		public byte leftStickY; // 0x07
		[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		public byte rightStickX; // 0x08
		public byte rightStickY; // 0x09
		private unsafe fixed /* 0x00000000-0x00000000 */ byte padding3[0]; // 0x0A
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger; // 0x12
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger; // 0x13
	
		// Properties
		public FourCC format { get; } // 0x0000000184DAC340-0x0000000184DAC350 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _padding3_e__FixedBuffer // TypeDefIndex: 47707
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 47712
	{
		// Fields
		internal const int kSize = 40; // Metadata: 0x0232A6D3
		internal const int kReportId = 5; // Metadata: 0x0232A6D4
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte flags; // 0x09
		public unsafe fixed /* 0x00000000-0x00000000 */ byte unknown1[0]; // 0x0A
		public byte highFrequencyMotorSpeed; // 0x0C
		public byte lowFrequencyMotorSpeed; // 0x0D
		public byte redColor; // 0x0E
		public byte greenColor; // 0x0F
		public byte blueColor; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ byte unknown2[0]; // 0x11
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
		public FourCC typeStatic { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
	
		// Nested types
		[Flags]
		public enum Flags // TypeDefIndex: 47709
		{
			Rumble = 1,
			Color = 2
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _unknown1_e__FixedBuffer // TypeDefIndex: 47710
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _unknown2_e__FixedBuffer // TypeDefIndex: 47711
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public void SetMotorSpeeds(float lowFreq, float highFreq); // 0x000000018B22D138-0x000000018B22D184
		public void SetColor(UnityEngine.Color color); // 0x000000018B22D0C0-0x000000018B22D138
		public static DualShockHIDOutputReport Create(int outputReportSize); // 0x0000000184DAC820-0x0000000184DAC850
	}
}

namespace UnityEngine.InputSystem.Editor
{
	internal struct SampleFrequencyCalculator // TypeDefIndex: 47713
	{
		// Fields
		private double m_LastUpdateTime; // 0x00
		private int m_SampleCount; // 0x08
		[CompilerGenerated]
		private float _targetFrequency_k__BackingField; // 0x0C
		[CompilerGenerated]
		private float _frequency_k__BackingField; // 0x10
	
		// Properties
		public float targetFrequency { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D9CC80-0x0000000184D9CC90 0x0000000184DACD70-0x0000000184DACD80
		public float frequency { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
	
		// Constructors
		public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup); // 0x0000000184DACD50-0x0000000184DACD70
	
		// Methods
		public void ProcessSample(InputEventPtr eventPtr); // 0x000000018B235C00-0x000000018B235C0C
		public bool Update(); // 0x000000018B235C48-0x000000018B235C6C
		public bool Update(double realtimeSinceStartup); // 0x000000018B235C0C-0x000000018B235C48
	}
}

namespace UnityEngine.InputSystem.EnhancedTouch
{
	public static class EnhancedTouchSupport // TypeDefIndex: 47680
	{
		// Fields
		private static int s_Enabled; // 0x00
		private static InputSettings.UpdateMode s_UpdateMode; // 0x04
	
		// Properties
		public static bool enabled { get; } // 0x000000018B22D628-0x000000018B22D640 
	
		// Methods
		public static void Enable(); // 0x0000000183DFAA20-0x0000000183DFAB90
		public static void Disable(); // 0x000000018B22D228-0x000000018B22D380
		internal static void Reset(); // 0x000000018B22D3F8-0x000000018B22D49C
		private static void SetUpState(); // 0x0000000183DF96D0-0x0000000183DF9B20
		internal static void TearDownState(); // 0x000000018B22D49C-0x000000018B22D628
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x0000000183DF9B20-0x0000000183DF9B90
		private static void OnSettingsChange(); // 0x000000018B22D380-0x000000018B22D3F8
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal static void CheckEnabled(); // 0x000000018B22D1B4-0x000000018B22D228
	}

	public class Finger // TypeDefIndex: 47681
	{
		// Fields
		[CompilerGenerated]
		private readonly Touchscreen _screen_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _index_k__BackingField; // 0x18
		internal readonly InputStateHistory<TouchState> m_StateHistory; // 0x20
	
		// Properties
		public Touchscreen screen { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public int index { [CompilerGenerated] get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public bool isActive { get; } // 0x000000018B22E798-0x000000018B22E800 
		public Vector2 screenPosition { get; } // 0x000000018B22E8D0-0x000000018B22E95C 
		public Touch lastTouch { get; } // 0x000000018B22E800-0x000000018B22E8D0 
		public Touch currentTouch { get; } // 0x000000018B22E69C-0x000000018B22E798 
		public TouchHistory touchHistory { get; } // 0x000000018B22E95C-0x000000018B22E998 
	
		// Constructors
		internal Finger(Touchscreen screen, int index, InputUpdateType updateMask); // 0x000000018B22E39C-0x000000018B22E69C
	
		// Methods
		private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr); // 0x000000018B22E2F8-0x000000018B22E39C
		private void OnTouchRecorded(InputStateHistory.Record record); // 0x000000018B22E044-0x000000018B22E2F8
		private Touch FindTouch(uint uniqueId); // 0x000000018B22DC28-0x000000018B22DE2C
		internal TouchHistory GetTouchHistory(Touch touch); // 0x000000018B22DE2C-0x000000018B22E044
	}

	public struct Touch : IEquatable<Touch> // TypeDefIndex: 47686
	{
		// Fields
		private readonly Finger m_Finger; // 0x00
		internal InputStateHistory<TouchState> m_TouchRecord; // 0x08
		internal static GlobalState s_GlobalState; // 0x00
	
		// Properties
		public bool valid { get; } // 0x000000018B239130-0x000000018B23916C 
		public Finger finger { get; } // 0x0000000182B76770-0x0000000182B76780 
		public UnityEngine.InputSystem.TouchPhase phase { get; } // 0x000000018B238CCC-0x000000018B238D1C 
		public bool began { get; } // 0x000000018B23885C-0x000000018B2388A4 
		public bool inProgress { get; } // 0x000000018B238B5C-0x000000018B238BE0 
		public bool ended { get; } // 0x000000018B238948-0x000000018B2389B0 
		public int touchId { get; } // 0x000000018B239044-0x000000018B239090 
		public float pressure { get; } // 0x000000018B238D1C-0x000000018B238D6C 
		public Vector2 radius { get; } // 0x000000018B238D6C-0x000000018B238DC0 
		public double startTime { get; } // 0x000000018B238F2C-0x000000018B238F7C 
		public double time { get; } // 0x000000018B239008-0x000000018B239044 
		public Touchscreen screen { get; } // 0x000000018B238E14-0x000000018B238E68 
		public Vector2 screenPosition { get; } // 0x000000018B238DC0-0x000000018B238E14 
		public Vector2 startScreenPosition { get; } // 0x000000018B238ED8-0x000000018B238F2C 
		public Vector2 delta { get; } // 0x000000018B2388A4-0x000000018B2388F8 
		public int tapCount { get; } // 0x000000018B238FB8-0x000000018B239008 
		public bool isTap { get; } // 0x000000018B238C34-0x000000018B238C7C 
		public int displayIndex { get; } // 0x000000018B2388F8-0x000000018B238948 
		public bool isInProgress { get; } // 0x000000018B238BE0-0x000000018B238C34 
		internal uint updateStepCount { get; } // 0x000000018B2390E0-0x000000018B239130 
		internal uint uniqueId { get; } // 0x000000018B239090-0x000000018B2390E0 
		private ref TouchState state { get; } // 0x000000018B238F7C-0x000000018B238FB8 
		private ref ExtraDataPerTouchState extraData { get; } // 0x000000018B2389B0-0x000000018B2389EC 
		public TouchHistory history { get; } // 0x000000018B238A6C-0x000000018B238B5C 
		public static ReadOnlyArray<Touch> activeTouches { get; } // 0x00000001842EEF60-0x00000001842EEFE0 
		public static ReadOnlyArray<Finger> fingers { get; } // 0x000000018B2389EC-0x000000018B238A6C 
		public static ReadOnlyArray<Finger> activeFingers { get; } // 0x000000018B2387C0-0x000000018B23885C 
		public static IEnumerable<Touchscreen> screens { get; } // 0x000000018B238E68-0x000000018B238ED8 
		public static int maxHistoryLengthPerFinger { get; } // 0x000000018B238C7C-0x000000018B238CCC 
	
		// Events
		public static event Action<Finger> onFingerDown {
			add; // 0x000000018B238588-0x000000018B238644
			remove; // 0x000000018B23916C-0x000000018B239228
		}
		public static event Action<Finger> onFingerUp {
			add; // 0x000000018B238700-0x000000018B2387C0
			remove; // 0x000000018B2392E4-0x000000018B2393A4
		}
		public static event Action<Finger> onFingerMove {
			add; // 0x000000018B238644-0x000000018B238700
			remove; // 0x000000018B239228-0x000000018B2392E4
		}
	
		// Nested types
		internal struct GlobalState // TypeDefIndex: 47682
		{
			// Fields
			internal InlinedArray<Touchscreen> touchscreens; // 0x00
			internal int historyLengthPerFinger; // 0x18
			internal CallbackArray<Action<Finger>> onFingerDown; // 0x20
			internal CallbackArray<Action<Finger>> onFingerMove; // 0x70
			internal CallbackArray<Action<Finger>> onFingerUp; // 0xC0
			internal FingerAndTouchState playerState; // 0x110
		}
	
		internal struct FingerAndTouchState // TypeDefIndex: 47683
		{
			// Fields
			public InputUpdateType updateMask; // 0x00
			public Finger[] fingers; // 0x08
			public Finger[] activeFingers; // 0x10
			public Touch[] activeTouches; // 0x18
			public int activeFingerCount; // 0x20
			public int activeTouchCount; // 0x24
			public int totalFingerCount; // 0x28
			public uint lastId; // 0x2C
			public bool haveBuiltActiveTouches; // 0x30
			public bool haveActiveTouchesNeedingRefreshNextUpdate; // 0x31
			public InputStateHistory<TouchState> activeTouchState; // 0x38
	
			// Methods
			public void AddFingers(Touchscreen screen); // 0x000000018B22D870-0x000000018B22D98C
			public void RemoveFingers(Touchscreen screen); // 0x000000018B22DA08-0x000000018B22DB24
			public void Destroy(); // 0x000000018B22D98C-0x000000018B22DA08
			public void UpdateActiveFingers(); // 0x000000018B22DB24-0x000000018B22DC28
			public void UpdateActiveTouches(); // 0x00000001842EEFE0-0x00000001842EF120
		}
	
		internal struct ExtraDataPerTouchState // TypeDefIndex: 47684
		{
			// Fields
			public Vector2 accumulatedDelta; // 0x00
			public uint uniqueId; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47685
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__80_0; // 0x08
			public static Action __9__80_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B239588-0x000000018B2395EC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SaveAndResetState_b__80_0(ref GlobalState state); // 0x000000018B2393FC-0x000000018B239568
			internal void _SaveAndResetState_b__80_1(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		internal Touch(Finger finger, InputStateHistory<TouchState> touchRecord); // 0x00000001843106D0-0x0000000184310700
		static Touch(); // 0x0000000184B88FB0-0x0000000184B890A0
	
		// Methods
		public override string ToString(); // 0x000000018B238318-0x000000018B238588
		public bool Equals(Touch other); // 0x000000018B237DEC-0x000000018B237E78
		public override bool Equals(object obj); // 0x000000018B237E78-0x000000018B237F14
		public override int GetHashCode(); // 0x000000018B237F14-0x000000018B237F78
		internal static void AddTouchscreen(Touchscreen screen); // 0x000000018B237D64-0x000000018B237DEC
		internal static void RemoveTouchscreen(Touchscreen screen); // 0x000000018B237F78-0x000000018B238038
		internal static void BeginUpdate(); // 0x0000000183F953B0-0x0000000183F953F0
		private static GlobalState CreateGlobalState(); // 0x0000000184DACE00-0x0000000184DACE30
		internal static ISavedState SaveAndResetState(); // 0x000000018B238038-0x000000018B238318
	}

	public struct TouchHistory : IReadOnlyList<Touch> // TypeDefIndex: 47688
	{
		// Fields
		private readonly InputStateHistory<TouchState> m_History; // 0x00
		private readonly Finger m_Finger; // 0x08
		private readonly int m_Count; // 0x10
		private readonly int m_StartIndex; // 0x14
		private readonly uint m_Version; // 0x18
	
		// Properties
		public int Count { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public Touch this[int index] { get => default; } // 0x000000018B235E2C-0x000000018B235F9C 
	
		// Nested types
		private class Enumerator : IEnumerator<Touch> // TypeDefIndex: 47687
		{
			// Fields
			private readonly TouchHistory m_Owner; // 0x10
			private int m_Index; // 0x30
	
			// Properties
			public Touch Current { get; } // 0x000000018B22D828-0x000000018B22D870 
			object IEnumerator.Current { get; } // 0x000000018B22D71C-0x000000018B22D77C 
	
			// Constructors
			internal Enumerator(TouchHistory owner); // 0x000000018B22D7C4-0x000000018B22D7F0
	
			// Methods
			public bool MoveNext(); // 0x000000018B22D640-0x000000018B22D65C
			public void Reset(); // 0x0000000182B2C650-0x0000000182B2C660
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1 /* Metadata: 0x0232A6C6 */, int count = -1 /* Metadata: 0x0232A6C7 */); // 0x000000018B235DC0-0x000000018B235E2C
	
		// Methods
		public IEnumerator<Touch> GetEnumerator(); // 0x000000018B235D38-0x000000018B235DB8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B235DB8-0x000000018B235DC0
		internal void CheckValid(); // 0x000000018B235C6C-0x000000018B235D38
	}

	[AddComponentMenu("Input/Debug/Touch Simulation")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/Touch.html#touch-simulation")]
	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor // TypeDefIndex: 47689
	{
		// Fields
		[CompilerGenerated]
		private Touchscreen _simulatedTouchscreen_k__BackingField; // 0x18
		[NonSerialized]
		private int m_NumPointers; // 0x20
		[NonSerialized]
		private UnityEngine.InputSystem.Pointer[] m_Pointers; // 0x28
		[NonSerialized]
		private Vector2[] m_CurrentPositions; // 0x30
		[NonSerialized]
		private int[] m_CurrentDisplayIndices; // 0x38
		[NonSerialized]
		private ButtonControl[] m_Touches; // 0x40
		[NonSerialized]
		private int[] m_TouchIds; // 0x48
		[NonSerialized]
		private int m_LastTouchId; // 0x50
		[NonSerialized]
		private Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> m_OnDeviceChange; // 0x58
		[NonSerialized]
		private Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> m_OnEvent; // 0x60
		internal static TouchSimulation s_Instance; // 0x00
	
		// Properties
		public Touchscreen simulatedTouchscreen { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public static TouchSimulation instance { get; } // 0x000000018B2379B4-0x000000018B2379EC 
	
		// Constructors
		public TouchSimulation(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void Enable(); // 0x000000018B236218-0x000000018B236340
		public static void Disable(); // 0x000000018B2361AC-0x000000018B236218
		public static void Destroy(); // 0x000000018B2360E0-0x000000018B2361AC
		protected void AddPointer(UnityEngine.InputSystem.Pointer pointer); // 0x000000018B235F9C-0x000000018B2360E0
		protected void RemovePointer(UnityEngine.InputSystem.Pointer pointer); // 0x000000018B2375FC-0x000000018B2377AC
		private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018B236974-0x000000018B2375FC
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018B236340-0x000000018B23640C
		protected void OnEnable(); // 0x000000018B236534-0x000000018B236974
		protected void OnDisable(); // 0x000000018B23640C-0x000000018B236534
		private void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, InputEventPtr eventPtr = default); // 0x000000018B2377AC-0x000000018B2379B4
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x00000001841E1670-0x00000001841E1680
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x00000001841E1670-0x00000001841E1680
		protected void InstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x0232A6C8 */); // 0x00000001841E1670-0x00000001841E1680
		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex); // 0x00000001841E1670-0x00000001841E1680
		protected void UninstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x0232A6C9 */); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble // TypeDefIndex: 47714
	{
		// Fields
		[CompilerGenerated]
		private float _lowFrequencyMotorSpeed_k__BackingField; // 0x00
		[CompilerGenerated]
		private float _highFrequencyMotorSpeed_k__BackingField; // 0x04
	
		// Properties
		public float lowFrequencyMotorSpeed { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D871D0-0x0000000184D871E0 0x0000000184D932C0-0x0000000184D932D0
		public float highFrequencyMotorSpeed { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9C560-0x0000000184D9C570 0x0000000184DAB920-0x0000000184DAB930
		public bool isRumbling { get; } // 0x000000018B22B4B4-0x000000018B22B540 
	
		// Methods
		public void PauseHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018B22B18C-0x000000018B22B264
		public void ResumeHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018B22B2FC-0x000000018B22B398
		public void ResetHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018B22B264-0x000000018B22B2FC
		public void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency); // 0x000000018B22B398-0x000000018B22B4B4
	}

	public interface IDualMotorRumble : IHaptics // TypeDefIndex: 47715
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency);
	}

	public interface IHaptics // TypeDefIndex: 47716
	{
		// Methods
		void PauseHaptics();
		void ResumeHaptics();
		void ResetHaptics();
	}
}

namespace UnityEngine.InputSystem.HID
{
	public class HID : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 47672
	{
		// Fields
		internal const string kHIDInterface = "HID"; // Metadata: 0x0232A587
		internal const string kHIDNamespace = "HID"; // Metadata: 0x0232A58B
		private bool m_HaveParsedHIDDescriptor; // 0x190
		private HIDDeviceDescriptor m_HIDDescriptor; // 0x198
		private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x00
	
		// Properties
		public static FourCC QueryHIDReportDescriptorDeviceCommandType { get; } // 0x0000000184DAC280-0x0000000184DAC290 
		public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType { get; } // 0x0000000184DAC290-0x0000000184DAC2A0 
		public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType { get; } // 0x0000000184DAC270-0x0000000184DAC280 
		public HIDDeviceDescriptor hidDescriptor { get; } // 0x000000018B221DFC-0x000000018B221F24 
	
		// Nested types
		[Serializable]
		private class HIDLayoutBuilder // TypeDefIndex: 47659
		{
			// Fields
			public string displayName; // 0x10
			public HIDDeviceDescriptor hidDescriptor; // 0x18
			public string parentLayout; // 0x48
			public System.Type deviceType; // 0x50
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47658
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Predicate<HIDElementDescriptor> __9__4_0; // 0x08
				public static Predicate<HIDElementDescriptor> __9__4_1; // 0x10
				public static Func<InputControlLayout.ControlItem, string> __9__4_2; // 0x18
	
				// Constructors
				static __c(); // 0x000000018B2395EC-0x000000018B239788
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _Build_b__4_0(HIDElementDescriptor element); // 0x000000018B2393A4-0x000000018B2393C0
				internal bool _Build_b__4_1(HIDElementDescriptor element); // 0x000000018B2393C0-0x000000018B2393DC
				internal string _Build_b__4_2(InputControlLayout.ControlItem x); // 0x000000018B2393DC-0x000000018B2393FC
			}
	
			// Constructors
			public HIDLayoutBuilder(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public InputControlLayout Build(); // 0x000000018B220F08-0x000000018B221D14
		}
	
		public enum HIDReportType // TypeDefIndex: 47660
		{
			Unknown = 0,
			Input = 1,
			Output = 2,
			Feature = 3
		}
	
		public enum HIDCollectionType // TypeDefIndex: 47661
		{
			Physical = 0,
			Application = 1,
			Logical = 2,
			Report = 3,
			NamedArray = 4,
			UsageSwitch = 5,
			UsageModifier = 6
		}
	
		[Flags]
		public enum HIDElementFlags // TypeDefIndex: 47662
		{
			Constant = 1,
			Variable = 2,
			Relative = 4,
			Wrap = 8,
			NonLinear = 16,
			NoPreferred = 32,
			NullState = 64,
			Volatile = 128,
			BufferedBytes = 256
		}
	
		[Serializable]
		public struct HIDElementDescriptor // TypeDefIndex: 47663
		{
			// Fields
			public int usage; // 0x00
			public UsagePage usagePage; // 0x04
			public int unit; // 0x08
			public int unitExponent; // 0x0C
			public int logicalMin; // 0x10
			public int logicalMax; // 0x14
			public int physicalMin; // 0x18
			public int physicalMax; // 0x1C
			public HIDReportType reportType; // 0x20
			public int collectionIndex; // 0x24
			public int reportId; // 0x28
			public int reportSizeInBits; // 0x2C
			public int reportOffsetInBits; // 0x30
			public HIDElementFlags flags; // 0x34
			public int? usageMin; // 0x38
			public int? usageMax; // 0x40
	
			// Properties
			public bool hasNullState { get; } // 0x000000018B2303E4-0x000000018B2303F0 
			public bool hasPreferredState { get; } // 0x000000018B2303F0-0x000000018B2303FC 
			public bool isArray { get; } // 0x000000018B2303FC-0x000000018B230408 
			public bool isNonLinear { get; } // 0x000000018B230410-0x000000018B23041C 
			public bool isRelative { get; } // 0x000000018B23041C-0x000000018B230428 
			public bool isConstant { get; } // 0x000000018B230408-0x000000018B230410 
			public bool isWrapping { get; } // 0x000000018B230430-0x000000018B23043C 
			internal bool isSigned { get; } // 0x000000018B230428-0x000000018B230430 
			internal float minFloatValue { get; } // 0x000000018B2304A4-0x000000018B23050C 
			internal float maxFloatValue { get; } // 0x000000018B23043C-0x000000018B2304A4 
	
			// Methods
			public bool Is(UsagePage usagePage, int usage); // 0x000000018B2303D4-0x000000018B2303E4
			internal string DetermineName(); // 0x000000018B22FECC-0x000000018B230088
			internal string DetermineDisplayName(); // 0x000000018B22FC14-0x000000018B22FCD4
			internal bool IsUsableElement(); // 0x000000018B2303A8-0x000000018B2303D4
			internal string DetermineLayout(); // 0x000000018B22FDD8-0x000000018B22FECC
			internal FourCC DetermineFormat(); // 0x000000018B22FCD4-0x000000018B22FDD8
			internal InternedString[] DetermineUsages(); // 0x000000018B230214-0x000000018B2303A8
			internal string DetermineParameters(); // 0x000000018B230088-0x000000018B2301C4
			private string DetermineAxisNormalizationParameters(); // 0x000000018B22F930-0x000000018B22FAF4
			internal string DetermineProcessors(); // 0x000000018B2301C4-0x000000018B230214
			internal PrimitiveValue DetermineDefaultState(); // 0x000000018B22FAF4-0x000000018B22FC14
			internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder); // 0x000000018B22F2AC-0x000000018B22F930
		}
	
		[Serializable]
		public struct HIDCollectionDescriptor // TypeDefIndex: 47664
		{
			// Fields
			public HIDCollectionType type; // 0x00
			public int usage; // 0x04
			public UsagePage usagePage; // 0x08
			public int parent; // 0x0C
			public int childCount; // 0x10
			public int firstChild; // 0x14
		}
	
		[Serializable]
		public struct HIDDeviceDescriptor // TypeDefIndex: 47665
		{
			// Fields
			public int vendorId; // 0x00
			public int productId; // 0x04
			public int usage; // 0x08
			public UsagePage usagePage; // 0x0C
			public int inputReportSize; // 0x10
			public int outputReportSize; // 0x14
			public int featureReportSize; // 0x18
			public HIDElementDescriptor[] elements; // 0x20
			public HIDCollectionDescriptor[] collections; // 0x28
	
			// Methods
			public string ToJson(); // 0x000000018B22F248-0x000000018B22F2AC
			public static HIDDeviceDescriptor FromJson(string json); // 0x0000000182F13CC0-0x0000000182F18530
		}
	
		public struct HIDDeviceDescriptorBuilder // TypeDefIndex: 47666
		{
			// Fields
			public UsagePage usagePage; // 0x00
			public int usage; // 0x04
			private int m_CurrentReportId; // 0x08
			private HIDReportType m_CurrentReportType; // 0x0C
			private int m_CurrentReportOffsetInBits; // 0x10
			private List<HIDElementDescriptor> m_Elements; // 0x18
			private List<HIDCollectionDescriptor> m_Collections; // 0x20
			private int m_InputReportSize; // 0x28
			private int m_OutputReportSize; // 0x2C
			private int m_FeatureReportSize; // 0x30
	
			// Constructors
			public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage); // 0x0000000184DAC990-0x0000000184DAC9C0
			public HIDDeviceDescriptorBuilder(GenericDesktop usage); // 0x0000000184DAC960-0x0000000184DAC990
	
			// Methods
			public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1 /* Metadata: 0x0232A5A6 */); // 0x0000000184DAC920-0x0000000184DAC960
			public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits); // 0x000000018B22EA84-0x000000018B22EE48
			public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits); // 0x000000018B22EE48-0x000000018B22EE98
			public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max); // 0x000000018B22F0CC-0x000000018B22F248
			public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max); // 0x000000018B22EF50-0x000000018B22F0CC
			public HIDDeviceDescriptor Finish(); // 0x000000018B22EE98-0x000000018B22EF50
		}
	
		public enum UsagePage // TypeDefIndex: 47667
		{
			Undefined = 0,
			GenericDesktop = 1,
			Simulation = 2,
			VRControls = 3,
			SportControls = 4,
			GameControls = 5,
			GenericDeviceControls = 6,
			Keyboard = 7,
			LEDs = 8,
			Button = 9,
			Ordinal = 10,
			Telephony = 11,
			Consumer = 12,
			Digitizer = 13,
			PID = 15,
			Unicode = 16,
			AlphanumericDisplay = 20,
			MedicalInstruments = 64,
			Monitor = 128,
			Power = 132,
			BarCodeScanner = 140,
			MagneticStripeReader = 142,
			Camera = 144,
			Arcade = 145,
			VendorDefined = 65280
		}
	
		public enum GenericDesktop // TypeDefIndex: 47668
		{
			Undefined = 0,
			Pointer = 1,
			Mouse = 2,
			Joystick = 4,
			Gamepad = 5,
			Keyboard = 6,
			Keypad = 7,
			MultiAxisController = 8,
			TabletPCControls = 9,
			AssistiveControl = 10,
			X = 48,
			Y = 49,
			Z = 50,
			Rx = 51,
			Ry = 52,
			Rz = 53,
			Slider = 54,
			Dial = 55,
			Wheel = 56,
			HatSwitch = 57,
			CountedBuffer = 58,
			ByteCount = 59,
			MotionWakeup = 60,
			Start = 61,
			Select = 62,
			Vx = 64,
			Vy = 65,
			Vz = 66,
			Vbrx = 67,
			Vbry = 68,
			Vbrz = 69,
			Vno = 70,
			FeatureNotification = 71,
			ResolutionMultiplier = 72,
			SystemControl = 128,
			SystemPowerDown = 129,
			SystemSleep = 130,
			SystemWakeUp = 131,
			SystemContextMenu = 132,
			SystemMainMenu = 133,
			SystemAppMenu = 134,
			SystemMenuHelp = 135,
			SystemMenuExit = 136,
			SystemMenuSelect = 137,
			SystemMenuRight = 138,
			SystemMenuLeft = 139,
			SystemMenuUp = 140,
			SystemMenuDown = 141,
			SystemColdRestart = 142,
			SystemWarmRestart = 143,
			DpadUp = 144,
			DpadDown = 145,
			DpadRight = 146,
			DpadLeft = 147,
			SystemDock = 160,
			SystemUndock = 161,
			SystemSetup = 162,
			SystemBreak = 163,
			SystemDebuggerBreak = 164,
			ApplicationBreak = 165,
			ApplicationDebuggerBreak = 166,
			SystemSpeakerMute = 167,
			SystemHibernate = 168,
			SystemDisplayInvert = 176,
			SystemDisplayInternal = 177,
			SystemDisplayExternal = 178,
			SystemDisplayBoth = 179,
			SystemDisplayDual = 180,
			SystemDisplayToggleIntExt = 181,
			SystemDisplaySwapPrimarySecondary = 182,
			SystemDisplayLCDAutoScale = 183
		}
	
		public enum Simulation // TypeDefIndex: 47669
		{
			Undefined = 0,
			FlightSimulationDevice = 1,
			AutomobileSimulationDevice = 2,
			TankSimulationDevice = 3,
			SpaceshipSimulationDevice = 4,
			SubmarineSimulationDevice = 5,
			SailingSimulationDevice = 6,
			MotorcycleSimulationDevice = 7,
			SportsSimulationDevice = 8,
			AirplaneSimulationDevice = 9,
			HelicopterSimulationDevice = 10,
			MagicCarpetSimulationDevice = 11,
			BicylcleSimulationDevice = 12,
			FlightControlStick = 32,
			FlightStick = 33,
			CyclicControl = 34,
			CyclicTrim = 35,
			FlightYoke = 36,
			TrackControl = 37,
			Aileron = 176,
			AileronTrim = 177,
			AntiTorqueControl = 178,
			AutopilotEnable = 179,
			ChaffRelease = 180,
			CollectiveControl = 181,
			DiveBreak = 182,
			ElectronicCountermeasures = 183,
			Elevator = 184,
			ElevatorTrim = 185,
			Rudder = 186,
			Throttle = 187,
			FlightCommunications = 188,
			FlareRelease = 189,
			LandingGear = 190,
			ToeBreak = 191,
			Trigger = 192,
			WeaponsArm = 193,
			WeaponsSelect = 194,
			WingFlaps = 195,
			Accelerator = 196,
			Brake = 197,
			Clutch = 198,
			Shifter = 199,
			Steering = 200,
			TurretDirection = 201,
			BarrelElevation = 202,
			DivePlane = 203,
			Ballast = 204,
			BicycleCrank = 205,
			HandleBars = 206,
			FrontBrake = 207,
			RearBrake = 208
		}
	
		public enum Button // TypeDefIndex: 47670
		{
			Undefined = 0,
			Primary = 1,
			Secondary = 2,
			Tertiary = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 47671
		{
			// Fields
			public HIDLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0(); // 0x000000018B239568-0x000000018B239588
		}
	
		// Constructors
		public HID(); // 0x00000001853971D4-0x00000001853971DC
		static HID(); // 0x0000000184D38F00-0x0000000184D38F60
	
		// Methods
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // 0x0000000183AE96F0-0x0000000183AE9A00
		internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate); // 0x0000000183AE9AB0-0x0000000183AEA670
		public static string UsagePageToString(UsagePage usagePage); // 0x000000018B221D14-0x000000018B221D80
		public static string UsageToString(UsagePage usagePage, int usage); // 0x000000018B221D80-0x000000018B221DFC
	}

	internal static class HIDParser // TypeDefIndex: 47677
	{
		// Nested types
		private struct HIDReportData // TypeDefIndex: 47673
		{
			// Fields
			public int reportId; // 0x00
			public HID.HIDReportType reportType; // 0x04
			public int currentBitOffset; // 0x08
	
			// Methods
			public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDReportData> reports); // 0x000000018B23170C-0x000000018B231834
		}
	
		private enum HIDItemTypeAndTag // TypeDefIndex: 47674
		{
			UsagePage = 4,
			Usage = 8,
			LogicalMinimum = 20,
			UsageMinimum = 24,
			LogicalMaximum = 36,
			UsageMaximum = 40,
			PhysicalMinimum = 52,
			DesignatorIndex = 56,
			PhysicalMaximum = 68,
			DesignatorMinimum = 72,
			UnitExponent = 84,
			DesignatorMaximum = 88,
			Unit = 100,
			ReportSize = 116,
			StringIndex = 120,
			Input = 128,
			ReportID = 132,
			StringMinimum = 136,
			Output = 144,
			ReportCount = 148,
			StringMaximum = 152,
			Collection = 160,
			Push = 164,
			Delimiter = 168,
			Feature = 176,
			Pop = 180,
			EndCollection = 192
		}
	
		private struct HIDItemStateLocal // TypeDefIndex: 47675
		{
			// Fields
			public int? usage; // 0x00
			public int? usageMinimum; // 0x08
			public int? usageMaximum; // 0x10
			public int? designatorIndex; // 0x18
			public int? designatorMinimum; // 0x20
			public int? designatorMaximum; // 0x28
			public int? stringIndex; // 0x30
			public int? stringMinimum; // 0x38
			public int? stringMaximum; // 0x40
			public List<int> usageList; // 0x48
	
			// Methods
			public static void Reset(ref HIDItemStateLocal state); // 0x000000018B2307B4-0x000000018B230814
			public void SetUsage(int value); // 0x000000018B230814-0x000000018B230914
			public int GetUsage(int index); // 0x000000018B2306C4-0x000000018B2307B4
		}
	
		private struct HIDItemStateGlobal // TypeDefIndex: 47676
		{
			// Fields
			public int? usagePage; // 0x00
			public int? logicalMinimum; // 0x08
			public int? logicalMaximum; // 0x10
			public int? physicalMinimum; // 0x18
			public int? physicalMaximum; // 0x20
			public int? unitExponent; // 0x28
			public int? unit; // 0x30
			public int? reportSize; // 0x38
			public int? reportCount; // 0x40
			public int? reportId; // 0x48
	
			// Methods
			public HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState); // 0x000000018B23064C-0x000000018B2306C4
			public int GetPhysicalMin(); // 0x000000018B2305AC-0x000000018B23064C
			public int GetPhysicalMax(); // 0x000000018B23050C-0x000000018B2305AC
		}
	
		// Methods
		public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor); // 0x000000018B230914-0x000000018B2309A8
		public static unsafe bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor); // 0x000000018B2309A8-0x000000018B2316B8
		private static unsafe int ReadData(int itemSize, byte* currentPtr, byte* endPtr); // 0x000000018B2316B8-0x000000018B23170C
	}

	public static class HIDSupport // TypeDefIndex: 47679
	{
		// Fields
		private static HIDPageUsage[] s_SupportedHIDUsages; // 0x00
	
		// Properties
		public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages { get; set; } // 0x0000000183AE9A00-0x0000000183AE9AB0 0x000000018B231834-0x000000018B231A70
	
		// Nested types
		public struct HIDPageUsage // TypeDefIndex: 47678
		{
			// Fields
			public HID.UsagePage page; // 0x00
			public int usage; // 0x04
	
			// Constructors
			public HIDPageUsage(HID.UsagePage page, int usage); // 0x0000000184D85C40-0x0000000184D85C50
			public HIDPageUsage(HID.GenericDesktop usage); // 0x0000000184DAC9C0-0x0000000184DAC9D0
		}
	
		// Methods
		internal static void Initialize(); // 0x0000000183DF7230-0x0000000183DF73C0
	}
}

namespace UnityEngine.InputSystem.Interactions
{
	[System.ComponentModel.DisplayName("Hold")]
	public class HoldInteraction : IInputInteraction // TypeDefIndex: 47899
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TimePressed; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018B1B80F4-0x000000018B1B8150 
		private float pressPointOrDefault { get; } // 0x000000018B1B8150-0x000000018B1B819C 
	
		// Constructors
		public HoldInteraction(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018B1B8008-0x000000018B1B80F4
		public void Reset(); // 0x0000000184DAB9F0-0x0000000184DABA00
	}

	public class MultiTapInteraction : IInputInteraction<float> // TypeDefIndex: 47901
	{
		// Fields
		[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
		public float tapTime; // 0x10
		[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
		public float tapDelay; // 0x14
		[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
		public int tapCount; // 0x18
		public float pressPoint; // 0x1C
		private TapPhase m_CurrentTapPhase; // 0x20
		private int m_CurrentTapCount; // 0x24
		private double m_CurrentTapStartTime; // 0x28
		private double m_LastTapReleaseTime; // 0x30
	
		// Properties
		private float tapTimeOrDefault { get; } // 0x000000018B1C0CF4-0x000000018B1C0D50 
		internal float tapDelayOrDefault { get; } // 0x000000018B1C0C98-0x000000018B1C0CF4 
		private float pressPointOrDefault { get; } // 0x000000018B1C0C04-0x000000018B1C0C50 
		private float releasePointOrDefault { get; } // 0x000000018B1C0C50-0x000000018B1C0C98 
	
		// Nested types
		private enum TapPhase // TypeDefIndex: 47900
		{
			None = 0,
			WaitingForNextRelease = 1,
			WaitingForNextPress = 2
		}
	
		// Constructors
		public MultiTapInteraction(); // 0x0000000184D8D750-0x0000000184D8D760
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018B1C0A30-0x000000018B1C0C04
		public void Reset(); // 0x0000000184DABAC0-0x0000000184DABAD0
	}

	[System.ComponentModel.DisplayName("Press")]
	public class PressInteraction : IInputInteraction // TypeDefIndex: 47902
	{
		// Fields
		[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to \'Default Press Point\' in the global input settings.")]
		public float pressPoint; // 0x10
		[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
		public PressBehavior behavior; // 0x14
		private bool m_WaitingForRelease; // 0x18
	
		// Properties
		private float pressPointOrDefault { get; } // 0x000000018B1C0FCC-0x000000018B1C1018 
		private float releasePointOrDefault { get; } // 0x000000018B1C1018-0x000000018B1C1060 
	
		// Constructors
		public PressInteraction(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018B1C0D50-0x000000018B1C0FCC
		public void Reset(); // 0x0000000184D91AA0-0x0000000184D91AB0
	}

	public enum PressBehavior // TypeDefIndex: 47903
	{
		PressOnly = 0,
		ReleaseOnly = 1,
		PressAndRelease = 2
	}

	[System.ComponentModel.DisplayName("Long Tap")]
	public class SlowTapInteraction : IInputInteraction // TypeDefIndex: 47904
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_SlowTapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018B1C1780-0x000000018B1C17DC 
		private float pressPointOrDefault { get; } // 0x000000018B1C17DC-0x000000018B1C1828 
	
		// Constructors
		public SlowTapInteraction(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018B1C16D4-0x000000018B1C1780
		public void Reset(); // 0x0000000184DAB9F0-0x0000000184DABA00
	}

	[System.ComponentModel.DisplayName("Tap")]
	public class TapInteraction : IInputInteraction // TypeDefIndex: 47905
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018B1C1A0C-0x000000018B1C1A68 
		private float pressPointOrDefault { get; } // 0x000000018B1C1A68-0x000000018B1C1AB4 
		private float releasePointOrDefault { get; } // 0x000000018B1C1AB4-0x000000018B1C1AFC 
	
		// Constructors
		public TapInteraction(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018B1C1930-0x000000018B1C1A0C
		public void Reset(); // 0x0000000184DAB9F0-0x0000000184DABA00
	}
}

namespace UnityEngine.InputSystem.Layouts
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public sealed class InputControlAttribute : PropertyAttribute // TypeDefIndex: 47847
	{
		// Fields
		[CompilerGenerated]
		private string _layout_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _variants_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _format_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _usage_k__BackingField; // 0x30
		[CompilerGenerated]
		private string[] _usages_k__BackingField; // 0x38
		[CompilerGenerated]
		private string _parameters_k__BackingField; // 0x40
		[CompilerGenerated]
		private string _processors_k__BackingField; // 0x48
		[CompilerGenerated]
		private string _alias_k__BackingField; // 0x50
		[CompilerGenerated]
		private string[] _aliases_k__BackingField; // 0x58
		[CompilerGenerated]
		private string _useStateFrom_k__BackingField; // 0x60
		[CompilerGenerated]
		private uint _bit_k__BackingField; // 0x68
		[CompilerGenerated]
		private uint _offset_k__BackingField; // 0x6C
		[CompilerGenerated]
		private uint _sizeInBits_k__BackingField; // 0x70
		[CompilerGenerated]
		private int _arraySize_k__BackingField; // 0x74
		[CompilerGenerated]
		private string _displayName_k__BackingField; // 0x78
		[CompilerGenerated]
		private string _shortDisplayName_k__BackingField; // 0x80
		[CompilerGenerated]
		private bool _noisy_k__BackingField; // 0x88
		[CompilerGenerated]
		private bool _synthetic_k__BackingField; // 0x89
		[CompilerGenerated]
		private bool _dontReset_k__BackingField; // 0x8A
		[CompilerGenerated]
		private object _defaultState_k__BackingField; // 0x90
		[CompilerGenerated]
		private object _minValue_k__BackingField; // 0x98
		[CompilerGenerated]
		private object _maxValue_k__BackingField; // 0xA0
	
		// Properties
		public string layout { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string variants { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string format { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string usage { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public string[] usages { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public string parameters { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public string processors { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public string alias { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public string[] aliases { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public string useStateFrom { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public uint bit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86CF0-0x0000000184D86D00 0x0000000184D86D00-0x0000000184D86D10
		public uint offset { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86B50-0x0000000184D86B60 0x0000000184D86BB0-0x0000000184D86BC0
		public uint sizeInBits { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
		public int arraySize { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D868B0-0x0000000184D868C0 0x0000000184D868E0-0x0000000184D868F0
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public string shortDisplayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public bool noisy { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2750-0x00000001811F2760 0x00000001811F2760-0x00000001811F2770
		public bool synthetic { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D89060-0x0000000184D89070 0x0000000184D90C50-0x0000000184D90C60
		public bool dontReset { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D890B0-0x0000000184D890C0 0x0000000184DA9BE0-0x0000000184DA9BF0
		public object defaultState { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public object minValue { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public object maxValue { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
	
		// Constructors
		public InputControlAttribute(); // 0x0000000184DACEC0-0x0000000184DACED0
	}

	public delegate string InputDeviceFindControlLayoutDelegate(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // TypeDefIndex: 47848; 0x00000001814F3120-0x00000001814F3140

	public class InputControlLayout // TypeDefIndex: 47868
	{
		// Fields
		private static InternedString s_DefaultVariant; // 0x00
		public const string VariantSeparator = ";"; // Metadata: 0x0232A8A1
		private InternedString m_Name; // 0x10
		private System.Type m_Type; // 0x20
		private InternedString m_Variants; // 0x28
		private FourCC m_StateFormat; // 0x38
		internal int m_StateSizeInBytes; // 0x3C
		internal bool? m_UpdateBeforeRender; // 0x40
		internal InlinedArray<InternedString> m_BaseLayouts; // 0x48
		private InlinedArray<InternedString> m_AppliedOverrides; // 0x68
		private InternedString[] m_CommonUsages; // 0x88
		internal ControlItem[] m_Controls; // 0x90
		internal string m_DisplayName; // 0x98
		private string m_Description; // 0xA0
		private Flags m_Flags; // 0xA8
		internal static Collection s_Layouts; // 0x10
		internal static Cache s_CacheInstance; // 0x50
		internal static int s_CacheInstanceRef; // 0x58
	
		// Properties
		public static InternedString DefaultVariant { get; } // 0x000000018B2421F0-0x000000018B24224C 
		public InternedString name { get; } // 0x0000000182B2D510-0x0000000182B2D520 
		public string displayName { get; } // 0x000000018B2425D8-0x000000018B242604 
		public System.Type type { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public InternedString variants { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
		public FourCC stateFormat { get; } // 0x0000000184D863B0-0x0000000184D863C0 
		public int stateSizeInBytes { get; } // 0x0000000184D86640-0x0000000184D86650 
		public IEnumerable<InternedString> baseLayouts { get; } // 0x000000018B24242C-0x000000018B24247C 
		public IEnumerable<InternedString> appliedOverrides { get; } // 0x000000018B2423DC-0x000000018B24242C 
		public ReadOnlyArray<InternedString> commonUsages { get; } // 0x000000018B242528-0x000000018B242580 
		public ReadOnlyArray<ControlItem> controls { get; } // 0x000000018B242580-0x000000018B2425D8 
		public bool updateBeforeRender { get; } // 0x000000018B2426C0-0x000000018B2426F8 
		public bool isDeviceLayout { get; } // 0x000000018B242624-0x000000018B24269C 
		public bool isControlLayout { get; } // 0x000000018B242610-0x000000018B242624 
		public bool isOverride { get; internal set; } // 0x000000018B2426B4-0x000000018B2426C0 0x000000018B2427E8-0x000000018B242808
		public bool isGenericTypeOfDevice { get; internal set; } // 0x000000018B24269C-0x000000018B2426A8 0x000000018B2427A8-0x000000018B2427C8
		public bool hideInUI { get; internal set; } // 0x000000018B242604-0x000000018B242610 0x000000018B242788-0x000000018B2427A8
		public bool isNoisy { get; internal set; } // 0x000000018B2426A8-0x000000018B2426B4 0x000000018B2427C8-0x000000018B2427E8
		public bool? canRunInBackground { get; internal set; } // 0x000000018B2424CC-0x000000018B242528 0x000000018B2426F8-0x000000018B242788
		public ControlItem this[string path] { get => default; } // 0x000000018B24224C-0x000000018B2423DC 
		internal static ref Cache cache { get; } // 0x000000018B24247C-0x000000018B2424CC 
	
		// Nested types
		public struct ControlItem // TypeDefIndex: 47850
		{
			// Fields
			[CompilerGenerated]
			private InternedString _name_k__BackingField; // 0x00
			[CompilerGenerated]
			private InternedString _layout_k__BackingField; // 0x10
			[CompilerGenerated]
			private InternedString _variants_k__BackingField; // 0x20
			[CompilerGenerated]
			private string _useStateFrom_k__BackingField; // 0x30
			[CompilerGenerated]
			private string _displayName_k__BackingField; // 0x38
			[CompilerGenerated]
			private string _shortDisplayName_k__BackingField; // 0x40
			[CompilerGenerated]
			private ReadOnlyArray<InternedString> _usages_k__BackingField; // 0x48
			[CompilerGenerated]
			private ReadOnlyArray<InternedString> _aliases_k__BackingField; // 0x58
			[CompilerGenerated]
			private ReadOnlyArray<NamedValue> _parameters_k__BackingField; // 0x68
			[CompilerGenerated]
			private ReadOnlyArray<NameAndParameters> _processors_k__BackingField; // 0x78
			[CompilerGenerated]
			private uint _offset_k__BackingField; // 0x88
			[CompilerGenerated]
			private uint _bit_k__BackingField; // 0x8C
			[CompilerGenerated]
			private uint _sizeInBits_k__BackingField; // 0x90
			[CompilerGenerated]
			private FourCC _format_k__BackingField; // 0x94
			[CompilerGenerated]
			private Flags _flags_k__BackingField; // 0x98
			[CompilerGenerated]
			private int _arraySize_k__BackingField; // 0x9C
			[CompilerGenerated]
			private PrimitiveValue _defaultState_k__BackingField; // 0xA0
			[CompilerGenerated]
			private PrimitiveValue _minValue_k__BackingField; // 0xB0
			[CompilerGenerated]
			private PrimitiveValue _maxValue_k__BackingField; // 0xC0
	
			// Properties
			public InternedString name { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000182B77630-0x0000000182B77640 0x0000000186D4B144-0x0000000186D4B150
			public InternedString layout { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B2D510-0x0000000182B2D520 0x00000001832A8A90-0x00000001832A8AA0
			public InternedString variants { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000186E7AA80-0x0000000186E7AA90
			public string useStateFrom { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
			public string displayName { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
			public string shortDisplayName { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
			public ReadOnlyArray<InternedString> usages { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D8FD50-0x0000000184D8FD60 0x0000000186D94C5C-0x0000000186D94C6C
			public ReadOnlyArray<InternedString> aliases { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D87E00-0x0000000184D87E10 0x0000000186E77204-0x0000000186E77214
			public ReadOnlyArray<NamedValue> parameters { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184DA63C0-0x0000000184DA63D0 0x000000018B23CC78-0x000000018B23CC88
			public ReadOnlyArray<NameAndParameters> processors { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D8E8F0-0x0000000184D8E900 0x0000000186C5932C-0x0000000186C5933C
			public uint offset { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D86890-0x0000000184D868A0 0x0000000184D868C0-0x0000000184D868D0
			public uint bit { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D90C40-0x0000000184D90C50 0x0000000184D90C60-0x0000000184D90C70
			public uint sizeInBits { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
			public FourCC format { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D86B20-0x0000000184D86B30 0x0000000184D86B80-0x0000000184D86B90
			private Flags flags { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862D0-0x0000000184D862E0 0x0000000184D86300-0x0000000184D86310
			public int arraySize { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000184D86C60-0x0000000184D86C70 0x0000000184D86C80-0x0000000184D86C90
			public PrimitiveValue defaultState { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA1260-0x0000000184DA1270 0x0000000184DA1300-0x0000000184DA1310
			public PrimitiveValue minValue { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA1230-0x0000000184DA1240 0x0000000184DA12B0-0x0000000184DA12C0
			public PrimitiveValue maxValue { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184DA1220-0x0000000184DA1230 0x0000000184DA12A0-0x0000000184DA12B0
			public bool isModifyingExistingControl { get; internal set; } // 0x000000018B23CBB4-0x000000018B23CBC0 0x000000018B23CC18-0x000000018B23CC38
			public bool isNoisy { get; internal set; } // 0x000000018B23CBC0-0x000000018B23CBCC 0x000000018B23CC38-0x000000018B23CC58
			public bool isSynthetic { get; internal set; } // 0x000000018B23CBCC-0x000000018B23CBD8 0x000000018B23CC58-0x000000018B23CC78
			public bool dontReset { get; internal set; } // 0x000000018B23CB90-0x000000018B23CB9C 0x000000018B23CBD8-0x000000018B23CBF8
			public bool isFirstDefinedInThisLayout { get; internal set; } // 0x000000018B23CBA8-0x000000018B23CBB4 0x000000018B23CBF8-0x000000018B23CC18
			public bool isArray { get; } // 0x000000018B23CB9C-0x000000018B23CBA8 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 47849
			{
				isModifyingExistingControl = 1,
				IsNoisy = 2,
				IsSynthetic = 4,
				IsFirstDefinedInThisLayout = 8,
				DontReset = 16
			}
	
			// Methods
			public ControlItem Merge(ControlItem other); // 0x000000018B23C820-0x000000018B23CB90
		}
	
		public class Builder // TypeDefIndex: 47853
		{
			// Fields
			[CompilerGenerated]
			private string _name_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _displayName_k__BackingField; // 0x18
			[CompilerGenerated]
			private System.Type _type_k__BackingField; // 0x20
			[CompilerGenerated]
			private FourCC _stateFormat_k__BackingField; // 0x28
			[CompilerGenerated]
			private int _stateSizeInBytes_k__BackingField; // 0x2C
			private string m_ExtendsLayout; // 0x30
			[CompilerGenerated]
			private bool? _updateBeforeRender_k__BackingField; // 0x38
			private int m_ControlCount; // 0x3C
			private ControlItem[] m_Controls; // 0x40
	
			// Properties
			public string name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
			public FourCC stateFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
			public int stateSizeInBytes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
			public string extendsLayout { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018B239E0C-0x000000018B239E2C
			public bool? updateBeforeRender { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DACEA0-0x0000000184DACEB0 0x0000000184DA8B30-0x0000000184DA8B40
			public ReadOnlyArray<ControlItem> controls { get; } // 0x000000018B239DAC-0x000000018B239E0C 
	
			// Nested types
			public struct ControlBuilder // TypeDefIndex: 47852
			{
				// Fields
				internal Builder builder; // 0x00
				internal int index; // 0x08
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 47851
				{
					// Fields
					public static readonly __c __9; // 0x00
					public static Func<string, InternedString> __9__14_0; // 0x08
	
					// Constructors
					static __c(); // 0x000000018B249E8C-0x000000018B249EF0
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal InternedString _WithUsages_b__14_0(string x); // 0x000000018B1C2520-0x000000018B1C2544
				}
	
				// Methods
				public ControlBuilder WithDisplayName(string displayName); // 0x000000018B23B144-0x000000018B23B1A4
				public ControlBuilder WithLayout(string layout); // 0x000000018B23B250-0x000000018B23B358
				public ControlBuilder WithFormat(FourCC format); // 0x000000018B23B1F8-0x000000018B23B250
				public ControlBuilder WithFormat(string format); // 0x000000018B23B1A4-0x000000018B23B1F8
				public ControlBuilder WithByteOffset(uint offset); // 0x000000018B23B08C-0x000000018B23B0E4
				public ControlBuilder WithBitOffset(uint bit); // 0x000000018B23B034-0x000000018B23B08C
				public ControlBuilder IsSynthetic(bool value); // 0x000000018B23AF54-0x000000018B23AFC0
				public ControlBuilder IsNoisy(bool value); // 0x000000018B23AEE8-0x000000018B23AF54
				public ControlBuilder DontReset(bool value); // 0x000000018B23AE7C-0x000000018B23AEE8
				public ControlBuilder WithSizeInBits(uint sizeInBits); // 0x000000018B23B5CC-0x000000018B23B624
				public ControlBuilder WithRange(float minValue, float maxValue); // 0x000000018B23B50C-0x000000018B23B5CC
				public ControlBuilder WithUsages(params InternedString[] usages); // 0x000000018B23B624-0x000000018B23B800
				public ControlBuilder WithUsages(IEnumerable<string> usages); // 0x000000018B23B800-0x000000018B23B958
				public ControlBuilder WithUsages(params string[] usages); // 0x000000018B23B958-0x000000018B23B980
				public ControlBuilder WithParameters(string parameters); // 0x000000018B23B358-0x000000018B23B424
				public ControlBuilder WithProcessors(string processors); // 0x000000018B23B424-0x000000018B23B50C
				public ControlBuilder WithDefaultState(PrimitiveValue value); // 0x000000018B23B0E4-0x000000018B23B144
				public ControlBuilder UsingStateFrom(string path); // 0x000000018B23AFC0-0x000000018B23B034
				public ControlBuilder AsArrayOfControlsWithSize(int arraySize); // 0x000000018B23AE24-0x000000018B23AE7C
			}
	
			// Constructors
			public Builder(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public ControlBuilder AddControl(string name); // 0x000000018B23997C-0x000000018B239B58
			public Builder WithName(string name); // 0x00000001869698F4-0x0000000186969910
			public Builder WithDisplayName(string displayName); // 0x0000000186969910-0x000000018696992C
			public Builder WithType<T>()
				where T : InputControl;
			public Builder WithFormat(FourCC format); // 0x0000000184DACE80-0x0000000184DACE90
			public Builder WithFormat(string format); // 0x000000018B239D7C-0x000000018B239DAC
			public Builder WithSizeInBytes(int sizeInBytes); // 0x0000000184DACE90-0x0000000184DACEA0
			public Builder Extend(string baseLayoutName); // 0x000000018B239D60-0x000000018B239D7C
			public InputControlLayout Build(); // 0x000000018B239B58-0x000000018B239D60
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 47854
		{
			IsGenericTypeOfDevice = 1,
			HideInUI = 2,
			IsOverride = 4,
			CanRunInBackground = 8,
			CanRunInBackgroundIsSet = 16,
			IsNoisy = 32
		}
	
		[Serializable]
		internal struct LayoutJsonNameAndDescriptorOnly // TypeDefIndex: 47855
		{
			// Fields
			public string name; // 0x00
			public string extend; // 0x08
			public string[] extendMultiple; // 0x10
			public InputDeviceMatcher.MatcherJson device; // 0x18
		}
	
		[Serializable]
		private struct LayoutJson // TypeDefIndex: 47857
		{
			// Fields
			public string name; // 0x00
			public string extend; // 0x08
			public string[] extendMultiple; // 0x10
			public string format; // 0x18
			public string beforeRender; // 0x20
			public string runInBackground; // 0x28
			public string[] commonUsages; // 0x30
			public string displayName; // 0x38
			public string description; // 0x40
			public string type; // 0x48
			public string variant; // 0x50
			public bool isGenericTypeOfDevice; // 0x58
			public bool hideInUI; // 0x59
			public ControlItemJson[] controls; // 0x60
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47856
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<string, InternedString> __9__14_0; // 0x08
				public static Func<InternedString, string> __9__15_0; // 0x10
				public static Func<InternedString, string> __9__15_1; // 0x18
	
				// Constructors
				static __c(); // 0x000000018B249E28-0x000000018B249E8C
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal InternedString _ToLayout_b__14_0(string x); // 0x000000018B1C2520-0x000000018B1C2544
				internal string _FromLayout_b__15_0(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
				internal string _FromLayout_b__15_1(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
			}
	
			// Methods
			public InputControlLayout ToLayout(); // 0x000000018B2466BC-0x000000018B247040
			public static LayoutJson FromLayout(InputControlLayout layout); // 0x000000018B246300-0x000000018B2466BC
		}
	
		[Serializable]
		private class ControlItemJson // TypeDefIndex: 47859
		{
			// Fields
			public string name; // 0x10
			public string layout; // 0x18
			public string variants; // 0x20
			public string usage; // 0x28
			public string alias; // 0x30
			public string useStateFrom; // 0x38
			public uint offset; // 0x40
			public uint bit; // 0x44
			public uint sizeInBits; // 0x48
			public string format; // 0x50
			public int arraySize; // 0x58
			public string[] usages; // 0x60
			public string[] aliases; // 0x68
			public string parameters; // 0x70
			public string processors; // 0x78
			public string displayName; // 0x80
			public string shortDisplayName; // 0x88
			public bool noisy; // 0x90
			public bool dontReset; // 0x91
			public bool synthetic; // 0x92
			public string defaultState; // 0x98
			public string minValue; // 0xA0
			public string maxValue; // 0xA8
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47858
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<string, InternedString> __9__24_0; // 0x08
				public static Func<string, InternedString> __9__24_1; // 0x10
				public static Func<NamedValue, string> __9__25_0; // 0x18
				public static Func<NameAndParameters, string> __9__25_1; // 0x20
				public static Func<InternedString, string> __9__25_2; // 0x28
				public static Func<InternedString, string> __9__25_3; // 0x30
	
				// Constructors
				static __c(); // 0x000000018B249DC4-0x000000018B249E28
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal InternedString _ToLayout_b__24_0(string x); // 0x000000018B1C2520-0x000000018B1C2544
				internal InternedString _ToLayout_b__24_1(string x); // 0x000000018B1C2520-0x000000018B1C2544
				internal string _FromControlItems_b__25_0(NamedValue x); // 0x000000018B1C93BC-0x000000018B1C93D0
				internal string _FromControlItems_b__25_1(NameAndParameters x); // 0x000000018B249D6C-0x000000018B249D80
				internal string _FromControlItems_b__25_2(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
				internal string _FromControlItems_b__25_3(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
			}
	
			// Constructors
			public ControlItemJson(); // 0x0000000184DACEB0-0x0000000184DACEC0
	
			// Methods
			public ControlItem ToLayout(); // 0x000000018B23C148-0x000000018B23C820
			public static ControlItemJson[] FromControlItems(ControlItem[] items); // 0x000000018B23B980-0x000000018B23C148
		}
	
		internal struct Collection // TypeDefIndex: 47863
		{
			// Fields
			public const float kBaseScoreForNonGeneratedLayouts = 1f; // Metadata: 0x0232A8AF
			public Dictionary<InternedString, System.Type> layoutTypes; // 0x00
			public Dictionary<InternedString, string> layoutStrings; // 0x08
			public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders; // 0x10
			public Dictionary<InternedString, InternedString> baseLayoutTable; // 0x18
			public Dictionary<InternedString, InternedString[]> layoutOverrides; // 0x20
			public HashSet<InternedString> layoutOverrideNames; // 0x28
			public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; // 0x30
			public List<LayoutMatcher> layoutMatchers; // 0x38
	
			// Nested types
			public struct LayoutMatcher // TypeDefIndex: 47860
			{
				// Fields
				public InternedString layoutName; // 0x00
				public InputDeviceMatcher deviceMatcher; // 0x10
			}
	
			public struct PrecompiledLayout // TypeDefIndex: 47861
			{
				// Fields
				public Func<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x00
				public string metadata; // 0x08
			}
	
			[CompilerGenerated]
			private sealed class _GetBaseLayouts_d__24 : IEnumerable<InternedString>, IEnumerator<InternedString> // TypeDefIndex: 47862
			{
				// Fields
				private int __1__state; // 0x10
				private InternedString __2__current; // 0x18
				private int __l__initialThreadId; // 0x28
				private bool includeSelf; // 0x2C
				public bool __3__includeSelf; // 0x2D
				private InternedString layout; // 0x30
				public InternedString __3__layout; // 0x40
				public Collection __4__this; // 0x50
				public Collection __3____4__this; // 0x90
	
				// Properties
				InternedString IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current { [DebuggerHidden] get; } // 0x0000000184D890C0-0x0000000184D890D0 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1C24D8-0x000000018B1C2520 
	
				// Constructors
				[DebuggerHidden]
				public _GetBaseLayouts_d__24(int __1__state); // 0x0000000186C07014-0x0000000186C07030
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018B1C22FC-0x000000018B1C23B0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018B1C248C-0x000000018B1C24D8
				[DebuggerHidden]
				IEnumerator<InternedString> IEnumerable<InternedString>.GetEnumerator(); // 0x000000018B1C23B0-0x000000018B1C2484
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1C2484-0x000000018B1C248C
			}
	
			// Methods
			public void Allocate(); // 0x0000000183DF51F0-0x0000000183DF5480
			public InternedString TryFindLayoutForType(System.Type layoutType); // 0x0000000183AEDEB0-0x0000000183AEE050
			public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription); // 0x0000000183AEC6C0-0x0000000183AEC880
			public bool HasLayout(InternedString name); // 0x0000000183AEF410-0x0000000183AEF4F0
			private InputControlLayout TryLoadLayoutInternal(InternedString name); // 0x000000018B23A474-0x000000018B23A660
			public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null); // 0x000000018B23A660-0x000000018B23AA7C
			public InternedString GetBaseLayoutName(InternedString layoutName); // 0x000000018B23A1B0-0x000000018B23A238
			public InternedString GetRootLayoutName(InternedString layoutName); // 0x000000018B23A300-0x000000018B23A38C
			public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance); // 0x000000018B239F00-0x000000018B239FDC
			public InternedString FindLayoutThatIntroducesControl(InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache); // 0x000000018B239FDC-0x000000018B23A1B0
			public System.Type GetControlTypeForLayout(InternedString layoutName); // 0x0000000183AE94D0-0x0000000183AE95B0
			public bool ValueTypeIsAssignableFrom(InternedString layoutName, System.Type valueType); // 0x000000018B23AA7C-0x000000018B23AB4C
			public bool IsGeneratedLayout(InternedString layout); // 0x000000018B23A418-0x000000018B23A474
			[IteratorStateMachine(typeof(_GetBaseLayouts_d__24))]
			public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true /* Metadata: 0x0232A8AE */); // 0x000000018B23A238-0x000000018B23A300
			public bool IsBasedOn(InternedString parentLayout, InternedString childLayout); // 0x000000018B23A38C-0x000000018B23A418
			public void AddMatcher(InternedString layout, InputDeviceMatcher matcher); // 0x0000000183AEC880-0x0000000183AECA20
		}
	
		public class LayoutNotFoundException : Exception // TypeDefIndex: 47864
		{
			// Fields
			[CompilerGenerated]
			private readonly string _layout_k__BackingField; // 0x90
	
			// Properties
			public string layout { [CompilerGenerated] get; } // 0x0000000184D86220-0x0000000184D86230 
	
			// Constructors
			public LayoutNotFoundException(); // 0x000000018B1C0550-0x000000018B1C059C
			public LayoutNotFoundException(string name, string message); // 0x000000018B1C06A0-0x000000018B1C0710
			public LayoutNotFoundException(string name); // 0x000000018B1C059C-0x000000018B1C0640
			public LayoutNotFoundException(string message, Exception innerException); // 0x000000018B1C0640-0x000000018B1C06A0
			protected LayoutNotFoundException(SerializationInfo info, StreamingContext context); // 0x000000018B1C0710-0x000000018B1C077C
		}
	
		internal struct Cache // TypeDefIndex: 47865
		{
			// Fields
			public Dictionary<InternedString, InputControlLayout> table; // 0x00
	
			// Methods
			public void Clear(); // 0x0000000185395148-0x0000000185395154
			public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true /* Metadata: 0x0232A8B3 */); // 0x000000018B1B6E58-0x000000018B1B6F9C
		}
	
		internal struct CacheRefInstance : IDisposable // TypeDefIndex: 47866
		{
			// Fields
			public bool valid; // 0x00
	
			// Methods
			public void Dispose(); // 0x000000018B1B6DC4-0x000000018B1B6E58
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47867
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, InternedString> __9__52_0; // 0x08
			public static Func<string, InternedString> __9__75_0; // 0x10
			public static Func<string, InternedString> __9__75_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018B1C2544-0x000000018B1C25A8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal InternedString _FromType_b__52_0(string x); // 0x000000018B1C2520-0x000000018B1C2544
			internal InternedString _CreateControlItemFromMember_b__75_0(string x); // 0x000000018B1C2520-0x000000018B1C2544
			internal InternedString _CreateControlItemFromMember_b__75_1(string x); // 0x000000018B1C2520-0x000000018B1C2544
		}
	
		// Constructors
		private InputControlLayout(string name, System.Type type); // 0x000000018B2421A0-0x000000018B2421F0
		static InputControlLayout(); // 0x0000000184D29060-0x0000000184D290E0
	
		// Methods
		public ControlItem? FindControl(InternedString path); // 0x000000018B23E7BC-0x000000018B23EAA8
		public ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex); // 0x000000018B23E3E0-0x000000018B23E7BC
		public System.Type GetValueType(); // 0x000000018B23EF98-0x000000018B23F00C
		public static InputControlLayout FromType(string name, System.Type type); // 0x000000018B23EB44-0x000000018B23EF98
		public string ToJson(); // 0x000000018B241F44-0x000000018B241FE8
		public static InputControlLayout FromJson(string json); // 0x000000018B23EAA8-0x000000018B23EB44
		private static void AddControlItems(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018B23D66C-0x000000018B23D6E0
		private static void AddControlItemsFromFields(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018B23CEBC-0x000000018B23CF38
		private static void AddControlItemsFromProperties(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018B23D5F0-0x000000018B23D66C
		private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName); // 0x000000018B23D14C-0x000000018B23D5F0
		private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems); // 0x000000018B23CF38-0x000000018B23D14C
		private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute); // 0x000000018B23D738-0x000000018B23E05C
		private static string InferLayoutFromValueType(System.Type type); // 0x000000018B23F00C-0x000000018B23F1EC
		public void MergeLayout(InputControlLayout other); // 0x000000018B23F1EC-0x000000018B241F44
		private static Dictionary<string, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<string> variants = null); // 0x000000018B23E05C-0x000000018B23E3E0
		internal static bool VariantsMatch(InternedString expected, InternedString actual); // 0x000000018B24205C-0x000000018B2420B8
		internal static bool VariantsMatch(string expected, string actual); // 0x000000018B2420B8-0x000000018B2421A0
		internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher); // 0x0000000183DF76B0-0x0000000183DF7830
		internal static CacheRefInstance CacheRef(); // 0x000000018B23D6E0-0x000000018B23D738
		[CompilerGenerated]
		private bool _MergeLayout_b__77_0(ControlItem x); // 0x000000018B241FE8-0x000000018B24205C
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class InputControlLayoutAttribute : Attribute // TypeDefIndex: 47869
	{
		// Fields
		[CompilerGenerated]
		private System.Type _stateType_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _stateFormat_k__BackingField; // 0x18
		[CompilerGenerated]
		private string[] _commonUsages_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _variants_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _isNoisy_k__BackingField; // 0x30
		internal bool? canRunInBackgroundInternal; // 0x31
		internal bool? updateBeforeRenderInternal; // 0x33
		[CompilerGenerated]
		private bool _isGenericTypeOfDevice_k__BackingField; // 0x35
		[CompilerGenerated]
		private string _displayName_k__BackingField; // 0x38
		[CompilerGenerated]
		private string _description_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _hideInUI_k__BackingField; // 0x48
	
		// Properties
		public System.Type stateType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string stateFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string[] commonUsages { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string variants { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public bool isNoisy { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public bool canRunInBackground { get; set; } // 0x000000018B1B92D0-0x000000018B1B930C 0x000000018B1B9348-0x000000018B1B9394
		public bool updateBeforeRender { get; set; } // 0x000000018B1B930C-0x000000018B1B9348 0x000000018B1B9394-0x000000018B1B93E0
		public bool isGenericTypeOfDevice { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86D30-0x0000000184D86D40 0x0000000184D86D40-0x0000000184D86D50
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public string description { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public bool hideInUI { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
	
		// Constructors
		public InputControlLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal struct InputDeviceBuilder : IDisposable // TypeDefIndex: 47871
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x00
		private InputControlLayout.CacheRefInstance m_LayoutCacheRef; // 0x08
		private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x10
		private List<uint> m_StateOffsetToControlMap; // 0x18
		private StringBuilder m_StringBuilder; // 0x20
		private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; // Metadata: 0x0232A8B4
		private static InputDeviceBuilder s_Instance; // 0x00
		private static int s_InstanceRef; // 0x28
	
		// Properties
		internal static ref InputDeviceBuilder instance { get; } // 0x000000018B1BDC40-0x000000018B1BDC74 
	
		// Nested types
		internal struct RefInstance : IDisposable // TypeDefIndex: 47870
		{
			// Methods
			public void Dispose(); // 0x000000018B1C1640-0x000000018B1C16D4
		}
	
		// Methods
		public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = default); // 0x000000018B1BDA70-0x000000018B1BDBDC
		public UnityEngine.InputSystem.InputDevice Finish(); // 0x000000018B1BBC6C-0x000000018B1BC034
		public void Dispose(); // 0x000000018B1BB510-0x000000018B1BB51C
		private void Reset(); // 0x000000018B1BD704-0x000000018B1BD76C
		private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent); // 0x000000018B1BD644-0x000000018B1BD6C4
		private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent); // 0x000000018B1BCF9C-0x000000018B1BD644
		private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls); // 0x000000018B1B9DC0-0x000000018B1BA4EC
		private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null); // 0x000000018B1B94A8-0x000000018B1B9DC0
		private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem); // 0x000000018B1BC55C-0x000000018B1BC894
		private string ChildControlOverridePath(InputControl parent, InternedString controlName); // 0x000000018B1BABF8-0x000000018B1BAC70
		private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem); // 0x000000018B1B93E0-0x000000018B1B94A8
		private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem); // 0x000000018B1BC894-0x000000018B1BCCA0
		private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout); // 0x000000018B1BAA24-0x000000018B1BABF8
		private static void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, InputControl exceptControl); // 0x000000018B1BDBDC-0x000000018B1BDC40
		private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName); // 0x000000018B1BD76C-0x000000018B1BD9E0
		private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName); // 0x000000018B1BA778-0x000000018B1BA814
		private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName); // 0x000000018B1BA814-0x000000018B1BAA24
		private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem); // 0x000000018B1BD9E0-0x000000018B1BDA70
		private static InputControlLayout FindOrLoadLayout(string name); // 0x000000018B1BBC1C-0x000000018B1BBC6C
		private static void ComputeStateLayout(InputControl control); // 0x000000018B1BAC70-0x000000018B1BB510
		private void FinalizeControlHierarchy(); // 0x000000018B1BB988-0x000000018B1BBC1C
		private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex); // 0x000000018B1BB51C-0x000000018B1BB988
		private void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset); // 0x000000018B1BCCA0-0x000000018B1BCF9C
		private ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset); // 0x000000018B1BC034-0x000000018B1BC494
		private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex); // 0x000000018B1BA61C-0x000000018B1BA778
		private void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right); // 0x000000018B1BA4EC-0x000000018B1BA61C
		private ushort GetControlIndex(InputControl control); // 0x000000018B1BC494-0x000000018B1BC55C
		internal static RefInstance Ref(); // 0x000000018B1BD6C4-0x000000018B1BD704
	}

	[Serializable]
	public struct InputDeviceDescription : IEquatable<InputDeviceDescription> // TypeDefIndex: 47873
	{
		// Fields
		[SerializeField]
		private string m_InterfaceName; // 0x00
		[SerializeField]
		private string m_DeviceClass; // 0x08
		[SerializeField]
		private string m_Manufacturer; // 0x10
		[SerializeField]
		private string m_Product; // 0x18
		[SerializeField]
		private string m_Serial; // 0x20
		[SerializeField]
		private string m_Version; // 0x28
		[SerializeField]
		private string m_Capabilities; // 0x30
	
		// Properties
		public string interfaceName { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public string deviceClass { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public string manufacturer { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string product { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string serial { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string version { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string capabilities { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public bool empty { get; } // 0x000000018B1BE2F8-0x000000018B1BE360 
	
		// Nested types
		private struct DeviceDescriptionJson // TypeDefIndex: 47872
		{
			// Fields
			public string @interface; // 0x00
			public string type; // 0x08
			public string product; // 0x10
			public string serial; // 0x18
			public string version; // 0x20
			public string manufacturer; // 0x28
			public string capabilities; // 0x30
		}
	
		// Methods
		public override string ToString(); // 0x000000018B1BE0E4-0x000000018B1BE2F8
		public bool Equals(InputDeviceDescription other); // 0x000000018B1BDDCC-0x000000018B1BDEC4
		public override bool Equals(object obj); // 0x000000018B1BDD40-0x000000018B1BDDCC
		public override int GetHashCode(); // 0x000000018B1BDEC4-0x000000018B1BDFD8
		public static bool operator ==(InputDeviceDescription left, InputDeviceDescription right); // 0x000000018B1BE360-0x000000018B1BE39C
		public static bool operator !=(InputDeviceDescription left, InputDeviceDescription right); // 0x000000018B1BE39C-0x000000018B1BE3D8
		public string ToJson(); // 0x000000018B1BDFD8-0x000000018B1BE0E4
		public static InputDeviceDescription FromJson(string json); // 0x0000000183AEADB0-0x0000000183AEAEC0
		internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonParser.JsonString propertyValue, string deviceDescriptor); // 0x000000018B1BDC74-0x000000018B1BDD40
	}

	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher> // TypeDefIndex: 47878
	{
		// Fields
		private KeyValuePair<InternedString, object>[] m_Patterns; // 0x00
		private static readonly InternedString kInterfaceKey; // 0x00
		private static readonly InternedString kDeviceClassKey; // 0x10
		private static readonly InternedString kManufacturerKey; // 0x20
		private static readonly InternedString kManufacturerContainsKey; // 0x30
		private static readonly InternedString kProductKey; // 0x40
		private static readonly InternedString kVersionKey; // 0x50
	
		// Properties
		public bool empty { get; } // 0x000000018314CD60-0x000000018314CD70 
		public IEnumerable<KeyValuePair<string, object>> patterns { [IteratorStateMachine(typeof(_get_patterns_d__4))] get; } // 0x000000018B1BE844-0x000000018B1BE8B4 
	
		// Nested types
		[Serializable]
		internal struct MatcherJson // TypeDefIndex: 47875
		{
			// Fields
			public string @interface; // 0x00
			public string[] interfaces; // 0x08
			public string deviceClass; // 0x10
			public string[] deviceClasses; // 0x18
			public string manufacturer; // 0x20
			public string manufacturerContains; // 0x28
			public string[] manufacturers; // 0x30
			public string product; // 0x38
			public string[] products; // 0x40
			public string version; // 0x48
			public string[] versions; // 0x50
			public Capability[] capabilities; // 0x58
	
			// Nested types
			public struct Capability // TypeDefIndex: 47874
			{
				// Fields
				public string path; // 0x00
				public string value; // 0x08
			}
	
			// Methods
			public static MatcherJson FromMatcher(InputDeviceMatcher matcher); // 0x000000018B1C077C-0x000000018B1C0A30
			public InputDeviceMatcher ToMatcher(); // 0x0000000183DF7830-0x0000000183DF7940
		}
	
		[CompilerGenerated]
		private sealed class _get_patterns_d__4 : IEnumerable<KeyValuePair<string, object>>, IEnumerator<KeyValuePair<string, object>> // TypeDefIndex: 47876
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<string, object> __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			public InputDeviceMatcher __4__this; // 0x30
			public InputDeviceMatcher __3____4__this; // 0x38
			private int _count_5__2; // 0x40
			private int _i_5__3; // 0x44
	
			// Properties
			KeyValuePair<string, object> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { [DebuggerHidden] get; } // 0x0000000184D890C0-0x0000000184D890D0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1C27A0-0x000000018B1C27E8 
	
			// Constructors
			[DebuggerHidden]
			public _get_patterns_d__4(int __1__state); // 0x0000000186C07014-0x0000000186C07030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1C25A8-0x000000018B1C26B8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1C2754-0x000000018B1C27A0
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator(); // 0x000000018B1C26B8-0x000000018B1C274C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1C274C-0x000000018B1C2754
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47877
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<char, bool> __9__12_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D456D0-0x0000000184D45730
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _With_b__12_0(char ch); // 0x00000001844834A0-0x0000000184483500
		}
	
		// Constructors
		static InputDeviceMatcher(); // 0x00000001849CE070-0x00000001849CE2A0
	
		// Methods
		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true /* Metadata: 0x0232A8B5 */); // 0x0000000183AF1A30-0x0000000183AF1AD0
		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true /* Metadata: 0x0232A8B6 */); // 0x000000018B1BE73C-0x000000018B1BE7C0
		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true /* Metadata: 0x0232A8B7 */); // 0x0000000184A787E0-0x0000000184A78880
		public InputDeviceMatcher WithManufacturerContains(string noRegExPattern); // 0x0000000183DF6C50-0x0000000183DF6D10
		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true /* Metadata: 0x0232A8B8 */); // 0x0000000183AF2800-0x0000000183AF28A0
		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true /* Metadata: 0x0232A8B9 */); // 0x000000018B1BE7C0-0x000000018B1BE844
		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value);
		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true /* Metadata: 0x0232A8BA */); // 0x0000000183AF0D70-0x0000000183AF0F50
		public float MatchPercentage(InputDeviceDescription deviceDescription); // 0x0000000183AECB90-0x0000000183AECF50
		private static bool MatchSingleProperty(object pattern, string value); // 0x0000000183AECF50-0x0000000183AECFB0
		private static bool MatchSinglePropertyContains(object pattern, string value); // 0x0000000183AEBBA0-0x0000000183AEBC10
		private static int GetNumPropertiesIn(InputDeviceDescription description); // 0x000000018B1BE57C-0x000000018B1BE5F4
		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription); // 0x000000018B1BE44C-0x000000018B1BE57C
		public override string ToString(); // 0x000000018B1BE5F4-0x000000018B1BE73C
		public bool Equals(InputDeviceMatcher other); // 0x0000000183AECA60-0x0000000183AECB70
		public override bool Equals(object obj); // 0x000000018B1BE3D8-0x000000018B1BE44C
		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right); // 0x0000000183AECA20-0x0000000183AECA60
		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right); // 0x000000018B1BE8B4-0x000000018B1BE908
		public override int GetHashCode(); // 0x000000018860F504-0x000000018860F528
	}
}

namespace UnityEngine.InputSystem.LowLevel
{
	public struct DisableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 47717
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0232A6D7
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC5A0-0x0000000184DAC5B0 
		public FourCC typeStatic { get; } // 0x0000000184DAC5A0-0x0000000184DAC5B0 
	
		// Methods
		public static DisableDeviceCommand Create(); // 0x0000000184DAC580-0x0000000184DAC5A0
	}

	public struct EnableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 47718
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0232A6D8
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC870-0x0000000184DAC880 
		public FourCC typeStatic { get; } // 0x0000000184DAC870-0x0000000184DAC880 
	
		// Methods
		public static EnableDeviceCommand Create(); // 0x0000000184DAC850-0x0000000184DAC870
	}

	public struct EnableIMECompositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 47719
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0232A6D9
		public InputDeviceCommand baseCommand; // 0x00
		private byte m_ImeEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC880-0x0000000184DAC890 
		public bool imeEnabled { get; } // 0x000000018B22D1AC-0x000000018B22D1B4 
		public FourCC typeStatic { get; } // 0x0000000184DAC880-0x0000000184DAC890 
	
		// Methods
		public static EnableIMECompositionCommand Create(bool enabled); // 0x000000018B22D184-0x000000018B22D1AC
	}

	public interface IInputDeviceCommandInfo // TypeDefIndex: 47720
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo // TypeDefIndex: 47722
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0232A6DA
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACA00-0x0000000184DACA10 
		public FourCC typeStatic { get; } // 0x0000000184DACA00-0x0000000184DACA10 
	
		// Nested types
		public enum Result // TypeDefIndex: 47721
		{
			ErrorAlreadyInProgress = -2,
			ErrorNotSupported = -1,
			SuccessfullyInitiated = 1
		}
	
		// Methods
		public static InitiateUserAccountPairingCommand Create(); // 0x0000000184DAC9E0-0x0000000184DACA00
	}

	public unsafe delegate long? InputDeviceCommandDelegate(UnityEngine.InputSystem.InputDevice device, InputDeviceCommand* command); // TypeDefIndex: 47723; 0x0000000186222510-0x0000000186222544

	public delegate long InputDeviceExecuteCommandDelegate(ref InputDeviceCommand command); // TypeDefIndex: 47724; 0x00000001814E2060-0x00000001814E2070

	public struct InputDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 47725
	{
		// Fields
		internal const int kBaseCommandSize = 8; // Metadata: 0x0232A6DF
		public const int BaseCommandSize = 8; // Metadata: 0x0232A6E0
		public const long GenericFailure = -1; // Metadata: 0x0232A6E1
		public const long GenericSuccess = 1; // Metadata: 0x0232A6E9
		public FourCC type; // 0x00
		public int sizeInBytes; // 0x04
	
		// Properties
		public int payloadSizeInBytes { get; } // 0x0000000184DACA10-0x0000000184DACA20 
		public unsafe void* payloadPtr { get; } // 0x0000000184D94D90-0x0000000184D94DA0 
		public FourCC typeStatic { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public InputDeviceCommand(FourCC type, int sizeInBytes = 8 /* Metadata: 0x0232A6DE */); // 0x0000000184D85C40-0x0000000184D85C50
	
		// Methods
		public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize); // 0x0000000183AEA670-0x0000000183AEA710
	}

	public struct QueryCanRunInBackground : IInputDeviceCommandInfo // TypeDefIndex: 47726
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x0232A6F1
		public InputDeviceCommand baseCommand; // 0x00
		public bool canRunInBackground; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACAD0-0x0000000184DACAE0 
		public FourCC typeStatic { get; } // 0x0000000184DACAD0-0x0000000184DACAE0 
	
		// Methods
		public static QueryCanRunInBackground Create(); // 0x0000000184750A00-0x0000000184750A30
	}

	public struct QueryDimensionsCommand : IInputDeviceCommandInfo // TypeDefIndex: 47727
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0232A6F2
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 outDimensions; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACB10-0x0000000184DACB20 
		public FourCC typeStatic { get; } // 0x0000000184DACB10-0x0000000184DACB20 
	
		// Methods
		public static QueryDimensionsCommand Create(); // 0x0000000184DACAE0-0x0000000184DACB10
	}

	public struct QueryEnabledStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 47728
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x0232A6F3
		public InputDeviceCommand baseCommand; // 0x00
		public bool isEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACB50-0x0000000184DACB60 
		public FourCC typeStatic { get; } // 0x0000000184DACB50-0x0000000184DACB60 
	
		// Methods
		public static QueryEnabledStateCommand Create(); // 0x0000000184DACB20-0x0000000184DACB50
	}

	public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo // TypeDefIndex: 47730
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0232A6F4
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACC00-0x0000000184DACC10 
		public FourCC typeStatic { get; } // 0x0000000184DACC00-0x0000000184DACC10 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 47729
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadLayoutName(); // 0x000000018B235950-0x000000018B235964
		public void WriteLayoutName(string name); // 0x000000018B235964-0x000000018B235990
		public static QueryKeyboardLayoutCommand Create(); // 0x0000000184DACBC0-0x0000000184DACC00
	}

	public struct QueryKeyNameCommand : IInputDeviceCommandInfo // TypeDefIndex: 47732
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0232A6F6
		internal const int kSize = 268; // Metadata: 0x0232A6F8
		public InputDeviceCommand baseCommand; // 0x00
		public int scanOrKeyCode; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x0C
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACBB0-0x0000000184DACBC0 
		public FourCC typeStatic { get; } // 0x0000000184DACBB0-0x0000000184DACBC0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 47731
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadKeyName(); // 0x000000018B23593C-0x000000018B235950
		public static QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key); // 0x0000000184DACB60-0x0000000184DACBB0
	}

	public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo // TypeDefIndex: 47736
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0232A6FA
		internal const int kMaxIdLength = 256; // Metadata: 0x0232A6FC
		internal const int kSize = 1040; // Metadata: 0x0232A6FE
		public InputDeviceCommand baseCommand; // 0x00
		public ulong handle; // 0x08
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x10
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x210
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACC50-0x0000000184DACC60 
		public string id { get; set; } // 0x000000018B235990-0x000000018B2359A4 0x000000018B2359B8-0x000000018B235ADC
		public string name { get; set; } // 0x000000018B2359A4-0x000000018B2359B8 0x000000018B235ADC-0x000000018B235C00
		public FourCC typeStatic { get; } // 0x0000000184DACC50-0x0000000184DACC60 
	
		// Nested types
		[Flags]
		public enum Result : long // TypeDefIndex: 47733
		{
			DevicePairedToUserAccount = 2,
			UserAccountSelectionInProgress = 4,
			UserAccountSelectionComplete = 8,
			UserAccountSelectionCanceled = 16
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 47734
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 47735
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static QueryPairedUserAccountCommand Create(); // 0x0000000184DACC10-0x0000000184DACC50
	}

	internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 47737
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0232A720
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACC90-0x0000000184DACCA0 
		public FourCC typeStatic { get; } // 0x0000000184DACC90-0x0000000184DACCA0 
	
		// Methods
		public static QuerySamplingFrequencyCommand Create(); // 0x0000000184DACC60-0x0000000184DACC90
	}

	internal struct QueryUserIdCommand : IInputDeviceCommandInfo // TypeDefIndex: 47739
	{
		// Fields
		public const int kMaxIdLength = 256; // Metadata: 0x0232A721
		internal const int kSize = 520; // Metadata: 0x0232A723
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACCE0-0x0000000184DACCF0 
		public FourCC typeStatic { get; } // 0x0000000184DACCE0-0x0000000184DACCF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 47738
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadId(); // 0x000000018B235950-0x000000018B235964
		public static QueryUserIdCommand Create(); // 0x0000000184DACCA0-0x0000000184DACCE0
	}

	public struct RequestResetCommand : IInputDeviceCommandInfo // TypeDefIndex: 47740
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0232A725
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACD10-0x0000000184DACD20 
		public FourCC typeStatic { get; } // 0x0000000184DACD10-0x0000000184DACD20 
	
		// Methods
		public static RequestResetCommand Create(); // 0x0000000184DACCF0-0x0000000184DACD10
	}

	public struct RequestSyncCommand : IInputDeviceCommandInfo // TypeDefIndex: 47741
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0232A726
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACD40-0x0000000184DACD50 
		public FourCC typeStatic { get; } // 0x0000000184DACD40-0x0000000184DACD50 
	
		// Methods
		public static RequestSyncCommand Create(); // 0x0000000184DACD20-0x0000000184DACD40
	}

	public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 47742
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0232A727
		public InputDeviceCommand baseCommand; // 0x00
		private Vector2 m_Position; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACDA0-0x0000000184DACDB0 
		public Vector2 position { get; } // 0x0000000184D9C5E0-0x0000000184D9C600 
		public FourCC typeStatic { get; } // 0x0000000184DACDA0-0x0000000184DACDB0 
	
		// Methods
		public static SetIMECursorPositionCommand Create(Vector2 cursorPosition); // 0x0000000184DACD80-0x0000000184DACDA0
	}

	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 47743
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0232A728
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACDE0-0x0000000184DACDF0 
		public FourCC typeStatic { get; } // 0x0000000184DACDE0-0x0000000184DACDF0 
	
		// Methods
		public static SetSamplingFrequencyCommand Create(float frequency); // 0x0000000184DACDB0-0x0000000184DACDE0
	}

	internal struct WarpMousePositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 47744
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0232A729
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 warpPositionInPlayerDisplaySpace; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DACE70-0x0000000184DACE80 
		public FourCC typeStatic { get; } // 0x0000000184DACE70-0x0000000184DACE80 
	
		// Methods
		public static WarpMousePositionCommand Create(Vector2 position); // 0x0000000184DACE50-0x0000000184DACE70
	}

	public struct GamepadState : IInputStateTypeInfo // TypeDefIndex: 47745
	{
		// Fields
		internal const string ButtonSouthShortDisplayName = "A"; // Metadata: 0x0232A72B
		internal const string ButtonNorthShortDisplayName = "Y"; // Metadata: 0x0232A72D
		internal const string ButtonWestShortDisplayName = "X"; // Metadata: 0x0232A72F
		internal const string ButtonEastShortDisplayName = "B"; // Metadata: 0x0232A731
		[InputControl(name = "rightShoulder", layout = "Button", bit = 11, displayName = "Right Shoulder", shortDisplayName = "RB")]
		[InputControl(name = "leftShoulder", layout = "Button", bit = 10, displayName = "Left Shoulder", shortDisplayName = "LB")]
		[InputControl(name = "rightStickPress", layout = "Button", bit = 9, displayName = "Right Stick Press")]
		[InputControl(name = "leftStickPress", layout = "Button", bit = 8, displayName = "Left Stick Press")]
		[InputControl(name = "buttonEast", layout = "Button", bit = 5, usages = new string[2] {"Back", "Cancel" }, aliases = new string[2] {"b", "circle" }, displayName = "Button East", shortDisplayName = "B")]
		[InputControl(name = "buttonWest", layout = "Button", bit = 7, usage = "SecondaryAction", aliases = new string[2] {"x", "square" }, displayName = "Button West", shortDisplayName = "X")]
		[InputControl(name = "buttonSouth", layout = "Button", bit = 6, usages = new string[2] {"PrimaryAction", "Submit" }, aliases = new string[2] {"a", "cross" }, displayName = "Button South", shortDisplayName = "A")]
		[InputControl(name = "dpad", layout = "Dpad", usage = "Hatswitch", displayName = "D-Pad", format = "BIT", sizeInBits = 4, bit = 0)]
		[InputControl(name = "start", layout = "Button", bit = 12, usage = "Menu", displayName = "Start")]
		[InputControl(name = "buttonNorth", layout = "Button", bit = 4, aliases = new string[2] {"y", "triangle" }, displayName = "Button North", shortDisplayName = "Y")]
		[InputControl(name = "select", layout = "Button", bit = 13, displayName = "Select")]
		public uint buttons; // 0x00
		[InputControl(layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone", displayName = "Left Stick", shortDisplayName = "LS")]
		public Vector2 leftStick; // 0x04
		[InputControl(layout = "Stick", usage = "Secondary2DMotion", processors = "stickDeadzone", displayName = "Right Stick", shortDisplayName = "RS")]
		public Vector2 rightStick; // 0x0C
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Left Trigger", shortDisplayName = "LT")]
		public float leftTrigger; // 0x14
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Right Trigger", shortDisplayName = "RT")]
		public float rightTrigger; // 0x18
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DAC8F0-0x0000000184DAC900 
		public FourCC format { get; } // 0x0000000184DAC8F0-0x0000000184DAC900 
	
		// Constructors
		public GamepadState(params GamepadButton[] buttons); // 0x000000018B22E9DC-0x000000018B22EA84
	
		// Methods
		public GamepadState WithButton(GamepadButton button, bool value = true /* Metadata: 0x0232A72A */); // 0x000000018B22E998-0x000000018B22E9DC
	}

	public enum GamepadButton // TypeDefIndex: 47746
	{
		DpadUp = 0,
		DpadDown = 1,
		DpadLeft = 2,
		DpadRight = 3,
		North = 4,
		Y = 4,
		Triangle = 4,
		East = 5,
		B = 5,
		Circle = 5,
		South = 6,
		A = 6,
		Cross = 6,
		West = 7,
		X = 7,
		Square = 7,
		LeftStick = 8,
		RightStick = 9,
		LeftShoulder = 10,
		RightShoulder = 11,
		Start = 12,
		Select = 13,
		LeftTrigger = 32,
		RightTrigger = 33
	}

	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo // TypeDefIndex: 47747
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0232A74B
		public InputDeviceCommand baseCommand; // 0x00
		public float lowFrequencyMotorSpeed; // 0x08
		public float highFrequencyMotorSpeed; // 0x0C
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC5E0-0x0000000184DAC5F0 
		public FourCC typeStatic { get; } // 0x0000000184DAC5E0-0x0000000184DAC5F0 
	
		// Methods
		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency); // 0x0000000184DAC5B0-0x0000000184DAC5E0
	}

	internal interface ICustomDeviceReset // TypeDefIndex: 47748
	{
		// Methods
		void Reset();
	}

	internal interface IEventMerger // TypeDefIndex: 47749
	{
		// Methods
		bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr);
	}

	internal interface IEventPreProcessor // TypeDefIndex: 47750
	{
		// Methods
		bool PreProcessEvent(InputEventPtr currentEventPtr);
	}

	public interface IInputUpdateCallbackReceiver // TypeDefIndex: 47751
	{
		// Methods
		void OnUpdate();
	}

	public interface ITextInputReceiver // TypeDefIndex: 47752
	{
		// Methods
		void OnTextInput(char character);
		void OnIMECompositionChanged(IMECompositionString compositionString);
	}

	internal struct JoystickState : IInputStateTypeInfo // TypeDefIndex: 47754
	{
		// Fields
		[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new string[3] {"PrimaryTrigger", "PrimaryAction", "Submit" }, bit = 4)]
		public int buttons; // 0x00
		[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
		public Vector2 stick; // 0x04
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DACA70-0x0000000184DACA80 
		public FourCC format { get; } // 0x0000000184DACA70-0x0000000184DACA80 
	
		// Nested types
		public enum Button // TypeDefIndex: 47753
		{
			HatSwitchUp = 0,
			HatSwitchDown = 1,
			HatSwitchLeft = 2,
			HatSwitchRight = 3,
			Trigger = 4
		}
	}

	public struct KeyboardState : IInputStateTypeInfo // TypeDefIndex: 47756
	{
		// Fields
		private const int kSizeInBits = 123; // Metadata: 0x0232A751
		internal const int kSizeInBytes = 16; // Metadata: 0x0232A753
		[InputControl(name = "numLock", displayName = "Num Lock", layout = "Key", bit = 73)]
		[InputControl(name = "capsLock", displayName = "Caps Lock", layout = "Key", bit = 72)]
		[InputControl(name = "delete", displayName = "Delete", layout = "Key", bit = 71)]
		[InputControl(name = "p", displayName = "P", layout = "Key", bit = 30)]
		[InputControl(name = "o", displayName = "O", layout = "Key", bit = 29)]
		[InputControl(name = "printScreen", displayName = "Print Screen", layout = "Key", bit = 74)]
		[InputControl(name = "insert", displayName = "Insert", layout = "Key", bit = 70)]
		[InputControl(name = "home", displayName = "Home", layout = "Key", bit = 68)]
		[InputControl(name = "pageUp", displayName = "Page Up", layout = "Key", bit = 67)]
		[InputControl(name = "pageDown", displayName = "Page Down", layout = "Key", bit = 66)]
		[InputControl(name = "n", displayName = "N", layout = "Key", bit = 28)]
		[InputControl(name = "m", displayName = "M", layout = "Key", bit = 27)]
		[InputControl(name = "backspace", displayName = "Backspace", layout = "Key", bit = 65)]
		[InputControl(name = "l", displayName = "L", layout = "Key", bit = 26)]
		[InputControl(name = "contextMenu", displayName = "Context Menu", layout = "Key", usage = "Modifier", bit = 59)]
		[InputControl(name = "rightMeta", displayName = "Right System", layout = "Key", usage = "Modifier", bit = 58, aliases = new string[3] {"RightWindows", "RightApple", "RightCommand" })]
		[InputControl(name = "end", displayName = "End", layout = "Key", bit = 69)]
		[InputControl(name = "scrollLock", displayName = "Scroll Lock", layout = "Key", bit = 75)]
		[InputControl(name = "equals", displayName = "=", layout = "Key", bit = 14)]
		[InputControl(name = "r", displayName = "R", layout = "Key", bit = 32)]
		[InputControl(name = "u", displayName = "U", layout = "Key", bit = 35)]
		[InputControl(name = "9", displayName = "9", layout = "Key", bit = 49)]
		[InputControl(name = "8", displayName = "8", layout = "Key", bit = 48)]
		[InputControl(name = "7", displayName = "7", layout = "Key", bit = 47)]
		[InputControl(name = "6", displayName = "6", layout = "Key", bit = 46)]
		[InputControl(name = "5", displayName = "5", layout = "Key", bit = 45)]
		[InputControl(name = "4", displayName = "4", layout = "Key", bit = 44)]
		[InputControl(name = "3", displayName = "3", layout = "Key", bit = 43)]
		[InputControl(name = "2", displayName = "2", layout = "Key", bit = 42)]
		[InputControl(name = "1", displayName = "1", layout = "Key", bit = 41)]
		[InputControl(name = "z", displayName = "Z", layout = "Key", bit = 40)]
		[InputControl(name = "y", displayName = "Y", layout = "Key", bit = 39)]
		[InputControl(name = "t", displayName = "T", layout = "Key", bit = 34)]
		[InputControl(name = "s", displayName = "S", layout = "Key", bit = 33)]
		[InputControl(name = "numpadEnter", displayName = "Numpad Enter", layout = "Key", bit = 77)]
		[InputControl(name = "pause", displayName = "Pause/Break", layout = "Key", bit = 76)]
		[InputControl(name = "k", displayName = "K", layout = "Key", bit = 25)]
		[InputControl(name = "q", displayName = "Q", layout = "Key", bit = 31)]
		[InputControl(name = "leftMeta", displayName = "Left System", layout = "Key", usage = "Modifier", bit = 57, aliases = new string[3] {"LeftWindows", "LeftApple", "LeftCommand" })]
		[InputControl(name = "i", displayName = "I", layout = "Key", bit = 23)]
		[InputControl(name = "j", displayName = "J", layout = "Key", bit = 24)]
		[InputControl(name = "anyKey", displayName = "Any Key", layout = "AnyKey", bit = 1, sizeInBits = 123, synthetic = true)]
		[InputControl(name = "escape", displayName = "Escape", layout = "Key", usages = new string[2] {"Back", "Cancel" }, bit = 60)]
		[InputControl(name = "space", displayName = "Space", layout = "Key", bit = 1)]
		[InputControl(name = "enter", displayName = "Enter", layout = "Key", usage = "Submit", bit = 2)]
		[InputControl(name = "tab", displayName = "Tab", layout = "Key", bit = 3)]
		[InputControl(name = "backquote", displayName = "`", layout = "Key", bit = 4)]
		[InputControl(name = "x", displayName = "X", layout = "Key", bit = 38)]
		[InputControl(name = "quote", displayName = "\'", layout = "Key", bit = 5)]
		[InputControl(name = "comma", displayName = ",", layout = "Key", bit = 7)]
		[InputControl(name = "period", displayName = ".", layout = "Key", bit = 8)]
		[InputControl(name = "slash", displayName = "/", layout = "Key", bit = 9)]
		[InputControl(name = "backslash", displayName = "\\", layout = "Key", bit = 10)]
		[InputControl(name = "leftBracket", displayName = "[", layout = "Key", bit = 11)]
		[InputControl(name = "rightBracket", displayName = "]", layout = "Key", bit = 12)]
		[InputControl(name = "minus", displayName = "-", layout = "Key", bit = 13)]
		[InputControl(name = "semicolon", displayName = ";", layout = "Key", bit = 6)]
		[InputControl(name = "downArrow", displayName = "Down Arrow", layout = "Key", bit = 64)]
		[InputControl(name = "leftArrow", displayName = "Left Arrow", layout = "Key", bit = 61)]
		[InputControl(name = "rightArrow", displayName = "Right Arrow", layout = "Key", bit = 62)]
		[InputControl(name = "upArrow", displayName = "Up Arrow", layout = "Key", bit = 63)]
		[InputControl(name = "rightCtrl", displayName = "Right Control", layout = "Key", usage = "Modifier", bit = 56)]
		[InputControl(name = "leftCtrl", displayName = "Left Control", layout = "Key", usage = "Modifier", bit = 55)]
		[InputControl(name = "alt", displayName = "Alt", layout = "DiscreteButton", usage = "Modifier", bit = 53, sizeInBits = 2, synthetic = true, parameters = "minValue=1,maxValue=3,writeMode=1")]
		[InputControl(name = "rightAlt", displayName = "Right Alt", layout = "Key", usage = "Modifier", bit = 54, alias = "AltGr")]
		[InputControl(name = "leftAlt", displayName = "Left Alt", layout = "Key", usage = "Modifier", bit = 53)]
		[InputControl(name = "h", displayName = "H", layout = "Key", bit = 22)]
		[InputControl(name = "shift", displayName = "Shift", layout = "DiscreteButton", usage = "Modifier", bit = 51, sizeInBits = 2, synthetic = true, parameters = "minValue=1,maxValue=3,writeMode=1")]
		[InputControl(name = "rightShift", displayName = "Right Shift", layout = "Key", usage = "Modifier", bit = 52)]
		[InputControl(name = "g", displayName = "G", layout = "Key", bit = 21)]
		[InputControl(name = "f", displayName = "F", layout = "Key", bit = 20)]
		[InputControl(name = "e", displayName = "E", layout = "Key", bit = 19)]
		[InputControl(name = "d", displayName = "D", layout = "Key", bit = 18)]
		[InputControl(name = "w", displayName = "W", layout = "Key", bit = 37)]
		[InputControl(name = "c", displayName = "C", layout = "Key", bit = 17)]
		[InputControl(name = "b", displayName = "B", layout = "Key", bit = 16)]
		[InputControl(name = "a", displayName = "A", layout = "Key", bit = 15)]
		[InputControl(name = "ctrl", displayName = "Control", layout = "DiscreteButton", usage = "Modifier", bit = 55, sizeInBits = 2, synthetic = true, parameters = "minValue=1,maxValue=3,writeMode=1")]
		[InputControl(name = "v", displayName = "V", layout = "Key", bit = 36)]
		[InputControl(name = "numpad5", displayName = "Numpad 5", layout = "Key", bit = 89)]
		[InputControl(name = "leftShift", displayName = "Left Shift", layout = "Key", usage = "Modifier", bit = 51)]
		[InputControl(name = "OEM1", layout = "Key", bit = 106)]
		[InputControl(name = "OEM2", layout = "Key", bit = 107)]
		[InputControl(name = "OEM3", layout = "Key", bit = 108)]
		[InputControl(name = "OEM4", layout = "Key", bit = 109)]
		[InputControl(name = "f13", displayName = "F13", layout = "Key", bit = 112)]
		[InputControl(name = "f14", displayName = "F14", layout = "Key", bit = 113)]
		[InputControl(name = "f15", displayName = "F15", layout = "Key", bit = 114)]
		[InputControl(name = "f16", displayName = "F16", layout = "Key", bit = 115)]
		[InputControl(name = "f17", displayName = "F17", layout = "Key", bit = 116)]
		[InputControl(name = "f12", displayName = "F12", layout = "Key", bit = 105)]
		[InputControl(name = "f18", displayName = "F18", layout = "Key", bit = 117)]
		[InputControl(name = "f20", displayName = "F20", layout = "Key", bit = 119)]
		[InputControl(name = "f21", displayName = "F21", layout = "Key", bit = 120)]
		[InputControl(name = "0", displayName = "0", layout = "Key", bit = 50)]
		[InputControl(name = "f22", displayName = "F22", layout = "Key", bit = 121)]
		[InputControl(name = "f23", displayName = "F23", layout = "Key", bit = 122)]
		[InputControl(name = "f24", displayName = "F24", layout = "Key", bit = 123)]
		[InputControl(name = "IMESelected", layout = "Button", bit = 127, synthetic = true)]
		[InputControl(name = "numpadMultiply", displayName = "Numpad *", layout = "Key", bit = 79)]
		[InputControl(name = "numpadDivide", displayName = "Numpad /", layout = "Key", bit = 78)]
		[InputControl(name = "f19", displayName = "F19", layout = "Key", bit = 118)]
		[InputControl(name = "f11", displayName = "F11", layout = "Key", bit = 104)]
		[InputControl(name = "OEM5", layout = "Key", bit = 110)]
		[InputControl(name = "f9", displayName = "F9", layout = "Key", bit = 102)]
		[InputControl(name = "numpad6", displayName = "Numpad 6", layout = "Key", bit = 90)]
		[InputControl(name = "numpad7", displayName = "Numpad 7", layout = "Key", bit = 91)]
		[InputControl(name = "numpad8", displayName = "Numpad 8", layout = "Key", bit = 92)]
		[InputControl(name = "numpad9", displayName = "Numpad 9", layout = "Key", bit = 93)]
		[InputControl(name = "f10", displayName = "F10", layout = "Key", bit = 103)]
		[InputControl(name = "numpad2", displayName = "Numpad 2", layout = "Key", bit = 86)]
		[InputControl(name = "numpad1", displayName = "Numpad 1", layout = "Key", bit = 85)]
		[InputControl(name = "numpad0", displayName = "Numpad 0", layout = "Key", bit = 84)]
		[InputControl(name = "f1", displayName = "F1", layout = "Key", bit = 94)]
		[InputControl(name = "f2", displayName = "F2", layout = "Key", bit = 95)]
		[InputControl(name = "numpad3", displayName = "Numpad 3", layout = "Key", bit = 87)]
		[InputControl(name = "numpadPeriod", displayName = "Numpad .", layout = "Key", bit = 82)]
		[InputControl(name = "f8", displayName = "F8", layout = "Key", bit = 101)]
		[InputControl(name = "f7", displayName = "F7", layout = "Key", bit = 100)]
		[InputControl(name = "numpadEquals", displayName = "Numpad =", layout = "Key", bit = 83)]
		[InputControl(name = "f6", displayName = "F6", layout = "Key", bit = 99)]
		[InputControl(name = "numpadPlus", displayName = "Numpad +", layout = "Key", bit = 80)]
		[InputControl(name = "numpad4", displayName = "Numpad 4", layout = "Key", bit = 88)]
		[InputControl(name = "f5", displayName = "F5", layout = "Key", bit = 98)]
		[InputControl(name = "f4", displayName = "F4", layout = "Key", bit = 97)]
		[InputControl(name = "f3", displayName = "F3", layout = "Key", bit = 96)]
		[InputControl(name = "numpadMinus", displayName = "Numpad -", layout = "Key", bit = 81)]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte keys[0]; // 0x00
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DACA80-0x0000000184DACA90 
		public FourCC format { get; } // 0x0000000184DACA80-0x0000000184DACA90 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _keys_e__FixedBuffer // TypeDefIndex: 47755
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe KeyboardState(params UnityEngine.InputSystem.Key[] pressedKeys); // 0x000000018B2356D4-0x000000018B2356E4
		public unsafe KeyboardState(bool IMESelected, params UnityEngine.InputSystem.Key[] pressedKeys); // 0x000000018B2356E4-0x000000018B2357B8
	
		// Methods
		public void Set(UnityEngine.InputSystem.Key key, bool state); // 0x0000000185396D64-0x0000000185396D6C
		internal bool Get(UnityEngine.InputSystem.Key key); // 0x00000001830D1A60-0x00000001830D1A90
		public void Press(UnityEngine.InputSystem.Key key); // 0x000000018B2356B0-0x000000018B2356C8
		public void Release(UnityEngine.InputSystem.Key key); // 0x000000018B2356C8-0x000000018B2356D4
	}

	public struct MouseState : IInputStateTypeInfo // TypeDefIndex: 47757
	{
		// Fields
		[InputControl(usage = "Point", dontReset = true)]
		public Vector2 position; // 0x00
		[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
		public Vector2 delta; // 0x08
		[InputControl(displayName = "Scroll", layout = "Delta")]
		[InputControl(name = "scroll/y", aliases = new string[1] {"vertical" }, usage = "ScrollVertical", displayName = "Up/Down", shortDisplayName = "Wheel")]
		[InputControl(name = "scroll/x", aliases = new string[1] {"horizontal" }, usage = "ScrollHorizontal", displayName = "Left/Right")]
		public Vector2 scroll; // 0x10
		[InputControl(name = "press", useStateFrom = "leftButton", synthetic = true, usages = new string[0])]
		[InputControl(name = "leftButton", layout = "Button", bit = 0, usage = "PrimaryAction", displayName = "Left Button", shortDisplayName = "LMB")]
		[InputControl(name = "rightButton", layout = "Button", bit = 1, usage = "SecondaryAction", displayName = "Right Button", shortDisplayName = "RMB")]
		[InputControl(name = "middleButton", layout = "Button", bit = 2, displayName = "Middle Button", shortDisplayName = "MMB")]
		[InputControl(name = "forwardButton", layout = "Button", bit = 3, usage = "Forward", displayName = "Forward")]
		[InputControl(name = "backButton", layout = "Button", bit = 4, usage = "Back", displayName = "Back")]
		[InputControl(name = "pressure", layout = "Axis", usage = "Pressure", offset = 4294967294, format = "FLT", sizeInBits = 32)]
		[InputControl(name = "radius", layout = "Vector2", usage = "Radius", offset = 4294967294, format = "VEC2", sizeInBits = 64)]
		[InputControl(name = "pointerId", layout = "Digital", format = "BIT", sizeInBits = 1, offset = 4294967294)]
		public ushort buttons; // 0x18
		[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
		public ushort displayIndex; // 0x1A
		[InputControl(name = "clickCount", layout = "Integer", displayName = "Click Count", synthetic = true)]
		public ushort clickCount; // 0x1C
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DACAA0-0x0000000184DACAB0 
		public FourCC format { get; } // 0x0000000184DACAA0-0x0000000184DACAB0 
	
		// Methods
		public MouseState WithButton(MouseButton button, bool state = true /* Metadata: 0x0232A754 */); // 0x000000018B2357B8-0x000000018B2357F4
	}

	public enum MouseButton // TypeDefIndex: 47758
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		Forward = 3,
		Back = 4
	}

	public struct PenState : IInputStateTypeInfo // TypeDefIndex: 47759
	{
		// Fields
		[InputControl(usage = "Point", dontReset = true)]
		public Vector2 position; // 0x00
		[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
		public Vector2 delta; // 0x08
		[InputControl(layout = "Vector2", displayName = "Tilt", usage = "Tilt")]
		public Vector2 tilt; // 0x10
		[InputControl(layout = "Analog", usage = "Pressure", defaultState = 0f)]
		public float pressure; // 0x18
		[InputControl(layout = "Axis", displayName = "Twist", usage = "Twist")]
		public float twist; // 0x1C
		[InputControl(name = "barrel4", displayName = "Barrel Button #4", layout = "Button", bit = 6, alias = "barrelFourth")]
		[InputControl(name = "radius", layout = "Vector2", format = "VEC2", sizeInBits = 64, usage = "Radius", offset = 4294967294)]
		[InputControl(name = "pointerId", layout = "Digital", format = "UINT", sizeInBits = 32, offset = 4294967294)]
		[InputControl(name = "barrel1", displayName = "Barrel Button #1", layout = "Button", bit = 2, alias = "barrelFirst", usage = "SecondaryAction")]
		[InputControl(name = "inRange", displayName = "In Range?", layout = "Button", bit = 4, synthetic = true)]
		[InputControl(name = "eraser", displayName = "Eraser", layout = "Button", bit = 1)]
		[InputControl(name = "press", useStateFrom = "tip", synthetic = true, usages = new string[0])]
		[InputControl(name = "tip", displayName = "Tip", layout = "Button", bit = 0, usage = "PrimaryAction")]
		[InputControl(name = "barrel2", displayName = "Barrel Button #2", layout = "Button", bit = 3, alias = "barrelSecond")]
		[InputControl(name = "barrel3", displayName = "Barrel Button #3", layout = "Button", bit = 5, alias = "barrelThird")]
		public ushort buttons; // 0x20
		[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
		private ushort displayIndex; // 0x22
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DACAB0-0x0000000184DACAC0 
		public FourCC format { get; } // 0x0000000184DACAB0-0x0000000184DACAC0 
	
		// Methods
		public PenState WithButton(PenButton button, bool state = true /* Metadata: 0x0232A75A */); // 0x000000018B2358F8-0x000000018B23593C
	}

	internal struct PointerState : IInputStateTypeInfo // TypeDefIndex: 47760
	{
		// Fields
		private uint pointerId; // 0x00
		[InputControl(layout = "Vector2", displayName = "Position", usage = "Point", dontReset = true)]
		public Vector2 position; // 0x04
		[InputControl(layout = "Delta", displayName = "Delta", usage = "Secondary2DMotion")]
		public Vector2 delta; // 0x0C
		[InputControl(layout = "Analog", displayName = "Pressure", usage = "Pressure", defaultState = 1f)]
		public float pressure; // 0x14
		[InputControl(layout = "Vector2", displayName = "Radius", usage = "Radius")]
		public Vector2 radius; // 0x18
		[InputControl(name = "press", displayName = "Press", layout = "Button", format = "BIT", bit = 0)]
		public ushort buttons; // 0x20
		[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
		public ushort displayIndex; // 0x22
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DACAC0-0x0000000184DACAD0 
		public FourCC format { get; } // 0x0000000184DACAC0-0x0000000184DACAD0 
	}

	internal struct AccelerometerState : IInputStateTypeInfo // TypeDefIndex: 47761
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DAC4A0-0x0000000184DAC4B0 
		public FourCC format { get; } // 0x0000000184DAC4A0-0x0000000184DAC4B0 
	}

	internal struct GyroscopeState : IInputStateTypeInfo // TypeDefIndex: 47762
	{
		// Fields
		[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = true)]
		public Vector3 angularVelocity; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DAC910-0x0000000184DAC920 
		public FourCC format { get; } // 0x0000000184DAC910-0x0000000184DAC920 
	}

	internal struct GravityState : IInputStateTypeInfo // TypeDefIndex: 47763
	{
		// Fields
		[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = true)]
		public Vector3 gravity; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DAC900-0x0000000184DAC910 
		public FourCC format { get; } // 0x0000000184DAC900-0x0000000184DAC910 
	}

	internal struct AttitudeState : IInputStateTypeInfo // TypeDefIndex: 47764
	{
		// Fields
		[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = true)]
		public Quaternion attitude; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DAC510-0x0000000184DAC520 
		public FourCC format { get; } // 0x0000000184DAC510-0x0000000184DAC520 
	}

	internal struct LinearAccelerationState : IInputStateTypeInfo // TypeDefIndex: 47765
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x0000000184DACA90-0x0000000184DACAA0 
		public FourCC format { get; } // 0x0000000184DACA90-0x0000000184DACAA0 
	}

	[Flags]
	internal enum TouchFlags : byte // TypeDefIndex: 47766
	{
		IndirectTouch = 1,
		PrimaryTouch = 8,
		TapPress = 16,
		TapRelease = 32,
		OrphanedPrimaryTouch = 64,
		BeganInSameFrame = 128
	}

	public struct TouchState : IInputStateTypeInfo // TypeDefIndex: 47767
	{
		// Fields
		internal const int kSizeInBytes = 56; // Metadata: 0x0232A761
		[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = true, dontReset = true)]
		public int touchId; // 0x00
		[InputControl(displayName = "Position", dontReset = true)]
		public Vector2 position; // 0x04
		[InputControl(displayName = "Delta", layout = "Delta")]
		public Vector2 delta; // 0x0C
		[InputControl(displayName = "Pressure", layout = "Axis")]
		public float pressure; // 0x14
		[InputControl(displayName = "Radius")]
		public Vector2 radius; // 0x18
		[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = true)]
		[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
		public byte phaseId; // 0x20
		[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
		public byte tapCount; // 0x21
		[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
		public byte displayIndex; // 0x22
		[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4)]
		[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0, synthetic = true)]
		public byte flags; // 0x23
		internal uint updateStepCount; // 0x24
		[InputControl(displayName = "Start Time", layout = "Double", synthetic = true)]
		public double startTime; // 0x28
		[InputControl(displayName = "Start Position", synthetic = true)]
		public Vector2 startPosition; // 0x30
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DACDF0-0x0000000184DACE00 
		public UnityEngine.InputSystem.TouchPhase phase { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public bool isNoneEndedOrCanceled { get; } // 0x000000018B237C54-0x000000018B237C6C 
		public bool isInProgress { get; } // 0x000000018B237C34-0x000000018B237C4C 
		public bool isPrimaryTouch { get; set; } // 0x000000018B237C74-0x000000018B237C7C 0x000000018B237CF8-0x000000018B237D1C
		internal bool isOrphanedPrimaryTouch { get; set; } // 0x000000018B237C6C-0x000000018B237C74 0x000000018B237CD4-0x000000018B237CF8
		public bool isIndirectTouch { get; set; } // 0x000000018B237C4C-0x000000018B237C54 0x000000018B237CB0-0x000000018B237CD4
		public bool isTap { get; set; } // 0x000000018B237C7C-0x000000018B237C84 0x000000018B237D1C-0x000000018B237D40
		internal bool isTapPress { get; set; } // 0x000000018B237C7C-0x000000018B237C84 0x000000018B237D1C-0x000000018B237D40
		internal bool isTapRelease { get; set; } // 0x000000018B237C84-0x000000018B237C8C 0x000000018B237D40-0x000000018B237D64
		internal bool beganInSameFrame { get; set; } // 0x000000018B237C2C-0x000000018B237C34 0x000000018B237C8C-0x000000018B237CB0
		public FourCC format { get; } // 0x0000000184DACDF0-0x0000000184DACE00 
	
		// Methods
		public override string ToString(); // 0x000000018B2379EC-0x000000018B237C2C
	}

	internal struct TouchscreenState : IInputStateTypeInfo // TypeDefIndex: 47770
	{
		// Fields
		public const int MaxTouches = 10; // Metadata: 0x0232A762
		[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
		[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[0])]
		[InputControl(name = "displayIndex", useStateFrom = "primaryTouch/displayIndex", format = "BYTE")]
		[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
		[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
		[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
		[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
		[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte primaryTouchData[0]; // 0x00
		internal const int kTouchDataOffset = 56; // Metadata: 0x0232A763
		[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte touchData[0]; // 0x38
	
		// Properties
		public static FourCC Format { get; } // 0x0000000184DACE30-0x0000000184DACE40 
		public unsafe TouchState* primaryTouch { get; } // 0x000000018464E630-0x000000018464E640 
		public unsafe TouchState* touches { get; } // 0x0000000184DACE40-0x0000000184DACE50 
		public FourCC format { get; } // 0x0000000184DACE30-0x0000000184DACE40 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _primaryTouchData_e__FixedBuffer // TypeDefIndex: 47768
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _touchData_e__FixedBuffer // TypeDefIndex: 47769
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ActionEvent : IInputEventTypeInfo // TypeDefIndex: 47772
	{
		// Fields
		public InputEvent baseEvent; // 0x00
		private ushort m_ControlIndex; // 0x14
		private ushort m_BindingIndex; // 0x16
		private ushort m_InteractionIndex; // 0x18
		private byte m_StateIndex; // 0x1A
		private byte m_Phase; // 0x1B
		private double m_StartTime; // 0x1C
		public unsafe fixed /* 0x00000000-0x00000000 */ byte m_ValueData[0]; // 0x24
	
		// Properties
		public static FourCC Type { get; } // 0x0000000184DAC4C0-0x0000000184DAC4D0 
		public double startTime { get; set; } // 0x0000000184DAC4D0-0x0000000184DAC4E0 0x0000000184DAC500-0x0000000184DAC510
		public InputActionPhase phase { get; set; } // 0x0000000184D895D0-0x0000000184D895E0 0x0000000184D89600-0x0000000184D89610
		public unsafe byte* valueData { get; } // 0x0000000184DAC4E0-0x0000000184DAC4F0 
		public int valueSizeInBytes { get; } // 0x0000000184DAC4F0-0x0000000184DAC500 
		public int stateIndex { get; set; } // 0x00000001815AF940-0x00000001815AF950 0x000000018B22AAE0-0x000000018B22AB4C
		public int controlIndex { get; set; } // 0x0000000184D96D00-0x0000000184D96D10 0x000000018B22A9F8-0x000000018B22AA64
		public int bindingIndex { get; set; } // 0x0000000184D993B0-0x0000000184D993C0 0x000000018B22A98C-0x000000018B22A9F8
		public int interactionIndex { get; set; } // 0x000000018B22A974-0x000000018B22A98C 0x000000018B22AA64-0x000000018B22AAE0
		public FourCC typeStatic { get; } // 0x0000000184DAC4C0-0x0000000184DAC4D0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_ValueData_e__FixedBuffer // TypeDefIndex: 47771
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x000000018464E630-0x000000018464E640
		public static int GetEventSizeWithValueSize(int valueSizeInBytes); // 0x0000000184DAC4B0-0x0000000184DAC4C0
		public static unsafe ActionEvent* From(InputEventPtr ptr); // 0x000000018B22A838-0x000000018B22A974
	}

	public struct DeltaStateEvent : IInputEventTypeInfo // TypeDefIndex: 47774
	{
		// Fields
		public const int Type = 1145852993; // Metadata: 0x0232A765
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		public uint stateOffset; // 0x18
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x1C
	
		// Properties
		public uint deltaStateSizeInBytes { get; } // 0x0000000184DAC520-0x0000000184DAC530 
		public unsafe void* deltaState { get; } // 0x0000000184DAC530-0x0000000184DAC540 
		public FourCC typeStatic { get; } // 0x0000000184DAC540-0x0000000184DAC550 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 47773
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x000000018464E630-0x000000018464E640
		public static unsafe DeltaStateEvent* From(InputEventPtr ptr); // 0x000000018B22AE10-0x000000018B22AF4C
		internal static unsafe DeltaStateEvent* FromUnchecked(InputEventPtr ptr); // 0x000000018464E630-0x000000018464E640
		public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0232A764 */); // 0x000000018B22AB4C-0x000000018B22AE10
	}

	public struct DeviceConfigurationEvent : IInputEventTypeInfo // TypeDefIndex: 47775
	{
		// Fields
		public const int Type = 1145259591; // Metadata: 0x0232A76A
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get; } // 0x0000000184DAC550-0x0000000184DAC560 
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x000000018464E630-0x000000018464E640
		public static DeviceConfigurationEvent Create(int deviceId, double time); // 0x000000018B22AF4C-0x000000018B22AFA4
	}

	public struct DeviceRemoveEvent : IInputEventTypeInfo // TypeDefIndex: 47776
	{
		// Fields
		public const int Type = 1146242381; // Metadata: 0x0232A777
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get; } // 0x0000000184DAC560-0x0000000184DAC570 
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x000000018464E630-0x000000018464E640
		public static DeviceRemoveEvent Create(int deviceId, double time = -1 /* Metadata: 0x0232A76F */); // 0x000000018B22AFA4-0x000000018B22AFFC
	}

	public struct DeviceResetEvent : IInputEventTypeInfo // TypeDefIndex: 47777
	{
		// Fields
		public const int Type = 1146245972; // Metadata: 0x0232A785
		public InputEvent baseEvent; // 0x00
		public bool hardReset; // 0x08
	
		// Properties
		public FourCC typeStatic { get; } // 0x0000000184DAC570-0x0000000184DAC580 
	
		// Methods
		public static DeviceResetEvent Create(int deviceId, bool hardReset = false /* Metadata: 0x0232A77C */, double time = -1 /* Metadata: 0x0232A77D */); // 0x000000018B22AFFC-0x000000018B22B064
	}

	public interface IInputEventTypeInfo // TypeDefIndex: 47778
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct IMECompositionEvent : IInputEventTypeInfo // TypeDefIndex: 47779
	{
		// Fields
		internal const int kIMECharBufferSize = 64; // Metadata: 0x0232A78A
		public const int Type = 1229800787; // Metadata: 0x0232A78C
		public InputEvent baseEvent; // 0x00
		public IMECompositionString compositionString; // 0x14
	
		// Properties
		public FourCC typeStatic { get; } // 0x0000000184DAC9D0-0x0000000184DAC9E0 
	
		// Methods
		public static IMECompositionEvent Create(int deviceId, string compositionString, double time); // 0x000000018B231A70-0x000000018B231B70
	}

	public struct IMECompositionString : IEnumerable<char> // TypeDefIndex: 47782
	{
		// Fields
		private int size; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ char buffer[0]; // 0x04
	
		// Properties
		public int Count { get; } // 0x0000000182B77620-0x0000000182B77630 
		public char this[int index] { get => default; } // 0x000000018B231D30-0x000000018B231DA0 
	
		// Nested types
		internal struct Enumerator : IEnumerator<char> // TypeDefIndex: 47780
		{
			// Fields
			private IMECompositionString m_CompositionString; // 0x00
			private char m_CurrentCharacter; // 0x84
			private int m_CurrentIndex; // 0x88
	
			// Properties
			public char Current { get; } // 0x0000000184D9CCF0-0x0000000184D9CD00 
			object IEnumerator.Current { get; } // 0x000000018B22D77C-0x000000018B22D7C4 
	
			// Constructors
			public Enumerator(IMECompositionString compositionString); // 0x0000000184DAC890-0x0000000184DAC8F0
	
			// Methods
			public bool MoveNext(); // 0x000000018B22D6AC-0x000000018B22D6D4
			public void Reset(); // 0x0000000184DAB0B0-0x0000000184DAB0C0
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 47781
		{
			// Fields
			public char FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe IMECompositionString(string characters); // 0x000000018B231CC4-0x000000018B231D30
	
		// Methods
		public override string ToString(); // 0x000000018B231CA0-0x000000018B231CC4
		public IEnumerator<char> GetEnumerator(); // 0x000000018B231B70-0x000000018B231C98
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B231C98-0x000000018B231CA0
	}

	public struct InputEvent // TypeDefIndex: 47783
	{
		// Fields
		private const uint kHandledMask = 2147483648; // Metadata: 0x0232A799
		private const uint kIdMask = 2147483647; // Metadata: 0x0232A79E
		internal const int kBaseEventSize = 20; // Metadata: 0x0232A7A3
		public const int InvalidEventId = 0; // Metadata: 0x0232A7A4
		internal const int kAlignment = 4; // Metadata: 0x0232A7A5
		private NativeInputEvent m_Event; // 0x00
	
		// Properties
		public FourCC type { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public uint sizeInBytes { get; set; } // 0x0000000184D87600-0x0000000184D87610 0x000000018381FC50-0x000000018381FC70
		public int eventId { get; set; } // 0x0000000184DACA50-0x0000000184DACA60 0x0000000184DACA60-0x0000000184DACA70
		public int deviceId { get; set; } // 0x0000000184D875F0-0x0000000184D87600 0x0000000184DA8A20-0x0000000184DA8A30
		public double time { get; set; } // 0x000000018B23566C-0x000000018B2356B0 0x0000000183820740-0x00000001838207A0
		internal double internalTime { get; set; } // 0x0000000184D9C270-0x0000000184D9C280 0x0000000184D9E9A0-0x0000000184D9E9B0
		public bool handled { get; set; } // 0x000000018425D410-0x000000018425D420 0x000000018420E3A0-0x000000018420E3C0
	
		// Constructors
		public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1 /* Metadata: 0x0232A791 */); // 0x0000000184033220-0x0000000184033280
	
		// Methods
		public override string ToString(); // 0x000000018B2354A8-0x000000018B23566C
		internal static unsafe InputEvent* GetNextInMemory(InputEvent* currentPtr); // 0x00000001830CD860-0x00000001830CD8B0
		internal static unsafe InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer); // 0x000000018B2353A8-0x000000018B2354A8
		public static unsafe bool Equals(InputEvent* first, InputEvent* second); // 0x000000018B23536C-0x000000018B2353A8
	}

	public struct InputEventBuffer : IEnumerable<InputEventPtr>, IDisposable, ICloneable // TypeDefIndex: 47785
	{
		// Fields
		public const long BufferSizeUnknown = -1; // Metadata: 0x0232A7B0
		private NativeArray<byte> m_Buffer; // 0x00
		private long m_SizeInBytes; // 0x10
		private int m_EventCount; // 0x18
		private bool m_WeOwnTheBuffer; // 0x1C
	
		// Properties
		public int eventCount { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public long sizeInBytes { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public long capacityInBytes { get; } // 0x0000000184D57490-0x0000000184D574D0 
		public NativeArray<byte> data { get; } // 0x0000000182B77630-0x0000000182B77640 
		public InputEventPtr bufferPtr { get; } // 0x000000018B232480-0x000000018B2324B0 
	
		// Nested types
		private struct Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 47784
		{
			// Fields
			private readonly unsafe InputEvent* m_Buffer; // 0x00
			private readonly int m_EventCount; // 0x08
			private unsafe InputEvent* m_CurrentEvent; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public InputEventPtr Current { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			object IEnumerator.Current { get; } // 0x000000018B22D6D4-0x000000018B22D71C 
	
			// Constructors
			public unsafe Enumerator(InputEventBuffer buffer); // 0x000000018B22D7F0-0x000000018B22D828
	
			// Methods
			public bool MoveNext(); // 0x000000018B22D65C-0x000000018B22D6AC
			public void Reset(); // 0x0000000184D8FA80-0x0000000184D8FA90
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1 /* Metadata: 0x0232A7A6 */, int capacityInBytes = -1 /* Metadata: 0x0232A7A7 */); // 0x00000001830CEA20-0x00000001830CEAB0
		public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1 /* Metadata: 0x0232A7A8 */, bool transferNativeArrayOwnership = false /* Metadata: 0x0232A7A9 */); // 0x000000018B232348-0x000000018B232480
	
		// Methods
		public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048 /* Metadata: 0x0232A7AA */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A7AC */); // 0x000000018B232088-0x000000018B23211C
		public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048 /* Metadata: 0x0232A7AD */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A7AF */); // 0x000000018B231E20-0x000000018B232088
		public unsafe bool Contains(InputEvent* eventPtr); // 0x000000018B2321E0-0x000000018B232210
		public void Reset(); // 0x00000001830A1D60-0x00000001830A1D80
		internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer); // 0x00000001830CE4A0-0x00000001830CE510
		public IEnumerator<InputEventPtr> GetEnumerator(); // 0x000000018B232260-0x000000018B2322E0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B2322E0-0x000000018B2322E8
		public void Dispose(); // 0x000000018B232210-0x000000018B232260
		public InputEventBuffer Clone(); // 0x000000018B23211C-0x000000018B2321E0
		object ICloneable.Clone(); // 0x000000018B2322E8-0x000000018B232348
	}

	public struct InputEventListener : IObservable<InputEventPtr> // TypeDefIndex: 47788
	{
		// Fields
		internal static ObserverState s_ObserverState; // 0x00
	
		// Nested types
		internal class ObserverState // TypeDefIndex: 47786
		{
			// Fields
			public InlinedArray<IObserver<InputEventPtr>> observers; // 0x10
			public Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28
	
			// Constructors
			public ObserverState(); // 0x000000018B23587C-0x000000018B2358F8
	
			// Methods
			[CompilerGenerated]
			private void _.ctor_b__2_0(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018B2357F4-0x000000018B23587C
		}
	
		private class DisposableObserver : IDisposable // TypeDefIndex: 47787
		{
			// Fields
			public IObserver<InputEventPtr> observer; // 0x10
	
			// Constructors
			public DisposableObserver(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Dispose(); // 0x000000018B22B064-0x000000018B22B18C
		}
	
		// Methods
		public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback); // 0x000000018B23262C-0x000000018B232798
		public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback); // 0x000000018B232798-0x000000018B232904
		public IDisposable Subscribe(IObserver<InputEventPtr> observer); // 0x000000018B2324B0-0x000000018B23262C
	}

	public struct InputEventPtr : IEquatable<InputEventPtr> // TypeDefIndex: 47789
	{
		// Fields
		private readonly unsafe InputEvent* m_EventPtr; // 0x00
	
		// Properties
		public bool valid { get; } // 0x00000001830CFC40-0x00000001830CFC50 
		public bool handled { get; set; } // 0x000000018B232A0C-0x000000018B232A2C 0x000000018B232CA8-0x000000018B232D18
		public int id { get; set; } // 0x000000018B232A2C-0x000000018B232A40 0x000000018B232D18-0x000000018B232D90
		public FourCC type { get; } // 0x00000001830CF8C0-0x00000001830CF8D0 
		public uint sizeInBytes { get; } // 0x0000000183FB4800-0x0000000183FB4820 
		public int deviceId { get; set; } // 0x000000018B2329F8-0x000000018B232A0C 0x000000018B232C38-0x000000018B232CA8
		public double time { get; set; } // 0x000000018B232C18-0x000000018B232C38 0x000000018B232E00-0x000000018B232E70
		internal double internalTime { get; set; } // 0x0000000183D44B10-0x0000000183D44B30 0x000000018B232D90-0x000000018B232E00
		public unsafe InputEvent* data { get; } // 0x0000000182B76770-0x0000000182B76780 
		internal FourCC stateFormat { get; } // 0x000000018400B620-0x000000018400B6A0 
		internal uint stateSizeInBytes { get; } // 0x000000018B232B10-0x000000018B232C18 
		internal uint stateOffset { get; } // 0x000000018B232A40-0x000000018B232B10 
	
		// Constructors
		public unsafe InputEventPtr(InputEvent* eventPtr); // 0x0000000184D88B60-0x0000000184D88B70
	
		// Methods
		public bool IsA<TOtherEvent>()
			where TOtherEvent : struct, IInputEventTypeInfo;
		public InputEventPtr Next(); // 0x000000018B232980-0x000000018B2329A0
		public override string ToString(); // 0x000000018B2329A0-0x000000018B2329F8
		public unsafe InputEvent* ToPointer(); // 0x0000000182B76770-0x0000000182B76780
		public bool Equals(InputEventPtr other); // 0x000000018B232968-0x000000018B232980
		public override bool Equals(object obj); // 0x000000018B232904-0x000000018B232968
		public override int GetHashCode(); // 0x0000000182B77620-0x0000000182B77630
		public static bool operator ==(InputEventPtr left, InputEventPtr right); // 0x0000000182FB1840-0x0000000182FB1850
		public static bool operator !=(InputEventPtr left, InputEventPtr right); // 0x0000000182F019D0-0x0000000182F01A10
		public static unsafe implicit operator InputEventPtr(InputEvent* eventPtr); // 0x000000018464E630-0x000000018464E640
		public static unsafe InputEventPtr From(InputEvent* eventPtr); // 0x000000018464E630-0x000000018464E640
		public static unsafe implicit operator InputEvent*(InputEventPtr eventPtr); // 0x000000018464E630-0x000000018464E640
		public static unsafe InputEvent* FromInputEventPtr(InputEventPtr eventPtr); // 0x000000018464E630-0x000000018464E640
	}

	internal struct InputEventStream // TypeDefIndex: 47790
	{
		// Fields
		private InputEventBuffer m_NativeBuffer; // 0x00
		private unsafe InputEvent* m_CurrentNativeEventReadPtr; // 0x20
		private unsafe InputEvent* m_CurrentNativeEventWritePtr; // 0x28
		private int m_RemainingNativeEventCount; // 0x30
		private readonly int m_MaxAppendedEvents; // 0x34
		private InputEventBuffer m_AppendBuffer; // 0x38
		private unsafe InputEvent* m_CurrentAppendEventReadPtr; // 0x58
		private unsafe InputEvent* m_CurrentAppendEventWritePtr; // 0x60
		private int m_RemainingAppendEventCount; // 0x68
		private int m_NumEventsRetainedInBuffer; // 0x6C
		private bool m_IsOpen; // 0x70
	
		// Properties
		public bool isOpen { get; } // 0x0000000184D86A50-0x0000000184D86A60 
		public int remainingEventCount { get; } // 0x0000000184DACA20-0x0000000184DACA30 
		public int numEventsRetainedInBuffer { get; } // 0x0000000184D86B50-0x0000000184D86B60 
		public unsafe InputEvent* currentEventPtr { get; } // 0x00000001830CE580-0x00000001830CE6A0 
		public uint numBytesRetainedInBuffer { get; } // 0x000000018B23301C-0x000000018B233050 
	
		// Constructors
		public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents); // 0x0000000183F51800-0x0000000183F51850
	
		// Methods
		public void Close(ref InputEventBuffer eventBuffer); // 0x00000001830A1610-0x00000001830A1670
		public void CleanUpAfterException(); // 0x000000018B232E70-0x000000018B232EC4
		public unsafe void Write(InputEvent* eventPtr); // 0x000000018B232EC4-0x000000018B23301C
		public unsafe InputEvent* Advance(bool leaveEventInBuffer); // 0x00000001830CE510-0x00000001830CE580
		public unsafe InputEvent* Peek(); // 0x00000001830CD8E0-0x00000001830CD930
	}

	[Serializable]
	public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr> // TypeDefIndex: 47797
	{
		// Fields
		private const int kDefaultBufferSize = 1048576; // Metadata: 0x0232A7F2
		private static readonly ProfilerMarker k_InputEvenTraceMarker; // 0x00
		[NonSerialized]
		private int m_ChangeCounter; // 0x10
		[NonSerialized]
		private bool m_Enabled; // 0x14
		[NonSerialized]
		private Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> m_OnFilterEvent; // 0x18
		[SerializeField]
		private int m_DeviceId; // 0x20
		[NonSerialized]
		private CallbackArray<Action<InputEventPtr>> m_EventListeners; // 0x28
		[SerializeField]
		private long m_EventBufferSize; // 0x78
		[SerializeField]
		private long m_MaxEventBufferSize; // 0x80
		[SerializeField]
		private long m_GrowIncrementSize; // 0x88
		[SerializeField]
		private long m_EventCount; // 0x90
		[SerializeField]
		private long m_EventSizeInBytes; // 0x98
		[SerializeField]
		private ulong m_EventBufferStorage; // 0xA0
		[SerializeField]
		private ulong m_EventBufferHeadStorage; // 0xA8
		[SerializeField]
		private ulong m_EventBufferTailStorage; // 0xB0
		[SerializeField]
		private bool m_HasWrapped; // 0xB8
		[SerializeField]
		private bool m_RecordFrameMarkers; // 0xB9
		[SerializeField]
		private DeviceInfo[] m_DeviceInfos; // 0xC0
		private static int kFileVersion; // 0x08
	
		// Properties
		public static FourCC FrameMarkerEvent { get; } // 0x0000000184DACA30-0x0000000184DACA40 
		public int deviceId { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public bool enabled { get; } // 0x0000000184D8EE50-0x0000000184D8EE60 
		public bool recordFrameMarkers { get; set; } // 0x0000000184D89310-0x0000000184D89320 0x000000018B235284-0x000000018B23536C
		public long eventCount { get; } // 0x0000000184D86220-0x0000000184D86230 
		public long totalEventSizeInBytes { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		public long allocatedSizeInBytes { get; } // 0x000000018B2351C8-0x000000018B2351DC 
		public long maxSizeInBytes { get; } // 0x0000000184D86260-0x0000000184D86270 
		public ReadOnlyArray<DeviceInfo> deviceInfos { get; } // 0x000000018B2351DC-0x000000018B235238 
		public Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> onFilterEvent { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		private unsafe byte* m_EventBuffer { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000184D927B0-0x0000000184D927C0
		private unsafe byte* m_EventBufferHead { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D862F0-0x0000000184D86300
		private unsafe byte* m_EventBufferTail { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D92630-0x0000000184D92640
		private static FourCC kFileFormat { get; } // 0x0000000184DACA40-0x0000000184DACA50 
	
		// Events
		public event Action<InputEventPtr> onEvent {
			add; // 0x000000018B23517C-0x000000018B2351C8
			remove; // 0x000000018B235238-0x000000018B235284
		}
	
		// Nested types
		private class Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 47791
		{
			// Fields
			private InputEventTrace m_Trace; // 0x10
			private int m_ChangeCounter; // 0x18
			internal InputEventPtr m_Current; // 0x20
	
			// Properties
			public InputEventPtr Current { get; } // 0x0000000184D862C0-0x0000000184D862D0 
			object IEnumerator.Current { get; } // 0x000000018B23CDB0-0x000000018B23CDF8 
	
			// Constructors
			public Enumerator(InputEventTrace trace); // 0x000000018B23CE50-0x000000018B23CE80
	
			// Methods
			public void Dispose(); // 0x000000018B23CC88-0x000000018B23CCAC
			public bool MoveNext(); // 0x000000018B23CCAC-0x000000018B23CD8C
			public void Reset(); // 0x000000018B23CD8C-0x000000018B23CDB0
		}
	
		[Flags]
		private enum FileFlags // TypeDefIndex: 47792
		{
			FixedUpdate = 1
		}
	
		public class ReplayController : IDisposable // TypeDefIndex: 47795
		{
			// Fields
			[CompilerGenerated]
			private bool _finished_k__BackingField; // 0x10
			[CompilerGenerated]
			private bool _paused_k__BackingField; // 0x11
			[CompilerGenerated]
			private int _position_k__BackingField; // 0x14
			private InputEventTrace m_EventTrace; // 0x18
			private Enumerator m_Enumerator; // 0x20
			private InlinedArray<KeyValuePair<int, int>> m_DeviceIDMappings; // 0x28
			private bool m_CreateNewDevices; // 0x40
			private InlinedArray<UnityEngine.InputSystem.InputDevice> m_CreatedDevices; // 0x48
			private Action m_OnFinished; // 0x60
			private Action<InputEventPtr> m_OnEvent; // 0x68
			private double m_StartTimeAsPerFirstEvent; // 0x70
			private double m_StartTimeAsPerRuntime; // 0x78
			private int m_AllEventsByTimeIndex; // 0x80
			private List<InputEventPtr> m_AllEventsByTime; // 0x88
	
			// Properties
			public InputEventTrace trace { get; } // 0x000000018385B100-0x000000018385B110 
			public bool finished { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
			public bool paused { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
			public int position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
			public IEnumerable<UnityEngine.InputSystem.InputDevice> createdDevices { get; } // 0x000000018B2491BC-0x000000018B24920C 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47793
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<InputEventPtr> __9__38_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B249EF0-0x000000018B24A118
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal int _PlayAllEventsAccordingToTimestamps_b__38_0(InputEventPtr a, InputEventPtr b); // 0x000000018B249D80-0x000000018B249DC4
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass43_0 // TypeDefIndex: 47794
			{
				// Fields
				public int originalDeviceId; // 0x10
	
				// Constructors
				public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _ApplyDeviceMapping_b__0(DeviceInfo x); // 0x000000018702DACC-0x000000018702DAD8
			}
	
			// Constructors
			internal ReplayController(InputEventTrace trace); // 0x000000018B249148-0x000000018B2491BC
	
			// Methods
			public void Dispose(); // 0x000000018B2482E4-0x000000018B248488
			public ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice); // 0x000000018B248F6C-0x000000018B249040
			public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId); // 0x000000018B249040-0x000000018B249148
			public ReplayController WithAllDevicesMappedToNewInstances(); // 0x0000000184DACF10-0x0000000184DACF20
			public ReplayController OnFinished(Action action); // 0x0000000186969620-0x000000018696963C
			public ReplayController OnEvent(Action<InputEventPtr> action); // 0x000000018696963C-0x0000000186969658
			public ReplayController PlayOneEvent(); // 0x000000018B248CB4-0x000000018B248D44
			public ReplayController Rewind(); // 0x000000018B248F28-0x000000018B248F6C
			public ReplayController PlayAllFramesOneByOne(); // 0x000000018B248C1C-0x000000018B248CB4
			public ReplayController PlayAllEvents(); // 0x000000018B248B78-0x000000018B248C1C
			public ReplayController PlayAllEventsAccordingToTimestamps(); // 0x000000018B248930-0x000000018B248B78
			private void OnBeginFrame(); // 0x000000018B2487B0-0x000000018B248930
			private void Finished(); // 0x000000018B248488-0x000000018B24852C
			private void QueueEvent(InputEventPtr eventPtr); // 0x000000018B248D44-0x000000018B248F28
			private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr); // 0x000000018B24852C-0x000000018B2487B0
			private int ApplyDeviceMapping(int originalDeviceId); // 0x000000018B247F88-0x000000018B2482E4
		}
	
		[Serializable]
		public struct DeviceInfo // TypeDefIndex: 47796
		{
			// Fields
			[SerializeField]
			internal int m_DeviceId; // 0x00
			[SerializeField]
			internal string m_Layout; // 0x08
			[SerializeField]
			internal FourCC m_StateFormat; // 0x10
			[SerializeField]
			internal int m_StateSizeInBytes; // 0x14
			[SerializeField]
			internal string m_FullLayoutJson; // 0x18
	
			// Properties
			public int deviceId { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
			public string layout { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
			public FourCC stateFormat { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
			public int stateSizeInBytes { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		}
	
		// Constructors
		public InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes = 1048576 /* Metadata: 0x0232A7B8 */, bool growBuffer = false /* Metadata: 0x0232A7C0 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x0232A7C1 */, long growIncrementSizeInBytes = -1 /* Metadata: 0x0232A7C9 */); // 0x000000018B2350D8-0x000000018B23517C
		public InputEventTrace(long bufferSizeInBytes = 1048576 /* Metadata: 0x0232A7D1 */, bool growBuffer = false /* Metadata: 0x0232A7D9 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x0232A7DA */, long growIncrementSizeInBytes = -1 /* Metadata: 0x0232A7E2 */); // 0x000000018B235094-0x000000018B2350D8
		static InputEventTrace(); // 0x000000018B235020-0x000000018B235094
	
		// Methods
		public void WriteTo(string filePath); // 0x000000018B234F0C-0x000000018B235020
		public void WriteTo(Stream stream); // 0x000000018B234940-0x000000018B234F0C
		public void ReadFrom(string filePath); // 0x000000018B233C10-0x000000018B233D24
		public void ReadFrom(Stream stream); // 0x000000018B233D24-0x000000018B234628
		public static InputEventTrace LoadFrom(string filePath); // 0x000000018B23350C-0x000000018B233640
		public static InputEventTrace LoadFrom(Stream stream); // 0x000000018B2333C0-0x000000018B23350C
		public ReplayController Replay(); // 0x000000018B234668-0x000000018B2346D4
		public bool Resize(long newBufferSize, long newMaxBufferSize = -1 /* Metadata: 0x0232A7EA */); // 0x000000018B2346D4-0x000000018B234938
		public void Clear(); // 0x000000018B23307C-0x000000018B2330B0
		public void Enable(); // 0x000000018B2331BC-0x000000018B2332D4
		public void Disable(); // 0x000000018B2330B0-0x000000018B23319C
		public bool GetNextEvent(ref InputEventPtr current); // 0x000000018B233334-0x000000018B2333C0
		public IEnumerator<InputEventPtr> GetEnumerator(); // 0x000000018B2332D4-0x000000018B233334
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B234938-0x000000018B234940
		public void Dispose(); // 0x000000018B23319C-0x000000018B2331BC
		private void Allocate(); // 0x000000018B233050-0x000000018B23307C
		private void Release(); // 0x000000018B234628-0x000000018B234668
		private void OnBeforeUpdate(); // 0x000000018B233640-0x000000018B233718
		private void OnInputEvent(InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device); // 0x000000018B233718-0x000000018B233C10
	}

	public struct StateEvent : IInputEventTypeInfo // TypeDefIndex: 47799
	{
		// Fields
		public const int Type = 1398030676; // Metadata: 0x0232A7F9
		internal const int kStateDataSizeToSubtract = 1; // Metadata: 0x0232A7FE
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x18
	
		// Properties
		public uint stateSizeInBytes { get; } // 0x0000000184DACFA0-0x0000000184DACFB0 
		public unsafe void* state { get; } // 0x0000000184DACFB0-0x0000000184DACFC0 
		public FourCC typeStatic { get; } // 0x0000000184DACFC0-0x0000000184DACFD0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 47798
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x000000018464E630-0x000000018464E640
		public TState GetState<TState>()
			where TState : struct, IInputStateTypeInfo;
		public static TState GetState<TState>(InputEventPtr ptr)
			where TState : struct, IInputStateTypeInfo;
		public static int GetEventSizeWithPayload<TState>()
			where TState : struct;
		public static unsafe StateEvent* From(InputEventPtr ptr); // 0x000000018B2497B8-0x000000018B2498F4
		internal static unsafe StateEvent* FromUnchecked(InputEventPtr ptr); // 0x000000018464E630-0x000000018464E640
		public static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0232A7F7 */); // 0x000000018B249788-0x000000018B2497B8
		public static NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0232A7F8 */); // 0x000000018B2494DC-0x000000018B24950C
		private static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState); // 0x000000018B24950C-0x000000018B249788
	}

	public struct TextEvent : IInputEventTypeInfo // TypeDefIndex: 47800
	{
		// Fields
		public const int Type = 1413830740; // Metadata: 0x0232A80F
		public InputEvent baseEvent; // 0x00
		public int character; // 0x14
	
		// Properties
		public FourCC typeStatic { get; } // 0x0000000184DACFD0-0x0000000184DACFE0 
	
		// Methods
		public static unsafe TextEvent* From(InputEventPtr eventPtr); // 0x000000018B249C30-0x000000018B249D6C
		public static TextEvent Create(int deviceId, char character, double time = -1 /* Metadata: 0x0232A7FF */); // 0x000000018B249B60-0x000000018B249BC8
		public static TextEvent Create(int deviceId, int character, double time = -1 /* Metadata: 0x0232A807 */); // 0x000000018B249BC8-0x000000018B249C30
	}

	internal delegate void InputUpdateDelegate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // TypeDefIndex: 47801; 0x00000001838E1420-0x00000001838E1430

	internal interface IInputRuntime // TypeDefIndex: 47802
	{
		// Properties
		InputUpdateDelegate onUpdate { get; set; }
		Action<InputUpdateType> onBeforeUpdate { get; set; }
		Func<InputUpdateType, bool> onShouldRunUpdate { get; set; }
		Action<int, string> onDeviceDiscovered { get; set; }
		Action<bool> onPlayerFocusChanged { get; set; }
		bool isPlayerFocused { get; }
		Action onShutdown { get; set; }
		float pollingFrequency { get; set; }
		double currentTime { get; }
		double currentTimeForFixedUpdate { get; }
		float unscaledGameTime { get; }
		double currentTimeOffsetToRealtimeSinceStartup { get; }
		bool runInBackground { get; set; }
		Vector2 screenSize { get; }
		ScreenOrientation screenOrientation { get; }
		bool isInBatchMode { get; }
	
		// Methods
		int AllocateDeviceId();
		void Update(InputUpdateType type);
		void QueueEvent(InputEvent* ptr);
		long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr);
	}

	internal static class InputRuntime // TypeDefIndex: 47803
	{
		// Fields
		public static IInputRuntime s_Instance; // 0x00
		public static double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x08
	}

	internal static class InputRuntimeExtensions // TypeDefIndex: 47804
	{
		// Extension methods
		public static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
	}

	[Serializable]
	public struct InputMetrics // TypeDefIndex: 47805
	{
		// Fields
		[CompilerGenerated]
		private int _maxNumDevices_k__BackingField; // 0x00
		[CompilerGenerated]
		private int _currentNumDevices_k__BackingField; // 0x04
		[CompilerGenerated]
		private int _maxStateSizeInBytes_k__BackingField; // 0x08
		[CompilerGenerated]
		private int _currentStateSizeInBytes_k__BackingField; // 0x0C
		[CompilerGenerated]
		private int _currentControlCount_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _currentLayoutCount_k__BackingField; // 0x14
		[CompilerGenerated]
		private int _totalEventBytes_k__BackingField; // 0x18
		[CompilerGenerated]
		private int _totalEventCount_k__BackingField; // 0x1C
		[CompilerGenerated]
		private int _totalUpdateCount_k__BackingField; // 0x20
		[CompilerGenerated]
		private double _totalEventProcessingTime_k__BackingField; // 0x28
		[CompilerGenerated]
		private double _totalEventLagTime_k__BackingField; // 0x30
	
		// Properties
		public int maxNumDevices { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public int currentNumDevices { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		public int maxStateSizeInBytes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
		public int currentStateSizeInBytes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 0x0000000184D8CAE0-0x0000000184D8CAF0
		public int currentControlCount { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public int currentLayoutCount { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public int totalEventBytes { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public int totalEventCount { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public int totalUpdateCount { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public double totalEventProcessingTime { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86D60-0x0000000184D86D70 0x0000000184D86D70-0x0000000184D86D80
		public double totalEventLagTime { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86A10-0x0000000184D86A20 0x0000000184D86A20-0x0000000184D86A30
		public float averageEventBytesPerFrame { get; } // 0x000000018B242894-0x000000018B2428AC 
		public double averageProcessingTimePerEvent { get; } // 0x000000018B2428C0-0x000000018B2428D4 
		public double averageLagTimePerEvent { get; } // 0x000000018B2428AC-0x000000018B2428C0 
	}

	[Flags]
	public enum InputUpdateType // TypeDefIndex: 47806
	{
		None = 0,
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		Default = 11,
		Manual = 16
	}

	internal static class InputUpdate // TypeDefIndex: 47809
	{
		// Fields
		public static uint s_UpdateStepCount; // 0x00
		public static InputUpdateType s_LatestUpdateType; // 0x04
		public static UpdateStepCount s_PlayerUpdateStepCount; // 0x08
	
		// Nested types
		[Serializable]
		public struct UpdateStepCount // TypeDefIndex: 47807
		{
			// Fields
			private bool m_WasUpdated; // 0x00
			[CompilerGenerated]
			private uint _value_k__BackingField; // 0x04
	
			// Properties
			public uint value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
	
			// Methods
			public void OnBeforeUpdate(); // 0x0000000184DACFE0-0x0000000184DACFF0
			public void OnUpdate(); // 0x00000001830CE770-0x00000001830CE780
		}
	
		[Serializable]
		public struct SerializedState // TypeDefIndex: 47808
		{
			// Fields
			public InputUpdateType lastUpdateType; // 0x00
			public UpdateStepCount playerUpdateStepCount; // 0x04
		}
	
		// Methods
		internal static void OnBeforeUpdate(InputUpdateType type); // 0x00000001830CE780-0x00000001830CE7D0
		internal static void OnUpdate(InputUpdateType type); // 0x00000001830CE710-0x00000001830CE770
		public static SerializedState Save(); // 0x000000018B245FFC-0x000000018B246048
		public static void Restore(SerializedState state); // 0x0000000183DF7BB0-0x0000000183DF7C40
	
		// Extension methods
		public static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask); // 0x000000018381FC20-0x000000018381FC40
		public static bool IsPlayerUpdate(this InputUpdateType updateType); // 0x00000001830CE8B0-0x00000001830CE8C0
	}

	internal class NativeInputRuntime : IInputRuntime // TypeDefIndex: 47813
	{
		// Fields
		public static readonly NativeInputRuntime instance; // 0x00
		private bool m_RunInBackground; // 0x10
		private Action m_ShutdownMethod; // 0x18
		private InputUpdateDelegate m_OnUpdate; // 0x20
		private Action<InputUpdateType> m_OnBeforeUpdate; // 0x28
		private Func<InputUpdateType, bool> m_OnShouldRunUpdate; // 0x30
		private float m_PollingFrequency; // 0x38
		private bool m_DidCallOnShutdown; // 0x3C
		private Action<bool> m_FocusChangedMethod; // 0x40
	
		// Properties
		public InputUpdateDelegate onUpdate { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000184A37690-0x0000000184A377A0
		public Action<InputUpdateType> onBeforeUpdate { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000183DFA4B0-0x0000000183DFA5D0
		public Func<InputUpdateType, bool> onShouldRunUpdate { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000184B49C00-0x0000000184B49D20
		public Action<int, string> onDeviceDiscovered { get; set; } // 0x000000018B247130-0x000000018B247170 0x0000000183EB3830-0x0000000183EB3880
		public Action onShutdown { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018B2471A8-0x000000018B24727C
		public Action<bool> onPlayerFocusChanged { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x0000000183EB42C0-0x0000000183EB4370
		public bool isPlayerFocused { get; } // 0x0000000185396550-0x0000000185396560 
		public float pollingFrequency { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000183EB3880-0x0000000183EB38E0
		public double currentTime { get; } // 0x00000001830CFB80-0x00000001830CFBD0 
		public double currentTimeForFixedUpdate { get; } // 0x000000018B2470F0-0x000000018B247128 
		public double currentTimeOffsetToRealtimeSinceStartup { get; } // 0x00000001830CF780-0x00000001830CF7B0 
		public float unscaledGameTime { get; } // 0x0000000185397920-0x0000000185397928 
		public bool runInBackground { get; set; } // 0x00000001833F1FA0-0x00000001833F1FF0 0x0000000184D86130-0x0000000184D86140
		public Vector2 screenSize { get; } // 0x000000018B247170-0x000000018B2471A8 
		public ScreenOrientation screenOrientation { get; } // 0x0000000185391B08-0x0000000185391B14 
		public bool isInBatchMode { get; } // 0x000000018B247128-0x000000018B247130 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 47810
		{
			// Fields
			public InputUpdateDelegate value; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal unsafe void _set_onUpdate_b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr); // 0x00000001830CE920-0x00000001830CEA20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 47811
		{
			// Fields
			public Action<InputUpdateType> value; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _set_onBeforeUpdate_b__0(NativeInputUpdateType updateType); // 0x0000000183EF9F40-0x0000000183EF9F60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 47812
		{
			// Fields
			public Func<InputUpdateType, bool> value; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _set_onShouldRunUpdate_b__0(NativeInputUpdateType updateType); // 0x0000000183DF4990-0x0000000183DF49B0
		}
	
		// Constructors
		public NativeInputRuntime(); // 0x0000000184DACEF0-0x0000000184DACF00
		static NativeInputRuntime(); // 0x0000000184D368B0-0x0000000184D36920
	
		// Methods
		public int AllocateDeviceId(); // 0x000000018B247040-0x000000018B247080
		public void Update(InputUpdateType updateType); // 0x0000000184B1ECE0-0x0000000184B1ED30
		public unsafe void QueueEvent(InputEvent* ptr); // 0x000000018B2470A4-0x000000018B2470F0
		public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr); // 0x0000000184320710-0x00000001843207A0
		private void OnShutdown(); // 0x000000018720F178-0x000000018720F194
		private bool OnWantsToShutdown(); // 0x000000018B247080-0x000000018B2470A4
		private void OnFocusChanged(bool focus); // 0x00000001848671F0-0x0000000184867210
	}

	public interface IInputStateCallbackReceiver // TypeDefIndex: 47814
	{
		// Methods
		void OnNextUpdate();
		void OnStateEvent(InputEventPtr eventPtr);
		bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
	}

	public interface IInputStateChangeMonitor // TypeDefIndex: 47815
	{
		// Methods
		void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);
		void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
	}

	public interface IInputStateTypeInfo // TypeDefIndex: 47816
	{
		// Properties
		FourCC format { get; }
	}

	public static class InputState // TypeDefIndex: 47818
	{
		// Properties
		public static InputUpdateType currentUpdateType { get; } // 0x000000018B245E90-0x000000018B245EC8 
		public static uint updateCount { get; } // 0x000000018B245EC8-0x000000018B245F00 
		public static double currentTime { get; } // 0x0000000184D50620-0x0000000184D50680 
	
		// Events
		public static event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onChange {
			add; // 0x000000018B245E30-0x000000018B245E90
			remove; // 0x000000018B245F00-0x000000018B245F60
		}
	
		// Nested types
		private class StateChangeMonitorDelegate : IInputStateChangeMonitor // TypeDefIndex: 47817
		{
			// Fields
			public Action<InputControl, double, InputEventPtr, long> valueChangeCallback; // 0x10
			public Action<InputControl, double, long, int> timerExpiredCallback; // 0x18
	
			// Constructors
			public StateChangeMonitorDelegate(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x000000018B249488-0x000000018B2494B0
			public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x000000018B2494B0-0x000000018B2494DC
		}
	
		// Methods
		public static void Change(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0232A81B */); // 0x000000018B24587C-0x000000018B245B10
		public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0232A81C */, InputEventPtr eventPtr = default)
			where TState : struct;
		public static void Change<TState>(InputControl control, ref ref TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0232A81D */, InputEventPtr eventPtr = default)
			where TState : struct;
		public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0232A81E */, uint groupIndex = 0 /* Metadata: 0x0232A826 */); // 0x000000018B2455BC-0x000000018B24577C
		public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1 /* Metadata: 0x0232A827 */, Action<InputControl, double, long, int> timerExpiredCallback = null); // 0x000000018B24577C-0x000000018B24587C
		public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0232A828 */); // 0x000000018B245D00-0x000000018B245E30
		public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1 /* Metadata: 0x0232A830 */, int timerIndex = -1 /* Metadata: 0x0232A838 */); // 0x000000018B2454C8-0x000000018B2455BC
		public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0232A839 */, int timerIndex = -1 /* Metadata: 0x0232A841 */); // 0x000000018B245C2C-0x000000018B245D00
	
		// Extension methods
		public static bool IsIntegerFormat(this FourCC format); // 0x000000018B245B10-0x000000018B245C2C
	}

	public struct InputStateBlock // TypeDefIndex: 47819
	{
		// Fields
		public const uint InvalidOffset = 4294967295; // Metadata: 0x0232A842
		public const uint AutomaticOffset = 4294967294; // Metadata: 0x0232A843
		public static readonly FourCC FormatInvalid; // 0x00
		internal const int kFormatInvalid = 0; // Metadata: 0x0232A844
		public static readonly FourCC FormatBit; // 0x04
		internal const int kFormatBit = 1112101920; // Metadata: 0x0232A845
		public static readonly FourCC FormatSBit; // 0x08
		internal const int kFormatSBit = 1396853076; // Metadata: 0x0232A84A
		public static readonly FourCC FormatInt; // 0x0C
		internal const int kFormatInt = 1229870112; // Metadata: 0x0232A84F
		public static readonly FourCC FormatUInt; // 0x10
		internal const int kFormatUInt = 1430867540; // Metadata: 0x0232A854
		public static readonly FourCC FormatShort; // 0x14
		internal const int kFormatShort = 1397248596; // Metadata: 0x0232A859
		public static readonly FourCC FormatUShort; // 0x18
		internal const int kFormatUShort = 1431521364; // Metadata: 0x0232A85E
		public static readonly FourCC FormatByte; // 0x1C
		internal const int kFormatByte = 1113150533; // Metadata: 0x0232A863
		public static readonly FourCC FormatSByte; // 0x20
		internal const int kFormatSByte = 1396857172; // Metadata: 0x0232A868
		public static readonly FourCC FormatLong; // 0x24
		internal const int kFormatLong = 1280198432; // Metadata: 0x0232A86D
		public static readonly FourCC FormatULong; // 0x28
		internal const int kFormatULong = 1431064135; // Metadata: 0x0232A872
		public static readonly FourCC FormatFloat; // 0x2C
		internal const int kFormatFloat = 1179407392; // Metadata: 0x0232A877
		public static readonly FourCC FormatDouble; // 0x30
		internal const int kFormatDouble = 1145195552; // Metadata: 0x0232A87C
		public static readonly FourCC FormatVector2; // 0x34
		internal const int kFormatVector2 = 1447379762; // Metadata: 0x0232A881
		public static readonly FourCC FormatVector3; // 0x38
		internal const int kFormatVector3 = 1447379763; // Metadata: 0x0232A886
		public static readonly FourCC FormatQuaternion; // 0x3C
		internal const int kFormatQuaternion = 1364541780; // Metadata: 0x0232A88B
		public static readonly FourCC FormatVector2Short; // 0x40
		public static readonly FourCC FormatVector3Short; // 0x44
		public static readonly FourCC FormatVector2Byte; // 0x48
		public static readonly FourCC FormatVector3Byte; // 0x4C
		public static readonly FourCC FormatPose; // 0x50
		internal const int kFormatPose = 1349481317; // Metadata: 0x0232A890
		[CompilerGenerated]
		private FourCC _format_k__BackingField; // 0x00
		internal uint m_ByteOffset; // 0x04
		[CompilerGenerated]
		private uint _bitOffset_k__BackingField; // 0x08
		[CompilerGenerated]
		private uint _sizeInBits_k__BackingField; // 0x0C
	
		// Properties
		public FourCC format { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public uint byteOffset { get; set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		public uint bitOffset { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
		public uint sizeInBits { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 0x0000000184D8CAE0-0x0000000184D8CAF0
		internal uint alignedSizeInBytes { get; } // 0x00000001830CFC10-0x00000001830CFC40 
		internal uint effectiveByteOffset { get; } // 0x000000018B243DFC-0x000000018B243E48 
		internal uint effectiveBitOffset { get; } // 0x000000018B243DB0-0x000000018B243DFC 
	
		// Constructors
		static InputStateBlock(); // 0x0000000184B0A8C0-0x0000000184B0AAA0
	
		// Methods
		public static int GetSizeOfPrimitiveFormatInBits(FourCC type); // 0x000000018B2430B0-0x000000018B243324
		public static FourCC GetPrimitiveFormatFromType(System.Type type); // 0x000000018B242C38-0x000000018B2430B0
		public unsafe int ReadInt(void* statePtr); // 0x0000000183F51080-0x0000000183F51100
		public unsafe void WriteInt(void* statePtr, int value); // 0x000000018B243BAC-0x000000018B243DB0
		public unsafe float ReadFloat(void* statePtr); // 0x00000001830D1BC0-0x00000001830D1CD0
		public unsafe void WriteFloat(void* statePtr, float value); // 0x000000018B2438D8-0x000000018B243BAC
		internal PrimitiveValue FloatToPrimitiveValue(float value); // 0x000000018B2428D4-0x000000018B242C38
		public unsafe double ReadDouble(void* statePtr); // 0x000000018B243324-0x000000018B2435D8
		public unsafe void WriteDouble(void* statePtr, double value); // 0x000000018B2435D8-0x000000018B2438D8
		public unsafe void Write(void* statePtr, PrimitiveValue value); // 0x000000018426F500-0x000000018426F5B0
		public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr); // 0x0000000184B39120-0x0000000184B39200
	}

	internal struct InputStateBuffers // TypeDefIndex: 47821
	{
		// Fields
		public uint sizePerBuffer; // 0x00
		public uint totalSize; // 0x04
		public unsafe void* defaultStateBuffer; // 0x08
		public unsafe void* noiseMaskBuffer; // 0x10
		public unsafe void* resetMaskBuffer; // 0x18
		private unsafe void* m_AllBuffers; // 0x20
		internal DoubleBuffers m_PlayerStateBuffers; // 0x28
		internal static unsafe void* s_DefaultStateBuffer; // 0x00
		internal static unsafe void* s_NoiseMaskBuffer; // 0x08
		internal static unsafe void* s_ResetMaskBuffer; // 0x10
		internal static DoubleBuffers s_CurrentBuffers; // 0x18
	
		// Nested types
		[Serializable]
		internal struct DoubleBuffers // TypeDefIndex: 47820
		{
			// Fields
			public unsafe void** deviceToBufferMapping; // 0x00
			public int deviceCount; // 0x08
	
			// Properties
			public bool valid { get; } // 0x00000001830CF830-0x00000001830CF840 
	
			// Methods
			public unsafe void SetFrontBuffer(int deviceIndex, void* ptr); // 0x00000001830CF7F0-0x00000001830CF810
			public unsafe void SetBackBuffer(int deviceIndex, void* ptr); // 0x00000001830CF810-0x00000001830CF830
			public unsafe void* GetFrontBuffer(int deviceIndex); // 0x00000001830D1280-0x00000001830D12A0
			public unsafe void* GetBackBuffer(int deviceIndex); // 0x00000001830CF840-0x00000001830CF860
			public void SwapBuffers(int deviceIndex); // 0x00000001830CF860-0x00000001830CF8C0
		}
	
		// Methods
		public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType); // 0x00000001830CE850-0x00000001830CE880
		public static unsafe void* GetFrontBufferForDevice(int deviceIndex); // 0x00000001830D1250-0x00000001830D1280
		public static unsafe void* GetBackBufferForDevice(int deviceIndex); // 0x000000018448E060-0x000000018448E0B0
		public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update); // 0x00000001830CE810-0x00000001830CE850
		public void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount); // 0x0000000183AE8D70-0x0000000183AE8E70
		private static unsafe DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer); // 0x0000000183AE8E70-0x0000000183AE8F10
		public void FreeAll(); // 0x0000000183AE8CA0-0x0000000183AE8D70
		public void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers); // 0x0000000183AE8F10-0x0000000183AE90E0
		private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer); // 0x0000000183AE8330-0x0000000183AE8510
		private static unsafe void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer); // 0x0000000183AE90E0-0x0000000183AE9210
		private static uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount); // 0x0000000183AE9210-0x0000000183AE9270
		private static uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device); // 0x0000000183AE9270-0x0000000183AE9300
	}

	public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IInputStateChangeMonitor // TypeDefIndex: 47827
	{
		// Fields
		private const int kDefaultHistorySize = 128; // Metadata: 0x0232A895
		[CompilerGenerated]
		private Action<Record> _onRecordAdded_k__BackingField; // 0x10
		[CompilerGenerated]
		private Func<InputControl, double, InputEventPtr, bool> _onShouldRecordStateChange_k__BackingField; // 0x18
		internal InputControl[] m_Controls; // 0x20
		internal int m_ControlCount; // 0x28
		private NativeArray<byte> m_RecordBuffer; // 0x30
		private int m_StateSizeInBytes; // 0x40
		private int m_RecordCount; // 0x44
		private int m_HistoryDepth; // 0x48
		private int m_ExtraMemoryPerRecord; // 0x4C
		internal int m_HeadIndex; // 0x50
		internal uint m_CurrentVersion; // 0x54
		private InputUpdateType? m_UpdateMask; // 0x58
		internal readonly bool m_AddNewControls; // 0x60
	
		// Properties
		public int Count { get; } // 0x0000000184D86530-0x0000000184D86540 
		public uint version { get; } // 0x0000000184D86540-0x0000000184D86550 
		public int historyDepth { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x000000018B245328-0x000000018B245410
		public int extraMemoryPerRecord { get; set; } // 0x0000000184D86600-0x0000000184D86610 0x00000001842EF120-0x00000001842EF170
		public InputUpdateType updateMask { get; set; } // 0x000000018B245160-0x000000018B2451E4 0x000000018B245410-0x000000018B2454C8
		public ReadOnlyArray<InputControl> controls { get; } // 0x000000018B245100-0x000000018B245160 
		public Record this[int index] { get => default; set {} } // 0x000000018B244FB4-0x000000018B2450D8 0x000000018B2451E4-0x000000018B245328
		public Action<Record> onRecordAdded { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		internal int bytesPerRecord { get; } // 0x000000018B2450D8-0x000000018B245100 
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 47822
		{
			// Fields
			private readonly InputStateHistory m_History; // 0x00
			private int m_Index; // 0x08
	
			// Properties
			public Record Current { get; } // 0x000000018B23CE80-0x000000018B23CEBC 
			object IEnumerator.Current { get; } // 0x000000018B23CDF8-0x000000018B23CE50 
	
			// Constructors
			public Enumerator(InputStateHistory history); // 0x000000018802AFB8-0x000000018802AFD4
	
			// Methods
			public bool MoveNext(); // 0x000000018808E204-0x000000018808E230
			public void Reset(); // 0x0000000184D94F70-0x0000000184D94F80
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		protected internal struct RecordHeader // TypeDefIndex: 47825
		{
			// Fields
			public double time; // 0x00
			public uint version; // 0x08
			public int controlIndex; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithoutControlIndex[0]; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithControlIndex[0]; // 0x10
			public const int kSizeWithControlIndex = 16; // Metadata: 0x0232A897
			public const int kSizeWithoutControlIndex = 12; // Metadata: 0x0232A898
	
			// Properties
			public unsafe byte* statePtrWithControlIndex { get; } // 0x0000000184DACF00-0x0000000184DACF10 
			public unsafe byte* statePtrWithoutControlIndex { get; } // 0x0000000184DA51C0-0x0000000184DA51D0 
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_StateWithoutControlIndex_e__FixedBuffer // TypeDefIndex: 47823
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_StateWithControlIndex_e__FixedBuffer // TypeDefIndex: 47824
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 47826
		{
			// Fields
			private readonly InputStateHistory m_Owner; // 0x00
			private readonly int m_IndexPlusOne; // 0x08
			private uint m_Version; // 0x0C
	
			// Properties
			internal unsafe RecordHeader* header { get; } // 0x000000018B247D44-0x000000018B247D6C 
			internal int recordIndex { get; } // 0x0000000184D9E120-0x0000000184D9E130 
			internal uint version { get; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 
			public bool valid { get; } // 0x000000018B247F48-0x000000018B247F88 
			public InputStateHistory owner { get; } // 0x0000000182B76770-0x0000000182B76780 
			public int index { get; } // 0x000000018B247D6C-0x000000018B247D9C 
			public double time { get; } // 0x000000018B247F18-0x000000018B247F48 
			public InputControl control { get; } // 0x000000018B247C98-0x000000018B247D44 
			public Record next { get; } // 0x000000018B247D9C-0x000000018B247E5C 
			public Record previous { get; } // 0x000000018B247E5C-0x000000018B247F18 
	
			// Constructors
			internal unsafe Record(InputStateHistory owner, int index, RecordHeader* header); // 0x000000018907C3C0-0x000000018907C3F0
	
			// Methods
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public object ReadValueAsObject(); // 0x000000018B247B90-0x000000018B247BD4
			public unsafe void* GetUnsafeMemoryPtr(); // 0x000000018B247B70-0x000000018B247B90
			internal unsafe void* GetUnsafeMemoryPtrUnchecked(); // 0x000000018B247AF0-0x000000018B247B70
			public unsafe void* GetUnsafeExtraMemoryPtr(); // 0x000000018B247AD0-0x000000018B247AF0
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked(); // 0x000000018B247A24-0x000000018B247AD0
			public void CopyFrom(Record record); // 0x000000018B2475A8-0x000000018B2479B4
			internal void CheckValid(); // 0x000000018B2474D0-0x000000018B2475A8
			public bool Equals(Record other); // 0x0000000188CC0AF0-0x0000000188CC0B10
			public override bool Equals(object obj); // 0x000000018B2479B4-0x000000018B247A24
			public override int GetHashCode(); // 0x000000018907BF10-0x000000018907BF44
			public override string ToString(); // 0x000000018B247BD4-0x000000018B247C98
		}
	
		// Constructors
		public InputStateHistory(int maxStateSizeInBytes); // 0x0000000184B864C0-0x0000000184B86510
		public InputStateHistory(string path); // 0x000000018B244D70-0x000000018B244ECC
		public InputStateHistory(InputControl control); // 0x000000018B244ECC-0x000000018B244FB4
		public InputStateHistory(IEnumerable<InputControl> controls); // 0x000000018B244CFC-0x000000018B244D70
	
		// Methods
		~InputStateHistory(); // 0x000000018B244200-0x000000018B244270
		public void Clear(); // 0x0000000184DACED0-0x0000000184DACEE0
		public Record AddRecord(Record record); // 0x000000018B243E48-0x000000018B243EC0
		public void StartRecording(); // 0x000000018B2449DC-0x000000018B244B14
		public void StopRecording(); // 0x000000018B244B14-0x000000018B244C40
		public Record RecordStateChange(InputControl control, InputEventPtr eventPtr); // 0x000000018B244524-0x000000018B244710
		public unsafe Record RecordStateChange(InputControl control, void* statePtr, double time); // 0x000000018B244710-0x000000018B2449DC
		public IEnumerator<Record> GetEnumerator(); // 0x000000018B244270-0x000000018B2442D0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B244C40-0x000000018B244C48
		public void Dispose(); // 0x000000018B2441AC-0x000000018B244200
		protected void Destroy(); // 0x000000018B244154-0x000000018B2441AC
		private void Allocate(); // 0x000000018B243F58-0x000000018B244154
		protected internal int RecordIndexToUserIndex(int index); // 0x000000018B244510-0x000000018B244524
		protected internal int UserIndexToRecordIndex(int index); // 0x0000000184DACEE0-0x0000000184DACEF0
		protected internal unsafe RecordHeader* GetRecord(int index); // 0x000000018B244324-0x000000018B244418
		internal unsafe RecordHeader* GetRecordUnchecked(int index); // 0x000000018B2442D0-0x000000018B244324
		protected internal unsafe RecordHeader* AllocateRecord(out int index); // 0x000000018B243EC0-0x000000018B243F58
		protected unsafe TValue ReadValue<TValue>(RecordHeader* data)
			where TValue : struct;
		protected unsafe object ReadValueAsObject(RecordHeader* data); // 0x000000018B244418-0x000000018B244510
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x000000018B244C48-0x000000018B244CFC
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x00000001841E1670-0x00000001841E1680
	}

	public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>> // TypeDefIndex: 47830
		where TValue : struct
	{
		// Properties
		public new Record this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 47828
		{
			// Fields
			private readonly InputStateHistory<TValue> m_History;
			private int m_Index;
	
			// Properties
			public Record<TValue> Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator(InputStateHistory<TValue> history);
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 47829
		{
			// Fields
			private readonly InputStateHistory<TValue> m_Owner;
			private readonly int m_IndexPlusOne;
			private uint m_Version;
	
			// Properties
			internal unsafe InputStateHistory.RecordHeader* header { get; }
			internal int recordIndex { get; }
			public bool valid { get; }
			public InputStateHistory<TValue> owner { get; }
			public int index { get; }
			public double time { get; }
			public InputControl<TValue> control { get; }
			public Record<TValue> next { get; }
			public Record<TValue> previous { get; }
	
			// Constructors
			internal unsafe Record(InputStateHistory<TValue> owner, int index, InputStateHistory.RecordHeader* header);
			internal Record(InputStateHistory<TValue> owner, int index);
	
			// Methods
			public TValue ReadValue();
			public unsafe void* GetUnsafeMemoryPtr();
			internal unsafe void* GetUnsafeMemoryPtrUnchecked();
			public unsafe void* GetUnsafeExtraMemoryPtr();
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked();
			public void CopyFrom(Record<TValue> record);
			private void CheckValid();
			public bool Equals(Record<TValue> other);
			public override bool Equals(object obj);
			public override int GetHashCode();
			public override string ToString();
		}
	
		// Constructors
		public InputStateHistory(int? maxStateSizeInBytes = default);
		public InputStateHistory(InputControl<TValue> control);
		public InputStateHistory(string path);
	
		// Methods
		~InputStateHistory();
		public Record AddRecord(Record record);
		public Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x0232A899 */);
		public new IEnumerator<Record> GetEnumerator();
		new IEnumerator IEnumerable.GetEnumerator();
	}

	internal class SelectObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 47832
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, TResult> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 47831
		{
			// Fields
			private SelectObservable<TSource, TResult> m_Observable;
			private readonly IObserver<TResult> m_Observer;
	
			// Constructors
			public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer);
	
			// Methods
			public void OnCompleted();
			public void OnError(Exception error);
			public void OnNext(TSource evt);
		}
	
		// Constructors
		public SelectObservable(IObservable<TSource> source, Func<TSource, TResult> filter);
	
		// Methods
		public IDisposable Subscribe(IObserver<TResult> observer);
	}
}

namespace UnityEngine.InputSystem.OnScreen
{
	[AddComponentMenu("Input/On-Screen Button")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/OnScreen.html#on-screen-buttons")]
	public class OnScreenButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 47652
	{
		// Fields
		[InputControl(layout = "Button")]
		[SerializeField]
		private string m_ControlPath; // 0x30
	
		// Properties
		protected override string controlPathInternal { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public OnScreenButton(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnPointerUp(PointerEventData eventData); // 0x000000018B223FB0-0x000000018B223FEC
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B223F6C-0x000000018B223FB0
	}

	public abstract class OnScreenControl : MonoBehaviour // TypeDefIndex: 47654
	{
		// Fields
		private InputControl m_Control; // 0x18
		private OnScreenControl m_NextControlOnDevice; // 0x20
		private InputEventPtr m_InputEventPtr; // 0x28
		private static int s_nbActiveInstances; // 0x00
		private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; // 0x08
	
		// Properties
		public string controlPath { get; set; } // 0x0000000185395664-0x0000000185395674 0x000000018B224E88-0x000000018B224EC4
		public InputControl control { get; } // 0x000000018385B100-0x000000018385B110 
		protected abstract string controlPathInternal { get; set; }
		internal static bool HasAnyActive { get; } // 0x000000018B224E4C-0x000000018B224E88 
	
		// Nested types
		private struct OnScreenDeviceInfo // TypeDefIndex: 47653
		{
			// Fields
			public InputEventPtr eventPtr; // 0x00
			public NativeArray<byte> buffer; // 0x08
			public UnityEngine.InputSystem.InputDevice device; // 0x18
			public OnScreenControl firstControl; // 0x20
	
			// Methods
			public OnScreenDeviceInfo AddControl(OnScreenControl control); // 0x000000018B224EC4-0x000000018B224F20
			public OnScreenDeviceInfo RemoveControl(OnScreenControl control); // 0x000000018B224FBC-0x000000018B2250F8
			public void Destroy(); // 0x000000018B224F20-0x000000018B224FBC
		}
	
		// Constructors
		protected OnScreenControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void SetupInputControl(); // 0x000000018B224630-0x000000018B224E4C
		protected void SendValueToControl<TValue>(TValue value)
			where TValue : struct;
		protected void SentDefaultValueToControl(); // 0x000000018B224598-0x000000018B224630
		protected virtual void OnEnable(); // 0x000000018B2242B8-0x000000018B224598
		protected virtual void OnDisable(); // 0x000000018B224034-0x000000018B2242B8
		internal string GetWarningMessage(); // 0x000000018B223FEC-0x000000018B224034
	}

	internal static class UGUIOnScreenControlUtils // TypeDefIndex: 47655
	{
		// Methods
		public static RectTransform GetCanvasRectTransform(Transform transform); // 0x000000018B2291B8-0x000000018B229250
	}

	[AddComponentMenu("Input/On-Screen Stick")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/OnScreen.html#on-screen-sticks")]
	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 47657
	{
		// Fields
		private const string kDynamicOriginClickable = "DynamicOriginClickable"; // Metadata: 0x0232A56D
		[FormerlySerializedAs("movementRange")]
		[Min(0f)]
		[SerializeField]
		private float m_MovementRange; // 0x30
		[Min(0f)]
		[SerializeField]
		[Tooltip("Defines the circular region where the onscreen control may have it\'s origin placed.")]
		private float m_DynamicOriginRange; // 0x34
		[InputControl(layout = "Vector2")]
		[SerializeField]
		private string m_ControlPath; // 0x38
		[SerializeField]
		[Tooltip("Choose how the onscreen stick will move relative to it\'s origin and the press position.\n\nRelativePositionWithStaticOrigin: The control\'s center of origin is fixed. The control will begin un-actuated at it\'s centered position and then move relative to the pointer or finger motion.\n\nExactPositionWithStaticOrigin: The control\'s center of origin is fixed. The stick will immediately jump to the exact position of the click or touch and begin tracking motion from there.\n\nExactPositionWithDynamicOrigin: The control\'s center of origin is determined by the initial press position. The stick will begin un-actuated at this center position and then track the current pointer or finger position.")]
		private Behaviour m_Behaviour; // 0x40
		[SerializeField]
		[Tooltip("Set this to true to prevent cancellation of pointer events due to device switching. Cancellation will appear as the stick jumping back and forth between the pointer position and the stick center.")]
		private bool m_UseIsolatedInputActions; // 0x44
		[SerializeField]
		[Tooltip("The action that will be used to detect pointer down events on the stick control. Note that if no bindings are set, default ones will be provided.")]
		private InputAction m_PointerDownAction; // 0x48
		[SerializeField]
		[Tooltip("The action that will be used to detect pointer movement on the stick control. Note that if no bindings are set, default ones will be provided.")]
		private InputAction m_PointerMoveAction; // 0x50
		private Vector3 m_StartPos; // 0x58
		private Vector2 m_PointerDownPos; // 0x64
		[NonSerialized]
		private List<RaycastResult> m_RaycastResults; // 0x70
		[NonSerialized]
		private PointerEventData m_PointerEventData; // 0x78
		[NonSerialized]
		private TouchControl m_TouchControl; // 0x80
		[NonSerialized]
		private bool m_IsIsolationActive; // 0x88
	
		// Properties
		public float movementRange { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
		public float dynamicOriginRange { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x000000018B226C44-0x000000018B226C60
		public bool useIsolatedInputActions { get; set; } // 0x0000000184D86A30-0x0000000184D86A40 0x0000000184D86A40-0x0000000184D86A50
		protected override string controlPathInternal { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public Behaviour behaviour { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
	
		// Nested types
		public enum Behaviour // TypeDefIndex: 47656
		{
			RelativePositionWithStaticOrigin = 0,
			ExactPositionWithStaticOrigin = 1,
			ExactPositionWithDynamicOrigin = 2
		}
	
		// Constructors
		public OnScreenStick(); // 0x000000018B226C20-0x000000018B226C44
	
		// Methods
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B226178-0x000000018B226230
		public void OnDrag(PointerEventData eventData); // 0x000000018B2259A8-0x000000018B225A60
		public void OnPointerUp(PointerEventData eventData); // 0x000000018B226440-0x000000018B226450
		private void Start(); // 0x000000018B226450-0x000000018B226AF8
		private void OnDestroy(); // 0x000000018B225910-0x000000018B2259A8
		private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera); // 0x000000018B2250F8-0x000000018B2252C8
		private void MoveStick(Vector2 pointerPosition, Camera uiCamera); // 0x000000018B2255DC-0x000000018B225910
		private void EndInteraction(); // 0x000000018B225408-0x000000018B2254CC
		private void OnPointerDown(InputAction.CallbackContext ctx); // 0x000000018B225C94-0x000000018B226178
		private void OnPointerChanged(InputAction.CallbackContext ctx); // 0x000000018B225C3C-0x000000018B225C94
		private void OnPointerMove(InputAction.CallbackContext ctx); // 0x000000018B226230-0x000000018B226334
		private void OnPointerUp(InputAction.CallbackContext ctx); // 0x000000018B226334-0x000000018B226440
		private Camera GetCameraFromCanvas(); // 0x000000018B2254CC-0x000000018B2255DC
		private void OnDrawGizmosSelected(); // 0x000000018B225A60-0x000000018B225C3C
		private void DrawGizmoCircle(Vector2 center, float radius); // 0x000000018B2252C8-0x000000018B225408
		private void UpdateDynamicOriginClickableArea(); // 0x000000018B226AF8-0x000000018B226C20
	}
}

namespace UnityEngine.InputSystem.Processors
{
	public class AxisDeadzoneProcessor : InputProcessor<float> // TypeDefIndex: 47833
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get; } // 0x000000018B23991C-0x000000018B23997C 
		private float maxOrDefault { get; } // 0x000000018B2398BC-0x000000018B23991C 
	
		// Constructors
		public AxisDeadzoneProcessor(); // 0x000000018B239894-0x000000018B2398BC
	
		// Methods
		public override float Process(float value, InputControl control = null); // 0x000000018B239788-0x000000018B2397F8
		public override string ToString(); // 0x000000018B2397F8-0x000000018B239894
	}

	public class ClampProcessor : InputProcessor<float> // TypeDefIndex: 47834
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Constructors
		public ClampProcessor(); // 0x000000018B239ED8-0x000000018B239F00
	
		// Methods
		public override float Process(float value, InputControl control); // 0x000000018B239E2C-0x000000018B239E48
		public override string ToString(); // 0x000000018B239E48-0x000000018B239ED8
	}

	[DesignTimeVisible(false)]
	internal class CompensateDirectionProcessor : InputProcessor<Vector3> // TypeDefIndex: 47835
	{
		// Properties
		public override CachingPolicy cachingPolicy { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public CompensateDirectionProcessor(); // 0x000000018B23ACA8-0x000000018B23ACD0
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018B23AB4C-0x000000018B23AC7C
		public override string ToString(); // 0x000000018B23AC7C-0x000000018B23ACA8
	}

	[DesignTimeVisible(false)]
	internal class CompensateRotationProcessor : InputProcessor<Quaternion> // TypeDefIndex: 47836
	{
		// Properties
		public override CachingPolicy cachingPolicy { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public CompensateRotationProcessor(); // 0x000000018B23ADFC-0x000000018B23AE24
	
		// Methods
		public override Quaternion Process(Quaternion value, InputControl control); // 0x000000018B23ACD0-0x000000018B23ADD0
		public override string ToString(); // 0x000000018B23ADD0-0x000000018B23ADFC
	}

	public class InvertProcessor : InputProcessor<float> // TypeDefIndex: 47837
	{
		// Constructors
		public InvertProcessor(); // 0x000000018B246074-0x000000018B24609C
	
		// Methods
		public override float Process(float value, InputControl control); // 0x0000000184DA64A0-0x0000000184DA64B0
		public override string ToString(); // 0x000000018B246048-0x000000018B246074
	}

	public class InvertVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 47838
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
	
		// Constructors
		public InvertVector2Processor(); // 0x000000018B24617C-0x000000018B2461B8
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x000000018B24609C-0x000000018B2460F4
		public override string ToString(); // 0x000000018B2460F4-0x000000018B24617C
	}

	public class InvertVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 47839
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
		public bool invertZ; // 0x12
	
		// Constructors
		public InvertVector3Processor(); // 0x000000018B2462C8-0x000000018B246300
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018B2461B8-0x000000018B246214
		public override string ToString(); // 0x000000018B246214-0x000000018B2462C8
	}

	public class NormalizeProcessor : InputProcessor<float> // TypeDefIndex: 47840
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
		public float zero; // 0x18
	
		// Constructors
		public NormalizeProcessor(); // 0x000000018B2473B8-0x000000018B2473E0
	
		// Methods
		public override float Process(float value, InputControl control); // 0x000000018B2472CC-0x000000018B2472F8
		public static float Normalize(float value, float min, float max, float zero); // 0x000000018426F6B0-0x000000018426F750
		internal static float Denormalize(float value, float min, float max, float zero); // 0x000000018B24727C-0x000000018B2472CC
		public override string ToString(); // 0x000000018B2472F8-0x000000018B2473B8
	}

	public class NormalizeVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 47841
	{
		// Constructors
		public NormalizeVector2Processor(); // 0x000000018B247424-0x000000018B24744C
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x000000018B2473E0-0x000000018B2473F8
		public override string ToString(); // 0x000000018B2473F8-0x000000018B247424
	}

	public class NormalizeVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 47842
	{
		// Constructors
		public NormalizeVector3Processor(); // 0x000000018B2474A8-0x000000018B2474D0
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018B24744C-0x000000018B24747C
		public override string ToString(); // 0x000000018B24747C-0x000000018B2474A8
	}

	public class ScaleProcessor : InputProcessor<float> // TypeDefIndex: 47843
	{
		// Fields
		[Tooltip("Scale factor to multiply incoming float values by.")]
		public float factor; // 0x10
	
		// Constructors
		public ScaleProcessor(); // 0x000000018B249270-0x000000018B2492AC
	
		// Methods
		public override float Process(float value, InputControl control); // 0x0000000184DACF20-0x0000000184DACF30
		public override string ToString(); // 0x000000018B24920C-0x000000018B249270
	}

	public class ScaleVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 47844
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector2\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector2\'s Y component by.")]
		public float y; // 0x14
	
		// Constructors
		public ScaleVector2Processor(); // 0x000000018B24933C-0x000000018B249388
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x0000000184DACF30-0x0000000184DACF60
		public override string ToString(); // 0x000000018B2492AC-0x000000018B24933C
	}

	public class ScaleVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 47845
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector3\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Y component by.")]
		public float y; // 0x14
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Z component by.")]
		public float z; // 0x18
	
		// Constructors
		public ScaleVector3Processor(); // 0x000000018B249448-0x000000018B249488
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x0000000184DACF60-0x0000000184DACFA0
		public override string ToString(); // 0x000000018B249388-0x000000018B249448
	}

	public class StickDeadzoneProcessor : InputProcessor<Vector2> // TypeDefIndex: 47846
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get; } // 0x000000018B249B00-0x000000018B249B60 
		private float maxOrDefault { get; } // 0x000000018B249AA0-0x000000018B249B00 
	
		// Constructors
		public StickDeadzoneProcessor(); // 0x000000018B249A78-0x000000018B249AA0
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control = null); // 0x000000018B249964-0x000000018B2499DC
		private float GetDeadZoneAdjustedValue(float value); // 0x000000018B2498F4-0x000000018B249964
		public override string ToString(); // 0x000000018B2499DC-0x000000018B249A78
	}
}

namespace UnityEngine.InputSystem.Switch
{
	[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
	public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor // TypeDefIndex: 47648
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _captureButton_k__BackingField; // 0x210
		[CompilerGenerated]
		private ButtonControl _homeButton_k__BackingField; // 0x218
		private static readonly SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence; // 0x00
		private int m_HandshakeStepIndex; // 0x220
		private double m_HandshakeTimer; // 0x228
		internal const byte JitterMaskLow = 120; // Metadata: 0x0232A544
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0232A545
	
		// Properties
		[InputControl(name = "capture", displayName = "Capture")]
		public ButtonControl captureButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(name = "home", displayName = "Home")]
		public ButtonControl homeButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
	
		// Nested types
		private struct SwitchInputOnlyReport // TypeDefIndex: 47639
		{
			// Fields
			public const int kSize = 7; // Metadata: 0x0232A546
			public byte buttons0; // 0x00
			public byte buttons1; // 0x01
			public byte hat; // 0x02
			public byte leftX; // 0x03
			public byte leftY; // 0x04
			public byte rightX; // 0x05
			public byte rightY; // 0x06
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018B226FD0-0x000000018B227248
		}
	
		private struct SwitchSimpleInputReport // TypeDefIndex: 47640
		{
			// Fields
			public const int kSize = 12; // Metadata: 0x0232A547
			public const byte ExpectedReportId = 63; // Metadata: 0x0232A548
			public byte reportId; // 0x00
			public byte buttons0; // 0x01
			public byte buttons1; // 0x02
			public byte hat; // 0x03
			public ushort leftX; // 0x04
			public ushort leftY; // 0x06
			public ushort rightX; // 0x08
			public ushort rightY; // 0x0A
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018B227A98-0x000000018B227D68
		}
	
		private struct SwitchFullInputReport // TypeDefIndex: 47641
		{
			// Fields
			public const int kSize = 25; // Metadata: 0x0232A549
			public const byte ExpectedReportId = 48; // Metadata: 0x0232A54A
			public byte reportId; // 0x00
			public byte buttons0; // 0x03
			public byte buttons1; // 0x04
			public byte buttons2; // 0x05
			public byte left0; // 0x06
			public byte left1; // 0x07
			public byte left2; // 0x08
			public byte right0; // 0x09
			public byte right1; // 0x0A
			public byte right2; // 0x0B
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018B226D64-0x000000018B226FD0
		}
	
		private struct SwitchHIDGenericInputReport // TypeDefIndex: 47642
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get; } // 0x0000000184DAC340-0x0000000184DAC350 
		}
	
		internal struct SwitchMagicOutputReport // TypeDefIndex: 47645
		{
			// Fields
			public const int kSize = 49; // Metadata: 0x0232A54B
			public const byte ExpectedReplyInputReportId = 129; // Metadata: 0x0232A54C
			public byte reportType; // 0x00
			public byte commandId; // 0x01
	
			// Nested types
			internal enum ReportType // TypeDefIndex: 47643
			{
				Magic = 128
			}
	
			public enum CommandIdType // TypeDefIndex: 47644
			{
				Status = 1,
				Handshake = 2,
				Highspeed = 3,
				ForceUSB = 4
			}
		}
	
		internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo // TypeDefIndex: 47646
		{
			// Fields
			public const int kSize = 57; // Metadata: 0x0232A553
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
			public FourCC typeStatic { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
	
			// Methods
			public static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type); // 0x0000000184DAC350-0x0000000184DAC3B0
		}
	
		internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo // TypeDefIndex: 47647
		{
			// Fields
			public const int kSize = 72; // Metadata: 0x0232A554
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
			public FourCC typeStatic { get; } // 0x0000000184DAC3B0-0x0000000184DAC3C0 
	
			// Methods
			public static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type); // 0x0000000184DAC3C0-0x0000000184DAC420
		}
	
		// Constructors
		public SwitchProControllerHID(); // 0x00000001853971D4-0x00000001853971DC
		static SwitchProControllerHID(); // 0x000000018B227A0C-0x000000018B227A98
	
		// Methods
		protected override void OnAdded(); // 0x000000018B227680-0x000000018B227728
		private void HandshakeRestart(); // 0x000000018B2273E4-0x000000018B227440
		private void HandshakeTick(); // 0x000000018B227440-0x000000018B227680
		public void OnNextUpdate(); // 0x000000018B227728-0x000000018B227730
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018B227730-0x000000018B227888
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001812081B0-0x0000000181208610
		public bool PreProcessEvent(InputEventPtr eventPtr); // 0x000000018B227888-0x000000018B227A0C
	}

	internal static class SwitchSupportHID // TypeDefIndex: 47649
	{
		// Methods
		public static void Initialize(); // 0x0000000183AF3430-0x0000000183AF3C50
	}
}

namespace UnityEngine.InputSystem.Switch.LowLevel
{
	internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo // TypeDefIndex: 47651
	{
		// Fields
		public static FourCC Format; // 0x00
		[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85")]
		[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
		[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		[InputControl(name = "select", displayName = "Minus", bit = 15)]
		[InputControl(name = "leftTrigger", displayName = "ZL", shortDisplayName = "ZL", format = "BIT", bit = 12)]
		[InputControl(name = "rightStickPress", displayName = "Right Stick", bit = 11)]
		[InputControl(name = "leftStickPress", displayName = "Left Stick", bit = 10)]
		[InputControl(name = "rightShoulder", displayName = "R", shortDisplayName = "R", bit = 9)]
		[InputControl(name = "leftShoulder", displayName = "L", shortDisplayName = "L", bit = 8)]
		[InputControl(name = "buttonEast", displayName = "A", shortDisplayName = "A", bit = 7, usages = new string[2] {"PrimaryAction", "Submit" })]
		[InputControl(name = "buttonNorth", displayName = "X", shortDisplayName = "X", bit = 5)]
		[InputControl(name = "buttonWest", displayName = "Y", shortDisplayName = "Y", bit = 4, usage = "SecondaryAction")]
		[InputControl(name = "dpad/down", bit = 2)]
		[InputControl(name = "dpad/right", bit = 1)]
		[InputControl(name = "dpad/up", bit = 0)]
		[InputControl(name = "dpad", format = "BIT", bit = 0, sizeInBits = 4)]
		[InputControl(name = "buttonSouth", displayName = "B", shortDisplayName = "B", bit = 6, usages = new string[2] {"Back", "Cancel" })]
		[InputControl(name = "dpad/left", bit = 3)]
		[InputControl(name = "start", displayName = "Plus", bit = 14, usage = "Menu")]
		[InputControl(name = "rightTrigger", displayName = "ZR", shortDisplayName = "ZR", format = "BIT", bit = 13)]
		public ushort buttons1; // 0x04
		[InputControl(name = "capture", layout = "Button", displayName = "Capture", bit = 0)]
		[InputControl(name = "home", layout = "Button", displayName = "Home", bit = 1)]
		public byte buttons2; // 0x06
	
		// Properties
		public FourCC format { get; } // 0x000000018B227394-0x000000018B2273E4 
	
		// Nested types
		public enum Button // TypeDefIndex: 47650
		{
			Up = 0,
			Right = 1,
			Down = 2,
			Left = 3,
			West = 4,
			Y = 4,
			North = 5,
			X = 5,
			South = 6,
			B = 6,
			East = 7,
			A = 7,
			L = 8,
			R = 9,
			StickL = 10,
			StickR = 11,
			ZL = 12,
			ZR = 13,
			Plus = 14,
			Minus = 15,
			Capture = 16,
			Home = 17
		}
	
		// Constructors
		static SwitchProControllerHIDInputState(); // 0x000000018B227358-0x000000018B227394
	
		// Methods
		public SwitchProControllerHIDInputState WithButton(Button button, bool value = true /* Metadata: 0x0232A556 */); // 0x000000018B2272F8-0x000000018B227358
		public void Set(Button button, bool state); // 0x000000018B220288-0x000000018B2205BC
		public void Press(Button button); // 0x000000018B227248-0x000000018B2272A0
		public void Release(Button button); // 0x000000018B2272A0-0x000000018B2272F8
	}
}

namespace UnityEngine.InputSystem.UI
{
	internal class BaseInputOverride : BaseInput // TypeDefIndex: 47619
	{
		// Fields
		[CompilerGenerated]
		private readonly string _compositionString_k__BackingField; // 0x18
	
		// Properties
		public override string compositionString { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public BaseInputOverride(); // 0x0000000185393520-0x0000000185393538
	}

	internal class ExtendedAxisEventData : AxisEventData, INavigationEventData // TypeDefIndex: 47620
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x30
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public ExtendedAxisEventData(EventSystem eventSystem); // 0x000000018B2207EC-0x000000018B2207F4
	
		// Methods
		public override string ToString(); // 0x000000018B220754-0x000000018B2207EC
	}

	public class ExtendedPointerEventData : PointerEventData // TypeDefIndex: 47621
	{
		// Fields
		[CompilerGenerated]
		private InputControl _control_k__BackingField; // 0x160
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x168
		[CompilerGenerated]
		private int _touchId_k__BackingField; // 0x170
		[CompilerGenerated]
		private UIPointerType _pointerType_k__BackingField; // 0x174
		[CompilerGenerated]
		private int _uiToolkitPointerId_k__BackingField; // 0x178
		[CompilerGenerated]
		private Vector3 _trackedDevicePosition_k__BackingField; // 0x17C
		[CompilerGenerated]
		private Quaternion _trackedDeviceOrientation_k__BackingField; // 0x188
	
		// Properties
		public InputControl control { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D8F0-0x0000000184D8D900 0x0000000186B8B288-0x0000000186B8B29C
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DF00-0x0000000184D8DF10 0x0000000186B8B954-0x0000000186B8B968
		public int touchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D903B0-0x0000000184D903C0 0x0000000184D90430-0x0000000184D90440
		public UIPointerType pointerType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAC1F0-0x0000000184DAC200 0x0000000184DAC230-0x0000000184DAC240
		public int uiToolkitPointerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA2300-0x0000000184DA2310 0x0000000184DA6C50-0x0000000184DA6C60
		public Vector3 trackedDevicePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAC210-0x0000000184DAC230 0x0000000184DAC250-0x0000000184DAC270
		public Quaternion trackedDeviceOrientation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAC200-0x0000000184DAC210 0x0000000184DAC240-0x0000000184DAC250
	
		// Constructors
		public ExtendedPointerEventData(EventSystem eventSystem); // 0x0000000185397DC4-0x0000000185397DCC
	
		// Methods
		public override string ToString(); // 0x000000018B220A84-0x000000018B220F08
		internal static int MakePointerIdForTouch(int deviceId, int touchId); // 0x0000000184DAC1E0-0x0000000184DAC1F0
		internal static int TouchIdFromPointerId(int pointerId); // 0x0000000184D94BA0-0x0000000184D94BB0
		internal void ReadDeviceState(); // 0x00000001833F54E0-0x00000001833F5600
		private static int GetPenPointerId(Pen pen); // 0x000000018B2207F4-0x000000018B2209A8
		private static int GetTouchPointerId(TouchControl touchControl); // 0x000000018B2209A8-0x000000018B220A84
	}

	public enum UIPointerType // TypeDefIndex: 47622
	{
		None = 0,
		MouseOrPen = 1,
		Touch = 2,
		Tracked = 3
	}

	public enum UIPointerBehavior // TypeDefIndex: 47623
	{
		SingleMouseOrPenButMultiTouchAndTrack = 0,
		SingleUnifiedPointer = 1,
		AllPointersAsIs = 2
	}

	internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData // TypeDefIndex: 47624
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x20
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Constructors
		public ExtendedSubmitCancelEventData(EventSystem eventSystem); // 0x0000000185392C40-0x0000000185392C50
	}

	internal interface INavigationEventData // TypeDefIndex: 47625
	{
		// Properties
		UnityEngine.InputSystem.InputDevice device { get; }
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#setting-up-ui-input")]
	public class InputSystemUIInputModule : BaseInputModule // TypeDefIndex: 47628
	{
		// Fields
		private const float kClickSpeed = 0.3f; // Metadata: 0x0232A53B
		[FormerlySerializedAs("m_RepeatDelay")]
		[SerializeField]
		[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
		private float m_MoveRepeatDelay; // 0x48
		[FormerlySerializedAs("m_RepeatRate")]
		[SerializeField]
		[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
		private float m_MoveRepeatRate; // 0x4C
		[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
		private float m_TrackedDeviceDragThresholdMultiplier; // 0x50
		[SerializeField]
		[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig\'s Transform.")]
		private Transform m_XRTrackingOrigin; // 0x58
		private static DefaultInputActions defaultActions; // 0x00
		[HideInInspector]
		[SerializeField]
		private InputActionAsset m_ActionsAsset; // 0x60
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_PointAction; // 0x68
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_MoveAction; // 0x70
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_SubmitAction; // 0x78
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_CancelAction; // 0x80
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_LeftClickAction; // 0x88
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_MiddleClickAction; // 0x90
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_RightClickAction; // 0x98
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_ScrollWheelAction; // 0xA0
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_TrackedDevicePositionAction; // 0xA8
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_TrackedDeviceOrientationAction; // 0xB0
		[SerializeField]
		private bool m_DeselectOnBackgroundClick; // 0xB8
		[SerializeField]
		private UIPointerBehavior m_PointerBehavior; // 0xBC
		[HideInInspector]
		[SerializeField]
		internal CursorLockBehavior m_CursorLockBehavior; // 0xC0
		[SerializeField]
		private float m_ScrollDeltaPerTick; // 0xC4
		private static Dictionary<InputAction, InputActionReferenceState> s_InputActionReferenceCounts; // 0x08
		[NonSerialized]
		private bool m_ActionsHooked; // 0xC8
		[NonSerialized]
		private bool m_NeedToPurgeStalePointers; // 0xC9
		private Action<InputAction.CallbackContext> m_OnPointDelegate; // 0xD0
		private Action<InputAction.CallbackContext> m_OnMoveDelegate; // 0xD8
		private Action<InputAction.CallbackContext> m_OnSubmitCancelDelegate; // 0xE0
		private Action<InputAction.CallbackContext> m_OnLeftClickDelegate; // 0xE8
		private Action<InputAction.CallbackContext> m_OnRightClickDelegate; // 0xF0
		private Action<InputAction.CallbackContext> m_OnMiddleClickDelegate; // 0xF8
		private Action<InputAction.CallbackContext> m_OnScrollWheelDelegate; // 0x100
		private Action<InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate; // 0x108
		private Action<InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate; // 0x110
		private Action<object> m_OnControlsChangedDelegate; // 0x118
		[NonSerialized]
		private int m_CurrentPointerId; // 0x120
		[NonSerialized]
		private int m_CurrentPointerIndex; // 0x124
		[NonSerialized]
		internal UIPointerType m_CurrentPointerType; // 0x128
		internal InlinedArray<int> m_PointerIds; // 0x130
		internal InlinedArray<PointerModel> m_PointerStates; // 0x140
		private NavigationModel m_NavigationState; // 0x358
		private SubmitCancelModel m_SubmitCancelState; // 0x380
		[NonSerialized]
		private GameObject m_LocalMultiPlayerRoot; // 0x390
	
		// Properties
		public bool deselectOnBackgroundClick { get; set; } // 0x0000000184D892C0-0x0000000184D892D0 0x0000000184D89320-0x0000000184D89330
		public UIPointerBehavior pointerBehavior { get; set; } // 0x0000000184DA32C0-0x0000000184DA32D0 0x0000000184DA3360-0x0000000184DA3370
		public CursorLockBehavior cursorLockBehavior { get; set; } // 0x0000000184DA4B70-0x0000000184DA4B80 0x0000000184DA5DC0-0x0000000184DA5DD0
		internal GameObject localMultiPlayerRoot { get; set; } // 0x0000000184D8DD80-0x0000000184D8DD90 0x0000000186B8B79C-0x0000000186B8B7B0
		public float scrollDeltaPerTick { get; set; } // 0x0000000184D9E380-0x0000000184D9E390 0x0000000184D9E510-0x0000000184D9E520
		public float moveRepeatDelay { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float moveRepeatRate { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		private bool explictlyIgnoreFocus { get; } // 0x00000001833F2090-0x00000001833F20D0 
		private bool shouldIgnoreFocus { get; } // 0x00000001833F2030-0x00000001833F2090 
		[Obsolete("\'repeatRate\' has been obsoleted; use \'moveRepeatRate\' instead. (UnityUpgradable) -> moveRepeatRate", false)]
		public float repeatRate { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		[Obsolete("\'repeatDelay\' has been obsoleted; use \'moveRepeatDelay\' instead. (UnityUpgradable) -> moveRepeatDelay", false)]
		public float repeatDelay { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public Transform xrTrackingOrigin { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public float trackedDeviceDragThresholdMultiplier { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public InputActionReference point { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018B223934-0x000000018B223968
		public InputActionReference scrollWheel { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x000000018B2239A0-0x000000018B2239D8
		public InputActionReference leftClick { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x000000018B223890-0x000000018B2238C8
		public InputActionReference middleClick { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x000000018B2238C8-0x000000018B223900
		public InputActionReference rightClick { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x000000018B223968-0x000000018B2239A0
		public InputActionReference move { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x000000018B223900-0x000000018B223934
		public InputActionReference submit { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x000000018B2239D8-0x000000018B223A0C
		public InputActionReference cancel { get; set; } // 0x0000000184D86260-0x0000000184D86270 0x000000018B223858-0x000000018B223890
		public InputActionReference trackedDeviceOrientation { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018B223A0C-0x000000018B223A44
		public InputActionReference trackedDevicePosition { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x000000018B223A44-0x000000018B223A7C
		[Obsolete("\'trackedDeviceSelect\' has been obsoleted; use \'leftClick\' instead.", true)]
		public InputActionReference trackedDeviceSelect { get; set; } // 0x000000018B22364C-0x000000018B223698 0x000000018B223A7C-0x000000018B223AC8
		public InputActionAsset actionsAsset { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x000000018B223698-0x000000018B223858
		private bool sendPointerHoverToParent { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		private struct InputActionReferenceState // TypeDefIndex: 47626
		{
			// Fields
			public int refCount; // 0x00
			public bool enabledByInputModule; // 0x04
		}
	
		public enum CursorLockBehavior // TypeDefIndex: 47627
		{
			OutsideScreen = 0,
			ScreenCenter = 1
		}
	
		// Constructors
		public InputSystemUIInputModule(); // 0x000000018445D490-0x000000018445D4D0
		static InputSystemUIInputModule(); // 0x0000000184D126D0-0x0000000184D12770
	
		// Methods
		public override void ActivateModule(); // 0x0000000183E9A360-0x0000000183E9A450
		public override bool IsPointerOverGameObject(int pointerOrTouchId); // 0x000000018B222814-0x000000018B222938
		public RaycastResult GetLastRaycastResult(int pointerOrTouchId); // 0x000000018B222458-0x000000018B222550
		private RaycastResult PerformRaycast(ExtendedPointerEventData eventData); // 0x00000001833F31A0-0x00000001833F34A0
		private void ProcessPointer(ref PointerModel state); // 0x00000001833F2AB0-0x00000001833F2DE0
		private bool PointerShouldIgnoreTransform(Transform t); // 0x00000001833EF9F0-0x00000001833EFA30
		private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData); // 0x00000001833F3670-0x00000001833F36C0
		private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget); // 0x00000001833F2120-0x00000001833F2A80
		private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData); // 0x00000001833F13A0-0x00000001833F1B80
		private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData); // 0x00000001833F1CB0-0x00000001833F1F30
		private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData); // 0x0000000184073080-0x0000000184073100
		internal void ProcessNavigation(ref NavigationModel navigationState); // 0x00000001833F5600-0x00000001833F58E0
		private bool IsMoveAllowed(AxisEventData eventData); // 0x000000018B22265C-0x000000018B222814
		private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback); // 0x000000018B223074-0x000000018B223320
		public void AssignDefaultActions(); // 0x000000018B221F24-0x000000018B2222EC
		public void UnassignActions(); // 0x000000018B223498-0x000000018B2235AC
		protected override void Awake(); // 0x0000000184D831F0-0x0000000184D83200
		protected override void OnDestroy(); // 0x000000018B222938-0x000000018B222940
		protected override void OnEnable(); // 0x0000000183DFA6E0-0x0000000183DFA810
		protected override void OnDisable(); // 0x000000018B222940-0x000000018B2229DC
		private void ResetPointers(); // 0x0000000183DFA810-0x0000000183DFA850
		private bool HasNoActions(); // 0x0000000183DFA8B0-0x0000000183DFA950
		private void EnableAllActions(); // 0x0000000183DFC030-0x0000000183DFC0F0
		private void DisableAllActions(); // 0x000000018B222384-0x000000018B222458
		private void EnableInputAction(InputActionReference inputActionReference); // 0x0000000183DFC0F0-0x0000000183DFC250
		private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false /* Metadata: 0x0232A539 */); // 0x000000018B223320-0x000000018B223498
		private int GetPointerStateIndexFor(int pointerOrTouchId); // 0x000000018B222550-0x000000018B22265C
		private ref PointerModel GetPointerStateForIndex(int index); // 0x00000001833F3B00-0x00000001833F3B20
		private int GetDisplayIndexFor(InputControl control); // 0x0000000183526D80-0x0000000183526E10
		private int GetPointerStateIndexFor(ref InputAction.CallbackContext context); // 0x0000000183526A90-0x0000000183526B00
		private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true /* Metadata: 0x0232A53A */); // 0x0000000183526B50-0x0000000183526D80
		private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, UnityEngine.InputSystem.InputDevice device, InputControl touchControl = null); // 0x00000001848BA810-0x00000001848BAA20
		private bool SendPointerExitEventsAndRemovePointer(int index); // 0x000000018B222FA8-0x000000018B223074
		private bool RemovePointerAtIndex(int index); // 0x000000018B222D08-0x000000018B222FA8
		private void PurgeStalePointers(); // 0x0000000183DFA950-0x0000000183DFAA20
		private static bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, InputActionReference actionReference); // 0x0000000183DFB300-0x0000000183DFB3C0
		private void OnPointCallback(InputAction.CallbackContext context); // 0x0000000183526E10-0x0000000183526F00
		private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed); // 0x00000001835269C0-0x0000000183526A00
		private void OnLeftClickCallback(InputAction.CallbackContext context); // 0x0000000183526A00-0x0000000183526A90
		private void OnRightClickCallback(InputAction.CallbackContext context); // 0x00000001835264C0-0x0000000183526550
		private void OnMiddleClickCallback(InputAction.CallbackContext context); // 0x000000018B2229DC-0x000000018B222A6C
		private bool CheckForRemovedDevice(ref InputAction.CallbackContext context); // 0x0000000183529820-0x0000000183529860
		private void OnScrollCallback(InputAction.CallbackContext context); // 0x000000018B222B00-0x000000018B222BA8
		private void OnMoveCallback(InputAction.CallbackContext context); // 0x000000018B222A6C-0x000000018B222B00
		private void OnSubmitCancelCallback(InputAction.CallbackContext context); // 0x000000018B222BA8-0x000000018B222BE8
		private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context); // 0x000000018B222BE8-0x000000018B222C74
		private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context); // 0x000000018B222C74-0x000000018B222D08
		private void OnControlsChanged(object obj); // 0x0000000184D85900-0x0000000184D85910
		private void FilterPointerStatesByType(); // 0x00000001833F3880-0x00000001833F3B00
		public override void Process(); // 0x00000001833F36C0-0x00000001833F3880
		public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData); // 0x000000018B2222EC-0x000000018B222384
		private void HookActions(); // 0x0000000183DF9E00-0x0000000183DFA160
		private void UnhookActions(); // 0x000000018B2235AC-0x000000018B2235C0
		private void SetActionCallbacks(bool install); // 0x0000000183DFC250-0x0000000183DFC3C0
		private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install); // 0x0000000183DFC3C0-0x0000000183DFC4B0
		private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference); // 0x000000018B2235C0-0x000000018B22364C
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#multiplayer-uis")]
	public class MultiplayerEventSystem : EventSystem // TypeDefIndex: 47629
	{
		// Fields
		[SerializeField]
		[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
		private GameObject m_PlayerRoot; // 0x50
	
		// Properties
		public GameObject playerRoot { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018B223F48-0x000000018B223F6C
	
		// Constructors
		public MultiplayerEventSystem(); // 0x000000018B223EFC-0x000000018B223F48
	
		// Methods
		protected override void OnEnable(); // 0x000000018B223E28-0x000000018B223E48
		protected override void OnDisable(); // 0x000000018B223E20-0x000000018B223E28
		private void InitializePlayerRoot(); // 0x000000018B223D6C-0x000000018B223E20
		protected override void Update(); // 0x000000018B223E48-0x000000018B223EFC
	}

	internal struct NavigationModel // TypeDefIndex: 47630
	{
		// Fields
		public Vector2 move; // 0x00
		public int consecutiveMoveCount; // 0x08
		public MoveDirection lastMoveDirection; // 0x0C
		public float lastMoveTime; // 0x10
		public AxisEventData eventData; // 0x18
		public UnityEngine.InputSystem.InputDevice device; // 0x20
	
		// Methods
		public void Reset(); // 0x00000001853982E0-0x00000001853982F0
	}

	internal struct SubmitCancelModel // TypeDefIndex: 47631
	{
		// Fields
		public BaseEventData eventData; // 0x00
		public UnityEngine.InputSystem.InputDevice device; // 0x08
	}

	internal struct PointerModel // TypeDefIndex: 47633
	{
		// Fields
		public bool changedThisFrame; // 0x00
		public ButtonState leftButton; // 0x08
		public ButtonState rightButton; // 0x98
		public ButtonState middleButton; // 0x128
		public ExtendedPointerEventData eventData; // 0x1B8
		private Vector2 m_ScreenPosition; // 0x1C0
		private Vector2 m_ScrollDelta; // 0x1C8
		private Vector3 m_WorldPosition; // 0x1D0
		private Quaternion m_WorldOrientation; // 0x1DC
		private float m_Pressure; // 0x1EC
		private float m_AzimuthAngle; // 0x1F0
		private float m_AltitudeAngle; // 0x1F4
		private float m_Twist; // 0x1F8
		private Vector2 m_Radius; // 0x1FC
	
		// Properties
		public UIPointerType pointerType { get; } // 0x00000001833F3B20-0x00000001833F3B50 
		public Vector2 screenPosition { get; set; } // 0x0000000184DAC2F0-0x0000000184DAC310 0x0000000183526B00-0x0000000183526B50
		public Vector3 worldPosition { get; set; } // 0x0000000184D911E0-0x0000000184D91200 0x000000018B226CAC-0x000000018B226D28
		public Quaternion worldOrientation { get; set; } // 0x0000000184DAC330-0x0000000184DAC340 0x000000018B226C60-0x000000018B226CAC
		public Vector2 scrollDelta { get; set; } // 0x0000000184DAC310-0x0000000184DAC330 0x00000001833F3BD0-0x00000001833F3C20
		public float pressure { get; set; } // 0x0000000184DAC2C0-0x0000000184DAC2D0 0x00000001833F3D70-0x00000001833F3D90
		public float azimuthAngle { get; set; } // 0x0000000184D92930-0x0000000184D92940 0x00000001833F3D50-0x00000001833F3D70
		public float altitudeAngle { get; set; } // 0x0000000184D92920-0x0000000184D92930 0x00000001833F3D30-0x00000001833F3D50
		public float twist { get; set; } // 0x0000000184D911D0-0x0000000184D911E0 0x00000001833F3D10-0x00000001833F3D30
		public Vector2 radius { get; set; } // 0x0000000184DAC2D0-0x0000000184DAC2F0 0x00000001833F3D90-0x00000001833F4C20
	
		// Nested types
		public struct ButtonState // TypeDefIndex: 47632
		{
			// Fields
			private bool m_IsPressed; // 0x00
			private PointerEventData.FramePressState m_FramePressState; // 0x04
			private float m_PressTime; // 0x08
			private RaycastResult m_PressRaycast; // 0x10
			private GameObject m_PressObject; // 0x58
			private GameObject m_RawPressObject; // 0x60
			private GameObject m_LastPressObject; // 0x68
			private GameObject m_DragObject; // 0x70
			private Vector2 m_PressPosition; // 0x78
			private float m_ClickTime; // 0x80
			private int m_ClickCount; // 0x84
			private bool m_Dragging; // 0x88
			private bool m_ClickedOnSameGameObject; // 0x89
			private bool m_IgnoreNextClick; // 0x8A
	
			// Properties
			public bool isPressed { get; set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000183526970-0x00000001835269C0
			public bool ignoreNextClick { get; set; } // 0x0000000184D890B0-0x0000000184D890C0 0x0000000184DA9BE0-0x0000000184DA9BF0
			public float pressTime { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DAC1D0-0x0000000184DAC1E0
			public bool clickedOnSameGameObject { get; set; } // 0x0000000184D89060-0x0000000184D89070 0x0000000184D90C50-0x0000000184D90C60
			public bool wasPressedThisFrame { get; } // 0x00000001833F1BA0-0x00000001833F1BC0 
			public bool wasReleasedThisFrame { get; } // 0x00000001833F1B80-0x00000001833F1BA0 
	
			// Methods
			public void CopyPressStateTo(PointerEventData eventData); // 0x00000001833F2DE0-0x00000001833F30B0
			public void CopyPressStateFrom(PointerEventData eventData); // 0x00000001833F1BC0-0x00000001833F1CB0
			public void OnEndFrame(); // 0x0000000184DAC1C0-0x0000000184DAC1D0
		}
	
		// Constructors
		public PointerModel(ExtendedPointerEventData eventData); // 0x00000001848BAA20-0x00000001848BAB60
	
		// Methods
		public void OnFrameFinished(); // 0x00000001833F3B50-0x00000001833F3BD0
		public void CopyTouchOrPenStateFrom(PointerEventData eventData); // 0x00000001833F3C20-0x00000001833F3D10
	}

	[AddComponentMenu("Event/Tracked Device Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class TrackedDeviceRaycaster : BaseRaycaster // TypeDefIndex: 47636
	{
		// Fields
		[NonSerialized]
		private List<RaycastHitData> m_RaycastResultsCache; // 0x20
		internal static InlinedArray<TrackedDeviceRaycaster> s_Instances; // 0x00
		private static readonly List<RaycastHitData> s_SortedGraphics; // 0x18
		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics; // 0x28
		[FormerlySerializedAs("checkFor2DOcclusion")]
		[SerializeField]
		private bool m_CheckFor2DOcclusion; // 0x29
		[FormerlySerializedAs("checkFor3DOcclusion")]
		[SerializeField]
		private bool m_CheckFor3DOcclusion; // 0x2A
		[SerializeField]
		[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
		private float m_MaxDistance; // 0x2C
		[SerializeField]
		private LayerMask m_BlockingMask; // 0x30
		[NonSerialized]
		private Canvas m_Canvas; // 0x38
	
		// Properties
		public override Camera eventCamera { get; } // 0x000000018B228E64-0x000000018B228ED8 
		public LayerMask blockingMask { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public bool checkFor3DOcclusion { get; set; } // 0x0000000184D86CA0-0x0000000184D86CB0 0x0000000184D86CD0-0x0000000184D86CE0
		public bool checkFor2DOcclusion { get; set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		public bool ignoreReversedGraphics { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public float maxDistance { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
		private Canvas canvas { get; } // 0x000000018B228DE0-0x000000018B228E64 
	
		// Nested types
		private struct RaycastHitData // TypeDefIndex: 47634
		{
			// Fields
			[CompilerGenerated]
			private readonly Graphic _graphic_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly Vector3 _worldHitPosition_k__BackingField; // 0x08
			[CompilerGenerated]
			private readonly Vector2 _screenPosition_k__BackingField; // 0x14
			[CompilerGenerated]
			private readonly float _distance_k__BackingField; // 0x1C
	
			// Properties
			public Graphic graphic { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000182B76770-0x0000000182B76780 
			public Vector3 worldHitPosition { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D9C4D0-0x0000000184D9C4F0 
			public Vector2 screenPosition { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D96410-0x0000000184D96430 
			public float distance { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000184D868F0-0x0000000184D86900 
	
			// Constructors
			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance); // 0x000000018B226D28-0x000000018B226D64
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47635
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RaycastHitData> __9__25_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B2290F0-0x000000018B229154
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortedRaycastGraphics_b__25_0(RaycastHitData g1, RaycastHitData g2); // 0x000000018B2290A8-0x000000018B2290F0
		}
	
		// Constructors
		public TrackedDeviceRaycaster(); // 0x000000018B228D58-0x000000018B228DE0
		static TrackedDeviceRaycaster(); // 0x000000018B228CC4-0x000000018B228D58
	
		// Methods
		protected override void OnEnable(); // 0x000000018B227E30-0x000000018B227EA0
		protected override void OnDisable(); // 0x000000018B227D68-0x000000018B227E30
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018B228860-0x000000018B2288D4
		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018B227EA0-0x000000018B228374
		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results); // 0x000000018B2288D4-0x000000018B228CC4
		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance); // 0x000000018B228374-0x000000018B228860
	}

	[AddComponentMenu("Input/Virtual Mouse")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#virtual-mouse-cursor-control")]
	public class VirtualMouseInput : MonoBehaviour // TypeDefIndex: 47638
	{
		// Fields
		[Header("Cursor")]
		[SerializeField]
		[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by \'Cursor Graphic\') will be hidden.")]
		private CursorMode m_CursorMode; // 0x18
		[SerializeField]
		[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see \'Cursor Mode\') is used.")]
		private Graphic m_CursorGraphic; // 0x20
		[SerializeField]
		[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see \'Cursor Mode\'). Moving the cursor updates the anchored position of the transform.")]
		private RectTransform m_CursorTransform; // 0x28
		[Header("Motion")]
		[SerializeField]
		[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from \'Stick Action\'.")]
		private float m_CursorSpeed; // 0x30
		[SerializeField]
		[Tooltip("Scale factor to apply to \'Scroll Wheel Action\' when setting the mouse \'scrollWheel\' control.")]
		private float m_ScrollSpeed; // 0x34
		[SerializeField]
		[Space(10f)]
		[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
		private InputActionProperty m_StickAction; // 0x38
		[SerializeField]
		[Tooltip("Button action that triggers a left-click on the mouse.")]
		private InputActionProperty m_LeftButtonAction; // 0x50
		[SerializeField]
		[Tooltip("Button action that triggers a middle-click on the mouse.")]
		private InputActionProperty m_MiddleButtonAction; // 0x68
		[SerializeField]
		[Tooltip("Button action that triggers a right-click on the mouse.")]
		private InputActionProperty m_RightButtonAction; // 0x80
		[SerializeField]
		[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
		private InputActionProperty m_ForwardButtonAction; // 0x98
		[SerializeField]
		[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
		private InputActionProperty m_BackButtonAction; // 0xB0
		[SerializeField]
		[Tooltip("Vector2 action that feeds into the mouse \'scrollWheel\' action (scaled by \'Scroll Speed\').")]
		private InputActionProperty m_ScrollWheelAction; // 0xC8
		private Canvas m_Canvas; // 0xE0
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0xE8
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0xF0
		private Action m_AfterInputUpdateDelegate; // 0xF8
		private Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x100
		private double m_LastTime; // 0x108
		private Vector2 m_LastStickValue; // 0x110
	
		// Properties
		public RectTransform cursorTransform { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public float cursorSpeed { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
		public CursorMode cursorMode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B22A3AC-0x000000018B22A490
		public Graphic cursorGraphic { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x000000018B22A388-0x000000018B22A3AC
		public float scrollSpeed { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x0000000184D88590-0x0000000184D885A0 
		public InputActionProperty stickAction { get; set; } // 0x0000000184D8F4A0-0x0000000184D8F4C0 0x000000018B22A780-0x000000018B22A838
		public InputActionProperty leftButtonAction { get; set; } // 0x0000000184D9EAA0-0x0000000184D9EAC0 0x000000018B22A548-0x000000018B22A5F0
		public InputActionProperty rightButtonAction { get; set; } // 0x0000000184DAC460-0x0000000184DAC480 0x000000018B22A698-0x000000018B22A750
		public InputActionProperty middleButtonAction { get; set; } // 0x0000000184D9D1C0-0x0000000184D9D1E0 0x000000018B22A5F0-0x000000018B22A698
		public InputActionProperty forwardButtonAction { get; set; } // 0x0000000184DAC440-0x0000000184DAC460 0x000000018B22A490-0x000000018B22A548
		public InputActionProperty backButtonAction { get; set; } // 0x0000000184DAC420-0x0000000184DAC440 0x000000018B22A2D0-0x000000018B22A388
		public InputActionProperty scrollWheelAction { get; set; } // 0x0000000184DAC480-0x0000000184DAC4A0 0x000000018B22A750-0x000000018B22A780
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 47637
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public VirtualMouseInput(); // 0x000000018B22A2AC-0x000000018B22A2D0
	
		// Methods
		protected void OnEnable(); // 0x000000018B229688-0x000000018B229AA4
		protected void OnDisable(); // 0x000000018B2293F0-0x000000018B229688
		private void TryFindCanvas(); // 0x000000018B229D94-0x000000018B229DF4
		private void TryEnableHardwareCursor(); // 0x000000018B229B9C-0x000000018B229D94
		private void UpdateMotion(); // 0x000000018B229DF4-0x000000018B22A2AC
		private void OnButtonActionTriggered(InputAction.CallbackContext context); // 0x000000018B229258-0x000000018B2293F0
		private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0232A541 */); // 0x0000000189E32E34-0x0000000189E32EA0
		private static void SetAction(ref InputActionProperty field, InputActionProperty value); // 0x000000018B229AA4-0x000000018B229B9C
		private void OnAfterInputUpdate(); // 0x000000018B229250-0x000000018B229258
	}
}

namespace UnityEngine.InputSystem.Users
{
	public struct InputUser : IEquatable<InputUser> // TypeDefIndex: 47614
	{
		// Fields
		public const uint InvalidId = 0; // Metadata: 0x0232A51E
		private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x00
		private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x08
		private uint m_Id; // 0x00
		private static GlobalState s_GlobalState; // 0x10
	
		// Properties
		public bool valid { get; } // 0x000000018B210F6C-0x000000018B211020 
		public int index { get; } // 0x000000018B210A94-0x000000018B210BC8 
		public uint id { get; } // 0x0000000182B77620-0x0000000182B77630 
		public InputUserAccountHandle? platformUserAccountHandle { get; } // 0x000000018B210DE8-0x000000018B210E7C 
		public string platformUserAccountName { get; } // 0x000000018B210EF4-0x000000018B210F6C 
		public string platformUserAccountId { get; } // 0x000000018B210E7C-0x000000018B210EF4 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> pairedDevices { get; } // 0x000000018B210D04-0x000000018B210DE8 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> lostDevices { get; } // 0x000000018B210C1C-0x000000018B210D04 
		public IInputActionCollection actions { get; } // 0x000000018B2107E0-0x000000018B210858 
		public InputControlScheme? controlScheme { get; } // 0x000000018B210984-0x000000018B210A18 
		public InputControlScheme.MatchResult controlSchemeMatch { get; } // 0x000000018B2108D4-0x000000018B210984 
		public bool hasMissingRequiredDevices { get; } // 0x000000018B210A18-0x000000018B210A94 
		public static ReadOnlyArray<InputUser> all { get; } // 0x000000018B210858-0x000000018B2108D4 
		public static int listenForUnpairedDeviceActivity { get; set; } // 0x000000018B210BC8-0x000000018B210C1C 0x000000018B21128C-0x000000018B211398
	
		// Events
		public static event Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice> onChange {
			add; // 0x000000018B210580-0x000000018B21063C
			remove; // 0x000000018B211020-0x000000018B2110DC
		}
		public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed {
			add; // 0x000000018B2106FC-0x000000018B2107E0
			remove; // 0x000000018B21119C-0x000000018B21128C
		}
		public static event Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity {
			add; // 0x000000018B21063C-0x000000018B2106FC
			remove; // 0x000000018B2110DC-0x000000018B21119C
		}
	
		// Nested types
		public struct ControlSchemeChangeSyntax // TypeDefIndex: 47607
		{
			// Fields
			internal int m_UserIndex; // 0x00
	
			// Methods
			public ControlSchemeChangeSyntax AndPairRemainingDevices(); // 0x000000018B220704-0x000000018B220754
		}
	
		[Flags]
		internal enum UserFlags // TypeDefIndex: 47608
		{
			BindToAllDevices = 1,
			UserAccountSelectionInProgress = 2
		}
	
		private struct UserData // TypeDefIndex: 47609
		{
			// Fields
			public InputUserAccountHandle? platformUserAccountHandle; // 0x00
			public string platformUserAccountName; // 0x18
			public string platformUserAccountId; // 0x20
			public int deviceCount; // 0x28
			public int deviceStartIndex; // 0x2C
			public IInputActionCollection actions; // 0x30
			public InputControlScheme? controlScheme; // 0x38
			public InputControlScheme.MatchResult controlSchemeMatch; // 0x58
			public int lostDeviceCount; // 0xA8
			public int lostDeviceStartIndex; // 0xAC
			public UserFlags flags; // 0xB0
		}
	
		private struct CompareDevicesByUserAccount : IComparer<UnityEngine.InputSystem.InputDevice> // TypeDefIndex: 47610
		{
			// Fields
			public InputUserAccountHandle platformUserAccountHandle; // 0x00
	
			// Methods
			public int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y); // 0x000000018B2205BC-0x000000018B220704
			private static InputUserAccountHandle? GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device); // 0x0000000184D8F590-0x0000000184D8F5A0
		}
	
		private struct OngoingAccountSelection // TypeDefIndex: 47611
		{
			// Fields
			public UnityEngine.InputSystem.InputDevice device; // 0x00
			public uint userId; // 0x08
		}
	
		private struct GlobalState // TypeDefIndex: 47612
		{
			// Fields
			internal int pairingStateVersion; // 0x00
			internal uint lastUserId; // 0x04
			internal int allUserCount; // 0x08
			internal int allPairedDeviceCount; // 0x0C
			internal int allLostDeviceCount; // 0x10
			internal InputUser[] allUsers; // 0x18
			internal UserData[] allUserData; // 0x20
			internal UnityEngine.InputSystem.InputDevice[] allPairedDevices; // 0x28
			internal UnityEngine.InputSystem.InputDevice[] allLostDevices; // 0x30
			internal InlinedArray<OngoingAccountSelection> ongoingAccountSelections; // 0x38
			internal CallbackArray<Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice>> onChange; // 0x58
			internal CallbackArray<Action<InputControl, InputEventPtr>> onUnpairedDeviceUsed; // 0xA8
			internal CallbackArray<Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed; // 0xF8
			internal Action<object, InputActionChange> actionChangeDelegate; // 0x148
			internal Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChangeDelegate; // 0x150
			internal Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x158
			internal bool onActionChangeHooked; // 0x160
			internal bool onDeviceChangeHooked; // 0x161
			internal bool onEventHooked; // 0x162
			internal int listenForUnpairedDeviceActivity; // 0x164
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47613
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__88_0; // 0x08
			public static Action __9__88_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B229154-0x000000018B2291B8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SaveAndResetState_b__88_0(ref GlobalState state); // 0x000000018B228ED8-0x000000018B229068
			internal void _SaveAndResetState_b__88_1(); // 0x000000018B229068-0x000000018B2290A8
		}
	
		// Constructors
		static InputUser(); // 0x000000018B2104E8-0x000000018B210580
	
		// Methods
		public override string ToString(); // 0x000000018B20E910-0x000000018B20EB34
		public void AssociateActionsWithUser(IInputActionCollection actions); // 0x000000018B20B0A4-0x000000018B20B374
		public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName); // 0x000000018B20A92C-0x000000018B20A9F4
		private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme); // 0x000000018B20EB34-0x000000018B20EDC0
		internal void FindControlScheme(string schemeName, out InputControlScheme scheme); // 0x000000018B20B51C-0x000000018B20B638
		public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme); // 0x000000018B20A780-0x000000018B20A92C
		private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme); // 0x000000018B20A398-0x000000018B20A780
		public void UnpairDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B20F2C4-0x000000018B20F3C8
		public void UnpairDevices(); // 0x000000018B20F420-0x000000018B20F634
		private static void RemoveLostDevicesForUser(int userIndex); // 0x000000018B20E16C-0x000000018B20E358
		public void UnpairDevicesAndRemoveUser(); // 0x000000018B20F3C8-0x000000018B20F420
		public static InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices(); // 0x000000018B20BB18-0x000000018B20BB88
		public static int GetUnpairedInputDevices(ref InputControlList<UnityEngine.InputSystem.InputDevice> list); // 0x000000018B20B93C-0x000000018B20BB18
		public static InputUser? FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018B20B840-0x000000018B20B93C
		public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle); // 0x000000018B20B6F8-0x000000018B20B840
		public static InputUser CreateUserWithoutPairedDevices(); // 0x000000018B20B374-0x000000018B20B3DC
		public static InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, InputUser user = default, InputUserPairingOptions options = InputUserPairingOptions.None /* Metadata: 0x0232A518 */); // 0x000000018B20D7BC-0x000000018B20DA28
		private static bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, InputUserPairingOptions options); // 0x000000018B20C01C-0x000000018B20C180
		public bool Equals(InputUser other); // 0x0000000182EED260-0x0000000182EED270
		public override bool Equals(object obj); // 0x000000018B20B4B4-0x000000018B20B51C
		public override int GetHashCode(); // 0x0000000182B77620-0x0000000182B77630
		public static bool operator ==(InputUser left, InputUser right); // 0x0000000187872540-0x0000000187872548
		public static bool operator !=(InputUser left, InputUser right); // 0x000000018AAED910-0x000000018AAED918
		private static int AddUser(); // 0x000000018B20AF28-0x000000018B20B0A4
		private static void RemoveUser(int userIndex); // 0x000000018B20E358-0x000000018B20E68C
		private static void Notify(int userIndex, InputUserChange change, UnityEngine.InputSystem.InputDevice device); // 0x000000018B20C180-0x000000018B20C424
		private static int TryFindUserIndex(uint userId); // 0x000000018B20EDC0-0x000000018B20EE6C
		private static int TryFindUserIndex(InputUserAccountHandle platformHandle); // 0x000000018B20EFA4-0x000000018B20F0B4
		private static int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device); // 0x000000018B20EE6C-0x000000018B20EFA4
		private static void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x0232A519 */, bool dontUpdateControlScheme = false /* Metadata: 0x0232A51A */); // 0x000000018B20A9F4-0x000000018B20AF28
		private static void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x0232A51B */); // 0x000000018B20DC3C-0x000000018B20E16C
		private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false /* Metadata: 0x0232A51C */); // 0x000000018B20F634-0x000000018B20FFA4
		private static long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device); // 0x000000018B20FFA4-0x000000018B2104E8
		private static long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId); // 0x000000018B20DA28-0x000000018B20DC3C
		private static bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device); // 0x000000018B20BF5C-0x000000018B20C01C
		private static void OnActionChange(object obj, InputActionChange change); // 0x000000018B20C424-0x000000018B20C4FC
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018B20C4FC-0x000000018B20CB98
		private static int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex = 0 /* Metadata: 0x0232A51D */); // 0x000000018B20B638-0x000000018B20B6F8
		private static void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018B20CB98-0x000000018B20D7BC
		internal static ISavedState SaveAndResetState(); // 0x000000018B20E6D8-0x000000018B20E910
		private static void HookIntoActionChange(); // 0x000000018B20BB88-0x000000018B20BCDC
		private static void UnhookFromActionChange(); // 0x000000018B20F0B4-0x000000018B20F188
		private static void HookIntoDeviceChange(); // 0x000000018B20BCDC-0x000000018B20BE1C
		private static void UnhookFromDeviceChange(); // 0x000000018B20F188-0x000000018B20F224
		private static void HookIntoEvents(); // 0x000000018B20BE1C-0x000000018B20BF5C
		private static void UnhookFromDeviceStateChange(); // 0x000000018B20F224-0x000000018B20F2C4
		private static void DisposeAndResetGlobalState(); // 0x000000018B20B3DC-0x000000018B20B4B4
		internal static void ResetGlobals(); // 0x000000018B20E68C-0x000000018B20E6D8
	}

	public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle> // TypeDefIndex: 47615
	{
		// Fields
		private string m_ApiName; // 0x00
		private ulong m_Handle; // 0x08
	
		// Properties
		public string apiName { get; } // 0x0000000182B76770-0x0000000182B76780 
		public ulong handle { get; } // 0x0000000184D88320-0x0000000184D88330 
	
		// Constructors
		public InputUserAccountHandle(string apiName, ulong handle); // 0x000000018B223CAC-0x000000018B223D2C
	
		// Methods
		public override string ToString(); // 0x000000018B223C00-0x000000018B223CAC
		public bool Equals(InputUserAccountHandle other); // 0x000000018B223AC8-0x000000018B223B58
		public override bool Equals(object obj); // 0x000000018B223B58-0x000000018B223BC8
		public static bool operator ==(InputUserAccountHandle left, InputUserAccountHandle right); // 0x000000018B223D2C-0x000000018B223D4C
		public static bool operator !=(InputUserAccountHandle left, InputUserAccountHandle right); // 0x000000018B223D4C-0x000000018B223D6C
		public override int GetHashCode(); // 0x000000018B223BC8-0x000000018B223C00
	}

	public enum InputUserChange // TypeDefIndex: 47616
	{
		Added = 0,
		Removed = 1,
		DevicePaired = 2,
		DeviceUnpaired = 3,
		DeviceLost = 4,
		DeviceRegained = 5,
		AccountChanged = 6,
		AccountNameChanged = 7,
		AccountSelectionInProgress = 8,
		AccountSelectionCanceled = 9,
		AccountSelectionComplete = 10,
		ControlSchemeChanged = 11,
		ControlsChanged = 12
	}

	[Flags]
	public enum InputUserPairingOptions // TypeDefIndex: 47617
	{
		None = 0,
		ForcePlatformUserAccountSelection = 1,
		ForceNoPlatformUserAccountSelection = 2,
		UnpairCurrentDevicesFromUser = 8
	}

	[Serializable]
	internal class InputUserSettings // TypeDefIndex: 47618
	{
		// Fields
		[CompilerGenerated]
		private string _customBindings_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _invertMouseX_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _invertMouseY_k__BackingField; // 0x19
		[CompilerGenerated]
		private float? _mouseSmoothing_k__BackingField; // 0x1C
		[CompilerGenerated]
		private float? _mouseSensitivity_k__BackingField; // 0x24
		[CompilerGenerated]
		private bool _invertStickX_k__BackingField; // 0x2C
		[CompilerGenerated]
		private bool _invertStickY_k__BackingField; // 0x2D
		[CompilerGenerated]
		private bool _swapSticks_k__BackingField; // 0x2E
		[CompilerGenerated]
		private bool _swapBumpers_k__BackingField; // 0x2F
		[CompilerGenerated]
		private bool _swapTriggers_k__BackingField; // 0x30
		[CompilerGenerated]
		private bool _swapDpadAndLeftStick_k__BackingField; // 0x31
		[CompilerGenerated]
		private float _vibrationStrength_k__BackingField; // 0x34
		[SerializeField]
		private string m_CustomBindings; // 0x38
	
		// Properties
		public string customBindings { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool invertMouseX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool invertMouseY { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public float? mouseSmoothing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAAC00-0x0000000184DAAC10 0x0000000184DAC2B0-0x0000000184DAC2C0
		public float? mouseSensitivity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAC2A0-0x0000000184DAC2B0 0x0000000184DA5EC0-0x0000000184DA5ED0
		public bool invertStickX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
		public bool invertStickY { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86CB0-0x0000000184D86CC0 0x0000000184D86CE0-0x0000000184D86CF0
		public bool swapSticks { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA8630-0x0000000184DA8640 0x0000000184DA8650-0x0000000184DA8660
		public bool swapBumpers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA8640-0x0000000184DA8650 0x0000000184DA8660-0x0000000184DA8670
		public bool swapTriggers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public bool swapDpadAndLeftStick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86AB0-0x0000000184D86AC0 0x0000000184D86AC0-0x0000000184D86AD0
		public float vibrationStrength { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
	
		// Constructors
		public InputUserSettings(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void Apply(IInputActionCollection actions); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine.InputSystem.Utilities
{
	public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IDisposable // TypeDefIndex: 47908
	{
		// Fields
		private bool m_SubscribedToAll; // 0x10
		private bool m_OnActionChangeHooked; // 0x11
		private InlinedArray<InputAction> m_SubscribedActions; // 0x18
		private InlinedArray<InputActionMap> m_SubscribedActionMaps; // 0x30
		private InputEventBuffer m_EventBuffer; // 0x48
		private InlinedArray<InputActionState> m_ActionMapStates; // 0x68
		private InlinedArray<InputActionState> m_ActionMapStateClones; // 0x80
		private Action<InputAction.CallbackContext> m_CallbackDelegate; // 0x98
		private Action<object, InputActionChange> m_ActionChangeDelegate; // 0xA0
	
		// Properties
		public InputEventBuffer buffer { get; } // 0x0000000184DABA00-0x0000000184DABA20 
		public int count { get; } // 0x0000000184D86790-0x0000000184D867A0 
	
		// Nested types
		public struct ActionEventPtr // TypeDefIndex: 47906
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr; // 0x08
	
			// Properties
			public InputAction action { get; } // 0x000000018B1B639C-0x000000018B1B63C8 
			public InputActionPhase phase { get; } // 0x0000000184DAB940-0x0000000184DAB950 
			public InputControl control { get; } // 0x000000018B1B63C8-0x000000018B1B6400 
			public IInputInteraction interaction { get; } // 0x000000018B1B6420-0x000000018B1B646C 
			public double time { get; } // 0x000000018B1B646C-0x000000018B1B648C 
			public double startTime { get; } // 0x0000000184DAB950-0x0000000184DAB960 
			public double duration { get; } // 0x000000018B1B6400-0x000000018B1B6420 
			public int valueSizeInBytes { get; } // 0x0000000184DAB960-0x0000000184DAB970 
	
			// Methods
			public object ReadValueAsObject(); // 0x000000018B1B5DE8-0x000000018B1B6004
			public unsafe void ReadValue(void* buffer, int bufferSize); // 0x000000018B1B6004-0x000000018B1B6100
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public override string ToString(); // 0x000000018B1B6100-0x000000018B1B639C
		}
	
		private struct Enumerator : IEnumerator<ActionEventPtr> // TypeDefIndex: 47907
		{
			// Fields
			private readonly InputActionTrace m_Trace; // 0x00
			private readonly unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer; // 0x08
			private readonly int m_EventCount; // 0x10
			private unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent; // 0x18
			private int m_CurrentIndex; // 0x20
	
			// Properties
			public ActionEventPtr Current { get; } // 0x000000018B1B7B90-0x000000018B1B7C10 
			object IEnumerator.Current { get; } // 0x000000018B1B7AEC-0x000000018B1B7B44 
	
			// Constructors
			public unsafe Enumerator(InputActionTrace trace); // 0x000000018B1B7B44-0x000000018B1B7B90
	
			// Methods
			public bool MoveNext(); // 0x000000018B1B7A9C-0x000000018B1B7AEC
			public void Reset(); // 0x0000000184DAB9B0-0x0000000184DAB9C0
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public InputActionTrace(); // 0x00000001841E1670-0x00000001841E1680
		public InputActionTrace(InputAction action); // 0x000000018B1B91F8-0x000000018B1B9264
		public InputActionTrace(InputActionMap actionMap); // 0x000000018B1B9264-0x000000018B1B92D0
	
		// Methods
		public void SubscribeToAll(); // 0x000000018B1B8970-0x000000018B1B8A28
		public void UnsubscribeFromAll(); // 0x000000018B1B8F28-0x000000018B1B8FE0
		public void SubscribeTo(InputAction action); // 0x000000018B1B8B50-0x000000018B1B8CA0
		public void SubscribeTo(InputActionMap actionMap); // 0x000000018B1B8A28-0x000000018B1B8B50
		public void UnsubscribeFrom(InputAction action); // 0x000000018B1B8FE0-0x000000018B1B9100
		public void UnsubscribeFrom(InputActionMap actionMap); // 0x000000018B1B9100-0x000000018B1B91F8
		public void RecordAction(InputAction.CallbackContext context); // 0x000000018B1B87E4-0x000000018B1B8970
		public void Clear(); // 0x000000018B1B819C-0x000000018B1B81E8
		~InputActionTrace(); // 0x000000018B1B83DC-0x000000018B1B844C
		public override string ToString(); // 0x000000018B1B8CA8-0x000000018B1B8ECC
		public void Dispose(); // 0x000000018B1B83BC-0x000000018B1B83DC
		private void DisposeInternal(); // 0x000000018B1B82B8-0x000000018B1B83BC
		public IEnumerator<ActionEventPtr> GetEnumerator(); // 0x000000018B1B844C-0x000000018B1B84CC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1B8CA0-0x000000018B1B8CA8
		private void HookOnActionChange(); // 0x000000018B1B84CC-0x000000018B1B858C
		private void UnhookOnActionChange(); // 0x000000018B1B8ECC-0x000000018B1B8F28
		private void OnActionChange(object actionOrMapOrAsset, InputActionChange change); // 0x000000018B1B858C-0x000000018B1B87E4
		private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap); // 0x000000018B1B81E8-0x000000018B1B82B8
	}

	internal static class ArrayHelpers // TypeDefIndex: 47912
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0<TValue> // TypeDefIndex: 47909
			where TValue : IEquatable<TValue>
		{
			// Fields
			public TValue secondValue;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _Merge_b__0(TValue x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0<TValue> // TypeDefIndex: 47910
		{
			// Fields
			public IEqualityComparer<TValue> comparer;
	
			// Constructors
			public __c__DisplayClass34_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_1<TValue> // TypeDefIndex: 47911
		{
			// Fields
			public TValue secondValue;
			public __c__DisplayClass34_0<TValue> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass34_1();
	
			// Methods
			internal bool _Merge_b__0(TValue x);
		}
	
		// Methods
		public static void EnsureCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x0232A8D0 */);
		public static void DuplicateWithCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x0232A8D1 */);
		public static bool Contains<TValue>(TValue[] array, TValue value);
		public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647 /* Metadata: 0x0232A8D2 */);
		public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x0232A8D3 */, int count = -1 /* Metadata: 0x0232A8D4 */);
		public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator)
			where TValue : struct;
		public static int Append<TValue>(ref ref TValue[] array, TValue value);
		public static int Append<TValue>(ref ref TValue[] array, IEnumerable<TValue> values);
		public static int AppendToImmutable<TValue>(ref ref TValue[] array, TValue[] values);
		public static int AppendWithCapacity<TValue>(ref ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x0232A8DA */);
		public static int AppendListWithCapacity<TValue, TValues>(ref ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10 /* Metadata: 0x0232A8DB */)
			where TValues : IReadOnlyList<TValue>;
		public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x0232A8DC */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A8DD */)
			where TValue : struct;
		public static void InsertAt<TValue>(ref ref TValue[] array, int index, TValue value);
		public static void InsertAtWithCapacity<TValue>(ref ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10 /* Metadata: 0x0232A8DE */);
		public static void PutAtIfNotSet<TValue>(ref ref TValue[] array, int index, Func<TValue> valueFn);
		public static int GrowBy<TValue>(ref ref TValue[] array, int count);
		public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A8DF */)
			where TValue : struct;
		public static int GrowWithCapacity<TValue>(ref ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x0232A8E0 */);
		public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x0232A8E1 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232A8E2 */)
			where TValue : struct;
		public static TValue[] Join<TValue>(TValue value, params TValue[] values);
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second)
			where TValue : IEquatable<TValue>;
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer);
		public static void EraseAt<TValue>(ref ref TValue[] array, int index);
		public static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index)
			where TValue : struct;
		public static bool Erase<TValue>(ref ref TValue[] array, TValue value);
		public static void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index);
		public static TValue[] Copy<TValue>(TValue[] array);
		public static TValue[] Clone<TValue>(TValue[] array)
			where TValue : ICloneable;
		public static TNew[] Select<TOld, TNew>(TOld[] array, Func<TOld, TNew> converter);
		private static void Swap<TValue>(ref ref TValue first, ref ref TValue second);
		public static void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count);
		public static void EraseSliceWithCapacity<TValue>(ref ref TValue[] array, ref int length, int index, int count);
	
		// Extension methods
		public static int LengthSafe<TValue>(this TValue[] array);
		public static void Clear<TValue>(this TValue[] array);
		public static void Clear<TValue>(this TValue[] array, int count);
		public static void Clear<TValue>(this TValue[] array, ref int count);
		public static bool ContainsReference<TValue>(this TValue[] array, TValue value)
			where TValue : class;
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class;
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int startIndex, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class;
		public static bool HaveDuplicateReferences<TFirst>(this TFirst[] first, int index, int count);
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate);
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate, int startIndex = 0 /* Metadata: 0x0232A8D5 */, int count = -1 /* Metadata: 0x0232A8D6 */);
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int count = -1 /* Metadata: 0x0232A8D7 */)
			where TFirst : TSecond
			where TSecond : class;
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int startIndex, int count)
			where TFirst : TSecond
			where TSecond : class;
		public static int IndexOfValue<TValue>(this TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x0232A8D8 */, int count = -1 /* Metadata: 0x0232A8D9 */)
			where TValue : struct, IEquatable<TValue>;
		public static void EraseAtWithCapacity<TValue>(this TValue[] array, ref int count, int index);
		public static void SwapElements<TValue>(this TValue[] array, int index1, int index2);
		public static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2)
			where TValue : struct;
	}

	internal struct CallbackArray<TDelegate> // TypeDefIndex: 47913
		where TDelegate : Delegate
	{
		// Fields
		private bool m_CannotMutateCallbacksArray;
		private InlinedArray<TDelegate> m_Callbacks;
		private InlinedArray<TDelegate> m_CallbacksToAdd;
		private InlinedArray<TDelegate> m_CallbacksToRemove;
	
		// Properties
		public int length { get; }
		public TDelegate this[int index] { get => default; }
	
		// Methods
		public void Clear();
		public void AddCallback(TDelegate dlg);
		public void RemoveCallback(TDelegate dlg);
		public void LockForChanges();
		public void UnlockForChanges();
	}

	public struct Vector2MagnitudeComparer : IComparer<Vector2> // TypeDefIndex: 47914
	{
		// Methods
		public int Compare(Vector2 x, Vector2 y); // 0x000000018B1C2A6C-0x000000018B1C2AC0
	}

	public struct Vector3MagnitudeComparer : IComparer<Vector3> // TypeDefIndex: 47915
	{
		// Methods
		public int Compare(Vector3 x, Vector3 y); // 0x000000018B1C2FD0-0x000000018B1C3084
	}

	internal static class CSharpCodeHelpers // TypeDefIndex: 47916
	{
		// Methods
		public static bool IsProperIdentifier(string name); // 0x000000018B1B6A50-0x000000018B1B6B04
		public static bool IsEmptyOrProperIdentifier(string name); // 0x000000018B1B697C-0x000000018B1B699C
		public static bool IsEmptyOrProperNamespaceName(string name); // 0x000000018B1B699C-0x000000018B1B6A50
		public static string MakeIdentifier(string name, string suffix = "" /* Metadata: 0x0232A8E3 */); // 0x000000018B1B6B04-0x000000018B1B6CE8
		public static string MakeTypeName(string name, string suffix = "" /* Metadata: 0x0232A8E4 */); // 0x000000018B1B6CE8-0x000000018B1B6DC4
	}

	internal static class DelegateHelpers // TypeDefIndex: 47917
	{
		// Methods
		public static void InvokeCallbacksSafe(ref CallbackArray<Action> callbacks, ProfilerMarker marker, string callbackName, object context = null); // 0x0000000182EE2F30-0x0000000182EE3370
		public static void InvokeCallbacksSafe<TValue>(ref CallbackArray<Action<TValue>> callbacks, TValue argument, string callbackName, object context = null);
		public static void InvokeCallbacksSafe<TValue1, TValue2>(ref CallbackArray<Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context = null);
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref CallbackArray<Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null);
		public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref CallbackArray<Func<TValue, Action>> callbacks, TValue argument, string callbackName, object context = null);
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref CallbackArray<Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context = null);
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class DisplayStringFormatAttribute : Attribute // TypeDefIndex: 47918
	{
		// Fields
		[CompilerGenerated]
		private string _formatString_k__BackingField; // 0x10
	
		// Properties
		public string formatString { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public DisplayStringFormatAttribute(string formatString); // 0x00000001853908C0-0x00000001853908D0
	}

	internal static class ExceptionHelpers // TypeDefIndex: 47919
	{
		// Extension methods
		public static bool IsExceptionIndicatingBugInCode(this Exception exception); // 0x000000018B1B7C10-0x000000018B1B7C94
	}

	public struct FourCC : IEquatable<FourCC> // TypeDefIndex: 47920
	{
		// Fields
		private int m_Code; // 0x00
	
		// Constructors
		public FourCC(int code); // 0x0000000184D86140-0x0000000184D86150
		public FourCC(char a, char b = ' ' /* Metadata: 0x0232A8E5 */, char c = ' ' /* Metadata: 0x0232A8E7 */, char d = ' ' /* Metadata: 0x0232A8E9 */); // 0x0000000184DAB9C0-0x0000000184DAB9F0
		public FourCC(string str); // 0x000000018B1B7E6C-0x000000018B1B8008
	
		// Methods
		public static implicit operator int(FourCC fourCC); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static implicit operator FourCC(int i); // 0x0000000184D88BE0-0x0000000184D88BF0
		public override string ToString(); // 0x000000018B1B7CF0-0x000000018B1B7E6C
		public bool Equals(FourCC other); // 0x0000000182EED260-0x0000000182EED270
		public override bool Equals(object obj); // 0x000000018B1B7C94-0x000000018B1B7CF0
		public override int GetHashCode(); // 0x0000000182B77620-0x0000000182B77630
		public static bool operator ==(FourCC left, FourCC right); // 0x0000000187872540-0x0000000187872548
		public static bool operator !=(FourCC left, FourCC right); // 0x000000018AAED910-0x000000018AAED918
		public static FourCC FromInt32(int i); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static int ToInt32(FourCC fourCC); // 0x0000000184D88BE0-0x0000000184D88BF0
	}

	internal struct InlinedArray<TValue> : IEnumerable<TValue> // TypeDefIndex: 47922
	{
		// Fields
		public int length;
		public TValue firstValue;
		public TValue[] additionalValues;
	
		// Properties
		public int Capacity { get; }
		public TValue this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 47921
		{
			// Fields
			public InlinedArray<TValue> array;
			public int index;
	
			// Properties
			public TValue Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		public InlinedArray(TValue value);
		public InlinedArray(TValue firstValue, params TValue[] additionalValues);
		public InlinedArray(IEnumerable<TValue> values);
	
		// Methods
		public void Clear();
		public void ClearWithCapacity();
		public InlinedArray<TValue> Clone();
		public void SetLength(int size);
		public TValue[] ToArray();
		public TOther[] ToArray<TOther>(Func<TValue, TOther> mapFunction);
		public int IndexOf(TValue value);
		public int Append(TValue value);
		public int AppendWithCapacity(TValue value, int capacityIncrement = 10 /* Metadata: 0x0232A8EB */);
		public void AssignWithCapacity(InlinedArray<TValue> values);
		public void Append(IEnumerable<TValue> values);
		public void Remove(TValue value);
		public void RemoveAtWithCapacity(int index);
		public void RemoveAt(int index);
		public void RemoveAtByMovingTailWithCapacity(int index);
		public bool RemoveByMovingTailWithCapacity(TValue value);
		public bool Contains(TValue value, IEqualityComparer<TValue> comparer);
		public void Merge(InlinedArray<TValue> other);
		public IEnumerator<TValue> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal static class InputArrayExtensions // TypeDefIndex: 47923
	{
		// Extension methods
		public static int IndexOfReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class;
		public static bool Contains<TValue>(this InlinedArray<TValue> array, TValue value);
		public static bool ContainsReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class;
	}

	public struct InternedString : IEquatable<InternedString>, IComparable<InternedString> // TypeDefIndex: 47924
	{
		// Fields
		private readonly string m_StringOriginalCase; // 0x00
		private readonly string m_StringLowerCase; // 0x08
	
		// Properties
		public int length { get; } // 0x000000018B1BEB0C-0x000000018B1BEB1C 
	
		// Constructors
		public InternedString(string text); // 0x0000000183AEEE80-0x0000000183AEEF20
	
		// Methods
		public bool IsEmpty(); // 0x0000000183AEF200-0x0000000183AEF210
		public string ToLower(); // 0x0000000184D88320-0x0000000184D88330
		public override bool Equals(object obj); // 0x000000018B1BEA44-0x000000018B1BEB0C
		public bool Equals(InternedString other); // 0x0000000183AECB80-0x0000000183AECB90
		public int CompareTo(InternedString other); // 0x000000018B1BEA2C-0x000000018B1BEA44
		public override int GetHashCode(); // 0x0000000183AF1A10-0x0000000183AF1A30
		public override string ToString(); // 0x0000000183AED380-0x0000000183AED3A0
		public static bool operator ==(InternedString a, InternedString b); // 0x0000000183AECB80-0x0000000183AECB90
		public static bool operator !=(InternedString a, InternedString b); // 0x0000000183AECB70-0x0000000183AECB80
		public static bool operator ==(InternedString a, string b); // 0x000000018B1BEB98-0x000000018B1BEC14
		public static bool operator !=(InternedString a, string b); // 0x000000018B1BECB4-0x000000018B1BED30
		public static bool operator ==(string a, InternedString b); // 0x000000018B1BEB1C-0x000000018B1BEB98
		public static bool operator !=(string a, InternedString b); // 0x000000018B1BEC38-0x000000018B1BECB4
		public static bool operator <(InternedString left, InternedString right); // 0x000000018B1BED30-0x000000018B1BED54
		public static bool operator >(InternedString left, InternedString right); // 0x000000018B1BEC14-0x000000018B1BEC38
		public static implicit operator string(InternedString str); // 0x0000000185395130-0x0000000185395140
	}

	internal struct JsonParser // TypeDefIndex: 47929
	{
		// Fields
		private readonly string m_Text; // 0x00
		private readonly int m_Length; // 0x08
		private int m_Position; // 0x0C
		private bool m_MatchAnyElementInArray; // 0x10
		private bool m_DryRun; // 0x11
	
		// Properties
		public bool isAtEnd { get; } // 0x000000018B1BF65C-0x000000018B1BF668 
	
		// Nested types
		public enum JsonValueType // TypeDefIndex: 47925
		{
			None = 0,
			Bool = 1,
			Real = 2,
			Integer = 3,
			String = 4,
			Array = 5,
			Object = 6,
			Any = 7
		}
	
		public struct JsonString : IEquatable<JsonString> // TypeDefIndex: 47926
		{
			// Fields
			public Substring text; // 0x00
			public bool hasEscapes; // 0x10
	
			// Methods
			public override string ToString(); // 0x000000018B1BF8C0-0x000000018B1BF98C
			public bool Equals(JsonString other); // 0x000000018B1BF668-0x000000018B1BF7E0
			public override bool Equals(object obj); // 0x000000018B1BF7E0-0x000000018B1BF858
			public override int GetHashCode(); // 0x000000018B1BF858-0x000000018B1BF8C0
			public static bool operator ==(JsonString left, JsonString right); // 0x000000018B1BF98C-0x000000018B1BF9B8
			public static bool operator !=(JsonString left, JsonString right); // 0x000000018B1BF9F4-0x000000018B1BFA20
			public static implicit operator JsonString(string str); // 0x000000018B1BF9B8-0x000000018B1BF9F4
		}
	
		public struct JsonValue : IEquatable<JsonValue> // TypeDefIndex: 47928
		{
			// Fields
			public JsonValueType type; // 0x00
			public bool boolValue; // 0x04
			public double realValue; // 0x08
			public long integerValue; // 0x10
			public JsonString stringValue; // 0x18
			public List<JsonValue> arrayValue; // 0x30
			public Dictionary<string, JsonValue> objectValue; // 0x38
			public object anyValue; // 0x40
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 47927
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<JsonValue, string> __9__11_0; // 0x08
				public static Func<KeyValuePair<string, JsonValue>, string> __9__11_1; // 0x10
	
				// Constructors
				static __c(); // 0x000000018B1C94AC-0x000000018B1C9510
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _ToString_b__11_0(JsonValue x); // 0x000000018B1C9304-0x000000018B1C9318
				internal string _ToString_b__11_1(KeyValuePair<string, JsonValue> pair); // 0x000000018B1C9318-0x000000018B1C93BC
			}
	
			// Methods
			public bool ToBoolean(); // 0x000000018B1BFBD8-0x000000018B1BFC64
			public long ToInteger(); // 0x000000018B1BFD00-0x000000018B1BFD8C
			public double ToDouble(); // 0x000000018B1BFC64-0x000000018B1BFD00
			public override string ToString(); // 0x000000018B1BFD8C-0x000000018B1C01AC
			public static implicit operator JsonValue(bool val); // 0x0000000184DABA30-0x0000000184DABA60
			public static implicit operator JsonValue(long val); // 0x0000000184DABA60-0x0000000184DABA90
			public static implicit operator JsonValue(double val); // 0x0000000184DABA90-0x0000000184DABAC0
			public static implicit operator JsonValue(string str); // 0x000000018B1C01F0-0x000000018B1C0270
			public static implicit operator JsonValue(JsonString str); // 0x000000018B1C02B4-0x000000018B1C0300
			public static implicit operator JsonValue(List<JsonValue> array); // 0x000000018B1C01AC-0x000000018B1C01F0
			public static implicit operator JsonValue(Dictionary<string, JsonValue> obj); // 0x000000018B1C0300-0x000000018B1C0344
			public static implicit operator JsonValue(Enum val); // 0x000000018B1C0270-0x000000018B1C02B4
			public bool Equals(JsonValue other); // 0x0000000184160A50-0x0000000184160B20
			private static bool Equals(object obj, JsonValue value); // 0x0000000184160B20-0x0000000184160C10
			public override bool Equals(object obj); // 0x000000018B1BFA20-0x000000018B1BFAB8
			public override int GetHashCode(); // 0x000000018B1BFAB8-0x000000018B1BFBD8
			public static bool operator ==(JsonValue left, JsonValue right); // 0x00000001853950EC-0x0000000185395130
			public static bool operator !=(JsonValue left, JsonValue right); // 0x000000018B1C0344-0x000000018B1C0388
		}
	
		// Constructors
		public JsonParser(string json); // 0x0000000183AED3A0-0x0000000183AED3E0
	
		// Methods
		public void Reset(); // 0x0000000184DABA20-0x0000000184DABA30
		public override string ToString(); // 0x000000018B1BF590-0x000000018B1BF65C
		public bool NavigateToProperty(string path); // 0x0000000183AED7F0-0x0000000183AED9B0
		public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue); // 0x0000000183AED3E0-0x0000000183AED4D0
		public bool ParseToken(char token); // 0x0000000183AED9B0-0x0000000183AEDA20
		public bool ParseValue(); // 0x000000018B1BF4BC-0x000000018B1BF4F0
		public bool ParseValue(out JsonValue result); // 0x0000000183AED4D0-0x0000000183AED570
		public bool ParseStringValue(out JsonValue result); // 0x000000018B1BF328-0x000000018B1BF4BC
		public bool ParseArrayValue(out JsonValue result); // 0x000000018B1BED54-0x000000018B1BEFD0
		public bool ParseObjectValue(out JsonValue result); // 0x000000018B1BF120-0x000000018B1BF328
		public bool ParseNumber(out JsonValue result); // 0x0000000183AED570-0x0000000183AED7F0
		public bool ParseBooleanValue(out JsonValue result); // 0x000000018B1BEFD0-0x000000018B1BF0C8
		public bool ParseNullValue(out JsonValue result); // 0x000000018B1BF0C8-0x000000018B1BF120
		public bool SkipToValue(); // 0x0000000183AEDA20-0x0000000183AEDA70
		private bool SkipString(string text); // 0x000000018B1BF4F0-0x000000018B1BF590
		private void SkipWhitespace(); // 0x0000000183AEDA70-0x0000000183AEDAF0
	}

	internal static class MemoryHelpers // TypeDefIndex: 47931
	{
		// Nested types
		public struct BitRegion // TypeDefIndex: 47930
		{
			// Fields
			public uint bitOffset; // 0x00
			public uint sizeInBits; // 0x04
	
			// Properties
			public bool isEmpty { get; } // 0x00000001830D1700-0x00000001830D1710 
	
			// Constructors
			public BitRegion(uint bitOffset, uint sizeInBits); // 0x0000000184D85C40-0x0000000184D85C50
			public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits); // 0x0000000184DABAF0-0x0000000184DABB00
	
			// Methods
			public BitRegion Overlap(BitRegion other); // 0x00000001830D1680-0x00000001830D1700
		}
	
		// Methods
		public static unsafe bool Compare(void* ptr1, void* ptr2, BitRegion region); // 0x00000001830D19D0-0x00000001830D1A50
		public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits); // 0x000000018B1C381C-0x000000018B1C3834
		public static unsafe void WriteSingleBit(void* ptr, uint bitOffset, bool value); // 0x00000001845B0B60-0x00000001845B0B90
		public static unsafe bool ReadSingleBit(void* ptr, uint bitOffset); // 0x00000001830D1A60-0x00000001830D1A90
		public static unsafe void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount); // 0x000000018B1C3834-0x000000018B1C3924
		public static unsafe bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null); // 0x00000001830D17E0-0x00000001830D1950
		public static unsafe void MemSet(void* destination, int numBytes, byte value); // 0x000000018B1C3A1C-0x000000018B1C3AD8
		public static unsafe void MemCpyMasked(void* destination, void* source, int numBytes, void* mask); // 0x000000018B1C3924-0x000000018B1C3A1C
		public static unsafe uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018B1C3B38-0x000000018B1C3D10
		public static unsafe void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value); // 0x000000018B1C3D94-0x000000018B1C3F9C
		public static unsafe int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018B1C3D10-0x000000018B1C3D18
		public static unsafe void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value); // 0x000000018B1C3D44-0x000000018B1C3D54
		public static unsafe int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018B1C3AD8-0x000000018B1C3B04
		public static unsafe void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value); // 0x000000018B1C3D18-0x000000018B1C3D44
		public static unsafe float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018B1C3B04-0x000000018B1C3B38
		public static unsafe void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value); // 0x000000018B1C3D54-0x000000018B1C3D94
		public static unsafe void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value); // 0x0000000183AEFB90-0x0000000183AEFCB0
		public static void Swap<TValue>(ref ref TValue a, ref ref TValue b);
		public static uint AlignNatural(uint offset, uint sizeInBytes); // 0x000000018B1C37C8-0x000000018B1C381C
	}

	internal static class MiscHelpers // TypeDefIndex: 47933
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _EveryNth_d__1<TValue> : IEnumerable<TValue>, IEnumerator<TValue> // TypeDefIndex: 47932
		{
			// Fields
			private int __1__state;
			private TValue __2__current;
			private int __l__initialThreadId;
			private IEnumerable<TValue> enumerable;
			public IEnumerable<TValue> __3__enumerable;
			private int start;
			public int __3__start;
			private int n;
			public int __3__n;
			private int _index_5__2;
			private IEnumerator<TValue> __7__wrap2;
	
			// Properties
			TValue IEnumerator<TValue>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EveryNth_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Extension methods
		public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key);
		[IteratorStateMachine(typeof(_EveryNth_d__1<TValue>))]
		public static IEnumerable<TValue> EveryNth<TValue>(this IEnumerable<TValue> enumerable, int n, int start = 0 /* Metadata: 0x0232A8F4 */);
		public static int IndexOf<TValue>(this IEnumerable<TValue> enumerable, TValue value);
	}

	public struct NameAndParameters // TypeDefIndex: 47935
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x00
		[CompilerGenerated]
		private ReadOnlyArray<NamedValue> _parameters_k__BackingField; // 0x08
	
		// Properties
		public string name { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public ReadOnlyArray<NamedValue> parameters { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815AD730-0x00000001815AD740 0x000000018B1C440C-0x000000018B1C441C
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47934
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NamedValue, string> __9__8_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B1C93E4-0x000000018B1C9448
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _ToString_b__8_0(NamedValue x); // 0x000000018B1C93BC-0x000000018B1C93D0
		}
	
		// Methods
		public override string ToString(); // 0x000000018B1C41D0-0x000000018B1C440C
		public static IEnumerable<NameAndParameters> ParseMultiple(string text); // 0x000000018B1C3F9C-0x000000018B1C3FF4
		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list); // 0x000000018B1C3FF4-0x000000018B1C4148
		internal static string ParseName(string text); // 0x000000018B1C4148-0x000000018B1C41D0
		public static NameAndParameters Parse(string text); // 0x0000000183DFDEF0-0x0000000183DFDF40
		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false /* Metadata: 0x0232A8F5 */); // 0x0000000183DFDC40-0x0000000183DFDE40
	}

	public struct NamedValue : IEquatable<NamedValue> // TypeDefIndex: 47936
	{
		// Fields
		public const string Separator = ","; // Metadata: 0x0232A8F6
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x00
		[CompilerGenerated]
		private PrimitiveValue _value_k__BackingField; // 0x08
	
		// Properties
		public string name { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public PrimitiveValue value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815AD730-0x00000001815AD740 0x0000000184DA4E20-0x0000000184DA4E30
		public TypeCode type { get; } // 0x0000000184D88B10-0x0000000184D88B20 
	
		// Methods
		public NamedValue ConvertTo(TypeCode type); // 0x000000018B1C467C-0x000000018B1C46D4
		public static NamedValue From<TValue>(string name, TValue value)
			where TValue : struct;
		public override string ToString(); // 0x000000018B1C4C2C-0x000000018B1C4CA0
		public bool Equals(NamedValue other); // 0x000000018B1C46D4-0x000000018B1C4730
		public override bool Equals(object obj); // 0x000000018B1C4730-0x000000018B1C47A8
		public override int GetHashCode(); // 0x000000018B1C47A8-0x000000018B1C47F4
		public static bool operator ==(NamedValue left, NamedValue right); // 0x000000018B1C4CA0-0x000000018B1C4CCC
		public static bool operator !=(NamedValue left, NamedValue right); // 0x000000018B1C4CCC-0x000000018B1C4CF8
		public static NamedValue[] ParseMultiple(string parameterString); // 0x000000018B1C47F4-0x000000018B1C4958
		public static NamedValue Parse(string str); // 0x000000018B1C4BF0-0x000000018B1C4C2C
		private static NamedValue ParseParameter(string parameterString, ref int index); // 0x000000018B1C4958-0x000000018B1C4BF0
		public void ApplyToObject(object instance); // 0x000000018B1C441C-0x000000018B1C467C
		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters)
			where TParameterList : IEnumerable<NamedValue>;
	}

	internal static class NumberHelpers // TypeDefIndex: 47937
	{
		// Methods
		public static bool Approximately(double a, double b); // 0x000000018B1C4D44-0x000000018B1C4DE4
		public static float IntToNormalizedFloat(int value, int minValue, int maxValue); // 0x000000018B1C4DE4-0x000000018B1C4E2C
		public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue); // 0x000000018B1C4E2C-0x000000018B1C4E74
		public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue); // 0x000000018B1C4F04-0x000000018B1C4F54
		public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue); // 0x000000018B1C4E74-0x000000018B1C4EC4
		public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize); // 0x000000018B1C4EC4-0x000000018B1C4F04
	
		// Extension methods
		public static int AlignToMultipleOf(this int number, int alignment); // 0x000000018B1C4CF8-0x000000018B1C4D10
		public static long AlignToMultipleOf(this long number, long alignment); // 0x000000018B1C4D28-0x000000018B1C4D44
		public static uint AlignToMultipleOf(this uint number, uint alignment); // 0x000000018B1C4D10-0x000000018B1C4D28
	}

	internal class ForDeviceEventObservable : IObservable<InputEventPtr> // TypeDefIndex: 47939
	{
		// Fields
		private IObservable<InputEventPtr> m_Source; // 0x10
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
		private System.Type m_DeviceType; // 0x20
	
		// Nested types
		private class ForDevice : IObserver<InputEventPtr> // TypeDefIndex: 47938
		{
			// Fields
			private IObserver<InputEventPtr> m_Observer; // 0x10
			private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
			private System.Type m_DeviceType; // 0x20
	
			// Constructors
			public ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, IObserver<InputEventPtr> observer); // 0x000000018B1C3790-0x000000018B1C37C8
	
			// Methods
			public void OnCompleted(); // 0x00000001841E1670-0x00000001841E1680
			public void OnError(Exception error); // 0x000000018B1C3650-0x000000018B1C369C
			public void OnNext(InputEventPtr value); // 0x000000018B1C369C-0x000000018B1C3790
		}
	
		// Constructors
		public ForDeviceEventObservable(IObservable<InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device); // 0x000000018B1C3618-0x000000018B1C3650
	
		// Methods
		public IDisposable Subscribe(IObserver<InputEventPtr> observer); // 0x000000018B1C3560-0x000000018B1C3618
	}

	public static class Observable // TypeDefIndex: 47941
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0<TValue> // TypeDefIndex: 47940
		{
			// Fields
			public IDisposable subscription;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _CallOnce_b__0();
		}
	
		// Extension methods
		public static IObservable<TValue> Where<TValue>(this IObservable<TValue> source, Func<TValue, bool> predicate);
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> filter);
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter);
		public static IObservable<TValue> Take<TValue>(this IObservable<TValue> source, int count);
		public static IObservable<InputEventPtr> ForDevice(this IObservable<InputEventPtr> source, UnityEngine.InputSystem.InputDevice device); // 0x000000018B1C4F54-0x000000018B1C501C
		public static IObservable<InputEventPtr> ForDevice<TDevice>(this IObservable<InputEventPtr> source)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static IDisposable CallOnce<TValue>(this IObservable<TValue> source, Action<TValue> action);
		public static IDisposable Call<TValue>(this IObservable<TValue> source, Action<TValue> action);
	}

	internal class Observer<TValue> : IObserver<TValue> // TypeDefIndex: 47942
	{
		// Fields
		private Action<TValue> m_OnNext;
		private Action m_OnCompleted;
	
		// Constructors
		public Observer(Action<TValue> onNext, Action onCompleted = null);
	
		// Methods
		public void OnCompleted();
		public void OnError(Exception error);
		public void OnNext(TValue evt);
	}

	internal class SelectManyObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 47944
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, IEnumerable<TResult>> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 47943
		{
			// Fields
			private SelectManyObservable<TSource, TResult> m_Observable;
			private readonly IObserver<TResult> m_Observer;
	
			// Constructors
			public Select(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer);
	
			// Methods
			public void OnCompleted();
			public void OnError(Exception error);
			public void OnNext(TSource evt);
		}
	
		// Constructors
		public SelectManyObservable(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter);
	
		// Methods
		public IDisposable Subscribe(IObserver<TResult> observer);
	}

	internal class TakeNObservable<TValue> : IObservable<TValue> // TypeDefIndex: 47946
	{
		// Fields
		private IObservable<TValue> m_Source;
		private int m_Count;
	
		// Nested types
		private class Take : IObserver<TValue> // TypeDefIndex: 47945
		{
			// Fields
			private IObserver<TValue> m_Observer;
			private int m_Remaining;
	
			// Constructors
			public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer);
	
			// Methods
			public void OnCompleted();
			public void OnError(Exception error);
			public void OnNext(TValue evt);
		}
	
		// Constructors
		public TakeNObservable(IObservable<TValue> source, int count);
	
		// Methods
		public IDisposable Subscribe(IObserver<TValue> observer);
	}

	internal class WhereObservable<TValue> : IObservable<TValue> // TypeDefIndex: 47948
	{
		// Fields
		private readonly IObservable<TValue> m_Source;
		private readonly Func<TValue, bool> m_Predicate;
	
		// Nested types
		private class Where : IObserver<TValue> // TypeDefIndex: 47947
		{
			// Fields
			private WhereObservable<TValue> m_Observable;
			private readonly IObserver<TValue> m_Observer;
	
			// Constructors
			public Where(WhereObservable<TValue> observable, IObserver<TValue> observer);
	
			// Methods
			public void OnCompleted();
			public void OnError(Exception error);
			public void OnNext(TValue evt);
		}
	
		// Constructors
		public WhereObservable(IObservable<TValue> source, Func<TValue, bool> predicate);
	
		// Methods
		public IDisposable Subscribe(IObserver<TValue> observer);
	}

	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue> // TypeDefIndex: 47950
		where TList : IReadOnlyList<TValue>
	{
		// Fields
		private readonly bool m_IsSingle;
		private readonly TValue m_Single;
		private readonly TList m_Multiple;
	
		// Properties
		public int Count { get; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		private class Enumerator : IEnumerator<TValue> // TypeDefIndex: 47949
		{
			// Fields
			internal int m_Index;
			internal OneOrMore<TValue, TList> m_List;
	
			// Properties
			public TValue Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator();
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		public OneOrMore(TValue single);
		public OneOrMore(TList multiple);
	
		// Methods
		public static implicit operator OneOrMore<TValue, TList>(TValue single);
		public static implicit operator OneOrMore<TValue, TList>(TList multiple);
		public IEnumerator<TValue> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal struct PredictiveParser // TypeDefIndex: 47951
	{
		// Fields
		private int m_Position; // 0x00
	
		// Methods
		public void ExpectSingleChar(ReadOnlySpan<char> str, char c); // 0x0000000183A6E6D0-0x0000000183A6E710
		public int ExpectInt(ReadOnlySpan<char> str); // 0x0000000182F13A50-0x0000000182F13AF0
		public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str); // 0x0000000182F13AF0-0x0000000182F13C00
		public bool AcceptSingleChar(ReadOnlySpan<char> str, char c); // 0x0000000182F13C90-0x0000000182F13CC0
		public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output); // 0x0000000183525080-0x0000000183525170
		public void AcceptInt(ReadOnlySpan<char> str); // 0x0000000183D4EB50-0x0000000183D4EBA0
	}

	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible // TypeDefIndex: 47952
	{
		// Fields
		private TypeCode m_Type; // 0x00
		private bool m_BoolValue; // 0x04
		private char m_CharValue; // 0x04
		private byte m_ByteValue; // 0x04
		private sbyte m_SByteValue; // 0x04
		private short m_ShortValue; // 0x04
		private ushort m_UShortValue; // 0x04
		private int m_IntValue; // 0x04
		private uint m_UIntValue; // 0x04
		private long m_LongValue; // 0x04
		private ulong m_ULongValue; // 0x04
		private float m_FloatValue; // 0x04
		private double m_DoubleValue; // 0x04
	
		// Properties
		internal unsafe byte* valuePtr { get; } // 0x0000000184DABDD0-0x0000000184DABDE0 
		public TypeCode type { get; } // 0x0000000182B77620-0x0000000182B77630 
		public bool isEmpty { get; } // 0x000000018426F6A0-0x000000018426F6B0 
	
		// Constructors
		public PrimitiveValue(bool value); // 0x0000000184DABD30-0x0000000184DABD40
		public PrimitiveValue(char value); // 0x0000000184DABC90-0x0000000184DABCB0
		public PrimitiveValue(byte value); // 0x0000000184DABD60-0x0000000184DABD70
		public PrimitiveValue(sbyte value); // 0x0000000184DABC80-0x0000000184DABC90
		public PrimitiveValue(short value); // 0x0000000184DABD10-0x0000000184DABD30
		public PrimitiveValue(ushort value); // 0x0000000184DABDB0-0x0000000184DABDD0
		public PrimitiveValue(int value); // 0x0000000184DABD90-0x0000000184DABDB0
		public PrimitiveValue(uint value); // 0x0000000184DABD70-0x0000000184DABD90
		public PrimitiveValue(long value); // 0x0000000184DABCF0-0x0000000184DABD10
		public PrimitiveValue(ulong value); // 0x0000000184DABCD0-0x0000000184DABCF0
		public PrimitiveValue(float value); // 0x0000000184DABCB0-0x0000000184DABCD0
		public PrimitiveValue(double value); // 0x0000000184DABD40-0x0000000184DABD60
	
		// Methods
		public PrimitiveValue ConvertTo(TypeCode type); // 0x000000018B1C54E4-0x000000018B1C5760
		public bool Equals(PrimitiveValue other); // 0x000000018B1C5760-0x000000018B1C578C
		public override bool Equals(object obj); // 0x000000018B1C578C-0x000000018B1C593C
		public static bool operator ==(PrimitiveValue left, PrimitiveValue right); // 0x000000018B1C69C4-0x000000018B1C69E4
		public static bool operator !=(PrimitiveValue left, PrimitiveValue right); // 0x000000018B1C69E4-0x000000018B1C6A04
		public override int GetHashCode(); // 0x000000018B1C60FC-0x000000018B1C611C
		public override string ToString(); // 0x000000018B1C6568-0x000000018B1C68D4
		public static PrimitiveValue FromString(string value); // 0x000000018B1C5DBC-0x000000018B1C60FC
		public TypeCode GetTypeCode(); // 0x0000000182B77620-0x0000000182B77630
		public bool ToBoolean(IFormatProvider provider = null); // 0x000000018B1C611C-0x000000018B1C6204
		public byte ToByte(IFormatProvider provider = null); // 0x000000018B1C6204-0x000000018B1C620C
		public char ToChar(IFormatProvider provider = null); // 0x000000018B1C620C-0x000000018B1C6238
		public System.DateTime ToDateTime(IFormatProvider provider = null); // 0x000000018B1C6238-0x000000018B1C6294
		public decimal ToDecimal(IFormatProvider provider = null); // 0x000000018B1C6294-0x000000018B1C62D0
		public double ToDouble(IFormatProvider provider = null); // 0x00000001844B04E0-0x00000001844B0500
		public short ToInt16(IFormatProvider provider = null); // 0x000000018B1C6204-0x000000018B1C620C
		public int ToInt32(IFormatProvider provider = null); // 0x000000018B1C6204-0x000000018B1C620C
		public long ToInt64(IFormatProvider provider = null); // 0x000000018B1C62D0-0x000000018B1C6350
		public sbyte ToSByte(IFormatProvider provider = null); // 0x000000018B1C6204-0x000000018B1C620C
		public float ToSingle(IFormatProvider provider = null); // 0x0000000185397374-0x000000018539738C
		public string ToString(IFormatProvider provider); // 0x000000018B1C68D4-0x000000018B1C68DC
		public object ToType(System.Type conversionType, IFormatProvider provider); // 0x000000018B1C68DC-0x000000018B1C6928
		public ushort ToUInt16(IFormatProvider provider = null); // 0x000000018B1C6928-0x000000018B1C6934
		public uint ToUInt32(IFormatProvider provider = null); // 0x000000018B1C6928-0x000000018B1C6934
		public ulong ToUInt64(IFormatProvider provider = null); // 0x000000018B1C6934-0x000000018B1C69C4
		public object ToObject(); // 0x000000018B1C6350-0x000000018B1C6568
		public static PrimitiveValue From<TValue>(TValue value)
			where TValue : struct;
		public static PrimitiveValue FromObject(object value); // 0x000000018B1C593C-0x000000018B1C5DBC
		public static implicit operator PrimitiveValue(bool value); // 0x0000000184DABB00-0x0000000184DABB20
		public static implicit operator PrimitiveValue(char value); // 0x0000000184DABB40-0x0000000184DABB60
		public static implicit operator PrimitiveValue(byte value); // 0x0000000184DABB20-0x0000000184DABB40
		public static implicit operator PrimitiveValue(sbyte value); // 0x0000000184DABBE0-0x0000000184DABC00
		public static implicit operator PrimitiveValue(short value); // 0x0000000184DABB80-0x0000000184DABBA0
		public static implicit operator PrimitiveValue(ushort value); // 0x0000000184DABC20-0x0000000184DABC40
		public static implicit operator PrimitiveValue(int value); // 0x0000000184DABBA0-0x0000000184DABBC0
		public static implicit operator PrimitiveValue(uint value); // 0x0000000184DABC40-0x0000000184DABC60
		public static implicit operator PrimitiveValue(long value); // 0x0000000184DABBC0-0x0000000184DABBE0
		public static implicit operator PrimitiveValue(ulong value); // 0x0000000184DABC60-0x0000000184DABC80
		public static implicit operator PrimitiveValue(float value); // 0x0000000184DABC00-0x0000000184DABC20
		public static implicit operator PrimitiveValue(double value); // 0x0000000184DABB60-0x0000000184DABB80
		public static PrimitiveValue FromBoolean(bool value); // 0x0000000184DABB00-0x0000000184DABB20
		public static PrimitiveValue FromChar(char value); // 0x0000000184DABB40-0x0000000184DABB60
		public static PrimitiveValue FromByte(byte value); // 0x0000000184DABB20-0x0000000184DABB40
		public static PrimitiveValue FromSByte(sbyte value); // 0x0000000184DABBE0-0x0000000184DABC00
		public static PrimitiveValue FromInt16(short value); // 0x0000000184DABB80-0x0000000184DABBA0
		public static PrimitiveValue FromUInt16(ushort value); // 0x0000000184DABC20-0x0000000184DABC40
		public static PrimitiveValue FromInt32(int value); // 0x0000000184DABBA0-0x0000000184DABBC0
		public static PrimitiveValue FromUInt32(uint value); // 0x0000000184DABC40-0x0000000184DABC60
		public static PrimitiveValue FromInt64(long value); // 0x0000000184DABBC0-0x0000000184DABBE0
		public static PrimitiveValue FromUInt64(ulong value); // 0x0000000184DABC60-0x0000000184DABC80
		public static PrimitiveValue FromSingle(float value); // 0x0000000184DABC00-0x0000000184DABC20
		public static PrimitiveValue FromDouble(double value); // 0x0000000184DABB60-0x0000000184DABB80
	}

	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue> // TypeDefIndex: 47954
	{
		// Fields
		internal TValue[] m_Array;
		internal int m_StartIndex;
		internal int m_Length;
	
		// Properties
		public int Count { get; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 47953
		{
			// Fields
			private readonly TValue[] m_Array;
			private readonly int m_IndexStart;
			private readonly int m_IndexEnd;
			private int m_Index;
	
			// Properties
			public TValue Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			internal Enumerator(TValue[] array, int index, int length);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public ReadOnlyArray(TValue[] array);
		public ReadOnlyArray(TValue[] array, int index, int length);
	
		// Methods
		public TValue[] ToArray();
		public int IndexOf(Predicate<TValue> predicate);
		public Enumerator GetEnumerator();
		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public static implicit operator ReadOnlyArray<TValue>(TValue[] array);
	}

	public static class ReadOnlyArrayExtensions // TypeDefIndex: 47955
	{
		// Extension methods
		public static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : IComparable<TValue>;
		public static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class;
		public static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class;
		internal static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647 /* Metadata: 0x0232A8F8 */);
	}

	internal interface ISavedState // TypeDefIndex: 47956
	{
		// Methods
		void StaticDisposeCurrentState();
		void RestoreSavedState();
	}

	internal sealed class SavedStructState<T> : ISavedState // TypeDefIndex: 47958
		where T : struct
	{
		// Fields
		private T m_State;
		private TypedRestore m_RestoreAction;
		private Action m_StaticDisposeCurrentState;
	
		// Nested types
		public delegate void TypedRestore(ref ref T state); // TypeDefIndex: 47957; 0x00000000-0x00000000
	
		// Constructors
		internal SavedStructState(ref ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState = null);
	
		// Methods
		public void StaticDisposeCurrentState();
		public void RestoreSavedState();
	}

	internal static class SpriteUtilities // TypeDefIndex: 47959
	{
		// Methods
		public static Sprite CreateCircleSprite(int radius, Color32 colour); // 0x000000018B1C6A04-0x000000018B1C6BF4
	}

	internal static class StringHelpers // TypeDefIndex: 47962
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Tokenize_d__8 : IEnumerable<Substring>, IEnumerator<Substring> // TypeDefIndex: 47960
		{
			// Fields
			private int __1__state; // 0x10
			private Substring __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private string str; // 0x30
			public string __3__str; // 0x38
			private int _length_5__2; // 0x40
			private int _endPos_5__3; // 0x44
	
			// Properties
			Substring IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.Current { [DebuggerHidden] get; } // 0x0000000184D890C0-0x0000000184D890D0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B1C92BC-0x000000018B1C9304 
	
			// Constructors
			[DebuggerHidden]
			public _Tokenize_d__8(int __1__state); // 0x0000000186C07014-0x0000000186C07030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1C8FB0-0x000000018B1C91D4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1C9270-0x000000018B1C92BC
			[DebuggerHidden]
			IEnumerator<Substring> IEnumerable<Substring>.GetEnumerator(); // 0x000000018B1C91D4-0x000000018B1C9268
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1C9268-0x000000018B1C9270
		}
	
		[CompilerGenerated]
		private sealed class _Split_d__9 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 47961
		{
			// Fields
			private int __1__state; // 0x10
			private string __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private string str; // 0x28
			public string __3__str; // 0x30
			private Func<char, bool> predicate; // 0x38
			public Func<char, bool> __3__predicate; // 0x40
			private int _length_5__2; // 0x48
			private int _position_5__3; // 0x4C
	
			// Properties
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Split_d__9(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1C8DB8-0x000000018B1C8EB8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B1C8F64-0x000000018B1C8FB0
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018B1C8EB8-0x000000018B1C8F5C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B1C8F5C-0x000000018B1C8F64
		}
	
		// Methods
		public static string NicifyMemorySize(long numBytes); // 0x000000018B1C7308-0x000000018B1C747C
		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1 /* Metadata: 0x0232A911 */); // 0x000000018B1C6F94-0x000000018B1C7100
		public static string Join<TValue>(string separator, params TValue[] values);
		public static string Join<TValue>(IEnumerable<TValue> values, string separator);
		public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc);
		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator); // 0x0000000183AEEF90-0x0000000183AEF200
		public static int ParseInt(string str, int pos); // 0x000000018B1C747C-0x000000018B1C7504
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters); // 0x000000018B1C7AC0-0x000000018B1C7AE0
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset); // 0x000000018B1C7920-0x000000018B1C7AC0
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize); // 0x000000018B1C7600-0x000000018B1C7620
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset); // 0x000000018B1C7504-0x000000018B1C7600
		public static string ExpandTemplateString(string template, Func<string, string> mapFunc); // 0x000000018B1C6DD4-0x000000018B1C6F94
	
		// Extension methods
		public static string Escape(this string str, string chars = "\n\t\r\\\"" /* Metadata: 0x0232A8F9 */, string replacements = "ntr\\\"" /* Metadata: 0x0232A8FF */); // 0x000000018B1C6C94-0x000000018B1C6DD4
		public static string Unescape(this string str, string chars = "ntr\\\"" /* Metadata: 0x0232A905 */, string replacements = "\n\t\r\\\"" /* Metadata: 0x0232A90B */); // 0x000000018B1C7718-0x000000018B1C7854
		public static bool Contains(this string str, char ch); // 0x000000018B1C6C14-0x000000018B1C6C34
		public static bool Contains(this string str, string text, StringComparison comparison); // 0x000000018B1C6BF4-0x000000018B1C6C14
		public static string GetPlural(this string str); // 0x000000018B1C7100-0x000000018B1C727C
		public static int CountOccurrences(this string str, char ch); // 0x000000018B1C6C34-0x000000018B1C6C94
		[IteratorStateMachine(typeof(_Tokenize_d__8))]
		public static IEnumerable<Substring> Tokenize(this string str); // 0x000000018B1C76A8-0x000000018B1C7718
		[IteratorStateMachine(typeof(_Split_d__9))]
		public static IEnumerable<string> Split(this string str, Func<char, bool> predicate); // 0x000000018B1C7620-0x000000018B1C76A8
		public static bool IsPrintable(this char ch); // 0x000000018B1C72A4-0x000000018B1C7308
		public static string WithAllWhitespaceStripped(this string str); // 0x000000018B1C7854-0x000000018B1C7920
		public static bool InvariantEqualsIgnoreCase(this string left, string right); // 0x000000018B1C727C-0x000000018B1C72A4
	}

	internal struct Substring : IComparable<Substring>, IEquatable<Substring> // TypeDefIndex: 47963
	{
		// Fields
		private readonly string m_String; // 0x00
		private readonly int m_Index; // 0x08
		private readonly int m_Length; // 0x0C
	
		// Properties
		public bool isEmpty { get; } // 0x000000018B1C7F5C-0x000000018B1C7F64 
		public int length { get; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 
		public int index { get; } // 0x0000000184D88B10-0x0000000184D88B20 
		public char this[int index] { get => default; } // 0x000000018B1C7EDC-0x000000018B1C7F5C 
	
		// Constructors
		public Substring(string str); // 0x000000018B1C7E70-0x000000018B1C7EA8
		public Substring(string str, int index, int length); // 0x0000000185390898-0x00000001853908B8
		public Substring(string str, int index); // 0x000000018B1C7EA8-0x000000018B1C7EDC
	
		// Methods
		public override bool Equals(object obj); // 0x000000018B1C7BC4-0x000000018B1C7C5C
		public bool Equals(string other); // 0x000000018B1C7C80-0x000000018B1C7D10
		public bool Equals(Substring other); // 0x000000018B1C7C5C-0x000000018B1C7C80
		public bool Equals(InternedString other); // 0x000000018B1C7B54-0x000000018B1C7BC4
		public int CompareTo(Substring other); // 0x000000018B1C7AE0-0x000000018B1C7B10
		public static int Compare(Substring left, Substring right, StringComparison comparison); // 0x000000018B1C7B10-0x000000018B1C7B54
		public bool StartsWith(string str); // 0x000000018B1C7D60-0x000000018B1C7DE0
		public string Substr(int index = 0 /* Metadata: 0x0232A919 */, int length = -1 /* Metadata: 0x0232A91A */); // 0x000000018B1C7DE0-0x000000018B1C7E14
		public override string ToString(); // 0x000000018B1C7E14-0x000000018B1C7E70
		public override int GetHashCode(); // 0x000000018B1C7D10-0x000000018B1C7D60
		public static bool operator ==(Substring a, Substring b); // 0x000000018B1C7F64-0x000000018B1C7F84
		public static bool operator !=(Substring a, Substring b); // 0x000000018B1C7FE8-0x000000018B1C8008
		public static bool operator ==(Substring a, InternedString b); // 0x000000018B1C7FA8-0x000000018B1C7FC8
		public static bool operator !=(Substring a, InternedString b); // 0x000000018B1C8008-0x000000018B1C8028
		public static bool operator ==(InternedString a, Substring b); // 0x000000018B1C7F84-0x000000018B1C7FA8
		public static bool operator !=(InternedString a, Substring b); // 0x000000018B1C8028-0x000000018B1C8050
		public static implicit operator Substring(string s); // 0x000000018B1C7FC8-0x000000018B1C7FE8
	}

	internal static class TypeHelpers // TypeDefIndex: 47964
	{
		// Methods
		public static System.Type GetValueType(MemberInfo member); // 0x000000018B1C8924-0x000000018B1C8A10
		public static System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex); // 0x000000018B1C828C-0x000000018B1C85C0
	
		// Extension methods
		public static TObject As<TObject>(this object obj);
		public static bool IsInt(this TypeCode type); // 0x000000018B1C8A10-0x000000018B1C8A40
		public static string GetNiceTypeName(this System.Type type); // 0x000000018B1C85C0-0x000000018B1C8924
	}

	internal struct TypeTable // TypeDefIndex: 47966
	{
		// Fields
		public Dictionary<InternedString, System.Type> table; // 0x00
	
		// Properties
		public IEnumerable<string> names { get; } // 0x000000018B1C8C88-0x000000018B1C8DB8 
		public IEnumerable<InternedString> internedNames { get; } // 0x000000018B1C8C44-0x000000018B1C8C88 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 47965
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InternedString, string> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B1C9448-0x000000018B1C94AC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _get_names_b__2_0(InternedString x); // 0x000000018B1C93D0-0x000000018B1C93E4
		}
	
		// Methods
		public void Initialize(); // 0x0000000183DF6720-0x0000000183DF67A0
		public InternedString FindNameForType(System.Type type); // 0x000000018B1C8A40-0x000000018B1C8C44
		public void AddTypeRegistration(string name, System.Type type); // 0x0000000183DF6650-0x0000000183DF6720
		public System.Type LookupTypeRegistration(string name); // 0x0000000183DFDE40-0x0000000183DFDEF0
	}
}

namespace UnityEngine.InputSystem.XInput
{
	public interface IXboxOneRumble : IDualMotorRumble // TypeDefIndex: 47597
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
	}

	[InputControlLayout(displayName = "Xbox Controller")]
	public class XInputController : Gamepad // TypeDefIndex: 47602
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _menu_k__BackingField; // 0x210
		[CompilerGenerated]
		private ButtonControl _view_k__BackingField; // 0x218
		private bool m_HaveParsedCapabilities; // 0x220
		private DeviceSubType m_SubType; // 0x224
		private DeviceFlags m_Flags; // 0x228
	
		// Properties
		[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
		[InputControl(name = "buttonNorth", displayName = "Y")]
		[InputControl(name = "start", displayName = "Menu", alias = "menu")]
		[InputControl(name = "select", displayName = "View", alias = "view")]
		[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
		[InputControl(name = "buttonSouth", displayName = "A")]
		[InputControl(name = "buttonWest", displayName = "X")]
		[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
		[InputControl(name = "buttonEast", displayName = "B")]
		[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		public ButtonControl view { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
		public DeviceSubType subType { get; } // 0x000000018B21E57C-0x000000018B21E5AC 
		public DeviceFlags flags { get; } // 0x000000018B21E54C-0x000000018B21E57C 
	
		// Nested types
		internal enum DeviceType // TypeDefIndex: 47598
		{
			Gamepad = 0
		}
	
		public enum DeviceSubType // TypeDefIndex: 47599
		{
			Unknown = 0,
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
		public enum DeviceFlags // TypeDefIndex: 47600
		{
			ForceFeedbackSupported = 1,
			Wireless = 2,
			VoiceSupported = 4,
			PluginModulesSupported = 8,
			NoNavigation = 16
		}
	
		[Serializable]
		internal struct Capabilities // TypeDefIndex: 47601
		{
			// Fields
			public UnityEngine.InputSystem.XInput.XInputController.DeviceType type; // 0x00
			public DeviceSubType subType; // 0x04
			public DeviceFlags flags; // 0x08
		}
	
		// Constructors
		public XInputController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B21E470-0x000000018B21E4BC
		private void ParseCapabilities(); // 0x000000018B21E4BC-0x000000018B21E54C
	}

	[InputControlLayout(stateType = typeof(XInputControllerWindowsState), hideInUI = true)]
	public class XInputControllerWindows : XInputController // TypeDefIndex: 47603
	{
		// Constructors
		public XInputControllerWindows(); // 0x00000001853971D4-0x00000001853971DC
	}

	internal static class XInputSupport // TypeDefIndex: 47604
	{
		// Methods
		public static void Initialize(); // 0x0000000183DF7120-0x0000000183DF7230
	}
}

namespace UnityEngine.InputSystem.XInput.LowLevel
{
	internal struct XInputControllerWindowsState : IInputStateTypeInfo // TypeDefIndex: 47606
	{
		// Fields
		[InputControl(name = "dpad", layout = "Dpad", sizeInBits = 4, bit = 0)]
		[InputControl(name = "buttonNorth", bit = 15, displayName = "Y")]
		[InputControl(name = "buttonWest", bit = 14, displayName = "X")]
		[InputControl(name = "dpad/down", bit = 1)]
		[InputControl(name = "buttonEast", bit = 13, displayName = "B")]
		[InputControl(name = "select", bit = 5, displayName = "Select")]
		[InputControl(name = "leftStickPress", bit = 6)]
		[InputControl(name = "rightStickPress", bit = 7)]
		[InputControl(name = "leftShoulder", bit = 8)]
		[InputControl(name = "start", bit = 4, displayName = "Start")]
		[InputControl(name = "dpad/up", bit = 0)]
		[InputControl(name = "dpad/left", bit = 2)]
		[InputControl(name = "dpad/right", bit = 3)]
		[InputControl(name = "rightShoulder", bit = 9)]
		[InputControl(name = "buttonSouth", bit = 12, displayName = "A")]
		public ushort buttons; // 0x00
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger; // 0x02
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger; // 0x03
		[InputControl(name = "leftStick/down", offset = 2, format = "SHRT")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
		[InputControl(name = "leftStick/right", offset = 0, format = "SHRT")]
		[InputControl(name = "leftStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "leftStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "leftStick/up", offset = 2, format = "SHRT")]
		[InputControl(name = "leftStick/left", offset = 0, format = "SHRT")]
		public short leftStickX; // 0x04
		public short leftStickY; // 0x06
		[InputControl(name = "rightStick/right", offset = 0, format = "SHRT")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
		[InputControl(name = "rightStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "rightStick/left", offset = 0, format = "SHRT")]
		[InputControl(name = "rightStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "rightStick/up", offset = 2, format = "SHRT")]
		[InputControl(name = "rightStick/down", offset = 2, format = "SHRT")]
		public short rightStickX; // 0x08
		public short rightStickY; // 0x0A
	
		// Properties
		public FourCC format { get; } // 0x0000000184DAC1B0-0x0000000184DAC1C0 
	
		// Nested types
		public enum Button // TypeDefIndex: 47605
		{
			DPadUp = 0,
			DPadDown = 1,
			DPadLeft = 2,
			DPadRight = 3,
			Start = 4,
			Select = 5,
			LeftThumbstickPress = 6,
			RightThumbstickPress = 7,
			LeftShoulder = 8,
			RightShoulder = 9,
			A = 12,
			B = 13,
			X = 14,
			Y = 15
		}
	
		// Methods
		public XInputControllerWindowsState WithButton(Button button); // 0x0000000184DAC180-0x0000000184DAC1B0
	}
}

namespace UnityEngine.InputSystem.XR
{
	public struct PoseState : IInputStateTypeInfo // TypeDefIndex: 47568
	{
		// Fields
		internal const int kSizeInBytes = 60; // Metadata: 0x0232A4C0
		internal static readonly FourCC s_Format; // 0x00
		[InputControl(displayName = "Is Tracked", layout = "Button", sizeInBits = 8)]
		public bool isTracked; // 0x00
		[InputControl(displayName = "Tracking State", layout = "Integer")]
		public InputTrackingState trackingState; // 0x04
		[InputControl(displayName = "Position", noisy = true)]
		public Vector3 position; // 0x08
		[InputControl(displayName = "Rotation", noisy = true)]
		public Quaternion rotation; // 0x14
		[InputControl(displayName = "Velocity", noisy = true)]
		public Vector3 velocity; // 0x24
		[InputControl(displayName = "Angular Velocity", noisy = true)]
		public Vector3 angularVelocity; // 0x30
	
		// Properties
		public FourCC format { get; } // 0x000000018B219D64-0x000000018B219DB4 
	
		// Constructors
		public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity); // 0x0000000184DAC0B0-0x0000000184DAC100
		static PoseState(); // 0x000000018B219D28-0x000000018B219D64
	}

	[InputControlLayout(stateType = typeof(PoseState))]
	[UnityEngine.Scripting.Preserve]
	public class PoseControl : InputControl<PoseState> // TypeDefIndex: 47569
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _isTracked_k__BackingField; // 0x178
		[CompilerGenerated]
		private IntegerControl _trackingState_k__BackingField; // 0x180
		[CompilerGenerated]
		private Vector3Control _position_k__BackingField; // 0x188
		[CompilerGenerated]
		private QuaternionControl _rotation_k__BackingField; // 0x190
		[CompilerGenerated]
		private Vector3Control _velocity_k__BackingField; // 0x198
		[CompilerGenerated]
		private Vector3Control _angularVelocity_k__BackingField; // 0x1A0
	
		// Properties
		public ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DEE0-0x0000000184D8DEF0 0x0000000186B8B92C-0x0000000186B8B940
		public IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DD60-0x0000000184D8DD70 0x0000000186B8B774-0x0000000186B8B788
		public Vector3Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x0000000186B8B3B4-0x0000000186B8B3C8
		public QuaternionControl rotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
		public Vector3Control velocity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public Vector3Control angularVelocity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
	
		// Constructors
		public PoseControl(); // 0x000000018B219CA4-0x000000018B219D28
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B219728-0x000000018B2198D4
		public override unsafe PoseState ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B2198D4-0x000000018B219ACC
		public override unsafe void WriteValueIntoState(PoseState value, void* statePtr); // 0x000000018B219ACC-0x000000018B219CA4
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018B2194FC-0x000000018B219728
	}

	[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR HMD", canRunInBackground = true)]
	public class XRHMD : TrackedDevice // TypeDefIndex: 47570
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _leftEyePosition_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private QuaternionControl _leftEyeRotation_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private Vector3Control _rightEyePosition_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private QuaternionControl _rightEyeRotation_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private Vector3Control _centerEyePosition_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private QuaternionControl _centerEyeRotation_k__BackingField; // 0x1D8
	
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control leftEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(noisy = true)]
		public QuaternionControl leftEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl(noisy = true)]
		public Vector3Control rightEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(noisy = true)]
		public QuaternionControl rightEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl(noisy = true)]
		public Vector3Control centerEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl(noisy = true)]
		public QuaternionControl centerEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
	
		// Constructors
		public XRHMD(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B21E86C-0x000000018B21E9EC
	}

	[InputControlLayout(commonUsages = new string[2] {"LeftHand", "RightHand" }, isGenericTypeOfDevice = true, displayName = "XR Controller")]
	public class XRController : TrackedDevice // TypeDefIndex: 47571
	{
		// Properties
		public static XRController leftHand { get; } // 0x000000018B21E728-0x000000018B21E7AC 
		public static XRController rightHand { get; } // 0x000000018B21E7AC-0x000000018B21E830 
	
		// Constructors
		public XRController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B21E640-0x000000018B21E728
	}

	public class XRControllerWithRumble : XRController // TypeDefIndex: 47572
	{
		// Constructors
		public XRControllerWithRumble(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		public void SendImpulse(float amplitude, float duration); // 0x000000018B21E5AC-0x000000018B21E640
	}

	[Serializable]
	[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
	public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 47576
	{
		// Fields
		[SerializeField]
		[Tooltip("Which Transform properties to update.")]
		private TrackingType m_TrackingType; // 0x18
		[SerializeField]
		[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
		private UpdateType m_UpdateType; // 0x1C
		[SerializeField]
		[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
		private bool m_IgnoreTrackingState; // 0x20
		[SerializeField]
		[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
		private InputActionProperty m_PositionInput; // 0x28
		[SerializeField]
		[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
		private InputActionProperty m_RotationInput; // 0x40
		[SerializeField]
		[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
		private InputActionProperty m_TrackingStateInput; // 0x58
		private Vector3 m_CurrentPosition; // 0x70
		private Quaternion m_CurrentRotation; // 0x7C
		private TrackingStates m_CurrentTrackingState; // 0x8C
		private bool m_RotationBound; // 0x90
		private bool m_PositionBound; // 0x91
		private bool m_TrackingStateBound; // 0x92
		private bool m_IsFirstUpdate; // 0x93
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private InputAction m_PositionAction; // 0x98
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private InputAction m_RotationAction; // 0xA0
	
		// Properties
		public TrackingType trackingType { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public UpdateType updateType { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public bool ignoreTrackingState { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public InputActionProperty positionInput { get; set; } // 0x0000000184D9CD10-0x0000000184D9CD30 0x000000018B21B578-0x000000018B21B5E8
		public InputActionProperty rotationInput { get; set; } // 0x0000000184D88410-0x0000000184D88430 0x000000018B21B63C-0x000000018B21B6AC
		public InputActionProperty trackingStateInput { get; set; } // 0x0000000184DAC160-0x0000000184DAC180 0x000000018B21B6AC-0x000000018B21B71C
		public InputAction positionAction { get; set; } // 0x000000018B21B50C-0x000000018B21B518 0x000000018B21B524-0x000000018B21B578
		public InputAction rotationAction { get; set; } // 0x000000018B21B518-0x000000018B21B524 0x000000018B21B5E8-0x000000018B21B63C
	
		// Nested types
		public enum TrackingType // TypeDefIndex: 47573
		{
			RotationAndPosition = 0,
			RotationOnly = 1,
			PositionOnly = 2
		}
	
		[Flags]
		private enum TrackingStates // TypeDefIndex: 47574
		{
			None = 0,
			Position = 1,
			Rotation = 2
		}
	
		public enum UpdateType // TypeDefIndex: 47575
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}
	
		// Constructors
		public TrackedPoseDriver(); // 0x000000018B21B4B4-0x000000018B21B50C
	
		// Methods
		private void BindActions(); // 0x000000018B21A194-0x000000018B21A1C0
		private void UnbindActions(); // 0x000000018B21AE98-0x000000018B21AEC4
		private void BindPosition(); // 0x000000018B21A1C0-0x000000018B21A33C
		private void BindRotation(); // 0x000000018B21A33C-0x000000018B21A4B8
		private void BindTrackingState(); // 0x000000018B21A4B8-0x000000018B21A634
		private static void RenameAndEnable(InputAction action, string name); // 0x000000018B21AB0C-0x000000018B21AB38
		private void UnbindPosition(); // 0x000000018B21AEC4-0x000000018B21AFFC
		private void UnbindRotation(); // 0x000000018B21AFFC-0x000000018B21B134
		private void UnbindTrackingState(); // 0x000000018B21B134-0x000000018B21B26C
		private void OnPositionPerformed(InputAction.CallbackContext context); // 0x000000018B21A8D0-0x000000018B21A930
		private void OnPositionCanceled(InputAction.CallbackContext context); // 0x000000018B21A8BC-0x000000018B21A8D0
		private void OnRotationPerformed(InputAction.CallbackContext context); // 0x000000018B21A950-0x000000018B21A9A4
		private void OnRotationCanceled(InputAction.CallbackContext context); // 0x000000018B21A930-0x000000018B21A950
		private void OnTrackingStatePerformed(InputAction.CallbackContext context); // 0x000000018B21A9A4-0x000000018B21A9F0
		private void OnTrackingStateCanceled(InputAction.CallbackContext context); // 0x0000000184DAC150-0x0000000184DAC160
		protected void Reset(); // 0x000000018B21AB38-0x000000018B21AD54
		protected virtual void Awake(); // 0x000000018B21A160-0x000000018B21A194
		protected void OnEnable(); // 0x000000018B21A818-0x000000018B21A8BC
		protected void OnDisable(); // 0x000000018B21A77C-0x000000018B21A818
		protected virtual void OnDestroy(); // 0x000000018B21A748-0x000000018B21A77C
		protected void UpdateCallback(); // 0x000000018B21B32C-0x000000018B21B4B4
		private void ReadTrackingState(bool hasResolvedPositionInputControl, bool hasResolvedRotationInputControl); // 0x000000018B21AA3C-0x000000018B21AB0C
		protected virtual void OnUpdate(); // 0x000000018B21A9F0-0x000000018B21AA04
		protected virtual void OnBeforeRender(); // 0x000000018B21A734-0x000000018B21A748
		protected virtual void PerformUpdate(); // 0x000000018B21AA04-0x000000018B21AA3C
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation); // 0x000000018B21AD54-0x000000018B21AE98
		private bool HasStereoCamera(out Camera cameraComponent); // 0x000000018B21A6D0-0x000000018B21A734
		private static bool HasResolvedControl(InputAction action); // 0x000000018B21A634-0x000000018B21A6D0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018B21B26C-0x000000018B21B32C
	}

	internal class XRLayoutBuilder // TypeDefIndex: 47578
	{
		// Fields
		private string parentLayout; // 0x10
		private string interfaceName; // 0x18
		private XRDeviceDescriptor descriptor; // 0x20
		private static readonly string[] poseSubControlNames; // 0x00
		private static readonly FeatureType[] poseSubControlTypes; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 47577
		{
			// Fields
			public XRLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0(); // 0x000000018B21C988-0x000000018B21C9A8
		}
	
		// Constructors
		public XRLayoutBuilder(); // 0x00000001841E1670-0x00000001841E1680
		static XRLayoutBuilder(); // 0x000000018B21FC00-0x000000018B220288
	
		// Methods
		private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor); // 0x000000018B21F8DC-0x000000018B21F970
		private static string SanitizeString(string original, bool allowPaths = false /* Metadata: 0x0232A4CA */); // 0x000000018B21FACC-0x000000018B21FC00
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate); // 0x0000000183AE95B0-0x0000000183AE96F0
		private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias); // 0x000000018B21F72C-0x000000018B21F8A0
		private bool IsSubControl(string name); // 0x000000018B21FAA4-0x000000018B21FACC
		private string GetParentControlName(string name); // 0x000000018B21F8A0-0x000000018B21F8DC
		private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex); // 0x000000018B21F970-0x000000018B21FAA4
		private InputControlLayout Build(); // 0x000000018B21E9EC-0x000000018B21F72C
	}

	public static class XRUtilities // TypeDefIndex: 47579
	{
		// Fields
		public const string InterfaceMatchAnyVersion = "^(XRInput)"; // Metadata: 0x0232A4CB
		public const string InterfaceV1 = "XRInput"; // Metadata: 0x0232A4D6
		public const string InterfaceCurrent = "XRInputV1"; // Metadata: 0x0232A4DE
	}

	public enum FeatureType // TypeDefIndex: 47580
	{
		Custom = 0,
		Binary = 1,
		DiscreteStates = 2,
		Axis1D = 3,
		Axis2D = 4,
		Axis3D = 5,
		Rotation = 6,
		Hand = 7,
		Bone = 8,
		Eyes = 9
	}

	[Serializable]
	public struct UsageHint // TypeDefIndex: 47581
	{
		// Fields
		public string content; // 0x00
	}

	[Serializable]
	public struct XRFeatureDescriptor // TypeDefIndex: 47582
	{
		// Fields
		public string name; // 0x00
		public List<UsageHint> usageHints; // 0x08
		public FeatureType featureType; // 0x10
		public uint customSize; // 0x14
	}

	[Serializable]
	public class XRDeviceDescriptor // TypeDefIndex: 47583
	{
		// Fields
		public string deviceName; // 0x10
		public string manufacturer; // 0x18
		public string serialNumber; // 0x20
		public InputDeviceCharacteristics characteristics; // 0x28
		public int deviceId; // 0x2C
		public List<XRFeatureDescriptor> inputFeatures; // 0x30
	
		// Constructors
		public XRDeviceDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public string ToJson(); // 0x0000000185393424-0x0000000185393430
		public static XRDeviceDescriptor FromJson(string json); // 0x000000018B21E830-0x000000018B21E86C
	}

	public struct Bone // TypeDefIndex: 47584
	{
		// Fields
		public uint m_ParentBoneIndex; // 0x00
		public Vector3 m_Position; // 0x04
		public Quaternion m_Rotation; // 0x10
	
		// Properties
		public uint parentBoneIndex { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public Vector3 position { get; set; } // 0x0000000184D8C7B0-0x0000000184D8C7D0 0x0000000184DABF50-0x0000000184DABF60
		public Quaternion rotation { get; set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
	}

	public struct Eyes // TypeDefIndex: 47585
	{
		// Fields
		public Vector3 m_LeftEyePosition; // 0x00
		public Quaternion m_LeftEyeRotation; // 0x0C
		public Vector3 m_RightEyePosition; // 0x1C
		public Quaternion m_RightEyeRotation; // 0x28
		public Vector3 m_FixationPoint; // 0x38
		public float m_LeftEyeOpenAmount; // 0x44
		public float m_RightEyeOpenAmount; // 0x48
	
		// Properties
		public Vector3 leftEyePosition { get; set; } // 0x0000000184D93250-0x0000000184D93270 0x0000000184DABF80-0x0000000184DABF90
		public Quaternion leftEyeRotation { get; set; } // 0x0000000184DABF70-0x0000000184DABF80 0x0000000184DABF90-0x0000000184DABFA0
		public Vector3 rightEyePosition { get; set; } // 0x0000000184D90520-0x0000000184D90540 0x0000000184D90500-0x0000000184D90510
		public Quaternion rightEyeRotation { get; set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
		public Vector3 fixationPoint { get; set; } // 0x0000000184D9E700-0x0000000184D9E720 0x0000000184D9DB00-0x0000000184D9DB10
		public float leftEyeOpenAmount { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public float rightEyeOpenAmount { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	}

	public class BoneControl : InputControl<UnityEngine.InputSystem.XR.Bone> // TypeDefIndex: 47586
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _parentBoneIndex_k__BackingField; // 0x140
		[CompilerGenerated]
		private Vector3Control _position_k__BackingField; // 0x148
		[CompilerGenerated]
		private QuaternionControl _rotation_k__BackingField; // 0x150
	
		// Properties
		[InputControl(offset = 0, displayName = "parentBoneIndex")]
		public IntegerControl parentBoneIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA60-0x0000000184D8DA70 0x0000000186B8B404-0x0000000186B8B418
		[InputControl(offset = 4, displayName = "Position")]
		public Vector3Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 0x0000000186B8B468-0x0000000186B8B47C
		[InputControl(offset = 16, displayName = "Rotation")]
		public QuaternionControl rotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D890-0x0000000184D8D8A0 0x0000000186B8B224-0x0000000186B8B238
	
		// Constructors
		public BoneControl(); // 0x000000018B20893C-0x000000018B208970
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B2086D4-0x000000018B2087D0
		public override unsafe UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B2087D0-0x000000018B2088A8
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr); // 0x000000018B2088A8-0x000000018B20893C
	}

	public class EyesControl : InputControl<UnityEngine.InputSystem.XR.Eyes> // TypeDefIndex: 47587
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _leftEyePosition_k__BackingField; // 0x198
		[CompilerGenerated]
		private QuaternionControl _leftEyeRotation_k__BackingField; // 0x1A0
		[CompilerGenerated]
		private Vector3Control _rightEyePosition_k__BackingField; // 0x1A8
		[CompilerGenerated]
		private QuaternionControl _rightEyeRotation_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private Vector3Control _fixationPoint_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private AxisControl _leftEyeOpenAmount_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private AxisControl _rightEyeOpenAmount_k__BackingField; // 0x1C8
	
		// Properties
		[InputControl(offset = 0, displayName = "LeftEyePosition")]
		public Vector3Control leftEyePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		[InputControl(offset = 12, displayName = "LeftEyeRotation")]
		public QuaternionControl leftEyeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		[InputControl(offset = 28, displayName = "RightEyePosition")]
		public Vector3Control rightEyePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		[InputControl(offset = 40, displayName = "RightEyeRotation")]
		public QuaternionControl rightEyeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(offset = 56, displayName = "FixationPoint")]
		public Vector3Control fixationPoint { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
		public AxisControl leftEyeOpenAmount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
		public AxisControl rightEyeOpenAmount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
	
		// Constructors
		public EyesControl(); // 0x000000018B209B0C-0x000000018B209B40
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B209684-0x000000018B209858
		public override unsafe UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr); // 0x000000018B209858-0x000000018B2099D4
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr); // 0x000000018B2099D4-0x000000018B209B0C
	}

	internal static class XRSupport // TypeDefIndex: 47588
	{
		// Methods
		public static void Initialize(); // 0x0000000183AF28A0-0x0000000183AF3430
	}
}

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct BufferedRumble // TypeDefIndex: 47589
	{
		// Fields
		[CompilerGenerated]
		private HapticCapabilities _capabilities_k__BackingField; // 0x00
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x18
	
		// Properties
		public HapticCapabilities capabilities { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D910A0-0x0000000184D910B0 0x0000000184D88C00-0x0000000184D88C10
		private UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public BufferedRumble(UnityEngine.InputSystem.InputDevice device); // 0x000000018B208A54-0x000000018B208B5C
	
		// Methods
		public void EnqueueRumble(byte[] samples); // 0x000000018B208970-0x000000018B208A54
	}

	public struct HapticState // TypeDefIndex: 47590
	{
		// Fields
		[CompilerGenerated]
		private uint _samplesQueued_k__BackingField; // 0x00
		[CompilerGenerated]
		private uint _samplesAvailable_k__BackingField; // 0x04
	
		// Properties
		public uint samplesQueued { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public uint samplesAvailable { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
	
		// Constructors
		public HapticState(uint samplesQueued, uint samplesAvailable); // 0x0000000184D85C40-0x0000000184D85C50
	}

	public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 47591
	{
		// Fields
		private const int kSize = 16; // Metadata: 0x0232A4F2
		private InputDeviceCommand baseCommand; // 0x00
		public uint samplesQueued; // 0x08
		public uint samplesAvailable; // 0x0C
	
		// Properties
		private static FourCC Type { get; } // 0x0000000184DABFD0-0x0000000184DABFE0 
		public FourCC typeStatic { get; } // 0x0000000184DABFD0-0x0000000184DABFE0 
		public HapticState currentState { get; } // 0x0000000184DABFE0-0x0000000184DAC000 
	
		// Methods
		public static GetCurrentHapticStateCommand Create(); // 0x0000000184DABFA0-0x0000000184DABFD0
	}

	public struct HapticCapabilities // TypeDefIndex: 47592
	{
		// Fields
		[CompilerGenerated]
		private readonly uint _numChannels_k__BackingField; // 0x00
		[CompilerGenerated]
		private readonly bool _supportsImpulse_k__BackingField; // 0x04
		[CompilerGenerated]
		private readonly bool _supportsBuffer_k__BackingField; // 0x05
		[CompilerGenerated]
		private readonly uint _frequencyHz_k__BackingField; // 0x08
		[CompilerGenerated]
		private readonly uint _maxBufferSize_k__BackingField; // 0x0C
		[CompilerGenerated]
		private readonly uint _optimalBufferSize_k__BackingField; // 0x10
	
		// Properties
		public uint numChannels { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182B77620-0x0000000182B77630 
		public bool supportsImpulse { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D90BB0-0x0000000184D90BC0 
		public bool supportsBuffer { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D92DC0-0x0000000184D92DD0 
		public uint frequencyHz { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D88B10-0x0000000184D88B20 
		public uint maxBufferSize { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 
		public uint optimalBufferSize { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize); // 0x0000000184DAC090-0x0000000184DAC0B0
		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize); // 0x0000000184DAC070-0x0000000184DAC090
	}

	public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo // TypeDefIndex: 47593
	{
		// Fields
		private const int kSize = 28; // Metadata: 0x0232A4F3
		private InputDeviceCommand baseCommand; // 0x00
		public uint numChannels; // 0x08
		public bool supportsImpulse; // 0x0C
		public bool supportsBuffer; // 0x0D
		public uint frequencyHz; // 0x10
		public uint maxBufferSize; // 0x14
		public uint optimalBufferSize; // 0x18
	
		// Properties
		private static FourCC Type { get; } // 0x0000000184DAC030-0x0000000184DAC040 
		public FourCC typeStatic { get; } // 0x0000000184DAC030-0x0000000184DAC040 
		public HapticCapabilities capabilities { get; } // 0x0000000184DAC040-0x0000000184DAC070 
	
		// Methods
		public static GetHapticCapabilitiesCommand Create(); // 0x0000000184DAC000-0x0000000184DAC030
	}

	public struct SendBufferedHapticCommand : IInputDeviceCommandInfo // TypeDefIndex: 47595
	{
		// Fields
		private const int kMaxHapticBufferSize = 1024; // Metadata: 0x0232A4F4
		private const int kSize = 1040; // Metadata: 0x0232A4F6
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private int bufferSize; // 0x0C
		private unsafe fixed /* 0x00000000-0x00000000 */ byte buffer[0]; // 0x10
	
		// Properties
		private static FourCC Type { get; } // 0x0000000184DAC100-0x0000000184DAC110 
		public FourCC typeStatic { get; } // 0x0000000184DAC100-0x0000000184DAC110 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 47594
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static SendBufferedHapticCommand Create(byte[] rumbleBuffer); // 0x000000018B219DB4-0x000000018B219F34
	}

	public struct SendHapticImpulseCommand : IInputDeviceCommandInfo // TypeDefIndex: 47596
	{
		// Fields
		private const int kSize = 20; // Metadata: 0x0232A4F8
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private float amplitude; // 0x0C
		private float duration; // 0x10
	
		// Properties
		private static FourCC Type { get; } // 0x0000000184DAC140-0x0000000184DAC150 
		public FourCC typeStatic { get; } // 0x0000000184DAC140-0x0000000184DAC150 
	
		// Methods
		public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration); // 0x0000000184DAC110-0x0000000184DAC140
	}
}

namespace UnityEngine.XR.WindowsMR.Input
{
	[InputControlLayout(displayName = "Windows MR Headset", hideInUI = true)]
	public class WMRHMD : XRHMD // TypeDefIndex: 47363
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _userPresence_k__BackingField; // 0x1E0
	
		// Properties
		[InputControl]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"HeadRotation" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"HeadPosition" })]
		public ButtonControl userPresence { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
	
		// Constructors
		public WMRHMD(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A9A14-0x000000018B1A9A80
	}

	[InputControlLayout(displayName = "HoloLens Hand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HololensHand : XRController // TypeDefIndex: 47364
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _airTap_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private AxisControl _sourceLossRisk_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private Vector3Control _sourceLossMitigationDirection_k__BackingField; // 0x1C8
	
		// Properties
		[InputControl(noisy = true, aliases = new string[1] {"gripVelocity" })]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl airTap { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
	
		// Constructors
		public HololensHand(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B198E64-0x000000018B198F84
	}

	[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class WMRSpatialController : XRControllerWithRumble // TypeDefIndex: 47365
	{
		// Fields
		[CompilerGenerated]
		private Vector2Control _joystick_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private AxisControl _grip_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private ButtonControl _gripPressed_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private ButtonControl _menu_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private AxisControl _trigger_k__BackingField; // 0x1D8
		[CompilerGenerated]
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
		[CompilerGenerated]
		private ButtonControl _joystickClicked_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1F8
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x200
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x208
		[CompilerGenerated]
		private AxisControl _batteryLevel_k__BackingField; // 0x210
		[CompilerGenerated]
		private AxisControl _sourceLossRisk_k__BackingField; // 0x218
		[CompilerGenerated]
		private Vector3Control _sourceLossMitigationDirection_k__BackingField; // 0x220
		[CompilerGenerated]
		private Vector3Control _pointerPosition_k__BackingField; // 0x228
		[CompilerGenerated]
		private QuaternionControl _pointerRotation_k__BackingField; // 0x230
	
		// Properties
		[InputControl(aliases = new string[2] {"Primary2DAxis", "thumbstickaxes" })]
		public Vector2Control joystick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		[InputControl(aliases = new string[2] {"Secondary2DAxis", "touchpadaxes" })]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA90-0x0000000184D8DAA0 0x0000000185397240-0x0000000185397254
		[InputControl(aliases = new string[1] {"gripaxis" })]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		[InputControl(aliases = new string[1] {"gripbutton" })]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		[InputControl(aliases = new string[2] {"Primary", "menubutton" })]
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x0000000186B8B0F8-0x0000000186B8B10C
		[InputControl(aliases = new string[1] {"triggeraxis" })]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000186B8B134-0x0000000186B8B148
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
		[InputControl(aliases = new string[1] {"thumbstickpressed" })]
		public ButtonControl joystickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		[InputControl(aliases = new string[2] {"joystickorpadpressed", "touchpadpressed" })]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		[InputControl(aliases = new string[2] {"joystickorpadtouched", "touchpadtouched" })]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		[InputControl(noisy = true, aliases = new string[1] {"gripVelocity" })]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DA40-0x0000000184D8DA50 0x0000000186B8B3DC-0x0000000186B8B3F0
		[InputControl(noisy = true, aliases = new string[1] {"gripAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 0x0000000186B8B24C-0x0000000186B8B260
		[InputControl(noisy = true)]
		public AxisControl batteryLevel { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 0x0000000186B8B238-0x0000000186B8B24C
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 0x0000000186B1D640-0x0000000186B1D654
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D870-0x0000000184D8D880 0x0000000186B8B1FC-0x0000000186B8B210
		[InputControl(noisy = true)]
		public Vector3Control pointerPosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D440-0x0000000184D8D450 0x0000000186B22BCC-0x0000000186B22BE0
		[InputControl(noisy = true, aliases = new string[1] {"PointerOrientation" })]
		public QuaternionControl pointerRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8DAE0-0x0000000184D8DAF0 0x0000000186B8B490-0x0000000186B8B4A4
	
		// Constructors
		public WMRSpatialController(); // 0x00000001853971D4-0x00000001853971DC
	
		// Methods
		protected override void FinishSetup(); // 0x000000018B1A9A80-0x000000018B1A9E70
	}
}
