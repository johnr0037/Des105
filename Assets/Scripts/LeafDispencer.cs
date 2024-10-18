using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDispencer : MonoBehaviour
{
    public GameObject leaf;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
       
     
=======
        Instantiate(leaf,transform.position,transform.rotation);
>>>>>>> 9d659f70407373b2503e3ebec15d2fd7789124e2
    }


    /*------- Challenge 1 ------- Beginner -------
     * 1. Move the check key if statement into a seperate function for checking keys
     * 2. Create a new function called SpawnLeaf
     * 3. Move the instantiate code to that function
     * 4. call the SpawnLeaf function from CheckInput function you created in step 1.
     */
    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        CheckKeys();
       
        //Instantiate()
    }
    public void CheckKeys()
    {
        if (Input.GetKey(KeyCode.L))
        {
            Instantiate(leaf, transform.position, transform.rotation);
        }
        SpawnLeaf();
    }
    public void SpawnLeaf()
    {
        Instantiate(leaf, transform.position, transform.rotation);
=======
        if(Input.GetKey(KeyCode.L))
        {
            Instantiate(leaf, transform.position, transform.rotation);
        }

        //Instantiate()
>>>>>>> 9d659f70407373b2503e3ebec15d2fd7789124e2
    }
}
