using UnityEngine;

public class PadController : MonoBehaviour
{
    public SpriteRenderer padSpriteRenderer;
    public Sprite basketballSprite;
    public Sprite footballSprite;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Change the pad's sprite based on the current sprite
                if (padSpriteRenderer.sprite == basketballSprite)
                {
                    padSpriteRenderer.sprite = footballSprite;
                }
                else
                {
                    padSpriteRenderer.sprite = basketballSprite;
                }
            }
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(padSpriteRenderer.sprite == basketballSprite)
        {
            if (collision.gameObject.CompareTag("BasketballBall"))
            {
                Destroy(collision.gameObject);
                IncreaseScore();

            }
            else
            {
                GameOver();
            }
        }

        if(padSpriteRenderer.sprite == footballSprite)
        {
            if (collision.gameObject.CompareTag("FootballBall"))
            {
                Destroy(collision.gameObject);
                IncreaseScore();
            }
            else
            {
                GameOver();
            }
        }
    }

    public void IncreaseScore()
    {
        Debug.Log("Score Increased");
    }
    public void GameOver()
    {
        Debug.Log("Gameover");

    }

}