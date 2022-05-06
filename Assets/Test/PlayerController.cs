using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Item[] itemsToAdd;

    private Inventory myInventory = new Inventory(20);
    Camera cam; 
    Rigidbody myRigidbody;


    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float strafeSpeed = 3.0f;
    [SerializeField] private float rotationSpeed = 5.0f;

    float forwardMovement, sideMovement, rotationDeltaY, rotationDeltaX, rotX, rotY;

    private bool isOpen;

    private void Start()
    {
        foreach(Item item in itemsToAdd)
        {
            myInventory.addItem(new ItemStack(item, 1)); 
        }
    }


    
    // Start is called before the first frame update
    void start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKeyDown(KeyCode.E))
      {
                if(!isOpen)
                {
                    InventoryManager.INSTANCE.openContainer(new ContainerPlayerInventory(null, myInventory));
                    isOpen = true;
                }
                else 
                {
                    InventoryManager.INSTANCE.closeContainer(); 
                    isOpen = false; 
                }
      }
      if (Input.GetKeyDown(KeyCode.Escape))
      {
            if (isOpen)
            {
                InventoryManager.INSTANCE.closeContainer();
                isOpen = false;
            }
      }






        forwardMovement = Input.GetAxis("Vertical");
        sideMovement = Input.GetAxis("Horizontal");
        rotationDeltaY = Input.GetAxis("Mouse Y");
        rotationDeltaX = Input.GetAxis("Mouse X");

        rotX = rotX + rotationDeltaX;
        rotY = rotY + rotationDeltaY;


        transform.position = transform.position + (transform.forward * forwardMovement * speed * Time.deltaTime);
        transform.position = transform.position + (transform.right * sideMovement * strafeSpeed * Time.deltaTime); 

        transform.localRotation = Quaternion.Euler(new Vector3(0.0f, rotX, 0.0f));
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-rotY, 0.0f, 0.0f)); 
    }
}
