using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject dontHitMe;
    public GameObject dontHitMe_Light;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LightSystem());
    }

    IEnumerator LightSystem()
    {
        dontHitMe.SetActive(true);
        dontHitMe_Light.SetActive(false);
        yield return new WaitForSeconds(1);
        dontHitMe.SetActive(false);
        dontHitMe_Light.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
