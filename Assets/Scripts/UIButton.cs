using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class UIButton : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] GameObject targetObject;
    [SerializeField] string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnPointerEnter(PointerEventData eventData){
        Debug.Log("You're moused over;");
        //Should we lift this outside of onMouseEnter?
        Image sprite = GetComponent<Image>();
        if (sprite != null){
            Debug.Log("Sprite is here");
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit(){}

    public void OnMouseUp()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
