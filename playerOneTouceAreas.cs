using UnityEngine;
using System.Collections;

public class playerOneTouceAreas : MonoBehaviour {


    GameObject gameController;
    serialInput touchInput;
    bool touchAreaOne;
    bool touchAreaOneDisabled;

    // Use this for initialization
    void Start ()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        touchInput = gameController.GetComponent<serialInput>();

        touchAreaOneDisabled = false;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);

    }
	
	// Update is called once per frame
	void Update () {

        touchAreaOne = touchInput.PlayerOneTouchAreaOneIsActive;

        if (touchAreaOne == true )//&& touchAreaOneDisabled == false)
        {
            print("Player 1 Area 1 has been disabled");
            touchAreaOneDisabled = true;

            this.GetComponent<SpriteRenderer>().color= new Color(1, 0, 0);

        }



    }
}
