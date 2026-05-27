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

// Image 49: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56846-56900
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Rewired
{
	public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 56847
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

	public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 56848
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

	public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 56849
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

	public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 56850
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

	public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 56851
	{
		// Properties
		IControllerTemplateAxis leftPedal { get; }
		IControllerTemplateAxis rightPedal { get; }
		IControllerTemplateAxis slide { get; }
	}

	public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 56852
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

	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 56853
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x01FD841C
		public const int elementId_leftStickY = 1; // Metadata: 0x01FD841D
		public const int elementId_rightStickX = 2; // Metadata: 0x01FD841E
		public const int elementId_rightStickY = 3; // Metadata: 0x01FD841F
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x01FD8420
		public const int elementId_a = 4; // Metadata: 0x01FD8421
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x01FD8422
		public const int elementId_b = 5; // Metadata: 0x01FD8423
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x01FD8424
		public const int elementId_c = 6; // Metadata: 0x01FD8425
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x01FD8426
		public const int elementId_x = 7; // Metadata: 0x01FD8427
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x01FD8428
		public const int elementId_y = 8; // Metadata: 0x01FD8429
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x01FD842A
		public const int elementId_z = 9; // Metadata: 0x01FD842B
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x01FD842C
		public const int elementId_leftBumper = 10; // Metadata: 0x01FD842D
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x01FD842E
		public const int elementId_leftTrigger = 11; // Metadata: 0x01FD842F
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x01FD8430
		public const int elementId_rightBumper = 12; // Metadata: 0x01FD8431
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x01FD8432
		public const int elementId_rightTrigger = 13; // Metadata: 0x01FD8433
		public const int elementId_center1 = 14; // Metadata: 0x01FD8434
		public const int elementId_back = 14; // Metadata: 0x01FD8435
		public const int elementId_center2 = 15; // Metadata: 0x01FD8436
		public const int elementId_start = 15; // Metadata: 0x01FD8437
		public const int elementId_center3 = 16; // Metadata: 0x01FD8438
		public const int elementId_guide = 16; // Metadata: 0x01FD8439
		public const int elementId_leftStickButton = 17; // Metadata: 0x01FD843A
		public const int elementId_rightStickButton = 18; // Metadata: 0x01FD843B
		public const int elementId_dPadUp = 19; // Metadata: 0x01FD843C
		public const int elementId_dPadRight = 20; // Metadata: 0x01FD843D
		public const int elementId_dPadDown = 21; // Metadata: 0x01FD843E
		public const int elementId_dPadLeft = 22; // Metadata: 0x01FD843F
		public const int elementId_leftStick = 23; // Metadata: 0x01FD8440
		public const int elementId_rightStick = 24; // Metadata: 0x01FD8441
		public const int elementId_dPad = 25; // Metadata: 0x01FD8442
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get => default; } // 0x00000001893E4324-0x00000001893E4364 
		IControllerTemplateButton IGamepadTemplate.a { get => default; } // 0x00000001893E42E4-0x00000001893E4324 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get => default; } // 0x00000001893E4364-0x00000001893E43A4 
		IControllerTemplateButton IGamepadTemplate.b { get => default; } // 0x00000001893E44A4-0x00000001893E44E4 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get => default; } // 0x00000001893E43A4-0x00000001893E43E4 
		IControllerTemplateButton IGamepadTemplate.c { get => default; } // 0x00000001893E4524-0x00000001893E4564 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get => default; } // 0x00000001893E43E4-0x00000001893E4424 
		IControllerTemplateButton IGamepadTemplate.x { get => default; } // 0x00000001893E4964-0x00000001893E49A4 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get => default; } // 0x00000001893E4424-0x00000001893E4464 
		IControllerTemplateButton IGamepadTemplate.y { get => default; } // 0x00000001893E49A4-0x00000001893E49E4 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get => default; } // 0x00000001893E4464-0x00000001893E44A4 
		IControllerTemplateButton IGamepadTemplate.z { get => default; } // 0x00000001893E49E4-0x00000001893E4A24 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get => default; } // 0x00000001893E46E4-0x00000001893E4724 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get => default; } // 0x00000001893E46A4-0x00000001893E46E4 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get => default; } // 0x00000001893E4724-0x00000001893E4764 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get => default; } // 0x00000001893E47A4-0x00000001893E47E4 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get => default; } // 0x00000001893E4824-0x00000001893E4864 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get => default; } // 0x00000001893E47E4-0x00000001893E4824 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get => default; } // 0x00000001893E4864-0x00000001893E48A4 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get => default; } // 0x00000001893E48E4-0x00000001893E4924 
		IControllerTemplateButton IGamepadTemplate.center1 { get => default; } // 0x00000001893E4564-0x00000001893E45A4 
		IControllerTemplateButton IGamepadTemplate.back { get => default; } // 0x00000001893E44E4-0x00000001893E4524 
		IControllerTemplateButton IGamepadTemplate.center2 { get => default; } // 0x00000001893E45A4-0x00000001893E45E4 
		IControllerTemplateButton IGamepadTemplate.start { get => default; } // 0x00000001893E4924-0x00000001893E4964 
		IControllerTemplateButton IGamepadTemplate.center3 { get => default; } // 0x00000001893E45E4-0x00000001893E4624 
		IControllerTemplateButton IGamepadTemplate.guide { get => default; } // 0x00000001893E4664-0x00000001893E46A4 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get => default; } // 0x00000001893E4764-0x00000001893E47A4 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get => default; } // 0x00000001893E48A4-0x00000001893E48E4 
		IControllerTemplateDPad IGamepadTemplate.dPad { get => default; } // 0x00000001893E4624-0x00000001893E4664 
	
		// Constructors
		public GamepadTemplate() {} // Dummy constructor
		public GamepadTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static GamepadTemplate() {} // 0x00000001893E4A24-0x00000001893E4A88
	}

	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 56854
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x01FD8443
		public const int elementId_accelerator = 1; // Metadata: 0x01FD8444
		public const int elementId_brake = 2; // Metadata: 0x01FD8445
		public const int elementId_clutch = 3; // Metadata: 0x01FD8446
		public const int elementId_shiftDown = 4; // Metadata: 0x01FD8447
		public const int elementId_shiftUp = 5; // Metadata: 0x01FD8448
		public const int elementId_wheelButton1 = 6; // Metadata: 0x01FD8449
		public const int elementId_wheelButton2 = 7; // Metadata: 0x01FD844A
		public const int elementId_wheelButton3 = 8; // Metadata: 0x01FD844B
		public const int elementId_wheelButton4 = 9; // Metadata: 0x01FD844C
		public const int elementId_wheelButton5 = 10; // Metadata: 0x01FD844D
		public const int elementId_wheelButton6 = 11; // Metadata: 0x01FD844E
		public const int elementId_wheelButton7 = 12; // Metadata: 0x01FD844F
		public const int elementId_wheelButton8 = 13; // Metadata: 0x01FD8450
		public const int elementId_wheelButton9 = 14; // Metadata: 0x01FD8451
		public const int elementId_wheelButton10 = 15; // Metadata: 0x01FD8452
		public const int elementId_consoleButton1 = 16; // Metadata: 0x01FD8453
		public const int elementId_consoleButton2 = 17; // Metadata: 0x01FD8454
		public const int elementId_consoleButton3 = 18; // Metadata: 0x01FD8455
		public const int elementId_consoleButton4 = 19; // Metadata: 0x01FD8456
		public const int elementId_consoleButton5 = 20; // Metadata: 0x01FD8457
		public const int elementId_consoleButton6 = 21; // Metadata: 0x01FD8458
		public const int elementId_consoleButton7 = 22; // Metadata: 0x01FD8459
		public const int elementId_consoleButton8 = 23; // Metadata: 0x01FD845A
		public const int elementId_consoleButton9 = 24; // Metadata: 0x01FD845B
		public const int elementId_consoleButton10 = 25; // Metadata: 0x01FD845C
		public const int elementId_shifter1 = 26; // Metadata: 0x01FD845D
		public const int elementId_shifter2 = 27; // Metadata: 0x01FD845E
		public const int elementId_shifter3 = 28; // Metadata: 0x01FD845F
		public const int elementId_shifter4 = 29; // Metadata: 0x01FD8460
		public const int elementId_shifter5 = 30; // Metadata: 0x01FD8461
		public const int elementId_shifter6 = 31; // Metadata: 0x01FD8462
		public const int elementId_shifter7 = 32; // Metadata: 0x01FD8463
		public const int elementId_shifter8 = 33; // Metadata: 0x01FD8464
		public const int elementId_shifter9 = 34; // Metadata: 0x01FD8465
		public const int elementId_shifter10 = 35; // Metadata: 0x01FD8466
		public const int elementId_reverseGear = 44; // Metadata: 0x01FD8467
		public const int elementId_select = 36; // Metadata: 0x01FD8468
		public const int elementId_start = 37; // Metadata: 0x01FD8469
		public const int elementId_systemButton = 38; // Metadata: 0x01FD846A
		public const int elementId_horn = 43; // Metadata: 0x01FD846B
		public const int elementId_dPadUp = 39; // Metadata: 0x01FD846C
		public const int elementId_dPadRight = 40; // Metadata: 0x01FD846D
		public const int elementId_dPadDown = 41; // Metadata: 0x01FD846E
		public const int elementId_dPadLeft = 42; // Metadata: 0x01FD846F
		public const int elementId_dPad = 45; // Metadata: 0x01FD8470
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get => default; } // 0x00000001893E783C-0x00000001893E7878 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get => default; } // 0x00000001893E6DFC-0x00000001893E6E3C 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get => default; } // 0x00000001893E6E3C-0x00000001893E6E7C 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get => default; } // 0x00000001893E6E7C-0x00000001893E6EBC 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get => default; } // 0x00000001893E723C-0x00000001893E727C 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get => default; } // 0x00000001893E727C-0x00000001893E72BC 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get => default; } // 0x00000001893E75FC-0x00000001893E763C 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get => default; } // 0x00000001893E763C-0x00000001893E767C 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get => default; } // 0x00000001893E767C-0x00000001893E76BC 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get => default; } // 0x00000001893E76BC-0x00000001893E76FC 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get => default; } // 0x00000001893E76FC-0x00000001893E773C 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get => default; } // 0x00000001893E773C-0x00000001893E777C 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get => default; } // 0x00000001893E777C-0x00000001893E77BC 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get => default; } // 0x00000001893E77BC-0x00000001893E77FC 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get => default; } // 0x00000001893E77FC-0x00000001893E783C 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get => default; } // 0x00000001893E75BC-0x00000001893E75FC 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get => default; } // 0x00000001893E6EFC-0x00000001893E6F3C 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get => default; } // 0x00000001893E6F3C-0x00000001893E6F7C 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get => default; } // 0x00000001893E6F7C-0x00000001893E6FBC 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get => default; } // 0x00000001893E6FBC-0x00000001893E6FFC 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get => default; } // 0x00000001893E6FFC-0x00000001893E703C 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get => default; } // 0x00000001893E703C-0x00000001893E707C 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get => default; } // 0x00000001893E707C-0x00000001893E70BC 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get => default; } // 0x00000001893E70BC-0x00000001893E70FC 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get => default; } // 0x00000001893E70FC-0x00000001893E713C 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get => default; } // 0x00000001893E6EBC-0x00000001893E6EFC 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get => default; } // 0x00000001893E72FC-0x00000001893E733C 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get => default; } // 0x00000001893E733C-0x00000001893E737C 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get => default; } // 0x00000001893E737C-0x00000001893E73BC 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get => default; } // 0x00000001893E73BC-0x00000001893E73FC 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get => default; } // 0x00000001893E73FC-0x00000001893E743C 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get => default; } // 0x00000001893E743C-0x00000001893E747C 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get => default; } // 0x00000001893E747C-0x00000001893E74BC 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get => default; } // 0x00000001893E74BC-0x00000001893E74FC 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get => default; } // 0x00000001893E74FC-0x00000001893E753C 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get => default; } // 0x00000001893E72BC-0x00000001893E72FC 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get => default; } // 0x00000001893E71BC-0x00000001893E71FC 
		IControllerTemplateButton IRacingWheelTemplate.select { get => default; } // 0x00000001893E71FC-0x00000001893E723C 
		IControllerTemplateButton IRacingWheelTemplate.start { get => default; } // 0x00000001893E753C-0x00000001893E757C 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get => default; } // 0x00000001893E757C-0x00000001893E75BC 
		IControllerTemplateButton IRacingWheelTemplate.horn { get => default; } // 0x00000001893E717C-0x00000001893E71BC 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get => default; } // 0x00000001893E713C-0x00000001893E717C 
	
		// Constructors
		public RacingWheelTemplate() {} // Dummy constructor
		public RacingWheelTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static RacingWheelTemplate() {} // 0x00000001893E7878-0x00000001893E78DC
	}

	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 56855
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x01FD8471
		public const int elementId_stickY = 1; // Metadata: 0x01FD8472
		public const int elementId_stickRotate = 2; // Metadata: 0x01FD8473
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x01FD8474
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x01FD8476
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x01FD8478
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x01FD847A
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x01FD847C
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x01FD847E
		public const int elementId_stickTrigger = 3; // Metadata: 0x01FD8480
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x01FD8481
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x01FD8482
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x01FD8483
		public const int elementId_stickButton1 = 6; // Metadata: 0x01FD8485
		public const int elementId_stickButton2 = 7; // Metadata: 0x01FD8486
		public const int elementId_stickButton3 = 8; // Metadata: 0x01FD8487
		public const int elementId_stickButton4 = 9; // Metadata: 0x01FD8488
		public const int elementId_stickButton5 = 10; // Metadata: 0x01FD8489
		public const int elementId_stickButton6 = 11; // Metadata: 0x01FD848A
		public const int elementId_stickButton7 = 12; // Metadata: 0x01FD848B
		public const int elementId_stickButton8 = 13; // Metadata: 0x01FD848C
		public const int elementId_stickButton9 = 14; // Metadata: 0x01FD848D
		public const int elementId_stickButton10 = 15; // Metadata: 0x01FD848E
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x01FD848F
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x01FD8490
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x01FD8491
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x01FD8492
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x01FD8493
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x01FD8494
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x01FD8495
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x01FD8496
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x01FD8497
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x01FD8498
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x01FD8499
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x01FD849B
		public const int elementId_stickHat1Up = 28; // Metadata: 0x01FD849D
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x01FD849E
		public const int elementId_stickHat1Right = 30; // Metadata: 0x01FD849F
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x01FD84A0
		public const int elementId_stickHat1Down = 32; // Metadata: 0x01FD84A1
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x01FD84A2
		public const int elementId_stickHat1Left = 34; // Metadata: 0x01FD84A3
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x01FD84A4
		public const int elementId_stickHat2Up = 36; // Metadata: 0x01FD84A5
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x01FD84A6
		public const int elementId_stickHat2Right = 38; // Metadata: 0x01FD84A7
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x01FD84A8
		public const int elementId_stickHat2Down = 40; // Metadata: 0x01FD84A9
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x01FD84AA
		public const int elementId_stickHat2Left = 42; // Metadata: 0x01FD84AB
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x01FD84AC
		public const int elementId_stickHat3Up = 84; // Metadata: 0x01FD84AD
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x01FD84AF
		public const int elementId_stickHat3Right = 86; // Metadata: 0x01FD84B1
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x01FD84B3
		public const int elementId_stickHat3Down = 88; // Metadata: 0x01FD84B5
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x01FD84B7
		public const int elementId_stickHat3Left = 90; // Metadata: 0x01FD84B9
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x01FD84BB
		public const int elementId_stickHat4Up = 92; // Metadata: 0x01FD84BD
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x01FD84BF
		public const int elementId_stickHat4Right = 94; // Metadata: 0x01FD84C1
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x01FD84C3
		public const int elementId_stickHat4Down = 96; // Metadata: 0x01FD84C5
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x01FD84C7
		public const int elementId_stickHat4Left = 98; // Metadata: 0x01FD84C9
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x01FD84CB
		public const int elementId_mode1 = 44; // Metadata: 0x01FD84CD
		public const int elementId_mode2 = 45; // Metadata: 0x01FD84CE
		public const int elementId_mode3 = 46; // Metadata: 0x01FD84CF
		public const int elementId_throttle1Axis = 49; // Metadata: 0x01FD84D0
		public const int elementId_throttle2Axis = 155; // Metadata: 0x01FD84D1
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x01FD84D3
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x01FD84D5
		public const int elementId_throttleButton1 = 50; // Metadata: 0x01FD84D7
		public const int elementId_throttleButton2 = 51; // Metadata: 0x01FD84D8
		public const int elementId_throttleButton3 = 52; // Metadata: 0x01FD84D9
		public const int elementId_throttleButton4 = 53; // Metadata: 0x01FD84DA
		public const int elementId_throttleButton5 = 54; // Metadata: 0x01FD84DB
		public const int elementId_throttleButton6 = 55; // Metadata: 0x01FD84DC
		public const int elementId_throttleButton7 = 56; // Metadata: 0x01FD84DD
		public const int elementId_throttleButton8 = 57; // Metadata: 0x01FD84DE
		public const int elementId_throttleButton9 = 58; // Metadata: 0x01FD84DF
		public const int elementId_throttleButton10 = 59; // Metadata: 0x01FD84E0
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x01FD84E1
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x01FD84E2
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x01FD84E3
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x01FD84E4
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x01FD84E5
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x01FD84E7
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x01FD84E9
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x01FD84EB
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x01FD84ED
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x01FD84EF
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x01FD84F1
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x01FD84F3
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x01FD84F5
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x01FD84F7
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x01FD84F9
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x01FD84FB
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x01FD84FD
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x01FD84FF
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x01FD8501
		public const int elementId_throttleDial1 = 74; // Metadata: 0x01FD8503
		public const int elementId_throttleDial2 = 142; // Metadata: 0x01FD8505
		public const int elementId_throttleDial3 = 143; // Metadata: 0x01FD8507
		public const int elementId_throttleDial4 = 144; // Metadata: 0x01FD8509
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x01FD850B
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x01FD850D
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x01FD850F
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x01FD8511
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x01FD8513
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x01FD8515
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x01FD8517
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x01FD8519
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x01FD851B
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x01FD851D
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x01FD851F
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x01FD8521
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x01FD8523
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x01FD8525
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x01FD8527
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x01FD8529
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x01FD852B
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x01FD852D
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x01FD852F
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x01FD8531
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x01FD8533
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x01FD8535
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x01FD8537
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x01FD8539
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x01FD853B
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x01FD853D
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x01FD853F
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x01FD8541
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x01FD8543
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x01FD8545
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x01FD8547
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x01FD8549
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x01FD854B
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x01FD854D
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x01FD854F
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x01FD8551
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x01FD8553
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x01FD8555
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x01FD8557
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x01FD8559
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x01FD855B
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x01FD855D
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x01FD855F
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x01FD8561
		public const int elementId_leftPedal = 168; // Metadata: 0x01FD8563
		public const int elementId_rightPedal = 169; // Metadata: 0x01FD8565
		public const int elementId_slidePedals = 170; // Metadata: 0x01FD8567
		public const int elementId_stick = 171; // Metadata: 0x01FD8569
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x01FD856B
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x01FD856D
		public const int elementId_stickHat1 = 174; // Metadata: 0x01FD856F
		public const int elementId_stickHat2 = 175; // Metadata: 0x01FD8571
		public const int elementId_stickHat3 = 176; // Metadata: 0x01FD8573
		public const int elementId_stickHat4 = 177; // Metadata: 0x01FD8575
		public const int elementId_throttle1 = 178; // Metadata: 0x01FD8577
		public const int elementId_throttle2 = 179; // Metadata: 0x01FD8579
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x01FD857B
		public const int elementId_throttleHat1 = 181; // Metadata: 0x01FD857D
		public const int elementId_throttleHat2 = 182; // Metadata: 0x01FD857F
		public const int elementId_throttleHat3 = 183; // Metadata: 0x01FD8581
		public const int elementId_throttleHat4 = 184; // Metadata: 0x01FD8583
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get => default; } // 0x00000001893E53C8-0x00000001893E5408 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get => default; } // 0x00000001893E5388-0x00000001893E53C8 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get => default; } // 0x00000001893E5308-0x00000001893E5348 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get => default; } // 0x00000001893E5348-0x00000001893E5388 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get => default; } // 0x00000001893E4F48-0x00000001893E4F88 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get => default; } // 0x00000001893E4F88-0x00000001893E4FC8 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get => default; } // 0x00000001893E4FC8-0x00000001893E5008 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get => default; } // 0x00000001893E5008-0x00000001893E5048 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get => default; } // 0x00000001893E5048-0x00000001893E5088 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get => default; } // 0x00000001893E5088-0x00000001893E50C8 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get => default; } // 0x00000001893E50C8-0x00000001893E5108 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get => default; } // 0x00000001893E5108-0x00000001893E5148 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get => default; } // 0x00000001893E5148-0x00000001893E5188 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get => default; } // 0x00000001893E4F08-0x00000001893E4F48 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get => default; } // 0x00000001893E4CC8-0x00000001893E4D08 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get => default; } // 0x00000001893E4D08-0x00000001893E4D48 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get => default; } // 0x00000001893E4D48-0x00000001893E4D88 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get => default; } // 0x00000001893E4D88-0x00000001893E4DC8 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get => default; } // 0x00000001893E4DC8-0x00000001893E4E08 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get => default; } // 0x00000001893E4E08-0x00000001893E4E48 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get => default; } // 0x00000001893E4E48-0x00000001893E4E88 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get => default; } // 0x00000001893E4E88-0x00000001893E4EC8 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get => default; } // 0x00000001893E4EC8-0x00000001893E4F08 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get => default; } // 0x00000001893E4C08-0x00000001893E4C48 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get => default; } // 0x00000001893E4C48-0x00000001893E4C88 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get => default; } // 0x00000001893E4C88-0x00000001893E4CC8 
		IControllerTemplateButton IHOTASTemplate.mode1 { get => default; } // 0x00000001893E4AC8-0x00000001893E4B08 
		IControllerTemplateButton IHOTASTemplate.mode2 { get => default; } // 0x00000001893E4B08-0x00000001893E4B48 
		IControllerTemplateButton IHOTASTemplate.mode3 { get => default; } // 0x00000001893E4B48-0x00000001893E4B88 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get => default; } // 0x00000001893E58C8-0x00000001893E5908 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get => default; } // 0x00000001893E5908-0x00000001893E5948 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get => default; } // 0x00000001893E5948-0x00000001893E5988 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get => default; } // 0x00000001893E5988-0x00000001893E59C8 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get => default; } // 0x00000001893E59C8-0x00000001893E5A08 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get => default; } // 0x00000001893E5A08-0x00000001893E5A48 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get => default; } // 0x00000001893E5A48-0x00000001893E5A88 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get => default; } // 0x00000001893E5A88-0x00000001893E5AC8 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get => default; } // 0x00000001893E5AC8-0x00000001893E5B08 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get => default; } // 0x00000001893E5888-0x00000001893E58C8 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get => default; } // 0x00000001893E5648-0x00000001893E5688 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get => default; } // 0x00000001893E5688-0x00000001893E56C8 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get => default; } // 0x00000001893E56C8-0x00000001893E5708 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get => default; } // 0x00000001893E5708-0x00000001893E5748 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get => default; } // 0x00000001893E5748-0x00000001893E5788 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get => default; } // 0x00000001893E5788-0x00000001893E57C8 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get => default; } // 0x00000001893E57C8-0x00000001893E5808 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get => default; } // 0x00000001893E5808-0x00000001893E5848 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get => default; } // 0x00000001893E5848-0x00000001893E5888 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get => default; } // 0x00000001893E54C8-0x00000001893E5508 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get => default; } // 0x00000001893E5508-0x00000001893E5548 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get => default; } // 0x00000001893E5548-0x00000001893E5588 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get => default; } // 0x00000001893E5588-0x00000001893E55C8 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get => default; } // 0x00000001893E55C8-0x00000001893E5608 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get => default; } // 0x00000001893E5608-0x00000001893E5648 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get => default; } // 0x00000001893E5D48-0x00000001893E5D88 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get => default; } // 0x00000001893E5D88-0x00000001893E5DC8 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get => default; } // 0x00000001893E5DC8-0x00000001893E5E08 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get => default; } // 0x00000001893E5E08-0x00000001893E5E48 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get => default; } // 0x00000001893E5B08-0x00000001893E5B48 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get => default; } // 0x00000001893E5B48-0x00000001893E5B88 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get => default; } // 0x00000001893E5B88-0x00000001893E5BC8 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get => default; } // 0x00000001893E5BC8-0x00000001893E5C08 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get => default; } // 0x00000001893E5E88-0x00000001893E5EC8 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get => default; } // 0x00000001893E5E48-0x00000001893E5E88 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get => default; } // 0x00000001893E5EC8-0x00000001893E5F08 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get => default; } // 0x00000001893E5F48-0x00000001893E5F88 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get => default; } // 0x00000001893E5F08-0x00000001893E5F48 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get => default; } // 0x00000001893E5F88-0x00000001893E5FC8 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get => default; } // 0x00000001893E6008-0x00000001893E6048 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get => default; } // 0x00000001893E5FC8-0x00000001893E6008 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get => default; } // 0x00000001893E6048-0x00000001893E6088 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get => default; } // 0x00000001893E4A88-0x00000001893E4AC8 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get => default; } // 0x00000001893E4B88-0x00000001893E4BC8 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get => default; } // 0x00000001893E4BC8-0x00000001893E4C08 
		IControllerTemplateStick IHOTASTemplate.stick { get => default; } // 0x00000001893E5408-0x00000001893E5448 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get => default; } // 0x00000001893E5288-0x00000001893E52C8 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get => default; } // 0x00000001893E52C8-0x00000001893E5308 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get => default; } // 0x00000001893E5188-0x00000001893E51C8 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get => default; } // 0x00000001893E51C8-0x00000001893E5208 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get => default; } // 0x00000001893E5208-0x00000001893E5248 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get => default; } // 0x00000001893E5248-0x00000001893E5288 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get => default; } // 0x00000001893E5448-0x00000001893E5488 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get => default; } // 0x00000001893E5488-0x00000001893E54C8 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get => default; } // 0x00000001893E5D08-0x00000001893E5D48 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get => default; } // 0x00000001893E5C08-0x00000001893E5C48 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get => default; } // 0x00000001893E5C48-0x00000001893E5C88 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get => default; } // 0x00000001893E5C88-0x00000001893E5CC8 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get => default; } // 0x00000001893E5CC8-0x00000001893E5D08 
	
		// Constructors
		public HOTASTemplate() {} // Dummy constructor
		public HOTASTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static HOTASTemplate() {} // 0x00000001893E6088-0x00000001893E60EC
	}

	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 56856
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x01FD8585
		public const int elementId_yokeZ = 1; // Metadata: 0x01FD8586
		public const int elementId_leftPaddle = 59; // Metadata: 0x01FD8587
		public const int elementId_rightPaddle = 60; // Metadata: 0x01FD8588
		public const int elementId_lever1Axis = 2; // Metadata: 0x01FD8589
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x01FD858A
		public const int elementId_lever2Axis = 3; // Metadata: 0x01FD858C
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x01FD858D
		public const int elementId_lever3Axis = 4; // Metadata: 0x01FD858F
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x01FD8590
		public const int elementId_lever4Axis = 5; // Metadata: 0x01FD8592
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x01FD8593
		public const int elementId_lever5Axis = 6; // Metadata: 0x01FD8595
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x01FD8596
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x01FD8598
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x01FD8599
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x01FD859A
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x01FD859B
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x01FD859C
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x01FD859D
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x01FD859E
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x01FD859F
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x01FD85A0
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x01FD85A1
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x01FD85A2
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x01FD85A3
		public const int elementId_centerButton1 = 19; // Metadata: 0x01FD85A4
		public const int elementId_centerButton2 = 20; // Metadata: 0x01FD85A5
		public const int elementId_centerButton3 = 21; // Metadata: 0x01FD85A6
		public const int elementId_centerButton4 = 22; // Metadata: 0x01FD85A7
		public const int elementId_centerButton5 = 23; // Metadata: 0x01FD85A8
		public const int elementId_centerButton6 = 24; // Metadata: 0x01FD85A9
		public const int elementId_centerButton7 = 25; // Metadata: 0x01FD85AA
		public const int elementId_centerButton8 = 26; // Metadata: 0x01FD85AB
		public const int elementId_wheel1Up = 53; // Metadata: 0x01FD85AC
		public const int elementId_wheel1Down = 54; // Metadata: 0x01FD85AD
		public const int elementId_wheel1Press = 55; // Metadata: 0x01FD85AE
		public const int elementId_wheel2Up = 56; // Metadata: 0x01FD85AF
		public const int elementId_wheel2Down = 57; // Metadata: 0x01FD85B0
		public const int elementId_wheel2Press = 58; // Metadata: 0x01FD85B1
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x01FD85B2
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x01FD85B3
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x01FD85B4
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x01FD85B5
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x01FD85B6
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x01FD85B7
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x01FD85B8
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x01FD85B9
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x01FD85BA
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x01FD85BB
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x01FD85BC
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x01FD85BD
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x01FD85BE
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x01FD85BF
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x01FD85C0
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x01FD85C1
		public const int elementId_consoleButton1 = 43; // Metadata: 0x01FD85C2
		public const int elementId_consoleButton2 = 44; // Metadata: 0x01FD85C3
		public const int elementId_consoleButton3 = 45; // Metadata: 0x01FD85C4
		public const int elementId_consoleButton4 = 46; // Metadata: 0x01FD85C5
		public const int elementId_consoleButton5 = 47; // Metadata: 0x01FD85C6
		public const int elementId_consoleButton6 = 48; // Metadata: 0x01FD85C7
		public const int elementId_consoleButton7 = 49; // Metadata: 0x01FD85C8
		public const int elementId_consoleButton8 = 50; // Metadata: 0x01FD85C9
		public const int elementId_consoleButton9 = 51; // Metadata: 0x01FD85CA
		public const int elementId_consoleButton10 = 52; // Metadata: 0x01FD85CB
		public const int elementId_mode1 = 61; // Metadata: 0x01FD85CC
		public const int elementId_mode2 = 62; // Metadata: 0x01FD85CD
		public const int elementId_mode3 = 63; // Metadata: 0x01FD85CE
		public const int elementId_yoke = 69; // Metadata: 0x01FD85CF
		public const int elementId_lever1 = 70; // Metadata: 0x01FD85D1
		public const int elementId_lever2 = 71; // Metadata: 0x01FD85D3
		public const int elementId_lever3 = 72; // Metadata: 0x01FD85D5
		public const int elementId_lever4 = 73; // Metadata: 0x01FD85D7
		public const int elementId_lever5 = 74; // Metadata: 0x01FD85D9
		public const int elementId_leftGripHat = 75; // Metadata: 0x01FD85DB
		public const int elementId_rightGripHat = 76; // Metadata: 0x01FD85DD
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get => default; } // 0x00000001893E3C80-0x00000001893E3CC0 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get => default; } // 0x00000001893E4080-0x00000001893E40C0 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get => default; } // 0x00000001893E3AC0-0x00000001893E3B00 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get => default; } // 0x00000001893E3B00-0x00000001893E3B40 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get => default; } // 0x00000001893E3B40-0x00000001893E3B80 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get => default; } // 0x00000001893E3B80-0x00000001893E3BC0 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get => default; } // 0x00000001893E3BC0-0x00000001893E3C00 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get => default; } // 0x00000001893E3C00-0x00000001893E3C40 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get => default; } // 0x00000001893E3EC0-0x00000001893E3F00 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get => default; } // 0x00000001893E3F00-0x00000001893E3F40 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get => default; } // 0x00000001893E3F40-0x00000001893E3F80 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get => default; } // 0x00000001893E3F80-0x00000001893E3FC0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get => default; } // 0x00000001893E3FC0-0x00000001893E4000 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get => default; } // 0x00000001893E4000-0x00000001893E4040 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get => default; } // 0x00000001893E3640-0x00000001893E3680 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get => default; } // 0x00000001893E3680-0x00000001893E36C0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get => default; } // 0x00000001893E36C0-0x00000001893E3700 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get => default; } // 0x00000001893E3700-0x00000001893E3740 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get => default; } // 0x00000001893E3740-0x00000001893E3780 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get => default; } // 0x00000001893E3780-0x00000001893E37C0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get => default; } // 0x00000001893E37C0-0x00000001893E3800 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get => default; } // 0x00000001893E3800-0x00000001893E3840 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get => default; } // 0x00000001893E4140-0x00000001893E4180 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get => default; } // 0x00000001893E40C0-0x00000001893E4100 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get => default; } // 0x00000001893E4100-0x00000001893E4140 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get => default; } // 0x00000001893E4200-0x00000001893E4240 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get => default; } // 0x00000001893E4180-0x00000001893E41C0 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get => default; } // 0x00000001893E41C0-0x00000001893E4200 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get => default; } // 0x00000001893E3880-0x00000001893E38C0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get => default; } // 0x00000001893E38C0-0x00000001893E3900 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get => default; } // 0x00000001893E3900-0x00000001893E3940 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get => default; } // 0x00000001893E3940-0x00000001893E3980 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get => default; } // 0x00000001893E3980-0x00000001893E39C0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get => default; } // 0x00000001893E39C0-0x00000001893E3A00 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get => default; } // 0x00000001893E3A00-0x00000001893E3A40 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get => default; } // 0x00000001893E3A40-0x00000001893E3A80 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get => default; } // 0x00000001893E3A80-0x00000001893E3AC0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get => default; } // 0x00000001893E3840-0x00000001893E3880 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get => default; } // 0x00000001893E3E00-0x00000001893E3E40 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get => default; } // 0x00000001893E3E40-0x00000001893E3E80 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get => default; } // 0x00000001893E3E80-0x00000001893E3EC0 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get => default; } // 0x00000001893E4240-0x00000001893E4280 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get => default; } // 0x00000001893E3CC0-0x00000001893E3D00 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get => default; } // 0x00000001893E3D00-0x00000001893E3D40 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get => default; } // 0x00000001893E3D40-0x00000001893E3D80 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get => default; } // 0x00000001893E3D80-0x00000001893E3DC0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get => default; } // 0x00000001893E3DC0-0x00000001893E3E00 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get => default; } // 0x00000001893E3C40-0x00000001893E3C80 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get => default; } // 0x00000001893E4040-0x00000001893E4080 
	
		// Constructors
		public FlightYokeTemplate() {} // Dummy constructor
		public FlightYokeTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static FlightYokeTemplate() {} // 0x00000001893E4280-0x00000001893E42E4
	}

	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 56857
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x01FD85DF
		public const int elementId_rightPedal = 1; // Metadata: 0x01FD85E0
		public const int elementId_slide = 2; // Metadata: 0x01FD85E1
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get => default; } // 0x00000001893E3518-0x00000001893E3554 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get => default; } // 0x00000001893E3554-0x00000001893E3594 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get => default; } // 0x00000001893E3594-0x00000001893E35D4 
	
		// Constructors
		public FlightPedalsTemplate() {} // Dummy constructor
		public FlightPedalsTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static FlightPedalsTemplate() {} // 0x00000001893E35D4-0x00000001893E3638
	}

	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 56858
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x01FD85E2
		public const int elementId_positionY = 2; // Metadata: 0x01FD85E3
		public const int elementId_positionZ = 0; // Metadata: 0x01FD85E4
		public const int elementId_rotationX = 3; // Metadata: 0x01FD85E5
		public const int elementId_rotationY = 5; // Metadata: 0x01FD85E6
		public const int elementId_rotationZ = 4; // Metadata: 0x01FD85E7
		public const int elementId_throttle1Axis = 6; // Metadata: 0x01FD85E8
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x01FD85E9
		public const int elementId_throttle2Axis = 7; // Metadata: 0x01FD85EA
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x01FD85EB
		public const int elementId_extraAxis1 = 8; // Metadata: 0x01FD85EC
		public const int elementId_extraAxis2 = 9; // Metadata: 0x01FD85ED
		public const int elementId_extraAxis3 = 10; // Metadata: 0x01FD85EE
		public const int elementId_extraAxis4 = 11; // Metadata: 0x01FD85EF
		public const int elementId_button1 = 12; // Metadata: 0x01FD85F0
		public const int elementId_button2 = 13; // Metadata: 0x01FD85F1
		public const int elementId_button3 = 14; // Metadata: 0x01FD85F2
		public const int elementId_button4 = 15; // Metadata: 0x01FD85F3
		public const int elementId_button5 = 16; // Metadata: 0x01FD85F4
		public const int elementId_button6 = 17; // Metadata: 0x01FD85F5
		public const int elementId_button7 = 18; // Metadata: 0x01FD85F6
		public const int elementId_button8 = 19; // Metadata: 0x01FD85F7
		public const int elementId_button9 = 20; // Metadata: 0x01FD85F8
		public const int elementId_button10 = 21; // Metadata: 0x01FD85F9
		public const int elementId_button11 = 22; // Metadata: 0x01FD85FA
		public const int elementId_button12 = 23; // Metadata: 0x01FD85FB
		public const int elementId_button13 = 24; // Metadata: 0x01FD85FC
		public const int elementId_button14 = 25; // Metadata: 0x01FD85FD
		public const int elementId_button15 = 26; // Metadata: 0x01FD85FE
		public const int elementId_button16 = 27; // Metadata: 0x01FD85FF
		public const int elementId_button17 = 28; // Metadata: 0x01FD8600
		public const int elementId_button18 = 29; // Metadata: 0x01FD8601
		public const int elementId_button19 = 30; // Metadata: 0x01FD8602
		public const int elementId_button20 = 31; // Metadata: 0x01FD8603
		public const int elementId_button21 = 55; // Metadata: 0x01FD8604
		public const int elementId_button22 = 56; // Metadata: 0x01FD8605
		public const int elementId_button23 = 57; // Metadata: 0x01FD8606
		public const int elementId_button24 = 58; // Metadata: 0x01FD8607
		public const int elementId_button25 = 59; // Metadata: 0x01FD8608
		public const int elementId_button26 = 60; // Metadata: 0x01FD8609
		public const int elementId_button27 = 61; // Metadata: 0x01FD860A
		public const int elementId_button28 = 62; // Metadata: 0x01FD860B
		public const int elementId_button29 = 63; // Metadata: 0x01FD860C
		public const int elementId_button30 = 64; // Metadata: 0x01FD860D
		public const int elementId_button31 = 65; // Metadata: 0x01FD860F
		public const int elementId_button32 = 66; // Metadata: 0x01FD8611
		public const int elementId_hat1Up = 32; // Metadata: 0x01FD8613
		public const int elementId_hat1UpRight = 33; // Metadata: 0x01FD8614
		public const int elementId_hat1Right = 34; // Metadata: 0x01FD8615
		public const int elementId_hat1DownRight = 35; // Metadata: 0x01FD8616
		public const int elementId_hat1Down = 36; // Metadata: 0x01FD8617
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x01FD8618
		public const int elementId_hat1Left = 38; // Metadata: 0x01FD8619
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x01FD861A
		public const int elementId_hat2Up = 40; // Metadata: 0x01FD861B
		public const int elementId_hat2UpRight = 41; // Metadata: 0x01FD861C
		public const int elementId_hat2Right = 42; // Metadata: 0x01FD861D
		public const int elementId_hat2DownRight = 43; // Metadata: 0x01FD861E
		public const int elementId_hat2Down = 44; // Metadata: 0x01FD861F
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x01FD8620
		public const int elementId_hat2Left = 46; // Metadata: 0x01FD8621
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x01FD8622
		public const int elementId_hat1 = 48; // Metadata: 0x01FD8623
		public const int elementId_hat2 = 49; // Metadata: 0x01FD8624
		public const int elementId_throttle1 = 52; // Metadata: 0x01FD8625
		public const int elementId_throttle2 = 53; // Metadata: 0x01FD8626
		public const int elementId_stick = 54; // Metadata: 0x01FD8627
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get => default; } // 0x00000001893EE774-0x00000001893EE7B4 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get => default; } // 0x00000001893EE7B4-0x00000001893EE7F4 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get => default; } // 0x00000001893EE7F4-0x00000001893EE834 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get => default; } // 0x00000001893EE834-0x00000001893EE874 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get => default; } // 0x00000001893EE1F4-0x00000001893EE234 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get => default; } // 0x00000001893EE4B4-0x00000001893EE4F4 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get => default; } // 0x00000001893EE5B4-0x00000001893EE5F4 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get => default; } // 0x00000001893EE5F4-0x00000001893EE634 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get => default; } // 0x00000001893EE634-0x00000001893EE674 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get => default; } // 0x00000001893EE674-0x00000001893EE6B4 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get => default; } // 0x00000001893EE6B4-0x00000001893EE6F4 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get => default; } // 0x00000001893EE6F4-0x00000001893EE734 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get => default; } // 0x00000001893EE734-0x00000001893EE774 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get => default; } // 0x00000001893EDF74-0x00000001893EDFB4 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get => default; } // 0x00000001893EDFB4-0x00000001893EDFF4 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get => default; } // 0x00000001893EDFF4-0x00000001893EE034 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get => default; } // 0x00000001893EE034-0x00000001893EE074 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get => default; } // 0x00000001893EE074-0x00000001893EE0B4 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get => default; } // 0x00000001893EE0B4-0x00000001893EE0F4 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get => default; } // 0x00000001893EE0F4-0x00000001893EE134 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get => default; } // 0x00000001893EE134-0x00000001893EE174 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get => default; } // 0x00000001893EE174-0x00000001893EE1B4 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get => default; } // 0x00000001893EE1B4-0x00000001893EE1F4 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get => default; } // 0x00000001893EE234-0x00000001893EE274 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get => default; } // 0x00000001893EE274-0x00000001893EE2B4 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get => default; } // 0x00000001893EE2B4-0x00000001893EE2F4 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get => default; } // 0x00000001893EE2F4-0x00000001893EE334 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get => default; } // 0x00000001893EE334-0x00000001893EE374 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get => default; } // 0x00000001893EE374-0x00000001893EE3B4 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get => default; } // 0x00000001893EE3B4-0x00000001893EE3F4 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get => default; } // 0x00000001893EE3F4-0x00000001893EE434 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get => default; } // 0x00000001893EE434-0x00000001893EE474 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get => default; } // 0x00000001893EE474-0x00000001893EE4B4 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get => default; } // 0x00000001893EE4F4-0x00000001893EE534 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get => default; } // 0x00000001893EE534-0x00000001893EE574 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get => default; } // 0x00000001893EE574-0x00000001893EE5B4 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get => default; } // 0x00000001893EE874-0x00000001893EE8B4 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get => default; } // 0x00000001893EE8B4-0x00000001893EE8F4 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get => default; } // 0x00000001893EE934-0x00000001893EE974 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get => default; } // 0x00000001893EE974-0x00000001893EE9B4 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get => default; } // 0x00000001893EE8F4-0x00000001893EE934 
	
		// Constructors
		public SixDofControllerTemplate() {} // Dummy constructor
		public SixDofControllerTemplate(object payload) {} // 0x00000001893E3638-0x00000001893E3640
		static SixDofControllerTemplate() {} // 0x00000001893EE9B4-0x00000001893EEA18
	}

	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base // TypeDefIndex: 56859
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager() {} // 0x0000000183CEB330-0x0000000183CEB340
	
		// Methods
		protected override void OnInitialized() {} // 0x0000000183170440-0x0000000183170450
		protected override void OnDeinitialized() {} // 0x00000001893E6174-0x00000001893E617C
		protected override void DetectPlatform() {} // 0x0000000183CFE450-0x0000000183CFE4B0
		protected override void CheckRecompile() {} // 0x000000018350B670-0x000000018350B680
		protected override IExternalTools GetExternalTools() => default; // 0x0000000183D2CCC0-0x0000000183D2CD00
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) => default; // 0x00000001893E60EC-0x00000001893E6174
		private void SubscribeEvents() {} // 0x00000001831709B0-0x0000000183170A60
		private void UnsubscribeEvents() {} // 0x0000000183170A60-0x0000000183170B00
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x0000000182F73E80-0x0000000182F73E90
	}
}

namespace Rewired.Data
{
	public class UserDataStore_File : UserDataStore_KeyValue // TypeDefIndex: 56868
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x01FD8628
		private const string defaultExtensionText = ".json"; // Metadata: 0x01FD8632
		private const string defaultExtensionBinary = ".bin"; // Metadata: 0x01FD8638
		private const string defaultFileName = "RewiredSaveData.json"; // Metadata: 0x01FD863D
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
		public string directory { get => default; set {} } // 0x00000001893EF210-0x00000001893EF248 0x00000001893EF28C-0x00000001893EF2BC
		public string fileName { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x00000001893EF2BC-0x00000001893EF2EC
		public DataFormat dataFormat { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x00000001893EF248-0x00000001893EF25C
		protected IDataHandler dataHandler { get => default; set {} } // 0x00000001893EF110-0x00000001893EF210 0x00000001893EF25C-0x00000001893EF28C
		protected override IDataStore dataStore { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
	
		// Nested types
		private sealed class DataStore : UserDataStore_KeyValue.IDataStore // TypeDefIndex: 56861
		{
			// Fields
			private Dictionary<string, object> _data; // 0x10
			private readonly string _absFilePath; // 0x18
			private IDataHandler _dataHandler; // 0x20
	
			// Constructors
			public DataStore() {} // Dummy constructor
			public DataStore(string fileName, string absDirectory, IDataHandler dataHandler) {} // 0x00000001893E2F14-0x00000001893E3044
	
			// Methods
			public bool TryGetValue(string key, out object value) {
				value = default;
				return default;
			} // 0x00000001893E2E94-0x00000001893E2F14
			public bool SetValue(string key, object value) => default; // 0x00000001893E2E1C-0x00000001893E2E94
			public bool Save() => default; // 0x00000001893E2CF8-0x00000001893E2E1C
			public bool Load() => default; // 0x00000001893E2B30-0x00000001893E2CF8
			public bool Clear() => default; // 0x00000001893E29D4-0x00000001893E2B30
		}
	
		private sealed class LocalFileDataHandler : IDataHandler // TypeDefIndex: 56862
		{
			// Fields
			private readonly Func<DataFormat> _dataFormatDelegate; // 0x10
			private readonly Codec _codec; // 0x18
	
			// Constructors
			public LocalFileDataHandler() {} // Dummy constructor
			public LocalFileDataHandler(Func<DataFormat> dataFormatDelegate, Codec codec) {} // 0x00000001893E66FC-0x00000001893E67CC
	
			// Methods
			public bool Load(string absoluteFilePath, out string data) {
				data = default;
				return default;
			} // 0x00000001893E6334-0x00000001893E6518
			public bool Save(string absoluteFilePath, string data) => default; // 0x00000001893E6518-0x00000001893E66FC
			public bool Clear(string absoluteFilePath) => default; // 0x00000001893E6274-0x00000001893E6334
		}
	
		private abstract class Codec // TypeDefIndex: 56863
		{
			// Constructors
			protected Codec() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public abstract byte[] Encode(string @string);
			public abstract string Decode(byte[] data);
		}
	
		private sealed class UTF8Text : Codec // TypeDefIndex: 56864
		{
			// Constructors
			public UTF8Text() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override byte[] Encode(string @string) => default; // 0x00000001893EEC98-0x00000001893EECC8
			public override string Decode(byte[] data) => default; // 0x00000001893EEC68-0x00000001893EEC98
		}
	
		private sealed class CLZF2 : Codec // TypeDefIndex: 56865
		{
			// Fields
			private readonly Utils.Libraries.CLZF2.CLZF2 _cLZF2; // 0x10
	
			// Constructors
			public CLZF2() {} // 0x00000001893E2470-0x00000001893E24D4
	
			// Methods
			public override byte[] Encode(string @string) => default; // 0x00000001893E2420-0x00000001893E2470
			public override string Decode(byte[] data) => default; // 0x00000001893E23C4-0x00000001893E2420
		}
	
		public interface IDataHandler // TypeDefIndex: 56866
		{
			// Methods
			bool Load(string absoluteFilePath, out string data);
			bool Save(string absoluteFilePath, string data);
			bool Clear(string absoluteFilePath);
		}
	
		public enum DataFormat // TypeDefIndex: 56867
		{
			Text = 0,
			Binary = 1
		}
	
		// Constructors
		public UserDataStore_File() {} // 0x00000001893EF0B0-0x00000001893EF110
		static UserDataStore_File() {} // 0x00000001893EF018-0x00000001893EF0B0
	
		// Methods
		protected virtual void SetInitialValues() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnInitialize() {} // 0x00000001893EEFF4-0x00000001893EF018
		private void OnDataSourceChanged() {} // 0x00000001893EEF24-0x00000001893EEFF4
	}

	public abstract class UserDataStore_KeyValue : UserDataStore // TypeDefIndex: 56878
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x01FD8654
		private const string key_controllerAssignments = "ControllerAssignments"; // Metadata: 0x01FD865E
		private const int controllerMapKeyVersion = 0; // Metadata: 0x01FD8674
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
		public bool isEnabled { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool loadDataOnStart { get; set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public bool loadJoystickAssignments { get; set; } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000183D4EFD0-0x0000000183D4EFE0
		public bool loadKeyboardAssignments { get; set; } // 0x0000000183D52270-0x0000000183D52280 0x0000000183D522A0-0x0000000183D522B0
		public bool loadMouseAssignments { get; set; } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
		protected abstract IDataStore dataStore { get; }
		private bool loadControllerAssignments { get; } // 0x00000001893F4A50-0x00000001893F4A64 
		private List<int> allActionIds { get; } // 0x00000001893F4910-0x00000001893F4A50 
		private string allActionIdsString { get; } // 0x00000001893F47F8-0x00000001893F4910 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 56871
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get => default; } // 0x000000018352ADE0-0x000000018352AE00 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 56869
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get => default; } // 0x00000001893E6B70-0x00000001893E6B84 
	
				// Constructors
				public PlayerInfo() {} // 0x000000018350B670-0x000000018350B680
	
				// Methods
				public int IndexOfJoystick(int joystickId) => default; // 0x00000001893E6AF4-0x00000001893E6B70
				public bool ContainsJoystick(int joystickId) => default; // 0x00000001893E6ADC-0x00000001893E6AF4
			}
	
			public class JoystickInfo // TypeDefIndex: 56870
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo() {} // 0x000000018350B670-0x000000018350B680
			public ControllerAssignmentSaveInfo(int playerCount) {} // 0x00000001893E2568-0x00000001893E2630
	
			// Methods
			public int IndexOfPlayer(int playerId) => default; // 0x00000001893E24EC-0x00000001893E2568
			public bool ContainsPlayer(int playerId) => default; // 0x00000001893E24D4-0x00000001893E24EC
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 56872
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo() {} // Dummy constructor
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId) {} // 0x00000001893E61F8-0x00000001893E6274
		}
	
		protected interface IDataStore // TypeDefIndex: 56873
		{
			// Methods
			bool Save();
			bool Load();
			bool Clear();
			bool TryGetValue(string key, out object result);
			bool SetValue(string key, object value);
		}
	
		// Constructors
		protected UserDataStore_KeyValue() {} // 0x00000001893F477C-0x00000001893F47F8
		static UserDataStore_KeyValue() {} // 0x00000001893F46E4-0x00000001893F477C
	
		// Methods
		public override void Save() {} // 0x00000001893F4354-0x00000001893F4410
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F36D8-0x00000001893F37BC
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F3604-0x00000001893F36D8
		public override void SavePlayerData(int playerId) {} // 0x00000001893F4294-0x00000001893F4354
		public override void SaveInputBehavior(int playerId, int behaviorId) {} // 0x00000001893F3DE8-0x00000001893F3EB8
		public override void Load() {} // 0x00000001893F2D8C-0x00000001893F2E48
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F0CE8-0x00000001893F0DCC
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F0DCC-0x00000001893F0E9C
		public override void LoadPlayerData(int playerId) {} // 0x00000001893F2CCC-0x00000001893F2D8C
		public override void LoadInputBehavior(int playerId, int behaviorId) {} // 0x00000001893F1450-0x00000001893F1520
		protected override void OnInitialize() {} // 0x00000001893F2F20-0x00000001893F2FA8
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x00000001893F2E48-0x00000001893F2EC0
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x00000001893F2EF0-0x00000001893F2F20
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x00000001893F2EC0-0x00000001893F2EF0
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x00000001893F3994-0x00000001893F3A38
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F0FB0-0x00000001893F1070
		public virtual void ClearSaveData() {} // 0x00000001893EFAA0-0x00000001893EFB18
		private int LoadAll() => default; // 0x00000001893F0954-0x00000001893F0A58
		private int LoadPlayerDataNow(int playerId) => default; // 0x00000001893F2A34-0x00000001893F2AA4
		private int LoadPlayerDataNow(Player player) => default; // 0x00000001893F2AA4-0x00000001893F2CCC
		private int LoadAllJoystickCalibrationData() => default; // 0x00000001893F0888-0x00000001893F0954
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick) => default; // 0x00000001893F257C-0x00000001893F25B4
		private int LoadJoystickCalibrationData(int joystickId) => default; // 0x00000001893F25B4-0x00000001893F2624
		private int LoadJoystickData(int joystickId) => default; // 0x00000001893F2624-0x00000001893F276C
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F0C5C-0x00000001893F0CC8
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F0CC8-0x00000001893F0CE8
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F1070-0x00000001893F12E8
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F0E9C-0x00000001893F0FB0
		private int LoadInputBehaviors(int playerId) => default; // 0x00000001893F1520-0x00000001893F1648
		private int LoadInputBehaviorNow(int playerId, int behaviorId) => default; // 0x00000001893F12E8-0x00000001893F13AC
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => default; // 0x00000001893F13AC-0x00000001893F1450
		private bool LoadControllerAssignmentsNow() => default; // 0x00000001893F0B9C-0x00000001893F0C5C
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001893F276C-0x00000001893F2A34
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001893F16A4-0x00000001893F257C
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData() => default; // 0x00000001893F0A58-0x00000001893F0B9C
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__73))]
		private IEnumerator LoadJoystickAssignmentsDeferred() => default; // 0x00000001893F1648-0x00000001893F16A4
		private void SaveAll() {} // 0x00000001893F30E0-0x00000001893F31DC
		private void SavePlayerDataNow(int playerId) {} // 0x00000001893F420C-0x00000001893F4294
		private void SavePlayerDataNow(Player player) {} // 0x00000001893F4148-0x00000001893F420C
		private void SaveAllJoystickCalibrationData() {} // 0x00000001893F3024-0x00000001893F30E0
		private void SaveJoystickCalibrationData(int joystickId) {} // 0x00000001893F3F24-0x00000001893F3F94
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick) {} // 0x00000001893F3F94-0x00000001893F4028
		private void SaveJoystickData(int joystickId) {} // 0x00000001893F4028-0x00000001893F4148
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F35A8-0x00000001893F35F0
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F35F0-0x00000001893F3604
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) {} // 0x00000001893F3B44-0x00000001893F3C98
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F3A38-0x00000001893F3B44
		private void SaveControllerMap(Player player, ControllerMap controllerMap) {} // 0x00000001893F37BC-0x00000001893F3994
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) {} // 0x00000001893F3EB8-0x00000001893F3F24
		private void SaveInputBehaviorNow(int playerId, int behaviorId) {} // 0x00000001893F3D0C-0x00000001893F3DE8
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) {} // 0x00000001893F3C98-0x00000001893F3D0C
		private bool SaveControllerAssignments() => default; // 0x00000001893F31DC-0x00000001893F35A8
		private static void AppendBaseKey(StringBuilder sb, Player player) {} // 0x00000001893EF7DC-0x00000001893EF84C
		private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x00000001893EFD70-0x00000001893EFE8C
		private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x00000001893EFE8C-0x00000001893EFFA8
		private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion) {} // 0x00000001893EF84C-0x00000001893EFAA0
		private string GetJoystickCalibrationMapKey(Rewired.Joystick joystick) => default; // 0x00000001893F06F0-0x00000001893F0888
		private string GetInputBehaviorKey(Player player, int inputBehaviorId) => default; // 0x00000001893F0574-0x00000001893F066C
		private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893EFC68-0x00000001893EFD70
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893EFFA8-0x00000001893F0180
		private string GetJoystickCalibrationMapJson(Rewired.Joystick joystick) => default; // 0x00000001893F066C-0x00000001893F06F0
		private string GetInputBehaviorJson(Player player, int id) => default; // 0x00000001893F04E0-0x00000001893F0574
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) {} // 0x00000001893EF2EC-0x00000001893EF7DC
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) => default; // 0x00000001893EFB18-0x00000001893EFC68
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches) {
			matches = default;
			return default;
		} // 0x00000001893F4410-0x00000001893F45C4
		private void RefreshLayoutManager(int playerId) {} // 0x00000001893F2FA8-0x00000001893F3024
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => default; // 0x00000001893F0180-0x00000001893F04E0
		private static bool TryGetString(IDataStore store, string key, out string result) {
			result = default;
			return default;
		} // 0x00000001893F45C4-0x00000001893F46E4
	}

	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 56887
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x01FD8675
		private const string logPrefix = "Rewired: "; // Metadata: 0x01FD868F
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x01FD8699
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x01FD8864
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x01FD887A
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x01FD887B
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x01FD887C
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x01FD887D
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x01FD887E
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
		public bool IsEnabled { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool LoadDataOnStart { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public bool LoadJoystickAssignments { get => default; set {} } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000183D4EFD0-0x0000000183D4EFE0
		public bool LoadKeyboardAssignments { get => default; set {} } // 0x0000000183D52270-0x0000000183D52280 0x0000000183D522A0-0x0000000183D522B0
		public bool LoadMouseAssignments { get => default; set {} } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
		public string PlayerPrefsKeyPrefix { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		private string playerPrefsKey_controllerAssignments { get => default; } // 0x00000001893F9B54-0x00000001893F9C3C 
		private bool loadControllerAssignments { get => default; } // 0x00000001893F4A50-0x00000001893F4A64 
		private List<int> allActionIds { get => default; } // 0x00000001893F9A14-0x00000001893F9B54 
		private string allActionIdsString { get => default; } // 0x00000001893F98FC-0x00000001893F9A14 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 56881
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get => default; } // 0x000000018352ADE0-0x000000018352AE00 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 56879
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get => default; } // 0x00000001893E6B70-0x00000001893E6B84 
	
				// Constructors
				public PlayerInfo() {} // 0x000000018350B670-0x000000018350B680
	
				// Methods
				public int IndexOfJoystick(int joystickId) => default; // 0x00000001893E6AF4-0x00000001893E6B70
				public bool ContainsJoystick(int joystickId) => default; // 0x00000001893E6ADC-0x00000001893E6AF4
			}
	
			public class JoystickInfo // TypeDefIndex: 56880
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo() {} // 0x000000018350B670-0x000000018350B680
			public ControllerAssignmentSaveInfo(int playerCount) {} // 0x00000001893E2630-0x00000001893E26F8
	
			// Methods
			public int IndexOfPlayer(int playerId) => default; // 0x00000001893E24EC-0x00000001893E2568
			public bool ContainsPlayer(int playerId) => default; // 0x00000001893E24D4-0x00000001893E24EC
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 56882
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo() {} // Dummy constructor
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId) {} // 0x00000001893E617C-0x00000001893E61F8
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs() {} // 0x00000001893F98A4-0x00000001893F98FC
	
		// Methods
		public override void Save() {} // 0x00000001893F9684-0x00000001893F96F0
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F8B14-0x00000001893F8BAC
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F8BAC-0x00000001893F8C34
		public override void SavePlayerData(int playerId) {} // 0x00000001893F960C-0x00000001893F9684
		public override void SaveInputBehavior(int playerId, int behaviorId) {} // 0x00000001893F91D8-0x00000001893F9260
		public override void Load() {} // 0x00000001893F8324-0x00000001893F8390
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F642C-0x00000001893F64C4
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F63A4-0x00000001893F642C
		public override void LoadPlayerData(int playerId) {} // 0x00000001893F82AC-0x00000001893F8324
		public override void LoadInputBehavior(int playerId, int behaviorId) {} // 0x00000001893F6A78-0x00000001893F6B00
		protected override void OnInitialize() {} // 0x00000001893F8468-0x00000001893F84F0
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x00000001893F8390-0x00000001893F8408
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x00000001893F8438-0x00000001893F8468
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x00000001893F8408-0x00000001893F8438
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x00000001893F8C34-0x00000001893F8CC0
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F64C4-0x00000001893F6584
		private int LoadAll() => default; // 0x00000001893F603C-0x00000001893F6140
		private int LoadPlayerDataNow(int playerId) => default; // 0x00000001893F8014-0x00000001893F8084
		private int LoadPlayerDataNow(Player player) => default; // 0x00000001893F8084-0x00000001893F82AC
		private int LoadAllJoystickCalibrationData() => default; // 0x00000001893F5F70-0x00000001893F603C
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick) => default; // 0x00000001893F7B5C-0x00000001893F7B94
		private int LoadJoystickCalibrationData(int joystickId) => default; // 0x00000001893F7B94-0x00000001893F7C04
		private int LoadJoystickData(int joystickId) => default; // 0x00000001893F7C04-0x00000001893F7D4C
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F6318-0x00000001893F6384
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F6384-0x00000001893F63A4
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x00000001893F6698-0x00000001893F6910
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F6584-0x00000001893F6698
		private int LoadInputBehaviors(int playerId) => default; // 0x00000001893F6B00-0x00000001893F6C28
		private int LoadInputBehaviorNow(int playerId, int behaviorId) => default; // 0x00000001893F69B4-0x00000001893F6A78
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => default; // 0x00000001893F6910-0x00000001893F69B4
		private bool LoadControllerAssignmentsNow() => default; // 0x00000001893F6258-0x00000001893F6318
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001893F7D4C-0x00000001893F8014
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001893F6C84-0x00000001893F7B5C
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData() => default; // 0x00000001893F6140-0x00000001893F6258
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__80))]
		private IEnumerator LoadJoystickAssignmentsDeferred() => default; // 0x00000001893F6C28-0x00000001893F6C84
		private void SaveAll() {} // 0x00000001893F8628-0x00000001893F870C
		private void SavePlayerDataNow(int playerId) {} // 0x00000001893F94D0-0x00000001893F9548
		private void SavePlayerDataNow(Player player) {} // 0x00000001893F9548-0x00000001893F960C
		private void SaveAllJoystickCalibrationData() {} // 0x00000001893F856C-0x00000001893F8628
		private void SaveJoystickCalibrationData(int joystickId) {} // 0x00000001893F92CC-0x00000001893F933C
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick) {} // 0x00000001893F933C-0x00000001893F93B0
		private void SaveJoystickData(int joystickId) {} // 0x00000001893F93B0-0x00000001893F94D0
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F8AC8-0x00000001893F8B14
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F8AA4-0x00000001893F8AC8
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) {} // 0x00000001893F8E64-0x00000001893F8FB8
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x00000001893F8FB8-0x00000001893F90C4
		private void SaveControllerMap(Player player, ControllerMap controllerMap) {} // 0x00000001893F8CC0-0x00000001893F8E64
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) {} // 0x00000001893F9260-0x00000001893F92CC
		private void SaveInputBehaviorNow(int playerId, int behaviorId) {} // 0x00000001893F9110-0x00000001893F91D8
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) {} // 0x00000001893F90C4-0x00000001893F9110
		private bool SaveControllerAssignments() => default; // 0x00000001893F870C-0x00000001893F8AA4
		private bool ControllerAssignmentSaveDataExists() => default; // 0x00000001893F4F54-0x00000001893F4FA0
		private string GetBasePlayerPrefsKey(Player player) => default; // 0x00000001893F50F0-0x00000001893F5154
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x00000001893F56BC-0x00000001893F5784
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x00000001893F5154-0x00000001893F521C
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x00000001893F53B8-0x00000001893F56BC
		private string GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick) => default; // 0x00000001893F5DCC-0x00000001893F5EFC
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) => default; // 0x00000001893F5CBC-0x00000001893F5D48
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F58A4-0x00000001893F595C
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001893F521C-0x00000001893F53B8
		private string GetJoystickCalibrationMapXml(Rewired.Joystick joystick) => default; // 0x00000001893F5EFC-0x00000001893F5F70
		private string GetInputBehaviorXml(Player player, int id) => default; // 0x00000001893F5D48-0x00000001893F5DCC
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) {} // 0x00000001893F4A64-0x00000001893F4F54
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) => default; // 0x00000001893F4FA0-0x00000001893F50F0
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches) {
			matches = default;
			return default;
		} // 0x00000001893F96F0-0x00000001893F98A4
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => default; // 0x00000001893F595C-0x00000001893F5CBC
		private void RefreshLayoutManager(int playerId) {} // 0x00000001893F84F0-0x00000001893F856C
		private static System.Type GetControllerMapType(Rewired.ControllerType controllerType) => default; // 0x00000001893F5784-0x00000001893F58A4
	}
}

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 56889
	{
		// Properties
		public int playerId { get; set; } // 0x0000000183D5AFA0-0x0000000183D5AFB0 0x0000000183D72300-0x0000000183D72310
		public int inputSourceIndex { get; set; } // 0x0000000183D5A840-0x0000000183D5A850 0x0000000183D5A8C0-0x0000000183D5A8D0
		public IMouseInputSource mouseSource { get; set; } // 0x0000000183D570F0-0x0000000183D57100 0x00000001858B3CA4-0x00000001858B3CB8
		public ITouchInputSource touchSource { get; set; } // 0x0000000183D574A0-0x0000000183D574B0 0x0000000184275C18-0x0000000184275C2C
		public PointerEventType sourceType { get; set; } // 0x0000000183D6D0A0-0x0000000183D6D0B0 0x0000000183D72310-0x0000000183D72320
		public int buttonIndex { get; set; } // 0x0000000183D5DB50-0x0000000183D5DB60 0x0000000183D5DB60-0x0000000183D5DB70
	
		// Constructors
		public PlayerPointerEventData() {} // Dummy constructor
		public PlayerPointerEventData(EventSystem eventSystem) {} // 0x00000001893E6DD0-0x00000001893E6DFC
	
		// Methods
		public override string ToString() => default; // 0x00000001893E6B84-0x00000001893E6DD0
	}

	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem // TypeDefIndex: 56890
	{
		// Fields
		[SerializeField]
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		private bool _alwaysUpdate; // 0x50
	
		// Properties
		public bool alwaysUpdate { get => default; set {} } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
	
		// Constructors
		public RewiredEventSystem() {} // 0x00000001893E7A18-0x00000001893E7A64
	
		// Methods
		protected override void Update() {} // 0x00000001893E78DC-0x00000001893E7A18
	}

	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 56895
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x01FD887F
		public const int kMouseRightId = -2; // Metadata: 0x01FD8880
		public const int kMouseMiddleId = -3; // Metadata: 0x01FD8881
		public const int kFakeTouchesId = -4; // Metadata: 0x01FD8882
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x01FD8883
		private const int customButtonsMaxCount = 128; // Metadata: 0x01FD8888
		private const int customButtonsLastId = -2147483392; // Metadata: 0x01FD888A
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x00000001893EA2DC-0x00000001893EA344 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x00000001893EA344-0x00000001893EA34C 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x00000001893EA344-0x00000001893EA34C 
		protected virtual bool isMouseSupported { get; } // 0x00000001893EA34C-0x00000001893EA400 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 56891
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState() {} // 0x00000001893E6A64-0x00000001893E6ADC
	
			// Methods
			public bool AnyPressesThisFrame() => default; // 0x00000001893E67E0-0x00000001893E686C
			public bool AnyReleasesThisFrame() => default; // 0x00000001893E686C-0x00000001893E68F8
			public ButtonState GetButtonState(int button) => default; // 0x00000001893E68F8-0x00000001893E6A14
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data) {} // 0x00000001893E6A14-0x00000001893E6A64
		}
	
		public class MouseButtonEventData // TypeDefIndex: 56892
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool PressedThisFrame() => default; // 0x00000001893E67CC-0x00000001893E67E0
			public bool ReleasedThisFrame() => default; // 0x00000001871262D0-0x00000001871262E4
		}
	
		protected class ButtonState // TypeDefIndex: 56893
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public int button { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
			// Constructors
			public ButtonState() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 56894
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get => default; } // 0x00000001893EED78-0x00000001893EED8C 
			int ITouchInputSource.playerId { get => default; } // 0x00000001893EED78-0x00000001893EED8C 
			bool IMouseInputSource.enabled { get => default; } // 0x00000001893EED40-0x00000001893EED58 
			bool IMouseInputSource.locked { get => default; } // 0x00000001893EED58-0x00000001893EED78 
			int IMouseInputSource.buttonCount { get => default; } // 0x00000001893EED28-0x00000001893EED40 
			Vector2 IMouseInputSource.screenPosition { get => default; } // 0x00000001893EEDCC-0x00000001893EEDFC 
			Vector2 IMouseInputSource.screenPositionDelta { get => default; } // 0x00000001893EED8C-0x00000001893EEDCC 
			Vector2 IMouseInputSource.wheelDelta { get => default; } // 0x00000001893EEDFC-0x00000001893EEE14 
			bool ITouchInputSource.touchSupported { get => default; } // 0x00000001893EEE90-0x00000001893EEEA8 
			int ITouchInputSource.touchCount { get => default; } // 0x00000001893EEE78-0x00000001893EEE90 
	
			// Constructors
			public UnityInputSource() {} // 0x0000000183D5C2D0-0x0000000183D5C2E0
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button) => default; // 0x00000001893EECC8-0x00000001893EECE8
			bool IMouseInputSource.GetButtonUp(int button) => default; // 0x00000001893EECE8-0x00000001893EED08
			bool IMouseInputSource.GetButton(int button) => default; // 0x00000001893EED08-0x00000001893EED28
			Touch ITouchInputSource.GetTouch(int index) => default; // 0x00000001893EEE14-0x00000001893EEE78
			private void TryUpdate() {} // 0x00000001893EEEA8-0x00000001893EEF24
		}
	
		// Constructors
		protected RewiredPointerInputModule() {} // 0x00000001893EA1D8-0x00000001893EA2DC
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse) => default; // 0x00000001893E9578-0x00000001893E9594
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) => default; // 0x00000001893E85C4-0x00000001893E875C
		public void RemoveMouseInputSource(IMouseInputSource source) {} // 0x00000001893E9AC8-0x00000001893E9B70
		public void AddMouseInputSource(IMouseInputSource source) {} // 0x00000001893E7A64-0x00000001893E7B40
		public int GetMouseInputSourceCount(int playerId) => default; // 0x00000001893E84AC-0x00000001893E85C4
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) => default; // 0x00000001893E92B8-0x00000001893E932C
		public void RemoveTouchInputSource(ITouchInputSource source) {} // 0x00000001893E9C1C-0x00000001893E9C98
		public void AddTouchInputSource(ITouchInputSource source) {} // 0x00000001893E7B40-0x00000001893E7C04
		public int GetTouchInputSourceCount(int playerId) => default; // 0x00000001893E9290-0x00000001893E92B8
		protected void ClearMouseInputSources() {} // 0x00000001893E7C04-0x00000001893E7C4C
		protected abstract bool IsDefaultPlayer(int playerId);
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) {
			data = default;
			return default;
		} // 0x00000001893E8F28-0x00000001893E9290
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) => default; // 0x00000001893E8080-0x00000001893E81BC
		protected void RemovePointerData(PlayerPointerEventData data) {} // 0x00000001893E9B70-0x00000001893E9C1C
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) {
			pressed = default;
			released = default;
			return default;
		} // 0x00000001893E932C-0x00000001893E9578
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex) => default; // 0x00000001893E875C-0x00000001893E8F28
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) => default; // 0x00000001893E8288-0x00000001893E84AC
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) => default; // 0x00000001893E9C98-0x00000001893E9CD8
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent) {} // 0x00000001893E99E4-0x00000001893E9AC8
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent) {} // 0x00000001893E9784-0x00000001893E99E4
		public override bool IsPointerOverGameObject(int pointerTypeId) => default; // 0x00000001893E9594-0x00000001893E9784
		protected void ClearSelection() {} // 0x00000001893E7C4C-0x00000001893E7FA4
		public override string ToString() => default; // 0x00000001893E9D44-0x00000001893EA1D8
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x00000001893E81BC-0x00000001893E8288
		protected void CopyFromTo(PointerEventData from, PointerEventData to) {} // 0x00000001893E7FA4-0x00000001893E8080
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) => default; // 0x00000001893E9CD8-0x00000001893E9D44
	}

	public enum PointerEventType // TypeDefIndex: 56896
	{
		Mouse = 0,
		Touch = 1
	}

	[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 56898
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x01FD8891
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x01FD889E
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x01FD88A9
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x01FD88B2
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
		public InputManager_Base RewiredInputManager { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public bool UseAllRewiredGamePlayers { get => default; set {} } // 0x0000000183D4F800-0x0000000183D4F810 0x00000001893EDBAC-0x00000001893EDBC8
		public bool UseRewiredSystemPlayer { get => default; set {} } // 0x0000000183D51AE0-0x0000000183D51AF0 0x00000001893EDBC8-0x00000001893EDBE4
		public int[] RewiredPlayerIds { get => default; set {} } // 0x00000001893ED6F0-0x00000001893ED740 0x00000001893EDA18-0x00000001893EDAA4
		public bool UsePlayingPlayersOnly { get => default; set {} } // 0x0000000183D51D50-0x0000000183D51D60 0x0000000183D56D40-0x0000000183D56D50
		public List<Rewired.Components.PlayerMouse> PlayerMice { get => default; set {} } // 0x00000001893ED678-0x00000001893ED6F0 0x00000001893ED95C-0x00000001893EDA18
		public bool MoveOneElementPerAxisPress { get => default; set {} } // 0x0000000183D58690-0x0000000183D586A0 0x0000000183D5CE20-0x0000000183D5CE30
		public bool allowMouseInput { get => default; set {} } // 0x0000000183D51180-0x0000000183D51190 0x0000000183D511E0-0x0000000183D511F0
		public bool allowMouseInputIfTouchSupported { get => default; set {} } // 0x0000000183D51160-0x0000000183D51170 0x0000000183D511C0-0x0000000183D511D0
		public bool allowTouchInput { get => default; set {} } // 0x0000000183D51170-0x0000000183D51180 0x0000000183D511D0-0x0000000183D511E0
		public bool deselectIfBackgroundClicked { get => default; set {} } // 0x0000000183D51190-0x0000000183D511A0 0x0000000183D511F0-0x0000000183D51200
		private bool deselectBeforeSelecting { get => default; set {} } // 0x0000000183D72330-0x0000000183D72340 0x0000000183D72350-0x0000000183D72360
		public bool SetActionsById { get => default; set {} } // 0x0000000183D6E080-0x0000000183D6E090 0x00000001893EDAA4-0x00000001893EDABC
		public int HorizontalActionId { get => default; set {} } // 0x0000000183D51960-0x0000000183D51970 0x00000001893ED86C-0x00000001893ED95C
		public int VerticalActionId { get => default; set {} } // 0x0000000183D50E50-0x0000000183D50E60 0x00000001893EDBE4-0x00000001893EDCD4
		public int SubmitActionId { get => default; set {} } // 0x0000000183D51870-0x0000000183D51880 0x00000001893EDABC-0x00000001893EDBAC
		public int CancelActionId { get => default; set {} } // 0x0000000183D51860-0x0000000183D51870 0x00000001893ED77C-0x00000001893ED86C
		protected override bool isMouseSupported { get => default; } // 0x00000001893ED740-0x00000001893ED77C 
		private bool isTouchAllowed { get => default; } // 0x0000000183D51170-0x0000000183D51180 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool allowActivationOnMobileDevice { get => default; set {} } // 0x0000000183D56760-0x0000000183D56770 0x0000000183D72340-0x0000000183D72350
		public bool forceModuleActive { get => default; set {} } // 0x0000000183D56760-0x0000000183D56770 0x0000000183D72340-0x0000000183D72350
		public float inputActionsPerSecond { get => default; set {} } // 0x0000000183D57560-0x0000000183D57570 0x0000000183D57580-0x0000000183D57590
		public float repeatDelay { get => default; set {} } // 0x0000000183D57550-0x0000000183D57560 0x0000000183D57570-0x0000000183D57580
		public string horizontalAxis { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x00000001893EDD7C-0x00000001893EDE24
		public string verticalAxis { get => default; set {} } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001893EDECC-0x00000001893EDF74
		public string submitButton { get => default; set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001893EDE24-0x00000001893EDECC
		public string cancelButton { get => default; set {} } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001893EDCD4-0x00000001893EDD7C
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 56897
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting() {} // 0x00000001895F46E4-0x00000001895F475C
			private PlayerSetting(PlayerSetting other) {} // 0x00000001895F475C-0x00000001895F4984
	
			// Methods
			public PlayerSetting Clone() => default; // 0x00000001895F4684-0x00000001895F46E4
		}
	
		// Constructors
		private RewiredStandaloneInputModule() {} // 0x00000001893ED4E8-0x00000001893ED678
	
		// Methods
		protected override void Awake() {} // 0x00000001893EA4B8-0x00000001893EA5BC
		public override void UpdateModule() {} // 0x00000001893ED480-0x00000001893ED4E8
		public override bool IsModuleSupported() => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool ShouldActivateModule() => default; // 0x00000001893ED128-0x00000001893ED418
		public override void ActivateModule() {} // 0x00000001893EA400-0x00000001893EA4B8
		public override void DeactivateModule() {} // 0x00000001893EA7C4-0x00000001893EA7CC
		public override void Process() {} // 0x00000001893EC3C0-0x00000001893EC4B0
		private bool ProcessTouchEvents() => default; // 0x00000001893EBCB4-0x00000001893EBE18
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x00000001893EBE18-0x00000001893EC3C0
		private bool SendSubmitEventToSelectedObject() => default; // 0x00000001893EC768-0x00000001893EC958
		private Vector2 GetRawMoveVector() => default; // 0x00000001893EAB20-0x00000001893EADDC
		private bool SendMoveEventToSelectedObject() => default; // 0x00000001893EC4B0-0x00000001893EC768
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical) {
			downHorizontal = default;
			downVertical = default;
		} // 0x00000001893EA5BC-0x00000001893EA728
		private void ProcessMouseEvents() {} // 0x00000001893EB624-0x00000001893EB764
		private void ProcessMouseEvent(int playerId, int pointerIndex) {} // 0x00000001893EB370-0x00000001893EB624
		private bool SendUpdateEventToSelectedObject() => default; // 0x00000001893EC958-0x00000001893ECA2C
		private void ProcessMousePress(MouseButtonEventData data) {} // 0x00000001893EB764-0x00000001893EBCB4
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x00000001893EADDC-0x00000001893EAF48
		private void OnApplicationFocus(bool hasFocus) {} // 0x0000000183D72320-0x0000000183D72330
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x00000001893ED418-0x00000001893ED480
		protected override void OnDestroy() {} // 0x00000001893EB23C-0x00000001893EB350
		protected override bool IsDefaultPlayer(int playerId) => default; // 0x00000001893EB0E0-0x00000001893EB23C
		private void InitializeRewired() {} // 0x00000001893EAF48-0x00000001893EB0E0
		private void SetupRewiredVars() {} // 0x00000001893ECDC8-0x00000001893ED128
		private void SetUpRewiredPlayerMice() {} // 0x00000001893ECCDC-0x00000001893ECDC8
		private void SetUpRewiredActions() {} // 0x00000001893ECA2C-0x00000001893ECCDC
		private bool GetButton(Player player, int actionId) => default; // 0x00000001893EA964-0x00000001893EA998
		private bool GetButtonDown(Player player, int actionId) => default; // 0x00000001893EA930-0x00000001893EA964
		private bool GetNegativeButton(Player player, int actionId) => default; // 0x00000001893EAAEC-0x00000001893EAB20
		private bool GetNegativeButtonDown(Player player, int actionId) => default; // 0x00000001893EAAB8-0x00000001893EAAEC
		private float GetAxis(Player player, int actionId) => default; // 0x00000001893EA8FC-0x00000001893EA930
		private void CheckEditorRecompile() {} // 0x00000001893EA728-0x00000001893EA784
		private void OnEditorRecompile() {} // 0x00000001893EB350-0x00000001893EB360
		private void ClearRewiredVars() {} // 0x00000001893EA784-0x00000001893EA7C4
		private bool DidAnyMouseMove() => default; // 0x00000001893EA7CC-0x00000001893EA8FC
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) => default; // 0x00000001893EA998-0x00000001893EAAB8
		private void OnRewiredInitialized() {} // 0x00000001893EB360-0x00000001893EB368
		private void OnRewiredShutDown() {} // 0x00000001893EB368-0x00000001893EB370
	}
}

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 56888
	{
		// Fields
		private static readonly System.Type[] _defaultTemplateTypes; // 0x00
		private static readonly System.Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static System.Type[] templateTypes { get; } // 0x00000001893E2984-0x00000001893E29D4 
		public static System.Type[] templateInterfaceTypes { get; } // 0x00000001893E2934-0x00000001893E2984 
	
		// Constructors
		static ControllerTemplateFactory() {} // 0x000000018384DD70-0x000000018384E100
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload) => default; // 0x00000001893E26F8-0x00000001893E2934
	}
}

namespace Rewired.Localization
{
	[AddComponentMenu("Rewired/Localization/Localized String Provider")]
	public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 56899
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
		protected virtual Dictionary<string, string> dictionary { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public virtual TextAsset localizedStringsFile { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x00000001895F4660-0x00000001895F4684
		protected override bool initialized { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
	
		// Constructors
		public LocalizedStringProvider() {} // 0x00000001895F45E0-0x00000001895F4660
	
		// Methods
		protected override bool Initialize() => default; // 0x00000001895F43BC-0x00000001895F43D8
		protected virtual bool TryLoadLocalizedStringData() => default; // 0x00000001895F4454-0x00000001895F45E0
		protected override bool TryGetLocalizedString(string key, out string result) {
			result = default;
			return default;
		} // 0x00000001895F43D8-0x00000001895F4454
	}

	public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 56900
	{
		// Fields
		[SerializeField]
		[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
		private bool _prefetch; // 0x18
	
		// Properties
		public virtual bool prefetch { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x00000001895F42E8-0x00000001895F43BC
		protected abstract bool initialized { get; }
	
		// Constructors
		protected LocalizedStringProviderBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001895F3FE4-0x00000001895F401C
		protected virtual void OnDisable() {} // 0x00000001895F3EF4-0x00000001895F3FE4
		protected virtual void Update() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void TrySetLocalizedStringProvider() {} // 0x00000001895F4134-0x00000001895F42E8
		protected abstract bool Initialize();
		public virtual void Reload() {} // 0x00000001895F401C-0x00000001895F40E8
		protected abstract bool TryGetLocalizedString(string key, out string result);
		bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result) {
			result = default;
			return default;
		} // 0x00000001895F40E8-0x00000001895F4134
	}
}

namespace Rewired.Utils
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools // TypeDefIndex: 56860
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get => default; set {} } // 0x00000001893E3390-0x00000001893E33C8 0x00000001893E34C8-0x00000001893E3518
		public bool isEditorPaused { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public bool UnityInput_IsTouchPressureSupported { get => default; } // 0x00000001893E3388-0x00000001893E3390 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent;
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;
	
		// Constructors
		public ExternalTools() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Destroy() {} // 0x000000018350B670-0x000000018350B680
		public object GetPlatformInitializer() => default; // 0x0000000184276AD8-0x0000000184276AE0
		public string GetFocusedEditorWindowTitle() => default; // 0x00000001893E3150-0x00000001893E3188
		public bool IsEditorSceneViewFocused() => default; // 0x000000018115F4C0-0x000000018115F530
		public bool LinuxInput_IsJoystickPreconfigured(string name) => default; // 0x000000018115F4C0-0x000000018115F530
		public int XboxOneInput_GetUserIdForGamepad(uint id) => default; // 0x0000000181002730-0x0000000181002740
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId) => default; // 0x0000000181002730-0x0000000181002740
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) => default; // 0x000000018115F4C0-0x000000018115F530
		public string XboxOneInput_GetControllerType(ulong xboxControllerId) => default; // 0x00000001893E32C4-0x00000001893E32FC
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) => default; // 0x0000000181002730-0x0000000181002740
		public void XboxOne_Gamepad_UpdatePlugin() {} // 0x000000018350B670-0x000000018350B680
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) => default; // 0x000000018115F4C0-0x000000018115F530
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) {} // 0x000000018350B670-0x000000018350B680
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids) {
			vids = default;
			pids = default;
		} // 0x00000001893E30A0-0x00000001893E3150
		public int GetAndroidAPILevel() => default; // 0x0000000183D5CD90-0x0000000183D5CDA0
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) {} // 0x0000000183269810-0x0000000183269870
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic) => default; // 0x00000001893E3188-0x00000001893E321C
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) {} // 0x00000001893E321C-0x00000001893E32C4
		public float UnityInput_GetTouchPressure(ref Touch touch) => default; // 0x0000000183D722F0-0x0000000183D72300
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) => default; // 0x0000000183D722E0-0x0000000183D722F0
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) => default; // 0x00000001893E3044-0x00000001893E30A0
		public System.Type[] GetControllerTemplateTypes() => default; // 0x0000000182CA4470-0x0000000182CA4560
		public System.Type[] GetControllerTemplateInterfaceTypes() => default; // 0x0000000182CA4560-0x0000000182CA4600
	}
}
