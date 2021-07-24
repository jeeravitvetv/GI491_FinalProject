using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceDialogue : MonoBehaviour
{
    public GameObject dialogue_1;
    public GameObject dialogue_2;
    public GameObject dialogue_3;
    public GameObject dialogue_4;
    public GameObject dialogue_5;
    public GameObject dialogue_6;
    public GameObject dialogue_7;
    public GameObject dialogue_8;
    public GameObject dialogue_9;
    public GameObject preSATK_1;
    public GameObject preSATK_2;
    public GameObject preSATK_3;
    public GameObject SATK_1;
    public GameObject SATK_2;
    public GameObject SATK_3;
    public GameObject bossDialogue;
    public GameObject bossAction;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        if (gm.gameOver == false)
        {
            StartCoroutine(Dialogue());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameOver == true)
        {
            bossDialogue.SetActive(false);
            bossAction.SetActive(false);
            Destroy(this);
        }
    }

    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(2);
        dialogue_1.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_1.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_2.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_2.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_3.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_3.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_4.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_4.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_5.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_5.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_6.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_6.SetActive(false);
        preSATK_1.SetActive(true);
        yield return new WaitForSeconds(2);
        SATK_1.SetActive(true);
        yield return new WaitForSeconds(1);
        SATK_1.SetActive(false);
        yield return new WaitForSeconds(1);
        preSATK_1.SetActive(false);
        yield return new WaitForSeconds(2);
        preSATK_2.SetActive(true);
        yield return new WaitForSeconds(2);
        SATK_2.SetActive(true);
        yield return new WaitForSeconds(1);
        SATK_2.SetActive(false);
        yield return new WaitForSeconds(1);
        preSATK_2.SetActive(false);
        yield return new WaitForSeconds(2);
        preSATK_3.SetActive(true);
        yield return new WaitForSeconds(2);
        SATK_3.SetActive(true);
        yield return new WaitForSeconds(1);
        SATK_3.SetActive(false);
        yield return new WaitForSeconds(1);
        preSATK_3.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_7.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_7.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_8.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_8.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_9.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_9.SetActive(false);
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("DefeatBoss");
    }
}
