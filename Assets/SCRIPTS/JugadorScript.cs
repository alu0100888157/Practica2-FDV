using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorScript : MonoBehaviour
{

    public int poder = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int get_poder()
    {
        return poder;
    }
    public void set_poder(int poder_add)
    {
        poder += poder_add;
    }

}
