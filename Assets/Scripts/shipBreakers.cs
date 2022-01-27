using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//shipBreakers class: destroys ships
public class shipBreakers : MonoBehaviour
{
    //Shipyard so we can clear the ship's index spot
    public GameObject Shipyard;

    //deleteShip(ship Ship, string shipName, int Index): you know what this does already
    public void deleteShip(ship Ship, string shipName, int Index)
    {
        Ship.closeShipPanel();

        GameObject shipObject = GameObject.Find(shipName);
        GameObject shipButton = GameObject.Find(string.Format("[{0}]_Button", shipName));

        Destroy(shipObject);
        Destroy(shipButton);
        Shipyard.GetComponent<shipyard>().Slips[Index] = false;
    }
}
