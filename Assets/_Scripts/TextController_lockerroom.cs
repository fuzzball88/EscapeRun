using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController_lockerroom : MonoBehaviour
{
	//Controls text element
	public Text text;

	// Every statemachine needs to be mentioned in this enum
	private enum States
	{
		lockerroom_0, lockerroom_0b, lockerroom_1, lockerroom_2, lockerroom_3, lockerroom_4, 
		lr_backdoor_0, lr_backdoor_1, lr_backdoor_2, lr_backdoor_3, lr_backdoor_4, 
		lr_scanner_0, lr_scanner_1, lr_scanner_2, lr_scanner_3, lr_scanner_4, 
		lr_light_0, lr_light_1, lr_light_2, lr_light_3, lr_light_4, 
		lr_scientist_0, lr_scientist_1, lr_scientist_2, lr_scientist_3, lr_scientist_4, 
		lr_ceiling_0, lr_ceiling_1, lr_ceiling_2, lr_ceiling_3, lr_ceiling_4, 
		lr_lockera_0, lr_lockera_1, lr_lockera_2, lr_lockera_3, lr_lockera_4, 
		lr_lockerb_0, lr_lockerb_1, lr_lockerb_2, lr_lockerb_3, lr_lockerb_4, 
		lr_lockerc_0, lr_lockerc_1, lr_lockerc_2, lr_lockerc_3, lr_lockerc_4, 
		lr_lockerd_0, lr_lockerd_1, lr_lockerd_2, lr_lockerd_3, lr_lockerd_4, 
		 
		lr_try_panel_0, lr_try_panel_1, lr_try_panel_2, lr_try_panel_3, lr_try_panel_4, 
		lr_try_lockerd, lr_try_codes_0, lr_try_codes_0b, lr_wear_coat, lr_read_note, 
		lr_use_crowbar, lr_climb,

		lr_passed
	};
	//Our statemachine declaration
	private States myState;

	// Use this for initialization
	void Start()
	{
		text = GameObject.FindObjectOfType<Text>();
		//Beginning state
		myState = States.lockerroom_0;
	}

	// Update is called once per frame
	void Update()
	{
		print(myState);

		//We update here the states where the player is currently
		//Misc State
		if (myState == States.lr_try_codes_0) { lr_try_codes_0(); }
		else if (myState == States.lr_try_codes_0b) { lr_try_codes_0b(); }
		else if (myState == States.lr_wear_coat) { lr_wear_coat(); }
		else if (myState == States.lr_read_note) { lr_read_note(); }
		else if (myState == States.lr_try_lockerd) { lr_try_lockerd(); }
		else if (myState == States.lr_use_crowbar) { lr_use_crowbar(); }
		else if (myState == States.lr_climb) { lr_climb(); }


		//State 0
		else if (myState == States.lockerroom_0) { lockerroom_0(); }
		else if (myState == States.lockerroom_0b) { lockerroom_0b(); }
		else if (myState == States.lr_backdoor_0) { lr_backdoor_0(); }
		else if (myState == States.lr_scanner_0) { lr_scanner_0(); }
		else if (myState == States.lr_light_0) { lr_light_0(); }
		else if (myState == States.lr_scientist_0) { lr_scientist_0(); }
		else if (myState == States.lr_ceiling_0) { lr_ceiling_0(); }
		else if (myState == States.lr_try_panel_0) { lr_try_panel_0(); } //---> State 1
		else if (myState == States.lr_lockera_0) { lr_lockera_0(); }
		else if (myState == States.lr_lockerb_0) { lr_lockerb_0(); }
		else if (myState == States.lr_lockerc_0) { lr_lockerc_0(); }
		else if (myState == States.lr_lockerd_0) { lr_lockerd_0(); }

		//State 1
		else if (myState == States.lockerroom_1) { lockerroom_1(); }
		else if (myState == States.lr_backdoor_1) { lr_backdoor_1(); }
		else if (myState == States.lr_scanner_1) { lr_scanner_1(); }
		else if (myState == States.lr_light_1) { lr_light_1(); }
		else if (myState == States.lr_scientist_1) { lr_scientist_1(); }
		else if (myState == States.lr_ceiling_1) { lr_ceiling_1(); }
		else if (myState == States.lr_try_panel_1) { lr_try_panel_1(); }
		else if (myState == States.lr_lockera_1) { lr_lockera_1(); }
		else if (myState == States.lr_lockerb_1) { lr_lockerb_1(); }
		else if (myState == States.lr_lockerc_1) { lr_lockerc_1(); } //---> State 2
		else if (myState == States.lr_lockerd_1) { lr_lockerd_1(); }

		//State 2
		else if (myState == States.lockerroom_2) { lockerroom_2(); }
		else if (myState == States.lr_backdoor_2) { lr_backdoor_2(); }
		else if (myState == States.lr_scanner_2) { lr_scanner_2(); }
		else if (myState == States.lr_light_2) { lr_light_2(); }
		else if (myState == States.lr_scientist_2) { lr_scientist_2(); }
		else if (myState == States.lr_ceiling_2) { lr_ceiling_2(); }
		else if (myState == States.lr_try_panel_2) { lr_try_panel_2(); }
		else if (myState == States.lr_lockera_2) { lr_lockera_2(); }
		else if (myState == States.lr_lockerb_2) { lr_lockerb_2(); } //---> State 3
		else if (myState == States.lr_lockerc_2) { lr_lockerc_2(); }
		else if (myState == States.lr_lockerd_2) { lr_lockerd_2(); }

		//State 3
		else if (myState == States.lockerroom_3) { lockerroom_3(); }
		else if (myState == States.lr_backdoor_3) { lr_backdoor_3(); }
		else if (myState == States.lr_scanner_3) { lr_scanner_3(); }
		else if (myState == States.lr_light_3) { lr_light_3(); }
		else if (myState == States.lr_scientist_3) { lr_scientist_3(); }
		else if (myState == States.lr_ceiling_3) { lr_ceiling_3(); }
		else if (myState == States.lr_try_panel_3) { lr_try_panel_3(); }
		else if (myState == States.lr_lockera_3) { lr_lockera_3(); }
		else if (myState == States.lr_lockerb_3) { lr_lockerb_3(); }
		else if (myState == States.lr_lockerc_3) { lr_lockerc_3(); }
		else if (myState == States.lr_lockerd_3) { lr_lockerd_3(); } //---> State 4

		//State 4
		else if (myState == States.lockerroom_4) { lockerroom_4(); }
		else if (myState == States.lr_backdoor_4) { lr_backdoor_4(); }
		else if (myState == States.lr_scanner_4) { lr_scanner_4(); }
		else if (myState == States.lr_light_4) { lr_light_4(); }
		else if (myState == States.lr_scientist_4) { lr_scientist_4(); }
		else if (myState == States.lr_ceiling_4) { lr_ceiling_4(); }
		else if (myState == States.lr_try_panel_4) { lr_try_panel_4(); } //---> State 5
		else if (myState == States.lr_lockera_4) { lr_lockera_4(); }
		else if (myState == States.lr_lockerb_4) { lr_lockerb_4(); }
		else if (myState == States.lr_lockerc_4) { lr_lockerc_4(); }
		else if (myState == States.lr_lockerd_4) { lr_lockerd_4(); }

		//State 5
		else if (myState == States.lr_passed) { lr_passed(); }

	}


	//___________________________________________STATE_0____________________________________________________________________


	//Every state is a separate void
	void lockerroom_0()
	{
		text.text = "As you hastily scamper into one of the rooms from the hallway, the door behind you slowly " +
			"closes and locks up due to the raised alarm. As you catch your breath you " +
			"finally manage to take a look around the room and notice the walls are " +
			"covered in lockers, most of which are completely wrecked." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_0; }
	}

	void lockerroom_0b()
	{
		text.text = "You are in a room resembling an ordinary locker room." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_0; }
	}

	void lr_backdoor_0()
	{
		text.text = "There is no way you're getting that open, looks like the only way is to go " +
			"forward." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_0b; };
	}

	void lr_scanner_0()
	{
		text.text = "The interface on the scanner asks you to provide an employee ID card. It " +
			"seems different from the card reader in the room you woke up in. Besides, " +
			"you couldn't have known there might be another use for the card in the future." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_0b; }
	}

	void lr_light_0()
	{
		text.text = "The red light is giving the white room a nice tint. You could get used to it " +
			"provided the annoying loud alarm sound didn't accompany it." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_0b; }
	}

	void lr_scientist_0()
	{
		text.text = "As you walk closer to examine the feet sticking out of the nearby locker, you " +
			"see that there is another partially mummified scientist inside it. The " +
			"substance covering them is an odd thing indeed." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_0b; }
	}

	void lr_ceiling_0()
	{
		text.text = "The ventilation panel seems easily detachable as it's nearly rusted off. No " +
			"air is blowing out of it, which makes the room a bit stuffy." +
			"\n\n" +
			"Press [1] to reach for the panel." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_try_panel_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_0b; }
	}

	void lr_try_panel_0()
	{
		text.text = "You try to reach the panel first by stretching your " +
			"arms high up and then by jumping, to no avail. It's simply too high. However, " +
			"if you were to find a way to reach it, you might be able to make your way out " +
			"that way." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_lockera_0()
	{
		text.text = "You open the first locker. There doesn't seem to be anything of use inside. " +
			"Only a file case and some photos."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_0; }
	}

	void lr_lockerb_0()
	{
		text.text = "As you go on to open the second locker, you notice it's locked. There is even " +
			"a red light, underneath of which is a small number panel which can be used to " +
			"input a code to try and open the locker up. However, you still don't know the " +
			"code and trying to force it open could damage the things inside." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_0b; }
	}

	void lr_lockerc_0()
	{
		text.text = "You open the third locker. There isn't anything else beside a file case. " +
			"Probably not much use to you right now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_0b; }
	}

	void lr_lockerd_0()
	{
		text.text = "The fourth locker seems to be locked. There's a small number panel near the handle, " +
			"on top of which is a red light, presumably signifying the locker's current " +
			"state. On the door, there is a faint worn-out name. \"F..ema., G.\". You don't " +
			"seem to recall such a name." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_0b; }
	}

	//___________________________________________STATE_1____________________________________________________________________


	void lockerroom_1()
	{
		text.text = "You are in a room resembling an ordinary locker room." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_1; }
	}

	void lr_backdoor_1()
	{
		text.text = "There is no way you're getting that open, looks like the only way is to go " +
			"forward." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; };
	}

	void lr_scanner_1()
	{
		text.text = "The interface on the scanner asks you to provide an employee ID card. It " +
			"seems different from the card reader in the room you woke up in. Besides, " +
			"you couldn't have known there might be another use for the card in the future." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_light_1()
	{
		text.text = "The red light is giving the white room a nice tint. You could get used to it " +
			"provided the annoying loud alarm sound didn't accompany it." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_scientist_1()
	{
		text.text = "As you walk closer to examine the feet sticking out of the nearby locker, you " +
			"see that there is another partially mummified scientist inside it. The " +
			"substance covering them is an odd thing indeed." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_ceiling_1()
	{
		text.text = "The ventilation panel seems easily detachable as it's nearly rusted off. No " +
			"air is blowing out of it, which makes the room a bit stuffy." +
			"\n\n" +
			"Press [1] to reach for the panel." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_try_panel_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_1; }
	}

	void lr_try_panel_1()
	{
		text.text = "You try to reach the panel first by stretching your " +
			"arms high up and then by jumping, to no avail. It's simply too high. However, " +
			"if you were to find a way to reach it, you might be able to make your way out " +
			"that way." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_lockera_1()
	{
		text.text = "You open the first locker. There doesn't seem to be anything of use inside. " +
			"Only a file case and some photos."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_1; }
	}

	void lr_lockerb_1()
	{
		text.text = "As you go on to open the second locker, you notice it's locked. There is even " +
			"a red light, underneath of which is a small number panel which can be used to " +
			"input a code to try and open the locker up. However, you still don't know the " +
			"code and trying to force it open could damage the things inside." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_1; }
	}

	void lr_lockerc_1()
	{
		text.text = "You open the third locker. There isn't anything else beside a file case. " +
			"Examining it further you find out it's filled with several 4-digit series of letters " +
			"and numbers. This should help with at least one of the locked lockers by eliminating " +
			"a bunch of the other possibilities." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_2; }
	}

	void lr_lockerd_1()
	{
		text.text = "The fourth locker seems to be locked. There's a small number panel near the handle, " +
			"on top of which is a red light, presumably signifying the locker's current " +
			"state. On the door, there is a faint worn-out name. \"F..ema., G.\". You don't " +
			"seem to recall such a name." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_1; }
	}

	//___________________________________________STATE_2____________________________________________________________________


	void lockerroom_2()
	{
		text.text = "You are in a room resembling an ordinary locker room." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_2; }
	}

	void lr_backdoor_2()
	{
		text.text = "There is no way you're getting that open, looks like the only way is to go " +
			"forward." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; };
	}

	void lr_scanner_2()
	{
		text.text = "The interface on the scanner asks you to provide an employee ID card. It " +
			"seems different from the card reader in the room you woke up in. Besides, " +
			"you couldn't have known there might be another use for the card in the future." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; }
	}

	void lr_light_2()
	{
		text.text = "The red light is giving the white room a nice tint. You could get used to it " +
			"provided the annoying loud alarm sound didn't accompany it." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; }
	}

	void lr_scientist_2()
	{
		text.text = "As you walk closer to examine the feet sticking out of the nearby locker, you " +
			"see that there is another partially mummified scientist inside it. The " +
			"substance covering them is an odd thing indeed." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; }
	}

	void lr_ceiling_2()
	{
		text.text = "The ventilation panel seems easily detachable as it's nearly rusted off. No " +
			"air is blowing out of it, which makes the room a bit stuffy." +
			"\n\n" +
			"Press [1] to reach for the panel." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_try_panel_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_2; }
	}

	void lr_try_panel_2()
	{
		text.text = "You try to reach the panel first by stretching your " +
			"arms high up and then by jumping, to no avail. It's simply too high. However, " +
			"if you were to find a way to reach it, you might be able to make your way out " +
			"that way." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; }
	}

	void lr_lockera_2()
	{
		text.text = "You open the first locker. There doesn't seem to be anything of use inside. " +
			"Only a file case and some photos."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_2; }
	}

	void lr_lockerb_2()
	{
		text.text = "As you go on to open the second locker, you notice it's locked. There is even " +
			"a red light, underneath of which is a small number panel which can be used to " +
			"input a code to try and open the locker up. However, you still don't know the " +
			"code and trying to force it open could damage the things inside." +
			"\n\n" +
			"Press [1] to use the codes inside the file case." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lr_try_codes_0; }
		else if (Input.GetKeyDown (KeyCode.Keypad2)) { myState = States.lockerroom_2; }
	}

	void lr_lockerc_2()
	{
		text.text = "You open the third locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_2; }
	}

	void lr_lockerd_2()
	{
		text.text = "The fourth locker seems to be locked. There's a small number panel near the handle, " +
			"on top of which is a red light, presumably signifying the locker's current " +
			"state. On the door, there is a faint worn-out name. \"F..ema., G.\". You don't " +
			"seem to recall such a name." +
			"\n\n" +
			"Press [1] to use the codes inside the file case." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lr_try_codes_0b; }
		else if (Input.GetKeyDown (KeyCode.Keypad2)) { myState = States.lockerroom_2; }
	}

	void lr_try_codes_0()
	{
		text.text = "You try some of the strings of digits inside the file case on the number panel and " +
			"eventually the locker beeps and swings open. There doesn't seem to be anything else inside " +
			"besides some lab clothing. Lucky for you, you're in need of some good clothes as it was " +
			"starting to get a bit chilly." +
			"\n\n" +
			"Press [1] to take and wear the clothes.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lr_wear_coat; }
	}

	void lr_wear_coat()
	{
		text.text = "You take the clothes and put them on. As you swing the laboratory coat on yourself, " +
			"a piece of paper flutters out of its pocket and falls to the floor." +
			"\n\n" +
			"Press [1] to read the piece of paper.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lr_read_note; }
	}

	void lr_read_note()
	{
		text.text = "You pick up the piece of paper and read both sides. It contains a single 4-digit " +
			"series of numbers. Looks like it's meant to open something." +
			"\n\n" +
			"Press [1] to continue.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_3; }
	}

	void lr_try_codes_0b()
	{
		text.text = "You try every string of digits in the file case but the locker stays locked." +
			"That didn't work." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_2; }
	}


	//___________________________________________STATE_3____________________________________________________________________


	void lockerroom_3()
	{
		text.text = "You are in a room resembling an ordinary locker room." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_3; }
	}

	void lr_backdoor_3()
	{
		text.text = "There is no way you're getting that open, looks like the only way is to go " +
			"forward." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; };
	}

	void lr_scanner_3()
	{
		text.text = "The interface on the scanner asks you to provide an employee ID card. It " +
			"seems different from the card reader in the room you woke up in. Besides, " +
			"you couldn't have known there might be another use for the card in the future." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; }
	}

	void lr_light_3()
	{
		text.text = "The red light is giving the white room a nice tint. You could get used to it " +
			"provided the annoying loud alarm sound didn't accompany it." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; }
	}

	void lr_scientist_3()
	{
		text.text = "As you walk closer to examine the feet sticking out of the nearby locker, you " +
			"see that there is another partially mummified scientist inside it. The " +
			"substance covering them is an odd thing indeed." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; }
	}

	void lr_ceiling_3()
	{
		text.text = "The ventilation panel seems easily detachable as it's nearly rusted off. No " +
			"air is blowing out of it, which makes the room a bit stuffy." +
			"\n\n" +
			"Press [1] to reach for the panel." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_try_panel_3; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_3; }
	}

	void lr_try_panel_3()
	{
		text.text = "You try to reach the panel first by stretching your " +
			"arms high up and then by jumping, to no avail. It's simply too high. However, " +
			"if you were to find a way to reach it, you might be able to make your way out " +
			"that way." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; }
	}

	void lr_lockera_3()
	{
		text.text = "You open the first locker. There doesn't seem to be anything of use inside. " +
			"Only a file case and some photos."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_3; }
	}

	void lr_lockerb_3()
	{
		text.text = "You open the second locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_3; }
	}

	void lr_lockerc_3()
	{
		text.text = "You open the third locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_3; }
	}

	void lr_lockerd_3()
	{
		text.text = "The fourth locker seems to be locked. There's a small number panel near the handle, " +
			"on top of which is a red light, presumably signifying the locker's current " +
			"state. On the door, there is a faint worn-out name. \"F..ema., G.\". You don't " +
			"seem to recall such a name." +
			"\n\n" +
			"Press [1] to use the codes provided by the piece of paper." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lr_try_lockerd; }
		else if (Input.GetKeyDown (KeyCode.Keypad2)) { myState = States.lockerroom_3; }
	}

	void lr_try_lockerd()
	{
		text.text = "You input the code on the piece of paper and the locker door swings open." +
			" There's a crowbar inside. You're sure it will prove useful in the near future." +
			"\n\n" +
			"Press [1] to take the crowbar and continue.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_4; }
	}


	//___________________________________________STATE_4____________________________________________________________________


	void lockerroom_4()
	{
		text.text = "You are in a room resembling an ordinary locker room." +
			"\n\n" +
			"There is another barred door in front of you. Next to it is a scanner of " +
			"some sort. On both sides of the room, there are lockers nearly covering the " +
			"walls with them being close to each other. In total, four of them seem to be " +
			"intact. Inside one of the broken lockers there are a pair of feet sticking out. " +
			"Looking up, you can see another red, spinning light alongside a ventilation panel." +
			"\n\n" +
			"Press [1] to examine the door you came through." +
			"\n" +
			"Press [2] to examine the scanner." +
			"\n" +
			"Press [3] to examine the light." +
			"\n" +
			"Press [4] to examine the pair of feet." +
			"\n" +
			"Press [5] to examine the ventilation panel." +
			"\n" +
			"Press [6] to examine the first intact locker." +
			"\n" +
			"Press [7] to examine the second intact locker." +
			"\n" +
			"Press [8] to examine the third intact locker." +
			"\n" +
			"Press [9] to examine the fourth intact locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_backdoor_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lr_scanner_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.lr_light_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.lr_scientist_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.lr_ceiling_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.lr_lockera_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.lr_lockerb_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.lr_lockerc_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) { myState = States.lr_lockerd_4; }
	}

	void lr_backdoor_4()
	{
		text.text = "There is no way you're getting that open, looks like the only way is to go " +
			"forward." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_4; };
	}

	void lr_scanner_4()
	{
		text.text = "The interface on the scanner asks you to provide an employee ID card. It " +
			"seems different from the card reader in the room you woke up in. Besides, " +
			"you couldn't have known there might be another use for the card in the future." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_4; }
	}

	void lr_light_4()
	{
		text.text = "The red light is giving the white room a nice tint. You could get used to it " +
			"provided the annoying loud alarm sound didn't accompany it." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_4; }
	}

	void lr_scientist_4()
	{
		text.text = "As you walk closer to examine the feet sticking out of the nearby locker, you " +
			"see that there is another partially mummified scientist inside it. The " +
			"substance covering them is an odd thing indeed." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_4; }
	}

	void lr_ceiling_4()
	{
		text.text = "The ventilation panel seems easily detachable as it's nearly rusted off. No " +
			"air is blowing out of it, which makes the room a bit stuffy." +
			"\n\n" +
			"Press [1] to reach for the panel." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_try_panel_4; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_4; }
	}

	void lr_try_panel_4()
	{
		text.text = "You try to reach the panel first by stretching your " +
			"arms high up and then by jumping, to no avail. It's simply too high. However, " +
			"if you were to find a way to reach it, you might be able to make your way out " +
			"that way." +
			"\n\n" +
			"One of the broken lockers could probably be pried off the wall with some leverage. " +
			"Luckily, you already have something that could be used." +
			"\n\n" +
			"Press [1] to use the crowbar to pry a locker off the wall." +
			"\n" +
			"Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_use_crowbar; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.lockerroom_4; }
	}

	void lr_lockera_4()
	{
		text.text = "You open the first locker. There doesn't seem to be anything of use inside. " +
			"Only a file case and some photos."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lockerroom_4; }
	}

	void lr_use_crowbar()
	{
		text.text = "You stick the crowbar between a locker and the wall behind it and give it a " +
			"good few kicks. Eventually, the locker comes crashing down. Sadly, the crowbar got " +
			"horribly bent and is now unusable." +
			"\n\n" +
			"Press [1] to climb onto the locker.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_climb; }
	}

	void lr_climb()
	{
		text.text = "With the destroyed locker, you boost yourself up effectively and can finally " +
			"reach the ventilation panel, which practically falls off right as you touch it. As " +
			"soon as it does, some goo starts to ooze out of the open shaft. As you peer inside, " +
			"you see that the walls of the ventilation system is completely covered in substance " +
			"similar to the one the mummified scientist have had on them, only this is more liquid. " +
			"Staying in the room doesn't seem the best idea but the ventilation shaft doesn't look " +
			"too inviting either." +
			"\n\n" +
			"Press [1] to climb into the ventilation shaft.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.lr_passed; }
	}

	void lr_passed()
	{
		text.text = "You muster up the courage to climb into the ventilation shaft but after just a " +
			"few seconds of crawling the bottom gives in and breaks under your weight. You fall into " +
			"another hallway. As with the previous hallway, the doors here are closing one by one and " +
			"another metallic creature-bot hybrid rolls out from your left. The lockdown must have activated " +
			"these things to roam and get rid of any unknown material in the hallways. With barely any time " +
			"to think, you rush into the next room before the door closes." +
			"\n\n" +
			"Press [1] to continue.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(Application.loadedLevel + 1); }
	}

	void lr_lockerb_4()
	{
		text.text = "You open the second locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_4; }
	}

	void lr_lockerc_4()
	{
		text.text = "you open the third locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_2; }
	}

	void lr_lockerd_4()
	{
		text.text = "You open the fourth locker. It's completely empty now." +
			"\n\n" +
			"Press [1] to go back.";
		if (Input.GetKeyDown (KeyCode.Keypad1)) { myState = States.lockerroom_4; }
	}
}