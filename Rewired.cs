/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Rewired;
using Rewired.Components;
using Rewired.Interfaces;
using Rewired.UI;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.CLZF2;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

// Image 49: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60358-60412
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Rewired
{
	public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 60359
	{
		// Properties
		IControllerTemplateButton actionBottomRow1 { get; }
		IControllerTemplateButton a { get; }
		IControllerTemplateButton actionBottomRow2 { get; }
		IControllerTemplateButton b { get; }
		IControllerTemplateButton actionBottomRow3 { get; }
		IControllerTemplateButton c { get; }
		IControllerTemplateButton actionTopRow1 { get; }
		IControllerTemplateButton x { get; }
		IControllerTemplateButton actionTopRow2 { get; }
		IControllerTemplateButton y { get; }
		IControllerTemplateButton actionTopRow3 { get; }
		IControllerTemplateButton z { get; }
		IControllerTemplateButton leftShoulder1 { get; }
		IControllerTemplateButton leftBumper { get; }
		IControllerTemplateAxis leftShoulder2 { get; }
		IControllerTemplateAxis leftTrigger { get; }
		IControllerTemplateButton rightShoulder1 { get; }
		IControllerTemplateButton rightBumper { get; }
		IControllerTemplateAxis rightShoulder2 { get; }
		IControllerTemplateAxis rightTrigger { get; }
		IControllerTemplateButton center1 { get; }
		IControllerTemplateButton back { get; }
		IControllerTemplateButton center2 { get; }
		IControllerTemplateButton start { get; }
		IControllerTemplateButton center3 { get; }
		IControllerTemplateButton guide { get; }
		IControllerTemplateThumbStick leftStick { get; }
		IControllerTemplateThumbStick rightStick { get; }
		IControllerTemplateDPad dPad { get; }
	}

	public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 60360
	{
		// Properties
		IControllerTemplateAxis wheel { get; }
		IControllerTemplateAxis accelerator { get; }
		IControllerTemplateAxis brake { get; }
		IControllerTemplateAxis clutch { get; }
		IControllerTemplateButton shiftDown { get; }
		IControllerTemplateButton shiftUp { get; }
		IControllerTemplateButton wheelButton1 { get; }
		IControllerTemplateButton wheelButton2 { get; }
		IControllerTemplateButton wheelButton3 { get; }
		IControllerTemplateButton wheelButton4 { get; }
		IControllerTemplateButton wheelButton5 { get; }
		IControllerTemplateButton wheelButton6 { get; }
		IControllerTemplateButton wheelButton7 { get; }
		IControllerTemplateButton wheelButton8 { get; }
		IControllerTemplateButton wheelButton9 { get; }
		IControllerTemplateButton wheelButton10 { get; }
		IControllerTemplateButton consoleButton1 { get; }
		IControllerTemplateButton consoleButton2 { get; }
		IControllerTemplateButton consoleButton3 { get; }
		IControllerTemplateButton consoleButton4 { get; }
		IControllerTemplateButton consoleButton5 { get; }
		IControllerTemplateButton consoleButton6 { get; }
		IControllerTemplateButton consoleButton7 { get; }
		IControllerTemplateButton consoleButton8 { get; }
		IControllerTemplateButton consoleButton9 { get; }
		IControllerTemplateButton consoleButton10 { get; }
		IControllerTemplateButton shifter1 { get; }
		IControllerTemplateButton shifter2 { get; }
		IControllerTemplateButton shifter3 { get; }
		IControllerTemplateButton shifter4 { get; }
		IControllerTemplateButton shifter5 { get; }
		IControllerTemplateButton shifter6 { get; }
		IControllerTemplateButton shifter7 { get; }
		IControllerTemplateButton shifter8 { get; }
		IControllerTemplateButton shifter9 { get; }
		IControllerTemplateButton shifter10 { get; }
		IControllerTemplateButton reverseGear { get; }
		IControllerTemplateButton select { get; }
		IControllerTemplateButton start { get; }
		IControllerTemplateButton systemButton { get; }
		IControllerTemplateButton horn { get; }
		IControllerTemplateDPad dPad { get; }
	}

	public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 60361
	{
		// Properties
		IControllerTemplateButton stickTrigger { get; }
		IControllerTemplateButton stickTriggerStage2 { get; }
		IControllerTemplateButton stickPinkyButton { get; }
		IControllerTemplateButton stickPinkyTrigger { get; }
		IControllerTemplateButton stickButton1 { get; }
		IControllerTemplateButton stickButton2 { get; }
		IControllerTemplateButton stickButton3 { get; }
		IControllerTemplateButton stickButton4 { get; }
		IControllerTemplateButton stickButton5 { get; }
		IControllerTemplateButton stickButton6 { get; }
		IControllerTemplateButton stickButton7 { get; }
		IControllerTemplateButton stickButton8 { get; }
		IControllerTemplateButton stickButton9 { get; }
		IControllerTemplateButton stickButton10 { get; }
		IControllerTemplateButton stickBaseButton1 { get; }
		IControllerTemplateButton stickBaseButton2 { get; }
		IControllerTemplateButton stickBaseButton3 { get; }
		IControllerTemplateButton stickBaseButton4 { get; }
		IControllerTemplateButton stickBaseButton5 { get; }
		IControllerTemplateButton stickBaseButton6 { get; }
		IControllerTemplateButton stickBaseButton7 { get; }
		IControllerTemplateButton stickBaseButton8 { get; }
		IControllerTemplateButton stickBaseButton9 { get; }
		IControllerTemplateButton stickBaseButton10 { get; }
		IControllerTemplateButton stickBaseButton11 { get; }
		IControllerTemplateButton stickBaseButton12 { get; }
		IControllerTemplateButton mode1 { get; }
		IControllerTemplateButton mode2 { get; }
		IControllerTemplateButton mode3 { get; }
		IControllerTemplateButton throttleButton1 { get; }
		IControllerTemplateButton throttleButton2 { get; }
		IControllerTemplateButton throttleButton3 { get; }
		IControllerTemplateButton throttleButton4 { get; }
		IControllerTemplateButton throttleButton5 { get; }
		IControllerTemplateButton throttleButton6 { get; }
		IControllerTemplateButton throttleButton7 { get; }
		IControllerTemplateButton throttleButton8 { get; }
		IControllerTemplateButton throttleButton9 { get; }
		IControllerTemplateButton throttleButton10 { get; }
		IControllerTemplateButton throttleBaseButton1 { get; }
		IControllerTemplateButton throttleBaseButton2 { get; }
		IControllerTemplateButton throttleBaseButton3 { get; }
		IControllerTemplateButton throttleBaseButton4 { get; }
		IControllerTemplateButton throttleBaseButton5 { get; }
		IControllerTemplateButton throttleBaseButton6 { get; }
		IControllerTemplateButton throttleBaseButton7 { get; }
		IControllerTemplateButton throttleBaseButton8 { get; }
		IControllerTemplateButton throttleBaseButton9 { get; }
		IControllerTemplateButton throttleBaseButton10 { get; }
		IControllerTemplateButton throttleBaseButton11 { get; }
		IControllerTemplateButton throttleBaseButton12 { get; }
		IControllerTemplateButton throttleBaseButton13 { get; }
		IControllerTemplateButton throttleBaseButton14 { get; }
		IControllerTemplateButton throttleBaseButton15 { get; }
		IControllerTemplateAxis throttleSlider1 { get; }
		IControllerTemplateAxis throttleSlider2 { get; }
		IControllerTemplateAxis throttleSlider3 { get; }
		IControllerTemplateAxis throttleSlider4 { get; }
		IControllerTemplateAxis throttleDial1 { get; }
		IControllerTemplateAxis throttleDial2 { get; }
		IControllerTemplateAxis throttleDial3 { get; }
		IControllerTemplateAxis throttleDial4 { get; }
		IControllerTemplateButton throttleWheel1Forward { get; }
		IControllerTemplateButton throttleWheel1Back { get; }
		IControllerTemplateButton throttleWheel1Press { get; }
		IControllerTemplateButton throttleWheel2Forward { get; }
		IControllerTemplateButton throttleWheel2Back { get; }
		IControllerTemplateButton throttleWheel2Press { get; }
		IControllerTemplateButton throttleWheel3Forward { get; }
		IControllerTemplateButton throttleWheel3Back { get; }
		IControllerTemplateButton throttleWheel3Press { get; }
		IControllerTemplateAxis leftPedal { get; }
		IControllerTemplateAxis rightPedal { get; }
		IControllerTemplateAxis slidePedals { get; }
		IControllerTemplateStick stick { get; }
		IControllerTemplateThumbStick stickMiniStick1 { get; }
		IControllerTemplateThumbStick stickMiniStick2 { get; }
		IControllerTemplateHat stickHat1 { get; }
		IControllerTemplateHat stickHat2 { get; }
		IControllerTemplateHat stickHat3 { get; }
		IControllerTemplateHat stickHat4 { get; }
		IControllerTemplateThrottle throttle1 { get; }
		IControllerTemplateThrottle throttle2 { get; }
		IControllerTemplateThumbStick throttleMiniStick { get; }
		IControllerTemplateHat throttleHat1 { get; }
		IControllerTemplateHat throttleHat2 { get; }
		IControllerTemplateHat throttleHat3 { get; }
		IControllerTemplateHat throttleHat4 { get; }
	}

	public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 60362
	{
		// Properties
		IControllerTemplateButton leftPaddle { get; }
		IControllerTemplateButton rightPaddle { get; }
		IControllerTemplateButton leftGripButton1 { get; }
		IControllerTemplateButton leftGripButton2 { get; }
		IControllerTemplateButton leftGripButton3 { get; }
		IControllerTemplateButton leftGripButton4 { get; }
		IControllerTemplateButton leftGripButton5 { get; }
		IControllerTemplateButton leftGripButton6 { get; }
		IControllerTemplateButton rightGripButton1 { get; }
		IControllerTemplateButton rightGripButton2 { get; }
		IControllerTemplateButton rightGripButton3 { get; }
		IControllerTemplateButton rightGripButton4 { get; }
		IControllerTemplateButton rightGripButton5 { get; }
		IControllerTemplateButton rightGripButton6 { get; }
		IControllerTemplateButton centerButton1 { get; }
		IControllerTemplateButton centerButton2 { get; }
		IControllerTemplateButton centerButton3 { get; }
		IControllerTemplateButton centerButton4 { get; }
		IControllerTemplateButton centerButton5 { get; }
		IControllerTemplateButton centerButton6 { get; }
		IControllerTemplateButton centerButton7 { get; }
		IControllerTemplateButton centerButton8 { get; }
		IControllerTemplateButton wheel1Up { get; }
		IControllerTemplateButton wheel1Down { get; }
		IControllerTemplateButton wheel1Press { get; }
		IControllerTemplateButton wheel2Up { get; }
		IControllerTemplateButton wheel2Down { get; }
		IControllerTemplateButton wheel2Press { get; }
		IControllerTemplateButton consoleButton1 { get; }
		IControllerTemplateButton consoleButton2 { get; }
		IControllerTemplateButton consoleButton3 { get; }
		IControllerTemplateButton consoleButton4 { get; }
		IControllerTemplateButton consoleButton5 { get; }
		IControllerTemplateButton consoleButton6 { get; }
		IControllerTemplateButton consoleButton7 { get; }
		IControllerTemplateButton consoleButton8 { get; }
		IControllerTemplateButton consoleButton9 { get; }
		IControllerTemplateButton consoleButton10 { get; }
		IControllerTemplateButton mode1 { get; }
		IControllerTemplateButton mode2 { get; }
		IControllerTemplateButton mode3 { get; }
		IControllerTemplateYoke yoke { get; }
		IControllerTemplateThrottle lever1 { get; }
		IControllerTemplateThrottle lever2 { get; }
		IControllerTemplateThrottle lever3 { get; }
		IControllerTemplateThrottle lever4 { get; }
		IControllerTemplateThrottle lever5 { get; }
		IControllerTemplateHat leftGripHat { get; }
		IControllerTemplateHat rightGripHat { get; }
	}

	public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 60363
	{
		// Properties
		IControllerTemplateAxis leftPedal { get; }
		IControllerTemplateAxis rightPedal { get; }
		IControllerTemplateAxis slide { get; }
	}

	public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 60364
	{
		// Properties
		IControllerTemplateAxis extraAxis1 { get; }
		IControllerTemplateAxis extraAxis2 { get; }
		IControllerTemplateAxis extraAxis3 { get; }
		IControllerTemplateAxis extraAxis4 { get; }
		IControllerTemplateButton button1 { get; }
		IControllerTemplateButton button2 { get; }
		IControllerTemplateButton button3 { get; }
		IControllerTemplateButton button4 { get; }
		IControllerTemplateButton button5 { get; }
		IControllerTemplateButton button6 { get; }
		IControllerTemplateButton button7 { get; }
		IControllerTemplateButton button8 { get; }
		IControllerTemplateButton button9 { get; }
		IControllerTemplateButton button10 { get; }
		IControllerTemplateButton button11 { get; }
		IControllerTemplateButton button12 { get; }
		IControllerTemplateButton button13 { get; }
		IControllerTemplateButton button14 { get; }
		IControllerTemplateButton button15 { get; }
		IControllerTemplateButton button16 { get; }
		IControllerTemplateButton button17 { get; }
		IControllerTemplateButton button18 { get; }
		IControllerTemplateButton button19 { get; }
		IControllerTemplateButton button20 { get; }
		IControllerTemplateButton button21 { get; }
		IControllerTemplateButton button22 { get; }
		IControllerTemplateButton button23 { get; }
		IControllerTemplateButton button24 { get; }
		IControllerTemplateButton button25 { get; }
		IControllerTemplateButton button26 { get; }
		IControllerTemplateButton button27 { get; }
		IControllerTemplateButton button28 { get; }
		IControllerTemplateButton button29 { get; }
		IControllerTemplateButton button30 { get; }
		IControllerTemplateButton button31 { get; }
		IControllerTemplateButton button32 { get; }
		IControllerTemplateHat hat1 { get; }
		IControllerTemplateHat hat2 { get; }
		IControllerTemplateThrottle throttle1 { get; }
		IControllerTemplateThrottle throttle2 { get; }
		IControllerTemplateStick6D stick { get; }
	}

	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 60365
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x0234D578
		public const int elementId_leftStickY = 1; // Metadata: 0x0234D579
		public const int elementId_rightStickX = 2; // Metadata: 0x0234D57A
		public const int elementId_rightStickY = 3; // Metadata: 0x0234D57B
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x0234D57C
		public const int elementId_a = 4; // Metadata: 0x0234D57D
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x0234D57E
		public const int elementId_b = 5; // Metadata: 0x0234D57F
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x0234D580
		public const int elementId_c = 6; // Metadata: 0x0234D581
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x0234D582
		public const int elementId_x = 7; // Metadata: 0x0234D583
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x0234D584
		public const int elementId_y = 8; // Metadata: 0x0234D585
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x0234D586
		public const int elementId_z = 9; // Metadata: 0x0234D587
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x0234D588
		public const int elementId_leftBumper = 10; // Metadata: 0x0234D589
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x0234D58A
		public const int elementId_leftTrigger = 11; // Metadata: 0x0234D58B
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x0234D58C
		public const int elementId_rightBumper = 12; // Metadata: 0x0234D58D
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x0234D58E
		public const int elementId_rightTrigger = 13; // Metadata: 0x0234D58F
		public const int elementId_center1 = 14; // Metadata: 0x0234D590
		public const int elementId_back = 14; // Metadata: 0x0234D591
		public const int elementId_center2 = 15; // Metadata: 0x0234D592
		public const int elementId_start = 15; // Metadata: 0x0234D593
		public const int elementId_center3 = 16; // Metadata: 0x0234D594
		public const int elementId_guide = 16; // Metadata: 0x0234D595
		public const int elementId_leftStickButton = 17; // Metadata: 0x0234D596
		public const int elementId_rightStickButton = 18; // Metadata: 0x0234D597
		public const int elementId_dPadUp = 19; // Metadata: 0x0234D598
		public const int elementId_dPadRight = 20; // Metadata: 0x0234D599
		public const int elementId_dPadDown = 21; // Metadata: 0x0234D59A
		public const int elementId_dPadLeft = 22; // Metadata: 0x0234D59B
		public const int elementId_leftStick = 23; // Metadata: 0x0234D59C
		public const int elementId_rightStick = 24; // Metadata: 0x0234D59D
		public const int elementId_dPad = 25; // Metadata: 0x0234D59E
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get; } // 0x000000018A9C93BC-0x000000018A9C93FC 
		IControllerTemplateButton IGamepadTemplate.a { get; } // 0x000000018A9C937C-0x000000018A9C93BC 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get; } // 0x000000018A9C93FC-0x000000018A9C943C 
		IControllerTemplateButton IGamepadTemplate.b { get; } // 0x000000018A9C953C-0x000000018A9C957C 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get; } // 0x000000018A9C943C-0x000000018A9C947C 
		IControllerTemplateButton IGamepadTemplate.c { get; } // 0x000000018A9C95BC-0x000000018A9C95FC 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get; } // 0x000000018A9C947C-0x000000018A9C94BC 
		IControllerTemplateButton IGamepadTemplate.x { get; } // 0x000000018A9C99FC-0x000000018A9C9A3C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get; } // 0x000000018A9C94BC-0x000000018A9C94FC 
		IControllerTemplateButton IGamepadTemplate.y { get; } // 0x000000018A9C9A3C-0x000000018A9C9A7C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get; } // 0x000000018A9C94FC-0x000000018A9C953C 
		IControllerTemplateButton IGamepadTemplate.z { get; } // 0x000000018A9C9A7C-0x000000018A9C9ABC 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get; } // 0x000000018A9C977C-0x000000018A9C97BC 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get; } // 0x000000018A9C973C-0x000000018A9C977C 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get; } // 0x000000018A9C97BC-0x000000018A9C97FC 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get; } // 0x000000018A9C983C-0x000000018A9C987C 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get; } // 0x000000018A9C98BC-0x000000018A9C98FC 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get; } // 0x000000018A9C987C-0x000000018A9C98BC 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get; } // 0x000000018A9C98FC-0x000000018A9C993C 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get; } // 0x000000018A9C997C-0x000000018A9C99BC 
		IControllerTemplateButton IGamepadTemplate.center1 { get; } // 0x000000018A9C95FC-0x000000018A9C963C 
		IControllerTemplateButton IGamepadTemplate.back { get; } // 0x000000018A9C957C-0x000000018A9C95BC 
		IControllerTemplateButton IGamepadTemplate.center2 { get; } // 0x000000018A9C963C-0x000000018A9C967C 
		IControllerTemplateButton IGamepadTemplate.start { get; } // 0x000000018A9C99BC-0x000000018A9C99FC 
		IControllerTemplateButton IGamepadTemplate.center3 { get; } // 0x000000018A9C967C-0x000000018A9C96BC 
		IControllerTemplateButton IGamepadTemplate.guide { get; } // 0x000000018A9C96FC-0x000000018A9C973C 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get; } // 0x000000018A9C97FC-0x000000018A9C983C 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get; } // 0x000000018A9C993C-0x000000018A9C997C 
		IControllerTemplateDPad IGamepadTemplate.dPad { get; } // 0x000000018A9C96BC-0x000000018A9C96FC 
	
		// Constructors
		public GamepadTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static GamepadTemplate(); // 0x000000018A9C9ABC-0x000000018A9C9B20
	}

	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 60366
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x0234D59F
		public const int elementId_accelerator = 1; // Metadata: 0x0234D5A0
		public const int elementId_brake = 2; // Metadata: 0x0234D5A1
		public const int elementId_clutch = 3; // Metadata: 0x0234D5A2
		public const int elementId_shiftDown = 4; // Metadata: 0x0234D5A3
		public const int elementId_shiftUp = 5; // Metadata: 0x0234D5A4
		public const int elementId_wheelButton1 = 6; // Metadata: 0x0234D5A5
		public const int elementId_wheelButton2 = 7; // Metadata: 0x0234D5A6
		public const int elementId_wheelButton3 = 8; // Metadata: 0x0234D5A7
		public const int elementId_wheelButton4 = 9; // Metadata: 0x0234D5A8
		public const int elementId_wheelButton5 = 10; // Metadata: 0x0234D5A9
		public const int elementId_wheelButton6 = 11; // Metadata: 0x0234D5AA
		public const int elementId_wheelButton7 = 12; // Metadata: 0x0234D5AB
		public const int elementId_wheelButton8 = 13; // Metadata: 0x0234D5AC
		public const int elementId_wheelButton9 = 14; // Metadata: 0x0234D5AD
		public const int elementId_wheelButton10 = 15; // Metadata: 0x0234D5AE
		public const int elementId_consoleButton1 = 16; // Metadata: 0x0234D5AF
		public const int elementId_consoleButton2 = 17; // Metadata: 0x0234D5B0
		public const int elementId_consoleButton3 = 18; // Metadata: 0x0234D5B1
		public const int elementId_consoleButton4 = 19; // Metadata: 0x0234D5B2
		public const int elementId_consoleButton5 = 20; // Metadata: 0x0234D5B3
		public const int elementId_consoleButton6 = 21; // Metadata: 0x0234D5B4
		public const int elementId_consoleButton7 = 22; // Metadata: 0x0234D5B5
		public const int elementId_consoleButton8 = 23; // Metadata: 0x0234D5B6
		public const int elementId_consoleButton9 = 24; // Metadata: 0x0234D5B7
		public const int elementId_consoleButton10 = 25; // Metadata: 0x0234D5B8
		public const int elementId_shifter1 = 26; // Metadata: 0x0234D5B9
		public const int elementId_shifter2 = 27; // Metadata: 0x0234D5BA
		public const int elementId_shifter3 = 28; // Metadata: 0x0234D5BB
		public const int elementId_shifter4 = 29; // Metadata: 0x0234D5BC
		public const int elementId_shifter5 = 30; // Metadata: 0x0234D5BD
		public const int elementId_shifter6 = 31; // Metadata: 0x0234D5BE
		public const int elementId_shifter7 = 32; // Metadata: 0x0234D5BF
		public const int elementId_shifter8 = 33; // Metadata: 0x0234D5C0
		public const int elementId_shifter9 = 34; // Metadata: 0x0234D5C1
		public const int elementId_shifter10 = 35; // Metadata: 0x0234D5C2
		public const int elementId_reverseGear = 44; // Metadata: 0x0234D5C3
		public const int elementId_select = 36; // Metadata: 0x0234D5C4
		public const int elementId_start = 37; // Metadata: 0x0234D5C5
		public const int elementId_systemButton = 38; // Metadata: 0x0234D5C6
		public const int elementId_horn = 43; // Metadata: 0x0234D5C7
		public const int elementId_dPadUp = 39; // Metadata: 0x0234D5C8
		public const int elementId_dPadRight = 40; // Metadata: 0x0234D5C9
		public const int elementId_dPadDown = 41; // Metadata: 0x0234D5CA
		public const int elementId_dPadLeft = 42; // Metadata: 0x0234D5CB
		public const int elementId_dPad = 45; // Metadata: 0x0234D5CC
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get; } // 0x000000018A9CC8C0-0x000000018A9CC8FC 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get; } // 0x000000018A9CBE80-0x000000018A9CBEC0 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get; } // 0x000000018A9CBEC0-0x000000018A9CBF00 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get; } // 0x000000018A9CBF00-0x000000018A9CBF40 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get; } // 0x000000018A9CC2C0-0x000000018A9CC300 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get; } // 0x000000018A9CC300-0x000000018A9CC340 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get; } // 0x000000018A9CC680-0x000000018A9CC6C0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get; } // 0x000000018A9CC6C0-0x000000018A9CC700 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get; } // 0x000000018A9CC700-0x000000018A9CC740 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get; } // 0x000000018A9CC740-0x000000018A9CC780 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get; } // 0x000000018A9CC780-0x000000018A9CC7C0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get; } // 0x000000018A9CC7C0-0x000000018A9CC800 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get; } // 0x000000018A9CC800-0x000000018A9CC840 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get; } // 0x000000018A9CC840-0x000000018A9CC880 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get; } // 0x000000018A9CC880-0x000000018A9CC8C0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get; } // 0x000000018A9CC640-0x000000018A9CC680 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get; } // 0x000000018A9CBF80-0x000000018A9CBFC0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get; } // 0x000000018A9CBFC0-0x000000018A9CC000 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get; } // 0x000000018A9CC000-0x000000018A9CC040 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get; } // 0x000000018A9CC040-0x000000018A9CC080 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get; } // 0x000000018A9CC080-0x000000018A9CC0C0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get; } // 0x000000018A9CC0C0-0x000000018A9CC100 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get; } // 0x000000018A9CC100-0x000000018A9CC140 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get; } // 0x000000018A9CC140-0x000000018A9CC180 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get; } // 0x000000018A9CC180-0x000000018A9CC1C0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get; } // 0x000000018A9CBF40-0x000000018A9CBF80 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get; } // 0x000000018A9CC380-0x000000018A9CC3C0 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get; } // 0x000000018A9CC3C0-0x000000018A9CC400 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get; } // 0x000000018A9CC400-0x000000018A9CC440 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get; } // 0x000000018A9CC440-0x000000018A9CC480 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get; } // 0x000000018A9CC480-0x000000018A9CC4C0 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get; } // 0x000000018A9CC4C0-0x000000018A9CC500 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get; } // 0x000000018A9CC500-0x000000018A9CC540 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get; } // 0x000000018A9CC540-0x000000018A9CC580 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get; } // 0x000000018A9CC580-0x000000018A9CC5C0 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get; } // 0x000000018A9CC340-0x000000018A9CC380 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get; } // 0x000000018A9CC240-0x000000018A9CC280 
		IControllerTemplateButton IRacingWheelTemplate.select { get; } // 0x000000018A9CC280-0x000000018A9CC2C0 
		IControllerTemplateButton IRacingWheelTemplate.start { get; } // 0x000000018A9CC5C0-0x000000018A9CC600 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get; } // 0x000000018A9CC600-0x000000018A9CC640 
		IControllerTemplateButton IRacingWheelTemplate.horn { get; } // 0x000000018A9CC200-0x000000018A9CC240 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get; } // 0x000000018A9CC1C0-0x000000018A9CC200 
	
		// Constructors
		public RacingWheelTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static RacingWheelTemplate(); // 0x000000018A9CC8FC-0x000000018A9CC960
	}

	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 60367
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x0234D5CD
		public const int elementId_stickY = 1; // Metadata: 0x0234D5CE
		public const int elementId_stickRotate = 2; // Metadata: 0x0234D5CF
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x0234D5D0
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x0234D5D2
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x0234D5D4
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x0234D5D6
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x0234D5D8
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x0234D5DA
		public const int elementId_stickTrigger = 3; // Metadata: 0x0234D5DC
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x0234D5DD
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x0234D5DE
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x0234D5DF
		public const int elementId_stickButton1 = 6; // Metadata: 0x0234D5E1
		public const int elementId_stickButton2 = 7; // Metadata: 0x0234D5E2
		public const int elementId_stickButton3 = 8; // Metadata: 0x0234D5E3
		public const int elementId_stickButton4 = 9; // Metadata: 0x0234D5E4
		public const int elementId_stickButton5 = 10; // Metadata: 0x0234D5E5
		public const int elementId_stickButton6 = 11; // Metadata: 0x0234D5E6
		public const int elementId_stickButton7 = 12; // Metadata: 0x0234D5E7
		public const int elementId_stickButton8 = 13; // Metadata: 0x0234D5E8
		public const int elementId_stickButton9 = 14; // Metadata: 0x0234D5E9
		public const int elementId_stickButton10 = 15; // Metadata: 0x0234D5EA
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x0234D5EB
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x0234D5EC
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x0234D5ED
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x0234D5EE
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x0234D5EF
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x0234D5F0
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x0234D5F1
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x0234D5F2
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x0234D5F3
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x0234D5F4
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x0234D5F5
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x0234D5F7
		public const int elementId_stickHat1Up = 28; // Metadata: 0x0234D5F9
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x0234D5FA
		public const int elementId_stickHat1Right = 30; // Metadata: 0x0234D5FB
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x0234D5FC
		public const int elementId_stickHat1Down = 32; // Metadata: 0x0234D5FD
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x0234D5FE
		public const int elementId_stickHat1Left = 34; // Metadata: 0x0234D5FF
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x0234D600
		public const int elementId_stickHat2Up = 36; // Metadata: 0x0234D601
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x0234D602
		public const int elementId_stickHat2Right = 38; // Metadata: 0x0234D603
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x0234D604
		public const int elementId_stickHat2Down = 40; // Metadata: 0x0234D605
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x0234D606
		public const int elementId_stickHat2Left = 42; // Metadata: 0x0234D607
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x0234D608
		public const int elementId_stickHat3Up = 84; // Metadata: 0x0234D609
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x0234D60B
		public const int elementId_stickHat3Right = 86; // Metadata: 0x0234D60D
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x0234D60F
		public const int elementId_stickHat3Down = 88; // Metadata: 0x0234D611
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x0234D613
		public const int elementId_stickHat3Left = 90; // Metadata: 0x0234D615
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x0234D617
		public const int elementId_stickHat4Up = 92; // Metadata: 0x0234D619
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x0234D61B
		public const int elementId_stickHat4Right = 94; // Metadata: 0x0234D61D
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x0234D61F
		public const int elementId_stickHat4Down = 96; // Metadata: 0x0234D621
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x0234D623
		public const int elementId_stickHat4Left = 98; // Metadata: 0x0234D625
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x0234D627
		public const int elementId_mode1 = 44; // Metadata: 0x0234D629
		public const int elementId_mode2 = 45; // Metadata: 0x0234D62A
		public const int elementId_mode3 = 46; // Metadata: 0x0234D62B
		public const int elementId_throttle1Axis = 49; // Metadata: 0x0234D62C
		public const int elementId_throttle2Axis = 155; // Metadata: 0x0234D62D
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x0234D62F
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x0234D631
		public const int elementId_throttleButton1 = 50; // Metadata: 0x0234D633
		public const int elementId_throttleButton2 = 51; // Metadata: 0x0234D634
		public const int elementId_throttleButton3 = 52; // Metadata: 0x0234D635
		public const int elementId_throttleButton4 = 53; // Metadata: 0x0234D636
		public const int elementId_throttleButton5 = 54; // Metadata: 0x0234D637
		public const int elementId_throttleButton6 = 55; // Metadata: 0x0234D638
		public const int elementId_throttleButton7 = 56; // Metadata: 0x0234D639
		public const int elementId_throttleButton8 = 57; // Metadata: 0x0234D63A
		public const int elementId_throttleButton9 = 58; // Metadata: 0x0234D63B
		public const int elementId_throttleButton10 = 59; // Metadata: 0x0234D63C
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x0234D63D
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x0234D63E
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x0234D63F
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x0234D640
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x0234D641
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x0234D643
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x0234D645
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x0234D647
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x0234D649
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x0234D64B
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x0234D64D
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x0234D64F
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x0234D651
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x0234D653
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x0234D655
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x0234D657
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x0234D659
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x0234D65B
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x0234D65D
		public const int elementId_throttleDial1 = 74; // Metadata: 0x0234D65F
		public const int elementId_throttleDial2 = 142; // Metadata: 0x0234D661
		public const int elementId_throttleDial3 = 143; // Metadata: 0x0234D663
		public const int elementId_throttleDial4 = 144; // Metadata: 0x0234D665
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x0234D667
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x0234D669
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x0234D66B
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x0234D66D
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x0234D66F
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x0234D671
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x0234D673
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x0234D675
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x0234D677
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x0234D679
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x0234D67B
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x0234D67D
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x0234D67F
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x0234D681
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x0234D683
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x0234D685
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x0234D687
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x0234D689
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x0234D68B
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x0234D68D
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x0234D68F
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x0234D691
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x0234D693
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x0234D695
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x0234D697
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x0234D699
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x0234D69B
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x0234D69D
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x0234D69F
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x0234D6A1
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x0234D6A3
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x0234D6A5
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x0234D6A7
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x0234D6A9
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x0234D6AB
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x0234D6AD
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x0234D6AF
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x0234D6B1
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x0234D6B3
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x0234D6B5
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x0234D6B7
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x0234D6B9
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x0234D6BB
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x0234D6BD
		public const int elementId_leftPedal = 168; // Metadata: 0x0234D6BF
		public const int elementId_rightPedal = 169; // Metadata: 0x0234D6C1
		public const int elementId_slidePedals = 170; // Metadata: 0x0234D6C3
		public const int elementId_stick = 171; // Metadata: 0x0234D6C5
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x0234D6C7
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x0234D6C9
		public const int elementId_stickHat1 = 174; // Metadata: 0x0234D6CB
		public const int elementId_stickHat2 = 175; // Metadata: 0x0234D6CD
		public const int elementId_stickHat3 = 176; // Metadata: 0x0234D6CF
		public const int elementId_stickHat4 = 177; // Metadata: 0x0234D6D1
		public const int elementId_throttle1 = 178; // Metadata: 0x0234D6D3
		public const int elementId_throttle2 = 179; // Metadata: 0x0234D6D5
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x0234D6D7
		public const int elementId_throttleHat1 = 181; // Metadata: 0x0234D6D9
		public const int elementId_throttleHat2 = 182; // Metadata: 0x0234D6DB
		public const int elementId_throttleHat3 = 183; // Metadata: 0x0234D6DD
		public const int elementId_throttleHat4 = 184; // Metadata: 0x0234D6DF
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get; } // 0x000000018A9CA460-0x000000018A9CA4A0 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get; } // 0x000000018A9CA420-0x000000018A9CA460 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get; } // 0x000000018A9CA3A0-0x000000018A9CA3E0 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get; } // 0x000000018A9CA3E0-0x000000018A9CA420 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get; } // 0x000000018A9C9FE0-0x000000018A9CA020 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get; } // 0x000000018A9CA020-0x000000018A9CA060 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get; } // 0x000000018A9CA060-0x000000018A9CA0A0 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get; } // 0x000000018A9CA0A0-0x000000018A9CA0E0 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get; } // 0x000000018A9CA0E0-0x000000018A9CA120 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get; } // 0x000000018A9CA120-0x000000018A9CA160 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get; } // 0x000000018A9CA160-0x000000018A9CA1A0 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get; } // 0x000000018A9CA1A0-0x000000018A9CA1E0 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get; } // 0x000000018A9CA1E0-0x000000018A9CA220 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get; } // 0x000000018A9C9FA0-0x000000018A9C9FE0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get; } // 0x000000018A9C9D60-0x000000018A9C9DA0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get; } // 0x000000018A9C9DA0-0x000000018A9C9DE0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get; } // 0x000000018A9C9DE0-0x000000018A9C9E20 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get; } // 0x000000018A9C9E20-0x000000018A9C9E60 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get; } // 0x000000018A9C9E60-0x000000018A9C9EA0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get; } // 0x000000018A9C9EA0-0x000000018A9C9EE0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get; } // 0x000000018A9C9EE0-0x000000018A9C9F20 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get; } // 0x000000018A9C9F20-0x000000018A9C9F60 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get; } // 0x000000018A9C9F60-0x000000018A9C9FA0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get; } // 0x000000018A9C9CA0-0x000000018A9C9CE0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get; } // 0x000000018A9C9CE0-0x000000018A9C9D20 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get; } // 0x000000018A9C9D20-0x000000018A9C9D60 
		IControllerTemplateButton IHOTASTemplate.mode1 { get; } // 0x000000018A9C9B60-0x000000018A9C9BA0 
		IControllerTemplateButton IHOTASTemplate.mode2 { get; } // 0x000000018A9C9BA0-0x000000018A9C9BE0 
		IControllerTemplateButton IHOTASTemplate.mode3 { get; } // 0x000000018A9C9BE0-0x000000018A9C9C20 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get; } // 0x000000018A9CA960-0x000000018A9CA9A0 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get; } // 0x000000018A9CA9A0-0x000000018A9CA9E0 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get; } // 0x000000018A9CA9E0-0x000000018A9CAA20 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get; } // 0x000000018A9CAA20-0x000000018A9CAA60 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get; } // 0x000000018A9CAA60-0x000000018A9CAAA0 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get; } // 0x000000018A9CAAA0-0x000000018A9CAAE0 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get; } // 0x000000018A9CAAE0-0x000000018A9CAB20 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get; } // 0x000000018A9CAB20-0x000000018A9CAB60 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get; } // 0x000000018A9CAB60-0x000000018A9CABA0 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get; } // 0x000000018A9CA920-0x000000018A9CA960 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get; } // 0x000000018A9CA6E0-0x000000018A9CA720 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get; } // 0x000000018A9CA720-0x000000018A9CA760 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get; } // 0x000000018A9CA760-0x000000018A9CA7A0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get; } // 0x000000018A9CA7A0-0x000000018A9CA7E0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get; } // 0x000000018A9CA7E0-0x000000018A9CA820 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get; } // 0x000000018A9CA820-0x000000018A9CA860 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get; } // 0x000000018A9CA860-0x000000018A9CA8A0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get; } // 0x000000018A9CA8A0-0x000000018A9CA8E0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get; } // 0x000000018A9CA8E0-0x000000018A9CA920 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get; } // 0x000000018A9CA560-0x000000018A9CA5A0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get; } // 0x000000018A9CA5A0-0x000000018A9CA5E0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get; } // 0x000000018A9CA5E0-0x000000018A9CA620 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get; } // 0x000000018A9CA620-0x000000018A9CA660 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get; } // 0x000000018A9CA660-0x000000018A9CA6A0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get; } // 0x000000018A9CA6A0-0x000000018A9CA6E0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get; } // 0x000000018A9CADE0-0x000000018A9CAE20 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get; } // 0x000000018A9CAE20-0x000000018A9CAE60 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get; } // 0x000000018A9CAE60-0x000000018A9CAEA0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get; } // 0x000000018A9CAEA0-0x000000018A9CAEE0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get; } // 0x000000018A9CABA0-0x000000018A9CABE0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get; } // 0x000000018A9CABE0-0x000000018A9CAC20 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get; } // 0x000000018A9CAC20-0x000000018A9CAC60 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get; } // 0x000000018A9CAC60-0x000000018A9CACA0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get; } // 0x000000018A9CAF20-0x000000018A9CAF60 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get; } // 0x000000018A9CAEE0-0x000000018A9CAF20 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get; } // 0x000000018A9CAF60-0x000000018A9CAFA0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get; } // 0x000000018A9CAFE0-0x000000018A9CB020 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get; } // 0x000000018A9CAFA0-0x000000018A9CAFE0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get; } // 0x000000018A9CB020-0x000000018A9CB060 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get; } // 0x000000018A9CB0A0-0x000000018A9CB0E0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get; } // 0x000000018A9CB060-0x000000018A9CB0A0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get; } // 0x000000018A9CB0E0-0x000000018A9CB120 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get; } // 0x000000018A9C9B20-0x000000018A9C9B60 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get; } // 0x000000018A9C9C20-0x000000018A9C9C60 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get; } // 0x000000018A9C9C60-0x000000018A9C9CA0 
		IControllerTemplateStick IHOTASTemplate.stick { get; } // 0x000000018A9CA4A0-0x000000018A9CA4E0 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get; } // 0x000000018A9CA320-0x000000018A9CA360 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get; } // 0x000000018A9CA360-0x000000018A9CA3A0 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get; } // 0x000000018A9CA220-0x000000018A9CA260 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get; } // 0x000000018A9CA260-0x000000018A9CA2A0 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get; } // 0x000000018A9CA2A0-0x000000018A9CA2E0 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get; } // 0x000000018A9CA2E0-0x000000018A9CA320 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get; } // 0x000000018A9CA4E0-0x000000018A9CA520 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get; } // 0x000000018A9CA520-0x000000018A9CA560 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get; } // 0x000000018A9CADA0-0x000000018A9CADE0 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get; } // 0x000000018A9CACA0-0x000000018A9CACE0 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get; } // 0x000000018A9CACE0-0x000000018A9CAD20 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get; } // 0x000000018A9CAD20-0x000000018A9CAD60 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get; } // 0x000000018A9CAD60-0x000000018A9CADA0 
	
		// Constructors
		public HOTASTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static HOTASTemplate(); // 0x000000018A9CB120-0x000000018A9CB184
	}

	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 60368
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x0234D6E1
		public const int elementId_yokeZ = 1; // Metadata: 0x0234D6E2
		public const int elementId_leftPaddle = 59; // Metadata: 0x0234D6E3
		public const int elementId_rightPaddle = 60; // Metadata: 0x0234D6E4
		public const int elementId_lever1Axis = 2; // Metadata: 0x0234D6E5
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x0234D6E6
		public const int elementId_lever2Axis = 3; // Metadata: 0x0234D6E8
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x0234D6E9
		public const int elementId_lever3Axis = 4; // Metadata: 0x0234D6EB
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x0234D6EC
		public const int elementId_lever4Axis = 5; // Metadata: 0x0234D6EE
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x0234D6EF
		public const int elementId_lever5Axis = 6; // Metadata: 0x0234D6F1
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x0234D6F2
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x0234D6F4
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x0234D6F5
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x0234D6F6
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x0234D6F7
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x0234D6F8
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x0234D6F9
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x0234D6FA
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x0234D6FB
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x0234D6FC
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x0234D6FD
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x0234D6FE
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x0234D6FF
		public const int elementId_centerButton1 = 19; // Metadata: 0x0234D700
		public const int elementId_centerButton2 = 20; // Metadata: 0x0234D701
		public const int elementId_centerButton3 = 21; // Metadata: 0x0234D702
		public const int elementId_centerButton4 = 22; // Metadata: 0x0234D703
		public const int elementId_centerButton5 = 23; // Metadata: 0x0234D704
		public const int elementId_centerButton6 = 24; // Metadata: 0x0234D705
		public const int elementId_centerButton7 = 25; // Metadata: 0x0234D706
		public const int elementId_centerButton8 = 26; // Metadata: 0x0234D707
		public const int elementId_wheel1Up = 53; // Metadata: 0x0234D708
		public const int elementId_wheel1Down = 54; // Metadata: 0x0234D709
		public const int elementId_wheel1Press = 55; // Metadata: 0x0234D70A
		public const int elementId_wheel2Up = 56; // Metadata: 0x0234D70B
		public const int elementId_wheel2Down = 57; // Metadata: 0x0234D70C
		public const int elementId_wheel2Press = 58; // Metadata: 0x0234D70D
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x0234D70E
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x0234D70F
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x0234D710
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x0234D711
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x0234D712
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x0234D713
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x0234D714
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x0234D715
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x0234D716
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x0234D717
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x0234D718
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x0234D719
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x0234D71A
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x0234D71B
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x0234D71C
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x0234D71D
		public const int elementId_consoleButton1 = 43; // Metadata: 0x0234D71E
		public const int elementId_consoleButton2 = 44; // Metadata: 0x0234D71F
		public const int elementId_consoleButton3 = 45; // Metadata: 0x0234D720
		public const int elementId_consoleButton4 = 46; // Metadata: 0x0234D721
		public const int elementId_consoleButton5 = 47; // Metadata: 0x0234D722
		public const int elementId_consoleButton6 = 48; // Metadata: 0x0234D723
		public const int elementId_consoleButton7 = 49; // Metadata: 0x0234D724
		public const int elementId_consoleButton8 = 50; // Metadata: 0x0234D725
		public const int elementId_consoleButton9 = 51; // Metadata: 0x0234D726
		public const int elementId_consoleButton10 = 52; // Metadata: 0x0234D727
		public const int elementId_mode1 = 61; // Metadata: 0x0234D728
		public const int elementId_mode2 = 62; // Metadata: 0x0234D729
		public const int elementId_mode3 = 63; // Metadata: 0x0234D72A
		public const int elementId_yoke = 69; // Metadata: 0x0234D72B
		public const int elementId_lever1 = 70; // Metadata: 0x0234D72D
		public const int elementId_lever2 = 71; // Metadata: 0x0234D72F
		public const int elementId_lever3 = 72; // Metadata: 0x0234D731
		public const int elementId_lever4 = 73; // Metadata: 0x0234D733
		public const int elementId_lever5 = 74; // Metadata: 0x0234D735
		public const int elementId_leftGripHat = 75; // Metadata: 0x0234D737
		public const int elementId_rightGripHat = 76; // Metadata: 0x0234D739
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get; } // 0x000000018A9C8D18-0x000000018A9C8D58 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get; } // 0x000000018A9C9118-0x000000018A9C9158 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get; } // 0x000000018A9C8B58-0x000000018A9C8B98 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get; } // 0x000000018A9C8B98-0x000000018A9C8BD8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get; } // 0x000000018A9C8BD8-0x000000018A9C8C18 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get; } // 0x000000018A9C8C18-0x000000018A9C8C58 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get; } // 0x000000018A9C8C58-0x000000018A9C8C98 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get; } // 0x000000018A9C8C98-0x000000018A9C8CD8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get; } // 0x000000018A9C8F58-0x000000018A9C8F98 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get; } // 0x000000018A9C8F98-0x000000018A9C8FD8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get; } // 0x000000018A9C8FD8-0x000000018A9C9018 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get; } // 0x000000018A9C9018-0x000000018A9C9058 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get; } // 0x000000018A9C9058-0x000000018A9C9098 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get; } // 0x000000018A9C9098-0x000000018A9C90D8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get; } // 0x000000018A9C86D8-0x000000018A9C8718 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get; } // 0x000000018A9C8718-0x000000018A9C8758 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get; } // 0x000000018A9C8758-0x000000018A9C8798 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get; } // 0x000000018A9C8798-0x000000018A9C87D8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get; } // 0x000000018A9C87D8-0x000000018A9C8818 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get; } // 0x000000018A9C8818-0x000000018A9C8858 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get; } // 0x000000018A9C8858-0x000000018A9C8898 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get; } // 0x000000018A9C8898-0x000000018A9C88D8 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get; } // 0x000000018A9C91D8-0x000000018A9C9218 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get; } // 0x000000018A9C9158-0x000000018A9C9198 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get; } // 0x000000018A9C9198-0x000000018A9C91D8 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get; } // 0x000000018A9C9298-0x000000018A9C92D8 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get; } // 0x000000018A9C9218-0x000000018A9C9258 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get; } // 0x000000018A9C9258-0x000000018A9C9298 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get; } // 0x000000018A9C8918-0x000000018A9C8958 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get; } // 0x000000018A9C8958-0x000000018A9C8998 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get; } // 0x000000018A9C8998-0x000000018A9C89D8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get; } // 0x000000018A9C89D8-0x000000018A9C8A18 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get; } // 0x000000018A9C8A18-0x000000018A9C8A58 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get; } // 0x000000018A9C8A58-0x000000018A9C8A98 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get; } // 0x000000018A9C8A98-0x000000018A9C8AD8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get; } // 0x000000018A9C8AD8-0x000000018A9C8B18 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get; } // 0x000000018A9C8B18-0x000000018A9C8B58 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get; } // 0x000000018A9C88D8-0x000000018A9C8918 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get; } // 0x000000018A9C8E98-0x000000018A9C8ED8 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get; } // 0x000000018A9C8ED8-0x000000018A9C8F18 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get; } // 0x000000018A9C8F18-0x000000018A9C8F58 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get; } // 0x000000018A9C92D8-0x000000018A9C9318 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get; } // 0x000000018A9C8D58-0x000000018A9C8D98 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get; } // 0x000000018A9C8D98-0x000000018A9C8DD8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get; } // 0x000000018A9C8DD8-0x000000018A9C8E18 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get; } // 0x000000018A9C8E18-0x000000018A9C8E58 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get; } // 0x000000018A9C8E58-0x000000018A9C8E98 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get; } // 0x000000018A9C8CD8-0x000000018A9C8D18 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get; } // 0x000000018A9C90D8-0x000000018A9C9118 
	
		// Constructors
		public FlightYokeTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static FlightYokeTemplate(); // 0x000000018A9C9318-0x000000018A9C937C
	}

	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 60369
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x0234D73B
		public const int elementId_rightPedal = 1; // Metadata: 0x0234D73C
		public const int elementId_slide = 2; // Metadata: 0x0234D73D
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get; } // 0x000000018A9C85B0-0x000000018A9C85EC 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get; } // 0x000000018A9C85EC-0x000000018A9C862C 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get; } // 0x000000018A9C862C-0x000000018A9C866C 
	
		// Constructors
		public FlightPedalsTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static FlightPedalsTemplate(); // 0x000000018A9C866C-0x000000018A9C86D0
	}

	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 60370
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x0234D73E
		public const int elementId_positionY = 2; // Metadata: 0x0234D73F
		public const int elementId_positionZ = 0; // Metadata: 0x0234D740
		public const int elementId_rotationX = 3; // Metadata: 0x0234D741
		public const int elementId_rotationY = 5; // Metadata: 0x0234D742
		public const int elementId_rotationZ = 4; // Metadata: 0x0234D743
		public const int elementId_throttle1Axis = 6; // Metadata: 0x0234D744
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x0234D745
		public const int elementId_throttle2Axis = 7; // Metadata: 0x0234D746
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x0234D747
		public const int elementId_extraAxis1 = 8; // Metadata: 0x0234D748
		public const int elementId_extraAxis2 = 9; // Metadata: 0x0234D749
		public const int elementId_extraAxis3 = 10; // Metadata: 0x0234D74A
		public const int elementId_extraAxis4 = 11; // Metadata: 0x0234D74B
		public const int elementId_button1 = 12; // Metadata: 0x0234D74C
		public const int elementId_button2 = 13; // Metadata: 0x0234D74D
		public const int elementId_button3 = 14; // Metadata: 0x0234D74E
		public const int elementId_button4 = 15; // Metadata: 0x0234D74F
		public const int elementId_button5 = 16; // Metadata: 0x0234D750
		public const int elementId_button6 = 17; // Metadata: 0x0234D751
		public const int elementId_button7 = 18; // Metadata: 0x0234D752
		public const int elementId_button8 = 19; // Metadata: 0x0234D753
		public const int elementId_button9 = 20; // Metadata: 0x0234D754
		public const int elementId_button10 = 21; // Metadata: 0x0234D755
		public const int elementId_button11 = 22; // Metadata: 0x0234D756
		public const int elementId_button12 = 23; // Metadata: 0x0234D757
		public const int elementId_button13 = 24; // Metadata: 0x0234D758
		public const int elementId_button14 = 25; // Metadata: 0x0234D759
		public const int elementId_button15 = 26; // Metadata: 0x0234D75A
		public const int elementId_button16 = 27; // Metadata: 0x0234D75B
		public const int elementId_button17 = 28; // Metadata: 0x0234D75C
		public const int elementId_button18 = 29; // Metadata: 0x0234D75D
		public const int elementId_button19 = 30; // Metadata: 0x0234D75E
		public const int elementId_button20 = 31; // Metadata: 0x0234D75F
		public const int elementId_button21 = 55; // Metadata: 0x0234D760
		public const int elementId_button22 = 56; // Metadata: 0x0234D761
		public const int elementId_button23 = 57; // Metadata: 0x0234D762
		public const int elementId_button24 = 58; // Metadata: 0x0234D763
		public const int elementId_button25 = 59; // Metadata: 0x0234D764
		public const int elementId_button26 = 60; // Metadata: 0x0234D765
		public const int elementId_button27 = 61; // Metadata: 0x0234D766
		public const int elementId_button28 = 62; // Metadata: 0x0234D767
		public const int elementId_button29 = 63; // Metadata: 0x0234D768
		public const int elementId_button30 = 64; // Metadata: 0x0234D769
		public const int elementId_button31 = 65; // Metadata: 0x0234D76B
		public const int elementId_button32 = 66; // Metadata: 0x0234D76D
		public const int elementId_hat1Up = 32; // Metadata: 0x0234D76F
		public const int elementId_hat1UpRight = 33; // Metadata: 0x0234D770
		public const int elementId_hat1Right = 34; // Metadata: 0x0234D771
		public const int elementId_hat1DownRight = 35; // Metadata: 0x0234D772
		public const int elementId_hat1Down = 36; // Metadata: 0x0234D773
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x0234D774
		public const int elementId_hat1Left = 38; // Metadata: 0x0234D775
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x0234D776
		public const int elementId_hat2Up = 40; // Metadata: 0x0234D777
		public const int elementId_hat2UpRight = 41; // Metadata: 0x0234D778
		public const int elementId_hat2Right = 42; // Metadata: 0x0234D779
		public const int elementId_hat2DownRight = 43; // Metadata: 0x0234D77A
		public const int elementId_hat2Down = 44; // Metadata: 0x0234D77B
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x0234D77C
		public const int elementId_hat2Left = 46; // Metadata: 0x0234D77D
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x0234D77E
		public const int elementId_hat1 = 48; // Metadata: 0x0234D77F
		public const int elementId_hat2 = 49; // Metadata: 0x0234D780
		public const int elementId_throttle1 = 52; // Metadata: 0x0234D781
		public const int elementId_throttle2 = 53; // Metadata: 0x0234D782
		public const int elementId_stick = 54; // Metadata: 0x0234D783
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get; } // 0x000000018A9D3998-0x000000018A9D39D8 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get; } // 0x000000018A9D39D8-0x000000018A9D3A18 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get; } // 0x000000018A9D3A18-0x000000018A9D3A58 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get; } // 0x000000018A9D3A58-0x000000018A9D3A98 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get; } // 0x000000018A9D3418-0x000000018A9D3458 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get; } // 0x000000018A9D36D8-0x000000018A9D3718 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get; } // 0x000000018A9D37D8-0x000000018A9D3818 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get; } // 0x000000018A9D3818-0x000000018A9D3858 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get; } // 0x000000018A9D3858-0x000000018A9D3898 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get; } // 0x000000018A9D3898-0x000000018A9D38D8 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get; } // 0x000000018A9D38D8-0x000000018A9D3918 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get; } // 0x000000018A9D3918-0x000000018A9D3958 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get; } // 0x000000018A9D3958-0x000000018A9D3998 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get; } // 0x000000018A9D3198-0x000000018A9D31D8 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get; } // 0x000000018A9D31D8-0x000000018A9D3218 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get; } // 0x000000018A9D3218-0x000000018A9D3258 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get; } // 0x000000018A9D3258-0x000000018A9D3298 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get; } // 0x000000018A9D3298-0x000000018A9D32D8 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get; } // 0x000000018A9D32D8-0x000000018A9D3318 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get; } // 0x000000018A9D3318-0x000000018A9D3358 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get; } // 0x000000018A9D3358-0x000000018A9D3398 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get; } // 0x000000018A9D3398-0x000000018A9D33D8 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get; } // 0x000000018A9D33D8-0x000000018A9D3418 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get; } // 0x000000018A9D3458-0x000000018A9D3498 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get; } // 0x000000018A9D3498-0x000000018A9D34D8 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get; } // 0x000000018A9D34D8-0x000000018A9D3518 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get; } // 0x000000018A9D3518-0x000000018A9D3558 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get; } // 0x000000018A9D3558-0x000000018A9D3598 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get; } // 0x000000018A9D3598-0x000000018A9D35D8 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get; } // 0x000000018A9D35D8-0x000000018A9D3618 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get; } // 0x000000018A9D3618-0x000000018A9D3658 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get; } // 0x000000018A9D3658-0x000000018A9D3698 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get; } // 0x000000018A9D3698-0x000000018A9D36D8 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get; } // 0x000000018A9D3718-0x000000018A9D3758 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get; } // 0x000000018A9D3758-0x000000018A9D3798 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get; } // 0x000000018A9D3798-0x000000018A9D37D8 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get; } // 0x000000018A9D3A98-0x000000018A9D3AD8 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get; } // 0x000000018A9D3AD8-0x000000018A9D3B18 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get; } // 0x000000018A9D3B58-0x000000018A9D3B98 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get; } // 0x000000018A9D3B98-0x000000018A9D3BD8 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get; } // 0x000000018A9D3B18-0x000000018A9D3B58 
	
		// Constructors
		public SixDofControllerTemplate(object payload); // 0x000000018A9C86D0-0x000000018A9C86D8
		static SixDofControllerTemplate(); // 0x000000018A9D3BD8-0x000000018A9D3C3C
	}

	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base // TypeDefIndex: 60371
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager(); // 0x0000000184D1C6F0-0x0000000184D1C700
	
		// Methods
		protected override void OnInitialized(); // 0x0000000183FCE990-0x0000000183FCE9A0
		protected override void OnDeinitialized(); // 0x000000018A9CB20C-0x000000018A9CB214
		protected override void DetectPlatform(); // 0x0000000184D30AD0-0x0000000184D30B30
		protected override void CheckRecompile(); // 0x00000001841E1670-0x00000001841E1680
		protected override IExternalTools GetExternalTools(); // 0x0000000184D5E7E0-0x0000000184D5E820
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel); // 0x000000018A9CB184-0x000000018A9CB20C
		private void SubscribeEvents(); // 0x0000000183FCEEE0-0x0000000183FCEF90
		private void UnsubscribeEvents(); // 0x0000000183FCEF90-0x0000000183FCF030
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x0000000183CB71B0-0x0000000183CB71C0
	}
}

namespace Rewired.Data
{
	public class UserDataStore_File : UserDataStore_KeyValue // TypeDefIndex: 60380
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x0234D784
		private const string defaultExtensionText = ".json"; // Metadata: 0x0234D78E
		private const string defaultExtensionBinary = ".bin"; // Metadata: 0x0234D794
		private const string defaultFileName = "RewiredSaveData.json"; // Metadata: 0x0234D799
		[SerializeField]
		[Tooltip("The data file name. Changing this will make saved data already stored with the old file name no longer accessible.")]
		private string _fileName; // 0x38
		[SerializeField]
		[Tooltip("Determines if the file should be stored as binary or text. Changing this will make saved data already stored no longer accessible.")]
		private DataFormat _dataFormat; // 0x40
		[NonSerialized]
		private string __directory; // 0x48
		[NonSerialized]
		private DataStore _dataStore; // 0x50
		[NonSerialized]
		private IDataHandler __dataHandler; // 0x58
		[NonSerialized]
		private bool _initialized; // 0x60
	
		// Properties
		public string directory { get; set; } // 0x000000018A9D4434-0x000000018A9D446C 0x000000018A9D44B0-0x000000018A9D44E0
		public string fileName { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x000000018A9D44E0-0x000000018A9D4510
		public DataFormat dataFormat { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x000000018A9D446C-0x000000018A9D4480
		protected IDataHandler dataHandler { get; set; } // 0x000000018A9D4334-0x000000018A9D4434 0x000000018A9D4480-0x000000018A9D44B0
		protected override IDataStore dataStore { get; } // 0x0000000184D86270-0x0000000184D86280 
	
		// Nested types
		private sealed class DataStore : UserDataStore_KeyValue.IDataStore // TypeDefIndex: 60373
		{
			// Fields
			private Dictionary<string, object> _data; // 0x10
			private readonly string _absFilePath; // 0x18
			private IDataHandler _dataHandler; // 0x20
	
			// Constructors
			public DataStore(string fileName, string absDirectory, IDataHandler dataHandler); // 0x000000018A9C7FAC-0x000000018A9C80DC
	
			// Methods
			public bool TryGetValue(string key, out object value); // 0x000000018A9C7F2C-0x000000018A9C7FAC
			public bool SetValue(string key, object value); // 0x000000018A9C7EB4-0x000000018A9C7F2C
			public bool Save(); // 0x000000018A9C7DB8-0x000000018A9C7EB4
			public bool Load(); // 0x000000018A9C7C0C-0x000000018A9C7DB8
			public bool Clear(); // 0x000000018A9C7AD8-0x000000018A9C7C0C
		}
	
		private sealed class LocalFileDataHandler : IDataHandler // TypeDefIndex: 60374
		{
			// Fields
			private readonly Func<DataFormat> _dataFormatDelegate; // 0x10
			private readonly Codec _codec; // 0x18
	
			// Constructors
			public LocalFileDataHandler(Func<DataFormat> dataFormatDelegate, Codec codec); // 0x000000018A9CB794-0x000000018A9CB864
	
			// Methods
			public bool Load(string absoluteFilePath, out string data); // 0x000000018A9CB3CC-0x000000018A9CB5B0
			public bool Save(string absoluteFilePath, string data); // 0x000000018A9CB5B0-0x000000018A9CB794
			public bool Clear(string absoluteFilePath); // 0x000000018A9CB30C-0x000000018A9CB3CC
		}
	
		private abstract class Codec // TypeDefIndex: 60375
		{
			// Constructors
			protected Codec(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public abstract byte[] Encode(string @string);
			public abstract string Decode(byte[] data);
		}
	
		private sealed class UTF8Text : Codec // TypeDefIndex: 60376
		{
			// Constructors
			public UTF8Text(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override byte[] Encode(string @string); // 0x000000018A9D3EBC-0x000000018A9D3EEC
			public override string Decode(byte[] data); // 0x000000018A9D3E8C-0x000000018A9D3EBC
		}
	
		private sealed class CLZF2 : Codec // TypeDefIndex: 60377
		{
			// Fields
			private readonly Utils.Libraries.CLZF2.CLZF2 _cLZF2; // 0x10
	
			// Constructors
			public CLZF2(); // 0x000000018A9C7574-0x000000018A9C75D8
	
			// Methods
			public override byte[] Encode(string @string); // 0x000000018A9C7524-0x000000018A9C7574
			public override string Decode(byte[] data); // 0x000000018A9C74C8-0x000000018A9C7524
		}
	
		public interface IDataHandler // TypeDefIndex: 60378
		{
			// Methods
			bool Load(string absoluteFilePath, out string data);
			bool Save(string absoluteFilePath, string data);
			bool Clear(string absoluteFilePath);
		}
	
		public enum DataFormat // TypeDefIndex: 60379
		{
			Text = 0,
			Binary = 1
		}
	
		// Constructors
		public UserDataStore_File(); // 0x000000018A9D42D4-0x000000018A9D4334
		static UserDataStore_File(); // 0x000000018A9D423C-0x000000018A9D42D4
	
		// Methods
		protected virtual void SetInitialValues(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnInitialize(); // 0x000000018A9D4218-0x000000018A9D423C
		private void OnDataSourceChanged(); // 0x000000018A9D4148-0x000000018A9D4218
		[CompilerGenerated]
		private DataFormat _get_dataHandler_b__17_0(); // 0x0000000184D865E0-0x0000000184D865F0
	}

	public abstract class UserDataStore_KeyValue : UserDataStore // TypeDefIndex: 60390
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x0234D7B0
		private const string key_controllerAssignments = "ControllerAssignments"; // Metadata: 0x0234D7BA
		private const int controllerMapKeyVersion = 0; // Metadata: 0x0234D7D0
		[SerializeField]
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		private bool _isEnabled; // 0x18
		[SerializeField]
		[Tooltip("Should saved data be loaded on start?")]
		private bool _loadDataOnStart; // 0x19
		[SerializeField]
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		private bool _loadJoystickAssignments; // 0x1A
		[SerializeField]
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		private bool _loadKeyboardAssignments; // 0x1B
		[SerializeField]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool _loadMouseAssignments; // 0x1C
		[NonSerialized]
		private bool _allowImpreciseJoystickAssignmentMatching; // 0x1D
		[NonSerialized]
		private bool _deferredJoystickAssignmentLoadPending; // 0x1E
		[NonSerialized]
		private bool _wasJoystickEverDetected; // 0x1F
		[NonSerialized]
		private List<int> __allActionIds; // 0x20
		[NonSerialized]
		private string __allActionIdsString; // 0x28
		[NonSerialized]
		private readonly StringBuilder _sb; // 0x30
	
		// Properties
		public bool isEnabled { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool loadDataOnStart { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public bool loadJoystickAssignments { get; set; } // 0x00000001815AF940-0x00000001815AF950 0x0000000184D866E0-0x0000000184D866F0
		public bool loadKeyboardAssignments { get; set; } // 0x0000000184D895D0-0x0000000184D895E0 0x0000000184D89600-0x0000000184D89610
		public bool loadMouseAssignments { get; set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
		protected abstract IDataStore dataStore { get; }
		private bool loadControllerAssignments { get; } // 0x000000018A9D9A2C-0x000000018A9D9A40 
		private List<int> allActionIds { get; } // 0x000000018A9D98EC-0x000000018A9D9A2C 
		private string allActionIdsString { get; } // 0x000000018A9D97D4-0x000000018A9D98EC 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 60383
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x0000000183141B90-0x0000000183141BB0 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 60381
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x0000000183BA3DE0-0x0000000183BA3E00 
	
				// Constructors
				public PlayerInfo(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x000000018A9CBB8C-0x000000018A9CBC08
				public bool ContainsJoystick(int joystickId); // 0x000000018A9CBB74-0x000000018A9CBB8C
			}
	
			public class JoystickInfo // TypeDefIndex: 60382
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x00000001841E1670-0x00000001841E1680
			public ControllerAssignmentSaveInfo(int playerCount); // 0x000000018A9C766C-0x000000018A9C7734
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x000000018A9C75F0-0x000000018A9C766C
			public bool ContainsPlayer(int playerId); // 0x000000018A9C75D8-0x000000018A9C75F0
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 60384
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId); // 0x000000018A9CB290-0x000000018A9CB30C
		}
	
		protected interface IDataStore // TypeDefIndex: 60385
		{
			// Methods
			bool Save();
			bool Load();
			bool Clear();
			bool TryGetValue(string key, out object result);
			bool SetValue(string key, object value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 60386
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x); // 0x000000018A98CBF4-0x000000018A98CC14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_1 // TypeDefIndex: 60387
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass71_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x); // 0x000000018A9D3E64-0x000000018A9D3E8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_2 // TypeDefIndex: 60388
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass71_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x); // 0x000000018A98CBF4-0x000000018A98CC14
		}
	
		[CompilerGenerated]
		private sealed class _LoadJoystickAssignmentsDeferred_d__73 : IEnumerator<object> // TypeDefIndex: 60389
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_KeyValue __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _LoadJoystickAssignmentsDeferred_d__73(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A9D3C3C-0x000000018A9D3D04
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9D3D04-0x000000018A9D3D50
		}
	
		// Constructors
		protected UserDataStore_KeyValue(); // 0x000000018A9D9758-0x000000018A9D97D4
		static UserDataStore_KeyValue(); // 0x000000018A9D96C0-0x000000018A9D9758
	
		// Methods
		public override void Save(); // 0x000000018A9D934C-0x000000018A9D9408
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D86D0-0x000000018A9D87B4
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D85FC-0x000000018A9D86D0
		public override void SavePlayerData(int playerId); // 0x000000018A9D928C-0x000000018A9D934C
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x000000018A9D8DE0-0x000000018A9D8EB0
		public override void Load(); // 0x000000018A9D7D84-0x000000018A9D7E40
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D5EE4-0x000000018A9D5FC8
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D5FC8-0x000000018A9D6098
		public override void LoadPlayerData(int playerId); // 0x000000018A9D7CC4-0x000000018A9D7D84
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x000000018A9D664C-0x000000018A9D671C
		protected override void OnInitialize(); // 0x000000018A9D7F18-0x000000018A9D7FA0
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x000000018A9D7E40-0x000000018A9D7EB8
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x000000018A9D7EE8-0x000000018A9D7F18
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x000000018A9D7EB8-0x000000018A9D7EE8
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x000000018A9D898C-0x000000018A9D8A30
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9D61AC-0x000000018A9D626C
		public virtual void ClearSaveData(); // 0x000000018A9D4CC0-0x000000018A9D4D14
		private int LoadAll(); // 0x000000018A9D5B50-0x000000018A9D5C54
		private int LoadPlayerDataNow(int playerId); // 0x000000018A9D7A2C-0x000000018A9D7A9C
		private int LoadPlayerDataNow(Player player); // 0x000000018A9D7A9C-0x000000018A9D7CC4
		private int LoadAllJoystickCalibrationData(); // 0x000000018A9D5A84-0x000000018A9D5B50
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018A9D7574-0x000000018A9D75AC
		private int LoadJoystickCalibrationData(int joystickId); // 0x000000018A9D75AC-0x000000018A9D761C
		private int LoadJoystickData(int joystickId); // 0x000000018A9D761C-0x000000018A9D7764
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D5E58-0x000000018A9D5EC4
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D5EC4-0x000000018A9D5EE4
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D626C-0x000000018A9D64E4
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9D6098-0x000000018A9D61AC
		private int LoadInputBehaviors(int playerId); // 0x000000018A9D671C-0x000000018A9D6844
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x000000018A9D64E4-0x000000018A9D65A8
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018A9D65A8-0x000000018A9D664C
		private bool LoadControllerAssignmentsNow(); // 0x000000018A9D5D98-0x000000018A9D5E58
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018A9D7764-0x000000018A9D7A2C
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018A9D68A0-0x000000018A9D7574
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x000000018A9D5C54-0x000000018A9D5D98
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__73))]
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x000000018A9D6844-0x000000018A9D68A0
		private void SaveAll(); // 0x000000018A9D80D8-0x000000018A9D81D4
		private void SavePlayerDataNow(int playerId); // 0x000000018A9D9204-0x000000018A9D928C
		private void SavePlayerDataNow(Player player); // 0x000000018A9D9140-0x000000018A9D9204
		private void SaveAllJoystickCalibrationData(); // 0x000000018A9D801C-0x000000018A9D80D8
		private void SaveJoystickCalibrationData(int joystickId); // 0x000000018A9D8F1C-0x000000018A9D8F8C
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018A9D8F8C-0x000000018A9D9020
		private void SaveJoystickData(int joystickId); // 0x000000018A9D9020-0x000000018A9D9140
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D85A0-0x000000018A9D85E8
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D85E8-0x000000018A9D85FC
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x000000018A9D8B3C-0x000000018A9D8C90
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9D8A30-0x000000018A9D8B3C
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x000000018A9D87B4-0x000000018A9D898C
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x000000018A9D8EB0-0x000000018A9D8F1C
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x000000018A9D8D04-0x000000018A9D8DE0
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018A9D8C90-0x000000018A9D8D04
		private bool SaveControllerAssignments(); // 0x000000018A9D81D4-0x000000018A9D85A0
		private static void AppendBaseKey(StringBuilder sb, Player player); // 0x000000018A9D4A00-0x000000018A9D4A70
		private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018A9D4F6C-0x000000018A9D5088
		private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018A9D5088-0x000000018A9D51A4
		private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion); // 0x000000018A9D4A70-0x000000018A9D4CC0
		private string GetJoystickCalibrationMapKey(Rewired.Joystick joystick); // 0x000000018A9D58EC-0x000000018A9D5A84
		private string GetInputBehaviorKey(Player player, int inputBehaviorId); // 0x000000018A9D5770-0x000000018A9D5868
		private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9D4E64-0x000000018A9D4F6C
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9D51A4-0x000000018A9D537C
		private string GetJoystickCalibrationMapJson(Rewired.Joystick joystick); // 0x000000018A9D5868-0x000000018A9D58EC
		private string GetInputBehaviorJson(Player player, int id); // 0x000000018A9D56DC-0x000000018A9D5770
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x000000018A9D4510-0x000000018A9D4A00
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x000000018A9D4D14-0x000000018A9D4E64
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches); // 0x000000018A9D9408-0x000000018A9D95BC
		private void RefreshLayoutManager(int playerId); // 0x000000018A9D7FA0-0x000000018A9D801C
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x000000018A9D537C-0x000000018A9D56DC
		private static bool TryGetString(IDataStore store, string key, out string result); // 0x000000018A9D95BC-0x000000018A9D96C0
	}

	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 60399
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x0234D7D1
		private const string logPrefix = "Rewired: "; // Metadata: 0x0234D7EB
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x0234D7F5
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x0234D9C0
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x0234D9D6
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x0234D9D7
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x0234D9D8
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x0234D9D9
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x0234D9DA
		[SerializeField]
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		private bool isEnabled; // 0x18
		[SerializeField]
		[Tooltip("Should saved data be loaded on start?")]
		private bool loadDataOnStart; // 0x19
		[SerializeField]
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		private bool loadJoystickAssignments; // 0x1A
		[SerializeField]
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		private bool loadKeyboardAssignments; // 0x1B
		[SerializeField]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool loadMouseAssignments; // 0x1C
		[SerializeField]
		[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
		private string playerPrefsKeyPrefix; // 0x20
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching; // 0x28
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending; // 0x29
		[NonSerialized]
		private bool wasJoystickEverDetected; // 0x2A
		[NonSerialized]
		private List<int> __allActionIds; // 0x30
		[NonSerialized]
		private string __allActionIdsString; // 0x38
	
		// Properties
		public bool IsEnabled { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool LoadDataOnStart { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public bool LoadJoystickAssignments { get; set; } // 0x00000001815AF940-0x00000001815AF950 0x0000000184D866E0-0x0000000184D866F0
		public bool LoadKeyboardAssignments { get; set; } // 0x0000000184D895D0-0x0000000184D895E0 0x0000000184D89600-0x0000000184D89610
		public bool LoadMouseAssignments { get; set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
		public string PlayerPrefsKeyPrefix { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		private string playerPrefsKey_controllerAssignments { get; } // 0x000000018A9DE92C-0x000000018A9DE9E8 
		private bool loadControllerAssignments { get; } // 0x000000018A9D9A2C-0x000000018A9D9A40 
		private List<int> allActionIds { get; } // 0x000000018A9DE7EC-0x000000018A9DE92C 
		private string allActionIdsString { get; } // 0x000000018A9DE6D4-0x000000018A9DE7EC 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 60393
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x0000000183141B90-0x0000000183141BB0 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 60391
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x0000000183BA3DE0-0x0000000183BA3E00 
	
				// Constructors
				public PlayerInfo(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x000000018A9CBB8C-0x000000018A9CBC08
				public bool ContainsJoystick(int joystickId); // 0x000000018A9CBB74-0x000000018A9CBB8C
			}
	
			public class JoystickInfo // TypeDefIndex: 60392
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x00000001841E1670-0x00000001841E1680
			public ControllerAssignmentSaveInfo(int playerCount); // 0x000000018A9C7734-0x000000018A9C77FC
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x000000018A9C75F0-0x000000018A9C766C
			public bool ContainsPlayer(int playerId); // 0x000000018A9C75D8-0x000000018A9C75F0
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 60394
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId); // 0x000000018A9CB214-0x000000018A9CB290
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0 // TypeDefIndex: 60395
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass78_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x); // 0x000000018A98CBF4-0x000000018A98CC14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_1 // TypeDefIndex: 60396
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass78_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x); // 0x000000018A9D3E64-0x000000018A9D3E8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_2 // TypeDefIndex: 60397
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass78_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x); // 0x000000018A98CBF4-0x000000018A98CC14
		}
	
		[CompilerGenerated]
		private sealed class _LoadJoystickAssignmentsDeferred_d__80 : IEnumerator<object> // TypeDefIndex: 60398
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_PlayerPrefs __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _LoadJoystickAssignmentsDeferred_d__80(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A9D3D50-0x000000018A9D3E18
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9D3E18-0x000000018A9D3E64
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs(); // 0x000000018A9DE67C-0x000000018A9DE6D4
	
		// Methods
		public override void Save(); // 0x000000018A9DE45C-0x000000018A9DE4C8
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DD8EC-0x000000018A9DD984
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DD984-0x000000018A9DDA0C
		public override void SavePlayerData(int playerId); // 0x000000018A9DE3E4-0x000000018A9DE45C
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x000000018A9DDFB0-0x000000018A9DE038
		public override void Load(); // 0x000000018A9DD0FC-0x000000018A9DD168
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DB408-0x000000018A9DB4A0
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DB380-0x000000018A9DB408
		public override void LoadPlayerData(int playerId); // 0x000000018A9DD084-0x000000018A9DD0FC
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x000000018A9DBA54-0x000000018A9DBADC
		protected override void OnInitialize(); // 0x000000018A9DD240-0x000000018A9DD2C8
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x000000018A9DD168-0x000000018A9DD1E0
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x000000018A9DD210-0x000000018A9DD240
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x000000018A9DD1E0-0x000000018A9DD210
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x000000018A9DDA0C-0x000000018A9DDA98
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9DB4A0-0x000000018A9DB560
		private int LoadAll(); // 0x000000018A9DB018-0x000000018A9DB11C
		private int LoadPlayerDataNow(int playerId); // 0x000000018A9DCDEC-0x000000018A9DCE5C
		private int LoadPlayerDataNow(Player player); // 0x000000018A9DCE5C-0x000000018A9DD084
		private int LoadAllJoystickCalibrationData(); // 0x000000018A9DAF4C-0x000000018A9DB018
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018A9DC934-0x000000018A9DC96C
		private int LoadJoystickCalibrationData(int joystickId); // 0x000000018A9DC96C-0x000000018A9DC9DC
		private int LoadJoystickData(int joystickId); // 0x000000018A9DC9DC-0x000000018A9DCB24
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DB2F4-0x000000018A9DB360
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DB360-0x000000018A9DB380
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DB674-0x000000018A9DB8EC
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9DB560-0x000000018A9DB674
		private int LoadInputBehaviors(int playerId); // 0x000000018A9DBADC-0x000000018A9DBC04
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x000000018A9DB990-0x000000018A9DBA54
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018A9DB8EC-0x000000018A9DB990
		private bool LoadControllerAssignmentsNow(); // 0x000000018A9DB234-0x000000018A9DB2F4
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018A9DCB24-0x000000018A9DCDEC
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018A9DBC60-0x000000018A9DC934
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x000000018A9DB11C-0x000000018A9DB234
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__80))]
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x000000018A9DBC04-0x000000018A9DBC60
		private void SaveAll(); // 0x000000018A9DD400-0x000000018A9DD4E4
		private void SavePlayerDataNow(int playerId); // 0x000000018A9DE2A8-0x000000018A9DE320
		private void SavePlayerDataNow(Player player); // 0x000000018A9DE320-0x000000018A9DE3E4
		private void SaveAllJoystickCalibrationData(); // 0x000000018A9DD344-0x000000018A9DD400
		private void SaveJoystickCalibrationData(int joystickId); // 0x000000018A9DE0A4-0x000000018A9DE114
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018A9DE114-0x000000018A9DE188
		private void SaveJoystickData(int joystickId); // 0x000000018A9DE188-0x000000018A9DE2A8
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DD8A0-0x000000018A9DD8EC
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DD87C-0x000000018A9DD8A0
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x000000018A9DDC3C-0x000000018A9DDD90
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018A9DDD90-0x000000018A9DDE9C
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x000000018A9DDA98-0x000000018A9DDC3C
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x000000018A9DE038-0x000000018A9DE0A4
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x000000018A9DDEE8-0x000000018A9DDFB0
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018A9DDE9C-0x000000018A9DDEE8
		private bool SaveControllerAssignments(); // 0x000000018A9DD4E4-0x000000018A9DD87C
		private bool ControllerAssignmentSaveDataExists(); // 0x000000018A9D9F30-0x000000018A9D9F7C
		private string GetBasePlayerPrefsKey(Player player); // 0x000000018A9DA0CC-0x000000018A9DA130
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018A9DA698-0x000000018A9DA760
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018A9DA130-0x000000018A9DA1F8
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018A9DA394-0x000000018A9DA698
		private string GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick); // 0x000000018A9DADA8-0x000000018A9DAED8
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId); // 0x000000018A9DAC98-0x000000018A9DAD24
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9DA880-0x000000018A9DA938
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018A9DA1F8-0x000000018A9DA394
		private string GetJoystickCalibrationMapXml(Rewired.Joystick joystick); // 0x000000018A9DAED8-0x000000018A9DAF4C
		private string GetInputBehaviorXml(Player player, int id); // 0x000000018A9DAD24-0x000000018A9DADA8
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x000000018A9D9A40-0x000000018A9D9F30
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x000000018A9D9F7C-0x000000018A9DA0CC
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches); // 0x000000018A9DE4C8-0x000000018A9DE67C
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x000000018A9DA938-0x000000018A9DAC98
		private void RefreshLayoutManager(int playerId); // 0x000000018A9DD2C8-0x000000018A9DD344
		private static System.Type GetControllerMapType(Rewired.ControllerType controllerType); // 0x000000018A9DA760-0x000000018A9DA880
	}
}

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 60401
	{
		// Fields
		[CompilerGenerated]
		private int _playerId_k__BackingField; // 0x160
		[CompilerGenerated]
		private int _inputSourceIndex_k__BackingField; // 0x164
		[CompilerGenerated]
		private IMouseInputSource _mouseSource_k__BackingField; // 0x168
		[CompilerGenerated]
		private ITouchInputSource _touchSource_k__BackingField; // 0x170
		[CompilerGenerated]
		private PointerEventType _sourceType_k__BackingField; // 0x178
		[CompilerGenerated]
		private int _buttonIndex_k__BackingField; // 0x17C
	
		// Properties
		public int playerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA6C30-0x0000000184DA6C40 0x0000000184DA6C40-0x0000000184DA6C50
		public int inputSourceIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D903F0-0x0000000184D90400 0x0000000184D90470-0x0000000184D90480
		public IMouseInputSource mouseSource { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DF00-0x0000000184D8DF10 0x0000000186B8B954-0x0000000186B8B968
		public ITouchInputSource touchSource { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DEF0-0x0000000184D8DF00 0x0000000186B8B940-0x0000000186B8B954
		public PointerEventType sourceType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA2300-0x0000000184DA2310 0x0000000184DA6C50-0x0000000184DA6C60
		public int buttonIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D92A50-0x0000000184D92A60 0x0000000184D92A60-0x0000000184D92A70
	
		// Constructors
		public PlayerPointerEventData(EventSystem eventSystem); // 0x000000018A9CBE54-0x000000018A9CBE80
	
		// Methods
		public override string ToString(); // 0x000000018A9CBC08-0x000000018A9CBE54
	}

	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem // TypeDefIndex: 60402
	{
		// Fields
		[SerializeField]
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		private bool _alwaysUpdate; // 0x50
	
		// Properties
		public bool alwaysUpdate { get; set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
	
		// Constructors
		public RewiredEventSystem(); // 0x000000018A9CCA9C-0x000000018A9CCAE8
	
		// Methods
		protected override void Update(); // 0x000000018A9CC960-0x000000018A9CCA9C
	}

	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 60407
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x0234D9DB
		public const int kMouseRightId = -2; // Metadata: 0x0234D9DC
		public const int kMouseMiddleId = -3; // Metadata: 0x0234D9DD
		public const int kFakeTouchesId = -4; // Metadata: 0x0234D9DE
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x0234D9DF
		private const int customButtonsMaxCount = 128; // Metadata: 0x0234D9E4
		private const int customButtonsLastId = -2147483392; // Metadata: 0x0234D9E6
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x000000018A9CF360-0x000000018A9CF3C8 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x000000018A9CF3C8-0x000000018A9CF3D0 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x000000018A9CF3C8-0x000000018A9CF3D0 
		protected virtual bool isMouseSupported { get; } // 0x000000018A9CF3D0-0x000000018A9CF484 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 60403
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x000000018A9CBAFC-0x000000018A9CBB74
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x000000018A9CB878-0x000000018A9CB904
			public bool AnyReleasesThisFrame(); // 0x000000018A9CB904-0x000000018A9CB990
			public ButtonState GetButtonState(int button); // 0x000000018A9CB990-0x000000018A9CBAAC
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data); // 0x000000018A9CBAAC-0x000000018A9CBAFC
		}
	
		public class MouseButtonEventData // TypeDefIndex: 60404
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool PressedThisFrame(); // 0x000000018A9CB864-0x000000018A9CB878
			public bool ReleasedThisFrame(); // 0x000000018863E6DC-0x000000018863E6F0
		}
	
		protected class ButtonState // TypeDefIndex: 60405
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public int button { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	
			// Constructors
			public ButtonState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 60406
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get; } // 0x000000018A9D3F9C-0x000000018A9D3FB0 
			int ITouchInputSource.playerId { get; } // 0x000000018A9D3F9C-0x000000018A9D3FB0 
			bool IMouseInputSource.enabled { get; } // 0x000000018A9D3F64-0x000000018A9D3F7C 
			bool IMouseInputSource.locked { get; } // 0x000000018A9D3F7C-0x000000018A9D3F9C 
			int IMouseInputSource.buttonCount { get; } // 0x000000018A9D3F4C-0x000000018A9D3F64 
			Vector2 IMouseInputSource.screenPosition { get; } // 0x000000018A9D3FF0-0x000000018A9D4020 
			Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x000000018A9D3FB0-0x000000018A9D3FF0 
			Vector2 IMouseInputSource.wheelDelta { get; } // 0x000000018A9D4020-0x000000018A9D4038 
			bool ITouchInputSource.touchSupported { get; } // 0x000000018A9D40B4-0x000000018A9D40CC 
			int ITouchInputSource.touchCount { get; } // 0x000000018A9D409C-0x000000018A9D40B4 
	
			// Constructors
			public UnityInputSource(); // 0x0000000184D91890-0x0000000184D918A0
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button); // 0x000000018A9D3EEC-0x000000018A9D3F0C
			bool IMouseInputSource.GetButtonUp(int button); // 0x000000018A9D3F0C-0x000000018A9D3F2C
			bool IMouseInputSource.GetButton(int button); // 0x000000018A9D3F2C-0x000000018A9D3F4C
			Touch ITouchInputSource.GetTouch(int index); // 0x000000018A9D4038-0x000000018A9D409C
			private void TryUpdate(); // 0x000000018A9D40CC-0x000000018A9D4148
		}
	
		// Constructors
		protected RewiredPointerInputModule(); // 0x000000018A9CF25C-0x000000018A9CF360
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse); // 0x000000018A9CE5FC-0x000000018A9CE618
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex); // 0x000000018A9CD648-0x000000018A9CD7E0
		public void RemoveMouseInputSource(IMouseInputSource source); // 0x000000018A9CEB4C-0x000000018A9CEBF4
		public void AddMouseInputSource(IMouseInputSource source); // 0x000000018A9CCAE8-0x000000018A9CCBC4
		public int GetMouseInputSourceCount(int playerId); // 0x000000018A9CD530-0x000000018A9CD648
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex); // 0x000000018A9CE33C-0x000000018A9CE3B0
		public void RemoveTouchInputSource(ITouchInputSource source); // 0x000000018A9CECA0-0x000000018A9CED1C
		public void AddTouchInputSource(ITouchInputSource source); // 0x000000018A9CCBC4-0x000000018A9CCC88
		public int GetTouchInputSourceCount(int playerId); // 0x000000018A9CE314-0x000000018A9CE33C
		protected void ClearMouseInputSources(); // 0x000000018A9CCC88-0x000000018A9CCCD0
		protected abstract bool IsDefaultPlayer(int playerId);
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType); // 0x000000018A9CDFAC-0x000000018A9CE314
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType); // 0x000000018A9CD104-0x000000018A9CD240
		protected void RemovePointerData(PlayerPointerEventData data); // 0x000000018A9CEBF4-0x000000018A9CECA0
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released); // 0x000000018A9CE3B0-0x000000018A9CE5FC
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex); // 0x000000018A9CD7E0-0x000000018A9CDFAC
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType); // 0x000000018A9CD30C-0x000000018A9CD530
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x000000018A9CED1C-0x000000018A9CED5C
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent); // 0x000000018A9CEA68-0x000000018A9CEB4C
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent); // 0x000000018A9CE808-0x000000018A9CEA68
		public override bool IsPointerOverGameObject(int pointerTypeId); // 0x000000018A9CE618-0x000000018A9CE808
		protected void ClearSelection(); // 0x000000018A9CCCD0-0x000000018A9CD028
		public override string ToString(); // 0x000000018A9CEDC8-0x000000018A9CF25C
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018A9CD240-0x000000018A9CD30C
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x000000018A9CD028-0x000000018A9CD104
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId); // 0x000000018A9CED5C-0x000000018A9CEDC8
	}

	public enum PointerEventType // TypeDefIndex: 60408
	{
		Mouse = 0,
		Touch = 1
	}

	[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 60410
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x0234D9ED
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x0234D9FA
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x0234DA05
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x0234DA0E
		[SerializeField]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
		private InputManager_Base rewiredInputManager; // 0x70
		[SerializeField]
		[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
		private bool useAllRewiredGamePlayers; // 0x78
		[SerializeField]
		[Tooltip("Allow the Rewired System Player to control the UI.")]
		private bool useRewiredSystemPlayer; // 0x79
		[SerializeField]
		[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
		private int[] rewiredPlayerIds; // 0x80
		[SerializeField]
		[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
		private bool usePlayingPlayersOnly; // 0x88
		[SerializeField]
		[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
		private List<Rewired.Components.PlayerMouse> playerMice; // 0x90
		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress; // 0x98
		[SerializeField]
		[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
		private bool setActionsById; // 0x99
		[SerializeField]
		[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
		private int horizontalActionId; // 0x9C
		[SerializeField]
		[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
		private int verticalActionId; // 0xA0
		[SerializeField]
		[Tooltip("Id of the Action used to submit.")]
		private int submitActionId; // 0xA4
		[SerializeField]
		[Tooltip("Id of the Action used to cancel.")]
		private int cancelActionId; // 0xA8
		[SerializeField]
		[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
		private string m_HorizontalAxis; // 0xB0
		[SerializeField]
		[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
		private string m_VerticalAxis; // 0xB8
		[SerializeField]
		[Tooltip("Name of the action used to submit.")]
		private string m_SubmitButton; // 0xC0
		[SerializeField]
		[Tooltip("Name of the action used to cancel.")]
		private string m_CancelButton; // 0xC8
		[SerializeField]
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
		private float m_InputActionsPerSecond; // 0xD0
		[SerializeField]
		[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
		private float m_RepeatDelay; // 0xD4
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements.")]
		private bool m_allowMouseInput; // 0xD8
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
		private bool m_allowMouseInputIfTouchSupported; // 0xD9
		[SerializeField]
		[Tooltip("Allows touch input to be used to select elements.")]
		private bool m_allowTouchInput; // 0xDA
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
		private bool m_deselectIfBackgroundClicked; // 0xDB
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
		private bool m_deselectBeforeSelecting; // 0xDC
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[SerializeField]
		[Tooltip("Forces the module to always be active.")]
		private bool m_ForceModuleActive; // 0xDD
		[NonSerialized]
		private int[] playerIds; // 0xE0
		private bool recompiling; // 0xE8
		[NonSerialized]
		private bool isTouchSupported; // 0xE9
		[NonSerialized]
		private double m_PrevActionTime; // 0xF0
		[NonSerialized]
		private Vector2 m_LastMoveVector; // 0xF8
		[NonSerialized]
		private int m_ConsecutiveMoveCount; // 0x100
		[NonSerialized]
		private bool m_HasFocus; // 0x104
	
		// Properties
		public InputManager_Base RewiredInputManager { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public bool UseAllRewiredGamePlayers { get; set; } // 0x0000000184D86F90-0x0000000184D86FA0 0x000000018A9D2DD0-0x000000018A9D2DEC
		public bool UseRewiredSystemPlayer { get; set; } // 0x0000000184D88E40-0x0000000184D88E50 0x000000018A9D2DEC-0x000000018A9D2E08
		public int[] RewiredPlayerIds { get; set; } // 0x000000018A9D2914-0x000000018A9D2964 0x000000018A9D2C3C-0x000000018A9D2CC8
		public bool UsePlayingPlayersOnly { get; set; } // 0x00000001811F2750-0x00000001811F2760 0x00000001811F2760-0x00000001811F2770
		public List<Rewired.Components.PlayerMouse> PlayerMice { get; set; } // 0x000000018A9D289C-0x000000018A9D2914 0x000000018A9D2B80-0x000000018A9D2C3C
		public bool MoveOneElementPerAxisPress { get; set; } // 0x0000000184D86C50-0x0000000184D86C60 0x0000000184D86C70-0x0000000184D86C80
		public bool allowMouseInput { get; set; } // 0x0000000184DA6C90-0x0000000184DA6CA0 0x0000000184DA6CE0-0x0000000184DA6CF0
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x0000000184DA6C80-0x0000000184DA6C90 0x0000000184DA6CD0-0x0000000184DA6CE0
		public bool allowTouchInput { get; set; } // 0x0000000184DA6CA0-0x0000000184DA6CB0 0x0000000184DA6CF0-0x0000000184DA6D00
		public bool deselectIfBackgroundClicked { get; set; } // 0x0000000184DA6CB0-0x0000000184DA6CC0 0x0000000184DA6D00-0x0000000184DA6D10
		private bool deselectBeforeSelecting { get; set; } // 0x0000000184D90A50-0x0000000184D90A60 0x0000000184D90A60-0x0000000184D90A70
		public bool SetActionsById { get; set; } // 0x0000000184DA34C0-0x0000000184DA34D0 0x000000018A9D2CC8-0x000000018A9D2CE0
		public int HorizontalActionId { get; set; } // 0x0000000184D86C60-0x0000000184D86C70 0x000000018A9D2A90-0x000000018A9D2B80
		public int VerticalActionId { get; set; } // 0x0000000184D88CD0-0x0000000184D88CE0 0x000000018A9D2E08-0x000000018A9D2EF8
		public int SubmitActionId { get; set; } // 0x0000000184D88C90-0x0000000184D88CA0 0x000000018A9D2CE0-0x000000018A9D2DD0
		public int CancelActionId { get; set; } // 0x0000000184D88C80-0x0000000184D88C90 0x000000018A9D29A0-0x000000018A9D2A90
		protected override bool isMouseSupported { get; } // 0x000000018A9D2964-0x000000018A9D29A0 
		private bool isTouchAllowed { get; } // 0x0000000184DA6CA0-0x0000000184DA6CB0 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool allowActivationOnMobileDevice { get; set; } // 0x0000000184DA6C70-0x0000000184DA6C80 0x0000000184DA6CC0-0x0000000184DA6CD0
		public bool forceModuleActive { get; set; } // 0x0000000184DA6C70-0x0000000184DA6C80 0x0000000184DA6CC0-0x0000000184DA6CD0
		public float inputActionsPerSecond { get; set; } // 0x0000000184D8E2E0-0x0000000184D8E2F0 0x0000000184D8E320-0x0000000184D8E330
		public float repeatDelay { get; set; } // 0x0000000184D8E2C0-0x0000000184D8E2D0 0x0000000184D8E300-0x0000000184D8E310
		public string horizontalAxis { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A9D2FA0-0x000000018A9D3048
		public string verticalAxis { get; set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x000000018A9D30F0-0x000000018A9D3198
		public string submitButton { get; set; } // 0x0000000184D892F0-0x0000000184D89300 0x000000018A9D3048-0x000000018A9D30F0
		public string cancelButton { get; set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x000000018A9D2EF8-0x000000018A9D2FA0
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 60409
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting(); // 0x000000018ABD38A0-0x000000018ABD3918
			private PlayerSetting(PlayerSetting other); // 0x000000018ABD3918-0x000000018ABD3B40
	
			// Methods
			public PlayerSetting Clone(); // 0x000000018ABD3840-0x000000018ABD38A0
		}
	
		// Constructors
		private RewiredStandaloneInputModule(); // 0x000000018A9D270C-0x000000018A9D289C
	
		// Methods
		protected override void Awake(); // 0x000000018A9CF53C-0x000000018A9CF620
		public override void UpdateModule(); // 0x000000018A9D26A4-0x000000018A9D270C
		public override bool IsModuleSupported(); // 0x0000000182FFF600-0x0000000182FFF610
		public override bool ShouldActivateModule(); // 0x000000018A9D22C4-0x000000018A9D263C
		public override void ActivateModule(); // 0x000000018A9CF484-0x000000018A9CF53C
		public override void DeactivateModule(); // 0x000000018A9CF828-0x000000018A9CF830
		public override void Process(); // 0x000000018A9D14F0-0x000000018A9D15E0
		private bool ProcessTouchEvents(); // 0x000000018A9D0DE4-0x000000018A9D0F48
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018A9D0F48-0x000000018A9D14F0
		private bool SendSubmitEventToSelectedObject(); // 0x000000018A9D1904-0x000000018A9D1AF4
		private Vector2 GetRawMoveVector(); // 0x000000018A9CFB84-0x000000018A9CFECC
		private bool SendMoveEventToSelectedObject(); // 0x000000018A9D15E0-0x000000018A9D1904
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical); // 0x000000018A9CF620-0x000000018A9CF78C
		private void ProcessMouseEvents(); // 0x000000018A9D0754-0x000000018A9D0894
		private void ProcessMouseEvent(int playerId, int pointerIndex); // 0x000000018A9D0460-0x000000018A9D0754
		private bool SendUpdateEventToSelectedObject(); // 0x000000018A9D1AF4-0x000000018A9D1BC8
		private void ProcessMousePress(MouseButtonEventData data); // 0x000000018A9D0894-0x000000018A9D0DE4
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018A9CFECC-0x000000018A9D0038
		private void OnApplicationFocus(bool hasFocus); // 0x0000000184DA6C60-0x0000000184DA6C70
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x000000018A9D263C-0x000000018A9D26A4
		protected override void OnDestroy(); // 0x000000018A9D032C-0x000000018A9D0440
		protected override bool IsDefaultPlayer(int playerId); // 0x000000018A9D01D0-0x000000018A9D032C
		private void InitializeRewired(); // 0x000000018A9D0038-0x000000018A9D01D0
		private void SetupRewiredVars(); // 0x000000018A9D1F64-0x000000018A9D22C4
		private void SetUpRewiredPlayerMice(); // 0x000000018A9D1E78-0x000000018A9D1F64
		private void SetUpRewiredActions(); // 0x000000018A9D1BC8-0x000000018A9D1E78
		private bool GetButton(Player player, int actionId); // 0x000000018A9CF9C8-0x000000018A9CF9FC
		private bool GetButtonDown(Player player, int actionId); // 0x000000018A9CF994-0x000000018A9CF9C8
		private bool GetNegativeButton(Player player, int actionId); // 0x000000018A9CFB50-0x000000018A9CFB84
		private bool GetNegativeButtonDown(Player player, int actionId); // 0x000000018A9CFB1C-0x000000018A9CFB50
		private float GetAxis(Player player, int actionId); // 0x000000018A9CF960-0x000000018A9CF994
		private void CheckEditorRecompile(); // 0x000000018A9CF78C-0x000000018A9CF7E8
		private void OnEditorRecompile(); // 0x000000018A9D0440-0x000000018A9D0450
		private void ClearRewiredVars(); // 0x000000018A9CF7E8-0x000000018A9CF828
		private bool DidAnyMouseMove(); // 0x000000018A9CF830-0x000000018A9CF960
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex); // 0x000000018A9CF9FC-0x000000018A9CFB1C
		private void OnRewiredInitialized(); // 0x000000018A9D0450-0x000000018A9D0458
		private void OnRewiredShutDown(); // 0x000000018A9D0458-0x000000018A9D0460
	}
}

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 60400
	{
		// Fields
		private static readonly System.Type[] _defaultTemplateTypes; // 0x00
		private static readonly System.Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static System.Type[] templateTypes { get; } // 0x000000018A9C7A88-0x000000018A9C7AD8 
		public static System.Type[] templateInterfaceTypes { get; } // 0x000000018A9C7A38-0x000000018A9C7A88 
	
		// Constructors
		static ControllerTemplateFactory(); // 0x00000001847F2CF0-0x00000001847F3080
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload); // 0x000000018A9C77FC-0x000000018A9C7A38
	}
}

namespace Rewired.Localization
{
	[AddComponentMenu("Rewired/Localization/Localized String Provider")]
	public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 60411
	{
		// Fields
		[SerializeField]
		[Tooltip("A JSON file containing localizied string key value pairs.")]
		private TextAsset _localizedStringsFile; // 0x20
		[NonSerialized]
		private Dictionary<string, string> _dictionary; // 0x28
		[NonSerialized]
		private bool _initialized; // 0x30
	
		// Properties
		protected virtual Dictionary<string, string> dictionary { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public virtual TextAsset localizedStringsFile { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x000000018ABD381C-0x000000018ABD3840
		protected override bool initialized { get; } // 0x0000000184D865F0-0x0000000184D86600 
	
		// Constructors
		public LocalizedStringProvider(); // 0x000000018ABD379C-0x000000018ABD381C
	
		// Methods
		protected override bool Initialize(); // 0x000000018ABD3578-0x000000018ABD3594
		protected virtual bool TryLoadLocalizedStringData(); // 0x000000018ABD3610-0x000000018ABD379C
		protected override bool TryGetLocalizedString(string key, out string result); // 0x000000018ABD3594-0x000000018ABD3610
	}

	public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 60412
	{
		// Fields
		[SerializeField]
		[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
		private bool _prefetch; // 0x18
	
		// Properties
		public virtual bool prefetch { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x000000018ABD34A4-0x000000018ABD3578
		protected abstract bool initialized { get; }
	
		// Constructors
		protected LocalizedStringProviderBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018ABD31A0-0x000000018ABD31D8
		protected virtual void OnDisable(); // 0x000000018ABD30B0-0x000000018ABD31A0
		protected virtual void Update(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void TrySetLocalizedStringProvider(); // 0x000000018ABD32F0-0x000000018ABD34A4
		protected abstract bool Initialize();
		public virtual void Reload(); // 0x000000018ABD31D8-0x000000018ABD32A4
		protected abstract bool TryGetLocalizedString(string key, out string result);
		bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result); // 0x000000018ABD32A4-0x000000018ABD32F0
	}
}

namespace Rewired.Utils
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools // TypeDefIndex: 60372
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
		[CompilerGenerated]
		private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get; set; } // 0x000000018A9C8428-0x000000018A9C8460 0x000000018A9C8560-0x000000018A9C85B0
		public bool isEditorPaused { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public bool UnityInput_IsTouchPressureSupported { get; } // 0x000000018A9C8420-0x000000018A9C8428 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent {
			add; // 0x00000001842B37C0-0x00000001842B3840
			remove; // 0x000000018A9C8460-0x000000018A9C84D4
		}
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange {
			add; // 0x000000018A9C8394-0x000000018A9C8420
			remove; // 0x000000018A9C84D4-0x000000018A9C8560
		}
	
		// Constructors
		public ExternalTools(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Destroy(); // 0x00000001841E1670-0x00000001841E1680
		public object GetPlatformInitializer(); // 0x000000018539494C-0x0000000185394954
		public string GetFocusedEditorWindowTitle(); // 0x000000018A9C81E8-0x000000018A9C8220
		public bool IsEditorSceneViewFocused(); // 0x00000001812081B0-0x0000000181208610
		public bool LinuxInput_IsJoystickPreconfigured(string name); // 0x00000001812081B0-0x0000000181208610
		public int XboxOneInput_GetUserIdForGamepad(uint id); // 0x00000001811EC580-0x00000001811EC590
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId); // 0x00000001811EC580-0x00000001811EC590
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId); // 0x00000001812081B0-0x0000000181208610
		public string XboxOneInput_GetControllerType(ulong xboxControllerId); // 0x000000018A9C835C-0x000000018A9C8394
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId); // 0x00000001811EC580-0x00000001811EC590
		public void XboxOne_Gamepad_UpdatePlugin(); // 0x00000001841E1670-0x00000001841E1680
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel); // 0x00000001812081B0-0x0000000181208610
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS); // 0x00000001841E1670-0x00000001841E1680
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids); // 0x000000018A9C8138-0x000000018A9C81E8
		public int GetAndroidAPILevel(); // 0x0000000184DA2BB0-0x0000000184DA2BC0
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize); // 0x0000000184031BA0-0x0000000184031C00
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic); // 0x000000018A9C8220-0x000000018A9C82B4
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value); // 0x000000018A9C82B4-0x000000018A9C835C
		public float UnityInput_GetTouchPressure(ref Touch touch); // 0x0000000184DA6C20-0x0000000184DA6C30
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch); // 0x0000000184DA6C10-0x0000000184DA6C20
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload); // 0x000000018A9C80DC-0x000000018A9C8138
		public System.Type[] GetControllerTemplateTypes(); // 0x000000018381A8D0-0x000000018381A9A0
		public System.Type[] GetControllerTemplateInterfaceTypes(); // 0x000000018381A9A0-0x000000018381AA40
	}
}
