using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : GameElement
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        //Dispatch the notification
        app.Notify(GameNotification.MouseOverObject, this);
    }

    private void OnBecameVisible()
    {
        app.Notify(GameNotification.MouseOverObject, this);
    }

    private void OnEnable()
    {
        //Dispatch the notification
        app.Notify(GameNotification.MouseOverObject, this);
    }
}
