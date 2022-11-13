
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameState : MonoBehaviour
{
    
    public void endgame() //Reloads back to the start of the game after the player dies
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
