using UnityEngine.SceneManagement;

public static class SceneLoadManager
{
    public static void SceneLoad(string name)
    {
        SceneManager.LoadScene(name);
    }
}