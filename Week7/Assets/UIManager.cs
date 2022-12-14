using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject 
        userID, //showing user's ID when starts
        timePanel, //time panel
        currentPickup, //current task panel with pickup info
        guidingPickup, //guiding state to pickup
        guidingDropoff, //guiding state to drop off
        currentDropoff, //current task panel with drop off info
        //dropoffDone,//Congrats on drop off
        //updateCurrent, //current task panel with box2
        //updateguiding, //guiding panel with box2
        moveLeft, //move left alert UI
        moveRight, //move right alert UI
        conveyerBelt; //move right alert UI

    [SerializeField] private GuideControllers _guideControllers;
    [SerializeField] private Greeting _greeting;
    [SerializeField] private GuideAudioManager _guideAudioManager;
    private void Start()
    {
        userIDOff();
        timePanelOff();
        guidingDropoffOff();
        currentDropoffOff();
        guidingPickupOff();
        currentPickupOff();
        conveyerBeltOff();
        moveLeftOff();
        moveRightOff();
    }

    private void Update()
    {
        if (_greeting)
        {
            userIDOn();
            timePanelOn();
        }

        if (_guideControllers._guidingfirst)
        {
            userIDOff();
            guidingPickupOn();
            currentPickupOn();
        }

        if (_guideControllers._carrying)
        {
            guidingPickupOff();
            currentPickupOff();
        }

        if (_guideAudioManager._afterPickUp)
        {
            guidingDropoffOn();
            currentDropoffOn();
        }

       
    }

    public void timePanelOn()
    {
        timePanel.SetActive(true);
    }
    public void timePanelOff()
    {
        timePanel.SetActive(false);
    }
    
    public void userIDOn()
    {
        userID.SetActive(true);
    }
    public void userIDOff()
    {
        userID.SetActive(false);
    }

    public void guidingPickupOn()
    {
        guidingPickup.SetActive(true);
    }
    public void guidingPickupOff()
    {
        guidingPickup.SetActive(false);
    }
    
    public void currentPickupOn()
    {
        currentPickup.SetActive(true);
    }
    public void currentPickupOff()
    {
        currentPickup.SetActive(false);
    }

    public void guidingDropoffOn()
    {
        guidingDropoff.SetActive(true);
    }
    public void guidingDropoffOff()
    {
        guidingDropoff.SetActive(false);
    }
    
    public void currentDropoffOn()
    {
        currentDropoff.SetActive(true);
    }
    public void currentDropoffOff()
    {
        currentDropoff.SetActive(false);
    }

    public void moveRightOn()
    {
        moveRight.SetActive(true);
    }
    public void moveRightOff()
    {
        moveRight.SetActive(false);
    }
    
    public void moveLeftOn()
    {
        moveLeft.SetActive(true);
    }
    public void moveLeftOff()
    {
        moveLeft.SetActive(false);
    }
    
    public void conveyerBeltOn()
    {
        conveyerBelt.SetActive(true);
    }
    public void conveyerBeltOff()
    {
        conveyerBelt.SetActive(false);
    }
}
