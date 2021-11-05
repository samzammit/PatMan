using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadPatManGame() {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }

    public void maybeQuitGame() {
        Debug.Log("Quit is clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_STANDALONE
        Application.Quit();
#endif
    }

    public void QuitGame() {
        SceneManager.LoadSceneAsync(0);
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.buildIndex == 1) {
            GameObject.FindWithTag("QuitButton").GetComponent<Button>().onClick.AddListener(QuitGame);
        }
    }

}
