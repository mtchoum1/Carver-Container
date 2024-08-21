using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScreen : MonoBehaviour
{
    [SerializeField] private GameObject[] Obj;
    private string[] strScene, strAuthor;
    private List<string> option = new List<string>();
    private int[] gamenum = new int[4];
    private string path;
    private int startval = 0;
    private int loopval = 0;
    // Start is called before the first frame update
    void Start()
    {
        strScene = new string[40];
        strAuthor = new string[40];
        for (int i = 0; i < strScene.Length; i++)
        {
            try
            {
                string path = SceneUtility.GetScenePathByBuildIndex(i + 2);
                path = path.Replace(".unity", ".txt");
                using (StreamReader sr = new StreamReader(path))
                {
                    strScene[i] = sr.ReadLine();
                    strAuthor[i] = sr.ReadLine();
                    option.Add(strScene[i]);
                }
            }
            catch
            {
                strScene[i] = "Scene at index " + (i + 2) + " has no file";
                strAuthor[i] = "Scene at index " + (i + 2) + " has no file";
                option.Add(strScene[i]);
            }
        }
        Obj[4].gameObject.GetComponent<Button>().onClick.AddListener( delegate {Up();});
        Obj[5].gameObject.GetComponent<Button>().onClick.AddListener( delegate {Down();});
        Obj[10].gameObject.GetComponent<Button>().onClick.AddListener( delegate {pickGame(0);});
        Obj[11].gameObject.GetComponent<Button>().onClick.AddListener( delegate {pickGame(1);});
        Obj[12].gameObject.GetComponent<Button>().onClick.AddListener( delegate {pickGame(2);});
        Obj[13].gameObject.GetComponent<Button>().onClick.AddListener( delegate {pickGame(3);});
        Obj[14].gameObject.GetComponent<InputField>().onValueChanged.AddListener(delegate {Search(Obj[14].gameObject.GetComponent<InputField>().text);});
        // Obj[14].gameObject.GetComponent<InputField>().onEndEdit.AddListener(delegate {Show();});
    }

    // Update is called once per frame
    void Update()
    {
        loopval = Mathf.Abs(startval) % option.Count;
        for (int i = 0; i < 4; i++)
        {
            if (i < option.Count)
            {
                loopval = loopval % option.Count;
                for (int j = 0; j < strScene.Length; j++)
                {
                    if (option[loopval] == strScene[j])
                    {
                        path = SceneUtility.GetScenePathByBuildIndex(j + 2);
                        path = path.Replace(".unity", ".png");
                        Obj[i + 10].transform.GetChild(1).gameObject.GetComponent<RawImage>().texture = LoadPNG(path);
                    } 
                 }
                loopval++;
            }
        }
        loopval = Mathf.Abs(startval) % option.Count;
        for (int i = 0; i < 4; i++)
        {
            Obj[i].gameObject.GetComponent<Text>().text = "";
            try
            {
                if (i < option.Count)
                {
                    Obj[i + 10].gameObject.SetActive(true);
                    loopval = loopval % option.Count;
                    for (int j = 0; j < strScene.Length; j++)
                    {
                        if (option[loopval] == strScene[j] || option[loopval] == strAuthor[j])
                        {
                            path = SceneUtility.GetScenePathByBuildIndex(j + 2);
                            path = path.Replace(".unity", ".txt");
                            int count = 0;
                            using (StreamReader sr = new StreamReader(path))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    if (count != 1)
                                    {
                                        Obj[i].gameObject.GetComponent<Text>().text += line + "\n";
                                    }
                                    else
                                    {
                                        Obj[i].gameObject.GetComponent<Text>().text += "Created By: " + line + "\n";
                                    }
                                    count++;
                                }
                            }
                            gamenum[i] = j + 2;  
                        } 
                    }
                    loopval++;
                }
                else
                {
                    Obj[i + 10].gameObject.SetActive(false);
                }
            }
            catch
            {
                loopval = loopval % option.Count;
                for (int j = 0; j < strScene.Length; j++)
                {
                    if (option[loopval] == strScene[j])
                    {
                        Obj[i].gameObject.GetComponent<Text>().text = "Scene at index " + (j + 2) + " has no file";
                        gamenum[i] = j + 2;  
                    } 
                }
                loopval++;
            }
        }
    }

    public void pickGame(int x)
    {
        SceneManager.LoadScene(gamenum[x]);
        Brain.isPlay = false;
    }

    public void Up()
    {
        startval++;
    }

    public void Down()
    {
        startval--;
    }

    public void Search(string str)
    {
        option.Clear();
        string strTest = "";
        string strList = "";
        string strAList = "";
        for (int i = 0; i < strScene.Length; i++)
        {
            strList = strScene[i].ToUpper();
            strTest = str.ToUpper();
            strAList = strAuthor[i].ToUpper();
            if (strList.Contains(strTest))
            {
                option.Add(strScene[i]);
            }
            else if (strAList.Contains(strTest) && !strList.Contains(strTest))
            {
                option.Add(strAuthor[i]);
            }
        }
        startval = 0;
    }

    public static Texture2D LoadPNG(string filePath) 
    {
        Texture2D tex = null;
        byte[] fileData;
        if (File.Exists(filePath))     
        {
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        else
        {
            fileData = File.ReadAllBytes("Assets/Main.png");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
        }
        return tex;
    }
}
