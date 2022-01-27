using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//shipyard class: builds de big boats
public class shipyard : MonoBehaviour
{
    //ui connections
    public InputField ShipName;
    //ui connections
    public InputField ShipSpeed;
    //ui connections
    public InputField ShipPivot;
    //ui connections
    public InputField ShipRoll;
    //shipHangar is where the ships are stored in the Unity hierarchy
    public GameObject ShipHangar;
    //ui connections
    public Button ShipButton;
    //ui connections
    public GameObject ButtonHolder;
    //ui connections
    public GameObject ShipPanel;
    //ui connections
    public GameObject ChangeStat_Panel;
    //the Slips are the spots where the buttons can go on the UI on the main menu. False means the slip is empty, true means the slip is full
    public List<bool> Slips = new List<bool> {false, false, false, false, false, false, false, false};

    //buildShip: Instantiates a new ship object
    public void buildShip()
    {
        int shipIndex = 0;
        for(int i = 0; i < 9; i++)
        {
            if(i == 8)
            {
                throw new System.Exception("No Open Slips");
            }
            if(Slips[i] == false)
            {
                shipIndex = i;
                Slips[i] = true;
                break;
            }
        }
        GameObject newShip = new GameObject("newShip");
        newShip.transform.SetParent(ShipHangar.transform);
        newShip.AddComponent<ship>();
        newShip.name = ShipName.text;
        
        ship newShip_Stats = newShip.GetComponent<ship>();
        newShip_Stats.Name = ShipName.text;
        newShip_Stats.Speed = int.Parse(ShipSpeed.text);
        newShip_Stats.Pivot = int.Parse(ShipPivot.text);
        newShip_Stats.Roll = int.Parse(ShipRoll.text);
        newShip_Stats.Index = shipIndex;
        newShip_Stats.ShipPanel = ShipPanel;
        newShip_Stats.ChangeStat_Panel = ChangeStat_Panel;


        Button newShip_Button = Instantiate(ShipButton, ButtonHolder.transform.GetChild(shipIndex));
        ButtonHolder.transform.GetChild(shipIndex).gameObject.SetActive(true);
        newShip_Button.name = string.Format("[{0}]_Button", ShipName.text);
        Text ButtonText = newShip_Button.GetComponentInChildren<Text>();
        ButtonText.text = ShipName.text;

        newShip_Button.onClick.AddListener(() => newShip_Stats.openShipPanel());

        ShipName.text = "";
        ShipSpeed.text = "";
        ShipPivot.text = "";
        ShipRoll.text = "";
    }
}
