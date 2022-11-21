using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour
{
    public Click click;

    void OnMouseDown()
    {
        if(gameObject.tag == "Circle"){
            click.circleClicked();
            }
        if(gameObject.tag == "Triangle"){
            click.triangleClicked();
        }
        if(gameObject.tag == "Square"){
            click.squareClicked();
        }
    }

}

