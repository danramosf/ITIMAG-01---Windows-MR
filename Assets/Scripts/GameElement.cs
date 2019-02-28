using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameElement : MonoBehaviour
{
    public GameApplication app { get { return GameObject.FindObjectOfType<GameApplication>(); } }
}
