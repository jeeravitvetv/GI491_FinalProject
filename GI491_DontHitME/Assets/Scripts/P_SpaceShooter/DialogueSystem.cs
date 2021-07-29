using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    public GameObject dialogue_1;
    public GameObject dialogue_2;
    public GameObject dialogue_3;
    public GameObject dialogue_4;
    public GameObject dialogue_5;
    public GameObject dialogue_6;
    bool endDialouge;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dialogue());
    }

    // Update is called once per frame
    void Update()
    {
        if(endDialouge == true)
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
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
        yield return new WaitForSeconds(3);
        dialogue_4.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_5.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_5.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogue_6.SetActive(true);
        yield return new WaitForSeconds(2);
        dialogue_6.SetActive(false);
        yield return new WaitForSeconds(2);
        endDialouge = true;
        yield return new WaitForSeconds(5);
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("SpaceShooter");
    }
}
