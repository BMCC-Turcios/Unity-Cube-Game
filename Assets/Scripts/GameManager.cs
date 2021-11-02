using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private const float ENDGAMETIME = 2f;

    public void EndGame()
    {
        Invoke("Restart", ENDGAMETIME);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
