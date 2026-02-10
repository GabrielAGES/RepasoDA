using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int numeroEntero = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Clases ListaEstudiantes = new Clases();
    void Start()
    {
        Myfunction();
    }

    // Update is called once per frame
    void Update()
    {
        Myfunction();
    }
    public void Myfunction()
    {
        //Escribir en la consola el estudiante con el index #2
        Debug.Log(ListaEstudiantes.estudiantes[2]);
    }
}
