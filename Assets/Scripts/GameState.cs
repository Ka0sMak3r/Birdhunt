
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameState : MonoBehaviour
{
    
    public void endgame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void restartgame()
    {
        
        {
            SceneManager.LoadScene("Arena");
        }
        

    }

}
