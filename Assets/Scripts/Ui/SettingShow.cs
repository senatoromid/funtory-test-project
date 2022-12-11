using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingShow : MonoBehaviour
{
    public Transform box;
    public CanvasGroup back;
    private void OnEnable()
    {
        back.alpha = 0;
        back.LeanAlpha(1, .4f);
        box.localPosition = new Vector2(413, -Screen.height);
        box.LeanMoveLocalY(514, .4f).setEaseInOutExpo().delay = .05f;
    }
    public void CloseDialog()
    {
        back.LeanAlpha(0, .5f);
        box.LeanMoveLocalY(-Screen.height, .4f).setEaseInExpo().setOnComplete(OnCompelet);
    }
    void OnCompelet()
    {
        gameObject.SetActive(false);
    }
}
