using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController_wakeup : MonoBehaviour
{
    //Controls text element
    public Text text;

    // Every statemachine needs to be mentioned in this enum
    private enum States
    {
		wakeup_0a, wakeup_0b, wakeup_1, wakeup_2, wakeup_3, wakeup_4, wakeup_5, wakeup_6, 
		wu_door_0, wu_door_1, wu_door_2, wu_door_3, wu_door_4, wu_door_5, wu_door_6, 
		wu_cabinet_0, wu_cabinet_1, wu_cabinet_2, wu_cabinet_3, wu_cabinet_4, wu_cabinet_5, wu_cabinet_6, 
		wu_tank_0, wu_tank_1, wu_tank_2, wu_tank_3, wu_tank_4, wu_tank_5, wu_tank_6, 
		wu_mummy_0, wu_mummy_1, wu_mummy_2, wu_mummy_3, wu_mummy_4, wu_mummy_5, wu_mummy_6, 
		wu_self_0, wu_self_1, wu_self_2, wu_self_3, wu_self_4, wu_self_5, wu_self_6, 
		wu_monitor_0, wu_monitor_1, wu_monitor_2, wu_monitor_3, wu_monitor_4, wu_monitor_5, wu_monitor_6, 
		wu_sleep, wu_monitor_examine_0, wu_monitor_examine_1, wu_mummy_examine, wu_cabinet_examine, 
		wu_self_examine, wu_door_examine, wu_next
	};
    //Our statemachine declaration
    private States myState;

    // Use this for initialization
    void Start()
    {
        text = GameObject.FindObjectOfType<Text>();
        //Beginning state
        myState = States.wakeup_0a;
    }

    // Update is called once per frame
    void Update()
    {
        //We update here the states where the player is currently
		//State 0
		if (myState == States.wakeup_0a) { wakeup_0a(); }
		else if (myState == States.wakeup_0b) { wakeup_0b(); }
		else if (myState == States.wu_door_0) { wu_door_0(); } //---> State 1
        else if (myState == States.wu_cabinet_0) { wu_cabinet_0(); }
		else if (myState == States.wu_tank_0) { wu_tank_0(); }
		else if (myState == States.wu_sleep) { wu_sleep(); }
		else if (myState == States.wu_mummy_0) { wu_mummy_0(); }
		else if (myState == States.wu_self_0) { wu_self_0(); }
        else if (myState == States.wu_monitor_0) { wu_monitor_0(); }

		//State 1
		else if (myState == States.wakeup_1) { wakeup_1(); }
		else if (myState == States.wu_door_1) { wu_door_1(); }
		else if (myState == States.wu_cabinet_1) { wu_cabinet_1(); }
		else if (myState == States.wu_tank_1) { wu_tank_1(); }
		else if (myState == States.wu_mummy_1) { wu_mummy_1(); }
		else if (myState == States.wu_self_1) { wu_self_1(); }
		else if (myState == States.wu_monitor_1) { wu_monitor_1(); }
		else if (myState == States.wu_monitor_examine_0) { wu_monitor_examine_0(); } //---> State 2

		//State 2
		else if (myState == States.wakeup_2) { wakeup_2(); }
		else if (myState == States.wu_door_2) { wu_door_2(); }
		else if (myState == States.wu_cabinet_2) { wu_cabinet_2(); }
		else if (myState == States.wu_tank_2) { wu_tank_2(); }
		else if (myState == States.wu_mummy_2) { wu_mummy_2(); }
		else if (myState == States.wu_mummy_examine) { wu_mummy_examine(); } //---> State 3
		else if (myState == States.wu_self_2) { wu_self_2(); }
		else if (myState == States.wu_monitor_2) { wu_monitor_2(); }

		//State 3
		else if (myState == States.wakeup_3) { wakeup_3(); }
		else if (myState == States.wu_door_3) { wu_door_3(); }
		else if (myState == States.wu_cabinet_3) { wu_cabinet_3(); }
		else if (myState == States.wu_tank_3) { wu_tank_3(); }
		else if (myState == States.wu_mummy_3) { wu_mummy_3(); }
		else if (myState == States.wu_self_3) { wu_self_3(); }
		else if (myState == States.wu_monitor_3) { wu_monitor_3(); }
		else if (myState == States.wu_monitor_examine_1) { wu_monitor_examine_1(); } //---> State 4

		//State 4
		else if (myState == States.wakeup_4) { wakeup_4(); }
		else if (myState == States.wu_door_4) { wu_door_4(); }
		else if (myState == States.wu_cabinet_4) { wu_cabinet_4(); }
		else if (myState == States.wu_cabinet_examine) { wu_cabinet_examine(); } //---> State 5
		else if (myState == States.wu_tank_4) { wu_tank_4(); }
		else if (myState == States.wu_mummy_4) { wu_mummy_4(); }
		else if (myState == States.wu_self_4) { wu_self_4(); }
		else if (myState == States.wu_monitor_4) { wu_monitor_4(); }

		//State 5
		else if (myState == States.wakeup_5) { wakeup_5(); }
		else if (myState == States.wu_door_5) { wu_door_5(); }
		else if (myState == States.wu_cabinet_5) { wu_cabinet_5(); }
		else if (myState == States.wu_tank_5) { wu_tank_5(); }
		else if (myState == States.wu_mummy_5) { wu_mummy_5(); }
		else if (myState == States.wu_self_5) { wu_self_5(); }
		else if (myState == States.wu_self_examine) { wu_self_examine(); } //---> State 6
		else if (myState == States.wu_monitor_5) { wu_monitor_5(); }

		//State 6
		else if (myState == States.wakeup_6) { wakeup_6(); }
		else if (myState == States.wu_door_6) { wu_door_6(); }
		else if (myState == States.wu_door_examine) { wu_door_examine(); } //---> State 7
		else if (myState == States.wu_cabinet_6) { wu_cabinet_6(); }
		else if (myState == States.wu_tank_6) { wu_tank_6(); }
		else if (myState == States.wu_mummy_6) { wu_mummy_6(); }
		else if (myState == States.wu_self_6) { wu_self_6(); }
		else if (myState == States.wu_monitor_6) { wu_monitor_6(); }
		else if (myState == States.wu_next) { wu_next(); }

    }


//___________________________________________STATE_0____________________________________________________________________


    //Every state is a separate void
	void wakeup_0a()
	{
		text.text = "You are jerked awake from blissful sleep by a muffled noise which " +
			"sounds like an alarm. As you open your eyes, they’re assaulted by a bright, " +
			"flickering red light, causing you to recoil. This, in turn, makes an odd " +
			"pipe-like appendage which was covering your mouth detach and you start to " +
			"gasp for air, to no avail. You raise your arms forward and try to reach " +
			"for the hazy room in front of you. Suddenly, you hear a click and a glass " +
			"door swings open and you fall face first onto the floor, coughing and " +
			"regurgitating some thick liquid. After a short while of collecting yourself " +
			"you get up and take a better look at the room." +
			"\n\n" +
			"You find yourself in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { myState = States.wu_door_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_0; }
	}

	void wakeup_0b()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_0; }
	}

	void wu_door_0()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_cabinet_0()
	{
		text.text = "You examine the cabinet and see that there is a circular saw blade " +
			"mounted on an odd metallic framework. Giving the cabinet a few knocks " +
			"suggests that the glass is rather thick and likely couldn’t be broken with " +
			"the equipment located in the current room."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_0b; }
	}

	void wu_tank_0()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to climb back into the empty tank."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_sleep; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_0b; }
	}

	void wu_sleep()
	{
		text.text = "You look at the tank you were in more closely and start feeling " +
			"oddly homesick. You’re not sure how long you were in that tank but hot " +
			"damn does it feel inviting. You look around the room and decide that " +
			"this isn’t something you want to experience and determined, climb " +
			"back into the tank, insert the weird appendage back in your mouth " +
			"and close the glass door." +
			"\n\n" +
			"As soon as the door closes, the tank starts to fill up with familiar " +
			"liquid. You close your eyes and feel your consciousness slowly " +
			"slip away. You begin to dream once more." +
			"\n\n" +
			"Press [1] to start over.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(0); }
		
	}

	void wu_mummy_0()
	{
		text.text = "You examine the slouched figure and find that they’re not breathing. " +
			"On top of that, they’re covered in some sort of substance the like you’ve " +
			"never seen before. Judging by their clothes, they must have worked here as " +
			"a researcher of some sort."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_0b; }
	}

	void wu_self_0()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_0b; }
	}

	void wu_monitor_0()
	{
		text.text = "You stare at the computer monitor a short while. All the random " +
			"numbers and letters on it don’t ring any bell and you have a hard time " +
			"even understanding some of them. On the corner of the monitor, there " +
			"seems to be a large rectangle that says ”LOCKED” with big, bold letters."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_0b; }
	}


	//___________________________________________STATE_1____________________________________________________________________


	void wakeup_1()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_1; }
	}

	void wu_door_1()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_cabinet_1()
	{
		text.text = "You examine the cabinet and see that there is a circular saw blade " +
			"mounted on an odd metallic framework. Giving the cabinet a few knocks " +
			"suggests that the glass is rather thick and likely couldn’t be broken with " +
			"the equipment located in the current room."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_tank_1()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_mummy_1()
	{
		text.text = "You examine the slouched figure and find that they’re not breathing. " +
			"On top of that, they’re covered in some sort of substance the like you’ve " +
			"never seen before. Judging by their clothes, they must have worked here as " +
			"a researcher of some sort."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_self_1()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_1; }
	}

	void wu_monitor_1()
	{
		text.text = "You stare at the computer monitor a short while. All the random " +
			"numbers and letters on it don’t ring any bell and you have a hard time " +
			"even understanding some of them. On the corner of the monitor, there " +
			"seems to be a large rectangle that says ”LOCKED” with big, bold letters."
			+ "\n\n"
			+ "Press [1] to further examine the monitor."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_monitor_examine_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_1; }
	}

	void wu_monitor_examine_0()
	{
		text.text = "You press the rectangle on the screen, but a large lock appears on it " +
			"instead. Underneath the lock it says ”Key card required to operate”. Looks " +
			"like you need to get one."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}


	//___________________________________________STATE_2____________________________________________________________________


	void wakeup_2()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_2; }
	}

	void wu_door_2()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}

	void wu_cabinet_2()
	{
		text.text = "You examine the cabinet and see that there is a circular saw blade " +
			"mounted on an odd metallic framework. Giving the cabinet a few knocks " +
			"suggests that the glass is rather thick and likely couldn’t be broken with " +
			"the equipment located in the current room."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}

	void wu_tank_2()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}

	void wu_mummy_2()
	{
		text.text = "You examine the slouched figure and find that they’re not breathing. " +
			"On top of that, they’re covered in some sort of substance the like you’ve " +
			"never seen before. Judging by their clothes, they must have worked here as " +
			"a researcher of some sort."
			+ "\n\n"
			+ "Press [1] to go through their pockets."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_mummy_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_2; }
	}

	void wu_self_2()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}

	void wu_monitor_2()
	{
		text.text = "You stare at the computer monitor a short while. All the random " +
			"numbers and letters on it don’t ring any bell and you have a hard time " +
			"even understanding some of them. On the corner of the monitor, there " +
			"seems to be a large rectangle that says ”LOCKED” with big, bold letters."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_2; }
	}

	void wu_mummy_examine()
	{
		text.text = "You rip off some of the substance covering the person and rifle " +
			"through their personal belongings. In the coat’s pocket you find a bright " +
			"red key card."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}


	//___________________________________________STATE_3____________________________________________________________________


	void wakeup_3()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_3; }
	}

	void wu_door_3()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}

	void wu_cabinet_3()
	{
		text.text = "You examine the cabinet and see that there is a circular saw blade " +
			"mounted on an odd metallic framework. Giving the cabinet a few knocks " +
			"suggests that the glass is rather thick and likely couldn’t be broken with " +
			"the equipment located in the current room."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}

	void wu_tank_3()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}

	void wu_mummy_3()
	{
		text.text = "You decide to leave the poor victim in their peace. You feel you " +
			"already kind of stepped out of line with going through their pockets. " +
			"Everyone deserves some privacy. On top of that, you get the feeling that " +
			"if you were to approach them again, they might just get up and chase you " +
			"down. Better to just leave the fellow be."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}

	void wu_self_3()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_3; }
	}

	void wu_monitor_3()
	{
		text.text = "You stare at the computer monitor a short while. All the random " +
			"numbers and letters on it don’t ring any bell and you have a hard time " +
			"even understanding some of them. On the corner of the monitor, there " +
			"seems to be a large rectangle that says ”LOCKED” with big, bold letters."
			+ "\n\n"
			+ "Press [1] to use the key card."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_monitor_examine_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_3; }
	}

	void wu_monitor_examine_1()
	{
		text.text = "You insert the key card into a reader underneath the monitor and " +
			"see the lock open on screen. Looks like that did it. You press the large " +
			"rectangle once more and the text on it changes into ”UNLOCKED” alongside " +
			"turning bright green. The cabinet beside you beeps and the door on it " +
			"swings open."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}


	//___________________________________________STATE_4____________________________________________________________________


	void wakeup_4()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_4; }
	}

	void wu_door_4()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}

	void wu_cabinet_4()
	{
		text.text = "You examine the cabinet and see that there is a circular saw blade " +
			"mounted on an odd metallic framework. Giving the cabinet a few knocks " +
			"suggests that the glass is rather thick and likely couldn’t be broken with " +
			"the equipment located in the current room."
			+ "\n\n"
			+ "Press [1] to take the saw blade."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_cabinet_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_4; }
	}

	void wu_tank_4()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}

	void wu_mummy_4()
	{
		text.text = "You decide to leave the poor victim in their peace. You feel you " +
			"already kind of stepped out of line with going through their pockets. " +
			"Everyone deserves some privacy. On top of that, you get the feeling that " +
			"if you were to approach them again, they might just get up and chase you " +
			"down. Better to just leave the fellow be."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}

	void wu_self_4()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}

	void wu_monitor_4()
	{
		text.text = "You examine the monitor again but there isn’t really anything " +
			"interesting going on anymore. Even the computer seems to know that " +
			"judging by how there’s only one of those old screensavers with colourful " +
			"pipes forming intricate designs running on it now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_4; }
	}

	void wu_cabinet_examine()
	{
		text.text = "Lucky for you, the key card did its thing and the cabinet is now " +
			"open and the saw blade seems strangely inviting all of a sudden. Naturally, " +
			"like the kleptomaniac you are, you take it."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}


	//___________________________________________STATE_5____________________________________________________________________


	void wakeup_5()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_5; }
	}

	void wu_door_5()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}

	void wu_cabinet_5()
	{
		text.text = "The cabinet is now empty. There’s nothing to see here except that " +
			"the glass indeed is pretty thick. Good thing you didn’t decide to bash it " +
			"with your fist or else you’d be bleeding dry right now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}

	void wu_tank_5()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}

	void wu_mummy_5()
	{
		text.text = "You decide to leave the poor victim in their peace. You feel you " +
			"already kind of stepped out of line with going through their pockets. " +
			"Everyone deserves some privacy. On top of that, you get the feeling that " +
			"if you were to approach them again, they might just get up and chase you " +
			"down. Better to just leave the fellow be."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}

	void wu_self_5()
	{
		text.text = "You take a while to admire yourself. As you do, you see that you’re " +
			"missing your right hand. In its place, rather than having a stump there, " +
			"you seem to sport a mechanical adapter at the end of your arm. Fiddling " +
			"with some of the buttons doesn’t seem to do anything and you assume " +
			"something needs to be inserted into it first. Also you’re butt-naked."
			+ "\n\n"
			+ "Press [1] to insert the saw blade in your right hand."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_self_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_5; }
	}

	void wu_monitor_5()
	{
		text.text = "You examine the monitor again but there isn’t really anything " +
			"interesting going on anymore. Even the computer seems to know that " +
			"judging by how there’s only one of those old screensavers with colourful " +
			"pipes forming intricate designs running on it now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_5; }
	}

	void wu_self_examine()
	{
		text.text = "With the saw blade in your left hand, and the adapter socket in " +
			"your right, you put the two together – literally – and notice that it’s a " +
			"perfect fit, like it was made specifically for you. You press the buttons " +
			"on your arm and the blade comes alive, whirring quite menacingly. This " +
			"should help quite a bit."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}


	//___________________________________________STATE_6____________________________________________________________________


	void wakeup_6()
	{
		text.text = "You are standing in a white room that looks like an abandoned laboratory. " +
			"There is a loud siren blaring outside and judging by the red light in the " +
			"room, an alarm must have triggered for some reason." +
			"\n\n" +
			"Behind you there are two large tanks, one of which is empty. In front of " +
			"you is a door leading outside. On your left, there is a large glass " +
			"cabinet and next to it is a wall-mounted computer monitor. On your right, " +
			"there seems to be a slouched figure."
			+ "\n\n"
			+ "Press [1] to examine the door."
			+ "\n"
			+ "Press [2] to examine the cabinet."
			+ "\n"
			+ "Press [3] to examine the tanks."
			+ "\n"
			+ "Press [4] to examine the figure."
			+ "\n"
			+ "Press [5] to examine yourself."
			+ "\n"
			+ "Press [6] to examine the monitor.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wu_cabinet_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.wu_tank_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.wu_mummy_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.wu_self_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.wu_monitor_6; }
	}

	void wu_door_6()
	{
		text.text = "Examining the door reveals that it’s barred from inside the room. " +
			"Likely by an automated system of a sort. You give it a firm tug, but the " +
			"door stays put. You’re going to have to get it open some other way."
			+"\n\n"
			+ "Press [1] to use the saw blade on the door."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_door_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.wakeup_6; }
	}

	void wu_cabinet_6()
	{
		text.text = "The cabinet is now empty. There’s nothing to see here except that " +
			"the glass indeed is pretty thick. Good thing you didn’t decide to bash it " +
			"with your fist or else you’d be bleeding dry right now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}

	void wu_tank_6()
	{
		text.text = "You examine the two tanks behind you. The left tank contains an " +
			"odd-looking creature which must have been human at some point judging by " +
			"the slightly humanoid shape of… it. Sadly, whatever the poor thing has went " +
			"through has seemingly mutated it into this crude being. You’re not sure " +
			"whether it’s still alive as you get no response after tapping the glass. " +
			"The right tank is currently empty, as you just got out of it a while ago. " +
			"Presumably you’ve spent quite a while in there and you shudder to think that " +
			"you could have shared the same fate as your quiet neighbour."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}

	void wu_mummy_6()
	{
		text.text = "You decide to leave the poor victim in their peace. You feel you " +
			"already kind of stepped out of line with going through their pockets. " +
			"Everyone deserves some privacy. On top of that, you get the feeling that " +
			"if you were to approach them again, they might just get up and chase you " +
			"down. Better to just leave the fellow be."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}

	void wu_self_6()
	{
		text.text = "As you once more take a good look at yourself, you see that not " +
			"much has changed. You’re still naked, but you have a badass saw blade in " +
			"place of your right hand, which is pretty dope. Careful not to cut anything " +
			"important."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}

	void wu_monitor_6()
	{
		text.text = "You examine the monitor again but there isn’t really anything " +
			"interesting going on anymore. Even the computer seems to know that " +
			"judging by how there’s only one of those old screensavers with colourful " +
			"pipes forming intricate designs running on it now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wakeup_6; }
	}

	void wu_door_examine()
	{
		text.text = "You press the buttons in your arm and the blade starts whirring. " +
			"The bar which kept the door locked isn’t a match for you and gives in " +
			"right away as you cut through it like butter. You hear a loud clang as " +
			"the halved bar comes off and falls to the floor. On top of that, your fun " +
			"seems to be over, as the saw blade suddenly just stops, and a small cylinder " +
			"falls from underneath your hand adapter. It’s an empty battery. Without it, " +
			"your new snazzy hand is pretty much useless."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.wu_next; }
	}

	void wu_next()
	{
		text.text = "You’re positive that there are no batteries in the current room to " +
			"replace the one you had with, and decide to instead step through the now " +
			"open door into a hallway. There are many other doors here, which seem to " +
			"be slowly closing one at a time. On your left, there is some sort of " +
			"automated security robot coming towards you. You’re not going to find out " +
			"whether its intent is to hug you or kill you and decide to dive into the " +
			"next room, whatever it may contain."
			+ "\n\n"
			+ "Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(Application.loadedLevel + 1); }
	}
}