using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIDGamepad : MonoBehaviour
{
    private GameObject boardWrapper;

    // Start is called before the first frame update
    void Start()
    {
        boardWrapper = GameObject.Find("BoardWrapper");    
    }

    // Update is called once per frame
    void Update()
    {
        // requires you to set up axes "Joy0X" - "Joy3X" and "Joy0Y" - "Joy3Y" in the Input Manger
        /*
        for (int i = 0; i < 4; i++)
        {
            if (Mathf.Abs(Input.GetAxis("Joy" + i + "X")) > 0.2 ||
                Mathf.Abs(Input.GetAxis("Joy" + i + "Y")) > 0.2)
            {
                Debug.Log(Input.GetJoystickNames()[i] + " is moved");
            }
        }
        */
        boardWrapper.transform.rotation = Quaternion.Euler(Input.GetAxis("JoyY") * 9 * -1, 0, Input.GetAxis("JoyX") * 9 * -1);
        Debug.Log("X: " + Input.GetAxis("JoyX") + ", JoyY: " + Input.GetAxis("JoyY"));
    }
}
