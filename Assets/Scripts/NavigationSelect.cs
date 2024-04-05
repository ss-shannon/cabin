using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Last edited by Shannon 6/04/2024

public class NavigationSelect : MonoBehaviour
{
    // Creating a selection panel reference to add in the inspector
    public GameObject selectionPanel;
    // Creating a main camera variable reference to add in the inspector
    public Camera mainCamera;
    // Creating a crosshair variable reference to add in the inspector
    public Image crosshair;
    // Creating a variable for listing way points
    public List<NavigationWaypoint> listOfWaypoints;

    // Start is called before the first frame update
    void Start()
    {
        // Turning the panel list off when the game starts
        selectionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Turns the selection panel on and off when the TAB key is pressed
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleSelectionPanel();
        }
    }

    public void ToggleSelectionPanel()
    {
        // If the Panel exists
        if (selectionPanel != null)
        {
            // Make it so the active state is toggled
            selectionPanel.SetActive(!selectionPanel.activeSelf);

            // If the toggle is now active
            if (selectionPanel.activeSelf == true)
            {
                // Turn on the cursor and turn off both camera look and the crosshair
                mainCamera.GetComponent<MouseLook>().enabled = false;
                crosshair.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            // If the toggle is not active now
            else
            {
                // Make sure camera mouse look and the crosshair are on, but not the cursor
                mainCamera.GetComponent<MouseLook>().enabled = true;
                crosshair.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    // These methods are teleporting the player to the numbered navigation waypoint and toggling the selection panel

    // Teleporting to the first waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint1()
    {
        listOfWaypoints[0].Activate();
        ToggleSelectionPanel();
    }

    // Teleporting to the second waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint2()
    {
        listOfWaypoints[1].Activate();
        ToggleSelectionPanel();
    }

    // Teleporting to the third waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint3()
    {
        listOfWaypoints[2].Activate();
        ToggleSelectionPanel();
    }

    // Teleporting to the fourth waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint4()
    {
        listOfWaypoints[3].Activate();
        ToggleSelectionPanel();
    }

    // Teleporting to the fifth waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint5()
    {
        listOfWaypoints[4].Activate();
        ToggleSelectionPanel();
    }

    // Teleporting to the sixth waypoint in the list and toggling the selection panel
    public void MoveToNavigationWaypoint6()
    {
        listOfWaypoints[5].Activate();
        ToggleSelectionPanel();
    }
}