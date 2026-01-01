using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void RumusKubus(){
    SceneManager.LoadScene("RumusKubus");
   }

   public void RumusTabung(){
    SceneManager.LoadScene("RumusTabung");
   }

   public void RumusBola(){
    SceneManager.LoadScene("RumusBola");
   }
}
