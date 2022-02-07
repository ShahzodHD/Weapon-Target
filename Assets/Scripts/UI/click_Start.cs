using UnityEngine;
using UnityEngine.SceneManagement;

public class click_Start : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScenes");
    }
}
