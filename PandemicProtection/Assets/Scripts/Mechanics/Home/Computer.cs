using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Computer : MonoBehaviour
{
    public bool hasCollided = false;
    public string labelText = "";
    public GameObject Instruction; 
    public TextMeshProUGUI label;
 
    void Start()
    {
        Instruction.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        Instruction.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E)) {        
            //TRANSITION TO STORE SCENE  
            Debug.Log("logging on to PPzon...");
            LevelLoader.instance.LoadNextLevel("Shop");                        
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instruction.SetActive(true);
        if(other.gameObject.tag =="Player") 
        {
            hasCollided = true;
            labelText = "Log onto P Mart Online? (press E to continue)";
            label.text = labelText;
        }
        Debug.Log(labelText);
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        Instruction.SetActive(false);
        hasCollided = false;
    
    }
}
