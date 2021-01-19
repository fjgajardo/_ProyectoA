using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    [SerializeField]
    private float speed;
    private Rigidbody2D body;
    Vector2 movement;


    public MoveCommand(Rigidbody2D body, float speed, Vector2 movement){
        this.speed = speed;
        this.body = body;
        this.movement = movement;
    }

    public void Execute()
    {
        body.MovePosition(body.position + movement * speed);
    }
}
