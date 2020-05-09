using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    [SerializeField]private GameObject _cloudParticlePrefab;

     private void  OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        if (bird != null)
        {
            Instantiate(_cloudParticlePrefab,transform.position,Quaternion.identity);
            Destroy(gameObject);
            return;
        }
        Enemy enmey = collision.collider.GetComponent<Enemy>();
        if (enmey != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
