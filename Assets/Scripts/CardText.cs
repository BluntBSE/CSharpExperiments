using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CardText : MonoBehaviour
{

    private string _renderedText;
    private CardObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake(){
        _parent = GetComponentInParent<CardObject>();
        _renderedText = _parent.ThisText;

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<TMP_Text>().text = _renderedText;
        
    }
}
