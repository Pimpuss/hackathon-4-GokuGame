using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth3 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    
    public float InvicibilityFlashDelay = 0.05f;
    public float InvicibilityTimeAfterHit = 2f;
    public bool isInvicible = false;
    public SpriteRenderer graphics;
    public HealthBar healthBar;

    [SerializeField] GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
   
    // Update is called once per frame

    public void Restart()
    {
      SceneManager.LoadScene(2);
    }

    public void TakeDamage(int damage)
        {
            if(!isInvicible) 
            {   
                currentHealth -= damage;
                healthBar.SetHealth(currentHealth);
                isInvicible = true;
                StartCoroutine(InvicibilityFlash());
                StartCoroutine(HandleInvicibilityDelay());
                if(currentHealth<=0){
                    Debug.Log("MORT");
                     gameObject.SetActive(true);
                     Invoke("TimeScale", 2);
                }
            }

        }

    void TimeScale ()
    {
        Time.timeScale = 0f;
    }

        public IEnumerator InvicibilityFlash() 
        {
            while(isInvicible) 
            {
                graphics.color = new Color(1f,1f,1f,0f);
                yield return new WaitForSeconds(InvicibilityFlashDelay);
                graphics.color = new Color(1f,1f,1f,1f);
                yield return new WaitForSeconds(InvicibilityFlashDelay);
            }
         }


         public IEnumerator  HandleInvicibilityDelay() 
         {
                yield return new WaitForSeconds(InvicibilityTimeAfterHit);
                isInvicible = false;
         }
}
