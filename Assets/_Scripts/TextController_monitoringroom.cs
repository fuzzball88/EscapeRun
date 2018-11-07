using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController_monitoringroom : MonoBehaviour
{

    //Controls text element
    public Text text;

    // Every statemachine needs to be mentioned in this enum
    private enum States
    {
        room2_0, room2_1, room2_computer1_0, room2_computer1_1,
        room2_computer2_0, room2_computer2_1, room2_computer3_0, room2_computer3_1,
        room2_door_0, room2_door_1, room2_out_1

    };
    //Our statemachine declaration
    private States myState;


    // Use this for initialization
    void Start ()
    {
        text = GameObject.FindObjectOfType<Text>();
        //Beginning state
        myState = States.room2_0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        print(myState);

        //We update here the states where the player is currently
        //State 0
        if (myState == States.room2_0) { room2_0(); }
        else if (myState == States.room2_computer1_0) { room2_computer1_0(); }
        else if (myState == States.room2_computer2_0) { room2_computer2_0(); } 
        else if (myState == States.room2_computer3_0) { room2_computer3_0(); } //---> State 1
        else if (myState == States.room2_door_0) { room2_door_0(); }


        //State 1
        if (myState == States.room2_1) { room2_1(); }
        else if (myState == States.room2_computer1_1) { room2_computer1_1(); }
        else if (myState == States.room2_computer2_1) { room2_computer2_1(); } 
        else if (myState == States.room2_computer3_1) { room2_computer3_1(); }
        else if (myState == States.room2_door_1) { room2_door_1(); }
        else if (myState == States.room2_out_1) { room2_out_1(); }//---> State 2
    }




//___________________________________________STATE_0____________________________________________________________________


    //Every state is a separate void
    void room2_0()
    {
    text.text = "You find yourself in a sterile looking room. " 
        + "It’s filled with rows of computers, some of which appear to have their screen turned on. "
        + "On the opposite side you can see another very heavy looking door. " 
        + "Quick glance around reveals you are the only person in room."
        + "\n\n"
        + "Press [1] to examine computer 1."
        + "\n"
        + "Press [2] to examine computer 2."
        + "\n"
        + "Press [3] to examine computer 3."
        + "\n"
        + "Press [4] to examine the door.";
    if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_computer1_0; }
    else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.room2_computer2_0; }
    else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.room2_computer3_0; }
    else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.room2_door_0; }
    
    }

    void room2_computer1_0()
    {
        text.text = "Excerpt from RESEARCH_LOG_AES_31\n\n"
           + "As the goo - like matter first contacts living tissue, "
           + "it immediately begins to consume the tissue. It appears to use acidic "
           + "liquid to dissolve and then consume the tissue. As tests with [REDACTED] has shown, "
           + "this action makes the subject feel burning sensation. Even few second contact with the Goo "
           + "results in very severe third degree burns. As the Goo keeps consuming its size will also continue to grow."
           + "This should be kept in mind always when conducting tests as its size is directly relative to "
           + "potential outbreak hazard.\n\n"
           + "-Dr.Allen "

            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_0; };
    }

    void room2_computer2_0()
    {
        text.text = "TO: A.SCOTT@***********.gov\n"
           + "FROM L.CAMPBELL@***********.gov\n"
           + "SUBJECT: Regarding tomorrows meeting\n\n"
           + "As you may have noticed, we are currently undergoing a change in management. "
           + "Including this facility and others around the globe. "
           + "Tomorrow we will be holding official information session about this for ALL facility staff, "
           + "ranging from janitors to junior researchers.For us however there’s apparently not much to learn. "
           + "As such the top brass has instructed us to take day off tomorrow. "
           + "Now in case you don’t read this mail before tomorrow, you are supposed to subtract our crisis code by 2 "

            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_0; };
    }

    void room2_computer3_0()
    {
        text.text = "WARNING. UNKNOWN ENTITY HAS BEEN IDENTIFIED IN C-WING\n"
			+ "ALL TOP PERSONNEL ARE TO FOLLOW CRISIS PLAN 9047(NINE - ZERO - FOUR - SEVEN)\n"
			+ "OTHER STAFF ARE TO FOLLOW CRISIS PLAN 9046(NINE - ZERO - FOUR - SIX)"
            + "\n\n"
            + "Press [1] to return.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_1; };
    }

    void room2_door_0()
    {
        text.text = "Even as you are few steps away, the door doesn’t show any signs of opening." 
            + " It’s sturdy enough to not budge when pushed. " 
            + "There appears to be a digital keypad on the left side of the door. With no idea what the keycode is," 
            + " you feel like you shouldn’t touch it.  "


            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_0; };
    }

    //___________________________________________STATE_1____________________________________________________________________

    //Every state is a separate void
    void room2_1()
    {
        text.text = "You find yourself in a sterile looking room. "
            + "It’s filled with rows of computers, some of which appear to have their screen turned on. "
            + "On the opposite side you can see another very heavy looking door. "
            + "Quick glance around reveals you are the only person in room."
            + "\n\n"
            + "Press [1] to examine computer 1."
            + "\n"
            + "Press [2] to examine computer 2."
            + "\n"
            + "Press [3] to examine computer 3."
            + "\n"
            + "Press [4] to examine the door.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_computer1_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.room2_computer2_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.room2_computer3_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.room2_door_1; }

    }

    void room2_computer1_1()
    {
        text.text = "Excerpt from RESEARCH_LOG_AES_31\n\n"
           + "As the goo - like matter first contacts living tissue, "
           + "it immediately begins to consume the tissue. It appears to use acidic "
           + "liquid to dissolve and then consume the tissue. As tests with [REDACTED] has shown, "
           + "this action makes the subject feel burning sensation. Even few second contact with the Goo "
           + "results in very severe third degree burns. As the Goo keeps consuming its size will also continue to grow."
           + "This should be kept in mind always when conducting tests as its size is directly relative to "
           + "potential outbreak hazard.\n\n"
           + "-Dr.Allen "

            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_1; };
    }

    void room2_computer2_1()
    {
        text.text = "TO: A.SCOTT@***********.gov\n"
           + "FROM L.CAMPBELL@***********.gov\n"
           + "SUBJECT: Regarding tomorrows meeting\n\n"
           + "As you may have noticed, we are currently undergoing a change in management. "
           + "Including this facility and others around the globe. "
           + "Tomorrow we will be holding official information session about this for ALL facility staff, "
           + "ranging from janitors to junior researchers.For us however there’s apparently not much to learn. "
           + "As such the top brass has instructed us to take day off tomorrow. "
           + "Now in case you don’t read this mail before tomorrow, you are supposed to subtract our crisis code by 2 "

            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_1; };
    }

    void room2_computer3_1()
    {
        text.text = "WARNING. UNKNOWN ENTITY HAS BEEN IDENTIFIED IN C-WING\n"
           + "ALL TOP PERSONNEL ARE TO FOLLOW CRISIS PLAN 9047(NINE - ZERO - FOUR - SEVEN)\n"
           + "OTHER STAFF ARE TO FOLLOW CRISIS PLAN 9046(NINE - ZERO - FOUR - SIX)"
            + "\n\n"
            + "Press [1] to return.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_1; };
    }

    void room2_door_1()
    {
        text.text = "Even as you are few steps away, the door doesn’t show any signs of opening."
            + " It’s sturdy enough to not budge when pushed. "
            + "There appears to be a digital keypad on the left side of the door."
            + "With few possible numbers in your head you decide to try your luck  "


            + "\n\n"
            + "Press [1] type 9047"
            + "\n"
            + "Press [2] type 9046"
            + "\n"
            + "Press [3] type 9045";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.room2_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.room2_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.room2_out_1; }
    }


    void room2_out_1()
    {
        text.text = "After you enter the code the keypad screen turns green. " 
            + "There is an audible mechanical noise echoing in the room as the door lock retracts. " 
            + "In front of you is another bright room. A nice difference from the already established"
			+ "norm of hallways with doors and death bots. "
            + "Feeling the need to press on you take a step into the next room.  "


            + "\n\n"
            + "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(Application.loadedLevel + 1); }
    }


}