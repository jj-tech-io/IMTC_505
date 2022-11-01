using UnityEngine;

public class Changer : MonoBehaviour
 {
     [SerializeField] GameObject[] targets;
     GameObject currentTarget;
     public int targetIndex = 0;
 
 
     void Start()
     {
        foreach (GameObject target in targets) {
            target.SetActive(false);
        }
         ChangeTarget();
     }
 
 
     public void ChangeTarget()
     {
         if (targets.Length > targetIndex)
         {
             if (currentTarget != null)
             {
                 currentTarget.SetActive(false);
             }
 
             currentTarget = targets[targetIndex];
             currentTarget.SetActive(true);
             targetIndex++;
         }
         else 
         {
             currentTarget.SetActive(false);
             targetIndex = 0;
         }
     }
 
 
 }