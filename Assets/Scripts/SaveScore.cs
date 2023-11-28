using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveScore : MonoBehaviour
{
    string json;
    private class score
    {
        public int kills;
    }

    private void Start()
    {
        Application.targetFrameRate = 300;
    }
    public void save(int killcount)
    {
        if (dataTransfer.health == 200)
        {
            score core = new score();
            core.kills = killcount;
            json = JsonUtility.ToJson(core);
            File.WriteAllText(Application.dataPath + "/200.json", json);
        }
        else if (dataTransfer.health == 300)
        {
            score core = new score();
            core.kills = killcount;
            json = JsonUtility.ToJson(core);
            File.WriteAllText(Application.dataPath + "/300.json", json);
        }
        else if (dataTransfer.health == 400)
        {
            score core = new score();
            core.kills = killcount;
            json = JsonUtility.ToJson(core);
            File.WriteAllText(Application.dataPath + "/400.json", json);
        }
        else if (dataTransfer.health == 500)
        {
            score core = new score();
            core.kills = killcount;
            json = JsonUtility.ToJson(core);
            File.WriteAllText(Application.dataPath + "/500.json", json);
        }
        else if (dataTransfer.health == 700)
        {
            score core = new score();
            core.kills = killcount;
            json = JsonUtility.ToJson(core);
            File.WriteAllText(Application.dataPath + "/700.json", json);
        }
    }

    public int Load()
    {
        if (dataTransfer.health == 200)
        {
            try
            {
                json = File.ReadAllText(Application.dataPath + "/200.json");
                score data = JsonUtility.FromJson<score>(json);
                return data.kills;
            }
            catch
            {
                return 0;
            }
        }
        else if (dataTransfer.health == 300)
        {
            try
            {
                json = File.ReadAllText(Application.dataPath + "/300.json");
                score data = JsonUtility.FromJson<score>(json);
                return data.kills;
            }
            catch
            {
                return 0;
            }
        }
        else if (dataTransfer.health == 400)
        {
            try
            {
                json = File.ReadAllText(Application.dataPath + "/400.json");
                score data = JsonUtility.FromJson<score>(json);
                return data.kills;
            }
            catch
            {
                return 0;
            }
        }
        else if (dataTransfer.health == 500)
        {
            try
            {
                json = File.ReadAllText(Application.dataPath + "/500.json");
                score data = JsonUtility.FromJson<score>(json);
                return data.kills;
            }
            catch
            {
                return 0;
            }
        }
        else if (dataTransfer.health == 700)
        {
            try
            {
                json = File.ReadAllText(Application.dataPath + "/700.json");
                score data = JsonUtility.FromJson<score>(json);
                return data.kills;
            }
            catch
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
       
    }


}