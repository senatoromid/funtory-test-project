using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPage : MonoBehaviour
{
   
    public void Close()
    {
        transform.LeanMoveLocalY(-Screen.height, .4f).setEaseInExpo().setOnComplete(OnCompelet);
    }
    void OnCompelet()
    {
        gameObject.SetActive(false);
    }
}
