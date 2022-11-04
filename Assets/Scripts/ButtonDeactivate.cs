using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDeactivate : MonoBehaviour
{
    Sprite buttonImage;
    public Sprite activatedButtonImage;

    public void DeactivateButton() {
        buttonImage = GetComponent<Image>().sprite;
        buttonImage = activatedButtonImage;
    }
}
