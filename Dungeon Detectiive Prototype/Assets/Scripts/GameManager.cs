//47
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GameManager : MonoBehaviour {
    GameObject AttackSelectPanel;
    GameObject NormalAttackPanel;
    GameObject SpecialAttackPanel;
    // Above 3 lines create variables  with type gameobject. they hold no value though.

    private Vector3 moveDown;
    private Vector3 moveUp;
    //Defining two variables that the ui panel goes to when prompted

    

    RectTransform AttackSelectPanelRectTransform;
    RectTransform NormalAttackPanelRectTransform;
    RectTransform SpecialAttackPanelRectTransform;
    //Defines variables of type RectTransform.

    private int EnemyHP = 100;
    private int PlayerHP = 100;
    //Defining HP Variables

    static System.Random randomDmg = new System.Random();
    int randomDmgAsInt;
    // used to make random bits of damage hit the player
    
    void DamagePlayer(int dmg)
    {
        Text PlayerHPLabel = GameObject.Find("PlayerHPLabel").GetComponent<Text>();        
        PlayerHP -= dmg;        
        PlayerHPLabel.text = PlayerHP.ToString();
        
    }

    void DamageEnemy(int dmg)
    {
        AudioSource hitAudio = GameObject.Find("GameManager").GetComponent<AudioSource>();
        hitAudio.Play();
        //works simmilar to text definitions, but with audio sources

        Text EnemyHPLabel = GameObject.Find("EnemyHPLabel").GetComponent<Text>();
        EnemyHP -= dmg;
        EnemyHPLabel.text = EnemyHP.ToString();
        randomDmgAsInt = randomDmg.Next(0,26);
        
        DamagePlayer(randomDmgAsInt);
        
    }


    private void GetAttackType()
    {


        moveDown = new Vector3(120, -500, 0);
        moveUp = new Vector3(120, 0, 0);
        // Makes a new variable of the component "Text" of the game object it finds.

        AttackSelectPanel = GameObject.Find("AttackSelectPanel");
        NormalAttackPanel = GameObject.Find("NormalAttackPanel");
        SpecialAttackPanel = GameObject.Find("SpecialAttackPanel");
        // Make the variable store a reference to the game object it's finding.

        AttackSelectPanelRectTransform = AttackSelectPanel.GetComponent<RectTransform>();
        NormalAttackPanelRectTransform = NormalAttackPanel.GetComponent<RectTransform>();
        SpecialAttackPanelRectTransform = SpecialAttackPanel.GetComponent<RectTransform>();


        Text AttackSelectLabel = GameObject.Find("ASLabel").GetComponent<Text>();
        
        //Makes new variables to store the text component of the UI element


        if (AttackSelectLabel.text.ToString() == "Normal Attack")
        //checks to see if the label's attack says "Normal attack"
        {

            AttackSelectPanelRectTransform.anchoredPosition = moveDown;
            NormalAttackPanelRectTransform.anchoredPosition = moveUp;
        }
        else if (AttackSelectLabel.text.ToString() == "Special Attack")
        {

            AttackSelectPanelRectTransform.anchoredPosition = moveDown;
            SpecialAttackPanelRectTransform.anchoredPosition = moveUp;
        }
    }
    void NBack()
    {

        AttackSelectPanelRectTransform.anchoredPosition = moveUp;
        NormalAttackPanelRectTransform.anchoredPosition = moveDown;
    }
    void SBack()
    {

        AttackSelectPanelRectTransform.anchoredPosition = moveUp;
        SpecialAttackPanelRectTransform.anchoredPosition = moveDown;
    }


    void PlayerSpecialAttack()
    {
        Text SpecialAttackLabel = GameObject.Find("SALabel").GetComponent<Text>();
        //Makes new variables to store the text component of the UI element

        if (SpecialAttackLabel.text.ToString() == "Pistol")
        //checks to see if the label's attack says "Pistol"
        {
            DamageEnemy(15);
            
        }
        else if (SpecialAttackLabel.text.ToString() == "Pepper spray")
        {
            DamageEnemy(5);
            
        }
        else if (SpecialAttackLabel.text.ToString() == "Shotgun")
        {
            DamageEnemy(25);
            
        }
    }

    
    void PlayerNormalAttack()
    {
        Text NormalAttackLabel = GameObject.Find("NALabel").GetComponent<Text>();
        //Makes new variables to store the text component of the UI element
        if (NormalAttackLabel.text.ToString() == "Fists")
        //checks to see if the label's attack says "Normal attack"
        {
            DamageEnemy(10);
            
        }
        else if (NormalAttackLabel.text.ToString() == "Baton")
        {
            DamageEnemy(10);
           
        }
        else if (NormalAttackLabel.text.ToString() == "Taser")
        {
            DamageEnemy(5);
            
        }
    }
    
}
