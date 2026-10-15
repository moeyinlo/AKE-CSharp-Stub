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

// Image 49: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87537-87591

namespace Rewired
{
	public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 87538
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

	public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 87539
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

	public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 87540
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

	public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 87541
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

	public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 87542
	{
		// Properties
		IControllerTemplateAxis leftPedal { get; }
		IControllerTemplateAxis rightPedal { get; }
		IControllerTemplateAxis slide { get; }
	}

	public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 87543
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

	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 87544
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x02646444
		public const int elementId_leftStickY = 1; // Metadata: 0x02646445
		public const int elementId_rightStickX = 2; // Metadata: 0x02646446
		public const int elementId_rightStickY = 3; // Metadata: 0x02646447
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x02646448
		public const int elementId_a = 4; // Metadata: 0x02646449
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x0264644A
		public const int elementId_b = 5; // Metadata: 0x0264644B
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x0264644C
		public const int elementId_c = 6; // Metadata: 0x0264644D
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x0264644E
		public const int elementId_x = 7; // Metadata: 0x0264644F
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x02646450
		public const int elementId_y = 8; // Metadata: 0x02646451
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x02646452
		public const int elementId_z = 9; // Metadata: 0x02646453
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x02646454
		public const int elementId_leftBumper = 10; // Metadata: 0x02646455
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x02646456
		public const int elementId_leftTrigger = 11; // Metadata: 0x02646457
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x02646458
		public const int elementId_rightBumper = 12; // Metadata: 0x02646459
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x0264645A
		public const int elementId_rightTrigger = 13; // Metadata: 0x0264645B
		public const int elementId_center1 = 14; // Metadata: 0x0264645C
		public const int elementId_back = 14; // Metadata: 0x0264645D
		public const int elementId_center2 = 15; // Metadata: 0x0264645E
		public const int elementId_start = 15; // Metadata: 0x0264645F
		public const int elementId_center3 = 16; // Metadata: 0x02646460
		public const int elementId_guide = 16; // Metadata: 0x02646461
		public const int elementId_leftStickButton = 17; // Metadata: 0x02646462
		public const int elementId_rightStickButton = 18; // Metadata: 0x02646463
		public const int elementId_dPadUp = 19; // Metadata: 0x02646464
		public const int elementId_dPadRight = 20; // Metadata: 0x02646465
		public const int elementId_dPadDown = 21; // Metadata: 0x02646466
		public const int elementId_dPadLeft = 22; // Metadata: 0x02646467
		public const int elementId_leftStick = 23; // Metadata: 0x02646468
		public const int elementId_rightStick = 24; // Metadata: 0x02646469
		public const int elementId_dPad = 25; // Metadata: 0x0264646A
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get; } // 0x000000018CBB910C-0x000000018CBB914C 
		IControllerTemplateButton IGamepadTemplate.a { get; } // 0x000000018CBB90CC-0x000000018CBB910C 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get; } // 0x000000018CBB914C-0x000000018CBB918C 
		IControllerTemplateButton IGamepadTemplate.b { get; } // 0x000000018CBB928C-0x000000018CBB92CC 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get; } // 0x000000018CBB918C-0x000000018CBB91CC 
		IControllerTemplateButton IGamepadTemplate.c { get; } // 0x000000018CBB930C-0x000000018CBB934C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get; } // 0x000000018CBB91CC-0x000000018CBB920C 
		IControllerTemplateButton IGamepadTemplate.x { get; } // 0x000000018CBB974C-0x000000018CBB978C 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get; } // 0x000000018CBB920C-0x000000018CBB924C 
		IControllerTemplateButton IGamepadTemplate.y { get; } // 0x000000018CBB978C-0x000000018CBB97CC 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get; } // 0x000000018CBB924C-0x000000018CBB928C 
		IControllerTemplateButton IGamepadTemplate.z { get; } // 0x000000018CBB97CC-0x000000018CBB980C 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get; } // 0x000000018CBB94CC-0x000000018CBB950C 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get; } // 0x000000018CBB948C-0x000000018CBB94CC 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get; } // 0x000000018CBB950C-0x000000018CBB954C 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get; } // 0x000000018CBB958C-0x000000018CBB95CC 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get; } // 0x000000018CBB960C-0x000000018CBB964C 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get; } // 0x000000018CBB95CC-0x000000018CBB960C 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get; } // 0x000000018CBB964C-0x000000018CBB968C 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get; } // 0x000000018CBB96CC-0x000000018CBB970C 
		IControllerTemplateButton IGamepadTemplate.center1 { get; } // 0x000000018CBB934C-0x000000018CBB938C 
		IControllerTemplateButton IGamepadTemplate.back { get; } // 0x000000018CBB92CC-0x000000018CBB930C 
		IControllerTemplateButton IGamepadTemplate.center2 { get; } // 0x000000018CBB938C-0x000000018CBB93CC 
		IControllerTemplateButton IGamepadTemplate.start { get; } // 0x000000018CBB970C-0x000000018CBB974C 
		IControllerTemplateButton IGamepadTemplate.center3 { get; } // 0x000000018CBB93CC-0x000000018CBB940C 
		IControllerTemplateButton IGamepadTemplate.guide { get; } // 0x000000018CBB944C-0x000000018CBB948C 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get; } // 0x000000018CBB954C-0x000000018CBB958C 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get; } // 0x000000018CBB968C-0x000000018CBB96CC 
		IControllerTemplateDPad IGamepadTemplate.dPad { get; } // 0x000000018CBB940C-0x000000018CBB944C 
	
		// Constructors
		public GamepadTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static GamepadTemplate(); // 0x000000018CBB980C-0x000000018CBB9870
	}

	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 87545
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x0264646B
		public const int elementId_accelerator = 1; // Metadata: 0x0264646C
		public const int elementId_brake = 2; // Metadata: 0x0264646D
		public const int elementId_clutch = 3; // Metadata: 0x0264646E
		public const int elementId_shiftDown = 4; // Metadata: 0x0264646F
		public const int elementId_shiftUp = 5; // Metadata: 0x02646470
		public const int elementId_wheelButton1 = 6; // Metadata: 0x02646471
		public const int elementId_wheelButton2 = 7; // Metadata: 0x02646472
		public const int elementId_wheelButton3 = 8; // Metadata: 0x02646473
		public const int elementId_wheelButton4 = 9; // Metadata: 0x02646474
		public const int elementId_wheelButton5 = 10; // Metadata: 0x02646475
		public const int elementId_wheelButton6 = 11; // Metadata: 0x02646476
		public const int elementId_wheelButton7 = 12; // Metadata: 0x02646477
		public const int elementId_wheelButton8 = 13; // Metadata: 0x02646478
		public const int elementId_wheelButton9 = 14; // Metadata: 0x02646479
		public const int elementId_wheelButton10 = 15; // Metadata: 0x0264647A
		public const int elementId_consoleButton1 = 16; // Metadata: 0x0264647B
		public const int elementId_consoleButton2 = 17; // Metadata: 0x0264647C
		public const int elementId_consoleButton3 = 18; // Metadata: 0x0264647D
		public const int elementId_consoleButton4 = 19; // Metadata: 0x0264647E
		public const int elementId_consoleButton5 = 20; // Metadata: 0x0264647F
		public const int elementId_consoleButton6 = 21; // Metadata: 0x02646480
		public const int elementId_consoleButton7 = 22; // Metadata: 0x02646481
		public const int elementId_consoleButton8 = 23; // Metadata: 0x02646482
		public const int elementId_consoleButton9 = 24; // Metadata: 0x02646483
		public const int elementId_consoleButton10 = 25; // Metadata: 0x02646484
		public const int elementId_shifter1 = 26; // Metadata: 0x02646485
		public const int elementId_shifter2 = 27; // Metadata: 0x02646486
		public const int elementId_shifter3 = 28; // Metadata: 0x02646487
		public const int elementId_shifter4 = 29; // Metadata: 0x02646488
		public const int elementId_shifter5 = 30; // Metadata: 0x02646489
		public const int elementId_shifter6 = 31; // Metadata: 0x0264648A
		public const int elementId_shifter7 = 32; // Metadata: 0x0264648B
		public const int elementId_shifter8 = 33; // Metadata: 0x0264648C
		public const int elementId_shifter9 = 34; // Metadata: 0x0264648D
		public const int elementId_shifter10 = 35; // Metadata: 0x0264648E
		public const int elementId_reverseGear = 44; // Metadata: 0x0264648F
		public const int elementId_select = 36; // Metadata: 0x02646490
		public const int elementId_start = 37; // Metadata: 0x02646491
		public const int elementId_systemButton = 38; // Metadata: 0x02646492
		public const int elementId_horn = 43; // Metadata: 0x02646493
		public const int elementId_dPadUp = 39; // Metadata: 0x02646494
		public const int elementId_dPadRight = 40; // Metadata: 0x02646495
		public const int elementId_dPadDown = 41; // Metadata: 0x02646496
		public const int elementId_dPadLeft = 42; // Metadata: 0x02646497
		public const int elementId_dPad = 45; // Metadata: 0x02646498
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get; } // 0x000000018CBBC618-0x000000018CBBC654 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get; } // 0x000000018CBBBBD8-0x000000018CBBBC18 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get; } // 0x000000018CBBBC18-0x000000018CBBBC58 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get; } // 0x000000018CBBBC58-0x000000018CBBBC98 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get; } // 0x000000018CBBC018-0x000000018CBBC058 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get; } // 0x000000018CBBC058-0x000000018CBBC098 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get; } // 0x000000018CBBC3D8-0x000000018CBBC418 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get; } // 0x000000018CBBC418-0x000000018CBBC458 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get; } // 0x000000018CBBC458-0x000000018CBBC498 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get; } // 0x000000018CBBC498-0x000000018CBBC4D8 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get; } // 0x000000018CBBC4D8-0x000000018CBBC518 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get; } // 0x000000018CBBC518-0x000000018CBBC558 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get; } // 0x000000018CBBC558-0x000000018CBBC598 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get; } // 0x000000018CBBC598-0x000000018CBBC5D8 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get; } // 0x000000018CBBC5D8-0x000000018CBBC618 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get; } // 0x000000018CBBC398-0x000000018CBBC3D8 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get; } // 0x000000018CBBBCD8-0x000000018CBBBD18 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get; } // 0x000000018CBBBD18-0x000000018CBBBD58 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get; } // 0x000000018CBBBD58-0x000000018CBBBD98 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get; } // 0x000000018CBBBD98-0x000000018CBBBDD8 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get; } // 0x000000018CBBBDD8-0x000000018CBBBE18 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get; } // 0x000000018CBBBE18-0x000000018CBBBE58 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get; } // 0x000000018CBBBE58-0x000000018CBBBE98 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get; } // 0x000000018CBBBE98-0x000000018CBBBED8 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get; } // 0x000000018CBBBED8-0x000000018CBBBF18 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get; } // 0x000000018CBBBC98-0x000000018CBBBCD8 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get; } // 0x000000018CBBC0D8-0x000000018CBBC118 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get; } // 0x000000018CBBC118-0x000000018CBBC158 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get; } // 0x000000018CBBC158-0x000000018CBBC198 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get; } // 0x000000018CBBC198-0x000000018CBBC1D8 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get; } // 0x000000018CBBC1D8-0x000000018CBBC218 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get; } // 0x000000018CBBC218-0x000000018CBBC258 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get; } // 0x000000018CBBC258-0x000000018CBBC298 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get; } // 0x000000018CBBC298-0x000000018CBBC2D8 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get; } // 0x000000018CBBC2D8-0x000000018CBBC318 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get; } // 0x000000018CBBC098-0x000000018CBBC0D8 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get; } // 0x000000018CBBBF98-0x000000018CBBBFD8 
		IControllerTemplateButton IRacingWheelTemplate.select { get; } // 0x000000018CBBBFD8-0x000000018CBBC018 
		IControllerTemplateButton IRacingWheelTemplate.start { get; } // 0x000000018CBBC318-0x000000018CBBC358 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get; } // 0x000000018CBBC358-0x000000018CBBC398 
		IControllerTemplateButton IRacingWheelTemplate.horn { get; } // 0x000000018CBBBF58-0x000000018CBBBF98 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get; } // 0x000000018CBBBF18-0x000000018CBBBF58 
	
		// Constructors
		public RacingWheelTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static RacingWheelTemplate(); // 0x000000018CBBC654-0x000000018CBBC6B8
	}

	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 87546
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x02646499
		public const int elementId_stickY = 1; // Metadata: 0x0264649A
		public const int elementId_stickRotate = 2; // Metadata: 0x0264649B
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x0264649C
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x0264649E
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x026464A0
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x026464A2
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x026464A4
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x026464A6
		public const int elementId_stickTrigger = 3; // Metadata: 0x026464A8
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x026464A9
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x026464AA
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x026464AB
		public const int elementId_stickButton1 = 6; // Metadata: 0x026464AD
		public const int elementId_stickButton2 = 7; // Metadata: 0x026464AE
		public const int elementId_stickButton3 = 8; // Metadata: 0x026464AF
		public const int elementId_stickButton4 = 9; // Metadata: 0x026464B0
		public const int elementId_stickButton5 = 10; // Metadata: 0x026464B1
		public const int elementId_stickButton6 = 11; // Metadata: 0x026464B2
		public const int elementId_stickButton7 = 12; // Metadata: 0x026464B3
		public const int elementId_stickButton8 = 13; // Metadata: 0x026464B4
		public const int elementId_stickButton9 = 14; // Metadata: 0x026464B5
		public const int elementId_stickButton10 = 15; // Metadata: 0x026464B6
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x026464B7
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x026464B8
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x026464B9
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x026464BA
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x026464BB
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x026464BC
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x026464BD
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x026464BE
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x026464BF
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x026464C0
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x026464C1
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x026464C3
		public const int elementId_stickHat1Up = 28; // Metadata: 0x026464C5
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x026464C6
		public const int elementId_stickHat1Right = 30; // Metadata: 0x026464C7
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x026464C8
		public const int elementId_stickHat1Down = 32; // Metadata: 0x026464C9
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x026464CA
		public const int elementId_stickHat1Left = 34; // Metadata: 0x026464CB
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x026464CC
		public const int elementId_stickHat2Up = 36; // Metadata: 0x026464CD
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x026464CE
		public const int elementId_stickHat2Right = 38; // Metadata: 0x026464CF
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x026464D0
		public const int elementId_stickHat2Down = 40; // Metadata: 0x026464D1
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x026464D2
		public const int elementId_stickHat2Left = 42; // Metadata: 0x026464D3
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x026464D4
		public const int elementId_stickHat3Up = 84; // Metadata: 0x026464D5
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x026464D7
		public const int elementId_stickHat3Right = 86; // Metadata: 0x026464D9
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x026464DB
		public const int elementId_stickHat3Down = 88; // Metadata: 0x026464DD
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x026464DF
		public const int elementId_stickHat3Left = 90; // Metadata: 0x026464E1
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x026464E3
		public const int elementId_stickHat4Up = 92; // Metadata: 0x026464E5
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x026464E7
		public const int elementId_stickHat4Right = 94; // Metadata: 0x026464E9
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x026464EB
		public const int elementId_stickHat4Down = 96; // Metadata: 0x026464ED
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x026464EF
		public const int elementId_stickHat4Left = 98; // Metadata: 0x026464F1
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x026464F3
		public const int elementId_mode1 = 44; // Metadata: 0x026464F5
		public const int elementId_mode2 = 45; // Metadata: 0x026464F6
		public const int elementId_mode3 = 46; // Metadata: 0x026464F7
		public const int elementId_throttle1Axis = 49; // Metadata: 0x026464F8
		public const int elementId_throttle2Axis = 155; // Metadata: 0x026464F9
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x026464FB
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x026464FD
		public const int elementId_throttleButton1 = 50; // Metadata: 0x026464FF
		public const int elementId_throttleButton2 = 51; // Metadata: 0x02646500
		public const int elementId_throttleButton3 = 52; // Metadata: 0x02646501
		public const int elementId_throttleButton4 = 53; // Metadata: 0x02646502
		public const int elementId_throttleButton5 = 54; // Metadata: 0x02646503
		public const int elementId_throttleButton6 = 55; // Metadata: 0x02646504
		public const int elementId_throttleButton7 = 56; // Metadata: 0x02646505
		public const int elementId_throttleButton8 = 57; // Metadata: 0x02646506
		public const int elementId_throttleButton9 = 58; // Metadata: 0x02646507
		public const int elementId_throttleButton10 = 59; // Metadata: 0x02646508
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x02646509
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x0264650A
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x0264650B
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x0264650C
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x0264650D
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x0264650F
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x02646511
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x02646513
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x02646515
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x02646517
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x02646519
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x0264651B
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x0264651D
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x0264651F
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x02646521
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x02646523
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x02646525
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x02646527
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x02646529
		public const int elementId_throttleDial1 = 74; // Metadata: 0x0264652B
		public const int elementId_throttleDial2 = 142; // Metadata: 0x0264652D
		public const int elementId_throttleDial3 = 143; // Metadata: 0x0264652F
		public const int elementId_throttleDial4 = 144; // Metadata: 0x02646531
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x02646533
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x02646535
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x02646537
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x02646539
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x0264653B
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x0264653D
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x0264653F
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x02646541
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x02646543
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x02646545
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x02646547
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x02646549
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x0264654B
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x0264654D
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x0264654F
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x02646551
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x02646553
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x02646555
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x02646557
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x02646559
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x0264655B
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x0264655D
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x0264655F
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x02646561
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x02646563
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x02646565
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x02646567
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x02646569
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x0264656B
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x0264656D
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x0264656F
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x02646571
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x02646573
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x02646575
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x02646577
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x02646579
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x0264657B
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x0264657D
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x0264657F
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x02646581
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x02646583
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x02646585
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x02646587
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x02646589
		public const int elementId_leftPedal = 168; // Metadata: 0x0264658B
		public const int elementId_rightPedal = 169; // Metadata: 0x0264658D
		public const int elementId_slidePedals = 170; // Metadata: 0x0264658F
		public const int elementId_stick = 171; // Metadata: 0x02646591
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x02646593
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x02646595
		public const int elementId_stickHat1 = 174; // Metadata: 0x02646597
		public const int elementId_stickHat2 = 175; // Metadata: 0x02646599
		public const int elementId_stickHat3 = 176; // Metadata: 0x0264659B
		public const int elementId_stickHat4 = 177; // Metadata: 0x0264659D
		public const int elementId_throttle1 = 178; // Metadata: 0x0264659F
		public const int elementId_throttle2 = 179; // Metadata: 0x026465A1
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x026465A3
		public const int elementId_throttleHat1 = 181; // Metadata: 0x026465A5
		public const int elementId_throttleHat2 = 182; // Metadata: 0x026465A7
		public const int elementId_throttleHat3 = 183; // Metadata: 0x026465A9
		public const int elementId_throttleHat4 = 184; // Metadata: 0x026465AB
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get; } // 0x000000018CBBA1B0-0x000000018CBBA1F0 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get; } // 0x000000018CBBA170-0x000000018CBBA1B0 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get; } // 0x000000018CBBA0F0-0x000000018CBBA130 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get; } // 0x000000018CBBA130-0x000000018CBBA170 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get; } // 0x000000018CBB9D30-0x000000018CBB9D70 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get; } // 0x000000018CBB9D70-0x000000018CBB9DB0 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get; } // 0x000000018CBB9DB0-0x000000018CBB9DF0 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get; } // 0x000000018CBB9DF0-0x000000018CBB9E30 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get; } // 0x000000018CBB9E30-0x000000018CBB9E70 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get; } // 0x000000018CBB9E70-0x000000018CBB9EB0 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get; } // 0x000000018CBB9EB0-0x000000018CBB9EF0 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get; } // 0x000000018CBB9EF0-0x000000018CBB9F30 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get; } // 0x000000018CBB9F30-0x000000018CBB9F70 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get; } // 0x000000018CBB9CF0-0x000000018CBB9D30 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get; } // 0x000000018CBB9AB0-0x000000018CBB9AF0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get; } // 0x000000018CBB9AF0-0x000000018CBB9B30 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get; } // 0x000000018CBB9B30-0x000000018CBB9B70 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get; } // 0x000000018CBB9B70-0x000000018CBB9BB0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get; } // 0x000000018CBB9BB0-0x000000018CBB9BF0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get; } // 0x000000018CBB9BF0-0x000000018CBB9C30 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get; } // 0x000000018CBB9C30-0x000000018CBB9C70 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get; } // 0x000000018CBB9C70-0x000000018CBB9CB0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get; } // 0x000000018CBB9CB0-0x000000018CBB9CF0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get; } // 0x000000018CBB99F0-0x000000018CBB9A30 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get; } // 0x000000018CBB9A30-0x000000018CBB9A70 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get; } // 0x000000018CBB9A70-0x000000018CBB9AB0 
		IControllerTemplateButton IHOTASTemplate.mode1 { get; } // 0x000000018CBB98B0-0x000000018CBB98F0 
		IControllerTemplateButton IHOTASTemplate.mode2 { get; } // 0x000000018CBB98F0-0x000000018CBB9930 
		IControllerTemplateButton IHOTASTemplate.mode3 { get; } // 0x000000018CBB9930-0x000000018CBB9970 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get; } // 0x000000018CBBA6B0-0x000000018CBBA6F0 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get; } // 0x000000018CBBA6F0-0x000000018CBBA730 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get; } // 0x000000018CBBA730-0x000000018CBBA770 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get; } // 0x000000018CBBA770-0x000000018CBBA7B0 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get; } // 0x000000018CBBA7B0-0x000000018CBBA7F0 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get; } // 0x000000018CBBA7F0-0x000000018CBBA830 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get; } // 0x000000018CBBA830-0x000000018CBBA870 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get; } // 0x000000018CBBA870-0x000000018CBBA8B0 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get; } // 0x000000018CBBA8B0-0x000000018CBBA8F0 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get; } // 0x000000018CBBA670-0x000000018CBBA6B0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get; } // 0x000000018CBBA430-0x000000018CBBA470 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get; } // 0x000000018CBBA470-0x000000018CBBA4B0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get; } // 0x000000018CBBA4B0-0x000000018CBBA4F0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get; } // 0x000000018CBBA4F0-0x000000018CBBA530 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get; } // 0x000000018CBBA530-0x000000018CBBA570 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get; } // 0x000000018CBBA570-0x000000018CBBA5B0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get; } // 0x000000018CBBA5B0-0x000000018CBBA5F0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get; } // 0x000000018CBBA5F0-0x000000018CBBA630 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get; } // 0x000000018CBBA630-0x000000018CBBA670 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get; } // 0x000000018CBBA2B0-0x000000018CBBA2F0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get; } // 0x000000018CBBA2F0-0x000000018CBBA330 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get; } // 0x000000018CBBA330-0x000000018CBBA370 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get; } // 0x000000018CBBA370-0x000000018CBBA3B0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get; } // 0x000000018CBBA3B0-0x000000018CBBA3F0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get; } // 0x000000018CBBA3F0-0x000000018CBBA430 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get; } // 0x000000018CBBAB30-0x000000018CBBAB70 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get; } // 0x000000018CBBAB70-0x000000018CBBABB0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get; } // 0x000000018CBBABB0-0x000000018CBBABF0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get; } // 0x000000018CBBABF0-0x000000018CBBAC30 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get; } // 0x000000018CBBA8F0-0x000000018CBBA930 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get; } // 0x000000018CBBA930-0x000000018CBBA970 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get; } // 0x000000018CBBA970-0x000000018CBBA9B0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get; } // 0x000000018CBBA9B0-0x000000018CBBA9F0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get; } // 0x000000018CBBAC70-0x000000018CBBACB0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get; } // 0x000000018CBBAC30-0x000000018CBBAC70 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get; } // 0x000000018CBBACB0-0x000000018CBBACF0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get; } // 0x000000018CBBAD30-0x000000018CBBAD70 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get; } // 0x000000018CBBACF0-0x000000018CBBAD30 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get; } // 0x000000018CBBAD70-0x000000018CBBADB0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get; } // 0x000000018CBBADF0-0x000000018CBBAE30 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get; } // 0x000000018CBBADB0-0x000000018CBBADF0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get; } // 0x000000018CBBAE30-0x000000018CBBAE70 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get; } // 0x000000018CBB9870-0x000000018CBB98B0 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get; } // 0x000000018CBB9970-0x000000018CBB99B0 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get; } // 0x000000018CBB99B0-0x000000018CBB99F0 
		IControllerTemplateStick IHOTASTemplate.stick { get; } // 0x000000018CBBA1F0-0x000000018CBBA230 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get; } // 0x000000018CBBA070-0x000000018CBBA0B0 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get; } // 0x000000018CBBA0B0-0x000000018CBBA0F0 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get; } // 0x000000018CBB9F70-0x000000018CBB9FB0 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get; } // 0x000000018CBB9FB0-0x000000018CBB9FF0 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get; } // 0x000000018CBB9FF0-0x000000018CBBA030 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get; } // 0x000000018CBBA030-0x000000018CBBA070 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get; } // 0x000000018CBBA230-0x000000018CBBA270 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get; } // 0x000000018CBBA270-0x000000018CBBA2B0 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get; } // 0x000000018CBBAAF0-0x000000018CBBAB30 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get; } // 0x000000018CBBA9F0-0x000000018CBBAA30 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get; } // 0x000000018CBBAA30-0x000000018CBBAA70 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get; } // 0x000000018CBBAA70-0x000000018CBBAAB0 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get; } // 0x000000018CBBAAB0-0x000000018CBBAAF0 
	
		// Constructors
		public HOTASTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static HOTASTemplate(); // 0x000000018CBBAE70-0x000000018CBBAED4
	}

	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 87547
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x026465AD
		public const int elementId_yokeZ = 1; // Metadata: 0x026465AE
		public const int elementId_leftPaddle = 59; // Metadata: 0x026465AF
		public const int elementId_rightPaddle = 60; // Metadata: 0x026465B0
		public const int elementId_lever1Axis = 2; // Metadata: 0x026465B1
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x026465B2
		public const int elementId_lever2Axis = 3; // Metadata: 0x026465B4
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x026465B5
		public const int elementId_lever3Axis = 4; // Metadata: 0x026465B7
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x026465B8
		public const int elementId_lever4Axis = 5; // Metadata: 0x026465BA
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x026465BB
		public const int elementId_lever5Axis = 6; // Metadata: 0x026465BD
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x026465BE
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x026465C0
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x026465C1
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x026465C2
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x026465C3
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x026465C4
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x026465C5
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x026465C6
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x026465C7
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x026465C8
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x026465C9
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x026465CA
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x026465CB
		public const int elementId_centerButton1 = 19; // Metadata: 0x026465CC
		public const int elementId_centerButton2 = 20; // Metadata: 0x026465CD
		public const int elementId_centerButton3 = 21; // Metadata: 0x026465CE
		public const int elementId_centerButton4 = 22; // Metadata: 0x026465CF
		public const int elementId_centerButton5 = 23; // Metadata: 0x026465D0
		public const int elementId_centerButton6 = 24; // Metadata: 0x026465D1
		public const int elementId_centerButton7 = 25; // Metadata: 0x026465D2
		public const int elementId_centerButton8 = 26; // Metadata: 0x026465D3
		public const int elementId_wheel1Up = 53; // Metadata: 0x026465D4
		public const int elementId_wheel1Down = 54; // Metadata: 0x026465D5
		public const int elementId_wheel1Press = 55; // Metadata: 0x026465D6
		public const int elementId_wheel2Up = 56; // Metadata: 0x026465D7
		public const int elementId_wheel2Down = 57; // Metadata: 0x026465D8
		public const int elementId_wheel2Press = 58; // Metadata: 0x026465D9
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x026465DA
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x026465DB
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x026465DC
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x026465DD
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x026465DE
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x026465DF
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x026465E0
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x026465E1
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x026465E2
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x026465E3
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x026465E4
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x026465E5
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x026465E6
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x026465E7
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x026465E8
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x026465E9
		public const int elementId_consoleButton1 = 43; // Metadata: 0x026465EA
		public const int elementId_consoleButton2 = 44; // Metadata: 0x026465EB
		public const int elementId_consoleButton3 = 45; // Metadata: 0x026465EC
		public const int elementId_consoleButton4 = 46; // Metadata: 0x026465ED
		public const int elementId_consoleButton5 = 47; // Metadata: 0x026465EE
		public const int elementId_consoleButton6 = 48; // Metadata: 0x026465EF
		public const int elementId_consoleButton7 = 49; // Metadata: 0x026465F0
		public const int elementId_consoleButton8 = 50; // Metadata: 0x026465F1
		public const int elementId_consoleButton9 = 51; // Metadata: 0x026465F2
		public const int elementId_consoleButton10 = 52; // Metadata: 0x026465F3
		public const int elementId_mode1 = 61; // Metadata: 0x026465F4
		public const int elementId_mode2 = 62; // Metadata: 0x026465F5
		public const int elementId_mode3 = 63; // Metadata: 0x026465F6
		public const int elementId_yoke = 69; // Metadata: 0x026465F7
		public const int elementId_lever1 = 70; // Metadata: 0x026465F9
		public const int elementId_lever2 = 71; // Metadata: 0x026465FB
		public const int elementId_lever3 = 72; // Metadata: 0x026465FD
		public const int elementId_lever4 = 73; // Metadata: 0x026465FF
		public const int elementId_lever5 = 74; // Metadata: 0x02646601
		public const int elementId_leftGripHat = 75; // Metadata: 0x02646603
		public const int elementId_rightGripHat = 76; // Metadata: 0x02646605
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get; } // 0x000000018CBB8A68-0x000000018CBB8AA8 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get; } // 0x000000018CBB8E68-0x000000018CBB8EA8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get; } // 0x000000018CBB88A8-0x000000018CBB88E8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get; } // 0x000000018CBB88E8-0x000000018CBB8928 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get; } // 0x000000018CBB8928-0x000000018CBB8968 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get; } // 0x000000018CBB8968-0x000000018CBB89A8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get; } // 0x000000018CBB89A8-0x000000018CBB89E8 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get; } // 0x000000018CBB89E8-0x000000018CBB8A28 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get; } // 0x000000018CBB8CA8-0x000000018CBB8CE8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get; } // 0x000000018CBB8CE8-0x000000018CBB8D28 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get; } // 0x000000018CBB8D28-0x000000018CBB8D68 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get; } // 0x000000018CBB8D68-0x000000018CBB8DA8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get; } // 0x000000018CBB8DA8-0x000000018CBB8DE8 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get; } // 0x000000018CBB8DE8-0x000000018CBB8E28 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get; } // 0x000000018CBB8428-0x000000018CBB8468 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get; } // 0x000000018CBB8468-0x000000018CBB84A8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get; } // 0x000000018CBB84A8-0x000000018CBB84E8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get; } // 0x000000018CBB84E8-0x000000018CBB8528 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get; } // 0x000000018CBB8528-0x000000018CBB8568 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get; } // 0x000000018CBB8568-0x000000018CBB85A8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get; } // 0x000000018CBB85A8-0x000000018CBB85E8 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get; } // 0x000000018CBB85E8-0x000000018CBB8628 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get; } // 0x000000018CBB8F28-0x000000018CBB8F68 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get; } // 0x000000018CBB8EA8-0x000000018CBB8EE8 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get; } // 0x000000018CBB8EE8-0x000000018CBB8F28 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get; } // 0x000000018CBB8FE8-0x000000018CBB9028 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get; } // 0x000000018CBB8F68-0x000000018CBB8FA8 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get; } // 0x000000018CBB8FA8-0x000000018CBB8FE8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get; } // 0x000000018CBB8668-0x000000018CBB86A8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get; } // 0x000000018CBB86A8-0x000000018CBB86E8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get; } // 0x000000018CBB86E8-0x000000018CBB8728 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get; } // 0x000000018CBB8728-0x000000018CBB8768 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get; } // 0x000000018CBB8768-0x000000018CBB87A8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get; } // 0x000000018CBB87A8-0x000000018CBB87E8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get; } // 0x000000018CBB87E8-0x000000018CBB8828 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get; } // 0x000000018CBB8828-0x000000018CBB8868 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get; } // 0x000000018CBB8868-0x000000018CBB88A8 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get; } // 0x000000018CBB8628-0x000000018CBB8668 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get; } // 0x000000018CBB8BE8-0x000000018CBB8C28 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get; } // 0x000000018CBB8C28-0x000000018CBB8C68 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get; } // 0x000000018CBB8C68-0x000000018CBB8CA8 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get; } // 0x000000018CBB9028-0x000000018CBB9068 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get; } // 0x000000018CBB8AA8-0x000000018CBB8AE8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get; } // 0x000000018CBB8AE8-0x000000018CBB8B28 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get; } // 0x000000018CBB8B28-0x000000018CBB8B68 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get; } // 0x000000018CBB8B68-0x000000018CBB8BA8 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get; } // 0x000000018CBB8BA8-0x000000018CBB8BE8 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get; } // 0x000000018CBB8A28-0x000000018CBB8A68 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get; } // 0x000000018CBB8E28-0x000000018CBB8E68 
	
		// Constructors
		public FlightYokeTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static FlightYokeTemplate(); // 0x000000018CBB9068-0x000000018CBB90CC
	}

	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 87548
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x02646607
		public const int elementId_rightPedal = 1; // Metadata: 0x02646608
		public const int elementId_slide = 2; // Metadata: 0x02646609
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get; } // 0x000000018CBB8300-0x000000018CBB833C 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get; } // 0x000000018CBB833C-0x000000018CBB837C 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get; } // 0x000000018CBB837C-0x000000018CBB83BC 
	
		// Constructors
		public FlightPedalsTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static FlightPedalsTemplate(); // 0x000000018CBB83BC-0x000000018CBB8420
	}

	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 87549
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x0264660A
		public const int elementId_positionY = 2; // Metadata: 0x0264660B
		public const int elementId_positionZ = 0; // Metadata: 0x0264660C
		public const int elementId_rotationX = 3; // Metadata: 0x0264660D
		public const int elementId_rotationY = 5; // Metadata: 0x0264660E
		public const int elementId_rotationZ = 4; // Metadata: 0x0264660F
		public const int elementId_throttle1Axis = 6; // Metadata: 0x02646610
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x02646611
		public const int elementId_throttle2Axis = 7; // Metadata: 0x02646612
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x02646613
		public const int elementId_extraAxis1 = 8; // Metadata: 0x02646614
		public const int elementId_extraAxis2 = 9; // Metadata: 0x02646615
		public const int elementId_extraAxis3 = 10; // Metadata: 0x02646616
		public const int elementId_extraAxis4 = 11; // Metadata: 0x02646617
		public const int elementId_button1 = 12; // Metadata: 0x02646618
		public const int elementId_button2 = 13; // Metadata: 0x02646619
		public const int elementId_button3 = 14; // Metadata: 0x0264661A
		public const int elementId_button4 = 15; // Metadata: 0x0264661B
		public const int elementId_button5 = 16; // Metadata: 0x0264661C
		public const int elementId_button6 = 17; // Metadata: 0x0264661D
		public const int elementId_button7 = 18; // Metadata: 0x0264661E
		public const int elementId_button8 = 19; // Metadata: 0x0264661F
		public const int elementId_button9 = 20; // Metadata: 0x02646620
		public const int elementId_button10 = 21; // Metadata: 0x02646621
		public const int elementId_button11 = 22; // Metadata: 0x02646622
		public const int elementId_button12 = 23; // Metadata: 0x02646623
		public const int elementId_button13 = 24; // Metadata: 0x02646624
		public const int elementId_button14 = 25; // Metadata: 0x02646625
		public const int elementId_button15 = 26; // Metadata: 0x02646626
		public const int elementId_button16 = 27; // Metadata: 0x02646627
		public const int elementId_button17 = 28; // Metadata: 0x02646628
		public const int elementId_button18 = 29; // Metadata: 0x02646629
		public const int elementId_button19 = 30; // Metadata: 0x0264662A
		public const int elementId_button20 = 31; // Metadata: 0x0264662B
		public const int elementId_button21 = 55; // Metadata: 0x0264662C
		public const int elementId_button22 = 56; // Metadata: 0x0264662D
		public const int elementId_button23 = 57; // Metadata: 0x0264662E
		public const int elementId_button24 = 58; // Metadata: 0x0264662F
		public const int elementId_button25 = 59; // Metadata: 0x02646630
		public const int elementId_button26 = 60; // Metadata: 0x02646631
		public const int elementId_button27 = 61; // Metadata: 0x02646632
		public const int elementId_button28 = 62; // Metadata: 0x02646633
		public const int elementId_button29 = 63; // Metadata: 0x02646634
		public const int elementId_button30 = 64; // Metadata: 0x02646635
		public const int elementId_button31 = 65; // Metadata: 0x02646637
		public const int elementId_button32 = 66; // Metadata: 0x02646639
		public const int elementId_hat1Up = 32; // Metadata: 0x0264663B
		public const int elementId_hat1UpRight = 33; // Metadata: 0x0264663C
		public const int elementId_hat1Right = 34; // Metadata: 0x0264663D
		public const int elementId_hat1DownRight = 35; // Metadata: 0x0264663E
		public const int elementId_hat1Down = 36; // Metadata: 0x0264663F
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x02646640
		public const int elementId_hat1Left = 38; // Metadata: 0x02646641
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x02646642
		public const int elementId_hat2Up = 40; // Metadata: 0x02646643
		public const int elementId_hat2UpRight = 41; // Metadata: 0x02646644
		public const int elementId_hat2Right = 42; // Metadata: 0x02646645
		public const int elementId_hat2DownRight = 43; // Metadata: 0x02646646
		public const int elementId_hat2Down = 44; // Metadata: 0x02646647
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x02646648
		public const int elementId_hat2Left = 46; // Metadata: 0x02646649
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x0264664A
		public const int elementId_hat1 = 48; // Metadata: 0x0264664B
		public const int elementId_hat2 = 49; // Metadata: 0x0264664C
		public const int elementId_throttle1 = 52; // Metadata: 0x0264664D
		public const int elementId_throttle2 = 53; // Metadata: 0x0264664E
		public const int elementId_stick = 54; // Metadata: 0x0264664F
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get; } // 0x000000018CBC37D4-0x000000018CBC3814 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get; } // 0x000000018CBC3814-0x000000018CBC3854 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get; } // 0x000000018CBC3854-0x000000018CBC3894 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get; } // 0x000000018CBC3894-0x000000018CBC38D4 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get; } // 0x000000018CBC3254-0x000000018CBC3294 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get; } // 0x000000018CBC3514-0x000000018CBC3554 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get; } // 0x000000018CBC3614-0x000000018CBC3654 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get; } // 0x000000018CBC3654-0x000000018CBC3694 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get; } // 0x000000018CBC3694-0x000000018CBC36D4 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get; } // 0x000000018CBC36D4-0x000000018CBC3714 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get; } // 0x000000018CBC3714-0x000000018CBC3754 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get; } // 0x000000018CBC3754-0x000000018CBC3794 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get; } // 0x000000018CBC3794-0x000000018CBC37D4 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get; } // 0x000000018CBC2FD4-0x000000018CBC3014 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get; } // 0x000000018CBC3014-0x000000018CBC3054 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get; } // 0x000000018CBC3054-0x000000018CBC3094 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get; } // 0x000000018CBC3094-0x000000018CBC30D4 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get; } // 0x000000018CBC30D4-0x000000018CBC3114 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get; } // 0x000000018CBC3114-0x000000018CBC3154 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get; } // 0x000000018CBC3154-0x000000018CBC3194 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get; } // 0x000000018CBC3194-0x000000018CBC31D4 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get; } // 0x000000018CBC31D4-0x000000018CBC3214 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get; } // 0x000000018CBC3214-0x000000018CBC3254 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get; } // 0x000000018CBC3294-0x000000018CBC32D4 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get; } // 0x000000018CBC32D4-0x000000018CBC3314 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get; } // 0x000000018CBC3314-0x000000018CBC3354 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get; } // 0x000000018CBC3354-0x000000018CBC3394 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get; } // 0x000000018CBC3394-0x000000018CBC33D4 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get; } // 0x000000018CBC33D4-0x000000018CBC3414 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get; } // 0x000000018CBC3414-0x000000018CBC3454 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get; } // 0x000000018CBC3454-0x000000018CBC3494 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get; } // 0x000000018CBC3494-0x000000018CBC34D4 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get; } // 0x000000018CBC34D4-0x000000018CBC3514 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get; } // 0x000000018CBC3554-0x000000018CBC3594 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get; } // 0x000000018CBC3594-0x000000018CBC35D4 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get; } // 0x000000018CBC35D4-0x000000018CBC3614 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get; } // 0x000000018CBC38D4-0x000000018CBC3914 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get; } // 0x000000018CBC3914-0x000000018CBC3954 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get; } // 0x000000018CBC3994-0x000000018CBC39D4 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get; } // 0x000000018CBC39D4-0x000000018CBC3A14 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get; } // 0x000000018CBC3954-0x000000018CBC3994 
	
		// Constructors
		public SixDofControllerTemplate(object payload); // 0x000000018CBB8420-0x000000018CBB8428
		static SixDofControllerTemplate(); // 0x000000018CBC3A14-0x000000018CBC3A78
	}

	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base // TypeDefIndex: 87550
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager(); // 0x000000018717B040-0x000000018717B050
	
		// Methods
		protected override void OnInitialized(); // 0x00000001861B2800-0x00000001861B2810
		protected override void OnDeinitialized(); // 0x000000018CBBAF5C-0x000000018CBBAF64
		protected override void DetectPlatform(); // 0x0000000185DE33B0-0x0000000185DE3410
		protected override void CheckRecompile(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override IExternalTools GetExternalTools(); // 0x00000001871FCCE0-0x00000001871FCD20
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel); // 0x000000018CBBAED4-0x000000018CBBAF5C
		private void SubscribeEvents(); // 0x00000001861B2D50-0x00000001861B2E00
		private void UnsubscribeEvents(); // 0x00000001861B2E00-0x00000001861B2EA0
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x00000001856F1660-0x00000001856F1670
	}
}

namespace Rewired.Data
{
	public class UserDataStore_File : UserDataStore_KeyValue // TypeDefIndex: 87559
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x02646650
		private const string defaultExtensionText = ".json"; // Metadata: 0x0264665A
		private const string defaultExtensionBinary = ".bin"; // Metadata: 0x02646660
		private const string defaultFileName = "RewiredSaveData.json"; // Metadata: 0x02646665
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
		public string directory { get; set; } // 0x000000018CBC4268-0x000000018CBC42A0 0x000000018CBC42E4-0x000000018CBC4314
		public string fileName { get; set; } // 0x0000000182986470-0x0000000182986480 0x000000018CBC4314-0x000000018CBC4344
		public DataFormat dataFormat { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x000000018CBC42A0-0x000000018CBC42B4
		protected IDataHandler dataHandler { get; set; } // 0x000000018CBC4168-0x000000018CBC4268 0x000000018CBC42B4-0x000000018CBC42E4
		protected override IDataStore dataStore { get; } // 0x000000018226EBD0-0x000000018226EBE0 
	
		// Nested types
		private sealed class DataStore : UserDataStore_KeyValue.IDataStore // TypeDefIndex: 87552
		{
			// Fields
			private Dictionary<string, object> _data; // 0x10
			private readonly string _absFilePath; // 0x18
			private IDataHandler _dataHandler; // 0x20
	
			// Constructors
			public DataStore(string fileName, string absDirectory, IDataHandler dataHandler); // 0x000000018CBB7CFC-0x000000018CBB7E2C
	
			// Methods
			public bool TryGetValue(string key, out object value); // 0x000000018CBB7C78-0x000000018CBB7CFC
			public bool SetValue(string key, object value); // 0x000000018CBB7C00-0x000000018CBB7C78
			public bool Save(); // 0x000000018CBB7B04-0x000000018CBB7C00
			public bool Load(); // 0x000000018CBB7958-0x000000018CBB7B04
			public bool Clear(); // 0x000000018CBB7824-0x000000018CBB7958
		}
	
		private sealed class LocalFileDataHandler : IDataHandler // TypeDefIndex: 87553
		{
			// Fields
			private readonly Func<DataFormat> _dataFormatDelegate; // 0x10
			private readonly Codec _codec; // 0x18
	
			// Constructors
			public LocalFileDataHandler(Func<DataFormat> dataFormatDelegate, Codec codec); // 0x000000018CBBB4E4-0x000000018CBBB5B4
	
			// Methods
			public bool Load(string absoluteFilePath, out string data); // 0x000000018CBBB11C-0x000000018CBBB300
			public bool Save(string absoluteFilePath, string data); // 0x000000018CBBB300-0x000000018CBBB4E4
			public bool Clear(string absoluteFilePath); // 0x000000018CBBB05C-0x000000018CBBB11C
		}
	
		private abstract class Codec // TypeDefIndex: 87554
		{
			// Constructors
			protected Codec(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public abstract byte[] Encode(string @string);
			public abstract string Decode(byte[] data);
		}
	
		private sealed class UTF8Text : Codec // TypeDefIndex: 87555
		{
			// Constructors
			public UTF8Text(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override byte[] Encode(string @string); // 0x000000018CBC3D08-0x000000018CBC3D38
			public override string Decode(byte[] data); // 0x000000018CBC3CD8-0x000000018CBC3D08
		}
	
		private sealed class CLZF2 : Codec // TypeDefIndex: 87556
		{
			// Fields
			private readonly Utils.Libraries.CLZF2.CLZF2 _cLZF2; // 0x10
	
			// Constructors
			public CLZF2(); // 0x000000018CBB7230-0x000000018CBB7294
	
			// Methods
			public override byte[] Encode(string @string); // 0x000000018CBB71E0-0x000000018CBB7230
			public override string Decode(byte[] data); // 0x000000018CBB7184-0x000000018CBB71E0
		}
	
		public interface IDataHandler // TypeDefIndex: 87557
		{
			// Methods
			bool Load(string absoluteFilePath, out string data);
			bool Save(string absoluteFilePath, string data);
			bool Clear(string absoluteFilePath);
		}
	
		public enum DataFormat // TypeDefIndex: 87558
		{
			Text = 0,
			Binary = 1
		}
	
		// Constructors
		public UserDataStore_File(); // 0x000000018CBC4108-0x000000018CBC4168
		static UserDataStore_File(); // 0x000000018CBC4070-0x000000018CBC4108
	
		// Methods
		protected virtual void SetInitialValues(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnInitialize(); // 0x000000018CBC404C-0x000000018CBC4070
		private void OnDataSourceChanged(); // 0x000000018CBC3F78-0x000000018CBC404C
		[CompilerGenerated]
		private DataFormat _get_dataHandler_b__17_0(); // 0x0000000182271C50-0x0000000182271C60
	}

	public abstract class UserDataStore_KeyValue : UserDataStore // TypeDefIndex: 87569
	{
		// Fields
		private static readonly string thisScriptName; // 0x00
		private const string logPrefix = "Rewired: "; // Metadata: 0x0264667C
		private const string key_controllerAssignments = "ControllerAssignments"; // Metadata: 0x02646686
		private const int controllerMapKeyVersion = 0; // Metadata: 0x0264669C
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
		public bool isEnabled { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool loadDataOnStart { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public bool loadJoystickAssignments { get; set; } // 0x000000018226EDC0-0x000000018226EDD0 0x000000018226EDD0-0x000000018226EDE0
		public bool loadKeyboardAssignments { get; set; } // 0x00000001872364A0-0x00000001872364B0 0x00000001872364D0-0x00000001872364E0
		public bool loadMouseAssignments { get; set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
		protected abstract IDataStore dataStore { get; }
		private bool loadControllerAssignments { get; } // 0x000000018CBC997C-0x000000018CBC9990 
		private List<int> allActionIds { get; } // 0x000000018CBC983C-0x000000018CBC997C 
		private string allActionIdsString { get; } // 0x000000018CBC9724-0x000000018CBC983C 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 87562
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x000000018564C6A0-0x000000018564C6C0 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 87560
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x0000000185384260-0x0000000185384280 
	
				// Constructors
				public PlayerInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x000000018CBBB8DC-0x000000018CBBB960
				public bool ContainsJoystick(int joystickId); // 0x000000018CBBB8C4-0x000000018CBBB8DC
			}
	
			public class JoystickInfo // TypeDefIndex: 87561
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			public ControllerAssignmentSaveInfo(int playerCount); // 0x000000018CBB7330-0x000000018CBB73F8
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x000000018CBB72AC-0x000000018CBB7330
			public bool ContainsPlayer(int playerId); // 0x000000018CBB7294-0x000000018CBB72AC
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 87563
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId); // 0x000000018CBBAFE0-0x000000018CBBB05C
		}
	
		protected interface IDataStore // TypeDefIndex: 87564
		{
			// Methods
			bool Save();
			bool Load();
			bool Clear();
			bool TryGetValue(string key, out object result);
			bool SetValue(string key, object value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 87565
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x); // 0x000000018CB3DE4C-0x000000018CB3DE6C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_1 // TypeDefIndex: 87566
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass71_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x); // 0x000000018CBC3CB0-0x000000018CBC3CD8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_2 // TypeDefIndex: 87567
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass71_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x); // 0x000000018CB3DE4C-0x000000018CB3DE6C
		}
	
		[CompilerGenerated]
		private sealed class _LoadJoystickAssignmentsDeferred_d__73 : IEnumerator<object> // TypeDefIndex: 87568
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_KeyValue __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _LoadJoystickAssignmentsDeferred_d__73(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CBC3A78-0x000000018CBC3B48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CBC3B48-0x000000018CBC3B94
		}
	
		// Constructors
		protected UserDataStore_KeyValue(); // 0x000000018CBC96A8-0x000000018CBC9724
		static UserDataStore_KeyValue(); // 0x000000018CBC9610-0x000000018CBC96A8
	
		// Methods
		public override void Save(); // 0x000000018CBC9294-0x000000018CBC9350
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC85D8-0x000000018CBC86C0
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC8504-0x000000018CBC85D8
		public override void SavePlayerData(int playerId); // 0x000000018CBC91D4-0x000000018CBC9294
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x000000018CBC8D14-0x000000018CBC8DE4
		public override void Load(); // 0x000000018CBC7C88-0x000000018CBC7D44
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC5DC0-0x000000018CBC5EA8
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC5EA8-0x000000018CBC5F78
		public override void LoadPlayerData(int playerId); // 0x000000018CBC7BC8-0x000000018CBC7C88
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x000000018CBC6540-0x000000018CBC6610
		protected override void OnInitialize(); // 0x000000018CBC7E1C-0x000000018CBC7EA4
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x000000018CBC7D44-0x000000018CBC7DBC
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x000000018CBC7DEC-0x000000018CBC7E1C
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x000000018CBC7DBC-0x000000018CBC7DEC
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x000000018CBC88A4-0x000000018CBC8948
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBC6098-0x000000018CBC615C
		public virtual void ClearSaveData(); // 0x000000018CBC4B14-0x000000018CBC4B68
		private int LoadAll(); // 0x000000018CBC5A28-0x000000018CBC5B2C
		private int LoadPlayerDataNow(int playerId); // 0x000000018CBC7918-0x000000018CBC7988
		private int LoadPlayerDataNow(Player player); // 0x000000018CBC7988-0x000000018CBC7BC8
		private int LoadAllJoystickCalibrationData(); // 0x000000018CBC595C-0x000000018CBC5A28
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018CBC7458-0x000000018CBC7490
		private int LoadJoystickCalibrationData(int joystickId); // 0x000000018CBC7490-0x000000018CBC7500
		private int LoadJoystickData(int joystickId); // 0x000000018CBC7500-0x000000018CBC764C
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC5D30-0x000000018CBC5DA0
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC5DA0-0x000000018CBC5DC0
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC615C-0x000000018CBC63D8
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBC5F78-0x000000018CBC6098
		private int LoadInputBehaviors(int playerId); // 0x000000018CBC6610-0x000000018CBC6738
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x000000018CBC63D8-0x000000018CBC649C
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018CBC649C-0x000000018CBC6540
		private bool LoadControllerAssignmentsNow(); // 0x000000018CBC5C70-0x000000018CBC5D30
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018CBC764C-0x000000018CBC7918
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018CBC6794-0x000000018CBC7458
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x000000018CBC5B2C-0x000000018CBC5C70
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__73))]
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x000000018CBC6738-0x000000018CBC6794
		private void SaveAll(); // 0x000000018CBC7FDC-0x000000018CBC80D8
		private void SavePlayerDataNow(int playerId); // 0x000000018CBC914C-0x000000018CBC91D4
		private void SavePlayerDataNow(Player player); // 0x000000018CBC9088-0x000000018CBC914C
		private void SaveAllJoystickCalibrationData(); // 0x000000018CBC7F20-0x000000018CBC7FDC
		private void SaveJoystickCalibrationData(int joystickId); // 0x000000018CBC8E60-0x000000018CBC8ED0
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018CBC8ED0-0x000000018CBC8F64
		private void SaveJoystickData(int joystickId); // 0x000000018CBC8F64-0x000000018CBC9088
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC84A8-0x000000018CBC84F0
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC84F0-0x000000018CBC8504
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x000000018CBC8A64-0x000000018CBC8BC4
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBC8948-0x000000018CBC8A64
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x000000018CBC86C0-0x000000018CBC88A4
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x000000018CBC8DE4-0x000000018CBC8E60
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x000000018CBC8C38-0x000000018CBC8D14
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018CBC8BC4-0x000000018CBC8C38
		private bool SaveControllerAssignments(); // 0x000000018CBC80D8-0x000000018CBC84A8
		private static void AppendBaseKey(StringBuilder sb, Player player); // 0x000000018CBC4848-0x000000018CBC48B8
		private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018CBC4DF0-0x000000018CBC4F10
		private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018CBC4F10-0x000000018CBC5030
		private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion); // 0x000000018CBC48B8-0x000000018CBC4B14
		private string GetJoystickCalibrationMapKey(Rewired.Joystick joystick); // 0x000000018CBC57AC-0x000000018CBC595C
		private string GetInputBehaviorKey(Player player, int inputBehaviorId); // 0x000000018CBC562C-0x000000018CBC5724
		private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBC4CE4-0x000000018CBC4DF0
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBC5030-0x000000018CBC5208
		private string GetJoystickCalibrationMapJson(Rewired.Joystick joystick); // 0x000000018CBC5724-0x000000018CBC57AC
		private string GetInputBehaviorJson(Player player, int id); // 0x000000018CBC5594-0x000000018CBC562C
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x000000018CBC4344-0x000000018CBC4848
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x000000018CBC4B68-0x000000018CBC4CE4
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches); // 0x000000018CBC9350-0x000000018CBC9504
		private void RefreshLayoutManager(int playerId); // 0x000000018CBC7EA4-0x000000018CBC7F20
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x000000018CBC5208-0x000000018CBC5594
		private static bool TryGetString(IDataStore store, string key, out string result); // 0x000000018CBC9504-0x000000018CBC9610
	}

	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 87578
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x0264669D
		private const string logPrefix = "Rewired: "; // Metadata: 0x026466B7
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x026466C1
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x0264688C
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x026468A2
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x026468A3
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x026468A4
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x026468A5
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x026468A6
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
		public bool IsEnabled { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool LoadDataOnStart { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public bool LoadJoystickAssignments { get; set; } // 0x000000018226EDC0-0x000000018226EDD0 0x000000018226EDD0-0x000000018226EDE0
		public bool LoadKeyboardAssignments { get; set; } // 0x00000001872364A0-0x00000001872364B0 0x00000001872364D0-0x00000001872364E0
		public bool LoadMouseAssignments { get; set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
		public string PlayerPrefsKeyPrefix { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		private string playerPrefsKey_controllerAssignments { get; } // 0x000000018CBCE98C-0x000000018CBCEA48 
		private bool loadControllerAssignments { get; } // 0x000000018CBC997C-0x000000018CBC9990 
		private List<int> allActionIds { get; } // 0x000000018CBCE84C-0x000000018CBCE98C 
		private string allActionIdsString { get; } // 0x000000018CBCE734-0x000000018CBCE84C 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 87572
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x000000018564C6A0-0x000000018564C6C0 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 87570
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x0000000185384260-0x0000000185384280 
	
				// Constructors
				public PlayerInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x000000018CBBB8DC-0x000000018CBBB960
				public bool ContainsJoystick(int joystickId); // 0x000000018CBBB8C4-0x000000018CBBB8DC
			}
	
			public class JoystickInfo // TypeDefIndex: 87571
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			public ControllerAssignmentSaveInfo(int playerCount); // 0x000000018CBB73F8-0x000000018CBB74C0
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x000000018CBB72AC-0x000000018CBB7330
			public bool ContainsPlayer(int playerId); // 0x000000018CBB7294-0x000000018CBB72AC
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 87573
		{
			// Fields
			public readonly Rewired.Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Rewired.Joystick joystick, int oldJoystickId); // 0x000000018CBBAF64-0x000000018CBBAFE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0 // TypeDefIndex: 87574
		{
			// Fields
			public Rewired.Joystick joystick; // 0x10
	
			// Constructors
			public __c__DisplayClass78_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x); // 0x000000018CB3DE4C-0x000000018CB3DE6C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_1 // TypeDefIndex: 87575
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass78_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x); // 0x000000018CBC3CB0-0x000000018CBC3CD8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_2 // TypeDefIndex: 87576
		{
			// Fields
			public Rewired.Joystick match; // 0x10
	
			// Constructors
			public __c__DisplayClass78_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x); // 0x000000018CB3DE4C-0x000000018CB3DE6C
		}
	
		[CompilerGenerated]
		private sealed class _LoadJoystickAssignmentsDeferred_d__80 : IEnumerator<object> // TypeDefIndex: 87577
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UserDataStore_PlayerPrefs __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _LoadJoystickAssignmentsDeferred_d__80(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CBC3B94-0x000000018CBC3C64
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CBC3C64-0x000000018CBC3CB0
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs(); // 0x000000018CBCE6DC-0x000000018CBCE734
	
		// Methods
		public override void Save(); // 0x000000018CBCE4BC-0x000000018CBCE528
		public override void SaveControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCD910-0x000000018CBCD9AC
		public override void SaveControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCD9AC-0x000000018CBCDA34
		public override void SavePlayerData(int playerId); // 0x000000018CBCE444-0x000000018CBCE4BC
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x000000018CBCDFFC-0x000000018CBCE084
		public override void Load(); // 0x000000018CBCD120-0x000000018CBCD18C
		public override void LoadControllerData(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCB404-0x000000018CBCB4A0
		public override void LoadControllerData(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCB37C-0x000000018CBCB404
		public override void LoadPlayerData(int playerId); // 0x000000018CBCD0A8-0x000000018CBCD120
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x000000018CBCBA68-0x000000018CBCBAF0
		protected override void OnInitialize(); // 0x000000018CBCD264-0x000000018CBCD2EC
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x000000018CBCD18C-0x000000018CBCD204
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x000000018CBCD234-0x000000018CBCD264
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x000000018CBCD204-0x000000018CBCD234
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x000000018CBCDA34-0x000000018CBCDAC0
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBCB4A0-0x000000018CBCB564
		private int LoadAll(); // 0x000000018CBCB010-0x000000018CBCB114
		private int LoadPlayerDataNow(int playerId); // 0x000000018CBCCDF8-0x000000018CBCCE68
		private int LoadPlayerDataNow(Player player); // 0x000000018CBCCE68-0x000000018CBCD0A8
		private int LoadAllJoystickCalibrationData(); // 0x000000018CBCAF44-0x000000018CBCB010
		private int LoadJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018CBCC938-0x000000018CBCC970
		private int LoadJoystickCalibrationData(int joystickId); // 0x000000018CBCC970-0x000000018CBCC9E0
		private int LoadJoystickData(int joystickId); // 0x000000018CBCC9E0-0x000000018CBCCB2C
		private int LoadControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCB2EC-0x000000018CBCB35C
		private int LoadControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCB35C-0x000000018CBCB37C
		private int LoadControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCB684-0x000000018CBCB900
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBCB564-0x000000018CBCB684
		private int LoadInputBehaviors(int playerId); // 0x000000018CBCBAF0-0x000000018CBCBC18
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x000000018CBCB9A4-0x000000018CBCBA68
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018CBCB900-0x000000018CBCB9A4
		private bool LoadControllerAssignmentsNow(); // 0x000000018CBCB22C-0x000000018CBCB2EC
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018CBCCB2C-0x000000018CBCCDF8
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x000000018CBCBC74-0x000000018CBCC938
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x000000018CBCB114-0x000000018CBCB22C
		[IteratorStateMachine(typeof(_LoadJoystickAssignmentsDeferred_d__80))]
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x000000018CBCBC18-0x000000018CBCBC74
		private void SaveAll(); // 0x000000018CBCD424-0x000000018CBCD508
		private void SavePlayerDataNow(int playerId); // 0x000000018CBCE308-0x000000018CBCE380
		private void SavePlayerDataNow(Player player); // 0x000000018CBCE380-0x000000018CBCE444
		private void SaveAllJoystickCalibrationData(); // 0x000000018CBCD368-0x000000018CBCD424
		private void SaveJoystickCalibrationData(int joystickId); // 0x000000018CBCE100-0x000000018CBCE170
		private void SaveJoystickCalibrationData(Rewired.Joystick joystick); // 0x000000018CBCE170-0x000000018CBCE1E4
		private void SaveJoystickData(int joystickId); // 0x000000018CBCE1E4-0x000000018CBCE308
		private void SaveControllerDataNow(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCD8C4-0x000000018CBCD910
		private void SaveControllerDataNow(Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCD8A0-0x000000018CBCD8C4
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x000000018CBCDC6C-0x000000018CBCDDCC
		private void SaveControllerMaps(int playerId, Rewired.ControllerType controllerType, int controllerId); // 0x000000018CBCDDCC-0x000000018CBCDEE8
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x000000018CBCDAC0-0x000000018CBCDC6C
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x000000018CBCE084-0x000000018CBCE100
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x000000018CBCDF34-0x000000018CBCDFFC
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x000000018CBCDEE8-0x000000018CBCDF34
		private bool SaveControllerAssignments(); // 0x000000018CBCD508-0x000000018CBCD8A0
		private bool ControllerAssignmentSaveDataExists(); // 0x000000018CBC9E94-0x000000018CBC9EE0
		private string GetBasePlayerPrefsKey(Player player); // 0x000000018CBCA05C-0x000000018CBCA0C0
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018CBCA640-0x000000018CBCA708
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018CBCA0C0-0x000000018CBCA188
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x000000018CBCA324-0x000000018CBCA640
		private string GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick); // 0x000000018CBCAD84-0x000000018CBCAED0
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId); // 0x000000018CBCAC74-0x000000018CBCAD00
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBCA830-0x000000018CBCA8E8
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018CBCA188-0x000000018CBCA324
		private string GetJoystickCalibrationMapXml(Rewired.Joystick joystick); // 0x000000018CBCAED0-0x000000018CBCAF44
		private string GetInputBehaviorXml(Player player, int id); // 0x000000018CBCAD00-0x000000018CBCAD84
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x000000018CBC9990-0x000000018CBC9E94
		private Rewired.Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x000000018CBC9EE0-0x000000018CBCA05C
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Rewired.Joystick> matches); // 0x000000018CBCE528-0x000000018CBCE6DC
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x000000018CBCA8E8-0x000000018CBCAC74
		private void RefreshLayoutManager(int playerId); // 0x000000018CBCD2EC-0x000000018CBCD368
		private static System.Type GetControllerMapType(Rewired.ControllerType controllerType); // 0x000000018CBCA708-0x000000018CBCA830
	}
}

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 87580
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
		public int playerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233DA0-0x0000000187233DB0 0x0000000187254CD0-0x0000000187254CE0
		public int inputSourceIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723E370-0x000000018723E380 0x000000018723E3E0-0x000000018723E3F0
		public IMouseInputSource mouseSource { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C240-0x000000018723C250 0x0000000188DC4DF4-0x0000000188DC4E08
		public ITouchInputSource touchSource { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C230-0x000000018723C240 0x0000000188DC4DE0-0x0000000188DC4DF4
		public PointerEventType sourceType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233DD0-0x0000000187233DE0 0x0000000187254CE0-0x0000000187254CF0
		public int buttonIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723E950-0x000000018723E960 0x000000018723E990-0x000000018723E9A0
	
		// Constructors
		public PlayerPointerEventData(EventSystem eventSystem); // 0x000000018CBBBBAC-0x000000018CBBBBD8
	
		// Methods
		public override string ToString(); // 0x000000018CBBB960-0x000000018CBBBBAC
	}

	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem // TypeDefIndex: 87581
	{
		// Fields
		[SerializeField]
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		private bool _alwaysUpdate; // 0x50
	
		// Properties
		public bool alwaysUpdate { get; set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
	
		// Constructors
		public RewiredEventSystem(); // 0x000000018CBBC7EC-0x000000018CBBC838
	
		// Methods
		protected override void Update(); // 0x000000018CBBC6B8-0x000000018CBBC7EC
	}

	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 87586
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x026468A7
		public const int kMouseRightId = -2; // Metadata: 0x026468A8
		public const int kMouseMiddleId = -3; // Metadata: 0x026468A9
		public const int kFakeTouchesId = -4; // Metadata: 0x026468AA
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x026468AB
		private const int customButtonsMaxCount = 128; // Metadata: 0x026468B0
		private const int customButtonsLastId = -2147483392; // Metadata: 0x026468B2
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x000000018CBBF120-0x000000018CBBF18C 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x000000018CBBF18C-0x000000018CBBF194 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x000000018CBBF18C-0x000000018CBBF194 
		protected virtual bool isMouseSupported { get; } // 0x000000018CBBF194-0x000000018CBBF248 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 87582
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x000000018CBBB84C-0x000000018CBBB8C4
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x000000018CBBB5C8-0x000000018CBBB654
			public bool AnyReleasesThisFrame(); // 0x000000018CBBB654-0x000000018CBBB6E0
			public ButtonState GetButtonState(int button); // 0x000000018CBBB6E0-0x000000018CBBB7FC
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data); // 0x000000018CBBB7FC-0x000000018CBBB84C
		}
	
		public class MouseButtonEventData // TypeDefIndex: 87583
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool PressedThisFrame(); // 0x000000018CBBB5B4-0x000000018CBBB5C8
			public bool ReleasedThisFrame(); // 0x000000018AB0B2F0-0x000000018AB0B304
		}
	
		protected class ButtonState // TypeDefIndex: 87584
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public int button { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
			// Constructors
			public ButtonState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 87585
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get; } // 0x000000018CBC3DE8-0x000000018CBC3DFC 
			int ITouchInputSource.playerId { get; } // 0x000000018CBC3DE8-0x000000018CBC3DFC 
			bool IMouseInputSource.enabled { get; } // 0x000000018CBC3DB0-0x000000018CBC3DC8 
			bool IMouseInputSource.locked { get; } // 0x000000018CBC3DC8-0x000000018CBC3DE8 
			int IMouseInputSource.buttonCount { get; } // 0x000000018CBC3D98-0x000000018CBC3DB0 
			Vector2 IMouseInputSource.screenPosition { get; } // 0x000000018CBC3E3C-0x000000018CBC3E6C 
			Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x000000018CBC3DFC-0x000000018CBC3E3C 
			Vector2 IMouseInputSource.wheelDelta { get; } // 0x000000018CBC3E6C-0x000000018CBC3E84 
			bool ITouchInputSource.touchSupported { get; } // 0x000000018CBC3F00-0x000000018CBC3F18 
			int ITouchInputSource.touchCount { get; } // 0x000000018CBC3EE8-0x000000018CBC3F00 
	
			// Constructors
			public UnityInputSource(); // 0x00000001872407F0-0x0000000187240800
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button); // 0x000000018CBC3D38-0x000000018CBC3D58
			bool IMouseInputSource.GetButtonUp(int button); // 0x000000018CBC3D58-0x000000018CBC3D78
			bool IMouseInputSource.GetButton(int button); // 0x000000018CBC3D78-0x000000018CBC3D98
			Touch ITouchInputSource.GetTouch(int index); // 0x000000018CBC3E84-0x000000018CBC3EE8
			private void TryUpdate(); // 0x000000018CBC3F18-0x000000018CBC3F78
		}
	
		// Constructors
		protected RewiredPointerInputModule(); // 0x000000018CBBF01C-0x000000018CBBF120
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse); // 0x000000018CBBE378-0x000000018CBBE394
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex); // 0x000000018CBBD3DC-0x000000018CBBD574
		public void RemoveMouseInputSource(IMouseInputSource source); // 0x000000018CBBE8E4-0x000000018CBBE98C
		public void AddMouseInputSource(IMouseInputSource source); // 0x000000018CBBC838-0x000000018CBBC914
		public int GetMouseInputSourceCount(int playerId); // 0x000000018CBBD2C4-0x000000018CBBD3DC
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex); // 0x000000018CBBE0AC-0x000000018CBBE120
		public void RemoveTouchInputSource(ITouchInputSource source); // 0x000000018CBBEA3C-0x000000018CBBEAB8
		public void AddTouchInputSource(ITouchInputSource source); // 0x000000018CBBC914-0x000000018CBBC9D8
		public int GetTouchInputSourceCount(int playerId); // 0x000000018CBBE084-0x000000018CBBE0AC
		protected void ClearMouseInputSources(); // 0x000000018CBBC9D8-0x000000018CBBCA20
		protected abstract bool IsDefaultPlayer(int playerId);
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType); // 0x000000018CBBDD00-0x000000018CBBE084
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType); // 0x000000018CBBCE74-0x000000018CBBCFB4
		protected void RemovePointerData(PlayerPointerEventData data); // 0x000000018CBBE98C-0x000000018CBBEA3C
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released); // 0x000000018CBBE120-0x000000018CBBE378
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex); // 0x000000018CBBD574-0x000000018CBBDD00
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType); // 0x000000018CBBD080-0x000000018CBBD2C4
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x000000018CBBEAB8-0x000000018CBBEAF8
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent); // 0x000000018CBBE800-0x000000018CBBE8E4
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent); // 0x000000018CBBE59C-0x000000018CBBE800
		public override bool IsPointerOverGameObject(int pointerTypeId); // 0x000000018CBBE394-0x000000018CBBE59C
		protected void ClearSelection(); // 0x000000018CBBCA20-0x000000018CBBCD98
		public override string ToString(); // 0x000000018CBBEB64-0x000000018CBBF01C
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018CBBCFB4-0x000000018CBBD080
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x000000018CBBCD98-0x000000018CBBCE74
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId); // 0x000000018CBBEAF8-0x000000018CBBEB64
	}

	public enum PointerEventType // TypeDefIndex: 87587
	{
		Mouse = 0,
		Touch = 1
	}

	[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 87589
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x026468B9
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x026468C6
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x026468D1
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x026468DA
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
		public InputManager_Base RewiredInputManager { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public bool UseAllRewiredGamePlayers { get; set; } // 0x000000018226EFA0-0x000000018226EFB0 0x000000018CBC2C0C-0x000000018CBC2C28
		public bool UseRewiredSystemPlayer { get; set; } // 0x0000000187235D90-0x0000000187235DA0 0x000000018CBC2C28-0x000000018CBC2C44
		public int[] RewiredPlayerIds { get; set; } // 0x000000018CBC2750-0x000000018CBC27A0 0x000000018CBC2A78-0x000000018CBC2B04
		public bool UsePlayingPlayersOnly { get; set; } // 0x000000018236FC60-0x000000018236FC70 0x000000018236FC70-0x000000018236FC80
		public List<Rewired.Components.PlayerMouse> PlayerMice { get; set; } // 0x000000018CBC26D8-0x000000018CBC2750 0x000000018CBC29BC-0x000000018CBC2A78
		public bool MoveOneElementPerAxisPress { get; set; } // 0x0000000182271B80-0x0000000182271B90 0x0000000182271B90-0x0000000182271BA0
		public bool allowMouseInput { get; set; } // 0x0000000184F59D60-0x0000000184F59D70 0x0000000184F59D70-0x0000000184F59D80
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x0000000187254D10-0x0000000187254D20 0x0000000187254D60-0x0000000187254D70
		public bool allowTouchInput { get; set; } // 0x0000000187254D20-0x0000000187254D30 0x0000000187254D70-0x0000000187254D80
		public bool deselectIfBackgroundClicked { get; set; } // 0x0000000187254D40-0x0000000187254D50 0x0000000187254D90-0x0000000187254DA0
		private bool deselectBeforeSelecting { get; set; } // 0x0000000187254D30-0x0000000187254D40 0x0000000187254D80-0x0000000187254D90
		public bool SetActionsById { get; set; } // 0x0000000187248B20-0x0000000187248B30 0x000000018CBC2B04-0x000000018CBC2B1C
		public int HorizontalActionId { get; set; } // 0x0000000182271AF0-0x0000000182271B00 0x000000018CBC28CC-0x000000018CBC29BC
		public int VerticalActionId { get; set; } // 0x0000000187235C10-0x0000000187235C20 0x000000018CBC2C44-0x000000018CBC2D34
		public int SubmitActionId { get; set; } // 0x0000000187235BE0-0x0000000187235BF0 0x000000018CBC2B1C-0x000000018CBC2C0C
		public int CancelActionId { get; set; } // 0x0000000187235BD0-0x0000000187235BE0 0x000000018CBC27DC-0x000000018CBC28CC
		protected override bool isMouseSupported { get; } // 0x000000018CBC27A0-0x000000018CBC27DC 
		private bool isTouchAllowed { get; } // 0x0000000187254D20-0x0000000187254D30 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool allowActivationOnMobileDevice { get; set; } // 0x0000000187254D00-0x0000000187254D10 0x0000000187254D50-0x0000000187254D60
		public bool forceModuleActive { get; set; } // 0x0000000187254D00-0x0000000187254D10 0x0000000187254D50-0x0000000187254D60
		public float inputActionsPerSecond { get; set; } // 0x000000018723B6F0-0x000000018723B700 0x000000018723B730-0x000000018723B740
		public float repeatDelay { get; set; } // 0x000000018723B6D0-0x000000018723B6E0 0x000000018723B710-0x000000018723B720
		public string horizontalAxis { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CBC2DDC-0x000000018CBC2E84
		public string verticalAxis { get; set; } // 0x0000000187232C80-0x0000000187232C90 0x000000018CBC2F2C-0x000000018CBC2FD4
		public string submitButton { get; set; } // 0x0000000187236200-0x0000000187236210 0x000000018CBC2E84-0x000000018CBC2F2C
		public string cancelButton { get; set; } // 0x000000018723BB00-0x000000018723BB10 0x000000018CBC2D34-0x000000018CBC2DDC
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 87588
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting(); // 0x000000018CDC82D0-0x000000018CDC8348
			private PlayerSetting(PlayerSetting other); // 0x000000018CDC8348-0x000000018CDC8584
	
			// Methods
			public PlayerSetting Clone(); // 0x000000018CDC8270-0x000000018CDC82D0
		}
	
		// Constructors
		private RewiredStandaloneInputModule(); // 0x000000018CBC2548-0x000000018CBC26D8
	
		// Methods
		protected override void Awake(); // 0x000000018CBBF300-0x000000018CBBF3E4
		public override void UpdateModule(); // 0x000000018CBC24E0-0x000000018CBC2548
		public override bool IsModuleSupported(); // 0x00000001851A4410-0x00000001851A4420
		public override bool ShouldActivateModule(); // 0x000000018CBC20F0-0x000000018CBC2478
		public override void ActivateModule(); // 0x000000018CBBF248-0x000000018CBBF300
		public override void DeactivateModule(); // 0x000000018CBBF600-0x000000018CBBF608
		public override void Process(); // 0x000000018CBC12E8-0x000000018CBC13D8
		private bool ProcessTouchEvents(); // 0x000000018CBC0BDC-0x000000018CBC0D48
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018CBC0D48-0x000000018CBC12E8
		private bool SendSubmitEventToSelectedObject(); // 0x000000018CBC1700-0x000000018CBC1900
		private Vector2 GetRawMoveVector(); // 0x000000018CBBF974-0x000000018CBBFCCC
		private bool SendMoveEventToSelectedObject(); // 0x000000018CBC13D8-0x000000018CBC1700
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical); // 0x000000018CBBF3E4-0x000000018CBBF564
		private void ProcessMouseEvents(); // 0x000000018CBC0558-0x000000018CBC0690
		private void ProcessMouseEvent(int playerId, int pointerIndex); // 0x000000018CBC0264-0x000000018CBC0558
		private bool SendUpdateEventToSelectedObject(); // 0x000000018CBC1900-0x000000018CBC19D4
		private void ProcessMousePress(MouseButtonEventData data); // 0x000000018CBC0690-0x000000018CBC0BDC
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018CBBFCCC-0x000000018CBBFE38
		private void OnApplicationFocus(bool hasFocus); // 0x0000000187254CF0-0x0000000187254D00
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x000000018CBC2478-0x000000018CBC24E0
		protected override void OnDestroy(); // 0x000000018CBC0130-0x000000018CBC0244
		protected override bool IsDefaultPlayer(int playerId); // 0x000000018CBBFFD0-0x000000018CBC0130
		private void InitializeRewired(); // 0x000000018CBBFE38-0x000000018CBBFFD0
		private void SetupRewiredVars(); // 0x000000018CBC1D7C-0x000000018CBC20F0
		private void SetUpRewiredPlayerMice(); // 0x000000018CBC1C90-0x000000018CBC1D7C
		private void SetUpRewiredActions(); // 0x000000018CBC19D4-0x000000018CBC1C90
		private bool GetButton(Player player, int actionId); // 0x000000018CBBF7AC-0x000000018CBBF7E0
		private bool GetButtonDown(Player player, int actionId); // 0x000000018CBBF778-0x000000018CBBF7AC
		private bool GetNegativeButton(Player player, int actionId); // 0x000000018CBBF940-0x000000018CBBF974
		private bool GetNegativeButtonDown(Player player, int actionId); // 0x000000018CBBF90C-0x000000018CBBF940
		private float GetAxis(Player player, int actionId); // 0x000000018CBBF744-0x000000018CBBF778
		private void CheckEditorRecompile(); // 0x000000018CBBF564-0x000000018CBBF5C0
		private void OnEditorRecompile(); // 0x000000018CBC0244-0x000000018CBC0254
		private void ClearRewiredVars(); // 0x000000018CBBF5C0-0x000000018CBBF600
		private bool DidAnyMouseMove(); // 0x000000018CBBF608-0x000000018CBBF744
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex); // 0x000000018CBBF7E0-0x000000018CBBF90C
		private void OnRewiredInitialized(); // 0x000000018CBC0254-0x000000018CBC025C
		private void OnRewiredShutDown(); // 0x000000018CBC025C-0x000000018CBC0264
	}
}

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 87579
	{
		// Fields
		private static readonly System.Type[] _defaultTemplateTypes; // 0x00
		private static readonly System.Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static System.Type[] templateTypes { get; } // 0x000000018CBB77D4-0x000000018CBB7824 
		public static System.Type[] templateInterfaceTypes { get; } // 0x000000018CBB7784-0x000000018CBB77D4 
	
		// Constructors
		static ControllerTemplateFactory(); // 0x0000000186C7F550-0x0000000186C7F8E0
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload); // 0x000000018CBB74C0-0x000000018CBB7784
	}
}

namespace Rewired.Localization
{
	[AddComponentMenu("Rewired/Localization/Localized String Provider")]
	public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 87590
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
		protected virtual Dictionary<string, string> dictionary { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public virtual TextAsset localizedStringsFile { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018CDC824C-0x000000018CDC8270
		protected override bool initialized { get; } // 0x00000001822434B0-0x00000001822434C0 
	
		// Constructors
		public LocalizedStringProvider(); // 0x000000018CDC81CC-0x000000018CDC824C
	
		// Methods
		protected override bool Initialize(); // 0x000000018CDC7FA4-0x000000018CDC7FC0
		protected virtual bool TryLoadLocalizedStringData(); // 0x000000018CDC8040-0x000000018CDC81CC
		protected override bool TryGetLocalizedString(string key, out string result); // 0x000000018CDC7FC0-0x000000018CDC8040
	}

	public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 87591
	{
		// Fields
		[SerializeField]
		[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
		private bool _prefetch; // 0x18
	
		// Properties
		public virtual bool prefetch { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018CDC7ED0-0x000000018CDC7FA4
		protected abstract bool initialized { get; }
	
		// Constructors
		protected LocalizedStringProviderBase(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CDC7BCC-0x000000018CDC7C04
		protected virtual void OnDisable(); // 0x000000018CDC7ADC-0x000000018CDC7BCC
		protected virtual void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void TrySetLocalizedStringProvider(); // 0x000000018CDC7D1C-0x000000018CDC7ED0
		protected abstract bool Initialize();
		public virtual void Reload(); // 0x000000018CDC7C04-0x000000018CDC7CD0
		protected abstract bool TryGetLocalizedString(string key, out string result);
		bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result); // 0x000000018CDC7CD0-0x000000018CDC7D1C
	}
}

namespace Rewired.Utils
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools // TypeDefIndex: 87551
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
		[CompilerGenerated]
		private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get; set; } // 0x000000018CBB8178-0x000000018CBB81B0 0x000000018CBB82B0-0x000000018CBB8300
		public bool isEditorPaused { get; } // 0x00000001829D0800-0x00000001829D0810 
		public bool UnityInput_IsTouchPressureSupported { get; } // 0x000000018CBB8170-0x000000018CBB8178 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent {
			add; // 0x0000000187121DE0-0x0000000187121E60
			remove; // 0x000000018CBB81B0-0x000000018CBB8224
		}
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange {
			add; // 0x000000018CBB80E4-0x000000018CBB8170
			remove; // 0x000000018CBB8224-0x000000018CBB82B0
		}
	
		// Constructors
		public ExternalTools(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Destroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public object GetPlatformInitializer(); // 0x000000018783D134-0x000000018783D13C
		public string GetFocusedEditorWindowTitle(); // 0x000000018CBB7F38-0x000000018CBB7F70
		public bool IsEditorSceneViewFocused(); // 0x00000001843FFFF0-0x0000000184400000
		public bool LinuxInput_IsJoystickPreconfigured(string name); // 0x00000001843FFFF0-0x0000000184400000
		public int XboxOneInput_GetUserIdForGamepad(uint id); // 0x0000000185829EC0-0x0000000185829ED0
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId); // 0x0000000185829EC0-0x0000000185829ED0
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId); // 0x00000001843FFFF0-0x0000000184400000
		public string XboxOneInput_GetControllerType(ulong xboxControllerId); // 0x000000018CBB80AC-0x000000018CBB80E4
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId); // 0x0000000185829EC0-0x0000000185829ED0
		public void XboxOne_Gamepad_UpdatePlugin(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel); // 0x00000001843FFFF0-0x0000000184400000
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS); // 0x0000000186805BA0-0x0000000186805BB0
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids); // 0x000000018CBB7E88-0x000000018CBB7F38
		public int GetAndroidAPILevel(); // 0x0000000184E58B60-0x0000000184E58B70
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize); // 0x00000001861A0470-0x00000001861A0510
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic); // 0x000000018CBB7F70-0x000000018CBB8004
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value); // 0x000000018CBB8004-0x000000018CBB80AC
		public float UnityInput_GetTouchPressure(ref Touch touch); // 0x0000000187254CC0-0x0000000187254CD0
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch); // 0x0000000187254CB0-0x0000000187254CC0
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload); // 0x000000018CBB7E2C-0x000000018CBB7E88
		public System.Type[] GetControllerTemplateTypes(); // 0x0000000185B6F2C0-0x0000000185B6F390
		public System.Type[] GetControllerTemplateInterfaceTypes(); // 0x0000000185B6F390-0x0000000185B6F430
	}
}
