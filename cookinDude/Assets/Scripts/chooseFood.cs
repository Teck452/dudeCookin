using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseFood : MonoBehaviour
{
    public bool aMeat;
    public bool bMeat;
    public bool cMeat;
    public bool aSpice;
    public bool bSpice;
    public int choice;
    public float cool;
    public bool running = false;

    public bool gChick;
    public bool sChick;
    public bool gPork;
    public bool sPork;
    public bool gSteak;
    public bool sSteak;

    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetInteger("choice", choice);

        animator.SetBool("gChick", gChick);
        animator.SetBool("sChick", sChick);
        animator.SetBool("gPork", gPork);
        animator.SetBool("sPork", sPork);
        animator.SetBool("gSteak", gSteak);
        animator.SetBool("sSteak", sSteak);

        if (cool == 0)
        {



            if (Input.GetKeyDown("left") && choice == 1)
            {
                aSpice = true;
                choice++;
            }

            if (Input.GetKeyDown("right") && choice == 1)
            {
                bSpice = true;
                choice++;
            }
            if (Input.GetKeyDown("left") && choice == 0)
            {
                aMeat = true;
                choice++;
            }

            if (Input.GetKeyDown("up") && choice == 0)
            {
                bMeat = true;
                choice++;
            }

            if (Input.GetKeyDown("right") && choice == 0)
            {
                cMeat = true;
                choice++;
            }


            if (choice == 2 && aMeat && aSpice)
            {
                
                aMeat = false;
                aSpice = false;

                cool = 5;
                running = true;

                gChick = true;
            }

            if (choice == 2 && bMeat && aSpice)
            {
               
                bMeat = false;
                aSpice = false;

                cool = 5;
                running = true;

                gSteak = true;
            }

            if (choice == 2 && cMeat && aSpice)
            {
                
                cMeat = false;
                aSpice = false;

                cool = 5;
                running = true;

                gPork = true;
            }

            if (choice == 2 && aMeat && bSpice)
            {
                
                aMeat = false;
                bSpice = false;

                cool = 5;
                running = true;

                sChick = true;
            }

            if (choice == 2 && bMeat && bSpice)
            {
               
                bMeat = false;
                bSpice = false;

                cool = 5;
                running = true;

                sSteak = true;
            }

            if (choice == 2 && cMeat && bSpice)
            {
                
                cMeat = false;
                bSpice = false;

                cool = 5;
                running = true;

                sPork = true;
            }
        }
   
        if (running)
        {
            if (cool > 0)
            {
                cool -= Time.deltaTime;
            }
            else
            {
                choice = 0;
                cool = 0;
                running = false;

                gChick = false;
                sChick = false;
                gSteak = false;
                sSteak = false;
                gPork = false;
                sPork = false;
            }

        }


    }
}
