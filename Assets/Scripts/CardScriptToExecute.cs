using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScriptToExecute : MonoBehaviour
{
    // Start is called before the first frame update
    public virtual void Execute(){
        Debug.Log("Hello from Executor");
    }
}
