#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;


public class ChangeScene : Editor
{
    [MenuItem("Open Scene/Load #1")]
    public static void OpenLoading()
    {
        OpenScene(Const.SCENE_LOAD);
    }

    [MenuItem("Open Scene/Home #2")]
    public static void OpenHome()
    {
        OpenScene(Const.SCENE_HOME);
    }

    [MenuItem("Open Scene/Game #3")]
    public static void OpenGame()
    {
        OpenScene(Const.SCENE_GAME);
    }

    [MenuItem("Open Scene/Test #4")]
    public static void OpenPhongDev()
    {
        OpenScene(Const.SCENE_TEST);
    }
    private static void OpenScene(string sceneName)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Game/Scenes/" + sceneName + ".unity");
        }
    }
}
#endif
