using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Movimento autom�tico no eixo Y
        rig.AddForce(Vector2.up * Speed, ForceMode2D.Force); // ou .Impulse

    }
}
