using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Elevator : MonoBehaviour
{ //I had no time to finish this :(
// great architecture and research around collections!!
    // Start is called before the first frame update
    void Start()
    {
        int peopleInElevator = 0;
        int currentWeight = 0;
        int maxWeight = 300;
        int currentFloor = 3;
        int firstFLoorPressed;
        bool isGoingUp = true;
        int elevatorDirection = 0;
        int[] goalFloors = new int[] { 1, 5, 6 };

        PersonGetsIn(peopleInElevator);
        Debug.Log($"A person got on! There are {peopleInElevator} people on board.");

    }

    static int PersonGetsIn(int peopleInElevator)
    {
        peopleInElevator++;
        Debug.Log($"One person went on. There are {peopleInElevator} people in the elevator.");
        return peopleInElevator;
    }
    static int PersonGetsOut(int peopleInElevator)
    {
        if (peopleInElevator > 0)
        {
            peopleInElevator--;
            Debug.Log($"One person went off. There are {peopleInElevator} people in the elevator.");
            return peopleInElevator;
        }
        else
            return peopleInElevator;
    }

    static bool IsGoingUp(int currentFloor, int firstFloorPressed)
    {
        int elevatorWay = currentFloor - firstFloorPressed;
        if (elevatorWay > 0)
        {
            return true;
        }
        else
            return false;
    }
   /* Had no time to finish this one :(
    * 
    * static int[] CreateFloorSequence(int[] floorsPressed, bool isGoingUp, int currentFloor)
    {
        int[] goingUpSequence  = new int[floorsPressed.Length];
        int[] goingDownSequence = new int[floorsPressed.Length];

        if(isGoingUp)
        {
            for (int i = 0; i < floorsPressed.Length; i++)
            {
                if(floorsPressed[i] >= currentFloor)
                {
                    goingUpSequence.add = floorsPressed[i];  
                }
            }
            Array.Sort(goingUpSequence);
            return goingUpSequence;
        }

        else
        {
            for (int i = 0; i < floorsPressed.Length; i++)
            {
                if (floorsPressed[i] < currentFloor)
                {
                    goingDownSequence[i] = floorsPressed[i];
                }
            }
            Array.Sort(goingDownSequence);
            Array.Reverse(goingDownSequence);
            return goingDownSequence;        
        }
    }
*/


    static int AddWeight(int personWeight, int currentWeight)
    {
        int totalWeight = currentWeight + personWeight;
        Debug.Log($"The total weight in the elevator is {totalWeight}.");
        return totalWeight;
    }
    static int RemoveWeight(int personWeight, int currentWeight)
    {
        int totalWeight = currentWeight - personWeight;
        Debug.Log($"The total weight in the elevator is {totalWeight}.");
        return totalWeight;
    }

}
