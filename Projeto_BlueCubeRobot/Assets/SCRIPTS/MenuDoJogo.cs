using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDoJogo : MonoBehaviour
{
    
     public void ChamaCena1() {
          SceneManager.LoadScene ("cena1");
     }

     public void ChamaMenu() {
          SceneManager.LoadScene ("cenaMENU");
     }

} // fecha public class (o script)
