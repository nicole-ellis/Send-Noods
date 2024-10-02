using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue_Manager : MonoBehaviour
{
    /// <summary>
    /// dialogue text file
    /// </summary>
    public TextAsset dialogueDataFile;

    /// <summary>
    /// customer sprite
    /// </summary>
    public SpriteRenderer customerSprite;


    /// <summary>
    /// character name text
    /// </summary>    
    public TMP_Text nameText;

    /// <summary>
    /// dialogue text
    /// </summary>
    public TMP_Text dialogueText;

    /// <summary>
    /// save current dialogue id
    /// </summary>
    public int dialogueIndex;

    /// <summary>
    /// dialogue text split by rows
    /// </summary>
    public string[] dialogueRows;

    public Button nextButton;

    public GameObject optionButton;
    public Transform buttonGroup;

    // Start is called before the first frame update
    void Start()
    {
        ReadText(dialogueDataFile);
        ShowDialogueRow();
        // UpdateText("Yukio","Hello!Nice to see you.");
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void UpdateText(string _name, string _text){
        nameText.text = _name;
        dialogueText.text = _text;
    }

    public void ReadText(TextAsset _textAsset){
        dialogueRows = _textAsset.text.Split('\n');
        // foreach (var row in rows)
        // {
        //     string[] cell = row.Split(',');
        // }
        Debug.Log("Read Correctly");

    }

    public void ShowDialogueRow(){
        for (int i = 0; i < dialogueRows.Length; i++)
        {
            string[] cells = dialogueRows[i].Split(',');
            if (cells[0] == "#" && int.Parse(cells[1])==dialogueIndex)
            {
                UpdateText(cells[2],cells[4]);

                dialogueIndex = int.Parse(cells[5]);
                nextButton.gameObject.SetActive(true);
                break;
            }
            else if (cells[0] == "&" && int.Parse(cells[1])==dialogueIndex)
            {
                nextButton.gameObject.SetActive(false);
                GenerateOption(i);
            }
            else if(cells[0] == "END" && int.Parse(cells[1])==dialogueIndex){
                Debug.Log("Game End");
            }
        }
    }

    public void OnClickNext(){
        ShowDialogueRow();
    }

    public void GenerateOption(int _index){
        string[] cells = dialogueRows[_index].Split(',');
        if (cells[0] == "&"){
            GameObject button = Instantiate(optionButton, buttonGroup);
            // bound to button event
            button.GetComponentInChildren<TMP_Text>().text = cells[4];
            button.GetComponent<Button>().onClick.AddListener(delegate {OnClickOption(int.Parse(cells[5]));});
            GenerateOption(_index + 1);
        }
    }

    public void OnClickOption(int _id){
        dialogueIndex = _id;
        ShowDialogueRow();
        for (int i = 0; i < buttonGroup.childCount; i++)
        {
            Destroy(buttonGroup.GetChild(i).gameObject);
        }
    }
}
