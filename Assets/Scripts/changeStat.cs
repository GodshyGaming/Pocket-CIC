using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//changeStat class: driver script behind the change (x) value buttons
public class changeStat : MonoBehaviour
{
    //The ChangeStat_Panel from the UI, attached in Unity
    public GameObject ChangeStat_Panel;
    //The ChangesStat_Panel_Title from the UI, attached in Unity
    public Text ChangeStat_Panel_Title;
    //The ChangeStat_InputField from the UI, attached in Unity
    public InputField ChangeStat_InputField;
    //The name of the stat to be changed, pulled on openWindow call
    [HideInInspector]
    public string statName;
    //The ship object we're changing, passed on openWindow call
    [HideInInspector]
    public ship Ship;

    //openWindow(string statName, ship Ship): opens the stat changing window in Unity
    public void openWindow(string statName, ship Ship)
    {
        ChangeStat_Panel.SetActive(true);

        ChangeStat_Panel_Title.text = statName;
        this.statName = statName;
        this.Ship = Ship;
    }
    //closeAccept(): closes the window and applies the changes made
    public void closeAccept()
    {
        this.Ship.GetType().GetField(this.statName).SetValue(this.Ship, int.Parse(ChangeStat_InputField.text));
        ChangeStat_InputField.text = "";
        ChangeStat_Panel.SetActive(false);
    }
    //closeCancel(): closes the window and disregards changes
    public void closeCancel()
    {
        ChangeStat_InputField.text = "";
        ChangeStat_Panel.SetActive(false);
    }
}
