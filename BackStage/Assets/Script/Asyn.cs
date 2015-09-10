using UnityEngine;
using System.Collections;

public class Asyn : MonoBehaviour {

    void Start()
    {
        print("Starting " + Time.time);
        
        StartCoroutine(WaitAndChange(2.0F));
        print("Before WaitAndChange Finishes " + Time.time);
    }
    IEnumerator WaitAndChange(float waitTime)
    {
      
        //GetComponent<Light>().color = Color.Lerp(Color.red, Color.magenta, waitTime * Time.deltaTime);
        yield return new WaitForSeconds(waitTime);
        GetComponent<Light>().color = Color.white;


    }
}
