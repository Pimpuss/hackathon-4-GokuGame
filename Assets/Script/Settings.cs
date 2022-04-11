using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Settings : MonoBehaviour {
    // Start is called before the first frame update
//    public Text textPlayGame = "TextPlayGame";
   
   

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

}