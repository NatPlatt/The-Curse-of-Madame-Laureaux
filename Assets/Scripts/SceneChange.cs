using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu]
public class SceneChange : ScriptableObject
{
    private Object scene;
    public void LoadScene(Object sceneName)
    {
        var newName = sceneName.name;
        SceneManager.LoadScene(newName);
    }

    public void OnTriggerEnter()
    {
        Debug.Log("change the scene");
        LoadScene(scene);
    }
}
