using UnityEngine;
using Zenject;

namespace Combined
{
    public class Arrow : MonoBehaviour, IProjectile
    {
        [Inject] private GameManager _gameManager;

        public void OnHit()
        {
            _gameManager.RegisterHit();
            Destroy(gameObject);
        }

        public void Shoot()
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
                OnHit();
        }
    }
}
