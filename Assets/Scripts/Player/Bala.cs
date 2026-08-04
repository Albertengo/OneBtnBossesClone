using System.Collections;
using UnityEngine;

public class Balas : MonoBehaviour
{
    #region variables

    [Header("BEHAVIOUR")]

    public float velocidad = 1f;
    public Rigidbody2D rbBala;
    public float tiempo = 3;
    [SerializeField] string Tag_Objetivo;

    #endregion

    private void OnEnable()
    {
        SetSpeed();
        StartCoroutine(DisableAfterTime());
    }
    IEnumerator DisableAfterTime()
    {
        yield return new WaitForSeconds(tiempo);

        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    #region code
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Tag_Objetivo)
        {
            gameObject.SetActive(false);
        }
    }
    void SetSpeed()
    {
        rbBala.velocity = Vector2.zero;
        rbBala.angularVelocity = 0;

        rbBala.velocity = transform.right * velocidad;
    }
    
    #endregion
}
