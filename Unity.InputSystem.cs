/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.HID;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Switch.LowLevel;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.XR;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngineInternal.Input;

// Image 11: Unity.InputSystem.dll - Assembly: Unity.InputSystem, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 44992-45638

internal static class UISupport // TypeDefIndex: 44993
{
	// Methods
	public static void Initialize() {} // 0x0000000184D54F50-0x0000000184D54FC0
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 45638
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_262 _1D0F855A98F398E261D1E4C657C33BD47F11A47FD9CF90F160D467BC8C7FEBE3; // 0x00 // Static value (base64): AAAAAAEAAgADAAQABQAGAAcACAAJAAoACwAMAA0ADgAPABAAEQASABMAFAAVABYAFwAYABkAGgAbABwAHQAeAB8AIAAhACIAIwAkACUAJgAnACgAKQAqACsALAAtAC4ALwAwADEAMgAzADQANQA2ADcAOAA5ADoAOgA7ADwAPQA9AD4APwBAAEAAQQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBXAFgAWQBaAFsAXABdAF4AXwBgAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegB7AHwAfQB+AA== - Metadata: 0x0205C2CC
	internal static readonly __StaticArrayInitTypeSize_508 _1E9B4B805C18CBD7D7326E392008A12FBD20465C53E9C60AEBEA427165641632; // 0x106 // Static value (base64): AgQIAADsCQADBBAABAQYAAUEIAAGBCgABwQwAAgEOAAJBEAACgRIAAsEUAAMBFgADQRgAA4EaAAPBHAAFAR4ABUEgAAWBIgAFwSQABgEmAAZBKAAGgSoABsEsAAcBLgAHQTAAB4EyAAfBNAAIATYACEE4AAiBOgAIwTwACQE+AAlBAABJgQIAScEEAEoBBgBKQQgASoEKAErBDABLAQ4AS0EQAEuBEgBLwRQATAEWAExBGABMgRoATMEcAE0BHgBNQSAATYEiAE3BJABOASYAToImAE5BKABOwSoAT0IqAE8BLABPgS4AUAIuAE/BMABQQTIAUIE0AFDBNgBAQTgARIE6AETBPABEAT4AREEAAJEBAgCRQQQAkYEGAJHBCACSAQoAkkEMAJKBDgCSwRAAkwESAJNBFACTgRYAk8EYAJQBGgCUQRwAlIEeAJTBIACVASIAlUEkAJWBJgCYASgAlcEqAJYBLACWQS4AloEwAJbBMgCXATQAl0E2AJeBOACXwToAmEE8AJiBPgCYwQAA2QECANlBBADZgQYA2cEIANoBCgDaQQwA2oEOANrBEADbARIA20EUANuBFgDbwRgA3AEaANxBHADcgSAA3MEiAN0BJADdQSYA3YEoAN3BKgDeASwA3kEuAN6BMADewTIA3wE0AN9BNgDfgT4Aw== - Metadata: 0x0205C3D4
	internal static readonly __StaticArrayInitTypeSize_976 _286DD866DF46AD63DA3C6198BE2F9CDB96A5223055FDC3E0287B7CCA9F45AFB4; // 0x302 // Static value (base64): EYAAAB6AAAEqgAABH4AAAiuAAAIigAADI4AAAySAAAMugAADL4AAAzCAAAMggAAEIYAABCWAAAQsgAAELYAABDGAAAQDgAAFFIAABSaAAAYygAAGJ4AABzOAAAcFIAAIFiAACBcgAAgYIEAIBiCACBkggAgaBMAIGwTgCBwAAQoogAAMKYAADTSAAA5BgAAPQoAAEEWAABFGgAARR4AAEUOAABJEgAASSIAAEjeAABNJgAAUSoAAFTkgABY6IAAWOyBAFjwggBY9BMAWPgTgFj8AARhLgAAaTIAAG02AABxagAAdW4AAHl6AAB9fgAAfYIAAH1yAACBdgAAgYYAAIFCAACFigAAiY4AAI1IgACRTIAAkVCBAJFUggCRWBMAkVwTgJFgAASZkgAAoZYAAKWaAACpzgAArdIAALHeAAC14gAAteYAALXWAAC52gAAueoAALmmAAC97gAAwfIAAMWsgADJsIAAybSBAMm4ggDJvBMAycATgMnEAATR9gAA2foAAN3+AADiMgAA5jYAAOpCAADuRgAA7koAAO46AADyPgAA8k4AAPIKAAD2UgAA+lYAAP4QgAECFIABAhiBAQIcggECIBMBAiQTgQIoAAUKWgABEl4AARZiAAEalgABHpoAASKmAAEmqgABJq4AASaeAAEqogABKrIAASpuAAEutgABMroAATZ0gAE6eIABOnyBATqAggE6hBMBOogTgTqMAAVCvgABSsIAAU7GAAFS+gABVv4AAVsKAAFfDgABXxIAAV8CAAFjBgABYxYAAWLSAAFnGgABax4AAW7YgAFy3IABcuCBAXLkggFy6BMBcuwTgXLwAAV7IgABgyYAAYcqAAGLXgABj2IAAZNuAAGXcgABl3YAAZdmAAGbagABm3oAAZs2AAGffgABo4IAAac8gAGrQIABq0SBAatIggGrTBMBq1ATgatUAAWzhgABu4oAAb+OAAHDwgABx8YAAcvSAAHP1gABz9oAAc/KAAHTzgAB094AAdOaAAHX4gAB2+YAAd+ggAHjpIAB46iBAeOsggHjsBMB47QTgeO4AAXr6gAB8+4AAffyAAH4JgQB/CoEAgA2BAIEOgQCBD4EAgQuBAIIMgQCCEIEAgv+AAIMRgQCEEoEAhQEhAIYCIQCGAyFAhgQhgIYFBcCGBgXghgcBAYgTgQCKFIEAixWBAIwigQCNI4EAjiaBAI8ngQCPKIEAjySBAJAlgQCQKYEAkBiBAJEqgQCSK4EAkxohAJQbIQCUHCFAlB0hgJQeBcCUHwXglCABAZYsgQCYLYEAmQ== - Metadata: 0x0205C5D4
	internal static readonly __StaticArrayInitTypeSize_20 _7BD1B2B340030CA32C0F7873A8B4949D42124F6206A455BA2860B27C103E8261; // 0x6D2 // Static value (base64): AQAAAAIAAAADAAAAAgAAAAQAAAA= - Metadata: 0x0205C9AC
	internal static readonly __StaticArrayInitTypeSize_371 BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B; // 0x6E6 // Static value (base64): hwEBAAAAAMQAAwAAAACHARcAAAAAgAAFAAAAAMQACwAAAABAAAcAAAABgAAJAAMAASAA//8BAAFAAP//AgABYAD//wcAA4AA//8EAAPBAA0AAAAAxAATAAAAAKEADwAKAATBABEADgAEkQD//xIAA6EA//8VAAPAAP//AAAAwQD//xgAAsMAFQAAAADEAP//HAABwgD//xoAAcMA//8bAAEgARkAAAAAhwEpAAAAAPAAGwAAAAAgAScAAAAA4AAdAAAAAPAA//8pAAHSAB8AJwAB4AD//ygAAcsAIQAAAADSAP//AAAAyAAjAAAAAMsA//8AAADGACUAAAAAyAD//wAAAMUA//8dAAHGAP//AAAACAH//x4AASAB//8fAAGAASsAAAAAhwEvAAAAAFAB//8gAAKAAS0AIgACaAH//yQAAYAB//8lAAGEATEAAAAAhwH//wAAAIIBMwAAAACEAf//AAAAgQH//yYAAYIB//8AAAA= - Metadata: 0x0205C9C4
	internal static readonly __StaticArrayInitTypeSize_3983 CB22D97D4BE9F7A4259E5E355F9F66F2C2D11559A9EA0634CFF23EAA93DA62AE; // 0x859 // Static value (base64): PxMBAAAAAMAIAwAAAAA/EwEBAAAAgAMFAAAAAMAIZwAAAADAAQcAAAABgAM1AEQAAcAACQAAAADAARUAAAAAYAALAAAAAMAADwAAAAAgAP//AQABYAANAAIAAkAA//8EAAJgAP//BgACkAARAAgACMAAEwAQAAh4AP//GAAGkAD//x4ABqgA//8kAALAAP//JgACHQEXAAAAAMABLwAAAAAIARkAAAAAHQEjAAAAAOQAGwAoAAQIAR0ALAAE0gD//zAAAuQA//8yAAL2AP//AAAACAEfAAAAAP8A//8AAAAIASEAAAAABAH//zQAAwgB//83AAMYASUAAAAAHQEnAAAAABAB//86AAEYAf//OwACGwEpAAAAAB0BLQAAAAAaASsAAAAAGwH//wAAABkB//89AAEaAf//AAAAHAH//wAAAB0B//8+AAGAATEAAAAAwAEzAEEAAU8B//8/AAGAAf//QAABoAH//0IAAcAB//9DAAGgAjcAXAABgANHAF0AATACOQBNAASgAkEAUQAE+AE7AEcAAjACPQBJAALcAf//RQAB+AH//0YAASACPwAAAAAwAv//AAAADAL//0sAASAC//9MAAFgAkMAAAAAoAJFAAAAAEgC//9VAANgAv//WAADgAL//1sAAaAC//9eAAEQA0kAaQABgANjAGoAAdgCSwAAAAAQA1MAAAAAvAL//18AAdgCTQBgAAHIAk8AAAAA2AJRAAAAAMIC//9hAALIAv//YwAC0AL//2UAAdgC//9mAAH0AlUAAAAAEAP//wAAAOYCVwAAAAD0Av//AAAA3wJZAAAAAOYC//8AAADcAlsAAAAA3wJfAAAAANoCXQAAAADcAv//AAAA2QL//2cAAdoC//8AAADeAmEAAAAA3wL//wAAAN0C//9oAAHeAv//AAAASAP//2sAAoADZQBtAAJkA///bwABgAP//3AAAQAHaQAAAADACM8AywABQAVrAHEAAQAHnQCeAAFgBG0AiQABQAV9AIoAAfADbwB6AARgBHcAfgAEuANxAHQAAvADcwB2AAKcA///cgABuAP//3MAAeADdQAAAADwA///AAAAzAP//3gAAeAD//95AAEgBHkAAAAAYAR7AAAAAAgE//+CAAMgBP//hQADQAT//4gAAWAE//+LAAHQBH8AlgABQAWZAJcAAZgEgQAAAADQBIkAAAAAfAT//4wAAZgEgwCNAAGIBIUAAAAAmASHAAAAAIIE//+OAAKIBP//kAACkAT//5IAAZgE//+TAAG0BIsAAAAA0AT//wAAAKYEjQAAAAC0BP//AAAAnwSPAAAAAKYE//8AAACcBJEAAAAAnwSVAAAAAJoEkwAAAACcBP//AAAAmQT//5QAAZoE//8AAACeBJcAAAAAnwT//wAAAJ0E//+VAAGeBP//AAAACAX//5gAAkAFmwCaAAIkBf//nAABQAX//50AASAGnwC2AAEAB68AtwABsAWhAKcABCAGqQCrAAR4BaMAoQACsAWlAKMAAlwF//+fAAF4Bf//oAABoAWnAAAAALAF//8AAACMBf//pQABoAX//6YAAeAFqwAAAAAgBq0AAAAAyAX//68AA+AF//+yAAMABv//tQABIAb//7gAAZAGsQDDAAEAB8sAxAABWAazAAAAAJAGuwAAAAA8Bv//uQABWAa1ALoAAUgGtwAAAABYBrkAAAAAQgb//7sAAkgG//+9AAJQBv//vwABWAb//8AAAXQGvQAAAACQBv//AAAAZga/AAAAAHQG//8AAABfBsEAAAAAZgb//wAAAFwGwwAAAABfBscAAAAAWgbFAAAAAFwG//8AAABZBv//wQABWgb//wAAAF4GyQAAAABfBv//AAAAXQb//8IAAV4G//8AAADIBv//xQACAAfNAMcAAuQG///JAAEAB///ygAB4AfRAOMAAcAI4QDkAAFwB9MA1AAE4AfbANgABDgH1QDOAAJwB9cA0AACHAf//8wAATgH///NAAFgB9kAAAAAcAf//wAAAEwH///SAAFgB///0wABoAfdAAAAAOAH3wAAAACIB///3AADoAf//98AA8AH///iAAHgB///5QABUAjjAPAAAcAI/QDxAAEYCOUAAAAAUAjtAAAAAPwH///mAAEYCOcA5wABCAjpAAAAABgI6wAAAAACCP//6AACCAj//+oAAhAI///sAAEYCP//7QABNAjvAAAAAFAI//8AAAAmCPEAAAAANAj//wAAAB8I8wAAAAAmCP//AAAAHAj1AAAAAB8I+QAAAAAaCPcAAAAAHAj//wAAABkI///uAAEaCP//AAAAHgj7AAAAAB8I//8AAAAdCP//7wABHgj//wAAAIgI///yAALACP8A9AACpAj///YAAcAI///3AAEADgMBAAAAPxOdAQAAAEAMBQEAAAAADmsBUgEBgAoHAfgAAUAMOQElAQGgCQkBEAEBgAoZAREBATAJCwEBAQSgCRMBBQEE+AgNAfsAAjAJDwH9AALcCP//+QAB+Aj///oAASAJEQEAAAAwCf//AAAADAn///8AASAJ//8AAQFgCRUBAAAAoAkXAQAAAEgJ//8JAQNgCf//DAEDgAn//w8BAaAJ//8SAQEQChsBHQEBgAo1AR4BAdgJHQEAAAAQCiUBAAAAvAn//xMBAdgJHwEUAQHICSEBAAAA2AkjAQAAAMIJ//8VAQLICf//FwEC0An//xkBAdgJ//8aAQH0CScBAAAAEAr//wAAAOYJKQEAAAD0Cf//AAAA3wkrAQAAAOYJ//8AAADcCS0BAAAA3wkxAQAAANoJLwEAAADcCf//AAAA2Qn//xsBAdoJ//8AAADeCTMBAAAA3wn//wAAAN0J//8cAQHeCf//AAAASAr//x8BAoAKNwEhAQJkCv//IwEBgAr//yQBAWALOwE9AQFADEsBPgEB8Ao9AS4BBGALRQEyAQS4Cj8BKAEC8ApBASoBApwK//8mAQG4Cv//JwEB4ApDAQAAAPAK//8AAADMCv//LAEB4Ar//y0BASALRwEAAABgC0kBAAAACAv//zYBAyAL//85AQNAC///PAEBYAv//z8BAdALTQFKAQFADGcBSwEBmAtPAQAAANALVwEAAAB8C///QAEBmAtRAUEBAYgLUwEAAACYC1UBAAAAggv//0IBAogL//9EAQKQC///RgEBmAv//0cBAbQLWQEAAADQC///AAAApgtbAQAAALQL//8AAACfC10BAAAApgv//wAAAJwLXwEAAACfC2MBAAAAmgthAQAAAJwL//8AAACZC///SAEBmgv//wAAAJ4LZQEAAACfC///AAAAnQv//0kBAZ4L//8AAAAIDP//TAECQAxpAU4BAiQM//9QAQFADP//UQEBIA1tAWoBAQAOfQFrAQGwDG8BWwEEIA13AV8BBHgMcQFVAQKwDHMBVwECXAz//1MBAXgM//9UAQGgDHUBAAAAsAz//wAAAIwM//9ZAQGgDP//WgEB4Ax5AQAAACANewEAAADIDP//YwED4Az//2YBAwAN//9pAQEgDf//bAEBkA1/AXcBAQAOmQF4AQFYDYEBAAAAkA2JAQAAADwN//9tAQFYDYMBbgEBSA2FAQAAAFgNhwEAAABCDf//bwECSA3//3EBAlAN//9zAQFYDf//dAEBdA2LAQAAAJAN//8AAABmDY0BAAAAdA3//wAAAF8NjwEAAABmDf//AAAAXA2RAQAAAF8NlQEAAABaDZMBAAAAXA3//wAAAFkN//91AQFaDf//AAAAXg2XAQAAAF8N//8AAABdDf//dgEBXg3//wAAAMgN//95AQIADpsBewEC5A3//30BAQAO//9+AQGAEZ8BAAAAPxMFAgAAAMAPoQF/AQGAEdMBrAEB4A6jAZcBAcAPswGYAQFwDqUBiAEE4A6tAYwBBDgOpwGCAQJwDqkBhAECHA7//4ABATgO//+BAQFgDqsBAAAAcA7//wAAAEwO//+GAQFgDv//hwEBoA6vAQAAAOAOsQEAAACIDv//kAEDoA7//5MBA8AO//+WAQHgDv//mQEBUA+1AaQBAcAPzwGlAQEYD7cBAAAAUA+/AQAAAPwO//+aAQEYD7kBmwEBCA+7AQAAABgPvQEAAAACD///nAECCA///54BAhAP//+gAQEYD///oQEBNA/BAQAAAFAP//8AAAAmD8MBAAAANA///wAAAB8PxQEAAAAmD///AAAAHA/HAQAAAB8PywEAAAAaD8kBAAAAHA///wAAABkP//+iAQEaD///AAAAHg/NAQAAAB8P//8AAAAdD///owEBHg///wAAAIgP//+mAQLAD9EBqAECpA///6oBAcAP//+rAQGgENUBxAEBgBHlAcUBATAQ1wG1AQSgEN8BuQEE+A/ZAa8BAjAQ2wGxAQLcD///rQEB+A///64BASAQ3QEAAAAwEP//AAAADBD//7MBASAQ//+0AQFgEOEBAAAAoBDjAQAAAEgQ//+9AQNgEP//wAEDgBD//8MBAaAQ///GAQEQEecB0QEBgBEBAtIBAdgQ6QEAAAAQEfEBAAAAvBD//8cBAdgQ6wHIAQHIEO0BAAAA2BDvAQAAAMIQ///JAQLIEP//ywEC0BD//80BAdgQ///OAQH0EPMBAAAAEBH//wAAAOYQ9QEAAAD0EP//AAAA3xD3AQAAAOYQ//8AAADcEPkBAAAA3xD9AQAAANoQ+wEAAADcEP//AAAA2RD//88BAdoQ//8AAADeEP8BAAAA3xD//wAAAN0Q///QAQHeEP//AAAASBH//9MBAoARAwLVAQJkEf//1wEBgBH//9gBAWASBwLZAQI/ExcC2wEC8BEJAuUBBGASEQLpAQS4EQsC3wEC8BENAuEBApwR///dAQG4Ef//3gEB4BEPAgAAAPAR//8AAADMEf//4wEB4BH//+QBASASEwIAAABgEhUCAAAACBL//+0BAyAS///wAQNAEv//8wEBYBL///QBAdASGQL/AQE/EzMCAAIBmBIbAgAAANASIwIAAAB8Ev//9QEBmBIdAvYBAYgSHwIAAACYEiECAAAAghL///cBAogS///5AQKQEv//+wEBmBL///wBAbQSJQIAAADQEv//AAAAphInAgAAALQS//8AAACfEikCAAAAphL//wAAAJwSKwIAAACfEi8CAAAAmhItAgAAAJwS//8AAACZEv///QEBmhL//wAAAJ4SMQIAAACfEv//AAAAnRL///4BAZ4S//8AAAAAE///AAAAPxM1AgAAACAT//8BAgI/EzcCAwIBMBP//wQCAT8T//8FAgE= - Metadata: 0x0205CB3C
	internal static readonly __StaticArrayInitTypeSize_1036 D4ADEDA8D4E42C7133AFF7B673F4893FEA7C6A101764B0179449453A7E7F516F; // 0x17E8 // Static value (base64): AAARABIAAQAeACoAHwArABMAIAAhACUAAgAsAC0AMQATACAAIQAlAAIALAAtADEAIgAjACQALgAvADAAIgAjACQALgAvADAAFAADABQAAwAVACcABAAzABUAJwAEADMAJgAyACYAMgAWABcABQAWABcABQAYABkABgAaABsAHAAcAB0AKAApAAcANAA0ADUAQQA1AEEAQgBCADYARQBGAEcANgBFAEYARwBDAEQASABDAEQASAA3ADgAOABJAEoASgA5ADoAOQA6ADsAPAA9AD4APwA/AEAASwBAAEsATABMAAgATQBNAE4AWgBOAFoAWwBbAE8AXgBfAGAATwBeAF8AYABcAF0AYQBcAF0AYQBQAFEAUQBiAGMAYwBSAFMAUgBTAFQAVQBWAFcAWABYAFkAZABZAGQAZQBlAAkAZgBmAGcAcwBnAHMAdAB0AGgAdwB4AHkAaAB3AHgAeQB1AHYAegB1AHYAegBpAGoAagB7AHwAfABrAGwAawBsAG0AbgBvAHAAcQBxAHIAfQByAH0AfgB+AAoAfwB/AIAAjACAAIwAjQCNAIEAkACRAJIAgQCQAJEAkgCOAI8AkwCOAI8AkwCCAIMAgwCUAJUAlQCEAIUAhACFAIYAhwCIAIkAigCKAIsAlgCLAJYAlwCXAAsAmACYAJkApQCZAKUApgCmAJoAqQCqAKsAmgCpAKoAqwCnAKgArACnAKgArACbAJwAnACtAK4ArgCdAJ4AnQCeAJ8AoAChAKIAowCjAKQArwCkAK8AsACwAAwAsQCxALIAvgCyAL4AvwC/ALMAwgDDAMQAswDCAMMAxADAAMEAxQDAAMEAxQC0ALUAtQDGAMcAxwC2ALcAtgC3ALgAuQC6ALsAvAC8AL0AyAC9AMgAyQDJAA0AygDKAMsA1wDLANcA2ADYAMwA2wDcAN0AzADbANwA3QDZANoA3gDZANoA3gDNAM4AzgDfAOAA4ADPANAAzwDQANEA0gDTANQA1QDVANYA4QDWAOEA4gDiAA4A4wDjAOQA8ADkAPAA8QDxAOUA9AD1APYA5QD0APUA9gDyAPMA9wDyAPMA9wDmAOcA5wD4APkA+QDoAOkA6ADpAOoA6wDsAO0A7gDuAO8A+gDvAPoA+wD7AA8A/AD8AP0ACQH9AAkBCgEKAf4ADQEOAQ8B/gANAQ4BDwELAQwBEAELAQwBEAH/AAABAAERARIBEgEBAQIBAQECAQMBBAEFAQYBBwEHAQgBEwEIARMBFAEUARAAGQEQABkBFQEVARYBIgEWASIBIwEjARcBJgEnASgBFwEmAScBKAEkASUBKQEkASUBKQEYASoBKwErARoBGwEaARsBHAEdAR4BHwEgASABIQEsASEBLQEtAQ== - Metadata: 0x0205DACC
	internal static readonly __StaticArrayInitTypeSize_84 D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A; // 0x1BF4 // Static value (base64): AAAOAA8AAQAQABEAFQASABMAFAACABYAFwAbAAIAFgAXABsAGAAZABoAGAAZABoAAwAEAAUABgAHAAgACQAJAAoAHAAKABwAHQAdAAsADAAMAA0A - Metadata: 0x0205DEDC
	internal static readonly __StaticArrayInitTypeSize_1799 E90C194F8229C7E8552701BC1D1F1BD2537F77555B9151B4B09FF9D1BA956FE6; // 0x1C48 // Static value (base64): fwABAAAAAEAAAwAAAAF/ADEAAQABIAAPAAAAAEAABQAAAAAwAFsAAAAAQAAHAAAAADgAeQBDAAFAAAkARAABPACHAAAAAEAACwAAAAA+AA0AAAAAQAAvAAAAAD0A//8CAAE+AP//EwABEAARAAAAACAAPQAAAAAIABMAAAAAEAAhAAAAAAQAFQAAAAAIABsAAAAAAgAXAAAAAAQAGQAAAAABAP//AAAAAgD//wMAAQMA//8EAAEEAP//BQABBgAdAAAAAAgAHwAAAAAFAP//BgABBgD//wcAAQcA//8IAAEIAP//CQABDAAjAAAAABAAKQAAAAAKACUAAAAADAAnAAAAAAkA//8KAAEKAP//CwABCwD//wwAAQwA//8NAAEOACsAAAAAEAAtAAAAAA0A//8OAAEOAP//DwABDwD//xAAARAA//8VAAE/AP//FAABQAD//xEAAWAAMwAAAAB/AMEAAAAAUAA1AAAAAGAAowAAAABIADcAAAAAUACVAAAAAEQAOQAAAABIAI8AAAAAQgA7AAAAAEQAjQAAAABBAP//EgABQgD//0gAARgAPwAAAAAgAE0AAAAAFABBAAAAABgARwAAAAASAEMAAAAAFABFAAAAABEA//8WAAESAP//FwABEwD//xgAARQA//8ZAAEWAEkAAAAAGABLAAAAABUA//8aAAEWAP//GwABFwD//xwAARgA//8dAAEcAE8AAAAAIABVAAAAABoAUQAAAAAcAFMAAAAAGQD//x4AARoA//8fAAEbAP//IAABHAD//yEAAR4AVwAAAAAgAFkAAAAAHQD//yIAAR4A//8jAAEfAP//JAABIAD//yUAASgAXQAAAAAwAGsAAAAAJABfAAAAACgAZQAAAAAiAGEAAAAAJABjAAAAACEA//8mAAEiAP//JwABIwD//ygAASQA//8pAAEmAGcAAAAAKABpAAAAACUA//8qAAEmAP//KwABJwD//ywAASgA//8tAAEsAG0AAAAAMABzAAAAACoAbwAAAAAsAHEAAAAAKQD//y4AASoA//8vAAErAP//MAABLAD//zEAAS4AdQAAAAAwAHcAAAAALQD//zIAAS4A//8zAAEvAP//NAABMAD//zUAATQAewA7AAE4AIEAPAABMgB9AAAAADQAfwAAAAAxAP//NgABMgD//zcAATMA//84AAE0AP//OQABNgCDAD8AATgAhQBAAAE1AP//OgABNgD//z0AATcA//8+AAE4AP//QQABOgCJAAAAADwAiwAAAAA5AP//QgABOgD//0UAATsA//9GAAE8AP//RwABQwD//0kAAUQA//9KAAFGAJEAAAAASACTAAAAAEUA//9LAAFGAP//TAABRwD//00AAUgA//9OAAFMAJcAAAAAUACdAAAAAEoAmQAAAABMAJsAAAAASQD//08AAUoA//9QAAFLAP//UQABTAD//1IAAU4AnwAAAABQAKEAAAAATQD//1MAAU4A//9UAAFPAP//VQABUAD//1YAAVgApQAAAABgALMAAAAAVACnAAAAAFgArQAAAABSAKkAAAAAVACrAAAAAFEA//9XAAFSAP//WAABUwD//1kAAVQA//9aAAFWAK8AAAAAWACxAAAAAFUA//9kAAFWAP//WwABVwD//1wAAVgA//9dAAFcALUAAAAAYAC7AAAAAFoAtwAAAABcALkAAAAAWQD//14AAVoA//9fAAFbAP//YAABXAD//2EAAV4AvQAAAABgAL8AAAAAXQD//2IAAV4A//9jAAFfAP//ZQABYAD//2YAAW8AwwAAAAB/AN8AAAAAaADFAAAAAG8A0wAAAABkAMcAAAAAaADNAAAAAGIAyQAAAABkAMsAAAAAYQD//2cAAWIA//9oAAFjAP//aQABZAD//2oAAWYAzwAAAABoANEAAAAAZQD//2sAAWYA//9sAAFnAP//bQABaAD//24AAWwA1QAAAABvANsAAAAAagDXAAAAAGwA2QAAAABpAP//bwABagD//3AAAWsA//9xAAFsAP//cgABbgDdAAAAAG8A//91AAFtAP//cwABbgD//3QAAXcA4QAAAAB/AO8AAAAAcwDjAAAAAHcA6QAAAABxAOUAAAAAcwDnAAAAAHAA//8AAABxAP//dgABcgD//3cAAXMA//94AAF1AOsAAAAAdwDtAAAAAHQA//95AAF1AP//egABdgD//3sAAXcA//98AAF7APEAAAAAfwD3AAAAAHkA8wAAAAB7APUAAAAAeAD//30AAXkA//9+AAF6AP//fwABewD//4AAAX0A+QAAAAB/APsAAAAAfAD//4EAAX0A//8AAAB+AP//AAAAfwD9AAAAAH8A//8AAAB/AP8AAAAAgAD//4IAAX8A//8AAAA= - Metadata: 0x0205DF34
	internal static readonly __StaticArrayInitTypeSize_24 EEAB0A49E323B940CB01CCD3E80D47F1566617F04466CD5D6190ACDBC495CB2A; // 0x234F // Static value (base64): AQAAAAIAAAAFAAAABgAAAAUAAAAFAAAA - Metadata: 0x0205E63C
	internal static readonly __StaticArrayInitTypeSize_104 FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5; // 0x2367 // Static value (base64): DoAAAA+AAAESgAACE4AAAhSAAAIQgAADEYAAAxWAAAMYgAAEGYAABBqAAAQWgAAFF4AABRuAAAUDBAAGBAQABgUECAYGBBAGBwQYBggEIAYMQIAGDUAABwmAAAgcgAAKHYAACwsEAAw= - Metadata: 0x0205E65C

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 45627
	{
	}

	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 45628
	{
	}

	private struct __StaticArrayInitTypeSize_84 // TypeDefIndex: 45629
	{
	}

	private struct __StaticArrayInitTypeSize_104 // TypeDefIndex: 45630
	{
	}

	private struct __StaticArrayInitTypeSize_262 // TypeDefIndex: 45631
	{
	}

	private struct __StaticArrayInitTypeSize_371 // TypeDefIndex: 45632
	{
	}

	private struct __StaticArrayInitTypeSize_508 // TypeDefIndex: 45633
	{
	}

	private struct __StaticArrayInitTypeSize_976 // TypeDefIndex: 45634
	{
	}

	private struct __StaticArrayInitTypeSize_1036 // TypeDefIndex: 45635
	{
	}

	private struct __StaticArrayInitTypeSize_1799 // TypeDefIndex: 45636
	{
	}

	private struct __StaticArrayInitTypeSize_3983 // TypeDefIndex: 45637
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Unity.XR.GoogleVr
{
	public class DaydreamHMD : XRHMD // TypeDefIndex: 45007
	{
		// Constructors
		public DaydreamHMD() {} // 0x00000001864734FC-0x0000000186473504
	}

	public class DaydreamController : XRController // TypeDefIndex: 45008
	{
		// Fields
		private Vector2Control _touchpad_k__BackingField; // 0x1B0
		private ButtonControl _volumeUp_k__BackingField; // 0x1B8
		private ButtonControl _recentered_k__BackingField; // 0x1C0
		private ButtonControl _volumeDown_k__BackingField; // 0x1C8
		private ButtonControl _recentering_k__BackingField; // 0x1D0
		private ButtonControl _app_k__BackingField; // 0x1D8
		private ButtonControl _home_k__BackingField; // 0x1E0
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1E8
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1F0
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F8
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x200
	
		// Properties
		public Vector2Control touchpad { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public ButtonControl volumeUp { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public ButtonControl recentered { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl volumeDown { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl recentering { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl app { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl home { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
	
		// Constructors
		public DaydreamController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCB7714-0x000000018BCB79AC
	}
}

namespace Unity.XR.Oculus.Input
{
	public class OculusHMD : XRHMD // TypeDefIndex: 45001
	{
		// Fields
		private ButtonControl _userPresence_k__BackingField; // 0x1E0
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E8
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x1F0
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x1F8
		private Vector3Control _leftEyeAngularVelocity_k__BackingField; // 0x200
		private Vector3Control _leftEyeAcceleration_k__BackingField; // 0x208
		private Vector3Control _leftEyeAngularAcceleration_k__BackingField; // 0x210
		private Vector3Control _rightEyeAngularVelocity_k__BackingField; // 0x218
		private Vector3Control _rightEyeAcceleration_k__BackingField; // 0x220
		private Vector3Control _rightEyeAngularAcceleration_k__BackingField; // 0x228
		private Vector3Control _centerEyeAngularVelocity_k__BackingField; // 0x230
		private Vector3Control _centerEyeAcceleration_k__BackingField; // 0x238
		private Vector3Control _centerEyeAngularAcceleration_k__BackingField; // 0x240
	
		// Properties
		public ButtonControl userPresence { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector3Control leftEyeAngularVelocity { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public Vector3Control leftEyeAcceleration { get; protected set; } // 0x0000000185FB84F0-0x0000000185FB8500 0x0000000187A475F0-0x0000000187A47604
		public Vector3Control leftEyeAngularAcceleration { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public Vector3Control rightEyeAngularVelocity { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
		public Vector3Control rightEyeAcceleration { get; protected set; } // 0x0000000185FB8890-0x0000000185FB88A0 0x0000000187A47BB8-0x0000000187A47BCC
		public Vector3Control rightEyeAngularAcceleration { get; protected set; } // 0x0000000185FB8620-0x0000000185FB8630 0x0000000187A47794-0x0000000187A477A8
		public Vector3Control centerEyeAngularVelocity { get; protected set; } // 0x0000000185FB8310-0x0000000185FB8320 0x0000000187A37678-0x0000000187A3768C
		public Vector3Control centerEyeAcceleration { get; protected set; } // 0x0000000185FB8850-0x0000000185FB8860 0x0000000187A47B54-0x0000000187A47B68
		public Vector3Control centerEyeAngularAcceleration { get; protected set; } // 0x0000000185FB8770-0x0000000185FB8780 0x0000000187A479C4-0x0000000187A479D8
	
		// Constructors
		public OculusHMD() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC1BC0-0x000000018BCC1EB8
	}

	public class OculusTouchController : XRControllerWithRumble // TypeDefIndex: 45002
	{
		// Fields
		private Vector2Control _thumbstick_k__BackingField; // 0x1B0
		private AxisControl _trigger_k__BackingField; // 0x1B8
		private AxisControl _grip_k__BackingField; // 0x1C0
		private ButtonControl _primaryButton_k__BackingField; // 0x1C8
		private ButtonControl _secondaryButton_k__BackingField; // 0x1D0
		private ButtonControl _gripPressed_k__BackingField; // 0x1D8
		private ButtonControl _start_k__BackingField; // 0x1E0
		private ButtonControl _thumbstickClicked_k__BackingField; // 0x1E8
		private ButtonControl _primaryTouched_k__BackingField; // 0x1F0
		private ButtonControl _secondaryTouched_k__BackingField; // 0x1F8
		private AxisControl _triggerTouched_k__BackingField; // 0x200
		private ButtonControl _triggerPressed_k__BackingField; // 0x208
		private ButtonControl _thumbstickTouched_k__BackingField; // 0x210
		private Vector3Control _deviceVelocity_k__BackingField; // 0x218
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x220
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x228
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x230
	
		// Properties
		public Vector2Control thumbstick { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public AxisControl trigger { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public AxisControl grip { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl primaryButton { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl secondaryButton { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl gripPressed { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl start { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl thumbstickClicked { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public ButtonControl primaryTouched { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public ButtonControl secondaryTouched { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public AxisControl triggerTouched { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB84F0-0x0000000185FB8500 0x0000000187A475F0-0x0000000187A47604
		public ButtonControl thumbstickTouched { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB8890-0x0000000185FB88A0 0x0000000187A47BB8-0x0000000187A47BCC
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000185FB8620-0x0000000185FB8630 0x0000000187A47794-0x0000000187A477A8
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000185FB8310-0x0000000185FB8320 0x0000000187A37678-0x0000000187A3768C
	
		// Constructors
		public OculusTouchController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC1F90-0x000000018BCC2374
	}

	public class OculusTrackingReference : TrackedDevice // TypeDefIndex: 45003
	{
		// Fields
		private IntegerControl _trackingState_k__BackingField; // 0x1B0
		private ButtonControl _isTracked_k__BackingField; // 0x1B8
	
		// Properties
		public new IntegerControl trackingState { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public new ButtonControl isTracked { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
	
		// Constructors
		public OculusTrackingReference() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC2374-0x000000018BCC2420
	}

	public class OculusRemote : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 45004
	{
		// Fields
		private ButtonControl _back_k__BackingField; // 0x190
		private ButtonControl _start_k__BackingField; // 0x198
		private Vector2Control _touchpad_k__BackingField; // 0x1A0
	
		// Properties
		public ButtonControl back { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public ButtonControl start { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public Vector2Control touchpad { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
	
		// Constructors
		public OculusRemote() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC1EB8-0x000000018BCC1F90
	}

	public class OculusHMDExtended : OculusHMD // TypeDefIndex: 45005
	{
		// Fields
		private ButtonControl _back_k__BackingField; // 0x248
		private Vector2Control _touchpad_k__BackingField; // 0x250
	
		// Properties
		public ButtonControl back { get; protected set; } // 0x0000000185FB8840-0x0000000185FB8850 0x0000000187A47B40-0x0000000187A47B54
		public Vector2Control touchpad { get; protected set; } // 0x0000000185FB8470-0x0000000185FB8480 0x0000000187A47550-0x0000000187A47564
	
		// Constructors
		public OculusHMDExtended() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC1B14-0x000000018BCC1BC0
	}

	public class GearVRTrackedController : XRController // TypeDefIndex: 45006
	{
		// Fields
		private Vector2Control _touchpad_k__BackingField; // 0x1B0
		private AxisControl _trigger_k__BackingField; // 0x1B8
		private ButtonControl _back_k__BackingField; // 0x1C0
		private ButtonControl _triggerPressed_k__BackingField; // 0x1C8
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1D0
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1D8
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E0
		private Vector3Control _deviceAcceleration_k__BackingField; // 0x1E8
		private Vector3Control _deviceAngularAcceleration_k__BackingField; // 0x1F0
	
		// Properties
		public Vector2Control touchpad { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public AxisControl trigger { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public ButtonControl back { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
	
		// Constructors
		public GearVRTrackedController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCB7BB0-0x000000018BCB7DEC
	}
}

namespace Unity.XR.OpenVR
{
	public class OpenVRHMD : XRHMD // TypeDefIndex: 44994
	{
		// Fields
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1E0
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1E8
		private Vector3Control _leftEyeVelocity_k__BackingField; // 0x1F0
		private Vector3Control _leftEyeAngularVelocity_k__BackingField; // 0x1F8
		private Vector3Control _rightEyeVelocity_k__BackingField; // 0x200
		private Vector3Control _rightEyeAngularVelocity_k__BackingField; // 0x208
		private Vector3Control _centerEyeVelocity_k__BackingField; // 0x210
		private Vector3Control _centerEyeAngularVelocity_k__BackingField; // 0x218
	
		// Properties
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public Vector3Control leftEyeVelocity { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector3Control leftEyeAngularVelocity { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector3Control rightEyeVelocity { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public Vector3Control rightEyeAngularVelocity { get; protected set; } // 0x0000000185FB84F0-0x0000000185FB8500 0x0000000187A475F0-0x0000000187A47604
		public Vector3Control centerEyeVelocity { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public Vector3Control centerEyeAngularVelocity { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
	
		// Constructors
		public OpenVRHMD() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC26C4-0x000000018BCC28A0
	}

	public class OpenVRControllerWMR : XRController // TypeDefIndex: 44995
	{
		// Fields
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1B8
		private ButtonControl _touchpadClick_k__BackingField; // 0x1C0
		private ButtonControl _touchpadTouch_k__BackingField; // 0x1C8
		private ButtonControl _gripPressed_k__BackingField; // 0x1D0
		private ButtonControl _triggerPressed_k__BackingField; // 0x1D8
		private ButtonControl _menu_k__BackingField; // 0x1E0
		private AxisControl _trigger_k__BackingField; // 0x1E8
		private AxisControl _grip_k__BackingField; // 0x1F0
		private Vector2Control _touchpad_k__BackingField; // 0x1F8
		private Vector2Control _joystick_k__BackingField; // 0x200
	
		// Properties
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public ButtonControl touchpadClick { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl touchpadTouch { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl gripPressed { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl menu { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public AxisControl trigger { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public AxisControl grip { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector2Control touchpad { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector2Control joystick { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
	
		// Constructors
		public OpenVRControllerWMR() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC2420-0x000000018BCC26C4
	}

	public class ViveWand : XRControllerWithRumble // TypeDefIndex: 44996
	{
		// Fields
		private AxisControl _grip_k__BackingField; // 0x1B0
		private ButtonControl _gripPressed_k__BackingField; // 0x1B8
		private ButtonControl _primary_k__BackingField; // 0x1C0
		private ButtonControl _trackpadPressed_k__BackingField; // 0x1C8
		private ButtonControl _trackpadTouched_k__BackingField; // 0x1D0
		private Vector2Control _trackpad_k__BackingField; // 0x1D8
		private AxisControl _trigger_k__BackingField; // 0x1E0
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E8
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F0
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1F8
	
		// Properties
		public AxisControl grip { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public ButtonControl gripPressed { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public ButtonControl primary { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl trackpadPressed { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl trackpadTouched { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public Vector2Control trackpad { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public AxisControl trigger { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
	
		// Constructors
		public ViveWand() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC88E0-0x000000018BCC8B50
	}

	public class ViveLighthouse : TrackedDevice // TypeDefIndex: 44997
	{
		// Constructors
		public ViveLighthouse() {} // 0x00000001864734FC-0x0000000186473504
	}

	public class ViveTracker : TrackedDevice // TypeDefIndex: 44998
	{
		// Fields
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x1B8
	
		// Properties
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
	
		// Constructors
		public ViveTracker() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC8840-0x000000018BCC88E0
	}

	public class HandedViveTracker : ViveTracker // TypeDefIndex: 44999
	{
		// Fields
		private AxisControl _grip_k__BackingField; // 0x1C0
		private ButtonControl _gripPressed_k__BackingField; // 0x1C8
		private ButtonControl _primary_k__BackingField; // 0x1D0
		private ButtonControl _trackpadPressed_k__BackingField; // 0x1D8
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
	
		// Properties
		public AxisControl grip { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl gripPressed { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl primary { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl trackpadPressed { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
	
		// Constructors
		public HandedViveTracker() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCB7DEC-0x000000018BCB7F38
	}

	public class OpenVROculusTouchController : XRControllerWithRumble // TypeDefIndex: 45000
	{
		// Fields
		private Vector2Control _thumbstick_k__BackingField; // 0x1B0
		private AxisControl _trigger_k__BackingField; // 0x1B8
		private AxisControl _grip_k__BackingField; // 0x1C0
		private ButtonControl _primaryButton_k__BackingField; // 0x1C8
		private ButtonControl _secondaryButton_k__BackingField; // 0x1D0
		private ButtonControl _gripPressed_k__BackingField; // 0x1D8
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
		private ButtonControl _thumbstickClicked_k__BackingField; // 0x1E8
		private ButtonControl _thumbstickTouched_k__BackingField; // 0x1F0
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1F8
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x200
	
		// Properties
		public Vector2Control thumbstick { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public AxisControl trigger { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public AxisControl grip { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl primaryButton { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl secondaryButton { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl gripPressed { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl thumbstickClicked { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public ButtonControl thumbstickTouched { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
	
		// Constructors
		public OpenVROculusTouchController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC28A0-0x000000018BCC2B44
	}
}

namespace UnityEngine.InputSystem
{
	public interface IInputActionCollection : IEnumerable<InputAction> // TypeDefIndex: 45012
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

	public interface IInputActionCollection2 : IInputActionCollection // TypeDefIndex: 45013
	{
		// Properties
		IEnumerable<InputBinding> bindings { get; }
	
		// Methods
		InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0205B9E8 */);
		int FindBinding(InputBinding mask, out InputAction action);
	}

	public interface IInputInteraction // TypeDefIndex: 45014
	{
		// Methods
		void Process(ref InputInteractionContext context);
		void Reset();
	}

	public interface IInputInteraction<TValue> : IInputInteraction // TypeDefIndex: 45015
		where TValue : struct
	{
	}

	internal static class InputInteraction // TypeDefIndex: 45016
	{
		// Fields
		public static TypeTable s_Interactions; // 0x00
	
		// Methods
		public static System.Type GetValueType(System.Type interactionType) => default; // 0x000000018BCC1A40-0x000000018BCC1B14
		public static string GetDisplayName(string interaction) => default; // 0x000000018BCC1964-0x000000018BCC1A40
		public static string GetDisplayName(System.Type interactionType) => default; // 0x000000018BCC1814-0x000000018BCC1964
	}

	[Serializable]
	public sealed class InputAction : ICloneable, IDisposable // TypeDefIndex: 45019
	{
		// Fields
		private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; // 0x00
		private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; // 0x08
		internal string m_Name; // 0x10
		internal UnityEngine.InputSystem.InputActionType m_Type; // 0x18
		internal string m_ExpectedControlType; // 0x20
		internal string m_Id; // 0x28
		internal string m_Processors; // 0x30
		internal string m_Interactions; // 0x38
		internal InputBinding[] m_SingletonActionBindings; // 0x40
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
		public string name { get => default; } // 0x000000018BCC14AC-0x000000018BCC14F8 
		public UnityEngine.InputSystem.InputActionType type { get => default; } // 0x000000018BCC1458-0x000000018BCC1460 
		public Guid id { get => default; } // 0x000000018BCC12B4-0x000000018BCC1328 
		internal Guid idDontGenerate { get => default; } // 0x000000018BCC1328-0x000000018BCC1394 
		public string expectedControlType { get => default; set {} } // 0x0000000185949C70-0x0000000185949D40 0x000000018BCC17F8-0x000000018BCC1814
		public string processors { get => default; } // 0x00000001843D29E0-0x00000001843D2AA0 
		public string interactions { get => default; } // 0x000000018BCC1050-0x000000018BCC1240 
		public InputActionMap actionMap { get => default; } // 0x000000018BCC0500-0x000000018BCC0520 
		public InputBinding? bindingMask { get => default; set {} } // 0x000000018BCC0A4C-0x000000018BCC0CF0 0x0000000184BFC020-0x0000000184BFC810
		public ReadOnlyArray<InputBinding> bindings { get => default; } // 0x000000018BCC0400-0x000000018BCC0500 
		public ReadOnlyArray<InputControl> controls { get => default; } // 0x000000018BCC0208-0x000000018BCC032C 
		public InputActionPhase phase { get => default; } // 0x000000018BCC0A44-0x000000018BCC0A4C 
		public bool inProgress { get => default; }
		public bool enabled { get => default; } // 0x000000018BCC0924-0x000000018BCC09A4 
		public bool triggered { get => default; } // 0x000000018BCC0EA0-0x000000018BCC0EFC 
		public InputControl activeControl { get => default; } // 0x000000018BCC0FD4-0x000000018BCC1050 
		public System.Type activeValueType { get => default; } // 0x000000018BCC0F78-0x000000018BCC0FD4 
		public bool wantsInitialStateCheck { get => default; set {} } // 0x000000018BCC0E24-0x000000018BCC0EA0 0x000000018BCC0DC8-0x000000018BCC0E24
		internal bool isSingletonAction { get => default; } // 0x00000001845859D0-0x0000000184585A30 
		private InputActionState.TriggerState currentState { get => default; } // 0x000000018BCB75AC-0x000000018BCB75FC 
	
		// Events
		public event Action<CallbackContext> started;
		public event Action<CallbackContext> canceled;
		public event Action<CallbackContext> performed;
	
		// Nested types
		internal enum ActionFlags // TypeDefIndex: 45017
		{
			WantsInitialStateCheck = 1
		}
	
		public struct CallbackContext // TypeDefIndex: 45018
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal int m_ActionIndex; // 0x08
	
			// Properties
			private int actionIndex { get => default; } // 0x000000018346D130-0x000000018346D140 
			private int bindingIndex { get => default; } // 0x00000001813AE560-0x00000001813AE570 
			private int controlIndex { get => default; } // 0x000000018BCC13E4-0x000000018BCC1424 
			private int interactionIndex { get => default; } // 0x0000000184BFD530-0x0000000184BFD580 
			public InputActionPhase phase { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
			public bool started { get => default; } // 0x000000018646EE40-0x000000018646EE50 
			public bool performed { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
			public bool canceled { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
			public InputAction action { get => default; } // 0x000000018BCC128C-0x000000018BCC12B4 
			public InputControl control { get => default; } // 0x0000000185FD7740-0x0000000185FD7780 
			public IInputInteraction interaction { get => default; } // 0x000000018BCC1544-0x000000018BCC17F8 
			public double time { get => default; } // 0x000000018BCC1394-0x000000018BCC13E4 
			public double startTime { get => default; } // 0x0000000184BFA640-0x0000000184BFA6B0 
			public double duration { get => default; } // 0x0000000184BFC860-0x0000000184BFC890 
			public System.Type valueType { get => default; } // 0x000000018BCC1424-0x000000018BCC143C 
			public int valueSizeInBytes { get => default; } // 0x0000000184BFC840-0x0000000184BFC860 
	
			// Methods
			public unsafe void ReadValue(void* buffer, int bufferSize) {} // 0x000000018BCC1240-0x000000018BCC128C
			public TValue ReadValue<TValue>()
				where TValue : struct => default; // 0x000000018BCC14F8-0x000000018BCC1544
			public bool ReadValueAsButton() => default; // 0x0000000184BFBF40-0x0000000184BFBF90
			public object ReadValueAsObject() => default; // 0x000000018BCC1460-0x000000018BCC14AC
			public override string ToString() => default; // 0x0000000184BFBF90-0x0000000184BFBFE0
		}
	
		// Constructors
		public InputAction() {} // 0x000000018BCC0D4C-0x000000018BCC0DC8
		public InputAction(string name = null, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x0205B9E9 */, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) {} // 0x000000018BCC0CF0-0x000000018BCC0D4C
		static InputAction() {} // 0x000000018BCB739C-0x000000018BCB7548
	
		// Methods
		public void Dispose() {} // 0x000000018BCC0770-0x000000018BCC0890
		public override string ToString() => default; // 0x000000018BCC143C-0x000000018BCC1458
		public void Enable() {} // 0x0000000184BFC890-0x0000000184BFC920
		public void Disable() {} // 0x0000000185BC6580-0x0000000185BC65B0
		public InputAction Clone() => default; // 0x000000018BCC06E0-0x000000018BCC0724
		object ICloneable.Clone() => default; // 0x0000000184BFC810-0x0000000184BFC840
		public TValue ReadValue<TValue>()
			where TValue : struct => default; // 0x000000018BCC032C-0x000000018BCC0400
		public object ReadValueAsObject() => default; // 0x000000018BCC09A4-0x000000018BCC09E0
		public float GetControlMagnitude() => default; // 0x000000018BCBFF10-0x000000018BCBFFF0
		public void Reset() {} // 0x000000018BCC0584-0x000000018BCC06E0
		public bool IsPressed() => default; // 0x000000018BCBFFF0-0x000000018BCC0168
		public bool IsInProgress() => default; // 0x000000018BCC0168-0x000000018BCC0208
		private int ExpectedFrame() => default; // 0x0000000185F0E2A0-0x0000000185F0E340
		public bool WasPressedThisFrame() => default; // 0x0000000181B7E450-0x0000000181B7E460
		public bool WasPressedThisDynamicUpdate() => default; // 0x0000000184584C70-0x0000000184584CA0
		public bool WasReleasedThisFrame() => default; // 0x0000000184585C10-0x0000000184585C50
		public bool WasReleasedThisDynamicUpdate() => default; // 0x000000018BCB757C-0x000000018BCB75AC
		public bool WasPerformedThisFrame() => default; // 0x0000000184586360-0x0000000184586380
		public bool WasPerformedThisDynamicUpdate() => default; // 0x000000018BCB7634-0x000000018BCB764C
		public bool WasCompletedThisFrame() => default; // 0x000000018BCB75FC-0x000000018BCB7614
		public bool WasCompletedThisDynamicUpdate() => default; // 0x0000000184586330-0x0000000184586360
		public float GetTimeoutCompletionPercentage() => default; // 0x00000001845845E0-0x0000000184584610
		internal string MakeSureIdIsInPlace() => default; // 0x000000018BCB764C-0x000000018BCB766C
		internal void GenerateId() {} // 0x000000018BCB7614-0x000000018BCB7634
		internal InputActionMap GetOrCreateActionMap() => default; // 0x000000018BCB7548-0x000000018BCB757C
		private void CreateInternalActionMapForSingletonAction() {} // 0x000000018BCB76C0-0x000000018BCB7714
		internal void RequestInitialStateCheckOnEnabledAction() {} // 0x000000018BCB766C-0x000000018BCB76C0
		internal bool ActiveControlIsValid(InputControl control) => default; // 0x000000018BCB71D8-0x000000018BCB739C
		internal InputBinding? FindEffectiveBindingMask() => default;
		internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) => default; // 0x0000000184954F40-0x0000000184954FC0
		internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) => default; // 0x000000018BCB715C-0x000000018BCB71D8
	}

	public class InputActionAsset : ScriptableObject, IInputActionCollection2 // TypeDefIndex: 45025
	{
		// Fields
		public const string Extension = "inputactions"; // Metadata: 0x0205B9ED
		internal const string kDefaultAssetLayoutJson = "{}"; // Metadata: 0x0205B9FA
		internal InputActionMap[] m_ActionMaps; // 0x18
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
		public bool enabled { get => default; } // 0x000000018BCB8538-0x000000018BCB85E0 
		public ReadOnlyArray<InputActionMap> actionMaps { get => default; } // 0x0000000184BFD330-0x0000000184BFD3E0 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x000000018BCB8A50-0x000000018BCB8B18 
		public IEnumerable<InputBinding> bindings { get => default; } // 0x000000018BCB8B18-0x000000018BCB8C48 
		public InputBinding? bindingMask { get => default; set {} } // 0x000000018BCB8DD0-0x000000018BCB8F14 0x000000018BCB81F8-0x000000018BCB8328
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x000000018BCB80C8-0x000000018BCB81F8 0x000000018BCB8058-0x000000018BCB80C8
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018BCB8D00-0x000000018BCB8D5C 
	
		// Nested types
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 45020
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.WriteMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
		}
	
		[Serializable]
		internal struct WriteFileJsonNoName // TypeDefIndex: 45021
		{
			// Fields
			public InputActionMap.WriteMapJson[] maps; // 0x00
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x08
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 45022
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.ReadMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
	
			// Methods
			public void ToAsset(InputActionAsset asset) {} // 0x000000018BCB93B8-0x000000018BCB94E8
		}
	
		private sealed class _get_bindings_d__9 : IEnumerable<InputBinding>, IEnumerator<InputBinding> // TypeDefIndex: 45023
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
			InputBinding IEnumerator<UnityEngine.InputSystem.InputBinding>.Current { get => default; } // 0x0000000185FD76C0-0x0000000185FD7700 
			object IEnumerator.Current { get => default; } // 0x0000000186470EDC-0x0000000186470F14 
	
			// Constructors
			public _get_bindings_d__9() {} // Dummy constructor
			public _get_bindings_d__9(int __1__state) {} // 0x0000000184BF9B20-0x0000000184BF9B80
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCB9364-0x000000018BCB93B8
			private bool MoveNext() => default; // 0x000000018BCB92F4-0x000000018BCB9364
			void IEnumerator.Reset() {} // 0x000000018BCB94E8-0x000000018BCB968C
			IEnumerator<InputBinding> IEnumerable<InputBinding>.GetEnumerator() => default; // 0x000000018BCB968C-0x000000018BCB96D4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCB9260-0x000000018BCB92F4
		}
	
		private sealed class _GetEnumerator_d__32 : IEnumerator<InputAction> // TypeDefIndex: 45024
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
			InputAction IEnumerator<UnityEngine.InputSystem.InputAction>.Current { get => default; } // 0x000000018BCB85E0-0x000000018BCB8940 
			object IEnumerator.Current { get => default; } // 0x000000018BCB8328-0x000000018BCB8538 
	
			// Constructors
			public _GetEnumerator_d__32() {} // Dummy constructor
			public _GetEnumerator_d__32(int __1__state) {} // 0x000000018BCB91A8-0x000000018BCB9260
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCB8F14-0x000000018BCB8FE4
			private bool MoveNext() => default; // 0x000000018BCB8C48-0x000000018BCB8D00
			void IEnumerator.Reset() {} // 0x000000018BCB8940-0x000000018BCB8A50
		}
	
		// Constructors
		public InputActionAsset() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public string ToJson() => default; // 0x000000018BCB91A0-0x000000018BCB91A8
		public void LoadFromJson(string json) {} // 0x0000000185492010-0x0000000185492020
		public static InputActionAsset FromJson(string json) => default; // 0x000000018BCB8D5C-0x000000018BCB8DD0
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0205B9EB */) => default; // 0x000000018BCB9094-0x000000018BCB90EC
		public int FindBinding(InputBinding mask, out InputAction action) {
			action = default;
			return default;
		} // 0x000000018BCB9020-0x000000018BCB9094
		public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false /* Metadata: 0x0205B9EC */) => default; // 0x000000018BCB90EC-0x000000018BCB9128
		public InputActionMap FindActionMap(Guid id) => default; // 0x000000018BCB9128-0x000000018BCB91A0
		public InputAction FindAction(Guid guid) => default; // 0x000000018BCB8FE4-0x000000018BCB9020
		public int FindControlSchemeIndex(string name) => default; // 0x0000000184BBD7B0-0x0000000184BBD7C0
		public InputControlScheme? FindControlScheme(string name) => default; // 0x000000018BCC440C-0x000000018BCC44CC
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BCC8824-0x000000018BCC8840
		public void Enable() {} // 0x0000000185492010-0x0000000185492020
		public void Disable() {} // 0x000000018BCC852C-0x000000018BCC86C8
		public bool Contains(InputAction action) => default; // 0x0000000185FD77D0-0x0000000185FD7810
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x000000018BCC875C-0x000000018BCC87A8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCC87A8-0x000000018BCC8824
		internal void MarkAsDirty() {} // 0x000000018BCC86C8-0x000000018BCC8754
		internal bool IsEmpty() => default; // 0x000000018BCC8754-0x000000018BCC875C
		internal void OnWantToChangeSetup() {} // 0x0000000181378230-0x0000000181378240
		internal void OnSetupChanged() {} // 0x0000000185492010-0x0000000185492020
		private void ReResolveIfNecessary(bool fullResolve) {} // 0x000000018BCC83C4-0x000000018BCC84E0
		internal void ResolveBindingsIfNecessary() {} // 0x0000000181377E40-0x0000000181377E50
		private void OnDestroy() {} // 0x000000018BCC84E0-0x000000018BCC852C
	}

	public enum InputActionChange // TypeDefIndex: 45026
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
	public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IDisposable // TypeDefIndex: 45038
	{
		// Fields
		private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; // 0x00
		internal string m_Name; // 0x10
		internal string m_Id; // 0x18
		internal InputActionAsset m_Asset; // 0x20
		internal InputAction[] m_Actions; // 0x28
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
		public string name { get => default; } // 0x000000018BCBAA58-0x000000018BCBAAA4 
		public InputActionAsset asset { get => default; } // 0x0000000185A1BC90-0x0000000185A1BCF0 
		public Guid id { get => default; } // 0x0000000185A1BC60-0x0000000185A1BC90 
		internal Guid idDontGenerate { get => default; } // 0x000000018BCB997C-0x000000018BCB9990 
		public bool enabled { get => default; } // 0x0000000184D59020-0x0000000184D59150 
		public ReadOnlyArray<InputAction> actions { get => default; } // 0x0000000184D59150-0x0000000184D592A0 
		public ReadOnlyArray<InputBinding> bindings { get => default; } // 0x0000000184BF9A10-0x0000000184BF9A50 
		IEnumerable<InputBinding> IInputActionCollection2.bindings { get => default; } // 0x0000000184BFD430-0x0000000184BFD530 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x0000000184D58FB0-0x0000000184D59020 
		public InputBinding? bindingMask { get => default; set {} } // 0x0000000184BFD3E0-0x0000000184BFD430 0x000000018BCB9D54-0x000000018BCB9E78
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x000000018BCB9990-0x000000018BCB99D4 0x000000018BCB994C-0x000000018BCB997C
		public InputAction this[string actionNameOrId] { get => default; } // 0x000000018BCB96D4-0x000000018BCB9920 
		private bool needToResolveBindings { get => default; set {} } // 0x000000018B4C7AF0-0x000000018B4C7B34 0x000000018BCB9E78-0x000000018BCB9F40
		private bool bindingResolutionNeedsFullReResolve { get => default; set {} } // 0x0000000184BFBFE0-0x0000000184BFC010 0x0000000184BF82E0-0x0000000184BF9910
		private bool controlsForEachActionInitialized { get => default; set {} } // 0x000000018BCB9A60-0x000000018BCB9B80 0x000000018BCB99D4-0x000000018BCB9A60
		private bool bindingsForEachActionInitialized { get => default; set {} } // 0x000000018BCB9B80-0x000000018BCB9C30 0x000000018BCBA538-0x000000018BCBA5E8
	
		// Events
		public event Action<InputAction.CallbackContext> actionTriggered;
	
		// Nested types
		private enum Flags // TypeDefIndex: 45027
		{
			NeedToResolveBindings = 1,
			BindingResolutionNeedsFullReResolve = 2,
			ControlsForEachActionInitialized = 4,
			BindingsForEachActionInitialized = 8
		}
	
		internal struct DeviceArray // TypeDefIndex: 45028
		{
			// Fields
			private bool m_HaveValue; // 0x00
			private int m_DeviceCount; // 0x04
			private UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x08
	
			// Methods
			public int IndexOf(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018346D130-0x000000018346D140
			public bool Remove(UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001813B31A0-0x00000001813B31B0
			public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? Get() => default; // 0x000000018BCBAA0C-0x000000018BCBAA58
			public bool Set(ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices) => default; // 0x000000018BCBA9C0-0x000000018BCBAA0C
		}
	
		[Serializable]
		internal struct BindingOverrideListJson // TypeDefIndex: 45029
		{
			// Fields
			public List<BindingOverrideJson> bindings; // 0x00
		}
	
		[Serializable]
		internal struct BindingOverrideJson // TypeDefIndex: 45030
		{
			// Fields
			public string action; // 0x00
			public string id; // 0x08
			public string path; // 0x10
			public string interactions; // 0x18
			public string processors; // 0x20
	
			// Methods
			public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) => default; // 0x000000018B8ABEF0-0x000000018B8ABEF8
			public static BindingOverrideJson FromBinding(InputBinding binding) => default; // 0x000000018BCBA87C-0x000000018BCBA8D0
			public static InputBinding ToBinding(BindingOverrideJson bindingOverride) => default; // 0x000000018BCBA8DC-0x000000018BCBA930
		}
	
		[Serializable]
		internal struct BindingJson // TypeDefIndex: 45031
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
			public InputBinding ToBinding() => default; // 0x000000018BCBA6DC-0x000000018BCBA734
			public static BindingJson FromBinding(ref InputBinding binding) => default; // 0x000000018BCBA930-0x000000018BCBA9C0
		}
	
		[Serializable]
		internal struct ReadActionJson // TypeDefIndex: 45032
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
			public InputAction ToAction(string actionName = null) => default; // 0x0000000185FD7700-0x0000000185FD7740
		}
	
		[Serializable]
		internal struct WriteActionJson // TypeDefIndex: 45033
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
			public static WriteActionJson FromAction(InputAction action) => default; // 0x000000018BCBAAA4-0x000000018BCBAC5C
		}
	
		[Serializable]
		internal struct ReadMapJson // TypeDefIndex: 45034
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public ReadActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
		}
	
		[Serializable]
		internal struct WriteMapJson // TypeDefIndex: 45035
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public WriteActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
	
			// Methods
			public static WriteMapJson FromMap(InputActionMap map) => default; // 0x00000001849544A0-0x0000000184954540
		}
	
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 45036
		{
			// Fields
			public WriteMapJson[] maps; // 0x00
	
			// Methods
			public static WriteFileJson FromMap(InputActionMap map) => default; // 0x000000018BCBAC5C-0x000000018BCBACA4
			public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps) => default; // 0x000000018BCBA780-0x000000018BCBA87C
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 45037
		{
			// Fields
			public ReadActionJson[] actions; // 0x00
			public ReadMapJson[] maps; // 0x08
	
			// Methods
			public InputActionMap[] ToMaps() => default; // 0x000000018BCBA734-0x000000018BCBA780
		}
	
		// Constructors
		public InputActionMap() {} // 0x000000018BCBA640-0x000000018BCBA6DC
		public InputActionMap(string name) {} // 0x000000018BCB9CC4-0x000000018BCB9D54
		static InputActionMap() {} // 0x000000018BCC44CC-0x000000018BCC5284
	
		// Methods
		public void Dispose() {} // 0x000000018BCBA528-0x000000018BCBA530
		internal int FindActionIndex(string nameOrId) => default; // 0x0000000184BFC010-0x0000000184BFC020
		private void SetUpActionLookupTable() {} // 0x0000000184BF9B00-0x0000000184BF9B20
		internal void ClearActionLookupTable() {} // 0x0000000184BF9910-0x0000000184BF9920
		private int FindActionIndex(Guid id) => default; // 0x0000000184BF9AE0-0x0000000184BF9B00
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0205BA06 */) => default; // 0x0000000184BFA750-0x0000000184BFA760
		public InputAction FindAction(Guid id) => default; // 0x0000000184BF9AC0-0x0000000184BF9AE0
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BCBA8D0-0x000000018BCBA8DC
		public void Enable() {} // 0x0000000184BF9AA0-0x0000000184BF9AC0
		public void Disable() {} // 0x000000018BCB9C30-0x000000018BCB9CC4
		public InputActionMap Clone() => default; // 0x0000000184BFA6B0-0x0000000184BFA750
		object ICloneable.Clone() => default; // 0x0000000184D58AD0-0x0000000184D58FB0
		public bool Contains(InputAction action) => default; // 0x000000018BCBA1C0-0x000000018BCBA528
		public override string ToString() => default; // 0x000000018BCB9F68-0x000000018BCBA1C0
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x000000018BCB9F40-0x000000018BCB9F68
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184BF9A50-0x0000000184BF9AA0
		internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action) => default; // 0x000000018BCBA5E8-0x000000018BCBA640
		internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action) => default; // 0x0000000185492010-0x0000000185492020
		private void SetUpPerActionControlAndBindingArrays() {} // 0x0000000184BF9920-0x0000000184BF9A10
		internal void OnWantToChangeSetup() {} // 0x0000000185F65C90-0x0000000185F65CF0
		internal void OnSetupChanged() {} // 0x000000018BCB79AC-0x000000018BCB79FC
		internal void OnBindingModified() {} // 0x000000018BCB79FC-0x000000018BCB7A64
		internal void ClearCachedActionData(bool onlyControls = false /* Metadata: 0x0205BA07 */) {} // 0x0000000184954540-0x00000001849545B0
		internal void GenerateId() {} // 0x000000018BCB7A64-0x000000018BCB7BB0
		internal bool LazyResolveBindings(bool fullResolve) => default; // 0x000000018BCB6EC4-0x000000018BCB6FC0
		internal bool ResolveBindingsIfNecessary() => default; // 0x000000018BCB6FC0-0x000000018BCB703C
		internal void ResolveBindings() {} // 0x000000018BCB703C-0x000000018BCB715C
		public int FindBinding(InputBinding mask, out InputAction action) {
			action = default;
			return default;
		} // 0x000000018BCB6DA0-0x000000018BCB6EC4
		internal int FindBindingRelativeToMap(InputBinding mask) => default; // 0x000000018BCB6CE8-0x000000018BCB6DA0
		public static InputActionMap[] FromJson(string json) => default; // 0x000000018BCC41D0-0x000000018BCC440C
		public static string ToJson(IEnumerable<InputActionMap> maps) => default; // 0x000000018BCC8FAC-0x000000018BCC9098
		public string ToJson() => default; // 0x000000018BCC9350-0x000000018BCC96E0
		public void OnBeforeSerialize() {} // 0x000000018BCC9098-0x000000018BCC9130
		public void OnAfterDeserialize() {} // 0x000000018BCC9130-0x000000018BCC9350
	}

	public static class InputActionRebindingExtensions // TypeDefIndex: 45048
	{
		// Fields
		private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x00
	
		// Nested types
		internal struct Parameter // TypeDefIndex: 45039
		{
			// Fields
			public object instance; // 0x00
			public System.Reflection.FieldInfo field; // 0x08
			public int bindingIndex; // 0x10
		}
	
		private struct ParameterEnumerable : IEnumerable<Parameter> // TypeDefIndex: 45040
		{
			// Fields
			private InputActionState m_State; // 0x00
			private ParameterOverride m_Parameter; // 0x08
			private int m_MapIndex; // 0x80
	
			// Constructors
			public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x0205BA13 */) {
				m_State = default;
				m_Parameter = default;
				m_MapIndex = default;
			} // 0x000000018BCBDC8C-0x000000018BCBDE74
	
			// Methods
			public ParameterEnumerator GetEnumerator() => default; // 0x000000018BCBDE74-0x000000018BCBE1D4
			IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() => default; // 0x000000018BCBE1D4-0x000000018BCBE478
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		private struct ParameterEnumerator : IEnumerator<Parameter> // TypeDefIndex: 45041
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
			public Parameter Current { get => default; } // 0x000000018BCBC6C0-0x000000018BCBC95C 
			object IEnumerator.Current { get => default; } // 0x000000018BCBBAC0-0x000000018BCBC2A8 
	
			// Constructors
			public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x0205BA14 */) : this() {
				m_State = default;
				m_MapIndex = default;
				m_BindingCurrentIndex = default;
				m_BindingEndIndex = default;
				m_InteractionCurrentIndex = default;
				m_InteractionEndIndex = default;
				m_ProcessorCurrentIndex = default;
				m_ProcessorEndIndex = default;
				m_BindingMask = default;
				m_ObjectType = default;
				m_ParameterName = default;
				m_MayBeInteraction = default;
				m_MayBeProcessor = default;
				m_MayBeComposite = default;
				m_CurrentBindingIsComposite = default;
				m_CurrentObject = default;
				m_CurrentParameter = default;
			}
	
			// Methods
			private bool MoveToNextBinding() => default;
			private bool MoveToNextInteraction() => default;
			private bool MoveToNextProcessor() => default;
			private bool FindParameter(object instance) => default; // 0x000000018BCBC4C4-0x000000018BCBC6C0
			public bool MoveNext() => default; // 0x000000018BCBC95C-0x000000018BCBCB90
			public void Reset() {} // 0x000000018BCBC2A8-0x000000018BCBC4C4
			public void Dispose() {} // 0x000000018BCBD8E0-0x000000018BCBDA2C
		}
	
		internal struct ParameterOverride // TypeDefIndex: 45042
		{
			// Fields
			public string objectRegistrationName; // 0x00
			public string parameter; // 0x08
			public InputBinding bindingMask; // 0x10
			public PrimitiveValue value; // 0x68
	
			// Properties
			public System.Type objectType { get => default; } // 0x000000018BCBDB40-0x000000018BCBDC8C 
	
			// Constructors
			public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default) : this() {
				objectRegistrationName = default;
				parameter = default;
				this.bindingMask = default;
				this.value = default;
			} // 0x000000018BCBDA2C-0x000000018BCBDB40
			public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default) : this() {
				this.objectRegistrationName = default;
				parameter = default;
				this.bindingMask = default;
				this.value = default;
			} // 0x000000018BCBD538-0x000000018BCBD73C
	
			// Methods
			public static ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName) => default; // 0x000000018BCBD73C-0x000000018BCBD8E0
			private static ParameterOverride? Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName) => default; // 0x000000018BCBD174-0x000000018BCBD32C
			private static ParameterOverride? PickMoreSpecificOne(ParameterOverride? first, ParameterOverride? second) => default; // 0x000000018BCBD32C-0x000000018BCBD538
		}
	
		public sealed class RebindingOperation : IDisposable // TypeDefIndex: 45045
		{
			// Fields
			public const float kDefaultMagnitudeThreshold = 0.2f; // Metadata: 0x0205BA1A
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
			public InputAction action { get => default; } // 0x000000018BCBAE0C-0x000000018BCBAF28 
			public InputBinding? bindingMask { get => default; } // 0x000000018BCBB030-0x000000018BCBB150 
			public InputControlList<InputControl> candidates { get => default; } // 0x000000018BCBB150-0x000000018BCBB248 
			public ReadOnlyArray<float> scores { get => default; } // 0x000000018BCBAF28-0x000000018BCBB030 
			public ReadOnlyArray<float> magnitudes { get => default; } // 0x000000018BCBB248-0x000000018BCBB39C 
			public InputControl selectedControl { get => default; } // 0x000000018BCBB39C-0x000000018BCBB57C 
			public bool started { get => default; } // 0x000000018BCBF37C-0x000000018BCBF458 
			public bool completed { get => default; } // 0x000000018BCBF290-0x000000018BCBF37C 
			public bool canceled { get => default; } // 0x000000018BCBF458-0x000000018BCBF544 
			public double startTime { get => default; } // 0x000000018BCBEEB8-0x000000018BCBF150 
			public float timeout { get => default; } // 0x000000018BCBF150-0x000000018BCBF290 
			public string expectedControlType { get => default; } // 0x000000018BCBB880-0x000000018BCBBAC0 
	
			// Nested types
			private enum Flags // TypeDefIndex: 45043
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
	
			private sealed class __c__DisplayClass32_0 // TypeDefIndex: 45044
			{
				// Fields
				public string group; // 0x10
	
				// Constructors
				public __c__DisplayClass32_0() {} // 0x000000018BCBCB90-0x000000018BCBCC18
	
				// Methods
				internal bool _WithTargetBinding_b__0(InputControlScheme x) => default; // 0x000000018BCBCC18-0x000000018BCBD174
			}
	
			// Constructors
			public RebindingOperation() {} // 0x000000018BCC75BC-0x000000018BCC75F4
	
			// Methods
			public RebindingOperation WithAction(InputAction action) => default; // 0x000000018BCBF544-0x000000018BCBF784
			public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true /* Metadata: 0x0205BA15 */) => default; // 0x000000018BCBB6DC-0x000000018BCBB880
			public RebindingOperation WithCancelingThrough(string binding) => default; // 0x000000018BCBB57C-0x000000018BCBB6DC
			public RebindingOperation WithCancelingThrough(InputControl control) => default; // 0x000000018BCBF784-0x000000018BCBFB14
			public RebindingOperation WithExpectedControlType(string layoutName) => default; // 0x000000018BCBFB14-0x000000018BCBFF10
			public RebindingOperation WithExpectedControlType(System.Type type) => default; // 0x000000018BCBACA4-0x000000018BCBAE0C
			public RebindingOperation WithExpectedControlType<TControl>()
				where TControl : InputControl => default; // 0x000000018BCBE828-0x000000018BCBE94C
			public RebindingOperation WithTargetBinding(int bindingIndex) => default; // 0x000000018BCBE94C-0x000000018BCBEA78
			public RebindingOperation WithBindingMask(InputBinding? bindingMask) => default; // 0x000000018BCBE478-0x000000018BCBE828
			public RebindingOperation WithBindingGroup(string group) => default; // 0x000000018BCBEA78-0x000000018BCBEEB8
			public RebindingOperation WithoutGeneralizingPathOfSelectedControl() => default; // 0x0000000184585C80-0x0000000184585D90
			public RebindingOperation WithRebindAddingNewBinding(string group = null) => default; // 0x000000018BCC2DDC-0x000000018BCC2E54
			public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) => default; // 0x000000018BCC2B44-0x000000018BCC2C64
			public RebindingOperation WithoutIgnoringNoisyControls() => default; // 0x000000018BCC2C64-0x000000018BCC2D20
			public RebindingOperation WithControlsHavingToMatchPath(string path) => default; // 0x000000018BCC2D20-0x000000018BCC2DDC
			public RebindingOperation WithControlsExcluding(string path) => default; // 0x000000018BCC3380-0x000000018BCC35C8
			public RebindingOperation WithTimeout(float timeInSeconds) => default; // 0x000000018BCC2FFC-0x000000018BCC3168
			public RebindingOperation OnComplete(Action<RebindingOperation> callback) => default; // 0x000000018BCC3168-0x000000018BCC31CC
			public RebindingOperation OnCancel(Action<RebindingOperation> callback) => default; // 0x000000018BCC31CC-0x000000018BCC3230
			public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback) => default; // 0x000000018BCC2E54-0x000000018BCC2F40
			public RebindingOperation OnGeneratePath(Func<InputControl, string> callback) => default; // 0x000000018BCC2F40-0x000000018BCC2FFC
			public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback) => default; // 0x000000018BCC3230-0x000000018BCC3320
			public RebindingOperation OnApplyBinding(Action<RebindingOperation, string> callback) => default; // 0x000000018BCC35C8-0x000000018BCC3614
			public RebindingOperation OnMatchWaitForAnother(float seconds) => default; // 0x000000018BCC3320-0x000000018BCC3380
			public RebindingOperation Start() => default; // 0x0000000185492010-0x0000000185492020
			public void Cancel() {} // 0x000000018BCC4138-0x000000018BCC41D0
			public void Complete() {} // 0x000000018BCC404C-0x000000018BCC4138
			public void AddCandidate(InputControl control, float score, float magnitude = -1f /* Metadata: 0x0205BA16 */) {} // 0x000000018BCC3FD0-0x000000018BCC404C
			public void RemoveCandidate(InputControl control) {} // 0x000000018BCC39CC-0x000000018BCC3C40
			public void Dispose() {} // 0x000000018BCC3614-0x000000018BCC39CC
			~RebindingOperation() {} // 0x000000018BCC3C40-0x000000018BCC3FD0
			public RebindingOperation Reset() => default; // 0x000000018346D130-0x000000018346D140
			private void HookOnEvent() {} // 0x0000000185FC3410-0x0000000185FC3450
			private void UnhookOnEvent() {} // 0x0000000185FD77B0-0x0000000185FD77D0
			private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCC82E8-0x000000018BCC835C
			private void SortCandidatesByScore() {} // 0x000000018BCC8274-0x000000018BCC82E8
			private static bool HavePathMatch(InputControl control, string[] paths, int pathCount) => default; // 0x000000018BCC835C-0x000000018BCC83B8
			private void HookOnAfterUpdate() {} // 0x000000018BCC83B8-0x000000018BCC83C4
			private void UnhookOnAfterUpdate() {} // 0x000000018BCC8244-0x000000018BCC8250
			private void OnAfterUpdate() {} // 0x000000018BCC8238-0x000000018BCC8244
			private void OnComplete() {} // 0x0000000185FCC5C0-0x0000000185FCC5D0
			private void OnCancel() {} // 0x0000000185FB8D20-0x0000000185FB8D30
			private void ResetAfterMatchCompleted() {} // 0x000000018BCC8250-0x000000018BCC8274
			private void ThrowIfRebindInProgress() {} // 0x000000018BCC7320-0x000000018BCC7468
			private string GeneratePathForControl(InputControl control) => default; // 0x000000018BCC7B58-0x000000018BCC7BA0
		}
	
		internal class DeferBindingResolutionWrapper : IDisposable // TypeDefIndex: 45046
		{
			// Constructors
			public DeferBindingResolutionWrapper() {} // 0x000000018BCC78D8-0x000000018BCC7A28
	
			// Methods
			public void Acquire() {} // 0x000000018BCC75F4-0x000000018BCC7688
			public void Dispose() {} // 0x000000018BCC7A28-0x000000018BCC7A80
		}
	
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 45047
		{
			// Fields
			public ReadOnlyArray<InputBinding> bindings; // 0x10
			public int firstPartIndex; // 0x20
			public string[] partStrings; // 0x28
			public int partCount; // 0x30
	
			// Constructors
			public __c__DisplayClass25_0() {}
	
			// Methods
			internal string _GetBindingDisplayString_b__0(string fragment) => default; // 0x000000018BCC7BCC-0x000000018BCC818C
		}
	
		// Methods
		public static PrimitiveValue? GetParameterValue(InputAction action, string name, InputBinding bindingMask = default) => default; // 0x000000018BCC7574-0x000000018BCC75BC
		private static PrimitiveValue? GetParameterValue(InputAction action, ParameterOverride parameterOverride) => default; // 0x000000018BCC7468-0x000000018BCC7574
		public static PrimitiveValue? GetParameterValue(InputAction action, string name, int bindingIndex) => default; // 0x0000000185FD77A0-0x0000000185FD77B0
		public static TValue? GetParameterValue<TObject, TValue>(InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default)
			where TValue : struct => default; // 0x000000018BCC7BA0-0x000000018BCC7BCC
		public static void ApplyParameterOverride<TObject, TValue>(InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {} // 0x000000018BCC7A80-0x000000018BCC7B58
		public static void ApplyParameterOverride<TObject, TValue>(InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {} // 0x000000018BCC818C-0x000000018BCC81AC
		public static void ApplyParameterOverride<TObject, TValue>(InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {} // 0x000000018BCC77B0-0x000000018BCC78D8
		private static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default, PrimitiveValue value = default) => default; // 0x000000018BCC7688-0x000000018BCC77B0
		public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x0000000185FD7790-0x0000000185FD77A0
		public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x000000018BCC5D1C-0x000000018BCC5D40
		public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x000000018BCC5948-0x000000018BCC596C
		public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) {} // 0x000000018BCC6C68-0x000000018BCC6C8C
		private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride) {} // 0x000000018BCC6C44-0x000000018BCC6C68
		public static int GetBindingIndex(InputAction action, InputBinding bindingMask) => default; // 0x000000018BCC5D40-0x000000018BCC5D64
		public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) => default; // 0x000000018BCC58EC-0x000000018BCC5910
		public static int GetBindingIndex(InputAction action, string group = null, string path = null) => default; // 0x0000000185FD7780-0x0000000185FD7790
		public static InputBinding? GetBindingForControl(InputAction action, InputControl control) => default; // 0x000000018BCC7050-0x000000018BCC71F8
		public static int GetBindingIndexForControl(InputAction action, InputControl control) => default; // 0x000000018BCC5414-0x000000018BCC5428
		public static string GetBindingDisplayString(InputAction action, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions) 0 /* Metadata: 0x0205BA0C */, string group = null) => default; // 0x000000018BCC5428-0x000000018BCC543C
		public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions) 0 /* Metadata: 0x0205BA0D */) => default; // 0x000000018BCC5284-0x000000018BCC5414
		public static string GetBindingDisplayString(InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions) 0 /* Metadata: 0x0205BA0E */) => default; // 0x000000018BCC6C8C-0x000000018BCC6D98
		public static string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions) 0 /* Metadata: 0x0205BA0F */) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x000000018BCC543C-0x000000018BCC54A0
		public static void ApplyBindingOverride(InputAction action, string newPath, string group = null, string path = null) {} // 0x000000018BCC54A0-0x000000018BCC5510
		public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) {} // 0x000000018BCC6E40-0x000000018BCC6F24
		public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) {} // 0x000000018BCC5778-0x000000018BCC5840
		public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) {} // 0x000000018BCC72C8-0x000000018BCC7320
		public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) => default; // 0x000000018BCC5D64-0x000000018BCC6C44
		public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) {} // 0x000000018BCC6F24-0x000000018BCC7050
		public static void RemoveBindingOverride(InputAction action, int bindingIndex) {} // 0x000000018BCC563C-0x000000018BCC56B0
		public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) {} // 0x000000018BCC56B0-0x000000018BCC5778
		private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) {} // 0x000000018BCC7264-0x000000018BCC72C8
		public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) {} // 0x000000018BCC5840-0x000000018BCC58EC
		public static void RemoveAllBindingOverrides(InputAction action) {} // 0x000000018BCC596C-0x000000018BCC5D1C
		public static void ApplyBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) {} // 0x000000018BCC5910-0x000000018BCC5948
		public static void RemoveBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) {} // 0x000000018BCC6D98-0x000000018BCC6E40
		public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) => default; // 0x000000018BCC71F8-0x000000018BCC7264
		public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) => default; // 0x000000018BCC5510-0x000000018BCC563C
		public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) => default; // 0x000000018BCC81AC-0x000000018BCC8238
		public static string SaveBindingOverridesAsJson(InputAction action) => default; // 0x0000000185492010-0x0000000185492020
		private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null) {} // 0x000000018BCD4A44-0x000000018BCD4A70
		public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting = true /* Metadata: 0x0205BA10 */) {} // 0x0000000184585D90-0x0000000184585DF0
		public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting = true /* Metadata: 0x0205BA11 */) {} // 0x0000000184634CA0-0x0000000184634D90
		private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) {} // 0x0000000185492010-0x0000000185492020
		public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex = -1 /* Metadata: 0x0205BA12 */) => default; // 0x0000000185492010-0x0000000185492020
		internal static DeferBindingResolutionWrapper DeferBindingResolution() => default; // 0x000000018BCD48F0-0x000000018BCD4A44
	}

	public enum InputActionPhase // TypeDefIndex: 45049
	{
		Disabled = 0,
		Waiting = 1,
		Started = 2,
		Performed = 3,
		Canceled = 4
	}

	[Serializable]
	public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference> // TypeDefIndex: 45050
	{
		// Fields
		private bool m_UseReference; // 0x00
		private InputAction m_Action; // 0x08
		private InputActionReference m_Reference; // 0x10
	
		// Properties
		public InputAction action { get => default; } // 0x000000018BCCBC0C-0x000000018BCCBC88 
		public InputActionReference reference { get => default; } // 0x000000018BCCBC88-0x000000018BCCBC98 
		internal InputAction serializedAction { get => default; } // 0x000000018357A260-0x000000018357A270 
		internal InputActionReference serializedReference { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public InputActionProperty(InputAction action) : this() {
			m_UseReference = default;
			m_Action = default;
			m_Reference = default;
		} // 0x000000018BCCBBB0-0x000000018BCCBBDC
		public InputActionProperty(InputActionReference reference) : this() {
			m_UseReference = default;
			m_Action = default;
			m_Reference = default;
		} // 0x000000018BCCBBDC-0x000000018BCCBC0C
	
		// Methods
		public bool Equals(InputActionProperty other) => default; // 0x000000018BCCB9A0-0x000000018BCCBA28
		public bool Equals(InputAction other) => default; // 0x000000018BCCBABC-0x000000018BCCBAD8
		public bool Equals(InputActionReference other) => default; // 0x000000018BCCBAD8-0x000000018BCCBB2C
		public override bool Equals(object obj) => default; // 0x000000018BCCBA28-0x000000018BCCBABC
		public override int GetHashCode() => default; // 0x000000018BCCBB2C-0x000000018BCCBBB0
		public static bool operator ==(InputActionProperty left, InputActionProperty right) => default; // 0x000000018BCCBC98-0x000000018BCCBCC4
		public static bool operator !=(InputActionProperty left, InputActionProperty right) => default; // 0x000000018BCCBCC4-0x000000018BCCBCF0
	}

	public class InputActionReference : ScriptableObject // TypeDefIndex: 45051
	{
		// Fields
		internal InputActionAsset m_Asset; // 0x18
		internal string m_ActionId; // 0x20
		[NonSerialized]
		private InputAction m_Action; // 0x28
	
		// Properties
		public InputActionAsset asset { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public InputAction action { get => default; } // 0x0000000184BFD250-0x0000000184BFD330 
	
		// Constructors
		public InputActionReference() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public void Set(InputAction action) {} // 0x000000018BCCC060-0x000000018BCCC180
		public void Set(InputActionAsset asset, string mapName, string actionName) {} // 0x000000018BCCC180-0x000000018BCCC448
		private void SetInternal(InputActionAsset asset, InputAction action) {} // 0x000000018BCCBEC8-0x000000018BCCC060
		public override string ToString() => default; // 0x000000018BCCC494-0x000000018BCCC68C
		internal static string GetDisplayName(InputAction action) => default; // 0x000000018BCCBD58-0x000000018BCCBDE4
		internal string ToDisplayName() => default; // 0x000000018BCCC448-0x000000018BCCC48C
		public static implicit operator InputAction(InputActionReference reference) => default; // 0x000000018BCCC68C-0x000000018BCCC6A8
		public static InputActionReference Create(InputAction action) => default; // 0x000000018BCCBCF0-0x000000018BCCBD58
		internal static void ResetCachedAction() {} // 0x000000018BCCBDE4-0x000000018BCCBEC8
		public InputAction ToInputAction() => default; // 0x000000018BCCC48C-0x000000018BCCC494
	}

	public static class InputActionSetupExtensions // TypeDefIndex: 45056
	{
		// Nested types
		public struct BindingSyntax // TypeDefIndex: 45052
		{
			// Fields
			private readonly InputActionMap m_ActionMap; // 0x00
			private readonly InputAction m_Action; // 0x08
			internal readonly int m_BindingIndexInMap; // 0x10
	
			// Properties
			public bool valid { get => default; } // 0x000000018BCCC998-0x000000018BCCCB90 
			public int bindingIndex { get => default; } // 0x000000018BCCC6A8-0x000000018BCCC998 
			public InputBinding binding { get => default; } // 0x000000018BCCEBCC-0x000000018BCCED4C 
	
			// Constructors
			internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null) : this() {
				m_ActionMap = default;
				m_Action = default;
				m_BindingIndexInMap = default;
			} // 0x000000018BCCED4C-0x000000018BCCEE78
	
			// Methods
			public BindingSyntax WithName(string name) => default; // 0x000000018BCCCB90-0x000000018BCCCF64
			public BindingSyntax WithPath(string path) => default; // 0x000000018BCCEE78-0x000000018BCCF1F8
			public BindingSyntax WithGroup(string group) => default; // 0x000000018BCCF1F8-0x000000018BCCF320
			public BindingSyntax WithGroups(string groups) => default; // 0x000000018BCCD0D8-0x000000018BCCD1D0
			public BindingSyntax WithInteraction(string interaction) => default; // 0x000000018BCCD540-0x000000018BCCD5F8
			public BindingSyntax WithInteractions(string interactions) => default; // 0x000000018BCCD2C0-0x000000018BCCD3E0
			public BindingSyntax WithInteraction<TInteraction>()
				where TInteraction : IInputInteraction => default; // 0x000000018BCCD5F8-0x000000018BCCD770
			public BindingSyntax WithProcessor(string processor) => default; // 0x000000018BCCD770-0x000000018BCCD8CC
			public BindingSyntax WithProcessors(string processors) => default; // 0x000000018BCCD1D0-0x000000018BCCD2C0
			public BindingSyntax WithProcessor<TProcessor>() => default; // 0x000000018BCCD3E0-0x000000018BCCD540
			public BindingSyntax Triggering(InputAction action) => default; // 0x000000018BCCD8CC-0x000000018BCCDAC8
			public BindingSyntax To(InputBinding binding) => default; // 0x000000018BCCCF64-0x000000018BCCD0D8
			public BindingSyntax NextBinding() => default; // 0x000000018BCCE768-0x000000018BCCE828
			public BindingSyntax PreviousBinding() => default; // 0x000000018BCCE4C4-0x000000018BCCE57C
			public BindingSyntax NextPartBinding(string partName) => default; // 0x000000018BCCE39C-0x000000018BCCE4C4
			public BindingSyntax PreviousPartBinding(string partName) => default; // 0x000000018BCCE05C-0x000000018BCCE170
			public BindingSyntax NextCompositeBinding(string compositeName = null) => default; // 0x000000018BCCE170-0x000000018BCCE28C
			public BindingSyntax PreviousCompositeBinding(string compositeName = null) => default; // 0x000000018BCCDF4C-0x000000018BCCE05C
			private BindingSyntax Iterate(bool next) => default; // 0x000000018BCCE28C-0x000000018BCCE39C
			private BindingSyntax IterateCompositeBinding(bool next, string compositeName) => default; // 0x000000018BCCE57C-0x000000018BCCE768
			private BindingSyntax IteratePartBinding(bool next, string partName) => default; // 0x000000018BCCE828-0x000000018BCCEA2C
			public void Erase() {} // 0x000000018BCCF460-0x000000018BCCF6EC
			public BindingSyntax InsertPartBinding(string partName, string path) => default; // 0x000000018BCCDAC8-0x000000018BCCDD7C
		}
	
		public struct CompositeSyntax // TypeDefIndex: 45053
		{
			// Fields
			private readonly InputAction m_Action; // 0x00
			private readonly InputActionMap m_ActionMap; // 0x08
			private int m_BindingIndexInMap; // 0x10
	
			// Properties
			public int bindingIndex { get => default; } // 0x000000018BCCDD7C-0x000000018BCCDF4C 
	
			// Constructors
			internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex) : this() {
				m_Action = default;
				m_ActionMap = default;
				m_BindingIndexInMap = default;
			} // 0x000000018BCCF320-0x000000018BCCF460
	
			// Methods
			public CompositeSyntax With(string name, string binding, string groups = null, string processors = null) => default; // 0x000000018BCCF6EC-0x000000018BCCF7BC
		}
	
		public struct ControlSchemeSyntax // TypeDefIndex: 45054
		{
			// Fields
			private readonly InputActionAsset m_Asset; // 0x00
			private readonly int m_ControlSchemeIndex; // 0x08
			private InputControlScheme m_ControlScheme; // 0x10
	
			// Constructors
			internal ControlSchemeSyntax(InputActionAsset asset, int index) {
				m_Asset = default;
				m_ControlSchemeIndex = default;
				m_ControlScheme = default;
			} // 0x000000018BCCF7BC-0x000000018BCCF8C4
			internal ControlSchemeSyntax(InputControlScheme controlScheme) {
				m_Asset = default;
				m_ControlSchemeIndex = default;
				m_ControlScheme = default;
			} // 0x000000018BCCF994-0x000000018BCCFA64
	
			// Methods
			public ControlSchemeSyntax WithBindingGroup(string bindingGroup) => default; // 0x000000018BCCF8C4-0x000000018BCCF994
			public ControlSchemeSyntax WithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCCEAFC-0x000000018BCCEBCC
			public ControlSchemeSyntax WithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCCEA2C-0x000000018BCCEAFC
			public ControlSchemeSyntax OrWithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCCB1D4-0x000000018BCCB22C
			public ControlSchemeSyntax OrWithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCCB0F4-0x000000018BCCB134
			public ControlSchemeSyntax WithRequiredDevice(string controlPath) => default; // 0x000000018BCCB134-0x000000018BCCB1D4
			public ControlSchemeSyntax WithOptionalDevice(string controlPath) => default; // 0x000000018BCCB0CC-0x000000018BCCB0F4
			public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) => default; // 0x000000018BCCAB94-0x000000018BCCAC68
			public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) => default; // 0x000000018BCCAC68-0x000000018BCCAD3C
			private string DeviceTypeToControlPath<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCCA474-0x000000018BCCA650
			public InputControlScheme Done() => default; // 0x000000018BCCA650-0x000000018BCCA804
			private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags) {} // 0x000000018BCCA804-0x000000018BCCA9E0
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 45055
		{
			// Fields
			public InputBinding binding; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BCCA9E0-0x000000018BCCAB94
	
			// Methods
			internal bool _RemoveAction_b__0(InputBinding b) => default;
		}
	
		// Methods
		public static InputActionMap AddActionMap(InputActionAsset asset, string name) => default; // 0x000000018BCCAD3C-0x000000018BCCAF18
		public static void AddActionMap(InputActionAsset asset, InputActionMap map) {} // 0x000000018BCCAF18-0x000000018BCCB0CC
		public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) {}
		public static void RemoveActionMap(InputActionAsset asset, string nameOrId) {} // 0x000000018BCCA2B4-0x000000018BCCA474
		public static InputAction AddAction(InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x0205BA30 */, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null) => default; // 0x000000018BCCA15C-0x000000018BCCA2B4
		public static void RemoveAction(InputAction action) {} // 0x000000018BCC9F4C-0x000000018BCC9F80
		public static void RemoveAction(InputActionAsset asset, string nameOrId) {} // 0x000000018BCCA054-0x000000018BCCA088
		public static BindingSyntax AddBinding(InputAction action, string path, string interactions = null, string processors = null, string groups = null) => default; // 0x000000018BCC9FBC-0x000000018BCCA054
		public static BindingSyntax AddBinding(InputAction action, InputControl control) => default; // 0x000000018BCCA0C4-0x000000018BCCA15C
		public static BindingSyntax AddBinding(InputAction action, InputBinding binding = default) => default; // 0x000000018BCC9F80-0x000000018BCC9FBC
		public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null) => default; // 0x000000018BCCA088-0x000000018BCCA0C4
		public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null) => default; // 0x000000018BCC9E64-0x000000018BCC9F4C
		public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null) => default; // 0x000000018BCC9B88-0x000000018BCC9CE8
		public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) => default; // 0x000000018BCC9CE8-0x000000018BCC9E64
		public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions = null, string processors = null) => default; // 0x000000018BCC9768-0x000000018BCC9914
		private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1 /* Metadata: 0x0205BA31 */) => default; // 0x000000018BCC9914-0x000000018BCC9B88
		public static BindingSyntax ChangeBinding(InputAction action, int index) => default; // 0x000000018BCCB448-0x000000018BCCB46C
		public static BindingSyntax ChangeBinding(InputAction action, string name) => default; // 0x000000018BCCB420-0x000000018BCCB448
		public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) => default; // 0x000000018BCCB22C-0x000000018BCCB420
		public static BindingSyntax ChangeBindingWithId(InputAction action, string id) => default; // 0x000000018BCCB974-0x000000018BCCB9A0
		public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) => default; // 0x000000018BCCB934-0x000000018BCCB974
		public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) => default; // 0x000000018BCCB778-0x000000018BCCB89C
		public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) => default;
		public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) => default;
		public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) => default;
		public static void Rename(InputAction action, string newName) {}
		public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) {} // 0x000000018BCCB8E8-0x000000018BCCB934
		public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) => default; // 0x000000018BCCB89C-0x000000018BCCB8E8
		public static void RemoveControlScheme(InputActionAsset asset, string name) {} // 0x000000018BCCB72C-0x000000018BCCB778
		public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) => default; // 0x000000018BCCB6E0-0x000000018BCCB72C
		public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) => default;
		public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) => default; // 0x000000018BCCB644-0x000000018BCCB6E0
		public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) => default; // 0x000000018BCCB46C-0x000000018BCCB644
		public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) => default; // 0x0000000185492010-0x0000000185492020
		public static InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) => default; // 0x000000018BCD4A70-0x000000018BCD4AFC
	}

	internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable // TypeDefIndex: 45067
	{
		// Fields
		public const int kInvalidIndex = -1; // Metadata: 0x0205BA42
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
		public int totalCompositeCount { get => default; } // 0x0000000185FC8460-0x0000000185FC8470 
		public int totalMapCount { get => default; } // 0x0000000185FCA580-0x0000000185FCA590 
		public int totalActionCount { get => default; } // 0x0000000181C44EA0-0x0000000181C44EB0 
		public int totalBindingCount { get => default; } // 0x0000000181C44EB0-0x0000000181C44EC0 
		public int totalInteractionCount { get => default; } // 0x0000000185FC3350-0x0000000185FC3360 
		public int totalControlCount { get => default; } // 0x0000000185FAFF60-0x0000000185FAFF70 
		public unsafe ActionMapIndices* mapIndices { get => default; } // 0x0000000185FBA150-0x0000000185FBA160 
		public unsafe TriggerState* actionStates { get => default; } // 0x0000000185FBA180-0x0000000185FBA190 
		public unsafe BindingState* bindingStates { get => default; } // 0x0000000181C9AC70-0x0000000181C9AC80 
		public unsafe InteractionState* interactionStates { get => default; } // 0x0000000181C9A5B0-0x0000000181C9A5C0 
		public unsafe int* controlIndexToBindingIndex { get => default; } // 0x0000000185FB3810-0x0000000185FB3820 
		public unsafe ushort* controlGroupingAndComplexity { get => default; } // 0x0000000185FB3820-0x0000000185FB3830 
		public unsafe float* controlMagnitudes { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public unsafe uint* enabledControls { get => default; } // 0x0000000185FB0620-0x0000000185FB0630 
		public bool isProcessingControlStateChange { get => default; } // 0x000000018BCD4694-0x000000018BCD469C 
	
		// Nested types
		internal struct InteractionState // TypeDefIndex: 45058
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
			public int triggerControlIndex { get => default; set {} } // 0x0000000183F80460-0x0000000183F80470 0x0000000185FB0570-0x0000000185FB0580
			public double startTime { get => default; set {} } // 0x0000000185FB06E0-0x0000000185FB06F0 0x0000000185FB0670-0x0000000185FB0680
			public double performedTime { get => default; set {} } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000183F80450-0x0000000183F80460
			public double timerStartTime { get => default; set {} } // 0x000000018349D710-0x000000018349D720 0x0000000185FB0530-0x0000000185FB0540
			public float timerDuration { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000181460F70-0x0000000181460F80
			public float totalTimeoutCompletionDone { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018349D730-0x000000018349D740
			public float totalTimeoutCompletionTimeRemaining { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x0000000185FB0510-0x0000000185FB0520
			public long timerMonitorIndex { get => default; set {} } // 0x0000000185FD78D0-0x0000000185FD78E0 0x0000000184BF9BE0-0x0000000184BF9C80
			public bool isTimerRunning { get => default; set {} } // 0x0000000184BF8180-0x0000000184BF82E0 0x0000000184BF9DD0-0x0000000184BF9EB0
			public InputActionPhase phase { get => default; set {} } // 0x000000018BCD0E0C-0x000000018BCD0E80 0x000000018BCD0BC8-0x000000018BCD0BD4
	
			// Nested types
			private enum Flags // TypeDefIndex: 45057
			{
				TimerRunning = 1
			}
		}
	
		internal struct BindingState // TypeDefIndex: 45060
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
			public int controlStartIndex { get => default; set {} } // 0x000000018BCD044C-0x000000018BCD05C8 0x000000018BCD0130-0x000000018BCD02D0
			public int controlCount { get => default; set {} } // 0x000000018BCD3528-0x000000018BCD3530 0x0000000184954360-0x00000001849544A0
			public int interactionStartIndex { get => default; set {} } // 0x000000018BCCFA64-0x000000018BCCFC14 0x000000018BCD1598-0x000000018BCD15E8
			public int interactionCount { get => default; set {} } // 0x0000000184BFA9B0-0x0000000184BFAAB0 0x000000018BCD1648-0x000000018BCD1B0C
			public int processorStartIndex { get => default; set {} } // 0x0000000184BF9B80-0x0000000184BF9BE0 0x000000018BCD27A8-0x000000018BCD2FA4
			public int processorCount { get => default; set {} } // 0x0000000184BFA920-0x0000000184BFA9B0 0x000000018BCD10D4-0x000000018BCD1140
			public int actionIndex { get => default; set {} } // 0x00000001849545B0-0x00000001849547E0 0x00000001849547E0-0x00000001849548E0
			public int mapIndex { get => default; set {} } // 0x00000001849548E0-0x00000001849549E0 0x0000000184BFC920-0x0000000184BFC950
			public int compositeOrCompositeBindingIndex { get => default; set {} } // 0x0000000185F82230-0x0000000185F82280 0x000000018BCD0BD4-0x000000018BCD0CD0
			public int triggerEventIdForComposite { get => default; set {} } // 0x000000018BCD0CD0-0x000000018BCD0D30 0x0000000184BFBE90-0x0000000184BFBF40
			public double pressTime { get => default; set {} } // 0x0000000184BFBCA0-0x0000000184BFBDA0 0x000000018BCD0700-0x000000018BCD0894
			public Flags flags { get => default; set {} } // 0x000000018BCD0AD4-0x000000018BCD0B34 0x000000018BCD0B34-0x000000018BCD0BC8
			public bool chainsWithNext { get => default; set {} } // 0x000000018BCD0894-0x000000018BCD0974 0x0000000184BFB570-0x0000000184BFB720
			public bool isEndOfChain { get => default; set {} } // 0x000000018BCD0974-0x000000018BCD0AD4 0x000000018BCD31DC-0x000000018BCD329C
			public bool isPartOfChain { get => default; } // 0x0000000184BFBB00-0x0000000184BFBB50 
			public bool isComposite { get => default; set {} } // 0x0000000184BFB770-0x0000000184BFB7B0 0x0000000184BFB730-0x0000000184BFB770
			public bool isPartOfComposite { get => default; set {} } // 0x0000000184BFBDA0-0x0000000184BFBE90 0x0000000184BFA150-0x0000000184BFA1D0
			public bool initialStateCheckPending { get => default; set {} } // 0x0000000184BFA760-0x0000000184BFA910 0x00000001845841B0-0x0000000184584200
			public bool wantsInitialStateCheck { get => default; set {} } // 0x000000018BCD3530-0x000000018BCD3578 0x0000000185FD7890-0x0000000185FD78D0
			public int partIndex { get => default; set {} } // 0x0000000185FD7860-0x0000000185FD7890 0x0000000185FD7850-0x0000000185FD7860
	
			// Nested types
			public enum Flags // TypeDefIndex: 45059
			{
				ChainsWithNext = 1,
				EndOfChain = 2,
				Composite = 4,
				PartOfComposite = 8,
				InitialStateCheckPending = 16,
				WantsInitialStateCheck = 32
			}
		}
	
		public struct TriggerState // TypeDefIndex: 45062
		{
			// Fields
			public const int kMaxNumMaps = 255; // Metadata: 0x0205BA4A
			public const int kMaxNumControls = 65535; // Metadata: 0x0205BA4C
			public const int kMaxNumBindings = 65535; // Metadata: 0x0205BA50
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
			public InputActionPhase phase { get => default; set {} } // 0x0000000184584D00-0x00000001845859D0 0x0000000184585A30-0x0000000184585C10
			public bool isDisabled { get => default; } // 0x000000018BCD32E0-0x000000018BCD3300 
			public bool isWaiting { get => default; } // 0x0000000184585FB0-0x0000000184586020 
			public bool isStarted { get => default; } // 0x0000000185FD7810-0x0000000185FD7840 
			public bool isPerformed { get => default; } // 0x0000000184584200-0x00000001845842E0 
			public bool isCanceled { get => default; } // 0x000000018BCD1B0C-0x000000018BCD1C48 
			public double time { get => default; set {} } // 0x000000018BCD1C48-0x000000018BCD1DD4 0x000000018BCD329C-0x000000018BCD32E0
			public double startTime { get => default; set {} } // 0x000000018BCD3300-0x000000018BCD3464 0x000000018BCD3464-0x000000018BCD3528
			public float magnitude { get => default; set {} } // 0x000000018BCCFC14-0x000000018BCD0130 0x00000001845849B0-0x0000000184584C30
			public bool haveMagnitude { get => default; } // 0x00000001845846B0-0x00000001845849B0 
			public int mapIndex { get => default; set {} } // 0x00000001845842E0-0x00000001845845E0 0x000000018BCD117C-0x000000018BCD11D4
			public int controlIndex { get => default; set {} } // 0x0000000184584610-0x00000001845846B0 0x000000018BCD11D4-0x000000018BCD1274
			public int bindingIndex { get => default; set {} } // 0x000000018BCD13E0-0x000000018BCD141C 0x000000018BCD141C-0x000000018BCD1478
			public int interactionIndex { get => default; set {} } // 0x000000018BCD1274-0x000000018BCD12B8 0x000000018BCD12B8-0x000000018BCD12F0
			public uint lastPerformedInUpdate { get => default; set {} } // 0x0000000185FD7840-0x0000000185FD7850 0x000000018BCD12F0-0x000000018BCD1368
			public uint lastCompletedInUpdate { get => default; set {} } // 0x000000018BCD1140-0x000000018BCD117C 0x000000018BCD2638-0x000000018BCD26F0
			public uint lastCanceledInUpdate { get => default; set {} } // 0x000000018BCD26F0-0x000000018BCD27A8 0x000000018BCD1478-0x000000018BCD1508
			public uint pressedInUpdate { get => default; set {} } // 0x000000018BCD1508-0x000000018BCD1598 0x000000018BCD15E8-0x000000018BCD1648
			public uint releasedInUpdate { get => default; set {} } // 0x000000018BCD21E0-0x000000018BCD23A0 
			public bool isPassThrough { get => default; set {} } // 0x000000018BCD0D30-0x000000018BCD0E0C
			public bool isButton { get => default; set {} } // 0x000000018BCD1368-0x000000018BCD13E0 
			public bool isPressed { get => default; set {} } // 0x000000018BCD1EE4-0x000000018BCD2018 0x000000018BCD1DD4-0x000000018BCD1EE4
			public bool mayNeedConflictResolution { get => default; set {} } // 0x000000018BCD2018-0x000000018BCD21E0 0x0000000184954FC0-0x00000001849550C0
			public bool hasMultipleConcurrentActuations { get => default; set {} } // 0x000000018BCD2FA4-0x000000018BCD31DC 0x0000000184BF9C80-0x0000000184BF9D10
			public bool inProcessing { get => default; set {} } // 0x000000018BCD23A0-0x000000018BCD24C4 0x0000000184BF9D10-0x0000000184BF9DD0
			public Flags flags { get => default; set {} } // 0x0000000184BF9EB0-0x0000000184BF9FB0 0x0000000184BFBB80-0x0000000184BFBCA0
	
			// Nested types
			public enum Flags // TypeDefIndex: 45061
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
	
		public struct ActionMapIndices // TypeDefIndex: 45063
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
	
		public struct UnmanagedMemory : IDisposable // TypeDefIndex: 45064
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
			public bool isAllocated { get => default; } // 0x000000018BCD24C4-0x000000018BCD2638 
			public int sizeInBytes { get => default; } // 0x000000018BCD0E80-0x000000018BCD10D4 
	
			// Methods
			public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) {} // 0x00000001849539B0-0x0000000184953B60
			public void Dispose() {} // 0x0000000184634930-0x0000000184634CA0
			public void CopyDataFrom(UnmanagedMemory memory) {} // 0x000000018BCD05C8-0x000000018BCD0700
			public UnmanagedMemory Clone() => default; // 0x000000018BCD02D0-0x000000018BCD044C
		}
	
		internal struct GlobalState // TypeDefIndex: 45065
		{
			// Fields
			internal InlinedArray<GCHandle> globalList; // 0x00
			internal CallbackArray<Action<object, InputActionChange>> onActionChange; // 0x18
			internal CallbackArray<Action<object>> onActionControlsChanged; // 0x68
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45066
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__140_0; // 0x08
			public static Action __9__140_1; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x0000000185D44750-0x0000000185D448A0
	
			// Methods
			internal void _SaveAndResetState_b__140_0(ref GlobalState state) {} // 0x000000018BCD469C-0x000000018BCD46B0
			internal void _SaveAndResetState_b__140_1() {} // 0x000000018BCD46D4-0x000000018BCD474C
		}
	
		// Constructors
		public InputActionState() {} // 0x000000018BCD476C-0x000000018BCD48B0
		static InputActionState() {} // 0x000000018BCD48B0-0x000000018BCD48F0
	
		// Methods
		public void Initialize(InputBindingResolver resolver) {} // 0x000000018BCD46B0-0x000000018BCD46D4
		private void ComputeControlGroupingIfNecessary() {} // 0x0000000185FB6C30-0x0000000185FB6C40
		public void ClaimDataFrom(InputBindingResolver resolver) {} // 0x0000000185FBD060-0x0000000185FBD070
		~InputActionState() {} // 0x0000000185FD4C40-0x0000000185FD4C50
		public void Dispose() {} // 0x000000018592CA70-0x000000018592D1B0
		private void Destroy(bool isFinalizing = false /* Metadata: 0x0205BA32 */) {} // 0x00000001835E3010-0x00000001835E3020
		public InputActionState Clone() => default; // 0x0000000185917FD0-0x0000000185917FF0
		object ICloneable.Clone() => default; // 0x0000000185BA6260-0x0000000185BA6280
		private bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001859A7ED0-0x00000001859A7EF0
		private bool CanUseDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001838F1DD0-0x00000001838F1DE0
		public bool HasEnabledActions() => default; // 0x00000001859A7EF0-0x00000001859A7F10
		private void FinishBindingCompositeSetups() {} // 0x000000018BCC9708-0x000000018BCC9720
		internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions) {} // 0x00000001859A7E70-0x00000001859A7E90
		public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve) {} // 0x0000000185FB6C30-0x0000000185FB6C40
		private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve) {} // 0x00000001859A7E90-0x00000001859A7EB0
		private bool IsActiveControl(int bindingIndex, int controlIndex) => default; // 0x0000000184584C50-0x0000000184584C70
		private int FindControlIndexOnBinding(int bindingIndex, InputControl control) => default; // 0x0000000185876A50-0x0000000185876A80
		private void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000185FB6C20-0x0000000185FB6C30
		private bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex) => default; // 0x00000001859A7EB0-0x00000001859A7ED0
		public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting /* Metadata: 0x0205BA33 */, bool hardReset = false /* Metadata: 0x0205BA34 */) {} // 0x0000000184BFAAC0-0x0000000184BFAAE0
		public ref TriggerState FetchActionState(InputAction action) => ref _refReturnTypeForFetchActionState; // 0x00000001858E32B0-0x00000001858E33C0
		private ref TriggerState _refReturnTypeForFetchActionState; // Dummy field
		public ActionMapIndices FetchMapIndices(InputActionMap map) => default; // 0x00000001813AE560-0x00000001813AE570
		public void EnableAllActions(InputActionMap map) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		private void EnableControls(InputActionMap map) {} // 0x0000000185FC3350-0x0000000185FC3360
		public void EnableSingleAction(InputAction action) {} // 0x0000000185FAFF60-0x0000000185FAFF70
		private void EnableControls(InputAction action) {} // 0x0000000185FB6C60-0x0000000185FB6C70
		public void DisableAllActions(InputActionMap map) {} // 0x0000000185FBF450-0x0000000185FBF460
		public void DisableControls(InputActionMap map) {} // 0x000000018BCC96E0-0x000000018BCC96E8
		public void DisableSingleAction(InputAction action) {} // 0x000000018BCC9720-0x000000018BCC9744
		private void DisableControls(InputAction action) {} // 0x000000018BCC96E8-0x000000018BCC96F4
		private void EnableControls(int mapIndex, int controlStartIndex, int numControls) {} // 0x000000018BCC9744-0x000000018BCC9768
		private void DisableControls(int mapIndex, int controlStartIndex, int numControls) {} // 0x000000018BCC96F4-0x000000018BCC9708
		public void SetInitialStateCheckPending(int actionIndex, bool value = true /* Metadata: 0x0205BA35 */) {} // 0x0000000184BFAAB0-0x0000000184BFAAC0
		private unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) {} // 0x00000001859C08C0-0x00000001859C08F0
		private bool IsControlEnabled(int controlIndex) => default; // 0x0000000184585EB0-0x0000000184585EC0
		private void SetControlEnabled(int controlIndex, bool state) {} // 0x00000001859F30E0-0x00000001859F3110
		private void HookOnBeforeUpdate() {} // 0x0000000184BFA910-0x0000000184BFA920
		private void UnhookOnBeforeUpdate() {} // 0x0000000184BFBB50-0x0000000184BFBB80
		private void OnBeforeInitialUpdate() {} // 0x0000000184BFB720-0x0000000184BFB730
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex) {} // 0x00000001859E9610-0x00000001859E9640
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex) {} // 0x0000000185FB6C70-0x0000000185FB6C80
		private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) => default; // 0x00000001859A7F20-0x00000001859A7F30
		private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) {
			mapIndex = default;
			controlIndex = default;
			bindingIndex = default;
		} // 0x00000001835E3010-0x00000001835E3020
		internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex) => default; // 0x0000000185FB0F60-0x0000000185FB0F70
		private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr) {} // 0x0000000184584CC0-0x0000000184584CD0
		private unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) {} // 0x000000018B911E4C-0x000000018B911E54
		private static unsafe bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) => default; // 0x000000018B911E54-0x000000018B911E5C
		private bool IsConflictingInput(ref TriggerState trigger, int actionIndex) => default; // 0x000000018BCD4764-0x000000018BCD476C
		private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount) {
			bindingCount = default;
			return default;
		} // 0x000000018BCD475C-0x000000018BCD4764
		private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex) {} // 0x0000000185FC8460-0x0000000185FC8470
		private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount) {} // 0x0000000185FCA580-0x0000000185FCA590
		private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) {} // 0x0000000185FC3350-0x0000000185FC3360
		internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger) {} // 0x0000000185FAFF60-0x0000000185FAFF70
		internal void StartTimeout(float seconds, ref TriggerState trigger) {} // 0x0000000185FB0850-0x0000000185FB0860
		private void StopTimeout(int interactionIndex) {} // 0x0000000185FD78E0-0x0000000185FD78F0
		internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting /* Metadata: 0x0205BA36 */, InputActionPhase phaseAfterCanceled = InputActionPhase.Waiting /* Metadata: 0x0205BA37 */, bool processNextInteractionOnCancel = true /* Metadata: 0x0205BA38 */) {} // 0x000000018BCD4754-0x000000018BCD475C
		private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting /* Metadata: 0x0205BA39 */) => default; // 0x0000000185FB6C30-0x0000000185FB6C40
		private unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false /* Metadata: 0x0205BA3A */) {} // 0x0000000184585F00-0x0000000184585F20
		private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName) {} // 0x0000000184585C50-0x0000000184585C70
		private object GetActionOrNoneString(ref TriggerState trigger) => default; // 0x0000000184585F80-0x0000000184585FB0
		internal InputAction GetActionOrNull(int bindingIndex) => default; // 0x0000000185FD4BE0-0x0000000185FD4BF0
		internal InputAction GetActionOrNull(ref TriggerState trigger) => default; // 0x0000000184585EE0-0x0000000184585F00
		internal InputControl GetControl(ref TriggerState trigger) => default; // 0x0000000184584C30-0x0000000184584C50
		private IInputInteraction GetInteractionOrNull(ref TriggerState trigger) => default; // 0x0000000184585EC0-0x0000000184585EE0
		internal int GetBindingIndexInMap(int bindingIndex) => default; // 0x00000001813B88B0-0x00000001813B88C0
		internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) => default; // 0x00000001813B9430-0x00000001813B9440
		internal ref BindingState GetBindingState(int bindingIndex) => ref _refReturnTypeForGetBindingState; // 0x00000001813CFF60-0x00000001813CFF70
		private ref BindingState _refReturnTypeForGetBindingState; // Dummy field
		internal ref InputBinding GetBinding(int bindingIndex) => ref _refReturnTypeForGetBinding; // 0x00000001813D0A90-0x00000001813D0AA0
		private ref InputBinding _refReturnTypeForGetBinding; // Dummy field
		internal InputActionMap GetActionMap(int bindingIndex) => default; // 0x0000000181424480-0x0000000181424490
		private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) {} // 0x0000000181424940-0x0000000181424950
		private void ResetInteractionState(int interactionIndex) {} // 0x0000000181C9AC80-0x0000000181C9AC90
		internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) => default; // 0x0000000181C9A5C0-0x0000000181C9A5D0
		internal System.Type GetValueType(int bindingIndex, int controlIndex) => default; // 0x0000000185FB0630-0x0000000185FB0640
		internal static bool IsActuated(ref TriggerState trigger, float threshold = 0f /* Metadata: 0x0205BA3B */) => default; // 0x0000000185FB0640-0x0000000185FB0650
		internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false /* Metadata: 0x0205BA3F */) {} // 0x0000000184584CB0-0x0000000184584CC0
		internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0205BA40 */)
			where TValue : struct => default; // 0x0000000184585F50-0x0000000184585F80
		internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null)
			where TValue : struct => default; // 0x0000000184585EA0-0x0000000184585EB0
		public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) => default; // 0x0000000184585F20-0x0000000184585F50
		internal double GetCompositePartPressTime(int bindingIndex, int partNumber) => default; // 0x0000000184585C70-0x0000000184585C80
		internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> {
			controlIndex = default;
			return default;
		} // 0x0000000184954A60-0x0000000184954A90
		internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize) => default; // 0x0000000184586020-0x0000000184586030
		internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) => default; // 0x0000000185D78A20-0x0000000185D78A50
		internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x0205BA41 */) => default; // 0x000000018BCD474C-0x000000018BCD4754
		internal bool ReadValueAsButton(int bindingIndex, int controlIndex) => default; // 0x0000000184954A40-0x0000000184954A60
		internal static ISavedState SaveAndResetState() => default; // 0x0000000184584CA0-0x0000000184584CB0
		private void AddToGlobalList() {} // 0x0000000184584CD0-0x0000000184584D00
		private void RemoveMapFromGlobalList() {} // 0x00000001838F1DD0-0x00000001838F1DE0
		private static void CompactGlobalList() {} // 0x00000001838F1DE0-0x00000001838F1DF0
		internal void NotifyListenersOfActionChange(InputActionChange change) {} // 0x0000000184443DF0-0x0000000184443E00
		internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) {} // 0x0000000185896C00-0x0000000185896C40
		private static void ResetGlobals() {} // 0x0000000185896A80-0x0000000185896C00
		internal static int FindAllEnabledActions(List<InputAction> result) => default; // 0x0000000185C45C30-0x0000000185C45C90
		internal static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018596F290-0x000000018596F3E0
		internal static void DeferredResolutionOfBindings() {} // 0x000000018BCD4BC4-0x000000018BCD4E1C
		internal static void DisableAllActions() {} // 0x000000018BCD4B60-0x000000018BCD4BC4
		internal static void DestroyAllActionMapStates() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum InputActionType // TypeDefIndex: 45068
	{
		Value = 0,
		Button = 1,
		PassThrough = 2
	}

	[Serializable]
	public struct InputBinding : IEquatable<InputBinding> // TypeDefIndex: 45073
	{
		// Fields
		public const char Separator = ';'; // Metadata: 0x0205BA62
		internal const string kSeparatorString = ";"; // Metadata: 0x0205BA64
		private string m_Name; // 0x00
		internal string m_Id; // 0x08
		private string m_Path; // 0x10
		private string m_Interactions; // 0x18
		private string m_Processors; // 0x20
		internal string m_Groups; // 0x28
		private string m_Action; // 0x30
		internal Flags m_Flags; // 0x38
		[NonSerialized]
		private string m_OverridePath; // 0x40
		[NonSerialized]
		private string m_OverrideInteractions; // 0x48
		[NonSerialized]
		private string m_OverrideProcessors; // 0x50
	
		// Properties
		public string name { get => default; set {} } // 0x000000018BCD4630-0x000000018BCD465C 0x000000018346D130-0x000000018346D140
		public Guid id { get => default; set {} } // 0x0000000184096E30-0x0000000184096EF0 0x00000001813FF010-0x00000001813FF020
		public string path { get => default; set {} } // 0x0000000185F05C80-0x0000000185F05C90 0x0000000181377E40-0x0000000181377E50
		public string overridePath { get => default; set {} } // 0x0000000184088E70-0x0000000184088E80 0x00000001813ECF20-0x00000001813ECF30
		public string interactions { get => default; set {} } // 0x000000018571FEC0-0x000000018571FED0 0x00000001813B31A0-0x00000001813B31B0
		public string overrideInteractions { get => default; set {} } // 0x000000018646EE40-0x000000018646EE50 0x0000000181460F60-0x0000000181460F70
		public string processors { get => default; set {} } // 0x0000000184A4E570-0x0000000184A4E580 0x00000001813B8590-0x00000001813B85A0
		public string overrideProcessors { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x00000001813B51D0-0x00000001813B51E0
		public string groups { get => default; set {} } // 0x00000001864721F0-0x0000000186472200 0x0000000184D592A0-0x0000000184D59340
		public string action { get => default; set {} } // 0x000000018BCD465C-0x000000018BCD4678 0x000000018587EE90-0x000000018587EEA0
		public bool isComposite { get => default; set {} } // 0x000000018BCD4678-0x000000018BCD4694 0x000000018BCD44A8-0x000000018BCD44C4
		public bool isPartOfComposite { get => default; set {} } // 0x000000018BCD4404-0x000000018BCD44A8 0x000000018BCD3C50-0x000000018BCD3C80
		public bool hasOverrides { get => default; } // 0x000000018BCD3AF0-0x000000018BCD3B34 
		public string effectivePath { get => default; } // 0x000000018BCD4510-0x000000018BCD4554 
		public string effectiveInteractions { get => default; } // 0x000000018BCD3A08-0x000000018BCD3AF0 
		public string effectiveProcessors { get => default; } // 0x000000018BCD3964-0x000000018BCD3A08 
		internal bool isEmpty { get => default; } // 0x000000018BCD4554-0x000000018BCD45A4 
	
		// Nested types
		public enum DisplayStringOptions // TypeDefIndex: 45069
		{
			DontUseShortDisplayNames = 1,
			DontOmitDevice = 2,
			DontIncludeInteractions = 4,
			IgnoreBindingOverrides = 8
		}
	
		internal enum MatchOptions // TypeDefIndex: 45070
		{
			EmptyGroupMatchesAny = 1
		}
	
		internal enum Flags // TypeDefIndex: 45071
		{
			None = 0,
			Composite = 4,
			PartOfComposite = 8
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45072
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__45_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001834AFB60-0x00000001834AFB70
			public __c() {} // 0x000000018646FE2C-0x000000018646FE34
	
			// Methods
			internal bool _MaskByGroups_b__45_0(string x) => default; // 0x000000018BCD44C4-0x000000018BCD4510
		}
	
		// Constructors
		public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null) : this() {
			m_Name = default;
			m_Id = default;
			m_Path = default;
			m_Interactions = default;
			m_Processors = default;
			m_Groups = default;
			m_Action = default;
			m_Flags = default;
			m_OverridePath = default;
			m_OverrideInteractions = default;
			m_OverrideProcessors = default;
		} // 0x000000018BCD3F78-0x000000018BCD3FB0
	
		// Methods
		public string GetNameOfComposite() => default; // 0x000000018BCD3C80-0x000000018BCD3CB8
		internal void GenerateId() {} // 0x000000018BCD3CB8-0x000000018BCD3E14
		internal void RemoveOverrides() {} // 0x00000001841133B0-0x00000001841133C0
		public static InputBinding MaskByGroup(string group) => default; // 0x0000000185B8AE40-0x0000000185B8AE50
		public static InputBinding MaskByGroups(string[] groups) => default; // 0x00000001859A7F10-0x00000001859A7F20
		public bool Equals(InputBinding other) => default; // 0x000000018BCD45A4-0x000000018BCD4630
		public override bool Equals(object obj) => default; // 0x000000018BCD3B34-0x000000018BCD3C50
		public static bool operator ==(InputBinding left, InputBinding right) => default; // 0x000000018BCD42BC-0x000000018BCD43B0
		public static bool operator !=(InputBinding left, InputBinding right) => default; // 0x000000018BCD4288-0x000000018BCD42BC
		public override int GetHashCode() => default; // 0x000000018BCD3FB0-0x000000018BCD4288
		public override string ToString() => default; // 0x000000018BCD43B0-0x000000018BCD4404
		public string ToDisplayString(DisplayStringOptions options = (DisplayStringOptions) 0 /* Metadata: 0x0205BA5F */, InputControl control = null) => default; // 0x000000018BCD3E14-0x000000018BCD3E28
		public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options = (DisplayStringOptions) 0 /* Metadata: 0x0205BA60 */, InputControl control = null) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x000000018BCD3E28-0x000000018BCD3F78
		internal bool TriggersAction(InputAction action) => default; // 0x000000018BCD4AFC-0x000000018BCD4B60
		public bool Matches(InputBinding binding) => default; // 0x0000000185492010-0x0000000185492020
		internal bool Matches(ref InputBinding binding, MatchOptions options = (MatchOptions) 0 /* Metadata: 0x0205BA61 */) => default; // 0x00000001813AC160-0x00000001813AC180
	}

	public abstract class InputBindingComposite // TypeDefIndex: 45075
	{
		// Fields
		internal static TypeTable s_Composites; // 0x00
	
		// Properties
		public abstract System.Type valueType { get; } // 0x000000018BCD3664-0x000000018BCD37E8 
		public abstract int valueSizeInBytes { get; } // 0x000000018BCD37E8-0x000000018BCD3858 
	
		// Nested types
		private sealed class _GetPartNames_d__12 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 45074
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
			string IEnumerator<System.String>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _GetPartNames_d__12() {} // Dummy constructor
			public _GetPartNames_d__12(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {} // 0x0000000185FD5E00-0x0000000185FD5E10
			IEnumerator<string> IEnumerable<string>.GetEnumerator() => default; // 0x00000001864720C8-0x0000000186472104
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCD3858-0x000000018BCD3964
		}
	
		// Constructors
		protected InputBindingComposite() {} // 0x000000018BCF8004-0x000000018BCF800C
	
		// Methods
		public abstract unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize); // 0x000000018BCD3578-0x000000018BCD3664
		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context); // 0x0000000185492010-0x0000000185492020
		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000184775050-0x0000000184775070
		protected virtual void FinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000185492010-0x0000000185492020
		internal void CallFinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018BCF7DD8-0x000000018BCF7F70
		internal static System.Type GetValueType(string composite) => default; // 0x0000000181377E40-0x0000000181377E50
		public static string GetExpectedControlLayoutName(string composite, string part) => default; // 0x000000018BCF800C-0x000000018BCF8058
		internal static IEnumerable<string> GetPartNames(string composite) => default; // 0x0000000181377E40-0x0000000181377E50
		internal static string GetDisplayFormatString(string composite) => default; // 0x000000018BCF7F70-0x000000018BCF8004
	}

	public abstract class InputBindingComposite<TValue> : InputBindingComposite // TypeDefIndex: 45076
		where TValue : struct
	{
		// Properties
		public override System.Type valueType { get; }
		public override int valueSizeInBytes { get; }
	
		// Constructors
		protected InputBindingComposite() {}
	
		// Methods
		public abstract TValue ReadValue(ref InputBindingCompositeContext context);
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) {}
		public override object ReadValueAsObject(ref InputBindingCompositeContext context) => default;
	}

	public struct InputBindingCompositeContext // TypeDefIndex: 45080
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal int m_BindingIndex; // 0x08
	
		// Properties
		public IEnumerable<PartBinding> controls { get => default; } // 0x00000001877900A4-0x00000001877900B4 
	
		// Nested types
		public struct PartBinding // TypeDefIndex: 45077
		{
			// Fields
			private int _part_k__BackingField; // 0x00
			private InputControl _control_k__BackingField; // 0x08
	
			// Properties
			public int part { get; set; } // 0x000000018BCEAB0C-0x000000018BCEAB80 0x000000018BCEA9D4-0x000000018BCEAA00
			public InputControl control { get; set; }
		}
	
		private struct DefaultComparer<TValue> : IComparer<TValue> // TypeDefIndex: 45078
			where TValue : IComparable<TValue>
		{
			// Methods
			public int Compare(TValue x, TValue y) => default;
		}
	
		private sealed class _get_controls_d__2 : IEnumerable<PartBinding>, IEnumerator<PartBinding> // TypeDefIndex: 45079
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
			PartBinding IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current { get => default; } // 0x000000018BCEAAB4-0x000000018BCEAAE0 
			object IEnumerator.Current { get => default; } // 0x00000001818226B0-0x00000001818226C0 
	
			// Constructors
			public _get_controls_d__2() {} // Dummy constructor
			public _get_controls_d__2(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCEAA2C-0x000000018BCEAAB4
			private bool MoveNext() => default; // 0x000000018BCEAAE0-0x000000018BCEAB0C
			void IEnumerator.Reset() {} // 0x000000018BCEAA00-0x000000018BCEAA2C
			IEnumerator<PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() => default; // 0x00000001818AA390-0x00000001818AA3A0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018357A260-0x000000018357A270
		}
	
		// Methods
		public float EvaluateMagnitude(int partNumber) => default;
		public TValue ReadValue<TValue>(int partNumber)
			where TValue : struct, IComparable<TValue> => default; // 0x00000001853410F0-0x0000000185341110
		public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl)
			where TValue : struct, IComparable<TValue> {
			sourceControl = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> => default; // 0x000000018BCF84A0-0x000000018BCF85CC
		public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> {
			sourceControl = default;
			return default;
		} // 0x0000000185FB30D0-0x0000000185FB30E0
		public bool ReadValueAsButton(int partNumber) => default; // 0x000000018BCF8668-0x000000018BCF86B4
		public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize) {} // 0x000000018BCF86B4-0x000000018BCF87D4
		public object ReadValueAsObject(int partNumber) => default; // 0x000000018BCF85CC-0x000000018BCF8660
		public double GetPressTime(int partNumber) => default; // 0x000000018BCF8660-0x000000018BCF8668
	}

	internal struct InputBindingResolver : IDisposable // TypeDefIndex: 45081
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
		public int totalMapCount { get => default; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public int totalActionCount { get => default; } // 0x0000000185FB0630-0x0000000185FB0640 
		public int totalBindingCount { get => default; } // 0x0000000185FB07C0-0x0000000185FB07D0 
		public int totalControlCount { get => default; } // 0x00000001813E5E30-0x00000001813E5E40 
	
		// Methods
		public void Dispose() {} // 0x000000018BCEAB80-0x000000018BCEAB8C
		public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) {} // 0x000000018BCEAB8C-0x000000018BCEAD00
		public void AddActionMap(InputActionMap actionMap) {} // 0x0000000184586A60-0x0000000184588D90
		private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) => default;
		private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) => default; // 0x0000000184113220-0x00000001841133B0
		private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) {} // 0x00000001841136B0-0x0000000184113BF0
		private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) => default; // 0x00000001856D7BF0-0x00000001856D7D60
	}

	[Serializable]
	public struct InputControlScheme : IEquatable<InputControlScheme> // TypeDefIndex: 45090
	{
		// Fields
		internal string m_Name; // 0x00
		internal string m_BindingGroup; // 0x08
		internal DeviceRequirement[] m_DeviceRequirements; // 0x10
	
		// Properties
		public string name { get => default; } // 0x000000018BCEA078-0x000000018BCEA094 
		public string bindingGroup { get => default; set {} } // 0x000000018BCE9FE8-0x000000018BCE9FF0 0x000000018BCEA040-0x000000018BCEA05C
		public ReadOnlyArray<DeviceRequirement> deviceRequirements { get => default; } // 0x000000018BCE9FF0-0x000000018BCE9FF8 
	
		// Nested types
		public struct MatchResult : IEnumerable<MatchResult.Match>, IDisposable // TypeDefIndex: 45085
		{
			// Fields
			internal Result m_Result; // 0x00
			internal float m_Score; // 0x04
			internal InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices; // 0x08
			internal InputControlList<InputControl> m_Controls; // 0x28
			internal DeviceRequirement[] m_Requirements; // 0x48
	
			// Properties
			public float score { get => default; }
			public bool isSuccessfulMatch { get => default; } // 0x000000018BCEE800-0x000000018BCEE9C8 
			public bool hasMissingRequiredDevices { get => default; } // 0x000000018BCEE9C8-0x000000018BCEEA40 
			public bool hasMissingOptionalDevices { get => default; } // 0x000000018BCEEA40-0x000000018BCEEAC4 
			public InputControlList<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x000000018BCEEC34-0x000000018BCEED8C 
			public Match this[int index] { get => default; } // 0x000000018BCEEEFC-0x000000018BCEEF28 
	
			// Nested types
			internal enum Result // TypeDefIndex: 45082
			{
				AllSatisfied = 0,
				MissingRequired = 1,
				MissingOptional = 2
			}
	
			public struct Match // TypeDefIndex: 45083
			{
				// Fields
				internal int m_RequirementIndex; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public InputControl control { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
				public UnityEngine.InputSystem.InputDevice device { get => default; } // 0x000000018357A260-0x000000018357A270 
				public int requirementIndex { get => default; } // 0x00000001877900A4-0x00000001877900B4 
				public DeviceRequirement requirement { get => default; } // 0x000000018BCEEEA8-0x000000018BCEEEFC 
				public bool isOptional { get => default; } // 0x000000018BCEED8C-0x000000018BCEEEA8 
			}
	
			private struct Enumerator : IEnumerator<Match> // TypeDefIndex: 45084
			{
				// Fields
				internal int m_Index; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public Match Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Methods
				public bool MoveNext() => default; // 0x000000018BCEEAC4-0x000000018BCEEB78
				public void Reset() {}
				public void Dispose() {} // 0x000000018BCEEB78-0x000000018BCEEC34
			}
	
			// Methods
			public IEnumerator<Match> GetEnumerator() => default; // 0x000000018BCEEF28-0x000000018BCEEF54
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FBA150-0x0000000185FBA160
			public void Dispose() {} // 0x000000018A984930-0x000000018A984938
		}
	
		[Serializable]
		public struct DeviceRequirement : IEquatable<DeviceRequirement> // TypeDefIndex: 45087
		{
			// Fields
			internal string m_ControlPath; // 0x00
			internal Flags m_Flags; // 0x08
	
			// Properties
			public string controlPath { get => default; set {} } // 0x0000000187E83D88-0x0000000187E83D90 0x0000000187E83D78-0x0000000187E83D80
			public bool isOptional { get => default; set {} } // 0x000000018BCF614C-0x000000018BCF6270 0x000000018BCF6094-0x000000018BCF614C
			public bool isAND { get => default; set {} } // 0x000000018BCF5FF8-0x000000018BCF608C 0x000000018BCF608C-0x000000018BCF6094
			public bool isOR { get => default; set {} } // 0x000000018BCF5FA0-0x000000018BCF5FF8 0x000000018BCF6270-0x000000018BCF62AC
	
			// Nested types
			internal enum Flags // TypeDefIndex: 45086
			{
				None = 0,
				Optional = 1,
				Or = 2
			}
	
			// Methods
			public override string ToString() => default; // 0x000000018BCF62AC-0x000000018BCF62C8
			public bool Equals(DeviceRequirement other) => default; // 0x00000001818226B0-0x00000001818226C0
			public override bool Equals(object obj) => default; // 0x000000018BCF62EC-0x000000018BCF631C
			public override int GetHashCode() => default; // 0x000000018BCF62C8-0x000000018BCF62EC
			public static bool operator ==(DeviceRequirement left, DeviceRequirement right) => default; // 0x000000018BCEA094-0x000000018BCEA0B0
			public static bool operator !=(DeviceRequirement left, DeviceRequirement right) => default; // 0x0000000185FD7D90-0x0000000185FD7DA0
		}
	
		[Serializable]
		internal struct SchemeJson // TypeDefIndex: 45089
		{
			// Fields
			public string name; // 0x00
			public string bindingGroup; // 0x08
			public DeviceJson[] devices; // 0x10
	
			// Nested types
			[Serializable]
			public struct DeviceJson // TypeDefIndex: 45088
			{
				// Fields
				public string devicePath; // 0x00
				public bool isOptional; // 0x08
				public bool isOR; // 0x09
	
				// Methods
				public DeviceRequirement ToDeviceEntry() => default; // 0x000000018BCEA11C-0x000000018BCEA1D4
				public static DeviceJson From(DeviceRequirement requirement) => default; // 0x000000018BCEA0B0-0x000000018BCEA11C
			}
	
			// Methods
			public InputControlScheme ToScheme() => default; // 0x0000000185492010-0x0000000185492020
			public static SchemeJson ToJson(InputControlScheme scheme) => default; // 0x00000001834AFB60-0x00000001834AFB70
			public static SchemeJson[] ToJson(InputControlScheme[] schemes) => default; // 0x000000018646FE2C-0x000000018646FE34
			public static InputControlScheme[] ToSchemes(SchemeJson[] schemes) => default; // 0x000000018BCE9FF8-0x000000018BCEA000
		}
	
		// Constructors
		public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null) : this() {
			m_Name = default;
			m_BindingGroup = default;
			m_DeviceRequirements = default;
		} // 0x000000018BCEA05C-0x000000018BCEA078
	
		// Methods
		internal void SetNameAndBindingGroup(string name, string bindingGroup = null) {} // 0x000000018BCE9F50-0x000000018BCE9FE8
		public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false /* Metadata: 0x0205BA6E */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme> => default; // 0x000000018BCE9DE0-0x000000018BCE9E3C
		public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false /* Metadata: 0x0205BA6F */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme> {
			controlScheme = default;
			matchResult = default;
			return default;
		} // 0x000000018BCE9E3C-0x000000018BCE9EAC
		public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
			where TSchemes : IEnumerable<InputControlScheme> => default; // 0x000000018BCE9EAC-0x000000018BCE9F50
		public bool SupportsDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BCEA000-0x000000018BCEA020
		public MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice = null)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice> => default; // 0x000000018BCEA020-0x000000018BCEA040
		public bool Equals(InputControlScheme other) => default; // 0x000000018BCF770C-0x000000018BCF785C
		public override bool Equals(object obj) => default; // 0x000000018BCF7470-0x000000018BCF760C
		public override int GetHashCode() => default; // 0x000000018BCF760C-0x000000018BCF770C
		public override string ToString() => default; // 0x000000018BCF785C-0x000000018BCF7934
		public static bool operator ==(InputControlScheme left, InputControlScheme right) => default; // 0x000000018BCE9D94-0x000000018BCE9DE0
		public static bool operator !=(InputControlScheme left, InputControlScheme right) => default; // 0x000000018BCE9D58-0x000000018BCE9D94
	}

	public struct InputInteractionContext // TypeDefIndex: 45092
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal Flags m_Flags; // 0x08
		internal InputActionState.TriggerState m_TriggerState; // 0x10
	
		// Properties
		public InputAction action { get => default; } // 0x000000018BCF23C0-0x000000018BCF23E8 
		public InputControl control { get => default; } // 0x000000018BCF23F4-0x000000018BCF241C 
		public InputActionPhase phase { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public double time { get => default; } // 0x0000000181C44EA0-0x0000000181C44EB0 
		public double startTime { get => default; } // 0x0000000181448670-0x0000000181448680 
		public bool timerHasExpired { get => default; internal set {} } // 0x000000018BCE9FF0-0x000000018BCE9FF8 0x000000018BCEA05C-0x000000018BCEA078
		public bool isWaiting { get => default; } // 0x000000018BCF2430-0x000000018BCF2438 
		public bool isStarted { get => default; } // 0x000000018BCF2428-0x000000018BCF2430 
		internal int mapIndex { get => default; } // 0x0000000185FB22D0-0x0000000185FB22E0 
		internal int controlIndex { get => default; } // 0x000000018BCF23E8-0x000000018BCF23F4 
		internal int bindingIndex { get => default; } // 0x0000000185FD7E30-0x0000000185FD7E40 
		internal int interactionIndex { get => default; } // 0x000000018BCF241C-0x000000018BCF2428 
	
		// Nested types
		internal enum Flags // TypeDefIndex: 45091
		{
			TimerHasExpired = 2
		}
	
		// Methods
		public float ComputeMagnitude() => default; // 0x0000000185FB09A0-0x0000000185FB09B0
		public bool ControlIsActuated(float threshold = 0f /* Metadata: 0x0205BA76 */) => default; // 0x000000018BCF2108-0x000000018BCF2164
		public void Started() {} // 0x000000018BCF232C-0x000000018BCF2378
		public void Performed() {} // 0x000000018BCF21FC-0x000000018BCF2248
		public void PerformedAndStayStarted() {} // 0x000000018BCF21B0-0x000000018BCF21FC
		public void PerformedAndStayPerformed() {} // 0x000000018BCF2164-0x000000018BCF21B0
		public void Canceled() {} // 0x000000018BCF20BC-0x000000018BCF2108
		public void Waiting() {} // 0x000000018BCF2378-0x000000018BCF23C0
		public void SetTimeout(float seconds) {} // 0x000000018BCF2248-0x000000018BCF2270
		public void SetTotalTimeoutCompletionTime(float seconds) {} // 0x000000018BCF2270-0x000000018BCF232C
		public TValue ReadValue<TValue>()
			where TValue : struct => default;
	}

	public static class InputSystem // TypeDefIndex: 45098
	{
		// Fields
		internal const string kAssemblyVersion = "1.14.0"; // Metadata: 0x0205BA9D
		internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14"; // Metadata: 0x0205BAA4
		private static readonly ProfilerMarker k_InputResetMarker; // 0x00
		internal const float scrollWheelDeltaPerTick = 1f; // Metadata: 0x0205BAE1
		internal static InputManager s_Manager; // 0x08
		internal static InputRemoting s_Remote; // 0x10
	
		// Properties
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x000000018BCF4DCC-0x000000018BCF4F34 
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> disconnectedDevices { get; } // 0x000000018BCF5978-0x000000018BCF5AE0 
		public static float pollingFrequency { get; set; } // 0x000000018BCF27F4-0x000000018BCF28F4 0x000000018BCF2628-0x000000018BCF26DC
		internal static bool isProcessingEvents { get; } // 0x000000018BCF37CC-0x000000018BCF3898 
		public static InputEventListener onEvent { get; set; }
		public static IObservable<InputControl> onAnyButtonPress { get; }
		public static InputSettings settings { get; set; } // 0x000000018BCF4D10-0x000000018BCF4DCC 0x000000018BCF553C-0x000000018BCF55F8
		public static InputRemoting remoting { get; } // 0x000000018BCF5138-0x000000018BCF51BC 
		public static System.Version version { get; } // 0x0000000184D54C90-0x0000000184D54D00 
		public static bool runInBackground { get; set; } // 0x0000000185F8AB60-0x0000000185F8ABC0 0x0000000185492010-0x0000000185492020
		public static InputMetrics metrics { get; } // 0x0000000184D54D00-0x0000000184D54EB0 
	
		// Events
		public static event Action<string, InputControlLayoutChange> onLayoutChange;
		public static event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange;
		public static event InputDeviceCommandDelegate onDeviceCommand;
		public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice;
		public static event Action onBeforeUpdate;
		public static event Action onAfterUpdate;
		public static event Action onSettingsChange;
		public static event Action<object, InputActionChange> onActionChange;
	
		// Nested types
		private struct StateEventBuffer // TypeDefIndex: 45094
		{
			// Fields
			public StateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x0205BAE5
			public _data_e__FixedBuffer data; // 0x19
	
			// Nested types
			public struct _data_e__FixedBuffer // TypeDefIndex: 45093
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		private struct DeltaStateEventBuffer // TypeDefIndex: 45096
		{
			// Fields
			public DeltaStateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x0205BAE7
			public _data_e__FixedBuffer data; // 0x1D
	
			// Nested types
			public struct _data_e__FixedBuffer // TypeDefIndex: 45095
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45097
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InputEventPtr, InputControl> __9__80_0; // 0x08
			public static Func<InputControl, bool> __9__80_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BCF4F34-0x000000018BCF5040
			public __c() {} // 0x000000018BCF5BEC-0x000000018BCF5CF8
	
			// Methods
			internal InputControl _get_onAnyButtonPress_b__80_0(InputEventPtr e) => default; // 0x00000001840036D0-0x0000000184003840
			internal bool _get_onAnyButtonPress_b__80_1(InputControl c) => default;
		}
	
		// Constructors
		static InputSystem() {} // 0x0000000185C577B0-0x0000000185C57850
	
		// Methods
		public static void RegisterLayout(System.Type type, string name = null, InputDeviceMatcher? matches = default) {} // 0x000000018BCF3EB0-0x000000018BCF3F20
		public static void RegisterLayout<T>(string name = null, InputDeviceMatcher? matches = default)
			where T : InputControl {}
		public static void RegisterLayout(string json, string name = null, InputDeviceMatcher? matches = default) {} // 0x000000018BCF3D00-0x000000018BCF3EB0
		public static void RegisterLayoutOverride(string json, string name = null) {}
		public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) {} // 0x000000018BCF4540-0x000000018BCF45A0
		public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher)
			where TDevice : UnityEngine.InputSystem.InputDevice {} // 0x000000018BCF4894-0x000000018BCF4914
		public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, InputDeviceMatcher? matches = default) {} // 0x000000018BCF33C0-0x000000018BCF3418
		public static void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new() {} // 0x000000018BCF3308-0x000000018BCF33C0
		public static void RemoveLayout(string name) {} // 0x000000018BCF347C-0x000000018BCF356C
		public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) => default;
		public static IEnumerable<string> ListLayouts() => default; // 0x000000018BCF2E08-0x000000018BCF2F1C
		public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout) => default; // 0x000000018BCF3000-0x000000018BCF3184
		public static InputControlLayout LoadLayout(string name) => default; // 0x000000018BCF3F94-0x000000018BCF43C0
		public static InputControlLayout LoadLayout<TControl>()
			where TControl : InputControl => default;
		public static string GetNameOfBaseLayout(string layoutName) => default; // 0x000000018BCF4AA4-0x000000018BCF4B6C
		public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) => default; // 0x000000018BCF3418-0x000000018BCF347C
		public static void RegisterProcessor(System.Type type, string name = null) {} // 0x000000018539A860-0x000000018539A8E0
		public static void RegisterProcessor<T>(string name = null) {} // 0x000000018BCF5040-0x000000018BCF50D4
		public static System.Type TryGetProcessor(string name) => default; // 0x0000000184111310-0x0000000184111610
		public static IEnumerable<string> ListProcessors() => default; // 0x000000018BCF5810-0x000000018BCF5978
		public static UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, string variants = null) => default; // 0x000000018BCF44DC-0x000000018BCF4540
		public static TDevice AddDevice<TDevice>(string name = null)
			where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCF2B60-0x000000018BCF2BB4
		public static UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description) => default; // 0x000000018BCF2DA8-0x000000018BCF2E08
		public static void AddDevice(UnityEngine.InputSystem.InputDevice device) {}
		public static void RemoveDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCF2BB4-0x000000018BCF2DA8
		public static void FlushDisconnectedDevices() {}
		public static UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout) => default;
		public static TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018457E690-0x000000018457E810
		public static UnityEngine.InputSystem.InputDevice GetDevice(System.Type type) => default; // 0x000000018BCF2F1C-0x000000018BCF2FA0
		public static TDevice GetDevice<TDevice>(InternedString usage)
			where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BCF2FA0-0x000000018BCF3000
		public static TDevice GetDevice<TDevice>(string usage)
			where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018539DB70-0x000000018539DBF0
		public static UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId) => default; // 0x000000018BCF2934-0x000000018BCF29A8
		public static List<InputDeviceDescription> GetUnsupportedDevices() => default; // 0x000000018BCF4BD8-0x000000018BCF4CBC
		public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) => default; // 0x000000018BCF45A0-0x000000018BCF4620
		public static void EnableDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCF4B6C-0x000000018BCF4BD8
		public static void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents = false /* Metadata: 0x0205BA7B */) {} // 0x000000018BCF356C-0x000000018BCF362C
		public static bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BCF46E0-0x000000018BCF47A0
		public static void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x0205BA7C */) {} // 0x000000018BCF4620-0x000000018BCF46E0
		public static bool TryResetDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BCF47A0-0x000000018BCF4818
		public static void PauseHaptics() {} // 0x000000018BCF4818-0x000000018BCF4894
		public static void ResumeHaptics() {} // 0x000000018BCF2588-0x000000018BCF2628
		public static void ResetHaptics() {} // 0x000000018BCF250C-0x000000018BCF2588
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {} // 0x000000018BCF443C-0x000000018BCF44DC
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x000000018BCF43C0-0x000000018BCF443C
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {} // 0x000000018BCF29A8-0x000000018BCF2AE8
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x000000018BCF2AE8-0x000000018BCF2B60
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {}
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {}
		public static InputControl FindControl(string path) => default; // 0x000000018BCF50D4-0x000000018BCF5138
		public static InputControlList<InputControl> FindControls(string path) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static InputControlList<TControl> FindControls<TControl>(string path)
			where TControl : InputControl => default; // 0x0000000185492010-0x0000000185492020
		public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl => default; // 0x000000018BCF51BC-0x000000018BCF53C8
		public static void QueueEvent(InputEventPtr eventPtr) {} // 0x000000018BCF362C-0x000000018BCF37CC
		public static void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo {} // 0x000000018BCF3898-0x000000018BCF3A50
		public static void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time = -1 /* Metadata: 0x0205BA7D */)
			where TState : struct, IInputStateTypeInfo {} // 0x000000018BCF4CBC-0x000000018BCF4D10
		public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1 /* Metadata: 0x0205BA85 */)
			where TDelta : struct {} // 0x0000000185C57850-0x0000000185C578C0
		public static void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time = -1 /* Metadata: 0x0205BA8D */) {} // 0x0000000184111900-0x0000000184111C00
		public static void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time = -1 /* Metadata: 0x0205BA95 */) {} // 0x000000018BCF5704-0x000000018BCF5810
		public static void Update() {} // 0x0000000184111C00-0x0000000184111E90
		internal static void Update(InputUpdateType updateType) {} // 0x000000018BCF55F8-0x000000018BCF5704
		public static void RegisterInteraction(System.Type type, string name = null) {} // 0x000000018BCF3A50-0x000000018BCF3BA8
		public static void RegisterInteraction<T>(string name = null) {}
		public static System.Type TryGetInteraction(string name) => default; // 0x000000018BCF4914-0x000000018BCF49DC
		public static IEnumerable<string> ListInteractions() => default; // 0x000000018BCF28F4-0x000000018BCF2934
		public static void RegisterBindingComposite(System.Type type, string name) {} // 0x000000018BCF3220-0x000000018BCF32A4
		public static void RegisterBindingComposite<T>(string name = null) {} // 0x000000018BCF3184-0x000000018BCF3220
		public static System.Type TryGetBindingComposite(string name) => default; // 0x000000018BCF5428-0x000000018BCF5478
		public static void DisableAllEnabledActions() {} // 0x000000018BCF54D8-0x000000018BCF553C
		public static List<InputAction> ListEnabledActions() => default; // 0x000000018BCF5478-0x000000018BCF54D8
		public static int ListEnabledActions(List<InputAction> actions) => default; // 0x000000018BCF5DC0-0x000000018BCF5E74
		private static void RunInitializeInPlayer() {} // 0x0000000184D54EB0-0x0000000184D54EF0
		internal static void EnsureInitialized() {} // 0x000000018BCF83D8-0x000000018BCF843C
		private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null) {} // 0x0000000185492010-0x0000000185492020
		private static void RunInitialUpdate() {} // 0x000000018BCF835C-0x000000018BCF8374
		private static void PerformDefaultPluginInitialization() {} // 0x0000000182F7A4D0-0x0000000182F7A4E0
	}

	public static class CommonUsages // TypeDefIndex: 45099
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
		static CommonUsages() {} // 0x000000018BCE89F4-0x000000018BCE93B4
	}

	public abstract class InputControl // TypeDefIndex: 45101
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
		public string name { get; } // 0x000000018646D6B4-0x000000018646D6D4 
		public string displayName { get; protected set; } // 0x000000018539DA70-0x000000018539DAB0 0x0000000185A16440-0x0000000185A16450
		public string shortDisplayName { get; protected set; } // 0x000000018BCEFCCC-0x000000018BCEFD00 0x000000018571FEC0-0x000000018571FED0
		public string path { get; } // 0x000000018BCEFC70-0x000000018BCEFCCC 
		public string layout { get; } // 0x000000018646D694-0x000000018646D6B4 
		public string variants { get; } // 0x000000018BCEFDE4-0x000000018BCEFE04 
		public UnityEngine.InputSystem.InputDevice device { get; } // 0x0000000183060C50-0x0000000183060C60 
		public InputControl parent { get; } // 0x000000018140CF50-0x000000018140CF60 
		public ReadOnlyArray<InputControl> children { get; } // 0x0000000184006CA0-0x0000000184006D20 
		public ReadOnlyArray<InternedString> usages { get; } // 0x000000018BCEFD6C-0x000000018BCEFDE4 
		public ReadOnlyArray<InternedString> aliases { get; } // 0x00000001840071A0-0x0000000184007220 
		public InputStateBlock stateBlock { get; } // 0x00000001834A7540-0x00000001834A7550 
		public bool noisy { get; internal set; } // 0x0000000184581DC0-0x0000000184581DD0 0x000000018BCEFE04-0x000000018BCEFEE0
		public bool synthetic { get; internal set; } // 0x000000018BCEFD60-0x000000018BCEFD6C 0x000000018506D6A0-0x000000018506D6C0
		public InputControl this[string path] { get => default; } // 0x000000018BCEFB6C-0x000000018BCEFC00 
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
		public float magnitude { get; } // 0x000000018646F414-0x000000018646F41C 
		protected internal unsafe void* currentStatePtr { get; } // 0x00000001845819D0-0x0000000184581A50 
		protected internal unsafe void* previousFrameStatePtr { get; } // 0x0000000185EF5040-0x0000000185EF5060 
		protected internal unsafe void* defaultStatePtr { get; } // 0x000000018BCEFC00-0x000000018BCEFC38 
		protected internal unsafe void* noiseMaskPtr { get; } // 0x000000018BCEFC38-0x000000018BCEFC70 
		protected internal uint stateOffsetRelativeToDeviceRoot { get; } // 0x000000018BCEFD00-0x000000018BCEFD60 
		public FourCC optimizedControlDataType { get; } // 0x0000000185FB23A0-0x0000000185FB23B0 
		internal bool isSetupFinished { get; set; } // 0x000000018506B670-0x000000018506B6D0 0x00000001850677B0-0x00000001850677D0
		internal bool isButton { get; set; } // 0x0000000184585E90-0x0000000184585EA0 0x000000018506E3F0-0x000000018506E410
		internal bool isConfigUpToDate { get; set; } // 0x000000018539DAE0-0x000000018539DAF0 0x000000018539DAF0-0x000000018539DB10
		internal bool dontReset { get; set; } // 0x0000000184006D20-0x0000000184006D30 0x0000000185069750-0x0000000185069770
		internal bool usesStateFromOtherControl { get; set; } // 0x0000000184006D30-0x0000000184006D40 0x000000018BCEFEE0-0x000000018BCEFF00
		internal bool hasDefaultState { get; } // 0x00000001840066F0-0x0000000184006700 
	
		// Nested types
		internal enum ControlFlags // TypeDefIndex: 45100
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
		protected InputControl() {} // 0x00000001854D1360-0x00000001854D13C0
	
		// Methods
		public override string ToString() => default; // 0x000000018BCEF9AC-0x000000018BCEFA0C
		private string DebuggerDisplay() => default; // 0x000000018BCEF048-0x000000018BCEF15C
		public float EvaluateMagnitude() => default; // 0x0000000185212520-0x00000001852125B0
		public virtual unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000185FD5E00-0x0000000185FD5E10
		public abstract unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
		public abstract unsafe object ReadValueFromStateAsObject(void* statePtr);
		public abstract unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
		public virtual unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr) {} // 0x000000018BCEFA84-0x000000018BCEFAF8
		public virtual unsafe void WriteValueFromObjectIntoState(object value, void* statePtr) {} // 0x000000018BCEFAF8-0x000000018BCEFB6C
		public abstract unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr);
		public InputControl TryGetChildControl(string path) => default; // 0x000000018BCEFA0C-0x000000018BCEFA84
		public TControl TryGetChildControl<TControl>(string path)
			where TControl : InputControl => default;
		public InputControl GetChildControl(string path) => default; // 0x000000018BCEF4EC-0x000000018BCEF610
		public TControl GetChildControl<TControl>(string path)
			where TControl : InputControl => default;
		protected virtual void FinishSetup() {} // 0x0000000185492010-0x0000000185492020
		protected void RefreshConfigurationIfNeeded() {} // 0x000000018539DAB0-0x000000018539DAE0
		protected virtual void RefreshConfiguration() {} // 0x0000000185492010-0x0000000185492020
		protected virtual FourCC CalculateOptimizedControlDataType() => default; // 0x00000001813AE580-0x00000001813AE590
		public void ApplyParameterChanges() {} // 0x000000018BCEEF54-0x000000018BCEEF98
		private void SetOptimizedControlDataType() {} // 0x000000018BCEF938-0x000000018BCEF9AC
		internal void SetOptimizedControlDataTypeRecursively() {} // 0x000000018BCEF7EC-0x000000018BCEF938
		internal void EnsureOptimizationTypeHasNotChanged() {} // 0x000000018BCEF15C-0x000000018BCEF4EC
		internal void CallFinishSetupRecursive() {} // 0x000000018BCEEF98-0x000000018BCEF048
		internal string MakeChildPath(string path) => default; // 0x000000018BCEF610-0x000000018BCEF68C
		internal void BakeOffsetIntoStateBlockRecursive(uint offset) {} // 0x0000000184006700-0x0000000184006CA0
		internal int GetDeviceIndex() => default; // 0x0000000184581AD0-0x0000000184581B10
		internal bool IsValueConsideredPressed(float value) => default; // 0x0000000184585DF0-0x0000000184585E90
		internal virtual void AddProcessor(object first) {} // 0x0000000185492010-0x0000000185492020
		internal void MarkAsStale() {} // 0x0000000185FD7DA0-0x0000000185FD7DB0
		internal void MarkAsStaleRecursively() {} // 0x000000018BCEF68C-0x000000018BCEF7EC
	}

	public abstract class InputControl<TValue> : InputControl // TypeDefIndex: 45102
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
		public ref TValue value { get; }
		internal ref TValue unprocessedValue { get; }
		internal InputProcessor<TValue>[] processors { get; }
	
		// Constructors
		protected InputControl() {}
	
		// Methods
		public TValue ReadValue() => default;
		public TValue ReadValueFromPreviousFrame() => default;
		public TValue ReadDefaultValue() => default;
		public unsafe TValue ReadValueFromState(void* statePtr) => default;
		public unsafe TValue ReadValueFromStateWithCaching(void* statePtr) => default;
		public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr) => default;
		public TValue ReadUnprocessedValue() => default;
		public abstract unsafe TValue ReadUnprocessedValueFromState(void* statePtr);
		public override unsafe object ReadValueFromStateAsObject(void* statePtr) => default;
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize) {}
		public override unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr) {}
		public override unsafe void WriteValueFromObjectIntoState(object value, void* statePtr) {}
		public virtual unsafe void WriteValueIntoState(TValue value, void* statePtr) {}
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize) => default;
		private static bool CompareValue(ref ref TValue firstValue, ref ref TValue secondValue) => default;
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr) => default;
		public TValue ProcessValue(TValue value) => default;
		public void ProcessValue(ref ref TValue value) {}
		internal TProcessor TryGetProcessor<TProcessor>()
			where TProcessor : InputProcessor<TValue> => default;
		internal override void AddProcessor(object processor) {}
		protected override void FinishSetup() {}
	}

	public static class InputControlExtensions // TypeDefIndex: 45109
	{
		// Nested types
		public enum Enumerate // TypeDefIndex: 45103
		{
			IgnoreControlsInDefaultState = 1,
			IgnoreControlsInCurrentState = 2,
			IncludeSyntheticControls = 4,
			IncludeNoisyControls = 8,
			IncludeNonLeafControls = 16
		}
	
		public struct InputEventControlCollection : IEnumerable<InputControl> // TypeDefIndex: 45104
		{
			// Fields
			internal UnityEngine.InputSystem.InputDevice m_Device; // 0x00
			internal InputEventPtr m_EventPtr; // 0x08
			internal Enumerate m_Flags; // 0x10
			internal float m_MagnitudeThreshold; // 0x14
	
			// Properties
			public InputEventPtr eventPtr { get => default; }
	
			// Methods
			public InputEventControlEnumerator GetEnumerator() => default; // 0x000000018BCEC1D0-0x000000018BCEC2B4
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator() => default; // 0x000000018BCEC148-0x000000018BCEC1D0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCEC32C-0x000000018BCEC3A8
		}
	
		public struct InputEventControlEnumerator : IEnumerator<InputControl> // TypeDefIndex: 45105
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
			public InputControl Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x000000018BCEC6F0-0x000000018BCEC7A0 
	
			// Constructors
			internal unsafe InputEventControlEnumerator(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, Enumerate flags, float magnitudeThreshold = 0f /* Metadata: 0x0205BB1D */) : this() {
				m_Flags = default;
				m_Device = default;
				m_StateOffsetToControlIndex = default;
				m_StateOffsetToControlIndexLength = default;
				m_AllControls = default;
				m_DefaultState = default;
				m_CurrentState = default;
				m_NoiseMask = default;
				m_EventPtr = default;
				m_CurrentControl = default;
				m_CurrentIndexInStateOffsetToControlIndexMap = default;
				m_CurrentControlStateBitOffset = default;
				m_EventState = default;
				m_CurrentBitOffset = default;
				m_EndBitOffset = default;
				m_MagnitudeThreshold = default;
			} // 0x000000018BCEC438-0x000000018BCEC528
	
			// Methods
			private bool CheckDefault(uint numBits) => default; // 0x000000018BCEC2B4-0x000000018BCEC32C
			private bool CheckCurrent(uint numBits) => default;
			public bool MoveNext() => default;
			public void Reset() {} // 0x000000018BCEC3A8-0x000000018BCEC438
			public void Dispose() {}
		}
	
		public struct ControlBuilder // TypeDefIndex: 45106
		{
			// Fields
			private InputControl _control_k__BackingField; // 0x00
	
			// Properties
			public InputControl control { get; internal set; } // 0x000000018BCEC7A0-0x000000018BCEC964 
	
			// Methods
			public ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index) => default;
			public ControlBuilder WithParent(InputControl parent) => default;
			public ControlBuilder WithName(string name) => default;
			public ControlBuilder WithDisplayName(string displayName) => default;
			public ControlBuilder WithShortDisplayName(string shortDisplayName) => default;
			public ControlBuilder WithLayout(InternedString layout) => default; // 0x000000018BCEB594-0x000000018BCEB714
			public ControlBuilder WithUsages(int startIndex, int count) => default;
			public ControlBuilder WithAliases(int startIndex, int count) => default; // 0x0000000184583D90-0x0000000184583E40
			public ControlBuilder WithChildren(int startIndex, int count) => default; // 0x0000000184583E40-0x0000000184583EE0
			public ControlBuilder WithStateBlock(InputStateBlock stateBlock) => default; // 0x000000018BCEB204-0x000000018BCEB280
			public ControlBuilder WithDefaultState(PrimitiveValue value) => default; // 0x000000018BCEB280-0x000000018BCEB3A0
			public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) => default; // 0x000000018BCEB3A0-0x000000018BCEB49C
			public ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor)
				where TProcessor : InputProcessor<TValue>
				where TValue : struct => default; // 0x0000000184583EE0-0x0000000184584060
			public ControlBuilder IsNoisy(bool value) => default; // 0x000000018BCEB49C-0x000000018BCEB594
			public ControlBuilder IsSynthetic(bool value) => default; // 0x000000018BCEC06C-0x000000018BCEC148
			public ControlBuilder DontReset(bool value) => default; // 0x000000018BCEBF78-0x000000018BCEC06C
			public ControlBuilder IsButton(bool value) => default; // 0x000000018BCEBE78-0x000000018BCEBF60
			public void Finish() {} // 0x000000018BCEBC54-0x000000018BCEBE78
		}
	
		public struct DeviceBuilder // TypeDefIndex: 45107
		{
			// Fields
			private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x00
	
			// Properties
			public UnityEngine.InputSystem.InputDevice device { get; internal set; } // 0x000000018BCEC528-0x000000018BCEC6F0 
	
			// Methods
			public DeviceBuilder WithName(string name) => default; // 0x000000018BCEAD00-0x000000018BCEADF4
			public DeviceBuilder WithDisplayName(string displayName) => default; // 0x000000018BCEADF4-0x000000018BCEAEEC
			public DeviceBuilder WithShortDisplayName(string shortDisplayName) => default;
			public DeviceBuilder WithLayout(InternedString layout) => default; // 0x000000018BCEAEEC-0x000000018BCEB204
			public DeviceBuilder WithChildren(int startIndex, int count) => default; // 0x000000018BCEB758-0x000000018BCEB9D0
			public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) => default; // 0x000000018BCEB714-0x000000018BCEB758
			public DeviceBuilder IsNoisy(bool value) => default; // 0x000000018BCEBF60-0x000000018BCEBF78
			public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) => default; // 0x000000018BCEBA58-0x000000018BCEBC54
			public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) => default; // 0x000000018BCEB9D0-0x000000018BCEBA58
			public DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map) => default; // 0x000000018506B620-0x000000018506B670
			public DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies) => default; // 0x000000018506B4D0-0x000000018506B620
			public void Finish() {} // 0x000000018357A260-0x000000018357A270
		}
	
		private sealed class _GetAllButtonPresses_d__43 : IEnumerable<InputControl>, IEnumerator<InputControl> // TypeDefIndex: 45108
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
			InputControl IEnumerator<UnityEngine.InputSystem.InputControl>.Current { get => default; } // 0x000000018BCF17C4-0x000000018BCF17F4 
			object IEnumerator.Current { get => default; } // 0x000000018BCF17F4-0x000000018BCF1BC0 
	
			// Constructors
			public _GetAllButtonPresses_d__43() {} // Dummy constructor
			public _GetAllButtonPresses_d__43(int __1__state) {} // 0x000000018BCF15F4-0x000000018BCF1664
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCF1664-0x000000018BCF16FC
			private bool MoveNext() => default; // 0x000000018BCF16FC-0x000000018BCF1794
			private void __m__Finally1() {} // 0x000000018BCF1F48-0x000000018BCF20BC
			void IEnumerator.Reset() {} // 0x000000018BCF1794-0x000000018BCF17C4
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator() => default; // 0x000000018BCF1BC0-0x000000018BCF1F48
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FD7E20-0x0000000185FD7E30
		}
	
		// Methods
		public static TControl FindInParentChain<TControl>(InputControl control)
			where TControl : InputControl => default; // 0x00000001813ECF20-0x00000001813ECF30
		public static bool IsPressed(InputControl control, float buttonPressPoint = 0f /* Metadata: 0x0205BAF1 */) => default; // 0x00000001813ECF20-0x00000001813ECF30
		public static bool IsActuated(InputControl control, float threshold = 0f /* Metadata: 0x0205BAF5 */) => default; // 0x00000001834AFB60-0x00000001834AFB70
		public static object ReadValueAsObject(InputControl control) => default; // 0x000000018646FE2C-0x000000018646FE34
		public static unsafe void ReadValueIntoBuffer(InputControl control, void* buffer, int bufferSize) {} // 0x000000018BCE93B4-0x000000018BCE943C
		public static object ReadDefaultValueAsObject(InputControl control) => default; // 0x000000018BCE968C-0x000000018BCE96BC
		public static TValue ReadValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent)
			where TValue : struct => default; // 0x000000018BCE963C-0x000000018BCE968C
		public static bool ReadValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct {
			value = default;
			return default;
		} // 0x000000018BCE9570-0x000000018BCE95D4
		public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) => default; // 0x000000018BCE96BC-0x000000018BCE9720
		public static TValue ReadUnprocessedValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr eventPtr)
			where TValue : struct => default; // 0x000000018BCE95D4-0x000000018BCE9604
		public static bool ReadUnprocessedValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct {
			value = default;
			return default;
		} // 0x000000018506DE10-0x000000018506DE40
		public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) {} // 0x000000018506DDE0-0x000000018506DE10
		public static unsafe void WriteValueIntoState(InputControl control, void* statePtr) {} // 0x000000018506DFE0-0x000000018506E010
		public static unsafe void WriteValueIntoState<TValue>(InputControl control, TValue value, void* statePtr)
			where TValue : struct {} // 0x000000018BCE9720-0x000000018BCE9744
		public static unsafe void WriteValueIntoState<TValue>(InputControl<TValue> control, TValue value, void* statePtr)
			where TValue : struct {} // 0x000000018BCE9528-0x000000018BCE9570
		public static unsafe void WriteValueIntoState<TValue>(InputControl<TValue> control, void* statePtr)
			where TValue : struct {} // 0x000000018BCE9604-0x000000018BCE963C
		public static void WriteValueIntoState<TValue, TState>(InputControl<TValue> control, TValue value, ref ref TState state)
			where TValue : struct
			where TState : struct, IInputStateTypeInfo {}
		public static void WriteValueIntoEvent<TValue>(InputControl control, TValue value, InputEventPtr eventPtr)
			where TValue : struct {} // 0x000000018BCE94D8-0x000000018BCE9500
		public static void WriteValueIntoEvent<TValue>(InputControl<TValue> control, TValue value, InputEventPtr eventPtr)
			where TValue : struct {} // 0x000000018BCE9500-0x000000018BCE9528
		public static unsafe void CopyState(UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes) {} // 0x000000018BCE943C-0x000000018BCE9490
		public static void CopyState<TState>(UnityEngine.InputSystem.InputDevice device, out ref TState state)
			where TState : struct, IInputStateTypeInfo {
			state = default;
		} // 0x000000018BCE94B0-0x000000018BCE94D8
		public static bool CheckStateIsAtDefault(InputControl control) => default; // 0x000000018BCE9490-0x000000018BCE94B0
		public static unsafe bool CheckStateIsAtDefault(InputControl control, void* statePtr, void* maskPtr = null) => default; // 0x00000001834AFB60-0x00000001834AFB70
		public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) => default; // 0x000000018646FE2C-0x000000018646FE34
		public static unsafe bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, void* statePtr) => default; // 0x000000018BCE963C-0x000000018BCE968C
		public static unsafe bool CompareStateIgnoringNoise(InputControl control, void* statePtr) => default; // 0x000000018BCE9570-0x000000018BCE95D4
		public static unsafe bool CompareState(InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null) => default; // 0x000000018BCE96BC-0x000000018BCE9720
		public static unsafe bool CompareState(InputControl control, void* statePtr, void* maskPtr = null) => default; // 0x000000018BCE95D4-0x000000018BCE9604
		public static unsafe bool HasValueChangeInState(InputControl control, void* statePtr) => default; // 0x000000018506DFE0-0x000000018506E010
		public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) => default; // 0x000000018BCE9720-0x000000018BCE9744
		public static unsafe void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) => default; // 0x000000018BCE94D8-0x000000018BCE9500
		internal static unsafe void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) => default; // 0x000000018BCE9C94-0x000000018BCE9D28
		public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) => default; // 0x000000018BCE9B10-0x000000018BCE9B54
		public static void QueueValueChange<TValue>(InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x0205BAF9 */)
			where TValue : struct {} // 0x000000018BCE9D28-0x000000018BCE9D58
		public static unsafe void AccumulateValueInEvent(InputControl<float> control, void* currentStatePtr, InputEventPtr newState) {} // 0x000000018BCE9B54-0x000000018BCE9C94
		internal static unsafe void AccumulateValueInEvent(InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState) {} // 0x000000018BCE9744-0x000000018BCE9B10
		public static void FindControlsRecursive<TControl>(InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate)
			where TControl : InputControl {}
		internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder = null) => default; // 0x000000018BCF7D60-0x000000018BCF7DD8
		public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x0205BB01 */) => default; // 0x000000018BCF7934-0x000000018BCF7C74
		public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x0205BB05 */) => default; // 0x0000000185FD7E40-0x0000000185FD7E60
		public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0205BB09 */, bool buttonControlsOnly = true /* Metadata: 0x0205BB0D */) => default; // 0x0000000181377E40-0x0000000181377E50
		public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0205BB0E */, bool buttonControlsOnly = true /* Metadata: 0x0205BB12 */) => default; // 0x000000018BCF7D14-0x000000018BCF7D60
		public static IEnumerable<InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x0205BB13 */, bool buttonControlsOnly = true /* Metadata: 0x0205BB17 */) => default; // 0x0000000181377E40-0x0000000181377E50
		public static ControlBuilder Setup(InputControl control) => default; // 0x000000018BCF7C74-0x000000018BCF7D0C
		public static DeviceBuilder Setup(UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount) => default; // 0x000000018BCF7D0C-0x000000018BCF7D14
	}

	public enum InputControlLayoutChange // TypeDefIndex: 45110
	{
		Added = 0,
		Removed = 1,
		Replaced = 2
	}

	public struct InputControlList<TControl> : IList<TControl>, IReadOnlyList<TControl>, IDisposable // TypeDefIndex: 45112
		where TControl : InputControl
	{
		// Fields
		private int m_Count;
		private NativeArray<ulong> m_Indices;
		private readonly Unity.Collections.Allocator m_Allocator;
		private const ulong kInvalidIndex = 18446744073709551615; // Metadata: 0x0205BB2E
	
		// Properties
		public int Count { get => default; }
		public int Capacity { get => default; set {} }
		public bool IsReadOnly { get => default; }
		public TControl this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TControl> // TypeDefIndex: 45111
		{
			// Fields
			private readonly unsafe ulong* m_Indices;
			private readonly int m_Count;
			private int m_Current;
	
			// Properties
			public TControl Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public unsafe Enumerator(InputControlList<TControl> list) : this() {
				m_Indices = default;
				m_Count = default;
				m_Current = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public InputControlList(Unity.Collections.Allocator allocator, int initialCapacity = 0 /* Metadata: 0x0205BB24 */) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
		public InputControlList(IEnumerable<TControl> values, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205BB25 */) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
		public InputControlList(TControl[] values) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
	
		// Methods
		public void Resize(int size) {}
		public void Add(TControl item) {}
		public void AddSlice<TList>(TList list, int count = -1 /* Metadata: 0x0205BB26 */, int destinationIndex = -1 /* Metadata: 0x0205BB27 */, int sourceIndex = 0 /* Metadata: 0x0205BB28 */)
			where TList : IReadOnlyList<TControl> {}
		public void AddRange(IEnumerable<TControl> list, int count = -1 /* Metadata: 0x0205BB29 */, int destinationIndex = -1 /* Metadata: 0x0205BB2A */) {}
		public bool Remove(TControl item) => default;
		public void RemoveAt(int index) {}
		public void CopyTo(TControl[] array, int arrayIndex) {}
		public int IndexOf(TControl item) => default;
		public int IndexOf(TControl item, int startIndex, int count = -1 /* Metadata: 0x0205BB2B */) => default;
		public void Insert(int index, TControl item) {}
		public void Clear() {}
		public bool Contains(TControl item) => default;
		public bool Contains(TControl item, int startIndex, int count = -1 /* Metadata: 0x0205BB2C */) => default;
		public void SwapElements(int index1, int index2) {}
		public void Sort<TCompare>(int startIndex, int count, TCompare comparer)
			where TCompare : IComparer<TControl> {}
		public TControl[] ToArray(bool dispose = false /* Metadata: 0x0205BB2D */) => default;
		internal void AppendTo(ref ref TControl[] array, ref int count) {}
		public void Dispose() {}
		public IEnumerator<TControl> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public override string ToString() => default;
		private static ulong ToIndex(TControl control) => default;
		private static TControl FromIndex(ulong index) => default;
	}

	public static class InputControlPath // TypeDefIndex: 45120
	{
		// Fields
		public const string Wildcard = "*"; // Metadata: 0x0205BB41
		public const string DoubleWildcard = "**"; // Metadata: 0x0205BB43
		public const char Separator = '/'; // Metadata: 0x0205BB46
		internal const char SeparatorReplacement = ' '; // Metadata: 0x0205BB48
	
		// Nested types
		public enum HumanReadableStringOptions // TypeDefIndex: 45113
		{
			None = 0,
			OmitDevice = 2,
			UseShortNames = 4
		}
	
		private enum PathComponentType // TypeDefIndex: 45114
		{
			Name = 0,
			DisplayName = 1,
			Usage = 2,
			Layout = 3
		}
	
		public struct ParsedPathComponent // TypeDefIndex: 45116
		{
			// Fields
			internal Substring m_Layout; // 0x00
			internal InlinedArray<Substring> m_Usages; // 0x10
			internal Substring m_Name; // 0x30
			internal Substring m_DisplayName; // 0x40
	
			// Properties
			public string layout { get => default; } // 0x000000018BCED6E0-0x000000018BCEE0CC 
			public IEnumerable<string> usages { get => default; } // 0x000000018BCEE65C-0x000000018BCEE800 
			public string name { get => default; } // 0x000000018BCEE548-0x000000018BCEE65C 
			public string displayName { get => default; } // 0x000000018BCEE328-0x000000018BCEE548 
			internal bool isWildcard { get => default; } // 0x000000018BCECDC0-0x000000018BCECF34 
			internal bool isDoubleWildcard { get => default; } // 0x000000018BCECBE0-0x000000018BCECDC0 
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 45115
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<Substring, string> __9__7_0; // 0x08
	
				// Constructors
				static __c() {} // 0x000000018BCEC964-0x000000018BCEC98C
				public __c() {} // 0x000000018BCEC98C-0x000000018BCECA54
	
				// Methods
				internal string _get_usages_b__7_0(Substring x) => default; // 0x000000018BCED6AC-0x000000018BCED6E0
			}
	
			// Methods
			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options) {
				referencedLayoutName = default;
				controlPath = default;
				return default;
			} // 0x000000018BCECA54-0x000000018BCECBE0
			private static string ToHumanReadableString(Substring substring) => default; // 0x000000018BCED4F4-0x000000018BCED6AC
			public bool Matches(InputControl control) => default; // 0x000000018BCEE124-0x000000018BCEE17C
			private static bool ComparePathElementToString(Substring pathElement, string element) => default; // 0x000000018BCEE1EC-0x000000018BCEE328
		}
	
		private struct PathParser // TypeDefIndex: 45117
		{
			// Fields
			private string path; // 0x00
			private int length; // 0x08
			private int leftIndexInPath; // 0x0C
			private int rightIndexInPath; // 0x10
			public ParsedPathComponent current; // 0x18
	
			// Properties
			public bool isAtEnd { get => default; } // 0x000000018BCEE17C-0x000000018BCEE1EC 
	
			// Constructors
			public PathParser(string path) : this() {
				this.path = default;
				length = default;
				leftIndexInPath = default;
				rightIndexInPath = default;
				current = default;
			}
	
			// Methods
			public bool MoveToNextComponent() => default;
			private Substring ParseComponentPart(char terminator) => default; // 0x000000018BCEE0CC-0x000000018BCEE124
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45118
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Substring, string> __9__9_0; // 0x08
	
			// Constructors
			static __c() {}
			public __c() {} // 0x000000018BCED370-0x000000018BCED484
	
			// Methods
			internal string _TryGetDeviceUsages_b__9_0(Substring x) => default; // 0x000000018BCECF34-0x000000018BCED1DC
		}
	
		private sealed class _Parse_d__34 : IEnumerable<ParsedPathComponent>, IEnumerator<ParsedPathComponent> // TypeDefIndex: 45119
		{
			// Fields
			private int __1__state; // 0x10
			private ParsedPathComponent __2__current; // 0x18
			private int __l__initialThreadId; // 0x68
			private string path; // 0x70
			public string __3__path; // 0x78
			private PathParser _parser_5__2; // 0x80
	
			// Properties
			ParsedPathComponent IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x0000000184007D60-0x0000000184008000 
	
			// Constructors
			public _Parse_d__34() {} // Dummy constructor
			public _Parse_d__34(int __1__state) {} // 0x000000018BCED1DC-0x000000018BCED300
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCED300-0x000000018BCED370
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
			IEnumerator<ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() => default; // 0x00000001840031B0-0x0000000184003280
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCED484-0x000000018BCED4F4
		}
	
		// Methods
		internal static string CleanSlashes(string pathComponent) => default; // 0x000000018BCF6F70-0x000000018BCF6F78
		public static string Combine(InputControl parent, string path) => default; // 0x000000018BCF6F84-0x000000018BCF70C0
		public static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x0205BB36 */, InputControl control = null) => default; // 0x000000018BCF6F78-0x000000018BCF6F84
		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x0205BB37 */, InputControl control = null) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x000000018BCF6E84-0x000000018BCF6E90
		public static string[] TryGetDeviceUsages(string path) => default; // 0x000000018BCF6F00-0x000000018BCF6F70
		public static string TryGetDeviceLayout(string path) => default; // 0x000000018BCF6E90-0x000000018BCF6F00
		public static string TryGetControlLayout(string path) => default; // 0x000000018BCF6708-0x000000018BCF6E84
		private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName) => default; // 0x000000018BCF66BC-0x000000018BCF6708
		private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout) => default; // 0x000000018BCF640C-0x000000018BCF66BC
		private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser) => default; // 0x000000018BCF631C-0x000000018BCF640C
		private static bool StringMatches(Substring str, InternedString matchTo) => default; // 0x000000018BCF8374-0x000000018BCF83D8
		public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0205BB38 */) => default; // 0x0000000185492010-0x0000000185492020
		public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0205BB39 */) => default; // 0x000000018BCF8348-0x000000018BCF835C
		public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0 /* Metadata: 0x0205BB3A */) => default; // 0x000000018BCF7464-0x000000018BCF7470
		public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0205BB3B */)
			where TControl : InputControl => default; // 0x000000018BCF7420-0x000000018BCF7464
		public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches)
			where TControl : InputControl => default; // 0x000000018BCF70C0-0x000000018BCF7350
		public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0205BB3C */) => default; // 0x000000018BCF7350-0x000000018BCF7420
		public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x0205BB3D */)
			where TControl : InputControl => default; // 0x000000018BCF843C-0x000000018BCF84A0
		public static bool Matches(string expected, InputControl control) => default; // 0x0000000185492010-0x0000000185492020
		internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false /* Metadata: 0x0205BB3E */) => default; // 0x000000018BCF8348-0x000000018BCF835C
		public static bool MatchesPrefix(string expected, InputControl control) => default; // 0x000000018BCF832C-0x000000018BCF8348
		private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false /* Metadata: 0x0205BB3F */) => default; // 0x0000000185492010-0x0000000185492020
		private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default; // 0x000000018BCF8058-0x000000018BCF81D8
		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default; // 0x0000000185FC4420-0x0000000185FC4450
		private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default; // 0x000000018BCF8274-0x000000018BCF82C0
		private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0 /* Metadata: 0x0205BB40 */) => default; // 0x000000018BCF82C0-0x000000018BCF832C
		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) => default; // 0x000000018BCF81D8-0x000000018BCF826C
		public static IEnumerable<ParsedPathComponent> Parse(string path) => default; // 0x000000018BCF826C-0x000000018BCF8274
	}

	public abstract class InputProcessor // TypeDefIndex: 45122
	{
		// Fields
		internal static TypeTable s_Processors; // 0x00
	
		// Properties
		public virtual CachingPolicy cachingPolicy { get; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Nested types
		public enum CachingPolicy // TypeDefIndex: 45121
		{
			CacheResult = 0,
			EvaluateOnEveryRead = 1
		}
	
		// Constructors
		protected InputProcessor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract object ProcessAsObject(object value, InputControl control);
		public abstract unsafe void Process(void* buffer, int bufferSize, InputControl control);
		internal static System.Type GetValueTypeFromType(System.Type processorType) => default; // 0x000000018BCF2438-0x000000018BCF250C
	}

	public abstract class InputProcessor<TValue> : InputProcessor // TypeDefIndex: 45123
		where TValue : struct
	{
		// Constructors
		protected InputProcessor() {}
	
		// Methods
		public abstract TValue Process(TValue value, InputControl control);
		public override object ProcessAsObject(object value, InputControl control) => default;
		public override unsafe void Process(void* buffer, int bufferSize, InputControl control) {}
	}

	public class Gamepad : UnityEngine.InputSystem.InputDevice, IDualMotorRumble // TypeDefIndex: 45124
	{
		// Fields
		private ButtonControl _buttonWest_k__BackingField; // 0x190
		private ButtonControl _buttonNorth_k__BackingField; // 0x198
		private ButtonControl _buttonSouth_k__BackingField; // 0x1A0
		private ButtonControl _buttonEast_k__BackingField; // 0x1A8
		private ButtonControl _leftStickButton_k__BackingField; // 0x1B0
		private ButtonControl _rightStickButton_k__BackingField; // 0x1B8
		private ButtonControl _startButton_k__BackingField; // 0x1C0
		private ButtonControl _selectButton_k__BackingField; // 0x1C8
		private DpadControl _dpad_k__BackingField; // 0x1D0
		private ButtonControl _leftShoulder_k__BackingField; // 0x1D8
		private ButtonControl _rightShoulder_k__BackingField; // 0x1E0
		private StickControl _leftStick_k__BackingField; // 0x1E8
		private StickControl _rightStick_k__BackingField; // 0x1F0
		private ButtonControl _leftTrigger_k__BackingField; // 0x1F8
		private ButtonControl _rightTrigger_k__BackingField; // 0x200
		private static Gamepad _current_k__BackingField; // 0x00
		private DualMotorRumble m_Rumble; // 0x208
		private static int s_GamepadCount; // 0x08
		private static Gamepad[] s_Gamepads; // 0x10
	
		// Properties
		public ButtonControl buttonWest { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public ButtonControl buttonNorth { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public ButtonControl buttonSouth { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public ButtonControl buttonEast { get; protected set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public ButtonControl leftStickButton { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public ButtonControl rightStickButton { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public ButtonControl startButton { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl selectButton { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public DpadControl dpad { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl leftShoulder { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl rightShoulder { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public StickControl leftStick { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public StickControl rightStick { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public ButtonControl leftTrigger { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public ButtonControl rightTrigger { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public ButtonControl aButton { get => default; } // 0x0000000185FB82F0-0x0000000185FB8300 
		public ButtonControl bButton { get => default; } // 0x0000000185FB82E0-0x0000000185FB82F0 
		public ButtonControl xButton { get => default; } // 0x0000000181B44930-0x0000000181B44940 
		public ButtonControl yButton { get => default; } // 0x0000000185FB88A0-0x0000000185FB88B0 
		public ButtonControl triangleButton { get => default; } // 0x0000000185FB88A0-0x0000000185FB88B0 
		public ButtonControl squareButton { get => default; } // 0x0000000181B44930-0x0000000181B44940 
		public ButtonControl circleButton { get => default; } // 0x0000000185FB82E0-0x0000000185FB82F0 
		public ButtonControl crossButton { get => default; } // 0x0000000185FB82F0-0x0000000185FB8300 
		public ButtonControl this[GamepadButton button] { get => default; } // 0x000000018BCEA6C0-0x000000018BCEA8DC 
		public static Gamepad current { get; private set; } // 0x000000018BCEA94C-0x000000018BCEA984 0x000000018BCEA984-0x000000018BCEA9D4
		public static new ReadOnlyArray<Gamepad> all { get => default; } // 0x000000018BCEA8DC-0x000000018BCEA94C 
	
		// Constructors
		public Gamepad() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCEA1D4-0x000000018BCEA538
		public override void MakeCurrent() {} // 0x000000018BCEA538-0x000000018BCEA540
		protected override void OnAdded() {} // 0x000000018BCEA540-0x000000018BCEA5B0
		protected override void OnRemoved() {} // 0x000000018BCEA5B0-0x000000018BCEA65C
		public virtual void PauseHaptics() {} // 0x000000018BCEA65C-0x000000018BCEA670
		public virtual void ResumeHaptics() {} // 0x000000018BCEA684-0x000000018BCEA698
		public virtual void ResetHaptics() {} // 0x000000018BCEA670-0x000000018BCEA684
		public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x000000018BCEA698-0x000000018BCEA6C0
	}

	public class InputDevice : InputControl // TypeDefIndex: 45127
	{
		// Fields
		public const int InvalidDeviceId = 0; // Metadata: 0x0205BB54
		internal const int kLocalParticipantId = 0; // Metadata: 0x0205BB55
		internal const int kInvalidDeviceIndex = -1; // Metadata: 0x0205BB56
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
		internal const int kControlIndexBits = 10; // Metadata: 0x0205BB57
		internal const int kStateOffsetBits = 13; // Metadata: 0x0205BB58
		internal const int kStateSizeBits = 9; // Metadata: 0x0205BB59
	
		// Properties
		public InputDeviceDescription description { get => default; } // 0x000000018457F890-0x000000018457F950 
		public bool enabled { get => default; } // 0x0000000186470EC4-0x0000000186470ECC 
		public bool canRunInBackground { get => default; } // 0x00000001858D87C0-0x00000001858D8880 
		internal bool canDeviceRunInBackground { get => default; } // 0x0000000184953550-0x0000000184953560 
		public bool added { get => default; } // 0x000000018BCF150C-0x000000018BCF1518 
		public bool remote { get => default; } // 0x0000000185F4C480-0x0000000185F4C490 
		public bool native { get => default; } // 0x00000001841124D0-0x00000001841124E0 
		public bool updateBeforeRender { get => default; } // 0x0000000185FB2330-0x0000000185FB2340 
		public int deviceId { get => default; } // 0x000000018BCF14C4-0x000000018BCF150C 
		public double lastUpdateTime { get => default; } // 0x0000000184CD6B40-0x0000000184CD6B90 
		public bool wasUpdatedThisFrame { get => default; } // 0x0000000185D225F0-0x0000000185D22650 
		public ReadOnlyArray<InputControl> allControls { get => default; } // 0x000000018BCF1564-0x000000018BCF15B4 
		public override System.Type valueType { get => default; } // 0x000000018BCF1518-0x000000018BCF1564 
		public override int valueSizeInBytes { get => default; } // 0x000000018BCF1474-0x000000018BCF14C4 
		public static ReadOnlyArray<InputDevice> all { get => default; } // 0x000000018BCF1448-0x000000018BCF1474 
		internal bool disabledInFrontend { get => default; set {} } // 0x000000018BCF15B4-0x000000018BCF15D4 0x0000000184954A90-0x0000000184954AA0
		internal bool disabledInRuntime { get => default; set {} } // 0x0000000184953940-0x0000000184953970 0x0000000184953930-0x0000000184953940
		internal bool disabledWhileInBackground { get => default; set {} } // 0x0000000184953900-0x0000000184953930 0x0000000185FD7DD0-0x0000000185FD7DE0
		internal bool hasControlsWithDefaultState { get => default; set {} } // 0x0000000185B65AA0-0x0000000185B65AC0 0x0000000184953540-0x0000000184953550
		internal bool hasDontResetControls { get => default; set {} } // 0x0000000185069770-0x0000000185069790 0x0000000184581DB0-0x0000000184581DC0
		internal bool hasStateCallbacks { get => default; set {} } // 0x000000018BCF15D4-0x000000018BCF15F4 0x000000018457F880-0x000000018457F890
		internal bool hasEventMerger { get => default; set {} } // 0x00000001841120D0-0x00000001841120F0 0x0000000185346BB0-0x0000000185346BC0
		internal bool hasEventPreProcessor { get => default; set {} } // 0x0000000184111F00-0x0000000184111F20 0x000000018BCEFF00-0x000000018BCEFFA8
	
		// Nested types
		[Serializable]
		internal enum DeviceFlags // TypeDefIndex: 45125
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
	
		internal struct ControlBitRangeNode // TypeDefIndex: 45126
		{
			// Fields
			public ushort endBitOffset; // 0x00
			public short leftChildIndex; // 0x02
			public ushort controlStartIndex; // 0x04
			public byte controlCount; // 0x06
	
			// Constructors
			public ControlBitRangeNode(ushort endOffset) {
				endBitOffset = default;
				leftChildIndex = default;
				controlStartIndex = default;
				controlCount = default;
			} // 0x0000000185FD7DE0-0x0000000185FD7E20
		}
	
		// Constructors
		public InputDevice() {} // 0x000000018BCF0764-0x000000018BCF07B0
	
		// Methods
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize) => default; // 0x000000018BCF07B0-0x000000018BCF0890
		public override unsafe object ReadValueFromStateAsObject(void* statePtr) => default; // 0x000000018BCF0890-0x000000018BCF0A88
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize) {} // 0x000000018BCF0000-0x000000018BCF0138
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr) => default; // 0x000000018BCF06EC-0x000000018BCF0754
		internal void NotifyConfigurationChanged() {} // 0x0000000185492010-0x0000000185492020
		public virtual void MakeCurrent() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAdded() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRemoved() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnConfigurationChanged() {}
		public long ExecuteCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default; // 0x00000001853CFB00-0x00000001853CFBE0
		protected virtual unsafe long ExecuteCommand(InputDeviceCommand* commandPtr) => default; // 0x000000018457F950-0x000000018457FA00
		internal bool QueryEnabledStateFromRuntime() => default; // 0x0000000184954AA0-0x0000000184954AB0
		internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits) => default; // 0x0000000185FD7DB0-0x0000000185FD7DD0
		internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize) {
			controlIndex = default;
			stateOffset = default;
			stateSize = default;
		} // 0x0000000185F96220-0x0000000185F96300
		internal void AddDeviceUsage(InternedString usage) {} // 0x000000018BCF0A88-0x000000018BCF0B58
		internal void RemoveDeviceUsage(InternedString usage) {} // 0x000000018BCEFFA8-0x000000018BCF0000
		internal void ClearDeviceUsages() {} // 0x0000000184955570-0x00000001849555F0
		internal bool RequestSync() => default; // 0x000000018BCF0B58-0x000000018BCF0BCC
		internal bool RequestReset() => default; // 0x00000001849554F0-0x0000000184955570
		internal bool ExecuteEnableCommand() => default; // 0x0000000184955470-0x00000001849554F0
		internal bool ExecuteDisableCommand() => default; // 0x000000018646DCA8-0x000000018646DCB8
		internal void NotifyAdded() {} // 0x000000018BCF0754-0x000000018BCF0764
		internal void NotifyRemoved() {}
		internal static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = default, bool noPrecompiledLayouts = false /* Metadata: 0x0205BB53 */)
			where TDevice : InputDevice => default; // 0x000000018BCF0F78-0x000000018BCF10FC
		internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice) {} // 0x000000018BCF10FC-0x000000018BCF1448
		private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset) {} // 0x000000018BCF0138-0x000000018BCF0454
		private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output) {} // 0x000000018BCF0454-0x000000018BCF05BC
		private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<string> output) {} // 0x000000018BCF05BC-0x000000018BCF0690
		internal string DumpControlTree() => default; // 0x000000018BCF0BCC-0x000000018BCF0F78
		private unsafe void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset) {} // 0x000000018BCF0690-0x000000018BCF06EC
		private static unsafe bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits) => default; // 0x0000000185FD7E60-0x0000000185FD7E70
	}

	public enum InputDeviceChange // TypeDefIndex: 45128
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

	public class Joystick : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 45129
	{
		// Fields
		private ButtonControl _trigger_k__BackingField; // 0x190
		private StickControl _stick_k__BackingField; // 0x198
		private AxisControl _twist_k__BackingField; // 0x1A0
		private Vector2Control _hatswitch_k__BackingField; // 0x1A8
		private static Joystick _current_k__BackingField; // 0x00
		private static int s_JoystickCount; // 0x08
		private static Joystick[] s_Joysticks; // 0x10
	
		// Properties
		public ButtonControl trigger { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public StickControl stick { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public AxisControl twist { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public Vector2Control hatswitch { get; protected set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public static Joystick current { get; private set; } // 0x000000018BCF8AB0-0x000000018BCF8AE8 0x000000018BCF8AE8-0x000000018BCF8B38
		public static new ReadOnlyArray<Joystick> all { get => default; } // 0x000000018BCF8A40-0x000000018BCF8AB0 
	
		// Constructors
		public Joystick() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCF87D4-0x000000018BCF88F8
		public override void MakeCurrent() {} // 0x000000018BCF88F8-0x000000018BCF8900
		protected override void OnAdded() {} // 0x000000018BCF8900-0x000000018BCF8970
		protected override void OnRemoved() {} // 0x000000018BCF8970-0x000000018BCF8A40
	}

	public enum Key // TypeDefIndex: 45130
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

	internal static class KeyEx // TypeDefIndex: 45131
	{
		// Fields
		internal const UnityEngine.InputSystem.Key IMESelected = UnityEngine.InputSystem.Key.IMESelected; // Metadata: 0x0205BC3E
		internal const UnityEngine.InputSystem.Key RemappedIMESelected = (UnityEngine.InputSystem.Key) 127; // Metadata: 0x0205BC40
	}

	public class Keyboard : UnityEngine.InputSystem.InputDevice, ITextInputReceiver, IEventPreProcessor // TypeDefIndex: 45132
	{
		// Fields
		public const int KeyCount = 110; // Metadata: 0x0205BC42
		internal const int ExtendedKeyCount = 123; // Metadata: 0x0205BC44
		private AnyKeyControl _anyKey_k__BackingField; // 0x190
		private ButtonControl _shiftKey_k__BackingField; // 0x198
		private ButtonControl _ctrlKey_k__BackingField; // 0x1A0
		private ButtonControl _altKey_k__BackingField; // 0x1A8
		private ButtonControl _imeSelected_k__BackingField; // 0x1B0
		private static Keyboard _current_k__BackingField; // 0x00
		private InlinedArray<Action<char>> m_TextInputListeners; // 0x1B8
		private string m_KeyboardLayoutName; // 0x1D0
		private KeyControl[] m_Keys; // 0x1D8
		private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners; // 0x1E0
	
		// Properties
		public string keyboardLayout { get => default; protected set {} } // 0x000000018BCFA760-0x000000018BCFA780 0x000000018647357C-0x0000000186473590
		public AnyKeyControl anyKey { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public KeyControl spaceKey { get => default; } // 0x000000018BCFAAD0-0x000000018BCFAAE0 
		public KeyControl enterKey { get => default; } // 0x000000018BCFA530-0x000000018BCFA540 
		public KeyControl tabKey { get => default; } // 0x000000018BCFAAF0-0x000000018BCFAB00 
		public KeyControl backquoteKey { get => default; } // 0x000000018BCFA398-0x000000018BCFA3A8 
		public KeyControl quoteKey { get => default; } // 0x000000018BCFAA10-0x000000018BCFAA20 
		public KeyControl semicolonKey { get => default; } // 0x000000018BCFAAB0-0x000000018BCFAAC0 
		public KeyControl commaKey { get => default; } // 0x000000018BCFA3E8-0x000000018BCFA3F8 
		public KeyControl periodKey { get => default; } // 0x000000018BCFA9E0-0x000000018BCFA9F0 
		public KeyControl slashKey { get => default; } // 0x000000018BCFAAC0-0x000000018BCFAAD0 
		public KeyControl backslashKey { get => default; } // 0x000000018BCFA3A8-0x000000018BCFA3B8 
		public KeyControl leftBracketKey { get => default; } // 0x000000018BCFA7C0-0x000000018BCFA7D0 
		public KeyControl rightBracketKey { get => default; } // 0x000000018BCFAA60-0x000000018BCFAA70 
		public KeyControl minusKey { get => default; } // 0x000000018BCFA800-0x000000018BCFA810 
		public KeyControl equalsKey { get => default; } // 0x000000018BCFA540-0x000000018BCFA550 
		public KeyControl aKey { get => default; } // 0x000000018BCFA320-0x000000018BCFA330 
		public KeyControl bKey { get => default; } // 0x000000018BCFA388-0x000000018BCFA398 
		public KeyControl cKey { get => default; } // 0x000000018BCFA3C8-0x000000018BCFA3D8 
		public KeyControl dKey { get => default; } // 0x000000018BCFA440-0x000000018BCFA450 
		public KeyControl eKey { get => default; } // 0x000000018BCFA510-0x000000018BCFA520 
		public KeyControl fKey { get => default; } // 0x000000018BCFA6E0-0x000000018BCFA6F0 
		public KeyControl gKey { get => default; } // 0x000000018BCFA6F0-0x000000018BCFA700 
		public KeyControl hKey { get => default; } // 0x000000018BCFA700-0x000000018BCFA710 
		public KeyControl iKey { get => default; } // 0x000000018BCFA720-0x000000018BCFA730 
		public KeyControl jKey { get => default; } // 0x000000018BCFA740-0x000000018BCFA750 
		public KeyControl kKey { get => default; } // 0x000000018BCFA750-0x000000018BCFA760 
		public KeyControl lKey { get => default; } // 0x000000018BCFA780-0x000000018BCFA790 
		public KeyControl mKey { get => default; } // 0x000000018BCFA7F0-0x000000018BCFA800 
		public KeyControl nKey { get => default; } // 0x000000018BCFA810-0x000000018BCFA820 
		public KeyControl oKey { get => default; } // 0x000000018BCFA940-0x000000018BCFA950 
		public KeyControl pKey { get => default; } // 0x000000018BCFA9A0-0x000000018BCFA9B0 
		public KeyControl qKey { get => default; } // 0x000000018BCFAA00-0x000000018BCFAA10 
		public KeyControl rKey { get => default; } // 0x000000018BCFAA20-0x000000018BCFAA30 
		public KeyControl sKey { get => default; } // 0x000000018BCFAA90-0x000000018BCFAAA0 
		public KeyControl tKey { get => default; } // 0x000000018BCFAAE0-0x000000018BCFAAF0 
		public KeyControl uKey { get => default; } // 0x000000018BCFAB00-0x000000018BCFAB10 
		public KeyControl vKey { get => default; } // 0x000000018BCFAB20-0x000000018BCFAB30 
		public KeyControl wKey { get => default; } // 0x000000018BCFAB30-0x000000018BCFAB40 
		public KeyControl xKey { get => default; } // 0x000000018BCFAB40-0x000000018BCFAB50 
		public KeyControl yKey { get => default; } // 0x000000018BCFAB50-0x000000018BCFAB60 
		public KeyControl zKey { get => default; } // 0x000000018BCFAB60-0x000000018BCFAB70 
		public KeyControl digit1Key { get => default; } // 0x000000018BCFA470-0x000000018BCFA480 
		public KeyControl digit2Key { get => default; } // 0x000000018BCFA480-0x000000018BCFA490 
		public KeyControl digit3Key { get => default; } // 0x000000018BCFA490-0x000000018BCFA4A0 
		public KeyControl digit4Key { get => default; } // 0x000000018BCFA4A0-0x000000018BCFA4B0 
		public KeyControl digit5Key { get => default; } // 0x000000018BCFA4B0-0x000000018BCFA4C0 
		public KeyControl digit6Key { get => default; } // 0x000000018BCFA4C0-0x000000018BCFA4D0 
		public KeyControl digit7Key { get => default; } // 0x000000018BCFA4D0-0x000000018BCFA4E0 
		public KeyControl digit8Key { get => default; } // 0x000000018BCFA4E0-0x000000018BCFA4F0 
		public KeyControl digit9Key { get => default; } // 0x000000018BCFA4F0-0x000000018BCFA500 
		public KeyControl digit0Key { get => default; } // 0x000000018BCFA460-0x000000018BCFA470 
		public KeyControl leftShiftKey { get => default; } // 0x000000018BCFA7E0-0x000000018BCFA7F0 
		public KeyControl rightShiftKey { get => default; } // 0x000000018BCFAA80-0x000000018BCFAA90 
		public KeyControl leftAltKey { get => default; } // 0x000000018BCFA790-0x000000018BCFA7A0 
		public KeyControl rightAltKey { get => default; } // 0x000000018BCFAA30-0x000000018BCFAA40 
		public KeyControl leftCtrlKey { get => default; } // 0x000000018BCFA7D0-0x000000018BCFA7E0 
		public KeyControl rightCtrlKey { get => default; } // 0x000000018BCFAA70-0x000000018BCFAA80 
		public KeyControl leftMetaKey { get => default; } // 0x000000018BCFA7A0-0x000000018BCFA7B0 
		public KeyControl rightMetaKey { get => default; } // 0x000000018BCFAA40-0x000000018BCFAA50 
		public KeyControl leftWindowsKey { get => default; } // 0x000000018BCFA7A0-0x000000018BCFA7B0 
		public KeyControl rightWindowsKey { get => default; } // 0x000000018BCFAA40-0x000000018BCFAA50 
		public KeyControl leftAppleKey { get => default; } // 0x000000018BCFA7A0-0x000000018BCFA7B0 
		public KeyControl rightAppleKey { get => default; } // 0x000000018BCFAA40-0x000000018BCFAA50 
		public KeyControl leftCommandKey { get => default; } // 0x000000018BCFA7A0-0x000000018BCFA7B0 
		public KeyControl rightCommandKey { get => default; } // 0x000000018BCFAA40-0x000000018BCFAA50 
		public KeyControl contextMenuKey { get => default; } // 0x000000018BCFA3F8-0x000000018BCFA408 
		public KeyControl escapeKey { get => default; } // 0x000000018BCFA550-0x000000018BCFA560 
		public KeyControl leftArrowKey { get => default; } // 0x000000018BCFA7B0-0x000000018BCFA7C0 
		public KeyControl rightArrowKey { get => default; } // 0x000000018BCFAA50-0x000000018BCFAA60 
		public KeyControl upArrowKey { get => default; } // 0x000000018BCFAB10-0x000000018BCFAB20 
		public KeyControl downArrowKey { get => default; } // 0x000000018BCFA500-0x000000018BCFA510 
		public KeyControl backspaceKey { get => default; } // 0x000000018BCFA3B8-0x000000018BCFA3C8 
		public KeyControl pageDownKey { get => default; } // 0x000000018BCFA9B0-0x000000018BCFA9C0 
		public KeyControl pageUpKey { get => default; } // 0x000000018BCFA9C0-0x000000018BCFA9D0 
		public KeyControl homeKey { get => default; } // 0x000000018BCFA710-0x000000018BCFA720 
		public KeyControl endKey { get => default; } // 0x000000018BCFA520-0x000000018BCFA530 
		public KeyControl insertKey { get => default; } // 0x000000018BCFA730-0x000000018BCFA740 
		public KeyControl deleteKey { get => default; } // 0x000000018BCFA450-0x000000018BCFA460 
		public KeyControl capsLockKey { get => default; } // 0x000000018BCFA3D8-0x000000018BCFA3E8 
		public KeyControl scrollLockKey { get => default; } // 0x000000018BCFAAA0-0x000000018BCFAAB0 
		public KeyControl numLockKey { get => default; } // 0x000000018BCFA820-0x000000018BCFA830 
		public KeyControl printScreenKey { get => default; } // 0x000000018BCFA9F0-0x000000018BCFAA00 
		public KeyControl pauseKey { get => default; } // 0x000000018BCFA9D0-0x000000018BCFA9E0 
		public KeyControl numpadEnterKey { get => default; } // 0x000000018BCFA8E0-0x000000018BCFA8F0 
		public KeyControl numpadDivideKey { get => default; } // 0x000000018BCFA8D0-0x000000018BCFA8E0 
		public KeyControl numpadMultiplyKey { get => default; } // 0x000000018BCFA910-0x000000018BCFA920 
		public KeyControl numpadMinusKey { get => default; } // 0x000000018BCFA900-0x000000018BCFA910 
		public KeyControl numpadPlusKey { get => default; } // 0x000000018BCFA930-0x000000018BCFA940 
		public KeyControl numpadPeriodKey { get => default; } // 0x000000018BCFA920-0x000000018BCFA930 
		public KeyControl numpadEqualsKey { get => default; } // 0x000000018BCFA8F0-0x000000018BCFA900 
		public KeyControl numpad0Key { get => default; } // 0x000000018BCFA830-0x000000018BCFA840 
		public KeyControl numpad1Key { get => default; } // 0x000000018BCFA840-0x000000018BCFA850 
		public KeyControl numpad2Key { get => default; } // 0x000000018BCFA850-0x000000018BCFA860 
		public KeyControl numpad3Key { get => default; } // 0x000000018BCFA860-0x000000018BCFA870 
		public KeyControl numpad4Key { get => default; } // 0x000000018BCFA870-0x000000018BCFA880 
		public KeyControl numpad5Key { get => default; } // 0x000000018BCFA880-0x000000018BCFA890 
		public KeyControl numpad6Key { get => default; } // 0x000000018BCFA890-0x000000018BCFA8A0 
		public KeyControl numpad7Key { get => default; } // 0x000000018BCFA8A0-0x000000018BCFA8B0 
		public KeyControl numpad8Key { get => default; } // 0x000000018BCFA8B0-0x000000018BCFA8C0 
		public KeyControl numpad9Key { get => default; } // 0x000000018BCFA8C0-0x000000018BCFA8D0 
		public KeyControl f1Key { get => default; } // 0x000000018BCFA600-0x000000018BCFA610 
		public KeyControl f2Key { get => default; } // 0x000000018BCFA660-0x000000018BCFA670 
		public KeyControl f3Key { get => default; } // 0x000000018BCFA670-0x000000018BCFA680 
		public KeyControl f4Key { get => default; } // 0x000000018BCFA680-0x000000018BCFA690 
		public KeyControl f5Key { get => default; } // 0x000000018BCFA690-0x000000018BCFA6A0 
		public KeyControl f6Key { get => default; } // 0x000000018BCFA6A0-0x000000018BCFA6B0 
		public KeyControl f7Key { get => default; } // 0x000000018BCFA6B0-0x000000018BCFA6C0 
		public KeyControl f8Key { get => default; } // 0x000000018BCFA6C0-0x000000018BCFA6D0 
		public KeyControl f9Key { get => default; } // 0x000000018BCFA6D0-0x000000018BCFA6E0 
		public KeyControl f10Key { get => default; } // 0x000000018BCFA560-0x000000018BCFA570 
		public KeyControl f11Key { get => default; } // 0x000000018BCFA570-0x000000018BCFA580 
		public KeyControl f12Key { get => default; } // 0x000000018BCFA580-0x000000018BCFA590 
		public KeyControl oem1Key { get => default; } // 0x000000018BCFA950-0x000000018BCFA960 
		public KeyControl oem2Key { get => default; } // 0x000000018BCFA960-0x000000018BCFA970 
		public KeyControl oem3Key { get => default; } // 0x000000018BCFA970-0x000000018BCFA980 
		public KeyControl oem4Key { get => default; } // 0x000000018BCFA980-0x000000018BCFA990 
		public KeyControl oem5Key { get => default; } // 0x000000018BCFA990-0x000000018BCFA9A0 
		public KeyControl f13Key { get => default; } // 0x000000018BCFA590-0x000000018BCFA5A0 
		public KeyControl f14Key { get => default; } // 0x000000018BCFA5A0-0x000000018BCFA5B0 
		public KeyControl f15Key { get => default; } // 0x000000018BCFA5B0-0x000000018BCFA5C0 
		public KeyControl f16Key { get => default; } // 0x000000018BCFA5C0-0x000000018BCFA5D0 
		public KeyControl f17Key { get => default; } // 0x000000018BCFA5D0-0x000000018BCFA5E0 
		public KeyControl f18Key { get => default; } // 0x000000018BCFA5E0-0x000000018BCFA5F0 
		public KeyControl f19Key { get => default; } // 0x000000018BCFA5F0-0x000000018BCFA600 
		public KeyControl f20Key { get => default; } // 0x000000018BCFA610-0x000000018BCFA620 
		public KeyControl f21Key { get => default; } // 0x000000018BCFA620-0x000000018BCFA630 
		public KeyControl f22Key { get => default; } // 0x000000018BCFA630-0x000000018BCFA640 
		public KeyControl f23Key { get => default; } // 0x000000018BCFA640-0x000000018BCFA650 
		public KeyControl f24Key { get => default; } // 0x000000018BCFA650-0x000000018BCFA660 
		public ButtonControl shiftKey { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public ButtonControl ctrlKey { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public ButtonControl altKey { get; protected set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public ButtonControl imeSelected { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public KeyControl this[UnityEngine.InputSystem.Key key] { get => default; } // 0x000000018BCFA28C-0x000000018BCFA320 
		public ReadOnlyArray<KeyControl> allKeys { get => default; } // 0x000000018BCFA330-0x000000018BCFA388 
		public static Keyboard current { get; private set; } // 0x000000018BCFA408-0x000000018BCFA440 0x000000018BCFAC08-0x000000018BCFAC58
		protected KeyControl[] keys { get => default; set {} } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
	
		// Events
		public event Action<char> onTextInput;
		public event Action<IMECompositionString> onIMECompositionChange;
	
		// Constructors
		public Keyboard() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public void SetIMEEnabled(bool enabled) {} // 0x000000018BCFA03C-0x000000018BCFA0C4
		public void SetIMECursorPosition(Vector2 position) {} // 0x000000018BCF9FC8-0x000000018BCFA03C
		public override void MakeCurrent() {} // 0x000000018586BF20-0x000000018586BF80
		protected override void OnRemoved() {} // 0x000000018BCF9EA4-0x000000018BCF9ECC
		protected override void FinishSetup() {} // 0x000000018BCF8C04-0x000000018BCF9DB8
		protected override void RefreshConfiguration() {} // 0x000000018BCF9ECC-0x000000018BCF9FC8
		public void OnTextInput(char character) {} // 0x0000000185562820-0x0000000185562880
		public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) => default; // 0x000000018BCF8B38-0x000000018BCF8C04
		public void OnIMECompositionChanged(IMECompositionString compositionString) {} // 0x000000018BCF9DB8-0x000000018BCF9EA4
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) => default; // 0x0000000185370760-0x0000000185370800
	}

	public class Mouse : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver // TypeDefIndex: 45133
	{
		// Fields
		private DeltaControl _scroll_k__BackingField; // 0x1C0
		private ButtonControl _leftButton_k__BackingField; // 0x1C8
		private ButtonControl _middleButton_k__BackingField; // 0x1D0
		private ButtonControl _rightButton_k__BackingField; // 0x1D8
		private ButtonControl _backButton_k__BackingField; // 0x1E0
		private ButtonControl _forwardButton_k__BackingField; // 0x1E8
		private IntegerControl _clickCount_k__BackingField; // 0x1F0
		private static Mouse _current_k__BackingField; // 0x00
		internal static Mouse s_PlatformMouseDevice; // 0x08
	
		// Properties
		public DeltaControl scroll { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl leftButton { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl middleButton { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl rightButton { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl backButton { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl forwardButton { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public IntegerControl clickCount { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public static new Mouse current { get; private set; } // 0x000000018BCFAFB8-0x000000018BCFAFF0 0x000000018BCFAFF0-0x000000018BCFB040
	
		// Constructors
		public Mouse() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018502F590-0x000000018502F5B0
		protected override void OnAdded() {} // 0x0000000185F4C410-0x0000000185F4C480
		protected override void OnRemoved() {} // 0x000000018BCFAEB4-0x000000018BCFAEE0
		public void WarpCursorPosition(Vector2 position) {} // 0x000000018BCFAF44-0x000000018BCFAFB8
		protected override void FinishSetup() {} // 0x000000018BCFAC58-0x000000018BCFAE50
		protected new void OnNextUpdate() {} // 0x000000018BCFAE50-0x000000018BCFAEB4
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BCFAEE0-0x000000018BCFAF34
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018BCFAF34-0x000000018BCFAF3C
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BCFAF3C-0x000000018BCFAF44
	}

	public enum PenButton // TypeDefIndex: 45134
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

	public class Pen : UnityEngine.InputSystem.Pointer // TypeDefIndex: 45135
	{
		// Fields
		private ButtonControl _tip_k__BackingField; // 0x1C0
		private ButtonControl _eraser_k__BackingField; // 0x1C8
		private ButtonControl _firstBarrelButton_k__BackingField; // 0x1D0
		private ButtonControl _secondBarrelButton_k__BackingField; // 0x1D8
		private ButtonControl _thirdBarrelButton_k__BackingField; // 0x1E0
		private ButtonControl _fourthBarrelButton_k__BackingField; // 0x1E8
		private ButtonControl _inRange_k__BackingField; // 0x1F0
		private Vector2Control _tilt_k__BackingField; // 0x1F8
		private AxisControl _twist_k__BackingField; // 0x200
		private static Pen _current_k__BackingField; // 0x00
	
		// Properties
		public ButtonControl tip { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl eraser { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl firstBarrelButton { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public ButtonControl secondBarrelButton { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl thirdBarrelButton { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl fourthBarrelButton { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public ButtonControl inRange { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public Vector2Control tilt { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public AxisControl twist { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public static new Pen current { get; internal set; } // 0x000000018BCFB454-0x000000018BCFB48C 0x000000018BCFB48C-0x000000018BCFB4DC
		public ButtonControl this[PenButton button] { get => default; } // 0x000000018BCFB320-0x000000018BCFB454 
	
		// Constructors
		public Pen() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFB2B0-0x000000018BCFB2CC
		protected override void OnRemoved() {} // 0x000000018BCFB2CC-0x000000018BCFB320
		protected override void FinishSetup() {} // 0x000000018BCFB040-0x000000018BCFB2B0
	}

	public class Pointer : UnityEngine.InputSystem.InputDevice, IInputStateCallbackReceiver // TypeDefIndex: 45136
	{
		// Fields
		private Vector2Control _position_k__BackingField; // 0x190
		private DeltaControl _delta_k__BackingField; // 0x198
		private Vector2Control _radius_k__BackingField; // 0x1A0
		private AxisControl _pressure_k__BackingField; // 0x1A8
		private ButtonControl _press_k__BackingField; // 0x1B0
		private IntegerControl _displayIndex_k__BackingField; // 0x1B8
		private static Pointer _current_k__BackingField; // 0x00
	
		// Properties
		public Vector2Control position { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public DeltaControl delta { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public Vector2Control radius { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public AxisControl pressure { get; protected set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public ButtonControl press { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public IntegerControl displayIndex { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public static Pointer current { get; internal set; } // 0x000000018BCFB75C-0x000000018BCFB794 0x000000018BCFB794-0x000000018BCFBED0
	
		// Constructors
		public Pointer() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018502F5B0-0x000000018502F6D0
		protected override void OnRemoved() {} // 0x000000018BCFB6D0-0x000000018BCFB6F8
		protected override void FinishSetup() {} // 0x000000018BCFB4DC-0x000000018BCFB678
		protected void OnNextUpdate() {} // 0x000000018BCFB678-0x000000018BCFB6D0
		protected void OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BCFB6F8-0x000000018BCFB74C
		void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018BCFB74C-0x000000018BCFB754
		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BCFB754-0x000000018BCFB75C
		bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	internal class FastKeyboard : UnityEngine.InputSystem.Keyboard // TypeDefIndex: 45137
	{
		// Fields
		public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard"; // Metadata: 0x0205BC51
	
		// Constructors
		public FastKeyboard() {} // 0x0000000184D59340-0x0000000184D5C750
	
		// Methods
		private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) => default; // 0x0000000185BA4340-0x0000000185BA4530
		private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4C90-0x0000000185BC4E80
		private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE5E0-0x0000000185BFE7C0
		private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4890-0x0000000185BC4A90
		private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE220-0x0000000185BFE400
		private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04B20-0x0000000185C04D00
		private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFF4E0-0x0000000185BFF6C0
		private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE9A0-0x0000000185BFEB80
		private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C041C0-0x0000000185C043A0
		private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFFA80-0x0000000185BFFC60
		private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE7C0-0x0000000185BFE9A0
		private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04940-0x0000000185C04B20
		private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C021E0-0x0000000185C023C0
		private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFEF40-0x0000000185BFF120
		private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C01E20-0x0000000185C02000
		private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03680-0x0000000185C03860
		private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFDE60-0x0000000185BFE040
		private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03C20-0x0000000185C03E00
		private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C023C0-0x0000000185C025A0
		private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFF120-0x0000000185BFF300
		private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04EE0-0x0000000185C050C0
		private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04D00-0x0000000185C04EE0
		private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04580-0x0000000185C04760
		private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03FE0-0x0000000185C041C0
		private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03A40-0x0000000185C03C20
		private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C034A0-0x0000000185C03680
		private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C032C0-0x0000000185C034A0
		private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C030E0-0x0000000185C032C0
		private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02D20-0x0000000185C02F00
		private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02960-0x0000000185C02B40
		private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02780-0x0000000185C02960
		private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C025A0-0x0000000185C02780
		private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02000-0x0000000185C021E0
		private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C01C40-0x0000000185C01E20
		private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C003E0-0x0000000185C005C0
		private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00200-0x0000000185C003E0
		private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFF6C0-0x0000000185BFF8A0
		private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFF300-0x0000000185BFF4E0
		private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFED60-0x0000000185BFEF40
		private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE400-0x0000000185BFE5E0
		private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFE040-0x0000000185BFE220
		private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFDC80-0x0000000185BFDE60
		private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFDAA0-0x0000000185BFDC80
		private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFD8C0-0x0000000185BFDAA0
		private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFD6E0-0x0000000185BFD8C0
		private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFD500-0x0000000185BFD6E0
		private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1D2A0-0x0000000185C1D480
		private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1D0C0-0x0000000185C1D2A0
		private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1CEE0-0x0000000185C1D0C0
		private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1CD00-0x0000000185C1CEE0
		private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1CB20-0x0000000185C1CD00
		private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1C940-0x0000000185C1CB20
		private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1C760-0x0000000185C1C940
		private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1C580-0x0000000185C1C760
		private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1C3A0-0x0000000185C1C580
		private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C1D480-0x0000000185C1D660
		private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4290-0x0000000185BC4490
		private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC3E90-0x0000000185BC4090
		private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001858E33C0-0x00000001858E35E0
		private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4690-0x0000000185BC4890
		private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BB6160-0x0000000185BB6360
		private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001858E35E0-0x00000001858E3800
		private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4490-0x0000000185BC4690
		private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4090-0x0000000185BC4290
		private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001858E3800-0x00000001858E3A20
		private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BB5940-0x0000000185BB5B50
		private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BB5730-0x0000000185BB5940
		private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BC4A90-0x0000000185BC4C90
		private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C04760-0x0000000185C04940
		private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00020-0x0000000185C00200
		private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFFE40-0x0000000185C00020
		private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02F00-0x0000000185C030E0
		private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03860-0x0000000185C03A40
		private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C02B40-0x0000000185C02D20
		private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C03E00-0x0000000185C03FE0
		private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C043A0-0x0000000185C04580
		private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C01A60-0x0000000185C01C40
		private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFF8A0-0x0000000185BFFA80
		private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFEB80-0x0000000185BFED60
		private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185BFFC60-0x0000000185BFFE40
		private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00F20-0x0000000185C01100
		private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C01100-0x0000000185C012E0
		private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00980-0x0000000185C00B60
		private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C005C0-0x0000000185C007A0
		private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00B60-0x0000000185C00D40
		private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C007A0-0x0000000185C00980
		private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C00D40-0x0000000185C00F20
		private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C01880-0x0000000185C01A60
		private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C016A0-0x0000000185C01880
		private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C014C0-0x0000000185C016A0
		private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185C012E0-0x0000000185C014C0
		private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185508930-0x0000000185508B10
		private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185508750-0x0000000185508930
		private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185508570-0x0000000185508750
		private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185508390-0x0000000185508570
		private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855081B0-0x0000000185508390
		private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507FD0-0x00000001855081B0
		private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507DF0-0x0000000185507FD0
		private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507C10-0x0000000185507DF0
		private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507A30-0x0000000185507C10
		private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507850-0x0000000185507A30
		private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507670-0x0000000185507850
		private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185507490-0x0000000185507670
		private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855072B0-0x0000000185507490
		private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855070D0-0x00000001855072B0
		private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506EF0-0x00000001855070D0
		private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506D10-0x0000000185506EF0
		private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506B30-0x0000000185506D10
		private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506950-0x0000000185506B30
		private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185504970-0x0000000185504B50
		private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185504B50-0x0000000185504D30
		private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185504D30-0x0000000185504F10
		private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185504F10-0x00000001855050F0
		private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855050F0-0x00000001855052D0
		private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855052D0-0x00000001855054B0
		private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855054B0-0x0000000185505690
		private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505690-0x0000000185505870
		private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505870-0x0000000185505A50
		private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505A50-0x0000000185505C30
		private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505C30-0x0000000185505E10
		private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505E10-0x0000000185505FF0
		private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185505FF0-0x00000001855061D0
		private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855061D0-0x00000001855063B0
		private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001855063B0-0x0000000185506590
		private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506590-0x0000000185506770
		private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000185506770-0x0000000185506950
		private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185C16020-0x0000000185C16200
	}

	internal class FastMouse : UnityEngine.InputSystem.Mouse, IInputStateCallbackReceiver, IEventMerger // TypeDefIndex: 45138
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer"; // Metadata: 0x0205BC81
	
		// Constructors
		public FastMouse() {} // 0x0000000185114F00-0x0000000185115CF0
	
		// Methods
		private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018506F140-0x000000018506F300
		private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x000000018506EFA0-0x000000018506F140
		private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) => default; // 0x000000018506EE10-0x000000018506EFA0
		private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506EC20-0x000000018506EE10
		private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506EA10-0x000000018506EC20
		private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506E800-0x000000018506EA10
		private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506E600-0x000000018506E800
		private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506E410-0x000000018506E600
		private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506E1D0-0x000000018506E3F0
		private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506E010-0x000000018506E1D0
		private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018506DE40-0x000000018506DFE0
		private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) => default; // 0x000000018506BDB0-0x000000018506BF20
		private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018506BF20-0x000000018506C0A0
		private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018506C0A0-0x000000018506C230
		private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506C230-0x000000018506C3E0
		private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506C3E0-0x000000018506C590
		private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506C590-0x000000018506C740
		private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506C740-0x000000018506C900
		private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506C900-0x000000018506CAC0
		private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506CAC0-0x000000018506CC70
		private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506CC70-0x000000018506CE00
		private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506CE00-0x000000018506CF90
		private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506CF90-0x000000018506D140
		private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506D140-0x000000018506D300
		private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506D300-0x000000018506D4C0
		private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506D4C0-0x000000018506D6A0
		private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506D6C0-0x000000018506D870
		private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506D870-0x000000018506DA30
		private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506DA30-0x000000018506DBC0
		private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506DBC0-0x000000018506DDE0
		protected new void OnNextUpdate() {} // 0x0000000184BFA430-0x0000000184BFA580
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000184BFA220-0x0000000184BFA430
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018646F40C-0x000000018646F414
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x00000001864733D4-0x00000001864733DC
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x0000000184580900-0x0000000184580A40
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x000000018646F3F0-0x000000018646F404
	}

	internal class FastTouchscreen : Touchscreen // TypeDefIndex: 45139
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer"; // Metadata: 0x0205BCCA
	
		// Constructors
		public FastTouchscreen() {} // 0x0000000185115CF0-0x000000018511AF10
	
		// Methods
		private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FCF00-0x00000001856FD090
		private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C2EAD0-0x0000000185C2EC90
		private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185065BB0-0x0000000185065D50
		private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) => default; // 0x0000000185B658A0-0x0000000185B65AA0
		private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C47880-0x0000000185C47A20
		private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001850730E0-0x0000000185073390
		private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185114B00-0x0000000185114F00
		private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD090-0x00000001856FD220
		private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD220-0x00000001856FD3B0
		private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD3B0-0x00000001856FD540
		private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD540-0x00000001856FD6D0
		private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD6D0-0x00000001856FD860
		private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD860-0x00000001856FD9F0
		private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FD9F0-0x00000001856FDB80
		private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FDB80-0x00000001856FDD10
		private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FDD10-0x00000001856FDEA0
		private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001856FDEA0-0x00000001856FE030
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185C33020-0x0000000185C331E0
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C32C90-0x0000000185C32E60
		private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185065D50-0x0000000185065EF0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64650-0x0000000185C647E0
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4CEE0-0x0000000185C4D200
		private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C512E0-0x0000000185C51480
		private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072EF0-0x00000001850730E0
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185C63E80-0x0000000185C64010
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185C647E0-0x0000000185C64970
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BC3C90-0x0000000185BC3E90
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BC3A90-0x0000000185BC3C90
		private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C51140-0x0000000185C512E0
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C33DB0-0x0000000185C33F60
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F570-0x0000000185C4F720
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F3C0-0x0000000185C4F570
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C30280-0x0000000185C30430
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27FC0-0x0000000185C28180
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27E00-0x0000000185C27FC0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C30430-0x0000000185C305E0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64B00-0x0000000185C64C90
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64970-0x0000000185C64B00
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C644C0-0x0000000185C64650
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64330-0x0000000185C644C0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C641A0-0x0000000185C64330
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64010-0x0000000185C641A0
		private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F8D0-0x0000000185C4FA80
		private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F720-0x0000000185C4F8D0
		private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C305E0-0x0000000185C30790
		private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C28340-0x0000000185C28500
		private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C28180-0x0000000185C28340
		private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C30790-0x0000000185C30940
		private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64E20-0x0000000185C64FB0
		private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C64C90-0x0000000185C64E20
		private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63CF0-0x0000000185C63E80
		private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63B60-0x0000000185C63CF0
		private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185C38C00-0x0000000185C38DC0
		private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C32AC0-0x0000000185C32C90
		private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185065EF0-0x0000000185066090
		private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C636B0-0x0000000185C63840
		private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4CD40-0x0000000185C4CEE0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C50FA0-0x0000000185C51140
		private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072D00-0x0000000185072EF0
		private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185C62EE0-0x0000000185C63070
		private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x00000001851122B0-0x0000000185112440
		private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BC3890-0x0000000185BC3A90
		private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BFD310-0x0000000185BFD500
		private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C50E00-0x0000000185C50FA0
		private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C33C00-0x0000000185C33DB0
		private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F210-0x0000000185C4F3C0
		private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4F060-0x0000000185C4F210
		private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2FF20-0x0000000185C300D0
		private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27C40-0x0000000185C27E00
		private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27A80-0x0000000185C27C40
		private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C300D0-0x0000000185C30280
		private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C639D0-0x0000000185C63B60
		private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63840-0x0000000185C639D0
		private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63520-0x0000000185C636B0
		private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63390-0x0000000185C63520
		private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63200-0x0000000185C63390
		private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C63070-0x0000000185C63200
		private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112440-0x0000000185112600
		private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C328F0-0x0000000185C32AC0
		private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066090-0x0000000185066230
		private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62A30-0x0000000185C62BC0
		private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4CBA0-0x0000000185C4CD40
		private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C50C60-0x0000000185C50E00
		private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072B10-0x0000000185072D00
		private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112600-0x0000000185112790
		private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112790-0x0000000185112920
		private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BC3690-0x0000000185BC3890
		private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BFD120-0x0000000185BFD310
		private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C50AC0-0x0000000185C50C60
		private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C33A50-0x0000000185C33C00
		private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4EEB0-0x0000000185C4F060
		private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4ED00-0x0000000185C4EEB0
		private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2FBC0-0x0000000185C2FD70
		private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C278C0-0x0000000185C27A80
		private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27700-0x0000000185C278C0
		private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2FD70-0x0000000185C2FF20
		private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62D50-0x0000000185C62EE0
		private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62BC0-0x0000000185C62D50
		private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C628A0-0x0000000185C62A30
		private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62710-0x0000000185C628A0
		private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62580-0x0000000185C62710
		private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C623F0-0x0000000185C62580
		private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112920-0x0000000185112AE0
		private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C32720-0x0000000185C328F0
		private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066230-0x00000001850663D0
		private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61F40-0x0000000185C620D0
		private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4CA00-0x0000000185C4CBA0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C50920-0x0000000185C50AC0
		private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072920-0x0000000185072B10
		private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112AE0-0x0000000185112C70
		private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112C70-0x0000000185112E00
		private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BC3490-0x0000000185BC3690
		private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185BFCF30-0x0000000185BFD120
		private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C50780-0x0000000185C50920
		private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C338A0-0x0000000185C33A50
		private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4EB50-0x0000000185C4ED00
		private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4E9A0-0x0000000185C4EB50
		private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2F860-0x0000000185C2FA10
		private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27540-0x0000000185C27700
		private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27380-0x0000000185C27540
		private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2FA10-0x0000000185C2FBC0
		private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C62260-0x0000000185C623F0
		private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C620D0-0x0000000185C62260
		private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61DB0-0x0000000185C61F40
		private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61C20-0x0000000185C61DB0
		private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61A90-0x0000000185C61C20
		private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61900-0x0000000185C61A90
		private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112E00-0x0000000185112FC0
		private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C32550-0x0000000185C32720
		private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x00000001850663D0-0x0000000185066570
		private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61450-0x0000000185C615E0
		private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4C860-0x0000000185C4CA00
		private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C505E0-0x0000000185C50780
		private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072730-0x0000000185072920
		private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185112FC0-0x0000000185113150
		private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113150-0x00000001851132E0
		private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185072530-0x0000000185072730
		private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185072340-0x0000000185072530
		private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C50440-0x0000000185C505E0
		private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C336F0-0x0000000185C338A0
		private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4E7F0-0x0000000185C4E9A0
		private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C4E640-0x0000000185C4E7F0
		private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2F500-0x0000000185C2F6B0
		private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C271C0-0x0000000185C27380
		private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C27000-0x0000000185C271C0
		private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2F6B0-0x0000000185C2F860
		private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61770-0x0000000185C61900
		private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C615E0-0x0000000185C61770
		private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C612C0-0x0000000185C61450
		private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C61130-0x0000000185C612C0
		private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60FA0-0x0000000185C61130
		private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60E10-0x0000000185C60FA0
		private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x00000001851132E0-0x00000001851134A0
		private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C32380-0x0000000185C32550
		private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066570-0x0000000185066710
		private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60960-0x0000000185C60AF0
		private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4C6C0-0x0000000185C4C860
		private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C502A0-0x0000000185C50440
		private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185072150-0x0000000185072340
		private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x00000001851134A0-0x0000000185113630
		private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113630-0x00000001851137C0
		private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185071F50-0x0000000185072150
		private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185071D60-0x0000000185071F50
		private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C50100-0x0000000185C502A0
		private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C33540-0x0000000185C336F0
		private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001850677D0-0x0000000185067980
		private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185067980-0x0000000185067B30
		private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2F1A0-0x0000000185C2F350
		private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26E40-0x0000000185C27000
		private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26C80-0x0000000185C26E40
		private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2F350-0x0000000185C2F500
		private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60C80-0x0000000185C60E10
		private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60AF0-0x0000000185C60C80
		private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C607D0-0x0000000185C60960
		private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60640-0x0000000185C607D0
		private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C604B0-0x0000000185C60640
		private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60320-0x0000000185C604B0
		private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185067B30-0x0000000185067CF0
		private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185067CF0-0x0000000185067EC0
		private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066710-0x00000001850668B0
		private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5FE70-0x0000000185C60000
		private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4C520-0x0000000185C4C6C0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C4FF60-0x0000000185C50100
		private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185071B70-0x0000000185071D60
		private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x00000001851137C0-0x0000000185113950
		private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113950-0x0000000185113AE0
		private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185071970-0x0000000185071B70
		private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185071780-0x0000000185071970
		private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000185C4FDC0-0x0000000185C4FF60
		private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C33390-0x0000000185C33540
		private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185067EC0-0x0000000185068070
		private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185068070-0x0000000185068220
		private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2EE40-0x0000000185C2EFF0
		private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26AC0-0x0000000185C26C80
		private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26900-0x0000000185C26AC0
		private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2EFF0-0x0000000185C2F1A0
		private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60190-0x0000000185C60320
		private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C60000-0x0000000185C60190
		private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5FCE0-0x0000000185C5FE70
		private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5FB50-0x0000000185C5FCE0
		private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5F9C0-0x0000000185C5FB50
		private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5F830-0x0000000185C5F9C0
		private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185068220-0x00000001850683E0
		private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) => default; // 0x00000001850683E0-0x00000001850685B0
		private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x00000001850668B0-0x0000000185066A50
		private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C5F6A0-0x0000000185C5F830
		private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185C4C380-0x0000000185C4C520
		private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185C4FC20-0x0000000185C4FDC0
		private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185071590-0x0000000185071780
		private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113AE0-0x0000000185113C70
		private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113C70-0x0000000185113E00
		private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185071390-0x0000000185071590
		private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001850711A0-0x0000000185071390
		private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x00000001850636A0-0x0000000185063840
		private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185063840-0x00000001850639F0
		private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001850685B0-0x0000000185068760
		private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185068760-0x0000000185068910
		private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C2EC90-0x0000000185C2EE40
		private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26740-0x0000000185C26900
		private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185C26580-0x0000000185C26740
		private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001850639F0-0x0000000185063BA0
		private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185063BA0-0x0000000185063D30
		private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185063D30-0x0000000185063EC0
		private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185063EC0-0x0000000185064050
		private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185064050-0x00000001850641E0
		private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001850641E0-0x0000000185064370
		private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185064370-0x0000000185064500
		private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185068910-0x0000000185068AD0
		private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185068AD0-0x0000000185068CA0
		private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066A50-0x0000000185066BF0
		private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185064500-0x0000000185064690
		private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185064690-0x0000000185064830
		private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185064830-0x00000001850649D0
		private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000185070FB0-0x00000001850711A0
		private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113E00-0x0000000185113F90
		private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185113F90-0x0000000185114120
		private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185070DB0-0x0000000185070FB0
		private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000185070BC0-0x0000000185070DB0
		private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x00000001850649D0-0x0000000185064B70
		private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185064B70-0x0000000185064D20
		private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185068CA0-0x0000000185068E50
		private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185068E50-0x0000000185069000
		private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185064D20-0x0000000185064ED0
		private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185064ED0-0x0000000185065090
		private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185065090-0x0000000185065250
		private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185065250-0x0000000185065400
		private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185065400-0x0000000185065590
		private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185065890-0x0000000185065A20
		private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185065A20-0x0000000185065BB0
		private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001851141A0-0x0000000185114330
		private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185114330-0x00000001851144C0
		private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001851144C0-0x0000000185114650
		private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185069000-0x00000001850691C0
		private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) => default; // 0x00000001850691C0-0x0000000185069390
		private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000185066BF0-0x0000000185066D90
		private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185114650-0x00000001851147E0
		private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185066D90-0x0000000185066F30
		private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000185066F30-0x00000001850670D0
		private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001850709D0-0x0000000185070BC0
		private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x00000001851147E0-0x0000000185114970
		private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000185114970-0x0000000185114B00
		private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001850707D0-0x00000001850709D0
		private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001850705E0-0x00000001850707D0
		private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x00000001850670D0-0x0000000185067270
		private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000185067270-0x0000000185067420
		private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069390-0x0000000185069540
		private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069540-0x0000000185069750
		private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185067420-0x00000001850675D0
		private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001850675D0-0x00000001850677B0
		private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069790-0x0000000185069950
		private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069950-0x0000000185069B00
		private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069B00-0x0000000185069C90
		private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069C90-0x0000000185069E20
		private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069E20-0x0000000185069FB0
		private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000185069FB0-0x000000018506A140
		private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506A140-0x000000018506A2D0
		private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506A2D0-0x000000018506A460
		private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018506A460-0x000000018506A620
		private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018506A620-0x000000018506A7F0
		private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x000000018506A7F0-0x000000018506A990
		private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506A990-0x000000018506AB20
		private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018506AB20-0x000000018506ACC0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x000000018506ACC0-0x000000018506AE60
		private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001850703B0-0x00000001850705E0
		private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018506AE60-0x000000018506AFF0
		private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018506AFF0-0x000000018506B180
		private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001850701B0-0x00000001850703B0
		private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018506FFC0-0x00000001850701B0
		private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x000000018506B180-0x000000018506B320
		private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018506FE10-0x000000018506FFC0
		private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506B320-0x000000018506B4D0
		private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506FC60-0x000000018506FE10
		private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506B6D0-0x000000018506B880
		private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506B880-0x000000018506BA40
		private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506BA40-0x000000018506BC00
		private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506BC00-0x000000018506BDB0
		private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506FAD0-0x000000018506FC60
		private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506F940-0x000000018506FAD0
		private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506F7B0-0x000000018506F940
		private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506F620-0x000000018506F7B0
		private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506F490-0x000000018506F620
		private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018506F300-0x000000018506F490
	}

	public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message> // TypeDefIndex: 45160
	{
		// Fields
		private Flags m_Flags; // 0x10
		private InputManager m_LocalManager; // 0x18
		private Subscriber[] m_Subscribers; // 0x20
		private RemoteSender[] m_Senders; // 0x28
	
		// Properties
		public bool sending { get => default; private set {} }
		internal InputManager manager { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public enum MessageType // TypeDefIndex: 45140
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
	
		public struct Message // TypeDefIndex: 45141
		{
			// Fields
			public int participantId; // 0x00
			public MessageType type; // 0x04
			public byte[] data; // 0x08
		}
	
		private enum Flags // TypeDefIndex: 45142
		{
			Sending = 1,
			StartSendingOnConnect = 2
		}
	
		[Serializable]
		internal struct RemoteSender // TypeDefIndex: 45143
		{
			// Fields
			public int senderId; // 0x00
			public InternedString[] layouts; // 0x08
			public RemoteInputDevice[] devices; // 0x10
		}
	
		[Serializable]
		internal struct RemoteInputDevice // TypeDefIndex: 45144
		{
			// Fields
			public int remoteId; // 0x00
			public int localId; // 0x04
			public InputDeviceDescription description; // 0x08
		}
	
		internal class Subscriber : IDisposable // TypeDefIndex: 45145
		{
			// Fields
			public InputRemoting owner; // 0x10
			public IObserver<Message> observer; // 0x18
	
			// Constructors
			public Subscriber() {} // 0x000000018BD00EAC-0x000000018BD00EC8
	
			// Methods
			public void Dispose() {} // 0x0000000184BBC850-0x0000000184BBC860
		}
	
		private static class ConnectMsg // TypeDefIndex: 45146
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x000000018BD00E28-0x000000018BD00EAC
		}
	
		private static class StartSendingMsg // TypeDefIndex: 45147
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x000000018BD00948-0x000000018BD00AAC
		}
	
		private static class StopSendingMsg // TypeDefIndex: 45148
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x000000018BD00AAC-0x000000018BD00C04
		}
	
		private static class DisconnectMsg // TypeDefIndex: 45149
		{
			// Methods
			public static void Process(InputRemoting receiver, Message msg) {} // 0x000000018BD00CF0-0x000000018BD00DF8
		}
	
		private static class NewLayoutMsg // TypeDefIndex: 45151
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 45150
			{
				// Fields
				public string name; // 0x00
				public string layoutJson; // 0x08
				public bool isOverride; // 0x10
			}
	
			// Methods
			public static Message? Create(InputRemoting sender, string layoutName) => default; // 0x0000000185492010-0x0000000185492020
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private static class NewDeviceMsg // TypeDefIndex: 45154
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 45152
			{
				// Fields
				public string name; // 0x00
				public string layout; // 0x08
				public int deviceId; // 0x10
				public string[] usages; // 0x18
				public InputDeviceDescription description; // 0x20
			}
	
			[Serializable]
			private sealed class __c // TypeDefIndex: 45153
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c() {} // 0x000000018BD00C04-0x000000018BD00CF0
				public __c() {} // 0x000000018BD006DC-0x000000018BD006FC
	
				// Methods
				internal string _Create_b__1_0(InternedString x) => default; // 0x000000018BD003EC-0x000000018BD00550
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD00810-0x000000018BD008BC
			public static void Process(InputRemoting receiver, Message msg) {} // 0x000000018BD002A4-0x000000018BD003EC
		}
	
		private static class NewEventsMsg // TypeDefIndex: 45155
		{
			// Methods
			public static Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset) => default; // 0x000000018BD00604-0x000000018BD0068C
			public static Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD0068C-0x000000018BD006DC
			public static unsafe Message Create(InputEvent* events, int eventCount) => default; // 0x000000018BD00550-0x000000018BD00604
			public static void Process(InputRemoting receiver, Message msg) {} // 0x000000018BD006FC-0x000000018BD00810
		}
	
		private static class ChangeUsageMsg // TypeDefIndex: 45158
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 45156
			{
				// Fields
				public int deviceId; // 0x00
				public string[] usages; // 0x08
			}
	
			[Serializable]
			private sealed class __c // TypeDefIndex: 45157
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<InternedString, string> __9__1_0; // 0x08
	
				// Constructors
				static __c() {} // 0x000000018BD008BC-0x000000018BD00948
				public __c() {} // 0x000000018BD000E8-0x000000018BD001C0
	
				// Methods
				internal string _Create_b__1_0(InternedString x) => default; // 0x000000018BCFFFFC-0x000000018BD0007C
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD0007C-0x000000018BD000E8
			public static void Process(InputRemoting receiver, Message msg) {} // 0x000000018BD00DF8-0x000000018BD00E28
		}
	
		private static class RemoveDeviceMsg // TypeDefIndex: 45159
		{
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000181377E40-0x0000000181377E50
			public static void Process(InputRemoting receiver, Message msg) {} // 0x000000018BD001C0-0x000000018BD002A4
		}
	
		// Constructors
		public InputRemoting() {} // Dummy constructor
		internal InputRemoting(InputManager manager, bool startSendingOnConnect = false /* Metadata: 0x0205BD3B */) {} // 0x000000018BD0346C-0x000000018BD034B8
	
		// Methods
		public void StartSending() {} // 0x0000000185492010-0x0000000185492020
		public void StopSending() {} // 0x000000018BCFC7FC-0x000000018BCFC830
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) {} // 0x000000018BD032AC-0x000000018BD032C8
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) {} // 0x000000018BD03404-0x000000018BD03420
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() {} // 0x000000018BCFC830-0x000000018BCFC8B0
		public IDisposable Subscribe(IObserver<Message> observer) => default; // 0x000000018BD01E04-0x000000018BD020DC
		private void SendInitialMessages() {} // 0x000000018BD020DC-0x000000018BD021B8
		private void SendAllGeneratedLayouts() {} // 0x000000018BD0127C-0x000000018BD01500
		private void SendLayout(string layoutName) {} // 0x000000018BD01500-0x000000018BD01AB0
		private void SendAllDevices() {} // 0x000000018BD04628-0x000000018BD0468C
		private void SendDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000185492010-0x0000000185492020
		private void SendEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCE81A4-0x000000018BCE81B8
		private void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018BD01AB0-0x000000018BD01B24
		private void SendLayoutChange(string layout, InputControlLayoutChange change) {} // 0x000000018BD01B24-0x000000018BD01C2C
		private void Send(Message msg) {} // 0x000000018BD01C2C-0x000000018BD01D14
		private int FindOrCreateSenderRecord(int senderId) => default; // 0x000000018BD01D14-0x000000018BD01E04
		private static InternedString BuildLayoutNamespace(int senderId) => default; // 0x000000018BCFC284-0x000000018BCFC464
		private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) => default; // 0x000000018BCFC464-0x000000018BCFC7FC
		private UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) => default; // 0x000000018BD0468C-0x000000018BD04900
		public void RemoveRemoteDevices(int participantId) {} // 0x000000018BCE81A4-0x000000018BCE81B8
		private static byte[] SerializeData<TData>(TData data) => default; // 0x000000018BD03034-0x000000018BD030B0
		private static TData DeserializeData<TData>(byte[] data) => default; // 0x000000018BD030B0-0x000000018BD03154
	}

	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 45162
	{
		// Fields
		public static readonly Guid kNewDeviceMsg; // 0x00
		public static readonly Guid kNewLayoutMsg; // 0x10
		public static readonly Guid kNewEventsMsg; // 0x20
		public static readonly Guid kRemoveDeviceMsg; // 0x30
		public static readonly Guid kChangeUsagesMsg; // 0x40
		public static readonly Guid kStartSendingMsg; // 0x50
		public static readonly Guid kStopSendingMsg; // 0x60
		private IEditorPlayerConnection m_Connection; // 0x18
		[NonSerialized]
		private Subscriber[] m_Subscribers; // 0x20
		private int[] m_ConnectedIds; // 0x28
	
		// Nested types
		private class Subscriber : IDisposable // TypeDefIndex: 45161
		{
			// Fields
			public RemoteInputPlayerConnection owner; // 0x10
			public IObserver<InputRemoting.Message> observer; // 0x18
	
			// Constructors
			public Subscriber() {} // 0x000000018BD02BB0-0x000000018BD02D04
	
			// Methods
			public void Dispose() {} // 0x000000018BD02430-0x000000018BD028E8
		}
	
		// Constructors
		public RemoteInputPlayerConnection() {} // 0x000000018BD03420-0x000000018BD0346C
		static RemoteInputPlayerConnection() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Bind(IEditorPlayerConnection connection, bool isConnected) {} // 0x000000018BD028F8-0x000000018BD029A0
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer) => default; // 0x000000018BD029A0-0x000000018BD02A4C
		private void OnConnected(int id) {} // 0x000000018BD02A4C-0x000000018BD02A5C
		private void OnDisconnected(int id) {} // 0x000000018BD02A6C-0x000000018BD02A7C
		private void OnNewDevice(MessageEventArgs args) {} // 0x000000018BD02A5C-0x000000018BD02A6C
		private void OnNewLayout(MessageEventArgs args) {} // 0x000000018BD02A7C-0x000000018BD02A8C
		private void OnNewEvents(MessageEventArgs args) {} // 0x000000018BD028E8-0x000000018BD028F8
		private void OnRemoveDevice(MessageEventArgs args) {} // 0x000000018BD02A8C-0x000000018BD02A9C
		private void OnChangeUsages(MessageEventArgs args) {} // 0x000000018BD02A9C-0x000000018BD02AAC
		private void OnStartSending(MessageEventArgs args) {} // 0x000000018BD02AAC-0x000000018BD02BB0
		private void OnStopSending(MessageEventArgs args) {} // 0x000000018BD02D04-0x000000018BD02E5C
		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args) {} // 0x0000000185492010-0x0000000185492020
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg) {} // 0x0000000185492010-0x0000000185492020
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() {} // 0x000000018BD02E5C-0x000000018BD03034
	}

	public class Sensor : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 45163
	{
		// Properties
		public float samplingFrequency { get => default; set {} } // 0x000000018BD03154-0x000000018BD03234 0x000000018BD03234-0x000000018BD032AC
	
		// Constructors
		public Sensor() {} // 0x00000001864734FC-0x0000000186473504
	}

	public class Accelerometer : Sensor // TypeDefIndex: 45164
	{
		// Fields
		private Vector3Control _acceleration_k__BackingField; // 0x190
		private static Accelerometer _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static Accelerometer current { get; private set; } // 0x000000018BCFBF84-0x000000018BCFBFBC 0x000000018BCFBFBC-0x000000018BCFC00C
	
		// Constructors
		public Accelerometer() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFBF30-0x000000018BCFBF38
		protected override void OnRemoved() {} // 0x000000018BCFBF38-0x000000018BCFBF84
		protected override void FinishSetup() {} // 0x000000018BCFBED0-0x000000018BCFBF30
	}

	public class Gyroscope : Sensor // TypeDefIndex: 45165
	{
		// Fields
		private Vector3Control _angularVelocity_k__BackingField; // 0x190
		private static Gyroscope _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control angularVelocity { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static Gyroscope current { get; private set; } // 0x000000018BCFCAA0-0x000000018BCFCAD8 0x000000018BCFCAD8-0x000000018BCFCB28
	
		// Constructors
		public Gyroscope() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFCA4C-0x000000018BCFCA54
		protected override void OnRemoved() {} // 0x000000018BCFCA54-0x000000018BCFCAA0
		protected override void FinishSetup() {} // 0x000000018BCFC9EC-0x000000018BCFCA4C
	}

	public class GravitySensor : Sensor // TypeDefIndex: 45166
	{
		// Fields
		private Vector3Control _gravity_k__BackingField; // 0x190
		private static GravitySensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control gravity { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static GravitySensor current { get; private set; } // 0x000000018BCFC964-0x000000018BCFC99C 0x000000018BCFC99C-0x000000018BCFC9EC
	
		// Constructors
		public GravitySensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCFC8B0-0x000000018BCFC910
		public override void MakeCurrent() {} // 0x000000018BCFC910-0x000000018BCFC918
		protected override void OnRemoved() {} // 0x000000018BCFC918-0x000000018BCFC964
	}

	public class AttitudeSensor : Sensor // TypeDefIndex: 45167
	{
		// Fields
		private QuaternionControl _attitude_k__BackingField; // 0x190
		private static AttitudeSensor _current_k__BackingField; // 0x00
	
		// Properties
		public QuaternionControl attitude { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static AttitudeSensor current { get; private set; } // 0x000000018BCFC1FC-0x000000018BCFC234 0x000000018BCFC234-0x000000018BCFC284
	
		// Constructors
		public AttitudeSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFC1A8-0x000000018BCFC1B0
		protected override void OnRemoved() {} // 0x000000018BCFC1B0-0x000000018BCFC1FC
		protected override void FinishSetup() {} // 0x000000018BCFC148-0x000000018BCFC1A8
	}

	public class LinearAccelerationSensor : Sensor // TypeDefIndex: 45168
	{
		// Fields
		private Vector3Control _acceleration_k__BackingField; // 0x190
		private static LinearAccelerationSensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control acceleration { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static LinearAccelerationSensor current { get; private set; } // 0x000000018BD010B8-0x000000018BD010F0 0x000000018BD010F0-0x000000018BD01140
	
		// Constructors
		public LinearAccelerationSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD01064-0x000000018BD0106C
		protected override void OnRemoved() {} // 0x000000018BD0106C-0x000000018BD010B8
		protected override void FinishSetup() {} // 0x000000018BD01004-0x000000018BD01064
	}

	public class MagneticFieldSensor : Sensor // TypeDefIndex: 45169
	{
		// Fields
		private Vector3Control _magneticField_k__BackingField; // 0x190
		private static MagneticFieldSensor _current_k__BackingField; // 0x00
	
		// Properties
		public Vector3Control magneticField { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static MagneticFieldSensor current { get; private set; } // 0x000000018BD011F4-0x000000018BD0122C 0x000000018BD0122C-0x000000018BD0127C
	
		// Constructors
		public MagneticFieldSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD011A0-0x000000018BD011A8
		protected override void OnRemoved() {} // 0x000000018BD011A8-0x000000018BD011F4
		protected override void FinishSetup() {} // 0x000000018BD01140-0x000000018BD011A0
	}

	public class LightSensor : Sensor // TypeDefIndex: 45170
	{
		// Fields
		private AxisControl _lightLevel_k__BackingField; // 0x190
		private static LightSensor _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl lightLevel { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static LightSensor current { get; private set; } // 0x000000018BD00F7C-0x000000018BD00FB4 0x000000018BD00FB4-0x000000018BD01004
	
		// Constructors
		public LightSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD00F28-0x000000018BD00F30
		protected override void OnRemoved() {} // 0x000000018BD00F30-0x000000018BD00F7C
		protected override void FinishSetup() {} // 0x000000018BD00EC8-0x000000018BD00F28
	}

	public class PressureSensor : Sensor // TypeDefIndex: 45171
	{
		// Fields
		private AxisControl _atmosphericPressure_k__BackingField; // 0x190
		private static PressureSensor _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl atmosphericPressure { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static PressureSensor current { get; private set; } // 0x000000018BD0226C-0x000000018BD022A4 0x000000018BD022A4-0x000000018BD022F4
	
		// Constructors
		public PressureSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD02218-0x000000018BD02220
		protected override void OnRemoved() {} // 0x000000018BD02220-0x000000018BD0226C
		protected override void FinishSetup() {} // 0x000000018BD021B8-0x000000018BD02218
	}

	public class ProximitySensor : Sensor // TypeDefIndex: 45172
	{
		// Fields
		private AxisControl _distance_k__BackingField; // 0x190
		private static ProximitySensor _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl distance { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static ProximitySensor current { get; private set; } // 0x000000018BD023A8-0x000000018BD023E0 0x000000018BD023E0-0x000000018BD02430
	
		// Constructors
		public ProximitySensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD02354-0x000000018BD0235C
		protected override void OnRemoved() {} // 0x000000018BD0235C-0x000000018BD023A8
		protected override void FinishSetup() {} // 0x000000018BD022F4-0x000000018BD02354
	}

	public class HumiditySensor : Sensor // TypeDefIndex: 45173
	{
		// Fields
		private AxisControl _relativeHumidity_k__BackingField; // 0x190
		private static HumiditySensor _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl relativeHumidity { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static HumiditySensor current { get; private set; } // 0x000000018BCFCD18-0x000000018BCFCD50 0x000000018BCFCD50-0x000000018BCFCDA0
	
		// Constructors
		public HumiditySensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFCCC4-0x000000018BCFCCCC
		protected override void OnRemoved() {} // 0x000000018BCFCCCC-0x000000018BCFCD18
		protected override void FinishSetup() {} // 0x000000018BCFCC64-0x000000018BCFCCC4
	}

	public class AmbientTemperatureSensor : Sensor // TypeDefIndex: 45174
	{
		// Fields
		private AxisControl _ambientTemperature_k__BackingField; // 0x190
		private static AmbientTemperatureSensor _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl ambientTemperature { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static AmbientTemperatureSensor current { get; private set; } // 0x000000018BCFC0C0-0x000000018BCFC0F8 0x000000018BCFC0F8-0x000000018BCFC148
	
		// Constructors
		public AmbientTemperatureSensor() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFC06C-0x000000018BCFC074
		protected override void OnRemoved() {} // 0x000000018BCFC074-0x000000018BCFC0C0
		protected override void FinishSetup() {} // 0x000000018BCFC00C-0x000000018BCFC06C
	}

	public class StepCounter : Sensor // TypeDefIndex: 45175
	{
		// Fields
		private IntegerControl _stepCounter_k__BackingField; // 0x190
		private static StepCounter _current_k__BackingField; // 0x00
	
		// Properties
		public IntegerControl stepCounter { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static StepCounter current { get; private set; } // 0x000000018BD0337C-0x000000018BD033B4 0x000000018BD033B4-0x000000018BD03404
	
		// Constructors
		public StepCounter() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD03328-0x000000018BD03330
		protected override void OnRemoved() {} // 0x000000018BD03330-0x000000018BD0337C
		protected override void FinishSetup() {} // 0x000000018BD032C8-0x000000018BD03328
	}

	public class HingeAngle : Sensor // TypeDefIndex: 45176
	{
		// Fields
		private AxisControl _angle_k__BackingField; // 0x190
		private static HingeAngle _current_k__BackingField; // 0x00
	
		// Properties
		public AxisControl angle { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public static HingeAngle current { get; private set; } // 0x000000018BCFCBDC-0x000000018BCFCC14 0x000000018BCFCC14-0x000000018BCFCC64
	
		// Constructors
		public HingeAngle() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BCFCB88-0x000000018BCFCB90
		protected override void OnRemoved() {} // 0x000000018BCFCB90-0x000000018BCFCBDC
		protected override void FinishSetup() {} // 0x000000018BCFCB28-0x000000018BCFCB88
	}

	public enum TouchPhase // TypeDefIndex: 45177
	{
		None = 0,
		Began = 1,
		Moved = 2,
		Ended = 3,
		Canceled = 4,
		Stationary = 5
	}

	public class Touchscreen : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset // TypeDefIndex: 45178
	{
		// Fields
		private TouchControl _primaryTouch_k__BackingField; // 0x1C0
		private ReadOnlyArray<TouchControl> _touches_k__BackingField; // 0x1C8
		private static readonly ProfilerMarker k_TouchscreenUpdateMarker; // 0x00
		private static readonly ProfilerMarker k_TouchAllocateMarker; // 0x08
		private static Touchscreen _current_k__BackingField; // 0x10
		internal static float s_TapTime; // 0x18
		internal static float s_TapDelayTime; // 0x1C
		internal static float s_TapRadiusSquared; // 0x20
	
		// Properties
		public TouchControl primaryTouch { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ReadOnlyArray<TouchControl> touches { get; protected set; } // 0x0000000185FD7EF0-0x0000000185FD7F00 0x000000018BD044EC-0x000000018BD04504
		protected TouchControl[] touchControlArray { get => default; set {} } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000185F62C60-0x0000000185F62CE0
		public static new Touchscreen current { get; internal set; } // 0x000000018BD0443C-0x000000018BD0448C 0x000000018BD0448C-0x000000018BD044EC
	
		// Constructors
		public Touchscreen() {} // 0x00000001864734FC-0x0000000186473504
		static Touchscreen() {} // 0x0000000185F0E0C0-0x0000000185F0E160
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018502F540-0x000000018502F590
		protected override void OnRemoved() {} // 0x000000018BD03934-0x000000018BD03994
		protected override void FinishSetup() {} // 0x000000018BD034B8-0x000000018BD03850
		protected new void OnNextUpdate() {} // 0x0000000184214840-0x0000000184214AA0
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BD03994-0x000000018BD040F4
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018646F404-0x000000018646F40C
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x000000018BD04434-0x000000018BD0443C
		new bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x000000018BD041E8-0x000000018BD04434
		void ICustomDeviceReset.Reset() {} // 0x00000001849520E0-0x00000001849526E0
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x000000018BD03850-0x000000018BD03934
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x000000018BD0418C-0x000000018BD041E8
		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) {} // 0x000000018BD040F4-0x000000018BD0418C
	}

	public class TrackedDevice : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 45179
	{
		// Fields
		private IntegerControl _trackingState_k__BackingField; // 0x190
		private ButtonControl _isTracked_k__BackingField; // 0x198
		private Vector3Control _devicePosition_k__BackingField; // 0x1A0
		private QuaternionControl _deviceRotation_k__BackingField; // 0x1A8
	
		// Properties
		public IntegerControl trackingState { get; protected set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public ButtonControl isTracked { get; protected set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public Vector3Control devicePosition { get; protected set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public QuaternionControl deviceRotation { get; protected set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
	
		// Constructors
		public TrackedDevice() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD04504-0x000000018BD04628
	}

	public static class InputExtensions // TypeDefIndex: 45180
	{
		// Methods
		public static bool IsInProgress(InputActionPhase phase) => default; // 0x0000000184586380-0x0000000184586390
		public static bool IsEndedOrCanceled(UnityEngine.InputSystem.TouchPhase phase) => default; // 0x000000018BCFCDA0-0x000000018BCFCDB0
		public static bool IsActive(UnityEngine.InputSystem.TouchPhase phase) => default; // 0x00000001849526E0-0x0000000184952700
		public static bool IsModifierKey(UnityEngine.InputSystem.Key key) => default; // 0x000000018BCFCDB0-0x000000018BCFCDBC
		public static bool IsTextInputKey(UnityEngine.InputSystem.Key key) => default; // 0x000000018BCFCDBC-0x000000018BCFCDD8
	}

	internal static class InputFeatureNames // TypeDefIndex: 45181
	{
		// Fields
		public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE"; // Metadata: 0x0205BD4E
		public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT"; // Metadata: 0x0205BD6E
		public const string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS"; // Metadata: 0x0205BD8B
		public const string kUseReadValueCaching = "USE_READ_VALUE_CACHING"; // Metadata: 0x0205BDA2
		public const string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS"; // Metadata: 0x0205BDB9
	}

	internal class InputManager // TypeDefIndex: 45190
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
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x0000000184BFA1D0-0x0000000184BFA220 
		public TypeTable processors { get => default; } // 0x0000000184111F70-0x0000000184111FC0 
		public TypeTable interactions { get => default; } // 0x000000018BCFFC08-0x000000018BCFFC54 
		public TypeTable composites { get => default; } // 0x0000000184111F20-0x0000000184111F70 
		public InputMetrics metrics { get => default; } // 0x000000018BCFFE1C-0x000000018BCFFE68 
		public InputSettings settings { get => default; set {} } // 0x0000000185FD7E80-0x0000000185FD7E90 0x00000001840A27C0-0x00000001840A27D0
		public InputUpdateType updateMask { get => default; set {} } // 0x000000018457CB40-0x000000018457CB80 0x000000018457C820-0x000000018457C850
		public InputUpdateType defaultUpdateType { get => default; } // 0x0000000184004F40-0x0000000184005890 
		public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get => default; set {} } // 0x0000000184D53D40-0x0000000184D53FA0 0x000000018BCFE2EC-0x000000018BCFE4FC
		public float pollingFrequency { get => default; set {} } // 0x0000000184005B80-0x00000001840060D0 
		public bool isProcessingEvents { get => default; } // 0x000000018BCFE768-0x000000018BCFE8CC 
		private bool gameIsPlaying { get => default; } // 0x000000018BCFE014-0x000000018BCFE0D4 
		private bool gameHasFocus { get => default; } // 0x000000018BCFD0AC-0x000000018BCFD1A0 
		private bool gameShouldGetInputRegardlessOfFocus { get => default; } // 0x000000018BCFD1A0-0x000000018BCFD300 
		internal bool optimizedControlsFeatureEnabled { get => default; set {} } // 0x000000018BCFDEE4-0x000000018BCFE014 0x000000018508FD80-0x000000018508FDE0
		internal bool readValueCachingFeatureEnabled { get => default; set {} } // 0x000000018BCFD428-0x000000018BCFD590 0x0000000184582F80-0x0000000184583020
		internal bool paranoidReadValueCachingChecksEnabled { get => default; set {} } // 0x0000000185FD7E70-0x0000000185FD7E80 0x00000001853705C0-0x00000001853706C0
	
		// Events
		public event Action<UnityEngine.InputSystem.InputDevice, InputDeviceChange> onDeviceChange;
		public event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onDeviceStateChange;
		public event InputDeviceCommandDelegate onDeviceCommand;
		public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice;
		public event Action<string, InputControlLayoutChange> onLayoutChange;
		public event Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEvent;
		public event Action onBeforeUpdate;
		public event Action onAfterUpdate;
		public event Action onSettingsChange;
	
		// Nested types
		internal enum DeviceDisableScope // TypeDefIndex: 45182
		{
			Everywhere = 0,
			InFrontendOnly = 1,
			TemporaryWhilePlayerIsInBackground = 2
		}
	
		[Serializable]
		internal struct AvailableDevice // TypeDefIndex: 45183
		{
			// Fields
			public InputDeviceDescription description; // 0x00
			public int deviceId; // 0x38
			public bool isNative; // 0x3C
			public bool isRemoved; // 0x3D
		}
	
		private struct StateChangeMonitorTimeout // TypeDefIndex: 45184
		{
			// Fields
			public InputControl control; // 0x00
			public double time; // 0x08
			public IInputStateChangeMonitor monitor; // 0x10
			public long monitorIndex; // 0x18
			public int timerIndex; // 0x20
		}
	
		internal struct StateChangeMonitorListener // TypeDefIndex: 45185
		{
			// Fields
			public InputControl control; // 0x00
			public IInputStateChangeMonitor monitor; // 0x08
			public long monitorIndex; // 0x10
			public uint groupIndex; // 0x18
		}
	
		internal struct StateChangeMonitorsForDevice // TypeDefIndex: 45186
		{
			// Fields
			public MemoryHelpers.BitRegion[] memoryRegions; // 0x00
			public StateChangeMonitorListener[] listeners; // 0x08
			public DynamicBitfield signalled; // 0x10
			public bool needToUpdateOrderingOfMonitors; // 0x30
			public bool needToCompactArrays; // 0x31
	
			// Properties
			public int count { get => default; } // 0x000000018539B5E0-0x000000018539B640 
	
			// Methods
			public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) {} // 0x00000001813F1630-0x00000001813F1640
			public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval) {} // 0x0000000185FB0530-0x0000000185FB0540
			public void Clear() {} // 0x00000001813AC280-0x00000001813AC290
			public void CompactArrays() {} // 0x000000018BCFFA84-0x000000018BCFFC08
			private void RemoveAt(int i) {} // 0x0000000185FB84A0-0x0000000185FB84B0
			public void SortMonitorsByIndex() {} // 0x000000018BCFFF08-0x000000018BCFFFFC
		}
	
		[Serializable]
		private sealed class __c__76<TDevice> // TypeDefIndex: 45187
			where TDevice : UnityEngine.InputSystem.InputDevice, new()
		{
			// Fields
			public static readonly __c__76<TDevice> __9;
			public static Func<UnityEngine.InputSystem.InputDevice> __9__76_0;
	
			// Constructors
			static __c__76() {} // 0x0000000185FB2CD0-0x0000000185FB2CE0
			public __c__76() {}
	
			// Methods
			internal UnityEngine.InputSystem.InputDevice _RegisterPrecompiledLayout_b__76_0() => default; // 0x0000000184112740-0x0000000184112760
		}
	
		private sealed class _ListControlLayouts_d__91 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 45188
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
			string IEnumerator<System.String>.Current { get => default; } // 0x000000018BCFFCA0-0x000000018BCFFCEC 
			object IEnumerator.Current { get => default; } // 0x000000018BCFFD84-0x000000018BCFFDD0 
	
			// Constructors
			public _ListControlLayouts_d__91() {} // Dummy constructor
			public _ListControlLayouts_d__91(int __1__state) {} // 0x0000000185FB25E0-0x0000000185FB25F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018539A850-0x000000018539A860
			private bool MoveNext() => default; // 0x0000000185FB2D80-0x0000000185FB2D90
			private void __m__Finally1() {} // 0x000000018BCFFE68-0x000000018BCFFF08
			private void __m__Finally2() {} // 0x0000000184111610-0x0000000184111660
			private void __m__Finally3() {} // 0x000000018BCFFC54-0x000000018BCFFCA0
			private void __m__Finally4() {} // 0x000000018BCFF9A0-0x000000018BCFF9EC
			private void __m__Finally5() {} // 0x000000018BCFFCEC-0x000000018BCFFD38
			private void __m__Finally6() {} // 0x000000018BCFF954-0x000000018BCFF9A0
			void IEnumerator.Reset() {} // 0x000000018539A690-0x000000018539A6F0
			IEnumerator<string> IEnumerable<string>.GetEnumerator() => default; // 0x000000018BCFFA38-0x000000018BCFFA84
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCFFDD0-0x000000018BCFFE1C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45189
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<UnityEngine.InputSystem.InputDevice, string> __9__175_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BCFF9EC-0x000000018BCFFA38
			public __c() {} // 0x000000018BCFFD38-0x000000018BCFFD84
	
			// Methods
			internal string _MakeDeviceNameUnique_b__175_0(UnityEngine.InputSystem.InputDevice x) => default; // 0x0000000184111FC0-0x0000000184112020
		}
	
		// Constructors
		public InputManager() {} // 0x0000000185F72190-0x0000000185F721F0
		static InputManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void RegisterControlLayout(string name, System.Type type) {} // 0x0000000184113BF0-0x0000000184113E70
		public void RegisterControlLayout(string json, string name = null, bool isOverride = false /* Metadata: 0x0205BDDC */) {} // 0x00000001841120F0-0x00000001841124D0
		public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null) {} // 0x000000018BCFD300-0x000000018BCFD354
		private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false /* Metadata: 0x0205BDDD */, bool isOverride = false /* Metadata: 0x0205BDDE */) {} // 0x0000000184114880-0x0000000184114A30
		public void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new() {} // 0x000000018BCFCF3C-0x000000018BCFD0AC
		private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false /* Metadata: 0x0205BDDF */) {} // 0x000000018BCFE8CC-0x000000018BCFECE0
		private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) => default; // 0x000000018BCFD674-0x000000018BCFD6C4
		private bool IsControlUsingLayout(InputControl control, InternedString layout) => default; // 0x0000000184952E10-0x0000000184953540
		public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) {} // 0x000000018BCFF370-0x000000018BCFF488
		public void RegisterControlLayoutMatcher(System.Type type, InputDeviceMatcher matcher) {} // 0x000000018BCFD6C4-0x000000018BCFD774
		private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) {} // 0x000000018BCFF488-0x000000018BCFF4DC
		private void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, InternedString newLayout) {} // 0x000000018457E810-0x000000018457E950
		private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) {} // 0x000000018BCFD774-0x000000018BCFD8BC
		public void RemoveControlLayout(string name) {} // 0x0000000184953730-0x0000000184953900
		public InputControlLayout TryLoadControlLayout(System.Type type) => default; // 0x000000018BCFE0D4-0x000000018BCFE160
		public InputControlLayout TryLoadControlLayout(InternedString name) => default; // 0x00000001884CCBF0-0x00000001884CCBF8
		public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0 /* Metadata: 0x0205BDE0 */) => default;
		private InternedString FindOrRegisterDeviceLayoutForType(System.Type type) => default; // 0x000000018BCFF930-0x000000018BCFF954
		private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) => default; // 0x0000000185C578C0-0x0000000185C57930
		public IEnumerable<string> ListControlLayouts(string basedOn = null) => default; // 0x0000000184D54EF0-0x0000000184D54F50
		public int GetControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl => default; // 0x000000018BCFD590-0x000000018BCFD674
		public void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000184003840-0x0000000184004A10
		public void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x00000001843445C0-0x00000001843447D0
		public void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000184A8DC30-0x0000000184A8DE20
		private void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000184D54230-0x0000000184D545F0
		public UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name = null) => default; // 0x0000000184D53A20-0x0000000184D53CB0
		public UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, InternedString variants = default) => default; // 0x000000018BCFF754-0x000000018BCFF930
		private UnityEngine.InputSystem.InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = default, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (UnityEngine.InputSystem.InputDevice.DeviceFlags) 0 /* Metadata: 0x0205BDE1 */, InternedString variants = default) => default; // 0x0000000185FD7E90-0x0000000185FD7EA0
		public void AddDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000185FD7EC0-0x0000000185FD7ED0
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description) => default; // 0x0000000185FD7EB0-0x0000000185FD7EC0
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0 /* Metadata: 0x0205BDE2 */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (UnityEngine.InputSystem.InputDevice.DeviceFlags) 0 /* Metadata: 0x0205BDE3 */) => default; // 0x0000000185FD7EE0-0x0000000185FD7EF0
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0 /* Metadata: 0x0205BDE4 */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (UnityEngine.InputSystem.InputDevice.DeviceFlags) 0 /* Metadata: 0x0205BDE5 */) => default; // 0x0000000185FD7EA0-0x0000000185FD7EB0
		public void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices = false /* Metadata: 0x0205BDE6 */) {} // 0x0000000185FD7ED0-0x0000000185FD7EE0
		public void FlushDisconnectedDevices() {} // 0x0000000184112FF0-0x0000000184113220
		public void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x0205BDE7 */, bool? issueResetCommand = default) {} // 0x000000018BCFF088-0x000000018BCFF154
		public UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout) => default; // 0x00000001841124E0-0x0000000184112530
		public UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout) => default; // 0x0000000184112530-0x0000000184112740
		public UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType) => default; // 0x000000018BCFD8BC-0x000000018BCFDA50
		public UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id) => default; // 0x0000000184006D40-0x0000000184007070
		public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) => default; // 0x0000000184113F50-0x0000000184114640
		public void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, DeviceDisableScope scope = DeviceDisableScope.Everywhere /* Metadata: 0x0205BDE8 */) {} // 0x000000018BCFDD94-0x000000018BCFDEE4
		private unsafe void QueueEvent(InputEvent* eventPtr) {} // 0x00000001841146A0-0x0000000184114770
		public void QueueEvent(InputEventPtr ptr) {} // 0x0000000184112020-0x00000001841120D0
		public void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo {} // 0x0000000185492010-0x0000000185492020
		public void Update() {} // 0x0000000185492010-0x0000000185492020
		public void Update(InputUpdateType updateType) {} // 0x0000000184581B10-0x0000000184581DB0
		internal void Initialize(IInputRuntime runtime, InputSettings settings) {} // 0x000000018539A8E0-0x000000018539B5E0
		internal void Destroy() {}
		internal void InitializeData() {} // 0x000000018539A6F0-0x000000018539A790
		private void RegisterCustomTypes(System.Type[] types) {} // 0x0000000184953970-0x00000001849539B0
		private void RegisterCustomTypes() {} // 0x0000000184953560-0x0000000184953730
		internal void InstallRuntime(IInputRuntime runtime) {} // 0x000000018502DEC0-0x000000018502DEE0
		internal void InstallGlobals() {} // 0x000000018457E990-0x000000018457F780
		internal void UninstallGlobals() {} // 0x00000001850C5CF0-0x00000001850C5D80
		private void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000184580E20-0x0000000184581610
		private static void ResetControlPathsRecursive(InputControl control) {} // 0x0000000184581610-0x0000000184581830
		private void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device) {} // 0x00000001845823A0-0x00000001845824C0
		private void ReallocateStateBuffers() {} // 0x0000000184BFB7B0-0x0000000184BFB900
		private void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCFEF68-0x000000018BCFF088
		private void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCFEE00-0x000000018BCFEF68
		private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) {} // 0x000000018BCFD354-0x000000018BCFD428
		private JsonParser.JsonString MakeEscapedJsonString(string theString) => default; // 0x000000018BCFECE0-0x000000018BCFEE00
		private UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) => default; // 0x0000000184581DD0-0x0000000184581E30
		private void InstallBeforeUpdateHookIfNecessary() {} // 0x000000018BCFF2B8-0x000000018BCFF370
		private void RestoreDevicesAfterDomainReloadIfNecessary() {} // 0x0000000184BF9FB0-0x0000000184BFA080
		private void WarnAboutDevicesFailingToRecreateAfterDomainReload() {} // 0x0000000184581E30-0x0000000184582230
		private void OnBeforeUpdate(InputUpdateType updateType) {} // 0x0000000184582730-0x0000000184582AF0
		internal void ApplySettings() {} // 0x000000018457CA40-0x000000018457CAB0
		internal long ExecuteGlobalCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default; // 0x0000000185492010-0x0000000185492020
		internal void AddAvailableDevicesThatAreNowRecognized() {} // 0x0000000185A6EF70-0x0000000185A6F290
		private bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000185993F30-0x0000000185993FB0
		internal void OnFocusChanged(bool focus) {} // 0x0000000181C9AC80-0x0000000181C9AC90
		internal bool ShouldRunUpdate(InputUpdateType updateType) => default; // 0x0000000184BFB900-0x0000000184BFBAA0
		private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) {} // 0x000000018BD16590-0x000000018BD16684
		private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed) => default; // 0x000000018BD16458-0x000000018BD164A8
		private string MakeStringWithEventsProcessedByDevice() => default; // 0x000000018BD164A8-0x000000018BD16504
		private void ResetCurrentProcessedEventBytesForDevices() {} // 0x000000018BD16504-0x000000018BD16590
		private void CheckAllDevicesOptimizedControlsHaveValidState() {} // 0x0000000185A59E10-0x0000000185A59EE0
		private void InvokeAfterUpdateCallback(InputUpdateType updateType) {}
		internal void DontMakeCurrentlyUpdatingDeviceCurrent() {}
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) => default;
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = default) => default; // 0x0000000184775050-0x0000000184775070
		private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers) {} // 0x000000018BD18AA0-0x000000018BD18D50
		private bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType) => default; // 0x000000018BD17C40-0x000000018BD189A8
		public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) {} // 0x000000018BD18D50-0x000000018BD18D8C
		private void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD18D8C-0x000000018BD18DC8
		public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) {} // 0x000000018BD18DC8-0x000000018BD18E04
		public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) {} // 0x000000018BD18E04-0x000000018BD18E40
		public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) {} // 0x000000018BD18E40-0x000000018BD18E7C
		private void SortStateChangeMonitorsIfNecessary(int deviceIndex) {} // 0x000000018BD18E7C-0x000000018BD18EB8
		public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) {} // 0x0000000181377E40-0x0000000181377E50
		public void FireStateChangeNotifications() {} // 0x000000018BD18A54-0x000000018BD18AA0
		private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) => default; // 0x0000000181377E40-0x0000000181377E50
		internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) {} // 0x000000018BD189A8-0x000000018BD18A4C
		private void ProcessStateChangeMonitorTimeouts() {} // 0x000000018BD18A4C-0x000000018BD18A54
		private long _TryFindMatchingControlLayout_b__88_0(ref InputDeviceCommand commandRef) => default; // 0x0000000185A32B80-0x0000000185A32C10
	}

	public class InputSettings : ScriptableObject // TypeDefIndex: 45196
	{
		// Fields
		private string[] m_SupportedDevices; // 0x18
		private UpdateMode m_UpdateMode; // 0x20
		private ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0x24
		private int m_MaxEventBytesPerUpdate; // 0x28
		private int m_MaxQueuedEventsPerUpdate; // 0x2C
		private bool m_CompensateForScreenOrientation; // 0x30
		private BackgroundBehavior m_BackgroundBehavior; // 0x34
		private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; // 0x38
		private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; // 0x3C
		private float m_DefaultDeadzoneMin; // 0x40
		private float m_DefaultDeadzoneMax; // 0x44
		private float m_DefaultButtonPressPoint; // 0x48
		private float m_ButtonReleaseThreshold; // 0x4C
		private float m_DefaultTapTime; // 0x50
		private float m_DefaultSlowTapTime; // 0x54
		private float m_DefaultHoldTime; // 0x58
		private float m_TapRadius; // 0x5C
		private float m_MultiTapDelayTime; // 0x60
		private bool m_DisableRedundantEventsMerging; // 0x64
		private bool m_ShortcutKeysConsumeInputs; // 0x65
		[NonSerialized]
		internal HashSet<string> m_FeatureFlags; // 0x68
		internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; // Metadata: 0x0205BDEC
	
		// Properties
		public UpdateMode updateMode { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x000000018BD068A8-0x000000018BD068B8
		public ScrollDeltaBehavior scrollDeltaBehavior { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x000000018BD06738-0x000000018BD06748
		public bool compensateForScreenOrientation { get => default; set {} } // 0x00000001814294C0-0x00000001814294D0 0x000000018BD065F8-0x000000018BD06608
		public bool filterNoiseOnCurrent { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x0000000185492010-0x0000000185492020
		public float defaultDeadzoneMin { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x000000018BD0665C-0x000000018BD06678
		public float defaultDeadzoneMax { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x000000018BD06640-0x000000018BD0665C
		public float defaultButtonPressPoint { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x000000018BD06608-0x000000018BD06640
		public float buttonReleaseThreshold { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x000000018BD065DC-0x000000018BD065F8
		public float defaultTapTime { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x000000018BD066B0-0x000000018BD066CC
		public float defaultSlowTapTime { get => default; set {} } // 0x0000000183F80440-0x0000000183F80450 0x000000018BD06694-0x000000018BD066B0
		public float defaultHoldTime { get => default; set {} } // 0x0000000181DE2580-0x0000000181DE2590 0x000000018BD06678-0x000000018BD06694
		public float tapRadius { get => default; set {} } // 0x0000000185FB89D0-0x0000000185FB89E0 0x000000018BD0688C-0x000000018BD068A8
		public float multiTapDelayTime { get => default; set {} } // 0x0000000185FB2200-0x0000000185FB2210 0x000000018BD0671C-0x000000018BD06738
		public BackgroundBehavior backgroundBehavior { get => default; set {} } // 0x0000000185FB07C0-0x0000000185FB07D0 0x000000018BD065CC-0x000000018BD065DC
		public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x000000018BD066DC-0x000000018BD066EC
		public InputActionPropertyDrawerMode inputActionPropertyDrawerMode { get => default; set {} } // 0x0000000185FB0790-0x0000000185FB07A0 0x000000018BD066EC-0x000000018BD066FC
		public int maxEventBytesPerUpdate { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x000000018BD066FC-0x000000018BD0670C
		public int maxQueuedEventsPerUpdate { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x000000018BD0670C-0x000000018BD0671C
		public ReadOnlyArray<string> supportedDevices { get => default; set {} } // 0x0000000184114640-0x00000001841146A0 0x000000018BD06758-0x000000018BD0688C
		public bool disableRedundantEventsMerging { get => default; set {} } // 0x0000000185FBA670-0x0000000185FBA680 0x000000018BD066CC-0x000000018BD066DC
		public bool shortcutKeysConsumeInput { get => default; set {} } // 0x0000000185FBDF90-0x0000000185FBDFA0 0x000000018BD06748-0x000000018BD06758
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 45191
		{
			ProcessEventsInDynamicUpdate = 1,
			ProcessEventsInFixedUpdate = 2,
			ProcessEventsManually = 3
		}
	
		public enum ScrollDeltaBehavior // TypeDefIndex: 45192
		{
			UniformAcrossAllPlatforms = 0,
			KeepPlatformSpecificInputRange = 1
		}
	
		public enum BackgroundBehavior // TypeDefIndex: 45193
		{
			ResetAndDisableNonBackgroundDevices = 0,
			ResetAndDisableAllDevices = 1,
			IgnoreFocus = 2
		}
	
		public enum EditorInputBehaviorInPlayMode // TypeDefIndex: 45194
		{
			PointersAndKeyboardsRespectGameViewFocus = 0,
			AllDevicesRespectGameViewFocus = 1,
			AllDeviceInputAlwaysGoesToGameView = 2
		}
	
		public enum InputActionPropertyDrawerMode // TypeDefIndex: 45195
		{
			Compact = 0,
			MultilineEffective = 1,
			MultilineBoth = 2
		}
	
		// Constructors
		public InputSettings() {} // 0x0000000185F81180-0x0000000185F811E0
	
		// Methods
		public void SetInternalFeatureFlag(string featureName, bool enabled) {} // 0x000000018BD0646C-0x000000018BD065CC
		internal bool IsFeatureEnabled(string featureName) => default; // 0x000000018BD06358-0x000000018BD063C8
		internal void OnChange() {} // 0x000000018BD063C8-0x000000018BD0646C
		private static bool CompareFloats(float a, float b) => default; // 0x000000018BD06344-0x000000018BD06358
		private static bool CompareSets<T>(ReadOnlyArray<T> a, ReadOnlyArray<T> b) => default;
		private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) => default; // 0x000000018BD062EC-0x000000018BD06344
		internal static bool AreEqual(InputSettings a, InputSettings b) => default; // 0x000000018BD06060-0x000000018BD062EC
	}

	public class DefaultInputActions : IInputActionCollection2, IDisposable // TypeDefIndex: 45201
	{
		// Fields
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
		public InputActionAsset asset { get; } // 0x000000018BD1A88C-0x000000018BD1A8AC 
		public InputBinding? bindingMask { get => default; set {} } // 0x000000018BD1A920-0x000000018BD1A940 0x000000018BD18F20-0x000000018BD18F3C
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x000000018BD18EFC-0x000000018BD18F20 0x000000018BD18ED8-0x000000018BD18EFC
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x000000018BD1A960-0x000000018BD1A984 
		public IEnumerable<InputBinding> bindings { get => default; }
		public PlayerActions Player { get => default; }
		public UIActions UI { get => default; }
		public InputControlScheme KeyboardMouseScheme { get => default; }
		public InputControlScheme GamepadScheme { get => default; }
		public InputControlScheme TouchScheme { get => default; }
		public InputControlScheme JoystickScheme { get => default; }
		public InputControlScheme XRScheme { get => default; }
	
		// Nested types
		public struct PlayerActions // TypeDefIndex: 45197
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Move { get => default; } // 0x000000018BD05214-0x000000018BD055DC 
			public InputAction Look { get => default; } // 0x000000018BD050F8-0x000000018BD05148 
			public InputAction Fire { get => default; } // 0x000000018BD059B0-0x000000018BD05A00 
			public bool enabled { get => default; } // 0x000000018BD05A20-0x000000018BD05A54 
	
			// Constructors
			public PlayerActions(DefaultInputActions wrapper) : this() {
				m_Wrapper = default;
			} // 0x000000018346D130-0x000000018346D140
	
			// Methods
			public InputActionMap Get() => default; // 0x000000018BD05A94-0x000000018BD05AF4
			public void Enable() {} // 0x000000018BD05A54-0x000000018BD05A94
			public void Disable() {} // 0x000000018BD05AF4-0x000000018BD05B2C
			public static implicit operator InputActionMap(PlayerActions set) => default; // 0x000000018BD050B8-0x000000018BD050D8
			public void SetCallbacks(IPlayerActions instance) {} // 0x000000018BD051EC-0x000000018BD0520C
		}
	
		public struct UIActions // TypeDefIndex: 45198
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Navigate { get => default; } // 0x000000018BD05148-0x000000018BD05168 
			public InputAction Submit { get => default; } // 0x000000018BD050D8-0x000000018BD050F8 
			public InputAction Cancel { get => default; } // 0x000000018BD05A00-0x000000018BD05A20 
			public InputAction Point { get => default; } // 0x000000018BD05168-0x000000018BD05188 
			public InputAction Click { get => default; } // 0x000000018BD05188-0x000000018BD051EC 
			public InputAction ScrollWheel { get => default; } // 0x0000000184759830-0x0000000184759850 
			public InputAction MiddleClick { get => default; } // 0x0000000184759830-0x0000000184759850 
			public InputAction RightClick { get => default; } // 0x000000018BD05764-0x000000018BD05828 
			public InputAction TrackedDevicePosition { get => default; } // 0x000000018BD055DC-0x000000018BD056A0 
			public InputAction TrackedDeviceOrientation { get => default; } // 0x000000018BD05828-0x000000018BD058EC 
			public bool enabled { get => default; } // 0x000000018BA4F478-0x000000018BA4F494 
	
			// Constructors
			public UIActions(DefaultInputActions wrapper) : this() {
				m_Wrapper = default;
			} // 0x000000018BD0520C-0x000000018BD05214
	
			// Methods
			public InputActionMap Get() => default; // 0x000000018BD056A0-0x000000018BD05764
			public void Enable() {} // 0x000000018BD058EC-0x000000018BD059B0
			public void Disable() {} // 0x000000018646FE2C-0x000000018646FE34
			public static implicit operator InputActionMap(UIActions set) => default; // 0x000000018BD0E1D8-0x000000018BD0E1F4
			public void SetCallbacks(IUIActions instance) {} // 0x000000018BD0E1BC-0x000000018BD0E1D8
		}
	
		public interface IPlayerActions // TypeDefIndex: 45199
		{
			// Methods
			void OnMove(InputAction.CallbackContext context); // 0x000000018BA4F69C-0x000000018BA4F6B8
			void OnLook(InputAction.CallbackContext context); // 0x000000018BD0D9B0-0x000000018BD0D9D4
			void OnFire(InputAction.CallbackContext context); // 0x000000018BD0D98C-0x000000018BD0D9B0
		}
	
		public interface IUIActions // TypeDefIndex: 45200
		{
			// Methods
			void OnNavigate(InputAction.CallbackContext context); // 0x000000018BD0E1F4-0x000000018BD0E218
			void OnSubmit(InputAction.CallbackContext context); // 0x000000018BD0E218-0x000000018BD0E234
			void OnCancel(InputAction.CallbackContext context); // 0x000000018BD0D9D4-0x000000018BD0E1BC
			void OnPoint(InputAction.CallbackContext context); // 0x000000018646FE2C-0x000000018646FE34
			void OnClick(InputAction.CallbackContext context); // 0x000000018BD1A8AC-0x000000018BD1A8C8
			void OnScrollWheel(InputAction.CallbackContext context); // 0x000000018BA4F6B8-0x000000018BA4F6D4
			void OnMiddleClick(InputAction.CallbackContext context); // 0x000000018BD1A854-0x000000018BD1A870
			void OnRightClick(InputAction.CallbackContext context); // 0x000000018BD1A8C8-0x000000018BD1A8E4
			void OnTrackedDevicePosition(InputAction.CallbackContext context); // 0x000000018BD1A870-0x000000018BD1A88C
			void OnTrackedDeviceOrientation(InputAction.CallbackContext context); // 0x000000018BD1A904-0x000000018BD1A920
		}
	
		// Constructors
		public DefaultInputActions() {} // 0x000000018BD1A8E4-0x000000018BD1A904
	
		// Methods
		public void Dispose() {} // 0x000000018BD1A940-0x000000018BD1A960
		public bool Contains(InputAction action) => default; // 0x000000018BD1A984-0x000000018BD1A9A0
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x000000018BD18F3C-0x000000018BD1A854
		IEnumerator IEnumerable.GetEnumerator() => default;
		public void Enable() {}
		public void Disable() {}
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x0205BDFB */) => default;
		public int FindBinding(InputBinding bindingMask, out InputAction action) {
			action = default;
			return default;
		}
	}

	public class InputValue // TypeDefIndex: 45202
	{
		// Fields
		internal InputAction.CallbackContext? m_Context; // 0x10
	
		// Properties
		public bool isPressed { get => default; } // 0x000000018BD0D930-0x000000018BD0D98C 
	
		// Constructors
		public InputValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public object Get() => default; // 0x000000018BD0D8D8-0x000000018BD0D930
		public TValue Get<TValue>()
			where TValue : struct => default;
	}

	public class PlayerInput : MonoBehaviour // TypeDefIndex: 45207
	{
		// Fields
		public const string DeviceLostMessage = "OnDeviceLost"; // Metadata: 0x0205BE00
		public const string DeviceRegainedMessage = "OnDeviceRegained"; // Metadata: 0x0205BE0D
		public const string ControlsChangedMessage = "OnControlsChanged"; // Metadata: 0x0205BE1E
		private int m_AllMapsHashCode; // 0x18
		internal InputActionAsset m_Actions; // 0x20
		internal PlayerNotifications m_NotificationBehavior; // 0x28
		internal InputSystemUIInputModule m_UIInputModule; // 0x30
		internal DeviceLostEvent m_DeviceLostEvent; // 0x38
		internal DeviceRegainedEvent m_DeviceRegainedEvent; // 0x40
		internal ControlsChangedEvent m_ControlsChangedEvent; // 0x48
		internal ActionEvent[] m_ActionEvents; // 0x50
		internal bool m_NeverAutoSwitchControlSchemes; // 0x58
		internal string m_DefaultControlScheme; // 0x60
		internal string m_DefaultActionMap; // 0x68
		internal int m_SplitScreenIndex; // 0x70
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
		public bool inputIsActive { get => default; } // 0x0000000185AE8FE0-0x0000000185AE8FF0 
		public bool active { get => default; } // 0x0000000181BE64B0-0x0000000181BE64C0 
		public int playerIndex { get => default; } // 0x000000018BD157D8-0x000000018BD1581C 
		public int splitScreenIndex { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public InputActionAsset actions { get => default; set {} } // 0x000000018BD1576C-0x000000018BD157D8 0x00000001813AC280-0x00000001813AC290
		public string currentControlScheme { get => default; } // 0x0000000185A62990-0x0000000185A629A0 
		public string defaultControlScheme { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x000000018BD1581C-0x000000018BD15864
		public bool neverAutoSwitchControlSchemes { get => default; set {} } // 0x000000018BD14E88-0x000000018BD14EE0 0x000000018BD155C0-0x000000018BD1563C
		public InputActionMap currentActionMap { get => default; set {} } // 0x000000018BD150AC-0x000000018BD1511C 0x000000018BD1511C-0x000000018BD1518C
		public string defaultActionMap { get => default; set {} } // 0x000000018BD14FA0-0x000000018BD15010 0x000000018BD14BE8-0x000000018BD14C90
		public PlayerNotifications notificationBehavior { get => default; set {} } // 0x000000018BD15320-0x000000018BD153C8 0x000000018BD14D38-0x000000018BD14DE0
		public ReadOnlyArray<ActionEvent> actionEvents { get => default; set {} } // 0x000000018BD15470-0x000000018BD15518 0x000000018BD14DE0-0x000000018BD14E88
		public DeviceLostEvent deviceLostEvent { get => default; } // 0x000000018BD15518-0x000000018BD155C0 
		public DeviceRegainedEvent deviceRegainedEvent { get => default; } // 0x000000018BD14C90-0x000000018BD14D38 
		public ControlsChangedEvent controlsChangedEvent { get => default; } // 0x000000018BD153C8-0x000000018BD15470 
		public Camera camera { get => default; set {} } // 0x000000018BD15288-0x000000018BD15320 
		public InputSystemUIInputModule uiInputModule { get => default; set {} } // 0x000000018BD100DC-0x000000018BD10180 0x000000018BD149A8-0x000000018BD14B80
		public InputUser user { get => default; } // 0x000000018BD113C8-0x000000018BD113F4 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x000000018BD137AC-0x000000018BD137B4 
		public bool hasMissingRequiredDevices { get => default; } // 0x000000018BD13FDC-0x000000018BD141D4 
		public static ReadOnlyArray<PlayerInput> all { get => default; } // 0x000000018BD141D4-0x000000018BD14320 
		public static bool isSinglePlayer { get => default; } // 0x000000018BD13EAC-0x000000018BD13FDC 
	
		// Events
		public event Action<InputAction.CallbackContext> onActionTriggered;
		public event Action<PlayerInput> onDeviceLost;
		public event Action<PlayerInput> onDeviceRegained;
		public event Action<PlayerInput> onControlsChanged;
	
		// Nested types
		[Serializable]
		public class ActionEvent : UnityEvent<InputAction.CallbackContext> // TypeDefIndex: 45203
		{
			// Fields
			private string m_ActionId; // 0x30
			private string m_ActionName; // 0x38
	
			// Properties
			public string actionId { get => default; } // 0x0000000185FCD9D0-0x0000000185FCD9E0 
			public string actionName { get => default; } // 0x0000000185FCD9D0-0x0000000185FCD9E0 
	
			// Constructors
			public ActionEvent() {} // 0x00000001834A0D50-0x00000001834A0D60
			public ActionEvent(InputAction action) {} // 0x0000000185FB0690-0x0000000185FB06A0
			public ActionEvent(Guid actionGUID, string name = null) {} // 0x000000018BD14EE0-0x000000018BD14F28
		}
	
		[Serializable]
		public class DeviceLostEvent : UnityEvent<PlayerInput> // TypeDefIndex: 45204
		{
			// Constructors
			public DeviceLostEvent() {} // 0x000000018BD1563C-0x000000018BD1576C
		}
	
		[Serializable]
		public class DeviceRegainedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 45205
		{
			// Constructors
			public DeviceRegainedEvent() {} // 0x000000018BD15010-0x000000018BD150AC
		}
	
		[Serializable]
		public class ControlsChangedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 45206
		{
			// Constructors
			public ControlsChangedEvent() {} // 0x0000000185FB0530-0x0000000185FB0540
		}
	
		// Constructors
		public PlayerInput() {} // 0x000000018BD05B68-0x000000018BD05BA4
		static PlayerInput() {} // 0x000000018BD0507C-0x000000018BD050B8
	
		// Methods
		public TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice => default; // 0x000000018BD117F0-0x000000018BD118CC
		public void ActivateInput() {} // 0x000000018BD11674-0x000000018BD117F0
		private void UpdateDelegates() {} // 0x000000018BD12360-0x000000018BD124F8
		public void DeactivateInput() {} // 0x000000018BD121A0-0x000000018BD12360
		public void PassivateInput() {} // 0x000000018BD11444-0x000000018BD11674
		public bool SwitchCurrentControlScheme(UnityEngine.InputSystem.InputDevice[] devices) => default; // 0x000000018BD11C7C-0x000000018BD11FE4
		public void SwitchCurrentControlScheme(string controlScheme, UnityEngine.InputSystem.InputDevice[] devices) {} // 0x000000018BD11188-0x000000018BD113C8
		public void SwitchCurrentActionMap(string mapNameOrId) {} // 0x000000018BD14650-0x000000018BD14844
		public static PlayerInput GetPlayerByIndex(int playerIndex) => default; // 0x000000018BD11FE4-0x000000018BD121A0
		public static PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD14844-0x000000018BD149A8
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x0205BDFC */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x0205BDFD */, UnityEngine.InputSystem.InputDevice pairWithDevice = null) => default; // 0x000000018BD124F8-0x000000018BD12700
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x0205BDFE */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x0205BDFF */, UnityEngine.InputSystem.InputDevice[] pairWithDevices) => default; // 0x000000018BD10E78-0x000000018BD11140
		private static PlayerInput DoInstantiate(GameObject prefab) => default; // 0x000000018BD11140-0x000000018BD11188
		private void InitializeActions() {} // 0x000000018BD1034C-0x000000018BD10E18
		private void CopyActionAssetAndApplyBindingOverrides() {} // 0x000000018BD11B90-0x000000018BD11C7C
		private void UninitializeActions() {} // 0x000000018BD14580-0x000000018BD14650
		private void InstallOnActionTriggeredHook() {} // 0x000000018BD14320-0x000000018BD14580
		private void UninstallOnActionTriggeredHook() {} // 0x000000018BD10180-0x000000018BD1034C
		private void OnActionTriggered(InputAction.CallbackContext context) {} // 0x000000018BD10E18-0x000000018BD10E78
		private void CacheMessageNames() {} // 0x000000018BD12A24-0x000000018BD12E84
		private void ClearCaches() {} // 0x000000018BD1387C-0x000000018BD139C4
		private void AssignUserAndDevices() {} // 0x000000018BD13A28-0x000000018BD13AA8
		private bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD137B4-0x000000018BD1387C
		private void UnassignUserAndDevices() {} // 0x000000018BD139C4-0x000000018BD13A28
		private bool TryToActivateControlScheme(InputControlScheme controlScheme) => default; // 0x000000018BD12828-0x000000018BD12A24
		private void AssignPlayerIndex() {} // 0x000000018BD113F4-0x000000018BD11444
		private void Awake() {} // 0x000000018BD119B8-0x000000018BD11AA4
		private void OnEnable() {} // 0x000000018BD11AA4-0x000000018BD11B90
		private void StartListeningForUnpairedDeviceActivity() {} // 0x000000018BD118CC-0x000000018BD119B8
		private void StopListeningForUnpairedDeviceActivity() {} // 0x000000018BD135E0-0x000000018BD137AC
		private void StartListeningForDeviceChanges() {} // 0x000000018BD12E84-0x000000018BD12F7C
		private void StopListeningForDeviceChanges() {} // 0x000000018BD12F7C-0x000000018BD135E0
		private void OnDisable() {} // 0x000000018BD12700-0x000000018BD12828
		public void DebugLogAction(InputAction.CallbackContext context) {} // 0x000000018BD13AA8-0x000000018BD13EAC
		private void HandleDeviceLost() {} // 0x000000018BD14BD0-0x000000018BD14BE8
		private void HandleDeviceRegained() {} // 0x000000018BD14B80-0x000000018BD14BD0
		private void HandleControlsChanged() {} // 0x00000001813B51D0-0x00000001813B51E0
		private static void OnUserChange(InputUser user, InputUserChange change, UnityEngine.InputSystem.InputDevice device) {} // 0x00000001813ECBC0-0x00000001813ECBD0
		private static bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr) => default; // 0x000000018BD04900-0x000000018BD0493C
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) {} // 0x000000018BD0493C-0x000000018BD04B7C
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018BD04B7C-0x000000018BD04BF4
		private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, UnityEngine.InputSystem.InputDevice[] devices) {} // 0x000000018BD05B2C-0x000000018BD05B68
	}

	public class PlayerInputManager : MonoBehaviour // TypeDefIndex: 45210
	{
		// Fields
		public const string PlayerJoinedMessage = "OnPlayerJoined"; // Metadata: 0x0205BE35
		public const string PlayerLeftMessage = "OnPlayerLeft"; // Metadata: 0x0205BE44
		private static PlayerInputManager _instance_k__BackingField; // 0x00
		internal PlayerNotifications m_NotificationBehavior; // 0x18
		internal int m_MaxPlayerCount; // 0x1C
		internal bool m_AllowJoining; // 0x20
		internal PlayerJoinBehavior m_JoinBehavior; // 0x24
		internal PlayerJoinedEvent m_PlayerJoinedEvent; // 0x28
		internal PlayerLeftEvent m_PlayerLeftEvent; // 0x30
		internal InputActionProperty m_JoinAction; // 0x38
		internal GameObject m_PlayerPrefab; // 0x50
		internal bool m_SplitScreen; // 0x58
		internal bool m_MaintainAspectRatioInSplitScreen; // 0x59
		internal int m_FixedNumberOfSplitScreens; // 0x5C
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
		public bool splitScreen { get => default; set {} } // 0x0000000185FB9F90-0x0000000185FB9FA0 0x0000000183F80460-0x0000000183F80470
		public bool maintainAspectRatioInSplitScreen { get => default; } // 0x0000000185FCCD00-0x0000000185FCCD10 
		public int fixedNumberOfSplitScreens { get => default; } // 0x000000018BD0FB40-0x000000018BD0FB90 
		public Rect splitScreenArea { get => default; } // 0x00000001813AE570-0x00000001813AE580 
		public int playerCount { get => default; } // 0x00000001813ECBF0-0x00000001813ECC00 
		public int maxPlayerCount { get => default; } // 0x0000000181424480-0x0000000181424490 
		public bool joiningEnabled { get => default; } // 0x000000018BD0FEB4-0x000000018BD0FF00 
		public PlayerJoinBehavior joinBehavior { get => default; set {} } // 0x0000000185FBAFF0-0x0000000185FBB010 0x000000018BD0FE10-0x000000018BD0FEB4
		public InputActionProperty joinAction { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public PlayerNotifications notificationBehavior { get => default; set {} } // 0x000000018BD0FB90-0x000000018BD0FC00 0x000000018BD0FC00-0x000000018BD0FC70
		public PlayerJoinedEvent playerJoinedEvent { get => default; } // 0x000000018BD0F930-0x000000018BD0F9D8 
		public PlayerLeftEvent playerLeftEvent { get => default; } // 0x000000018BD0FC70-0x000000018BD0FD18 
		public GameObject playerPrefab { get => default; set {} } // 0x000000018BD0FA80-0x000000018BD0FAB8 0x000000018BD0FDC0-0x000000018BD0FE10
		public static PlayerInputManager instance { get; private set; } // 0x000000018BD0E598-0x000000018BD0E770 0x000000018BD0E4BC-0x000000018BD0E598
		internal static string[] messages { get => default; } // 0x000000018BD0F380-0x000000018BD0F418 
	
		// Events
		public event Action<PlayerInput> onPlayerJoined;
		public event Action<PlayerInput> onPlayerLeft;
	
		// Nested types
		[Serializable]
		public class PlayerJoinedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 45208
		{
			// Constructors
			public PlayerJoinedEvent() {} // 0x0000000181BE64B0-0x0000000181BE64C0
		}
	
		[Serializable]
		public class PlayerLeftEvent : UnityEvent<PlayerInput> // TypeDefIndex: 45209
		{
			// Constructors
			public PlayerLeftEvent() {} // 0x000000018BD0FF00-0x000000018BD100DC
		}
	
		// Constructors
		public PlayerInputManager() {} // 0x000000018BD159E4-0x000000018BD15A20
	
		// Methods
		public void EnableJoining() {} // 0x000000018BD0EC98-0x000000018BD0ECF8
		public void DisableJoining() {} // 0x000000018BD0EC38-0x000000018BD0EC98
		internal void JoinPlayerFromUI() {} // 0x000000018BD0EB6C-0x000000018BD0EC38
		public void JoinPlayerFromAction(InputAction.CallbackContext context) {} // 0x000000018BD0ECF8-0x000000018BD0ED9C
		public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context) {} // 0x000000018BD0ED9C-0x000000018BD0EE40
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x0205BE30 */, int splitScreenIndex = -1 /* Metadata: 0x0205BE31 */, string controlScheme = null, UnityEngine.InputSystem.InputDevice pairWithDevice = null) => default; // 0x000000018BD0FAB8-0x000000018BD0FB40
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x0205BE32 */, int splitScreenIndex = -1 /* Metadata: 0x0205BE33 */, string controlScheme = null, UnityEngine.InputSystem.InputDevice[] pairWithDevices) => default; // 0x000000018BD0E234-0x000000018BD0E4BC
		private bool CheckIfPlayerCanJoin(int playerIndex = -1 /* Metadata: 0x0205BE34 */) => default; // 0x000000018BD0F0AC-0x000000018BD0F380
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) {} // 0x000000018BD0F038-0x000000018BD0F0AC
		private void OnEnable() {} // 0x000000018BD0F418-0x000000018BD0F908
		private void OnDisable() {} // 0x000000018BD0E770-0x000000018BD0EB6C
		private void UpdateSplitScreen() {} // 0x0000000185492010-0x0000000185492020
		private bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD0EE40-0x000000018BD0EF3C
		private void ValidateInputActionAsset() {} // 0x000000018BD0EF3C-0x000000018BD0F038
		internal void NotifyPlayerJoined(PlayerInput player) {} // 0x000000018BD0F908-0x000000018BD0F930
		internal void NotifyPlayerLeft(PlayerInput player) {} // 0x000000018BD159A8-0x000000018BD159E4
	}

	public enum PlayerJoinBehavior // TypeDefIndex: 45211
	{
		JoinPlayersWhenButtonIsPressed = 0,
		JoinPlayersWhenJoinActionIsTriggered = 1,
		JoinPlayersManually = 2
	}

	public enum PlayerNotifications // TypeDefIndex: 45212
	{
		SendMessages = 0,
		BroadcastMessages = 1,
		InvokeUnityEvents = 2,
		InvokeCSharpEvents = 3
	}

	internal struct DynamicBitfield // TypeDefIndex: 45213
	{
		// Fields
		public InlinedArray<ulong> array; // 0x00
		public int length; // 0x18
	
		// Methods
		public void SetLength(int newLength) {} // 0x0000000184BFBAA0-0x0000000184BFBB00
		public void SetBit(int bitIndex) {} // 0x0000000184584060-0x0000000184584100
		public bool TestBit(int bitIndex) => default; // 0x0000000184582AF0-0x0000000184582F00
		public void ClearBit(int bitIndex) {} // 0x0000000184584100-0x00000001845841A0
		public bool AnyBitIsSet() => default; // 0x0000000185103730-0x00000001851037B0
		private static int BitCountToULongCount(int bitCount) => default; // 0x0000000185FD7F10-0x0000000185FD7F20
	}
}

namespace UnityEngine.InputSystem.Composites
{
	public class AxisComposite : InputBindingComposite<float> // TypeDefIndex: 45614
	{
		// Fields
		public int negative; // 0x10
		public int positive; // 0x14
		public float minValue; // 0x18
		public float maxValue; // 0x1C
		public WhichSideWins whichSideWins; // 0x20
	
		// Properties
		public float midPoint { get => default; } // 0x0000000185FD7A80-0x0000000185FD7AA0 
	
		// Nested types
		public enum WhichSideWins // TypeDefIndex: 45613
		{
			Neither = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		public AxisComposite() {} // 0x000000018BCE202C-0x000000018BCE2078
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x000000018BCE1F28-0x000000018BCE202C
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE1E9C-0x000000018BCE1F28
	}

	public class ButtonWithOneModifier : InputBindingComposite<float> // TypeDefIndex: 45616
	{
		// Fields
		public int modifier; // 0x10
		public int button; // 0x14
		public bool overrideModifiersNeedToBePressedFirst; // 0x18
		public ModifiersOrder modifiersOrder; // 0x1C
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 45615
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithOneModifier() {} // 0x000000018BCE21BC-0x000000018BCE21E4
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x000000018BCE215C-0x000000018BCE21BC
		private bool ModifierIsPressed(ref InputBindingCompositeContext context) => default; // 0x000000018BCE20F8-0x000000018BCE215C
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE2078-0x000000018BCE208C
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018BCE208C-0x000000018BCE20F8
	}

	public class ButtonWithTwoModifiers : InputBindingComposite<float> // TypeDefIndex: 45618
	{
		// Fields
		public int modifier1; // 0x10
		public int modifier2; // 0x14
		public int button; // 0x18
		public bool overrideModifiersNeedToBePressedFirst; // 0x1C
		public ModifiersOrder modifiersOrder; // 0x20
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 45617
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithTwoModifiers() {} // 0x000000018BCE2350-0x000000018BCE2378
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x000000018BCE22F0-0x000000018BCE2350
		private bool ModifiersArePressed(ref InputBindingCompositeContext context) => default; // 0x000000018BCE2250-0x000000018BCE22F0
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE2078-0x000000018BCE208C
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018BCE21E4-0x000000018BCE2250
	}

	public class OneModifierComposite : InputBindingComposite // TypeDefIndex: 45620
	{
		// Fields
		public int modifier; // 0x10
		public int binding; // 0x14
		public bool overrideModifiersNeedToBePressedFirst; // 0x18
		public ModifiersOrder modifiersOrder; // 0x1C
		private int m_ValueSizeInBytes; // 0x20
		private System.Type m_ValueType; // 0x28
		private bool m_BindingIsButton; // 0x30
	
		// Properties
		public override System.Type valueType { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public override int valueSizeInBytes { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 45619
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public OneModifierComposite() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE410C-0x000000018BCE4148
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) {} // 0x000000018BCE4290-0x000000018BCE42FC
		private bool ModifierIsPressed(ref InputBindingCompositeContext context) => default; // 0x000000018BCE41E4-0x000000018BCE4250
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018BCE4148-0x000000018BCE41E4
		public override object ReadValueAsObject(ref InputBindingCompositeContext context) => default; // 0x000000018BCE4250-0x000000018BCE4290
		internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out System.Type valueType, out int valueSizeInBytes, out bool isButton) {
			valueType = default;
			valueSizeInBytes = default;
			isButton = default;
		} // 0x000000018BCE3E34-0x000000018BCE410C
	}

	public class TwoModifiersComposite : InputBindingComposite // TypeDefIndex: 45622
	{
		// Fields
		public int modifier1; // 0x10
		public int modifier2; // 0x14
		public int binding; // 0x18
		public bool overrideModifiersNeedToBePressedFirst; // 0x1C
		public ModifiersOrder modifiersOrder; // 0x20
		private int m_ValueSizeInBytes; // 0x24
		private System.Type m_ValueType; // 0x28
		private bool m_BindingIsButton; // 0x30
	
		// Properties
		public override System.Type valueType { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public override int valueSizeInBytes { get => default; } // 0x0000000181424480-0x0000000181424490 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 45621
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public TwoModifiersComposite() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE6E24-0x000000018BCE6E60
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) {} // 0x000000018BCE6FF4-0x000000018BCE7060
		private bool ModifiersArePressed(ref InputBindingCompositeContext context) => default; // 0x000000018BCE6EFC-0x000000018BCE6FA0
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018BCE6E60-0x000000018BCE6EFC
		public override object ReadValueAsObject(ref InputBindingCompositeContext context) => default; // 0x000000018BCE6FA0-0x000000018BCE6FF4
	}

	public class Vector2Composite : InputBindingComposite<Vector2> // TypeDefIndex: 45624
	{
		// Fields
		public int up; // 0x10
		public int down; // 0x14
		public int left; // 0x18
		public int right; // 0x1C
		public bool normalize; // 0x20
		public Mode mode; // 0x24
	
		// Nested types
		public enum Mode // TypeDefIndex: 45623
		{
			DigitalNormalized = 0,
			Digital = 1,
			Analog = 2
		}
	
		// Constructors
		public Vector2Composite() {} // 0x0000000185F5F880-0x0000000185F5F8C0
	
		// Methods
		public override Vector2 ReadValue(ref InputBindingCompositeContext context) => default; // 0x000000018BCE8308-0x000000018BCE8464
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE82E4-0x000000018BCE8308
	}

	public class Vector3Composite : InputBindingComposite<Vector3> // TypeDefIndex: 45626
	{
		// Fields
		public int up; // 0x10
		public int down; // 0x14
		public int left; // 0x18
		public int right; // 0x1C
		public int forward; // 0x20
		public int backward; // 0x24
		public Mode mode; // 0x28
	
		// Nested types
		public enum Mode // TypeDefIndex: 45625
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}
	
		// Constructors
		public Vector3Composite() {} // 0x000000018BCE86C4-0x000000018BCE89F4
	
		// Methods
		public override Vector3 ReadValue(ref InputBindingCompositeContext context) => default; // 0x000000018BCE8498-0x000000018BCE86C4
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x000000018BCE8464-0x000000018BCE8498
	}
}

namespace UnityEngine.InputSystem.Controls
{
	public class AnyKeyControl : ButtonControl // TypeDefIndex: 45525
	{
		// Constructors
		public AnyKeyControl() {} // 0x0000000185BA4530-0x0000000185BA45A0
	
		// Methods
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000185A5F270-0x0000000185A5F2E0
	}

	public class AxisControl : InputControl<float> // TypeDefIndex: 45527
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
		public enum Clamp // TypeDefIndex: 45526
		{
			None = 0,
			BeforeNormalize = 1,
			AfterNormalize = 2,
			ToConstantBeforeNormalize = 3
		}
	
		// Constructors
		public AxisControl() {} // 0x0000000185065810-0x0000000185065890
	
		// Methods
		protected float Preprocess(float value) => default; // 0x000000018BCD574C-0x000000018BCD5834
		private float Unpreprocess(float value) => default; // 0x000000018BCD5834-0x000000018BCD5894
		protected override void FinishSetup() {} // 0x000000018BCD567C-0x000000018BCD574C
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000184C57960-0x0000000184C57AC0
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x000000018BCD5894-0x000000018BCD5944
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr) => default; // 0x000000018BCD55F8-0x000000018BCD567C
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000184003470-0x00000001840034D0
		private float EvaluateMagnitude(float value) => default; // 0x0000000184004A10-0x0000000184004AC0
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BCD54C0-0x000000018BCD55F8
	}

	public class ButtonControl : AxisControl // TypeDefIndex: 45528
	{
		// Fields
		private bool m_NeedsToCheckFramePress; // 0x130
		private uint m_UpdateCountLastPressed; // 0x134
		private uint m_UpdateCountLastReleased; // 0x138
		private bool m_LastUpdateWasPress; // 0x13C
		private bool _needsToCheckFramePress_k__BackingField; // 0x13D
		public float pressPoint; // 0x140
		internal static float s_GlobalDefaultButtonPressPoint; // 0x00
		internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x04
		internal const float kMinButtonPressPoint = 0.0001f; // Metadata: 0x0205C257
	
		// Properties
		internal bool needsToCheckFramePress { get; private set; } // 0x0000000185FD7920-0x0000000185FD7930 0x0000000185FD7930-0x0000000185FD7940
		public float pressPointOrDefault { get => default; } // 0x00000001849550F0-0x0000000184955150 
		public bool isPressed { get => default; } // 0x000000018BCD5944-0x000000018BCD59A0 
		public bool wasPressedThisFrame { get => default; } // 0x0000000184CD6A40-0x0000000184CD6B40 
		public bool wasReleasedThisFrame { get => default; } // 0x000000018BCD59A0-0x000000018BCD5A94 
	
		// Constructors
		public ButtonControl() {} // 0x0000000185065710-0x0000000185065810
	
		// Methods
		public new bool IsValueConsideredPressed(float value) => default; // 0x00000001849550C0-0x00000001849550F0
		private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) {} // 0x0000000184CD6B90-0x0000000184CD6C30
		internal void UpdateWasPressed() {} // 0x0000000184954B30-0x0000000184954BC0
	}

	public class DeltaControl : Vector2Control // TypeDefIndex: 45529
	{
		// Fields
		private AxisControl _up_k__BackingField; // 0x120
		private AxisControl _down_k__BackingField; // 0x128
		private AxisControl _left_k__BackingField; // 0x130
		private AxisControl _right_k__BackingField; // 0x138
	
		// Properties
		public AxisControl up { get; set; } // 0x0000000185FB8700-0x0000000185FB8710 0x0000000186473590-0x00000001864735A4
		public AxisControl down { get; set; } // 0x0000000185FB8550-0x0000000185FB8560 0x00000001864735A4-0x00000001864735B8
		public AxisControl left { get; set; } // 0x0000000185FB84E0-0x0000000185FB84F0 0x00000001864735B8-0x00000001864735CC
		public AxisControl right { get; set; } // 0x0000000185FB8720-0x0000000185FB8730 0x00000001864735CC-0x00000001864735E0
	
		// Constructors
		public DeltaControl() {} // 0x000000018647316C-0x0000000186473174
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCD60B4-0x000000018BCD61BC
	}

	public class DiscreteButtonControl : ButtonControl // TypeDefIndex: 45531
	{
		// Fields
		public int minValue; // 0x148
		public int maxValue; // 0x14C
		public int wrapAtValue; // 0x150
		public int nullValue; // 0x154
		public WriteMode writeMode; // 0x158
	
		// Nested types
		public enum WriteMode // TypeDefIndex: 45530
		{
			WriteDisabled = 0,
			WriteNullAndMaxValue = 1
		}
	
		// Constructors
		public DiscreteButtonControl() {} // 0x0000000186473174-0x000000018647317C
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCD61BC-0x000000018BCD62D0
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCD62D0-0x000000018BCD6390
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x000000018BCD6390-0x000000018BCD6498
	}

	public class DoubleControl : InputControl<double> // TypeDefIndex: 45532
	{
		// Constructors
		public DoubleControl() {} // 0x0000000185065610-0x0000000185065690
	
		// Methods
		public override unsafe double ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCD6498-0x000000018BCD64F4
		public override unsafe void WriteValueIntoState(double value, void* statePtr) {} // 0x000000018BCD64F4-0x000000018BCD6558
	}

	public class DpadControl : Vector2Control // TypeDefIndex: 45535
	{
		// Fields
		private ButtonControl _up_k__BackingField; // 0x120
		private ButtonControl _down_k__BackingField; // 0x128
		private ButtonControl _left_k__BackingField; // 0x130
		private ButtonControl _right_k__BackingField; // 0x138
	
		// Properties
		public ButtonControl up { get; set; } // 0x00000001864735B8-0x00000001864735CC 0x0000000185FB8720-0x0000000185FB8730
		public ButtonControl down { get; set; } // 0x00000001864735CC-0x00000001864735E0 0x000000018BCD6AEC-0x000000018BCD6B48
		public ButtonControl left { get; set; } // 0x000000018BCD6674-0x000000018BCD677C 0x000000018BCD67F0-0x000000018BCD6970
		public ButtonControl right { get; set; } // 0x000000018BCD6970-0x000000018BCD6AEC 0x000000018BCD677C-0x000000018BCD67F0
	
		// Nested types
		public class DpadAxisControl : AxisControl // TypeDefIndex: 45533
		{
			// Fields
			private int _component_k__BackingField; // 0x130
	
			// Properties
			public int component { get; set; } // 0x0000000185FB8700-0x0000000185FB8710 0x0000000186473590-0x00000001864735A4
	
			// Constructors
			public DpadAxisControl() {} // 0x0000000185FB84E0-0x0000000185FB84F0
	
			// Methods
			protected override void FinishSetup() {} // 0x0000000185FB8550-0x0000000185FB8560
			public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x00000001864735A4-0x00000001864735B8
		}
	
		internal enum ButtonBits // TypeDefIndex: 45534
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}
	
		// Constructors
		public DpadControl() {} // 0x0000000185FD7940-0x0000000185FD7960
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000185FB8050-0x0000000185FB8060
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000185FB8070-0x0000000185FB8080
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr) {} // 0x000000018BCD6558-0x000000018BCD65D8
		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true /* Metadata: 0x0205C25D */) => default; // 0x000000018BCD65D8-0x000000018BCD666C
		public static Vector2 MakeDpadVector(float up, float down, float left, float right) => default; // 0x000000018BCD666C-0x000000018BCD6674
	}

	public class IntegerControl : InputControl<int> // TypeDefIndex: 45536
	{
		// Constructors
		public IntegerControl() {} // 0x0000000185114120-0x00000001851141A0
	
		// Methods
		public override unsafe int ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000184FCBBA0-0x0000000184FCBC20
		public override unsafe void WriteValueIntoState(int value, void* statePtr) {} // 0x000000018BCDDA58-0x000000018BCDDAD4
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BCDD9B0-0x000000018BCDDA58
	}

	public class KeyControl : ButtonControl // TypeDefIndex: 45537
	{
		// Fields
		private UnityEngine.InputSystem.Key _keyCode_k__BackingField; // 0x148
		private int m_ScanCode; // 0x14C
	
		// Properties
		public UnityEngine.InputSystem.Key keyCode { get; set; } // 0x0000000181ABEDE0-0x0000000181ABEDF0 0x0000000181ABEE30-0x0000000181ABEE40
		public int scanCode { get => default; } // 0x000000018BCDF5D0-0x000000018BCDF5EC 
	
		// Constructors
		public KeyControl() {} // 0x0000000186473174-0x000000018647317C
	
		// Methods
		protected override void RefreshConfiguration() {} // 0x000000018BCDF424-0x000000018BCDF5D0
	}

	public class QuaternionControl : InputControl<Quaternion> // TypeDefIndex: 45538
	{
		// Fields
		private AxisControl _x_k__BackingField; // 0x120
		private AxisControl _y_k__BackingField; // 0x128
		private AxisControl _z_k__BackingField; // 0x130
		private AxisControl _w_k__BackingField; // 0x138
	
		// Properties
		public AxisControl x { get; set; } // 0x0000000185FB8700-0x0000000185FB8710 0x0000000186473590-0x00000001864735A4
		public AxisControl y { get; set; } // 0x0000000185FB8550-0x0000000185FB8560 0x00000001864735A4-0x00000001864735B8
		public AxisControl z { get; set; } // 0x0000000185FB84E0-0x0000000185FB84F0 0x00000001864735B8-0x00000001864735CC
		public AxisControl w { get; set; } // 0x0000000185FB8720-0x0000000185FB8730 0x00000001864735CC-0x00000001864735E0
	
		// Constructors
		public QuaternionControl() {} // 0x000000018BCE0568-0x000000018BCE05D0
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE023C-0x000000018BCE0358
		public override unsafe Quaternion ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCE0358-0x000000018BCE0494
		public override unsafe void WriteValueIntoState(Quaternion value, void* statePtr) {} // 0x000000018BCE0494-0x000000018BCE0568
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BCDFFF0-0x000000018BCE023C
	}

	public class StickControl : Vector2Control // TypeDefIndex: 45539
	{
		// Fields
		private ButtonControl _up_k__BackingField; // 0x120
		private ButtonControl _down_k__BackingField; // 0x128
		private ButtonControl _left_k__BackingField; // 0x130
		private ButtonControl _right_k__BackingField; // 0x138
	
		// Properties
		public ButtonControl up { get; set; } // 0x0000000185FB8700-0x0000000185FB8710 0x0000000186473590-0x00000001864735A4
		public ButtonControl down { get; set; } // 0x0000000185FB8550-0x0000000185FB8560 0x00000001864735A4-0x00000001864735B8
		public ButtonControl left { get; set; } // 0x0000000185FB84E0-0x0000000185FB84F0 0x00000001864735B8-0x00000001864735CC
		public ButtonControl right { get; set; } // 0x0000000185FB8720-0x0000000185FB8730 0x00000001864735CC-0x00000001864735E0
	
		// Constructors
		public StickControl() {} // 0x000000018647316C-0x0000000186473174
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE07B8-0x000000018BCE08C0
	}

	public class TouchControl : InputControl<TouchState> // TypeDefIndex: 45540
	{
		// Fields
		private TouchPressControl _press_k__BackingField; // 0x170
		private IntegerControl _displayIndex_k__BackingField; // 0x178
		private IntegerControl _touchId_k__BackingField; // 0x180
		private Vector2Control _position_k__BackingField; // 0x188
		private DeltaControl _delta_k__BackingField; // 0x190
		private AxisControl _pressure_k__BackingField; // 0x198
		private Vector2Control _radius_k__BackingField; // 0x1A0
		private TouchPhaseControl _phase_k__BackingField; // 0x1A8
		private ButtonControl _indirectTouch_k__BackingField; // 0x1B0
		private ButtonControl _tap_k__BackingField; // 0x1B8
		private IntegerControl _tapCount_k__BackingField; // 0x1C0
		private DoubleControl _startTime_k__BackingField; // 0x1C8
		private Vector2Control _startPosition_k__BackingField; // 0x1D0
	
		// Properties
		public TouchPressControl press { get; set; } // 0x0000000185FB88C0-0x0000000185FB88D0 0x0000000186473504-0x0000000186473518
		public IntegerControl displayIndex { get; set; } // 0x0000000185FB88B0-0x0000000185FB88C0 0x0000000186473518-0x000000018647352C
		public IntegerControl touchId { get; set; } // 0x0000000185FB8280-0x0000000185FB8290 0x000000018647352C-0x0000000186473540
		public Vector2Control position { get; set; } // 0x0000000185FB8360-0x0000000185FB8370 0x0000000186473540-0x0000000186473554
		public DeltaControl delta { get; set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public AxisControl pressure { get; set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public Vector2Control radius { get; set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public TouchPhaseControl phase { get; set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public ButtonControl indirectTouch { get; set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public ButtonControl tap { get; set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public IntegerControl tapCount { get; set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public DoubleControl startTime { get; set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public Vector2Control startPosition { get; set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public bool isInProgress { get => default; } // 0x00000001849509E0-0x0000000184950A40 
	
		// Constructors
		public TouchControl() {} // 0x00000001856FE030-0x00000001856FE0A0
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE0A8C-0x000000018BCE0DDC
		public override unsafe TouchState ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCE0DDC-0x000000018BCE0E58
		public override unsafe void WriteValueIntoState(TouchState value, void* statePtr) {} // 0x000000018BCE0E58-0x000000018BCE0ED8
	}

	public class TouchPhaseControl : InputControl<UnityEngine.InputSystem.TouchPhase> // TypeDefIndex: 45541
	{
		// Constructors
		public TouchPhaseControl() {} // 0x0000000185065590-0x0000000185065610
	
		// Methods
		public override unsafe UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000184FCBB30-0x0000000184FCBBA0
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr) {} // 0x000000018BCE0ED8-0x000000018BCE0F38
	}

	public class TouchPressControl : ButtonControl // TypeDefIndex: 45542
	{
		// Constructors
		public TouchPressControl() {} // 0x0000000186473174-0x000000018647317C
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE0F38-0x000000018BCE104C
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCE104C-0x000000018BCE10C8
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x000000018BCE10C8-0x000000018BCE1114
	}

	public class Vector2Control : InputControl<Vector2> // TypeDefIndex: 45543
	{
		// Fields
		private AxisControl _x_k__BackingField; // 0x110
		private AxisControl _y_k__BackingField; // 0x118
	
		// Properties
		public AxisControl x { get; set; } // 0x0000000185FB8600-0x0000000185FB8610 0x00000001864735E0-0x00000001864735F4
		public AxisControl y { get; set; } // 0x0000000185FB8540-0x0000000185FB8550 0x00000001864735F4-0x0000000186473608
	
		// Constructors
		public Vector2Control() {} // 0x0000000185065690-0x0000000185065710
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE1728-0x000000018BCE17D8
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000184F1DD80-0x0000000184F1DE30
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr) {} // 0x000000018BCE17D8-0x000000018BCE1884
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000185172350-0x0000000185172410
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BCE1600-0x000000018BCE1728
	}

	public class Vector3Control : InputControl<Vector3> // TypeDefIndex: 45544
	{
		// Fields
		private AxisControl _x_k__BackingField; // 0x118
		private AxisControl _y_k__BackingField; // 0x120
		private AxisControl _z_k__BackingField; // 0x128
	
		// Properties
		public AxisControl x { get; set; } // 0x0000000185FB8540-0x0000000185FB8550 0x00000001864735F4-0x0000000186473608
		public AxisControl y { get; set; } // 0x0000000185FB8700-0x0000000185FB8710 0x0000000186473590-0x00000001864735A4
		public AxisControl z { get; set; } // 0x0000000185FB8550-0x0000000185FB8560 0x00000001864735A4-0x00000001864735B8
	
		// Constructors
		public Vector3Control() {} // 0x000000018BCE1D84-0x000000018BCE1DE8
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCE1ADC-0x000000018BCE1BC0
		public override unsafe Vector3 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BCE1BC0-0x000000018BCE1CC0
		public override unsafe void WriteValueIntoState(Vector3 value, void* statePtr) {} // 0x000000018BCE1CC0-0x000000018BCE1D84
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x000000018BCE1A70-0x000000018BCE1ADC
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BCE18D8-0x000000018BCE1A70
	}
}

namespace UnityEngine.InputSystem.DualShock
{
	public class DualShockGamepad : Gamepad, IDualShockHaptics // TypeDefIndex: 45336
	{
		// Fields
		private ButtonControl _touchpadButton_k__BackingField; // 0x210
		private ButtonControl _optionsButton_k__BackingField; // 0x218
		private ButtonControl _shareButton_k__BackingField; // 0x220
		private ButtonControl _L1_k__BackingField; // 0x228
		private ButtonControl _R1_k__BackingField; // 0x230
		private ButtonControl _L2_k__BackingField; // 0x238
		private ButtonControl _R2_k__BackingField; // 0x240
		private ButtonControl _L3_k__BackingField; // 0x248
		private ButtonControl _R3_k__BackingField; // 0x250
		private static DualShockGamepad _current_k__BackingField; // 0x00
		private HID.HIDDeviceDescriptor _hidDescriptor_k__BackingField; // 0x258
	
		// Properties
		public ButtonControl touchpadButton { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public ButtonControl optionsButton { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
		public ButtonControl shareButton { get; protected set; } // 0x0000000185FB8890-0x0000000185FB88A0 0x0000000187A47BB8-0x0000000187A47BCC
		public ButtonControl L1 { get; protected set; } // 0x0000000185FB8620-0x0000000185FB8630 0x0000000187A47794-0x0000000187A477A8
		public ButtonControl R1 { get; protected set; } // 0x0000000185FB8310-0x0000000185FB8320 0x0000000187A37678-0x0000000187A3768C
		public ButtonControl L2 { get; protected set; } // 0x0000000185FB8850-0x0000000185FB8860 0x0000000187A47B54-0x0000000187A47B68
		public ButtonControl R2 { get; protected set; } // 0x0000000185FB8770-0x0000000185FB8780 0x0000000187A479C4-0x0000000187A479D8
		public ButtonControl L3 { get; protected set; } // 0x0000000185FB8840-0x0000000185FB8850 0x0000000187A47B40-0x0000000187A47B54
		public ButtonControl R3 { get; protected set; } // 0x0000000185FB8470-0x0000000185FB8480 0x0000000187A47550-0x0000000187A47564
		public static new DualShockGamepad current { get; private set; } // 0x000000018BD294BC-0x000000018BD294F4 0x000000018BD294F4-0x000000018BD29544
		internal HID.HIDDeviceDescriptor hidDescriptor { get; private set; } // 0x0000000185FD8700-0x0000000185FD8730 0x000000018BD29544-0x000000018BD29570
	
		// Constructors
		public DualShockGamepad() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public override void MakeCurrent() {} // 0x000000018BD2944C-0x000000018BD29468
		protected override void OnRemoved() {} // 0x000000018BD29468-0x000000018BD294BC
		protected override void FinishSetup() {} // 0x000000018BD292A0-0x000000018BD2944C
		public virtual void SetLightBarColor(UnityEngine.Color color) {} // 0x0000000185492010-0x0000000185492020
	}

	public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 45341
	{
		// Fields
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		private ButtonControl _playStationButton_k__BackingField; // 0x298
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		protected UnityEngine.Color? m_LightBarColor; // 0x2B0
		private byte outputSequenceId; // 0x2C4
		internal const byte JitterMaskLow = 120; // Metadata: 0x0205C062
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0205C063
	
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000187A47B90-0x0000000187A47BA4 0x000000018BD279F0-0x000000018BD27AC4
		public ButtonControl rightTriggerButton { get; protected set; } // 0x000000018BD27CE0-0x000000018BD27D7C 0x000000018BD27D7C-0x000000018BD27E00
		public ButtonControl playStationButton { get; protected set; } // 0x000000018BD27E00-0x000000018BD27E74 0x000000018BD27E74-0x000000018BD27F08
	
		// Nested types
		internal struct DualSenseHIDGenericInputReport // TypeDefIndex: 45337
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get => default; } // 0x0000000181ACF050-0x0000000181ACF060 
		}
	
		internal struct DualSenseHIDUSBInputReport // TypeDefIndex: 45338
		{
			// Fields
			public const int ExpectedReportId = 1; // Metadata: 0x0205C064
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
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000187B4A1E0-0x0000000187B4A1F4
		}
	
		internal struct DualSenseHIDBluetoothInputReport // TypeDefIndex: 45339
		{
			// Fields
			public const int ExpectedReportId = 49; // Metadata: 0x0205C065
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
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000185FB8560-0x0000000185FB8570
		}
	
		internal struct DualSenseHIDMinimalInputReport // TypeDefIndex: 45340
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
			static DualSenseHIDMinimalInputReport() {
				ExpectedSize1 = default;
				ExpectedSize2 = default;
			} // 0x0000000185FB8880-0x0000000185FB8890
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000187A47654-0x0000000187A47668
		}
	
		// Constructors
		public DualSenseGamepadHID() {} // 0x000000018BD285D8-0x000000018BD28628
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD28118-0x000000018BD281D8
		public override void PauseHaptics() {} // 0x000000018BD27F08-0x000000018BD28118
		public override void ResetHaptics() {} // 0x000000018BD27AC4-0x000000018BD27AFC
		public override void ResumeHaptics() {} // 0x000000018BD27AFC-0x000000018BD27B34
		public override void SetLightBarColor(UnityEngine.Color color) {} // 0x000000018BD27B34-0x000000018BD27B6C
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x000000018BD281D8-0x000000018BD28384
		public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, UnityEngine.Color? color) => default; // 0x000000018BD28384-0x000000018BD2854C
		private static unsafe bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState) => default; // 0x0000000185492010-0x0000000185492020
		private static unsafe bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState) => default; // 0x000000018BD27B6C-0x000000018BD27CE0
		private static unsafe bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState) => default; // 0x00000001814A81B0-0x00000001814A81C0
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x00000001864734FC-0x0000000186473504
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) => default; // 0x0000000185FD8270-0x0000000185FD8280
		public void OnNextUpdate() {} // 0x0000000185FD8610-0x0000000185FD8660
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000185FD8500-0x0000000185FD8550
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x0000000185FD85C0-0x0000000185FD8610
	}

	public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 45343
	{
		// Fields
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		private ButtonControl _playStationButton_k__BackingField; // 0x298
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		private UnityEngine.Color? m_LightBarColor; // 0x2B0
		internal const byte JitterMaskLow = 120; // Metadata: 0x0205C066
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0205C067
	
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000185FB8560-0x0000000185FB8570 0x0000000187A47654-0x0000000187A47668
		public ButtonControl rightTriggerButton { get; protected set; } // 0x0000000185FB8880-0x0000000185FB8890 0x0000000187A47B90-0x0000000187A47BA4
		public ButtonControl playStationButton { get; protected set; } // 0x000000018BD286FC-0x000000018BD287D0 0x000000018BD28944-0x000000018BD28A60
	
		// Nested types
		internal struct DualShock4HIDGenericInputReport // TypeDefIndex: 45342
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
			public static FourCC Format { get => default; } // 0x0000000181ACF050-0x0000000181ACF060 
	
			// Methods
			public DualShock4HIDInputReport ToHIDInputReport() => default; // 0x0000000187B4A1E0-0x0000000187B4A1F4
		}
	
		// Constructors
		public DualShock4GamepadHID() {} // 0x0000000185FD86B0-0x0000000185FD8700
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD28A60-0x000000018BD28B9C
		public override void PauseHaptics() {} // 0x000000018BD28B9C-0x000000018BD28D24
		public override void ResetHaptics() {} // 0x000000018BD28D24-0x000000018BD28E2C
		public override void ResumeHaptics() {} // 0x000000018BD28FA4-0x000000018BD290BC
		public override void SetLightBarColor(UnityEngine.Color color) {} // 0x000000018BD28E2C-0x000000018BD28FA4
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x000000018BD290BC-0x000000018BD29214
		public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, UnityEngine.Color color) => default; // 0x0000000185492010-0x0000000185492020
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) => default; // 0x000000018BD287D0-0x000000018BD28944
		public void OnNextUpdate() {} // 0x00000001814A81B0-0x00000001814A81C0
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x00000001864734FC-0x0000000186473504
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x0000000185FD8270-0x0000000185FD8280
	}

	public class DualShock3GamepadHID : DualShockGamepad // TypeDefIndex: 45344
	{
		// Fields
		private ButtonControl _leftTriggerButton_k__BackingField; // 0x288
		private ButtonControl _rightTriggerButton_k__BackingField; // 0x290
		private ButtonControl _playStationButton_k__BackingField; // 0x298
	
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000181ACF050-0x0000000181ACF060 0x0000000187B4A1E0-0x0000000187B4A1F4
		public ButtonControl rightTriggerButton { get; protected set; } // 0x0000000185FB8560-0x0000000185FB8570 0x0000000187A47654-0x0000000187A47668
		public ButtonControl playStationButton { get; protected set; } // 0x0000000185FB8880-0x0000000185FB8890 0x0000000187A47B90-0x0000000187A47BA4
	
		// Constructors
		public DualShock3GamepadHID() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD28628-0x000000018BD286FC
	}

	internal static class DualShockSupport // TypeDefIndex: 45345
	{
		// Methods
		public static void Initialize() {} // 0x0000000184D554E0-0x0000000184D55990
	}

	public interface IDualShockHaptics : IDualMotorRumble // TypeDefIndex: 45346
	{
		// Methods
		void SetLightBarColor(UnityEngine.Color color);
	}
}

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	public struct DualSenseHIDInputReport : IInputStateTypeInfo // TypeDefIndex: 45347
	{
		// Fields
		public static FourCC Format; // 0x00
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		public byte leftTrigger; // 0x04
		public byte rightTrigger; // 0x05
		public byte buttons0; // 0x06
		public byte buttons1; // 0x07
		public byte buttons2; // 0x08
	
		// Properties
		public FourCC format { get => default; } // 0x000000018BD28588-0x000000018BD285D8 
	
		// Constructors
		static DualSenseHIDInputReport() {
			Format = default;
		} // 0x000000018BD2854C-0x000000018BD28588
	}

	internal struct DualSenseHIDOutputReportPayload // TypeDefIndex: 45348
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

	internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 45349
	{
		// Fields
		internal const int kSize = 56; // Metadata: 0x0205C068
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public DualSenseHIDOutputReportPayload payload; // 0x09
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
	
		// Methods
		public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize) => default; // 0x0000000185FD8660-0x0000000185FD86B0
	}

	internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 45351
	{
		// Fields
		internal const int kSize = 86; // Metadata: 0x0205C069
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte tag1; // 0x09
		public byte tag2; // 0x0A
		public DualSenseHIDOutputReportPayload payload; // 0x0B
		public uint crc32; // 0x52
		public _rawData_e__FixedBuffer rawData; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
	
		// Nested types
		public struct _rawData_e__FixedBuffer // TypeDefIndex: 45350
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize) => default; // 0x0000000185FD8550-0x0000000185FD85C0
	}

	internal struct DualShock4HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 45352
	{
		// Fields
		public static FourCC Format; // 0x00
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		public byte buttons1; // 0x04
		public byte buttons2; // 0x05
		public byte buttons3; // 0x06
		public byte leftTrigger; // 0x07
		public byte rightTrigger; // 0x08
	
		// Properties
		public FourCC format { get => default; } // 0x000000018BD29250-0x000000018BD292A0 
	
		// Constructors
		static DualShock4HIDInputReport() {
			Format = default;
		} // 0x000000018BD29214-0x000000018BD29250
	}

	internal struct DualShock3HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 45354
	{
		// Fields
		private ushort padding1; // 0x00
		public byte buttons1; // 0x02
		public byte buttons2; // 0x03
		public byte buttons3; // 0x04
		private byte padding2; // 0x05
		public byte leftStickX; // 0x06
		public byte leftStickY; // 0x07
		public byte rightStickX; // 0x08
		public byte rightStickY; // 0x09
		private _padding3_e__FixedBuffer padding3; // 0x0A
		public byte leftTrigger; // 0x12
		public byte rightTrigger; // 0x13
	
		// Properties
		public FourCC format { get => default; } // 0x0000000185FD8270-0x0000000185FD8280 
	
		// Nested types
		public struct _padding3_e__FixedBuffer // TypeDefIndex: 45353
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 45358
	{
		// Fields
		internal const int kSize = 40; // Metadata: 0x0205C06B
		internal const int kReportId = 5; // Metadata: 0x0205C06C
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte flags; // 0x09
		public _unknown1_e__FixedBuffer unknown1; // 0x0A
		public byte highFrequencyMotorSpeed; // 0x0C
		public byte lowFrequencyMotorSpeed; // 0x0D
		public byte redColor; // 0x0E
		public byte greenColor; // 0x0F
		public byte blueColor; // 0x10
		public _unknown2_e__FixedBuffer unknown2; // 0x11
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD82E0-0x0000000185FD82F0 
	
		// Nested types
		public enum Flags // TypeDefIndex: 45355
		{
			Rumble = 1,
			Color = 2
		}
	
		public struct _unknown1_e__FixedBuffer // TypeDefIndex: 45356
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _unknown2_e__FixedBuffer // TypeDefIndex: 45357
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public void SetMotorSpeeds(float lowFreq, float highFreq) {} // 0x000000018BD295E8-0x000000018BD29634
		public void SetColor(UnityEngine.Color color) {} // 0x000000018BD29570-0x000000018BD295E8
		public static DualShockHIDOutputReport Create(int outputReportSize) => default; // 0x0000000185FD8730-0x0000000185FD8760
	}
}

namespace UnityEngine.InputSystem.Editor
{
	internal struct SampleFrequencyCalculator // TypeDefIndex: 45359
	{
		// Fields
		private double m_LastUpdateTime; // 0x00
		private int m_SampleCount; // 0x08
		private float _targetFrequency_k__BackingField; // 0x0C
		private float _frequency_k__BackingField; // 0x10
	
		// Properties
		public float targetFrequency { get; private set; } // 0x0000000185FBF760-0x0000000185FBF770 0x0000000185FBF770-0x0000000185FBF780
		public float frequency { get; private set; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x0000000181A6E380-0x0000000181A6E390
	
		// Constructors
		public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup) : this() {
			m_LastUpdateTime = default;
			m_SampleCount = default;
			<targetFrequency>k__BackingField = default;
			<frequency>k__BackingField = default;
		} // 0x0000000185FD8C60-0x0000000185FD8C80
	
		// Methods
		public void ProcessSample(InputEventPtr eventPtr) {} // 0x000000018BD31C78-0x000000018BD31C84
		public bool Update() => default; // 0x000000018BD31CC0-0x000000018BD31CE4
		public bool Update(double realtimeSinceStartup) => default; // 0x000000018BD31C84-0x000000018BD31CC0
	}
}

namespace UnityEngine.InputSystem.EnhancedTouch
{
	public static class EnhancedTouchSupport // TypeDefIndex: 45326
	{
		// Fields
		private static int s_Enabled; // 0x00
		private static InputSettings.UpdateMode s_UpdateMode; // 0x04
	
		// Properties
		public static bool enabled { get; } // 0x000000018BD29AD8-0x000000018BD29B14 
	
		// Methods
		public static void Enable() {} // 0x0000000184111790-0x0000000184111900
		public static void Disable() {} // 0x000000018BD296D0-0x000000018BD29830
		internal static void Reset() {} // 0x000000018BD298A8-0x000000018BD2994C
		private static void SetUpState() {} // 0x000000018539B6E0-0x000000018539BCF0
		internal static void TearDownState() {} // 0x000000018BD2994C-0x000000018BD29AD8
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018539B640-0x000000018539B6E0
		private static void OnSettingsChange() {} // 0x000000018BD29830-0x000000018BD298A8
		internal static void CheckEnabled() {} // 0x000000018BD29664-0x000000018BD296D0
	}

	public class Finger // TypeDefIndex: 45327
	{
		// Fields
		private readonly Touchscreen _screen_k__BackingField; // 0x10
		private readonly int _index_k__BackingField; // 0x18
		internal readonly InputStateHistory<TouchState> m_StateHistory; // 0x20
	
		// Properties
		public Touchscreen screen { get; } // 0x000000018346D130-0x000000018346D140 
		public int index { get; } // 0x00000001813AE560-0x00000001813AE570 
		public bool isActive { get => default; } // 0x000000018BD2A850-0x000000018BD2A8B8 
		public Vector2 screenPosition { get => default; } // 0x000000018BD2A988-0x000000018BD2AA14 
		public Touch lastTouch { get => default; } // 0x000000018BD2A8B8-0x000000018BD2A988 
		public Touch currentTouch { get => default; } // 0x000000018BD2A754-0x000000018BD2A850 
		public TouchHistory touchHistory { get => default; } // 0x000000018BD2AA14-0x000000018BD2AA50 
	
		// Constructors
		public Finger() {} // Dummy constructor
		internal Finger(Touchscreen screen, int index, InputUpdateType updateMask) {} // 0x0000000184952700-0x0000000184952970
	
		// Methods
		private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr) => default; // 0x000000018BD2A6B0-0x000000018BD2A754
		private void OnTouchRecorded(InputStateHistory.Record record) {} // 0x000000018BD2A3FC-0x000000018BD2A6B0
		private Touch FindTouch(uint uniqueId) => default; // 0x000000018BD29FE0-0x000000018BD2A1E4
		internal TouchHistory GetTouchHistory(Touch touch) => default; // 0x000000018BD2A1E4-0x000000018BD2A3FC
	}

	public struct Touch : IEquatable<Touch> // TypeDefIndex: 45332
	{
		// Fields
		private readonly Finger m_Finger; // 0x00
		internal InputStateHistory<TouchState> m_TouchRecord; // 0x08
		internal static GlobalState s_GlobalState; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x000000018BD35010-0x000000018BD35060 
		public Finger finger { get => default; } // 0x000000018BD350EC-0x000000018BD35128 
		public UnityEngine.InputSystem.TouchPhase phase { get => default; } // 0x000000018BD34EF8-0x000000018BD34F4C 
		public bool began { get => default; } // 0x000000018BD34EA4-0x000000018BD34EF8 
		public bool inProgress { get => default; } // 0x000000018BD34FBC-0x000000018BD35010 
		public bool ended { get => default; } // 0x000000018BD349D8-0x000000018BD34A2C 
		public int touchId { get => default; } // 0x000000018BD3509C-0x000000018BD350EC 
		public float pressure { get => default; } // 0x000000018BD34D68-0x000000018BD34DB0 
		public Vector2 radius { get => default; } // 0x000000018BD34A2C-0x000000018BD34A7C 
		public double startTime { get => default; } // 0x000000018BD34D14-0x000000018BD34D68 
		public double time { get => default; } // 0x000000018BD351C4-0x000000018BD35214 
		public Touchscreen screen { get => default; } // 0x000000018BD35174-0x000000018BD351C4 
		public Vector2 screenPosition { get => default; } // 0x000000018BD35060-0x000000018BD3509C 
		public Vector2 startScreenPosition { get => default; } // 0x000000018BD34AE4-0x000000018BD34B20 
		public Vector2 delta { get => default; } // 0x000000018BD34BA0-0x000000018BD34C90 
		public int tapCount { get => default; } // 0x0000000184FC3EB0-0x0000000184FC3F60 
		public bool isTap { get => default; } // 0x000000018BD34B20-0x000000018BD34BA0 
		public int displayIndex { get => default; } // 0x000000018BD348F4-0x000000018BD34990 
		public bool isInProgress { get => default; } // 0x000000018BD34F4C-0x000000018BD34FBC 
		internal uint updateStepCount { get => default; } // 0x000000018BD346BC-0x000000018BD34778 
		internal uint uniqueId { get => default; } // 0x000000018BD35250-0x000000018BD3530C 
		private ref TouchState state { get => default; } // 0x000000018BD34834-0x000000018BD348F4 
		private ref ExtraDataPerTouchState extraData { get => default; } // 0x000000018BD353C8-0x000000018BD35488 
		public TouchHistory history { get => default; } // 0x000000018BD34778-0x000000018BD34834 
		public static ReadOnlyArray<Touch> activeTouches { get => default; } // 0x000000018BD3530C-0x000000018BD353C8 
		public static ReadOnlyArray<Finger> fingers { get => default; } // 0x0000000184950B40-0x0000000184950BA0 
		public static ReadOnlyArray<Finger> activeFingers { get => default; } // 0x0000000184F8F900-0x0000000184F8F930 
		public static IEnumerable<Touchscreen> screens { get => default; } // 0x000000018BD3444C-0x000000018BD346BC 
		public static int maxHistoryLengthPerFinger { get => default; } // 0x0000000185FD8D00-0x0000000185FD8D30 
	
		// Events
		public static event Action<Finger> onFingerDown;
		public static event Action<Finger> onFingerUp;
		public static event Action<Finger> onFingerMove;
	
		// Nested types
		internal struct GlobalState // TypeDefIndex: 45328
		{
			// Fields
			internal InlinedArray<Touchscreen> touchscreens; // 0x00
			internal int historyLengthPerFinger; // 0x18
			internal CallbackArray<Action<Finger>> onFingerDown; // 0x20
			internal CallbackArray<Action<Finger>> onFingerMove; // 0x70
			internal CallbackArray<Action<Finger>> onFingerUp; // 0xC0
			internal FingerAndTouchState playerState; // 0x110
		}
	
		internal struct FingerAndTouchState // TypeDefIndex: 45329
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
			public void AddFingers(Touchscreen screen) {} // 0x000000018BD35214-0x000000018BD35250
			public void RemoveFingers(Touchscreen screen) {} // 0x00000001834AFB60-0x00000001834AFB70
			public void Destroy() {} // 0x000000018BD34DB0-0x000000018BD34E00
			public void UpdateActiveFingers() {} // 0x000000018BD34990-0x000000018BD349D8
			public void UpdateActiveTouches() {} // 0x000000018BD34C90-0x000000018BD34D14
		}
	
		internal struct ExtraDataPerTouchState // TypeDefIndex: 45330
		{
			// Fields
			public Vector2 accumulatedDelta; // 0x00
			public uint uniqueId; // 0x08
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45331
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__80_0; // 0x08
			public static Action __9__80_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BD34A7C-0x000000018BD34AE4
			public __c() {} // 0x000000018BD35128-0x000000018BD35174
	
			// Methods
			internal void _SaveAndResetState_b__80_0(ref GlobalState state) {} // 0x000000018BD34E00-0x000000018BD34E50
			internal void _SaveAndResetState_b__80_1() {} // 0x000000018BD34E50-0x000000018BD34EA4
		}
	
		// Constructors
		internal Touch(Finger finger, InputStateHistory<TouchState> touchRecord) : this() {
			m_Finger = default;
			m_TouchRecord = default;
		} // 0x000000018BD3416C-0x000000018BD3444C
		static Touch() {
			s_GlobalState = default;
		} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override string ToString() => default; // 0x0000000185DB0BD0-0x0000000185DB0CC0
		public bool Equals(Touch other) => default; // 0x000000018539A290-0x000000018539A3D0
		public override bool Equals(object obj) => default; // 0x000000018BD29DC0-0x000000018BD29EDC
		public override int GetHashCode() => default; // 0x000000018BD29D44-0x000000018BD29DC0
		internal static void AddTouchscreen(Touchscreen screen) {} // 0x000000018BD29EDC-0x000000018BD29FE0
		internal static void RemoveTouchscreen(Touchscreen screen) {} // 0x0000000184FC3F60-0x0000000184FC4190
		internal static void BeginUpdate() {} // 0x000000018BD3566C-0x000000018BD356D0
		private static GlobalState CreateGlobalState() => default; // 0x0000000185492010-0x0000000185492020
		internal static ISavedState SaveAndResetState() => default; // 0x000000018BD354E0-0x000000018BD3564C
	}

	public struct TouchHistory : IReadOnlyList<Touch> // TypeDefIndex: 45334
	{
		// Fields
		private readonly InputStateHistory<TouchState> m_History; // 0x00
		private readonly Finger m_Finger; // 0x08
		private readonly int m_Count; // 0x10
		private readonly int m_StartIndex; // 0x14
		private readonly uint m_Version; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x000000018BD29CFC-0x000000018BD29D44 
		public Touch this[int index] { get => default; } // 0x000000018BD29BF0-0x000000018BD29C50 
	
		// Nested types
		private class Enumerator : IEnumerator<Touch> // TypeDefIndex: 45333
		{
			// Fields
			private readonly TouchHistory m_Owner; // 0x10
			private int m_Index; // 0x30
	
			// Properties
			public Touch Current { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
			object IEnumerator.Current { get => default; } // 0x000000018BD31EA4-0x000000018BD32014 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(TouchHistory owner) {} // 0x000000018BD31E38-0x000000018BD31EA4
	
			// Methods
			public bool MoveNext() => default; // 0x000000018BD31DB0-0x000000018BD31E30
			public void Reset() {} // 0x000000018BD31E30-0x000000018BD31E38
			public void Dispose() {} // 0x000000018BD31CE4-0x000000018BD31DB0
		}
	
		// Constructors
		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1 /* Metadata: 0x0205C05E */, int count = -1 /* Metadata: 0x0205C05F */) : this() {
			m_History = default;
			m_Finger = default;
			m_Count = default;
			m_StartIndex = default;
			m_Version = default;
		} // 0x000000018BD29C98-0x000000018BD29CC4
	
		// Methods
		public IEnumerator<Touch> GetEnumerator() => default; // 0x000000018BD29B14-0x000000018BD29B30
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018346D190-0x000000018346D1A0
		internal void CheckValid() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor // TypeDefIndex: 45335
	{
		// Fields
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
		public Touchscreen simulatedTouchscreen { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public static TouchSimulation instance { get => default; } // 0x000000018BD33B70-0x000000018BD33BA8 
	
		// Constructors
		public TouchSimulation() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static void Enable() {} // 0x000000018BD32290-0x000000018BD323B8
		public static void Disable() {} // 0x000000018BD32224-0x000000018BD32290
		public static void Destroy() {} // 0x000000018BD32158-0x000000018BD32224
		protected void AddPointer(UnityEngine.InputSystem.Pointer pointer) {} // 0x000000018BD32014-0x000000018BD32158
		protected void RemovePointer(UnityEngine.InputSystem.Pointer pointer) {} // 0x000000018BD337B8-0x000000018BD33968
		private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD32B30-0x000000018BD337B8
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018BD323B8-0x000000018BD32484
		protected void OnEnable() {} // 0x000000018BD325AC-0x000000018BD32B30
		protected void OnDisable() {} // 0x000000018BD32484-0x000000018BD325AC
		private void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, InputEventPtr eventPtr = default) {} // 0x000000018BD33968-0x000000018BD33B70
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x0000000185492010-0x0000000185492020
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x0000000185492010-0x0000000185492020
		protected void InstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x0205C060 */) {} // 0x0000000185492010-0x0000000185492020
		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex) {} // 0x0000000185492010-0x0000000185492020
		protected void UninstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x0205C061 */) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.InputSystem.HID
{
	public class HID : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 45318
	{
		// Fields
		internal const string kHIDInterface = "HID"; // Metadata: 0x0205BF1F
		internal const string kHIDNamespace = "HID"; // Metadata: 0x0205BF23
		private bool m_HaveParsedHIDDescriptor; // 0x190
		private HIDDeviceDescriptor m_HIDDescriptor; // 0x198
		private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x00
	
		// Properties
		public static FourCC QueryHIDReportDescriptorDeviceCommandType { get => default; } // 0x0000000185FD88A0-0x0000000185FD88D0 
		public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType { get => default; } // 0x0000000185FD8870-0x0000000185FD88A0 
		public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType { get => default; } // 0x0000000185FD8830-0x0000000185FD8870 
		public HIDDeviceDescriptor hidDescriptor { get => default; } // 0x000000018BD2AB3C-0x000000018BD2AF00 
	
		// Nested types
		[Serializable]
		private class HIDLayoutBuilder // TypeDefIndex: 45305
		{
			// Fields
			public string displayName; // 0x10
			public HIDDeviceDescriptor hidDescriptor; // 0x18
			public string parentLayout; // 0x48
			public System.Type deviceType; // 0x50
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 45304
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Predicate<HIDElementDescriptor> __9__4_0; // 0x08
				public static Predicate<HIDElementDescriptor> __9__4_1; // 0x10
				public static Func<InputControlLayout.ControlItem, string> __9__4_2; // 0x18
	
				// Constructors
				static __c() {} // 0x0000000185FD81D0-0x0000000185FD81E0
				public __c() {} // 0x0000000185FD81E0-0x0000000185FD81F0
	
				// Methods
				internal bool _Build_b__4_0(HIDElementDescriptor element) => default; // 0x0000000185FD81C0-0x0000000185FD81D0
				internal bool _Build_b__4_1(HIDElementDescriptor element) => default; // 0x000000018BD1E32C-0x000000018BD1E454
				internal string _Build_b__4_2(InputControlLayout.ControlItem x) => default; // 0x0000000184950CE0-0x0000000184950FF0
			}
	
			// Constructors
			public HIDLayoutBuilder() {} // 0x000000018BD1E244-0x000000018BD1E2B0
	
			// Methods
			public InputControlLayout Build() => default; // 0x00000001849510A0-0x0000000184951DE0
		}
	
		public enum HIDReportType // TypeDefIndex: 45306
		{
			Unknown = 0,
			Input = 1,
			Output = 2,
			Feature = 3
		}
	
		public enum HIDCollectionType // TypeDefIndex: 45307
		{
			Physical = 0,
			Application = 1,
			Logical = 2,
			Report = 3,
			NamedArray = 4,
			UsageSwitch = 5,
			UsageModifier = 6
		}
	
		public enum HIDElementFlags // TypeDefIndex: 45308
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
		public struct HIDElementDescriptor // TypeDefIndex: 45309
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
			public bool hasNullState { get => default; } // 0x000000018BD1E2B0-0x000000018BD1E32C 
			public bool hasPreferredState { get => default; } // 0x00000001864734FC-0x0000000186473504 
			public bool isArray { get => default; } // 0x0000000185F65CF0-0x0000000185F65D50 
			public bool isNonLinear { get => default; } // 0x000000018BD1D438-0x000000018BD1E244 
			public bool isRelative { get => default; } // 0x0000000185492010-0x0000000185492020 
			public bool isConstant { get => default; } // 0x000000018BD356D0-0x000000018BD35920 
			public bool isWrapping { get => default; } // 0x0000000185492010-0x0000000185492020 
			internal bool isSigned { get => default; } // 0x000000018BD35488-0x000000018BD354A4 
			internal float minFloatValue { get => default; } // 0x000000018BD354A4-0x000000018BD354C0 
			internal float maxFloatValue { get => default; } // 0x000000018BD354C0-0x000000018BD354E0 
	
			// Methods
			public bool Is(UsagePage usagePage, int usage) => default; // 0x000000018BD2C438-0x000000018BD2C444
			internal string DetermineName() => default; // 0x000000018BD2C444-0x000000018BD2C450
			internal string DetermineDisplayName() => default; // 0x000000018BD2C450-0x000000018BD2C45C
			internal bool IsUsableElement() => default; // 0x000000018BD2C464-0x000000018BD2C470
			internal string DetermineLayout() => default; // 0x000000018BD2C470-0x000000018BD2C47C
			internal FourCC DetermineFormat() => default; // 0x000000018BD2C45C-0x000000018BD2C464
			internal InternedString[] DetermineUsages() => default; // 0x000000018BD2C484-0x000000018BD2C490
			internal string DetermineParameters() => default; // 0x000000018BD2C47C-0x000000018BD2C484
			private string DetermineAxisNormalizationParameters() => default; // 0x000000018BD2C4F8-0x000000018BD2C560
			internal string DetermineProcessors() => default; // 0x000000018BD2C490-0x000000018BD2C4F8
			internal PrimitiveValue DetermineDefaultState() => default; // 0x000000018BD2C428-0x000000018BD2C438
			internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder) {} // 0x000000018BD2BF20-0x000000018BD2C0DC
		}
	
		[Serializable]
		public struct HIDCollectionDescriptor // TypeDefIndex: 45310
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
		public struct HIDDeviceDescriptor // TypeDefIndex: 45311
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
			public string ToJson() => default; // 0x000000018BD2BC68-0x000000018BD2BD28
			public static HIDDeviceDescriptor FromJson(string json) => default; // 0x000000018BD2C3FC-0x000000018BD2C428
		}
	
		public struct HIDDeviceDescriptorBuilder // TypeDefIndex: 45312
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
			public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage) {
				this.usagePage = default;
				this.usage = default;
				m_CurrentReportId = default;
				m_CurrentReportType = default;
				m_CurrentReportOffsetInBits = default;
				m_Elements = default;
				m_Collections = default;
				m_InputReportSize = default;
				m_OutputReportSize = default;
				m_FeatureReportSize = default;
			} // 0x000000018BD2BE2C-0x000000018BD2BF20
			public HIDDeviceDescriptorBuilder(GenericDesktop usage) {
				usagePage = default;
				this.usage = default;
				m_CurrentReportId = default;
				m_CurrentReportType = default;
				m_CurrentReportOffsetInBits = default;
				m_Elements = default;
				m_Collections = default;
				m_InputReportSize = default;
				m_OutputReportSize = default;
				m_FeatureReportSize = default;
			} // 0x000000018BD2BD28-0x000000018BD2BE2C
	
			// Methods
			public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1 /* Metadata: 0x0205BF3E */) => default; // 0x000000018BD2C268-0x000000018BD2C3FC
			public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) => default; // 0x000000018BD2C0DC-0x000000018BD2C218
			public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) => default; // 0x000000018BD2B9E8-0x000000018BD2BB48
			public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) => default; // 0x000000018BD2C218-0x000000018BD2C268
			public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) => default; // 0x000000018BD2BB48-0x000000018BD2BC68
			public HIDDeviceDescriptor Finish() => default; // 0x000000018BD2B364-0x000000018BD2B9E8
		}
	
		public enum UsagePage // TypeDefIndex: 45313
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
	
		public enum GenericDesktop // TypeDefIndex: 45314
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
	
		public enum Simulation // TypeDefIndex: 45315
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
	
		public enum Button // TypeDefIndex: 45316
		{
			Undefined = 0,
			Primary = 1,
			Secondary = 2,
			Tertiary = 3
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 45317
		{
			// Fields
			public HIDLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018BD2B300-0x000000018BD2B364
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0() => default; // 0x0000000184033550-0x0000000184037E90
		}
	
		// Constructors
		public HID() {} // 0x0000000185492010-0x0000000185492020
		static HID() {} // 0x000000018BD3564C-0x000000018BD3566C
	
		// Methods
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) => default; // 0x000000018BD2AF00-0x000000018BD2AF50
		internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) => default; // 0x000000018BD2B184-0x000000018BD2B300
		public static string UsagePageToString(UsagePage usagePage) => default; // 0x000000018BD2B008-0x000000018BD2B184
		public static string UsageToString(UsagePage usagePage, int usage) => default; // 0x000000018BD2AF50-0x000000018BD2B008
	}

	internal static class HIDParser // TypeDefIndex: 45323
	{
		// Nested types
		private struct HIDReportData // TypeDefIndex: 45319
		{
			// Fields
			public int reportId; // 0x00
			public HID.HIDReportType reportType; // 0x04
			public int currentBitOffset; // 0x08
	
			// Methods
			public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDReportData> reports) => default; // 0x000000018BD2C968-0x000000018BD2C9FC
		}
	
		private enum HIDItemTypeAndTag // TypeDefIndex: 45320
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
	
		private struct HIDItemStateLocal // TypeDefIndex: 45321
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
			public static void Reset(ref HIDItemStateLocal state) {} // 0x000000018BD2C9FC-0x000000018BD2D70C
			public void SetUsage(int value) {} // 0x000000018BD2D70C-0x000000018BD2D760
			public int GetUsage(int index) => default; // 0x000000018BD2D760-0x000000018BD2D888
		}
	
		private struct HIDItemStateGlobal // TypeDefIndex: 45322
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
			public HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState) => default; // 0x000000018BD2C808-0x000000018BD2C868
			public int GetPhysicalMin() => default; // 0x000000018BD2C868-0x000000018BD2C968
			public int GetPhysicalMax() => default; // 0x000000018BD2C718-0x000000018BD2C808
		}
	
		// Methods
		public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor) => default; // 0x000000018BD2C6A0-0x000000018BD2C718
		public static unsafe bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor) => default; // 0x000000018BD2C600-0x000000018BD2C6A0
		private static unsafe int ReadData(int itemSize, byte* currentPtr, byte* endPtr) => default; // 0x000000018BD2C560-0x000000018BD2C600
	}

	public static class HIDSupport // TypeDefIndex: 45325
	{
		// Fields
		private static HIDPageUsage[] s_SupportedHIDUsages; // 0x00
	
		// Properties
		public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages { get; set; } // 0x0000000184D55080-0x0000000184D55210 0x000000018357CB90-0x000000018357CBA0
	
		// Nested types
		public struct HIDPageUsage // TypeDefIndex: 45324
		{
			// Fields
			public HID.UsagePage page; // 0x00
			public int usage; // 0x04
	
			// Constructors
			public HIDPageUsage(HID.UsagePage page, int usage) {
				this.page = default;
				this.usage = default;
			} // 0x0000000184950FF0-0x00000001849510A0
			public HIDPageUsage(HID.GenericDesktop usage) {
				page = default;
				this.usage = default;
			} // 0x000000018BD2D888-0x000000018BD2DAD0
		}
	
		// Methods
		internal static void Initialize() {} // 0x0000000185FD88D0-0x0000000185FD88E0
	}
}

namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble // TypeDefIndex: 45360
	{
		// Fields
		private float _lowFrequencyMotorSpeed_k__BackingField; // 0x00
		private float _highFrequencyMotorSpeed_k__BackingField; // 0x04
	
		// Properties
		public float lowFrequencyMotorSpeed { get; private set; } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x0000000185FBA160-0x0000000185FBA170
		public float highFrequencyMotorSpeed { get; private set; } // 0x0000000185FBA150-0x0000000185FBA160 0x0000000185FBA180-0x0000000185FBA190
		public bool isRumbling { get => default; } // 0x000000018BD279BC-0x000000018BD279F0 
	
		// Methods
		public void PauseHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD27694-0x000000018BD2776C
		public void ResumeHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD27804-0x000000018BD278A0
		public void ResetHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD2776C-0x000000018BD27804
		public void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency) {} // 0x000000018BD278A0-0x000000018BD279BC
	}

	public interface IDualMotorRumble : IHaptics // TypeDefIndex: 45361
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency);
	}

	public interface IHaptics // TypeDefIndex: 45362
	{
		// Methods
		void PauseHaptics();
		void ResumeHaptics();
		void ResetHaptics();
	}
}

namespace UnityEngine.InputSystem.Interactions
{
	public class HoldInteraction : IInputInteraction // TypeDefIndex: 45545
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TimePressed; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x000000018BCD71A0-0x000000018BCD71FC 
		private float pressPointOrDefault { get => default; } // 0x000000018BCD71FC-0x000000018BCD7248 
	
		// Constructors
		public HoldInteraction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x000000018BCD70B4-0x000000018BCD71A0
		public void Reset() {} // 0x0000000185FD79A0-0x0000000185FD79B0
	}

	public class MultiTapInteraction : IInputInteraction<float> // TypeDefIndex: 45547
	{
		// Fields
		public float tapTime; // 0x10
		public float tapDelay; // 0x14
		public int tapCount; // 0x18
		public float pressPoint; // 0x1C
		private TapPhase m_CurrentTapPhase; // 0x20
		private int m_CurrentTapCount; // 0x24
		private double m_CurrentTapStartTime; // 0x28
		private double m_LastTapReleaseTime; // 0x30
	
		// Properties
		private float tapTimeOrDefault { get => default; } // 0x000000018BCDFD90-0x000000018BCDFDEC 
		internal float tapDelayOrDefault { get => default; } // 0x000000018BCDFD34-0x000000018BCDFD90 
		private float pressPointOrDefault { get => default; } // 0x000000018BCDFCA0-0x000000018BCDFCEC 
		private float releasePointOrDefault { get => default; } // 0x000000018BCDFCEC-0x000000018BCDFD34 
	
		// Nested types
		private enum TapPhase // TypeDefIndex: 45546
		{
			None = 0,
			WaitingForNextRelease = 1,
			WaitingForNextPress = 2
		}
	
		// Constructors
		public MultiTapInteraction() {} // 0x0000000185FB83D0-0x0000000185FB83E0
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x000000018BCDFACC-0x000000018BCDFCA0
		public void Reset() {} // 0x0000000185FD7A70-0x0000000185FD7A80
	}

	public class PressInteraction : IInputInteraction // TypeDefIndex: 45548
	{
		// Fields
		public float pressPoint; // 0x10
		public PressBehavior behavior; // 0x14
		private bool m_WaitingForRelease; // 0x18
	
		// Properties
		private float pressPointOrDefault { get => default; } // 0x000000018BCDFF5C-0x000000018BCDFFA8 
		private float releasePointOrDefault { get => default; } // 0x000000018BCDFFA8-0x000000018BCDFFF0 
	
		// Constructors
		public PressInteraction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x000000018BCDFDEC-0x000000018BCDFF5C
		public void Reset() {} // 0x0000000185FBD8D0-0x0000000185FBD8E0
	}

	public enum PressBehavior // TypeDefIndex: 45549
	{
		PressOnly = 0,
		ReleaseOnly = 1,
		PressAndRelease = 2
	}

	public class SlowTapInteraction : IInputInteraction // TypeDefIndex: 45550
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_SlowTapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x000000018BCE0710-0x000000018BCE076C 
		private float pressPointOrDefault { get => default; } // 0x000000018BCE076C-0x000000018BCE07B8 
	
		// Constructors
		public SlowTapInteraction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x000000018BCE0664-0x000000018BCE0710
		public void Reset() {} // 0x0000000185FD79A0-0x0000000185FD79B0
	}

	public class TapInteraction : IInputInteraction // TypeDefIndex: 45551
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x000000018BCE099C-0x000000018BCE09F8 
		private float pressPointOrDefault { get => default; } // 0x000000018BCE09F8-0x000000018BCE0A44 
		private float releasePointOrDefault { get => default; } // 0x000000018BCE0A44-0x000000018BCE0A8C 
	
		// Constructors
		public TapInteraction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x000000018BCE08C0-0x000000018BCE099C
		public void Reset() {} // 0x0000000185FD79A0-0x0000000185FD79B0
	}
}

namespace UnityEngine.InputSystem.Layouts
{
	public sealed class InputControlAttribute : PropertyAttribute // TypeDefIndex: 45493
	{
		// Fields
		private string _layout_k__BackingField; // 0x10
		private string _variants_k__BackingField; // 0x18
		private string _name_k__BackingField; // 0x20
		private string _format_k__BackingField; // 0x28
		private string _usage_k__BackingField; // 0x30
		private string[] _usages_k__BackingField; // 0x38
		private string _parameters_k__BackingField; // 0x40
		private string _processors_k__BackingField; // 0x48
		private string _alias_k__BackingField; // 0x50
		private string[] _aliases_k__BackingField; // 0x58
		private string _useStateFrom_k__BackingField; // 0x60
		private uint _bit_k__BackingField; // 0x68
		private uint _offset_k__BackingField; // 0x6C
		private uint _sizeInBits_k__BackingField; // 0x70
		private int _arraySize_k__BackingField; // 0x74
		private string _displayName_k__BackingField; // 0x78
		private string _shortDisplayName_k__BackingField; // 0x80
		private bool _noisy_k__BackingField; // 0x88
		private bool _synthetic_k__BackingField; // 0x89
		private bool _dontReset_k__BackingField; // 0x8A
		private object _defaultState_k__BackingField; // 0x90
		private object _minValue_k__BackingField; // 0x98
		private object _maxValue_k__BackingField; // 0xA0
	
		// Properties
		public string layout { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string variants { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string name { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string format { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string usage { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public string[] usages { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public string parameters { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public string processors { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public string alias { get; set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public string[] aliases { get; set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public string useStateFrom { get; set; } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public uint bit { get; set; } // 0x0000000185FB0B00-0x0000000185FB0B10 0x0000000185FB0B10-0x0000000185FB0B20
		public uint offset { get; set; } // 0x0000000185FB09F0-0x0000000185FB0A00 0x0000000185FB0A30-0x0000000185FB0A40
		public uint sizeInBits { get; set; } // 0x0000000185FB0690-0x0000000185FB06A0 0x0000000185FB06C0-0x0000000185FB06D0
		public int arraySize { get; set; } // 0x0000000185FB0830-0x0000000185FB0840 0x0000000185FB0840-0x0000000185FB0850
		public string displayName { get; set; } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
		public string shortDisplayName { get; set; } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public bool noisy { get; set; } // 0x000000018316BFD0-0x000000018316BFE0 0x0000000185FB0AB0-0x0000000185FB0AC0
		public bool synthetic { get; set; } // 0x0000000185FB3080-0x0000000185FB3090 0x0000000185FBCA10-0x0000000185FBCA20
		public bool dontReset { get; set; } // 0x0000000185FB30C0-0x0000000185FB30D0 0x0000000185FD5BF0-0x0000000185FD5C00
		public object defaultState { get; set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x00000001873CBEA8-0x00000001873CBEBC
		public object minValue { get; set; } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public object maxValue { get; set; } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
	
		// Constructors
		public InputControlAttribute() {} // 0x0000000185FD8DC0-0x0000000185FD8DD0
	}

	public delegate string InputDeviceFindControlLayoutDelegate(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // TypeDefIndex: 45494; 0x00000001817E31E0-0x00000001817E3200

	public class InputControlLayout // TypeDefIndex: 45514
	{
		// Fields
		private static InternedString s_DefaultVariant; // 0x00
		public const string VariantSeparator = ";"; // Metadata: 0x0205C239
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
		public static InternedString DefaultVariant { get => default; } // 0x000000018BD382EC-0x000000018BD389C4 
		public InternedString name { get => default; } // 0x000000018BD37B24-0x000000018BD382EC 
		public string displayName { get => default; } // 0x000000018BD45990-0x000000018BD459F4 
		public System.Type type { get => default; } // 0x0000000185492010-0x0000000185492020 
		public InternedString variants { get => default; } // 0x000000018BCE1338-0x000000018BCE135C 
		public FourCC stateFormat { get => default; } // 0x000000018BCE1338-0x000000018BCE135C 
		public int stateSizeInBytes { get => default; } // 0x000000018BCE8190-0x000000018BCE81A4 
		public IEnumerable<InternedString> baseLayouts { get => default; } // 0x000000018BD45938-0x000000018BD4594C 
		public IEnumerable<InternedString> appliedOverrides { get => default; } // 0x000000018BCE81A4-0x000000018BCE81B8 
		public ReadOnlyArray<InternedString> commonUsages { get => default; } // 0x000000018BCE81A4-0x000000018BCE81B8 
		public ReadOnlyArray<ControlItem> controls { get => default; } // 0x0000000184002AD0-0x0000000184002D60 
		public bool updateBeforeRender { get => default; } // 0x0000000184004DA0-0x0000000184004F40 
		public bool isDeviceLayout { get => default; } // 0x0000000184116560-0x0000000184116700 
		public bool isControlLayout { get => default; } // 0x0000000184005890-0x0000000184005970 
		public bool isOverride { get => default; internal set {} } // 0x000000018BD3660C-0x000000018BD367FC 0x000000018BD367FC-0x000000018BD36C20
		public bool isGenericTypeOfDevice { get => default; internal set {} } // 0x000000018BD36348-0x000000018BD363D0 0x000000018BD36498-0x000000018BD36524
		public bool hideInUI { get => default; internal set {} } // 0x000000018BD36098-0x000000018BD36174 0x000000018BD36174-0x000000018BD36348
		public bool isNoisy { get => default; internal set {} } // 0x0000000184113E70-0x0000000184113F50 0x000000018BD36C20-0x000000018BD36CF0
		public bool? canRunInBackground { get => default; internal set {} } // 0x000000018BD365B0-0x000000018BD3660C 0x000000018BD363D0-0x000000018BD36498
		public ControlItem this[string path] { get => default; } // 0x000000018BD36524-0x000000018BD365B0 
		internal static ref Cache cache { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public struct ControlItem // TypeDefIndex: 45496
		{
			// Fields
			private InternedString _name_k__BackingField; // 0x00
			private InternedString _layout_k__BackingField; // 0x10
			private InternedString _variants_k__BackingField; // 0x20
			private string _useStateFrom_k__BackingField; // 0x30
			private string _displayName_k__BackingField; // 0x38
			private string _shortDisplayName_k__BackingField; // 0x40
			private ReadOnlyArray<InternedString> _usages_k__BackingField; // 0x48
			private ReadOnlyArray<InternedString> _aliases_k__BackingField; // 0x58
			private ReadOnlyArray<NamedValue> _parameters_k__BackingField; // 0x68
			private ReadOnlyArray<NameAndParameters> _processors_k__BackingField; // 0x78
			private uint _offset_k__BackingField; // 0x88
			private uint _bit_k__BackingField; // 0x8C
			private uint _sizeInBits_k__BackingField; // 0x90
			private FourCC _format_k__BackingField; // 0x94
			private Flags _flags_k__BackingField; // 0x98
			private int _arraySize_k__BackingField; // 0x9C
			private PrimitiveValue _defaultState_k__BackingField; // 0xA0
			private PrimitiveValue _minValue_k__BackingField; // 0xB0
			private PrimitiveValue _maxValue_k__BackingField; // 0xC0
	
			// Properties
			public InternedString name { get; internal set; } // 0x000000018BD3E388-0x000000018BD3E3E4 0x00000001834A7540-0x00000001834A7550
			public InternedString layout { get; internal set; } // 0x000000018BD3E770-0x000000018BD3E79C 0x00000001813B31A0-0x00000001813B31B0
			public InternedString variants { get; internal set; } // 0x0000000185FBB610-0x0000000185FBB620 0x00000001813E5E30-0x00000001813E5E40
			public string useStateFrom { get; internal set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x000000018BD3E5C4-0x000000018BD3E614
			public string displayName { get; internal set; } // 0x000000018BD3E574-0x000000018BD3E5C4 0x000000018BD3E6C0-0x000000018BD3E718
			public string shortDisplayName { get; internal set; } // 0x000000018BD3E718-0x000000018BD3E770 0x000000018BD3E858-0x000000018BD3E890
			public ReadOnlyArray<InternedString> usages { get; internal set; } // 0x000000018BD3E7BC-0x000000018BD3E834 0x000000018BD3E7A8-0x000000018BD3E7BC
			public ReadOnlyArray<InternedString> aliases { get; internal set; } // 0x000000018BD3E84C-0x000000018BD3E858 0x000000018BD3E980-0x000000018BD3E9A0
			public ReadOnlyArray<NamedValue> parameters { get; internal set; } // 0x000000018BD3E834-0x000000018BD3E840 0x000000018BD3E940-0x000000018BD3E960
			public ReadOnlyArray<NameAndParameters> processors { get; internal set; } // 0x000000018BD3E79C-0x000000018BD3E7A8 0x000000018BD3E920-0x000000018BD3E940
			public uint offset { get; internal set; } // 0x000000018BD3E840-0x000000018BD3E84C 0x000000018BD3E960-0x000000018BD3E980
			public uint bit { get; internal set; } // 0x000000018BD3E664-0x000000018BD3E6C0 0x000000018BD3E890-0x000000018BD3E920
			public uint sizeInBits { get; internal set; } // 0x000000018BD3E3E4-0x000000018BD3E574 0x000000018BD3A954-0x000000018BD3AC40
			public FourCC format { get; internal set; } // 0x000000018BD3A578-0x000000018BD3A954 0x000000018BD3B130-0x000000018BD3B1A4
			private Flags flags { get; set; } // 0x000000018BD3ACDC-0x000000018BD3B130 0x000000018BD3E0DC-0x000000018BD3E180
			public int arraySize { get; internal set; } // 0x000000018BD3AC40-0x000000018BD3ACDC 0x000000018BD3E338-0x000000018BD3E388
			public PrimitiveValue defaultState { get; internal set; } // 0x000000018BD39804-0x000000018BD39878 0x000000018BD39054-0x000000018BD390D0
			public PrimitiveValue minValue { get; internal set; } // 0x000000018BD39788-0x000000018BD39804 0x000000018BD392E4-0x000000018BD39788
			public PrimitiveValue maxValue { get; internal set; } // 0x000000018BD390D0-0x000000018BD392E4 0x000000018BD398D0-0x000000018BD3A1F4
			public bool isModifyingExistingControl { get => default; internal set {} } // 0x000000018BD3B1A4-0x000000018BD3B384 0x000000018BD3B384-0x000000018BD3E0DC
			public bool isNoisy { get => default; internal set {} } // 0x000000018BD3A1F4-0x000000018BD3A578 0x000000018BD3E1F4-0x000000018BD3E250
			public bool isSynthetic { get => default; internal set {} } // 0x000000018BD3E250-0x000000018BD3E338 0x0000000184D53FA0-0x0000000184D54120
			public bool dontReset { get => default; internal set {} } // 0x000000018BD3E614-0x000000018BD3E664 0x000000018BD39878-0x000000018BD398D0
			public bool isFirstDefinedInThisLayout { get => default; internal set {} } // 0x0000000185F55120-0x0000000185F551A0 0x000000018BD3E180-0x000000018BD3E1F4
			public bool isArray { get => default; } // 0x0000000181D61820-0x0000000181D61830 
	
			// Nested types
			private enum Flags // TypeDefIndex: 45495
			{
				isModifyingExistingControl = 1,
				IsNoisy = 2,
				IsSynthetic = 4,
				IsFirstDefinedInThisLayout = 8,
				DontReset = 16
			}
	
			// Methods
			public ControlItem Merge(ControlItem other) => default; // 0x0000000187C196C0-0x0000000187C196CC
		}
	
		public class Builder // TypeDefIndex: 45499
		{
			// Fields
			private string _name_k__BackingField; // 0x10
			private string _displayName_k__BackingField; // 0x18
			private System.Type _type_k__BackingField; // 0x20
			private FourCC _stateFormat_k__BackingField; // 0x28
			private int _stateSizeInBytes_k__BackingField; // 0x2C
			private string m_ExtendsLayout; // 0x30
			private bool? _updateBeforeRender_k__BackingField; // 0x38
			private int m_ControlCount; // 0x3C
			private ControlItem[] m_Controls; // 0x40
	
			// Properties
			public string name { get; set; } // 0x00000001834A0D50-0x00000001834A0D60 0x00000001834A2260-0x00000001834A2270
			public string displayName { get; set; } // 0x0000000181A73EA0-0x0000000181A73EB0 0x0000000181A73EC0-0x0000000181A73ED0
			public System.Type type { get; set; } // 0x00000001834A0D40-0x00000001834A0D50 0x00000001834A2250-0x00000001834A2260
			public FourCC stateFormat { get; set; } // 0x00000001834A0D60-0x00000001834A0D70 0x00000001834A2270-0x00000001834A2280
			public int stateSizeInBytes { get; set; } // 0x0000000185FCCCE0-0x0000000185FCCCF0 0x0000000185FCCD70-0x0000000185FCCD80
			public string extendsLayout { get => default; set {} } // 0x0000000185FCCCB0-0x0000000185FCCCC0 0x0000000185FCCD30-0x0000000185FCCD40
			public bool? updateBeforeRender { get; set; } // 0x0000000185FCCCA0-0x0000000185FCCCB0 0x0000000185FCCD20-0x0000000185FCCD30
			public ReadOnlyArray<ControlItem> controls { get => default; } // 0x000000018BD38D4C-0x000000018BD38D58 
	
			// Nested types
			public struct ControlBuilder // TypeDefIndex: 45498
			{
				// Fields
				internal Builder builder; // 0x00
				internal int index; // 0x08
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 45497
				{
					// Fields
					public static readonly __c __9; // 0x00
					public static Func<string, InternedString> __9__14_0; // 0x08
	
					// Constructors
					static __c() {} // 0x00000001834A7540-0x00000001834A7550
					public __c() {} // 0x0000000184AF8BE0-0x0000000184AF8BF0
	
					// Methods
					internal InternedString _WithUsages_b__14_0(string x) => default; // 0x0000000185FB6120-0x0000000185FB6130
				}
	
				// Methods
				public ControlBuilder WithDisplayName(string displayName) => default; // 0x0000000186474FF8-0x0000000186475008
				public ControlBuilder WithLayout(string layout) => default; // 0x00000001813B51D0-0x00000001813B51E0
				public ControlBuilder WithFormat(FourCC format) => default; // 0x00000001864721F0-0x0000000186472200
				public ControlBuilder WithFormat(string format) => default; // 0x00000001813ECBC0-0x00000001813ECBD0
				public ControlBuilder WithByteOffset(uint offset) => default; // 0x0000000185A16440-0x0000000185A16450
				public ControlBuilder WithBitOffset(uint bit) => default; // 0x00000001813FF010-0x00000001813FF020
				public ControlBuilder IsSynthetic(bool value) => default; // 0x0000000185F05C80-0x0000000185F05C90
				public ControlBuilder IsNoisy(bool value) => default; // 0x0000000185FBB8A0-0x0000000185FBB8B0
				public ControlBuilder DontReset(bool value) => default; // 0x0000000187C5FE34-0x0000000187C5FE44
				public ControlBuilder WithSizeInBits(uint sizeInBits) => default; // 0x0000000185FB1D60-0x0000000185FB1D70
				public ControlBuilder WithRange(float minValue, float maxValue) => default; // 0x0000000187D38F50-0x0000000187D38F60
				public ControlBuilder WithUsages(InternedString[] usages) => default; // 0x0000000185FBECA0-0x0000000185FBECB0
				public ControlBuilder WithUsages(IEnumerable<string> usages) => default; // 0x000000018BD38E10-0x000000018BD38E20
				public ControlBuilder WithUsages(string[] usages) => default; // 0x0000000185FB9E60-0x0000000185FB9E70
				public ControlBuilder WithParameters(string parameters) => default; // 0x0000000187AF0B6C-0x0000000187AF0B7C
				public ControlBuilder WithProcessors(string processors) => default; // 0x00000001834A1F30-0x00000001834A1F40
				public ControlBuilder WithDefaultState(PrimitiveValue value) => default; // 0x00000001834A2280-0x00000001834A2290
				public ControlBuilder UsingStateFrom(string path) => default; // 0x000000018349D720-0x000000018349D730
				public ControlBuilder AsArrayOfControlsWithSize(int arraySize) => default; // 0x00000001834A21B0-0x00000001834A21C0
			}
	
			// Constructors
			public Builder() {} // 0x00000001876E6608-0x00000001876E6614
	
			// Methods
			public ControlBuilder AddControl(string name) => default; // 0x000000018BD38DB0-0x000000018BD38DD0
			public Builder WithName(string name) => default; // 0x000000018BD38D58-0x000000018BD38D64
			public Builder WithDisplayName(string displayName) => default; // 0x000000018BD38DD0-0x000000018BD38DF0
			public Builder WithType<T>()
				where T : InputControl => default; // 0x000000018BD38D64-0x000000018BD38D70
			public Builder WithFormat(FourCC format) => default; // 0x000000018BD38DF0-0x000000018BD38E10
			public Builder WithFormat(string format) => default; // 0x000000018BD38D34-0x000000018BD38D40
			public Builder WithSizeInBytes(int sizeInBytes) => default; // 0x000000018BD38D70-0x000000018BD38D90
			public Builder Extend(string baseLayoutName) => default; // 0x000000018BD38D40-0x000000018BD38D4C
			public InputControlLayout Build() => default; // 0x000000018BD38D90-0x000000018BD38DB0
		}
	
		private enum Flags // TypeDefIndex: 45500
		{
			IsGenericTypeOfDevice = 1,
			HideInUI = 2,
			IsOverride = 4,
			CanRunInBackground = 8,
			CanRunInBackgroundIsSet = 16,
			IsNoisy = 32
		}
	
		[Serializable]
		internal struct LayoutJsonNameAndDescriptorOnly // TypeDefIndex: 45501
		{
			// Fields
			public string name; // 0x00
			public string extend; // 0x08
			public string[] extendMultiple; // 0x10
			public InputDeviceMatcher.MatcherJson device; // 0x18
		}
	
		[Serializable]
		private struct LayoutJson // TypeDefIndex: 45503
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
			private sealed class __c // TypeDefIndex: 45502
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<string, InternedString> __9__14_0; // 0x08
				public static Func<InternedString, string> __9__15_0; // 0x10
				public static Func<InternedString, string> __9__15_1; // 0x18
	
				// Constructors
				static __c() {} // 0x000000018BD389C4-0x000000018BD38D34
				public __c() {} // 0x000000018346D130-0x000000018346D140
	
				// Methods
				internal InternedString _ToLayout_b__14_0(string x) => default; // 0x0000000184096E30-0x0000000184096EF0
				internal string _FromLayout_b__15_0(InternedString x) => default; // 0x0000000181377E40-0x0000000181377E50
				internal string _FromLayout_b__15_1(InternedString x) => default; // 0x0000000184088E70-0x0000000184088E80
			}
	
			// Methods
			public InputControlLayout ToLayout() => default; // 0x00000001813B31A0-0x00000001813B31B0
			public static LayoutJson FromLayout(InputControlLayout layout) => default; // 0x000000018646EE40-0x000000018646EE50
		}
	
		[Serializable]
		private class ControlItemJson // TypeDefIndex: 45505
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
			private sealed class __c // TypeDefIndex: 45504
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
				static __c() {} // 0x0000000181C9AC80-0x0000000181C9AC90
				public __c() {} // 0x0000000181C9A5C0-0x0000000181C9A5D0
	
				// Methods
				internal InternedString _ToLayout_b__24_0(string x) => default; // 0x0000000185FB0630-0x0000000185FB0640
				internal InternedString _ToLayout_b__24_1(string x) => default; // 0x0000000185FB0640-0x0000000185FB0650
				internal string _FromControlItems_b__25_0(NamedValue x) => default; // 0x00000001813B51D0-0x00000001813B51E0
				internal string _FromControlItems_b__25_1(NameAndParameters x) => default; // 0x000000018BD35FA4-0x000000018BD35FC4
				internal string _FromControlItems_b__25_2(InternedString x) => default; // 0x0000000185FD8DA0-0x0000000185FD8DB0
				internal string _FromControlItems_b__25_3(InternedString x) => default; // 0x0000000185FD4BA0-0x0000000185FD4BB0
			}
	
			// Constructors
			public ControlItemJson() {} // 0x000000018BD35F44-0x000000018BD35FA4
	
			// Methods
			public ControlItem ToLayout() => default; // 0x000000018BD35B14-0x000000018BD35CF0
			public static ControlItemJson[] FromControlItems(ControlItem[] items) => default; // 0x00000001878FE900-0x00000001878FE91C
		}
	
		internal struct Collection // TypeDefIndex: 45509
		{
			// Fields
			public const float kBaseScoreForNonGeneratedLayouts = 1f; // Metadata: 0x0205C247
			public Dictionary<InternedString, System.Type> layoutTypes; // 0x00
			public Dictionary<InternedString, string> layoutStrings; // 0x08
			public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders; // 0x10
			public Dictionary<InternedString, InternedString> baseLayoutTable; // 0x18
			public Dictionary<InternedString, InternedString[]> layoutOverrides; // 0x20
			public HashSet<InternedString> layoutOverrideNames; // 0x28
			public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; // 0x30
			public List<LayoutMatcher> layoutMatchers; // 0x38
	
			// Nested types
			public struct LayoutMatcher // TypeDefIndex: 45506
			{
				// Fields
				public InternedString layoutName; // 0x00
				public InputDeviceMatcher deviceMatcher; // 0x10
			}
	
			public struct PrecompiledLayout // TypeDefIndex: 45507
			{
				// Fields
				public Func<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x00
				public string metadata; // 0x08
			}
	
			private sealed class _GetBaseLayouts_d__24 : IEnumerable<InternedString>, IEnumerator<InternedString> // TypeDefIndex: 45508
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
				InternedString IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current { get => default; } // 0x000000018BD35F14-0x000000018BD35F44 
				object IEnumerator.Current { get => default; } // 0x000000018BD35EF8-0x000000018BD35F14 
	
				// Constructors
				public _GetBaseLayouts_d__24() {} // Dummy constructor
				public _GetBaseLayouts_d__24(int __1__state) {} // 0x00000001878FE91C-0x00000001878FE938
	
				// Methods
				void IDisposable.Dispose() {}
				private bool MoveNext() => default; // 0x0000000185FD8D80-0x0000000185FD8D90
				void IEnumerator.Reset() {} // 0x0000000185FD8D90-0x0000000185FD8DA0
				IEnumerator<InternedString> IEnumerable<InternedString>.GetEnumerator() => default; // 0x000000018BD35CF0-0x000000018BD35EF8
				IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			public void Allocate() {} // 0x000000018BD372E8-0x000000018BD37348
			public InternedString TryFindLayoutForType(System.Type layoutType) => default; // 0x000000018BD373F4-0x000000018BD374FC
			public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) => default; // 0x000000018BD3739C-0x000000018BD373F4
			public bool HasLayout(InternedString name) => default; // 0x000000018BD37348-0x000000018BD3739C
			private InputControlLayout TryLoadLayoutInternal(InternedString name) => default; // 0x000000018BD37230-0x000000018BD37288
			public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null) => default; // 0x000000018BD371D8-0x000000018BD37230
			public InternedString GetBaseLayoutName(InternedString layoutName) => default; // 0x000000018BD370F8-0x000000018BD37164
			public InternedString GetRootLayoutName(InternedString layoutName) => default; // 0x000000018BD3708C-0x000000018BD370F8
			public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance) {
				distance = default;
				return default;
			} // 0x000000018BD37020-0x000000018BD3708C
			public InternedString FindLayoutThatIntroducesControl(InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache) => default; // 0x000000018BD37770-0x000000018BD377C8
			public System.Type GetControlTypeForLayout(InternedString layoutName) => default; // 0x000000018BD376B0-0x000000018BD37770
			public bool ValueTypeIsAssignableFrom(InternedString layoutName, System.Type valueType) => default; // 0x000000018BD377C8-0x000000018BD379A4
			public bool IsGeneratedLayout(InternedString layout) => default; // 0x000000018BD379A4-0x000000018BD37AFC
			public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true /* Metadata: 0x0205C246 */) => default; // 0x000000018BD37AFC-0x000000018BD37B24
			public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) => default; // 0x000000018BD374FC-0x000000018BD375C8
			public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) {} // 0x000000018BD375C8-0x000000018BD376B0
		}
	
		public class LayoutNotFoundException : Exception // TypeDefIndex: 45510
		{
			// Fields
			private readonly string _layout_k__BackingField; // 0x90
	
			// Properties
			public string layout { get; } // 0x000000018BD37288-0x000000018BD372E8 
	
			// Constructors
			public LayoutNotFoundException() {} // 0x000000018BD37164-0x000000018BD371D8
			public LayoutNotFoundException(string name, string message) {} // 0x000000018BD36FC8-0x000000018BD37020
			public LayoutNotFoundException(string name) {} // 0x000000018BD45A58-0x000000018BD45ABC
			public LayoutNotFoundException(string message, Exception innerException) {} // 0x0000000185492010-0x0000000185492020
			protected LayoutNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x000000018BCE1338-0x000000018BCE135C
		}
	
		internal struct Cache // TypeDefIndex: 45511
		{
			// Fields
			public Dictionary<InternedString, InputControlLayout> table; // 0x00
	
			// Methods
			public void Clear() {} // 0x000000018BD42284-0x000000018BD42C08
			public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true /* Metadata: 0x0205C24B */) => default; // 0x000000018BD41EC8-0x000000018BD42284
		}
	
		internal struct CacheRefInstance : IDisposable // TypeDefIndex: 45512
		{
			// Fields
			public bool valid; // 0x00
	
			// Methods
			public void Dispose() {} // 0x000000018BD459F4-0x000000018BD45A58
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45513
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, InternedString> __9__52_0; // 0x08
			public static Func<string, InternedString> __9__75_0; // 0x10
			public static Func<string, InternedString> __9__75_1; // 0x18
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x000000018BCE1338-0x000000018BCE135C
	
			// Methods
			internal InternedString _FromType_b__52_0(string x) => default; // 0x000000018BCE81A4-0x000000018BCE81B8
			internal InternedString _CreateControlItemFromMember_b__75_0(string x) => default; // 0x000000018BCE81A4-0x000000018BCE81B8
			internal InternedString _CreateControlItemFromMember_b__75_1(string x) => default; // 0x0000000185FD8DB0-0x0000000185FD8DC0
		}
	
		// Constructors
		public InputControlLayout() {} // Dummy constructor
		private InputControlLayout(string name, System.Type type) {} // 0x000000018BCE12F0-0x000000018BCE1338
		static InputControlLayout() {} // 0x000000018BCE1338-0x000000018BCE135C
	
		// Methods
		public ControlItem? FindControl(InternedString path) => default; // 0x0000000184116700-0x00000001841168A0
		public ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex) {
			arrayIndex = default;
			return default;
		} // 0x00000001853410F0-0x0000000185341110
		public System.Type GetValueType() => default; // 0x0000000185492010-0x0000000185492020
		public static InputControlLayout FromType(string name, System.Type type) => default; // 0x000000018BCE1114-0x000000018BCE11C8
		public string ToJson() => default; // 0x0000000185FB30D0-0x0000000185FB30E0
		public static InputControlLayout FromJson(string json) => default; // 0x000000018BCE12A4-0x000000018BCE12F0
		private static void AddControlItems(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x000000018BCE11C8-0x000000018BCE129C
		private static void AddControlItemsFromFields(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x000000018BCE129C-0x000000018BCE12A4
		private static void AddControlItemsFromProperties(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x0000000181B5FFD0-0x0000000181B5FFE0
		private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName) {} // 0x000000018BCDF5EC-0x000000018BCDF638
		private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems) {} // 0x000000018BCDF73C-0x000000018BCDF7AC
		private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) => default; // 0x000000018BCDF638-0x000000018BCDF6DC
		private static string InferLayoutFromValueType(System.Type type) => default; // 0x000000018BCDF6DC-0x000000018BCDF73C
		public void MergeLayout(InputControlLayout other) {} // 0x000000018BCDF7AC-0x000000018BCDF818
		private static Dictionary<string, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<string> variants = null) => default; // 0x000000018646D678-0x000000018646D684
		internal static bool VariantsMatch(InternedString expected, InternedString actual) => default; // 0x000000018BCD5F70-0x000000018BCD60B4
		internal static bool VariantsMatch(string expected, string actual) => default; // 0x000000018BCD5EDC-0x000000018BCD5F70
		internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher) {
			name = default;
			baseLayouts = default;
			deviceMatcher = default;
		} // 0x000000018BCE135C-0x000000018BCE13C0
		internal static CacheRefInstance CacheRef() => default; // 0x000000018BCE1338-0x000000018BCE135C
		private bool _MergeLayout_b__77_0(ControlItem x) => default; // 0x000000018BCE1338-0x000000018BCE135C
	}

	public sealed class InputControlLayoutAttribute : Attribute // TypeDefIndex: 45515
	{
		// Fields
		private System.Type _stateType_k__BackingField; // 0x10
		private string _stateFormat_k__BackingField; // 0x18
		private string[] _commonUsages_k__BackingField; // 0x20
		private string _variants_k__BackingField; // 0x28
		private bool _isNoisy_k__BackingField; // 0x30
		internal bool? canRunInBackgroundInternal; // 0x31
		internal bool? updateBeforeRenderInternal; // 0x33
		private bool _isGenericTypeOfDevice_k__BackingField; // 0x35
		private string _displayName_k__BackingField; // 0x38
		private string _description_k__BackingField; // 0x40
		private bool _hideInUI_k__BackingField; // 0x48
	
		// Properties
		public System.Type stateType { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string stateFormat { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string[] commonUsages { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string variants { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public bool isNoisy { get; set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public bool canRunInBackground { get => default; set {} } // 0x000000018BCD837C-0x000000018BCD83B8 0x000000018BCD83F4-0x000000018BCD8440
		public bool updateBeforeRender { get => default; set {} } // 0x000000018BCD83B8-0x000000018BCD83F4 0x000000018BCD8440-0x000000018BCD848C
		public bool isGenericTypeOfDevice { get; set; } // 0x0000000185FB0B80-0x0000000185FB0B90 0x0000000185FB0BA0-0x0000000185FB0BB0
		public string displayName { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public string description { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public bool hideInUI { get; set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
	
		// Constructors
		public InputControlLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct InputDeviceBuilder : IDisposable // TypeDefIndex: 45517
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x00
		private InputControlLayout.CacheRefInstance m_LayoutCacheRef; // 0x08
		private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x10
		private List<uint> m_StateOffsetToControlMap; // 0x18
		private StringBuilder m_StringBuilder; // 0x20
		private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; // Metadata: 0x0205C24C
		private static InputDeviceBuilder s_Instance; // 0x00
		private static int s_InstanceRef; // 0x28
	
		// Properties
		internal static ref InputDeviceBuilder instance { get => default; } // 0x000000018BCDC788-0x000000018BCDC7C8 
	
		// Nested types
		internal struct RefInstance : IDisposable // TypeDefIndex: 45516
		{
			// Methods
			public void Dispose() {} // 0x000000018BCDCB18-0x000000018BCDCC84
		}
	
		// Methods
		public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = default) {} // 0x000000018BCDAD18-0x000000018BCDB0E0
		public UnityEngine.InputSystem.InputDevice Finish() => default; // 0x000000018BCDA5BC-0x000000018BCDA5C8
		public void Dispose() {} // 0x000000018BCDC7C8-0x000000018BCDC830
		private void Reset() {} // 0x000000018BCDC708-0x000000018BCDC788
		private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) => default; // 0x000000018BCDC054-0x000000018BCDC708
		private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) => default; // 0x000000018BCD8E70-0x000000018BCD95A4
		private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) {} // 0x000000018BCD8554-0x000000018BCD8E70
		private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null) => default; // 0x000000018BCDB608-0x000000018BCDB940
		private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem) {} // 0x000000018BCD9CB0-0x000000018BCD9D28
		private string ChildControlOverridePath(InputControl parent, InternedString controlName) => default; // 0x000000018BCD848C-0x000000018BCD8554
		private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) {} // 0x000000018BCDB940-0x000000018BCDBD58
		private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) => default; // 0x000000018BCD9AE0-0x000000018BCD9CB0
		private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout) {} // 0x000000018BCDCC84-0x000000018BCDCCE8
		private static void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, InputControl exceptControl) {} // 0x000000018BCDC830-0x000000018BCDCA88
		private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) {} // 0x000000018BCD9830-0x000000018BCD98CC
		private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) {} // 0x000000018BCD98CC-0x000000018BCD9AE0
		private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName) {} // 0x000000018BCDCA88-0x000000018BCDCB18
		private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem) {} // 0x000000018BCDACC8-0x000000018BCDAD18
		private static InputControlLayout FindOrLoadLayout(string name) => default; // 0x000000018BCD9D28-0x000000018BCDA5BC
		private static void ComputeStateLayout(InputControl control) {} // 0x000000018BCDAA2C-0x000000018BCDACC8
		private void FinalizeControlHierarchy() {} // 0x000000018BCDA5C8-0x000000018BCDAA2C
		private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) {} // 0x000000018BCDBD58-0x000000018BCDC054
		private void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset) {} // 0x000000018BCDB0E0-0x000000018BCDB540
		private ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset) => default; // 0x000000018BCD96D4-0x000000018BCD9830
		private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) {} // 0x000000018BCD95A4-0x000000018BCD96D4
		private void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right) {} // 0x000000018BCDB540-0x000000018BCDB608
		private ushort GetControlIndex(InputControl control) => default; // 0x000000018BCDCCE8-0x000000018BCDCD1C
		internal static RefInstance Ref() => default; // 0x000000018BCE05D0-0x000000018BCE0664
	}

	[Serializable]
	public struct InputDeviceDescription : IEquatable<InputDeviceDescription> // TypeDefIndex: 45519
	{
		// Fields
		private string m_InterfaceName; // 0x00
		private string m_DeviceClass; // 0x08
		private string m_Manufacturer; // 0x10
		private string m_Product; // 0x18
		private string m_Serial; // 0x20
		private string m_Version; // 0x28
		private string m_Capabilities; // 0x30
	
		// Properties
		public string interfaceName { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public string deviceClass { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public string manufacturer { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string product { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string serial { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string version { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string capabilities { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public bool empty { get => default; } // 0x000000018BCDD3A0-0x000000018BCDD408 
	
		// Nested types
		private struct DeviceDescriptionJson // TypeDefIndex: 45518
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
		public override string ToString() => default; // 0x000000018BCDD18C-0x000000018BCDD3A0
		public bool Equals(InputDeviceDescription other) => default; // 0x000000018BCDCE74-0x000000018BCDCF6C
		public override bool Equals(object obj) => default; // 0x000000018BCDCDE8-0x000000018BCDCE74
		public override int GetHashCode() => default; // 0x000000018BCDCF6C-0x000000018BCDD080
		public static bool operator ==(InputDeviceDescription left, InputDeviceDescription right) => default; // 0x000000018BCDD408-0x000000018BCDD444
		public static bool operator !=(InputDeviceDescription left, InputDeviceDescription right) => default; // 0x000000018BCDD444-0x000000018BCDD480
		public string ToJson() => default; // 0x000000018BCDD080-0x000000018BCDD18C
		public static InputDeviceDescription FromJson(string json) => default; // 0x0000000184114770-0x0000000184114880
		internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonParser.JsonString propertyValue, string deviceDescriptor) => default; // 0x000000018BCDCD1C-0x000000018BCDCDE8
	}

	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher> // TypeDefIndex: 45524
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
		public bool empty { get => default; } // 0x000000018BCDD624-0x000000018BCDD69C 
		public IEnumerable<KeyValuePair<string, object>> patterns { get => default; } // 0x000000018BCDD4F4-0x000000018BCDD624 
	
		// Nested types
		[Serializable]
		internal struct MatcherJson // TypeDefIndex: 45521
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
			public struct Capability // TypeDefIndex: 45520
			{
				// Fields
				public string path; // 0x00
				public string value; // 0x08
			}
	
			// Methods
			public static MatcherJson FromMatcher(InputDeviceMatcher matcher) => default; // 0x000000018402E460-0x000000018402E470
			public InputDeviceMatcher ToMatcher() => default; // 0x000000018BCDD8EC-0x000000018BCDD95C
		}
	
		private sealed class _get_patterns_d__4 : IEnumerable<KeyValuePair<string, object>>, IEnumerator<KeyValuePair<string, object>> // TypeDefIndex: 45522
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
			KeyValuePair<string, object> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get => default; } // 0x0000000184D553B0-0x0000000184D55440 
			object IEnumerator.Current { get => default; } // 0x000000018BCDD868-0x000000018BCDD8EC 
	
			// Constructors
			public _get_patterns_d__4() {} // Dummy constructor
			public _get_patterns_d__4(int __1__state) {} // 0x0000000184D57310-0x0000000184D573B0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCDD7E4-0x000000018BCDD868
			private bool MoveNext() => default; // 0x0000000184D55440-0x0000000184D554E0
			void IEnumerator.Reset() {} // 0x0000000184D56D40-0x0000000184D56DE0
			IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184D57BF0-0x0000000184D57E50
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45523
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<char, bool> __9__12_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184116A60-0x0000000184116EF0
			public __c() {} // 0x0000000184116EF0-0x0000000184116F90
	
			// Methods
			internal bool _With_b__12_0(char ch) => default; // 0x0000000184115250-0x00000001841152C0
		}
	
		// Constructors
		static InputDeviceMatcher() {
			kInterfaceKey = default;
			kDeviceClassKey = default;
			kManufacturerKey = default;
			kManufacturerContainsKey = default;
			kProductKey = default;
			kVersionKey = default;
		} // 0x00000001855B4EE0-0x00000001855B4F60
	
		// Methods
		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true /* Metadata: 0x0205C24D */) => default; // 0x000000018BCDD69C-0x000000018BCDD7E4
		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true /* Metadata: 0x0205C24E */) => default; // 0x0000000184116900-0x0000000184116A40
		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true /* Metadata: 0x0205C24F */) => default; // 0x000000018BCDD480-0x000000018BCDD4F4
		public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) => default; // 0x00000001841168A0-0x0000000184116900
		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true /* Metadata: 0x0205C250 */) => default; // 0x000000018BCDD95C-0x000000018BCDD9B0
		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true /* Metadata: 0x0205C251 */) => default; // 0x0000000189289CE0-0x0000000189289D04
		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value) => default; // 0x0000000185BAECE0-0x0000000185BAEF10
		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true /* Metadata: 0x0205C252 */) => default; // 0x000000018BCDF818-0x000000018BCDFACC
		public float MatchPercentage(InputDeviceDescription deviceDescription) => default; // 0x0000000184D54120-0x0000000184D54230
		private static bool MatchSingleProperty(object pattern, string value) => default; // 0x00000001853410F0-0x0000000185341110
		private static bool MatchSinglePropertyContains(object pattern, string value) => default; // 0x0000000185492010-0x0000000185492020
		private static int GetNumPropertiesIn(InputDeviceDescription description) => default; // 0x000000018BCE13C0-0x000000018BCE14D0
		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) => default; // 0x0000000185FB30D0-0x0000000185FB30E0
		public override string ToString() => default; // 0x000000018BCE156C-0x000000018BCE15B8
		public bool Equals(InputDeviceMatcher other) => default; // 0x000000018BCE15B8-0x000000018BCE1600
		public override bool Equals(object obj) => default; // 0x000000018BCE14D0-0x000000018BCE1564
		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right) => default; // 0x000000018BCE1564-0x000000018BCE156C
		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right) => default; // 0x0000000185F71CB0-0x0000000185F71D10
		public override int GetHashCode() => default; // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.InputSystem.LowLevel
{
	public struct DisableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 45363
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0205C06F
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD84B0-0x0000000185FD84C0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD84B0-0x0000000185FD84C0 
	
		// Methods
		public static DisableDeviceCommand Create() => default; // 0x0000000185FD8490-0x0000000185FD84B0
	}

	public struct EnableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 45364
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0205C070
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8780-0x0000000185FD8790 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8780-0x0000000185FD8790 
	
		// Methods
		public static EnableDeviceCommand Create() => default; // 0x0000000185FD8760-0x0000000185FD8780
	}

	public struct EnableIMECompositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 45365
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0205C071
		public InputDeviceCommand baseCommand; // 0x00
		private byte m_ImeEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8790-0x0000000185FD87A0 
		public bool imeEnabled { get => default; } // 0x000000018BD2965C-0x000000018BD29664 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8790-0x0000000185FD87A0 
	
		// Methods
		public static EnableIMECompositionCommand Create(bool enabled) => default; // 0x000000018BD29634-0x000000018BD2965C
	}

	public interface IInputDeviceCommandInfo // TypeDefIndex: 45366
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo // TypeDefIndex: 45368
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0205C072
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8910-0x0000000185FD8920 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8910-0x0000000185FD8920 
	
		// Nested types
		public enum Result // TypeDefIndex: 45367
		{
			ErrorAlreadyInProgress = -2,
			ErrorNotSupported = -1,
			SuccessfullyInitiated = 1
		}
	
		// Methods
		public static InitiateUserAccountPairingCommand Create() => default; // 0x0000000185FD88F0-0x0000000185FD8910
	}

	public unsafe delegate long? InputDeviceCommandDelegate(UnityEngine.InputSystem.InputDevice device, InputDeviceCommand* command); // TypeDefIndex: 45369; 0x00000001836B3FA0-0x00000001836B3FE0

	public delegate long InputDeviceExecuteCommandDelegate(ref InputDeviceCommand command); // TypeDefIndex: 45370; 0x00000001817C2F70-0x00000001817C2F80

	public struct InputDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 45371
	{
		// Fields
		internal const int kBaseCommandSize = 8; // Metadata: 0x0205C077
		public const int BaseCommandSize = 8; // Metadata: 0x0205C078
		public const long GenericFailure = -1; // Metadata: 0x0205C079
		public const long GenericSuccess = 1; // Metadata: 0x0205C081
		public FourCC type; // 0x00
		public int sizeInBytes; // 0x04
	
		// Properties
		public int payloadSizeInBytes { get => default; } // 0x0000000185FD8920-0x0000000185FD8930 
		public unsafe void* payloadPtr { get => default; } // 0x0000000185FC1A80-0x0000000185FC1A90 
		public FourCC typeStatic { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public InputDeviceCommand(FourCC type, int sizeInBytes = 8 /* Metadata: 0x0205C076 */) : this() {
			this.type = default;
			this.sizeInBytes = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize) => default; // 0x0000000184951DE0-0x0000000184951E80
	}

	public struct QueryCanRunInBackground : IInputDeviceCommandInfo // TypeDefIndex: 45372
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x0205C089
		public InputDeviceCommand baseCommand; // 0x00
		public bool canRunInBackground; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD89E0-0x0000000185FD89F0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD89E0-0x0000000185FD89F0 
	
		// Methods
		public static QueryCanRunInBackground Create() => default; // 0x00000001858D8880-0x00000001858D88B0
	}

	public struct QueryDimensionsCommand : IInputDeviceCommandInfo // TypeDefIndex: 45373
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0205C08A
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 outDimensions; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8A20-0x0000000185FD8A30 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8A20-0x0000000185FD8A30 
	
		// Methods
		public static QueryDimensionsCommand Create() => default; // 0x0000000185FD89F0-0x0000000185FD8A20
	}

	public struct QueryEnabledStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 45374
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x0205C08B
		public InputDeviceCommand baseCommand; // 0x00
		public bool isEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8A60-0x0000000185FD8A70 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8A60-0x0000000185FD8A70 
	
		// Methods
		public static QueryEnabledStateCommand Create() => default; // 0x0000000185FD8A30-0x0000000185FD8A60
	}

	public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo // TypeDefIndex: 45376
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0205C08C
		public InputDeviceCommand baseCommand; // 0x00
		public _nameBuffer_e__FixedBuffer nameBuffer; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8B10-0x0000000185FD8B20 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8B10-0x0000000185FD8B20 
	
		// Nested types
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 45375
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadLayoutName() => default; // 0x000000018BD319C8-0x000000018BD319DC
		public void WriteLayoutName(string name) {} // 0x000000018BD319DC-0x000000018BD31A08
		public static QueryKeyboardLayoutCommand Create() => default; // 0x0000000185FD8AD0-0x0000000185FD8B10
	}

	public struct QueryKeyNameCommand : IInputDeviceCommandInfo // TypeDefIndex: 45378
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0205C08E
		internal const int kSize = 268; // Metadata: 0x0205C090
		public InputDeviceCommand baseCommand; // 0x00
		public int scanOrKeyCode; // 0x08
		public _nameBuffer_e__FixedBuffer nameBuffer; // 0x0C
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8AC0-0x0000000185FD8AD0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8AC0-0x0000000185FD8AD0 
	
		// Nested types
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 45377
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadKeyName() => default; // 0x000000018BD319B4-0x000000018BD319C8
		public static QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key) => default; // 0x0000000185FD8A70-0x0000000185FD8AC0
	}

	public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo // TypeDefIndex: 45382
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x0205C092
		internal const int kMaxIdLength = 256; // Metadata: 0x0205C094
		internal const int kSize = 1040; // Metadata: 0x0205C096
		public InputDeviceCommand baseCommand; // 0x00
		public ulong handle; // 0x08
		internal _nameBuffer_e__FixedBuffer nameBuffer; // 0x10
		internal _idBuffer_e__FixedBuffer idBuffer; // 0x210
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8B60-0x0000000185FD8B70 
		public string id { get => default; set {} } // 0x000000018BD31A08-0x000000018BD31A1C 0x000000018BD31A30-0x000000018BD31B54
		public string name { get => default; set {} } // 0x000000018BD31A1C-0x000000018BD31A30 0x000000018BD31B54-0x000000018BD31C78
		public FourCC typeStatic { get => default; } // 0x0000000185FD8B60-0x0000000185FD8B70 
	
		// Nested types
		public enum Result : long // TypeDefIndex: 45379
		{
			DevicePairedToUserAccount = 2,
			UserAccountSelectionInProgress = 4,
			UserAccountSelectionComplete = 8,
			UserAccountSelectionCanceled = 16
		}
	
		public struct _nameBuffer_e__FixedBuffer // TypeDefIndex: 45380
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 45381
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static QueryPairedUserAccountCommand Create() => default; // 0x0000000185FD8B20-0x0000000185FD8B60
	}

	internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 45383
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0205C0B8
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8BA0-0x0000000185FD8BB0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8BA0-0x0000000185FD8BB0 
	
		// Methods
		public static QuerySamplingFrequencyCommand Create() => default; // 0x0000000185FD8B70-0x0000000185FD8BA0
	}

	internal struct QueryUserIdCommand : IInputDeviceCommandInfo // TypeDefIndex: 45385
	{
		// Fields
		public const int kMaxIdLength = 256; // Metadata: 0x0205C0B9
		internal const int kSize = 520; // Metadata: 0x0205C0BB
		public InputDeviceCommand baseCommand; // 0x00
		public _idBuffer_e__FixedBuffer idBuffer; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8BF0-0x0000000185FD8C00 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8BF0-0x0000000185FD8C00 
	
		// Nested types
		public struct _idBuffer_e__FixedBuffer // TypeDefIndex: 45384
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string ReadId() => default; // 0x000000018BD319C8-0x000000018BD319DC
		public static QueryUserIdCommand Create() => default; // 0x0000000185FD8BB0-0x0000000185FD8BF0
	}

	public struct RequestResetCommand : IInputDeviceCommandInfo // TypeDefIndex: 45386
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0205C0BD
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8C20-0x0000000185FD8C30 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8C20-0x0000000185FD8C30 
	
		// Methods
		public static RequestResetCommand Create() => default; // 0x0000000185FD8C00-0x0000000185FD8C20
	}

	public struct RequestSyncCommand : IInputDeviceCommandInfo // TypeDefIndex: 45387
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x0205C0BE
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8C50-0x0000000185FD8C60 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8C50-0x0000000185FD8C60 
	
		// Methods
		public static RequestSyncCommand Create() => default; // 0x0000000185FD8C30-0x0000000185FD8C50
	}

	public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 45388
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0205C0BF
		public InputDeviceCommand baseCommand; // 0x00
		private Vector2 m_Position; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8CA0-0x0000000185FD8CB0 
		public Vector2 position { get => default; } // 0x0000000185FB8260-0x0000000185FB8280 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8CA0-0x0000000185FD8CB0 
	
		// Methods
		public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) => default; // 0x0000000185FD8C80-0x0000000185FD8CA0
	}

	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 45389
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x0205C0C0
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8CE0-0x0000000185FD8CF0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8CE0-0x0000000185FD8CF0 
	
		// Methods
		public static SetSamplingFrequencyCommand Create(float frequency) => default; // 0x0000000185FD8CB0-0x0000000185FD8CE0
	}

	internal struct WarpMousePositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 45390
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0205C0C1
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 warpPositionInPlayerDisplaySpace; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD8D70-0x0000000185FD8D80 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8D70-0x0000000185FD8D80 
	
		// Methods
		public static WarpMousePositionCommand Create(Vector2 position) => default; // 0x0000000185FD8D50-0x0000000185FD8D70
	}

	public struct GamepadState : IInputStateTypeInfo // TypeDefIndex: 45391
	{
		// Fields
		internal const string ButtonSouthShortDisplayName = "A"; // Metadata: 0x0205C0C3
		internal const string ButtonNorthShortDisplayName = "Y"; // Metadata: 0x0205C0C5
		internal const string ButtonWestShortDisplayName = "X"; // Metadata: 0x0205C0C7
		internal const string ButtonEastShortDisplayName = "B"; // Metadata: 0x0205C0C9
		public uint buttons; // 0x00
		public Vector2 leftStick; // 0x04
		public Vector2 rightStick; // 0x0C
		public float leftTrigger; // 0x14
		public float rightTrigger; // 0x18
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD8800-0x0000000185FD8810 
		public FourCC format { get => default; } // 0x0000000185FD8800-0x0000000185FD8810 
	
		// Constructors
		public GamepadState(GamepadButton[] buttons) : this() {
			this.buttons = default;
			leftStick = default;
			rightStick = default;
			leftTrigger = default;
			rightTrigger = default;
		} // 0x000000018BD2AA94-0x000000018BD2AB3C
	
		// Methods
		public GamepadState WithButton(GamepadButton button, bool value = true /* Metadata: 0x0205C0C2 */) => default; // 0x000000018BD2AA50-0x000000018BD2AA94
	}

	public enum GamepadButton // TypeDefIndex: 45392
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

	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo // TypeDefIndex: 45393
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x0205C0E3
		public InputDeviceCommand baseCommand; // 0x00
		public float lowFrequencyMotorSpeed; // 0x08
		public float highFrequencyMotorSpeed; // 0x0C
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD84F0-0x0000000185FD8500 
		public FourCC typeStatic { get => default; } // 0x0000000185FD84F0-0x0000000185FD8500 
	
		// Methods
		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) => default; // 0x0000000185FD84C0-0x0000000185FD84F0
	}

	internal interface ICustomDeviceReset // TypeDefIndex: 45394
	{
		// Methods
		void Reset();
	}

	internal interface IEventMerger // TypeDefIndex: 45395
	{
		// Methods
		bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr);
	}

	internal interface IEventPreProcessor // TypeDefIndex: 45396
	{
		// Methods
		bool PreProcessEvent(InputEventPtr currentEventPtr);
	}

	public interface IInputUpdateCallbackReceiver // TypeDefIndex: 45397
	{
		// Methods
		void OnUpdate();
	}

	public interface ITextInputReceiver // TypeDefIndex: 45398
	{
		// Methods
		void OnTextInput(char character);
		void OnIMECompositionChanged(IMECompositionString compositionString);
	}

	internal struct JoystickState : IInputStateTypeInfo // TypeDefIndex: 45400
	{
		// Fields
		public int buttons; // 0x00
		public Vector2 stick; // 0x04
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD8980-0x0000000185FD8990 
		public FourCC format { get => default; } // 0x0000000185FD8980-0x0000000185FD8990 
	
		// Nested types
		public enum Button // TypeDefIndex: 45399
		{
			HatSwitchUp = 0,
			HatSwitchDown = 1,
			HatSwitchLeft = 2,
			HatSwitchRight = 3,
			Trigger = 4
		}
	}

	public struct KeyboardState : IInputStateTypeInfo // TypeDefIndex: 45402
	{
		// Fields
		private const int kSizeInBits = 123; // Metadata: 0x0205C0E9
		internal const int kSizeInBytes = 16; // Metadata: 0x0205C0EB
		public _keys_e__FixedBuffer keys; // 0x00
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD8990-0x0000000185FD89A0 
		public FourCC format { get => default; } // 0x0000000185FD8990-0x0000000185FD89A0 
	
		// Nested types
		public struct _keys_e__FixedBuffer // TypeDefIndex: 45401
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		public KeyboardState(UnityEngine.InputSystem.Key[] pressedKeys) : this() {
			keys = default;
		} // 0x000000018BD3174C-0x000000018BD3175C
		public KeyboardState(bool IMESelected, UnityEngine.InputSystem.Key[] pressedKeys) : this() {
			keys = default;
		} // 0x000000018BD3175C-0x000000018BD31830
	
		// Methods
		public void Set(UnityEngine.InputSystem.Key key, bool state) {} // 0x0000000186473C6C-0x0000000186473C74
		internal bool Get(UnityEngine.InputSystem.Key key) => default; // 0x0000000184582370-0x00000001845823A0
		public void Press(UnityEngine.InputSystem.Key key) {} // 0x000000018BD31728-0x000000018BD31740
		public void Release(UnityEngine.InputSystem.Key key) {} // 0x000000018BD31740-0x000000018BD3174C
	}

	public struct MouseState : IInputStateTypeInfo // TypeDefIndex: 45403
	{
		// Fields
		public Vector2 position; // 0x00
		public Vector2 delta; // 0x08
		public Vector2 scroll; // 0x10
		public ushort buttons; // 0x18
		public ushort displayIndex; // 0x1A
		public ushort clickCount; // 0x1C
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD89B0-0x0000000185FD89C0 
		public FourCC format { get => default; } // 0x0000000185FD89B0-0x0000000185FD89C0 
	
		// Methods
		public MouseState WithButton(MouseButton button, bool state = true /* Metadata: 0x0205C0EC */) => default; // 0x000000018BD31830-0x000000018BD3186C
	}

	public enum MouseButton // TypeDefIndex: 45404
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		Forward = 3,
		Back = 4
	}

	public struct PenState : IInputStateTypeInfo // TypeDefIndex: 45405
	{
		// Fields
		public Vector2 position; // 0x00
		public Vector2 delta; // 0x08
		public Vector2 tilt; // 0x10
		public float pressure; // 0x18
		public float twist; // 0x1C
		public ushort buttons; // 0x20
		private ushort displayIndex; // 0x22
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD89C0-0x0000000185FD89D0 
		public FourCC format { get => default; } // 0x0000000185FD89C0-0x0000000185FD89D0 
	
		// Methods
		public PenState WithButton(PenButton button, bool state = true /* Metadata: 0x0205C0F2 */) => default; // 0x000000018BD31970-0x000000018BD319B4
	}

	internal struct PointerState : IInputStateTypeInfo // TypeDefIndex: 45406
	{
		// Fields
		private uint pointerId; // 0x00
		public Vector2 position; // 0x04
		public Vector2 delta; // 0x0C
		public float pressure; // 0x14
		public Vector2 radius; // 0x18
		public ushort buttons; // 0x20
		public ushort displayIndex; // 0x22
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD89D0-0x0000000185FD89E0 
		public FourCC format { get => default; } // 0x0000000185FD89D0-0x0000000185FD89E0 
	}

	internal struct AccelerometerState : IInputStateTypeInfo // TypeDefIndex: 45407
	{
		// Fields
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD83B0-0x0000000185FD83C0 
		public FourCC format { get => default; } // 0x0000000185FD83B0-0x0000000185FD83C0 
	}

	internal struct GyroscopeState : IInputStateTypeInfo // TypeDefIndex: 45408
	{
		// Fields
		public Vector3 angularVelocity; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD8820-0x0000000185FD8830 
		public FourCC format { get => default; } // 0x0000000185FD8820-0x0000000185FD8830 
	}

	internal struct GravityState : IInputStateTypeInfo // TypeDefIndex: 45409
	{
		// Fields
		public Vector3 gravity; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD8810-0x0000000185FD8820 
		public FourCC format { get => default; } // 0x0000000185FD8810-0x0000000185FD8820 
	}

	internal struct AttitudeState : IInputStateTypeInfo // TypeDefIndex: 45410
	{
		// Fields
		public Quaternion attitude; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD8420-0x0000000185FD8430 
		public FourCC format { get => default; } // 0x0000000185FD8420-0x0000000185FD8430 
	}

	internal struct LinearAccelerationState : IInputStateTypeInfo // TypeDefIndex: 45411
	{
		// Fields
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000185FD89A0-0x0000000185FD89B0 
		public FourCC format { get => default; } // 0x0000000185FD89A0-0x0000000185FD89B0 
	}

	internal enum TouchFlags : byte // TypeDefIndex: 45412
	{
		IndirectTouch = 1,
		PrimaryTouch = 8,
		TapPress = 16,
		TapRelease = 32,
		OrphanedPrimaryTouch = 64,
		BeganInSameFrame = 128
	}

	public struct TouchState : IInputStateTypeInfo // TypeDefIndex: 45413
	{
		// Fields
		internal const int kSizeInBytes = 56; // Metadata: 0x0205C0F9
		public int touchId; // 0x00
		public Vector2 position; // 0x04
		public Vector2 delta; // 0x0C
		public float pressure; // 0x14
		public Vector2 radius; // 0x18
		public byte phaseId; // 0x20
		public byte tapCount; // 0x21
		public byte displayIndex; // 0x22
		public byte flags; // 0x23
		internal uint updateStepCount; // 0x24
		public double startTime; // 0x28
		public Vector2 startPosition; // 0x30
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD8CF0-0x0000000185FD8D00 
		public UnityEngine.InputSystem.TouchPhase phase { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public bool isNoneEndedOrCanceled { get => default; } // 0x000000018BD33E10-0x000000018BD33E28 
		public bool isInProgress { get => default; } // 0x000000018BD33DF0-0x000000018BD33E08 
		public bool isPrimaryTouch { get => default; set {} } // 0x000000018BD33E30-0x000000018BD33E38 0x000000018BD33EB4-0x000000018BD33ED8
		internal bool isOrphanedPrimaryTouch { get => default; set {} } // 0x000000018BD33E28-0x000000018BD33E30 0x000000018BD33E90-0x000000018BD33EB4
		public bool isIndirectTouch { get => default; set {} } // 0x000000018BD33E08-0x000000018BD33E10 0x000000018BD33E6C-0x000000018BD33E90
		public bool isTap { get => default; set {} } // 0x000000018BD33E38-0x000000018BD33E40 0x000000018BD33ED8-0x000000018BD33EFC
		internal bool isTapPress { get => default; set {} } // 0x000000018BD33E38-0x000000018BD33E40 0x000000018BD33ED8-0x000000018BD33EFC
		internal bool isTapRelease { get => default; set {} } // 0x000000018BD33E40-0x000000018BD33E48 0x000000018BD33EFC-0x000000018BD33F20
		internal bool beganInSameFrame { get => default; set {} } // 0x000000018BD33DE8-0x000000018BD33DF0 0x000000018BD33E48-0x000000018BD33E6C
		public FourCC format { get => default; } // 0x0000000185FD8CF0-0x0000000185FD8D00 
	
		// Methods
		public override string ToString() => default; // 0x000000018BD33BA8-0x000000018BD33DE8
	}

	internal struct TouchscreenState : IInputStateTypeInfo // TypeDefIndex: 45416
	{
		// Fields
		public const int MaxTouches = 10; // Metadata: 0x0205C0FA
		public _primaryTouchData_e__FixedBuffer primaryTouchData; // 0x00
		internal const int kTouchDataOffset = 56; // Metadata: 0x0205C0FB
		public _touchData_e__FixedBuffer touchData; // 0x38
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000185FD8D30-0x0000000185FD8D40 
		public unsafe TouchState* primaryTouch { get => default; } // 0x0000000185779060-0x0000000185779070 
		public unsafe TouchState* touches { get => default; } // 0x0000000185FD8D40-0x0000000185FD8D50 
		public FourCC format { get => default; } // 0x0000000185FD8D30-0x0000000185FD8D40 
	
		// Nested types
		public struct _primaryTouchData_e__FixedBuffer // TypeDefIndex: 45414
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _touchData_e__FixedBuffer // TypeDefIndex: 45415
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ActionEvent : IInputEventTypeInfo // TypeDefIndex: 45418
	{
		// Fields
		public InputEvent baseEvent; // 0x00
		private ushort m_ControlIndex; // 0x14
		private ushort m_BindingIndex; // 0x16
		private ushort m_InteractionIndex; // 0x18
		private byte m_StateIndex; // 0x1A
		private byte m_Phase; // 0x1B
		private double m_StartTime; // 0x1C
		public _m_ValueData_e__FixedBuffer m_ValueData; // 0x24
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000185FD83D0-0x0000000185FD83E0 
		public double startTime { get => default; set {} } // 0x0000000185FD83E0-0x0000000185FD83F0 0x0000000185FD8410-0x0000000185FD8420
		public InputActionPhase phase { get => default; set {} } // 0x0000000185FB3590-0x0000000185FB35A0 0x0000000185FB35C0-0x0000000185FB35D0
		public unsafe byte* valueData { get => default; } // 0x0000000185FD83F0-0x0000000185FD8400 
		public int valueSizeInBytes { get => default; } // 0x0000000185FD8400-0x0000000185FD8410 
		public int stateIndex { get => default; set {} } // 0x0000000185FB0730-0x0000000185FB0740 0x000000018BD26FE8-0x000000018BD27054
		public int controlIndex { get => default; set {} } // 0x0000000185FC3340-0x0000000185FC3350 0x000000018BD26F00-0x000000018BD26F6C
		public int bindingIndex { get => default; set {} } // 0x0000000185FC5940-0x0000000185FC5950 0x000000018BD26E94-0x000000018BD26F00
		public int interactionIndex { get => default; set {} } // 0x000000018BD26E7C-0x000000018BD26E94 0x000000018BD26F6C-0x000000018BD26FE8
		public FourCC typeStatic { get => default; } // 0x0000000185FD83D0-0x0000000185FD83E0 
	
		// Nested types
		public struct _m_ValueData_e__FixedBuffer // TypeDefIndex: 45417
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x0000000185779060-0x0000000185779070
		public static int GetEventSizeWithValueSize(int valueSizeInBytes) => default; // 0x0000000185FD83C0-0x0000000185FD83D0
		public static unsafe ActionEvent* From(InputEventPtr ptr) => default; // 0x000000018BD26D40-0x000000018BD26E7C
	}

	public struct DeltaStateEvent : IInputEventTypeInfo // TypeDefIndex: 45420
	{
		// Fields
		public const int Type = 1145852993; // Metadata: 0x0205C0FD
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		public uint stateOffset; // 0x18
		internal _stateData_e__FixedBuffer stateData; // 0x1C
	
		// Properties
		public uint deltaStateSizeInBytes { get => default; } // 0x0000000185FD8430-0x0000000185FD8440 
		public unsafe void* deltaState { get => default; } // 0x0000000185FD8440-0x0000000185FD8450 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8450-0x0000000185FD8460 
	
		// Nested types
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 45419
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x0000000185779060-0x0000000185779070
		public static unsafe DeltaStateEvent* From(InputEventPtr ptr) => default; // 0x000000018BD27318-0x000000018BD27454
		internal static unsafe DeltaStateEvent* FromUnchecked(InputEventPtr ptr) => default; // 0x0000000185779060-0x0000000185779070
		public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0205C0FC */) {
			eventPtr = default;
			return default;
		} // 0x000000018BD27054-0x000000018BD27318
	}

	public struct DeviceConfigurationEvent : IInputEventTypeInfo // TypeDefIndex: 45421
	{
		// Fields
		public const int Type = 1145259591; // Metadata: 0x0205C102
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000185FD8460-0x0000000185FD8470 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x0000000185779060-0x0000000185779070
		public static DeviceConfigurationEvent Create(int deviceId, double time) => default; // 0x000000018BD27454-0x000000018BD274AC
	}

	public struct DeviceRemoveEvent : IInputEventTypeInfo // TypeDefIndex: 45422
	{
		// Fields
		public const int Type = 1146242381; // Metadata: 0x0205C10F
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000185FD8470-0x0000000185FD8480 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x0000000185779060-0x0000000185779070
		public static DeviceRemoveEvent Create(int deviceId, double time = -1 /* Metadata: 0x0205C107 */) => default; // 0x000000018BD274AC-0x000000018BD27504
	}

	public struct DeviceResetEvent : IInputEventTypeInfo // TypeDefIndex: 45423
	{
		// Fields
		public const int Type = 1146245972; // Metadata: 0x0205C11D
		public InputEvent baseEvent; // 0x00
		public bool hardReset; // 0x08
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000185FD8480-0x0000000185FD8490 
	
		// Methods
		public static DeviceResetEvent Create(int deviceId, bool hardReset = false /* Metadata: 0x0205C114 */, double time = -1 /* Metadata: 0x0205C115 */) => default; // 0x000000018BD27504-0x000000018BD2756C
	}

	public interface IInputEventTypeInfo // TypeDefIndex: 45424
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct IMECompositionEvent : IInputEventTypeInfo // TypeDefIndex: 45425
	{
		// Fields
		internal const int kIMECharBufferSize = 64; // Metadata: 0x0205C122
		public const int Type = 1229800787; // Metadata: 0x0205C124
		public InputEvent baseEvent; // 0x00
		public IMECompositionString compositionString; // 0x14
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000185FD88E0-0x0000000185FD88F0 
	
		// Methods
		public static IMECompositionEvent Create(int deviceId, string compositionString, double time) => default; // 0x000000018BD2DAD0-0x000000018BD2DBD0
	}

	public struct IMECompositionString : IEnumerable<char> // TypeDefIndex: 45428
	{
		// Fields
		private int size; // 0x00
		private _buffer_e__FixedBuffer buffer; // 0x04
	
		// Properties
		public int Count { get => default; } // 0x0000000185FD87A0-0x0000000185FD8800 
		public char this[int index] { get => default; } // 0x000000018BD29B80-0x000000018BD29BA8 
	
		// Nested types
		internal struct Enumerator : IEnumerator<char> // TypeDefIndex: 45426
		{
			// Fields
			private IMECompositionString m_CompositionString; // 0x00
			private char m_CurrentCharacter; // 0x84
			private int m_CurrentIndex; // 0x88
	
			// Properties
			public char Current { get => default; } // 0x000000018BD2DBD0-0x000000018BD2DCF8 
			object IEnumerator.Current { get => default; } // 0x000000018BD2DCF8-0x000000018BD2DD00 
	
			// Constructors
			public Enumerator(IMECompositionString compositionString) : this() {
				m_CompositionString = default;
				m_CurrentCharacter = default;
				m_CurrentIndex = default;
			} // 0x00000001818226B0-0x00000001818226C0
	
			// Methods
			public bool MoveNext() => default; // 0x000000018BD2DD90-0x000000018BD2DE00
			public void Reset() {} // 0x000000018BD2DD24-0x000000018BD2DD90
			public void Dispose() {} // 0x000000018BD2DD00-0x000000018BD2DD24
		}
	
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 45427
		{
			// Fields
			public char FixedElementField; // 0x00
		}
	
		// Constructors
		public IMECompositionString(string characters) : this() {
			size = default;
			buffer = default;
		} // 0x0000000185FD6FF0-0x0000000185FD7000
	
		// Methods
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public IEnumerator<char> GetEnumerator() => default; // 0x0000000185FC8CB0-0x0000000185FC8CC0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BD29C50-0x000000018BD29C98
	}

	public struct InputEvent // TypeDefIndex: 45429
	{
		// Fields
		private const uint kHandledMask = 2147483648; // Metadata: 0x0205C131
		private const uint kIdMask = 2147483647; // Metadata: 0x0205C136
		internal const int kBaseEventSize = 20; // Metadata: 0x0205C13B
		public const int InvalidEventId = 0; // Metadata: 0x0205C13C
		internal const int kAlignment = 4; // Metadata: 0x0205C13D
		private NativeInputEvent m_Event; // 0x00
	
		// Properties
		public FourCC type { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public uint sizeInBytes { get => default; set {} } // 0x0000000185FB1440-0x0000000185FB1450 0x0000000185EF8E80-0x0000000185EF8EA0
		public int eventId { get => default; set {} } // 0x0000000185FD8960-0x0000000185FD8970 0x0000000185FD8970-0x0000000185FD8980
		public int deviceId { get => default; set {} } // 0x0000000185FB1430-0x0000000185FB1440 0x0000000185FD4A80-0x0000000185FD4A90
		public double time { get => default; set {} } // 0x000000018BD316E4-0x000000018BD31728 0x0000000185D65750-0x0000000185D657B0
		internal double internalTime { get => default; set {} } // 0x0000000185FC8460-0x0000000185FC8470 0x0000000185FCA580-0x0000000185FCA590
		public bool handled { get => default; set {} } // 0x00000001845841A0-0x00000001845841B0 0x00000001852E0B50-0x00000001852E0B70
	
		// Constructors
		public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1 /* Metadata: 0x0205C129 */) : this() {
			m_Event = default;
		} // 0x0000000184952970-0x0000000184952A10
	
		// Methods
		public override string ToString() => default; // 0x000000018BD3152C-0x000000018BD316E4
		internal static unsafe InputEvent* GetNextInMemory(InputEvent* currentPtr) => default; // 0x000000018457FA50-0x000000018457FB30
		internal static unsafe InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) => default; // 0x000000018BD3142C-0x000000018BD3152C
		public static unsafe bool Equals(InputEvent* first, InputEvent* second) => default; // 0x000000018BD313F0-0x000000018BD3142C
	}

	public struct InputEventBuffer : IEnumerable<InputEventPtr>, IDisposable, ICloneable // TypeDefIndex: 45431
	{
		// Fields
		public const long BufferSizeUnknown = -1; // Metadata: 0x0205C148
		private NativeArray<byte> m_Buffer; // 0x00
		private long m_SizeInBytes; // 0x10
		private int m_EventCount; // 0x18
		private bool m_WeOwnTheBuffer; // 0x1C
	
		// Properties
		public int eventCount { get => default; } // 0x000000018BD2E3E0-0x000000018BD2E518 
		public long sizeInBytes { get => default; } // 0x000000018BD2E0EC-0x000000018BD2E180 
		public long capacityInBytes { get => default; } // 0x000000018BD2DE80-0x000000018BD2E0EC 
		public NativeArray<byte> data { get => default; } // 0x000000018BD2E244-0x000000018BD2E2A8 
		public InputEventPtr bufferPtr { get => default; } // 0x00000001847C4F20-0x00000001847C4F40 
	
		// Nested types
		private struct Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 45430
		{
			// Fields
			private readonly unsafe InputEvent* m_Buffer; // 0x00
			private readonly int m_EventCount; // 0x08
			private unsafe InputEvent* m_CurrentEvent; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public InputEventPtr Current { get => default; } // 0x000000018BD2E518-0x000000018BD2E548 
			object IEnumerator.Current { get => default; } // 0x000000018457CD30-0x000000018457CE00 
	
			// Constructors
			public unsafe Enumerator(InputEventBuffer buffer) : this() {
				m_Buffer = default;
				m_EventCount = default;
				m_CurrentEvent = default;
				m_CurrentIndex = default;
			} // 0x00000001813AE560-0x00000001813AE570
	
			// Methods
			public bool MoveNext() => default; // 0x000000018346D130-0x000000018346D140
			public void Reset() {} // 0x0000000185F868B0-0x0000000185F868F0
			public void Dispose() {} // 0x0000000181D61820-0x0000000181D61830
		}
	
		// Constructors
		public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1 /* Metadata: 0x0205C13E */, int capacityInBytes = -1 /* Metadata: 0x0205C13F */) : this() {
			m_Buffer = default;
			m_SizeInBytes = default;
			m_EventCount = default;
			m_WeOwnTheBuffer = default;
		} // 0x000000018457F810-0x000000018457F880
		public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1 /* Metadata: 0x0205C140 */, bool transferNativeArrayOwnership = false /* Metadata: 0x0205C141 */) : this() {
			m_Buffer = default;
			m_SizeInBytes = default;
			m_EventCount = default;
			m_WeOwnTheBuffer = default;
		} // 0x000000018BD2E2F8-0x000000018BD2E378
	
		// Methods
		public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048 /* Metadata: 0x0205C142 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205C144 */) {} // 0x000000018BD2E378-0x000000018BD2E380
		public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048 /* Metadata: 0x0205C145 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205C147 */) => default; // 0x000000018BD2E2A8-0x000000018BD2E2F8
		public unsafe bool Contains(InputEvent* eventPtr) => default; // 0x000000018BD2E180-0x000000018BD2E244
		public void Reset() {} // 0x000000018BD2E380-0x000000018BD2E3E0
		internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) {} // 0x000000018BD29CC4-0x000000018BD29CFC
		public IEnumerator<InputEventPtr> GetEnumerator() => default; // 0x000000018BD29B30-0x000000018BD29B80
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FBB420-0x0000000185FBB430
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public InputEventBuffer Clone() => default; // 0x000000018346D130-0x000000018346D140
		object ICloneable.Clone() => default; // 0x000000018BD29BA8-0x000000018BD29BF0
	}

	public struct InputEventListener : IObservable<InputEventPtr> // TypeDefIndex: 45434
	{
		// Fields
		internal static ObserverState s_ObserverState; // 0x00
	
		// Nested types
		internal class ObserverState // TypeDefIndex: 45432
		{
			// Fields
			public InlinedArray<IObserver<InputEventPtr>> observers; // 0x10
			public Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28
	
			// Constructors
			public ObserverState() {} // 0x000000018BD2E6C4-0x000000018BD2E830
	
			// Methods
			private void _.ctor_b__2_0(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD2E830-0x000000018BD2E99C
		}
	
		private class DisposableObserver : IDisposable // TypeDefIndex: 45433
		{
			// Fields
			public IObserver<InputEventPtr> observer; // 0x10
	
			// Constructors
			public DisposableObserver() {} // 0x000000018BD318F4-0x000000018BD31970
	
			// Methods
			public void Dispose() {} // 0x000000018BD2E548-0x000000018BD2E6C4
		}
	
		// Methods
		public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback) => default; // 0x000000018BD3186C-0x000000018BD318F4
		public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback) => default; // 0x000000018BD2756C-0x000000018BD27694
		public IDisposable Subscribe(IObserver<InputEventPtr> observer) => default; // 0x0000000185492010-0x0000000185492020
	}

	public struct InputEventPtr : IEquatable<InputEventPtr> // TypeDefIndex: 45435
	{
		// Fields
		private readonly unsafe InputEvent* m_EventPtr; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x0000000184443DF0-0x0000000184443E00 
		public bool handled { get => default; set {} } // 0x000000018BD2EAA4-0x000000018BD2EAC4 0x000000018BD2ED40-0x000000018BD2EDB0
		public int id { get => default; set {} } // 0x000000018BD2EAC4-0x000000018BD2EAD8 0x000000018BD2EDB0-0x000000018BD2EE28
		public FourCC type { get => default; } // 0x0000000184580A40-0x0000000184580A50 
		public uint sizeInBytes { get => default; } // 0x000000018457CA20-0x000000018457CA40 
		public int deviceId { get => default; set {} } // 0x000000018BD2EA90-0x000000018BD2EAA4 0x000000018BD2ECD0-0x000000018BD2ED40
		public double time { get => default; set {} } // 0x000000018BD2ECB0-0x000000018BD2ECD0 0x000000018BD2EE98-0x000000018BD2EF08
		internal double internalTime { get => default; set {} } // 0x000000018457FFE0-0x0000000184580000 0x000000018BD2EE28-0x000000018BD2EE98
		public unsafe InputEvent* data { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		internal FourCC stateFormat { get => default; } // 0x00000001853706C0-0x0000000185370760 
		internal uint stateSizeInBytes { get => default; } // 0x000000018BD2EBA8-0x000000018BD2ECB0 
		internal uint stateOffset { get => default; } // 0x000000018BD2EAD8-0x000000018BD2EBA8 
	
		// Constructors
		public unsafe InputEventPtr(InputEvent* eventPtr) : this() {
			m_EventPtr = default;
		} // 0x0000000185FB2BB0-0x0000000185FB2BC0
	
		// Methods
		public bool IsA<TOtherEvent>()
			where TOtherEvent : struct, IInputEventTypeInfo => default;
		public InputEventPtr Next() => default; // 0x000000018BD2EA18-0x000000018BD2EA38
		public override string ToString() => default; // 0x000000018BD2EA38-0x000000018BD2EA90
		public unsafe InputEvent* ToPointer() => default; // 0x00000001834AFB60-0x00000001834AFB70
		public bool Equals(InputEventPtr other) => default; // 0x000000018BD2EA00-0x000000018BD2EA18
		public override bool Equals(object obj) => default; // 0x000000018BD2E99C-0x000000018BD2EA00
		public override int GetHashCode() => default; // 0x00000001818226B0-0x00000001818226C0
		public static bool operator ==(InputEventPtr left, InputEventPtr right) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public static bool operator !=(InputEventPtr left, InputEventPtr right) => default; // 0x0000000183FA9580-0x0000000183FA9590
		public static unsafe implicit operator InputEventPtr(InputEvent* eventPtr) => default; // 0x0000000185779060-0x0000000185779070
		public static unsafe InputEventPtr From(InputEvent* eventPtr) => default; // 0x0000000185779060-0x0000000185779070
		public static unsafe implicit operator InputEvent*(InputEventPtr eventPtr) => default; // 0x0000000185779060-0x0000000185779070
		public static unsafe InputEvent* FromInputEventPtr(InputEventPtr eventPtr) => default; // 0x0000000185779060-0x0000000185779070
	}

	internal struct InputEventStream // TypeDefIndex: 45436
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
		public bool isOpen { get => default; } // 0x0000000185FB0950-0x0000000185FB0960 
		public int remainingEventCount { get => default; } // 0x0000000185FD8930-0x0000000185FD8940 
		public int numEventsRetainedInBuffer { get => default; } // 0x0000000185FB09F0-0x0000000185FB0A00 
		public unsafe InputEvent* currentEventPtr { get => default; } // 0x000000018457F7F0-0x000000018457F810 
		public uint numBytesRetainedInBuffer { get => default; } // 0x000000018BD2F0B4-0x000000018BD2F0E8 
	
		// Constructors
		public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents) : this() {
			m_NativeBuffer = default;
			m_CurrentNativeEventReadPtr = default;
			m_CurrentNativeEventWritePtr = default;
			m_RemainingNativeEventCount = default;
			m_MaxAppendedEvents = default;
			m_AppendBuffer = default;
			m_CurrentAppendEventReadPtr = default;
			m_CurrentAppendEventWritePtr = default;
			m_RemainingAppendEventCount = default;
			m_NumEventsRetainedInBuffer = default;
			m_IsOpen = default;
		} // 0x0000000184FF68C0-0x0000000184FF6950
	
		// Methods
		public void Close(ref InputEventBuffer eventBuffer) {} // 0x00000001847C4E90-0x00000001847C4F20
		public void CleanUpAfterException() {} // 0x000000018BD2EF08-0x000000018BD2EF5C
		public unsafe void Write(InputEvent* eventPtr) {} // 0x000000018BD2EF5C-0x000000018BD2F0B4
		public unsafe InputEvent* Advance(bool leaveEventInBuffer) => default; // 0x000000018457F780-0x000000018457F7F0
		public unsafe InputEvent* Peek() => default; // 0x000000018457FA00-0x000000018457FA50
	}

	[Serializable]
	public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr> // TypeDefIndex: 45443
	{
		// Fields
		private const int kDefaultBufferSize = 1048576; // Metadata: 0x0205C18A
		private static readonly ProfilerMarker k_InputEvenTraceMarker; // 0x00
		[NonSerialized]
		private int m_ChangeCounter; // 0x10
		[NonSerialized]
		private bool m_Enabled; // 0x14
		[NonSerialized]
		private Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> m_OnFilterEvent; // 0x18
		private int m_DeviceId; // 0x20
		[NonSerialized]
		private CallbackArray<Action<InputEventPtr>> m_EventListeners; // 0x28
		private long m_EventBufferSize; // 0x78
		private long m_MaxEventBufferSize; // 0x80
		private long m_GrowIncrementSize; // 0x88
		private long m_EventCount; // 0x90
		private long m_EventSizeInBytes; // 0x98
		private ulong m_EventBufferStorage; // 0xA0
		private ulong m_EventBufferHeadStorage; // 0xA8
		private ulong m_EventBufferTailStorage; // 0xB0
		private bool m_HasWrapped; // 0xB8
		private bool m_RecordFrameMarkers; // 0xB9
		private DeviceInfo[] m_DeviceInfos; // 0xC0
		private static int kFileVersion; // 0x08
	
		// Properties
		public static FourCC FrameMarkerEvent { get => default; } // 0x000000018BD38FE8-0x000000018BD39018 
		public int deviceId { get => default; set {} } // 0x000000018BD38E20-0x000000018BD38E44 0x000000018BD38E44-0x000000018BD38F24
		public bool enabled { get => default; } // 0x000000018BD38F24-0x000000018BD38F48 
		public bool recordFrameMarkers { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018BD38F48-0x000000018BD38F90
		public long eventCount { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public long totalEventSizeInBytes { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public long allocatedSizeInBytes { get => default; } // 0x000000018184FBD0-0x000000018184FBE0 
		public long maxSizeInBytes { get => default; } // 0x0000000185FB22C0-0x0000000185FB22D0 
		public ReadOnlyArray<DeviceInfo> deviceInfos { get => default; } // 0x0000000185FB2560-0x0000000185FB2570 
		public Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> onFilterEvent { get => default; set {} } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		private unsafe byte* m_EventBuffer { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BD4594C-0x000000018BD45990
		private unsafe byte* m_EventBufferHead { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000187EBD7DC-0x0000000187EBD8E8
		private unsafe byte* m_EventBufferTail { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		private static FourCC kFileFormat { get => default; } // 0x0000000185FB21A0-0x0000000185FB21B0 
	
		// Events
		public event Action<InputEventPtr> onEvent;
	
		// Nested types
		private class Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 45437
		{
			// Fields
			private InputEventTrace m_Trace; // 0x10
			private int m_ChangeCounter; // 0x18
			internal InputEventPtr m_Current; // 0x20
	
			// Properties
			public InputEventPtr Current { get => default; } // 0x0000000185FB32F0-0x0000000185FB3300 
			object IEnumerator.Current { get => default; } // 0x000000018BD31308-0x000000018BD313F0 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			public Enumerator(InputEventTrace trace) {} // 0x0000000185FD8940-0x0000000185FD8950
	
			// Methods
			public void Dispose() {} // 0x00000001813B88B0-0x00000001813B88C0
			public bool MoveNext() => default; // 0x00000001813B9430-0x00000001813B9440
			public void Reset() {} // 0x0000000185FBA190-0x0000000185FBA1A0
		}
	
		private enum FileFlags // TypeDefIndex: 45438
		{
			FixedUpdate = 1
		}
	
		public class ReplayController : IDisposable // TypeDefIndex: 45441
		{
			// Fields
			private bool _finished_k__BackingField; // 0x10
			private bool _paused_k__BackingField; // 0x11
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
			public InputEventTrace trace { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			public bool finished { get; private set; } // 0x0000000184088E70-0x0000000184088E80 0x000000018BD31200-0x000000018BD3124C
			public bool paused { get; set; } // 0x000000018BD312BC-0x000000018BD31308 0x000000018BD3115C-0x000000018BD31200
			public int position { get; private set; } // 0x000000018BD31118-0x000000018BD3115C 0x000000018BD30F90-0x000000018BD310A4
			public IEnumerable<UnityEngine.InputSystem.InputDevice> createdDevices { get => default; } // 0x000000018BD309C4-0x000000018BD30F90 
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 45439
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<InputEventPtr> __9__38_0; // 0x08
	
				// Constructors
				static __c() {} // 0x0000000181B5FFD0-0x0000000181B5FFE0
				public __c() {} // 0x0000000181E336C0-0x0000000181E336D0
	
				// Methods
				internal int _PlayAllEventsAccordingToTimestamps_b__38_0(InputEventPtr a, InputEventPtr b) => default; // 0x000000018BD3124C-0x000000018BD31260
			}
	
			private sealed class __c__DisplayClass43_0 // TypeDefIndex: 45440
			{
				// Fields
				public int originalDeviceId; // 0x10
	
				// Constructors
				public __c__DisplayClass43_0() {} // 0x000000018140CF50-0x000000018140CF60
	
				// Methods
				internal bool _ApplyDeviceMapping_b__0(DeviceInfo x) => default; // 0x000000018BD31260-0x000000018BD312BC
			}
	
			// Constructors
			public ReplayController() {} // Dummy constructor
			internal ReplayController(InputEventTrace trace) {} // 0x000000018BD2FC94-0x000000018BD2FDA8
	
			// Methods
			public void Dispose() {} // 0x000000018BD2FDA8-0x000000018BD306AC
			public ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice) => default; // 0x000000018BD2F5A4-0x000000018BD2F6D8
			public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) => default; // 0x000000018BD2F458-0x000000018BD2F5A4
			public ReplayController WithAllDevicesMappedToNewInstances() => default; // 0x000000018BD306EC-0x000000018BD30758
			public ReplayController OnFinished(Action action) => default; // 0x000000018BD30758-0x000000018BD309BC
			public ReplayController OnEvent(Action<InputEventPtr> action) => default; // 0x000000018BD2F114-0x000000018BD2F148
			public ReplayController PlayOneEvent() => default; // 0x000000018BD2F254-0x000000018BD2F36C
			public ReplayController Rewind() => default; // 0x000000018BD2F148-0x000000018BD2F234
			public ReplayController PlayAllFramesOneByOne() => default; // 0x000000018BD2F3CC-0x000000018BD2F458
			public ReplayController PlayAllEvents() => default; // 0x000000018BD2F36C-0x000000018BD2F3CC
			public ReplayController PlayAllEventsAccordingToTimestamps() => default; // 0x000000018BD309BC-0x000000018BD309C4
			private void OnBeginFrame() {} // 0x000000018BD2F234-0x000000018BD2F254
			private void Finished() {} // 0x0000000185FB0520-0x0000000185FB0530
			private void QueueEvent(InputEventPtr eventPtr) {} // 0x0000000185FBEC00-0x0000000185FBEC10
			private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr) {
				eventPtr = default;
				return default;
			} // 0x000000018349D730-0x000000018349D740
			private int ApplyDeviceMapping(int originalDeviceId) => default; // 0x0000000185FB0550-0x0000000185FB0560
		}
	
		[Serializable]
		public struct DeviceInfo // TypeDefIndex: 45442
		{
			// Fields
			internal int m_DeviceId; // 0x00
			internal string m_Layout; // 0x08
			internal FourCC m_StateFormat; // 0x10
			internal int m_StateSizeInBytes; // 0x14
			internal string m_FullLayoutJson; // 0x18
	
			// Properties
			public int deviceId { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x0000000185FB2430-0x0000000185FB2440
			public string layout { get => default; set {} } // 0x000000018BD2F0E8-0x000000018BD2F114 0x000000018BD306AC-0x000000018BD306EC
			public FourCC stateFormat { get => default; set {} } // 0x000000018BD2F6D8-0x000000018BD2F7B0 0x000000018BD2F7B0-0x000000018BD2FC94
			public int stateSizeInBytes { get => default; set {} } // 0x0000000185FD8950-0x0000000185FD8960 0x000000018BD310A4-0x000000018BD31118
		}
	
		// Constructors
		public InputEventTrace() {} // Dummy constructor
		public InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes = 1048576 /* Metadata: 0x0205C150 */, bool growBuffer = false /* Metadata: 0x0205C158 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x0205C159 */, long growIncrementSizeInBytes = -1 /* Metadata: 0x0205C161 */) {} // 0x000000018BD43EAC-0x000000018BD44050
		public InputEventTrace(long bufferSizeInBytes = 1048576 /* Metadata: 0x0205C169 */, bool growBuffer = false /* Metadata: 0x0205C171 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x0205C172 */, long growIncrementSizeInBytes = -1 /* Metadata: 0x0205C17A */) {} // 0x000000018BD44B34-0x000000018BD44C08
		static InputEventTrace() {} // 0x0000000185FBB0B0-0x0000000185FBB0C0
	
		// Methods
		public void WriteTo(string filePath) {} // 0x000000018BD44C08-0x000000018BD44D10
		public void WriteTo(Stream stream) {} // 0x0000000185FD8E00-0x0000000185FD8E10
		public void ReadFrom(string filePath) {} // 0x00000001878FE62C-0x00000001878FE648
		public void ReadFrom(Stream stream) {} // 0x00000001878FE648-0x00000001878FE664
		public static InputEventTrace LoadFrom(string filePath) => default; // 0x000000018BD4487C-0x000000018BD4490C
		public static InputEventTrace LoadFrom(Stream stream) => default; // 0x000000018BD44AF0-0x000000018BD44B34
		public ReplayController Replay() => default; // 0x000000018BD447E4-0x000000018BD4487C
		public bool Resize(long newBufferSize, long newMaxBufferSize = -1 /* Metadata: 0x0205C182 */) => default; // 0x000000018BD44740-0x000000018BD447E4
		public void Clear() {} // 0x000000018BD444F8-0x000000018BD44740
		public void Enable() {} // 0x000000018BD44378-0x000000018BD444F8
		public void Disable() {} // 0x000000018BD44050-0x000000018BD440F4
		public bool GetNextEvent(ref InputEventPtr current) => default; // 0x000000018BD4490C-0x000000018BD44AF0
		public IEnumerator<InputEventPtr> GetEnumerator() => default; // 0x000000018BD440F4-0x000000018BD44378
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BD43B50-0x000000018BD43EAC
		public void Dispose() {} // 0x000000018BD45ABC-0x000000018BD45CE4
		private void Allocate() {} // 0x000000018357A260-0x000000018357A270
		private void Release() {} // 0x00000001877900A4-0x00000001877900B4
		private void OnBeforeUpdate() {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		private void OnInputEvent(InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000181378230-0x0000000181378240
	}

	public struct StateEvent : IInputEventTypeInfo // TypeDefIndex: 45445
	{
		// Fields
		public const int Type = 1398030676; // Metadata: 0x0205C191
		internal const int kStateDataSizeToSubtract = 1; // Metadata: 0x0205C196
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		internal _stateData_e__FixedBuffer stateData; // 0x18
	
		// Properties
		public uint stateSizeInBytes { get => default; } // 0x0000000185FD8E90-0x0000000185FD8EA0 
		public unsafe void* state { get => default; } // 0x0000000185FCDB50-0x0000000185FCDB60 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8EA0-0x0000000185FD8EB0 
	
		// Nested types
		public struct _stateData_e__FixedBuffer // TypeDefIndex: 45444
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x0000000185779060-0x0000000185779070
		public TState GetState<TState>()
			where TState : struct, IInputStateTypeInfo => default;
		public static TState GetState<TState>(InputEventPtr ptr)
			where TState : struct, IInputStateTypeInfo => default;
		public static int GetEventSizeWithPayload<TState>()
			where TState : struct => default;
		public static unsafe StateEvent* From(InputEventPtr ptr) => default; // 0x000000018BD45380-0x000000018BD454C0
		internal static unsafe StateEvent* FromUnchecked(InputEventPtr ptr) => default; // 0x0000000185779060-0x0000000185779070
		public static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0205C18F */) {
			eventPtr = default;
			return default;
		} // 0x000000018BD45350-0x000000018BD45380
		public static NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0205C190 */) {
			eventPtr = default;
			return default;
		} // 0x000000018BD450A4-0x000000018BD450D4
		private static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState) {
			eventPtr = default;
			return default;
		} // 0x000000018BD450D4-0x000000018BD45350
	}

	public struct TextEvent : IInputEventTypeInfo // TypeDefIndex: 45446
	{
		// Fields
		public const int Type = 1413830740; // Metadata: 0x0205C1A7
		public InputEvent baseEvent; // 0x00
		public int character; // 0x14
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000185FD8EB0-0x0000000185FD8EC0 
	
		// Methods
		public static unsafe TextEvent* From(InputEventPtr eventPtr) => default; // 0x000000018BD457FC-0x000000018BD45938
		public static TextEvent Create(int deviceId, char character, double time = -1 /* Metadata: 0x0205C197 */) => default; // 0x000000018BD4572C-0x000000018BD45794
		public static TextEvent Create(int deviceId, int character, double time = -1 /* Metadata: 0x0205C19F */) => default; // 0x000000018BD45794-0x000000018BD457FC
	}

	internal delegate void InputUpdateDelegate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // TypeDefIndex: 45447; 0x00000001831C5680-0x00000001831C5690

	internal interface IInputRuntime // TypeDefIndex: 45448
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

	internal static class InputRuntime // TypeDefIndex: 45449
	{
		// Fields
		public static IInputRuntime s_Instance; // 0x00
		public static double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x08
	}

	internal static class InputRuntimeExtensions // TypeDefIndex: 45450
	{
		// Methods
		public static long DeviceCommand<TCommand>(IInputRuntime runtime, int deviceId, ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default;
	}

	[Serializable]
	public struct InputMetrics // TypeDefIndex: 45451
	{
		// Fields
		private int _maxNumDevices_k__BackingField; // 0x00
		private int _currentNumDevices_k__BackingField; // 0x04
		private int _maxStateSizeInBytes_k__BackingField; // 0x08
		private int _currentStateSizeInBytes_k__BackingField; // 0x0C
		private int _currentControlCount_k__BackingField; // 0x10
		private int _currentLayoutCount_k__BackingField; // 0x14
		private int _totalEventBytes_k__BackingField; // 0x18
		private int _totalEventCount_k__BackingField; // 0x1C
		private int _totalUpdateCount_k__BackingField; // 0x20
		private double _totalEventProcessingTime_k__BackingField; // 0x28
		private double _totalEventLagTime_k__BackingField; // 0x30
	
		// Properties
		public int maxNumDevices { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int currentNumDevices { get; set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int maxStateSizeInBytes { get; set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public int currentStateSizeInBytes { get; set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
		public int currentControlCount { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public int currentLayoutCount { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public int totalEventBytes { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int totalEventCount { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public int totalUpdateCount { get; set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public double totalEventProcessingTime { get; set; } // 0x0000000185FB0BC0-0x0000000185FB0BD0 0x0000000185FB0BD0-0x0000000185FB0BE0
		public double totalEventLagTime { get; set; } // 0x0000000181BD6170-0x0000000181BD61C0 0x0000000185FB0940-0x0000000185FB0950
		public float averageEventBytesPerFrame { get => default; } // 0x000000018BD3EA2C-0x000000018BD3EA44 
		public double averageProcessingTimePerEvent { get => default; } // 0x000000018BD3EA58-0x000000018BD3EA6C 
		public double averageLagTimePerEvent { get => default; } // 0x000000018BD3EA44-0x000000018BD3EA58 
	}

	public enum InputUpdateType // TypeDefIndex: 45452
	{
		None = 0,
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		Default = 11,
		Manual = 16
	}

	internal static class InputUpdate // TypeDefIndex: 45455
	{
		// Fields
		public static uint s_UpdateStepCount; // 0x00
		public static InputUpdateType s_LatestUpdateType; // 0x04
		public static UpdateStepCount s_PlayerUpdateStepCount; // 0x08
	
		// Nested types
		[Serializable]
		public struct UpdateStepCount // TypeDefIndex: 45453
		{
			// Fields
			private bool m_WasUpdated; // 0x00
			private uint _value_k__BackingField; // 0x04
	
			// Properties
			public uint value { get; private set; } // 0x0000000184582F00-0x0000000184582F80 0x0000000184F1CF40-0x0000000184F1CFC0
	
			// Methods
			public void OnBeforeUpdate() {} // 0x000000018BD41BC4-0x000000018BD41C10
			public void OnUpdate() {} // 0x0000000184D53CB0-0x0000000184D53D40
		}
	
		[Serializable]
		public struct SerializedState // TypeDefIndex: 45454
		{
			// Fields
			public InputUpdateType lastUpdateType; // 0x00
			public UpdateStepCount playerUpdateStepCount; // 0x04
		}
	
		// Methods
		internal static void OnBeforeUpdate(InputUpdateType type) {} // 0x0000000184112760-0x0000000184112780
		internal static void OnUpdate(InputUpdateType type) {} // 0x000000018457CB80-0x000000018457CB90
		public static SerializedState Save() => default; // 0x000000018357CBC0-0x000000018357CBD0
		public static void Restore(SerializedState state) {} // 0x0000000185FB2BA0-0x0000000185FB2BB0
		public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) => default; // 0x0000000185FD8EC0-0x0000000185FD8ED0
		public static bool IsPlayerUpdate(InputUpdateType updateType) => default; // 0x0000000184F1CFC0-0x0000000184F1D070
	}

	internal class NativeInputRuntime : IInputRuntime // TypeDefIndex: 45459
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
		public InputUpdateDelegate onUpdate { get => default; set {} } // 0x000000018BD42CF8-0x000000018BD42D38 0x0000000184D545F0-0x0000000184D54700
		public Action<InputUpdateType> onBeforeUpdate { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018BD42D70-0x000000018BD42E44
		public Func<InputUpdateType, bool> onShouldRunUpdate { get => default; set {} } // 0x00000001813FF010-0x00000001813FF020 0x0000000184D54900-0x0000000184D549B0
		public Action<int, string> onDeviceDiscovered { get => default; set {} } // 0x0000000186472690-0x0000000186472698 0x0000000185FB24B0-0x0000000185FB24C0
		public Action onShutdown { get => default; set {} } // 0x0000000184D54700-0x0000000184D54760 0x0000000184580800-0x0000000184580870
		public Action<bool> onPlayerFocusChanged { get => default; set {} } // 0x000000018BD42CB8-0x000000018BD42CF0 0x000000018457FB30-0x000000018457FB80
		public bool isPlayerFocused { get => default; } // 0x000000018647474C-0x0000000186474754 
		public float pollingFrequency { get => default; set {} } // 0x0000000184955400-0x0000000184955430 0x000000018184FBD0-0x000000018184FBE0
		public double currentTime { get => default; } // 0x0000000188052F3C-0x0000000188052F58 
		public double currentTimeForFixedUpdate { get => default; } // 0x000000018BD42C48-0x000000018BD42C6C 
		public double currentTimeOffsetToRealtimeSinceStartup { get => default; } // 0x0000000184952AD0-0x0000000184952E10 
		public float unscaledGameTime { get => default; } // 0x000000018BD42D38-0x000000018BD42D70 
		public bool runInBackground { get => default; set {} } // 0x000000018646E41C-0x000000018646E428 0x000000018BD42CF0-0x000000018BD42CF8
		public Vector2 screenSize { get => default; } // 0x000000018457CC10-0x000000018457CD30 
		public ScreenOrientation screenOrientation { get => default; } // 0x0000000185492010-0x0000000185492020 
		public bool isInBatchMode { get => default; } // 0x00000001850F19F0-0x00000001850F1A10 
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 45456
		{
			// Fields
			public InputUpdateDelegate value; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018BD42C08-0x000000018BD42C48
	
			// Methods
			internal unsafe void _set_onUpdate_b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) {} // 0x0000000185C57930-0x0000000185C57980
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 45457
		{
			// Fields
			public Action<InputUpdateType> value; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018BD42C6C-0x000000018BD42CB8
	
			// Methods
			internal void _set_onBeforeUpdate_b__0(NativeInputUpdateType updateType) {} // 0x00000001853CFBE0-0x00000001853CFC70
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 45458
		{
			// Fields
			public Func<InputUpdateType, bool> value; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal bool _set_onShouldRunUpdate_b__0(NativeInputUpdateType updateType) => default; // 0x0000000184D54A60-0x0000000184D54B70
		}
	
		// Constructors
		public NativeInputRuntime() {} // 0x0000000185492010-0x0000000185492020
		static NativeInputRuntime() {} // 0x0000000184F2F070-0x0000000184F2F090
	
		// Methods
		public int AllocateDeviceId() => default; // 0x00000001813B8590-0x00000001813B85A0
		public void Update(InputUpdateType updateType) {} // 0x0000000184111670-0x0000000184111790
		public unsafe void QueueEvent(InputEvent* ptr) {} // 0x00000001813B51D0-0x00000001813B51E0
		public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) => default; // 0x0000000184D54B70-0x0000000184D54C90
		private void OnShutdown() {} // 0x0000000185FD8DF0-0x0000000185FD8E00
		private bool OnWantsToShutdown() => default; // 0x0000000185F63A10-0x0000000185F63A80
		private void OnFocusChanged(bool focus) {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IInputStateCallbackReceiver // TypeDefIndex: 45460
	{
		// Methods
		void OnNextUpdate();
		void OnStateEvent(InputEventPtr eventPtr);
		bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
	}

	public interface IInputStateChangeMonitor // TypeDefIndex: 45461
	{
		// Methods
		void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);
		void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
	}

	public interface IInputStateTypeInfo // TypeDefIndex: 45462
	{
		// Properties
		FourCC format { get; }
	}

	public static class InputState // TypeDefIndex: 45464
	{
		// Properties
		public static InputUpdateType currentUpdateType { get; } // 0x000000018BD419F8-0x000000018BD41A58 
		public static uint updateCount { get; } // 0x000000018BD41AC8-0x000000018BD41B28 
		public static double currentTime { get; } // 0x000000018BD41440-0x000000018BD416D8 
	
		// Events
		public static event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onChange;
	
		// Nested types
		private class StateChangeMonitorDelegate : IInputStateChangeMonitor // TypeDefIndex: 45463
		{
			// Fields
			public Action<InputControl, double, InputEventPtr, long> valueChangeCallback; // 0x10
			public Action<InputControl, double, long, int> timerExpiredCallback; // 0x18
	
			// Constructors
			public StateChangeMonitorDelegate() {} // 0x00000001849549E0-0x0000000184954A40
	
			// Methods
			public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x000000018BD41A58-0x000000018BD41A90
			public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x000000018BD41A90-0x000000018BD41AC8
		}
	
		// Methods
		public static void Change(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0205C1B3 */) {} // 0x000000018BD416D8-0x000000018BD417F4
		public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0205C1B4 */, InputEventPtr eventPtr = default)
			where TState : struct {} // 0x0000000184BFB4A0-0x0000000184BFB570
		public static void Change<TState>(InputControl control, ref ref TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x0205C1B5 */, InputEventPtr eventPtr = default)
			where TState : struct {} // 0x000000018BD41340-0x000000018BD41440
		public static bool IsIntegerFormat(FourCC format) => default; // 0x000000018BD418C8-0x000000018BD419F8
		public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0205C1B6 */, uint groupIndex = 0 /* Metadata: 0x0205C1BE */) {} // 0x000000018BD4124C-0x000000018BD41340
		public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1 /* Metadata: 0x0205C1BF */, Action<InputControl, double, long, int> timerExpiredCallback = null) => default; // 0x000000018BD417F4-0x000000018BD418C8
		public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0205C1C0 */) {} // 0x000000018BD45050-0x000000018BD45078
		public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1 /* Metadata: 0x0205C1C8 */, int timerIndex = -1 /* Metadata: 0x0205C1D0 */) {} // 0x000000018BD45078-0x000000018BD450A4
		public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x0205C1D1 */, int timerIndex = -1 /* Metadata: 0x0205C1D9 */) {} // 0x0000000185492010-0x0000000185492020
	}

	public struct InputStateBlock // TypeDefIndex: 45465
	{
		// Fields
		public const uint InvalidOffset = 4294967295; // Metadata: 0x0205C1DA
		public const uint AutomaticOffset = 4294967294; // Metadata: 0x0205C1DB
		public static readonly FourCC FormatInvalid; // 0x00
		internal const int kFormatInvalid = 0; // Metadata: 0x0205C1DC
		public static readonly FourCC FormatBit; // 0x04
		internal const int kFormatBit = 1112101920; // Metadata: 0x0205C1DD
		public static readonly FourCC FormatSBit; // 0x08
		internal const int kFormatSBit = 1396853076; // Metadata: 0x0205C1E2
		public static readonly FourCC FormatInt; // 0x0C
		internal const int kFormatInt = 1229870112; // Metadata: 0x0205C1E7
		public static readonly FourCC FormatUInt; // 0x10
		internal const int kFormatUInt = 1430867540; // Metadata: 0x0205C1EC
		public static readonly FourCC FormatShort; // 0x14
		internal const int kFormatShort = 1397248596; // Metadata: 0x0205C1F1
		public static readonly FourCC FormatUShort; // 0x18
		internal const int kFormatUShort = 1431521364; // Metadata: 0x0205C1F6
		public static readonly FourCC FormatByte; // 0x1C
		internal const int kFormatByte = 1113150533; // Metadata: 0x0205C1FB
		public static readonly FourCC FormatSByte; // 0x20
		internal const int kFormatSByte = 1396857172; // Metadata: 0x0205C200
		public static readonly FourCC FormatLong; // 0x24
		internal const int kFormatLong = 1280198432; // Metadata: 0x0205C205
		public static readonly FourCC FormatULong; // 0x28
		internal const int kFormatULong = 1431064135; // Metadata: 0x0205C20A
		public static readonly FourCC FormatFloat; // 0x2C
		internal const int kFormatFloat = 1179407392; // Metadata: 0x0205C20F
		public static readonly FourCC FormatDouble; // 0x30
		internal const int kFormatDouble = 1145195552; // Metadata: 0x0205C214
		public static readonly FourCC FormatVector2; // 0x34
		internal const int kFormatVector2 = 1447379762; // Metadata: 0x0205C219
		public static readonly FourCC FormatVector3; // 0x38
		internal const int kFormatVector3 = 1447379763; // Metadata: 0x0205C21E
		public static readonly FourCC FormatQuaternion; // 0x3C
		internal const int kFormatQuaternion = 1364541780; // Metadata: 0x0205C223
		public static readonly FourCC FormatVector2Short; // 0x40
		public static readonly FourCC FormatVector3Short; // 0x44
		public static readonly FourCC FormatVector2Byte; // 0x48
		public static readonly FourCC FormatVector3Byte; // 0x4C
		public static readonly FourCC FormatPose; // 0x50
		internal const int kFormatPose = 1349481317; // Metadata: 0x0205C228
		private FourCC _format_k__BackingField; // 0x00
		internal uint m_ByteOffset; // 0x04
		private uint _bitOffset_k__BackingField; // 0x08
		private uint _sizeInBits_k__BackingField; // 0x0C
	
		// Properties
		public FourCC format { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public uint byteOffset { get => default; set {} } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public uint bitOffset { get; set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public uint sizeInBits { get; set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
		internal uint alignedSizeInBytes { get => default; } // 0x00000001845808B0-0x0000000184580900 
		internal uint effectiveByteOffset { get => default; } // 0x000000018BD3FF94-0x000000018BD3FFE0 
		internal uint effectiveBitOffset { get => default; } // 0x000000018BD3FF48-0x000000018BD3FF94 
	
		// Constructors
		static InputStateBlock() {
			FormatInvalid = default;
			FormatBit = default;
			FormatSBit = default;
			FormatInt = default;
			FormatUInt = default;
			FormatShort = default;
			FormatUShort = default;
			FormatByte = default;
			FormatSByte = default;
			FormatLong = default;
			FormatULong = default;
			FormatFloat = default;
			FormatDouble = default;
			FormatVector2 = default;
			FormatVector3 = default;
			FormatQuaternion = default;
			FormatVector2Short = default;
			FormatVector3Short = default;
			FormatVector2Byte = default;
			FormatVector3Byte = default;
			FormatPose = default;
		} // 0x0000000185D22DD0-0x0000000185D22FB0
	
		// Methods
		public static int GetSizeOfPrimitiveFormatInBits(FourCC type) => default; // 0x000000018BD3F248-0x000000018BD3F4BC
		public static FourCC GetPrimitiveFormatFromType(System.Type type) => default; // 0x000000018BD3EDD0-0x000000018BD3F248
		public unsafe int ReadInt(void* statePtr) => default; // 0x0000000184FCBC20-0x0000000184FCBD00
		public unsafe void WriteInt(void* statePtr, int value) {} // 0x000000018BD3FD44-0x000000018BD3FF48
		public unsafe float ReadFloat(void* statePtr) => default; // 0x0000000184C57AC0-0x0000000184C57BF0
		public unsafe void WriteFloat(void* statePtr, float value) {} // 0x000000018BD3FA70-0x000000018BD3FD44
		internal PrimitiveValue FloatToPrimitiveValue(float value) => default; // 0x000000018BD3EA6C-0x000000018BD3EDD0
		public unsafe double ReadDouble(void* statePtr) => default; // 0x000000018BD3F4BC-0x000000018BD3F770
		public unsafe void WriteDouble(void* statePtr, double value) {} // 0x000000018BD3F770-0x000000018BD3FA70
		public unsafe void Write(void* statePtr, PrimitiveValue value) {} // 0x0000000184002D60-0x0000000184002E00
		public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr) {} // 0x0000000185B97AB0-0x0000000185B97BA0
	}

	internal struct InputStateBuffers // TypeDefIndex: 45467
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
		internal struct DoubleBuffers // TypeDefIndex: 45466
		{
			// Fields
			public unsafe void** deviceToBufferMapping; // 0x00
			public int deviceCount; // 0x08
	
			// Properties
			public bool valid { get => default; } // 0x000000018457CB10-0x000000018457CB40 
	
			// Methods
			public unsafe void SetFrontBuffer(int deviceIndex, void* ptr) {} // 0x0000000184581A50-0x0000000184581AB0
			public unsafe void SetBackBuffer(int deviceIndex, void* ptr) {} // 0x0000000185EF5060-0x0000000185EF50B0
			public unsafe void* GetFrontBuffer(int deviceIndex) => default; // 0x000000018457CAB0-0x000000018457CB10
			public unsafe void* GetBackBuffer(int deviceIndex) => default; // 0x0000000184112A60-0x0000000184112B70
			public void SwapBuffers(int deviceIndex) {} // 0x0000000184112B70-0x0000000184112C10
		}
	
		// Methods
		public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) => default; // 0x0000000184112780-0x0000000184112860
		public static unsafe void* GetFrontBufferForDevice(int deviceIndex) => default; // 0x0000000184112C10-0x0000000184112DD0
		public static unsafe void* GetBackBufferForDevice(int deviceIndex) => default; // 0x0000000184112860-0x0000000184112A60
		public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) {} // 0x0000000184112E30-0x0000000184112F60
		public void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount) {} // 0x0000000184112DD0-0x0000000184112E30
		private static unsafe DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer) => default; // 0x0000000184112F60-0x0000000184112FF0
		public void FreeAll() {} // 0x000000018457FC00-0x000000018457FC10
		public void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) {} // 0x000000018457FBC0-0x000000018457FBE0
		private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) {} // 0x000000018457FBE0-0x000000018457FC00
		private static unsafe void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer) {} // 0x0000000184581AB0-0x0000000184581AD0
		private static uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount) => default; // 0x000000018457FC10-0x000000018457FC30
		private static uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018457FC30-0x000000018457FC90
	}

	public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IInputStateChangeMonitor // TypeDefIndex: 45473
	{
		// Fields
		private const int kDefaultHistorySize = 128; // Metadata: 0x0205C22D
		private Action<Record> _onRecordAdded_k__BackingField; // 0x10
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
		public int Count { get => default; } // 0x000000018BD406A8-0x000000018BD406BC 
		public uint version { get => default; } // 0x0000000185FD8DE0-0x0000000185FD8DF0 
		public int historyDepth { get => default; set {} } // 0x000000018BD404BC-0x000000018BD405B0 0x000000018BD40468-0x000000018BD404BC
		public int extraMemoryPerRecord { get => default; set {} } // 0x000000018BD40058-0x000000018BD400F0 
		public InputUpdateType updateMask { get => default; set {} } // 0x000000018BD405B0-0x000000018BD406A8 0x000000018BD40CB4-0x000000018BD40D68
		public ReadOnlyArray<InputControl> controls { get => default; } // 0x0000000185492010-0x0000000185492020 
		public Record this[int index] { get => default; set {} } // 0x000000018BD4105C-0x000000018BD41084 0x0000000188D0855C-0x0000000188D08578
		public Action<Record> onRecordAdded { get; set; } // 0x0000000188D5D9D8-0x0000000188D5DA04 0x0000000185FC1C50-0x0000000185FC1C60
		public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange { get; set; } // 0x000000018BD39018-0x000000018BD39054 0x000000018BD38F90-0x000000018BD38FE8
		internal int bytesPerRecord { get => default; } // 0x000000018BD4379C-0x000000018BD43860 
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 45468
		{
			// Fields
			private readonly InputStateHistory m_History; // 0x00
			private int m_Index; // 0x08
	
			// Properties
			public Record Current { get => default; } // 0x0000000184950AF0-0x0000000184950B40 
			object IEnumerator.Current { get => default; } // 0x0000000185FB06E0-0x0000000185FB06F0 
	
			// Constructors
			public Enumerator(InputStateHistory history) : this() {
				m_History = default;
				m_Index = default;
			} // 0x0000000183908D10-0x0000000183908D20
	
			// Methods
			public bool MoveNext() => default; // 0x0000000185FB0670-0x0000000185FB0680
			public void Reset() {} // 0x0000000185FB0570-0x0000000185FB0580
			public void Dispose() {} // 0x0000000184950AA0-0x0000000184950AF0
		}
	
		protected internal struct RecordHeader // TypeDefIndex: 45471
		{
			// Fields
			public double time; // 0x00
			public uint version; // 0x08
			public int controlIndex; // 0x0C
			private _m_StateWithoutControlIndex_e__FixedBuffer m_StateWithoutControlIndex; // 0x0C
			private _m_StateWithControlIndex_e__FixedBuffer m_StateWithControlIndex; // 0x10
			public const int kSizeWithControlIndex = 16; // Metadata: 0x0205C22F
			public const int kSizeWithoutControlIndex = 12; // Metadata: 0x0205C230
	
			// Properties
			public unsafe byte* statePtrWithControlIndex { get => default; } // 0x000000018BD41084-0x000000018BD41108 
			public unsafe byte* statePtrWithoutControlIndex { get => default; } // 0x0000000184950A40-0x0000000184950AA0 
	
			// Nested types
			public struct _m_StateWithoutControlIndex_e__FixedBuffer // TypeDefIndex: 45469
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct _m_StateWithControlIndex_e__FixedBuffer // TypeDefIndex: 45470
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 45472
		{
			// Fields
			private readonly InputStateHistory m_Owner; // 0x00
			private readonly int m_IndexPlusOne; // 0x08
			private uint m_Version; // 0x0C
	
			// Properties
			internal unsafe RecordHeader* header { get => default; } // 0x0000000184BFB440-0x0000000184BFB4A0 
			internal int recordIndex { get => default; } // 0x000000018BD40F38-0x000000018BD4105C 
			internal uint version { get => default; } // 0x000000018BD41108-0x000000018BD4124C 
			public bool valid { get => default; } // 0x000000018346D130-0x000000018346D140 
			public InputStateHistory owner { get => default; } // 0x0000000184096E30-0x0000000184096EF0 
			public int index { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			public double time { get => default; } // 0x0000000184088E70-0x0000000184088E80 
			public InputControl control { get => default; } // 0x0000000185B3F7E0-0x0000000185B3F830 
			public Record next { get => default; } // 0x000000018BD40DDC-0x000000018BD40F38 
			public Record previous { get => default; } // 0x000000018598A510-0x000000018598A5B0 
	
			// Constructors
			internal unsafe Record(InputStateHistory owner, int index, RecordHeader* header) : this() {
				m_Owner = default;
				m_IndexPlusOne = default;
				m_Version = default;
			} // 0x000000018BD40D68-0x000000018BD40DDC
	
			// Methods
			public TValue ReadValue<TValue>()
				where TValue : struct => default; // 0x000000018BD40398-0x000000018BD40408
			public object ReadValueAsObject() => default; // 0x0000000185FD8DD0-0x0000000185FD8DE0
			public unsafe void* GetUnsafeMemoryPtr() => default; // 0x000000018BD3FFE0-0x000000018BD40058
			internal unsafe void* GetUnsafeMemoryPtrUnchecked() => default; // 0x0000000184BFB030-0x0000000184BFB440
			public unsafe void* GetUnsafeExtraMemoryPtr() => default; // 0x000000018BD40B80-0x000000018BD40CAC
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked() => default; // 0x000000018BD406BC-0x000000018BD408B0
			public void CopyFrom(Record record) {} // 0x000000018BD408B0-0x000000018BD40B80
			internal void CheckValid() {} // 0x000000018BD40408-0x000000018BD40468
			public bool Equals(Record other) => default; // 0x000000018BD40CAC-0x000000018BD40CB4
			public override bool Equals(object obj) => default; // 0x000000018BD40344-0x000000018BD40398
			public override int GetHashCode() => default; // 0x000000018BD402EC-0x000000018BD40344
			public override string ToString() => default; // 0x000000018BD400F0-0x000000018BD402EC
		}
	
		// Constructors
		public InputStateHistory() {} // Dummy constructor
		public InputStateHistory(int maxStateSizeInBytes) {} // 0x0000000185492010-0x0000000185492020
		public InputStateHistory(string path) {} // 0x0000000185FB6BE0-0x0000000185FB6BF0
		public InputStateHistory(InputControl control) {} // 0x0000000185FD1760-0x0000000185FD1770
		public InputStateHistory(IEnumerable<InputControl> controls) {} // 0x000000018BD4390C-0x000000018BD43934
	
		// Methods
		~InputStateHistory() {} // 0x0000000185FC9E60-0x0000000185FC9E70
		public void Clear() {} // 0x00000001834AFB70-0x00000001834AFB80
		public Record AddRecord(Record record) => default; // 0x000000018BD43B10-0x000000018BD43B50
		public void StartRecording() {} // 0x00000001834AFB60-0x00000001834AFB70
		public void StopRecording() {} // 0x000000018BD43934-0x000000018BD43964
		public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) => default; // 0x000000018BD43AE0-0x000000018BD43B10
		public unsafe Record RecordStateChange(InputControl control, void* statePtr, double time) => default; // 0x000000018BD43860-0x000000018BD4390C
		public IEnumerator<Record> GetEnumerator() => default; // 0x000000018BD43964-0x000000018BD43A24
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BD43A24-0x000000018BD43AE0
		public void Dispose() {} // 0x0000000189C61CA8-0x0000000189C61CD8
		protected void Destroy() {}
		private void Allocate() {} // 0x000000018BD43758-0x000000018BD4379C
		protected internal int RecordIndexToUserIndex(int index) => default; // 0x000000018BD43738-0x000000018BD43758
		protected internal int UserIndexToRecordIndex(int index) => default; // 0x000000018BD436B8-0x000000018BD43738
		protected internal unsafe RecordHeader* GetRecord(int index) => default; // 0x000000018BD43698-0x000000018BD436B8
		internal unsafe RecordHeader* GetRecordUnchecked(int index) => default; // 0x000000018BD435EC-0x000000018BD43698
		protected internal unsafe RecordHeader* AllocateRecord(out int index) {
			index = default;
			return default;
		} // 0x000000018BD43170-0x000000018BD4357C
		protected unsafe TValue ReadValue<TValue>(RecordHeader* data)
			where TValue : struct => default; // 0x000000018BD43098-0x000000018BD43170
		protected unsafe object ReadValueAsObject(RecordHeader* data) => default; // 0x00000001898A4CD8-0x00000001898A4CF8
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x000000018BD4357C-0x000000018BD435EC
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x0000000189C617F8-0x0000000189C6182C
	}

	public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>> // TypeDefIndex: 45476
		where TValue : struct
	{
		// Properties
		public new Record this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 45474
		{
			// Fields
			private readonly InputStateHistory<TValue> m_History;
			private int m_Index;
	
			// Properties
			public Record<TValue> Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(InputStateHistory<TValue> history) : this() {
				m_History = default;
				m_Index = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 45475
		{
			// Fields
			private readonly InputStateHistory<TValue> m_Owner;
			private readonly int m_IndexPlusOne;
			private uint m_Version;
	
			// Properties
			internal unsafe InputStateHistory.RecordHeader* header { get => default; }
			internal int recordIndex { get => default; }
			public bool valid { get => default; }
			public InputStateHistory<TValue> owner { get => default; }
			public int index { get => default; }
			public double time { get => default; }
			public InputControl<TValue> control { get => default; }
			public Record<TValue> next { get => default; }
			public Record<TValue> previous { get => default; }
	
			// Constructors
			internal unsafe Record(InputStateHistory<TValue> owner, int index, InputStateHistory.RecordHeader* header) : this() {
				m_Owner = default;
				m_IndexPlusOne = default;
				m_Version = default;
			}
			internal Record(InputStateHistory<TValue> owner, int index) : this() {
				m_Owner = default;
				m_IndexPlusOne = default;
				m_Version = default;
			}
	
			// Methods
			public TValue ReadValue() => default;
			public unsafe void* GetUnsafeMemoryPtr() => default;
			internal unsafe void* GetUnsafeMemoryPtrUnchecked() => default;
			public unsafe void* GetUnsafeExtraMemoryPtr() => default;
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked() => default;
			public void CopyFrom(Record<TValue> record) {}
			private void CheckValid() {}
			public bool Equals(Record<TValue> other) => default;
			public override bool Equals(object obj) => default;
			public override int GetHashCode() => default;
			public override string ToString() => default;
		}
	
		// Constructors
		public InputStateHistory() {} // Dummy constructor
		public InputStateHistory(int? maxStateSizeInBytes = default) {}
		public InputStateHistory(InputControl<TValue> control) {}
		public InputStateHistory(string path) {}
	
		// Methods
		~InputStateHistory() {}
		public Record AddRecord(Record record) => default;
		public Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x0205C231 */) => default;
		public new IEnumerator<Record> GetEnumerator() => default;
		new IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal class SelectObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 45478
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, TResult> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 45477
		{
			// Fields
			private SelectObservable<TSource, TResult> m_Observable;
			private readonly IObserver<TResult> m_Observer;
	
			// Constructors
			public Select() {} // Dummy constructor
			public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer) {}
	
			// Methods
			public void OnCompleted() {}
			public void OnError(Exception error) {}
			public void OnNext(TSource evt) {}
		}
	
		// Constructors
		public SelectObservable() {} // Dummy constructor
		public SelectObservable(IObservable<TSource> source, Func<TSource, TResult> filter) {}
	
		// Methods
		public IDisposable Subscribe(IObserver<TResult> observer) => default;
	}
}

namespace UnityEngine.InputSystem.OnScreen
{
	public class OnScreenButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 45298
	{
		// Fields
		private string m_ControlPath; // 0x30
	
		// Properties
		protected override string controlPathInternal { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public OnScreenButton() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018BD20438-0x000000018BD20474
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018BD203F4-0x000000018BD20438
	}

	public abstract class OnScreenControl : MonoBehaviour // TypeDefIndex: 45300
	{
		// Fields
		private InputControl m_Control; // 0x18
		private OnScreenControl m_NextControlOnDevice; // 0x20
		private InputEventPtr m_InputEventPtr; // 0x28
		private static int s_nbActiveInstances; // 0x00
		private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; // 0x08
	
		// Properties
		public string controlPath { get; set; }
		public InputControl control { get; } // 0x000000018BD20AB8-0x000000018BD212D4 
		protected abstract string controlPathInternal { get; set; } // 0x000000018BD20A20-0x000000018BD20AB8
		internal static bool HasAnyActive { get; } // 0x000000018BD20474-0x000000018BD204BC 
	
		// Nested types
		private struct OnScreenDeviceInfo // TypeDefIndex: 45299
		{
			// Fields
			public InputEventPtr eventPtr; // 0x00
			public NativeArray<byte> buffer; // 0x08
			public UnityEngine.InputSystem.InputDevice device; // 0x18
			public OnScreenControl firstControl; // 0x20
	
			// Methods
			public OnScreenDeviceInfo AddControl(OnScreenControl control) => default; // 0x00000001864738F0-0x0000000186473900
			public OnScreenDeviceInfo RemoveControl(OnScreenControl control) => default; // 0x000000018BD21310-0x000000018BD2134C
			public void Destroy() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		protected OnScreenControl() {} // 0x000000018BD213A8-0x000000018BD21444
	
		// Methods
		private void SetupInputControl() {} // 0x000000018BD212D4-0x000000018BD21310
		protected void SendValueToControl<TValue>(TValue value)
			where TValue : struct {} // 0x000000018BD20740-0x000000018BD20A20
		protected void SentDefaultValueToControl() {} // 0x000000018BD204BC-0x000000018BD20740
		protected virtual void OnEnable() {} // 0x000000018646DB20-0x000000018646DB28
		protected virtual void OnDisable() {} // 0x000000018BD2134C-0x000000018BD213A8
		internal string GetWarningMessage() => default; // 0x000000018BD21444-0x000000018BD21580
	}

	internal static class UGUIOnScreenControlUtils // TypeDefIndex: 45301
	{
		// Methods
		public static RectTransform GetCanvasRectTransform(Transform transform) => default; // 0x000000018BD2578C-0x000000018BD25824
	}

	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 45303
	{
		// Fields
		private const string kDynamicOriginClickable = "DynamicOriginClickable"; // Metadata: 0x0205BF05
		private float m_MovementRange; // 0x30
		private float m_DynamicOriginRange; // 0x34
		private string m_ControlPath; // 0x38
		private Behaviour m_Behaviour; // 0x40
		private bool m_UseIsolatedInputActions; // 0x44
		private InputAction m_PointerDownAction; // 0x48
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
		public float movementRange { get => default; set {} } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x0000000185FB0BF0-0x0000000185FB0C00
		public float dynamicOriginRange { get => default; set {} } // 0x0000000185FB8060-0x0000000185FB8070 0x000000018BD23218-0x000000018BD23234
		public bool useIsolatedInputActions { get => default; set {} } // 0x0000000185FB08A0-0x0000000185FB08B0 0x0000000185FB08B0-0x0000000185FB08C0
		protected override string controlPathInternal { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public Behaviour behaviour { get => default; set {} } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
	
		// Nested types
		public enum Behaviour // TypeDefIndex: 45302
		{
			RelativePositionWithStaticOrigin = 0,
			ExactPositionWithStaticOrigin = 1,
			ExactPositionWithDynamicOrigin = 2
		}
	
		// Constructors
		public OnScreenStick() {} // 0x000000018BD23200-0x000000018BD23218
	
		// Methods
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018BD22758-0x000000018BD22810
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BD21E30-0x000000018BD21EE8
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018BD22A20-0x000000018BD22A30
		private void Start() {} // 0x000000018BD22A30-0x000000018BD230D8
		private void OnDestroy() {} // 0x000000018BD21D98-0x000000018BD21E30
		private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) {} // 0x000000018BD21580-0x000000018BD21750
		private void MoveStick(Vector2 pointerPosition, Camera uiCamera) {} // 0x000000018BD21A64-0x000000018BD21D98
		private void EndInteraction() {} // 0x000000018BD21890-0x000000018BD21954
		private void OnPointerDown(InputAction.CallbackContext ctx) {} // 0x000000018BD2211C-0x000000018BD22758
		private void OnPointerChanged(InputAction.CallbackContext ctx) {} // 0x000000018BD220C4-0x000000018BD2211C
		private void OnPointerMove(InputAction.CallbackContext ctx) {} // 0x000000018BD22810-0x000000018BD22914
		private void OnPointerUp(InputAction.CallbackContext ctx) {} // 0x000000018BD22914-0x000000018BD22A20
		private Camera GetCameraFromCanvas() => default; // 0x000000018BD21954-0x000000018BD21A64
		private void OnDrawGizmosSelected() {} // 0x000000018BD21EE8-0x000000018BD220C4
		private void DrawGizmoCircle(Vector2 center, float radius) {} // 0x000000018BD21750-0x000000018BD21890
		private void UpdateDynamicOriginClickableArea() {} // 0x000000018BD230D8-0x000000018BD23200
	}
}

namespace UnityEngine.InputSystem.Processors
{
	public class AxisDeadzoneProcessor : InputProcessor<float> // TypeDefIndex: 45479
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get => default; } // 0x000000018BD35AB4-0x000000018BD35B14 
		private float maxOrDefault { get => default; } // 0x000000018BD35A54-0x000000018BD35AB4 
	
		// Constructors
		public AxisDeadzoneProcessor() {} // 0x000000018BD35A2C-0x000000018BD35A54
	
		// Methods
		public override float Process(float value, InputControl control = null) => default; // 0x000000018BD35920-0x000000018BD35990
		public override string ToString() => default; // 0x000000018BD35990-0x000000018BD35A2C
	}

	public class ClampProcessor : InputProcessor<float> // TypeDefIndex: 45480
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Constructors
		public ClampProcessor() {} // 0x000000018BD36070-0x000000018BD36098
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x000000018BD35FC4-0x000000018BD35FE0
		public override string ToString() => default; // 0x000000018BD35FE0-0x000000018BD36070
	}

	internal class CompensateDirectionProcessor : InputProcessor<Vector3> // TypeDefIndex: 45481
	{
		// Properties
		public override CachingPolicy cachingPolicy { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public CompensateDirectionProcessor() {} // 0x000000018BD36E4C-0x000000018BD36E74
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x000000018BD36CF0-0x000000018BD36E20
		public override string ToString() => default; // 0x000000018BD36E20-0x000000018BD36E4C
	}

	internal class CompensateRotationProcessor : InputProcessor<Quaternion> // TypeDefIndex: 45482
	{
		// Properties
		public override CachingPolicy cachingPolicy { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public CompensateRotationProcessor() {} // 0x000000018BD36FA0-0x000000018BD36FC8
	
		// Methods
		public override Quaternion Process(Quaternion value, InputControl control) => default; // 0x000000018BD36E74-0x000000018BD36F74
		public override string ToString() => default; // 0x000000018BD36F74-0x000000018BD36FA0
	}

	public class InvertProcessor : InputProcessor<float> // TypeDefIndex: 45483
	{
		// Constructors
		public InvertProcessor() {} // 0x000000018BD41C3C-0x000000018BD41C64
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000185FD2810-0x0000000185FD2820
		public override string ToString() => default; // 0x000000018BD41C10-0x000000018BD41C3C
	}

	public class InvertVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 45484
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
	
		// Constructors
		public InvertVector2Processor() {} // 0x000000018BD41D44-0x000000018BD41D80
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x000000018BD41C64-0x000000018BD41CBC
		public override string ToString() => default; // 0x000000018BD41CBC-0x000000018BD41D44
	}

	public class InvertVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 45485
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
		public bool invertZ; // 0x12
	
		// Constructors
		public InvertVector3Processor() {} // 0x000000018BD41E90-0x000000018BD41EC8
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x000000018BD41D80-0x000000018BD41DDC
		public override string ToString() => default; // 0x000000018BD41DDC-0x000000018BD41E90
	}

	public class NormalizeProcessor : InputProcessor<float> // TypeDefIndex: 45486
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
		public float zero; // 0x18
	
		// Constructors
		public NormalizeProcessor() {} // 0x000000018BD42F80-0x000000018BD42FA8
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x000000018BD42E94-0x000000018BD42EC0
		public static float Normalize(float value, float min, float max, float zero) => default; // 0x00000001840034D0-0x0000000184003540
		internal static float Denormalize(float value, float min, float max, float zero) => default; // 0x000000018BD42E44-0x000000018BD42E94
		public override string ToString() => default; // 0x000000018BD42EC0-0x000000018BD42F80
	}

	public class NormalizeVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 45487
	{
		// Constructors
		public NormalizeVector2Processor() {} // 0x000000018BD42FEC-0x000000018BD43014
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x000000018BD42FA8-0x000000018BD42FC0
		public override string ToString() => default; // 0x000000018BD42FC0-0x000000018BD42FEC
	}

	public class NormalizeVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 45488
	{
		// Constructors
		public NormalizeVector3Processor() {} // 0x000000018BD43070-0x000000018BD43098
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x000000018BD43014-0x000000018BD43044
		public override string ToString() => default; // 0x000000018BD43044-0x000000018BD43070
	}

	public class ScaleProcessor : InputProcessor<float> // TypeDefIndex: 45489
	{
		// Fields
		public float factor; // 0x10
	
		// Constructors
		public ScaleProcessor() {} // 0x000000018BD44E38-0x000000018BD44E74
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000185FD8E10-0x0000000185FD8E20
		public override string ToString() => default; // 0x000000018BD44DD4-0x000000018BD44E38
	}

	public class ScaleVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 45490
	{
		// Fields
		public float x; // 0x10
		public float y; // 0x14
	
		// Constructors
		public ScaleVector2Processor() {} // 0x000000018BD44F04-0x000000018BD44F50
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x0000000185FD8E20-0x0000000185FD8E50
		public override string ToString() => default; // 0x000000018BD44E74-0x000000018BD44F04
	}

	public class ScaleVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 45491
	{
		// Fields
		public float x; // 0x10
		public float y; // 0x14
		public float z; // 0x18
	
		// Constructors
		public ScaleVector3Processor() {} // 0x000000018BD45010-0x000000018BD45050
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x0000000185FD8E50-0x0000000185FD8E90
		public override string ToString() => default; // 0x000000018BD44F50-0x000000018BD45010
	}

	public class StickDeadzoneProcessor : InputProcessor<Vector2> // TypeDefIndex: 45492
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get => default; } // 0x000000018BD456CC-0x000000018BD4572C 
		private float maxOrDefault { get => default; } // 0x000000018BD4566C-0x000000018BD456CC 
	
		// Constructors
		public StickDeadzoneProcessor() {} // 0x000000018BD45644-0x000000018BD4566C
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control = null) => default; // 0x000000018BD45530-0x000000018BD455A8
		private float GetDeadZoneAdjustedValue(float value) => default; // 0x000000018BD454C0-0x000000018BD45530
		public override string ToString() => default; // 0x000000018BD455A8-0x000000018BD45644
	}
}

namespace UnityEngine.InputSystem.Switch
{
	public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor // TypeDefIndex: 45294
	{
		// Fields
		private ButtonControl _captureButton_k__BackingField; // 0x210
		private ButtonControl _homeButton_k__BackingField; // 0x218
		private static readonly SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence; // 0x00
		private int m_HandshakeStepIndex; // 0x220
		private double m_HandshakeTimer; // 0x228
		internal const byte JitterMaskLow = 120; // Metadata: 0x0205BEDC
		internal const byte JitterMaskHigh = 135; // Metadata: 0x0205BEDD
	
		// Properties
		public ButtonControl captureButton { get; protected set; } // 0x000000018BD23E5C-0x000000018BD23FE0 0x00000001864734FC-0x0000000186473504
		public ButtonControl homeButton { get; protected set; } // 0x000000018BD23FE0-0x000000018BD2406C 0x000000018BD235A4-0x000000018BD2381C
	
		// Nested types
		private struct SwitchInputOnlyReport // TypeDefIndex: 45285
		{
			// Fields
			public const int kSize = 7; // Metadata: 0x0205BEDE
			public byte buttons0; // 0x00
			public byte buttons1; // 0x01
			public byte hat; // 0x02
			public byte leftX; // 0x03
			public byte leftY; // 0x04
			public byte rightX; // 0x05
			public byte rightY; // 0x06
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000185FB83A0-0x0000000185FB83B0
		}
	
		private struct SwitchSimpleInputReport // TypeDefIndex: 45286
		{
			// Fields
			public const int kSize = 12; // Metadata: 0x0205BEDF
			public const byte ExpectedReportId = 63; // Metadata: 0x0205BEE0
			public byte reportId; // 0x00
			public byte buttons0; // 0x01
			public byte buttons1; // 0x02
			public byte hat; // 0x03
			public ushort leftX; // 0x04
			public ushort leftY; // 0x06
			public ushort rightX; // 0x08
			public ushort rightY; // 0x0A
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000187A475DC-0x0000000187A475F0
		}
	
		private struct SwitchFullInputReport // TypeDefIndex: 45287
		{
			// Fields
			public const int kSize = 25; // Metadata: 0x0205BEE1
			public const byte ExpectedReportId = 48; // Metadata: 0x0205BEE2
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
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000185FB8830-0x0000000185FB8840
		}
	
		private struct SwitchHIDGenericInputReport // TypeDefIndex: 45288
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get => default; } // 0x0000000187A47B2C-0x0000000187A47B40 
		}
	
		internal struct SwitchMagicOutputReport // TypeDefIndex: 45291
		{
			// Fields
			public const int kSize = 49; // Metadata: 0x0205BEE3
			public const byte ExpectedReplyInputReportId = 129; // Metadata: 0x0205BEE4
			public byte reportType; // 0x00
			public byte commandId; // 0x01
	
			// Nested types
			internal enum ReportType // TypeDefIndex: 45289
			{
				Magic = 128
			}
	
			public enum CommandIdType // TypeDefIndex: 45290
			{
				Status = 1,
				Handshake = 2,
				Highspeed = 3,
				ForceUSB = 4
			}
		}
	
		internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo // TypeDefIndex: 45292
		{
			// Fields
			public const int kSize = 57; // Metadata: 0x0205BEEB
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get => default; } // 0x000000018BD23C54-0x000000018BD23CFC 
			public FourCC typeStatic { get => default; } // 0x000000018BD239B8-0x000000018BD23A14 
	
			// Methods
			public static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type) => default; // 0x000000018BD23A14-0x000000018BD23C54
		}
	
		internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo // TypeDefIndex: 45293
		{
			// Fields
			public const int kSize = 72; // Metadata: 0x0205BEEC
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get => default; } // 0x000000018BD23CFC-0x000000018BD23D04 
			public FourCC typeStatic { get => default; } // 0x000000018BD23D04-0x000000018BD23E5C 
	
			// Methods
			public static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		// Constructors
		public SwitchProControllerHID() {} // 0x0000000185FD82E0-0x0000000185FD82F0
		static SwitchProControllerHID() {} // 0x0000000185FD82F0-0x0000000185FD8350
	
		// Methods
		protected override void OnAdded() {} // 0x000000018BD2406C-0x000000018BD2433C
		private void HandshakeRestart() {} // 0x000000018BD23338-0x000000018BD235A4
		private void HandshakeTick() {} // 0x0000000185FD8270-0x0000000185FD8280
		public void OnNextUpdate() {} // 0x0000000185FD82E0-0x0000000185FD82F0
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000185FD82E0-0x0000000185FD82F0
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x0000000185FD8280-0x0000000185FD82E0
		public bool PreProcessEvent(InputEventPtr eventPtr) => default; // 0x0000000185FD82E0-0x0000000185FD82F0
	}

	internal static class SwitchSupportHID // TypeDefIndex: 45295
	{
		// Methods
		public static void Initialize() {} // 0x0000000184D55990-0x0000000184D561B0
	}
}

namespace UnityEngine.InputSystem.Switch.LowLevel
{
	internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo // TypeDefIndex: 45297
	{
		// Fields
		public static FourCC Format; // 0x00
		public byte leftStickX; // 0x00
		public byte leftStickY; // 0x01
		public byte rightStickX; // 0x02
		public byte rightStickY; // 0x03
		public ushort buttons1; // 0x04
		public byte buttons2; // 0x06
	
		// Properties
		public FourCC format { get => default; } // 0x000000018BD23968-0x000000018BD239B8 
	
		// Nested types
		public enum Button // TypeDefIndex: 45296
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
		static SwitchProControllerHIDInputState() {
			Format = default;
		} // 0x000000018BD2392C-0x000000018BD23968
	
		// Methods
		public SwitchProControllerHIDInputState WithButton(Button button, bool value = true /* Metadata: 0x0205BEEE */) => default; // 0x000000018BD238CC-0x000000018BD2392C
		public void Set(Button button, bool state) {} // 0x000000018BD1C7B8-0x000000018BD1CAEC
		public void Press(Button button) {} // 0x000000018BD2381C-0x000000018BD23874
		public void Release(Button button) {} // 0x000000018BD23874-0x000000018BD238CC
	}
}

namespace UnityEngine.InputSystem.UI
{
	internal class BaseInputOverride : BaseInput // TypeDefIndex: 45265
	{
		// Fields
		private readonly string _compositionString_k__BackingField; // 0x18
	
		// Properties
		public override string compositionString { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public BaseInputOverride() {} // 0x000000018646DB20-0x000000018646DB28
	}

	internal class ExtendedAxisEventData : AxisEventData, INavigationEventData // TypeDefIndex: 45266
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x30
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public ExtendedAxisEventData() {} // Dummy constructor
		public ExtendedAxisEventData(EventSystem eventSystem) {} // 0x000000018BD1CD1C-0x000000018BD1CD24
	
		// Methods
		public override string ToString() => default; // 0x000000018BD1CC84-0x000000018BD1CD1C
	}

	public class ExtendedPointerEventData : PointerEventData // TypeDefIndex: 45267
	{
		// Fields
		private InputControl _control_k__BackingField; // 0x160
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x168
		private int _touchId_k__BackingField; // 0x170
		private UIPointerType _pointerType_k__BackingField; // 0x174
		private int _uiToolkitPointerId_k__BackingField; // 0x178
		private Vector3 _trackedDevicePosition_k__BackingField; // 0x17C
		private Quaternion _trackedDeviceOrientation_k__BackingField; // 0x188
	
		// Properties
		public InputControl control { get; set; } // 0x0000000185FB8520-0x0000000185FB8530 0x0000000187A4762C-0x0000000187A47640
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x0000000185FB88D0-0x0000000185FB88E0 0x0000000187A47BE0-0x0000000187A47BF4
		public int touchId { get; set; } // 0x0000000185FBBE50-0x0000000185FBBE60 0x0000000185FBBEC0-0x0000000185FBBED0
		public UIPointerType pointerType { get; set; } // 0x0000000185FB1190-0x0000000185FB11A0 0x0000000185FD8180-0x0000000185FD8190
		public int uiToolkitPointerId { get; set; } // 0x0000000185FCDD00-0x0000000185FCDD10 0x0000000185FD2F70-0x0000000185FD2F80
		public Vector3 trackedDevicePosition { get; set; } // 0x0000000185FD8160-0x0000000185FD8180 0x0000000185FD81A0-0x0000000185FD81C0
		public Quaternion trackedDeviceOrientation { get; set; } // 0x0000000185FD8150-0x0000000185FD8160 0x0000000185FD8190-0x0000000185FD81A0
	
		// Constructors
		public ExtendedPointerEventData() {} // Dummy constructor
		public ExtendedPointerEventData(EventSystem eventSystem) {} // 0x0000000186474FA4-0x0000000186474FAC
	
		// Methods
		public override string ToString() => default; // 0x000000018BD1CFB4-0x000000018BD1D438
		internal static int MakePointerIdForTouch(int deviceId, int touchId) => default; // 0x0000000185FD8140-0x0000000185FD8150
		internal static int TouchIdFromPointerId(int pointerId) => default; // 0x0000000185FD0F30-0x0000000185FD0F40
		internal void ReadDeviceState() {} // 0x0000000184212C80-0x0000000184212E00
		private static int GetPenPointerId(Pen pen) => default; // 0x000000018BD1CD24-0x000000018BD1CED8
		private static int GetTouchPointerId(TouchControl touchControl) => default; // 0x000000018BD1CED8-0x000000018BD1CFB4
	}

	public enum UIPointerType // TypeDefIndex: 45268
	{
		None = 0,
		MouseOrPen = 1,
		Touch = 2,
		Tracked = 3
	}

	public enum UIPointerBehavior // TypeDefIndex: 45269
	{
		SingleMouseOrPenButMultiTouchAndTrack = 0,
		SingleUnifiedPointer = 1,
		AllPointersAsIs = 2
	}

	internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData // TypeDefIndex: 45270
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x20
	
		// Properties
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public ExtendedSubmitCancelEventData() {} // Dummy constructor
		public ExtendedSubmitCancelEventData(EventSystem eventSystem) {} // 0x0000000184088E70-0x0000000184088E80
	}

	internal interface INavigationEventData // TypeDefIndex: 45271
	{
		// Properties
		UnityEngine.InputSystem.InputDevice device { get; }
	}

	public class InputSystemUIInputModule : BaseInputModule // TypeDefIndex: 45274
	{
		// Fields
		private const float kClickSpeed = 0.3f; // Metadata: 0x0205BED3
		private float m_MoveRepeatDelay; // 0x48
		private float m_MoveRepeatRate; // 0x4C
		private float m_TrackedDeviceDragThresholdMultiplier; // 0x50
		private Transform m_XRTrackingOrigin; // 0x58
		private static DefaultInputActions defaultActions; // 0x00
		private InputActionAsset m_ActionsAsset; // 0x60
		private InputActionReference m_PointAction; // 0x68
		private InputActionReference m_MoveAction; // 0x70
		private InputActionReference m_SubmitAction; // 0x78
		private InputActionReference m_CancelAction; // 0x80
		private InputActionReference m_LeftClickAction; // 0x88
		private InputActionReference m_MiddleClickAction; // 0x90
		private InputActionReference m_RightClickAction; // 0x98
		private InputActionReference m_ScrollWheelAction; // 0xA0
		private InputActionReference m_TrackedDevicePositionAction; // 0xA8
		private InputActionReference m_TrackedDeviceOrientationAction; // 0xB0
		private bool m_DeselectOnBackgroundClick; // 0xB8
		private UIPointerBehavior m_PointerBehavior; // 0xBC
		internal CursorLockBehavior m_CursorLockBehavior; // 0xC0
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
		public bool deselectOnBackgroundClick { get => default; set {} } // 0x0000000181EB1570-0x0000000181EB1580 0x0000000181EB1580-0x0000000181EB1590
		public UIPointerBehavior pointerBehavior { get => default; set {} } // 0x0000000185FBEB50-0x0000000185FBEB60 0x0000000185FCEB90-0x0000000185FCEBA0
		public CursorLockBehavior cursorLockBehavior { get => default; set {} } // 0x0000000185FBE0C0-0x0000000185FBE0D0 0x0000000185FD2210-0x0000000185FD2220
		internal GameObject localMultiPlayerRoot { get => default; set {} } // 0x0000000185FB86D0-0x0000000185FB86E0 0x0000000187A478FC-0x0000000187A47910
		public float scrollDeltaPerTick { get => default; set {} } // 0x0000000185FB9CA0-0x0000000185FB9CB0 0x0000000185FCA210-0x0000000185FCA220
		public float moveRepeatDelay { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float moveRepeatRate { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		private bool explictlyIgnoreFocus { get => default; } // 0x00000001849552C0-0x0000000184955320 
		private bool shouldIgnoreFocus { get => default; } // 0x0000000184955220-0x00000001849552C0 
		public float repeatRate { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float repeatDelay { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public Transform xrTrackingOrigin { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public float trackedDeviceDragThresholdMultiplier { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public InputActionReference point { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x000000018BD1FDBC-0x000000018BD1FDF0
		public InputActionReference scrollWheel { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018BD1FE28-0x000000018BD1FE60
		public InputActionReference leftClick { get => default; set {} } // 0x0000000185FB0510-0x0000000185FB0520 0x000000018BD1FD18-0x000000018BD1FD50
		public InputActionReference middleClick { get => default; set {} } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x000000018BD1FD50-0x000000018BD1FD88
		public InputActionReference rightClick { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x000000018BD1FDF0-0x000000018BD1FE28
		public InputActionReference move { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x000000018BD1FD88-0x000000018BD1FDBC
		public InputActionReference submit { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x000000018BD1FE60-0x000000018BD1FE94
		public InputActionReference cancel { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x000000018BD1FCE0-0x000000018BD1FD18
		public InputActionReference trackedDeviceOrientation { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x000000018BD1FE94-0x000000018BD1FECC
		public InputActionReference trackedDevicePosition { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018BD1FECC-0x000000018BD1FF04
		public InputActionReference trackedDeviceSelect { get => default; set {} } // 0x000000018BD1FAD4-0x000000018BD1FB20 0x000000018BD1FF04-0x000000018BD1FF50
		public InputActionAsset actionsAsset { get => default; set {} } // 0x0000000185FB0530-0x0000000185FB0540 0x000000018BD1FB20-0x000000018BD1FCE0
		private bool sendPointerHoverToParent { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Nested types
		private struct InputActionReferenceState // TypeDefIndex: 45272
		{
			// Fields
			public int refCount; // 0x00
			public bool enabledByInputModule; // 0x04
		}
	
		public enum CursorLockBehavior // TypeDefIndex: 45273
		{
			OutsideScreen = 0,
			ScreenCenter = 1
		}
	
		// Constructors
		public InputSystemUIInputModule() {} // 0x00000001857EE6F0-0x00000001857EE730
		static InputSystemUIInputModule() {} // 0x0000000185F3A870-0x0000000185F3A910
	
		// Methods
		public override void ActivateModule() {} // 0x00000001845E2B40-0x00000001845E2C00
		public override bool IsPointerOverGameObject(int pointerOrTouchId) => default; // 0x000000018BD1ED44-0x000000018BD1EE68
		public RaycastResult GetLastRaycastResult(int pointerOrTouchId) => default; // 0x000000018BD1E988-0x000000018BD1EA80
		private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) => default; // 0x00000001842127C0-0x00000001842129F0
		private void ProcessPointer(ref PointerModel state) {} // 0x00000001842110D0-0x00000001842114B0
		private bool PointerShouldIgnoreTransform(Transform t) => default; // 0x0000000184212750-0x00000001842127C0
		private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) {} // 0x0000000184212C30-0x0000000184212C80
		private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) {} // 0x00000001842106D0-0x00000001842110D0
		private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData) {} // 0x0000000184211D30-0x00000001842125E0
		private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData) {} // 0x00000001842119D0-0x0000000184211D00
		private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) {} // 0x0000000184210130-0x0000000184210240
		internal void ProcessNavigation(ref NavigationModel navigationState) {} // 0x00000001845E2C00-0x00000001845E30A0
		private bool IsMoveAllowed(AxisEventData eventData) => default; // 0x000000018BD1EB8C-0x000000018BD1ED44
		private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback) {} // 0x000000018BD1F4FC-0x000000018BD1F7A8
		public void AssignDefaultActions() {} // 0x000000018BD1E454-0x000000018BD1E81C
		public void UnassignActions() {} // 0x000000018BD1F920-0x000000018BD1FA34
		protected override void Awake() {} // 0x0000000185FACDD0-0x0000000185FACDE0
		protected override void OnDestroy() {} // 0x000000018BD1EE68-0x000000018BD1EE70
		protected override void OnEnable() {} // 0x00000001858C88D0-0x00000001858C89F0
		protected override void OnDisable() {} // 0x000000018BD1EE70-0x000000018BD1EF0C
		private void ResetPointers() {} // 0x00000001858C89F0-0x00000001858C8A30
		private bool HasNoActions() => default; // 0x00000001858C8A90-0x00000001858C8B00
		private void EnableAllActions() {} // 0x0000000184BFCE00-0x0000000184BFCEC0
		private void DisableAllActions() {} // 0x000000018BD1E8B4-0x000000018BD1E988
		private void EnableInputAction(InputActionReference inputActionReference) {} // 0x0000000184BFCEC0-0x0000000184BFD020
		private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false /* Metadata: 0x0205BED1 */) {} // 0x000000018BD1F7A8-0x000000018BD1F920
		private int GetPointerStateIndexFor(int pointerOrTouchId) => default; // 0x000000018BD1EA80-0x000000018BD1EB8C
		private ref PointerModel GetPointerStateForIndex(int index) => ref _refReturnTypeForGetPointerStateForIndex; // 0x0000000184213460-0x0000000184213480
		private ref PointerModel _refReturnTypeForGetPointerStateForIndex; // Dummy field
		private int GetDisplayIndexFor(InputControl control) => default; // 0x0000000184586950-0x0000000184586A10
		private int GetPointerStateIndexFor(ref InputAction.CallbackContext context) => default; // 0x0000000184954E80-0x0000000184954EF0
		private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true /* Metadata: 0x0205BED2 */) => default; // 0x0000000184586630-0x0000000184586950
		private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, UnityEngine.InputSystem.InputDevice device, InputControl touchControl = null) => default; // 0x0000000185A94380-0x0000000185A94590
		private bool SendPointerExitEventsAndRemovePointer(int index) => default; // 0x000000018BD1F430-0x000000018BD1F4FC
		private bool RemovePointerAtIndex(int index) => default; // 0x000000018BD1F190-0x000000018BD1F430
		private void PurgeStalePointers() {} // 0x0000000184BFA080-0x0000000184BFA150
		private static bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, InputActionReference actionReference) => default; // 0x0000000184BFA580-0x0000000184BFA640
		private void OnPointCallback(InputAction.CallbackContext context) {} // 0x0000000184586490-0x0000000184586630
		private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed) => default; // 0x0000000184955150-0x0000000184955220
		private void OnLeftClickCallback(InputAction.CallbackContext context) {} // 0x0000000184954D40-0x0000000184954DD0
		private void OnRightClickCallback(InputAction.CallbackContext context) {} // 0x0000000184955E30-0x00000001849561C0
		private void OnMiddleClickCallback(InputAction.CallbackContext context) {} // 0x000000018BD1EF0C-0x000000018BD1EF9C
		private bool CheckForRemovedDevice(ref InputAction.CallbackContext context) => default; // 0x00000001845862D0-0x0000000184586330
		private void OnScrollCallback(InputAction.CallbackContext context) {} // 0x0000000184954DD0-0x0000000184954E80
		private void OnMoveCallback(InputAction.CallbackContext context) {} // 0x000000018BD1EF9C-0x000000018BD1F030
		private void OnSubmitCancelCallback(InputAction.CallbackContext context) {} // 0x000000018BD1F030-0x000000018BD1F070
		private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context) {} // 0x000000018BD1F070-0x000000018BD1F0FC
		private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context) {} // 0x000000018BD1F0FC-0x000000018BD1F190
		private void OnControlsChanged(object obj) {} // 0x0000000185FAFC50-0x0000000185FAFC60
		private void FilterPointerStatesByType() {} // 0x0000000184213040-0x0000000184213430
		public override void Process() {} // 0x0000000184212E00-0x0000000184213040
		public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) => default; // 0x000000018BD1E81C-0x000000018BD1E8B4
		private void HookActions() {} // 0x00000001858C8C10-0x00000001858C8F70
		private void UnhookActions() {} // 0x000000018BD1FA34-0x000000018BD1FA48
		private void SetActionCallbacks(bool install) {} // 0x0000000184BFD020-0x0000000184BFD190
		private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install) {} // 0x0000000184BFD190-0x0000000184BFD250
		private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) => default; // 0x000000018BD1FA48-0x000000018BD1FAD4
	}

	public class MultiplayerEventSystem : EventSystem // TypeDefIndex: 45275
	{
		// Fields
		private GameObject m_PlayerRoot; // 0x50
	
		// Properties
		public GameObject playerRoot { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x000000018BD203D0-0x000000018BD203F4
	
		// Constructors
		public MultiplayerEventSystem() {} // 0x000000018BD20384-0x000000018BD203D0
	
		// Methods
		protected override void OnEnable() {} // 0x000000018BD202B0-0x000000018BD202D0
		protected override void OnDisable() {} // 0x000000018BD202A8-0x000000018BD202B0
		private void InitializePlayerRoot() {} // 0x000000018BD201F4-0x000000018BD202A8
		protected override void Update() {} // 0x000000018BD202D0-0x000000018BD20384
	}

	internal struct NavigationModel // TypeDefIndex: 45276
	{
		// Fields
		public Vector2 move; // 0x00
		public int consecutiveMoveCount; // 0x08
		public MoveDirection lastMoveDirection; // 0x0C
		public float lastMoveTime; // 0x10
		public AxisEventData eventData; // 0x18
		public UnityEngine.InputSystem.InputDevice device; // 0x20
	
		// Methods
		public void Reset() {} // 0x00000001864754E0-0x00000001864754F0
	}

	internal struct SubmitCancelModel // TypeDefIndex: 45277
	{
		// Fields
		public BaseEventData eventData; // 0x00
		public UnityEngine.InputSystem.InputDevice device; // 0x08
	}

	internal struct PointerModel // TypeDefIndex: 45279
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
		public UIPointerType pointerType { get => default; } // 0x0000000185FBACB0-0x0000000185FBACC0 
		public Vector2 screenPosition { get => default; set {} } // 0x0000000184213590-0x00000001842135B0 0x0000000185FBA250-0x0000000185FBA260
		public Vector3 worldPosition { get => default; set {} } // 0x0000000184213570-0x0000000184213590 0x0000000185FD6E10-0x0000000185FD6E30
		public Quaternion worldOrientation { get => default; set {} } // 0x00000001842135F0-0x0000000184213640 0x0000000185A94590-0x0000000185A946D0
		public Vector2 scrollDelta { get => default; set {} } // 0x0000000184213640-0x00000001842136C0 0x0000000184213480-0x0000000184213570
		public float pressure { get => default; set {} } // 0x00000001835E3010-0x00000001835E3020 0x0000000184954EF0-0x0000000184954F40
		public float azimuthAngle { get => default; set {} } // 0x0000000185FB30C0-0x0000000185FB30D0 0x0000000185FD5BF0-0x0000000185FD5C00
		public float altitudeAngle { get => default; set {} } // 0x0000000185FBA140-0x0000000185FBA150 0x0000000185FBA170-0x0000000185FBA180
		public float twist { get => default; set {} } // 0x0000000185FB3080-0x0000000185FB3090 0x0000000185FBCA10-0x0000000185FBCA20
		public Vector2 radius { get => default; set {} } // 0x0000000184212600-0x0000000184212620 0x00000001842125E0-0x0000000184212600
	
		// Nested types
		public struct ButtonState // TypeDefIndex: 45278
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
			public bool isPressed { get => default; set {} } // 0x0000000184213430-0x0000000184213460 0x0000000185FD8200-0x0000000185FD8220
			public bool ignoreNextClick { get => default; set {} } // 0x0000000184586A10-0x0000000184586A60 0x0000000185FD8250-0x0000000185FD8270
			public float pressTime { get => default; set {} } // 0x000000018BD23280-0x000000018BD232FC 0x0000000185FD8240-0x0000000185FD8250
			public bool clickedOnSameGameObject { get => default; set {} } // 0x000000018BD23234-0x000000018BD23280 0x0000000185FD8220-0x0000000185FD8240
			public bool wasPressedThisFrame { get => default; } // 0x00000001842136C0-0x0000000184213990 
			public bool wasReleasedThisFrame { get => default; } // 0x0000000185FBAC40-0x0000000185FBAC50 
	
			// Methods
			public void CopyPressStateTo(PointerEventData eventData) {} // 0x00000001842135D0-0x00000001842135F0
			public void CopyPressStateFrom(PointerEventData eventData) {} // 0x0000000185FBAC50-0x0000000185FBAC60
			public void OnEndFrame() {} // 0x00000001842135B0-0x00000001842135D0
		}
	
		// Constructors
		public PointerModel(ExtendedPointerEventData eventData) : this() {
			changedThisFrame = default;
			leftButton = default;
			rightButton = default;
			middleButton = default;
			this.eventData = default;
			m_ScreenPosition = default;
			m_ScrollDelta = default;
			m_WorldPosition = default;
			m_WorldOrientation = default;
			m_Pressure = default;
			m_AzimuthAngle = default;
			m_AltitudeAngle = default;
			m_Twist = default;
			m_Radius = default;
		} // 0x00000001842114B0-0x0000000184211860
	
		// Methods
		public void OnFrameFinished() {} // 0x0000000184212620-0x0000000184212710
		public void CopyTouchOrPenStateFrom(PointerEventData eventData) {} // 0x0000000185FD8130-0x0000000185FD8140
	}

	public class TrackedDeviceRaycaster : BaseRaycaster // TypeDefIndex: 45282
	{
		// Fields
		[NonSerialized]
		private List<RaycastHitData> m_RaycastResultsCache; // 0x20
		internal static InlinedArray<TrackedDeviceRaycaster> s_Instances; // 0x00
		private static readonly List<RaycastHitData> s_SortedGraphics; // 0x18
		private bool m_IgnoreReversedGraphics; // 0x28
		private bool m_CheckFor2DOcclusion; // 0x29
		private bool m_CheckFor3DOcclusion; // 0x2A
		private float m_MaxDistance; // 0x2C
		private LayerMask m_BlockingMask; // 0x30
		[NonSerialized]
		private Canvas m_Canvas; // 0x38
	
		// Properties
		public override Camera eventCamera { get => default; } // 0x00000001813B4840-0x00000001813B4850 
		public LayerMask blockingMask { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x0000000185FB09B0-0x0000000185FB09C0
		public bool checkFor3DOcclusion { get => default; set {} } // 0x000000018BD24404-0x000000018BD24474 0x000000018BD2433C-0x000000018BD24404
		public bool checkFor2DOcclusion { get => default; set {} } // 0x000000018BD24E34-0x000000018BD24EA8 0x000000018BD24474-0x000000018BD24948
		public bool ignoreReversedGraphics { get => default; set {} } // 0x000000018BD24EA8-0x000000018BD25298 0x000000018BD24948-0x000000018BD24E34
		public float maxDistance { get => default; set {} } // 0x000000018BD253B4-0x000000018BD25438 0x000000018BD2532C-0x000000018BD253B4
		private Canvas canvas { get => default; } // 0x000000018BD256C4-0x000000018BD25728 
	
		// Nested types
		private struct RaycastHitData // TypeDefIndex: 45280
		{
			// Fields
			private readonly Graphic _graphic_k__BackingField; // 0x00
			private readonly Vector3 _worldHitPosition_k__BackingField; // 0x08
			private readonly Vector2 _screenPosition_k__BackingField; // 0x14
			private readonly float _distance_k__BackingField; // 0x1C
	
			// Properties
			public Graphic graphic { get; } // 0x00000001813CFF60-0x00000001813CFF70 
			public Vector3 worldHitPosition { get; } // 0x00000001813D0A90-0x00000001813D0AA0 
			public Vector2 screenPosition { get; } // 0x0000000181E2DB70-0x0000000181E2DB80 
			public float distance { get; } // 0x000000018306A5F0-0x000000018306BCC0 
	
			// Constructors
			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) : this() {
				<graphic>k__BackingField = default;
				<worldHitPosition>k__BackingField = default;
				<screenPosition>k__BackingField = default;
				<distance>k__BackingField = default;
			} // 0x000000018BD25438-0x000000018BD254AC
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45281
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RaycastHitData> __9__25_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001813B34D0-0x00000001813B34E0
			public __c() {} // 0x00000001813B4850-0x00000001813B4860
	
			// Methods
			internal int _SortedRaycastGraphics_b__25_0(RaycastHitData g1, RaycastHitData g2) => default; // 0x00000001813B31B0-0x00000001813B31C0
		}
	
		// Constructors
		public TrackedDeviceRaycaster() {} // 0x0000000185492010-0x0000000185492020
		static TrackedDeviceRaycaster() {} // 0x000000018BD2567C-0x000000018BD256C4
	
		// Methods
		protected override void OnEnable() {} // 0x000000018BD25298-0x000000018BD2532C
		protected override void OnDisable() {} // 0x000000018BD232FC-0x000000018BD23338
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x00000001834AFB60-0x00000001834AFB70
		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000185FBFA70-0x0000000185FBFA90
		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results) {} // 0x0000000185FBD960-0x0000000185FBD980
		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) {
			worldPosition = default;
			distance = default;
			return default;
		} // 0x0000000185FB0850-0x0000000185FB0860
	}

	public class VirtualMouseInput : MonoBehaviour // TypeDefIndex: 45284
	{
		// Fields
		private CursorMode m_CursorMode; // 0x18
		private Graphic m_CursorGraphic; // 0x20
		private RectTransform m_CursorTransform; // 0x28
		private float m_CursorSpeed; // 0x30
		private float m_ScrollSpeed; // 0x34
		private InputActionProperty m_StickAction; // 0x38
		private InputActionProperty m_LeftButtonAction; // 0x50
		private InputActionProperty m_MiddleButtonAction; // 0x68
		private InputActionProperty m_RightButtonAction; // 0x80
		private InputActionProperty m_ForwardButtonAction; // 0x98
		private InputActionProperty m_BackButtonAction; // 0xB0
		private InputActionProperty m_ScrollWheelAction; // 0xC8
		private Canvas m_Canvas; // 0xE0
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0xE8
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0xF0
		private Action m_AfterInputUpdateDelegate; // 0xF8
		private Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x100
		private double m_LastTime; // 0x108
		private Vector2 m_LastStickValue; // 0x110
	
		// Properties
		public RectTransform cursorTransform { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public float cursorSpeed { get => default; set {} } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x0000000185FB0BF0-0x0000000185FB0C00
		public CursorMode cursorMode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018BD268B4-0x000000018BD26998
		public Graphic cursorGraphic { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018BD26890-0x000000018BD268B4
		public float scrollSpeed { get => default; set {} } // 0x0000000185FB8060-0x0000000185FB8070 0x0000000185FB8A50-0x0000000185FB8A60
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x0000000185FB2360-0x0000000185FB2370 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000185FBAFF0-0x0000000185FBB010 0x000000018BD26C88-0x000000018BD26D40
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000185FCA690-0x0000000185FCA6B0 0x000000018BD26A50-0x000000018BD26AF8
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000185FD8370-0x0000000185FD8390 0x000000018BD26BA0-0x000000018BD26C58
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x00000001838563D0-0x00000001838563F0 0x000000018BD26AF8-0x000000018BD26BA0
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000185FD8350-0x0000000185FD8370 0x000000018BD26998-0x000000018BD26A50
		public InputActionProperty backButtonAction { get => default; set {} } // 0x0000000185FCCE60-0x0000000185FCCE80 0x000000018BD267D8-0x000000018BD26890
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x0000000185FD8390-0x0000000185FD83B0 0x000000018BD26C58-0x000000018BD26C88
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 45283
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public VirtualMouseInput() {} // 0x000000018BD267C0-0x000000018BD267D8
	
		// Methods
		protected void OnEnable() {} // 0x000000018BD25C5C-0x000000018BD26078
		protected void OnDisable() {} // 0x000000018BD259C4-0x000000018BD25C5C
		private void TryFindCanvas() {} // 0x000000018BD26368-0x000000018BD263C8
		private void TryEnableHardwareCursor() {} // 0x000000018BD26170-0x000000018BD26368
		private void UpdateMotion() {} // 0x000000018BD263C8-0x000000018BD267C0
		private void OnButtonActionTriggered(InputAction.CallbackContext context) {} // 0x000000018BD2582C-0x000000018BD259C4
		private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0205BED9 */) {} // 0x000000018A9BCA20-0x000000018A9BCA8C
		private static void SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x000000018BD26078-0x000000018BD26170
		private void OnAfterInputUpdate() {} // 0x000000018BD25824-0x000000018BD2582C
	}
}

namespace UnityEngine.InputSystem.Users
{
	public struct InputUser : IEquatable<InputUser> // TypeDefIndex: 45260
	{
		// Fields
		public const uint InvalidId = 0; // Metadata: 0x0205BEB6
		private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x00
		private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x08
		private uint m_Id; // 0x00
		private static GlobalState s_GlobalState; // 0x10
	
		// Properties
		public bool valid { get => default; } // 0x000000018BD0D15C-0x000000018BD0D244 
		public int index { get => default; } // 0x000000018BD0CD20-0x000000018BD0CD98 
		public uint id { get => default; } // 0x000000018BD0CEC4-0x000000018BD0CF58 
		public InputUserAccountHandle? platformUserAccountHandle { get => default; } // 0x000000018BD0CE14-0x000000018BD0CEC4 
		public string platformUserAccountName { get => default; } // 0x000000018BD0CF58-0x000000018BD0CFD4 
		public string platformUserAccountId { get => default; } // 0x000000018BD0CD98-0x000000018BD0CE14 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> pairedDevices { get => default; } // 0x000000018BD0CAC0-0x000000018BD0CB7C 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> lostDevices { get => default; } // 0x000000018BD0D560-0x000000018BD0D61C 
		public IInputActionCollection actions { get => default; } // 0x000000018BD0CC3C-0x000000018BD0CD20 
		public InputControlScheme? controlScheme { get => default; } // 0x000000018BD0D6DC-0x000000018BD0D7CC 
		public InputControlScheme.MatchResult controlSchemeMatch { get => default; } // 0x000000018BD0CB7C-0x000000018BD0CC3C 
		public bool hasMissingRequiredDevices { get => default; } // 0x000000018BD0D61C-0x000000018BD0D6DC 
		public static ReadOnlyArray<InputUser> all { get => default; } // 0x000000018BD0D108-0x000000018BD0D15C 
		public static int listenForUnpairedDeviceActivity { get => default; set {} } // 0x000000018BD06CA0-0x000000018BD06E4C 0x000000018BD068B8-0x000000018BD06CA0
	
		// Events
		public static event Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice> onChange;
		public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed;
		public static event Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity;
	
		// Nested types
		public struct ControlSchemeChangeSyntax // TypeDefIndex: 45253
		{
			// Fields
			internal int m_UserIndex; // 0x00
	
			// Methods
			public ControlSchemeChangeSyntax AndPairRemainingDevices() => default; // 0x000000018BD0D4AC-0x000000018BD0D560
		}
	
		internal enum UserFlags // TypeDefIndex: 45254
		{
			BindToAllDevices = 1,
			UserAccountSelectionInProgress = 2
		}
	
		private struct UserData // TypeDefIndex: 45255
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
	
		private struct CompareDevicesByUserAccount : IComparer<UnityEngine.InputSystem.InputDevice> // TypeDefIndex: 45256
		{
			// Fields
			public InputUserAccountHandle platformUserAccountHandle; // 0x00
	
			// Methods
			public int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y) => default; // 0x000000018BD0CFD4-0x000000018BD0D108
			private static InputUserAccountHandle? GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001818226B0-0x00000001818226C0
		}
	
		private struct OngoingAccountSelection // TypeDefIndex: 45257
		{
			// Fields
			public UnityEngine.InputSystem.InputDevice device; // 0x00
			public uint userId; // 0x08
		}
	
		private struct GlobalState // TypeDefIndex: 45258
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
		private sealed class __c // TypeDefIndex: 45259
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SavedStructState<GlobalState> __9__88_0; // 0x08
			public static Action __9__88_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BD0D328-0x000000018BD0D3BC
			public __c() {} // 0x000000018BD0D434-0x000000018BD0D4AC
	
			// Methods
			internal void _SaveAndResetState_b__88_0(ref GlobalState state) {} // 0x000000018BD0D3BC-0x000000018BD0D434
			internal void _SaveAndResetState_b__88_1() {} // 0x000000018BD0D244-0x000000018BD0D328
		}
	
		// Constructors
		static InputUser() {
			k_InputUserOnChangeMarker = default;
			k_InputCheckForUnpairMarker = default;
			s_GlobalState = default;
		} // 0x000000018BD2563C-0x000000018BD2567C
	
		// Methods
		public override string ToString() => default; // 0x000000018BD0B804-0x000000018BD0B908
		public void AssociateActionsWithUser(IInputActionCollection actions) {} // 0x000000018BD0B960-0x000000018BD0BB74
		public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) => default; // 0x000000018BD0A68C-0x000000018BD0A878
		private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) {
			scheme = default;
			return default;
		} // 0x000000018BD0B908-0x000000018BD0B960
		internal void FindControlScheme(string schemeName, out InputControlScheme scheme) {
			scheme = default;
		} // 0x000000018BD08038-0x000000018BD080A8
		public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) => default; // 0x000000018BD07E5C-0x000000018BD08038
		private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) {} // 0x000000018BD07D60-0x000000018BD07E5C
		public void UnpairDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD07C18-0x000000018BD07D60
		public void UnpairDevices() {} // 0x000000018BD07894-0x000000018BD078FC
		private static void RemoveLostDevicesForUser(int userIndex) {} // 0x000000018BD09CDC-0x000000018BD09F48
		public void UnpairDevicesAndRemoveUser() {} // 0x000000018BD0853C-0x000000018BD086A0
		public static InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public static int GetUnpairedInputDevices(ref InputControlList<UnityEngine.InputSystem.InputDevice> list) => default; // 0x000000018BD079D4-0x000000018BD07A3C
		public static InputUser? FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001818226B0-0x00000001818226C0
		public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) => default; // 0x0000000188645D08-0x0000000188645D10
		public static InputUser CreateUserWithoutPairedDevices() => default; // 0x000000018B6328C0-0x000000018B6328C8
		public static InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, InputUser user = default, InputUserPairingOptions options = InputUserPairingOptions.None /* Metadata: 0x0205BEB0 */) => default; // 0x000000018BD07448-0x000000018BD075C4
		private static bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, InputUserPairingOptions options) => default; // 0x000000018BD0A878-0x000000018BD0ABAC
		public bool Equals(InputUser other) => default; // 0x000000018BD086A0-0x000000018BD08944
		public override bool Equals(object obj) => default; // 0x000000018BD0B300-0x000000018BD0B3AC
		public override int GetHashCode() => default; // 0x000000018BD0B4E4-0x000000018BD0B5F4
		public static bool operator ==(InputUser left, InputUser right) => default; // 0x000000018BD0B3AC-0x000000018BD0B4E4
		public static bool operator !=(InputUser left, InputUser right) => default; // 0x000000018BD06F14-0x000000018BD07448
		private static int AddUser() => default; // 0x000000018BD0A15C-0x000000018BD0A68C
		private static void RemoveUser(int userIndex) {} // 0x000000018BD0BB74-0x000000018BD0C4E4
		private static void Notify(int userIndex, InputUserChange change, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD0C4E4-0x000000018BD0CA28
		private static int TryFindUserIndex(uint userId) => default; // 0x000000018BD09F48-0x000000018BD0A15C
		private static int TryFindUserIndex(InputUserAccountHandle platformHandle) => default; // 0x000000018BD0847C-0x000000018BD0853C
		private static int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD08944-0x000000018BD08A1C
		private static void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x0205BEB1 */, bool dontUpdateControlScheme = false /* Metadata: 0x0205BEB2 */) {} // 0x000000018BD08A1C-0x000000018BD090B8
		private static void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x0205BEB3 */) {} // 0x000000018BD07B58-0x000000018BD07C18
		private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false /* Metadata: 0x0205BEB4 */) {} // 0x000000018BD090B8-0x000000018BD09CDC
		private static long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD0ABF8-0x000000018BD0AE30
		private static long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId) {
			platformAccountHandle = default;
			platformAccountName = default;
			platformAccountId = default;
			return default;
		} // 0x000000018BD080A8-0x000000018BD081FC
		private static bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device) => default; // 0x000000018BD0B5F4-0x000000018BD0B6C8
		private static void OnActionChange(object obj, InputActionChange change) {} // 0x000000018BD081FC-0x000000018BD0833C
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x000000018BD0B6C8-0x000000018BD0B764
		private static int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex = 0 /* Metadata: 0x0205BEB5 */) => default; // 0x000000018BD0833C-0x000000018BD0847C
		private static void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BD0B764-0x000000018BD0B804
		internal static ISavedState SaveAndResetState() => default; // 0x000000018BD078FC-0x000000018BD079D4
		private static void HookIntoActionChange() {} // 0x000000018BD0ABAC-0x000000018BD0ABF8
		private static void UnhookFromActionChange() {} // 0x000000018BD0CA28-0x000000018BD0CAC0
		private static void HookIntoDeviceChange() {} // 0x000000018BD1CC34-0x000000018BD1CC84
		private static void UnhookFromDeviceChange() {} // 0x000000018BD1CAEC-0x000000018BD1CC34
		private static void HookIntoEvents() {} // 0x0000000185FBB100-0x0000000185FBB110
		private static void UnhookFromDeviceStateChange() {} // 0x000000018BD25728-0x000000018BD2578C
		private static void DisposeAndResetGlobalState() {} // 0x0000000185492010-0x0000000185492020
		internal static void ResetGlobals() {} // 0x000000018BD254AC-0x000000018BD2563C
	}

	public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle> // TypeDefIndex: 45261
	{
		// Fields
		private string m_ApiName; // 0x00
		private ulong m_Handle; // 0x08
	
		// Properties
		public string apiName { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		public ulong handle { get => default; } // 0x000000018357A260-0x000000018357A270 
	
		// Constructors
		public InputUserAccountHandle(string apiName, ulong handle) : this() {
			m_ApiName = default;
			m_Handle = default;
		} // 0x000000018BD20134-0x000000018BD201B4
	
		// Methods
		public override string ToString() => default; // 0x000000018BD20088-0x000000018BD20134
		public bool Equals(InputUserAccountHandle other) => default; // 0x000000018BD1FF50-0x000000018BD1FFE0
		public override bool Equals(object obj) => default; // 0x000000018BD1FFE0-0x000000018BD20050
		public static bool operator ==(InputUserAccountHandle left, InputUserAccountHandle right) => default; // 0x000000018BD201B4-0x000000018BD201D4
		public static bool operator !=(InputUserAccountHandle left, InputUserAccountHandle right) => default; // 0x000000018BD201D4-0x000000018BD201F4
		public override int GetHashCode() => default; // 0x000000018BD20050-0x000000018BD20088
	}

	public enum InputUserChange // TypeDefIndex: 45262
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

	public enum InputUserPairingOptions // TypeDefIndex: 45263
	{
		None = 0,
		ForcePlatformUserAccountSelection = 1,
		ForceNoPlatformUserAccountSelection = 2,
		UnpairCurrentDevicesFromUser = 8
	}

	[Serializable]
	internal class InputUserSettings // TypeDefIndex: 45264
	{
		// Fields
		private string _customBindings_k__BackingField; // 0x10
		private bool _invertMouseX_k__BackingField; // 0x18
		private bool _invertMouseY_k__BackingField; // 0x19
		private float? _mouseSmoothing_k__BackingField; // 0x1C
		private float? _mouseSensitivity_k__BackingField; // 0x24
		private bool _invertStickX_k__BackingField; // 0x2C
		private bool _invertStickY_k__BackingField; // 0x2D
		private bool _swapSticks_k__BackingField; // 0x2E
		private bool _swapBumpers_k__BackingField; // 0x2F
		private bool _swapTriggers_k__BackingField; // 0x30
		private bool _swapDpadAndLeftStick_k__BackingField; // 0x31
		private float _vibrationStrength_k__BackingField; // 0x34
		private string m_CustomBindings; // 0x38
	
		// Properties
		public string customBindings { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool invertMouseX { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public bool invertMouseY { get; set; } // 0x0000000181A73E90-0x0000000181A73EA0 0x0000000181A73EB0-0x0000000181A73EC0
		public float? mouseSmoothing { get; set; } // 0x0000000185FD6A20-0x0000000185FD6A30 0x0000000185FD81F0-0x0000000185FD8200
		public float? mouseSensitivity { get; set; } // 0x0000000185FB2D50-0x0000000185FB2D60 0x0000000185FD22E0-0x0000000185FD22F0
		public bool invertStickX { get; set; } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
		public bool invertStickY { get; set; } // 0x0000000185FB0AD0-0x0000000185FB0AE0 0x0000000185FB0AF0-0x0000000185FB0B00
		public bool swapSticks { get; set; } // 0x0000000185FBA470-0x0000000185FBA480 0x0000000185FBA480-0x0000000185FBA490
		public bool swapBumpers { get; set; } // 0x0000000185FD46C0-0x0000000185FD46D0 0x0000000185FD46D0-0x0000000185FD46E0
		public bool swapTriggers { get; set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public bool swapDpadAndLeftStick { get; set; } // 0x0000000185FB0980-0x0000000185FB0990 0x0000000185FB0990-0x0000000185FB09A0
		public float vibrationStrength { get; set; } // 0x0000000185FB8060-0x0000000185FB8070 0x0000000185FB8A50-0x0000000185FB8A60
	
		// Constructors
		public InputUserSettings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void Apply(IInputActionCollection actions) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.InputSystem.Utilities
{
	public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IDisposable // TypeDefIndex: 45554
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
		public InputEventBuffer buffer { get => default; } // 0x000000018BCD7D4C-0x000000018BCD7D54 
		public int count { get => default; } // 0x000000018BCD7578-0x000000018BCD7638 
	
		// Nested types
		public struct ActionEventPtr // TypeDefIndex: 45552
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr; // 0x08
	
			// Properties
			public InputAction action { get => default; } // 0x0000000185FD79B0-0x0000000185FD79D0 
			public InputActionPhase phase { get => default; } // 0x000000018143E3B0-0x000000018143E3C0 
			public InputControl control { get => default; } // 0x0000000185492010-0x0000000185492020 
			public IInputInteraction interaction { get => default; } // 0x000000018BCD82A4-0x000000018BCD8310 
			public double time { get => default; } // 0x000000018BCD8310-0x000000018BCD837C 
			public double startTime { get => default; } // 0x000000018BCD7A1C-0x000000018BCD7AD4 
			public double duration { get => default; } // 0x000000018BCD7FD4-0x000000018BCD808C 
			public int valueSizeInBytes { get => default; } // 0x000000018BCD7BFC-0x000000018BCD7D4C 
	
			// Methods
			public object ReadValueAsObject() => default; // 0x000000018BCD7AD4-0x000000018BCD7BFC
			public unsafe void ReadValue(void* buffer, int bufferSize) {} // 0x000000018BCD808C-0x000000018BCD81AC
			public TValue ReadValue<TValue>()
				where TValue : struct => default; // 0x000000018BCD81AC-0x000000018BCD82A4
			public override string ToString() => default; // 0x000000018BCD7890-0x000000018BCD7A1C
		}
	
		private struct Enumerator : IEnumerator<ActionEventPtr> // TypeDefIndex: 45553
		{
			// Fields
			private readonly InputActionTrace m_Trace; // 0x00
			private readonly unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer; // 0x08
			private readonly int m_EventCount; // 0x10
			private unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent; // 0x18
			private int m_CurrentIndex; // 0x20
	
			// Properties
			public ActionEventPtr Current { get => default; } // 0x000000018BCD7364-0x000000018BCD7468 
			object IEnumerator.Current { get => default; } // 0x000000018BCD74F8-0x000000018BCD7578 
	
			// Constructors
			public unsafe Enumerator(InputActionTrace trace) : this() {
				m_Trace = default;
				m_Buffer = default;
				m_EventCount = default;
				m_CurrentEvent = default;
				m_CurrentIndex = default;
			} // 0x000000018BCD7248-0x000000018BCD7294
	
			// Methods
			public bool MoveNext() => default; // 0x000000018BCD7488-0x000000018BCD74F8
			public void Reset() {} // 0x000000018BCD7D54-0x000000018BCD7F78
			public void Dispose() {} // 0x000000018BCD7468-0x000000018BCD7488
		}
	
		// Constructors
		public InputActionTrace() {} // 0x000000018BCD7F78-0x000000018BCD7FD4
		public InputActionTrace(InputAction action) {} // 0x000000018BCD7638-0x000000018BCD7890
		public InputActionTrace(InputActionMap actionMap) {} // 0x000000018BCD7294-0x000000018BCD7364
	
		// Methods
		public void SubscribeToAll() {} // 0x000000018BCD53D0-0x000000018BCD53FC
		public void UnsubscribeFromAll() {} // 0x0000000185FD78F0-0x0000000185FD7900
		public void SubscribeTo(InputAction action) {} // 0x000000018BCD53FC-0x000000018BCD5434
		public void SubscribeTo(InputActionMap actionMap) {} // 0x000000018BCD5454-0x000000018BCD54A0
		public void UnsubscribeFrom(InputAction action) {} // 0x000000018BCD54A0-0x000000018BCD54C0
		public void UnsubscribeFrom(InputActionMap actionMap) {} // 0x0000000185FD7900-0x0000000185FD7910
		public void RecordAction(InputAction.CallbackContext context) {} // 0x000000018BCD5434-0x000000018BCD5454
		public void Clear() {} // 0x0000000185FD7910-0x0000000185FD7920
		~InputActionTrace() {} // 0x000000018BCD4E1C-0x000000018BCD5038
		public override string ToString() => default; // 0x000000018BCD5038-0x000000018BCD5134
		public void Dispose() {}
		private void DisposeInternal() {} // 0x000000018BCD5134-0x000000018BCD53D0
		public IEnumerator<ActionEventPtr> GetEnumerator() => default; // 0x000000018BCD6BF0-0x000000018BCD6C3C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCD6B48-0x000000018BCD6B98
		private void HookOnActionChange() {} // 0x0000000185FD7960-0x0000000185FD7970
		private void UnhookOnActionChange() {} // 0x0000000185492010-0x0000000185492020
		private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) {} // 0x000000018BCD6C3C-0x000000018BCD6CBC
		private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) {} // 0x000000018BCD6B98-0x000000018BCD6BF0
	}

	internal static class ArrayHelpers // TypeDefIndex: 45558
	{
		// Nested types
		private sealed class __c__DisplayClass33_0<TValue> // TypeDefIndex: 45555
			where TValue : IEquatable<TValue>
		{
			// Fields
			public TValue secondValue;
	
			// Constructors
			public __c__DisplayClass33_0() {}
	
			// Methods
			internal bool _Merge_b__0(TValue x) => default;
		}
	
		private sealed class __c__DisplayClass34_0<TValue> // TypeDefIndex: 45556
		{
			// Fields
			public IEqualityComparer<TValue> comparer;
	
			// Constructors
			public __c__DisplayClass34_0() {}
		}
	
		private sealed class __c__DisplayClass34_1<TValue> // TypeDefIndex: 45557
		{
			// Fields
			public TValue secondValue;
			public __c__DisplayClass34_0<TValue> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass34_1() {}
	
			// Methods
			internal bool _Merge_b__0(TValue x) => default;
		}
	
		// Methods
		public static int LengthSafe<TValue>(TValue[] array) => default;
		public static void Clear<TValue>(TValue[] array) {}
		public static void Clear<TValue>(TValue[] array, int count) {}
		public static void Clear<TValue>(TValue[] array, ref int count) {}
		public static void EnsureCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x0205C268 */) {}
		public static void DuplicateWithCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x0205C269 */) {}
		public static bool Contains<TValue>(TValue[] array, TValue value) => default;
		public static bool ContainsReference<TValue>(TValue[] array, TValue value)
			where TValue : class => default;
		public static bool ContainsReference<TFirst, TSecond>(TFirst[] array, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class => default;
		public static bool ContainsReference<TFirst, TSecond>(TFirst[] array, int startIndex, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class => default;
		public static bool HaveDuplicateReferences<TFirst>(TFirst[] first, int index, int count) => default;
		public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647 /* Metadata: 0x0205C26A */) => default;
		public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x0205C26B */, int count = -1 /* Metadata: 0x0205C26C */) => default;
		public static int IndexOf<TValue>(TValue[] array, Predicate<TValue> predicate) => default;
		public static int IndexOf<TValue>(TValue[] array, Predicate<TValue> predicate, int startIndex = 0 /* Metadata: 0x0205C26D */, int count = -1 /* Metadata: 0x0205C26E */) => default;
		public static int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int count = -1 /* Metadata: 0x0205C26F */)
			where TFirst : TSecond
			where TSecond : class => default;
		public static int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int startIndex, int count)
			where TFirst : TSecond
			where TSecond : class => default;
		public static int IndexOfValue<TValue>(TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x0205C270 */, int count = -1 /* Metadata: 0x0205C271 */)
			where TValue : struct, IEquatable<TValue> => default;
		public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator)
			where TValue : struct {}
		public static int Append<TValue>(ref ref TValue[] array, TValue value) => default;
		public static int Append<TValue>(ref ref TValue[] array, IEnumerable<TValue> values) => default;
		public static int AppendToImmutable<TValue>(ref ref TValue[] array, TValue[] values) => default;
		public static int AppendWithCapacity<TValue>(ref ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x0205C272 */) => default;
		public static int AppendListWithCapacity<TValue, TValues>(ref ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10 /* Metadata: 0x0205C273 */)
			where TValues : IReadOnlyList<TValue> => default;
		public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x0205C274 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205C275 */)
			where TValue : struct => default;
		public static void InsertAt<TValue>(ref ref TValue[] array, int index, TValue value) {}
		public static void InsertAtWithCapacity<TValue>(ref ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10 /* Metadata: 0x0205C276 */) {}
		public static void PutAtIfNotSet<TValue>(ref ref TValue[] array, int index, Func<TValue> valueFn) {}
		public static int GrowBy<TValue>(ref ref TValue[] array, int count) => default;
		public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205C277 */)
			where TValue : struct => default;
		public static int GrowWithCapacity<TValue>(ref ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x0205C278 */) => default;
		public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x0205C279 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205C27A */)
			where TValue : struct => default;
		public static TValue[] Join<TValue>(TValue value, TValue[] values) => default;
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second)
			where TValue : IEquatable<TValue> => default;
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer) => default;
		public static void EraseAt<TValue>(ref ref TValue[] array, int index) {}
		public static void EraseAtWithCapacity<TValue>(TValue[] array, ref int count, int index) {}
		public static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index)
			where TValue : struct {}
		public static bool Erase<TValue>(ref ref TValue[] array, TValue value) => default;
		public static void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index) {}
		public static TValue[] Copy<TValue>(TValue[] array) => default;
		public static TValue[] Clone<TValue>(TValue[] array)
			where TValue : ICloneable => default;
		public static TNew[] Select<TOld, TNew>(TOld[] array, Func<TOld, TNew> converter) => default;
		private static void Swap<TValue>(ref ref TValue first, ref ref TValue second) {}
		public static void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count) {}
		public static void EraseSliceWithCapacity<TValue>(ref ref TValue[] array, ref int length, int index, int count) {}
		public static void SwapElements<TValue>(TValue[] array, int index1, int index2) {}
		public static void SwapElements<TValue>(NativeArray<TValue> array, int index1, int index2)
			where TValue : struct {}
	}

	internal struct CallbackArray<TDelegate> // TypeDefIndex: 45559
		where TDelegate : Delegate
	{
		// Fields
		private bool m_CannotMutateCallbacksArray;
		private InlinedArray<TDelegate> m_Callbacks;
		private InlinedArray<TDelegate> m_CallbacksToAdd;
		private InlinedArray<TDelegate> m_CallbacksToRemove;
	
		// Properties
		public int length { get => default; }
		public TDelegate this[int index] { get => default; }
	
		// Methods
		public void Clear() {}
		public void AddCallback(TDelegate dlg) {}
		public void RemoveCallback(TDelegate dlg) {}
		public void LockForChanges() {}
		public void UnlockForChanges() {}
	}

	public struct Vector2MagnitudeComparer : IComparer<Vector2> // TypeDefIndex: 45560
	{
		// Methods
		public int Compare(Vector2 x, Vector2 y) => default; // 0x000000018BCE1884-0x000000018BCE18D8
	}

	public struct Vector3MagnitudeComparer : IComparer<Vector3> // TypeDefIndex: 45561
	{
		// Methods
		public int Compare(Vector3 x, Vector3 y) => default; // 0x000000018BCE1DE8-0x000000018BCE1E9C
	}

	internal static class CSharpCodeHelpers // TypeDefIndex: 45562
	{
		// Methods
		public static bool IsProperIdentifier(string name) => default; // 0x000000018BCD5B68-0x000000018BCD5C1C
		public static bool IsEmptyOrProperIdentifier(string name) => default; // 0x000000018BCD5A94-0x000000018BCD5AB4
		public static bool IsEmptyOrProperNamespaceName(string name) => default; // 0x000000018BCD5AB4-0x000000018BCD5B68
		public static string MakeIdentifier(string name, string suffix = "" /* Metadata: 0x0205C27B */) => default; // 0x000000018BCD5C1C-0x000000018BCD5E00
		public static string MakeTypeName(string name, string suffix = "" /* Metadata: 0x0205C27C */) => default; // 0x000000018BCD5E00-0x000000018BCD5EDC
	}

	internal static class DelegateHelpers // TypeDefIndex: 45563
	{
		// Methods
		public static void InvokeCallbacksSafe(ref CallbackArray<Action> callbacks, ProfilerMarker marker, string callbackName, object context = null) {} // 0x0000000184583020-0x0000000184583240
		public static void InvokeCallbacksSafe<TValue>(ref CallbackArray<Action<TValue>> callbacks, TValue argument, string callbackName, object context = null) {}
		public static void InvokeCallbacksSafe<TValue1, TValue2>(ref CallbackArray<Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context = null) {}
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref CallbackArray<Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null) => default;
		public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref CallbackArray<Func<TValue, Action>> callbacks, TValue argument, string callbackName, object context = null) {}
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref CallbackArray<Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context = null) => default;
	}

	public class DisplayStringFormatAttribute : Attribute // TypeDefIndex: 45564
	{
		// Fields
		private string _formatString_k__BackingField; // 0x10
	
		// Properties
		public string formatString { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public DisplayStringFormatAttribute() {} // Dummy constructor
		public DisplayStringFormatAttribute(string formatString) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal static class ExceptionHelpers // TypeDefIndex: 45565
	{
		// Methods
		public static bool IsExceptionIndicatingBugInCode(Exception exception) => default; // 0x000000018BCD6CBC-0x000000018BCD6D40
	}

	public struct FourCC : IEquatable<FourCC> // TypeDefIndex: 45566
	{
		// Fields
		private int m_Code; // 0x00
	
		// Constructors
		public FourCC(int code) {
			m_Code = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
		public FourCC(char a, char b = ' ' /* Metadata: 0x0205C27D */, char c = ' ' /* Metadata: 0x0205C27F */, char d = ' ' /* Metadata: 0x0205C281 */) {
			m_Code = default;
		} // 0x0000000185FD7970-0x0000000185FD79A0
		public FourCC(string str) {
			m_Code = default;
		} // 0x000000018BCD6F18-0x000000018BCD70B4
	
		// Methods
		public static implicit operator int(FourCC fourCC) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static implicit operator FourCC(int i) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public override string ToString() => default; // 0x000000018BCD6D9C-0x000000018BCD6F18
		public bool Equals(FourCC other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public override bool Equals(object obj) => default; // 0x000000018BCD6D40-0x000000018BCD6D9C
		public override int GetHashCode() => default; // 0x00000001818226B0-0x00000001818226C0
		public static bool operator ==(FourCC left, FourCC right) => default; // 0x0000000188645D08-0x0000000188645D10
		public static bool operator !=(FourCC left, FourCC right) => default; // 0x000000018B6328C0-0x000000018B6328C8
		public static FourCC FromInt32(int i) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static int ToInt32(FourCC fourCC) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
	}

	internal struct InlinedArray<TValue> : IEnumerable<TValue> // TypeDefIndex: 45568
	{
		// Fields
		public int length;
		public TValue firstValue;
		public TValue[] additionalValues;
	
		// Properties
		public int Capacity { get => default; }
		public TValue this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 45567
		{
			// Fields
			public InlinedArray<TValue> array;
			public int index;
	
			// Properties
			public TValue Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public InlinedArray(TValue value) : this() {
			length = default;
			firstValue = default;
			additionalValues = default;
		}
		public InlinedArray(TValue firstValue, TValue[] additionalValues) : this() {
			length = default;
			this.firstValue = default;
			this.additionalValues = default;
		}
		public InlinedArray(IEnumerable<TValue> values) : this() {
			length = default;
			firstValue = default;
			additionalValues = default;
		}
	
		// Methods
		public void Clear() {}
		public void ClearWithCapacity() {}
		public InlinedArray<TValue> Clone() => default;
		public void SetLength(int size) {}
		public TValue[] ToArray() => default;
		public TOther[] ToArray<TOther>(Func<TValue, TOther> mapFunction) => default;
		public int IndexOf(TValue value) => default;
		public int Append(TValue value) => default;
		public int AppendWithCapacity(TValue value, int capacityIncrement = 10 /* Metadata: 0x0205C283 */) => default;
		public void AssignWithCapacity(InlinedArray<TValue> values) {}
		public void Append(IEnumerable<TValue> values) {}
		public void Remove(TValue value) {}
		public void RemoveAtWithCapacity(int index) {}
		public void RemoveAt(int index) {}
		public void RemoveAtByMovingTailWithCapacity(int index) {}
		public bool RemoveByMovingTailWithCapacity(TValue value) => default;
		public bool Contains(TValue value, IEqualityComparer<TValue> comparer) => default;
		public void Merge(InlinedArray<TValue> other) {}
		public IEnumerator<TValue> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal static class InputArrayExtensions // TypeDefIndex: 45569
	{
		// Methods
		public static int IndexOfReference<TValue>(InlinedArray<TValue> array, TValue value)
			where TValue : class => default;
		public static bool Contains<TValue>(InlinedArray<TValue> array, TValue value) => default;
		public static bool ContainsReference<TValue>(InlinedArray<TValue> array, TValue value)
			where TValue : class => default;
	}

	public struct InternedString : IEquatable<InternedString>, IComparable<InternedString> // TypeDefIndex: 45570
	{
		// Fields
		private readonly string m_StringOriginalCase; // 0x00
		private readonly string m_StringLowerCase; // 0x08
	
		// Properties
		public int length { get => default; } // 0x000000018BCDDBB4-0x000000018BCDDBC4 
	
		// Constructors
		public InternedString(string text) : this() {
			m_StringOriginalCase = default;
			m_StringLowerCase = default;
		} // 0x00000001846664C0-0x00000001846665B0
	
		// Methods
		public bool IsEmpty() => default; // 0x0000000184005B70-0x0000000184005B80
		public string ToLower() => default; // 0x000000018357A260-0x000000018357A270
		public override bool Equals(object obj) => default; // 0x000000018BCDDAEC-0x000000018BCDDBB4
		public bool Equals(InternedString other) => default; // 0x0000000184116A50-0x0000000184116A60
		public int CompareTo(InternedString other) => default; // 0x000000018BCDDAD4-0x000000018BCDDAEC
		public override int GetHashCode() => default; // 0x0000000184D58910-0x0000000184D58930
		public override string ToString() => default; // 0x00000001841161A0-0x00000001841161F0
		public static bool operator ==(InternedString a, InternedString b) => default; // 0x0000000184116A50-0x0000000184116A60
		public static bool operator !=(InternedString a, InternedString b) => default; // 0x0000000184116A40-0x0000000184116A50
		public static bool operator ==(InternedString a, string b) => default; // 0x000000018BCDDC40-0x000000018BCDDCBC
		public static bool operator !=(InternedString a, string b) => default; // 0x000000018BCDDD5C-0x000000018BCDDDD8
		public static bool operator ==(string a, InternedString b) => default; // 0x000000018BCDDBC4-0x000000018BCDDC40
		public static bool operator !=(string a, InternedString b) => default; // 0x000000018BCDDCE0-0x000000018BCDDD5C
		public static bool operator <(InternedString left, InternedString right) => default; // 0x000000018BCDDDD8-0x000000018BCDDDFC
		public static bool operator >(InternedString left, InternedString right) => default; // 0x000000018BCDDCBC-0x000000018BCDDCE0
		public static implicit operator string(InternedString str) => default; // 0x000000018646D684-0x000000018646D694
	}

	internal struct JsonParser // TypeDefIndex: 45575
	{
		// Fields
		private readonly string m_Text; // 0x00
		private readonly int m_Length; // 0x08
		private int m_Position; // 0x0C
		private bool m_MatchAnyElementInArray; // 0x10
		private bool m_DryRun; // 0x11
	
		// Properties
		public bool isAtEnd { get => default; } // 0x000000018BCE80EC-0x000000018BCE8190 
	
		// Nested types
		public enum JsonValueType // TypeDefIndex: 45571
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
	
		public struct JsonString : IEquatable<JsonString> // TypeDefIndex: 45572
		{
			// Fields
			public Substring text; // 0x00
			public bool hasEscapes; // 0x10
	
			// Methods
			public override string ToString() => default; // 0x0000000184116160-0x00000001841161A0
			public bool Equals(JsonString other) => default; // 0x0000000185FD79D0-0x0000000185FD79E0
			public override bool Equals(object obj) => default; // 0x000000018BCDE638-0x000000018BCDE704
			public override int GetHashCode() => default; // 0x0000000184115E40-0x0000000184116000
			public static bool operator ==(JsonString left, JsonString right) => default; // 0x0000000184115980-0x0000000184115AB0
			public static bool operator !=(JsonString left, JsonString right) => default; // 0x0000000184116000-0x0000000184116070
			public static implicit operator JsonString(string str) => default; // 0x000000018BCDE564-0x000000018BCDE598
		}
	
		public struct JsonValue : IEquatable<JsonValue> // TypeDefIndex: 45574
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
			private sealed class __c // TypeDefIndex: 45573
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<JsonValue, string> __9__11_0; // 0x08
				public static Func<KeyValuePair<string, JsonValue>, string> __9__11_1; // 0x10
	
				// Constructors
				static __c() {} // 0x0000000184115AB0-0x0000000184115B50
				public __c() {} // 0x000000018BCDE3D0-0x000000018BCDE564
	
				// Methods
				internal string _ToString_b__11_0(JsonValue x) => default; // 0x000000018BCDDDFC-0x000000018BCDE078
				internal string _ToString_b__11_1(KeyValuePair<string, JsonValue> pair) => default; // 0x000000018BCDE1C8-0x000000018BCDE3D0
			}
	
			// Methods
			public bool ToBoolean() => default; // 0x0000000184115B50-0x0000000184115E40
			public long ToInteger() => default; // 0x000000018BCDE078-0x000000018BCDE170
			public double ToDouble() => default; // 0x000000018BCDE170-0x000000018BCDE1C8
			public override string ToString() => default; // 0x0000000184116070-0x00000001841160C0
			public static implicit operator JsonValue(bool val) => default; // 0x000000018BCDE598-0x000000018BCDE638
			public static implicit operator JsonValue(long val) => default; // 0x00000001841160C0-0x0000000184116160
			public static implicit operator JsonValue(double val) => default; // 0x000000018BCDE704-0x000000018BCDE710
			public static implicit operator JsonValue(string str) => default; // 0x000000018BCDE968-0x000000018BCDEA34
			public static implicit operator JsonValue(JsonString str) => default; // 0x000000018BCDE710-0x000000018BCDE888
			public static implicit operator JsonValue(List<JsonValue> array) => default; // 0x000000018BCDE888-0x000000018BCDE900
			public static implicit operator JsonValue(Dictionary<string, JsonValue> obj) => default; // 0x000000018BCDE900-0x000000018BCDE968
			public static implicit operator JsonValue(Enum val) => default; // 0x000000018BCDEA34-0x000000018BCDEA60
			public bool Equals(JsonValue other) => default; // 0x000000018BCDEA9C-0x000000018BCDEAC8
			private static bool Equals(object obj, JsonValue value) => default; // 0x000000018BCDEA60-0x000000018BCDEA9C
			public override bool Equals(object obj) => default; // 0x000000018BCDEC80-0x000000018BCDED0C
			public override int GetHashCode() => default; // 0x000000018BCDEDA8-0x000000018BCDEE34
			public static bool operator ==(JsonValue left, JsonValue right) => default; // 0x000000018BCDED0C-0x000000018BCDEDA8
			public static bool operator !=(JsonValue left, JsonValue right) => default; // 0x000000018BCDEE34-0x000000018BCDF248
		}
	
		// Constructors
		public JsonParser(string json) : this() {
			m_Text = default;
			m_Length = default;
			m_Position = default;
			m_MatchAnyElementInArray = default;
			m_DryRun = default;
		} // 0x0000000185FD79E0-0x0000000185FD7A10
	
		// Methods
		public void Reset() {} // 0x0000000185FD7A10-0x0000000185FD7A40
		public override string ToString() => default; // 0x0000000185FD7A40-0x0000000185FD7A70
		public bool NavigateToProperty(string path) => default; // 0x000000018BCDF28C-0x000000018BCDF30C
		public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) => default; // 0x000000018BCDF350-0x000000018BCDF39C
		public bool ParseToken(char token) => default; // 0x000000018BCDF248-0x000000018BCDF28C
		public bool ParseValue() => default; // 0x000000018BCDF39C-0x000000018BCDF3E0
		public bool ParseValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x000000018BCDF30C-0x000000018BCDF350
		public bool ParseStringValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x00000001851C3DD0-0x00000001851C3EA0
		public bool ParseArrayValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x00000001851C3EA0-0x00000001851C4060
		public bool ParseObjectValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x000000018BCDEAC8-0x000000018BCDEB60
		public bool ParseNumber(out JsonValue result) {
			result = default;
			return default;
		} // 0x000000018BCDEB60-0x000000018BCDEC80
		public bool ParseBooleanValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x000000018646DCB8-0x000000018646DCFC
		public bool ParseNullValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x000000018BCDF3E0-0x000000018BCDF424
		public bool SkipToValue() => default; // 0x000000018BCE8280-0x000000018BCE82E4
		private bool SkipString(string text) => default; // 0x0000000185492010-0x0000000185492020
		private void SkipWhitespace() {} // 0x000000018BCE80D8-0x000000018BCE80EC
	}

	internal static class MemoryHelpers // TypeDefIndex: 45577
	{
		// Nested types
		public struct BitRegion // TypeDefIndex: 45576
		{
			// Fields
			public uint bitOffset; // 0x00
			public uint sizeInBits; // 0x04
	
			// Properties
			public bool isEmpty { get => default; } // 0x00000001845822F0-0x0000000184582370 
	
			// Constructors
			public BitRegion(uint bitOffset, uint sizeInBits) : this() {
				this.bitOffset = default;
				this.sizeInBits = default;
			} // 0x000000018BCE2634-0x000000018BCE264C
			public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits) : this() {
				this.bitOffset = default;
				this.sizeInBits = default;
			} // 0x0000000185A274B0-0x0000000185A274E0
	
			// Methods
			public BitRegion Overlap(BitRegion other) => default; // 0x0000000184582370-0x00000001845823A0
		}
	
		// Methods
		public static unsafe bool Compare(void* ptr1, void* ptr2, BitRegion region) => default; // 0x000000018BCE264C-0x000000018BCE273C
		public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits) => default; // 0x00000001845824C0-0x0000000184582630
		public static unsafe void WriteSingleBit(void* ptr, uint bitOffset, bool value) {} // 0x000000018BCE2834-0x000000018BCE28F0
		public static unsafe bool ReadSingleBit(void* ptr, uint bitOffset) => default; // 0x000000018BCE273C-0x000000018BCE2834
		public static unsafe void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount) {} // 0x000000018BCE2950-0x000000018BCE2B28
		public static unsafe bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null) => default; // 0x000000018BCE2BAC-0x000000018BCE2DB4
		public static unsafe void MemSet(void* destination, int numBytes, byte value) {} // 0x000000018BCE2B28-0x000000018BCE2B30
		public static unsafe void MemCpyMasked(void* destination, void* source, int numBytes, void* mask) {} // 0x000000018BCE2B5C-0x000000018BCE2B6C
		public static unsafe uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x000000018BCE28F0-0x000000018BCE291C
		public static unsafe void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value) {} // 0x000000018BCE2B30-0x000000018BCE2B5C
		public static unsafe int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x000000018BCE291C-0x000000018BCE2950
		public static unsafe void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) {} // 0x000000018BCE2B6C-0x000000018BCE2BAC
		public static unsafe int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x0000000184007070-0x00000001840071A0
		public static unsafe void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) {}
		public static unsafe float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x000000018BCE25E0-0x000000018BCE2634
		public static unsafe void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value) {} // 0x00000001842FA4F0-0x00000001842FA500
		public static unsafe void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) {} // 0x000000018357CB90-0x000000018357CBA0
		public static void Swap<TValue>(ref ref TValue a, ref ref TValue b) {} // 0x0000000185FD7AA0-0x0000000185FD7AB0
		public static uint AlignNatural(uint offset, uint sizeInBytes) => default; // 0x0000000184582230-0x00000001845822D0
	}

	internal static class MiscHelpers // TypeDefIndex: 45579
	{
		// Nested types
		private sealed class _EveryNth_d__1<TValue> : IEnumerable<TValue>, IEnumerator<TValue> // TypeDefIndex: 45578
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
			TValue IEnumerator<TValue>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _EveryNth_d__1() {} // Dummy constructor
			public _EveryNth_d__1(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			private void __m__Finally1() {}
			void IEnumerator.Reset() {}
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Methods
		public static TValue GetValueOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key) => default;
		public static IEnumerable<TValue> EveryNth<TValue>(IEnumerable<TValue> enumerable, int n, int start = 0 /* Metadata: 0x0205C28C */) => default;
		public static int IndexOf<TValue>(IEnumerable<TValue> enumerable, TValue value) => default;
	}

	public struct NameAndParameters // TypeDefIndex: 45581
	{
		// Fields
		private string _name_k__BackingField; // 0x00
		private ReadOnlyArray<NamedValue> _parameters_k__BackingField; // 0x08
	
		// Properties
		public string name { get; set; } // 0x000000018BCE3224-0x000000018BCE3234 0x000000018BCE2FE8-0x000000018BCE3224
		public ReadOnlyArray<NamedValue> parameters { get; set; } // 0x000000018BCE2DB4-0x000000018BCE2E0C 0x000000018BCE2E0C-0x000000018BCE2F60
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 45580
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NamedValue, string> __9__8_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001834AFB60-0x00000001834AFB70
			public __c() {} // 0x000000018646FE2C-0x000000018646FE34
	
			// Methods
			internal string _ToString_b__8_0(NamedValue x) => default; // 0x0000000183577F20-0x0000000183577F30
		}
	
		// Methods
		public override string ToString() => default; // 0x000000018BCE2F60-0x000000018BCE2FE8
		public static IEnumerable<NameAndParameters> ParseMultiple(string text) => default; // 0x00000001841133C0-0x0000000184113410
		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list) => default; // 0x00000001841134C0-0x00000001841136B0
		internal static string ParseName(string text) => default; // 0x000000018BCE81B8-0x000000018BCE821C
		public static NameAndParameters Parse(string text) => default; // 0x0000000185492010-0x0000000185492020
		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false /* Metadata: 0x0205C28D */) => default; // 0x000000018BCE8190-0x000000018BCE81A4
	}

	public struct NamedValue : IEquatable<NamedValue> // TypeDefIndex: 45582
	{
		// Fields
		public const string Separator = ","; // Metadata: 0x0205C28E
		private string _name_k__BackingField; // 0x00
		private PrimitiveValue _value_k__BackingField; // 0x08
	
		// Properties
		public string name { get; set; } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public PrimitiveValue value { get; set; } // 0x0000000183577F20-0x0000000183577F30 0x0000000185FD13F0-0x0000000185FD1400
		public TypeCode type { get => default; } // 0x0000000181B7E450-0x0000000181B7E460 
	
		// Methods
		public NamedValue ConvertTo(TypeCode type) => default; // 0x000000018BCE3494-0x000000018BCE34EC
		public static NamedValue From<TValue>(string name, TValue value)
			where TValue : struct => default;
		public override string ToString() => default; // 0x000000018BCE3A44-0x000000018BCE3AB8
		public bool Equals(NamedValue other) => default; // 0x000000018BCE34EC-0x000000018BCE3548
		public override bool Equals(object obj) => default; // 0x000000018BCE3548-0x000000018BCE35C0
		public override int GetHashCode() => default; // 0x000000018BCE35C0-0x000000018BCE360C
		public static bool operator ==(NamedValue left, NamedValue right) => default; // 0x000000018BCE3AB8-0x000000018BCE3AE4
		public static bool operator !=(NamedValue left, NamedValue right) => default; // 0x000000018BCE3AE4-0x000000018BCE3B10
		public static NamedValue[] ParseMultiple(string parameterString) => default; // 0x000000018BCE360C-0x000000018BCE3770
		public static NamedValue Parse(string str) => default; // 0x000000018BCE3A08-0x000000018BCE3A44
		private static NamedValue ParseParameter(string parameterString, ref int index) => default; // 0x000000018BCE3770-0x000000018BCE3A08
		public void ApplyToObject(object instance) {} // 0x000000018BCE3234-0x000000018BCE3494
		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters)
			where TParameterList : IEnumerable<NamedValue> {}
	}

	internal static class NumberHelpers // TypeDefIndex: 45583
	{
		// Methods
		public static int AlignToMultipleOf(int number, int alignment) => default; // 0x000000018BCE3B10-0x000000018BCE3B28
		public static long AlignToMultipleOf(long number, long alignment) => default; // 0x000000018BCE3B40-0x000000018BCE3B5C
		public static uint AlignToMultipleOf(uint number, uint alignment) => default; // 0x000000018BCE3B28-0x000000018BCE3B40
		public static bool Approximately(double a, double b) => default; // 0x000000018BCE3B5C-0x000000018BCE3BFC
		public static float IntToNormalizedFloat(int value, int minValue, int maxValue) => default; // 0x000000018BCE3BFC-0x000000018BCE3C44
		public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) => default; // 0x000000018BCE3C44-0x000000018BCE3C8C
		public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue) => default; // 0x000000018BCE3D1C-0x000000018BCE3D6C
		public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue) => default; // 0x000000018BCE3C8C-0x000000018BCE3CDC
		public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize) => default; // 0x000000018BCE3CDC-0x000000018BCE3D1C
	}

	internal class ForDeviceEventObservable : IObservable<InputEventPtr> // TypeDefIndex: 45585
	{
		// Fields
		private IObservable<InputEventPtr> m_Source; // 0x10
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
		private System.Type m_DeviceType; // 0x20
	
		// Nested types
		private class ForDevice : IObserver<InputEventPtr> // TypeDefIndex: 45584
		{
			// Fields
			private IObserver<InputEventPtr> m_Observer; // 0x10
			private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
			private System.Type m_DeviceType; // 0x20
	
			// Constructors
			public ForDevice() {} // Dummy constructor
			public ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, IObserver<InputEventPtr> observer) {} // 0x000000018BCE2430-0x000000018BCE2468
	
			// Methods
			public void OnCompleted() {} // 0x000000018BCE2378-0x000000018BCE2430
			public void OnError(Exception error) {} // 0x000000018BCE25A8-0x000000018BCE25E0
			public void OnNext(InputEventPtr value) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public ForDeviceEventObservable() {} // Dummy constructor
		public ForDeviceEventObservable(IObservable<InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device) {} // 0x000000018BCE2468-0x000000018BCE24B4
	
		// Methods
		public IDisposable Subscribe(IObserver<InputEventPtr> observer) => default; // 0x000000018BCE24B4-0x000000018BCE25A8
	}

	public static class Observable // TypeDefIndex: 45587
	{
		// Nested types
		private sealed class __c__DisplayClass6_0<TValue> // TypeDefIndex: 45586
		{
			// Fields
			public IDisposable subscription;
	
			// Constructors
			public __c__DisplayClass6_0() {}
	
			// Methods
			internal void _CallOnce_b__0() {}
		}
	
		// Methods
		public static IObservable<TValue> Where<TValue>(IObservable<TValue> source, Func<TValue, bool> predicate) => default;
		public static IObservable<TResult> Select<TSource, TResult>(IObservable<TSource> source, Func<TSource, TResult> filter) => default;
		public static IObservable<TResult> SelectMany<TSource, TResult>(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter) => default; // 0x000000018BCE3D6C-0x000000018BCE3E34
		public static IObservable<TValue> Take<TValue>(IObservable<TValue> source, int count) => default;
		public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source, UnityEngine.InputSystem.InputDevice device) => default;
		public static IObservable<InputEventPtr> ForDevice<TDevice>(IObservable<InputEventPtr> source)
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static IDisposable CallOnce<TValue>(IObservable<TValue> source, Action<TValue> action) => default;
		public static IDisposable Call<TValue>(IObservable<TValue> source, Action<TValue> action) => default;
	}

	internal class Observer<TValue> : IObserver<TValue> // TypeDefIndex: 45588
	{
		// Fields
		private Action<TValue> m_OnNext;
		private Action m_OnCompleted;
	
		// Constructors
		public Observer() {} // Dummy constructor
		public Observer(Action<TValue> onNext, Action onCompleted = null) {}
	
		// Methods
		public void OnCompleted() {}
		public void OnError(Exception error) {}
		public void OnNext(TValue evt) {}
	}

	internal class SelectManyObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 45590
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, IEnumerable<TResult>> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 45589
		{
			// Fields
			private SelectManyObservable<TSource, TResult> m_Observable;
			private readonly IObserver<TResult> m_Observer;
	
			// Constructors
			public Select() {} // Dummy constructor
			public Select(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer) {}
	
			// Methods
			public void OnCompleted() {}
			public void OnError(Exception error) {}
			public void OnNext(TSource evt) {}
		}
	
		// Constructors
		public SelectManyObservable() {} // Dummy constructor
		public SelectManyObservable(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter) {}
	
		// Methods
		public IDisposable Subscribe(IObserver<TResult> observer) => default;
	}

	internal class TakeNObservable<TValue> : IObservable<TValue> // TypeDefIndex: 45592
	{
		// Fields
		private IObservable<TValue> m_Source;
		private int m_Count;
	
		// Nested types
		private class Take : IObserver<TValue> // TypeDefIndex: 45591
		{
			// Fields
			private IObserver<TValue> m_Observer;
			private int m_Remaining;
	
			// Constructors
			public Take() {} // Dummy constructor
			public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer) {}
	
			// Methods
			public void OnCompleted() {}
			public void OnError(Exception error) {}
			public void OnNext(TValue evt) {}
		}
	
		// Constructors
		public TakeNObservable() {} // Dummy constructor
		public TakeNObservable(IObservable<TValue> source, int count) {}
	
		// Methods
		public IDisposable Subscribe(IObserver<TValue> observer) => default;
	}

	internal class WhereObservable<TValue> : IObservable<TValue> // TypeDefIndex: 45594
	{
		// Fields
		private readonly IObservable<TValue> m_Source;
		private readonly Func<TValue, bool> m_Predicate;
	
		// Nested types
		private class Where : IObserver<TValue> // TypeDefIndex: 45593
		{
			// Fields
			private WhereObservable<TValue> m_Observable;
			private readonly IObserver<TValue> m_Observer;
	
			// Constructors
			public Where() {} // Dummy constructor
			public Where(WhereObservable<TValue> observable, IObserver<TValue> observer) {}
	
			// Methods
			public void OnCompleted() {}
			public void OnError(Exception error) {}
			public void OnNext(TValue evt) {}
		}
	
		// Constructors
		public WhereObservable() {} // Dummy constructor
		public WhereObservable(IObservable<TValue> source, Func<TValue, bool> predicate) {}
	
		// Methods
		public IDisposable Subscribe(IObserver<TValue> observer) => default;
	}

	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue> // TypeDefIndex: 45596
		where TList : IReadOnlyList<TValue>
	{
		// Fields
		private readonly bool m_IsSingle;
		private readonly TValue m_Single;
		private readonly TList m_Multiple;
	
		// Properties
		public int Count { get => default; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		private class Enumerator : IEnumerator<TValue> // TypeDefIndex: 45595
		{
			// Fields
			internal int m_Index;
			internal OneOrMore<TValue, TList> m_List;
	
			// Properties
			public TValue Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator() {}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public OneOrMore(TValue single) : this() {
			m_IsSingle = default;
			m_Single = default;
			m_Multiple = default;
		}
		public OneOrMore(TList multiple) : this() {
			m_IsSingle = default;
			m_Single = default;
			m_Multiple = default;
		}
	
		// Methods
		public static implicit operator OneOrMore<TValue, TList>(TValue single) => default;
		public static implicit operator OneOrMore<TValue, TList>(TList multiple) => default;
		public IEnumerator<TValue> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal struct PredictiveParser // TypeDefIndex: 45597
	{
		// Fields
		private int m_Position; // 0x00
	
		// Methods
		public void ExpectSingleChar(ReadOnlySpan<char> str, char c) {} // 0x0000000184033100-0x0000000184033140
		public int ExpectInt(ReadOnlySpan<char> str) => default; // 0x00000001840332C0-0x0000000184033360
		public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str) => default; // 0x0000000184033360-0x00000001840334A0
		public bool AcceptSingleChar(ReadOnlySpan<char> str, char c) => default; // 0x0000000184033290-0x00000001840332C0
		public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output) {
			output = default;
			return default;
		} // 0x0000000185166210-0x0000000185166330
		public void AcceptInt(ReadOnlySpan<char> str) {} // 0x0000000184CF9440-0x0000000184CF9490
	}

	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible // TypeDefIndex: 45598
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
		internal unsafe byte* valuePtr { get => default; } // 0x0000000185FD7D80-0x0000000185FD7D90 
		public TypeCode type { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		public bool isEmpty { get => default; } // 0x00000001840066E0-0x00000001840066F0 
	
		// Constructors
		public PrimitiveValue(bool value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7CE0-0x0000000185FD7CF0
		public PrimitiveValue(char value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7C40-0x0000000185FD7C60
		public PrimitiveValue(byte value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7D10-0x0000000185FD7D20
		public PrimitiveValue(sbyte value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7C30-0x0000000185FD7C40
		public PrimitiveValue(short value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7CC0-0x0000000185FD7CE0
		public PrimitiveValue(ushort value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7D60-0x0000000185FD7D80
		public PrimitiveValue(int value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7D40-0x0000000185FD7D60
		public PrimitiveValue(uint value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7D20-0x0000000185FD7D40
		public PrimitiveValue(long value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7CA0-0x0000000185FD7CC0
		public PrimitiveValue(ulong value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7C80-0x0000000185FD7CA0
		public PrimitiveValue(float value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7C60-0x0000000185FD7C80
		public PrimitiveValue(double value) : this() {
			m_Type = default;
			m_BoolValue = default;
			m_CharValue = default;
			m_ByteValue = default;
			m_SByteValue = default;
			m_ShortValue = default;
			m_UShortValue = default;
			m_IntValue = default;
			m_UIntValue = default;
			m_LongValue = default;
			m_ULongValue = default;
			m_FloatValue = default;
			m_DoubleValue = default;
		} // 0x0000000185FD7CF0-0x0000000185FD7D10
	
		// Methods
		public PrimitiveValue ConvertTo(TypeCode type) => default; // 0x000000018BCE42FC-0x000000018BCE4578
		public bool Equals(PrimitiveValue other) => default; // 0x000000018BCE4578-0x000000018BCE45A4
		public override bool Equals(object obj) => default; // 0x000000018BCE45A4-0x000000018BCE4754
		public static bool operator ==(PrimitiveValue left, PrimitiveValue right) => default; // 0x000000018BCE5788-0x000000018BCE57A8
		public static bool operator !=(PrimitiveValue left, PrimitiveValue right) => default; // 0x000000018BCE57A8-0x000000018BCE57C8
		public override int GetHashCode() => default; // 0x000000018BCE4F14-0x000000018BCE4F34
		public override string ToString() => default; // 0x000000018BCE532C-0x000000018BCE5698
		public static PrimitiveValue FromString(string value) => default; // 0x000000018BCE4BD4-0x000000018BCE4F14
		public TypeCode GetTypeCode() => default; // 0x00000001818226B0-0x00000001818226C0
		public bool ToBoolean(IFormatProvider provider = null) => default; // 0x000000018BCE4F34-0x000000018BCE4FC8
		public byte ToByte(IFormatProvider provider = null) => default; // 0x000000018BCE4FC8-0x000000018BCE4FD0
		public char ToChar(IFormatProvider provider = null) => default; // 0x000000018BCE4FD0-0x000000018BCE4FFC
		public System.DateTime ToDateTime(IFormatProvider provider = null) => default; // 0x000000018BCE4FFC-0x000000018BCE5058
		public decimal ToDecimal(IFormatProvider provider = null) => default; // 0x000000018BCE5058-0x000000018BCE5094
		public double ToDouble(IFormatProvider provider = null) => default; // 0x00000001859268F0-0x0000000185926910
		public short ToInt16(IFormatProvider provider = null) => default; // 0x000000018BCE4FC8-0x000000018BCE4FD0
		public int ToInt32(IFormatProvider provider = null) => default; // 0x000000018BCE4FC8-0x000000018BCE4FD0
		public long ToInt64(IFormatProvider provider = null) => default; // 0x000000018BCE5094-0x000000018BCE5114
		public sbyte ToSByte(IFormatProvider provider = null) => default; // 0x000000018BCE4FC8-0x000000018BCE4FD0
		public float ToSingle(IFormatProvider provider = null) => default; // 0x000000018646D660-0x000000018646D678
		public string ToString(IFormatProvider provider) => default; // 0x000000018BCE5698-0x000000018BCE56A0
		public object ToType(System.Type conversionType, IFormatProvider provider) => default; // 0x000000018BCE56A0-0x000000018BCE56EC
		public ushort ToUInt16(IFormatProvider provider = null) => default; // 0x000000018BCE56EC-0x000000018BCE56F8
		public uint ToUInt32(IFormatProvider provider = null) => default; // 0x000000018BCE56EC-0x000000018BCE56F8
		public ulong ToUInt64(IFormatProvider provider = null) => default; // 0x000000018BCE56F8-0x000000018BCE5788
		public object ToObject() => default; // 0x000000018BCE5114-0x000000018BCE532C
		public static PrimitiveValue From<TValue>(TValue value)
			where TValue : struct => default;
		public static PrimitiveValue FromObject(object value) => default; // 0x000000018BCE4754-0x000000018BCE4BD4
		public static implicit operator PrimitiveValue(bool value) => default; // 0x0000000185FD7AB0-0x0000000185FD7AD0
		public static implicit operator PrimitiveValue(char value) => default; // 0x0000000185FD7AF0-0x0000000185FD7B10
		public static implicit operator PrimitiveValue(byte value) => default; // 0x0000000185FD7AD0-0x0000000185FD7AF0
		public static implicit operator PrimitiveValue(sbyte value) => default; // 0x0000000185FD7B90-0x0000000185FD7BB0
		public static implicit operator PrimitiveValue(short value) => default; // 0x0000000185FD7B30-0x0000000185FD7B50
		public static implicit operator PrimitiveValue(ushort value) => default; // 0x0000000185FD7BD0-0x0000000185FD7BF0
		public static implicit operator PrimitiveValue(int value) => default; // 0x0000000185FD7B50-0x0000000185FD7B70
		public static implicit operator PrimitiveValue(uint value) => default; // 0x0000000185FD7BF0-0x0000000185FD7C10
		public static implicit operator PrimitiveValue(long value) => default; // 0x0000000185FD7B70-0x0000000185FD7B90
		public static implicit operator PrimitiveValue(ulong value) => default; // 0x0000000185FD7C10-0x0000000185FD7C30
		public static implicit operator PrimitiveValue(float value) => default; // 0x0000000185FD7BB0-0x0000000185FD7BD0
		public static implicit operator PrimitiveValue(double value) => default; // 0x0000000185FD7B10-0x0000000185FD7B30
		public static PrimitiveValue FromBoolean(bool value) => default; // 0x0000000185FD7AB0-0x0000000185FD7AD0
		public static PrimitiveValue FromChar(char value) => default; // 0x0000000185FD7AF0-0x0000000185FD7B10
		public static PrimitiveValue FromByte(byte value) => default; // 0x0000000185FD7AD0-0x0000000185FD7AF0
		public static PrimitiveValue FromSByte(sbyte value) => default; // 0x0000000185FD7B90-0x0000000185FD7BB0
		public static PrimitiveValue FromInt16(short value) => default; // 0x0000000185FD7B30-0x0000000185FD7B50
		public static PrimitiveValue FromUInt16(ushort value) => default; // 0x0000000185FD7BD0-0x0000000185FD7BF0
		public static PrimitiveValue FromInt32(int value) => default; // 0x0000000185FD7B50-0x0000000185FD7B70
		public static PrimitiveValue FromUInt32(uint value) => default; // 0x0000000185FD7BF0-0x0000000185FD7C10
		public static PrimitiveValue FromInt64(long value) => default; // 0x0000000185FD7B70-0x0000000185FD7B90
		public static PrimitiveValue FromUInt64(ulong value) => default; // 0x0000000185FD7C10-0x0000000185FD7C30
		public static PrimitiveValue FromSingle(float value) => default; // 0x0000000185FD7BB0-0x0000000185FD7BD0
		public static PrimitiveValue FromDouble(double value) => default; // 0x0000000185FD7B10-0x0000000185FD7B30
	}

	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue> // TypeDefIndex: 45600
	{
		// Fields
		internal TValue[] m_Array;
		internal int m_StartIndex;
		internal int m_Length;
	
		// Properties
		public int Count { get => default; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 45599
		{
			// Fields
			private readonly TValue[] m_Array;
			private readonly int m_IndexStart;
			private readonly int m_IndexEnd;
			private int m_Index;
	
			// Properties
			public TValue Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(TValue[] array, int index, int length) : this() {
				m_Array = default;
				m_IndexStart = default;
				m_IndexEnd = default;
				m_Index = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public ReadOnlyArray(TValue[] array) : this() {
			m_Array = default;
			m_StartIndex = default;
			m_Length = default;
		}
		public ReadOnlyArray(TValue[] array, int index, int length) : this() {
			m_Array = default;
			m_StartIndex = default;
			m_Length = default;
		}
	
		// Methods
		public TValue[] ToArray() => default;
		public int IndexOf(Predicate<TValue> predicate) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public static implicit operator ReadOnlyArray<TValue>(TValue[] array) => default;
	}

	public static class ReadOnlyArrayExtensions // TypeDefIndex: 45601
	{
		// Methods
		public static bool Contains<TValue>(ReadOnlyArray<TValue> array, TValue value)
			where TValue : IComparable<TValue> => default;
		public static bool ContainsReference<TValue>(ReadOnlyArray<TValue> array, TValue value)
			where TValue : class => default;
		public static int IndexOfReference<TValue>(ReadOnlyArray<TValue> array, TValue value)
			where TValue : class => default;
		internal static bool HaveEqualReferences<TValue>(ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647 /* Metadata: 0x0205C290 */) => default;
	}

	internal interface ISavedState // TypeDefIndex: 45602
	{
		// Methods
		void StaticDisposeCurrentState();
		void RestoreSavedState();
	}

	internal sealed class SavedStructState<T> : ISavedState // TypeDefIndex: 45604
		where T : struct
	{
		// Fields
		private T m_State;
		private TypedRestore m_RestoreAction;
		private Action m_StaticDisposeCurrentState;
	
		// Nested types
		public delegate void TypedRestore(ref ref T state); // TypeDefIndex: 45603; 0x00000000-0x00000000
	
		// Constructors
		public SavedStructState() {} // Dummy constructor
		internal SavedStructState(ref ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState = null) {}
	
		// Methods
		public void StaticDisposeCurrentState() {}
		public void RestoreSavedState() {}
	}

	internal static class SpriteUtilities // TypeDefIndex: 45605
	{
		// Methods
		public static Sprite CreateCircleSprite(int radius, Color32 colour) => default; // 0x000000018BCE57C8-0x000000018BCE59B8
	}

	internal static class StringHelpers // TypeDefIndex: 45608
	{
		// Nested types
		private sealed class _Tokenize_d__8 : IEnumerable<Substring>, IEnumerator<Substring> // TypeDefIndex: 45606
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
			Substring IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.Current { get => default; } // 0x000000018BCE59B8-0x000000018BCE59D8 
			object IEnumerator.Current { get => default; } // 0x000000018BCE60CC-0x000000018BCE6240 
	
			// Constructors
			public _Tokenize_d__8() {} // Dummy constructor
			public _Tokenize_d__8(int __1__state) {} // 0x000000018BCE5A58-0x000000018BCE5B98
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCE64DC-0x000000018BCE6618
			private bool MoveNext() => default; // 0x000000018BCE59D8-0x000000018BCE59F8
			void IEnumerator.Reset() {} // 0x000000018BCE5EC4-0x000000018BCE6040
			IEnumerator<Substring> IEnumerable<Substring>.GetEnumerator() => default; // 0x000000018BCE5D58-0x000000018BCE5EC4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCE59F8-0x000000018BCE5A58
		}
	
		private sealed class _Split_d__9 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 45607
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
			string IEnumerator<System.String>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x00000001840060D0-0x0000000184006340 
	
			// Constructors
			public _Split_d__9() {} // Dummy constructor
			public _Split_d__9(int __1__state) {} // 0x000000018BCE646C-0x000000018BCE64DC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCE63E4-0x000000018BCE646C
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
			IEnumerator<string> IEnumerable<string>.GetEnumerator() => default; // 0x000000018BCE6240-0x000000018BCE62C8
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BCE6884-0x000000018BCE68A4
		}
	
		// Methods
		public static string Escape(string str, string chars = "\n\t\r\\\"" /* Metadata: 0x0205C291 */, string replacements = "ntr\\\"" /* Metadata: 0x0205C297 */) => default; // 0x000000018BCE66E4-0x000000018BCE6884
		public static string Unescape(string str, string chars = "ntr\\\"" /* Metadata: 0x0205C29D */, string replacements = "\n\t\r\\\"" /* Metadata: 0x0205C2A3 */) => default; // 0x000000018BCE63C4-0x000000018BCE63E4
		public static bool Contains(string str, char ch) => default; // 0x000000018BCE62C8-0x000000018BCE63C4
		public static bool Contains(string str, string text, StringComparison comparison) => default; // 0x000000018BCE6068-0x000000018BCE60CC
		public static string GetPlural(string str) => default; // 0x000000018BCE6618-0x000000018BCE66E4
		public static string NicifyMemorySize(long numBytes) => default; // 0x000000018BCE6040-0x000000018BCE6068
		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1 /* Metadata: 0x0205C2A9 */) {
			result = default;
			return default;
		} // 0x000000018BCE5B98-0x000000018BCE5D58
		public static int CountOccurrences(string str, char ch) => default; // 0x00000001853410F0-0x0000000185341110
		public static IEnumerable<Substring> Tokenize(string str) => default; // 0x0000000185492010-0x0000000185492020
		public static IEnumerable<string> Split(string str, Func<char, bool> predicate) => default; // 0x000000018BCE7D84-0x000000018BCE7FA8
		public static string Join<TValue>(string separator, TValue[] values) => default; // 0x0000000185FB30D0-0x0000000185FB30E0
		public static string Join<TValue>(IEnumerable<TValue> values, string separator) => default; // 0x000000018BCE8044-0x000000018BCE8090
		public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc) => default; // 0x000000018BCE8090-0x000000018BCE80D8
		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator) => default; // 0x000000018BCE7FA8-0x000000018BCE803C
		public static int ParseInt(string str, int pos) => default; // 0x000000018BCE803C-0x000000018BCE8044
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) => default; // 0x0000000184775050-0x0000000184775070
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset) => default; // 0x0000000185492010-0x0000000185492020
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) => default; // 0x000000018BCE7B8C-0x000000018BCE7C8C
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool IsPrintable(char ch) => default; // 0x000000018BCE7D38-0x000000018BCE7D84
		public static string WithAllWhitespaceStripped(string str) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool InvariantEqualsIgnoreCase(string left, string right) => default; // 0x000000018BCE7C8C-0x000000018BCE7D30
		public static string ExpandTemplateString(string template, Func<string, string> mapFunc) => default; // 0x000000018BCE7D30-0x000000018BCE7D38
	}

	internal struct Substring : IComparable<Substring>, IEquatable<Substring> // TypeDefIndex: 45609
	{
		// Fields
		private readonly string m_String; // 0x00
		private readonly int m_Index; // 0x08
		private readonly int m_Length; // 0x0C
	
		// Properties
		public bool isEmpty { get => default; } // 0x000000018BCE6D30-0x000000018BCE6D38 
		public int length { get => default; } // 0x00000001834AFB70-0x00000001834AFB80 
		public int index { get => default; } // 0x0000000181B7E450-0x0000000181B7E460 
		public char this[int index] { get => default; } // 0x000000018BCE6CB0-0x000000018BCE6D30 
	
		// Constructors
		public Substring(string str) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x000000018BCE6C44-0x000000018BCE6C7C
		public Substring(string str, int index, int length) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x000000018646D7F4-0x000000018646D814
		public Substring(string str, int index) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x000000018BCE6C7C-0x000000018BCE6CB0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BCE6998-0x000000018BCE6A30
		public bool Equals(string other) => default; // 0x000000018BCE6A54-0x000000018BCE6AE4
		public bool Equals(Substring other) => default; // 0x000000018BCE6A30-0x000000018BCE6A54
		public bool Equals(InternedString other) => default; // 0x000000018BCE6918-0x000000018BCE6998
		public int CompareTo(Substring other) => default; // 0x000000018BCE68A4-0x000000018BCE68D4
		public static int Compare(Substring left, Substring right, StringComparison comparison) => default; // 0x000000018BCE68D4-0x000000018BCE6918
		public bool StartsWith(string str) => default; // 0x000000018BCE6B34-0x000000018BCE6BB4
		public string Substr(int index = 0 /* Metadata: 0x0205C2B1 */, int length = -1 /* Metadata: 0x0205C2B2 */) => default; // 0x000000018BCE6BB4-0x000000018BCE6BE8
		public override string ToString() => default; // 0x000000018BCE6BE8-0x000000018BCE6C44
		public override int GetHashCode() => default; // 0x000000018BCE6AE4-0x000000018BCE6B34
		public static bool operator ==(Substring a, Substring b) => default; // 0x000000018BCE6D38-0x000000018BCE6D58
		public static bool operator !=(Substring a, Substring b) => default; // 0x000000018BCE6DBC-0x000000018BCE6DDC
		public static bool operator ==(Substring a, InternedString b) => default; // 0x000000018BCE6D7C-0x000000018BCE6D9C
		public static bool operator !=(Substring a, InternedString b) => default; // 0x000000018BCE6DDC-0x000000018BCE6DFC
		public static bool operator ==(InternedString a, Substring b) => default; // 0x000000018BCE6D58-0x000000018BCE6D7C
		public static bool operator !=(InternedString a, Substring b) => default; // 0x000000018BCE6DFC-0x000000018BCE6E24
		public static implicit operator Substring(string s) => default; // 0x000000018BCE6D9C-0x000000018BCE6DBC
	}

	internal static class TypeHelpers // TypeDefIndex: 45610
	{
		// Methods
		public static TObject As<TObject>(object obj) => default;
		public static bool IsInt(TypeCode type) => default; // 0x000000018BCE77E4-0x000000018BCE7814
		public static System.Type GetValueType(MemberInfo member) => default; // 0x000000018BCE76F8-0x000000018BCE77E4
		public static string GetNiceTypeName(System.Type type) => default; // 0x000000018BCE7394-0x000000018BCE76F8
		public static System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex) => default; // 0x000000018BCE7060-0x000000018BCE7394
	}

	internal struct TypeTable // TypeDefIndex: 45612
	{
		// Fields
		public Dictionary<InternedString, System.Type> table; // 0x00
	
		// Properties
		public IEnumerable<string> names { get => default; } // 0x000000018BCE7814-0x000000018BCE7A18 
		public IEnumerable<InternedString> internedNames { get => default; } // 0x0000000184003540-0x0000000184003610 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 45611
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InternedString, string> __9__2_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BCE7A5C-0x000000018BCE7B8C
			public __c() {} // 0x000000018BCE7A18-0x000000018BCE7A5C
	
			// Methods
			internal string _get_names_b__2_0(InternedString x) => default; // 0x0000000184002E00-0x0000000184002E80
		}
	
		// Methods
		public void Initialize() {} // 0x0000000184113410-0x00000001841134C0
		public InternedString FindNameForType(System.Type type) => default; // 0x000000018BCE821C-0x000000018BCE8280
		public void AddTypeRegistration(string name, System.Type type) {} // 0x0000000185492010-0x0000000185492020
		public System.Type LookupTypeRegistration(string name) => default; // 0x000000018BCE81A4-0x000000018BCE81B8
	}
}

namespace UnityEngine.InputSystem.XInput
{
	public interface IXboxOneRumble : IDualMotorRumble // TypeDefIndex: 45243
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
	}

	public class XInputController : Gamepad // TypeDefIndex: 45248
	{
		// Fields
		private ButtonControl _menu_k__BackingField; // 0x210
		private ButtonControl _view_k__BackingField; // 0x218
		private bool m_HaveParsedCapabilities; // 0x220
		private DeviceSubType m_SubType; // 0x224
		private DeviceFlags m_Flags; // 0x228
	
		// Properties
		public ButtonControl menu { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public ButtonControl view { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
		public DeviceSubType subType { get => default; } // 0x000000018BD1AAAC-0x000000018BD1AADC 
		public DeviceFlags flags { get => default; } // 0x000000018BD1AA7C-0x000000018BD1AAAC 
	
		// Nested types
		internal enum DeviceType // TypeDefIndex: 45244
		{
			Gamepad = 0
		}
	
		public enum DeviceSubType // TypeDefIndex: 45245
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
	
		public enum DeviceFlags // TypeDefIndex: 45246
		{
			ForceFeedbackSupported = 1,
			Wireless = 2,
			VoiceSupported = 4,
			PluginModulesSupported = 8,
			NoNavigation = 16
		}
	
		[Serializable]
		internal struct Capabilities // TypeDefIndex: 45247
		{
			// Fields
			public UnityEngine.InputSystem.XInput.XInputController.DeviceType type; // 0x00
			public DeviceSubType subType; // 0x04
			public DeviceFlags flags; // 0x08
		}
	
		// Constructors
		public XInputController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD1A9A0-0x000000018BD1A9EC
		private void ParseCapabilities() {} // 0x000000018BD1A9EC-0x000000018BD1AA7C
	}

	public class XInputControllerWindows : XInputController // TypeDefIndex: 45249
	{
		// Constructors
		public XInputControllerWindows() {} // 0x00000001864734FC-0x0000000186473504
	}

	internal static class XInputSupport // TypeDefIndex: 45250
	{
		// Methods
		public static void Initialize() {} // 0x0000000184D552A0-0x0000000184D553B0
	}
}

namespace UnityEngine.InputSystem.XInput.LowLevel
{
	internal struct XInputControllerWindowsState : IInputStateTypeInfo // TypeDefIndex: 45252
	{
		// Fields
		public ushort buttons; // 0x00
		public byte leftTrigger; // 0x02
		public byte rightTrigger; // 0x03
		public short leftStickX; // 0x04
		public short leftStickY; // 0x06
		public short rightStickX; // 0x08
		public short rightStickY; // 0x0A
	
		// Properties
		public FourCC format { get => default; } // 0x0000000185FD8120-0x0000000185FD8130 
	
		// Nested types
		public enum Button // TypeDefIndex: 45251
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
		public XInputControllerWindowsState WithButton(Button button) => default; // 0x0000000185FD80F0-0x0000000185FD8120
	}
}

namespace UnityEngine.InputSystem.XR
{
	public struct PoseState : IInputStateTypeInfo // TypeDefIndex: 45214
	{
		// Fields
		internal const int kSizeInBytes = 60; // Metadata: 0x0205BE58
		internal static readonly FourCC s_Format; // 0x00
		public bool isTracked; // 0x00
		public InputTrackingState trackingState; // 0x04
		public Vector3 position; // 0x08
		public Quaternion rotation; // 0x14
		public Vector3 velocity; // 0x24
		public Vector3 angularVelocity; // 0x30
	
		// Properties
		public FourCC format { get => default; } // 0x000000018BD16288-0x000000018BD162D8 
	
		// Constructors
		public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) : this() {
			this.isTracked = default;
			this.trackingState = default;
			this.position = default;
			this.rotation = default;
			this.velocity = default;
			this.angularVelocity = default;
		} // 0x0000000185FD8040-0x0000000185FD8090
		static PoseState() {
			s_Format = default;
		} // 0x000000018BD1624C-0x000000018BD16288
	}

	public class PoseControl : InputControl<PoseState> // TypeDefIndex: 45215
	{
		// Fields
		private ButtonControl _isTracked_k__BackingField; // 0x178
		private IntegerControl _trackingState_k__BackingField; // 0x180
		private Vector3Control _position_k__BackingField; // 0x188
		private QuaternionControl _rotation_k__BackingField; // 0x190
		private Vector3Control _velocity_k__BackingField; // 0x198
		private Vector3Control _angularVelocity_k__BackingField; // 0x1A0
	
		// Properties
		public ButtonControl isTracked { get; set; } // 0x0000000185FB88B0-0x0000000185FB88C0 0x0000000186473518-0x000000018647352C
		public IntegerControl trackingState { get; set; } // 0x0000000185FB8280-0x0000000185FB8290 0x000000018647352C-0x0000000186473540
		public Vector3Control position { get; set; } // 0x0000000185FB8360-0x0000000185FB8370 0x0000000186473540-0x0000000186473554
		public QuaternionControl rotation { get; set; } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
		public Vector3Control velocity { get; set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public Vector3Control angularVelocity { get; set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
	
		// Constructors
		public PoseControl() {} // 0x000000018BD161C8-0x000000018BD1624C
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD15C4C-0x000000018BD15DF8
		public override unsafe PoseState ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BD15DF8-0x000000018BD15FF0
		public override unsafe void WriteValueIntoState(PoseState value, void* statePtr) {} // 0x000000018BD15FF0-0x000000018BD161C8
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x000000018BD15A20-0x000000018BD15C4C
	}

	public class XRHMD : TrackedDevice // TypeDefIndex: 45216
	{
		// Fields
		private Vector3Control _leftEyePosition_k__BackingField; // 0x1B0
		private QuaternionControl _leftEyeRotation_k__BackingField; // 0x1B8
		private Vector3Control _rightEyePosition_k__BackingField; // 0x1C0
		private QuaternionControl _rightEyeRotation_k__BackingField; // 0x1C8
		private Vector3Control _centerEyePosition_k__BackingField; // 0x1D0
		private QuaternionControl _centerEyeRotation_k__BackingField; // 0x1D8
	
		// Properties
		public Vector3Control leftEyePosition { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public QuaternionControl leftEyeRotation { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public Vector3Control rightEyePosition { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public QuaternionControl rightEyeRotation { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public Vector3Control centerEyePosition { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public QuaternionControl centerEyeRotation { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
	
		// Constructors
		public XRHMD() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD1AD9C-0x000000018BD1AF1C
	}

	public class XRController : TrackedDevice // TypeDefIndex: 45217
	{
		// Properties
		public static XRController leftHand { get => default; } // 0x000000018BD1AC58-0x000000018BD1ACDC 
		public static XRController rightHand { get => default; } // 0x000000018BD1ACDC-0x000000018BD1AD60 
	
		// Constructors
		public XRController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD1AB70-0x000000018BD1AC58
	}

	public class XRControllerWithRumble : XRController // TypeDefIndex: 45218
	{
		// Constructors
		public XRControllerWithRumble() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		public void SendImpulse(float amplitude, float duration) {} // 0x000000018BD1AADC-0x000000018BD1AB70
	}

	[Serializable]
	public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 45222
	{
		// Fields
		private TrackingType m_TrackingType; // 0x18
		private UpdateType m_UpdateType; // 0x1C
		private bool m_IgnoreTrackingState; // 0x20
		private InputActionProperty m_PositionInput; // 0x28
		private InputActionProperty m_RotationInput; // 0x40
		private InputActionProperty m_TrackingStateInput; // 0x58
		private Vector3 m_CurrentPosition; // 0x70
		private Quaternion m_CurrentRotation; // 0x7C
		private TrackingStates m_CurrentTrackingState; // 0x8C
		private bool m_RotationBound; // 0x90
		private bool m_PositionBound; // 0x91
		private bool m_TrackingStateBound; // 0x92
		private bool m_IsFirstUpdate; // 0x93
		private InputAction m_PositionAction; // 0x98
		private InputAction m_RotationAction; // 0xA0
	
		// Properties
		public TrackingType trackingType { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public UpdateType updateType { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public bool ignoreTrackingState { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public InputActionProperty positionInput { get => default; set {} } // 0x0000000185FC8CD0-0x0000000185FC8CF0 0x000000018BD17A9C-0x000000018BD17B0C
		public InputActionProperty rotationInput { get => default; set {} } // 0x0000000185FB2520-0x0000000185FB2540 0x000000018BD17B60-0x000000018BD17BD0
		public InputActionProperty trackingStateInput { get => default; set {} } // 0x0000000185FCE860-0x0000000185FCE880 0x000000018BD17BD0-0x000000018BD17C40
		public InputAction positionAction { get => default; set {} } // 0x000000018BD17A30-0x000000018BD17A3C 0x000000018BD17A48-0x000000018BD17A9C
		public InputAction rotationAction { get => default; set {} } // 0x000000018BD17A3C-0x000000018BD17A48 0x000000018BD17B0C-0x000000018BD17B60
	
		// Nested types
		public enum TrackingType // TypeDefIndex: 45219
		{
			RotationAndPosition = 0,
			RotationOnly = 1,
			PositionOnly = 2
		}
	
		private enum TrackingStates // TypeDefIndex: 45220
		{
			None = 0,
			Position = 1,
			Rotation = 2
		}
	
		public enum UpdateType // TypeDefIndex: 45221
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}
	
		// Constructors
		public TrackedPoseDriver() {} // 0x000000018BD179D8-0x000000018BD17A30
	
		// Methods
		private void BindActions() {} // 0x000000018BD166B8-0x000000018BD166E4
		private void UnbindActions() {} // 0x000000018BD173BC-0x000000018BD173E8
		private void BindPosition() {} // 0x000000018BD166E4-0x000000018BD16860
		private void BindRotation() {} // 0x000000018BD16860-0x000000018BD169DC
		private void BindTrackingState() {} // 0x000000018BD169DC-0x000000018BD16B58
		private static void RenameAndEnable(InputAction action, string name) {} // 0x000000018BD17030-0x000000018BD1705C
		private void UnbindPosition() {} // 0x000000018BD173E8-0x000000018BD17520
		private void UnbindRotation() {} // 0x000000018BD17520-0x000000018BD17658
		private void UnbindTrackingState() {} // 0x000000018BD17658-0x000000018BD17790
		private void OnPositionPerformed(InputAction.CallbackContext context) {} // 0x000000018BD16DF4-0x000000018BD16E54
		private void OnPositionCanceled(InputAction.CallbackContext context) {} // 0x000000018BD16DE0-0x000000018BD16DF4
		private void OnRotationPerformed(InputAction.CallbackContext context) {} // 0x000000018BD16E74-0x000000018BD16EC8
		private void OnRotationCanceled(InputAction.CallbackContext context) {} // 0x000000018BD16E54-0x000000018BD16E74
		private void OnTrackingStatePerformed(InputAction.CallbackContext context) {} // 0x000000018BD16EC8-0x000000018BD16F14
		private void OnTrackingStateCanceled(InputAction.CallbackContext context) {} // 0x0000000185FD80E0-0x0000000185FD80F0
		protected void Reset() {} // 0x000000018BD1705C-0x000000018BD17278
		protected virtual void Awake() {} // 0x000000018BD16684-0x000000018BD166B8
		protected void OnEnable() {} // 0x000000018BD16D3C-0x000000018BD16DE0
		protected void OnDisable() {} // 0x000000018BD16CA0-0x000000018BD16D3C
		protected virtual void OnDestroy() {} // 0x000000018BD16C6C-0x000000018BD16CA0
		protected void UpdateCallback() {} // 0x000000018BD17850-0x000000018BD179D8
		private void ReadTrackingState(bool hasResolvedPositionInputControl, bool hasResolvedRotationInputControl) {} // 0x000000018BD16F60-0x000000018BD17030
		protected virtual void OnUpdate() {} // 0x000000018BD16F14-0x000000018BD16F28
		protected virtual void OnBeforeRender() {} // 0x000000018BD16C58-0x000000018BD16C6C
		protected virtual void PerformUpdate() {} // 0x000000018BD16F28-0x000000018BD16F60
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) {} // 0x000000018BD17278-0x000000018BD173BC
		private bool HasStereoCamera(out Camera cameraComponent) {
			cameraComponent = default;
			return default;
		} // 0x000000018BD16BF4-0x000000018BD16C58
		private static bool HasResolvedControl(InputAction action) => default; // 0x000000018BD16B58-0x000000018BD16BF4
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BD17790-0x000000018BD17850
	}

	internal class XRLayoutBuilder // TypeDefIndex: 45224
	{
		// Fields
		private string parentLayout; // 0x10
		private string interfaceName; // 0x18
		private XRDeviceDescriptor descriptor; // 0x20
		private static readonly string[] poseSubControlNames; // 0x00
		private static readonly FeatureType[] poseSubControlTypes; // 0x08
	
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 45223
		{
			// Fields
			public XRLayoutBuilder layout; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BD1BE0C-0x000000018BD1BEA0
	
			// Methods
			internal InputControlLayout _OnFindLayoutForDevice_b__0() => default; // 0x000000018BD1BFFC-0x000000018BD1C130
		}
	
		// Constructors
		public XRLayoutBuilder() {} // 0x0000000185492010-0x0000000185492020
		static XRLayoutBuilder() {} // 0x000000018BD18EB8-0x000000018BD18ED8
	
		// Methods
		private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor) => default; // 0x0000000184950BA0-0x0000000184950CE0
		private static string SanitizeString(string original, bool allowPaths = false /* Metadata: 0x0205BE62 */) => default; // 0x000000018BD1BC5C-0x000000018BD1BDD0
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate) => default; // 0x000000018BD1BFD4-0x000000018BD1BFFC
		private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias) => default; // 0x000000018BD1BDD0-0x000000018BD1BE0C
		private bool IsSubControl(string name) => default; // 0x000000018BD1BEA0-0x000000018BD1BFD4
		private string GetParentControlName(string name) => default; // 0x000000018BD1AF1C-0x000000018BD1BC5C
		private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex) => default; // 0x0000000185492010-0x0000000185492020
		private InputControlLayout Build() => default; // 0x000000018BD1C130-0x000000018BD1C7B8
	}

	public static class XRUtilities // TypeDefIndex: 45225
	{
		// Fields
		public const string InterfaceMatchAnyVersion = "^(XRInput)"; // Metadata: 0x0205BE63
		public const string InterfaceV1 = "XRInput"; // Metadata: 0x0205BE6E
		public const string InterfaceCurrent = "XRInputV1"; // Metadata: 0x0205BE76
	}

	public enum FeatureType // TypeDefIndex: 45226
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
	public struct UsageHint // TypeDefIndex: 45227
	{
		// Fields
		public string content; // 0x00
	}

	[Serializable]
	public struct XRFeatureDescriptor // TypeDefIndex: 45228
	{
		// Fields
		public string name; // 0x00
		public List<UsageHint> usageHints; // 0x08
		public FeatureType featureType; // 0x10
		public uint customSize; // 0x14
	}

	[Serializable]
	public class XRDeviceDescriptor // TypeDefIndex: 45229
	{
		// Fields
		public string deviceName; // 0x10
		public string manufacturer; // 0x18
		public string serialNumber; // 0x20
		public InputDeviceCharacteristics characteristics; // 0x28
		public int deviceId; // 0x2C
		public List<XRFeatureDescriptor> inputFeatures; // 0x30
	
		// Constructors
		public XRDeviceDescriptor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public string ToJson() => default; // 0x000000018646F41C-0x000000018646F428
		public static XRDeviceDescriptor FromJson(string json) => default; // 0x000000018BD1AD60-0x000000018BD1AD9C
	}

	public struct Bone // TypeDefIndex: 45230
	{
		// Fields
		public uint m_ParentBoneIndex; // 0x00
		public Vector3 m_Position; // 0x04
		public Quaternion m_Rotation; // 0x10
	
		// Properties
		public uint parentBoneIndex { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public Vector3 position { get => default; set {} } // 0x0000000185FBF900-0x0000000185FBF920 0x0000000185FD7F00-0x0000000185FD7F10
		public Quaternion rotation { get => default; set {} } // 0x00000001834A7540-0x00000001834A7550 0x0000000185FB6860-0x0000000185FB6870
	}

	public struct Eyes // TypeDefIndex: 45231
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
		public Vector3 leftEyePosition { get => default; set {} } // 0x0000000185FB7B80-0x0000000185FB7BA0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Quaternion leftEyeRotation { get => default; set {} } // 0x0000000185FBF8F0-0x0000000185FBF900 0x0000000185FD7F20-0x0000000185FD7F30
		public Vector3 rightEyePosition { get => default; set {} } // 0x0000000185FBE120-0x0000000185FBE140 0x0000000185FBE140-0x0000000185FBE150
		public Quaternion rightEyeRotation { get => default; set {} } // 0x0000000185FBB610-0x0000000185FBB620 0x0000000185FBB620-0x0000000185FBB630
		public Vector3 fixationPoint { get => default; set {} } // 0x0000000185FCA320-0x0000000185FCA340 0x0000000185FC9A60-0x0000000185FC9A70
		public float leftEyeOpenAmount { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public float rightEyeOpenAmount { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	}

	public class BoneControl : InputControl<UnityEngine.InputSystem.XR.Bone> // TypeDefIndex: 45232
	{
		// Fields
		private IntegerControl _parentBoneIndex_k__BackingField; // 0x140
		private Vector3Control _position_k__BackingField; // 0x148
		private QuaternionControl _rotation_k__BackingField; // 0x150
	
		// Properties
		public IntegerControl parentBoneIndex { get; set; } // 0x0000000185FB85F0-0x0000000185FB8600 0x0000000187A47758-0x0000000187A4776C
		public Vector3Control position { get; set; } // 0x0000000185FB8610-0x0000000185FB8620 0x0000000187A47780-0x0000000187A47794
		public QuaternionControl rotation { get; set; } // 0x0000000185FB84D0-0x0000000185FB84E0 0x0000000187A475C8-0x0000000187A475DC
	
		// Constructors
		public BoneControl() {} // 0x000000018BD04E5C-0x000000018BD04E90
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD04BF4-0x000000018BD04CF0
		public override unsafe UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BD04CF0-0x000000018BD04DC8
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr) {} // 0x000000018BD04DC8-0x000000018BD04E5C
	}

	public class EyesControl : InputControl<UnityEngine.InputSystem.XR.Eyes> // TypeDefIndex: 45233
	{
		// Fields
		private Vector3Control _leftEyePosition_k__BackingField; // 0x198
		private QuaternionControl _leftEyeRotation_k__BackingField; // 0x1A0
		private Vector3Control _rightEyePosition_k__BackingField; // 0x1A8
		private QuaternionControl _rightEyeRotation_k__BackingField; // 0x1B0
		private Vector3Control _fixationPoint_k__BackingField; // 0x1B8
		private AxisControl _leftEyeOpenAmount_k__BackingField; // 0x1C0
		private AxisControl _rightEyeOpenAmount_k__BackingField; // 0x1C8
	
		// Properties
		public Vector3Control leftEyePosition { get; set; } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public QuaternionControl leftEyeRotation { get; set; } // 0x0000000185FB82F0-0x0000000185FB8300 0x00000001864734C0-0x00000001864734D4
		public Vector3Control rightEyePosition { get; set; } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public QuaternionControl rightEyeRotation { get; set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public Vector3Control fixationPoint { get; set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public AxisControl leftEyeOpenAmount { get; set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public AxisControl rightEyeOpenAmount { get; set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
	
		// Constructors
		public EyesControl() {} // 0x000000018BD0602C-0x000000018BD06060
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BD05BA4-0x000000018BD05D78
		public override unsafe UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018BD05D78-0x000000018BD05EF4
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr) {} // 0x000000018BD05EF4-0x000000018BD0602C
	}

	internal static class XRSupport // TypeDefIndex: 45234
	{
		// Methods
		public static void Initialize() {} // 0x0000000184D561B0-0x0000000184D56D40
	}
}

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct BufferedRumble // TypeDefIndex: 45235
	{
		// Fields
		private HapticCapabilities _capabilities_k__BackingField; // 0x00
		private UnityEngine.InputSystem.InputDevice _device_k__BackingField; // 0x18
	
		// Properties
		public HapticCapabilities capabilities { get; private set; } // 0x0000000181DD1540-0x0000000181DD1550 0x0000000185FB2C80-0x0000000185FB2C90
		private UnityEngine.InputSystem.InputDevice device { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public BufferedRumble(UnityEngine.InputSystem.InputDevice device) : this() {
			<capabilities>k__BackingField = default;
			<device>k__BackingField = default;
		} // 0x000000018BD04F74-0x000000018BD0507C
	
		// Methods
		public void EnqueueRumble(byte[] samples) {} // 0x000000018BD04E90-0x000000018BD04F74
	}

	public struct HapticState // TypeDefIndex: 45236
	{
		// Fields
		private uint _samplesQueued_k__BackingField; // 0x00
		private uint _samplesAvailable_k__BackingField; // 0x04
	
		// Properties
		public uint samplesQueued { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public uint samplesAvailable { get; private set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
	
		// Constructors
		public HapticState(uint samplesQueued, uint samplesAvailable) : this() {
			<samplesQueued>k__BackingField = default;
			<samplesAvailable>k__BackingField = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	}

	public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 45237
	{
		// Fields
		private const int kSize = 16; // Metadata: 0x0205BE8A
		private InputDeviceCommand baseCommand; // 0x00
		public uint samplesQueued; // 0x08
		public uint samplesAvailable; // 0x0C
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000185FD7F60-0x0000000185FD7F70 
		public FourCC typeStatic { get => default; } // 0x0000000185FD7F60-0x0000000185FD7F70 
		public HapticState currentState { get => default; } // 0x0000000185FD7F70-0x0000000185FD7F90 
	
		// Methods
		public static GetCurrentHapticStateCommand Create() => default; // 0x0000000185FD7F30-0x0000000185FD7F60
	}

	public struct HapticCapabilities // TypeDefIndex: 45238
	{
		// Fields
		private readonly uint _numChannels_k__BackingField; // 0x00
		private readonly bool _supportsImpulse_k__BackingField; // 0x04
		private readonly bool _supportsBuffer_k__BackingField; // 0x05
		private readonly uint _frequencyHz_k__BackingField; // 0x08
		private readonly uint _maxBufferSize_k__BackingField; // 0x0C
		private readonly uint _optimalBufferSize_k__BackingField; // 0x10
	
		// Properties
		public uint numChannels { get; } // 0x00000001818226B0-0x00000001818226C0 
		public bool supportsImpulse { get; } // 0x0000000185FB6C60-0x0000000185FB6C70 
		public bool supportsBuffer { get; } // 0x0000000185FB6C70-0x0000000185FB6C80 
		public uint frequencyHz { get; } // 0x0000000181B7E450-0x0000000181B7E460 
		public uint maxBufferSize { get; } // 0x00000001834AFB70-0x00000001834AFB80 
		public uint optimalBufferSize { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize) : this() {
			<numChannels>k__BackingField = default;
			<supportsImpulse>k__BackingField = default;
			<supportsBuffer>k__BackingField = default;
			<frequencyHz>k__BackingField = default;
			<maxBufferSize>k__BackingField = default;
			<optimalBufferSize>k__BackingField = default;
		} // 0x0000000185FD8020-0x0000000185FD8040
		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize) : this() {
			<numChannels>k__BackingField = default;
			<supportsImpulse>k__BackingField = default;
			<supportsBuffer>k__BackingField = default;
			<frequencyHz>k__BackingField = default;
			<maxBufferSize>k__BackingField = default;
			<optimalBufferSize>k__BackingField = default;
		} // 0x0000000185FD8000-0x0000000185FD8020
	}

	public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo // TypeDefIndex: 45239
	{
		// Fields
		private const int kSize = 28; // Metadata: 0x0205BE8B
		private InputDeviceCommand baseCommand; // 0x00
		public uint numChannels; // 0x08
		public bool supportsImpulse; // 0x0C
		public bool supportsBuffer; // 0x0D
		public uint frequencyHz; // 0x10
		public uint maxBufferSize; // 0x14
		public uint optimalBufferSize; // 0x18
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000185FD7FC0-0x0000000185FD7FD0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD7FC0-0x0000000185FD7FD0 
		public HapticCapabilities capabilities { get => default; } // 0x0000000185FD7FD0-0x0000000185FD8000 
	
		// Methods
		public static GetHapticCapabilitiesCommand Create() => default; // 0x0000000185FD7F90-0x0000000185FD7FC0
	}

	public struct SendBufferedHapticCommand : IInputDeviceCommandInfo // TypeDefIndex: 45241
	{
		// Fields
		private const int kMaxHapticBufferSize = 1024; // Metadata: 0x0205BE8C
		private const int kSize = 1040; // Metadata: 0x0205BE8E
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private int bufferSize; // 0x0C
		private _buffer_e__FixedBuffer buffer; // 0x10
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000185FD8090-0x0000000185FD80A0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD8090-0x0000000185FD80A0 
	
		// Nested types
		public struct _buffer_e__FixedBuffer // TypeDefIndex: 45240
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public static SendBufferedHapticCommand Create(byte[] rumbleBuffer) => default; // 0x000000018BD162D8-0x000000018BD16458
	}

	public struct SendHapticImpulseCommand : IInputDeviceCommandInfo // TypeDefIndex: 45242
	{
		// Fields
		private const int kSize = 20; // Metadata: 0x0205BE90
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private float amplitude; // 0x0C
		private float duration; // 0x10
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000185FD80D0-0x0000000185FD80E0 
		public FourCC typeStatic { get => default; } // 0x0000000185FD80D0-0x0000000185FD80E0 
	
		// Methods
		public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration) => default; // 0x0000000185FD80A0-0x0000000185FD80D0
	}
}

namespace UnityEngine.XR.WindowsMR.Input
{
	public class WMRHMD : XRHMD // TypeDefIndex: 45009
	{
		// Fields
		private ButtonControl _userPresence_k__BackingField; // 0x1E0
	
		// Properties
		public ButtonControl userPresence { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
	
		// Constructors
		public WMRHMD() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC8B50-0x000000018BCC8BBC
	}

	public class HololensHand : XRController // TypeDefIndex: 45010
	{
		// Fields
		private Vector3Control _deviceVelocity_k__BackingField; // 0x1B0
		private ButtonControl _airTap_k__BackingField; // 0x1B8
		private AxisControl _sourceLossRisk_k__BackingField; // 0x1C0
		private Vector3Control _sourceLossMitigationDirection_k__BackingField; // 0x1C8
	
		// Properties
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public ButtonControl airTap { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public AxisControl sourceLossRisk { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public Vector3Control sourceLossMitigationDirection { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
	
		// Constructors
		public HololensHand() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCB7F38-0x000000018BCB8058
	}

	public class WMRSpatialController : XRControllerWithRumble // TypeDefIndex: 45011
	{
		// Fields
		private Vector2Control _joystick_k__BackingField; // 0x1B0
		private Vector2Control _touchpad_k__BackingField; // 0x1B8
		private AxisControl _grip_k__BackingField; // 0x1C0
		private ButtonControl _gripPressed_k__BackingField; // 0x1C8
		private ButtonControl _menu_k__BackingField; // 0x1D0
		private AxisControl _trigger_k__BackingField; // 0x1D8
		private ButtonControl _triggerPressed_k__BackingField; // 0x1E0
		private ButtonControl _joystickClicked_k__BackingField; // 0x1E8
		private ButtonControl _touchpadClicked_k__BackingField; // 0x1F0
		private ButtonControl _touchpadTouched_k__BackingField; // 0x1F8
		private Vector3Control _deviceVelocity_k__BackingField; // 0x200
		private Vector3Control _deviceAngularVelocity_k__BackingField; // 0x208
		private AxisControl _batteryLevel_k__BackingField; // 0x210
		private AxisControl _sourceLossRisk_k__BackingField; // 0x218
		private Vector3Control _sourceLossMitigationDirection_k__BackingField; // 0x220
		private Vector3Control _pointerPosition_k__BackingField; // 0x228
		private QuaternionControl _pointerRotation_k__BackingField; // 0x230
	
		// Properties
		public Vector2Control joystick { get; protected set; } // 0x0000000185FB8350-0x0000000185FB8360 0x00000001864734E8-0x00000001864734FC
		public Vector2Control touchpad { get; protected set; } // 0x0000000181BE0A10-0x0000000181BE0A20 0x0000000186473484-0x0000000186473498
		public AxisControl grip { get; protected set; } // 0x0000000185FB7F50-0x0000000185FB7F60 0x0000000186473554-0x0000000186473568
		public ButtonControl gripPressed { get; protected set; } // 0x0000000185FB8420-0x0000000185FB8430 0x0000000186473568-0x000000018647357C
		public ButtonControl menu { get; protected set; } // 0x0000000185FB8030-0x0000000185FB8040 0x000000018647357C-0x0000000186473590
		public AxisControl trigger { get; protected set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000187A47514-0x0000000187A47528
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
		public ButtonControl joystickClicked { get; protected set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000185FB85D0-0x0000000185FB85E0 0x0000000187A4771C-0x0000000187A47730
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000185FB84F0-0x0000000185FB8500 0x0000000187A475F0-0x0000000187A47604
		public AxisControl batteryLevel { get; protected set; } // 0x0000000185FB83A0-0x0000000185FB83B0 0x0000000187A475DC-0x0000000187A475F0
		public AxisControl sourceLossRisk { get; protected set; } // 0x0000000185FB8830-0x0000000185FB8840 0x0000000187A47B2C-0x0000000187A47B40
		public Vector3Control sourceLossMitigationDirection { get; protected set; } // 0x0000000185FB8890-0x0000000185FB88A0 0x0000000187A47BB8-0x0000000187A47BCC
		public Vector3Control pointerPosition { get; protected set; } // 0x0000000185FB8620-0x0000000185FB8630 0x0000000187A47794-0x0000000187A477A8
		public QuaternionControl pointerRotation { get; protected set; } // 0x0000000185FB8310-0x0000000185FB8320 0x0000000187A37678-0x0000000187A3768C
	
		// Constructors
		public WMRSpatialController() {} // 0x00000001864734FC-0x0000000186473504
	
		// Methods
		protected override void FinishSetup() {} // 0x000000018BCC8BBC-0x000000018BCC8FAC
	}
}
