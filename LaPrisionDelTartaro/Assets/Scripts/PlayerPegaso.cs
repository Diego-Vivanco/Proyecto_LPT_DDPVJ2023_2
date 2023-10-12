using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPegaso : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;

    private Animator anim;
    public float x, y;

    //public Rigidbody rb;
    //public float fuerzaSalto = 8.0f;
    public bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        //puedoSaltar = false;
        anim = GetComponent<Animator>();
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    anim.SetTrigger("salto");
        //}
    }


}
