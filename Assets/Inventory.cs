using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int chickenCount;
    public Text chickenCountText;

    public static Inventory instance;
    

    private void Awake() 
    {
        if(instance != null) 
        {
            Debug.LogWarning("Il y a plus d'une instance d'Inventory dans le scène");
            return;
        }
        instance = this;
    }

    public void AddChicken(int count) 
    {
        chickenCount += count;
        chickenCountText.text = chickenCount.ToString();

    }


}
