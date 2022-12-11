using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Transform box;
    public CanvasGroup back;

    private void OnEnable()
    {
       
        back.alpha = 0;
        back.LeanAlpha(1, .4f);
        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, .4f).setEaseInOutExpo().delay = .05f;
        StartCoroutine(PauseGame());
    }
    public void CloseDialog()
    {
        back.LeanAlpha(0, .5f);
        box.LeanMoveLocalY(-Screen.height, .4f).setEaseInExpo().setOnComplete(OnCompelet);
        Time.timeScale = 1;
    }
    void OnCompelet()
    {
        gameObject.SetActive(false);
    }
    IEnumerator PauseGame()
    {
        yield return new WaitForSeconds(.5f);
        Time.timeScale = 0;
    }

}
