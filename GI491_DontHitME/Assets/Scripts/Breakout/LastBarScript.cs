using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBarScript : MonoBehaviour
{
    public GameObject dialogue_1;
    public GameObject dialogue_2;
    public GameObject dialogue_3;
    public GameObject dialogue_4;
    public GameObject dialogue_5;
    public GameObject nextToClickbox;
    public Transform vanish;
    private new AudioSource audio;
    public bool stageClear;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("ball"))
        {
            StartCoroutine(DialogueSystem());
        }
    }

    IEnumerator DialogueSystem()
    {
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
        nextToClickbox.SetActive(true);
        Destroy(this.gameObject);
        Transform newVanish = Instantiate(vanish, vanish.transform.position, vanish.transform.rotation);
        audio.Play();
    }
}
