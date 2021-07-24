using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDialogue : MonoBehaviour
{
    public GameObject dialogue_1;
    public GameObject dialogue_2;
    public GameObject dialogue_3;
    public GameObject dialogue_4;
    public GameObject end1Dialogue_1;
    public GameObject end1Dialogue_2;
    public GameObject end2Dialogue_1;
    public GameObject end2Dialogue_2;
    public GameObject end2Dialogue_3;
    public GameObject end2Dialogue_4;
    public GameObject end2Dialogue_5;
    public GameObject end2Dialogue_6;
    public GameObject choicePanel;
    public GameObject bossSad;
    public GameObject bossHappy;
    int count = 0;
    int end1_count = 0;
    int end2_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        bossSad.SetActive(true);
        bossHappy.SetActive(false);
        dialogue_1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(count == 0)
            {
                dialogue_1.SetActive(false);
                dialogue_2.SetActive(true);
                count++;
            }
            else if (count == 1)
            {
                dialogue_2.SetActive(false);
                dialogue_3.SetActive(true);
                count++;
            }
            else if (count == 2)
            {
                dialogue_3.SetActive(false);
                dialogue_4.SetActive(true);
                count++;
            }
            else if (count == 3)
            {
                dialogue_4.SetActive(false);
                choicePanel.SetActive(true);
                count = -1;
            }
            if (end1_count == 1)
            {
                end1Dialogue_1.SetActive(false);
                end1Dialogue_2.SetActive(true);
                end1_count++;
            }
            else if (end1_count == 2)
            {
                ChangeScene();
            }
            if (end2_count == 1)
            {
                end2Dialogue_1.SetActive(false);
                end2Dialogue_2.SetActive(true);
                end2_count++;
            }
            else if (end2_count == 2)
            {
                end2Dialogue_2.SetActive(false);
                end2Dialogue_3.SetActive(true);
                end2_count++;
            }
            else if (end2_count == 3)
            {
                end2Dialogue_3.SetActive(false);
                end2Dialogue_4.SetActive(true);
                end2_count++;
            }
            else if (end2_count == 4)
            {
                end2Dialogue_4.SetActive(false);
                end2Dialogue_5.SetActive(true);
                end2_count++;
            }
            else if (end2_count == 5)
            {
                end2Dialogue_5.SetActive(false);
                end2Dialogue_6.SetActive(true);
                end2_count++;
            }
            else if (end2_count == 6)
            {
                ChangeScene();
            }
        }
    }

    public void Ending_1()
    {
        choicePanel.SetActive(false);
        end1Dialogue_1.SetActive(true);
        end1_count++;
    }

    public void Ending_2()
    {
        bossSad.SetActive(false);
        bossHappy.SetActive(true);
        choicePanel.SetActive(false);
        end2Dialogue_1.SetActive(true);
        end2_count++;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("EndCredits");
    }
}
