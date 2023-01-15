using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PAGE
{
    page1,
    page2,
}



public class Page : MonoBehaviour
{
    [SerializeField] Image page;

    GameObject settingpage;


    private void Start()
    {
        page.enabled = true;
        
    }

    public void OnClickPage()
    {
        if (PAGE.page1 == 0)

            
    }
}
