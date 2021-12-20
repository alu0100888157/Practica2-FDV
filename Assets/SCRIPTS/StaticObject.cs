using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticObject : MonoBehaviour
{
    public JugadorScript jugadorscript;
    public Rigidbody _rigidbody;
    public GameObject jugador;
    public Text Texto_Score;
    private Vector3 posicion;
    private Vector3 escala;

    // Start is called before the first frame update
    void Start()
    {
        escala.x = 0.5f;
        escala.y = 0.5f;
        escala.z = 0.5f;
        posicion.Set(Random.Range(-33, 33), 1, Random.Range(-33, 33));
        this.gameObject.transform.position = posicion;
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == jugador.gameObject.GetComponent<CapsuleCollider>())
        {
            
            this.GetComponent<Renderer>().material.color = Color.clear;
            if (this.transform.localScale.sqrMagnitude > escala.sqrMagnitude)
            {
                this.transform.localScale = this.transform.localScale * 0.75f;

                jugadorscript.set_poder(3);
            }
            else
            {
                jugadorscript.set_poder(3);
                this.gameObject.SetActive(false);
            }
            _rigidbody.AddForce(0, 0, jugadorscript.get_poder(), ForceMode.Impulse);
        }
    }
}
