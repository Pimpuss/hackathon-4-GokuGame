using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GokuScriptLvl2 : MonoBehaviour
{
    [SerializeField] float speed = 2f, jumpForce = 500f;
    Rigidbody2D rb;
    Animator anim;
    AudioSource _audioSource;
    bool lookRight = true;
    bool Mute = true;
    bool Pause = true;

    // Grounded
    [SerializeField] bool grounded;
    [SerializeField] float groundRadius = 0.02f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask theGround;


    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }
    public void Start() {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(move));
        // anim.SetFloat("Speed", Mathf.Abs(move));
    }
    public void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(move));
        // grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, theGround);
        // anim.SetBool("Grounded", grounded);

        // float move = Input.GetAxis("Horizontal");
        // transform.Translate(Vector2.right * move * speed * Time.deltaTime);
        // anim.SetFloat("Speed", Mathf.Abs(move));
        // anim.SetFloat("Vspeed", rb.velocity.y);

        // if (move > 0 && !lookRight)
        // {
        //     Flip();
        // }
        // else if (move < 0 && lookRight)
        // {
        //     Flip();
        // }
        //  if (Input.GetKeyDown(KeyCode.UpArrow)) 
        // {

        //     rb.AddForce(new Vector2(0, jumpForce));
        // }

        // if (Input.GetKeyDown(KeyCode.Space)) 
        // {
        //     anim.SetTrigger("Attack");
            
        // }
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     SceneManager.LoadScene(0);
        // }
    }

    public void Flip()
    {
        lookRight = !lookRight;
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

     public void Hurt() 
    {
        anim.SetTrigger("Hurt");
    }
    
    public void StopMusic()
     {
         if(Mute) {
         _audioSource.Stop();
         Mute = !Mute;
         } else if (!Mute) {
             _audioSource.Play();
             Mute = !Mute;
         }
     }

    public void PauseGame()
    {
        if(Pause) {
            Time.timeScale = 0f;
            _audioSource.Stop();
            Pause = !Pause;
        } else {
            Time.timeScale = 1;
            Pause = !Pause;
        }
    }



    // private void FixedUpdate ()
    // {
    //     if (Input.GetKeyDown(KeyCode.UpArrow) && anim.GetBool("Grounded")) 
    //     {
    //         rb.AddForce(new Vector2(0, jumpForce));
    //     }
    // }
}
