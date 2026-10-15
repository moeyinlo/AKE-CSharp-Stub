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

// Image 10: Unity.InputSystem.dll - Assembly: Unity.InputSystem, Version=1.14.0.0, Culture=neutral, PublicKeyToken=null - Types 72086-72732

internal static class UISupport // TypeDefIndex: 72087
{
	// Methods
	public static void Initialize(); // 0x0000000185B0AD20-0x0000000185B0AD90
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 72732
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_262 _1D0F855A98F398E261D1E4C657C33BD47F11A47FD9CF90F160D467BC8C7FEBE3; // 0x00 // Static value (base64): AAAAAAEAAgADAAQABQAGAAcACAAJAAoACwAMAA0ADgAPABAAEQASABMAFAAVABYAFwAYABkAGgAbABwAHQAeAB8AIAAhACIAIwAkACUAJgAnACgAKQAqACsALAAtAC4ALwAwADEAMgAzADQANQA2ADcAOAA5ADoAOgA7ADwAPQA9AD4APwBAAEAAQQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBXAFgAWQBaAFsAXABdAF4AXwBgAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegB7AHwAfQB+AA== - Metadata: 0x026230C8
	internal static readonly __StaticArrayInitTypeSize_508 _1E9B4B805C18CBD7D7326E392008A12FBD20465C53E9C60AEBEA427165641632; // 0x106 // Static value (base64): AgQIAADsCQADBBAABAQYAAUEIAAGBCgABwQwAAgEOAAJBEAACgRIAAsEUAAMBFgADQRgAA4EaAAPBHAAFAR4ABUEgAAWBIgAFwSQABgEmAAZBKAAGgSoABsEsAAcBLgAHQTAAB4EyAAfBNAAIATYACEE4AAiBOgAIwTwACQE+AAlBAABJgQIAScEEAEoBBgBKQQgASoEKAErBDABLAQ4AS0EQAEuBEgBLwRQATAEWAExBGABMgRoATMEcAE0BHgBNQSAATYEiAE3BJABOASYAToImAE5BKABOwSoAT0IqAE8BLABPgS4AUAIuAE/BMABQQTIAUIE0AFDBNgBAQTgARIE6AETBPABEAT4AREEAAJEBAgCRQQQAkYEGAJHBCACSAQoAkkEMAJKBDgCSwRAAkwESAJNBFACTgRYAk8EYAJQBGgCUQRwAlIEeAJTBIACVASIAlUEkAJWBJgCYASgAlcEqAJYBLACWQS4AloEwAJbBMgCXATQAl0E2AJeBOACXwToAmEE8AJiBPgCYwQAA2QECANlBBADZgQYA2cEIANoBCgDaQQwA2oEOANrBEADbARIA20EUANuBFgDbwRgA3AEaANxBHADcgSAA3MEiAN0BJADdQSYA3YEoAN3BKgDeASwA3kEuAN6BMADewTIA3wE0AN9BNgDfgT4Aw== - Metadata: 0x026231D0
	internal static readonly __StaticArrayInitTypeSize_976 _286DD866DF46AD63DA3C6198BE2F9CDB96A5223055FDC3E0287B7CCA9F45AFB4; // 0x302 // Static value (base64): EYAAAB6AAAEqgAABH4AAAiuAAAIigAADI4AAAySAAAMugAADL4AAAzCAAAMggAAEIYAABCWAAAQsgAAELYAABDGAAAQDgAAFFIAABSaAAAYygAAGJ4AABzOAAAcFIAAIFiAACBcgAAgYIEAIBiCACBkggAgaBMAIGwTgCBwAAQoogAAMKYAADTSAAA5BgAAPQoAAEEWAABFGgAARR4AAEUOAABJEgAASSIAAEjeAABNJgAAUSoAAFTkgABY6IAAWOyBAFjwggBY9BMAWPgTgFj8AARhLgAAaTIAAG02AABxagAAdW4AAHl6AAB9fgAAfYIAAH1yAACBdgAAgYYAAIFCAACFigAAiY4AAI1IgACRTIAAkVCBAJFUggCRWBMAkVwTgJFgAASZkgAAoZYAAKWaAACpzgAArdIAALHeAAC14gAAteYAALXWAAC52gAAueoAALmmAAC97gAAwfIAAMWsgADJsIAAybSBAMm4ggDJvBMAycATgMnEAATR9gAA2foAAN3+AADiMgAA5jYAAOpCAADuRgAA7koAAO46AADyPgAA8k4AAPIKAAD2UgAA+lYAAP4QgAECFIABAhiBAQIcggECIBMBAiQTgQIoAAUKWgABEl4AARZiAAEalgABHpoAASKmAAEmqgABJq4AASaeAAEqogABKrIAASpuAAEutgABMroAATZ0gAE6eIABOnyBATqAggE6hBMBOogTgTqMAAVCvgABSsIAAU7GAAFS+gABVv4AAVsKAAFfDgABXxIAAV8CAAFjBgABYxYAAWLSAAFnGgABax4AAW7YgAFy3IABcuCBAXLkggFy6BMBcuwTgXLwAAV7IgABgyYAAYcqAAGLXgABj2IAAZNuAAGXcgABl3YAAZdmAAGbagABm3oAAZs2AAGffgABo4IAAac8gAGrQIABq0SBAatIggGrTBMBq1ATgatUAAWzhgABu4oAAb+OAAHDwgABx8YAAcvSAAHP1gABz9oAAc/KAAHTzgAB094AAdOaAAHX4gAB2+YAAd+ggAHjpIAB46iBAeOsggHjsBMB47QTgeO4AAXr6gAB8+4AAffyAAH4JgQB/CoEAgA2BAIEOgQCBD4EAgQuBAIIMgQCCEIEAgv+AAIMRgQCEEoEAhQEhAIYCIQCGAyFAhgQhgIYFBcCGBgXghgcBAYgTgQCKFIEAixWBAIwigQCNI4EAjiaBAI8ngQCPKIEAjySBAJAlgQCQKYEAkBiBAJEqgQCSK4EAkxohAJQbIQCUHCFAlB0hgJQeBcCUHwXglCABAZYsgQCYLYEAmQ== - Metadata: 0x026233D0
	internal static readonly __StaticArrayInitTypeSize_20 _7BD1B2B340030CA32C0F7873A8B4949D42124F6206A455BA2860B27C103E8261; // 0x6D2 // Static value (base64): AQAAAAIAAAADAAAAAgAAAAQAAAA= - Metadata: 0x026237A8
	internal static readonly __StaticArrayInitTypeSize_371 BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B; // 0x6E6 // Static value (base64): hwEBAAAAAMQAAwAAAACHARcAAAAAgAAFAAAAAMQACwAAAABAAAcAAAABgAAJAAMAASAA//8BAAFAAP//AgABYAD//wcAA4AA//8EAAPBAA0AAAAAxAATAAAAAKEADwAKAATBABEADgAEkQD//xIAA6EA//8VAAPAAP//AAAAwQD//xgAAsMAFQAAAADEAP//HAABwgD//xoAAcMA//8bAAEgARkAAAAAhwEpAAAAAPAAGwAAAAAgAScAAAAA4AAdAAAAAPAA//8pAAHSAB8AJwAB4AD//ygAAcsAIQAAAADSAP//AAAAyAAjAAAAAMsA//8AAADGACUAAAAAyAD//wAAAMUA//8dAAHGAP//AAAACAH//x4AASAB//8fAAGAASsAAAAAhwEvAAAAAFAB//8gAAKAAS0AIgACaAH//yQAAYAB//8lAAGEATEAAAAAhwH//wAAAIIBMwAAAACEAf//AAAAgQH//yYAAYIB//8AAAA= - Metadata: 0x026237C0
	internal static readonly __StaticArrayInitTypeSize_3983 CB22D97D4BE9F7A4259E5E355F9F66F2C2D11559A9EA0634CFF23EAA93DA62AE; // 0x859 // Static value (base64): PxMBAAAAAMAIAwAAAAA/EwEBAAAAgAMFAAAAAMAIZwAAAADAAQcAAAABgAM1AEQAAcAACQAAAADAARUAAAAAYAALAAAAAMAADwAAAAAgAP//AQABYAANAAIAAkAA//8EAAJgAP//BgACkAARAAgACMAAEwAQAAh4AP//GAAGkAD//x4ABqgA//8kAALAAP//JgACHQEXAAAAAMABLwAAAAAIARkAAAAAHQEjAAAAAOQAGwAoAAQIAR0ALAAE0gD//zAAAuQA//8yAAL2AP//AAAACAEfAAAAAP8A//8AAAAIASEAAAAABAH//zQAAwgB//83AAMYASUAAAAAHQEnAAAAABAB//86AAEYAf//OwACGwEpAAAAAB0BLQAAAAAaASsAAAAAGwH//wAAABkB//89AAEaAf//AAAAHAH//wAAAB0B//8+AAGAATEAAAAAwAEzAEEAAU8B//8/AAGAAf//QAABoAH//0IAAcAB//9DAAGgAjcAXAABgANHAF0AATACOQBNAASgAkEAUQAE+AE7AEcAAjACPQBJAALcAf//RQAB+AH//0YAASACPwAAAAAwAv//AAAADAL//0sAASAC//9MAAFgAkMAAAAAoAJFAAAAAEgC//9VAANgAv//WAADgAL//1sAAaAC//9eAAEQA0kAaQABgANjAGoAAdgCSwAAAAAQA1MAAAAAvAL//18AAdgCTQBgAAHIAk8AAAAA2AJRAAAAAMIC//9hAALIAv//YwAC0AL//2UAAdgC//9mAAH0AlUAAAAAEAP//wAAAOYCVwAAAAD0Av//AAAA3wJZAAAAAOYC//8AAADcAlsAAAAA3wJfAAAAANoCXQAAAADcAv//AAAA2QL//2cAAdoC//8AAADeAmEAAAAA3wL//wAAAN0C//9oAAHeAv//AAAASAP//2sAAoADZQBtAAJkA///bwABgAP//3AAAQAHaQAAAADACM8AywABQAVrAHEAAQAHnQCeAAFgBG0AiQABQAV9AIoAAfADbwB6AARgBHcAfgAEuANxAHQAAvADcwB2AAKcA///cgABuAP//3MAAeADdQAAAADwA///AAAAzAP//3gAAeAD//95AAEgBHkAAAAAYAR7AAAAAAgE//+CAAMgBP//hQADQAT//4gAAWAE//+LAAHQBH8AlgABQAWZAJcAAZgEgQAAAADQBIkAAAAAfAT//4wAAZgEgwCNAAGIBIUAAAAAmASHAAAAAIIE//+OAAKIBP//kAACkAT//5IAAZgE//+TAAG0BIsAAAAA0AT//wAAAKYEjQAAAAC0BP//AAAAnwSPAAAAAKYE//8AAACcBJEAAAAAnwSVAAAAAJoEkwAAAACcBP//AAAAmQT//5QAAZoE//8AAACeBJcAAAAAnwT//wAAAJ0E//+VAAGeBP//AAAACAX//5gAAkAFmwCaAAIkBf//nAABQAX//50AASAGnwC2AAEAB68AtwABsAWhAKcABCAGqQCrAAR4BaMAoQACsAWlAKMAAlwF//+fAAF4Bf//oAABoAWnAAAAALAF//8AAACMBf//pQABoAX//6YAAeAFqwAAAAAgBq0AAAAAyAX//68AA+AF//+yAAMABv//tQABIAb//7gAAZAGsQDDAAEAB8sAxAABWAazAAAAAJAGuwAAAAA8Bv//uQABWAa1ALoAAUgGtwAAAABYBrkAAAAAQgb//7sAAkgG//+9AAJQBv//vwABWAb//8AAAXQGvQAAAACQBv//AAAAZga/AAAAAHQG//8AAABfBsEAAAAAZgb//wAAAFwGwwAAAABfBscAAAAAWgbFAAAAAFwG//8AAABZBv//wQABWgb//wAAAF4GyQAAAABfBv//AAAAXQb//8IAAV4G//8AAADIBv//xQACAAfNAMcAAuQG///JAAEAB///ygAB4AfRAOMAAcAI4QDkAAFwB9MA1AAE4AfbANgABDgH1QDOAAJwB9cA0AACHAf//8wAATgH///NAAFgB9kAAAAAcAf//wAAAEwH///SAAFgB///0wABoAfdAAAAAOAH3wAAAACIB///3AADoAf//98AA8AH///iAAHgB///5QABUAjjAPAAAcAI/QDxAAEYCOUAAAAAUAjtAAAAAPwH///mAAEYCOcA5wABCAjpAAAAABgI6wAAAAACCP//6AACCAj//+oAAhAI///sAAEYCP//7QABNAjvAAAAAFAI//8AAAAmCPEAAAAANAj//wAAAB8I8wAAAAAmCP//AAAAHAj1AAAAAB8I+QAAAAAaCPcAAAAAHAj//wAAABkI///uAAEaCP//AAAAHgj7AAAAAB8I//8AAAAdCP//7wABHgj//wAAAIgI///yAALACP8A9AACpAj///YAAcAI///3AAEADgMBAAAAPxOdAQAAAEAMBQEAAAAADmsBUgEBgAoHAfgAAUAMOQElAQGgCQkBEAEBgAoZAREBATAJCwEBAQSgCRMBBQEE+AgNAfsAAjAJDwH9AALcCP//+QAB+Aj///oAASAJEQEAAAAwCf//AAAADAn///8AASAJ//8AAQFgCRUBAAAAoAkXAQAAAEgJ//8JAQNgCf//DAEDgAn//w8BAaAJ//8SAQEQChsBHQEBgAo1AR4BAdgJHQEAAAAQCiUBAAAAvAn//xMBAdgJHwEUAQHICSEBAAAA2AkjAQAAAMIJ//8VAQLICf//FwEC0An//xkBAdgJ//8aAQH0CScBAAAAEAr//wAAAOYJKQEAAAD0Cf//AAAA3wkrAQAAAOYJ//8AAADcCS0BAAAA3wkxAQAAANoJLwEAAADcCf//AAAA2Qn//xsBAdoJ//8AAADeCTMBAAAA3wn//wAAAN0J//8cAQHeCf//AAAASAr//x8BAoAKNwEhAQJkCv//IwEBgAr//yQBAWALOwE9AQFADEsBPgEB8Ao9AS4BBGALRQEyAQS4Cj8BKAEC8ApBASoBApwK//8mAQG4Cv//JwEB4ApDAQAAAPAK//8AAADMCv//LAEB4Ar//y0BASALRwEAAABgC0kBAAAACAv//zYBAyAL//85AQNAC///PAEBYAv//z8BAdALTQFKAQFADGcBSwEBmAtPAQAAANALVwEAAAB8C///QAEBmAtRAUEBAYgLUwEAAACYC1UBAAAAggv//0IBAogL//9EAQKQC///RgEBmAv//0cBAbQLWQEAAADQC///AAAApgtbAQAAALQL//8AAACfC10BAAAApgv//wAAAJwLXwEAAACfC2MBAAAAmgthAQAAAJwL//8AAACZC///SAEBmgv//wAAAJ4LZQEAAACfC///AAAAnQv//0kBAZ4L//8AAAAIDP//TAECQAxpAU4BAiQM//9QAQFADP//UQEBIA1tAWoBAQAOfQFrAQGwDG8BWwEEIA13AV8BBHgMcQFVAQKwDHMBVwECXAz//1MBAXgM//9UAQGgDHUBAAAAsAz//wAAAIwM//9ZAQGgDP//WgEB4Ax5AQAAACANewEAAADIDP//YwED4Az//2YBAwAN//9pAQEgDf//bAEBkA1/AXcBAQAOmQF4AQFYDYEBAAAAkA2JAQAAADwN//9tAQFYDYMBbgEBSA2FAQAAAFgNhwEAAABCDf//bwECSA3//3EBAlAN//9zAQFYDf//dAEBdA2LAQAAAJAN//8AAABmDY0BAAAAdA3//wAAAF8NjwEAAABmDf//AAAAXA2RAQAAAF8NlQEAAABaDZMBAAAAXA3//wAAAFkN//91AQFaDf//AAAAXg2XAQAAAF8N//8AAABdDf//dgEBXg3//wAAAMgN//95AQIADpsBewEC5A3//30BAQAO//9+AQGAEZ8BAAAAPxMFAgAAAMAPoQF/AQGAEdMBrAEB4A6jAZcBAcAPswGYAQFwDqUBiAEE4A6tAYwBBDgOpwGCAQJwDqkBhAECHA7//4ABATgO//+BAQFgDqsBAAAAcA7//wAAAEwO//+GAQFgDv//hwEBoA6vAQAAAOAOsQEAAACIDv//kAEDoA7//5MBA8AO//+WAQHgDv//mQEBUA+1AaQBAcAPzwGlAQEYD7cBAAAAUA+/AQAAAPwO//+aAQEYD7kBmwEBCA+7AQAAABgPvQEAAAACD///nAECCA///54BAhAP//+gAQEYD///oQEBNA/BAQAAAFAP//8AAAAmD8MBAAAANA///wAAAB8PxQEAAAAmD///AAAAHA/HAQAAAB8PywEAAAAaD8kBAAAAHA///wAAABkP//+iAQEaD///AAAAHg/NAQAAAB8P//8AAAAdD///owEBHg///wAAAIgP//+mAQLAD9EBqAECpA///6oBAcAP//+rAQGgENUBxAEBgBHlAcUBATAQ1wG1AQSgEN8BuQEE+A/ZAa8BAjAQ2wGxAQLcD///rQEB+A///64BASAQ3QEAAAAwEP//AAAADBD//7MBASAQ//+0AQFgEOEBAAAAoBDjAQAAAEgQ//+9AQNgEP//wAEDgBD//8MBAaAQ///GAQEQEecB0QEBgBEBAtIBAdgQ6QEAAAAQEfEBAAAAvBD//8cBAdgQ6wHIAQHIEO0BAAAA2BDvAQAAAMIQ///JAQLIEP//ywEC0BD//80BAdgQ///OAQH0EPMBAAAAEBH//wAAAOYQ9QEAAAD0EP//AAAA3xD3AQAAAOYQ//8AAADcEPkBAAAA3xD9AQAAANoQ+wEAAADcEP//AAAA2RD//88BAdoQ//8AAADeEP8BAAAA3xD//wAAAN0Q///QAQHeEP//AAAASBH//9MBAoARAwLVAQJkEf//1wEBgBH//9gBAWASBwLZAQI/ExcC2wEC8BEJAuUBBGASEQLpAQS4EQsC3wEC8BENAuEBApwR///dAQG4Ef//3gEB4BEPAgAAAPAR//8AAADMEf//4wEB4BH//+QBASASEwIAAABgEhUCAAAACBL//+0BAyAS///wAQNAEv//8wEBYBL///QBAdASGQL/AQE/EzMCAAIBmBIbAgAAANASIwIAAAB8Ev//9QEBmBIdAvYBAYgSHwIAAACYEiECAAAAghL///cBAogS///5AQKQEv//+wEBmBL///wBAbQSJQIAAADQEv//AAAAphInAgAAALQS//8AAACfEikCAAAAphL//wAAAJwSKwIAAACfEi8CAAAAmhItAgAAAJwS//8AAACZEv///QEBmhL//wAAAJ4SMQIAAACfEv//AAAAnRL///4BAZ4S//8AAAAAE///AAAAPxM1AgAAACAT//8BAgI/EzcCAwIBMBP//wQCAT8T//8FAgE= - Metadata: 0x02623938
	internal static readonly __StaticArrayInitTypeSize_1036 D4ADEDA8D4E42C7133AFF7B673F4893FEA7C6A101764B0179449453A7E7F516F; // 0x17E8 // Static value (base64): AAARABIAAQAeACoAHwArABMAIAAhACUAAgAsAC0AMQATACAAIQAlAAIALAAtADEAIgAjACQALgAvADAAIgAjACQALgAvADAAFAADABQAAwAVACcABAAzABUAJwAEADMAJgAyACYAMgAWABcABQAWABcABQAYABkABgAaABsAHAAcAB0AKAApAAcANAA0ADUAQQA1AEEAQgBCADYARQBGAEcANgBFAEYARwBDAEQASABDAEQASAA3ADgAOABJAEoASgA5ADoAOQA6ADsAPAA9AD4APwA/AEAASwBAAEsATABMAAgATQBNAE4AWgBOAFoAWwBbAE8AXgBfAGAATwBeAF8AYABcAF0AYQBcAF0AYQBQAFEAUQBiAGMAYwBSAFMAUgBTAFQAVQBWAFcAWABYAFkAZABZAGQAZQBlAAkAZgBmAGcAcwBnAHMAdAB0AGgAdwB4AHkAaAB3AHgAeQB1AHYAegB1AHYAegBpAGoAagB7AHwAfABrAGwAawBsAG0AbgBvAHAAcQBxAHIAfQByAH0AfgB+AAoAfwB/AIAAjACAAIwAjQCNAIEAkACRAJIAgQCQAJEAkgCOAI8AkwCOAI8AkwCCAIMAgwCUAJUAlQCEAIUAhACFAIYAhwCIAIkAigCKAIsAlgCLAJYAlwCXAAsAmACYAJkApQCZAKUApgCmAJoAqQCqAKsAmgCpAKoAqwCnAKgArACnAKgArACbAJwAnACtAK4ArgCdAJ4AnQCeAJ8AoAChAKIAowCjAKQArwCkAK8AsACwAAwAsQCxALIAvgCyAL4AvwC/ALMAwgDDAMQAswDCAMMAxADAAMEAxQDAAMEAxQC0ALUAtQDGAMcAxwC2ALcAtgC3ALgAuQC6ALsAvAC8AL0AyAC9AMgAyQDJAA0AygDKAMsA1wDLANcA2ADYAMwA2wDcAN0AzADbANwA3QDZANoA3gDZANoA3gDNAM4AzgDfAOAA4ADPANAAzwDQANEA0gDTANQA1QDVANYA4QDWAOEA4gDiAA4A4wDjAOQA8ADkAPAA8QDxAOUA9AD1APYA5QD0APUA9gDyAPMA9wDyAPMA9wDmAOcA5wD4APkA+QDoAOkA6ADpAOoA6wDsAO0A7gDuAO8A+gDvAPoA+wD7AA8A/AD8AP0ACQH9AAkBCgEKAf4ADQEOAQ8B/gANAQ4BDwELAQwBEAELAQwBEAH/AAABAAERARIBEgEBAQIBAQECAQMBBAEFAQYBBwEHAQgBEwEIARMBFAEUARAAGQEQABkBFQEVARYBIgEWASIBIwEjARcBJgEnASgBFwEmAScBKAEkASUBKQEkASUBKQEYASoBKwErARoBGwEaARsBHAEdAR4BHwEgASABIQEsASEBLQEtAQ== - Metadata: 0x026248C8
	internal static readonly __StaticArrayInitTypeSize_84 D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A; // 0x1BF4 // Static value (base64): AAAOAA8AAQAQABEAFQASABMAFAACABYAFwAbAAIAFgAXABsAGAAZABoAGAAZABoAAwAEAAUABgAHAAgACQAJAAoAHAAKABwAHQAdAAsADAAMAA0A - Metadata: 0x02624CD8
	internal static readonly __StaticArrayInitTypeSize_1799 E90C194F8229C7E8552701BC1D1F1BD2537F77555B9151B4B09FF9D1BA956FE6; // 0x1C48 // Static value (base64): fwABAAAAAEAAAwAAAAF/ADEAAQABIAAPAAAAAEAABQAAAAAwAFsAAAAAQAAHAAAAADgAeQBDAAFAAAkARAABPACHAAAAAEAACwAAAAA+AA0AAAAAQAAvAAAAAD0A//8CAAE+AP//EwABEAARAAAAACAAPQAAAAAIABMAAAAAEAAhAAAAAAQAFQAAAAAIABsAAAAAAgAXAAAAAAQAGQAAAAABAP//AAAAAgD//wMAAQMA//8EAAEEAP//BQABBgAdAAAAAAgAHwAAAAAFAP//BgABBgD//wcAAQcA//8IAAEIAP//CQABDAAjAAAAABAAKQAAAAAKACUAAAAADAAnAAAAAAkA//8KAAEKAP//CwABCwD//wwAAQwA//8NAAEOACsAAAAAEAAtAAAAAA0A//8OAAEOAP//DwABDwD//xAAARAA//8VAAE/AP//FAABQAD//xEAAWAAMwAAAAB/AMEAAAAAUAA1AAAAAGAAowAAAABIADcAAAAAUACVAAAAAEQAOQAAAABIAI8AAAAAQgA7AAAAAEQAjQAAAABBAP//EgABQgD//0gAARgAPwAAAAAgAE0AAAAAFABBAAAAABgARwAAAAASAEMAAAAAFABFAAAAABEA//8WAAESAP//FwABEwD//xgAARQA//8ZAAEWAEkAAAAAGABLAAAAABUA//8aAAEWAP//GwABFwD//xwAARgA//8dAAEcAE8AAAAAIABVAAAAABoAUQAAAAAcAFMAAAAAGQD//x4AARoA//8fAAEbAP//IAABHAD//yEAAR4AVwAAAAAgAFkAAAAAHQD//yIAAR4A//8jAAEfAP//JAABIAD//yUAASgAXQAAAAAwAGsAAAAAJABfAAAAACgAZQAAAAAiAGEAAAAAJABjAAAAACEA//8mAAEiAP//JwABIwD//ygAASQA//8pAAEmAGcAAAAAKABpAAAAACUA//8qAAEmAP//KwABJwD//ywAASgA//8tAAEsAG0AAAAAMABzAAAAACoAbwAAAAAsAHEAAAAAKQD//y4AASoA//8vAAErAP//MAABLAD//zEAAS4AdQAAAAAwAHcAAAAALQD//zIAAS4A//8zAAEvAP//NAABMAD//zUAATQAewA7AAE4AIEAPAABMgB9AAAAADQAfwAAAAAxAP//NgABMgD//zcAATMA//84AAE0AP//OQABNgCDAD8AATgAhQBAAAE1AP//OgABNgD//z0AATcA//8+AAE4AP//QQABOgCJAAAAADwAiwAAAAA5AP//QgABOgD//0UAATsA//9GAAE8AP//RwABQwD//0kAAUQA//9KAAFGAJEAAAAASACTAAAAAEUA//9LAAFGAP//TAABRwD//00AAUgA//9OAAFMAJcAAAAAUACdAAAAAEoAmQAAAABMAJsAAAAASQD//08AAUoA//9QAAFLAP//UQABTAD//1IAAU4AnwAAAABQAKEAAAAATQD//1MAAU4A//9UAAFPAP//VQABUAD//1YAAVgApQAAAABgALMAAAAAVACnAAAAAFgArQAAAABSAKkAAAAAVACrAAAAAFEA//9XAAFSAP//WAABUwD//1kAAVQA//9aAAFWAK8AAAAAWACxAAAAAFUA//9kAAFWAP//WwABVwD//1wAAVgA//9dAAFcALUAAAAAYAC7AAAAAFoAtwAAAABcALkAAAAAWQD//14AAVoA//9fAAFbAP//YAABXAD//2EAAV4AvQAAAABgAL8AAAAAXQD//2IAAV4A//9jAAFfAP//ZQABYAD//2YAAW8AwwAAAAB/AN8AAAAAaADFAAAAAG8A0wAAAABkAMcAAAAAaADNAAAAAGIAyQAAAABkAMsAAAAAYQD//2cAAWIA//9oAAFjAP//aQABZAD//2oAAWYAzwAAAABoANEAAAAAZQD//2sAAWYA//9sAAFnAP//bQABaAD//24AAWwA1QAAAABvANsAAAAAagDXAAAAAGwA2QAAAABpAP//bwABagD//3AAAWsA//9xAAFsAP//cgABbgDdAAAAAG8A//91AAFtAP//cwABbgD//3QAAXcA4QAAAAB/AO8AAAAAcwDjAAAAAHcA6QAAAABxAOUAAAAAcwDnAAAAAHAA//8AAABxAP//dgABcgD//3cAAXMA//94AAF1AOsAAAAAdwDtAAAAAHQA//95AAF1AP//egABdgD//3sAAXcA//98AAF7APEAAAAAfwD3AAAAAHkA8wAAAAB7APUAAAAAeAD//30AAXkA//9+AAF6AP//fwABewD//4AAAX0A+QAAAAB/APsAAAAAfAD//4EAAX0A//8AAAB+AP//AAAAfwD9AAAAAH8A//8AAAB/AP8AAAAAgAD//4IAAX8A//8AAAA= - Metadata: 0x02624D30
	internal static readonly __StaticArrayInitTypeSize_24 EEAB0A49E323B940CB01CCD3E80D47F1566617F04466CD5D6190ACDBC495CB2A; // 0x234F // Static value (base64): AQAAAAIAAAAFAAAABgAAAAUAAAAFAAAA - Metadata: 0x02625438
	internal static readonly __StaticArrayInitTypeSize_104 FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5; // 0x2367 // Static value (base64): DoAAAA+AAAESgAACE4AAAhSAAAIQgAADEYAAAxWAAAMYgAAEGYAABBqAAAQWgAAFF4AABRuAAAUDBAAGBAQABgUECAYGBBAGBwQYBggEIAYMQIAGDUAABwmAAAgcgAAKHYAACwsEAAw= - Metadata: 0x02625458

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 72721
	{
	}

	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 72722
	{
	}

	private struct __StaticArrayInitTypeSize_84 // TypeDefIndex: 72723
	{
	}

	private struct __StaticArrayInitTypeSize_104 // TypeDefIndex: 72724
	{
	}

	private struct __StaticArrayInitTypeSize_262 // TypeDefIndex: 72725
	{
	}

	private struct __StaticArrayInitTypeSize_371 // TypeDefIndex: 72726
	{
	}

	private struct __StaticArrayInitTypeSize_508 // TypeDefIndex: 72727
	{
	}

	private struct __StaticArrayInitTypeSize_976 // TypeDefIndex: 72728
	{
	}

	private struct __StaticArrayInitTypeSize_1036 // TypeDefIndex: 72729
	{
	}

	private struct __StaticArrayInitTypeSize_1799 // TypeDefIndex: 72730
	{
	}

	private struct __StaticArrayInitTypeSize_3983 // TypeDefIndex: 72731
	{
	}
}

namespace Unity.XR.GoogleVr
{
	[InputControlLayout(displayName = "Daydream Headset", hideInUI = true)]
	public class DaydreamHMD : XRHMD // TypeDefIndex: 72101
	{
		// Constructors
		public DaydreamHMD(); // 0x000000018D2E1E18-0x000000018D2E1E20
	}

	[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class DaydreamController : XRController // TypeDefIndex: 72102
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
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl]
		public ButtonControl volumeUp { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl]
		public ButtonControl recentered { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl]
		public ButtonControl volumeDown { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl]
		public ButtonControl recentering { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl]
		public ButtonControl app { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl]
		public ButtonControl home { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
	
		// Constructors
		public DaydreamController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2E1B80-0x000000018D2E1E18
	}
}

namespace Unity.XR.Oculus.Input
{
	[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
	public class OculusHMD : XRHMD // TypeDefIndex: 72095
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
		public ButtonControl userPresence { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234920-0x0000000187234930 0x0000000188A865D0-0x0000000188A865E4
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD00-0x000000018723BD10 0x0000000188DC4534-0x0000000188DC4548
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B240-0x000000018723B250 0x0000000188DC455C-0x0000000188DC4570
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B310-0x000000018723B320 0x0000000188D3C0D0-0x0000000188D3C0E4
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BEC0-0x000000018723BED0 0x0000000188DC482C-0x0000000188DC4840
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BEB0-0x000000018723BEC0 0x0000000188DC4818-0x0000000188DC482C
	
		// Constructors
		public OculusHMD(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2EC2D4-0x000000018D2EC5CC
	}

	[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OculusTouchController : XRControllerWithRumble // TypeDefIndex: 72096
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
		public Vector2Control thumbstick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(aliases = new string[3] {"A", "X", "Alternate" })]
		public ButtonControl primaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl(aliases = new string[3] {"B", "Y", "Primary" })]
		public ButtonControl secondaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl(aliases = new string[1] {"GripButton" })]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl]
		public ButtonControl start { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(aliases = new string[2] {"JoystickOrPadPressed", "thumbstickClick" })]
		public ButtonControl thumbstickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(aliases = new string[4] {"ATouched", "XTouched", "ATouch", "XTouch" })]
		public ButtonControl primaryTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(aliases = new string[4] {"BTouched", "YTouched", "BTouch", "YTouch" })]
		public ButtonControl secondaryTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(aliases = new string[2] {"indexTouch", "indexNearTouched" })]
		public AxisControl triggerTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		[InputControl(aliases = new string[2] {"indexButton", "indexTouched" })]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234920-0x0000000187234930 0x0000000188A865D0-0x0000000188A865E4
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"controllerRotation" })]
		[InputControl(aliases = new string[2] {"JoystickOrPadTouched", "thumbstickTouch" })]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[1] {"controllerTrackingState" })]
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[1] {"ControllerIsTracked" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"controllerPosition" })]
		public ButtonControl thumbstickTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(noisy = true, aliases = new string[1] {"controllerVelocity" })]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD00-0x000000018723BD10 0x0000000188DC4534-0x0000000188DC4548
		[InputControl(noisy = true, aliases = new string[1] {"controllerAcceleration" })]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B240-0x000000018723B250 0x0000000188DC455C-0x0000000188DC4570
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularAcceleration" })]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B310-0x000000018723B320 0x0000000188D3C0D0-0x0000000188D3C0E4
	
		// Constructors
		public OculusTouchController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2EC6A4-0x000000018D2ECA88
	}

	public class OculusTrackingReference : TrackedDevice // TypeDefIndex: 72097
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _trackingState_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private ButtonControl _isTracked_k__BackingField; // 0x1B8
	
		// Properties
		[InputControl(aliases = new string[1] {"trackingReferenceTrackingState" })]
		public new IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(aliases = new string[1] {"trackingReferenceIsTracked" })]
		public new ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
	
		// Constructors
		public OculusTrackingReference(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2ECA88-0x000000018D2ECB34
	}

	[InputControlLayout(displayName = "Oculus Remote", hideInUI = true)]
	public class OculusRemote : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 72098
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
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		[InputControl]
		public ButtonControl start { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
	
		// Constructors
		public OculusRemote(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2EC5CC-0x000000018D2EC6A4
	}

	[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = true)]
	public class OculusHMDExtended : OculusHMD // TypeDefIndex: 72099
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _back_k__BackingField; // 0x248
		[CompilerGenerated]
		private Vector2Control _touchpad_k__BackingField; // 0x250
	
		// Properties
		[InputControl]
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C1C0-0x000000018723C1D0 0x0000000188DC4D04-0x0000000188DC4D18
		[InputControl]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCE0-0x000000018723BCF0 0x0000000188DC44F8-0x0000000188DC450C
	
		// Constructors
		public OculusHMDExtended(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2EC228-0x000000018D2EC2D4
	}

	[InputControlLayout(displayName = "GearVR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class GearVRTrackedController : XRController // TypeDefIndex: 72100
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
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl]
		public ButtonControl back { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
	
		// Constructors
		public GearVRTrackedController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2E202C-0x000000018D2E2268
	}
}

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "OpenVR Headset", hideInUI = true)]
	public class OpenVRHMD : XRHMD // TypeDefIndex: 72088
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
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(noisy = true)]
		public Vector3Control leftEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(noisy = true)]
		public Vector3Control rightEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234920-0x0000000187234930 0x0000000188A865D0-0x0000000188A865E4
		[InputControl(noisy = true)]
		public Vector3Control centerEyeVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
	
		// Constructors
		public OpenVRHMD(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2ECDD8-0x000000018D2ECFB4
	}

	[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVRControllerWMR : XRController // TypeDefIndex: 72089
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
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl touchpadClick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl touchpadTouch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl(aliases = new string[1] {"primary" })]
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(aliases = new string[1] {"secondary2DAxis" })]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(aliases = new string[1] {"primary2DAxis" })]
		public Vector2Control joystick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
	
		// Constructors
		public OpenVRControllerWMR(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2ECB34-0x000000018D2ECDD8
	}

	[InputControlLayout(displayName = "Vive Wand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class ViveWand : XRControllerWithRumble // TypeDefIndex: 72090
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
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl]
		public ButtonControl primary { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl trackpadPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl trackpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl(aliases = new string[1] {"Primary2DAxis" })]
		public Vector2Control trackpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
	
		// Constructors
		public ViveWand(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2F30A8-0x000000018D2F3318
	}

	[InputControlLayout(displayName = "Vive Lighthouse", hideInUI = true)]
	public class ViveLighthouse : TrackedDevice // TypeDefIndex: 72091
	{
		// Constructors
		public ViveLighthouse(); // 0x000000018D2E1E18-0x000000018D2E1E20
	}

	[InputControlLayout(displayName = "Vive Tracker")]
	public class ViveTracker : TrackedDevice // TypeDefIndex: 72092
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		[CompilerGenerated]
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1B8
	
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
	
		// Constructors
		public ViveTracker(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2F3008-0x000000018D2F30A8
	}

	[InputControlLayout(displayName = "Handed Vive Tracker", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HandedViveTracker : ViveTracker // TypeDefIndex: 72093
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
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl]
		public ButtonControl primary { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl(aliases = new string[1] {"JoystickOrPadPressed" })]
		public ButtonControl trackpadPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
	
		// Constructors
		public HandedViveTracker(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2E2268-0x000000018D2E23B4
	}

	[InputControlLayout(displayName = "Oculus Touch Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVROculusTouchController : XRControllerWithRumble // TypeDefIndex: 72094
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
		public Vector2Control thumbstick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(aliases = new string[1] {"Alternate" })]
		public ButtonControl primaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl(aliases = new string[1] {"Primary" })]
		public ButtonControl secondaryButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(aliases = new string[1] {"primary2DAxisClicked" })]
		public ButtonControl thumbstickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(aliases = new string[1] {"primary2DAxisTouch" })]
		public ButtonControl thumbstickTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
	
		// Constructors
		public OpenVROculusTouchController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2ECFB4-0x000000018D2ED258
	}
}

namespace UnityEngine.InputSystem
{
	public interface IInputActionCollection : IEnumerable<InputAction> // TypeDefIndex: 72106
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

	public interface IInputActionCollection2 : IInputActionCollection // TypeDefIndex: 72107
	{
		// Properties
		IEnumerable<InputBinding> bindings { get; }
	
		// Methods
		InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x026227E4 */);
		int FindBinding(InputBinding mask, out InputAction action);
	}

	public interface IInputInteraction // TypeDefIndex: 72108
	{
		// Methods
		void Process(ref InputInteractionContext context);
		void Reset();
	}

	public interface IInputInteraction<TValue> : IInputInteraction // TypeDefIndex: 72109
		where TValue : struct
	{
	}

	internal static class InputInteraction // TypeDefIndex: 72110
	{
		// Fields
		public static TypeTable s_Interactions; // 0x00
	
		// Methods
		public static System.Type GetValueType(System.Type interactionType); // 0x000000018D2EC154-0x000000018D2EC228
		public static string GetDisplayName(string interaction); // 0x000000018D2EC078-0x000000018D2EC154
		public static string GetDisplayName(System.Type interactionType); // 0x000000018D2EBF28-0x000000018D2EC078
	}

	[Serializable]
	public sealed class InputAction : ICloneable, IDisposable // TypeDefIndex: 72113
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
		public string name { get; } // 0x00000001829260F0-0x0000000182926100 
		public UnityEngine.InputSystem.InputActionType type { get; } // 0x00000001844AF510-0x00000001844AF520 
		public Guid id { get; } // 0x000000018D2EBAF8-0x000000018D2EBB38 
		internal Guid idDontGenerate { get; } // 0x0000000185B041B0-0x0000000185B04200 
		public string expectedControlType { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string processors { get; } // 0x00000001829600D0-0x00000001829600E0 
		public string interactions { get; } // 0x0000000182986470-0x0000000182986480 
		public InputActionMap actionMap { get; } // 0x000000018D2EB9A0-0x000000018D2EB9C8 
		public InputBinding? bindingMask { get; set; } // 0x0000000187259710-0x0000000187259750 0x000000018D2EBC58-0x000000018D2EBF0C
		public ReadOnlyArray<InputBinding> bindings { get; } // 0x000000018D2EBAA8-0x000000018D2EBAF8 
		public ReadOnlyArray<InputControl> controls { get; } // 0x0000000185B017C0-0x0000000185B01830 
		public InputActionPhase phase { get; } // 0x0000000185B030D0-0x0000000185B03100 
		public bool inProgress { get; } // 0x000000018D2EBB38-0x000000018D2EBB50 
		public bool enabled { get; } // 0x0000000185B030B0-0x0000000185B030D0 
		public bool triggered { get; } // 0x000000018D2EBB6C-0x000000018D2EBB74 
		public InputControl activeControl { get; } // 0x000000018D2EB9C8-0x000000018D2EBA3C 
		public System.Type activeValueType { get; } // 0x000000018D2EBA3C-0x000000018D2EBAA8 
		public bool wantsInitialStateCheck { get; set; } // 0x0000000186318170-0x0000000186318180 0x000000018D2EBF0C-0x000000018D2EBF28
		internal bool isSingletonAction { get; } // 0x000000018D2EBB50-0x000000018D2EBB6C 
		private InputActionState.TriggerState currentState { get; } // 0x0000000185B03100-0x0000000185B03190 
	
		// Events
		public event Action<CallbackContext> started {
			add; // 0x000000018D2EB954-0x000000018D2EB9A0
			remove; // 0x000000018D2EBC0C-0x000000018D2EBC58
		}
		public event Action<CallbackContext> canceled {
			add; // 0x0000000185B02770-0x0000000185B027C0
			remove; // 0x000000018D2EBB74-0x000000018D2EBBC0
		}
		public event Action<CallbackContext> performed {
			add; // 0x0000000185B027C0-0x0000000185B02810
			remove; // 0x000000018D2EBBC0-0x000000018D2EBC0C
		}
	
		// Nested types
		[Flags]
		internal enum ActionFlags // TypeDefIndex: 72111
		{
			WantsInitialStateCheck = 1
		}
	
		public struct CallbackContext // TypeDefIndex: 72112
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal int m_ActionIndex; // 0x08
	
			// Properties
			private int actionIndex { get; } // 0x0000000184431A70-0x0000000184431A80 
			private int bindingIndex { get; } // 0x000000018526F8D0-0x000000018526F900 
			private int controlIndex { get; } // 0x000000018526F2D0-0x000000018526F310 
			private int interactionIndex { get; } // 0x000000018D2E19E8-0x000000018D2E1A18 
			public InputActionPhase phase { get; } // 0x0000000185270020-0x0000000185270040 
			public bool started { get; } // 0x000000018D2E1AA0-0x000000018D2E1AB8 
			public bool performed { get; } // 0x000000018D2E1A68-0x000000018D2E1A80 
			public bool canceled { get; } // 0x000000018526FFF0-0x0000000185270020 
			public InputAction action { get; } // 0x000000018526DB40-0x000000018526DC00 
			public InputControl control { get; } // 0x000000018526E1B0-0x000000018526E210 
			public IInputInteraction interaction { get; } // 0x000000018D2E1A18-0x000000018D2E1A68 
			public double time { get; } // 0x000000018D2E1AB8-0x000000018D2E1AD8 
			public double startTime { get; } // 0x000000018D2E1A80-0x000000018D2E1AA0 
			public double duration { get; } // 0x000000018D2E19B4-0x000000018D2E19E8 
			public System.Type valueType { get; } // 0x000000018D2E1B2C-0x000000018D2E1B80 
			public int valueSizeInBytes { get; } // 0x000000018D2E1AD8-0x000000018D2E1B2C 
	
			// Methods
			public unsafe void ReadValue(void* buffer, int bufferSize); // 0x000000018D2E1644-0x000000018D2E1808
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public bool ReadValueAsButton(); // 0x000000018526CF00-0x000000018526CF80
			public object ReadValueAsObject(); // 0x000000018D2E15C4-0x000000018D2E1644
			public override string ToString(); // 0x000000018D2E1808-0x000000018D2E19B4
		}
	
		// Constructors
		public InputAction(); // 0x0000000185959700-0x0000000185959800
		public InputAction(string name = null, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x026227E5 */, string binding = null, string interactions = null, string processors = null, string expectedControlType = null); // 0x000000018D2EB728-0x000000018D2EB954
		static InputAction(); // 0x0000000187110300-0x00000001871103A0
	
		// Methods
		public void Dispose(); // 0x000000018D2EAB98-0x000000018D2EABB8
		public override string ToString(); // 0x000000018D2EB120-0x000000018D2EB3C8
		public void Enable(); // 0x0000000185B02850-0x0000000185B03080
		public void Disable(); // 0x000000018D2EAA8C-0x000000018D2EAB98
		public InputAction Clone(); // 0x000000018D2EA888-0x000000018D2EA9B8
		object ICloneable.Clone(); // 0x000000018D2EB118-0x000000018D2EB120
		public TValue ReadValue<TValue>()
			where TValue : struct;
		public object ReadValueAsObject(); // 0x000000018D2EAFF0-0x000000018D2EB074
		public float GetControlMagnitude(); // 0x000000018D2EADE8-0x000000018D2EAE34
		public void Reset(); // 0x000000018D2EB0B0-0x000000018D2EB118
		public bool IsPressed(); // 0x000000018D2EAFA8-0x000000018D2EAFF0
		public bool IsInProgress(); // 0x000000018D2EAF5C-0x000000018D2EAFA8
		private int ExpectedFrame(); // 0x000000018D2EABB8-0x000000018D2EAC1C
		public bool WasPressedThisFrame(); // 0x000000018D2EB5D4-0x000000018D2EB650
		public bool WasPressedThisDynamicUpdate(); // 0x000000018D2EB578-0x000000018D2EB5D4
		public bool WasReleasedThisFrame(); // 0x000000018D2EB6AC-0x000000018D2EB728
		public bool WasReleasedThisDynamicUpdate(); // 0x000000018D2EB650-0x000000018D2EB6AC
		public bool WasPerformedThisFrame(); // 0x000000018D2EB4FC-0x000000018D2EB578
		public bool WasPerformedThisDynamicUpdate(); // 0x000000018D2EB4A0-0x000000018D2EB4FC
		public bool WasCompletedThisFrame(); // 0x000000018D2EB424-0x000000018D2EB4A0
		public bool WasCompletedThisDynamicUpdate(); // 0x000000018D2EB3C8-0x000000018D2EB424
		public float GetTimeoutCompletionPercentage(); // 0x000000018D2EAE34-0x000000018D2EAF5C
		internal string MakeSureIdIsInPlace(); // 0x0000000186E623F0-0x0000000186E62420
		internal void GenerateId(); // 0x000000018D2EAD78-0x000000018D2EADE8
		internal InputActionMap GetOrCreateActionMap(); // 0x0000000185B03080-0x0000000185B030B0
		private void CreateInternalActionMapForSingletonAction(); // 0x000000018D2EA9B8-0x000000018D2EAA8C
		internal void RequestInitialStateCheckOnEnabledAction(); // 0x000000018D2EB074-0x000000018D2EB0B0
		internal bool ActiveControlIsValid(InputControl control); // 0x000000018D2EA590-0x000000018D2EA670
		internal InputBinding? FindEffectiveBindingMask(); // 0x000000018D2EAC1C-0x000000018D2EAD78
		internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction); // 0x000000018D2EA670-0x000000018D2EA7E8
		internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap); // 0x000000018D2EA7E8-0x000000018D2EA888
	}

	public class InputActionAsset : ScriptableObject, IInputActionCollection2 // TypeDefIndex: 72119
	{
		// Fields
		public const string Extension = "inputactions"; // Metadata: 0x026227E9
		internal const string kDefaultAssetLayoutJson = "{}"; // Metadata: 0x026227F6
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
		public bool enabled { get; } // 0x000000018D2E3914-0x000000018D2E3A44 
		public ReadOnlyArray<InputActionMap> actionMaps { get; } // 0x0000000186811700-0x0000000186811760 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018D2E38C0-0x000000018D2E3914 
		public IEnumerable<InputBinding> bindings { [IteratorStateMachine(typeof(_get_bindings_d__9))] get; } // 0x000000018D2E3850-0x000000018D2E38C0 
		public InputBinding? bindingMask { get; set; } // 0x0000000187259690-0x00000001872596D0 0x000000018D2E3A44-0x000000018D2E3BE8
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x0000000187835798-0x00000001878357D0 0x000000018D2E3BE8-0x000000018D2E3C30
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018D2E37BC-0x000000018D2E3850 
	
		// Nested types
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 72114
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.WriteMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
		}
	
		[Serializable]
		internal struct WriteFileJsonNoName // TypeDefIndex: 72115
		{
			// Fields
			public InputActionMap.WriteMapJson[] maps; // 0x00
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x08
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 72116
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.ReadMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
	
			// Methods
			public void ToAsset(InputActionAsset asset); // 0x000000018D2EEB0C-0x000000018D2EEBD8
		}
	
		[CompilerGenerated]
		private sealed class _get_bindings_d__9 : IEnumerable<InputBinding>, IEnumerator<InputBinding> // TypeDefIndex: 72117
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
			InputBinding IEnumerator<UnityEngine.InputSystem.InputBinding>.Current { [DebuggerHidden] get; } // 0x00000001872597B0-0x00000001872597F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D2F2F70-0x000000018D2F2FEC 
	
			// Constructors
			[DebuggerHidden]
			public _get_bindings_d__9(int __1__state); // 0x000000018D2F2FEC-0x000000018D2F3008
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D2F2CE0-0x000000018D2F2E8C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2F2F24-0x000000018D2F2F70
			[DebuggerHidden]
			IEnumerator<InputBinding> IEnumerable<InputBinding>.GetEnumerator(); // 0x000000018D2F2E8C-0x000000018D2F2F1C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D2F2F1C-0x000000018D2F2F24
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__32 : IEnumerator<InputAction> // TypeDefIndex: 72118
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
			InputAction IEnumerator<UnityEngine.InputSystem.InputAction>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__32(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D2F2B6C-0x000000018D2F2C94
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2F2C94-0x000000018D2F2CE0
		}
	
		// Constructors
		public InputActionAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public string ToJson(); // 0x000000018D2E3700-0x000000018D2E37BC
		public void LoadFromJson(string json); // 0x000000018D2E345C-0x000000018D2E352C
		public static InputActionAsset FromJson(string json); // 0x000000018D2E3178-0x000000018D2E3230
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x026227E7 */); // 0x000000018D2E2AE4-0x000000018D2E2E4C
		public int FindBinding(InputBinding mask, out InputAction action); // 0x000000018D2E2E4C-0x000000018D2E2F80
		public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false /* Metadata: 0x026227E8 */); // 0x000000018D2E27A4-0x000000018D2E2A00
		public InputActionMap FindActionMap(Guid id); // 0x000000018D2E2A00-0x000000018D2E2AE4
		public InputAction FindAction(Guid guid); // 0x0000000185B03990-0x0000000185B03A50
		public int FindControlSchemeIndex(string name); // 0x000000018D2E2F80-0x000000018D2E3048
		public InputControlScheme? FindControlScheme(string name); // 0x000000018D2E3048-0x000000018D2E3178
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D2E3300-0x000000018D2E345C
		public void Enable(); // 0x000000018D2E2674-0x000000018D2E27A4
		public void Disable(); // 0x000000018D2E2544-0x000000018D2E2674
		public bool Contains(InputAction action); // 0x000000018D2E24D4-0x000000018D2E2544
		[IteratorStateMachine(typeof(_GetEnumerator_d__32))]
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018D2E3230-0x000000018D2E328C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D2E36F8-0x000000018D2E3700
		internal void MarkAsDirty(); // 0x0000000186805BA0-0x0000000186805BB0
		internal bool IsEmpty(); // 0x000000018D2E328C-0x000000018D2E3300
		internal void OnWantToChangeSetup(); // 0x000000018D2E35E0-0x000000018D2E3638
		internal void OnSetupChanged(); // 0x000000018D2E3568-0x000000018D2E35E0
		private void ReResolveIfNecessary(bool fullResolve); // 0x000000018D2E3638-0x000000018D2E3674
		internal void ResolveBindingsIfNecessary(); // 0x000000018D2E3674-0x000000018D2E36F8
		private void OnDestroy(); // 0x000000018D2E352C-0x000000018D2E3568
	}

	public enum InputActionChange // TypeDefIndex: 72120
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
	public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IDisposable // TypeDefIndex: 72132
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
		public string name { get; } // 0x00000001829260F0-0x0000000182926100 
		public InputActionAsset asset { get; } // 0x000000018225E800-0x000000018225E810 
		public Guid id { get; } // 0x000000018D2E4F04-0x000000018D2E4F50 
		internal Guid idDontGenerate { get; } // 0x000000018D2E4EB8-0x000000018D2E4F04 
		public bool enabled { get; } // 0x000000018CF3937C-0x000000018CF39384 
		public ReadOnlyArray<InputAction> actions { get; } // 0x000000018D2E4D74-0x000000018D2E4DC8 
		public ReadOnlyArray<InputBinding> bindings { get; } // 0x000000018D2E4DD4-0x000000018D2E4E28 
		IEnumerable<InputBinding> IInputActionCollection2.bindings { get; } // 0x000000018D2E4BD4-0x000000018D2E4C2C 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018D2E4E28-0x000000018D2E4EB8 
		public InputBinding? bindingMask { get; set; } // 0x00000001872596D0-0x0000000187259710 0x000000018D2E4F9C-0x000000018D2E5154
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x000000018526B530-0x000000018526B5D0 0x000000018D2E5154-0x000000018D2E519C
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018D2E4C78-0x000000018D2E4D74 
		private bool needToResolveBindings { get; set; } // 0x0000000185B02840-0x0000000185B02850 0x00000001868116E0-0x0000000186811700
		private bool bindingResolutionNeedsFullReResolve { get; set; } // 0x00000001868114D0-0x00000001868114E0 0x00000001868116C0-0x00000001868116E0
		private bool controlsForEachActionInitialized { get; set; } // 0x0000000185B01650-0x0000000185B01660 0x00000001868116A0-0x00000001868116C0
		private bool bindingsForEachActionInitialized { get; set; } // 0x000000018D2E4DC8-0x000000018D2E4DD4 0x0000000186811680-0x00000001868116A0
	
		// Events
		public event Action<InputAction.CallbackContext> actionTriggered {
			add; // 0x000000018D2E4C2C-0x000000018D2E4C78
			remove; // 0x000000018D2E4F50-0x000000018D2E4F9C
		}
	
		// Nested types
		[Flags]
		private enum Flags // TypeDefIndex: 72121
		{
			NeedToResolveBindings = 1,
			BindingResolutionNeedsFullReResolve = 2,
			ControlsForEachActionInitialized = 4,
			BindingsForEachActionInitialized = 8
		}
	
		internal struct DeviceArray // TypeDefIndex: 72122
		{
			// Fields
			private bool m_HaveValue; // 0x00
			private int m_DeviceCount; // 0x04
			private UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x08
	
			// Methods
			public int IndexOf(UnityEngine.InputSystem.InputDevice device); // 0x000000018D2E1E20-0x000000018D2E1E70
			public bool Remove(UnityEngine.InputSystem.InputDevice device); // 0x000000018D2E1E70-0x000000018D2E1ED8
			public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? Get(); // 0x000000018526B5D0-0x000000018526B640
			public bool Set(ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices); // 0x000000018D2E1ED8-0x000000018D2E202C
		}
	
		[Serializable]
		internal struct BindingOverrideListJson // TypeDefIndex: 72123
		{
			// Fields
			public List<BindingOverrideJson> bindings; // 0x00
		}
	
		[Serializable]
		internal struct BindingOverrideJson // TypeDefIndex: 72124
		{
			// Fields
			public string action; // 0x00
			public string id; // 0x08
			public string path; // 0x10
			public string interactions; // 0x18
			public string processors; // 0x20
	
			// Methods
			public static BindingOverrideJson FromBinding(InputBinding binding, string actionName); // 0x000000018D2E1308-0x000000018D2E1428
			public static BindingOverrideJson FromBinding(InputBinding binding); // 0x000000018D2E1428-0x000000018D2E14A4
			public static InputBinding ToBinding(BindingOverrideJson bindingOverride); // 0x000000018D2E14A4-0x000000018D2E15C4
		}
	
		[Serializable]
		internal struct BindingJson // TypeDefIndex: 72125
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
			public InputBinding ToBinding(); // 0x000000018D2E11E4-0x000000018D2E1308
			public static BindingJson FromBinding(ref InputBinding binding); // 0x000000018D2E112C-0x000000018D2E11E4
		}
	
		[Serializable]
		internal struct ReadActionJson // TypeDefIndex: 72126
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
			public InputAction ToAction(string actionName = null); // 0x000000018D2EE8D0-0x000000018D2EEB0C
		}
	
		[Serializable]
		internal struct WriteActionJson // TypeDefIndex: 72127
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
			public static WriteActionJson FromAction(InputAction action); // 0x000000018D2F3774-0x000000018D2F3864
		}
	
		[Serializable]
		internal struct ReadMapJson // TypeDefIndex: 72128
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public ReadActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
		}
	
		[Serializable]
		internal struct WriteMapJson // TypeDefIndex: 72129
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public WriteActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
	
			// Methods
			public static WriteMapJson FromMap(InputActionMap map); // 0x000000018D2F3B38-0x000000018D2F3E30
		}
	
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 72130
		{
			// Fields
			public WriteMapJson[] maps; // 0x00
	
			// Methods
			public static WriteFileJson FromMap(InputActionMap map); // 0x000000018D2F3864-0x000000018D2F3904
			public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps); // 0x000000018D2F3904-0x000000018D2F3B38
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 72131
		{
			// Fields
			public ReadActionJson[] actions; // 0x00
			public ReadMapJson[] maps; // 0x08
	
			// Methods
			public InputActionMap[] ToMaps(); // 0x000000018D2EEBD8-0x000000018D2EF9BC
		}
	
		// Constructors
		public InputActionMap(); // 0x0000000186CD83E0-0x0000000186CD8440
		public InputActionMap(string name); // 0x0000000186CD83B0-0x0000000186CD83E0
		static InputActionMap(); // 0x00000001871DD0D0-0x00000001871DD130
	
		// Methods
		public void Dispose(); // 0x000000018D2E3EEC-0x000000018D2E3F00
		internal int FindActionIndex(string nameOrId); // 0x000000018526C3F0-0x000000018526C4E0
		private void SetUpActionLookupTable(); // 0x000000018526C4E0-0x000000018526C610
		internal void ClearActionLookupTable(); // 0x00000001868115F0-0x0000000186811630
		private int FindActionIndex(Guid id); // 0x0000000185B04030-0x0000000185B041B0
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x02622802 */); // 0x000000018526CB00-0x000000018526CB70
		public InputAction FindAction(Guid id); // 0x0000000185B03A50-0x0000000185B03AA0
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D2E433C-0x000000018D2E4460
		public void Enable(); // 0x000000018D2E3F00-0x000000018D2E3F44
		public void Disable(); // 0x000000018D2E3EBC-0x000000018D2E3EEC
		public InputActionMap Clone(); // 0x000000018D2E3C30-0x000000018D2E3E90
		object ICloneable.Clone(); // 0x000000018D2E4A28-0x000000018D2E4A30
		public bool Contains(InputAction action); // 0x000000018D2E3E90-0x000000018D2E3EBC
		public override string ToString(); // 0x000000018D2E4B38-0x000000018D2E4BD4
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018D2E42AC-0x000000018D2E433C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D2E4A20-0x000000018D2E4A28
		internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action); // 0x000000018D2E4218-0x000000018D2E42AC
		internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action); // 0x0000000185B01660-0x0000000185B01700
		private void SetUpPerActionControlAndBindingArrays(); // 0x000000018526C610-0x000000018526CB00
		internal void OnWantToChangeSetup(); // 0x000000018D2E47B4-0x000000018D2E4A20
		internal void OnSetupChanged(); // 0x000000018D2E4554-0x000000018D2E47B4
		internal void OnBindingModified(); // 0x000000018D2E452C-0x000000018D2E4554
		internal void ClearCachedActionData(bool onlyControls = false /* Metadata: 0x02622803 */); // 0x0000000186811630-0x0000000186811680
		internal void GenerateId(); // 0x000000018D2E41A8-0x000000018D2E4218
		internal bool LazyResolveBindings(bool fullResolve); // 0x000000018D2E4460-0x000000018D2E452C
		internal bool ResolveBindingsIfNecessary(); // 0x0000000185B02810-0x0000000185B02840
		internal void ResolveBindings(); // 0x000000018680FF90-0x00000001868114D0
		public int FindBinding(InputBinding mask, out InputAction action); // 0x000000018D2E3FD0-0x000000018D2E40F0
		internal int FindBindingRelativeToMap(InputBinding mask); // 0x000000018D2E3F44-0x000000018D2E3FD0
		public static InputActionMap[] FromJson(string json); // 0x000000018D2E40F0-0x000000018D2E41A8
		public static string ToJson(IEnumerable<InputActionMap> maps); // 0x000000018D2E4A30-0x000000018D2E4AE0
		public string ToJson(); // 0x000000018D2E4AE0-0x000000018D2E4B38
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x00000001868114E0-0x00000001868115F0
	}

	public static class InputActionRebindingExtensions // TypeDefIndex: 72142
	{
		// Fields
		private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x00
	
		// Nested types
		internal struct Parameter // TypeDefIndex: 72133
		{
			// Fields
			public object instance; // 0x00
			public System.Reflection.FieldInfo field; // 0x08
			public int bindingIndex; // 0x10
		}
	
		private struct ParameterEnumerable : IEnumerable<Parameter> // TypeDefIndex: 72134
		{
			// Fields
			private InputActionState m_State; // 0x00
			private ParameterOverride m_Parameter; // 0x08
			private int m_MapIndex; // 0x80
	
			// Constructors
			public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x0262280F */); // 0x000000018D2ED4F4-0x000000018D2ED56C
	
			// Methods
			public ParameterEnumerator GetEnumerator(); // 0x000000018D2ED258-0x000000018D2ED37C
			IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(); // 0x000000018D2ED37C-0x000000018D2ED438
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D2ED438-0x000000018D2ED4F4
		}
	
		private struct ParameterEnumerator : IEnumerator<Parameter> // TypeDefIndex: 72135
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
			public Parameter Current { get; } // 0x000000018D2EDCE4-0x000000018D2EDD30 
			object IEnumerator.Current { get; } // 0x000000018D2EDA3C-0x000000018D2EDA9C 
	
			// Constructors
			public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x02622810 */); // 0x000000018D2EDA9C-0x000000018D2EDCE4
	
			// Methods
			private bool MoveToNextBinding(); // 0x000000018D2ED714-0x000000018D2ED880
			private bool MoveToNextInteraction(); // 0x000000018D2ED880-0x000000018D2ED8E4
			private bool MoveToNextProcessor(); // 0x000000018D2ED8E4-0x000000018D2ED948
			private bool FindParameter(object instance); // 0x000000018D2ED56C-0x000000018D2ED658
			public bool MoveNext(); // 0x000000018D2ED658-0x000000018D2ED714
			public void Reset(); // 0x000000018D2ED948-0x000000018D2EDA3C
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		internal struct ParameterOverride // TypeDefIndex: 72136
		{
			// Fields
			public string objectRegistrationName; // 0x00
			public string parameter; // 0x08
			public InputBinding bindingMask; // 0x10
			public PrimitiveValue value; // 0x68
	
			// Properties
			public System.Type objectType { get; } // 0x000000018D2EE838-0x000000018D2EE8D0 
	
			// Constructors
			public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default); // 0x000000018D2EE748-0x000000018D2EE838
			public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default); // 0x000000018D2EE6CC-0x000000018D2EE748
	
			// Methods
			public static ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName); // 0x000000018D2EE0C0-0x000000018D2EE33C
			private static ParameterOverride? Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName); // 0x000000018D2EDD30-0x000000018D2EE0C0
			private static ParameterOverride? PickMoreSpecificOne(ParameterOverride? first, ParameterOverride? second); // 0x000000018D2EE33C-0x000000018D2EE6CC
		}
	
		public sealed class RebindingOperation : IDisposable // TypeDefIndex: 72139
		{
			// Fields
			public const float kDefaultMagnitudeThreshold = 0.2f; // Metadata: 0x02622816
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
			public InputAction action { get; } // 0x00000001829260F0-0x0000000182926100 
			public InputBinding? bindingMask { get; } // 0x0000000187244F20-0x0000000187244F60 
			public InputControlList<InputControl> candidates { get; } // 0x0000000187259780-0x00000001872597A0 
			public ReadOnlyArray<float> scores { get; } // 0x000000018D2F2A90-0x000000018D2F2B04 
			public ReadOnlyArray<float> magnitudes { get; } // 0x000000018D2F2A1C-0x000000018D2F2A90 
			public InputControl selectedControl { get; } // 0x000000018D2F2B04-0x000000018D2F2B60 
			public bool started { get; } // 0x000000018D2F2B60-0x000000018D2F2B6C 
			public bool completed { get; } // 0x000000018D2F29EC-0x000000018D2F29F8 
			public bool canceled { get; } // 0x000000018D2F29E0-0x000000018D2F29EC 
			public double startTime { get; } // 0x000000018724ED50-0x000000018724ED60 
			public float timeout { get; } // 0x00000001872597A0-0x00000001872597B0 
			public string expectedControlType { get; } // 0x000000018D2F29F8-0x000000018D2F2A1C 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 72137
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
			private sealed class __c__DisplayClass32_0 // TypeDefIndex: 72138
			{
				// Fields
				public string group; // 0x10
	
				// Constructors
				public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _WithTargetBinding_b__0(InputControlScheme x); // 0x000000018D2FF7A4-0x000000018D2FF7D0
			}
	
			// Constructors
			public RebindingOperation(); // 0x000000018D2F2950-0x000000018D2F29E0
	
			// Methods
			public RebindingOperation WithAction(InputAction action); // 0x000000018D2F1AA0-0x000000018D2F1BE8
			public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true /* Metadata: 0x02622811 */); // 0x000000018D2F22F8-0x000000018D2F2340
			public RebindingOperation WithCancelingThrough(string binding); // 0x000000018D2F1D3C-0x000000018D2F1D74
			public RebindingOperation WithCancelingThrough(InputControl control); // 0x000000018D2F1D74-0x000000018D2F1E08
			public RebindingOperation WithExpectedControlType(string layoutName); // 0x000000018D2F21C8-0x000000018D2F2220
			public RebindingOperation WithExpectedControlType(System.Type type); // 0x000000018D2F2078-0x000000018D2F21C8
			public RebindingOperation WithExpectedControlType<TControl>()
				where TControl : InputControl;
			public RebindingOperation WithTargetBinding(int bindingIndex); // 0x000000018D2F236C-0x000000018D2F2930
			public RebindingOperation WithBindingMask(InputBinding? bindingMask); // 0x000000018D2F1CF4-0x000000018D2F1D3C
			public RebindingOperation WithBindingGroup(string group); // 0x000000018D2F1BE8-0x000000018D2F1CF4
			public RebindingOperation WithoutGeneralizingPathOfSelectedControl(); // 0x0000000187259770-0x0000000187259780
			public RebindingOperation WithRebindAddingNewBinding(string group = null); // 0x000000018D2F2340-0x000000018D2F236C
			public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude); // 0x000000018D2F2220-0x000000018D2F22F8
			public RebindingOperation WithoutIgnoringNoisyControls(); // 0x000000018D2F2930-0x000000018D2F2950
			public RebindingOperation WithControlsHavingToMatchPath(string path); // 0x000000018D2F1F40-0x000000018D2F2078
			public RebindingOperation WithControlsExcluding(string path); // 0x000000018D2F1E08-0x000000018D2F1F40
			public RebindingOperation WithTimeout(float timeInSeconds); // 0x0000000187259760-0x0000000187259770
			public RebindingOperation OnComplete(Action<RebindingOperation> callback); // 0x000000018D2F0478-0x000000018D2F049C
			public RebindingOperation OnCancel(Action<RebindingOperation> callback); // 0x000000018D2F0098-0x000000018D2F00BC
			public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback); // 0x000000018D2F13BC-0x000000018D2F13E0
			public RebindingOperation OnGeneratePath(Func<InputControl, string> callback); // 0x000000018D2F1398-0x000000018D2F13BC
			public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback); // 0x000000018D2F049C-0x000000018D2F04C0
			public RebindingOperation OnApplyBinding(Action<RebindingOperation, string> callback); // 0x000000018D2F003C-0x000000018D2F0060
			public RebindingOperation OnMatchWaitForAnother(float seconds); // 0x0000000187259750-0x0000000187259760
			public RebindingOperation Start(); // 0x000000018D2F17D0-0x000000018D2F1978
			public void Cancel(); // 0x000000018D2EFB4C-0x000000018D2EFB60
			public void Complete(); // 0x000000018D2EFB60-0x000000018D2EFB74
			public void AddCandidate(InputControl control, float score, float magnitude = -1f /* Metadata: 0x02622812 */); // 0x000000018D2EF9BC-0x000000018D2EFB4C
			public void RemoveCandidate(InputControl control); // 0x000000018D2F13E0-0x000000018D2F14EC
			public void Dispose(); // 0x000000018D2EFB74-0x000000018D2EFBD8
			~RebindingOperation(); // 0x000000018D2EFBD8-0x000000018D2EFC4C
			public RebindingOperation Reset(); // 0x000000018D2F1598-0x000000018D2F1690
			private void HookOnEvent(); // 0x000000018D2EFEC8-0x000000018D2EFF90
			private void UnhookOnEvent(); // 0x000000018D2F1A48-0x000000018D2F1AA0
			private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018D2F04C0-0x000000018D2F1398
			private void SortCandidatesByScore(); // 0x000000018D2F1690-0x000000018D2F17D0
			private static bool HavePathMatch(InputControl control, string[] paths, int pathCount); // 0x000000018D2EFD7C-0x000000018D2EFE00
			private void HookOnAfterUpdate(); // 0x000000018D2EFE00-0x000000018D2EFEC8
			private void UnhookOnAfterUpdate(); // 0x000000018D2F19E4-0x000000018D2F1A48
			private void OnAfterUpdate(); // 0x000000018D2EFF90-0x000000018D2F003C
			private void OnComplete(); // 0x000000018D2F00BC-0x000000018D2F0478
			private void OnCancel(); // 0x000000018D2F0060-0x000000018D2F0098
			private void ResetAfterMatchCompleted(); // 0x000000018D2F14EC-0x000000018D2F1598
			private void ThrowIfRebindInProgress(); // 0x000000018D2F1978-0x000000018D2F19E4
			private string GeneratePathForControl(InputControl control); // 0x000000018D2EFC4C-0x000000018D2EFD7C
		}
	
		internal class DeferBindingResolutionWrapper : IDisposable // TypeDefIndex: 72140
		{
			// Constructors
			public DeferBindingResolutionWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Acquire(); // 0x000000018526F5C0-0x000000018526F600
			public void Dispose(); // 0x0000000185B01830-0x0000000185B018E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 72141
		{
			// Fields
			public ReadOnlyArray<InputBinding> bindings; // 0x10
			public int firstPartIndex; // 0x20
			public string[] partStrings; // 0x28
			public int partCount; // 0x30
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _GetBindingDisplayString_b__0(string fragment); // 0x000000018D2FF654-0x000000018D2FF7A4
		}
	
		// Methods
		private static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default, PrimitiveValue value = default);
		private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride); // 0x000000018D2E601C-0x000000018D2E6810
		internal static DeferBindingResolutionWrapper DeferBindingResolution(); // 0x000000018526F500-0x000000018526F5C0
	
		// Extension methods
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, InputBinding bindingMask = default); // 0x000000018D2E8240-0x000000018D2E842C
		private static PrimitiveValue? GetParameterValue(this InputAction action, ParameterOverride parameterOverride); // 0x000000018D2E842C-0x000000018D2E8794
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, int bindingIndex); // 0x000000018D2E8794-0x000000018D2E8A4C
		public static TValue? GetParameterValue<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct;
		public static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018D2E6A30-0x000000018D2E6C34
		public static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018D2E6EE0-0x000000018D2E7118
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = default); // 0x000000018D2E6810-0x000000018D2E6A30
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex); // 0x000000018D2E6C34-0x000000018D2E6EE0
		public static int GetBindingIndex(this InputAction action, InputBinding bindingMask); // 0x000000018D2E7E88-0x000000018D2E7FD4
		public static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask); // 0x000000018D2E80F4-0x000000018D2E8240
		public static int GetBindingIndex(this InputAction action, string group = null, string path = null); // 0x000000018D2E7FD4-0x000000018D2E80F4
		public static InputBinding? GetBindingForControl(this InputAction action, InputControl control); // 0x000000018D2E7AD4-0x000000018D2E7CD8
		public static int GetBindingIndexForControl(this InputAction action, InputControl control); // 0x000000018D2E7CD8-0x000000018D2E7E88
		public static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options =  /* Metadata: 0x02622808 */, string group = null); // 0x000000018D2E7710-0x000000018D2E78C8
		public static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options =  /* Metadata: 0x02622809 */); // 0x000000018D2E78C8-0x000000018D2E7AD4
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0262280A */); // 0x000000018D2E7118-0x000000018D2E71A8
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options =  /* Metadata: 0x0262280B */); // 0x000000018D2E71A8-0x000000018D2E7710
		public static void ApplyBindingOverride(this InputAction action, string newPath, string group = null, string path = null); // 0x000000018D2E535C-0x000000018D2E5478
		public static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride); // 0x000000018D2E5580-0x000000018D2E56A0
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride); // 0x000000018D2E56A0-0x000000018D2E5798
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path); // 0x000000018D2E5478-0x000000018D2E5580
		public static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride); // 0x000000018D2E5798-0x000000018D2E58EC
		public static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride); // 0x000000018D2E58EC-0x000000018D2E5ACC
		public static void RemoveBindingOverride(this InputAction action, int bindingIndex); // 0x000000018D2E99D8-0x000000018D2E9AB4
		public static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask); // 0x000000018D2E98E0-0x000000018D2E99D8
		private static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask); // 0x000000018D2E9AB4-0x000000018D2E9BAC
		public static void RemoveAllBindingOverrides(this IInputActionCollection2 actions); // 0x000000018D2E94E0-0x000000018D2E9790
		public static void RemoveAllBindingOverrides(this InputAction action); // 0x000000018D2E9790-0x000000018D2E98E0
		public static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides); // 0x000000018D2E5DD0-0x000000018D2E601C
		public static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides); // 0x000000018D2E9BAC-0x000000018D2E9DF8
		public static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control); // 0x000000018D2E5C2C-0x000000018D2E5DD0
		public static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control); // 0x000000018D2E5ACC-0x000000018D2E5C2C
		public static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions); // 0x000000018D2E9DF8-0x000000018D2EA180
		public static string SaveBindingOverridesAsJson(this InputAction action); // 0x000000018D2EA180-0x000000018D2EA590
		private static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null); // 0x000000018D2E519C-0x000000018D2E535C
		public static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true /* Metadata: 0x0262280C */); // 0x000000018D2E8E24-0x000000018D2E8F54
		public static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true /* Metadata: 0x0262280D */); // 0x000000018D2E8F54-0x000000018D2E908C
		private static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json); // 0x000000018D2E8A4C-0x000000018D2E8E24
		public static RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1 /* Metadata: 0x0262280E */); // 0x000000018D2E908C-0x000000018D2E94E0
	}

	public enum InputActionPhase // TypeDefIndex: 72143
	{
		Disabled = 0,
		Waiting = 1,
		Started = 2,
		Performed = 3,
		Canceled = 4
	}

	[Serializable]
	public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference> // TypeDefIndex: 72144
	{
		// Fields
		[SerializeField]
		private bool m_UseReference; // 0x00
		[SerializeField]
		private InputAction m_Action; // 0x08
		[SerializeField]
		private InputActionReference m_Reference; // 0x10
	
		// Properties
		public InputAction action { get; } // 0x000000018D2F6388-0x000000018D2F6404 
		public InputActionReference reference { get; } // 0x000000018D2F6404-0x000000018D2F6414 
		internal InputAction serializedAction { get; } // 0x00000001844AFA30-0x00000001844AFA40 
		internal InputActionReference serializedReference { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public InputActionProperty(InputAction action); // 0x000000018D2F632C-0x000000018D2F6358
		public InputActionProperty(InputActionReference reference); // 0x000000018D2F6358-0x000000018D2F6388
	
		// Methods
		public bool Equals(InputActionProperty other); // 0x000000018D2F611C-0x000000018D2F61A4
		public bool Equals(InputAction other); // 0x000000018D2F6238-0x000000018D2F6254
		public bool Equals(InputActionReference other); // 0x000000018D2F6254-0x000000018D2F62A8
		public override bool Equals(object obj); // 0x000000018D2F61A4-0x000000018D2F6238
		public override int GetHashCode(); // 0x000000018D2F62A8-0x000000018D2F632C
		public static bool operator ==(InputActionProperty left, InputActionProperty right); // 0x000000018D2F6414-0x000000018D2F6440
		public static bool operator !=(InputActionProperty left, InputActionProperty right); // 0x000000018D2F6440-0x000000018D2F646C
	}

	public class InputActionReference : ScriptableObject // TypeDefIndex: 72145
	{
		// Fields
		[SerializeField]
		internal InputActionAsset m_Asset; // 0x18
		[SerializeField]
		internal string m_ActionId; // 0x20
		[NonSerialized]
		private InputAction m_Action; // 0x28
	
		// Properties
		public InputActionAsset asset { get; } // 0x0000000182234E30-0x0000000182234E40 
		public InputAction action { get; } // 0x0000000185B03860-0x0000000185B03990 
	
		// Constructors
		public InputActionReference(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public void Set(InputAction action); // 0x000000018D2F6800-0x000000018D2F6928
		public void Set(InputActionAsset asset, string mapName, string actionName); // 0x000000018D2F6928-0x000000018D2F6BF0
		private void SetInternal(InputActionAsset asset, InputAction action); // 0x000000018D2F6658-0x000000018D2F6800
		public override string ToString(); // 0x000000018D2F6C3C-0x000000018D2F6E34
		internal static string GetDisplayName(InputAction action); // 0x000000018D2F64D4-0x000000018D2F6560
		internal string ToDisplayName(); // 0x000000018D2F6BF0-0x000000018D2F6C34
		public static implicit operator InputAction(InputActionReference reference); // 0x000000018D2F6E34-0x000000018D2F6E50
		public static InputActionReference Create(InputAction action); // 0x000000018D2F646C-0x000000018D2F64D4
		internal static void ResetCachedAction(); // 0x000000018D2F6560-0x000000018D2F6658
		public InputAction ToInputAction(); // 0x000000018D2F6C34-0x000000018D2F6C3C
	}

	public static class InputActionSetupExtensions // TypeDefIndex: 72150
	{
		// Nested types
		public struct BindingSyntax // TypeDefIndex: 72146
		{
			// Fields
			private readonly InputActionMap m_ActionMap; // 0x00
			private readonly InputAction m_Action; // 0x08
			internal readonly int m_BindingIndexInMap; // 0x10
	
			// Properties
			public bool valid { get; } // 0x000000018D2F5934-0x000000018D2F598C 
			public int bindingIndex { get; } // 0x000000018D2F5854-0x000000018D2F5894 
			public InputBinding binding { get; } // 0x000000018D2F5894-0x000000018D2F5934 
	
			// Constructors
			internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null); // 0x000000018D2F582C-0x000000018D2F5854
	
			// Methods
			public BindingSyntax WithName(string name); // 0x000000018D2F52F4-0x000000018D2F53C8
			public BindingSyntax WithPath(string path); // 0x000000018D2F53C8-0x000000018D2F549C
			public BindingSyntax WithGroup(string group); // 0x000000018D2F4BD4-0x000000018D2F4DB0
			public BindingSyntax WithGroups(string groups); // 0x000000018D2F4DB0-0x000000018D2F4F64
			public BindingSyntax WithInteraction(string interaction); // 0x000000018D2F4F64-0x000000018D2F5140
			public BindingSyntax WithInteractions(string interactions); // 0x000000018D2F5140-0x000000018D2F52F4
			public BindingSyntax WithInteraction<TInteraction>()
				where TInteraction : IInputInteraction;
			public BindingSyntax WithProcessor(string processor); // 0x000000018D2F549C-0x000000018D2F5678
			public BindingSyntax WithProcessors(string processors); // 0x000000018D2F5678-0x000000018D2F582C
			public BindingSyntax WithProcessor<TProcessor>();
			public BindingSyntax Triggering(InputAction action); // 0x000000018D2F4A14-0x000000018D2F4BD4
			public BindingSyntax To(InputBinding binding); // 0x000000018D2F48C4-0x000000018D2F4A14
			public BindingSyntax NextBinding(); // 0x000000018D2F46AC-0x000000018D2F46E0
			public BindingSyntax PreviousBinding(); // 0x000000018D2F47B8-0x000000018D2F47EC
			public BindingSyntax NextPartBinding(string partName); // 0x000000018D2F471C-0x000000018D2F47B8
			public BindingSyntax PreviousPartBinding(string partName); // 0x000000018D2F4828-0x000000018D2F48C4
			public BindingSyntax NextCompositeBinding(string compositeName = null); // 0x000000018D2F46E0-0x000000018D2F471C
			public BindingSyntax PreviousCompositeBinding(string compositeName = null); // 0x000000018D2F47EC-0x000000018D2F4828
			private BindingSyntax Iterate(bool next); // 0x000000018D2F45C4-0x000000018D2F46AC
			private BindingSyntax IterateCompositeBinding(bool next, string compositeName); // 0x000000018D2F42E8-0x000000018D2F4448
			private BindingSyntax IteratePartBinding(bool next, string partName); // 0x000000018D2F4448-0x000000018D2F45C4
			public void Erase(); // 0x000000018D2F3EB8-0x000000018D2F4064
			public BindingSyntax InsertPartBinding(string partName, string path); // 0x000000018D2F4064-0x000000018D2F42E8
		}
	
		public struct CompositeSyntax // TypeDefIndex: 72147
		{
			// Fields
			private readonly InputAction m_Action; // 0x00
			private readonly InputActionMap m_ActionMap; // 0x08
			private int m_BindingIndexInMap; // 0x10
	
			// Properties
			public int bindingIndex { get; } // 0x000000018D2F5BB8-0x000000018D2F5BDC 
	
			// Constructors
			internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex); // 0x000000018D2F5B90-0x000000018D2F5BB8
	
			// Methods
			public CompositeSyntax With(string name, string binding, string groups = null, string processors = null); // 0x000000018D2F598C-0x000000018D2F5B90
		}
	
		public struct ControlSchemeSyntax // TypeDefIndex: 72148
		{
			// Fields
			private readonly InputActionAsset m_Asset; // 0x00
			private readonly int m_ControlSchemeIndex; // 0x08
			private InputControlScheme m_ControlScheme; // 0x10
	
			// Constructors
			internal ControlSchemeSyntax(InputActionAsset asset, int index); // 0x000000018D2F60F0-0x000000018D2F611C
			internal ControlSchemeSyntax(InputControlScheme controlScheme); // 0x000000018D2F60B0-0x000000018D2F60F0
	
			// Methods
			public ControlSchemeSyntax WithBindingGroup(string bindingGroup); // 0x000000018D2F5EF4-0x000000018D2F6018
			public ControlSchemeSyntax WithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax WithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax OrWithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax OrWithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public ControlSchemeSyntax WithRequiredDevice(string controlPath); // 0x000000018D2F6064-0x000000018D2F60B0
			public ControlSchemeSyntax WithOptionalDevice(string controlPath); // 0x000000018D2F6018-0x000000018D2F6064
			public ControlSchemeSyntax OrWithRequiredDevice(string controlPath); // 0x000000018D2F5EA8-0x000000018D2F5EF4
			public ControlSchemeSyntax OrWithOptionalDevice(string controlPath); // 0x000000018D2F5E5C-0x000000018D2F5EA8
			private string DeviceTypeToControlPath<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice;
			public InputControlScheme Done(); // 0x000000018D2F5DC0-0x000000018D2F5E5C
			private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags); // 0x000000018D2F5BDC-0x000000018D2F5DC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 72149
		{
			// Fields
			public InputBinding binding; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveAction_b__0(InputBinding b); // 0x000000018D2FF7D0-0x000000018D2FF85C
		}
	
		// Methods
		private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1 /* Metadata: 0x0262282D */); // 0x000000018D2F771C-0x000000018D2F7890
	
		// Extension methods
		public static InputActionMap AddActionMap(this InputActionAsset asset, string name); // 0x000000018D2F7140-0x000000018D2F7338
		public static void AddActionMap(this InputActionAsset asset, InputActionMap map); // 0x000000018D2F6E50-0x000000018D2F7140
		public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map); // 0x000000018D2F9424-0x000000018D2F95A8
		public static void RemoveActionMap(this InputActionAsset asset, string nameOrId); // 0x000000018D2F95A8-0x000000018D2F96D4
		public static InputAction AddAction(this InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x0262282C */, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null); // 0x000000018D2F7338-0x000000018D2F771C
		public static void RemoveAction(this InputAction action); // 0x000000018D2F96D4-0x000000018D2F9A58
		public static void RemoveAction(this InputActionAsset asset, string nameOrId); // 0x000000018D2F9A58-0x000000018D2F9B80
		public static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null); // 0x000000018D2F7890-0x000000018D2F7988
		public static BindingSyntax AddBinding(this InputAction action, InputControl control); // 0x000000018D2F7D34-0x000000018D2F7DF4
		public static BindingSyntax AddBinding(this InputAction action, InputBinding binding = default); // 0x000000018D2F7AB4-0x000000018D2F7BD4
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null); // 0x000000018D2F7DF4-0x000000018D2F7F6C
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null); // 0x000000018D2F7F6C-0x000000018D2F80D4
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null); // 0x000000018D2F7988-0x000000018D2F7AB4
		public static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding); // 0x000000018D2F7BD4-0x000000018D2F7D34
		public static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null); // 0x000000018D2F80D4-0x000000018D2F82E0
		public static BindingSyntax ChangeBinding(this InputAction action, int index); // 0x000000018D2F8FA8-0x000000018D2F9068
		public static BindingSyntax ChangeBinding(this InputAction action, string name); // 0x000000018D2F8CDC-0x000000018D2F8D94
		public static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index); // 0x000000018D2F8BB4-0x000000018D2F8CDC
		public static BindingSyntax ChangeBindingWithId(this InputAction action, string id); // 0x000000018D2F8874-0x000000018D2F8988
		public static BindingSyntax ChangeBindingWithId(this InputAction action, Guid id); // 0x000000018D2F8988-0x000000018D2F8AA4
		public static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group); // 0x000000018D2F8764-0x000000018D2F8874
		public static BindingSyntax ChangeBindingWithPath(this InputAction action, string path); // 0x000000018D2F8AA4-0x000000018D2F8BB4
		public static BindingSyntax ChangeBinding(this InputAction action, InputBinding match); // 0x000000018D2F8D94-0x000000018D2F8FA8
		public static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName); // 0x000000018D2F9068-0x000000018D2F926C
		public static void Rename(this InputAction action, string newName); // 0x000000018D2F9CC0-0x000000018D2F9F4C
		public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme); // 0x000000018D2F82E0-0x000000018D2F8594
		public static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name); // 0x000000018D2F8594-0x000000018D2F8764
		public static void RemoveControlScheme(this InputActionAsset asset, string name); // 0x000000018D2F9B80-0x000000018D2F9CC0
		public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup); // 0x000000018D2F9F4C-0x000000018D2FA028
		public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required); // 0x000000018D2FA028-0x000000018D2FA13C
		public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath); // 0x000000018D2FA218-0x000000018D2FA2F4
		public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath); // 0x000000018D2FA13C-0x000000018D2FA218
		public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath); // 0x000000018D2F9348-0x000000018D2F9424
		public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath); // 0x000000018D2F926C-0x000000018D2F9348
	}

	internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable // TypeDefIndex: 72161
	{
		// Fields
		public const int kInvalidIndex = -1; // Metadata: 0x0262283E
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
		public int totalCompositeCount { get; } // 0x0000000187233600-0x0000000187233610 
		public int totalMapCount { get; } // 0x00000001872330A0-0x00000001872330B0 
		public int totalActionCount { get; } // 0x0000000187233730-0x0000000187233740 
		public int totalBindingCount { get; } // 0x00000001872336F0-0x0000000187233700 
		public int totalInteractionCount { get; } // 0x0000000187233280-0x0000000187233290 
		public int totalControlCount { get; } // 0x00000001872331A0-0x00000001872331B0 
		public unsafe ActionMapIndices* mapIndices { get; } // 0x0000000187232C80-0x0000000187232C90 
		public unsafe TriggerState* actionStates { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public unsafe BindingState* bindingStates { get; } // 0x0000000187232F80-0x0000000187232F90 
		public unsafe InteractionState* interactionStates { get; } // 0x0000000187232FC0-0x0000000187232FD0 
		public unsafe int* controlIndexToBindingIndex { get; } // 0x0000000187232F60-0x0000000187232F70 
		public unsafe ushort* controlGroupingAndComplexity { get; } // 0x0000000187232FB0-0x0000000187232FC0 
		public unsafe float* controlMagnitudes { get; } // 0x00000001829CD170-0x00000001829CD180 
		public unsafe uint* enabledControls { get; } // 0x0000000187232F50-0x0000000187232F60 
		public bool isProcessingControlStateChange { get; } // 0x00000001872538A0-0x00000001872538B0 
	
		// Nested types
		internal struct InteractionState // TypeDefIndex: 72152
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
			public int triggerControlIndex { get; set; } // 0x000000018D2FF3C8-0x000000018D2FF3DC 0x000000018D2FF400-0x000000018D2FF478
			public double startTime { get; set; } // 0x000000018724A3F0-0x000000018724A400 0x000000018724CA60-0x000000018724CA70
			public double performedTime { get; set; } // 0x0000000187233020-0x0000000187233030 0x0000000187233030-0x0000000187233040
			public double timerStartTime { get; set; } // 0x0000000187244520-0x0000000187244530 0x0000000187247AC0-0x0000000187247AD0
			public float timerDuration { get; set; } // 0x000000018724A6D0-0x000000018724A6E0 0x00000001872598B0-0x00000001872598C0
			public float totalTimeoutCompletionDone { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
			public float totalTimeoutCompletionTimeRemaining { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
			public long timerMonitorIndex { get; set; } // 0x0000000182262130-0x0000000182262140 0x000000018561BB40-0x000000018561BB50
			public bool isTimerRunning { get; set; } // 0x000000018D2FF3C0-0x000000018D2FF3C8 0x000000018D2FF3DC-0x000000018D2FF400
			public InputActionPhase phase { get; set; } // 0x0000000187239B80-0x0000000187239B90 0x000000018723EE20-0x000000018723EE30
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 72151
			{
				TimerRunning = 1
			}
		}
	
		internal struct BindingState // TypeDefIndex: 72154
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
			public int controlStartIndex { get; set; } // 0x0000000187256CA0-0x0000000187256CB0 0x00000001863180B0-0x00000001863180D0
			public int controlCount { get; set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x00000001863181C0-0x00000001863181E0
			public int interactionStartIndex { get; set; } // 0x0000000186317E80-0x0000000186317EA0 0x00000001863180D0-0x00000001863180F0
			public int interactionCount { get; set; } // 0x00000001844AD300-0x00000001844AD310 0x00000001863180F0-0x0000000186318110
			public int processorStartIndex { get; set; } // 0x000000018D2F3E58-0x000000018D2F3E70 0x0000000186318110-0x0000000186318130
			public int processorCount { get; set; } // 0x0000000187239B80-0x0000000187239B90 0x0000000186318130-0x0000000186318150
			public int actionIndex { get; set; } // 0x000000018526F8B0-0x000000018526F8D0 0x0000000186317FC0-0x0000000186317FF0
			public int mapIndex { get; set; } // 0x0000000187239B70-0x0000000187239B80 0x0000000186318150-0x0000000186318170
			public int compositeOrCompositeBindingIndex { get; set; } // 0x0000000186317B40-0x0000000186317B60 0x0000000186317FF0-0x0000000186318020
			public int triggerEventIdForComposite { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
			public double pressTime { get; set; } // 0x0000000187244520-0x0000000187244530 0x0000000187247AC0-0x0000000187247AD0
			public Flags flags { get; set; } // 0x0000000187239BC0-0x0000000187239BD0 0x000000018723EA20-0x000000018723EA30
			public bool chainsWithNext { get; set; } // 0x000000018D2F3E30-0x000000018D2F3E38 0x000000018D2F3E70-0x000000018D2F3E94
			public bool isEndOfChain { get; set; } // 0x000000018D2F3E38-0x000000018D2F3E44 0x000000018D2F3E94-0x000000018D2F3EB8
			public bool isPartOfChain { get; } // 0x000000018D2F3E44-0x000000018D2F3E58 
			public bool isComposite { get; set; } // 0x0000000186317FA0-0x0000000186317FB0 0x0000000186318020-0x0000000186318050
			public bool isPartOfComposite { get; set; } // 0x000000018526FA70-0x000000018526FA80 0x0000000186318050-0x0000000186318080
			public bool initialStateCheckPending { get; set; } // 0x0000000186316FE0-0x0000000186316FF0 0x0000000185B01620-0x0000000185B01650
			public bool wantsInitialStateCheck { get; set; } // 0x0000000185B01DE0-0x0000000185B01DF0 0x0000000186318080-0x00000001863180B0
			public int partIndex { get; set; } // 0x0000000187239BD0-0x0000000187239BE0 0x0000000186318190-0x00000001863181A0
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 72153
			{
				ChainsWithNext = 1,
				EndOfChain = 2,
				Composite = 4,
				PartOfComposite = 8,
				InitialStateCheckPending = 16,
				WantsInitialStateCheck = 32
			}
		}
	
		public struct TriggerState // TypeDefIndex: 72156
		{
			// Fields
			public const int kMaxNumMaps = 255; // Metadata: 0x02622846
			public const int kMaxNumControls = 65535; // Metadata: 0x02622848
			public const int kMaxNumBindings = 65535; // Metadata: 0x0262284C
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
			public InputActionPhase phase { get; set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x0000000187233BE0-0x0000000187233BF0
			public bool isDisabled { get; } // 0x000000018526F920-0x000000018526F930 
			public bool isWaiting { get; } // 0x0000000185D35600-0x0000000185D35640 
			public bool isStarted { get; } // 0x0000000188CD7C48-0x0000000188CD7C50 
			public bool isPerformed { get; } // 0x000000018D2FF490-0x000000018D2FF498 
			public bool isCanceled { get; } // 0x000000018D2FF488-0x000000018D2FF490 
			public double time { get; set; } // 0x000000018724A3F0-0x000000018724A400 0x000000018724CA60-0x000000018724CA70
			public double startTime { get; set; } // 0x0000000187244520-0x0000000187244530 0x0000000187247AC0-0x0000000187247AD0
			public float magnitude { get; set; } // 0x0000000187233410-0x0000000187233420 0x00000001872598C0-0x00000001872598D0
			public bool haveMagnitude { get; } // 0x000000018D2FF480-0x000000018D2FF488 
			public int mapIndex { get; set; } // 0x0000000187239B80-0x0000000187239B90 0x000000018526FAC0-0x000000018526FAE0
			public int controlIndex { get; set; } // 0x000000018526F4D0-0x000000018526F4F0 0x000000018526FB70-0x000000018526FBA0
			public int bindingIndex { get; set; } // 0x0000000187256C40-0x0000000187256C50 0x000000018526FAA0-0x000000018526FAC0
			public int interactionIndex { get; set; } // 0x000000018526F890-0x000000018526F8B0 0x000000018526FA80-0x000000018526FAA0
			public uint lastPerformedInUpdate { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
			public uint lastCompletedInUpdate { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
			public uint lastCanceledInUpdate { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
			public uint pressedInUpdate { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			public uint releasedInUpdate { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
			public bool isPassThrough { get; set; } // 0x000000018526F910-0x000000018526F920 0x000000018526FB40-0x000000018526FB70
			public bool isButton { get; set; } // 0x000000018526FA60-0x000000018526FA70 0x000000018526FB10-0x000000018526FB40
			public bool isPressed { get; set; } // 0x000000018526F4F0-0x000000018526F500 0x000000018526D5E0-0x000000018526D610
			public bool mayNeedConflictResolution { get; set; } // 0x000000018526FC10-0x000000018526FC20 0x0000000186317CF0-0x0000000186317D10
			public bool hasMultipleConcurrentActuations { get; set; } // 0x000000018D2FF478-0x000000018D2FF480 0x000000018D2FF498-0x000000018D2FF4BC
			public bool inProcessing { get; set; } // 0x000000018526F900-0x000000018526F910 0x000000018526FAE0-0x000000018526FB10
			public Flags flags { get; set; } // 0x00000001844AD300-0x00000001844AD310 0x0000000187239F70-0x0000000187239F80
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 72155
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
	
		public struct ActionMapIndices // TypeDefIndex: 72157
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
	
		public struct UnmanagedMemory : IDisposable // TypeDefIndex: 72158
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
			public bool isAllocated { get; } // 0x00000001853AE700-0x00000001853AE710 
			public int sizeInBytes { get; } // 0x00000001863177A0-0x00000001863177E0 
	
			// Methods
			public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount); // 0x0000000186317620-0x00000001863177A0
			public void Dispose(); // 0x00000001863177E0-0x0000000186317840
			public void CopyDataFrom(UnmanagedMemory memory); // 0x0000000186316FF0-0x0000000186317140
			public UnmanagedMemory Clone(); // 0x000000018D2FF924-0x000000018D2FFB80
		}
	
		internal struct GlobalState // TypeDefIndex: 72159
		{
			// Fields
			internal InlinedArray<GCHandle> globalList; // 0x00
			internal CallbackArray<Action<object, InputActionChange>> onActionChange; // 0x18
			internal CallbackArray<Action<object>> onActionControlsChanged; // 0x68
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72160
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__140_0; // 0x08
			public static Action __9__140_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D2FF8C0-0x000000018D2FF924
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SaveAndResetState_b__140_0(ref GlobalState state); // 0x000000018D2FF4D0-0x000000018D2FF614
			internal void _SaveAndResetState_b__140_1(); // 0x000000018D2FF614-0x000000018D2FF654
		}
	
		// Constructors
		public InputActionState(); // 0x0000000186805BA0-0x0000000186805BB0
		static InputActionState(); // 0x0000000186F8EA70-0x0000000186F8EBC0
	
		// Methods
		public void Initialize(InputBindingResolver resolver); // 0x00000001868117C0-0x0000000186811860
		private void ComputeControlGroupingIfNecessary(); // 0x0000000186811BB0-0x0000000186811D20
		public void ClaimDataFrom(InputBindingResolver resolver); // 0x00000001868119B0-0x0000000186811A90
		~InputActionState(); // 0x000000018D2FB710-0x000000018D2FB788
		public void Dispose(); // 0x000000018D2FB4C8-0x000000018D2FB4D4
		private void Destroy(bool isFinalizing = false /* Metadata: 0x0262282E */); // 0x000000018D2FACF0-0x000000018D2FAE80
		public InputActionState Clone(); // 0x000000018D2FA9E0-0x000000018D2FAB80
		object ICloneable.Clone(); // 0x000000018D2FE1C0-0x000000018D2FE1C8
		private bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018526B3E0-0x000000018526B530
		private bool CanUseDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D2FA2F4-0x000000018D2FA4B4
		public bool HasEnabledActions(); // 0x000000018D2FBF0C-0x000000018D2FBF60
		private void FinishBindingCompositeSetups(); // 0x0000000186317EA0-0x0000000186317FA0
		internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions); // 0x000000018D2FBFE0-0x000000018D2FC4B4
		public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve); // 0x0000000186811760-0x00000001868117C0
		private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve); // 0x000000018D2FD3C8-0x000000018D2FDC00
		private bool IsActiveControl(int bindingIndex, int controlIndex); // 0x0000000187066470-0x0000000187066500
		private int FindControlIndexOnBinding(int bindingIndex, InputControl control); // 0x000000018D2FBA28-0x000000018D2FBAA4
		private void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device); // 0x000000018526AF30-0x000000018526B160
		private bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex); // 0x000000018526B160-0x000000018526B270
		public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting /* Metadata: 0x0262282F */, bool hardReset = false /* Metadata: 0x02622830 */); // 0x000000018D2FCF00-0x000000018D2FD08C
		public ref TriggerState FetchActionState(InputAction action); // 0x0000000185B03190-0x0000000185B031C0
		public ActionMapIndices FetchMapIndices(InputActionMap map); // 0x00000001871F2360-0x00000001871F23B0
		public void EnableAllActions(InputActionMap map); // 0x000000018D2FB4D4-0x000000018D2FB5D0
		private void EnableControls(InputActionMap map); // 0x000000018D2FB5D0-0x000000018D2FB634
		public void EnableSingleAction(InputAction action); // 0x0000000185B026C0-0x0000000185B02770
		private void EnableControls(InputAction action); // 0x0000000185B024C0-0x0000000185B025C0
		public void DisableAllActions(InputActionMap map); // 0x000000018D2FAFD0-0x000000018D2FB16C
		public void DisableControls(InputActionMap map); // 0x000000018D2FB3CC-0x000000018D2FB430
		public void DisableSingleAction(InputAction action); // 0x000000018D2FB430-0x000000018D2FB4C8
		private void DisableControls(InputAction action); // 0x000000018D2FB16C-0x000000018D2FB250
		private void EnableControls(int mapIndex, int controlStartIndex, int numControls); // 0x0000000185B01C10-0x0000000185B01DE0
		private void DisableControls(int mapIndex, int controlStartIndex, int numControls); // 0x000000018D2FB250-0x000000018D2FB3CC
		public void SetInitialStateCheckPending(int actionIndex, bool value = true /* Metadata: 0x02622831 */); // 0x000000018D2FDE3C-0x000000018D2FDF00
		private unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value); // 0x0000000185B015D0-0x0000000185B01620
		private bool IsControlEnabled(int controlIndex); // 0x0000000185B01E30-0x0000000185B01E70
		private void SetControlEnabled(int controlIndex, bool state); // 0x0000000185B01DF0-0x0000000185B01E30
		private void HookOnBeforeUpdate(); // 0x0000000185B025C0-0x0000000185B026C0
		private void UnhookOnBeforeUpdate(); // 0x00000001870F20F0-0x00000001870F2170
		private void OnBeforeInitialUpdate(); // 0x0000000186316E20-0x0000000186316FE0
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex); // 0x000000018526D870-0x000000018526D8C0
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex); // 0x000000018D2FE1C8-0x000000018D2FE20C
		private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex); // 0x0000000187259870-0x00000001872598B0
		private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex); // 0x0000000187259840-0x0000000187259870
		internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex); // 0x0000000187259830-0x0000000187259840
		private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr); // 0x000000018526E210-0x000000018526F2D0
		private unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr); // 0x000000018526F310-0x000000018526F4D0
		private static unsafe bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr); // 0x000000018D2FDF44-0x000000018D2FDF64
		private bool IsConflictingInput(ref TriggerState trigger, int actionIndex); // 0x000000018526FBA0-0x000000018526FC10
		private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount); // 0x00000001872597F0-0x0000000187259820
		private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex); // 0x000000018526F930-0x000000018526F9E0
		private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount); // 0x000000018D2FC4B4-0x000000018D2FC608
		private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex); // 0x000000018D2FC608-0x000000018D2FC7BC
		internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger); // 0x000000018D2FDF00-0x000000018D2FDF44
		internal void StartTimeout(float seconds, ref TriggerState trigger); // 0x000000018D2FDF64-0x000000018D2FE0DC
		private void StopTimeout(int interactionIndex); // 0x000000018D2FE0DC-0x000000018D2FE1C0
		internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting /* Metadata: 0x02622832 */, InputActionPhase phaseAfterCanceled = InputActionPhase.Waiting /* Metadata: 0x02622833 */, bool processNextInteractionOnCancel = true /* Metadata: 0x02622834 */); // 0x000000018D2FA4B4-0x000000018D2FA9E0
		private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting /* Metadata: 0x02622835 */); // 0x000000018526F600-0x000000018526F890
		private unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false /* Metadata: 0x02622836 */); // 0x000000018526DCA0-0x000000018526E1B0
		private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName); // 0x000000018526D8C0-0x000000018526DB40
		private object GetActionOrNoneString(ref TriggerState trigger); // 0x000000018D2FBAE0-0x000000018D2FBB38
		internal InputAction GetActionOrNull(int bindingIndex); // 0x000000018526DC00-0x000000018526DCA0
		internal InputAction GetActionOrNull(ref TriggerState trigger); // 0x000000018D2FBB38-0x000000018D2FBBD8
		internal InputControl GetControl(ref TriggerState trigger); // 0x000000018D2FBD44-0x000000018D2FBD80
		private IInputInteraction GetInteractionOrNull(ref TriggerState trigger); // 0x000000018D2FBD80-0x000000018D2FBDDC
		internal int GetBindingIndexInMap(int bindingIndex); // 0x000000018D2FBBD8-0x000000018D2FBC1C
		internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap); // 0x000000018D2FBC1C-0x000000018D2FBC54
		internal ref BindingState GetBindingState(int bindingIndex); // 0x0000000187259820-0x0000000187259830
		internal ref InputBinding GetBinding(int bindingIndex); // 0x000000018D2FBC54-0x000000018D2FBCCC
		internal InputActionMap GetActionMap(int bindingIndex); // 0x000000018D2FBAA4-0x000000018D2FBAE0
		private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled); // 0x000000018D2FD204-0x000000018D2FD2BC
		private void ResetInteractionState(int interactionIndex); // 0x000000018D2FD2BC-0x000000018D2FD3C8
		internal int GetValueSizeInBytes(int bindingIndex, int controlIndex); // 0x000000018D2FBDDC-0x000000018D2FBE74
		internal System.Type GetValueType(int bindingIndex, int controlIndex); // 0x000000018D2FBE74-0x000000018D2FBF0C
		internal static bool IsActuated(ref TriggerState trigger, float threshold = 0f /* Metadata: 0x02622837 */); // 0x000000018D2FBF60-0x000000018D2FBFE0
		internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false /* Metadata: 0x0262283B */); // 0x000000018D2FCC04-0x000000018D2FCDD8
		internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0262283C */)
			where TValue : struct;
		internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null)
			where TValue : struct;
		public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber); // 0x000000018D2FB634-0x000000018D2FB710
		internal double GetCompositePartPressTime(int bindingIndex, int partNumber); // 0x000000018D2FBCCC-0x000000018D2FBD44
		internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue>;
		internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize); // 0x000000018D2FC8EC-0x000000018D2FCA30
		internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber); // 0x000000018D2FC7BC-0x000000018D2FC8EC
		internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0262283D */); // 0x000000018D2FCA30-0x000000018D2FCC04
		internal bool ReadValueAsButton(int bindingIndex, int controlIndex); // 0x000000018526CBF0-0x000000018526CCC0
		internal static ISavedState SaveAndResetState(); // 0x000000018D2FDC00-0x000000018D2FDE3C
		private void AddToGlobalList(); // 0x0000000186811860-0x00000001868118F0
		private void RemoveMapFromGlobalList(); // 0x000000018D2FCDD8-0x000000018D2FCF00
		private static void CompactGlobalList(); // 0x00000001868118F0-0x00000001868119B0
		internal void NotifyListenersOfActionChange(InputActionChange change); // 0x0000000186811A90-0x0000000186811BB0
		internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset); // 0x0000000185B02390-0x0000000185B024C0
		private static void ResetGlobals(); // 0x000000018D2FD08C-0x000000018D2FD204
		internal static int FindAllEnabledActions(List<InputAction> result); // 0x000000018D2FB788-0x000000018D2FBA28
		internal static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018526B270-0x000000018526B3E0
		internal static void DeferredResolutionOfBindings(); // 0x0000000185B018E0-0x0000000185B01C10
		internal static void DisableAllActions(); // 0x000000018D2FAE80-0x000000018D2FAFD0
		internal static void DestroyAllActionMapStates(); // 0x000000018D2FAB80-0x000000018D2FACF0
	}

	public enum InputActionType // TypeDefIndex: 72162
	{
		Value = 0,
		Button = 1,
		PassThrough = 2
	}

	[Serializable]
	public struct InputBinding : IEquatable<InputBinding> // TypeDefIndex: 72167
	{
		// Fields
		public const char Separator = ';'; // Metadata: 0x0262285E
		internal const string kSeparatorString = ";"; // Metadata: 0x02622860
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
		public string name { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Guid id { get; set; } // 0x000000018D2FF1DC-0x000000018D2FF228 0x000000018D2FF348-0x000000018D2FF3A4
		public string path { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string overridePath { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public string interactions { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string overrideInteractions { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public string processors { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string overrideProcessors { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public string groups { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string action { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool isComposite { get; set; } // 0x0000000186318180-0x0000000186318190 0x000000018D2FF3A4-0x000000018D2FF3C0
		public bool isPartOfComposite { get; set; } // 0x00000001863181E0-0x00000001863181F0 0x000000018CB5ED74-0x000000018CB5ED90
		public bool hasOverrides { get; } // 0x000000018D2FF1C0-0x000000018D2FF1DC 
		public string effectivePath { get; } // 0x00000001863181A0-0x00000001863181B0 
		public string effectiveInteractions { get; } // 0x0000000186317FB0-0x0000000186317FC0 
		public string effectiveProcessors { get; } // 0x00000001863181B0-0x00000001863181C0 
		internal bool isEmpty { get; } // 0x000000018D2FF228-0x000000018D2FF26C 
	
		// Nested types
		[Flags]
		public enum DisplayStringOptions // TypeDefIndex: 72163
		{
			DontUseShortDisplayNames = 1,
			DontOmitDevice = 2,
			DontIncludeInteractions = 4,
			IgnoreBindingOverrides = 8
		}
	
		[Flags]
		internal enum MatchOptions // TypeDefIndex: 72164
		{
			EmptyGroupMatchesAny = 1
		}
	
		[Flags]
		internal enum Flags // TypeDefIndex: 72165
		{
			None = 0,
			Composite = 4,
			PartOfComposite = 8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72166
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__45_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D2FF85C-0x000000018D2FF8C0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _MaskByGroups_b__45_0(string x); // 0x000000018D2FF4BC-0x000000018D2FF4D0
		}
	
		// Constructors
		public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null); // 0x000000018D2FF11C-0x000000018D2FF1C0
	
		// Methods
		public string GetNameOfComposite(); // 0x000000018D2FE91C-0x000000018D2FE94C
		internal void GenerateId(); // 0x000000018D2FE784-0x000000018D2FE7F4
		internal void RemoveOverrides(); // 0x000000018D2FEC78-0x000000018D2FECB0
		public static InputBinding MaskByGroup(string group); // 0x000000018D2FE94C-0x000000018D2FE984
		public static InputBinding MaskByGroups(params string[] groups); // 0x000000018D2FE984-0x000000018D2FEAE0
		public bool Equals(InputBinding other); // 0x000000018D2FE69C-0x000000018D2FE784
		public override bool Equals(object obj); // 0x000000018D2FE5F8-0x000000018D2FE69C
		public static bool operator ==(InputBinding left, InputBinding right); // 0x000000018D2FF26C-0x000000018D2FF2BC
		public static bool operator !=(InputBinding left, InputBinding right); // 0x000000018D2FF2BC-0x000000018D2FF348
		public override int GetHashCode(); // 0x000000018D2FE7F4-0x000000018D2FE91C
		public override string ToString(); // 0x000000018D2FEFD4-0x000000018D2FF0C8
		public string ToDisplayString(DisplayStringOptions options =  /* Metadata: 0x0262285B */, InputControl control = null); // 0x000000018D2FEFA0-0x000000018D2FEFD4
		public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options =  /* Metadata: 0x0262285C */, InputControl control = null); // 0x000000018D2FECB0-0x000000018D2FEFA0
		internal bool TriggersAction(InputAction action); // 0x000000018D2FF0C8-0x000000018D2FF11C
		public bool Matches(InputBinding binding); // 0x000000018D2FEAE0-0x000000018D2FEAF4
		internal bool Matches(ref InputBinding binding, MatchOptions options =  /* Metadata: 0x0262285D */); // 0x000000018D2FEAF4-0x000000018D2FEC78
	}

	public abstract class InputBindingComposite // TypeDefIndex: 72169
	{
		// Fields
		internal static TypeTable s_Composites; // 0x00
	
		// Properties
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetPartNames_d__12 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 72168
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
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetPartNames_d__12(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D3228BC-0x000000018D322A64
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D322B00-0x000000018D322B4C
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018D322A64-0x000000018D322AF8
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D322AF8-0x000000018D322B00
		}
	
		// Constructors
		protected InputBindingComposite(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);
		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);
		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x0000000187257DF0-0x0000000187257E00
		protected virtual void FinishSetup(ref InputBindingCompositeContext context); // 0x0000000186805BA0-0x0000000186805BB0
		internal void CallFinishSetup(ref InputBindingCompositeContext context); // 0x000000018783BE50-0x000000018783BE8C
		internal static System.Type GetValueType(string composite); // 0x000000018D2FE4EC-0x000000018D2FE5F8
		public static string GetExpectedControlLayoutName(string composite, string part); // 0x000000018D2FE2F8-0x000000018D2FE47C
		[IteratorStateMachine(typeof(_GetPartNames_d__12))]
		internal static IEnumerable<string> GetPartNames(string composite); // 0x000000018D2FE47C-0x000000018D2FE4EC
		internal static string GetDisplayFormatString(string composite); // 0x000000018D2FE20C-0x000000018D2FE2F8
	}

	public abstract class InputBindingComposite<TValue> : InputBindingComposite // TypeDefIndex: 72170
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

	public struct InputBindingCompositeContext // TypeDefIndex: 72174
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal int m_BindingIndex; // 0x08
	
		// Properties
		public IEnumerable<PartBinding> controls { [IteratorStateMachine(typeof(_get_controls_d__2))] get; } // 0x000000018D315814-0x000000018D315888 
	
		// Nested types
		public struct PartBinding // TypeDefIndex: 72171
		{
			// Fields
			[CompilerGenerated]
			private int _part_k__BackingField; // 0x00
			[CompilerGenerated]
			private InputControl _control_k__BackingField; // 0x08
	
			// Properties
			public int part { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
			public InputControl control { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		}
	
		private struct DefaultComparer<TValue> : IComparer<TValue> // TypeDefIndex: 72172
			where TValue : IComparable<TValue>
		{
			// Methods
			public int Compare(TValue x, TValue y);
		}
	
		[CompilerGenerated]
		private sealed class _get_controls_d__2 : IEnumerable<PartBinding>, IEnumerator<PartBinding> // TypeDefIndex: 72173
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
			PartBinding IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current { [DebuggerHidden] get; } // 0x00000001845C28E0-0x00000001845C28F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D3231B8-0x000000018D3232D8 
	
			// Constructors
			[DebuggerHidden]
			public _get_controls_d__2(int __1__state); // 0x0000000188E4A554-0x0000000188E4A570
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D322F9C-0x000000018D3230CC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D32316C-0x000000018D3231B8
			[DebuggerHidden]
			IEnumerator<PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator(); // 0x000000018D3230CC-0x000000018D323164
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D323164-0x000000018D32316C
		}
	
		// Methods
		public float EvaluateMagnitude(int partNumber); // 0x000000018D3156D4-0x000000018D315700
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
		public bool ReadValueAsButton(int partNumber); // 0x000000018D31572C-0x000000018D3157B8
		public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize); // 0x000000018D3157E4-0x000000018D315814
		public object ReadValueAsObject(int partNumber); // 0x000000018D3157B8-0x000000018D3157E4
		public double GetPressTime(int partNumber); // 0x000000018D315700-0x000000018D31572C
	}

	internal struct InputBindingResolver : IDisposable // TypeDefIndex: 72175
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
		public int totalMapCount { get; } // 0x0000000182271A60-0x0000000182271A70 
		public int totalActionCount { get; } // 0x0000000182271A80-0x0000000182271A90 
		public int totalBindingCount { get; } // 0x0000000182271A70-0x0000000182271A80 
		public int totalControlCount { get; } // 0x00000001829600C0-0x00000001829600D0 
	
		// Methods
		public void Dispose(); // 0x000000018D315888-0x000000018D315894
		public void StartWithPreviousResolve(InputActionState state, bool isFullResolve); // 0x000000018D315894-0x000000018D315A18
		public void AddActionMap(InputActionMap actionMap); // 0x00000001863181F0-0x000000018631A450
		private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding);
		private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap); // 0x0000000186317B60-0x0000000186317CF0
		private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters); // 0x0000000186317140-0x0000000186317620
		private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount); // 0x0000000186317D10-0x0000000186317E80
	}

	[Serializable]
	public struct InputControlScheme : IEquatable<InputControlScheme> // TypeDefIndex: 72184
	{
		// Fields
		[SerializeField]
		internal string m_Name; // 0x00
		[SerializeField]
		internal string m_BindingGroup; // 0x08
		[SerializeField]
		internal DeviceRequirement[] m_DeviceRequirements; // 0x10
	
		// Properties
		public string name { get; } // 0x0000000184431970-0x0000000184431980 
		public string bindingGroup { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public ReadOnlyArray<DeviceRequirement> deviceRequirements { get; } // 0x000000018D319C74-0x000000018D319CC8 
	
		// Nested types
		public struct MatchResult : IEnumerable<MatchResult.Match>, IDisposable // TypeDefIndex: 72179
		{
			// Fields
			internal Result m_Result; // 0x00
			internal float m_Score; // 0x04
			internal InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices; // 0x08
			internal InputControlList<InputControl> m_Controls; // 0x28
			internal DeviceRequirement[] m_Requirements; // 0x48
	
			// Properties
			public float score { get; } // 0x000000018724A6D0-0x000000018724A6E0 
			public bool isSuccessfulMatch { get; } // 0x000000018D320CE0-0x000000018D320CE8 
			public bool hasMissingRequiredDevices { get; } // 0x000000018D320CD8-0x000000018D320CE0 
			public bool hasMissingOptionalDevices { get; } // 0x000000018D320CD0-0x000000018D320CD8 
			public InputControlList<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x000000018D320BAC-0x000000018D320CD0 
			public Match this[int index] { get => default; } // 0x000000018D320AF4-0x000000018D320BAC 
	
			// Nested types
			internal enum Result // TypeDefIndex: 72176
			{
				AllSatisfied = 0,
				MissingRequired = 1,
				MissingOptional = 2
			}
	
			public struct Match // TypeDefIndex: 72177
			{
				// Fields
				internal int m_RequirementIndex; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public InputControl control { get; } // 0x000000018D320CE8-0x000000018D320D24 
				public UnityEngine.InputSystem.InputDevice device { get; } // 0x000000018D320D24-0x000000018D320D40 
				public int requirementIndex { get; } // 0x00000001844AD290-0x00000001844AD2A0 
				public DeviceRequirement requirement { get; } // 0x000000018D320D64-0x000000018D320D94 
				public bool isOptional { get; } // 0x000000018D320D40-0x000000018D320D64 
			}
	
			private struct Enumerator : IEnumerator<Match> // TypeDefIndex: 72178
			{
				// Fields
				internal int m_Index; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public Match Current { get; } // 0x000000018D314E18-0x000000018D314ED0 
				object IEnumerator.Current { get; } // 0x000000018D314DAC-0x000000018D314E18 
	
				// Methods
				public bool MoveNext(); // 0x000000018D314D90-0x000000018D314DAC
				public void Reset(); // 0x0000000187254C40-0x0000000187254C50
				public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Methods
			public IEnumerator<Match> GetEnumerator(); // 0x000000018D320A54-0x000000018D320AEC
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D320AEC-0x000000018D320AF4
			public void Dispose(); // 0x000000018D3209FC-0x000000018D320A54
		}
	
		[Serializable]
		public struct DeviceRequirement : IEquatable<DeviceRequirement> // TypeDefIndex: 72181
		{
			// Fields
			[SerializeField]
			internal string m_ControlPath; // 0x00
			[SerializeField]
			internal Flags m_Flags; // 0x08
	
			// Properties
			public string controlPath { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
			public bool isOptional { get; set; } // 0x000000018D314CF4-0x000000018D314CFC 0x000000018D314D74-0x000000018D314D90
			public bool isAND { get; set; } // 0x000000018D314CE4-0x000000018D314CEC 0x000000018D314D3C-0x000000018D314D58
			public bool isOR { get; set; } // 0x000000018D314CEC-0x000000018D314CF4 0x000000018D314D58-0x000000018D314D74
	
			// Nested types
			[Flags]
			internal enum Flags // TypeDefIndex: 72180
			{
				None = 0,
				Optional = 1,
				Or = 2
			}
	
			// Methods
			public override string ToString(); // 0x000000018D314C4C-0x000000018D314CE4
			public bool Equals(DeviceRequirement other); // 0x000000018D314ADC-0x000000018D314B38
			public override bool Equals(object obj); // 0x000000018D314B38-0x000000018D314BA8
			public override int GetHashCode(); // 0x000000018D314BA8-0x000000018D314C4C
			public static bool operator ==(DeviceRequirement left, DeviceRequirement right); // 0x000000018D314CFC-0x000000018D314D1C
			public static bool operator !=(DeviceRequirement left, DeviceRequirement right); // 0x000000018D314D1C-0x000000018D314D3C
		}
	
		[Serializable]
		internal struct SchemeJson // TypeDefIndex: 72183
		{
			// Fields
			public string name; // 0x00
			public string bindingGroup; // 0x08
			public DeviceJson[] devices; // 0x10
	
			// Nested types
			[Serializable]
			public struct DeviceJson // TypeDefIndex: 72182
			{
				// Fields
				public string devicePath; // 0x00
				public bool isOptional; // 0x08
				public bool isOR; // 0x09
	
				// Methods
				public DeviceRequirement ToDeviceEntry(); // 0x000000018D314A90-0x000000018D314ADC
				public static DeviceJson From(DeviceRequirement requirement); // 0x000000018D314A50-0x000000018D314A90
			}
	
			// Methods
			public InputControlScheme ToScheme(); // 0x000000018D3221EC-0x000000018D32233C
			public static SchemeJson ToJson(InputControlScheme scheme); // 0x000000018D321F1C-0x000000018D3220DC
			public static SchemeJson[] ToJson(InputControlScheme[] schemes); // 0x000000018D3220DC-0x000000018D3221EC
			public static InputControlScheme[] ToSchemes(SchemeJson[] schemes); // 0x000000018D32233C-0x000000018D322414
		}
	
		// Constructors
		public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null); // 0x000000018D319B54-0x000000018D319C74
	
		// Methods
		internal void SetNameAndBindingGroup(string name, string bindingGroup = null); // 0x000000018D31988C-0x000000018D319940
		public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false /* Metadata: 0x0262286A */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme>;
		public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false /* Metadata: 0x0262286B */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme>;
		public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
			where TSchemes : IEnumerable<InputControlScheme>;
		public bool SupportsDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D319940-0x000000018D3199FC
		public MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice = null)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>;
		public bool Equals(InputControlScheme other); // 0x000000018D3195C8-0x000000018D319790
		public override bool Equals(object obj); // 0x000000018D319790-0x000000018D319808
		public override int GetHashCode(); // 0x000000018D319808-0x000000018D31988C
		public override string ToString(); // 0x000000018D3199FC-0x000000018D319B54
		public static bool operator ==(InputControlScheme left, InputControlScheme right); // 0x000000018D319CC8-0x000000018D319CF4
		public static bool operator !=(InputControlScheme left, InputControlScheme right); // 0x000000018D319CF4-0x000000018D319D20
	}

	public struct InputInteractionContext // TypeDefIndex: 72186
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal Flags m_Flags; // 0x08
		internal InputActionState.TriggerState m_TriggerState; // 0x10
	
		// Properties
		public InputAction action { get; } // 0x000000018D31CCAC-0x000000018D31CCD4 
		public InputControl control { get; } // 0x000000018D31CCE0-0x000000018D31CD08 
		public InputActionPhase phase { get; } // 0x00000001829D0800-0x00000001829D0810 
		public double time { get; } // 0x0000000187233020-0x0000000187233030 
		public double startTime { get; } // 0x00000001872331C0-0x00000001872331D0 
		public bool timerHasExpired { get; internal set; } // 0x000000018D314CEC-0x000000018D314CF4 0x000000018D314D58-0x000000018D314D74
		public bool isWaiting { get; } // 0x000000018D31CD1C-0x000000018D31CD24 
		public bool isStarted { get; } // 0x000000018D31CD14-0x000000018D31CD1C 
		internal int mapIndex { get; } // 0x0000000187235CB0-0x0000000187235CC0 
		internal int controlIndex { get; } // 0x000000018D31CCD4-0x000000018D31CCE0 
		internal int bindingIndex { get; } // 0x0000000187259E00-0x0000000187259E10 
		internal int interactionIndex { get; } // 0x000000018D31CD08-0x000000018D31CD14 
	
		// Nested types
		[Flags]
		internal enum Flags // TypeDefIndex: 72185
		{
			TimerHasExpired = 2
		}
	
		// Methods
		public float ComputeMagnitude(); // 0x0000000187233330-0x0000000187233340
		public bool ControlIsActuated(float threshold = 0f /* Metadata: 0x02622872 */); // 0x000000018D31C9E4-0x000000018D31CA40
		public void Started(); // 0x000000018D31CC18-0x000000018D31CC64
		public void Performed(); // 0x000000018D31CAE0-0x000000018D31CB30
		public void PerformedAndStayStarted(); // 0x000000018D31CA90-0x000000018D31CAE0
		public void PerformedAndStayPerformed(); // 0x000000018D31CA40-0x000000018D31CA90
		public void Canceled(); // 0x000000018D31C998-0x000000018D31C9E4
		public void Waiting(); // 0x000000018D31CC64-0x000000018D31CCAC
		public void SetTimeout(float seconds); // 0x000000018D31CB30-0x000000018D31CB58
		public void SetTotalTimeoutCompletionTime(float seconds); // 0x000000018D31CB58-0x000000018D31CC18
		public TValue ReadValue<TValue>()
			where TValue : struct;
	}

	public static class InputSystem // TypeDefIndex: 72192
	{
		// Fields
		internal const string kAssemblyVersion = "1.14.0"; // Metadata: 0x02622899
		internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14"; // Metadata: 0x026228A0
		private static readonly ProfilerMarker k_InputResetMarker; // 0x00
		internal const float scrollWheelDeltaPerTick = 1f; // Metadata: 0x026228DD
		internal static InputManager s_Manager; // 0x08
		internal static InputRemoting s_Remote; // 0x10
	
		// Properties
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x0000000185B0D040-0x0000000185B0D0C0 
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> disconnectedDevices { get; } // 0x000000018D31FA90-0x000000018D31FB24 
		public static float pollingFrequency { get; set; } // 0x000000018D31FE18-0x000000018D31FE78 0x000000018D3207D8-0x000000018D320840
		internal static bool isProcessingEvents { get; } // 0x000000018D31FB24-0x000000018D31FB88 
		public static InputEventListener onEvent { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
		public static IObservable<InputControl> onAnyButtonPress { get; } // 0x000000018D31FC0C-0x000000018D31FE18 
		public static InputSettings settings { get; set; } // 0x000000018526D070-0x000000018526D100 0x000000018D3208D0-0x000000018D3209FC
		public static InputRemoting remoting { get; } // 0x000000018D31FE78-0x000000018D31FEC8 
		public static System.Version version { get; } // 0x000000018D31FF28-0x000000018D31FF8C 
		public static bool runInBackground { get; set; } // 0x000000018D31FEC8-0x000000018D31FF28 0x000000018D320840-0x000000018D3208D0
		public static InputMetrics metrics { get; } // 0x000000018D31FB88-0x000000018D31FC0C 
	
		// Events
		public static event Action<string, InputControlLayoutChange> onLayoutChange {
			add; // 0x000000018D31F97C-0x000000018D31FA90
			remove; // 0x000000018D320664-0x000000018D320778
		}
		public static event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange {
			add; // 0x0000000186F86E20-0x0000000186F870F0
			remove; // 0x000000018D320270-0x000000018D3203E0
		}
		public static event InputDeviceCommandDelegate onDeviceCommand {
			add; // 0x000000018D31F80C-0x000000018D31F97C
			remove; // 0x000000018D3203E0-0x000000018D320550
		}
		public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice {
			add; // 0x0000000185B0CBE0-0x0000000185B0CE50
			remove; // 0x000000018D320550-0x000000018D320664
		}
		public static event Action onBeforeUpdate {
			add; // 0x0000000185B00BB0-0x0000000185B00E20
			remove; // 0x000000018D32015C-0x000000018D320270
		}
		public static event Action onAfterUpdate {
			add; // 0x0000000185B00E20-0x0000000185B01080
			remove; // 0x000000018D320048-0x000000018D32015C
		}
		public static event Action onSettingsChange {
			add; // 0x0000000185B01080-0x0000000185B010F0
			remove; // 0x000000018D320778-0x000000018D3207D8
		}
		public static event Action<object, InputActionChange> onActionChange {
			add; // 0x000000018D31F750-0x000000018D31F80C
			remove; // 0x000000018D31FF8C-0x000000018D320048
		}
	
		// Nested types
		private struct StateEventBuffer // TypeDefIndex: 72188
		{
			// Fields
			public StateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x026228E1
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x19
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _data_e__FixedBuffer // TypeDefIndex: 72187
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		private struct DeltaStateEventBuffer // TypeDefIndex: 72190
		{
			// Fields
			public DeltaStateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x026228E3
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x1D
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _data_e__FixedBuffer // TypeDefIndex: 72189
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72191
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InputEventPtr, InputControl> __9__80_0; // 0x08
			public static Func<InputControl, bool> __9__80_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D322ED4-0x000000018D322F38
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal InputControl _get_onAnyButtonPress_b__80_0(InputEventPtr e); // 0x000000018D322E58-0x000000018D322E70
			internal bool _get_onAnyButtonPress_b__80_1(InputControl c); // 0x00000001894D8534-0x00000001894D853C
		}
	
		// Constructors
		static InputSystem(); // 0x0000000185B0AA40-0x0000000185B0AAB0
	
		// Methods
		public static void RegisterLayout(System.Type type, string name = null, InputDeviceMatcher? matches = default); // 0x000000018662BCC0-0x000000018662BE30
		public static void RegisterLayout<T>(string name = null, InputDeviceMatcher? matches = default)
			where T : InputControl;
		public static void RegisterLayout(string json, string name = null, InputDeviceMatcher? matches = default); // 0x0000000185B0AD90-0x0000000185B0AE50
		public static void RegisterLayoutOverride(string json, string name = null); // 0x000000018D31E87C-0x000000018D31E8F4
		public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher); // 0x000000018D31E80C-0x000000018D31E87C
		public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, InputDeviceMatcher? matches = default); // 0x000000018D31E658-0x000000018D31E80C
		public static void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new();
		public static void RemoveLayout(string name); // 0x000000018D31EEB4-0x000000018D31EF14
		public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription); // 0x000000018D31F2D0-0x000000018D31F354
		public static IEnumerable<string> ListLayouts(); // 0x000000018D31DCB4-0x000000018D31DD0C
		public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout); // 0x000000018D31DBFC-0x000000018D31DCB4
		public static InputControlLayout LoadLayout(string name); // 0x000000018D31DD70-0x000000018D31DE60
		public static InputControlLayout LoadLayout<TControl>()
			where TControl : InputControl;
		public static string GetNameOfBaseLayout(string layoutName); // 0x000000018D31D6FC-0x000000018D31D810
		public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName); // 0x000000018D31D8F4-0x000000018D31DA78
		public static void RegisterProcessor(System.Type type, string name = null); // 0x000000018D31E8F4-0x000000018D31ED34
		public static void RegisterProcessor<T>(string name = null);
		public static System.Type TryGetProcessor(string name); // 0x000000018D31F4E4-0x000000018D31F5AC
		public static IEnumerable<string> ListProcessors(); // 0x000000018D31DD0C-0x000000018D31DD70
		public static UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, string variants = null); // 0x000000018D31CFC8-0x000000018D31D0E4
		public static TDevice AddDevice<TDevice>(string name = null)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description); // 0x000000018D31D0E4-0x000000018D31D1E4
		public static void AddDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D31CF14-0x000000018D31CFC8
		public static void RemoveDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D31EE50-0x000000018D31EEB4
		public static void FlushDisconnectedDevices(); // 0x000000018D31D454-0x000000018D31D4A8
		public static UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout); // 0x000000018D31D69C-0x000000018D31D6FC
		public static TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice GetDevice(System.Type type); // 0x000000018D31D4A8-0x000000018D31D69C
		public static TDevice GetDevice<TDevice>(InternedString usage)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static TDevice GetDevice<TDevice>(string usage)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId); // 0x00000001853AAFB0-0x00000001853AB100
		public static List<InputDeviceDescription> GetUnsupportedDevices(); // 0x000000018D31D810-0x000000018D31D894
		public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions); // 0x000000018D31D894-0x000000018D31D8F4
		public static void EnableDevice(UnityEngine.InputSystem.InputDevice device); // 0x0000000185B0CF50-0x0000000185B0CFD0
		public static void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents = false /* Metadata: 0x02622877 */); // 0x000000018D31D224-0x000000018D31D29C
		public static bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D31F618-0x000000018D31F6FC
		public static void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x02622878 */); // 0x000000018D31EF14-0x000000018D31EF94
		[Obsolete("Use \'ResetDevice\' instead.", false)]
		public static bool TryResetDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D31F5AC-0x000000018D31F618
		public static void PauseHaptics(); // 0x000000018D31DE60-0x000000018D31DF80
		public static void ResumeHaptics(); // 0x000000018D31F0B8-0x000000018D31F1DC
		public static void ResetHaptics(); // 0x000000018D31EF94-0x000000018D31F0B8
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018D31F1DC-0x000000018D31F254
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D31F254-0x000000018D31F2D0
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018D31CE74-0x000000018D31CF14
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D31CDF8-0x000000018D31CE74
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage); // 0x000000018D31EDB0-0x000000018D31EE50
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D31ED34-0x000000018D31EDB0
		public static InputControl FindControl(string path); // 0x000000018D31D29C-0x000000018D31D3DC
		public static InputControlList<InputControl> FindControls(string path); // 0x000000018D31D3DC-0x000000018D31D454
		public static InputControlList<TControl> FindControls<TControl>(string path)
			where TControl : InputControl;
		public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl;
		public static void QueueEvent(InputEventPtr eventPtr); // 0x000000018D31E120-0x000000018D31E1EC
		public static void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo;
		public static void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time = -1 /* Metadata: 0x02622879 */)
			where TState : struct, IInputStateTypeInfo;
		public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1 /* Metadata: 0x02622881 */)
			where TDelta : struct;
		public static void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time = -1 /* Metadata: 0x02622889 */); // 0x000000018D31DF80-0x000000018D31E120
		public static void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time = -1 /* Metadata: 0x02622891 */); // 0x000000018D31E1EC-0x000000018D31E3A8
		public static void Update(); // 0x000000018D31F6FC-0x000000018D31F750
		internal static void Update(InputUpdateType updateType); // 0x0000000186F90730-0x0000000186F907B0
		public static void RegisterInteraction(System.Type type, string name = null); // 0x000000018D31E500-0x000000018D31E658
		public static void RegisterInteraction<T>(string name = null);
		public static System.Type TryGetInteraction(string name); // 0x000000018D31F41C-0x000000018D31F4E4
		public static IEnumerable<string> ListInteractions(); // 0x000000018D31DB98-0x000000018D31DBFC
		public static void RegisterBindingComposite(System.Type type, string name); // 0x000000018D31E3A8-0x000000018D31E500
		public static void RegisterBindingComposite<T>(string name = null);
		public static System.Type TryGetBindingComposite(string name); // 0x000000018D31F354-0x000000018D31F41C
		public static void DisableAllEnabledActions(); // 0x000000018D31D1E4-0x000000018D31D224
		public static List<InputAction> ListEnabledActions(); // 0x000000018D31DB14-0x000000018D31DB98
		public static int ListEnabledActions(List<InputAction> actions); // 0x000000018D31DA78-0x000000018D31DB14
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RunInitializeInPlayer(); // 0x00000001871FB720-0x00000001871FB780
		internal static void EnsureInitialized(); // 0x0000000186805BA0-0x0000000186805BB0
		private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null); // 0x0000000185B0AAB0-0x0000000185B0AC80
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RunInitialUpdate(); // 0x0000000186F90690-0x0000000186F90730
		private static void PerformDefaultPluginInitialization(); // 0x0000000185B0AC80-0x0000000185B0ACC0
	}

	public static class CommonUsages // TypeDefIndex: 72193
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
		static CommonUsages(); // 0x000000018D313854-0x000000018D314214
	}

	[DebuggerDisplay("{DebuggerDisplay(),nq}")]
	public abstract class InputControl // TypeDefIndex: 72195
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
		public string name { get; } // 0x0000000187835758-0x0000000187835778 
		public string displayName { get; protected set; } // 0x0000000185B0E510-0x0000000185B0E550 0x0000000186AB5C00-0x0000000186AB5C10
		public string shortDisplayName { get; protected set; } // 0x000000018D31AAC4-0x000000018D31AAF8 0x0000000185B68F50-0x0000000185B68F60
		public string path { get; } // 0x000000018D31AA74-0x000000018D31AAC4 
		public string layout { get; } // 0x0000000187835778-0x0000000187835798 
		public string variants { get; } // 0x000000018D31ABDC-0x000000018D31ABFC 
		public UnityEngine.InputSystem.InputDevice device { get; } // 0x00000001829CD170-0x00000001829CD180 
		public InputControl parent { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public ReadOnlyArray<InputControl> children { get; } // 0x000000018526AC50-0x000000018526ACD0 
		public ReadOnlyArray<InternedString> usages { get; } // 0x000000018D31AB64-0x000000018D31ABDC 
		public ReadOnlyArray<InternedString> aliases { get; } // 0x0000000185268A70-0x0000000185268AC0 
		public InputStateBlock stateBlock { get; } // 0x0000000184430480-0x0000000184430490 
		public bool noisy { get; internal set; } // 0x00000001853AFA00-0x00000001853AFA10 0x000000018D31ABFC-0x000000018D31ACD8
		public bool synthetic { get; internal set; } // 0x000000018D31AB58-0x000000018D31AB64 0x00000001863707F0-0x0000000186370810
		public InputControl this[string path] { get => default; } // 0x000000018D31A970-0x000000018D31AA04 
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
		public float magnitude { get; } // 0x00000001878357D8-0x000000018783585C 
		protected internal unsafe void* currentStatePtr { get; } // 0x00000001853AF910-0x00000001853AF970 
		protected internal unsafe void* previousFrameStatePtr { get; } // 0x00000001869130E0-0x0000000186913100 
		protected internal unsafe void* defaultStatePtr { get; } // 0x000000018D31AA04-0x000000018D31AA3C 
		protected internal unsafe void* noiseMaskPtr { get; } // 0x000000018D31AA3C-0x000000018D31AA74 
		protected internal uint stateOffsetRelativeToDeviceRoot { get; } // 0x000000018D31AAF8-0x000000018D31AB58 
		public FourCC optimizedControlDataType { get; } // 0x000000018723CB10-0x000000018723CB20 
		internal bool isSetupFinished { get; set; } // 0x000000018636E890-0x000000018636E8A0 0x000000018636A8F0-0x000000018636A910
		internal bool isButton { get; set; } // 0x000000018526FA50-0x000000018526FA60 0x0000000186371550-0x0000000186371570
		internal bool isConfigUpToDate { get; set; } // 0x0000000185B0E5C0-0x0000000185B0E5D0 0x0000000185B0E5D0-0x0000000185B0E5F0
		internal bool dontReset { get; set; } // 0x0000000185268AD0-0x0000000185268AE0 0x0000000186EBF390-0x0000000186EBF3B0
		internal bool usesStateFromOtherControl { get; set; } // 0x0000000185268AC0-0x0000000185268AD0 0x000000018D31ACD8-0x000000018D31ACF8
		internal bool hasDefaultState { get; } // 0x0000000186535E10-0x0000000186535E20 
	
		// Nested types
		[Flags]
		internal enum ControlFlags // TypeDefIndex: 72194
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
		protected InputControl(); // 0x0000000186A2CEE0-0x0000000186A2CF20
	
		// Methods
		public override string ToString(); // 0x000000018D31A7A4-0x000000018D31A810
		private string DebuggerDisplay(); // 0x000000018D319E14-0x000000018D319F38
		public float EvaluateMagnitude(); // 0x0000000186390D30-0x0000000186390DA0
		public virtual unsafe float EvaluateMagnitude(void* statePtr); // 0x0000000187257DF0-0x0000000187257E00
		public abstract unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
		public abstract unsafe object ReadValueFromStateAsObject(void* statePtr);
		public abstract unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
		public virtual unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr); // 0x000000018D31A888-0x000000018D31A8FC
		public virtual unsafe void WriteValueFromObjectIntoState(object value, void* statePtr); // 0x000000018D31A8FC-0x000000018D31A970
		public abstract unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr);
		public InputControl TryGetChildControl(string path); // 0x000000018D31A810-0x000000018D31A888
		public TControl TryGetChildControl<TControl>(string path)
			where TControl : InputControl;
		public InputControl GetChildControl(string path); // 0x000000018D31A2DC-0x000000018D31A400
		public TControl GetChildControl<TControl>(string path)
			where TControl : InputControl;
		protected virtual void FinishSetup(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void RefreshConfigurationIfNeeded(); // 0x0000000185B0E590-0x0000000185B0E5C0
		protected virtual void RefreshConfiguration(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual FourCC CalculateOptimizedControlDataType(); // 0x0000000185829EC0-0x0000000185829ED0
		public void ApplyParameterChanges(); // 0x000000018D319D20-0x000000018D319D64
		private void SetOptimizedControlDataType(); // 0x000000018D31A730-0x000000018D31A7A4
		internal void SetOptimizedControlDataTypeRecursively(); // 0x000000018D31A5E0-0x000000018D31A730
		[Conditional("UNITY_EDITOR")]
		internal void EnsureOptimizationTypeHasNotChanged(); // 0x000000018D319F38-0x000000018D31A2DC
		internal void CallFinishSetupRecursive(); // 0x000000018D319D64-0x000000018D319E14
		internal string MakeChildPath(string path); // 0x000000018D31A400-0x000000018D31A47C
		internal void BakeOffsetIntoStateBlockRecursive(uint offset); // 0x000000018526A700-0x000000018526AC50
		internal int GetDeviceIndex(); // 0x00000001853AF9C0-0x00000001853AFA00
		internal bool IsValueConsideredPressed(float value); // 0x000000018526F9E0-0x000000018526FA50
		internal virtual void AddProcessor(object first); // 0x0000000186805BA0-0x0000000186805BB0
		internal void MarkAsStale(); // 0x0000000187259D70-0x0000000187259D80
		public void MarkAsStaleRecursively(); // 0x000000018D31A47C-0x000000018D31A5E0
	}

	public abstract class InputControl<TValue> : InputControl // TypeDefIndex: 72196
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

	public static class InputControlExtensions // TypeDefIndex: 72203
	{
		// Nested types
		[Flags]
		public enum Enumerate // TypeDefIndex: 72197
		{
			IgnoreControlsInDefaultState = 1,
			IgnoreControlsInCurrentState = 2,
			IncludeSyntheticControls = 4,
			IncludeNoisyControls = 8,
			IncludeNonLeafControls = 16
		}
	
		public struct InputEventControlCollection : IEnumerable<InputControl> // TypeDefIndex: 72198
		{
			// Fields
			internal UnityEngine.InputSystem.InputDevice m_Device; // 0x00
			internal InputEventPtr m_EventPtr; // 0x08
			internal Enumerate m_Flags; // 0x10
			internal float m_MagnitudeThreshold; // 0x14
	
			// Properties
			public InputEventPtr eventPtr { get; } // 0x00000001844AFA30-0x00000001844AFA40 
	
			// Methods
			public InputEventControlEnumerator GetEnumerator(); // 0x000000018D31BEC0-0x000000018D31BF34
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator(); // 0x000000018D31BF34-0x000000018D31BFCC
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D31BFCC-0x000000018D31C064
		}
	
		public struct InputEventControlEnumerator : IEnumerator<InputControl> // TypeDefIndex: 72199
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
			public InputControl Current { get; } // 0x000000018226EE80-0x000000018226EE90 
			object IEnumerator.Current { get; } // 0x000000018226EE80-0x000000018226EE90 
	
			// Constructors
			internal unsafe InputEventControlEnumerator(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, Enumerate flags, float magnitudeThreshold = 0f /* Metadata: 0x02622919 */); // 0x000000018D31C820-0x000000018D31C998
	
			// Methods
			private bool CheckDefault(uint numBits); // 0x000000018D31C094-0x000000018D31C0C4
			private bool CheckCurrent(uint numBits); // 0x000000018D31C064-0x000000018D31C094
			public bool MoveNext(); // 0x000000018D31C0C4-0x000000018D31C49C
			public void Reset(); // 0x000000018D31C49C-0x000000018D31C820
			public void Dispose(); // 0x0000000187259DF0-0x0000000187259E00
		}
	
		public struct ControlBuilder // TypeDefIndex: 72200
		{
			// Fields
			[CompilerGenerated]
			private InputControl _control_k__BackingField; // 0x00
	
			// Properties
			public InputControl control { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			public ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index); // 0x000000018D314214-0x000000018D31429C
			public ControlBuilder WithParent(InputControl parent); // 0x000000018D31449C-0x000000018D3144CC
			public ControlBuilder WithName(string name); // 0x0000000186375710-0x00000001863757F0
			public ControlBuilder WithDisplayName(string displayName); // 0x000000018D3143D0-0x000000018D314434
			public ControlBuilder WithShortDisplayName(string shortDisplayName); // 0x000000018D3144CC-0x000000018D314530
			public ControlBuilder WithLayout(InternedString layout); // 0x000000018D314434-0x000000018D314464
			public ControlBuilder WithUsages(int startIndex, int count); // 0x0000000186370F60-0x0000000186370F90
			public ControlBuilder WithAliases(int startIndex, int count); // 0x0000000186370F30-0x0000000186370F60
			public ControlBuilder WithChildren(int startIndex, int count); // 0x0000000186371130-0x0000000186371160
			public ControlBuilder WithStateBlock(InputStateBlock stateBlock); // 0x000000018D314530-0x000000018D314554
			public ControlBuilder WithDefaultState(PrimitiveValue value); // 0x000000018D314388-0x000000018D3143D0
			public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max); // 0x000000018D314464-0x000000018D31449C
			public ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor)
				where TProcessor : InputProcessor<TValue>
				where TValue : struct;
			public ControlBuilder IsNoisy(bool value); // 0x000000018D314338-0x000000018D314360
			public ControlBuilder IsSynthetic(bool value); // 0x000000018D314360-0x000000018D314388
			public ControlBuilder DontReset(bool value); // 0x000000018D31429C-0x000000018D3142F0
			public ControlBuilder IsButton(bool value); // 0x000000018D314310-0x000000018D314338
			public void Finish(); // 0x000000018D3142F0-0x000000018D314310
		}
	
		public struct DeviceBuilder // TypeDefIndex: 72201
		{
			// Fields
			[CompilerGenerated]
			private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x00
	
			// Properties
			public UnityEngine.InputSystem.InputDevice device { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			public DeviceBuilder WithName(string name); // 0x0000000186375710-0x00000001863757F0
			public DeviceBuilder WithDisplayName(string displayName); // 0x000000018D3143D0-0x000000018D314434
			public DeviceBuilder WithShortDisplayName(string shortDisplayName); // 0x000000018D3144CC-0x000000018D314530
			public DeviceBuilder WithLayout(InternedString layout); // 0x000000018D314434-0x000000018D314464
			public DeviceBuilder WithChildren(int startIndex, int count); // 0x0000000186371130-0x0000000186371160
			public DeviceBuilder WithStateBlock(InputStateBlock stateBlock); // 0x000000018D314530-0x000000018D314554
			public DeviceBuilder IsNoisy(bool value); // 0x000000018D314338-0x000000018D314360
			public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control); // 0x000000018D3149BC-0x000000018D314A50
			public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias); // 0x000000018D314838-0x000000018D31487C
			public DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map); // 0x00000001863757F0-0x0000000186375820
			public DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies); // 0x000000018D31487C-0x000000018D3149BC
			public void Finish(); // 0x000000018D314554-0x000000018D314838
		}
	
		[CompilerGenerated]
		private sealed class _GetAllButtonPresses_d__43 : IEnumerable<InputControl>, IEnumerator<InputControl> // TypeDefIndex: 72202
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
			InputControl IEnumerator<UnityEngine.InputSystem.InputControl>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllButtonPresses_d__43(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D322844-0x000000018D3228BC
			private bool MoveNext(); // 0x000000018D322414-0x000000018D322758
			private void __m__Finally1(); // 0x0000000187259E10-0x0000000187259E30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3227F8-0x000000018D322844
			[DebuggerHidden]
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator(); // 0x000000018D322758-0x000000018D3227F0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D3227F0-0x000000018D3227F8
		}
	
		// Extension methods
		public static TControl FindInParentChain<TControl>(this InputControl control)
			where TControl : InputControl;
		public static bool IsPressed(this InputControl control, float buttonPressPoint = 0f /* Metadata: 0x026228ED */); // 0x000000018D316F24-0x000000018D317048
		public static bool IsActuated(this InputControl control, float threshold = 0f /* Metadata: 0x026228F1 */); // 0x000000018D316E74-0x000000018D316F24
		public static object ReadValueAsObject(this InputControl control); // 0x000000018D3170C0-0x000000018D31713C
		public static unsafe void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize); // 0x000000018D3171CC-0x000000018D3172BC
		public static object ReadDefaultValueAsObject(this InputControl control); // 0x000000018D317048-0x000000018D3170C0
		public static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent)
			where TValue : struct;
		public static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct;
		public static object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent); // 0x000000018D31713C-0x000000018D3171CC
		public static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr)
			where TValue : struct;
		public static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct;
		public static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, object value); // 0x000000018D317484-0x000000018D317538
		public static unsafe void WriteValueIntoState(this InputControl control, void* statePtr); // 0x000000018D317538-0x000000018D317704
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
		public static unsafe void CopyState(this UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes); // 0x000000018D3162C0-0x000000018D316430
		public static void CopyState<TState>(this UnityEngine.InputSystem.InputDevice device, out ref TState state)
			where TState : struct, IInputStateTypeInfo;
		public static bool CheckStateIsAtDefault(this InputControl control); // 0x000000018526FC20-0x000000018526FCB0
		public static unsafe bool CheckStateIsAtDefault(this InputControl control, void* statePtr, void* maskPtr = null); // 0x000000018526FCB0-0x000000018526FD50
		public static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control); // 0x000000018D315F24-0x000000018D315FA0
		public static unsafe bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr); // 0x000000018D315FA0-0x000000018D3160C4
		public static unsafe bool CompareStateIgnoringNoise(this InputControl control, void* statePtr); // 0x000000018D3160C4-0x000000018D3161C4
		public static unsafe bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null); // 0x000000018526FD50-0x000000018526FEB0
		public static unsafe bool CompareState(this InputControl control, void* statePtr, void* maskPtr = null); // 0x000000018D3161C4-0x000000018D3162C0
		public static unsafe bool HasValueChangeInState(this InputControl control, void* statePtr); // 0x000000018D316D98-0x000000018D316E74
		public static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018D316CA4-0x000000018D316D98
		public static unsafe void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018D316BA4-0x000000018D316C8C
		internal static unsafe void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType); // 0x000000018D316980-0x000000018D316BA4
		public static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr); // 0x000000018D3172BC-0x000000018D317484
		public static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x026228F5 */)
			where TValue : struct;
		public static unsafe void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState); // 0x000000018D315A18-0x000000018D315B10
		internal static unsafe void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState); // 0x000000018D315B10-0x000000018D315C08
		public static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate)
			where TControl : InputControl;
		internal static string BuildPath(this InputControl control, string deviceLayout, StringBuilder builder = null); // 0x000000018D315C08-0x000000018D315F24
		public static InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, Enumerate flags, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x026228FD */); // 0x000000018D316474-0x000000018D3166F4
		public static InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x02622901 */); // 0x000000018D316430-0x000000018D316474
		public static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x02622905 */, bool buttonControlsOnly = true /* Metadata: 0x02622909 */); // 0x000000018D316C8C-0x000000018D316CA4
		public static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0262290A */, bool buttonControlsOnly = true /* Metadata: 0x0262290E */); // 0x000000018D31677C-0x000000018D316980
		[IteratorStateMachine(typeof(_GetAllButtonPresses_d__43))]
		public static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0262290F */, bool buttonControlsOnly = true /* Metadata: 0x02622913 */); // 0x000000018D3166F4-0x000000018D31677C
		public static ControlBuilder Setup(this InputControl control); // 0x000000018636E840-0x000000018636E890
		public static DeviceBuilder Setup(this UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount); // 0x000000018636E6F0-0x000000018636E840
	}

	public enum InputControlLayoutChange // TypeDefIndex: 72204
	{
		Added = 0,
		Removed = 1,
		Replaced = 2
	}

	[DebuggerDisplay("Count = {Count}")]
	public struct InputControlList<TControl> : IList<TControl>, IReadOnlyList<TControl>, IDisposable // TypeDefIndex: 72206
		where TControl : InputControl
	{
		// Fields
		private int m_Count;
		private NativeArray<ulong> m_Indices;
		private readonly Unity.Collections.Allocator m_Allocator;
		private const ulong kInvalidIndex = 18446744073709551615; // Metadata: 0x0262292A
	
		// Properties
		public int Count { get; }
		public int Capacity { get; set; }
		public bool IsReadOnly { get; }
		public TControl this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TControl> // TypeDefIndex: 72205
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
		public InputControlList(Unity.Collections.Allocator allocator, int initialCapacity = 0 /* Metadata: 0x02622920 */);
		public InputControlList(IEnumerable<TControl> values, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02622921 */);
		public InputControlList(params TControl[] values);
	
		// Methods
		public void Resize(int size);
		public void Add(TControl item);
		public void AddSlice<TList>(TList list, int count = -1 /* Metadata: 0x02622922 */, int destinationIndex = -1 /* Metadata: 0x02622923 */, int sourceIndex = 0 /* Metadata: 0x02622924 */)
			where TList : IReadOnlyList<TControl>;
		public void AddRange(IEnumerable<TControl> list, int count = -1 /* Metadata: 0x02622925 */, int destinationIndex = -1 /* Metadata: 0x02622926 */);
		public bool Remove(TControl item);
		public void RemoveAt(int index);
		public void CopyTo(TControl[] array, int arrayIndex);
		public int IndexOf(TControl item);
		public int IndexOf(TControl item, int startIndex, int count = -1 /* Metadata: 0x02622927 */);
		public void Insert(int index, TControl item);
		public void Clear();
		public bool Contains(TControl item);
		public bool Contains(TControl item, int startIndex, int count = -1 /* Metadata: 0x02622928 */);
		public void SwapElements(int index1, int index2);
		public void Sort<TCompare>(int startIndex, int count, TCompare comparer)
			where TCompare : IComparer<TControl>;
		public TControl[] ToArray(bool dispose = false /* Metadata: 0x02622929 */);
		internal void AppendTo(ref ref TControl[] array, ref int count);
		public void Dispose();
		public IEnumerator<TControl> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public override string ToString();
		private static ulong ToIndex(TControl control);
		private static TControl FromIndex(ulong index);
	}

	public static class InputControlPath // TypeDefIndex: 72214
	{
		// Fields
		public const string Wildcard = "*"; // Metadata: 0x0262293D
		public const string DoubleWildcard = "**"; // Metadata: 0x0262293F
		public const char Separator = '/'; // Metadata: 0x02622942
		internal const char SeparatorReplacement = ' '; // Metadata: 0x02622944
	
		// Nested types
		[Flags]
		public enum HumanReadableStringOptions // TypeDefIndex: 72207
		{
			None = 0,
			OmitDevice = 2,
			UseShortNames = 4
		}
	
		private enum PathComponentType // TypeDefIndex: 72208
		{
			Name = 0,
			DisplayName = 1,
			Usage = 2,
			Layout = 3
		}
	
		public struct ParsedPathComponent // TypeDefIndex: 72210
		{
			// Fields
			internal Substring m_Layout; // 0x00
			internal InlinedArray<Substring> m_Usages; // 0x10
			internal Substring m_Name; // 0x30
			internal Substring m_DisplayName; // 0x40
	
			// Properties
			public string layout { get; } // 0x000000018D321A04-0x000000018D321A0C 
			public IEnumerable<string> usages { get; } // 0x000000018D321A18-0x000000018D321B54 
			public string name { get; } // 0x000000018D321A0C-0x000000018D321A18 
			public string displayName { get; } // 0x000000018D321918-0x000000018D321924 
			internal bool isWildcard { get; } // 0x000000018D321994-0x000000018D321A04 
			internal bool isDoubleWildcard { get; } // 0x000000018D321924-0x000000018D321994 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 72209
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<Substring, string> __9__7_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D322E70-0x000000018D322ED4
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _get_usages_b__7_0(Substring x); // 0x000000018D322E44-0x000000018D322E58
			}
	
			// Methods
			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options); // 0x000000018D321194-0x000000018D321918
			private static string ToHumanReadableString(Substring substring); // 0x000000018D321148-0x000000018D321194
			public bool Matches(InputControl control); // 0x000000018D320E84-0x000000018D321148
			private static bool ComparePathElementToString(Substring pathElement, string element); // 0x000000018D320D94-0x000000018D320E84
		}
	
		private struct PathParser // TypeDefIndex: 72211
		{
			// Fields
			private string path; // 0x00
			private int length; // 0x08
			private int leftIndexInPath; // 0x0C
			private int rightIndexInPath; // 0x10
			public ParsedPathComponent current; // 0x18
	
			// Properties
			public bool isAtEnd { get; } // 0x000000018D321F10-0x000000018D321F1C 
	
			// Constructors
			public PathParser(string path); // 0x000000018D321ED0-0x000000018D321F10
	
			// Methods
			public bool MoveToNextComponent(); // 0x000000018D321B54-0x000000018D321E00
			private Substring ParseComponentPart(char terminator); // 0x000000018D321E00-0x000000018D321ED0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72212
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Substring, string> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D322F38-0x000000018D322F9C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _TryGetDeviceUsages_b__9_0(Substring x); // 0x000000018D322E44-0x000000018D322E58
		}
	
		[CompilerGenerated]
		private sealed class _Parse_d__34 : IEnumerable<ParsedPathComponent>, IEnumerator<ParsedPathComponent> // TypeDefIndex: 72213
		{
			// Fields
			private int __1__state; // 0x10
			private ParsedPathComponent __2__current; // 0x18
			private int __l__initialThreadId; // 0x68
			private string path; // 0x70
			public string __3__path; // 0x78
			private PathParser _parser_5__2; // 0x80
	
			// Properties
			ParsedPathComponent IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.Current { [DebuggerHidden] get; } // 0x000000018724A1F0-0x000000018724A220 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D322DBC-0x000000018D322E28 
	
			// Constructors
			[DebuggerHidden]
			public _Parse_d__34(int __1__state); // 0x000000018D322E28-0x000000018D322E44
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D322B4C-0x000000018D322CD4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D322D70-0x000000018D322DBC
			[DebuggerHidden]
			IEnumerator<ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator(); // 0x000000018D322CD4-0x000000018D322D68
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D322D68-0x000000018D322D70
		}
	
		// Methods
		public static string Combine(InputControl parent, string path); // 0x000000018D31772C-0x000000018D3177F4
		public static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x02622932 */, InputControl control = null); // 0x000000018D318458-0x000000018D31848C
		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x02622933 */, InputControl control = null); // 0x000000018D31848C-0x000000018D318E8C
		public static string[] TryGetDeviceUsages(string path); // 0x000000018D319424-0x000000018D3195C8
		public static string TryGetDeviceLayout(string path); // 0x000000018D319310-0x000000018D319424
		public static string TryGetControlLayout(string path); // 0x000000018D3190F0-0x000000018D319310
		private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName); // 0x000000018D317B58-0x000000018D317CD4
		private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout); // 0x000000018D317980-0x000000018D317B58
		private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser); // 0x000000018D3177F4-0x000000018D317980
		private static bool StringMatches(Substring str, InternedString matchTo); // 0x000000018D3182A0-0x000000018D318458
		public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x02622934 */); // 0x000000018D318EE4-0x000000018D318F3C
		public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x02622935 */); // 0x000000018D318FAC-0x000000018D3190F0
		public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0 /* Metadata: 0x02622936 */); // 0x000000018D318F3C-0x000000018D318FAC
		public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x02622937 */)
			where TControl : InputControl;
		public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches)
			where TControl : InputControl;
		public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x02622938 */); // 0x000000018D318E8C-0x000000018D318EE4
		public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x02622939 */)
			where TControl : InputControl;
		public static bool Matches(string expected, InputControl control); // 0x000000018D31811C-0x000000018D318230
		internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false /* Metadata: 0x0262293A */); // 0x000000018D317CD4-0x000000018D317F88
		public static bool MatchesPrefix(string expected, InputControl control); // 0x000000018D317F88-0x000000018D3180AC
		private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false /* Metadata: 0x0262293B */); // 0x000000018D3180AC-0x000000018D31811C
		private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl;
		private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0 /* Metadata: 0x0262293C */); // 0x00000001852687D0-0x0000000185268A30
		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath); // 0x0000000186A24FB0-0x0000000186A25030
		[IteratorStateMachine(typeof(_Parse_d__34))]
		public static IEnumerable<ParsedPathComponent> Parse(string path); // 0x000000018D318230-0x000000018D3182A0
	
		// Extension methods
		internal static string CleanSlashes(this string pathComponent); // 0x000000018D317704-0x000000018D31772C
	}

	public abstract class InputProcessor // TypeDefIndex: 72216
	{
		// Fields
		internal static TypeTable s_Processors; // 0x00
	
		// Properties
		public virtual CachingPolicy cachingPolicy { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Nested types
		public enum CachingPolicy // TypeDefIndex: 72215
		{
			CacheResult = 0,
			EvaluateOnEveryRead = 1
		}
	
		// Constructors
		protected InputProcessor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract object ProcessAsObject(object value, InputControl control);
		public abstract unsafe void Process(void* buffer, int bufferSize, InputControl control);
		internal static System.Type GetValueTypeFromType(System.Type processorType); // 0x000000018D31CD24-0x000000018D31CDF8
	}

	public abstract class InputProcessor<TValue> : InputProcessor // TypeDefIndex: 72217
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
	public class Gamepad : UnityEngine.InputSystem.InputDevice, IDualMotorRumble // TypeDefIndex: 72218
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
		public ButtonControl buttonWest { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public ButtonControl buttonNorth { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public ButtonControl buttonSouth { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public ButtonControl buttonEast { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public ButtonControl leftStickButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		public ButtonControl rightStickButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		public ButtonControl startButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		public ButtonControl selectButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		public DpadControl dpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		public ButtonControl leftShoulder { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		public ButtonControl rightShoulder { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		public StickControl leftStick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		public StickControl rightStick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		public ButtonControl leftTrigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		public ButtonControl rightTrigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		public ButtonControl aButton { get; } // 0x000000018723BE20-0x000000018723BE30 
		public ButtonControl bButton { get; } // 0x000000018723BDE0-0x000000018723BDF0 
		public ButtonControl xButton { get; } // 0x000000018723C0A0-0x000000018723C0B0 
		public ButtonControl yButton { get; } // 0x000000018723C220-0x000000018723C230 
		public ButtonControl triangleButton { get; } // 0x000000018723C220-0x000000018723C230 
		public ButtonControl squareButton { get; } // 0x000000018723C0A0-0x000000018723C0B0 
		public ButtonControl circleButton { get; } // 0x000000018723BDE0-0x000000018723BDF0 
		public ButtonControl crossButton { get; } // 0x000000018723BE20-0x000000018723BE30 
		public ButtonControl this[GamepadButton button] { get => default; } // 0x000000018D3153BC-0x000000018D3155DC 
		public static Gamepad current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D31564C-0x000000018D315684 0x000000018D315684-0x000000018D3156D4
		public static new ReadOnlyArray<Gamepad> all { get; } // 0x000000018D3155DC-0x000000018D31564C 
	
		// Constructors
		public Gamepad(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D314ED0-0x000000018D315234
		public override void MakeCurrent(); // 0x000000018D315234-0x000000018D31523C
		protected override void OnAdded(); // 0x000000018D31523C-0x000000018D3152AC
		protected override void OnRemoved(); // 0x000000018D3152AC-0x000000018D315358
		public virtual void PauseHaptics(); // 0x000000018D315358-0x000000018D31536C
		public virtual void ResumeHaptics(); // 0x000000018D315380-0x000000018D315394
		public virtual void ResetHaptics(); // 0x000000018D31536C-0x000000018D315380
		public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018D315394-0x000000018D3153BC
	}

	public class InputDevice : InputControl // TypeDefIndex: 72221
	{
		// Fields
		public const int InvalidDeviceId = 0; // Metadata: 0x02622950
		internal const int kLocalParticipantId = 0; // Metadata: 0x02622951
		internal const int kInvalidDeviceIndex = -1; // Metadata: 0x02622952
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
		internal const int kControlIndexBits = 10; // Metadata: 0x02622953
		internal const int kStateOffsetBits = 13; // Metadata: 0x02622954
		internal const int kStateSizeBits = 9; // Metadata: 0x02622955
	
		// Properties
		public InputDeviceDescription description { get; } // 0x0000000187259DB0-0x0000000187259DF0 
		public bool enabled { get; } // 0x00000001853ACCC0-0x00000001853ACD60 
		public bool canRunInBackground { get; } // 0x00000001878357D0-0x00000001878357D8 
		internal bool canDeviceRunInBackground { get; } // 0x0000000186B01600-0x0000000186B016D0 
		public bool added { get; } // 0x000000018526BE70-0x000000018526BE80 
		public bool remote { get; } // 0x000000018D31BDD8-0x000000018D31BDE4 
		public bool native { get; } // 0x000000018717D4A0-0x000000018717D4B0 
		public bool updateBeforeRender { get; } // 0x00000001863138B0-0x00000001863138C0 
		public int deviceId { get; } // 0x00000001872406B0-0x00000001872406C0 
		public double lastUpdateTime { get; } // 0x000000018D31BD90-0x000000018D31BDD8 
		public bool wasUpdatedThisFrame { get; } // 0x0000000186B0C3A0-0x0000000186B0C3F0 
		public ReadOnlyArray<InputControl> allControls { get; } // 0x00000001868E6560-0x00000001868E6590 
		public override System.Type valueType { get; } // 0x000000018D31BE30-0x000000018D31BE80 
		public override int valueSizeInBytes { get; } // 0x000000018D31BDE4-0x000000018D31BE30 
		[Obsolete("Use \'InputSystem.devices\' instead. (UnityUpgradable) -> InputSystem.devices", false)]
		public static ReadOnlyArray<InputDevice> all { get; } // 0x000000018D31BD40-0x000000018D31BD90 
		internal bool disabledInFrontend { get; set; } // 0x000000018526BED0-0x000000018526BEE0 0x000000018D31BE80-0x000000018D31BEA0
		internal bool disabledInRuntime { get; set; } // 0x000000018526BEC0-0x000000018526BED0 0x000000018526BF90-0x000000018526BFC0
		internal bool disabledWhileInBackground { get; set; } // 0x000000018526C3A0-0x000000018526C3B0 0x000000018526C180-0x000000018526C1B0
		internal bool hasControlsWithDefaultState { get; set; } // 0x0000000187224D30-0x0000000187224D40 0x00000001871C7560-0x00000001871C7580
		internal bool hasDontResetControls { get; set; } // 0x000000018526BEA0-0x000000018526BEC0 0x0000000186EBF3B0-0x0000000186EBF3D0
		internal bool hasStateCallbacks { get; set; } // 0x00000001853AE710-0x00000001853AE720 0x000000018D31BEA0-0x000000018D31BEC0
		internal bool hasEventMerger { get; set; } // 0x00000001853ACC40-0x00000001853ACC50 0x0000000186313310-0x0000000186313330
		internal bool hasEventPreProcessor { get; set; } // 0x00000001863C24C0-0x00000001863C24D0 0x0000000186313330-0x0000000186313350
	
		// Nested types
		[Serializable]
		[Flags]
		internal enum DeviceFlags // TypeDefIndex: 72219
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
	
		internal struct ControlBitRangeNode // TypeDefIndex: 72220
		{
			// Fields
			public ushort endBitOffset; // 0x00
			public short leftChildIndex; // 0x02
			public ushort controlStartIndex; // 0x04
			public byte controlCount; // 0x06
	
			// Constructors
			public ControlBitRangeNode(ushort endOffset); // 0x0000000187259E30-0x0000000187259E40
		}
	
		// Constructors
		public InputDevice(); // 0x000000018D31BD14-0x000000018D31BD40
	
		// Methods
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize); // 0x000000018D31B518-0x000000018D31B564
		public override unsafe object ReadValueFromStateAsObject(void* statePtr); // 0x000000018D31B564-0x000000018D31B64C
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize); // 0x000000018D31B64C-0x000000018D31B844
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr); // 0x000000018D31ADFC-0x000000018D31AF34
		internal void NotifyConfigurationChanged(); // 0x000000018D31B494-0x000000018D31B508
		public virtual void MakeCurrent(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAdded(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRemoved(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnConfigurationChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public long ExecuteCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
		protected virtual unsafe long ExecuteCommand(InputDeviceCommand* commandPtr); // 0x0000000186608200-0x00000001866082A0
		internal bool QueryEnabledStateFromRuntime(); // 0x00000001853ACD60-0x00000001853ACDF0
		internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits); // 0x0000000187259DA0-0x0000000187259DB0
		internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize); // 0x0000000187259D80-0x0000000187259DA0
		internal void AddDeviceUsage(InternedString usage); // 0x000000018D31ACF8-0x000000018D31ADA0
		internal void RemoveDeviceUsage(InternedString usage); // 0x000000018D31B844-0x000000018D31B918
		internal void ClearDeviceUsages(); // 0x000000018D31ADA0-0x000000018D31ADFC
		internal bool RequestSync(); // 0x000000018526ACD0-0x000000018526AEA0
		internal bool RequestReset(); // 0x000000018D31B918-0x000000018D31B994
		internal bool ExecuteEnableCommand(); // 0x000000018526AEA0-0x000000018526AF30
		internal bool ExecuteDisableCommand(); // 0x000000018526B640-0x000000018526B6C0
		internal void NotifyAdded(); // 0x000000018783BE40-0x000000018783BE50
		internal void NotifyRemoved(); // 0x000000018D31B508-0x000000018D31B518
		internal static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = default, bool noPrecompiledLayouts = false /* Metadata: 0x0262294F */)
			where TDevice : InputDevice;
		internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice); // 0x00000001860FC3F0-0x00000001860FC500
		private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset); // 0x000000018D31B994-0x000000018D31BD14
		private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output); // 0x000000018D31AF34-0x000000018D31B250
		private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<string> output); // 0x000000018D31B250-0x000000018D31B3BC
		internal string DumpControlTree(); // 0x000000018D31B3BC-0x000000018D31B494
		private unsafe void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset); // 0x00000001860FC500-0x00000001860FC9D0
		private static unsafe bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits); // 0x00000001860FC9D0-0x00000001860FCA00
	}

	public enum InputDeviceChange // TypeDefIndex: 72222
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
	public class Joystick : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 72223
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
		public ButtonControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public StickControl stick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public AxisControl twist { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public Vector2Control hatswitch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public static Joystick current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D3235B4-0x000000018D3235EC 0x000000018D3235EC-0x000000018D32363C
		public static new ReadOnlyArray<Joystick> all { get; } // 0x000000018D323544-0x000000018D3235B4 
	
		// Constructors
		public Joystick(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3232D8-0x000000018D3233FC
		public override void MakeCurrent(); // 0x000000018D3233FC-0x000000018D323404
		protected override void OnAdded(); // 0x000000018D323404-0x000000018D323474
		protected override void OnRemoved(); // 0x000000018D323474-0x000000018D323544
	}

	public enum Key // TypeDefIndex: 72224
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

	internal static class KeyEx // TypeDefIndex: 72225
	{
		// Fields
		internal const UnityEngine.InputSystem.Key IMESelected = UnityEngine.InputSystem.Key.IMESelected; // Metadata: 0x02622A3A
		internal const UnityEngine.InputSystem.Key RemappedIMESelected = (UnityEngine.InputSystem.Key) 127; // Metadata: 0x02622A3C
	}

	[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
	public class Keyboard : UnityEngine.InputSystem.InputDevice, ITextInputReceiver, IEventPreProcessor // TypeDefIndex: 72226
	{
		// Fields
		public const int KeyCount = 110; // Metadata: 0x02622A3E
		internal const int ExtendedKeyCount = 123; // Metadata: 0x02622A40
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
		public string keyboardLayout { get; protected set; } // 0x000000018D3250E4-0x000000018D325104 0x0000000188DC4458-0x0000000188DC446C
		public AnyKeyControl anyKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public KeyControl spaceKey { get; } // 0x000000018D325454-0x000000018D325464 
		public KeyControl enterKey { get; } // 0x000000018D324EB4-0x000000018D324EC4 
		public KeyControl tabKey { get; } // 0x000000018D325474-0x000000018D325484 
		public KeyControl backquoteKey { get; } // 0x000000018D324D1C-0x000000018D324D2C 
		public KeyControl quoteKey { get; } // 0x000000018D325394-0x000000018D3253A4 
		public KeyControl semicolonKey { get; } // 0x000000018D325434-0x000000018D325444 
		public KeyControl commaKey { get; } // 0x000000018D324D6C-0x000000018D324D7C 
		public KeyControl periodKey { get; } // 0x000000018D325364-0x000000018D325374 
		public KeyControl slashKey { get; } // 0x000000018D325444-0x000000018D325454 
		public KeyControl backslashKey { get; } // 0x000000018D324D2C-0x000000018D324D3C 
		public KeyControl leftBracketKey { get; } // 0x000000018D325144-0x000000018D325154 
		public KeyControl rightBracketKey { get; } // 0x000000018D3253E4-0x000000018D3253F4 
		public KeyControl minusKey { get; } // 0x000000018D325184-0x000000018D325194 
		public KeyControl equalsKey { get; } // 0x000000018D324EC4-0x000000018D324ED4 
		public KeyControl aKey { get; } // 0x000000018D324CA4-0x000000018D324CB4 
		public KeyControl bKey { get; } // 0x000000018D324D0C-0x000000018D324D1C 
		public KeyControl cKey { get; } // 0x000000018D324D4C-0x000000018D324D5C 
		public KeyControl dKey { get; } // 0x000000018D324DC4-0x000000018D324DD4 
		public KeyControl eKey { get; } // 0x000000018D324E94-0x000000018D324EA4 
		public KeyControl fKey { get; } // 0x000000018D325064-0x000000018D325074 
		public KeyControl gKey { get; } // 0x000000018D325074-0x000000018D325084 
		public KeyControl hKey { get; } // 0x000000018D325084-0x000000018D325094 
		public KeyControl iKey { get; } // 0x000000018D3250A4-0x000000018D3250B4 
		public KeyControl jKey { get; } // 0x000000018D3250C4-0x000000018D3250D4 
		public KeyControl kKey { get; } // 0x000000018D3250D4-0x000000018D3250E4 
		public KeyControl lKey { get; } // 0x000000018D325104-0x000000018D325114 
		public KeyControl mKey { get; } // 0x000000018D325174-0x000000018D325184 
		public KeyControl nKey { get; } // 0x000000018D325194-0x000000018D3251A4 
		public KeyControl oKey { get; } // 0x000000018D3252C4-0x000000018D3252D4 
		public KeyControl pKey { get; } // 0x000000018D325324-0x000000018D325334 
		public KeyControl qKey { get; } // 0x000000018D325384-0x000000018D325394 
		public KeyControl rKey { get; } // 0x000000018D3253A4-0x000000018D3253B4 
		public KeyControl sKey { get; } // 0x000000018D325414-0x000000018D325424 
		public KeyControl tKey { get; } // 0x000000018D325464-0x000000018D325474 
		public KeyControl uKey { get; } // 0x000000018D325484-0x000000018D325494 
		public KeyControl vKey { get; } // 0x000000018D3254A4-0x000000018D3254B4 
		public KeyControl wKey { get; } // 0x000000018D3254B4-0x000000018D3254C4 
		public KeyControl xKey { get; } // 0x000000018D3254C4-0x000000018D3254D4 
		public KeyControl yKey { get; } // 0x000000018D3254D4-0x000000018D3254E4 
		public KeyControl zKey { get; } // 0x000000018D3254E4-0x000000018D3254F4 
		public KeyControl digit1Key { get; } // 0x000000018D324DF4-0x000000018D324E04 
		public KeyControl digit2Key { get; } // 0x000000018D324E04-0x000000018D324E14 
		public KeyControl digit3Key { get; } // 0x000000018D324E14-0x000000018D324E24 
		public KeyControl digit4Key { get; } // 0x000000018D324E24-0x000000018D324E34 
		public KeyControl digit5Key { get; } // 0x000000018D324E34-0x000000018D324E44 
		public KeyControl digit6Key { get; } // 0x000000018D324E44-0x000000018D324E54 
		public KeyControl digit7Key { get; } // 0x000000018D324E54-0x000000018D324E64 
		public KeyControl digit8Key { get; } // 0x000000018D324E64-0x000000018D324E74 
		public KeyControl digit9Key { get; } // 0x000000018D324E74-0x000000018D324E84 
		public KeyControl digit0Key { get; } // 0x000000018D324DE4-0x000000018D324DF4 
		public KeyControl leftShiftKey { get; } // 0x000000018D325164-0x000000018D325174 
		public KeyControl rightShiftKey { get; } // 0x000000018D325404-0x000000018D325414 
		public KeyControl leftAltKey { get; } // 0x000000018D325114-0x000000018D325124 
		public KeyControl rightAltKey { get; } // 0x000000018D3253B4-0x000000018D3253C4 
		public KeyControl leftCtrlKey { get; } // 0x000000018D325154-0x000000018D325164 
		public KeyControl rightCtrlKey { get; } // 0x000000018D3253F4-0x000000018D325404 
		public KeyControl leftMetaKey { get; } // 0x000000018D325124-0x000000018D325134 
		public KeyControl rightMetaKey { get; } // 0x000000018D3253C4-0x000000018D3253D4 
		public KeyControl leftWindowsKey { get; } // 0x000000018D325124-0x000000018D325134 
		public KeyControl rightWindowsKey { get; } // 0x000000018D3253C4-0x000000018D3253D4 
		public KeyControl leftAppleKey { get; } // 0x000000018D325124-0x000000018D325134 
		public KeyControl rightAppleKey { get; } // 0x000000018D3253C4-0x000000018D3253D4 
		public KeyControl leftCommandKey { get; } // 0x000000018D325124-0x000000018D325134 
		public KeyControl rightCommandKey { get; } // 0x000000018D3253C4-0x000000018D3253D4 
		public KeyControl contextMenuKey { get; } // 0x000000018D324D7C-0x000000018D324D8C 
		public KeyControl escapeKey { get; } // 0x000000018D324ED4-0x000000018D324EE4 
		public KeyControl leftArrowKey { get; } // 0x000000018D325134-0x000000018D325144 
		public KeyControl rightArrowKey { get; } // 0x000000018D3253D4-0x000000018D3253E4 
		public KeyControl upArrowKey { get; } // 0x000000018D325494-0x000000018D3254A4 
		public KeyControl downArrowKey { get; } // 0x000000018D324E84-0x000000018D324E94 
		public KeyControl backspaceKey { get; } // 0x000000018D324D3C-0x000000018D324D4C 
		public KeyControl pageDownKey { get; } // 0x000000018D325334-0x000000018D325344 
		public KeyControl pageUpKey { get; } // 0x000000018D325344-0x000000018D325354 
		public KeyControl homeKey { get; } // 0x000000018D325094-0x000000018D3250A4 
		public KeyControl endKey { get; } // 0x000000018D324EA4-0x000000018D324EB4 
		public KeyControl insertKey { get; } // 0x000000018D3250B4-0x000000018D3250C4 
		public KeyControl deleteKey { get; } // 0x000000018D324DD4-0x000000018D324DE4 
		public KeyControl capsLockKey { get; } // 0x000000018D324D5C-0x000000018D324D6C 
		public KeyControl scrollLockKey { get; } // 0x000000018D325424-0x000000018D325434 
		public KeyControl numLockKey { get; } // 0x000000018D3251A4-0x000000018D3251B4 
		public KeyControl printScreenKey { get; } // 0x000000018D325374-0x000000018D325384 
		public KeyControl pauseKey { get; } // 0x000000018D325354-0x000000018D325364 
		public KeyControl numpadEnterKey { get; } // 0x000000018D325264-0x000000018D325274 
		public KeyControl numpadDivideKey { get; } // 0x000000018D325254-0x000000018D325264 
		public KeyControl numpadMultiplyKey { get; } // 0x000000018D325294-0x000000018D3252A4 
		public KeyControl numpadMinusKey { get; } // 0x000000018D325284-0x000000018D325294 
		public KeyControl numpadPlusKey { get; } // 0x000000018D3252B4-0x000000018D3252C4 
		public KeyControl numpadPeriodKey { get; } // 0x000000018D3252A4-0x000000018D3252B4 
		public KeyControl numpadEqualsKey { get; } // 0x000000018D325274-0x000000018D325284 
		public KeyControl numpad0Key { get; } // 0x000000018D3251B4-0x000000018D3251C4 
		public KeyControl numpad1Key { get; } // 0x000000018D3251C4-0x000000018D3251D4 
		public KeyControl numpad2Key { get; } // 0x000000018D3251D4-0x000000018D3251E4 
		public KeyControl numpad3Key { get; } // 0x000000018D3251E4-0x000000018D3251F4 
		public KeyControl numpad4Key { get; } // 0x000000018D3251F4-0x000000018D325204 
		public KeyControl numpad5Key { get; } // 0x000000018D325204-0x000000018D325214 
		public KeyControl numpad6Key { get; } // 0x000000018D325214-0x000000018D325224 
		public KeyControl numpad7Key { get; } // 0x000000018D325224-0x000000018D325234 
		public KeyControl numpad8Key { get; } // 0x000000018D325234-0x000000018D325244 
		public KeyControl numpad9Key { get; } // 0x000000018D325244-0x000000018D325254 
		public KeyControl f1Key { get; } // 0x000000018D324F84-0x000000018D324F94 
		public KeyControl f2Key { get; } // 0x000000018D324FE4-0x000000018D324FF4 
		public KeyControl f3Key { get; } // 0x000000018D324FF4-0x000000018D325004 
		public KeyControl f4Key { get; } // 0x000000018D325004-0x000000018D325014 
		public KeyControl f5Key { get; } // 0x000000018D325014-0x000000018D325024 
		public KeyControl f6Key { get; } // 0x000000018D325024-0x000000018D325034 
		public KeyControl f7Key { get; } // 0x000000018D325034-0x000000018D325044 
		public KeyControl f8Key { get; } // 0x000000018D325044-0x000000018D325054 
		public KeyControl f9Key { get; } // 0x000000018D325054-0x000000018D325064 
		public KeyControl f10Key { get; } // 0x000000018D324EE4-0x000000018D324EF4 
		public KeyControl f11Key { get; } // 0x000000018D324EF4-0x000000018D324F04 
		public KeyControl f12Key { get; } // 0x000000018D324F04-0x000000018D324F14 
		public KeyControl oem1Key { get; } // 0x000000018D3252D4-0x000000018D3252E4 
		public KeyControl oem2Key { get; } // 0x000000018D3252E4-0x000000018D3252F4 
		public KeyControl oem3Key { get; } // 0x000000018D3252F4-0x000000018D325304 
		public KeyControl oem4Key { get; } // 0x000000018D325304-0x000000018D325314 
		public KeyControl oem5Key { get; } // 0x000000018D325314-0x000000018D325324 
		public KeyControl f13Key { get; } // 0x000000018D324F14-0x000000018D324F24 
		public KeyControl f14Key { get; } // 0x000000018D324F24-0x000000018D324F34 
		public KeyControl f15Key { get; } // 0x000000018D324F34-0x000000018D324F44 
		public KeyControl f16Key { get; } // 0x000000018D324F44-0x000000018D324F54 
		public KeyControl f17Key { get; } // 0x000000018D324F54-0x000000018D324F64 
		public KeyControl f18Key { get; } // 0x000000018D324F64-0x000000018D324F74 
		public KeyControl f19Key { get; } // 0x000000018D324F74-0x000000018D324F84 
		public KeyControl f20Key { get; } // 0x000000018D324F94-0x000000018D324FA4 
		public KeyControl f21Key { get; } // 0x000000018D324FA4-0x000000018D324FB4 
		public KeyControl f22Key { get; } // 0x000000018D324FB4-0x000000018D324FC4 
		public KeyControl f23Key { get; } // 0x000000018D324FC4-0x000000018D324FD4 
		public KeyControl f24Key { get; } // 0x000000018D324FD4-0x000000018D324FE4 
		public ButtonControl shiftKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public ButtonControl ctrlKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public ButtonControl altKey { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public ButtonControl imeSelected { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		public KeyControl this[UnityEngine.InputSystem.Key key] { get => default; } // 0x00000001851D5BA0-0x00000001851D5BF0 
		public ReadOnlyArray<KeyControl> allKeys { get; } // 0x000000018D324CB4-0x000000018D324D0C 
		public static Keyboard current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D324D8C-0x000000018D324DC4 0x000000018D32558C-0x000000018D3255DC
		protected KeyControl[] keys { get; set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
	
		// Events
		public event Action<char> onTextInput {
			add; // 0x000000018D324BC0-0x000000018D324CA4
			remove; // 0x000000018D325540-0x000000018D32558C
		}
		public event Action<IMECompositionString> onIMECompositionChange {
			add; // 0x000000018D324ADC-0x000000018D324BC0
			remove; // 0x000000018D3254F4-0x000000018D325540
		}
	
		// Constructors
		public Keyboard(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public void SetIMEEnabled(bool enabled); // 0x000000018D324A54-0x000000018D324ADC
		public void SetIMECursorPosition(Vector2 position); // 0x000000018D3249E0-0x000000018D324A54
		public override void MakeCurrent(); // 0x00000001868708F0-0x0000000186870950
		protected override void OnRemoved(); // 0x000000018D3248B8-0x000000018D3248E0
		protected override void FinishSetup(); // 0x000000018D323708-0x000000018D3248B8
		protected override void RefreshConfiguration(); // 0x000000018D3248E0-0x000000018D3249E0
		public void OnTextInput(char character); // 0x0000000186354D60-0x0000000186354D90
		public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName); // 0x000000018D32363C-0x000000018D323708
		public void OnIMECompositionChanged(IMECompositionString compositionString); // 0x0000000186DD84E0-0x0000000186DD8530
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr); // 0x0000000186252470-0x00000001862524E0
	}

	[InputControlLayout(stateType = typeof(UnityEngine.InputSystem.LowLevel.MouseState), isGenericTypeOfDevice = true)]
	public class Mouse : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver // TypeDefIndex: 72227
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
		public DeltaControl scroll { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		public ButtonControl leftButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		public ButtonControl middleButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		public ButtonControl rightButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		public ButtonControl backButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		public ButtonControl forwardButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		public IntegerControl clickCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		public static new Mouse current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D32593C-0x000000018D325974 0x000000018D325974-0x000000018D3259C4
	
		// Constructors
		public Mouse(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x00000001861B0A50-0x00000001861B0A70
		protected override void OnAdded(); // 0x000000018717D430-0x000000018717D4A0
		protected override void OnRemoved(); // 0x000000018D325838-0x000000018D325864
		public void WarpCursorPosition(Vector2 position); // 0x000000018D3258C8-0x000000018D32593C
		protected override void FinishSetup(); // 0x000000018D3255DC-0x000000018D3257D4
		protected new void OnNextUpdate(); // 0x000000018D3257D4-0x000000018D325838
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D325864-0x000000018D3258B8
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018D3258B8-0x000000018D3258C0
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018D3258C0-0x000000018D3258C8
	}

	public enum PenButton // TypeDefIndex: 72228
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
	public class Pen : UnityEngine.InputSystem.Pointer // TypeDefIndex: 72229
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
		public ButtonControl tip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		public ButtonControl eraser { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		public ButtonControl firstBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		public ButtonControl secondBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		public ButtonControl thirdBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		public ButtonControl fourthBarrelButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		public ButtonControl inRange { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		public Vector2Control tilt { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		public AxisControl twist { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		public static new Pen current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018D325DDC-0x000000018D325E14 0x000000018D325E14-0x000000018D325E64
		public ButtonControl this[PenButton button] { get => default; } // 0x000000018D325CA4-0x000000018D325DDC 
	
		// Constructors
		public Pen(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D325C34-0x000000018D325C50
		protected override void OnRemoved(); // 0x000000018D325C50-0x000000018D325CA4
		protected override void FinishSetup(); // 0x000000018D3259C4-0x000000018D325C34
	}

	[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
	public class Pointer : UnityEngine.InputSystem.InputDevice, IInputStateCallbackReceiver // TypeDefIndex: 72230
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
		public Vector2Control position { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public DeltaControl delta { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public Vector2Control radius { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public AxisControl pressure { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public ButtonControl press { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		public IntegerControl displayIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		public static Pointer current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018D3260E4-0x000000018D32611C 0x000000018D32611C-0x000000018D32616C
	
		// Constructors
		public Pointer(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x00000001861B0A70-0x00000001861B0B20
		protected override void OnRemoved(); // 0x000000018D326058-0x000000018D326080
		protected override void FinishSetup(); // 0x000000018D325E64-0x000000018D326000
		protected void OnNextUpdate(); // 0x000000018D326000-0x000000018D326058
		protected void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D326080-0x000000018D3260D4
		void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018D3260D4-0x000000018D3260DC
		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018D3260DC-0x000000018D3260E4
		bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001843FFFF0-0x0000000184400000
	}

	internal class FastKeyboard : UnityEngine.InputSystem.Keyboard // TypeDefIndex: 72231
	{
		// Fields
		public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard"; // Metadata: 0x02622A4D
	
		// Constructors
		public FastKeyboard(); // 0x0000000186376670-0x0000000186379A80
	
		// Methods
		private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent); // 0x0000000186671130-0x0000000186671320
		private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent); // 0x0000000186E5F990-0x0000000186E5FB80
		private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent); // 0x0000000186E73310-0x0000000186E734F0
		private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent); // 0x0000000186E5F590-0x0000000186E5F790
		private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent); // 0x0000000186E72F50-0x0000000186E73130
		private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76D30-0x0000000186E76F10
		private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74030-0x0000000186E74210
		private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent); // 0x0000000186E736D0-0x0000000186E738B0
		private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76790-0x0000000186E76970
		private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent); // 0x0000000186E743F0-0x0000000186E745D0
		private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent); // 0x0000000186E734F0-0x0000000186E736D0
		private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76B50-0x0000000186E76D30
		private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74F30-0x0000000186E75110
		private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent); // 0x0000000186E73A90-0x0000000186E73C70
		private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74B70-0x0000000186E74D50
		private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76010-0x0000000186E761F0
		private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000186E72B90-0x0000000186E72D70
		private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000186E763D0-0x0000000186E765B0
		private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000186E75110-0x0000000186E752F0
		private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent); // 0x0000000186E73C70-0x0000000186E73E50
		private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent); // 0x0000000186E770F0-0x0000000186E772D0
		private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76F10-0x0000000186E770F0
		private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent); // 0x0000000186E76970-0x0000000186E76B50
		private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent); // 0x0000000186E765B0-0x0000000186E76790
		private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent); // 0x0000000186E761F0-0x0000000186E763D0
		private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent); // 0x0000000186E75E30-0x0000000186E76010
		private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent); // 0x0000000186E75C50-0x0000000186E75E30
		private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent); // 0x0000000186E75A70-0x0000000186E75C50
		private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent); // 0x0000000186E75890-0x0000000186E75A70
		private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent); // 0x0000000186E756B0-0x0000000186E75890
		private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent); // 0x0000000186E754D0-0x0000000186E756B0
		private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent); // 0x0000000186E752F0-0x0000000186E754D0
		private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74D50-0x0000000186E74F30
		private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74990-0x0000000186E74B70
		private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent); // 0x0000000186E747B0-0x0000000186E74990
		private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent); // 0x0000000186E745D0-0x0000000186E747B0
		private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent); // 0x0000000186E74210-0x0000000186E743F0
		private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent); // 0x0000000186E73E50-0x0000000186E74030
		private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent); // 0x0000000186E738B0-0x0000000186E73A90
		private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent); // 0x0000000186E73130-0x0000000186E73310
		private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent); // 0x0000000186E72D70-0x0000000186E72F50
		private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent); // 0x0000000186E729B0-0x0000000186E72B90
		private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent); // 0x0000000186E727D0-0x0000000186E729B0
		private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent); // 0x0000000186E725F0-0x0000000186E727D0
		private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent); // 0x0000000186E72410-0x0000000186E725F0
		private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent); // 0x0000000186E72230-0x0000000186E72410
		private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent); // 0x0000000186EA5EE0-0x0000000186EA60C0
		private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent); // 0x0000000186EA5D00-0x0000000186EA5EE0
		private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent); // 0x0000000186EA5B20-0x0000000186EA5D00
		private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent); // 0x0000000186368990-0x0000000186368B70
		private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent); // 0x0000000186368B70-0x0000000186368D50
		private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent); // 0x0000000186368D50-0x0000000186368F30
		private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent); // 0x0000000186368F30-0x0000000186369110
		private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent); // 0x0000000186369110-0x00000001863692F0
		private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent); // 0x00000001863692F0-0x00000001863694D0
		private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent); // 0x00000001863694D0-0x00000001863696B0
		private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent); // 0x00000001863696B0-0x00000001863698B0
		private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent); // 0x00000001863698B0-0x0000000186369AB0
		private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent); // 0x000000018636E8A0-0x000000018636EAC0
		private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent); // 0x0000000186369AB0-0x0000000186369CB0
		private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent); // 0x0000000186369CB0-0x0000000186369EB0
		private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent); // 0x000000018636EAC0-0x000000018636ECE0
		private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent); // 0x0000000186369EB0-0x000000018636A0B0
		private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent); // 0x000000018636A0B0-0x000000018636A2B0
		private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent); // 0x000000018636ECE0-0x000000018636EF00
		private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent); // 0x000000018636A2B0-0x000000018636A4C0
		private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent); // 0x000000018636A4C0-0x000000018636A6D0
		private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent); // 0x000000018636A6D0-0x000000018636A8F0
		private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent); // 0x000000018636A910-0x000000018636AAF0
		private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent); // 0x000000018636AAF0-0x000000018636ACD0
		private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent); // 0x000000018636ACD0-0x000000018636AEB0
		private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent); // 0x000000018636AEB0-0x000000018636B090
		private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent); // 0x000000018636B090-0x000000018636B270
		private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent); // 0x000000018636B270-0x000000018636B450
		private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent); // 0x000000018636B450-0x000000018636B630
		private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent); // 0x000000018636B630-0x000000018636B810
		private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent); // 0x000000018636B810-0x000000018636B9F0
		private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent); // 0x000000018636B9F0-0x000000018636BBD0
		private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent); // 0x000000018636BBD0-0x000000018636BDB0
		private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent); // 0x000000018636BDB0-0x000000018636BF90
		private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent); // 0x000000018636BF90-0x000000018636C170
		private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent); // 0x000000018636C170-0x000000018636C350
		private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent); // 0x000000018636C350-0x000000018636C530
		private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent); // 0x000000018636C530-0x000000018636C710
		private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent); // 0x000000018636C710-0x000000018636C8F0
		private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent); // 0x000000018636C8F0-0x000000018636CAD0
		private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent); // 0x000000018636CAD0-0x000000018636CCB0
		private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent); // 0x000000018636CCB0-0x000000018636CE90
		private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent); // 0x000000018636CE90-0x000000018636D070
		private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent); // 0x000000018636D070-0x000000018636D250
		private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent); // 0x000000018636D250-0x000000018636D430
		private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent); // 0x000000018636D430-0x000000018636D610
		private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent); // 0x000000018636D610-0x000000018636D7F0
		private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent); // 0x000000018636D7F0-0x000000018636D9D0
		private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent); // 0x000000018636D9D0-0x000000018636DBB0
		private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent); // 0x000000018636DBB0-0x000000018636DD90
		private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent); // 0x000000018636DD90-0x000000018636DF70
		private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent); // 0x000000018636DF70-0x000000018636E150
		private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent); // 0x000000018636E150-0x000000018636E330
		private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent); // 0x000000018636E330-0x000000018636E510
		private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent); // 0x000000018636E510-0x000000018636E6F0
		private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent); // 0x0000000186375380-0x0000000186375710
		private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent); // 0x00000001863751A0-0x0000000186375380
		private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent); // 0x0000000186374FC0-0x00000001863751A0
		private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent); // 0x0000000186374DE0-0x0000000186374FC0
		private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent); // 0x0000000186374C00-0x0000000186374DE0
		private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent); // 0x0000000186374A20-0x0000000186374C00
		private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent); // 0x0000000186374840-0x0000000186374A20
		private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent); // 0x0000000186374660-0x0000000186374840
		private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent); // 0x0000000186374480-0x0000000186374660
		private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent); // 0x00000001863742A0-0x0000000186374480
		private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent); // 0x00000001863740C0-0x00000001863742A0
		private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent); // 0x0000000186373EE0-0x00000001863740C0
		private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent); // 0x0000000186373D00-0x0000000186373EE0
		private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent); // 0x0000000186373B20-0x0000000186373D00
		private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent); // 0x0000000186373940-0x0000000186373B20
		private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent); // 0x0000000186373760-0x0000000186373940
		private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent); // 0x0000000186373580-0x0000000186373760
		private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent); // 0x0000000186373360-0x0000000186373580
		private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent); // 0x0000000186373180-0x0000000186373360
		private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent); // 0x0000000186372FA0-0x0000000186373180
		private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent); // 0x0000000186372DC0-0x0000000186372FA0
		private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent); // 0x0000000186372BE0-0x0000000186372DC0
		private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent); // 0x0000000186372A00-0x0000000186372BE0
		private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent); // 0x0000000186372820-0x0000000186372A00
		private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent); // 0x0000000186372640-0x0000000186372820
		private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent); // 0x0000000186372460-0x0000000186372640
	}

	internal class FastMouse : UnityEngine.InputSystem.Mouse, IInputStateCallbackReceiver, IEventMerger // TypeDefIndex: 72232
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer"; // Metadata: 0x02622A7D
	
		// Constructors
		public FastMouse(); // 0x0000000186375820-0x0000000186376670
	
		// Methods
		private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent); // 0x00000001863722A0-0x0000000186372460
		private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent); // 0x0000000186372100-0x00000001863722A0
		private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent); // 0x0000000186371F70-0x0000000186372100
		private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent); // 0x0000000186371D80-0x0000000186371F70
		private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent); // 0x0000000186371B70-0x0000000186371D80
		private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent); // 0x0000000186371960-0x0000000186371B70
		private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent); // 0x0000000186371760-0x0000000186371960
		private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent); // 0x0000000186371570-0x0000000186371760
		private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent); // 0x0000000186371330-0x0000000186371550
		private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent); // 0x0000000186371160-0x0000000186371330
		private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent); // 0x0000000186370F90-0x0000000186371130
		private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent); // 0x000000018636EF00-0x000000018636F070
		private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018636F070-0x000000018636F1F0
		private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018636F1F0-0x000000018636F380
		private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018636F380-0x000000018636F530
		private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018636F530-0x000000018636F6E0
		private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018636F6E0-0x000000018636F890
		private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018636F890-0x000000018636FA50
		private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018636FA50-0x000000018636FC10
		private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018636FC10-0x000000018636FDC0
		private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent); // 0x000000018636FDC0-0x000000018636FF50
		private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent); // 0x000000018636FF50-0x00000001863700E0
		private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent); // 0x00000001863700E0-0x0000000186370290
		private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent); // 0x0000000186370290-0x0000000186370450
		private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent); // 0x0000000186370450-0x0000000186370610
		private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent); // 0x0000000186370610-0x00000001863707F0
		private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent); // 0x0000000186370810-0x00000001863709C0
		private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent); // 0x00000001863709C0-0x0000000186370B80
		private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent); // 0x0000000186370B80-0x0000000186370D10
		private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent); // 0x0000000186370D10-0x0000000186370F30
		protected new void OnNextUpdate(); // 0x0000000185E686E0-0x0000000185E68860
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x0000000185E68540-0x0000000185E686E0
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018783BA68-0x000000018783BA70
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018783BDAC-0x000000018783BDB4
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x00000001853AE5B0-0x00000001853AE6F0
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x0000000187835E18-0x0000000187835E2C
	}

	internal class FastTouchscreen : Touchscreen // TypeDefIndex: 72233
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer"; // Metadata: 0x02622AC6
	
		// Constructors
		public FastTouchscreen(); // 0x000000018D3436D8-0x000000018D348FD0
	
		// Methods
		private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent); // 0x000000018D3275C4-0x000000018D327748
		private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent); // 0x000000018D326DB0-0x000000018D326F4C
		private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D32616C-0x000000018D3262F8
		private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent); // 0x000000018D32741C-0x000000018D3275C4
		private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent); // 0x000000018D329E48-0x000000018D329FD4
		private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D327254-0x000000018D32741C
		private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D326C50-0x000000018D326DB0
		private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent); // 0x000000018D32A2BC-0x000000018D32A434
		private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent); // 0x000000018D32CB20-0x000000018D32CC98
		private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent); // 0x000000018D32F384-0x000000018D32F4FC
		private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent); // 0x000000018D331BE8-0x000000018D331D60
		private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent); // 0x000000018D334454-0x000000018D3345CC
		private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent); // 0x000000018D336CC0-0x000000018D336E38
		private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent); // 0x000000018D33952C-0x000000018D3396A4
		private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent); // 0x000000018D33BD98-0x000000018D33BF0C
		private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent); // 0x000000018D33E600-0x000000018D33E778
		private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent); // 0x000000018D340E6C-0x000000018D340FE4
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D329CB4-0x000000018D329E48
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent); // 0x000000018D328700-0x000000018D328898
		private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D327748-0x000000018D3278D4
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D328D6C-0x000000018D328EE0
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent); // 0x000000018D328EE0-0x000000018D32906C
		private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D32857C-0x000000018D328700
		private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D328BA0-0x000000018D328D6C
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D329958-0x000000018D329ACC
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32822C-0x000000018D3283A0
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D3283A0-0x000000018D32857C
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent); // 0x000000018D329ACC-0x000000018D329CB4
		private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D3297D4-0x000000018D329958
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D329354-0x000000018D3294EC
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D328898-0x000000018D328A1C
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D328A1C-0x000000018D328BA0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D327DAC-0x000000018D327F44
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D3278D4-0x000000018D327A74
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D327A74-0x000000018D327C14
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D327C14-0x000000018D327DAC
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D327F44-0x000000018D3280B8
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D3280B8-0x000000018D32822C
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32906C-0x000000018D3291E0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D3291E0-0x000000018D329354
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D3294EC-0x000000018D329660
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D329660-0x000000018D3297D4
		private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D326F4C-0x000000018D3270D0
		private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D3270D0-0x000000018D327254
		private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D3267D0-0x000000018D326968
		private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D3262F8-0x000000018D326498
		private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D326498-0x000000018D326638
		private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D326638-0x000000018D3267D0
		private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D326968-0x000000018D326ADC
		private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D326ADC-0x000000018D326C50
		private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D329FD4-0x000000018D32A148
		private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D32A148-0x000000018D32A2BC
		private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32C98C-0x000000018D32CB20
		private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent); // 0x000000018D32B3EC-0x000000018D32B584
		private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D32A434-0x000000018D32A5C0
		private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D32BA58-0x000000018D32BBCC
		private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D32BBCC-0x000000018D32BD58
		private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D32B268-0x000000018D32B3EC
		private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D32B88C-0x000000018D32BA58
		private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32C644-0x000000018D32C7B8
		private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32AF18-0x000000018D32B08C
		private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D32B08C-0x000000018D32B268
		private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D32C7B8-0x000000018D32C98C
		private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D32C4C0-0x000000018D32C644
		private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D32C040-0x000000018D32C1D8
		private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32B584-0x000000018D32B708
		private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D32B708-0x000000018D32B88C
		private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D32AA98-0x000000018D32AC30
		private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D32A5C0-0x000000018D32A760
		private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D32A760-0x000000018D32A900
		private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D32A900-0x000000018D32AA98
		private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D32AC30-0x000000018D32ADA4
		private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D32ADA4-0x000000018D32AF18
		private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32BD58-0x000000018D32BECC
		private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D32BECC-0x000000018D32C040
		private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32C1D8-0x000000018D32C34C
		private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D32C34C-0x000000018D32C4C0
		private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32F1F0-0x000000018D32F384
		private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent); // 0x000000018D32DC50-0x000000018D32DDE8
		private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D32CC98-0x000000018D32CE24
		private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D32E2BC-0x000000018D32E430
		private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D32E430-0x000000018D32E5BC
		private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D32DACC-0x000000018D32DC50
		private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D32E0F0-0x000000018D32E2BC
		private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32EEA8-0x000000018D32F01C
		private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32D77C-0x000000018D32D8F0
		private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D32D8F0-0x000000018D32DACC
		private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D32F01C-0x000000018D32F1F0
		private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D32ED24-0x000000018D32EEA8
		private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D32E8A4-0x000000018D32EA3C
		private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32DDE8-0x000000018D32DF6C
		private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D32DF6C-0x000000018D32E0F0
		private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D32D2FC-0x000000018D32D494
		private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D32CE24-0x000000018D32CFC4
		private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D32CFC4-0x000000018D32D164
		private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D32D164-0x000000018D32D2FC
		private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D32D494-0x000000018D32D608
		private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D32D608-0x000000018D32D77C
		private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32E5BC-0x000000018D32E730
		private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D32E730-0x000000018D32E8A4
		private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D32EA3C-0x000000018D32EBB0
		private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D32EBB0-0x000000018D32ED24
		private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D331A54-0x000000018D331BE8
		private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent); // 0x000000018D3304B4-0x000000018D33064C
		private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D32F4FC-0x000000018D32F688
		private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D330B20-0x000000018D330C94
		private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D330C94-0x000000018D330E20
		private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D330330-0x000000018D3304B4
		private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D330954-0x000000018D330B20
		private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33170C-0x000000018D331880
		private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D32FFE0-0x000000018D330154
		private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D330154-0x000000018D330330
		private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D331880-0x000000018D331A54
		private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D331588-0x000000018D33170C
		private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D331108-0x000000018D3312A0
		private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33064C-0x000000018D3307D0
		private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D3307D0-0x000000018D330954
		private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D32FB60-0x000000018D32FCF8
		private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D32F688-0x000000018D32F828
		private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D32F828-0x000000018D32F9C8
		private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D32F9C8-0x000000018D32FB60
		private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D32FCF8-0x000000018D32FE6C
		private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D32FE6C-0x000000018D32FFE0
		private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D330E20-0x000000018D330F94
		private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D330F94-0x000000018D331108
		private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D3312A0-0x000000018D331414
		private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D331414-0x000000018D331588
		private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D3342C0-0x000000018D334454
		private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent); // 0x000000018D332D18-0x000000018D332EB4
		private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D331D60-0x000000018D331EEC
		private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D333388-0x000000018D3334FC
		private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D3334FC-0x000000018D333688
		private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D332B94-0x000000018D332D18
		private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D3331BC-0x000000018D333388
		private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D333F78-0x000000018D3340EC
		private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D332844-0x000000018D3329B8
		private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D3329B8-0x000000018D332B94
		private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D3340EC-0x000000018D3342C0
		private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D333DF4-0x000000018D333F78
		private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D333970-0x000000018D333B0C
		private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D332EB4-0x000000018D333038
		private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D333038-0x000000018D3331BC
		private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D3323C4-0x000000018D33255C
		private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D331EEC-0x000000018D33208C
		private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D33208C-0x000000018D33222C
		private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D33222C-0x000000018D3323C4
		private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D33255C-0x000000018D3326D0
		private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D3326D0-0x000000018D332844
		private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D333688-0x000000018D3337FC
		private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D3337FC-0x000000018D333970
		private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D333B0C-0x000000018D333C80
		private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D333C80-0x000000018D333DF4
		private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D336B2C-0x000000018D336CC0
		private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent); // 0x000000018D335584-0x000000018D335720
		private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D3345CC-0x000000018D334758
		private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D335BF4-0x000000018D335D68
		private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D335D68-0x000000018D335EF4
		private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D335400-0x000000018D335584
		private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D335A28-0x000000018D335BF4
		private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D3367E4-0x000000018D336958
		private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D3350B0-0x000000018D335224
		private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D335224-0x000000018D335400
		private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D336958-0x000000018D336B2C
		private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D336660-0x000000018D3367E4
		private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D3361DC-0x000000018D336378
		private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D335720-0x000000018D3358A4
		private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D3358A4-0x000000018D335A28
		private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D334C30-0x000000018D334DC8
		private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D334758-0x000000018D3348F8
		private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D3348F8-0x000000018D334A98
		private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D334A98-0x000000018D334C30
		private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D334DC8-0x000000018D334F3C
		private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D334F3C-0x000000018D3350B0
		private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D335EF4-0x000000018D336068
		private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D336068-0x000000018D3361DC
		private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D336378-0x000000018D3364EC
		private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D3364EC-0x000000018D336660
		private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D339398-0x000000018D33952C
		private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent); // 0x000000018D337DF0-0x000000018D337F8C
		private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D336E38-0x000000018D336FC4
		private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D338460-0x000000018D3385D4
		private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D3385D4-0x000000018D338760
		private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D337C6C-0x000000018D337DF0
		private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D338294-0x000000018D338460
		private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D339050-0x000000018D3391C4
		private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33791C-0x000000018D337A90
		private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D337A90-0x000000018D337C6C
		private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D3391C4-0x000000018D339398
		private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D338ECC-0x000000018D339050
		private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D338A48-0x000000018D338BE4
		private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D337F8C-0x000000018D338110
		private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D338110-0x000000018D338294
		private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D33749C-0x000000018D337634
		private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D336FC4-0x000000018D337164
		private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D337164-0x000000018D337304
		private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D337304-0x000000018D33749C
		private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D337634-0x000000018D3377A8
		private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D3377A8-0x000000018D33791C
		private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D338760-0x000000018D3388D4
		private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D3388D4-0x000000018D338A48
		private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D338BE4-0x000000018D338D58
		private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D338D58-0x000000018D338ECC
		private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33BC04-0x000000018D33BD98
		private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent); // 0x000000018D33A65C-0x000000018D33A7F8
		private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D3396A4-0x000000018D339830
		private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D33ACCC-0x000000018D33AE40
		private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D33AE40-0x000000018D33AFCC
		private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D33A4D8-0x000000018D33A65C
		private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D33AB00-0x000000018D33ACCC
		private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33B8BC-0x000000018D33BA30
		private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33A188-0x000000018D33A2FC
		private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D33A2FC-0x000000018D33A4D8
		private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D33BA30-0x000000018D33BC04
		private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D33B738-0x000000018D33B8BC
		private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D33B2B4-0x000000018D33B450
		private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33A7F8-0x000000018D33A97C
		private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D33A97C-0x000000018D33AB00
		private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D339D08-0x000000018D339EA0
		private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D339830-0x000000018D3399D0
		private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D3399D0-0x000000018D339B70
		private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D339B70-0x000000018D339D08
		private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D339EA0-0x000000018D33A014
		private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D33A014-0x000000018D33A188
		private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33AFCC-0x000000018D33B140
		private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D33B140-0x000000018D33B2B4
		private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33B450-0x000000018D33B5C4
		private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D33B5C4-0x000000018D33B738
		private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33E46C-0x000000018D33E600
		private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent); // 0x000000018D33CEC4-0x000000018D33D060
		private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D33BF0C-0x000000018D33C098
		private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D33D534-0x000000018D33D6A8
		private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D33D6A8-0x000000018D33D834
		private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D33CD40-0x000000018D33CEC4
		private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D33D368-0x000000018D33D534
		private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33E124-0x000000018D33E298
		private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33C9F0-0x000000018D33CB64
		private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D33CB64-0x000000018D33CD40
		private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D33E298-0x000000018D33E46C
		private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D33DFA0-0x000000018D33E124
		private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D33DB1C-0x000000018D33DCB8
		private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33D060-0x000000018D33D1E4
		private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D33D1E4-0x000000018D33D368
		private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C570-0x000000018D33C708
		private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C098-0x000000018D33C238
		private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C238-0x000000018D33C3D8
		private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C3D8-0x000000018D33C570
		private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C708-0x000000018D33C87C
		private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D33C87C-0x000000018D33C9F0
		private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33D834-0x000000018D33D9A8
		private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D33D9A8-0x000000018D33DB1C
		private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33DCB8-0x000000018D33DE2C
		private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D33DE2C-0x000000018D33DFA0
		private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D340CD8-0x000000018D340E6C
		private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent); // 0x000000018D33F730-0x000000018D33F8CC
		private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D33E778-0x000000018D33E904
		private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D33FDA0-0x000000018D33FF14
		private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D33FF14-0x000000018D3400A0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D33F5AC-0x000000018D33F730
		private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D33FBD4-0x000000018D33FDA0
		private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D340990-0x000000018D340B04
		private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D33F25C-0x000000018D33F3D0
		private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D33F3D0-0x000000018D33F5AC
		private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D340B04-0x000000018D340CD8
		private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D34080C-0x000000018D340990
		private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D340388-0x000000018D340524
		private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D33F8CC-0x000000018D33FA50
		private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D33FA50-0x000000018D33FBD4
		private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D33EDDC-0x000000018D33EF74
		private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D33E904-0x000000018D33EAA4
		private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D33EAA4-0x000000018D33EC44
		private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D33EC44-0x000000018D33EDDC
		private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D33EF74-0x000000018D33F0E8
		private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D33F0E8-0x000000018D33F25C
		private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D3400A0-0x000000018D340214
		private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D340214-0x000000018D340388
		private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D340524-0x000000018D340698
		private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D340698-0x000000018D34080C
		private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent); // 0x000000018D343544-0x000000018D3436D8
		private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent); // 0x000000018D341F9C-0x000000018D342138
		private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent); // 0x000000018D340FE4-0x000000018D341170
		private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent); // 0x000000018D34260C-0x000000018D342780
		private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent); // 0x000000018D342780-0x000000018D34290C
		private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent); // 0x000000018D341E18-0x000000018D341F9C
		private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent); // 0x000000018D342440-0x000000018D34260C
		private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent); // 0x000000018D3431FC-0x000000018D343370
		private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent); // 0x000000018D341AC8-0x000000018D341C3C
		private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent); // 0x000000018D341C3C-0x000000018D341E18
		private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent); // 0x000000018D343370-0x000000018D343544
		private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent); // 0x000000018D343078-0x000000018D3431FC
		private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent); // 0x000000018D342BF4-0x000000018D342D90
		private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D342138-0x000000018D3422BC
		private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D3422BC-0x000000018D342440
		private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent); // 0x000000018D341648-0x000000018D3417E0
		private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent); // 0x000000018D341170-0x000000018D341310
		private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent); // 0x000000018D341310-0x000000018D3414B0
		private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent); // 0x000000018D3414B0-0x000000018D341648
		private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent); // 0x000000018D3417E0-0x000000018D341954
		private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent); // 0x000000018D341954-0x000000018D341AC8
		private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent); // 0x000000018D34290C-0x000000018D342A80
		private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent); // 0x000000018D342A80-0x000000018D342BF4
		private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent); // 0x000000018D342D90-0x000000018D342F04
		private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent); // 0x000000018D342F04-0x000000018D343078
	}

	public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message> // TypeDefIndex: 72254
	{
		// Fields
		private Flags m_Flags; // 0x10
		private InputManager m_LocalManager; // 0x18
		private Subscriber[] m_Subscribers; // 0x20
		private RemoteSender[] m_Senders; // 0x28
	
		// Properties
		public bool sending { get; private set; } // 0x0000000185A37090-0x0000000185A370A0 0x000000018D34E034-0x000000018D34E050
		internal InputManager manager { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Nested types
		public enum MessageType // TypeDefIndex: 72234
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
	
		public struct Message // TypeDefIndex: 72235
		{
			// Fields
			public int participantId; // 0x00
			public MessageType type; // 0x04
			public byte[] data; // 0x08
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 72236
		{
			Sending = 1,
			StartSendingOnConnect = 2
		}
	
		[Serializable]
		internal struct RemoteSender // TypeDefIndex: 72237
		{
			// Fields
			public int senderId; // 0x00
			public InternedString[] layouts; // 0x08
			public RemoteInputDevice[] devices; // 0x10
		}
	
		[Serializable]
		internal struct RemoteInputDevice // TypeDefIndex: 72238
		{
			// Fields
			public int remoteId; // 0x00
			public int localId; // 0x04
			public InputDeviceDescription description; // 0x08
		}
	
		internal class Subscriber : IDisposable // TypeDefIndex: 72239
		{
			// Fields
			public InputRemoting owner; // 0x10
			public IObserver<Message> observer; // 0x18
	
			// Constructors
			public Subscriber(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Dispose(); // 0x000000018D350644-0x000000018D350690
		}
	
		private static class ConnectMsg // TypeDefIndex: 72240
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018D34991C-0x000000018D349950
		}
	
		private static class StartSendingMsg // TypeDefIndex: 72241
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018D350484-0x000000018D3504A0
		}
	
		private static class StopSendingMsg // TypeDefIndex: 72242
		{
			// Methods
			public static void Process(InputRemoting receiver); // 0x000000018D3505DC-0x000000018D3505F8
		}
	
		private static class DisconnectMsg // TypeDefIndex: 72243
		{
			// Methods
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D349950-0x000000018D3499D0
		}
	
		private static class NewLayoutMsg // TypeDefIndex: 72245
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 72244
			{
				// Fields
				public string name; // 0x00
				public string layoutJson; // 0x08
				public bool isOverride; // 0x10
			}
	
			// Methods
			public static Message? Create(InputRemoting sender, string layoutName); // 0x000000018D34EFD4-0x000000018D34F2C8
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D34F2C8-0x000000018D34F3B0
		}
	
		private static class NewDeviceMsg // TypeDefIndex: 72248
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 72246
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
			private sealed class __c // TypeDefIndex: 72247
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D351F68-0x000000018D351FCC
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _Create_b__1_0(InternedString x); // 0x000000018D313214-0x000000018D313228
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34E404-0x000000018D34E69C
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D34E69C-0x000000018D34EC74
		}
	
		private static class NewEventsMsg // TypeDefIndex: 72249
		{
			// Methods
			public static Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset); // 0x000000018D34EC74-0x000000018D34ECE8
			public static Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34ECE8-0x000000018D34EDF8
			public static unsafe Message Create(InputEvent* events, int eventCount); // 0x000000018D34EDF8-0x000000018D34EEE4
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D34EEE4-0x000000018D34EFD4
		}
	
		private static class ChangeUsageMsg // TypeDefIndex: 72252
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 72250
			{
				// Fields
				public int deviceId; // 0x00
				public string[] usages; // 0x08
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 72251
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D351FCC-0x000000018D3521CC
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _Create_b__1_0(InternedString x); // 0x000000018D313214-0x000000018D313228
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018D349384-0x000000018D349564
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D349564-0x000000018D34991C
		}
	
		private static class RemoveDeviceMsg // TypeDefIndex: 72253
		{
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device); // 0x000000018D35020C-0x000000018D350288
			public static void Process(InputRemoting receiver, Message msg); // 0x000000018D350288-0x000000018D35032C
		}
	
		// Constructors
		internal InputRemoting(InputManager manager, bool startSendingOnConnect = false /* Metadata: 0x02622B37 */); // 0x000000018D34DFB0-0x000000018D34E034
	
		// Methods
		public void StartSending(); // 0x000000018D34DAD0-0x000000018D34DC34
		public void StopSending(); // 0x000000018D34DC34-0x000000018D34DD8C
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg); // 0x000000018D34DE78-0x000000018D34DF80
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error); // 0x0000000186805BA0-0x0000000186805BB0
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(); // 0x0000000186805BA0-0x0000000186805BB0
		public IDisposable Subscribe(IObserver<Message> observer); // 0x000000018D34DD8C-0x000000018D34DE78
		private void SendInitialMessages(); // 0x000000018D34D854-0x000000018D34D874
		private void SendAllGeneratedLayouts(); // 0x000000018D34D54C-0x000000018D34D6C8
		private void SendLayout(string layoutName); // 0x000000018D34D988-0x000000018D34DA34
		private void SendAllDevices(); // 0x000000018D34D404-0x000000018D34D54C
		private void SendDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34D77C-0x000000018D34D804
		private void SendEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018D34D804-0x000000018D34D854
		private void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018D34D6C8-0x000000018D34D77C
		private void SendLayoutChange(string layout, InputControlLayoutChange change); // 0x000000018D34D874-0x000000018D34D988
		private void Send(Message msg); // 0x000000018D34DA34-0x000000018D34DAD0
		private int FindOrCreateSenderRecord(int senderId); // 0x000000018D34D25C-0x000000018D34D320
		private static InternedString BuildLayoutNamespace(int senderId); // 0x000000018D34D164-0x000000018D34D1E4
		private int FindLocalDeviceId(int remoteDeviceId, int senderIndex); // 0x000000018D34D1E4-0x000000018D34D25C
		private UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex); // 0x000000018D34DF80-0x000000018D34DFB0
		public void RemoveRemoteDevices(int participantId); // 0x000000018D34D320-0x000000018D34D404
		private static byte[] SerializeData<TData>(TData data);
		private static TData DeserializeData<TData>(byte[] data);
	}

	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 72256
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
		private class Subscriber : IDisposable // TypeDefIndex: 72255
		{
			// Fields
			public RemoteInputPlayerConnection owner; // 0x10
			public IObserver<InputRemoting.Message> observer; // 0x18
	
			// Constructors
			public Subscriber(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Dispose(); // 0x000000018D3505F8-0x000000018D350644
		}
	
		// Constructors
		public RemoteInputPlayerConnection(); // 0x0000000185DD6260-0x0000000185DD6270
		static RemoteInputPlayerConnection(); // 0x000000018D350034-0x000000018D35020C
	
		// Methods
		public void Bind(IEditorPlayerConnection connection, bool isConnected); // 0x000000018D34F628-0x000000018D34FAA8
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer); // 0x000000018D34FD70-0x000000018D34FEDC
		private void OnConnected(int id); // 0x000000018D34FAB8-0x000000018D34FB60
		private void OnDisconnected(int id); // 0x000000018D34FB60-0x000000018D34FC0C
		private void OnNewDevice(MessageEventArgs args); // 0x000000018D34FC0C-0x000000018D34FC1C
		private void OnNewLayout(MessageEventArgs args); // 0x000000018D34FC2C-0x000000018D34FC3C
		private void OnNewEvents(MessageEventArgs args); // 0x000000018D34FC1C-0x000000018D34FC2C
		private void OnRemoveDevice(MessageEventArgs args); // 0x000000018D34FC3C-0x000000018D34FC4C
		private void OnChangeUsages(MessageEventArgs args); // 0x000000018D34FAA8-0x000000018D34FAB8
		private void OnStartSending(MessageEventArgs args); // 0x000000018D34FC4C-0x000000018D34FC5C
		private void OnStopSending(MessageEventArgs args); // 0x000000018D34FC5C-0x000000018D34FC6C
		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args); // 0x000000018D34FC6C-0x000000018D34FD70
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg); // 0x000000018D34FEDC-0x000000018D350034
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error); // 0x0000000186805BA0-0x0000000186805BB0
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[InputControlLayout(isGenericTypeOfDevice = true)]
	public class Sensor : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 72257
	{
		// Properties
		public float samplingFrequency { get; set; } // 0x000000018D35032C-0x000000018D35040C 0x000000018D35040C-0x000000018D350484
	
		// Constructors
		public Sensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	}

	[InputControlLayout(stateType = typeof(AccelerometerState))]
	public class Accelerometer : Sensor // TypeDefIndex: 72258
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _acceleration_k__BackingField; // 0x190
		[CompilerGenerated]
		private static Accelerometer _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static Accelerometer current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D349084-0x000000018D3490BC 0x000000018D3490BC-0x000000018D34910C
	
		// Constructors
		public Accelerometer(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D349030-0x000000018D349038
		protected override void OnRemoved(); // 0x000000018D349038-0x000000018D349084
		protected override void FinishSetup(); // 0x000000018D348FD0-0x000000018D349030
	}

	[InputControlLayout(stateType = typeof(GyroscopeState))]
	public class Gyroscope : Sensor // TypeDefIndex: 72259
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _angularVelocity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static Gyroscope _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control angularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static Gyroscope current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D349B9C-0x000000018D349BD4 0x000000018D349BD4-0x000000018D349C24
	
		// Constructors
		public Gyroscope(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D349B48-0x000000018D349B50
		protected override void OnRemoved(); // 0x000000018D349B50-0x000000018D349B9C
		protected override void FinishSetup(); // 0x000000018D349AE8-0x000000018D349B48
	}

	[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
	public class GravitySensor : Sensor // TypeDefIndex: 72260
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _gravity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static GravitySensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control gravity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static GravitySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D349A60-0x000000018D349A98 0x000000018D349A98-0x000000018D349AE8
	
		// Constructors
		public GravitySensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3499D0-0x000000018D349A30
		public override void MakeCurrent(); // 0x000000018D349A30-0x000000018D349A38
		protected override void OnRemoved(); // 0x000000018D349A38-0x000000018D349A60
	}

	[InputControlLayout(stateType = typeof(AttitudeState), displayName = "Attitude")]
	public class AttitudeSensor : Sensor // TypeDefIndex: 72261
	{
		// Fields
		[CompilerGenerated]
		private QuaternionControl _attitude_k__BackingField; // 0x190
		[CompilerGenerated]
		private static AttitudeSensor _current_k__BackingField; // 0x00
	
		// Properties
		public QuaternionControl attitude { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static AttitudeSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D3492FC-0x000000018D349334 0x000000018D349334-0x000000018D349384
	
		// Constructors
		public AttitudeSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D3492A8-0x000000018D3492B0
		protected override void OnRemoved(); // 0x000000018D3492B0-0x000000018D3492FC
		protected override void FinishSetup(); // 0x000000018D349248-0x000000018D3492A8
	}

	[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
	public class LinearAccelerationSensor : Sensor // TypeDefIndex: 72262
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _acceleration_k__BackingField; // 0x190
		[CompilerGenerated]
		private static LinearAccelerationSensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static LinearAccelerationSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D34E240-0x000000018D34E278 0x000000018D34E278-0x000000018D34E2C8
	
		// Constructors
		public LinearAccelerationSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34E1EC-0x000000018D34E1F4
		protected override void OnRemoved(); // 0x000000018D34E1F4-0x000000018D34E240
		protected override void FinishSetup(); // 0x000000018D34E18C-0x000000018D34E1EC
	}

	[InputControlLayout(displayName = "Magnetic Field")]
	public class MagneticFieldSensor : Sensor // TypeDefIndex: 72263
	{
		// Fields
		[CompilerGenerated]
		private Vector3Control _magneticField_k__BackingField; // 0x190
		[CompilerGenerated]
		private static MagneticFieldSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Magnetic Field", noisy = true)]
		public Vector3Control magneticField { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static MagneticFieldSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D34E37C-0x000000018D34E3B4 0x000000018D34E3B4-0x000000018D34E404
	
		// Constructors
		public MagneticFieldSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34E328-0x000000018D34E330
		protected override void OnRemoved(); // 0x000000018D34E330-0x000000018D34E37C
		protected override void FinishSetup(); // 0x000000018D34E2C8-0x000000018D34E328
	}

	[InputControlLayout(displayName = "Light")]
	public class LightSensor : Sensor // TypeDefIndex: 72264
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _lightLevel_k__BackingField; // 0x190
		[CompilerGenerated]
		private static LightSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Light Level", noisy = true)]
		public AxisControl lightLevel { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static LightSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D34E104-0x000000018D34E13C 0x000000018D34E13C-0x000000018D34E18C
	
		// Constructors
		public LightSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34E0B0-0x000000018D34E0B8
		protected override void OnRemoved(); // 0x000000018D34E0B8-0x000000018D34E104
		protected override void FinishSetup(); // 0x000000018D34E050-0x000000018D34E0B0
	}

	[InputControlLayout(displayName = "Pressure")]
	public class PressureSensor : Sensor // TypeDefIndex: 72265
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _atmosphericPressure_k__BackingField; // 0x190
		[CompilerGenerated]
		private static PressureSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Atmospheric Pressure", noisy = true)]
		public AxisControl atmosphericPressure { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static PressureSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D34F464-0x000000018D34F49C 0x000000018D34F49C-0x000000018D34F4EC
	
		// Constructors
		public PressureSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34F410-0x000000018D34F418
		protected override void OnRemoved(); // 0x000000018D34F418-0x000000018D34F464
		protected override void FinishSetup(); // 0x000000018D34F3B0-0x000000018D34F410
	}

	[InputControlLayout(displayName = "Proximity")]
	public class ProximitySensor : Sensor // TypeDefIndex: 72266
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _distance_k__BackingField; // 0x190
		[CompilerGenerated]
		private static ProximitySensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Distance", noisy = true)]
		public AxisControl distance { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static ProximitySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D34F5A0-0x000000018D34F5D8 0x000000018D34F5D8-0x000000018D34F628
	
		// Constructors
		public ProximitySensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34F54C-0x000000018D34F554
		protected override void OnRemoved(); // 0x000000018D34F554-0x000000018D34F5A0
		protected override void FinishSetup(); // 0x000000018D34F4EC-0x000000018D34F54C
	}

	[InputControlLayout(displayName = "Humidity")]
	public class HumiditySensor : Sensor // TypeDefIndex: 72267
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _relativeHumidity_k__BackingField; // 0x190
		[CompilerGenerated]
		private static HumiditySensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Relative Humidity", noisy = true)]
		public AxisControl relativeHumidity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static HumiditySensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D349E14-0x000000018D349E4C 0x000000018D349E4C-0x000000018D349E9C
	
		// Constructors
		public HumiditySensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D349DC0-0x000000018D349DC8
		protected override void OnRemoved(); // 0x000000018D349DC8-0x000000018D349E14
		protected override void FinishSetup(); // 0x000000018D349D60-0x000000018D349DC0
	}

	[InputControlLayout(displayName = "Ambient Temperature")]
	public class AmbientTemperatureSensor : Sensor // TypeDefIndex: 72268
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _ambientTemperature_k__BackingField; // 0x190
		[CompilerGenerated]
		private static AmbientTemperatureSensor _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Ambient Temperature", noisy = true)]
		public AxisControl ambientTemperature { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static AmbientTemperatureSensor current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D3491C0-0x000000018D3491F8 0x000000018D3491F8-0x000000018D349248
	
		// Constructors
		public AmbientTemperatureSensor(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D34916C-0x000000018D349174
		protected override void OnRemoved(); // 0x000000018D349174-0x000000018D3491C0
		protected override void FinishSetup(); // 0x000000018D34910C-0x000000018D34916C
	}

	[InputControlLayout(displayName = "Step Counter")]
	public class StepCounter : Sensor // TypeDefIndex: 72269
	{
		// Fields
		[CompilerGenerated]
		private IntegerControl _stepCounter_k__BackingField; // 0x190
		[CompilerGenerated]
		private static StepCounter _current_k__BackingField; // 0x00
	
		// Properties
		[InputControl(displayName = "Step Counter", noisy = true)]
		public IntegerControl stepCounter { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static StepCounter current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D350554-0x000000018D35058C 0x000000018D35058C-0x000000018D3505DC
	
		// Constructors
		public StepCounter(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D350500-0x000000018D350508
		protected override void OnRemoved(); // 0x000000018D350508-0x000000018D350554
		protected override void FinishSetup(); // 0x000000018D3504A0-0x000000018D350500
	}

	[InputControlLayout(displayName = "Hinge Angle")]
	public class HingeAngle : Sensor // TypeDefIndex: 72270
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _angle_k__BackingField; // 0x190
		[CompilerGenerated]
		private static HingeAngle _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl angle { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public static HingeAngle current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D349CD8-0x000000018D349D10 0x000000018D349D10-0x000000018D349D60
	
		// Constructors
		public HingeAngle(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D349C84-0x000000018D349C8C
		protected override void OnRemoved(); // 0x000000018D349C8C-0x000000018D349CD8
		protected override void FinishSetup(); // 0x000000018D349C24-0x000000018D349C84
	}

	public enum TouchPhase // TypeDefIndex: 72271
	{
		None = 0,
		Began = 1,
		Moved = 2,
		Ended = 3,
		Canceled = 4,
		Stationary = 5
	}

	[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
	public class Touchscreen : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset // TypeDefIndex: 72272
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
		public TouchControl primaryTouch { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		public ReadOnlyArray<TouchControl> touches { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187259EC0-0x0000000187259ED0 0x000000018D351E2C-0x000000018D351E44
		protected TouchControl[] touchControlArray { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x000000018D351DC0-0x000000018D351E2C
		public static new Touchscreen current { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018D351D10-0x000000018D351D60 0x000000018D351D60-0x000000018D351DC0
	
		// Constructors
		public Touchscreen(); // 0x000000018D2E1E18-0x000000018D2E1E20
		static Touchscreen(); // 0x000000018710FB80-0x000000018710FC20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D350A28-0x000000018D350A78
		protected override void OnRemoved(); // 0x000000018D350EB8-0x000000018D350F18
		protected override void FinishSetup(); // 0x000000018D350690-0x000000018D350A28
		protected new void OnNextUpdate(); // 0x000000018D350B5C-0x000000018D350EB8
		protected new void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D350F18-0x000000018D35165C
		new void IInputStateCallbackReceiver.OnNextUpdate(); // 0x000000018D351D00-0x000000018D351D08
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr); // 0x000000018D351D08-0x000000018D351D10
		new bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x000000018D351AB4-0x000000018D351D00
		void ICustomDeviceReset.Reset(); // 0x000000018D3516F4-0x000000018D351A58
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018D350A78-0x000000018D350B5C
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018D351A58-0x000000018D351AB4
		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr); // 0x000000018D35165C-0x000000018D3516F4
	}

	[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = true)]
	public class TrackedDevice : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 72273
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
		public IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		[InputControl(synthetic = true)]
		public ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		[InputControl(noisy = true, dontReset = true)]
		public Vector3Control devicePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		[InputControl(noisy = true, dontReset = true)]
		public QuaternionControl deviceRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
	
		// Constructors
		public TrackedDevice(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D351E44-0x000000018D351F68
	}

	public static class InputExtensions // TypeDefIndex: 72274
	{
		// Extension methods
		public static bool IsInProgress(this InputActionPhase phase); // 0x0000000185270040-0x0000000185270050
		public static bool IsEndedOrCanceled(this UnityEngine.InputSystem.TouchPhase phase); // 0x000000018D349EB0-0x000000018D349EC0
		public static bool IsActive(this UnityEngine.InputSystem.TouchPhase phase); // 0x000000018D349E9C-0x000000018D349EB0
		public static bool IsModifierKey(this UnityEngine.InputSystem.Key key); // 0x000000018D349EC0-0x000000018D349ECC
		public static bool IsTextInputKey(this UnityEngine.InputSystem.Key key); // 0x000000018D349ECC-0x000000018D349EE8
	}

	internal static class InputFeatureNames // TypeDefIndex: 72275
	{
		// Fields
		public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE"; // Metadata: 0x02622B4A
		public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT"; // Metadata: 0x02622B6A
		public const string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS"; // Metadata: 0x02622B87
		public const string kUseReadValueCaching = "USE_READ_VALUE_CACHING"; // Metadata: 0x02622B9E
		public const string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS"; // Metadata: 0x02622BB5
	}

	internal class InputManager // TypeDefIndex: 72284
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
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x0000000185B0DA00-0x0000000185B0DA60 
		public TypeTable processors { get; } // 0x0000000187232F70-0x0000000187232F80 
		public TypeTable interactions { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public TypeTable composites { get; } // 0x0000000187232F80-0x0000000187232F90 
		public InputMetrics metrics { get; } // 0x000000018D34CBDC-0x000000018D34CD70 
		public InputSettings settings { get; set; } // 0x0000000184736930-0x0000000184736940 0x000000018D34D070-0x000000018D34D164
		public InputUpdateType updateMask { get; set; } // 0x0000000187235BD0-0x0000000187235BE0 0x0000000185B0E560-0x0000000185B0E590
		public InputUpdateType defaultUpdateType { get; } // 0x000000018526BE30-0x000000018526BE50 
		public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get; set; } // 0x0000000187240810-0x0000000187240820 0x0000000185B0E550-0x0000000185B0E560
		public float pollingFrequency { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x000000018D34CFD0-0x000000018D34D070
		public bool isProcessingEvents { get; } // 0x0000000187259E50-0x0000000187259E60 
		private bool gameIsPlaying { get; } // 0x00000001851A4410-0x00000001851A4420 
		private bool gameHasFocus { get; } // 0x00000001853AD9B0-0x00000001853AD9E0 
		private bool gameShouldGetInputRegardlessOfFocus { get; } // 0x00000001863E12D0-0x00000001863E1300 
		internal bool optimizedControlsFeatureEnabled { get; set; } // 0x0000000187259E60-0x0000000187259E70 0x0000000187259E90-0x0000000187259EA0
		internal bool readValueCachingFeatureEnabled { get; set; } // 0x0000000187259E80-0x0000000187259E90 0x0000000187259EB0-0x0000000187259EC0
		internal bool paranoidReadValueCachingChecksEnabled { get; set; } // 0x0000000187259E70-0x0000000187259E80 0x0000000187259EA0-0x0000000187259EB0
	
		// Events
		public event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange {
			add; // 0x0000000186F870F0-0x0000000186F87140
			remove; // 0x000000018D34CDBC-0x000000018D34CE08
		}
		public event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onDeviceStateChange {
			add; // 0x000000018D34CAF8-0x000000018D34CB44
			remove; // 0x000000018D34CE54-0x000000018D34CEA0
		}
		public event InputDeviceCommandDelegate onDeviceCommand {
			add; // 0x000000018D34CAAC-0x000000018D34CAF8
			remove; // 0x000000018D34CE08-0x000000018D34CE54
		}
		public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice {
			add; // 0x0000000185B0CE50-0x0000000185B0CEB0
			remove; // 0x000000018D34CEEC-0x000000018D34CF38
		}
		public event Action<string, InputControlLayoutChange> onLayoutChange {
			add; // 0x000000018D34CB90-0x000000018D34CBDC
			remove; // 0x000000018D34CF38-0x000000018D34CF84
		}
		public event Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEvent {
			add; // 0x000000018D34CB44-0x000000018D34CB90
			remove; // 0x000000018D34CEA0-0x000000018D34CEEC
		}
		public event Action onBeforeUpdate {
			add; // 0x0000000185B01190-0x0000000185B011F0
			remove; // 0x00000001870F2170-0x00000001870F21C0
		}
		public event Action onAfterUpdate {
			add; // 0x0000000185B01140-0x0000000185B01190
			remove; // 0x000000018D34CD70-0x000000018D34CDBC
		}
		public event Action onSettingsChange {
			add; // 0x0000000185B010F0-0x0000000185B01140
			remove; // 0x000000018D34CF84-0x000000018D34CFD0
		}
	
		// Nested types
		internal enum DeviceDisableScope // TypeDefIndex: 72276
		{
			Everywhere = 0,
			InFrontendOnly = 1,
			TemporaryWhilePlayerIsInBackground = 2
		}
	
		[Serializable]
		internal struct AvailableDevice // TypeDefIndex: 72277
		{
			// Fields
			public InputDeviceDescription description; // 0x00
			public int deviceId; // 0x38
			public bool isNative; // 0x3C
			public bool isRemoved; // 0x3D
		}
	
		private struct StateChangeMonitorTimeout // TypeDefIndex: 72278
		{
			// Fields
			public InputControl control; // 0x00
			public double time; // 0x08
			public IInputStateChangeMonitor monitor; // 0x10
			public long monitorIndex; // 0x18
			public int timerIndex; // 0x20
		}
	
		internal struct StateChangeMonitorListener // TypeDefIndex: 72279
		{
			// Fields
			public InputControl control; // 0x00
			public IInputStateChangeMonitor monitor; // 0x08
			public long monitorIndex; // 0x10
			public uint groupIndex; // 0x18
		}
	
		internal struct StateChangeMonitorsForDevice // TypeDefIndex: 72280
		{
			// Fields
			public MemoryHelpers.BitRegion[] memoryRegions; // 0x00
			public StateChangeMonitorListener[] listeners; // 0x08
			public DynamicBitfield signalled; // 0x10
			public bool needToUpdateOrderingOfMonitors; // 0x30
			public bool needToCompactArrays; // 0x31
	
			// Properties
			public int count { get; } // 0x0000000182271A60-0x0000000182271A70 
	
			// Methods
			public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex); // 0x0000000185B01FC0-0x0000000185B02160
			public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval); // 0x000000018D36404C-0x000000018D364140
			public void Clear(); // 0x000000018D363EFC-0x000000018D363F4C
			public void CompactArrays(); // 0x000000018D363F4C-0x000000018D363FC0
			private void RemoveAt(int i); // 0x000000018D363FC0-0x000000018D36404C
			public void SortMonitorsByIndex(); // 0x0000000186CFEEB0-0x0000000186CFEF80
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__76<TDevice> // TypeDefIndex: 72281
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
		private sealed class _ListControlLayouts_d__91 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 72282
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
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _ListControlLayouts_d__91(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D366588-0x000000018D366854
			private bool MoveNext(); // 0x000000018D365730-0x000000018D36648C
			private void __m__Finally1(); // 0x000000018D366854-0x000000018D366890
			private void __m__Finally2(); // 0x000000018D366890-0x000000018D3668CC
			private void __m__Finally3(); // 0x000000018D3668CC-0x000000018D366908
			private void __m__Finally4(); // 0x000000018D366908-0x000000018D366944
			private void __m__Finally5(); // 0x000000018D366944-0x000000018D366980
			private void __m__Finally6(); // 0x000000018D366980-0x000000018D3669BC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D36653C-0x000000018D366588
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018D36648C-0x000000018D366534
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D366534-0x000000018D36653C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72283
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<UnityEngine.InputSystem.InputDevice, string> __9__175_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5D80-0x00000001871E5DE0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _MakeDeviceNameUnique_b__175_0(UnityEngine.InputSystem.InputDevice x); // 0x0000000186EAB260-0x0000000186EAB2D0
		}
	
		// Constructors
		public InputManager(); // 0x0000000186805BA0-0x0000000186805BB0
		static InputManager(); // 0x0000000186D25260-0x0000000186D25580
	
		// Methods
		public void RegisterControlLayout(string name, System.Type type); // 0x0000000185266950-0x0000000185267410
		public void RegisterControlLayout(string json, string name = null, bool isOverride = false /* Metadata: 0x02622BD8 */); // 0x0000000185B0A530-0x0000000185B0A790
		public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null); // 0x000000018D34B3F8-0x000000018D34B608
		private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false /* Metadata: 0x02622BD9 */, bool isOverride = false /* Metadata: 0x02622BDA */); // 0x00000001852663E0-0x00000001852667A0
		public void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new();
		private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false /* Metadata: 0x02622BDB */); // 0x0000000185267790-0x0000000185267990
		private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout); // 0x000000018D34AB80-0x000000018D34AC64
		private bool IsControlUsingLayout(InputControl control, InternedString layout); // 0x000000018D34AC64-0x000000018D34AD38
		public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher); // 0x000000018662BE30-0x000000018662BF20
		public void RegisterControlLayoutMatcher(System.Type type, InputDeviceMatcher matcher); // 0x000000018662BB10-0x000000018662BC00
		private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher); // 0x000000018662C010-0x000000018662C2B0
		private void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, InternedString newLayout); // 0x000000018D34B274-0x000000018D34B3F8
		private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout); // 0x000000018662BF20-0x000000018662C010
		public void RemoveControlLayout(string name); // 0x000000018D34B608-0x000000018D34B87C
		public InputControlLayout TryLoadControlLayout(System.Type type); // 0x000000018D34C654-0x000000018D34C8A4
		public InputControlLayout TryLoadControlLayout(InternedString name); // 0x000000018D34C62C-0x000000018D34C654
		public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0 /* Metadata: 0x02622BDC */); // 0x0000000186315030-0x0000000186315AB0
		private InternedString FindOrRegisterDeviceLayoutForType(System.Type type); // 0x0000000186BAD7F0-0x0000000186BAD850
		private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName); // 0x000000018D34AD38-0x000000018D34AE4C
		[IteratorStateMachine(typeof(_ListControlLayouts_d__91))]
		public IEnumerable<string> ListControlLayouts(string basedOn = null); // 0x000000018D34AE4C-0x000000018D34AED4
		public int GetControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl;
		public void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D34C290-0x000000018D34C3F4
		public void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D349EE8-0x000000018D34A04C
		public void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage); // 0x000000018D34B87C-0x000000018D34B9E0
		private void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34B154-0x000000018D34B214
		public UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name = null); // 0x000000018D34A1C4-0x000000018D34A2BC
		public UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, InternedString variants = default); // 0x000000018D34A2BC-0x000000018D34A41C
		private UnityEngine.InputSystem.InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = default, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x02622BDD */, InternedString variants = default); // 0x0000000186314370-0x0000000186314540
		public void AddDevice(UnityEngine.InputSystem.InputDevice device); // 0x0000000186313530-0x00000001863138B0
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description); // 0x000000018D34A41C-0x000000018D34A470
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0 /* Metadata: 0x02622BDE */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x02622BDF */); // 0x0000000186314E80-0x0000000186315030
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0 /* Metadata: 0x02622BE0 */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x02622BE1 */); // 0x000000018D34A04C-0x000000018D34A1C4
		public void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices = false /* Metadata: 0x02622BE2 */); // 0x000000018D34B9E0-0x000000018D34BE1C
		public void FlushDisconnectedDevices(); // 0x000000018D34A7A4-0x000000018D34A7F4
		public void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x02622BE3 */, bool? issueResetCommand = default); // 0x000000018526B720-0x000000018526BE30
		public UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout); // 0x000000018D34C4AC-0x000000018D34C5D8
		public UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout); // 0x000000018D34A7F4-0x000000018D34A8A4
		public UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType); // 0x000000018D34C5D8-0x000000018D34C62C
		public UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id); // 0x00000001853AB100-0x00000001853AB230
		public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions); // 0x000000018D34A8A4-0x000000018D34A9EC
		public void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, DeviceDisableScope scope = DeviceDisableScope.Everywhere /* Metadata: 0x02622BE4 */); // 0x000000018526BFC0-0x000000018526C180
		private unsafe void QueueEvent(InputEvent* eventPtr); // 0x000000018D34B214-0x000000018D34B274
		public void QueueEvent(InputEventPtr ptr); // 0x0000000189B3F094-0x0000000189B3F09C
		public void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo;
		public void Update(); // 0x000000018D34CA88-0x000000018D34CAAC
		public void Update(InputUpdateType updateType); // 0x0000000186F907B0-0x0000000186F907F0
		internal void Initialize(IInputRuntime runtime, InputSettings settings); // 0x0000000185B0ACC0-0x0000000185B0AD20
		internal void Destroy(); // 0x000000018D34A6B4-0x000000018D34A7A4
		internal void InitializeData(); // 0x0000000185B08F10-0x0000000185B0A0E0
		private void RegisterCustomTypes(System.Type[] types); // 0x00000001854C3020-0x00000001854C3240
		private void RegisterCustomTypes(); // 0x0000000185B80660-0x0000000185B80840
		internal void InstallRuntime(IInputRuntime runtime); // 0x000000018668E6C0-0x000000018668EA30
		internal void InstallGlobals(); // 0x0000000185B0A230-0x0000000185B0A4A0
		internal void UninstallGlobals(); // 0x000000018D34C8A4-0x000000018D34CA88
		private void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device); // 0x0000000186313920-0x0000000186313AD0
		private static void ResetControlPathsRecursive(InputControl control); // 0x000000018D34C1C4-0x000000018D34C290
		private void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device); // 0x00000001863138C0-0x0000000186313920
		private void ReallocateStateBuffers(); // 0x0000000186313AD0-0x0000000186313CC0
		private void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34A9EC-0x000000018D34AB80
		private void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device); // 0x0000000185267E00-0x0000000185268140
		private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor); // 0x0000000186314540-0x0000000186314C40
		private JsonParser.JsonString MakeEscapedJsonString(string theString); // 0x000000018D34AED4-0x000000018D34B024
		private UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor); // 0x0000000186314CA0-0x0000000186314D70
		private void InstallBeforeUpdateHookIfNecessary(); // 0x0000000185B011F0-0x0000000185B012D0
		private void RestoreDevicesAfterDomainReloadIfNecessary(); // 0x0000000186805BA0-0x0000000186805BB0
		private void WarnAboutDevicesFailingToRecreateAfterDomainReload(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnBeforeUpdate(InputUpdateType updateType); // 0x00000001853AE720-0x00000001853AE930
		internal void ApplySettings(); // 0x0000000185B0D0C0-0x0000000185B0DA00
		internal long ExecuteGlobalCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
		internal void AddAvailableDevicesThatAreNowRecognized(); // 0x0000000185B0CEB0-0x0000000185B0CF50
		private bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device); // 0x000000018526C3B0-0x000000018526C3F0
		internal void OnFocusChanged(bool focus); // 0x000000018526C1B0-0x000000018526C3A0
		internal bool ShouldRunUpdate(InputUpdateType updateType); // 0x00000001861D7DA0-0x00000001861D7DC0
		private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // 0x00000001853ABEE0-0x00000001853ACBA0
		private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed); // 0x00000001861D30F0-0x00000001861D3130
		private string MakeStringWithEventsProcessedByDevice(); // 0x000000018D34B024-0x000000018D34B154
		private void ResetCurrentProcessedEventBytesForDevices(); // 0x00000001861B4050-0x00000001861B4090
		[Conditional("UNITY_EDITOR")]
		private void CheckAllDevicesOptimizedControlsHaveValidState(); // 0x000000018D34A544-0x000000018D34A6B4
		private void InvokeAfterUpdateCallback(InputUpdateType updateType); // 0x0000000185E3DEB0-0x0000000185E3DF10
		internal void DontMakeCurrentlyUpdatingDeviceCurrent(); // 0x0000000187259E40-0x0000000187259E50
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputEvent* eventPtr, InputUpdateType updateType); // 0x0000000186252360-0x0000000186252430
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = default); // 0x00000001853AE930-0x00000001853AF3D0
		private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers); // 0x00000001853AF3D0-0x00000001853AF650
		private bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType); // 0x00000001853AFEE0-0x00000001853AFFC0
		public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex); // 0x0000000185B01E70-0x0000000185B01FC0
		private void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device); // 0x000000018D34C0A4-0x000000018D34C1C4
		public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex); // 0x000000018D34BF3C-0x000000018D34C0A4
		public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex); // 0x000000018D34A470-0x000000018D34A544
		public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex); // 0x000000018D34BE1C-0x000000018D34BF3C
		private void SortStateChangeMonitorsIfNecessary(int deviceIndex); // 0x00000001853AFA10-0x00000001853AFA70
		public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor); // 0x000000018D34C3F4-0x000000018D34C4AC
		public void FireStateChangeNotifications(); // 0x000000018702B290-0x000000018702B360
		private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes); // 0x00000001853AFA70-0x00000001853AFDC0
		internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr); // 0x00000001853B1010-0x00000001853B1330
		private void ProcessStateChangeMonitorTimeouts(); // 0x00000001853AD980-0x00000001853AD9B0
		[CompilerGenerated]
		private long _TryFindMatchingControlLayout_b__88_0(ref InputDeviceCommand commandRef); // 0x0000000186DB81D0-0x0000000186DB8250
	}

	public class InputSettings : ScriptableObject // TypeDefIndex: 72290
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
		internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; // Metadata: 0x02622BE8
	
		// Properties
		public UpdateMode updateMode { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018D3541B4-0x000000018D3541C4
		public ScrollDeltaBehavior scrollDeltaBehavior { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x000000018D354038-0x000000018D354048
		public bool compensateForScreenOrientation { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x000000018D353EF8-0x000000018D353F08
		[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", false)]
		public bool filterNoiseOnCurrent { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
		public float defaultDeadzoneMin { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x000000018D353F5C-0x000000018D353F78
		public float defaultDeadzoneMax { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x000000018D353F40-0x000000018D353F5C
		public float defaultButtonPressPoint { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018D353F08-0x000000018D353F40
		public float buttonReleaseThreshold { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018D353EDC-0x000000018D353EF8
		public float defaultTapTime { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018D353FB0-0x000000018D353FCC
		public float defaultSlowTapTime { get; set; } // 0x0000000187233590-0x00000001872335A0 0x000000018D353F94-0x000000018D353FB0
		public float defaultHoldTime { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x000000018D353F78-0x000000018D353F94
		public float tapRadius { get; set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x000000018D354198-0x000000018D3541B4
		public float multiTapDelayTime { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x000000018D35401C-0x000000018D354038
		public BackgroundBehavior backgroundBehavior { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x000000018D353ECC-0x000000018D353EDC
		public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x000000018D353FDC-0x000000018D353FEC
		public InputActionPropertyDrawerMode inputActionPropertyDrawerMode { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018D353FEC-0x000000018D353FFC
		public int maxEventBytesPerUpdate { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x000000018D353FFC-0x000000018D35400C
		public int maxQueuedEventsPerUpdate { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x000000018D35400C-0x000000018D35401C
		public ReadOnlyArray<string> supportedDevices { get; set; } // 0x0000000186314C40-0x0000000186314CA0 0x000000018D354058-0x000000018D354198
		public bool disableRedundantEventsMerging { get; set; } // 0x000000018225E030-0x000000018225E040 0x000000018D353FCC-0x000000018D353FDC
		public bool shortcutKeysConsumeInput { get; set; } // 0x000000018723CA30-0x000000018723CA40 0x000000018D354048-0x000000018D354058
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 72285
		{
			ProcessEventsInDynamicUpdate = 1,
			ProcessEventsInFixedUpdate = 2,
			ProcessEventsManually = 3
		}
	
		public enum ScrollDeltaBehavior // TypeDefIndex: 72286
		{
			UniformAcrossAllPlatforms = 0,
			KeepPlatformSpecificInputRange = 1
		}
	
		public enum BackgroundBehavior // TypeDefIndex: 72287
		{
			ResetAndDisableNonBackgroundDevices = 0,
			ResetAndDisableAllDevices = 1,
			IgnoreFocus = 2
		}
	
		public enum EditorInputBehaviorInPlayMode // TypeDefIndex: 72288
		{
			PointersAndKeyboardsRespectGameViewFocus = 0,
			AllDevicesRespectGameViewFocus = 1,
			AllDeviceInputAlwaysGoesToGameView = 2
		}
	
		public enum InputActionPropertyDrawerMode // TypeDefIndex: 72289
		{
			Compact = 0,
			MultilineEffective = 1,
			MultilineBoth = 2
		}
	
		// Constructors
		public InputSettings(); // 0x00000001871F0530-0x00000001871F0590
	
		// Methods
		public void SetInternalFeatureFlag(string featureName, bool enabled); // 0x000000018D353D6C-0x000000018D353ECC
		internal bool IsFeatureEnabled(string featureName); // 0x000000018D353C58-0x000000018D353CC8
		internal void OnChange(); // 0x000000018D353CC8-0x000000018D353D6C
		private static bool CompareFloats(float a, float b); // 0x000000018D353C44-0x000000018D353C58
		private static bool CompareSets<T>(ReadOnlyArray<T> a, ReadOnlyArray<T> b);
		private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName); // 0x000000018D353BEC-0x000000018D353C44
		internal static bool AreEqual(InputSettings a, InputSettings b); // 0x000000018D353960-0x000000018D353BEC
	}

	public class DefaultInputActions : IInputActionCollection2, IDisposable // TypeDefIndex: 72295
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
		public InputActionAsset asset { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public InputBinding? bindingMask { get; set; } // 0x000000018D3532B0-0x000000018D353300 0x000000018D353394-0x000000018D3533F4
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get; set; } // 0x000000018D353354-0x000000018D353394 0x000000018D3533F4-0x000000018D35342C
		public ReadOnlyArray<InputControlScheme> controlSchemes { get; } // 0x000000018D353320-0x000000018D353354 
		public IEnumerable<InputBinding> bindings { get; } // 0x000000018D353300-0x000000018D353320 
		public PlayerActions Player { get; } // 0x0000000186067390-0x00000001860673B0 
		public UIActions UI { get; } // 0x0000000186067390-0x00000001860673B0 
		public InputControlScheme KeyboardMouseScheme { get; } // 0x000000018D353064-0x000000018D353128 
		public InputControlScheme GamepadScheme { get; } // 0x000000018D352EDC-0x000000018D352FA0 
		public InputControlScheme TouchScheme { get; } // 0x000000018D353128-0x000000018D3531EC 
		public InputControlScheme JoystickScheme { get; } // 0x000000018D352FA0-0x000000018D353064 
		public InputControlScheme XRScheme { get; } // 0x000000018D3531EC-0x000000018D3532B0 
	
		// Nested types
		public struct PlayerActions // TypeDefIndex: 72291
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Move { get; } // 0x000000018D35BB48-0x000000018D35BB64 
			public InputAction Look { get; } // 0x000000018D35BB2C-0x000000018D35BB48 
			public InputAction Fire { get; } // 0x000000018D09E2B0-0x000000018D09E2CC 
			public bool enabled { get; } // 0x000000018D35BB64-0x000000018D35BB88 
	
			// Constructors
			public PlayerActions(DefaultInputActions wrapper); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			public InputActionMap Get(); // 0x000000018D09E3F0-0x000000018D09E40C
			public void Enable(); // 0x000000018D35B320-0x000000018D35B344
			public void Disable(); // 0x000000018D35B2FC-0x000000018D35B320
			public static implicit operator InputActionMap(PlayerActions set); // 0x000000018D35BB88-0x000000018D35BBA4
			public void SetCallbacks(IPlayerActions instance); // 0x000000018D35B344-0x000000018D35BB2C
		}
	
		public struct UIActions // TypeDefIndex: 72292
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Navigate { get; } // 0x000000018D368394-0x000000018D3683B0 
			public InputAction Submit { get; } // 0x000000018D368408-0x000000018D368424 
			public InputAction Cancel { get; } // 0x000000018D36833C-0x000000018D368358 
			public InputAction Point { get; } // 0x000000018D3683B0-0x000000018D3683CC 
			public InputAction Click { get; } // 0x000000018D368358-0x000000018D368374 
			public InputAction ScrollWheel { get; } // 0x000000018D3683EC-0x000000018D368408 
			public InputAction MiddleClick { get; } // 0x000000018D368374-0x000000018D368394 
			public InputAction RightClick { get; } // 0x000000018D3683CC-0x000000018D3683EC 
			public InputAction TrackedDevicePosition { get; } // 0x000000018D368444-0x000000018D368464 
			public InputAction TrackedDeviceOrientation { get; } // 0x000000018D368424-0x000000018D368444 
			public bool enabled { get; } // 0x000000018D368464-0x000000018D368488 
	
			// Constructors
			public UIActions(DefaultInputActions wrapper); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			public InputActionMap Get(); // 0x000000018783655C-0x0000000187836578
			public void Enable(); // 0x000000018D366A00-0x000000018D366A24
			public void Disable(); // 0x000000018D3669DC-0x000000018D366A00
			public static implicit operator InputActionMap(UIActions set); // 0x000000018D368488-0x000000018D3684A4
			public void SetCallbacks(IUIActions instance); // 0x000000018D366A24-0x000000018D36833C
		}
	
		public interface IPlayerActions // TypeDefIndex: 72293
		{
			// Methods
			void OnMove(InputAction.CallbackContext context);
			void OnLook(InputAction.CallbackContext context);
			void OnFire(InputAction.CallbackContext context);
		}
	
		public interface IUIActions // TypeDefIndex: 72294
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
		public DefaultInputActions(); // 0x000000018D352B14-0x000000018D352EDC
	
		// Methods
		public void Dispose(); // 0x000000018D3529F8-0x000000018D352A48
		public bool Contains(InputAction action); // 0x000000018D3529B8-0x000000018D3529D8
		public IEnumerator<InputAction> GetEnumerator(); // 0x000000018D352AEC-0x000000018D352B0C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D352B0C-0x000000018D352B14
		public void Enable(); // 0x000000018D352A48-0x000000018D352A68
		public void Disable(); // 0x000000018D3529D8-0x000000018D3529F8
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x02622BF7 */); // 0x000000018D352A68-0x000000018D352A88
		public int FindBinding(InputBinding bindingMask, out InputAction action); // 0x000000018D352A88-0x000000018D352AEC
	}

	[DebuggerDisplay("Value = {Get()}")]
	public class InputValue // TypeDefIndex: 72296
	{
		// Fields
		internal InputAction.CallbackContext? m_Context; // 0x10
	
		// Properties
		public bool isPressed { get; } // 0x000000018D35B2A0-0x000000018D35B2FC 
	
		// Constructors
		public InputValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public object Get(); // 0x000000018D35B248-0x000000018D35B2A0
		public TValue Get<TValue>()
			where TValue : struct;
	}

	[AddComponentMenu("Input/Player Input")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInput.html")]
	public class PlayerInput : MonoBehaviour // TypeDefIndex: 72301
	{
		// Fields
		public const string DeviceLostMessage = "OnDeviceLost"; // Metadata: 0x02622BFC
		public const string DeviceRegainedMessage = "OnDeviceRegained"; // Metadata: 0x02622C09
		public const string ControlsChangedMessage = "OnControlsChanged"; // Metadata: 0x02622C1A
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
		public bool inputIsActive { get; } // 0x000000018723FB20-0x000000018723FB30 
		[Obsolete("Use inputIsActive instead.")]
		public bool active { get; } // 0x000000018723FB20-0x000000018723FB30 
		public int playerIndex { get; } // 0x00000001872333B0-0x00000001872333C0 
		public int splitScreenIndex { get; } // 0x0000000187233370-0x0000000187233380 
		public InputActionAsset actions { get; set; } // 0x000000018D362990-0x000000018D3629D8 0x000000018D3630EC-0x000000018D36321C
		public string currentControlScheme { get; } // 0x000000018D362AC0-0x000000018D362B5C 
		public string defaultControlScheme { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public bool neverAutoSwitchControlSchemes { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018D36328C-0x000000018D3632D0
		public InputActionMap currentActionMap { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x000000018D36321C-0x000000018D36328C
		public string defaultActionMap { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public PlayerNotifications notificationBehavior { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x000000018D3632D0-0x000000018D363318
		public ReadOnlyArray<ActionEvent> actionEvents { get; set; } // 0x000000018D362938-0x000000018D362990 0x000000018D363070-0x000000018D3630EC
		public DeviceLostEvent deviceLostEvent { get; } // 0x000000018D362B5C-0x000000018D362BCC 
		public DeviceRegainedEvent deviceRegainedEvent { get; } // 0x000000018D362BCC-0x000000018D362C3C 
		public ControlsChangedEvent controlsChangedEvent { get; } // 0x000000018D362A50-0x000000018D362AC0 
		public Camera camera { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public InputSystemUIInputModule uiInputModule { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018D363318-0x000000018D36345C
		public InputUser user { get; } // 0x0000000187235C10-0x0000000187235C20 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x000000018D362C3C-0x000000018D362CC0 
		public bool hasMissingRequiredDevices { get; } // 0x000000018D362CC0-0x000000018D362D38 
		public static ReadOnlyArray<PlayerInput> all { get; } // 0x000000018D3629D8-0x000000018D362A50 
		public static bool isSinglePlayer { get; } // 0x000000018D362D38-0x000000018D362DD0 
	
		// Events
		public event Action<InputAction.CallbackContext> onActionTriggered {
			add; // 0x000000018D362698-0x000000018D362740
			remove; // 0x000000018D362DD0-0x000000018D362E78
		}
		public event Action<PlayerInput> onDeviceLost {
			add; // 0x000000018D3627E8-0x000000018D362890
			remove; // 0x000000018D362F20-0x000000018D362FC8
		}
		public event Action<PlayerInput> onDeviceRegained {
			add; // 0x000000018D362890-0x000000018D362938
			remove; // 0x000000018D362FC8-0x000000018D363070
		}
		public event Action<PlayerInput> onControlsChanged {
			add; // 0x000000018D362740-0x000000018D3627E8
			remove; // 0x000000018D362E78-0x000000018D362F20
		}
	
		// Nested types
		[Serializable]
		public class ActionEvent : UnityEvent<InputAction.CallbackContext> // TypeDefIndex: 72297
		{
			// Fields
			[SerializeField]
			private string m_ActionId; // 0x30
			[SerializeField]
			private string m_ActionName; // 0x38
	
			// Properties
			public string actionId { get; } // 0x00000001829600D0-0x00000001829600E0 
			public string actionName { get; } // 0x0000000182986470-0x0000000182986480 
	
			// Constructors
			public ActionEvent(); // 0x000000018D3521CC-0x000000018D352208
			public ActionEvent(InputAction action); // 0x000000018D352208-0x000000018D352464
			public ActionEvent(Guid actionGUID, string name = null); // 0x000000018D352464-0x000000018D3524F4
		}
	
		[Serializable]
		public class DeviceLostEvent : UnityEvent<PlayerInput> // TypeDefIndex: 72298
		{
			// Constructors
			public DeviceLostEvent(); // 0x000000018D35342C-0x000000018D353468
		}
	
		[Serializable]
		public class DeviceRegainedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 72299
		{
			// Constructors
			public DeviceRegainedEvent(); // 0x000000018D353468-0x000000018D3534A4
		}
	
		[Serializable]
		public class ControlsChangedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 72300
		{
			// Constructors
			public ControlsChangedEvent(); // 0x000000018D35297C-0x000000018D3529B8
		}
	
		// Constructors
		public PlayerInput(); // 0x000000018D362670-0x000000018D362698
		static PlayerInput(); // 0x000000018D362620-0x000000018D362670
	
		// Methods
		public TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public void ActivateInput(); // 0x000000018D35DA9C-0x000000018D35DB40
		private void UpdateDelegates(); // 0x000000018D362444-0x000000018D362620
		public void DeactivateInput(); // 0x000000018D35EDAC-0x000000018D35EDD8
		[Obsolete("Use DeactivateInput instead.")]
		public void PassivateInput(); // 0x000000018D36121C-0x000000018D361224
		public bool SwitchCurrentControlScheme(params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018D361A58-0x000000018D361C50
		public void SwitchCurrentControlScheme(string controlScheme, params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018D361C50-0x000000018D361D9C
		public void SwitchCurrentActionMap(string mapNameOrId); // 0x000000018D361928-0x000000018D361A58
		public static PlayerInput GetPlayerByIndex(int playerIndex); // 0x000000018D35F1E4-0x000000018D35F2CC
		public static PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D35F05C-0x000000018D35F1E4
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x02622BF8 */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x02622BF9 */, UnityEngine.InputSystem.InputDevice pairWithDevice = null); // 0x000000018D35FD8C-0x000000018D35FF24
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x02622BFA */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x02622BFB */, params UnityEngine.InputSystem.InputDevice[] pairWithDevices); // 0x000000018D35FBCC-0x000000018D35FD8C
		private static PlayerInput DoInstantiate(GameObject prefab); // 0x000000018D35EE28-0x000000018D35F05C
		private void InitializeActions(); // 0x000000018D35F694-0x000000018D35FA0C
		private void CopyActionAssetAndApplyBindingOverrides(); // 0x000000018D35EB6C-0x000000018D35EDAC
		private void UninitializeActions(); // 0x000000018D3620DC-0x000000018D3622E0
		private void InstallOnActionTriggeredHook(); // 0x000000018D35FA0C-0x000000018D35FBCC
		private void UninstallOnActionTriggeredHook(); // 0x000000018D3622E0-0x000000018D362444
		private void OnActionTriggered(InputAction.CallbackContext context); // 0x000000018D35FF24-0x000000018D360130
		private void CacheMessageNames(); // 0x000000018D35E84C-0x000000018D35EB24
		private void ClearCaches(); // 0x000000018D35EB24-0x000000018D35EB6C
		private void AssignUserAndDevices(); // 0x000000018D35DD10-0x000000018D35E7EC
		private bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D35F5A8-0x000000018D35F694
		private void UnassignUserAndDevices(); // 0x000000018D36200C-0x000000018D3620DC
		private bool TryToActivateControlScheme(InputControlScheme controlScheme); // 0x000000018D361D9C-0x000000018D36200C
		private void AssignPlayerIndex(); // 0x000000018D35DB40-0x000000018D35DD10
		private void Awake(); // 0x000000018D35E7EC-0x000000018D35E84C
		private void OnEnable(); // 0x000000018D360464-0x000000018D3608DC
		private void StartListeningForUnpairedDeviceActivity(); // 0x000000018D3612EC-0x000000018D361434
		private void StopListeningForUnpairedDeviceActivity(); // 0x000000018D361498-0x000000018D361518
		private void StartListeningForDeviceChanges(); // 0x000000018D361224-0x000000018D3612EC
		private void StopListeningForDeviceChanges(); // 0x000000018D361434-0x000000018D361498
		private void OnDisable(); // 0x000000018D360258-0x000000018D360464
		public void DebugLogAction(InputAction.CallbackContext context); // 0x000000018D35EDD8-0x000000018D35EE28
		private void HandleDeviceLost(); // 0x000000018D35F3C0-0x000000018D35F4B4
		private void HandleDeviceRegained(); // 0x000000018D35F4B4-0x000000018D35F5A8
		private void HandleControlsChanged(); // 0x000000018D35F2CC-0x000000018D35F3C0
		private static void OnUserChange(InputUser user, InputUserChange change, UnityEngine.InputSystem.InputDevice device); // 0x000000018D361048-0x000000018D36121C
		private static bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr); // 0x000000018D3608DC-0x000000018D3609D4
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr); // 0x000000018D3609D4-0x000000018D361048
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018D360130-0x000000018D360258
		private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params UnityEngine.InputSystem.InputDevice[] devices); // 0x000000018D361518-0x000000018D361928
	}

	[AddComponentMenu("Input/Player Input Manager")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInputManager.html")]
	public class PlayerInputManager : MonoBehaviour // TypeDefIndex: 72304
	{
		// Fields
		public const string PlayerJoinedMessage = "OnPlayerJoined"; // Metadata: 0x02622C31
		public const string PlayerLeftMessage = "OnPlayerLeft"; // Metadata: 0x02622C40
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
		public bool splitScreen { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018D35D8C0-0x000000018D35DA9C
		public bool maintainAspectRatioInSplitScreen { get; } // 0x0000000182271B50-0x0000000182271B60 
		public int fixedNumberOfSplitScreens { get; } // 0x0000000187233600-0x0000000187233610 
		public Rect splitScreenArea { get; } // 0x000000018724F4E0-0x000000018724F4F0 
		public int playerCount { get; } // 0x000000018D35D500-0x000000018D35D550 
		public int maxPlayerCount { get; } // 0x0000000187233000-0x0000000187233010 
		public bool joiningEnabled { get; } // 0x0000000182246E50-0x0000000182246E60 
		public PlayerJoinBehavior joinBehavior { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x000000018D35D874-0x000000018D35D8C0
		public InputActionProperty joinAction { get; set; } // 0x000000018723D0D0-0x000000018723D0F0 0x000000018D35D7D0-0x000000018D35D874
		public PlayerNotifications notificationBehavior { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public PlayerJoinedEvent playerJoinedEvent { get; } // 0x000000018D35D550-0x000000018D35D5C0 
		public PlayerLeftEvent playerLeftEvent { get; } // 0x000000018D35D5C0-0x000000018D35D630 
		public GameObject playerPrefab { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public static PlayerInputManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D35D440-0x000000018D35D478 0x000000018D35D780-0x000000018D35D7D0
		internal static string[] messages { get; } // 0x000000018D35D478-0x000000018D35D500 
	
		// Events
		public event Action<PlayerInput> onPlayerJoined {
			add; // 0x000000018D35D2F0-0x000000018D35D398
			remove; // 0x000000018D35D630-0x000000018D35D6D8
		}
		public event Action<PlayerInput> onPlayerLeft {
			add; // 0x000000018D35D398-0x000000018D35D440
			remove; // 0x000000018D35D6D8-0x000000018D35D780
		}
	
		// Nested types
		[Serializable]
		public class PlayerJoinedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 72302
		{
			// Constructors
			public PlayerJoinedEvent(); // 0x000000018D36345C-0x000000018D363498
		}
	
		[Serializable]
		public class PlayerLeftEvent : UnityEvent<PlayerInput> // TypeDefIndex: 72303
		{
			// Constructors
			public PlayerLeftEvent(); // 0x000000018D363498-0x000000018D3634D4
		}
	
		// Constructors
		public PlayerInputManager(); // 0x000000018D35D2BC-0x000000018D35D2F0
	
		// Methods
		public void EnableJoining(); // 0x000000018D35BF08-0x000000018D35C0E0
		public void DisableJoining(); // 0x000000018D35BE2C-0x000000018D35BF08
		internal void JoinPlayerFromUI(); // 0x000000018D35C620-0x000000018D35C680
		public void JoinPlayerFromAction(InputAction.CallbackContext context); // 0x000000018D35C5BC-0x000000018D35C620
		public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context); // 0x000000018D35C4EC-0x000000018D35C5BC
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x02622C2C */, int splitScreenIndex = -1 /* Metadata: 0x02622C2D */, string controlScheme = null, UnityEngine.InputSystem.InputDevice pairWithDevice = null); // 0x000000018D35C680-0x000000018D35C728
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x02622C2E */, int splitScreenIndex = -1 /* Metadata: 0x02622C2F */, string controlScheme = null, params UnityEngine.InputSystem.InputDevice[] pairWithDevices); // 0x000000018D35C728-0x000000018D35C7D0
		private bool CheckIfPlayerCanJoin(int playerIndex = -1 /* Metadata: 0x02622C30 */); // 0x000000018D35BBA4-0x000000018D35BE2C
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr); // 0x000000018D35CD2C-0x000000018D35CDC4
		private void OnEnable(); // 0x000000018D35CA4C-0x000000018D35CD2C
		private void OnDisable(); // 0x000000018D35C9D8-0x000000018D35CA4C
		private void UpdateSplitScreen(); // 0x000000018D35CDC4-0x000000018D35D2BC
		private bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device); // 0x000000018D35C0E0-0x000000018D35C4EC
		private void ValidateInputActionAsset(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void NotifyPlayerJoined(PlayerInput player); // 0x000000018D35C7D0-0x000000018D35C8D4
		internal void NotifyPlayerLeft(PlayerInput player); // 0x000000018D35C8D4-0x000000018D35C9D8
	}

	public enum PlayerJoinBehavior // TypeDefIndex: 72305
	{
		JoinPlayersWhenButtonIsPressed = 0,
		JoinPlayersWhenJoinActionIsTriggered = 1,
		JoinPlayersManually = 2
	}

	public enum PlayerNotifications // TypeDefIndex: 72306
	{
		SendMessages = 0,
		BroadcastMessages = 1,
		InvokeUnityEvents = 2,
		InvokeCSharpEvents = 3
	}

	internal struct DynamicBitfield // TypeDefIndex: 72307
	{
		// Fields
		public InlinedArray<ulong> array; // 0x00
		public int length; // 0x18
	
		// Methods
		public void SetLength(int newLength); // 0x0000000185B02160-0x0000000185B021C0
		public void SetBit(int bitIndex); // 0x00000001860F4440-0x00000001860F44C0
		public bool TestBit(int bitIndex); // 0x00000001853B1330-0x00000001853B13A0
		public void ClearBit(int bitIndex); // 0x00000001860F43C0-0x00000001860F4440
		public bool AnyBitIsSet(); // 0x00000001862AE100-0x00000001862AE170
		private static int BitCountToULongCount(int bitCount); // 0x0000000187259EE0-0x0000000187259EF0
	}
}

namespace UnityEngine.InputSystem.Composites
{
	[System.ComponentModel.DisplayName("Positive/Negative Binding")]
	[DisplayStringFormat("{negative}/{positive}")]
	public class AxisComposite : InputBindingComposite<float> // TypeDefIndex: 72708
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
		public float midPoint { get; } // 0x0000000187259A60-0x0000000187259A80 
	
		// Nested types
		public enum WhichSideWins // TypeDefIndex: 72707
		{
			Neither = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		public AxisComposite(); // 0x000000018D30CFD4-0x000000018D30D020
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018D30CED0-0x000000018D30CFD4
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D30CE40-0x000000018D30CED0
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier}+{button}")]
	public class ButtonWithOneModifier : InputBindingComposite<float> // TypeDefIndex: 72710
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
		public enum ModifiersOrder // TypeDefIndex: 72709
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithOneModifier(); // 0x000000018D30D164-0x000000018D30D18C
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018D30D104-0x000000018D30D164
		private bool ModifierIsPressed(ref InputBindingCompositeContext context); // 0x000000018D30D0A0-0x000000018D30D104
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D30D020-0x000000018D30D034
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018D30D034-0x000000018D30D0A0
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
	public class ButtonWithTwoModifiers : InputBindingComposite<float> // TypeDefIndex: 72712
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
		public enum ModifiersOrder // TypeDefIndex: 72711
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithTwoModifiers(); // 0x000000018D30D2F8-0x000000018D30D320
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context); // 0x000000018D30D298-0x000000018D30D2F8
		private bool ModifiersArePressed(ref InputBindingCompositeContext context); // 0x000000018D30D1F8-0x000000018D30D298
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D30D020-0x000000018D30D034
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018D30D18C-0x000000018D30D1F8
	}

	[System.ComponentModel.DisplayName("Binding With One Modifier")]
	[DisplayStringFormat("{modifier}+{binding}")]
	public class OneModifierComposite : InputBindingComposite // TypeDefIndex: 72714
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
		public override System.Type valueType { get; } // 0x0000000182262130-0x0000000182262140 
		public override int valueSizeInBytes { get; } // 0x000000018226A850-0x000000018226A860 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 72713
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public OneModifierComposite(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D30F0D8-0x000000018D30F114
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize); // 0x000000018D30F25C-0x000000018D30F2C8
		private bool ModifierIsPressed(ref InputBindingCompositeContext context); // 0x000000018D30F1B0-0x000000018D30F21C
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018D30F114-0x000000018D30F1B0
		public override object ReadValueAsObject(ref InputBindingCompositeContext context); // 0x000000018D30F21C-0x000000018D30F25C
		internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out System.Type valueType, out int valueSizeInBytes, out bool isButton); // 0x000000018D30EDEC-0x000000018D30F0D8
	}

	[System.ComponentModel.DisplayName("Binding With Two Modifiers")]
	[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
	public class TwoModifiersComposite : InputBindingComposite // TypeDefIndex: 72716
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
		public override System.Type valueType { get; } // 0x0000000182262130-0x0000000182262140 
		public override int valueSizeInBytes { get; } // 0x0000000182A819B0-0x0000000182A819C0 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 72715
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public TwoModifiersComposite(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D311E6C-0x000000018D311EA8
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize); // 0x000000018D31203C-0x000000018D3120A8
		private bool ModifiersArePressed(ref InputBindingCompositeContext context); // 0x000000018D311F44-0x000000018D311FE8
		protected override void FinishSetup(ref InputBindingCompositeContext context); // 0x000000018D311EA8-0x000000018D311F44
		public override object ReadValueAsObject(ref InputBindingCompositeContext context); // 0x000000018D311FE8-0x000000018D31203C
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right Composite")]
	[DisplayStringFormat("{up}/{left}/{down}/{right}")]
	public class Vector2Composite : InputBindingComposite<Vector2> // TypeDefIndex: 72718
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
		public enum Mode // TypeDefIndex: 72717
		{
			DigitalNormalized = 0,
			Digital = 1,
			Analog = 2
		}
	
		// Constructors
		public Vector2Composite(); // 0x00000001871CB4A0-0x00000001871CB4E0
	
		// Methods
		public override Vector2 ReadValue(ref InputBindingCompositeContext context); // 0x000000018D313378-0x000000018D3134D8
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D313354-0x000000018D313378
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
	[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
	public class Vector3Composite : InputBindingComposite<Vector3> // TypeDefIndex: 72720
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
		public enum Mode // TypeDefIndex: 72719
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}
	
		// Constructors
		public Vector3Composite(); // 0x000000018D313738-0x000000018D313854
	
		// Methods
		public override Vector3 ReadValue(ref InputBindingCompositeContext context); // 0x000000018D31350C-0x000000018D313738
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context); // 0x000000018D3134D8-0x000000018D31350C
	}
}

namespace UnityEngine.InputSystem.Controls
{
	[InputControlLayout(hideInUI = true)]
	public class AnyKeyControl : ButtonControl // TypeDefIndex: 72619
	{
		// Constructors
		public AnyKeyControl(); // 0x0000000186671320-0x0000000186671390
	
		// Methods
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x00000001869FB310-0x00000001869FB380
	}

	public class AxisControl : InputControl<float> // TypeDefIndex: 72621
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
		public enum Clamp // TypeDefIndex: 72620
		{
			None = 0,
			BeforeNormalize = 1,
			AfterNormalize = 2,
			ToConstantBeforeNormalize = 3
		}
	
		// Constructors
		public AxisControl(); // 0x0000000186671470-0x00000001866714C0
	
		// Methods
		protected float Preprocess(float value); // 0x000000018D3004EC-0x000000018D3005D8
		private float Unpreprocess(float value); // 0x000000018D3005D8-0x000000018D30063C
		protected override void FinishSetup(); // 0x000000018D30041C-0x000000018D3004EC
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x00000001853B0AD0-0x00000001853B0C00
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018D30063C-0x000000018D3006EC
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr); // 0x000000018D30035C-0x000000018D30041C
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x0000000186535E20-0x0000000186535E50
		private float EvaluateMagnitude(float value); // 0x0000000186535E50-0x0000000186535F00
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D300224-0x000000018D30035C
	}

	public class ButtonControl : AxisControl // TypeDefIndex: 72622
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
		internal const float kMinButtonPressPoint = 0.0001f; // Metadata: 0x02623053
	
		// Properties
		internal bool needsToCheckFramePress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187259900-0x0000000187259910 0x0000000187259910-0x0000000187259920
		public float pressPointOrDefault { get; } // 0x000000018526CED0-0x000000018526CF00 
		public bool isPressed { get; } // 0x00000001851D5CB0-0x00000001851D5E20 
		public bool wasPressedThisFrame { get; } // 0x00000001851D5BF0-0x00000001851D5CB0 
		public bool wasReleasedThisFrame { get; } // 0x00000001851D37D0-0x00000001851D5BA0 
	
		// Constructors
		public ButtonControl(); // 0x0000000186671390-0x0000000186671470
	
		// Methods
		public new bool IsValueConsideredPressed(float value); // 0x000000018D3006EC-0x000000018D30071C
		private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame); // 0x00000001869D2B20-0x00000001869D2BC0
		internal void UpdateWasPressed(); // 0x000000018526CE30-0x000000018526CED0
	}

	[UnityEngine.Scripting.Preserve]
	public class DeltaControl : Vector2Control // TypeDefIndex: 72623
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
		public AxisControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5E0-0x000000018723B5F0 0x000000018783BF50-0x000000018783BF64
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Down")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Left")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Right")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
	
		// Constructors
		public DeltaControl(); // 0x000000018D300E48-0x000000018D300E50
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D300D40-0x000000018D300E48
	}

	public class DiscreteButtonControl : ButtonControl // TypeDefIndex: 72625
	{
		// Fields
		public int minValue; // 0x148
		public int maxValue; // 0x14C
		public int wrapAtValue; // 0x150
		public int nullValue; // 0x154
		public WriteMode writeMode; // 0x158
	
		// Nested types
		public enum WriteMode // TypeDefIndex: 72624
		{
			WriteDisabled = 0,
			WriteNullAndMaxValue = 1
		}
	
		// Constructors
		public DiscreteButtonControl(); // 0x000000018783BF48-0x000000018783BF50
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D300E50-0x000000018D300F64
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D300F64-0x000000018D301024
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018D301024-0x000000018D30112C
	}

	public class DoubleControl : InputControl<double> // TypeDefIndex: 72626
	{
		// Constructors
		public DoubleControl(); // 0x000000018D3011EC-0x000000018D301250
	
		// Methods
		public override unsafe double ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30112C-0x000000018D301188
		public override unsafe void WriteValueIntoState(double value, void* statePtr); // 0x000000018D301188-0x000000018D3011EC
	}

	public class DpadControl : Vector2Control // TypeDefIndex: 72629
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
		public ButtonControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5E0-0x000000018723B5F0 0x000000018783BF50-0x000000018783BF64
		[InputControl(bit = 1, displayName = "Down")]
		public ButtonControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		[InputControl(bit = 2, displayName = "Left")]
		public ButtonControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		[InputControl(bit = 3, displayName = "Right")]
		public ButtonControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
	
		// Nested types
		[InputControlLayout(hideInUI = true)]
		public class DpadAxisControl : AxisControl // TypeDefIndex: 72627
		{
			// Fields
			[CompilerGenerated]
			private int _component_k__BackingField; // 0x130
	
			// Properties
			public int component { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723E940-0x000000018723E950 0x000000018723E980-0x000000018723E990
	
			// Constructors
			public DpadAxisControl(); // 0x000000018D301368-0x000000018D301370
	
			// Methods
			protected override void FinishSetup(); // 0x000000018D301250-0x000000018D3012D4
			public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D3012D4-0x000000018D301368
		}
	
		internal enum ButtonBits // TypeDefIndex: 72628
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}
	
		// Constructors
		public DpadControl(); // 0x000000018D3017E8-0x000000018D301844
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D301370-0x000000018D301478
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D3014EC-0x000000018D301670
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr); // 0x000000018D301670-0x000000018D3017E8
		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true /* Metadata: 0x02623059 */); // 0x000000018D301478-0x000000018D3014EC
		public static Vector2 MakeDpadVector(float up, float down, float left, float right); // 0x0000000187259920-0x0000000187259940
	}

	public class IntegerControl : InputControl<int> // TypeDefIndex: 72630
	{
		// Constructors
		public IntegerControl(); // 0x000000018709FE00-0x000000018709FE80
	
		// Methods
		public override unsafe int ReadUnprocessedValueFromState(void* statePtr); // 0x00000001861A8F10-0x00000001861A8F70
		public override unsafe void WriteValueIntoState(int value, void* statePtr); // 0x000000018D308720-0x000000018D3087A8
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D308678-0x000000018D308720
	}

	public class KeyControl : ButtonControl // TypeDefIndex: 72631
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.Key _keyCode_k__BackingField; // 0x148
		private int m_ScanCode; // 0x14C
	
		// Properties
		public UnityEngine.InputSystem.Key keyCode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187241320-0x0000000187241330 0x0000000187241340-0x0000000187241350
		public int scanCode { get; } // 0x000000018D30A2C8-0x000000018D30A2E4 
	
		// Constructors
		public KeyControl(); // 0x000000018783BF48-0x000000018783BF50
	
		// Methods
		protected override void RefreshConfiguration(); // 0x000000018D30A114-0x000000018D30A2C8
	}

	public class QuaternionControl : InputControl<Quaternion> // TypeDefIndex: 72632
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
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5E0-0x000000018723B5F0 0x000000018783BF50-0x000000018783BF64
		[InputControl(displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		[InputControl(displayName = "Z")]
		public AxisControl z { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		[InputControl(displayName = "W")]
		public AxisControl w { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
	
		// Constructors
		public QuaternionControl(); // 0x000000018D30B380-0x000000018D30B3E8
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30B054-0x000000018D30B170
		public override unsafe Quaternion ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30B170-0x000000018D30B2AC
		public override unsafe void WriteValueIntoState(Quaternion value, void* statePtr); // 0x000000018D30B2AC-0x000000018D30B380
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D30AE08-0x000000018D30B054
	}

	public class StickControl : Vector2Control // TypeDefIndex: 72633
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
		public ButtonControl up { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5E0-0x000000018723B5F0 0x000000018783BF50-0x000000018783BF64
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Down")]
		public ButtonControl down { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Left")]
		public ButtonControl left { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Right")]
		public ButtonControl right { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
	
		// Constructors
		public StickControl(); // 0x000000018D300E48-0x000000018D300E50
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30B5D0-0x000000018D30B6D8
	}

	[InputControlLayout(stateType = typeof(TouchState))]
	public class TouchControl : InputControl<TouchState> // TypeDefIndex: 72634
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
		public TouchPressControl press { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C230-0x000000018723C240 0x0000000188DC4DE0-0x0000000188DC4DF4
		public IntegerControl displayIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BA40-0x000000018723BA50 0x0000000188DC4DCC-0x0000000188DC4DE0
		public IntegerControl touchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C0D0-0x000000018723C0E0 0x0000000188DC4B88-0x0000000188DC4B9C
		public Vector2Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B990-0x000000018723B9A0 0x0000000188DC473C-0x0000000188DC4750
		public DeltaControl delta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public AxisControl pressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public Vector2Control radius { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public TouchPhaseControl phase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public ButtonControl indirectTouch { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		public ButtonControl tap { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		public IntegerControl tapCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		public DoubleControl startTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		public Vector2Control startPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		public bool isInProgress { get; } // 0x000000018D30BD44-0x000000018D30BDA4 
	
		// Constructors
		public TouchControl(); // 0x000000018D30BCF0-0x000000018D30BD44
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30B8A4-0x000000018D30BBF4
		public override unsafe TouchState ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30BBF4-0x000000018D30BC70
		public override unsafe void WriteValueIntoState(TouchState value, void* statePtr); // 0x000000018D30BC70-0x000000018D30BCF0
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPhaseControl : InputControl<UnityEngine.InputSystem.TouchPhase> // TypeDefIndex: 72635
	{
		// Constructors
		public TouchPhaseControl(); // 0x000000018D30BE64-0x000000018D30BEC8
	
		// Methods
		public override unsafe UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30BDA4-0x000000018D30BE04
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr); // 0x000000018D30BE04-0x000000018D30BE64
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPressControl : ButtonControl // TypeDefIndex: 72636
	{
		// Constructors
		public TouchPressControl(); // 0x000000018783BF48-0x000000018783BF50
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30BEC8-0x000000018D30BFDC
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30BFDC-0x000000018D30C058
		public override unsafe void WriteValueIntoState(float value, void* statePtr); // 0x000000018D30C058-0x000000018D30C0A4
	}

	public class Vector2Control : InputControl<Vector2> // TypeDefIndex: 72637
	{
		// Fields
		[CompilerGenerated]
		private AxisControl _x_k__BackingField; // 0x110
		[CompilerGenerated]
		private AxisControl _y_k__BackingField; // 0x118
	
		// Properties
		[InputControl(offset = 0, displayName = "X")]
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B410-0x000000018723B420 0x000000018783BFB4-0x000000018783BFC8
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232D10-0x0000000187232D20 0x000000018783BFA0-0x000000018783BFB4
	
		// Constructors
		public Vector2Control(); // 0x0000000186FCC710-0x0000000186FCC790
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30C6CC-0x000000018D30C77C
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr); // 0x0000000186125C20-0x0000000186125DB0
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr); // 0x000000018D30C77C-0x000000018D30C828
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x00000001864EE400-0x00000001864EE470
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D30C5A4-0x000000018D30C6CC
	}

	public class Vector3Control : InputControl<Vector3> // TypeDefIndex: 72638
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
		public AxisControl x { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232D10-0x0000000187232D20 0x000000018783BFA0-0x000000018783BFB4
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5E0-0x000000018723B5F0 0x000000018783BF50-0x000000018783BF64
		[InputControl(offset = 8, displayName = "Z")]
		public AxisControl z { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
	
		// Constructors
		public Vector3Control(); // 0x000000018D30CD28-0x000000018D30CD8C
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D30CA80-0x000000018D30CB64
		public override unsafe Vector3 ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D30CB64-0x000000018D30CC64
		public override unsafe void WriteValueIntoState(Vector3 value, void* statePtr); // 0x000000018D30CC64-0x000000018D30CD28
		public override unsafe float EvaluateMagnitude(void* statePtr); // 0x000000018D30CA14-0x000000018D30CA80
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D30C87C-0x000000018D30CA14
	}
}

namespace UnityEngine.InputSystem.DualShock
{
	[InputControlLayout(displayName = "PlayStation Controller")]
	public class DualShockGamepad : Gamepad, IDualShockHaptics // TypeDefIndex: 72430
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
		public ButtonControl touchpadButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(name = "start", displayName = "Options")]
		public ButtonControl optionsButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		[InputControl(name = "select", displayName = "Share")]
		public ButtonControl shareButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD00-0x000000018723BD10 0x0000000188DC4534-0x0000000188DC4548
		[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
		public ButtonControl L1 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B240-0x000000018723B250 0x0000000188DC455C-0x0000000188DC4570
		[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
		public ButtonControl R1 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B310-0x000000018723B320 0x0000000188D3C0D0-0x0000000188D3C0E4
		[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
		public ButtonControl L2 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BEC0-0x000000018723BED0 0x0000000188DC482C-0x0000000188DC4840
		[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
		public ButtonControl R2 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BEB0-0x000000018723BEC0 0x0000000188DC4818-0x0000000188DC482C
		[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
		public ButtonControl L3 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C1C0-0x000000018723C1D0 0x0000000188DC4D04-0x0000000188DC4D18
		[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
		public ButtonControl R3 { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCE0-0x000000018723BCF0 0x0000000188DC44F8-0x0000000188DC450C
		public static new DualShockGamepad current { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D37709C-0x000000018D3770D4 0x000000018D3770D4-0x000000018D377124
		internal HID.HIDDeviceDescriptor hidDescriptor { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018725A6F0-0x000000018725A720 0x000000018D377124-0x000000018D377150
	
		// Constructors
		public DualShockGamepad(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public override void MakeCurrent(); // 0x000000018D37702C-0x000000018D377048
		protected override void OnRemoved(); // 0x000000018D377048-0x000000018D37709C
		protected override void FinishSetup(); // 0x000000018D376E80-0x000000018D37702C
		public virtual void SetLightBarColor(UnityEngine.Color color); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
	public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 72435
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
		internal const byte JitterMaskLow = 120; // Metadata: 0x02622E5E
		internal const byte JitterMaskHigh = 135; // Metadata: 0x02622E5F
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B2A0-0x000000018723B2B0 0x0000000188D36D24-0x0000000188D36D38
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCC0-0x000000018723BCD0 0x0000000188DC44D0-0x0000000188DC44E4
	
		// Nested types
		internal struct DualSenseHIDGenericInputReport // TypeDefIndex: 72431
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get; } // 0x000000018725A260-0x000000018725A270 
		}
	
		internal struct DualSenseHIDUSBInputReport // TypeDefIndex: 72432
		{
			// Fields
			public const int ExpectedReportId = 1; // Metadata: 0x02622E60
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
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x000000018725A600-0x000000018725A650
		}
	
		internal struct DualSenseHIDBluetoothInputReport // TypeDefIndex: 72433
		{
			// Fields
			public const int ExpectedReportId = 49; // Metadata: 0x02622E61
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
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x000000018725A4F0-0x000000018725A540
		}
	
		internal struct DualSenseHIDMinimalInputReport // TypeDefIndex: 72434
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
			static DualSenseHIDMinimalInputReport(); // 0x000000018D3761B0-0x000000018D376200
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport(); // 0x000000018725A5B0-0x000000018725A600
		}
	
		// Constructors
		public DualSenseGamepadHID(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3755A4-0x000000018D375678
		public override void PauseHaptics(); // 0x000000018D375894-0x000000018D375940
		public override void ResetHaptics(); // 0x000000018D375940-0x000000018D3759C8
		public override void ResumeHaptics(); // 0x000000018D3759C8-0x000000018D375A40
		public override void SetLightBarColor(UnityEngine.Color color); // 0x000000018D375A40-0x000000018D375AD4
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018D375CE4-0x000000018D375DB0
		public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, UnityEngine.Color? color); // 0x000000018D375AD4-0x000000018D375CE4
		private static unsafe bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState); // 0x000000018D375678-0x000000018D3756B0
		private static unsafe bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState); // 0x000000018D3756B0-0x000000018D3756E8
		private static unsafe bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState); // 0x000000018D3756E8-0x000000018D375720
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr); // 0x000000018D375DB0-0x000000018D375F5C
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr); // 0x000000018D375F5C-0x000000018D376124
		public void OnNextUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D375720-0x000000018D375894
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001843FFFF0-0x0000000184400000
	}

	[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = true, isNoisy = true)]
	public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 72437
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
		internal const byte JitterMaskLow = 120; // Metadata: 0x02622E62
		internal const byte JitterMaskHigh = 135; // Metadata: 0x02622E63
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B2A0-0x000000018723B2B0 0x0000000188D36D24-0x0000000188D36D38
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCC0-0x000000018723BCD0 0x0000000188DC44D0-0x0000000188DC44E4
	
		// Nested types
		internal struct DualShock4HIDGenericInputReport // TypeDefIndex: 72436
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
			public static FourCC Format { get; } // 0x000000018725A260-0x000000018725A270 
	
			// Methods
			public DualShock4HIDInputReport ToHIDInputReport(); // 0x000000018725A6A0-0x000000018725A6F0
		}
	
		// Constructors
		public DualShock4GamepadHID(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3762D4-0x000000018D3763A8
		public override void PauseHaptics(); // 0x000000018D37651C-0x000000018D376638
		public override void ResetHaptics(); // 0x000000018D376638-0x000000018D376774
		public override void ResumeHaptics(); // 0x000000018D376774-0x000000018D3768FC
		public override void SetLightBarColor(UnityEngine.Color color); // 0x000000018D3768FC-0x000000018D376A04
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency); // 0x000000018D376B80-0x000000018D376C9C
		public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, UnityEngine.Color color); // 0x000000018D376A04-0x000000018D376B80
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr); // 0x000000018D376C9C-0x000000018D376DF4
		public void OnNextUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D3763A8-0x000000018D37651C
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001843FFFF0-0x0000000184400000
	}

	[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = true, displayName = "PS3 Controller")]
	public class DualShock3GamepadHID : DualShockGamepad // TypeDefIndex: 72438
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		[CompilerGenerated]
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		[CompilerGenerated]
		private ButtonControl _playStationButton_k__BackingField; // 0x298
	
		// Properties
		public ButtonControl leftTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public ButtonControl rightTriggerButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B2A0-0x000000018723B2B0 0x0000000188D36D24-0x0000000188D36D38
		public ButtonControl playStationButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCC0-0x000000018723BCD0 0x0000000188DC44D0-0x0000000188DC44E4
	
		// Constructors
		public DualShock3GamepadHID(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D376200-0x000000018D3762D4
	}

	internal static class DualShockSupport // TypeDefIndex: 72439
	{
		// Methods
		public static void Initialize(); // 0x0000000185B0AF60-0x0000000185B0B410
	}

	public interface IDualShockHaptics : IDualMotorRumble // TypeDefIndex: 72440
	{
		// Methods
		void SetLightBarColor(UnityEngine.Color color);
	}
}

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	public struct DualSenseHIDInputReport : IInputStateTypeInfo // TypeDefIndex: 72441
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
		public FourCC format { get; } // 0x000000018D376160-0x000000018D3761B0 
	
		// Constructors
		static DualSenseHIDInputReport(); // 0x000000018D376124-0x000000018D376160
	}

	internal struct DualSenseHIDOutputReportPayload // TypeDefIndex: 72442
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

	internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 72443
	{
		// Fields
		internal const int kSize = 56; // Metadata: 0x02622E64
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public DualSenseHIDOutputReportPayload payload; // 0x09
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A2D0-0x000000018725A2E0 
		public FourCC typeStatic { get; } // 0x000000018725A2D0-0x000000018725A2E0 
	
		// Methods
		public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize); // 0x000000018725A650-0x000000018725A6A0
	}

	internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 72445
	{
		// Fields
		internal const int kSize = 86; // Metadata: 0x02622E65
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte tag1; // 0x09
		public byte tag2; // 0x0A
		public DualSenseHIDOutputReportPayload payload; // 0x0B
		public uint crc32; // 0x52
		public unsafe fixed /* 0x00000000-0x00000000 */ byte rawData[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A2D0-0x000000018725A2E0 
		public FourCC typeStatic { get; } // 0x000000018725A2D0-0x000000018725A2E0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _rawData_e__FixedBuffer // TypeDefIndex: 72444
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize); // 0x000000018725A540-0x000000018725A5B0
	}

	internal struct DualShock4HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 72446
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
		public FourCC format { get; } // 0x000000018D376E30-0x000000018D376E80 
	
		// Constructors
		static DualShock4HIDInputReport(); // 0x000000018D376DF4-0x000000018D376E30
	}

	internal struct DualShock3HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 72448
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
		public FourCC format { get; } // 0x000000018725A260-0x000000018725A270 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _padding3_e__FixedBuffer // TypeDefIndex: 72447
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 72452
	{
		// Fields
		internal const int kSize = 40; // Metadata: 0x02622E67
		internal const int kReportId = 5; // Metadata: 0x02622E68
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
		public static FourCC Type { get; } // 0x000000018725A2D0-0x000000018725A2E0 
		public FourCC typeStatic { get; } // 0x000000018725A2D0-0x000000018725A2E0 
	
		// Nested types
		[Flags]
		public enum Flags // TypeDefIndex: 72449
		{
			Rumble = 1,
			Color = 2
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _unknown1_e__FixedBuffer // TypeDefIndex: 72450
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _unknown2_e__FixedBuffer // TypeDefIndex: 72451
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public void SetMotorSpeeds(float lowFreq, float highFreq); // 0x000000018D3771C8-0x000000018D377214
		public void SetColor(UnityEngine.Color color); // 0x000000018D377150-0x000000018D3771C8
		public static DualShockHIDOutputReport Create(int outputReportSize); // 0x000000018725A720-0x000000018725A750
	}
}

namespace UnityEngine.InputSystem.Editor
{
	internal struct SampleFrequencyCalculator // TypeDefIndex: 72453
	{
		// Fields
		private double m_LastUpdateTime; // 0x00
		private int m_SampleCount; // 0x08
		[CompilerGenerated]
		private float _targetFrequency_k__BackingField; // 0x0C
		[CompilerGenerated]
		private float _frequency_k__BackingField; // 0x10
	
		// Properties
		public float targetFrequency { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x000000018724AEC0-0x000000018724AED0 0x000000018725AC70-0x000000018725AC80
		public float frequency { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
	
		// Constructors
		public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup); // 0x000000018725AC50-0x000000018725AC70
	
		// Methods
		public void ProcessSample(InputEventPtr eventPtr); // 0x000000018D37FDCC-0x000000018D37FDD8
		public bool Update(); // 0x000000018D37FE14-0x000000018D37FE38
		public bool Update(double realtimeSinceStartup); // 0x000000018D37FDD8-0x000000018D37FE14
	}
}

namespace UnityEngine.InputSystem.EnhancedTouch
{
	public static class EnhancedTouchSupport // TypeDefIndex: 72420
	{
		// Fields
		private static int s_Enabled; // 0x00
		private static InputSettings.UpdateMode s_UpdateMode; // 0x04
	
		// Properties
		public static bool enabled { get; } // 0x000000018D3776BC-0x000000018D3776D4 
	
		// Methods
		public static void Enable(); // 0x0000000185B00A40-0x0000000185B00BB0
		public static void Disable(); // 0x000000018D3772B8-0x000000018D377410
		internal static void Reset(); // 0x000000018D377488-0x000000018D377530
		private static void SetUpState(); // 0x0000000185B0E080-0x0000000185B0E4A0
		internal static void TearDownState(); // 0x000000018D377530-0x000000018D3776BC
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x0000000185B0E4A0-0x0000000185B0E510
		private static void OnSettingsChange(); // 0x000000018D377410-0x000000018D377488
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal static void CheckEnabled(); // 0x000000018D377244-0x000000018D3772B8
	}

	public class Finger // TypeDefIndex: 72421
	{
		// Fields
		[CompilerGenerated]
		private readonly Touchscreen _screen_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _index_k__BackingField; // 0x18
		internal readonly InputStateHistory<TouchState> m_StateHistory; // 0x20
	
		// Properties
		public Touchscreen screen { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public int index { [CompilerGenerated] get; } // 0x00000001844AF510-0x00000001844AF520 
		public bool isActive { get; } // 0x000000018D378890-0x000000018D3788F8 
		public Vector2 screenPosition { get; } // 0x000000018D3789C8-0x000000018D378A54 
		public Touch lastTouch { get; } // 0x000000018D3788F8-0x000000018D3789C8 
		public Touch currentTouch { get; } // 0x000000018D378794-0x000000018D378890 
		public TouchHistory touchHistory { get; } // 0x000000018D378A54-0x000000018D378A90 
	
		// Constructors
		internal Finger(Touchscreen screen, int index, InputUpdateType updateMask); // 0x000000018D378494-0x000000018D378794
	
		// Methods
		private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr); // 0x000000018D3783F0-0x000000018D378494
		private void OnTouchRecorded(InputStateHistory.Record record); // 0x000000018D378138-0x000000018D3783F0
		private Touch FindTouch(uint uniqueId); // 0x000000018D377D0C-0x000000018D377F1C
		internal TouchHistory GetTouchHistory(Touch touch); // 0x000000018D377F1C-0x000000018D378138
	}

	public struct Touch : IEquatable<Touch> // TypeDefIndex: 72426
	{
		// Fields
		private readonly Finger m_Finger; // 0x00
		internal InputStateHistory<TouchState> m_TouchRecord; // 0x08
		internal static GlobalState s_GlobalState; // 0x00
	
		// Properties
		public bool valid { get; } // 0x000000018D38336C-0x000000018D3833A8 
		public Finger finger { get; } // 0x0000000184431970-0x0000000184431980 
		public UnityEngine.InputSystem.TouchPhase phase { get; } // 0x000000018D382F08-0x000000018D382F58 
		public bool began { get; } // 0x000000018D382A98-0x000000018D382AE0 
		public bool inProgress { get; } // 0x000000018D382D98-0x000000018D382E1C 
		public bool ended { get; } // 0x000000018D382B84-0x000000018D382BEC 
		public int touchId { get; } // 0x000000018D383280-0x000000018D3832CC 
		public float pressure { get; } // 0x000000018D382F58-0x000000018D382FA8 
		public Vector2 radius { get; } // 0x000000018D382FA8-0x000000018D382FFC 
		public double startTime { get; } // 0x000000018D383168-0x000000018D3831B8 
		public double time { get; } // 0x000000018D383244-0x000000018D383280 
		public Touchscreen screen { get; } // 0x000000018D383050-0x000000018D3830A4 
		public Vector2 screenPosition { get; } // 0x000000018D382FFC-0x000000018D383050 
		public Vector2 startScreenPosition { get; } // 0x000000018D383114-0x000000018D383168 
		public Vector2 delta { get; } // 0x000000018D382AE0-0x000000018D382B34 
		public int tapCount { get; } // 0x000000018D3831F4-0x000000018D383244 
		public bool isTap { get; } // 0x000000018D382E70-0x000000018D382EB8 
		public int displayIndex { get; } // 0x000000018D382B34-0x000000018D382B84 
		public bool isInProgress { get; } // 0x000000018D382E1C-0x000000018D382E70 
		internal uint updateStepCount { get; } // 0x000000018D38331C-0x000000018D38336C 
		internal uint uniqueId { get; } // 0x000000018D3832CC-0x000000018D38331C 
		private ref TouchState state { get; } // 0x000000018D3831B8-0x000000018D3831F4 
		private ref ExtraDataPerTouchState extraData { get; } // 0x000000018D382BEC-0x000000018D382C28 
		public TouchHistory history { get; } // 0x000000018D382CA8-0x000000018D382D98 
		public static ReadOnlyArray<Touch> activeTouches { get; } // 0x00000001865673A0-0x0000000186567420 
		public static ReadOnlyArray<Finger> fingers { get; } // 0x000000018D382C28-0x000000018D382CA8 
		public static ReadOnlyArray<Finger> activeFingers { get; } // 0x000000018D3829FC-0x000000018D382A98 
		public static IEnumerable<Touchscreen> screens { get; } // 0x000000018D3830A4-0x000000018D383114 
		public static int maxHistoryLengthPerFinger { get; } // 0x000000018D382EB8-0x000000018D382F08 
	
		// Events
		public static event Action<Finger> onFingerDown {
			add; // 0x000000018D3827C4-0x000000018D382880
			remove; // 0x000000018D3833A8-0x000000018D383464
		}
		public static event Action<Finger> onFingerUp {
			add; // 0x000000018D38293C-0x000000018D3829FC
			remove; // 0x000000018D383520-0x000000018D3835E0
		}
		public static event Action<Finger> onFingerMove {
			add; // 0x000000018D382880-0x000000018D38293C
			remove; // 0x000000018D383464-0x000000018D383520
		}
	
		// Nested types
		internal struct GlobalState // TypeDefIndex: 72422
		{
			// Fields
			internal InlinedArray<Touchscreen> touchscreens; // 0x00
			internal int historyLengthPerFinger; // 0x18
			internal CallbackArray<Action<Finger>> onFingerDown; // 0x20
			internal CallbackArray<Action<Finger>> onFingerMove; // 0x70
			internal CallbackArray<Action<Finger>> onFingerUp; // 0xC0
			internal FingerAndTouchState playerState; // 0x110
		}
	
		internal struct FingerAndTouchState // TypeDefIndex: 72423
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
			public void AddFingers(Touchscreen screen); // 0x000000018D37790C-0x000000018D377A28
			public void RemoveFingers(Touchscreen screen); // 0x000000018D377AB4-0x000000018D377BF8
			public void Destroy(); // 0x000000018D377A28-0x000000018D377AB4
			public void UpdateActiveFingers(); // 0x000000018D377BF8-0x000000018D377D0C
			public void UpdateActiveTouches(); // 0x0000000186567420-0x0000000186567560
		}
	
		internal struct ExtraDataPerTouchState // TypeDefIndex: 72424
		{
			// Fields
			public Vector2 accumulatedDelta; // 0x00
			public uint uniqueId; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72425
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__80_0; // 0x08
			public static Action __9__80_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D3837C4-0x000000018D383828
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SaveAndResetState_b__80_0(ref GlobalState state); // 0x000000018D383638-0x000000018D3837A4
			internal void _SaveAndResetState_b__80_1(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		internal Touch(Finger finger, InputStateHistory<TouchState> touchRecord); // 0x0000000185AE5280-0x0000000185AE52B0
		static Touch(); // 0x00000001870773D0-0x00000001870774C0
	
		// Methods
		public override string ToString(); // 0x000000018D382554-0x000000018D3827C4
		public bool Equals(Touch other); // 0x000000018D382028-0x000000018D3820B4
		public override bool Equals(object obj); // 0x000000018D3820B4-0x000000018D382150
		public override int GetHashCode(); // 0x000000018D382150-0x000000018D3821B4
		internal static void AddTouchscreen(Touchscreen screen); // 0x000000018D381FA0-0x000000018D382028
		internal static void RemoveTouchscreen(Touchscreen screen); // 0x000000018D3821B4-0x000000018D382274
		internal static void BeginUpdate(); // 0x00000001862B7300-0x00000001862B7340
		private static GlobalState CreateGlobalState(); // 0x000000018725AD00-0x000000018725AD30
		internal static ISavedState SaveAndResetState(); // 0x000000018D382274-0x000000018D382554
	}

	public struct TouchHistory : IReadOnlyList<Touch> // TypeDefIndex: 72428
	{
		// Fields
		private readonly InputStateHistory<TouchState> m_History; // 0x00
		private readonly Finger m_Finger; // 0x08
		private readonly int m_Count; // 0x10
		private readonly int m_StartIndex; // 0x14
		private readonly uint m_Version; // 0x18
	
		// Properties
		public int Count { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public Touch this[int index] { get => default; } // 0x000000018D37FFF8-0x000000018D380168 
	
		// Nested types
		private class Enumerator : IEnumerator<Touch> // TypeDefIndex: 72427
		{
			// Fields
			private readonly TouchHistory m_Owner; // 0x10
			private int m_Index; // 0x30
	
			// Properties
			public Touch Current { get; } // 0x000000018D3778C4-0x000000018D37790C 
			object IEnumerator.Current { get; } // 0x000000018D3777B8-0x000000018D377818 
	
			// Constructors
			internal Enumerator(TouchHistory owner); // 0x000000018D377860-0x000000018D37788C
	
			// Methods
			public bool MoveNext(); // 0x000000018D3776D4-0x000000018D3776F4
			public void Reset(); // 0x000000018723FA60-0x000000018723FA70
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1 /* Metadata: 0x02622E5A */, int count = -1 /* Metadata: 0x02622E5B */); // 0x000000018D37FF8C-0x000000018D37FFF8
	
		// Methods
		public IEnumerator<Touch> GetEnumerator(); // 0x000000018D37FF04-0x000000018D37FF84
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D37FF84-0x000000018D37FF8C
		internal void CheckValid(); // 0x000000018D37FE38-0x000000018D37FF04
	}

	[AddComponentMenu("Input/Debug/Touch Simulation")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/Touch.html#touch-simulation")]
	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor // TypeDefIndex: 72429
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
		public Touchscreen simulatedTouchscreen { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public static TouchSimulation instance { get; } // 0x000000018D381BF0-0x000000018D381C28 
	
		// Constructors
		public TouchSimulation(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static void Enable(); // 0x000000018D3803E8-0x000000018D380510
		public static void Disable(); // 0x000000018D38037C-0x000000018D3803E8
		public static void Destroy(); // 0x000000018D3802AC-0x000000018D38037C
		protected void AddPointer(UnityEngine.InputSystem.Pointer pointer); // 0x000000018D380168-0x000000018D3802AC
		protected void RemovePointer(UnityEngine.InputSystem.Pointer pointer); // 0x000000018D381824-0x000000018D3819E8
		private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018D380B50-0x000000018D381824
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018D380510-0x000000018D3805DC
		protected void OnEnable(); // 0x000000018D380718-0x000000018D380B50
		protected void OnDisable(); // 0x000000018D3805DC-0x000000018D380718
		private void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, InputEventPtr eventPtr = default); // 0x000000018D3819E8-0x000000018D381BF0
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x0000000186805BA0-0x0000000186805BB0
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x0000000186805BA0-0x0000000186805BB0
		protected void InstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x02622E5C */); // 0x0000000186805BA0-0x0000000186805BB0
		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex); // 0x0000000186805BA0-0x0000000186805BB0
		protected void UninstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x02622E5D */); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble // TypeDefIndex: 72454
	{
		// Fields
		[CompilerGenerated]
		private float _lowFrequencyMotorSpeed_k__BackingField; // 0x00
		[CompilerGenerated]
		private float _highFrequencyMotorSpeed_k__BackingField; // 0x04
	
		// Properties
		public float lowFrequencyMotorSpeed { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342D0-0x00000001872342E0 0x0000000187241700-0x0000000187241710
		public float highFrequencyMotorSpeed { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724A6D0-0x000000018724A6E0 0x00000001872598B0-0x00000001872598C0
		public bool isRumbling { get; } // 0x000000018D375518-0x000000018D3755A4 
	
		// Methods
		public void PauseHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018D3751EC-0x000000018D3752C4
		public void ResumeHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018D375360-0x000000018D3753FC
		public void ResetHaptics(UnityEngine.InputSystem.InputDevice device); // 0x000000018D3752C4-0x000000018D375360
		public void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency); // 0x000000018D3753FC-0x000000018D375518
	}

	public interface IDualMotorRumble : IHaptics // TypeDefIndex: 72455
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency);
	}

	public interface IHaptics // TypeDefIndex: 72456
	{
		// Methods
		void PauseHaptics();
		void ResumeHaptics();
		void ResetHaptics();
	}
}

namespace UnityEngine.InputSystem.HID
{
	public class HID : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 72412
	{
		// Fields
		internal const string kHIDInterface = "HID"; // Metadata: 0x02622D1B
		internal const string kHIDNamespace = "HID"; // Metadata: 0x02622D1F
		private bool m_HaveParsedHIDDescriptor; // 0x190
		private HIDDeviceDescriptor m_HIDDescriptor; // 0x198
		private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x00
	
		// Properties
		public static FourCC QueryHIDReportDescriptorDeviceCommandType { get; } // 0x000000018725A1B0-0x000000018725A1C0 
		public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType { get; } // 0x000000018725A1C0-0x000000018725A1D0 
		public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType { get; } // 0x000000018725A1A0-0x000000018725A1B0 
		public HIDDeviceDescriptor hidDescriptor { get; } // 0x000000018D36BE64-0x000000018D36BF8C 
	
		// Nested types
		[Serializable]
		private class HIDLayoutBuilder // TypeDefIndex: 72399
		{
			// Fields
			public string displayName; // 0x10
			public HIDDeviceDescriptor hidDescriptor; // 0x18
			public string parentLayout; // 0x48
			public System.Type deviceType; // 0x50
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 72398
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Predicate<HIDElementDescriptor> __9__4_0; // 0x08
				public static Predicate<HIDElementDescriptor> __9__4_1; // 0x10
				public static Func<InputControlLayout.ControlItem, string> __9__4_2; // 0x18
	
				// Constructors
				static __c(); // 0x000000018D383828-0x000000018D3839C4
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _Build_b__4_0(HIDElementDescriptor element); // 0x000000018D3835E0-0x000000018D3835FC
				internal bool _Build_b__4_1(HIDElementDescriptor element); // 0x000000018D3835FC-0x000000018D383618
				internal string _Build_b__4_2(InputControlLayout.ControlItem x); // 0x000000018D383618-0x000000018D383638
			}
	
			// Constructors
			public HIDLayoutBuilder(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public InputControlLayout Build(); // 0x000000018D36AF68-0x000000018D36BD78
		}
	
		public enum HIDReportType // TypeDefIndex: 72400
		{
			Unknown = 0,
			Input = 1,
			Output = 2,
			Feature = 3
		}
	
		public enum HIDCollectionType // TypeDefIndex: 72401
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
		public enum HIDElementFlags // TypeDefIndex: 72402
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
		public struct HIDElementDescriptor // TypeDefIndex: 72403
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
			public bool hasNullState { get; } // 0x000000018D37A514-0x000000018D37A520 
			public bool hasPreferredState { get; } // 0x000000018D37A520-0x000000018D37A52C 
			public bool isArray { get; } // 0x000000018D37A52C-0x000000018D37A538 
			public bool isNonLinear { get; } // 0x000000018D37A540-0x000000018D37A54C 
			public bool isRelative { get; } // 0x000000018D37A54C-0x000000018D37A558 
			public bool isConstant { get; } // 0x000000018D37A538-0x000000018D37A540 
			public bool isWrapping { get; } // 0x000000018D37A560-0x000000018D37A56C 
			internal bool isSigned { get; } // 0x000000018D37A558-0x000000018D37A560 
			internal float minFloatValue { get; } // 0x000000018D37A5CC-0x000000018D37A62C 
			internal float maxFloatValue { get; } // 0x000000018D37A56C-0x000000018D37A5CC 
	
			// Methods
			public bool Is(UsagePage usagePage, int usage); // 0x000000018D37A504-0x000000018D37A514
			internal string DetermineName(); // 0x000000018D379FF8-0x000000018D37A1B8
			internal string DetermineDisplayName(); // 0x000000018D379D24-0x000000018D379DE8
			internal bool IsUsableElement(); // 0x000000018D37A4D8-0x000000018D37A504
			internal string DetermineLayout(); // 0x000000018D379EEC-0x000000018D379FF8
			internal FourCC DetermineFormat(); // 0x000000018D379DE8-0x000000018D379EEC
			internal InternedString[] DetermineUsages(); // 0x000000018D37A344-0x000000018D37A4D8
			internal string DetermineParameters(); // 0x000000018D37A1B8-0x000000018D37A2F4
			private string DetermineAxisNormalizationParameters(); // 0x000000018D379A2C-0x000000018D379BF4
			internal string DetermineProcessors(); // 0x000000018D37A2F4-0x000000018D37A344
			internal PrimitiveValue DetermineDefaultState(); // 0x000000018D379BF4-0x000000018D379D24
			internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder); // 0x000000018D3793A8-0x000000018D379A2C
		}
	
		[Serializable]
		public struct HIDCollectionDescriptor // TypeDefIndex: 72404
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
		public struct HIDDeviceDescriptor // TypeDefIndex: 72405
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
			public string ToJson(); // 0x000000018D379344-0x000000018D3793A8
			public static HIDDeviceDescriptor FromJson(string json); // 0x0000000185BC6CE0-0x0000000185BCC230
		}
	
		public struct HIDDeviceDescriptorBuilder // TypeDefIndex: 72406
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
			public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage); // 0x000000018725A890-0x000000018725A8C0
			public HIDDeviceDescriptorBuilder(GenericDesktop usage); // 0x000000018725A860-0x000000018725A890
	
			// Methods
			public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1 /* Metadata: 0x02622D3A */); // 0x000000018725A820-0x000000018725A860
			public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits); // 0x000000018D378B7C-0x000000018D378F40
			public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits); // 0x000000018D378F40-0x000000018D378F94
			public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max); // 0x000000018D3791C8-0x000000018D379344
			public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max); // 0x000000018D37904C-0x000000018D3791C8
			public HIDDeviceDescriptor Finish(); // 0x000000018D378F94-0x000000018D37904C
		}
	
		public enum UsagePage // TypeDefIndex: 72407
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
	
		public enum GenericDesktop // TypeDefIndex: 72408
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
	
		public enum Simulation // TypeDefIndex: 72409
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
	
		public enum Button // TypeDefIndex: 72410
		{
			Undefined = 0,
			Primary = 1,
			Secondary = 2,
			Tertiary = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 72411
		{
			// Fields
			public HIDLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0(); // 0x000000018D3837A4-0x000000018D3837C4
		}
	
		// Constructors
		public HID(); // 0x000000018D2E1E18-0x000000018D2E1E20
		static HID(); // 0x00000001871DD190-0x00000001871DD1F0
	
		// Methods
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // 0x0000000186315BF0-0x0000000186315F00
		internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate); // 0x0000000186315FA0-0x0000000186316CA0
		public static string UsagePageToString(UsagePage usagePage); // 0x000000018D36BD78-0x000000018D36BDE4
		public static string UsageToString(UsagePage usagePage, int usage); // 0x000000018D36BDE4-0x000000018D36BE64
	}

	internal static class HIDParser // TypeDefIndex: 72417
	{
		// Nested types
		private struct HIDReportData // TypeDefIndex: 72413
		{
			// Fields
			public int reportId; // 0x00
			public HID.HIDReportType reportType; // 0x04
			public int currentBitOffset; // 0x08
	
			// Methods
			public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDReportData> reports); // 0x000000018D37B844-0x000000018D37B970
		}
	
		private enum HIDItemTypeAndTag // TypeDefIndex: 72414
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
	
		private struct HIDItemStateLocal // TypeDefIndex: 72415
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
			public static void Reset(ref HIDItemStateLocal state); // 0x000000018D37A8D4-0x000000018D37A938
			public void SetUsage(int value); // 0x000000018D37A938-0x000000018D37AA3C
			public int GetUsage(int index); // 0x000000018D37A7E4-0x000000018D37A8D4
		}
	
		private struct HIDItemStateGlobal // TypeDefIndex: 72416
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
			public HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState); // 0x000000018D37A76C-0x000000018D37A7E4
			public int GetPhysicalMin(); // 0x000000018D37A6CC-0x000000018D37A76C
			public int GetPhysicalMax(); // 0x000000018D37A62C-0x000000018D37A6CC
		}
	
		// Methods
		public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor); // 0x000000018D37AA3C-0x000000018D37AAD0
		public static unsafe bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor); // 0x000000018D37AAD0-0x000000018D37B7F0
		private static unsafe int ReadData(int itemSize, byte* currentPtr, byte* endPtr); // 0x000000018D37B7F0-0x000000018D37B844
	}

	public static class HIDSupport // TypeDefIndex: 72419
	{
		// Fields
		private static HIDPageUsage[] s_SupportedHIDUsages; // 0x00
	
		// Properties
		public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages { get; set; } // 0x0000000186315F00-0x0000000186315FA0 0x000000018D37B970-0x000000018D37BBAC
	
		// Nested types
		public struct HIDPageUsage // TypeDefIndex: 72418
		{
			// Fields
			public HID.UsagePage page; // 0x00
			public int usage; // 0x04
	
			// Constructors
			public HIDPageUsage(HID.UsagePage page, int usage); // 0x00000001827241A0-0x00000001827241B0
			public HIDPageUsage(HID.GenericDesktop usage); // 0x000000018725A8C0-0x000000018725A8D0
		}
	
		// Methods
		internal static void Initialize(); // 0x0000000185B0C9C0-0x0000000185B0CB50
	}
}

namespace UnityEngine.InputSystem.Interactions
{
	[System.ComponentModel.DisplayName("Hold")]
	public class HoldInteraction : IInputInteraction // TypeDefIndex: 72639
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TimePressed; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018D301EA8-0x000000018D301F04 
		private float pressPointOrDefault { get; } // 0x000000018D301F04-0x000000018D301F50 
	
		// Constructors
		public HoldInteraction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018D301DBC-0x000000018D301EA8
		public void Reset(); // 0x0000000187259980-0x0000000187259990
	}

	public class MultiTapInteraction : IInputInteraction<float> // TypeDefIndex: 72641
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
		private float tapTimeOrDefault { get; } // 0x000000018D30AA9C-0x000000018D30AAF8 
		internal float tapDelayOrDefault { get; } // 0x000000018D30AA40-0x000000018D30AA9C 
		private float pressPointOrDefault { get; } // 0x000000018D30A9AC-0x000000018D30A9F8 
		private float releasePointOrDefault { get; } // 0x000000018D30A9F8-0x000000018D30AA40 
	
		// Nested types
		private enum TapPhase // TypeDefIndex: 72640
		{
			None = 0,
			WaitingForNextRelease = 1,
			WaitingForNextPress = 2
		}
	
		// Constructors
		public MultiTapInteraction(); // 0x000000018723B480-0x000000018723B490
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018D30A7D8-0x000000018D30A9AC
		public void Reset(); // 0x0000000187259A50-0x0000000187259A60
	}

	[System.ComponentModel.DisplayName("Press")]
	public class PressInteraction : IInputInteraction // TypeDefIndex: 72642
	{
		// Fields
		[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to \'Default Press Point\' in the global input settings.")]
		public float pressPoint; // 0x10
		[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
		public PressBehavior behavior; // 0x14
		private bool m_WaitingForRelease; // 0x18
	
		// Properties
		private float pressPointOrDefault { get; } // 0x000000018D30AD74-0x000000018D30ADC0 
		private float releasePointOrDefault { get; } // 0x000000018D30ADC0-0x000000018D30AE08 
	
		// Constructors
		public PressInteraction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018D30AAF8-0x000000018D30AD74
		public void Reset(); // 0x000000018723F9D0-0x000000018723F9E0
	}

	public enum PressBehavior // TypeDefIndex: 72643
	{
		PressOnly = 0,
		ReleaseOnly = 1,
		PressAndRelease = 2
	}

	[System.ComponentModel.DisplayName("Long Tap")]
	public class SlowTapInteraction : IInputInteraction // TypeDefIndex: 72644
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_SlowTapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018D30B528-0x000000018D30B584 
		private float pressPointOrDefault { get; } // 0x000000018D30B584-0x000000018D30B5D0 
	
		// Constructors
		public SlowTapInteraction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018D30B47C-0x000000018D30B528
		public void Reset(); // 0x0000000187259980-0x0000000187259990
	}

	[System.ComponentModel.DisplayName("Tap")]
	public class TapInteraction : IInputInteraction // TypeDefIndex: 72645
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get; } // 0x000000018D30B7B4-0x000000018D30B810 
		private float pressPointOrDefault { get; } // 0x000000018D30B810-0x000000018D30B85C 
		private float releasePointOrDefault { get; } // 0x000000018D30B85C-0x000000018D30B8A4 
	
		// Constructors
		public TapInteraction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Process(ref InputInteractionContext context); // 0x000000018D30B6D8-0x000000018D30B7B4
		public void Reset(); // 0x0000000187259980-0x0000000187259990
	}
}

namespace UnityEngine.InputSystem.Layouts
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public sealed class InputControlAttribute : PropertyAttribute // TypeDefIndex: 72587
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
		public string layout { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string variants { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string format { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string usage { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public string[] usages { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public string parameters { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public string processors { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public string alias { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public string[] aliases { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public string useStateFrom { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public uint bit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271AE0-0x0000000182271AF0 0x0000000185B8E660-0x0000000185B8E8A0
		public uint offset { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872333A0-0x00000001872333B0 0x0000000187233400-0x0000000187233410
		public uint sizeInBits { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233370-0x0000000187233380 0x00000001872333D0-0x00000001872333E0
		public int arraySize { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233390-0x00000001872333A0 0x00000001872333F0-0x0000000187233400
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public string shortDisplayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public bool noisy { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018236FC60-0x000000018236FC70 0x000000018236FC70-0x000000018236FC80
		public bool synthetic { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235FA0-0x0000000187235FB0 0x000000018723EB40-0x000000018723EB50
		public bool dontReset { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235FE0-0x0000000187235FF0 0x0000000187257CA0-0x0000000187257CB0
		public object defaultState { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public object minValue { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public object maxValue { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
	
		// Constructors
		public InputControlAttribute(); // 0x000000018725ADC0-0x000000018725ADD0
	}

	public delegate string InputDeviceFindControlLayoutDelegate(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // TypeDefIndex: 72588; 0x00000001811DF7F0-0x00000001811DF810

	public class InputControlLayout // TypeDefIndex: 72608
	{
		// Fields
		private static InternedString s_DefaultVariant; // 0x00
		public const string VariantSeparator = ";"; // Metadata: 0x02623035
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
		public static InternedString DefaultVariant { get; } // 0x000000018D38C460-0x000000018D38C4BC 
		public InternedString name { get; } // 0x0000000184430480-0x0000000184430490 
		public string displayName { get; } // 0x000000018D38C848-0x000000018D38C874 
		public System.Type type { get; } // 0x000000018225E800-0x000000018225E810 
		public InternedString variants { get; } // 0x000000018723D770-0x000000018723D780 
		public FourCC stateFormat { get; } // 0x00000001829600C0-0x00000001829600D0 
		public int stateSizeInBytes { get; } // 0x000000018226F000-0x000000018226F010 
		public IEnumerable<InternedString> baseLayouts { get; } // 0x000000018D38C69C-0x000000018D38C6EC 
		public IEnumerable<InternedString> appliedOverrides { get; } // 0x000000018D38C64C-0x000000018D38C69C 
		public ReadOnlyArray<InternedString> commonUsages { get; } // 0x000000018D38C798-0x000000018D38C7F0 
		public ReadOnlyArray<ControlItem> controls { get; } // 0x000000018D38C7F0-0x000000018D38C848 
		public bool updateBeforeRender { get; } // 0x000000018D38C930-0x000000018D38C968 
		public bool isDeviceLayout { get; } // 0x000000018D38C894-0x000000018D38C90C 
		public bool isControlLayout { get; } // 0x000000018D38C880-0x000000018D38C894 
		public bool isOverride { get; internal set; } // 0x000000018D38C924-0x000000018D38C930 0x000000018D38CA64-0x000000018D38CA84
		public bool isGenericTypeOfDevice { get; internal set; } // 0x000000018D38C90C-0x000000018D38C918 0x000000018D38CA24-0x000000018D38CA44
		public bool hideInUI { get; internal set; } // 0x000000018D38C874-0x000000018D38C880 0x000000018D38CA04-0x000000018D38CA24
		public bool isNoisy { get; internal set; } // 0x000000018D38C918-0x000000018D38C924 0x000000018D38CA44-0x000000018D38CA64
		public bool? canRunInBackground { get; internal set; } // 0x000000018D38C73C-0x000000018D38C798 0x000000018D38C968-0x000000018D38CA04
		public ControlItem this[string path] { get => default; } // 0x000000018D38C4BC-0x000000018D38C64C 
		internal static ref Cache cache { get; } // 0x000000018D38C6EC-0x000000018D38C73C 
	
		// Nested types
		public struct ControlItem // TypeDefIndex: 72590
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
			public InternedString name { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x000000018723AC80-0x000000018723AC90 0x0000000188EFA1E4-0x0000000188EFA1F0
			public InternedString layout { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184430480-0x0000000184430490 0x0000000185D04A50-0x0000000185D04A60
			public InternedString variants { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000187238F60-0x0000000187238F70 0x000000018903B5B4-0x000000018903B5C4
			public string useStateFrom { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
			public string displayName { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
			public string shortDisplayName { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
			public ReadOnlyArray<InternedString> usages { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x000000018723DAF0-0x000000018723DB00 0x0000000188F39170-0x0000000188F39180
			public ReadOnlyArray<InternedString> aliases { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000187234DB0-0x0000000187234DC0 0x0000000189041A6C-0x0000000189041A7C
			public ReadOnlyArray<NamedValue> parameters { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000187253FA0-0x0000000187253FB0 0x000000018D386F04-0x000000018D386F14
			public ReadOnlyArray<NameAndParameters> processors { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018723C550-0x000000018723C560 0x0000000188DECA20-0x0000000188DECA30
			public uint offset { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000187233450-0x0000000187233460 0x0000000185B8E410-0x0000000185B8E660
			public uint bit { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000187233660-0x0000000187233670 0x0000000187233680-0x0000000187233690
			public uint sizeInBits { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001872333B0-0x00000001872333C0 0x0000000185FD6920-0x0000000185FD6930
			public FourCC format { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182271AD0-0x0000000182271AE0 0x0000000182271B30-0x0000000182271B40
			private Flags flags { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271AC0-0x0000000182271AD0 0x0000000182271B20-0x0000000182271B30
			public int arraySize { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] internal set; } // 0x0000000182271AF0-0x0000000182271B00 0x0000000182271B40-0x0000000182271B50
			public PrimitiveValue defaultState { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018724F4C0-0x000000018724F4D0 0x0000000187233E60-0x0000000187233E70
			public PrimitiveValue minValue { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018724F490-0x000000018724F4A0 0x000000018724F4F0-0x000000018724F500
			public PrimitiveValue maxValue { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018724F480-0x000000018724F490 0x0000000187233B30-0x0000000187233B40
			public bool isModifyingExistingControl { get; internal set; } // 0x000000018D386E40-0x000000018D386E4C 0x000000018D386EA4-0x000000018D386EC4
			public bool isNoisy { get; internal set; } // 0x000000018D386E4C-0x000000018D386E58 0x000000018D386EC4-0x000000018D386EE4
			public bool isSynthetic { get; internal set; } // 0x000000018D386E58-0x000000018D386E64 0x000000018D386EE4-0x000000018D386F04
			public bool dontReset { get; internal set; } // 0x000000018D386E28-0x000000018D386E34 0x000000018D386E64-0x000000018D386E84
			public bool isFirstDefinedInThisLayout { get; internal set; } // 0x000000018D386E34-0x000000018D386E40 0x000000018D386E84-0x000000018D386EA4
			public bool isArray { get; } // 0x0000000188A29BC4-0x0000000188A29BD0 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 72589
			{
				isModifyingExistingControl = 1,
				IsNoisy = 2,
				IsSynthetic = 4,
				IsFirstDefinedInThisLayout = 8,
				DontReset = 16
			}
	
			// Methods
			public ControlItem Merge(ControlItem other); // 0x000000018D386AA0-0x000000018D386E28
		}
	
		public class Builder // TypeDefIndex: 72593
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
			public string name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
			public FourCC stateFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			public int stateSizeInBytes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
			public string extendsLayout { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018D384038-0x000000018D384058
			public bool? updateBeforeRender { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725ADA0-0x000000018725ADB0 0x0000000187256C00-0x0000000187256C10
			public ReadOnlyArray<ControlItem> controls { get; } // 0x000000018D383FD8-0x000000018D384038 
	
			// Nested types
			public struct ControlBuilder // TypeDefIndex: 72592
			{
				// Fields
				internal Builder builder; // 0x00
				internal int index; // 0x08
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 72591
				{
					// Fields
					public static readonly __c __9; // 0x00
					public static Func<string, InternedString> __9__14_0; // 0x08
	
					// Constructors
					static __c(); // 0x000000018D394180-0x000000018D3941E4
					public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
					// Methods
					internal InternedString _WithUsages_b__14_0(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
				}
	
				// Methods
				public ControlBuilder WithDisplayName(string displayName); // 0x000000018D385384-0x000000018D3853E4
				public ControlBuilder WithLayout(string layout); // 0x000000018D385494-0x000000018D38559C
				public ControlBuilder WithFormat(FourCC format); // 0x000000018D38543C-0x000000018D385494
				public ControlBuilder WithFormat(string format); // 0x000000018D3853E4-0x000000018D38543C
				public ControlBuilder WithByteOffset(uint offset); // 0x000000018D3852CC-0x000000018D385324
				public ControlBuilder WithBitOffset(uint bit); // 0x000000018D385274-0x000000018D3852CC
				public ControlBuilder IsSynthetic(bool value); // 0x000000018D385194-0x000000018D385200
				public ControlBuilder IsNoisy(bool value); // 0x000000018D385128-0x000000018D385194
				public ControlBuilder DontReset(bool value); // 0x000000018D3850BC-0x000000018D385128
				public ControlBuilder WithSizeInBits(uint sizeInBits); // 0x000000018D385818-0x000000018D385870
				public ControlBuilder WithRange(float minValue, float maxValue); // 0x000000018D385750-0x000000018D385818
				public ControlBuilder WithUsages(params InternedString[] usages); // 0x000000018D385870-0x000000018D385A50
				public ControlBuilder WithUsages(IEnumerable<string> usages); // 0x000000018D385A50-0x000000018D385BA8
				public ControlBuilder WithUsages(params string[] usages); // 0x000000018D385BA8-0x000000018D385BD0
				public ControlBuilder WithParameters(string parameters); // 0x000000018D38559C-0x000000018D385668
				public ControlBuilder WithProcessors(string processors); // 0x000000018D385668-0x000000018D385750
				public ControlBuilder WithDefaultState(PrimitiveValue value); // 0x000000018D385324-0x000000018D385384
				public ControlBuilder UsingStateFrom(string path); // 0x000000018D385200-0x000000018D385274
				public ControlBuilder AsArrayOfControlsWithSize(int arraySize); // 0x000000018D385064-0x000000018D3850BC
			}
	
			// Constructors
			public Builder(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public ControlBuilder AddControl(string name); // 0x000000018D383BB8-0x000000018D383D84
			public Builder WithName(string name); // 0x0000000188C893FC-0x0000000188C89418
			public Builder WithDisplayName(string displayName); // 0x0000000188C89418-0x0000000188C89434
			public Builder WithType<T>()
				where T : InputControl;
			public Builder WithFormat(FourCC format); // 0x000000018725AD80-0x000000018725AD90
			public Builder WithFormat(string format); // 0x000000018D383FA8-0x000000018D383FD8
			public Builder WithSizeInBytes(int sizeInBytes); // 0x000000018725AD90-0x000000018725ADA0
			public Builder Extend(string baseLayoutName); // 0x000000018D383F8C-0x000000018D383FA8
			public InputControlLayout Build(); // 0x000000018D383D84-0x000000018D383F8C
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 72594
		{
			IsGenericTypeOfDevice = 1,
			HideInUI = 2,
			IsOverride = 4,
			CanRunInBackground = 8,
			CanRunInBackgroundIsSet = 16,
			IsNoisy = 32
		}
	
		[Serializable]
		internal struct LayoutJsonNameAndDescriptorOnly // TypeDefIndex: 72595
		{
			// Fields
			public string name; // 0x00
			public string extend; // 0x08
			public string[] extendMultiple; // 0x10
			public InputDeviceMatcher.MatcherJson device; // 0x18
		}
	
		[Serializable]
		private struct LayoutJson // TypeDefIndex: 72597
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
			private sealed class __c // TypeDefIndex: 72596
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<string, InternedString> __9__14_0; // 0x08
				public static Func<InternedString, string> __9__15_0; // 0x10
				public static Func<InternedString, string> __9__15_1; // 0x18
	
				// Constructors
				static __c(); // 0x000000018D39411C-0x000000018D394180
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal InternedString _ToLayout_b__14_0(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
				internal string _FromLayout_b__15_0(InternedString x); // 0x000000018D313214-0x000000018D313228
				internal string _FromLayout_b__15_1(InternedString x); // 0x000000018D313214-0x000000018D313228
			}
	
			// Methods
			public InputControlLayout ToLayout(); // 0x000000018D390970-0x000000018D391308
			public static LayoutJson FromLayout(InputControlLayout layout); // 0x000000018D3905B4-0x000000018D390970
		}
	
		[Serializable]
		private class ControlItemJson // TypeDefIndex: 72599
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
			private sealed class __c // TypeDefIndex: 72598
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
				static __c(); // 0x000000018D3940B8-0x000000018D39411C
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal InternedString _ToLayout_b__24_0(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
				internal InternedString _ToLayout_b__24_1(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
				internal string _FromControlItems_b__25_0(NamedValue x); // 0x000000018D313200-0x000000018D313214
				internal string _FromControlItems_b__25_1(NameAndParameters x); // 0x000000018D394060-0x000000018D394074
				internal string _FromControlItems_b__25_2(InternedString x); // 0x000000018D313214-0x000000018D313228
				internal string _FromControlItems_b__25_3(InternedString x); // 0x000000018D313214-0x000000018D313228
			}
	
			// Constructors
			public ControlItemJson(); // 0x000000018725ADB0-0x000000018725ADC0
	
			// Methods
			public ControlItem ToLayout(); // 0x000000018D3863C8-0x000000018D386AA0
			public static ControlItemJson[] FromControlItems(ControlItem[] items); // 0x000000018D385BD0-0x000000018D3863C8
		}
	
		internal struct Collection // TypeDefIndex: 72603
		{
			// Fields
			public const float kBaseScoreForNonGeneratedLayouts = 1f; // Metadata: 0x02623043
			public Dictionary<InternedString, System.Type> layoutTypes; // 0x00
			public Dictionary<InternedString, string> layoutStrings; // 0x08
			public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders; // 0x10
			public Dictionary<InternedString, InternedString> baseLayoutTable; // 0x18
			public Dictionary<InternedString, InternedString[]> layoutOverrides; // 0x20
			public HashSet<InternedString> layoutOverrideNames; // 0x28
			public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; // 0x30
			public List<LayoutMatcher> layoutMatchers; // 0x38
	
			// Nested types
			public struct LayoutMatcher // TypeDefIndex: 72600
			{
				// Fields
				public InternedString layoutName; // 0x00
				public InputDeviceMatcher deviceMatcher; // 0x10
			}
	
			public struct PrecompiledLayout // TypeDefIndex: 72601
			{
				// Fields
				public Func<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x00
				public string metadata; // 0x08
			}
	
			[CompilerGenerated]
			private sealed class _GetBaseLayouts_d__24 : IEnumerable<InternedString>, IEnumerator<InternedString> // TypeDefIndex: 72602
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
				InternedString IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current { [DebuggerHidden] get; } // 0x00000001845C28E0-0x00000001845C28F0 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D30C288-0x000000018D30C2D0 
	
				// Constructors
				[DebuggerHidden]
				public _GetBaseLayouts_d__24(int __1__state); // 0x0000000188E4A554-0x0000000188E4A570
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x000000018D30C0A4-0x000000018D30C15C
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018D30C23C-0x000000018D30C288
				[DebuggerHidden]
				IEnumerator<InternedString> IEnumerable<InternedString>.GetEnumerator(); // 0x000000018D30C15C-0x000000018D30C234
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D30C234-0x000000018D30C23C
			}
	
			// Methods
			public void Allocate(); // 0x0000000185B08C80-0x0000000185B08F10
			public InternedString TryFindLayoutForType(System.Type layoutType); // 0x00000001852667A0-0x0000000185266950
			public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription); // 0x0000000185264D50-0x0000000185264F50
			public bool HasLayout(InternedString name); // 0x0000000185267990-0x0000000185267A70
			private InputControlLayout TryLoadLayoutInternal(InternedString name); // 0x000000018D3846A0-0x000000018D384894
			public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null); // 0x000000018D384894-0x000000018D384CBC
			public InternedString GetBaseLayoutName(InternedString layoutName); // 0x000000018D3843DC-0x000000018D384464
			public InternedString GetRootLayoutName(InternedString layoutName); // 0x000000018D38452C-0x000000018D3845B8
			public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance); // 0x000000018D38412C-0x000000018D384208
			public InternedString FindLayoutThatIntroducesControl(InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache); // 0x000000018D384208-0x000000018D3843DC
			public System.Type GetControlTypeForLayout(InternedString layoutName); // 0x0000000186316D40-0x0000000186316E20
			public bool ValueTypeIsAssignableFrom(InternedString layoutName, System.Type valueType); // 0x000000018D384CBC-0x000000018D384D8C
			public bool IsGeneratedLayout(InternedString layout); // 0x000000018D384644-0x000000018D3846A0
			[IteratorStateMachine(typeof(_GetBaseLayouts_d__24))]
			public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true /* Metadata: 0x02623042 */); // 0x000000018D384464-0x000000018D38452C
			public bool IsBasedOn(InternedString parentLayout, InternedString childLayout); // 0x000000018D3845B8-0x000000018D384644
			public void AddMatcher(InternedString layout, InputDeviceMatcher matcher); // 0x0000000185264F50-0x0000000185265120
		}
	
		public class LayoutNotFoundException : Exception // TypeDefIndex: 72604
		{
			// Fields
			[CompilerGenerated]
			private readonly string _layout_k__BackingField; // 0x90
	
			// Properties
			public string layout { [CompilerGenerated] get; } // 0x0000000182271B70-0x0000000182271B80 
	
			// Constructors
			public LayoutNotFoundException(); // 0x000000018D30A2E4-0x000000018D30A330
			public LayoutNotFoundException(string name, string message); // 0x000000018D30A434-0x000000018D30A4A4
			public LayoutNotFoundException(string name); // 0x000000018D30A330-0x000000018D30A3D4
			public LayoutNotFoundException(string message, Exception innerException); // 0x000000018D30A3D4-0x000000018D30A434
			protected LayoutNotFoundException(SerializationInfo info, StreamingContext context); // 0x000000018D30A4A4-0x000000018D30A510
		}
	
		internal struct Cache // TypeDefIndex: 72605
		{
			// Fields
			public Dictionary<InternedString, InputControlLayout> table; // 0x00
	
			// Methods
			public void Clear(); // 0x000000018783574C-0x0000000187835758
			public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true /* Metadata: 0x02623047 */); // 0x000000018D300BFC-0x000000018D300D40
		}
	
		internal struct CacheRefInstance : IDisposable // TypeDefIndex: 72606
		{
			// Fields
			public bool valid; // 0x00
	
			// Methods
			public void Dispose(); // 0x000000018D300B64-0x000000018D300BFC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72607
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, InternedString> __9__52_0; // 0x08
			public static Func<string, InternedString> __9__75_0; // 0x10
			public static Func<string, InternedString> __9__75_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018D30C2F4-0x000000018D30C358
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal InternedString _FromType_b__52_0(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
			internal InternedString _CreateControlItemFromMember_b__75_0(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
			internal InternedString _CreateControlItemFromMember_b__75_1(string x); // 0x000000018D30C2D0-0x000000018D30C2F4
		}
	
		// Constructors
		private InputControlLayout(string name, System.Type type); // 0x000000018D38C410-0x000000018D38C460
		static InputControlLayout(); // 0x000000018718EE90-0x000000018718EF10
	
		// Methods
		public ControlItem? FindControl(InternedString path); // 0x000000018D3889F4-0x000000018D388CE0
		public ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex); // 0x000000018D388614-0x000000018D3889F4
		public System.Type GetValueType(); // 0x000000018D3891DC-0x000000018D389250
		public static InputControlLayout FromType(string name, System.Type type); // 0x000000018D388D8C-0x000000018D3891DC
		public string ToJson(); // 0x000000018D38C1B4-0x000000018D38C258
		public static InputControlLayout FromJson(string json); // 0x000000018D388CE0-0x000000018D388D8C
		private static void AddControlItems(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018D3878F4-0x000000018D387968
		private static void AddControlItemsFromFields(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018D387148-0x000000018D3871C4
		private static void AddControlItemsFromProperties(System.Type type, List<ControlItem> controlLayouts, string layoutName); // 0x000000018D387878-0x000000018D3878F4
		private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName); // 0x000000018D3873E4-0x000000018D387878
		private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems); // 0x000000018D3871C4-0x000000018D3873E4
		private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute); // 0x000000018D3879C0-0x000000018D388274
		private static string InferLayoutFromValueType(System.Type type); // 0x000000018D389250-0x000000018D389430
		public void MergeLayout(InputControlLayout other); // 0x000000018D389430-0x000000018D38C1B4
		private static Dictionary<string, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<string> variants = null); // 0x000000018D388274-0x000000018D388614
		internal static bool VariantsMatch(InternedString expected, InternedString actual); // 0x000000018D38C2CC-0x000000018D38C328
		internal static bool VariantsMatch(string expected, string actual); // 0x000000018D38C328-0x000000018D38C410
		internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher); // 0x0000000185B0A790-0x0000000185B0A920
		internal static CacheRefInstance CacheRef(); // 0x000000018D387968-0x000000018D3879C0
		[CompilerGenerated]
		private bool _MergeLayout_b__77_0(ControlItem x); // 0x000000018D38C258-0x000000018D38C2CC
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class InputControlLayoutAttribute : Attribute // TypeDefIndex: 72609
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
		public System.Type stateType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string stateFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string[] commonUsages { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string variants { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public bool isNoisy { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public bool canRunInBackground { get; set; } // 0x000000018D30309C-0x000000018D3030D8 0x000000018D303114-0x000000018D303160
		public bool updateBeforeRender { get; set; } // 0x000000018D3030D8-0x000000018D303114 0x000000018D303160-0x000000018D3031AC
		public bool isGenericTypeOfDevice { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182260CC0-0x0000000182260CD0 0x0000000182260CD0-0x0000000182260CE0
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public string description { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public bool hideInUI { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Constructors
		public InputControlLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal struct InputDeviceBuilder : IDisposable // TypeDefIndex: 72611
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x00
		private InputControlLayout.CacheRefInstance m_LayoutCacheRef; // 0x08
		private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x10
		private List<uint> m_StateOffsetToControlMap; // 0x18
		private StringBuilder m_StringBuilder; // 0x20
		private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; // Metadata: 0x02623048
		private static InputDeviceBuilder s_Instance; // 0x00
		private static int s_InstanceRef; // 0x28
	
		// Properties
		internal static ref InputDeviceBuilder instance { get; } // 0x000000018D30798C-0x000000018D3079C0 
	
		// Nested types
		internal struct RefInstance : IDisposable // TypeDefIndex: 72610
		{
			// Methods
			public void Dispose(); // 0x000000018D30B3E8-0x000000018D30B47C
		}
	
		// Methods
		public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = default); // 0x000000018D30779C-0x000000018D307910
		public UnityEngine.InputSystem.InputDevice Finish(); // 0x000000018D305A40-0x000000018D305D08
		public void Dispose(); // 0x000000018D3052C0-0x000000018D3052CC
		private void Reset(); // 0x000000018D307424-0x000000018D307494
		private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent); // 0x000000018D307360-0x000000018D3073E4
		private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent); // 0x000000018D306CB0-0x000000018D307360
		private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls); // 0x000000018D303B8C-0x000000018D3042D8
		private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null); // 0x000000018D303274-0x000000018D303B8C
		private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem); // 0x000000018D306270-0x000000018D3065A8
		private string ChildControlOverridePath(InputControl parent, InternedString controlName); // 0x000000018D3049F4-0x000000018D304A6C
		private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem); // 0x000000018D3031AC-0x000000018D303274
		private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem); // 0x000000018D3065A8-0x000000018D3069BC
		private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout); // 0x000000018D304818-0x000000018D3049F4
		private static void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, InputControl exceptControl); // 0x000000018D307910-0x000000018D30798C
		private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName); // 0x000000018D307494-0x000000018D30770C
		private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName); // 0x000000018D304564-0x000000018D304604
		private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName); // 0x000000018D304604-0x000000018D304818
		private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem); // 0x000000018D30770C-0x000000018D30779C
		private static InputControlLayout FindOrLoadLayout(string name); // 0x000000018D3059F0-0x000000018D305A40
		private static void ComputeStateLayout(InputControl control); // 0x000000018D304A6C-0x000000018D3052C0
		private void FinalizeControlHierarchy(); // 0x000000018D305758-0x000000018D3059F0
		private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex); // 0x000000018D3052CC-0x000000018D305758
		private void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset); // 0x000000018D3069BC-0x000000018D306CB0
		private ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset); // 0x000000018D305D08-0x000000018D3061A8
		private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex); // 0x000000018D304408-0x000000018D304564
		private void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right); // 0x000000018D3042D8-0x000000018D304408
		private ushort GetControlIndex(InputControl control); // 0x000000018D3061A8-0x000000018D306270
		internal static RefInstance Ref(); // 0x000000018D3073E4-0x000000018D307424
	}

	[Serializable]
	public struct InputDeviceDescription : IEquatable<InputDeviceDescription> // TypeDefIndex: 72613
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
		public string interfaceName { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public string deviceClass { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public string manufacturer { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string product { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string serial { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string version { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string capabilities { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool empty { get; } // 0x000000018D308068-0x000000018D3080D0 
	
		// Nested types
		private struct DeviceDescriptionJson // TypeDefIndex: 72612
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
		public override string ToString(); // 0x000000018D307E3C-0x000000018D308068
		public bool Equals(InputDeviceDescription other); // 0x000000018D307B18-0x000000018D307C10
		public override bool Equals(object obj); // 0x000000018D307A8C-0x000000018D307B18
		public override int GetHashCode(); // 0x000000018D307C10-0x000000018D307D30
		public static bool operator ==(InputDeviceDescription left, InputDeviceDescription right); // 0x000000018D3080D0-0x000000018D30810C
		public static bool operator !=(InputDeviceDescription left, InputDeviceDescription right); // 0x000000018D30810C-0x000000018D308148
		public string ToJson(); // 0x000000018D307D30-0x000000018D307E3C
		public static InputDeviceDescription FromJson(string json); // 0x0000000186314D70-0x0000000186314E80
		internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonParser.JsonString propertyValue, string deviceDescriptor); // 0x000000018D3079C0-0x000000018D307A8C
	}

	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher> // TypeDefIndex: 72618
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
		public bool empty { get; } // 0x00000001850BC1F0-0x00000001850BC200 
		public IEnumerable<KeyValuePair<string, object>> patterns { [IteratorStateMachine(typeof(_get_patterns_d__4))] get; } // 0x000000018D3085B4-0x000000018D308624 
	
		// Nested types
		[Serializable]
		internal struct MatcherJson // TypeDefIndex: 72615
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
			public struct Capability // TypeDefIndex: 72614
			{
				// Fields
				public string path; // 0x00
				public string value; // 0x08
			}
	
			// Methods
			public static MatcherJson FromMatcher(InputDeviceMatcher matcher); // 0x000000018D30A510-0x000000018D30A7D8
			public InputDeviceMatcher ToMatcher(); // 0x0000000185B0A920-0x0000000185B0AA40
		}
	
		[CompilerGenerated]
		private sealed class _get_patterns_d__4 : IEnumerable<KeyValuePair<string, object>>, IEnumerator<KeyValuePair<string, object>> // TypeDefIndex: 72616
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
			KeyValuePair<string, object> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { [DebuggerHidden] get; } // 0x00000001845C28E0-0x00000001845C28F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D30C55C-0x000000018D30C5A4 
	
			// Constructors
			[DebuggerHidden]
			public _get_patterns_d__4(int __1__state); // 0x0000000188E4A554-0x0000000188E4A570
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D30C358-0x000000018D30C474
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D30C510-0x000000018D30C55C
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator(); // 0x000000018D30C474-0x000000018D30C508
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D30C508-0x000000018D30C510
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72617
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<char, bool> __9__12_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5C00-0x00000001871E5C60
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _With_b__12_0(char ch); // 0x000000018693C100-0x000000018693C160
		}
	
		// Constructors
		static InputDeviceMatcher(); // 0x0000000186E41320-0x0000000186E41550
	
		// Methods
		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true /* Metadata: 0x02623049 */); // 0x000000018526A020-0x000000018526A0C0
		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true /* Metadata: 0x0262304A */); // 0x000000018D3084AC-0x000000018D308530
		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true /* Metadata: 0x0262304B */); // 0x0000000185B0C860-0x0000000185B0C900
		public InputDeviceMatcher WithManufacturerContains(string noRegExPattern); // 0x0000000185B0C900-0x0000000185B0C9C0
		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true /* Metadata: 0x0262304C */); // 0x0000000185B0C7C0-0x0000000185B0C860
		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true /* Metadata: 0x0262304D */); // 0x000000018D308530-0x000000018D3085B4
		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value);
		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true /* Metadata: 0x0262304E */); // 0x0000000185269350-0x0000000185269540
		public float MatchPercentage(InputDeviceDescription deviceDescription); // 0x0000000185265290-0x0000000185265650
		private static bool MatchSingleProperty(object pattern, string value); // 0x0000000185265650-0x00000001852656B0
		private static bool MatchSinglePropertyContains(object pattern, string value); // 0x0000000186CAB3A0-0x0000000186CAB410
		private static int GetNumPropertiesIn(InputDeviceDescription description); // 0x000000018D3082EC-0x000000018D308364
		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription); // 0x000000018D3081BC-0x000000018D3082EC
		public override string ToString(); // 0x000000018D308364-0x000000018D3084AC
		public bool Equals(InputDeviceMatcher other); // 0x0000000185265160-0x0000000185265270
		public override bool Equals(object obj); // 0x000000018D308148-0x000000018D3081BC
		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right); // 0x0000000185265120-0x0000000185265160
		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right); // 0x000000018D308624-0x000000018D308678
		public override int GetHashCode(); // 0x000000018AB02AA8-0x000000018AB02ACC
	}
}

namespace UnityEngine.InputSystem.LowLevel
{
	public struct DisableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 72457
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x02622E6B
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A4A0-0x000000018725A4B0 
		public FourCC typeStatic { get; } // 0x000000018725A4A0-0x000000018725A4B0 
	
		// Methods
		public static DisableDeviceCommand Create(); // 0x000000018725A480-0x000000018725A4A0
	}

	public struct EnableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 72458
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x02622E6C
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A770-0x000000018725A780 
		public FourCC typeStatic { get; } // 0x000000018725A770-0x000000018725A780 
	
		// Methods
		public static EnableDeviceCommand Create(); // 0x000000018725A750-0x000000018725A770
	}

	public struct EnableIMECompositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 72459
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x02622E6D
		public InputDeviceCommand baseCommand; // 0x00
		private byte m_ImeEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A780-0x000000018725A790 
		public bool imeEnabled { get; } // 0x000000018D37723C-0x000000018D377244 
		public FourCC typeStatic { get; } // 0x000000018725A780-0x000000018725A790 
	
		// Methods
		public static EnableIMECompositionCommand Create(bool enabled); // 0x000000018D377214-0x000000018D37723C
	}

	public interface IInputDeviceCommandInfo // TypeDefIndex: 72460
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo // TypeDefIndex: 72462
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x02622E6E
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A900-0x000000018725A910 
		public FourCC typeStatic { get; } // 0x000000018725A900-0x000000018725A910 
	
		// Nested types
		public enum Result // TypeDefIndex: 72461
		{
			ErrorAlreadyInProgress = -2,
			ErrorNotSupported = -1,
			SuccessfullyInitiated = 1
		}
	
		// Methods
		public static InitiateUserAccountPairingCommand Create(); // 0x000000018725A8E0-0x000000018725A900
	}

	public unsafe delegate long? InputDeviceCommandDelegate(UnityEngine.InputSystem.InputDevice device, InputDeviceCommand* command); // TypeDefIndex: 72463; 0x00000001812C43A0-0x00000001812C43E0

	public delegate long InputDeviceExecuteCommandDelegate(ref InputDeviceCommand command); // TypeDefIndex: 72464; 0x0000000185B78EA0-0x0000000185B78EB0

	public struct InputDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 72465
	{
		// Fields
		internal const int kBaseCommandSize = 8; // Metadata: 0x02622E73
		public const int BaseCommandSize = 8; // Metadata: 0x02622E74
		public const long GenericFailure = -1; // Metadata: 0x02622E75
		public const long GenericSuccess = 1; // Metadata: 0x02622E7D
		public FourCC type; // 0x00
		public int sizeInBytes; // 0x04
	
		// Properties
		public int payloadSizeInBytes { get; } // 0x000000018725A910-0x000000018725A920 
		public unsafe void* payloadPtr { get; } // 0x0000000187243120-0x0000000187243130 
		public FourCC typeStatic { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public InputDeviceCommand(FourCC type, int sizeInBytes = 8 /* Metadata: 0x02622E72 */); // 0x00000001827241A0-0x00000001827241B0
	
		// Methods
		public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize); // 0x0000000186316CA0-0x0000000186316D40
	}

	public struct QueryCanRunInBackground : IInputDeviceCommandInfo // TypeDefIndex: 72466
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x02622E85
		public InputDeviceCommand baseCommand; // 0x00
		public bool canRunInBackground; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A9D0-0x000000018725A9E0 
		public FourCC typeStatic { get; } // 0x000000018725A9D0-0x000000018725A9E0 
	
		// Methods
		public static QueryCanRunInBackground Create(); // 0x0000000186B016D0-0x0000000186B01700
	}

	public struct QueryDimensionsCommand : IInputDeviceCommandInfo // TypeDefIndex: 72467
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x02622E86
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 outDimensions; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AA10-0x000000018725AA20 
		public FourCC typeStatic { get; } // 0x000000018725AA10-0x000000018725AA20 
	
		// Methods
		public static QueryDimensionsCommand Create(); // 0x000000018725A9E0-0x000000018725AA10
	}

	public struct QueryEnabledStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 72468
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x02622E87
		public InputDeviceCommand baseCommand; // 0x00
		public bool isEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AA50-0x000000018725AA60 
		public FourCC typeStatic { get; } // 0x000000018725AA50-0x000000018725AA60 
	
		// Methods
		public static QueryEnabledStateCommand Create(); // 0x000000018725AA20-0x000000018725AA50
	}

	public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo // TypeDefIndex: 72470
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x02622E88
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AB00-0x000000018725AB10 
		public FourCC typeStatic { get; } // 0x000000018725AB00-0x000000018725AB10 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 72469
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadLayoutName(); // 0x000000018D37FB1C-0x000000018D37FB30
		public void WriteLayoutName(string name); // 0x000000018D37FB30-0x000000018D37FB5C
		public static QueryKeyboardLayoutCommand Create(); // 0x000000018725AAC0-0x000000018725AB00
	}

	public struct QueryKeyNameCommand : IInputDeviceCommandInfo // TypeDefIndex: 72472
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x02622E8A
		internal const int kSize = 268; // Metadata: 0x02622E8C
		public InputDeviceCommand baseCommand; // 0x00
		public int scanOrKeyCode; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x0C
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AAB0-0x000000018725AAC0 
		public FourCC typeStatic { get; } // 0x000000018725AAB0-0x000000018725AAC0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 72471
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadKeyName(); // 0x000000018D37FB08-0x000000018D37FB1C
		public static QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key); // 0x000000018725AA60-0x000000018725AAB0
	}

	public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo // TypeDefIndex: 72476
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x02622E8E
		internal const int kMaxIdLength = 256; // Metadata: 0x02622E90
		internal const int kSize = 1040; // Metadata: 0x02622E92
		public InputDeviceCommand baseCommand; // 0x00
		public ulong handle; // 0x08
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x10
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x210
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AB50-0x000000018725AB60 
		public string id { get; set; } // 0x000000018D37FB5C-0x000000018D37FB70 0x000000018D37FB84-0x000000018D37FCA8
		public string name { get; set; } // 0x000000018D37FB70-0x000000018D37FB84 0x000000018D37FCA8-0x000000018D37FDCC
		public FourCC typeStatic { get; } // 0x000000018725AB50-0x000000018725AB60 
	
		// Nested types
		[Flags]
		public enum Result : long // TypeDefIndex: 72473
		{
			DevicePairedToUserAccount = 2,
			UserAccountSelectionInProgress = 4,
			UserAccountSelectionComplete = 8,
			UserAccountSelectionCanceled = 16
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 72474
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 72475
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static QueryPairedUserAccountCommand Create(); // 0x000000018725AB10-0x000000018725AB50
	}

	internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 72477
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x02622EB4
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AB90-0x000000018725ABA0 
		public FourCC typeStatic { get; } // 0x000000018725AB90-0x000000018725ABA0 
	
		// Methods
		public static QuerySamplingFrequencyCommand Create(); // 0x000000018725AB60-0x000000018725AB90
	}

	internal struct QueryUserIdCommand : IInputDeviceCommandInfo // TypeDefIndex: 72479
	{
		// Fields
		public const int kMaxIdLength = 256; // Metadata: 0x02622EB5
		internal const int kSize = 520; // Metadata: 0x02622EB7
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725ABE0-0x000000018725ABF0 
		public FourCC typeStatic { get; } // 0x000000018725ABE0-0x000000018725ABF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 72478
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadId(); // 0x000000018D37FB1C-0x000000018D37FB30
		public static QueryUserIdCommand Create(); // 0x000000018725ABA0-0x000000018725ABE0
	}

	public struct RequestResetCommand : IInputDeviceCommandInfo // TypeDefIndex: 72480
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x02622EB9
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AC10-0x000000018725AC20 
		public FourCC typeStatic { get; } // 0x000000018725AC10-0x000000018725AC20 
	
		// Methods
		public static RequestResetCommand Create(); // 0x000000018725ABF0-0x000000018725AC10
	}

	public struct RequestSyncCommand : IInputDeviceCommandInfo // TypeDefIndex: 72481
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x02622EBA
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AC40-0x000000018725AC50 
		public FourCC typeStatic { get; } // 0x000000018725AC40-0x000000018725AC50 
	
		// Methods
		public static RequestSyncCommand Create(); // 0x000000018725AC20-0x000000018725AC40
	}

	public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 72482
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x02622EBB
		public InputDeviceCommand baseCommand; // 0x00
		private Vector2 m_Position; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725ACA0-0x000000018725ACB0 
		public Vector2 position { get; } // 0x000000018724A700-0x000000018724A720 
		public FourCC typeStatic { get; } // 0x000000018725ACA0-0x000000018725ACB0 
	
		// Methods
		public static SetIMECursorPositionCommand Create(Vector2 cursorPosition); // 0x000000018725AC80-0x000000018725ACA0
	}

	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 72483
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x02622EBC
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725ACE0-0x000000018725ACF0 
		public FourCC typeStatic { get; } // 0x000000018725ACE0-0x000000018725ACF0 
	
		// Methods
		public static SetSamplingFrequencyCommand Create(float frequency); // 0x000000018725ACB0-0x000000018725ACE0
	}

	internal struct WarpMousePositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 72484
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x02622EBD
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 warpPositionInPlayerDisplaySpace; // 0x08
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725AD70-0x000000018725AD80 
		public FourCC typeStatic { get; } // 0x000000018725AD70-0x000000018725AD80 
	
		// Methods
		public static WarpMousePositionCommand Create(Vector2 position); // 0x000000018725AD50-0x000000018725AD70
	}

	public struct GamepadState : IInputStateTypeInfo // TypeDefIndex: 72485
	{
		// Fields
		internal const string ButtonSouthShortDisplayName = "A"; // Metadata: 0x02622EBF
		internal const string ButtonNorthShortDisplayName = "Y"; // Metadata: 0x02622EC1
		internal const string ButtonWestShortDisplayName = "X"; // Metadata: 0x02622EC3
		internal const string ButtonEastShortDisplayName = "B"; // Metadata: 0x02622EC5
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
		public static FourCC Format { get; } // 0x000000018725A7F0-0x000000018725A800 
		public FourCC format { get; } // 0x000000018725A7F0-0x000000018725A800 
	
		// Constructors
		public GamepadState(params GamepadButton[] buttons); // 0x000000018D378AD4-0x000000018D378B7C
	
		// Methods
		public GamepadState WithButton(GamepadButton button, bool value = true /* Metadata: 0x02622EBE */); // 0x000000018D378A90-0x000000018D378AD4
	}

	public enum GamepadButton // TypeDefIndex: 72486
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

	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo // TypeDefIndex: 72487
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x02622EDF
		public InputDeviceCommand baseCommand; // 0x00
		public float lowFrequencyMotorSpeed; // 0x08
		public float highFrequencyMotorSpeed; // 0x0C
	
		// Properties
		public static FourCC Type { get; } // 0x000000018725A4E0-0x000000018725A4F0 
		public FourCC typeStatic { get; } // 0x000000018725A4E0-0x000000018725A4F0 
	
		// Methods
		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency); // 0x000000018725A4B0-0x000000018725A4E0
	}

	internal interface ICustomDeviceReset // TypeDefIndex: 72488
	{
		// Methods
		void Reset();
	}

	internal interface IEventMerger // TypeDefIndex: 72489
	{
		// Methods
		bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr);
	}

	internal interface IEventPreProcessor // TypeDefIndex: 72490
	{
		// Methods
		bool PreProcessEvent(InputEventPtr currentEventPtr);
	}

	public interface IInputUpdateCallbackReceiver // TypeDefIndex: 72491
	{
		// Methods
		void OnUpdate();
	}

	public interface ITextInputReceiver // TypeDefIndex: 72492
	{
		// Methods
		void OnTextInput(char character);
		void OnIMECompositionChanged(IMECompositionString compositionString);
	}

	internal struct JoystickState : IInputStateTypeInfo // TypeDefIndex: 72494
	{
		// Fields
		[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new string[3] {"PrimaryTrigger", "PrimaryAction", "Submit" }, bit = 4)]
		public int buttons; // 0x00
		[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
		public Vector2 stick; // 0x04
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A970-0x000000018725A980 
		public FourCC format { get; } // 0x000000018725A970-0x000000018725A980 
	
		// Nested types
		public enum Button // TypeDefIndex: 72493
		{
			HatSwitchUp = 0,
			HatSwitchDown = 1,
			HatSwitchLeft = 2,
			HatSwitchRight = 3,
			Trigger = 4
		}
	}

	public struct KeyboardState : IInputStateTypeInfo // TypeDefIndex: 72496
	{
		// Fields
		private const int kSizeInBits = 123; // Metadata: 0x02622EE5
		internal const int kSizeInBytes = 16; // Metadata: 0x02622EE7
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
		public static FourCC Format { get; } // 0x000000018725A980-0x000000018725A990 
		public FourCC format { get; } // 0x000000018725A980-0x000000018725A990 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _keys_e__FixedBuffer // TypeDefIndex: 72495
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe KeyboardState(params UnityEngine.InputSystem.Key[] pressedKeys); // 0x000000018D37F884-0x000000018D37F894
		public unsafe KeyboardState(bool IMESelected, params UnityEngine.InputSystem.Key[] pressedKeys); // 0x000000018D37F894-0x000000018D37F978
	
		// Methods
		public void Set(UnityEngine.InputSystem.Key key, bool state); // 0x000000018783BCC0-0x000000018783BCC8
		internal bool Get(UnityEngine.InputSystem.Key key); // 0x00000001853B0460-0x00000001853B0490
		public void Press(UnityEngine.InputSystem.Key key); // 0x000000018D37F86C-0x000000018D37F878
		public void Release(UnityEngine.InputSystem.Key key); // 0x000000018D37F878-0x000000018D37F884
	}

	public struct MouseState : IInputStateTypeInfo // TypeDefIndex: 72497
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
		public static FourCC Format { get; } // 0x000000018725A9A0-0x000000018725A9B0 
		public FourCC format { get; } // 0x000000018725A9A0-0x000000018725A9B0 
	
		// Methods
		public MouseState WithButton(MouseButton button, bool state = true /* Metadata: 0x02622EE8 */); // 0x000000018D37F978-0x000000018D37F9BC
	}

	public enum MouseButton // TypeDefIndex: 72498
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		Forward = 3,
		Back = 4
	}

	public struct PenState : IInputStateTypeInfo // TypeDefIndex: 72499
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
		public static FourCC Format { get; } // 0x000000018725A9B0-0x000000018725A9C0 
		public FourCC format { get; } // 0x000000018725A9B0-0x000000018725A9C0 
	
		// Methods
		public PenState WithButton(PenButton button, bool state = true /* Metadata: 0x02622EEE */); // 0x000000018D37FAC0-0x000000018D37FB08
	}

	internal struct PointerState : IInputStateTypeInfo // TypeDefIndex: 72500
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
		public static FourCC kFormat { get; } // 0x000000018725A9C0-0x000000018725A9D0 
		public FourCC format { get; } // 0x000000018725A9C0-0x000000018725A9D0 
	}

	internal struct AccelerometerState : IInputStateTypeInfo // TypeDefIndex: 72501
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A3A0-0x000000018725A3B0 
		public FourCC format { get; } // 0x000000018725A3A0-0x000000018725A3B0 
	}

	internal struct GyroscopeState : IInputStateTypeInfo // TypeDefIndex: 72502
	{
		// Fields
		[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = true)]
		public Vector3 angularVelocity; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A810-0x000000018725A820 
		public FourCC format { get; } // 0x000000018725A810-0x000000018725A820 
	}

	internal struct GravityState : IInputStateTypeInfo // TypeDefIndex: 72503
	{
		// Fields
		[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = true)]
		public Vector3 gravity; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A800-0x000000018725A810 
		public FourCC format { get; } // 0x000000018725A800-0x000000018725A810 
	}

	internal struct AttitudeState : IInputStateTypeInfo // TypeDefIndex: 72504
	{
		// Fields
		[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = true)]
		public Quaternion attitude; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A410-0x000000018725A420 
		public FourCC format { get; } // 0x000000018725A410-0x000000018725A420 
	}

	internal struct LinearAccelerationState : IInputStateTypeInfo // TypeDefIndex: 72505
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get; } // 0x000000018725A990-0x000000018725A9A0 
		public FourCC format { get; } // 0x000000018725A990-0x000000018725A9A0 
	}

	[Flags]
	internal enum TouchFlags : byte // TypeDefIndex: 72506
	{
		IndirectTouch = 1,
		PrimaryTouch = 8,
		TapPress = 16,
		TapRelease = 32,
		OrphanedPrimaryTouch = 64,
		BeganInSameFrame = 128
	}

	public struct TouchState : IInputStateTypeInfo // TypeDefIndex: 72507
	{
		// Fields
		internal const int kSizeInBytes = 56; // Metadata: 0x02622EF5
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
		public static FourCC Format { get; } // 0x000000018725ACF0-0x000000018725AD00 
		public UnityEngine.InputSystem.TouchPhase phase { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public bool isNoneEndedOrCanceled { get; } // 0x000000018D381E90-0x000000018D381EA8 
		public bool isInProgress { get; } // 0x000000018D381E70-0x000000018D381E88 
		public bool isPrimaryTouch { get; set; } // 0x000000018D381EB0-0x000000018D381EB8 0x000000018D381F34-0x000000018D381F58
		internal bool isOrphanedPrimaryTouch { get; set; } // 0x000000018D381EA8-0x000000018D381EB0 0x000000018D381F10-0x000000018D381F34
		public bool isIndirectTouch { get; set; } // 0x000000018D381E88-0x000000018D381E90 0x000000018D381EEC-0x000000018D381F10
		public bool isTap { get; set; } // 0x000000018D381EB8-0x000000018D381EC0 0x000000018D381F58-0x000000018D381F7C
		internal bool isTapPress { get; set; } // 0x000000018D381EB8-0x000000018D381EC0 0x000000018D381F58-0x000000018D381F7C
		internal bool isTapRelease { get; set; } // 0x000000018D381EC0-0x000000018D381EC8 0x000000018D381F7C-0x000000018D381FA0
		internal bool beganInSameFrame { get; set; } // 0x000000018D381E68-0x000000018D381E70 0x000000018D381EC8-0x000000018D381EEC
		public FourCC format { get; } // 0x000000018725ACF0-0x000000018725AD00 
	
		// Methods
		public override string ToString(); // 0x000000018D381C28-0x000000018D381E68
	}

	internal struct TouchscreenState : IInputStateTypeInfo // TypeDefIndex: 72510
	{
		// Fields
		public const int MaxTouches = 10; // Metadata: 0x02622EF6
		[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
		[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[0])]
		[InputControl(name = "displayIndex", useStateFrom = "primaryTouch/displayIndex", format = "BYTE")]
		[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
		[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
		[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
		[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
		[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte primaryTouchData[0]; // 0x00
		internal const int kTouchDataOffset = 56; // Metadata: 0x02622EF7
		[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte touchData[0]; // 0x38
	
		// Properties
		public static FourCC Format { get; } // 0x000000018725AD30-0x000000018725AD40 
		public unsafe TouchState* primaryTouch { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		public unsafe TouchState* touches { get; } // 0x000000018725AD40-0x000000018725AD50 
		public FourCC format { get; } // 0x000000018725AD30-0x000000018725AD40 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _primaryTouchData_e__FixedBuffer // TypeDefIndex: 72508
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _touchData_e__FixedBuffer // TypeDefIndex: 72509
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ActionEvent : IInputEventTypeInfo // TypeDefIndex: 72512
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
		public static FourCC Type { get; } // 0x000000018725A3C0-0x000000018725A3D0 
		public double startTime { get; set; } // 0x000000018725A3D0-0x000000018725A3E0 0x000000018725A400-0x000000018725A410
		public InputActionPhase phase { get; set; } // 0x00000001872364A0-0x00000001872364B0 0x00000001872364D0-0x00000001872364E0
		public unsafe byte* valueData { get; } // 0x000000018725A3E0-0x000000018725A3F0 
		public int valueSizeInBytes { get; } // 0x000000018725A3F0-0x000000018725A400 
		public int stateIndex { get; set; } // 0x000000018226EDC0-0x000000018226EDD0 0x000000018D374B40-0x000000018D374BAC
		public int controlIndex { get; set; } // 0x0000000187244E60-0x0000000187244E70 0x000000018D374A58-0x000000018D374AC4
		public int bindingIndex { get; set; } // 0x0000000187247620-0x0000000187247630 0x000000018D3749EC-0x000000018D374A58
		public int interactionIndex { get; set; } // 0x000000018D3749D4-0x000000018D3749EC 0x000000018D374AC4-0x000000018D374B40
		public FourCC typeStatic { get; } // 0x000000018725A3C0-0x000000018725A3D0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_ValueData_e__FixedBuffer // TypeDefIndex: 72511
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static int GetEventSizeWithValueSize(int valueSizeInBytes); // 0x000000018725A3B0-0x000000018725A3C0
		public static unsafe ActionEvent* From(InputEventPtr ptr); // 0x000000018D374898-0x000000018D3749D4
	}

	public struct DeltaStateEvent : IInputEventTypeInfo // TypeDefIndex: 72514
	{
		// Fields
		public const int Type = 1145852993; // Metadata: 0x02622EF9
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		public uint stateOffset; // 0x18
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x1C
	
		// Properties
		public uint deltaStateSizeInBytes { get; } // 0x000000018725A420-0x000000018725A430 
		public unsafe void* deltaState { get; } // 0x000000018725A430-0x000000018725A440 
		public FourCC typeStatic { get; } // 0x000000018725A440-0x000000018725A450 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 72513
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static unsafe DeltaStateEvent* From(InputEventPtr ptr); // 0x000000018D374E70-0x000000018D374FAC
		internal static unsafe DeltaStateEvent* FromUnchecked(InputEventPtr ptr); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x02622EF8 */); // 0x000000018D374BAC-0x000000018D374E70
	}

	public struct DeviceConfigurationEvent : IInputEventTypeInfo // TypeDefIndex: 72515
	{
		// Fields
		public const int Type = 1145259591; // Metadata: 0x02622EFE
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get; } // 0x000000018725A450-0x000000018725A460 
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static DeviceConfigurationEvent Create(int deviceId, double time); // 0x000000018D374FAC-0x000000018D375004
	}

	public struct DeviceRemoveEvent : IInputEventTypeInfo // TypeDefIndex: 72516
	{
		// Fields
		public const int Type = 1146242381; // Metadata: 0x02622F0B
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get; } // 0x000000018725A460-0x000000018725A470 
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static DeviceRemoveEvent Create(int deviceId, double time = -1 /* Metadata: 0x02622F03 */); // 0x000000018D375004-0x000000018D37505C
	}

	public struct DeviceResetEvent : IInputEventTypeInfo // TypeDefIndex: 72517
	{
		// Fields
		public const int Type = 1146245972; // Metadata: 0x02622F19
		public InputEvent baseEvent; // 0x00
		public bool hardReset; // 0x08
	
		// Properties
		public FourCC typeStatic { get; } // 0x000000018725A470-0x000000018725A480 
	
		// Methods
		public static DeviceResetEvent Create(int deviceId, bool hardReset = false /* Metadata: 0x02622F10 */, double time = -1 /* Metadata: 0x02622F11 */); // 0x000000018D37505C-0x000000018D3750C4
	}

	public interface IInputEventTypeInfo // TypeDefIndex: 72518
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct IMECompositionEvent : IInputEventTypeInfo // TypeDefIndex: 72519
	{
		// Fields
		internal const int kIMECharBufferSize = 64; // Metadata: 0x02622F1E
		public const int Type = 1229800787; // Metadata: 0x02622F20
		public InputEvent baseEvent; // 0x00
		public IMECompositionString compositionString; // 0x14
	
		// Properties
		public FourCC typeStatic { get; } // 0x000000018725A8D0-0x000000018725A8E0 
	
		// Methods
		public static IMECompositionEvent Create(int deviceId, string compositionString, double time); // 0x000000018D37BBAC-0x000000018D37BCAC
	}

	public struct IMECompositionString : IEnumerable<char> // TypeDefIndex: 72522
	{
		// Fields
		private int size; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ char buffer[0]; // 0x04
	
		// Properties
		public int Count { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public char this[int index] { get => default; } // 0x000000018D37BE70-0x000000018D37BEE0 
	
		// Nested types
		internal struct Enumerator : IEnumerator<char> // TypeDefIndex: 72520
		{
			// Fields
			private IMECompositionString m_CompositionString; // 0x00
			private char m_CurrentCharacter; // 0x84
			private int m_CurrentIndex; // 0x88
	
			// Properties
			public char Current { get; } // 0x000000018724AF00-0x000000018724AF10 
			object IEnumerator.Current { get; } // 0x000000018D377818-0x000000018D377860 
	
			// Constructors
			public Enumerator(IMECompositionString compositionString); // 0x000000018725A790-0x000000018725A7F0
	
			// Methods
			public bool MoveNext(); // 0x000000018D377744-0x000000018D377770
			public void Reset(); // 0x0000000187258F70-0x0000000187258F80
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 72521
		{
			// Fields
			public char FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe IMECompositionString(string characters); // 0x000000018D37BE04-0x000000018D37BE70
	
		// Methods
		public override string ToString(); // 0x000000018D37BDE0-0x000000018D37BE04
		public IEnumerator<char> GetEnumerator(); // 0x000000018D37BCAC-0x000000018D37BDD8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D37BDD8-0x000000018D37BDE0
	}

	public struct InputEvent // TypeDefIndex: 72523
	{
		// Fields
		private const uint kHandledMask = 2147483648; // Metadata: 0x02622F2D
		private const uint kIdMask = 2147483647; // Metadata: 0x02622F32
		internal const int kBaseEventSize = 20; // Metadata: 0x02622F37
		public const int InvalidEventId = 0; // Metadata: 0x02622F38
		internal const int kAlignment = 4; // Metadata: 0x02622F39
		private NativeInputEvent m_Event; // 0x00
	
		// Properties
		public FourCC type { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public uint sizeInBytes { get; set; } // 0x0000000187234250-0x0000000187234260 0x000000018526BE80-0x000000018526BEA0
		public int eventId { get; set; } // 0x000000018725A950-0x000000018725A960 0x000000018725A960-0x000000018725A970
		public int deviceId { get; set; } // 0x0000000187234240-0x0000000187234250 0x0000000187256AF0-0x0000000187256B00
		public double time { get; set; } // 0x000000018D37F828-0x000000018D37F86C 0x000000018526B6C0-0x000000018526B720
		internal double internalTime { get; set; } // 0x000000018724A3F0-0x000000018724A400 0x000000018724CA60-0x000000018724CA70
		public bool handled { get; set; } // 0x00000001864C5360-0x00000001864C5370 0x000000018644A0F0-0x000000018644A110
	
		// Constructors
		public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1 /* Metadata: 0x02622F25 */); // 0x0000000186292960-0x00000001862929C0
	
		// Methods
		public override string ToString(); // 0x000000018D37F664-0x000000018D37F828
		internal static unsafe InputEvent* GetNextInMemory(InputEvent* currentPtr); // 0x00000001853AD640-0x00000001853AD690
		internal static unsafe InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer); // 0x000000018D37F564-0x000000018D37F664
		public static unsafe bool Equals(InputEvent* first, InputEvent* second); // 0x000000018D37F528-0x000000018D37F564
	}

	public struct InputEventBuffer : IEnumerable<InputEventPtr>, IDisposable, ICloneable // TypeDefIndex: 72525
	{
		// Fields
		public const long BufferSizeUnknown = -1; // Metadata: 0x02622F44
		private NativeArray<byte> m_Buffer; // 0x00
		private long m_SizeInBytes; // 0x10
		private int m_EventCount; // 0x18
		private bool m_WeOwnTheBuffer; // 0x1C
	
		// Properties
		public int eventCount { get; } // 0x00000001844AF510-0x00000001844AF520 
		public long sizeInBytes { get; } // 0x00000001829260F0-0x0000000182926100 
		public long capacityInBytes { get; } // 0x00000001871F5720-0x00000001871F5760 
		public NativeArray<byte> data { get; } // 0x000000018723AC80-0x000000018723AC90 
		public InputEventPtr bufferPtr { get; } // 0x000000018D37C5CC-0x000000018D37C5FC 
	
		// Nested types
		private struct Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 72524
		{
			// Fields
			private readonly unsafe InputEvent* m_Buffer; // 0x00
			private readonly int m_EventCount; // 0x08
			private unsafe InputEvent* m_CurrentEvent; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public InputEventPtr Current { get; } // 0x00000001829260F0-0x0000000182926100 
			object IEnumerator.Current { get; } // 0x000000018D377770-0x000000018D3777B8 
	
			// Constructors
			public unsafe Enumerator(InputEventBuffer buffer); // 0x000000018D37788C-0x000000018D3778C4
	
			// Methods
			public bool MoveNext(); // 0x000000018D3776F4-0x000000018D377744
			public void Reset(); // 0x000000018723DE80-0x000000018723DE90
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1 /* Metadata: 0x02622F3A */, int capacityInBytes = -1 /* Metadata: 0x02622F3B */); // 0x00000001853AD7E0-0x00000001853AD8E0
		public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1 /* Metadata: 0x02622F3C */, bool transferNativeArrayOwnership = false /* Metadata: 0x02622F3D */); // 0x000000018D37C494-0x000000018D37C5CC
	
		// Methods
		public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048 /* Metadata: 0x02622F3E */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02622F40 */); // 0x000000018D37C1CC-0x000000018D37C264
		public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048 /* Metadata: 0x02622F41 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02622F43 */); // 0x000000018D37BF64-0x000000018D37C1CC
		public unsafe bool Contains(InputEvent* eventPtr); // 0x000000018D37C328-0x000000018D37C358
		public void Reset(); // 0x00000001861B9200-0x00000001861B9220
		internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer); // 0x00000001853ACC50-0x00000001853ACCC0
		public IEnumerator<InputEventPtr> GetEnumerator(); // 0x000000018D37C3AC-0x000000018D37C42C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D37C42C-0x000000018D37C434
		public void Dispose(); // 0x000000018D37C358-0x000000018D37C3AC
		public InputEventBuffer Clone(); // 0x000000018D37C264-0x000000018D37C328
		object ICloneable.Clone(); // 0x000000018D37C434-0x000000018D37C494
	}

	public struct InputEventListener : IObservable<InputEventPtr> // TypeDefIndex: 72528
	{
		// Fields
		internal static ObserverState s_ObserverState; // 0x00
	
		// Nested types
		internal class ObserverState // TypeDefIndex: 72526
		{
			// Fields
			public InlinedArray<IObserver<InputEventPtr>> observers; // 0x10
			public Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28
	
			// Constructors
			public ObserverState(); // 0x000000018D37FA44-0x000000018D37FAC0
	
			// Methods
			[CompilerGenerated]
			private void _.ctor_b__2_0(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018D37F9BC-0x000000018D37FA44
		}
	
		private class DisposableObserver : IDisposable // TypeDefIndex: 72527
		{
			// Fields
			public IObserver<InputEventPtr> observer; // 0x10
	
			// Constructors
			public DisposableObserver(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Dispose(); // 0x000000018D3750C4-0x000000018D3751EC
		}
	
		// Methods
		public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback); // 0x000000018D37C778-0x000000018D37C8E8
		public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback); // 0x000000018D37C8E8-0x000000018D37CA58
		public IDisposable Subscribe(IObserver<InputEventPtr> observer); // 0x000000018D37C5FC-0x000000018D37C778
	}

	public struct InputEventPtr : IEquatable<InputEventPtr> // TypeDefIndex: 72529
	{
		// Fields
		private readonly unsafe InputEvent* m_EventPtr; // 0x00
	
		// Properties
		public bool valid { get; } // 0x00000001853AE700-0x00000001853AE710 
		public bool handled { get; set; } // 0x000000018D37CB60-0x000000018D37CB80 0x000000018D37CDFC-0x000000018D37CE6C
		public int id { get; set; } // 0x000000018D37CB80-0x000000018D37CB94 0x000000018D37CE6C-0x000000018D37CEE4
		public FourCC type { get; } // 0x00000001853AE6F0-0x00000001853AE700 
		public uint sizeInBytes { get; } // 0x000000018623C610-0x000000018623C630 
		public int deviceId { get; set; } // 0x000000018D37CB4C-0x000000018D37CB60 0x000000018D37CD8C-0x000000018D37CDFC
		public double time { get; set; } // 0x000000018D37CD6C-0x000000018D37CD8C 0x000000018D37CF54-0x000000018D37CFC4
		internal double internalTime { get; set; } // 0x00000001853ADA50-0x00000001853ADA70 0x000000018D37CEE4-0x000000018D37CF54
		public unsafe InputEvent* data { get; } // 0x0000000184431970-0x0000000184431980 
		internal FourCC stateFormat { get; } // 0x0000000186252430-0x0000000186252470 
		internal uint stateSizeInBytes { get; } // 0x000000018D37CC64-0x000000018D37CD6C 
		internal uint stateOffset { get; } // 0x000000018D37CB94-0x000000018D37CC64 
	
		// Constructors
		public unsafe InputEventPtr(InputEvent* eventPtr); // 0x000000018561B5B0-0x000000018561B5C0
	
		// Methods
		public bool IsA<TOtherEvent>()
			where TOtherEvent : struct, IInputEventTypeInfo;
		public InputEventPtr Next(); // 0x000000018D37CAD4-0x000000018D37CAF4
		public override string ToString(); // 0x000000018D37CAF4-0x000000018D37CB4C
		public unsafe InputEvent* ToPointer(); // 0x0000000184431970-0x0000000184431980
		public bool Equals(InputEventPtr other); // 0x000000018D37CABC-0x000000018D37CAD4
		public override bool Equals(object obj); // 0x000000018D37CA58-0x000000018D37CABC
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public static bool operator ==(InputEventPtr left, InputEventPtr right); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public static bool operator !=(InputEventPtr left, InputEventPtr right); // 0x0000000184F9E9E0-0x0000000184F9E9F0
		public static unsafe implicit operator InputEventPtr(InputEvent* eventPtr); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static unsafe InputEventPtr From(InputEvent* eventPtr); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static unsafe implicit operator InputEvent*(InputEventPtr eventPtr); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static unsafe InputEvent* FromInputEventPtr(InputEventPtr eventPtr); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	internal struct InputEventStream // TypeDefIndex: 72530
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
		public bool isOpen { get; } // 0x0000000182271A20-0x0000000182271A30 
		public int remainingEventCount { get; } // 0x000000018725A920-0x000000018725A930 
		public int numEventsRetainedInBuffer { get; } // 0x00000001872333A0-0x00000001872333B0 
		public unsafe InputEvent* currentEventPtr { get; } // 0x00000001853ACC20-0x00000001853ACC40 
		public uint numBytesRetainedInBuffer { get; } // 0x000000018D37D174-0x000000018D37D1A8 
	
		// Constructors
		public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents); // 0x0000000186210730-0x0000000186210780
	
		// Methods
		public void Close(ref InputEventBuffer eventBuffer); // 0x00000001861B91A0-0x00000001861B9200
		public void CleanUpAfterException(); // 0x000000018D37CFC4-0x000000018D37D018
		public unsafe void Write(InputEvent* eventPtr); // 0x000000018D37D018-0x000000018D37D174
		public unsafe InputEvent* Advance(bool leaveEventInBuffer); // 0x00000001853ACBA0-0x00000001853ACC20
		public unsafe InputEvent* Peek(); // 0x00000001853ACDF0-0x00000001853ACE40
	}

	[Serializable]
	public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr> // TypeDefIndex: 72537
	{
		// Fields
		private const int kDefaultBufferSize = 1048576; // Metadata: 0x02622F86
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
		public static FourCC FrameMarkerEvent { get; } // 0x000000018725A930-0x000000018725A940 
		public int deviceId { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public bool enabled { get; } // 0x0000000187239C50-0x0000000187239C60 
		public bool recordFrameMarkers { get; set; } // 0x0000000187236210-0x0000000187236220 0x000000018D37F440-0x000000018D37F528
		public long eventCount { get; } // 0x0000000182271B70-0x0000000182271B80 
		public long totalEventSizeInBytes { get; } // 0x0000000187232C70-0x0000000187232C80 
		public long allocatedSizeInBytes { get; } // 0x000000018D37F384-0x000000018D37F398 
		public long maxSizeInBytes { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public ReadOnlyArray<DeviceInfo> deviceInfos { get; } // 0x000000018D37F398-0x000000018D37F3F4 
		public Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> onFilterEvent { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		private unsafe byte* m_EventBuffer { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x00000001865CCBD0-0x00000001865CCBE0
		private unsafe byte* m_EventBufferHead { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x00000001865CCBC0-0x00000001865CCBD0
		private unsafe byte* m_EventBufferTail { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x00000001865C0760-0x00000001865C0770
		private static FourCC kFileFormat { get; } // 0x000000018725A940-0x000000018725A950 
	
		// Events
		public event Action<InputEventPtr> onEvent {
			add; // 0x000000018D37F338-0x000000018D37F384
			remove; // 0x000000018D37F3F4-0x000000018D37F440
		}
	
		// Nested types
		private class Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 72531
		{
			// Fields
			private InputEventTrace m_Trace; // 0x10
			private int m_ChangeCounter; // 0x18
			internal InputEventPtr m_Current; // 0x20
	
			// Properties
			public InputEventPtr Current { get; } // 0x000000018225E800-0x000000018225E810 
			object IEnumerator.Current { get; } // 0x000000018D38703C-0x000000018D387084 
	
			// Constructors
			public Enumerator(InputEventTrace trace); // 0x000000018D3870DC-0x000000018D38710C
	
			// Methods
			public void Dispose(); // 0x000000018D386F14-0x000000018D386F38
			public bool MoveNext(); // 0x000000018D386F38-0x000000018D387018
			public void Reset(); // 0x000000018D387018-0x000000018D38703C
		}
	
		[Flags]
		private enum FileFlags // TypeDefIndex: 72532
		{
			FixedUpdate = 1
		}
	
		public class ReplayController : IDisposable // TypeDefIndex: 72535
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
			public InputEventTrace trace { get; } // 0x0000000182234E30-0x0000000182234E40 
			public bool finished { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
			public bool paused { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235410-0x0000000187235420 0x0000000187235420-0x0000000187235430
			public int position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
			public IEnumerable<UnityEngine.InputSystem.InputDevice> createdDevices { get; } // 0x000000018D39349C-0x000000018D3934EC 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 72533
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<InputEventPtr> __9__38_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D3941E4-0x000000018D394304
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal int _PlayAllEventsAccordingToTimestamps_b__38_0(InputEventPtr a, InputEventPtr b); // 0x000000018D394074-0x000000018D3940B8
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass43_0 // TypeDefIndex: 72534
			{
				// Fields
				public int originalDeviceId; // 0x10
	
				// Constructors
				public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _ApplyDeviceMapping_b__0(DeviceInfo x); // 0x0000000182A92250-0x0000000182A92270
			}
	
			// Constructors
			internal ReplayController(InputEventTrace trace); // 0x000000018D393428-0x000000018D39349C
	
			// Methods
			public void Dispose(); // 0x000000018D3925C4-0x000000018D392774
			public ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice); // 0x000000018D39324C-0x000000018D393320
			public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId); // 0x000000018D393320-0x000000018D393428
			public ReplayController WithAllDevicesMappedToNewInstances(); // 0x000000018725AE10-0x000000018725AE20
			public ReplayController OnFinished(Action action); // 0x0000000188C89124-0x0000000188C89140
			public ReplayController OnEvent(Action<InputEventPtr> action); // 0x0000000188C89140-0x0000000188C8915C
			public ReplayController PlayOneEvent(); // 0x000000018D392FAC-0x000000018D393040
			public ReplayController Rewind(); // 0x000000018D393208-0x000000018D39324C
			public ReplayController PlayAllFramesOneByOne(); // 0x000000018D392F14-0x000000018D392FAC
			public ReplayController PlayAllEvents(); // 0x000000018D392E6C-0x000000018D392F14
			public ReplayController PlayAllEventsAccordingToTimestamps(); // 0x000000018D392C18-0x000000018D392E6C
			private void OnBeginFrame(); // 0x000000018D392A8C-0x000000018D392C18
			private void Finished(); // 0x000000018D392774-0x000000018D392818
			private void QueueEvent(InputEventPtr eventPtr); // 0x000000018D393040-0x000000018D393208
			private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr); // 0x000000018D392818-0x000000018D392A8C
			private int ApplyDeviceMapping(int originalDeviceId); // 0x000000018D392268-0x000000018D3925C4
		}
	
		[Serializable]
		public struct DeviceInfo // TypeDefIndex: 72536
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
			public int deviceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
			public string layout { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
			public FourCC stateFormat { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			public int stateSizeInBytes { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		}
	
		// Constructors
		public InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes = 1048576 /* Metadata: 0x02622F4C */, bool growBuffer = false /* Metadata: 0x02622F54 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x02622F55 */, long growIncrementSizeInBytes = -1 /* Metadata: 0x02622F5D */); // 0x000000018D37F290-0x000000018D37F338
		public InputEventTrace(long bufferSizeInBytes = 1048576 /* Metadata: 0x02622F65 */, bool growBuffer = false /* Metadata: 0x02622F6D */, long maxBufferSizeInBytes = -1 /* Metadata: 0x02622F6E */, long growIncrementSizeInBytes = -1 /* Metadata: 0x02622F76 */); // 0x000000018D37F24C-0x000000018D37F290
		static InputEventTrace(); // 0x000000018D37F1D4-0x000000018D37F24C
	
		// Methods
		public void WriteTo(string filePath); // 0x000000018D37F0B4-0x000000018D37F1D4
		public void WriteTo(Stream stream); // 0x000000018D37EAB0-0x000000018D37F0B4
		public void ReadFrom(string filePath); // 0x000000018D37DD90-0x000000018D37DEB0
		public void ReadFrom(Stream stream); // 0x000000018D37DEB0-0x000000018D37E7A0
		public static InputEventTrace LoadFrom(string filePath); // 0x000000018D37D668-0x000000018D37D7A8
		public static InputEventTrace LoadFrom(Stream stream); // 0x000000018D37D518-0x000000018D37D668
		public ReplayController Replay(); // 0x000000018D37E7E0-0x000000018D37E84C
		public bool Resize(long newBufferSize, long newMaxBufferSize = -1 /* Metadata: 0x02622F7E */); // 0x000000018D37E84C-0x000000018D37EAA8
		public void Clear(); // 0x000000018D37D1D4-0x000000018D37D208
		public void Enable(); // 0x000000018D37D314-0x000000018D37D42C
		public void Disable(); // 0x000000018D37D208-0x000000018D37D2F4
		public bool GetNextEvent(ref InputEventPtr current); // 0x000000018D37D48C-0x000000018D37D518
		public IEnumerator<InputEventPtr> GetEnumerator(); // 0x000000018D37D42C-0x000000018D37D48C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D37EAA8-0x000000018D37EAB0
		public void Dispose(); // 0x000000018D37D2F4-0x000000018D37D314
		private void Allocate(); // 0x000000018D37D1A8-0x000000018D37D1D4
		private void Release(); // 0x000000018D37E7A0-0x000000018D37E7E0
		private void OnBeforeUpdate(); // 0x000000018D37D7A8-0x000000018D37D884
		private void OnInputEvent(InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device); // 0x000000018D37D884-0x000000018D37DD90
	}

	public struct StateEvent : IInputEventTypeInfo // TypeDefIndex: 72539
	{
		// Fields
		public const int Type = 1398030676; // Metadata: 0x02622F8D
		internal const int kStateDataSizeToSubtract = 1; // Metadata: 0x02622F92
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x18
	
		// Properties
		public uint stateSizeInBytes { get; } // 0x000000018725AEA0-0x000000018725AEB0 
		public unsafe void* state { get; } // 0x000000018725AEB0-0x000000018725AEC0 
		public FourCC typeStatic { get; } // 0x000000018725AEC0-0x000000018725AED0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 72538
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public TState GetState<TState>()
			where TState : struct, IInputStateTypeInfo;
		public static TState GetState<TState>(InputEventPtr ptr)
			where TState : struct, IInputStateTypeInfo;
		public static int GetEventSizeWithPayload<TState>()
			where TState : struct;
		public static unsafe StateEvent* From(InputEventPtr ptr); // 0x000000018D393AAC-0x000000018D393BE8
		internal static unsafe StateEvent* FromUnchecked(InputEventPtr ptr); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x02622F8B */); // 0x000000018D393A7C-0x000000018D393AAC
		public static NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x02622F8C */); // 0x000000018D3937C8-0x000000018D3937F8
		private static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState); // 0x000000018D3937F8-0x000000018D393A7C
	}

	public struct TextEvent : IInputEventTypeInfo // TypeDefIndex: 72540
	{
		// Fields
		public const int Type = 1413830740; // Metadata: 0x02622FA3
		public InputEvent baseEvent; // 0x00
		public int character; // 0x14
	
		// Properties
		public FourCC typeStatic { get; } // 0x000000018725AED0-0x000000018725AEE0 
	
		// Methods
		public static unsafe TextEvent* From(InputEventPtr eventPtr); // 0x000000018D393F24-0x000000018D394060
		public static TextEvent Create(int deviceId, char character, double time = -1 /* Metadata: 0x02622F93 */); // 0x000000018D393E54-0x000000018D393EBC
		public static TextEvent Create(int deviceId, int character, double time = -1 /* Metadata: 0x02622F9B */); // 0x000000018D393EBC-0x000000018D393F24
	}

	internal delegate void InputUpdateDelegate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // TypeDefIndex: 72541; 0x00000001859B7730-0x00000001859B7740

	internal interface IInputRuntime // TypeDefIndex: 72542
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

	internal static class InputRuntime // TypeDefIndex: 72543
	{
		// Fields
		public static IInputRuntime s_Instance; // 0x00
		public static double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x08
	}

	internal static class InputRuntimeExtensions // TypeDefIndex: 72544
	{
		// Extension methods
		public static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo;
	}

	[Serializable]
	public struct InputMetrics // TypeDefIndex: 72545
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
		public int maxNumDevices { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int currentNumDevices { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public int maxStateSizeInBytes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		public int currentStateSizeInBytes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431980-0x0000000184431990 0x00000001872397D0-0x00000001872397E0
		public int currentControlCount { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public int currentLayoutCount { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public int totalEventBytes { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int totalEventCount { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public int totalUpdateCount { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public double totalEventProcessingTime { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233230-0x0000000187233240 0x0000000187233250-0x0000000187233260
		public double totalEventLagTime { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233310-0x0000000187233320 0x0000000187233320-0x0000000187233330
		public float averageEventBytesPerFrame { get; } // 0x000000018D38CB14-0x000000018D38CB2C 
		public double averageProcessingTimePerEvent { get; } // 0x000000018D38CB40-0x000000018D38CB54 
		public double averageLagTimePerEvent { get; } // 0x000000018D38CB2C-0x000000018D38CB40 
	}

	[Flags]
	public enum InputUpdateType // TypeDefIndex: 72546
	{
		None = 0,
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		Default = 11,
		Manual = 16
	}

	internal static class InputUpdate // TypeDefIndex: 72549
	{
		// Fields
		public static uint s_UpdateStepCount; // 0x00
		public static InputUpdateType s_LatestUpdateType; // 0x04
		public static UpdateStepCount s_PlayerUpdateStepCount; // 0x08
	
		// Nested types
		[Serializable]
		public struct UpdateStepCount // TypeDefIndex: 72547
		{
			// Fields
			private bool m_WasUpdated; // 0x00
			[CompilerGenerated]
			private uint _value_k__BackingField; // 0x04
	
			// Properties
			public uint value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
	
			// Methods
			public void OnBeforeUpdate(); // 0x000000018725AEE0-0x000000018725AEF0
			public void OnUpdate(); // 0x00000001860A31F0-0x00000001860A3200
		}
	
		[Serializable]
		public struct SerializedState // TypeDefIndex: 72548
		{
			// Fields
			public InputUpdateType lastUpdateType; // 0x00
			public UpdateStepCount playerUpdateStepCount; // 0x04
		}
	
		// Methods
		internal static void OnBeforeUpdate(InputUpdateType type); // 0x000000018611B520-0x000000018611B570
		internal static void OnUpdate(InputUpdateType type); // 0x00000001860A3190-0x00000001860A31F0
		public static SerializedState Save(); // 0x000000018D3902AC-0x000000018D3902F8
		public static void Restore(SerializedState state); // 0x0000000185B0A4A0-0x0000000185B0A530
	
		// Extension methods
		public static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask); // 0x000000018526BE50-0x000000018526BE70
		public static bool IsPlayerUpdate(this InputUpdateType updateType); // 0x00000001853AD970-0x00000001853AD980
	}

	internal class NativeInputRuntime : IInputRuntime // TypeDefIndex: 72553
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
		public InputUpdateDelegate onUpdate { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018668E540-0x000000018668E650
		public Action<InputUpdateType> onBeforeUpdate { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000186FC4160-0x0000000186FC4280
		public Func<InputUpdateType, bool> onShouldRunUpdate { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018668E310-0x000000018668E430
		public Action<int, string> onDeviceDiscovered { get; set; } // 0x000000018D3913F8-0x000000018D391438 0x000000018668EA30-0x000000018668EA80
		public Action onShutdown { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D391470-0x000000018D391544
		public Action<bool> onPlayerFocusChanged { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x000000018668F3E0-0x000000018668F490
		public bool isPlayerFocused { get; } // 0x000000018783C5E0-0x000000018783C5E8 
		public float pollingFrequency { get; set; } // 0x0000000187235380-0x0000000187235390 0x000000018668EA80-0x000000018668EAE0
		public double currentTime { get; } // 0x00000001853AE4F0-0x00000001853AE540 
		public double currentTimeForFixedUpdate { get; } // 0x000000018D3913B8-0x000000018D3913F0 
		public double currentTimeOffsetToRealtimeSinceStartup { get; } // 0x00000001853AD8E0-0x00000001853AD930 
		public float unscaledGameTime { get; } // 0x000000018783585C-0x0000000187835864 
		public bool runInBackground { get; set; } // 0x000000018526D100-0x000000018526D130 0x0000000182A819C0-0x0000000182A819D0
		public Vector2 screenSize { get; } // 0x000000018D391438-0x000000018D391470 
		public ScreenOrientation screenOrientation { get; } // 0x0000000187834B5C-0x0000000187834B68 
		public bool isInBatchMode { get; } // 0x000000018D3913F0-0x000000018D3913F8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 72550
		{
			// Fields
			public InputUpdateDelegate value; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal unsafe void _set_onUpdate_b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr); // 0x00000001853AD6F0-0x00000001853AD7E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 72551
		{
			// Fields
			public Action<InputUpdateType> value; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _set_onBeforeUpdate_b__0(NativeInputUpdateType updateType); // 0x00000001861F8BD0-0x00000001861F8BF0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 72552
		{
			// Fields
			public Func<InputUpdateType, bool> value; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _set_onShouldRunUpdate_b__0(NativeInputUpdateType updateType); // 0x00000001860F2BB0-0x00000001860F2BD0
		}
	
		// Constructors
		public NativeInputRuntime(); // 0x000000018725ADF0-0x000000018725AE00
		static NativeInputRuntime(); // 0x00000001871DAF60-0x00000001871DAFD0
	
		// Methods
		public int AllocateDeviceId(); // 0x000000018D391308-0x000000018D391348
		public void Update(InputUpdateType updateType); // 0x0000000186F907F0-0x0000000186F90840
		public unsafe void QueueEvent(InputEvent* ptr); // 0x000000018D39136C-0x000000018D3913B8
		public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr); // 0x00000001866082A0-0x0000000186608330
		private void OnShutdown(); // 0x00000001894E6068-0x00000001894E6084
		private bool OnWantsToShutdown(); // 0x000000018D391348-0x000000018D39136C
		private void OnFocusChanged(bool focus); // 0x0000000186BBEAA0-0x0000000186BBEAC0
	}

	public interface IInputStateCallbackReceiver // TypeDefIndex: 72554
	{
		// Methods
		void OnNextUpdate();
		void OnStateEvent(InputEventPtr eventPtr);
		bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
	}

	public interface IInputStateChangeMonitor // TypeDefIndex: 72555
	{
		// Methods
		void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);
		void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
	}

	public interface IInputStateTypeInfo // TypeDefIndex: 72556
	{
		// Properties
		FourCC format { get; }
	}

	public static class InputState // TypeDefIndex: 72558
	{
		// Properties
		public static InputUpdateType currentUpdateType { get; } // 0x000000018D390140-0x000000018D390178 
		public static uint updateCount { get; } // 0x000000018D390178-0x000000018D3901B0 
		public static double currentTime { get; } // 0x00000001871EA0D0-0x00000001871EA130 
	
		// Events
		public static event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onChange {
			add; // 0x000000018D3900E0-0x000000018D390140
			remove; // 0x000000018D3901B0-0x000000018D390210
		}
	
		// Nested types
		private class StateChangeMonitorDelegate : IInputStateChangeMonitor // TypeDefIndex: 72557
		{
			// Fields
			public Action<InputControl, double, InputEventPtr, long> valueChangeCallback; // 0x10
			public Action<InputControl, double, long, int> timerExpiredCallback; // 0x18
	
			// Constructors
			public StateChangeMonitorDelegate(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x000000018D39376C-0x000000018D393798
			public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x000000018D393798-0x000000018D3937C8
		}
	
		// Methods
		public static void Change(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x02622FAF */); // 0x000000018D38FB28-0x000000018D38FDB8
		public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x02622FB0 */, InputEventPtr eventPtr = default)
			where TState : struct;
		public static void Change<TState>(InputControl control, ref ref TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x02622FB1 */, InputEventPtr eventPtr = default)
			where TState : struct;
		public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x02622FB2 */, uint groupIndex = 0 /* Metadata: 0x02622FBA */); // 0x000000018D38F864-0x000000018D38FA28
		public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1 /* Metadata: 0x02622FBB */, Action<InputControl, double, long, int> timerExpiredCallback = null); // 0x000000018D38FA28-0x000000018D38FB28
		public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x02622FBC */); // 0x000000018D38FFAC-0x000000018D3900E0
		public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1 /* Metadata: 0x02622FC4 */, int timerIndex = -1 /* Metadata: 0x02622FCC */); // 0x000000018D38F770-0x000000018D38F864
		public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x02622FCD */, int timerIndex = -1 /* Metadata: 0x02622FD5 */); // 0x000000018D38FED4-0x000000018D38FFAC
	
		// Extension methods
		public static bool IsIntegerFormat(this FourCC format); // 0x000000018D38FDB8-0x000000018D38FED4
	}

	public struct InputStateBlock // TypeDefIndex: 72559
	{
		// Fields
		public const uint InvalidOffset = 4294967295; // Metadata: 0x02622FD6
		public const uint AutomaticOffset = 4294967294; // Metadata: 0x02622FD7
		public static readonly FourCC FormatInvalid; // 0x00
		internal const int kFormatInvalid = 0; // Metadata: 0x02622FD8
		public static readonly FourCC FormatBit; // 0x04
		internal const int kFormatBit = 1112101920; // Metadata: 0x02622FD9
		public static readonly FourCC FormatSBit; // 0x08
		internal const int kFormatSBit = 1396853076; // Metadata: 0x02622FDE
		public static readonly FourCC FormatInt; // 0x0C
		internal const int kFormatInt = 1229870112; // Metadata: 0x02622FE3
		public static readonly FourCC FormatUInt; // 0x10
		internal const int kFormatUInt = 1430867540; // Metadata: 0x02622FE8
		public static readonly FourCC FormatShort; // 0x14
		internal const int kFormatShort = 1397248596; // Metadata: 0x02622FED
		public static readonly FourCC FormatUShort; // 0x18
		internal const int kFormatUShort = 1431521364; // Metadata: 0x02622FF2
		public static readonly FourCC FormatByte; // 0x1C
		internal const int kFormatByte = 1113150533; // Metadata: 0x02622FF7
		public static readonly FourCC FormatSByte; // 0x20
		internal const int kFormatSByte = 1396857172; // Metadata: 0x02622FFC
		public static readonly FourCC FormatLong; // 0x24
		internal const int kFormatLong = 1280198432; // Metadata: 0x02623001
		public static readonly FourCC FormatULong; // 0x28
		internal const int kFormatULong = 1431064135; // Metadata: 0x02623006
		public static readonly FourCC FormatFloat; // 0x2C
		internal const int kFormatFloat = 1179407392; // Metadata: 0x0262300B
		public static readonly FourCC FormatDouble; // 0x30
		internal const int kFormatDouble = 1145195552; // Metadata: 0x02623010
		public static readonly FourCC FormatVector2; // 0x34
		internal const int kFormatVector2 = 1447379762; // Metadata: 0x02623015
		public static readonly FourCC FormatVector3; // 0x38
		internal const int kFormatVector3 = 1447379763; // Metadata: 0x0262301A
		public static readonly FourCC FormatQuaternion; // 0x3C
		internal const int kFormatQuaternion = 1364541780; // Metadata: 0x0262301F
		public static readonly FourCC FormatVector2Short; // 0x40
		public static readonly FourCC FormatVector3Short; // 0x44
		public static readonly FourCC FormatVector2Byte; // 0x48
		public static readonly FourCC FormatVector3Byte; // 0x4C
		public static readonly FourCC FormatPose; // 0x50
		internal const int kFormatPose = 1349481317; // Metadata: 0x02623024
		[CompilerGenerated]
		private FourCC _format_k__BackingField; // 0x00
		internal uint m_ByteOffset; // 0x04
		[CompilerGenerated]
		private uint _bitOffset_k__BackingField; // 0x08
		[CompilerGenerated]
		private uint _sizeInBits_k__BackingField; // 0x0C
	
		// Properties
		public FourCC format { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public uint byteOffset { get; set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public uint bitOffset { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		public uint sizeInBits { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184431980-0x0000000184431990 0x00000001872397D0-0x00000001872397E0
		internal uint alignedSizeInBytes { get; } // 0x00000001853AE580-0x00000001853AE5B0 
		internal uint effectiveByteOffset { get; } // 0x000000018D38E07C-0x000000018D38E0C8 
		internal uint effectiveBitOffset { get; } // 0x000000018D38E030-0x000000018D38E07C 
	
		// Constructors
		static InputStateBlock(); // 0x0000000186F87140-0x0000000186F87320
	
		// Methods
		public static int GetSizeOfPrimitiveFormatInBits(FourCC type); // 0x000000018D38D324-0x000000018D38D598
		public static FourCC GetPrimitiveFormatFromType(System.Type type); // 0x000000018D38CEAC-0x000000018D38D324
		public unsafe int ReadInt(void* statePtr); // 0x00000001861A8F70-0x00000001861A8FF0
		public unsafe void WriteInt(void* statePtr, int value); // 0x000000018D38DE24-0x000000018D38E030
		public unsafe float ReadFloat(void* statePtr); // 0x00000001853B0C00-0x00000001853B0D10
		public unsafe void WriteFloat(void* statePtr, float value); // 0x000000018D38DB4C-0x000000018D38DE24
		internal PrimitiveValue FloatToPrimitiveValue(float value); // 0x000000018D38CB54-0x000000018D38CEAC
		public unsafe double ReadDouble(void* statePtr); // 0x000000018D38D598-0x000000018D38D84C
		public unsafe void WriteDouble(void* statePtr, double value); // 0x000000018D38D84C-0x000000018D38DB4C
		public unsafe void Write(void* statePtr, PrimitiveValue value); // 0x0000000186535D60-0x0000000186535E10
		public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr); // 0x0000000186FB6730-0x0000000186FB6800
	}

	internal struct InputStateBuffers // TypeDefIndex: 72561
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
		internal struct DoubleBuffers // TypeDefIndex: 72560
		{
			// Fields
			public unsafe void** deviceToBufferMapping; // 0x00
			public int deviceCount; // 0x08
	
			// Properties
			public bool valid { get; } // 0x00000001853B1420-0x00000001853B1430 
	
			// Methods
			public unsafe void SetFrontBuffer(int deviceIndex, void* ptr); // 0x00000001853B1450-0x00000001853B1470
			public unsafe void SetBackBuffer(int deviceIndex, void* ptr); // 0x00000001853B1430-0x00000001853B1450
			public unsafe void* GetFrontBuffer(int deviceIndex); // 0x00000001853AF9A0-0x00000001853AF9C0
			public unsafe void* GetBackBuffer(int deviceIndex); // 0x00000001853B1400-0x00000001853B1420
			public void SwapBuffers(int deviceIndex); // 0x00000001853B13A0-0x00000001853B1400
		}
	
		// Methods
		public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType); // 0x00000001853ADA20-0x00000001853ADA50
		public static unsafe void* GetFrontBufferForDevice(int deviceIndex); // 0x00000001853AF970-0x00000001853AF9A0
		public static unsafe void* GetBackBufferForDevice(int deviceIndex); // 0x0000000186913100-0x0000000186913150
		public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update); // 0x00000001853AD9E0-0x00000001853ADA20
		public void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount); // 0x0000000186313D90-0x0000000186313E90
		private static unsafe DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer); // 0x0000000186313E90-0x0000000186313F20
		public void FreeAll(); // 0x0000000186313CC0-0x0000000186313D90
		public void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers); // 0x0000000186313F20-0x0000000186314110
		private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer); // 0x0000000186313350-0x0000000186313530
		private static unsafe void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer); // 0x0000000186314110-0x0000000186314260
		private static uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount); // 0x0000000186314260-0x00000001863142F0
		private static uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device); // 0x00000001863142F0-0x0000000186314370
	}

	public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IInputStateChangeMonitor // TypeDefIndex: 72567
	{
		// Fields
		private const int kDefaultHistorySize = 128; // Metadata: 0x02623029
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
		public int Count { get; } // 0x0000000182271C40-0x0000000182271C50 
		public uint version { get; } // 0x00000001872336F0-0x0000000187233700 
		public int historyDepth { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x000000018D38F5CC-0x000000018D38F6B4
		public int extraMemoryPerRecord { get; set; } // 0x0000000187233730-0x0000000187233740 0x0000000186567560-0x00000001865675B0
		public InputUpdateType updateMask { get; set; } // 0x000000018D38F400-0x000000018D38F484 0x000000018D38F6B4-0x000000018D38F770
		public ReadOnlyArray<InputControl> controls { get; } // 0x000000018D38F3A0-0x000000018D38F400 
		public Record this[int index] { get => default; set {} } // 0x000000018D38F254-0x000000018D38F37C 0x000000018D38F484-0x000000018D38F5CC
		public Action<Record> onRecordAdded { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		internal int bytesPerRecord { get; } // 0x000000018D38F37C-0x000000018D38F3A0 
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 72562
		{
			// Fields
			private readonly InputStateHistory m_History; // 0x00
			private int m_Index; // 0x08
	
			// Properties
			public Record Current { get; } // 0x000000018D38710C-0x000000018D387148 
			object IEnumerator.Current { get; } // 0x000000018D387084-0x000000018D3870DC 
	
			// Constructors
			public Enumerator(InputStateHistory history); // 0x000000018A4799AC-0x000000018A4799C8
	
			// Methods
			public bool MoveNext(); // 0x000000018A54C800-0x000000018A54C82C
			public void Reset(); // 0x0000000187243140-0x0000000187243150
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		protected internal struct RecordHeader // TypeDefIndex: 72565
		{
			// Fields
			public double time; // 0x00
			public uint version; // 0x08
			public int controlIndex; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithoutControlIndex[0]; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithControlIndex[0]; // 0x10
			public const int kSizeWithControlIndex = 16; // Metadata: 0x0262302B
			public const int kSizeWithoutControlIndex = 12; // Metadata: 0x0262302C
	
			// Properties
			public unsafe byte* statePtrWithControlIndex { get; } // 0x000000018725AE00-0x000000018725AE10 
			public unsafe byte* statePtrWithoutControlIndex { get; } // 0x0000000187253070-0x0000000187253080 
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_StateWithoutControlIndex_e__FixedBuffer // TypeDefIndex: 72563
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_StateWithControlIndex_e__FixedBuffer // TypeDefIndex: 72564
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 72566
		{
			// Fields
			private readonly InputStateHistory m_Owner; // 0x00
			private readonly int m_IndexPlusOne; // 0x08
			private uint m_Version; // 0x0C
	
			// Properties
			internal unsafe RecordHeader* header { get; } // 0x000000018D392020-0x000000018D392048 
			internal int recordIndex { get; } // 0x000000018724C2A0-0x000000018724C2B0 
			internal uint version { get; } // 0x0000000184431980-0x0000000184431990 
			public bool valid { get; } // 0x000000018D392228-0x000000018D392268 
			public InputStateHistory owner { get; } // 0x0000000184431970-0x0000000184431980 
			public int index { get; } // 0x000000018D392048-0x000000018D392078 
			public double time { get; } // 0x000000018D3921F8-0x000000018D392228 
			public InputControl control { get; } // 0x000000018D391F74-0x000000018D392020 
			public Record next { get; } // 0x000000018D392078-0x000000018D39213C 
			public Record previous { get; } // 0x000000018D39213C-0x000000018D3921F8 
	
			// Constructors
			internal unsafe Record(InputStateHistory owner, int index, RecordHeader* header); // 0x000000018B5E3D68-0x000000018B5E3D98
	
			// Methods
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public object ReadValueAsObject(); // 0x000000018D391E68-0x000000018D391EAC
			public unsafe void* GetUnsafeMemoryPtr(); // 0x000000018D391E48-0x000000018D391E68
			internal unsafe void* GetUnsafeMemoryPtrUnchecked(); // 0x000000018D391DC8-0x000000018D391E48
			public unsafe void* GetUnsafeExtraMemoryPtr(); // 0x000000018D391DA8-0x000000018D391DC8
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked(); // 0x000000018D391CFC-0x000000018D391DA8
			public void CopyFrom(Record record); // 0x000000018D391874-0x000000018D391C8C
			internal void CheckValid(); // 0x000000018D39179C-0x000000018D391874
			public bool Equals(Record other); // 0x000000018B1F4118-0x000000018B1F4138
			public override bool Equals(object obj); // 0x000000018D391C8C-0x000000018D391CFC
			public override int GetHashCode(); // 0x000000018B5E38B4-0x000000018B5E38E8
			public override string ToString(); // 0x000000018D391EAC-0x000000018D391F74
		}
	
		// Constructors
		public InputStateHistory(int maxStateSizeInBytes); // 0x00000001870648A0-0x00000001870648F0
		public InputStateHistory(string path); // 0x000000018D38F00C-0x000000018D38F16C
		public InputStateHistory(InputControl control); // 0x000000018D38F16C-0x000000018D38F254
		public InputStateHistory(IEnumerable<InputControl> controls); // 0x000000018D38EF98-0x000000018D38F00C
	
		// Methods
		~InputStateHistory(); // 0x000000018D38E488-0x000000018D38E4FC
		public void Clear(); // 0x000000018725ADD0-0x000000018725ADE0
		public Record AddRecord(Record record); // 0x000000018D38E0C8-0x000000018D38E148
		public void StartRecording(); // 0x000000018D38EC6C-0x000000018D38EDA8
		public void StopRecording(); // 0x000000018D38EDA8-0x000000018D38EED8
		public Record RecordStateChange(InputControl control, InputEventPtr eventPtr); // 0x000000018D38E7AC-0x000000018D38E99C
		public unsafe Record RecordStateChange(InputControl control, void* statePtr, double time); // 0x000000018D38E99C-0x000000018D38EC6C
		public IEnumerator<Record> GetEnumerator(); // 0x000000018D38E4FC-0x000000018D38E55C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D38EED8-0x000000018D38EEE0
		public void Dispose(); // 0x000000018D38E434-0x000000018D38E488
		protected void Destroy(); // 0x000000018D38E3DC-0x000000018D38E434
		private void Allocate(); // 0x000000018D38E1E0-0x000000018D38E3DC
		protected internal int RecordIndexToUserIndex(int index); // 0x000000018D38E798-0x000000018D38E7AC
		protected internal int UserIndexToRecordIndex(int index); // 0x000000018725ADE0-0x000000018725ADF0
		protected internal unsafe RecordHeader* GetRecord(int index); // 0x000000018D38E5B0-0x000000018D38E6A4
		internal unsafe RecordHeader* GetRecordUnchecked(int index); // 0x000000018D38E55C-0x000000018D38E5B0
		protected internal unsafe RecordHeader* AllocateRecord(out int index); // 0x000000018D38E148-0x000000018D38E1E0
		protected unsafe TValue ReadValue<TValue>(RecordHeader* data)
			where TValue : struct;
		protected unsafe object ReadValueAsObject(RecordHeader* data); // 0x000000018D38E6A4-0x000000018D38E798
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex); // 0x000000018D38EEE0-0x000000018D38EF98
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>> // TypeDefIndex: 72570
		where TValue : struct
	{
		// Properties
		public new Record this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 72568
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
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 72569
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
		public Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x0262302D */);
		public new IEnumerator<Record> GetEnumerator();
		new IEnumerator IEnumerable.GetEnumerator();
	}

	internal class SelectObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 72572
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, TResult> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 72571
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
	public class OnScreenButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 72392
	{
		// Fields
		[InputControl(layout = "Button")]
		[SerializeField]
		private string m_ControlPath; // 0x30
	
		// Properties
		protected override string controlPathInternal { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public OnScreenButton(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnPointerUp(PointerEventData eventData); // 0x000000018D36E014-0x000000018D36E050
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D36DFD0-0x000000018D36E014
	}

	public abstract class OnScreenControl : MonoBehaviour // TypeDefIndex: 72394
	{
		// Fields
		private InputControl m_Control; // 0x18
		private OnScreenControl m_NextControlOnDevice; // 0x20
		private InputEventPtr m_InputEventPtr; // 0x28
		private static int s_nbActiveInstances; // 0x00
		private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; // 0x08
	
		// Properties
		public string controlPath { get; set; } // 0x000000018783B1B4-0x000000018783B1C4 0x000000018D36EEF8-0x000000018D36EF34
		public InputControl control { get; } // 0x0000000182234E30-0x0000000182234E40 
		protected abstract string controlPathInternal { get; set; }
		internal static bool HasAnyActive { get; } // 0x000000018D36EEBC-0x000000018D36EEF8 
	
		// Nested types
		private struct OnScreenDeviceInfo // TypeDefIndex: 72393
		{
			// Fields
			public InputEventPtr eventPtr; // 0x00
			public NativeArray<byte> buffer; // 0x08
			public UnityEngine.InputSystem.InputDevice device; // 0x18
			public OnScreenControl firstControl; // 0x20
	
			// Methods
			public OnScreenDeviceInfo AddControl(OnScreenControl control); // 0x000000018D36EF34-0x000000018D36EF90
			public OnScreenDeviceInfo RemoveControl(OnScreenControl control); // 0x000000018D36F02C-0x000000018D36F16C
			public void Destroy(); // 0x000000018D36EF90-0x000000018D36F02C
		}
	
		// Constructors
		protected OnScreenControl(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void SetupInputControl(); // 0x000000018D36E69C-0x000000018D36EEBC
		protected void SendValueToControl<TValue>(TValue value)
			where TValue : struct;
		protected void SentDefaultValueToControl(); // 0x000000018D36E604-0x000000018D36E69C
		protected virtual void OnEnable(); // 0x000000018D36E320-0x000000018D36E604
		protected virtual void OnDisable(); // 0x000000018D36E098-0x000000018D36E320
		internal string GetWarningMessage(); // 0x000000018D36E050-0x000000018D36E098
	}

	internal static class UGUIOnScreenControlUtils // TypeDefIndex: 72395
	{
		// Methods
		public static RectTransform GetCanvasRectTransform(Transform transform); // 0x000000018D3731FC-0x000000018D373294
	}

	[AddComponentMenu("Input/On-Screen Stick")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/OnScreen.html#on-screen-sticks")]
	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 72397
	{
		// Fields
		private const string kDynamicOriginClickable = "DynamicOriginClickable"; // Metadata: 0x02622D01
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
		public float movementRange { get; set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
		public float dynamicOriginRange { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x000000018D370C58-0x000000018D370C74
		public bool useIsolatedInputActions { get; set; } // 0x000000018226ED80-0x000000018226ED90 0x000000018226ED90-0x000000018226EDA0
		protected override string controlPathInternal { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public Behaviour behaviour { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
	
		// Nested types
		public enum Behaviour // TypeDefIndex: 72396
		{
			RelativePositionWithStaticOrigin = 0,
			ExactPositionWithStaticOrigin = 1,
			ExactPositionWithDynamicOrigin = 2
		}
	
		// Constructors
		public OnScreenStick(); // 0x000000018D370C34-0x000000018D370C58
	
		// Methods
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D3701F0-0x000000018D3702A8
		public void OnDrag(PointerEventData eventData); // 0x000000018D36FA1C-0x000000018D36FAD4
		public void OnPointerUp(PointerEventData eventData); // 0x000000018D3704BC-0x000000018D3704CC
		private void Start(); // 0x000000018D3704CC-0x000000018D370B68
		private void OnDestroy(); // 0x000000018D36F984-0x000000018D36FA1C
		private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera); // 0x000000018D36F16C-0x000000018D36F344
		private void MoveStick(Vector2 pointerPosition, Camera uiCamera); // 0x000000018D36F650-0x000000018D36F984
		private void EndInteraction(); // 0x000000018D36F48C-0x000000018D36F53C
		private void OnPointerDown(InputAction.CallbackContext ctx); // 0x000000018D36FD08-0x000000018D3701F0
		private void OnPointerChanged(InputAction.CallbackContext ctx); // 0x000000018D36FCB0-0x000000018D36FD08
		private void OnPointerMove(InputAction.CallbackContext ctx); // 0x000000018D3702A8-0x000000018D3703AC
		private void OnPointerUp(InputAction.CallbackContext ctx); // 0x000000018D3703AC-0x000000018D3704BC
		private Camera GetCameraFromCanvas(); // 0x000000018D36F53C-0x000000018D36F650
		private void OnDrawGizmosSelected(); // 0x000000018D36FAD4-0x000000018D36FCB0
		private void DrawGizmoCircle(Vector2 center, float radius); // 0x000000018D36F344-0x000000018D36F48C
		private void UpdateDynamicOriginClickableArea(); // 0x000000018D370B68-0x000000018D370C34
	}
}

namespace UnityEngine.InputSystem.Processors
{
	public class AxisDeadzoneProcessor : InputProcessor<float> // TypeDefIndex: 72573
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get; } // 0x000000018D383B58-0x000000018D383BB8 
		private float maxOrDefault { get; } // 0x000000018D383AF8-0x000000018D383B58 
	
		// Constructors
		public AxisDeadzoneProcessor(); // 0x000000018D383AD0-0x000000018D383AF8
	
		// Methods
		public override float Process(float value, InputControl control = null); // 0x000000018D3839C4-0x000000018D383A34
		public override string ToString(); // 0x000000018D383A34-0x000000018D383AD0
	}

	public class ClampProcessor : InputProcessor<float> // TypeDefIndex: 72574
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Constructors
		public ClampProcessor(); // 0x000000018D384104-0x000000018D38412C
	
		// Methods
		public override float Process(float value, InputControl control); // 0x000000018D384058-0x000000018D384074
		public override string ToString(); // 0x000000018D384074-0x000000018D384104
	}

	[DesignTimeVisible(false)]
	internal class CompensateDirectionProcessor : InputProcessor<Vector3> // TypeDefIndex: 72575
	{
		// Properties
		public override CachingPolicy cachingPolicy { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public CompensateDirectionProcessor(); // 0x000000018D384EE8-0x000000018D384F10
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018D384D8C-0x000000018D384EBC
		public override string ToString(); // 0x000000018D384EBC-0x000000018D384EE8
	}

	[DesignTimeVisible(false)]
	internal class CompensateRotationProcessor : InputProcessor<Quaternion> // TypeDefIndex: 72576
	{
		// Properties
		public override CachingPolicy cachingPolicy { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public CompensateRotationProcessor(); // 0x000000018D38503C-0x000000018D385064
	
		// Methods
		public override Quaternion Process(Quaternion value, InputControl control); // 0x000000018D384F10-0x000000018D385010
		public override string ToString(); // 0x000000018D385010-0x000000018D38503C
	}

	public class InvertProcessor : InputProcessor<float> // TypeDefIndex: 72577
	{
		// Constructors
		public InvertProcessor(); // 0x000000018D390324-0x000000018D39034C
	
		// Methods
		public override float Process(float value, InputControl control); // 0x0000000187254070-0x0000000187254080
		public override string ToString(); // 0x000000018D3902F8-0x000000018D390324
	}

	public class InvertVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 72578
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
	
		// Constructors
		public InvertVector2Processor(); // 0x000000018D39042C-0x000000018D390468
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x000000018D39034C-0x000000018D3903A4
		public override string ToString(); // 0x000000018D3903A4-0x000000018D39042C
	}

	public class InvertVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 72579
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
		public bool invertZ; // 0x12
	
		// Constructors
		public InvertVector3Processor(); // 0x000000018D39057C-0x000000018D3905B4
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018D390468-0x000000018D3904C4
		public override string ToString(); // 0x000000018D3904C4-0x000000018D39057C
	}

	public class NormalizeProcessor : InputProcessor<float> // TypeDefIndex: 72580
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
		public float zero; // 0x18
	
		// Constructors
		public NormalizeProcessor(); // 0x000000018D391684-0x000000018D3916AC
	
		// Methods
		public override float Process(float value, InputControl control); // 0x000000018D391594-0x000000018D3915C0
		public static float Normalize(float value, float min, float max, float zero); // 0x0000000186535F10-0x0000000186535FB0
		internal static float Denormalize(float value, float min, float max, float zero); // 0x000000018D391544-0x000000018D391594
		public override string ToString(); // 0x000000018D3915C0-0x000000018D391684
	}

	public class NormalizeVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 72581
	{
		// Constructors
		public NormalizeVector2Processor(); // 0x000000018D3916F0-0x000000018D391718
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x000000018D3916AC-0x000000018D3916C4
		public override string ToString(); // 0x000000018D3916C4-0x000000018D3916F0
	}

	public class NormalizeVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 72582
	{
		// Constructors
		public NormalizeVector3Processor(); // 0x000000018D391774-0x000000018D39179C
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018D391718-0x000000018D391748
		public override string ToString(); // 0x000000018D391748-0x000000018D391774
	}

	public class ScaleProcessor : InputProcessor<float> // TypeDefIndex: 72583
	{
		// Fields
		[Tooltip("Scale factor to multiply incoming float values by.")]
		public float factor; // 0x10
	
		// Constructors
		public ScaleProcessor(); // 0x000000018D393550-0x000000018D39358C
	
		// Methods
		public override float Process(float value, InputControl control); // 0x000000018725AE20-0x000000018725AE30
		public override string ToString(); // 0x000000018D3934EC-0x000000018D393550
	}

	public class ScaleVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 72584
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector2\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector2\'s Y component by.")]
		public float y; // 0x14
	
		// Constructors
		public ScaleVector2Processor(); // 0x000000018D39361C-0x000000018D393668
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control); // 0x000000018725AE30-0x000000018725AE60
		public override string ToString(); // 0x000000018D39358C-0x000000018D39361C
	}

	public class ScaleVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 72585
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector3\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Y component by.")]
		public float y; // 0x14
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Z component by.")]
		public float z; // 0x18
	
		// Constructors
		public ScaleVector3Processor(); // 0x000000018D39372C-0x000000018D39376C
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control); // 0x000000018725AE60-0x000000018725AEA0
		public override string ToString(); // 0x000000018D393668-0x000000018D39372C
	}

	public class StickDeadzoneProcessor : InputProcessor<Vector2> // TypeDefIndex: 72586
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get; } // 0x000000018D393DF4-0x000000018D393E54 
		private float maxOrDefault { get; } // 0x000000018D393D94-0x000000018D393DF4 
	
		// Constructors
		public StickDeadzoneProcessor(); // 0x000000018D393D6C-0x000000018D393D94
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control = null); // 0x000000018D393C58-0x000000018D393CD0
		private float GetDeadZoneAdjustedValue(float value); // 0x000000018D393BE8-0x000000018D393C58
		public override string ToString(); // 0x000000018D393CD0-0x000000018D393D6C
	}
}

namespace UnityEngine.InputSystem.Switch
{
	[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
	public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor // TypeDefIndex: 72388
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _captureButton_k__BackingField; // 0x210
		[CompilerGenerated]
		private ButtonControl _homeButton_k__BackingField; // 0x218
		private static readonly SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence; // 0x00
		private int m_HandshakeStepIndex; // 0x220
		private double m_HandshakeTimer; // 0x228
		internal const byte JitterMaskLow = 120; // Metadata: 0x02622CD8
		internal const byte JitterMaskHigh = 135; // Metadata: 0x02622CD9
	
		// Properties
		[InputControl(name = "capture", displayName = "Capture")]
		public ButtonControl captureButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(name = "home", displayName = "Home")]
		public ButtonControl homeButton { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
	
		// Nested types
		private struct SwitchInputOnlyReport // TypeDefIndex: 72379
		{
			// Fields
			public const int kSize = 7; // Metadata: 0x02622CDA
			public byte buttons0; // 0x00
			public byte buttons1; // 0x01
			public byte hat; // 0x02
			public byte leftX; // 0x03
			public byte leftY; // 0x04
			public byte rightX; // 0x05
			public byte rightY; // 0x06
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018D370FE8-0x000000018D371260
		}
	
		private struct SwitchSimpleInputReport // TypeDefIndex: 72380
		{
			// Fields
			public const int kSize = 12; // Metadata: 0x02622CDB
			public const byte ExpectedReportId = 63; // Metadata: 0x02622CDC
			public byte reportId; // 0x00
			public byte buttons0; // 0x01
			public byte buttons1; // 0x02
			public byte hat; // 0x03
			public ushort leftX; // 0x04
			public ushort leftY; // 0x06
			public ushort rightX; // 0x08
			public ushort rightY; // 0x0A
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018D371AB8-0x000000018D371D88
		}
	
		private struct SwitchFullInputReport // TypeDefIndex: 72381
		{
			// Fields
			public const int kSize = 25; // Metadata: 0x02622CDD
			public const byte ExpectedReportId = 48; // Metadata: 0x02622CDE
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
			public SwitchProControllerHIDInputState ToHIDInputReport(); // 0x000000018D370D78-0x000000018D370FE8
		}
	
		private struct SwitchHIDGenericInputReport // TypeDefIndex: 72382
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get; } // 0x000000018725A260-0x000000018725A270 
		}
	
		internal struct SwitchMagicOutputReport // TypeDefIndex: 72385
		{
			// Fields
			public const int kSize = 49; // Metadata: 0x02622CDF
			public const byte ExpectedReplyInputReportId = 129; // Metadata: 0x02622CE0
			public byte reportType; // 0x00
			public byte commandId; // 0x01
	
			// Nested types
			internal enum ReportType // TypeDefIndex: 72383
			{
				Magic = 128
			}
	
			public enum CommandIdType // TypeDefIndex: 72384
			{
				Status = 1,
				Handshake = 2,
				Highspeed = 3,
				ForceUSB = 4
			}
		}
	
		internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo // TypeDefIndex: 72386
		{
			// Fields
			public const int kSize = 57; // Metadata: 0x02622CE7
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get; } // 0x000000018725A2D0-0x000000018725A2E0 
			public FourCC typeStatic { get; } // 0x000000018725A2D0-0x000000018725A2E0 
	
			// Methods
			public static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type); // 0x000000018725A270-0x000000018725A2D0
		}
	
		internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo // TypeDefIndex: 72387
		{
			// Fields
			public const int kSize = 72; // Metadata: 0x02622CE8
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get; } // 0x000000018725A2D0-0x000000018725A2E0 
			public FourCC typeStatic { get; } // 0x000000018725A2D0-0x000000018725A2E0 
	
			// Methods
			public static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type); // 0x000000018725A2E0-0x000000018725A340
		}
	
		// Constructors
		public SwitchProControllerHID(); // 0x000000018D2E1E18-0x000000018D2E1E20
		static SwitchProControllerHID(); // 0x000000018D371A2C-0x000000018D371AB8
	
		// Methods
		protected override void OnAdded(); // 0x000000018D3716A0-0x000000018D371748
		private void HandshakeRestart(); // 0x000000018D3713FC-0x000000018D37145C
		private void HandshakeTick(); // 0x000000018D37145C-0x000000018D3716A0
		public void OnNextUpdate(); // 0x000000018D371748-0x000000018D371750
		public void OnStateEvent(InputEventPtr eventPtr); // 0x000000018D371750-0x000000018D3718A8
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset); // 0x00000001843FFFF0-0x0000000184400000
		public bool PreProcessEvent(InputEventPtr eventPtr); // 0x000000018D3718A8-0x000000018D371A2C
	}

	internal static class SwitchSupportHID // TypeDefIndex: 72389
	{
		// Methods
		public static void Initialize(); // 0x0000000185B0B410-0x0000000185B0BC30
	}
}

namespace UnityEngine.InputSystem.Switch.LowLevel
{
	internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo // TypeDefIndex: 72391
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
		public FourCC format { get; } // 0x000000018D3713AC-0x000000018D3713FC 
	
		// Nested types
		public enum Button // TypeDefIndex: 72390
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
		static SwitchProControllerHIDInputState(); // 0x000000018D371370-0x000000018D3713AC
	
		// Methods
		public SwitchProControllerHIDInputState WithButton(Button button, bool value = true /* Metadata: 0x02622CEA */); // 0x000000018D371310-0x000000018D371370
		public void Set(Button button, bool state); // 0x000000018D36A2E4-0x000000018D36A618
		public void Press(Button button); // 0x000000018D371260-0x000000018D3712B8
		public void Release(Button button); // 0x000000018D3712B8-0x000000018D371310
	}
}

namespace UnityEngine.InputSystem.UI
{
	internal class BaseInputOverride : BaseInput // TypeDefIndex: 72359
	{
		// Fields
		[CompilerGenerated]
		private readonly string _compositionString_k__BackingField; // 0x18
	
		// Properties
		public override string compositionString { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public BaseInputOverride(); // 0x00000001878364A0-0x00000001878364B8
	}

	internal class ExtendedAxisEventData : AxisEventData, INavigationEventData // TypeDefIndex: 72360
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x30
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public ExtendedAxisEventData(EventSystem eventSystem); // 0x000000018D36A848-0x000000018D36A850
	
		// Methods
		public override string ToString(); // 0x000000018D36A7B0-0x000000018D36A848
	}

	public class ExtendedPointerEventData : PointerEventData // TypeDefIndex: 72361
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
		public InputControl control { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BD40-0x000000018723BD50 0x0000000188DC45AC-0x0000000188DC45C0
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C240-0x000000018723C250 0x0000000188DC4DF4-0x0000000188DC4E08
		public int touchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723E340-0x000000018723E350 0x000000018723E3B0-0x000000018723E3C0
		public UIPointerType pointerType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725A140-0x000000018725A150 0x000000018725A170-0x000000018725A180
		public int uiToolkitPointerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233DD0-0x0000000187233DE0 0x0000000187254CE0-0x0000000187254CF0
		public Vector3 trackedDevicePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725A150-0x000000018725A170 0x000000018725A180-0x000000018725A1A0
		public Quaternion trackedDeviceOrientation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723D5B0-0x000000018723D5C0 0x0000000187233FD0-0x0000000187233FE0
	
		// Constructors
		public ExtendedPointerEventData(EventSystem eventSystem); // 0x000000018783D594-0x000000018783D59C
	
		// Methods
		public override string ToString(); // 0x000000018D36AAE0-0x000000018D36AF68
		internal static int MakePointerIdForTouch(int deviceId, int touchId); // 0x000000018725A130-0x000000018725A140
		internal static int TouchIdFromPointerId(int pointerId); // 0x0000000187241400-0x0000000187241410
		internal void ReadDeviceState(); // 0x00000001852709C0-0x0000000185270AE0
		private static int GetPenPointerId(Pen pen); // 0x000000018D36A850-0x000000018D36AA04
		private static int GetTouchPointerId(TouchControl touchControl); // 0x000000018D36AA04-0x000000018D36AAE0
	}

	public enum UIPointerType // TypeDefIndex: 72362
	{
		None = 0,
		MouseOrPen = 1,
		Touch = 2,
		Tracked = 3
	}

	public enum UIPointerBehavior // TypeDefIndex: 72363
	{
		SingleMouseOrPenButMultiTouchAndTrack = 0,
		SingleUnifiedPointer = 1,
		AllPointersAsIs = 2
	}

	internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData // TypeDefIndex: 72364
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x20
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Constructors
		public ExtendedSubmitCancelEventData(EventSystem eventSystem); // 0x0000000187835500-0x0000000187835510
	}

	internal interface INavigationEventData // TypeDefIndex: 72365
	{
		// Properties
		UnityEngine.InputSystem.InputDevice device { get; }
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#setting-up-ui-input")]
	public class InputSystemUIInputModule : BaseInputModule // TypeDefIndex: 72368
	{
		// Fields
		private const float kClickSpeed = 0.3f; // Metadata: 0x02622CCF
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
		public bool deselectOnBackgroundClick { get; set; } // 0x000000018223B190-0x000000018223B1A0 0x000000018223B1A0-0x000000018223B1B0
		public UIPointerBehavior pointerBehavior { get; set; } // 0x000000018723BAF0-0x000000018723BB00 0x000000018723BB50-0x000000018723BB60
		public CursorLockBehavior cursorLockBehavior { get; set; } // 0x000000018723BAC0-0x000000018723BAD0 0x000000018723BB20-0x000000018723BB30
		internal GameObject localMultiPlayerRoot { get; set; } // 0x000000018723BDC0-0x000000018723BDD0 0x0000000188DC4660-0x0000000188DC4674
		public float scrollDeltaPerTick { get; set; } // 0x0000000184F560A0-0x0000000184F560B0 0x000000018724C660-0x000000018724C670
		public float moveRepeatDelay { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public float moveRepeatRate { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		private bool explictlyIgnoreFocus { get; } // 0x000000018526D030-0x000000018526D070 
		private bool shouldIgnoreFocus { get; } // 0x000000018526CFD0-0x000000018526D030 
		[Obsolete("\'repeatRate\' has been obsoleted; use \'moveRepeatRate\' instead. (UnityUpgradable) -> moveRepeatRate", false)]
		public float repeatRate { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		[Obsolete("\'repeatDelay\' has been obsoleted; use \'moveRepeatDelay\' instead. (UnityUpgradable) -> moveRepeatDelay", false)]
		public float repeatDelay { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public Transform xrTrackingOrigin { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public float trackedDeviceDragThresholdMultiplier { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public InputActionReference point { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x000000018D36D98C-0x000000018D36D9C0
		public InputActionReference scrollWheel { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x000000018D36D9F8-0x000000018D36DA30
		public InputActionReference leftClick { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x000000018D36D8E8-0x000000018D36D920
		public InputActionReference middleClick { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x000000018D36D920-0x000000018D36D958
		public InputActionReference rightClick { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x000000018D36D9C0-0x000000018D36D9F8
		public InputActionReference move { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x000000018D36D958-0x000000018D36D98C
		public InputActionReference submit { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x000000018D36DA30-0x000000018D36DA64
		public InputActionReference cancel { get; set; } // 0x00000001828D49D0-0x00000001828D49E0 0x000000018D36D8B0-0x000000018D36D8E8
		public InputActionReference trackedDeviceOrientation { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018D36DA64-0x000000018D36DA9C
		public InputActionReference trackedDevicePosition { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018D36DA9C-0x000000018D36DAD4
		[Obsolete("\'trackedDeviceSelect\' has been obsoleted; use \'leftClick\' instead.", true)]
		public InputActionReference trackedDeviceSelect { get; set; } // 0x000000018D36D6A4-0x000000018D36D6F0 0x000000018D36DAD4-0x000000018D36DB20
		public InputActionAsset actionsAsset { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x000000018D36D6F0-0x000000018D36D8B0
		private bool sendPointerHoverToParent { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		private struct InputActionReferenceState // TypeDefIndex: 72366
		{
			// Fields
			public int refCount; // 0x00
			public bool enabledByInputModule; // 0x04
		}
	
		public enum CursorLockBehavior // TypeDefIndex: 72367
		{
			OutsideScreen = 0,
			ScreenCenter = 1
		}
	
		// Constructors
		public InputSystemUIInputModule(); // 0x0000000186881500-0x0000000186881540
		static InputSystemUIInputModule(); // 0x000000018716EE10-0x000000018716EEB0
	
		// Methods
		public override void ActivateModule(); // 0x0000000185FBC990-0x0000000185FBCA80
		public override bool IsPointerOverGameObject(int pointerOrTouchId); // 0x000000018D36C87C-0x000000018D36C9A0
		public RaycastResult GetLastRaycastResult(int pointerOrTouchId); // 0x000000018D36C4C0-0x000000018D36C5B8
		private RaycastResult PerformRaycast(ExtendedPointerEventData eventData); // 0x0000000185271460-0x0000000185271A20
		private void ProcessPointer(ref PointerModel state); // 0x0000000185270D70-0x00000001852710D0
		private bool PointerShouldIgnoreTransform(Transform t); // 0x00000001852734C0-0x0000000185273580
		private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData); // 0x0000000185271C10-0x0000000185271C60
		private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget); // 0x0000000185271C60-0x00000001852726C0
		private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData); // 0x00000001852729E0-0x0000000185273390
		private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData); // 0x00000001852726F0-0x00000001852729E0
		private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData); // 0x00000001852701A0-0x0000000185270290
		internal void ProcessNavigation(ref NavigationModel navigationState); // 0x0000000185270AE0-0x0000000185270D70
		private bool IsMoveAllowed(AxisEventData eventData); // 0x000000018D36C6C4-0x000000018D36C87C
		private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback); // 0x000000018D36D0C8-0x000000018D36D374
		public void AssignDefaultActions(); // 0x000000018D36BF8C-0x000000018D36C354
		public void UnassignActions(); // 0x000000018D36D4EC-0x000000018D36D604
		protected override void Awake(); // 0x000000018722B6F0-0x000000018722B700
		protected override void OnDestroy(); // 0x000000018D36C9A0-0x000000018D36C9A8
		protected override void OnEnable(); // 0x0000000186BD0300-0x0000000186BD0430
		protected override void OnDisable(); // 0x000000018D36C9A8-0x000000018D36CA44
		private void ResetPointers(); // 0x0000000186BD0430-0x0000000186BD0470
		private bool HasNoActions(); // 0x0000000186BD04D0-0x0000000186BD0570
		private void EnableAllActions(); // 0x0000000185B033E0-0x0000000185B034A0
		private void DisableAllActions(); // 0x000000018D36C3EC-0x000000018D36C4C0
		private void EnableInputAction(InputActionReference inputActionReference); // 0x0000000185B034A0-0x0000000185B03600
		private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false /* Metadata: 0x02622CCD */); // 0x000000018D36D374-0x000000018D36D4EC
		private int GetPointerStateIndexFor(int pointerOrTouchId); // 0x000000018D36C5B8-0x000000018D36C6C4
		private ref PointerModel GetPointerStateForIndex(int index); // 0x00000001852706E0-0x0000000185270700
		private int GetDisplayIndexFor(InputControl control); // 0x000000018526D4D0-0x000000018526D560
		private int GetPointerStateIndexFor(ref InputAction.CallbackContext context); // 0x000000018526D560-0x000000018526D5E0
		private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true /* Metadata: 0x02622CCE */); // 0x000000018526D280-0x000000018526D4D0
		private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, UnityEngine.InputSystem.InputDevice device, InputControl touchControl = null); // 0x0000000186D3B140-0x0000000186D3B350
		private bool SendPointerExitEventsAndRemovePointer(int index); // 0x000000018D36CFFC-0x000000018D36D0C8
		private bool RemovePointerAtIndex(int index); // 0x000000018D36CD58-0x000000018D36CFFC
		private void PurgeStalePointers(); // 0x0000000185B006A0-0x0000000185B00770
		private static bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, InputActionReference actionReference); // 0x0000000185B01700-0x0000000185B017C0
		private void OnPointCallback(InputAction.CallbackContext context); // 0x0000000185270050-0x00000001852701A0
		private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed); // 0x000000018526D1B0-0x000000018526D1F0
		private void OnLeftClickCallback(InputAction.CallbackContext context); // 0x000000018526D1F0-0x000000018526D280
		private void OnRightClickCallback(InputAction.CallbackContext context); // 0x000000018D36CB68-0x000000018D36CBF8
		private void OnMiddleClickCallback(InputAction.CallbackContext context); // 0x000000018D36CA44-0x000000018D36CAD4
		private bool CheckForRemovedDevice(ref InputAction.CallbackContext context); // 0x000000018526FFB0-0x000000018526FFF0
		private void OnScrollCallback(InputAction.CallbackContext context); // 0x000000018526BEE0-0x000000018526BF90
		private void OnMoveCallback(InputAction.CallbackContext context); // 0x000000018D36CAD4-0x000000018D36CB68
		private void OnSubmitCancelCallback(InputAction.CallbackContext context); // 0x000000018D36CBF8-0x000000018D36CC38
		private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context); // 0x000000018D36CC38-0x000000018D36CCC4
		private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context); // 0x000000018D36CCC4-0x000000018D36CD58
		private void OnControlsChanged(object obj); // 0x0000000187232630-0x0000000187232640
		private void FilterPointerStatesByType(); // 0x0000000185270460-0x00000001852706E0
		public override void Process(); // 0x0000000185270290-0x0000000185270460
		public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData); // 0x000000018D36C354-0x000000018D36C3EC
		private void HookActions(); // 0x0000000186BD0680-0x0000000186BD09E0
		private void UnhookActions(); // 0x000000018D36D604-0x000000018D36D618
		private void SetActionCallbacks(bool install); // 0x0000000185B03600-0x0000000185B03770
		private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install); // 0x0000000185B03770-0x0000000185B03860
		private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference); // 0x000000018D36D618-0x000000018D36D6A4
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#multiplayer-uis")]
	public class MultiplayerEventSystem : EventSystem // TypeDefIndex: 72369
	{
		// Fields
		[SerializeField]
		[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
		private GameObject m_PlayerRoot; // 0x50
	
		// Properties
		public GameObject playerRoot { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018D36DFAC-0x000000018D36DFD0
	
		// Constructors
		public MultiplayerEventSystem(); // 0x000000018D36DF60-0x000000018D36DFAC
	
		// Methods
		protected override void OnEnable(); // 0x000000018D36DE80-0x000000018D36DEA0
		protected override void OnDisable(); // 0x000000018D36DE78-0x000000018D36DE80
		private void InitializePlayerRoot(); // 0x000000018D36DDC4-0x000000018D36DE78
		protected override void Update(); // 0x000000018D36DEA0-0x000000018D36DF60
	}

	internal struct NavigationModel // TypeDefIndex: 72370
	{
		// Fields
		public Vector2 move; // 0x00
		public int consecutiveMoveCount; // 0x08
		public MoveDirection lastMoveDirection; // 0x0C
		public float lastMoveTime; // 0x10
		public AxisEventData eventData; // 0x18
		public UnityEngine.InputSystem.InputDevice device; // 0x20
	
		// Methods
		public void Reset(); // 0x0000000184FC54A0-0x0000000184FC54B0
	}

	internal struct SubmitCancelModel // TypeDefIndex: 72371
	{
		// Fields
		public BaseEventData eventData; // 0x00
		public UnityEngine.InputSystem.InputDevice device; // 0x08
	}

	internal struct PointerModel // TypeDefIndex: 72373
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
		public UIPointerType pointerType { get; } // 0x0000000185270700-0x0000000185270730 
		public Vector2 screenPosition { get; set; } // 0x0000000187258DF0-0x0000000187258E10 0x00000001862DAFE0-0x00000001862DB030
		public Vector3 worldPosition { get; set; } // 0x000000018723F0E0-0x000000018723F100 0x000000018D370CC0-0x000000018D370D3C
		public Quaternion worldOrientation { get; set; } // 0x000000018725A250-0x000000018725A260 0x000000018D370C74-0x000000018D370CC0
		public Vector2 scrollDelta { get; set; } // 0x000000018725A230-0x000000018725A250 0x00000001852707B0-0x0000000185270800
		public float pressure { get; set; } // 0x000000018725A200-0x000000018725A210 0x0000000185270950-0x0000000185270970
		public float azimuthAngle { get; set; } // 0x000000018723C440-0x000000018723C450 0x0000000185270930-0x0000000185270950
		public float altitudeAngle { get; set; } // 0x000000018725A1F0-0x000000018725A200 0x0000000185270910-0x0000000185270930
		public float twist { get; set; } // 0x000000018723F0D0-0x000000018723F0E0 0x00000001852708F0-0x0000000185270910
		public Vector2 radius { get; set; } // 0x000000018725A210-0x000000018725A230 0x0000000185270970-0x00000001852709C0
	
		// Nested types
		public struct ButtonState // TypeDefIndex: 72372
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
			public bool isPressed { get; set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x000000018526CF80-0x000000018526CFD0
			public bool ignoreNextClick { get; set; } // 0x0000000187235FE0-0x0000000187235FF0 0x0000000187257CA0-0x0000000187257CB0
			public float pressTime { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725A120-0x000000018725A130
			public bool clickedOnSameGameObject { get; set; } // 0x0000000187235FA0-0x0000000187235FB0 0x000000018723EB40-0x000000018723EB50
			public bool wasPressedThisFrame { get; } // 0x00000001852733B0-0x00000001852733D0 
			public bool wasReleasedThisFrame { get; } // 0x0000000185273390-0x00000001852733B0 
	
			// Methods
			public void CopyPressStateTo(PointerEventData eventData); // 0x00000001852710D0-0x00000001852712E0
			public void CopyPressStateFrom(PointerEventData eventData); // 0x00000001852733D0-0x00000001852734C0
			public void OnEndFrame(); // 0x000000018725A110-0x000000018725A120
		}
	
		// Constructors
		public PointerModel(ExtendedPointerEventData eventData); // 0x0000000186D3B350-0x0000000186D3B490
	
		// Methods
		public void OnFrameFinished(); // 0x0000000185270730-0x00000001852707B0
		public void CopyTouchOrPenStateFrom(PointerEventData eventData); // 0x0000000185270800-0x00000001852708F0
	}

	[AddComponentMenu("Event/Tracked Device Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class TrackedDeviceRaycaster : BaseRaycaster // TypeDefIndex: 72376
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
		public override Camera eventCamera { get; } // 0x000000018D372EA8-0x000000018D372F1C 
		public LayerMask blockingMask { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public bool checkFor3DOcclusion { get; set; } // 0x000000018226EE00-0x000000018226EE10 0x000000018226EE10-0x000000018226EE20
		public bool checkFor2DOcclusion { get; set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public bool ignoreReversedGraphics { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public float maxDistance { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
		private Canvas canvas { get; } // 0x000000018D372E24-0x000000018D372EA8 
	
		// Nested types
		private struct RaycastHitData // TypeDefIndex: 72374
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
			public Graphic graphic { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000184431970-0x0000000184431980 
			public Vector3 worldHitPosition { [IsReadOnly] [CompilerGenerated] get; } // 0x000000018724A620-0x000000018724A640 
			public Vector2 screenPosition { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187244610-0x0000000187244630 
			public float distance { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000187233410-0x0000000187233420 
	
			// Constructors
			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance); // 0x000000018D370D3C-0x000000018D370D78
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72375
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RaycastHitData> __9__25_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D373134-0x000000018D373198
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SortedRaycastGraphics_b__25_0(RaycastHitData g1, RaycastHitData g2); // 0x000000018D3730EC-0x000000018D373134
		}
	
		// Constructors
		public TrackedDeviceRaycaster(); // 0x000000018D372D9C-0x000000018D372E24
		static TrackedDeviceRaycaster(); // 0x000000018D372D08-0x000000018D372D9C
	
		// Methods
		protected override void OnEnable(); // 0x000000018D371E50-0x000000018D371EC0
		protected override void OnDisable(); // 0x000000018D371D88-0x000000018D371E50
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018D372894-0x000000018D372908
		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018D371EC0-0x000000018D37239C
		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results); // 0x000000018D372908-0x000000018D372D08
		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance); // 0x000000018D37239C-0x000000018D372894
	}

	[AddComponentMenu("Input/Virtual Mouse")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#virtual-mouse-cursor-control")]
	public class VirtualMouseInput : MonoBehaviour // TypeDefIndex: 72378
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
		public RectTransform cursorTransform { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public float cursorSpeed { get; set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
		public CursorMode cursorMode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D374408-0x000000018D3744F0
		public Graphic cursorGraphic { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018D3743E4-0x000000018D374408
		public float scrollSpeed { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x00000001872354B0-0x00000001872354C0 
		public InputActionProperty stickAction { get; set; } // 0x000000018723D0D0-0x000000018723D0F0 0x000000018D3747E0-0x000000018D374898
		public InputActionProperty leftButtonAction { get; set; } // 0x000000018724CB70-0x000000018724CB90 0x000000018D3745A8-0x000000018D374650
		public InputActionProperty rightButtonAction { get; set; } // 0x000000018725A380-0x000000018725A3A0 0x000000018D3746F8-0x000000018D3747B0
		public InputActionProperty middleButtonAction { get; set; } // 0x000000018723D130-0x000000018723D150 0x000000018D374650-0x000000018D3746F8
		public InputActionProperty forwardButtonAction { get; set; } // 0x000000018725A360-0x000000018725A380 0x000000018D3744F0-0x000000018D3745A8
		public InputActionProperty backButtonAction { get; set; } // 0x000000018725A340-0x000000018725A360 0x000000018D37432C-0x000000018D3743E4
		public InputActionProperty scrollWheelAction { get; set; } // 0x0000000187250AC0-0x0000000187250AE0 0x000000018D3747B0-0x000000018D3747E0
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 72377
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public VirtualMouseInput(); // 0x000000018D374308-0x000000018D37432C
	
		// Methods
		protected void OnEnable(); // 0x000000018D3736D4-0x000000018D373AF0
		protected void OnDisable(); // 0x000000018D373434-0x000000018D3736D4
		private void TryFindCanvas(); // 0x000000018D373DE0-0x000000018D373E40
		private void TryEnableHardwareCursor(); // 0x000000018D373BE8-0x000000018D373DE0
		private void UpdateMotion(); // 0x000000018D373E40-0x000000018D374308
		private void OnButtonActionTriggered(InputAction.CallbackContext context); // 0x000000018D37329C-0x000000018D373434
		private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x02622CD5 */); // 0x000000018C267A38-0x000000018C267AA4
		private static void SetAction(ref InputActionProperty field, InputActionProperty value); // 0x000000018D373AF0-0x000000018D373BE8
		private void OnAfterInputUpdate(); // 0x000000018D373294-0x000000018D37329C
	}
}

namespace UnityEngine.InputSystem.Users
{
	public struct InputUser : IEquatable<InputUser> // TypeDefIndex: 72354
	{
		// Fields
		public const uint InvalidId = 0; // Metadata: 0x02622CB2
		private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x00
		private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x08
		private uint m_Id; // 0x00
		private static GlobalState s_GlobalState; // 0x10
	
		// Properties
		public bool valid { get; } // 0x000000018D35AE1C-0x000000018D35AED0 
		public int index { get; } // 0x000000018D35A944-0x000000018D35AA78 
		public uint id { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public InputUserAccountHandle? platformUserAccountHandle { get; } // 0x000000018D35AC98-0x000000018D35AD2C 
		public string platformUserAccountName { get; } // 0x000000018D35ADA4-0x000000018D35AE1C 
		public string platformUserAccountId { get; } // 0x000000018D35AD2C-0x000000018D35ADA4 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> pairedDevices { get; } // 0x000000018D35ABB4-0x000000018D35AC98 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> lostDevices { get; } // 0x000000018D35AACC-0x000000018D35ABB4 
		public IInputActionCollection actions { get; } // 0x000000018D35A690-0x000000018D35A708 
		public InputControlScheme? controlScheme { get; } // 0x000000018D35A834-0x000000018D35A8C8 
		public InputControlScheme.MatchResult controlSchemeMatch { get; } // 0x000000018D35A784-0x000000018D35A834 
		public bool hasMissingRequiredDevices { get; } // 0x000000018D35A8C8-0x000000018D35A944 
		public static ReadOnlyArray<InputUser> all { get; } // 0x000000018D35A708-0x000000018D35A784 
		public static int listenForUnpairedDeviceActivity { get; set; } // 0x000000018D35AA78-0x000000018D35AACC 0x000000018D35B13C-0x000000018D35B248
	
		// Events
		public static event Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice> onChange {
			add; // 0x000000018D35A430-0x000000018D35A4EC
			remove; // 0x000000018D35AED0-0x000000018D35AF8C
		}
		public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed {
			add; // 0x000000018D35A5AC-0x000000018D35A690
			remove; // 0x000000018D35B04C-0x000000018D35B13C
		}
		public static event Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity {
			add; // 0x000000018D35A4EC-0x000000018D35A5AC
			remove; // 0x000000018D35AF8C-0x000000018D35B04C
		}
	
		// Nested types
		public struct ControlSchemeChangeSyntax // TypeDefIndex: 72347
		{
			// Fields
			internal int m_UserIndex; // 0x00
	
			// Methods
			public ControlSchemeChangeSyntax AndPairRemainingDevices(); // 0x000000018D36A760-0x000000018D36A7B0
		}
	
		[Flags]
		internal enum UserFlags // TypeDefIndex: 72348
		{
			BindToAllDevices = 1,
			UserAccountSelectionInProgress = 2
		}
	
		private struct UserData // TypeDefIndex: 72349
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
	
		private struct CompareDevicesByUserAccount : IComparer<UnityEngine.InputSystem.InputDevice> // TypeDefIndex: 72350
		{
			// Fields
			public InputUserAccountHandle platformUserAccountHandle; // 0x00
	
			// Methods
			public int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y); // 0x000000018D36A618-0x000000018D36A760
			private static InputUserAccountHandle? GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018723D1E0-0x000000018723D1F0
		}
	
		private struct OngoingAccountSelection // TypeDefIndex: 72351
		{
			// Fields
			public UnityEngine.InputSystem.InputDevice device; // 0x00
			public uint userId; // 0x08
		}
	
		private struct GlobalState // TypeDefIndex: 72352
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
		private sealed class __c // TypeDefIndex: 72353
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__88_0; // 0x08
			public static Action __9__88_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D373198-0x000000018D3731FC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SaveAndResetState_b__88_0(ref GlobalState state); // 0x000000018D372F1C-0x000000018D3730AC
			internal void _SaveAndResetState_b__88_1(); // 0x000000018D3730AC-0x000000018D3730EC
		}
	
		// Constructors
		static InputUser(); // 0x000000018D35A390-0x000000018D35A430
	
		// Methods
		public override string ToString(); // 0x000000018D358790-0x000000018D3589B4
		public void AssociateActionsWithUser(IInputActionCollection actions); // 0x000000018D354ED0-0x000000018D3551A0
		public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName); // 0x000000018D354768-0x000000018D354830
		private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme); // 0x000000018D3589B4-0x000000018D358C40
		internal void FindControlScheme(string schemeName, out InputControlScheme scheme); // 0x000000018D355348-0x000000018D355464
		public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme); // 0x000000018D3545BC-0x000000018D354768
		private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme); // 0x000000018D3541C4-0x000000018D3545BC
		public void UnpairDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D359144-0x000000018D359248
		public void UnpairDevices(); // 0x000000018D3592A4-0x000000018D3594CC
		private static void RemoveLostDevicesForUser(int userIndex); // 0x000000018D357FE4-0x000000018D3581D4
		public void UnpairDevicesAndRemoveUser(); // 0x000000018D359248-0x000000018D3592A4
		public static InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices(); // 0x000000018D35597C-0x000000018D3559EC
		public static int GetUnpairedInputDevices(ref InputControlList<UnityEngine.InputSystem.InputDevice> list); // 0x000000018D35579C-0x000000018D35597C
		public static InputUser? FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device); // 0x000000018D35569C-0x000000018D35579C
		public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle); // 0x000000018D355550-0x000000018D35569C
		public static InputUser CreateUserWithoutPairedDevices(); // 0x000000018D3551A0-0x000000018D355208
		public static InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, InputUser user = default, InputUserPairingOptions options = InputUserPairingOptions.None /* Metadata: 0x02622CAC */); // 0x000000018D35762C-0x000000018D35789C
		private static bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, InputUserPairingOptions options); // 0x000000018D355E80-0x000000018D355FF0
		public bool Equals(InputUser other); // 0x0000000184FF20D0-0x0000000184FF20E0
		public override bool Equals(object obj); // 0x000000018D3552E0-0x000000018D355348
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public static bool operator ==(InputUser left, InputUser right); // 0x0000000189CCDE30-0x0000000189CCDE38
		public static bool operator !=(InputUser left, InputUser right); // 0x000000018CCE071C-0x000000018CCE0724
		private static int AddUser(); // 0x000000018D354D64-0x000000018D354ED0
		private static void RemoveUser(int userIndex); // 0x000000018D3581D4-0x000000018D358508
		private static void Notify(int userIndex, InputUserChange change, UnityEngine.InputSystem.InputDevice device); // 0x000000018D355FF0-0x000000018D356294
		private static int TryFindUserIndex(uint userId); // 0x000000018D358C40-0x000000018D358CEC
		private static int TryFindUserIndex(InputUserAccountHandle platformHandle); // 0x000000018D358E24-0x000000018D358F34
		private static int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device); // 0x000000018D358CEC-0x000000018D358E24
		private static void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x02622CAD */, bool dontUpdateControlScheme = false /* Metadata: 0x02622CAE */); // 0x000000018D354830-0x000000018D354D64
		private static void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x02622CAF */); // 0x000000018D357AB4-0x000000018D357FE4
		private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false /* Metadata: 0x02622CB0 */); // 0x000000018D3594CC-0x000000018D359E44
		private static long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device); // 0x000000018D359E44-0x000000018D35A390
		private static long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId); // 0x000000018D35789C-0x000000018D357AB4
		private static bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device); // 0x000000018D355DC0-0x000000018D355E80
		private static void OnActionChange(object obj, InputActionChange change); // 0x000000018D356294-0x000000018D35636C
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change); // 0x000000018D35636C-0x000000018D356A10
		private static int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex = 0 /* Metadata: 0x02622CB1 */); // 0x000000018D355464-0x000000018D355550
		private static void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device); // 0x000000018D356A10-0x000000018D35762C
		internal static ISavedState SaveAndResetState(); // 0x000000018D358554-0x000000018D358790
		private static void HookIntoActionChange(); // 0x000000018D3559EC-0x000000018D355B40
		private static void UnhookFromActionChange(); // 0x000000018D358F34-0x000000018D359008
		private static void HookIntoDeviceChange(); // 0x000000018D355B40-0x000000018D355C80
		private static void UnhookFromDeviceChange(); // 0x000000018D359008-0x000000018D3590A4
		private static void HookIntoEvents(); // 0x000000018D355C80-0x000000018D355DC0
		private static void UnhookFromDeviceStateChange(); // 0x000000018D3590A4-0x000000018D359144
		private static void DisposeAndResetGlobalState(); // 0x000000018D355208-0x000000018D3552E0
		internal static void ResetGlobals(); // 0x000000018D358508-0x000000018D358554
	}

	public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle> // TypeDefIndex: 72355
	{
		// Fields
		private string m_ApiName; // 0x00
		private ulong m_Handle; // 0x08
	
		// Properties
		public string apiName { get; } // 0x0000000184431970-0x0000000184431980 
		public ulong handle { get; } // 0x00000001844AFA30-0x00000001844AFA40 
	
		// Constructors
		public InputUserAccountHandle(string apiName, ulong handle); // 0x000000018D36DD04-0x000000018D36DD84
	
		// Methods
		public override string ToString(); // 0x000000018D36DC58-0x000000018D36DD04
		public bool Equals(InputUserAccountHandle other); // 0x000000018D36DB20-0x000000018D36DBB0
		public override bool Equals(object obj); // 0x000000018D36DBB0-0x000000018D36DC20
		public static bool operator ==(InputUserAccountHandle left, InputUserAccountHandle right); // 0x000000018D36DD84-0x000000018D36DDA4
		public static bool operator !=(InputUserAccountHandle left, InputUserAccountHandle right); // 0x000000018D36DDA4-0x000000018D36DDC4
		public override int GetHashCode(); // 0x000000018D36DC20-0x000000018D36DC58
	}

	public enum InputUserChange // TypeDefIndex: 72356
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
	public enum InputUserPairingOptions // TypeDefIndex: 72357
	{
		None = 0,
		ForcePlatformUserAccountSelection = 1,
		ForceNoPlatformUserAccountSelection = 2,
		UnpairCurrentDevicesFromUser = 8
	}

	[Serializable]
	internal class InputUserSettings // TypeDefIndex: 72358
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
		public string customBindings { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public bool invertMouseX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool invertMouseY { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public float? mouseSmoothing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258A90-0x0000000187258AA0 0x000000018725A1E0-0x000000018725A1F0
		public float? mouseSensitivity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725A1D0-0x000000018725A1E0 0x0000000187253B00-0x0000000187253B10
		public bool invertStickX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
		public bool invertStickY { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E0B0-0x000000018225E0C0 0x000000018225E0C0-0x000000018225E0D0
		public bool swapSticks { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018236FCA0-0x000000018236FCB0 0x000000018236FCB0-0x0000000182372280
		public bool swapBumpers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187256750-0x0000000187256760 0x0000000187256760-0x0000000187256770
		public bool swapTriggers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public bool swapDpadAndLeftStick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182260CA0-0x0000000182260CB0 0x0000000182260CB0-0x0000000182260CC0
		public float vibrationStrength { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
	
		// Constructors
		public InputUserSettings(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void Apply(IInputActionCollection actions); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.InputSystem.Utilities
{
	public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IDisposable // TypeDefIndex: 72648
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
		public InputEventBuffer buffer { get; } // 0x0000000187259990-0x00000001872599B0 
		public int count { get; } // 0x00000001872332A0-0x00000001872332B0 
	
		// Nested types
		public struct ActionEventPtr // TypeDefIndex: 72646
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr; // 0x08
	
			// Properties
			public InputAction action { get; } // 0x000000018D300134-0x000000018D300160 
			public InputActionPhase phase { get; } // 0x00000001872598D0-0x00000001872598E0 
			public InputControl control { get; } // 0x000000018D300160-0x000000018D300198 
			public IInputInteraction interaction { get; } // 0x000000018D3001B8-0x000000018D300204 
			public double time { get; } // 0x000000018D300204-0x000000018D300224 
			public double startTime { get; } // 0x00000001872598E0-0x00000001872598F0 
			public double duration { get; } // 0x000000018D300198-0x000000018D3001B8 
			public int valueSizeInBytes { get; } // 0x00000001872598F0-0x0000000187259900 
	
			// Methods
			public object ReadValueAsObject(); // 0x000000018D2FFB80-0x000000018D2FFD9C
			public unsafe void ReadValue(void* buffer, int bufferSize); // 0x000000018D2FFD9C-0x000000018D2FFE98
			public TValue ReadValue<TValue>()
				where TValue : struct;
			public override string ToString(); // 0x000000018D2FFE98-0x000000018D300134
		}
	
		private struct Enumerator : IEnumerator<ActionEventPtr> // TypeDefIndex: 72647
		{
			// Fields
			private readonly InputActionTrace m_Trace; // 0x00
			private readonly unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer; // 0x08
			private readonly int m_EventCount; // 0x10
			private unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent; // 0x18
			private int m_CurrentIndex; // 0x20
	
			// Properties
			public ActionEventPtr Current { get; } // 0x000000018D301940-0x000000018D3019C4 
			object IEnumerator.Current { get; } // 0x000000018D301894-0x000000018D3018EC 
	
			// Constructors
			public unsafe Enumerator(InputActionTrace trace); // 0x000000018D3018EC-0x000000018D301940
	
			// Methods
			public bool MoveNext(); // 0x000000018D301844-0x000000018D301894
			public void Reset(); // 0x0000000187259940-0x0000000187259950
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public InputActionTrace(); // 0x0000000186805BA0-0x0000000186805BB0
		public InputActionTrace(InputAction action); // 0x000000018D302FC4-0x000000018D303030
		public InputActionTrace(InputActionMap actionMap); // 0x000000018D303030-0x000000018D30309C
	
		// Methods
		public void SubscribeToAll(); // 0x000000018D302730-0x000000018D3027E8
		public void UnsubscribeFromAll(); // 0x000000018D302CF4-0x000000018D302DAC
		public void SubscribeTo(InputAction action); // 0x000000018D302910-0x000000018D302A60
		public void SubscribeTo(InputActionMap actionMap); // 0x000000018D3027E8-0x000000018D302910
		public void UnsubscribeFrom(InputAction action); // 0x000000018D302DAC-0x000000018D302ECC
		public void UnsubscribeFrom(InputActionMap actionMap); // 0x000000018D302ECC-0x000000018D302FC4
		public void RecordAction(InputAction.CallbackContext context); // 0x000000018D3025A4-0x000000018D302730
		public void Clear(); // 0x000000018D301F50-0x000000018D301F9C
		~InputActionTrace(); // 0x000000018D302194-0x000000018D302208
		public override string ToString(); // 0x000000018D302A68-0x000000018D302C98
		public void Dispose(); // 0x000000018D302174-0x000000018D302194
		private void DisposeInternal(); // 0x000000018D30206C-0x000000018D302174
		public IEnumerator<ActionEventPtr> GetEnumerator(); // 0x000000018D302208-0x000000018D302288
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D302A60-0x000000018D302A68
		private void HookOnActionChange(); // 0x000000018D302288-0x000000018D302348
		private void UnhookOnActionChange(); // 0x000000018D302C98-0x000000018D302CF4
		private void OnActionChange(object actionOrMapOrAsset, InputActionChange change); // 0x000000018D302348-0x000000018D3025A4
		private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap); // 0x000000018D301F9C-0x000000018D30206C
	}

	internal static class ArrayHelpers // TypeDefIndex: 72652
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0<TValue> // TypeDefIndex: 72649
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
		private sealed class __c__DisplayClass34_0<TValue> // TypeDefIndex: 72650
		{
			// Fields
			public IEqualityComparer<TValue> comparer;
	
			// Constructors
			public __c__DisplayClass34_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_1<TValue> // TypeDefIndex: 72651
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
		public static void EnsureCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x02623064 */);
		public static void DuplicateWithCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x02623065 */);
		public static bool Contains<TValue>(TValue[] array, TValue value);
		public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647 /* Metadata: 0x02623066 */);
		public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x02623067 */, int count = -1 /* Metadata: 0x02623068 */);
		public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator)
			where TValue : struct;
		public static int Append<TValue>(ref ref TValue[] array, TValue value);
		public static int Append<TValue>(ref ref TValue[] array, IEnumerable<TValue> values);
		public static int AppendToImmutable<TValue>(ref ref TValue[] array, TValue[] values);
		public static int AppendWithCapacity<TValue>(ref ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x0262306E */);
		public static int AppendListWithCapacity<TValue, TValues>(ref ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10 /* Metadata: 0x0262306F */)
			where TValues : IReadOnlyList<TValue>;
		public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x02623070 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02623071 */)
			where TValue : struct;
		public static void InsertAt<TValue>(ref ref TValue[] array, int index, TValue value);
		public static void InsertAtWithCapacity<TValue>(ref ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10 /* Metadata: 0x02623072 */);
		public static void PutAtIfNotSet<TValue>(ref ref TValue[] array, int index, Func<TValue> valueFn);
		public static int GrowBy<TValue>(ref ref TValue[] array, int count);
		public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02623073 */)
			where TValue : struct;
		public static int GrowWithCapacity<TValue>(ref ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x02623074 */);
		public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x02623075 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02623076 */)
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
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate, int startIndex = 0 /* Metadata: 0x02623069 */, int count = -1 /* Metadata: 0x0262306A */);
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int count = -1 /* Metadata: 0x0262306B */)
			where TFirst : TSecond
			where TSecond : class;
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int startIndex, int count)
			where TFirst : TSecond
			where TSecond : class;
		public static int IndexOfValue<TValue>(this TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x0262306C */, int count = -1 /* Metadata: 0x0262306D */)
			where TValue : struct, IEquatable<TValue>;
		public static void EraseAtWithCapacity<TValue>(this TValue[] array, ref int count, int index);
		public static void SwapElements<TValue>(this TValue[] array, int index1, int index2);
		public static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2)
			where TValue : struct;
	}

	internal struct CallbackArray<TDelegate> // TypeDefIndex: 72653
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

	public struct Vector2MagnitudeComparer : IComparer<Vector2> // TypeDefIndex: 72654
	{
		// Methods
		public int Compare(Vector2 x, Vector2 y); // 0x000000018D30C828-0x000000018D30C87C
	}

	public struct Vector3MagnitudeComparer : IComparer<Vector3> // TypeDefIndex: 72655
	{
		// Methods
		public int Compare(Vector3 x, Vector3 y); // 0x000000018D30CD8C-0x000000018D30CE40
	}

	internal static class CSharpCodeHelpers // TypeDefIndex: 72656
	{
		// Methods
		public static bool IsProperIdentifier(string name); // 0x000000018D3007F0-0x000000018D3008A4
		public static bool IsEmptyOrProperIdentifier(string name); // 0x000000018D30071C-0x000000018D30073C
		public static bool IsEmptyOrProperNamespaceName(string name); // 0x000000018D30073C-0x000000018D3007F0
		public static string MakeIdentifier(string name, string suffix = "" /* Metadata: 0x02623077 */); // 0x000000018D3008A4-0x000000018D300A88
		public static string MakeTypeName(string name, string suffix = "" /* Metadata: 0x02623078 */); // 0x000000018D300A88-0x000000018D300B64
	}

	internal static class DelegateHelpers // TypeDefIndex: 72657
	{
		// Methods
		public static void InvokeCallbacksSafe(ref CallbackArray<Action> callbacks, ProfilerMarker marker, string callbackName, object context = null); // 0x0000000185E3DF10-0x0000000185E3E340
		public static void InvokeCallbacksSafe<TValue>(ref CallbackArray<Action<TValue>> callbacks, TValue argument, string callbackName, object context = null);
		public static void InvokeCallbacksSafe<TValue1, TValue2>(ref CallbackArray<Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context = null);
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref CallbackArray<Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null);
		public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref CallbackArray<Func<TValue, Action>> callbacks, TValue argument, string callbackName, object context = null);
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref CallbackArray<Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context = null);
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class DisplayStringFormatAttribute : Attribute // TypeDefIndex: 72658
	{
		// Fields
		[CompilerGenerated]
		private string _formatString_k__BackingField; // 0x10
	
		// Properties
		public string formatString { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public DisplayStringFormatAttribute(string formatString); // 0x0000000184FD2410-0x0000000184FD2420
	}

	internal static class ExceptionHelpers // TypeDefIndex: 72659
	{
		// Extension methods
		public static bool IsExceptionIndicatingBugInCode(this Exception exception); // 0x000000018D3019C4-0x000000018D301A48
	}

	public struct FourCC : IEquatable<FourCC> // TypeDefIndex: 72660
	{
		// Fields
		private int m_Code; // 0x00
	
		// Constructors
		public FourCC(int code); // 0x0000000184547F40-0x0000000184547F50
		public FourCC(char a, char b = ' ' /* Metadata: 0x02623079 */, char c = ' ' /* Metadata: 0x0262307B */, char d = ' ' /* Metadata: 0x0262307D */); // 0x0000000187259950-0x0000000187259980
		public FourCC(string str); // 0x000000018D301C20-0x000000018D301DBC
	
		// Methods
		public static implicit operator int(FourCC fourCC); // 0x0000000187235A70-0x0000000187235A80
		public static implicit operator FourCC(int i); // 0x0000000187235A70-0x0000000187235A80
		public override string ToString(); // 0x000000018D301AA4-0x000000018D301C20
		public bool Equals(FourCC other); // 0x0000000184FF20D0-0x0000000184FF20E0
		public override bool Equals(object obj); // 0x000000018D301A48-0x000000018D301AA4
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public static bool operator ==(FourCC left, FourCC right); // 0x0000000189CCDE30-0x0000000189CCDE38
		public static bool operator !=(FourCC left, FourCC right); // 0x000000018CCE071C-0x000000018CCE0724
		public static FourCC FromInt32(int i); // 0x0000000187235A70-0x0000000187235A80
		public static int ToInt32(FourCC fourCC); // 0x0000000187235A70-0x0000000187235A80
	}

	internal struct InlinedArray<TValue> : IEnumerable<TValue> // TypeDefIndex: 72662
	{
		// Fields
		public int length;
		public TValue firstValue;
		public TValue[] additionalValues;
	
		// Properties
		public int Capacity { get; }
		public TValue this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 72661
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
		public int AppendWithCapacity(TValue value, int capacityIncrement = 10 /* Metadata: 0x0262307F */);
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

	internal static class InputArrayExtensions // TypeDefIndex: 72663
	{
		// Extension methods
		public static int IndexOfReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class;
		public static bool Contains<TValue>(this InlinedArray<TValue> array, TValue value);
		public static bool ContainsReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class;
	}

	public struct InternedString : IEquatable<InternedString>, IComparable<InternedString> // TypeDefIndex: 72664
	{
		// Fields
		private readonly string m_StringOriginalCase; // 0x00
		private readonly string m_StringLowerCase; // 0x08
	
		// Properties
		public int length { get; } // 0x000000018D308888-0x000000018D308898 
	
		// Constructors
		public InternedString(string text); // 0x0000000185267410-0x00000001852674B0
	
		// Methods
		public bool IsEmpty(); // 0x0000000185267780-0x0000000185267790
		public string ToLower(); // 0x00000001844AFA30-0x00000001844AFA40
		public override bool Equals(object obj); // 0x000000018D3087C0-0x000000018D308888
		public bool Equals(InternedString other); // 0x0000000185265280-0x0000000185265290
		public int CompareTo(InternedString other); // 0x000000018D3087A8-0x000000018D3087C0
		public override int GetHashCode(); // 0x000000018526A000-0x000000018526A020
		public override string ToString(); // 0x0000000185265C70-0x0000000185265C90
		public static bool operator ==(InternedString a, InternedString b); // 0x0000000185265280-0x0000000185265290
		public static bool operator !=(InternedString a, InternedString b); // 0x0000000185265270-0x0000000185265280
		public static bool operator ==(InternedString a, string b); // 0x000000018D308914-0x000000018D308990
		public static bool operator !=(InternedString a, string b); // 0x000000018D308A30-0x000000018D308AAC
		public static bool operator ==(string a, InternedString b); // 0x000000018D308898-0x000000018D308914
		public static bool operator !=(string a, InternedString b); // 0x000000018D3089B4-0x000000018D308A30
		public static bool operator <(InternedString left, InternedString right); // 0x000000018D308AAC-0x000000018D308AD0
		public static bool operator >(InternedString left, InternedString right); // 0x000000018D308990-0x000000018D3089B4
		public static implicit operator string(InternedString str); // 0x0000000187835734-0x0000000187835744
	}

	internal struct JsonParser // TypeDefIndex: 72669
	{
		// Fields
		private readonly string m_Text; // 0x00
		private readonly int m_Length; // 0x08
		private int m_Position; // 0x0C
		private bool m_MatchAnyElementInArray; // 0x10
		private bool m_DryRun; // 0x11
	
		// Properties
		public bool isAtEnd { get; } // 0x000000018D3093E0-0x000000018D3093EC 
	
		// Nested types
		public enum JsonValueType // TypeDefIndex: 72665
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
	
		public struct JsonString : IEquatable<JsonString> // TypeDefIndex: 72666
		{
			// Fields
			public Substring text; // 0x00
			public bool hasEscapes; // 0x10
	
			// Methods
			public override string ToString(); // 0x000000018D309644-0x000000018D309710
			public bool Equals(JsonString other); // 0x000000018D3093EC-0x000000018D309564
			public override bool Equals(object obj); // 0x000000018D309564-0x000000018D3095DC
			public override int GetHashCode(); // 0x000000018D3095DC-0x000000018D309644
			public static bool operator ==(JsonString left, JsonString right); // 0x000000018D309710-0x000000018D30973C
			public static bool operator !=(JsonString left, JsonString right); // 0x000000018D309778-0x000000018D3097A4
			public static implicit operator JsonString(string str); // 0x000000018D30973C-0x000000018D309778
		}
	
		public struct JsonValue : IEquatable<JsonValue> // TypeDefIndex: 72668
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
			private sealed class __c // TypeDefIndex: 72667
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<JsonValue, string> __9__11_0; // 0x08
				public static Func<KeyValuePair<string, JsonValue>, string> __9__11_1; // 0x10
	
				// Constructors
				static __c(); // 0x000000018D3132F0-0x000000018D313354
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _ToString_b__11_0(JsonValue x); // 0x000000018D313148-0x000000018D31315C
				internal string _ToString_b__11_1(KeyValuePair<string, JsonValue> pair); // 0x000000018D31315C-0x000000018D313200
			}
	
			// Methods
			public bool ToBoolean(); // 0x000000018D309964-0x000000018D3099F0
			public long ToInteger(); // 0x000000018D309A8C-0x000000018D309B18
			public double ToDouble(); // 0x000000018D3099F0-0x000000018D309A8C
			public override string ToString(); // 0x000000018D309B18-0x000000018D309F38
			public static implicit operator JsonValue(bool val); // 0x00000001872599C0-0x00000001872599F0
			public static implicit operator JsonValue(long val); // 0x00000001872599F0-0x0000000187259A20
			public static implicit operator JsonValue(double val); // 0x0000000187259A20-0x0000000187259A50
			public static implicit operator JsonValue(string str); // 0x000000018D309F7C-0x000000018D309FFC
			public static implicit operator JsonValue(JsonString str); // 0x000000018D30A040-0x000000018D30A08C
			public static implicit operator JsonValue(List<JsonValue> array); // 0x000000018D309F38-0x000000018D309F7C
			public static implicit operator JsonValue(Dictionary<string, JsonValue> obj); // 0x000000018D30A08C-0x000000018D30A0D0
			public static implicit operator JsonValue(Enum val); // 0x000000018D309FFC-0x000000018D30A040
			public bool Equals(JsonValue other); // 0x0000000186557600-0x00000001865576D0
			private static bool Equals(object obj, JsonValue value); // 0x00000001865576D0-0x00000001865577C0
			public override bool Equals(object obj); // 0x000000018D3097A4-0x000000018D30983C
			public override int GetHashCode(); // 0x000000018D30983C-0x000000018D309964
			public static bool operator ==(JsonValue left, JsonValue right); // 0x00000001878356F0-0x0000000187835734
			public static bool operator !=(JsonValue left, JsonValue right); // 0x000000018D30A0D0-0x000000018D30A114
		}
	
		// Constructors
		public JsonParser(string json); // 0x0000000185265C90-0x0000000185265CD0
	
		// Methods
		public void Reset(); // 0x00000001872599B0-0x00000001872599C0
		public override string ToString(); // 0x000000018D309314-0x000000018D3093E0
		public bool NavigateToProperty(string path); // 0x00000001852660E0-0x00000001852662A0
		public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue); // 0x0000000185265CD0-0x0000000185265DC0
		public bool ParseToken(char token); // 0x00000001852662A0-0x0000000185266310
		public bool ParseValue(); // 0x000000018D309240-0x000000018D309274
		public bool ParseValue(out JsonValue result); // 0x0000000185265DC0-0x0000000185265E60
		public bool ParseStringValue(out JsonValue result); // 0x000000018D3090A4-0x000000018D309240
		public bool ParseArrayValue(out JsonValue result); // 0x000000018D308AD0-0x000000018D308D4C
		public bool ParseObjectValue(out JsonValue result); // 0x000000018D308E9C-0x000000018D3090A4
		public bool ParseNumber(out JsonValue result); // 0x0000000185265E60-0x00000001852660E0
		public bool ParseBooleanValue(out JsonValue result); // 0x000000018D308D4C-0x000000018D308E44
		public bool ParseNullValue(out JsonValue result); // 0x000000018D308E44-0x000000018D308E9C
		public bool SkipToValue(); // 0x0000000185266310-0x0000000185266360
		private bool SkipString(string text); // 0x000000018D309274-0x000000018D309314
		private void SkipWhitespace(); // 0x0000000185266360-0x00000001852663E0
	}

	internal static class MemoryHelpers // TypeDefIndex: 72671
	{
		// Nested types
		public struct BitRegion // TypeDefIndex: 72670
		{
			// Fields
			public uint bitOffset; // 0x00
			public uint sizeInBits; // 0x04
	
			// Properties
			public bool isEmpty { get; } // 0x0000000184FC7720-0x0000000184FC7730 
	
			// Constructors
			public BitRegion(uint bitOffset, uint sizeInBits); // 0x00000001827241A0-0x00000001827241B0
			public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits); // 0x0000000187259A80-0x0000000187259A90
	
			// Methods
			public BitRegion Overlap(BitRegion other); // 0x00000001853AFDC0-0x00000001853AFE40
		}
	
		// Methods
		public static unsafe bool Compare(void* ptr1, void* ptr2, BitRegion region); // 0x00000001853AFE60-0x00000001853AFEE0
		public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits); // 0x000000018D30D5E0-0x000000018D30D5F8
		public static unsafe void WriteSingleBit(void* ptr, uint bitOffset, bool value); // 0x0000000187066C10-0x0000000187066C40
		public static unsafe bool ReadSingleBit(void* ptr, uint bitOffset); // 0x00000001853B0460-0x00000001853B0490
		public static unsafe void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount); // 0x000000018D30D5F8-0x000000018D30D6E0
		public static unsafe bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null); // 0x00000001853AFFC0-0x00000001853B0120
		public static unsafe void MemSet(void* destination, int numBytes, byte value); // 0x000000018D30D7D8-0x000000018D30D89C
		public static unsafe void MemCpyMasked(void* destination, void* source, int numBytes, void* mask); // 0x000000018D30D6E0-0x000000018D30D7D8
		public static unsafe uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018D30D8F8-0x000000018D30DACC
		public static unsafe void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value); // 0x000000018D30DB4C-0x000000018D30DD4C
		public static unsafe int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018D30DACC-0x000000018D30DAD4
		public static unsafe void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value); // 0x000000018D30DB00-0x000000018D30DB10
		public static unsafe int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018D30D89C-0x000000018D30D8C8
		public static unsafe void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value); // 0x000000018D30DAD4-0x000000018D30DB00
		public static unsafe float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount); // 0x000000018D30D8C8-0x000000018D30D8F8
		public static unsafe void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value); // 0x000000018D30DB10-0x000000018D30DB4C
		public static unsafe void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value); // 0x0000000185268140-0x0000000185268260
		public static void Swap<TValue>(ref ref TValue a, ref ref TValue b);
		public static uint AlignNatural(uint offset, uint sizeInBytes); // 0x000000018D30D58C-0x000000018D30D5E0
	}

	internal static class MiscHelpers // TypeDefIndex: 72673
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _EveryNth_d__1<TValue> : IEnumerable<TValue>, IEnumerator<TValue> // TypeDefIndex: 72672
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
		public static IEnumerable<TValue> EveryNth<TValue>(this IEnumerable<TValue> enumerable, int n, int start = 0 /* Metadata: 0x02623088 */);
		public static int IndexOf<TValue>(this IEnumerable<TValue> enumerable, TValue value);
	}

	public struct NameAndParameters // TypeDefIndex: 72675
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x00
		[CompilerGenerated]
		private ReadOnlyArray<NamedValue> _parameters_k__BackingField; // 0x08
	
		// Properties
		public string name { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public ReadOnlyArray<NamedValue> parameters { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018453CA30-0x000000018453CA40 0x000000018D30E1D4-0x000000018D30E1E4
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72674
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NamedValue, string> __9__8_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D313228-0x000000018D31328C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _ToString_b__8_0(NamedValue x); // 0x000000018D313200-0x000000018D313214
		}
	
		// Methods
		public override string ToString(); // 0x000000018D30DF90-0x000000018D30E1D4
		public static IEnumerable<NameAndParameters> ParseMultiple(string text); // 0x000000018D30DD4C-0x000000018D30DDA8
		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list); // 0x000000018D30DDA8-0x000000018D30DF04
		internal static string ParseName(string text); // 0x000000018D30DF04-0x000000018D30DF90
		public static NameAndParameters Parse(string text); // 0x0000000186317AF0-0x0000000186317B40
		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false /* Metadata: 0x02623089 */); // 0x0000000186317840-0x0000000186317A40
	}

	public struct NamedValue : IEquatable<NamedValue> // TypeDefIndex: 72676
	{
		// Fields
		public const string Separator = ","; // Metadata: 0x0262308A
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x00
		[CompilerGenerated]
		private PrimitiveValue _value_k__BackingField; // 0x08
	
		// Properties
		public string name { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public PrimitiveValue value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018453CA30-0x000000018453CA40 0x000000018723B0B0-0x000000018723B0C0
		public TypeCode type { get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Methods
		public NamedValue ConvertTo(TypeCode type); // 0x000000018D30E444-0x000000018D30E49C
		public static NamedValue From<TValue>(string name, TValue value)
			where TValue : struct;
		public override string ToString(); // 0x000000018D30E9F8-0x000000018D30EA6C
		public bool Equals(NamedValue other); // 0x000000018D30E49C-0x000000018D30E4F8
		public override bool Equals(object obj); // 0x000000018D30E4F8-0x000000018D30E570
		public override int GetHashCode(); // 0x000000018D30E570-0x000000018D30E5BC
		public static bool operator ==(NamedValue left, NamedValue right); // 0x000000018D30EA6C-0x000000018D30EA98
		public static bool operator !=(NamedValue left, NamedValue right); // 0x000000018D30EA98-0x000000018D30EAC4
		public static NamedValue[] ParseMultiple(string parameterString); // 0x000000018D30E5BC-0x000000018D30E724
		public static NamedValue Parse(string str); // 0x000000018D30E9BC-0x000000018D30E9F8
		private static NamedValue ParseParameter(string parameterString, ref int index); // 0x000000018D30E724-0x000000018D30E9BC
		public void ApplyToObject(object instance); // 0x000000018D30E1E4-0x000000018D30E444
		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters)
			where TParameterList : IEnumerable<NamedValue>;
	}

	internal static class NumberHelpers // TypeDefIndex: 72677
	{
		// Methods
		public static bool Approximately(double a, double b); // 0x000000018D30EB10-0x000000018D30EBB0
		public static float IntToNormalizedFloat(int value, int minValue, int maxValue); // 0x000000018D30EBB0-0x000000018D30EBF8
		public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue); // 0x000000018D30EBF8-0x000000018D30EC40
		public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue); // 0x000000018D30ECD0-0x000000018D30ED20
		public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue); // 0x000000018D30EC40-0x000000018D30EC90
		public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize); // 0x000000018D30EC90-0x000000018D30ECD0
	
		// Extension methods
		public static int AlignToMultipleOf(this int number, int alignment); // 0x000000018D30EAC4-0x000000018D30EADC
		public static long AlignToMultipleOf(this long number, long alignment); // 0x000000018D30EAF4-0x000000018D30EB10
		public static uint AlignToMultipleOf(this uint number, uint alignment); // 0x000000018D30EADC-0x000000018D30EAF4
	}

	internal class ForDeviceEventObservable : IObservable<InputEventPtr> // TypeDefIndex: 72679
	{
		// Fields
		private IObservable<InputEventPtr> m_Source; // 0x10
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
		private System.Type m_DeviceType; // 0x20
	
		// Nested types
		private class ForDevice : IObserver<InputEventPtr> // TypeDefIndex: 72678
		{
			// Fields
			private IObserver<InputEventPtr> m_Observer; // 0x10
			private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
			private System.Type m_DeviceType; // 0x20
	
			// Constructors
			public ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, IObserver<InputEventPtr> observer); // 0x000000018D30D554-0x000000018D30D58C
	
			// Methods
			public void OnCompleted(); // 0x0000000186805BA0-0x0000000186805BB0
			public void OnError(Exception error); // 0x000000018D30D414-0x000000018D30D460
			public void OnNext(InputEventPtr value); // 0x000000018D30D460-0x000000018D30D554
		}
	
		// Constructors
		public ForDeviceEventObservable(IObservable<InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device); // 0x000000018D30D3DC-0x000000018D30D414
	
		// Methods
		public IDisposable Subscribe(IObserver<InputEventPtr> observer); // 0x000000018D30D320-0x000000018D30D3DC
	}

	public static class Observable // TypeDefIndex: 72681
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0<TValue> // TypeDefIndex: 72680
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
		public static IObservable<InputEventPtr> ForDevice(this IObservable<InputEventPtr> source, UnityEngine.InputSystem.InputDevice device); // 0x000000018D30ED20-0x000000018D30EDEC
		public static IObservable<InputEventPtr> ForDevice<TDevice>(this IObservable<InputEventPtr> source)
			where TDevice : UnityEngine.InputSystem.InputDevice;
		public static IDisposable CallOnce<TValue>(this IObservable<TValue> source, Action<TValue> action);
		public static IDisposable Call<TValue>(this IObservable<TValue> source, Action<TValue> action);
	}

	internal class Observer<TValue> : IObserver<TValue> // TypeDefIndex: 72682
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

	internal class SelectManyObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 72684
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, IEnumerable<TResult>> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 72683
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

	internal class TakeNObservable<TValue> : IObservable<TValue> // TypeDefIndex: 72686
	{
		// Fields
		private IObservable<TValue> m_Source;
		private int m_Count;
	
		// Nested types
		private class Take : IObserver<TValue> // TypeDefIndex: 72685
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

	internal class WhereObservable<TValue> : IObservable<TValue> // TypeDefIndex: 72688
	{
		// Fields
		private readonly IObservable<TValue> m_Source;
		private readonly Func<TValue, bool> m_Predicate;
	
		// Nested types
		private class Where : IObserver<TValue> // TypeDefIndex: 72687
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

	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue> // TypeDefIndex: 72690
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
		private class Enumerator : IEnumerator<TValue> // TypeDefIndex: 72689
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

	internal struct PredictiveParser // TypeDefIndex: 72691
	{
		// Fields
		private int m_Position; // 0x00
	
		// Methods
		public void ExpectSingleChar(ReadOnlySpan<char> str, char c); // 0x0000000185BC6C70-0x0000000185BC6CB0
		public int ExpectInt(ReadOnlySpan<char> str); // 0x0000000185BC6BD0-0x0000000185BC6C70
		public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str); // 0x00000001850C0C30-0x00000001850C0D40
		public bool AcceptSingleChar(ReadOnlySpan<char> str, char c); // 0x0000000185BC6CB0-0x0000000185BC6CE0
		public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output); // 0x0000000185BC6AB0-0x0000000185BC6B80
		public void AcceptInt(ReadOnlySpan<char> str); // 0x0000000185BC6B80-0x0000000185BC6BD0
	}

	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible // TypeDefIndex: 72692
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
		internal unsafe byte* valuePtr { get; } // 0x0000000187259D60-0x0000000187259D70 
		public TypeCode type { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public bool isEmpty { get; } // 0x0000000186535F00-0x0000000186535F10 
	
		// Constructors
		public PrimitiveValue(bool value); // 0x0000000187259CC0-0x0000000187259CD0
		public PrimitiveValue(char value); // 0x0000000187259C20-0x0000000187259C40
		public PrimitiveValue(byte value); // 0x0000000187259CF0-0x0000000187259D00
		public PrimitiveValue(sbyte value); // 0x0000000187259C10-0x0000000187259C20
		public PrimitiveValue(short value); // 0x0000000187259CA0-0x0000000187259CC0
		public PrimitiveValue(ushort value); // 0x0000000187259D40-0x0000000187259D60
		public PrimitiveValue(int value); // 0x0000000187259D20-0x0000000187259D40
		public PrimitiveValue(uint value); // 0x0000000187259D00-0x0000000187259D20
		public PrimitiveValue(long value); // 0x0000000187259C80-0x0000000187259CA0
		public PrimitiveValue(ulong value); // 0x0000000187259C60-0x0000000187259C80
		public PrimitiveValue(float value); // 0x0000000187259C40-0x0000000187259C60
		public PrimitiveValue(double value); // 0x0000000187259CD0-0x0000000187259CF0
	
		// Methods
		public PrimitiveValue ConvertTo(TypeCode type); // 0x000000018D30F2C8-0x000000018D30F554
		public bool Equals(PrimitiveValue other); // 0x000000018D30F554-0x000000018D30F580
		public override bool Equals(object obj); // 0x000000018D30F580-0x000000018D30F730
		public static bool operator ==(PrimitiveValue left, PrimitiveValue right); // 0x000000018D3107D8-0x000000018D3107F8
		public static bool operator !=(PrimitiveValue left, PrimitiveValue right); // 0x000000018D3107F8-0x000000018D310818
		public override int GetHashCode(); // 0x000000018D30FF10-0x000000018D30FF30
		public override string ToString(); // 0x000000018D31037C-0x000000018D3106E8
		public static PrimitiveValue FromString(string value); // 0x000000018D30FBBC-0x000000018D30FF10
		public TypeCode GetTypeCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public bool ToBoolean(IFormatProvider provider = null); // 0x000000018D30FF30-0x000000018D310018
		public byte ToByte(IFormatProvider provider = null); // 0x000000018D310018-0x000000018D310020
		public char ToChar(IFormatProvider provider = null); // 0x000000018D310020-0x000000018D31004C
		public System.DateTime ToDateTime(IFormatProvider provider = null); // 0x000000018D31004C-0x000000018D3100A8
		public decimal ToDecimal(IFormatProvider provider = null); // 0x000000018D3100A8-0x000000018D3100E4
		public double ToDouble(IFormatProvider provider = null); // 0x00000001867F2E60-0x00000001867F2E80
		public short ToInt16(IFormatProvider provider = null); // 0x000000018D310018-0x000000018D310020
		public int ToInt32(IFormatProvider provider = null); // 0x000000018D310018-0x000000018D310020
		public long ToInt64(IFormatProvider provider = null); // 0x000000018D3100E4-0x000000018D310164
		public sbyte ToSByte(IFormatProvider provider = null); // 0x000000018D310018-0x000000018D310020
		public float ToSingle(IFormatProvider provider = null); // 0x000000018783C35C-0x000000018783C374
		public string ToString(IFormatProvider provider); // 0x000000018D3106E8-0x000000018D3106F0
		public object ToType(System.Type conversionType, IFormatProvider provider); // 0x000000018D3106F0-0x000000018D31073C
		public ushort ToUInt16(IFormatProvider provider = null); // 0x000000018D31073C-0x000000018D310748
		public uint ToUInt32(IFormatProvider provider = null); // 0x000000018D31073C-0x000000018D310748
		public ulong ToUInt64(IFormatProvider provider = null); // 0x000000018D310748-0x000000018D3107D8
		public object ToObject(); // 0x000000018D310164-0x000000018D31037C
		public static PrimitiveValue From<TValue>(TValue value)
			where TValue : struct;
		public static PrimitiveValue FromObject(object value); // 0x000000018D30F730-0x000000018D30FBBC
		public static implicit operator PrimitiveValue(bool value); // 0x0000000187259A90-0x0000000187259AB0
		public static implicit operator PrimitiveValue(char value); // 0x0000000187259AD0-0x0000000187259AF0
		public static implicit operator PrimitiveValue(byte value); // 0x0000000187259AB0-0x0000000187259AD0
		public static implicit operator PrimitiveValue(sbyte value); // 0x0000000187259B70-0x0000000187259B90
		public static implicit operator PrimitiveValue(short value); // 0x0000000187259B10-0x0000000187259B30
		public static implicit operator PrimitiveValue(ushort value); // 0x0000000187259BB0-0x0000000187259BD0
		public static implicit operator PrimitiveValue(int value); // 0x0000000187259B30-0x0000000187259B50
		public static implicit operator PrimitiveValue(uint value); // 0x0000000187259BD0-0x0000000187259BF0
		public static implicit operator PrimitiveValue(long value); // 0x0000000187259B50-0x0000000187259B70
		public static implicit operator PrimitiveValue(ulong value); // 0x0000000187259BF0-0x0000000187259C10
		public static implicit operator PrimitiveValue(float value); // 0x0000000187259B90-0x0000000187259BB0
		public static implicit operator PrimitiveValue(double value); // 0x0000000187259AF0-0x0000000187259B10
		public static PrimitiveValue FromBoolean(bool value); // 0x0000000187259A90-0x0000000187259AB0
		public static PrimitiveValue FromChar(char value); // 0x0000000187259AD0-0x0000000187259AF0
		public static PrimitiveValue FromByte(byte value); // 0x0000000187259AB0-0x0000000187259AD0
		public static PrimitiveValue FromSByte(sbyte value); // 0x0000000187259B70-0x0000000187259B90
		public static PrimitiveValue FromInt16(short value); // 0x0000000187259B10-0x0000000187259B30
		public static PrimitiveValue FromUInt16(ushort value); // 0x0000000187259BB0-0x0000000187259BD0
		public static PrimitiveValue FromInt32(int value); // 0x0000000187259B30-0x0000000187259B50
		public static PrimitiveValue FromUInt32(uint value); // 0x0000000187259BD0-0x0000000187259BF0
		public static PrimitiveValue FromInt64(long value); // 0x0000000187259B50-0x0000000187259B70
		public static PrimitiveValue FromUInt64(ulong value); // 0x0000000187259BF0-0x0000000187259C10
		public static PrimitiveValue FromSingle(float value); // 0x0000000187259B90-0x0000000187259BB0
		public static PrimitiveValue FromDouble(double value); // 0x0000000187259AF0-0x0000000187259B10
	}

	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue> // TypeDefIndex: 72694
	{
		// Fields
		internal TValue[] m_Array;
		internal int m_StartIndex;
		internal int m_Length;
	
		// Properties
		public int Count { get; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 72693
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

	public static class ReadOnlyArrayExtensions // TypeDefIndex: 72695
	{
		// Extension methods
		public static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : IComparable<TValue>;
		public static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class;
		public static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class;
		internal static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647 /* Metadata: 0x0262308C */);
	}

	internal interface ISavedState // TypeDefIndex: 72696
	{
		// Methods
		void StaticDisposeCurrentState();
		void RestoreSavedState();
	}

	internal sealed class SavedStructState<T> : ISavedState // TypeDefIndex: 72698
		where T : struct
	{
		// Fields
		private T m_State;
		private TypedRestore m_RestoreAction;
		private Action m_StaticDisposeCurrentState;
	
		// Nested types
		public delegate void TypedRestore(ref ref T state); // TypeDefIndex: 72697; 0x00000000-0x00000000
	
		// Constructors
		internal SavedStructState(ref ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState = null);
	
		// Methods
		public void StaticDisposeCurrentState();
		public void RestoreSavedState();
	}

	internal static class SpriteUtilities // TypeDefIndex: 72699
	{
		// Methods
		public static Sprite CreateCircleSprite(int radius, Color32 colour); // 0x000000018D310818-0x000000018D310A08
	}

	internal static class StringHelpers // TypeDefIndex: 72702
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Tokenize_d__8 : IEnumerable<Substring>, IEnumerator<Substring> // TypeDefIndex: 72700
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
			Substring IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.Current { [DebuggerHidden] get; } // 0x00000001845C28E0-0x00000001845C28F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D313100-0x000000018D313148 
	
			// Constructors
			[DebuggerHidden]
			public _Tokenize_d__8(int __1__state); // 0x0000000188E4A554-0x0000000188E4A570
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D312DE4-0x000000018D313018
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3130B4-0x000000018D313100
			[DebuggerHidden]
			IEnumerator<Substring> IEnumerable<Substring>.GetEnumerator(); // 0x000000018D313018-0x000000018D3130AC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D3130AC-0x000000018D3130B4
		}
	
		[CompilerGenerated]
		private sealed class _Split_d__9 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 72701
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
			string IEnumerator<System.String>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Split_d__9(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D312BE0-0x000000018D312CE8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D312D98-0x000000018D312DE4
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018D312CE8-0x000000018D312D90
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D312D90-0x000000018D312D98
		}
	
		// Methods
		public static string NicifyMemorySize(long numBytes); // 0x000000018D311124-0x000000018D311298
		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1 /* Metadata: 0x026230A5 */); // 0x000000018D310DA8-0x000000018D310F1C
		public static string Join<TValue>(string separator, params TValue[] values);
		public static string Join<TValue>(IEnumerable<TValue> values, string separator);
		public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc);
		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator); // 0x0000000185267510-0x0000000185267780
		public static int ParseInt(string str, int pos); // 0x000000018D311298-0x000000018D31131C
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters); // 0x000000018D3118D8-0x000000018D3118F8
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset); // 0x000000018D311738-0x000000018D3118D8
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize); // 0x000000018D311418-0x000000018D311438
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset); // 0x000000018D31131C-0x000000018D311418
		public static string ExpandTemplateString(string template, Func<string, string> mapFunc); // 0x000000018D310BE8-0x000000018D310DA8
	
		// Extension methods
		public static string Escape(this string str, string chars = "\n\t\r\\\"" /* Metadata: 0x0262308D */, string replacements = "ntr\\\"" /* Metadata: 0x02623093 */); // 0x000000018D310AA8-0x000000018D310BE8
		public static string Unescape(this string str, string chars = "ntr\\\"" /* Metadata: 0x02623099 */, string replacements = "\n\t\r\\\"" /* Metadata: 0x0262309F */); // 0x000000018D311530-0x000000018D31166C
		public static bool Contains(this string str, char ch); // 0x000000018D310A28-0x000000018D310A48
		public static bool Contains(this string str, string text, StringComparison comparison); // 0x000000018D310A08-0x000000018D310A28
		public static string GetPlural(this string str); // 0x000000018D310F1C-0x000000018D311098
		public static int CountOccurrences(this string str, char ch); // 0x000000018D310A48-0x000000018D310AA8
		[IteratorStateMachine(typeof(_Tokenize_d__8))]
		public static IEnumerable<Substring> Tokenize(this string str); // 0x000000018D3114C0-0x000000018D311530
		[IteratorStateMachine(typeof(_Split_d__9))]
		public static IEnumerable<string> Split(this string str, Func<char, bool> predicate); // 0x000000018D311438-0x000000018D3114C0
		public static bool IsPrintable(this char ch); // 0x000000018D3110C0-0x000000018D311124
		public static string WithAllWhitespaceStripped(this string str); // 0x000000018D31166C-0x000000018D311738
		public static bool InvariantEqualsIgnoreCase(this string left, string right); // 0x000000018D311098-0x000000018D3110C0
	}

	internal struct Substring : IComparable<Substring>, IEquatable<Substring> // TypeDefIndex: 72703
	{
		// Fields
		private readonly string m_String; // 0x00
		private readonly int m_Index; // 0x08
		private readonly int m_Length; // 0x0C
	
		// Properties
		public bool isEmpty { get; } // 0x000000018D311D78-0x000000018D311D80 
		public int length { get; } // 0x0000000184431980-0x0000000184431990 
		public int index { get; } // 0x0000000184431A70-0x0000000184431A80 
		public char this[int index] { get => default; } // 0x000000018D311CF8-0x000000018D311D78 
	
		// Constructors
		public Substring(string str); // 0x000000018D311C90-0x000000018D311CC4
		public Substring(string str, int index, int length); // 0x00000001878348F0-0x0000000187834910
		public Substring(string str, int index); // 0x000000018D311CC4-0x000000018D311CF8
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D3119E4-0x000000018D311A7C
		public bool Equals(string other); // 0x000000018D311AA0-0x000000018D311B30
		public bool Equals(Substring other); // 0x000000018D311A7C-0x000000018D311AA0
		public bool Equals(InternedString other); // 0x000000018D311970-0x000000018D3119E4
		public int CompareTo(Substring other); // 0x000000018D3118F8-0x000000018D311928
		public static int Compare(Substring left, Substring right, StringComparison comparison); // 0x000000018D311928-0x000000018D311970
		public bool StartsWith(string str); // 0x000000018D311B80-0x000000018D311C00
		public string Substr(int index = 0 /* Metadata: 0x026230AD */, int length = -1 /* Metadata: 0x026230AE */); // 0x000000018D311C00-0x000000018D311C34
		public override string ToString(); // 0x000000018D311C34-0x000000018D311C90
		public override int GetHashCode(); // 0x000000018D311B30-0x000000018D311B80
		public static bool operator ==(Substring a, Substring b); // 0x000000018D311D80-0x000000018D311DA0
		public static bool operator !=(Substring a, Substring b); // 0x000000018D311E04-0x000000018D311E24
		public static bool operator ==(Substring a, InternedString b); // 0x000000018D311DC4-0x000000018D311DE4
		public static bool operator !=(Substring a, InternedString b); // 0x000000018D311E24-0x000000018D311E44
		public static bool operator ==(InternedString a, Substring b); // 0x000000018D311DA0-0x000000018D311DC4
		public static bool operator !=(InternedString a, Substring b); // 0x000000018D311E44-0x000000018D311E6C
		public static implicit operator Substring(string s); // 0x000000018D311DE4-0x000000018D311E04
	}

	internal static class TypeHelpers // TypeDefIndex: 72704
	{
		// Methods
		public static System.Type GetValueType(MemberInfo member); // 0x000000018D312748-0x000000018D312834
		public static System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex); // 0x000000018D3120A8-0x000000018D3123E4
	
		// Extension methods
		public static TObject As<TObject>(this object obj);
		public static bool IsInt(this TypeCode type); // 0x000000018D312834-0x000000018D312864
		public static string GetNiceTypeName(this System.Type type); // 0x000000018D3123E4-0x000000018D312748
	}

	internal struct TypeTable // TypeDefIndex: 72706
	{
		// Fields
		public Dictionary<InternedString, System.Type> table; // 0x00
	
		// Properties
		public IEnumerable<string> names { get; } // 0x000000018D312AB0-0x000000018D312BE0 
		public IEnumerable<InternedString> internedNames { get; } // 0x000000018D312A6C-0x000000018D312AB0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72705
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InternedString, string> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D31328C-0x000000018D3132F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _get_names_b__2_0(InternedString x); // 0x000000018D313214-0x000000018D313228
		}
	
		// Methods
		public void Initialize(); // 0x0000000185B0A1B0-0x0000000185B0A230
		public InternedString FindNameForType(System.Type type); // 0x000000018D312864-0x000000018D312A6C
		public void AddTypeRegistration(string name, System.Type type); // 0x0000000185B0A0E0-0x0000000185B0A1B0
		public System.Type LookupTypeRegistration(string name); // 0x0000000186317A40-0x0000000186317AF0
	}
}

namespace UnityEngine.InputSystem.XInput
{
	public interface IXboxOneRumble : IDualMotorRumble // TypeDefIndex: 72337
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
	}

	[InputControlLayout(displayName = "Xbox Controller")]
	public class XInputController : Gamepad // TypeDefIndex: 72342
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
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		public ButtonControl view { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		public DeviceSubType subType { get; } // 0x000000018D3685B0-0x000000018D3685E0 
		public DeviceFlags flags { get; } // 0x000000018D368580-0x000000018D3685B0 
	
		// Nested types
		internal enum DeviceType // TypeDefIndex: 72338
		{
			Gamepad = 0
		}
	
		public enum DeviceSubType // TypeDefIndex: 72339
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
		public enum DeviceFlags // TypeDefIndex: 72340
		{
			ForceFeedbackSupported = 1,
			Wireless = 2,
			VoiceSupported = 4,
			PluginModulesSupported = 8,
			NoNavigation = 16
		}
	
		[Serializable]
		internal struct Capabilities // TypeDefIndex: 72341
		{
			// Fields
			public UnityEngine.InputSystem.XInput.XInputController.DeviceType type; // 0x00
			public DeviceSubType subType; // 0x04
			public DeviceFlags flags; // 0x08
		}
	
		// Constructors
		public XInputController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3684A4-0x000000018D3684F0
		private void ParseCapabilities(); // 0x000000018D3684F0-0x000000018D368580
	}

	[InputControlLayout(stateType = typeof(XInputControllerWindowsState), hideInUI = true)]
	public class XInputControllerWindows : XInputController // TypeDefIndex: 72343
	{
		// Constructors
		public XInputControllerWindows(); // 0x000000018D2E1E18-0x000000018D2E1E20
	}

	internal static class XInputSupport // TypeDefIndex: 72344
	{
		// Methods
		public static void Initialize(); // 0x0000000185B0AE50-0x0000000185B0AF60
	}
}

namespace UnityEngine.InputSystem.XInput.LowLevel
{
	internal struct XInputControllerWindowsState : IInputStateTypeInfo // TypeDefIndex: 72346
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
		public FourCC format { get; } // 0x000000018725A100-0x000000018725A110 
	
		// Nested types
		public enum Button // TypeDefIndex: 72345
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
		public XInputControllerWindowsState WithButton(Button button); // 0x000000018725A0D0-0x000000018725A100
	}
}

namespace UnityEngine.InputSystem.XR
{
	public struct PoseState : IInputStateTypeInfo // TypeDefIndex: 72308
	{
		// Fields
		internal const int kSizeInBytes = 60; // Metadata: 0x02622C54
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
		public FourCC format { get; } // 0x000000018D363D3C-0x000000018D363D8C 
	
		// Constructors
		public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity); // 0x000000018725A020-0x000000018725A070
		static PoseState(); // 0x000000018D363D00-0x000000018D363D3C
	}

	[InputControlLayout(stateType = typeof(PoseState))]
	[UnityEngine.Scripting.Preserve]
	public class PoseControl : InputControl<PoseState> // TypeDefIndex: 72309
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
		public ButtonControl isTracked { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BA40-0x000000018723BA50 0x0000000188DC4DCC-0x0000000188DC4DE0
		public IntegerControl trackingState { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C0D0-0x000000018723C0E0 0x0000000188DC4B88-0x0000000188DC4B9C
		public Vector3Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B990-0x000000018723B9A0 0x0000000188DC473C-0x0000000188DC4750
		public QuaternionControl rotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
		public Vector3Control velocity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		public Vector3Control angularVelocity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
	
		// Constructors
		public PoseControl(); // 0x000000018D363C7C-0x000000018D363D00
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D363700-0x000000018D3638AC
		public override unsafe PoseState ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D3638AC-0x000000018D363AA4
		public override unsafe void WriteValueIntoState(PoseState value, void* statePtr); // 0x000000018D363AA4-0x000000018D363C7C
		protected override FourCC CalculateOptimizedControlDataType(); // 0x000000018D3634D4-0x000000018D363700
	}

	[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR HMD", canRunInBackground = true)]
	public class XRHMD : TrackedDevice // TypeDefIndex: 72310
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
		public Vector3Control leftEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(noisy = true)]
		public QuaternionControl leftEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl(noisy = true)]
		public Vector3Control rightEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(noisy = true)]
		public QuaternionControl rightEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl(noisy = true)]
		public Vector3Control centerEyePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl(noisy = true)]
		public QuaternionControl centerEyeRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
	
		// Constructors
		public XRHMD(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3688A0-0x000000018D368A20
	}

	[InputControlLayout(commonUsages = new string[2] {"LeftHand", "RightHand" }, isGenericTypeOfDevice = true, displayName = "XR Controller")]
	public class XRController : TrackedDevice // TypeDefIndex: 72311
	{
		// Properties
		public static XRController leftHand { get; } // 0x000000018D36875C-0x000000018D3687E0 
		public static XRController rightHand { get; } // 0x000000018D3687E0-0x000000018D368864 
	
		// Constructors
		public XRController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D368674-0x000000018D36875C
	}

	public class XRControllerWithRumble : XRController // TypeDefIndex: 72312
	{
		// Constructors
		public XRControllerWithRumble(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		public void SendImpulse(float amplitude, float duration); // 0x000000018D3685E0-0x000000018D368674
	}

	[Serializable]
	[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
	public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 72316
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
		public TrackingType trackingType { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public UpdateType updateType { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public bool ignoreTrackingState { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public InputActionProperty positionInput { get; set; } // 0x000000018724AF20-0x000000018724AF40 0x000000018D36558C-0x000000018D3655FC
		public InputActionProperty rotationInput { get; set; } // 0x00000001872353C0-0x00000001872353E0 0x000000018D365650-0x000000018D3656C0
		public InputActionProperty trackingStateInput { get; set; } // 0x000000018723CEB0-0x000000018723CED0 0x000000018D3656C0-0x000000018D365730
		public InputAction positionAction { get; set; } // 0x000000018D365520-0x000000018D36552C 0x000000018D365538-0x000000018D36558C
		public InputAction rotationAction { get; set; } // 0x000000018D36552C-0x000000018D365538 0x000000018D3655FC-0x000000018D365650
	
		// Nested types
		public enum TrackingType // TypeDefIndex: 72313
		{
			RotationAndPosition = 0,
			RotationOnly = 1,
			PositionOnly = 2
		}
	
		[Flags]
		private enum TrackingStates // TypeDefIndex: 72314
		{
			None = 0,
			Position = 1,
			Rotation = 2
		}
	
		public enum UpdateType // TypeDefIndex: 72315
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}
	
		// Constructors
		public TrackedPoseDriver(); // 0x000000018D3654C8-0x000000018D365520
	
		// Methods
		private void BindActions(); // 0x000000018D364174-0x000000018D3641A0
		private void UnbindActions(); // 0x000000018D364EAC-0x000000018D364ED8
		private void BindPosition(); // 0x000000018D3641A0-0x000000018D36431C
		private void BindRotation(); // 0x000000018D36431C-0x000000018D364498
		private void BindTrackingState(); // 0x000000018D364498-0x000000018D364614
		private static void RenameAndEnable(InputAction action, string name); // 0x000000018D364AF0-0x000000018D364B1C
		private void UnbindPosition(); // 0x000000018D364ED8-0x000000018D365010
		private void UnbindRotation(); // 0x000000018D365010-0x000000018D365148
		private void UnbindTrackingState(); // 0x000000018D365148-0x000000018D365280
		private void OnPositionPerformed(InputAction.CallbackContext context); // 0x000000018D3648B0-0x000000018D364910
		private void OnPositionCanceled(InputAction.CallbackContext context); // 0x000000018D36489C-0x000000018D3648B0
		private void OnRotationPerformed(InputAction.CallbackContext context); // 0x000000018D364930-0x000000018D364984
		private void OnRotationCanceled(InputAction.CallbackContext context); // 0x000000018D364910-0x000000018D364930
		private void OnTrackingStatePerformed(InputAction.CallbackContext context); // 0x000000018D364984-0x000000018D3649D0
		private void OnTrackingStateCanceled(InputAction.CallbackContext context); // 0x000000018725A0C0-0x000000018725A0D0
		protected void Reset(); // 0x000000018D364B1C-0x000000018D364D58
		protected virtual void Awake(); // 0x000000018D364140-0x000000018D364174
		protected void OnEnable(); // 0x000000018D3647F8-0x000000018D36489C
		protected void OnDisable(); // 0x000000018D36475C-0x000000018D3647F8
		protected virtual void OnDestroy(); // 0x000000018D364728-0x000000018D36475C
		protected void UpdateCallback(); // 0x000000018D365340-0x000000018D3654C8
		private void ReadTrackingState(bool hasResolvedPositionInputControl, bool hasResolvedRotationInputControl); // 0x000000018D364A1C-0x000000018D364AF0
		protected virtual void OnUpdate(); // 0x000000018D3649D0-0x000000018D3649E4
		protected virtual void OnBeforeRender(); // 0x000000018D364714-0x000000018D364728
		protected virtual void PerformUpdate(); // 0x000000018D3649E4-0x000000018D364A1C
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation); // 0x000000018D364D58-0x000000018D364EAC
		private bool HasStereoCamera(out Camera cameraComponent); // 0x000000018D3646B0-0x000000018D364714
		private static bool HasResolvedControl(InputAction action); // 0x000000018D364614-0x000000018D3646B0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018D365280-0x000000018D365340
	}

	internal class XRLayoutBuilder // TypeDefIndex: 72318
	{
		// Fields
		private string parentLayout; // 0x10
		private string interfaceName; // 0x18
		private XRDeviceDescriptor descriptor; // 0x20
		private static readonly string[] poseSubControlNames; // 0x00
		private static readonly FeatureType[] poseSubControlTypes; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 72317
		{
			// Fields
			public XRLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0(); // 0x000000018D3669BC-0x000000018D3669DC
		}
	
		// Constructors
		public XRLayoutBuilder(); // 0x0000000186805BA0-0x0000000186805BB0
		static XRLayoutBuilder(); // 0x000000018D369C58-0x000000018D36A2E4
	
		// Methods
		private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor); // 0x000000018D36991C-0x000000018D3699B0
		private static string SanitizeString(string original, bool allowPaths = false /* Metadata: 0x02622C5E */); // 0x000000018D369B24-0x000000018D369C58
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate); // 0x0000000186315AB0-0x0000000186315BF0
		private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias); // 0x000000018D36976C-0x000000018D3698E0
		private bool IsSubControl(string name); // 0x000000018D369AFC-0x000000018D369B24
		private string GetParentControlName(string name); // 0x000000018D3698E0-0x000000018D36991C
		private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex); // 0x000000018D3699B0-0x000000018D369AFC
		private InputControlLayout Build(); // 0x000000018D368A20-0x000000018D36976C
	}

	public static class XRUtilities // TypeDefIndex: 72319
	{
		// Fields
		public const string InterfaceMatchAnyVersion = "^(XRInput)"; // Metadata: 0x02622C5F
		public const string InterfaceV1 = "XRInput"; // Metadata: 0x02622C6A
		public const string InterfaceCurrent = "XRInputV1"; // Metadata: 0x02622C72
	}

	public enum FeatureType // TypeDefIndex: 72320
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
	public struct UsageHint // TypeDefIndex: 72321
	{
		// Fields
		public string content; // 0x00
	}

	[Serializable]
	public struct XRFeatureDescriptor // TypeDefIndex: 72322
	{
		// Fields
		public string name; // 0x00
		public List<UsageHint> usageHints; // 0x08
		public FeatureType featureType; // 0x10
		public uint customSize; // 0x14
	}

	[Serializable]
	public class XRDeviceDescriptor // TypeDefIndex: 72323
	{
		// Fields
		public string deviceName; // 0x10
		public string manufacturer; // 0x18
		public string serialNumber; // 0x20
		public InputDeviceCharacteristics characteristics; // 0x28
		public int deviceId; // 0x2C
		public List<XRFeatureDescriptor> inputFeatures; // 0x30
	
		// Constructors
		public XRDeviceDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public string ToJson(); // 0x000000018783B884-0x000000018783B890
		public static XRDeviceDescriptor FromJson(string json); // 0x000000018D368864-0x000000018D3688A0
	}

	public struct Bone // TypeDefIndex: 72324
	{
		// Fields
		public uint m_ParentBoneIndex; // 0x00
		public Vector3 m_Position; // 0x04
		public Quaternion m_Rotation; // 0x10
	
		// Properties
		public uint parentBoneIndex { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public Vector3 position { get; set; } // 0x000000018724A6B0-0x000000018724A6D0 0x0000000187259ED0-0x0000000187259EE0
		public Quaternion rotation { get; set; } // 0x0000000184430480-0x0000000184430490 0x0000000187239680-0x0000000187239690
	}

	public struct Eyes // TypeDefIndex: 72325
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
		public Vector3 leftEyePosition { get; set; } // 0x000000018723AE60-0x000000018723AE80 0x000000018723AEB0-0x000000018723AEC0
		public Quaternion leftEyeRotation { get; set; } // 0x0000000187259EF0-0x0000000187259F00 0x0000000187259F00-0x0000000187259F10
		public Vector3 rightEyePosition { get; set; } // 0x000000018723E2B0-0x000000018723E2D0 0x000000018723E2A0-0x000000018723E2B0
		public Quaternion rightEyeRotation { get; set; } // 0x000000018723D770-0x000000018723D780 0x000000018723D780-0x000000018723D790
		public Vector3 fixationPoint { get; set; } // 0x000000018724C790-0x000000018724C7B0 0x000000018724BD80-0x000000018724BD90
		public float leftEyeOpenAmount { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public float rightEyeOpenAmount { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	}

	public class BoneControl : InputControl<UnityEngine.InputSystem.XR.Bone> // TypeDefIndex: 72326
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
		public IntegerControl parentBoneIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE50-0x000000018723BE60 0x0000000188DC478C-0x0000000188DC47A0
		[InputControl(offset = 4, displayName = "Position")]
		public Vector3Control position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BEA0-0x000000018723BEB0 0x0000000188DC4804-0x0000000188DC4818
		[InputControl(offset = 16, displayName = "Rotation")]
		public QuaternionControl rotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BD10-0x000000018723BD20 0x0000000188DC4570-0x0000000188DC4584
	
		// Constructors
		public BoneControl(); // 0x000000018D35275C-0x000000018D352790
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3524F4-0x000000018D3525F0
		public override unsafe UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D3525F0-0x000000018D3526C8
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr); // 0x000000018D3526C8-0x000000018D35275C
	}

	public class EyesControl : InputControl<UnityEngine.InputSystem.XR.Eyes> // TypeDefIndex: 72327
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
		public Vector3Control leftEyePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
		[InputControl(offset = 12, displayName = "LeftEyeRotation")]
		public QuaternionControl leftEyeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		[InputControl(offset = 28, displayName = "RightEyePosition")]
		public Vector3Control rightEyePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		[InputControl(offset = 40, displayName = "RightEyeRotation")]
		public QuaternionControl rightEyeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(offset = 56, displayName = "FixationPoint")]
		public Vector3Control fixationPoint { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
		public AxisControl leftEyeOpenAmount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
		public AxisControl rightEyeOpenAmount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
	
		// Constructors
		public EyesControl(); // 0x000000018D35392C-0x000000018D353960
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D3534A4-0x000000018D353678
		public override unsafe UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr); // 0x000000018D353678-0x000000018D3537F4
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr); // 0x000000018D3537F4-0x000000018D35392C
	}

	internal static class XRSupport // TypeDefIndex: 72328
	{
		// Methods
		public static void Initialize(); // 0x0000000185B0BC30-0x0000000185B0C7C0
	}
}

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct BufferedRumble // TypeDefIndex: 72329
	{
		// Fields
		[CompilerGenerated]
		private HapticCapabilities _capabilities_k__BackingField; // 0x00
		[CompilerGenerated]
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x18
	
		// Properties
		public HapticCapabilities capabilities { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001872415B0-0x00000001872415C0 0x0000000187235B60-0x0000000187235B70
		private UnityEngine.InputSystem.InputDevice device { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public BufferedRumble(UnityEngine.InputSystem.InputDevice device); // 0x000000018D352874-0x000000018D35297C
	
		// Methods
		public void EnqueueRumble(byte[] samples); // 0x000000018D352790-0x000000018D352874
	}

	public struct HapticState // TypeDefIndex: 72330
	{
		// Fields
		[CompilerGenerated]
		private uint _samplesQueued_k__BackingField; // 0x00
		[CompilerGenerated]
		private uint _samplesAvailable_k__BackingField; // 0x04
	
		// Properties
		public uint samplesQueued { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public uint samplesAvailable { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
	
		// Constructors
		public HapticState(uint samplesQueued, uint samplesAvailable); // 0x00000001827241A0-0x00000001827241B0
	}

	public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 72331
	{
		// Fields
		private const int kSize = 16; // Metadata: 0x02622C86
		private InputDeviceCommand baseCommand; // 0x00
		public uint samplesQueued; // 0x08
		public uint samplesAvailable; // 0x0C
	
		// Properties
		private static FourCC Type { get; } // 0x0000000187259F40-0x0000000187259F50 
		public FourCC typeStatic { get; } // 0x0000000187259F40-0x0000000187259F50 
		public HapticState currentState { get; } // 0x0000000187259F50-0x0000000187259F70 
	
		// Methods
		public static GetCurrentHapticStateCommand Create(); // 0x0000000187259F10-0x0000000187259F40
	}

	public struct HapticCapabilities // TypeDefIndex: 72332
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
		public uint numChannels { [IsReadOnly] [CompilerGenerated] get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public bool supportsImpulse { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187239BC0-0x0000000187239BD0 
		public bool supportsBuffer { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187239BD0-0x0000000187239BE0 
		public uint frequencyHz { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
		public uint maxBufferSize { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431980-0x0000000184431990 
		public uint optimalBufferSize { [IsReadOnly] [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize); // 0x000000018725A000-0x000000018725A020
		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize); // 0x0000000187259FE0-0x000000018725A000
	}

	public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo // TypeDefIndex: 72333
	{
		// Fields
		private const int kSize = 28; // Metadata: 0x02622C87
		private InputDeviceCommand baseCommand; // 0x00
		public uint numChannels; // 0x08
		public bool supportsImpulse; // 0x0C
		public bool supportsBuffer; // 0x0D
		public uint frequencyHz; // 0x10
		public uint maxBufferSize; // 0x14
		public uint optimalBufferSize; // 0x18
	
		// Properties
		private static FourCC Type { get; } // 0x0000000187259FA0-0x0000000187259FB0 
		public FourCC typeStatic { get; } // 0x0000000187259FA0-0x0000000187259FB0 
		public HapticCapabilities capabilities { get; } // 0x0000000187259FB0-0x0000000187259FE0 
	
		// Methods
		public static GetHapticCapabilitiesCommand Create(); // 0x0000000187259F70-0x0000000187259FA0
	}

	public struct SendBufferedHapticCommand : IInputDeviceCommandInfo // TypeDefIndex: 72335
	{
		// Fields
		private const int kMaxHapticBufferSize = 1024; // Metadata: 0x02622C88
		private const int kSize = 1040; // Metadata: 0x02622C8A
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private int bufferSize; // 0x0C
		private unsafe fixed /* 0x00000000-0x00000000 */ byte buffer[0]; // 0x10
	
		// Properties
		private static FourCC Type { get; } // 0x000000018725A070-0x000000018725A080 
		public FourCC typeStatic { get; } // 0x000000018725A070-0x000000018725A080 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 72334
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static SendBufferedHapticCommand Create(byte[] rumbleBuffer); // 0x000000018D363D8C-0x000000018D363EFC
	}

	public struct SendHapticImpulseCommand : IInputDeviceCommandInfo // TypeDefIndex: 72336
	{
		// Fields
		private const int kSize = 20; // Metadata: 0x02622C8C
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private float amplitude; // 0x0C
		private float duration; // 0x10
	
		// Properties
		private static FourCC Type { get; } // 0x000000018725A0B0-0x000000018725A0C0 
		public FourCC typeStatic { get; } // 0x000000018725A0B0-0x000000018725A0C0 
	
		// Methods
		public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration); // 0x000000018725A080-0x000000018725A0B0
	}
}

namespace UnityEngine.XR.WindowsMR.Input
{
	[InputControlLayout(displayName = "Windows MR Headset", hideInUI = true)]
	public class WMRHMD : XRHMD // TypeDefIndex: 72103
	{
		// Fields
		[CompilerGenerated]
		private ButtonControl _userPresence_k__BackingField; // 0x1E0
	
		// Properties
		[InputControl]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"HeadRotation" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"HeadPosition" })]
		public ButtonControl userPresence { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
	
		// Constructors
		public WMRHMD(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2F3318-0x000000018D2F3384
	}

	[InputControlLayout(displayName = "HoloLens Hand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HololensHand : XRController // TypeDefIndex: 72104
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
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl airTap { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
	
		// Constructors
		public HololensHand(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2E23B4-0x000000018D2E24D4
	}

	[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class WMRSpatialController : XRControllerWithRumble // TypeDefIndex: 72105
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
		public Vector2Control joystick { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD90-0x000000018723BDA0 0x0000000188DC4624-0x0000000188DC4638
		[InputControl(aliases = new string[2] {"Secondary2DAxis", "touchpadaxes" })]
		public Vector2Control touchpad { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		[InputControl(aliases = new string[1] {"gripaxis" })]
		public AxisControl grip { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE70-0x000000018723BE80 0x0000000188DC47B4-0x0000000188DC47C8
		[InputControl(aliases = new string[1] {"gripbutton" })]
		public ButtonControl gripPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		[InputControl(aliases = new string[2] {"Primary", "menubutton" })]
		public ButtonControl menu { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		[InputControl(aliases = new string[1] {"triggeraxis" })]
		public AxisControl trigger { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BCA0-0x000000018723BCB0 0x0000000188DC4494-0x0000000188DC44A8
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl triggerPressed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD70-0x000000018723BD80 0x0000000188DC45E8-0x0000000188DC45FC
		[InputControl(aliases = new string[1] {"thumbstickpressed" })]
		public ButtonControl joystickClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
		[InputControl(aliases = new string[2] {"joystickorpadpressed", "touchpadpressed" })]
		public ButtonControl touchpadClicked { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B380-0x000000018723B390 0x0000000188D42B54-0x0000000188D42B68
		[InputControl(aliases = new string[2] {"joystickorpadtouched", "touchpadtouched" })]
		public ButtonControl touchpadTouched { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872347A0-0x00000001872347B0 0x0000000188DC46EC-0x0000000188DC4700
		[InputControl(noisy = true, aliases = new string[1] {"gripVelocity" })]
		public Vector3Control deviceVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BE40-0x000000018723BE50 0x0000000188DC4764-0x0000000188DC4778
		[InputControl(noisy = true, aliases = new string[1] {"gripAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234920-0x0000000187234930 0x0000000188A865D0-0x0000000188A865E4
		[InputControl(noisy = true)]
		public AxisControl batteryLevel { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723BD00-0x000000018723BD10 0x0000000188DC4534-0x0000000188DC4548
		[InputControl(noisy = true)]
		public Vector3Control pointerPosition { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B240-0x000000018723B250 0x0000000188DC455C-0x0000000188DC4570
		[InputControl(noisy = true, aliases = new string[1] {"PointerOrientation" })]
		public QuaternionControl pointerRotation { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B310-0x000000018723B320 0x0000000188D3C0D0-0x0000000188D3C0E4
	
		// Constructors
		public WMRSpatialController(); // 0x000000018D2E1E18-0x000000018D2E1E20
	
		// Methods
		protected override void FinishSetup(); // 0x000000018D2F3384-0x000000018D2F3774
	}
}
