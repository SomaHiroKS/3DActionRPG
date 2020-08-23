using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Reflection;

public class ShortcutsControllerEditor : EditorWindow
{
	// Shift + F8
	// [MenuItem("Tools/InputName #F8")]
	// private static void shortCutInputName()
	// {
	// 	EditorSceneManager.OpenScene("Assets/Scenes/InputName.unity", OpenSceneMode.Single);
	// }

	// コンソール出力のクリア b (bだけ単押しで消える)
	[MenuItem("Tools/ClearConsoleLogs _b")]
	private static void ClearConsoleLogs()
	{
		var type = Assembly
		.GetAssembly(typeof( SceneView ))
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
