using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ship class: basic ship object everything else revolves around
public class ship : MonoBehaviour
{
    //name of ship
    public string Name;
    //ship's speed
    public int Speed;
    //ship's pivot
    public int Pivot;
    //ship's roll
    public int Roll;
    //ship's index (ui purposes)
    public int Index;
    //ui stuff attached at runtime
    [HideInInspector]
    public GameObject ShipPanel;
    //ui stuff attached at runtime
    [HideInInspector]
    public GameObject ChangeStat_Panel;
    //ui stuff attached at runtime
    [HideInInspector]
    public Text ShipPanel_Title;
    //ui stuff attached at runtime
    [HideInInspector]
    public Text ShipPanel_Speed;
    //ui stuff attached at runtime
    [HideInInspector]
    public Text ShipPanel_Pivot;
    //ui stuff attached at runtime
    [HideInInspector]
    public Text ShipPanel_Roll;
    //ui stuff attached at runtime
    [HideInInspector]
    public Button Return_Button;
    //ui stuff attached at runtime
    [HideInInspector]
    public Button Delete_Button;
    //ui stuff attached at runtime
    [HideInInspector]
    public Button Speed_Button;
    //ui stuff attached at runtime
    [HideInInspector]
    public Button Pivot_Button;
    //ui stuff attached at runtime
    [HideInInspector]
    public Button Roll_Button;

    //openShipPanel(): Opens the ship panel and attaches everything appropriately in the UI
    public void openShipPanel()
    {
        ShipPanel.SetActive(true);
        this.enabled = true;

        this.ShipPanel_Title = GameObject.Find("Ship_Panel_Title").GetComponent<Text>();
        this.ShipPanel_Speed = GameObject.Find("Speed_Value").GetComponent<Text>();
        this.ShipPanel_Pivot = GameObject.Find("Pivot_Value").GetComponent<Text>();
        this.ShipPanel_Roll = GameObject.Find("Roll_Value").GetComponent<Text>();

        this.Return_Button = GameObject.Find("Return_Button").GetComponent<Button>();
        this.Delete_Button = GameObject.Find("DeleteShip_Button").GetComponent<Button>();
        Return_Button.onClick.AddListener(() => this.closeShipPanel());
        shipBreakers shipBreaker = GameObject.Find("DeleteShip_Button").GetComponent<shipBreakers>();
        Delete_Button.onClick.AddListener(() => shipBreaker.deleteShip(this, Name, Index));

        this.Speed_Button = GameObject.Find("Speed_Button").GetComponent<Button>();
        this.Pivot_Button = GameObject.Find("Pivot_Button").GetComponent<Button>();
        this.Roll_Button = GameObject.Find("Roll_Button").GetComponent<Button>();
        changeStat changeStat_Script = ChangeStat_Panel.GetComponent<changeStat>();
        Speed_Button.onClick.AddListener(() => changeStat_Script.openWindow("Speed", this));
        Pivot_Button.onClick.AddListener(() => changeStat_Script.openWindow("Pivot", this));
        Roll_Button.onClick.AddListener(() => changeStat_Script.openWindow("Roll", this));
    }

    //Update(): keeps updating the displayed stats in case of change.
    void Update()
    {
        try
        {
        this.ShipPanel_Title.text = Name;
        this.ShipPanel_Speed.text = Speed.ToString();
        this.ShipPanel_Pivot.text = Pivot.ToString();
        this.ShipPanel_Roll.text = Roll.ToString();
        }
        //After the first runthrough starts throwing NullReferenceExceptions with no affect on program. Unknown cause, ignored.
        catch (NullReferenceException)
        {}
    }

    //loseShipPanel(): resets the ship panel to defaults and closes it.
    public void closeShipPanel()
    {
        ShipPanel_Title.text = "Ship Name";
        ShipPanel_Speed.text = "Value";
        ShipPanel_Pivot.text = "Value";
        ShipPanel_Roll.text = "Value";
        Return_Button.onClick.RemoveAllListeners();
        Delete_Button.onClick.RemoveAllListeners();
        Speed_Button.onClick.RemoveAllListeners();
        Pivot_Button.onClick.RemoveAllListeners();
        Roll_Button.onClick.RemoveAllListeners();
        ShipPanel.SetActive(false);
        this.enabled = false;
    }
}
