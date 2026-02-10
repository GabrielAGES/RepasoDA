using Unity.VisualScripting;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;

    //public bool isMove;
    public Rigidbody rb;
    float velocidad = 5;
    //[SerializeField]
    //private bool isMove;
    //public bool is
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerController.DireccionJugador());
        Movimiento();
    }

    public void Movimiento()
    {

            rb.linearVelocity = playerController.DireccionJugador() * velocidad;

    }
}
