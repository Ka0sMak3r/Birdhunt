using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour

{
    public void starthunt()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Start Button to Load into the game
    }    
}
