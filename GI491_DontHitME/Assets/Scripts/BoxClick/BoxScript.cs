using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject boxOpened;
    public GameObject boxClosed;
    public GameObject dialogue_1;
    public GameObject dialogue_2;
    public GameObject dialogue_3;
    public GameObject dialogue_4;
    public GameObject dialogue_5;
    public GameObject dialogue_6;
    public GameObject dialogue_7;
    public GameObject dialogue_8;
    public GameObject bag_1;
    public GameObject bag_2;
    public GameObject bag_3;
    public GameObject bag_4;
    public GameObject bag_5;
    public GameObject bag_6;
    public GameObject bag_7;
    public GameObject bag_8;
    public GameObject bag_9;
    public GameObject bag_10;
    public GameObject nextToSpaceShooter;
    public Transform vanish;
    bool active = true;
    int press = 0;

    // Start is called before the first frame update
    void Start()
    {
        boxOpened.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (press == 8)
        {
            dialogue_1.SetActive(true);
        }
        else if (press == 9)
        {
            dialogue_1.SetActive(false);
        }
        else if (press == 16)
        {
            dialogue_2.SetActive(true);
        }
        else if (press == 17)
        {
            dialogue_2.SetActive(false);
        }
        else if (press == 24)
        {
            dialogue_3.SetActive(true);
        }
        else if (press == 25)
        {
            dialogue_3.SetActive(false);
        }
        else if (press == 31)
        {
            bag_1.SetActive(true);
        }
        else if (press == 32)
        {
            dialogue_4.SetActive(true);
        }
        else if (press == 33)
        {
            dialogue_4.SetActive(false);
        }
        else if (press == 39)
        {
            bag_2.SetActive(true);
        }
        else if (press == 40)
        {
            dialogue_5.SetActive(true);
        }
        else if (press == 41)
        {
            dialogue_5.SetActive(false);
        }
        else if (press == 44)
        {
            bag_3.SetActive(true);
        }
        else if (press == 47)
        {
            bag_4.SetActive(true);
        }
        else if (press == 48)
        {
            dialogue_6.SetActive(true);
        }
        else if (press == 49)
        {
            dialogue_6.SetActive(false);
        }
        else if (press == 52)
        {
            bag_5.SetActive(true);
        }
        else if (press == 55)
        {
            bag_6.SetActive(true);
        }
        else if (press == 56)
        {
            dialogue_7.SetActive(true);
        }
        else if (press == 57)
        {
            dialogue_7.SetActive(false);
        }
        else if (press == 58)
        {
            bag_7.SetActive(true);
        }
        else if (press == 60)
        {
            bag_8.SetActive(true);
        }
        else if (press == 61)
        {
            bag_9.SetActive(true);
        }
        else if (press == 63)
        {
            bag_10.SetActive(true);
        }
        else if (press == 64)
        {
            dialogue_8.SetActive(true);
        }
    }

    public void OpenAndClose()
    {
        if(active == false)
        {
            boxOpened.SetActive(false);
            active = true;
            press++;
        }
        else
        {
            boxOpened.SetActive(true);
            active = false;
            press++;
        }
        if (press == 65)
        {
            dialogue_8.SetActive(false);
            Transform newVanish = Instantiate(vanish, vanish.transform.position, vanish.transform.rotation);
            nextToSpaceShooter.SetActive(true);
        }
    }
}
