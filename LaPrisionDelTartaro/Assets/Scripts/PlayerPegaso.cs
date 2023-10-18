using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPegaso : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;

    private Animator anim;
    public float x, y;

    private AnimatorStateInfo playerAnimatorInfo;

    public Rigidbody rb;
    public int fuerzaSalto = 5;
    public bool puedoSaltar;
    public int fuerzaExtra = 3;

    public Slider SFxSlider;

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
        playerAnimatorInfo = anim.GetCurrentAnimatorStateInfo(0);
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        //if (puedoSaltar)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        anim.SetBool("salto", true);
        //        rb.AddForce(new Vector3(0, fuerzaSalto, 0));

        //    }
        //    else
        //    {
        //        anim.SetBool("suelo", true);
        //    }
        //}
        //else
        //{
        //    EstoyCayendo();
        //}



        if (Input.GetKeyDown(KeyCode.Space) && playerAnimatorInfo.IsName("Correr"))
        {
            anim.SetTrigger("saltar");
        }
    }

    public void EstoyCayendo()
    {
        rb.AddForce(fuerzaExtra * Physics.gravity);
        anim.SetBool("suelo", false);
        anim.SetBool("salto", false);
    }
}
