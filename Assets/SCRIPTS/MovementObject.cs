
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementObject : MonoBehaviour
{
    public JugadorScript jugadorscript;
    public Rigidbody _rigidbody;
    public GameObject jugador;
    private Vector3 posicion;
    private Vector3 escala;
    private bool lado = false;
    void Start()
    {
        escala.x = 0.5f;
        escala.y = 0.5f;
        escala.z = 0.5f;
        posicion.Set(Random.Range(-33, 33), 1, Random.Range(-33, 33));
        this.gameObject.transform.position = posicion;
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        Invoke("ChangePosition", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangePosition()
    {
        /*if (posicion.x < 53 && posicion.x + 1 < 53 && lado)
        {
            posicion.x++;
            this.gameObject.transform.position = posicion;
        }
        else if(posicion.x > -53 && posicion.x - 1 > -53)
        {
            posicion.x--;
            lado = false;
            this.gameObject.transform.position = posicion;
        } 
        else
        {
            lado = true;
        }*/
        posicion = this.gameObject.transform.position;
        posicion.x++;
        this.gameObject.transform.position = posicion;
        Invoke("ChangePosition", 3);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == jugador.gameObject.GetComponent<CapsuleCollider>())
        {

            this.GetComponent<Renderer>().material.color = Color.clear;
            if (this.transform.localScale.sqrMagnitude > escala.sqrMagnitude)
            {
                this.transform.localScale = this.transform.localScale * 0.75f;

                jugadorscript.set_poder(15);
                Debug.Log(jugadorscript.get_poder());
            }
            else
            {
                jugadorscript.set_poder(15);
                Debug.Log(jugadorscript.get_poder());
                this.gameObject.SetActive(false);
            }
            Vector3 distancia = this.gameObject.transform.position - jugador.gameObject.transform.position;
            distancia = distancia.normalized;
            _rigidbody.AddForce(distancia * 4, ForceMode.Impulse);
        }
    }
}
