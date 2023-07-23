using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{   
    public int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public bool isShield = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        foreach(Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
        for(int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
        if (health <= 0)
        {
            //SceneManager.LoadScene("EndMenu");
            End();
        }
        checkShiled();
    }
    public void End()
    {
        Destroy(this.gameObject);
        MenuManager.GoToMenu(MenuName.End);
    }

    public void checkShiled()
    {
        if (isShield == true)
        {
            StartCoroutine(ResetShield());
        }
    }
    public IEnumerator ResetShield()
    {
        yield return new WaitForSeconds(5f);
        isShield = false;
        Debug.Log("Shield deActivated");
    }

}
