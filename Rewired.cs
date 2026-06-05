/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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

// Image 49: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57849-57903

namespace Rewired
{
	public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 57850
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

	public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 57851
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

	public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 57852
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

	public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 57853
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

	public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 57854
	{
		// Properties
		IControllerTemplateAxis leftPedal { get; }
		IControllerTemplateAxis rightPedal { get; }
		IControllerTemplateAxis slide { get; }
	}

	public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 57855
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

	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 57856
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x0207DCD0
		public const int elementId_leftStickY = 1; // Metadata: 0x0207DCD1
		public const int elementId_rightStickX = 2; // Metadata: 0x0207DCD2
		public const int elementId_rightStickY = 3; // Metadata: 0x0207DCD3
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x0207DCD4
		public const int elementId_a = 4; // Metadata: 0x0207DCD5
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x0207DCD6
		public const int elementId_b = 5; // Metadata: 0x0207DCD7
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x0207DCD8
		public const int elementId_c = 6; // Metadata: 0x0207DCD9
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x0207DCDA
		public const int elementId_x = 7; // Metadata: 0x0207DCDB
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x0207DCDC
		public const int elementId_y = 8; // Metadata: 0x0207DCDD
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x0207DCDE
		public const int elementId_z = 9; // Metadata: 0x0207DCDF
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x0207DCE0
		public const int elementId_leftBumper = 10; // Metadata: 0x0207DCE1
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x0207DCE2
		public const int elementId_leftTrigger = 11; // Metadata: 0x0207DCE3
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x0207DCE4
		public const int elementId_rightBumper = 12; // Metadata: 0x0207DCE5
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x0207DCE6
		public const int elementId_rightTrigger = 13; // Metadata: 0x0207DCE7
		public const int elementId_center1 = 14; // Metadata: 0x0207DCE8
		public const int elementId_back = 14; // Metadata: 0x0207DCE9
		public const int elementId_center2 = 15; // Metadata: 0x0207DCEA
		public const int elementId_start = 15; // Metadata: 0x0207DCEB
		public const int elementId_center3 = 16; // Metadata: 0x0207DCEC
		public const int elementId_guide = 16; // Metadata: 0x0207DCED
		public const int elementId_leftStickButton = 17; // Metadata: 0x0207DCEE
		public const int elementId_rightStickButton = 18; // Metadata: 0x0207DCEF
		public const int elementId_dPadUp = 19; // Metadata: 0x0207DCF0
		public const int elementId_dPadRight = 20; // Metadata: 0x0207DCF1
		public const int elementId_dPadDown = 21; // Metadata: 0x0207DCF2
		public const int elementId_dPadLeft = 22; // Metadata: 0x0207DCF3
		public const int elementId_leftStick = 23; // Metadata: 0x0207DCF4
		public const int elementId_rightStick = 24; // Metadata: 0x0207DCF5
		public const int elementId_dPad = 25; // Metadata: 0x0207DCF6
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get => default; } // 0x000000018B50A35C-0x000000018B50A39C 
		IControllerTemplateButton IGamepadTemplate.a { get => default; } // 0x000000018B50A31C-0x000000018B50A35C 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get => default; } // 0x000000018B50A39C-0x000000018B50A3DC 
		IControllerTemplateButton IGamepadTemplate.b { get => default; } // 0x000000018B50A4DC-0x000000018B50A51C 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get => default; } // 0x000000018B50A3DC-0x000000018B50A41C 
		IControllerTemplateButton IGamepadTemplate.c { get => default; } // 0x000000018B50A55C-0x000000018B50A59C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get => default; } // 0x000000018B50A41C-0x000000018B50A45C 
		IControllerTemplateButton IGamepadTemplate.x { get => default; } // 0x000000018B50A99C-0x000000018B50A9DC 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get => default; } // 0x000000018B50A45C-0x000000018B50A49C 
		IControllerTemplateButton IGamepadTemplate.y { get => default; } // 0x000000018B50A9DC-0x000000018B50AA1C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get => default; } // 0x000000018B50A49C-0x000000018B50A4DC 
		IControllerTemplateButton IGamepadTemplate.z { get => default; } // 0x000000018B50AA1C-0x000000018B50AA5C 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get => default; } // 0x000000018B50A71C-0x000000018B50A75C 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get => default; } // 0x000000018B50A6DC-0x000000018B50A71C 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get => default; } // 0x000000018B50A75C-0x000000018B50A79C 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get => default; } // 0x000000018B50A7DC-0x000000018B50A81C 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get => default; } // 0x000000018B50A85C-0x000000018B50A89C 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get => default; } // 0x000000018B50A81C-0x000000018B50A85C 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get => default; } // 0x000000018B50A89C-0x000000018B50A8DC 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get => default; } // 0x000000018B50A91C-0x000000018B50A95C 
		IControllerTemplateButton IGamepadTemplate.center1 { get => default; } // 0x000000018B50A59C-0x000000018B50A5DC 
		IControllerTemplateButton IGamepadTemplate.back { get => default; } // 0x000000018B50A51C-0x000000018B50A55C 
		IControllerTemplateButton IGamepadTemplate.center2 { get => default; } // 0x000000018B50A5DC-0x000000018B50A61C 
		IControllerTemplateButton IGamepadTemplate.start { get => default; } // 0x000000018B50A95C-0x000000018B50A99C 
		IControllerTemplateButton IGamepadTemplate.center3 { get => default; } // 0x000000018B50A61C-0x000000018B50A65C 
		IControllerTemplateButton IGamepadTemplate.guide { get => default; } // 0x000000018B50A69C-0x000000018B50A6DC 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get => default; } // 0x000000018B50A79C-0x000000018B50A7DC 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get => default; } // 0x000000018B50A8DC-0x000000018B50A91C 
		IControllerTemplateDPad IGamepadTemplate.dPad { get => default; } // 0x000000018B50A65C-0x000000018B50A69C 
	
		// Constructors
		public GamepadTemplate() {} // Dummy constructor
		public GamepadTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static GamepadTemplate() {} // 0x000000018B50AA5C-0x000000018B50AAC0
	}

	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 57857
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x0207DCF7
		public const int elementId_accelerator = 1; // Metadata: 0x0207DCF8
		public const int elementId_brake = 2; // Metadata: 0x0207DCF9
		public const int elementId_clutch = 3; // Metadata: 0x0207DCFA
		public const int elementId_shiftDown = 4; // Metadata: 0x0207DCFB
		public const int elementId_shiftUp = 5; // Metadata: 0x0207DCFC
		public const int elementId_wheelButton1 = 6; // Metadata: 0x0207DCFD
		public const int elementId_wheelButton2 = 7; // Metadata: 0x0207DCFE
		public const int elementId_wheelButton3 = 8; // Metadata: 0x0207DCFF
		public const int elementId_wheelButton4 = 9; // Metadata: 0x0207DD00
		public const int elementId_wheelButton5 = 10; // Metadata: 0x0207DD01
		public const int elementId_wheelButton6 = 11; // Metadata: 0x0207DD02
		public const int elementId_wheelButton7 = 12; // Metadata: 0x0207DD03
		public const int elementId_wheelButton8 = 13; // Metadata: 0x0207DD04
		public const int elementId_wheelButton9 = 14; // Metadata: 0x0207DD05
		public const int elementId_wheelButton10 = 15; // Metadata: 0x0207DD06
		public const int elementId_consoleButton1 = 16; // Metadata: 0x0207DD07
		public const int elementId_consoleButton2 = 17; // Metadata: 0x0207DD08
		public const int elementId_consoleButton3 = 18; // Metadata: 0x0207DD09
		public const int elementId_consoleButton4 = 19; // Metadata: 0x0207DD0A
		public const int elementId_consoleButton5 = 20; // Metadata: 0x0207DD0B
		public const int elementId_consoleButton6 = 21; // Metadata: 0x0207DD0C
		public const int elementId_consoleButton7 = 22; // Metadata: 0x0207DD0D
		public const int elementId_consoleButton8 = 23; // Metadata: 0x0207DD0E
		public const int elementId_consoleButton9 = 24; // Metadata: 0x0207DD0F
		public const int elementId_consoleButton10 = 25; // Metadata: 0x0207DD10
		public const int elementId_shifter1 = 26; // Metadata: 0x0207DD11
		public const int elementId_shifter2 = 27; // Metadata: 0x0207DD12
		public const int elementId_shifter3 = 28; // Metadata: 0x0207DD13
		public const int elementId_shifter4 = 29; // Metadata: 0x0207DD14
		public const int elementId_shifter5 = 30; // Metadata: 0x0207DD15
		public const int elementId_shifter6 = 31; // Metadata: 0x0207DD16
		public const int elementId_shifter7 = 32; // Metadata: 0x0207DD17
		public const int elementId_shifter8 = 33; // Metadata: 0x0207DD18
		public const int elementId_shifter9 = 34; // Metadata: 0x0207DD19
		public const int elementId_shifter10 = 35; // Metadata: 0x0207DD1A
		public const int elementId_reverseGear = 44; // Metadata: 0x0207DD1B
		public const int elementId_select = 36; // Metadata: 0x0207DD1C
		public const int elementId_start = 37; // Metadata: 0x0207DD1D
		public const int elementId_systemButton = 38; // Metadata: 0x0207DD1E
		public const int elementId_horn = 43; // Metadata: 0x0207DD1F
		public const int elementId_dPadUp = 39; // Metadata: 0x0207DD20
		public const int elementId_dPadRight = 40; // Metadata: 0x0207DD21
		public const int elementId_dPadDown = 41; // Metadata: 0x0207DD22
		public const int elementId_dPadLeft = 42; // Metadata: 0x0207DD23
		public const int elementId_dPad = 45; // Metadata: 0x0207DD24
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get => default; } // 0x000000018B50D874-0x000000018B50D8B0 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get => default; } // 0x000000018B50CE34-0x000000018B50CE74 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get => default; } // 0x000000018B50CE74-0x000000018B50CEB4 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get => default; } // 0x000000018B50CEB4-0x000000018B50CEF4 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get => default; } // 0x000000018B50D274-0x000000018B50D2B4 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get => default; } // 0x000000018B50D2B4-0x000000018B50D2F4 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get => default; } // 0x000000018B50D634-0x000000018B50D674 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get => default; } // 0x000000018B50D674-0x000000018B50D6B4 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get => default; } // 0x000000018B50D6B4-0x000000018B50D6F4 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get => default; } // 0x000000018B50D6F4-0x000000018B50D734 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get => default; } // 0x000000018B50D734-0x000000018B50D774 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get => default; } // 0x000000018B50D774-0x000000018B50D7B4 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get => default; } // 0x000000018B50D7B4-0x000000018B50D7F4 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get => default; } // 0x000000018B50D7F4-0x000000018B50D834 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get => default; } // 0x000000018B50D834-0x000000018B50D874 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get => default; } // 0x000000018B50D5F4-0x000000018B50D634 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get => default; } // 0x000000018B50CF34-0x000000018B50CF74 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get => default; } // 0x000000018B50CF74-0x000000018B50CFB4 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get => default; } // 0x000000018B50CFB4-0x000000018B50CFF4 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get => default; } // 0x000000018B50CFF4-0x000000018B50D034 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get => default; } // 0x000000018B50D034-0x000000018B50D074 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get => default; } // 0x000000018B50D074-0x000000018B50D0B4 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get => default; } // 0x000000018B50D0B4-0x000000018B50D0F4 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get => default; } // 0x000000018B50D0F4-0x000000018B50D134 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get => default; } // 0x000000018B50D134-0x000000018B50D174 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get => default; } // 0x000000018B50CEF4-0x000000018B50CF34 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get => default; } // 0x000000018B50D334-0x000000018B50D374 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get => default; } // 0x000000018B50D374-0x000000018B50D3B4 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get => default; } // 0x000000018B50D3B4-0x000000018B50D3F4 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get => default; } // 0x000000018B50D3F4-0x000000018B50D434 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get => default; } // 0x000000018B50D434-0x000000018B50D474 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get => default; } // 0x000000018B50D474-0x000000018B50D4B4 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get => default; } // 0x000000018B50D4B4-0x000000018B50D4F4 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get => default; } // 0x000000018B50D4F4-0x000000018B50D534 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get => default; } // 0x000000018B50D534-0x000000018B50D574 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get => default; } // 0x000000018B50D2F4-0x000000018B50D334 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get => default; } // 0x000000018B50D1F4-0x000000018B50D234 
		IControllerTemplateButton IRacingWheelTemplate.select { get => default; } // 0x000000018B50D234-0x000000018B50D274 
		IControllerTemplateButton IRacingWheelTemplate.start { get => default; } // 0x000000018B50D574-0x000000018B50D5B4 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get => default; } // 0x000000018B50D5B4-0x000000018B50D5F4 
		IControllerTemplateButton IRacingWheelTemplate.horn { get => default; } // 0x000000018B50D1B4-0x000000018B50D1F4 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get => default; } // 0x000000018B50D174-0x000000018B50D1B4 
	
		// Constructors
		public RacingWheelTemplate() {} // Dummy constructor
		public RacingWheelTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static RacingWheelTemplate() {} // 0x000000018B50D8B0-0x000000018B50D914
	}

	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 57858
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x0207DD25
		public const int elementId_stickY = 1; // Metadata: 0x0207DD26
		public const int elementId_stickRotate = 2; // Metadata: 0x0207DD27
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x0207DD28
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x0207DD2A
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x0207DD2C
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x0207DD2E
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x0207DD30
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x0207DD32
		public const int elementId_stickTrigger = 3; // Metadata: 0x0207DD34
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x0207DD35
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x0207DD36
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x0207DD37
		public const int elementId_stickButton1 = 6; // Metadata: 0x0207DD39
		public const int elementId_stickButton2 = 7; // Metadata: 0x0207DD3A
		public const int elementId_stickButton3 = 8; // Metadata: 0x0207DD3B
		public const int elementId_stickButton4 = 9; // Metadata: 0x0207DD3C
		public const int elementId_stickButton5 = 10; // Metadata: 0x0207DD3D
		public const int elementId_stickButton6 = 11; // Metadata: 0x0207DD3E
		public const int elementId_stickButton7 = 12; // Metadata: 0x0207DD3F
		public const int elementId_stickButton8 = 13; // Metadata: 0x0207DD40
		public const int elementId_stickButton9 = 14; // Metadata: 0x0207DD41
		public const int elementId_stickButton10 = 15; // Metadata: 0x0207DD42
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x0207DD43
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x0207DD44
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x0207DD45
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x0207DD46
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x0207DD47
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x0207DD48
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x0207DD49
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x0207DD4A
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x0207DD4B
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x0207DD4C
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x0207DD4D
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x0207DD4F
		public const int elementId_stickHat1Up = 28; // Metadata: 0x0207DD51
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x0207DD52
		public const int elementId_stickHat1Right = 30; // Metadata: 0x0207DD53
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x0207DD54
		public const int elementId_stickHat1Down = 32; // Metadata: 0x0207DD55
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x0207DD56
		public const int elementId_stickHat1Left = 34; // Metadata: 0x0207DD57
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x0207DD58
		public const int elementId_stickHat2Up = 36; // Metadata: 0x0207DD59
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x0207DD5A
		public const int elementId_stickHat2Right = 38; // Metadata: 0x0207DD5B
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x0207DD5C
		public const int elementId_stickHat2Down = 40; // Metadata: 0x0207DD5D
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x0207DD5E
		public const int elementId_stickHat2Left = 42; // Metadata: 0x0207DD5F
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x0207DD60
		public const int elementId_stickHat3Up = 84; // Metadata: 0x0207DD61
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x0207DD63
		public const int elementId_stickHat3Right = 86; // Metadata: 0x0207DD65
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x0207DD67
		public const int elementId_stickHat3Down = 88; // Metadata: 0x0207DD69
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x0207DD6B
		public const int elementId_stickHat3Left = 90; // Metadata: 0x0207DD6D
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x0207DD6F
		public const int elementId_stickHat4Up = 92; // Metadata: 0x0207DD71
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x0207DD73
		public const int elementId_stickHat4Right = 94; // Metadata: 0x0207DD75
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x0207DD77
		public const int elementId_stickHat4Down = 96; // Metadata: 0x0207DD79
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x0207DD7B
		public const int elementId_stickHat4Left = 98; // Metadata: 0x0207DD7D
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x0207DD7F
		public const int elementId_mode1 = 44; // Metadata: 0x0207DD81
		public const int elementId_mode2 = 45; // Metadata: 0x0207DD82
		public const int elementId_mode3 = 46; // Metadata: 0x0207DD83
		public const int elementId_throttle1Axis = 49; // Metadata: 0x0207DD84
		public const int elementId_throttle2Axis = 155; // Metadata: 0x0207DD85
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x0207DD87
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x0207DD89
		public const int elementId_throttleButton1 = 50; // Metadata: 0x0207DD8B
		public const int elementId_throttleButton2 = 51; // Metadata: 0x0207DD8C
		public const int elementId_throttleButton3 = 52; // Metadata: 0x0207DD8D
		public const int elementId_throttleButton4 = 53; // Metadata: 0x0207DD8E
		public const int elementId_throttleButton5 = 54; // Metadata: 0x0207DD8F
		public const int elementId_throttleButton6 = 55; // Metadata: 0x0207DD90
		public const int elementId_throttleButton7 = 56; // Metadata: 0x0207DD91
		public const int elementId_throttleButton8 = 57; // Metadata: 0x0207DD92
		public const int elementId_throttleButton9 = 58; // Metadata: 0x0207DD93
		public const int elementId_throttleButton10 = 59; // Metadata: 0x0207DD94
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x0207DD95
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x0207DD96
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x0207DD97
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x0207DD98
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x0207DD99
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x0207DD9B
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x0207DD9D
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x0207DD9F
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x0207DDA1
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x0207DDA3
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x0207DDA5
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x0207DDA7
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x0207DDA9
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x0207DDAB
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x0207DDAD
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x0207DDAF
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x0207DDB1
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x0207DDB3
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x0207DDB5
		public const int elementId_throttleDial1 = 74; // Metadata: 0x0207DDB7
		public const int elementId_throttleDial2 = 142; // Metadata: 0x0207DDB9
		public const int elementId_throttleDial3 = 143; // Metadata: 0x0207DDBB
		public const int elementId_throttleDial4 = 144; // Metadata: 0x0207DDBD
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x0207DDBF
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x0207DDC1
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x0207DDC3
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x0207DDC5
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x0207DDC7
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x0207DDC9
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x0207DDCB
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x0207DDCD
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x0207DDCF
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x0207DDD1
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x0207DDD3
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x0207DDD5
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x0207DDD7
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x0207DDD9
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x0207DDDB
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x0207DDDD
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x0207DDDF
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x0207DDE1
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x0207DDE3
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x0207DDE5
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x0207DDE7
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x0207DDE9
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x0207DDEB
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x0207DDED
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x0207DDEF
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x0207DDF1
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x0207DDF3
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x0207DDF5
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x0207DDF7
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x0207DDF9
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x0207DDFB
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x0207DDFD
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x0207DDFF
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x0207DE01
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x0207DE03
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x0207DE05
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x0207DE07
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x0207DE09
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x0207DE0B
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x0207DE0D
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x0207DE0F
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x0207DE11
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x0207DE13
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x0207DE15
		public const int elementId_leftPedal = 168; // Metadata: 0x0207DE17
		public const int elementId_rightPedal = 169; // Metadata: 0x0207DE19
		public const int elementId_slidePedals = 170; // Metadata: 0x0207DE1B
		public const int elementId_stick = 171; // Metadata: 0x0207DE1D
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x0207DE1F
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x0207DE21
		public const int elementId_stickHat1 = 174; // Metadata: 0x0207DE23
		public const int elementId_stickHat2 = 175; // Metadata: 0x0207DE25
		public const int elementId_stickHat3 = 176; // Metadata: 0x0207DE27
		public const int elementId_stickHat4 = 177; // Metadata: 0x0207DE29
		public const int elementId_throttle1 = 178; // Metadata: 0x0207DE2B
		public const int elementId_throttle2 = 179; // Metadata: 0x0207DE2D
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x0207DE2F
		public const int elementId_throttleHat1 = 181; // Metadata: 0x0207DE31
		public const int elementId_throttleHat2 = 182; // Metadata: 0x0207DE33
		public const int elementId_throttleHat3 = 183; // Metadata: 0x0207DE35
		public const int elementId_throttleHat4 = 184; // Metadata: 0x0207DE37
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get => default; } // 0x000000018B50B400-0x000000018B50B440 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get => default; } // 0x000000018B50B3C0-0x000000018B50B400 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get => default; } // 0x000000018B50B340-0x000000018B50B380 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get => default; } // 0x000000018B50B380-0x000000018B50B3C0 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get => default; } // 0x000000018B50AF80-0x000000018B50AFC0 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get => default; } // 0x000000018B50AFC0-0x000000018B50B000 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get => default; } // 0x000000018B50B000-0x000000018B50B040 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get => default; } // 0x000000018B50B040-0x000000018B50B080 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get => default; } // 0x000000018B50B080-0x000000018B50B0C0 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get => default; } // 0x000000018B50B0C0-0x000000018B50B100 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get => default; } // 0x000000018B50B100-0x000000018B50B140 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get => default; } // 0x000000018B50B140-0x000000018B50B180 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get => default; } // 0x000000018B50B180-0x000000018B50B1C0 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get => default; } // 0x000000018B50AF40-0x000000018B50AF80 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get => default; } // 0x000000018B50AD00-0x000000018B50AD40 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get => default; } // 0x000000018B50AD40-0x000000018B50AD80 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get => default; } // 0x000000018B50AD80-0x000000018B50ADC0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get => default; } // 0x000000018B50ADC0-0x000000018B50AE00 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get => default; } // 0x000000018B50AE00-0x000000018B50AE40 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get => default; } // 0x000000018B50AE40-0x000000018B50AE80 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get => default; } // 0x000000018B50AE80-0x000000018B50AEC0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get => default; } // 0x000000018B50AEC0-0x000000018B50AF00 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get => default; } // 0x000000018B50AF00-0x000000018B50AF40 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get => default; } // 0x000000018B50AC40-0x000000018B50AC80 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get => default; } // 0x000000018B50AC80-0x000000018B50ACC0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get => default; } // 0x000000018B50ACC0-0x000000018B50AD00 
		IControllerTemplateButton IHOTASTemplate.mode1 { get => default; } // 0x000000018B50AB00-0x000000018B50AB40 
		IControllerTemplateButton IHOTASTemplate.mode2 { get => default; } // 0x000000018B50AB40-0x000000018B50AB80 
		IControllerTemplateButton IHOTASTemplate.mode3 { get => default; } // 0x000000018B50AB80-0x000000018B50ABC0 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get => default; } // 0x000000018B50B900-0x000000018B50B940 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get => default; } // 0x000000018B50B940-0x000000018B50B980 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get => default; } // 0x000000018B50B980-0x000000018B50B9C0 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get => default; } // 0x000000018B50B9C0-0x000000018B50BA00 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get => default; } // 0x000000018B50BA00-0x000000018B50BA40 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get => default; } // 0x000000018B50BA40-0x000000018B50BA80 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get => default; } // 0x000000018B50BA80-0x000000018B50BAC0 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get => default; } // 0x000000018B50BAC0-0x000000018B50BB00 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get => default; } // 0x000000018B50BB00-0x000000018B50BB40 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get => default; } // 0x000000018B50B8C0-0x000000018B50B900 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get => default; } // 0x000000018B50B680-0x000000018B50B6C0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get => default; } // 0x000000018B50B6C0-0x000000018B50B700 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get => default; } // 0x000000018B50B700-0x000000018B50B740 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get => default; } // 0x000000018B50B740-0x000000018B50B780 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get => default; } // 0x000000018B50B780-0x000000018B50B7C0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get => default; } // 0x000000018B50B7C0-0x000000018B50B800 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get => default; } // 0x000000018B50B800-0x000000018B50B840 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get => default; } // 0x000000018B50B840-0x000000018B50B880 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get => default; } // 0x000000018B50B880-0x000000018B50B8C0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get => default; } // 0x000000018B50B500-0x000000018B50B540 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get => default; } // 0x000000018B50B540-0x000000018B50B580 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get => default; } // 0x000000018B50B580-0x000000018B50B5C0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get => default; } // 0x000000018B50B5C0-0x000000018B50B600 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get => default; } // 0x000000018B50B600-0x000000018B50B640 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get => default; } // 0x000000018B50B640-0x000000018B50B680 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get => default; } // 0x000000018B50BD80-0x000000018B50BDC0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get => default; } // 0x000000018B50BDC0-0x000000018B50BE00 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get => default; } // 0x000000018B50BE00-0x000000018B50BE40 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get => default; } // 0x000000018B50BE40-0x000000018B50BE80 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get => default; } // 0x000000018B50BB40-0x000000018B50BB80 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get => default; } // 0x000000018B50BB80-0x000000018B50BBC0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get => default; } // 0x000000018B50BBC0-0x000000018B50BC00 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get => default; } // 0x000000018B50BC00-0x000000018B50BC40 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get => default; } // 0x000000018B50BEC0-0x000000018B50BF00 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get => default; } // 0x000000018B50BE80-0x000000018B50BEC0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get => default; } // 0x000000018B50BF00-0x000000018B50BF40 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get => default; } // 0x000000018B50BF80-0x000000018B50BFC0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get => default; } // 0x000000018B50BF40-0x000000018B50BF80 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get => default; } // 0x000000018B50BFC0-0x000000018B50C000 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get => default; } // 0x000000018B50C040-0x000000018B50C080 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get => default; } // 0x000000018B50C000-0x000000018B50C040 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get => default; } // 0x000000018B50C080-0x000000018B50C0C0 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get => default; } // 0x000000018B50AAC0-0x000000018B50AB00 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get => default; } // 0x000000018B50ABC0-0x000000018B50AC00 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get => default; } // 0x000000018B50AC00-0x000000018B50AC40 
		IControllerTemplateStick IHOTASTemplate.stick { get => default; } // 0x000000018B50B440-0x000000018B50B480 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get => default; } // 0x000000018B50B2C0-0x000000018B50B300 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get => default; } // 0x000000018B50B300-0x000000018B50B340 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get => default; } // 0x000000018B50B1C0-0x000000018B50B200 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get => default; } // 0x000000018B50B200-0x000000018B50B240 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get => default; } // 0x000000018B50B240-0x000000018B50B280 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get => default; } // 0x000000018B50B280-0x000000018B50B2C0 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get => default; } // 0x000000018B50B480-0x000000018B50B4C0 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get => default; } // 0x000000018B50B4C0-0x000000018B50B500 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get => default; } // 0x000000018B50BD40-0x000000018B50BD80 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get => default; } // 0x000000018B50BC40-0x000000018B50BC80 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get => default; } // 0x000000018B50BC80-0x000000018B50BCC0 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get => default; } // 0x000000018B50BCC0-0x000000018B50BD00 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get => default; } // 0x000000018B50BD00-0x000000018B50BD40 
	
		// Constructors
		public HOTASTemplate() {} // Dummy constructor
		public HOTASTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static HOTASTemplate() {} // 0x000000018B50C0C0-0x000000018B50C124
	}

	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 57859
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x0207DE39
		public const int elementId_yokeZ = 1; // Metadata: 0x0207DE3A
		public const int elementId_leftPaddle = 59; // Metadata: 0x0207DE3B
		public const int elementId_rightPaddle = 60; // Metadata: 0x0207DE3C
		public const int elementId_lever1Axis = 2; // Metadata: 0x0207DE3D
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x0207DE3E
		public const int elementId_lever2Axis = 3; // Metadata: 0x0207DE40
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x0207DE41
		public const int elementId_lever3Axis = 4; // Metadata: 0x0207DE43
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x0207DE44
		public const int elementId_lever4Axis = 5; // Metadata: 0x0207DE46
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x0207DE47
		public const int elementId_lever5Axis = 6; // Metadata: 0x0207DE49
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x0207DE4A
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x0207DE4C
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x0207DE4D
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x0207DE4E
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x0207DE4F
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x0207DE50
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x0207DE51
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x0207DE52
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x0207DE53
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x0207DE54
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x0207DE55
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x0207DE56
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x0207DE57
		public const int elementId_centerButton1 = 19; // Metadata: 0x0207DE58
		public const int elementId_centerButton2 = 20; // Metadata: 0x0207DE59
		public const int elementId_centerButton3 = 21; // Metadata: 0x0207DE5A
		public const int elementId_centerButton4 = 22; // Metadata: 0x0207DE5B
		public const int elementId_centerButton5 = 23; // Metadata: 0x0207DE5C
		public const int elementId_centerButton6 = 24; // Metadata: 0x0207DE5D
		public const int elementId_centerButton7 = 25; // Metadata: 0x0207DE5E
		public const int elementId_centerButton8 = 26; // Metadata: 0x0207DE5F
		public const int elementId_wheel1Up = 53; // Metadata: 0x0207DE60
		public const int elementId_wheel1Down = 54; // Metadata: 0x0207DE61
		public const int elementId_wheel1Press = 55; // Metadata: 0x0207DE62
		public const int elementId_wheel2Up = 56; // Metadata: 0x0207DE63
		public const int elementId_wheel2Down = 57; // Metadata: 0x0207DE64
		public const int elementId_wheel2Press = 58; // Metadata: 0x0207DE65
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x0207DE66
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x0207DE67
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x0207DE68
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x0207DE69
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x0207DE6A
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x0207DE6B
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x0207DE6C
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x0207DE6D
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x0207DE6E
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x0207DE6F
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x0207DE70
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x0207DE71
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x0207DE72
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x0207DE73
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x0207DE74
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x0207DE75
		public const int elementId_consoleButton1 = 43; // Metadata: 0x0207DE76
		public const int elementId_consoleButton2 = 44; // Metadata: 0x0207DE77
		public const int elementId_consoleButton3 = 45; // Metadata: 0x0207DE78
		public const int elementId_consoleButton4 = 46; // Metadata: 0x0207DE79
		public const int elementId_consoleButton5 = 47; // Metadata: 0x0207DE7A
		public const int elementId_consoleButton6 = 48; // Metadata: 0x0207DE7B
		public const int elementId_consoleButton7 = 49; // Metadata: 0x0207DE7C
		public const int elementId_consoleButton8 = 50; // Metadata: 0x0207DE7D
		public const int elementId_consoleButton9 = 51; // Metadata: 0x0207DE7E
		public const int elementId_consoleButton10 = 52; // Metadata: 0x0207DE7F
		public const int elementId_mode1 = 61; // Metadata: 0x0207DE80
		public const int elementId_mode2 = 62; // Metadata: 0x0207DE81
		public const int elementId_mode3 = 63; // Metadata: 0x0207DE82
		public const int elementId_yoke = 69; // Metadata: 0x0207DE83
		public const int elementId_lever1 = 70; // Metadata: 0x0207DE85
		public const int elementId_lever2 = 71; // Metadata: 0x0207DE87
		public const int elementId_lever3 = 72; // Metadata: 0x0207DE89
		public const int elementId_lever4 = 73; // Metadata: 0x0207DE8B
		public const int elementId_lever5 = 74; // Metadata: 0x0207DE8D
		public const int elementId_leftGripHat = 75; // Metadata: 0x0207DE8F
		public const int elementId_rightGripHat = 76; // Metadata: 0x0207DE91
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get => default; } // 0x000000018B509CB8-0x000000018B509CF8 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get => default; } // 0x000000018B50A0B8-0x000000018B50A0F8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get => default; } // 0x000000018B509AF8-0x000000018B509B38 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get => default; } // 0x000000018B509B38-0x000000018B509B78 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get => default; } // 0x000000018B509B78-0x000000018B509BB8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get => default; } // 0x000000018B509BB8-0x000000018B509BF8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get => default; } // 0x000000018B509BF8-0x000000018B509C38 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get => default; } // 0x000000018B509C38-0x000000018B509C78 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get => default; } // 0x000000018B509EF8-0x000000018B509F38 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get => default; } // 0x000000018B509F38-0x000000018B509F78 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get => default; } // 0x000000018B509F78-0x000000018B509FB8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get => default; } // 0x000000018B509FB8-0x000000018B509FF8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get => default; } // 0x000000018B509FF8-0x000000018B50A038 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get => default; } // 0x000000018B50A038-0x000000018B50A078 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get => default; } // 0x000000018B509678-0x000000018B5096B8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get => default; } // 0x000000018B5096B8-0x000000018B5096F8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get => default; } // 0x000000018B5096F8-0x000000018B509738 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get => default; } // 0x000000018B509738-0x000000018B509778 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get => default; } // 0x000000018B509778-0x000000018B5097B8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get => default; } // 0x000000018B5097B8-0x000000018B5097F8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get => default; } // 0x000000018B5097F8-0x000000018B509838 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get => default; } // 0x000000018B509838-0x000000018B509878 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get => default; } // 0x000000018B50A178-0x000000018B50A1B8 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get => default; } // 0x000000018B50A0F8-0x000000018B50A138 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get => default; } // 0x000000018B50A138-0x000000018B50A178 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get => default; } // 0x000000018B50A238-0x000000018B50A278 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get => default; } // 0x000000018B50A1B8-0x000000018B50A1F8 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get => default; } // 0x000000018B50A1F8-0x000000018B50A238 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get => default; } // 0x000000018B5098B8-0x000000018B5098F8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get => default; } // 0x000000018B5098F8-0x000000018B509938 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get => default; } // 0x000000018B509938-0x000000018B509978 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get => default; } // 0x000000018B509978-0x000000018B5099B8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get => default; } // 0x000000018B5099B8-0x000000018B5099F8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get => default; } // 0x000000018B5099F8-0x000000018B509A38 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get => default; } // 0x000000018B509A38-0x000000018B509A78 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get => default; } // 0x000000018B509A78-0x000000018B509AB8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get => default; } // 0x000000018B509AB8-0x000000018B509AF8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get => default; } // 0x000000018B509878-0x000000018B5098B8 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get => default; } // 0x000000018B509E38-0x000000018B509E78 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get => default; } // 0x000000018B509E78-0x000000018B509EB8 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get => default; } // 0x000000018B509EB8-0x000000018B509EF8 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get => default; } // 0x000000018B50A278-0x000000018B50A2B8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get => default; } // 0x000000018B509CF8-0x000000018B509D38 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get => default; } // 0x000000018B509D38-0x000000018B509D78 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get => default; } // 0x000000018B509D78-0x000000018B509DB8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get => default; } // 0x000000018B509DB8-0x000000018B509DF8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get => default; } // 0x000000018B509DF8-0x000000018B509E38 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get => default; } // 0x000000018B509C78-0x000000018B509CB8 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get => default; } // 0x000000018B50A078-0x000000018B50A0B8 
	
		// Constructors
		public FlightYokeTemplate() {} // Dummy constructor
		public FlightYokeTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static FlightYokeTemplate() {} // 0x000000018B50A2B8-0x000000018B50A31C
	}

	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 57860
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x0207DE93
		public const int elementId_rightPedal = 1; // Metadata: 0x0207DE94
		public const int elementId_slide = 2; // Metadata: 0x0207DE95
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get => default; } // 0x000000018B509550-0x000000018B50958C 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get => default; } // 0x000000018B50958C-0x000000018B5095CC 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get => default; } // 0x000000018B5095CC-0x000000018B50960C 
	
		// Constructors
		public FlightPedalsTemplate() {} // Dummy constructor
		public FlightPedalsTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static FlightPedalsTemplate() {} // 0x000000018B50960C-0x000000018B509670
	}

	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 57861
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x0207DE96
		public const int elementId_positionY = 2; // Metadata: 0x0207DE97
		public const int elementId_positionZ = 0; // Metadata: 0x0207DE98
		public const int elementId_rotationX = 3; // Metadata: 0x0207DE99
		public const int elementId_rotationY = 5; // Metadata: 0x0207DE9A
		public const int elementId_rotationZ = 4; // Metadata: 0x0207DE9B
		public const int elementId_throttle1Axis = 6; // Metadata: 0x0207DE9C
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x0207DE9D
		public const int elementId_throttle2Axis = 7; // Metadata: 0x0207DE9E
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x0207DE9F
		public const int elementId_extraAxis1 = 8; // Metadata: 0x0207DEA0
		public const int elementId_extraAxis2 = 9; // Metadata: 0x0207DEA1
		public const int elementId_extraAxis3 = 10; // Metadata: 0x0207DEA2
		public const int elementId_extraAxis4 = 11; // Metadata: 0x0207DEA3
		public const int elementId_button1 = 12; // Metadata: 0x0207DEA4
		public const int elementId_button2 = 13; // Metadata: 0x0207DEA5
		public const int elementId_button3 = 14; // Metadata: 0x0207DEA6
		public const int elementId_button4 = 15; // Metadata: 0x0207DEA7
		public const int elementId_button5 = 16; // Metadata: 0x0207DEA8
		public const int elementId_button6 = 17; // Metadata: 0x0207DEA9
		public const int elementId_button7 = 18; // Metadata: 0x0207DEAA
		public const int elementId_button8 = 19; // Metadata: 0x0207DEAB
		public const int elementId_button9 = 20; // Metadata: 0x0207DEAC
		public const int elementId_button10 = 21; // Metadata: 0x0207DEAD
		public const int elementId_button11 = 22; // Metadata: 0x0207DEAE
		public const int elementId_button12 = 23; // Metadata: 0x0207DEAF
		public const int elementId_button13 = 24; // Metadata: 0x0207DEB0
		public const int elementId_button14 = 25; // Metadata: 0x0207DEB1
		public const int elementId_button15 = 26; // Metadata: 0x0207DEB2
		public const int elementId_button16 = 27; // Metadata: 0x0207DEB3
		public const int elementId_button17 = 28; // Metadata: 0x0207DEB4
		public const int elementId_button18 = 29; // Metadata: 0x0207DEB5
		public const int elementId_button19 = 30; // Metadata: 0x0207DEB6
		public const int elementId_button20 = 31; // Metadata: 0x0207DEB7
		public const int elementId_button21 = 55; // Metadata: 0x0207DEB8
		public const int elementId_button22 = 56; // Metadata: 0x0207DEB9
		public const int elementId_button23 = 57; // Metadata: 0x0207DEBA
		public const int elementId_button24 = 58; // Metadata: 0x0207DEBB
		public const int elementId_button25 = 59; // Metadata: 0x0207DEBC
		public const int elementId_button26 = 60; // Metadata: 0x0207DEBD
		public const int elementId_button27 = 61; // Metadata: 0x0207DEBE
		public const int elementId_button28 = 62; // Metadata: 0x0207DEBF
		public const int elementId_button29 = 63; // Metadata: 0x0207DEC0
		public const int elementId_button30 = 64; // Metadata: 0x0207DEC1
		public const int elementId_button31 = 65; // Metadata: 0x0207DEC3
		public const int elementId_button32 = 66; // Metadata: 0x0207DEC5
		public const int elementId_hat1Up = 32; // Metadata: 0x0207DEC7
		public const int elementId_hat1UpRight = 33; // Metadata: 0x0207DEC8
		public const int elementId_hat1Right = 34; // Metadata: 0x0207DEC9
		public const int elementId_hat1DownRight = 35; // Metadata: 0x0207DECA
		public const int elementId_hat1Down = 36; // Metadata: 0x0207DECB
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x0207DECC
		public const int elementId_hat1Left = 38; // Metadata: 0x0207DECD
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x0207DECE
		public const int elementId_hat2Up = 40; // Metadata: 0x0207DECF
		public const int elementId_hat2UpRight = 41; // Metadata: 0x0207DED0
		public const int elementId_hat2Right = 42; // Metadata: 0x0207DED1
		public const int elementId_hat2DownRight = 43; // Metadata: 0x0207DED2
		public const int elementId_hat2Down = 44; // Metadata: 0x0207DED3
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x0207DED4
		public const int elementId_hat2Left = 46; // Metadata: 0x0207DED5
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x0207DED6
		public const int elementId_hat1 = 48; // Metadata: 0x0207DED7
		public const int elementId_hat2 = 49; // Metadata: 0x0207DED8
		public const int elementId_throttle1 = 52; // Metadata: 0x0207DED9
		public const int elementId_throttle2 = 53; // Metadata: 0x0207DEDA
		public const int elementId_stick = 54; // Metadata: 0x0207DEDB
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get => default; } // 0x000000018B5147AC-0x000000018B5147EC 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get => default; } // 0x000000018B5147EC-0x000000018B51482C 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get => default; } // 0x000000018B51482C-0x000000018B51486C 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get => default; } // 0x000000018B51486C-0x000000018B5148AC 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get => default; } // 0x000000018B51422C-0x000000018B51426C 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get => default; } // 0x000000018B5144EC-0x000000018B51452C 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get => default; } // 0x000000018B5145EC-0x000000018B51462C 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get => default; } // 0x000000018B51462C-0x000000018B51466C 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get => default; } // 0x000000018B51466C-0x000000018B5146AC 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get => default; } // 0x000000018B5146AC-0x000000018B5146EC 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get => default; } // 0x000000018B5146EC-0x000000018B51472C 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get => default; } // 0x000000018B51472C-0x000000018B51476C 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get => default; } // 0x000000018B51476C-0x000000018B5147AC 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get => default; } // 0x000000018B513FAC-0x000000018B513FEC 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get => default; } // 0x000000018B513FEC-0x000000018B51402C 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get => default; } // 0x000000018B51402C-0x000000018B51406C 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get => default; } // 0x000000018B51406C-0x000000018B5140AC 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get => default; } // 0x000000018B5140AC-0x000000018B5140EC 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get => default; } // 0x000000018B5140EC-0x000000018B51412C 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get => default; } // 0x000000018B51412C-0x000000018B51416C 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get => default; } // 0x000000018B51416C-0x000000018B5141AC 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get => default; } // 0x000000018B5141AC-0x000000018B5141EC 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get => default; } // 0x000000018B5141EC-0x000000018B51422C 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get => default; } // 0x000000018B51426C-0x000000018B5142AC 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get => default; } // 0x000000018B5142AC-0x000000018B5142EC 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get => default; } // 0x000000018B5142EC-0x000000018B51432C 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get => default; } // 0x000000018B51432C-0x000000018B51436C 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get => default; } // 0x000000018B51436C-0x000000018B5143AC 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get => default; } // 0x000000018B5143AC-0x000000018B5143EC 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get => default; } // 0x000000018B5143EC-0x000000018B51442C 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get => default; } // 0x000000018B51442C-0x000000018B51446C 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get => default; } // 0x000000018B51446C-0x000000018B5144AC 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get => default; } // 0x000000018B5144AC-0x000000018B5144EC 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get => default; } // 0x000000018B51452C-0x000000018B51456C 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get => default; } // 0x000000018B51456C-0x000000018B5145AC 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get => default; } // 0x000000018B5145AC-0x000000018B5145EC 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get => default; } // 0x000000018B5148AC-0x000000018B5148EC 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get => default; } // 0x000000018B5148EC-0x000000018B51492C 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get => default; } // 0x000000018B51496C-0x000000018B5149AC 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get => default; } // 0x000000018B5149AC-0x000000018B5149EC 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get => default; } // 0x000000018B51492C-0x000000018B51496C 
	
		// Constructors
		public SixDofControllerTemplate() {} // Dummy constructor
		public SixDofControllerTemplate(object payload) {} // 0x000000018B509670-0x000000018B509678
		static SixDofControllerTemplate() {} // 0x000000018B5149EC-0x000000018B514A50
	}

	public sealed class InputManager : InputManager_Base // TypeDefIndex: 57862
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager() {} // 0x0000000185F46DF0-0x0000000185F46E00
	
		// Methods
		protected override void OnInitialized() {} // 0x000000018508E670-0x000000018508E680
		protected override void OnDeinitialized() {} // 0x000000018B50C1AC-0x000000018B50C1B4
		protected override void DetectPlatform() {} // 0x0000000185F5A5E0-0x0000000185F5A640
		protected override void CheckRecompile() {} // 0x0000000185492010-0x0000000185492020
		protected override IExternalTools GetExternalTools() => default; // 0x0000000185F8C000-0x0000000185F8C040
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) => default; // 0x000000018B50C124-0x000000018B50C1AC
		private void SubscribeEvents() {} // 0x000000018508EBE0-0x000000018508EC90
		private void UnsubscribeEvents() {} // 0x000000018508EC90-0x000000018508ED30
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x0000000184D681E0-0x0000000184D681F0
	}
}

namespace Rewired.Data
{
	public class UserDataStore_File : UserDataStore_KeyValue // TypeDefIndex: 57871
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x0207DEDC
		private const string defaultExtensionText = ".json"; // Metadata: 0x0207DEE6
		private const string defaultExtensionBinary = ".bin"; // Metadata: 0x0207DEEC
		private const string defaultFileName = "RewiredSaveData.json"; // Metadata: 0x0207DEF1
		private string _fileName; // 0x38
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
		public string directory { get => default; set {} } // 0x000000018B50C36C-0x000000018B50C550 0x000000018B50C550-0x000000018B50C734
		public string fileName { get => default; set {} } // 0x000000018B50C2AC-0x000000018B50C36C 
		public DataFormat dataFormat { get => default; set {} } // 0x0000000185492010-0x0000000185492020
		protected IDataHandler dataHandler { get => default; set {} } // 0x000000018B514CF0-0x000000018B514D20 0x000000018B514CC0-0x000000018B514CF0
		protected override IDataStore dataStore { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class DataStore : UserDataStore_KeyValue.IDataStore // TypeDefIndex: 57864
		{
			// Fields
			private Dictionary<string, object> _data; // 0x10
			private readonly string _absFilePath; // 0x18
			private IDataHandler _dataHandler; // 0x20
	
			// Constructors
			public DataStore() {} // Dummy constructor
			public DataStore(string fileName, string absDirectory, IDataHandler dataHandler) {} // 0x000000018B515268-0x000000018B5152A0
	
			// Methods
			public bool TryGetValue(string key, out object value) {
				value = default;
				return default;
			} // 0x000000018B5152E4-0x000000018B515314
			public bool SetValue(string key, object value) => default; // 0x00000001813ECBC0-0x00000001813ECBD0
			public bool Save() => default; // 0x000000018B515314-0x000000018B515344
			public bool Load() => default; // 0x00000001813ECF10-0x00000001813ECF20
			public bool Clear() => default; // 0x000000018B5152A0-0x000000018B5152B4
		}
	
		private sealed class LocalFileDataHandler : IDataHandler // TypeDefIndex: 57865
		{
			// Fields
			private readonly Func<DataFormat> _dataFormatDelegate; // 0x10
			private readonly Codec _codec; // 0x18
	
			// Constructors
			public LocalFileDataHandler() {} // Dummy constructor
			public LocalFileDataHandler(Func<DataFormat> dataFormatDelegate, Codec codec) {} // 0x000000018B515168-0x000000018B515268
	
			// Methods
			public bool Load(string absoluteFilePath, out string data) {
				data = default;
				return default;
			} // 0x000000018B5152B4-0x000000018B5152E4
			public bool Save(string absoluteFilePath, string data) => default; // 0x0000000181460F60-0x0000000181460F70
			public bool Clear(string absoluteFilePath) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private abstract class Codec // TypeDefIndex: 57866
		{
			// Constructors
			protected Codec() {} // 0x000000018B515108-0x000000018B515168
	
			// Methods
			public abstract byte[] Encode(string @string); // 0x000000018B51504C-0x000000018B515070
			public abstract string Decode(byte[] data); // 0x000000018B514F7C-0x000000018B51504C
		}
	
		private sealed class UTF8Text : Codec // TypeDefIndex: 57867
		{
			// Constructors
			public UTF8Text() {} // 0x000000018B508F4C-0x000000018B50907C
	
			// Methods
			public override byte[] Encode(string @string) => default; // 0x000000018B515070-0x000000018B515108
			public override string Decode(byte[] data) => default; // 0x00000001813ECF10-0x00000001813ECF20
		}
	
		private sealed class CLZF2 : Codec // TypeDefIndex: 57868
		{
			// Fields
			private readonly Utils.Libraries.CLZF2.CLZF2 _cLZF2; // 0x10
	
			// Constructors
			public CLZF2() {} // 0x000000018B508ECC-0x000000018B508F4C
	
			// Methods
			public override byte[] Encode(string @string) => default; // 0x000000018B508E54-0x000000018B508ECC
			public override string Decode(byte[] data) => default; // 0x000000018B508D30-0x000000018B508E54
		}
	
		public interface IDataHandler // TypeDefIndex: 57869
		{
			// Methods
			bool Load(string absoluteFilePath, out string data); // 0x000000018B508B68-0x000000018B508D30
			bool Save(string absoluteFilePath, string data); // 0x000000018B508A0C-0x000000018B508B68
			bool Clear(string absoluteFilePath); // 0x000000018B50C734-0x000000018B50C804
		}
	
		public enum DataFormat // TypeDefIndex: 57870
		{
			Text = 0,
			Binary = 1
		}
	
		// Constructors
		public UserDataStore_File() {}
		static UserDataStore_File() {}
	
		// Methods
		protected virtual void SetInitialValues() {} // 0x000000018B5084A8-0x000000018B50850C
		protected override void OnInitialize() {} // 0x000000018B508458-0x000000018B5084A8
		private void OnDataSourceChanged() {} // 0x000000018B5083FC-0x000000018B508458
		private DataFormat _get_dataHandler_b__17_0() => default;
	}

	public abstract class UserDataStore_KeyValue : UserDataStore // TypeDefIndex: 57881
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x0207DF08
		private const string key_controllerAssignments = "ControllerAssignments"; // Metadata: 0x0207DF12
		private const int controllerMapKeyVersion = 0; // Metadata: 0x0207DF28
		private bool _isEnabled; // 0x18
		private bool _loadDataOnStart; // 0x19
		private bool _loadJoystickAssignments; // 0x1A
		private bool _loadKeyboardAssignments; // 0x1B
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
		public bool isEnabled { get; set; } // 0x000000018B5199EC-0x000000018B519A90 0x000000018B517008-0x000000018B5170C8
		public bool loadDataOnStart { get; set; } // 0x000000018B515AF8-0x000000018B515B70 0x000000018B5169AC-0x000000018B516AB0
		public bool loadJoystickAssignments { get; set; } // 0x000000018B518A8C-0x000000018B518AFC 0x000000018B518AFC-0x000000018B518D24
		public bool loadKeyboardAssignments { get; set; } // 0x000000018B5168E0-0x000000018B5169AC 0x000000018B5185D4-0x000000018B51860C
		public bool loadMouseAssignments { get; set; } // 0x000000018B51860C-0x000000018B51867C 0x000000018B51867C-0x000000018B5187C4
		protected abstract IDataStore dataStore { get; } // 0x000000018B516CB4-0x000000018B516D20 
		private bool loadControllerAssignments { get; } // 0x000000018B516D20-0x000000018B516D40 
		private List<int> allActionIds { get; } // 0x000000018B5170C8-0x000000018B517340 
		private string allActionIdsString { get; } // 0x000000018B516EF4-0x000000018B517008 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 57874
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get => default; } // 0x0000000185FB0740-0x0000000185FB0750 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 57872
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get => default; } // 0x00000001813C0430-0x00000001813C0440 
	
				// Constructors
				public PlayerInfo() {} // 0x0000000181A73EB0-0x0000000181A73EC0
	
				// Methods
				public int IndexOfJoystick(int joystickId) => default; // 0x00000001813C0520-0x00000001813C0530
				public bool ContainsJoystick(int joystickId) => default; // 0x0000000181A73E90-0x0000000181A73EA0
			}
	
			public class JoystickInfo // TypeDefIndex: 57873
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo() {} // 0x0000000185FB0730-0x0000000185FB0740
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo() {} // 0x0000000185FB3590-0x0000000185FB35A0
			public ControllerAssignmentSaveInfo(int playerCount) {} // 0x0000000185FB35C0-0x0000000185FB35D0
	
			// Methods
			public int IndexOfPlayer(int playerId) => default; // 0x00000001814088D0-0x00000001814088E0
			public bool ContainsPlayer(int playerId) => default; // 0x0000000181408D10-0x0000000181408D20
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 57875
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo() {} // Dummy constructor
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId) {}
		}
	
		protected interface IDataStore // TypeDefIndex: 57876
		{
			// Methods
			bool Save(); // 0x000000018B51AAA8-0x000000018B51AABC
			bool Load(); // 0x000000018B51A968-0x000000018B51AAA8
			bool Clear(); // 0x000000018B51A850-0x000000018B51A968
			bool TryGetValue(string key, out object result); // 0x000000018B51A3AC-0x000000018B51A468
			bool SetValue(string key, object value); // 0x000000018B519730-0x000000018B519814
		}
	
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 57877
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass71_0() {} // 0x000000018B51965C-0x000000018B519730
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B51A2EC-0x000000018B51A3AC
		}
	
		private sealed class __c__DisplayClass71_1 // TypeDefIndex: 57878
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass71_1() {} // 0x000000018B519E40-0x000000018B519F10
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B518DE4-0x000000018B518EA0
		}
	
		private sealed class __c__DisplayClass71_2 // TypeDefIndex: 57879
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass71_2() {} // 0x000000018B516D40-0x000000018B516E24
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B516E24-0x000000018B516EF4
		}
	
		private sealed class _LoadJoystickAssignmentsDeferred_d__73 : IEnumerator<object> // TypeDefIndex: 57880
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_KeyValue __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B518EA0-0x000000018B518F18 
			object IEnumerator.Current { get => default; } // 0x000000018B518F18-0x000000018B518F48 
	
			// Constructors
			public _LoadJoystickAssignmentsDeferred_d__73() {} // Dummy constructor
			public _LoadJoystickAssignmentsDeferred_d__73(int __1__state) {} // 0x000000018B518D24-0x000000018B518DE4
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B5174A8-0x000000018B517578
			private bool MoveNext() => default; // 0x000000018B518F78-0x000000018B519000
			void IEnumerator.Reset() {} // 0x000000018B518F48-0x000000018B518F78
		}
	
		// Constructors
		protected UserDataStore_KeyValue() {} // 0x000000018B514B18-0x000000018B514B64
		static UserDataStore_KeyValue() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void Save() {} // 0x000000018B517578-0x000000018B5176A0
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B517340-0x000000018B517404
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B517404-0x000000018B5174A8
		public override void SavePlayerData(int playerId) {} // 0x000000018B516BF4-0x000000018B516CB4
		public override void SaveInputBehavior(int playerId, int behaviorId) {} // 0x000000018B5187C4-0x000000018B518A8C
		public override void Load() {} // 0x000000018B5176FC-0x000000018B5185D4
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B516AB0-0x000000018B516BF4
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B5176A0-0x000000018B5176FC
		public override void LoadPlayerData(int playerId) {} // 0x000000018B519138-0x000000018B519234
		public override void LoadInputBehavior(int playerId, int behaviorId) {} // 0x000000018B51A264-0x000000018B51A2EC
		protected override void OnInitialize() {} // 0x000000018B51A1A0-0x000000018B51A264
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x000000018B51907C-0x000000018B519138
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x000000018B519F7C-0x000000018B519FEC
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x000000018B519FEC-0x000000018B51A080
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x000000018B51A080-0x000000018B51A1A0
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B519600-0x000000018B519648
		public virtual void ClearSaveData() {} // 0x000000018B519648-0x000000018B51965C
		private int LoadAll() => default; // 0x000000018B519B9C-0x000000018B519CF0
		private int LoadPlayerDataNow(int playerId) => default; // 0x000000018B519A90-0x000000018B519B9C
		private int LoadPlayerDataNow(Player player) => default; // 0x000000018B519814-0x000000018B5199EC
		private int LoadAllJoystickCalibrationData() => default; // 0x000000018B519F10-0x000000018B519F7C
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick) => default; // 0x000000018B519D64-0x000000018B519E40
		private int LoadJoystickCalibrationData(int joystickId) => default; // 0x000000018B519CF0-0x000000018B519D64
		private int LoadJoystickData(int joystickId) => default; // 0x000000018B519234-0x000000018B519600
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B515834-0x000000018B5158A4
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B515DC8-0x000000018B515EE4
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B515EE4-0x000000018B516000
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B5158A4-0x000000018B515AF8
		private int LoadInputBehaviors(int playerId) => default; // 0x000000018B516748-0x000000018B5168E0
		private int LoadInputBehaviorNow(int playerId, int behaviorId) => default; // 0x000000018B5165CC-0x000000018B5166C4
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => default; // 0x000000018B515CC0-0x000000018B515DC8
		private bool LoadControllerAssignmentsNow() => default; // 0x000000018B516000-0x000000018B5161D8
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x000000018B5166C4-0x000000018B516748
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x000000018B516538-0x000000018B5165CC
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData() => default; // 0x000000018B515344-0x000000018B515834
		private IEnumerator LoadJoystickAssignmentsDeferred() => default; // 0x000000018B515B70-0x000000018B515CC0
		private void SaveAll() {} // 0x000000018B51A468-0x000000018B51A61C
		private void SavePlayerDataNow(int playerId) {} // 0x000000018B519000-0x000000018B51907C
		private void SavePlayerDataNow(Player player) {} // 0x000000018B5161D8-0x000000018B516538
		private void SaveAllJoystickCalibrationData() {} // 0x000000018B51A61C-0x000000018B51A73C
		private void SaveJoystickCalibrationData(int joystickId) {} // 0x000000018B51A7D4-0x000000018B51A850
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick) {} // 0x000000018B51A73C-0x000000018B51A7D4
		private void SaveJoystickData(int joystickId) {} // 0x000000018556EA80-0x000000018556EAA0
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x0000000185492010-0x0000000185492020
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B5085A0-0x000000018B508668
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) {} // 0x000000018B508524-0x000000018B5085A0
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B50850C-0x000000018B508524
		private void SaveControllerMap(Player player, ControllerMap controllerMap) {} // 0x000000018B50CBA8-0x000000018B50CBBC
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) {} // 0x000000018B50CB2C-0x000000018B50CBA8
		private void SaveInputBehaviorNow(int playerId, int behaviorId) {} // 0x000000018B50CB14-0x000000018B50CB2C
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) {} // 0x0000000185492010-0x0000000185492020
		private bool SaveControllerAssignments() => default; // 0x0000000185492010-0x0000000185492020
		private static void AppendBaseKey(StringBuilder sb, Player player) {} // 0x000000018B50C230-0x000000018B50C2AC
		private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default;
		private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default;
		private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion) {}
		private string GetJoystickCalibrationMapKey(Rewired.Joystick joystick) => default;
		private string GetInputBehaviorKey(Player player, int inputBehaviorId) => default;
		private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x0000000185492010-0x0000000185492020
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B514C78-0x000000018B514C98
		private string GetJoystickCalibrationMapJson(Rewired.Joystick joystick) => default; // 0x0000000185492010-0x0000000185492020
		private string GetInputBehaviorJson(Player player, int id) => default; // 0x000000018B514C98-0x000000018B514CC0
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) {} // 0x0000000185492010-0x0000000185492020
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) => default; // 0x000000018B514C78-0x000000018B514C98
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches) {
			matches = default;
			return default;
		} // 0x0000000181378230-0x0000000181378240
		private void RefreshLayoutManager(int playerId) {} // 0x0000000185492010-0x0000000185492020
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => default; // 0x000000018B514A50-0x000000018B514B18
		private static bool TryGetString(IDataStore store, string key, out string result) {
			result = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
	}

	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 57890
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x0207DF29
		private const string logPrefix = "Rewired: "; // Metadata: 0x0207DF43
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x0207DF4D
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x0207E118
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x0207E12E
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x0207E12F
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x0207E130
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x0207E131
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x0207E132
		private bool isEnabled; // 0x18
		private bool loadDataOnStart; // 0x19
		private bool loadJoystickAssignments; // 0x1A
		private bool loadKeyboardAssignments; // 0x1B
		private bool loadMouseAssignments; // 0x1C
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
		public bool IsEnabled { get => default; set {} } // 0x000000018B51C3FC-0x000000018B51C484 0x000000018B51E304-0x000000018B51E37C
		public bool LoadDataOnStart { get => default; set {} } // 0x000000018B51CAD0-0x000000018B51CB58 0x000000018B51E4C0-0x000000018B51E548
		public bool LoadJoystickAssignments { get => default; set {} } // 0x000000018B51E3E8-0x000000018B51E460 0x000000018B51E490-0x000000018B51E4C0
		public bool LoadKeyboardAssignments { get => default; set {} } // 0x000000018B51E460-0x000000018B51E490 0x000000018B51EC8C-0x000000018B51ED18
		public bool LoadMouseAssignments { get => default; set {} } // 0x000000018B51C51C-0x000000018B51C5DC 0x000000018B51C094-0x000000018B51C198
		public string PlayerPrefsKeyPrefix { get => default; set {} } // 0x000000018B51E06C-0x000000018B51E0DC 0x000000018B51E0DC-0x000000018B51E304
		private string playerPrefsKey_controllerAssignments { get => default; } // 0x000000018B51BFC8-0x000000018B51C094 
		private bool loadControllerAssignments { get => default; } // 0x000000018B51DBB4-0x000000018B51DBEC 
		private List<int> allActionIds { get => default; } // 0x000000018B51DBEC-0x000000018B51DC5C 
		private string allActionIdsString { get => default; } // 0x000000018B51DC5C-0x000000018B51DDA4 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 57884
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get => default; } // 0x0000000185FB0740-0x0000000185FB0750 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 57882
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get => default; } // 0x00000001813C0430-0x00000001813C0440 
	
				// Constructors
				public PlayerInfo() {} // 0x0000000181A73EB0-0x0000000181A73EC0
	
				// Methods
				public int IndexOfJoystick(int joystickId) => default; // 0x00000001813C0520-0x00000001813C0530
				public bool ContainsJoystick(int joystickId) => default; // 0x0000000181A73E90-0x0000000181A73EA0
			}
	
			public class JoystickInfo // TypeDefIndex: 57883
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo() {} // 0x0000000185FB0730-0x0000000185FB0740
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo() {} // 0x0000000185FB3590-0x0000000185FB35A0
			public ControllerAssignmentSaveInfo(int playerCount) {} // 0x0000000185FB35C0-0x0000000185FB35D0
	
			// Methods
			public int IndexOfPlayer(int playerId) => default; // 0x00000001814088D0-0x00000001814088E0
			public bool ContainsPlayer(int playerId) => default; // 0x0000000181408D10-0x0000000181408D20
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 57885
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo() {} // Dummy constructor
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId) {} // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		private sealed class __c__DisplayClass78_0 // TypeDefIndex: 57886
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass78_0() {} // 0x000000018646EE40-0x000000018646EE50
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B51FBAC-0x000000018B51FC94
		}
	
		private sealed class __c__DisplayClass78_1 // TypeDefIndex: 57887
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass78_1() {} // 0x000000018B51AAA8-0x000000018B51AABC
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B51FA6C-0x000000018B51FBAC
		}
	
		private sealed class __c__DisplayClass78_2 // TypeDefIndex: 57888
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass78_2() {} // 0x000000018B51F954-0x000000018B51FA6C
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x) => default; // 0x000000018B51F6DC-0x000000018B51F748
		}
	
		private sealed class _LoadJoystickAssignmentsDeferred_d__80 : IEnumerator<object> // TypeDefIndex: 57889
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_PlayerPrefs __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B51F230-0x000000018B51F2B8 
			object IEnumerator.Current { get => default; } // 0x000000018B51C484-0x000000018B51C51C 
	
			// Constructors
			public _LoadJoystickAssignmentsDeferred_d__80() {} // Dummy constructor
			public _LoadJoystickAssignmentsDeferred_d__80(int __1__state) {} // 0x000000018B51EB6C-0x000000018B51EC04
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B51EC04-0x000000018B51EC8C
			private bool MoveNext() => default; // 0x000000018B51F664-0x000000018B51F6DC
			void IEnumerator.Reset() {} // 0x000000018B51E37C-0x000000018B51E3E8
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void Save() {} // 0x000000018B51C370-0x000000018B51C3DC
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51C3DC-0x000000018B51C3FC
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51C6F0-0x000000018B51C968
		public override void SavePlayerData(int playerId) {} // 0x000000018B51C5DC-0x000000018B51C6F0
		public override void SaveInputBehavior(int playerId, int behaviorId) {} // 0x000000018B51CB58-0x000000018B51CC80
		public override void Load() {} // 0x000000018B51CA0C-0x000000018B51CAD0
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51C968-0x000000018B51CA0C
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51C2B0-0x000000018B51C370
		public override void LoadPlayerData(int playerId) {} // 0x000000018B51DDA4-0x000000018B51E06C
		public override void LoadInputBehavior(int playerId, int behaviorId) {} // 0x000000018B51CCDC-0x000000018B51DBB4
		protected override void OnInitialize() {} // 0x000000018B51C198-0x000000018B51C2B0
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x000000018B51CC80-0x000000018B51CCDC
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x000000018B51E680-0x000000018B51E764
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x000000018B51F528-0x000000018B51F5A0
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x000000018B51F5A0-0x000000018B51F664
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B51E5C4-0x000000018B51E680
		private int LoadAll() => default; // 0x000000018B51F324-0x000000018B51F394
		private int LoadPlayerDataNow(int playerId) => default; // 0x000000018B51F394-0x000000018B51F408
		private int LoadPlayerDataNow(Player player) => default; // 0x000000018B51F408-0x000000018B51F528
		private int LoadAllJoystickCalibrationData() => default; // 0x000000018B51EB20-0x000000018B51EB6C
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick) => default; // 0x000000018B51EAFC-0x000000018B51EB20
		private int LoadJoystickCalibrationData(int joystickId) => default; // 0x000000018B51EEBC-0x000000018B51F010
		private int LoadJoystickData(int joystickId) => default; // 0x000000018B51F010-0x000000018B51F11C
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B51ED18-0x000000018B51EEBC
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B51F2B8-0x000000018B51F324
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) => default; // 0x000000018B51F168-0x000000018B51F230
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B51F11C-0x000000018B51F168
		private int LoadInputBehaviors(int playerId) => default; // 0x000000018B51E764-0x000000018B51EAFC
		private int LoadInputBehaviorNow(int playerId, int behaviorId) => default; // 0x000000018B51AFAC-0x000000018B51AFF8
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => default; // 0x000000018B51B148-0x000000018B51B1AC
		private bool LoadControllerAssignmentsNow() => default; // 0x000000018B51B714-0x000000018B51B7DC
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x000000018B51B1AC-0x000000018B51B274
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x000000018B51B410-0x000000018B51B714
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData() => default; // 0x000000018B51BE24-0x000000018B51BF54
		private IEnumerator LoadJoystickAssignmentsDeferred() => default; // 0x000000018B51BD14-0x000000018B51BDA0
		private void SaveAll() {} // 0x000000018B51B8FC-0x000000018B51B9B4
		private void SavePlayerDataNow(int playerId) {} // 0x000000018B51B274-0x000000018B51B410
		private void SavePlayerDataNow(Player player) {} // 0x000000018B51BF54-0x000000018B51BFC8
		private void SaveAllJoystickCalibrationData() {} // 0x000000018B51BDA0-0x000000018B51BE24
		private void SaveJoystickCalibrationData(int joystickId) {} // 0x000000018B51AABC-0x000000018B51AFAC
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick) {} // 0x000000018B51AFF8-0x000000018B51B148
		private void SaveJoystickData(int joystickId) {} // 0x000000018B51F748-0x000000018B51F8FC
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51B9B4-0x000000018B51BD14
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51E548-0x000000018B51E5C4
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) {} // 0x000000018B51B7DC-0x000000018B51B8FC
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId) {} // 0x000000018B51F8FC-0x000000018B51F954
		private void SaveControllerMap(Player player, ControllerMap controllerMap) {} // 0x000000018556EA80-0x000000018556EAA0
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) {} // 0x0000000185492010-0x0000000185492020
		private void SaveInputBehaviorNow(int playerId, int behaviorId) {} // 0x000000018B508668-0x000000018B508730
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) {} // 0x000000018B508524-0x000000018B5085A0
		private bool SaveControllerAssignments() => default; // 0x000000018B50850C-0x000000018B508524
		private bool ControllerAssignmentSaveDataExists() => default; // 0x000000018B50CBA8-0x000000018B50CBBC
		private string GetBasePlayerPrefsKey(Player player) => default; // 0x000000018B50CB2C-0x000000018B50CBA8
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x000000018B50CB14-0x000000018B50CB2C
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x0000000185492010-0x0000000185492020
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) => default; // 0x0000000185492010-0x0000000185492020
		private string GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick) => default; // 0x000000018B50C1B4-0x000000018B50C230
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) => default; // 0x0000000185492010-0x0000000185492020
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x000000018B514C78-0x000000018B514C98
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x0000000185492010-0x0000000185492020
		private string GetJoystickCalibrationMapXml(Rewired.Joystick joystick) => default; // 0x000000018B514C98-0x000000018B514CC0
		private string GetInputBehaviorXml(Player player, int id) => default; // 0x0000000185492010-0x0000000185492020
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) {} // 0x000000018B514C78-0x000000018B514C98
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) => default; // 0x0000000181378230-0x0000000181378240
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches) {
			matches = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => default; // 0x000000018B514B64-0x000000018B514C2C
		private void RefreshLayoutManager(int playerId) {} // 0x0000000181377E40-0x0000000181377E50
		private static System.Type GetControllerMapType(Rewired.ControllerType controllerType) => default; // 0x000000018B514C2C-0x000000018B514C78
	}
}

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 57892
	{
		// Fields
		private int _playerId_k__BackingField; // 0x160
		private int _inputSourceIndex_k__BackingField; // 0x164
		private IMouseInputSource _mouseSource_k__BackingField; // 0x168
		private ITouchInputSource _touchSource_k__BackingField; // 0x170
		private PointerEventType _sourceType_k__BackingField; // 0x178
		private int _buttonIndex_k__BackingField; // 0x17C
	
		// Properties
		public int playerId { get; set; } // 0x0000000185FBC710-0x0000000185FBC720 0x0000000185FD2F60-0x0000000185FD2F70
		public int inputSourceIndex { get; set; } // 0x0000000185FBBE80-0x0000000185FBBE90 0x0000000185FBBF00-0x0000000185FBBF10
		public IMouseInputSource mouseSource { get; set; } // 0x0000000185FB88D0-0x0000000185FB88E0 0x0000000187A47BE0-0x0000000187A47BF4
		public ITouchInputSource touchSource { get; set; } // 0x0000000185FB88C0-0x0000000185FB88D0 0x0000000186473504-0x0000000186473518
		public PointerEventType sourceType { get; set; } // 0x0000000185FCDD00-0x0000000185FCDD10 0x0000000185FD2F70-0x0000000185FD2F80
		public int buttonIndex { get; set; } // 0x0000000185FBF070-0x0000000185FBF080 0x0000000185FBF080-0x0000000185FBF090
	
		// Constructors
		public PlayerPointerEventData() {} // Dummy constructor
		public PlayerPointerEventData(EventSystem eventSystem) {} // 0x000000018B50CE08-0x000000018B50CE34
	
		// Methods
		public override string ToString() => default; // 0x000000018B50CBBC-0x000000018B50CE08
	}

	public class RewiredEventSystem : EventSystem // TypeDefIndex: 57893
	{
		// Fields
		private bool _alwaysUpdate; // 0x50
	
		// Properties
		public bool alwaysUpdate { get => default; set {} } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
	
		// Constructors
		public RewiredEventSystem() {} // 0x000000018B50DA50-0x000000018B50DA9C
	
		// Methods
		protected override void Update() {} // 0x000000018B50D914-0x000000018B50DA50
	}

	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 57898
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x0207E133
		public const int kMouseRightId = -2; // Metadata: 0x0207E134
		public const int kMouseMiddleId = -3; // Metadata: 0x0207E135
		public const int kFakeTouchesId = -4; // Metadata: 0x0207E136
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x0207E137
		private const int customButtonsMaxCount = 128; // Metadata: 0x0207E13C
		private const int customButtonsLastId = -2147483392; // Metadata: 0x0207E13E
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x000000018B50FD10-0x000000018B50FD7C 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x000000018B510210-0x000000018B510314 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x000000018B50C818-0x000000018B50C8A4 
		protected virtual bool isMouseSupported { get; } // 0x0000000181378230-0x0000000181378240 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 57894
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState() {} // 0x000000018B50E5FC-0x000000018B50E794
	
			// Methods
			public bool AnyPressesThisFrame() => default; // 0x000000018B510314-0x000000018B51037C
			public bool AnyReleasesThisFrame() => default; // 0x000000018B51037C-0x000000018B510384
			public ButtonState GetButtonState(int button) => default; // 0x000000018B51037C-0x000000018B510384
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data) {} // 0x000000018B50F5B0-0x000000018B50F5CC
		}
	
		public class MouseButtonEventData // TypeDefIndex: 57895
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData() {} // 0x000000018B50E4E4-0x000000018B50E5FC
	
			// Methods
			public bool PressedThisFrame() => default; // 0x000000018B50FB00-0x000000018B50FBA8
			public bool ReleasedThisFrame() => default; // 0x000000018B50DA9C-0x000000018B50DB78
		}
	
		protected class ButtonState // TypeDefIndex: 57896
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get => default; set {} } // 0x000000018B50F2F0-0x000000018B50F364 0x000000018B50FC54-0x000000018B50FCD0
			public int button { get => default; set {} } // 0x000000018B50DB78-0x000000018B50DC3C 0x000000018B50F2C8-0x000000018B50F2F0
	
			// Constructors
			public ButtonState() {} // 0x000000018B50DC3C-0x000000018B50DC84
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 57897
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get => default; } // 0x000000018B510384-0x000000018B510438 
			int ITouchInputSource.playerId { get => default; }
			bool IMouseInputSource.enabled { get => default; } // 0x000000018B50EF60-0x000000018B50F2C8 
			bool IMouseInputSource.locked { get => default; } // 0x000000018B50E0B8-0x000000018B50E1F4 
			int IMouseInputSource.buttonCount { get => default; } // 0x000000018B50FBA8-0x000000018B50FC54 
			Vector2 IMouseInputSource.screenPosition { get => default; } // 0x000000018B50FCD0-0x000000018B50FD10 
			Vector2 IMouseInputSource.screenPositionDelta { get => default; } // 0x000000018B50FA1C-0x000000018B50FB00 
			Vector2 IMouseInputSource.wheelDelta { get => default; } // 0x000000018B50F7BC-0x000000018B50FA1C 
			bool ITouchInputSource.touchSupported { get => default; } // 0x000000018B50F5CC-0x000000018B50F7BC 
			int ITouchInputSource.touchCount { get => default; } // 0x000000018B50DC84-0x000000018B50DFDC 
	
			// Constructors
			public UnityInputSource() {} // 0x000000018B50DFDC-0x000000018B50E0B8
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button) => default; // 0x000000018B50F364-0x000000018B50F5B0
			bool IMouseInputSource.GetButtonUp(int button) => default; // 0x000000018B50E794-0x000000018B50EF60
			bool IMouseInputSource.GetButton(int button) => default; // 0x000000018B50E2C0-0x000000018B50E4E4
			Touch ITouchInputSource.GetTouch(int index) => default; // 0x000000018B50FD7C-0x000000018B510210
			private void TryUpdate() {} // 0x000000018B50E1F4-0x000000018B50E2C0
		}
	
		// Constructors
		protected RewiredPointerInputModule() {} // 0x0000000185FBD7E0-0x0000000185FBD7F0
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse) => default; // 0x000000018B50C8A4-0x000000018B50C930
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) => default; // 0x000000018B50C930-0x000000018B50CA4C
		public void RemoveMouseInputSource(IMouseInputSource source) {} // 0x000000018B50CA4C-0x000000018B50CA9C
		public void AddMouseInputSource(IMouseInputSource source) {} // 0x000000018B50CA9C-0x000000018B50CB14
		public int GetMouseInputSourceCount(int playerId) => default; // 0x000000018B50C804-0x000000018B50C818
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) => default; // 0x0000000189291CF8-0x0000000189291D0C
		public void RemoveTouchInputSource(ITouchInputSource source) {} // 0x0000000185492010-0x0000000185492020
		public void AddTouchInputSource(ITouchInputSource source) {} // 0x0000000181377E40-0x0000000181377E50
		public int GetTouchInputSourceCount(int playerId) => default; // 0x0000000184088E70-0x0000000184088E80
		protected void ClearMouseInputSources() {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		protected abstract bool IsDefaultPlayer(int playerId); // 0x0000000185492010-0x0000000185492020
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) {
			data = default;
			return default;
		} // 0x000000018B514DD0-0x000000018B514DE4
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) => default; // 0x000000018B514DD0-0x000000018B514DE4
		protected void RemovePointerData(PlayerPointerEventData data) {} // 0x000000018B514D98-0x000000018B514DB0
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) {
			pressed = default;
			released = default;
			return default;
		} // 0x000000018B514DB0-0x000000018B514DD0
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex) => default; // 0x000000018B514D80-0x000000018B514D98
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) => default; // 0x000000018B514D20-0x000000018B514D40
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) => default; // 0x000000018B514D40-0x000000018B514D60
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent) {} // 0x000000018B514D60-0x000000018B514D80
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent) {} // 0x000000018B514E24-0x000000018B514E54
		public override bool IsPointerOverGameObject(int pointerTypeId) => default; // 0x000000018B514DE4-0x000000018B514E24
		protected void ClearSelection() {} // 0x000000018B514E54-0x000000018B514E6C
		public override string ToString() => default; // 0x000000018B514EE8-0x000000018B514F00
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x000000018B514ED0-0x000000018B514EE8
		protected void CopyFromTo(PointerEventData from, PointerEventData to) {} // 0x000000018B514E6C-0x000000018B514ED0
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) => default; // 0x000000018B514F00-0x000000018B514F7C
	}

	public enum PointerEventType // TypeDefIndex: 57899
	{
		Mouse = 0,
		Touch = 1
	}

	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 57901
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x0207E145
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x0207E152
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x0207E15D
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x0207E166
		private InputManager_Base rewiredInputManager; // 0x70
		private bool useAllRewiredGamePlayers; // 0x78
		private bool useRewiredSystemPlayer; // 0x79
		private int[] rewiredPlayerIds; // 0x80
		private bool usePlayingPlayersOnly; // 0x88
		private List<Rewired.Components.PlayerMouse> playerMice; // 0x90
		private bool moveOneElementPerAxisPress; // 0x98
		private bool setActionsById; // 0x99
		private int horizontalActionId; // 0x9C
		private int verticalActionId; // 0xA0
		private int submitActionId; // 0xA4
		private int cancelActionId; // 0xA8
		private string m_HorizontalAxis; // 0xB0
		private string m_VerticalAxis; // 0xB8
		private string m_SubmitButton; // 0xC0
		private string m_CancelButton; // 0xC8
		private float m_InputActionsPerSecond; // 0xD0
		private float m_RepeatDelay; // 0xD4
		private bool m_allowMouseInput; // 0xD8
		private bool m_allowMouseInputIfTouchSupported; // 0xD9
		private bool m_allowTouchInput; // 0xDA
		private bool m_deselectIfBackgroundClicked; // 0xDB
		private bool m_deselectBeforeSelecting; // 0xDC
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
		public InputManager_Base RewiredInputManager { get => default; set {} } // 0x000000018B513BE4-0x000000018B513C00 0x0000000185FB2E50-0x0000000185FB2E60
		public bool UseAllRewiredGamePlayers { get => default; set {} } // 0x000000018B513C00-0x000000018B513C1C 0x000000018B513728-0x000000018B513778
		public bool UseRewiredSystemPlayer { get => default; set {} } // 0x000000018B513A50-0x000000018B513ADC 0x000000018316BFD0-0x000000018316BFE0
		public int[] RewiredPlayerIds { get => default; set {} } // 0x0000000185FB0AB0-0x0000000185FB0AC0 0x000000018B5136B0-0x000000018B513728
		public bool UsePlayingPlayersOnly { get => default; set {} } // 0x000000018B513994-0x000000018B513A50 0x0000000185FB9E80-0x0000000185FB9E90
		public List<Rewired.Components.PlayerMouse> PlayerMice { get => default; set {} } // 0x0000000185FBE380-0x0000000185FBE390 0x0000000185FB2610-0x0000000185FB2620
		public bool MoveOneElementPerAxisPress { get => default; set {} } // 0x0000000185FB2670-0x0000000185FB2680 0x0000000185FB25F0-0x0000000185FB2600
		public bool allowMouseInput { get => default; set {} } // 0x0000000185FB2650-0x0000000185FB2660 0x0000000185FB2600-0x0000000185FB2610
		public bool allowMouseInputIfTouchSupported { get => default; set {} } // 0x0000000185FB2660-0x0000000185FB2670 0x0000000185FB2620-0x0000000185FB2630
		public bool allowTouchInput { get => default; set {} } // 0x0000000185FB2680-0x0000000185FB2690 0x0000000185FD2F90-0x0000000185FD2FA0
		public bool deselectIfBackgroundClicked { get => default; set {} } // 0x0000000185FD2FB0-0x0000000185FD2FC0 0x0000000185FCECB0-0x0000000185FCECC0
		private bool deselectBeforeSelecting { get => default; set {} } // 0x000000018B513ADC-0x000000018B513AF4 0x00000001834A0D60-0x00000001834A0D70
		public bool SetActionsById { get => default; set {} } // 0x000000018B5138A4-0x000000018B513994 0x0000000185FB2320-0x0000000185FB2330
		public int HorizontalActionId { get => default; set {} } // 0x000000018B513C1C-0x000000018B513D0C 0x0000000185FB2CE0-0x0000000185FB2CF0
		public int VerticalActionId { get => default; set {} } // 0x000000018B513AF4-0x000000018B513BE4 0x0000000185FB2CD0-0x0000000185FB2CE0
		public int SubmitActionId { get => default; set {} } // 0x000000018B5137B4-0x000000018B5138A4 0x000000018B513778-0x000000018B5137B4
		public int CancelActionId { get => default; set {} } // 0x0000000185FB2600-0x0000000185FB2610 0x0000000185FB7DA0-0x0000000185FB7DB0
		protected override bool isMouseSupported { get => default; } // 0x0000000185FD2FA0-0x0000000185FD2FB0 
		private bool isTouchAllowed { get => default; } // 0x0000000185FB7DA0-0x0000000185FB7DB0 
		public bool allowActivationOnMobileDevice { get => default; set {} } // 0x0000000185FD2FA0-0x0000000185FD2FB0 0x0000000185FB8D40-0x0000000185FB8D50
		public bool forceModuleActive { get => default; set {} } // 0x0000000185FB8D70-0x0000000185FB8D80 0x0000000185FB8D30-0x0000000185FB8D40
		public float inputActionsPerSecond { get => default; set {} } // 0x0000000185FB8D60-0x0000000185FB8D70 0x000000018346D8F0-0x000000018346D900
		public float repeatDelay { get => default; set {} } // 0x000000018B513DB4-0x000000018B513E5C 0x000000018349D710-0x000000018349D720
		public string horizontalAxis { get => default; set {} } // 0x000000018B513F04-0x000000018B513FAC 0x0000000181B388F0-0x0000000181B38900
		public string verticalAxis { get => default; set {} } // 0x000000018B513E5C-0x000000018B513F04 0x0000000185FB0300-0x0000000185FB0310
		public string submitButton { get => default; set {} } // 0x000000018B513D0C-0x000000018B513DB4 0x000000018B513520-0x000000018B5136B0
		public string cancelButton { get => default; set {} } // 0x000000018B5104F0-0x000000018B5105F4 0x000000018B5134B8-0x000000018B513520
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 57900
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting() {} // 0x0000000181460F70-0x0000000181460F80
			private PlayerSetting(PlayerSetting other) {} // 0x00000001874BE90C-0x00000001874BE91C
	
			// Methods
			public PlayerSetting Clone() => default; // 0x0000000185FB0DA0-0x0000000185FB0DB0
		}
	
		// Constructors
		private RewiredStandaloneInputModule() {} // 0x00000001840A27C0-0x00000001840A27D0
	
		// Methods
		protected override void Awake() {} // 0x000000018B513160-0x000000018B513450
		public override void UpdateModule() {} // 0x000000018B510438-0x000000018B5104F0
		public override bool IsModuleSupported() => default; // 0x000000018B5107FC-0x000000018B510804
		public override bool ShouldActivateModule() => default; // 0x000000018B5123F8-0x000000018B5124E8
		public override void ActivateModule() {} // 0x000000018B511CEC-0x000000018B511E50
		public override void DeactivateModule() {} // 0x000000018B511E50-0x000000018B5123F8
		public override void Process() {} // 0x000000018B5127A0-0x000000018B512990
		private bool ProcessTouchEvents() => default; // 0x000000018B510B58-0x000000018B510E14
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x000000018B5124E8-0x000000018B5127A0
		private bool SendSubmitEventToSelectedObject() => default; // 0x000000018B5105F4-0x000000018B510760
		private Vector2 GetRawMoveVector() => default; // 0x000000018B51165C-0x000000018B51179C
		private bool SendMoveEventToSelectedObject() => default; // 0x000000018B5113A8-0x000000018B51165C
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical) {
			downHorizontal = default;
			downVertical = default;
		} // 0x000000018B512990-0x000000018B512A64
		private void ProcessMouseEvents() {} // 0x000000018B51179C-0x000000018B511CEC
		private void ProcessMouseEvent(int playerId, int pointerIndex) {} // 0x000000018B510E14-0x000000018B510F80
		private bool SendUpdateEventToSelectedObject() => default; // 0x0000000185FD2F80-0x0000000185FD2F90
		private void ProcessMousePress(MouseButtonEventData data) {} // 0x000000018B513450-0x000000018B5134B8
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x000000018B511274-0x000000018B511388
		private void OnApplicationFocus(bool hasFocus) {} // 0x000000018B511118-0x000000018B511274
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x000000018B510F80-0x000000018B511118
		protected override void OnDestroy() {} // 0x000000018B512E00-0x000000018B513160
		protected override bool IsDefaultPlayer(int playerId) => default; // 0x000000018B512D14-0x000000018B512E00
		private void InitializeRewired() {} // 0x000000018B512A64-0x000000018B512D14
		private void SetupRewiredVars() {} // 0x000000018B51099C-0x000000018B5109D0
		private void SetUpRewiredPlayerMice() {} // 0x000000018B510968-0x000000018B51099C
		private void SetUpRewiredActions() {} // 0x000000018B510B24-0x000000018B510B58
		private bool GetButton(Player player, int actionId) => default; // 0x000000018B510AF0-0x000000018B510B24
		private bool GetButtonDown(Player player, int actionId) => default; // 0x000000018B510934-0x000000018B510968
		private bool GetNegativeButton(Player player, int actionId) => default; // 0x000000018B510760-0x000000018B5107BC
		private bool GetNegativeButtonDown(Player player, int actionId) => default; // 0x000000018B511388-0x000000018B511398
		private float GetAxis(Player player, int actionId) => default; // 0x000000018B5107BC-0x000000018B5107FC
		private void CheckEditorRecompile() {} // 0x000000018B510804-0x000000018B510934
		private void OnEditorRecompile() {} // 0x000000018B5109D0-0x000000018B510AF0
		private void ClearRewiredVars() {} // 0x000000018B511398-0x000000018B5113A0
		private bool DidAnyMouseMove() => default; // 0x000000018B5113A0-0x000000018B5113A8
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) => default; // 0x000000018B71A728-0x000000018B71A7A0
		private void OnRewiredInitialized() {} // 0x000000018B71A7A0-0x000000018B71A9C8
		private void OnRewiredShutDown() {} // 0x000000018B71A6C8-0x000000018B71A728
	}
}

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 57891
	{
		// Fields
		private static readonly System.Type[] _defaultTemplateTypes; // 0x00
		private static readonly System.Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static System.Type[] templateTypes { get; } // 0x000000018B5089BC-0x000000018B508A0C 
		public static System.Type[] templateInterfaceTypes { get; } // 0x000000018B50896C-0x000000018B5089BC 
	
		// Constructors
		static ControllerTemplateFactory() {} // 0x00000001859BE9A0-0x00000001859BED30
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload) => default; // 0x000000018B508730-0x000000018B50896C
	}
}

namespace Rewired.Localization
{
	public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 57902
	{
		// Fields
		private TextAsset _localizedStringsFile; // 0x20
		[NonSerialized]
		private Dictionary<string, string> _dictionary; // 0x28
		[NonSerialized]
		private bool _initialized; // 0x30
	
		// Properties
		protected virtual Dictionary<string, string> dictionary { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public virtual TextAsset localizedStringsFile { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018B71A6A4-0x000000018B71A6C8
		protected override bool initialized { get => default; } // 0x00000001814294C0-0x00000001814294D0 
	
		// Constructors
		public LocalizedStringProvider() {} // 0x000000018B71A624-0x000000018B71A6A4
	
		// Methods
		protected override bool Initialize() => default; // 0x000000018B71A400-0x000000018B71A41C
		protected virtual bool TryLoadLocalizedStringData() => default; // 0x000000018B71A498-0x000000018B71A624
		protected override bool TryGetLocalizedString(string key, out string result) {
			result = default;
			return default;
		} // 0x000000018B71A41C-0x000000018B71A498
	}

	public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 57903
	{
		// Fields
		private bool _prefetch; // 0x18
	
		// Properties
		public virtual bool prefetch { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x000000018B71A32C-0x000000018B71A400
		protected abstract bool initialized { get; }
	
		// Constructors
		protected LocalizedStringProviderBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B71A028-0x000000018B71A060
		protected virtual void OnDisable() {} // 0x000000018B719F38-0x000000018B71A028
		protected virtual void Update() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void TrySetLocalizedStringProvider() {} // 0x000000018B71A178-0x000000018B71A32C
		protected abstract bool Initialize();
		public virtual void Reload() {} // 0x000000018B71A060-0x000000018B71A12C
		protected abstract bool TryGetLocalizedString(string key, out string result);
		bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result) {
			result = default;
			return default;
		} // 0x000000018B71A12C-0x000000018B71A178
	}
}

namespace Rewired.Utils
{
	public class ExternalTools : IExternalTools // TypeDefIndex: 57863
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
		private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get => default; set {} } // 0x000000018B5093C8-0x000000018B509400 0x000000018B509500-0x000000018B509550
		public bool isEditorPaused { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public bool UnityInput_IsTouchPressureSupported { get => default; } // 0x000000018B5093C0-0x000000018B5093C8 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent;
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;
	
		// Constructors
		public ExternalTools() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Destroy() {} // 0x0000000185492010-0x0000000185492020
		public object GetPlatformInitializer() => default; // 0x0000000186474650-0x0000000186474658
		public string GetFocusedEditorWindowTitle() => default; // 0x000000018B509188-0x000000018B5091C0
		public bool IsEditorSceneViewFocused() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public bool LinuxInput_IsJoystickPreconfigured(string name) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int XboxOneInput_GetUserIdForGamepad(uint id) => default; // 0x00000001813AE580-0x00000001813AE590
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId) => default; // 0x00000001813AE580-0x00000001813AE590
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public string XboxOneInput_GetControllerType(ulong xboxControllerId) => default; // 0x000000018B5092FC-0x000000018B509334
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) => default; // 0x00000001813AE580-0x00000001813AE590
		public void XboxOne_Gamepad_UpdatePlugin() {} // 0x0000000185492010-0x0000000185492020
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) {} // 0x0000000185492010-0x0000000185492020
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids) {
			vids = default;
			pids = default;
		} // 0x000000018B5090D8-0x000000018B509188
		public int GetAndroidAPILevel() => default; // 0x0000000185FBE2F0-0x0000000185FBE300
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) {} // 0x00000001851D0CC0-0x00000001851D0D20
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic) => default; // 0x000000018B5091C0-0x000000018B509254
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) {} // 0x000000018B509254-0x000000018B5092FC
		public float UnityInput_GetTouchPressure(ref Touch touch) => default; // 0x0000000185FD2F50-0x0000000185FD2F60
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) => default; // 0x0000000185FD2F40-0x0000000185FD2F50
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) => default; // 0x000000018B50907C-0x000000018B5090D8
		public System.Type[] GetControllerTemplateTypes() => default; // 0x0000000184939E10-0x0000000184939F00
		public System.Type[] GetControllerTemplateInterfaceTypes() => default; // 0x0000000184939F00-0x0000000184939FA0
	}
}
