using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Consts.WheatType.GOLD_WHEAT))
        {
            other.gameObject?.GetComponent<GoldWheatCollectible>().Collect();
        }
        if (other.CompareTag(Consts.WheatType.HOLY_WHEAT))
        {
            other.gameObject?.GetComponent<HolyWheatCollectible>().Collect();
        }
        if (other.CompareTag(Consts.WheatType.ROTTEN_WHEAT))
        {
            other.gameObject?.GetComponent<RottenWheatCollectible>().Collect();
        } 
    }
}
