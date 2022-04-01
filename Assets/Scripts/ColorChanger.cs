using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject tail;
    public GameObject bottle;
    public ParticleSystem particle;
    public float rotationSpeed = 5f;
    Material temp;

    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        bottle.transform.Rotate(0,rotationSpeed*Time.deltaTime,0, Space.World);
    }

    void OnTriggerEnter(Collider color)
    {
        if(color.GetComponent<Collider>().tag == "Player")
        {
            if(head.GetComponent<Renderer>().material.color == Color.white)
            {
                //all parts are applied to same color as color picker
                head.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
                body.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
                tail.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
                particle.GetComponent<ParticleSystem>().startColor = tail.GetComponent<Renderer>().material.color;
            }
            if(head.GetComponent<Renderer>().material != GetComponent<Renderer>().material)
            {
                //colors are swapped from head -> body -> tail if multiple colors are picked
                temp = GetComponent<Renderer>().material;
                tail.GetComponent<Renderer>().material = body.GetComponent<Renderer>().material;
                body.GetComponent<Renderer>().material = head.GetComponent<Renderer>().material;
                head.GetComponent<Renderer>().material = temp;
                bottle.gameObject.SetActive(false);
            }
        }
    }
}
