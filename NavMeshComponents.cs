/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 109: NavMeshComponents.dll - Assembly: NavMeshComponents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59795-59803
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DefaultExecutionOrder(-102)]
[ExecuteInEditMode]
public class NavMeshPrefabInstance : MonoBehaviour // TypeDefIndex: 59796
{
	// Fields
	[SerializeField]
	private NavMeshData m_NavMesh; // 0x18
	[SerializeField]
	private bool m_FollowTransform; // 0x20
	private NavMeshDataInstance m_Instance; // 0x24
	private static readonly List<NavMeshPrefabInstance> s_TrackedInstances; // 0x00
	private Vector3 m_Position; // 0x28
	private Quaternion m_Rotation; // 0x34

	// Properties
	public NavMeshData navMeshData { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	public bool followTransform { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x000000018929C3A0-0x000000018929C3A8
	public static List<NavMeshPrefabInstance> trackedInstances { get => default; } // 0x000000018929C350-0x000000018929C3A0 

	// Constructors
	public NavMeshPrefabInstance() {} // 0x000000018426FE60-0x000000018426FE68
	static NavMeshPrefabInstance() {} // 0x000000018929C2C4-0x000000018929C350

	// Methods
	private void OnEnable() {} // 0x000000018929BF6C-0x000000018929BFA8
	private void OnDisable() {} // 0x000000018929BF48-0x000000018929BF6C
	public void UpdateInstance() {} // 0x000000018929C150-0x000000018929C174
	private void AddInstance() {} // 0x000000018929BB80-0x000000018929BCC0
	private void AddTracking() {} // 0x000000018929BCC0-0x000000018929BE54
	private void RemoveTracking() {} // 0x000000018929BFA8-0x000000018929C124
	private void SetFollowTransform(bool value) {} // 0x000000018929C124-0x000000018929C150
	private bool HasMoved() => default; // 0x000000018929BE54-0x000000018929BF48
	private static void UpdateTrackedInstances() {} // 0x000000018929C174-0x000000018929C2C4
}

