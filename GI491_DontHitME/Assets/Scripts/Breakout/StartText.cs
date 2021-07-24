using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public Text canvasText1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableText", 3f);//invoke after 5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableText()
    {
        canvasText1.enabled = false;
    }
}
