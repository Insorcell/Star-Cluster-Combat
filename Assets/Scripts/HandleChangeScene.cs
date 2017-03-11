using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleChangeScene : MonoBehaviour {
    public Transform mainmenuLocation;
    public Transform gameLocation;
    public Transform optionsLocation;
    public Transform creditsLocation;
    public void ChangeScene(int location)
    {
        switch (location)
        {
            case 0:
                transform.position = mainmenuLocation.position;
                break;
            case 1:
                transform.position = gameLocation.position;
                break;
            case 2:
                transform.position = optionsLocation.position;
                break;
            case 3:
                transform.position = creditsLocation.position;
                break;
            default:
                break;
        }
    }
}
