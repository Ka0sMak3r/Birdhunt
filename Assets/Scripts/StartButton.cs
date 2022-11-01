using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour

{
    public void starthunt()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    
}
