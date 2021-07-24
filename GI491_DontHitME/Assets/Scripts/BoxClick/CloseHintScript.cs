using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHintScript : MonoBehaviour
{
    public GameObject hintDialogue;
    public GameObject closeHintButton;
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseHintSystem()
    {
        if (active == false)
        {
            hintDialogue.SetActive(false);
            closeHintButton.SetActive(false);
        }
    }
}
