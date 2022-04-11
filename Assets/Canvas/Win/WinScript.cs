using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{


    [SerializeField] bool victory;
    [SerializeField] float victoryRadius = 2f;
    [SerializeField] Transform victoryCheck;
    [SerializeField] LayerMask theVictory;
    [SerializeField] GameObject gameObject;
    [SerializeField] GameObject blockVictory;

    
    public int sceneName;

    void Update()
    {
        victory = Physics2D.OverlapCircle(victoryCheck.position, victoryRadius, theVictory);

        if (victory)
        {
            
        gameObject.SetActive(true);
            Invoke("TimeScale", 3);
        }
    }

    void TimeScale ()
    {
         SceneManager.LoadScene(sceneName);
    }
    
}
