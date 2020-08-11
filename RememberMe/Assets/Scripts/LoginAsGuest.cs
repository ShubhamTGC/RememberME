using SimpleSQL;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginAsGuest : MonoBehaviour
{
    public SimpleSQLManager dbmanager;
    public InputField Username;
    public Button Goahead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Goahead.interactable = Username.text != null;
    }


}
