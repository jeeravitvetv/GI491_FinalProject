using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    public GameObject hintDialogue;
    public GameObject closeHintButton;
    bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HintSystem()
    {
        if (active == true)
        {
            hintDialogue.SetActive(true);
            closeHintButton.SetActive(true);
        }
    }
}
