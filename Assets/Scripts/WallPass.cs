using UnityEngine;

public class WallPass : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject tail;
    public GameObject destroyedWall;
    public Player movement;
    public AudioSource crashSound;
    public AudioSource track;
    
    void OnTriggerEnter(Collider wall)
    {
        if(wall.GetComponent<Collider>().tag == "Player")
        {
            if(gameObject.GetComponent<Renderer>().material.color == head.GetComponent<Renderer>().material.color)
            {
                Instantiate(destroyedWall, transform.position, transform.rotation);
                this.gameObject.SetActive(false);
                //colors are swapped from tail -> body -> head if wall is breaked 
                head.GetComponent<Renderer>().material.color =  body.GetComponent<Renderer>().material.color;
                body.GetComponent<Renderer>().material.color = tail.GetComponent<Renderer>().material.color;
                tail.GetComponent<Renderer>().material.color = tail.GetComponent<Renderer>().material.color;
                //particle.GetComponent<ParticleSystem>().startColor = tail.GetComponent<Renderer>().material.color;
            }
            else
            {
                FindObjectOfType<GameManager>().EndGame();
                movement.enabled = false;
                Time.timeScale = 0f;
                crashSound.enabled = true;
                track.enabled = false;
                FindObjectOfType<GameManager>().CrashMenu();
                FindObjectOfType<HighScore>().HighScoreData();
            }
            if(head.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color 
                && body.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color
                    && tail.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
            {
                //all parts are applied to white color if only one color is there in all parts and the wall is breaked
                head.GetComponent<Renderer>().material.color = Color.white;
                body.GetComponent<Renderer>().material.color = Color.white;
                tail.GetComponent<Renderer>().material.color = Color.white;
                //particle.GetComponent<ParticleSystem>().startColor = tail.GetComponent<Renderer>().material.color;
            }
        }
    }
       
}
