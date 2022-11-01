using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject planeStage;
    [SerializeField] private TextMeshProUGUI  textMesh;
    [SerializeField] private string textOn, textOff;
    private bool isOn = true;
    // Start is called before the first frame update
    void Start()
    {
        ToggleActive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleActive()
    {
        isOn = !isOn;
        if(isOn) {
            textMesh.text = textOn;
        }
        else {
            textMesh.text = textOff;
        }
        planeStage.SetActive(isOn);
    }
}
