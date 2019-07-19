using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f, jumpForce = 700f;

    [SerializeField]
    private GameObject[] Chara = new GameObject[2];

    [SerializeField]
    private string charColor;

    public bool moveRight, moveLeft, jump, change;
    public int arrayIndex = 0, cnt = 0;
    
    Rigidbody2D rb;

    void Awake () {
        Chara[arrayIndex % 2].SetActive(true);
        charColor = Chara[arrayIndex % 2].tag;
    }

    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate () {

        if (moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (moveLeft)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }

        if (jump) {
            PlayerJump();
        }

        if (change)
        {
            CharChange();
        }
    }

    public void PlayerJump () {
        if (rb.velocity.y == 0)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
    }

    public void CharChange() {
        if (cnt < 1){
            Chara[arrayIndex % 2].SetActive(false);
            arrayIndex++;
            charColor = Chara[arrayIndex % 2].tag;
            Chara[arrayIndex % 2].SetActive(true);
            cnt++;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != charColor)
            Debug.Log("GAME OVER DUDE");
    }
} //Class
