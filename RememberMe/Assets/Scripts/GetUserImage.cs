using Firebase.Auth;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUserImage : MonoBehaviour
{
    public Image ProfileImage;
    public Sprite defaultSprite;
    public void getIamge(string Url)
    {
        StartCoroutine(UserProfile(Url));
    }

    IEnumerator UserProfile(string Url)
    {
        WWW image_www = new WWW(Url);
        yield return image_www;
        if (image_www.text != null)
        {
            
            Texture2D texture = new Texture2D(1, 1);
            Sprite sprite = null;
            texture.LoadImage(image_www.bytes);
            texture.Apply();
            if (texture.height == 8 && texture.width == 8)
            {
                sprite = defaultSprite;
                ProfileImage.sprite = sprite;
            }
            else
            {
                sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                ProfileImage.sprite = sprite;
            }


        }
    }

}
