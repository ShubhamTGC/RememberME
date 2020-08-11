using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideComeIn : MonoBehaviour
{
    public GameObject TextObject;
    void Start()
    {
        
    }
    private void OnEnable()
    {
        StartCoroutine(Effect());
    }

   IEnumerator Effect()
    {
        float fillvalue = this.GetComponent<Image>().fillAmount;
        while(fillvalue < 1)
        {
            fillvalue += 0.2f;
            this.GetComponent<Image>().fillAmount = fillvalue;
            yield return new WaitForSeconds(0.05f);
        }
        TextObject.SetActive(true);

    }
}
