using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    // Start is called before the first frame update
//    public Text textPlayGame = "TextPlayGame";

    public void PlayGame()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        SceneManager.LoadScene(1);
    }

      public void Settings()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame() 
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
