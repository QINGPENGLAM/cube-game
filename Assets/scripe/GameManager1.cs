using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour

{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartdelay = 1f;

    public void Completelevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", 2f);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
