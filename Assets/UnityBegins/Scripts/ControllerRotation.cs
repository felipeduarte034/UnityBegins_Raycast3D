using UnityEngine;

public class ControllerRotation : MonoBehaviour
{
    public float angulo = 0;
    public float passo = 90;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            angulo += passo;
            transform.rotation = Quaternion.Euler(angulo, 0, 0);
        }
    }
}
