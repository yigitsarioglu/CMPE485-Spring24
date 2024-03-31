using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float pushForce = 500f; // İtme kuvveti
    

    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        characterController.Move(moveDirection * Time.deltaTime);  
    }



     

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collison occured");
        if (collision.gameObject.CompareTag("keyobject")) // Eğer çarpışan nesne "Top" etiketine sahipse
        {
            Rigidbody topRigidbody = collision.gameObject.GetComponent<Rigidbody>(); // Çarpışma yaşanan nesnenin Rigidbody bileşeni
            if (topRigidbody != null)
            {
                topRigidbody.AddForce(transform.forward * pushForce, ForceMode.Impulse); // İleri yönde itme kuvveti uygula
                Debug.Log("Topa itme işlemi gerçekleştirildi!"); // Çarpışma algılandığında bir yazdırma işlemi
            }
        }
    }
}