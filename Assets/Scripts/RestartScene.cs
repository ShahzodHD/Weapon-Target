using UnityEngine;
using UnityEngine.SceneManagement;

class RestartScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
