using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplication : MonoBehaviour
{
    //Reference to the MVC instances
    public GameModel model;
    public GameView view;
    public GameController controller;

    // Iterates all Controllers and delegates the notification data
    // This method can easily be found because every class is “BounceElement” and has an “app” 
    // instance.
    public void Notify(string p_event_path, Object p_target, params object[] p_data)
    {
        GameController[] controller_list = GetAllControllers();
        foreach (GameController c in controller_list)
        {
            c.OnNotification(p_event_path, p_target, p_data);
        }
    }

    // Fetches all scene Controllers.
    public GameController[] GetAllControllers() {
        return this.GetComponents<GameController>();
    }

    // Init things here
    void Start() { }
}
