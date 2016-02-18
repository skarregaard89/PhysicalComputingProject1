using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class serialInput : MonoBehaviour {

    public bool PlayerOneTouchAreaOneIsActive;

    SerialPort sp = new SerialPort("COM4", 9600);

	// Use this for initialization
	void Start () {
        sp.Open();
        sp.ReadTimeout = 1;
    }
	
	// Update is called once per frame
	void Update () {

        if (sp.IsOpen)
        {
            try
            {
                detectButtonPressed(sp.ReadByte());
            }
            catch(System.Exception)
            {
                PlayerOneTouchAreaOneIsActive = false;
            }
            
        }
        

    }

    void detectButtonPressed(int touchArea)
    {

        if (touchArea == 1)
        {
            PlayerOneTouchAreaOneIsActive = true;
        } 
    }

}
