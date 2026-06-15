using UnityEngine;

namespace Combined
{
    public class Arrow : MonoBehaviour, IProjectile
    {
        public void OnHit()
        {
            GameManager.Instance.RegisterHit();
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
