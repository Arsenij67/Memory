using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{  [SerializeField] private SceneController controller;
    [SerializeField] private GameObject cardBack;

    [System.Obsolete]
    public void Restart()
    {

        Application.LoadLevel("Scene");
    
    }
    public void OnMouseDown()
    {
        if (cardBack.activeSelf  && controller.canReveal) 
        { 
            cardBack.SetActive(false);
            controller.CardRevealed(this);
                
                
                
                
        }
    }

    public void Unreveal()
    {

        cardBack.SetActive(true);
    
    }
  
    private int _id;
    public int id
    {
        get { return _id; }
    
    }
    
    public void SetCard(int id,Sprite image)
    {

        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    
    
    }
    







}
