using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{

    public GameObject GameView;
    public Button DarkModeButton;
    public Sprite On, Off;
    public Color LightModeColor, DarkModeColor;
    public List<GameObject> MenuPages;
    private GameObject LastSelectedObj;
    public GameObject Infopanel, settingpanel;
    public List<GameObject> SubmenuPages;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DarkMode()
    {
        DarkModeButton.image.sprite = DarkModeButton.image.sprite.name == "OFF" ? On : Off;
        GameView.GetComponent<Image>().color = DarkModeButton.image.sprite.name == "OFF" ? LightModeColor : DarkModeColor;

    }

    public void InfoPage()
    {
        LastSelectedObj = CheckActiveObj();
        SubmenuPages.ForEach(x =>
        {
            x.gameObject.SetActive(false);
        });
        LastSelectedObj.SetActive(false);
        Infopanel.SetActive(true);
    }

    public void SettingPage()
    {
        LastSelectedObj = CheckActiveObj();
        SubmenuPages.ForEach(x =>
        {
            x.gameObject.SetActive(false);
        });
        LastSelectedObj.SetActive(false);
        settingpanel.SetActive(true);
    }


    public void CloseCurrentPanel(GameObject Currentpage)
    {
        Currentpage.SetActive(false);
        LastSelectedObj.SetActive(true);
    }

    private GameObject CheckActiveObj()
    {
        GameObject gb = null;
        for (int a = 0; a < MenuPages.Count; a++)
        {
            if (MenuPages[a].gameObject.activeInHierarchy)
            {
                gb = MenuPages[a];
            }
        }
        return gb;

    }
}
