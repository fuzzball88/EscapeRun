using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController_kitchen : MonoBehaviour
{
    //Controls text element
    public Text text;

    // Every statemachine needs to be mentioned in this enum. 
    private enum States
    {
        kitchen_0, kitchen_drawers_0, kitchen_workarea_0, kitchen_freezer_0, unknown_device_0,previous_door_0, new_door_0,
        kitchen_1, kitchen_drawers_1, kitchen_workarea_1, kitchen_freezer_1, unknown_device_1, previous_door_1, new_door_1, unknown_device_1_0, unknown_device_1_0death,
        kitchen_2, kitchen_drawers_2, kitchen_workarea_2, kitchen_freezer_2, unknown_device_2, previous_door_2, new_door_2, kitchen_freezer_2_0,
        kitchen_3, kitchen_drawers_3, kitchen_workarea_3, kitchen_freezer_3, unknown_device_3, previous_door_3, new_door_3, kitchen_drawers_3_0,
        kitchen_4, kitchen_drawers_4, kitchen_workarea_4, kitchen_freezer_4, unknown_device_4, previous_door_4, new_door_4, kitchen_workarea_4_0,
        kitchen_5, kitchen_drawers_5, kitchen_workarea_5, kitchen_freezer_5, unknown_device_5, previous_door_5, new_door_5, kitchen_freezer_5_0,
        kitchen_6, kitchen_drawers_6, kitchen_workarea_6, kitchen_freezer_6, unknown_device_6, previous_door_6, new_door_6, unknown_device_6_0,
        kitchen_7
    };
    //Our statemachine declaration
    private States myState;

    // Use this for initialization
    void Start()
    {
        text = GameObject.FindObjectOfType<Text>();
        //Beginning state
        myState = States.kitchen_0;
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);

        //We update here the states where the player is currently
        //State 0
        if (myState == States.kitchen_0) { kitchen_0(); }
        else if (myState == States.kitchen_drawers_0) { kitchen_drawers_0(); }
        else if (myState == States.kitchen_workarea_0) { kitchen_workarea_0(); }
        else if (myState == States.kitchen_freezer_0) { kitchen_freezer_0(); }
        else if (myState == States.unknown_device_0) { unknown_device_0(); }
        else if (myState == States.previous_door_0) { previous_door_0(); }
        else if (myState == States.new_door_0) { new_door_0(); } //---> NEXT MAJOR State

        else if (myState == States.kitchen_1) { kitchen_1(); }
        else if (myState == States.kitchen_drawers_1) { kitchen_drawers_1(); }
        else if (myState == States.kitchen_workarea_1) { kitchen_workarea_1(); }
        else if (myState == States.kitchen_freezer_1) { kitchen_freezer_1(); }
        else if (myState == States.unknown_device_1) { unknown_device_1(); }
        else if (myState == States.previous_door_1) { previous_door_1(); }
        else if (myState == States.new_door_1) { new_door_1(); }
        else if (myState == States.unknown_device_1_0) { unknown_device_1_0(); }
        else if (myState == States.unknown_device_1_0death) { unknown_device_1_0death(); }

        else if (myState == States.kitchen_2) { kitchen_2(); }
        else if (myState == States.kitchen_drawers_2) { kitchen_drawers_2(); }
        else if (myState == States.kitchen_workarea_2) { kitchen_workarea_2(); }
        else if (myState == States.kitchen_freezer_2) { kitchen_freezer_2(); }
        else if (myState == States.unknown_device_2) { unknown_device_2(); }
        else if (myState == States.previous_door_2) { previous_door_2(); }
        else if (myState == States.new_door_2) { new_door_2(); }
        else if (myState == States.kitchen_freezer_2_0) { kitchen_freezer_2_0(); }

        else if (myState == States.kitchen_3) { kitchen_3(); }
        else if (myState == States.kitchen_drawers_3) { kitchen_drawers_3(); }
        else if (myState == States.kitchen_workarea_3) { kitchen_workarea_3(); }
        else if (myState == States.kitchen_freezer_3) { kitchen_freezer_3(); }
        else if (myState == States.unknown_device_3) { unknown_device_3(); }
        else if (myState == States.previous_door_3) { previous_door_3(); }
        else if (myState == States.new_door_3) { new_door_3(); }
        else if (myState == States.kitchen_drawers_3_0) { kitchen_drawers_3_0(); }

        else if (myState == States.kitchen_4) { kitchen_4(); }
        else if (myState == States.kitchen_drawers_4) { kitchen_drawers_4(); }
        else if (myState == States.kitchen_workarea_4) { kitchen_workarea_4(); }
        else if (myState == States.kitchen_freezer_4) { kitchen_freezer_4(); }
        else if (myState == States.unknown_device_4) { unknown_device_4(); }
        else if (myState == States.previous_door_4) { previous_door_4(); }
        else if (myState == States.new_door_4) { new_door_4(); }
        else if (myState == States.kitchen_workarea_4_0) { kitchen_workarea_4_0(); }

        else if (myState == States.kitchen_5) { kitchen_5(); }
        else if (myState == States.kitchen_drawers_5) { kitchen_drawers_5(); }
        else if (myState == States.kitchen_workarea_5) { kitchen_workarea_5(); }
        else if (myState == States.kitchen_freezer_5) { kitchen_freezer_5(); }
        else if (myState == States.unknown_device_5) { unknown_device_5(); }
        else if (myState == States.previous_door_5) { previous_door_5(); }
        else if (myState == States.new_door_5) { new_door_5(); }
        else if (myState == States.kitchen_freezer_5_0) { kitchen_freezer_5_0(); }

		else if (myState == States.kitchen_6) { kitchen_6(); }
		else if (myState == States.kitchen_drawers_6) { kitchen_drawers_6(); }
		else if (myState == States.kitchen_workarea_6) { kitchen_workarea_6(); }
		else if (myState == States.kitchen_freezer_6) { kitchen_freezer_6(); }
		else if (myState == States.unknown_device_6) { unknown_device_6(); }
		else if (myState == States.unknown_device_6_0) { unknown_device_6_0(); }
		else if (myState == States.previous_door_6) { previous_door_6(); }
		else if (myState == States.new_door_6) { new_door_6(); }

		else if (myState == States.kitchen_7) { kitchen_7(); }




    }


    //___________________________________________STATE_0____________________________________________________________________


    //Every state is a separate method
    void kitchen_0()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove. "
            + "At the other side of the room there is a table set."
            + "\n"
            + "You can hear the creature moving behind the door where you just entered the room. On the other side of the room there is a new door."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "You don't feel hungry and just want to escape. Seems the you are receiving some kind of drawback "
            + "because of the wake up. Nauseous feeling starts to spread around you gut."
            + "\n\n"
            + "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_0; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_0; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_0; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_0; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_0; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_0; }
    }

    void kitchen_drawers_0()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_0; }

    }

    void kitchen_workarea_0()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "There is nothing you can do here now."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_0; }

    }

    void kitchen_freezer_0()
    {
        text.text = "You can see that something has moved around the freezer."
            + "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "Disgusting feeling rolls in your gut and you close the freezer lid"
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_0; }

    }

    void unknown_device_0()
    {
        text.text = "You investigate the device in the middle of the room. There are many dust trails around the device."
            + "It seems off from the rest of the room and you cannot recognise it from anything."
            + "All the materials seem familiar but construct is something you haven't ever seen."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "There is nothing you can do with the device at the moment."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_0; }

    }

    void previous_door_0()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_0; }

    }

    void new_door_0()
    {
        text.text = "You approach new door and slowly begin open it to take bit peek out."
            + "There is hunky metallic creature just behind the door."
            + "It doesn't notice you or move but cannot risk it by trying to flee pass it."
            + "\n\n"
            + "You notice that it has tube kind of part extending its body that has same kind of adapter piece as in your hand. "
            + "If you could lure it somewhere or fight it you might be able to escape this place."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }


    // Section 2--------------------------------------------------------------------------------------------------------------------------------------

    void kitchen_1()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You need to figure out how to lure it away or defend yourself."
			+ "\n\n"
            + "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_1; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_1; }
    }

    void kitchen_drawers_1()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }

    void kitchen_workarea_1()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "There is nothing you can do here now."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }

    void kitchen_freezer_1()
    {
        text.text = "You can see that something has moved around the freezer."
            + "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "Disgusting feeling rolls in your gut and you close the freezer lid"
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }

    void unknown_device_1()
    {
        text.text = "You investigate the device in the middle of the room. There are many dust trails around the device."
            + "It seems off from the rest of the room and you cannot recognise it from anything."
            + "All the materials seem familiar but construct is something you haven't ever seen."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "Its Possible that the signs of movement are done by the creatures around this machine."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to Investigate the device more carefully.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }
        else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.unknown_device_1_0; }

    }

    void unknown_device_1_0()
    {
        text.text = "You take a moment and investigate the device more carefully."
            + "You figure out that the device is somehow related to the tech on you lost hand "
            + "as you can fit you stump to a jack. Container is empty and nothing happens when you do this."
            + "\n\n"
            + "Size of the cylinder is made so that adult human body fits into it. You have eerie feeling that this device might be some kind of body processing device."
            + "\n\n"
            + "You think throwing a body into it might be the only way to activate the device."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to jump into the cylinder.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }
        else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.unknown_device_1_0death; }

    }

    void unknown_device_1_0death()
    {
        text.text = "You make a brave jump into the devices cylinder and lay in it."
            + "You hear device activating and cylinder lid rolls closed"
            + "Bottom of the cylinder opens up and a splinter grinder appears from it."
            + "\n\n"
            + "Your body is grinded and melted into a green goo and the creature behind the door comes and sucks your body goo."
            + "\n\n"
            + "You are DEAD! How do you like that? Not smart to jump into unknown things!"
            + "\n\n"
            + "Press [1] to Try the level again.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }
        void previous_door_1()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }

    void new_door_1()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it before you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_1; }

    }

    // SECTION 3 ----------------------------------------------------------------------------------------------------------------------------------------------
    void kitchen_2()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You could try activating the unknown device by inserting a body into it."
			+ "\n\n"
            + "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_2; }
    }

    void kitchen_drawers_2()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }

    }

    void kitchen_workarea_2()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "There is nothing you can do here now."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }

    }

    void kitchen_freezer_2()
    {
        text.text = "You can see that something has moved around the freezer."
            + "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "You would need one of these bodies to be inserted into the unknown device."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to try picking up a body.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_freezer_2_0; }

    }

    void kitchen_freezer_2_0()
    {
        text.text = "You grab the body on top and start pulling it out. Corpses arm is tangled with another corpses limb and you don't have the strength to pull it out."
            + "\n\n"
            + "If you could just release that arm you could maybe pull this corpse out."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }


    }

    void unknown_device_2()
    {
        text.text = "You have investigated the device in the middle of the room. There are many dust trails around the device."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "You believe the device activates when it's cylinder has body in it. You won't jump in yourself as you believe the device processes human tissue into something."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }

    }


    void previous_door_2()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }

    }

    void new_door_2()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it unless you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_2; }

    }

    //Section 3-------------------------------------------------------------------------------------

    void kitchen_3()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You could try activating the unknown device by inserting a body into it."
            + "You have checked the freezer for corpses. You could lift up the top one out, if it's arm would not be so frozen and tangled with other corpses."
			+ "\n\n"
            + "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_3; }
    }

    void kitchen_drawers_3()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to grab a kettle.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_drawers_3_0; }

    }

    void kitchen_drawers_3_0()
    {
        text.text = "You grab a biggest kettle you find."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }

    void kitchen_workarea_3()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "Maybe you could heat up here something?"
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }

    }

    void kitchen_freezer_3()
    {
        text.text = "Something has moved around the freezer."
            + "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "You need one of these bodies to be inserted into the unknown device."
            + "The body on the top looks that it could be lift up if it's arm would't be frozen and tangled with other corpses."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }

    }


    void unknown_device_3()
    {
        text.text = "You have investigated the device in the middle of the room. There are many dust trails around the device."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "You believe the device activates when it's cylinder has body in it. You won't jump in yourself as you believe the device processes human tissue into something."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }

    }


    void previous_door_3()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }

    }

    void new_door_3()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it unless you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_3; }

    }

    //SECTION 4----------------------------------------------------------------------------------------------------------------------------

    void kitchen_4()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You could try activating the unknown device by inserting a body into it."
            + "You have checked the freezer for corpses. You could lift up the top one out, if it's arm would not be so frozen and tangled with other corpses."
            + "You are holding a large kettle."
			+ "\n\n"
            + "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_4; }
    }

    void kitchen_drawers_4()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "Earlier you found a kettle from here and it's the biggest one."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }


    void kitchen_workarea_4()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "Maybe you could heat up here some water with the big kettle you are holding?"
            + "\n\n"
            + "Press [1] to return.\n" 
            + "Press [2] to boil lots of water.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_4_0; }

    }

    void kitchen_workarea_4_0()
    {
        text.text = "You fill the kettle with water and put it on the stove."
            + "After few minutes the water starts to boil."
            + "\n\n"
            + "You have now lots of hot water!"
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }

    void kitchen_freezer_4()
    {
        text.text = "Something has moved around the freezer."
            + "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "You need one of these bodies to be inserted into the unknown device."
            + "The body on the top looks that it could be lift up if it's arm would't be frozen and tangled with other corpses."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }


    void unknown_device_4()
    {
        text.text = "You have investigated the device in the middle of the room. There are many dust trails around the device."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "You believe the device activates when it's cylinder has body in it. You won't jump in yourself as you believe the device processes human tissue into something."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }


    void previous_door_4()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }

    void new_door_4()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it unless you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_4; }

    }

    //Section 5----------------------------------------------------------------------------------------------------

    void kitchen_5()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You could try activating the unknown device by inserting a body into it."
            + "You have checked the freezer for corpses. You could lift up the top one out, if it's arm would not be so frozen and tangled with other corpses."
            + "You are holding a large kettle thats full of hot water."
			+ "\n\n"
			+ "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_5; }
    }

    void kitchen_drawers_5()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }


    void kitchen_workarea_5()
    {
        text.text = "Work are is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "The water you are carrying is still hot as possible so you don't need to do here anything."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }


    void kitchen_freezer_5()
    {
        text.text = "You pop the freezer top lid open and find dozen human bodies inside."
            + "All the bodies are tangled together by their limbs and you would need huge strength to pull them out."
            + "\n\n"
            + "You need one of these bodies to be inserted into the unknown device."
            + "The body on the top looks that it could be lift up if it's arm would't be frozen and tangled with other corpses."
            + "\n\n"
            + "You could try melting the arm with the hot water you are carrying."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to Try melting the arm.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_freezer_5_0; }

    }

    void kitchen_freezer_5_0()
    {
        text.text = "You start to pour down the hot water on the corpses arm."
            + "Even though the arm is frozen the skin starts to cook a bit and disgusting smell floods the room."
            + "\n\n"
            + "You need to puke behind the freezer."
            + "Disgusted you move the defrozen arm and set the body loose. You lift it out of the freezer."
            + "\n\n"
            + "Press [1] to return.\n";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }


    }


    void unknown_device_5()
    {
        text.text = "You have investigated the device in the middle of the room. There are many dust trails around the device."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "You believe the device activates when it's cylinder has body in it. You won't jump in yourself as you believe the device processes human tissue into something."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }


    void previous_door_5()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }

    void new_door_5()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it unless you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_5; }

    }

    //Section 6-----------------------------------------------------------------------------------------------------------------

    void kitchen_6()
    {
        text.text = "You are in a wide white room. You can tell that it is a kitchen."
            + "At the center of the room there is a large unknown device."
            + "One side of the room is filled with stainless steel kitchen equipment. There is a freezer, drawers, closets, sink and stove"
            + "Other side of the room has a table set and bigger closets."
            + "\n\n"
            + "Behind you is the door you used to enter the room. On the other side of the room there is a new door and another creature waiting behind it."
            + "\n\n"
            + "All the surfaces of the room are covered in mild dust. You can see moving tracks on the floor. There has been movement inside the room. "
            + "\n\n"
            + "Creature behind the new door is blocking your escape. You could try activating the unknown device by inserting a body into it."
            + "You have pulled out one of the corpses out of the freezer. It's laying in the middle of the floor."
			+ "\n\n"
			+ "Press [1] to examine the kitchen drawers and closets\n"
            + "Press [2] to examine the kitchen work area.\n"
            + "Press [3] to examine the freezer.\n"
            + "Press [4] to examine the unknown device.\n"
            + "Press [5] to examine the previous door.\n"
            + "Press [6] to examine the new door.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_drawers_6; }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.kitchen_workarea_6; }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.kitchen_freezer_6; }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.unknown_device_6; }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.previous_door_6; }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.new_door_6; }
    }

    void kitchen_drawers_6()
    {
        text.text = "You go through the kitchen closets and drawers."
            + "You find a collection of different size pots, pans and kettles"
            + "They look used but you have feeling that they haven't been used for very long time."
            + "\n\n"
            + "Strange that there isn't a single knife or any sharp tool to use for self-defence."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }

    }


    void kitchen_workarea_6()
    {
        text.text = "Work area is covered in same mild dust as the rest of the room."
            + "Water runs on the tap and kitchen stove is electric and you can turn it on."
            + "\n\n"
            + "The water you are carrying is still hot as possible so you don't need to do here anything."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }

    }


    void kitchen_freezer_6()
    {
		text.text = "You pop the freezer top lid open and find dozen human bodies inside."
		+ "All the bodies are tangled together."
		+ "\n\n"
		+ "Theres a awful smell of cooked human skin."
		+ "\n\n"
		+ "You cannot do here anything anymore."
		+ "\n\n"
		+ "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }


    }


    void unknown_device_6()
    {
        text.text = "You have investigated the device in the middle of the room. There are many dust trails around the device."
            + "\n\n"
            + "There is large cylinder leaving from it that could fit in a person. Its insides has some smudge spots all over it like its been used often."
            + "On top of the device is a big glossy container that has glass meter on its side. The container is empty."
            + "\n\n"
            + "You believe the device activates when it's cylinder has body in it. You won't jump in yourself as you believe the device processes human tissue into something."
            + "\n\n"
            + "You could throw in the body thats laying on the floor."
            + "\n\n"
            + "Press [1] to return.\n"
            + "Press [2] to insert the body into the cylinder.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.unknown_device_6_0; }

    }

    void unknown_device_6_0()
    {
        text.text = "You lift up the body thats laying on the floor and drag it to the device."
            + "\n\n"
            + "Body falls in and fits perfectly in the cylinder."
            + "In seconds you can hear the device to start activating and a cover rotates and closes the cylinder."
            + "\n\n"
            + "You hear grinding sound and some heavy electric sounds from the device."
            + "\n\n"
            + "Green liquid goo starts filling into the top container."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_7; }

    }


    void previous_door_6()
    {
        text.text = "You listen through the closed door where you entered the room."
            + "You can hear the creature moving along the hallway like it would be patrolling."
            + "\n\n"
            + "There is no point now going back and risk being captured. "
            + "\n\n"
            + "Press [1] to go back.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }

    }

    void new_door_6()
    {
        text.text = "You know that there is a creature behind the door and you cannot go pass it unless you find a way to distract it."
            + "\n\n"
            + "Creature has tube kind of part extending its body that has the same kind of adapter piece as in your hand. "
            + "Opening the door is a suicide."
            + "\n\n"
            + "Press [1] to return.\n";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.kitchen_6; }

    }
    //Section 7----------------------------------------------------------------------------------
    void kitchen_7()
    {
        text.text = "Suddenly you hear loud moving noises from the new door."
            + "You look around you and decide to rush under the kitchen table set."
            + "\n\n"
            + "Door opens up and the mechanical creature rolls with its crawler tracks towards the device."
            + "\n\n"
            + "You keep quiet and take a moment looking what the creature is doing with the device. It extends its tubeish joint and inserts it to the device."
            + "The door is open and creature is looking in other direction. You take you chance and sneak to the door and enter the next hallway while it's "
			+ "distracted. There doesn't seem to be anything here. Looks like the place is slowly coming apart since on both your sides, the hallways "
			+ "have been partially collapsed for whatever reason. Upon closer inspection there is some of the familiar substance seeping through the cracks "
			+ "of the rubble. Whatever caused this could still be around. You quietly sneak into the next room and close the door behind yourself."
			+ "\n\n"
            + "Press [1] to continue.";
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(Application.loadedLevel + 1); }

        
    }

   
}