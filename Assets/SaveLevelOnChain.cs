using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using UnityEngine.UI;

public class SaveLevelOnChain : MonoBehaviour
{
    public Button nextButton;
    public Text nextButtonText;
    public Button homeButton;

    private EndgameView endgameView;

    public async void SaveLevelForPlayer()
    {
        nextButton.interactable = false;
        homeButton.interactable = false;
        nextButtonText.text = "Saving...";
        string address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
        var contract = ThirdwebManager.Instance.SDK.GetContract(ContractConfig.LEVEL_CONTRACT, ContractConfig.LEVEL_CONTRACT_ABI);
        int CurrentLevel = PlayerPrefs.GetInt(PlayerPrefsKey.LEVEL_KEY, 1);
        await contract.Write("updateLevel", CurrentLevel);
        Debug.Log("Level Saved");
        nextButtonText.text = "NEXT LEVEL";
        nextButton.interactable = true;
        homeButton.interactable = true;

        // Find the GameObject with the tag "EndGameView"
        GameObject endgameViewObject = GameObject.FindWithTag("EndGameView");
        if (endgameViewObject != null)
        {
            // Get the EndgameView component from the GameObject
            endgameView = endgameViewObject.GetComponent<EndgameView>();
            if (endgameView != null)
            {
                // Call the OnClickNextLevelButton method
                endgameView.OnClickNextLevelButton();
            }
            else
            {
                Debug.LogError("EndgameView component not found!");
            }
        }
        else
        {
            Debug.LogError("EndgameView GameObject with tag 'EndGameView' not found!");
        }
    }
}
