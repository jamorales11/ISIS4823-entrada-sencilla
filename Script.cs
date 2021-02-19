using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    GameObject obj;
    float r = 0f;
    float g = 0f;
    float b = 0f;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }

    // Update is called once per frame
    void Update()
    {
        float vy = 0;
        float vx = 0;
        float speed = 4;
        if(Input.GetKey(KeyCode.UpArrow)){
            vy+=speed;
        }if(Input.GetKey(KeyCode.DownArrow)){
            vy-=speed;
        }if(Input.GetKey(KeyCode.LeftArrow)){
            vx-=speed;
        }if(Input.GetKey(KeyCode.RightArrow)){
            vx+=speed;
        }

        obj.transform.position += new Vector3(vx*Time.deltaTime, vy*Time.deltaTime, 0f);
        
        float coloracion = 1f;
        if(Input.GetKey(KeyCode.R)&&r<255f){
            r+=coloracion;
        }
        if(Input.GetKey(KeyCode.T)&&r>0f){
            r-=coloracion;
        }
        if(Input.GetKey(KeyCode.G)&&g<255f){
            g+=coloracion;
        }
        if(Input.GetKey(KeyCode.H)&&g>0f){
            g-=coloracion;
        }
        if(Input.GetKey(KeyCode.B)&&b<255f){
            b+=coloracion;
        }
        if(Input.GetKey(KeyCode.N)&&b>0f){
            b-=coloracion;
        }
        Color c = CrearColor(new Vector3(r,g,b));
        obj.GetComponent<Renderer>().material.color = c;
    }
     Color CrearColor(Vector3 colores){
        Vector3 p = new Vector3((float)(colores.x/255),(float)(colores.y/255),(float)(colores.z/255));
        return new Color(p.x,p.y,p.z);
    }
}
