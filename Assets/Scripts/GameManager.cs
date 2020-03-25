using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool koniecjuznastal = false;

    public void GameEnd()
    {
        if (koniecjuznastal == false)
        {
            koniecjuznastal = true;
            Debug.Log("no zjebales");
            Restart();
        }
    }

    public void GameWin()
    {
        Debug.Log("udalo sie");
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


