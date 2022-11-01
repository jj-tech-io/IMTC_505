using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonHelp : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI  textMesh;
    private bool showHelp = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowHelp()
    {
        showHelp = !showHelp;
        if(showHelp) {
            textMesh.text = "Click on the button to toggle the plane stage on and off. Tap screen to place snakes. Tap on snake to switch snakes. :)";
        }
        else {
            textMesh.text = "";
        }
    }
}

