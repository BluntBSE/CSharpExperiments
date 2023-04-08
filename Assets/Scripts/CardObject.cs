using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class CardObject : MonoBehaviour
{
    public bool isDragged = false;
    public bool isHovered = false;

    [SerializeField]
    private string _thisText;
    public string ThisText
    {
        get => _thisText;
        set { _thisText = value; }
    }
    private GameObject thisObject;
    private Vector3 offset;
    private Vector3 originalPosition;
    private bool acceptsTargets = true;
    public CardScriptToExecute cardScriptToExecute;
    public GameObject target;
    [SerializeField]
    public CardAsset cardAsset;
    public string cardEffectScriptName;


  

    /*LIFE CYCLE LIFE CYCLE LIFE CYCLE */
    /*LIFE CYCLE LIFE CYCLE LIFE CYCLE */
    /*LIFE CYCLE LIFE CYCLE LIFE CYCLE */


    // Start is called before the first frame update
    void DisplaySomeText(){
        Debug.Log("DisplaySomeText was triggered");
    }

    void ReadCardFromAsset(CardAsset asset){
        //Change the scriptname here from asset.
        cardScriptToExecute = System.Activator.CreateInstance(System.Type.GetType(cardEffectScriptName)) as CardScriptToExecute;
    }

    void Start() {
    
     }

    void Awake()
    {   
        
        thisObject = this.gameObject;
        ReadCardFromAsset(cardAsset);
    }

    // Update is called once per frame
    void Update()
    {

        cardScriptToExecute.Execute();
        }

}
