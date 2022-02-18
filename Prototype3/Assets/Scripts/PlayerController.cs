using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype3
 * This script controls the player and the effects related to them.
 */

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetFloat("Speed_f", 1.0f);

        rb = GetComponent<Rigidbody>();

        jumpForceMode = ForceMode.Impulse;

        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over! :(");
            gameOver = true;

            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            explosionParticle.Play();
            dirtParticle.Stop();

            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
