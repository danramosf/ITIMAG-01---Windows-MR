using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls the app workflow.
public class GameController : GameElement
{
    // Handles the ball hit event
    public void OnNotification(string p_event_path, Object p_target, params object[] p_data)
    {
        switch (p_event_path)
        {
            case GameNotification.MouseOverObject:
                //Do something...
                //Change and retrieve values from models, etc..
                Debug.Log("Mouse is over the object. ");

                break;

            case GameNotification.GameComplete:
                Debug.Log("Victory!!");
                break;
        }
    }
}
