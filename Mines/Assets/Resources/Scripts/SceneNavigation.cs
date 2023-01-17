using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void OpenSceneByName(string NameOfTheScene)
    {
        SceneManager.LoadScene(NameOfTheScene);
    }

    public void OpenThisSceneAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}