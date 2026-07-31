using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    //este script sirve para manejar la velocidad del disparo y su autodestrucción
    #region variables
    public float velocidad = 1f;
    public Rigidbody2D rbBala;
    public float tiempo = 3; //el alcance que va a tener la bala antes de desaparecer
    [SerializeField] string Tag_Objetivo;
    #endregion

    #region funciones basicas
    private void OnEnable()
    {
        //gameObject.SetActive(true);
        //rbBala.velocity = transform.right * velocidad;
        rbBala.velocity = Vector2.zero;
        rbBala.angularVelocity = 0;

        rbBala.velocity = transform.right * velocidad;
        StartCoroutine(DisableAfterTime());
    }

    #endregion

    #region code
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == Tag_Objetivo)
        {
            //GameObject gameObject = ObjectPool.SharedInstance.GetPooledObject();
            gameObject.SetActive(false);
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
    IEnumerator DisableAfterTime()
    {
        yield return new WaitForSeconds(tiempo);

        gameObject.SetActive(false);
    }

    //IEnumerator cooldown()
    //{
    //    //Debug.Log("cambio de velocidad");
    //    //GameObject gameObject = ObjectPool.SharedInstance.GetPooledObject();
    //    yield return new WaitForSeconds(tiempo);

    //    gameObject.SetActive(false);


    //    //yield return new WaitForSeconds(3f);
    //    yield break;
    //}
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    #endregion
}
