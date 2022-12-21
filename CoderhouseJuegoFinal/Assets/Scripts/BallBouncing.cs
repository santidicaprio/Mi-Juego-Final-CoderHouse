using UnityEngine;

public class BallBouncing : MonoBehaviour




{
    [SerializeField] Rigidbody rb;
    [SerializeField] float bouncing;
    [SerializeField] float speed;
    [SerializeField] float maxSpeed = 30f;
    [SerializeField] Transform pointRaycast;
    [SerializeField] ParticleSystem hitParticle;
    [SerializeField] AudioSource clip;
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource godlikeSound;
    [SerializeField] AudioSource finishGame;
    [SerializeField] ParticleSystem finishParticle;
    [SerializeField] ParticleSystem rain;
    




    private float _horizontalMove;
    private float _verticalMove;
    private float _range = 1000f;
    private bool _soundOneTime = false;







    void Start()
    {

        Invoke("Music", 7f);
    }


    void Update()
    {
        ParticleEffect();
        
    }

    void FixedUpdate()
    {

        BallMovementTwo();
    }

    void ParticleEffect()
    {
        RaycastHit hit;

        if (Physics.Raycast(pointRaycast.transform.position, -transform.up, out hit, 0.1f))
        {

            Debug.Log("Efecto particula");
        }

    }
    bool alreadyTouched = false;
    void OnCollisionEnter(Collision col)
    {

        if (col.transform.CompareTag("Floor") && _soundOneTime == false)
        {
            speed = 20f;
            godlikeSound.PlayOneShot(godlikeSound.clip, 1f);
            rain.Play();
            _soundOneTime = true;


        }


        if (col.transform.CompareTag("SpeedFloor"))
        {
            speed = 80f;
        }




        if (col.transform.CompareTag("Ground") && alreadyTouched == false)
        {


            Instantiate(hitParticle, transform.position, Quaternion.LookRotation(transform.position));
            clip.Play();

            rb.AddForce(Vector3.up * bouncing, ForceMode.Force);
            Debug.Log("saltando");







            var obstacle = col.gameObject.GetComponent<Obstacle>();
            if (obstacle != null)
            {
                obstacle.DeactiveKinematic();

                Debug.Log("Desactivando kinematic");
            }








            alreadyTouched = true;
            Invoke("ResetAlreadyTouched", 0.2f);
        }

        else if (col.transform.CompareTag("FinishLevel"))
        {

            var obstacle = col.gameObject.GetComponent<Obstacle>();
            if (obstacle != null)
            {
                obstacle.DeactiveKinematic();

                Debug.Log("Rompiendo pared");
                obstacle.BreakWall();
                Debug.Log("Explosion");
            }
        }
        else if (col.transform.CompareTag("FinishGame"))
        {
            finishGame.Play();
            finishParticle.Play();
            music.Stop();
        }
        



    }



    void ResetAlreadyTouched()
    {
        alreadyTouched = false;
        Debug.Log("Puedo volver a saltar");
    }

    void OnCollisionExit(Collision col)
    {
        if (col.transform.CompareTag("Ground"))
        {
            //alreadyTouched = false;
        }
    }

    
    void BallMovement()
    {
        _horizontalMove = Input.GetAxis("Horizontal");
        _verticalMove = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(_horizontalMove, 0, _verticalMove);


        rb.AddRelativeForce(dir * speed, ForceMode.Acceleration);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    }



    void BallMovementTwo()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-Vector3.right * speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(-Vector3.forward * speed);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.CompareTag("Coin"))
        {
            var coin = col.gameObject.GetComponent<CoinBehaviour>();
            if (coin != null)
            {
                coin.Coin();                
            }
        }
    }
    void Music()
    {
        music.Play();
    }
}
