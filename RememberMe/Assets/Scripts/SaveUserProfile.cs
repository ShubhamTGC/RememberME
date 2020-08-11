using SimpleSQL;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class SaveUserProfile : MonoBehaviour
{
    public SimpleSQLManager dbmanager;
    public InputField UsernameField;
    public Button SubmitBtn;
    string image_path = "abc";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SubmitBtn.interactable = UsernameField.text != null;
    }


    public void SaveUserInfo()
    {
        Debug.Log("application " + Application.persistentDataPath);
        UserProfile user_Data = dbmanager.Table<UserProfile>().FirstOrDefault();
      
        if(user_Data.Username == null)
        {
            user_Data.Username = UsernameField.text;
            user_Data.ImageUrl = image_path;
            dbmanager.Insert(user_Data);
        }
        else
        {
            user_Data.Username = UsernameField.text;
            user_Data.ImageUrl = image_path;
            dbmanager.UpdateTable(user_Data);
        }
      
    }
}
