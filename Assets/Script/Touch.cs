using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private PlayerMove player;
    public Rigidbody2D pemain;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMove>();
    }

    public void LeftArrow() {
        player.moveLeft = true;
        player.moveRight = false;
    }

    public void RightArrow()
    {
        player.moveLeft = false;
        player.moveRight = true;
    }

    public void ReleaseLeftArrow()
    {
        player.moveLeft = false;
        pemain.velocity = new Vector2(0, pemain.velocity.y);
    }

    public void ReleaseRightArrow()
    {
        player.moveRight = false;
        pemain.velocity = new Vector2(0, pemain.velocity.y);
    }

    public void JumpButton () {
        player.jump = true;
    }

    public void ReleaseJumpButton() {
        player.jump = false;
    }

    public void changeButton()
    {
        player.change = true;
    }

    public void releaseChangeButton()
    {
        player.change = false;
        player.cnt = 0;
    }
}
