using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CardAsset", order = 1)]
public class CardAsset : ScriptableObject
{
    public CardScriptToExecute cardScriptToExecute;
    // Start is called before the first frame update

    public void DisplayAssetText(){
        Debug.Log("Text displayed from constructor asset");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
