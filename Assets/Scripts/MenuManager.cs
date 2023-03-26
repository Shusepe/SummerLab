using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private AudioSource audioSource;

    public GameObject hotDog;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
        audioSource.Play();

        if (sceneName == "Game") 
        {
            hotDog.GetComponent<HotDog>().speed = (float)2;
        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
