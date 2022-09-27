using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public SceneController Controller;
    [SerializeField] private string targetMessage;
    public Color hightlightColor = Color.cyan;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = hightlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        
        }
    


    }
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f,1.1f,1.1f);
    }
    public void OnMouseUp()
    {
        transform.localScale = Vector3.one;
       

        {

            Controller.SendMessage(targetMessage);
        
        }
    }
}   
