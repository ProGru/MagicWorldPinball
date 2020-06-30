using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupBehavior : MonoBehaviour
{
    public GameObject popupText;
    public float disolveSpeed = 0.01f;
    public Color color;
    public Color colorOutline;
    public Color what;
    public bool scaleModifier = true;
    public bool colorModifier = true;
    public bool disolveModifier = true;
    
    void Update()
    {
        if (scaleModifier)
        {
            ScaleModifier();
        }
        if (colorModifier)
        {
            ColorModifier();
        }
        if (disolveModifier)
        {
            DisolveModifier();
        }

    }

    public void ScaleModifier()
    {
        if (popupText.transform.localScale.x < 0 | popupText.transform.localScale.y < 0 | popupText.transform.localScale.z < 0)
        {
            Destroy(this.gameObject);
        }
        popupText.transform.localScale -= new Vector3(disolveSpeed, disolveSpeed, disolveSpeed);
    }

    public void ColorModifier()
    {

        float r = (color.r - popupText.GetComponent<TextMeshProUGUI>().color.r) * disolveSpeed;
        float g = (color.g - popupText.GetComponent<TextMeshProUGUI>().color.g) * disolveSpeed;
        float b = (color.b - popupText.GetComponent<TextMeshProUGUI>().color.b) * disolveSpeed;
        popupText.GetComponent<TextMeshProUGUI>().color = new Color(
            popupText.GetComponent<TextMeshProUGUI>().color.r+r,
            popupText.GetComponent<TextMeshProUGUI>().color.g+g,
            popupText.GetComponent<TextMeshProUGUI>().color.b+b, popupText.GetComponent<TextMeshProUGUI>().color.a);

        /*
        float r_o = (colorOutline.r - popupText.GetComponent<TextMeshProUGUI>().outlineColor.r) * disolveSpeed;
        float g_o = (colorOutline.g - popupText.GetComponent<TextMeshProUGUI>().outlineColor.g) * disolveSpeed;
        float b_o = (colorOutline.b - popupText.GetComponent<TextMeshProUGUI>().outlineColor.b) * disolveSpeed;
        popupText.GetComponent<TextMeshProUGUI>().outlineColor = new Color(
            popupText.GetComponent<TextMeshProUGUI>().outlineColor.r + r_o,
            popupText.GetComponent<TextMeshProUGUI>().outlineColor.g + g_o,
            popupText.GetComponent<TextMeshProUGUI>().outlineColor.b + b_o, popupText.GetComponent<TextMeshProUGUI>().outlineColor.a);*/

    }

    public void DisolveModifier()
    {
        if (popupText.GetComponent<TextMeshProUGUI>().color.a <= 0)
        {
            Destroy(this.gameObject);
        }
        popupText.GetComponent<TextMeshProUGUI>().color = new Color(
            popupText.GetComponent<TextMeshProUGUI>().color.r,
            popupText.GetComponent<TextMeshProUGUI>().color.g,
            popupText.GetComponent<TextMeshProUGUI>().color.b,
            popupText.GetComponent<TextMeshProUGUI>().color.a - disolveSpeed);
    }

}
