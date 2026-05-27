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

// Image 11: Unity.InputSystem.dll - Assembly: Unity.InputSystem, Version=1.14.0.0, Culture=neutral, PublicKeyToken=null - Types 44031-44677
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.InputSystem.Tests")]
[assembly: InternalsVisibleTo("Unity.InputSystem.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.InputSystem.TestFramework")]
[assembly: InternalsVisibleTo("Unity.InputSystem.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.InputSystem.ForUI")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class UISupport // TypeDefIndex: 44032
{
	// Methods
	public static void Initialize() {} // 0x0000000182F18170-0x0000000182F181E0
}

namespace Unity.XR.GoogleVr
{
	[InputControlLayout(displayName = "Daydream Headset", hideInUI = true)]
	public class DaydreamHMD : XRHMD // TypeDefIndex: 44046
	{
		// Constructors
		public DaydreamHMD() {} // 0x0000000184275C10-0x0000000184275C18
	}

	[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class DaydreamController : XRController // TypeDefIndex: 44047
	{
		// Properties
		[InputControl]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl]
		public ButtonControl volumeUp { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl]
		public ButtonControl recentered { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl]
		public ButtonControl volumeDown { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl]
		public ButtonControl recentering { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl]
		public ButtonControl app { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl]
		public ButtonControl home { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl]
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl]
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
	
		// Constructors
		public DaydreamController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189B9DEA0-0x0000000189B9E138
	}
}

namespace Unity.XR.Oculus.Input
{
	[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
	public class OculusHMD : XRHMD // TypeDefIndex: 44040
	{
		// Properties
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[1] {"deviceistracked" })]
		[InputControl]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[1] {"devicetrackingstate" })]
		public ButtonControl userPresence { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAcceleration { get; protected set; } // 0x0000000183D57190-0x0000000183D571A0 0x00000001858ADFBC-0x00000001858ADFD0
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularAcceleration { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAcceleration { get; protected set; } // 0x0000000183D57430-0x0000000183D57440 0x00000001858B41A4-0x00000001858B41B8
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularAcceleration { get; protected set; } // 0x0000000183D57480-0x0000000183D57490 0x00000001858B421C-0x00000001858B4230
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { get; protected set; } // 0x0000000183D57210-0x0000000183D57220 0x00000001858B3DE4-0x00000001858B3DF8
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAcceleration { get; protected set; } // 0x0000000183D57220-0x0000000183D57230 0x00000001858B3DF8-0x00000001858B3E0C
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularAcceleration { get; protected set; } // 0x0000000183D56B10-0x0000000183D56B20 0x000000018586F120-0x000000018586F134
	
		// Constructors
		public OculusHMD() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA834C-0x0000000189BA8644
	}

	[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OculusTouchController : XRControllerWithRumble // TypeDefIndex: 44041
	{
		// Properties
		[InputControl(aliases = new string[2] {"Primary2DAxis", "Joystick" })]
		public Vector2Control thumbstick { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl]
		public AxisControl trigger { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl]
		public AxisControl grip { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(aliases = new string[3] {"A", "X", "Alternate" })]
		public ButtonControl primaryButton { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl(aliases = new string[3] {"B", "Y", "Primary" })]
		public ButtonControl secondaryButton { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl(aliases = new string[1] {"GripButton" })]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl]
		public ButtonControl start { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(aliases = new string[2] {"JoystickOrPadPressed", "thumbstickClick" })]
		public ButtonControl thumbstickClicked { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(aliases = new string[4] {"ATouched", "XTouched", "ATouch", "XTouch" })]
		public ButtonControl primaryTouched { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(aliases = new string[4] {"BTouched", "YTouched", "BTouch", "YTouch" })]
		public ButtonControl secondaryTouched { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(aliases = new string[2] {"indexTouch", "indexNearTouched" })]
		public AxisControl triggerTouched { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		[InputControl(aliases = new string[2] {"indexButton", "indexTouched" })]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D57190-0x0000000183D571A0 0x00000001858ADFBC-0x00000001858ADFD0
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"controllerRotation" })]
		[InputControl(aliases = new string[2] {"JoystickOrPadTouched", "thumbstickTouch" })]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[1] {"controllerTrackingState" })]
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[1] {"ControllerIsTracked" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"controllerPosition" })]
		public ButtonControl thumbstickTouched { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(noisy = true, aliases = new string[1] {"controllerVelocity" })]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D57430-0x0000000183D57440 0x00000001858B41A4-0x00000001858B41B8
		[InputControl(noisy = true, aliases = new string[1] {"controllerAcceleration" })]
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000183D57480-0x0000000183D57490 0x00000001858B421C-0x00000001858B4230
		[InputControl(noisy = true, aliases = new string[1] {"controllerAngularAcceleration" })]
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000183D57210-0x0000000183D57220 0x00000001858B3DE4-0x00000001858B3DF8
	
		// Constructors
		public OculusTouchController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA871C-0x0000000189BA8B00
	}

	public class OculusTrackingReference : TrackedDevice // TypeDefIndex: 44042
	{
		// Properties
		[InputControl(aliases = new string[1] {"trackingReferenceTrackingState" })]
		public new IntegerControl trackingState { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(aliases = new string[1] {"trackingReferenceIsTracked" })]
		public new ButtonControl isTracked { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
	
		// Constructors
		public OculusTrackingReference() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA8B00-0x0000000189BA8BAC
	}

	[InputControlLayout(displayName = "Oculus Remote", hideInUI = true)]
	public class OculusRemote : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 44043
	{
		// Properties
		[InputControl]
		public ButtonControl back { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		[InputControl]
		public ButtonControl start { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		[InputControl]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
	
		// Constructors
		public OculusRemote() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA8644-0x0000000189BA871C
	}

	[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = true)]
	public class OculusHMDExtended : OculusHMD // TypeDefIndex: 44044
	{
		// Properties
		[InputControl]
		public ButtonControl back { get; protected set; } // 0x0000000183D56D60-0x0000000183D56D70 0x00000001858AAF50-0x00000001858AAF64
		[InputControl]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D57350-0x0000000183D57360 0x00000001858B403C-0x00000001858B4050
	
		// Constructors
		public OculusHMDExtended() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA82A0-0x0000000189BA834C
	}

	[InputControlLayout(displayName = "GearVR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class GearVRTrackedController : XRController // TypeDefIndex: 44045
	{
		// Properties
		[InputControl]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl]
		public AxisControl trigger { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl]
		public ButtonControl back { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl]
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl]
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
	
		// Constructors
		public GearVRTrackedController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189B9E33C-0x0000000189B9E578
	}
}

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "OpenVR Headset", hideInUI = true)]
	public class OpenVRHMD : XRHMD // TypeDefIndex: 44033
	{
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(noisy = true)]
		public Vector3Control leftEyeVelocity { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(noisy = true)]
		public Vector3Control rightEyeVelocity { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity { get; protected set; } // 0x0000000183D57190-0x0000000183D571A0 0x00000001858ADFBC-0x00000001858ADFD0
		[InputControl(noisy = true)]
		public Vector3Control centerEyeVelocity { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
	
		// Constructors
		public OpenVRHMD() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA8E50-0x0000000189BA902C
	}

	[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVRControllerWMR : XRController // TypeDefIndex: 44034
	{
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl touchpadClick { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl touchpadTouch { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl(aliases = new string[1] {"primary" })]
		public ButtonControl menu { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl]
		public AxisControl trigger { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl]
		public AxisControl grip { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(aliases = new string[1] {"secondary2DAxis" })]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(aliases = new string[1] {"primary2DAxis" })]
		public Vector2Control joystick { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
	
		// Constructors
		public OpenVRControllerWMR() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA8BAC-0x0000000189BA8E50
	}

	[InputControlLayout(displayName = "Vive Wand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class ViveWand : XRControllerWithRumble // TypeDefIndex: 44035
	{
		// Properties
		[InputControl]
		public AxisControl grip { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl]
		public ButtonControl primary { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(aliases = new string[2] {"primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl trackpadPressed { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl(aliases = new string[2] {"primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl trackpadTouched { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl(aliases = new string[1] {"Primary2DAxis" })]
		public Vector2Control trackpad { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl]
		public AxisControl trigger { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
	
		// Constructors
		public ViveWand() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BAF06C-0x0000000189BAF2DC
	}

	[InputControlLayout(displayName = "Vive Lighthouse", hideInUI = true)]
	public class ViveLighthouse : TrackedDevice // TypeDefIndex: 44036
	{
		// Constructors
		public ViveLighthouse() {} // 0x0000000184275C10-0x0000000184275C18
	}

	[InputControlLayout(displayName = "Vive Tracker")]
	public class ViveTracker : TrackedDevice // TypeDefIndex: 44037
	{
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
	
		// Constructors
		public ViveTracker() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BAEFCC-0x0000000189BAF06C
	}

	[InputControlLayout(displayName = "Handed Vive Tracker", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HandedViveTracker : ViveTracker // TypeDefIndex: 44038
	{
		// Properties
		[InputControl]
		public AxisControl grip { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl]
		public ButtonControl primary { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl(aliases = new string[1] {"JoystickOrPadPressed" })]
		public ButtonControl trackpadPressed { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
	
		// Constructors
		public HandedViveTracker() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189B9E578-0x0000000189B9E6C4
	}

	[InputControlLayout(displayName = "Oculus Touch Controller (OpenVR)", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVROculusTouchController : XRControllerWithRumble // TypeDefIndex: 44039
	{
		// Properties
		[InputControl]
		public Vector2Control thumbstick { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl]
		public AxisControl trigger { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl]
		public AxisControl grip { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(aliases = new string[1] {"Alternate" })]
		public ButtonControl primaryButton { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl(aliases = new string[1] {"Primary" })]
		public ButtonControl secondaryButton { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(aliases = new string[1] {"primary2DAxisClicked" })]
		public ButtonControl thumbstickClicked { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(aliases = new string[1] {"primary2DAxisTouch" })]
		public ButtonControl thumbstickTouched { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
	
		// Constructors
		public OpenVROculusTouchController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BA902C-0x0000000189BA92D0
	}
}

namespace UnityEngine.InputSystem
{
	public interface IInputActionCollection : IEnumerable<InputAction> // TypeDefIndex: 44051
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

	public interface IInputActionCollection2 : IInputActionCollection // TypeDefIndex: 44052
	{
		// Properties
		IEnumerable<InputBinding> bindings { get; }
	
		// Methods
		InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x01FB633C */);
		int FindBinding(InputBinding mask, out InputAction action);
	}

	public interface IInputInteraction // TypeDefIndex: 44053
	{
		// Methods
		void Process(ref InputInteractionContext context);
		void Reset();
	}

	public interface IInputInteraction<TValue> : IInputInteraction // TypeDefIndex: 44054
		where TValue : struct
	{
	}

	internal static class InputInteraction // TypeDefIndex: 44055
	{
		// Fields
		public static TypeTable s_Interactions; // 0x00
	
		// Methods
		public static System.Type GetValueType(System.Type interactionType) => default; // 0x0000000189BA81CC-0x0000000189BA82A0
		public static string GetDisplayName(string interaction) => default; // 0x0000000189BA80F0-0x0000000189BA81CC
		public static string GetDisplayName(System.Type interactionType) => default; // 0x0000000189BA7FA0-0x0000000189BA80F0
	}

	[Serializable]
	public sealed class InputAction : ICloneable, IDisposable // TypeDefIndex: 44058
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
		public string name { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public UnityEngine.InputSystem.InputActionType type { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Guid id { get => default; } // 0x0000000189BA7B70-0x0000000189BA7BB0 
		internal Guid idDontGenerate { get => default; } // 0x0000000182EBA620-0x0000000182EBA670 
		public string expectedControlType { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string processors { get => default; } // 0x0000000181003830-0x0000000181003840 
		public string interactions { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public InputActionMap actionMap { get => default; } // 0x0000000189BA7A18-0x0000000189BA7A40 
		public InputBinding? bindingMask { get => default; set {} } // 0x0000000183D76AD0-0x0000000183D76B10 0x0000000189BA7CD0-0x0000000189BA7F84
		public ReadOnlyArray<InputBinding> bindings { get => default; } // 0x0000000189BA7B20-0x0000000189BA7B70 
		public ReadOnlyArray<InputControl> controls { get => default; } // 0x0000000182EB7860-0x0000000182EB78D0 
		public InputActionPhase phase { get => default; } // 0x0000000182EB9950-0x0000000182EB9980 
		public bool inProgress { get => default; } // 0x0000000189BA7BB0-0x0000000189BA7BC8 
		public bool enabled { get => default; } // 0x0000000182EB9930-0x0000000182EB9950 
		public bool triggered { get => default; } // 0x0000000189BA7BE4-0x0000000189BA7BEC 
		public InputControl activeControl { get => default; } // 0x0000000189BA7A40-0x0000000189BA7AB4 
		public System.Type activeValueType { get => default; } // 0x0000000189BA7AB4-0x0000000189BA7B20 
		public bool wantsInitialStateCheck { get => default; set {} } // 0x0000000182F1C050-0x0000000182F1C060 0x0000000189BA7F84-0x0000000189BA7FA0
		internal bool isSingletonAction { get => default; } // 0x0000000189BA7BC8-0x0000000189BA7BE4 
		private InputActionState.TriggerState currentState { get => default; } // 0x0000000182EB9980-0x0000000182EB9A10 
	
		// Events
		public event Action<CallbackContext> started;
		public event Action<CallbackContext> canceled;
		public event Action<CallbackContext> performed;
	
		// Nested types
		[Flags]
		internal enum ActionFlags // TypeDefIndex: 44056
		{
			WantsInitialStateCheck = 1
		}
	
		public struct CallbackContext // TypeDefIndex: 44057
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal int m_ActionIndex; // 0x08
	
			// Properties
			private int actionIndex { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
			private int bindingIndex { get => default; } // 0x00000001822BDD00-0x00000001822BDD30 
			private int controlIndex { get => default; } // 0x00000001822BECA0-0x00000001822BECE0 
			private int interactionIndex { get => default; } // 0x0000000189B9DD08-0x0000000189B9DD38 
			public InputActionPhase phase { get => default; } // 0x00000001822BF3F0-0x00000001822BF410 
			public bool started { get => default; } // 0x0000000189B9DDC0-0x0000000189B9DDD8 
			public bool performed { get => default; } // 0x0000000189B9DD88-0x0000000189B9DDA0 
			public bool canceled { get => default; } // 0x00000001822BF3C0-0x00000001822BF3F0 
			public InputAction action { get => default; } // 0x00000001822BD670-0x00000001822BD6A0 
			public InputControl control { get => default; } // 0x00000001822BEA60-0x00000001822BEAC0 
			public IInputInteraction interaction { get => default; } // 0x0000000189B9DD38-0x0000000189B9DD88 
			public double time { get => default; } // 0x0000000189B9DDD8-0x0000000189B9DDF8 
			public double startTime { get => default; } // 0x0000000189B9DDA0-0x0000000189B9DDC0 
			public double duration { get => default; } // 0x0000000189B9DCD4-0x0000000189B9DD08 
			public System.Type valueType { get => default; } // 0x0000000189B9DE4C-0x0000000189B9DEA0 
			public int valueSizeInBytes { get => default; } // 0x0000000189B9DDF8-0x0000000189B9DE4C 
	
			// Methods
			public unsafe void ReadValue(void* buffer, int bufferSize) {} // 0x0000000189B9D964-0x0000000189B9DB28
			public TValue ReadValue<TValue>()
				where TValue : struct => default;
			public bool ReadValueAsButton() => default; // 0x0000000182EB6BA0-0x0000000182EB6C20
			public object ReadValueAsObject() => default; // 0x0000000189B9D8E8-0x0000000189B9D964
			public override string ToString() => default; // 0x0000000189B9DB28-0x0000000189B9DCD4
		}
	
		// Constructors
		public InputAction() {} // 0x0000000182A6B530-0x0000000182A6B5F0
		public InputAction(string name = null, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x01FB633D */, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) {} // 0x0000000189BA77DC-0x0000000189BA79CC
		static InputAction() {} // 0x0000000183CBA0E0-0x0000000183CBA180
	
		// Methods
		public void Dispose() {} // 0x0000000189BA6C8C-0x0000000189BA6CAC
		public override string ToString() => default; // 0x0000000189BA71D8-0x0000000189BA747C
		public void Enable() {} // 0x0000000182EB9110-0x0000000182EB9900
		public void Disable() {} // 0x0000000189BA6B8C-0x0000000189BA6C8C
		public InputAction Clone() => default; // 0x0000000189BA6994-0x0000000189BA6AB8
		object ICloneable.Clone() => default; // 0x0000000189BA71D0-0x0000000189BA71D8
		public TValue ReadValue<TValue>()
			where TValue : struct => default;
		public object ReadValueAsObject() => default; // 0x0000000189BA70B0-0x0000000189BA7130
		public float GetControlMagnitude() => default; // 0x0000000189BA6EB0-0x0000000189BA6EFC
		public void Reset() {} // 0x0000000189BA716C-0x0000000189BA71D0
		public bool IsPressed() => default; // 0x0000000189BA7068-0x0000000189BA70B0
		public bool IsInProgress() => default; // 0x0000000189BA701C-0x0000000189BA7068
		private int ExpectedFrame() => default; // 0x0000000189BA6CAC-0x0000000189BA6D10
		public bool WasPressedThisFrame() => default; // 0x0000000189BA7688-0x0000000189BA7704
		public bool WasPressedThisDynamicUpdate() => default; // 0x0000000189BA762C-0x0000000189BA7688
		public bool WasReleasedThisFrame() => default; // 0x0000000189BA7760-0x0000000189BA77DC
		public bool WasReleasedThisDynamicUpdate() => default; // 0x0000000189BA7704-0x0000000189BA7760
		public bool WasPerformedThisFrame() => default; // 0x0000000189BA75B0-0x0000000189BA762C
		public bool WasPerformedThisDynamicUpdate() => default; // 0x0000000189BA7554-0x0000000189BA75B0
		public bool WasCompletedThisFrame() => default; // 0x0000000189BA74D8-0x0000000189BA7554
		public bool WasCompletedThisDynamicUpdate() => default; // 0x0000000189BA747C-0x0000000189BA74D8
		public float GetTimeoutCompletionPercentage() => default; // 0x0000000189BA6EFC-0x0000000189BA701C
		internal string MakeSureIdIsInPlace() => default; // 0x00000001839DE430-0x00000001839DE460
		internal void GenerateId() {} // 0x0000000189BA6E6C-0x0000000189BA6EB0
		internal InputActionMap GetOrCreateActionMap() => default; // 0x0000000182EB9900-0x0000000182EB9930
		private void CreateInternalActionMapForSingletonAction() {} // 0x0000000189BA6AB8-0x0000000189BA6B8C
		internal void RequestInitialStateCheckOnEnabledAction() {} // 0x0000000189BA7130-0x0000000189BA716C
		internal bool ActiveControlIsValid(InputControl control) => default; // 0x0000000189BA669C-0x0000000189BA677C
		internal InputBinding? FindEffectiveBindingMask() => default; // 0x0000000189BA6D10-0x0000000189BA6E6C
		internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) => default; // 0x0000000189BA677C-0x0000000189BA68F4
		internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) => default; // 0x0000000189BA68F4-0x0000000189BA6994
	}

	public class InputActionAsset : ScriptableObject, IInputActionCollection2 // TypeDefIndex: 44064
	{
		// Fields
		public const string Extension = "inputactions"; // Metadata: 0x01FB6341
		internal const string kDefaultAssetLayoutJson = "{}"; // Metadata: 0x01FB634E
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
		public bool enabled { get => default; } // 0x0000000189B9FB44-0x0000000189B9FC74 
		public ReadOnlyArray<InputActionMap> actionMaps { get => default; } // 0x00000001834B1770-0x00000001834B17D0 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x0000000189B9FAF0-0x0000000189B9FB44 
		public IEnumerable<InputBinding> bindings { [IteratorStateMachine(typeof(_get_bindings_d__9))] get => default; } // 0x0000000189B9FA80-0x0000000189B9FAF0 
		public InputBinding? bindingMask { get => default; set {} } // 0x0000000183D76A50-0x0000000183D76A90 0x0000000189B9FC74-0x0000000189B9FE18
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x0000000184273058-0x0000000184273090 0x0000000189B9FE18-0x0000000189B9FE60
		public InputAction this[string actionNameOrId] { get => default; } // 0x0000000189B9F9EC-0x0000000189B9FA80 
	
		// Nested types
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 44059
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.WriteMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
		}
	
		[Serializable]
		internal struct WriteFileJsonNoName // TypeDefIndex: 44060
		{
			// Fields
			public InputActionMap.WriteMapJson[] maps; // 0x00
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x08
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 44061
		{
			// Fields
			public string name; // 0x00
			public InputActionMap.ReadMapJson[] maps; // 0x08
			public InputControlScheme.SchemeJson[] controlSchemes; // 0x10
	
			// Methods
			public void ToAsset(InputActionAsset asset) {} // 0x0000000189BAAB98-0x0000000189BAAC58
		}
	
		// Constructors
		public InputActionAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public string ToJson() => default; // 0x0000000189B9F934-0x0000000189B9F9EC
		public void LoadFromJson(string json) {} // 0x0000000189B9F6A0-0x0000000189B9F770
		public static InputActionAsset FromJson(string json) => default; // 0x0000000189B9F3D4-0x0000000189B9F48C
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x01FB633F */) => default; // 0x0000000189B9ED6C-0x0000000189B9F0CC
		public int FindBinding(InputBinding mask, out InputAction action) {
			action = default;
			return default;
		} // 0x0000000189B9F0CC-0x0000000189B9F1DC
		public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false /* Metadata: 0x01FB6340 */) => default; // 0x0000000189B9EAB4-0x0000000189B9ECC4
		public InputActionMap FindActionMap(Guid id) => default; // 0x0000000189B9ECC4-0x0000000189B9ED6C
		public InputAction FindAction(Guid guid) => default; // 0x0000000182EBA420-0x0000000182EBA4D0
		public int FindControlSchemeIndex(string name) => default; // 0x0000000189B9F1DC-0x0000000189B9F2A4
		public InputControlScheme? FindControlScheme(string name) => default; // 0x0000000189B9F2A4-0x0000000189B9F3D4
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189B9F55C-0x0000000189B9F6A0
		public void Enable() {} // 0x0000000189B9E984-0x0000000189B9EAB4
		public void Disable() {} // 0x0000000189B9E854-0x0000000189B9E984
		public bool Contains(InputAction action) => default; // 0x0000000189B9E7E4-0x0000000189B9E854
		[IteratorStateMachine(typeof(_GetEnumerator_d__32))]
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x0000000189B9F48C-0x0000000189B9F4E8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189B9F92C-0x0000000189B9F934
		internal void MarkAsDirty() {} // 0x000000018350B670-0x000000018350B680
		internal bool IsEmpty() => default; // 0x0000000189B9F4E8-0x0000000189B9F55C
		internal void OnWantToChangeSetup() {} // 0x0000000189B9F820-0x0000000189B9F878
		internal void OnSetupChanged() {} // 0x0000000189B9F7AC-0x0000000189B9F820
		private void ReResolveIfNecessary(bool fullResolve) {} // 0x0000000189B9F878-0x0000000189B9F8B4
		internal void ResolveBindingsIfNecessary() {} // 0x0000000189B9F8B4-0x0000000189B9F92C
		private void OnDestroy() {} // 0x0000000189B9F770-0x0000000189B9F7AC
	}

	public enum InputActionChange // TypeDefIndex: 44065
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
	public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IDisposable // TypeDefIndex: 44077
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
		public string name { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public InputActionAsset asset { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Guid id { get => default; } // 0x0000000189BA1198-0x0000000189BA11E4 
		internal Guid idDontGenerate { get => default; } // 0x0000000189BA114C-0x0000000189BA1198 
		public bool enabled { get => default; } // 0x0000000189785D6C-0x0000000189785D74 
		public ReadOnlyArray<InputAction> actions { get => default; } // 0x0000000189BA1008-0x0000000189BA105C 
		public ReadOnlyArray<InputBinding> bindings { get => default; } // 0x0000000189BA1068-0x0000000189BA10BC 
		IEnumerable<InputBinding> IInputActionCollection2.bindings { get => default; } // 0x0000000189BA0E68-0x0000000189BA0EC0 
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x0000000189BA10BC-0x0000000189BA114C 
		public InputBinding? bindingMask { get => default; set {} } // 0x0000000183D76A90-0x0000000183D76AD0 0x0000000189BA1230-0x0000000189BA13E8
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x0000000182CB0CA0-0x0000000182CB0D40 0x0000000189BA13E8-0x0000000189BA1430
		public InputAction this[string actionNameOrId] { get => default; } // 0x0000000189BA0F0C-0x0000000189BA1008 
		private bool needToResolveBindings { get => default; set {} } // 0x0000000182EB9100-0x0000000182EB9110 0x00000001834B1750-0x00000001834B1770
		private bool bindingResolutionNeedsFullReResolve { get => default; set {} } // 0x00000001834B1560-0x00000001834B1570 0x00000001834B1730-0x00000001834B1750
		private bool controlsForEachActionInitialized { get => default; set {} } // 0x0000000182EB7970-0x0000000182EB7980 0x00000001834B1710-0x00000001834B1730
		private bool bindingsForEachActionInitialized { get => default; set {} } // 0x0000000189BA105C-0x0000000189BA1068 0x00000001834B16F0-0x00000001834B1710
	
		// Events
		public event Action<InputAction.CallbackContext> actionTriggered;
	
		// Nested types
		[Flags]
		private enum Flags // TypeDefIndex: 44066
		{
			NeedToResolveBindings = 1,
			BindingResolutionNeedsFullReResolve = 2,
			ControlsForEachActionInitialized = 4,
			BindingsForEachActionInitialized = 8
		}
	
		internal struct DeviceArray // TypeDefIndex: 44067
		{
			// Fields
			private bool m_HaveValue; // 0x00
			private int m_DeviceCount; // 0x04
			private UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x08
	
			// Methods
			public int IndexOf(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189B9E138-0x0000000189B9E188
			public bool Remove(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189B9E188-0x0000000189B9E1F0
			public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? Get() => default; // 0x0000000182CB0D40-0x0000000182CB0DB0
			public bool Set(ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices) => default; // 0x0000000189B9E1F0-0x0000000189B9E33C
		}
	
		[Serializable]
		internal struct BindingOverrideListJson // TypeDefIndex: 44068
		{
			// Fields
			public List<BindingOverrideJson> bindings; // 0x00
		}
	
		[Serializable]
		internal struct BindingOverrideJson // TypeDefIndex: 44069
		{
			// Fields
			public string action; // 0x00
			public string id; // 0x08
			public string path; // 0x10
			public string interactions; // 0x18
			public string processors; // 0x20
	
			// Methods
			public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) => default; // 0x0000000189B9D650-0x0000000189B9D74C
			public static BindingOverrideJson FromBinding(InputBinding binding) => default; // 0x0000000189B9D74C-0x0000000189B9D7C8
			public static InputBinding ToBinding(BindingOverrideJson bindingOverride) => default; // 0x0000000189B9D7C8-0x0000000189B9D8E8
		}
	
		[Serializable]
		internal struct BindingJson // TypeDefIndex: 44070
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
			public InputBinding ToBinding() => default; // 0x0000000189B9D52C-0x0000000189B9D650
			public static BindingJson FromBinding(ref InputBinding binding) => default; // 0x0000000189B9D474-0x0000000189B9D52C
		}
	
		[Serializable]
		internal struct ReadActionJson // TypeDefIndex: 44071
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
			public InputAction ToAction(string actionName = null) => default; // 0x0000000189BAA95C-0x0000000189BAAB98
		}
	
		[Serializable]
		internal struct WriteActionJson // TypeDefIndex: 44072
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
			public static WriteActionJson FromAction(InputAction action) => default; // 0x0000000189BAF738-0x0000000189BAF824
		}
	
		[Serializable]
		internal struct ReadMapJson // TypeDefIndex: 44073
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public ReadActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
		}
	
		[Serializable]
		internal struct WriteMapJson // TypeDefIndex: 44074
		{
			// Fields
			public string name; // 0x00
			public string id; // 0x08
			public WriteActionJson[] actions; // 0x10
			public BindingJson[] bindings; // 0x18
	
			// Methods
			public static WriteMapJson FromMap(InputActionMap map) => default; // 0x0000000189BAFADC-0x0000000189BAFE6C
		}
	
		[Serializable]
		internal struct WriteFileJson // TypeDefIndex: 44075
		{
			// Fields
			public WriteMapJson[] maps; // 0x00
	
			// Methods
			public static WriteFileJson FromMap(InputActionMap map) => default; // 0x0000000189BAF824-0x0000000189BAF8BC
			public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps) => default; // 0x0000000189BAF8BC-0x0000000189BAFADC
		}
	
		[Serializable]
		internal struct ReadFileJson // TypeDefIndex: 44076
		{
			// Fields
			public ReadActionJson[] actions; // 0x00
			public ReadMapJson[] maps; // 0x08
	
			// Methods
			public InputActionMap[] ToMaps() => default; // 0x0000000189BAAC58-0x0000000189BABA10
		}
	
		// Constructors
		public InputActionMap() {} // 0x0000000183895670-0x00000001838956D0
		public InputActionMap(string name) {} // 0x0000000183895640-0x0000000183895670
		static InputActionMap() {} // 0x0000000183D06FB0-0x0000000183D07010
	
		// Methods
		public void Dispose() {} // 0x0000000189BA0108-0x0000000189BA011C
		internal int FindActionIndex(string nameOrId) => default; // 0x0000000182F1C5D0-0x0000000182F1C700
		private void SetUpActionLookupTable() {} // 0x0000000182F1C700-0x0000000182F1C850
		internal void ClearActionLookupTable() {} // 0x00000001834B1660-0x00000001834B16A0
		private int FindActionIndex(Guid id) => default; // 0x0000000182EBA520-0x0000000182EBA620
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x01FB635A */) => default; // 0x0000000182F1C560-0x0000000182F1C5D0
		public InputAction FindAction(Guid id) => default; // 0x0000000182EBA4D0-0x0000000182EBA520
		public bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BA04E0-0x0000000189BA0604
		public void Enable() {} // 0x0000000189BA011C-0x0000000189BA0160
		public void Disable() {} // 0x0000000189BA00D8-0x0000000189BA0108
		public InputActionMap Clone() => default; // 0x0000000189B9FE60-0x0000000189BA00AC
		object ICloneable.Clone() => default; // 0x0000000189BA0CBC-0x0000000189BA0CC4
		public bool Contains(InputAction action) => default; // 0x0000000189BA00AC-0x0000000189BA00D8
		public override string ToString() => default; // 0x0000000189BA0DCC-0x0000000189BA0E68
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x0000000189BA0450-0x0000000189BA04E0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BA0CB4-0x0000000189BA0CBC
		internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action) => default; // 0x0000000189BA03BC-0x0000000189BA0450
		internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action) => default; // 0x0000000182EB78D0-0x0000000182EB7970
		private void SetUpPerActionControlAndBindingArrays() {} // 0x0000000182F1C080-0x0000000182F1C560
		internal void OnWantToChangeSetup() {} // 0x0000000189BA094C-0x0000000189BA0CB4
		internal void OnSetupChanged() {} // 0x0000000189BA06F4-0x0000000189BA094C
		internal void OnBindingModified() {} // 0x0000000189BA06CC-0x0000000189BA06F4
		internal void ClearCachedActionData(bool onlyControls = false /* Metadata: 0x01FB635B */) {} // 0x00000001834B16A0-0x00000001834B16F0
		internal void GenerateId() {} // 0x00000001893A1C20-0x00000001893A1C64
		internal bool LazyResolveBindings(bool fullResolve) => default; // 0x0000000189BA0604-0x0000000189BA06CC
		internal bool ResolveBindingsIfNecessary() => default; // 0x0000000182EB90D0-0x0000000182EB9100
		internal void ResolveBindings() {} // 0x00000001834AFF30-0x00000001834B1560
		public int FindBinding(InputBinding mask, out InputAction action) {
			action = default;
			return default;
		} // 0x0000000189BA01EC-0x0000000189BA030C
		internal int FindBindingRelativeToMap(InputBinding mask) => default; // 0x0000000189BA0160-0x0000000189BA01EC
		public static InputActionMap[] FromJson(string json) => default; // 0x0000000189BA030C-0x0000000189BA03BC
		public static string ToJson(IEnumerable<InputActionMap> maps) => default; // 0x0000000189BA0CC4-0x0000000189BA0D74
		public string ToJson() => default; // 0x0000000189BA0D74-0x0000000189BA0DCC
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x00000001834B1570-0x00000001834B1660
	}

	public static class InputActionRebindingExtensions // TypeDefIndex: 44087
	{
		// Fields
		private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x00
	
		// Nested types
		internal struct Parameter // TypeDefIndex: 44078
		{
			// Fields
			public object instance; // 0x00
			public System.Reflection.FieldInfo field; // 0x08
			public int bindingIndex; // 0x10
		}
	
		private struct ParameterEnumerable : IEnumerable<Parameter> // TypeDefIndex: 44079
		{
			// Fields
			private InputActionState m_State; // 0x00
			private ParameterOverride m_Parameter; // 0x08
			private int m_MapIndex; // 0x80
	
			// Constructors
			public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x01FB6367 */) {
				m_State = default;
				m_Parameter = default;
				m_MapIndex = default;
			} // 0x0000000189BA9568-0x0000000189BA95E0
	
			// Methods
			public ParameterEnumerator GetEnumerator() => default; // 0x0000000189BA92D0-0x0000000189BA93F0
			IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() => default; // 0x0000000189BA93F0-0x0000000189BA94AC
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BA94AC-0x0000000189BA9568
		}
	
		private struct ParameterEnumerator : IEnumerator<Parameter> // TypeDefIndex: 44080
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
			public Parameter Current { get => default; } // 0x0000000189BA9D54-0x0000000189BA9DA0 
			object IEnumerator.Current { get => default; } // 0x0000000189BA9AAC-0x0000000189BA9B0C 
	
			// Constructors
			public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1 /* Metadata: 0x01FB6368 */) : this() {
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
			} // 0x0000000189BA9B0C-0x0000000189BA9D54
	
			// Methods
			private bool MoveToNextBinding() => default; // 0x0000000189BA9788-0x0000000189BA98F4
			private bool MoveToNextInteraction() => default; // 0x0000000189BA98F4-0x0000000189BA9958
			private bool MoveToNextProcessor() => default; // 0x0000000189BA9958-0x0000000189BA99BC
			private bool FindParameter(object instance) => default; // 0x0000000189BA95E0-0x0000000189BA96CC
			public bool MoveNext() => default; // 0x0000000189BA96CC-0x0000000189BA9788
			public void Reset() {} // 0x0000000189BA99BC-0x0000000189BA9AAC
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		internal struct ParameterOverride // TypeDefIndex: 44081
		{
			// Fields
			public string objectRegistrationName; // 0x00
			public string parameter; // 0x08
			public InputBinding bindingMask; // 0x10
			public PrimitiveValue value; // 0x68
	
			// Properties
			public System.Type objectType { get => default; } // 0x0000000189BAA8C4-0x0000000189BAA95C 
	
			// Constructors
			public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default) : this() {
				objectRegistrationName = default;
				parameter = default;
				this.bindingMask = default;
				this.value = default;
			} // 0x0000000189BAA7D8-0x0000000189BAA8C4
			public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default) : this() {
				this.objectRegistrationName = default;
				parameter = default;
				this.bindingMask = default;
				this.value = default;
			} // 0x0000000189BAA75C-0x0000000189BAA7D8
	
			// Methods
			public static ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName) => default; // 0x0000000189BAA158-0x0000000189BAA3CC
			private static ParameterOverride? Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName) => default; // 0x0000000189BA9DA0-0x0000000189BAA158
			private static ParameterOverride? PickMoreSpecificOne(ParameterOverride? first, ParameterOverride? second) => default; // 0x0000000189BAA3CC-0x0000000189BAA75C
		}
	
		public sealed class RebindingOperation : IDisposable // TypeDefIndex: 44084
		{
			// Fields
			public const float kDefaultMagnitudeThreshold = 0.2f; // Metadata: 0x01FB636E
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
			public InputAction action { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public InputBinding? bindingMask { get => default; } // 0x0000000183D626A0-0x0000000183D626E0 
			public InputControlList<InputControl> candidates { get => default; } // 0x0000000183D76B40-0x0000000183D76B60 
			public ReadOnlyArray<float> scores { get => default; } // 0x0000000189BAEA74-0x0000000189BAEAE8 
			public ReadOnlyArray<float> magnitudes { get => default; } // 0x0000000189BAEA00-0x0000000189BAEA74 
			public InputControl selectedControl { get => default; } // 0x0000000189BAEAE8-0x0000000189BAEB44 
			public bool started { get => default; } // 0x0000000189BAEB44-0x0000000189BAEB50 
			public bool completed { get => default; } // 0x0000000189BAE9D0-0x0000000189BAE9DC 
			public bool canceled { get => default; } // 0x0000000189BAE9C4-0x0000000189BAE9D0 
			public double startTime { get => default; } // 0x0000000183D6B940-0x0000000183D6B950 
			public float timeout { get => default; } // 0x0000000183D57540-0x0000000183D57550 
			public string expectedControlType { get => default; } // 0x0000000189BAE9DC-0x0000000189BAEA00 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 44082
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
	
			// Constructors
			public RebindingOperation() {} // 0x0000000189BAE938-0x0000000189BAE9C4
	
			// Methods
			public RebindingOperation WithAction(InputAction action) => default; // 0x0000000189BADAAC-0x0000000189BADBF4
			public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true /* Metadata: 0x01FB6369 */) => default; // 0x0000000189BAE2E4-0x0000000189BAE32C
			public RebindingOperation WithCancelingThrough(string binding) => default; // 0x0000000189BADD48-0x0000000189BADD80
			public RebindingOperation WithCancelingThrough(InputControl control) => default; // 0x0000000189BADD80-0x0000000189BADE14
			public RebindingOperation WithExpectedControlType(string layoutName) => default; // 0x0000000189BAE1B4-0x0000000189BAE20C
			public RebindingOperation WithExpectedControlType(System.Type type) => default; // 0x0000000189BAE064-0x0000000189BAE1B4
			public RebindingOperation WithExpectedControlType<TControl>()
				where TControl : InputControl => default;
			public RebindingOperation WithTargetBinding(int bindingIndex) => default; // 0x0000000189BAE358-0x0000000189BAE918
			public RebindingOperation WithBindingMask(InputBinding? bindingMask) => default; // 0x0000000189BADD00-0x0000000189BADD48
			public RebindingOperation WithBindingGroup(string group) => default; // 0x0000000189BADBF4-0x0000000189BADD00
			public RebindingOperation WithoutGeneralizingPathOfSelectedControl() => default; // 0x0000000183D76B30-0x0000000183D76B40
			public RebindingOperation WithRebindAddingNewBinding(string group = null) => default; // 0x0000000189BAE32C-0x0000000189BAE358
			public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) => default; // 0x0000000189BAE20C-0x0000000189BAE2E4
			public RebindingOperation WithoutIgnoringNoisyControls() => default; // 0x0000000189BAE918-0x0000000189BAE938
			public RebindingOperation WithControlsHavingToMatchPath(string path) => default; // 0x0000000189BADF3C-0x0000000189BAE064
			public RebindingOperation WithControlsExcluding(string path) => default; // 0x0000000189BADE14-0x0000000189BADF3C
			public RebindingOperation WithTimeout(float timeInSeconds) => default; // 0x0000000183D76B20-0x0000000183D76B30
			public RebindingOperation OnComplete(Action<RebindingOperation> callback) => default; // 0x0000000189BAC4A8-0x0000000189BAC4CC
			public RebindingOperation OnCancel(Action<RebindingOperation> callback) => default; // 0x0000000189BAC0D4-0x0000000189BAC0F8
			public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback) => default; // 0x0000000189BAD3F4-0x0000000189BAD418
			public RebindingOperation OnGeneratePath(Func<InputControl, string> callback) => default; // 0x0000000189BAD3D0-0x0000000189BAD3F4
			public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback) => default; // 0x0000000189BAC4CC-0x0000000189BAC4F0
			public RebindingOperation OnApplyBinding(Action<RebindingOperation, string> callback) => default; // 0x0000000189BAC078-0x0000000189BAC09C
			public RebindingOperation OnMatchWaitForAnother(float seconds) => default; // 0x0000000183D76B10-0x0000000183D76B20
			public RebindingOperation Start() => default; // 0x0000000189BAD7DC-0x0000000189BAD984
			public void Cancel() {} // 0x0000000189BABBA0-0x0000000189BABBB4
			public void Complete() {} // 0x0000000189BABBB4-0x0000000189BABBC8
			public void AddCandidate(InputControl control, float score, float magnitude = -1f /* Metadata: 0x01FB636A */) {} // 0x0000000189BABA10-0x0000000189BABBA0
			public void RemoveCandidate(InputControl control) {} // 0x0000000189BAD418-0x0000000189BAD524
			public void Dispose() {} // 0x0000000189BABBC8-0x0000000189BABC2C
			~RebindingOperation() {} // 0x0000000189BABC2C-0x0000000189BABC9C
			public RebindingOperation Reset() => default; // 0x0000000189BAD5CC-0x0000000189BAD6B0
			private void HookOnEvent() {} // 0x0000000189BABF04-0x0000000189BABFCC
			private void UnhookOnEvent() {} // 0x0000000189BADA54-0x0000000189BADAAC
			private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BAC4F0-0x0000000189BAD3D0
			private void SortCandidatesByScore() {} // 0x0000000189BAD6B0-0x0000000189BAD7DC
			private static bool HavePathMatch(InputControl control, string[] paths, int pathCount) => default; // 0x0000000189BABDC8-0x0000000189BABE3C
			private void HookOnAfterUpdate() {} // 0x0000000189BABE3C-0x0000000189BABF04
			private void UnhookOnAfterUpdate() {} // 0x0000000189BAD9F0-0x0000000189BADA54
			private void OnAfterUpdate() {} // 0x0000000189BABFCC-0x0000000189BAC078
			private void OnComplete() {} // 0x0000000189BAC0F8-0x0000000189BAC4A8
			private void OnCancel() {} // 0x0000000189BAC09C-0x0000000189BAC0D4
			private void ResetAfterMatchCompleted() {} // 0x0000000189BAD524-0x0000000189BAD5CC
			private void ThrowIfRebindInProgress() {} // 0x0000000189BAD984-0x0000000189BAD9F0
			private string GeneratePathForControl(InputControl control) => default; // 0x0000000189BABC9C-0x0000000189BABDC8
		}
	
		internal class DeferBindingResolutionWrapper : IDisposable // TypeDefIndex: 44085
		{
			// Constructors
			public DeferBindingResolutionWrapper() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Acquire() {} // 0x00000001822BEE20-0x00000001822BEE80
			public void Dispose() {} // 0x000000018289CC90-0x000000018289CD80
		}
	
		// Methods
		private static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default, PrimitiveValue value = default) => default;
		private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride) {} // 0x0000000189BA224C-0x0000000189BA2A34
		internal static DeferBindingResolutionWrapper DeferBindingResolution() => default; // 0x00000001822BED10-0x00000001822BEE20
	
		// Extension methods
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, InputBinding bindingMask = default) => default; // 0x0000000189BA4418-0x0000000189BA4600
		private static PrimitiveValue? GetParameterValue(this InputAction action, ParameterOverride parameterOverride) => default; // 0x0000000189BA4600-0x0000000189BA4960
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, int bindingIndex) => default; // 0x0000000189BA4960-0x0000000189BA4C04
		public static TValue? GetParameterValue<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default)
			where TValue : struct => default;
		public static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {}
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {}
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default)
			where TValue : struct {}
		public static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x0000000189BA2C50-0x0000000189BA2E4C
		public static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x0000000189BA30E8-0x0000000189BA331C
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = default) {} // 0x0000000189BA2A34-0x0000000189BA2C50
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex) {} // 0x0000000189BA2E4C-0x0000000189BA30E8
		public static int GetBindingIndex(this InputAction action, InputBinding bindingMask) => default; // 0x0000000189BA406C-0x0000000189BA41B8
		public static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask) => default; // 0x0000000189BA42CC-0x0000000189BA4418
		public static int GetBindingIndex(this InputAction action, string group = null, string path = null) => default; // 0x0000000189BA41B8-0x0000000189BA42CC
		public static InputBinding? GetBindingForControl(this InputAction action, InputControl control) => default; // 0x0000000189BA3CC4-0x0000000189BA3EC8
		public static int GetBindingIndexForControl(this InputAction action, InputControl control) => default; // 0x0000000189BA3EC8-0x0000000189BA406C
		public static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options =  /* Metadata: 0x01FB6360 */, string group = null) => default; // 0x0000000189BA3900-0x0000000189BA3AB8
		public static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options =  /* Metadata: 0x01FB6361 */) => default; // 0x0000000189BA3AB8-0x0000000189BA3CC4
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options =  /* Metadata: 0x01FB6362 */) => default; // 0x0000000189BA331C-0x0000000189BA33A4
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options =  /* Metadata: 0x01FB6363 */) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x0000000189BA33A4-0x0000000189BA3900
		public static void ApplyBindingOverride(this InputAction action, string newPath, string group = null, string path = null) {} // 0x0000000189BA1598-0x0000000189BA16B4
		public static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride) {} // 0x0000000189BA17BC-0x0000000189BA18DC
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride) {} // 0x0000000189BA18DC-0x0000000189BA19D4
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path) {} // 0x0000000189BA16B4-0x0000000189BA17BC
		public static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride) => default; // 0x0000000189BA19D4-0x0000000189BA1B28
		public static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) {} // 0x0000000189BA1B28-0x0000000189BA1D08
		public static void RemoveBindingOverride(this InputAction action, int bindingIndex) {} // 0x0000000189BA5B08-0x0000000189BA5BE4
		public static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask) {} // 0x0000000189BA5A1C-0x0000000189BA5B08
		private static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask) {} // 0x0000000189BA5BE4-0x0000000189BA5CD0
		public static void RemoveAllBindingOverrides(this IInputActionCollection2 actions) {} // 0x0000000189BA5644-0x0000000189BA58DC
		public static void RemoveAllBindingOverrides(this InputAction action) {} // 0x0000000189BA58DC-0x0000000189BA5A1C
		public static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides) {} // 0x0000000189BA200C-0x0000000189BA224C
		public static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides) {} // 0x0000000189BA5CD0-0x0000000189BA5F10
		public static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control) => default; // 0x0000000189BA1E68-0x0000000189BA200C
		public static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control) => default; // 0x0000000189BA1D08-0x0000000189BA1E68
		public static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions) => default; // 0x0000000189BA5F10-0x0000000189BA62A0
		public static string SaveBindingOverridesAsJson(this InputAction action) => default; // 0x0000000189BA62A0-0x0000000189BA669C
		private static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null) {} // 0x0000000189BA1430-0x0000000189BA1598
		public static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true /* Metadata: 0x01FB6364 */) {} // 0x0000000189BA4FB4-0x0000000189BA50D8
		public static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true /* Metadata: 0x01FB6365 */) {} // 0x0000000189BA50D8-0x0000000189BA5204
		private static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json) {} // 0x0000000189BA4C04-0x0000000189BA4FB4
		public static RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1 /* Metadata: 0x01FB6366 */) => default; // 0x0000000189BA5204-0x0000000189BA5644
	}

	public enum InputActionPhase // TypeDefIndex: 44088
	{
		Disabled = 0,
		Waiting = 1,
		Started = 2,
		Performed = 3,
		Canceled = 4
	}

	[Serializable]
	public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference> // TypeDefIndex: 44089
	{
		// Fields
		[SerializeField]
		private bool m_UseReference; // 0x00
		[SerializeField]
		private InputAction m_Action; // 0x08
		[SerializeField]
		private InputActionReference m_Reference; // 0x10
	
		// Properties
		public InputAction action { get => default; } // 0x0000000189BB2398-0x0000000189BB2414 
		public InputActionReference reference { get => default; } // 0x0000000189BB2414-0x0000000189BB2424 
		internal InputAction serializedAction { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		internal InputActionReference serializedReference { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public InputActionProperty(InputAction action) : this() {
			m_UseReference = default;
			m_Action = default;
			m_Reference = default;
		} // 0x0000000189BB233C-0x0000000189BB2368
		public InputActionProperty(InputActionReference reference) : this() {
			m_UseReference = default;
			m_Action = default;
			m_Reference = default;
		} // 0x0000000189BB2368-0x0000000189BB2398
	
		// Methods
		public bool Equals(InputActionProperty other) => default; // 0x0000000189BB212C-0x0000000189BB21B4
		public bool Equals(InputAction other) => default; // 0x0000000189BB2248-0x0000000189BB2264
		public bool Equals(InputActionReference other) => default; // 0x0000000189BB2264-0x0000000189BB22B8
		public override bool Equals(object obj) => default; // 0x0000000189BB21B4-0x0000000189BB2248
		public override int GetHashCode() => default; // 0x0000000189BB22B8-0x0000000189BB233C
		public static bool operator ==(InputActionProperty left, InputActionProperty right) => default; // 0x0000000189BB2424-0x0000000189BB2450
		public static bool operator !=(InputActionProperty left, InputActionProperty right) => default; // 0x0000000189BB2450-0x0000000189BB247C
	}

	public class InputActionReference : ScriptableObject // TypeDefIndex: 44090
	{
		// Fields
		[SerializeField]
		internal InputActionAsset m_Asset; // 0x18
		[SerializeField]
		internal string m_ActionId; // 0x20
		[NonSerialized]
		private InputAction m_Action; // 0x28
	
		// Properties
		public InputActionAsset asset { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public InputAction action { get => default; } // 0x0000000182EBA340-0x0000000182EBA420 
	
		// Constructors
		public InputActionReference() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public void Set(InputAction action) {} // 0x0000000189BB27EC-0x0000000189BB290C
		public void Set(InputActionAsset asset, string mapName, string actionName) {} // 0x0000000189BB290C-0x0000000189BB2BD4
		private void SetInternal(InputActionAsset asset, InputAction action) {} // 0x0000000189BB2654-0x0000000189BB27EC
		public override string ToString() => default; // 0x0000000189BB2C20-0x0000000189BB2E18
		internal static string GetDisplayName(InputAction action) => default; // 0x0000000189BB24E4-0x0000000189BB2570
		internal string ToDisplayName() => default; // 0x0000000189BB2BD4-0x0000000189BB2C18
		public static implicit operator InputAction(InputActionReference reference) => default; // 0x0000000189BB2E18-0x0000000189BB2E34
		public static InputActionReference Create(InputAction action) => default; // 0x0000000189BB247C-0x0000000189BB24E4
		internal static void ResetCachedAction() {} // 0x0000000189BB2570-0x0000000189BB2654
		public InputAction ToInputAction() => default; // 0x0000000189BB2C18-0x0000000189BB2C20
	}

	public static class InputActionSetupExtensions // TypeDefIndex: 44095
	{
		// Nested types
		public struct BindingSyntax // TypeDefIndex: 44091
		{
			// Fields
			private readonly InputActionMap m_ActionMap; // 0x00
			private readonly InputAction m_Action; // 0x08
			internal readonly int m_BindingIndexInMap; // 0x10
	
			// Properties
			public bool valid { get => default; } // 0x0000000189BB1960-0x0000000189BB19B8 
			public int bindingIndex { get => default; } // 0x0000000189BB1880-0x0000000189BB18C0 
			public InputBinding binding { get => default; } // 0x0000000189BB18C0-0x0000000189BB1960 
	
			// Constructors
			internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null) : this() {
				m_ActionMap = default;
				m_Action = default;
				m_BindingIndexInMap = default;
			} // 0x0000000189BB1858-0x0000000189BB1880
	
			// Methods
			public BindingSyntax WithName(string name) => default; // 0x0000000189BB1320-0x0000000189BB13F4
			public BindingSyntax WithPath(string path) => default; // 0x0000000189BB13F4-0x0000000189BB14C8
			public BindingSyntax WithGroup(string group) => default; // 0x0000000189BB0C00-0x0000000189BB0DDC
			public BindingSyntax WithGroups(string groups) => default; // 0x0000000189BB0DDC-0x0000000189BB0F90
			public BindingSyntax WithInteraction(string interaction) => default; // 0x0000000189BB0F90-0x0000000189BB116C
			public BindingSyntax WithInteractions(string interactions) => default; // 0x0000000189BB116C-0x0000000189BB1320
			public BindingSyntax WithInteraction<TInteraction>()
				where TInteraction : IInputInteraction => default;
			public BindingSyntax WithProcessor(string processor) => default; // 0x0000000189BB14C8-0x0000000189BB16A4
			public BindingSyntax WithProcessors(string processors) => default; // 0x0000000189BB16A4-0x0000000189BB1858
			public BindingSyntax WithProcessor<TProcessor>() => default;
			public BindingSyntax Triggering(InputAction action) => default; // 0x0000000189BB0A40-0x0000000189BB0C00
			public BindingSyntax To(InputBinding binding) => default; // 0x0000000189BB08E8-0x0000000189BB0A40
			public BindingSyntax NextBinding() => default; // 0x0000000189BB06D8-0x0000000189BB070C
			public BindingSyntax PreviousBinding() => default; // 0x0000000189BB07E0-0x0000000189BB0814
			public BindingSyntax NextPartBinding(string partName) => default; // 0x0000000189BB0748-0x0000000189BB07E0
			public BindingSyntax PreviousPartBinding(string partName) => default; // 0x0000000189BB0850-0x0000000189BB08E8
			public BindingSyntax NextCompositeBinding(string compositeName = null) => default; // 0x0000000189BB070C-0x0000000189BB0748
			public BindingSyntax PreviousCompositeBinding(string compositeName = null) => default; // 0x0000000189BB0814-0x0000000189BB0850
			private BindingSyntax Iterate(bool next) => default; // 0x0000000189BB05F0-0x0000000189BB06D8
			private BindingSyntax IterateCompositeBinding(bool next, string compositeName) => default; // 0x0000000189BB0314-0x0000000189BB0474
			private BindingSyntax IteratePartBinding(bool next, string partName) => default; // 0x0000000189BB0474-0x0000000189BB05F0
			public void Erase() {} // 0x0000000189BAFEF4-0x0000000189BB00A0
			public BindingSyntax InsertPartBinding(string partName, string path) => default; // 0x0000000189BB00A0-0x0000000189BB0314
		}
	
		public struct CompositeSyntax // TypeDefIndex: 44092
		{
			// Fields
			private readonly InputAction m_Action; // 0x00
			private readonly InputActionMap m_ActionMap; // 0x08
			private int m_BindingIndexInMap; // 0x10
	
			// Properties
			public int bindingIndex { get => default; } // 0x0000000189BB1BD4-0x0000000189BB1BF8 
	
			// Constructors
			internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex) : this() {
				m_Action = default;
				m_ActionMap = default;
				m_BindingIndexInMap = default;
			} // 0x0000000189BB1BAC-0x0000000189BB1BD4
	
			// Methods
			public CompositeSyntax With(string name, string binding, string groups = null, string processors = null) => default; // 0x0000000189BB19B8-0x0000000189BB1BAC
		}
	
		public struct ControlSchemeSyntax // TypeDefIndex: 44093
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
			} // 0x0000000189BB2100-0x0000000189BB212C
			internal ControlSchemeSyntax(InputControlScheme controlScheme) {
				m_Asset = default;
				m_ControlSchemeIndex = default;
				m_ControlScheme = default;
			} // 0x0000000189BB20C0-0x0000000189BB2100
	
			// Methods
			public ControlSchemeSyntax WithBindingGroup(string bindingGroup) => default; // 0x0000000189BB1F04-0x0000000189BB2028
			public ControlSchemeSyntax WithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default;
			public ControlSchemeSyntax WithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default;
			public ControlSchemeSyntax OrWithRequiredDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default;
			public ControlSchemeSyntax OrWithOptionalDevice<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default;
			public ControlSchemeSyntax WithRequiredDevice(string controlPath) => default; // 0x0000000189BB2074-0x0000000189BB20C0
			public ControlSchemeSyntax WithOptionalDevice(string controlPath) => default; // 0x0000000189BB2028-0x0000000189BB2074
			public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) => default; // 0x0000000189BB1EB8-0x0000000189BB1F04
			public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) => default; // 0x0000000189BB1E6C-0x0000000189BB1EB8
			private string DeviceTypeToControlPath<TDevice>()
				where TDevice : UnityEngine.InputSystem.InputDevice => default;
			public InputControlScheme Done() => default; // 0x0000000189BB1DD0-0x0000000189BB1E6C
			private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags) {} // 0x0000000189BB1BF8-0x0000000189BB1DD0
		}
	
		// Methods
		private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1 /* Metadata: 0x01FB6385 */) => default; // 0x0000000189BB36F0-0x0000000189BB3864
	
		// Extension methods
		public static InputActionMap AddActionMap(this InputActionAsset asset, string name) => default; // 0x0000000189BB3124-0x0000000189BB331C
		public static void AddActionMap(this InputActionAsset asset, InputActionMap map) {} // 0x0000000189BB2E34-0x0000000189BB3124
		public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map) {} // 0x0000000189BB5358-0x0000000189BB54D8
		public static void RemoveActionMap(this InputActionAsset asset, string nameOrId) {} // 0x0000000189BB54D8-0x0000000189BB5604
		public static InputAction AddAction(this InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type = UnityEngine.InputSystem.InputActionType.Value /* Metadata: 0x01FB6384 */, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null) => default; // 0x0000000189BB331C-0x0000000189BB36F0
		public static void RemoveAction(this InputAction action) {} // 0x0000000189BB5604-0x0000000189BB5984
		public static void RemoveAction(this InputActionAsset asset, string nameOrId) {} // 0x0000000189BB5984-0x0000000189BB5AAC
		public static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null) => default; // 0x0000000189BB3864-0x0000000189BB395C
		public static BindingSyntax AddBinding(this InputAction action, InputControl control) => default; // 0x0000000189BB3CCC-0x0000000189BB3D84
		public static BindingSyntax AddBinding(this InputAction action, InputBinding binding = default) => default; // 0x0000000189BB3A4C-0x0000000189BB3B6C
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null) => default; // 0x0000000189BB3D84-0x0000000189BB3EFC
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null) => default; // 0x0000000189BB3EFC-0x0000000189BB4058
		public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null) => default; // 0x0000000189BB395C-0x0000000189BB3A4C
		public static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding) => default; // 0x0000000189BB3B6C-0x0000000189BB3CCC
		public static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null) => default; // 0x0000000189BB4058-0x0000000189BB4254
		public static BindingSyntax ChangeBinding(this InputAction action, int index) => default; // 0x0000000189BB4EF4-0x0000000189BB4FB4
		public static BindingSyntax ChangeBinding(this InputAction action, string name) => default; // 0x0000000189BB4C50-0x0000000189BB4D08
		public static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index) => default; // 0x0000000189BB4B28-0x0000000189BB4C50
		public static BindingSyntax ChangeBindingWithId(this InputAction action, string id) => default; // 0x0000000189BB47E8-0x0000000189BB48FC
		public static BindingSyntax ChangeBindingWithId(this InputAction action, Guid id) => default; // 0x0000000189BB48FC-0x0000000189BB4A18
		public static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group) => default; // 0x0000000189BB46D8-0x0000000189BB47E8
		public static BindingSyntax ChangeBindingWithPath(this InputAction action, string path) => default; // 0x0000000189BB4A18-0x0000000189BB4B28
		public static BindingSyntax ChangeBinding(this InputAction action, InputBinding match) => default; // 0x0000000189BB4D08-0x0000000189BB4EF4
		public static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName) => default; // 0x0000000189BB4FB4-0x0000000189BB51B8
		public static void Rename(this InputAction action, string newName) {} // 0x0000000189BB5BEC-0x0000000189BB5E78
		public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme) {} // 0x0000000189BB4254-0x0000000189BB4508
		public static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name) => default; // 0x0000000189BB4508-0x0000000189BB46D8
		public static void RemoveControlScheme(this InputActionAsset asset, string name) {} // 0x0000000189BB5AAC-0x0000000189BB5BEC
		public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup) => default; // 0x0000000189BB5E78-0x0000000189BB5F48
		public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required) => default; // 0x0000000189BB5F48-0x0000000189BB6050
		public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath) => default; // 0x0000000189BB6120-0x0000000189BB61F0
		public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath) => default; // 0x0000000189BB6050-0x0000000189BB6120
		public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath) => default; // 0x0000000189BB5288-0x0000000189BB5358
		public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath) => default; // 0x0000000189BB51B8-0x0000000189BB5288
	}

	internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable // TypeDefIndex: 44106
	{
		// Fields
		public const int kInvalidIndex = -1; // Metadata: 0x01FB6396
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
		public int totalCompositeCount { get => default; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
		public int totalMapCount { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
		public int totalActionCount { get => default; } // 0x0000000183D4EDF0-0x0000000183D4EE00 
		public int totalBindingCount { get => default; } // 0x0000000183D4EEC0-0x0000000183D4EED0 
		public int totalInteractionCount { get => default; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
		public int totalControlCount { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public unsafe ActionMapIndices* mapIndices { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
		public unsafe TriggerState* actionStates { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public unsafe BindingState* bindingStates { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public unsafe InteractionState* interactionStates { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public unsafe int* controlIndexToBindingIndex { get => default; } // 0x0000000183D4EA80-0x0000000183D4EA90 
		public unsafe ushort* controlGroupingAndComplexity { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
		public unsafe float* controlMagnitudes { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public unsafe uint* enabledControls { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public bool isProcessingControlStateChange { get => default; } // 0x0000000183D5D860-0x0000000183D5D870 
	
		// Nested types
		internal struct InteractionState // TypeDefIndex: 44097
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
			public int triggerControlIndex { get => default; set {} } // 0x0000000189BBAE64-0x0000000189BBAE78 0x0000000189BBAE9C-0x0000000189BBAF14
			public double startTime { get => default; set {} } // 0x0000000183D676E0-0x0000000183D676F0 0x0000000183D698E0-0x0000000183D698F0
			public double performedTime { get => default; set {} } // 0x0000000183D4EBD0-0x0000000183D4EBE0 0x0000000183D4EBE0-0x0000000183D4EBF0
			public double timerStartTime { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000183D4E410-0x0000000183D4E420
			public float timerDuration { get => default; set {} } // 0x0000000183D58BC0-0x0000000183D58BD0 0x0000000183D58BF0-0x0000000183D58C00
			public float totalTimeoutCompletionDone { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
			public float totalTimeoutCompletionTimeRemaining { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
			public long timerMonitorIndex { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000183D4ED70-0x0000000183D4ED80
			public bool isTimerRunning { get => default; set {} } // 0x0000000189BBAE5C-0x0000000189BBAE64 0x0000000189BBAE78-0x0000000189BBAE9C
			public InputActionPhase phase { get => default; set {} } // 0x0000000183D559C0-0x0000000183D559D0 0x0000000183D5BC20-0x0000000183D5BC30
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 44096
			{
				TimerRunning = 1
			}
		}
	
		internal struct BindingState // TypeDefIndex: 44099
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
			public int controlStartIndex { get => default; set {} } // 0x0000000183D73FD0-0x0000000183D73FE0 0x0000000182F1BF90-0x0000000182F1BFB0
			public int controlCount { get => default; set {} } // 0x0000000183D51020-0x0000000183D51030 0x0000000182F1C870-0x0000000182F1C890
			public int interactionStartIndex { get => default; set {} } // 0x00000001839C1E90-0x00000001839C1EB0 0x0000000182F1BFB0-0x0000000182F1BFD0
			public int interactionCount { get => default; set {} } // 0x0000000183D559E0-0x0000000183D559F0 0x0000000182F1BFD0-0x0000000182F1BFF0
			public int processorStartIndex { get => default; set {} } // 0x0000000189BAFE94-0x0000000189BAFEAC 0x0000000182F1BFF0-0x0000000182F1C010
			public int processorCount { get => default; set {} } // 0x0000000183D559C0-0x0000000183D559D0 0x0000000182F1C010-0x0000000182F1C030
			public int actionIndex { get => default; set {} } // 0x00000001822BDCE0-0x00000001822BDD00 0x0000000182F1BEA0-0x0000000182F1BED0
			public int mapIndex { get => default; set {} } // 0x0000000183D559B0-0x0000000183D559C0 0x0000000182F1C030-0x0000000182F1C050
			public int compositeOrCompositeBindingIndex { get => default; set {} } // 0x0000000183C907D0-0x0000000183C907F0 0x0000000182F1BED0-0x0000000182F1BF00
			public int triggerEventIdForComposite { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
			public double pressTime { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000183D4E410-0x0000000183D4E420
			public Flags flags { get => default; set {} } // 0x0000000183D55A00-0x0000000183D55A10 0x0000000183D5DDF0-0x0000000183D5DE00
			public bool chainsWithNext { get => default; set {} } // 0x0000000189BAFE6C-0x0000000189BAFE74 0x0000000189BAFEAC-0x0000000189BAFED0
			public bool isEndOfChain { get => default; set {} } // 0x0000000189BAFE74-0x0000000189BAFE80 0x0000000189BAFED0-0x0000000189BAFEF4
			public bool isPartOfChain { get => default; } // 0x0000000189BAFE80-0x0000000189BAFE94 
			public bool isComposite { get => default; set {} } // 0x0000000182F1BDF0-0x0000000182F1BE00 0x0000000182F1BF00-0x0000000182F1BF30
			public bool isPartOfComposite { get => default; set {} } // 0x00000001822BEF40-0x00000001822BEF50 0x0000000182F1BF30-0x0000000182F1BF60
			public bool initialStateCheckPending { get => default; set {} } // 0x0000000182EB7B30-0x0000000182EB7B40 0x0000000182EB8C40-0x0000000182EB8C70
			public bool wantsInitialStateCheck { get => default; set {} } // 0x0000000182EB8810-0x0000000182EB8820 0x0000000182F1BF60-0x0000000182F1BF90
			public int partIndex { get => default; set {} } // 0x0000000183D55A10-0x0000000183D55A20 0x0000000182F1C070-0x0000000182F1C080
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 44098
			{
				ChainsWithNext = 1,
				EndOfChain = 2,
				Composite = 4,
				PartOfComposite = 8,
				InitialStateCheckPending = 16,
				WantsInitialStateCheck = 32
			}
		}
	
		public struct TriggerState // TypeDefIndex: 44101
		{
			// Fields
			public const int kMaxNumMaps = 255; // Metadata: 0x01FB639E
			public const int kMaxNumControls = 65535; // Metadata: 0x01FB63A0
			public const int kMaxNumBindings = 65535; // Metadata: 0x01FB63A4
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
			public InputActionPhase phase { get => default; set {} } // 0x0000000183D51020-0x0000000183D51030 0x0000000183D4F9D0-0x0000000183D4F9E0
			public bool isDisabled { get => default; } // 0x00000001822BDD50-0x00000001822BDD60 
			public bool isWaiting { get => default; } // 0x00000001897EBCC8-0x00000001897EBCD0 
			public bool isStarted { get => default; } // 0x00000001897EBCD0-0x00000001897EBCD8 
			public bool isPerformed { get => default; } // 0x0000000189BBAF2C-0x0000000189BBAF34 
			public bool isCanceled { get => default; } // 0x0000000189BBAF24-0x0000000189BBAF2C 
			public double time { get => default; set {} } // 0x0000000183D676E0-0x0000000183D676F0 0x0000000183D698E0-0x0000000183D698F0
			public double startTime { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000183D4E410-0x0000000183D4E420
			public float magnitude { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D76C60-0x0000000183D76C70
			public bool haveMagnitude { get => default; } // 0x0000000189BBAF1C-0x0000000189BBAF24 
			public int mapIndex { get => default; set {} } // 0x0000000183D559C0-0x0000000183D559D0 0x00000001822BEF90-0x00000001822BEFB0
			public int controlIndex { get => default; set {} } // 0x00000001822BECE0-0x00000001822BED00 0x00000001822BF010-0x00000001822BF040
			public int bindingIndex { get => default; set {} } // 0x0000000183D73F70-0x0000000183D73F80 0x00000001822BEF70-0x00000001822BEF90
			public int interactionIndex { get => default; set {} } // 0x00000001822BDCC0-0x00000001822BDCE0 0x00000001822BEF50-0x00000001822BEF70
			public uint lastPerformedInUpdate { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
			public uint lastCompletedInUpdate { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
			public uint lastCanceledInUpdate { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
			public uint pressedInUpdate { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
			public uint releasedInUpdate { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
			public bool isPassThrough { get => default; set {} } // 0x00000001822BDD40-0x00000001822BDD50 0x00000001822BEFE0-0x00000001822BF010
			public bool isButton { get => default; set {} } // 0x00000001822BEF30-0x00000001822BEF40 0x00000001822BEFB0-0x00000001822BEFE0
			public bool isPressed { get => default; set {} } // 0x00000001822BED00-0x00000001822BED10 0x0000000182CAFC60-0x0000000182CAFC90
			public bool mayNeedConflictResolution { get => default; set {} } // 0x00000001822BF0B0-0x00000001822BF0C0 0x0000000183B45DA0-0x0000000183B45DD0
			public bool hasMultipleConcurrentActuations { get => default; set {} } // 0x0000000189BBAF14-0x0000000189BBAF1C 0x0000000182CAFC40-0x0000000182CAFC60
			public bool inProcessing { get => default; set {} } // 0x00000001822BDD30-0x00000001822BDD40 0x00000001822BDD60-0x00000001822BDD90
			public Flags flags { get => default; set {} } // 0x0000000183D559E0-0x0000000183D559F0 0x0000000183D5BC30-0x0000000183D5BC40
	
			// Nested types
			[Flags]
			public enum Flags // TypeDefIndex: 44100
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
	
		public struct ActionMapIndices // TypeDefIndex: 44102
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
	
		public struct UnmanagedMemory : IDisposable // TypeDefIndex: 44103
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
			public bool isAllocated { get => default; } // 0x00000001822B9B50-0x00000001822B9B60 
			public int sizeInBytes { get => default; } // 0x000000018377A1D0-0x000000018377A210 
	
			// Methods
			public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) {} // 0x000000018377A050-0x000000018377A1D0
			public void Dispose() {} // 0x0000000183A410A0-0x0000000183A41100
			public void CopyDataFrom(UnmanagedMemory memory) {} // 0x0000000183807AF0-0x0000000183807C40
			public UnmanagedMemory Clone() => default; // 0x0000000189BBB38C-0x0000000189BBB5E4
		}
	
		internal struct GlobalState // TypeDefIndex: 44104
		{
			// Fields
			internal InlinedArray<GCHandle> globalList; // 0x00
			internal CallbackArray<Action<object, InputActionChange>> onActionChange; // 0x18
			internal CallbackArray<Action<object>> onActionControlsChanged; // 0x68
		}
	
		// Constructors
		public InputActionState() {} // 0x000000018350B670-0x000000018350B680
		static InputActionState() {} // 0x0000000183B1DAC0-0x0000000183B1DC10
	
		// Methods
		public void Initialize(InputBindingResolver resolver) {} // 0x00000001834B1830-0x00000001834B18D0
		private void ComputeControlGroupingIfNecessary() {} // 0x00000001834B1C00-0x00000001834B1D60
		public void ClaimDataFrom(InputBindingResolver resolver) {} // 0x00000001834B1A20-0x00000001834B1B00
		~InputActionState() {} // 0x0000000189BB7598-0x0000000189BB760C
		public void Dispose() {} // 0x0000000189BB7354-0x0000000189BB7360
		private void Destroy(bool isFinalizing = false /* Metadata: 0x01FB6386 */) {} // 0x0000000189BB6BD8-0x0000000189BB6D54
		public InputActionState Clone() => default; // 0x0000000189BB68BC-0x0000000189BB6A5C
		object ICloneable.Clone() => default; // 0x0000000189BB9CB4-0x0000000189BB9CBC
		private bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000182CB0B60-0x0000000182CB0CA0
		private bool CanUseDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BB61F0-0x0000000189BB63A0
		public bool HasEnabledActions() => default; // 0x0000000189BB7D24-0x0000000189BB7D74
		private void FinishBindingCompositeSetups() {} // 0x0000000182F1BCF0-0x0000000182F1BDF0
		internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions) {} // 0x0000000189BB7DD4-0x0000000189BB8298
		public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve) {} // 0x00000001834B17D0-0x00000001834B1830
		private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve) {} // 0x0000000189BB8F34-0x0000000189BB9730
		private bool IsActiveControl(int bindingIndex, int controlIndex) => default; // 0x0000000182EB7B40-0x0000000182EB7BD0
		private int FindControlIndexOnBinding(int bindingIndex, InputControl control) => default; // 0x0000000189BB7860-0x0000000189BB78CC
		private void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000182CAFC90-0x0000000182CAFEC0
		private bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex) => default; // 0x0000000182CAFEC0-0x0000000182CAFFC0
		public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting /* Metadata: 0x01FB6387 */, bool hardReset = false /* Metadata: 0x01FB6388 */) {} // 0x0000000182CAFAE0-0x0000000182CAFBE0
		public ref TriggerState FetchActionState(InputAction action) => ref _refReturnTypeForFetchActionState; // 0x0000000182EB9A10-0x0000000182EB9A40
		private ref TriggerState _refReturnTypeForFetchActionState; // Dummy field
		public ActionMapIndices FetchMapIndices(InputActionMap map) => default; // 0x0000000183D22E90-0x0000000183D22EE0
		public void EnableAllActions(InputActionMap map) {} // 0x0000000189BB7360-0x0000000189BB745C
		private void EnableControls(InputActionMap map) {} // 0x0000000189BB745C-0x0000000189BB74BC
		public void EnableSingleAction(InputAction action) {} // 0x0000000182EB8F80-0x0000000182EB9030
		private void EnableControls(InputAction action) {} // 0x0000000182EB8D90-0x0000000182EB8E90
		public void DisableAllActions(InputActionMap map) {} // 0x0000000189BB6E8C-0x0000000189BB7020
		public void DisableControls(InputActionMap map) {} // 0x0000000189BB7260-0x0000000189BB72C0
		public void DisableSingleAction(InputAction action) {} // 0x0000000189BB72C0-0x0000000189BB7354
		private void DisableControls(InputAction action) {} // 0x0000000189BB7020-0x0000000189BB7100
		private void EnableControls(int mapIndex, int controlStartIndex, int numControls) {} // 0x0000000182EB8660-0x0000000182EB8810
		private void DisableControls(int mapIndex, int controlStartIndex, int numControls) {} // 0x0000000189BB7100-0x0000000189BB7260
		public void SetInitialStateCheckPending(int actionIndex, bool value = true /* Metadata: 0x01FB6389 */) {} // 0x0000000189BB9968-0x0000000189BB9A28
		private unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) {} // 0x0000000182EB8BF0-0x0000000182EB8C40
		private bool IsControlEnabled(int controlIndex) => default; // 0x0000000182EB8860-0x0000000182EB88A0
		private void SetControlEnabled(int controlIndex, bool state) {} // 0x0000000182EB8820-0x0000000182EB8860
		private void HookOnBeforeUpdate() {} // 0x0000000182EB8E90-0x0000000182EB8F80
		private void UnhookOnBeforeUpdate() {} // 0x0000000182EB76D0-0x0000000182EB7750
		private void OnBeforeInitialUpdate() {} // 0x0000000182EB7980-0x0000000182EB7B30
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex) {} // 0x00000001822BD240-0x00000001822BD290
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex) {} // 0x0000000189BB9CBC-0x0000000189BB9D04
		private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) => default; // 0x0000000183D76C20-0x0000000183D76C60
		private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) {
			mapIndex = default;
			controlIndex = default;
			bindingIndex = default;
		} // 0x0000000183D76BF0-0x0000000183D76C20
		internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex) => default; // 0x0000000183D76BE0-0x0000000183D76BF0
		private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr) {} // 0x00000001822BDD90-0x00000001822BEA60
		private unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) {} // 0x00000001822BEAC0-0x00000001822BECA0
		private static unsafe bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) => default; // 0x0000000189BB9A6C-0x0000000189BB9A8C
		private bool IsConflictingInput(ref TriggerState trigger, int actionIndex) => default; // 0x00000001822BF040-0x00000001822BF0B0
		private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount) {
			bindingCount = default;
			return default;
		} // 0x0000000183D76BA0-0x0000000183D76BD0
		private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex) {} // 0x00000001822BD290-0x00000001822BD370
		private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount) {} // 0x0000000189BB8298-0x0000000189BB83D4
		private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) {} // 0x0000000189BB83D4-0x0000000189BB8560
		internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger) {} // 0x0000000189BB9A28-0x0000000189BB9A6C
		internal void StartTimeout(float seconds, ref TriggerState trigger) {} // 0x0000000189BB9A8C-0x0000000189BB9BF0
		private void StopTimeout(int interactionIndex) {} // 0x0000000189BB9BF0-0x0000000189BB9CB4
		internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting /* Metadata: 0x01FB638A */, InputActionPhase phaseAfterCanceled = InputActionPhase.Waiting /* Metadata: 0x01FB638B */, bool processNextInteractionOnCancel = true /* Metadata: 0x01FB638C */) {} // 0x0000000189BB63A0-0x0000000189BB68BC
		private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting /* Metadata: 0x01FB638D */) => default; // 0x00000001822BDA40-0x00000001822BDCC0
		private unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false /* Metadata: 0x01FB638E */) {} // 0x00000001822BD740-0x00000001822BDA40
		private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName) {} // 0x00000001822BD370-0x00000001822BD670
		private object GetActionOrNoneString(ref TriggerState trigger) => default; // 0x0000000189BB7908-0x0000000189BB7960
		internal InputAction GetActionOrNull(int bindingIndex) => default; // 0x00000001822BD6A0-0x00000001822BD740
		internal InputAction GetActionOrNull(ref TriggerState trigger) => default; // 0x0000000189BB7960-0x0000000189BB7A00
		internal InputControl GetControl(ref TriggerState trigger) => default; // 0x0000000189BB7B6C-0x0000000189BB7BA8
		private IInputInteraction GetInteractionOrNull(ref TriggerState trigger) => default; // 0x0000000189BB7BA8-0x0000000189BB7C04
		internal int GetBindingIndexInMap(int bindingIndex) => default; // 0x0000000189BB7A00-0x0000000189BB7A44
		internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) => default; // 0x0000000189BB7A44-0x0000000189BB7A7C
		internal ref BindingState GetBindingState(int bindingIndex) => ref _refReturnTypeForGetBindingState; // 0x0000000183D76BD0-0x0000000183D76BE0
		private ref BindingState _refReturnTypeForGetBindingState; // Dummy field
		internal ref InputBinding GetBinding(int bindingIndex) => ref _refReturnTypeForGetBinding; // 0x0000000189BB7A7C-0x0000000189BB7AF4
		private ref InputBinding _refReturnTypeForGetBinding; // Dummy field
		internal InputActionMap GetActionMap(int bindingIndex) => default; // 0x0000000189BB78CC-0x0000000189BB7908
		private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) {} // 0x0000000189BB8DC4-0x0000000189BB8E7C
		private void ResetInteractionState(int interactionIndex) {} // 0x0000000189BB8E7C-0x0000000189BB8F34
		internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) => default; // 0x0000000189BB7C04-0x0000000189BB7C94
		internal System.Type GetValueType(int bindingIndex, int controlIndex) => default; // 0x0000000189BB7C94-0x0000000189BB7D24
		internal static bool IsActuated(ref TriggerState trigger, float threshold = 0f /* Metadata: 0x01FB638F */) => default; // 0x0000000189BB7D74-0x0000000189BB7DD4
		internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false /* Metadata: 0x01FB6393 */) {} // 0x0000000189BB896C-0x0000000189BB8B2C
		internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x01FB6394 */)
			where TValue : struct => default;
		internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null)
			where TValue : struct => default;
		public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) => default; // 0x0000000189BB74BC-0x0000000189BB7598
		internal double GetCompositePartPressTime(int bindingIndex, int partNumber) => default; // 0x0000000189BB7AF4-0x0000000189BB7B6C
		internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> {
			controlIndex = default;
			return default;
		}
		internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize) => default; // 0x0000000189BB8670-0x0000000189BB87A4
		internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) => default; // 0x0000000189BB8560-0x0000000189BB8670
		internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false /* Metadata: 0x01FB6395 */) => default; // 0x0000000189BB87A4-0x0000000189BB896C
		internal bool ReadValueAsButton(int bindingIndex, int controlIndex) => default; // 0x0000000182EB6C20-0x0000000182EB6D20
		internal static ISavedState SaveAndResetState() => default; // 0x0000000189BB9730-0x0000000189BB9968
		private void AddToGlobalList() {} // 0x00000001834B18D0-0x00000001834B1960
		private void RemoveMapFromGlobalList() {} // 0x0000000189BB8B2C-0x0000000189BB8C50
		private static void CompactGlobalList() {} // 0x00000001834B1960-0x00000001834B1A20
		internal void NotifyListenersOfActionChange(InputActionChange change) {} // 0x00000001834B1B00-0x00000001834B1C00
		internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) {} // 0x0000000182EB8C70-0x0000000182EB8D90
		private static void ResetGlobals() {} // 0x0000000189BB8C50-0x0000000189BB8DC4
		internal static int FindAllEnabledActions(List<InputAction> result) => default; // 0x0000000189BB760C-0x0000000189BB7860
		internal static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000182CB0DB0-0x0000000182CB0F60
		internal static void DeferredResolutionOfBindings() {} // 0x000000018289C920-0x000000018289CC90
		internal static void DisableAllActions() {} // 0x0000000189BB6D54-0x0000000189BB6E8C
		internal static void DestroyAllActionMapStates() {} // 0x0000000189BB6A5C-0x0000000189BB6BD8
	}

	public enum InputActionType // TypeDefIndex: 44107
	{
		Value = 0,
		Button = 1,
		PassThrough = 2
	}

	[Serializable]
	public struct InputBinding : IEquatable<InputBinding> // TypeDefIndex: 44112
	{
		// Fields
		public const char Separator = ';'; // Metadata: 0x01FB63B6
		internal const string kSeparatorString = ";"; // Metadata: 0x01FB63B8
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
		public string name { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Guid id { get => default; set {} } // 0x0000000189BBAC8C-0x0000000189BBACD8 0x0000000189BBADF8-0x0000000189BBAE24
		public string path { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string overridePath { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public string interactions { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string overrideInteractions { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public string processors { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string overrideProcessors { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public string groups { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string action { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public bool isComposite { get => default; set {} } // 0x0000000182F1C060-0x0000000182F1C070 0x0000000189BBAE24-0x0000000189BBAE40
		public bool isPartOfComposite { get => default; set {} } // 0x0000000182F1C890-0x0000000182F1C8A0 0x0000000189BBAE40-0x0000000189BBAE5C
		public bool hasOverrides { get => default; } // 0x0000000189BBAC70-0x0000000189BBAC8C 
		public string effectivePath { get => default; } // 0x0000000182F1C850-0x0000000182F1C860 
		public string effectiveInteractions { get => default; } // 0x0000000182F1BE00-0x0000000182F1BEA0 
		public string effectiveProcessors { get => default; } // 0x0000000182F1C860-0x0000000182F1C870 
		internal bool isEmpty { get => default; } // 0x0000000189BBACD8-0x0000000189BBAD1C 
	
		// Nested types
		[Flags]
		public enum DisplayStringOptions // TypeDefIndex: 44108
		{
			DontUseShortDisplayNames = 1,
			DontOmitDevice = 2,
			DontIncludeInteractions = 4,
			IgnoreBindingOverrides = 8
		}
	
		[Flags]
		internal enum MatchOptions // TypeDefIndex: 44109
		{
			EmptyGroupMatchesAny = 1
		}
	
		[Flags]
		internal enum Flags // TypeDefIndex: 44110
		{
			None = 0,
			Composite = 4,
			PartOfComposite = 8
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
		} // 0x0000000189BBABCC-0x0000000189BBAC70
	
		// Methods
		public string GetNameOfComposite() => default; // 0x0000000189BBA418-0x0000000189BBA448
		internal void GenerateId() {} // 0x0000000189BBA2B8-0x0000000189BBA2FC
		internal void RemoveOverrides() {} // 0x0000000189BBA740-0x0000000189BBA778
		public static InputBinding MaskByGroup(string group) => default; // 0x0000000189BBA448-0x0000000189BBA480
		public static InputBinding MaskByGroups(params string[] groups) => default; // 0x0000000189BBA480-0x0000000189BBA5DC
		public bool Equals(InputBinding other) => default; // 0x0000000189BBA1D0-0x0000000189BBA2B8
		public override bool Equals(object obj) => default; // 0x0000000189BBA12C-0x0000000189BBA1D0
		public static bool operator ==(InputBinding left, InputBinding right) => default; // 0x0000000189BBAD1C-0x0000000189BBAD6C
		public static bool operator !=(InputBinding left, InputBinding right) => default; // 0x0000000189BBAD6C-0x0000000189BBADF8
		public override int GetHashCode() => default; // 0x0000000189BBA2FC-0x0000000189BBA418
		public override string ToString() => default; // 0x0000000189BBAA84-0x0000000189BBAB78
		public string ToDisplayString(DisplayStringOptions options =  /* Metadata: 0x01FB63B3 */, InputControl control = null) => default; // 0x0000000189BBAA50-0x0000000189BBAA84
		public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options =  /* Metadata: 0x01FB63B4 */, InputControl control = null) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x0000000189BBA778-0x0000000189BBAA50
		internal bool TriggersAction(InputAction action) => default; // 0x0000000189BBAB78-0x0000000189BBABCC
		public bool Matches(InputBinding binding) => default; // 0x0000000189BBA5DC-0x0000000189BBA5F0
		internal bool Matches(ref InputBinding binding, MatchOptions options =  /* Metadata: 0x01FB63B5 */) => default; // 0x0000000189BBA5F0-0x0000000189BBA740
	}

	public abstract class InputBindingComposite // TypeDefIndex: 44114
	{
		// Fields
		internal static TypeTable s_Composites; // 0x00
	
		// Properties
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
	
		// Constructors
		protected InputBindingComposite() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);
		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);
		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000183D751A0-0x0000000183D751B0
		protected virtual void FinishSetup(ref InputBindingCompositeContext context) {} // 0x000000018350B670-0x000000018350B680
		internal void CallFinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000189BB9D04-0x0000000189BB9D40
		internal static System.Type GetValueType(string composite) => default; // 0x0000000189BBA020-0x0000000189BBA12C
		public static string GetExpectedControlLayoutName(string composite, string part) => default; // 0x0000000189BB9E2C-0x0000000189BB9FB0
		[IteratorStateMachine(typeof(_GetPartNames_d__12))]
		internal static IEnumerable<string> GetPartNames(string composite) => default; // 0x0000000189BB9FB0-0x0000000189BBA020
		internal static string GetDisplayFormatString(string composite) => default; // 0x0000000189BB9D40-0x0000000189BB9E2C
	}

	public abstract class InputBindingComposite<TValue> : InputBindingComposite // TypeDefIndex: 44115
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

	public struct InputBindingCompositeContext // TypeDefIndex: 44119
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal int m_BindingIndex; // 0x08
	
		// Properties
		public IEnumerable<PartBinding> controls { [IteratorStateMachine(typeof(_get_controls_d__2))] get => default; } // 0x0000000189BD12D4-0x0000000189BD1348 
	
		// Nested types
		public struct PartBinding // TypeDefIndex: 44116
		{
			// Properties
			public int part { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
			public InputControl control { [IsReadOnly] get; set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		}
	
		private struct DefaultComparer<TValue> : IComparer<TValue> // TypeDefIndex: 44117
			where TValue : IComparable<TValue>
		{
			// Methods
			public int Compare(TValue x, TValue y) => default;
		}
	
		// Methods
		public float EvaluateMagnitude(int partNumber) => default; // 0x0000000189BD119C-0x0000000189BD11C8
		public TValue ReadValue<TValue>(int partNumber)
			where TValue : struct, IComparable<TValue> => default;
		public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl)
			where TValue : struct, IComparable<TValue> {
			sourceControl = default;
			return default;
		}
		public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> => default;
		public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, TComparer comparer = default)
			where TValue : struct
			where TComparer : IComparer<TValue> {
			sourceControl = default;
			return default;
		}
		public bool ReadValueAsButton(int partNumber) => default; // 0x0000000189BD11F4-0x0000000189BD127C
		public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize) {} // 0x0000000189BD12A8-0x0000000189BD12D4
		public object ReadValueAsObject(int partNumber) => default; // 0x0000000189BD127C-0x0000000189BD12A8
		public double GetPressTime(int partNumber) => default; // 0x0000000189BD11C8-0x0000000189BD11F4
	}

	internal struct InputBindingResolver : IDisposable // TypeDefIndex: 44120
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
		public int totalMapCount { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public int totalActionCount { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public int totalBindingCount { get => default; } // 0x0000000183D4EE00-0x0000000183D4EE10 
		public int totalControlCount { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
	
		// Methods
		public void Dispose() {} // 0x0000000189BD1348-0x0000000189BD1354
		public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) {} // 0x0000000189BD1354-0x0000000189BD14C8
		public void AddActionMap(InputActionMap actionMap) {} // 0x0000000182F1C8A0-0x0000000182F1EBD0
		private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) => default;
		private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) => default; // 0x000000018235DE90-0x000000018235E020
		private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) {} // 0x000000018235E310-0x000000018235E850
		private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) => default; // 0x0000000183625F70-0x00000001836260E0
	}

	[Serializable]
	public struct InputControlScheme : IEquatable<InputControlScheme> // TypeDefIndex: 44129
	{
		// Fields
		[SerializeField]
		internal string m_Name; // 0x00
		[SerializeField]
		internal string m_BindingGroup; // 0x08
		[SerializeField]
		internal DeviceRequirement[] m_DeviceRequirements; // 0x10
	
		// Properties
		public string name { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public string bindingGroup { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public ReadOnlyArray<DeviceRequirement> deviceRequirements { get => default; } // 0x0000000189BD5670-0x0000000189BD56C4 
	
		// Nested types
		public struct MatchResult : IEnumerable<MatchResult.Match>, IDisposable // TypeDefIndex: 44124
		{
			// Fields
			internal Result m_Result; // 0x00
			internal float m_Score; // 0x04
			internal InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices; // 0x08
			internal InputControlList<InputControl> m_Controls; // 0x28
			internal DeviceRequirement[] m_Requirements; // 0x48
	
			// Properties
			public float score { get => default; } // 0x0000000183D58BC0-0x0000000183D58BD0 
			public bool isSuccessfulMatch { get => default; } // 0x0000000188870E90-0x0000000188870E98 
			public bool hasMissingRequiredDevices { get => default; } // 0x0000000185CC6BD8-0x0000000185CC6BE0 
			public bool hasMissingOptionalDevices { get => default; } // 0x0000000185CC6BC8-0x0000000185CC6BD0 
			public InputControlList<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x0000000189BDC914-0x0000000189BDCA38 
			public Match this[int index] { get => default; } // 0x0000000189BDC85C-0x0000000189BDC914 
	
			// Nested types
			internal enum Result // TypeDefIndex: 44121
			{
				AllSatisfied = 0,
				MissingRequired = 1,
				MissingOptional = 2
			}
	
			public struct Match // TypeDefIndex: 44122
			{
				// Fields
				internal int m_RequirementIndex; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public InputControl control { get => default; } // 0x0000000189BDCA38-0x0000000189BDCA74 
				public UnityEngine.InputSystem.InputDevice device { get => default; } // 0x0000000189BDCA74-0x0000000189BDCA90 
				public int requirementIndex { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
				public DeviceRequirement requirement { get => default; } // 0x0000000189BDCAB4-0x0000000189BDCAE4 
				public bool isOptional { get => default; } // 0x0000000189BDCA90-0x0000000189BDCAB4 
			}
	
			private struct Enumerator : IEnumerator<Match> // TypeDefIndex: 44123
			{
				// Fields
				internal int m_Index; // 0x00
				internal DeviceRequirement[] m_Requirements; // 0x08
				internal InputControlList<InputControl> m_Controls; // 0x10
	
				// Properties
				public Match Current { get => default; } // 0x0000000189BD08E4-0x0000000189BD099C 
				object IEnumerator.Current { get => default; } // 0x0000000189BD0878-0x0000000189BD08E4 
	
				// Methods
				public bool MoveNext() => default; // 0x0000000189BD085C-0x0000000189BD0878
				public void Reset() {} // 0x0000000183D77120-0x0000000183D77130
				public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Methods
			public IEnumerator<Match> GetEnumerator() => default; // 0x0000000189BDC7C0-0x0000000189BDC854
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BDC854-0x0000000189BDC85C
			public void Dispose() {} // 0x0000000189BDC768-0x0000000189BDC7C0
		}
	
		[Serializable]
		public struct DeviceRequirement : IEquatable<DeviceRequirement> // TypeDefIndex: 44126
		{
			// Fields
			[SerializeField]
			internal string m_ControlPath; // 0x00
			[SerializeField]
			internal Flags m_Flags; // 0x08
	
			// Properties
			public string controlPath { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
			public bool isOptional { get => default; set {} } // 0x0000000189BD07C0-0x0000000189BD07C8 0x0000000189BD0840-0x0000000189BD085C
			public bool isAND { get => default; set {} } // 0x0000000189BD07B0-0x0000000189BD07B8 0x0000000189BD0808-0x0000000189BD0824
			public bool isOR { get => default; set {} } // 0x0000000189BD07B8-0x0000000189BD07C0 0x0000000189BD0824-0x0000000189BD0840
	
			// Nested types
			[Flags]
			internal enum Flags // TypeDefIndex: 44125
			{
				None = 0,
				Optional = 1,
				Or = 2
			}
	
			// Methods
			public override string ToString() => default; // 0x0000000189BD0718-0x0000000189BD07B0
			public bool Equals(DeviceRequirement other) => default; // 0x0000000189BD05A8-0x0000000189BD0604
			public override bool Equals(object obj) => default; // 0x0000000189BD0604-0x0000000189BD0674
			public override int GetHashCode() => default; // 0x0000000189BD0674-0x0000000189BD0718
			public static bool operator ==(DeviceRequirement left, DeviceRequirement right) => default; // 0x0000000189BD07C8-0x0000000189BD07E8
			public static bool operator !=(DeviceRequirement left, DeviceRequirement right) => default; // 0x0000000189BD07E8-0x0000000189BD0808
		}
	
		[Serializable]
		internal struct SchemeJson // TypeDefIndex: 44128
		{
			// Fields
			public string name; // 0x00
			public string bindingGroup; // 0x08
			public DeviceJson[] devices; // 0x10
	
			// Nested types
			[Serializable]
			public struct DeviceJson // TypeDefIndex: 44127
			{
				// Fields
				public string devicePath; // 0x00
				public bool isOptional; // 0x08
				public bool isOR; // 0x09
	
				// Methods
				public DeviceRequirement ToDeviceEntry() => default; // 0x0000000189BD055C-0x0000000189BD05A8
				public static DeviceJson From(DeviceRequirement requirement) => default; // 0x0000000189BD0520-0x0000000189BD055C
			}
	
			// Methods
			public InputControlScheme ToScheme() => default; // 0x0000000189BDDED4-0x0000000189BDE024
			public static SchemeJson ToJson(InputControlScheme scheme) => default; // 0x0000000189BDDC38-0x0000000189BDDDD4
			public static SchemeJson[] ToJson(InputControlScheme[] schemes) => default; // 0x0000000189BDDDD4-0x0000000189BDDED4
			public static InputControlScheme[] ToSchemes(SchemeJson[] schemes) => default; // 0x0000000189BDE024-0x0000000189BDE0FC
		}
	
		// Constructors
		public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null) : this() {
			m_Name = default;
			m_BindingGroup = default;
			m_DeviceRequirements = default;
		} // 0x0000000189BD5554-0x0000000189BD5670
	
		// Methods
		internal void SetNameAndBindingGroup(string name, string bindingGroup = null) {} // 0x0000000189BD528C-0x0000000189BD5340
		public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false /* Metadata: 0x01FB63C2 */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme> => default;
		public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false /* Metadata: 0x01FB63C3 */)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice>
			where TSchemes : IEnumerable<InputControlScheme> {
			controlScheme = default;
			matchResult = default;
			return default;
		}
		public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
			where TSchemes : IEnumerable<InputControlScheme> => default;
		public bool SupportsDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BD5340-0x0000000189BD53FC
		public MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice = null)
			where TDevices : IReadOnlyList<UnityEngine.InputSystem.InputDevice> => default;
		public bool Equals(InputControlScheme other) => default; // 0x0000000189BD4FC8-0x0000000189BD5190
		public override bool Equals(object obj) => default; // 0x0000000189BD5190-0x0000000189BD5208
		public override int GetHashCode() => default; // 0x0000000189BD5208-0x0000000189BD528C
		public override string ToString() => default; // 0x0000000189BD53FC-0x0000000189BD5554
		public static bool operator ==(InputControlScheme left, InputControlScheme right) => default; // 0x0000000189BD56C4-0x0000000189BD56F0
		public static bool operator !=(InputControlScheme left, InputControlScheme right) => default; // 0x0000000189BD56F0-0x0000000189BD571C
	}

	public struct InputInteractionContext // TypeDefIndex: 44131
	{
		// Fields
		internal InputActionState m_State; // 0x00
		internal Flags m_Flags; // 0x08
		internal InputActionState.TriggerState m_TriggerState; // 0x10
	
		// Properties
		public InputAction action { get => default; } // 0x0000000189BD8B88-0x0000000189BD8BB0 
		public InputControl control { get => default; } // 0x0000000189BD8BBC-0x0000000189BD8BE4 
		public InputActionPhase phase { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public double time { get => default; } // 0x0000000183D4EBD0-0x0000000183D4EBE0 
		public double startTime { get => default; } // 0x0000000183D4F1C0-0x0000000183D4F1D0 
		public bool timerHasExpired { get => default; internal set {} } // 0x0000000189BD07B8-0x0000000189BD07C0 0x0000000189BD0824-0x0000000189BD0840
		public bool isWaiting { get => default; } // 0x0000000189BD8BF8-0x0000000189BD8C00 
		public bool isStarted { get => default; } // 0x0000000189BD8BF0-0x0000000189BD8BF8 
		internal int mapIndex { get => default; } // 0x0000000183D519E0-0x0000000183D519F0 
		internal int controlIndex { get => default; } // 0x0000000189BD8BB0-0x0000000189BD8BBC 
		internal int bindingIndex { get => default; } // 0x0000000183D771C0-0x0000000183D771D0 
		internal int interactionIndex { get => default; } // 0x0000000189BD8BE4-0x0000000189BD8BF0 
	
		// Nested types
		[Flags]
		internal enum Flags // TypeDefIndex: 44130
		{
			TimerHasExpired = 2
		}
	
		// Methods
		public float ComputeMagnitude() => default; // 0x0000000183D4F3A0-0x0000000183D4F3B0
		public bool ControlIsActuated(float threshold = 0f /* Metadata: 0x01FB63CA */) => default; // 0x0000000189BD88D0-0x0000000189BD892C
		public void Started() {} // 0x0000000189BD8AF4-0x0000000189BD8B40
		public void Performed() {} // 0x0000000189BD89C4-0x0000000189BD8A10
		public void PerformedAndStayStarted() {} // 0x0000000189BD8978-0x0000000189BD89C4
		public void PerformedAndStayPerformed() {} // 0x0000000189BD892C-0x0000000189BD8978
		public void Canceled() {} // 0x0000000189BD8884-0x0000000189BD88D0
		public void Waiting() {} // 0x0000000189BD8B40-0x0000000189BD8B88
		public void SetTimeout(float seconds) {} // 0x0000000189BD8A10-0x0000000189BD8A38
		public void SetTotalTimeoutCompletionTime(float seconds) {} // 0x0000000189BD8A38-0x0000000189BD8AF4
		public TValue ReadValue<TValue>()
			where TValue : struct => default;
	}

	public static class InputSystem // TypeDefIndex: 44137
	{
		// Fields
		internal const string kAssemblyVersion = "1.14.0"; // Metadata: 0x01FB63F1
		internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14"; // Metadata: 0x01FB63F8
		private static readonly ProfilerMarker k_InputResetMarker; // 0x00
		internal const float scrollWheelDeltaPerTick = 1f; // Metadata: 0x01FB6435
		internal static InputManager s_Manager; // 0x08
		internal static InputRemoting s_Remote; // 0x10
	
		// Properties
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get; } // 0x0000000182CAB840-0x0000000182CAB8C0 
		public static ReadOnlyArray<UnityEngine.InputSystem.InputDevice> disconnectedDevices { get; } // 0x0000000189BDB808-0x0000000189BDB89C 
		public static float pollingFrequency { get; set; } // 0x0000000189BDBB90-0x0000000189BDBBF0 0x0000000189BDC520-0x0000000189BDC588
		internal static bool isProcessingEvents { get; } // 0x0000000189BDB89C-0x0000000189BDB900 
		public static InputEventListener onEvent { get; set; } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
		public static IObservable<InputControl> onAnyButtonPress { get; } // 0x0000000189BDB984-0x0000000189BDBB90 
		public static InputSettings settings { get; set; } // 0x00000001822BFAB0-0x00000001822BFB20 0x0000000189BDC63C-0x0000000189BDC768
		public static InputRemoting remoting { get; } // 0x0000000189BDBBF0-0x0000000189BDBC40 
		public static System.Version version { get; } // 0x0000000189BDBCA0-0x0000000189BDBD04 
		public static bool runInBackground { get; set; } // 0x0000000189BDBC40-0x0000000189BDBCA0 0x0000000189BDC588-0x0000000189BDC63C
		public static InputMetrics metrics { get; } // 0x0000000189BDB900-0x0000000189BDB984 
	
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
		private struct StateEventBuffer // TypeDefIndex: 44133
		{
			// Fields
			public StateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x01FB6439
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x19
		}
	
		private struct DeltaStateEventBuffer // TypeDefIndex: 44135
		{
			// Fields
			public DeltaStateEvent stateEvent; // 0x00
			public const int kMaxSize = 512; // Metadata: 0x01FB643B
			public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x1D
		}
	
		// Constructors
		static InputSystem() {} // 0x0000000182F17EB0-0x0000000182F17F20
	
		// Methods
		public static void RegisterLayout(System.Type type, string name = null, InputDeviceMatcher? matches = default) {} // 0x00000001822F8B30-0x00000001822F8CA0
		public static void RegisterLayout<T>(string name = null, InputDeviceMatcher? matches = default)
			where T : InputControl {}
		public static void RegisterLayout(string json, string name = null, InputDeviceMatcher? matches = default) {} // 0x0000000182F181E0-0x0000000182F182A0
		public static void RegisterLayoutOverride(string json, string name = null) {} // 0x0000000189BDA6E8-0x0000000189BDA75C
		public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) {} // 0x0000000189BDA678-0x0000000189BDA6E8
		public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher)
			where TDevice : UnityEngine.InputSystem.InputDevice {}
		public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, InputDeviceMatcher? matches = default) {} // 0x0000000189BDA4C8-0x0000000189BDA678
		public static void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new() {}
		public static void RemoveLayout(string name) {} // 0x0000000189BDAD08-0x0000000189BDAD68
		public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) => default; // 0x0000000189BDB05C-0x0000000189BDB0DC
		public static IEnumerable<string> ListLayouts() => default; // 0x0000000189BD9B88-0x0000000189BD9BE0
		public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout) => default; // 0x0000000189BD9AD0-0x0000000189BD9B88
		public static InputControlLayout LoadLayout(string name) => default; // 0x0000000189BD9C44-0x0000000189BD9D34
		public static InputControlLayout LoadLayout<TControl>()
			where TControl : InputControl => default;
		public static string GetNameOfBaseLayout(string layoutName) => default; // 0x0000000189BD95D0-0x0000000189BD96E4
		public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) => default; // 0x0000000189BD97C8-0x0000000189BD994C
		public static void RegisterProcessor(System.Type type, string name = null) {} // 0x0000000189BDA75C-0x0000000189BDAB88
		public static void RegisterProcessor<T>(string name = null) {}
		public static System.Type TryGetProcessor(string name) => default; // 0x0000000189BDB26C-0x0000000189BDB334
		public static IEnumerable<string> ListProcessors() => default; // 0x0000000189BD9BE0-0x0000000189BD9C44
		public static UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, string variants = null) => default; // 0x0000000189BD8EA4-0x0000000189BD8FBC
		public static TDevice AddDevice<TDevice>(string name = null)
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description) => default; // 0x0000000189BD8FBC-0x0000000189BD90BC
		public static void AddDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BD8DF0-0x0000000189BD8EA4
		public static void RemoveDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BDACA4-0x0000000189BDAD08
		public static void FlushDisconnectedDevices() {} // 0x0000000189BD9328-0x0000000189BD937C
		public static UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout) => default; // 0x0000000189BD9570-0x0000000189BD95D0
		public static TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static UnityEngine.InputSystem.InputDevice GetDevice(System.Type type) => default; // 0x0000000189BD937C-0x0000000189BD9570
		public static TDevice GetDevice<TDevice>(InternedString usage)
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static TDevice GetDevice<TDevice>(string usage)
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId) => default; // 0x00000001824AF510-0x00000001824AF690
		public static List<InputDeviceDescription> GetUnsupportedDevices() => default; // 0x0000000189BD96E4-0x0000000189BD9768
		public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) => default; // 0x0000000189BD9768-0x0000000189BD97C8
		public static void EnableDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000182CAA190-0x0000000182CAA210
		public static void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents = false /* Metadata: 0x01FB63CF */) {} // 0x0000000189BD90FC-0x0000000189BD9170
		public static bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BDB3A0-0x0000000189BDB484
		public static void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x01FB63D0 */) {} // 0x0000000189BDAD68-0x0000000189BDADE8
		[Obsolete("Use \'ResetDevice\' instead.", false)]
		public static bool TryResetDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BDB334-0x0000000189BDB3A0
		public static void PauseHaptics() {} // 0x0000000189BD9D34-0x0000000189BD9DF4
		public static void ResumeHaptics() {} // 0x0000000189BDAEA8-0x0000000189BDAF68
		public static void ResetHaptics() {} // 0x0000000189BDADE8-0x0000000189BDAEA8
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {} // 0x0000000189BDAF68-0x0000000189BDAFE0
		public static void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BDAFE0-0x0000000189BDB05C
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {} // 0x0000000189BD8D50-0x0000000189BD8DF0
		public static void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BD8CD4-0x0000000189BD8D50
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage) {} // 0x0000000189BDAC04-0x0000000189BDACA4
		public static void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BDAB88-0x0000000189BDAC04
		public static InputControl FindControl(string path) => default; // 0x0000000189BD9170-0x0000000189BD92B0
		public static InputControlList<InputControl> FindControls(string path) => default; // 0x0000000189BD92B0-0x0000000189BD9328
		public static InputControlList<TControl> FindControls<TControl>(string path)
			where TControl : InputControl => default;
		public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl => default;
		public static void QueueEvent(InputEventPtr eventPtr) {} // 0x0000000189BD9F94-0x0000000189BDA060
		public static void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo {}
		public static void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time = -1 /* Metadata: 0x01FB63D1 */)
			where TState : struct, IInputStateTypeInfo {}
		public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1 /* Metadata: 0x01FB63D9 */)
			where TDelta : struct {}
		public static void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time = -1 /* Metadata: 0x01FB63E1 */) {} // 0x0000000189BD9DF4-0x0000000189BD9F94
		public static void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time = -1 /* Metadata: 0x01FB63E9 */) {} // 0x0000000189BDA060-0x0000000189BDA218
		public static void Update() {} // 0x0000000189BDB484-0x0000000189BDB4D8
		internal static void Update(InputUpdateType updateType) {} // 0x0000000183A4FD10-0x0000000183A4FD80
		public static void RegisterInteraction(System.Type type, string name = null) {} // 0x0000000189BDA370-0x0000000189BDA4C8
		public static void RegisterInteraction<T>(string name = null) {}
		public static System.Type TryGetInteraction(string name) => default; // 0x0000000189BDB1A4-0x0000000189BDB26C
		public static IEnumerable<string> ListInteractions() => default; // 0x0000000189BD9A6C-0x0000000189BD9AD0
		public static void RegisterBindingComposite(System.Type type, string name) {} // 0x0000000189BDA218-0x0000000189BDA370
		public static void RegisterBindingComposite<T>(string name = null) {}
		public static System.Type TryGetBindingComposite(string name) => default; // 0x0000000189BDB0DC-0x0000000189BDB1A4
		public static void DisableAllEnabledActions() {} // 0x0000000189BD90BC-0x0000000189BD90FC
		public static List<InputAction> ListEnabledActions() => default; // 0x0000000189BD99E8-0x0000000189BD9A6C
		public static int ListEnabledActions(List<InputAction> actions) => default; // 0x0000000189BD994C-0x0000000189BD99E8
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RunInitializeInPlayer() {} // 0x0000000183D2B830-0x0000000183D2B890
		internal static void EnsureInitialized() {} // 0x000000018350B670-0x000000018350B680
		private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null) {} // 0x0000000182F17F20-0x0000000182F180D0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RunInitialUpdate() {} // 0x0000000183A4FC70-0x0000000183A4FD10
		private static void PerformDefaultPluginInitialization() {} // 0x0000000182F180D0-0x0000000182F18110
	}

	public static class CommonUsages // TypeDefIndex: 44138
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
		static CommonUsages() {} // 0x0000000189BCF1BC-0x0000000189BCFB7C
	}

	[DebuggerDisplay("{DebuggerDisplay(),nq}")]
	public abstract class InputControl // TypeDefIndex: 44140
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
		public string name { get; } // 0x000000018426F780-0x000000018426F7A0 
		public string displayName { get; protected set; } // 0x0000000182CAA330-0x0000000182CAA370 0x000000018388FF30-0x000000018388FF40
		public string shortDisplayName { get; protected set; } // 0x0000000189BD6494-0x0000000189BD64C8 0x0000000182692290-0x00000001826922A0
		public string path { get; } // 0x0000000189BD6438-0x0000000189BD6494 
		public string layout { get; } // 0x000000018426F750-0x000000018426F770 
		public string variants { get; } // 0x0000000189BD65AC-0x0000000189BD65CC 
		public UnityEngine.InputSystem.InputDevice device { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public InputControl parent { get; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public ReadOnlyArray<InputControl> children { get; } // 0x00000001822FC060-0x00000001822FC1D0 
		public ReadOnlyArray<InternedString> usages { get; } // 0x0000000189BD6534-0x0000000189BD65AC 
		public ReadOnlyArray<InternedString> aliases { get; } // 0x00000001822FC650-0x00000001822FC6D0 
		public InputStateBlock stateBlock { get; } // 0x00000001820B7B30-0x00000001820B7B40 
		public bool noisy { get; internal set; } // 0x00000001822BAED0-0x00000001822BAEE0 0x0000000189BD65CC-0x0000000189BD66A8
		public bool synthetic { get; internal set; } // 0x0000000189BD6528-0x0000000189BD6534 0x000000018313F0A0-0x000000018313F0C0
		public InputControl this[string path] { get => default; } // 0x0000000189BD6334-0x0000000189BD63C8 
		public abstract System.Type valueType { get; }
		public abstract int valueSizeInBytes { get; }
		public float magnitude { get; } // 0x000000018426F630-0x000000018426F6B4 
		protected internal unsafe void* currentStatePtr { get; } // 0x00000001822BAAE0-0x00000001822BAB60 
		protected internal unsafe void* previousFrameStatePtr { get; } // 0x0000000183CA3C50-0x0000000183CA3C70 
		protected internal unsafe void* defaultStatePtr { get; } // 0x0000000189BD63C8-0x0000000189BD6400 
		protected internal unsafe void* noiseMaskPtr { get; } // 0x0000000189BD6400-0x0000000189BD6438 
		protected internal uint stateOffsetRelativeToDeviceRoot { get; } // 0x0000000189BD64C8-0x0000000189BD6528 
		public FourCC optimizedControlDataType { get; } // 0x0000000183D50EE0-0x0000000183D50EF0 
		internal bool isSetupFinished { get; set; } // 0x000000018313D0C0-0x000000018313D0D0 0x0000000183139200-0x0000000183139220
		internal bool isButton { get; set; } // 0x00000001822BEF20-0x00000001822BEF30 0x000000018313FDF0-0x000000018313FE10
		internal bool isConfigUpToDate { get; set; } // 0x0000000182CAA300-0x0000000182CAA310 0x0000000182CAA310-0x0000000182CAA330
		internal bool dontReset { get; set; } // 0x00000001822FC1D0-0x00000001822FC1E0 0x000000018313B1A0-0x000000018313B1C0
		internal bool usesStateFromOtherControl { get; set; } // 0x00000001822FC1E0-0x00000001822FC1F0 0x0000000189BD66A8-0x0000000189BD66C8
		internal bool hasDefaultState { get; } // 0x00000001822FBAB0-0x00000001822FBAC0 
	
		// Nested types
		[Flags]
		internal enum ControlFlags // TypeDefIndex: 44139
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
		protected InputControl() {} // 0x00000001834B7E90-0x00000001834B7EF0
	
		// Methods
		public override string ToString() => default; // 0x0000000189BD6174-0x0000000189BD61D4
		private string DebuggerDisplay() => default; // 0x0000000189BD5810-0x0000000189BD5924
		public float EvaluateMagnitude() => default; // 0x000000018328CF20-0x000000018328CFB0
		public virtual unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000183D751A0-0x0000000183D751B0
		public abstract unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
		public abstract unsafe object ReadValueFromStateAsObject(void* statePtr);
		public abstract unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
		public virtual unsafe void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr) {} // 0x0000000189BD624C-0x0000000189BD62C0
		public virtual unsafe void WriteValueFromObjectIntoState(object value, void* statePtr) {} // 0x0000000189BD62C0-0x0000000189BD6334
		public abstract unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr);
		public InputControl TryGetChildControl(string path) => default; // 0x0000000189BD61D4-0x0000000189BD624C
		public TControl TryGetChildControl<TControl>(string path)
			where TControl : InputControl => default;
		public InputControl GetChildControl(string path) => default; // 0x0000000189BD5CB4-0x0000000189BD5DD8
		public TControl GetChildControl<TControl>(string path)
			where TControl : InputControl => default;
		protected virtual void FinishSetup() {} // 0x000000018350B670-0x000000018350B680
		protected void RefreshConfigurationIfNeeded() {} // 0x0000000182CAA2D0-0x0000000182CAA300
		protected virtual void RefreshConfiguration() {} // 0x000000018350B670-0x000000018350B680
		protected virtual FourCC CalculateOptimizedControlDataType() => default; // 0x0000000181002730-0x0000000181002740
		public void ApplyParameterChanges() {} // 0x0000000189BD571C-0x0000000189BD5760
		private void SetOptimizedControlDataType() {} // 0x0000000189BD6100-0x0000000189BD6174
		internal void SetOptimizedControlDataTypeRecursively() {} // 0x0000000189BD5FB4-0x0000000189BD6100
		[Conditional("UNITY_EDITOR")]
		internal void EnsureOptimizationTypeHasNotChanged() {} // 0x0000000189BD5924-0x0000000189BD5CB4
		internal void CallFinishSetupRecursive() {} // 0x0000000189BD5760-0x0000000189BD5810
		internal string MakeChildPath(string path) => default; // 0x0000000189BD5DD8-0x0000000189BD5E54
		internal void BakeOffsetIntoStateBlockRecursive(uint offset) {} // 0x00000001822FBAC0-0x00000001822FC060
		internal int GetDeviceIndex() => default; // 0x00000001822BABE0-0x00000001822BAC20
		internal bool IsValueConsideredPressed(float value) => default; // 0x00000001822BEE80-0x00000001822BEF20
		internal virtual void AddProcessor(object first) {} // 0x000000018350B670-0x000000018350B680
		internal void MarkAsStale() {} // 0x0000000183D77130-0x0000000183D77140
		internal void MarkAsStaleRecursively() {} // 0x0000000189BD5E54-0x0000000189BD5FB4
	}

	public abstract class InputControl<TValue> : InputControl // TypeDefIndex: 44141
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

	public static class InputControlExtensions // TypeDefIndex: 44148
	{
		// Nested types
		[Flags]
		public enum Enumerate // TypeDefIndex: 44142
		{
			IgnoreControlsInDefaultState = 1,
			IgnoreControlsInCurrentState = 2,
			IncludeSyntheticControls = 4,
			IncludeNoisyControls = 8,
			IncludeNonLeafControls = 16
		}
	
		public struct InputEventControlCollection : IEnumerable<InputControl> // TypeDefIndex: 44143
		{
			// Fields
			internal UnityEngine.InputSystem.InputDevice m_Device; // 0x00
			internal InputEventPtr m_EventPtr; // 0x08
			internal Enumerate m_Flags; // 0x10
			internal float m_MagnitudeThreshold; // 0x14
	
			// Properties
			public InputEventPtr eventPtr { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
			// Methods
			public InputEventControlEnumerator GetEnumerator() => default; // 0x0000000189BD7DBC-0x0000000189BD7E2C
			IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator() => default; // 0x0000000189BD7E2C-0x0000000189BD7EC4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BD7EC4-0x0000000189BD7F5C
		}
	
		public struct InputEventControlEnumerator : IEnumerator<InputControl> // TypeDefIndex: 44144
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
			public InputControl Current { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
			object IEnumerator.Current { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
	
			// Constructors
			internal unsafe InputEventControlEnumerator(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, Enumerate flags, float magnitudeThreshold = 0f /* Metadata: 0x01FB6471 */) : this() {
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
			} // 0x0000000189BD8710-0x0000000189BD8884
	
			// Methods
			private bool CheckDefault(uint numBits) => default; // 0x0000000189BD7F8C-0x0000000189BD7FBC
			private bool CheckCurrent(uint numBits) => default; // 0x0000000189BD7F5C-0x0000000189BD7F8C
			public bool MoveNext() => default; // 0x0000000189BD7FBC-0x0000000189BD8388
			public void Reset() {} // 0x0000000189BD8388-0x0000000189BD8710
			public void Dispose() {} // 0x0000000183D771B0-0x0000000183D771C0
		}
	
		public struct ControlBuilder // TypeDefIndex: 44145
		{
			// Properties
			public InputControl control { [IsReadOnly] get; internal set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			public ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index) => default; // 0x0000000189BCFB7C-0x0000000189BCFC04
			public ControlBuilder WithParent(InputControl parent) => default; // 0x0000000189BCFE54-0x0000000189BCFE84
			public ControlBuilder WithName(string name) => default; // 0x0000000189BCFE04-0x0000000189BCFE54
			public ControlBuilder WithDisplayName(string displayName) => default; // 0x0000000189BCFD38-0x0000000189BCFD9C
			public ControlBuilder WithShortDisplayName(string shortDisplayName) => default; // 0x0000000189BCFE84-0x0000000189BCFEE8
			public ControlBuilder WithLayout(InternedString layout) => default; // 0x0000000189BCFD9C-0x0000000189BCFDCC
			public ControlBuilder WithUsages(int startIndex, int count) => default; // 0x000000018313F810-0x000000018313F840
			public ControlBuilder WithAliases(int startIndex, int count) => default; // 0x000000018313F7E0-0x000000018313F810
			public ControlBuilder WithChildren(int startIndex, int count) => default; // 0x000000018313F9E0-0x000000018313FA10
			public ControlBuilder WithStateBlock(InputStateBlock stateBlock) => default; // 0x0000000189BCFEE8-0x0000000189BCFF0C
			public ControlBuilder WithDefaultState(PrimitiveValue value) => default; // 0x0000000189BCFCF0-0x0000000189BCFD38
			public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) => default; // 0x0000000189BCFDCC-0x0000000189BCFE04
			public ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor)
				where TProcessor : InputProcessor<TValue>
				where TValue : struct => default;
			public ControlBuilder IsNoisy(bool value) => default; // 0x0000000189BCFCA0-0x0000000189BCFCC8
			public ControlBuilder IsSynthetic(bool value) => default; // 0x0000000189BCFCC8-0x0000000189BCFCF0
			public ControlBuilder DontReset(bool value) => default; // 0x0000000189BCFC04-0x0000000189BCFC58
			public ControlBuilder IsButton(bool value) => default; // 0x0000000189BCFC78-0x0000000189BCFCA0
			public void Finish() {} // 0x0000000189BCFC58-0x0000000189BCFC78
		}
	
		public struct DeviceBuilder // TypeDefIndex: 44146
		{
			// Properties
			public UnityEngine.InputSystem.InputDevice device { [IsReadOnly] get; internal set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			public DeviceBuilder WithName(string name) => default; // 0x0000000189BCFE04-0x0000000189BCFE54
			public DeviceBuilder WithDisplayName(string displayName) => default; // 0x0000000189BCFD38-0x0000000189BCFD9C
			public DeviceBuilder WithShortDisplayName(string shortDisplayName) => default; // 0x0000000189BCFE84-0x0000000189BCFEE8
			public DeviceBuilder WithLayout(InternedString layout) => default; // 0x0000000189BCFD9C-0x0000000189BCFDCC
			public DeviceBuilder WithChildren(int startIndex, int count) => default; // 0x000000018313F9E0-0x000000018313FA10
			public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) => default; // 0x0000000189BCFEE8-0x0000000189BCFF0C
			public DeviceBuilder IsNoisy(bool value) => default; // 0x0000000189BCFCA0-0x0000000189BCFCC8
			public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) => default; // 0x0000000189BD045C-0x0000000189BD04F0
			public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) => default; // 0x0000000189BD02D8-0x0000000189BD031C
			public DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map) => default; // 0x0000000189BD04F0-0x0000000189BD0520
			public DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies) => default; // 0x0000000189BD031C-0x0000000189BD045C
			public void Finish() {} // 0x0000000189BCFF0C-0x0000000189BD02D8
		}
	
		// Extension methods
		public static TControl FindInParentChain<TControl>(this InputControl control)
			where TControl : InputControl => default;
		public static bool IsPressed(this InputControl control, float buttonPressPoint = 0f /* Metadata: 0x01FB6445 */) => default; // 0x0000000189BD2998-0x0000000189BD2A7C
		public static bool IsActuated(this InputControl control, float threshold = 0f /* Metadata: 0x01FB6449 */) => default; // 0x0000000189BD2910-0x0000000189BD2998
		public static object ReadValueAsObject(this InputControl control) => default; // 0x0000000189BD2AF4-0x0000000189BD2B70
		public static unsafe void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize) {} // 0x0000000189BD2C00-0x0000000189BD2CF0
		public static object ReadDefaultValueAsObject(this InputControl control) => default; // 0x0000000189BD2A7C-0x0000000189BD2AF4
		public static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent)
			where TValue : struct => default;
		public static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct {
			value = default;
			return default;
		}
		public static object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent) => default; // 0x0000000189BD2B70-0x0000000189BD2C00
		public static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr)
			where TValue : struct => default;
		public static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out ref TValue value)
			where TValue : struct {
			value = default;
			return default;
		}
		public static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, object value) {} // 0x0000000189BD2EB8-0x0000000189BD2F68
		public static unsafe void WriteValueIntoState(this InputControl control, void* statePtr) {} // 0x0000000189BD2F68-0x0000000189BD312C
		public static unsafe void WriteValueIntoState<TValue>(this InputControl control, TValue value, void* statePtr)
			where TValue : struct {}
		public static unsafe void WriteValueIntoState<TValue>(this InputControl<TValue> control, TValue value, void* statePtr)
			where TValue : struct {}
		public static unsafe void WriteValueIntoState<TValue>(this InputControl<TValue> control, void* statePtr)
			where TValue : struct {}
		public static void WriteValueIntoState<TValue, TState>(this InputControl<TValue> control, TValue value, ref ref TState state)
			where TValue : struct
			where TState : struct, IInputStateTypeInfo {}
		public static void WriteValueIntoEvent<TValue>(this InputControl control, TValue value, InputEventPtr eventPtr)
			where TValue : struct {}
		public static void WriteValueIntoEvent<TValue>(this InputControl<TValue> control, TValue value, InputEventPtr eventPtr)
			where TValue : struct {}
		public static unsafe void CopyState(this UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes) {} // 0x0000000189BD1D5C-0x0000000189BD1EDC
		public static void CopyState<TState>(this UnityEngine.InputSystem.InputDevice device, out ref TState state)
			where TState : struct, IInputStateTypeInfo {
			state = default;
		}
		public static bool CheckStateIsAtDefault(this InputControl control) => default; // 0x00000001822BCE20-0x00000001822BCED0
		public static unsafe bool CheckStateIsAtDefault(this InputControl control, void* statePtr, void* maskPtr = null) => default; // 0x00000001822BCED0-0x00000001822BCF70
		public static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control) => default; // 0x0000000189BD19CC-0x0000000189BD1A48
		public static unsafe bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr) => default; // 0x0000000189BD1A48-0x0000000189BD1B68
		public static unsafe bool CompareStateIgnoringNoise(this InputControl control, void* statePtr) => default; // 0x0000000189BD1B68-0x0000000189BD1C64
		public static unsafe bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null) => default; // 0x00000001822BCF70-0x00000001822BD0F0
		public static unsafe bool CompareState(this InputControl control, void* statePtr, void* maskPtr = null) => default; // 0x0000000189BD1C64-0x0000000189BD1D5C
		public static unsafe bool HasValueChangeInState(this InputControl control, void* statePtr) => default; // 0x0000000189BD2834-0x0000000189BD2910
		public static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr) => default; // 0x0000000189BD2740-0x0000000189BD2834
		public static unsafe void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr) => default; // 0x0000000189BD2640-0x0000000189BD2728
		internal static unsafe void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType) => default; // 0x0000000189BD241C-0x0000000189BD2640
		public static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr) => default; // 0x0000000189BD2CF0-0x0000000189BD2EB8
		public static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x01FB644D */)
			where TValue : struct {}
		public static unsafe void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState) {} // 0x0000000189BD14C8-0x0000000189BD15BC
		internal static unsafe void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState) {} // 0x0000000189BD15BC-0x0000000189BD16B4
		public static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate)
			where TControl : InputControl {}
		internal static string BuildPath(this InputControl control, string deviceLayout, StringBuilder builder = null) => default; // 0x0000000189BD16B4-0x0000000189BD19CC
		public static InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, Enumerate flags, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x01FB6455 */) => default; // 0x0000000189BD1F20-0x0000000189BD2198
		public static InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f /* Metadata: 0x01FB6459 */) => default; // 0x0000000189BD1EDC-0x0000000189BD1F20
		public static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x01FB645D */, bool buttonControlsOnly = true /* Metadata: 0x01FB6461 */) => default; // 0x0000000189BD2728-0x0000000189BD2740
		public static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x01FB6462 */, bool buttonControlsOnly = true /* Metadata: 0x01FB6466 */) => default; // 0x0000000189BD2220-0x0000000189BD241C
		[IteratorStateMachine(typeof(_GetAllButtonPresses_d__43))]
		public static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f /* Metadata: 0x01FB6467 */, bool buttonControlsOnly = true /* Metadata: 0x01FB646B */) => default; // 0x0000000189BD2198-0x0000000189BD2220
		public static ControlBuilder Setup(this InputControl control) => default; // 0x000000018313D070-0x000000018313D0C0
		public static DeviceBuilder Setup(this UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount) => default; // 0x000000018313CF20-0x000000018313D070
	}

	public enum InputControlLayoutChange // TypeDefIndex: 44149
	{
		Added = 0,
		Removed = 1,
		Replaced = 2
	}

	[DebuggerDisplay("Count = {Count}")]
	public struct InputControlList<TControl> : IList<TControl>, IReadOnlyList<TControl>, IDisposable // TypeDefIndex: 44151
		where TControl : InputControl
	{
		// Fields
		private int m_Count;
		private NativeArray<ulong> m_Indices;
		private readonly Unity.Collections.Allocator m_Allocator;
		private const ulong kInvalidIndex = 18446744073709551615; // Metadata: 0x01FB6482
	
		// Properties
		public int Count { get => default; }
		public int Capacity { get => default; set {} }
		public bool IsReadOnly { get => default; }
		public TControl this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TControl> // TypeDefIndex: 44150
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
		public InputControlList(Unity.Collections.Allocator allocator, int initialCapacity = 0 /* Metadata: 0x01FB6478 */) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
		public InputControlList(IEnumerable<TControl> values, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6479 */) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
		public InputControlList(params TControl[] values) : this() {
			m_Count = default;
			m_Indices = default;
			m_Allocator = default;
		}
	
		// Methods
		public void Resize(int size) {}
		public void Add(TControl item) {}
		public void AddSlice<TList>(TList list, int count = -1 /* Metadata: 0x01FB647A */, int destinationIndex = -1 /* Metadata: 0x01FB647B */, int sourceIndex = 0 /* Metadata: 0x01FB647C */)
			where TList : IReadOnlyList<TControl> {}
		public void AddRange(IEnumerable<TControl> list, int count = -1 /* Metadata: 0x01FB647D */, int destinationIndex = -1 /* Metadata: 0x01FB647E */) {}
		public bool Remove(TControl item) => default;
		public void RemoveAt(int index) {}
		public void CopyTo(TControl[] array, int arrayIndex) {}
		public int IndexOf(TControl item) => default;
		public int IndexOf(TControl item, int startIndex, int count = -1 /* Metadata: 0x01FB647F */) => default;
		public void Insert(int index, TControl item) {}
		public void Clear() {}
		public bool Contains(TControl item) => default;
		public bool Contains(TControl item, int startIndex, int count = -1 /* Metadata: 0x01FB6480 */) => default;
		public void SwapElements(int index1, int index2) {}
		public void Sort<TCompare>(int startIndex, int count, TCompare comparer)
			where TCompare : IComparer<TControl> {}
		public TControl[] ToArray(bool dispose = false /* Metadata: 0x01FB6481 */) => default;
		internal void AppendTo(ref ref TControl[] array, ref int count) {}
		public void Dispose() {}
		public IEnumerator<TControl> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public override string ToString() => default;
		private static ulong ToIndex(TControl control) => default;
		private static TControl FromIndex(ulong index) => default;
	}

	public static class InputControlPath // TypeDefIndex: 44159
	{
		// Fields
		public const string Wildcard = "*"; // Metadata: 0x01FB6495
		public const string DoubleWildcard = "**"; // Metadata: 0x01FB6497
		public const char Separator = '/'; // Metadata: 0x01FB649A
		internal const char SeparatorReplacement = ' '; // Metadata: 0x01FB649C
	
		// Nested types
		[Flags]
		public enum HumanReadableStringOptions // TypeDefIndex: 44152
		{
			None = 0,
			OmitDevice = 2,
			UseShortNames = 4
		}
	
		private enum PathComponentType // TypeDefIndex: 44153
		{
			Name = 0,
			DisplayName = 1,
			Usage = 2,
			Layout = 3
		}
	
		public struct ParsedPathComponent // TypeDefIndex: 44155
		{
			// Fields
			internal Substring m_Layout; // 0x00
			internal InlinedArray<Substring> m_Usages; // 0x10
			internal Substring m_Name; // 0x30
			internal Substring m_DisplayName; // 0x40
	
			// Properties
			public string layout { get => default; } // 0x0000000189BDD738-0x0000000189BDD740 
			public IEnumerable<string> usages { get => default; } // 0x0000000189BDD74C-0x0000000189BDD888 
			public string name { get => default; } // 0x0000000189BDD740-0x0000000189BDD74C 
			public string displayName { get => default; } // 0x0000000189BDD64C-0x0000000189BDD658 
			internal bool isWildcard { get => default; } // 0x0000000189BDD6C8-0x0000000189BDD738 
			internal bool isDoubleWildcard { get => default; } // 0x0000000189BDD658-0x0000000189BDD6C8 
	
			// Methods
			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options) {
				referencedLayoutName = default;
				controlPath = default;
				return default;
			} // 0x0000000189BDCED0-0x0000000189BDD64C
			private static string ToHumanReadableString(Substring substring) => default; // 0x0000000189BDCE84-0x0000000189BDCED0
			public bool Matches(InputControl control) => default; // 0x0000000189BDCBD4-0x0000000189BDCE84
			private static bool ComparePathElementToString(Substring pathElement, string element) => default; // 0x0000000189BDCAE4-0x0000000189BDCBD4
		}
	
		private struct PathParser // TypeDefIndex: 44156
		{
			// Fields
			private string path; // 0x00
			private int length; // 0x08
			private int leftIndexInPath; // 0x0C
			private int rightIndexInPath; // 0x10
			public ParsedPathComponent current; // 0x18
	
			// Properties
			public bool isAtEnd { get => default; } // 0x0000000189BDDC2C-0x0000000189BDDC38 
	
			// Constructors
			public PathParser(string path) : this() {
				this.path = default;
				length = default;
				leftIndexInPath = default;
				rightIndexInPath = default;
				current = default;
			} // 0x0000000189BDDBE8-0x0000000189BDDC2C
	
			// Methods
			public bool MoveToNextComponent() => default; // 0x0000000189BDD888-0x0000000189BDDB18
			private Substring ParseComponentPart(char terminator) => default; // 0x0000000189BDDB18-0x0000000189BDDBE8
		}
	
		// Methods
		public static string Combine(InputControl parent, string path) => default; // 0x0000000189BD3154-0x0000000189BD321C
		public static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x01FB648A */, InputControl control = null) => default; // 0x0000000189BD3E74-0x0000000189BD3EA8
		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None /* Metadata: 0x01FB648B */, InputControl control = null) {
			deviceLayoutName = default;
			controlPath = default;
			return default;
		} // 0x0000000189BD3EA8-0x0000000189BD4894
		public static string[] TryGetDeviceUsages(string path) => default; // 0x0000000189BD4E24-0x0000000189BD4FC8
		public static string TryGetDeviceLayout(string path) => default; // 0x0000000189BD4D10-0x0000000189BD4E24
		public static string TryGetControlLayout(string path) => default; // 0x0000000189BD4AF0-0x0000000189BD4D10
		private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName) => default; // 0x0000000189BD3588-0x0000000189BD36FC
		private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout) => default; // 0x0000000189BD33A8-0x0000000189BD3588
		private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser) => default; // 0x0000000189BD321C-0x0000000189BD33A8
		private static bool StringMatches(Substring str, InternedString matchTo) => default; // 0x0000000189BD3CBC-0x0000000189BD3E74
		public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x01FB648C */) => default; // 0x0000000189BD48EC-0x0000000189BD4944
		public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x01FB648D */) => default; // 0x0000000189BD49B4-0x0000000189BD4AF0
		public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0 /* Metadata: 0x01FB648E */) => default; // 0x0000000189BD4944-0x0000000189BD49B4
		public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x01FB648F */)
			where TControl : InputControl => default;
		public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches)
			where TControl : InputControl => default;
		public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x01FB6490 */) => default; // 0x0000000189BD4894-0x0000000189BD48EC
		public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0 /* Metadata: 0x01FB6491 */)
			where TControl : InputControl => default;
		public static bool Matches(string expected, InputControl control) => default; // 0x0000000189BD3B38-0x0000000189BD3C4C
		internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false /* Metadata: 0x01FB6492 */) => default; // 0x0000000189BD36FC-0x0000000189BD39A4
		public static bool MatchesPrefix(string expected, InputControl control) => default; // 0x0000000189BD39A4-0x0000000189BD3AC8
		private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false /* Metadata: 0x01FB6493 */) => default; // 0x0000000189BD3AC8-0x0000000189BD3B38
		private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default;
		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default;
		private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple)
			where TControl : InputControl => default;
		private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0 /* Metadata: 0x01FB6494 */) => default; // 0x00000001822FD210-0x00000001822FD4B0
		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) => default; // 0x00000001822F8610-0x00000001822F86E0
		[IteratorStateMachine(typeof(_Parse_d__34))]
		public static IEnumerable<ParsedPathComponent> Parse(string path) => default; // 0x0000000189BD3C4C-0x0000000189BD3CBC
	
		// Extension methods
		internal static string CleanSlashes(this string pathComponent) => default; // 0x0000000189BD312C-0x0000000189BD3154
	}

	public abstract class InputProcessor // TypeDefIndex: 44161
	{
		// Fields
		internal static TypeTable s_Processors; // 0x00
	
		// Properties
		public virtual CachingPolicy cachingPolicy { get; } // 0x0000000181002730-0x0000000181002740 
	
		// Nested types
		public enum CachingPolicy // TypeDefIndex: 44160
		{
			CacheResult = 0,
			EvaluateOnEveryRead = 1
		}
	
		// Constructors
		protected InputProcessor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract object ProcessAsObject(object value, InputControl control);
		public abstract unsafe void Process(void* buffer, int bufferSize, InputControl control);
		internal static System.Type GetValueTypeFromType(System.Type processorType) => default; // 0x0000000189BD8C00-0x0000000189BD8CD4
	}

	public abstract class InputProcessor<TValue> : InputProcessor // TypeDefIndex: 44162
		where TValue : struct
	{
		// Constructors
		protected InputProcessor() {}
	
		// Methods
		public abstract TValue Process(TValue value, InputControl control);
		public override object ProcessAsObject(object value, InputControl control) => default;
		public override unsafe void Process(void* buffer, int bufferSize, InputControl control) {}
	}

	[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = true)]
	public class Gamepad : UnityEngine.InputSystem.InputDevice, IDualMotorRumble // TypeDefIndex: 44163
	{
		// Fields
		private DualMotorRumble m_Rumble; // 0x208
		private static int s_GamepadCount; // 0x08
		private static Gamepad[] s_Gamepads; // 0x10
	
		// Properties
		public ButtonControl buttonWest { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public ButtonControl buttonNorth { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public ButtonControl buttonSouth { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		public ButtonControl buttonEast { get; protected set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public ButtonControl leftStickButton { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		public ButtonControl rightStickButton { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		public ButtonControl startButton { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public ButtonControl selectButton { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		public DpadControl dpad { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		public ButtonControl leftShoulder { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		public ButtonControl rightShoulder { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		public StickControl leftStick { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		public StickControl rightStick { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		public ButtonControl leftTrigger { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		public ButtonControl rightTrigger { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		public ButtonControl aButton { get => default; } // 0x0000000183D56AD0-0x0000000183D56AE0 
		public ButtonControl bButton { get => default; } // 0x0000000183D57170-0x0000000183D57180 
		public ButtonControl xButton { get => default; } // 0x0000000183D56B70-0x0000000183D56B80 
		public ButtonControl yButton { get => default; } // 0x0000000183D56AE0-0x0000000183D56AF0 
		public ButtonControl triangleButton { get => default; } // 0x0000000183D56AE0-0x0000000183D56AF0 
		public ButtonControl squareButton { get => default; } // 0x0000000183D56B70-0x0000000183D56B80 
		public ButtonControl circleButton { get => default; } // 0x0000000183D57170-0x0000000183D57180 
		public ButtonControl crossButton { get => default; } // 0x0000000183D56AD0-0x0000000183D56AE0 
		public ButtonControl this[GamepadButton button] { get => default; } // 0x0000000189BD0E88-0x0000000189BD10A4 
		public static Gamepad current { get; private set; } // 0x0000000189BD1114-0x0000000189BD114C 0x0000000189BD114C-0x0000000189BD119C
		public static new ReadOnlyArray<Gamepad> all { get => default; } // 0x0000000189BD10A4-0x0000000189BD1114 
	
		// Constructors
		public Gamepad() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BD099C-0x0000000189BD0D00
		public override void MakeCurrent() {} // 0x0000000189BD0D00-0x0000000189BD0D08
		protected override void OnAdded() {} // 0x0000000189BD0D08-0x0000000189BD0D78
		protected override void OnRemoved() {} // 0x0000000189BD0D78-0x0000000189BD0E24
		public virtual void PauseHaptics() {} // 0x0000000189BD0E24-0x0000000189BD0E38
		public virtual void ResumeHaptics() {} // 0x0000000189BD0E4C-0x0000000189BD0E60
		public virtual void ResetHaptics() {} // 0x0000000189BD0E38-0x0000000189BD0E4C
		public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x0000000189BD0E60-0x0000000189BD0E88
	}

	public class InputDevice : InputControl // TypeDefIndex: 44166
	{
		// Fields
		public const int InvalidDeviceId = 0; // Metadata: 0x01FB64A8
		internal const int kLocalParticipantId = 0; // Metadata: 0x01FB64A9
		internal const int kInvalidDeviceIndex = -1; // Metadata: 0x01FB64AA
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
		internal const int kControlIndexBits = 10; // Metadata: 0x01FB64AB
		internal const int kStateOffsetBits = 13; // Metadata: 0x01FB64AC
		internal const int kStateSizeBits = 9; // Metadata: 0x01FB64AD
	
		// Properties
		public InputDeviceDescription description { get => default; } // 0x0000000183D77170-0x0000000183D771B0 
		public bool enabled { get => default; } // 0x00000001824B0F00-0x00000001824B0FC0 
		public bool canRunInBackground { get => default; } // 0x0000000184273050-0x0000000184273058 
		internal bool canDeviceRunInBackground { get => default; } // 0x00000001837B09F0-0x00000001837B0AB0 
		public bool added { get => default; } // 0x0000000182CB0700-0x0000000182CB0710 
		public bool remote { get => default; } // 0x0000000189BD7CD4-0x0000000189BD7CE0 
		public bool native { get => default; } // 0x0000000183CEFE10-0x0000000183CEFE20 
		public bool updateBeforeRender { get => default; } // 0x000000018235D3D0-0x000000018235D3E0 
		public int deviceId { get => default; } // 0x0000000183D50E70-0x0000000183D50E80 
		public double lastUpdateTime { get => default; } // 0x0000000189BD7C8C-0x0000000189BD7CD4 
		public bool wasUpdatedThisFrame { get => default; } // 0x0000000183D2A5C0-0x0000000183D2A610 
		public ReadOnlyArray<InputControl> allControls { get => default; } // 0x0000000183B0EE80-0x0000000183B0EEE0 
		public override System.Type valueType { get => default; } // 0x0000000189BD7D2C-0x0000000189BD7D7C 
		public override int valueSizeInBytes { get => default; } // 0x0000000189BD7CE0-0x0000000189BD7D2C 
		[Obsolete("Use \'InputSystem.devices\' instead. (UnityUpgradable) -> InputSystem.devices", false)]
		public static ReadOnlyArray<InputDevice> all { get => default; } // 0x0000000189BD7C3C-0x0000000189BD7C8C 
		internal bool disabledInFrontend { get => default; set {} } // 0x0000000182CAFAC0-0x0000000182CAFAD0 0x0000000189BD7D7C-0x0000000189BD7D9C
		internal bool disabledInRuntime { get => default; set {} } // 0x0000000182CAFAD0-0x0000000182CAFAE0 0x0000000182CB0AF0-0x0000000182CB0B20
		internal bool disabledWhileInBackground { get => default; set {} } // 0x0000000182CB0AE0-0x0000000182CB0AF0 0x0000000182CB0AB0-0x0000000182CB0AE0
		internal bool hasControlsWithDefaultState { get => default; set {} } // 0x0000000183D36300-0x0000000183D363E0 0x0000000183999270-0x0000000183999290
		internal bool hasDontResetControls { get => default; set {} } // 0x0000000182CB06F0-0x0000000182CB0700 0x000000018313B1C0-0x000000018313B1E0
		internal bool hasStateCallbacks { get => default; set {} } // 0x00000001822BAEC0-0x00000001822BAED0 0x0000000189BD7D9C-0x0000000189BD7DBC
		internal bool hasEventMerger { get => default; set {} } // 0x00000001824B0EF0-0x00000001824B0F00 0x000000018235CFD0-0x000000018235CFF0
		internal bool hasEventPreProcessor { get => default; set {} } // 0x000000018338AB10-0x000000018338AB20 0x000000018235CC00-0x000000018235CC20
	
		// Nested types
		[Serializable]
		[Flags]
		internal enum DeviceFlags // TypeDefIndex: 44164
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
	
		internal struct ControlBitRangeNode // TypeDefIndex: 44165
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
			} // 0x0000000183D771F0-0x0000000183D77200
		}
	
		// Constructors
		public InputDevice() {} // 0x0000000189BD7C10-0x0000000189BD7C3C
	
		// Methods
		public override unsafe object ReadValueFromBufferAsObject(void* buffer, int bufferSize) => default; // 0x0000000189BD6F2C-0x0000000189BD6F78
		public override unsafe object ReadValueFromStateAsObject(void* statePtr) => default; // 0x0000000189BD6F78-0x0000000189BD7058
		public override unsafe void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize) {} // 0x0000000189BD7058-0x0000000189BD7250
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr) => default; // 0x0000000189BD67C8-0x0000000189BD6900
		internal void NotifyConfigurationChanged() {} // 0x0000000189BD6EB4-0x0000000189BD6F1C
		public virtual void MakeCurrent() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAdded() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRemoved() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnConfigurationChanged() {} // 0x000000018350B670-0x000000018350B680
		public long ExecuteCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default;
		protected virtual unsafe long ExecuteCommand(InputDeviceCommand* commandPtr) => default; // 0x00000001833FA6A0-0x00000001833FA780
		internal bool QueryEnabledStateFromRuntime() => default; // 0x00000001824B0FC0-0x00000001824B1070
		internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits) => default; // 0x0000000183D77160-0x0000000183D77170
		internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize) {
			controlIndex = default;
			stateOffset = default;
			stateSize = default;
		} // 0x0000000183D77140-0x0000000183D77160
		internal void AddDeviceUsage(InternedString usage) {} // 0x0000000189BD66C8-0x0000000189BD6770
		internal void RemoveDeviceUsage(InternedString usage) {} // 0x0000000189BD7250-0x0000000189BD7320
		internal void ClearDeviceUsages() {} // 0x0000000189BD6770-0x0000000189BD67C8
		internal bool RequestSync() => default; // 0x0000000182CAF8F0-0x0000000182CAF970
		internal bool RequestReset() => default; // 0x0000000189BD7320-0x0000000189BD7394
		internal bool ExecuteEnableCommand() => default; // 0x0000000182CAF970-0x0000000182CAF9F0
		internal bool ExecuteDisableCommand() => default; // 0x0000000182CAF9F0-0x0000000182CAFAC0
		internal void NotifyAdded() {} // 0x000000018426F97C-0x000000018426F98C
		internal void NotifyRemoved() {} // 0x0000000189BD6F1C-0x0000000189BD6F2C
		internal static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = default, bool noPrecompiledLayouts = false /* Metadata: 0x01FB64A7 */)
			where TDevice : InputDevice => default;
		internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice) {} // 0x0000000189BD7740-0x0000000189BD78C4
		private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset) {} // 0x0000000189BD78C4-0x0000000189BD7C10
		private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output) {} // 0x0000000189BD6900-0x0000000189BD6C1C
		private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<string> output) {} // 0x0000000189BD6C1C-0x0000000189BD6D84
		internal string DumpControlTree() => default; // 0x0000000189BD6D84-0x0000000189BD6E58
		private unsafe void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset) {} // 0x0000000189BD7394-0x0000000189BD7740
		private static unsafe bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits) => default; // 0x0000000189BD6E58-0x0000000189BD6EB4
	}

	public enum InputDeviceChange // TypeDefIndex: 44167
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
	public class Joystick : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 44168
	{
		// Fields
		private static int s_JoystickCount; // 0x08
		private static Joystick[] s_Joysticks; // 0x10
	
		// Properties
		public ButtonControl trigger { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public StickControl stick { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public AxisControl twist { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		public Vector2Control hatswitch { get; protected set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public static Joystick current { get; private set; } // 0x0000000189BDF278-0x0000000189BDF2B0 0x0000000189BDF2B0-0x0000000189BDF300
		public static new ReadOnlyArray<Joystick> all { get => default; } // 0x0000000189BDF208-0x0000000189BDF278 
	
		// Constructors
		public Joystick() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BDEF9C-0x0000000189BDF0C0
		public override void MakeCurrent() {} // 0x0000000189BDF0C0-0x0000000189BDF0C8
		protected override void OnAdded() {} // 0x0000000189BDF0C8-0x0000000189BDF138
		protected override void OnRemoved() {} // 0x0000000189BDF138-0x0000000189BDF208
	}

	public enum Key // TypeDefIndex: 44169
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

	internal static class KeyEx // TypeDefIndex: 44170
	{
		// Fields
		internal const UnityEngine.InputSystem.Key IMESelected = UnityEngine.InputSystem.Key.IMESelected; // Metadata: 0x01FB6592
		internal const UnityEngine.InputSystem.Key RemappedIMESelected = (UnityEngine.InputSystem.Key) 127; // Metadata: 0x01FB6594
	}

	[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
	public class Keyboard : UnityEngine.InputSystem.InputDevice, ITextInputReceiver, IEventPreProcessor // TypeDefIndex: 44171
	{
		// Fields
		public const int KeyCount = 110; // Metadata: 0x01FB6596
		internal const int ExtendedKeyCount = 123; // Metadata: 0x01FB6598
		private InlinedArray<Action<char>> m_TextInputListeners; // 0x1B8
		private string m_KeyboardLayoutName; // 0x1D0
		private KeyControl[] m_Keys; // 0x1D8
		private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners; // 0x1E0
	
		// Properties
		public string keyboardLayout { get => default; protected set {} } // 0x0000000189BE0F28-0x0000000189BE0F48 0x0000000184275C90-0x0000000184275CA4
		public AnyKeyControl anyKey { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public KeyControl spaceKey { get => default; } // 0x0000000189BE1298-0x0000000189BE12A8 
		public KeyControl enterKey { get => default; } // 0x0000000189BE0CF8-0x0000000189BE0D08 
		public KeyControl tabKey { get => default; } // 0x0000000189BE12B8-0x0000000189BE12C8 
		public KeyControl backquoteKey { get => default; } // 0x0000000189BE0B60-0x0000000189BE0B70 
		public KeyControl quoteKey { get => default; } // 0x0000000189BE11D8-0x0000000189BE11E8 
		public KeyControl semicolonKey { get => default; } // 0x0000000189BE1278-0x0000000189BE1288 
		public KeyControl commaKey { get => default; } // 0x0000000189BE0BB0-0x0000000189BE0BC0 
		public KeyControl periodKey { get => default; } // 0x0000000189BE11A8-0x0000000189BE11B8 
		public KeyControl slashKey { get => default; } // 0x0000000189BE1288-0x0000000189BE1298 
		public KeyControl backslashKey { get => default; } // 0x0000000189BE0B70-0x0000000189BE0B80 
		public KeyControl leftBracketKey { get => default; } // 0x0000000189BE0F88-0x0000000189BE0F98 
		public KeyControl rightBracketKey { get => default; } // 0x0000000189BE1228-0x0000000189BE1238 
		public KeyControl minusKey { get => default; } // 0x0000000189BE0FC8-0x0000000189BE0FD8 
		public KeyControl equalsKey { get => default; } // 0x0000000189BE0D08-0x0000000189BE0D18 
		public KeyControl aKey { get => default; } // 0x0000000189BE0AE8-0x0000000189BE0AF8 
		public KeyControl bKey { get => default; } // 0x0000000189BE0B50-0x0000000189BE0B60 
		public KeyControl cKey { get => default; } // 0x0000000189BE0B90-0x0000000189BE0BA0 
		public KeyControl dKey { get => default; } // 0x0000000189BE0C08-0x0000000189BE0C18 
		public KeyControl eKey { get => default; } // 0x0000000189BE0CD8-0x0000000189BE0CE8 
		public KeyControl fKey { get => default; } // 0x0000000189BE0EA8-0x0000000189BE0EB8 
		public KeyControl gKey { get => default; } // 0x0000000189BE0EB8-0x0000000189BE0EC8 
		public KeyControl hKey { get => default; } // 0x0000000189BE0EC8-0x0000000189BE0ED8 
		public KeyControl iKey { get => default; } // 0x0000000189BE0EE8-0x0000000189BE0EF8 
		public KeyControl jKey { get => default; } // 0x0000000189BE0F08-0x0000000189BE0F18 
		public KeyControl kKey { get => default; } // 0x0000000189BE0F18-0x0000000189BE0F28 
		public KeyControl lKey { get => default; } // 0x0000000189BE0F48-0x0000000189BE0F58 
		public KeyControl mKey { get => default; } // 0x0000000189BE0FB8-0x0000000189BE0FC8 
		public KeyControl nKey { get => default; } // 0x0000000189BE0FD8-0x0000000189BE0FE8 
		public KeyControl oKey { get => default; } // 0x0000000189BE1108-0x0000000189BE1118 
		public KeyControl pKey { get => default; } // 0x0000000189BE1168-0x0000000189BE1178 
		public KeyControl qKey { get => default; } // 0x0000000189BE11C8-0x0000000189BE11D8 
		public KeyControl rKey { get => default; } // 0x0000000189BE11E8-0x0000000189BE11F8 
		public KeyControl sKey { get => default; } // 0x0000000189BE1258-0x0000000189BE1268 
		public KeyControl tKey { get => default; } // 0x0000000189BE12A8-0x0000000189BE12B8 
		public KeyControl uKey { get => default; } // 0x0000000189BE12C8-0x0000000189BE12D8 
		public KeyControl vKey { get => default; } // 0x0000000189BE12E8-0x0000000189BE12F8 
		public KeyControl wKey { get => default; } // 0x0000000189BE12F8-0x0000000189BE1308 
		public KeyControl xKey { get => default; } // 0x0000000189BE1308-0x0000000189BE1318 
		public KeyControl yKey { get => default; } // 0x0000000189BE1318-0x0000000189BE1328 
		public KeyControl zKey { get => default; } // 0x0000000189BE1328-0x0000000189BE1338 
		public KeyControl digit1Key { get => default; } // 0x0000000189BE0C38-0x0000000189BE0C48 
		public KeyControl digit2Key { get => default; } // 0x0000000189BE0C48-0x0000000189BE0C58 
		public KeyControl digit3Key { get => default; } // 0x0000000189BE0C58-0x0000000189BE0C68 
		public KeyControl digit4Key { get => default; } // 0x0000000189BE0C68-0x0000000189BE0C78 
		public KeyControl digit5Key { get => default; } // 0x0000000189BE0C78-0x0000000189BE0C88 
		public KeyControl digit6Key { get => default; } // 0x0000000189BE0C88-0x0000000189BE0C98 
		public KeyControl digit7Key { get => default; } // 0x0000000189BE0C98-0x0000000189BE0CA8 
		public KeyControl digit8Key { get => default; } // 0x0000000189BE0CA8-0x0000000189BE0CB8 
		public KeyControl digit9Key { get => default; } // 0x0000000189BE0CB8-0x0000000189BE0CC8 
		public KeyControl digit0Key { get => default; } // 0x0000000189BE0C28-0x0000000189BE0C38 
		public KeyControl leftShiftKey { get => default; } // 0x0000000189BE0FA8-0x0000000189BE0FB8 
		public KeyControl rightShiftKey { get => default; } // 0x0000000189BE1248-0x0000000189BE1258 
		public KeyControl leftAltKey { get => default; } // 0x0000000189BE0F58-0x0000000189BE0F68 
		public KeyControl rightAltKey { get => default; } // 0x0000000189BE11F8-0x0000000189BE1208 
		public KeyControl leftCtrlKey { get => default; } // 0x0000000189BE0F98-0x0000000189BE0FA8 
		public KeyControl rightCtrlKey { get => default; } // 0x0000000189BE1238-0x0000000189BE1248 
		public KeyControl leftMetaKey { get => default; } // 0x0000000189BE0F68-0x0000000189BE0F78 
		public KeyControl rightMetaKey { get => default; } // 0x0000000189BE1208-0x0000000189BE1218 
		public KeyControl leftWindowsKey { get => default; } // 0x0000000189BE0F68-0x0000000189BE0F78 
		public KeyControl rightWindowsKey { get => default; } // 0x0000000189BE1208-0x0000000189BE1218 
		public KeyControl leftAppleKey { get => default; } // 0x0000000189BE0F68-0x0000000189BE0F78 
		public KeyControl rightAppleKey { get => default; } // 0x0000000189BE1208-0x0000000189BE1218 
		public KeyControl leftCommandKey { get => default; } // 0x0000000189BE0F68-0x0000000189BE0F78 
		public KeyControl rightCommandKey { get => default; } // 0x0000000189BE1208-0x0000000189BE1218 
		public KeyControl contextMenuKey { get => default; } // 0x0000000189BE0BC0-0x0000000189BE0BD0 
		public KeyControl escapeKey { get => default; } // 0x0000000189BE0D18-0x0000000189BE0D28 
		public KeyControl leftArrowKey { get => default; } // 0x0000000189BE0F78-0x0000000189BE0F88 
		public KeyControl rightArrowKey { get => default; } // 0x0000000189BE1218-0x0000000189BE1228 
		public KeyControl upArrowKey { get => default; } // 0x0000000189BE12D8-0x0000000189BE12E8 
		public KeyControl downArrowKey { get => default; } // 0x0000000189BE0CC8-0x0000000189BE0CD8 
		public KeyControl backspaceKey { get => default; } // 0x0000000189BE0B80-0x0000000189BE0B90 
		public KeyControl pageDownKey { get => default; } // 0x0000000189BE1178-0x0000000189BE1188 
		public KeyControl pageUpKey { get => default; } // 0x0000000189BE1188-0x0000000189BE1198 
		public KeyControl homeKey { get => default; } // 0x0000000189BE0ED8-0x0000000189BE0EE8 
		public KeyControl endKey { get => default; } // 0x0000000189BE0CE8-0x0000000189BE0CF8 
		public KeyControl insertKey { get => default; } // 0x0000000189BE0EF8-0x0000000189BE0F08 
		public KeyControl deleteKey { get => default; } // 0x0000000189BE0C18-0x0000000189BE0C28 
		public KeyControl capsLockKey { get => default; } // 0x0000000189BE0BA0-0x0000000189BE0BB0 
		public KeyControl scrollLockKey { get => default; } // 0x0000000189BE1268-0x0000000189BE1278 
		public KeyControl numLockKey { get => default; } // 0x0000000189BE0FE8-0x0000000189BE0FF8 
		public KeyControl printScreenKey { get => default; } // 0x0000000189BE11B8-0x0000000189BE11C8 
		public KeyControl pauseKey { get => default; } // 0x0000000189BE1198-0x0000000189BE11A8 
		public KeyControl numpadEnterKey { get => default; } // 0x0000000189BE10A8-0x0000000189BE10B8 
		public KeyControl numpadDivideKey { get => default; } // 0x0000000189BE1098-0x0000000189BE10A8 
		public KeyControl numpadMultiplyKey { get => default; } // 0x0000000189BE10D8-0x0000000189BE10E8 
		public KeyControl numpadMinusKey { get => default; } // 0x0000000189BE10C8-0x0000000189BE10D8 
		public KeyControl numpadPlusKey { get => default; } // 0x0000000189BE10F8-0x0000000189BE1108 
		public KeyControl numpadPeriodKey { get => default; } // 0x0000000189BE10E8-0x0000000189BE10F8 
		public KeyControl numpadEqualsKey { get => default; } // 0x0000000189BE10B8-0x0000000189BE10C8 
		public KeyControl numpad0Key { get => default; } // 0x0000000189BE0FF8-0x0000000189BE1008 
		public KeyControl numpad1Key { get => default; } // 0x0000000189BE1008-0x0000000189BE1018 
		public KeyControl numpad2Key { get => default; } // 0x0000000189BE1018-0x0000000189BE1028 
		public KeyControl numpad3Key { get => default; } // 0x0000000189BE1028-0x0000000189BE1038 
		public KeyControl numpad4Key { get => default; } // 0x0000000189BE1038-0x0000000189BE1048 
		public KeyControl numpad5Key { get => default; } // 0x0000000189BE1048-0x0000000189BE1058 
		public KeyControl numpad6Key { get => default; } // 0x0000000189BE1058-0x0000000189BE1068 
		public KeyControl numpad7Key { get => default; } // 0x0000000189BE1068-0x0000000189BE1078 
		public KeyControl numpad8Key { get => default; } // 0x0000000189BE1078-0x0000000189BE1088 
		public KeyControl numpad9Key { get => default; } // 0x0000000189BE1088-0x0000000189BE1098 
		public KeyControl f1Key { get => default; } // 0x0000000189BE0DC8-0x0000000189BE0DD8 
		public KeyControl f2Key { get => default; } // 0x0000000189BE0E28-0x0000000189BE0E38 
		public KeyControl f3Key { get => default; } // 0x0000000189BE0E38-0x0000000189BE0E48 
		public KeyControl f4Key { get => default; } // 0x0000000189BE0E48-0x0000000189BE0E58 
		public KeyControl f5Key { get => default; } // 0x0000000189BE0E58-0x0000000189BE0E68 
		public KeyControl f6Key { get => default; } // 0x0000000189BE0E68-0x0000000189BE0E78 
		public KeyControl f7Key { get => default; } // 0x0000000189BE0E78-0x0000000189BE0E88 
		public KeyControl f8Key { get => default; } // 0x0000000189BE0E88-0x0000000189BE0E98 
		public KeyControl f9Key { get => default; } // 0x0000000189BE0E98-0x0000000189BE0EA8 
		public KeyControl f10Key { get => default; } // 0x0000000189BE0D28-0x0000000189BE0D38 
		public KeyControl f11Key { get => default; } // 0x0000000189BE0D38-0x0000000189BE0D48 
		public KeyControl f12Key { get => default; } // 0x0000000189BE0D48-0x0000000189BE0D58 
		public KeyControl oem1Key { get => default; } // 0x0000000189BE1118-0x0000000189BE1128 
		public KeyControl oem2Key { get => default; } // 0x0000000189BE1128-0x0000000189BE1138 
		public KeyControl oem3Key { get => default; } // 0x0000000189BE1138-0x0000000189BE1148 
		public KeyControl oem4Key { get => default; } // 0x0000000189BE1148-0x0000000189BE1158 
		public KeyControl oem5Key { get => default; } // 0x0000000189BE1158-0x0000000189BE1168 
		public KeyControl f13Key { get => default; } // 0x0000000189BE0D58-0x0000000189BE0D68 
		public KeyControl f14Key { get => default; } // 0x0000000189BE0D68-0x0000000189BE0D78 
		public KeyControl f15Key { get => default; } // 0x0000000189BE0D78-0x0000000189BE0D88 
		public KeyControl f16Key { get => default; } // 0x0000000189BE0D88-0x0000000189BE0D98 
		public KeyControl f17Key { get => default; } // 0x0000000189BE0D98-0x0000000189BE0DA8 
		public KeyControl f18Key { get => default; } // 0x0000000189BE0DA8-0x0000000189BE0DB8 
		public KeyControl f19Key { get => default; } // 0x0000000189BE0DB8-0x0000000189BE0DC8 
		public KeyControl f20Key { get => default; } // 0x0000000189BE0DD8-0x0000000189BE0DE8 
		public KeyControl f21Key { get => default; } // 0x0000000189BE0DE8-0x0000000189BE0DF8 
		public KeyControl f22Key { get => default; } // 0x0000000189BE0DF8-0x0000000189BE0E08 
		public KeyControl f23Key { get => default; } // 0x0000000189BE0E08-0x0000000189BE0E18 
		public KeyControl f24Key { get => default; } // 0x0000000189BE0E18-0x0000000189BE0E28 
		public ButtonControl shiftKey { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public ButtonControl ctrlKey { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		public ButtonControl altKey { get; protected set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public ButtonControl imeSelected { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		public KeyControl this[UnityEngine.InputSystem.Key key] { get => default; } // 0x0000000189BE0A54-0x0000000189BE0AE8 
		public ReadOnlyArray<KeyControl> allKeys { get => default; } // 0x0000000189BE0AF8-0x0000000189BE0B50 
		public static Keyboard current { get; private set; } // 0x0000000189BE0BD0-0x0000000189BE0C08 0x0000000189BE13D0-0x0000000189BE1420
		protected KeyControl[] keys { get => default; set {} } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
	
		// Events
		public event Action<char> onTextInput;
		public event Action<IMECompositionString> onIMECompositionChange;
	
		// Constructors
		public Keyboard() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public void SetIMEEnabled(bool enabled) {} // 0x0000000189BE0804-0x0000000189BE088C
		public void SetIMECursorPosition(Vector2 position) {} // 0x0000000189BE0790-0x0000000189BE0804
		public override void MakeCurrent() {} // 0x000000018375CCE0-0x000000018375CD40
		protected override void OnRemoved() {} // 0x0000000189BE066C-0x0000000189BE0694
		protected override void FinishSetup() {} // 0x0000000189BDF3CC-0x0000000189BE0580
		protected override void RefreshConfiguration() {} // 0x0000000189BE0694-0x0000000189BE0790
		public void OnTextInput(char character) {} // 0x000000018351BD90-0x000000018351BDF0
		public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) => default; // 0x0000000189BDF300-0x0000000189BDF3CC
		public void OnIMECompositionChanged(IMECompositionString compositionString) {} // 0x0000000189BE0580-0x0000000189BE066C
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) => default; // 0x00000001822B8320-0x00000001822B8380
	}

	[InputControlLayout(stateType = typeof(UnityEngine.InputSystem.LowLevel.MouseState), isGenericTypeOfDevice = true)]
	public class Mouse : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver // TypeDefIndex: 44172
	{
		// Fields
		internal static Mouse s_PlatformMouseDevice; // 0x08
	
		// Properties
		public DeltaControl scroll { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public ButtonControl leftButton { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		public ButtonControl middleButton { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		public ButtonControl rightButton { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		public ButtonControl backButton { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		public ButtonControl forwardButton { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		public IntegerControl clickCount { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		public static new Mouse current { get; private set; } // 0x0000000189BE1780-0x0000000189BE17B8 0x0000000189BE17B8-0x0000000189BE1808
	
		// Constructors
		public Mouse() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000183108C60-0x0000000183108C80
		protected override void OnAdded() {} // 0x0000000183CEFDA0-0x0000000183CEFE10
		protected override void OnRemoved() {} // 0x0000000189BE167C-0x0000000189BE16A8
		public void WarpCursorPosition(Vector2 position) {} // 0x0000000189BE170C-0x0000000189BE1780
		protected override void FinishSetup() {} // 0x0000000189BE1420-0x0000000189BE1618
		protected new void OnNextUpdate() {} // 0x0000000189BE1618-0x0000000189BE167C
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BE16A8-0x0000000189BE16FC
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x0000000189BE16FC-0x0000000189BE1704
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BE1704-0x0000000189BE170C
	}

	public enum PenButton // TypeDefIndex: 44173
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
	public class Pen : UnityEngine.InputSystem.Pointer // TypeDefIndex: 44174
	{
		// Properties
		public ButtonControl tip { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public ButtonControl eraser { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		public ButtonControl firstBarrelButton { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		public ButtonControl secondBarrelButton { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		public ButtonControl thirdBarrelButton { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		public ButtonControl fourthBarrelButton { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		public ButtonControl inRange { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		public Vector2Control tilt { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		public AxisControl twist { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		public static new Pen current { get; internal set; } // 0x0000000189BE1C1C-0x0000000189BE1C54 0x0000000189BE1C54-0x0000000189BE1CA4
		public ButtonControl this[PenButton button] { get => default; } // 0x0000000189BE1AE8-0x0000000189BE1C1C 
	
		// Constructors
		public Pen() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE1A78-0x0000000189BE1A94
		protected override void OnRemoved() {} // 0x0000000189BE1A94-0x0000000189BE1AE8
		protected override void FinishSetup() {} // 0x0000000189BE1808-0x0000000189BE1A78
	}

	[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
	public class Pointer : UnityEngine.InputSystem.InputDevice, IInputStateCallbackReceiver // TypeDefIndex: 44175
	{
		// Properties
		public Vector2Control position { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public DeltaControl delta { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public Vector2Control radius { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		public AxisControl pressure { get; protected set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public ButtonControl press { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		public IntegerControl displayIndex { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		public static Pointer current { get; internal set; } // 0x0000000189BE1F24-0x0000000189BE1F5C 0x0000000189BE1F5C-0x0000000189BE2698
	
		// Constructors
		public Pointer() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000183108C80-0x0000000183108DA0
		protected override void OnRemoved() {} // 0x0000000189BE1E98-0x0000000189BE1EC0
		protected override void FinishSetup() {} // 0x0000000189BE1CA4-0x0000000189BE1E40
		protected void OnNextUpdate() {} // 0x0000000189BE1E40-0x0000000189BE1E98
		protected void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BE1EC0-0x0000000189BE1F14
		void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x0000000189BE1F14-0x0000000189BE1F1C
		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BE1F1C-0x0000000189BE1F24
		bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	internal class FastKeyboard : UnityEngine.InputSystem.Keyboard // TypeDefIndex: 44176
	{
		// Fields
		public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard"; // Metadata: 0x01FB65A5
	
		// Constructors
		public FastKeyboard() {} // 0x00000001833E5A30-0x00000001833E8E40
	
		// Methods
		private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) => default; // 0x00000001839C00D0-0x00000001839C02C0
		private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DC4F0-0x00000001839DC6E0
		private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FF720-0x00000001839FF900
		private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DC0F0-0x00000001839DC2F0
		private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FF360-0x00000001839FF540
		private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A06200-0x0000000183A063E0
		private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00620-0x0000000183A00800
		private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FFAE0-0x00000001839FFCC0
		private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A058A0-0x0000000183A05A80
		private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00BC0-0x0000000183A00DA0
		private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FF900-0x00000001839FFAE0
		private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A06020-0x0000000183A06200
		private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A038C0-0x0000000183A03AA0
		private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00080-0x0000000183A00260
		private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03500-0x0000000183A036E0
		private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04D60-0x0000000183A04F40
		private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FEFA0-0x00000001839FF180
		private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A05300-0x0000000183A054E0
		private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03AA0-0x0000000183A03C80
		private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00260-0x0000000183A00440
		private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A065C0-0x0000000183A067A0
		private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A063E0-0x0000000183A065C0
		private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A05C60-0x0000000183A05E40
		private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A056C0-0x0000000183A058A0
		private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A05120-0x0000000183A05300
		private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04B80-0x0000000183A04D60
		private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A049A0-0x0000000183A04B80
		private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A047C0-0x0000000183A049A0
		private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04400-0x0000000183A045E0
		private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04040-0x0000000183A04220
		private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03E60-0x0000000183A04040
		private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03C80-0x0000000183A03E60
		private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A036E0-0x0000000183A038C0
		private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03320-0x0000000183A03500
		private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01520-0x0000000183A01700
		private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01340-0x0000000183A01520
		private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00800-0x0000000183A009E0
		private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00440-0x0000000183A00620
		private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FFEA0-0x0000000183A00080
		private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FF540-0x00000001839FF720
		private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FF180-0x00000001839FF360
		private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FEDC0-0x00000001839FEFA0
		private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FEBE0-0x00000001839FEDC0
		private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FEA00-0x00000001839FEBE0
		private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FE820-0x00000001839FEA00
		private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FE640-0x00000001839FE820
		private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1B6B0-0x0000000183A1B890
		private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1B4D0-0x0000000183A1B6B0
		private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1B2F0-0x0000000183A1B4D0
		private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1B110-0x0000000183A1B2F0
		private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1AF30-0x0000000183A1B110
		private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1AD50-0x0000000183A1AF30
		private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1AB70-0x0000000183A1AD50
		private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1A990-0x0000000183A1AB70
		private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1A7B0-0x0000000183A1A990
		private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A1B890-0x0000000183A1BA70
		private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DBAF0-0x00000001839DBCF0
		private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DB6F0-0x00000001839DB8F0
		private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001837B4710-0x00000001837B4930
		private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DBEF0-0x00000001839DC0F0
		private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839CE2B0-0x00000001839CE4B0
		private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001837B4930-0x00000001837B4B50
		private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DBCF0-0x00000001839DBEF0
		private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DB8F0-0x00000001839DBAF0
		private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) => default; // 0x00000001837B4B50-0x00000001837B4D70
		private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839CDA90-0x00000001839CDCA0
		private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839CD880-0x00000001839CDA90
		private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839DC2F0-0x00000001839DC4F0
		private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A05E40-0x0000000183A06020
		private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01160-0x0000000183A01340
		private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00F80-0x0000000183A01160
		private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A045E0-0x0000000183A047C0
		private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04F40-0x0000000183A05120
		private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A04220-0x0000000183A04400
		private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A054E0-0x0000000183A056C0
		private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A05A80-0x0000000183A05C60
		private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A03140-0x0000000183A03320
		private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A009E0-0x0000000183A00BC0
		private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001839FFCC0-0x00000001839FFEA0
		private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A00DA0-0x0000000183A00F80
		private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02060-0x0000000183A02240
		private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02240-0x0000000183A02420
		private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01AC0-0x0000000183A01CA0
		private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01700-0x0000000183A018E0
		private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01CA0-0x0000000183A01E80
		private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A018E0-0x0000000183A01AC0
		private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A01E80-0x0000000183A02060
		private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02F60-0x0000000183A03140
		private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02D80-0x0000000183A02F60
		private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02BA0-0x0000000183A02D80
		private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A029C0-0x0000000183A02BA0
		private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A027E0-0x0000000183A029C0
		private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02600-0x0000000183A027E0
		private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) => default; // 0x0000000183A02420-0x0000000183A02600
		private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E1BF0-0x00000001833E1DD0
		private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E1DD0-0x00000001833E1FB0
		private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E1FB0-0x00000001833E2190
		private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2190-0x00000001833E2370
		private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2370-0x00000001833E2550
		private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2550-0x00000001833E2730
		private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2730-0x00000001833E2910
		private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2910-0x00000001833E2AF0
		private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2AF0-0x00000001833E2CD0
		private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2CD0-0x00000001833E2EB0
		private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E2EB0-0x00000001833E3090
		private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3090-0x00000001833E3270
		private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3270-0x00000001833E3450
		private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3450-0x00000001833E3630
		private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3630-0x00000001833E3810
		private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3810-0x00000001833E39F0
		private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E39F0-0x00000001833E3BD0
		private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3BD0-0x00000001833E3DB0
		private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3DB0-0x00000001833E3F90
		private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E3F90-0x00000001833E4170
		private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4170-0x00000001833E4350
		private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4350-0x00000001833E4530
		private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4530-0x00000001833E4710
		private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4710-0x00000001833E48F0
		private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E48F0-0x00000001833E4AD0
		private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4AD0-0x00000001833E4CB0
		private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4CB0-0x00000001833E4E90
		private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E4E90-0x00000001833E5070
		private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E5070-0x00000001833E5250
		private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E5250-0x00000001833E5430
		private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E5430-0x00000001833E5610
		private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent) => default; // 0x00000001833E5610-0x00000001833E57F0
		private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001833E57F0-0x00000001833E5A30
	}

	internal class FastMouse : UnityEngine.InputSystem.Mouse, IInputStateCallbackReceiver, IEventMerger // TypeDefIndex: 44177
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer"; // Metadata: 0x01FB65D5
	
		// Constructors
		public FastMouse() {} // 0x000000018319F3C0-0x00000001831A01B0
	
		// Methods
		private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183140B40-0x0000000183140D00
		private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x00000001831409A0-0x0000000183140B40
		private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183140810-0x00000001831409A0
		private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183140620-0x0000000183140810
		private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183140410-0x0000000183140620
		private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183140200-0x0000000183140410
		private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183140000-0x0000000183140200
		private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018313FE10-0x0000000183140000
		private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) => default; // 0x000000018313FBD0-0x000000018313FDF0
		private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313FA10-0x000000018313FBD0
		private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018313F840-0x000000018313F9E0
		private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) => default; // 0x000000018313D7B0-0x000000018313D920
		private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313D920-0x000000018313DAA0
		private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313DAA0-0x000000018313DC30
		private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313DC30-0x000000018313DDE0
		private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313DDE0-0x000000018313DF90
		private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313DF90-0x000000018313E140
		private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E140-0x000000018313E300
		private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E300-0x000000018313E4C0
		private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E4C0-0x000000018313E670
		private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E670-0x000000018313E800
		private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E800-0x000000018313E990
		private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313E990-0x000000018313EB40
		private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313EB40-0x000000018313ED00
		private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313ED00-0x000000018313EEC0
		private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313EEC0-0x000000018313F0A0
		private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313F0C0-0x000000018313F270
		private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313F270-0x000000018313F430
		private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313F430-0x000000018313F5C0
		private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313F5C0-0x000000018313F7E0
		protected new void OnNextUpdate() {} // 0x00000001822B8380-0x00000001822B84D0
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x00000001822B8A90-0x00000001822B8CA0
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018426F628-0x000000018426F630
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000184275AF0-0x0000000184275AF8
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x00000001822B9A00-0x00000001822B9B40
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x0000000184270144-0x0000000184270158
	}

	internal class FastTouchscreen : Touchscreen // TypeDefIndex: 44178
	{
		// Fields
		public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer"; // Metadata: 0x01FB661E
	
		// Constructors
		public FastTouchscreen() {} // 0x00000001831A01B0-0x00000001831A53D0
	
		// Methods
		private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183642520-0x00000001836426B0
		private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2A0C0-0x0000000183A2A280
		private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137600-0x00000001831377A0
		private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) => default; // 0x0000000183999070-0x0000000183999270
		private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A42EE0-0x0000000183A43080
		private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183144AE0-0x0000000183144CD0
		private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319F020-0x000000018319F3C0
		private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001836426B0-0x0000000183642840
		private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183642840-0x00000001836429D0
		private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001836429D0-0x0000000183642B60
		private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183642B60-0x0000000183642CF0
		private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183642CF0-0x0000000183642E80
		private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183642E80-0x0000000183643010
		private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183643010-0x00000001836431A0
		private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001836431A0-0x0000000183643330
		private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) => default; // 0x0000000183643330-0x00000001836434C0
		private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) => default; // 0x00000001836434C0-0x0000000183643650
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183A2E790-0x0000000183A2E950
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2E400-0x0000000183A2E5D0
		private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) => default; // 0x00000001831377A0-0x0000000183137940
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58B80-0x0000000183A58D10
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A46040-0x0000000183A46360
		private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A4A560-0x0000000183A4A700
		private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001831448F0-0x0000000183144AE0
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183A583B0-0x0000000183A58540
		private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183A58D10-0x0000000183A58EA0
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839DB4F0-0x00000001839DB6F0
		private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839DB2F0-0x00000001839DB4F0
		private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A4A3C0-0x0000000183A4A560
		private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2F520-0x0000000183A2F6D0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A487F0-0x0000000183A489A0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A48640-0x0000000183A487F0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B870-0x0000000183A2BA20
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23F90-0x0000000183A24150
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23DD0-0x0000000183A23F90
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2BA20-0x0000000183A2BBD0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A59030-0x0000000183A591C0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58EA0-0x0000000183A59030
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A589F0-0x0000000183A58B80
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58860-0x0000000183A589F0
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A586D0-0x0000000183A58860
		private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58540-0x0000000183A586D0
		private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A48B50-0x0000000183A48D00
		private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A489A0-0x0000000183A48B50
		private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2BBD0-0x0000000183A2BD80
		private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A24310-0x0000000183A244D0
		private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A24150-0x0000000183A24310
		private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2BD80-0x0000000183A2BF30
		private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A59350-0x0000000183A594E0
		private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A591C0-0x0000000183A59350
		private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58220-0x0000000183A583B0
		private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A58090-0x0000000183A58220
		private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183A345C0-0x0000000183A34780
		private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2E230-0x0000000183A2E400
		private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137940-0x0000000183137AE0
		private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57BE0-0x0000000183A57D70
		private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A45EA0-0x0000000183A46040
		private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A4A220-0x0000000183A4A3C0
		private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183144700-0x00000001831448F0
		private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183A57410-0x0000000183A575A0
		private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319C7D0-0x000000018319C960
		private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839DB0F0-0x00000001839DB2F0
		private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839FE450-0x00000001839FE640
		private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A4A080-0x0000000183A4A220
		private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2F370-0x0000000183A2F520
		private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A48490-0x0000000183A48640
		private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A482E0-0x0000000183A48490
		private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B510-0x0000000183A2B6C0
		private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23C10-0x0000000183A23DD0
		private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23A50-0x0000000183A23C10
		private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B6C0-0x0000000183A2B870
		private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57F00-0x0000000183A58090
		private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57D70-0x0000000183A57F00
		private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57A50-0x0000000183A57BE0
		private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A578C0-0x0000000183A57A50
		private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57730-0x0000000183A578C0
		private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A575A0-0x0000000183A57730
		private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319C960-0x000000018319CB20
		private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2E060-0x0000000183A2E230
		private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137AE0-0x0000000183137C80
		private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56F60-0x0000000183A570F0
		private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A45D00-0x0000000183A45EA0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A49EE0-0x0000000183A4A080
		private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183144510-0x0000000183144700
		private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319CB20-0x000000018319CCB0
		private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319CCB0-0x000000018319CE40
		private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839DAEF0-0x00000001839DB0F0
		private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839FE260-0x00000001839FE450
		private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A49D40-0x0000000183A49EE0
		private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2F1C0-0x0000000183A2F370
		private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A48130-0x0000000183A482E0
		private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A47F80-0x0000000183A48130
		private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B1B0-0x0000000183A2B360
		private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23890-0x0000000183A23A50
		private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A236D0-0x0000000183A23890
		private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B360-0x0000000183A2B510
		private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A57280-0x0000000183A57410
		private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A570F0-0x0000000183A57280
		private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56DD0-0x0000000183A56F60
		private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56C40-0x0000000183A56DD0
		private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56AB0-0x0000000183A56C40
		private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56920-0x0000000183A56AB0
		private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319CE40-0x000000018319D000
		private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2DE90-0x0000000183A2E060
		private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137C80-0x0000000183137E20
		private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56470-0x0000000183A56600
		private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A45B60-0x0000000183A45D00
		private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A49BA0-0x0000000183A49D40
		private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183144320-0x0000000183144510
		private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D000-0x000000018319D190
		private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D190-0x000000018319D320
		private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839DACF0-0x00000001839DAEF0
		private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001839FE070-0x00000001839FE260
		private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A49A00-0x0000000183A49BA0
		private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2F010-0x0000000183A2F1C0
		private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A47DD0-0x0000000183A47F80
		private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A47C20-0x0000000183A47DD0
		private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2AE50-0x0000000183A2B000
		private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23510-0x0000000183A236D0
		private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23350-0x0000000183A23510
		private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2B000-0x0000000183A2B1B0
		private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56790-0x0000000183A56920
		private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56600-0x0000000183A56790
		private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A562E0-0x0000000183A56470
		private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A56150-0x0000000183A562E0
		private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55FC0-0x0000000183A56150
		private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55E30-0x0000000183A55FC0
		private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D320-0x000000018319D4E0
		private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2DCC0-0x0000000183A2DE90
		private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137E20-0x0000000183137FC0
		private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55980-0x0000000183A55B10
		private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A459C0-0x0000000183A45B60
		private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A49860-0x0000000183A49A00
		private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183144130-0x0000000183144320
		private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D4E0-0x000000018319D670
		private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D670-0x000000018319D800
		private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143F30-0x0000000183144130
		private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143D40-0x0000000183143F30
		private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A496C0-0x0000000183A49860
		private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2EE60-0x0000000183A2F010
		private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A47A70-0x0000000183A47C20
		private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A478C0-0x0000000183A47A70
		private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2AAF0-0x0000000183A2ACA0
		private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A23190-0x0000000183A23350
		private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22FD0-0x0000000183A23190
		private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2ACA0-0x0000000183A2AE50
		private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55CA0-0x0000000183A55E30
		private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55B10-0x0000000183A55CA0
		private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A557F0-0x0000000183A55980
		private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55660-0x0000000183A557F0
		private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A554D0-0x0000000183A55660
		private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55340-0x0000000183A554D0
		private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D800-0x000000018319D9C0
		private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2DAF0-0x0000000183A2DCC0
		private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183137FC0-0x0000000183138160
		private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54E90-0x0000000183A55020
		private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A45820-0x0000000183A459C0
		private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A49520-0x0000000183A496C0
		private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183143B50-0x0000000183143D40
		private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319D9C0-0x000000018319DB50
		private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319DB50-0x000000018319DCE0
		private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143950-0x0000000183143B50
		private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143760-0x0000000183143950
		private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A49380-0x0000000183A49520
		private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2ECB0-0x0000000183A2EE60
		private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183139220-0x00000001831393D0
		private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001831393D0-0x0000000183139580
		private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2A790-0x0000000183A2A940
		private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22E10-0x0000000183A22FD0
		private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22C50-0x0000000183A22E10
		private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2A940-0x0000000183A2AAF0
		private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A551B0-0x0000000183A55340
		private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A55020-0x0000000183A551B0
		private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54D00-0x0000000183A54E90
		private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54B70-0x0000000183A54D00
		private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A549E0-0x0000000183A54B70
		private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54850-0x0000000183A549E0
		private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183139580-0x0000000183139740
		private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183139740-0x0000000183139910
		private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183138160-0x0000000183138300
		private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A543A0-0x0000000183A54530
		private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A45680-0x0000000183A45820
		private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A491E0-0x0000000183A49380
		private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183143570-0x0000000183143760
		private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319DCE0-0x000000018319DE70
		private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319DE70-0x000000018319E000
		private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143370-0x0000000183143570
		private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183143180-0x0000000183143370
		private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183A49040-0x0000000183A491E0
		private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A2EB00-0x0000000183A2ECB0
		private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183139910-0x0000000183139AC0
		private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183139AC0-0x0000000183139C70
		private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2A430-0x0000000183A2A5E0
		private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22A90-0x0000000183A22C50
		private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A228D0-0x0000000183A22A90
		private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2A5E0-0x0000000183A2A790
		private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A546C0-0x0000000183A54850
		private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54530-0x0000000183A546C0
		private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54210-0x0000000183A543A0
		private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A54080-0x0000000183A54210
		private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A53EF0-0x0000000183A54080
		private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A53D60-0x0000000183A53EF0
		private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x0000000183139C70-0x0000000183139E30
		private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183139E30-0x000000018313A000
		private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183138300-0x00000001831384A0
		private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A53BD0-0x0000000183A53D60
		private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183A454E0-0x0000000183A45680
		private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183A48EA0-0x0000000183A49040
		private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183142F90-0x0000000183143180
		private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319E000-0x000000018319E190
		private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319E190-0x000000018319E320
		private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183142D90-0x0000000183142F90
		private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183142BA0-0x0000000183142D90
		private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x00000001831350F0-0x0000000183135290
		private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183135290-0x0000000183135440
		private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313A000-0x000000018313A1B0
		private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313A1B0-0x000000018313A360
		private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A2A280-0x0000000183A2A430
		private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22710-0x0000000183A228D0
		private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183A22550-0x0000000183A22710
		private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135440-0x00000001831355F0
		private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001831355F0-0x0000000183135780
		private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135780-0x0000000183135910
		private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135910-0x0000000183135AA0
		private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135AA0-0x0000000183135C30
		private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135C30-0x0000000183135DC0
		private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135DC0-0x0000000183135F50
		private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313A360-0x000000018313A520
		private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018313A520-0x000000018313A6F0
		private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x00000001831384A0-0x0000000183138640
		private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183135F50-0x00000001831360E0
		private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) => default; // 0x00000001831360E0-0x0000000183136280
		private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183136280-0x0000000183136420
		private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001831429B0-0x0000000183142BA0
		private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319E320-0x000000018319E4B0
		private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319E4B0-0x000000018319E640
		private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001831427B0-0x00000001831429B0
		private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001831425C0-0x00000001831427B0
		private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183136420-0x00000001831365C0
		private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x00000001831365C0-0x0000000183136770
		private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313A6F0-0x000000018313A8A0
		private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313A8A0-0x000000018313AA50
		private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183136770-0x0000000183136920
		private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183136920-0x0000000183136AE0
		private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183136AE0-0x0000000183136CA0
		private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183136CA0-0x0000000183136E50
		private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183136E50-0x0000000183136FE0
		private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001831372E0-0x0000000183137470
		private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183137470-0x0000000183137600
		private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018319E6C0-0x000000018319E850
		private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018319E850-0x000000018319E9E0
		private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018319E9E0-0x000000018319EB70
		private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313AA50-0x000000018313AC10
		private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018313AC10-0x000000018313ADE0
		private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x0000000183138640-0x00000001831387E0
		private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018319EB70-0x000000018319ED00
		private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) => default; // 0x00000001831387E0-0x0000000183138980
		private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x0000000183138980-0x0000000183138B20
		private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x00000001831423D0-0x00000001831425C0
		private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319ED00-0x000000018319EE90
		private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018319EE90-0x000000018319F020
		private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001831421D0-0x00000001831423D0
		private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183141FE0-0x00000001831421D0
		private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x0000000183138B20-0x0000000183138CC0
		private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183138CC0-0x0000000183138E70
		private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313ADE0-0x000000018313AF90
		private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313AF90-0x000000018313B1A0
		private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183138E70-0x0000000183139020
		private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183139020-0x0000000183139200
		private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313B1E0-0x000000018313B3A0
		private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313B3A0-0x000000018313B550
		private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313B550-0x000000018313B6E0
		private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313B6E0-0x000000018313B870
		private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313B870-0x000000018313BA00
		private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313BA00-0x000000018313BB90
		private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313BB90-0x000000018313BD20
		private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313BD20-0x000000018313BEB0
		private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313BEB0-0x000000018313C070
		private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018313C070-0x000000018313C240
		private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) => default; // 0x000000018313C240-0x000000018313C3E0
		private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313C3E0-0x000000018313C570
		private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) => default; // 0x000000018313C570-0x000000018313C710
		private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) => default; // 0x000000018313C710-0x000000018313C8B0
		private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) => default; // 0x0000000183141DB0-0x0000000183141FE0
		private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313C8B0-0x000000018313CA40
		private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) => default; // 0x000000018313CA40-0x000000018313CBD0
		private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) => default; // 0x0000000183141BB0-0x0000000183141DB0
		private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) => default; // 0x00000001831419C0-0x0000000183141BB0
		private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) => default; // 0x000000018313CBD0-0x000000018313CD70
		private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) => default; // 0x0000000183141810-0x00000001831419C0
		private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313CD70-0x000000018313CF20
		private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183141660-0x0000000183141810
		private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313D0D0-0x000000018313D280
		private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313D280-0x000000018313D440
		private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313D440-0x000000018313D600
		private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) => default; // 0x000000018313D600-0x000000018313D7B0
		private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001831414D0-0x0000000183141660
		private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183141340-0x00000001831414D0
		private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) => default; // 0x00000001831411B0-0x0000000183141340
		private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183141020-0x00000001831411B0
		private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183140E90-0x0000000183141020
		private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent) => default; // 0x0000000183140D00-0x0000000183140E90
	}

	public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message> // TypeDefIndex: 44199
	{
		// Fields
		private Flags m_Flags; // 0x10
		private InputManager m_LocalManager; // 0x18
		private Subscriber[] m_Subscribers; // 0x20
		private RemoteSender[] m_Senders; // 0x28
	
		// Properties
		public bool sending { get => default; private set {} } // 0x000000018286E950-0x000000018286E960 0x0000000189BE7674-0x0000000189BE7690
		internal InputManager manager { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		public enum MessageType // TypeDefIndex: 44179
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
	
		public struct Message // TypeDefIndex: 44180
		{
			// Fields
			public int participantId; // 0x00
			public MessageType type; // 0x04
			public byte[] data; // 0x08
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 44181
		{
			Sending = 1,
			StartSendingOnConnect = 2
		}
	
		[Serializable]
		internal struct RemoteSender // TypeDefIndex: 44182
		{
			// Fields
			public int senderId; // 0x00
			public InternedString[] layouts; // 0x08
			public RemoteInputDevice[] devices; // 0x10
		}
	
		[Serializable]
		internal struct RemoteInputDevice // TypeDefIndex: 44183
		{
			// Fields
			public int remoteId; // 0x00
			public int localId; // 0x04
			public InputDeviceDescription description; // 0x08
		}
	
		internal class Subscriber : IDisposable // TypeDefIndex: 44184
		{
			// Fields
			public InputRemoting owner; // 0x10
			public IObserver<Message> observer; // 0x18
	
			// Constructors
			public Subscriber() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Dispose() {} // 0x0000000189BE9C34-0x0000000189BE9C80
		}
	
		private static class ConnectMsg // TypeDefIndex: 44185
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x0000000189BE2FC4-0x0000000189BE2FF8
		}
	
		private static class StartSendingMsg // TypeDefIndex: 44186
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x0000000189BE9A74-0x0000000189BE9A90
		}
	
		private static class StopSendingMsg // TypeDefIndex: 44187
		{
			// Methods
			public static void Process(InputRemoting receiver) {} // 0x0000000189BE9BCC-0x0000000189BE9BE8
		}
	
		private static class DisconnectMsg // TypeDefIndex: 44188
		{
			// Methods
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE2FF8-0x0000000189BE3078
		}
	
		private static class NewLayoutMsg // TypeDefIndex: 44190
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 44189
			{
				// Fields
				public string name; // 0x00
				public string layoutJson; // 0x08
				public bool isOverride; // 0x10
			}
	
			// Methods
			public static Message? Create(InputRemoting sender, string layoutName) => default; // 0x0000000189BE85CC-0x0000000189BE88A4
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE88A4-0x0000000189BE8980
		}
	
		private static class NewDeviceMsg // TypeDefIndex: 44193
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 44191
			{
				// Fields
				public string name; // 0x00
				public string layout; // 0x08
				public int deviceId; // 0x10
				public string[] usages; // 0x18
				public InputDeviceDescription description; // 0x20
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BE7A44-0x0000000189BE7CC8
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE7CC8-0x0000000189BE8278
		}
	
		private static class NewEventsMsg // TypeDefIndex: 44194
		{
			// Methods
			public static Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset) => default; // 0x0000000189BE8278-0x0000000189BE82EC
			public static Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BE82EC-0x0000000189BE83F4
			public static unsafe Message Create(InputEvent* events, int eventCount) => default; // 0x0000000189BE83F4-0x0000000189BE84DC
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE84DC-0x0000000189BE85CC
		}
	
		private static class ChangeUsageMsg // TypeDefIndex: 44197
		{
			// Nested types
			[Serializable]
			public struct Data // TypeDefIndex: 44195
			{
				// Fields
				public int deviceId; // 0x00
				public string[] usages; // 0x08
			}
	
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BE2A4C-0x0000000189BE2C2C
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE2C2C-0x0000000189BE2FC4
		}
	
		private static class RemoveDeviceMsg // TypeDefIndex: 44198
		{
			// Methods
			public static Message Create(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BE97FC-0x0000000189BE9878
			public static void Process(InputRemoting receiver, Message msg) {} // 0x0000000189BE9878-0x0000000189BE991C
		}
	
		// Constructors
		public InputRemoting() {} // Dummy constructor
		internal InputRemoting(InputManager manager, bool startSendingOnConnect = false /* Metadata: 0x01FB668F */) {} // 0x0000000189BE75F0-0x0000000189BE7674
	
		// Methods
		public void StartSending() {} // 0x0000000189BE7110-0x0000000189BE7274
		public void StopSending() {} // 0x0000000189BE7274-0x0000000189BE73CC
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) {} // 0x0000000189BE74B8-0x0000000189BE75C0
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) {} // 0x000000018350B670-0x000000018350B680
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() {} // 0x000000018350B670-0x000000018350B680
		public IDisposable Subscribe(IObserver<Message> observer) => default; // 0x0000000189BE73CC-0x0000000189BE74B8
		private void SendInitialMessages() {} // 0x0000000189BE6EA4-0x0000000189BE6EC4
		private void SendAllGeneratedLayouts() {} // 0x0000000189BE6BB4-0x0000000189BE6D18
		private void SendLayout(string layoutName) {} // 0x0000000189BE6FD8-0x0000000189BE7084
		private void SendAllDevices() {} // 0x0000000189BE6A6C-0x0000000189BE6BB4
		private void SendDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BE6DCC-0x0000000189BE6E54
		private void SendEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BE6E54-0x0000000189BE6EA4
		private void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000189BE6D18-0x0000000189BE6DCC
		private void SendLayoutChange(string layout, InputControlLayoutChange change) {} // 0x0000000189BE6EC4-0x0000000189BE6FD8
		private void Send(Message msg) {} // 0x0000000189BE7084-0x0000000189BE7110
		private int FindOrCreateSenderRecord(int senderId) => default; // 0x0000000189BE68B0-0x0000000189BE6988
		private static InternedString BuildLayoutNamespace(int senderId) => default; // 0x0000000189BE67C4-0x0000000189BE6844
		private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) => default; // 0x0000000189BE6844-0x0000000189BE68B0
		private UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) => default; // 0x0000000189BE75C0-0x0000000189BE75F0
		public void RemoveRemoteDevices(int participantId) {} // 0x0000000189BE6988-0x0000000189BE6A6C
		private static byte[] SerializeData<TData>(TData data) => default;
		private static TData DeserializeData<TData>(byte[] data) => default;
	}

	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 44201
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
		private class Subscriber : IDisposable // TypeDefIndex: 44200
		{
			// Fields
			public RemoteInputPlayerConnection owner; // 0x10
			public IObserver<InputRemoting.Message> observer; // 0x18
	
			// Constructors
			public Subscriber() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Dispose() {} // 0x0000000189BE9BE8-0x0000000189BE9C34
		}
	
		// Constructors
		public RemoteInputPlayerConnection() {} // 0x000000018286F540-0x000000018286F550
		static RemoteInputPlayerConnection() {} // 0x0000000189BE9624-0x0000000189BE97FC
	
		// Methods
		public void Bind(IEditorPlayerConnection connection, bool isConnected) {} // 0x0000000189BE8BF8-0x0000000189BE90B0
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer) => default; // 0x0000000189BE9378-0x0000000189BE94CC
		private void OnConnected(int id) {} // 0x0000000189BE90C0-0x0000000189BE9168
		private void OnDisconnected(int id) {} // 0x0000000189BE9168-0x0000000189BE9214
		private void OnNewDevice(MessageEventArgs args) {} // 0x0000000189BE9214-0x0000000189BE9224
		private void OnNewLayout(MessageEventArgs args) {} // 0x0000000189BE9234-0x0000000189BE9244
		private void OnNewEvents(MessageEventArgs args) {} // 0x0000000189BE9224-0x0000000189BE9234
		private void OnRemoveDevice(MessageEventArgs args) {} // 0x0000000189BE9244-0x0000000189BE9254
		private void OnChangeUsages(MessageEventArgs args) {} // 0x0000000189BE90B0-0x0000000189BE90C0
		private void OnStartSending(MessageEventArgs args) {} // 0x0000000189BE9254-0x0000000189BE9264
		private void OnStopSending(MessageEventArgs args) {} // 0x0000000189BE9264-0x0000000189BE9274
		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args) {} // 0x0000000189BE9274-0x0000000189BE9378
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg) {} // 0x0000000189BE94CC-0x0000000189BE9624
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) {} // 0x000000018350B670-0x000000018350B680
		void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() {} // 0x000000018350B670-0x000000018350B680
	}

	[InputControlLayout(isGenericTypeOfDevice = true)]
	public class Sensor : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 44202
	{
		// Properties
		public float samplingFrequency { get => default; set {} } // 0x0000000189BE991C-0x0000000189BE99FC 0x0000000189BE99FC-0x0000000189BE9A74
	
		// Constructors
		public Sensor() {} // 0x0000000184275C10-0x0000000184275C18
	}

	[InputControlLayout(stateType = typeof(AccelerometerState))]
	public class Accelerometer : Sensor // TypeDefIndex: 44203
	{
		// Properties
		public Vector3Control acceleration { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static Accelerometer current { get; private set; } // 0x0000000189BE274C-0x0000000189BE2784 0x0000000189BE2784-0x0000000189BE27D4
	
		// Constructors
		public Accelerometer() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE26F8-0x0000000189BE2700
		protected override void OnRemoved() {} // 0x0000000189BE2700-0x0000000189BE274C
		protected override void FinishSetup() {} // 0x0000000189BE2698-0x0000000189BE26F8
	}

	[InputControlLayout(stateType = typeof(GyroscopeState))]
	public class Gyroscope : Sensor // TypeDefIndex: 44204
	{
		// Properties
		public Vector3Control angularVelocity { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static Gyroscope current { get; private set; } // 0x0000000189BE3268-0x0000000189BE32A0 0x0000000189BE32A0-0x0000000189BE32F0
	
		// Constructors
		public Gyroscope() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE3214-0x0000000189BE321C
		protected override void OnRemoved() {} // 0x0000000189BE321C-0x0000000189BE3268
		protected override void FinishSetup() {} // 0x0000000189BE31B4-0x0000000189BE3214
	}

	[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
	public class GravitySensor : Sensor // TypeDefIndex: 44205
	{
		// Properties
		public Vector3Control gravity { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static GravitySensor current { get; private set; } // 0x0000000189BE312C-0x0000000189BE3164 0x0000000189BE3164-0x0000000189BE31B4
	
		// Constructors
		public GravitySensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BE3078-0x0000000189BE30D8
		public override void MakeCurrent() {} // 0x0000000189BE30D8-0x0000000189BE30E0
		protected override void OnRemoved() {} // 0x0000000189BE30E0-0x0000000189BE312C
	}

	[InputControlLayout(stateType = typeof(AttitudeState), displayName = "Attitude")]
	public class AttitudeSensor : Sensor // TypeDefIndex: 44206
	{
		// Properties
		public QuaternionControl attitude { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static AttitudeSensor current { get; private set; } // 0x0000000189BE29C4-0x0000000189BE29FC 0x0000000189BE29FC-0x0000000189BE2A4C
	
		// Constructors
		public AttitudeSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE2970-0x0000000189BE2978
		protected override void OnRemoved() {} // 0x0000000189BE2978-0x0000000189BE29C4
		protected override void FinishSetup() {} // 0x0000000189BE2910-0x0000000189BE2970
	}

	[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
	public class LinearAccelerationSensor : Sensor // TypeDefIndex: 44207
	{
		// Properties
		public Vector3Control acceleration { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static LinearAccelerationSensor current { get; private set; } // 0x0000000189BE7880-0x0000000189BE78B8 0x0000000189BE78B8-0x0000000189BE7908
	
		// Constructors
		public LinearAccelerationSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE782C-0x0000000189BE7834
		protected override void OnRemoved() {} // 0x0000000189BE7834-0x0000000189BE7880
		protected override void FinishSetup() {} // 0x0000000189BE77CC-0x0000000189BE782C
	}

	[InputControlLayout(displayName = "Magnetic Field")]
	public class MagneticFieldSensor : Sensor // TypeDefIndex: 44208
	{
		// Properties
		[InputControl(displayName = "Magnetic Field", noisy = true)]
		public Vector3Control magneticField { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static MagneticFieldSensor current { get; private set; } // 0x0000000189BE79BC-0x0000000189BE79F4 0x0000000189BE79F4-0x0000000189BE7A44
	
		// Constructors
		public MagneticFieldSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE7968-0x0000000189BE7970
		protected override void OnRemoved() {} // 0x0000000189BE7970-0x0000000189BE79BC
		protected override void FinishSetup() {} // 0x0000000189BE7908-0x0000000189BE7968
	}

	[InputControlLayout(displayName = "Light")]
	public class LightSensor : Sensor // TypeDefIndex: 44209
	{
		// Properties
		[InputControl(displayName = "Light Level", noisy = true)]
		public AxisControl lightLevel { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static LightSensor current { get; private set; } // 0x0000000189BE7744-0x0000000189BE777C 0x0000000189BE777C-0x0000000189BE77CC
	
		// Constructors
		public LightSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE76F0-0x0000000189BE76F8
		protected override void OnRemoved() {} // 0x0000000189BE76F8-0x0000000189BE7744
		protected override void FinishSetup() {} // 0x0000000189BE7690-0x0000000189BE76F0
	}

	[InputControlLayout(displayName = "Pressure")]
	public class PressureSensor : Sensor // TypeDefIndex: 44210
	{
		// Properties
		[InputControl(displayName = "Atmospheric Pressure", noisy = true)]
		public AxisControl atmosphericPressure { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static PressureSensor current { get; private set; } // 0x0000000189BE8A34-0x0000000189BE8A6C 0x0000000189BE8A6C-0x0000000189BE8ABC
	
		// Constructors
		public PressureSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE89E0-0x0000000189BE89E8
		protected override void OnRemoved() {} // 0x0000000189BE89E8-0x0000000189BE8A34
		protected override void FinishSetup() {} // 0x0000000189BE8980-0x0000000189BE89E0
	}

	[InputControlLayout(displayName = "Proximity")]
	public class ProximitySensor : Sensor // TypeDefIndex: 44211
	{
		// Properties
		[InputControl(displayName = "Distance", noisy = true)]
		public AxisControl distance { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static ProximitySensor current { get; private set; } // 0x0000000189BE8B70-0x0000000189BE8BA8 0x0000000189BE8BA8-0x0000000189BE8BF8
	
		// Constructors
		public ProximitySensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE8B1C-0x0000000189BE8B24
		protected override void OnRemoved() {} // 0x0000000189BE8B24-0x0000000189BE8B70
		protected override void FinishSetup() {} // 0x0000000189BE8ABC-0x0000000189BE8B1C
	}

	[InputControlLayout(displayName = "Humidity")]
	public class HumiditySensor : Sensor // TypeDefIndex: 44212
	{
		// Properties
		[InputControl(displayName = "Relative Humidity", noisy = true)]
		public AxisControl relativeHumidity { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static HumiditySensor current { get; private set; } // 0x0000000189BE34E0-0x0000000189BE3518 0x0000000189BE3518-0x0000000189BE3568
	
		// Constructors
		public HumiditySensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE348C-0x0000000189BE3494
		protected override void OnRemoved() {} // 0x0000000189BE3494-0x0000000189BE34E0
		protected override void FinishSetup() {} // 0x0000000189BE342C-0x0000000189BE348C
	}

	[InputControlLayout(displayName = "Ambient Temperature")]
	public class AmbientTemperatureSensor : Sensor // TypeDefIndex: 44213
	{
		// Properties
		[InputControl(displayName = "Ambient Temperature", noisy = true)]
		public AxisControl ambientTemperature { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static AmbientTemperatureSensor current { get; private set; } // 0x0000000189BE2888-0x0000000189BE28C0 0x0000000189BE28C0-0x0000000189BE2910
	
		// Constructors
		public AmbientTemperatureSensor() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE2834-0x0000000189BE283C
		protected override void OnRemoved() {} // 0x0000000189BE283C-0x0000000189BE2888
		protected override void FinishSetup() {} // 0x0000000189BE27D4-0x0000000189BE2834
	}

	[InputControlLayout(displayName = "Step Counter")]
	public class StepCounter : Sensor // TypeDefIndex: 44214
	{
		// Properties
		[InputControl(displayName = "Step Counter", noisy = true)]
		public IntegerControl stepCounter { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static StepCounter current { get; private set; } // 0x0000000189BE9B44-0x0000000189BE9B7C 0x0000000189BE9B7C-0x0000000189BE9BCC
	
		// Constructors
		public StepCounter() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE9AF0-0x0000000189BE9AF8
		protected override void OnRemoved() {} // 0x0000000189BE9AF8-0x0000000189BE9B44
		protected override void FinishSetup() {} // 0x0000000189BE9A90-0x0000000189BE9AF0
	}

	[InputControlLayout(displayName = "Hinge Angle")]
	public class HingeAngle : Sensor // TypeDefIndex: 44215
	{
		// Properties
		public AxisControl angle { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public static HingeAngle current { get; private set; } // 0x0000000189BE33A4-0x0000000189BE33DC 0x0000000189BE33DC-0x0000000189BE342C
	
		// Constructors
		public HingeAngle() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189BE3350-0x0000000189BE3358
		protected override void OnRemoved() {} // 0x0000000189BE3358-0x0000000189BE33A4
		protected override void FinishSetup() {} // 0x0000000189BE32F0-0x0000000189BE3350
	}

	public enum TouchPhase // TypeDefIndex: 44216
	{
		None = 0,
		Began = 1,
		Moved = 2,
		Ended = 3,
		Canceled = 4,
		Stationary = 5
	}

	[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
	public class Touchscreen : UnityEngine.InputSystem.Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset // TypeDefIndex: 44217
	{
		// Fields
		private static readonly ProfilerMarker k_TouchscreenUpdateMarker; // 0x00
		private static readonly ProfilerMarker k_TouchAllocateMarker; // 0x08
		internal static float s_TapTime; // 0x18
		internal static float s_TapDelayTime; // 0x1C
		internal static float s_TapRadiusSquared; // 0x20
	
		// Properties
		public TouchControl primaryTouch { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public ReadOnlyArray<TouchControl> touches { get; protected set; } // 0x0000000183D77280-0x0000000183D77290 0x0000000189BEACB4-0x0000000189BEACCC
		protected TouchControl[] touchControlArray { get => default; set {} } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000183D044C0-0x0000000183D04540
		public static new Touchscreen current { get; internal set; } // 0x0000000189BEAC04-0x0000000189BEAC54 0x0000000189BEAC54-0x0000000189BEACB4
	
		// Constructors
		public Touchscreen() {} // 0x0000000184275C10-0x0000000184275C18
		static Touchscreen() {} // 0x0000000183CB9F00-0x0000000183CB9FA0
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000183108C10-0x0000000183108C60
		protected override void OnRemoved() {} // 0x0000000189BEA0FC-0x0000000189BEA15C
		protected override void FinishSetup() {} // 0x0000000189BE9C80-0x0000000189BEA018
		protected new void OnNextUpdate() {} // 0x00000001822BBFF0-0x00000001822BC250
		protected new void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BEA15C-0x0000000189BEA8BC
		new void IInputStateCallbackReceiver.OnNextUpdate() {} // 0x000000018426F620-0x000000018426F628
		new void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189BEABFC-0x0000000189BEAC04
		new bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x0000000189BEA9B0-0x0000000189BEABFC
		void ICustomDeviceReset.Reset() {} // 0x0000000182CAEFC0-0x0000000182CAF5C0
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x0000000189BEA018-0x0000000189BEA0FC
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x0000000189BEA954-0x0000000189BEA9B0
		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) {} // 0x0000000189BEA8BC-0x0000000189BEA954
	}

	[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = true)]
	public class TrackedDevice : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 44218
	{
		// Properties
		[InputControl(synthetic = true)]
		public IntegerControl trackingState { get; protected set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		[InputControl(synthetic = true)]
		public ButtonControl isTracked { get; protected set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		[InputControl(noisy = true, dontReset = true)]
		public Vector3Control devicePosition { get; protected set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		[InputControl(noisy = true, dontReset = true)]
		public QuaternionControl deviceRotation { get; protected set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
	
		// Constructors
		public TrackedDevice() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BEACCC-0x0000000189BEADF0
	}

	public static class InputExtensions // TypeDefIndex: 44219
	{
		// Extension methods
		public static bool IsInProgress(this InputActionPhase phase) => default; // 0x00000001822BF410-0x00000001822BF420
		public static bool IsEndedOrCanceled(this UnityEngine.InputSystem.TouchPhase phase) => default; // 0x0000000189BE3568-0x0000000189BE3578
		public static bool IsActive(this UnityEngine.InputSystem.TouchPhase phase) => default; // 0x0000000182CAF5C0-0x0000000182CAF5E0
		public static bool IsModifierKey(this UnityEngine.InputSystem.Key key) => default; // 0x0000000189BE3578-0x0000000189BE3584
		public static bool IsTextInputKey(this UnityEngine.InputSystem.Key key) => default; // 0x0000000189BE3584-0x0000000189BE35A0
	}

	internal static class InputFeatureNames // TypeDefIndex: 44220
	{
		// Fields
		public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE"; // Metadata: 0x01FB66A2
		public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT"; // Metadata: 0x01FB66C2
		public const string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS"; // Metadata: 0x01FB66DF
		public const string kUseReadValueCaching = "USE_READ_VALUE_CACHING"; // Metadata: 0x01FB66F6
		public const string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS"; // Metadata: 0x01FB670D
	}

	internal class InputManager // TypeDefIndex: 44229
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
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x0000000182CAC5C0-0x0000000182CAC620 
		public TypeTable processors { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public TypeTable interactions { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public TypeTable composites { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public InputMetrics metrics { get => default; } // 0x0000000189BE624C-0x0000000189BE63D0 
		public InputSettings settings { get => default; set {} } // 0x0000000183D57100-0x0000000183D57110 0x0000000189BE66D0-0x0000000189BE67C4
		public InputUpdateType updateMask { get => default; set {} } // 0x0000000183D51860-0x0000000183D51870 0x0000000182CAC630-0x0000000182CAC660
		public InputUpdateType defaultUpdateType { get => default; } // 0x000000018235D640-0x000000018235D660 
		public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get => default; set {} } // 0x0000000183D51150-0x0000000183D51160 0x0000000182CAC620-0x0000000182CAC630
		public float pollingFrequency { get => default; set {} } // 0x0000000183D51930-0x0000000183D51940 0x0000000189BE6630-0x0000000189BE66D0
		public bool isProcessingEvents { get => default; } // 0x0000000183D77210-0x0000000183D77220 
		private bool gameIsPlaying { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		private bool gameHasFocus { get => default; } // 0x00000001824B17A0-0x00000001824B17E0 
		private bool gameShouldGetInputRegardlessOfFocus { get => default; } // 0x00000001831EB800-0x00000001831EB830 
		internal bool optimizedControlsFeatureEnabled { get => default; set {} } // 0x0000000183D77220-0x0000000183D77230 0x0000000183D77250-0x0000000183D77260
		internal bool readValueCachingFeatureEnabled { get => default; set {} } // 0x0000000183D77240-0x0000000183D77250 0x0000000183D77270-0x0000000183D77280
		internal bool paranoidReadValueCachingChecksEnabled { get => default; set {} } // 0x0000000183D77230-0x0000000183D77240 0x0000000183D77260-0x0000000183D77270
	
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
		internal enum DeviceDisableScope // TypeDefIndex: 44221
		{
			Everywhere = 0,
			InFrontendOnly = 1,
			TemporaryWhilePlayerIsInBackground = 2
		}
	
		[Serializable]
		internal struct AvailableDevice // TypeDefIndex: 44222
		{
			// Fields
			public InputDeviceDescription description; // 0x00
			public int deviceId; // 0x38
			public bool isNative; // 0x3C
			public bool isRemoved; // 0x3D
		}
	
		private struct StateChangeMonitorTimeout // TypeDefIndex: 44223
		{
			// Fields
			public InputControl control; // 0x00
			public double time; // 0x08
			public IInputStateChangeMonitor monitor; // 0x10
			public long monitorIndex; // 0x18
			public int timerIndex; // 0x20
		}
	
		internal struct StateChangeMonitorListener // TypeDefIndex: 44224
		{
			// Fields
			public InputControl control; // 0x00
			public IInputStateChangeMonitor monitor; // 0x08
			public long monitorIndex; // 0x10
			public uint groupIndex; // 0x18
		}
	
		internal struct StateChangeMonitorsForDevice // TypeDefIndex: 44225
		{
			// Fields
			public MemoryHelpers.BitRegion[] memoryRegions; // 0x00
			public StateChangeMonitorListener[] listeners; // 0x08
			public DynamicBitfield signalled; // 0x10
			public bool needToUpdateOrderingOfMonitors; // 0x30
			public bool needToCompactArrays; // 0x31
	
			// Properties
			public int count { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
			// Methods
			public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) {} // 0x0000000182EB89F0-0x0000000182EB8B90
			public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval) {} // 0x0000000189BFCD58-0x0000000189BFCE4C
			public void Clear() {} // 0x0000000189BFCC20-0x0000000189BFCC70
			public void CompactArrays() {} // 0x0000000189BFCC70-0x0000000189BFCCCC
			private void RemoveAt(int i) {} // 0x0000000189BFCCCC-0x0000000189BFCD58
			public void SortMonitorsByIndex() {} // 0x00000001838C00C0-0x00000001838C0190
		}
	
		// Constructors
		public InputManager() {} // 0x000000018350B670-0x000000018350B680
		static InputManager() {} // 0x00000001838CE5D0-0x00000001838CE8F0
	
		// Methods
		public void RegisterControlLayout(string name, System.Type type) {} // 0x00000001822FA3A0-0x00000001822FACF0
		public void RegisterControlLayout(string json, string name = null, bool isOverride = false /* Metadata: 0x01FB6730 */) {} // 0x0000000182F179C0-0x0000000182F17C20
		public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null) {} // 0x0000000189BE4AB4-0x0000000189BE4CC4
		private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false /* Metadata: 0x01FB6731 */, bool isOverride = false /* Metadata: 0x01FB6732 */) {} // 0x00000001822FB250-0x00000001822FB660
		public void RegisterPrecompiledLayout<TDevice>(string metadata)
			where TDevice : UnityEngine.InputSystem.InputDevice, new() {}
		private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false /* Metadata: 0x01FB6733 */) {} // 0x00000001822FADD0-0x00000001822FAFD0
		private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) => default; // 0x0000000189BE4218-0x0000000189BE42FC
		private bool IsControlUsingLayout(InputControl control, InternedString layout) => default; // 0x0000000189BE42FC-0x0000000189BE43C0
		public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) {} // 0x00000001823602B0-0x00000001823603A0
		public void RegisterControlLayoutMatcher(System.Type type, InputDeviceMatcher matcher) {} // 0x00000001822F87B0-0x00000001822F88D0
		private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) {} // 0x000000018235FF30-0x00000001823601C0
		private void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, InternedString newLayout) {} // 0x0000000189BE4928-0x0000000189BE4AB4
		private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) {} // 0x00000001823601C0-0x00000001823602B0
		public void RemoveControlLayout(string name) {} // 0x0000000189BE4CC4-0x0000000189BE4F30
		public InputControlLayout TryLoadControlLayout(System.Type type) => default; // 0x0000000189BE5CCC-0x0000000189BE5F1C
		public InputControlLayout TryLoadControlLayout(InternedString name) => default; // 0x0000000189BE5CA4-0x0000000189BE5CCC
		public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0 /* Metadata: 0x01FB6734 */) => default; // 0x000000018235F690-0x000000018235FEB0
		private InternedString FindOrRegisterDeviceLayoutForType(System.Type type) => default; // 0x00000001822F85B0-0x00000001822F8610
		private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) => default; // 0x0000000189BE43C0-0x0000000189BE44D4
		[IteratorStateMachine(typeof(_ListControlLayouts_d__91))]
		public IEnumerable<string> ListControlLayouts(string basedOn = null) => default; // 0x0000000189BE44D4-0x0000000189BE455C
		public int GetControls<TControl>(string path, ref InputControlList<TControl> controls)
			where TControl : InputControl => default;
		public void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BE591C-0x0000000189BE5A80
		public void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BE35A0-0x0000000189BE3704
		public void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, InternedString usage) {} // 0x0000000189BE4F30-0x0000000189BE5094
		private void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BE47DC-0x0000000189BE489C
		public UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name = null) => default; // 0x0000000189BE3874-0x0000000189BE3968
		public UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, InternedString variants = default) => default; // 0x0000000189BE3968-0x0000000189BE3AC8
		private UnityEngine.InputSystem.InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = default, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x01FB6735 */, InternedString variants = default) => default; // 0x000000018235E850-0x000000018235EAD0
		public void AddDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018235CFF0-0x000000018235D3D0
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description) => default; // 0x0000000189BE3AC8-0x0000000189BE3B1C
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0 /* Metadata: 0x01FB6736 */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x01FB6737 */) => default; // 0x000000018235F4E0-0x000000018235F690
		public UnityEngine.InputSystem.InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0 /* Metadata: 0x01FB6738 */, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags =  /* Metadata: 0x01FB6739 */) => default; // 0x0000000189BE3704-0x0000000189BE3874
		public void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices = false /* Metadata: 0x01FB673A */) {} // 0x0000000189BE5094-0x0000000189BE54A8
		public void FlushDisconnectedDevices() {} // 0x0000000189BE3E3C-0x0000000189BE3E8C
		public void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false /* Metadata: 0x01FB673B */, bool? issueResetCommand = default) {} // 0x0000000182CAFFC0-0x0000000182CB06F0
		public UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout) => default; // 0x0000000189BE5B38-0x0000000189BE5C50
		public UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout) => default; // 0x0000000189BE3E8C-0x0000000189BE3F3C
		public UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType) => default; // 0x0000000189BE5C50-0x0000000189BE5CA4
		public UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id) => default; // 0x00000001824AF690-0x00000001824AF7D0
		public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) => default; // 0x0000000189BE3F3C-0x0000000189BE4084
		public void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, DeviceDisableScope scope = DeviceDisableScope.Everywhere /* Metadata: 0x01FB673C */) {} // 0x0000000182CB08E0-0x0000000182CB0AB0
		private unsafe void QueueEvent(InputEvent* eventPtr) {} // 0x0000000189BE489C-0x0000000189BE4928
		public void QueueEvent(InputEventPtr ptr) {} // 0x000000018636D860-0x000000018636D868
		public void QueueEvent<TEvent>(ref ref TEvent inputEvent)
			where TEvent : struct, IInputEventTypeInfo {}
		public void Update() {} // 0x0000000189BE60F8-0x0000000189BE611C
		public void Update(InputUpdateType updateType) {} // 0x0000000183A4FD80-0x0000000183A4FDF0
		internal void Initialize(IInputRuntime runtime, InputSettings settings) {} // 0x0000000182F18110-0x0000000182F18170
		internal void Destroy() {} // 0x0000000189BE3D58-0x0000000189BE3E3C
		internal void InitializeData() {} // 0x00000001822F8CA0-0x00000001822F9E70
		private void RegisterCustomTypes(System.Type[] types) {} // 0x00000001824D94F0-0x00000001824D9700
		private void RegisterCustomTypes() {} // 0x00000001826792C0-0x00000001826794B0
		internal void InstallRuntime(IInputRuntime runtime) {} // 0x0000000182EB5D50-0x0000000182EB62A0
		internal void InstallGlobals() {} // 0x0000000182F176A0-0x0000000182F17930
		internal void UninstallGlobals() {} // 0x0000000189BE5F1C-0x0000000189BE60F8
		private void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018235DC60-0x000000018235DE90
		private static void ResetControlPathsRecursive(InputControl control) {} // 0x0000000189BE5850-0x0000000189BE591C
		private void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device) {} // 0x000000018235D3E0-0x000000018235D430
		private void ReallocateStateBuffers() {} // 0x000000018235D430-0x000000018235D640
		private void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BE4084-0x0000000189BE4218
		private void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device) {} // 0x00000001822FC1F0-0x00000001822FC520
		private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) {} // 0x000000018235EBB0-0x000000018235F2A0
		private JsonParser.JsonString MakeEscapedJsonString(string theString) => default; // 0x0000000189BE455C-0x0000000189BE46AC
		private UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) => default; // 0x000000018235F300-0x000000018235F3D0
		private void InstallBeforeUpdateHookIfNecessary() {} // 0x000000018235CF20-0x000000018235CFD0
		private void RestoreDevicesAfterDomainReloadIfNecessary() {} // 0x000000018350B670-0x000000018350B680
		private void WarnAboutDevicesFailingToRecreateAfterDomainReload() {} // 0x000000018350B670-0x000000018350B680
		private void OnBeforeUpdate(InputUpdateType updateType) {} // 0x00000001822BAC20-0x00000001822BAEC0
		internal void ApplySettings() {} // 0x0000000182CAB8C0-0x0000000182CAC5C0
		internal long ExecuteGlobalCommand<TCommand>(ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default;
		internal void AddAvailableDevicesThatAreNowRecognized() {} // 0x0000000182CACA10-0x0000000182CACAB0
		private bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000182CB0B20-0x0000000182CB0B60
		internal void OnFocusChanged(bool focus) {} // 0x0000000182CB0710-0x0000000182CB08E0
		internal bool ShouldRunUpdate(InputUpdateType updateType) => default; // 0x0000000183107590-0x00000001831075B0
		private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) {} // 0x00000001824AFE80-0x00000001824B0C70
		private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed) => default; // 0x0000000183166170-0x0000000183166200
		private string MakeStringWithEventsProcessedByDevice() => default; // 0x0000000189BE46AC-0x0000000189BE47DC
		private void ResetCurrentProcessedEventBytesForDevices() {} // 0x00000001831703A0-0x0000000183170400
		[Conditional("UNITY_EDITOR")]
		private void CheckAllDevicesOptimizedControlsHaveValidState() {} // 0x0000000189BE3BF0-0x0000000189BE3D58
		private void InvokeAfterUpdateCallback(InputUpdateType updateType) {} // 0x00000001824B1970-0x00000001824B1A10
		internal void DontMakeCurrentlyUpdatingDeviceCurrent() {} // 0x0000000183D77200-0x0000000183D77210
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) => default; // 0x00000001822B8060-0x00000001822B8160
		internal unsafe bool UpdateState(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = default) => default; // 0x00000001822B9F30-0x00000001822BA720
		private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers) {} // 0x00000001822BA720-0x00000001822BA940
		private bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, InputUpdateType updateType) => default; // 0x00000001822BB490-0x00000001822BB5B0
		public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) {} // 0x0000000182EB88A0-0x0000000182EB89F0
		private void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BE5730-0x0000000189BE5850
		public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) {} // 0x0000000189BE55C8-0x0000000189BE5730
		public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) {} // 0x0000000189BE3B1C-0x0000000189BE3BF0
		public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) {} // 0x0000000189BE54A8-0x0000000189BE55C8
		private void SortStateChangeMonitorsIfNecessary(int deviceIndex) {} // 0x00000001822BAEE0-0x00000001822BAF40
		public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) {} // 0x0000000189BE5A80-0x0000000189BE5B38
		public void FireStateChangeNotifications() {} // 0x0000000183B2EAD0-0x0000000183B2EBA0
		private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) => default; // 0x00000001822BAF40-0x00000001822BB340
		internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) {} // 0x00000001822BB820-0x00000001822BBBE0
		private void ProcessStateChangeMonitorTimeouts() {} // 0x00000001824B1870-0x00000001824B18E0
	}

	public class InputSettings : ScriptableObject // TypeDefIndex: 44235
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
		internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; // Metadata: 0x01FB6740
	
		// Properties
		public UpdateMode updateMode { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000189BED070-0x0000000189BED080
		public ScrollDeltaBehavior scrollDeltaBehavior { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000189BECF00-0x0000000189BECF10
		public bool compensateForScreenOrientation { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000189BECDC0-0x0000000189BECDD0
		[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", false)]
		public bool filterNoiseOnCurrent { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
		public float defaultDeadzoneMin { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000189BECE24-0x0000000189BECE40
		public float defaultDeadzoneMax { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000189BECE08-0x0000000189BECE24
		public float defaultButtonPressPoint { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000189BECDD0-0x0000000189BECE08
		public float buttonReleaseThreshold { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000189BECDA4-0x0000000189BECDC0
		public float defaultTapTime { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000189BECE78-0x0000000189BECE94
		public float defaultSlowTapTime { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000189BECE5C-0x0000000189BECE78
		public float defaultHoldTime { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x0000000189BECE40-0x0000000189BECE5C
		public float tapRadius { get => default; set {} } // 0x0000000183D56C10-0x0000000183D56C20 0x0000000189BED054-0x0000000189BED070
		public float multiTapDelayTime { get => default; set {} } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000189BECEE4-0x0000000189BECF00
		public BackgroundBehavior backgroundBehavior { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000189BECD94-0x0000000189BECDA4
		public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000189BECEA4-0x0000000189BECEB4
		public InputActionPropertyDrawerMode inputActionPropertyDrawerMode { get => default; set {} } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000189BECEB4-0x0000000189BECEC4
		public int maxEventBytesPerUpdate { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000189BECEC4-0x0000000189BECED4
		public int maxQueuedEventsPerUpdate { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000189BECED4-0x0000000189BECEE4
		public ReadOnlyArray<string> supportedDevices { get => default; set {} } // 0x000000018235F2A0-0x000000018235F300 0x0000000189BECF20-0x0000000189BED054
		public bool disableRedundantEventsMerging { get => default; set {} } // 0x0000000183D590F0-0x0000000183D59100 0x0000000189BECE94-0x0000000189BECEA4
		public bool shortcutKeysConsumeInput { get => default; set {} } // 0x0000000183D5CA70-0x0000000183D5CA80 0x0000000189BECF10-0x0000000189BECF20
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 44230
		{
			ProcessEventsInDynamicUpdate = 1,
			ProcessEventsInFixedUpdate = 2,
			ProcessEventsManually = 3
		}
	
		public enum ScrollDeltaBehavior // TypeDefIndex: 44231
		{
			UniformAcrossAllPlatforms = 0,
			KeepPlatformSpecificInputRange = 1
		}
	
		public enum BackgroundBehavior // TypeDefIndex: 44232
		{
			ResetAndDisableNonBackgroundDevices = 0,
			ResetAndDisableAllDevices = 1,
			IgnoreFocus = 2
		}
	
		public enum EditorInputBehaviorInPlayMode // TypeDefIndex: 44233
		{
			PointersAndKeyboardsRespectGameViewFocus = 0,
			AllDevicesRespectGameViewFocus = 1,
			AllDeviceInputAlwaysGoesToGameView = 2
		}
	
		public enum InputActionPropertyDrawerMode // TypeDefIndex: 44234
		{
			Compact = 0,
			MultilineEffective = 1,
			MultilineBoth = 2
		}
	
		// Constructors
		public InputSettings() {} // 0x0000000183D21C20-0x0000000183D21C80
	
		// Methods
		public void SetInternalFeatureFlag(string featureName, bool enabled) {} // 0x0000000189BECC34-0x0000000189BECD94
		internal bool IsFeatureEnabled(string featureName) => default; // 0x0000000189BECB20-0x0000000189BECB90
		internal void OnChange() {} // 0x0000000189BECB90-0x0000000189BECC34
		private static bool CompareFloats(float a, float b) => default; // 0x0000000189BECB0C-0x0000000189BECB20
		private static bool CompareSets<T>(ReadOnlyArray<T> a, ReadOnlyArray<T> b) => default;
		private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) => default; // 0x0000000189BECAB4-0x0000000189BECB0C
		internal static bool AreEqual(InputSettings a, InputSettings b) => default; // 0x0000000189BEC828-0x0000000189BECAB4
	}

	public class DefaultInputActions : IInputActionCollection2, IDisposable // TypeDefIndex: 44240
	{
		// Fields
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
		public InputActionAsset asset { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public InputBinding? bindingMask { get => default; set {} } // 0x0000000189BEC178-0x0000000189BEC1C8 0x0000000189BEC25C-0x0000000189BEC2BC
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices { get => default; set {} } // 0x0000000189BEC21C-0x0000000189BEC25C 0x0000000189BEC2BC-0x0000000189BEC2F4
		public ReadOnlyArray<InputControlScheme> controlSchemes { get => default; } // 0x0000000189BEC1E8-0x0000000189BEC21C 
		public IEnumerable<InputBinding> bindings { get => default; } // 0x0000000189BEC1C8-0x0000000189BEC1E8 
		public PlayerActions Player { get => default; } // 0x0000000182712100-0x0000000182712120 
		public UIActions UI { get => default; } // 0x0000000182712100-0x0000000182712120 
		public InputControlScheme KeyboardMouseScheme { get => default; } // 0x0000000189BEBF2C-0x0000000189BEBFF0 
		public InputControlScheme GamepadScheme { get => default; } // 0x0000000189BEBDA4-0x0000000189BEBE68 
		public InputControlScheme TouchScheme { get => default; } // 0x0000000189BEBFF0-0x0000000189BEC0B4 
		public InputControlScheme JoystickScheme { get => default; } // 0x0000000189BEBE68-0x0000000189BEBF2C 
		public InputControlScheme XRScheme { get => default; } // 0x0000000189BEC0B4-0x0000000189BEC178 
	
		// Nested types
		public struct PlayerActions // TypeDefIndex: 44236
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Move { get => default; } // 0x000000018992910C-0x0000000189929128 
			public InputAction Look { get => default; } // 0x0000000189BF49A0-0x0000000189BF49BC 
			public InputAction Fire { get => default; } // 0x0000000189BF4984-0x0000000189BF49A0 
			public bool enabled { get => default; } // 0x0000000189BF49BC-0x0000000189BF49E0 
	
			// Constructors
			public PlayerActions(DefaultInputActions wrapper) : this() {
				m_Wrapper = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			public InputActionMap Get() => default; // 0x0000000189929330-0x000000018992934C
			public void Enable() {} // 0x0000000189BF4178-0x0000000189BF419C
			public void Disable() {} // 0x0000000189BF4154-0x0000000189BF4178
			public static implicit operator InputActionMap(PlayerActions set) => default; // 0x0000000189BF49E0-0x0000000189BF49FC
			public void SetCallbacks(IPlayerActions instance) {} // 0x0000000189BF419C-0x0000000189BF4984
		}
	
		public struct UIActions // TypeDefIndex: 44237
		{
			// Fields
			private DefaultInputActions m_Wrapper; // 0x00
	
			// Properties
			public InputAction Navigate { get => default; } // 0x0000000189C01074-0x0000000189C01090 
			public InputAction Submit { get => default; } // 0x000000018992934C-0x0000000189929368 
			public InputAction Cancel { get => default; } // 0x0000000189C0101C-0x0000000189C01038 
			public InputAction Point { get => default; } // 0x0000000189C01090-0x0000000189C010AC 
			public InputAction Click { get => default; } // 0x0000000189C01038-0x0000000189C01054 
			public InputAction ScrollWheel { get => default; } // 0x0000000189C010CC-0x0000000189C010E8 
			public InputAction MiddleClick { get => default; } // 0x0000000189C01054-0x0000000189C01074 
			public InputAction RightClick { get => default; } // 0x0000000189C010AC-0x0000000189C010CC 
			public InputAction TrackedDevicePosition { get => default; } // 0x0000000189C01108-0x0000000189C01128 
			public InputAction TrackedDeviceOrientation { get => default; } // 0x0000000189C010E8-0x0000000189C01108 
			public bool enabled { get => default; } // 0x0000000189C01128-0x0000000189C0114C 
	
			// Constructors
			public UIActions(DefaultInputActions wrapper) : this() {
				m_Wrapper = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			public InputActionMap Get() => default; // 0x0000000189BFF6E8-0x0000000189BFF704
			public void Enable() {} // 0x0000000189BFF6C4-0x0000000189BFF6E8
			public void Disable() {} // 0x0000000189BFF6A0-0x0000000189BFF6C4
			public static implicit operator InputActionMap(UIActions set) => default; // 0x0000000189C0114C-0x0000000189C01168
			public void SetCallbacks(IUIActions instance) {} // 0x0000000189BFF704-0x0000000189C0101C
		}
	
		public interface IPlayerActions // TypeDefIndex: 44238
		{
			// Methods
			void OnMove(InputAction.CallbackContext context);
			void OnLook(InputAction.CallbackContext context);
			void OnFire(InputAction.CallbackContext context);
		}
	
		public interface IUIActions // TypeDefIndex: 44239
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
		public DefaultInputActions() {} // 0x0000000189BEB9DC-0x0000000189BEBDA4
	
		// Methods
		public void Dispose() {} // 0x0000000189BEB8C0-0x0000000189BEB910
		public bool Contains(InputAction action) => default; // 0x0000000189BEB880-0x0000000189BEB8A0
		public IEnumerator<InputAction> GetEnumerator() => default; // 0x0000000189BEB9B4-0x0000000189BEB9D4
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BEB9D4-0x0000000189BEB9DC
		public void Enable() {} // 0x0000000189BEB910-0x0000000189BEB930
		public void Disable() {} // 0x0000000189BEB8A0-0x0000000189BEB8C0
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false /* Metadata: 0x01FB674F */) => default; // 0x0000000189BEB930-0x0000000189BEB950
		public int FindBinding(InputBinding bindingMask, out InputAction action) {
			action = default;
			return default;
		} // 0x0000000189BEB950-0x0000000189BEB9B4
	}

	[DebuggerDisplay("Value = {Get()}")]
	public class InputValue // TypeDefIndex: 44241
	{
		// Fields
		internal InputAction.CallbackContext? m_Context; // 0x10
	
		// Properties
		public bool isPressed { get => default; } // 0x0000000189BF40F8-0x0000000189BF4154 
	
		// Constructors
		public InputValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public object Get() => default; // 0x0000000189BF40A0-0x0000000189BF40F8
		public TValue Get<TValue>()
			where TValue : struct => default;
	}

	[AddComponentMenu("Input/Player Input")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInput.html")]
	public class PlayerInput : MonoBehaviour // TypeDefIndex: 44246
	{
		// Fields
		public const string DeviceLostMessage = "OnDeviceLost"; // Metadata: 0x01FB6754
		public const string DeviceRegainedMessage = "OnDeviceRegained"; // Metadata: 0x01FB6761
		public const string ControlsChangedMessage = "OnControlsChanged"; // Metadata: 0x01FB6772
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
		public bool inputIsActive { get => default; } // 0x0000000183D6CD80-0x0000000183D6CD90 
		[Obsolete("Use inputIsActive instead.")]
		public bool active { get => default; } // 0x0000000183D6CD80-0x0000000183D6CD90 
		public int playerIndex { get => default; } // 0x0000000183D4FB60-0x0000000183D4FB70 
		public int splitScreenIndex { get => default; } // 0x0000000183D4F0C0-0x0000000183D4F0D0 
		public InputActionAsset actions { get => default; set {} } // 0x0000000189BFB6A8-0x0000000189BFB6F0 0x0000000189BFBE04-0x0000000189BFBF34
		public string currentControlScheme { get => default; } // 0x0000000189BFB7D8-0x0000000189BFB874 
		public string defaultControlScheme { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public bool neverAutoSwitchControlSchemes { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000189BFBFA0-0x0000000189BFBFE4
		public InputActionMap currentActionMap { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000189BFBF34-0x0000000189BFBFA0
		public string defaultActionMap { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public PlayerNotifications notificationBehavior { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000189BFBFE4-0x0000000189BFC02C
		public ReadOnlyArray<ActionEvent> actionEvents { get => default; set {} } // 0x0000000189BFB650-0x0000000189BFB6A8 0x0000000189BFBD88-0x0000000189BFBE04
		public DeviceLostEvent deviceLostEvent { get => default; } // 0x0000000189BFB874-0x0000000189BFB8E4 
		public DeviceRegainedEvent deviceRegainedEvent { get => default; } // 0x0000000189BFB8E4-0x0000000189BFB954 
		public ControlsChangedEvent controlsChangedEvent { get => default; } // 0x0000000189BFB768-0x0000000189BFB7D8 
		public Camera camera { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public InputSystemUIInputModule uiInputModule { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000189BFC02C-0x0000000189BFC170
		public InputUser user { get => default; } // 0x0000000183D50E50-0x0000000183D50E60 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> devices { get => default; } // 0x0000000189BFB954-0x0000000189BFB9D8 
		public bool hasMissingRequiredDevices { get => default; } // 0x0000000189BFB9D8-0x0000000189BFBA50 
		public static ReadOnlyArray<PlayerInput> all { get => default; } // 0x0000000189BFB6F0-0x0000000189BFB768 
		public static bool isSinglePlayer { get => default; } // 0x0000000189BFBA50-0x0000000189BFBAE8 
	
		// Events
		public event Action<InputAction.CallbackContext> onActionTriggered;
		public event Action<PlayerInput> onDeviceLost;
		public event Action<PlayerInput> onDeviceRegained;
		public event Action<PlayerInput> onControlsChanged;
	
		// Nested types
		[Serializable]
		public class ActionEvent : UnityEvent<InputAction.CallbackContext> // TypeDefIndex: 44242
		{
			// Fields
			[SerializeField]
			private string m_ActionId; // 0x30
			[SerializeField]
			private string m_ActionName; // 0x38
	
			// Properties
			public string actionId { get => default; } // 0x0000000181003830-0x0000000181003840 
			public string actionName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
			// Constructors
			public ActionEvent() {} // 0x0000000189BEB0C8-0x0000000189BEB104
			public ActionEvent(InputAction action) {} // 0x0000000189BEB104-0x0000000189BEB344
			public ActionEvent(Guid actionGUID, string name = null) {} // 0x0000000189BEB344-0x0000000189BEB3BC
		}
	
		[Serializable]
		public class DeviceLostEvent : UnityEvent<PlayerInput> // TypeDefIndex: 44243
		{
			// Constructors
			public DeviceLostEvent() {} // 0x0000000189BEC2F4-0x0000000189BEC330
		}
	
		[Serializable]
		public class DeviceRegainedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 44244
		{
			// Constructors
			public DeviceRegainedEvent() {} // 0x0000000189BEC330-0x0000000189BEC36C
		}
	
		[Serializable]
		public class ControlsChangedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 44245
		{
			// Constructors
			public ControlsChangedEvent() {} // 0x0000000189BEB844-0x0000000189BEB880
		}
	
		// Constructors
		public PlayerInput() {} // 0x0000000189BFB398-0x0000000189BFB3B0
		static PlayerInput() {} // 0x0000000189BFB348-0x0000000189BFB398
	
		// Methods
		public TDevice GetDevice<TDevice>()
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public void ActivateInput() {} // 0x0000000189BF68A4-0x0000000189BF6948
		private void UpdateDelegates() {} // 0x0000000189BFB170-0x0000000189BFB348
		public void DeactivateInput() {} // 0x0000000189BF7B90-0x0000000189BF7BBC
		[Obsolete("Use DeactivateInput instead.")]
		public void PassivateInput() {} // 0x0000000189BF9F74-0x0000000189BF9F7C
		public bool SwitchCurrentControlScheme(params UnityEngine.InputSystem.InputDevice[] devices) => default; // 0x0000000189BFA7A4-0x0000000189BFA99C
		public void SwitchCurrentControlScheme(string controlScheme, params UnityEngine.InputSystem.InputDevice[] devices) {} // 0x0000000189BFA99C-0x0000000189BFAAE8
		public void SwitchCurrentActionMap(string mapNameOrId) {} // 0x0000000189BFA674-0x0000000189BFA7A4
		public static PlayerInput GetPlayerByIndex(int playerIndex) => default; // 0x0000000189BF7FB8-0x0000000189BF8094
		public static PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BF7E3C-0x0000000189BF7FB8
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x01FB6750 */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x01FB6751 */, UnityEngine.InputSystem.InputDevice pairWithDevice = null) => default; // 0x0000000189BF8B28-0x0000000189BF8CC0
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1 /* Metadata: 0x01FB6752 */, string controlScheme = null, int splitScreenIndex = -1 /* Metadata: 0x01FB6753 */, params UnityEngine.InputSystem.InputDevice[] pairWithDevices) => default; // 0x0000000189BF8968-0x0000000189BF8B28
		private static PlayerInput DoInstantiate(GameObject prefab) => default; // 0x0000000189BF7C0C-0x0000000189BF7E3C
		private void InitializeActions() {} // 0x0000000189BF8444-0x0000000189BF87AC
		private void CopyActionAssetAndApplyBindingOverrides() {} // 0x0000000189BF7950-0x0000000189BF7B90
		private void UninitializeActions() {} // 0x0000000189BFAE18-0x0000000189BFB00C
		private void InstallOnActionTriggeredHook() {} // 0x0000000189BF87AC-0x0000000189BF8968
		private void UninstallOnActionTriggeredHook() {} // 0x0000000189BFB00C-0x0000000189BFB170
		private void OnActionTriggered(InputAction.CallbackContext context) {} // 0x0000000189BF8CC0-0x0000000189BF8EC8
		private void CacheMessageNames() {} // 0x0000000189BF7640-0x0000000189BF7908
		private void ClearCaches() {} // 0x0000000189BF7908-0x0000000189BF7950
		private void AssignUserAndDevices() {} // 0x0000000189BF6B14-0x0000000189BF75E0
		private bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BF8358-0x0000000189BF8444
		private void UnassignUserAndDevices() {} // 0x0000000189BFAD48-0x0000000189BFAE18
		private bool TryToActivateControlScheme(InputControlScheme controlScheme) => default; // 0x0000000189BFAAE8-0x0000000189BFAD48
		private void AssignPlayerIndex() {} // 0x0000000189BF6948-0x0000000189BF6B14
		private void Awake() {} // 0x0000000189BF75E0-0x0000000189BF7640
		private void OnEnable() {} // 0x0000000189BF91EC-0x0000000189BF964C
		private void StartListeningForUnpairedDeviceActivity() {} // 0x0000000189BFA044-0x0000000189BFA18C
		private void StopListeningForUnpairedDeviceActivity() {} // 0x0000000189BFA1F0-0x0000000189BFA270
		private void StartListeningForDeviceChanges() {} // 0x0000000189BF9F7C-0x0000000189BFA044
		private void StopListeningForDeviceChanges() {} // 0x0000000189BFA18C-0x0000000189BFA1F0
		private void OnDisable() {} // 0x0000000189BF8FF0-0x0000000189BF91EC
		public void DebugLogAction(InputAction.CallbackContext context) {} // 0x0000000189BF7BBC-0x0000000189BF7C0C
		private void HandleDeviceLost() {} // 0x0000000189BF8180-0x0000000189BF826C
		private void HandleDeviceRegained() {} // 0x0000000189BF826C-0x0000000189BF8358
		private void HandleControlsChanged() {} // 0x0000000189BF8094-0x0000000189BF8180
		private static void OnUserChange(InputUser user, InputUserChange change, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BF9DA8-0x0000000189BF9F74
		private static bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr) => default; // 0x0000000189BF964C-0x0000000189BF9744
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) {} // 0x0000000189BF9744-0x0000000189BF9DA8
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000189BF8EC8-0x0000000189BF8FF0
		private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params UnityEngine.InputSystem.InputDevice[] devices) {} // 0x0000000189BFA270-0x0000000189BFA674
	}

	[AddComponentMenu("Input/Player Input Manager")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/PlayerInputManager.html")]
	public class PlayerInputManager : MonoBehaviour // TypeDefIndex: 44249
	{
		// Fields
		public const string PlayerJoinedMessage = "OnPlayerJoined"; // Metadata: 0x01FB6789
		public const string PlayerLeftMessage = "OnPlayerLeft"; // Metadata: 0x01FB6798
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
		public bool splitScreen { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000189BF66C8-0x0000000189BF68A4
		public bool maintainAspectRatioInSplitScreen { get => default; } // 0x0000000183D589D0-0x0000000183D589E0 
		public int fixedNumberOfSplitScreens { get => default; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
		public Rect splitScreenArea { get => default; } // 0x0000000183D5A130-0x0000000183D5A140 
		public int playerCount { get => default; } // 0x0000000189BF6308-0x0000000189BF6358 
		public int maxPlayerCount { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public bool joiningEnabled { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		public PlayerJoinBehavior joinBehavior { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000189BF667C-0x0000000189BF66C8
		public InputActionProperty joinAction { get => default; set {} } // 0x0000000183D59520-0x0000000183D59540 0x0000000189BF65D8-0x0000000189BF667C
		public PlayerNotifications notificationBehavior { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public PlayerJoinedEvent playerJoinedEvent { get => default; } // 0x0000000189BF6358-0x0000000189BF63C8 
		public PlayerLeftEvent playerLeftEvent { get => default; } // 0x0000000189BF63C8-0x0000000189BF6438 
		public GameObject playerPrefab { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public static PlayerInputManager instance { get; private set; } // 0x0000000189BF6248-0x0000000189BF6280 0x0000000189BF6588-0x0000000189BF65D8
		internal static string[] messages { get => default; } // 0x0000000189BF6280-0x0000000189BF6308 
	
		// Events
		public event Action<PlayerInput> onPlayerJoined;
		public event Action<PlayerInput> onPlayerLeft;
	
		// Nested types
		[Serializable]
		public class PlayerJoinedEvent : UnityEvent<PlayerInput> // TypeDefIndex: 44247
		{
			// Constructors
			public PlayerJoinedEvent() {} // 0x0000000189BFC170-0x0000000189BFC1AC
		}
	
		[Serializable]
		public class PlayerLeftEvent : UnityEvent<PlayerInput> // TypeDefIndex: 44248
		{
			// Constructors
			public PlayerLeftEvent() {} // 0x0000000189BFC1AC-0x0000000189BFC1E8
		}
	
		// Constructors
		public PlayerInputManager() {} // 0x0000000189BF60D0-0x0000000189BF60F8
	
		// Methods
		public void EnableJoining() {} // 0x0000000189BF4D60-0x0000000189BF4F38
		public void DisableJoining() {} // 0x0000000189BF4C84-0x0000000189BF4D60
		internal void JoinPlayerFromUI() {} // 0x0000000189BF5460-0x0000000189BF54C0
		public void JoinPlayerFromAction(InputAction.CallbackContext context) {} // 0x0000000189BF5400-0x0000000189BF5460
		public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context) {} // 0x0000000189BF5334-0x0000000189BF5400
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x01FB6784 */, int splitScreenIndex = -1 /* Metadata: 0x01FB6785 */, string controlScheme = null, UnityEngine.InputSystem.InputDevice pairWithDevice = null) => default; // 0x0000000189BF54C0-0x0000000189BF5564
		public PlayerInput JoinPlayer(int playerIndex = -1 /* Metadata: 0x01FB6786 */, int splitScreenIndex = -1 /* Metadata: 0x01FB6787 */, string controlScheme = null, params UnityEngine.InputSystem.InputDevice[] pairWithDevices) => default; // 0x0000000189BF5564-0x0000000189BF5608
		private bool CheckIfPlayerCanJoin(int playerIndex = -1 /* Metadata: 0x01FB6788 */) => default; // 0x0000000189BF49FC-0x0000000189BF4C84
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) {} // 0x0000000189BF5B48-0x0000000189BF5BE0
		private void OnEnable() {} // 0x0000000189BF5874-0x0000000189BF5B48
		private void OnDisable() {} // 0x0000000189BF5800-0x0000000189BF5874
		private void UpdateSplitScreen() {} // 0x0000000189BF5BE0-0x0000000189BF60D0
		private bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BF4F38-0x0000000189BF5334
		private void ValidateInputActionAsset() {} // 0x000000018350B670-0x000000018350B680
		internal void NotifyPlayerJoined(PlayerInput player) {} // 0x0000000189BF5608-0x0000000189BF5704
		internal void NotifyPlayerLeft(PlayerInput player) {} // 0x0000000189BF5704-0x0000000189BF5800
	}

	public enum PlayerJoinBehavior // TypeDefIndex: 44250
	{
		JoinPlayersWhenButtonIsPressed = 0,
		JoinPlayersWhenJoinActionIsTriggered = 1,
		JoinPlayersManually = 2
	}

	public enum PlayerNotifications // TypeDefIndex: 44251
	{
		SendMessages = 0,
		BroadcastMessages = 1,
		InvokeUnityEvents = 2,
		InvokeCSharpEvents = 3
	}

	internal struct DynamicBitfield // TypeDefIndex: 44252
	{
		// Fields
		public InlinedArray<ulong> array; // 0x00
		public int length; // 0x18
	
		// Methods
		public void SetLength(int newLength) {} // 0x0000000182EB8B90-0x0000000182EB8BF0
		public void SetBit(int bitIndex) {} // 0x00000001822BD0F0-0x00000001822BD190
		public bool TestBit(int bitIndex) => default; // 0x00000001822BBBE0-0x00000001822BBFF0
		public void ClearBit(int bitIndex) {} // 0x00000001822BD190-0x00000001822BD230
		public bool AnyBitIsSet() => default; // 0x000000018318DD50-0x000000018318DDD0
		private static int BitCountToULongCount(int bitCount) => default; // 0x0000000183D772A0-0x0000000183D772B0
	}
}

namespace UnityEngine.InputSystem.Composites
{
	[System.ComponentModel.DisplayName("Positive/Negative Binding")]
	[DisplayStringFormat("{negative}/{positive}")]
	public class AxisComposite : InputBindingComposite<float> // TypeDefIndex: 44653
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
		public float midPoint { get => default; } // 0x0000000183D76E10-0x0000000183D76E30 
	
		// Nested types
		public enum WhichSideWins // TypeDefIndex: 44652
		{
			Neither = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		public AxisComposite() {} // 0x0000000189BC87F4-0x0000000189BC8840
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x0000000189BC86F0-0x0000000189BC87F4
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8664-0x0000000189BC86F0
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier}+{button}")]
	public class ButtonWithOneModifier : InputBindingComposite<float> // TypeDefIndex: 44655
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
		public enum ModifiersOrder // TypeDefIndex: 44654
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithOneModifier() {} // 0x0000000189BC8984-0x0000000189BC89AC
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8924-0x0000000189BC8984
		private bool ModifierIsPressed(ref InputBindingCompositeContext context) => default; // 0x0000000189BC88C0-0x0000000189BC8924
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8840-0x0000000189BC8854
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000189BC8854-0x0000000189BC88C0
	}

	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
	public class ButtonWithTwoModifiers : InputBindingComposite<float> // TypeDefIndex: 44657
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
		public enum ModifiersOrder // TypeDefIndex: 44656
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public ButtonWithTwoModifiers() {} // 0x0000000189BC8B18-0x0000000189BC8B40
	
		// Methods
		public override float ReadValue(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8AB8-0x0000000189BC8B18
		private bool ModifiersArePressed(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8A18-0x0000000189BC8AB8
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BC8840-0x0000000189BC8854
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000189BC89AC-0x0000000189BC8A18
	}

	[System.ComponentModel.DisplayName("Binding With One Modifier")]
	[DisplayStringFormat("{modifier}+{binding}")]
	public class OneModifierComposite : InputBindingComposite // TypeDefIndex: 44659
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
		public override System.Type valueType { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override int valueSizeInBytes { get => default; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 44658
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public OneModifierComposite() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BCA8D4-0x0000000189BCA910
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) {} // 0x0000000189BCAA58-0x0000000189BCAAC4
		private bool ModifierIsPressed(ref InputBindingCompositeContext context) => default; // 0x0000000189BCA9AC-0x0000000189BCAA18
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000189BCA910-0x0000000189BCA9AC
		public override object ReadValueAsObject(ref InputBindingCompositeContext context) => default; // 0x0000000189BCAA18-0x0000000189BCAA58
		internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out System.Type valueType, out int valueSizeInBytes, out bool isButton) {
			valueType = default;
			valueSizeInBytes = default;
			isButton = default;
		} // 0x0000000189BCA5FC-0x0000000189BCA8D4
	}

	[System.ComponentModel.DisplayName("Binding With Two Modifiers")]
	[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
	public class TwoModifiersComposite : InputBindingComposite // TypeDefIndex: 44661
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
		public override System.Type valueType { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override int valueSizeInBytes { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
	
		// Nested types
		public enum ModifiersOrder // TypeDefIndex: 44660
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}
	
		// Constructors
		public TwoModifiersComposite() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BCD5EC-0x0000000189BCD628
		public override unsafe void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) {} // 0x0000000189BCD7BC-0x0000000189BCD828
		private bool ModifiersArePressed(ref InputBindingCompositeContext context) => default; // 0x0000000189BCD6C4-0x0000000189BCD768
		protected override void FinishSetup(ref InputBindingCompositeContext context) {} // 0x0000000189BCD628-0x0000000189BCD6C4
		public override object ReadValueAsObject(ref InputBindingCompositeContext context) => default; // 0x0000000189BCD768-0x0000000189BCD7BC
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right Composite")]
	[DisplayStringFormat("{up}/{left}/{down}/{right}")]
	public class Vector2Composite : InputBindingComposite<Vector2> // TypeDefIndex: 44663
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
		public enum Mode // TypeDefIndex: 44662
		{
			DigitalNormalized = 0,
			Digital = 1,
			Analog = 2
		}
	
		// Constructors
		public Vector2Composite() {} // 0x0000000183D00BB0-0x0000000183D00BF0
	
		// Methods
		public override Vector2 ReadValue(ref InputBindingCompositeContext context) => default; // 0x0000000189BCEAD0-0x0000000189BCEC2C
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BCEAAC-0x0000000189BCEAD0
	}

	[System.ComponentModel.DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
	[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
	public class Vector3Composite : InputBindingComposite<Vector3> // TypeDefIndex: 44665
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
		public enum Mode // TypeDefIndex: 44664
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}
	
		// Constructors
		public Vector3Composite() {} // 0x0000000189BCEE8C-0x0000000189BCF1BC
	
		// Methods
		public override Vector3 ReadValue(ref InputBindingCompositeContext context) => default; // 0x0000000189BCEC60-0x0000000189BCEE8C
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context) => default; // 0x0000000189BCEC2C-0x0000000189BCEC60
	}
}

namespace UnityEngine.InputSystem.Controls
{
	[InputControlLayout(hideInUI = true)]
	public class AnyKeyControl : ButtonControl // TypeDefIndex: 44564
	{
		// Constructors
		public AnyKeyControl() {} // 0x00000001839C02C0-0x00000001839C0330
	
		// Methods
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x00000001838C1920-0x00000001838C1990
	}

	public class AxisControl : InputControl<float> // TypeDefIndex: 44566
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
		public enum Clamp // TypeDefIndex: 44565
		{
			None = 0,
			BeforeNormalize = 1,
			AfterNormalize = 2,
			ToConstantBeforeNormalize = 3
		}
	
		// Constructors
		public AxisControl() {} // 0x0000000183137260-0x00000001831372E0
	
		// Methods
		protected float Preprocess(float value) => default; // 0x0000000189BBBF14-0x0000000189BBBFFC
		private float Unpreprocess(float value) => default; // 0x0000000189BBBFFC-0x0000000189BBC05C
		protected override void FinishSetup() {} // 0x0000000189BBBE44-0x0000000189BBBF14
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000182E55460-0x0000000182E555C0
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x0000000189BBC05C-0x0000000189BBC10C
		public override unsafe bool CompareValue(void* firstStatePtr, void* secondStatePtr) => default; // 0x0000000189BBBDC0-0x0000000189BBBE44
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x00000001822F88D0-0x00000001822F8930
		private float EvaluateMagnitude(float value) => default; // 0x00000001822F9E70-0x00000001822F9F20
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BBBC88-0x0000000189BBBDC0
	}

	public class ButtonControl : AxisControl // TypeDefIndex: 44567
	{
		// Fields
		private bool m_NeedsToCheckFramePress; // 0x130
		private uint m_UpdateCountLastPressed; // 0x134
		private uint m_UpdateCountLastReleased; // 0x138
		private bool m_LastUpdateWasPress; // 0x13C
		public float pressPoint; // 0x140
		internal static float s_GlobalDefaultButtonPressPoint; // 0x00
		internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x04
		internal const float kMinButtonPressPoint = 0.0001f; // Metadata: 0x01FB6BAB
	
		// Properties
		internal bool needsToCheckFramePress { get; private set; } // 0x0000000183D76CA0-0x0000000183D76CB0 0x0000000183D76CB0-0x0000000183D76CC0
		public float pressPointOrDefault { get => default; } // 0x0000000182EB6D50-0x0000000182EB6DB0 
		public bool isPressed { get => default; } // 0x0000000189BBC10C-0x0000000189BBC168 
		public bool wasPressedThisFrame { get => default; } // 0x0000000182851190-0x0000000182851290 
		public bool wasReleasedThisFrame { get => default; } // 0x0000000189BBC168-0x0000000189BBC25C 
	
		// Constructors
		public ButtonControl() {} // 0x0000000183137160-0x0000000183137260
	
		// Methods
		public new bool IsValueConsideredPressed(float value) => default; // 0x0000000182EB6D20-0x0000000182EB6D50
		private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) {} // 0x0000000183CB4B50-0x0000000183CB4BF0
		internal void UpdateWasPressed() {} // 0x0000000182EB63B0-0x0000000182EB6440
	}

	[UnityEngine.Scripting.Preserve]
	public class DeltaControl : Vector2Control // TypeDefIndex: 44568
	{
		// Properties
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Up")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl up { get; set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Down")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl down { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Left")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl left { get; set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Right")]
		[UnityEngine.Scripting.Preserve]
		public AxisControl right { get; set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
	
		// Constructors
		public DeltaControl() {} // 0x0000000184275810-0x0000000184275818
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BBC87C-0x0000000189BBC984
	}

	public class DiscreteButtonControl : ButtonControl // TypeDefIndex: 44570
	{
		// Fields
		public int minValue; // 0x148
		public int maxValue; // 0x14C
		public int wrapAtValue; // 0x150
		public int nullValue; // 0x154
		public WriteMode writeMode; // 0x158
	
		// Nested types
		public enum WriteMode // TypeDefIndex: 44569
		{
			WriteDisabled = 0,
			WriteNullAndMaxValue = 1
		}
	
		// Constructors
		public DiscreteButtonControl() {} // 0x0000000184275818-0x0000000184275820
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BBC984-0x0000000189BBCA98
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BBCA98-0x0000000189BBCB58
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x0000000189BBCB58-0x0000000189BBCC60
	}

	public class DoubleControl : InputControl<double> // TypeDefIndex: 44571
	{
		// Constructors
		public DoubleControl() {} // 0x0000000183137060-0x00000001831370E0
	
		// Methods
		public override unsafe double ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BBCC60-0x0000000189BBCCBC
		public override unsafe void WriteValueIntoState(double value, void* statePtr) {} // 0x0000000189BBCCBC-0x0000000189BBCD20
	}

	public class DpadControl : Vector2Control // TypeDefIndex: 44574
	{
		// Properties
		[InputControl(bit = 0, displayName = "Up")]
		[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = true)]
		[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = true)]
		public ButtonControl up { get; set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		[InputControl(bit = 1, displayName = "Down")]
		public ButtonControl down { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		[InputControl(bit = 2, displayName = "Left")]
		public ButtonControl left { get; set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		[InputControl(bit = 3, displayName = "Right")]
		public ButtonControl right { get; set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
	
		// Nested types
		[InputControlLayout(hideInUI = true)]
		public class DpadAxisControl : AxisControl // TypeDefIndex: 44572
		{
			// Properties
			public int component { get; set; } // 0x0000000183D5CE60-0x0000000183D5CE70 0x0000000183D5CE70-0x0000000183D5CE80
	
			// Constructors
			public DpadAxisControl() {} // 0x0000000189BBCE34-0x0000000189BBCE3C
	
			// Methods
			protected override void FinishSetup() {} // 0x0000000189BBCD20-0x0000000189BBCDA0
			public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BBCDA0-0x0000000189BBCE34
		}
	
		internal enum ButtonBits // TypeDefIndex: 44573
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}
	
		// Constructors
		public DpadControl() {} // 0x0000000189BBD2B4-0x0000000189BBD310
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BBCE3C-0x0000000189BBCF44
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BBCFB8-0x0000000189BBD138
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr) {} // 0x0000000189BBD138-0x0000000189BBD2B4
		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true /* Metadata: 0x01FB6BB1 */) => default; // 0x0000000189BBCF44-0x0000000189BBCFB8
		public static Vector2 MakeDpadVector(float up, float down, float left, float right) => default; // 0x0000000183D76CC0-0x0000000183D76CE0
	}

	public class IntegerControl : InputControl<int> // TypeDefIndex: 44575
	{
		// Constructors
		public IntegerControl() {} // 0x000000018319E640-0x000000018319E6C0
	
		// Methods
		public override unsafe int ReadUnprocessedValueFromState(void* statePtr) => default; // 0x00000001830CC090-0x00000001830CC110
		public override unsafe void WriteValueIntoState(int value, void* statePtr) {} // 0x0000000189BC4220-0x0000000189BC429C
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BC4178-0x0000000189BC4220
	}

	public class KeyControl : ButtonControl // TypeDefIndex: 44576
	{
		// Fields
		private int m_ScanCode; // 0x14C
	
		// Properties
		public UnityEngine.InputSystem.Key keyCode { get; set; } // 0x0000000183D72F40-0x0000000183D72F50 0x0000000183D76DF0-0x0000000183D76E00
		public int scanCode { get => default; } // 0x0000000189BC5D98-0x0000000189BC5DB4 
	
		// Constructors
		public KeyControl() {} // 0x0000000184275818-0x0000000184275820
	
		// Methods
		protected override void RefreshConfiguration() {} // 0x0000000189BC5BEC-0x0000000189BC5D98
	}

	public class QuaternionControl : InputControl<Quaternion> // TypeDefIndex: 44577
	{
		// Properties
		[InputControl(displayName = "X")]
		public AxisControl x { get; set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		[InputControl(displayName = "Y")]
		public AxisControl y { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		[InputControl(displayName = "Z")]
		public AxisControl z { get; set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		[InputControl(displayName = "W")]
		public AxisControl w { get; set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
	
		// Constructors
		public QuaternionControl() {} // 0x0000000189BC6D30-0x0000000189BC6D98
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC6A04-0x0000000189BC6B20
		public override unsafe Quaternion ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BC6B20-0x0000000189BC6C5C
		public override unsafe void WriteValueIntoState(Quaternion value, void* statePtr) {} // 0x0000000189BC6C5C-0x0000000189BC6D30
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BC67B8-0x0000000189BC6A04
	}

	public class StickControl : Vector2Control // TypeDefIndex: 44578
	{
		// Properties
		[InputControl(name = "y", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		[InputControl(name = "x", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Up")]
		public ButtonControl up { get; set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Down")]
		public ButtonControl down { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Left")]
		public ButtonControl left { get; set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Right")]
		public ButtonControl right { get; set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
	
		// Constructors
		public StickControl() {} // 0x0000000184275810-0x0000000184275818
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC6F80-0x0000000189BC7088
	}

	[InputControlLayout(stateType = typeof(TouchState))]
	public class TouchControl : InputControl<TouchState> // TypeDefIndex: 44579
	{
		// Properties
		public TouchPressControl press { get; set; } // 0x0000000183D574A0-0x0000000183D574B0 0x0000000184275C18-0x0000000184275C2C
		public IntegerControl displayIndex { get; set; } // 0x0000000183D56A70-0x0000000183D56A80 0x0000000184275C2C-0x0000000184275C40
		public IntegerControl touchId { get; set; } // 0x0000000183D56B50-0x0000000183D56B60 0x0000000184275C40-0x0000000184275C54
		public Vector2Control position { get; set; } // 0x0000000183D56AF0-0x0000000183D56B00 0x0000000184275C54-0x0000000184275C68
		public DeltaControl delta { get; set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public AxisControl pressure { get; set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public Vector2Control radius { get; set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		public TouchPhaseControl phase { get; set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public ButtonControl indirectTouch { get; set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		public ButtonControl tap { get; set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		public IntegerControl tapCount { get; set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public DoubleControl startTime { get; set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		public Vector2Control startPosition { get; set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		public bool isInProgress { get => default; } // 0x0000000182CADB20-0x0000000182CADB80 
	
		// Constructors
		public TouchControl() {} // 0x0000000183643650-0x00000001836436C0
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC7254-0x0000000189BC75A4
		public override unsafe TouchState ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BC75A4-0x0000000189BC7620
		public override unsafe void WriteValueIntoState(TouchState value, void* statePtr) {} // 0x0000000189BC7620-0x0000000189BC76A0
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPhaseControl : InputControl<UnityEngine.InputSystem.TouchPhase> // TypeDefIndex: 44580
	{
		// Constructors
		public TouchPhaseControl() {} // 0x0000000183136FE0-0x0000000183137060
	
		// Methods
		public override unsafe UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr) => default; // 0x00000001830CC020-0x00000001830CC090
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr) {} // 0x0000000189BC76A0-0x0000000189BC7700
	}

	[InputControlLayout(hideInUI = true)]
	public class TouchPressControl : ButtonControl // TypeDefIndex: 44581
	{
		// Constructors
		public TouchPressControl() {} // 0x0000000184275818-0x0000000184275820
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC7700-0x0000000189BC7814
		public override unsafe float ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BC7814-0x0000000189BC7890
		public override unsafe void WriteValueIntoState(float value, void* statePtr) {} // 0x0000000189BC7890-0x0000000189BC78DC
	}

	public class Vector2Control : InputControl<Vector2> // TypeDefIndex: 44582
	{
		// Properties
		[InputControl(offset = 0, displayName = "X")]
		public AxisControl x { get; set; } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { get; set; } // 0x0000000183D571F0-0x0000000183D57200 0x0000000184275D08-0x0000000184275D1C
	
		// Constructors
		public Vector2Control() {} // 0x00000001831370E0-0x0000000183137160
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC7EF0-0x0000000189BC7FA0
		public override unsafe Vector2 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x000000018307A430-0x000000018307A4E0
		public override unsafe void WriteValueIntoState(Vector2 value, void* statePtr) {} // 0x0000000189BC7FA0-0x0000000189BC804C
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000183213D20-0x0000000183213DE0
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BC7DC8-0x0000000189BC7EF0
	}

	public class Vector3Control : InputControl<Vector3> // TypeDefIndex: 44583
	{
		// Properties
		[InputControl(offset = 0, displayName = "X")]
		public AxisControl x { get; set; } // 0x0000000183D571F0-0x0000000183D57200 0x0000000184275D08-0x0000000184275D1C
		[InputControl(offset = 4, displayName = "Y")]
		public AxisControl y { get; set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		[InputControl(offset = 8, displayName = "Z")]
		public AxisControl z { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
	
		// Constructors
		public Vector3Control() {} // 0x0000000189BC854C-0x0000000189BC85B0
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BC82A4-0x0000000189BC8388
		public override unsafe Vector3 ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BC8388-0x0000000189BC8488
		public override unsafe void WriteValueIntoState(Vector3 value, void* statePtr) {} // 0x0000000189BC8488-0x0000000189BC854C
		public override unsafe float EvaluateMagnitude(void* statePtr) => default; // 0x0000000189BC8238-0x0000000189BC82A4
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BC80A0-0x0000000189BC8238
	}
}

namespace UnityEngine.InputSystem.DualShock
{
	[InputControlLayout(displayName = "PlayStation Controller")]
	public class DualShockGamepad : Gamepad, IDualShockHaptics // TypeDefIndex: 44375
	{
		// Properties
		[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
		[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
		[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
		[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
		[InputControl]
		public ButtonControl touchpadButton { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(name = "start", displayName = "Options")]
		public ButtonControl optionsButton { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		[InputControl(name = "select", displayName = "Share")]
		public ButtonControl shareButton { get; protected set; } // 0x0000000183D57430-0x0000000183D57440 0x00000001858B41A4-0x00000001858B41B8
		[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
		public ButtonControl L1 { get; protected set; } // 0x0000000183D57480-0x0000000183D57490 0x00000001858B421C-0x00000001858B4230
		[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
		public ButtonControl R1 { get; protected set; } // 0x0000000183D57210-0x0000000183D57220 0x00000001858B3DE4-0x00000001858B3DF8
		[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
		public ButtonControl L2 { get; protected set; } // 0x0000000183D57220-0x0000000183D57230 0x00000001858B3DF8-0x00000001858B3E0C
		[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
		public ButtonControl R2 { get; protected set; } // 0x0000000183D56B10-0x0000000183D56B20 0x000000018586F120-0x000000018586F134
		[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
		public ButtonControl L3 { get; protected set; } // 0x0000000183D56D60-0x0000000183D56D70 0x00000001858AAF50-0x00000001858AAF64
		[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
		public ButtonControl R3 { get; protected set; } // 0x0000000183D57350-0x0000000183D57360 0x00000001858B403C-0x00000001858B4050
		public static new DualShockGamepad current { get; private set; } // 0x0000000189C0FC84-0x0000000189C0FCBC 0x0000000189C0FCBC-0x0000000189C0FD0C
		internal HID.HIDDeviceDescriptor hidDescriptor { get; private set; } // 0x0000000183D77A70-0x0000000183D77AA0 0x0000000189C0FD0C-0x0000000189C0FD38
	
		// Constructors
		public DualShockGamepad() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public override void MakeCurrent() {} // 0x0000000189C0FC14-0x0000000189C0FC30
		protected override void OnRemoved() {} // 0x0000000189C0FC30-0x0000000189C0FC84
		protected override void FinishSetup() {} // 0x0000000189C0FA68-0x0000000189C0FC14
		public virtual void SetLightBarColor(UnityEngine.Color color) {} // 0x000000018350B670-0x000000018350B680
	}

	[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
	public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 44380
	{
		// Fields
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		protected UnityEngine.Color? m_LightBarColor; // 0x2B0
		private byte outputSequenceId; // 0x2C4
		internal const byte JitterMaskLow = 120; // Metadata: 0x01FB69B6
		internal const byte JitterMaskHigh = 135; // Metadata: 0x01FB69B7
	
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000183D57060-0x0000000183D57070 0x00000001858B3BDC-0x00000001858B3BF0
		public ButtonControl rightTriggerButton { get; protected set; } // 0x0000000183D57040-0x0000000183D57050 0x00000001858B3BB4-0x00000001858B3BC8
		public ButtonControl playStationButton { get; protected set; } // 0x0000000183D57180-0x0000000183D57190 0x00000001858B3D80-0x00000001858B3D94
	
		// Nested types
		internal struct DualSenseHIDGenericInputReport // TypeDefIndex: 44376
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get => default; } // 0x0000000183D775E0-0x0000000183D775F0 
		}
	
		internal struct DualSenseHIDUSBInputReport // TypeDefIndex: 44377
		{
			// Fields
			public const int ExpectedReportId = 1; // Metadata: 0x01FB69B8
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
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000183D77980-0x0000000183D779D0
		}
	
		internal struct DualSenseHIDBluetoothInputReport // TypeDefIndex: 44378
		{
			// Fields
			public const int ExpectedReportId = 49; // Metadata: 0x01FB69B9
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
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000183D77870-0x0000000183D778C0
		}
	
		internal struct DualSenseHIDMinimalInputReport // TypeDefIndex: 44379
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
			} // 0x0000000189C0EDA0-0x0000000189C0EDF0
	
			// Methods
			public DualSenseHIDInputReport ToHIDInputReport() => default; // 0x0000000183D77930-0x0000000183D77980
		}
	
		// Constructors
		public DualSenseGamepadHID() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C0E1B8-0x0000000189C0E28C
		public override void PauseHaptics() {} // 0x0000000189C0E4A8-0x0000000189C0E544
		public override void ResetHaptics() {} // 0x0000000189C0E544-0x0000000189C0E5C8
		public override void ResumeHaptics() {} // 0x0000000189C0E5C8-0x0000000189C0E63C
		public override void SetLightBarColor(UnityEngine.Color color) {} // 0x0000000189C0E63C-0x0000000189C0E6D0
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x0000000189C0E8E0-0x0000000189C0E9A0
		public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, UnityEngine.Color? color) => default; // 0x0000000189C0E6D0-0x0000000189C0E8E0
		private static unsafe bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState) => default; // 0x0000000189C0E28C-0x0000000189C0E2C4
		private static unsafe bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState) => default; // 0x0000000189C0E2C4-0x0000000189C0E2FC
		private static unsafe bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState) => default; // 0x0000000189C0E2FC-0x0000000189C0E334
		bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) => default; // 0x0000000189C0E9A0-0x0000000189C0EB4C
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) => default; // 0x0000000189C0EB4C-0x0000000189C0ED14
		public void OnNextUpdate() {} // 0x000000018350B670-0x000000018350B680
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189C0E334-0x0000000189C0E4A8
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = true, isNoisy = true)]
	public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 44382
	{
		// Fields
		private float? m_LowFrequencyMotorSpeed; // 0x2A0
		private float? m_HighFrequenceyMotorSpeed; // 0x2A8
		private UnityEngine.Color? m_LightBarColor; // 0x2B0
		internal const byte JitterMaskLow = 120; // Metadata: 0x01FB69BA
		internal const byte JitterMaskHigh = 135; // Metadata: 0x01FB69BB
	
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000183D57060-0x0000000183D57070 0x00000001858B3BDC-0x00000001858B3BF0
		public ButtonControl rightTriggerButton { get; protected set; } // 0x0000000183D57040-0x0000000183D57050 0x00000001858B3BB4-0x00000001858B3BC8
		public ButtonControl playStationButton { get; protected set; } // 0x0000000183D57180-0x0000000183D57190 0x00000001858B3D80-0x00000001858B3D94
	
		// Nested types
		internal struct DualShock4HIDGenericInputReport // TypeDefIndex: 44381
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
			public static FourCC Format { get => default; } // 0x0000000183D775E0-0x0000000183D775F0 
	
			// Methods
			public DualShock4HIDInputReport ToHIDInputReport() => default; // 0x0000000183D77A20-0x0000000183D77A70
		}
	
		// Constructors
		public DualShock4GamepadHID() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C0EEC4-0x0000000189C0EF98
		public override void PauseHaptics() {} // 0x0000000189C0F10C-0x0000000189C0F228
		public override void ResetHaptics() {} // 0x0000000189C0F228-0x0000000189C0F364
		public override void ResumeHaptics() {} // 0x0000000189C0F364-0x0000000189C0F4EC
		public override void SetLightBarColor(UnityEngine.Color color) {} // 0x0000000189C0F4EC-0x0000000189C0F5F4
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency) {} // 0x0000000189C0F76C-0x0000000189C0F884
		public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, UnityEngine.Color color) => default; // 0x0000000189C0F5F4-0x0000000189C0F76C
		bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) => default; // 0x0000000189C0F884-0x0000000189C0F9DC
		public void OnNextUpdate() {} // 0x000000018350B670-0x000000018350B680
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189C0EF98-0x0000000189C0F10C
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = true, displayName = "PS3 Controller")]
	public class DualShock3GamepadHID : DualShockGamepad // TypeDefIndex: 44383
	{
		// Properties
		public ButtonControl leftTriggerButton { get; protected set; } // 0x0000000183D57060-0x0000000183D57070 0x00000001858B3BDC-0x00000001858B3BF0
		public ButtonControl rightTriggerButton { get; protected set; } // 0x0000000183D57040-0x0000000183D57050 0x00000001858B3BB4-0x00000001858B3BC8
		public ButtonControl playStationButton { get; protected set; } // 0x0000000183D57180-0x0000000183D57190 0x00000001858B3D80-0x00000001858B3D94
	
		// Constructors
		public DualShock3GamepadHID() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C0EDF0-0x0000000189C0EEC4
	}

	internal static class DualShockSupport // TypeDefIndex: 44384
	{
		// Methods
		public static void Initialize() {} // 0x0000000182F18700-0x0000000182F18BB0
	}

	public interface IDualShockHaptics : IDualMotorRumble // TypeDefIndex: 44385
	{
		// Methods
		void SetLightBarColor(UnityEngine.Color color);
	}
}

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	public struct DualSenseHIDInputReport : IInputStateTypeInfo // TypeDefIndex: 44386
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
		public FourCC format { get => default; } // 0x0000000189C0ED50-0x0000000189C0EDA0 
	
		// Constructors
		static DualSenseHIDInputReport() {
			Format = default;
		} // 0x0000000189C0ED14-0x0000000189C0ED50
	}

	internal struct DualSenseHIDOutputReportPayload // TypeDefIndex: 44387
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

	internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 44388
	{
		// Fields
		internal const int kSize = 56; // Metadata: 0x01FB69BC
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public DualSenseHIDOutputReportPayload payload; // 0x09
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77650-0x0000000183D77660 
		public FourCC typeStatic { get => default; } // 0x0000000183D77650-0x0000000183D77660 
	
		// Methods
		public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize) => default; // 0x0000000183D779D0-0x0000000183D77A20
	}

	internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 44390
	{
		// Fields
		internal const int kSize = 86; // Metadata: 0x01FB69BD
		public InputDeviceCommand baseCommand; // 0x00
		public byte reportId; // 0x08
		public byte tag1; // 0x09
		public byte tag2; // 0x0A
		public DualSenseHIDOutputReportPayload payload; // 0x0B
		public uint crc32; // 0x52
		public unsafe fixed /* 0x00000000-0x00000000 */ byte rawData[0]; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77650-0x0000000183D77660 
		public FourCC typeStatic { get => default; } // 0x0000000183D77650-0x0000000183D77660 
	
		// Methods
		public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize) => default; // 0x0000000183D778C0-0x0000000183D77930
	}

	internal struct DualShock4HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 44391
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
		public FourCC format { get => default; } // 0x0000000189C0FA18-0x0000000189C0FA68 
	
		// Constructors
		static DualShock4HIDInputReport() {
			Format = default;
		} // 0x0000000189C0F9DC-0x0000000189C0FA18
	}

	internal struct DualShock3HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 44393
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
		public FourCC format { get => default; } // 0x0000000183D775E0-0x0000000183D775F0 
	}

	internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 44397
	{
		// Fields
		internal const int kSize = 40; // Metadata: 0x01FB69BF
		internal const int kReportId = 5; // Metadata: 0x01FB69C0
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
		public static FourCC Type { get => default; } // 0x0000000183D77650-0x0000000183D77660 
		public FourCC typeStatic { get => default; } // 0x0000000183D77650-0x0000000183D77660 
	
		// Nested types
		[Flags]
		public enum Flags // TypeDefIndex: 44394
		{
			Rumble = 1,
			Color = 2
		}
	
		// Methods
		public void SetMotorSpeeds(float lowFreq, float highFreq) {} // 0x0000000189C0FDB0-0x0000000189C0FDFC
		public void SetColor(UnityEngine.Color color) {} // 0x0000000189C0FD38-0x0000000189C0FDB0
		public static DualShockHIDOutputReport Create(int outputReportSize) => default; // 0x0000000183D77AA0-0x0000000183D77AD0
	}
}

namespace UnityEngine.InputSystem.Editor
{
	internal struct SampleFrequencyCalculator // TypeDefIndex: 44398
	{
		// Fields
		private double m_LastUpdateTime; // 0x00
		private int m_SampleCount; // 0x08
	
		// Properties
		public float targetFrequency { [IsReadOnly] get; private set; } // 0x0000000183D5E120-0x0000000183D5E130 0x0000000183D5E130-0x0000000183D5E140
		public float frequency { [IsReadOnly] get; private set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
	
		// Constructors
		public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup) : this() {
			m_LastUpdateTime = default;
			m_SampleCount = default;
		} // 0x0000000183D77FD0-0x0000000183D77FF0
	
		// Methods
		public void ProcessSample(InputEventPtr eventPtr) {} // 0x0000000189C18448-0x0000000189C18454
		public bool Update() => default; // 0x0000000189C18490-0x0000000189C184B4
		public bool Update(double realtimeSinceStartup) => default; // 0x0000000189C18454-0x0000000189C18490
	}
}

namespace UnityEngine.InputSystem.EnhancedTouch
{
	public static class EnhancedTouchSupport // TypeDefIndex: 44365
	{
		// Fields
		private static int s_Enabled; // 0x00
		private static InputSettings.UpdateMode s_UpdateMode; // 0x04
	
		// Properties
		public static bool enabled { get; } // 0x0000000189C102A0-0x0000000189C102DC 
	
		// Methods
		public static void Enable() {} // 0x000000018235C490-0x000000018235C600
		public static void Disable() {} // 0x0000000189C0FE98-0x0000000189C0FFF8
		internal static void Reset() {} // 0x0000000189C10070-0x0000000189C10114
		private static void SetUpState() {} // 0x0000000182CAB190-0x0000000182CAB7A0
		internal static void TearDownState() {} // 0x0000000189C10114-0x0000000189C102A0
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000182CAB7A0-0x0000000182CAB840
		private static void OnSettingsChange() {} // 0x0000000189C0FFF8-0x0000000189C10070
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal static void CheckEnabled() {} // 0x0000000189C0FE2C-0x0000000189C0FE98
	}

	public class Finger // TypeDefIndex: 44366
	{
		// Fields
		internal readonly InputStateHistory<TouchState> m_StateHistory; // 0x20
	
		// Properties
		public Touchscreen screen { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int index { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public bool isActive { get => default; } // 0x0000000189C11018-0x0000000189C11080 
		public Vector2 screenPosition { get => default; } // 0x0000000189C11150-0x0000000189C111DC 
		public Touch lastTouch { get => default; } // 0x0000000189C11080-0x0000000189C11150 
		public Touch currentTouch { get => default; } // 0x0000000189C10F1C-0x0000000189C11018 
		public TouchHistory touchHistory { get => default; } // 0x0000000189C111DC-0x0000000189C11218 
	
		// Constructors
		public Finger() {} // Dummy constructor
		internal Finger(Touchscreen screen, int index, InputUpdateType updateMask) {} // 0x0000000182CAF5E0-0x0000000182CAF850
	
		// Methods
		private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr) => default; // 0x0000000189C10E78-0x0000000189C10F1C
		private void OnTouchRecorded(InputStateHistory.Record record) {} // 0x0000000189C10BC4-0x0000000189C10E78
		private Touch FindTouch(uint uniqueId) => default; // 0x0000000189C107A8-0x0000000189C109AC
		internal TouchHistory GetTouchHistory(Touch touch) => default; // 0x0000000189C109AC-0x0000000189C10BC4
	}

	public struct Touch : IEquatable<Touch> // TypeDefIndex: 44371
	{
		// Fields
		private readonly Finger m_Finger; // 0x00
		internal InputStateHistory<TouchState> m_TouchRecord; // 0x08
		internal static GlobalState s_GlobalState; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x0000000189C1B9E4-0x0000000189C1BA20 
		public Finger finger { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public UnityEngine.InputSystem.TouchPhase phase { get => default; } // 0x0000000189C1B580-0x0000000189C1B5D0 
		public bool began { get => default; } // 0x0000000189C1B160-0x0000000189C1B1A8 
		public bool inProgress { get => default; } // 0x0000000189C1B460-0x0000000189C1B4E4 
		public bool ended { get => default; } // 0x0000000189C1B24C-0x0000000189C1B2B4 
		public int touchId { get => default; } // 0x0000000189C1B8F8-0x0000000189C1B944 
		public float pressure { get => default; } // 0x0000000189C1B5D0-0x0000000189C1B620 
		public Vector2 radius { get => default; } // 0x0000000189C1B620-0x0000000189C1B674 
		public double startTime { get => default; } // 0x0000000189C1B7E0-0x0000000189C1B830 
		public double time { get => default; } // 0x0000000189C1B8BC-0x0000000189C1B8F8 
		public Touchscreen screen { get => default; } // 0x0000000189C1B6C8-0x0000000189C1B71C 
		public Vector2 screenPosition { get => default; } // 0x0000000189C1B674-0x0000000189C1B6C8 
		public Vector2 startScreenPosition { get => default; } // 0x0000000189C1B78C-0x0000000189C1B7E0 
		public Vector2 delta { get => default; } // 0x0000000189C1B1A8-0x0000000189C1B1FC 
		public int tapCount { get => default; } // 0x0000000189C1B86C-0x0000000189C1B8BC 
		public bool isTap { get => default; } // 0x0000000189C1B538-0x0000000189C1B580 
		public int displayIndex { get => default; } // 0x0000000189C1B1FC-0x0000000189C1B24C 
		public bool isInProgress { get => default; } // 0x0000000189C1B4E4-0x0000000189C1B538 
		internal uint updateStepCount { get => default; } // 0x0000000189C1B994-0x0000000189C1B9E4 
		internal uint uniqueId { get => default; } // 0x0000000189C1B944-0x0000000189C1B994 
		private ref TouchState state { get => default; } // 0x0000000189C1B830-0x0000000189C1B86C 
		private ref ExtraDataPerTouchState extraData { get => default; } // 0x0000000189C1B2B4-0x0000000189C1B2F0 
		public TouchHistory history { get => default; } // 0x0000000189C1B370-0x0000000189C1B460 
		public static ReadOnlyArray<Touch> activeTouches { get => default; } // 0x0000000182CAD700-0x0000000182CAD7B0 
		public static ReadOnlyArray<Finger> fingers { get => default; } // 0x0000000189C1B2F0-0x0000000189C1B370 
		public static ReadOnlyArray<Finger> activeFingers { get => default; } // 0x0000000189C1B0C4-0x0000000189C1B160 
		public static IEnumerable<Touchscreen> screens { get => default; } // 0x0000000189C1B71C-0x0000000189C1B78C 
		public static int maxHistoryLengthPerFinger { get => default; } // 0x0000000182CADC80-0x0000000182CADCE0 
	
		// Events
		public static event Action<Finger> onFingerDown;
		public static event Action<Finger> onFingerUp;
		public static event Action<Finger> onFingerMove;
	
		// Nested types
		internal struct GlobalState // TypeDefIndex: 44367
		{
			// Fields
			internal InlinedArray<Touchscreen> touchscreens; // 0x00
			internal int historyLengthPerFinger; // 0x18
			internal CallbackArray<Action<Finger>> onFingerDown; // 0x20
			internal CallbackArray<Action<Finger>> onFingerMove; // 0x70
			internal CallbackArray<Action<Finger>> onFingerUp; // 0xC0
			internal FingerAndTouchState playerState; // 0x110
		}
	
		internal struct FingerAndTouchState // TypeDefIndex: 44368
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
			public void AddFingers(Touchscreen screen) {} // 0x0000000182CAD9E0-0x0000000182CADB20
			public void RemoveFingers(Touchscreen screen) {} // 0x0000000189C10588-0x0000000189C106A4
			public void Destroy() {} // 0x0000000189C1050C-0x0000000189C10588
			public void UpdateActiveFingers() {} // 0x0000000189C106A4-0x0000000189C107A8
			public void UpdateActiveTouches() {} // 0x0000000182CAD7B0-0x0000000182CAD9E0
		}
	
		internal struct ExtraDataPerTouchState // TypeDefIndex: 44369
		{
			// Fields
			public Vector2 accumulatedDelta; // 0x00
			public uint uniqueId; // 0x08
		}
	
		// Constructors
		internal Touch(Finger finger, InputStateHistory<TouchState> touchRecord) : this() {
			m_Finger = default;
			m_TouchRecord = default;
		} // 0x00000001830BA9B0-0x00000001830BA9E0
		static Touch() {
			s_GlobalState = default;
		} // 0x0000000183B73B60-0x0000000183B73C50
	
		// Methods
		public override string ToString() => default; // 0x0000000189C1AC1C-0x0000000189C1AE8C
		public bool Equals(Touch other) => default; // 0x0000000189C1A6F0-0x0000000189C1A77C
		public override bool Equals(object obj) => default; // 0x0000000189C1A77C-0x0000000189C1A818
		public override int GetHashCode() => default; // 0x0000000189C1A818-0x0000000189C1A87C
		internal static void AddTouchscreen(Touchscreen screen) {} // 0x0000000182CAC660-0x0000000182CAC6F0
		internal static void RemoveTouchscreen(Touchscreen screen) {} // 0x0000000189C1A87C-0x0000000189C1A93C
		internal static void BeginUpdate() {} // 0x00000001831ABFD0-0x00000001831AC030
		private static GlobalState CreateGlobalState() => default; // 0x0000000183D78070-0x0000000183D780A0
		internal static ISavedState SaveAndResetState() => default; // 0x0000000189C1A93C-0x0000000189C1AC1C
	}

	public struct TouchHistory : IReadOnlyList<Touch> // TypeDefIndex: 44373
	{
		// Fields
		private readonly InputStateHistory<TouchState> m_History; // 0x00
		private readonly Finger m_Finger; // 0x08
		private readonly int m_Count; // 0x10
		private readonly int m_StartIndex; // 0x14
		private readonly uint m_Version; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public Touch this[int index] { get => default; } // 0x0000000189C18674-0x0000000189C187E4 
	
		// Nested types
		private class Enumerator : IEnumerator<Touch> // TypeDefIndex: 44372
		{
			// Fields
			private readonly TouchHistory m_Owner; // 0x10
			private int m_Index; // 0x30
	
			// Properties
			public Touch Current { get => default; } // 0x0000000189C104C4-0x0000000189C1050C 
			object IEnumerator.Current { get => default; } // 0x0000000189C103B8-0x0000000189C10418 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(TouchHistory owner) {} // 0x0000000189C10460-0x0000000189C1048C
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189C102DC-0x0000000189C102F8
			public void Reset() {} // 0x0000000183D5C430-0x0000000183D5C440
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1 /* Metadata: 0x01FB69B2 */, int count = -1 /* Metadata: 0x01FB69B3 */) : this() {
			m_History = default;
			m_Finger = default;
			m_Count = default;
			m_StartIndex = default;
			m_Version = default;
		} // 0x0000000189C18608-0x0000000189C18674
	
		// Methods
		public IEnumerator<Touch> GetEnumerator() => default; // 0x0000000189C18580-0x0000000189C18600
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189C18600-0x0000000189C18608
		internal void CheckValid() {} // 0x0000000189C184B4-0x0000000189C18580
	}

	[AddComponentMenu("Input/Debug/Touch Simulation")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/Touch.html#touch-simulation")]
	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor // TypeDefIndex: 44374
	{
		// Fields
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
		public Touchscreen simulatedTouchscreen { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public static TouchSimulation instance { get => default; } // 0x0000000189C1A340-0x0000000189C1A378 
	
		// Constructors
		public TouchSimulation() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void Enable() {} // 0x0000000189C18A60-0x0000000189C18B88
		public static void Disable() {} // 0x0000000189C189F4-0x0000000189C18A60
		public static void Destroy() {} // 0x0000000189C18928-0x0000000189C189F4
		protected void AddPointer(UnityEngine.InputSystem.Pointer pointer) {} // 0x0000000189C187E4-0x0000000189C18928
		protected void RemovePointer(UnityEngine.InputSystem.Pointer pointer) {} // 0x0000000189C19F88-0x0000000189C1A138
		private void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189C19300-0x0000000189C19F88
		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000189C18B88-0x0000000189C18C54
		protected void OnEnable() {} // 0x0000000189C18D7C-0x0000000189C19300
		protected void OnDisable() {} // 0x0000000189C18C54-0x0000000189C18D7C
		private void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, InputEventPtr eventPtr = default) {} // 0x0000000189C1A138-0x0000000189C1A340
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x000000018350B670-0x000000018350B680
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x000000018350B670-0x000000018350B680
		protected void InstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x01FB69B4 */) {} // 0x000000018350B670-0x000000018350B680
		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex) {} // 0x000000018350B670-0x000000018350B680
		protected void UninstallStateChangeMonitors(int startIndex = 0 /* Metadata: 0x01FB69B5 */) {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble // TypeDefIndex: 44399
	{
		// Properties
		public float lowFrequencyMotorSpeed { [IsReadOnly] get; private set; } // 0x0000000183D4FA00-0x0000000183D4FA10 0x0000000183D58BD0-0x0000000183D58BE0
		public float highFrequencyMotorSpeed { [IsReadOnly] get; private set; } // 0x0000000183D58BC0-0x0000000183D58BD0 0x0000000183D58BF0-0x0000000183D58C00
		public bool isRumbling { get => default; } // 0x0000000189C0E184-0x0000000189C0E1B8 
	
		// Methods
		public void PauseHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189C0DE5C-0x0000000189C0DF34
		public void ResumeHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189C0DFCC-0x0000000189C0E068
		public void ResetHaptics(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189C0DF34-0x0000000189C0DFCC
		public void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency) {} // 0x0000000189C0E068-0x0000000189C0E184
	}

	public interface IDualMotorRumble : IHaptics // TypeDefIndex: 44400
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency);
	}

	public interface IHaptics // TypeDefIndex: 44401
	{
		// Methods
		void PauseHaptics();
		void ResumeHaptics();
		void ResetHaptics();
	}
}

namespace UnityEngine.InputSystem.HID
{
	public class HID : UnityEngine.InputSystem.InputDevice // TypeDefIndex: 44357
	{
		// Fields
		internal const string kHIDInterface = "HID"; // Metadata: 0x01FB6873
		internal const string kHIDNamespace = "HID"; // Metadata: 0x01FB6877
		private bool m_HaveParsedHIDDescriptor; // 0x190
		private HIDDeviceDescriptor m_HIDDescriptor; // 0x198
		private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x00
	
		// Properties
		public static FourCC QueryHIDReportDescriptorDeviceCommandType { get => default; } // 0x0000000183D77560-0x0000000183D77570 
		public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType { get => default; } // 0x0000000183D77570-0x0000000183D77580 
		public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType { get => default; } // 0x0000000183D77550-0x0000000183D77560 
		public HIDDeviceDescriptor hidDescriptor { get => default; } // 0x0000000189C04AF4-0x0000000189C04C1C 
	
		// Nested types
		[Serializable]
		private class HIDLayoutBuilder // TypeDefIndex: 44344
		{
			// Fields
			public string displayName; // 0x10
			public HIDDeviceDescriptor hidDescriptor; // 0x18
			public string parentLayout; // 0x48
			public System.Type deviceType; // 0x50
	
			// Constructors
			public HIDLayoutBuilder() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public InputControlLayout Build() => default; // 0x0000000189C03C00-0x0000000189C04A0C
		}
	
		public enum HIDReportType // TypeDefIndex: 44345
		{
			Unknown = 0,
			Input = 1,
			Output = 2,
			Feature = 3
		}
	
		public enum HIDCollectionType // TypeDefIndex: 44346
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
		public enum HIDElementFlags // TypeDefIndex: 44347
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
		public struct HIDElementDescriptor // TypeDefIndex: 44348
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
			public bool hasNullState { get => default; } // 0x0000000189C12C00-0x0000000189C12C0C 
			public bool hasPreferredState { get => default; } // 0x0000000189C12C0C-0x0000000189C12C18 
			public bool isArray { get => default; } // 0x0000000189C12C18-0x0000000189C12C24 
			public bool isNonLinear { get => default; } // 0x0000000189C12C2C-0x0000000189C12C38 
			public bool isRelative { get => default; } // 0x0000000189C12C38-0x0000000189C12C44 
			public bool isConstant { get => default; } // 0x0000000189C12C24-0x0000000189C12C2C 
			public bool isWrapping { get => default; } // 0x0000000189C12C4C-0x0000000189C12C58 
			internal bool isSigned { get => default; } // 0x0000000189C12C44-0x0000000189C12C4C 
			internal float minFloatValue { get => default; } // 0x0000000189C12CC0-0x0000000189C12D28 
			internal float maxFloatValue { get => default; } // 0x0000000189C12C58-0x0000000189C12CC0 
	
			// Methods
			public bool Is(UsagePage usagePage, int usage) => default; // 0x0000000189C12BF0-0x0000000189C12C00
			internal string DetermineName() => default; // 0x0000000189C126E8-0x0000000189C128A4
			internal string DetermineDisplayName() => default; // 0x0000000189C12430-0x0000000189C124F0
			internal bool IsUsableElement() => default; // 0x0000000189C12BC4-0x0000000189C12BF0
			internal string DetermineLayout() => default; // 0x0000000189C125F4-0x0000000189C126E8
			internal FourCC DetermineFormat() => default; // 0x0000000189C124F0-0x0000000189C125F4
			internal InternedString[] DetermineUsages() => default; // 0x0000000189C12A30-0x0000000189C12BC4
			internal string DetermineParameters() => default; // 0x0000000189C128A4-0x0000000189C129E0
			private string DetermineAxisNormalizationParameters() => default; // 0x0000000189C121B0-0x0000000189C12310
			internal string DetermineProcessors() => default; // 0x0000000189C129E0-0x0000000189C12A30
			internal PrimitiveValue DetermineDefaultState() => default; // 0x0000000189C12310-0x0000000189C12430
			internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder) {} // 0x0000000189C11B2C-0x0000000189C121B0
		}
	
		[Serializable]
		public struct HIDCollectionDescriptor // TypeDefIndex: 44349
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
		public struct HIDDeviceDescriptor // TypeDefIndex: 44350
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
			public string ToJson() => default; // 0x0000000189C11AC8-0x0000000189C11B2C
			public static HIDDeviceDescriptor FromJson(string json) => default; // 0x000000018237B550-0x000000018237FE90
		}
	
		public struct HIDDeviceDescriptorBuilder // TypeDefIndex: 44351
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
			} // 0x0000000183D77C10-0x0000000183D77C40
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
			} // 0x0000000183D77BE0-0x0000000183D77C10
	
			// Methods
			public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1 /* Metadata: 0x01FB6892 */) => default; // 0x0000000183D77BA0-0x0000000183D77BE0
			public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) => default; // 0x0000000189C11304-0x0000000189C116C8
			public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) => default; // 0x0000000189C116C8-0x0000000189C11718
			public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) => default; // 0x0000000189C1194C-0x0000000189C11AC8
			public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) => default; // 0x0000000189C117D0-0x0000000189C1194C
			public HIDDeviceDescriptor Finish() => default; // 0x0000000189C11718-0x0000000189C117D0
		}
	
		public enum UsagePage // TypeDefIndex: 44352
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
	
		public enum GenericDesktop // TypeDefIndex: 44353
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
	
		public enum Simulation // TypeDefIndex: 44354
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
	
		public enum Button // TypeDefIndex: 44355
		{
			Undefined = 0,
			Primary = 1,
			Secondary = 2,
			Tertiary = 3
		}
	
		// Constructors
		public HID() {} // 0x0000000184275C10-0x0000000184275C18
		static HID() {} // 0x0000000183D07010-0x0000000183D07070
	
		// Methods
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) => default; // 0x0000000182CADE20-0x0000000182CAE130
		internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) => default; // 0x0000000182CAE1E0-0x0000000182CAEF20
		public static string UsagePageToString(UsagePage usagePage) => default; // 0x0000000189C04A0C-0x0000000189C04A78
		public static string UsageToString(UsagePage usagePage, int usage) => default; // 0x0000000189C04A78-0x0000000189C04AF4
	}

	internal static class HIDParser // TypeDefIndex: 44362
	{
		// Nested types
		private struct HIDReportData // TypeDefIndex: 44358
		{
			// Fields
			public int reportId; // 0x00
			public HID.HIDReportType reportType; // 0x04
			public int currentBitOffset; // 0x08
	
			// Methods
			public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDReportData> reports) => default; // 0x0000000189C13F28-0x0000000189C14050
		}
	
		private enum HIDItemTypeAndTag // TypeDefIndex: 44359
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
	
		private struct HIDItemStateLocal // TypeDefIndex: 44360
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
			public static void Reset(ref HIDItemStateLocal state) {} // 0x0000000189C12FD0-0x0000000189C13030
			public void SetUsage(int value) {} // 0x0000000189C13030-0x0000000189C13130
			public int GetUsage(int index) => default; // 0x0000000189C12EE0-0x0000000189C12FD0
		}
	
		private struct HIDItemStateGlobal // TypeDefIndex: 44361
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
			public HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState) => default; // 0x0000000189C12E68-0x0000000189C12EE0
			public int GetPhysicalMin() => default; // 0x0000000189C12DC8-0x0000000189C12E68
			public int GetPhysicalMax() => default; // 0x0000000189C12D28-0x0000000189C12DC8
		}
	
		// Methods
		public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor) => default; // 0x0000000189C13130-0x0000000189C131C4
		public static unsafe bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor) => default; // 0x0000000189C131C4-0x0000000189C13ED4
		private static unsafe int ReadData(int itemSize, byte* currentPtr, byte* endPtr) => default; // 0x0000000189C13ED4-0x0000000189C13F28
	}

	public static class HIDSupport // TypeDefIndex: 44364
	{
		// Fields
		private static HIDPageUsage[] s_SupportedHIDUsages; // 0x00
	
		// Properties
		public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages { get; set; } // 0x0000000182CAE130-0x0000000182CAE1E0 0x0000000189C14050-0x0000000189C14298
	
		// Nested types
		public struct HIDPageUsage // TypeDefIndex: 44363
		{
			// Fields
			public HID.UsagePage page; // 0x00
			public int usage; // 0x04
	
			// Constructors
			public HIDPageUsage(HID.UsagePage page, int usage) {
				this.page = default;
				this.usage = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
			public HIDPageUsage(HID.GenericDesktop usage) {
				page = default;
				this.usage = default;
			} // 0x0000000183D77C40-0x0000000183D77C50
		}
	
		// Methods
		internal static void Initialize() {} // 0x0000000182F182A0-0x0000000182F18430
	}
}

namespace UnityEngine.InputSystem.Interactions
{
	[System.ComponentModel.DisplayName("Hold")]
	public class HoldInteraction : IInputInteraction // TypeDefIndex: 44584
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TimePressed; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x0000000189BBD968-0x0000000189BBD9C4 
		private float pressPointOrDefault { get => default; } // 0x0000000189BBD9C4-0x0000000189BBDA10 
	
		// Constructors
		public HoldInteraction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x0000000189BBD87C-0x0000000189BBD968
		public void Reset() {} // 0x0000000183D76D20-0x0000000183D76D30
	}

	public class MultiTapInteraction : IInputInteraction<float> // TypeDefIndex: 44586
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
		private float tapTimeOrDefault { get => default; } // 0x0000000189BC6558-0x0000000189BC65B4 
		internal float tapDelayOrDefault { get => default; } // 0x0000000189BC64FC-0x0000000189BC6558 
		private float pressPointOrDefault { get => default; } // 0x0000000189BC6468-0x0000000189BC64B4 
		private float releasePointOrDefault { get => default; } // 0x0000000189BC64B4-0x0000000189BC64FC 
	
		// Nested types
		private enum TapPhase // TypeDefIndex: 44585
		{
			None = 0,
			WaitingForNextRelease = 1,
			WaitingForNextPress = 2
		}
	
		// Constructors
		public MultiTapInteraction() {} // 0x0000000183D56C80-0x0000000183D56C90
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x0000000189BC6294-0x0000000189BC6468
		public void Reset() {} // 0x0000000183D76E00-0x0000000183D76E10
	}

	[System.ComponentModel.DisplayName("Press")]
	public class PressInteraction : IInputInteraction // TypeDefIndex: 44587
	{
		// Fields
		[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to \'Default Press Point\' in the global input settings.")]
		public float pressPoint; // 0x10
		[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
		public PressBehavior behavior; // 0x14
		private bool m_WaitingForRelease; // 0x18
	
		// Properties
		private float pressPointOrDefault { get => default; } // 0x0000000189BC6724-0x0000000189BC6770 
		private float releasePointOrDefault { get => default; } // 0x0000000189BC6770-0x0000000189BC67B8 
	
		// Constructors
		public PressInteraction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x0000000189BC65B4-0x0000000189BC6724
		public void Reset() {} // 0x0000000183D566B0-0x0000000183D566C0
	}

	public enum PressBehavior // TypeDefIndex: 44588
	{
		PressOnly = 0,
		ReleaseOnly = 1,
		PressAndRelease = 2
	}

	[System.ComponentModel.DisplayName("Long Tap")]
	public class SlowTapInteraction : IInputInteraction // TypeDefIndex: 44589
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_SlowTapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x0000000189BC6ED8-0x0000000189BC6F34 
		private float pressPointOrDefault { get => default; } // 0x0000000189BC6F34-0x0000000189BC6F80 
	
		// Constructors
		public SlowTapInteraction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x0000000189BC6E2C-0x0000000189BC6ED8
		public void Reset() {} // 0x0000000183D76D20-0x0000000183D76D30
	}

	[System.ComponentModel.DisplayName("Tap")]
	public class TapInteraction : IInputInteraction // TypeDefIndex: 44590
	{
		// Fields
		public float duration; // 0x10
		public float pressPoint; // 0x14
		private double m_TapStartTime; // 0x18
	
		// Properties
		private float durationOrDefault { get => default; } // 0x0000000189BC7164-0x0000000189BC71C0 
		private float pressPointOrDefault { get => default; } // 0x0000000189BC71C0-0x0000000189BC720C 
		private float releasePointOrDefault { get => default; } // 0x0000000189BC720C-0x0000000189BC7254 
	
		// Constructors
		public TapInteraction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Process(ref InputInteractionContext context) {} // 0x0000000189BC7088-0x0000000189BC7164
		public void Reset() {} // 0x0000000183D76D20-0x0000000183D76D30
	}
}

namespace UnityEngine.InputSystem.Layouts
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public sealed class InputControlAttribute : PropertyAttribute // TypeDefIndex: 44532
	{
		// Properties
		public string layout { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string variants { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string name { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string format { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string usage { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public string[] usages { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public string parameters { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public string processors { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public string alias { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public string[] aliases { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public string useStateFrom { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public uint bit { get; set; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 0x0000000183D4EF30-0x0000000183D4EF40
		public uint offset { get; set; } // 0x0000000183D4F400-0x0000000183D4F410 0x0000000183D4F450-0x0000000183D4F460
		public uint sizeInBits { get; set; } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public int arraySize { get; set; } // 0x0000000183D4F0D0-0x0000000183D4F0E0 0x0000000183D4F100-0x0000000183D4F110
		public string displayName { get; set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public string shortDisplayName { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public bool noisy { get; set; } // 0x0000000183D51D50-0x0000000183D51D60 0x0000000183D56D40-0x0000000183D56D50
		public bool synthetic { get; set; } // 0x0000000183D51D10-0x0000000183D51D20 0x0000000183D5B370-0x0000000183D5B380
		public bool dontReset { get; set; } // 0x0000000183D51D70-0x0000000183D51D80 0x0000000183D74F90-0x0000000183D74FA0
		public object defaultState { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public object minValue { get; set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public object maxValue { get; set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
	
		// Constructors
		public InputControlAttribute() {} // 0x0000000183D78130-0x0000000183D78140
	}

	public delegate string InputDeviceFindControlLayoutDelegate(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand); // TypeDefIndex: 44533; 0x0000000181035ED0-0x0000000181035EF0

	public class InputControlLayout // TypeDefIndex: 44553
	{
		// Fields
		private static InternedString s_DefaultVariant; // 0x00
		public const string VariantSeparator = ";"; // Metadata: 0x01FB6B8D
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
		public static InternedString DefaultVariant { get => default; } // 0x0000000189C24B58-0x0000000189C24BB4 
		public InternedString name { get => default; } // 0x00000001820B7B30-0x00000001820B7B40 
		public string displayName { get => default; } // 0x0000000189C24F40-0x0000000189C24F6C 
		public System.Type type { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public InternedString variants { get => default; } // 0x0000000183D59E20-0x0000000183D59E30 
		public FourCC stateFormat { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
		public int stateSizeInBytes { get => default; } // 0x0000000183D4ED90-0x0000000183D4EDA0 
		public IEnumerable<InternedString> baseLayouts { get => default; } // 0x0000000189C24D94-0x0000000189C24DE4 
		public IEnumerable<InternedString> appliedOverrides { get => default; } // 0x0000000189C24D44-0x0000000189C24D94 
		public ReadOnlyArray<InternedString> commonUsages { get => default; } // 0x0000000189C24E90-0x0000000189C24EE8 
		public ReadOnlyArray<ControlItem> controls { get => default; } // 0x0000000189C24EE8-0x0000000189C24F40 
		public bool updateBeforeRender { get => default; } // 0x0000000189C25028-0x0000000189C25060 
		public bool isDeviceLayout { get => default; } // 0x0000000189C24F8C-0x0000000189C25004 
		public bool isControlLayout { get => default; } // 0x0000000189C24F78-0x0000000189C24F8C 
		public bool isOverride { get => default; internal set {} } // 0x0000000189C2501C-0x0000000189C25028 0x0000000189C25150-0x0000000189C25170
		public bool isGenericTypeOfDevice { get => default; internal set {} } // 0x0000000189C25004-0x0000000189C25010 0x0000000189C25110-0x0000000189C25130
		public bool hideInUI { get => default; internal set {} } // 0x0000000189C24F6C-0x0000000189C24F78 0x0000000189C250F0-0x0000000189C25110
		public bool isNoisy { get => default; internal set {} } // 0x0000000189C25010-0x0000000189C2501C 0x0000000189C25130-0x0000000189C25150
		public bool? canRunInBackground { get => default; internal set {} } // 0x0000000189C24E34-0x0000000189C24E90 0x0000000189C25060-0x0000000189C250F0
		public ControlItem this[string path] { get => default; } // 0x0000000189C24BB4-0x0000000189C24D44 
		internal static ref Cache cache { get => default; } // 0x0000000189C24DE4-0x0000000189C24E34 
	
		// Nested types
		public struct ControlItem // TypeDefIndex: 44535
		{
			// Properties
			public InternedString name { [IsReadOnly] get; internal set; } // 0x0000000183D5B250-0x0000000183D5B260 0x0000000185A40414-0x0000000185A40420
			public InternedString layout { [IsReadOnly] get; internal set; } // 0x00000001820B7B30-0x00000001820B7B40 0x000000018229DBD0-0x000000018229DBE0
			public InternedString variants { [IsReadOnly] get; internal set; } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000184276CC0-0x0000000184276CD0
			public string useStateFrom { [IsReadOnly] get; internal set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
			public string displayName { [IsReadOnly] get; internal set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
			public string shortDisplayName { [IsReadOnly] get; internal set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
			public ReadOnlyArray<InternedString> usages { [IsReadOnly] get; internal set; } // 0x0000000183D5AAD0-0x0000000183D5AAE0 0x0000000185B96C48-0x0000000185B96C58
			public ReadOnlyArray<InternedString> aliases { [IsReadOnly] get; internal set; } // 0x0000000183D50820-0x0000000183D50830 0x0000000185B7C8D4-0x0000000185B7C8E4
			public ReadOnlyArray<NamedValue> parameters { [IsReadOnly] get; internal set; } // 0x0000000183D5D750-0x0000000183D5D760 0x0000000189C1F5E0-0x0000000189C1F5F0
			public ReadOnlyArray<NameAndParameters> processors { [IsReadOnly] get; internal set; } // 0x0000000183D58660-0x0000000183D58670 0x0000000185915CE0-0x0000000185915CF0
			public uint offset { [IsReadOnly] get; internal set; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x0000000183D4F0E0-0x0000000183D4F0F0
			public uint bit { [IsReadOnly] get; internal set; } // 0x0000000183D4F3D0-0x0000000183D4F3E0 0x0000000183D4F420-0x0000000183D4F430
			public uint sizeInBits { [IsReadOnly] get; internal set; } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
			public FourCC format { [IsReadOnly] get; internal set; } // 0x0000000183D5B3A0-0x0000000183D5B3B0 0x0000000183D5B3D0-0x0000000183D5B3E0
			private Flags flags { [IsReadOnly] get; set; } // 0x0000000183D4EB50-0x0000000183D4EB60 0x0000000183D4EB80-0x0000000183D4EB90
			public int arraySize { [IsReadOnly] get; internal set; } // 0x0000000183D51960-0x0000000183D51970 0x0000000183D51980-0x0000000183D51990
			public PrimitiveValue defaultState { [IsReadOnly] get; internal set; } // 0x0000000183D6C070-0x0000000183D6C080 0x0000000183D6C0F0-0x0000000183D6C100
			public PrimitiveValue minValue { [IsReadOnly] get; internal set; } // 0x0000000183D6C040-0x0000000183D6C050 0x0000000183D6C0B0-0x0000000183D6C0C0
			public PrimitiveValue maxValue { [IsReadOnly] get; internal set; } // 0x0000000183D6C030-0x0000000183D6C040 0x0000000183D6C0A0-0x0000000183D6C0B0
			public bool isModifyingExistingControl { get => default; internal set {} } // 0x0000000189C1F51C-0x0000000189C1F528 0x0000000189C1F580-0x0000000189C1F5A0
			public bool isNoisy { get => default; internal set {} } // 0x0000000189C1F528-0x0000000189C1F534 0x0000000189C1F5A0-0x0000000189C1F5C0
			public bool isSynthetic { get => default; internal set {} } // 0x0000000189C1F534-0x0000000189C1F540 0x0000000189C1F5C0-0x0000000189C1F5E0
			public bool dontReset { get => default; internal set {} } // 0x0000000189C1F504-0x0000000189C1F510 0x0000000189C1F540-0x0000000189C1F560
			public bool isFirstDefinedInThisLayout { get => default; internal set {} } // 0x0000000189C1F510-0x0000000189C1F51C 0x0000000189C1F560-0x0000000189C1F580
			public bool isArray { get => default; } // 0x00000001854E5090-0x00000001854E509C 
	
			// Nested types
			[Flags]
			private enum Flags // TypeDefIndex: 44534
			{
				isModifyingExistingControl = 1,
				IsNoisy = 2,
				IsSynthetic = 4,
				IsFirstDefinedInThisLayout = 8,
				DontReset = 16
			}
	
			// Methods
			public ControlItem Merge(ControlItem other) => default; // 0x0000000189C1F194-0x0000000189C1F504
		}
	
		public class Builder // TypeDefIndex: 44538
		{
			// Fields
			private string m_ExtendsLayout; // 0x30
			private int m_ControlCount; // 0x3C
			private ControlItem[] m_Controls; // 0x40
	
			// Properties
			public string name { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public string displayName { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public System.Type type { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
			public FourCC stateFormat { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
			public int stateSizeInBytes { get; set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
			public string extendsLayout { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000189C1C774-0x0000000189C1C794
			public bool? updateBeforeRender { get; set; } // 0x0000000183D78110-0x0000000183D78120 0x0000000183D73F30-0x0000000183D73F40
			public ReadOnlyArray<ControlItem> controls { get => default; } // 0x0000000189C1C714-0x0000000189C1C774 
	
			// Nested types
			public struct ControlBuilder // TypeDefIndex: 44537
			{
				// Fields
				internal Builder builder; // 0x00
				internal int index; // 0x08
	
				// Methods
				public ControlBuilder WithDisplayName(string displayName) => default; // 0x0000000189C1DAB8-0x0000000189C1DB18
				public ControlBuilder WithLayout(string layout) => default; // 0x0000000189C1DBC4-0x0000000189C1DCCC
				public ControlBuilder WithFormat(FourCC format) => default; // 0x0000000189C1DB6C-0x0000000189C1DBC4
				public ControlBuilder WithFormat(string format) => default; // 0x0000000189C1DB18-0x0000000189C1DB6C
				public ControlBuilder WithByteOffset(uint offset) => default; // 0x0000000189C1DA00-0x0000000189C1DA58
				public ControlBuilder WithBitOffset(uint bit) => default; // 0x0000000189C1D9A8-0x0000000189C1DA00
				public ControlBuilder IsSynthetic(bool value) => default; // 0x0000000189C1D8C8-0x0000000189C1D934
				public ControlBuilder IsNoisy(bool value) => default; // 0x0000000189C1D85C-0x0000000189C1D8C8
				public ControlBuilder DontReset(bool value) => default; // 0x0000000189C1D7F0-0x0000000189C1D85C
				public ControlBuilder WithSizeInBits(uint sizeInBits) => default; // 0x0000000189C1DF40-0x0000000189C1DF98
				public ControlBuilder WithRange(float minValue, float maxValue) => default; // 0x0000000189C1DE80-0x0000000189C1DF40
				public ControlBuilder WithUsages(params InternedString[] usages) => default; // 0x0000000189C1DF98-0x0000000189C1E174
				public ControlBuilder WithUsages(IEnumerable<string> usages) => default; // 0x0000000189C1E174-0x0000000189C1E2CC
				public ControlBuilder WithUsages(params string[] usages) => default; // 0x0000000189C1E2CC-0x0000000189C1E2F4
				public ControlBuilder WithParameters(string parameters) => default; // 0x0000000189C1DCCC-0x0000000189C1DD98
				public ControlBuilder WithProcessors(string processors) => default; // 0x0000000189C1DD98-0x0000000189C1DE80
				public ControlBuilder WithDefaultState(PrimitiveValue value) => default; // 0x0000000189C1DA58-0x0000000189C1DAB8
				public ControlBuilder UsingStateFrom(string path) => default; // 0x0000000189C1D934-0x0000000189C1D9A8
				public ControlBuilder AsArrayOfControlsWithSize(int arraySize) => default; // 0x0000000189C1D798-0x0000000189C1D7F0
			}
	
			// Constructors
			public Builder() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public ControlBuilder AddControl(string name) => default; // 0x0000000189C1C2E4-0x0000000189C1C4C0
			public Builder WithName(string name) => default; // 0x000000018574BE68-0x000000018574BE84
			public Builder WithDisplayName(string displayName) => default; // 0x000000018574BE84-0x000000018574BEA0
			public Builder WithType<T>()
				where T : InputControl => default;
			public Builder WithFormat(FourCC format) => default; // 0x0000000183D780F0-0x0000000183D78100
			public Builder WithFormat(string format) => default; // 0x0000000189C1C6E4-0x0000000189C1C714
			public Builder WithSizeInBytes(int sizeInBytes) => default; // 0x0000000183D78100-0x0000000183D78110
			public Builder Extend(string baseLayoutName) => default; // 0x0000000189C1C6C8-0x0000000189C1C6E4
			public InputControlLayout Build() => default; // 0x0000000189C1C4C0-0x0000000189C1C6C8
		}
	
		[Flags]
		private enum Flags // TypeDefIndex: 44539
		{
			IsGenericTypeOfDevice = 1,
			HideInUI = 2,
			IsOverride = 4,
			CanRunInBackground = 8,
			CanRunInBackgroundIsSet = 16,
			IsNoisy = 32
		}
	
		[Serializable]
		internal struct LayoutJsonNameAndDescriptorOnly // TypeDefIndex: 44540
		{
			// Fields
			public string name; // 0x00
			public string extend; // 0x08
			public string[] extendMultiple; // 0x10
			public InputDeviceMatcher.MatcherJson device; // 0x18
		}
	
		[Serializable]
		private struct LayoutJson // TypeDefIndex: 44542
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
	
			// Methods
			public InputControlLayout ToLayout() => default; // 0x0000000189C28A54-0x0000000189C293D8
			public static LayoutJson FromLayout(InputControlLayout layout) => default; // 0x0000000189C28698-0x0000000189C28A54
		}
	
		[Serializable]
		private class ControlItemJson // TypeDefIndex: 44544
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
	
			// Constructors
			public ControlItemJson() {} // 0x0000000183D78120-0x0000000183D78130
	
			// Methods
			public ControlItem ToLayout() => default; // 0x0000000189C1EABC-0x0000000189C1F194
			public static ControlItemJson[] FromControlItems(ControlItem[] items) => default; // 0x0000000189C1E2F4-0x0000000189C1EABC
		}
	
		internal struct Collection // TypeDefIndex: 44548
		{
			// Fields
			public const float kBaseScoreForNonGeneratedLayouts = 1f; // Metadata: 0x01FB6B9B
			public Dictionary<InternedString, System.Type> layoutTypes; // 0x00
			public Dictionary<InternedString, string> layoutStrings; // 0x08
			public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders; // 0x10
			public Dictionary<InternedString, InternedString> baseLayoutTable; // 0x18
			public Dictionary<InternedString, InternedString[]> layoutOverrides; // 0x20
			public HashSet<InternedString> layoutOverrideNames; // 0x28
			public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; // 0x30
			public List<LayoutMatcher> layoutMatchers; // 0x38
	
			// Nested types
			public struct LayoutMatcher // TypeDefIndex: 44545
			{
				// Fields
				public InternedString layoutName; // 0x00
				public InputDeviceMatcher deviceMatcher; // 0x10
			}
	
			public struct PrecompiledLayout // TypeDefIndex: 44546
			{
				// Fields
				public Func<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x00
				public string metadata; // 0x08
			}
	
			// Methods
			public void Allocate() {} // 0x00000001822F7F30-0x00000001822F81C0
			public InternedString TryFindLayoutForType(System.Type layoutType) => default; // 0x00000001822FA200-0x00000001822FA3A0
			public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) => default; // 0x0000000182360F90-0x0000000182361130
			public bool HasLayout(InternedString name) => default; // 0x00000001822FACF0-0x00000001822FADD0
			private InputControlLayout TryLoadLayoutInternal(InternedString name) => default; // 0x0000000189C1CDDC-0x0000000189C1CFCC
			public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null) => default; // 0x0000000189C1CFCC-0x0000000189C1D3F0
			public InternedString GetBaseLayoutName(InternedString layoutName) => default; // 0x0000000189C1CB18-0x0000000189C1CBA0
			public InternedString GetRootLayoutName(InternedString layoutName) => default; // 0x0000000189C1CC68-0x0000000189C1CCF4
			public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance) {
				distance = default;
				return default;
			} // 0x0000000189C1C868-0x0000000189C1C944
			public InternedString FindLayoutThatIntroducesControl(InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache) => default; // 0x0000000189C1C944-0x0000000189C1CB18
			public System.Type GetControlTypeForLayout(InternedString layoutName) => default; // 0x000000018235EAD0-0x000000018235EBB0
			public bool ValueTypeIsAssignableFrom(InternedString layoutName, System.Type valueType) => default; // 0x0000000189C1D3F0-0x0000000189C1D4C0
			public bool IsGeneratedLayout(InternedString layout) => default; // 0x0000000189C1CD80-0x0000000189C1CDDC
			[IteratorStateMachine(typeof(_GetBaseLayouts_d__24))]
			public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true /* Metadata: 0x01FB6B9A */) => default; // 0x0000000189C1CBA0-0x0000000189C1CC68
			public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) => default; // 0x0000000189C1CCF4-0x0000000189C1CD80
			public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) {} // 0x0000000182361130-0x00000001823612D0
		}
	
		public class LayoutNotFoundException : Exception // TypeDefIndex: 44549
		{
			// Properties
			public string layout { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
	
			// Constructors
			public LayoutNotFoundException() {} // 0x0000000189BC5DB4-0x0000000189BC5E00
			public LayoutNotFoundException(string name, string message) {} // 0x0000000189BC5F04-0x0000000189BC5F74
			public LayoutNotFoundException(string name) {} // 0x0000000189BC5E00-0x0000000189BC5EA4
			public LayoutNotFoundException(string message, Exception innerException) {} // 0x0000000189BC5EA4-0x0000000189BC5F04
			protected LayoutNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x0000000189BC5F74-0x0000000189BC5FE0
		}
	
		internal struct Cache // TypeDefIndex: 44550
		{
			// Fields
			public Dictionary<InternedString, InputControlLayout> table; // 0x00
	
			// Methods
			public void Clear() {} // 0x000000018426F744-0x000000018426F750
			public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true /* Metadata: 0x01FB6B9F */) => default; // 0x0000000189BBC738-0x0000000189BBC87C
		}
	
		internal struct CacheRefInstance : IDisposable // TypeDefIndex: 44551
		{
			// Fields
			public bool valid; // 0x00
	
			// Methods
			public void Dispose() {} // 0x0000000189BBC6A4-0x0000000189BBC738
		}
	
		// Constructors
		public InputControlLayout() {} // Dummy constructor
		private InputControlLayout(string name, System.Type type) {} // 0x0000000189C24B08-0x0000000189C24B58
		static InputControlLayout() {} // 0x0000000183CF8C90-0x0000000183CF8D10
	
		// Methods
		public ControlItem? FindControl(InternedString path) => default; // 0x0000000189C21124-0x0000000189C21410
		public ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex) {
			arrayIndex = default;
			return default;
		} // 0x0000000189C20D48-0x0000000189C21124
		public System.Type GetValueType() => default; // 0x0000000189C21900-0x0000000189C21974
		public static InputControlLayout FromType(string name, System.Type type) => default; // 0x0000000189C214AC-0x0000000189C21900
		public string ToJson() => default; // 0x0000000189C248AC-0x0000000189C24950
		public static InputControlLayout FromJson(string json) => default; // 0x0000000189C21410-0x0000000189C214AC
		private static void AddControlItems(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x0000000189C1FFD4-0x0000000189C20048
		private static void AddControlItemsFromFields(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x0000000189C1F824-0x0000000189C1F8A0
		private static void AddControlItemsFromProperties(System.Type type, List<ControlItem> controlLayouts, string layoutName) {} // 0x0000000189C1FF58-0x0000000189C1FFD4
		private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName) {} // 0x0000000189C1FAB4-0x0000000189C1FF58
		private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems) {} // 0x0000000189C1F8A0-0x0000000189C1FAB4
		private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) => default; // 0x0000000189C200A0-0x0000000189C209C4
		private static string InferLayoutFromValueType(System.Type type) => default; // 0x0000000189C21974-0x0000000189C21B54
		public void MergeLayout(InputControlLayout other) {} // 0x0000000189C21B54-0x0000000189C248AC
		private static Dictionary<string, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<string> variants = null) => default; // 0x0000000189C209C4-0x0000000189C20D48
		internal static bool VariantsMatch(InternedString expected, InternedString actual) => default; // 0x0000000189C249C4-0x0000000189C24A20
		internal static bool VariantsMatch(string expected, string actual) => default; // 0x0000000189C24A20-0x0000000189C24B08
		internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher) {
			name = default;
			baseLayouts = default;
			deviceMatcher = default;
		} // 0x0000000182F17C20-0x0000000182F17DA0
		internal static CacheRefInstance CacheRef() => default; // 0x0000000189C20048-0x0000000189C200A0
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class InputControlLayoutAttribute : Attribute // TypeDefIndex: 44554
	{
		// Fields
		internal bool? canRunInBackgroundInternal; // 0x31
		internal bool? updateBeforeRenderInternal; // 0x33
	
		// Properties
		public System.Type stateType { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string stateFormat { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string[] commonUsages { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string variants { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public bool isNoisy { get; set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public bool canRunInBackground { get => default; set {} } // 0x0000000189BBEB44-0x0000000189BBEB80 0x0000000189BBEBBC-0x0000000189BBEC08
		public bool updateBeforeRender { get => default; set {} } // 0x0000000189BBEB80-0x0000000189BBEBBC 0x0000000189BBEC08-0x0000000189BBEC54
		public bool isGenericTypeOfDevice { get; set; } // 0x0000000183D4F560-0x0000000183D4F570 0x0000000183D4F580-0x0000000183D4F590
		public string displayName { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public string description { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public bool hideInUI { get; set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Constructors
		public InputControlLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal struct InputDeviceBuilder : IDisposable // TypeDefIndex: 44556
	{
		// Fields
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x00
		private InputControlLayout.CacheRefInstance m_LayoutCacheRef; // 0x08
		private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x10
		private List<uint> m_StateOffsetToControlMap; // 0x18
		private StringBuilder m_StringBuilder; // 0x20
		private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; // Metadata: 0x01FB6BA0
		private static InputDeviceBuilder s_Instance; // 0x00
		private static int s_InstanceRef; // 0x28
	
		// Properties
		internal static ref InputDeviceBuilder instance { get => default; } // 0x0000000189BC34B0-0x0000000189BC34E4 
	
		// Nested types
		internal struct RefInstance : IDisposable // TypeDefIndex: 44555
		{
			// Methods
			public void Dispose() {} // 0x0000000189BC6D98-0x0000000189BC6E2C
		}
	
		// Methods
		public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = default) {} // 0x0000000189BC32E0-0x0000000189BC344C
		public UnityEngine.InputSystem.InputDevice Finish() => default; // 0x0000000189BC14E0-0x0000000189BC18A8
		public void Dispose() {} // 0x0000000189BC0D84-0x0000000189BC0D90
		private void Reset() {} // 0x0000000189BC2F90-0x0000000189BC2FF8
		private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) => default; // 0x0000000189BC2ED0-0x0000000189BC2F50
		private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) => default; // 0x0000000189BC281C-0x0000000189BC2ED0
		private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) {} // 0x0000000189BBF638-0x0000000189BBFD6C
		private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null) => default; // 0x0000000189BBED1C-0x0000000189BBF638
		private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem) {} // 0x0000000189BC1DD0-0x0000000189BC2108
		private string ChildControlOverridePath(InputControl parent, InternedString controlName) => default; // 0x0000000189BC0478-0x0000000189BC04F0
		private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) {} // 0x0000000189BBEC54-0x0000000189BBED1C
		private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) => default; // 0x0000000189BC2108-0x0000000189BC2520
		private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout) {} // 0x0000000189BC02A8-0x0000000189BC0478
		private static void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, InputControl exceptControl) {} // 0x0000000189BC344C-0x0000000189BC34B0
		private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) {} // 0x0000000189BC2FF8-0x0000000189BC3250
		private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) {} // 0x0000000189BBFFF8-0x0000000189BC0094
		private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName) {} // 0x0000000189BC0094-0x0000000189BC02A8
		private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem) {} // 0x0000000189BC3250-0x0000000189BC32E0
		private static InputControlLayout FindOrLoadLayout(string name) => default; // 0x0000000189BC1490-0x0000000189BC14E0
		private static void ComputeStateLayout(InputControl control) {} // 0x0000000189BC04F0-0x0000000189BC0D84
		private void FinalizeControlHierarchy() {} // 0x0000000189BC11F4-0x0000000189BC1490
		private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) {} // 0x0000000189BC0D90-0x0000000189BC11F4
		private void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset) {} // 0x0000000189BC2520-0x0000000189BC281C
		private ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset) => default; // 0x0000000189BC18A8-0x0000000189BC1D08
		private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) {} // 0x0000000189BBFE9C-0x0000000189BBFFF8
		private void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right) {} // 0x0000000189BBFD6C-0x0000000189BBFE9C
		private ushort GetControlIndex(InputControl control) => default; // 0x0000000189BC1D08-0x0000000189BC1DD0
		internal static RefInstance Ref() => default; // 0x0000000189BC2F50-0x0000000189BC2F90
	}

	[Serializable]
	public struct InputDeviceDescription : IEquatable<InputDeviceDescription> // TypeDefIndex: 44558
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
		public string interfaceName { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public string deviceClass { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public string manufacturer { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string product { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string serial { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string version { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string capabilities { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public bool empty { get => default; } // 0x0000000189BC3B68-0x0000000189BC3BD0 
	
		// Nested types
		private struct DeviceDescriptionJson // TypeDefIndex: 44557
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
		public override string ToString() => default; // 0x0000000189BC3954-0x0000000189BC3B68
		public bool Equals(InputDeviceDescription other) => default; // 0x0000000189BC363C-0x0000000189BC3734
		public override bool Equals(object obj) => default; // 0x0000000189BC35B0-0x0000000189BC363C
		public override int GetHashCode() => default; // 0x0000000189BC3734-0x0000000189BC3848
		public static bool operator ==(InputDeviceDescription left, InputDeviceDescription right) => default; // 0x0000000189BC3BD0-0x0000000189BC3C0C
		public static bool operator !=(InputDeviceDescription left, InputDeviceDescription right) => default; // 0x0000000189BC3C0C-0x0000000189BC3C48
		public string ToJson() => default; // 0x0000000189BC3848-0x0000000189BC3954
		public static InputDeviceDescription FromJson(string json) => default; // 0x000000018235F3D0-0x000000018235F4E0
		internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonParser.JsonString propertyValue, string deviceDescriptor) => default; // 0x0000000189BC34E4-0x0000000189BC35B0
	}

	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher> // TypeDefIndex: 44563
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
		public bool empty { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public IEnumerable<KeyValuePair<string, object>> patterns { [IteratorStateMachine(typeof(_get_patterns_d__4))] get => default; } // 0x0000000189BC40B4-0x0000000189BC4124 
	
		// Nested types
		[Serializable]
		internal struct MatcherJson // TypeDefIndex: 44560
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
			public struct Capability // TypeDefIndex: 44559
			{
				// Fields
				public string path; // 0x00
				public string value; // 0x08
			}
	
			// Methods
			public static MatcherJson FromMatcher(InputDeviceMatcher matcher) => default; // 0x0000000189BC5FE0-0x0000000189BC6294
			public InputDeviceMatcher ToMatcher() => default; // 0x0000000182F17DA0-0x0000000182F17EB0
		}
	
		// Constructors
		static InputDeviceMatcher() {
			kInterfaceKey = default;
			kDeviceClassKey = default;
			kManufacturerKey = default;
			kManufacturerContainsKey = default;
			kProductKey = default;
			kVersionKey = default;
		} // 0x00000001839C84B0-0x00000001839C86E0
	
		// Methods
		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true /* Metadata: 0x01FB6BA1 */) => default; // 0x0000000182F1A530-0x0000000182F1A5D0
		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true /* Metadata: 0x01FB6BA2 */) => default; // 0x0000000189BC3FAC-0x0000000189BC4030
		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true /* Metadata: 0x01FB6BA3 */) => default; // 0x0000000182F18660-0x0000000182F18700
		public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) => default; // 0x0000000182F185D0-0x0000000182F18660
		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true /* Metadata: 0x01FB6BA4 */) => default; // 0x0000000182F19F60-0x0000000182F1A000
		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true /* Metadata: 0x01FB6BA5 */) => default; // 0x0000000189BC4030-0x0000000189BC40B4
		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value) => default;
		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true /* Metadata: 0x01FB6BA6 */) => default; // 0x0000000182F1AE10-0x0000000182F1B070
		public float MatchPercentage(InputDeviceDescription deviceDescription) => default; // 0x0000000182361490-0x0000000182361C20
		private static bool MatchSingleProperty(object pattern, string value) => default; // 0x0000000182361C30-0x0000000182361CD0
		private static bool MatchSinglePropertyContains(object pattern, string value) => default; // 0x000000018235FEB0-0x000000018235FF30
		private static int GetNumPropertiesIn(InputDeviceDescription description) => default; // 0x0000000189BC3DEC-0x0000000189BC3E64
		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) => default; // 0x0000000189BC3CBC-0x0000000189BC3DEC
		public override string ToString() => default; // 0x0000000189BC3E64-0x0000000189BC3FAC
		public bool Equals(InputDeviceMatcher other) => default; // 0x0000000182361330-0x0000000182361470
		public override bool Equals(object obj) => default; // 0x0000000189BC3C48-0x0000000189BC3CBC
		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right) => default; // 0x00000001823612D0-0x0000000182361330
		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right) => default; // 0x0000000189BC4124-0x0000000189BC4178
		public override int GetHashCode() => default; // 0x000000018711E2B8-0x000000018711E2DC
	}
}

namespace UnityEngine.InputSystem.LowLevel
{
	public struct DisableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 44402
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x01FB69C3
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77820-0x0000000183D77830 
		public FourCC typeStatic { get => default; } // 0x0000000183D77820-0x0000000183D77830 
	
		// Methods
		public static DisableDeviceCommand Create() => default; // 0x0000000183D77800-0x0000000183D77820
	}

	public struct EnableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 44403
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x01FB69C4
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77AF0-0x0000000183D77B00 
		public FourCC typeStatic { get => default; } // 0x0000000183D77AF0-0x0000000183D77B00 
	
		// Methods
		public static EnableDeviceCommand Create() => default; // 0x0000000183D77AD0-0x0000000183D77AF0
	}

	public struct EnableIMECompositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 44404
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x01FB69C5
		public InputDeviceCommand baseCommand; // 0x00
		private byte m_ImeEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77B00-0x0000000183D77B10 
		public bool imeEnabled { get => default; } // 0x0000000189C0FE24-0x0000000189C0FE2C 
		public FourCC typeStatic { get => default; } // 0x0000000183D77B00-0x0000000183D77B10 
	
		// Methods
		public static EnableIMECompositionCommand Create(bool enabled) => default; // 0x0000000189C0FDFC-0x0000000189C0FE24
	}

	public interface IInputDeviceCommandInfo // TypeDefIndex: 44405
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo // TypeDefIndex: 44407
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x01FB69C6
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77C80-0x0000000183D77C90 
		public FourCC typeStatic { get => default; } // 0x0000000183D77C80-0x0000000183D77C90 
	
		// Nested types
		public enum Result // TypeDefIndex: 44406
		{
			ErrorAlreadyInProgress = -2,
			ErrorNotSupported = -1,
			SuccessfullyInitiated = 1
		}
	
		// Methods
		public static InitiateUserAccountPairingCommand Create() => default; // 0x0000000183D77C60-0x0000000183D77C80
	}

	public unsafe delegate long? InputDeviceCommandDelegate(UnityEngine.InputSystem.InputDevice device, InputDeviceCommand* command); // TypeDefIndex: 44408; 0x000000018500D88C-0x000000018500D8C0

	public delegate long InputDeviceExecuteCommandDelegate(ref InputDeviceCommand command); // TypeDefIndex: 44409; 0x000000018102B410-0x000000018102B420

	public struct InputDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 44410
	{
		// Fields
		internal const int kBaseCommandSize = 8; // Metadata: 0x01FB69CB
		public const int BaseCommandSize = 8; // Metadata: 0x01FB69CC
		public const long GenericFailure = -1; // Metadata: 0x01FB69CD
		public const long GenericSuccess = 1; // Metadata: 0x01FB69D5
		public FourCC type; // 0x00
		public int sizeInBytes; // 0x04
	
		// Properties
		public int payloadSizeInBytes { get => default; } // 0x0000000183D77C90-0x0000000183D77CA0 
		public unsafe void* payloadPtr { get => default; } // 0x0000000183D607B0-0x0000000183D607C0 
		public FourCC typeStatic { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public InputDeviceCommand(FourCC type, int sizeInBytes = 8 /* Metadata: 0x01FB69CA */) : this() {
			this.type = default;
			this.sizeInBytes = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	
		// Methods
		public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize) => default; // 0x0000000182CAEF20-0x0000000182CAEFC0
	}

	public struct QueryCanRunInBackground : IInputDeviceCommandInfo // TypeDefIndex: 44411
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x01FB69DD
		public InputDeviceCommand baseCommand; // 0x00
		public bool canRunInBackground; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77D50-0x0000000183D77D60 
		public FourCC typeStatic { get => default; } // 0x0000000183D77D50-0x0000000183D77D60 
	
		// Methods
		public static QueryCanRunInBackground Create() => default; // 0x00000001837B0AB0-0x00000001837B0AE0
	}

	public struct QueryDimensionsCommand : IInputDeviceCommandInfo // TypeDefIndex: 44412
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x01FB69DE
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 outDimensions; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77D90-0x0000000183D77DA0 
		public FourCC typeStatic { get => default; } // 0x0000000183D77D90-0x0000000183D77DA0 
	
		// Methods
		public static QueryDimensionsCommand Create() => default; // 0x0000000183D77D60-0x0000000183D77D90
	}

	public struct QueryEnabledStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 44413
	{
		// Fields
		internal const int kSize = 9; // Metadata: 0x01FB69DF
		public InputDeviceCommand baseCommand; // 0x00
		public bool isEnabled; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77DD0-0x0000000183D77DE0 
		public FourCC typeStatic { get => default; } // 0x0000000183D77DD0-0x0000000183D77DE0 
	
		// Methods
		public static QueryEnabledStateCommand Create() => default; // 0x0000000183D77DA0-0x0000000183D77DD0
	}

	public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo // TypeDefIndex: 44415
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x01FB69E0
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77E80-0x0000000183D77E90 
		public FourCC typeStatic { get => default; } // 0x0000000183D77E80-0x0000000183D77E90 
	
		// Methods
		public string ReadLayoutName() => default; // 0x0000000189C18198-0x0000000189C181AC
		public void WriteLayoutName(string name) {} // 0x0000000189C181AC-0x0000000189C181D8
		public static QueryKeyboardLayoutCommand Create() => default; // 0x0000000183D77E40-0x0000000183D77E80
	}

	public struct QueryKeyNameCommand : IInputDeviceCommandInfo // TypeDefIndex: 44417
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x01FB69E2
		internal const int kSize = 268; // Metadata: 0x01FB69E4
		public InputDeviceCommand baseCommand; // 0x00
		public int scanOrKeyCode; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x0C
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77E30-0x0000000183D77E40 
		public FourCC typeStatic { get => default; } // 0x0000000183D77E30-0x0000000183D77E40 
	
		// Methods
		public string ReadKeyName() => default; // 0x0000000189C18184-0x0000000189C18198
		public static QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key) => default; // 0x0000000183D77DE0-0x0000000183D77E30
	}

	public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo // TypeDefIndex: 44421
	{
		// Fields
		internal const int kMaxNameLength = 256; // Metadata: 0x01FB69E6
		internal const int kMaxIdLength = 256; // Metadata: 0x01FB69E8
		internal const int kSize = 1040; // Metadata: 0x01FB69EA
		public InputDeviceCommand baseCommand; // 0x00
		public ulong handle; // 0x08
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte nameBuffer[0]; // 0x10
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x210
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77ED0-0x0000000183D77EE0 
		public string id { get => default; set {} } // 0x0000000189C181D8-0x0000000189C181EC 0x0000000189C18200-0x0000000189C18324
		public string name { get => default; set {} } // 0x0000000189C181EC-0x0000000189C18200 0x0000000189C18324-0x0000000189C18448
		public FourCC typeStatic { get => default; } // 0x0000000183D77ED0-0x0000000183D77EE0 
	
		// Nested types
		[Flags]
		public enum Result : long // TypeDefIndex: 44418
		{
			DevicePairedToUserAccount = 2,
			UserAccountSelectionInProgress = 4,
			UserAccountSelectionComplete = 8,
			UserAccountSelectionCanceled = 16
		}
	
		// Methods
		public static QueryPairedUserAccountCommand Create() => default; // 0x0000000183D77E90-0x0000000183D77ED0
	}

	internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 44422
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x01FB6A0C
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77F10-0x0000000183D77F20 
		public FourCC typeStatic { get => default; } // 0x0000000183D77F10-0x0000000183D77F20 
	
		// Methods
		public static QuerySamplingFrequencyCommand Create() => default; // 0x0000000183D77EE0-0x0000000183D77F10
	}

	internal struct QueryUserIdCommand : IInputDeviceCommandInfo // TypeDefIndex: 44424
	{
		// Fields
		public const int kMaxIdLength = 256; // Metadata: 0x01FB6A0D
		internal const int kSize = 520; // Metadata: 0x01FB6A0F
		public InputDeviceCommand baseCommand; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte idBuffer[0]; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77F60-0x0000000183D77F70 
		public FourCC typeStatic { get => default; } // 0x0000000183D77F60-0x0000000183D77F70 
	
		// Methods
		public string ReadId() => default; // 0x0000000189C18198-0x0000000189C181AC
		public static QueryUserIdCommand Create() => default; // 0x0000000183D77F20-0x0000000183D77F60
	}

	public struct RequestResetCommand : IInputDeviceCommandInfo // TypeDefIndex: 44425
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x01FB6A11
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77F90-0x0000000183D77FA0 
		public FourCC typeStatic { get => default; } // 0x0000000183D77F90-0x0000000183D77FA0 
	
		// Methods
		public static RequestResetCommand Create() => default; // 0x0000000183D77F70-0x0000000183D77F90
	}

	public struct RequestSyncCommand : IInputDeviceCommandInfo // TypeDefIndex: 44426
	{
		// Fields
		internal const int kSize = 8; // Metadata: 0x01FB6A12
		public InputDeviceCommand baseCommand; // 0x00
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77FC0-0x0000000183D77FD0 
		public FourCC typeStatic { get => default; } // 0x0000000183D77FC0-0x0000000183D77FD0 
	
		// Methods
		public static RequestSyncCommand Create() => default; // 0x0000000183D77FA0-0x0000000183D77FC0
	}

	public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 44427
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x01FB6A13
		public InputDeviceCommand baseCommand; // 0x00
		private Vector2 m_Position; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D78010-0x0000000183D78020 
		public Vector2 position { get => default; } // 0x0000000183D67720-0x0000000183D67740 
		public FourCC typeStatic { get => default; } // 0x0000000183D78010-0x0000000183D78020 
	
		// Methods
		public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) => default; // 0x0000000183D77FF0-0x0000000183D78010
	}

	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 44428
	{
		// Fields
		internal const int kSize = 12; // Metadata: 0x01FB6A14
		public InputDeviceCommand baseCommand; // 0x00
		public float frequency; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D78050-0x0000000183D78060 
		public FourCC typeStatic { get => default; } // 0x0000000183D78050-0x0000000183D78060 
	
		// Methods
		public static SetSamplingFrequencyCommand Create(float frequency) => default; // 0x0000000183D78020-0x0000000183D78050
	}

	internal struct WarpMousePositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 44429
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x01FB6A15
		public InputDeviceCommand baseCommand; // 0x00
		public Vector2 warpPositionInPlayerDisplaySpace; // 0x08
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D780E0-0x0000000183D780F0 
		public FourCC typeStatic { get => default; } // 0x0000000183D780E0-0x0000000183D780F0 
	
		// Methods
		public static WarpMousePositionCommand Create(Vector2 position) => default; // 0x0000000183D780C0-0x0000000183D780E0
	}

	public struct GamepadState : IInputStateTypeInfo // TypeDefIndex: 44430
	{
		// Fields
		internal const string ButtonSouthShortDisplayName = "A"; // Metadata: 0x01FB6A17
		internal const string ButtonNorthShortDisplayName = "Y"; // Metadata: 0x01FB6A19
		internal const string ButtonWestShortDisplayName = "X"; // Metadata: 0x01FB6A1B
		internal const string ButtonEastShortDisplayName = "B"; // Metadata: 0x01FB6A1D
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
		public static FourCC Format { get => default; } // 0x0000000183D77B70-0x0000000183D77B80 
		public FourCC format { get => default; } // 0x0000000183D77B70-0x0000000183D77B80 
	
		// Constructors
		public GamepadState(params GamepadButton[] buttons) : this() {
			this.buttons = default;
			leftStick = default;
			rightStick = default;
			leftTrigger = default;
			rightTrigger = default;
		} // 0x0000000189C1125C-0x0000000189C11304
	
		// Methods
		public GamepadState WithButton(GamepadButton button, bool value = true /* Metadata: 0x01FB6A16 */) => default; // 0x0000000189C11218-0x0000000189C1125C
	}

	public enum GamepadButton // TypeDefIndex: 44431
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

	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo // TypeDefIndex: 44432
	{
		// Fields
		internal const int kSize = 16; // Metadata: 0x01FB6A37
		public InputDeviceCommand baseCommand; // 0x00
		public float lowFrequencyMotorSpeed; // 0x08
		public float highFrequencyMotorSpeed; // 0x0C
	
		// Properties
		public static FourCC Type { get => default; } // 0x0000000183D77860-0x0000000183D77870 
		public FourCC typeStatic { get => default; } // 0x0000000183D77860-0x0000000183D77870 
	
		// Methods
		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) => default; // 0x0000000183D77830-0x0000000183D77860
	}

	internal interface ICustomDeviceReset // TypeDefIndex: 44433
	{
		// Methods
		void Reset();
	}

	internal interface IEventMerger // TypeDefIndex: 44434
	{
		// Methods
		bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr);
	}

	internal interface IEventPreProcessor // TypeDefIndex: 44435
	{
		// Methods
		bool PreProcessEvent(InputEventPtr currentEventPtr);
	}

	public interface IInputUpdateCallbackReceiver // TypeDefIndex: 44436
	{
		// Methods
		void OnUpdate();
	}

	public interface ITextInputReceiver // TypeDefIndex: 44437
	{
		// Methods
		void OnTextInput(char character);
		void OnIMECompositionChanged(IMECompositionString compositionString);
	}

	internal struct JoystickState : IInputStateTypeInfo // TypeDefIndex: 44439
	{
		// Fields
		[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new string[3] {"PrimaryTrigger", "PrimaryAction", "Submit" }, bit = 4)]
		public int buttons; // 0x00
		[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
		public Vector2 stick; // 0x04
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77CF0-0x0000000183D77D00 
		public FourCC format { get => default; } // 0x0000000183D77CF0-0x0000000183D77D00 
	
		// Nested types
		public enum Button // TypeDefIndex: 44438
		{
			HatSwitchUp = 0,
			HatSwitchDown = 1,
			HatSwitchLeft = 2,
			HatSwitchRight = 3,
			Trigger = 4
		}
	}

	public struct KeyboardState : IInputStateTypeInfo // TypeDefIndex: 44441
	{
		// Fields
		private const int kSizeInBits = 123; // Metadata: 0x01FB6A3D
		internal const int kSizeInBytes = 16; // Metadata: 0x01FB6A3F
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
		public static FourCC Format { get => default; } // 0x0000000183D77D00-0x0000000183D77D10 
		public FourCC format { get => default; } // 0x0000000183D77D00-0x0000000183D77D10 
	
		// Constructors
		public unsafe KeyboardState(params UnityEngine.InputSystem.Key[] pressedKeys) : this() {
			keys = default;
		} // 0x0000000189C17F1C-0x0000000189C17F2C
		public unsafe KeyboardState(bool IMESelected, params UnityEngine.InputSystem.Key[] pressedKeys) : this() {
			keys = default;
		} // 0x0000000189C17F2C-0x0000000189C18000
	
		// Methods
		public void Set(UnityEngine.InputSystem.Key key, bool state) {} // 0x0000000189C17F14-0x0000000189C17F1C
		internal bool Get(UnityEngine.InputSystem.Key key) => default; // 0x000000018426F5E0-0x000000018426F604
		public void Press(UnityEngine.InputSystem.Key key) {} // 0x0000000189C17EF0-0x0000000189C17F08
		public void Release(UnityEngine.InputSystem.Key key) {} // 0x0000000189C17F08-0x0000000189C17F14
	}

	public struct MouseState : IInputStateTypeInfo // TypeDefIndex: 44442
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
		public static FourCC Format { get => default; } // 0x0000000183D77D20-0x0000000183D77D30 
		public FourCC format { get => default; } // 0x0000000183D77D20-0x0000000183D77D30 
	
		// Methods
		public MouseState WithButton(MouseButton button, bool state = true /* Metadata: 0x01FB6A40 */) => default; // 0x0000000189C18000-0x0000000189C1803C
	}

	public enum MouseButton // TypeDefIndex: 44443
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		Forward = 3,
		Back = 4
	}

	public struct PenState : IInputStateTypeInfo // TypeDefIndex: 44444
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
		public static FourCC Format { get => default; } // 0x0000000183D77D30-0x0000000183D77D40 
		public FourCC format { get => default; } // 0x0000000183D77D30-0x0000000183D77D40 
	
		// Methods
		public PenState WithButton(PenButton button, bool state = true /* Metadata: 0x01FB6A46 */) => default; // 0x0000000189C18140-0x0000000189C18184
	}

	internal struct PointerState : IInputStateTypeInfo // TypeDefIndex: 44445
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
		public static FourCC kFormat { get => default; } // 0x0000000183D77D40-0x0000000183D77D50 
		public FourCC format { get => default; } // 0x0000000183D77D40-0x0000000183D77D50 
	}

	internal struct AccelerometerState : IInputStateTypeInfo // TypeDefIndex: 44446
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77720-0x0000000183D77730 
		public FourCC format { get => default; } // 0x0000000183D77720-0x0000000183D77730 
	}

	internal struct GyroscopeState : IInputStateTypeInfo // TypeDefIndex: 44447
	{
		// Fields
		[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = true)]
		public Vector3 angularVelocity; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77B90-0x0000000183D77BA0 
		public FourCC format { get => default; } // 0x0000000183D77B90-0x0000000183D77BA0 
	}

	internal struct GravityState : IInputStateTypeInfo // TypeDefIndex: 44448
	{
		// Fields
		[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = true)]
		public Vector3 gravity; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77B80-0x0000000183D77B90 
		public FourCC format { get => default; } // 0x0000000183D77B80-0x0000000183D77B90 
	}

	internal struct AttitudeState : IInputStateTypeInfo // TypeDefIndex: 44449
	{
		// Fields
		[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = true)]
		public Quaternion attitude; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77790-0x0000000183D777A0 
		public FourCC format { get => default; } // 0x0000000183D77790-0x0000000183D777A0 
	}

	internal struct LinearAccelerationState : IInputStateTypeInfo // TypeDefIndex: 44450
	{
		// Fields
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration; // 0x00
	
		// Properties
		public static FourCC kFormat { get => default; } // 0x0000000183D77D10-0x0000000183D77D20 
		public FourCC format { get => default; } // 0x0000000183D77D10-0x0000000183D77D20 
	}

	[Flags]
	internal enum TouchFlags : byte // TypeDefIndex: 44451
	{
		IndirectTouch = 1,
		PrimaryTouch = 8,
		TapPress = 16,
		TapRelease = 32,
		OrphanedPrimaryTouch = 64,
		BeganInSameFrame = 128
	}

	public struct TouchState : IInputStateTypeInfo // TypeDefIndex: 44452
	{
		// Fields
		internal const int kSizeInBytes = 56; // Metadata: 0x01FB6A4D
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
		public static FourCC Format { get => default; } // 0x0000000183D78060-0x0000000183D78070 
		public UnityEngine.InputSystem.TouchPhase phase { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public bool isNoneEndedOrCanceled { get => default; } // 0x0000000189C1A5E0-0x0000000189C1A5F8 
		public bool isInProgress { get => default; } // 0x0000000189C1A5C0-0x0000000189C1A5D8 
		public bool isPrimaryTouch { get => default; set {} } // 0x0000000189C1A600-0x0000000189C1A608 0x0000000189C1A684-0x0000000189C1A6A8
		internal bool isOrphanedPrimaryTouch { get => default; set {} } // 0x0000000189C1A5F8-0x0000000189C1A600 0x0000000189C1A660-0x0000000189C1A684
		public bool isIndirectTouch { get => default; set {} } // 0x0000000189C1A5D8-0x0000000189C1A5E0 0x0000000189C1A63C-0x0000000189C1A660
		public bool isTap { get => default; set {} } // 0x0000000189C1A608-0x0000000189C1A610 0x0000000189C1A6A8-0x0000000189C1A6CC
		internal bool isTapPress { get => default; set {} } // 0x0000000189C1A608-0x0000000189C1A610 0x0000000189C1A6A8-0x0000000189C1A6CC
		internal bool isTapRelease { get => default; set {} } // 0x0000000189C1A610-0x0000000189C1A618 0x0000000189C1A6CC-0x0000000189C1A6F0
		internal bool beganInSameFrame { get => default; set {} } // 0x0000000189C1A5B8-0x0000000189C1A5C0 0x0000000189C1A618-0x0000000189C1A63C
		public FourCC format { get => default; } // 0x0000000183D78060-0x0000000183D78070 
	
		// Methods
		public override string ToString() => default; // 0x0000000189C1A378-0x0000000189C1A5B8
	}

	internal struct TouchscreenState : IInputStateTypeInfo // TypeDefIndex: 44455
	{
		// Fields
		public const int MaxTouches = 10; // Metadata: 0x01FB6A4E
		[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
		[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[0])]
		[InputControl(name = "displayIndex", useStateFrom = "primaryTouch/displayIndex", format = "BYTE")]
		[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
		[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
		[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
		[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
		[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte primaryTouchData[0]; // 0x00
		internal const int kTouchDataOffset = 56; // Metadata: 0x01FB6A4F
		[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
		public unsafe fixed /* 0x00000000-0x00000000 */ byte touchData[0]; // 0x38
	
		// Properties
		public static FourCC Format { get => default; } // 0x0000000183D780A0-0x0000000183D780B0 
		public unsafe TouchState* primaryTouch { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		public unsafe TouchState* touches { get => default; } // 0x0000000183D780B0-0x0000000183D780C0 
		public FourCC format { get => default; } // 0x0000000183D780A0-0x0000000183D780B0 
	}

	internal struct ActionEvent : IInputEventTypeInfo // TypeDefIndex: 44457
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
		public static FourCC Type { get => default; } // 0x0000000183D77740-0x0000000183D77750 
		public double startTime { get => default; set {} } // 0x0000000183D77750-0x0000000183D77760 0x0000000183D77780-0x0000000183D77790
		public InputActionPhase phase { get => default; set {} } // 0x0000000183D52270-0x0000000183D52280 0x0000000183D522A0-0x0000000183D522B0
		public unsafe byte* valueData { get => default; } // 0x0000000183D77760-0x0000000183D77770 
		public int valueSizeInBytes { get => default; } // 0x0000000183D77770-0x0000000183D77780 
		public int stateIndex { get => default; set {} } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000189C0D7B0-0x0000000189C0D81C
		public int controlIndex { get => default; set {} } // 0x0000000183D61CE0-0x0000000183D61CF0 0x0000000189C0D6C8-0x0000000189C0D734
		public int bindingIndex { get => default; set {} } // 0x0000000183D64B10-0x0000000183D64B20 0x0000000189C0D65C-0x0000000189C0D6C8
		public int interactionIndex { get => default; set {} } // 0x0000000189C0D644-0x0000000189C0D65C 0x0000000189C0D734-0x0000000189C0D7B0
		public FourCC typeStatic { get => default; } // 0x0000000183D77740-0x0000000183D77750 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x000000018339AE90-0x000000018339AEA0
		public static int GetEventSizeWithValueSize(int valueSizeInBytes) => default; // 0x0000000183D77730-0x0000000183D77740
		public static unsafe ActionEvent* From(InputEventPtr ptr) => default; // 0x0000000189C0D508-0x0000000189C0D644
	}

	public struct DeltaStateEvent : IInputEventTypeInfo // TypeDefIndex: 44459
	{
		// Fields
		public const int Type = 1145852993; // Metadata: 0x01FB6A51
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		public uint stateOffset; // 0x18
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x1C
	
		// Properties
		public uint deltaStateSizeInBytes { get => default; } // 0x0000000183D777A0-0x0000000183D777B0 
		public unsafe void* deltaState { get => default; } // 0x0000000183D777B0-0x0000000183D777C0 
		public FourCC typeStatic { get => default; } // 0x0000000183D777C0-0x0000000183D777D0 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x000000018339AE90-0x000000018339AEA0
		public static unsafe DeltaStateEvent* From(InputEventPtr ptr) => default; // 0x0000000189C0DAE0-0x0000000189C0DC1C
		internal static unsafe DeltaStateEvent* FromUnchecked(InputEventPtr ptr) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FB6A50 */) {
			eventPtr = default;
			return default;
		} // 0x0000000189C0D81C-0x0000000189C0DAE0
	}

	public struct DeviceConfigurationEvent : IInputEventTypeInfo // TypeDefIndex: 44460
	{
		// Fields
		public const int Type = 1145259591; // Metadata: 0x01FB6A56
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000183D777D0-0x0000000183D777E0 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x000000018339AE90-0x000000018339AEA0
		public static DeviceConfigurationEvent Create(int deviceId, double time) => default; // 0x0000000189C0DC1C-0x0000000189C0DC74
	}

	public struct DeviceRemoveEvent : IInputEventTypeInfo // TypeDefIndex: 44461
	{
		// Fields
		public const int Type = 1146242381; // Metadata: 0x01FB6A63
		public InputEvent baseEvent; // 0x00
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000183D777E0-0x0000000183D777F0 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x000000018339AE90-0x000000018339AEA0
		public static DeviceRemoveEvent Create(int deviceId, double time = -1 /* Metadata: 0x01FB6A5B */) => default; // 0x0000000189C0DC74-0x0000000189C0DCCC
	}

	public struct DeviceResetEvent : IInputEventTypeInfo // TypeDefIndex: 44462
	{
		// Fields
		public const int Type = 1146245972; // Metadata: 0x01FB6A71
		public InputEvent baseEvent; // 0x00
		public bool hardReset; // 0x08
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000183D777F0-0x0000000183D77800 
	
		// Methods
		public static DeviceResetEvent Create(int deviceId, bool hardReset = false /* Metadata: 0x01FB6A68 */, double time = -1 /* Metadata: 0x01FB6A69 */) => default; // 0x0000000189C0DCCC-0x0000000189C0DD34
	}

	public interface IInputEventTypeInfo // TypeDefIndex: 44463
	{
		// Properties
		FourCC typeStatic { get; }
	}

	public struct IMECompositionEvent : IInputEventTypeInfo // TypeDefIndex: 44464
	{
		// Fields
		internal const int kIMECharBufferSize = 64; // Metadata: 0x01FB6A76
		public const int Type = 1229800787; // Metadata: 0x01FB6A78
		public InputEvent baseEvent; // 0x00
		public IMECompositionString compositionString; // 0x14
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000183D77C50-0x0000000183D77C60 
	
		// Methods
		public static IMECompositionEvent Create(int deviceId, string compositionString, double time) => default; // 0x0000000189C14298-0x0000000189C14398
	}

	public struct IMECompositionString : IEnumerable<char> // TypeDefIndex: 44467
	{
		// Fields
		private int size; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ char buffer[0]; // 0x04
	
		// Properties
		public int Count { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public char this[int index] { get => default; } // 0x0000000189C14558-0x0000000189C145C8 
	
		// Nested types
		internal struct Enumerator : IEnumerator<char> // TypeDefIndex: 44465
		{
			// Fields
			private IMECompositionString m_CompositionString; // 0x00
			private char m_CurrentCharacter; // 0x84
			private int m_CurrentIndex; // 0x88
	
			// Properties
			public char Current { get => default; } // 0x0000000183D67F10-0x0000000183D67F20 
			object IEnumerator.Current { get => default; } // 0x0000000189C10418-0x0000000189C10460 
	
			// Constructors
			public Enumerator(IMECompositionString compositionString) : this() {
				m_CompositionString = default;
				m_CurrentCharacter = default;
				m_CurrentIndex = default;
			} // 0x0000000183D77B10-0x0000000183D77B70
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189C10348-0x0000000189C10370
			public void Reset() {} // 0x0000000183D76380-0x0000000183D76390
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public unsafe IMECompositionString(string characters) : this() {
			size = default;
			buffer = default;
		} // 0x0000000189C144EC-0x0000000189C14558
	
		// Methods
		public override string ToString() => default; // 0x0000000189C144C8-0x0000000189C144EC
		public IEnumerator<char> GetEnumerator() => default; // 0x0000000189C14398-0x0000000189C144C0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189C144C0-0x0000000189C144C8
	}

	public struct InputEvent // TypeDefIndex: 44468
	{
		// Fields
		private const uint kHandledMask = 2147483648; // Metadata: 0x01FB6A85
		private const uint kIdMask = 2147483647; // Metadata: 0x01FB6A8A
		internal const int kBaseEventSize = 20; // Metadata: 0x01FB6A8F
		public const int InvalidEventId = 0; // Metadata: 0x01FB6A90
		internal const int kAlignment = 4; // Metadata: 0x01FB6A91
		private NativeInputEvent m_Event; // 0x00
	
		// Properties
		public FourCC type { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public uint sizeInBytes { get => default; set {} } // 0x0000000183D4FEE0-0x0000000183D4FEF0 0x0000000183CA7CF0-0x0000000183CA7D10
		public int eventId { get => default; set {} } // 0x0000000183D77CD0-0x0000000183D77CE0 0x0000000183D77CE0-0x0000000183D77CF0
		public int deviceId { get => default; set {} } // 0x0000000183D4FED0-0x0000000183D4FEE0 0x0000000183D73E20-0x0000000183D73E30
		public double time { get => default; set {} } // 0x0000000189C17EAC-0x0000000189C17EF0 0x0000000183B33A20-0x0000000183B33A80
		internal double internalTime { get => default; set {} } // 0x0000000183D676E0-0x0000000183D676F0 0x0000000183D698E0-0x0000000183D698F0
		public bool handled { get => default; set {} } // 0x00000001822BD230-0x00000001822BD240 0x0000000183341B70-0x0000000183341B90
	
		// Constructors
		public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1 /* Metadata: 0x01FB6A7D */) : this() {
			m_Event = default;
		} // 0x0000000182CAF850-0x0000000182CAF8F0
	
		// Methods
		public override string ToString() => default; // 0x0000000189C17CF4-0x0000000189C17EAC
		internal static unsafe InputEvent* GetNextInMemory(InputEvent* currentPtr) => default; // 0x00000001824B10C0-0x00000001824B1110
		internal static unsafe InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) => default; // 0x0000000189C17BF4-0x0000000189C17CF4
		public static unsafe bool Equals(InputEvent* first, InputEvent* second) => default; // 0x0000000189C17BB8-0x0000000189C17BF4
	}

	public struct InputEventBuffer : IEnumerable<InputEventPtr>, IDisposable, ICloneable // TypeDefIndex: 44470
	{
		// Fields
		public const long BufferSizeUnknown = -1; // Metadata: 0x01FB6A9C
		private NativeArray<byte> m_Buffer; // 0x00
		private long m_SizeInBytes; // 0x10
		private int m_EventCount; // 0x18
		private bool m_WeOwnTheBuffer; // 0x1C
	
		// Properties
		public int eventCount { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public long sizeInBytes { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public long capacityInBytes { get => default; } // 0x0000000183D275D0-0x0000000183D27610 
		public NativeArray<byte> data { get => default; } // 0x0000000183D5B250-0x0000000183D5B260 
		public InputEventPtr bufferPtr { get => default; } // 0x0000000189C14CE0-0x0000000189C14D10 
	
		// Nested types
		private struct Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 44469
		{
			// Fields
			private readonly unsafe InputEvent* m_Buffer; // 0x00
			private readonly int m_EventCount; // 0x08
			private unsafe InputEvent* m_CurrentEvent; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public InputEventPtr Current { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			object IEnumerator.Current { get => default; } // 0x0000000189C10370-0x0000000189C103B8 
	
			// Constructors
			public unsafe Enumerator(InputEventBuffer buffer) : this() {
				m_Buffer = default;
				m_EventCount = default;
				m_CurrentEvent = default;
				m_CurrentIndex = default;
			} // 0x0000000189C1048C-0x0000000189C104C4
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189C102F8-0x0000000189C10348
			public void Reset() {} // 0x0000000183D5A0E0-0x0000000183D5A0F0
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1 /* Metadata: 0x01FB6A92 */, int capacityInBytes = -1 /* Metadata: 0x01FB6A93 */) : this() {
			m_Buffer = default;
			m_SizeInBytes = default;
			m_EventCount = default;
			m_WeOwnTheBuffer = default;
		} // 0x00000001824B1300-0x00000001824B1460
		public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1 /* Metadata: 0x01FB6A94 */, bool transferNativeArrayOwnership = false /* Metadata: 0x01FB6A95 */) : this() {
			m_Buffer = default;
			m_SizeInBytes = default;
			m_EventCount = default;
			m_WeOwnTheBuffer = default;
		} // 0x0000000189C14BA8-0x0000000189C14CE0
	
		// Methods
		public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048 /* Metadata: 0x01FB6A96 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6A98 */) {} // 0x0000000189C148B4-0x0000000189C14948
		public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048 /* Metadata: 0x01FB6A99 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6A9B */) => default; // 0x0000000189C14648-0x0000000189C148B4
		public unsafe bool Contains(InputEvent* eventPtr) => default; // 0x0000000189C14A0C-0x0000000189C14A70
		public void Reset() {} // 0x00000001829890F0-0x0000000182989110
		internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) {} // 0x00000001824B0D00-0x00000001824B0D70
		public IEnumerator<InputEventPtr> GetEnumerator() => default; // 0x0000000189C14AC0-0x0000000189C14B40
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189C14B40-0x0000000189C14B48
		public void Dispose() {} // 0x0000000189C14A70-0x0000000189C14AC0
		public InputEventBuffer Clone() => default; // 0x0000000189C14948-0x0000000189C14A0C
		object ICloneable.Clone() => default; // 0x0000000189C14B48-0x0000000189C14BA8
	}

	public struct InputEventListener : IObservable<InputEventPtr> // TypeDefIndex: 44473
	{
		// Fields
		internal static ObserverState s_ObserverState; // 0x00
	
		// Nested types
		internal class ObserverState // TypeDefIndex: 44471
		{
			// Fields
			public InlinedArray<IObserver<InputEventPtr>> observers; // 0x10
			public Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28
	
			// Constructors
			public ObserverState() {} // 0x0000000189C180C4-0x0000000189C18140
		}
	
		private class DisposableObserver : IDisposable // TypeDefIndex: 44472
		{
			// Fields
			public IObserver<InputEventPtr> observer; // 0x10
	
			// Constructors
			public DisposableObserver() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Dispose() {} // 0x0000000189C0DD34-0x0000000189C0DE5C
		}
	
		// Methods
		public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback) => default; // 0x0000000189C14E8C-0x0000000189C14FF8
		public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, UnityEngine.InputSystem.InputDevice> callback) => default; // 0x0000000189C14FF8-0x0000000189C15164
		public IDisposable Subscribe(IObserver<InputEventPtr> observer) => default; // 0x0000000189C14D10-0x0000000189C14E8C
	}

	public struct InputEventPtr : IEquatable<InputEventPtr> // TypeDefIndex: 44474
	{
		// Fields
		private readonly unsafe InputEvent* m_EventPtr; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x00000001822B9B50-0x00000001822B9B60 
		public bool handled { get => default; set {} } // 0x0000000189C1526C-0x0000000189C1528C 0x0000000189C15508-0x0000000189C15578
		public int id { get => default; set {} } // 0x0000000189C1528C-0x0000000189C152A0 0x0000000189C15578-0x0000000189C155F0
		public FourCC type { get => default; } // 0x00000001822B9B40-0x00000001822B9B50 
		public uint sizeInBytes { get => default; } // 0x00000001822B8CA0-0x00000001822B8CC0 
		public int deviceId { get => default; set {} } // 0x0000000189C15258-0x0000000189C1526C 0x0000000189C15498-0x0000000189C15508
		public double time { get => default; set {} } // 0x0000000189C15478-0x0000000189C15498 0x0000000189C15660-0x0000000189C156D0
		internal double internalTime { get => default; set {} } // 0x00000001822B90E0-0x00000001822B9100 0x0000000189C155F0-0x0000000189C15660
		public unsafe InputEvent* data { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		internal FourCC stateFormat { get => default; } // 0x00000001822B8160-0x00000001822B81A0 
		internal uint stateSizeInBytes { get => default; } // 0x0000000189C15370-0x0000000189C15478 
		internal uint stateOffset { get => default; } // 0x0000000189C152A0-0x0000000189C15370 
	
		// Constructors
		public unsafe InputEventPtr(InputEvent* eventPtr) : this() {
			m_EventPtr = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public bool IsA<TOtherEvent>()
			where TOtherEvent : struct, IInputEventTypeInfo => default;
		public InputEventPtr Next() => default; // 0x0000000189C151E0-0x0000000189C15200
		public override string ToString() => default; // 0x0000000189C15200-0x0000000189C15258
		public unsafe InputEvent* ToPointer() => default; // 0x00000001820C61B0-0x00000001820C61C0
		public bool Equals(InputEventPtr other) => default; // 0x0000000189C151C8-0x0000000189C151E0
		public override bool Equals(object obj) => default; // 0x0000000189C15164-0x0000000189C151C8
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public static bool operator ==(InputEventPtr left, InputEventPtr right) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(InputEventPtr left, InputEventPtr right) => default; // 0x00000001822E54C0-0x00000001822E54D0
		public static unsafe implicit operator InputEventPtr(InputEvent* eventPtr) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static unsafe InputEventPtr From(InputEvent* eventPtr) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static unsafe implicit operator InputEvent*(InputEventPtr eventPtr) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static unsafe InputEvent* FromInputEventPtr(InputEventPtr eventPtr) => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	internal struct InputEventStream // TypeDefIndex: 44475
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
		public bool isOpen { get => default; } // 0x0000000183D4F260-0x0000000183D4F270 
		public int remainingEventCount { get => default; } // 0x0000000183D77CA0-0x0000000183D77CB0 
		public int numEventsRetainedInBuffer { get => default; } // 0x0000000183D4F400-0x0000000183D4F410 
		public unsafe InputEvent* currentEventPtr { get => default; } // 0x00000001824B0CE0-0x00000001824B0D00 
		public uint numBytesRetainedInBuffer { get => default; } // 0x0000000189C1587C-0x0000000189C158B0 
	
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
		} // 0x00000001830ECEE0-0x00000001830ECF70
	
		// Methods
		public void Close(ref InputEventBuffer eventBuffer) {} // 0x0000000182989060-0x00000001829890F0
		public void CleanUpAfterException() {} // 0x0000000189C156D0-0x0000000189C15724
		public unsafe void Write(InputEvent* eventPtr) {} // 0x0000000189C15724-0x0000000189C1587C
		public unsafe InputEvent* Advance(bool leaveEventInBuffer) => default; // 0x00000001824B0C70-0x00000001824B0CE0
		public unsafe InputEvent* Peek() => default; // 0x00000001824B1070-0x00000001824B10C0
	}

	[Serializable]
	public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr> // TypeDefIndex: 44482
	{
		// Fields
		private const int kDefaultBufferSize = 1048576; // Metadata: 0x01FB6ADE
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
		public static FourCC FrameMarkerEvent { get => default; } // 0x0000000183D77CB0-0x0000000183D77CC0 
		public int deviceId { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool enabled { get => default; } // 0x0000000183D58C00-0x0000000183D58C10 
		public bool recordFrameMarkers { get => default; set {} } // 0x0000000183D51FC0-0x0000000183D51FD0 0x0000000189C17AD0-0x0000000189C17BB8
		public long eventCount { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public long totalEventSizeInBytes { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		public long allocatedSizeInBytes { get => default; } // 0x0000000189C17A14-0x0000000189C17A28 
		public long maxSizeInBytes { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public ReadOnlyArray<DeviceInfo> deviceInfos { get => default; } // 0x0000000189C17A28-0x0000000189C17A84 
		public Func<InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> onFilterEvent { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		private unsafe byte* m_EventBuffer { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000183D71630-0x0000000183D71640
		private unsafe byte* m_EventBufferHead { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000183D4EB70-0x0000000183D4EB80
		private unsafe byte* m_EventBufferTail { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000183D50F80-0x0000000183D50F90
		private static FourCC kFileFormat { get => default; } // 0x0000000183D77CC0-0x0000000183D77CD0 
	
		// Events
		public event Action<InputEventPtr> onEvent;
	
		// Nested types
		private class Enumerator : IEnumerator<InputEventPtr> // TypeDefIndex: 44476
		{
			// Fields
			private InputEventTrace m_Trace; // 0x10
			private int m_ChangeCounter; // 0x18
			internal InputEventPtr m_Current; // 0x20
	
			// Properties
			public InputEventPtr Current { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
			object IEnumerator.Current { get => default; } // 0x0000000189C1F718-0x0000000189C1F760 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			public Enumerator(InputEventTrace trace) {} // 0x0000000189C1F7B8-0x0000000189C1F7E8
	
			// Methods
			public void Dispose() {} // 0x0000000189C1F5F0-0x0000000189C1F614
			public bool MoveNext() => default; // 0x0000000189C1F614-0x0000000189C1F6F4
			public void Reset() {} // 0x0000000189C1F6F4-0x0000000189C1F718
		}
	
		[Flags]
		private enum FileFlags // TypeDefIndex: 44477
		{
			FixedUpdate = 1
		}
	
		public class ReplayController : IDisposable // TypeDefIndex: 44480
		{
			// Fields
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
			public InputEventTrace trace { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public bool finished { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
			public bool paused { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
			public int position { get; private set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
			public IEnumerable<UnityEngine.InputSystem.InputDevice> createdDevices { get => default; } // 0x0000000189C2B554-0x0000000189C2B5A4 
	
			// Constructors
			public ReplayController() {} // Dummy constructor
			internal ReplayController(InputEventTrace trace) {} // 0x0000000189C2B4E0-0x0000000189C2B554
	
			// Methods
			public void Dispose() {} // 0x0000000189C2A67C-0x0000000189C2A820
			public ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice) => default; // 0x0000000189C2B304-0x0000000189C2B3D8
			public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) => default; // 0x0000000189C2B3D8-0x0000000189C2B4E0
			public ReplayController WithAllDevicesMappedToNewInstances() => default; // 0x0000000183D78170-0x0000000183D78180
			public ReplayController OnFinished(Action action) => default; // 0x000000018574BB94-0x000000018574BBB0
			public ReplayController OnEvent(Action<InputEventPtr> action) => default; // 0x000000018574BBB0-0x000000018574BBCC
			public ReplayController PlayOneEvent() => default; // 0x0000000189C2B04C-0x0000000189C2B0DC
			public ReplayController Rewind() => default; // 0x0000000189C2B2C0-0x0000000189C2B304
			public ReplayController PlayAllFramesOneByOne() => default; // 0x0000000189C2AFB4-0x0000000189C2B04C
			public ReplayController PlayAllEvents() => default; // 0x0000000189C2AF10-0x0000000189C2AFB4
			public ReplayController PlayAllEventsAccordingToTimestamps() => default; // 0x0000000189C2ACC8-0x0000000189C2AF10
			private void OnBeginFrame() {} // 0x0000000189C2AB48-0x0000000189C2ACC8
			private void Finished() {} // 0x0000000189C2A820-0x0000000189C2A8C4
			private void QueueEvent(InputEventPtr eventPtr) {} // 0x0000000189C2B0DC-0x0000000189C2B2C0
			private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr) {
				eventPtr = default;
				return default;
			} // 0x0000000189C2A8C4-0x0000000189C2AB48
			private int ApplyDeviceMapping(int originalDeviceId) => default; // 0x0000000189C2A320-0x0000000189C2A67C
		}
	
		[Serializable]
		public struct DeviceInfo // TypeDefIndex: 44481
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
			public int deviceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
			public string layout { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
			public FourCC stateFormat { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
			public int stateSizeInBytes { get => default; set {} } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		}
	
		// Constructors
		public InputEventTrace() {} // Dummy constructor
		public InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes = 1048576 /* Metadata: 0x01FB6AA4 */, bool growBuffer = false /* Metadata: 0x01FB6AAC */, long maxBufferSizeInBytes = -1 /* Metadata: 0x01FB6AAD */, long growIncrementSizeInBytes = -1 /* Metadata: 0x01FB6AB5 */) {} // 0x0000000189C17924-0x0000000189C179C8
		public InputEventTrace(long bufferSizeInBytes = 1048576 /* Metadata: 0x01FB6ABD */, bool growBuffer = false /* Metadata: 0x01FB6AC5 */, long maxBufferSizeInBytes = -1 /* Metadata: 0x01FB6AC6 */, long growIncrementSizeInBytes = -1 /* Metadata: 0x01FB6ACE */) {} // 0x0000000189C178E0-0x0000000189C17924
		static InputEventTrace() {} // 0x0000000189C1786C-0x0000000189C178E0
	
		// Methods
		public void WriteTo(string filePath) {} // 0x0000000189C17758-0x0000000189C1786C
		public void WriteTo(Stream stream) {} // 0x0000000189C1718C-0x0000000189C17758
		public void ReadFrom(string filePath) {} // 0x0000000189C1645C-0x0000000189C16570
		public void ReadFrom(Stream stream) {} // 0x0000000189C16570-0x0000000189C16E74
		public static InputEventTrace LoadFrom(string filePath) => default; // 0x0000000189C15D6C-0x0000000189C15EA0
		public static InputEventTrace LoadFrom(Stream stream) => default; // 0x0000000189C15C20-0x0000000189C15D6C
		public ReplayController Replay() => default; // 0x0000000189C16EB4-0x0000000189C16F20
		public bool Resize(long newBufferSize, long newMaxBufferSize = -1 /* Metadata: 0x01FB6AD6 */) => default; // 0x0000000189C16F20-0x0000000189C17184
		public void Clear() {} // 0x0000000189C158DC-0x0000000189C15910
		public void Enable() {} // 0x0000000189C15A1C-0x0000000189C15B34
		public void Disable() {} // 0x0000000189C15910-0x0000000189C159FC
		public bool GetNextEvent(ref InputEventPtr current) => default; // 0x0000000189C15B94-0x0000000189C15C20
		public IEnumerator<InputEventPtr> GetEnumerator() => default; // 0x0000000189C15B34-0x0000000189C15B94
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189C17184-0x0000000189C1718C
		public void Dispose() {} // 0x0000000189C159FC-0x0000000189C15A1C
		private void Allocate() {} // 0x0000000189C158B0-0x0000000189C158DC
		private void Release() {} // 0x0000000189C16E74-0x0000000189C16EB4
		private void OnBeforeUpdate() {} // 0x0000000189C15EA0-0x0000000189C15F78
		private void OnInputEvent(InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189C15F78-0x0000000189C1645C
	}

	public struct StateEvent : IInputEventTypeInfo // TypeDefIndex: 44484
	{
		// Fields
		public const int Type = 1398030676; // Metadata: 0x01FB6AE5
		internal const int kStateDataSizeToSubtract = 1; // Metadata: 0x01FB6AEA
		public InputEvent baseEvent; // 0x00
		public FourCC stateFormat; // 0x14
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte stateData[0]; // 0x18
	
		// Properties
		public uint stateSizeInBytes { get => default; } // 0x0000000183D78200-0x0000000183D78210 
		public unsafe void* state { get => default; } // 0x0000000183D6CEF0-0x0000000183D6CF00 
		public FourCC typeStatic { get => default; } // 0x0000000183D78210-0x0000000183D78220 
	
		// Methods
		public InputEventPtr ToEventPtr() => default; // 0x000000018339AE90-0x000000018339AEA0
		public TState GetState<TState>()
			where TState : struct, IInputStateTypeInfo => default;
		public static TState GetState<TState>(InputEventPtr ptr)
			where TState : struct, IInputStateTypeInfo => default;
		public static int GetEventSizeWithPayload<TState>()
			where TState : struct => default;
		public static unsafe StateEvent* From(InputEventPtr ptr) => default; // 0x0000000189C2BB50-0x0000000189C2BC90
		internal static unsafe StateEvent* FromUnchecked(InputEventPtr ptr) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FB6AE3 */) {
			eventPtr = default;
			return default;
		} // 0x0000000189C2BB20-0x0000000189C2BB50
		public static NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FB6AE4 */) {
			eventPtr = default;
			return default;
		} // 0x0000000189C2B874-0x0000000189C2B8A4
		private static NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, out InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState) {
			eventPtr = default;
			return default;
		} // 0x0000000189C2B8A4-0x0000000189C2BB20
	}

	public struct TextEvent : IInputEventTypeInfo // TypeDefIndex: 44485
	{
		// Fields
		public const int Type = 1413830740; // Metadata: 0x01FB6AFB
		public InputEvent baseEvent; // 0x00
		public int character; // 0x14
	
		// Properties
		public FourCC typeStatic { get => default; } // 0x0000000183D78220-0x0000000183D78230 
	
		// Methods
		public static unsafe TextEvent* From(InputEventPtr eventPtr) => default; // 0x0000000189C2BFCC-0x0000000189C2C108
		public static TextEvent Create(int deviceId, char character, double time = -1 /* Metadata: 0x01FB6AEB */) => default; // 0x0000000189C2BEFC-0x0000000189C2BF64
		public static TextEvent Create(int deviceId, int character, double time = -1 /* Metadata: 0x01FB6AF3 */) => default; // 0x0000000189C2BF64-0x0000000189C2BFCC
	}

	internal delegate void InputUpdateDelegate(InputUpdateType updateType, ref InputEventBuffer eventBuffer); // TypeDefIndex: 44486; 0x0000000182065C10-0x0000000182065C20

	internal interface IInputRuntime // TypeDefIndex: 44487
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

	internal static class InputRuntime // TypeDefIndex: 44488
	{
		// Fields
		public static IInputRuntime s_Instance; // 0x00
		public static double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x08
	}

	internal static class InputRuntimeExtensions // TypeDefIndex: 44489
	{
		// Extension methods
		public static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref ref TCommand command)
			where TCommand : struct, IInputDeviceCommandInfo => default;
	}

	[Serializable]
	public struct InputMetrics // TypeDefIndex: 44490
	{
		// Properties
		public int maxNumDevices { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int currentNumDevices { [IsReadOnly] get; set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public int maxStateSizeInBytes { [IsReadOnly] get; set; } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public int currentStateSizeInBytes { [IsReadOnly] get; set; } // 0x0000000183D4FBF0-0x0000000183D4FC00 0x0000000183D55690-0x0000000183D556A0
		public int currentControlCount { [IsReadOnly] get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public int currentLayoutCount { [IsReadOnly] get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public int totalEventBytes { [IsReadOnly] get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int totalEventCount { [IsReadOnly] get; set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public int totalUpdateCount { [IsReadOnly] get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public double totalEventProcessingTime { [IsReadOnly] get; set; } // 0x0000000183D4F5B0-0x0000000183D4F5C0 0x0000000183D4F5C0-0x0000000183D4F5D0
		public double totalEventLagTime { [IsReadOnly] get; set; } // 0x0000000183D4F240-0x0000000183D4F250 0x0000000183D4F250-0x0000000183D4F260
		public float averageEventBytesPerFrame { get => default; } // 0x0000000189C251FC-0x0000000189C25214 
		public double averageProcessingTimePerEvent { get => default; } // 0x0000000189C25228-0x0000000189C2523C 
		public double averageLagTimePerEvent { get => default; } // 0x0000000189C25214-0x0000000189C25228 
	}

	[Flags]
	public enum InputUpdateType // TypeDefIndex: 44491
	{
		None = 0,
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		Default = 11,
		Manual = 16
	}

	internal static class InputUpdate // TypeDefIndex: 44494
	{
		// Fields
		public static uint s_UpdateStepCount; // 0x00
		public static InputUpdateType s_LatestUpdateType; // 0x04
		public static UpdateStepCount s_PlayerUpdateStepCount; // 0x08
	
		// Nested types
		[Serializable]
		public struct UpdateStepCount // TypeDefIndex: 44492
		{
			// Fields
			private bool m_WasUpdated; // 0x00
	
			// Properties
			public uint value { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
	
			// Methods
			public void OnBeforeUpdate() {} // 0x0000000183D78230-0x0000000183D78240
			public void OnUpdate() {} // 0x00000001824B1960-0x00000001824B1970
		}
	
		[Serializable]
		public struct SerializedState // TypeDefIndex: 44493
		{
			// Fields
			public InputUpdateType lastUpdateType; // 0x00
			public UpdateStepCount playerUpdateStepCount; // 0x04
		}
	
		// Methods
		internal static void OnBeforeUpdate(InputUpdateType type) {} // 0x00000001822BC250-0x00000001822BC2D0
		internal static void OnUpdate(InputUpdateType type) {} // 0x00000001824B18E0-0x00000001824B1960
		public static SerializedState Save() => default; // 0x0000000189C28394-0x0000000189C283E0
		public static void Restore(SerializedState state) {} // 0x0000000182F17930-0x0000000182F179C0
	
		// Extension methods
		public static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask) => default; // 0x000000018235D660-0x000000018235D680
		public static bool IsPlayerUpdate(this InputUpdateType updateType) => default; // 0x00000001824B14F0-0x00000001824B1500
	}

	internal class NativeInputRuntime : IInputRuntime // TypeDefIndex: 44498
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
		public InputUpdateDelegate onUpdate { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000182EB5BD0-0x0000000182EB5CE0
		public Action<InputUpdateType> onBeforeUpdate { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x000000018235C370-0x000000018235C490
		public Func<InputUpdateType, bool> onShouldRunUpdate { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000182EB5AB0-0x0000000182EB5BD0
		public Action<int, string> onDeviceDiscovered { get => default; set {} } // 0x0000000189C294C8-0x0000000189C29508 0x0000000182EB7200-0x0000000182EB7310
		public Action onShutdown { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189C29540-0x0000000189C29614
		public Action<bool> onPlayerFocusChanged { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000182EB74A0-0x0000000182EB7550
		public bool isPlayerFocused { get => default; } // 0x00000001842744F0-0x00000001842744F8 
		public float pollingFrequency { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000182EB7310-0x0000000182EB7370
		public double currentTime { get => default; } // 0x00000001822B9900-0x00000001822B9970 
		public double currentTimeForFixedUpdate { get => default; } // 0x0000000189C29488-0x0000000189C294C0 
		public double currentTimeOffsetToRealtimeSinceStartup { get => default; } // 0x00000001824B1460-0x00000001824B14B0 
		public float unscaledGameTime { get => default; } // 0x000000018426F6B4-0x000000018426F6BC 
		public bool runInBackground { get => default; set {} } // 0x00000001822BFB90-0x00000001822BFBC0 0x0000000183D4E960-0x0000000183D4E970
		public Vector2 screenSize { get => default; } // 0x0000000189C29508-0x0000000189C29540 
		public ScreenOrientation screenOrientation { get => default; } // 0x0000000184270628-0x0000000184270634 
		public bool isInBatchMode { get => default; } // 0x0000000189C294C0-0x0000000189C294C8 
	
		// Constructors
		public NativeInputRuntime() {} // 0x0000000183D78160-0x0000000183D78170
		static NativeInputRuntime() {} // 0x0000000183D05270-0x0000000183D052E0
	
		// Methods
		public int AllocateDeviceId() => default; // 0x0000000189C293D8-0x0000000189C29418
		public void Update(InputUpdateType updateType) {} // 0x0000000183A4FDF0-0x0000000183A4FE40
		public unsafe void QueueEvent(InputEvent* ptr) {} // 0x0000000189C2943C-0x0000000189C29488
		public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) => default; // 0x00000001833FA780-0x00000001833FA810
		private void OnShutdown() {} // 0x0000000185ED621C-0x0000000185ED6238
		private bool OnWantsToShutdown() => default; // 0x0000000189C29418-0x0000000189C2943C
		private void OnFocusChanged(bool focus) {} // 0x00000001829FF1B0-0x00000001829FF1D0
	}

	public interface IInputStateCallbackReceiver // TypeDefIndex: 44499
	{
		// Methods
		void OnNextUpdate();
		void OnStateEvent(InputEventPtr eventPtr);
		bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
	}

	public interface IInputStateChangeMonitor // TypeDefIndex: 44500
	{
		// Methods
		void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);
		void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
	}

	public interface IInputStateTypeInfo // TypeDefIndex: 44501
	{
		// Properties
		FourCC format { get; }
	}

	public static class InputState // TypeDefIndex: 44503
	{
		// Properties
		public static InputUpdateType currentUpdateType { get; } // 0x0000000189C28228-0x0000000189C28260 
		public static uint updateCount { get; } // 0x0000000189C28260-0x0000000189C28298 
		public static double currentTime { get; } // 0x0000000182CAFBE0-0x0000000182CAFC40 
	
		// Events
		public static event Action<UnityEngine.InputSystem.InputDevice, InputEventPtr> onChange;
	
		// Nested types
		private class StateChangeMonitorDelegate : IInputStateChangeMonitor // TypeDefIndex: 44502
		{
			// Fields
			public Action<InputControl, double, InputEventPtr, long> valueChangeCallback; // 0x10
			public Action<InputControl, double, long, int> timerExpiredCallback; // 0x18
	
			// Constructors
			public StateChangeMonitorDelegate() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x0000000189C2B820-0x0000000189C2B848
			public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x0000000189C2B848-0x0000000189C2B874
		}
	
		// Methods
		public static void Change(UnityEngine.InputSystem.InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x01FB6B07 */) {} // 0x0000000189C27C10-0x0000000189C27EA8
		public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x01FB6B08 */, InputEventPtr eventPtr = default)
			where TState : struct {}
		public static void Change<TState>(InputControl control, ref ref TState state, InputUpdateType updateType = InputUpdateType.None /* Metadata: 0x01FB6B09 */, InputEventPtr eventPtr = default)
			where TState : struct {}
		public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x01FB6B0A */, uint groupIndex = 0 /* Metadata: 0x01FB6B12 */) {} // 0x0000000182EB8590-0x0000000182EB8660
		public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1 /* Metadata: 0x01FB6B13 */, Action<InputControl, double, long, int> timerExpiredCallback = null) => default; // 0x0000000189C27B10-0x0000000189C27C10
		public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x01FB6B14 */) {} // 0x0000000189C28098-0x0000000189C281C8
		public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1 /* Metadata: 0x01FB6B1C */, int timerIndex = -1 /* Metadata: 0x01FB6B24 */) {} // 0x0000000189C27A1C-0x0000000189C27B10
		public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1 /* Metadata: 0x01FB6B25 */, int timerIndex = -1 /* Metadata: 0x01FB6B2D */) {} // 0x0000000189C27FC4-0x0000000189C28098
	
		// Extension methods
		public static bool IsIntegerFormat(this FourCC format) => default; // 0x0000000189C27EA8-0x0000000189C27FC4
	}

	public struct InputStateBlock // TypeDefIndex: 44504
	{
		// Fields
		public const uint InvalidOffset = 4294967295; // Metadata: 0x01FB6B2E
		public const uint AutomaticOffset = 4294967294; // Metadata: 0x01FB6B2F
		public static readonly FourCC FormatInvalid; // 0x00
		internal const int kFormatInvalid = 0; // Metadata: 0x01FB6B30
		public static readonly FourCC FormatBit; // 0x04
		internal const int kFormatBit = 1112101920; // Metadata: 0x01FB6B31
		public static readonly FourCC FormatSBit; // 0x08
		internal const int kFormatSBit = 1396853076; // Metadata: 0x01FB6B36
		public static readonly FourCC FormatInt; // 0x0C
		internal const int kFormatInt = 1229870112; // Metadata: 0x01FB6B3B
		public static readonly FourCC FormatUInt; // 0x10
		internal const int kFormatUInt = 1430867540; // Metadata: 0x01FB6B40
		public static readonly FourCC FormatShort; // 0x14
		internal const int kFormatShort = 1397248596; // Metadata: 0x01FB6B45
		public static readonly FourCC FormatUShort; // 0x18
		internal const int kFormatUShort = 1431521364; // Metadata: 0x01FB6B4A
		public static readonly FourCC FormatByte; // 0x1C
		internal const int kFormatByte = 1113150533; // Metadata: 0x01FB6B4F
		public static readonly FourCC FormatSByte; // 0x20
		internal const int kFormatSByte = 1396857172; // Metadata: 0x01FB6B54
		public static readonly FourCC FormatLong; // 0x24
		internal const int kFormatLong = 1280198432; // Metadata: 0x01FB6B59
		public static readonly FourCC FormatULong; // 0x28
		internal const int kFormatULong = 1431064135; // Metadata: 0x01FB6B5E
		public static readonly FourCC FormatFloat; // 0x2C
		internal const int kFormatFloat = 1179407392; // Metadata: 0x01FB6B63
		public static readonly FourCC FormatDouble; // 0x30
		internal const int kFormatDouble = 1145195552; // Metadata: 0x01FB6B68
		public static readonly FourCC FormatVector2; // 0x34
		internal const int kFormatVector2 = 1447379762; // Metadata: 0x01FB6B6D
		public static readonly FourCC FormatVector3; // 0x38
		internal const int kFormatVector3 = 1447379763; // Metadata: 0x01FB6B72
		public static readonly FourCC FormatQuaternion; // 0x3C
		internal const int kFormatQuaternion = 1364541780; // Metadata: 0x01FB6B77
		public static readonly FourCC FormatVector2Short; // 0x40
		public static readonly FourCC FormatVector3Short; // 0x44
		public static readonly FourCC FormatVector2Byte; // 0x48
		public static readonly FourCC FormatVector3Byte; // 0x4C
		public static readonly FourCC FormatPose; // 0x50
		internal const int kFormatPose = 1349481317; // Metadata: 0x01FB6B7C
		internal uint m_ByteOffset; // 0x04
	
		// Properties
		public FourCC format { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public uint byteOffset { get => default; set {} } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public uint bitOffset { [IsReadOnly] get; set; } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public uint sizeInBits { [IsReadOnly] get; set; } // 0x0000000183D4FBF0-0x0000000183D4FC00 0x0000000183D55690-0x0000000183D556A0
		internal uint alignedSizeInBytes { get => default; } // 0x00000001822B99B0-0x00000001822B9A00 
		internal uint effectiveByteOffset { get => default; } // 0x0000000189C26764-0x0000000189C267B0 
		internal uint effectiveBitOffset { get => default; } // 0x0000000189C26718-0x0000000189C26764 
	
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
		} // 0x0000000183B0F5B0-0x0000000183B0F790
	
		// Methods
		public static int GetSizeOfPrimitiveFormatInBits(FourCC type) => default; // 0x0000000189C25A18-0x0000000189C25C8C
		public static FourCC GetPrimitiveFormatFromType(System.Type type) => default; // 0x0000000189C255A0-0x0000000189C25A18
		public unsafe int ReadInt(void* statePtr) => default; // 0x00000001830CC110-0x00000001830CC1F0
		public unsafe void WriteInt(void* statePtr, int value) {} // 0x0000000189C26514-0x0000000189C26718
		public unsafe float ReadFloat(void* statePtr) => default; // 0x0000000182E555C0-0x0000000182E556F0
		public unsafe void WriteFloat(void* statePtr, float value) {} // 0x0000000189C26240-0x0000000189C26514
		internal PrimitiveValue FloatToPrimitiveValue(float value) => default; // 0x0000000189C2523C-0x0000000189C255A0
		public unsafe double ReadDouble(void* statePtr) => default; // 0x0000000189C25C8C-0x0000000189C25F40
		public unsafe void WriteDouble(void* statePtr, double value) {} // 0x0000000189C25F40-0x0000000189C26240
		public unsafe void Write(void* statePtr, PrimitiveValue value) {} // 0x00000001822F81C0-0x00000001822F8260
		public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr) {} // 0x00000001839B4DB0-0x00000001839B4EA0
	}

	internal struct InputStateBuffers // TypeDefIndex: 44506
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
		internal struct DoubleBuffers // TypeDefIndex: 44505
		{
			// Fields
			public unsafe void** deviceToBufferMapping; // 0x00
			public int deviceCount; // 0x08
	
			// Properties
			public bool valid { get => default; } // 0x00000001822B8D00-0x00000001822B8D10 
	
			// Methods
			public unsafe void SetFrontBuffer(int deviceIndex, void* ptr) {} // 0x00000001822B8CC0-0x00000001822B8CE0
			public unsafe void SetBackBuffer(int deviceIndex, void* ptr) {} // 0x00000001822B8CE0-0x00000001822B8D00
			public unsafe void* GetFrontBuffer(int deviceIndex) => default; // 0x00000001822BABC0-0x00000001822BABE0
			public unsafe void* GetBackBuffer(int deviceIndex) => default; // 0x00000001822B8D10-0x00000001822B8D30
			public void SwapBuffers(int deviceIndex) {} // 0x00000001822B8D30-0x00000001822B8D90
		}
	
		// Methods
		public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) => default; // 0x00000001824B1840-0x00000001824B1870
		public static unsafe void* GetFrontBufferForDevice(int deviceIndex) => default; // 0x00000001822BAB60-0x00000001822BABC0
		public static unsafe void* GetBackBufferForDevice(int deviceIndex) => default; // 0x0000000183CA3C70-0x0000000183CA3CC0
		public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) {} // 0x00000001824B17E0-0x00000001824B1840
		public void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount) {} // 0x000000018235D760-0x000000018235D870
		private static unsafe DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer) => default; // 0x000000018235D870-0x000000018235D910
		public void FreeAll() {} // 0x000000018235D680-0x000000018235D760
		public void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) {} // 0x000000018235D970-0x000000018235DB30
		private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) {} // 0x000000018235CCC0-0x000000018235CEC0
		private static unsafe void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer) {} // 0x000000018235DB30-0x000000018235DC60
		private static uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount) => default; // 0x000000018235D910-0x000000018235D970
		private static uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device) => default; // 0x00000001822B7FD0-0x00000001822B8060
	}

	public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IInputStateChangeMonitor // TypeDefIndex: 44512
	{
		// Fields
		private const int kDefaultHistorySize = 128; // Metadata: 0x01FB6B81
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
		public int Count { get => default; } // 0x0000000183D4EE80-0x0000000183D4EE90 
		public uint version { get => default; } // 0x0000000183D4EEC0-0x0000000183D4EED0 
		public int historyDepth { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000182CADC30-0x0000000182CADC80
		public int extraMemoryPerRecord { get => default; set {} } // 0x0000000183D4EDF0-0x0000000183D4EE00 0x0000000182CADBE0-0x0000000182CADC30
		public InputUpdateType updateMask { get => default; set {} } // 0x0000000189C27854-0x0000000189C278D8 0x0000000182CADB80-0x0000000182CADBE0
		public ReadOnlyArray<InputControl> controls { get => default; } // 0x0000000182EB8530-0x0000000182EB8590 
		public Record this[int index] { get => default; set {} } // 0x0000000189C27708-0x0000000189C2782C 0x0000000189C278D8-0x0000000189C27A1C
		public Action<Record> onRecordAdded { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		internal int bytesPerRecord { get => default; } // 0x0000000189C2782C-0x0000000189C27854 
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 44507
		{
			// Fields
			private readonly InputStateHistory m_History; // 0x00
			private int m_Index; // 0x08
	
			// Properties
			public Record Current { get => default; } // 0x0000000189C1F7E8-0x0000000189C1F824 
			object IEnumerator.Current { get => default; } // 0x0000000189C1F760-0x0000000189C1F7B8 
	
			// Constructors
			public Enumerator(InputStateHistory history) : this() {
				m_History = default;
				m_Index = default;
			} // 0x0000000186BB19D8-0x0000000186BB19F4
	
			// Methods
			public bool MoveNext() => default; // 0x0000000186C03688-0x0000000186C036B4
			public void Reset() {} // 0x0000000183D60980-0x0000000183D60990
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		protected internal struct RecordHeader // TypeDefIndex: 44510
		{
			// Fields
			public double time; // 0x00
			public uint version; // 0x08
			public int controlIndex; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithoutControlIndex[0]; // 0x0C
			private unsafe fixed /* 0x00000000-0x00000000 */ byte m_StateWithControlIndex[0]; // 0x10
			public const int kSizeWithControlIndex = 16; // Metadata: 0x01FB6B83
			public const int kSizeWithoutControlIndex = 12; // Metadata: 0x01FB6B84
	
			// Properties
			public unsafe byte* statePtrWithControlIndex { get => default; } // 0x0000000183D55960-0x0000000183D55970 
			public unsafe byte* statePtrWithoutControlIndex { get => default; } // 0x0000000183D70B10-0x0000000183D70B20 
		}
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 44511
		{
			// Fields
			private readonly InputStateHistory m_Owner; // 0x00
			private readonly int m_IndexPlusOne; // 0x08
			private uint m_Version; // 0x0C
	
			// Properties
			internal unsafe RecordHeader* header { get => default; } // 0x0000000189C2A0DC-0x0000000189C2A104 
			internal int recordIndex { get => default; } // 0x0000000183D691A0-0x0000000183D691B0 
			internal uint version { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
			public bool valid { get => default; } // 0x0000000189C2A2E0-0x0000000189C2A320 
			public InputStateHistory owner { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
			public int index { get => default; } // 0x0000000189C2A104-0x0000000189C2A134 
			public double time { get => default; } // 0x0000000189C2A2B0-0x0000000189C2A2E0 
			public InputControl control { get => default; } // 0x0000000189C2A030-0x0000000189C2A0DC 
			public Record next { get => default; } // 0x0000000189C2A134-0x0000000189C2A1F4 
			public Record previous { get => default; } // 0x0000000189C2A1F4-0x0000000189C2A2B0 
	
			// Constructors
			internal unsafe Record(InputStateHistory owner, int index, RecordHeader* header) : this() {
				m_Owner = default;
				m_IndexPlusOne = default;
				m_Version = default;
			} // 0x0000000187AF298C-0x0000000187AF29BC
	
			// Methods
			public TValue ReadValue<TValue>()
				where TValue : struct => default;
			public object ReadValueAsObject() => default; // 0x0000000189C29F28-0x0000000189C29F6C
			public unsafe void* GetUnsafeMemoryPtr() => default; // 0x0000000189C29F08-0x0000000189C29F28
			internal unsafe void* GetUnsafeMemoryPtrUnchecked() => default; // 0x0000000189C29E88-0x0000000189C29F08
			public unsafe void* GetUnsafeExtraMemoryPtr() => default; // 0x0000000189C29E68-0x0000000189C29E88
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked() => default; // 0x0000000189C29DBC-0x0000000189C29E68
			public void CopyFrom(Record record) {} // 0x0000000189C29940-0x0000000189C29D4C
			internal void CheckValid() {} // 0x0000000189C29868-0x0000000189C29940
			public bool Equals(Record other) => default; // 0x000000018773E738-0x000000018773E758
			public override bool Equals(object obj) => default; // 0x0000000189C29D4C-0x0000000189C29DBC
			public override int GetHashCode() => default; // 0x0000000187AF24DC-0x0000000187AF2510
			public override string ToString() => default; // 0x0000000189C29F6C-0x0000000189C2A030
		}
	
		// Constructors
		public InputStateHistory() {} // Dummy constructor
		public InputStateHistory(int maxStateSizeInBytes) {} // 0x000000018397E0D0-0x000000018397E120
		public InputStateHistory(string path) {} // 0x0000000189C275AC-0x0000000189C27708
		public InputStateHistory(InputControl control) {} // 0x000000018381CFF0-0x000000018381D090
		public InputStateHistory(IEnumerable<InputControl> controls) {} // 0x0000000189C27538-0x0000000189C275AC
	
		// Methods
		~InputStateHistory() {} // 0x0000000189C26B68-0x0000000189C26BD8
		public void Clear() {} // 0x0000000183D78140-0x0000000183D78150
		public Record AddRecord(Record record) => default; // 0x0000000189C267B0-0x0000000189C26828
		public void StartRecording() {} // 0x0000000182EB8120-0x0000000182EB8530
		public void StopRecording() {} // 0x0000000189C27350-0x0000000189C2747C
		public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) => default; // 0x0000000189C26E8C-0x0000000189C27080
		public unsafe Record RecordStateChange(InputControl control, void* statePtr, double time) => default; // 0x0000000189C27080-0x0000000189C27350
		public IEnumerator<Record> GetEnumerator() => default; // 0x0000000189C26BD8-0x0000000189C26C38
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189C2747C-0x0000000189C27484
		public void Dispose() {} // 0x0000000189C26B14-0x0000000189C26B68
		protected void Destroy() {} // 0x0000000189C26ABC-0x0000000189C26B14
		private void Allocate() {} // 0x0000000189C268C0-0x0000000189C26ABC
		protected internal int RecordIndexToUserIndex(int index) => default; // 0x0000000189C26E78-0x0000000189C26E8C
		protected internal int UserIndexToRecordIndex(int index) => default; // 0x0000000183D78150-0x0000000183D78160
		protected internal unsafe RecordHeader* GetRecord(int index) => default; // 0x0000000189C26C8C-0x0000000189C26D80
		internal unsafe RecordHeader* GetRecordUnchecked(int index) => default; // 0x0000000189C26C38-0x0000000189C26C8C
		protected internal unsafe RecordHeader* AllocateRecord(out int index) {
			index = default;
			return default;
		} // 0x0000000189C26828-0x0000000189C268C0
		protected unsafe TValue ReadValue<TValue>(RecordHeader* data)
			where TValue : struct => default;
		protected unsafe object ReadValueAsObject(RecordHeader* data) => default; // 0x0000000189C26D80-0x0000000189C26E78
		void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) {} // 0x0000000189C27484-0x0000000189C27538
		void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) {} // 0x000000018350B670-0x000000018350B680
	}

	public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>> // TypeDefIndex: 44515
		where TValue : struct
	{
		// Properties
		public new Record this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<Record> // TypeDefIndex: 44513
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
	
		public struct Record : IEquatable<Record> // TypeDefIndex: 44514
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
		public Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1 /* Metadata: 0x01FB6B85 */) => default;
		public new IEnumerator<Record> GetEnumerator() => default;
		new IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal class SelectObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 44517
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, TResult> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 44516
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
	[AddComponentMenu("Input/On-Screen Button")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/OnScreen.html#on-screen-buttons")]
	public class OnScreenButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 44337
	{
		// Fields
		[InputControl(layout = "Button")]
		[SerializeField]
		private string m_ControlPath; // 0x30
	
		// Properties
		protected override string controlPathInternal { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public OnScreenButton() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000189C06C00-0x0000000189C06C3C
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000189C06BBC-0x0000000189C06C00
	}

	public abstract class OnScreenControl : MonoBehaviour // TypeDefIndex: 44339
	{
		// Fields
		private InputControl m_Control; // 0x18
		private OnScreenControl m_NextControlOnDevice; // 0x20
		private InputEventPtr m_InputEventPtr; // 0x28
		private static int s_nbActiveInstances; // 0x00
		private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; // 0x08
	
		// Properties
		public string controlPath { get; set; } // 0x0000000184273A44-0x0000000184273A54 0x0000000189C07AD8-0x0000000189C07B14
		public InputControl control { get; } // 0x0000000181041090-0x00000001810410A0 
		protected abstract string controlPathInternal { get; set; }
		internal static bool HasAnyActive { get; } // 0x0000000189C07A9C-0x0000000189C07AD8 
	
		// Nested types
		private struct OnScreenDeviceInfo // TypeDefIndex: 44338
		{
			// Fields
			public InputEventPtr eventPtr; // 0x00
			public NativeArray<byte> buffer; // 0x08
			public UnityEngine.InputSystem.InputDevice device; // 0x18
			public OnScreenControl firstControl; // 0x20
	
			// Methods
			public OnScreenDeviceInfo AddControl(OnScreenControl control) => default; // 0x0000000189C07B14-0x0000000189C07B70
			public OnScreenDeviceInfo RemoveControl(OnScreenControl control) => default; // 0x0000000189C07C0C-0x0000000189C07D48
			public void Destroy() {} // 0x0000000189C07B70-0x0000000189C07C0C
		}
	
		// Constructors
		protected OnScreenControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void SetupInputControl() {} // 0x0000000189C07280-0x0000000189C07A9C
		protected void SendValueToControl<TValue>(TValue value)
			where TValue : struct {}
		protected void SentDefaultValueToControl() {} // 0x0000000189C071E8-0x0000000189C07280
		protected virtual void OnEnable() {} // 0x0000000189C06F08-0x0000000189C071E8
		protected virtual void OnDisable() {} // 0x0000000189C06C84-0x0000000189C06F08
		internal string GetWarningMessage() => default; // 0x0000000189C06C3C-0x0000000189C06C84
	}

	internal static class UGUIOnScreenControlUtils // TypeDefIndex: 44340
	{
		// Methods
		public static RectTransform GetCanvasRectTransform(Transform transform) => default; // 0x0000000189C0BF54-0x0000000189C0BFEC
	}

	[AddComponentMenu("Input/On-Screen Stick")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/OnScreen.html#on-screen-sticks")]
	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 44342
	{
		// Fields
		private const string kDynamicOriginClickable = "DynamicOriginClickable"; // Metadata: 0x01FB6859
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
		public float movementRange { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
		public float dynamicOriginRange { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000189C099E0-0x0000000189C099FC
		public bool useIsolatedInputActions { get => default; set {} } // 0x0000000183D4F170-0x0000000183D4F180 0x0000000183D4F180-0x0000000183D4F190
		protected override string controlPathInternal { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public Behaviour behaviour { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
	
		// Nested types
		public enum Behaviour // TypeDefIndex: 44341
		{
			RelativePositionWithStaticOrigin = 0,
			ExactPositionWithStaticOrigin = 1,
			ExactPositionWithDynamicOrigin = 2
		}
	
		// Constructors
		public OnScreenStick() {} // 0x0000000189C099C8-0x0000000189C099E0
	
		// Methods
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000189C08F20-0x0000000189C08FD8
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189C085F8-0x0000000189C086B0
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000189C091E8-0x0000000189C091F8
		private void Start() {} // 0x0000000189C091F8-0x0000000189C098A0
		private void OnDestroy() {} // 0x0000000189C08560-0x0000000189C085F8
		private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) {} // 0x0000000189C07D48-0x0000000189C07F18
		private void MoveStick(Vector2 pointerPosition, Camera uiCamera) {} // 0x0000000189C0822C-0x0000000189C08560
		private void EndInteraction() {} // 0x0000000189C08058-0x0000000189C0811C
		private void OnPointerDown(InputAction.CallbackContext ctx) {} // 0x0000000189C088E4-0x0000000189C08F20
		private void OnPointerChanged(InputAction.CallbackContext ctx) {} // 0x0000000189C0888C-0x0000000189C088E4
		private void OnPointerMove(InputAction.CallbackContext ctx) {} // 0x0000000189C08FD8-0x0000000189C090DC
		private void OnPointerUp(InputAction.CallbackContext ctx) {} // 0x0000000189C090DC-0x0000000189C091E8
		private Camera GetCameraFromCanvas() => default; // 0x0000000189C0811C-0x0000000189C0822C
		private void OnDrawGizmosSelected() {} // 0x0000000189C086B0-0x0000000189C0888C
		private void DrawGizmoCircle(Vector2 center, float radius) {} // 0x0000000189C07F18-0x0000000189C08058
		private void UpdateDynamicOriginClickableArea() {} // 0x0000000189C098A0-0x0000000189C099C8
	}
}

namespace UnityEngine.InputSystem.Processors
{
	public class AxisDeadzoneProcessor : InputProcessor<float> // TypeDefIndex: 44518
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get => default; } // 0x0000000189C1C284-0x0000000189C1C2E4 
		private float maxOrDefault { get => default; } // 0x0000000189C1C224-0x0000000189C1C284 
	
		// Constructors
		public AxisDeadzoneProcessor() {} // 0x0000000189C1C1FC-0x0000000189C1C224
	
		// Methods
		public override float Process(float value, InputControl control = null) => default; // 0x0000000189C1C0F0-0x0000000189C1C160
		public override string ToString() => default; // 0x0000000189C1C160-0x0000000189C1C1FC
	}

	public class ClampProcessor : InputProcessor<float> // TypeDefIndex: 44519
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Constructors
		public ClampProcessor() {} // 0x0000000189C1C840-0x0000000189C1C868
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000189C1C794-0x0000000189C1C7B0
		public override string ToString() => default; // 0x0000000189C1C7B0-0x0000000189C1C840
	}

	[DesignTimeVisible(false)]
	internal class CompensateDirectionProcessor : InputProcessor<Vector3> // TypeDefIndex: 44520
	{
		// Properties
		public override CachingPolicy cachingPolicy { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CompensateDirectionProcessor() {} // 0x0000000189C1D61C-0x0000000189C1D644
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x0000000189C1D4C0-0x0000000189C1D5F0
		public override string ToString() => default; // 0x0000000189C1D5F0-0x0000000189C1D61C
	}

	[DesignTimeVisible(false)]
	internal class CompensateRotationProcessor : InputProcessor<Quaternion> // TypeDefIndex: 44521
	{
		// Properties
		public override CachingPolicy cachingPolicy { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CompensateRotationProcessor() {} // 0x0000000189C1D770-0x0000000189C1D798
	
		// Methods
		public override Quaternion Process(Quaternion value, InputControl control) => default; // 0x0000000189C1D644-0x0000000189C1D744
		public override string ToString() => default; // 0x0000000189C1D744-0x0000000189C1D770
	}

	public class InvertProcessor : InputProcessor<float> // TypeDefIndex: 44522
	{
		// Constructors
		public InvertProcessor() {} // 0x0000000189C2840C-0x0000000189C28434
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000183D71BB0-0x0000000183D71BC0
		public override string ToString() => default; // 0x0000000189C283E0-0x0000000189C2840C
	}

	public class InvertVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 44523
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
	
		// Constructors
		public InvertVector2Processor() {} // 0x0000000189C28514-0x0000000189C28550
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x0000000189C28434-0x0000000189C2848C
		public override string ToString() => default; // 0x0000000189C2848C-0x0000000189C28514
	}

	public class InvertVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 44524
	{
		// Fields
		public bool invertX; // 0x10
		public bool invertY; // 0x11
		public bool invertZ; // 0x12
	
		// Constructors
		public InvertVector3Processor() {} // 0x0000000189C28660-0x0000000189C28698
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x0000000189C28550-0x0000000189C285AC
		public override string ToString() => default; // 0x0000000189C285AC-0x0000000189C28660
	}

	public class NormalizeProcessor : InputProcessor<float> // TypeDefIndex: 44525
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
		public float zero; // 0x18
	
		// Constructors
		public NormalizeProcessor() {} // 0x0000000189C29750-0x0000000189C29778
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000189C29664-0x0000000189C29690
		public static float Normalize(float value, float min, float max, float zero) => default; // 0x00000001822F8930-0x00000001822F89A0
		internal static float Denormalize(float value, float min, float max, float zero) => default; // 0x0000000189C29614-0x0000000189C29664
		public override string ToString() => default; // 0x0000000189C29690-0x0000000189C29750
	}

	public class NormalizeVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 44526
	{
		// Constructors
		public NormalizeVector2Processor() {} // 0x0000000189C297BC-0x0000000189C297E4
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x0000000189C29778-0x0000000189C29790
		public override string ToString() => default; // 0x0000000189C29790-0x0000000189C297BC
	}

	public class NormalizeVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 44527
	{
		// Constructors
		public NormalizeVector3Processor() {} // 0x0000000189C29840-0x0000000189C29868
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x0000000189C297E4-0x0000000189C29814
		public override string ToString() => default; // 0x0000000189C29814-0x0000000189C29840
	}

	public class ScaleProcessor : InputProcessor<float> // TypeDefIndex: 44528
	{
		// Fields
		[Tooltip("Scale factor to multiply incoming float values by.")]
		public float factor; // 0x10
	
		// Constructors
		public ScaleProcessor() {} // 0x0000000189C2B608-0x0000000189C2B644
	
		// Methods
		public override float Process(float value, InputControl control) => default; // 0x0000000183D78180-0x0000000183D78190
		public override string ToString() => default; // 0x0000000189C2B5A4-0x0000000189C2B608
	}

	public class ScaleVector2Processor : InputProcessor<Vector2> // TypeDefIndex: 44529
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector2\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector2\'s Y component by.")]
		public float y; // 0x14
	
		// Constructors
		public ScaleVector2Processor() {} // 0x0000000189C2B6D4-0x0000000189C2B720
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control) => default; // 0x0000000183D78190-0x0000000183D781C0
		public override string ToString() => default; // 0x0000000189C2B644-0x0000000189C2B6D4
	}

	public class ScaleVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 44530
	{
		// Fields
		[Tooltip("Scale factor to multiply the incoming Vector3\'s X component by.")]
		public float x; // 0x10
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Y component by.")]
		public float y; // 0x14
		[Tooltip("Scale factor to multiply the incoming Vector3\'s Z component by.")]
		public float z; // 0x18
	
		// Constructors
		public ScaleVector3Processor() {} // 0x0000000189C2B7E0-0x0000000189C2B820
	
		// Methods
		public override Vector3 Process(Vector3 value, InputControl control) => default; // 0x0000000183D781C0-0x0000000183D78200
		public override string ToString() => default; // 0x0000000189C2B720-0x0000000189C2B7E0
	}

	public class StickDeadzoneProcessor : InputProcessor<Vector2> // TypeDefIndex: 44531
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
	
		// Properties
		private float minOrDefault { get => default; } // 0x0000000189C2BE9C-0x0000000189C2BEFC 
		private float maxOrDefault { get => default; } // 0x0000000189C2BE3C-0x0000000189C2BE9C 
	
		// Constructors
		public StickDeadzoneProcessor() {} // 0x0000000189C2BE14-0x0000000189C2BE3C
	
		// Methods
		public override Vector2 Process(Vector2 value, InputControl control = null) => default; // 0x0000000189C2BD00-0x0000000189C2BD78
		private float GetDeadZoneAdjustedValue(float value) => default; // 0x0000000189C2BC90-0x0000000189C2BD00
		public override string ToString() => default; // 0x0000000189C2BD78-0x0000000189C2BE14
	}
}

namespace UnityEngine.InputSystem.Switch
{
	[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
	public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor // TypeDefIndex: 44333
	{
		// Fields
		private static readonly SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence; // 0x00
		private int m_HandshakeStepIndex; // 0x220
		private double m_HandshakeTimer; // 0x228
		internal const byte JitterMaskLow = 120; // Metadata: 0x01FB6830
		internal const byte JitterMaskHigh = 135; // Metadata: 0x01FB6831
	
		// Properties
		[InputControl(name = "capture", displayName = "Capture")]
		public ButtonControl captureButton { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(name = "home", displayName = "Home")]
		public ButtonControl homeButton { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
	
		// Nested types
		private struct SwitchInputOnlyReport // TypeDefIndex: 44324
		{
			// Fields
			public const int kSize = 7; // Metadata: 0x01FB6832
			public byte buttons0; // 0x00
			public byte buttons1; // 0x01
			public byte hat; // 0x02
			public byte leftX; // 0x03
			public byte leftY; // 0x04
			public byte rightX; // 0x05
			public byte rightY; // 0x06
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000189C09D6C-0x0000000189C09FE4
		}
	
		private struct SwitchSimpleInputReport // TypeDefIndex: 44325
		{
			// Fields
			public const int kSize = 12; // Metadata: 0x01FB6833
			public const byte ExpectedReportId = 63; // Metadata: 0x01FB6834
			public byte reportId; // 0x00
			public byte buttons0; // 0x01
			public byte buttons1; // 0x02
			public byte hat; // 0x03
			public ushort leftX; // 0x04
			public ushort leftY; // 0x06
			public ushort rightX; // 0x08
			public ushort rightY; // 0x0A
	
			// Methods
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000189C0A834-0x0000000189C0AB04
		}
	
		private struct SwitchFullInputReport // TypeDefIndex: 44326
		{
			// Fields
			public const int kSize = 25; // Metadata: 0x01FB6835
			public const byte ExpectedReportId = 48; // Metadata: 0x01FB6836
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
			public SwitchProControllerHIDInputState ToHIDInputReport() => default; // 0x0000000189C09B00-0x0000000189C09D6C
		}
	
		private struct SwitchHIDGenericInputReport // TypeDefIndex: 44327
		{
			// Fields
			public byte reportId; // 0x00
	
			// Properties
			public static FourCC Format { get => default; } // 0x0000000183D775E0-0x0000000183D775F0 
		}
	
		internal struct SwitchMagicOutputReport // TypeDefIndex: 44330
		{
			// Fields
			public const int kSize = 49; // Metadata: 0x01FB6837
			public const byte ExpectedReplyInputReportId = 129; // Metadata: 0x01FB6838
			public byte reportType; // 0x00
			public byte commandId; // 0x01
	
			// Nested types
			internal enum ReportType // TypeDefIndex: 44328
			{
				Magic = 128
			}
	
			public enum CommandIdType // TypeDefIndex: 44329
			{
				Status = 1,
				Handshake = 2,
				Highspeed = 3,
				ForceUSB = 4
			}
		}
	
		internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo // TypeDefIndex: 44331
		{
			// Fields
			public const int kSize = 57; // Metadata: 0x01FB683F
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get => default; } // 0x0000000183D77650-0x0000000183D77660 
			public FourCC typeStatic { get => default; } // 0x0000000183D77650-0x0000000183D77660 
	
			// Methods
			public static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type) => default; // 0x0000000183D775F0-0x0000000183D77650
		}
	
		internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo // TypeDefIndex: 44332
		{
			// Fields
			public const int kSize = 72; // Metadata: 0x01FB6840
			public InputDeviceCommand baseCommand; // 0x00
			public SwitchMagicOutputReport report; // 0x08
	
			// Properties
			public static FourCC Type { get => default; } // 0x0000000183D77650-0x0000000183D77660 
			public FourCC typeStatic { get => default; } // 0x0000000183D77650-0x0000000183D77660 
	
			// Methods
			public static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type) => default; // 0x0000000183D77660-0x0000000183D776C0
		}
	
		// Constructors
		public SwitchProControllerHID() {} // 0x0000000184275C10-0x0000000184275C18
		static SwitchProControllerHID() {} // 0x0000000189C0A7A8-0x0000000189C0A834
	
		// Methods
		protected override void OnAdded() {} // 0x0000000189C0A41C-0x0000000189C0A4C4
		private void HandshakeRestart() {} // 0x0000000189C0A180-0x0000000189C0A1DC
		private void HandshakeTick() {} // 0x0000000189C0A1DC-0x0000000189C0A41C
		public void OnNextUpdate() {} // 0x0000000189C0A4C4-0x0000000189C0A4CC
		public void OnStateEvent(InputEventPtr eventPtr) {} // 0x0000000189C0A4CC-0x0000000189C0A624
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool PreProcessEvent(InputEventPtr eventPtr) => default; // 0x0000000189C0A624-0x0000000189C0A7A8
	}

	internal static class SwitchSupportHID // TypeDefIndex: 44334
	{
		// Methods
		public static void Initialize() {} // 0x0000000182F18BB0-0x0000000182F193D0
	}
}

namespace UnityEngine.InputSystem.Switch.LowLevel
{
	internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo // TypeDefIndex: 44336
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
		public FourCC format { get => default; } // 0x0000000189C0A130-0x0000000189C0A180 
	
		// Nested types
		public enum Button // TypeDefIndex: 44335
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
		} // 0x0000000189C0A0F4-0x0000000189C0A130
	
		// Methods
		public SwitchProControllerHIDInputState WithButton(Button button, bool value = true /* Metadata: 0x01FB6842 */) => default; // 0x0000000189C0A094-0x0000000189C0A0F4
		public void Set(Button button, bool state) {} // 0x0000000189C02F80-0x0000000189C032B4
		public void Press(Button button) {} // 0x0000000189C09FE4-0x0000000189C0A03C
		public void Release(Button button) {} // 0x0000000189C0A03C-0x0000000189C0A094
	}
}

namespace UnityEngine.InputSystem.UI
{
	internal class BaseInputOverride : BaseInput // TypeDefIndex: 44304
	{
		// Properties
		public override string compositionString { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public BaseInputOverride() {} // 0x000000018426FE60-0x000000018426FE68
	}

	internal class ExtendedAxisEventData : AxisEventData, INavigationEventData // TypeDefIndex: 44305
	{
		// Properties
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public ExtendedAxisEventData() {} // Dummy constructor
		public ExtendedAxisEventData(EventSystem eventSystem) {} // 0x0000000189C034E4-0x0000000189C034EC
	
		// Methods
		public override string ToString() => default; // 0x0000000189C0344C-0x0000000189C034E4
	}

	public class ExtendedPointerEventData : PointerEventData // TypeDefIndex: 44306
	{
		// Properties
		public InputControl control { get; set; } // 0x0000000183D570E0-0x0000000183D570F0 0x00000001858B3C90-0x00000001858B3CA4
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x0000000183D570F0-0x0000000183D57100 0x00000001858B3CA4-0x00000001858B3CB8
		public int touchId { get; set; } // 0x0000000183D5A810-0x0000000183D5A820 0x0000000183D5A880-0x0000000183D5A890
		public UIPointerType pointerType { get; set; } // 0x0000000183D4FC30-0x0000000183D4FC40 0x0000000183D77510-0x0000000183D77520
		public int uiToolkitPointerId { get; set; } // 0x0000000183D6D0A0-0x0000000183D6D0B0 0x0000000183D72310-0x0000000183D72320
		public Vector3 trackedDevicePosition { get; set; } // 0x0000000183D774F0-0x0000000183D77510 0x0000000183D77530-0x0000000183D77550
		public Quaternion trackedDeviceOrientation { get; set; } // 0x0000000183D774E0-0x0000000183D774F0 0x0000000183D77520-0x0000000183D77530
	
		// Constructors
		public ExtendedPointerEventData() {} // Dummy constructor
		public ExtendedPointerEventData(EventSystem eventSystem) {} // 0x00000001842744F8-0x0000000184274500
	
		// Methods
		public override string ToString() => default; // 0x0000000189C0377C-0x0000000189C03C00
		internal static int MakePointerIdForTouch(int deviceId, int touchId) => default; // 0x0000000183D774D0-0x0000000183D774E0
		internal static int TouchIdFromPointerId(int pointerId) => default; // 0x0000000183D702E0-0x0000000183D702F0
		internal void ReadDeviceState() {} // 0x00000001822C0950-0x00000001822C0C70
		private static int GetPenPointerId(Pen pen) => default; // 0x0000000189C034EC-0x0000000189C036A0
		private static int GetTouchPointerId(TouchControl touchControl) => default; // 0x0000000189C036A0-0x0000000189C0377C
	}

	public enum UIPointerType // TypeDefIndex: 44307
	{
		None = 0,
		MouseOrPen = 1,
		Touch = 2,
		Tracked = 3
	}

	public enum UIPointerBehavior // TypeDefIndex: 44308
	{
		SingleMouseOrPenButMultiTouchAndTrack = 0,
		SingleUnifiedPointer = 1,
		AllPointersAsIs = 2
	}

	internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData // TypeDefIndex: 44309
	{
		// Properties
		public UnityEngine.InputSystem.InputDevice device { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public ExtendedSubmitCancelEventData() {} // Dummy constructor
		public ExtendedSubmitCancelEventData(EventSystem eventSystem) {} // 0x00000001822C3A90-0x00000001822C3AA0
	}

	internal interface INavigationEventData // TypeDefIndex: 44310
	{
		// Properties
		UnityEngine.InputSystem.InputDevice device { get; }
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#setting-up-ui-input")]
	public class InputSystemUIInputModule : BaseInputModule // TypeDefIndex: 44313
	{
		// Fields
		private const float kClickSpeed = 0.3f; // Metadata: 0x01FB6827
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
		public bool deselectOnBackgroundClick { get => default; set {} } // 0x0000000183D51F80-0x0000000183D51F90 0x0000000183D51FD0-0x0000000183D51FE0
		public UIPointerBehavior pointerBehavior { get => default; set {} } // 0x0000000183D57F20-0x0000000183D57F30 0x0000000183D57FA0-0x0000000183D57FB0
		public CursorLockBehavior cursorLockBehavior { get => default; set {} } // 0x0000000183D57EF0-0x0000000183D57F00 0x0000000183D57F70-0x0000000183D57F80
		internal GameObject localMultiPlayerRoot { get => default; set {} } // 0x0000000183D572C0-0x0000000183D572D0 0x00000001858B3F60-0x00000001858B3F74
		public float scrollDeltaPerTick { get => default; set {} } // 0x0000000183D58470-0x0000000183D58480 0x0000000183D69550-0x0000000183D69560
		public float moveRepeatDelay { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float moveRepeatRate { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		private bool explictlyIgnoreFocus { get => default; } // 0x00000001822BFA50-0x00000001822BFAB0 
		private bool shouldIgnoreFocus { get => default; } // 0x00000001822BF9B0-0x00000001822BFA50 
		[Obsolete("\'repeatRate\' has been obsoleted; use \'moveRepeatRate\' instead. (UnityUpgradable) -> moveRepeatRate", false)]
		public float repeatRate { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		[Obsolete("\'repeatDelay\' has been obsoleted; use \'moveRepeatDelay\' instead. (UnityUpgradable) -> moveRepeatDelay", false)]
		public float repeatDelay { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public Transform xrTrackingOrigin { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public float trackedDeviceDragThresholdMultiplier { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public InputActionReference point { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000189C06584-0x0000000189C065B8
		public InputActionReference scrollWheel { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189C065F0-0x0000000189C06628
		public InputActionReference leftClick { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000189C064E0-0x0000000189C06518
		public InputActionReference middleClick { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x0000000189C06518-0x0000000189C06550
		public InputActionReference rightClick { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x0000000189C065B8-0x0000000189C065F0
		public InputActionReference move { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x0000000189C06550-0x0000000189C06584
		public InputActionReference submit { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x0000000189C06628-0x0000000189C0665C
		public InputActionReference cancel { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x0000000189C064A8-0x0000000189C064E0
		public InputActionReference trackedDeviceOrientation { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000189C0665C-0x0000000189C06694
		public InputActionReference trackedDevicePosition { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000189C06694-0x0000000189C066CC
		[Obsolete("\'trackedDeviceSelect\' has been obsoleted; use \'leftClick\' instead.", true)]
		public InputActionReference trackedDeviceSelect { get => default; set {} } // 0x0000000189C0629C-0x0000000189C062E8 0x0000000189C066CC-0x0000000189C06718
		public InputActionAsset actionsAsset { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x0000000189C062E8-0x0000000189C064A8
		private bool sendPointerHoverToParent { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		private struct InputActionReferenceState // TypeDefIndex: 44311
		{
			// Fields
			public int refCount; // 0x00
			public bool enabledByInputModule; // 0x04
		}
	
		public enum CursorLockBehavior // TypeDefIndex: 44312
		{
			OutsideScreen = 0,
			ScreenCenter = 1
		}
	
		// Constructors
		public InputSystemUIInputModule() {} // 0x0000000183D444A0-0x0000000183D444E0
		static InputSystemUIInputModule() {} // 0x0000000183CDF640-0x0000000183CDF6E0
	
		// Methods
		public override void ActivateModule() {} // 0x00000001822C3840-0x00000001822C3900
		public override bool IsPointerOverGameObject(int pointerOrTouchId) => default; // 0x0000000189C0550C-0x0000000189C05630
		public RaycastResult GetLastRaycastResult(int pointerOrTouchId) => default; // 0x0000000189C05150-0x0000000189C05248
		private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) => default; // 0x00000001822C2D60-0x00000001822C2F90
		private void ProcessPointer(ref PointerModel state) {} // 0x00000001822C1670-0x00000001822C1A50
		private bool PointerShouldIgnoreTransform(Transform t) => default; // 0x00000001822C2CF0-0x00000001822C2D60
		private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) {} // 0x00000001822C31D0-0x00000001822C3220
		private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) {} // 0x00000001822C0C70-0x00000001822C1670
		private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData) {} // 0x00000001822C22D0-0x00000001822C2B80
		private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData) {} // 0x00000001822C1F70-0x00000001822C22A0
		private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) {} // 0x00000001822C3220-0x00000001822C3500
		internal void ProcessNavigation(ref NavigationModel navigationState) {} // 0x00000001822BFC00-0x00000001822C0040
		private bool IsMoveAllowed(AxisEventData eventData) => default; // 0x0000000189C05354-0x0000000189C0550C
		private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback) {} // 0x0000000189C05CC4-0x0000000189C05F70
		public void AssignDefaultActions() {} // 0x0000000189C04C1C-0x0000000189C04FE4
		public void UnassignActions() {} // 0x0000000189C060E8-0x0000000189C061FC
		protected override void Awake() {} // 0x0000000183D4B980-0x0000000183D4B990
		protected override void OnDestroy() {} // 0x0000000189C05630-0x0000000189C05638
		protected override void OnEnable() {} // 0x00000001837A02E0-0x00000001837A0400
		protected override void OnDisable() {} // 0x0000000189C05638-0x0000000189C056D4
		private void ResetPointers() {} // 0x00000001837A0400-0x00000001837A0440
		private bool HasNoActions() => default; // 0x00000001837A04A0-0x00000001837A0510
		private void EnableAllActions() {} // 0x0000000182EB9EF0-0x0000000182EB9FB0
		private void DisableAllActions() {} // 0x0000000189C0507C-0x0000000189C05150
		private void EnableInputAction(InputActionReference inputActionReference) {} // 0x0000000182EB9FB0-0x0000000182EBA110
		private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false /* Metadata: 0x01FB6825 */) {} // 0x0000000189C05F70-0x0000000189C060E8
		private int GetPointerStateIndexFor(int pointerOrTouchId) => default; // 0x0000000189C05248-0x0000000189C05354
		private ref PointerModel GetPointerStateForIndex(int index) => ref _refReturnTypeForGetPointerStateForIndex; // 0x00000001822C06A0-0x00000001822C06C0
		private ref PointerModel _refReturnTypeForGetPointerStateForIndex; // Dummy field
		private int GetDisplayIndexFor(InputControl control) => default; // 0x0000000182EB6A90-0x0000000182EB6B50
		private int GetPointerStateIndexFor(ref InputAction.CallbackContext context) => default; // 0x0000000182EB6700-0x0000000182EB6770
		private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true /* Metadata: 0x01FB6826 */) => default; // 0x0000000182EB6770-0x0000000182EB6A90
		private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, UnityEngine.InputSystem.InputDevice device, InputControl touchControl = null) => default; // 0x0000000182EB6ED0-0x0000000182EB7200
		private bool SendPointerExitEventsAndRemovePointer(int index) => default; // 0x0000000189C05BF8-0x0000000189C05CC4
		private bool RemovePointerAtIndex(int index) => default; // 0x0000000189C05958-0x0000000189C05BF8
		private void PurgeStalePointers() {} // 0x0000000182EB7600-0x0000000182EB76D0
		private static bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, InputActionReference actionReference) => default; // 0x0000000182EB77A0-0x0000000182EB7860
		private void OnPointCallback(InputAction.CallbackContext context) {} // 0x00000001822BF520-0x00000001822BF6C0
		private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed) => default; // 0x0000000182EB6DB0-0x0000000182EB6ED0
		private void OnLeftClickCallback(InputAction.CallbackContext context) {} // 0x0000000182EB65C0-0x0000000182EB6650
		private void OnRightClickCallback(InputAction.CallbackContext context) {} // 0x0000000182EB62A0-0x0000000182EB6330
		private void OnMiddleClickCallback(InputAction.CallbackContext context) {} // 0x0000000189C056D4-0x0000000189C05764
		private bool CheckForRemovedDevice(ref InputAction.CallbackContext context) => default; // 0x00000001822BF360-0x00000001822BF3C0
		private void OnScrollCallback(InputAction.CallbackContext context) {} // 0x0000000182EB6650-0x0000000182EB6700
		private void OnMoveCallback(InputAction.CallbackContext context) {} // 0x0000000189C05764-0x0000000189C057F8
		private void OnSubmitCancelCallback(InputAction.CallbackContext context) {} // 0x0000000189C057F8-0x0000000189C05838
		private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context) {} // 0x0000000189C05838-0x0000000189C058C4
		private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context) {} // 0x0000000189C058C4-0x0000000189C05958
		private void OnControlsChanged(object obj) {} // 0x0000000183D4E0B0-0x0000000183D4E0C0
		private void FilterPointerStatesByType() {} // 0x00000001822C0280-0x00000001822C0670
		public override void Process() {} // 0x00000001822C0040-0x00000001822C0280
		public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) => default; // 0x0000000189C04FE4-0x0000000189C0507C
		private void HookActions() {} // 0x00000001837A0620-0x00000001837A0980
		private void UnhookActions() {} // 0x0000000189C061FC-0x0000000189C06210
		private void SetActionCallbacks(bool install) {} // 0x0000000182EBA110-0x0000000182EBA280
		private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install) {} // 0x0000000182EBA280-0x0000000182EBA340
		private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) => default; // 0x0000000189C06210-0x0000000189C0629C
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#multiplayer-uis")]
	public class MultiplayerEventSystem : EventSystem // TypeDefIndex: 44314
	{
		// Fields
		[SerializeField]
		[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
		private GameObject m_PlayerRoot; // 0x50
	
		// Properties
		public GameObject playerRoot { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000189C06B98-0x0000000189C06BBC
	
		// Constructors
		public MultiplayerEventSystem() {} // 0x0000000189C06B4C-0x0000000189C06B98
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189C06A78-0x0000000189C06A98
		protected override void OnDisable() {} // 0x0000000189C06A70-0x0000000189C06A78
		private void InitializePlayerRoot() {} // 0x0000000189C069BC-0x0000000189C06A70
		protected override void Update() {} // 0x0000000189C06A98-0x0000000189C06B4C
	}

	internal struct NavigationModel // TypeDefIndex: 44315
	{
		// Fields
		public Vector2 move; // 0x00
		public int consecutiveMoveCount; // 0x08
		public MoveDirection lastMoveDirection; // 0x0C
		public float lastMoveTime; // 0x10
		public AxisEventData eventData; // 0x18
		public UnityEngine.InputSystem.InputDevice device; // 0x20
	
		// Methods
		public void Reset() {} // 0x0000000184277208-0x0000000184277218
	}

	internal struct SubmitCancelModel // TypeDefIndex: 44316
	{
		// Fields
		public BaseEventData eventData; // 0x00
		public UnityEngine.InputSystem.InputDevice device; // 0x08
	}

	internal struct PointerModel // TypeDefIndex: 44318
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
		public UIPointerType pointerType { get => default; } // 0x00000001822C0670-0x00000001822C06A0 
		public Vector2 screenPosition { get => default; set {} } // 0x0000000183D77590-0x0000000183D775B0 0x00000001831C09B0-0x00000001831C0A00
		public Vector3 worldPosition { get => default; set {} } // 0x0000000183D56B20-0x0000000183D56B40 0x0000000189C09A48-0x0000000189C09AC4
		public Quaternion worldOrientation { get => default; set {} } // 0x0000000183D775D0-0x0000000183D775E0 0x0000000189C099FC-0x0000000189C09A48
		public Vector2 scrollDelta { get => default; set {} } // 0x0000000183D775B0-0x0000000183D775D0 0x00000001822C0740-0x00000001822C0790
		public float pressure { get => default; set {} } // 0x0000000183D599A0-0x0000000183D599B0 0x00000001822C08E0-0x00000001822C0900
		public float azimuthAngle { get => default; set {} } // 0x0000000183D599B0-0x0000000183D599C0 0x00000001822C08C0-0x00000001822C08E0
		public float altitudeAngle { get => default; set {} } // 0x0000000183D59A10-0x0000000183D59A20 0x00000001822C08A0-0x00000001822C08C0
		public float twist { get => default; set {} } // 0x0000000183D58CC0-0x0000000183D58CD0 0x00000001822C0880-0x00000001822C08A0
		public Vector2 radius { get => default; set {} } // 0x0000000183D761F0-0x0000000183D76210 0x00000001822C0900-0x00000001822C0950
	
		// Nested types
		public struct ButtonState // TypeDefIndex: 44317
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
			public bool isPressed { get => default; set {} } // 0x0000000183D51020-0x0000000183D51030 0x0000000182EB6B50-0x0000000182EB6BA0
			public bool ignoreNextClick { get => default; set {} } // 0x0000000183D51D70-0x0000000183D51D80 0x0000000183D74F90-0x0000000183D74FA0
			public float pressTime { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000183D58BE0-0x0000000183D58BF0
			public bool clickedOnSameGameObject { get => default; set {} } // 0x0000000183D51D10-0x0000000183D51D20 0x0000000183D5B370-0x0000000183D5B380
			public bool wasPressedThisFrame { get => default; } // 0x00000001822C2BA0-0x00000001822C2BC0 
			public bool wasReleasedThisFrame { get => default; } // 0x00000001822C2B80-0x00000001822C2BA0 
	
			// Methods
			public void CopyPressStateTo(PointerEventData eventData) {} // 0x00000001822C1A50-0x00000001822C1E00
			public void CopyPressStateFrom(PointerEventData eventData) {} // 0x00000001822C2BC0-0x00000001822C2CB0
			public void OnEndFrame() {} // 0x0000000183D774C0-0x0000000183D774D0
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
		} // 0x0000000182EB5970-0x0000000182EB5AB0
	
		// Methods
		public void OnFrameFinished() {} // 0x00000001822C06C0-0x00000001822C0740
		public void CopyTouchOrPenStateFrom(PointerEventData eventData) {} // 0x00000001822C0790-0x00000001822C0880
	}

	[AddComponentMenu("Event/Tracked Device Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class TrackedDeviceRaycaster : BaseRaycaster // TypeDefIndex: 44321
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
		public override Camera eventCamera { get => default; } // 0x0000000189C0BC00-0x0000000189C0BC74 
		public LayerMask blockingMask { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public bool checkFor3DOcclusion { get => default; set {} } // 0x0000000183D4F4B0-0x0000000183D4F4C0 0x0000000183D4F4E0-0x0000000183D4F4F0
		public bool checkFor2DOcclusion { get => default; set {} } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		public bool ignoreReversedGraphics { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public float maxDistance { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
		private Canvas canvas { get => default; } // 0x0000000189C0BB7C-0x0000000189C0BC00 
	
		// Nested types
		private struct RaycastHitData // TypeDefIndex: 44319
		{
			// Properties
			public Graphic graphic { [IsReadOnly] get; } // 0x00000001820C61B0-0x00000001820C61C0 
			public Vector3 worldHitPosition { [IsReadOnly] get; } // 0x0000000183D5E630-0x0000000183D5E650 
			public Vector2 screenPosition { [IsReadOnly] get; } // 0x0000000183D5C3E0-0x0000000183D5C400 
			public float distance { [IsReadOnly] get; } // 0x0000000183D4F110-0x0000000183D4F120 
	
			// Constructors
			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) : this() {} // 0x0000000189C09AC4-0x0000000189C09B00
		}
	
		// Constructors
		public TrackedDeviceRaycaster() {} // 0x0000000189C0BAF4-0x0000000189C0BB7C
		static TrackedDeviceRaycaster() {} // 0x0000000189C0BA60-0x0000000189C0BAF4
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189C0ABCC-0x0000000189C0AC3C
		protected override void OnDisable() {} // 0x0000000189C0AB04-0x0000000189C0ABCC
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000189C0B5FC-0x0000000189C0B670
		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000189C0AC3C-0x0000000189C0B110
		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results) {} // 0x0000000189C0B670-0x0000000189C0BA60
		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) {
			worldPosition = default;
			distance = default;
			return default;
		} // 0x0000000189C0B110-0x0000000189C0B5FC
	}

	[AddComponentMenu("Input/Virtual Mouse")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/UISupport.html#virtual-mouse-cursor-control")]
	public class VirtualMouseInput : MonoBehaviour // TypeDefIndex: 44323
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
		public RectTransform cursorTransform { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public float cursorSpeed { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
		public CursorMode cursorMode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189C0D07C-0x0000000189C0D160
		public Graphic cursorGraphic { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000189C0D058-0x0000000189C0D07C
		public float scrollSpeed { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x0000000183D50EA0-0x0000000183D50EB0 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000183D59520-0x0000000183D59540 0x0000000189C0D450-0x0000000189C0D508
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000183D699F0-0x0000000183D69A10 0x0000000189C0D218-0x0000000189C0D2C0
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000183D776E0-0x0000000183D77700 0x0000000189C0D368-0x0000000189C0D420
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x0000000183D68300-0x0000000183D68320 0x0000000189C0D2C0-0x0000000189C0D368
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000183D776C0-0x0000000183D776E0 0x0000000189C0D160-0x0000000189C0D218
		public InputActionProperty backButtonAction { get => default; set {} } // 0x0000000183D6C1E0-0x0000000183D6C200 0x0000000189C0CFA0-0x0000000189C0D058
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x0000000183D77700-0x0000000183D77720 0x0000000189C0D420-0x0000000189C0D450
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 44322
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public VirtualMouseInput() {} // 0x0000000189C0CF88-0x0000000189C0CFA0
	
		// Methods
		protected void OnEnable() {} // 0x0000000189C0C424-0x0000000189C0C840
		protected void OnDisable() {} // 0x0000000189C0C18C-0x0000000189C0C424
		private void TryFindCanvas() {} // 0x0000000189C0CB30-0x0000000189C0CB90
		private void TryEnableHardwareCursor() {} // 0x0000000189C0C938-0x0000000189C0CB30
		private void UpdateMotion() {} // 0x0000000189C0CB90-0x0000000189C0CF88
		private void OnButtonActionTriggered(InputAction.CallbackContext context) {} // 0x0000000189C0BFF4-0x0000000189C0C18C
		private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x01FB682D */) {} // 0x00000001888AAFE0-0x00000001888AB04C
		private static void SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x0000000189C0C840-0x0000000189C0C938
		private void OnAfterInputUpdate() {} // 0x0000000189C0BFEC-0x0000000189C0BFF4
	}
}

namespace UnityEngine.InputSystem.Users
{
	public struct InputUser : IEquatable<InputUser> // TypeDefIndex: 44299
	{
		// Fields
		public const uint InvalidId = 0; // Metadata: 0x01FB680A
		private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x00
		private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x08
		private uint m_Id; // 0x00
		private static GlobalState s_GlobalState; // 0x10
	
		// Properties
		public bool valid { get => default; } // 0x0000000189BF3C74-0x0000000189BF3D28 
		public int index { get => default; } // 0x0000000189BF379C-0x0000000189BF38D0 
		public uint id { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public InputUserAccountHandle? platformUserAccountHandle { get => default; } // 0x0000000189BF3AF0-0x0000000189BF3B84 
		public string platformUserAccountName { get => default; } // 0x0000000189BF3BFC-0x0000000189BF3C74 
		public string platformUserAccountId { get => default; } // 0x0000000189BF3B84-0x0000000189BF3BFC 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> pairedDevices { get => default; } // 0x0000000189BF3A0C-0x0000000189BF3AF0 
		public ReadOnlyArray<UnityEngine.InputSystem.InputDevice> lostDevices { get => default; } // 0x0000000189BF3924-0x0000000189BF3A0C 
		public IInputActionCollection actions { get => default; } // 0x0000000189BF34E8-0x0000000189BF3560 
		public InputControlScheme? controlScheme { get => default; } // 0x0000000189BF368C-0x0000000189BF3720 
		public InputControlScheme.MatchResult controlSchemeMatch { get => default; } // 0x0000000189BF35DC-0x0000000189BF368C 
		public bool hasMissingRequiredDevices { get => default; } // 0x0000000189BF3720-0x0000000189BF379C 
		public static ReadOnlyArray<InputUser> all { get => default; } // 0x0000000189BF3560-0x0000000189BF35DC 
		public static int listenForUnpairedDeviceActivity { get => default; set {} } // 0x0000000189BF38D0-0x0000000189BF3924 0x0000000189BF3F94-0x0000000189BF40A0
	
		// Events
		public static event Action<InputUser, InputUserChange, UnityEngine.InputSystem.InputDevice> onChange;
		public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed;
		public static event Func<UnityEngine.InputSystem.InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity;
	
		// Nested types
		public struct ControlSchemeChangeSyntax // TypeDefIndex: 44292
		{
			// Fields
			internal int m_UserIndex; // 0x00
	
			// Methods
			public ControlSchemeChangeSyntax AndPairRemainingDevices() => default; // 0x0000000189C033FC-0x0000000189C0344C
		}
	
		[Flags]
		internal enum UserFlags // TypeDefIndex: 44293
		{
			BindToAllDevices = 1,
			UserAccountSelectionInProgress = 2
		}
	
		private struct UserData // TypeDefIndex: 44294
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
	
		private struct CompareDevicesByUserAccount : IComparer<UnityEngine.InputSystem.InputDevice> // TypeDefIndex: 44295
		{
			// Fields
			public InputUserAccountHandle platformUserAccountHandle; // 0x00
	
			// Methods
			public int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y) => default; // 0x0000000189C032B4-0x0000000189C033FC
			private static InputUserAccountHandle? GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000183D595C0-0x0000000183D595D0
		}
	
		private struct OngoingAccountSelection // TypeDefIndex: 44296
		{
			// Fields
			public UnityEngine.InputSystem.InputDevice device; // 0x00
			public uint userId; // 0x08
		}
	
		private struct GlobalState // TypeDefIndex: 44297
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
	
		// Constructors
		static InputUser() {
			k_InputUserOnChangeMarker = default;
			k_InputCheckForUnpairMarker = default;
			s_GlobalState = default;
		} // 0x0000000189BF31F0-0x0000000189BF3288
	
		// Methods
		public override string ToString() => default; // 0x0000000189BF15F8-0x0000000189BF181C
		public void AssociateActionsWithUser(IInputActionCollection actions) {} // 0x0000000189BEDD8C-0x0000000189BEE05C
		public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) => default; // 0x0000000189BED614-0x0000000189BED6DC
		private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) {
			scheme = default;
			return default;
		} // 0x0000000189BF181C-0x0000000189BF1AC8
		internal void FindControlScheme(string schemeName, out InputControlScheme scheme) {
			scheme = default;
		} // 0x0000000189BEE204-0x0000000189BEE320
		public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) => default; // 0x0000000189BED468-0x0000000189BED614
		private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) {} // 0x0000000189BED080-0x0000000189BED468
		public void UnpairDevice(UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BF1FCC-0x0000000189BF20D0
		public void UnpairDevices() {} // 0x0000000189BF2128-0x0000000189BF233C
		private static void RemoveLostDevicesForUser(int userIndex) {} // 0x0000000189BF0E54-0x0000000189BF1040
		public void UnpairDevicesAndRemoveUser() {} // 0x0000000189BF20D0-0x0000000189BF2128
		public static InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() => default; // 0x0000000189BEE800-0x0000000189BEE870
		public static int GetUnpairedInputDevices(ref InputControlList<UnityEngine.InputSystem.InputDevice> list) => default; // 0x0000000189BEE624-0x0000000189BEE800
		public static InputUser? FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BEE528-0x0000000189BEE624
		public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) => default; // 0x0000000189BEE3E0-0x0000000189BEE528
		public static InputUser CreateUserWithoutPairedDevices() => default; // 0x0000000189BEE05C-0x0000000189BEE0C4
		public static InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, InputUser user = default, InputUserPairingOptions options = InputUserPairingOptions.None /* Metadata: 0x01FB6804 */) => default; // 0x0000000189BF04A4-0x0000000189BF0710
		private static bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, InputUserPairingOptions options) => default; // 0x0000000189BEED04-0x0000000189BEEE68
		public bool Equals(InputUser other) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public override bool Equals(object obj) => default; // 0x0000000189BEE19C-0x0000000189BEE204
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public static bool operator ==(InputUser left, InputUser right) => default; // 0x0000000186505FF4-0x0000000186505FFC
		public static bool operator !=(InputUser left, InputUser right) => default; // 0x000000018950C868-0x000000018950C870
		private static int AddUser() => default; // 0x0000000189BEDC10-0x0000000189BEDD8C
		private static void RemoveUser(int userIndex) {} // 0x0000000189BF1040-0x0000000189BF1374
		private static void Notify(int userIndex, InputUserChange change, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BEEE68-0x0000000189BEF10C
		private static int TryFindUserIndex(uint userId) => default; // 0x0000000189BF1AC8-0x0000000189BF1B74
		private static int TryFindUserIndex(InputUserAccountHandle platformHandle) => default; // 0x0000000189BF1CAC-0x0000000189BF1DBC
		private static int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BF1B74-0x0000000189BF1CAC
		private static void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x01FB6805 */, bool dontUpdateControlScheme = false /* Metadata: 0x01FB6806 */) {} // 0x0000000189BED6DC-0x0000000189BEDC10
		private static void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false /* Metadata: 0x01FB6807 */) {} // 0x0000000189BF0924-0x0000000189BF0E54
		private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false /* Metadata: 0x01FB6808 */) {} // 0x0000000189BF233C-0x0000000189BF2CAC
		private static long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BF2CAC-0x0000000189BF31F0
		private static long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId) {
			platformAccountHandle = default;
			platformAccountName = default;
			platformAccountId = default;
			return default;
		} // 0x0000000189BF0710-0x0000000189BF0924
		private static bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BEEC44-0x0000000189BEED04
		private static void OnActionChange(object obj, InputActionChange change) {} // 0x0000000189BEF10C-0x0000000189BEF1E4
		private static void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change) {} // 0x0000000189BEF1E4-0x0000000189BEF880
		private static int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex = 0 /* Metadata: 0x01FB6809 */) => default; // 0x0000000189BEE320-0x0000000189BEE3E0
		private static void OnEvent(InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BEF880-0x0000000189BF04A4
		internal static ISavedState SaveAndResetState() => default; // 0x0000000189BF13C0-0x0000000189BF15F8
		private static void HookIntoActionChange() {} // 0x0000000189BEE870-0x0000000189BEE9C4
		private static void UnhookFromActionChange() {} // 0x0000000189BF1DBC-0x0000000189BF1E90
		private static void HookIntoDeviceChange() {} // 0x0000000189BEE9C4-0x0000000189BEEB04
		private static void UnhookFromDeviceChange() {} // 0x0000000189BF1E90-0x0000000189BF1F2C
		private static void HookIntoEvents() {} // 0x0000000189BEEB04-0x0000000189BEEC44
		private static void UnhookFromDeviceStateChange() {} // 0x0000000189BF1F2C-0x0000000189BF1FCC
		private static void DisposeAndResetGlobalState() {} // 0x0000000189BEE0C4-0x0000000189BEE19C
		internal static void ResetGlobals() {} // 0x0000000189BF1374-0x0000000189BF13C0
	}

	public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle> // TypeDefIndex: 44300
	{
		// Fields
		private string m_ApiName; // 0x00
		private ulong m_Handle; // 0x08
	
		// Properties
		public string apiName { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public ulong handle { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Constructors
		public InputUserAccountHandle(string apiName, ulong handle) : this() {
			m_ApiName = default;
			m_Handle = default;
		} // 0x0000000189C068FC-0x0000000189C0697C
	
		// Methods
		public override string ToString() => default; // 0x0000000189C06850-0x0000000189C068FC
		public bool Equals(InputUserAccountHandle other) => default; // 0x0000000189C06718-0x0000000189C067A8
		public override bool Equals(object obj) => default; // 0x0000000189C067A8-0x0000000189C06818
		public static bool operator ==(InputUserAccountHandle left, InputUserAccountHandle right) => default; // 0x0000000189C0697C-0x0000000189C0699C
		public static bool operator !=(InputUserAccountHandle left, InputUserAccountHandle right) => default; // 0x0000000189C0699C-0x0000000189C069BC
		public override int GetHashCode() => default; // 0x0000000189C06818-0x0000000189C06850
	}

	public enum InputUserChange // TypeDefIndex: 44301
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
	public enum InputUserPairingOptions // TypeDefIndex: 44302
	{
		None = 0,
		ForcePlatformUserAccountSelection = 1,
		ForceNoPlatformUserAccountSelection = 2,
		UnpairCurrentDevicesFromUser = 8
	}

	[Serializable]
	internal class InputUserSettings // TypeDefIndex: 44303
	{
		// Fields
		[SerializeField]
		private string m_CustomBindings; // 0x38
	
		// Properties
		public string customBindings { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool invertMouseX { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool invertMouseY { get; set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public float? mouseSmoothing { get; set; } // 0x0000000183D75DC0-0x0000000183D75DD0 0x0000000183D77580-0x0000000183D77590
		public float? mouseSensitivity { get; set; } // 0x0000000183D518E0-0x0000000183D518F0 0x0000000183D71680-0x0000000183D71690
		public bool invertStickX { get; set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
		public bool invertStickY { get; set; } // 0x0000000183D4F4C0-0x0000000183D4F4D0 0x0000000183D4F4F0-0x0000000183D4F500
		public bool swapSticks { get; set; } // 0x0000000183D58EE0-0x0000000183D58EF0 0x0000000183D58EF0-0x0000000183D58F00
		public bool swapBumpers { get; set; } // 0x0000000183D73A60-0x0000000183D73A70 0x0000000183D73A70-0x0000000183D73A80
		public bool swapTriggers { get; set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public bool swapDpadAndLeftStick { get; set; } // 0x0000000183D4F2C0-0x0000000183D4F2D0 0x0000000183D4F2D0-0x0000000183D4F2E0
		public float vibrationStrength { get; set; } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
	
		// Constructors
		public InputUserSettings() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Apply(IInputActionCollection actions) {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace UnityEngine.InputSystem.Utilities
{
	public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IDisposable // TypeDefIndex: 44593
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
		public InputEventBuffer buffer { get => default; } // 0x0000000183D76D30-0x0000000183D76D50 
		public int count { get => default; } // 0x0000000183D4F050-0x0000000183D4F060 
	
		// Nested types
		public struct ActionEventPtr // TypeDefIndex: 44591
		{
			// Fields
			internal InputActionState m_State; // 0x00
			internal unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr; // 0x08
	
			// Properties
			public InputAction action { get => default; } // 0x0000000189BBBB98-0x0000000189BBBBC4 
			public InputActionPhase phase { get => default; } // 0x0000000183D76C70-0x0000000183D76C80 
			public InputControl control { get => default; } // 0x0000000189BBBBC4-0x0000000189BBBBFC 
			public IInputInteraction interaction { get => default; } // 0x0000000189BBBC1C-0x0000000189BBBC68 
			public double time { get => default; } // 0x0000000189BBBC68-0x0000000189BBBC88 
			public double startTime { get => default; } // 0x0000000183D76C80-0x0000000183D76C90 
			public double duration { get => default; } // 0x0000000189BBBBFC-0x0000000189BBBC1C 
			public int valueSizeInBytes { get => default; } // 0x0000000183D76C90-0x0000000183D76CA0 
	
			// Methods
			public object ReadValueAsObject() => default; // 0x0000000189BBB5E4-0x0000000189BBB800
			public unsafe void ReadValue(void* buffer, int bufferSize) {} // 0x0000000189BBB800-0x0000000189BBB8FC
			public TValue ReadValue<TValue>()
				where TValue : struct => default;
			public override string ToString() => default; // 0x0000000189BBB8FC-0x0000000189BBBB98
		}
	
		private struct Enumerator : IEnumerator<ActionEventPtr> // TypeDefIndex: 44592
		{
			// Fields
			private readonly InputActionTrace m_Trace; // 0x00
			private readonly unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer; // 0x08
			private readonly int m_EventCount; // 0x10
			private unsafe UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent; // 0x18
			private int m_CurrentIndex; // 0x20
	
			// Properties
			public ActionEventPtr Current { get => default; } // 0x0000000189BBD404-0x0000000189BBD484 
			object IEnumerator.Current { get => default; } // 0x0000000189BBD360-0x0000000189BBD3B8 
	
			// Constructors
			public unsafe Enumerator(InputActionTrace trace) : this() {
				m_Trace = default;
				m_Buffer = default;
				m_EventCount = default;
				m_CurrentEvent = default;
				m_CurrentIndex = default;
			} // 0x0000000189BBD3B8-0x0000000189BBD404
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189BBD310-0x0000000189BBD360
			public void Reset() {} // 0x0000000183D76CE0-0x0000000183D76CF0
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public InputActionTrace() {} // 0x000000018350B670-0x000000018350B680
		public InputActionTrace(InputAction action) {} // 0x0000000189BBEA6C-0x0000000189BBEAD8
		public InputActionTrace(InputActionMap actionMap) {} // 0x0000000189BBEAD8-0x0000000189BBEB44
	
		// Methods
		public void SubscribeToAll() {} // 0x0000000189BBE1E4-0x0000000189BBE29C
		public void UnsubscribeFromAll() {} // 0x0000000189BBE79C-0x0000000189BBE854
		public void SubscribeTo(InputAction action) {} // 0x0000000189BBE3C4-0x0000000189BBE514
		public void SubscribeTo(InputActionMap actionMap) {} // 0x0000000189BBE29C-0x0000000189BBE3C4
		public void UnsubscribeFrom(InputAction action) {} // 0x0000000189BBE854-0x0000000189BBE974
		public void UnsubscribeFrom(InputActionMap actionMap) {} // 0x0000000189BBE974-0x0000000189BBEA6C
		public void RecordAction(InputAction.CallbackContext context) {} // 0x0000000189BBE058-0x0000000189BBE1E4
		public void Clear() {} // 0x0000000189BBDA10-0x0000000189BBDA5C
		~InputActionTrace() {} // 0x0000000189BBDC50-0x0000000189BBDCC0
		public override string ToString() => default; // 0x0000000189BBE51C-0x0000000189BBE740
		public void Dispose() {} // 0x0000000189BBDC30-0x0000000189BBDC50
		private void DisposeInternal() {} // 0x0000000189BBDB2C-0x0000000189BBDC30
		public IEnumerator<ActionEventPtr> GetEnumerator() => default; // 0x0000000189BBDCC0-0x0000000189BBDD40
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BBE514-0x0000000189BBE51C
		private void HookOnActionChange() {} // 0x0000000189BBDD40-0x0000000189BBDE00
		private void UnhookOnActionChange() {} // 0x0000000189BBE740-0x0000000189BBE79C
		private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) {} // 0x0000000189BBDE00-0x0000000189BBE058
		private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) {} // 0x0000000189BBDA5C-0x0000000189BBDB2C
	}

	internal static class ArrayHelpers // TypeDefIndex: 44597
	{
		// Methods
		public static void EnsureCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x01FB6BBC */) {}
		public static void DuplicateWithCapacity<TValue>(ref ref TValue[] array, int count, int capacity, int capacityIncrement = 10 /* Metadata: 0x01FB6BBD */) {}
		public static bool Contains<TValue>(TValue[] array, TValue value) => default;
		public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647 /* Metadata: 0x01FB6BBE */) => default;
		public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x01FB6BBF */, int count = -1 /* Metadata: 0x01FB6BC0 */) => default;
		public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator)
			where TValue : struct {}
		public static int Append<TValue>(ref ref TValue[] array, TValue value) => default;
		public static int Append<TValue>(ref ref TValue[] array, IEnumerable<TValue> values) => default;
		public static int AppendToImmutable<TValue>(ref ref TValue[] array, TValue[] values) => default;
		public static int AppendWithCapacity<TValue>(ref ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x01FB6BC6 */) => default;
		public static int AppendListWithCapacity<TValue, TValues>(ref ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10 /* Metadata: 0x01FB6BC7 */)
			where TValues : IReadOnlyList<TValue> => default;
		public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10 /* Metadata: 0x01FB6BC8 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6BC9 */)
			where TValue : struct => default;
		public static void InsertAt<TValue>(ref ref TValue[] array, int index, TValue value) {}
		public static void InsertAtWithCapacity<TValue>(ref ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10 /* Metadata: 0x01FB6BCA */) {}
		public static void PutAtIfNotSet<TValue>(ref ref TValue[] array, int index, Func<TValue> valueFn) {}
		public static int GrowBy<TValue>(ref ref TValue[] array, int count) => default;
		public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6BCB */)
			where TValue : struct => default;
		public static int GrowWithCapacity<TValue>(ref ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x01FB6BCC */) => default;
		public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10 /* Metadata: 0x01FB6BCD */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB6BCE */)
			where TValue : struct => default;
		public static TValue[] Join<TValue>(TValue value, params TValue[] values) => default;
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second)
			where TValue : IEquatable<TValue> => default;
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer) => default;
		public static void EraseAt<TValue>(ref ref TValue[] array, int index) {}
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
	
		// Extension methods
		public static int LengthSafe<TValue>(this TValue[] array) => default;
		public static void Clear<TValue>(this TValue[] array) {}
		public static void Clear<TValue>(this TValue[] array, int count) {}
		public static void Clear<TValue>(this TValue[] array, ref int count) {}
		public static bool ContainsReference<TValue>(this TValue[] array, TValue value)
			where TValue : class => default;
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class => default;
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int startIndex, int count, TSecond value)
			where TFirst : TSecond
			where TSecond : class => default;
		public static bool HaveDuplicateReferences<TFirst>(this TFirst[] first, int index, int count) => default;
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate) => default;
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate, int startIndex = 0 /* Metadata: 0x01FB6BC1 */, int count = -1 /* Metadata: 0x01FB6BC2 */) => default;
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int count = -1 /* Metadata: 0x01FB6BC3 */)
			where TFirst : TSecond
			where TSecond : class => default;
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int startIndex, int count)
			where TFirst : TSecond
			where TSecond : class => default;
		public static int IndexOfValue<TValue>(this TValue[] array, TValue value, int startIndex = 0 /* Metadata: 0x01FB6BC4 */, int count = -1 /* Metadata: 0x01FB6BC5 */)
			where TValue : struct, IEquatable<TValue> => default;
		public static void EraseAtWithCapacity<TValue>(this TValue[] array, ref int count, int index) {}
		public static void SwapElements<TValue>(this TValue[] array, int index1, int index2) {}
		public static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2)
			where TValue : struct {}
	}

	internal struct CallbackArray<TDelegate> // TypeDefIndex: 44598
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

	public struct Vector2MagnitudeComparer : IComparer<Vector2> // TypeDefIndex: 44599
	{
		// Methods
		public int Compare(Vector2 x, Vector2 y) => default; // 0x0000000189BC804C-0x0000000189BC80A0
	}

	public struct Vector3MagnitudeComparer : IComparer<Vector3> // TypeDefIndex: 44600
	{
		// Methods
		public int Compare(Vector3 x, Vector3 y) => default; // 0x0000000189BC85B0-0x0000000189BC8664
	}

	internal static class CSharpCodeHelpers // TypeDefIndex: 44601
	{
		// Methods
		public static bool IsProperIdentifier(string name) => default; // 0x0000000189BBC330-0x0000000189BBC3E4
		public static bool IsEmptyOrProperIdentifier(string name) => default; // 0x0000000189BBC25C-0x0000000189BBC27C
		public static bool IsEmptyOrProperNamespaceName(string name) => default; // 0x0000000189BBC27C-0x0000000189BBC330
		public static string MakeIdentifier(string name, string suffix = "" /* Metadata: 0x01FB6BCF */) => default; // 0x0000000189BBC3E4-0x0000000189BBC5C8
		public static string MakeTypeName(string name, string suffix = "" /* Metadata: 0x01FB6BD0 */) => default; // 0x0000000189BBC5C8-0x0000000189BBC6A4
	}

	internal static class DelegateHelpers // TypeDefIndex: 44602
	{
		// Methods
		public static void InvokeCallbacksSafe(ref CallbackArray<Action> callbacks, ProfilerMarker marker, string callbackName, object context = null) {} // 0x00000001824B1A10-0x00000001824B1C30
		public static void InvokeCallbacksSafe<TValue>(ref CallbackArray<Action<TValue>> callbacks, TValue argument, string callbackName, object context = null) {}
		public static void InvokeCallbacksSafe<TValue1, TValue2>(ref CallbackArray<Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context = null) {}
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref CallbackArray<Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null) => default;
		public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref CallbackArray<Func<TValue, Action>> callbacks, TValue argument, string callbackName, object context = null) {}
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref CallbackArray<Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context = null) => default;
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class DisplayStringFormatAttribute : Attribute // TypeDefIndex: 44603
	{
		// Properties
		public string formatString { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public DisplayStringFormatAttribute() {} // Dummy constructor
		public DisplayStringFormatAttribute(string formatString) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	internal static class ExceptionHelpers // TypeDefIndex: 44604
	{
		// Extension methods
		public static bool IsExceptionIndicatingBugInCode(this Exception exception) => default; // 0x0000000189BBD484-0x0000000189BBD508
	}

	public struct FourCC : IEquatable<FourCC> // TypeDefIndex: 44605
	{
		// Fields
		private int m_Code; // 0x00
	
		// Constructors
		public FourCC(int code) {
			m_Code = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
		public FourCC(char a, char b = ' ' /* Metadata: 0x01FB6BD1 */, char c = ' ' /* Metadata: 0x01FB6BD3 */, char d = ' ' /* Metadata: 0x01FB6BD5 */) {
			m_Code = default;
		} // 0x0000000183D76CF0-0x0000000183D76D20
		public FourCC(string str) {
			m_Code = default;
		} // 0x0000000189BBD6E0-0x0000000189BBD87C
	
		// Methods
		public static implicit operator int(FourCC fourCC) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static implicit operator FourCC(int i) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public override string ToString() => default; // 0x0000000189BBD564-0x0000000189BBD6E0
		public bool Equals(FourCC other) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public override bool Equals(object obj) => default; // 0x0000000189BBD508-0x0000000189BBD564
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public static bool operator ==(FourCC left, FourCC right) => default; // 0x0000000186505FF4-0x0000000186505FFC
		public static bool operator !=(FourCC left, FourCC right) => default; // 0x000000018950C868-0x000000018950C870
		public static FourCC FromInt32(int i) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static int ToInt32(FourCC fourCC) => default; // 0x0000000183D517B0-0x0000000183D517C0
	}

	internal struct InlinedArray<TValue> : IEnumerable<TValue> // TypeDefIndex: 44607
	{
		// Fields
		public int length;
		public TValue firstValue;
		public TValue[] additionalValues;
	
		// Properties
		public int Capacity { get => default; }
		public TValue this[int index] { get => default; set {} }
	
		// Nested types
		private struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 44606
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
		public InlinedArray(TValue firstValue, params TValue[] additionalValues) : this() {
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
		public int AppendWithCapacity(TValue value, int capacityIncrement = 10 /* Metadata: 0x01FB6BD7 */) => default;
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

	internal static class InputArrayExtensions // TypeDefIndex: 44608
	{
		// Extension methods
		public static int IndexOfReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class => default;
		public static bool Contains<TValue>(this InlinedArray<TValue> array, TValue value) => default;
		public static bool ContainsReference<TValue>(this InlinedArray<TValue> array, TValue value)
			where TValue : class => default;
	}

	public struct InternedString : IEquatable<InternedString>, IComparable<InternedString> // TypeDefIndex: 44609
	{
		// Fields
		private readonly string m_StringOriginalCase; // 0x00
		private readonly string m_StringLowerCase; // 0x08
	
		// Properties
		public int length { get => default; } // 0x0000000189BC437C-0x0000000189BC438C 
	
		// Constructors
		public InternedString(string text) : this() {
			m_StringOriginalCase = default;
			m_StringLowerCase = default;
		} // 0x00000001822FD4F0-0x00000001822FD5E0
	
		// Methods
		public bool IsEmpty() => default; // 0x00000001822FAFD0-0x00000001822FAFE0
		public string ToLower() => default; // 0x0000000183D50DE0-0x0000000183D50DF0
		public override bool Equals(object obj) => default; // 0x0000000189BC42B4-0x0000000189BC437C
		public bool Equals(InternedString other) => default; // 0x0000000182361480-0x0000000182361490
		public int CompareTo(InternedString other) => default; // 0x0000000189BC429C-0x0000000189BC42B4
		public override int GetHashCode() => default; // 0x0000000182F1BB30-0x0000000182F1BB50
		public override string ToString() => default; // 0x0000000182360BD0-0x0000000182360C20
		public static bool operator ==(InternedString a, InternedString b) => default; // 0x0000000182361480-0x0000000182361490
		public static bool operator !=(InternedString a, InternedString b) => default; // 0x0000000182361470-0x0000000182361480
		public static bool operator ==(InternedString a, string b) => default; // 0x0000000189BC4408-0x0000000189BC4484
		public static bool operator !=(InternedString a, string b) => default; // 0x0000000189BC4524-0x0000000189BC45A0
		public static bool operator ==(string a, InternedString b) => default; // 0x0000000189BC438C-0x0000000189BC4408
		public static bool operator !=(string a, InternedString b) => default; // 0x0000000189BC44A8-0x0000000189BC4524
		public static bool operator <(InternedString left, InternedString right) => default; // 0x0000000189BC45A0-0x0000000189BC45C4
		public static bool operator >(InternedString left, InternedString right) => default; // 0x0000000189BC4484-0x0000000189BC44A8
		public static implicit operator string(InternedString str) => default; // 0x000000018426F770-0x000000018426F780
	}

	internal struct JsonParser // TypeDefIndex: 44614
	{
		// Fields
		private readonly string m_Text; // 0x00
		private readonly int m_Length; // 0x08
		private int m_Position; // 0x0C
		private bool m_MatchAnyElementInArray; // 0x10
		private bool m_DryRun; // 0x11
	
		// Properties
		public bool isAtEnd { get => default; } // 0x0000000189BC4ECC-0x0000000189BC4ED8 
	
		// Nested types
		public enum JsonValueType // TypeDefIndex: 44610
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
	
		public struct JsonString : IEquatable<JsonString> // TypeDefIndex: 44611
		{
			// Fields
			public Substring text; // 0x00
			public bool hasEscapes; // 0x10
	
			// Methods
			public override string ToString() => default; // 0x0000000189BC5130-0x0000000189BC51FC
			public bool Equals(JsonString other) => default; // 0x0000000189BC4ED8-0x0000000189BC5050
			public override bool Equals(object obj) => default; // 0x0000000189BC5050-0x0000000189BC50C8
			public override int GetHashCode() => default; // 0x0000000189BC50C8-0x0000000189BC5130
			public static bool operator ==(JsonString left, JsonString right) => default; // 0x0000000189BC51FC-0x0000000189BC5228
			public static bool operator !=(JsonString left, JsonString right) => default; // 0x0000000189BC5264-0x0000000189BC5290
			public static implicit operator JsonString(string str) => default; // 0x0000000189BC5228-0x0000000189BC5264
		}
	
		public struct JsonValue : IEquatable<JsonValue> // TypeDefIndex: 44613
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
	
			// Methods
			public bool ToBoolean() => default; // 0x0000000189BC5448-0x0000000189BC54D4
			public long ToInteger() => default; // 0x0000000189BC5570-0x0000000189BC55FC
			public double ToDouble() => default; // 0x0000000189BC54D4-0x0000000189BC5570
			public override string ToString() => default; // 0x0000000189BC55FC-0x0000000189BC5A10
			public static implicit operator JsonValue(bool val) => default; // 0x0000000183D76D60-0x0000000183D76D90
			public static implicit operator JsonValue(long val) => default; // 0x0000000183D76D90-0x0000000183D76DC0
			public static implicit operator JsonValue(double val) => default; // 0x0000000183D76DC0-0x0000000183D76DF0
			public static implicit operator JsonValue(string str) => default; // 0x0000000189BC5A54-0x0000000189BC5AD4
			public static implicit operator JsonValue(JsonString str) => default; // 0x0000000189BC5B18-0x0000000189BC5B64
			public static implicit operator JsonValue(List<JsonValue> array) => default; // 0x0000000189BC5A10-0x0000000189BC5A54
			public static implicit operator JsonValue(Dictionary<string, JsonValue> obj) => default; // 0x0000000189BC5B64-0x0000000189BC5BA8
			public static implicit operator JsonValue(Enum val) => default; // 0x0000000189BC5AD4-0x0000000189BC5B18
			public bool Equals(JsonValue other) => default; // 0x0000000183267570-0x0000000183267640
			private static bool Equals(object obj, JsonValue value) => default; // 0x0000000183267640-0x0000000183267800
			public override bool Equals(object obj) => default; // 0x0000000189BC5290-0x0000000189BC5328
			public override int GetHashCode() => default; // 0x0000000189BC5328-0x0000000189BC5448
			public static bool operator ==(JsonValue left, JsonValue right) => default; // 0x000000018426F98C-0x000000018426F9D0
			public static bool operator !=(JsonValue left, JsonValue right) => default; // 0x0000000189BC5BA8-0x0000000189BC5BEC
		}
	
		// Constructors
		public JsonParser(string json) : this() {
			m_Text = default;
			m_Length = default;
			m_Position = default;
			m_MatchAnyElementInArray = default;
			m_DryRun = default;
		} // 0x0000000182360B90-0x0000000182360BD0
	
		// Methods
		public void Reset() {} // 0x0000000183D76D50-0x0000000183D76D60
		public override string ToString() => default; // 0x0000000189BC4E00-0x0000000189BC4ECC
		public bool NavigateToProperty(string path) => default; // 0x0000000182360870-0x0000000182360A30
		public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) => default; // 0x00000001823603B0-0x00000001823604E0
		public bool ParseToken(char token) => default; // 0x0000000182360A30-0x0000000182360AA0
		public bool ParseValue() => default; // 0x0000000189BC4D2C-0x0000000189BC4D60
		public bool ParseValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x00000001823604E0-0x0000000182360580
		public bool ParseStringValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000189BC4B98-0x0000000189BC4D2C
		public bool ParseArrayValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000189BC45C4-0x0000000189BC4840
		public bool ParseObjectValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000189BC4990-0x0000000189BC4B98
		public bool ParseNumber(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000182360580-0x0000000182360870
		public bool ParseBooleanValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000189BC4840-0x0000000189BC4938
		public bool ParseNullValue(out JsonValue result) {
			result = default;
			return default;
		} // 0x0000000189BC4938-0x0000000189BC4990
		public bool SkipToValue() => default; // 0x0000000182360AA0-0x0000000182360AF0
		private bool SkipString(string text) => default; // 0x0000000189BC4D60-0x0000000189BC4E00
		private void SkipWhitespace() {} // 0x0000000182360AF0-0x0000000182360B90
	}

	internal static class MemoryHelpers // TypeDefIndex: 44616
	{
		// Nested types
		public struct BitRegion // TypeDefIndex: 44615
		{
			// Fields
			public uint bitOffset; // 0x00
			public uint sizeInBits; // 0x04
	
			// Properties
			public bool isEmpty { get => default; } // 0x00000001822BB3E0-0x00000001822BB3F0 
	
			// Constructors
			public BitRegion(uint bitOffset, uint sizeInBits) : this() {
				this.bitOffset = default;
				this.sizeInBits = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
			public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits) : this() {
				this.bitOffset = default;
				this.sizeInBits = default;
			} // 0x0000000183D76E30-0x0000000183D76E40
	
			// Methods
			public BitRegion Overlap(BitRegion other) => default; // 0x00000001822BB340-0x00000001822BB3E0
		}
	
		// Methods
		public static unsafe bool Compare(void* ptr1, void* ptr2, BitRegion region) => default; // 0x00000001822BB410-0x00000001822BB490
		public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits) => default; // 0x0000000189BC8DFC-0x0000000189BC8E14
		public static unsafe void WriteSingleBit(void* ptr, uint bitOffset, bool value) {} // 0x000000018389D740-0x000000018389D770
		public static unsafe bool ReadSingleBit(void* ptr, uint bitOffset) => default; // 0x000000018426F5E0-0x000000018426F604
		public static unsafe void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount) {} // 0x0000000189BC8E14-0x0000000189BC8F04
		public static unsafe bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null) => default; // 0x00000001822BB5B0-0x00000001822BB720
		public static unsafe void MemSet(void* destination, int numBytes, byte value) {} // 0x0000000189BC8FFC-0x0000000189BC90B8
		public static unsafe void MemCpyMasked(void* destination, void* source, int numBytes, void* mask) {} // 0x0000000189BC8F04-0x0000000189BC8FFC
		public static unsafe uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x0000000189BC9118-0x0000000189BC92F0
		public static unsafe void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value) {} // 0x0000000189BC9374-0x0000000189BC957C
		public static unsafe int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x0000000189BC92F0-0x0000000189BC92F8
		public static unsafe void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) {} // 0x0000000189BC9324-0x0000000189BC9334
		public static unsafe int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x0000000189BC90B8-0x0000000189BC90E4
		public static unsafe void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) {} // 0x0000000189BC92F8-0x0000000189BC9324
		public static unsafe float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount) => default; // 0x0000000189BC90E4-0x0000000189BC9118
		public static unsafe void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value) {} // 0x0000000189BC9334-0x0000000189BC9374
		public static unsafe void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) {} // 0x00000001822FC520-0x00000001822FC650
		public static void Swap<TValue>(ref ref TValue a, ref ref TValue b) {}
		public static uint AlignNatural(uint offset, uint sizeInBytes) => default; // 0x0000000189BC8DA8-0x0000000189BC8DFC
	}

	internal static class MiscHelpers // TypeDefIndex: 44618
	{
		// Extension methods
		public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key) => default;
		[IteratorStateMachine(typeof(_EveryNth_d__1<TValue>))]
		public static IEnumerable<TValue> EveryNth<TValue>(this IEnumerable<TValue> enumerable, int n, int start = 0 /* Metadata: 0x01FB6BE0 */) => default;
		public static int IndexOf<TValue>(this IEnumerable<TValue> enumerable, TValue value) => default;
	}

	public struct NameAndParameters // TypeDefIndex: 44620
	{
		// Properties
		public string name { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public ReadOnlyArray<NamedValue> parameters { [IsReadOnly] get; set; } // 0x00000001820C61C0-0x00000001820C61D0 0x0000000189BC99EC-0x0000000189BC99FC
	
		// Methods
		public override string ToString() => default; // 0x0000000189BC97B0-0x0000000189BC99EC
		public static IEnumerable<NameAndParameters> ParseMultiple(string text) => default; // 0x0000000189BC957C-0x0000000189BC95D4
		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list) => default; // 0x0000000189BC95D4-0x0000000189BC9728
		internal static string ParseName(string text) => default; // 0x0000000189BC9728-0x0000000189BC97B0
		public static NameAndParameters Parse(string text) => default; // 0x000000018235E020-0x000000018235E070
		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false /* Metadata: 0x01FB6BE1 */) => default; // 0x000000018235E120-0x000000018235E310
	}

	public struct NamedValue : IEquatable<NamedValue> // TypeDefIndex: 44621
	{
		// Fields
		public const string Separator = ","; // Metadata: 0x01FB6BE2
	
		// Properties
		public string name { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public PrimitiveValue value { [IsReadOnly] get; set; } // 0x00000001820C61C0-0x00000001820C61D0 0x0000000183D707A0-0x0000000183D707B0
		public TypeCode type { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Methods
		public NamedValue ConvertTo(TypeCode type) => default; // 0x0000000189BC9C5C-0x0000000189BC9CB4
		public static NamedValue From<TValue>(string name, TValue value)
			where TValue : struct => default;
		public override string ToString() => default; // 0x0000000189BCA20C-0x0000000189BCA280
		public bool Equals(NamedValue other) => default; // 0x0000000189BC9CB4-0x0000000189BC9D10
		public override bool Equals(object obj) => default; // 0x0000000189BC9D10-0x0000000189BC9D88
		public override int GetHashCode() => default; // 0x0000000189BC9D88-0x0000000189BC9DD4
		public static bool operator ==(NamedValue left, NamedValue right) => default; // 0x0000000189BCA280-0x0000000189BCA2AC
		public static bool operator !=(NamedValue left, NamedValue right) => default; // 0x0000000189BCA2AC-0x0000000189BCA2D8
		public static NamedValue[] ParseMultiple(string parameterString) => default; // 0x0000000189BC9DD4-0x0000000189BC9F38
		public static NamedValue Parse(string str) => default; // 0x0000000189BCA1D0-0x0000000189BCA20C
		private static NamedValue ParseParameter(string parameterString, ref int index) => default; // 0x0000000189BC9F38-0x0000000189BCA1D0
		public void ApplyToObject(object instance) {} // 0x0000000189BC99FC-0x0000000189BC9C5C
		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters)
			where TParameterList : IEnumerable<NamedValue> {}
	}

	internal static class NumberHelpers // TypeDefIndex: 44622
	{
		// Methods
		public static bool Approximately(double a, double b) => default; // 0x0000000189BCA324-0x0000000189BCA3C4
		public static float IntToNormalizedFloat(int value, int minValue, int maxValue) => default; // 0x0000000189BCA3C4-0x0000000189BCA40C
		public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) => default; // 0x0000000189BCA40C-0x0000000189BCA454
		public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue) => default; // 0x0000000189BCA4E4-0x0000000189BCA534
		public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue) => default; // 0x0000000189BCA454-0x0000000189BCA4A4
		public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize) => default; // 0x0000000189BCA4A4-0x0000000189BCA4E4
	
		// Extension methods
		public static int AlignToMultipleOf(this int number, int alignment) => default; // 0x0000000189BCA2D8-0x0000000189BCA2F0
		public static long AlignToMultipleOf(this long number, long alignment) => default; // 0x0000000189BCA308-0x0000000189BCA324
		public static uint AlignToMultipleOf(this uint number, uint alignment) => default; // 0x0000000189BCA2F0-0x0000000189BCA308
	}

	internal class ForDeviceEventObservable : IObservable<InputEventPtr> // TypeDefIndex: 44624
	{
		// Fields
		private IObservable<InputEventPtr> m_Source; // 0x10
		private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
		private System.Type m_DeviceType; // 0x20
	
		// Nested types
		private class ForDevice : IObserver<InputEventPtr> // TypeDefIndex: 44623
		{
			// Fields
			private IObserver<InputEventPtr> m_Observer; // 0x10
			private UnityEngine.InputSystem.InputDevice m_Device; // 0x18
			private System.Type m_DeviceType; // 0x20
	
			// Constructors
			public ForDevice() {} // Dummy constructor
			public ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, IObserver<InputEventPtr> observer) {} // 0x0000000189BC8D70-0x0000000189BC8DA8
	
			// Methods
			public void OnCompleted() {} // 0x000000018350B670-0x000000018350B680
			public void OnError(Exception error) {} // 0x0000000189BC8C30-0x0000000189BC8C7C
			public void OnNext(InputEventPtr value) {} // 0x0000000189BC8C7C-0x0000000189BC8D70
		}
	
		// Constructors
		public ForDeviceEventObservable() {} // Dummy constructor
		public ForDeviceEventObservable(IObservable<InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device) {} // 0x0000000189BC8BF8-0x0000000189BC8C30
	
		// Methods
		public IDisposable Subscribe(IObserver<InputEventPtr> observer) => default; // 0x0000000189BC8B40-0x0000000189BC8BF8
	}

	public static class Observable // TypeDefIndex: 44626
	{
		// Extension methods
		public static IObservable<TValue> Where<TValue>(this IObservable<TValue> source, Func<TValue, bool> predicate) => default;
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> filter) => default;
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter) => default;
		public static IObservable<TValue> Take<TValue>(this IObservable<TValue> source, int count) => default;
		public static IObservable<InputEventPtr> ForDevice(this IObservable<InputEventPtr> source, UnityEngine.InputSystem.InputDevice device) => default; // 0x0000000189BCA534-0x0000000189BCA5FC
		public static IObservable<InputEventPtr> ForDevice<TDevice>(this IObservable<InputEventPtr> source)
			where TDevice : UnityEngine.InputSystem.InputDevice => default;
		public static IDisposable CallOnce<TValue>(this IObservable<TValue> source, Action<TValue> action) => default;
		public static IDisposable Call<TValue>(this IObservable<TValue> source, Action<TValue> action) => default;
	}

	internal class Observer<TValue> : IObserver<TValue> // TypeDefIndex: 44627
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

	internal class SelectManyObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 44629
	{
		// Fields
		private readonly IObservable<TSource> m_Source;
		private readonly Func<TSource, IEnumerable<TResult>> m_Filter;
	
		// Nested types
		private class Select : IObserver<TSource> // TypeDefIndex: 44628
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

	internal class TakeNObservable<TValue> : IObservable<TValue> // TypeDefIndex: 44631
	{
		// Fields
		private IObservable<TValue> m_Source;
		private int m_Count;
	
		// Nested types
		private class Take : IObserver<TValue> // TypeDefIndex: 44630
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

	internal class WhereObservable<TValue> : IObservable<TValue> // TypeDefIndex: 44633
	{
		// Fields
		private readonly IObservable<TValue> m_Source;
		private readonly Func<TValue, bool> m_Predicate;
	
		// Nested types
		private class Where : IObserver<TValue> // TypeDefIndex: 44632
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

	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue> // TypeDefIndex: 44635
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
		private class Enumerator : IEnumerator<TValue> // TypeDefIndex: 44634
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

	internal struct PredictiveParser // TypeDefIndex: 44636
	{
		// Fields
		private int m_Position; // 0x00
	
		// Methods
		public void ExpectSingleChar(ReadOnlySpan<char> str, char c) {} // 0x000000018237B100-0x000000018237B140
		public int ExpectInt(ReadOnlySpan<char> str) => default; // 0x000000018237B2C0-0x000000018237B360
		public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str) => default; // 0x000000018237B360-0x000000018237B4A0
		public bool AcceptSingleChar(ReadOnlySpan<char> str, char c) => default; // 0x000000018237B290-0x000000018237B2C0
		public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output) {
			output = default;
			return default;
		} // 0x00000001831EC7F0-0x00000001831EC910
		public void AcceptInt(ReadOnlySpan<char> str) {} // 0x0000000182EE1CC0-0x0000000182EE1D10
	}

	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible // TypeDefIndex: 44637
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
		internal unsafe byte* valuePtr { get => default; } // 0x0000000183D77110-0x0000000183D77120 
		public TypeCode type { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public bool isEmpty { get => default; } // 0x00000001822FBAA0-0x00000001822FBAB0 
	
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
		} // 0x0000000183D77070-0x0000000183D77080
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
		} // 0x0000000183D76FD0-0x0000000183D76FF0
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
		} // 0x0000000183D770A0-0x0000000183D770B0
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
		} // 0x0000000183D76FC0-0x0000000183D76FD0
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
		} // 0x0000000183D77050-0x0000000183D77070
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
		} // 0x0000000183D770F0-0x0000000183D77110
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
		} // 0x0000000183D770D0-0x0000000183D770F0
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
		} // 0x0000000183D770B0-0x0000000183D770D0
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
		} // 0x0000000183D77030-0x0000000183D77050
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
		} // 0x0000000183D77010-0x0000000183D77030
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
		} // 0x0000000183D76FF0-0x0000000183D77010
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
		} // 0x0000000183D77080-0x0000000183D770A0
	
		// Methods
		public PrimitiveValue ConvertTo(TypeCode type) => default; // 0x0000000189BCAAC4-0x0000000189BCAD40
		public bool Equals(PrimitiveValue other) => default; // 0x0000000189BCAD40-0x0000000189BCAD6C
		public override bool Equals(object obj) => default; // 0x0000000189BCAD6C-0x0000000189BCAF1C
		public static bool operator ==(PrimitiveValue left, PrimitiveValue right) => default; // 0x0000000189BCBF50-0x0000000189BCBF70
		public static bool operator !=(PrimitiveValue left, PrimitiveValue right) => default; // 0x0000000189BCBF70-0x0000000189BCBF90
		public override int GetHashCode() => default; // 0x0000000189BCB6DC-0x0000000189BCB6FC
		public override string ToString() => default; // 0x0000000189BCBAF4-0x0000000189BCBE60
		public static PrimitiveValue FromString(string value) => default; // 0x0000000189BCB39C-0x0000000189BCB6DC
		public TypeCode GetTypeCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public bool ToBoolean(IFormatProvider provider = null) => default; // 0x0000000189BCB6FC-0x0000000189BCB790
		public byte ToByte(IFormatProvider provider = null) => default; // 0x0000000189BCB790-0x0000000189BCB798
		public char ToChar(IFormatProvider provider = null) => default; // 0x0000000189BCB798-0x0000000189BCB7C4
		public System.DateTime ToDateTime(IFormatProvider provider = null) => default; // 0x0000000189BCB7C4-0x0000000189BCB820
		public decimal ToDecimal(IFormatProvider provider = null) => default; // 0x0000000189BCB820-0x0000000189BCB85C
		public double ToDouble(IFormatProvider provider = null) => default; // 0x00000001837E3470-0x00000001837E3490
		public short ToInt16(IFormatProvider provider = null) => default; // 0x0000000189BCB790-0x0000000189BCB798
		public int ToInt32(IFormatProvider provider = null) => default; // 0x0000000189BCB790-0x0000000189BCB798
		public long ToInt64(IFormatProvider provider = null) => default; // 0x0000000189BCB85C-0x0000000189BCB8DC
		public sbyte ToSByte(IFormatProvider provider = null) => default; // 0x0000000189BCB790-0x0000000189BCB798
		public float ToSingle(IFormatProvider provider = null) => default; // 0x000000018426F72C-0x000000018426F744
		public string ToString(IFormatProvider provider) => default; // 0x0000000189BCBE60-0x0000000189BCBE68
		public object ToType(System.Type conversionType, IFormatProvider provider) => default; // 0x0000000189BCBE68-0x0000000189BCBEB4
		public ushort ToUInt16(IFormatProvider provider = null) => default; // 0x0000000189BCBEB4-0x0000000189BCBEC0
		public uint ToUInt32(IFormatProvider provider = null) => default; // 0x0000000189BCBEB4-0x0000000189BCBEC0
		public ulong ToUInt64(IFormatProvider provider = null) => default; // 0x0000000189BCBEC0-0x0000000189BCBF50
		public object ToObject() => default; // 0x0000000189BCB8DC-0x0000000189BCBAF4
		public static PrimitiveValue From<TValue>(TValue value)
			where TValue : struct => default;
		public static PrimitiveValue FromObject(object value) => default; // 0x0000000189BCAF1C-0x0000000189BCB39C
		public static implicit operator PrimitiveValue(bool value) => default; // 0x0000000183D76E40-0x0000000183D76E60
		public static implicit operator PrimitiveValue(char value) => default; // 0x0000000183D76E80-0x0000000183D76EA0
		public static implicit operator PrimitiveValue(byte value) => default; // 0x0000000183D76E60-0x0000000183D76E80
		public static implicit operator PrimitiveValue(sbyte value) => default; // 0x0000000183D76F20-0x0000000183D76F40
		public static implicit operator PrimitiveValue(short value) => default; // 0x0000000183D76EC0-0x0000000183D76EE0
		public static implicit operator PrimitiveValue(ushort value) => default; // 0x0000000183D76F60-0x0000000183D76F80
		public static implicit operator PrimitiveValue(int value) => default; // 0x0000000183D76EE0-0x0000000183D76F00
		public static implicit operator PrimitiveValue(uint value) => default; // 0x0000000183D76F80-0x0000000183D76FA0
		public static implicit operator PrimitiveValue(long value) => default; // 0x0000000183D76F00-0x0000000183D76F20
		public static implicit operator PrimitiveValue(ulong value) => default; // 0x0000000183D76FA0-0x0000000183D76FC0
		public static implicit operator PrimitiveValue(float value) => default; // 0x0000000183D76F40-0x0000000183D76F60
		public static implicit operator PrimitiveValue(double value) => default; // 0x0000000183D76EA0-0x0000000183D76EC0
		public static PrimitiveValue FromBoolean(bool value) => default; // 0x0000000183D76E40-0x0000000183D76E60
		public static PrimitiveValue FromChar(char value) => default; // 0x0000000183D76E80-0x0000000183D76EA0
		public static PrimitiveValue FromByte(byte value) => default; // 0x0000000183D76E60-0x0000000183D76E80
		public static PrimitiveValue FromSByte(sbyte value) => default; // 0x0000000183D76F20-0x0000000183D76F40
		public static PrimitiveValue FromInt16(short value) => default; // 0x0000000183D76EC0-0x0000000183D76EE0
		public static PrimitiveValue FromUInt16(ushort value) => default; // 0x0000000183D76F60-0x0000000183D76F80
		public static PrimitiveValue FromInt32(int value) => default; // 0x0000000183D76EE0-0x0000000183D76F00
		public static PrimitiveValue FromUInt32(uint value) => default; // 0x0000000183D76F80-0x0000000183D76FA0
		public static PrimitiveValue FromInt64(long value) => default; // 0x0000000183D76F00-0x0000000183D76F20
		public static PrimitiveValue FromUInt64(ulong value) => default; // 0x0000000183D76FA0-0x0000000183D76FC0
		public static PrimitiveValue FromSingle(float value) => default; // 0x0000000183D76F40-0x0000000183D76F60
		public static PrimitiveValue FromDouble(double value) => default; // 0x0000000183D76EA0-0x0000000183D76EC0
	}

	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue> // TypeDefIndex: 44639
	{
		// Fields
		internal TValue[] m_Array;
		internal int m_StartIndex;
		internal int m_Length;
	
		// Properties
		public int Count { get => default; }
		public TValue this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 44638
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

	public static class ReadOnlyArrayExtensions // TypeDefIndex: 44640
	{
		// Extension methods
		public static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : IComparable<TValue> => default;
		public static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class => default;
		public static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value)
			where TValue : class => default;
		internal static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647 /* Metadata: 0x01FB6BE4 */) => default;
	}

	internal interface ISavedState // TypeDefIndex: 44641
	{
		// Methods
		void StaticDisposeCurrentState();
		void RestoreSavedState();
	}

	internal sealed class SavedStructState<T> : ISavedState // TypeDefIndex: 44643
		where T : struct
	{
		// Fields
		private T m_State;
		private TypedRestore m_RestoreAction;
		private Action m_StaticDisposeCurrentState;
	
		// Nested types
		public delegate void TypedRestore(ref ref T state); // TypeDefIndex: 44642; 0x00000000-0x00000000
	
		// Constructors
		public SavedStructState() {} // Dummy constructor
		internal SavedStructState(ref ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState = null) {}
	
		// Methods
		public void StaticDisposeCurrentState() {}
		public void RestoreSavedState() {}
	}

	internal static class SpriteUtilities // TypeDefIndex: 44644
	{
		// Methods
		public static Sprite CreateCircleSprite(int radius, Color32 colour) => default; // 0x0000000189BCBF90-0x0000000189BCC180
	}

	internal static class StringHelpers // TypeDefIndex: 44647
	{
		// Methods
		public static string NicifyMemorySize(long numBytes) => default; // 0x0000000189BCC894-0x0000000189BCCA08
		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1 /* Metadata: 0x01FB6BFD */) {
			result = default;
			return default;
		} // 0x0000000189BCC520-0x0000000189BCC68C
		public static string Join<TValue>(string separator, params TValue[] values) => default;
		public static string Join<TValue>(IEnumerable<TValue> values, string separator) => default;
		public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc) => default;
		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator) => default; // 0x00000001822FAFE0-0x00000001822FB250
		public static int ParseInt(string str, int pos) => default; // 0x0000000189BCCA08-0x0000000189BCCA90
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) => default; // 0x0000000189BCD04C-0x0000000189BCD06C
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset) => default; // 0x0000000189BCCEAC-0x0000000189BCD04C
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) => default; // 0x0000000189BCCB8C-0x0000000189BCCBAC
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset) => default; // 0x0000000189BCCA90-0x0000000189BCCB8C
		public static string ExpandTemplateString(string template, Func<string, string> mapFunc) => default; // 0x0000000189BCC360-0x0000000189BCC520
	
		// Extension methods
		public static string Escape(this string str, string chars = "\n\t\r\\\"" /* Metadata: 0x01FB6BE5 */, string replacements = "ntr\\\"" /* Metadata: 0x01FB6BEB */) => default; // 0x0000000189BCC220-0x0000000189BCC360
		public static string Unescape(this string str, string chars = "ntr\\\"" /* Metadata: 0x01FB6BF1 */, string replacements = "\n\t\r\\\"" /* Metadata: 0x01FB6BF7 */) => default; // 0x0000000189BCCCA4-0x0000000189BCCDE0
		public static bool Contains(this string str, char ch) => default; // 0x0000000189BCC1A0-0x0000000189BCC1C0
		public static bool Contains(this string str, string text, StringComparison comparison) => default; // 0x0000000189BCC180-0x0000000189BCC1A0
		public static string GetPlural(this string str) => default; // 0x0000000189BCC68C-0x0000000189BCC808
		public static int CountOccurrences(this string str, char ch) => default; // 0x0000000189BCC1C0-0x0000000189BCC220
		[IteratorStateMachine(typeof(_Tokenize_d__8))]
		public static IEnumerable<Substring> Tokenize(this string str) => default; // 0x0000000189BCCC34-0x0000000189BCCCA4
		[IteratorStateMachine(typeof(_Split_d__9))]
		public static IEnumerable<string> Split(this string str, Func<char, bool> predicate) => default; // 0x0000000189BCCBAC-0x0000000189BCCC34
		public static bool IsPrintable(this char ch) => default; // 0x0000000189BCC830-0x0000000189BCC894
		public static string WithAllWhitespaceStripped(this string str) => default; // 0x0000000189BCCDE0-0x0000000189BCCEAC
		public static bool InvariantEqualsIgnoreCase(this string left, string right) => default; // 0x0000000189BCC808-0x0000000189BCC830
	}

	internal struct Substring : IComparable<Substring>, IEquatable<Substring> // TypeDefIndex: 44648
	{
		// Fields
		private readonly string m_String; // 0x00
		private readonly int m_Index; // 0x08
		private readonly int m_Length; // 0x0C
	
		// Properties
		public bool isEmpty { get => default; } // 0x0000000189BCD4F8-0x0000000189BCD500 
		public int length { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
		public int index { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		public char this[int index] { get => default; } // 0x0000000189BCD478-0x0000000189BCD4F8 
	
		// Constructors
		public Substring(string str) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x0000000189BCD40C-0x0000000189BCD444
		public Substring(string str, int index, int length) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x000000018426FA34-0x000000018426FA54
		public Substring(string str, int index) : this() {
			m_String = default;
			m_Index = default;
			m_Length = default;
		} // 0x0000000189BCD444-0x0000000189BCD478
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189BCD160-0x0000000189BCD1F8
		public bool Equals(string other) => default; // 0x0000000189BCD21C-0x0000000189BCD2AC
		public bool Equals(Substring other) => default; // 0x0000000189BCD1F8-0x0000000189BCD21C
		public bool Equals(InternedString other) => default; // 0x0000000189BCD0E0-0x0000000189BCD160
		public int CompareTo(Substring other) => default; // 0x0000000189BCD06C-0x0000000189BCD09C
		public static int Compare(Substring left, Substring right, StringComparison comparison) => default; // 0x0000000189BCD09C-0x0000000189BCD0E0
		public bool StartsWith(string str) => default; // 0x0000000189BCD2FC-0x0000000189BCD37C
		public string Substr(int index = 0 /* Metadata: 0x01FB6C05 */, int length = -1 /* Metadata: 0x01FB6C06 */) => default; // 0x0000000189BCD37C-0x0000000189BCD3B0
		public override string ToString() => default; // 0x0000000189BCD3B0-0x0000000189BCD40C
		public override int GetHashCode() => default; // 0x0000000189BCD2AC-0x0000000189BCD2FC
		public static bool operator ==(Substring a, Substring b) => default; // 0x0000000189BCD500-0x0000000189BCD520
		public static bool operator !=(Substring a, Substring b) => default; // 0x0000000189BCD584-0x0000000189BCD5A4
		public static bool operator ==(Substring a, InternedString b) => default; // 0x0000000189BCD544-0x0000000189BCD564
		public static bool operator !=(Substring a, InternedString b) => default; // 0x0000000189BCD5A4-0x0000000189BCD5C4
		public static bool operator ==(InternedString a, Substring b) => default; // 0x0000000189BCD520-0x0000000189BCD544
		public static bool operator !=(InternedString a, Substring b) => default; // 0x0000000189BCD5C4-0x0000000189BCD5EC
		public static implicit operator Substring(string s) => default; // 0x0000000189BCD564-0x0000000189BCD584
	}

	internal static class TypeHelpers // TypeDefIndex: 44649
	{
		// Methods
		public static System.Type GetValueType(MemberInfo member) => default; // 0x0000000189BCDEC0-0x0000000189BCDFAC
		public static System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex) => default; // 0x0000000189BCD828-0x0000000189BCDB5C
	
		// Extension methods
		public static TObject As<TObject>(this object obj) => default;
		public static bool IsInt(this TypeCode type) => default; // 0x0000000189BCDFAC-0x0000000189BCDFDC
		public static string GetNiceTypeName(this System.Type type) => default; // 0x0000000189BCDB5C-0x0000000189BCDEC0
	}

	internal struct TypeTable // TypeDefIndex: 44651
	{
		// Fields
		public Dictionary<InternedString, System.Type> table; // 0x00
	
		// Properties
		public IEnumerable<string> names { get => default; } // 0x0000000189BCE224-0x0000000189BCE354 
		public IEnumerable<InternedString> internedNames { get => default; } // 0x0000000189BCE1E0-0x0000000189BCE224 
	
		// Methods
		public void Initialize() {} // 0x00000001822F8260-0x00000001822F82E0
		public InternedString FindNameForType(System.Type type) => default; // 0x0000000189BCDFDC-0x0000000189BCE1E0
		public void AddTypeRegistration(string name, System.Type type) {} // 0x00000001822F89A0-0x00000001822F8A70
		public System.Type LookupTypeRegistration(string name) => default; // 0x000000018235E070-0x000000018235E120
	}
}

namespace UnityEngine.InputSystem.XInput
{
	public interface IXboxOneRumble : IDualMotorRumble // TypeDefIndex: 44282
	{
		// Methods
		void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
	}

	[InputControlLayout(displayName = "Xbox Controller")]
	public class XInputController : Gamepad // TypeDefIndex: 44287
	{
		// Fields
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
		public ButtonControl menu { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		public ButtonControl view { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		public DeviceSubType subType { get => default; } // 0x0000000189C01274-0x0000000189C012A4 
		public DeviceFlags flags { get => default; } // 0x0000000189C01244-0x0000000189C01274 
	
		// Nested types
		internal enum DeviceType // TypeDefIndex: 44283
		{
			Gamepad = 0
		}
	
		public enum DeviceSubType // TypeDefIndex: 44284
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
		public enum DeviceFlags // TypeDefIndex: 44285
		{
			ForceFeedbackSupported = 1,
			Wireless = 2,
			VoiceSupported = 4,
			PluginModulesSupported = 8,
			NoNavigation = 16
		}
	
		[Serializable]
		internal struct Capabilities // TypeDefIndex: 44286
		{
			// Fields
			public UnityEngine.InputSystem.XInput.XInputController.DeviceType type; // 0x00
			public DeviceSubType subType; // 0x04
			public DeviceFlags flags; // 0x08
		}
	
		// Constructors
		public XInputController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C01168-0x0000000189C011B4
		private void ParseCapabilities() {} // 0x0000000189C011B4-0x0000000189C01244
	}

	[InputControlLayout(stateType = typeof(XInputControllerWindowsState), hideInUI = true)]
	public class XInputControllerWindows : XInputController // TypeDefIndex: 44288
	{
		// Constructors
		public XInputControllerWindows() {} // 0x0000000184275C10-0x0000000184275C18
	}

	internal static class XInputSupport // TypeDefIndex: 44289
	{
		// Methods
		public static void Initialize() {} // 0x0000000182F184C0-0x0000000182F185D0
	}
}

namespace UnityEngine.InputSystem.XInput.LowLevel
{
	internal struct XInputControllerWindowsState : IInputStateTypeInfo // TypeDefIndex: 44291
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
		public FourCC format { get => default; } // 0x0000000183D774B0-0x0000000183D774C0 
	
		// Nested types
		public enum Button // TypeDefIndex: 44290
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
		public XInputControllerWindowsState WithButton(Button button) => default; // 0x0000000183D77480-0x0000000183D774B0
	}
}

namespace UnityEngine.InputSystem.XR
{
	public struct PoseState : IInputStateTypeInfo // TypeDefIndex: 44253
	{
		// Fields
		internal const int kSizeInBytes = 60; // Metadata: 0x01FB67AC
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
		public FourCC format { get => default; } // 0x0000000189BFCA50-0x0000000189BFCAA0 
	
		// Constructors
		public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) : this() {
			this.isTracked = default;
			this.trackingState = default;
			this.position = default;
			this.rotation = default;
			this.velocity = default;
			this.angularVelocity = default;
		} // 0x0000000183D773D0-0x0000000183D77420
		static PoseState() {
			s_Format = default;
		} // 0x0000000189BFCA14-0x0000000189BFCA50
	}

	[InputControlLayout(stateType = typeof(PoseState))]
	[UnityEngine.Scripting.Preserve]
	public class PoseControl : InputControl<PoseState> // TypeDefIndex: 44254
	{
		// Properties
		public ButtonControl isTracked { get; set; } // 0x0000000183D56A70-0x0000000183D56A80 0x0000000184275C2C-0x0000000184275C40
		public IntegerControl trackingState { get; set; } // 0x0000000183D56B50-0x0000000183D56B60 0x0000000184275C40-0x0000000184275C54
		public Vector3Control position { get; set; } // 0x0000000183D56AF0-0x0000000183D56B00 0x0000000184275C54-0x0000000184275C68
		public QuaternionControl rotation { get; set; } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public Vector3Control velocity { get; set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public Vector3Control angularVelocity { get; set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
	
		// Constructors
		public PoseControl() {} // 0x0000000189BFC990-0x0000000189BFCA14
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BFC414-0x0000000189BFC5C0
		public override unsafe PoseState ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BFC5C0-0x0000000189BFC7B8
		public override unsafe void WriteValueIntoState(PoseState value, void* statePtr) {} // 0x0000000189BFC7B8-0x0000000189BFC990
		protected override FourCC CalculateOptimizedControlDataType() => default; // 0x0000000189BFC1E8-0x0000000189BFC414
	}

	[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR HMD", canRunInBackground = true)]
	public class XRHMD : TrackedDevice // TypeDefIndex: 44255
	{
		// Properties
		[InputControl(noisy = true)]
		public Vector3Control leftEyePosition { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(noisy = true)]
		public QuaternionControl leftEyeRotation { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl(noisy = true)]
		public Vector3Control rightEyePosition { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(noisy = true)]
		public QuaternionControl rightEyeRotation { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl(noisy = true)]
		public Vector3Control centerEyePosition { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl(noisy = true)]
		public QuaternionControl centerEyeRotation { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
	
		// Constructors
		public XRHMD() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C01564-0x0000000189C016E4
	}

	[InputControlLayout(commonUsages = new string[2] {"LeftHand", "RightHand" }, isGenericTypeOfDevice = true, displayName = "XR Controller")]
	public class XRController : TrackedDevice // TypeDefIndex: 44256
	{
		// Properties
		public static XRController leftHand { get => default; } // 0x0000000189C01420-0x0000000189C014A4 
		public static XRController rightHand { get => default; } // 0x0000000189C014A4-0x0000000189C01528 
	
		// Constructors
		public XRController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189C01338-0x0000000189C01420
	}

	public class XRControllerWithRumble : XRController // TypeDefIndex: 44257
	{
		// Constructors
		public XRControllerWithRumble() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		public void SendImpulse(float amplitude, float duration) {} // 0x0000000189C012A4-0x0000000189C01338
	}

	[Serializable]
	[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
	public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 44261
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
		public TrackingType trackingType { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public UpdateType updateType { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public bool ignoreTrackingState { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public InputActionProperty positionInput { get => default; set {} } // 0x0000000183D67F30-0x0000000183D67F50 0x0000000189BFE264-0x0000000189BFE2D4
		public InputActionProperty rotationInput { get => default; set {} } // 0x0000000183D51090-0x0000000183D510B0 0x0000000189BFE328-0x0000000189BFE398
		public InputActionProperty trackingStateInput { get => default; set {} } // 0x0000000183D6DC30-0x0000000183D6DC50 0x0000000189BFE398-0x0000000189BFE408
		public InputAction positionAction { get => default; set {} } // 0x0000000189BFE1F8-0x0000000189BFE204 0x0000000189BFE210-0x0000000189BFE264
		public InputAction rotationAction { get => default; set {} } // 0x0000000189BFE204-0x0000000189BFE210 0x0000000189BFE2D4-0x0000000189BFE328
	
		// Nested types
		public enum TrackingType // TypeDefIndex: 44258
		{
			RotationAndPosition = 0,
			RotationOnly = 1,
			PositionOnly = 2
		}
	
		[Flags]
		private enum TrackingStates // TypeDefIndex: 44259
		{
			None = 0,
			Position = 1,
			Rotation = 2
		}
	
		public enum UpdateType // TypeDefIndex: 44260
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}
	
		// Constructors
		public TrackedPoseDriver() {} // 0x0000000189BFE1A0-0x0000000189BFE1F8
	
		// Methods
		private void BindActions() {} // 0x0000000189BFCE80-0x0000000189BFCEAC
		private void UnbindActions() {} // 0x0000000189BFDB84-0x0000000189BFDBB0
		private void BindPosition() {} // 0x0000000189BFCEAC-0x0000000189BFD028
		private void BindRotation() {} // 0x0000000189BFD028-0x0000000189BFD1A4
		private void BindTrackingState() {} // 0x0000000189BFD1A4-0x0000000189BFD320
		private static void RenameAndEnable(InputAction action, string name) {} // 0x0000000189BFD7F8-0x0000000189BFD824
		private void UnbindPosition() {} // 0x0000000189BFDBB0-0x0000000189BFDCE8
		private void UnbindRotation() {} // 0x0000000189BFDCE8-0x0000000189BFDE20
		private void UnbindTrackingState() {} // 0x0000000189BFDE20-0x0000000189BFDF58
		private void OnPositionPerformed(InputAction.CallbackContext context) {} // 0x0000000189BFD5BC-0x0000000189BFD61C
		private void OnPositionCanceled(InputAction.CallbackContext context) {} // 0x0000000189BFD5A8-0x0000000189BFD5BC
		private void OnRotationPerformed(InputAction.CallbackContext context) {} // 0x0000000189BFD63C-0x0000000189BFD690
		private void OnRotationCanceled(InputAction.CallbackContext context) {} // 0x0000000189BFD61C-0x0000000189BFD63C
		private void OnTrackingStatePerformed(InputAction.CallbackContext context) {} // 0x0000000189BFD690-0x0000000189BFD6DC
		private void OnTrackingStateCanceled(InputAction.CallbackContext context) {} // 0x0000000183D77470-0x0000000183D77480
		protected void Reset() {} // 0x0000000189BFD824-0x0000000189BFDA40
		protected virtual void Awake() {} // 0x0000000189BFCE4C-0x0000000189BFCE80
		protected void OnEnable() {} // 0x0000000189BFD504-0x0000000189BFD5A8
		protected void OnDisable() {} // 0x0000000189BFD468-0x0000000189BFD504
		protected virtual void OnDestroy() {} // 0x0000000189BFD434-0x0000000189BFD468
		protected void UpdateCallback() {} // 0x0000000189BFE018-0x0000000189BFE1A0
		private void ReadTrackingState(bool hasResolvedPositionInputControl, bool hasResolvedRotationInputControl) {} // 0x0000000189BFD728-0x0000000189BFD7F8
		protected virtual void OnUpdate() {} // 0x0000000189BFD6DC-0x0000000189BFD6F0
		protected virtual void OnBeforeRender() {} // 0x0000000189BFD420-0x0000000189BFD434
		protected virtual void PerformUpdate() {} // 0x0000000189BFD6F0-0x0000000189BFD728
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) {} // 0x0000000189BFDA40-0x0000000189BFDB84
		private bool HasStereoCamera(out Camera cameraComponent) {
			cameraComponent = default;
			return default;
		} // 0x0000000189BFD3BC-0x0000000189BFD420
		private static bool HasResolvedControl(InputAction action) => default; // 0x0000000189BFD320-0x0000000189BFD3BC
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189BFDF58-0x0000000189BFE018
	}

	internal class XRLayoutBuilder // TypeDefIndex: 44263
	{
		// Fields
		private string parentLayout; // 0x10
		private string interfaceName; // 0x18
		private XRDeviceDescriptor descriptor; // 0x20
		private static readonly string[] poseSubControlNames; // 0x00
		private static readonly FeatureType[] poseSubControlTypes; // 0x08
	
		// Constructors
		public XRLayoutBuilder() {} // 0x000000018350B670-0x000000018350B680
		static XRLayoutBuilder() {} // 0x0000000189C028F8-0x0000000189C02F80
	
		// Methods
		private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor) => default; // 0x0000000189C025D4-0x0000000189C02668
		private static string SanitizeString(string original, bool allowPaths = false /* Metadata: 0x01FB67B6 */) => default; // 0x0000000189C027C4-0x0000000189C028F8
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate) => default; // 0x0000000182CADCE0-0x0000000182CADE20
		private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias) => default; // 0x0000000189C02424-0x0000000189C02598
		private bool IsSubControl(string name) => default; // 0x0000000189C0279C-0x0000000189C027C4
		private string GetParentControlName(string name) => default; // 0x0000000189C02598-0x0000000189C025D4
		private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex) => default; // 0x0000000189C02668-0x0000000189C0279C
		private InputControlLayout Build() => default; // 0x0000000189C016E4-0x0000000189C02424
	}

	public static class XRUtilities // TypeDefIndex: 44264
	{
		// Fields
		public const string InterfaceMatchAnyVersion = "^(XRInput)"; // Metadata: 0x01FB67B7
		public const string InterfaceV1 = "XRInput"; // Metadata: 0x01FB67C2
		public const string InterfaceCurrent = "XRInputV1"; // Metadata: 0x01FB67CA
	}

	public enum FeatureType // TypeDefIndex: 44265
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
	public struct UsageHint // TypeDefIndex: 44266
	{
		// Fields
		public string content; // 0x00
	}

	[Serializable]
	public struct XRFeatureDescriptor // TypeDefIndex: 44267
	{
		// Fields
		public string name; // 0x00
		public List<UsageHint> usageHints; // 0x08
		public FeatureType featureType; // 0x10
		public uint customSize; // 0x14
	}

	[Serializable]
	public class XRDeviceDescriptor // TypeDefIndex: 44268
	{
		// Fields
		public string deviceName; // 0x10
		public string manufacturer; // 0x18
		public string serialNumber; // 0x20
		public InputDeviceCharacteristics characteristics; // 0x28
		public int deviceId; // 0x2C
		public List<XRFeatureDescriptor> inputFeatures; // 0x30
	
		// Constructors
		public XRDeviceDescriptor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public string ToJson() => default; // 0x000000018427445C-0x0000000184274468
		public static XRDeviceDescriptor FromJson(string json) => default; // 0x0000000189C01528-0x0000000189C01564
	}

	public struct Bone // TypeDefIndex: 44269
	{
		// Fields
		public uint m_ParentBoneIndex; // 0x00
		public Vector3 m_Position; // 0x04
		public Quaternion m_Rotation; // 0x10
	
		// Properties
		public uint parentBoneIndex { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public Vector3 position { get => default; set {} } // 0x0000000183D5E390-0x0000000183D5E3B0 0x0000000183D77290-0x0000000183D772A0
		public Quaternion rotation { get => default; set {} } // 0x00000001820B7B30-0x00000001820B7B40 0x0000000183D55580-0x0000000183D55590
	}

	public struct Eyes // TypeDefIndex: 44270
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
		public Vector3 leftEyePosition { get => default; set {} } // 0x0000000183D56520-0x0000000183D56540 0x0000000183D56570-0x0000000183D56580
		public Quaternion leftEyeRotation { get => default; set {} } // 0x0000000183D5E380-0x0000000183D5E390 0x0000000183D772B0-0x0000000183D772C0
		public Vector3 rightEyePosition { get => default; set {} } // 0x0000000183D568F0-0x0000000183D56910 0x0000000183D5CBC0-0x0000000183D5CBD0
		public Quaternion rightEyeRotation { get => default; set {} } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000183D59E30-0x0000000183D59E40
		public Vector3 fixationPoint { get => default; set {} } // 0x0000000183D69690-0x0000000183D696B0 0x0000000183D68D90-0x0000000183D68DA0
		public float leftEyeOpenAmount { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public float rightEyeOpenAmount { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	}

	public class BoneControl : InputControl<UnityEngine.InputSystem.XR.Bone> // TypeDefIndex: 44271
	{
		// Properties
		[InputControl(offset = 0, displayName = "parentBoneIndex")]
		public IntegerControl parentBoneIndex { get; set; } // 0x0000000183D57300-0x0000000183D57310 0x00000001858B3FD8-0x00000001858B3FEC
		[InputControl(offset = 4, displayName = "Position")]
		public Vector3Control position { get; set; } // 0x0000000183D571B0-0x0000000183D571C0 0x00000001858B3DA8-0x00000001858B3DBC
		[InputControl(offset = 16, displayName = "Rotation")]
		public QuaternionControl rotation { get; set; } // 0x0000000183D57200-0x0000000183D57210 0x00000001858B3DD0-0x00000001858B3DE4
	
		// Constructors
		public BoneControl() {} // 0x0000000189BEB624-0x0000000189BEB658
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BEB3BC-0x0000000189BEB4B8
		public override unsafe UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BEB4B8-0x0000000189BEB590
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr) {} // 0x0000000189BEB590-0x0000000189BEB624
	}

	public class EyesControl : InputControl<UnityEngine.InputSystem.XR.Eyes> // TypeDefIndex: 44272
	{
		// Properties
		[InputControl(offset = 0, displayName = "LeftEyePosition")]
		public Vector3Control leftEyePosition { get; set; } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		[InputControl(offset = 12, displayName = "LeftEyeRotation")]
		public QuaternionControl leftEyeRotation { get; set; } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		[InputControl(offset = 28, displayName = "RightEyePosition")]
		public Vector3Control rightEyePosition { get; set; } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		[InputControl(offset = 40, displayName = "RightEyeRotation")]
		public QuaternionControl rightEyeRotation { get; set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(offset = 56, displayName = "FixationPoint")]
		public Vector3Control fixationPoint { get; set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
		public AxisControl leftEyeOpenAmount { get; set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
		public AxisControl rightEyeOpenAmount { get; set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
	
		// Constructors
		public EyesControl() {} // 0x0000000189BEC7F4-0x0000000189BEC828
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BEC36C-0x0000000189BEC540
		public override unsafe UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr) => default; // 0x0000000189BEC540-0x0000000189BEC6BC
		public override unsafe void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr) {} // 0x0000000189BEC6BC-0x0000000189BEC7F4
	}

	internal static class XRSupport // TypeDefIndex: 44273
	{
		// Methods
		public static void Initialize() {} // 0x0000000182F193D0-0x0000000182F19F60
	}
}

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct BufferedRumble // TypeDefIndex: 44274
	{
		// Properties
		public HapticCapabilities capabilities { [IsReadOnly] get; private set; } // 0x0000000183D5EC40-0x0000000183D5EC50 0x0000000183D517D0-0x0000000183D517E0
		private UnityEngine.InputSystem.InputDevice device { [IsReadOnly] get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public BufferedRumble(UnityEngine.InputSystem.InputDevice device) : this() {} // 0x0000000189BEB73C-0x0000000189BEB844
	
		// Methods
		public void EnqueueRumble(byte[] samples) {} // 0x0000000189BEB658-0x0000000189BEB73C
	}

	public struct HapticState // TypeDefIndex: 44275
	{
		// Properties
		public uint samplesQueued { [IsReadOnly] get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public uint samplesAvailable { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
	
		// Constructors
		public HapticState(uint samplesQueued, uint samplesAvailable) : this() {} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	}

	public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 44276
	{
		// Fields
		private const int kSize = 16; // Metadata: 0x01FB67DE
		private InputDeviceCommand baseCommand; // 0x00
		public uint samplesQueued; // 0x08
		public uint samplesAvailable; // 0x0C
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000183D772F0-0x0000000183D77300 
		public FourCC typeStatic { get => default; } // 0x0000000183D772F0-0x0000000183D77300 
		public HapticState currentState { get => default; } // 0x0000000183D77300-0x0000000183D77320 
	
		// Methods
		public static GetCurrentHapticStateCommand Create() => default; // 0x0000000183D772C0-0x0000000183D772F0
	}

	public struct HapticCapabilities // TypeDefIndex: 44277
	{
		// Properties
		public uint numChannels { [IsReadOnly] get; } // 0x0000000183D4E980-0x0000000183D4E990 
		public bool supportsImpulse { [IsReadOnly] get; } // 0x0000000183D55A00-0x0000000183D55A10 
		public bool supportsBuffer { [IsReadOnly] get; } // 0x0000000183D55A10-0x0000000183D55A20 
		public uint frequencyHz { [IsReadOnly] get; } // 0x0000000183D516F0-0x0000000183D51700 
		public uint maxBufferSize { [IsReadOnly] get; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
		public uint optimalBufferSize { [IsReadOnly] get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize) : this() {} // 0x0000000183D773B0-0x0000000183D773D0
		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize) : this() {} // 0x0000000183D77390-0x0000000183D773B0
	}

	public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo // TypeDefIndex: 44278
	{
		// Fields
		private const int kSize = 28; // Metadata: 0x01FB67DF
		private InputDeviceCommand baseCommand; // 0x00
		public uint numChannels; // 0x08
		public bool supportsImpulse; // 0x0C
		public bool supportsBuffer; // 0x0D
		public uint frequencyHz; // 0x10
		public uint maxBufferSize; // 0x14
		public uint optimalBufferSize; // 0x18
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000183D77350-0x0000000183D77360 
		public FourCC typeStatic { get => default; } // 0x0000000183D77350-0x0000000183D77360 
		public HapticCapabilities capabilities { get => default; } // 0x0000000183D77360-0x0000000183D77390 
	
		// Methods
		public static GetHapticCapabilitiesCommand Create() => default; // 0x0000000183D77320-0x0000000183D77350
	}

	public struct SendBufferedHapticCommand : IInputDeviceCommandInfo // TypeDefIndex: 44280
	{
		// Fields
		private const int kMaxHapticBufferSize = 1024; // Metadata: 0x01FB67E0
		private const int kSize = 1040; // Metadata: 0x01FB67E2
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private int bufferSize; // 0x0C
		private unsafe fixed /* 0x00000000-0x00000000 */ byte buffer[0]; // 0x10
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000183D77420-0x0000000183D77430 
		public FourCC typeStatic { get => default; } // 0x0000000183D77420-0x0000000183D77430 
	
		// Methods
		public static SendBufferedHapticCommand Create(byte[] rumbleBuffer) => default; // 0x0000000189BFCAA0-0x0000000189BFCC20
	}

	public struct SendHapticImpulseCommand : IInputDeviceCommandInfo // TypeDefIndex: 44281
	{
		// Fields
		private const int kSize = 20; // Metadata: 0x01FB67E4
		private InputDeviceCommand baseCommand; // 0x00
		private int channel; // 0x08
		private float amplitude; // 0x0C
		private float duration; // 0x10
	
		// Properties
		private static FourCC Type { get => default; } // 0x0000000183D77460-0x0000000183D77470 
		public FourCC typeStatic { get => default; } // 0x0000000183D77460-0x0000000183D77470 
	
		// Methods
		public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration) => default; // 0x0000000183D77430-0x0000000183D77460
	}
}

namespace UnityEngine.XR.WindowsMR.Input
{
	[InputControlLayout(displayName = "Windows MR Headset", hideInUI = true)]
	public class WMRHMD : XRHMD // TypeDefIndex: 44048
	{
		// Properties
		[InputControl]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[1] {"HeadRotation" })]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[1] {"HeadPosition" })]
		public ButtonControl userPresence { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
	
		// Constructors
		public WMRHMD() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BAF2DC-0x0000000189BAF348
	}

	[InputControlLayout(displayName = "HoloLens Hand", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class HololensHand : XRController // TypeDefIndex: 44049
	{
		// Properties
		[InputControl(noisy = true, aliases = new string[1] {"gripVelocity" })]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl airTap { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
	
		// Constructors
		public HololensHand() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189B9E6C4-0x0000000189B9E7E4
	}

	[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new string[2] {"LeftHand", "RightHand" }, hideInUI = true)]
	public class WMRSpatialController : XRControllerWithRumble // TypeDefIndex: 44050
	{
		// Properties
		[InputControl(aliases = new string[2] {"Primary2DAxis", "thumbstickaxes" })]
		public Vector2Control joystick { get; protected set; } // 0x0000000183D57160-0x0000000183D57170 0x0000000184275BFC-0x0000000184275C10
		[InputControl(aliases = new string[2] {"Secondary2DAxis", "touchpadaxes" })]
		public Vector2Control touchpad { get; protected set; } // 0x0000000183D57130-0x0000000183D57140 0x0000000184275B98-0x0000000184275BAC
		[InputControl(aliases = new string[1] {"gripaxis" })]
		public AxisControl grip { get; protected set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		[InputControl(aliases = new string[1] {"gripbutton" })]
		public ButtonControl gripPressed { get; protected set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		[InputControl(aliases = new string[2] {"Primary", "menubutton" })]
		public ButtonControl menu { get; protected set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000184275C90-0x0000000184275CA4
		[InputControl(aliases = new string[1] {"triggeraxis" })]
		public AxisControl trigger { get; protected set; } // 0x0000000183D50210-0x0000000183D50220 0x00000001858B3B64-0x00000001858B3B78
		[InputControl(aliases = new string[1] {"triggerbutton" })]
		public ButtonControl triggerPressed { get; protected set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
		[InputControl(aliases = new string[1] {"thumbstickpressed" })]
		public ButtonControl joystickClicked { get; protected set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		[InputControl(aliases = new string[2] {"joystickorpadpressed", "touchpadpressed" })]
		public ButtonControl touchpadClicked { get; protected set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		[InputControl(aliases = new string[2] {"joystickorpadtouched", "touchpadtouched" })]
		public ButtonControl touchpadTouched { get; protected set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		[InputControl(noisy = true, aliases = new string[1] {"gripVelocity" })]
		public Vector3Control deviceVelocity { get; protected set; } // 0x0000000183D56BB0-0x0000000183D56BC0 0x00000001858ADFA8-0x00000001858ADFBC
		[InputControl(noisy = true, aliases = new string[1] {"gripAngularVelocity" })]
		public Vector3Control deviceAngularVelocity { get; protected set; } // 0x0000000183D57190-0x0000000183D571A0 0x00000001858ADFBC-0x00000001858ADFD0
		[InputControl(noisy = true)]
		public AxisControl batteryLevel { get; protected set; } // 0x0000000183D570C0-0x0000000183D570D0 0x00000001858B3C68-0x00000001858B3C7C
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk { get; protected set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection { get; protected set; } // 0x0000000183D57430-0x0000000183D57440 0x00000001858B41A4-0x00000001858B41B8
		[InputControl(noisy = true)]
		public Vector3Control pointerPosition { get; protected set; } // 0x0000000183D57480-0x0000000183D57490 0x00000001858B421C-0x00000001858B4230
		[InputControl(noisy = true, aliases = new string[1] {"PointerOrientation" })]
		public QuaternionControl pointerRotation { get; protected set; } // 0x0000000183D57210-0x0000000183D57220 0x00000001858B3DE4-0x00000001858B3DF8
	
		// Constructors
		public WMRSpatialController() {} // 0x0000000184275C10-0x0000000184275C18
	
		// Methods
		protected override void FinishSetup() {} // 0x0000000189BAF348-0x0000000189BAF738
	}
}
