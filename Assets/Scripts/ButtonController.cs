using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject[] buttons;
    public Sprite activatedButtonImage;

    public void DeactivateButton(int i) {
        buttons[i].GetComponent<Image>().sprite = activatedButtonImage;
        buttons[i].transform.localScale *= 0.75f;
        buttons[i].GetComponent<Button>().interactable = false;
    }
}
