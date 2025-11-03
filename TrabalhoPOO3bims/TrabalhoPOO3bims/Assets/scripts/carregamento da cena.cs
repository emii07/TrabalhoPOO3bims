using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
  public string NomedaCena;
  
  public void Carregar()
  {
     SceneManager.LoadScene(NomedaCena);
  }
}
