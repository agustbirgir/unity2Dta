using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;
    public float sideways = 2;
    public float jump = 2;
    //private Rigidbody leikmadur;
    public static int count;
    public Text countText;

    void Start()
    {
        Debug.Log("byrja");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //sn� player
        if (Input.GetKey("f"))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
        if (Input.GetKey("g"))//sn�a leikmanni
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }
        if (Input.GetKey(KeyCode.Space))//hoppa
        {
            transform.position += transform.up * jump;
        }
        if (transform.position.y <= -1)
        {
            Endurr�sa();
        }
        if (Input.GetKey(KeyCode.UpArrow))//�fram
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))// til baka
        {
            transform.position += -transform.forward * speed;

        }
        if (Input.GetKey(KeyCode.RightArrow))//h�gri
        {
            transform.position += transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//vinstri
        {
            //hreyfir player um sideways � hvert skipti sem �tt er � leftArrow
            transform.position += -transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("b�mm");
            //Vector3 movement = new Vector3(0, 10, 0);
            transform.position += transform.up * jump;
        }
        if (transform.position.y <= -1)
        {
            Endurr�sa();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ef player keyrir � object sem heitir hlutur
        if (collision.collider.tag == "hlutur")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
            // Debug.Log("N� er �g komin me� " + count);
            SetCountText();//kallar � falli�
        }
        if (collision.collider.tag == "pikk")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 5;
            //Debug.Log("N� er �g komin me� " + count);
            SetCountText();//kallar � falli�
        }
        if (collision.collider.tag == "hindrun")
        {
            collision.collider.gameObject.SetActive(false);
            count = count - 1;
            //Debug.Log("N� er �g komin me� " + count);
            SetCountText();//kallar � falli�
        }
    }
    void SetCountText()
    {
        countText.text = "Stig: " + count.ToString();

        if (count <= 0)
        {
            this.enabled = false;//kemur � veg fyrir a� playerinn geti hreyfst �fram eftir dau�an
            countText.text = "Svo dau����������������ur " + count.ToString() + " stigum";

            StartCoroutine(Bida());

        }

    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(1);
        Endurr�sa();
    }

    public void Byrja()
    {
        SceneManager.LoadScene(1);
    }
    public void Endurr�sa()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Level_1
        SceneManager.LoadScene(0);
    }

}
