using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class Attack1 : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Collider2D myCollider;
    public ParticleSystem ps;

    public int damage = 1;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        if (myRigidbody != null)
        {
            Invoke("AutoDestroy", 10F);

            myCollider = GetComponent<Collider2D>();

            if (myCollider != null)
            {
                myCollider.isTrigger = false;
            }
        }
        else
        {
            AutoDestroy();
        }
    }

    private void AutoDestroy()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player"
            || col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Character>().ApplyDamage(damage);
        }

        if (ps != null)
        {
            (Instantiate<ParticleSystem>(ps, transform.position, ps.transform.rotation)).Play();
        }

        AutoDestroy();
    }
}