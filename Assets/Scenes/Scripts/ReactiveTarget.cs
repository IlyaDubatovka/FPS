using System.Collections;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
    public void ReactToHit() {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null) {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());

    } 
}
