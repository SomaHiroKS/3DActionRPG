using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Reflection;

public class ShortcutsControllerEditor : EditorWindow
{
	// Shift + F1
	[MenuItem("Tools/Start #F1")]
	private static void shortCutStart()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Start.unity", OpenSceneMode.Single);
	}

	// Shift + F2
	[MenuItem("Tools/Ranking #F2")]
	private static void shortCutRanking()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Ranking.unity", OpenSceneMode.Single);
	}

	// Shift + F3
	[MenuItem("Tools/Settings #F3")]
	private static void shortCutSettings()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Settings.unity", OpenSceneMode.Single);
	}

	// Shift + F4
	[MenuItem("Tools/SelectStage #F4")]
	private static void shortCutSelectStage()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/SelectStage.unity", OpenSceneMode.Single);
	}

	// Shift + F5
	[MenuItem("Tools/InputName #F5")]
	private static void shortCutInputName()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/InputName.unity", OpenSceneMode.Single);
	}

	// Shift + F6
	[MenuItem("Tools/Shop #F6")]
	private static void shortCutShop()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Shop.unity", OpenSceneMode.Single);
	}

	// Shift + F7
	[MenuItem("Tools/Stage #F7")]
	private static void shortCutStage()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Stage.unity", OpenSceneMode.Single);
	}

	// Shift + F8
	[MenuItem("Tools/Battle #F8")]
	private static void shortCutBattle()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Battle.unity", OpenSceneMode.Single);
	}

	// コンソール出力のクリア b (bだけ単押しで消える)
	[MenuItem("Tools/ClearConsoleLogs _b")]
	private static void ClearConsoleLogs()
	{
		var type = Assembly
		.GetAssembly(typeof(SceneView))
#if UNITY_2017_1_OR_NEWER
			.GetType("UnityEditor.LogEntries")
#else
			.GetType("UnityEditorInternal.LogEntries")
#endif
			;
		var method = type.GetMethod("Clear", BindingFlags.Static | BindingFlags.Public);
		method.Invoke(null, null);
	}
}
