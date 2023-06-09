using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClickCount : CLickPower
{
    public int countClick;
    public TMP_Text textCount;
    public TMP_Text textCost;
    void Start()
    {
        textCount.text = "" + countClick;
        textCost.text = "" + powerCost;
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Click();
        }
    }
    public void Click()
    {
        countClick += powerClick;
        textCount.text ="" + countClick;
    }
    public void Up()
    {
        if (countClick >= powerCost)
        {
            countClick -= powerCost;
            powerClick++;
            powerCost += 5;
            textCost.text = "" + powerCost;
        }
    }
}
public class CLickPower : MonoBehaviour
{
    public int powerClick;
    public int powerCost;
}