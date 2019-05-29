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
        boardWrapper.transform.rotation = Quaternion.Euler(Input.GetAxis("JoyY") * 9 * -1, 0, Input.GetAxis("JoyX") * 9 * -1);
        Debug.Log("X: " + Input.GetAxis("JoyX") + ", JoyY: " + Input.GetAxis("JoyY"));
    }
}
